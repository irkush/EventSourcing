using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApplication
{
    public class CreateOrderCommand
    {
        public decimal Amount { get; set; }

        public CreateOrderCommand(decimal amount)
        {
            Amount = amount;
        }
    }
}
