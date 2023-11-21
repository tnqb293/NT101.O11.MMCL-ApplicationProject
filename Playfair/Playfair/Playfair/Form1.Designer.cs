namespace Playfair
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
            txtKeyMatrix = new RichTextBox();
            textBox1 = new TextBox();
            btnGenerateKey = new Button();
            txtInput = new RichTextBox();
            txtOutput = new RichTextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnSwitch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtKeyMatrix
            // 
            txtKeyMatrix.Location = new Point(40, 48);
            txtKeyMatrix.Name = "txtKeyMatrix";
            txtKeyMatrix.Size = new Size(304, 257);
            txtKeyMatrix.TabIndex = 0;
            txtKeyMatrix.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(379, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 1;
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Location = new Point(379, 89);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(296, 29);
            btnGenerateKey.TabIndex = 2;
            btnGenerateKey.Text = "Khóa ngẫu nhiên";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(40, 371);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(233, 139);
            txtInput.TabIndex = 3;
            txtInput.Text = "";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(442, 371);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(233, 139);
            txtOutput.TabIndex = 4;
            txtOutput.Text = "";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(315, 371);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(94, 29);
            btnEncrypt.TabIndex = 5;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(315, 429);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(94, 29);
            btnDecrypt.TabIndex = 6;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnSwitch
            // 
            btnSwitch.Location = new Point(315, 481);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(94, 29);
            btnSwitch.TabIndex = 7;
            btnSwitch.Text = "<<";
            btnSwitch.UseVisualStyleBackColor = true;
            btnSwitch.Click += btnSwitch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 8;
            label1.Text = "Khóa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 18);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 9;
            label2.Text = "Nhập ma trận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 340);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 10;
            label3.Text = "Văn bản đầu vào:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 340);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 11;
            label4.Text = "Văn bản đầu ra:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 545);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSwitch);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnGenerateKey);
            Controls.Add(textBox1);
            Controls.Add(txtKeyMatrix);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtKeyMatrix;
        private TextBox textBox1;
        private Button btnGenerateKey;
        private RichTextBox txtInput;
        private RichTextBox txtOutput;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnSwitch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}