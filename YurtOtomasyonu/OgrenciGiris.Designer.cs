namespace YurtOtomasyonu
{
    partial class OgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciGiris));
            this.Ogrbtngrs = new DevExpress.XtraEditors.SimpleButton();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtTcnmr = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTcnmr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Ogrbtngrs
            // 
            this.Ogrbtngrs.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold);
            this.Ogrbtngrs.Appearance.Options.UseFont = true;
            this.Ogrbtngrs.Location = new System.Drawing.Point(197, 149);
            this.Ogrbtngrs.Name = "Ogrbtngrs";
            this.Ogrbtngrs.Size = new System.Drawing.Size(209, 45);
            this.Ogrbtngrs.TabIndex = 10;
            this.Ogrbtngrs.Text = "Giriş";
            this.Ogrbtngrs.Click += new System.EventHandler(this.Ogrbtngrs_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(197, 97);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.Appearance.Options.UseForeColor = true;
            this.txtParola.Properties.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(209, 34);
            this.txtParola.TabIndex = 9;
            // 
            // txtTcnmr
            // 
            this.txtTcnmr.Location = new System.Drawing.Point(197, 57);
            this.txtTcnmr.Name = "txtTcnmr";
            this.txtTcnmr.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcnmr.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTcnmr.Properties.Appearance.Options.UseFont = true;
            this.txtTcnmr.Properties.Appearance.Options.UseForeColor = true;
            this.txtTcnmr.Size = new System.Drawing.Size(209, 34);
            this.txtTcnmr.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "T.C Numarası :";
            // 
            // OgrenciGiris
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 241);
            this.Controls.Add(this.Ogrbtngrs);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtTcnmr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OgrenciGiris";
            this.Text = "Öğrenci Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTcnmr.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Ogrbtngrs;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.TextEdit txtTcnmr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}