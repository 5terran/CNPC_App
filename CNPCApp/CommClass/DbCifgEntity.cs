using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CNPCApp.CommClass
{
    public class DbCifgEntity
    {
        private string Connstring;
        private string Path;
        private string Time;
        private XmlNode DBNameList;

        public string DBcifgConnstring
        {
            get { return Connstring; }
            set { Connstring = value; }
        }

        public string DbcifgPath
        {
            get { return Path; }
            set { Path = value; }
        }

        public string DBcifgTime
        {
            get { return Time; }
            set { Time = value; }
        }

        public XmlNode DbcifgDBNameList
        {
            get { return DBNameList; }
            set { DBNameList = value; }
        }

    }
}
