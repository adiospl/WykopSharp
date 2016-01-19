using System;
using System.Threading.Tasks;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IUserRepository : IRepository
    {
        Task<Login> Login(string accountKey);
        Task<Login> Login(string login, string password);
        Uri Connect();
        Uri Connect(Uri redirectUrl, string appSecret);
    }
}