namespace GUI
{
    partial class RabinForm
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
            this.lblPrime1 = new System.Windows.Forms.Label();
            this.lblPrime2 = new System.Windows.Forms.Label();
            this.lblRan = new System.Windows.Forms.Label();
            this.tbPrime1 = new System.Windows.Forms.TextBox();
            this.tbPrime2 = new System.Windows.Forms.TextBox();
            this.tbRan = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrime1
            // 
            this.lblPrime1.AutoSize = true;
            this.lblPrime1.Location = new System.Drawing.Point(86, 64);
            this.lblPrime1.Name = "lblPrime1";
            this.lblPrime1.Size = new System.Drawing.Size(123, 20);
            this.lblPrime1.TabIndex = 0;
            this.lblPrime1.Text = "Prime number #1";
            // 
            // lblPrime2
            // 
            this.lblPrime2.AutoSize = true;
            this.lblPrime2.Location = new System.Drawing.Point(86, 150);
            this.lblPrime2.Name = "lblPrime2";
            this.lblPrime2.Size = new System.Drawing.Size(123, 20);
            this.lblPrime2.TabIndex = 1;
            this.lblPrime2.Text = "Prime number #2";
            // 
            // lblRan
            // 
            this.lblRan.AutoSize = true;
            this.lblRan.Location = new System.Drawing.Point(86, 237);
            this.lblRan.Name = "lblRan";
            this.lblRan.Size = new System.Drawing.Size(120, 20);
            this.lblRan.TabIndex = 2;
            this.lblRan.Text = "Random number";
            // 
            // tbPrime1
            // 
            this.tbPrime1.Location = new System.Drawing.Point(86, 98);
            this.tbPrime1.Name = "tbPrime1";
            this.tbPrime1.Size = new System.Drawing.Size(125, 27);
            this.tbPrime1.TabIndex = 3;
            this.tbPrime1.Text = "11";
            // 
            // tbPrime2
            // 
            this.tbPrime2.Location = new System.Drawing.Point(86, 184);
            this.tbPrime2.Name = "tbPrime2";
            this.tbPrime2.Size = new System.Drawing.Size(125, 27);
            this.tbPrime2.TabIndex = 4;
            this.tbPrime2.Text = "17";
            // 
            // tbRan
            // 
            this.tbRan.Location = new System.Drawing.Point(86, 273);
            this.tbRan.Name = "tbRan";
            this.tbRan.Size = new System.Drawing.Size(125, 27);
            this.tbRan.TabIndex = 5;
            this.tbRan.Text = "111";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(270, 271);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 29);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(397, 271);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 29);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // RabinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 373);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbRan);
            this.Controls.Add(this.tbPrime2);
            this.Controls.Add(this.tbPrime1);
            this.Controls.Add(this.lblRan);
            this.Controls.Add(this.lblPrime2);
            this.Controls.Add(this.lblPrime1);
            this.Name = "RabinForm";
            this.Text = "ring ring...";
            this.Load += new System.EventHandler(this.RabinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPrime1;
        private Label lblPrime2;
        private Label lblRan;
        private TextBox tbPrime1;
        private TextBox tbPrime2;
        private TextBox tbRan;
        private Button btnEncrypt;
        private Button btnDecrypt;
    }
}