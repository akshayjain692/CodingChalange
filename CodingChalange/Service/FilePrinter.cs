using CodingChalange.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChalange.Service
{
    public class FilePrinter : IPrintOption
    {
        private IFileWriter FileWriter;


        public FilePrinter()
        {
            FileWriter = new FileWriterService();
        }

        public void Print(object data)
        {
            FileWriter.WriteToFile(data);
        }
    }
}
