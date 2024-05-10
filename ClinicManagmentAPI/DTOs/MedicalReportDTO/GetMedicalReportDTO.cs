using System;

public class GetMedicalReportDTO
{
    public int Id { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public DateTime Date { get; set; }
    public string CaseType { get; set; }
    public string MainDescription { get; set; }
    public string Diagnosis { get; set; }

}
