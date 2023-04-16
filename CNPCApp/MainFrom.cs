using CNPCApp.CommClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Timers;
using CNPC_App.Ali;

namespace CNPCApp
{
    public partial class MainFrom : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer timer2 = new System.Timers.Timer();
        System.Timers.Timer timer3 = new System.Timers.Timer();
        private XmlDocument xmldoc;
        private XmlNode xmlnode;
        private XmlElement xmlelem;
        public const string AccessId = "";
        public const string AccessKey = "";
        public const string Endpoint = "http://oss-cn-shanghai.aliyuncs.com";
        public const string BucketName = "ynytbnsh";

        public MainFrom()
        {
            InitializeComponent();
        }

        #region 事件

        /// <summary>
        /// 时间触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            int intSecond = e.SignalTime.Second;

            int iHour = 1;
            int iMinute = 00;
            int iSecond = 00;

            if (intHour == iHour && intMinute == iMinute && intSecond == iSecond)
            {
                //到时自动触发备份
                BakDb();
                LoadDbBakInfoXML();

                //删除15天以前的备份数据
                DelDataFor15day();
            }

        }

        private void Timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            int intSecond = e.SignalTime.Second;

            int iHour = 2;
            int iMinute = 00;
            int iSecond = 00;

            if (intHour == iHour && intMinute == iMinute && intSecond == iSecond)
            {
                //到时自动触发上传
                // UploadOss();
                // LoadOssInfoXML();
            }
        }

        private void Timer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            int intSecond = e.SignalTime.Second;

            int iHour = 12;
            int iMinute = 00;
            int iSecond = 00;

            if (intHour == iHour && intMinute == iMinute && intSecond == iSecond)
            {
                //到时自动重启
                restart();
            }
        }

        /// <summary>
        /// fromload
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrom_Load(object sender, EventArgs e)
        {
            // 读取备份数据库配置文件
            LoadXmlConfig();
            //LoadUpDataDbOssInfo();

            // 
            LoadDbBakInfoXML();
            //LoadOssInfoXML();

            // 启动定时器开始自动备份
            timer.Enabled = true;
            timer.Interval = 1000;//执行间隔时间,单位为毫秒  
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);

            timer2.Enabled = true;
            timer2.Interval = 1000;//执行间隔时间,单位为毫秒  
            timer2.Start();
            timer2.Elapsed += new System.Timers.ElapsedEventHandler(Timer2_Elapsed);

            timer3.Enabled = true;
            timer3.Interval = 1000;//执行间隔时间,单位为毫秒  
            timer3.Start();
            timer3.Elapsed += new System.Timers.ElapsedEventHandler(Timer3_Elapsed);

        }




        /// <summary>
        /// 测试连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDbContent_Click(object sender, EventArgs e)
        {
            if (DbInputCheck() == false) return;

            DataSet DbList = GetAllDataBase(".", this.txtDbAccName.Text.Trim(), this.txtDbAccPsd.Text.Trim());

            if (DbList != null && DbList.Tables.Count > 0)
            {
                this.dataGridViewDb.DataSource = DbList;
                this.dataGridViewDb.DataMember = "DBName";
            }
            else
            {
                MessageBox.Show("本地没有可用的数据库，请检查本地数据库", "错误提示", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 点击单元格选中checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridViewDb.Rows[e.RowIndex].Cells["cb_check"];
            Boolean flag = Convert.ToBoolean(checkCell.Value);

            if (flag == true)
            {
                checkCell.Value = false;
            }
            else
            {
                checkCell.Value = true;
            }
        }

        /// <summary>
        /// 数据库全部选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell checkCell;

            if (chbAll.Checked == true)
            {
                foreach (DataGridViewRow dr in dataGridViewDb.Rows)
                {
                    checkCell = (DataGridViewCheckBoxCell)dr.Cells["cb_check"];
                    checkCell.Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow dr in dataGridViewDb.Rows)
                {
                    checkCell = (DataGridViewCheckBoxCell)dr.Cells["cb_check"];
                    checkCell.Value = false;
                }
            }
        }


        /// <summary>
        /// 选择备份路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDbSelectPath_Click(object sender, EventArgs e)
        {
            //选择文件夹
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                this.txtDbBakPath.Text = foldPath;
            }

        }


        /// <summary>
        /// 自动备份启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDbAutoBak_Click(object sender, EventArgs e)
        {
            if (SaveDbBakInfo() == false)
            {
                MessageBox.Show("数据库备份信息填写保存有误，请检查后再次保存", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            MessageBox.Show("自动备份设置成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// 手动备份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDbBak_Click(object sender, EventArgs e)
        {
            if (SaveDbBakInfo() == false)
            {
                MessageBox.Show("数据库备份信息填写保存有误，请检查后再次保存", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            BakDb();

            MessageBox.Show("手动备份成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// 选择需要备份的数据库路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOssSelect_Click(object sender, EventArgs e)
        {
            //选择文件夹
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                this.txtOssDbPath.Text = foldPath;
            }
        }

        /// <summary>
        /// 确定并自动上传阿里云OSS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOssOk_Click(object sender, EventArgs e)
        {
            // 最小化主窗口
            HideMainForm();



            if (this.txtAccessId.Text.Length <= 0 || this.txtAccessKey.Text.Length <= 0 || this.txtBucketName.Text.Length <= 0)
            {
                MessageBox.Show("阿里云OSS信息不能为空", "错误提示", MessageBoxButtons.OK);
                return;
            }

            xmldoc = new XmlDocument();
            //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
            XmlDeclaration xmldecl;
            xmldecl = xmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
            xmldoc.AppendChild(xmldecl);

            //加入一个AliOss根元素
            xmlelem = xmldoc.CreateElement("", "AliOss", "");
            xmldoc.AppendChild(xmlelem);
            //加入另外一个元素
            XmlNode root = xmldoc.SelectSingleNode("AliOss");//查找<AliOss> 
            XmlElement xe1 = xmldoc.CreateElement("OssInfo"); //创建一个<Node>节点 
            xe1.SetAttribute("name", "阿里云OSS信息");
            XmlElement xesub1 = xmldoc.CreateElement("AccessId");
            xesub1.InnerText = this.txtAccessId.Text.Trim();//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到<AliOss>节点中 

            xesub1 = xmldoc.CreateElement("AccessKey");
            xesub1.InnerText = this.txtAccessKey.Text.Trim();//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到<AliOss>节点中 

            xesub1 = xmldoc.CreateElement("BucketName");
            xesub1.InnerText = this.txtBucketName.Text.Trim();//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到<AliOss>节点中 

            xesub1 = xmldoc.CreateElement("Endpoint");
            xesub1.InnerText = this.txtEndpoint.Text.Trim();//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到<AliOss>节点中 

            string strOssday = "";
            if (this.rbtnOssDay.Checked == true) strOssday = "1";
            if (this.rbtnOss3Day.Checked == true) strOssday = "3";
            if (this.rbtnOss7Day.Checked == true) strOssday = "7";
            if (this.rbtnOss15Day.Checked == true) strOssday = "15";

            //加入另外一个元素
            root = xmldoc.SelectSingleNode("AliOss");//查找<Conentstring> 
            xe1 = xmldoc.CreateElement("OssBakTime"); //创建一个<Node>节点 
            xe1.SetAttribute("name", "上传时间");
            xesub1 = xmldoc.CreateElement("UploadTime");
            xesub1.InnerText = strOssday;//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到<AliOss>节点中 

            //加入另外一个元素
            root = xmldoc.SelectSingleNode("AliOss");//查找<Conentstring> 
            xe1 = xmldoc.CreateElement("OssBakPath"); //创建一个<Node>节点 
            xe1.SetAttribute("name", "上传指定路径");
            xesub1 = xmldoc.CreateElement("UploadTime");
            xesub1.InnerText = this.txtOssDbPath.Text.Trim();//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到<AliOss>节点中 

            string str = System.Windows.Forms.Application.StartupPath;
            string path = Application.StartupPath + "\\config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            try
            {
                xmldoc.Save(path + "\\AliOssXML.xml");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            UploadOss();

        }

        #endregion



        #region 私有函数
        /// <summary>
        /// 设置DBinput的输入验证
        /// </summary>
        /// <returns></returns>
        private bool DbInputCheck()
        {
            if (this.txtDbAccName.Text.Length <= 0 || this.txtDbAccPsd.Text.Length <= 0)
            {
                MessageBox.Show("请输入本地数据库连接信息", "错误提示", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 获取本地数据库所有名称
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private DataSet GetAllDataBase(string ip, string username, string password, string strSqlConnection = "0")
        {
            DataSet DBNameList = new DataSet();
            string strFormat = "";

            if (strSqlConnection == "0")
            {
                strFormat = String.Format("Data Source={0};Initial Catalog = master;User ID = {1};PWD = {2}", ip, username, password);
            }
            else
            {
                strFormat = strSqlConnection;
            }
            SqlConnection Connection = new SqlConnection(
               strFormat);
            SqlDataAdapter Adapter = new SqlDataAdapter("select name from master..sysdatabases", Connection);

            // 保存连接字符串
            this.txtDbConetstring.Text = strFormat;

            lock (Adapter)
            {
                try
                {
                    Adapter.Fill(DBNameList, "DBName");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }

            }

            DBNameList.Tables[0].Columns.Add("DBSize");

            int cnt = 0;

            foreach (DataRow dr in DBNameList.Tables[0].Rows)
            {
                cnt++;
                dr["DBSize"] = cnt.ToString();
            }

            return DBNameList;
        }

        /// <summary>
        /// 保存Db备份的相关信息为XML文件
        /// </summary>
        private bool SaveDbBakInfo()
        {
            if (DbInputCheck() == false || this.txtDbBakPath.Text.Length <= 0)
            {
                MessageBox.Show("请完善数据库备份所需要输入的相关信息，报错sa名称，密码及其数据库备份路径", "错误提示", MessageBoxButtons.OK);
                return false;
            }

            DataGridViewCheckBoxCell checkCell;
            ArrayList arlist = new ArrayList();
            foreach (DataGridViewRow dr in dataGridViewDb.Rows)
            {
                checkCell = (DataGridViewCheckBoxCell)dr.Cells["cb_check"];
                if (checkCell.Value != null && (bool)checkCell.Value == true)
                {
                    arlist.Add(((DataGridViewTextBoxCell)dr.Cells["c2"]).Value);
                }
            }

            if (arlist.Count == 0)
            {
                MessageBox.Show("请勾选需要备份的数据库", "错误提示", MessageBoxButtons.OK);
                return false;
            }

            xmldoc = new XmlDocument();
            //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
            XmlDeclaration xmldecl;
            xmldecl = xmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
            xmldoc.AppendChild(xmldecl);

            //加入一个Conentstring根元素
            xmlelem = xmldoc.CreateElement("", "Conentstring", "");
            xmldoc.AppendChild(xmlelem);

            //加入另外一个元素
            XmlNode root = xmldoc.SelectSingleNode("Conentstring");//查找<Conentstring> 
            XmlElement xe1 = xmldoc.CreateElement("Conent"); //创建一个<Node>节点 
            xe1.SetAttribute("name", "数据库链接字符串");
            xe1.SetAttribute("IP", ".");

            XmlElement xesub1 = xmldoc.CreateElement("value");
            xesub1.InnerText = this.txtDbConetstring.Text.Trim();//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到<Conentstring>节点中 

            root = xmldoc.SelectSingleNode("Conentstring");//查找<Conentstring> 
            xe1 = xmldoc.CreateElement("DbPath"); //创建一个<Node>节点 
            xe1.SetAttribute("name", "数据库备份路径");

            xesub1 = xmldoc.CreateElement("DbcifgPath");
            xesub1.InnerText = this.txtDbBakPath.Text.Trim();//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到节点中 

            xesub1 = xmldoc.CreateElement("DBcifgTime");
            string strDayValue = "";
            if (this.rbtnDbDay.Checked) strDayValue = "1";
            if (this.rbtnDb3Day.Checked) strDayValue = "3";
            if (this.rbtnDb7Day.Checked) strDayValue = "7";
            if (this.rbtnDb15Day.Checked) strDayValue = "15";
            xesub1.InnerText = strDayValue;//设置文本节点 
            xe1.AppendChild(xesub1);//添加到节点中 
            root.AppendChild(xe1);//添加到节点中 

            root = xmldoc.SelectSingleNode("Conentstring");//查找<Conentstring> 
            xe1 = xmldoc.CreateElement("DB"); //创建一个<Node>节点 
            xe1.SetAttribute("name", "备份的数据库备份");
            for (int i = 0; i < arlist.Count; i++)
            {
                xesub1 = xmldoc.CreateElement("DBName");
                xesub1.InnerText = arlist[i].ToString();//设置文本节点 
                xe1.AppendChild(xesub1);//添加到节点中 
                root.AppendChild(xe1);//添加到节点中 
            }

            //保存创建好的XML文档
            string str = System.Windows.Forms.Application.StartupPath;
            string path = Application.StartupPath + "\\config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            try
            {
                xmldoc.Save(path + "\\ConentstringXML.xml");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        /// <summary>
        ///开机自动读取数据库备份相关配置文件 
        /// </summary>
        private void LoadXmlConfig()
        {
            string strXmlPath = Application.StartupPath + "\\config\\";
            DbCifgEntity dbcifg = new DbCifgEntity();

            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(strXmlPath + "ConentstringXML.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("配置文件不存在，请进行第一次使用配置");
                return;
            }

            XmlNode xn = xmlDoc.SelectSingleNode("Conentstring");

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;
            txtDbConetstring.Text = ((XmlElement)xnl[0]).ChildNodes[0].InnerText;
            dbcifg.DBcifgConnstring = ((XmlElement)xnl[0]).ChildNodes[0].InnerText;

            txtDbBakPath.Text = ((XmlElement)xnl[1]).ChildNodes[0].InnerText;
            dbcifg.DbcifgPath = ((XmlElement)xnl[1]).ChildNodes[0].InnerText;

            string strTime = ((XmlElement)xnl[1]).ChildNodes[1].InnerText;
            dbcifg.DBcifgTime = ((XmlElement)xnl[1]).ChildNodes[1].InnerText;
            if (strTime == "1") rbtnDbDay.Checked = true;
            if (strTime == "3") rbtnDb3Day.Checked = true;
            if (strTime == "7") rbtnDb7Day.Checked = true;
            if (strTime == "15") rbtnDb15Day.Checked = true;

            dbcifg.DbcifgDBNameList = xnl[2];
            //读取数据库配置，检索数据库
            DataSet DbList = GetAllDataBase(".", "", "", txtDbConetstring.Text);
            if (DbList != null && DbList.Tables.Count > 0)
            {
                // 数据库列表页面datagird
                this.dataGridViewDb.DataSource = DbList;
                this.dataGridViewDb.DataMember = "DBName";

                // 阿里云OSS页
                this.dataGridViewOss.DataSource = DbList;
                this.dataGridViewOss.DataMember = "DBName";

                DataGridViewCheckBoxCell checkCell;

                for (int i = 0; i < xnl[2].ChildNodes.Count; i++)
                {
                    foreach (DataGridViewRow dr in dataGridViewDb.Rows)
                    {
                        if ((dr.Cells["c2"].Value).ToString() == xnl[2].ChildNodes[i].InnerText)
                        {
                            checkCell = (DataGridViewCheckBoxCell)dr.Cells["cb_check"];
                            checkCell.Value = true;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("本地没有可用的数据库，请检查本地数据库", "错误提示", MessageBoxButtons.OK);
            }

        }


        /// <summary>
        /// 读取DbbakinfoXml信息
        /// </summary>
        private void LoadDbBakInfoXML()
        {
            string strXmlPath = Application.StartupPath + "\\config\\";
            DataSet xmlDS = new DataSet();
            xmldoc = new XmlDocument();

            try
            {
                xmlDS.ReadXml(strXmlPath + "DbBakInfoXML.xml");
                xmlDS.Tables[0].Columns[0].ColumnName = "数据库备份信息";
                xmlDS.Tables[0].Columns[1].ColumnName = "数据库备份";
                xmlDS.Tables[0].Columns[2].ColumnName = "数据库备时间";
                dataGridViewPathDb.DataSource = xmlDS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("DbBakInfoXML.xml没有产生，无法读取");
            }


        }

        private void LoadUpDataDbOssInfo()
        {
            string strXmlPath = Application.StartupPath + "\\config\\";
            DataSet xmlDS = new DataSet();
            xmldoc = new XmlDocument();

            try
            {
                xmlDS.ReadXml(strXmlPath + "OssResultXML.xml");
                xmlDS.Tables[0].Columns[0].ColumnName = "数据库上传状态";
                xmlDS.Tables[0].Columns[1].ColumnName = "阿里云服务";
                xmlDS.Tables[0].Columns[2].ColumnName = "上传时间";
                dataGridViewHistyOss.DataSource = xmlDS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("OssResultXML.xml没有产生，无法读取");
            }
        }


        private void LoadOssInfoXML()
        {
            string strXmlPath = Application.StartupPath + "\\config\\";
            DbCifgEntity dbcifg = new DbCifgEntity();

            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(strXmlPath + "AliOssXML.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AliOssXML配置文件不存在，请进行第一次使用配置");
                return;
            }

            XmlNode xn = xmlDoc.SelectSingleNode("AliOss");

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;
            this.txtAccessId.Text = ((XmlElement)xnl[0]).ChildNodes[0].InnerText;
            this.txtAccessKey.Text = ((XmlElement)xnl[0]).ChildNodes[1].InnerText;
            this.txtBucketName.Text = ((XmlElement)xnl[0]).ChildNodes[2].InnerText;
            this.txtEndpoint.Text = ((XmlElement)xnl[0]).ChildNodes[3].InnerText;

            string strTime = ((XmlElement)xnl[1]).ChildNodes[0].InnerText;
            if (strTime == "1") this.rbtnOssDay.Checked = true;
            if (strTime == "3") this.rbtnOss3Day.Checked = true;
            if (strTime == "7") this.rbtnOss7Day.Checked = true;
            if (strTime == "15") this.rbtnOss15Day.Checked = true;

            this.txtOssDbPath.Text = ((XmlElement)xnl[2]).ChildNodes[0].InnerText;



        }

        /// <summary>
        /// 数据库备份
        /// </summary>
        private void BakDb()
        {
            Bdbank dbBak = new Bdbank();
            if (this.txtDbConetstring.Text.Trim().Length <= 0)
            {
                this.txtDbConetstring.Text = String.Format("Data Source={0};Initial Catalog = master;User ID = {1};PWD = {2}", ".", this.txtDbAccName.Text.Trim(), this.txtDbAccPsd.Text.Trim());
            }

            dbBak.ConnectionString = this.txtDbConetstring.Text.Trim();
            DataGridViewCheckBoxCell checkCell;

            foreach (DataGridViewRow dr in dataGridViewDb.Rows)
            {
                checkCell = (DataGridViewCheckBoxCell)dr.Cells["cb_check"];

                if (checkCell.Value != null && (bool)checkCell.Value == true)
                {
                    string strDbName = ((DataGridViewTextBoxCell)dr.Cells["c2"]).Value.ToString();
                    string strBakDbName = DateTime.Now.ToShortDateString() + "_CNPCDB_" + strDbName;

                    dbBak.SQLDataBaseBackup(this.txtDbBakPath.Text.Trim(), strBakDbName, strDbName);
                }
            }

        }


        /// <summary>
        /// 上传到阿里云OSS
        /// </summary>
        private void UploadOss()
        {
            // 获取制定路径下的所有数据库bak文件列表
            string str = this.txtOssDbPath.Text.Trim();
            string strPath = str + "\\" + DateTime.Now.Date.ToShortDateString();
            var files = Directory.GetFiles(strPath, "*.bak");

            foreach (var file in files)
            {
                string[] strsprint = file.Split(new string[] { @"\" }, StringSplitOptions.None);
                string strName = strsprint[strsprint.Length - 1];

                // 开始分片上传
                // 计算分片数量
                int partSize = 90 * 1024 * 1024;
                var fi = new FileInfo(file);
                var fileSize = fi.Length;
                var partCount = fileSize / partSize;
                if (fileSize % partSize != 0)
                {
                    partCount++;
                }

                string key = OssHelper.UploadMultipart(BucketName, strName, file, partSize);

                string strXmlPath = Application.StartupPath + "\\config\\";
                DbCifgEntity dbcifg = new DbCifgEntity();

                xmldoc = new XmlDocument();
                try
                {
                    xmldoc.Load(strXmlPath + "OssResultXML.xml");
                }
                catch (Exception ex)
                {
                    xmldoc = new XmlDocument();
                    //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                    XmlDeclaration xmldecl;
                    xmldecl = xmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                    xmldoc.AppendChild(xmldecl);

                    //加入一个Conentstring根元素
                    xmlelem = xmldoc.CreateElement("", "OssResult", "");
                    xmldoc.AppendChild(xmlelem);
                    xmldoc.Save(strXmlPath + "\\OssResultXML.xml");
                }

                //加入另外一个元素
                XmlNode root = xmldoc.SelectSingleNode("OssResult");//查找<OssResult> 
                XmlElement xe1 = xmldoc.CreateElement("Result"); //创建一个<Node>节点 
                xe1.SetAttribute("name", "OSS上传状态");
                xe1.SetAttribute("date", DateTime.Now.ToShortDateString());

                XmlElement xesub1 = xmldoc.CreateElement("value");
                xesub1.InnerText = strName + "上传成功";
                //this.labUploadProgress.Text = strName + "上传成功";
                xe1.AppendChild(xesub1);//添加到节点中 
                root.AppendChild(xe1);//添加到<OssResult>节点中

                xmldoc.Save(strXmlPath + "\\OssResultXML.xml");
            }
        }

        /// <summary>
        /// 删除15天以前的备份数据
        /// </summary>
        private void DelDataFor15day()
        {
            string docName = DateTime.Now.AddDays(-15).ToShortDateString();
            string path = txtDbBakPath.Text.Trim() + "\\" + docName;
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }

        private void HideMainForm()
        {
            this.Hide();
        }

        private void ShowMainForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;

                HideMainForm();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                ShowMainForm();
            }
        }

        private void MainFrom_MinimumSizeChanged(object sender, EventArgs e)
        {

        }

        private void MainFrom_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideMainForm();
            }
        }

        private void MainFrom_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)    //最小化到系统托盘
            {
                notifyIcon1.Visible = true;    //显示托盘图标
                this.Hide();    //隐藏窗口
            }
        }

        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            //注意判断关闭事件Reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;    //取消"关闭窗口"事件
                this.WindowState = FormWindowState.Minimized;    //使关闭时窗口向右下角缩小的效果
                notifyIcon1.Visible = true;
                this.Hide();
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart()
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }


    }
    #endregion
}