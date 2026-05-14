using PensilShop.Forms;
using PensilShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensilShop.Services
{
    internal class ContextManager
    {
        public static User User { get; set; }
        public static ProductForm ProductForm { get; set; }

        public static OrderForm OrderForm { get; set; }
    }
}
