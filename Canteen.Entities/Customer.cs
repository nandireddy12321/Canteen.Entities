using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Entities
{
    public class Customer
    {

        public string customerid { get; set; }
        public string customername { get; set; }
        public string customerusername { get; set; }
        public string customerpassword { get; set; }
        public string customercity { get; set; }
        public string customerstate { get; set; }
        public override string ToString()
        {
            return "customerid  " + customerid + " customername  " + customername + " customerusername " + customerusername +
                "customerpassword  " + customerpassword + "customercity" + customercity + "customerstate"
            + customerstate;
        }
    }
}
