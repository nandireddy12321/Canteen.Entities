using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Entities
{
    public class Menu
    {
        public string menuid { get; set; }
        public string restaurantid { get; set; }
        public string itemname { get; set; }
        public int price { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return "menuid  " + menuid + " restaurantid  " + restaurantid + " itemname " + itemname +
                "price  " + price + "description" + description;
        }
    }
}
