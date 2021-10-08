using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios

{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()

        {
            
            rutas= new List<Rutas>()
            {
                new Rutas{id=1, origen=1,destino="Norte",tiempo_estimado= 100},
                new Rutas{id= 2 ,origen=2,destino="Sur",tiempo_estimado= 120},
                new Rutas{id =3, origen=3,destino="Oriente",tiempo_estimado= 200}
 
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutasWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }
        public Rutas Create(Rutas newRutas){
           newRutas.id=rutas.Max(r => r.id) +1; 
           rutas.Add(newRutas);
           return newRutas;
        }
    
        public Rutas Delete(int id)
        {
        var ruta= rutas.SingleOrDefault(b => b.id == id);
        rutas.Remove(ruta);
        return ruta;
        }


        public  Rutas Update(Rutas newRutas){
            var ruta= rutas.SingleOrDefault(b => b.id == newRutas.id);
            if(ruta != null){
                ruta.id = newRutas.id;
                ruta.origen = newRutas.origen;
                ruta.destino = newRutas.destino;
                ruta.tiempo_estimado = newRutas.tiempo_estimado;
                
            }
        return ruta;
        }

    }
}
