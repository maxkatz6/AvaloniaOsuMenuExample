using CommunityToolkit.Mvvm.ComponentModel;

namespace OsuMenuExample;

public class MapViewModel : ObservableObject
{
    public MapViewModel(string rank, string title, string artist, string difficulty)
    {
        Rank = rank;
        Title = title;
        Artist = artist;
        Difficulty = difficulty;
    }
    
    public string Rank { get; }
    public string Title { get; }
    public string Artist { get; }
    public string Difficulty { get; }
}