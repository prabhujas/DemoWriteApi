using System;
using DemoWriteApi.Models;

namespace DemoWriteApi.Services
{
    public interface IWriteService
    {
        void WriteData(WriteRequest request);
    }
}
