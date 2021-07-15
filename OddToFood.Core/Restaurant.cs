using System;
using System.Collections.Generic;
using System.Text;

namespace OddToFood.Core
{
    public partial class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Kitchen KitchenType { get; set; }
    }
}
