namespace Appsence_Razi
{
    partial class formConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConnexion));
            this.panelforms = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txt_login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_connect = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.topBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.minimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.small_logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.raziLogo = new System.Windows.Forms.PictureBox();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.gunaAnimateWindow2 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelforms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.small_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raziLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelforms
            // 
            this.panelforms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelforms.BackgroundImage")));
            this.panelforms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelforms.Controls.Add(this.txt_login);
            this.panelforms.Controls.Add(this.txt_password);
            this.panelforms.Controls.Add(this.btn_connect);
            this.panelforms.Controls.Add(this.lbl_error);
            this.panelforms.Controls.Add(this.pictureBox1);
            this.panelforms.Controls.Add(this.pictureBox2);
            this.panelforms.Controls.Add(this.topBar);
            this.panelforms.Controls.Add(this.raziLogo);
            this.panelforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelforms.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.panelforms.GradientBottomRight = System.Drawing.Color.White;
            this.panelforms.GradientTopLeft = System.Drawing.Color.LightBlue;
            this.panelforms.GradientTopRight = System.Drawing.Color.White;
            this.panelforms.Location = new System.Drawing.Point(0, 0);
            this.panelforms.Name = "panelforms";
            this.panelforms.Quality = 10;
            this.panelforms.Size = new System.Drawing.Size(539, 392);
            this.panelforms.TabIndex = 12;
            // 
            // txt_login
            // 
            this.txt_login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_login.BackColor = System.Drawing.SystemColors.Control;
            this.txt_login.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_login.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_login.HintText = "LOGIN";
            this.txt_login.isPassword = false;
            this.txt_login.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_login.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_login.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_login.LineThickness = 3;
            this.txt_login.Location = new System.Drawing.Point(65, 258);
            this.txt_login.Margin = new System.Windows.Forms.Padding(6);
            this.txt_login.MaxLength = 32767;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(293, 34);
            this.txt_login.TabIndex = 58;
            this.txt_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_login_KeyPress);
            this.txt_login.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_login_KeyUp);
            // 
            // txt_password
            // 
            this.txt_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_password.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_password.HintText = "MOT DE PASSE";
            this.txt_password.isPassword = true;
            this.txt_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_password.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_password.LineThickness = 3;
            this.txt_password.Location = new System.Drawing.Point(65, 304);
            this.txt_password.Margin = new System.Windows.Forms.Padding(6);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(293, 34);
            this.txt_password.TabIndex = 64;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            this.txt_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyUp);
            // 
            // btn_connect
            // 
            this.btn_connect.ActiveImage = null;
            this.btn_connect.AllowAnimations = true;
            this.btn_connect.AllowBuffering = true;
            this.btn_connect.AllowZooming = true;
            this.btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_connect.ErrorImage")));
            this.btn_connect.FadeWhenInactive = false;
            this.btn_connect.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
            this.btn_connect.ImageActive = null;
            this.btn_connect.ImageLocation = null;
            this.btn_connect.ImageMargin = 10;
            this.btn_connect.ImageSize = new System.Drawing.Size(77, 70);
            this.btn_connect.ImageZoomSize = new System.Drawing.Size(87, 80);
            this.btn_connect.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_connect.InitialImage")));
            this.btn_connect.Location = new System.Drawing.Point(377, 258);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Rotation = 0;
            this.btn_connect.ShowActiveImage = true;
            this.btn_connect.ShowCursorChanges = true;
            this.btn_connect.ShowImageBorders = false;
            this.btn_connect.ShowSizeMarkers = false;
            this.btn_connect.Size = new System.Drawing.Size(87, 80);
            this.btn_connect.TabIndex = 65;
            this.toolTip1.SetToolTip(this.btn_connect, "se connecter");
            this.btn_connect.ToolTipText = "";
            this.btn_connect.WaitOnLoad = false;
            this.btn_connect.Zoom = 10;
            this.btn_connect.ZoomSpeed = 10;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.lbl_error.Location = new System.Drawing.Point(88, 217);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 24);
            this.lbl_error.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(274, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // topBar
            // 
            this.topBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBar.BackgroundImage")));
            this.topBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBar.Controls.Add(this.lbl_time);
            this.topBar.Controls.Add(this.minimise);
            this.topBar.Controls.Add(this.close);
            this.topBar.Controls.Add(this.small_logo);
            this.topBar.Controls.Add(this.title);
            this.topBar.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.topBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.topBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.topBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Quality = 10;
            this.topBar.Size = new System.Drawing.Size(539, 33);
            this.topBar.TabIndex = 69;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(438, 6);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 20);
            this.lbl_time.TabIndex = 4;
            // 
            // minimise
            // 
            this.minimise.BackColor = System.Drawing.Color.Transparent;
            this.minimise.Image = ((System.Drawing.Image)(resources.GetObject("minimise.Image")));
            this.minimise.ImageActive = null;
            this.minimise.Location = new System.Drawing.Point(468, 5);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(25, 22);
            this.minimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimise.TabIndex = 3;
            this.minimise.TabStop = false;
            this.minimise.Zoom = 10;
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(502, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // small_logo
            // 
            this.small_logo.BackColor = System.Drawing.Color.Transparent;
            this.small_logo.Image = ((System.Drawing.Image)(resources.GetObject("small_logo.Image")));
            this.small_logo.Location = new System.Drawing.Point(4, 0);
            this.small_logo.Name = "small_logo";
            this.small_logo.Size = new System.Drawing.Size(48, 33);
            this.small_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.small_logo.TabIndex = 1;
            this.small_logo.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(55, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(82, 20);
            this.title.TabIndex = 0;
            this.title.Text = "Appsence";
            // 
            // raziLogo
            // 
            this.raziLogo.BackColor = System.Drawing.Color.Transparent;
            this.raziLogo.Image = ((System.Drawing.Image)(resources.GetObject("raziLogo.Image")));
            this.raziLogo.Location = new System.Drawing.Point(11, 60);
            this.raziLogo.Name = "raziLogo";
            this.raziLogo.Size = new System.Drawing.Size(260, 94);
            this.raziLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raziLogo.TabIndex = 67;
            this.raziLogo.TabStop = false;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.gunaAnimateWindow1.Interval = 600;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // gunaAnimateWindow2
            // 
            this.gunaAnimateWindow2.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.gunaAnimateWindow2.Interval = 600;
            this.gunaAnimateWindow2.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // formConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(539, 392);
            this.Controls.Add(this.panelforms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formConnexion";
            this.Load += new System.EventHandler(this.formConnexion_Load);
            this.panelforms.ResumeLayout(false);
            this.panelforms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.small_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raziLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelforms;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;
        private Bunifu.UI.WinForms.BunifuImageButton btn_connect;
        private System.Windows.Forms.PictureBox raziLogo;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Bunifu.Framework.UI.BunifuGradientPanel topBar;
        private System.Windows.Forms.Label lbl_time;
        private Bunifu.Framework.UI.BunifuImageButton minimise;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.PictureBox small_logo;
        private System.Windows.Forms.Label title;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}