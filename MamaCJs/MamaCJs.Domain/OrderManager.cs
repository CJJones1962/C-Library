﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaCJs.Domain
{
    public class OrderManager
    {
        public static void CreateOrder()
        {
            Persistance.OrderRepository.CreateOrder();
        }
    }
}
