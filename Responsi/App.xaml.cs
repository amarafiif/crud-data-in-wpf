using Responsi.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Responsi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Dashboard Dashboard;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Dashboard = new Dashboard();
            Dashboard.Show();

        }
    }

}
