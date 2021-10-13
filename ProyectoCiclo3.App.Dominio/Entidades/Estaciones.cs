using System;
using System.ComponentModel.DataAnnotations;
namespace ProyectoCiclo3.App.Dominio{
	public class Estaciones{
		public int id {get;set;}
		public string nombre {get;set;}
		public string direccion {get;set;}
		public float coord_x {get;set;}
		public float coord_y {get;set;}
		public string tipo {get;set;}
	}
}
