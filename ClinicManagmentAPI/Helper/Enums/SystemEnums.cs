namespace ClinicManagmentAPI.Helper.Enums
{
    public static class SystemEnums
    {
        public enum Role
        {
            Admin,
            Employee,
            Client,
            Doctor,
            Nurse
        }
        public enum PaymentMethod
        {
            Cliacq = 100,
            Wallet=101,
            Cash=102
        }
        public enum CaseType
        {
            MedicalReview,
            Emergency,
            Appointment
        }
        public enum DiscountType
        {
            Percent,
            Value,
            // edit bayan
            None
        }
        public enum Gender
        {
            Male,
            Female
        }

        public enum DiesesType
        {
            AccidentalCondition,//حالة عرضية
            ChronicDisease,//مرض مزمن
            SeasonalIllness,//مرض موسمي
            ContagiousDisease,//مرض معدي
            ViralDisease//مرض فيروسي
        }

        public enum Servity
        {
            Low,
            Medium,
            High
        }

        public enum AttachementType
        {
            PreviousReport,
            PreviousMedicalPrescription,
            LabTest,
            Xray,
            Other
        }
    }
}
