﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DTO
{
    class Food
    {
        public int idFood { get; set; }
        public string name { get; set; }
        public int category { get; set; }  // 0 drink 1 food
        public long  price { get; set; }
        public string description { get; set; }
        public int discount { get; set; }
        public int quantity { get; set; }
        public string image { get; set; }
    }
}