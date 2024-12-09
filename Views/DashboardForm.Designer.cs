namespace shop_management_system.Views
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            fplContainer = new components.PanelComponent1();
            flpProducts = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            pbProfile = new components.PictureBoxComponent1();
            panel4 = new Panel();
            lblWelcome = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            btnPay = new components.ButtonSidebar1();
            btnCart = new components.ButtonSidebar1();
            btnProducts = new components.ButtonSidebar();
            pbLogo = new PictureBox();
            panel3 = new Panel();
            logoutButton1 = new components.LogoutButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            fplContainer.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1924, 1055);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(fplContainer, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(223, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1698, 1049);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // fplContainer
            // 
            fplContainer.BackColor = Color.White;
            fplContainer.Controls.Add(flpProducts);
            fplContainer.Dock = DockStyle.Fill;
            fplContainer.Location = new Point(3, 105);
            fplContainer.Margin = new Padding(3, 20, 30, 20);
            fplContainer.Name = "fplContainer";
            fplContainer.Size = new Size(1665, 924);
            fplContainer.TabIndex = 0;
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.Dock = DockStyle.Fill;
            flpProducts.Location = new Point(0, 0);
            flpProducts.Margin = new Padding(50, 100, 50, 20);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(1665, 924);
            flpProducts.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(panel2, 1, 0);
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1692, 79);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbProfile);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1545, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 73);
            panel2.TabIndex = 0;
            // 
            // pbProfile
            // 
            pbProfile.BackColor = Color.Transparent;
            pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
            pbProfile.Location = new Point(40, 5);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(65, 65);
            pbProfile.TabIndex = 0;
            pbProfile.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblWelcome);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(txtSearch);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1536, 73);
            panel4.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.ForeColor = Color.FromArgb(64, 123, 255);
            lblWelcome.Location = new Point(24, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(78, 32);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "label1";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(665, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 42);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(318, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 39);
            txtSearch.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(panel3, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.Size = new Size(214, 1049);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(btnCart);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(pbLogo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 949);
            panel1.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.BackColor = SystemColors.Control;
            btnPay.BackgroundColor = SystemColors.Control;
            btnPay.BorderColor = Color.PaleVioletRed;
            btnPay.BorderRadius = 10;
            btnPay.BorderSize = 0;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI Semibold", 12F);
            btnPay.ForeColor = Color.Black;
            btnPay.Location = new Point(10, 248);
            btnPay.Name = "btnPay";
            btnPay.Padding = new Padding(15, 5, 30, 5);
            btnPay.Size = new Size(188, 50);
            btnPay.TabIndex = 7;
            btnPay.Text = "Payments";
            btnPay.TextAlign = ContentAlignment.MiddleLeft;
            btnPay.TextColor = Color.Black;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = SystemColors.Control;
            btnCart.BackgroundColor = SystemColors.Control;
            btnCart.BorderColor = Color.PaleVioletRed;
            btnCart.BorderRadius = 10;
            btnCart.BorderSize = 0;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI Semibold", 12F);
            btnCart.ForeColor = Color.Black;
            btnCart.Location = new Point(9, 192);
            btnCart.Name = "btnCart";
            btnCart.Padding = new Padding(15, 5, 30, 5);
            btnCart.Size = new Size(188, 50);
            btnCart.TabIndex = 6;
            btnCart.Text = "Carts";
            btnCart.TextAlign = ContentAlignment.MiddleLeft;
            btnCart.TextColor = Color.Black;
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(64, 123, 255);
            btnProducts.BackgroundColor = Color.FromArgb(64, 123, 255);
            btnProducts.BorderColor = Color.PaleVioletRed;
            btnProducts.BorderRadius = 10;
            btnProducts.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 12F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(9, 136);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(15, 5, 30, 5);
            btnProducts.Size = new Size(189, 50);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextColor = Color.White;
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(19, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(logoutButton1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 952);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 94);
            panel3.TabIndex = 1;
            // 
            // logoutButton1
            // 
            logoutButton1.BackColor = Color.FromArgb(250, 64, 50);
            logoutButton1.BackgroundColor = Color.FromArgb(250, 64, 50);
            logoutButton1.BorderColor = Color.PaleVioletRed;
            logoutButton1.BorderRadius = 10;
            logoutButton1.BorderSize = 0;
            logoutButton1.FlatAppearance.BorderSize = 0;
            logoutButton1.FlatStyle = FlatStyle.Flat;
            logoutButton1.Font = new Font("Segoe UI Semibold", 12F);
            logoutButton1.ForeColor = Color.White;
            logoutButton1.Location = new Point(39, 0);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Padding = new Padding(15, 8, 15, 8);
            logoutButton1.Size = new Size(129, 51);
            logoutButton1.TabIndex = 1;
            logoutButton1.Text = "Logout";
            logoutButton1.TextColor = Color.White;
            logoutButton1.UseVisualStyleBackColor = false;
            logoutButton1.Click += logoutButton1_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            fplContainer.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbLogo;
        private TableLayoutPanel tableLayoutPanel2;
        private components.ButtonSidebar btnProducts;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Panel panel3;
        private components.LogoutButton logoutButton1;
        private components.PanelComponent1 fplContainer;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private components.PictureBoxComponent1 pbProfile;
        public FlowLayoutPanel flpProducts;
        private Panel panel4;
        private Label lblWelcome;
        private Button btnSearch;
        private TextBox txtSearch;
        private components.ButtonSidebar1 btnPay;
        private components.ButtonSidebar1 btnCart;
    }
}