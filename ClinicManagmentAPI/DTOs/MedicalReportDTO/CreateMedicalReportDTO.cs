using ClinicManagmentAPI.Models.Enitites;
using System;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

public class CreateMedicalReportDTO
{
    public DateTime Date { get; set; }
    public string CaseType { get; set; }
    public string MainDescription { get; set; }
    public string Diagnosis { get; set; }
}

