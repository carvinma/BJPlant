namespace BJ_Plant_Design
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Chk_Flower_Color = new System.Windows.Forms.CheckBox();
            this.Chk_Flower_Date = new System.Windows.Forms.CheckBox();
            this.cmbFlower_Date = new System.Windows.Forms.ComboBox();
            this.cmbFlower_Color = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Chk_F_Color = new System.Windows.Forms.CheckBox();
            this.cmbye_Color = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Chk_Fruit_Color = new System.Windows.Forms.CheckBox();
            this.Chk_Fruit_Date = new System.Windows.Forms.CheckBox();
            this.cmbFruit_Date = new System.Windows.Forms.ComboBox();
            this.cmbFruit_Color = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbPlant_Hight = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbFlower_Type = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmbIs_cl = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cmbResistance = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cmbMangement = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前进一步ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.后退一步ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原一步ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.变形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平面图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.立面图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.效果图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.爱上大声地ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 25);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类型";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbType.Items.AddRange(new object[] {
            "------请选择-----",
            "宿根花卉",
            "一二年生花卉",
            "球根花卉",
            "一年生或多年生花卉",
            "一年生花卉",
            "多年生花卉",
            "一年或短期多年生花卉",
            "灌木"});
            this.cmbType.Location = new System.Drawing.Point(73, 0);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 20);
            this.cmbType.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Chk_Flower_Color);
            this.groupBox2.Controls.Add(this.Chk_Flower_Date);
            this.groupBox2.Controls.Add(this.cmbFlower_Date);
            this.groupBox2.Controls.Add(this.cmbFlower_Color);
            this.groupBox2.Location = new System.Drawing.Point(31, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "观花";
            // 
            // Chk_Flower_Color
            // 
            this.Chk_Flower_Color.AutoSize = true;
            this.Chk_Flower_Color.Location = new System.Drawing.Point(15, 45);
            this.Chk_Flower_Color.Name = "Chk_Flower_Color";
            this.Chk_Flower_Color.Size = new System.Drawing.Size(48, 16);
            this.Chk_Flower_Color.TabIndex = 1;
            this.Chk_Flower_Color.Text = "颜色";
            this.Chk_Flower_Color.UseVisualStyleBackColor = true;
            // 
            // Chk_Flower_Date
            // 
            this.Chk_Flower_Date.AutoSize = true;
            this.Chk_Flower_Date.Location = new System.Drawing.Point(15, 20);
            this.Chk_Flower_Date.Name = "Chk_Flower_Date";
            this.Chk_Flower_Date.Size = new System.Drawing.Size(48, 16);
            this.Chk_Flower_Date.TabIndex = 0;
            this.Chk_Flower_Date.Text = "花期";
            this.Chk_Flower_Date.UseVisualStyleBackColor = true;
            // 
            // cmbFlower_Date
            // 
            this.cmbFlower_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlower_Date.FormattingEnabled = true;
            this.cmbFlower_Date.Items.AddRange(new object[] {
            "------请选择-----",
            "7~8月",
            "6~10月",
            "6~9月",
            "6~7月",
            "4~5月",
            "5~9月",
            "7~10月",
            "9~10月",
            "6~10月",
            "6~7月",
            "5~7月",
            "6~10月",
            "8~9月",
            "5~6月",
            "7~10月",
            "6~8月",
            "10月",
            "因栽培时间而异",
            "4~10月",
            "5~8月",
            "8~9月",
            "4~7月",
            "7~9月",
            "6~8月",
            "3~5月",
            "4~5月",
            "无"});
            this.cmbFlower_Date.Location = new System.Drawing.Point(73, 14);
            this.cmbFlower_Date.Name = "cmbFlower_Date";
            this.cmbFlower_Date.Size = new System.Drawing.Size(121, 20);
            this.cmbFlower_Date.TabIndex = 9;
            // 
            // cmbFlower_Color
            // 
            this.cmbFlower_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlower_Color.FormattingEnabled = true;
            this.cmbFlower_Color.Items.AddRange(new object[] {
            "------请选择-----",
            "红",
            "黄",
            "蓝",
            "白",
            "紫",
            "白蓝",
            "白红",
            "红黄",
            "蓝红",
            "白，粉",
            "蓝，白",
            "蓝紫",
            "紫，白，黄",
            "桃红",
            "红，紫",
            "绿白",
            "黄绿",
            "无"});
            this.cmbFlower_Color.Location = new System.Drawing.Point(74, 43);
            this.cmbFlower_Color.Name = "cmbFlower_Color";
            this.cmbFlower_Color.Size = new System.Drawing.Size(121, 20);
            this.cmbFlower_Color.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Chk_F_Color);
            this.groupBox3.Controls.Add(this.cmbye_Color);
            this.groupBox3.Location = new System.Drawing.Point(31, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "观叶";
            // 
            // Chk_F_Color
            // 
            this.Chk_F_Color.AutoSize = true;
            this.Chk_F_Color.Location = new System.Drawing.Point(15, 21);
            this.Chk_F_Color.Name = "Chk_F_Color";
            this.Chk_F_Color.Size = new System.Drawing.Size(48, 16);
            this.Chk_F_Color.TabIndex = 0;
            this.Chk_F_Color.Text = "颜色";
            this.Chk_F_Color.UseVisualStyleBackColor = true;
            // 
            // cmbye_Color
            // 
            this.cmbye_Color.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cmbye_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbye_Color.FormattingEnabled = true;
            this.cmbye_Color.Items.AddRange(new object[] {
            "------请选择-----",
            "绿色",
            "金色",
            "紫色",
            "花色"});
            this.cmbye_Color.Location = new System.Drawing.Point(74, 19);
            this.cmbye_Color.Name = "cmbye_Color";
            this.cmbye_Color.Size = new System.Drawing.Size(121, 20);
            this.cmbye_Color.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Chk_Fruit_Color);
            this.groupBox4.Controls.Add(this.Chk_Fruit_Date);
            this.groupBox4.Controls.Add(this.cmbFruit_Date);
            this.groupBox4.Controls.Add(this.cmbFruit_Color);
            this.groupBox4.Location = new System.Drawing.Point(31, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 72);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "观果";
            // 
            // Chk_Fruit_Color
            // 
            this.Chk_Fruit_Color.AutoSize = true;
            this.Chk_Fruit_Color.Location = new System.Drawing.Point(15, 43);
            this.Chk_Fruit_Color.Name = "Chk_Fruit_Color";
            this.Chk_Fruit_Color.Size = new System.Drawing.Size(48, 16);
            this.Chk_Fruit_Color.TabIndex = 1;
            this.Chk_Fruit_Color.Text = "颜色";
            this.Chk_Fruit_Color.UseVisualStyleBackColor = true;
            // 
            // Chk_Fruit_Date
            // 
            this.Chk_Fruit_Date.AutoSize = true;
            this.Chk_Fruit_Date.Location = new System.Drawing.Point(15, 21);
            this.Chk_Fruit_Date.Name = "Chk_Fruit_Date";
            this.Chk_Fruit_Date.Size = new System.Drawing.Size(48, 16);
            this.Chk_Fruit_Date.TabIndex = 0;
            this.Chk_Fruit_Date.Text = "果期";
            this.Chk_Fruit_Date.UseVisualStyleBackColor = true;
            // 
            // cmbFruit_Date
            // 
            this.cmbFruit_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFruit_Date.FormattingEnabled = true;
            this.cmbFruit_Date.Items.AddRange(new object[] {
            "------请选择-----",
            "7月",
            "8月",
            "9月",
            "5~8月",
            "6~7月",
            "6~8月",
            "8~9月",
            "8~10月",
            "9~10月",
            "6~10月",
            "7~10月",
            "10~11月"});
            this.cmbFruit_Date.Location = new System.Drawing.Point(74, 17);
            this.cmbFruit_Date.Name = "cmbFruit_Date";
            this.cmbFruit_Date.Size = new System.Drawing.Size(121, 20);
            this.cmbFruit_Date.TabIndex = 12;
            // 
            // cmbFruit_Color
            // 
            this.cmbFruit_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFruit_Color.FormattingEnabled = true;
            this.cmbFruit_Color.Items.AddRange(new object[] {
            "------请选择-----",
            "棕色"});
            this.cmbFruit_Color.Location = new System.Drawing.Point(73, 46);
            this.cmbFruit_Color.Name = "cmbFruit_Color";
            this.cmbFruit_Color.Size = new System.Drawing.Size(121, 20);
            this.cmbFruit_Color.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.cmbPlant_Hight);
            this.groupBox5.Location = new System.Drawing.Point(31, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 23);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "高度";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(0, 45);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 40);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "冠幅";
            // 
            // cmbPlant_Hight
            // 
            this.cmbPlant_Hight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlant_Hight.FormattingEnabled = true;
            this.cmbPlant_Hight.Items.AddRange(new object[] {
            "------请选择-----",
            "5",
            "18",
            "19",
            "20",
            "25",
            "30",
            "40",
            "45",
            "50",
            "55",
            "60",
            "70",
            "80",
            "84",
            "85",
            "90",
            "95",
            "100",
            "119",
            "120",
            "146",
            "150",
            "170",
            "175"});
            this.cmbPlant_Hight.Location = new System.Drawing.Point(73, -3);
            this.cmbPlant_Hight.Name = "cmbPlant_Hight";
            this.cmbPlant_Hight.Size = new System.Drawing.Size(121, 20);
            this.cmbPlant_Hight.TabIndex = 14;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbFlower_Type);
            this.groupBox7.Location = new System.Drawing.Point(31, 276);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 26);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "花型";
            // 
            // cmbFlower_Type
            // 
            this.cmbFlower_Type.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFlower_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlower_Type.FormattingEnabled = true;
            this.cmbFlower_Type.Items.AddRange(new object[] {
            "------请选择-----",
            "水平线条",
            "竖线条",
            "独立花头"});
            this.cmbFlower_Type.Location = new System.Drawing.Point(73, 0);
            this.cmbFlower_Type.Name = "cmbFlower_Type";
            this.cmbFlower_Type.Size = new System.Drawing.Size(121, 20);
            this.cmbFlower_Type.TabIndex = 15;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cmbIs_cl);
            this.groupBox8.Location = new System.Drawing.Point(31, 312);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 25);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "常绿";
            // 
            // cmbIs_cl
            // 
            this.cmbIs_cl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIs_cl.FormattingEnabled = true;
            this.cmbIs_cl.Items.AddRange(new object[] {
            "------请选择-----",
            "是",
            "否"});
            this.cmbIs_cl.Location = new System.Drawing.Point(73, -1);
            this.cmbIs_cl.Name = "cmbIs_cl";
            this.cmbIs_cl.Size = new System.Drawing.Size(121, 20);
            this.cmbIs_cl.TabIndex = 16;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cmbResistance);
            this.groupBox9.Location = new System.Drawing.Point(31, 343);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 29);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "耐性";
            // 
            // cmbResistance
            // 
            this.cmbResistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResistance.FormattingEnabled = true;
            this.cmbResistance.Items.AddRange(new object[] {
            "------请选择-----",
            "耐旱",
            "耐寒",
            "耐阴",
            "耐寒、耐旱",
            "耐阴、耐寒",
            "耐阴、耐旱",
            "耐寒、耐涝",
            "耐阴、耐寒、耐旱",
            "耐寒、耐瘠薄"});
            this.cmbResistance.Location = new System.Drawing.Point(73, 0);
            this.cmbResistance.Name = "cmbResistance";
            this.cmbResistance.Size = new System.Drawing.Size(121, 20);
            this.cmbResistance.TabIndex = 17;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cmbMangement);
            this.groupBox10.Location = new System.Drawing.Point(31, 378);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 25);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "管理";
            // 
            // cmbMangement
            // 
            this.cmbMangement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMangement.FormattingEnabled = true;
            this.cmbMangement.Items.AddRange(new object[] {
            "------请选择-----",
            "粗放",
            "一般",
            "密集"});
            this.cmbMangement.Location = new System.Drawing.Point(73, 0);
            this.cmbMangement.Name = "cmbMangement";
            this.cmbMangement.Size = new System.Drawing.Size(121, 20);
            this.cmbMangement.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.图像VToolStripMenuItem,
            this.视图IToolStripMenuItem,
            this.返回ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.文件ToolStripMenuItem.Text = "文件（F）";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前进一步ToolStripMenuItem,
            this.后退一步ToolStripMenuItem,
            this.还原一步ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.编辑EToolStripMenuItem.Text = "编辑（E）";
            // 
            // 前进一步ToolStripMenuItem
            // 
            this.前进一步ToolStripMenuItem.Name = "前进一步ToolStripMenuItem";
            this.前进一步ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.前进一步ToolStripMenuItem.Text = "前进一步";
            // 
            // 后退一步ToolStripMenuItem
            // 
            this.后退一步ToolStripMenuItem.Name = "后退一步ToolStripMenuItem";
            this.后退一步ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.后退一步ToolStripMenuItem.Text = "后退一步";
            // 
            // 还原一步ToolStripMenuItem
            // 
            this.还原一步ToolStripMenuItem.Name = "还原一步ToolStripMenuItem";
            this.还原一步ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.还原一步ToolStripMenuItem.Text = "还原一步";
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            // 
            // 图像VToolStripMenuItem
            // 
            this.图像VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.粘贴ToolStripMenuItem1,
            this.变形ToolStripMenuItem});
            this.图像VToolStripMenuItem.Name = "图像VToolStripMenuItem";
            this.图像VToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.图像VToolStripMenuItem.Text = "图像（I）";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.导入ToolStripMenuItem.Text = "导入";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem.Text = "剪切";
            // 
            // 粘贴ToolStripMenuItem1
            // 
            this.粘贴ToolStripMenuItem1.Name = "粘贴ToolStripMenuItem1";
            this.粘贴ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem1.Text = "粘贴";
            // 
            // 变形ToolStripMenuItem
            // 
            this.变形ToolStripMenuItem.Name = "变形ToolStripMenuItem";
            this.变形ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.变形ToolStripMenuItem.Text = "变形";
            // 
            // 视图IToolStripMenuItem
            // 
            this.视图IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全视图ToolStripMenuItem,
            this.平面图ToolStripMenuItem,
            this.立面图ToolStripMenuItem,
            this.效果图ToolStripMenuItem});
            this.视图IToolStripMenuItem.Name = "视图IToolStripMenuItem";
            this.视图IToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.视图IToolStripMenuItem.Text = "视图（V）";
            // 
            // 全视图ToolStripMenuItem
            // 
            this.全视图ToolStripMenuItem.Name = "全视图ToolStripMenuItem";
            this.全视图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.全视图ToolStripMenuItem.Text = "全视图";
            // 
            // 平面图ToolStripMenuItem
            // 
            this.平面图ToolStripMenuItem.Name = "平面图ToolStripMenuItem";
            this.平面图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.平面图ToolStripMenuItem.Text = "平面图";
            // 
            // 立面图ToolStripMenuItem
            // 
            this.立面图ToolStripMenuItem.Name = "立面图ToolStripMenuItem";
            this.立面图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.立面图ToolStripMenuItem.Text = "立面图";
            // 
            // 效果图ToolStripMenuItem
            // 
            this.效果图ToolStripMenuItem.Name = "效果图ToolStripMenuItem";
            this.效果图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.效果图ToolStripMenuItem.Text = "效果图";
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.爱上大声地ToolStripMenuItem});
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(112, 21);
            this.返回ToolStripMenuItem.Text = "返回主界面（R）";
            this.返回ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 爱上大声地ToolStripMenuItem
            // 
            this.爱上大声地ToolStripMenuItem.Name = "爱上大声地ToolStripMenuItem";
            this.爱上大声地ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.爱上大声地ToolStripMenuItem.Text = "爱上大声地";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(156, 409);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 101);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox10);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox9);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.btn);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(898, 441);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 11;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(233, 244);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 10;
            this.btn.Text = "按钮";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 466);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Chk_Flower_Color;
        private System.Windows.Forms.CheckBox Chk_Flower_Date;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Chk_F_Color;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox Chk_Fruit_Color;
        private System.Windows.Forms.CheckBox Chk_Fruit_Date;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 爱上大声地ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbFlower_Date;
        private System.Windows.Forms.ComboBox cmbFlower_Color;
        private System.Windows.Forms.ComboBox cmbye_Color;
        private System.Windows.Forms.ComboBox cmbFruit_Date;
        private System.Windows.Forms.ComboBox cmbFruit_Color;
        private System.Windows.Forms.ComboBox cmbPlant_Hight;
        private System.Windows.Forms.ComboBox cmbFlower_Type;
        private System.Windows.Forms.ComboBox cmbIs_cl;
        private System.Windows.Forms.ComboBox cmbResistance;
        private System.Windows.Forms.ComboBox cmbMangement;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前进一步ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 后退一步ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原一步ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 变形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平面图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 立面图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 效果图ToolStripMenuItem;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn;
    }
}

