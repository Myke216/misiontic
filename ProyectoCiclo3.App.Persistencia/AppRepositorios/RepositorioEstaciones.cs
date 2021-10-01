using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="La Estrella",direccion="Autopista Regional #78d Sur-1 a 78d Sur-217,",coord_x= 100000,coord_y= 4,tipo= "POP678"},
                new Estaciones{id=2,nombre="Suramericana",direccion= "Esquina con Calle 47 D, Cra. 65 #S/N",coord_x= 90000,coord_y= 16,tipo= "OIU859"},
                new Estaciones{id=3,nombre="Laureles",direccion= "a 46-119, Cl. 44 #46-21",coord_x= 150000,coord_y= 24,tipo= "YUH859"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetEstacionWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }

        public Estaciones Create(Estaciones newEstacion)
        {
           if(estaciones.Count > 0){
           newEstacion.id=estaciones.Max(r => r.id) +1;  
            }else{
               newEstacion.id = 1; 
            }
           estaciones.Add(newEstacion);
           return newEstacion;
        }
        public Estaciones Update(Estaciones newEstacion){
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstacion.id);
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.coord_x= newEstacion.coord_x;
                estacion.coord_y = newEstacion.coord_y;
                estacion.tipo = newEstacion.tipo;
            }
        return estacion;
        }
        public Estaciones Delete(int id)
        {
        var estacion= estaciones.SingleOrDefault(b => b.id == id);
        estaciones.Remove(estacion);
        return estacion;
        }
    }
}