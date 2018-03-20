using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.ViewModels
{
    class SiparisViewModel
    {
        public int SiparisNo { get; set; }
        public DateTime SiparisTarihi { get; set; }         
        public decimal ToplamSiparisTutari { get; set; }
        public string OdemeSekli { get; set; }
        public decimal KDV { get; set; }
    }
}
