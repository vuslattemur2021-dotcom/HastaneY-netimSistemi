public class PatientHistory {
    public int HistoryId { get; set; }
    public int PatientId { get; set; }
    public DateTime VisitDate { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }
    public string Notes { get; set; }
}