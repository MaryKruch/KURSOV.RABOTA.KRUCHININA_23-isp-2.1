using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class Incident:Base
{
    [Key]
    public int IncidentId { get; set; }

    private string? registrationdate;
    public string? RegistrationDate
    {
        get { return registrationdate; }
        set
        {
            registrationdate = value;
            OnPropertyChanged(nameof(RegistrationDate));
        }
    }
    private string? incidentdescription;
    public string? IncidentDescription
    {
        get { return registrationdate; }
        set
        {
            registrationdate = value;
            OnPropertyChanged(nameof(IncidentDescription));
        }
    }

    public virtual ICollection<Decision> Decisions { get; set; } = new List<Decision>();
}
