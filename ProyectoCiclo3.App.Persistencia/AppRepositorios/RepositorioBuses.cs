using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> buses;
        private readonly AppContext _appContext = new AppContext(); 
 //   public RepositorioBuses()
   //     {
     //       buses= new List<Buses>()
       //     {
         //       new Buses{id=1,marca="Audi",modelo= 2020,kilometraje= 100000,numero_asientos= 4,placa= "POP678"},
          //      new Buses{id=2,marca="Toyota",modelo= 2021,kilometraje= 90000,numero_asientos= 16,placa= "OIU859"},
            //    new Buses{id=3,marca="Mazda",modelo= 2000,kilometraje= 150000,numero_asientos= 24,placa= "YUH859"}
 
//            };
  //      }
 
        public IEnumerable<Buses> GetAll()
        {
              return _appContext.Buses;
        }
 
        public Buses GetBusWithId(int id){
            return _appContext.Buses.Find(id);
        }
       
       public Buses Create(Buses newBus)
        {
         var addBus = _appContext.Buses.Add(newBus);
            _appContext.SaveChanges();
            return addBus.Entity;
        }
        public Buses Update(Buses newBus){
            var bus  = _appContext.Buses.Find(newBus.id);
            if(bus != null){
                bus.marca = newBus.marca;
                bus.modelo = newBus.modelo;
                bus.kilometraje = newBus.kilometraje;
                bus.numero_asientos = newBus.numero_asientos;
                bus.placa = newBus.placa;
                _appContext.SaveChanges();
            }
        return bus;
        }
        public void Delete(int id)
        {
        var bus = _appContext.Buses.Find(id);
        if (bus == null)
            return;
        _appContext.Buses.Remove(bus);
        _appContext.SaveChanges();
        }

    }
}