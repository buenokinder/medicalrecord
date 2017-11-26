namespace Docway.MedicalRecords.Domain.Core.Bus
{
    using System.Threading.Tasks;
    using Docway.MedicalRecords.Domain.Core.Commands;
    using Docway.MedicalRecords.Domain.Core.Events;

    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}