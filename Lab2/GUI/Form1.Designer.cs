namespace GUI
{
    partial class MainForm
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
            this.rtbRegister = new System.Windows.Forms.RichTextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnEcrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnKey = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbRegister
            // 
            this.rtbRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbRegister.Location = new System.Drawing.Point(86, 170);
            this.rtbRegister.Name = "rtbRegister";
            this.rtbRegister.Size = new System.Drawing.Size(335, 56);
            this.rtbRegister.TabIndex = 0;
            this.rtbRegister.Text = "";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(86, 136);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(102, 20);
            this.lblRegister.TabIndex = 1;
            this.lblRegister.Text = "Register state:";
            // 
            // btnEcrypt
            // 
            this.btnEcrypt.Location = new System.Drawing.Point(227, 251);
            this.btnEcrypt.Name = "btnEcrypt";
            this.btnEcrypt.Size = new System.Drawing.Size(94, 29);
            this.btnEcrypt.TabIndex = 2;
            this.btnEcrypt.Text = "Encrypt";
            this.btnEcrypt.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(327, 251);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 29);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(86, 251);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(94, 29);
            this.btnKey.TabIndex = 4;
            this.btnKey.Text = "Generate key";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(125, 366);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 20);
            this.lblTest.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEcrypt);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.rtbRegister);
            this.Name = "MainForm";
            this.Text = "can this guy stop tipping me?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbRegister;
        private Label lblRegister;
        private Button btnEcrypt;
        private Button btnDecrypt;
        private Button btnKey;
        private Label lblTest;
    }
}