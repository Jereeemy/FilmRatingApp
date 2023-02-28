using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmRatingApp.Models;

public class Notation
{
    private int utl_id;
    private int? flm_id;
    private int? not_note;
/*
    private int utilisateurId;
    private int? filmId;
    private int? note;*/

    /*[ForeignKey("FilmId")]//récupère l'ID de l'autre table
    [InverseProperty("NotesFilm")]*/
    public Film FilmNote { get; set; } = null!;

    /*[ForeignKey("UtilisateurId")]
    [InverseProperty("NotesUtilisateur")]*/
    public Utilisateur UtilisateurNotant { get; set; } = null!;

    
    public int UtilisateurId
    {
        get
        {
            return utl_id;
        }

        set
        {
            utl_id = value;
        }
    }

    
    public int? FilmId
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

    
    public int? Note
    {
        get
        {
            return not_note;
        }

        set
        {
            not_note = value;
        }
    }

    public override bool Equals(object? obj)
    {
        return obj is Notation notation &&
               EqualityComparer<Film>.Default.Equals(this.FilmNote, notation.FilmNote) &&
               EqualityComparer<Utilisateur>.Default.Equals(this.UtilisateurNotant, notation.UtilisateurNotant) &&
               this.UtilisateurId == notation.UtilisateurId &&
               this.FilmId == notation.FilmId &&
               this.Note == notation.Note;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.FilmNote, this.UtilisateurNotant, this.UtilisateurId, this.FilmId, this.Note);
    }
}

