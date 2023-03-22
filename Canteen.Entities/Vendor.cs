using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Entities
{
    public class Vendor
    {
        public string vendorid { get; set; }
        public string vendorname { get; set; }
        public string vendorusername { get; set; }
        public string vendorpassword { get; set; }
        public string vendorcity { get; set; }
        public string vendorstate { get; set; }
        public override string ToString()
        {
            return "vendorid  " + vendorid + " vendorname  " + vendorname + " vendorusername " + vendorusername +
                "vendorpassword  " + vendorpassword + "vendorcity" + vendorcity + "vendorstate"
            + vendorstate;
        }
    }
}
