namespace PrintThat
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_f1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_checker = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon_main = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_updateNprint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_close = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_properties = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_multi = new System.Windows.Forms.NumericUpDown();
            this.checkBox_logging = new System.Windows.Forms.CheckBox();
            this.checkBox_recyrentSearch = new System.Windows.Forms.CheckBox();
            this.label_formats = new System.Windows.Forms.Label();
            this.checkBox_autoCheck = new System.Windows.Forms.CheckBox();
            this.checkBox_autostart = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_from = new System.Windows.Forms.Button();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_printers = new System.Windows.Forms.Button();
            this.button_multiplier = new System.Windows.Forms.Button();
            this.button_properties = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column_Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_multi)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_f1,
            this.label_status,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 290);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(434, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_f1
            // 
            this.toolStripStatusLabel_f1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel_f1.Name = "toolStripStatusLabel_f1";
            this.toolStripStatusLabel_f1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel_f1.Text = "[F1] - Справка";
            // 
            // label_status
            // 
            this.label_status.BackColor = System.Drawing.SystemColors.Control;
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(202, 17);
            this.label_status.Text = "[Esc] - свернуть приложение в трей";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "by ARt";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_checker
            // 
            this.timer_checker.Interval = 60000;
            // 
            // notifyIcon_main
            // 
            this.notifyIcon_main.BalloonTipText = "Программа для массовой печати документов";
            this.notifyIcon_main.BalloonTipTitle = "Распечатка";
            this.notifyIcon_main.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon_main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_main.Icon")));
            this.notifyIcon_main.Text = "Распечатка";
            this.notifyIcon_main.DoubleClick += new System.EventHandler(this.notifyIcon_main_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_show,
            this.toolStripMenuItem_updateNprint,
            this.toolStripSeparator1,
            this.toolStripMenuItem_close});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 76);
            // 
            // toolStripMenuItem_show
            // 
            this.toolStripMenuItem_show.Image = global::PrintThat.Properties.Resources.window_dialog;
            this.toolStripMenuItem_show.Name = "toolStripMenuItem_show";
            this.toolStripMenuItem_show.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem_show.Text = "Показать приложение";
            this.toolStripMenuItem_show.Click += new System.EventHandler(this.toolStripMenuItem_show_Click);
            // 
            // toolStripMenuItem_updateNprint
            // 
            this.toolStripMenuItem_updateNprint.Enabled = false;
            this.toolStripMenuItem_updateNprint.Image = global::PrintThat.Properties.Resources.keyboard_key_enter;
            this.toolStripMenuItem_updateNprint.Name = "toolStripMenuItem_updateNprint";
            this.toolStripMenuItem_updateNprint.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem_updateNprint.Text = "Обновить список и распечатать";
            this.toolStripMenuItem_updateNprint.Click += new System.EventHandler(this.toolStripMenuItem_updateNprint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // toolStripMenuItem_close
            // 
            this.toolStripMenuItem_close.Image = global::PrintThat.Properties.Resources.door_open;
            this.toolStripMenuItem_close.Name = "toolStripMenuItem_close";
            this.toolStripMenuItem_close.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem_close.Text = "Закрыть приложени";
            this.toolStripMenuItem_close.Click += new System.EventHandler(this.toolStripMenuItem_close_Click);
            // 
            // panel_properties
            // 
            this.panel_properties.BackColor = System.Drawing.Color.White;
            this.panel_properties.Controls.Add(this.label2);
            this.panel_properties.Controls.Add(this.numericUpDown_multi);
            this.panel_properties.Controls.Add(this.checkBox_logging);
            this.panel_properties.Controls.Add(this.checkBox_recyrentSearch);
            this.panel_properties.Controls.Add(this.label_formats);
            this.panel_properties.Controls.Add(this.checkBox_autoCheck);
            this.panel_properties.Controls.Add(this.checkBox_autostart);
            this.panel_properties.Controls.Add(this.label1);
            this.panel_properties.Controls.Add(this.button_from);
            this.panel_properties.Controls.Add(this.textBox_from);
            this.panel_properties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_properties.Location = new System.Drawing.Point(0, 111);
            this.panel_properties.Name = "panel_properties";
            this.panel_properties.Size = new System.Drawing.Size(434, 179);
            this.panel_properties.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Множитель количества копий ";
            // 
            // numericUpDown_multi
            // 
            this.numericUpDown_multi.Location = new System.Drawing.Point(267, 49);
            this.numericUpDown_multi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_multi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_multi.Name = "numericUpDown_multi";
            this.numericUpDown_multi.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_multi.TabIndex = 10;
            this.numericUpDown_multi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkBox_logging
            // 
            this.checkBox_logging.AutoSize = true;
            this.checkBox_logging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_logging.Location = new System.Drawing.Point(6, 141);
            this.checkBox_logging.Name = "checkBox_logging";
            this.checkBox_logging.Size = new System.Drawing.Size(295, 17);
            this.checkBox_logging.TabIndex = 8;
            this.checkBox_logging.Text = "Логгирование распечатанных фалов (имена файлов)";
            this.checkBox_logging.UseVisualStyleBackColor = true;
            // 
            // checkBox_recyrentSearch
            // 
            this.checkBox_recyrentSearch.AutoSize = true;
            this.checkBox_recyrentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_recyrentSearch.Location = new System.Drawing.Point(6, 118);
            this.checkBox_recyrentSearch.Name = "checkBox_recyrentSearch";
            this.checkBox_recyrentSearch.Size = new System.Drawing.Size(238, 17);
            this.checkBox_recyrentSearch.TabIndex = 7;
            this.checkBox_recyrentSearch.Text = "Рекурсивный поиск файлов внутри папки";
            this.checkBox_recyrentSearch.UseVisualStyleBackColor = true;
            // 
            // label_formats
            // 
            this.label_formats.AutoSize = true;
            this.label_formats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_formats.Location = new System.Drawing.Point(3, 161);
            this.label_formats.Name = "label_formats";
            this.label_formats.Size = new System.Drawing.Size(191, 16);
            this.label_formats.TabIndex = 6;
            this.label_formats.Text = "Поддерживаемые форматы:";
            // 
            // checkBox_autoCheck
            // 
            this.checkBox_autoCheck.AutoSize = true;
            this.checkBox_autoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_autoCheck.Location = new System.Drawing.Point(6, 72);
            this.checkBox_autoCheck.Name = "checkBox_autoCheck";
            this.checkBox_autoCheck.Size = new System.Drawing.Size(173, 17);
            this.checkBox_autoCheck.TabIndex = 5;
            this.checkBox_autoCheck.Text = "Автоматическое обновление";
            this.checkBox_autoCheck.UseVisualStyleBackColor = true;
            this.checkBox_autoCheck.CheckedChanged += new System.EventHandler(this.CheckBox_autoCheck_CheckedChanged);
            // 
            // checkBox_autostart
            // 
            this.checkBox_autostart.AutoSize = true;
            this.checkBox_autostart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_autostart.Location = new System.Drawing.Point(6, 95);
            this.checkBox_autostart.Name = "checkBox_autostart";
            this.checkBox_autostart.Size = new System.Drawing.Size(204, 17);
            this.checkBox_autostart.TabIndex = 4;
            this.checkBox_autostart.Text = "Автозагрузка со стартом системы";
            this.checkBox_autostart.UseVisualStyleBackColor = true;
            this.checkBox_autostart.CheckedChanged += new System.EventHandler(this.checkBox_autostart_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка, из которой должны быть распечатаны документы";
            // 
            // button_from
            // 
            this.button_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_from.Location = new System.Drawing.Point(393, 21);
            this.button_from.Name = "button_from";
            this.button_from.Size = new System.Drawing.Size(35, 22);
            this.button_from.TabIndex = 4;
            this.button_from.Text = "...";
            this.button_from.UseVisualStyleBackColor = true;
            this.button_from.Click += new System.EventHandler(this.button_from_Click);
            // 
            // textBox_from
            // 
            this.textBox_from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_from.BackColor = System.Drawing.Color.White;
            this.textBox_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_from.Location = new System.Drawing.Point(6, 21);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.ReadOnly = true;
            this.textBox_from.Size = new System.Drawing.Size(381, 22);
            this.textBox_from.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Linen;
            this.panel_main.Controls.Add(this.button_printers);
            this.panel_main.Controls.Add(this.button_multiplier);
            this.panel_main.Controls.Add(this.button_properties);
            this.panel_main.Controls.Add(this.button_refresh);
            this.panel_main.Controls.Add(this.button_print);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_main.Location = new System.Drawing.Point(0, 75);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(434, 36);
            this.panel_main.TabIndex = 14;
            // 
            // button_printers
            // 
            this.button_printers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_printers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_printers.Image = global::PrintThat.Properties.Resources.receipt_printer;
            this.button_printers.Location = new System.Drawing.Point(213, 3);
            this.button_printers.Name = "button_printers";
            this.button_printers.Size = new System.Drawing.Size(30, 30);
            this.button_printers.TabIndex = 13;
            this.button_printers.UseVisualStyleBackColor = true;
            this.button_printers.Click += new System.EventHandler(this.button_printers_Click);
            // 
            // button_multiplier
            // 
            this.button_multiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiplier.Location = new System.Drawing.Point(3, 3);
            this.button_multiplier.Name = "button_multiplier";
            this.button_multiplier.Size = new System.Drawing.Size(30, 30);
            this.button_multiplier.TabIndex = 12;
            this.button_multiplier.Text = "=V";
            this.button_multiplier.UseVisualStyleBackColor = true;
            this.button_multiplier.Click += new System.EventHandler(this.button_multiplier_Click);
            // 
            // button_properties
            // 
            this.button_properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_properties.Image = global::PrintThat.Properties.Resources.gearwheels;
            this.button_properties.Location = new System.Drawing.Point(36, 3);
            this.button_properties.Name = "button_properties";
            this.button_properties.Size = new System.Drawing.Size(30, 30);
            this.button_properties.TabIndex = 10;
            this.button_properties.UseVisualStyleBackColor = true;
            this.button_properties.Click += new System.EventHandler(this.button_properties_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.Image = global::PrintThat.Properties.Resources.arrow_circle;
            this.button_refresh.Location = new System.Drawing.Point(249, 3);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(30, 30);
            this.button_refresh.TabIndex = 8;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_print
            // 
            this.button_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_print.Location = new System.Drawing.Point(285, 3);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(146, 30);
            this.button_print.TabIndex = 1;
            this.button_print.Text = "Распечатать";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // dgv
            // 
            this.dgv.AllowDrop = true;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Del,
            this.Column_Check,
            this.Column_File,
            this.Column_Path,
            this.Column_Count});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(434, 75);
            this.dgv.TabIndex = 15;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgv_DragDrop);
            this.dgv.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgv_DragEnter);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            // 
            // Column_Del
            // 
            this.Column_Del.Frozen = true;
            this.Column_Del.HeaderText = "";
            this.Column_Del.Image = global::PrintThat.Properties.Resources.delete_small;
            this.Column_Del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Del.Name = "Column_Del";
            this.Column_Del.ReadOnly = true;
            this.Column_Del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Del.Width = 20;
            // 
            // Column_Check
            // 
            this.Column_Check.Frozen = true;
            this.Column_Check.HeaderText = "";
            this.Column_Check.Name = "Column_Check";
            this.Column_Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Check.Width = 35;
            // 
            // Column_File
            // 
            this.Column_File.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_File.HeaderText = "Название файла";
            this.Column_File.MaxInputLength = 1000;
            this.Column_File.Name = "Column_File";
            this.Column_File.ReadOnly = true;
            // 
            // Column_Path
            // 
            this.Column_Path.HeaderText = "Column_Path";
            this.Column_Path.Name = "Column_Path";
            this.Column_Path.ReadOnly = true;
            this.Column_Path.Visible = false;
            // 
            // Column_Count
            // 
            this.Column_Count.HeaderText = "Кол-во";
            this.Column_Count.Name = "Column_Count";
            this.Column_Count.Width = 75;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PrintThat.Properties.Resources.delete_small;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // Form_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 312);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_properties);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "Form_Main";
            this.Text = "Распечатка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_properties.ResumeLayout(false);
            this.panel_properties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_multi)).EndInit();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label_status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon_main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_show;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_updateNprint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_close;
        private System.Windows.Forms.Panel panel_properties;
        private System.Windows.Forms.CheckBox checkBox_autoCheck;
        private System.Windows.Forms.CheckBox checkBox_autostart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_from;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.CheckBox checkBox_recyrentSearch;
        private System.Windows.Forms.Label label_formats;
        private System.Windows.Forms.CheckBox checkBox_logging;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_properties;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_f1;
        private System.Windows.Forms.NumericUpDown numericUpDown_multi;
        private System.Windows.Forms.Button button_multiplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn Column_Del;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_File;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Count;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button button_printers;
    }
}

