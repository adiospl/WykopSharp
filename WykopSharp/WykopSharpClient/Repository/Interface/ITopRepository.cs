using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface ITopRepository
    {
        Task<List<Link>> Date(DateTime date);
        Task<List<Link>> Date(int year, int month);
        Task<TopYear> Index(int year);
        Task<TopYear> Index(DateTime date);
        Task<List<Link>> RandomHits();
    }
}