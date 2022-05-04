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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.cbSize = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPrime1
            // 
            this.lblPrime1.AutoSize = true;
            this.lblPrime1.Location = new System.Drawing.Point(86, 64);
            this.lblPrime1.Name = "lblPrime1";
            this.lblPrime1.Size = new System.Drawing.Size(17, 20);
            this.lblPrime1.TabIndex = 0;
            this.lblPrime1.Text = "P";
            // 
            // lblPrime2
            // 
            this.lblPrime2.AutoSize = true;
            this.lblPrime2.Location = new System.Drawing.Point(86, 150);
            this.lblPrime2.Name = "lblPrime2";
            this.lblPrime2.Size = new System.Drawing.Size(20, 20);
            this.lblPrime2.TabIndex = 1;
            this.lblPrime2.Text = "Q";
            // 
            // lblRan
            // 
            this.lblRan.AutoSize = true;
            this.lblRan.Location = new System.Drawing.Point(86, 237);
            this.lblRan.Name = "lblRan";
            this.lblRan.Size = new System.Drawing.Size(18, 20);
            this.lblRan.TabIndex = 2;
            this.lblRan.Text = "B";
            // 
            // tbPrime1
            // 
            this.tbPrime1.Location = new System.Drawing.Point(86, 98);
            this.tbPrime1.Name = "tbPrime1";
            this.tbPrime1.Size = new System.Drawing.Size(125, 27);
            this.tbPrime1.TabIndex = 3;
            this.tbPrime1.Text = "3";
            this.tbPrime1.TextChanged += new System.EventHandler(this.tbPrime1_TextChanged);
            this.tbPrime1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrime1_KeyPress);
            // 
            // tbPrime2
            // 
            this.tbPrime2.Location = new System.Drawing.Point(86, 184);
            this.tbPrime2.Name = "tbPrime2";
            this.tbPrime2.Size = new System.Drawing.Size(125, 27);
            this.tbPrime2.TabIndex = 4;
            this.tbPrime2.Text = "523";
            this.tbPrime2.TextChanged += new System.EventHandler(this.tbPrime2_TextChanged);
            this.tbPrime2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrime2_KeyPress);
            // 
            // tbRan
            // 
            this.tbRan.Location = new System.Drawing.Point(86, 273);
            this.tbRan.Name = "tbRan";
            this.tbRan.Size = new System.Drawing.Size(125, 27);
            this.tbRan.TabIndex = 5;
            this.tbRan.Text = "1";
            this.tbRan.TextChanged += new System.EventHandler(this.tbRan_TextChanged);
            this.tbRan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRan_KeyPress);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(253, 272);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(118, 29);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(398, 272);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(118, 29);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(253, 98);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(263, 159);
            this.rtbOutput.TabIndex = 8;
            this.rtbOutput.Text = "";
            // 
            // cbSize
            // 
            this.cbSize.AutoSize = true;
            this.cbSize.Location = new System.Drawing.Point(253, 317);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(92, 24);
            this.cbSize.TabIndex = 9;
            this.cbSize.Text = "print info";
            this.cbSize.UseVisualStyleBackColor = true;
            this.cbSize.CheckedChanged += new System.EventHandler(this.cbSize_CheckedChanged);
            // 
            // RabinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 373);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbRan);
            this.Controls.Add(this.tbPrime2);
            this.Controls.Add(this.tbPrime1);
            this.Controls.Add(this.lblRan);
            this.Controls.Add(this.lblPrime2);
            this.Controls.Add(this.lblPrime1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private RichTextBox rtbOutput;
        private CheckBox cbSize;
    }
}