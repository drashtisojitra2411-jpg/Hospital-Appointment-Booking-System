using System.ComponentModel.DataAnnotations;

namespace ResilienceLifescapeHospital.Areas.Identity.Data
{
    public class Patient
    {
        [Key]
        public string Id { get; set; }
        public string? Allergies { get; set; }
        public string? NameOfDisease { get; set; }
        public bool Genetic { get; set; }
        public string? SinceYears { get; set; }
        public string CurrentMedication { get; set; }
        public string? MaritialStatus { get; set; }
        public string Occupation { get; set; }
        public string? Disability { get; set; }
        public string? Insurance { get; set; }
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
