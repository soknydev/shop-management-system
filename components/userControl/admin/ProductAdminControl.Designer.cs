namespace shop_management_system.components.userControl.admin
{
    partial class ProductAdminControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdminControl));
            ptImage = new PictureBox();
            lblProductPrice = new Label();
            lblProductName = new Label();
            btnDelete = new PictureBox();
            btnUpdate = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).BeginInit();
            SuspendLayout();
            // 
            // ptImage
            // 
            ptImage.Image = Properties.Resources.bakery1;
            ptImage.Location = new Point(39, 144);
            ptImage.Name = "ptImage";
            ptImage.Size = new Size(220, 145);
            ptImage.SizeMode = PictureBoxSizeMode.Zoom;
            ptImage.TabIndex = 6;
            ptImage.TabStop = false;
            // 
            // lblProductPrice
            // 
            lblProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = Color.FromArgb(126, 96, 191);
            lblProductPrice.Location = new Point(113, 302);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(73, 31);
            lblProductPrice.TabIndex = 5;
            lblProductPrice.Text = "label1";
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProductName.ForeColor = Color.FromArgb(64, 123, 255);
            lblProductName.Location = new Point(39, 90);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(86, 37);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "label1";
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(238, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(49, 37);
            btnDelete.SizeMode = PictureBoxSizeMode.Zoom;
            btnDelete.TabIndex = 10;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(183, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(49, 37);
            btnUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdate.TabIndex = 9;
            btnUpdate.TabStop = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ProductAdminControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(ptImage);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductName);
            Margin = new Padding(10);
            Name = "ProductAdminControl";
            Size = new Size(313, 382);
            ((System.ComponentModel.ISupportInitialize)ptImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptImage;
        private Label lblProductPrice;
        private Label lblProductName;
        private PictureBox btnDelete;
        private PictureBox btnUpdate;
    }
}
