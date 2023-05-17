using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentitiyProject.EntitiyLayer.Concrete
{  
    // Müşteri Hesabı
    public class CustomerAccount
    {
        public int  CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string Currency { get; set; }
        public decimal CusomerAccountBalance { get; set; }
        public string BankBranch { get; set; }

    }
}
