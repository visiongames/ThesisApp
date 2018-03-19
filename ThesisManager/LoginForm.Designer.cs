namespace ThesisManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.CheckLogin = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.debugLabelValue = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btThesisAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckLogin
            // 
            this.CheckLogin.BackColor = System.Drawing.Color.Transparent;
            this.CheckLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckLogin.BackgroundImage")));
            this.CheckLogin.FlatAppearance.BorderSize = 0;
            this.CheckLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckLogin.Font = new System.Drawing.Font("Open Sans Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.CheckLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckLogin.Location = new System.Drawing.Point(89, 278);
            this.CheckLogin.Name = "CheckLogin";
            this.CheckLogin.Size = new System.Drawing.Size(327, 56);
            this.CheckLogin.TabIndex = 0;
            this.CheckLogin.Text = "Login";
            this.CheckLogin.UseVisualStyleBackColor = false;
            this.CheckLogin.Click += new System.EventHandler(this.CheckLogin_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.ForeColor = System.Drawing.Color.Coral;
            this.debugLabel.Location = new System.Drawing.Point(41, 447);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(42, 13);
            this.debugLabel.TabIndex = 1;
            this.debugLabel.Text = "Debug:";
            // 
            // debugLabelValue
            // 
            this.debugLabelValue.AutoSize = true;
            this.debugLabelValue.ForeColor = System.Drawing.Color.Red;
            this.debugLabelValue.Location = new System.Drawing.Point(118, 447);
            this.debugLabelValue.MinimumSize = new System.Drawing.Size(150, 0);
            this.debugLabelValue.Name = "debugLabelValue";
            this.debugLabelValue.Size = new System.Drawing.Size(150, 13);
            this.debugLabelValue.TabIndex = 2;
            this.debugLabelValue.Text = "label1";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Azure;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUserName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtUserName.Location = new System.Drawing.Point(89, 139);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(327, 54);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "nazwa użytkownika...";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Azure;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtPassword.Location = new System.Drawing.Point(89, 209);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(327, 54);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "hasło...";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // btThesisAdd
            // 
            this.btThesisAdd.BackColor = System.Drawing.Color.Transparent;
            this.btThesisAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThesisAdd.BackgroundImage")));
            this.btThesisAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThesisAdd.FlatAppearance.BorderSize = 0;
            this.btThesisAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btThesisAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThesisAdd.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btThesisAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThesisAdd.Location = new System.Drawing.Point(665, 139);
            this.btThesisAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btThesisAdd.Name = "btThesisAdd";
            this.btThesisAdd.Size = new System.Drawing.Size(327, 56);
            this.btThesisAdd.TabIndex = 5;
            this.btThesisAdd.Text = "Dodawanie Pracy";
            this.btThesisAdd.UseVisualStyleBackColor = false;
            this.btThesisAdd.Click += new System.EventHandler(this.btThesisAdd_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 645);
            this.Controls.Add(this.btThesisAdd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.debugLabelValue);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.CheckLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ThesisView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckLogin;
        private System.Windows.Forms.Label debugLabel;
        public System.Windows.Forms.Label debugLabelValue;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btThesisAdd;
    }
}

