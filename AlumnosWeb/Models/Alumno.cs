namespace AlumnosWeb.Models;

public class Alumno
{
    public int Codigo { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public decimal Pension { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool Activo { get; set; }
}
