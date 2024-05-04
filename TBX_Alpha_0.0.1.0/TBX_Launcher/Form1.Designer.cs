namespace TBX_Launcher
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.devID_TextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.signIn_Button = new System.Windows.Forms.Button();
            this.logo_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // login_TextBox
            // 
            this.login_TextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_TextBox.Location = new System.Drawing.Point(14, 15);
            this.login_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login_TextBox.MaxLength = 128;
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(200, 22);
            this.login_TextBox.TabIndex = 0;
            // 
            // devID_TextBox
            // 
            this.devID_TextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.devID_TextBox.Location = new System.Drawing.Point(14, 107);
            this.devID_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.devID_TextBox.MaxLength = 256;
            this.devID_TextBox.Name = "devID_TextBox";
            this.devID_TextBox.Size = new System.Drawing.Size(200, 22);
            this.devID_TextBox.TabIndex = 3;
            this.devID_TextBox.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(14, 79);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "I\'m a developer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_TextBox.Location = new System.Drawing.Point(14, 47);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password_TextBox.MaxLength = 128;
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(200, 22);
            this.password_TextBox.TabIndex = 1;
            this.password_TextBox.UseSystemPasswordChar = true;
            // 
            // signIn_Button
            // 
            this.signIn_Button.Cursor = System.Windows.Forms.Cursors.No;
            this.signIn_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signIn_Button.Location = new System.Drawing.Point(261, 124);
            this.signIn_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signIn_Button.Name = "signIn_Button";
            this.signIn_Button.Size = new System.Drawing.Size(110, 25);
            this.signIn_Button.TabIndex = 4;
            this.signIn_Button.Text = "Sign in / Log in";
            this.signIn_Button.UseVisualStyleBackColor = true;
            this.signIn_Button.Click += new System.EventHandler(this.signIn_Button_Click);
            // 
            // logo_PictureBox
            // 
            this.logo_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo_PictureBox.Image = global::TBX_Launcher.Properties.Resources.tbx_dev_launcher;
            this.logo_PictureBox.Location = new System.Drawing.Point(261, 15);
            this.logo_PictureBox.Name = "logo_PictureBox";
            this.logo_PictureBox.Size = new System.Drawing.Size(110, 85);
            this.logo_PictureBox.TabIndex = 5;
            this.logo_PictureBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.signIn_Button;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.logo_PictureBox);
            this.Controls.Add(this.signIn_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.devID_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TBX_Launcher";

            ((System.ComponentModel.ISupportInitialize)(this.logo_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.TextBox devID_TextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button signIn_Button;
        private System.Windows.Forms.PictureBox logo_PictureBox;
    }
}

