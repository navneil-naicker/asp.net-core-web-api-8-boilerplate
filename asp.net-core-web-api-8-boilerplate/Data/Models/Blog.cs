using System.ComponentModel.DataAnnotations;

namespace asp.net_core_web_api_8_boilerplate.Data.Entities
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string? Title { get; set; }
        public string? Except { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
    }

    public class BlogLog
    {
        [Key]
        public int LogID { get; set; }
        public required string LogAction { get; set; }
        public required DateTime LogCreatedAt { get; set; }
        public required int LogCreatedBy { get; set; }
        public required int BlogID { get; set; }
        public string? Title { get; set; }
        public string? Except { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }

    }

}
