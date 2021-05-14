using CodingChalange.Constants;
using CodingChalange.Helper;
using CodingChalange.Interfaces;
using CodingChalange.Model;
using CodingChalange.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CodingChalange.ViewModel
{
    public class OrderPageViewModel : BaseViewModel
    {
        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; OnPropertyChanged(); }
        }


        private string _discount;

        public string Discount
        {
            get { return _discount; }
            set { _discount = value; OnPropertyChanged(); }
        }


        private string _perGramPrice;

        public string PerGramPrice
        {
            get { return _perGramPrice; }
            set { _perGramPrice = value; OnPropertyChanged(); }
        }

        private string _weightInGrams;

        public string WeightGrams
        {
            get { return _weightInGrams; }
            set { _weightInGrams = value; OnPropertyChanged(); }
        }


        private string _total;

        public string Total
        {
            get { return _total; }
            set { _total = value; OnPropertyChanged(); }
        }


        public ICommand CalculateCommand { get; private set; }

        private IPageService PageService;

        public ICommand PrintCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }
        public OrderPageViewModel(Customer customer, IPageService pageService)
        {
            this.Customer = customer;
            ApplyDiscount();
            CalculateCommand = new Command(CalculateTotal);
            PrintCommand = new Command(async () => await ShowPrintOptions());
            CloseCommand = new Command(CloseApplication);
            this.PageService = pageService;
        }

        private void CloseApplication()
        {
            Process.GetCurrentProcess().Kill();
        }

        private async Task ShowPrintOptions()
        {
            var result = await PageService.DisplayActionSheet("Print Options", AppConstants.CANCEL, null, AppConstants.PRINT_TO_FILE, AppConstants.PRINT_TO_PAPER, AppConstants.PRINT_TO_SCREEN);
            PrintHelper.ResolvePrintOption(result).Print(Customer);
        }

        private void ApplyDiscount()
        {
            if (Customer.IsGoldCustomer)
                Discount = "2";
            else
                Discount = "0";
        }


        private void CalculateTotal()
        {
            var totalPrice = ConvertToDouble(WeightGrams) * ConvertToDouble(PerGramPrice);
            var discountPrice = (double)totalPrice * (ConvertToDouble(Discount) / 100.0);
            Total = (totalPrice - discountPrice).ToString("F2");
        }


        private double ConvertToDouble(string value)
        {
            double.TryParse(value, out double result);
            return result;
        }
    }
}
