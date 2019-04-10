namespace pi_vj4
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
            this.boxUnos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gumbUnos = new System.Windows.Forms.Button();
            this.listBoxDNK = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boxUnos
            // 
            this.boxUnos.FormattingEnabled = true;
            this.boxUnos.Items.AddRange(new object[] {
            "A",
            "C",
            "T",
            "G"});
            this.boxUnos.Location = new System.Drawing.Point(372, 45);
            this.boxUnos.Name = "boxUnos";
            this.boxUnos.Size = new System.Drawing.Size(121, 21);
            this.boxUnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unos Baze (A - C - T - G)";
            // 
            // gumbUnos
            // 
            this.gumbUnos.Location = new System.Drawing.Point(372, 111);
            this.gumbUnos.Name = "gumbUnos";
            this.gumbUnos.Size = new System.Drawing.Size(121, 56);
            this.gumbUnos.TabIndex = 3;
            this.gumbUnos.Text = "Unesi bazu";
            this.gumbUnos.UseVisualStyleBackColor = true;
            this.gumbUnos.Click += new System.EventHandler(this.gumbUnos_Click);
            // 
            // listBoxDNK
            // 
            this.listBoxDNK.FormattingEnabled = true;
            this.listBoxDNK.Location = new System.Drawing.Point(13, 13);
            this.listBoxDNK.Name = "listBoxDNK";
            this.listBoxDNK.Size = new System.Drawing.Size(341, 407);
            this.listBoxDNK.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 446);
            this.Controls.Add(this.listBoxDNK);
            this.Controls.Add(this.gumbUnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox boxUnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gumbUnos;
        private System.Windows.Forms.ListBox listBoxDNK;
    }
}

