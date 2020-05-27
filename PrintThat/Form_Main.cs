using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PrintThat
{
    public partial class Form_Main : Form
    {
        bool gloabl_startAppWithMinimizing = false;

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.F5: { CheckDirectory(); break; }
                case Keys.F1: { new Form_About().ShowDialog(); break; }
                case Keys.Escape:
                    {
                        this.Hide();
                        notifyIcon_main.Visible = true;
                        notifyIcon_main.ShowBalloonTip(50, "Распечатка", "Приложение свёрнуто в трей", ToolTipIcon.Info);
                        break;
                    }
            }
        }




        public Form_Main(bool StartAppWithMinimizing = false)
        {
            InitializeComponent();

            var names = typeof(Program).Assembly.GetName();
            this.Text += " v" + names.Version.ToString();

            button_multiplier.Text = "=" + Configs.PrintCount.ToString();
            
            gloabl_startAppWithMinimizing = StartAppWithMinimizing;

            //panel1_Resize(null, null);

            string txt = string.Empty;
            foreach (string format in FileFunctions.AvaliableFormats)
            {
                txt += format + ", ";
            }
            label_formats.Text += " " + txt.Remove(txt.Length - 2) + ".";

            toolStripStatusLabel_f1.Click += (ss, ee) => { new Form_About().ShowDialog(); };
        }

        private void button_from_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) { return; }
            textBox_from.Text = Configs.TargetPath = dialog.SelectedPath;

            CheckDirectory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_from.Text = Configs.TargetPath;

            checkBox_autostart.Checked = AutoStart.isAutostarts;
            this.checkBox_autostart.CheckedChanged += this.checkBox_autostart_CheckedChanged;

            checkBox_autoCheck.Checked = Configs.AutoCheck;
            this.checkBox_autoCheck.CheckedChanged += CheckBox_autoCheck_CheckedChanged;

            checkBox_recyrentSearch.Checked = Configs.RecSearch;
            this.checkBox_recyrentSearch.CheckedChanged += (ss, ee) => { Configs.RecSearch = checkBox_recyrentSearch.Checked; };

            checkBox_logging.Checked = Configs.Logging;
            this.checkBox_logging.CheckedChanged += (ss, ee) => { Configs.Logging = checkBox_logging.Checked; };

            numericUpDown_multi.Value = Configs.PrintCount;
            this.numericUpDown_multi.ValueChanged += (ss, ee) =>
            {
                Configs.PrintCount = (Int16)numericUpDown_multi.Value;
                this.button_multiplier.Text = "=" + Configs.PrintCount.ToString();
            };


            button_properties.PerformClick();
        }

        Timer timer_checker;
        private void CheckBox_autoCheck_CheckedChanged(object sender, EventArgs e)
        {
            Configs.AutoCheck = checkBox_autoCheck.Checked;

            if (Configs.AutoCheck)
            {
                timer_checker = new Timer();
                timer_checker.Tick += (ss, ee) => { CheckDirectory(); };
                timer_checker.Interval = 60 * 1000;
                timer_checker.Enabled = true;
                timer_checker.Start();
            }
            else
            {
                timer_checker.Stop();
                timer_checker.Enabled = false;
                timer_checker.Dispose();
                timer_checker = null;
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Configs.TargetPath))
            {
                MessageBox.Show("Целевая папка не существует.", "Внмание", MessageBoxButtons.OK);
                return;
            }

            if (dgv.RowCount == 0)
            {
                MessageBox.Show("Нет доступных файлов для печати.", "Внмание", MessageBoxButtons.OK);
                return;
            }

            #region check copy counts
            int tmp_i;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!int.TryParse(row.Cells[Column_Count.Index].Value.ToString(), out tmp_i))
                {
                    MessageBox.Show("Не целое число копий.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            #endregion

            List<cDGVRow> files = new List<cDGVRow>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!bool.Parse(row.Cells[Column_Check.Index].Value.ToString())) { continue; }

                files.Add(new cDGVRow()
                {
                    Count = int.Parse(row.Cells[Column_Count.Index].Value.ToString()),
                    FileName = row.Cells[Column_File.Index].Value.ToString(),
                    FilePath = row.Cells[Column_Path.Index].Value.ToString(),
                    isChecked = true
                });
            }

            files.Print();
           
            MessageBox.Show($"Печать документов окончена в количестве {files.Count}");

            files = null;
        }

        private void checkBox_autostart_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_autostart.Checked != AutoStart.isAutostarts)
                {
                    AutoStart.SetAutostart(checkBox_autostart.Checked, Application.ExecutablePath.ToString());
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Неавторизированный доступ к реестру.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            CheckDirectory();
        }

        private void CheckDirectory()
        {
            dgv.Rows.Clear();

            if (!System.IO.Directory.Exists(Configs.TargetPath)) { return; }

            string txt = button_print.Text;
            button_print.Text = "Обновление";
            button_print.Enabled = false;

            var files = FileFunctions.GetAvaliableFilesByDirectory(Configs.TargetPath, Configs.RecSearch);

            string file_name;
            foreach (var file in files)
            {
                file_name = file.Split('\\').Last();
                dgv.Rows.Add(null,true, file_name, file, 1);
            }
            files = null;

            button_print.Text = txt;
            button_print.Enabled = true;

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.CurrentRow.Cells[Column_Check.Index].Value = !(bool)dgv.CurrentRow.Cells[Column_Check.Index].Value;
            }
        }

        void HideRules()
        {
            this.ShowInTaskbar = false;
            this.Hide();
            notifyIcon_main.Visible = true;
        }

        void ShowRules()
        {
            this.TopMost = true;
            this.ShowInTaskbar = true;
            this.Show();
            this.Focus();
            notifyIcon_main.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            HideRules();
        }





        private void notifyIcon_main_DoubleClick(object sender, EventArgs e) =>ShowRules();
        

        private void toolStripMenuItem_show_Click(object sender, EventArgs e) => ShowRules();
        

        private void toolStripMenuItem_updateNprint_Click(object sender, EventArgs e)
        {
            CheckDirectory();
            button_print.PerformClick();
        }

        private void toolStripMenuItem_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.ExitThread();
        }

        private void button_properties_Click(object sender, EventArgs e)
        {
            panel_properties.Visible = !panel_properties.Visible;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (gloabl_startAppWithMinimizing) { HideRules(); }
            else { notifyIcon_main.Visible = false; }
        }

        //private void Common_DragEnter(object sender, DragEventArgs e)
        //{
        //    DragDropEffects effects = DragDropEffects.None;
        //    string path;

        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        //        if (Directory.Exists(path) || File.Exists(path)) { effects = DragDropEffects.Copy; }
        //    }
        //    path = string.Empty;

        //    e.Effect = effects;
        //}

        //private void Common_DragDrop(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        //TODO: можно сделать и для отдельного файла и кинуть в поток
        //        string some_obj = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        //        if (Directory.Exists(some_obj)) { FileFunctions.PrintFolder(some_obj); }
        //        else if (File.Exists(some_obj)) { some_obj.Print(); }
        //    }
        //}

        #region DGV

        private void dgv_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            string path;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path)) { effects = DragDropEffects.Copy; }
            }
            path = string.Empty;

            e.Effect = effects;
        }

        private void dgv_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //TODO: можно сделать и для отдельного файла и кинуть в поток
                string folder = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (!Directory.Exists(folder)) { return; }

                Configs.TargetPath = textBox_from.Text = folder;

                CheckDirectory();
            }
        }

        #endregion

        cDGVRow RowToStruct(DataGridViewRow row)
        {
            return new cDGVRow()
            {
                Count = int.Parse(row.Cells[Column_Count.Index].Value.ToString()),
                FileName = row.Cells[Column_File.Index].Value.ToString(),
                FilePath = row.Cells[Column_Path.Index].Value.ToString(),
                isChecked = bool.Parse(row.Cells[Column_Check.Index].Value.ToString())
            };
        }
        void SetStructintoRow(DataGridViewRow row, cDGVRow s_row)
        {
            row.Cells[Column_Count.Index].Value = s_row.Count;
            row.Cells[Column_File.Index].Value = s_row.FileName;
            row.Cells[Column_Path.Index].Value = s_row.FilePath;
            row.Cells[Column_Check.Index].Value = s_row.isChecked;
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                if (e.KeyCode.Equals(Keys.Up))
                {
                    if (dgv.CurrentRow.Index == 0) { return; }

                    int indx = dgv.CurrentRow.Index;

                    var cur_Row = RowToStruct(dgv.CurrentRow);
                    var upper_Row = RowToStruct(dgv.Rows[indx - 1]);

                    SetStructintoRow(dgv.Rows[indx], upper_Row);
                    SetStructintoRow(dgv.Rows[indx - 1], cur_Row);

                    dgv.CurrentCell = dgv.Rows[indx - 1].Cells[0];
                }
                else if (e.KeyCode.Equals(Keys.Down))
                {
                    if (dgv.CurrentRow.Index + 1 == dgv.RowCount) { return; }

                    int indx = dgv.CurrentRow.Index;

                    var cur_Row = RowToStruct(dgv.CurrentRow);
                    var down_Row = RowToStruct(dgv.Rows[indx + 1]);

                    SetStructintoRow(dgv.Rows[indx], down_Row);
                    SetStructintoRow(dgv.Rows[indx + 1], cur_Row);

                    dgv.CurrentCell = dgv.Rows[indx + 1].Cells[0];

                }
                e.Handled = true;
            }
        }





        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            string path;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path)) { effects = DragDropEffects.Copy; }
                else if (File.Exists(path) && _isAvailableformat(path)) { effects = DragDropEffects.Copy; }
            }
            path = string.Empty;

            e.Effect = effects;
        }

        bool _isAvailableformat(string file)
        {
            string format = file.Split('.').Last();
            return FileFunctions.AvaliableFormats.Contains(format);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string some_obj = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(some_obj)) { FileFunctions.PrintFolder(some_obj); }
                else if (File.Exists(some_obj)) { some_obj.Print(); }
            }
        }

        //private void panel1_Resize(object sender, EventArgs e)
        //{
        //    //label_on_panel.Location = new Point((panel1.Width - label_on_panel.Width) / 2, (panel1.Height - label_on_panel.Height) / 2);
        //}

        private void button_multiplier_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                string value = Configs.PrintCount.ToString();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells[Column_Count.Index].Value = value;
                }
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                if (e.ColumnIndex == Column_Del.Index)
                {
                    dgv.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button_printers_Click(object sender, EventArgs e)
        {
            var printers = new Form_Printers();
            if(printers.ShowDialog() != DialogResult.OK) {return;}


        }
    }
}
