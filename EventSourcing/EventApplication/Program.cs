using System;
using System.Diagnostics;
using NEventStore;

namespace EventApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var auditEvent = new AuditEvent {Id = Guid.NewGuid(), Name = "My first message", SystemId = Guid.NewGuid()};
            var secondAuditEvent = new AuditEvent { Id = Guid.NewGuid(), Name = "My second message", SystemId = auditEvent.SystemId };


            var store = Wireup.Init().UsingInMemoryPersistence().LogToOutputWindow().Build();
            using (store)
            {
                using (var stream = store.CreateStream(auditEvent.SystemId))
                {
                    stream.Add(new EventMessage { Body = auditEvent });
                    stream.Add(new EventMessage { Body = secondAuditEvent });
                    stream.CommitChanges(auditEvent.Id);
                }

                using (var stream = store.OpenStream(auditEvent.SystemId, 0))
                {
                    foreach (var @event in stream.CommittedEvents)
                    {
                        Console.WriteLine(@event.Body);
                    }
                }

                


                // Order system


                // Create new Order
                // Add order row
                // Lower order row amount

                // Get current state.
                // Get audit events.
                // Collect snapshot of events.

                // Add order row
                // Get current state.
            }

            while (true)
            {
                Console.WriteLine("Enter your command: ");
                Console.WriteLine("1. Create new order");

                Console.WriteLine("E. Exit program.");


                var selection = Console.ReadKey();
                Console.WriteLine("You selected " + selection.KeyChar);
                if (selection.Key == ConsoleKey.E)
                {
                    Console.WriteLine("You exited");
                    break;
                }
            }
        }
    }
}
