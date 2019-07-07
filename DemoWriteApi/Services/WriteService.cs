using System;
using DemoWriteApi.Models;
using DemoWriteApi.Repositories;

namespace DemoWriteApi.Services
{
    public class WriteService : IWriteService
    {
        private IRepository repository;

        public WriteService(IRepository repository)
        {
            this.repository = repository;
        }

        public void WriteData(WriteRequest request)
        {
            
            Console.WriteLine(request.Payload ?? "Hello World");
        }
    }
}
