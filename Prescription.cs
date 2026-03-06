public class Prescription { 
    public int PrescriptionId { get; set; } 
    public int PatientId { get; set; } 
    public int DoctorId { get; set; } 
    public string MedicineName { get; set; } 
    public string Dosage { get; set; } 
    public int Duration { get; set; } 
    public DateTime PrescriptionDate { get; set; } 
}