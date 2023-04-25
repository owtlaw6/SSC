using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace labS3velciov
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonComputeMACandHASH_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBox1.Text);
            byte[] mac = mh.ComputeMAC(myConverter.StringToByteArray(textBoxPlainText.Text), myConverter.StringToByteArray(textBoxKey.Text));
            byte[] hash = mh.ComputeHASH(myConverter.StringToByteArray(textBoxPlainText.Text));
            textBoxMACascii.Text = myConverter.ByteArrayToString(mac);
            textBoxMAChex.Text = myConverter.ByteArrayToHexString(mac);
            textBoxHASH.Text = myConverter.ByteArrayToString(hash);
        }

        private void buttonVerifyMAC_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBox1.Text);
            if(mh.CheckAuthenticity(myConverter.StringToByteArray(textBoxPlainText.Text), 
               myConverter.HexStringToByteArray(textBoxMAChex.Text),myConverter.StringToByteArray(textBoxKey.Text)) == true)
            {
                System.Windows.Forms.MessageBox.Show("MAC OK !!!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("MAC NOT OK !!!");
            }
        }
    }
}
