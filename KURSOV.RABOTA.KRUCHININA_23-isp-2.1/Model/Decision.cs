using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class Decision:Base
{
    [Key]
    public int DecisionId { get; set; }
    private int icidentid;
    public int IncidentId
    {
        get { return icidentid; }
        set
        {
            icidentid = value;
            OnPropertyChanged(nameof(IncidentId));
        }
    }
    private string? dicisiontype;
    public string? DicisionType
    {
        get { return dicisiontype; }
        set
        {
            dicisiontype = value;
            OnPropertyChanged(nameof(DicisionType));
        }
    }

    private string? casenumber;
    public string? CaseNumber
    {
        get { return casenumber; }
        set
        {
            casenumber = value;
            OnPropertyChanged(nameof(CaseNumber));
        }
    }


    public virtual Incident Incident { get; set; } = null!;
}
