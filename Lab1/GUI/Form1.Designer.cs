namespace GUI
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbChoice = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.rtbKey = new System.Windows.Forms.RichTextBox();
            this.cbMethods = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(66, 344);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 29);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(179, 344);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 29);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lbChoice
            // 
            this.lbChoice.AutoSize = true;
            this.lbChoice.Location = new System.Drawing.Point(66, 46);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(64, 20);
            this.lbChoice.TabIndex = 0;
            this.lbChoice.Text = "Method:";
            this.lbChoice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(66, 166);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(179, 20);
            this.lbKey.TabIndex = 4;
            this.lbKey.Text = "Encryption/decription key";
            // 
            // rtbKey
            // 
            this.rtbKey.Location = new System.Drawing.Point(66, 200);
            this.rtbKey.Name = "rtbKey";
            this.rtbKey.Size = new System.Drawing.Size(207, 120);
            this.rtbKey.TabIndex = 2;
            this.rtbKey.Text = "";
            // 
            // cbMethods
            // 
            this.cbMethods.FormattingEnabled = true;
            this.cbMethods.Items.AddRange(new object[] {
            "Column",
            "Vigenère",
            "Playfair"});
            this.cbMethods.Location = new System.Drawing.Point(66, 73);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(151, 28);
            this.cbMethods.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 428);
            this.Controls.Add(this.cbMethods);
            this.Controls.Add(this.rtbKey);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.lbChoice);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.Text = "Chil bro, chill and flex bro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label lbChoice;
        private Label lbKey;
        private RichTextBox rtbKey;
        private ComboBox cbMethods;
    }
}