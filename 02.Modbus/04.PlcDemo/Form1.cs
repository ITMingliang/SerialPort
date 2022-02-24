using S7.Net;
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
using thinger.cn.DataConvertHelper;

namespace _04.PlcDemo
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




        private void bt_send_Click(object sender, EventArgs e)
        {
            
        }


        #region   连接与断开
        private Plc plc = new Plc(CpuType.S71200, "127.0.0.1", 0, 0);
        private void bt_Distinct_Click(object sender, EventArgs e)
        {

            try
            {
                plc.Open();
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
              plc.Close();
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
            //MD100 MW104
            object val = plc.Read(S7.Net.DataType.Memory, 0, 100, VarType.Real, 2);
            tbReadValue.Text = ((float[])val)[0].ToString()+ "  " + ((float[])val)[1].ToString();

            byte[] data = plc.ReadBytes(S7.Net.DataType.Memory, 0, 100, 7);

            //MD100
            float md100_103_ = BitConverter.ToSingle(new byte[] { data[3], data[2], data[1], data[0] }, 0);
            short mw104_105 = BitConverter.ToInt16(new byte[] { data[5], data[4] }, 0);

            bool m1006 = BitLib.GetBitFromByte(data[6], 0);

        }

        private void bt_Write_Click(object sender, EventArgs e)
        {
            plc.Write("MW104", Convert.ToInt16(tbWriteValue));
        }
    }
}
