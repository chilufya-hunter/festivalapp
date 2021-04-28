using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmfestival.misc;

namespace Filmfestival.viewmodels
{
    class Nominationviewmodels : BindableBase
    {
        // Данные для таблицы с направленями
        public object DataSource
        {
            get
            {
                var movie = (from film in Globals.Db.nominations select film).ToList();
                var query = (from film in movie select new {film.title ,film.category,film.rating }).ToList();
                return query;
            }
        }
    }
}

