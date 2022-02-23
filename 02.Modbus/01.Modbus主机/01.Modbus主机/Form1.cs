using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.Modbus主机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public void OpenCOM(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            //设置一些通信参数
            serialPort1.PortName = portName;
            serialPort1.BaudRate = baudRate;
            serialPort1.Parity = parity;
            serialPort1.DataBits = dataBits;
            serialPort1.StopBits = stopBits;

            //判断是否已经打开
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();

            }

            //打开串口
            serialPort1.Open();
        }

        //CRC校验
        public uint CRC(byte[] s_strPuchMsg,int len)
        {
            uint crc16 = 0xFFFF;
            for (int i = 0; i < len; i++)
            {
                crc16 ^= s_strPuchMsg[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc16 & 0x01)==1)
                    {
                        crc16 = (crc16 >> 1) ^ 0xA001;

                    }
                    else
                    {
                        crc16=crc16 >> 1;
                    }
                }
            }
            return crc16;   
        }

        static byte[] modbus_fasong=new byte[100];


        //读取寄存器从0开始的10个值
        public void mudbus_send()
        {
            modbus_fasong[0] = 0x01;//地址
            modbus_fasong[1] = 0x03;//功能码

            modbus_fasong[2] = 0x00;//起始地址
            modbus_fasong[3] = 0x00;

            modbus_fasong[4] = 0x00;//数据长度
            modbus_fasong[5] = 0x0A;

            modbus_fasong[6] = (byte)CRC(modbus_fasong,6);//校验位,低8位
            modbus_fasong[7] = (byte)(CRC(modbus_fasong, 6)>>8);//高8位

            serialPort1.Write(modbus_fasong, 0, 8);
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            mudbus_send();
        }





        #region   连接与断开
        private void bt_Distinct_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("断开失败：" + ex.Message);
                return;
            }
            MessageBox.Show("断开成功~");
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            

            try
            {
                //打开与Slave通信的端口
                OpenCOM("COM12", 9600, Parity.None, 8, StopBits.One);
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败：" + ex.Message); 
                return;
            }

            MessageBox.Show("连接成功~");
        }

        #endregion

    }
}
