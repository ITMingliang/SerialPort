namespace _03.Modbus写寄存器
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_Connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.comStartRister_w = new System.Windows.Forms.ComboBox();
            this.bt_Write = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comLen = new System.Windows.Forms.ComboBox();
            this.comStartRister_r = new System.Windows.Forms.ComboBox();
            this.bt_Read = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_Distinct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Test = new System.Windows.Forms.Button();
            this.tbRester10 = new System.Windows.Forms.TextBox();
            this.tbRester9 = new System.Windows.Forms.TextBox();
            this.tbRester8 = new System.Windows.Forms.TextBox();
            this.tbRester2 = new System.Windows.Forms.TextBox();
            this.tbRester3 = new System.Windows.Forms.TextBox();
            this.tbRester4 = new System.Windows.Forms.TextBox();
            this.tbRester5 = new System.Windows.Forms.TextBox();
            this.tbRester7 = new System.Windows.Forms.TextBox();
            this.tbRester6 = new System.Windows.Forms.TextBox();
            this.tbRester1 = new System.Windows.Forms.TextBox();
            this.rcbRes = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_Connect
            // 
            this.bt_Connect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Connect.Location = new System.Drawing.Point(16, 36);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(94, 36);
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.Text = "连接串口";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.bt_Distinct);
            this.groupBox1.Controls.Add(this.bt_Connect);
            this.groupBox1.Location = new System.Drawing.Point(26, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 477);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mudbus操作";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbData);
            this.groupBox3.Controls.Add(this.comStartRister_w);
            this.groupBox3.Controls.Add(this.bt_Write);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(25, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 147);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读取";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(110, 79);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(121, 21);
            this.tbData.TabIndex = 9;
            this.tbData.Text = "10";
            // 
            // comStartRister_w
            // 
            this.comStartRister_w.FormattingEnabled = true;
            this.comStartRister_w.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comStartRister_w.Location = new System.Drawing.Point(110, 24);
            this.comStartRister_w.Name = "comStartRister_w";
            this.comStartRister_w.Size = new System.Drawing.Size(121, 20);
            this.comStartRister_w.TabIndex = 8;
            this.comStartRister_w.Text = "0";
            // 
            // bt_Write
            // 
            this.bt_Write.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Write.Location = new System.Drawing.Point(258, 53);
            this.bt_Write.Name = "bt_Write";
            this.bt_Write.Size = new System.Drawing.Size(94, 36);
            this.bt_Write.TabIndex = 3;
            this.bt_Write.Text = "写入";
            this.bt_Write.UseVisualStyleBackColor = true;
            this.bt_Write.Click += new System.EventHandler(this.bt_Write_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(16, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "数据内容：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(16, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "寄存器地址：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comLen);
            this.groupBox4.Controls.Add(this.comStartRister_r);
            this.groupBox4.Controls.Add(this.bt_Read);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(25, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 147);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "读取";
            // 
            // comLen
            // 
            this.comLen.FormattingEnabled = true;
            this.comLen.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comLen.Location = new System.Drawing.Point(110, 83);
            this.comLen.Name = "comLen";
            this.comLen.Size = new System.Drawing.Size(121, 20);
            this.comLen.TabIndex = 9;
            this.comLen.Text = "1";
            // 
            // comStartRister_r
            // 
            this.comStartRister_r.FormattingEnabled = true;
            this.comStartRister_r.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comStartRister_r.Location = new System.Drawing.Point(110, 24);
            this.comStartRister_r.Name = "comStartRister_r";
            this.comStartRister_r.Size = new System.Drawing.Size(121, 20);
            this.comStartRister_r.TabIndex = 8;
            this.comStartRister_r.Text = "0";
            // 
            // bt_Read
            // 
            this.bt_Read.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Read.Location = new System.Drawing.Point(258, 50);
            this.bt_Read.Name = "bt_Read";
            this.bt_Read.Size = new System.Drawing.Size(94, 36);
            this.bt_Read.TabIndex = 2;
            this.bt_Read.Text = "读取";
            this.bt_Read.UseVisualStyleBackColor = true;
            this.bt_Read.Click += new System.EventHandler(this.bt_Read_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(16, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "数据长度：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "起始地址：";
            // 
            // bt_Distinct
            // 
            this.bt_Distinct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Distinct.Location = new System.Drawing.Point(156, 36);
            this.bt_Distinct.Name = "bt_Distinct";
            this.bt_Distinct.Size = new System.Drawing.Size(94, 36);
            this.bt_Distinct.TabIndex = 1;
            this.bt_Distinct.Text = "断开串口";
            this.bt_Distinct.UseVisualStyleBackColor = true;
            this.bt_Distinct.Click += new System.EventHandler(this.bt_Distinct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "寄存器1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "寄存器5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "寄存器6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "寄存器4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(26, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "寄存器3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(26, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "寄存器2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "寄存器7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(26, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "寄存器8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(26, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "寄存器9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(26, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "寄存器10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rcbRes);
            this.groupBox2.Controls.Add(this.bt_Test);
            this.groupBox2.Controls.Add(this.tbRester10);
            this.groupBox2.Controls.Add(this.tbRester9);
            this.groupBox2.Controls.Add(this.tbRester8);
            this.groupBox2.Controls.Add(this.tbRester2);
            this.groupBox2.Controls.Add(this.tbRester3);
            this.groupBox2.Controls.Add(this.tbRester4);
            this.groupBox2.Controls.Add(this.tbRester5);
            this.groupBox2.Controls.Add(this.tbRester7);
            this.groupBox2.Controls.Add(this.tbRester6);
            this.groupBox2.Controls.Add(this.tbRester1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(493, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 541);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "寄存器交互";
            // 
            // bt_Test
            // 
            this.bt_Test.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Test.Location = new System.Drawing.Point(347, 26);
            this.bt_Test.Name = "bt_Test";
            this.bt_Test.Size = new System.Drawing.Size(94, 36);
            this.bt_Test.TabIndex = 11;
            this.bt_Test.Text = "测试";
            this.bt_Test.UseVisualStyleBackColor = true;
            this.bt_Test.Click += new System.EventHandler(this.bt_Test_Click);
            // 
            // tbRester10
            // 
            this.tbRester10.Location = new System.Drawing.Point(130, 500);
            this.tbRester10.Name = "tbRester10";
            this.tbRester10.Size = new System.Drawing.Size(164, 21);
            this.tbRester10.TabIndex = 22;
            this.tbRester10.TextChanged += new System.EventHandler(this.tbRester10_TextChanged);
            // 
            // tbRester9
            // 
            this.tbRester9.Location = new System.Drawing.Point(130, 449);
            this.tbRester9.Name = "tbRester9";
            this.tbRester9.Size = new System.Drawing.Size(164, 21);
            this.tbRester9.TabIndex = 21;
            this.tbRester9.TextChanged += new System.EventHandler(this.tbRester9_TextChanged);
            // 
            // tbRester8
            // 
            this.tbRester8.Location = new System.Drawing.Point(130, 393);
            this.tbRester8.Name = "tbRester8";
            this.tbRester8.Size = new System.Drawing.Size(164, 21);
            this.tbRester8.TabIndex = 20;
            this.tbRester8.TextChanged += new System.EventHandler(this.tbRester8_TextChanged);
            // 
            // tbRester2
            // 
            this.tbRester2.Location = new System.Drawing.Point(130, 84);
            this.tbRester2.Name = "tbRester2";
            this.tbRester2.Size = new System.Drawing.Size(164, 21);
            this.tbRester2.TabIndex = 19;
            this.tbRester2.TextChanged += new System.EventHandler(this.tbRester2_TextChanged);
            // 
            // tbRester3
            // 
            this.tbRester3.Location = new System.Drawing.Point(130, 131);
            this.tbRester3.Name = "tbRester3";
            this.tbRester3.Size = new System.Drawing.Size(164, 21);
            this.tbRester3.TabIndex = 18;
            this.tbRester3.TextChanged += new System.EventHandler(this.tbRester3_TextChanged);
            // 
            // tbRester4
            // 
            this.tbRester4.Location = new System.Drawing.Point(130, 186);
            this.tbRester4.Name = "tbRester4";
            this.tbRester4.Size = new System.Drawing.Size(164, 21);
            this.tbRester4.TabIndex = 17;
            this.tbRester4.TextChanged += new System.EventHandler(this.tbRester4_TextChanged);
            // 
            // tbRester5
            // 
            this.tbRester5.Location = new System.Drawing.Point(130, 237);
            this.tbRester5.Name = "tbRester5";
            this.tbRester5.Size = new System.Drawing.Size(164, 21);
            this.tbRester5.TabIndex = 16;
            this.tbRester5.TextChanged += new System.EventHandler(this.tbRester5_TextChanged);
            // 
            // tbRester7
            // 
            this.tbRester7.Location = new System.Drawing.Point(130, 341);
            this.tbRester7.Name = "tbRester7";
            this.tbRester7.Size = new System.Drawing.Size(164, 21);
            this.tbRester7.TabIndex = 15;
            this.tbRester7.TextChanged += new System.EventHandler(this.tbRester7_TextChanged);
            // 
            // tbRester6
            // 
            this.tbRester6.Location = new System.Drawing.Point(130, 288);
            this.tbRester6.Name = "tbRester6";
            this.tbRester6.Size = new System.Drawing.Size(164, 21);
            this.tbRester6.TabIndex = 14;
            this.tbRester6.TextChanged += new System.EventHandler(this.tbRester6_TextChanged);
            // 
            // tbRester1
            // 
            this.tbRester1.Location = new System.Drawing.Point(130, 36);
            this.tbRester1.Name = "tbRester1";
            this.tbRester1.Size = new System.Drawing.Size(164, 21);
            this.tbRester1.TabIndex = 13;
            this.tbRester1.TextChanged += new System.EventHandler(this.tbRester1_TextChanged);
            // 
            // rcbRes
            // 
            this.rcbRes.Location = new System.Drawing.Point(321, 127);
            this.rcbRes.Name = "rcbRes";
            this.rcbRes.Size = new System.Drawing.Size(633, 390);
            this.rcbRes.TabIndex = 23;
            this.rcbRes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Distinct;
        private System.Windows.Forms.Button bt_Write;
        private System.Windows.Forms.Button bt_Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbRester1;
        private System.Windows.Forms.TextBox tbRester2;
        private System.Windows.Forms.TextBox tbRester3;
        private System.Windows.Forms.TextBox tbRester4;
        private System.Windows.Forms.TextBox tbRester5;
        private System.Windows.Forms.TextBox tbRester7;
        private System.Windows.Forms.TextBox tbRester6;
        private System.Windows.Forms.TextBox tbRester10;
        private System.Windows.Forms.TextBox tbRester9;
        private System.Windows.Forms.TextBox tbRester8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comLen;
        private System.Windows.Forms.ComboBox comStartRister_r;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comStartRister_w;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button bt_Test;
        private System.Windows.Forms.RichTextBox rcbRes;
    }
}

