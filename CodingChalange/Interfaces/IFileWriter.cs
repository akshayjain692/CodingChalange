using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingChalange.Interfaces
{
    public interface IFileWriter
    {
        Task WriteToFile(object data);
    }
}
