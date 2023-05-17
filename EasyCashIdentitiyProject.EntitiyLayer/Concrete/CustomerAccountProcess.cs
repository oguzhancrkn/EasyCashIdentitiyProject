using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentitiyProject.EntitiyLayer.Concrete
{
    //Gelen giden para ödemeler AppUser : gönderen ver alıcı iki adım  olucak Müşteri Hesabı Süreci
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }

    }
}
