using System.ComponentModel.DataAnnotations;

namespace EnergyDashboardApp.Models
{
    public class EnergyData
    {
        [Key]
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public double EnergyConsumption { get; set; }
        public double EnergyGeneration { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
    }
}