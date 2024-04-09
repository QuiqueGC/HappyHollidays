using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHollidays.Models.Queries
{
    public static class HotelesOrm
    {
        public static List<hoteles> Select(String nombre)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre))
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(String nombre, cadenas cadenas)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h=>
                h.nombre.Contains(nombre) &&
                h.cadenas.cif == cadenas.cif)
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(string nombre, string tipo)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.tipo == tipo)
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(string nombre, int categoria)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.categoria == categoria)
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(string nombre, ciudades ciudades)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.ciudades.id_ciudad == ciudades.id_ciudad)
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(string nombre, cadenas cadenas, ciudades ciudades)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.cadenas.cif == cadenas.cif &&
                h.ciudades.id_ciudad == ciudades.id_ciudad)
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(string nombre, cadenas cadenas, int categoria)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.cadenas.cif == cadenas.cif &&
                h.categoria == categoria)
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(string nombre, string tipo, int categoria)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.tipo == tipo &&
                h.categoria == categoria)
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(string nombre, string tipo, ciudades ciudades)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.ciudades.id_ciudad == ciudades.id_ciudad &&
                h.tipo == tipo)
                .ToList();
            return _hoteles;
        }
        
        public static List<hoteles> Select(string nombre, int categoria, ciudades ciudades)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.ciudades.id_ciudad == ciudades.id_ciudad &&
                h.categoria == categoria)
                .ToList();
            return _hoteles;
        }

        public static List<hoteles> Select(string nombre, cadenas cadenas, ciudades ciudades, int categoria)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.cadenas.cif == cadenas.cif &&
                h.ciudades.id_ciudad == ciudades.id_ciudad &&
                h.categoria == categoria)
                .ToList();
            return _hoteles;
        }


        public static List<hoteles> Select(string nombre, string tipo, int categoria, ciudades ciudades)
        {
            List<hoteles> _hoteles = Orm.db.hoteles
                .Where(h =>
                h.nombre.Contains(nombre) &&
                h.ciudades.id_ciudad == ciudades.id_ciudad &&
                h.tipo == tipo &&
                h.categoria == categoria)
                .ToList();
            return _hoteles;
        }

        public static String Insert(hoteles _hoteles)
        {
            Orm.db.hoteles.Add(_hoteles);
            return Orm.MySaveChanges();
        }

        public static String Delete(hoteles _hoteles)
        {
            Orm.db.hoteles.Remove(_hoteles);
            return Orm.MySaveChanges();
        }
    }
}
