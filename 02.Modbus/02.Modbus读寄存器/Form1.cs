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

namespace _02.Modbus读寄存器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


        #region   连接与断开
        private void bt_Distinct_Click(object sender, EventArgs e)
        {

            try
            {
                modbusUilty.CloseCOM();
            }
            catch (Exception ex)
            {
                MessageBox.Show("断开失败：" + ex.Message);
                return;
            }
            MessageBox.Show("断开成功~");
        }

        private ModbusUilty modbusUilty = new ModbusUilty();
        private void bt_Connect_Click(object sender, EventArgs e)
        {

            try
            {
                modbusUilty.OpenCOM("COM12", 9600, Parity.None, 8, StopBits.One);
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败：" + ex.Message);
                return;
            }

            MessageBox.Show("连接成功~");
        }

        #endregion

        private void bt_ReadRegister_Click(object sender, EventArgs e)
        {
            
            //从机地址
            byte slaveId = (byte) int.Parse( cbSlave.Text.ToString());
            //起始地址
            ushort startAddress =(ushort) int.Parse(cbAddress.Text.ToString());
            //数据位
            ushort count =(ushort) int.Parse(cbAccout.Text.ToString());   

            //读取寄存器
            byte[] data = modbusUilty.ReadRegisters(slaveId, startAddress, count);
            if (data != null)
            {
                if (data.Length==2)
                {
                    //高位*256 + 低位
                    string res = (data[0] * 256 + data[1]).ToString();
                    tbReadValue.Text = res;
                }
                else
                {
                    //读取大于一个寄存器时候，原样按顺序读出输出
                    string str = string.Join(" ", data.Select(t => t.ToString()).ToArray());
                    Console.Write(str);
                    tbReadValue.Text = str.ToString();
                }
               
            }
            else
            {
                MessageBox.Show("读取失败!");
            }

        }
    }
}
