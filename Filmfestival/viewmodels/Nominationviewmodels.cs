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
                var filmnominattion = (from Film_festival in Globals.Db.film_nomination select Film_festival).ToList();
                var query = (from film_nominattion in filmnominattion select new { film_nominattion.id_film, film_nominattion.category }).ToList();

                return query;
            }
        }
    }
}

