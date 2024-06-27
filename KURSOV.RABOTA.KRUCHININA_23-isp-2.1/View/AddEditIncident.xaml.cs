using KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.View
{
    /// <summary>
    /// Логика взаимодействия для AddEditIncident.xaml
    /// </summary>

    public struct MyData
    {
        public string Role { set; get; }
        public string Person { set; get; }
    }
    public partial class AddEditIncident : Window
    {

        DatabasekursovContext db = new DatabasekursovContext();
        public Incident Incident { get; private set; }
        public List<Person> ListPerson { get; set; }
        public List<IncidentPerson> InsPersons { get; set; }
        public AddEditIncident(Incident incident)
        {
            InitializeComponent();
            Incident = incident;
            DataContext = Incident;
            Peoples.ItemsSource = db.People.ToList();
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            Persons.Columns.Add(col1);
            Persons.Columns.Add(col2);
            col1.Binding = new Binding("Person");
            col2.Binding = new Binding("Role");
            col1.Header = "Person";
            col2.Header = "Role";
        }

        private void adopted_dicision_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (adopted_dicision.SelectedIndex)
            {
                case 1:
                    {
                        RegNomer.Visibility = Visibility.Visible;
                    }
                    break;
                default:
                    RegNomer.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Persons.Items.Add(new MyData{ Person = Peoples.SelectedValue.ToString()!, Role = (Role.SelectedItem as TextBlock).Text!});
        }
    }
}