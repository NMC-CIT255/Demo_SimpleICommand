using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_SimpleICommand.Models;
using Demo_SimpleICommand.DataLayer;

namespace Demo_SimpleICommand.BusinessLayer
{
    public class AppBusiness
    {
        private IList<Riddle> riddles = new List<Riddle>();



        public AppBusiness()
        {
            AppWindowViewModel appWindowViewModel = new AppWindowViewModel(riddles);

            AppWindow appWindow = new AppWindow();
            appWindow.DataContext = appWindowViewModel;
            appWindow.Show();
        }
    }
}
