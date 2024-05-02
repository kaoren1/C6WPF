using System;
using System.Collections.Generic;
using System.Data;
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

namespace PR6WPF
{
    /// <summary>
    /// Логика взаимодействия для CalendarPage.xaml
    /// </summary>
    public partial class CalendarPage : Page
    {
        private static DateTime currentDate = DateTime.Now;

        public CalendarPage()
        {
            InitializeComponent();
            UpdateCalendar();
        }

        private void UpdateCalendar()
        {
            string d = currentDate.ToString("MMMM-yyyy");

            Month.Text = d;

            int month = currentDate.Month;

            int year = currentDate.Year;

            int daysInMonth = DateTime.DaysInMonth(year, month);

            DaysPanel.Children.Clear();

            for (int day = 1; day <= daysInMonth; day++)
            {
                MainView dayView = new MainView();
                DaysPanel.Children.Add(dayView);
            }
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            UpdateCalendar();
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            UpdateCalendar();
        }
    }
}
