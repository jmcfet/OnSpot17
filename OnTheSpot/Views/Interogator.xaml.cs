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

namespace OnTheSpot.Views
{
    /// <summary>
    /// Interaction logic for Interogator.xaml
    /// </summary>
    public partial class Interogator : Window
    {
        OnTheSpot.Models.InterogatorInfo info;
        int current = 0;
        public Interogator(OnTheSpot.Models.InterogatorInfo info)
        {
            DataContext = info;
            this.info = info;
            InitializeComponent();
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            if (current > 0)
            {
                issue.Text = info.issues[--current];
                res.Text = info.resolutions[current];
            }
        }

        private void right_Click(object sender, RoutedEventArgs e)
        {
            if (current < info.issues.Count-1)
            {
                issue.Text = info.issues[++current];
                res.Text = info.resolutions[current];
            }
        }
    }
}
