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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime? dt1;
        DateTime? dt2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Date2_CalendarClosed(object sender, RoutedEventArgs e)
        {
            dt2 = Date2.SelectedDate;
            if (dt2 != null && dt1 != null && dt2 > dt1)
                Text.Text = (dt2 - dt1).Value.TotalDays.ToString();
            else
                Text.Text = "Incorrect Input";

        }

        private void Date1_CalendarClosed(object sender, RoutedEventArgs e)
        {
            dt1 = Date1.SelectedDate;
            if (dt2 != null && dt1 != null && dt2 > dt1)
                Text.Text = (dt2 - dt1).Value.TotalDays.ToString();
            else
                Text.Text = "Incorrect Input";
        }
    }
}
