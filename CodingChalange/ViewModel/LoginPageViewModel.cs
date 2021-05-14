using CodingChalange.Interfaces;
using CodingChalange.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Xml;
using System.Xml.Linq;
using Xamarin.Forms;

namespace CodingChalange.ViewModel
{
    public class LoginPageViewModel : BaseViewModel
    {
        #region command
        public ICommand LoginCommand { get; private set; }
        #endregion

        #region Properties

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value;  }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value;  }
        }


        #endregion

        #region Field
        
        private IXmlReader Reader;
        private IPageService PageService;

        #endregion

        

        public LoginPageViewModel(IXmlReader xmlReader, IPageService pageService)
        {
            LoginCommand = new Command(Login);
            this.Reader = xmlReader;
            this.PageService = pageService;
        }

        private void Login()
        {
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                PageService.DisplayAlert("Alert", "Enter all Values", "Ok");
                return;
            }

            var customer = Reader.GetCustomerFromUserId(UserName, Password);

            if (customer != null)
            {
                PageService.PushAsync(new OrderPage(customer));
            }
            else
            {
                PageService.DisplayAlert("Error", "Invalid User", "Ok");
            }
        }
    }
}
