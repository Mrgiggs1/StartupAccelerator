using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StartUpAcceloratorAPI.Models
{
    public class Statistics
    {
        public int id { get; set; }
        public string? totalCapitalAmount { get; set; }
        public string? financialBackground { get; set; }
        public int managementExperience { get; set; }
        public int numOfCompetitors { get; set; }
        public int numOfEmployees { get; set; }
        public int relationships { get; set; }
        public int companyID { get; set; }
    }
}
