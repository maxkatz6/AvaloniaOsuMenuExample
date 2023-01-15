using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace OsuMenuExample;

public class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Maps = new ObservableCollection<MapViewModel>(new[]
        {
            new MapViewModel("S", "SHIORI", "ClariS", "Insane"),
            new MapViewModel("A", "MONSTER", "Reol", "Expert"),
            new MapViewModel("A", "Hall Of The Mountain King", "Apocalyptica", "Insane"),
            new MapViewModel("S", "Chocolate", "GUMI", "Insane"),
            new MapViewModel("S", "Frame of Mind", "Tristam", "Normal"),
            new MapViewModel("B", "Sprinter", "Kalafina", "Insane"),
            new MapViewModel("S", "Katana no Saya", "Ali Project", "Normal"),
        });
    }
    
    public IReadOnlyCollection<MapViewModel> Maps { get; }
}