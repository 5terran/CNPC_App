using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CNPCApp.CommClass
{
    public class Bdbank
    {
        private XmlDocument xmldoc;
        private XmlNode xmlnode;
        private XmlElement xmlelem;

        public string ConnectionString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSQLbakFilePath">目标路径</param>
        /// <param name="strSQLbakName">备份名称</param>
        /// <param name="strDbName">备份数据库名称</param>
        public void SQLDataBaseBackup(string strSQLbakFilePath, string strSQLbakName, string strDbName)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.ConnectionString))
            {
                try
                {
                    // 创建一个日期文件夹
                    if (!Directory.Exists(strSQLbakFilePath + "\\" + DateTime.Now.Date))
                    {
                        Directory.CreateDirectory(strSQLbakFilePath + "\\" + DateTime.Now.Date.ToShortDateString());
                        strSQLbakFilePath = strSQLbakFilePath + "\\" + DateTime.Now.Date.ToShortDateString();
                    }

                    if (strSQLbakFilePath != "" && strSQLbakName != "")
                    {
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlConnection.Open();
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandTimeout = 180000;
                        sqlCommand.CommandText = "BACKUP DATABASE " + strDbName + " TO DISK = '" + strSQLbakFilePath + "\\" + strSQLbakName + ".bak'";
                        if (sqlCommand.ExecuteNonQuery() != 0)
                        {
                            //MessageBox.Show("数据库文件【" + strDbName + "】备份成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BakInfoToXml("数据库文件【" + strDbName + "】备份成功！");
                            sqlConnection.Close();
                            sqlConnection.Dispose();
                            return;
                        }
                        else
                        {
                            //MessageBox.Show("数据库文件【" + strDbName + "】备份失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BakInfoToXml("数据库文件【" + strDbName + "】备份失败！");
                            return;
                        }
                    }
                    else
                    {
                        //MessageBox.Show("请填写备份的正确位置及文件名！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BakInfoToXml(strSQLbakName + "请填写备份的正确位置及文件名！");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message.ToString() + "或您所输入的用户名密码不具备此数据库的操作权限", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BakInfoToXml(ex.Message.ToString() + "或您所输入的用户名密码不具备此数据库的操作权限");
                    return;
                }
            }
        }

        public void BakInfoToXml(string strDbName)
        {
            string strXmlPath = Application.StartupPath + "\\config\\";

            xmldoc = new XmlDocument();
            try
            {
                xmldoc.Load(strXmlPath + "DbBakInfoXML.xml");
            }
            catch (Exception ex)
            {
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                XmlDeclaration xmldecl;
                xmldecl = xmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                xmldoc.AppendChild(xmldecl);

                //加入一个Conentstring根元素
                xmlelem = xmldoc.CreateElement("", "DbBakInfo", "");
                xmldoc.AppendChild(xmlelem);
            }

            //加入另外一个元素
            XmlNode root = xmldoc.SelectSingleNode("DbBakInfo");//查找<Conentstring> 
            XmlElement xe1 = xmldoc.CreateElement("Dbbak"); //创建一个<Node>节点 
            xe1.SetAttribute("name", "数据库备份信息列表");
            xe1.SetAttribute("time", DateTime.Now.Date.ToShortDateString());

            XmlElement xesub1 = xmldoc.CreateElement("Dbinfo");
            xesub1.InnerText = strDbName;
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//


            //保存创建好的XML文档
            string str = System.Windows.Forms.Application.StartupPath;
            string path = Application.StartupPath + "\\config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            try
            {
                xmldoc.Save(path + "\\DbBakInfoXML.xml");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }




    }
}
