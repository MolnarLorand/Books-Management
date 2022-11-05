namespace Molnar_Lorand_Lab2.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<Book>? Books { get; set; }

        public static implicit operator Author(string v)
        {
            throw new NotImplementedException();
        }
    }
}
