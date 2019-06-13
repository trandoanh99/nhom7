namespace Caro
{
    partial class CoCaro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoCaro));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btDanhLai = new System.Windows.Forms.Button();
            this.ptbMark = new System.Windows.Forms.PictureBox();
            this.prsTimeDown = new System.Windows.Forms.ProgressBar();
            this.txtTennguoichoi = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btVanmoi = new System.Windows.Forms.Button();
            this.timerTimeDown = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.AccessibleName = "";
            this.pnlChessBoard.Location = new System.Drawing.Point(11, 5);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(653, 520);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(672, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 230);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 96);
            this.label2.TabIndex = 8;
            this.label2.Text = "C\r\nA\r\nR\r\nO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "5 in a line to win";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "ptrcaro";
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Caro.Properties.Resources.CoCaro;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btDanhLai);
            this.panel3.Controls.Add(this.ptbMark);
            this.panel3.Controls.Add(this.prsTimeDown);
            this.panel3.Controls.Add(this.txtTennguoichoi);
            this.panel3.Location = new System.Drawing.Point(672, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 258);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lưu ý: Mỗi lượt đánh bạn \r\nsẽ có 15s để suy nghĩ !!!";
            // 
            // btDanhLai
            // 
            this.btDanhLai.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDanhLai.Location = new System.Drawing.Point(6, 89);
            this.btDanhLai.Name = "btDanhLai";
            this.btDanhLai.Size = new System.Drawing.Size(79, 31);
            this.btDanhLai.TabIndex = 5;
            this.btDanhLai.Text = "Đánh lại";
            this.btDanhLai.UseVisualStyleBackColor = false;
            this.btDanhLai.Click += new System.EventHandler(this.btDanhLai_Click);
            // 
            // ptbMark
            // 
            this.ptbMark.Location = new System.Drawing.Point(176, 10);
            this.ptbMark.Name = "ptbMark";
            this.ptbMark.Size = new System.Drawing.Size(58, 58);
            this.ptbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMark.TabIndex = 2;
            this.ptbMark.TabStop = false;
            // 
            // prsTimeDown
            // 
            this.prsTimeDown.AccessibleName = "";
            this.prsTimeDown.Location = new System.Drawing.Point(7, 48);
            this.prsTimeDown.Name = "prsTimeDown";
            this.prsTimeDown.Size = new System.Drawing.Size(141, 20);
            this.prsTimeDown.TabIndex = 1;
            // 
            // txtTennguoichoi
            // 
            this.txtTennguoichoi.AccessibleName = "";
            this.txtTennguoichoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTennguoichoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennguoichoi.Location = new System.Drawing.Point(6, 10);
            this.txtTennguoichoi.Name = "txtTennguoichoi";
            this.txtTennguoichoi.ReadOnly = true;
            this.txtTennguoichoi.Size = new System.Drawing.Size(141, 26);
            this.txtTennguoichoi.TabIndex = 0;
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(834, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát game";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btVanmoi
            // 
            this.btVanmoi.ImageKey = "(none)";
            this.btVanmoi.Location = new System.Drawing.Point(672, 3);
            this.btVanmoi.Name = "btVanmoi";
            this.btVanmoi.Size = new System.Drawing.Size(75, 23);
            this.btVanmoi.TabIndex = 8;
            this.btVanmoi.Text = "Ván mới";
            this.btVanmoi.UseVisualStyleBackColor = true;
            this.btVanmoi.Click += new System.EventHandler(this.btVanmoi_Click);
            // 
            // timerTimeDown
            // 
            this.timerTimeDown.Tick += new System.EventHandler(this.timerTimeDown_Tick);
            // 
            // CoCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 533);
            this.Controls.Add(this.btVanmoi);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.MaximumSize = new System.Drawing.Size(939, 572);
            this.MinimumSize = new System.Drawing.Size(939, 572);
            this.Name = "CoCaro";
            this.Text = "Game Cờ Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoCaro_FormClosing);
            this.Load += new System.EventHandler(this.CoCaro_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ptbMark;
        private System.Windows.Forms.ProgressBar prsTimeDown;
        private System.Windows.Forms.TextBox txtTennguoichoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDanhLai;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btVanmoi;
        private System.Windows.Forms.Timer timerTimeDown;
        private System.Windows.Forms.Label label3;
    }
}

