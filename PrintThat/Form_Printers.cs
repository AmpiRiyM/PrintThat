using System;
using System.Windows.Forms;

namespace PrintThat
{
    public partial class Form_Printers : Form
    {
        public string ARG_Printer { get; set; }
        public Form_Printers()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Не выбран принтер.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.Focus();
                return;
            }

            ARG_Printer = dgv.CurrentRow.Cells[Column_Name.Name].Value.ToString();

            var resultative = (new Printer()).SetPrinter(ARG_Printer);

            if (resultative)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Во время постановки принтера возникла ошибка.\nПринтер не изменён.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgv.Focus();
                return;
            }
        }

        private void Form_Printers_Shown(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            var dt = new Printer().AvaliablePrintersFull(); //http://www.cyberforum.ru/csharp-beginners/thread2185249.html
            dgv.DataSource = dt;
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button_select.PerformClick();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Form_Printers_Shown(null, null);
        }
    }
}
