using System;

namespace EventApplication
{
    public interface IHandleCommands<in TCommand> where TCommand : ICommand
    {

        //void Handle(ICommandHandlingContext<TCommand> handlingContext);

    }
}