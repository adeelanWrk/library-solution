using System.Collections.Generic;

public class Book
{
    public int BookId { get; set; } 
    public string? Title { get; set; }
    public string? Publisher { get; set; }
    public decimal? Price { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
}
