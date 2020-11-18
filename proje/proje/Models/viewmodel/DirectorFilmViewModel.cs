using System.Collections.Generic;
using proje.Models;

namespace proje.Models.ViewModels
{
    public class DirectorFilmViewModel
    {
        public Director Director { get; set; }
        public IList<Film> Films { get; set; }
    }
}
