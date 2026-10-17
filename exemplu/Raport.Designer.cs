namespace ExempluDesign
{
    partial class Raport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raport));
            this.picLuna = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblIndemn = new System.Windows.Forms.Label();
            this.lstEtape = new System.Windows.Forms.ListBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLuna)).BeginInit();
            this.SuspendLayout();
            //
            // picLuna
            //
            this.picLuna.Image = ((System.Drawing.Image)(resources.GetObject("picLuna.Image")));
            this.picLuna.Location = new System.Drawing.Point(24, 24);
            this.picLuna.Name = "picLuna";
            this.picLuna.Size = new System.Drawing.Size(120, 120);
            this.picLuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLuna.TabIndex = 2;
            this.picLuna.TabStop = false;
            //
            // lblTitlu
            //
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.lblTitlu.Location = new System.Drawing.Point(168, 18);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(176, 25);
            this.lblTitlu.TabIndex = 3;
            this.lblTitlu.Text = "Raportul misiunii";
            //
            // lblIndemn
            //
            this.lblIndemn.AutoSize = true;
            this.lblIndemn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIndemn.ForeColor = System.Drawing.Color.Silver;
            this.lblIndemn.Location = new System.Drawing.Point(168, 48);
            this.lblIndemn.Name = "lblIndemn";
            this.lblIndemn.Size = new System.Drawing.Size(200, 15);
            this.lblIndemn.TabIndex = 4;
            this.lblIndemn.Text = "Alege etapa pana la care se face raportul";
            //
            // lstEtape
            //
            this.lstEtape.FormattingEnabled = true;
            this.lstEtape.ItemHeight = 19;
            this.lstEtape.Items.AddRange(new object[] {
            "Lansare",
            "Orbita Pamantului",
            "Traseul spre Luna",
            "Aselenizare"});
            this.lstEtape.Location = new System.Drawing.Point(168, 72);
            this.lstEtape.Name = "lstEtape";
            this.lstEtape.Size = new System.Drawing.Size(268, 80);
            this.lstEtape.TabIndex = 0;
            //
            // btnFoto
            //
            this.btnFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.btnFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.ForeColor = System.Drawing.Color.Black;
            this.btnFoto.Location = new System.Drawing.Point(168, 172);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(120, 34);
            this.btnFoto.TabIndex = 1;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            //
            // btnIesire
            //
            this.btnIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.btnIesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIesire.FlatAppearance.BorderSize = 0;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.ForeColor = System.Drawing.Color.Black;
            this.btnIesire.Location = new System.Drawing.Point(316, 172);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(120, 34);
            this.btnIesire.TabIndex = 2;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            //
            // Raport
            //
            this.AcceptButton = this.btnFoto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.CancelButton = this.btnIesire;
            this.ClientSize = new System.Drawing.Size(460, 230);
            this.Controls.Add(this.picLuna);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblIndemn);
            this.Controls.Add(this.lstEtape);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnIesire);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport";
            ((System.ComponentModel.ISupportInitialize)(this.picLuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLuna;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblIndemn;
        private System.Windows.Forms.ListBox lstEtape;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnIesire;
    }
}
