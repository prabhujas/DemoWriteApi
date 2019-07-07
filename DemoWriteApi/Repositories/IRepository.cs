using System;
namespace DemoWriteApi.Repositories
{
    public interface IRepository
    {
        void Save(string payload);
    }
}
