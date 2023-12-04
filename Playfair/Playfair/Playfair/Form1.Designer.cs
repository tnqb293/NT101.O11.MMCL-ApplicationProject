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
            txtInputKey = new TextBox();
            btnGenerateKey = new Button();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            label1 = new Label();
            txtKey = new Label();
            label3 = new Label();
            label4 = new Label();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtKeyMatrix
            // 
            txtKeyMatrix.Location = new Point(29, 48);
            txtKeyMatrix.Name = "txtKeyMatrix";
            txtKeyMatrix.Size = new Size(304, 257);
            txtKeyMatrix.TabIndex = 0;
            txtKeyMatrix.Text = "";
            // 
            // txtInputKey
            // 
            txtInputKey.Location = new Point(379, 48);
            txtInputKey.Name = "txtInputKey";
            txtInputKey.Size = new Size(232, 27);
            txtInputKey.TabIndex = 1;
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerateKey.Location = new Point(380, 144);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(232, 29);
            btnGenerateKey.TabIndex = 2;
            btnGenerateKey.Text = "Random Key";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEncrypt.Location = new Point(463, 347);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(128, 27);
            btnEncrypt.TabIndex = 5;
            btnEncrypt.Text = "Encrpyt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecrypt.Location = new Point(463, 411);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(128, 27);
            btnDecrypt.TabIndex = 6;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 8;
            label1.Text = "Key Matrix";
            // 
            // txtKey
            // 
            txtKey.AutoSize = true;
            txtKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtKey.Location = new Point(379, 18);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(39, 20);
            txtKey.TabIndex = 9;
            txtKey.Text = "Key:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 324);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 10;
            label3.Text = "Input:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 388);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 11;
            label4.Text = "Output:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(29, 347);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(368, 27);
            txtInput.TabIndex = 12;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(29, 411);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(368, 27);
            txtOutput.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(379, 98);
            button1.Name = "button1";
            button1.Size = new Size(233, 29);
            button1.TabIndex = 14;
            button1.Text = "Generate Key";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 462);
            Controls.Add(button1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtKey);
            Controls.Add(label1);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnGenerateKey);
            Controls.Add(txtInputKey);
            Controls.Add(txtKeyMatrix);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtKeyMatrix;
        private TextBox txtInputKey;
        private Button btnGenerateKey;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label label1;
        private Label txtKey;
        private Label label3;
        private Label label4;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button button1;
    }
}