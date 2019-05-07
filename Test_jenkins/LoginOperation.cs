using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WPFUIItems;
using TestStack.White.UIItems.Finders;
using System.Windows.Automation.Text;
using System.Threading;
namespace Test_jenkins
{
 public   class LoginOperation
    {
        private Window window;
        public LoginOperation(string title)
        {
            Driver.instance.WaitForWindow(title);
        }

        public TextBox txtuserName
        {
            get
            {
                return window.Get<TextBox>(SearchCriteria.ByAutomationId("usernameTB"));
            }
        
        }
        public TextBox txtPassword
        {
            get
            {
                return window.Get<TextBox>(SearchCriteria.ByClassName("PasswordBox"));
            }

        }

        public Button okButton
        {
            get { return window.Get<Button>(SearchCriteria.ByText("OK")); } }

        public void Login(string userName,string password)
        {
            try
            {
                txtuserName.SetValue(userName);
                Thread.Sleep(500);
                txtPassword.SetValue(password);
                Thread.Sleep(500);
                okButton.Click();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    }
