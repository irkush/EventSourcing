using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApplication
{
    public class CreateOrderCommandHandler : CommandHandler<CreateOrderCommand>
    {
        //protected IDomainRepository _repository;

        //public CreateOrderCommandHandler(IDomainRepository repository)
        public CreateOrderCommandHandler()

        {
            //_repository = repository;
        }

        protected CreateOrderStatus ValidateCommand(CreateOrderCommand command)
        {
            return CreateOrderStatus.Successful;
        }
    }
}
