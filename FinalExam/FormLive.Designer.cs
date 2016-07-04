namespace FinalExam
{
    partial class FormLive
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
            this.gpbControl = new System.Windows.Forms.GroupBox();
            this.btnOver = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gpbScore = new System.Windows.Forms.GroupBox();
            this.txtHomeRun = new System.Windows.Forms.TextBox();
            this.lblHomeRun = new System.Windows.Forms.Label();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.txtCatch = new System.Windows.Forms.TextBox();
            this.lblCatch = new System.Windows.Forms.Label();
            this.txtOutBall = new System.Windows.Forms.TextBox();
            this.lblOutBall = new System.Windows.Forms.Label();
            this.txtNoHit = new System.Windows.Forms.TextBox();
            this.lblNoHit = new System.Windows.Forms.Label();
            this.gpbLiteralLive = new System.Windows.Forms.GroupBox();
            this.txtLiteralLive = new System.Windows.Forms.TextBox();
            this.gpbControl.SuspendLayout();
            this.gpbScore.SuspendLayout();
            this.gpbLiteralLive.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbControl
            // 
            this.gpbControl.Controls.Add(this.btnOver);
            this.gpbControl.Controls.Add(this.btnPause);
            this.gpbControl.Controls.Add(this.btnStart);
            this.gpbControl.Location = new System.Drawing.Point(18, 12);
            this.gpbControl.Name = "gpbControl";
            this.gpbControl.Size = new System.Drawing.Size(406, 83);
            this.gpbControl.TabIndex = 0;
            this.gpbControl.TabStop = false;
            this.gpbControl.Text = "控制按鈕";
            // 
            // btnOver
            // 
            this.btnOver.Enabled = false;
            this.btnOver.Location = new System.Drawing.Point(295, 27);
            this.btnOver.Name = "btnOver";
            this.btnOver.Size = new System.Drawing.Size(92, 34);
            this.btnOver.TabIndex = 2;
            this.btnOver.Text = "結束轉播";
            this.btnOver.UseVisualStyleBackColor = true;
            this.btnOver.Click += new System.EventHandler(this.btnOver_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(158, 27);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(92, 34);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開始轉播";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gpbScore
            // 
            this.gpbScore.Controls.Add(this.txtHomeRun);
            this.gpbScore.Controls.Add(this.lblHomeRun);
            this.gpbScore.Controls.Add(this.txtSave);
            this.gpbScore.Controls.Add(this.lblSave);
            this.gpbScore.Controls.Add(this.txtCatch);
            this.gpbScore.Controls.Add(this.lblCatch);
            this.gpbScore.Controls.Add(this.txtOutBall);
            this.gpbScore.Controls.Add(this.lblOutBall);
            this.gpbScore.Controls.Add(this.txtNoHit);
            this.gpbScore.Controls.Add(this.lblNoHit);
            this.gpbScore.Location = new System.Drawing.Point(19, 101);
            this.gpbScore.Name = "gpbScore";
            this.gpbScore.Size = new System.Drawing.Size(405, 87);
            this.gpbScore.TabIndex = 1;
            this.gpbScore.TabStop = false;
            this.gpbScore.Text = "成績統計";
            // 
            // txtHomeRun
            // 
            this.txtHomeRun.Location = new System.Drawing.Point(336, 48);
            this.txtHomeRun.Name = "txtHomeRun";
            this.txtHomeRun.Size = new System.Drawing.Size(50, 25);
            this.txtHomeRun.TabIndex = 9;
            // 
            // lblHomeRun
            // 
            this.lblHomeRun.Location = new System.Drawing.Point(332, 30);
            this.lblHomeRun.Name = "lblHomeRun";
            this.lblHomeRun.Size = new System.Drawing.Size(71, 19);
            this.lblHomeRun.TabIndex = 8;
            this.lblHomeRun.Text = "全壘打";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(259, 48);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(50, 25);
            this.txtSave.TabIndex = 7;
            // 
            // lblSave
            // 
            this.lblSave.Location = new System.Drawing.Point(263, 30);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(71, 19);
            this.lblSave.TabIndex = 6;
            this.lblSave.Text = "安打";
            // 
            // txtCatch
            // 
            this.txtCatch.Location = new System.Drawing.Point(182, 48);
            this.txtCatch.Name = "txtCatch";
            this.txtCatch.Size = new System.Drawing.Size(50, 25);
            this.txtCatch.TabIndex = 5;
            // 
            // lblCatch
            // 
            this.lblCatch.Location = new System.Drawing.Point(186, 30);
            this.lblCatch.Name = "lblCatch";
            this.lblCatch.Size = new System.Drawing.Size(71, 19);
            this.lblCatch.TabIndex = 4;
            this.lblCatch.Text = "接殺";
            // 
            // txtOutBall
            // 
            this.txtOutBall.Location = new System.Drawing.Point(110, 48);
            this.txtOutBall.Name = "txtOutBall";
            this.txtOutBall.Size = new System.Drawing.Size(50, 25);
            this.txtOutBall.TabIndex = 3;
            // 
            // lblOutBall
            // 
            this.lblOutBall.Location = new System.Drawing.Point(114, 30);
            this.lblOutBall.Name = "lblOutBall";
            this.lblOutBall.Size = new System.Drawing.Size(71, 15);
            this.lblOutBall.TabIndex = 2;
            this.lblOutBall.Text = "界外";
            // 
            // txtNoHit
            // 
            this.txtNoHit.Location = new System.Drawing.Point(30, 48);
            this.txtNoHit.Name = "txtNoHit";
            this.txtNoHit.Size = new System.Drawing.Size(50, 25);
            this.txtNoHit.TabIndex = 1;
            // 
            // lblNoHit
            // 
            this.lblNoHit.Location = new System.Drawing.Point(26, 30);
            this.lblNoHit.Name = "lblNoHit";
            this.lblNoHit.Size = new System.Drawing.Size(71, 19);
            this.lblNoHit.TabIndex = 0;
            this.lblNoHit.Text = "揮棒落空";
            // 
            // gpbLiteralLive
            // 
            this.gpbLiteralLive.Controls.Add(this.txtLiteralLive);
            this.gpbLiteralLive.Location = new System.Drawing.Point(21, 201);
            this.gpbLiteralLive.Name = "gpbLiteralLive";
            this.gpbLiteralLive.Size = new System.Drawing.Size(402, 334);
            this.gpbLiteralLive.TabIndex = 2;
            this.gpbLiteralLive.TabStop = false;
            this.gpbLiteralLive.Text = "文字轉播";
            // 
            // txtLiteralLive
            // 
            this.txtLiteralLive.Location = new System.Drawing.Point(16, 24);
            this.txtLiteralLive.Multiline = true;
            this.txtLiteralLive.Name = "txtLiteralLive";
            this.txtLiteralLive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLiteralLive.Size = new System.Drawing.Size(372, 304);
            this.txtLiteralLive.TabIndex = 0;
            // 
            // FormLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 547);
            this.Controls.Add(this.gpbLiteralLive);
            this.Controls.Add(this.gpbScore);
            this.Controls.Add(this.gpbControl);
            this.Name = "FormLive";
            this.Text = "Live";
            this.gpbControl.ResumeLayout(false);
            this.gpbScore.ResumeLayout(false);
            this.gpbScore.PerformLayout();
            this.gpbLiteralLive.ResumeLayout(false);
            this.gpbLiteralLive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbControl;
        private System.Windows.Forms.Button btnOver;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gpbScore;
        private System.Windows.Forms.TextBox txtHomeRun;
        private System.Windows.Forms.Label lblHomeRun;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.TextBox txtCatch;
        private System.Windows.Forms.Label lblCatch;
        private System.Windows.Forms.TextBox txtOutBall;
        private System.Windows.Forms.Label lblOutBall;
        private System.Windows.Forms.TextBox txtNoHit;
        private System.Windows.Forms.Label lblNoHit;
        private System.Windows.Forms.GroupBox gpbLiteralLive;
        private System.Windows.Forms.TextBox txtLiteralLive;
    }
}