using System;
using EventApplication.Api;
namespace EventApplication
{
    public interface IHandleCommands<in TCommand> where TCommand : ICommand
    {
        void Handle(ICommandHandlingContext<TCommand> handlingContext);

    }
}