using System.ComponentModel;

namespace shop_management_system.components
{
    public partial class DataGrideViewComponent1 : Component
    {
        public DataGrideViewComponent1()
        {
            InitializeComponent();
        }

        public DataGrideViewComponent1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
