namespace CNPCApp
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDbBak = new System.Windows.Forms.Button();
            this.btnDbAutoBak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDbSelectPath = new System.Windows.Forms.Button();
            this.txtDbBakPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnDb15Day = new System.Windows.Forms.RadioButton();
            this.rbtnDb7Day = new System.Windows.Forms.RadioButton();
            this.rbtnDb3Day = new System.Windows.Forms.RadioButton();
            this.rbtnDbDay = new System.Windows.Forms.RadioButton();
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDbConetstring = new System.Windows.Forms.TextBox();
            this.btnDbContent = new System.Windows.Forms.Button();
            this.txtDbAccPsd = new System.Windows.Forms.TextBox();
            this.txtDbAccName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDb = new System.Windows.Forms.DataGridView();
            this.cb_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labUploadProgress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewOss = new System.Windows.Forms.DataGridView();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbUpload = new System.Windows.Forms.CheckBox();
            this.btnOssOk = new System.Windows.Forms.Button();
            this.btnOssSelect = new System.Windows.Forms.Button();
            this.txtOssDbPath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbtnOss15Day = new System.Windows.Forms.RadioButton();
            this.rbtnOss7Day = new System.Windows.Forms.RadioButton();
            this.rbtnOss3Day = new System.Windows.Forms.RadioButton();
            this.rbtnOssDay = new System.Windows.Forms.RadioButton();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.txtBucketName = new System.Windows.Forms.TextBox();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.txtAccessId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewPathDb = new System.Windows.Forms.DataGridView();
            this.dataGridViewHistyOss = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDb)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOss)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPathDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistyOss)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 537);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnDbBak);
            this.tabPage1.Controls.Add(this.btnDbAutoBak);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chbAll);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridViewDb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置备份数据库";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(665, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "安全退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDbBak
            // 
            this.btnDbBak.Location = new System.Drawing.Point(618, 430);
            this.btnDbBak.Name = "btnDbBak";
            this.btnDbBak.Size = new System.Drawing.Size(122, 40);
            this.btnDbBak.TabIndex = 7;
            this.btnDbBak.Text = "手动备份";
            this.btnDbBak.UseVisualStyleBackColor = true;
            this.btnDbBak.Click += new System.EventHandler(this.btnDbBak_Click);
            // 
            // btnDbAutoBak
            // 
            this.btnDbAutoBak.Location = new System.Drawing.Point(481, 430);
            this.btnDbAutoBak.Name = "btnDbAutoBak";
            this.btnDbAutoBak.Size = new System.Drawing.Size(122, 40);
            this.btnDbAutoBak.TabIndex = 7;
            this.btnDbAutoBak.Text = "自动备份";
            this.btnDbAutoBak.UseVisualStyleBackColor = true;
            this.btnDbAutoBak.Click += new System.EventHandler(this.btnDbAutoBak_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDbSelectPath);
            this.groupBox1.Controls.Add(this.txtDbBakPath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbtnDb15Day);
            this.groupBox1.Controls.Add(this.rbtnDb7Day);
            this.groupBox1.Controls.Add(this.rbtnDb3Day);
            this.groupBox1.Controls.Add(this.rbtnDbDay);
            this.groupBox1.Location = new System.Drawing.Point(32, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置备份时间与路径";
            // 
            // btnDbSelectPath
            // 
            this.btnDbSelectPath.Font = new System.Drawing.Font("宋体", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDbSelectPath.Location = new System.Drawing.Point(387, 42);
            this.btnDbSelectPath.Name = "btnDbSelectPath";
            this.btnDbSelectPath.Size = new System.Drawing.Size(28, 21);
            this.btnDbSelectPath.TabIndex = 10;
            this.btnDbSelectPath.Text = "....";
            this.btnDbSelectPath.UseVisualStyleBackColor = true;
            this.btnDbSelectPath.Click += new System.EventHandler(this.btnDbSelectPath_Click);
            // 
            // txtDbBakPath
            // 
            this.txtDbBakPath.Location = new System.Drawing.Point(65, 42);
            this.txtDbBakPath.Name = "txtDbBakPath";
            this.txtDbBakPath.ReadOnly = true;
            this.txtDbBakPath.Size = new System.Drawing.Size(316, 21);
            this.txtDbBakPath.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "备份路径";
            // 
            // rbtnDb15Day
            // 
            this.rbtnDb15Day.AutoSize = true;
            this.rbtnDb15Day.Location = new System.Drawing.Point(236, 20);
            this.rbtnDb15Day.Name = "rbtnDb15Day";
            this.rbtnDb15Day.Size = new System.Drawing.Size(47, 16);
            this.rbtnDb15Day.TabIndex = 0;
            this.rbtnDb15Day.TabStop = true;
            this.rbtnDb15Day.Text = "15天";
            this.rbtnDb15Day.UseVisualStyleBackColor = true;
            // 
            // rbtnDb7Day
            // 
            this.rbtnDb7Day.AutoSize = true;
            this.rbtnDb7Day.Location = new System.Drawing.Point(160, 20);
            this.rbtnDb7Day.Name = "rbtnDb7Day";
            this.rbtnDb7Day.Size = new System.Drawing.Size(41, 16);
            this.rbtnDb7Day.TabIndex = 0;
            this.rbtnDb7Day.TabStop = true;
            this.rbtnDb7Day.Text = "7天";
            this.rbtnDb7Day.UseVisualStyleBackColor = true;
            // 
            // rbtnDb3Day
            // 
            this.rbtnDb3Day.AutoSize = true;
            this.rbtnDb3Day.Location = new System.Drawing.Point(88, 20);
            this.rbtnDb3Day.Name = "rbtnDb3Day";
            this.rbtnDb3Day.Size = new System.Drawing.Size(41, 16);
            this.rbtnDb3Day.TabIndex = 0;
            this.rbtnDb3Day.TabStop = true;
            this.rbtnDb3Day.Text = "3天";
            this.rbtnDb3Day.UseVisualStyleBackColor = true;
            // 
            // rbtnDbDay
            // 
            this.rbtnDbDay.AutoSize = true;
            this.rbtnDbDay.Checked = true;
            this.rbtnDbDay.Location = new System.Drawing.Point(9, 20);
            this.rbtnDbDay.Name = "rbtnDbDay";
            this.rbtnDbDay.Size = new System.Drawing.Size(47, 16);
            this.rbtnDbDay.TabIndex = 0;
            this.rbtnDbDay.TabStop = true;
            this.rbtnDbDay.Text = "每天";
            this.rbtnDbDay.UseVisualStyleBackColor = true;
            // 
            // chbAll
            // 
            this.chbAll.AutoSize = true;
            this.chbAll.Location = new System.Drawing.Point(32, 390);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(48, 16);
            this.chbAll.TabIndex = 4;
            this.chbAll.Text = "全选";
            this.chbAll.UseVisualStyleBackColor = true;
            this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDbConetstring);
            this.panel1.Controls.Add(this.btnDbContent);
            this.panel1.Controls.Add(this.txtDbAccPsd);
            this.panel1.Controls.Add(this.txtDbAccName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(488, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 337);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "数据库连接字符串";
            // 
            // txtDbConetstring
            // 
            this.txtDbConetstring.Location = new System.Drawing.Point(16, 208);
            this.txtDbConetstring.Multiline = true;
            this.txtDbConetstring.Name = "txtDbConetstring";
            this.txtDbConetstring.ReadOnly = true;
            this.txtDbConetstring.Size = new System.Drawing.Size(219, 120);
            this.txtDbConetstring.TabIndex = 6;
            // 
            // btnDbContent
            // 
            this.btnDbContent.Location = new System.Drawing.Point(16, 109);
            this.btnDbContent.Name = "btnDbContent";
            this.btnDbContent.Size = new System.Drawing.Size(75, 23);
            this.btnDbContent.TabIndex = 5;
            this.btnDbContent.Text = "测试连接";
            this.btnDbContent.UseVisualStyleBackColor = true;
            this.btnDbContent.Click += new System.EventHandler(this.btnDbContent_Click);
            // 
            // txtDbAccPsd
            // 
            this.txtDbAccPsd.Location = new System.Drawing.Point(16, 82);
            this.txtDbAccPsd.MaxLength = 50;
            this.txtDbAccPsd.Name = "txtDbAccPsd";
            this.txtDbAccPsd.Size = new System.Drawing.Size(219, 21);
            this.txtDbAccPsd.TabIndex = 3;
            // 
            // txtDbAccName
            // 
            this.txtDbAccName.Location = new System.Drawing.Point(16, 30);
            this.txtDbAccName.MaxLength = 50;
            this.txtDbAccName.Name = "txtDbAccName";
            this.txtDbAccName.Size = new System.Drawing.Size(219, 21);
            this.txtDbAccName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据库访问密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据库访问名";
            // 
            // dataGridViewDb
            // 
            this.dataGridViewDb.AllowUserToAddRows = false;
            this.dataGridViewDb.AllowUserToDeleteRows = false;
            this.dataGridViewDb.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_check,
            this.c2,
            this.DBSize});
            this.dataGridViewDb.Location = new System.Drawing.Point(22, 43);
            this.dataGridViewDb.Name = "dataGridViewDb";
            this.dataGridViewDb.RowTemplate.Height = 23;
            this.dataGridViewDb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDb.Size = new System.Drawing.Size(442, 337);
            this.dataGridViewDb.TabIndex = 1;
            this.dataGridViewDb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDb_CellClick);
            // 
            // cb_check
            // 
            this.cb_check.Frozen = true;
            this.cb_check.HeaderText = "";
            this.cb_check.Name = "cb_check";
            this.cb_check.ReadOnly = true;
            this.cb_check.Width = 50;
            // 
            // c2
            // 
            this.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c2.DataPropertyName = "name";
            this.c2.Frozen = true;
            this.c2.HeaderText = "数据库名称";
            this.c2.MaxInputLength = 200;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Width = 200;
            // 
            // DBSize
            // 
            this.DBSize.DataPropertyName = "DBSize";
            this.DBSize.HeaderText = "数据库ID";
            this.DBSize.MaxInputLength = 200;
            this.DBSize.Name = "DBSize";
            this.DBSize.ReadOnly = true;
            this.DBSize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DBSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DBSize.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库列表";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labUploadProgress);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.txtEndpoint);
            this.tabPage2.Controls.Add(this.txtBucketName);
            this.tabPage2.Controls.Add(this.txtAccessKey);
            this.tabPage2.Controls.Add(this.txtAccessId);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置阿里云OSS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labUploadProgress
            // 
            this.labUploadProgress.AutoSize = true;
            this.labUploadProgress.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUploadProgress.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labUploadProgress.Location = new System.Drawing.Point(640, 486);
            this.labUploadProgress.Name = "labUploadProgress";
            this.labUploadProgress.Size = new System.Drawing.Size(98, 12);
            this.labUploadProgress.TabIndex = 15;
            this.labUploadProgress.Text = "上传进度：100%";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dataGridViewOss);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(25, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 304);
            this.panel2.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "数据库备份文件列表";
            // 
            // dataGridViewOss
            // 
            this.dataGridViewOss.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c3,
            this.C4});
            this.dataGridViewOss.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewOss.Location = new System.Drawing.Point(26, 33);
            this.dataGridViewOss.Name = "dataGridViewOss";
            this.dataGridViewOss.RowTemplate.Height = 23;
            this.dataGridViewOss.Size = new System.Drawing.Size(659, 150);
            this.dataGridViewOss.TabIndex = 1;
            // 
            // c3
            // 
            this.c3.DataPropertyName = "name";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c3.DefaultCellStyle = dataGridViewCellStyle5;
            this.c3.HeaderText = "数据库名称";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Width = 400;
            // 
            // C4
            // 
            this.C4.DataPropertyName = "DBSize";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.C4.DefaultCellStyle = dataGridViewCellStyle6;
            this.C4.HeaderText = "数据库ID";
            this.C4.Name = "C4";
            this.C4.Width = 180;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbUpload);
            this.groupBox2.Controls.Add(this.btnOssOk);
            this.groupBox2.Controls.Add(this.btnOssSelect);
            this.groupBox2.Controls.Add(this.txtOssDbPath);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.rbtnOss15Day);
            this.groupBox2.Controls.Add(this.rbtnOss7Day);
            this.groupBox2.Controls.Add(this.rbtnOss3Day);
            this.groupBox2.Controls.Add(this.rbtnOssDay);
            this.groupBox2.Location = new System.Drawing.Point(26, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "上传份时间与路径设置";
            // 
            // chbUpload
            // 
            this.chbUpload.AutoSize = true;
            this.chbUpload.Checked = true;
            this.chbUpload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUpload.Location = new System.Drawing.Point(318, 32);
            this.chbUpload.Name = "chbUpload";
            this.chbUpload.Size = new System.Drawing.Size(96, 16);
            this.chbUpload.TabIndex = 19;
            this.chbUpload.Text = "启动断点续传";
            this.chbUpload.UseVisualStyleBackColor = true;
            // 
            // btnOssOk
            // 
            this.btnOssOk.Location = new System.Drawing.Point(528, 61);
            this.btnOssOk.Name = "btnOssOk";
            this.btnOssOk.Size = new System.Drawing.Size(113, 23);
            this.btnOssOk.TabIndex = 18;
            this.btnOssOk.Text = "确定并自动上传";
            this.btnOssOk.UseVisualStyleBackColor = true;
            this.btnOssOk.Click += new System.EventHandler(this.btnOssOk_Click);
            // 
            // btnOssSelect
            // 
            this.btnOssSelect.Font = new System.Drawing.Font("宋体", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOssSelect.Location = new System.Drawing.Point(457, 63);
            this.btnOssSelect.Name = "btnOssSelect";
            this.btnOssSelect.Size = new System.Drawing.Size(28, 21);
            this.btnOssSelect.TabIndex = 17;
            this.btnOssSelect.Text = "....";
            this.btnOssSelect.UseVisualStyleBackColor = true;
            this.btnOssSelect.Click += new System.EventHandler(this.btnOssSelect_Click);
            // 
            // txtOssDbPath
            // 
            this.txtOssDbPath.Location = new System.Drawing.Point(106, 63);
            this.txtOssDbPath.Name = "txtOssDbPath";
            this.txtOssDbPath.ReadOnly = true;
            this.txtOssDbPath.Size = new System.Drawing.Size(345, 21);
            this.txtOssDbPath.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "数据库备份路径";
            // 
            // rbtnOss15Day
            // 
            this.rbtnOss15Day.AutoSize = true;
            this.rbtnOss15Day.Location = new System.Drawing.Point(242, 32);
            this.rbtnOss15Day.Name = "rbtnOss15Day";
            this.rbtnOss15Day.Size = new System.Drawing.Size(47, 16);
            this.rbtnOss15Day.TabIndex = 14;
            this.rbtnOss15Day.TabStop = true;
            this.rbtnOss15Day.Text = "15天";
            this.rbtnOss15Day.UseVisualStyleBackColor = true;
            // 
            // rbtnOss7Day
            // 
            this.rbtnOss7Day.AutoSize = true;
            this.rbtnOss7Day.Location = new System.Drawing.Point(166, 32);
            this.rbtnOss7Day.Name = "rbtnOss7Day";
            this.rbtnOss7Day.Size = new System.Drawing.Size(41, 16);
            this.rbtnOss7Day.TabIndex = 12;
            this.rbtnOss7Day.TabStop = true;
            this.rbtnOss7Day.Text = "7天";
            this.rbtnOss7Day.UseVisualStyleBackColor = true;
            // 
            // rbtnOss3Day
            // 
            this.rbtnOss3Day.AutoSize = true;
            this.rbtnOss3Day.Location = new System.Drawing.Point(94, 32);
            this.rbtnOss3Day.Name = "rbtnOss3Day";
            this.rbtnOss3Day.Size = new System.Drawing.Size(41, 16);
            this.rbtnOss3Day.TabIndex = 13;
            this.rbtnOss3Day.TabStop = true;
            this.rbtnOss3Day.Text = "3天";
            this.rbtnOss3Day.UseVisualStyleBackColor = true;
            // 
            // rbtnOssDay
            // 
            this.rbtnOssDay.AutoSize = true;
            this.rbtnOssDay.Checked = true;
            this.rbtnOssDay.Location = new System.Drawing.Point(15, 32);
            this.rbtnOssDay.Name = "rbtnOssDay";
            this.rbtnOssDay.Size = new System.Drawing.Size(47, 16);
            this.rbtnOssDay.TabIndex = 11;
            this.rbtnOssDay.TabStop = true;
            this.rbtnOssDay.Text = "每天";
            this.rbtnOssDay.UseVisualStyleBackColor = true;
            // 
            // txtEndpoint
            // 
            this.txtEndpoint.Location = new System.Drawing.Point(133, 106);
            this.txtEndpoint.MaxLength = 200;
            this.txtEndpoint.Name = "txtEndpoint";
            this.txtEndpoint.Size = new System.Drawing.Size(369, 21);
            this.txtEndpoint.TabIndex = 12;
            // 
            // txtBucketName
            // 
            this.txtBucketName.Location = new System.Drawing.Point(133, 134);
            this.txtBucketName.MaxLength = 200;
            this.txtBucketName.Name = "txtBucketName";
            this.txtBucketName.Size = new System.Drawing.Size(369, 21);
            this.txtBucketName.TabIndex = 11;
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(133, 77);
            this.txtAccessKey.MaxLength = 200;
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(369, 21);
            this.txtAccessKey.TabIndex = 10;
            // 
            // txtAccessId
            // 
            this.txtAccessId.Location = new System.Drawing.Point(133, 49);
            this.txtAccessId.MaxLength = 200;
            this.txtAccessId.Name = "txtAccessId";
            this.txtAccessId.Size = new System.Drawing.Size(369, 21);
            this.txtAccessId.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "BucketName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "Endpoint";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "AccessKey";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "AccessId";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(710, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(282, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "阿里云OSS设置";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewPathDb);
            this.tabPage3.Controls.Add(this.dataGridViewHistyOss);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "备份历史";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPathDb
            // 
            this.dataGridViewPathDb.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewPathDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPathDb.Location = new System.Drawing.Point(3, 303);
            this.dataGridViewPathDb.Name = "dataGridViewPathDb";
            this.dataGridViewPathDb.RowTemplate.Height = 23;
            this.dataGridViewPathDb.Size = new System.Drawing.Size(746, 193);
            this.dataGridViewPathDb.TabIndex = 5;
            // 
            // dataGridViewHistyOss
            // 
            this.dataGridViewHistyOss.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridViewHistyOss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistyOss.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewHistyOss.Name = "dataGridViewHistyOss";
            this.dataGridViewHistyOss.RowTemplate.Height = 23;
            this.dataGridViewHistyOss.Size = new System.Drawing.Size(746, 197);
            this.dataGridViewHistyOss.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(345, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 26);
            this.label16.TabIndex = 3;
            this.label16.Text = "本地备份";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(272, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 26);
            this.label15.TabIndex = 2;
            this.label15.Text = "已上传到阿里云的备份文件";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "云投石化数据库备份";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNPC数据库备份阿里云OSS应用程序";
            this.MinimumSizeChanged += new System.EventHandler(this.MainFrom_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrom_FormClosing);
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.SizeChanged += new System.EventHandler(this.MainFrom_SizeChanged);
            this.Resize += new System.EventHandler(this.MainFrom_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDb)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOss)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPathDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistyOss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDbBak;
        private System.Windows.Forms.Button btnDbAutoBak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDbSelectPath;
        private System.Windows.Forms.TextBox txtDbBakPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnDb15Day;
        private System.Windows.Forms.RadioButton rbtnDb7Day;
        private System.Windows.Forms.RadioButton rbtnDb3Day;
        private System.Windows.Forms.RadioButton rbtnDbDay;
        private System.Windows.Forms.CheckBox chbAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDbConetstring;
        private System.Windows.Forms.Button btnDbContent;
        private System.Windows.Forms.TextBox txtDbAccPsd;
        private System.Windows.Forms.TextBox txtDbAccName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewOss;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOssOk;
        private System.Windows.Forms.Button btnOssSelect;
        private System.Windows.Forms.TextBox txtOssDbPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbtnOss15Day;
        private System.Windows.Forms.RadioButton rbtnOss7Day;
        private System.Windows.Forms.RadioButton rbtnOss3Day;
        private System.Windows.Forms.RadioButton rbtnOssDay;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.TextBox txtBucketName;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.TextBox txtAccessId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewPathDb;
        private System.Windows.Forms.DataGridView dataGridViewHistyOss;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.Label labUploadProgress;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chbUpload;
    }
}

