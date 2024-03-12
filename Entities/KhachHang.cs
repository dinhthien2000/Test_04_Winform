using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_04.Entities
{
    public class KhachHang
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string TaxCode { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsVendor { get; set; }
        public bool IsPersonal { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public decimal DebtLimit { get; set; }
        public int NumberDayLimit { get; set; }

        public KhachHang() { }

        public KhachHang(string customerID, string customerName, string taxCode, bool isCustomer, bool isVendor, bool isPersonal, string mobile, string email, string address, string contactPerson, decimal debtLimit, int numberDayLimit)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            TaxCode = taxCode;
            IsCustomer = isCustomer;
            IsVendor = isVendor;
            IsPersonal = isPersonal;
            Mobile = mobile;
            Email = email;
            Address = address;
            ContactPerson = contactPerson;
            DebtLimit = debtLimit;
            NumberDayLimit = numberDayLimit;
        }
    }
}
