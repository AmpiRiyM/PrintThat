using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(dgv.CurrentRow == null)
            {
                MessageBox.Show("Не выбран принтер.");
                dgv.Focus();
                return;
            }

            ARG_Printer = dgv.CurrentRow.Cells[Column_Name.Name].Value.ToString();

            var resultative = (new Printer()).SetPrinter(ARG_Printer);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form_Printers_Shown(object sender, EventArgs e)
        {
            var dt = new Printer().AvaliablePrinters();
            //http://www.cyberforum.ru/csharp-beginners/thread2185249.html
            dgv.DataSource = dt;
        }
    }
}
