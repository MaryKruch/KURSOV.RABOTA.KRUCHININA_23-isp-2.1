using System;
using System.Collections.Generic;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class IncidentPerson
{
    public int IncidentId { get; set; }

    public int PersonId { get; set; }

    public virtual Incident Incident { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
