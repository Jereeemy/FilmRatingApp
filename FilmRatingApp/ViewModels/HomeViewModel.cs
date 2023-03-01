using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using FilmRatingApp.Models;
using FilmRatingApp.Services;
using Microsoft.UI.Xaml.Controls;

namespace FilmRatingApp.ViewModels;

public class HomeViewModel : ObservableRecipient //ObservableObject
{
    public HomeViewModel()
    {
    }

    /*private ObservableCollection<Utilisateur> utilisateurs;

    public ObservableCollection<Utilisateur> Utilisateurs
    {
        get
        {
            return utilisateurs;
        }
        set
        {
            utilisateurs = value; OnPropertyChanged();
        }
    }


    public async void GetDataOnLoadAsync()
    {
        WSService service = new WSService("https://localhost:7001/");
        List<Utilisateur> result = await service.GetUtilisateursAsync("api/Utilisateurs/GetUtilisateurs");
        if (result == null)
            DisplayErreurDialog("API non disponible !", "Erreur");
        else
            Utilisateurs = new ObservableCollection<Utilisateur>(result);
    }

    public async void DisplayErreurDialog(string content, string title)
    {
        ContentDialog erreur = new ContentDialog()
        {
            Title = title,
            Content = content,
            CloseButtonText = "Ok"
        };

        erreur.XamlRoot = App.MainRoot.XamlRoot;
        await erreur.ShowAsync();
    }*/
}
