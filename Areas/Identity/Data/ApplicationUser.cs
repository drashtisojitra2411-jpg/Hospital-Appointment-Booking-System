using Microsoft.AspNetCore.Identity;

namespace ResilienceLifescapeHospital.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser<string>
{
    public string FName { get; set; }
    public string MName { get; set; }
    public string LName { get; set; }
    public string Gender { get; set; }
    public DateTime? DOB { get; set; }
    public string? BloodGroup { get; set; }
    public string Address { get; set; }
    public int Pincode { get; set; }
    public string City { get; set; }
    public string? State { get; set; }
    public virtual List<Doctor> Doctors { get; set; }
    public virtual List<Patient> Patients { get; set; }
}

