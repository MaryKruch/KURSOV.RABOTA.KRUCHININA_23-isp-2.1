using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class IncidentPerson:Base
{

    public int incidentId;
    public int IncidentId
    {
        get { return incidentId; }
        set
        {
            incidentId = value;
            OnPropertyChanged(nameof(IncidentId));
        }
    }
    private int personid;
    public int PersonId
    {
        get { return personid; }
        set
        {
            personid = value;
            OnPropertyChanged(nameof(PersonId));
        }
    }

    public virtual Incident Incident { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
