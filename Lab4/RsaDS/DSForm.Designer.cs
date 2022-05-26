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
            this.SuspendLayout();
            // 
            // tbPnum
            // 
            this.tbPnum.Location = new System.Drawing.Point(85, 84);
            this.tbPnum.Name = "tbPnum";
            this.tbPnum.Size = new System.Drawing.Size(125, 27);
            this.tbPnum.TabIndex = 0;
            // 
            // tbQnum
            // 
            this.tbQnum.Location = new System.Drawing.Point(85, 135);
            this.tbQnum.Name = "tbQnum";
            this.tbQnum.Size = new System.Drawing.Size(125, 27);
            this.tbQnum.TabIndex = 1;
            // 
            // tbDnum
            // 
            this.tbDnum.Location = new System.Drawing.Point(85, 188);
            this.tbDnum.Name = "tbDnum";
            this.tbDnum.Size = new System.Drawing.Size(125, 27);
            this.tbDnum.TabIndex = 2;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(85, 61);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(17, 20);
            this.lblP.TabIndex = 3;
            this.lblP.Text = "P";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(85, 114);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(20, 20);
            this.lblQ.TabIndex = 4;
            this.lblQ.Text = "Q";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(85, 165);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(20, 20);
            this.lblD.TabIndex = 5;
            this.lblD.Text = "D";
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.Location = new System.Drawing.Point(85, 234);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(125, 29);
            this.btnKeyGen.TabIndex = 6;
            this.btnKeyGen.Text = "Generate key";
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.btnKeyGen_Click);
            // 
            // tbRnum
            // 
            this.tbRnum.Location = new System.Drawing.Point(250, 84);
            this.tbRnum.Name = "tbRnum";
            this.tbRnum.Size = new System.Drawing.Size(125, 27);
            this.tbRnum.TabIndex = 7;
            // 
            // tbEnum
            // 
            this.tbEnum.Location = new System.Drawing.Point(250, 135);
            this.tbEnum.Name = "tbEnum";
            this.tbEnum.Size = new System.Drawing.Size(125, 27);
            this.tbEnum.TabIndex = 8;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(250, 61);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(18, 20);
            this.lblR.TabIndex = 9;
            this.lblR.Text = "R";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(250, 112);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(17, 20);
            this.lblE.TabIndex = 10;
            this.lblE.Text = "E";
            // 
            // DSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 347);
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
    }
}