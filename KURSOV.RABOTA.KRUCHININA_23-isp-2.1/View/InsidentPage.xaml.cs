using KURSOV.RABOTA.KRUCHININA_23_isp_2._1.ViewModel;
using Microsoft.EntityFrameworkCore.Storage;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.View
{
    /// <summary>
    /// Логика взаимодействия для InsidentPage.xaml
    /// </summary>
    public partial class InsidentPage : Page
    {
        public InsidentPage()
        {
            InitializeComponent();
            DataContext = new incidentViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
