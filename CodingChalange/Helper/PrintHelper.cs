using CodingChalange.Constants;
using CodingChalange.Interfaces;
using CodingChalange.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChalange.Helper
{
    public static class PrintHelper
    {
        public static IPrintOption ResolvePrintOption(string type)
        {
            switch (type)
            {
                case AppConstants.PRINT_TO_FILE:
                    return new FilePrinter();
                case AppConstants.PRINT_TO_PAPER:
                    return new PagePrinter();
                case AppConstants.PRINT_TO_SCREEN:
                    return  new ScreenPrinter();
                default:
                    return null;
            }
        }
    }
}
