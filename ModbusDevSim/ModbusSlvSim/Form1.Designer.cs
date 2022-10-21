﻿namespace ModbusSlvSim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlb_main = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtr_main = new System.Windows.Forms.RichTextBox();
            this.tlb_sp = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_spx = new System.Windows.Forms.ComboBox();
            this.btn_find_sp = new System.Windows.Forms.Button();
            this.btn_sp_con = new System.Windows.Forms.Button();
            this.btn_sp_discon = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_flowrate = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.btn_stop_wm = new System.Windows.Forms.Button();
            this.btn_start_wm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_update_wm_settings = new System.Windows.Forms.Button();
            this.nud_temp = new System.Windows.Forms.NumericUpDown();
            this.nud_flowrate = new System.Windows.Forms.NumericUpDown();
            this.nud_volume = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbx_binary_err_code = new System.Windows.Forms.ComboBox();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.chk_err_code = new System.Windows.Forms.CheckBox();
            this.chk_ontime = new System.Windows.Forms.CheckBox();
            this.chk_flowrate = new System.Windows.Forms.CheckBox();
            this.chk_serial_no = new System.Windows.Forms.CheckBox();
            this.chk_temp = new System.Windows.Forms.CheckBox();
            this.chk_rev_volume = new System.Windows.Forms.CheckBox();
            this.chk_vol = new System.Windows.Forms.CheckBox();
            this.chk_dt = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tlb_main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tlb_sp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_flowrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlb_main
            // 
            this.tlb_main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlb_main.ColumnCount = 1;
            this.tlb_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlb_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlb_main.Controls.Add(this.menuStrip1, 0, 0);
            this.tlb_main.Controls.Add(this.txtr_main, 0, 3);
            this.tlb_main.Controls.Add(this.tlb_sp, 0, 1);
            this.tlb_main.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlb_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlb_main.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tlb_main.Location = new System.Drawing.Point(0, 0);
            this.tlb_main.Name = "tlb_main";
            this.tlb_main.RowCount = 4;
            this.tlb_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlb_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlb_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlb_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlb_main.Size = new System.Drawing.Size(1073, 633);
            this.tlb_main.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 20);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 16);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // txtr_main
            // 
            this.txtr_main.BackColor = System.Drawing.Color.Black;
            this.txtr_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtr_main.ForeColor = System.Drawing.Color.Lime;
            this.txtr_main.Location = new System.Drawing.Point(4, 407);
            this.txtr_main.Name = "txtr_main";
            this.txtr_main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtr_main.Size = new System.Drawing.Size(1065, 222);
            this.txtr_main.TabIndex = 1;
            this.txtr_main.Text = "";
            // 
            // tlb_sp
            // 
            this.tlb_sp.ColumnCount = 4;
            this.tlb_sp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlb_sp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlb_sp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlb_sp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlb_sp.Controls.Add(this.cbx_spx, 0, 0);
            this.tlb_sp.Controls.Add(this.btn_find_sp, 1, 0);
            this.tlb_sp.Controls.Add(this.btn_sp_con, 2, 0);
            this.tlb_sp.Controls.Add(this.btn_sp_discon, 3, 0);
            this.tlb_sp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlb_sp.Location = new System.Drawing.Point(4, 25);
            this.tlb_sp.Name = "tlb_sp";
            this.tlb_sp.RowCount = 1;
            this.tlb_sp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlb_sp.Size = new System.Drawing.Size(1065, 34);
            this.tlb_sp.TabIndex = 2;
            // 
            // cbx_spx
            // 
            this.cbx_spx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_spx.FormattingEnabled = true;
            this.cbx_spx.Location = new System.Drawing.Point(3, 3);
            this.cbx_spx.Name = "cbx_spx";
            this.cbx_spx.Size = new System.Drawing.Size(420, 29);
            this.cbx_spx.TabIndex = 0;
            // 
            // btn_find_sp
            // 
            this.btn_find_sp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_find_sp.Location = new System.Drawing.Point(429, 3);
            this.btn_find_sp.Name = "btn_find_sp";
            this.btn_find_sp.Size = new System.Drawing.Size(207, 28);
            this.btn_find_sp.TabIndex = 1;
            this.btn_find_sp.Text = "Find COM Ports";
            this.btn_find_sp.UseVisualStyleBackColor = true;
            // 
            // btn_sp_con
            // 
            this.btn_sp_con.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sp_con.Location = new System.Drawing.Point(642, 3);
            this.btn_sp_con.Name = "btn_sp_con";
            this.btn_sp_con.Size = new System.Drawing.Size(207, 28);
            this.btn_sp_con.TabIndex = 1;
            this.btn_sp_con.Text = "Connect";
            this.btn_sp_con.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sp_con.UseVisualStyleBackColor = true;
            // 
            // btn_sp_discon
            // 
            this.btn_sp_discon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sp_discon.Location = new System.Drawing.Point(855, 3);
            this.btn_sp_discon.Name = "btn_sp_discon";
            this.btn_sp_discon.Size = new System.Drawing.Size(207, 28);
            this.btn_sp_discon.TabIndex = 1;
            this.btn_sp_discon.Text = "Disconnect";
            this.btn_sp_discon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 334);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_temp);
            this.groupBox1.Controls.Add(this.lbl_flowrate);
            this.groupBox1.Controls.Add(this.lbl_volume);
            this.groupBox1.Controls.Add(this.btn_stop_wm);
            this.groupBox1.Controls.Add(this.btn_start_wm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Water Meter Operation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "\'C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "m3/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "m3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Temprature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Flow Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Volume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volume";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_temp.Location = new System.Drawing.Point(146, 220);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(25, 30);
            this.lbl_temp.TabIndex = 1;
            this.lbl_temp.Text = "0";
            // 
            // lbl_flowrate
            // 
            this.lbl_flowrate.AutoSize = true;
            this.lbl_flowrate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_flowrate.Location = new System.Drawing.Point(146, 178);
            this.lbl_flowrate.Name = "lbl_flowrate";
            this.lbl_flowrate.Size = new System.Drawing.Size(25, 30);
            this.lbl_flowrate.TabIndex = 1;
            this.lbl_flowrate.Text = "0";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_volume.Location = new System.Drawing.Point(146, 138);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(25, 30);
            this.lbl_volume.TabIndex = 1;
            this.lbl_volume.Text = "0";
            // 
            // btn_stop_wm
            // 
            this.btn_stop_wm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_stop_wm.Location = new System.Drawing.Point(205, 37);
            this.btn_stop_wm.Name = "btn_stop_wm";
            this.btn_stop_wm.Size = new System.Drawing.Size(78, 72);
            this.btn_stop_wm.TabIndex = 0;
            this.btn_stop_wm.Text = "Stop";
            this.btn_stop_wm.UseVisualStyleBackColor = false;
            // 
            // btn_start_wm
            // 
            this.btn_start_wm.BackColor = System.Drawing.Color.Lime;
            this.btn_start_wm.Location = new System.Drawing.Point(19, 37);
            this.btn_start_wm.Name = "btn_start_wm";
            this.btn_start_wm.Size = new System.Drawing.Size(78, 72);
            this.btn_start_wm.TabIndex = 0;
            this.btn_start_wm.Text = "Start";
            this.btn_start_wm.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_update_wm_settings);
            this.groupBox2.Controls.Add(this.nud_temp);
            this.groupBox2.Controls.Add(this.nud_flowrate);
            this.groupBox2.Controls.Add(this.nud_volume);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(358, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // btn_update_wm_settings
            // 
            this.btn_update_wm_settings.Location = new System.Drawing.Point(62, 220);
            this.btn_update_wm_settings.Name = "btn_update_wm_settings";
            this.btn_update_wm_settings.Size = new System.Drawing.Size(178, 43);
            this.btn_update_wm_settings.TabIndex = 4;
            this.btn_update_wm_settings.Text = "Update Setting";
            this.btn_update_wm_settings.UseVisualStyleBackColor = true;
            // 
            // nud_temp
            // 
            this.nud_temp.Location = new System.Drawing.Point(131, 143);
            this.nud_temp.Name = "nud_temp";
            this.nud_temp.Size = new System.Drawing.Size(85, 29);
            this.nud_temp.TabIndex = 3;
            this.nud_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_temp.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // nud_flowrate
            // 
            this.nud_flowrate.Location = new System.Drawing.Point(131, 92);
            this.nud_flowrate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_flowrate.Name = "nud_flowrate";
            this.nud_flowrate.Size = new System.Drawing.Size(85, 29);
            this.nud_flowrate.TabIndex = 3;
            this.nud_flowrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_flowrate.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // nud_volume
            // 
            this.nud_volume.Location = new System.Drawing.Point(110, 35);
            this.nud_volume.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_volume.Name = "nud_volume";
            this.nud_volume.Size = new System.Drawing.Size(130, 29);
            this.nud_volume.TabIndex = 3;
            this.nud_volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Temprature";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "\'C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Flowrate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "m3/h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Volume";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "m3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbx_binary_err_code);
            this.groupBox3.Controls.Add(this.cbx_status);
            this.groupBox3.Controls.Add(this.chk_err_code);
            this.groupBox3.Controls.Add(this.chk_ontime);
            this.groupBox3.Controls.Add(this.chk_flowrate);
            this.groupBox3.Controls.Add(this.chk_serial_no);
            this.groupBox3.Controls.Add(this.chk_temp);
            this.groupBox3.Controls.Add(this.chk_rev_volume);
            this.groupBox3.Controls.Add(this.chk_vol);
            this.groupBox3.Controls.Add(this.chk_dt);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(713, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 328);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status and Errors";
            // 
            // cbx_binary_err_code
            // 
            this.cbx_binary_err_code.FormattingEnabled = true;
            this.cbx_binary_err_code.Items.AddRange(new object[] {
            "OK (0x0000)",
            "Leakage (0x0001)   ",
            "Pipe Burst (0x0002)   ",
            "Reverse flow (0x0004)   ",
            "Dry (0x0008)   ",
            "Critical Config (0x0010)   ",
            "Measurement Fail (0x0020)   ",
            "Tamper (0x0040)   ",
            "Battery (0x0080)   ",
            "Unit change (0x0100)   ",
            "Service required (0x0200)   "});
            this.cbx_binary_err_code.Location = new System.Drawing.Point(110, 72);
            this.cbx_binary_err_code.Name = "cbx_binary_err_code";
            this.cbx_binary_err_code.Size = new System.Drawing.Size(187, 29);
            this.cbx_binary_err_code.TabIndex = 10;
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "Normal: 0x00",
            "Low Battery : 0x04",
            "Permannent Error: 0x08",
            "Dry or Temporary Error: 0x10",
            "Backflow: 0x70",
            "Manipulation: 0xD0",
            "Burst: 0xB0",
            "Leakage:  0x30"});
            this.cbx_status.Location = new System.Drawing.Point(110, 34);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(187, 29);
            this.cbx_status.TabIndex = 10;
            // 
            // chk_err_code
            // 
            this.chk_err_code.AutoSize = true;
            this.chk_err_code.Location = new System.Drawing.Point(170, 230);
            this.chk_err_code.Name = "chk_err_code";
            this.chk_err_code.Size = new System.Drawing.Size(107, 25);
            this.chk_err_code.TabIndex = 7;
            this.chk_err_code.Text = "Error code";
            this.chk_err_code.UseVisualStyleBackColor = true;
            // 
            // chk_ontime
            // 
            this.chk_ontime.AutoSize = true;
            this.chk_ontime.Location = new System.Drawing.Point(170, 207);
            this.chk_ontime.Name = "chk_ontime";
            this.chk_ontime.Size = new System.Drawing.Size(96, 25);
            this.chk_ontime.TabIndex = 8;
            this.chk_ontime.Text = "ON Time";
            this.chk_ontime.UseVisualStyleBackColor = true;
            // 
            // chk_flowrate
            // 
            this.chk_flowrate.AutoSize = true;
            this.chk_flowrate.Location = new System.Drawing.Point(24, 230);
            this.chk_flowrate.Name = "chk_flowrate";
            this.chk_flowrate.Size = new System.Drawing.Size(95, 25);
            this.chk_flowrate.TabIndex = 9;
            this.chk_flowrate.Text = "Flowrate";
            this.chk_flowrate.UseVisualStyleBackColor = true;
            // 
            // chk_serial_no
            // 
            this.chk_serial_no.AutoSize = true;
            this.chk_serial_no.Location = new System.Drawing.Point(170, 181);
            this.chk_serial_no.Name = "chk_serial_no";
            this.chk_serial_no.Size = new System.Drawing.Size(99, 25);
            this.chk_serial_no.TabIndex = 6;
            this.chk_serial_no.Text = "Serial No";
            this.chk_serial_no.UseVisualStyleBackColor = true;
            // 
            // chk_temp
            // 
            this.chk_temp.AutoSize = true;
            this.chk_temp.Location = new System.Drawing.Point(170, 155);
            this.chk_temp.Name = "chk_temp";
            this.chk_temp.Size = new System.Drawing.Size(117, 25);
            this.chk_temp.TabIndex = 5;
            this.chk_temp.Text = "Temprature";
            this.chk_temp.UseVisualStyleBackColor = true;
            // 
            // chk_rev_volume
            // 
            this.chk_rev_volume.AutoSize = true;
            this.chk_rev_volume.Location = new System.Drawing.Point(24, 207);
            this.chk_rev_volume.Name = "chk_rev_volume";
            this.chk_rev_volume.Size = new System.Drawing.Size(120, 25);
            this.chk_rev_volume.TabIndex = 5;
            this.chk_rev_volume.Text = "Rev Volume";
            this.chk_rev_volume.UseVisualStyleBackColor = true;
            // 
            // chk_vol
            // 
            this.chk_vol.AutoSize = true;
            this.chk_vol.Checked = true;
            this.chk_vol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_vol.Location = new System.Drawing.Point(24, 181);
            this.chk_vol.Name = "chk_vol";
            this.chk_vol.Size = new System.Drawing.Size(88, 25);
            this.chk_vol.TabIndex = 5;
            this.chk_vol.Text = "Volume";
            this.chk_vol.UseVisualStyleBackColor = true;
            // 
            // chk_dt
            // 
            this.chk_dt.AutoSize = true;
            this.chk_dt.Checked = true;
            this.chk_dt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_dt.Location = new System.Drawing.Point(24, 155);
            this.chk_dt.Name = "chk_dt";
            this.chk_dt.Size = new System.Drawing.Size(112, 25);
            this.chk_dt.TabIndex = 4;
            this.chk_dt.Text = "Time point";
            this.chk_dt.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 21);
            this.label17.TabIndex = 3;
            this.label17.Text = "Data records:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "Error Code:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 633);
            this.Controls.Add(this.tlb_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Modbus Water Meter Simulator";
            this.tlb_main.ResumeLayout(false);
            this.tlb_main.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlb_sp.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_flowrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlb_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtr_main;
        private System.Windows.Forms.TableLayoutPanel tlb_sp;
        private System.Windows.Forms.ComboBox cbx_spx;
        private System.Windows.Forms.Button btn_find_sp;
        private System.Windows.Forms.Button btn_sp_con;
        private System.Windows.Forms.Button btn_sp_discon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_flowrate;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Button btn_stop_wm;
        private System.Windows.Forms.Button btn_start_wm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_update_wm_settings;
        private System.Windows.Forms.NumericUpDown nud_temp;
        private System.Windows.Forms.NumericUpDown nud_flowrate;
        private System.Windows.Forms.NumericUpDown nud_volume;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbx_binary_err_code;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.CheckBox chk_err_code;
        private System.Windows.Forms.CheckBox chk_ontime;
        private System.Windows.Forms.CheckBox chk_flowrate;
        private System.Windows.Forms.CheckBox chk_serial_no;
        private System.Windows.Forms.CheckBox chk_temp;
        private System.Windows.Forms.CheckBox chk_rev_volume;
        private System.Windows.Forms.CheckBox chk_vol;
        private System.Windows.Forms.CheckBox chk_dt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}
