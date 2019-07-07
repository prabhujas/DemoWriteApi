using System;
using DemoWriteApi.Models;

namespace DemoWriteApi.Services
{
    public class WriteService : IWriteService
    {
     
        public void PostData(WriteRequest request)
        {
            Console.WriteLine(request.Payload);
        }
    }
}
