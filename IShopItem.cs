﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi
{
    interface IShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
