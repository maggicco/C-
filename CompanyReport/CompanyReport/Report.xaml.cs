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

namespace CompanyReport
{
    /// <summary>
    /// Logique d'interaction pour Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        public Report()
        {
            InitializeComponent();
        }

        
        public Report(object data) : this()
        {
            // Bind report data.
            this.DataContext = data;
        }


    }
}
