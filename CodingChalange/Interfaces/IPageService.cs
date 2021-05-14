using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CodingChalange.Interfaces
{
    public interface IPageService
    {
        Task PushAsync(Page page);

        Task PopPageAsync();

        Task<bool> DisplayAlert(string title, string message, string ok, string cancel);

        void DisplayAlert(string title, string message, string ok);

        Task<string> DisplayActionSheet(string title, string cancel, string destruction, FlowDirection flowDirection, params string[] buttons);
        Task<string> DisplayActionSheet(string title, string cancel, string destruction, params string[] buttons);
    }
}
