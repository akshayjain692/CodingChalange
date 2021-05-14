using CodingChalange.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CodingChalange.Service
{
    public class PageService : IPageService
    {
        public Task<string> DisplayActionSheet(string title, string cancel, string destruction, FlowDirection flowDirection, params string[] buttons)
        {
            return Application.Current.MainPage.DisplayActionSheet(title, cancel, destruction, flowDirection, buttons);
        }

        public Task<string> DisplayActionSheet(string title, string cancel, string destruction, params string[] buttons)
        {
            return Application.Current.MainPage.DisplayActionSheet(title, cancel, destruction, buttons);
        }

        public Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }

        public void DisplayAlert(string title, string message, string ok)
        {
            Application.Current.MainPage.DisplayAlert(title, message, ok);
        }

        public Task PopPageAsync()
        {
            return Application.Current.MainPage.Navigation.PopAsync();
        }

        public Task PushAsync(Page page)
        {
            return Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
