using MMT_Test_Ness.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MMT_Test_Ness.Dto
{


    public class ClientQueryDto
    {
        public string user { get; set; }
        public string customerId { get; set; }
    }

    public class GetOrderDto
    {
        public int user { get; set; }
        public string customerId { get; set; }
    }

    public class CUSTOMERDTO
    {
        public string email { get; set; }
        public string customerId { get; set; }
        public bool website { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime lastLoggedIn { get; set; }
        public string houseNumber { get; set; }
        public string street { get; set; }
        public string town { get; set; }
        public string postcode { get; set; }
        public string preferredLanguage { get; set; }
    }


public class PRODUCTSDTO
    {
        [Key]
        public int PRODUCTID { get; set; }
        public string PRODUCTNAME { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal PACKHEIGHT { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal PACKWIDTH { get; set; }
        [Column(TypeName = "decimal(8,3)")]
        public decimal PACKWEIGHT { get; set; }
        public string COLOUR { get; set; }
        public string SIZE { get; set; }
    }

    public class ORDERSDTO
    {
        [Key]
        public int ORDERID { get; set; }
        public string CUSTOMERID { get; set; }
        public DateTime ORDERDATE { get; set; }
        public DateTime DELIVERYEXPECTED { get; set; }
        public bool CONTAINSGIFT { get; set; }
        public string SHIPPINGMODE { get; set; }
        public string ORDERSOURCE { get; set; }
    }

    public class ORDERITEMSDTO
    {
        [Key]
        public int ORDERITEMID { get; set; }
        public int ORDERID { get; set; }
        public int PRODUCTID { get; set; }
        public int QUANTITY { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal PRICE { get; set; }
    }

    public class customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class OrderReturnDto
    {
        public int OrderNumber { get; set; }
        public DateTime ORDERDATE { get; set; }
        public string DELIVERYADDRESS { get; set; }
        public ICollection<orderItems> orderItems { get; set; }
        public DateTime DELIVERYEXPECTED { get; set; }
    }

    public class orderItems
    {
        public int ID { get; set; }
        //public virtual PRODUCTSDTO PRODUCTRecord { get; set; }
        //public string product
        //{
        //    get
        //    {
        //        return PRODUCTRecord.PRODUCTNAME;
        //    }
        //}
        public int QUANTITY { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal PRICE { get; set; }
    }
}
