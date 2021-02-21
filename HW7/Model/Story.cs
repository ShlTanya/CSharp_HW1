namespace HW7.Model
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AuthorID { get; set; }
        public Author Author { get; set; }
    }
}