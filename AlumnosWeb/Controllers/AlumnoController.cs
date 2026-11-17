using AlumnosWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlumnosWeb.Controllers;

public class AlumnoController : Controller
{
    private static readonly IReadOnlyList<Alumno> ListaAlumnos =
    [
        new() { Codigo = 1001, Nombre = "Ricardo Loaiziga", Pension = 450.90m, FechaNacimiento = new DateTime(2007, 3, 3), Activo = true },
        new() { Codigo = 1002, Nombre = "David Martínez", Pension = 380.50m, FechaNacimiento = new DateTime(2006, 9, 21), Activo = true },
        new() { Codigo = 1003, Nombre = "Steven Andino", Pension = 550.10m, FechaNacimiento = new DateTime(2000, 6, 12), Activo = true },
        new() { Codigo = 1004, Nombre = "Kenneth Maldonado", Pension = 220.40m, FechaNacimiento = new DateTime(2005, 11, 9), Activo = true },
        new() { Codigo = 1005, Nombre = "Kevin Torrez", Pension = 300.60m, FechaNacimiento = new DateTime(2004, 1, 21), Activo = true },
        new() { Codigo = 1006, Nombre = "Julian Alvarez", Pension = 400.30m, FechaNacimiento = new DateTime(2003, 5, 21), Activo = true },
        new() { Codigo = 1007, Nombre = "Deybi Gonzalez", Pension = 440.30m, FechaNacimiento = new DateTime(2007, 10, 22), Activo = true },
        new() { Codigo = 1008, Nombre = "Luis Obando", Pension = 230.50m, FechaNacimiento = new DateTime(2002, 12, 31), Activo = true }
    ];

    public IActionResult Index()
    {
        return View(ListaAlumnos);
    }
}
