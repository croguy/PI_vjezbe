namespace Stoperica
{
    partial class FrmStoperica
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lstVremena = new System.Windows.Forms.ListBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(48, 336);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 64);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(200, 336);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(146, 64);
            this.btnLap.TabIndex = 0;
            this.btnLap.Text = "LAP";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(352, 336);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(146, 64);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(504, 336);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(146, 64);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "RESUME";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(656, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 64);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijeme.Location = new System.Drawing.Point(47, 143);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(299, 59);
            this.lblVrijeme.TabIndex = 1;
            this.lblVrijeme.Text = "0:00:00.000";
            // 
            // lstVremena
            // 
            this.lstVremena.FormattingEnabled = true;
            this.lstVremena.ItemHeight = 20;
            this.lstVremena.Location = new System.Drawing.Point(544, 36);
            this.lstVremena.Name = "lstVremena";
            this.lstVremena.Size = new System.Drawing.Size(258, 244);
            this.lstVremena.TabIndex = 2;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 10;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // FrmStoperica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.lstVremena);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmStoperica";
            this.Text = "Štoperica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.ListBox lstVremena;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}

