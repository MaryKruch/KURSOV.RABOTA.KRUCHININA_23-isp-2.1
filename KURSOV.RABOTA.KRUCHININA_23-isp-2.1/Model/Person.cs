using System;
using System.Collections.Generic;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class Person
{
    public int PersonId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Surname { get; set; }

    public string Address { get; set; } = null!;

    public int? CriminalRecord { get; set; }
}
