using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHollidays.Models.Queries
{
    public static class CadenasOrm
    {
        public static List<cadenas> Select()
        {
            List<cadenas> _cadenas = Orm.db.cadenas.ToList();
            return _cadenas;
        }
        
        public static List<cadenas> Select(String nombre)
        {
            List<cadenas> _cadenas = Orm.db.cadenas
                .Where(c => c.nombre.Contains(nombre))
                .ToList();
            return _cadenas;
        }

        public static String Insert(cadenas _cadenas)
        {
            Orm.db.cadenas.Add(_cadenas);
            return Orm.MySaveChanges();
        }

        public static String Delete(cadenas _cadenas)
        {
            Orm.db.cadenas.Remove(_cadenas);
            return Orm.MySaveChanges();
        }
    }
}
