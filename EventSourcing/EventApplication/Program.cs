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

                Console.ReadLine();
            }
        }
    }
}
