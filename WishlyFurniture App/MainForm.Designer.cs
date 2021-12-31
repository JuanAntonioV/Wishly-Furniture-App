
namespace WishlyFurniture_App
{
    partial class MainForm
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
            this.BorderControl = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.picUserProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnWarehouse = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.spTaskbar = new Guna.UI2.WinForms.Guna2Separator();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pcMenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderControl
            // 
            this.BorderControl.BorderRadius = 20;
            this.BorderControl.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.lblUsername);
            this.pnlMenu.Controls.Add(this.lblPosition);
            this.pnlMenu.Controls.Add(this.picUserProfile);
            this.pnlMenu.Controls.Add(this.btnEmployee);
            this.pnlMenu.Controls.Add(this.btnPurchase);
            this.pnlMenu.Controls.Add(this.lblCopyright);
            this.pnlMenu.Controls.Add(this.btnWarehouse);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.ShadowDecoration.Parent = this.pnlMenu;
            this.pnlMenu.Size = new System.Drawing.Size(183, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Animated = true;
            this.btnLogOut.AutoRoundedCorners = true;
            this.btnLogOut.BorderRadius = 21;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = global::WishlyFurniture_App.Properties.Resources.LogOut;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLogOut.ImageSize = new System.Drawing.Size(32, 30);
            this.btnLogOut.Location = new System.Drawing.Point(0, 311);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(183, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.TextOffset = new System.Drawing.Point(30, 0);
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(76, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(50, 16);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Admin";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(76, 42);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(67, 13);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Administrator";
            // 
            // picUserProfile
            // 
            this.picUserProfile.Image = global::WishlyFurniture_App.Properties.Resources.UserProfile;
            this.picUserProfile.Location = new System.Drawing.Point(20, 14);
            this.picUserProfile.Name = "picUserProfile";
            this.picUserProfile.ShadowDecoration.Parent = this.picUserProfile;
            this.picUserProfile.Size = new System.Drawing.Size(50, 50);
            this.picUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserProfile.TabIndex = 1;
            this.picUserProfile.TabStop = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployee.Animated = true;
            this.btnEmployee.AutoRoundedCorners = true;
            this.btnEmployee.BorderRadius = 21;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.White;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = global::WishlyFurniture_App.Properties.Resources.Employee;
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnEmployee.ImageSize = new System.Drawing.Size(32, 30);
            this.btnEmployee.Location = new System.Drawing.Point(0, 215);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(183, 45);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.TextOffset = new System.Drawing.Point(30, 0);
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurchase.Animated = true;
            this.btnPurchase.AutoRoundedCorners = true;
            this.btnPurchase.BorderRadius = 21;
            this.btnPurchase.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPurchase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnPurchase.CheckedState.Parent = this.btnPurchase;
            this.btnPurchase.CustomImages.Parent = this.btnPurchase;
            this.btnPurchase.FillColor = System.Drawing.Color.White;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.Black;
            this.btnPurchase.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnPurchase.HoverState.Parent = this.btnPurchase;
            this.btnPurchase.Image = global::WishlyFurniture_App.Properties.Resources.Purchase;
            this.btnPurchase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchase.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPurchase.ImageSize = new System.Drawing.Size(32, 30);
            this.btnPurchase.Location = new System.Drawing.Point(0, 167);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.ShadowDecoration.Parent = this.btnPurchase;
            this.btnPurchase.Size = new System.Drawing.Size(183, 45);
            this.btnPurchase.TabIndex = 4;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchase.TextOffset = new System.Drawing.Point(30, 0);
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(29, 570);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(116, 13);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Created by Kelompok 7";
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWarehouse.Animated = true;
            this.btnWarehouse.AutoRoundedCorners = true;
            this.btnWarehouse.BorderRadius = 21;
            this.btnWarehouse.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWarehouse.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnWarehouse.CheckedState.Parent = this.btnWarehouse;
            this.btnWarehouse.CustomImages.Parent = this.btnWarehouse;
            this.btnWarehouse.FillColor = System.Drawing.Color.White;
            this.btnWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouse.ForeColor = System.Drawing.Color.Black;
            this.btnWarehouse.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnWarehouse.HoverState.Parent = this.btnWarehouse;
            this.btnWarehouse.Image = global::WishlyFurniture_App.Properties.Resources.Warehouse;
            this.btnWarehouse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWarehouse.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnWarehouse.ImageSize = new System.Drawing.Size(32, 30);
            this.btnWarehouse.Location = new System.Drawing.Point(0, 263);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.ShadowDecoration.Parent = this.btnWarehouse;
            this.btnWarehouse.Size = new System.Drawing.Size(183, 45);
            this.btnWarehouse.TabIndex = 2;
            this.btnWarehouse.Text = "Warehouse";
            this.btnWarehouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWarehouse.TextOffset = new System.Drawing.Point(30, 0);
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.Animated = true;
            this.btnDashboard.AutoRoundedCorners = true;
            this.btnDashboard.BorderRadius = 21;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.White;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::WishlyFurniture_App.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(0, 119);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(183, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(30, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // spTaskbar
            // 
            this.spTaskbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spTaskbar.BackColor = System.Drawing.Color.Transparent;
            this.spTaskbar.FillColor = System.Drawing.Color.Gainsboro;
            this.spTaskbar.Location = new System.Drawing.Point(183, 41);
            this.spTaskbar.Name = "spTaskbar";
            this.spTaskbar.Size = new System.Drawing.Size(814, 10);
            this.spTaskbar.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(183, 57);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(814, 543);
            this.pnlMain.TabIndex = 2;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(247, 14);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(84, 16);
            this.lblMenu.TabIndex = 9;
            this.lblMenu.Text = "Dashboard";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = global::WishlyFurniture_App.Properties.Resources.Minimize;
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(900, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(50, 31);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.HoverState.Image = global::WishlyFurniture_App.Properties.Resources.Close_T;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::WishlyFurniture_App.Properties.Resources.Close;
            this.btnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Location = new System.Drawing.Point(950, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(50, 31);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pcMenu
            // 
            this.pcMenu.Image = global::WishlyFurniture_App.Properties.Resources.Dashboard;
            this.pcMenu.Location = new System.Drawing.Point(211, 8);
            this.pcMenu.Name = "pcMenu";
            this.pcMenu.ShadowDecoration.Parent = this.pcMenu;
            this.pcMenu.Size = new System.Drawing.Size(30, 30);
            this.pcMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcMenu.TabIndex = 8;
            this.pcMenu.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pcMenu);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.spTaskbar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse BorderControl;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnWarehouse;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label lblCopyright;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnPurchase;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPosition;
        private Guna.UI2.WinForms.Guna2PictureBox picUserProfile;
        private Guna.UI2.WinForms.Guna2Separator spTaskbar;
        private System.Windows.Forms.Label lblMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pcMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
    }
}