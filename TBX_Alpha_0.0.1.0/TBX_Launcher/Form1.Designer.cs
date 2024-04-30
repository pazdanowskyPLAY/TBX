namespace TBX_Launcher
{
    partial class TBXLauncher
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBXLauncher));
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.ifdev = new System.Windows.Forms.CheckBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbox
            // 
            this.loginbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginbox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginbox.Location = new System.Drawing.Point(12, 13);
            this.loginbox.MaxLength = 64;
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(200, 20);
            this.loginbox.TabIndex = 0;
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordbox.Location = new System.Drawing.Point(12, 41);
            this.passwordbox.MaxLength = 64;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(200, 20);
            this.passwordbox.TabIndex = 1;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // ifdev
            // 
            this.ifdev.AutoSize = true;
            this.ifdev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ifdev.Location = new System.Drawing.Point(12, 67);
            this.ifdev.Name = "ifdev";
            this.ifdev.Size = new System.Drawing.Size(178, 20);
            this.ifdev.TabIndex = 2;
            this.ifdev.Text = "I\'m a certificated developer";
            this.ifdev.UseVisualStyleBackColor = true;
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idbox.Location = new System.Drawing.Point(12, 93);
            this.idbox.MaxLength = 256;
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(200, 20);
            this.idbox.TabIndex = 3;
            this.idbox.UseSystemPasswordChar = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(272, 101);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(100, 23);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Log in / Sign in";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TBXLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 136);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.ifdev);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.loginbox);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TBXLauncher";
            this.ShowIcon = false;
            this.Text = "TBX_Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.CheckBox ifdev;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

