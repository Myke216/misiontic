
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormRutasModel : PageModel
    {
        private readonly RepositorioEstaciones repositorioEstaciones;
        public IEnumerable<Estaciones> Estaciones {get;set;}
        private readonly RepositorioRutas repositorioRutas;
       
        [BindProperty]
        public Rutas Rutas {get;set;}
 
        public FormRutasModel(RepositorioRutas repositorioRutas,RepositorioEstaciones repositorioEstaciones)
       {
            this.repositorioRutas=repositorioRutas;
            this.repositorioEstaciones=repositorioEstaciones;
       }


        public void OnGet()
        {
        Estaciones=repositorioEstaciones.GetAll();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }else{            
            Rutas = repositorioRutas.Create(Rutas);            
            return RedirectToPage("./List");
            }
        }
    }
}