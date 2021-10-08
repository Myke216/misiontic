using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios

{
    public class RepositorioRutas
    {
        private readonly AppContext _appContext = new AppContext(); 

 
        public IEnumerable<Rutas> GetAll()
        {
            return _appContext.Rutas;
        }
 
        public Rutas GetRutasWithId(int id){
               return _appContext.Rutas.Find(id);
        }
        public Rutas Create(Rutas newRutas){
           var addRutas = _appContext.Rutas.Add(newRutas);
            _appContext.SaveChanges();
            return addRutas.Entity;
        }
    
        public void Delete(int id)
        {
        var ruta = _appContext.Rutas.Find(id);
        if (ruta == null)
            return;
        _appContext.Rutas.Remove(ruta);
        _appContext.SaveChanges();
        }
        


        public  Rutas Update(Rutas newRutas){
           var ruta = _appContext.Rutas.Find(newRutas.id);
            if(ruta != null){
                ruta.origen = newRutas.origen;
                ruta.destino = newRutas.destino;
                ruta.tiempo_estimado = newRutas.tiempo_estimado;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return ruta;
        }

    }
}

 

       


