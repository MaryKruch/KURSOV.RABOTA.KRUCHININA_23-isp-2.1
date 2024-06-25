using System;
using System.Collections.Generic;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class Decision
{
    public int DecisionId { get; set; }

    public int IncidentId { get; set; }

    public string DicisionType { get; set; } = null!;

    public string? CaseNumber { get; set; }

    public virtual Incident Incident { get; set; } = null!;
}
