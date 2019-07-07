using System;
using DemoWriteApi.Models;

namespace DemoWriteApi.Services
{
    public class WriteService : IWriteService
    {

        public void WriteData(WriteRequest request)
        {
            
            Console.WriteLine(request.Payload ?? "Hello World");
        }
    }
}
