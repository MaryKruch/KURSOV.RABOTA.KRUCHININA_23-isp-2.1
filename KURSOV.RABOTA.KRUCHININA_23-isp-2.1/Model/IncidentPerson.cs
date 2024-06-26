using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class IncidentPerson:Base
{
    [Key]
    public int IncidentId { get; set; }
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
