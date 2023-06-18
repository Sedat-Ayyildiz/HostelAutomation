namespace AyCicegiPansiyonUygulaması
{
    partial class FrmGazeteler
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnHurriyet = new System.Windows.Forms.Button();
            this.BtnMilliyet = new System.Windows.Forms.Button();
            this.BtnSozcu = new System.Windows.Forms.Button();
            this.BtnHaberturk = new System.Windows.Forms.Button();
            this.BtnFanatik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-1, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1001, 457);
            this.webBrowser1.TabIndex = 0;
            // 
            // BtnHurriyet
            // 
            this.BtnHurriyet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnHurriyet.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHurriyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHurriyet.Location = new System.Drawing.Point(2, 5);
            this.BtnHurriyet.Name = "BtnHurriyet";
            this.BtnHurriyet.Size = new System.Drawing.Size(182, 41);
            this.BtnHurriyet.TabIndex = 1;
            this.BtnHurriyet.Text = "Hürriyet";
            this.BtnHurriyet.UseVisualStyleBackColor = false;
            this.BtnHurriyet.Click += new System.EventHandler(this.BtnHurriyet_Click);
            // 
            // BtnMilliyet
            // 
            this.BtnMilliyet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnMilliyet.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMilliyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMilliyet.Location = new System.Drawing.Point(204, 5);
            this.BtnMilliyet.Name = "BtnMilliyet";
            this.BtnMilliyet.Size = new System.Drawing.Size(182, 41);
            this.BtnMilliyet.TabIndex = 2;
            this.BtnMilliyet.Text = "Milliyet";
            this.BtnMilliyet.UseVisualStyleBackColor = false;
            this.BtnMilliyet.Click += new System.EventHandler(this.BtnMilliyet_Click);
            // 
            // BtnSozcu
            // 
            this.BtnSozcu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnSozcu.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSozcu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSozcu.Location = new System.Drawing.Point(409, 5);
            this.BtnSozcu.Name = "BtnSozcu";
            this.BtnSozcu.Size = new System.Drawing.Size(182, 41);
            this.BtnSozcu.TabIndex = 3;
            this.BtnSozcu.Text = "Sözcü";
            this.BtnSozcu.UseVisualStyleBackColor = false;
            this.BtnSozcu.Click += new System.EventHandler(this.BtnSozcu_Click);
            // 
            // BtnHaberturk
            // 
            this.BtnHaberturk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnHaberturk.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHaberturk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHaberturk.Location = new System.Drawing.Point(611, 5);
            this.BtnHaberturk.Name = "BtnHaberturk";
            this.BtnHaberturk.Size = new System.Drawing.Size(182, 41);
            this.BtnHaberturk.TabIndex = 4;
            this.BtnHaberturk.Text = "HaberTürk";
            this.BtnHaberturk.UseVisualStyleBackColor = false;
            this.BtnHaberturk.Click += new System.EventHandler(this.BtnHaberturk_Click);
            // 
            // BtnFanatik
            // 
            this.BtnFanatik.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnFanatik.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFanatik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFanatik.Location = new System.Drawing.Point(814, 5);
            this.BtnFanatik.Name = "BtnFanatik";
            this.BtnFanatik.Size = new System.Drawing.Size(182, 41);
            this.BtnFanatik.TabIndex = 5;
            this.BtnFanatik.Text = "Fanatik";
            this.BtnFanatik.UseVisualStyleBackColor = false;
            this.BtnFanatik.Click += new System.EventHandler(this.BtnFanatik_Click);
            // 
            // FrmGazeteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Controls.Add(this.BtnFanatik);
            this.Controls.Add(this.BtnHaberturk);
            this.Controls.Add(this.BtnSozcu);
            this.Controls.Add(this.BtnMilliyet);
            this.Controls.Add(this.BtnHurriyet);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGazeteler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAZETELER & BÜLTEN PANELİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnHurriyet;
        private System.Windows.Forms.Button BtnMilliyet;
        private System.Windows.Forms.Button BtnSozcu;
        private System.Windows.Forms.Button BtnHaberturk;
        private System.Windows.Forms.Button BtnFanatik;
    }
}