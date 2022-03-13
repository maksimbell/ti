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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbChoice = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.rtbKey = new System.Windows.Forms.RichTextBox();
            this.cbMethods = new System.Windows.Forms.ComboBox();
            this.openFileDialog_File = new System.Windows.Forms.OpenFileDialog();
            this.panelKey = new System.Windows.Forms.Panel();
            this.panelMethod = new System.Windows.Forms.Panel();
            this.panelKey.SuspendLayout();
            this.panelMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(22, 77);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 29);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(122, 77);
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
            this.lbChoice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbChoice.Location = new System.Drawing.Point(22, 16);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(64, 20);
            this.lbChoice.TabIndex = 0;
            this.lbChoice.Text = "Method:";
            this.lbChoice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbKey.Location = new System.Drawing.Point(26, 14);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(179, 20);
            this.lbKey.TabIndex = 4;
            this.lbKey.Text = "Encryption/decription key";
            this.lbKey.Click += new System.EventHandler(this.lbKey_Click);
            // 
            // rtbKey
            // 
            this.rtbKey.Location = new System.Drawing.Point(26, 48);
            this.rtbKey.Name = "rtbKey";
            this.rtbKey.Size = new System.Drawing.Size(207, 117);
            this.rtbKey.TabIndex = 2;
            this.rtbKey.Text = "";
            this.rtbKey.TextChanged += new System.EventHandler(this.rtbKey_TextChanged);
            // 
            // cbMethods
            // 
            this.cbMethods.DisplayMember = "(нет)";
            this.cbMethods.FormattingEnabled = true;
            this.cbMethods.Items.AddRange(new object[] {
            "Column",
            "Vigenère",
            "Playfair"});
            this.cbMethods.Location = new System.Drawing.Point(22, 43);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(194, 28);
            this.cbMethods.TabIndex = 1;
            this.cbMethods.Text = "Column";
            this.cbMethods.SelectionChangeCommitted += new System.EventHandler(this.cbMethods_SelectionChangeCommitted);
            // 
            // openFileDialog_File
            // 
            this.openFileDialog_File.FileName = "openFileDialog1";
            this.openFileDialog_File.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panelKey
            // 
            this.panelKey.BackColor = System.Drawing.Color.Transparent;
            this.panelKey.Controls.Add(this.rtbKey);
            this.panelKey.Controls.Add(this.lbKey);
            this.panelKey.Location = new System.Drawing.Point(66, 171);
            this.panelKey.Name = "panelKey";
            this.panelKey.Size = new System.Drawing.Size(258, 186);
            this.panelKey.TabIndex = 5;
            // 
            // panelMethod
            // 
            this.panelMethod.BackColor = System.Drawing.Color.Transparent;
            this.panelMethod.Controls.Add(this.cbMethods);
            this.panelMethod.Controls.Add(this.btnEncrypt);
            this.panelMethod.Controls.Add(this.btnDecrypt);
            this.panelMethod.Controls.Add(this.lbChoice);
            this.panelMethod.Location = new System.Drawing.Point(66, 40);
            this.panelMethod.Name = "panelMethod";
            this.panelMethod.Size = new System.Drawing.Size(258, 125);
            this.panelMethod.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 428);
            this.Controls.Add(this.panelMethod);
            this.Controls.Add(this.panelKey);
            this.MaximumSize = new System.Drawing.Size(640, 475);
            this.MinimumSize = new System.Drawing.Size(640, 475);
            this.Name = "Form1";
            this.Text = "Chil bro, chill and flex bro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelKey.ResumeLayout(false);
            this.panelKey.PerformLayout();
            this.panelMethod.ResumeLayout(false);
            this.panelMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label lbChoice;
        private Label lbKey;
        private RichTextBox rtbKey;
        private ComboBox cbMethods;
        private OpenFileDialog openFileDialog_File;
        private Panel panelKey;
        private Panel panelMethod;
    }
}