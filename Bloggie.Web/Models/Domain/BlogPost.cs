﻿namespace Bloggie.Web.Models.Domain
{
    public class BlogPost
    {
        //prop   /ctor
        public Guid Id { get; set; }  // Guid --> unique identifer
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

        //show many to many relationship
        public ICollection<Tag> Tags{ get; set; }  //1 blog having many tags

    }
}
