using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;


namespace Test_jenkins
{
    class ApplicationDriver
    {

        private Application application;

        public Dictionary<string, Application> appList = new Dictionary<string, Application>();

        private Window window;

        public void LaunchApplication()
        {
            application = Application.Launch(@"C:\Program Files\App\SAP.exe");
            application.WaitWhileBusy();
            appList.Add("1", application);
         }
       
        public Window WaitForWindow(string tile)
        {
            DateTime endTime = DateTime.Now.AddSeconds(30);

            while (DateTime.Now < endTime)
            {
                window = appList["1"].GetWindows().Where(x => x.Title.Contains(tile)).FirstOrDefault();
                if(window.Visible)
                {
                    break;
                    System.Threading.Thread.Sleep(2000);
                }
            }
            return window;
        }

     
    }
}
