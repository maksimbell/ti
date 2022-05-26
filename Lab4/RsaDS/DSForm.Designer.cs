namespace RsaDS
{
    partial class DSForm
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
            this.tbPnum = new System.Windows.Forms.TextBox();
            this.tbQnum = new System.Windows.Forms.TextBox();
            this.tbDnum = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.tbRnum = new System.Windows.Forms.TextBox();
            this.tbEnum = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPnum
            // 
            this.tbPnum.Location = new System.Drawing.Point(85, 63);
            this.tbPnum.Name = "tbPnum";
            this.tbPnum.Size = new System.Drawing.Size(125, 27);
            this.tbPnum.TabIndex = 0;
            // 
            // tbQnum
            // 
            this.tbQnum.Location = new System.Drawing.Point(85, 114);
            this.tbQnum.Name = "tbQnum";
            this.tbQnum.Size = new System.Drawing.Size(125, 27);
            this.tbQnum.TabIndex = 1;
            // 
            // tbDnum
            // 
            this.tbDnum.Location = new System.Drawing.Point(85, 167);
            this.tbDnum.Name = "tbDnum";
            this.tbDnum.Size = new System.Drawing.Size(125, 27);
            this.tbDnum.TabIndex = 2;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(85, 40);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(17, 20);
            this.lblP.TabIndex = 3;
            this.lblP.Text = "P";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(85, 93);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(20, 20);
            this.lblQ.TabIndex = 4;
            this.lblQ.Text = "Q";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(85, 144);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(20, 20);
            this.lblD.TabIndex = 5;
            this.lblD.Text = "D";
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.Location = new System.Drawing.Point(85, 263);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(125, 29);
            this.btnKeyGen.TabIndex = 6;
            this.btnKeyGen.Text = "Generate key";
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.btnKeyGen_Click);
            // 
            // tbRnum
            // 
            this.tbRnum.Enabled = false;
            this.tbRnum.Location = new System.Drawing.Point(250, 63);
            this.tbRnum.Name = "tbRnum";
            this.tbRnum.Size = new System.Drawing.Size(125, 27);
            this.tbRnum.TabIndex = 7;
            // 
            // tbEnum
            // 
            this.tbEnum.Enabled = false;
            this.tbEnum.Location = new System.Drawing.Point(250, 114);
            this.tbEnum.Name = "tbEnum";
            this.tbEnum.Size = new System.Drawing.Size(125, 27);
            this.tbEnum.TabIndex = 8;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(250, 40);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(18, 20);
            this.lblR.TabIndex = 9;
            this.lblR.Text = "R";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(250, 91);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(17, 20);
            this.lblE.TabIndex = 10;
            this.lblE.Text = "E";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(250, 263);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(125, 29);
            this.btnFile.TabIndex = 11;
            this.btnFile.Text = "Select file";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(412, 63);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(192, 78);
            this.rtbText.TabIndex = 12;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(412, 167);
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(192, 27);
            this.tbHash.TabIndex = 13;
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(412, 217);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.Size = new System.Drawing.Size(192, 27);
            this.tbSignature.TabIndex = 14;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(412, 40);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(36, 20);
            this.lblText.TabIndex = 15;
            this.lblText.Text = "Text";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(412, 144);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(42, 20);
            this.lblHash.TabIndex = 16;
            this.lblHash.Text = "Hash";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(412, 197);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(72, 20);
            this.lblSignature.TabIndex = 17;
            this.lblSignature.Text = "Signature";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(412, 263);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(125, 29);
            this.btnCheck.TabIndex = 18;
            this.btnCheck.Text = "Check signature";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // DSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 347);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.tbEnum);
            this.Controls.Add(this.tbRnum);
            this.Controls.Add(this.btnKeyGen);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.tbDnum);
            this.Controls.Add(this.tbQnum);
            this.Controls.Add(this.tbPnum);
            this.Name = "DSForm";
            this.Text = "wait whaa/";
            this.Load += new System.EventHandler(this.DSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbPnum;
        private TextBox tbQnum;
        private TextBox tbDnum;
        private Label lblP;
        private Label lblQ;
        private Label lblD;
        private Button btnKeyGen;
        private TextBox tbRnum;
        private TextBox tbEnum;
        private Label lblR;
        private Label lblE;
        private Button btnFile;
        private RichTextBox rtbText;
        private TextBox tbHash;
        private TextBox tbSignature;
        private Label lblText;
        private Label lblHash;
        private Label lblSignature;
        private Button btnCheck;
    }
}