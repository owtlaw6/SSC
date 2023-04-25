namespace labS3velciov
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComputeMACandHASH = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMACascii = new System.Windows.Forms.TextBox();
            this.textBoxMAChex = new System.Windows.Forms.TextBox();
            this.buttonVerifyMAC = new System.Windows.Forms.Button();
            this.textBoxHASH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // buttonComputeMACandHASH
            // 
            this.buttonComputeMACandHASH.Location = new System.Drawing.Point(72, 160);
            this.buttonComputeMACandHASH.Name = "buttonComputeMACandHASH";
            this.buttonComputeMACandHASH.Size = new System.Drawing.Size(152, 23);
            this.buttonComputeMACandHASH.TabIndex = 1;
            this.buttonComputeMACandHASH.Text = "Compute MAC and HASH";
            this.buttonComputeMACandHASH.UseVisualStyleBackColor = true;
            this.buttonComputeMACandHASH.Click += new System.EventHandler(this.buttonComputeMACandHASH_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(352, 74);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(267, 20);
            this.textBoxKey.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SHA1",
            "MD5",
            "RIPEMD",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.comboBox1.Location = new System.Drawing.Point(72, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plain Text";
            // 
            // textBoxPlainText
            // 
            this.textBoxPlainText.Location = new System.Drawing.Point(352, 162);
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(267, 20);
            this.textBoxPlainText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ASCII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ASCII";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MAC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ASCII";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "HEX";
            // 
            // textBoxMACascii
            // 
            this.textBoxMACascii.Location = new System.Drawing.Point(352, 246);
            this.textBoxMACascii.Name = "textBoxMACascii";
            this.textBoxMACascii.Size = new System.Drawing.Size(267, 20);
            this.textBoxMACascii.TabIndex = 11;
            // 
            // textBoxMAChex
            // 
            this.textBoxMAChex.Location = new System.Drawing.Point(352, 282);
            this.textBoxMAChex.Name = "textBoxMAChex";
            this.textBoxMAChex.Size = new System.Drawing.Size(267, 20);
            this.textBoxMAChex.TabIndex = 12;
            // 
            // buttonVerifyMAC
            // 
            this.buttonVerifyMAC.Location = new System.Drawing.Point(72, 231);
            this.buttonVerifyMAC.Name = "buttonVerifyMAC";
            this.buttonVerifyMAC.Size = new System.Drawing.Size(152, 23);
            this.buttonVerifyMAC.TabIndex = 13;
            this.buttonVerifyMAC.Text = "Verify MAC";
            this.buttonVerifyMAC.UseVisualStyleBackColor = true;
            this.buttonVerifyMAC.Click += new System.EventHandler(this.buttonVerifyMAC_Click);
            // 
            // textBoxHASH
            // 
            this.textBoxHASH.Location = new System.Drawing.Point(352, 369);
            this.textBoxHASH.Name = "textBoxHASH";
            this.textBoxHASH.Size = new System.Drawing.Size(267, 20);
            this.textBoxHASH.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "HASH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 529);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxHASH);
            this.Controls.Add(this.buttonVerifyMAC);
            this.Controls.Add(this.textBoxMAChex);
            this.Controls.Add(this.textBoxMACascii);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlainText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonComputeMACandHASH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComputeMACandHASH;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlainText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMACascii;
        private System.Windows.Forms.TextBox textBoxMAChex;
        private System.Windows.Forms.Button buttonVerifyMAC;
        private System.Windows.Forms.TextBox textBoxHASH;
        private System.Windows.Forms.Label label8;
    }
}

