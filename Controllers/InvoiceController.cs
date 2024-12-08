using shop_management_system.Models;
using shop_management_system.Services;

namespace shop_management_system.Controllers
{
    public class InvoiceController
    {
        private readonly InvoiceService _invoiceService;

        public InvoiceController()
        {
            _invoiceService = new InvoiceService();
        }

        public List<Invoice> GetInvoicesByEmployeeId(int employeeId)
        {
            return _invoiceService.GetInvoicesByEmployeeId(employeeId);
        }
    }
}
