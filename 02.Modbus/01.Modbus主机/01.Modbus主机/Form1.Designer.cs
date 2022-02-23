namespace _01.Modbus主机
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
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Distinct = new System.Windows.Forms.Button();
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
            this.bt_Connect.Text = "连接串口";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // bt_send
            // 
            this.bt_send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_send.Location = new System.Drawing.Point(282, 49);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(103, 35);
            this.bt_send.TabIndex = 1;
            this.bt_send.Text = "发  送";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_send);
            this.groupBox1.Controls.Add(this.bt_Distinct);
            this.groupBox1.Controls.Add(this.bt_Connect);
            this.groupBox1.Location = new System.Drawing.Point(26, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 400);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mudbus操作";
            // 
            // bt_Distinct
            // 
            this.bt_Distinct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Distinct.Location = new System.Drawing.Point(157, 48);
            this.bt_Distinct.Name = "bt_Distinct";
            this.bt_Distinct.Size = new System.Drawing.Size(94, 36);
            this.bt_Distinct.TabIndex = 1;
            this.bt_Distinct.Text = "断开串口";
            this.bt_Distinct.UseVisualStyleBackColor = true;
            this.bt_Distinct.Click += new System.EventHandler(this.bt_Distinct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 595);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Distinct;
    }
}

