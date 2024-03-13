

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiAppPOC.ViewModel
{
    public partial class MainViewModel: ObservableObject
    {

        public MainViewModel() 
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [ObservableProperty]
        string city;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            Items.Add(Text+", "+City);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s) 
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }
    }
}
