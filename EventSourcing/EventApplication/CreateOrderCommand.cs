using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventApplication.Api;

namespace EventApplication
{
    public class CreateOrderCommand : ICommand
    {
        public decimal Amount { get; set; }
        public string CustomerName { get; set; }

        public CreateOrderCommand(decimal amount, string customerName)
        {
            Amount = amount;
            CustomerName = customerName;
        }
    }
}
