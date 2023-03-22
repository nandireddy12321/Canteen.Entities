using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Canteen.Entities;
using Canteen.DAO;

using System.Threading.Tasks;

namespace CmsProject.Main
{
    public class Program
    {
        public static void Showrest()
        {
            CanteenDAO dao = new CanteenDAO();
            List<Canteen.Entities.Restaurant> restList = dao.Showrest();

            foreach (Canteen.Entities.Restaurant r in restList)
            {
                Console.WriteLine(r);
            }
        }
        public static void Searchrest()
        {
            CanteenDAO dao = new CanteenDAO();
            string restaurantid;
            Console.WriteLine("Enter restaurantid :   ");
            restaurantid = Console.ReadLine();
            Canteen.Entities.Restaurant restFound = dao.Searchrest(restaurantid);
            if (restFound != null)
            {
                Console.WriteLine(restFound);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
        public static void Showcust()
        {
            CanteenDAO dao = new CanteenDAO();
            List<Canteen.Entities.Customer> custList = dao.Showcust();

            foreach (Canteen.Entities.Customer c in custList)
            {
                Console.WriteLine(c);
            }
        }
        public static void Searchcust()
        {
            CanteenDAO dao = new CanteenDAO();
            string customerid;
            Console.WriteLine("Enter customerid :   ");
            customerid = Console.ReadLine();
            Canteen.Entities.Customer custFound = dao.Searchcust(customerid);
            if (custFound != null)
            {
                Console.WriteLine(custFound);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
        public static void Showmenu()
        {
            CanteenDAO dao = new CanteenDAO();
            List<Canteen.Entities.Menu> menuList = dao.Showmenu();

            foreach (Canteen.Entities.Menu m in menuList)
            {
                Console.WriteLine(m);
            }
        }
        public static void Searchmenu()
        {
            CanteenDAO dao = new CanteenDAO();
            string menuid;
            Console.WriteLine("Enter menuid :   ");
            menuid = Console.ReadLine();
            Canteen.Entities.Menu menuFound = dao.Searchmenu(menuid);
            if (menuFound != null)
            {
                Console.WriteLine(menuFound);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
        public static void Showvendor()
        {
            CanteenDAO dao = new CanteenDAO();
            List<Canteen.Entities.Vendor> vendorList = dao.Showvendor();

            foreach (Canteen.Entities.Vendor v in vendorList)
            {
                Console.WriteLine(v);
            }
        }
        public static void Searchvendor()
        {
            CanteenDAO dao = new CanteenDAO();
            string vendorid;
            Console.WriteLine("Enter vendorid :   ");
            vendorid = Console.ReadLine();
            Canteen.Entities.Vendor vendorFound = dao.Searchvendor(vendorid);
            if (vendorFound != null)
            {
                Console.WriteLine(vendorFound);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }


        public static void Searchbyvendorname()
        {
            CanteenDAO dao = new CanteenDAO();
            string vendorname;
            Console.WriteLine("Enter vendorname :   ");
            vendorname = Console.ReadLine();
            Canteen.Entities.Vendor SearchbyvendornameFound = dao.Searchbyvendorname(vendorname);
            if (SearchbyvendornameFound != null)
            {
                Console.WriteLine(SearchbyvendornameFound);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }


        public static void Showwallet()
        {
            CanteenDAO dao = new CanteenDAO();
            List<Canteen.Entities.Wallet> walletList = dao.Showwallet();

            foreach (Canteen.Entities.Wallet w in walletList)
            {
                Console.WriteLine(w);
            }
        }



        public static void Walletsearch()
        {
            CanteenDAO dao = new CanteenDAO();
            string walletid;
            Console.WriteLine("Enter walletid :   ");
            walletid = Console.ReadLine();
            Canteen.Entities.Wallet walletFound = dao.Walletsearch(walletid);
            if (walletFound != null)
            {
                Console.WriteLine(walletFound);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
        public static void showwalletbycustomerid()
        {
            
            string customerid;
            Console.WriteLine("Enter customerid :   ");
            customerid = Console.ReadLine();
            CanteenDAO dao = new CanteenDAO();
            List< Canteen.Entities.Wallet> walletlist = dao.showwalletbycustomerid(customerid);

            foreach (Canteen.Entities.Wallet w in walletlist)
            {
                Console.WriteLine(w);
            }
        }

        public static void Searchbycustomername()
        {
            CanteenDAO dao = new CanteenDAO();
            string customername;
            Console.WriteLine("Enter customername :   ");
            customername = Console.ReadLine();
            Canteen.Entities.Customer SearchbycustomernameFound = dao.Searchbycustomername(customername);
            if (SearchbycustomernameFound != null)
            {
                Console.WriteLine(SearchbycustomernameFound);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
        public static void Showwalletbywalletid()
        {
            CanteenDAO dao = new CanteenDAO();
            string walletid;
            Console.WriteLine("Enter walletid :   ");
            walletid = Console.ReadLine();
            List<Canteen.Entities.Wallet> walletlist = dao.Showwalletbywalletid(walletid);
            foreach (Canteen.Entities.Wallet w in walletlist)
            {
                Console.WriteLine(w);
            }
        }
        public static void Showmenubyrestaurantid()
        {
            string restaurantid;
            Console.WriteLine("Enter restaurantid");
            restaurantid = Console.ReadLine();
            CanteenDAO dao = new CanteenDAO();
            List<Canteen.Entities.Menu> menulist = dao.Showmenubyrestaurantid(restaurantid);

            foreach (Canteen.Entities.Menu m in menulist)
            {
                Console.WriteLine(m);
            }
        }
        public static void CustomerAuthenticationDAO()
        {
            string customerusername, customerpassword;
            Console.WriteLine("Enter customerusername   ");
            customerusername = Console.ReadLine();
            Console.WriteLine("Enter customerpassword   ");
            customerpassword = Console.ReadLine();
            CanteenDAO dao = new CanteenDAO();
            dao.CustomerAuthenticationDAO(customerusername, customerpassword);
        }
        public static void VendorAuthenticationDAO()
        {
            string vendorusername, vendorpassword;
            Console.WriteLine("Enter vendorusername   ");
            vendorusername = Console.ReadLine();
            Console.WriteLine("Enter vendorpassword   ");
            vendorpassword = Console.ReadLine();
            CanteenDAO dao = new CanteenDAO();
            dao.VendorAuthenticationDAO(vendorusername, vendorpassword);
        }




        public static void Showmenubymenuid()
        {
            string menuid;
            Console.WriteLine("Enter menuid");
            menuid = Console.ReadLine();
            CanteenDAO dao = new CanteenDAO();
            List<Canteen.Entities.Menu> menulist = dao.Showmenubymenuid(menuid);

            foreach (Canteen.Entities.Menu m in menulist)
            {
                Console.WriteLine(m);
            }
        }
        public static void AcceptOrReject()
        {
            

            CanteenDAO obj = new CanteenDAO();
            
            Console.WriteLine("enter order id");
            int Orderid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter vendor id");
            string vendorid = Console.ReadLine();
            Console.WriteLine("enter status");
            String status = Console.ReadLine();
            Console.WriteLine(obj.AcceptOrRejectOrder(Orderid, vendorid, status));
        }


        public static void placeorder()
        {
            
            
                Orderdetails orderDetails = new Orderdetails();
                
                
                Console.WriteLine("enter customer id");
                orderDetails.customerid = Console.ReadLine();
                Console.WriteLine("enter vendor id");
                orderDetails.vendorid = Console.ReadLine();
                Console.WriteLine("enter menu id");
                orderDetails.menuid = Console.ReadLine();
                Console.WriteLine("enter wallet id");
                orderDetails.walletid = Console.ReadLine();
                Console.WriteLine("enter order quantity");
                orderDetails.qtyord = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enetr order date");
                orderDetails.orderDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("enter order comments");
                orderDetails.orderComments = Console.ReadLine();

                CanteenDAO dao = new CanteenDAO();
                Console.WriteLine(dao.placeOrder(orderDetails));



        }

        public static void CustomerPendingOrders()
        {
            Console.WriteLine("enter customer id....");
            string customerid = Console.ReadLine();
            CanteenDAO dao = new CanteenDAO();
            List<Orderdetails> customerOrders = dao.CustomerPendingOrders(customerid);
            foreach (Orderdetails customerOrder in customerOrders)
            {
                Console.WriteLine(customerOrder);
            }

        }


        public static void VendorPendingOrders()
        {
            Console.WriteLine("enter vendor id....");
            string vendorid = Console.ReadLine();
            CanteenDAO dao = new CanteenDAO();
            List<Orderdetails> vendorsOrders = dao.VendorpendingOrders(vendorid);
            foreach (Orderdetails vendorOrder in vendorsOrders)
            {
                Console.WriteLine(vendorOrder);
            }

        }
        public static void customerorders()
         {
            Console.WriteLine("enter customer id....");
            string customerId = Console.ReadLine();
        CanteenDAO obj = new CanteenDAO();
        List<Orderdetails> customerOrders = obj.CustomerOrders(customerId);
            foreach(Orderdetails customerOrder in customerOrders)
            {
                Console.WriteLine(customerOrder);
            }

           }

        public static void vendororders()
        {
            Console.WriteLine("enter vendor id....");
            string vendorId = Console.ReadLine();
            CanteenDAO obj = new CanteenDAO();
            List<Orderdetails> vendorOrders = obj.VendorOrders(vendorId);
            foreach (Orderdetails vendorOrder in vendorOrders)
            {
                Console.WriteLine(vendorOrder);
            }

        }




        public static void Orderdetails()
        {
            Orderdetails orderDetails = new Orderdetails();
            Console.WriteLine("enter order id");
            orderDetails.orderid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer id");
            orderDetails.customerid = Console.ReadLine();
            Console.WriteLine("enter vendor id");
            orderDetails.vendorid = Console.ReadLine();
            Console.WriteLine("enter menu id");
            orderDetails.menuid = Console.ReadLine();
            Console.WriteLine("enter wallet id");
            orderDetails.walletid = Console.ReadLine();
            Console.WriteLine("enter order quantity");
            orderDetails.qtyord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr order date");
            orderDetails.orderDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter order comments");
            orderDetails.orderComments = Console.ReadLine();

            CanteenDAO dao = new CanteenDAO();
            Console.WriteLine(dao.placeOrder(orderDetails));
        }
    
            static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("O P T I O N S");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Show restaurant");
                Console.WriteLine("2. Search restaurant");
                Console.WriteLine("3. Show customer");
                Console.WriteLine("4. Search customer");
                Console.WriteLine("5. Show menu");
                Console.WriteLine("6. Search menu");
                Console.WriteLine("7. Show vendor");
                Console.WriteLine("8. Search vendor");
                Console.WriteLine("9. Showwalletbycustomerid");
                Console.WriteLine("10. Showwalletbywalletid");
                Console.WriteLine("11. Showmenubyrestaurantid");
                Console.WriteLine("12. CustomerAuth");
                Console.WriteLine("13. VendorAuth");
                Console.WriteLine("14. Searchby customername");
                Console.WriteLine("15. Show wallet");
                Console.WriteLine("16. Walletsearch");
                Console.WriteLine("17. OrderDetails");
                Console.WriteLine("18. Search by vendor name");
                Console.WriteLine("19 AcceptOrReject");
                Console.WriteLine("20 Showmenubymenuid ");
                Console.WriteLine("21 placeorder");
                Console.WriteLine("22 customerorders");
                Console.WriteLine("23 customerpendingorders");
                Console.WriteLine("24 vendorpendingorders");
                Console.WriteLine("25 vendororders");
                Console.WriteLine("Enter Your Choice   ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Showrest();
                        break;
                    case 2:
                        Searchrest();
                        break;
                    case 3:
                        Showcust();
                        break;
                    case 4:
                        Searchcust();
                        break;
                    case 5:
                        Showmenu();
                        break;
                    case 6:
                        Searchmenu();
                        break;
                    case 7:
                        Showvendor();
                        break;
                    case 8:
                        Searchvendor();
                        break;
                    case 9:
                        showwalletbycustomerid();
                        break;
                    case 10:
                        Showwalletbywalletid();
                        break;
                    case 11:
                        Showmenubyrestaurantid();
                        break;
                    case 12:
                        CustomerAuthenticationDAO();
                        break;
                    case 13:
                        VendorAuthenticationDAO();
                        break;
                    case 14:
                        Searchbycustomername();
                        break;
                    case 15:
                        Showmenu();
                        break;

                    case 16:
                        Walletsearch();
                        break;

                    case 17:
                        Orderdetails();
                        
                        break;

                    case 18:
                        Searchbyvendorname();
                        break;
                        

                    case 19:
                   AcceptOrReject();
                        break;


                    case 20:

                        placeorder();
                        break;

                    case 21:
                        Showmenubymenuid();
                            break;
                    case 22:
                        customerorders();
                        break;
                    case 23:
                        CustomerPendingOrders();
                        break;

                    case 24:
                        VendorPendingOrders();
                        break;
                    case 25:
                        vendororders();
                        break;

                    case 26:
                        return;
                }
            } while (choice != 25);
        }
    }
}
