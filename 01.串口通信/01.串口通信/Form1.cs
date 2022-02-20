using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.串口通信
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox1.Items.Clear();
            string [] port =SerialPort.GetPortNames();
            Array.Sort(port);
            comboBox1.Items.AddRange(port);
            comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;

        }

        SerialPort spl =new SerialPort();
        private void button1_Click(object sender, EventArgs e)
        {
            if (spl.IsOpen==false)
            {
                spl.PortName=comboBox1.Text;
                spl.BaudRate=Convert.ToInt32(comboBox2.Text);
                spl.DataBits=Convert.ToInt32(comboBox3.Text);

                //校验位
                if (comboBox4.Text=="None")
                    spl.Parity = Parity.None;
                if (comboBox4.Text == "Even")
                    spl.Parity = Parity.Even;
                if (comboBox4.Text == "Odd")
                    spl.Parity = Parity.Odd;
                if (comboBox4.Text == "Mark")
                    spl.Parity = Parity.Mark;
                if (comboBox4.Text == "Space")
                    spl.Parity = Parity.Space;

                //停止位
                if (comboBox5.Text == "0")
                    spl.StopBits = StopBits.None;
                if (comboBox5.Text == "1")
                    spl.StopBits = StopBits.One;
                if (comboBox5.Text == "1.5")
                    spl.StopBits = StopBits.OnePointFive;
                if (comboBox5.Text == "2")
                    spl.StopBits = StopBits.Two;


                try
                {
                    spl.Open();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return; 
                }
                button1.Text = "关闭串口";

            }
            else
            {
                try
                {
                    spl.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                button1.Text = "打开串口";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (spl.IsOpen)
            {
                string sendMessage = tbTranbmit.Text;
                spl.Write(sendMessage);
                rtbResult.Text += "\r\n" + "发送:" + sendMessage;
            }
            else
            {
                MessageBox.Show("串口未连接!");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (spl.IsOpen)
            {
                Byte[] receveData = new Byte[spl.BytesToRead];
                spl.Read(receveData, 0, receveData.Length);
                spl.DiscardInBuffer();
                string strRev = null;

                //接收数据
                if (receveData.Length > 0)
                {
                    strRev += Encoding.Default.GetString(receveData);
                    rtbResult.Text += "\r\n" + "接收:" + strRev;
                }
            }
        }
    }
}
