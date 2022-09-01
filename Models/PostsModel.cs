namespace StartUpAcceloratorAPI.Models
{
    public class PostsModel
    {
        int posID { get; set; }
        string? projectImage { get; set; }
        string? projectDescription { get; set; }
        string? projectStatus { get; set; }
        string? projectTitle { get; set; }
        int companyID { get; set; }
    }
}
