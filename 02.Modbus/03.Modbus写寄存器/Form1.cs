using ModbusLib;
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

namespace _03.Modbus写寄存器
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

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();

            }

            //打开串口
            serialPort1.Open();
        }

        //CRC校验
        public uint CRC(byte[] s_strPuchMsg, int len)
        {
            uint crc16 = 0xFFFF;
            for (int i = 0; i < len; i++)
            {
                crc16 ^= s_strPuchMsg[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc16 & 0x01) == 1)
                    {
                        crc16 = (crc16 >> 1) ^ 0xA001;

                    }
                    else
                    {
                        crc16 = crc16 >> 1;
                    }
                }
            }
            return crc16;
        }

        static byte[] modbus_fasong = new byte[100];

        static byte[] modbus_read = new byte[100];

        //从主机向从机索要数据
        public void mudbus_read(UInt16 startRist, UInt16 len)
        {
            modbus_fasong[0] = 0x01;//地址
            modbus_fasong[1] = 0x03;//功能码

            modbus_fasong[2] = (byte)(startRist >> 8); //起始地址
            modbus_fasong[3] = (byte)startRist;

            modbus_fasong[4] = (byte)(len >> 8); //数据长度
            modbus_fasong[5] = (byte)len;

            modbus_fasong[6] = (byte)CRC(modbus_fasong, 6);//校验位,低8位
            modbus_fasong[7] = (byte)(CRC(modbus_fasong, 6) >> 8);//高8位

            serialPort1.Write(modbus_fasong, 0, 8);
        }

        //从主机向从机发送单个寄存器数据
        public void mudbus_write(UInt16 startRist,UInt16 data)
        {
            modbus_fasong[0] = 0x01;//地址
            modbus_fasong[1] = 0x06;//功能码

            modbus_fasong[2] = (byte)(startRist >> 8);//寄存器地址
            modbus_fasong[3] = (byte)startRist;

            modbus_fasong[4] = (byte)(data >> 8);//数据内容
            modbus_fasong[5] = (byte)data;

            modbus_fasong[6] = (byte)CRC(modbus_fasong, 6);//校验位,低8位
            modbus_fasong[7] = (byte)(CRC(modbus_fasong, 6) >> 8);//高8位

            serialPort1.Write(modbus_fasong, 0, 8);
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


        UInt16 fasong = 0;
        private void bt_Test_Click(object sender, EventArgs e)
        {
            //fasong = 1;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TextBox[] Tb = { tbRester1 , tbRester2, tbRester3 , tbRester4, tbRester5 , tbRester6 , tbRester7 , tbRester8 , tbRester9 , tbRester10 };
            if (serialPort1.IsOpen)
            {
                //if (fasong==1)
                //{
                //    mudbus_write(UInt16.Parse(comStartRister_w.Text.ToString()), UInt16.Parse(tbData.Text.ToString()));
                //    fasong = 0;
                //    return;
                //}

                for (UInt16 i = 0; i < 10; i++)
                {
                    if (f[i]==1)
                    {
                        mudbus_write(UInt16.Parse(i.ToString()), UInt16.Parse(Tb[i].Text.ToString()));
                        f[i] = 0;
                        return ;
                    }
                }
                mudbus_read(UInt16.Parse(comStartRister_r.Text.ToString()), UInt16.Parse(comLen.Text.ToString()));
            }
        }

        private void bt_Read_Click(object sender, EventArgs e)
        {
            UInt16  startRester = UInt16.Parse( comStartRister_r.Text.ToString());
            UInt16 len = UInt16.Parse(comLen.Text.ToString());
            mudbus_read(startRester,len);
        }

        private void bt_Write_Click(object sender, EventArgs e)
        {
            UInt16 startRester = UInt16.Parse(comStartRister_w.Text.ToString());
            UInt16 data = UInt16.Parse(tbData.Text.ToString());
            mudbus_write(startRester, data);
        }

        #region  Text_Change
        UInt16[] f =new UInt16[10];

        private void tbRester1_TextChanged(object sender, EventArgs e)
        {
            f[0] = 1;
        }

        private void tbRester2_TextChanged(object sender, EventArgs e)
        {
            f[1] = 1;
        }


        private void tbRester3_TextChanged(object sender, EventArgs e)
        {
            f[2] = 1;
        }
        private void tbRester4_TextChanged(object sender, EventArgs e)
        {
            f[3] = 1;
        }

        private void tbRester5_TextChanged(object sender, EventArgs e)
        {
            f[4] = 1;
        }

        private void tbRester6_TextChanged(object sender, EventArgs e)
        {
            f[5] = 1;
        }

        private void tbRester7_TextChanged(object sender, EventArgs e)
        {
            f[6] = 1;
        }

        private void tbRester8_TextChanged(object sender, EventArgs e)
        {
            f[7] = 1;
        }

        private void tbRester9_TextChanged(object sender, EventArgs e)
        {
            f[8] = 1;
        }

        private void tbRester10_TextChanged(object sender, EventArgs e)
        {
            f[9] = 1;
        }

        #endregion

        int qty = 0;
        private void dealData(object sender, EventArgs e)
        {
            for (int i = 0; i < num; i++)
            {
                rcbRes.Text += modbus_read[i].ToString("X2") + " ";//十六进制
            }
            //换行
            rcbRes.Text += "\r\n";
           
            qty++;

            //每20条清空
            if (qty>20)
            {
                rcbRes.Text = "";
                qty = 0;
            }
        }

        int num;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            num=serialPort1.BytesToRead;
            serialPort1.Read(modbus_read,0,num);
            this.Invoke(new EventHandler(dealData));
        }
    }
}
