using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StartUpAcceloratorAPI.Models
{
    public class User
    {

       public int UserId { get; set; }
        public  string Fullname { get; set; }
        public string Surname { get; set;  }
       public string email { get; set;}
       public  string phoneNo { get; set; }
        public string profileImg { get; set; }

       public int companyID { get; set; }
       public string address { get; set; }
       public int authenticationID { get; set; }

    }
}
