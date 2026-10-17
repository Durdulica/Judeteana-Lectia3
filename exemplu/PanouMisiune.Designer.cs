namespace ExempluDesign
{
    partial class PanouMisiune
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanouMisiune));
            this.picSpatiu = new System.Windows.Forms.PictureBox();
            this.tblLegenda = new System.Windows.Forms.TableLayoutPanel();
            this.picAstronauti = new System.Windows.Forms.PictureBox();
            this.lblAstronauti = new System.Windows.Forms.Label();
            this.picOxigen = new System.Windows.Forms.PictureBox();
            this.lblOxigen = new System.Windows.Forms.Label();
            this.picProbe = new System.Windows.Forms.PictureBox();
            this.lblProbe = new System.Windows.Forms.Label();
            this.picIncarcatura = new System.Windows.Forms.PictureBox();
            this.lblIncarcatura = new System.Windows.Forms.Label();
            this.lblIesire = new System.Windows.Forms.Label();
            this.btnIesire = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSpatiu)).BeginInit();
            this.tblLegenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAstronauti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOxigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIncarcatura)).BeginInit();
            this.SuspendLayout();
            //
            // picSpatiu
            //
            this.picSpatiu.Image = ((System.Drawing.Image)(resources.GetObject("picSpatiu.Image")));
            this.picSpatiu.Location = new System.Drawing.Point(0, 0);
            this.picSpatiu.Name = "picSpatiu";
            this.picSpatiu.Size = new System.Drawing.Size(900, 600);
            this.picSpatiu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSpatiu.TabIndex = 2;
            this.picSpatiu.TabStop = false;
            //
            // tblLegenda
            //
            this.tblLegenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.tblLegenda.ColumnCount = 2;
            this.tblLegenda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLegenda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLegenda.Controls.Add(this.picAstronauti, 0, 0);
            this.tblLegenda.Controls.Add(this.lblAstronauti, 1, 0);
            this.tblLegenda.Controls.Add(this.picOxigen, 0, 1);
            this.tblLegenda.Controls.Add(this.lblOxigen, 1, 1);
            this.tblLegenda.Controls.Add(this.picProbe, 0, 2);
            this.tblLegenda.Controls.Add(this.lblProbe, 1, 2);
            this.tblLegenda.Controls.Add(this.picIncarcatura, 0, 3);
            this.tblLegenda.Controls.Add(this.lblIncarcatura, 1, 3);
            this.tblLegenda.Location = new System.Drawing.Point(716, 24);
            this.tblLegenda.Name = "tblLegenda";
            this.tblLegenda.Padding = new System.Windows.Forms.Padding(6);
            this.tblLegenda.RowCount = 4;
            this.tblLegenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLegenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLegenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLegenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLegenda.Size = new System.Drawing.Size(160, 152);
            this.tblLegenda.TabIndex = 1;
            //
            // picAstronauti
            //
            this.picAstronauti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAstronauti.Image = ((System.Drawing.Image)(resources.GetObject("picAstronauti.Image")));
            this.picAstronauti.Location = new System.Drawing.Point(13, 11);
            this.picAstronauti.Name = "picAstronauti";
            this.picAstronauti.Size = new System.Drawing.Size(25, 25);
            this.picAstronauti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAstronauti.TabIndex = 0;
            this.picAstronauti.TabStop = false;
            this.toolTip1.SetToolTip(this.picAstronauti, "Astronauti la bord");
            //
            // lblAstronauti
            //
            this.lblAstronauti.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAstronauti.AutoSize = true;
            this.lblAstronauti.Location = new System.Drawing.Point(49, 14);
            this.lblAstronauti.Name = "lblAstronauti";
            this.lblAstronauti.Size = new System.Drawing.Size(14, 19);
            this.lblAstronauti.TabIndex = 1;
            this.lblAstronauti.Text = "0";
            //
            // picOxigen
            //
            this.picOxigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picOxigen.Image = ((System.Drawing.Image)(resources.GetObject("picOxigen.Image")));
            this.picOxigen.Location = new System.Drawing.Point(13, 46);
            this.picOxigen.Name = "picOxigen";
            this.picOxigen.Size = new System.Drawing.Size(25, 25);
            this.picOxigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOxigen.TabIndex = 2;
            this.picOxigen.TabStop = false;
            this.toolTip1.SetToolTip(this.picOxigen, "Oxigen disponibil (kg)");
            //
            // lblOxigen
            //
            this.lblOxigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOxigen.AutoSize = true;
            this.lblOxigen.Location = new System.Drawing.Point(49, 49);
            this.lblOxigen.Name = "lblOxigen";
            this.lblOxigen.Size = new System.Drawing.Size(14, 19);
            this.lblOxigen.TabIndex = 3;
            this.lblOxigen.Text = "0";
            //
            // picProbe
            //
            this.picProbe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picProbe.Image = ((System.Drawing.Image)(resources.GetObject("picProbe.Image")));
            this.picProbe.Location = new System.Drawing.Point(13, 81);
            this.picProbe.Name = "picProbe";
            this.picProbe.Size = new System.Drawing.Size(25, 25);
            this.picProbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProbe.TabIndex = 4;
            this.picProbe.TabStop = false;
            this.toolTip1.SetToolTip(this.picProbe, "Probe culese (kg)");
            //
            // lblProbe
            //
            this.lblProbe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProbe.AutoSize = true;
            this.lblProbe.Location = new System.Drawing.Point(49, 84);
            this.lblProbe.Name = "lblProbe";
            this.lblProbe.Size = new System.Drawing.Size(14, 19);
            this.lblProbe.TabIndex = 5;
            this.lblProbe.Text = "0";
            //
            // picIncarcatura
            //
            this.picIncarcatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picIncarcatura.Image = ((System.Drawing.Image)(resources.GetObject("picIncarcatura.Image")));
            this.picIncarcatura.Location = new System.Drawing.Point(13, 116);
            this.picIncarcatura.Name = "picIncarcatura";
            this.picIncarcatura.Size = new System.Drawing.Size(25, 25);
            this.picIncarcatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIncarcatura.TabIndex = 6;
            this.picIncarcatura.TabStop = false;
            this.toolTip1.SetToolTip(this.picIncarcatura, "Incarcatura navei (kg)");
            //
            // lblIncarcatura
            //
            this.lblIncarcatura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIncarcatura.AutoSize = true;
            this.lblIncarcatura.Location = new System.Drawing.Point(49, 119);
            this.lblIncarcatura.Name = "lblIncarcatura";
            this.lblIncarcatura.Size = new System.Drawing.Size(14, 19);
            this.lblIncarcatura.TabIndex = 7;
            this.lblIncarcatura.Text = "0";
            //
            // lblIesire
            //
            this.lblIesire.AutoSize = true;
            this.lblIesire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIesire.ForeColor = System.Drawing.Color.Silver;
            this.lblIesire.Location = new System.Drawing.Point(24, 610);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Size = new System.Drawing.Size(270, 30);
            this.lblIesire.TabIndex = 3;
            this.lblIesire.Text = "Iesi din aplicatie oricand: tasta Esc sau butonul Iesire\r\nCtrl+S deschide raportul misiunii";
            //
            // btnIesire
            //
            this.btnIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.btnIesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIesire.FlatAppearance.BorderSize = 0;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.ForeColor = System.Drawing.Color.Black;
            this.btnIesire.Location = new System.Drawing.Point(756, 608);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(120, 34);
            this.btnIesire.TabIndex = 0;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            //
            // PanouMisiune
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.tblLegenda);
            this.Controls.Add(this.picSpatiu);
            this.Controls.Add(this.lblIesire);
            this.Controls.Add(this.btnIesire);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PanouMisiune";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Misiune";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PanouMisiune_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanouMisiune_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picSpatiu)).EndInit();
            this.tblLegenda.ResumeLayout(false);
            this.tblLegenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAstronauti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOxigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIncarcatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpatiu;
        private System.Windows.Forms.TableLayoutPanel tblLegenda;
        private System.Windows.Forms.PictureBox picAstronauti;
        private System.Windows.Forms.Label lblAstronauti;
        private System.Windows.Forms.PictureBox picOxigen;
        private System.Windows.Forms.Label lblOxigen;
        private System.Windows.Forms.PictureBox picProbe;
        private System.Windows.Forms.Label lblProbe;
        private System.Windows.Forms.PictureBox picIncarcatura;
        private System.Windows.Forms.Label lblIncarcatura;
        private System.Windows.Forms.Label lblIesire;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
