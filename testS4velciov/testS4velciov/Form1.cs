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

namespace testS4velciov
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();
        SymmetricAlgorithm mySymmetricAlg;
        HashAlgorithm myHASH;

        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            Generate();
            byte[] ciphertext = Encrypt(myConverter.StringToByteArray(textBoxIn.Text),
                                mySymmetricAlg.Key, mySymmetricAlg.IV);
            byte[] hash = ComputeHASH(ciphertext);
            textBoxOut.Text = myConverter.ByteArrayToString(ciphertext) + myConverter.ByteArrayToString(hash);
            textBoxHash.Text = myConverter.ByteArrayToString(hash);
        }

        public void Generate()
        {
            mySymmetricAlg = Aes.Create();
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

        public Form1()
        {
            InitializeComponent();
        }

        public byte[] ComputeHASH(byte[] mes)
        {
            return myHASH.ComputeHash(mes);
        }
    }
}
