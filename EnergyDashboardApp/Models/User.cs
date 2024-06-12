using System.ComponentModel.DataAnnotations;

namespace EnergyDashboardApp.Models
{
    public class User
    {
       [Key]
        public int? UserID { get; set; }
        public string Username { get; set; }
        public string EmailID { get; set; }
        public List<EnergyData> EnergyData { get; set; }
    }
}

