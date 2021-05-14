using CodingChalange.Model;
using CodingChalange.Service;
using CodingChalange.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CodingChalange.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage(Customer customer)
        {
            InitializeComponent();
            this.BindingContext = new OrderPageViewModel(customer,  new PageService());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}