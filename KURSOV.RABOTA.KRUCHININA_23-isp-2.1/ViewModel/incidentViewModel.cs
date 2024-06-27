using KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;
using KURSOV.RABOTA.KRUCHININA_23_isp_2._1.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.ViewModel
{
    class incidentViewModel:Base
    {
        DatabasekursovContext db = new DatabasekursovContext();
        private ObservableCollection<Incident> incidentList;
        public ObservableCollection<Incident> IncidentLst
        {
            get { return incidentList; }
            set
            {
                incidentList = value;
                OnPropertyChanged(nameof(IncidentLst));
            }
        }

        public InsidentPage window;

        private Incident? selectedIncident;
        public Incident? SelectedIncident
        {
            get { return selectedIncident; }
            set
            {
                selectedIncident = value;
                OnPropertyChanged(nameof(SelectedIncident));
            }
        }


        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddEditIncident window = new AddEditIncident(new Incident());
                        if (window.ShowDialog() == true)
                        {
                            Incident incident = window.Incident;
                            db.Incidents.Add(incident);
                            db.SaveChanges();
                        }
                    }));
            }
        }
        private RelayCommand? editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                    (editCommand = new RelayCommand(obj =>
                    {
                        Incident? incident = obj as Incident;
                        if (incident == null) return;
                        AddEditIncident window = new AddEditIncident(incident);
                        if (window.ShowDialog() == true)
                        {
                            //incident.IncidentId = window.
                            //incident.RegistrationDate = window.registration_date;
                            //incident.Type = window.dicision_type;
                            //incident.Kurs = window.Student.Kurs;                /*вопросик*/
                            //incident.BirthDay = window.Student.BirthDay;
                            //incident.City = window.Student.City;
                            //incident.UnivId = window.Student.UnivId;
                            //db.Entry(incident).State = EntityState.Modified;
                            //db.SaveChanges();
                        }
                    }));
            }
        }
        RelayCommand? deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand(selectedItem =>
                  {
                      // получаем выделенный объект
                      Incident? incident = selectedItem as Incident;
                      if (incident== null) return;
                      db.Incidents.Remove(incident);
                      db.SaveChanges();
                  }));
            }
        }
    }
}