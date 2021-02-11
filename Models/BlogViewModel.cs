namespace bloopers.Models
{
    public class Blogs
    {
        public int BlogId {get; set;}
        public string Title {get; set;}
        public string Author {get;set;}
        public string Date {get;set;}
    }

    public class Content
    {
        public int BlogId {get;set;}
        public string Text {get;set;}
    }
}