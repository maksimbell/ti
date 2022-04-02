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
            this.btnKey = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.openInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.openOutputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // rtbRegister
            // 
            this.rtbRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbRegister.Location = new System.Drawing.Point(77, 146);
            this.rtbRegister.Name = "rtbRegister";
            this.rtbRegister.Size = new System.Drawing.Size(335, 56);
            this.rtbRegister.TabIndex = 0;
            this.rtbRegister.Text = "";
            this.rtbRegister.TextChanged += new System.EventHandler(this.rtbRegister_TextChanged);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Location = new System.Drawing.Point(77, 112);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(102, 20);
            this.lblRegister.TabIndex = 1;
            this.lblRegister.Text = "Register state:";
            // 
            // btnEcrypt
            // 
            this.btnEcrypt.Location = new System.Drawing.Point(212, 233);
            this.btnEcrypt.Name = "btnEcrypt";
            this.btnEcrypt.Size = new System.Drawing.Size(94, 29);
            this.btnEcrypt.TabIndex = 2;
            this.btnEcrypt.Text = "Encrypt";
            this.btnEcrypt.UseVisualStyleBackColor = true;
            this.btnEcrypt.Click += new System.EventHandler(this.btnEcrypt_Click);
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(77, 233);
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
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.Location = new System.Drawing.Point(12, 320);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(13, 20);
            this.lblTest.TabIndex = 5;
            this.lblTest.Text = " ";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(440, 146);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(125, 27);
            this.tbInput.TabIndex = 6;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInput.Click += new System.EventHandler(this.textBox1_Click);
            this.tbInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openInputFileDialog
            // 
            this.openInputFileDialog.FileName = "openFileDialog2";
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.BackColor = System.Drawing.Color.Transparent;
            this.lblInputFile.Location = new System.Drawing.Point(440, 112);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(67, 20);
            this.lblInputFile.TabIndex = 7;
            this.lblInputFile.Text = "Message";
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputFile.Location = new System.Drawing.Point(440, 201);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(52, 20);
            this.lblOutputFile.TabIndex = 8;
            this.lblOutputFile.Text = "Cipher";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(440, 233);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(125, 27);
            this.tbOutput.TabIndex = 9;
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOutput.Click += new System.EventHandler(this.tbOutput_Click);
            // 
            // openOutputFileDialog
            // 
            this.openOutputFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(669, 473);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.lblOutputFile);
            this.Controls.Add(this.lblInputFile);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.btnEcrypt);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.rtbRegister);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "can this guy stop tipping me?";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbRegister;
        private Label lblRegister;
        private Button btnEcrypt;
        private Button btnKey;
        private Label lblTest;
        private TextBox tbInput;
        private OpenFileDialog openInputFileDialog;
        private Label lblInputFile;
        private Label lblOutputFile;
        private TextBox tbOutput;
        private OpenFileDialog openOutputFileDialog;
    }
}