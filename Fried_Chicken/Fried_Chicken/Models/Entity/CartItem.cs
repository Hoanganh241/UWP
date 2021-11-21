using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fried_Chicken.Models.Entity
{
    class CartItem //DAO pattern
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
