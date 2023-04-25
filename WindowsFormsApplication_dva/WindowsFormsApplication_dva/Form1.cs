using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApplication_dva
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();
        SymmetricAlgorithm mySymmetricAlg;

        public void Generate(string cipher)
        {
            switch (cipher)
            {
                case "DES":
                    mySymmetricAlg = DES.Create();
                    break;
                case "3DES":
                    mySymmetricAlg = TripleDES.Create();
                    break;
                case "Rijndael":
                    mySymmetricAlg = Rijndael.Create();
                    break;
            }
            mySymmetricAlg.GenerateIV();
            mySymmetricAlg.GenerateKey();
        }
        public byte[] Encrypt(byte[] mess, byte[] key, byte[] iv)
        {
            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(mess, 0, mess.Length);
            cs.Close();
            return ms.ToArray();
        }
        public byte[] Decrypt(byte[] mess, byte[] key, byte[] iv)
        {
            byte[] plaintext = new byte[mess.Length];
            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;
            MemoryStream ms = new MemoryStream(mess);
            CryptoStream cs = new CryptoStream(ms,mySymmetricAlg.CreateDecryptor(),CryptoStreamMode.Read);
            cs.Read(plaintext, 0, mess.Length);
            cs.Close();
            return plaintext;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            byte[] ciphertext = Encrypt(myConverter.StringToByteArray(textBoxPlainASCII.Text), 
                                myConverter.HexStringToByteArray(textBoxKey.Text),myConverter.HexStringToByteArray(textBoxIV.Text));
            textBoxCipherASCII.Text = myConverter.ByteArrayToString(ciphertext);
            textBoxCipherHEX.Text = myConverter.ByteArrayToHexString(ciphertext);
            textBoxPlainHEX.Text = myConverter.ByteArrayToHexString(myConverter.StringToByteArray(textBoxPlainASCII.Text));
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            byte[] plaintext = Decrypt(myConverter.HexStringToByteArray(textBoxCipherHEX.Text), 
                               myConverter.HexStringToByteArray(textBoxKey.Text),myConverter.HexStringToByteArray(textBoxIV.Text));
            textBoxPlainASCII.Text = myConverter.ByteArrayToString(plaintext);
            textBoxPlainHEX.Text = myConverter.ByteArrayToHexString(plaintext);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Generate(comboBox1.Text);
            textBoxKey.Text = myConverter.ByteArrayToHexString(mySymmetricAlg.Key);
            textBoxIV.Text =myConverter.ByteArrayToHexString(mySymmetricAlg.IV);
        }

        private void buttonGetEncryptTime_Click(object sender, EventArgs e)
        {
            mySymmetricAlg.GenerateIV(); // generates a fresh IV
            mySymmetricAlg.GenerateKey(); // generates a fresh Key
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] mes_block = new byte[8];
            long start_time = DateTime.Now.Ticks;
            int count = 10000000;
            for (int i = 0; i < count; i++)
            {
                cs.Write(mes_block, 0, mes_block.Length);
            }
            cs.Close();
            double operation_time = (DateTime.Now.Ticks - start_time);
            operation_time = operation_time / (10*count); // 1 tick is 100 ns, i.e., 1/10 of 1 us
            labelTimeMessEncryption.Text = "Time for encryption of a message block: " + operation_time.ToString() + " us";
        }

        private void buttonGetDecryptTime_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(myConverter.HexStringToByteArray(textBoxCipherHEX.Text));
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateDecryptor(), CryptoStreamMode.Read);
            byte[] mes_block = new byte[8];
            long start_time = DateTime.Now.Ticks;
            int count = 10000000;
            for (int i = 0; i < count; i++)
            {
                cs.Read(mes_block, 0, mes_block.Length);
            }
            cs.Close();
            double operation_time = (DateTime.Now.Ticks - start_time);
            operation_time = operation_time / (10 * count); // 1 tick is 100 ns, i.e., 1/10 of 1 us
            labelTimeMessDecryption.Text = "Time for encryption of a message block: " + operation_time.ToString() + " us";
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
