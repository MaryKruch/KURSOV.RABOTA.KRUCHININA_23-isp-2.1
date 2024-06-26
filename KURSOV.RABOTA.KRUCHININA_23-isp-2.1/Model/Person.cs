using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class Person:Base
{
    [Key]
    public int PersonId { get; set; }
    private string? lastname;
    public string? LastName
    {
        get { return lastname; }
        set
        {
            lastname = value;
            OnPropertyChanged(nameof(LastName));
        }
    }
    private string? firstname;
    public string? FirstName
    {
        get { return firstname; }
        set
        {
            firstname = value;
            OnPropertyChanged(nameof(FirstName));
        }
    }

    private string? surname;
    public string? Surname
    {
        get { return surname; }
        set
        {
            surname = value;
            OnPropertyChanged(nameof(Surname));
        }
    }
    private string? address;
    public string? Address
    {
        get { return address; }
        set
        {
            address = value;
            OnPropertyChanged(nameof(Address));
        }
    }
    private int? criminalrecord;
    public int? CriminalRecord
    {
        get { return criminalrecord; }
        set
        {
            criminalrecord = value;
            OnPropertyChanged(nameof(CriminalRecord));
        }
    }
}
