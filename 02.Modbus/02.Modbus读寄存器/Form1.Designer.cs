namespace _02.Modbus读寄存器
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
            this.bt_Connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbReadValue = new System.Windows.Forms.TextBox();
            this.bt_ReadRegister = new System.Windows.Forms.Button();
            this.bt_Distinct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSlave = new System.Windows.Forms.ComboBox();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.cbAccout = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Connect.Location = new System.Drawing.Point(22, 33);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(94, 36);
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.Text = "连接串口";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAccout);
            this.groupBox1.Controls.Add(this.cbAddress);
            this.groupBox1.Controls.Add(this.cbSlave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbReadValue);
            this.groupBox1.Controls.Add(this.bt_ReadRegister);
            this.groupBox1.Controls.Add(this.bt_Distinct);
            this.groupBox1.Controls.Add(this.bt_Connect);
            this.groupBox1.Location = new System.Drawing.Point(26, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 301);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mudbus操作";
            // 
            // tbReadValue
            // 
            this.tbReadValue.Location = new System.Drawing.Point(145, 244);
            this.tbReadValue.Multiline = true;
            this.tbReadValue.Name = "tbReadValue";
            this.tbReadValue.Size = new System.Drawing.Size(211, 36);
            this.tbReadValue.TabIndex = 3;
            // 
            // bt_ReadRegister
            // 
            this.bt_ReadRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_ReadRegister.Location = new System.Drawing.Point(22, 244);
            this.bt_ReadRegister.Name = "bt_ReadRegister";
            this.bt_ReadRegister.Size = new System.Drawing.Size(94, 36);
            this.bt_ReadRegister.TabIndex = 2;
            this.bt_ReadRegister.Text = "读取寄存器";
            this.bt_ReadRegister.UseVisualStyleBackColor = true;
            this.bt_ReadRegister.Click += new System.EventHandler(this.bt_ReadRegister_Click);
            // 
            // bt_Distinct
            // 
            this.bt_Distinct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Distinct.Location = new System.Drawing.Point(145, 33);
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
            this.label1.Location = new System.Drawing.Point(28, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Slave：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(29, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account：";
            // 
            // cbSlave
            // 
            this.cbSlave.FormattingEnabled = true;
            this.cbSlave.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbSlave.Location = new System.Drawing.Point(123, 103);
            this.cbSlave.Name = "cbSlave";
            this.cbSlave.Size = new System.Drawing.Size(121, 20);
            this.cbSlave.TabIndex = 7;
            this.cbSlave.Text = "1";
            // 
            // cbAddress
            // 
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Items.AddRange(new object[] {
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
            this.cbAddress.Location = new System.Drawing.Point(123, 148);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(121, 20);
            this.cbAddress.TabIndex = 8;
            this.cbAddress.Text = "0";
            // 
            // cbAccout
            // 
            this.cbAccout.FormattingEnabled = true;
            this.cbAccout.Items.AddRange(new object[] {
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
            this.cbAccout.Location = new System.Drawing.Point(123, 196);
            this.cbAccout.Name = "cbAccout";
            this.cbAccout.Size = new System.Drawing.Size(121, 20);
            this.cbAccout.TabIndex = 9;
            this.cbAccout.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 610);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Distinct;
        private System.Windows.Forms.Button bt_ReadRegister;
        private System.Windows.Forms.TextBox tbReadValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAccout;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.ComboBox cbSlave;
    }
}

