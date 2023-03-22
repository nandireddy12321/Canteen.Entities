using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Entities
{
    public class Wallet
    {
        public string walletid { get; set; }
        public string customerid { get; set; }
        public string wallettype { get; set; }
        public int walletamount { get; set; }
        public override string ToString()
        {
            return "walletid  " + walletid + " customerid  " + customerid + " wallettype " + wallettype +
                "walletamount " + walletamount;

        }
    }
}
