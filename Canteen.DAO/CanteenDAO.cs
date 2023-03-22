using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Canteen.Entities;
using System.Data.SqlClient;

using System.Threading.Tasks;

namespace Canteen.DAO
{

    public class CanteenDAO
    {
        SqlConnection conn;
        SqlDataAdapter ad;



        public List<Canteen.Entities.Restaurant> Showrest()
        {

            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from restaurant", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "RestaurantDummy");
            List<Canteen.Entities.Restaurant> restList = new List<Canteen.Entities.Restaurant>();
            Canteen.Entities.Restaurant Restaurant = null;
            foreach (DataRow dr in ds.Tables["RestaurantDummy"].Rows)
            {
                Restaurant = new Canteen.Entities.Restaurant();

                Restaurant.restaurantid = dr["restaurantid"].ToString();
                Restaurant.restaurantname = dr["restaurantname"].ToString();
                Restaurant.location = dr["location"].ToString();
                Restaurant.rating = dr["rating"].ToString();

                restList.Add(Restaurant);
            }
            return restList;
        }
        public Canteen.Entities.Restaurant Searchrest(string restaurantid)
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from restaurant where restaurantid=@restaurantid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@restaurantid", restaurantid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "RestDummy");
            Canteen.Entities.Restaurant rest = null;
            int count = ds.Tables["RestDummy"].Rows.Count;
            if (count == 1)
            {
                rest = new Canteen.Entities.Restaurant();
                DataRow dr = ds.Tables["RestDummy"].Rows[0];
                rest.restaurantid = dr["restaurantid"].ToString();
                rest.restaurantname = dr["restaurantname"].ToString();
                rest.location = dr["location"].ToString();
                rest.rating = dr["rating"].ToString();


            }
            return rest;


        }
        public List<Canteen.Entities.Customer> Showcust()
        {

            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from customer", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "CustomerDummy");
            List<Canteen.Entities.Customer> custList = new List<Canteen.Entities.Customer>();
            Canteen.Entities.Customer cust = null;
            foreach (DataRow dr in ds.Tables["CustomerDummy"].Rows)
            {
                cust = new Canteen.Entities.Customer();

                cust.customerid = dr["customerid"].ToString();
                cust.customername = dr["customername"].ToString();
                cust.customerusername = dr["customerusername"].ToString();
                cust.customerpassword = dr["customerpassword"].ToString();
                cust.customercity = dr["customercity"].ToString();
                cust.customerstate = dr["customerstate"].ToString();


                custList.Add(cust);
            }
            return custList;
        }
        public Canteen.Entities.Customer Searchcust(string customerid)
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from customer where customerid=@customerid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@customerid", customerid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "CustDummy");
            Canteen.Entities.Customer cust = null;
            int count = ds.Tables["CustDummy"].Rows.Count;
            if (count == 1)
            {
                cust = new Canteen.Entities.Customer();
                DataRow dr = ds.Tables["CustDummy"].Rows[0];
                cust.customerid = dr["customerid"].ToString();
                cust.customername = dr["customername"].ToString();
                cust.customerusername = dr["customerusername"].ToString();
                cust.customerpassword = dr["customerpassword"].ToString();
                cust.customercity = dr["customercity"].ToString();
                cust.customerstate = dr["customerstate"].ToString();


            }
            return cust;


        }



        public Customer Searchbycustomername(string customername)
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from customer where customerusername=@customerid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@customerid", customername);
            DataSet ds = new DataSet();
            ad.Fill(ds, "customerDummy");
            int count = ds.Tables["customerDummy"].Rows.Count;
            Customer cust = null;
            if (count == 1)
            {
                cust = new Customer();
                DataRow dr = ds.Tables["customerDummy"].Rows[0];

                cust.customerid = dr["customerid"].ToString();
                cust.customername = dr["customername"].ToString();
                cust.customerusername = dr["customerusername"].ToString();
                cust.customerpassword = dr["customerpassword"].ToString();

                cust.customercity = dr["customercity"].ToString();

                cust.customerstate = dr["customerstate"].ToString();
            }
            return cust;
        }
        public List<Canteen.Entities.Menu> Showmenu()
        {

            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from menu", conn);

            DataSet ds = new DataSet();
            ad.Fill(ds, "MenuDummy");
            List<Canteen.Entities.Menu> menuList = new List<Canteen.Entities.Menu>();
            Canteen.Entities.Menu menu = null;
            foreach (DataRow dr in ds.Tables["MenuDummy"].Rows)
            {
                menu = new Canteen.Entities.Menu();

                menu.menuid = dr["menuid"].ToString();
                menu.restaurantid = dr["restaurantid"].ToString();
                menu.itemname = dr["itemname"].ToString();
                menu.price = Convert.ToInt32(dr["price"]);
                menu.description = dr["description"].ToString();



                menuList.Add(menu);
            }
            return menuList;
        }
        public Canteen.Entities.Menu Searchmenu(string menuid)
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from menu where menuid=@menuid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@menuid", menuid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "MenuDummy");
            Canteen.Entities.Menu menu = null;
            int count = ds.Tables["MenuDummy"].Rows.Count;
            if (count == 1)
            {
                menu = new Canteen.Entities.Menu();
                DataRow dr = ds.Tables["MenuDummy"].Rows[0];
                menu.menuid = dr["menuid"].ToString();
                menu.restaurantid = dr["restaurantid"].ToString();
                menu.itemname = dr["itemname"].ToString();
                menu.price = Convert.ToInt32(dr["price"]);
                menu.description = dr["description"].ToString();



            }
            return menu;


        }
        public List<Canteen.Entities.Vendor> Showvendor()
        {

            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from vendor", conn);

            DataSet ds = new DataSet();
            ad.Fill(ds, "VendorDummy");
            List<Canteen.Entities.Vendor> vendorList = new List<Canteen.Entities.Vendor>();
            Canteen.Entities.Vendor vendor = null;
            foreach (DataRow dr in ds.Tables["VendorDummy"].Rows)
            {
                vendor = new Canteen.Entities.Vendor();

                vendor.vendorid = dr["vendorid"].ToString();
                vendor.vendorname = dr["vendorname"].ToString();
                vendor.vendorusername = dr["vendorusername"].ToString();
                vendor.vendorpassword = dr["vendorpassword"].ToString();
                vendor.vendorcity = dr["vendorcity"].ToString();
                vendor.vendorstate = dr["vendorstate"].ToString();




                vendorList.Add(vendor);
            }
            return vendorList;
        }
        public Canteen.Entities.Vendor Searchvendor(string vendorid)
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from vendor where vendorid=@vendorid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@vendorid", vendorid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "VendorDummy");
            Canteen.Entities.Vendor vendor = null;
            int count = ds.Tables["VendorDummy"].Rows.Count;
            if (count == 1)
            {
                vendor = new Canteen.Entities.Vendor();
                DataRow dr = ds.Tables["VendorDummy"].Rows[0];
                vendor.vendorid = dr["vendorid"].ToString();
                vendor.vendorname = dr["vendorname"].ToString();
                vendor.vendorusername = dr["vendorusername"].ToString();
                vendor.vendorpassword = dr["vendorpassword"].ToString();
                vendor.vendorcity = dr["vendorcity"].ToString();
                vendor.vendorstate = dr["vendorstate"].ToString();
            }
            return vendor;
        }



        public Vendor Searchbyvendorname(string vendorname)
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from vendor where vendorusername=@vendorid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@vendorid", vendorname);
            DataSet ds = new DataSet();
            ad.Fill(ds, "vendorDummy");
            int count = ds.Tables["vendorDummy"].Rows.Count;
            Vendor vend = null;
            if (count == 1)
            {
                vend = new Vendor();
                DataRow dr = ds.Tables["vendorDummy"].Rows[0];

                vend.vendorid = dr["vendorid"].ToString();
                vend.vendorname = dr["vendorname"].ToString();
                vend.vendorusername = dr["vendorusername"].ToString();
                vend.vendorpassword = dr["vendorpassword"].ToString();

                vend.vendorcity = dr["vendorcity"].ToString();

                vend.vendorstate = dr["vendorstate"].ToString();
            }
            return vend;
        }

        public List<Canteen.Entities.Wallet> Showwallet()
        {

            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from wallet", conn);

            DataSet ds = new DataSet();
            ad.Fill(ds, "WalletDummy");
            List<Canteen.Entities.Wallet> walletList = new List<Canteen.Entities.Wallet>();
            Canteen.Entities.Wallet wallet = null;
            foreach (DataRow dr in ds.Tables["WalletDummy"].Rows)
            {
                wallet = new Canteen.Entities.Wallet();

                wallet.walletid = dr["walletid"].ToString();
                wallet.customerid = dr["customerid"].ToString();
                wallet.wallettype = dr["wallettype"].ToString();
                wallet.walletamount = Convert.ToInt32(dr["walletamount"]);




                walletList.Add(wallet);
            }
            return walletList;
        }
        public List<Wallet> showwalletbycustomerid(string customerid)
        {
            List<Wallet> walletlist = new List<Wallet>();
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from wallet where customerid=@customerid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@customerid", customerid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "WalletDummy");
            Canteen.Entities.Wallet wallet = null;
            foreach (DataRow dr in ds.Tables["WalletDummy"].Rows)
            {
                wallet = new Canteen.Entities.Wallet();
                wallet.walletid = dr["walletid"].ToString();
                wallet.customerid = dr["customerid"].ToString();
                wallet.wallettype = dr["wallettype"].ToString();
                wallet.walletamount = Convert.ToInt32(dr["walletamount"]);
                walletlist.Add(wallet);

            }

            return walletlist;
        }

        public List<Canteen.Entities.Wallet> Showwalletbywalletid(string walletid)
        {
            List<Wallet> walletlist = new List<Wallet>();
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from wallet where walletid=@walletid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@walletid", walletid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "WalletDummy");
            Canteen.Entities.Wallet wallet = null;
            foreach (DataRow dr in ds.Tables["WalletDummy"].Rows)
            {
                wallet = new Canteen.Entities.Wallet();

                wallet.walletid = dr["walletid"].ToString();
                wallet.customerid = dr["customerid"].ToString();
                wallet.wallettype = dr["wallettype"].ToString();
                wallet.walletamount = Convert.ToInt32(dr["walletamount"]);

                walletlist.Add(wallet);
            }
            return walletlist;
        }
        public List<Menu> Showmenubyrestaurantid(string restaurantid)
        {
            List<Menu> menulist = new List<Menu>();
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from menu where restaurantid=@restaurantid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@restaurantid", restaurantid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "MenuDummy");
            Canteen.Entities.Menu menu = null;

            foreach (DataRow dr in ds.Tables["MenuDummy"].Rows)
            {
                menu = new Canteen.Entities.Menu();

                menu.menuid = dr["menuid"].ToString();
                menu.restaurantid = dr["restaurantid"].ToString();
                menu.itemname = dr["itemname"].ToString();
                menu.price = Convert.ToInt32(dr["price"]);
                menu.description = dr["description"].ToString();

                menulist.Add(menu);

            }
            return menulist;


        }
        public int CustomerAuthenticationDAO(string customerusername, string customerpassword)
        {

            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select count(*) cnt from customer where customerusername=@customerusername AND " +
                " customerpassword=@customerpassword", conn);
            ad.SelectCommand.Parameters.AddWithValue("@customerusername", customerusername);
            ad.SelectCommand.Parameters.AddWithValue("@customerpassword", customerpassword);
            DataSet ds = new DataSet();
            ad.Fill(ds, "CustauthDummy");
            int count = Convert.ToInt32(ds.Tables["CustauthDummy"].Rows[0]["cnt"]);
            if (count == 1)
            {
                Console.WriteLine("Correct Credentials...");
            }
            else
            {
                Console.WriteLine("Invalid Credentials...");
            }
            return count;

        }



        public List<Menu> Showmenubymenuid(string menuid)
        {
            List<Menu> menulist = new List<Menu>();
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select * from menu where menuid=@menuid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@menuid", menuid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "MenuDummy");
            Canteen.Entities.Menu menu = null;

            foreach (DataRow dr in ds.Tables["MenuDummy"].Rows)
            {
                menu = new Canteen.Entities.Menu();

                menu.menuid = dr["menuid"].ToString();
                menu.restaurantid = dr["restaurantid"].ToString();
                menu.itemname = dr["itemname"].ToString();
                menu.price = Convert.ToInt32(dr["price"]);
                menu.description = dr["description"].ToString();

                menulist.Add(menu);

            }
            return menulist;


        }
        public int VendorAuthenticationDAO(string vendorusername, string vendorpassword)
        {

            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter("select count(*) cnt from vendor where vendorusername=@vendorusername AND " +
                " vendorpassword=@vendorpassword", conn);
            ad.SelectCommand.Parameters.AddWithValue("@vendorusername", vendorusername);
            ad.SelectCommand.Parameters.AddWithValue("@Vendorpassword", vendorpassword);
            DataSet ds = new DataSet();
            ad.Fill(ds, "vendorauthDummy");
            int count = Convert.ToInt32(ds.Tables["vendorauthDummy"].Rows[0]["cnt"]);
            if (count == 1)
            {
                Console.WriteLine("Correct Credentials...");
            }
            else
            {
                Console.WriteLine("Invalid Credentials...");
            }
            return count;

        }


        public Wallet Walletsearch(string walletid)
        {
            conn = ConnectionHelper.GetConnection();
            ad = new SqlDataAdapter(" select *from wallet where walletid=@wid", conn);
            ad.SelectCommand.Parameters.AddWithValue("@wid", walletid);
            DataSet ds = new DataSet();
            ad.Fill(ds, "walletDummy");
            int count = ds.Tables["walletDummy"].Rows.Count;
            Wallet wallet = null;
            if (count == 1)
            {
                wallet = new Wallet();
                DataRow dr = ds.Tables["walletDummy"].Rows[0];
                wallet.walletid = walletid;
                wallet.customerid = dr["customerid"].ToString();
                wallet.wallettype = dr["wallettype"].ToString();
                wallet.walletamount = Convert.ToInt32(dr["walletAmount"]);


            }
            return wallet;
        }

        public String placeOrder(Orderdetails orderDetails)
        {
            Menu mobj = Searchmenu(orderDetails.menuid);
            double price = mobj.price;
            orderDetails.billAmount = price * orderDetails.qtyord;
            Wallet wallet = Walletsearch(orderDetails.walletid);
            Console.WriteLine(orderDetails.billAmount);
            Console.WriteLine(wallet.walletamount);
            if (orderDetails.billAmount > wallet.walletamount)
            {
                return "Insufficient Funds";
            }


            conn = ConnectionHelper.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcPlaceOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@orderId", orderDetails.orderId);
            cmd.Parameters.AddWithValue("@customerId", orderDetails.customerid);
            cmd.Parameters.AddWithValue("@vendorId", orderDetails.vendorid);
            cmd.Parameters.AddWithValue("@menuId", orderDetails.menuid);
            cmd.Parameters.AddWithValue("@walletId", orderDetails.walletid);
            cmd.Parameters.AddWithValue("@qtyord", orderDetails.qtyord);
            cmd.Parameters.AddWithValue("@orderdate", orderDetails.orderDate);
            cmd.Parameters.AddWithValue("@billAmount", orderDetails.billAmount);
            cmd.Parameters.AddWithValue("@orderComments", orderDetails.orderComments);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("prcDeductAmount", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@WalletID", orderDetails.walletid);
            cmd.Parameters.AddWithValue("@billAmount", orderDetails.billAmount);
            cmd.ExecuteNonQuery();
            return "Order placed Sucessfully";


        }




        public Orderdetails SearchByOrderId(int orderId)
        {
            conn = ConnectionHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("prcOrderSearch", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderId", orderId);
            SqlDataReader dr = cmd.ExecuteReader();
            Orderdetails orderDetails = null;
            if (dr.Read())
            {
                orderDetails = new Orderdetails();
                orderDetails.orderid = Convert.ToInt32(dr["orderid"]);
                orderDetails.customerid = dr["customerid"].ToString();
                orderDetails.vendorid = dr["vendorid"].ToString();
                orderDetails.menuid = dr["menuid"].ToString();
                orderDetails.walletid = dr["walletid"].ToString();
                orderDetails.qtyord = Convert.ToInt32(dr["qtyord"]);
                orderDetails.orderStatus = dr["orderstatus"].ToString();
                orderDetails.orderDate = Convert.ToDateTime(dr["orderdate"]);
                orderDetails.billAmount = Convert.ToInt32(dr["billamount"]);
                orderDetails.orderComments = dr["ordercomments"].ToString();

            }
            return orderDetails;
        }



        public String AcceptOrRejectOrder(int Orderid, String vendorid, String status)
        {
            Orderdetails orderdetails = SearchByOrderId(Orderid);
            if (status.Equals("yes"))
            {
                if (vendorid == orderdetails.vendorid)
                {
                    CanteenDAO obj = new CanteenDAO();
                    orderdetails.vendorid = null;
                    conn = ConnectionHelper.GetConnection();
                    SqlCommand cmd = new SqlCommand("prcAcceptOrder", conn);
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orderID", Orderid);
                    cmd.ExecuteNonQuery();
                    return "order Accepted";

                }
                else
                {
                    return "you are unauthorised vendor";
                }

            }
            else
            {
                conn = ConnectionHelper.GetConnection();
                SqlCommand cmd = new SqlCommand("prcRejectOrder", conn);
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", Orderid);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("prcRefundAmount", conn);
                //conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@walletId", orderdetails.walletid);
                cmd.Parameters.AddWithValue("@walletAmount", orderdetails.billAmount);
                cmd.ExecuteNonQuery();

                return "order rejected and amount refunded";
            }
        }

        public List<Orderdetails> CustomerPendingOrders(string customerid)
        {
            conn = ConnectionHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("prcCustomerPendingOrders", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerid", customerid);
            SqlDataReader dr = cmd.ExecuteReader();
            Orderdetails orderDetails = null;
            List<Orderdetails> customerOrders = new List<Orderdetails>();
            while (dr.Read())
            {
                orderDetails = new Orderdetails();
                orderDetails.orderid = Convert.ToInt32(dr["orderid"]);
                orderDetails.customerid = dr["customerid"].ToString();
                orderDetails.vendorid = dr["vendorid"].ToString();
                orderDetails.menuid = dr["menuid"].ToString();
                orderDetails.walletid = dr["walletid"].ToString();
                orderDetails.qtyord = Convert.ToInt32(dr["qtyord"]);
                orderDetails.orderStatus = dr["Orderstatus"].ToString();
                orderDetails.orderDate = Convert.ToDateTime(dr["orderdate"]);
                orderDetails.billAmount = Convert.ToInt32(dr["billAmount"]);
                orderDetails.orderComments = dr["orderComments"].ToString();
                customerOrders.Add(orderDetails);

            }
            return customerOrders;


        }
        public List<Orderdetails> CustomerOrders(string customerId)
        {
            conn = ConnectionHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("prcCustomerOrders", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerId", customerId);
            SqlDataReader dr = cmd.ExecuteReader();
            Orderdetails orderDetails = null;
            List<Orderdetails> customerOrders = new List<Orderdetails>();
            while (dr.Read())
            {
                orderDetails = new Orderdetails();
                orderDetails.orderid = Convert.ToInt32(dr["orderid"]);
                orderDetails.customerid = dr["customerid"].ToString();
                orderDetails.vendorid = dr["vendorid"].ToString();
                orderDetails.menuid = dr["menuid"].ToString();
                orderDetails.walletid = dr["walletid"].ToString();
                orderDetails.qtyord = Convert.ToInt32(dr["qtyord"]);
                orderDetails.orderStatus = dr["orderstatus"].ToString();
                orderDetails.orderDate = Convert.ToDateTime(dr["orderdate"]);
                orderDetails.billAmount = Convert.ToInt32(dr["billamount"]);
                orderDetails.orderComments = dr["ordercomments"].ToString();
                customerOrders.Add(orderDetails);

            }
            return customerOrders;


        }


        public List<Orderdetails> VendorpendingOrders(string vendorId)
        {
            conn = ConnectionHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("prcVendorpendingOrders", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@vendorId", vendorId);
            SqlDataReader dr = cmd.ExecuteReader();
            Orderdetails orderDetails = null;
            List<Orderdetails> vendorOrders = new List<Orderdetails>();
            while (dr.Read())
            {
                orderDetails = new Orderdetails();
                orderDetails.orderid = Convert.ToInt32(dr["orderid"]);
                orderDetails.customerid = dr["customerid"].ToString();
                orderDetails.vendorid = dr["vendorid"].ToString();
                orderDetails.menuid = dr["menuid"].ToString();
                orderDetails.walletid = dr["walletid"].ToString();
                orderDetails.qtyord = Convert.ToInt32(dr["qtyord"]);
                orderDetails.orderStatus = dr["orderstatus"].ToString();
                orderDetails.orderDate = Convert.ToDateTime(dr["orderdate"]);
                orderDetails.billAmount = Convert.ToInt32(dr["billamount"]);
                orderDetails.orderComments = dr["ordercomments"].ToString();
                vendorOrders.Add(orderDetails);

            }
            return vendorOrders;


        }



        public List<Orderdetails> VendorOrders(string vendorId)
        {
            conn = ConnectionHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("prcVendorOrders", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@vendorId", vendorId);
            SqlDataReader dr = cmd.ExecuteReader();
            Orderdetails orderDetails = null;
            List<Orderdetails> vendorOrders = new List<Orderdetails>();
            while (dr.Read())
            {
                orderDetails = new Orderdetails();
                orderDetails.orderid = Convert.ToInt32(dr["orderid"]);
                orderDetails.customerid = dr["customerid"].ToString();
                orderDetails.vendorid = dr["vendorid"].ToString();
                orderDetails.menuid = dr["menuid"].ToString();
                orderDetails.walletid = dr["walletid"].ToString();
                orderDetails.qtyord = Convert.ToInt32(dr["qtyord"]);
                orderDetails.orderStatus = dr["orderstatus"].ToString();
                orderDetails.orderDate = Convert.ToDateTime(dr["orderdate"]);
                orderDetails.billAmount = Convert.ToInt32(dr["billamount"]);
                orderDetails.orderComments = dr["ordercomments"].ToString();
                vendorOrders.Add(orderDetails);

            }
            return vendorOrders;


        }
    }
    

}

















