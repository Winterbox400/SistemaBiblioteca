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
            BtnIngresar = new Button();
            pictureBox1 = new PictureBox();
            TbNametag = new TextBox();
            LbNametag = new Label();
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
            LbUsuario.Location = new Point(149, 262);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(93, 25);
            LbUsuario.TabIndex = 0;
            LbUsuario.Text = "Nametag";
            // 
            // LbPassword
            // 
            LbPassword.Anchor = AnchorStyles.None;
            LbPassword.AutoSize = true;
            LbPassword.BackColor = Color.Transparent;
            LbPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            LbPassword.ForeColor = Color.White;
            LbPassword.Location = new Point(129, 319);
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
            TbUsuario.Location = new Point(257, 262);
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
            TbPassword.Location = new Point(257, 314);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(190, 29);
            TbPassword.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Anchor = AnchorStyles.None;
            BtnIngresar.BackColor = Color.SlateBlue;
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Segoe UI", 12F);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(257, 406);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(116, 35);
            BtnIngresar.TabIndex = 5;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TbNametag
            // 
            TbNametag.Anchor = AnchorStyles.None;
            TbNametag.BackColor = Color.FromArgb(192, 192, 255);
            TbNametag.BorderStyle = BorderStyle.FixedSingle;
            TbNametag.Font = new Font("Segoe UI", 12F);
            TbNametag.Location = new Point(257, 288);
            TbNametag.Name = "TbNametag";
            TbNametag.ReadOnly = true;
            TbNametag.Size = new Size(190, 29);
            TbNametag.TabIndex = 8;
            TbNametag.Visible = false;
            // 
            // LbNametag
            // 
            LbNametag.Anchor = AnchorStyles.None;
            LbNametag.AutoSize = true;
            LbNametag.BackColor = Color.Transparent;
            LbNametag.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            LbNametag.ForeColor = Color.White;
            LbNametag.Location = new Point(129, 293);
            LbNametag.Name = "LbNametag";
            LbNametag.Size = new Size(103, 25);
            LbNametag.TabIndex = 7;
            LbNametag.Text = "  Nametag";
            LbNametag.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 480);
            Controls.Add(TbNametag);
            Controls.Add(LbNametag);
            Controls.Add(pictureBox1);
            Controls.Add(BtnIngresar);
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
        private Button BtnIngresar;
        private PictureBox pictureBox1;
        private TextBox TbNametag;
        private Label LbNametag;
    }
}