namespace Decode_SMS_AND_USD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.lbxRes = new System.Windows.Forms.ListBox();
            this.rbUssd = new System.Windows.Forms.RadioButton();
            this.rbSms = new System.Windows.Forms.RadioButton();
            this.rbUnicode = new System.Windows.Forms.RadioButton();
            this.rbBigEndianUnicode = new System.Windows.Forms.RadioButton();
            this.rbUTF8 = new System.Windows.Forms.RadioButton();
            this.rbAscii = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Text";
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(75, 30);
            this.txtSMS.Multiline = true;
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(713, 87);
            this.txtSMS.TabIndex = 2;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(86, 268);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // lbxRes
            // 
            this.lbxRes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbxRes.ForeColor = System.Drawing.SystemColors.Info;
            this.lbxRes.FormattingEnabled = true;
            this.lbxRes.ItemHeight = 15;
            this.lbxRes.Location = new System.Drawing.Point(80, 333);
            this.lbxRes.Name = "lbxRes";
            this.lbxRes.Size = new System.Drawing.Size(713, 139);
            this.lbxRes.TabIndex = 4;
            // 
            // rbUssd
            // 
            this.rbUssd.AutoSize = true;
            this.rbUssd.Location = new System.Drawing.Point(178, 22);
            this.rbUssd.Name = "rbUssd";
            this.rbUssd.Size = new System.Drawing.Size(53, 19);
            this.rbUssd.TabIndex = 5;
            this.rbUssd.Text = "USSD";
            this.rbUssd.UseVisualStyleBackColor = true;
            // 
            // rbSms
            // 
            this.rbSms.AutoSize = true;
            this.rbSms.Checked = true;
            this.rbSms.Location = new System.Drawing.Point(92, 22);
            this.rbSms.Name = "rbSms";
            this.rbSms.Size = new System.Drawing.Size(48, 19);
            this.rbSms.TabIndex = 6;
            this.rbSms.TabStop = true;
            this.rbSms.Text = "SMS";
            this.rbSms.UseVisualStyleBackColor = true;
            // 
            // rbUnicode
            // 
            this.rbUnicode.AutoSize = true;
            this.rbUnicode.Checked = true;
            this.rbUnicode.Location = new System.Drawing.Point(11, 22);
            this.rbUnicode.Name = "rbUnicode";
            this.rbUnicode.Size = new System.Drawing.Size(69, 19);
            this.rbUnicode.TabIndex = 9;
            this.rbUnicode.Text = "Unicode";
            this.rbUnicode.UseVisualStyleBackColor = true;
            // 
            // rbBigEndianUnicode
            // 
            this.rbBigEndianUnicode.AutoSize = true;
            this.rbBigEndianUnicode.Location = new System.Drawing.Point(97, 22);
            this.rbBigEndianUnicode.Name = "rbBigEndianUnicode";
            this.rbBigEndianUnicode.Size = new System.Drawing.Size(122, 19);
            this.rbBigEndianUnicode.TabIndex = 8;
            this.rbBigEndianUnicode.Text = "BigEndianUnicode";
            this.rbBigEndianUnicode.UseVisualStyleBackColor = true;
            // 
            // rbUTF8
            // 
            this.rbUTF8.AutoSize = true;
            this.rbUTF8.Location = new System.Drawing.Point(238, 22);
            this.rbUTF8.Name = "rbUTF8";
            this.rbUTF8.Size = new System.Drawing.Size(56, 19);
            this.rbUTF8.TabIndex = 11;
            this.rbUTF8.Text = "UTF-8";
            this.rbUTF8.UseVisualStyleBackColor = true;
            // 
            // rbAscii
            // 
            this.rbAscii.AutoSize = true;
            this.rbAscii.Location = new System.Drawing.Point(341, 22);
            this.rbAscii.Name = "rbAscii";
            this.rbAscii.Size = new System.Drawing.Size(53, 19);
            this.rbAscii.TabIndex = 12;
            this.rbAscii.Text = "ASCII";
            this.rbAscii.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSms);
            this.groupBox1.Controls.Add(this.rbUssd);
            this.groupBox1.Location = new System.Drawing.Point(75, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 51);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBigEndianUnicode);
            this.groupBox2.Controls.Add(this.rbUnicode);
            this.groupBox2.Controls.Add(this.rbAscii);
            this.groupBox2.Controls.Add(this.rbUTF8);
            this.groupBox2.Location = new System.Drawing.Point(75, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 50);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Unicode ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxRes);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtSMS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSMS;
        private Button btnDecode;
        private ListBox lbxRes;
        private RadioButton rbUssd;
        private RadioButton rbSms;
        private RadioButton rbUnicode;
        private RadioButton rbBigEndianUnicode;
        private RadioButton rbUTF8;
        private RadioButton rbAscii;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}