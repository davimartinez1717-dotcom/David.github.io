using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AlumnoController : Controller
    {
        static List<Alumno> ListaAlumnos = new List<Alumno>()
        { 
            new Alumno(1001, "Ricardo Loaiziga", 450.90, DateTime.Parse("03/03/2007")),
             new Alumno(1002, "David Martínez", 380.50, DateTime.Parse("21/09/2006")),
              new Alumno(1003, "Steven Andino", 550.10, DateTime.Parse("12/06/2000")),
               new Alumno(1004, "Kenneth Maldonado", 220.40, DateTime.Parse("09/11/2005")),
                new Alumno(1005, "Kevin Torrez", 300.60, DateTime.Parse("21/01/2004")),
                  new Alumno(1006, "Julian Alvarez", 400.30, DateTime.Parse("21/05/2003")),
                    new Alumno(1007, "Deybi Gonzalez", 440.30, DateTime.Parse("22/10/2007")),
                      new Alumno(1008, "Luis Obando", 230.50, DateTime.Parse("31/12/2002")),
        };

    // GET: Alumno
    public ActionResult Index()
        {
            return View(ListaAlumnos);
        }
    }
}