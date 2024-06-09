namespace SOLID;

public interface IAudioBook : ILibraryItem
{
    int RuntimeInMinutes { get; set; }
}