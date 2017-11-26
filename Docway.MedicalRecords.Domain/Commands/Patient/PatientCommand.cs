using System;
using Docway.MedicalRecords.Domain.Core.Commands;

namespace Docway.MedicalRecords.Domain.Commands.Patient
{
    public abstract class PatientCommand : Command
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public DateTime BirthDate { get; protected set; }
    }
}
