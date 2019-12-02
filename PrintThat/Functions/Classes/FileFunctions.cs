using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Drawing.Printing;
using System.Drawing;

namespace PrintThat
{
    public static class FileFunctions
    {
        static readonly HashSet<s_format> _avaliableFormats = new HashSet<s_format> {
            new s_format {  FileFormat = "doc",     PrintAs = ePrintAs.doc  },
            new s_format {  FileFormat = "docx",    PrintAs = ePrintAs.docx },
            new s_format {  FileFormat = "pdf",     PrintAs = ePrintAs.pdf },
            new s_format {  FileFormat = "txt",     PrintAs = ePrintAs.txt },
            new s_format {  FileFormat = "rtf",     PrintAs = ePrintAs.rtf }
        };
        public static List<string> AvaliableFormats
        {
            get { return _avaliableFormats.Select(f => f.FileFormat).ToList(); }
        }

        static void _getFilesRecursive(string path, ref List<string> formats, ref List<string> files)
        {
            string tmp;
            foreach (string item_directory in Directory.GetDirectories(path))
            {
                foreach (string file in Directory.GetFiles(item_directory))
                {
                    tmp = file.Split('.').Last();
                    if (formats.Contains(tmp)) { files.Add(file); }
                }

                _getFilesRecursive(item_directory, ref formats, ref files);
            }
        }
        
        public static List<string> GetAvaliableFilesByDirectory(string path, bool useRecyrentSearch)
        {
            List<string> files = new List<string>();

            var formats = AvaliableFormats;
            string tmp;

            if (useRecyrentSearch)
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    tmp = file.Split('.').Last();
                    if (formats.Contains(tmp)) { files.Add(file); }
                }

                _getFilesRecursive(path, ref formats, ref files);
            }
            else
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    tmp = file.Split('.').Last();
                    if (formats.Contains(tmp)) { files.Add(file); }
                }
            }

            return files;
        }

        public static void Print(this string file)
        {
            _printFile(file);
        }

        private static void _printFile(string file, int count = 1)
        {
            string format = file.Split('.').Last().ToLower();

            switch (_avaliableFormats.Where(f => f.FileFormat == format).Select(f => f.PrintAs).First())
            {
                case ePrintAs.pdf:
                case ePrintAs.rtf:
                    {
                        #region printing pdf

                        for (int i = 0; i < count; i++)
                        {
                            using (Process p = new Process())
                            {
                                p.StartInfo = new ProcessStartInfo()
                                {
                                    Verb = "print",
                                    FileName = file,
                                    CreateNoWindow = true,
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                };
                                p.Start();
                                p.WaitForInputIdle();//System.Threading.Thread.Sleep(3000); //if (false == p.CloseMainWindow()) //p.Kill();
                            }
                        }

                        #endregion
                        break;
                    }
                case ePrintAs.docx:
                case ePrintAs.doc:
                    {
                        #region print docx

                        for (int i = 0; i < count; i++)
                        {
                            Microsoft.Office.Interop.Word.Application wordInstance = new Microsoft.Office.Interop.Word.Application();
                            wordInstance.Visible = false;
                            object fileObject = file;
                            object oMissing = System.Reflection.Missing.Value;
                            Microsoft.Office.Interop.Word.Document doc = wordInstance.Documents.Open(ref fileObject, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                            doc.Activate();
                            doc.PrintOut(oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing);
                            doc.Close(ref oMissing, ref oMissing, ref oMissing);
                            wordInstance.Quit(ref oMissing, ref oMissing, ref oMissing);
                            doc = null;
                            wordInstance = null;
                        }

                        break;
                        #endregion
                    }
                case ePrintAs.txt:
                    {
                        #region txt
                        Font printFont = new Font("Arial", 10);
                        string content = File.ReadAllText(file);
                        // for (int i = 0; i < count; i++)
                        {
                            try
                            {
                                PrintDocument pd = new PrintDocument();
                                pd.PrintPage += (sender, print_event) =>
                                {
                                    print_event.Graphics.DrawString(content, printFont, Brushes.Black,
                                     print_event.MarginBounds.Left, 0, new StringFormat());
                                };
                                pd.PrinterSettings.Copies = (short)count;
                                pd.Print();
                            }
                            catch { }
                        }
                        break;
                        #endregion
                    }
            }

            if (Configs.Logging) { file.Put(count); }

            GC.Collect();
        }

        public static void Print(this List<cDGVRow> files) => files.ForEach(f => _printFile(f.FilePath, f.Count));

        internal static void PrintFolder(string folder)
        {
            if (!Directory.Exists(folder)) { return; }

            List<string> files = FileFunctions.GetAvaliableFilesByDirectory(folder, Configs.RecSearch);

            foreach (string file in files)
            {
                file.Print();
            }
        }
    }
}
