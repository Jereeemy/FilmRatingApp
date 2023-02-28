using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using FilmRatingApp.Models;

namespace FilmRatingApp.Services;
internal class WSService : IService
{

    private HttpClient client;
    public const string nomControlleur = "/api/series";

    public WSService(string url)
    {
        client = new HttpClient();
        client.BaseAddress = new Uri(url);
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<List<Utilisateur>> GetUtilisateursAsync(string nomControleur)
    {
        try
        {
            return await client.GetFromJsonAsync<List<Utilisateur>>(nomControleur);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public async Task<Utilisateur> GetUtilisateurFromAsync<T>(string nomControleur, T value)
    {
        try
        {
            return await client.GetFromJsonAsync<Utilisateur>($"{nomControleur}/{value}");
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<Utilisateur> GetUtilisateurFromMailAsync(string nomControleur, String mail)
    {
        try
        {
            Console.WriteLine($"{nomControleur}/{mail}");
            return await GetUtilisateurFromAsync(nomControleur, mail);
        }
        catch (Exception)
        {
            return null;
        }
    }


}
