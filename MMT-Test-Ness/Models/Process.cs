using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MMT_Test_Ness.Models
{
    public class PRODUCTS
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

    public class ORDERS
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

    public class ORDERITEMS
    {
        [Key]
        public int ORDERITEMID { get; set; }
        public int ORDERID { get; set; }
        public int PRODUCTID { get; set; }

        public int QUANTITY { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal PRICE { get; set; }
    }
}
