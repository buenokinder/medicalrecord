namespace Docway.MedicalRecords.Domain.Core.Events
{
    using System;
    using MediatR;

    public abstract class Message : INotification
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
