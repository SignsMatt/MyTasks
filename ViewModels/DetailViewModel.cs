using CommunityToolkit.Mvvm.ComponentModel;

namespace MyTasks.ViewModels
{
    [QueryProperty("Text", "Text")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
    }
}
