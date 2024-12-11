using shop_management_system.Controllers;
using shop_management_system.Models;
using shop_management_system.Views.admin;

namespace shop_management_system.components.userControl.admin
{
    public partial class ProductAdminControl : UserControl
    {
        private Product _product; // Store the current product
        private readonly ProductController _productController;

        public ProductAdminControl()
        {
            InitializeComponent();
            _productController = new ProductController(); // Initialize the ProductController
        }

        public void SetProduct(Product product)
        {
            _product = product;
            lblProductName.Text = product.Name;
            lblProductPrice.Text = $"${product.Price:F2}";

            try
            {
                if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
                {
                    ptImage.Image = Image.FromFile(product.ImagePath);
                }
                else
                {
                    ptImage.Image = Properties.Resources.bun_8447394_640;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image for product {product.Name}: {ex.Message}");
                ptImage.Image = Properties.Resources.bun_8447394_640;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("No product selected for updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updateForm = new UpdateProductForm();
            updateForm.SetProduct(_product);

            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                var updatedProduct = updateForm.UpdatedProduct;
                bool isUpdated = _productController.UpdateProduct(updatedProduct);

                if (isUpdated)
                {
                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetProduct(updatedProduct); // Update the UI with new product details
                }
                else
                {
                    MessageBox.Show("Failed to update the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("No product selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete {_product.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool isDeleted = _productController.DeleteProduct(_product.ProductId);

                if (isDeleted)
                {
                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Parent?.Controls.Remove(this); // Remove this control from the parent container
                }
                else
                {
                    MessageBox.Show("Failed to delete the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
