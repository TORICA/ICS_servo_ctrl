using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;  //SerialPortを使う
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS_servo_ctrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //利用可能なシリアルポート名の配列を取得する
            string[] PortList = SerialPort.GetPortNames();

            portNameCB.Items.Clear();

            portNameCB.Items.AddRange(PortList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //すでにポートが開いている場合にはポートを閉じる
            if(serialPort1.IsOpen) serialPort1.Close();

            //接続先をコンボボックスで選択されているポートに設定する
            if (portNameCB.SelectedIndex == -1)
            {
                MessageBox.Show("ポートが選択されていません");
                return;
            }
            serialPort1.PortName = portNameCB.SelectedItem.ToString();


            /*
            通信速度    115200bps
            ビット長    8bit
            ストップ    1bit
            フロー制御  なし
            パリティ    偶数
            */
            serialPort1.BaudRate = 115200;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Handshake = Handshake.None;
            serialPort1.Parity = Parity.Even;


            //シリアルポートを開く。エラーならメッセージを表示
            try
            {
                serialPort1.Open();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void posActValTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void posTRB_ValueChanged(object sender, EventArgs e)
        {
            updatePosSetValTXB();
            updatePos();
        }

        private void weakCKB_CheckedChanged(object sender, EventArgs e)
        {
            updatePosSetValTXB();
        }

        private void updatePosSetValTXB()
        {
            String posSetVal;
            if (weakCKB.Checked)
            {
                posSetVal = "0(脱力)";
            }
            else
            {
                posSetVal = posTRB.Value.ToString();
            }
            posSetValTXB.Text = posSetVal;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //ポートを開いていない場合は何もしない
            if (!serialPort1.IsOpen) return;

            try
            {
                int data = serialPort1.ReadByte();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatePos()
        {
            char posSetVal;
            if (weakCKB.Checked)
            {
                posSetVal = (char)0;
            }
            else
            {
                posSetVal = (char)posTRB.Value;
            }

            byte CMD=129;   //0b10000001
            byte[] packed= { 0,0,0};
            packed[0] = CMD;
            packed[1] = (byte)(posSetVal >> 8);
            packed[2] = (byte)posSetVal;
            serialPort1.Write(packed, 0, 3);
        }
    }
}
