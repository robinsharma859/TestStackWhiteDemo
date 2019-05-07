using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace Test_jenkins
{
    class Driver :ApplicationDriver
    {
        private static Driver _driver=null;
        private static string Title;
        private Driver()
        {

        }
      
        
        public static Driver instance
        {
            get
            {
                if(_driver!=null)
                {
                    return _driver;
                }
                else
                {
                    _driver =  new Driver();
                    return _driver;
                }
            }
        }

    }
}
