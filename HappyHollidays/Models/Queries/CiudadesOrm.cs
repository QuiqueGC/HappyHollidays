using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHollidays.Models.Queries
{
    public static class CiudadesOrm
    {
        public static List<ciudades> Select()
        {
            List<ciudades> _ciudades = Orm.db.ciudades.ToList();
            return _ciudades;
        }

        public static List<ciudades> Select(string name)
        {
            List<ciudades> _ciudades = Orm.db.ciudades
                .Where(c =>
                c.nombre.Contains(name))
                .ToList();
            return _ciudades;
        }

        public static String Insert(ciudades _ciudades)
        {
            Orm.db.ciudades.Add(_ciudades);
            return Orm.MySaveChanges();
        }

        public static String Delete(ciudades _ciudades)
        {
            Orm.db.ciudades.Remove(_ciudades);
            return Orm.MySaveChanges();
        }
    }
}
