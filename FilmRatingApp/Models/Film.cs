using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmRatingApp.Models;

public class Film
{
    private int flm_id;
    private string? flm_titre;
    private string? flm_resume;
    private DateTime? flm_datesortie;
    private double? flm_duree;
    private string? flm_genre;

    /*[InverseProperty(nameof(Notation.FilmNote))]*/
    public ICollection<Notation> NotesFilm { get; set; } = new List<Notation>();

   
    public int FilmId
    {
        get
        {
            return flm_id;
        }

        set
        {
            flm_id = value;
        }
    }

    
    public string? Titre
    {
        get
        {
            return flm_titre;
        }

        set
        {
            flm_titre = value;
        }
    }

   
    public string? Resume
    {
        get
        {
            return flm_resume;
        }

        set
        {
            flm_resume = value;
        }
    }

   
    public DateTime? DateSortie
    {
        get
        {
            return flm_datesortie;
        }

        set
        {
            flm_datesortie = value;
        }
    }

    
    public double? Duree
    {
        get
        {
            return flm_duree;
        }

        set
        {
            flm_duree = value;
        }
    }

    
    public string? Genre
    {
        get
        {
            return flm_genre;
        }

        set
        {
            flm_genre = value;
        }
    }

    public override bool Equals(object? obj)
    {
        return obj is Film film &&
               EqualityComparer<ICollection<Notation>>.Default.Equals(this.NotesFilm, film.NotesFilm) &&
               this.FilmId == film.FilmId &&
               this.Titre == film.Titre &&
               this.Resume == film.Resume &&
               this.DateSortie == film.DateSortie &&
               this.Duree == film.Duree &&
               this.Genre == film.Genre;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.NotesFilm, this.FilmId, this.Titre, this.Resume, this.DateSortie, this.Duree, this.Genre);
    }
}

