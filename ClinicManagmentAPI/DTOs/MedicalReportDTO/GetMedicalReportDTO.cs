using System;

public class GetMedicalReportDTO
{
    public int Id { get; set; }
    public DateTime CreationDate { get; set; }
    public string CaseType { get; set; }
    public string MainDescription { get; set; }
    public string Diagnosis { get; set; }
    public string? PatientImage { get; set; }
    public string? PatientName { get; set; }
    public string? PatientNationalId { get; set; }
    public string? PatientPhone { get; set; }
    public string? PatientEmail { get; set; }
    public string? EmployeeName { get; set; }
    public string? DoctorName { get; set; }

}
