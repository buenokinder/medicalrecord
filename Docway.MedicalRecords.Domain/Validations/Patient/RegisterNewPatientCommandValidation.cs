namespace Docway.MedicalRecords.Domain.Validations.Patient
{
    using System;
    using Docway.MedicalRecords.Domain.Commands.Patient;

    public class RegisterNewPatientCommandValidation : PatientValidation<RegisterNewPatientCommand>
    {
        public RegisterNewPatientCommandValidation()
        {
            ValidateName();
            ValidateBirthDate();
            ValidateEmail();
        }
    }
}
