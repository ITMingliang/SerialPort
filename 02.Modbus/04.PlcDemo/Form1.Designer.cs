namespace _04.PlcDemo
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
            this.bt_Write = new System.Windows.Forms.Button();
            this.tbWriteValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Connect.Location = new System.Drawing.Point(22, 48);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(94, 36);
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.Text = "连接";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbWriteValue);
            this.groupBox1.Controls.Add(this.bt_Write);
            this.groupBox1.Controls.Add(this.tbReadValue);
            this.groupBox1.Controls.Add(this.bt_ReadRegister);
            this.groupBox1.Controls.Add(this.bt_Distinct);
            this.groupBox1.Controls.Add(this.bt_Connect);
            this.groupBox1.Location = new System.Drawing.Point(26, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 400);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plc操作";
            // 
            // tbReadValue
            // 
            this.tbReadValue.Location = new System.Drawing.Point(163, 141);
            this.tbReadValue.Multiline = true;
            this.tbReadValue.Name = "tbReadValue";
            this.tbReadValue.Size = new System.Drawing.Size(223, 36);
            this.tbReadValue.TabIndex = 3;
            this.tbReadValue.Text = "MD100";
            // 
            // bt_ReadRegister
            // 
            this.bt_ReadRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_ReadRegister.Location = new System.Drawing.Point(22, 141);
            this.bt_ReadRegister.Name = "bt_ReadRegister";
            this.bt_ReadRegister.Size = new System.Drawing.Size(94, 36);
            this.bt_ReadRegister.TabIndex = 2;
            this.bt_ReadRegister.Text = "读取";
            this.bt_ReadRegister.UseVisualStyleBackColor = true;
            this.bt_ReadRegister.Click += new System.EventHandler(this.bt_ReadRegister_Click);
            // 
            // bt_Distinct
            // 
            this.bt_Distinct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Distinct.Location = new System.Drawing.Point(240, 48);
            this.bt_Distinct.Name = "bt_Distinct";
            this.bt_Distinct.Size = new System.Drawing.Size(94, 36);
            this.bt_Distinct.TabIndex = 1;
            this.bt_Distinct.Text = "断开";
            this.bt_Distinct.UseVisualStyleBackColor = true;
            this.bt_Distinct.Click += new System.EventHandler(this.bt_Distinct_Click);
            // 
            // bt_Write
            // 
            this.bt_Write.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Write.Location = new System.Drawing.Point(22, 243);
            this.bt_Write.Name = "bt_Write";
            this.bt_Write.Size = new System.Drawing.Size(94, 36);
            this.bt_Write.TabIndex = 4;
            this.bt_Write.Text = "写入";
            this.bt_Write.UseVisualStyleBackColor = true;
            this.bt_Write.Click += new System.EventHandler(this.bt_Write_Click);
            // 
            // tbWriteValue
            // 
            this.tbWriteValue.Location = new System.Drawing.Point(163, 243);
            this.tbWriteValue.Multiline = true;
            this.tbWriteValue.Name = "tbWriteValue";
            this.tbWriteValue.Size = new System.Drawing.Size(223, 36);
            this.tbWriteValue.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 595);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Plc";
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
        private System.Windows.Forms.Button bt_Write;
        private System.Windows.Forms.TextBox tbWriteValue;
    }
}

