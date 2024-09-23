using System;
using System.Collections.Generic;

namespace Crud_Funcional.Models;

public partial class Inscripcione
{
    public int IdInscripcion { get; set; }

    public int IdEstudiante { get; set; }

    public int IdMateria { get; set; }

    public DateOnly FechaInscripcion { get; set; }

    public virtual Estudiante IdEstudianteNavigation { get; set; } = null!;

    public virtual Materia IdMateriaNavigation { get; set; } = null!;
}
