using System.ComponentModel.DataAnnotations;

namespace ResilienceLifescapeHospital.Areas.Identity.Data
{
    public class Doctor
    {
        [Key]
        public string Id { get; set; }
        public string Specialist { get; set; }
        public string? ExperienceYears { get; set; }
        public string Degree { get; set; }
        public bool PartTime { get; set; }
        public string? OPDTiming { get; set; }
        public string? SuccessfullOperations { get; set; }
        public string Nationality { get; set; }
        public bool isAssistant { get; set; }
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
