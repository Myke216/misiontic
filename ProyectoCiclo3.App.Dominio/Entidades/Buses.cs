using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCiclo3.App.Dominio{
    public class Buses{
        
        public int id {get;set;}
        [Required]
        public string marca {get;set;}
        public int modelo {get;set;}
        public int kilometraje {get;set;}
        public int numero_asientos {get;set;}
        public string placa {get;set;}
    }
}
