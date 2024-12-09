namespace shop_management_system.Views
{
    partial class MyPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPaymentForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            logoutButton1 = new components.LogoutButton();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panelComponent11 = new components.PanelComponent1();
            flpInvoices = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            pbProfile = new components.PictureBoxComponent1();
            panel4 = new Panel();
            lblWelcome = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnPay = new components.ButtonSidebar1();
            btnProducts = new components.ButtonSidebar1();
            btnCarts = new components.ButtonSidebar();
            pbLogo = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelComponent11.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1469, 820);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Size = new Size(214, 814);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(logoutButton1);
            panel1.Location = new Point(3, 667);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 144);
            panel1.TabIndex = 0;
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
            logoutButton1.Location = new Point(43, 0);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Padding = new Padding(15, 8, 15, 8);
            logoutButton1.Size = new Size(129, 51);
            logoutButton1.TabIndex = 2;
            logoutButton1.Text = "Logout";
            logoutButton1.TextColor = Color.White;
            logoutButton1.UseVisualStyleBackColor = false;
            logoutButton1.Click += logoutButton1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnCarts);
            panel2.Controls.Add(pbLogo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 658);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(panelComponent11, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(223, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1243, 814);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panelComponent11
            // 
            panelComponent11.BackColor = Color.White;
            panelComponent11.Controls.Add(flpInvoices);
            panelComponent11.Dock = DockStyle.Fill;
            panelComponent11.Location = new Point(20, 105);
            panelComponent11.Margin = new Padding(20);
            panelComponent11.Name = "panelComponent11";
            panelComponent11.Size = new Size(1203, 689);
            panelComponent11.TabIndex = 0;
            // 
            // flpInvoices
            // 
            flpInvoices.AutoScroll = true;
            flpInvoices.Dock = DockStyle.Fill;
            flpInvoices.Location = new Point(0, 0);
            flpInvoices.Margin = new Padding(30);
            flpInvoices.Name = "flpInvoices";
            flpInvoices.Size = new Size(1203, 689);
            flpInvoices.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1237, 79);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbProfile);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1090, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 73);
            panel3.TabIndex = 3;
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
            panel4.Size = new Size(1081, 73);
            panel4.TabIndex = 2;
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
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(318, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 39);
            txtSearch.TabIndex = 0;
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
            btnPay.Location = new Point(10, 191);
            btnPay.Name = "btnPay";
            btnPay.Padding = new Padding(15, 5, 30, 5);
            btnPay.Size = new Size(188, 50);
            btnPay.TabIndex = 15;
            btnPay.Text = "Carts";
            btnPay.TextAlign = ContentAlignment.MiddleLeft;
            btnPay.TextColor = Color.Black;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnCarts_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.Control;
            btnProducts.BackgroundColor = SystemColors.Control;
            btnProducts.BorderColor = Color.PaleVioletRed;
            btnProducts.BorderRadius = 10;
            btnProducts.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 12F);
            btnProducts.ForeColor = Color.Black;
            btnProducts.Location = new Point(10, 135);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(15, 5, 30, 5);
            btnProducts.Size = new Size(188, 50);
            btnProducts.TabIndex = 14;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextColor = Color.Black;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCarts
            // 
            btnCarts.BackColor = Color.FromArgb(64, 123, 255);
            btnCarts.BackgroundColor = Color.FromArgb(64, 123, 255);
            btnCarts.BorderColor = Color.PaleVioletRed;
            btnCarts.BorderRadius = 10;
            btnCarts.BorderSize = 0;
            btnCarts.FlatAppearance.BorderSize = 0;
            btnCarts.FlatStyle = FlatStyle.Flat;
            btnCarts.Font = new Font("Segoe UI Semibold", 12F);
            btnCarts.ForeColor = Color.White;
            btnCarts.Location = new Point(16, 247);
            btnCarts.Name = "btnCarts";
            btnCarts.Padding = new Padding(15, 5, 30, 5);
            btnCarts.Size = new Size(189, 50);
            btnCarts.TabIndex = 13;
            btnCarts.Text = "Payments";
            btnCarts.TextAlign = ContentAlignment.MiddleLeft;
            btnCarts.TextColor = Color.White;
            btnCarts.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(18, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 12;
            pbLogo.TabStop = false;
            // 
            // MyPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 820);
            Controls.Add(tableLayoutPanel1);
            Name = "MyPaymentForm";
            Text = "MyPaymentForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panelComponent11.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private components.LogoutButton logoutButton1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private components.PanelComponent1 panelComponent11;
        private FlowLayoutPanel flpInvoices;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private Label lblWelcome;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel3;
        private components.PictureBoxComponent1 pbProfile;
        private components.ButtonSidebar1 btnPay;
        private components.ButtonSidebar1 btnProducts;
        private components.ButtonSidebar btnCarts;
        private PictureBox pbLogo;
    }
}