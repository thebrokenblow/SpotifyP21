namespace SpotifyP21.Entities;

public class Group
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public ICollection<Genre> Genres { get; set; }
    public ICollection<Album> Albums { get; set; }
}