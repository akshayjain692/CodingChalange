using CodingChalange.Helper;
using CodingChalange.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace CodingChalange.Service
{
    public class FileWriterService : IFileWriter
    {
        public async Task WriteToFile(object data)
        {
            try
            {
                await PermissionHelper.RequestStoragePermission();

                var filePath = ((App)(App.Current)).FilePath;
                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                }
                File.WriteAllText(filePath, data.ToString());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
