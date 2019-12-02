using System;
using System.Runtime.InteropServices;
using System.Data;

namespace PrintThat
{
    public class Printer
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern Boolean SetDefaultPrinter(String name);

        public DataTable AvaliablePrinters()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            int i = 0;
            DataRow dr;
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                dr = dt.NewRow();
                dr[0] = i;
                dr[1] = printer;
                dt.Rows.Add(dr);
            }

            return dt;
        }
        public bool SetPrinter(string printer) => SetDefaultPrinter(printer);
    }
}
