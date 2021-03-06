﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface ITagRepository
    {
        Task<BooleanModel> Block(string tagName);
        Task<Tag> Entries(string tagName, int page = 1);
        Task<Tag> Index(string tagName, int page = 1);
        Task<Tag> Links(string tagName, int page = 1);
        Task<BooleanModel> Observe(string tagName);
        Task<BooleanModel> Unblock(string tagName);
        Task<BooleanModel> Unobserve(string tagName);
    }
}