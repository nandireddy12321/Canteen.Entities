using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Entities
{
    public class Orderdetails
    {
        public int orderid { get; set; }
        public string customerid { get; set; }
        public string vendorid { get; set; }
        public string menuid { get; set; }
        public string walletid { get; set; }
        public int qtyord;
        public string orderStatus;
        public DateTime orderDate;
        public double billAmount;
        public string orderComments;
        public override string ToString()
        {
            return "orderID  " + orderid + " customerid  " + customerid + " vendorid " + vendorid +
                "menuid  " + menuid + "walletid" + walletid;
        }
    }
}
