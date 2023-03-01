using FilmRatingApp.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace FilmRatingApp.Views;

public sealed partial class UtilisateurPage : Page
{
    public UtilisateurViewModel ViewModel
    {
        get;
    }

    public UtilisateurPage()
    {
        ViewModel = App.GetService<UtilisateurViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
        //DataContext = ((App)Application.Current).UtilisateurVM;
    }
}
