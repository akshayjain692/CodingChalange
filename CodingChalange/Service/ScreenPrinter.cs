using CodingChalange.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CodingChalange.Service
{
    public class ScreenPrinter : IPrintOption
    {
        private IPageService PageService;


        public ScreenPrinter()
        {
            PageService = new PageService();
        }
        public void Print(object data)
        {
            PageService.DisplayAlert("Screen Print", "Print Sucessfull", "Cancel");
        }
    }
}
