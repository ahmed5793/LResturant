using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Restuarnt.DAL;


namespace Restuarnt.BL
{
    class Order
    {
        internal DataTable AddOrder( int IdClient, DateTime Date, decimal deliveryService ,decimal total, decimal pay, decimal rent,decimal discont,string Statues)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];



           
            param[0] = new SqlParameter("@IdClient", SqlDbType.Int);
            param[0].Value = IdClient;


            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;
        
            param[2] = new SqlParameter("@DeliveryService", SqlDbType.Decimal);
            param[2].Value = deliveryService;

            param[3] = new SqlParameter("@Total", SqlDbType.Decimal);
            param[3].Value = total;
            param[4] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[4].Value = pay;
            param[5] = new SqlParameter("@Rent", SqlDbType.Decimal);
            param[5].Value = rent;
            param[6] = new SqlParameter("@discount", SqlDbType.Decimal);
            param[6].Value = discont;
            param[7] = new SqlParameter("@Statues", SqlDbType.NVarChar,50);
            param[7].Value = Statues;


          dt=  da.selected("AddOrder", param);
            da.close();
            return dt;

        }
     
        
        internal void AddOrderDetails(int idItem, decimal prise, int Quantity, int IdOrder,decimal totalPrise)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];



            param[0] = new SqlParameter("@ID_Items", SqlDbType.Int);
            param[0].Value = idItem;


            param[1] = new SqlParameter("@Prise", SqlDbType.Decimal);
            param[1].Value = prise;
            param[2] = new SqlParameter("@Quntity", SqlDbType.Int);
            param[2].Value = Quantity;
            param[3] = new SqlParameter("@IdOrder", SqlDbType.Int);
            param[3].Value = IdOrder;
            param[4] = new SqlParameter("@TotalPrise", SqlDbType.Decimal);
            param[4].Value = totalPrise;
         





            da.excutequery("AddOrderDetails", param);
            da.close();

        }

        internal void AddOrderNewRow(int idItem, decimal prise, int Quantity, int IdOrder, decimal totalPrise)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];



            param[0] = new SqlParameter("@ID_Items", SqlDbType.Int);
            param[0].Value = idItem;


            param[1] = new SqlParameter("@Prise", SqlDbType.Decimal);
            param[1].Value = prise;
            param[2] = new SqlParameter("@Quntity", SqlDbType.Int);
            param[2].Value = Quantity;
            param[3] = new SqlParameter("@IdOrder", SqlDbType.Int);
            param[3].Value = IdOrder;
            param[4] = new SqlParameter("@TotalPrise", SqlDbType.Decimal);
            param[4].Value = totalPrise;
       




            da.excutequery("AddOrderNewRow", param);
            da.close();

        }




        
        internal void UpdateNewOrder(int IdOrder, int idItem,decimal prise,int quantity)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@IdOrder", SqlDbType.Int);
            param[0].Value = IdOrder;

            param[1] = new SqlParameter("@iditem", SqlDbType.Int);
            param[1].Value = idItem;


            param[2] = new SqlParameter("@Prise", SqlDbType.Decimal);
            param[2].Value = prise;
            param[3] = new SqlParameter("@quantity", SqlDbType.Int);
            param[3].Value = quantity;






            da.excutequery("UpdateNewOrder", param);
            da.close();

        }
   

        internal void UpdateOrderDetails(int idItem, decimal prise, int Quantity, int IdOrder, decimal totalPrise)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];



            param[0] = new SqlParameter("@ID_Items", SqlDbType.Int);
            param[0].Value = idItem;


            param[1] = new SqlParameter("@Prise", SqlDbType.Decimal);
            param[1].Value = prise;
            param[2] = new SqlParameter("@Quntity", SqlDbType.Int);
            param[2].Value = Quantity;
            param[3] = new SqlParameter("@IdOrder", SqlDbType.Int);
            param[3].Value = IdOrder;
            param[4] = new SqlParameter("@TotalPrise", SqlDbType.Decimal);
            param[4].Value = totalPrise;





            da.excutequery("UpdateOrderDetails", param);
            da.close();

        }
      
        internal void UpdateOrder(int IdOrder,decimal deliveryService,decimal total, decimal pay, decimal rent,decimal discount)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@IdOrder", SqlDbType.Int);
            param[0].Value = IdOrder;
            param[1] = new SqlParameter("@DeliveryService", SqlDbType.Decimal);
            param[1].Value = deliveryService;
            param[2] = new SqlParameter("@Total", SqlDbType.Decimal);
            param[2].Value = total;
            param[3] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[3].Value = pay;
            param[4] = new SqlParameter("@Rent", SqlDbType.Decimal);
            param[4].Value = rent;
            param[5] = new SqlParameter("@Discount", SqlDbType.Decimal);
            param[5].Value = discount;
            da.excutequery("UpdateOrder", param);
            da.close();

        }
        

        internal void AddTakeAway(int idOrder)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idOrder", SqlDbType.Int);
            param[0].Value = idOrder;

            


            da.excutequery("AddTakeAway", param);
            da.close();
        }
        internal void Delete_ProdFromOrderDetails(int idOrder)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdOrder", SqlDbType.Int);
            param[0].Value = idOrder;

           


            da.excutequery("Delete_ProdFromOrderDetails", param);
            da.close();
        }
        internal void AddSala(int idOrder,int idTable,int ID_Stuff)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idOrder", SqlDbType.Int);
            param[0].Value = idOrder;
            param[1] = new SqlParameter("@idTable", SqlDbType.Int);
            param[1].Value = idTable;
            param[2] = new SqlParameter("@idStuff", SqlDbType.Int);
            param[2].Value = ID_Stuff;




            da.excutequery("AddSala", param);
            da.close();
        }
        internal void AddDelivery(int idOrder, int idDelivery)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idOrder", SqlDbType.Int);
            param[0].Value = idOrder;
            param[1] = new SqlParameter("@idDelivery", SqlDbType.Int);
            param[1].Value = idDelivery;




            da.excutequery("AddDelivery", param);
            da.close();
        }
        internal DataTable SelectCtegoryOrder(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SelectCtegoryOrder", param);
            da.close();
            return dt;
        }
        internal DataTable LasIdOrder()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
         

            dt = da.selected("LasIdOrder", null);
            da.close();
            return dt;
        }
        internal DataTable SELECTOrder(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Order", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SELECTOrder", param);
            da.close(); 
            return dt;
        }
        internal DataTable SELECTOrderDetails(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Order", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SELECTOrderDetails", param);
            da.close();
            return dt;
        }
        internal DataTable SELECTOrderRent()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();


            dt = da.selected("SELECTOrderRent", null);
            da.close();
            return dt;
        }
     
        internal DataTable SELECTOrderRentSala()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();


            dt = da.selected("SELECTOrderRentSala", null);
            da.close();
            return dt;
        }

        internal DataTable SELECTOrderRentALLORDER()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();


            dt = da.selected("SELECTOrderRentALLORDER", null);
            da.close();
            return dt;
        }

        internal DataTable SELECTSala(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Order", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SELECTSala", param);
            da.close();
            return dt;
        }
        internal DataTable SELECTDelivery(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Order", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SELECTDelivery", param);
            da.close();
            return dt;
        }
        internal DataTable SELECTTakeAway(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Order", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SELECTTakeAway", param);
            da.close();
            return dt;
        }
        internal DataTable VildateOrderDetails(int idorder, int iditem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idorder;
            param[1] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[1].Value = iditem;
          

            dt = da.selected("VildateOrderDetails", param);
            da.close();
            return dt;
        }
        internal DataTable VildateNewOrder(int idorder, int iditem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idorder;
            param[1] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[1].Value = iditem;


            dt = da.selected("VildateNewOrder", param);
            da.close();
            return dt;
        }
        internal DataTable txtvidlatequantity(int idorder, int iditem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idorder;
            param[1] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[1].Value = iditem;


            dt = da.selected("txtvidlatequantity", param);
            da.close();
            return dt;
        }
        internal DataTable VildateQuantity(int idorder, int iditem,int quantity)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idorder;
            param[1] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[1].Value = iditem;
            param[2] = new SqlParameter("@quantity", SqlDbType.Int);
            param[2].Value = quantity;


            dt = da.selected("VildateQuantity", param);
            da.close();
            return dt;
        }
        internal DataTable SELECTOrderSala(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Order", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SELECTOrderSala", param);
            da.close();
            return dt;
        }
        internal DataTable SELECTOrderRentTkeAway()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
        
          

            dt = da.selected("SELECTOrderRentTkeAway", null);
            da.close();
            return dt;
        }
        internal DataTable SELECTOrderTakwAway(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Order", SqlDbType.Int);
            param[0].Value = id;



            dt = da.selected("SELECTOrderTakwAway", param);
            da.close();
            return dt;
        }
        internal DataTable PritOrderNewRow(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;



            dt = da.selected("PritOrderNewRow", param);
            da.close();
            return dt;
        }
        internal DataTable validatePritOrderNewRow(int id)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("validatePritOrderNewRow", param);
            da.close();
            return dt;
        }
        internal void DeleteOrderItems(int idOrder,int idItems)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idOrder;
            param[1] = new SqlParameter("@idItem", SqlDbType.Int);
            param[1].Value = idItems;




            da.excutequery("DeleteOrderItems", param);
            da.close();
        }
        internal void DeleteOrder(int idOrder)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idOrder;
       




            da.excutequery("DeleteOrder", param);
            da.close();
        }
        internal void DeleteOrderNewRow()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
         





            da.excutequery("DeleteOrderNewRow", null);
            da.close();
        }
        internal DataTable SELECTManagmentOrderTakwAway()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();



            dt = da.selected("SELECTManagmentOrderTakwAway", null);
            da.close();
            return dt;
        }
        internal DataTable SelectMangmentOrders()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();



            dt = da.selected("SelectMangmentOrders", null);
            da.close();
            return dt;
        }
        internal DataTable SELECTManagmentOrderSala()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();



            dt = da.selected("SELECTManagmentOrderSala", null);
            da.close();
            return dt;
        }
        internal DataTable SELECManamentTOrderDelivery()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();



            dt = da.selected("SELECManamentTOrderDelivery", null);
            da.close();
            return dt;
        }
        internal DataTable SearchMangmentOrders(DateTime FromDate, DateTime ToDate )
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            param[0].Value = FromDate;

            param[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            param[1].Value = ToDate;
        
            dt = da.selected("SearchMangmentOrders", param);
            da.close();
            return dt;
        }
        internal DataTable SearchManamentTOrderDelivery(DateTime FROMTime, DateTime ToTime)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            param[0].Value = FROMTime;
            param[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            param[1].Value = ToTime;
            dt = da.selected("SearchManamentTOrderDelivery", param);
            da.close();
            return dt;
        }
        internal DataTable SearchManagmentOrderSala(DateTime FROMTime, DateTime ToTime)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            param[0].Value = FROMTime;
            param[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            param[1].Value = ToTime;
            dt = da.selected("SearchManagmentOrderSala", param);
            da.close();
            return dt;
        }
        internal DataTable SearchManagmentOrderTakwAway(DateTime FROMTime, DateTime ToTime)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            param[0].Value = FROMTime;
            param[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            param[1].Value = ToTime;
            dt = da.selected("SearchManagmentOrderTakwAway", param);
            da.close();
            return dt;
        }
        internal DataTable SelecthMovedItems()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();



            dt = da.selected("SelecthMovedItems", null);
            da.close();
            return dt;
        }
        internal DataTable SearchMovedItems(DateTime Datefrom ,DateTime DateTo )
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@DateFrom", SqlDbType.DateTime);
            param[0].Value = Datefrom;

            param[1] = new SqlParameter("@DateTo", SqlDbType.DateTime);
            param[1].Value = DateTo;

            dt = da.selected("SearchMovedItems", param);
            da.close();
            return dt;
        }


        internal void deleteAllOrder()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
       





            da.excutequery("deleteAllOrder", null);
            da.close();
        }


        internal DataTable ReportOrderDepartment(string Department, DateTime fromDte, DateTime todate)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Department", SqlDbType.NVarChar, 50);
            param[0].Value = Department;



            param[1] = new SqlParameter("@fromDte", SqlDbType.DateTime);
            param[1].Value = fromDte;
            param[2] = new SqlParameter("@todate", SqlDbType.DateTime);
            param[2].Value = todate;


          dt=  da.selected("ReportOrderDepartment", param);
            da.close();
            return dt;
        }
    }
}
