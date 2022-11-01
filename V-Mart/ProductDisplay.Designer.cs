namespace V_Mart
{
    partial class ProductDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDisplay));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.PB_ProductImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lbl_productname = new Bunifu.UI.WinForms.BunifuLabel();
            this.rating_product = new Bunifu.UI.WinForms.BunifuRating();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_PriceValue = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_details = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_CheckOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lb_StockValue = new Bunifu.UI.WinForms.BunifuLabel();
            this.Input_Quantity = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_ProductImg
            // 
            this.PB_ProductImg.Image = ((System.Drawing.Image)(resources.GetObject("PB_ProductImg.Image")));
            this.PB_ProductImg.Location = new System.Drawing.Point(19, 14);
            this.PB_ProductImg.Name = "PB_ProductImg";
            this.PB_ProductImg.ShadowDecoration.Parent = this.PB_ProductImg;
            this.PB_ProductImg.Size = new System.Drawing.Size(226, 170);
            this.PB_ProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ProductImg.TabIndex = 0;
            this.PB_ProductImg.TabStop = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Gainsboro;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(263, 14);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 170);
            this.bunifuSeparator3.TabIndex = 46;
            // 
            // lbl_productname
            // 
            this.lbl_productname.AllowParentOverrides = false;
            this.lbl_productname.AutoEllipsis = false;
            this.lbl_productname.CursorType = null;
            this.lbl_productname.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_productname.Location = new System.Drawing.Point(279, 14);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_productname.Size = new System.Drawing.Size(165, 32);
            this.lbl_productname.TabIndex = 47;
            this.lbl_productname.Text = "Product Name";
            this.lbl_productname.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_productname.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // rating_product
            // 
            this.rating_product.BackColor = System.Drawing.Color.Transparent;
            this.rating_product.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rating_product.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.rating_product.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rating_product.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rating_product.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rating_product.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rating_product.InnerRadius = 2F;
            this.rating_product.Location = new System.Drawing.Point(808, 24);
            this.rating_product.Name = "rating_product";
            this.rating_product.OuterRadius = 10F;
            this.rating_product.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rating_product.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rating_product.ReadOnly = false;
            this.rating_product.RightClickToClear = true;
            this.rating_product.Size = new System.Drawing.Size(121, 22);
            this.rating_product.TabIndex = 48;
            this.rating_product.Text = "bunifuRating1";
            this.rating_product.Value = 3;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Orange;
            this.bunifuLabel1.Location = new System.Drawing.Point(279, 138);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(55, 20);
            this.bunifuLabel1.TabIndex = 49;
            this.bunifuLabel1.Text = "Price $ :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_PriceValue
            // 
            this.lbl_PriceValue.AllowParentOverrides = false;
            this.lbl_PriceValue.AutoEllipsis = false;
            this.lbl_PriceValue.CursorType = null;
            this.lbl_PriceValue.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PriceValue.ForeColor = System.Drawing.Color.Orange;
            this.lbl_PriceValue.Location = new System.Drawing.Point(344, 130);
            this.lbl_PriceValue.Name = "lbl_PriceValue";
            this.lbl_PriceValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_PriceValue.Size = new System.Drawing.Size(42, 32);
            this.lbl_PriceValue.TabIndex = 50;
            this.lbl_PriceValue.Text = "412";
            this.lbl_PriceValue.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_PriceValue.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_details
            // 
            this.lbl_details.AllowParentOverrides = false;
            this.lbl_details.AutoEllipsis = false;
            this.lbl_details.CursorType = null;
            this.lbl_details.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_details.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_details.Location = new System.Drawing.Point(279, 61);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_details.Size = new System.Drawing.Size(665, 60);
            this.lbl_details.TabIndex = 51;
            this.lbl_details.Text = resources.GetString("lbl_details.Text");
            this.lbl_details.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_details.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.AllowAnimations = true;
            this.btn_CheckOut.AllowMouseEffects = true;
            this.btn_CheckOut.AllowToggling = false;
            this.btn_CheckOut.AnimationSpeed = 200;
            this.btn_CheckOut.AutoGenerateColors = false;
            this.btn_CheckOut.AutoRoundBorders = false;
            this.btn_CheckOut.AutoSizeLeftIcon = true;
            this.btn_CheckOut.AutoSizeRightIcon = true;
            this.btn_CheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_CheckOut.BackColor1 = System.Drawing.Color.Orange;
            this.btn_CheckOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CheckOut.BackgroundImage")));
            this.btn_CheckOut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CheckOut.ButtonText = "Check Out";
            this.btn_CheckOut.ButtonTextMarginLeft = 0;
            this.btn_CheckOut.ColorContrastOnClick = 45;
            this.btn_CheckOut.ColorContrastOnHover = 45;
            this.btn_CheckOut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_CheckOut.CustomizableEdges = borderEdges1;
            this.btn_CheckOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_CheckOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_CheckOut.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_CheckOut.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_CheckOut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_CheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_CheckOut.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CheckOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_CheckOut.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_CheckOut.IconMarginLeft = 11;
            this.btn_CheckOut.IconPadding = 10;
            this.btn_CheckOut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CheckOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_CheckOut.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_CheckOut.IconSize = 25;
            this.btn_CheckOut.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_CheckOut.IdleBorderRadius = 15;
            this.btn_CheckOut.IdleBorderThickness = 2;
            this.btn_CheckOut.IdleFillColor = System.Drawing.Color.Orange;
            this.btn_CheckOut.IdleIconLeftImage = null;
            this.btn_CheckOut.IdleIconRightImage = null;
            this.btn_CheckOut.IndicateFocus = false;
            this.btn_CheckOut.Location = new System.Drawing.Point(808, 152);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_CheckOut.OnDisabledState.BorderRadius = 15;
            this.btn_CheckOut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CheckOut.OnDisabledState.BorderThickness = 2;
            this.btn_CheckOut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_CheckOut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_CheckOut.OnDisabledState.IconLeftImage = null;
            this.btn_CheckOut.OnDisabledState.IconRightImage = null;
            this.btn_CheckOut.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_CheckOut.onHoverState.BorderRadius = 15;
            this.btn_CheckOut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CheckOut.onHoverState.BorderThickness = 2;
            this.btn_CheckOut.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_CheckOut.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.onHoverState.IconLeftImage = null;
            this.btn_CheckOut.onHoverState.IconRightImage = null;
            this.btn_CheckOut.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_CheckOut.OnIdleState.BorderRadius = 15;
            this.btn_CheckOut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CheckOut.OnIdleState.BorderThickness = 2;
            this.btn_CheckOut.OnIdleState.FillColor = System.Drawing.Color.Orange;
            this.btn_CheckOut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.OnIdleState.IconLeftImage = null;
            this.btn_CheckOut.OnIdleState.IconRightImage = null;
            this.btn_CheckOut.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_CheckOut.OnPressedState.BorderRadius = 15;
            this.btn_CheckOut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CheckOut.OnPressedState.BorderThickness = 2;
            this.btn_CheckOut.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_CheckOut.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.OnPressedState.IconLeftImage = null;
            this.btn_CheckOut.OnPressedState.IconRightImage = null;
            this.btn_CheckOut.Size = new System.Drawing.Size(121, 39);
            this.btn_CheckOut.TabIndex = 52;
            this.btn_CheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CheckOut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_CheckOut.TextMarginLeft = 0;
            this.btn_CheckOut.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_CheckOut.UseDefaultRadiusAndThickness = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_BuyProduct_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Orange;
            this.bunifuLabel2.Location = new System.Drawing.Point(279, 171);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(107, 20);
            this.bunifuLabel2.TabIndex = 53;
            this.bunifuLabel2.Text = "StockQuantity : ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lb_StockValue
            // 
            this.lb_StockValue.AllowParentOverrides = false;
            this.lb_StockValue.AutoEllipsis = false;
            this.lb_StockValue.CursorType = null;
            this.lb_StockValue.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StockValue.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lb_StockValue.Location = new System.Drawing.Point(393, 163);
            this.lb_StockValue.Name = "lb_StockValue";
            this.lb_StockValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_StockValue.Size = new System.Drawing.Size(28, 32);
            this.lb_StockValue.TabIndex = 54;
            this.lb_StockValue.Text = "15";
            this.lb_StockValue.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_StockValue.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Input_Quantity
            // 
            this.Input_Quantity.AcceptsReturn = false;
            this.Input_Quantity.AcceptsTab = false;
            this.Input_Quantity.AnimationSpeed = 200;
            this.Input_Quantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Input_Quantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Input_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.Input_Quantity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Input_Quantity.BackgroundImage")));
            this.Input_Quantity.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Input_Quantity.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Input_Quantity.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Input_Quantity.BorderColorIdle = System.Drawing.Color.Silver;
            this.Input_Quantity.BorderRadius = 6;
            this.Input_Quantity.BorderThickness = 1;
            this.Input_Quantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Input_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input_Quantity.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Input_Quantity.DefaultText = "";
            this.Input_Quantity.FillColor = System.Drawing.Color.White;
            this.Input_Quantity.HideSelection = true;
            this.Input_Quantity.IconLeft = null;
            this.Input_Quantity.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Input_Quantity.IconPadding = 10;
            this.Input_Quantity.IconRight = null;
            this.Input_Quantity.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Input_Quantity.Lines = new string[0];
            this.Input_Quantity.Location = new System.Drawing.Point(737, 155);
            this.Input_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Input_Quantity.MaxLength = 32767;
            this.Input_Quantity.MinimumSize = new System.Drawing.Size(1, 1);
            this.Input_Quantity.Modified = false;
            this.Input_Quantity.Multiline = false;
            this.Input_Quantity.Name = "Input_Quantity";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Input_Quantity.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Input_Quantity.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Input_Quantity.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Input_Quantity.OnIdleState = stateProperties4;
            this.Input_Quantity.Padding = new System.Windows.Forms.Padding(2);
            this.Input_Quantity.PasswordChar = '\0';
            this.Input_Quantity.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Input_Quantity.PlaceholderText = "1";
            this.Input_Quantity.ReadOnly = false;
            this.Input_Quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Input_Quantity.SelectedText = "";
            this.Input_Quantity.SelectionLength = 0;
            this.Input_Quantity.SelectionStart = 0;
            this.Input_Quantity.ShortcutsEnabled = true;
            this.Input_Quantity.Size = new System.Drawing.Size(54, 34);
            this.Input_Quantity.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Input_Quantity.TabIndex = 55;
            this.Input_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Input_Quantity.TextMarginBottom = 0;
            this.Input_Quantity.TextMarginLeft = 3;
            this.Input_Quantity.TextMarginTop = 0;
            this.Input_Quantity.TextPlaceholder = "1";
            this.Input_Quantity.UseSystemPasswordChar = false;
            this.Input_Quantity.WordWrap = true;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Orange;
            this.bunifuLabel3.Location = new System.Drawing.Point(669, 163);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(61, 20);
            this.bunifuLabel3.TabIndex = 56;
            this.bunifuLabel3.Text = "Quantity";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ProductDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.Input_Quantity);
            this.Controls.Add(this.lb_StockValue);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.lbl_PriceValue);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.rating_product);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.PB_ProductImg);
            this.Name = "ProductDisplay";
            this.Size = new System.Drawing.Size(951, 200);
            ((System.ComponentModel.ISupportInitialize)(this.PB_ProductImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PB_ProductImg;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuLabel lbl_productname;
        private Bunifu.UI.WinForms.BunifuRating rating_product;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_PriceValue;
        private Bunifu.UI.WinForms.BunifuLabel lbl_details;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_CheckOut;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lb_StockValue;
        private Bunifu.UI.WinForms.BunifuTextBox Input_Quantity;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}
