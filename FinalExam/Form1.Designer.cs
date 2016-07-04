namespace FinalExam
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbGameChoose = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.btnGameChoose = new System.Windows.Forms.Button();
            this.GameChoose = new System.Windows.Forms.Label();
            this.gpbLive = new System.Windows.Forms.GroupBox();
            this.btnLive = new System.Windows.Forms.Button();
            this.cmbLive = new System.Windows.Forms.ComboBox();
            this.lblLive = new System.Windows.Forms.Label();
            this.gpbGameChoose.SuspendLayout();
            this.gpbLive.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGameChoose
            // 
            this.gpbGameChoose.Controls.Add(this.btnUpdate);
            this.gpbGameChoose.Controls.Add(this.cmbUpdate);
            this.gpbGameChoose.Controls.Add(this.btnGameChoose);
            this.gpbGameChoose.Controls.Add(this.GameChoose);
            this.gpbGameChoose.Location = new System.Drawing.Point(21, 24);
            this.gpbGameChoose.Name = "gpbGameChoose";
            this.gpbGameChoose.Size = new System.Drawing.Size(441, 208);
            this.gpbGameChoose.TabIndex = 0;
            this.gpbGameChoose.TabStop = false;
            this.gpbGameChoose.Text = "參數設定";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(340, 134);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 27);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "更改參數";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(114, 136);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(196, 23);
            this.cmbUpdate.TabIndex = 3;
            // 
            // btnGameChoose
            // 
            this.btnGameChoose.Location = new System.Drawing.Point(340, 48);
            this.btnGameChoose.Name = "btnGameChoose";
            this.btnGameChoose.Size = new System.Drawing.Size(85, 28);
            this.btnGameChoose.TabIndex = 2;
            this.btnGameChoose.Text = "新增";
            this.btnGameChoose.UseVisualStyleBackColor = true;
            this.btnGameChoose.Click += new System.EventHandler(this.btnGameChoose_Click);
            // 
            // GameChoose
            // 
            this.GameChoose.AutoSize = true;
            this.GameChoose.Location = new System.Drawing.Point(19, 48);
            this.GameChoose.Name = "GameChoose";
            this.GameChoose.Size = new System.Drawing.Size(37, 15);
            this.GameChoose.TabIndex = 0;
            this.GameChoose.Text = "場次";
            // 
            // gpbLive
            // 
            this.gpbLive.Controls.Add(this.btnLive);
            this.gpbLive.Controls.Add(this.cmbLive);
            this.gpbLive.Controls.Add(this.lblLive);
            this.gpbLive.Location = new System.Drawing.Point(21, 310);
            this.gpbLive.Name = "gpbLive";
            this.gpbLive.Size = new System.Drawing.Size(441, 118);
            this.gpbLive.TabIndex = 3;
            this.gpbLive.TabStop = false;
            this.gpbLive.Text = "轉播";
            // 
            // btnLive
            // 
            this.btnLive.Location = new System.Drawing.Point(340, 44);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(85, 28);
            this.btnLive.TabIndex = 2;
            this.btnLive.Text = "開始轉播";
            this.btnLive.UseVisualStyleBackColor = true;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // cmbLive
            // 
            this.cmbLive.FormattingEnabled = true;
            this.cmbLive.Location = new System.Drawing.Point(114, 48);
            this.cmbLive.Name = "cmbLive";
            this.cmbLive.Size = new System.Drawing.Size(196, 23);
            this.cmbLive.TabIndex = 1;
            // 
            // lblLive
            // 
            this.lblLive.AutoSize = true;
            this.lblLive.Location = new System.Drawing.Point(19, 48);
            this.lblLive.Name = "lblLive";
            this.lblLive.Size = new System.Drawing.Size(37, 15);
            this.lblLive.TabIndex = 0;
            this.lblLive.Text = "場次";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 458);
            this.Controls.Add(this.gpbLive);
            this.Controls.Add(this.gpbGameChoose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbGameChoose.ResumeLayout(false);
            this.gpbGameChoose.PerformLayout();
            this.gpbLive.ResumeLayout(false);
            this.gpbLive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGameChoose;
        private System.Windows.Forms.Button btnGameChoose;
        private System.Windows.Forms.Label GameChoose;
        private System.Windows.Forms.GroupBox gpbLive;
        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.ComboBox cmbLive;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbUpdate;
    }
}

