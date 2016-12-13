using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventApplication.Api;

namespace EventApplication
{
    public interface ICommandHandlingContext<out TCommand> where TCommand : ICommand
    {

        TCommand Command { get; }

        void Return(int value);

    }
}
