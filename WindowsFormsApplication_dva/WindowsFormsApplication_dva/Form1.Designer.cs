namespace WindowsFormsApplication_dva
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlainHEX = new System.Windows.Forms.TextBox();
            this.textBoxPlainASCII = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCipherASCII = new System.Windows.Forms.TextBox();
            this.textBoxCipherHEX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonGetEncryptTime = new System.Windows.Forms.Button();
            this.buttonGetDecryptTime = new System.Windows.Forms.Button();
            this.labelTimeMessEncryption = new System.Windows.Forms.Label();
            this.labelTimeMessDecryption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DES",
            "3DES",
            "Rijndael"});
            this.comboBox1.Location = new System.Drawing.Point(43, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(347, 46);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(275, 20);
            this.textBoxKey.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IV";
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(347, 117);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(275, 20);
            this.textBoxIV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plain Text";
            // 
            // textBoxPlainHEX
            // 
            this.textBoxPlainHEX.Location = new System.Drawing.Point(347, 234);
            this.textBoxPlainHEX.Name = "textBoxPlainHEX";
            this.textBoxPlainHEX.Size = new System.Drawing.Size(275, 20);
            this.textBoxPlainHEX.TabIndex = 6;
            // 
            // textBoxPlainASCII
            // 
            this.textBoxPlainASCII.Location = new System.Drawing.Point(347, 204);
            this.textBoxPlainASCII.Name = "textBoxPlainASCII";
            this.textBoxPlainASCII.Size = new System.Drawing.Size(275, 20);
            this.textBoxPlainASCII.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cipher Text";
            // 
            // textBoxCipherASCII
            // 
            this.textBoxCipherASCII.Location = new System.Drawing.Point(347, 302);
            this.textBoxCipherASCII.Name = "textBoxCipherASCII";
            this.textBoxCipherASCII.Size = new System.Drawing.Size(275, 20);
            this.textBoxCipherASCII.TabIndex = 9;
            // 
            // textBoxCipherHEX
            // 
            this.textBoxCipherHEX.Location = new System.Drawing.Point(347, 328);
            this.textBoxCipherHEX.Name = "textBoxCipherHEX";
            this.textBoxCipherHEX.Size = new System.Drawing.Size(275, 20);
            this.textBoxCipherHEX.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ASCII";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "HEX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ASCII";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "HEX";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(43, 108);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(135, 23);
            this.buttonGenerate.TabIndex = 15;
            this.buttonGenerate.Text = "Generate Key and IV";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(43, 178);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(135, 23);
            this.buttonEncrypt.TabIndex = 16;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(43, 271);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(135, 23);
            this.buttonDecrypt.TabIndex = 17;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonGetEncryptTime
            // 
            this.buttonGetEncryptTime.Location = new System.Drawing.Point(43, 424);
            this.buttonGetEncryptTime.Name = "buttonGetEncryptTime";
            this.buttonGetEncryptTime.Size = new System.Drawing.Size(135, 23);
            this.buttonGetEncryptTime.TabIndex = 18;
            this.buttonGetEncryptTime.Text = "Get Encrypt Time";
            this.buttonGetEncryptTime.UseVisualStyleBackColor = true;
            this.buttonGetEncryptTime.Click += new System.EventHandler(this.buttonGetEncryptTime_Click);
            // 
            // buttonGetDecryptTime
            // 
            this.buttonGetDecryptTime.Location = new System.Drawing.Point(43, 486);
            this.buttonGetDecryptTime.Name = "buttonGetDecryptTime";
            this.buttonGetDecryptTime.Size = new System.Drawing.Size(135, 23);
            this.buttonGetDecryptTime.TabIndex = 19;
            this.buttonGetDecryptTime.Text = "Get Decrypt Time";
            this.buttonGetDecryptTime.UseVisualStyleBackColor = true;
            this.buttonGetDecryptTime.Click += new System.EventHandler(this.buttonGetDecryptTime_Click);
            // 
            // labelTimeMessEncryption
            // 
            this.labelTimeMessEncryption.AutoSize = true;
            this.labelTimeMessEncryption.Location = new System.Drawing.Point(300, 424);
            this.labelTimeMessEncryption.Name = "labelTimeMessEncryption";
            this.labelTimeMessEncryption.Size = new System.Drawing.Size(147, 13);
            this.labelTimeMessEncryption.TabIndex = 20;
            this.labelTimeMessEncryption.Text = "Time/message at encryption: ";
            // 
            // labelTimeMessDecryption
            // 
            this.labelTimeMessDecryption.AutoSize = true;
            this.labelTimeMessDecryption.Location = new System.Drawing.Point(300, 486);
            this.labelTimeMessDecryption.Name = "labelTimeMessDecryption";
            this.labelTimeMessDecryption.Size = new System.Drawing.Size(147, 13);
            this.labelTimeMessDecryption.TabIndex = 21;
            this.labelTimeMessDecryption.Text = "Time/message at decryption: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 624);
            this.Controls.Add(this.labelTimeMessDecryption);
            this.Controls.Add(this.labelTimeMessEncryption);
            this.Controls.Add(this.buttonGetDecryptTime);
            this.Controls.Add(this.buttonGetEncryptTime);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCipherHEX);
            this.Controls.Add(this.textBoxCipherASCII);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPlainASCII);
            this.Controls.Add(this.textBoxPlainHEX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlainHEX;
        private System.Windows.Forms.TextBox textBoxPlainASCII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCipherASCII;
        private System.Windows.Forms.TextBox textBoxCipherHEX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonGetEncryptTime;
        private System.Windows.Forms.Button buttonGetDecryptTime;
        private System.Windows.Forms.Label labelTimeMessEncryption;
        private System.Windows.Forms.Label labelTimeMessDecryption;
    }
}

