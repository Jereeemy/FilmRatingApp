﻿using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilmRatingApp.Models;
using FilmRatingApp.Services;

namespace FilmRatingApp.ViewModels;


public class UtilisateurViewModel : HomeViewModel
{
    public IRelayCommand BtnSearchUtilisateurCommand
    {
        get;
    }

    public UtilisateurViewModel()
    {
        UtilisateurSearch = new Utilisateur();
        BtnSearchUtilisateurCommand = new RelayCommand(SearchUserOnAction);
    }

    private string searchMail;

    public string SearchMail
    {
        get
        {
            return searchMail;
        }
        set
        {
            searchMail = value; OnPropertyChanged();
        }
    }

    private Utilisateur utilisateurSearch;

    public Utilisateur UtilisateurSearch
    {
        get
        {
            return utilisateurSearch;
        }
        set
        {
            utilisateurSearch = value; OnPropertyChanged();
        }
    }

    public async void SearchUserOnAction()
    {
        WSService service = new WSService("https://localhost:7001");
        var result = await service.GetUtilisateurByEmailAsync("api/Utilisateurs/GetByEmail/GetByEmail", SearchMail);
        if (result == null)
            DisplayErreurDialog("Série non trouvée !", "Erreur");
        else
            UtilisateurSearch = result.Value;
    }

}

