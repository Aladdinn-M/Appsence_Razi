﻿namespace Appsence_Razi
{
    partial class form_list_ABS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_list_ABS));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panelforms = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_printAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_print = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txt_NBabs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_commmentaire = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_matricule = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_type_abs = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_cin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_cnss = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddw_months = new Bunifu.UI.WinForms.BunifuDropdown();
            this.list_date = new System.Windows.Forms.ListBox();
            this.Ddw_fonction = new Bunifu.UI.WinForms.BunifuDropdown();
            this.list_personnel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelforms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelforms
            // 
            this.panelforms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelforms.BackgroundImage")));
            this.panelforms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelforms.Controls.Add(this.btn_printAll);
            this.panelforms.Controls.Add(this.btn_print);
            this.panelforms.Controls.Add(this.txt_NBabs);
            this.panelforms.Controls.Add(this.label8);
            this.panelforms.Controls.Add(this.txt_commmentaire);
            this.panelforms.Controls.Add(this.label4);
            this.panelforms.Controls.Add(this.label7);
            this.panelforms.Controls.Add(this.txt_matricule);
            this.panelforms.Controls.Add(this.txt_type_abs);
            this.panelforms.Controls.Add(this.txt_cin);
            this.panelforms.Controls.Add(this.txt_cnss);
            this.panelforms.Controls.Add(this.label6);
            this.panelforms.Controls.Add(this.label5);
            this.panelforms.Controls.Add(this.label3);
            this.panelforms.Controls.Add(this.label2);
            this.panelforms.Controls.Add(this.ddw_months);
            this.panelforms.Controls.Add(this.list_date);
            this.panelforms.Controls.Add(this.Ddw_fonction);
            this.panelforms.Controls.Add(this.list_personnel);
            this.panelforms.Controls.Add(this.label1);
            this.panelforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelforms.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.panelforms.GradientBottomRight = System.Drawing.Color.White;
            this.panelforms.GradientTopLeft = System.Drawing.Color.LightBlue;
            this.panelforms.GradientTopRight = System.Drawing.Color.White;
            this.panelforms.Location = new System.Drawing.Point(0, 0);
            this.panelforms.Name = "panelforms";
            this.panelforms.Quality = 10;
            this.panelforms.Size = new System.Drawing.Size(974, 600);
            this.panelforms.TabIndex = 11;
            // 
            // btn_printAll
            // 
            this.btn_printAll.AllowToggling = false;
            this.btn_printAll.AnimationSpeed = 200;
            this.btn_printAll.AutoGenerateColors = false;
            this.btn_printAll.BackColor = System.Drawing.Color.Transparent;
            this.btn_printAll.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.btn_printAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_printAll.BackgroundImage")));
            this.btn_printAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_printAll.ButtonText = "Imprimer tout";
            this.btn_printAll.ButtonTextMarginLeft = 0;
            this.btn_printAll.ColorContrastOnClick = 45;
            this.btn_printAll.ColorContrastOnHover = 45;
            this.btn_printAll.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_printAll.CustomizableEdges = borderEdges1;
            this.btn_printAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_printAll.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_printAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_printAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_printAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_printAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_printAll.ForeColor = System.Drawing.Color.White;
            this.btn_printAll.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_printAll.IconMarginLeft = 11;
            this.btn_printAll.IconPadding = 10;
            this.btn_printAll.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_printAll.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_printAll.IdleBorderRadius = 3;
            this.btn_printAll.IdleBorderThickness = 1;
            this.btn_printAll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.btn_printAll.IdleIconLeftImage = null;
            this.btn_printAll.IdleIconRightImage = null;
            this.btn_printAll.IndicateFocus = false;
            this.btn_printAll.Location = new System.Drawing.Point(806, 339);
            this.btn_printAll.Name = "btn_printAll";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_printAll.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_printAll.OnPressedState = stateProperties2;
            this.btn_printAll.Size = new System.Drawing.Size(156, 45);
            this.btn_printAll.TabIndex = 69;
            this.btn_printAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_printAll.TextMarginLeft = 0;
            this.btn_printAll.UseDefaultRadiusAndThickness = true;
            this.btn_printAll.Click += new System.EventHandler(this.btn_printAll_Click);
            // 
            // btn_print
            // 
            this.btn_print.ActiveImage = null;
            this.btn_print.AllowAnimations = true;
            this.btn_print.AllowBuffering = false;
            this.btn_print.AllowZooming = true;
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_print.ErrorImage")));
            this.btn_print.FadeWhenInactive = false;
            this.btn_print.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.ImageActive = null;
            this.btn_print.ImageLocation = null;
            this.btn_print.ImageMargin = 10;
            this.btn_print.ImageSize = new System.Drawing.Size(61, 57);
            this.btn_print.ImageZoomSize = new System.Drawing.Size(71, 67);
            this.btn_print.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_print.InitialImage")));
            this.btn_print.Location = new System.Drawing.Point(849, 238);
            this.btn_print.Name = "btn_print";
            this.btn_print.Rotation = 0;
            this.btn_print.ShowActiveImage = true;
            this.btn_print.ShowCursorChanges = true;
            this.btn_print.ShowImageBorders = false;
            this.btn_print.ShowSizeMarkers = false;
            this.btn_print.Size = new System.Drawing.Size(71, 67);
            this.btn_print.TabIndex = 68;
            this.btn_print.ToolTipText = "";
            this.btn_print.WaitOnLoad = false;
            this.btn_print.Zoom = 10;
            this.btn_print.ZoomSpeed = 10;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_NBabs
            // 
            this.txt_NBabs.AutoSize = true;
            this.txt_NBabs.BackColor = System.Drawing.Color.Transparent;
            this.txt_NBabs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NBabs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_NBabs.Location = new System.Drawing.Point(634, 99);
            this.txt_NBabs.Name = "txt_NBabs";
            this.txt_NBabs.Size = new System.Drawing.Size(0, 24);
            this.txt_NBabs.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.label8.Location = new System.Drawing.Point(414, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 24);
            this.label8.TabIndex = 65;
            this.label8.Text = "Nombre des jours :";
            // 
            // txt_commmentaire
            // 
            this.txt_commmentaire.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_commmentaire.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_commmentaire.BackColor = System.Drawing.SystemColors.Control;
            this.txt_commmentaire.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_commmentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_commmentaire.Enabled = false;
            this.txt_commmentaire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_commmentaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_commmentaire.HintForeColor = System.Drawing.Color.Empty;
            this.txt_commmentaire.HintText = "";
            this.txt_commmentaire.isPassword = false;
            this.txt_commmentaire.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_commmentaire.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_commmentaire.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_commmentaire.LineThickness = 3;
            this.txt_commmentaire.Location = new System.Drawing.Point(549, 467);
            this.txt_commmentaire.Margin = new System.Windows.Forms.Padding(6);
            this.txt_commmentaire.MaxLength = 32767;
            this.txt_commmentaire.Name = "txt_commmentaire";
            this.txt_commmentaire.Size = new System.Drawing.Size(239, 34);
            this.txt_commmentaire.TabIndex = 64;
            this.txt_commmentaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.label4.Location = new System.Drawing.Point(408, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "Commentaire :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.label7.Location = new System.Drawing.Point(414, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Liste des dates :";
            // 
            // txt_matricule
            // 
            this.txt_matricule.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_matricule.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_matricule.BackColor = System.Drawing.SystemColors.Control;
            this.txt_matricule.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_matricule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matricule.Enabled = false;
            this.txt_matricule.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_matricule.HintForeColor = System.Drawing.Color.Empty;
            this.txt_matricule.HintText = "";
            this.txt_matricule.isPassword = false;
            this.txt_matricule.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_matricule.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_matricule.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_matricule.LineThickness = 3;
            this.txt_matricule.Location = new System.Drawing.Point(136, 517);
            this.txt_matricule.Margin = new System.Windows.Forms.Padding(6);
            this.txt_matricule.MaxLength = 32767;
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(226, 34);
            this.txt_matricule.TabIndex = 57;
            this.txt_matricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_type_abs
            // 
            this.txt_type_abs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_type_abs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_type_abs.BackColor = System.Drawing.SystemColors.Control;
            this.txt_type_abs.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_type_abs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_type_abs.Enabled = false;
            this.txt_type_abs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type_abs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_type_abs.HintForeColor = System.Drawing.Color.Empty;
            this.txt_type_abs.HintText = "";
            this.txt_type_abs.isPassword = false;
            this.txt_type_abs.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_type_abs.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_type_abs.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_type_abs.LineThickness = 3;
            this.txt_type_abs.Location = new System.Drawing.Point(549, 418);
            this.txt_type_abs.Margin = new System.Windows.Forms.Padding(6);
            this.txt_type_abs.MaxLength = 32767;
            this.txt_type_abs.Name = "txt_type_abs";
            this.txt_type_abs.Size = new System.Drawing.Size(239, 34);
            this.txt_type_abs.TabIndex = 58;
            this.txt_type_abs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_cin
            // 
            this.txt_cin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_cin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_cin.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cin.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_cin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cin.Enabled = false;
            this.txt_cin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_cin.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cin.HintText = "";
            this.txt_cin.isPassword = false;
            this.txt_cin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_cin.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_cin.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_cin.LineThickness = 3;
            this.txt_cin.Location = new System.Drawing.Point(136, 419);
            this.txt_cin.Margin = new System.Windows.Forms.Padding(6);
            this.txt_cin.MaxLength = 32767;
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(226, 34);
            this.txt_cin.TabIndex = 60;
            this.txt_cin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_cnss
            // 
            this.txt_cnss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_cnss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_cnss.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cnss.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_cnss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cnss.Enabled = false;
            this.txt_cnss.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cnss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_cnss.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cnss.HintText = "";
            this.txt_cnss.isPassword = false;
            this.txt_cnss.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_cnss.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.txt_cnss.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_cnss.LineThickness = 3;
            this.txt_cnss.Location = new System.Drawing.Point(136, 468);
            this.txt_cnss.Margin = new System.Windows.Forms.Padding(6);
            this.txt_cnss.MaxLength = 32767;
            this.txt_cnss.Name = "txt_cnss";
            this.txt_cnss.Size = new System.Drawing.Size(226, 34);
            this.txt_cnss.TabIndex = 61;
            this.txt_cnss.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.label6.Location = new System.Drawing.Point(37, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "CNSS :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.label5.Location = new System.Drawing.Point(37, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "CIN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(405, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Type d\'absence :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.label2.Location = new System.Drawing.Point(37, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Matricule :";
            // 
            // ddw_months
            // 
            this.ddw_months.BackColor = System.Drawing.SystemColors.Control;
            this.ddw_months.BorderRadius = 1;
            this.ddw_months.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddw_months.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddw_months.DisabledColor = System.Drawing.Color.Gray;
            this.ddw_months.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddw_months.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddw_months.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddw_months.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddw_months.FillDropDown = false;
            this.ddw_months.FillIndicator = false;
            this.ddw_months.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddw_months.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddw_months.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddw_months.FormattingEnabled = true;
            this.ddw_months.Icon = null;
            this.ddw_months.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddw_months.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddw_months.ItemBackColor = System.Drawing.Color.White;
            this.ddw_months.ItemBorderColor = System.Drawing.Color.White;
            this.ddw_months.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddw_months.ItemHeight = 26;
            this.ddw_months.ItemHighLightColor = System.Drawing.Color.LightBlue;
            this.ddw_months.Location = new System.Drawing.Point(411, 160);
            this.ddw_months.Name = "ddw_months";
            this.ddw_months.Size = new System.Drawing.Size(377, 32);
            this.ddw_months.TabIndex = 9;
            this.ddw_months.Text = null;
            this.ddw_months.SelectedValueChanged += new System.EventHandler(this.ddw_months_SelectedValueChanged);
            // 
            // list_date
            // 
            this.list_date.BackColor = System.Drawing.SystemColors.Control;
            this.list_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.list_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.list_date.FormatString = "d";
            this.list_date.FormattingEnabled = true;
            this.list_date.ItemHeight = 24;
            this.list_date.Location = new System.Drawing.Point(411, 192);
            this.list_date.Name = "list_date";
            this.list_date.Size = new System.Drawing.Size(377, 192);
            this.list_date.Sorted = true;
            this.list_date.TabIndex = 8;
            this.list_date.SelectedValueChanged += new System.EventHandler(this.list_date_SelectedValueChanged);
            // 
            // Ddw_fonction
            // 
            this.Ddw_fonction.BackColor = System.Drawing.SystemColors.Control;
            this.Ddw_fonction.BorderRadius = 1;
            this.Ddw_fonction.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.Ddw_fonction.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.Ddw_fonction.DisabledColor = System.Drawing.Color.Gray;
            this.Ddw_fonction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Ddw_fonction.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.Ddw_fonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ddw_fonction.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Ddw_fonction.FillDropDown = false;
            this.Ddw_fonction.FillIndicator = false;
            this.Ddw_fonction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ddw_fonction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ddw_fonction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.Ddw_fonction.FormattingEnabled = true;
            this.Ddw_fonction.Icon = null;
            this.Ddw_fonction.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.Ddw_fonction.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Ddw_fonction.ItemBackColor = System.Drawing.Color.White;
            this.Ddw_fonction.ItemBorderColor = System.Drawing.Color.White;
            this.Ddw_fonction.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.Ddw_fonction.ItemHeight = 26;
            this.Ddw_fonction.ItemHighLightColor = System.Drawing.Color.LightBlue;
            this.Ddw_fonction.Location = new System.Drawing.Point(40, 96);
            this.Ddw_fonction.Name = "Ddw_fonction";
            this.Ddw_fonction.Size = new System.Drawing.Size(322, 32);
            this.Ddw_fonction.TabIndex = 6;
            this.Ddw_fonction.Text = null;
            this.Ddw_fonction.SelectedValueChanged += new System.EventHandler(this.Ddw_fonction_SelectedValueChanged);
            // 
            // list_personnel
            // 
            this.list_personnel.BackColor = System.Drawing.SystemColors.Control;
            this.list_personnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_personnel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.list_personnel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.list_personnel.ItemHeight = 24;
            this.list_personnel.Location = new System.Drawing.Point(40, 144);
            this.list_personnel.Name = "list_personnel";
            this.list_personnel.Size = new System.Drawing.Size(322, 240);
            this.list_personnel.TabIndex = 7;
            this.list_personnel.SelectedValueChanged += new System.EventHandler(this.list_personnel_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details d\'absence";
            // 
            // form_list_ABS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 600);
            this.Controls.Add(this.panelforms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_list_ABS";
            this.Text = "form_list_ABS";
            this.Load += new System.EventHandler(this.form_list_ABS_Load);
            this.panelforms.ResumeLayout(false);
            this.panelforms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelforms;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown Ddw_fonction;
        private System.Windows.Forms.ListBox list_personnel;
        private Bunifu.UI.WinForms.BunifuDropdown ddw_months;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_matricule;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_type_abs;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cnss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_commmentaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_NBabs;
        private System.Windows.Forms.ListBox list_date;
        private Bunifu.UI.WinForms.BunifuImageButton btn_print;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_printAll;
    }
}