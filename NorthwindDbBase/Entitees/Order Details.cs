using NorthwindDbBase.Entitees;

namespace NorthwindDbBase.Entitees
{
   public class Order_Details
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        //public Products Products{ get; set; }
        //public Orders Orders { get; set; }
    }
}
