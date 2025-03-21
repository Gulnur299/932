using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using _932.db;

namespace _932.Functions
{
    public class FilmFunctions
    {
        public static ObservableCollection<Film> films {  get; set; }
        public static ObservableCollection<Film> GetFilms()
        {
            return new ObservableCollection<Film>(DB_Class.connection.Film.ToList());
        }

        public static ObservableCollection<Film> SearchFilm(string name)
        {
            return films = new ObservableCollection<Film>(DB_Class.connection.Film.Where(x=> x.Title.Contains(name)).ToList());
        }

        public static Film GetFilmInfo(int id)
        {
            Film selectedFilm = DB_Class.connection.Film.Where(Id_film => Id_film.id_film == id).FirstOrDefault();
            Film film = new Film
            {
                id_film = selectedFilm.id_film,
                Title = selectedFilm.Title,
                id_age = selectedFilm.id_age,
                Price = selectedFilm.Price
            };
            return film;
        }
    }
}
