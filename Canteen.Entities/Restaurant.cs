using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Entities
{
    public class Restaurant
    {
        public string restaurantid { get; set; }
        public string restaurantname { get; set; }
        public string location { get; set; }
        public string rating { get; set; }
        public override string ToString()
        {
            return "restaurantid  " + restaurantid + " restaurantname  " + restaurantname + " location " + location +
                "  rating  " + rating;

        }
    }
}
