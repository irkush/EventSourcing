using System;

namespace EventApplication
{
    class AuditEvent
    {
        public Guid Id { get; set; }
        public Guid SystemId { get; set; }

        public string Name { get; set; }

        public DateTime Timestamp { get; set; }

        public override string ToString()
        {
            return $"{Name} with Id {Id}";
        }
    }
}