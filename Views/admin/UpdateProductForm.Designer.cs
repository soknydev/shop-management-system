namespace shop_management_system.Views.admin
{
    partial class UpdateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductForm));
            btnClose = new components.ButtonComponent2();
            cmbCategory = new ComboBox();
            btnSave = new components.ButtonComponent1();
            pbProductImage = new PictureBox();
            btnUpload = new Button();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtPrice = new TextBox();
            txtStockLevel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.BackgroundColor = Color.Red;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 8;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(818, 629);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(15, 8, 15, 8);
            btnClose.Size = new Size(127, 54);
            btnClose.TabIndex = 65;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(499, 571);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(223, 36);
            cmbCategory.TabIndex = 64;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 123, 255);
            btnSave.BackgroundColor = Color.FromArgb(64, 123, 255);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 10;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(994, 629);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(15, 8, 15, 8);
            btnSave.Size = new Size(134, 50);
            btnSave.TabIndex = 63;
            btnSave.Text = "Update";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pbProductImage
            // 
            pbProductImage.Image = (Image)resources.GetObject("pbProductImage.Image");
            pbProductImage.Location = new Point(960, 289);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(178, 180);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 62;
            pbProductImage.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(960, 209);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(178, 46);
            btnUpload.TabIndex = 61;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUploadImage_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(306, 571);
            label9.Name = "label9";
            label9.Size = new Size(92, 28);
            label9.TabIndex = 60;
            label9.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(850, 214);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 59;
            label8.Text = "Image";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(306, 474);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 57;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(306, 385);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 55;
            label4.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(499, 300);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(223, 34);
            txtDescription.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 300);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 53;
            label3.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(499, 208);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(223, 34);
            txtProductName.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 208);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 51;
            label2.Text = "Produc Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 123, 255);
            label1.Location = new Point(330, 88);
            label1.Name = "label1";
            label1.Size = new Size(286, 50);
            label1.TabIndex = 50;
            label1.Text = "Update Product";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(499, 379);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(223, 34);
            txtPrice.TabIndex = 68;
            // 
            // txtStockLevel
            // 
            txtStockLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockLevel.Location = new Point(499, 468);
            txtStockLevel.Name = "txtStockLevel";
            txtStockLevel.Size = new Size(223, 34);
            txtStockLevel.TabIndex = 69;
            txtStockLevel.Text = "50";
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 771);
            Controls.Add(txtStockLevel);
            Controls.Add(txtPrice);
            Controls.Add(btnClose);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            Controls.Add(pbProductImage);
            Controls.Add(btnUpload);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private components.ButtonComponent2 btnClose;
        private ComboBox cmbCategory;
        private components.ButtonComponent1 btnSave;
        private PictureBox pbProductImage;
        private Button btnUpload;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label4;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private Label label1;
        private TextBox txtPrice;
        private TextBox txtStockLevel;
    }
}