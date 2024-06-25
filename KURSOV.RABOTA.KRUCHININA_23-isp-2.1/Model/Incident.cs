using System;
using System.Collections.Generic;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class Incident
{
    public int IncidentId { get; set; }

    public string RegistrationDate { get; set; } = null!;

    public string IncidentDescription { get; set; } = null!;

    public virtual ICollection<Decision> Decisions { get; set; } = new List<Decision>();
}
