namespace GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LbUsuario = new Label();
            LbPassword = new Label();
            TbUsuario = new TextBox();
            TbPassword = new TextBox();
            BtnRegister = new Button();
            BtnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LbUsuario
            // 
            LbUsuario.Anchor = AnchorStyles.None;
            LbUsuario.AutoSize = true;
            LbUsuario.BackColor = Color.Transparent;
            LbUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            LbUsuario.ForeColor = Color.White;
            LbUsuario.Location = new Point(148, 209);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(81, 25);
            LbUsuario.TabIndex = 0;
            LbUsuario.Text = "Usuario";
            // 
            // LbPassword
            // 
            LbPassword.Anchor = AnchorStyles.None;
            LbPassword.AutoSize = true;
            LbPassword.BackColor = Color.Transparent;
            LbPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            LbPassword.ForeColor = Color.White;
            LbPassword.Location = new Point(128, 264);
            LbPassword.Name = "LbPassword";
            LbPassword.Size = new Size(113, 25);
            LbPassword.TabIndex = 1;
            LbPassword.Text = "Contraseña";
            // 
            // TbUsuario
            // 
            TbUsuario.Anchor = AnchorStyles.None;
            TbUsuario.BackColor = Color.FromArgb(192, 192, 255);
            TbUsuario.BorderStyle = BorderStyle.FixedSingle;
            TbUsuario.Font = new Font("Segoe UI", 12F);
            TbUsuario.Location = new Point(256, 209);
            TbUsuario.Name = "TbUsuario";
            TbUsuario.Size = new Size(190, 29);
            TbUsuario.TabIndex = 2;
            // 
            // TbPassword
            // 
            TbPassword.Anchor = AnchorStyles.None;
            TbPassword.BackColor = Color.FromArgb(192, 192, 255);
            TbPassword.BorderStyle = BorderStyle.FixedSingle;
            TbPassword.Font = new Font("Segoe UI", 12F);
            TbPassword.Location = new Point(256, 259);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(190, 29);
            TbPassword.TabIndex = 3;
            // 
            // BtnRegister
            // 
            BtnRegister.Anchor = AnchorStyles.None;
            BtnRegister.BackColor = Color.SlateBlue;
            BtnRegister.FlatStyle = FlatStyle.Flat;
            BtnRegister.Font = new Font("Segoe UI", 12F);
            BtnRegister.ForeColor = Color.White;
            BtnRegister.Location = new Point(148, 350);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(120, 35);
            BtnRegister.TabIndex = 4;
            BtnRegister.Text = "Registrarse";
            BtnRegister.UseVisualStyleBackColor = false;
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.None;
            BtnLogin.BackColor = Color.SlateBlue;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Segoe UI", 12F);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(312, 350);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(116, 35);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Iniciar Sesión";
            BtnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(202, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 480);
            Controls.Add(pictureBox1);
            Controls.Add(BtnLogin);
            Controls.Add(BtnRegister);
            Controls.Add(TbPassword);
            Controls.Add(TbUsuario);
            Controls.Add(LbPassword);
            Controls.Add(LbUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbUsuario;
        private Label LbPassword;
        private TextBox TbUsuario;
        private TextBox TbPassword;
        private Button BtnRegister;
        private Button BtnLogin;
        private PictureBox pictureBox1;
    }
}