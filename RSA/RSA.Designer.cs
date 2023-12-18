using System.Windows.Forms;

namespace RSA
{
    partial class RSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA));
            this.rtb_plain = new System.Windows.Forms.RichTextBox();
            this.rtb_cipher = new System.Windows.Forms.RichTextBox();
            this.tb_public = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_private = new System.Windows.Forms.TextBox();
            this.btn_en = new System.Windows.Forms.Button();
            this.btn_de = new System.Windows.Forms.Button();
            this.pNum = new System.Windows.Forms.TextBox();
            this.qNum = new System.Windows.Forms.TextBox();
            this.nNum = new System.Windows.Forms.TextBox();
            this.phiNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_plain
            // 
            this.rtb_plain.Location = new System.Drawing.Point(12, 29);
            this.rtb_plain.Name = "rtb_plain";
            this.rtb_plain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtb_plain.Size = new System.Drawing.Size(400, 200);
            this.rtb_plain.TabIndex = 0;
            this.rtb_plain.Text = "HELLO";
            // 
            // rtb_cipher
            // 
            this.rtb_cipher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb_cipher.Location = new System.Drawing.Point(12, 288);
            this.rtb_cipher.Name = "rtb_cipher";
            this.rtb_cipher.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtb_cipher.Size = new System.Drawing.Size(400, 200);
            this.rtb_cipher.TabIndex = 1;
            this.rtb_cipher.Text = "";
            // 
            // tb_public
            // 
            this.tb_public.Location = new System.Drawing.Point(448, 149);
            this.tb_public.Name = "tb_public";
            this.tb_public.Size = new System.Drawing.Size(160, 22);
            this.tb_public.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Public key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Original text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciphered text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Private key";
            // 
            // tb_private
            // 
            this.tb_private.Location = new System.Drawing.Point(448, 205);
            this.tb_private.Name = "tb_private";
            this.tb_private.Size = new System.Drawing.Size(160, 22);
            this.tb_private.TabIndex = 6;
            // 
            // btn_en
            // 
            this.btn_en.Location = new System.Drawing.Point(448, 288);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(160, 40);
            this.btn_en.TabIndex = 8;
            this.btn_en.Text = "Encrypt";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // btn_de
            // 
            this.btn_de.Location = new System.Drawing.Point(448, 334);
            this.btn_de.Name = "btn_de";
            this.btn_de.Size = new System.Drawing.Size(160, 40);
            this.btn_de.TabIndex = 9;
            this.btn_de.Text = "Decrypt";
            this.btn_de.UseVisualStyleBackColor = true;
            this.btn_de.Click += new System.EventHandler(this.btn_de_Click);
            // 
            // pNum
            // 
            this.pNum.Location = new System.Drawing.Point(448, 52);
            this.pNum.Name = "pNum";
            this.pNum.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pNum.Size = new System.Drawing.Size(78, 22);
            this.pNum.TabIndex = 10;
            // 
            // qNum
            // 
            this.qNum.Location = new System.Drawing.Point(532, 52);
            this.qNum.Name = "qNum";
            this.qNum.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.qNum.Size = new System.Drawing.Size(78, 22);
            this.qNum.TabIndex = 12;
            // 
            // nNum
            // 
            this.nNum.Location = new System.Drawing.Point(616, 52);
            this.nNum.Name = "nNum";
            this.nNum.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nNum.Size = new System.Drawing.Size(78, 22);
            this.nNum.TabIndex = 14;
            // 
            // phiNum
            // 
            this.phiNum.Location = new System.Drawing.Point(700, 52);
            this.phiNum.Name = "phiNum";
            this.phiNum.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.phiNum.Size = new System.Drawing.Size(78, 22);
            this.phiNum.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "p";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "q";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "phi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(448, 80);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(330, 40);
            this.btn_reset.TabIndex = 21;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phiNum);
            this.Controls.Add(this.nNum);
            this.Controls.Add(this.qNum);
            this.Controls.Add(this.pNum);
            this.Controls.Add(this.btn_de);
            this.Controls.Add(this.btn_en);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_private);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_public);
            this.Controls.Add(this.rtb_cipher);
            this.Controls.Add(this.rtb_plain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Tool";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_reset;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox phiNum;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox nNum;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox qNum;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox pNum;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button btn_de;

        private System.Windows.Forms.Button btn_en;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_public;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox tb_private;

        private System.Windows.Forms.RichTextBox rtb_cipher;

        private System.Windows.Forms.RichTextBox rtb_plain;

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

