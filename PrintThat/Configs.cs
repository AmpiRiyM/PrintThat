using System;
using System.Collections.Generic;
using System.Xml;
using System.Security.Cryptography;
using System.Text;


namespace PrintThat
{
    public static class Configs
    {
        static Int16 _printCount;
        const string def_printCount = "PrintCount";
        public static Int16 PrintCount
        {
            get { return _printCount; }
            set
            {
                _printCount = value;
                _writeValue(def_printCount, value);
            }
        }


        static string _targetPath;
        const string def_targetPath = "TargetPath";
        public static string TargetPath
        {
            get { return _targetPath; }
            set
            {
                _targetPath = value;

                //byte[] data =ASCIIEncoding.ASCII.GetBytes(value);
                //var crypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
               // string _crypted_str =ASCIIEncoding.ASCII.GetString(crypted);

                _writeValue(def_targetPath, value);// _crypted_str);
            }
        }

        static bool _startMinimazing;
        const string def_startMinimazing = "StartMinimazing";
        public static bool StartMinimazing
        {
            get { return _startMinimazing; }
            set
            {
                _startMinimazing = value;
                _writeValue(def_startMinimazing, value);
            }
        }

        static bool _autoCheck;
        const string def_autoCheck = "AutoCheck";
        public static bool AutoCheck
        {
            get { return _autoCheck; }
            set
            {
                _autoCheck = value;
                _writeValue(def_autoCheck, value);
            }
        }


        static bool _logging;
        const string def_logging = "Logging";
        public static bool Logging
        {
            get { return _logging; }
            set
            {
                _logging = value;
                _writeValue(def_logging, value);
            }
        }

        static bool _rec_search;
        const string def_rec_search = "RecSearch";
        /// <summary>
        /// Выполнение рекурентного поиска файлов во внутренних папках целевой папки
        /// </summary>
        public static bool RecSearch
        {
            get { return _rec_search; }
            set
            {
                _rec_search = value;
                _writeValue(def_rec_search, value);
            }
        }


        static void _writeValue(string NodeName, object Value)
        {
            new System.Threading.Thread((obj) =>
            {
                XmlDocument _doc = new XmlDocument();
                _doc.Load(_filePath);
                try
                {
                    _doc.ChildNodes[1].SelectSingleNode(NodeName).InnerText = obj.ToString();
                    _doc.Save(_filePath);
                }
                catch { }
                finally { _doc = null; }
            }).Start(Value);
        }


        static string _filePath;

        struct c_temp
        {
            public string name;
            public SomeFunction func;
        }
        delegate void SomeFunction(string value);

        public static void Init(string FilePath)
        {
            var fields = new List<c_temp>
            {
                new c_temp { name = def_targetPath,         func = (i)=>
                {
                    //if(i==string.Empty) { return; }

                    //byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(i);
                    //var crypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
                    //string _crypted_str = System.Text.ASCIIEncoding.ASCII.GetString(crypted);

                    _targetPath = i;// _crypted_str;
                } },
                new c_temp { name = def_startMinimazing,    func = (i)=> { bool.TryParse(i, out _startMinimazing); }},
                new c_temp { name = def_autoCheck,          func = (i)=> { bool.TryParse(i, out _autoCheck); }},
                new c_temp { name = def_rec_search,         func = (i)=> { bool.TryParse(i, out _rec_search); }},
                new c_temp { name = def_logging,            func = (i)=> { bool.TryParse(i, out _logging); }},
                new c_temp { name = def_printCount,         func = (i)=> { Int16.TryParse(i, out _printCount); }},
            };

            _filePath = FilePath;
            using (XmlReader _reader = XmlReader.Create(_filePath))
            {
                int index;
                _reader.Read();
                _reader.Read();
                _reader.ReadInnerXml();
                while (_reader.Read())
                {
                    if (_reader.NodeType == XmlNodeType.Element)
                    {
                        index = 0;
                        foreach (var field in fields)
                        {
                            if (field.name == _reader.Name)
                            {
                                _reader.Read();
                                field.func.Invoke(_reader.Value);
                                fields.RemoveAt(index);
                                break;
                            }
                            index++;
                        }
                    }
                }
            }
        }
    }
}


