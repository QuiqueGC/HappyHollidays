using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyHollidays.Models.Queries
{
    public static class ActividadesHotelesOrm
    {
        public static List<act_hotel> Select(String descripcion, hoteles hoteles)
        {
            List<act_hotel> _act_hotel = Orm.db.act_hotel
                .Where(a =>
                a.nombre == hoteles.nombre &&
                a.id_ciudad == hoteles.id_ciudad &&
                a.actividades.descripcion.Contains(descripcion))
                .ToList();
            return _act_hotel;
        }

        public static List<act_hotel> Select(String descripcion, hoteles hoteles, int grado)
        {
            List<act_hotel> _act_hotel = Orm.db.act_hotel
                .Where(a =>
                a.hoteles.nombre == hoteles.nombre &&
                a.hoteles.id_ciudad == hoteles.id_ciudad &&
                a.actividades.descripcion.Contains(descripcion) &&
                a.grado == grado)
                .ToList();
            return _act_hotel;
        }

        public static List<act_hotel> Select(String hotelName, ciudades ciudades, actividades actividades)
        {
            List<act_hotel> _act_hotel = Orm.db.act_hotel
                .Where(a =>
                a.hoteles.nombre.Contains(hotelName) &&
                a.id_ciudad == ciudades.id_ciudad && 
                a.id_act == actividades.id_act
                )
                .ToList();
            return _act_hotel;
        }

        public static List<act_hotel> Select(String hotelName, actividades actividades)
        {
            List<act_hotel> _act_hotel = Orm.db.act_hotel
                .Where(a =>
                a.hoteles.nombre.Contains(hotelName) &&
                a.id_act == actividades.id_act
                ).ToList();
            return _act_hotel;
        }

        public static String Insert(act_hotel _act_hotel)
        {
            Orm.db.act_hotel.Add(_act_hotel);
            return Orm.MySaveChanges();
        }
        public static String Delete(act_hotel _act_hotel)
        {
            Orm.db.act_hotel.Remove(_act_hotel);
            return Orm.MySaveChanges();
        }
    }
}
