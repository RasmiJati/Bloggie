namespace Bloggie.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        //many to many relation between blogpost and tag
        public ICollection<BlogPost> BlogPosts { get; set; }  // 1 tag have multiple blogpost
    }
}
