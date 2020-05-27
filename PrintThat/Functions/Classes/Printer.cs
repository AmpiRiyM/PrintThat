using System;
using System.Runtime.InteropServices;
using System.Data;
using System.Management;

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
                dr[0] = i++;
                dr[1] = printer;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public DataTable AvaliablePrintersFull()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Default", typeof(string));
            dt.Columns.Add("Network", typeof(string));

            int i = 0;
            DataRow dr;

            var printerQuery = new ManagementObjectSearcher("SELECT * from Win32_Printer");
            foreach (var printer in printerQuery.Get())
            {
                var name = printer.GetPropertyValue("Name");
                var status = printer.GetPropertyValue("Status");
                var isDefault = bool.Parse( printer.GetPropertyValue("Default").ToString());
                var isNetworkPrinter = bool.Parse(printer.GetPropertyValue("Network").ToString());

                dr = dt.NewRow();
                dr[0] = i++;
                dr[1] = name;
                dr[2] = status;
                dr[3] = isDefault ? "По умолчанию": "Обычный";
                dr[4] = isNetworkPrinter? "Сетевой": "Локальный";
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public bool SetPrinter(string printer) => SetDefaultPrinter(printer);
    }
}
