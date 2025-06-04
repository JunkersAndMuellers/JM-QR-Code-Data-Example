
namespace JMQRCodeDataExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPieces = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUnits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbArticleDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWeightPiece = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbArticleNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JMQRCodeDataExample.Properties.Resources.jm_tt_gif;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(856, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL :";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(64, 134);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(592, 20);
            this.tbURL.TabIndex = 3;
            this.tbURL.Text = "http://ws.jmtt.eu/GetPieceData/Getpiecedata.asmx/GetPiece?uid=3B2166ED-408D-4E17-" +
    "8421-68E9824577FC";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(662, 132);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 4;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // tbType
            // 
            this.tbType.BackColor = System.Drawing.SystemColors.Info;
            this.tbType.Location = new System.Drawing.Point(263, 171);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(199, 20);
            this.tbType.TabIndex = 6;
            this.tbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type :";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Info;
            this.tbName.Location = new System.Drawing.Point(108, 205);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(138, 20);
            this.tbName.TabIndex = 8;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name :";
            // 
            // tbWeight
            // 
            this.tbWeight.BackColor = System.Drawing.SystemColors.Info;
            this.tbWeight.Location = new System.Drawing.Point(108, 257);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.ReadOnly = true;
            this.tbWeight.Size = new System.Drawing.Size(138, 20);
            this.tbWeight.TabIndex = 10;
            this.tbWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight :";
            // 
            // tbPieces
            // 
            this.tbPieces.BackColor = System.Drawing.SystemColors.Info;
            this.tbPieces.Location = new System.Drawing.Point(108, 231);
            this.tbPieces.Name = "tbPieces";
            this.tbPieces.ReadOnly = true;
            this.tbPieces.Size = new System.Drawing.Size(138, 20);
            this.tbPieces.TabIndex = 12;
            this.tbPieces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pieces :";
            // 
            // tbUnits
            // 
            this.tbUnits.BackColor = System.Drawing.SystemColors.Info;
            this.tbUnits.Location = new System.Drawing.Point(108, 283);
            this.tbUnits.Name = "tbUnits";
            this.tbUnits.ReadOnly = true;
            this.tbUnits.Size = new System.Drawing.Size(138, 20);
            this.tbUnits.TabIndex = 14;
            this.tbUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Shipping units :";
            // 
            // tbLength
            // 
            this.tbLength.BackColor = System.Drawing.SystemColors.Info;
            this.tbLength.Location = new System.Drawing.Point(468, 279);
            this.tbLength.Name = "tbLength";
            this.tbLength.ReadOnly = true;
            this.tbLength.Size = new System.Drawing.Size(138, 20);
            this.tbLength.TabIndex = 24;
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Length :";
            // 
            // tbArticleDesc
            // 
            this.tbArticleDesc.BackColor = System.Drawing.SystemColors.Info;
            this.tbArticleDesc.Location = new System.Drawing.Point(468, 227);
            this.tbArticleDesc.Name = "tbArticleDesc";
            this.tbArticleDesc.ReadOnly = true;
            this.tbArticleDesc.Size = new System.Drawing.Size(463, 20);
            this.tbArticleDesc.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Article desc. :";
            // 
            // tbWeightPiece
            // 
            this.tbWeightPiece.BackColor = System.Drawing.SystemColors.Info;
            this.tbWeightPiece.Location = new System.Drawing.Point(468, 253);
            this.tbWeightPiece.Name = "tbWeightPiece";
            this.tbWeightPiece.ReadOnly = true;
            this.tbWeightPiece.Size = new System.Drawing.Size(138, 20);
            this.tbWeightPiece.TabIndex = 20;
            this.tbWeightPiece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Weight :";
            // 
            // tbArticleNo
            // 
            this.tbArticleNo.BackColor = System.Drawing.SystemColors.Info;
            this.tbArticleNo.Location = new System.Drawing.Point(468, 201);
            this.tbArticleNo.Name = "tbArticleNo";
            this.tbArticleNo.ReadOnly = true;
            this.tbArticleNo.Size = new System.Drawing.Size(138, 20);
            this.tbArticleNo.TabIndex = 18;
            this.tbArticleNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Article No. :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(967, 498);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbArticleDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbWeightPiece);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbArticleNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbUnits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPieces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Junkers & Muellers XML Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPieces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUnits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbArticleDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbWeightPiece;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbArticleNo;
        private System.Windows.Forms.Label label10;
    }
}

