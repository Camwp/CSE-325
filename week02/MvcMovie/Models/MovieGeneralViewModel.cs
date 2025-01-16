using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public SelectList? ReleaseDates { get; set; }
    public string? SelectedReleaseDate { get; set; } // Add this property

    public string? SearchString { get; set; }
}