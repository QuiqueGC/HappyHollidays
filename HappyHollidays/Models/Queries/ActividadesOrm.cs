using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHollidays.Models.Queries
{
    public static class ActividadesOrm
    {
        public static List<actividades> Select(String descripcion)
        {
            List<actividades> _actividades = Orm.db.actividades
                .Where(a =>
                a.descripcion.Contains(descripcion))
                .ToList();
            return _actividades;
        }

        public static String Insert(actividades _actividades)
        {
            Orm.db.actividades.Add(_actividades);
            return Orm.MySaveChanges();
        }

        public static String Delete(actividades _actividades)
        {
            Orm.db.actividades.Remove(_actividades);
            return Orm.MySaveChanges();
        }
    }
}
