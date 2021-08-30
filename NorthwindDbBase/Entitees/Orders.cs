using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDbBase.Entitees
{
   public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        
    }
}
