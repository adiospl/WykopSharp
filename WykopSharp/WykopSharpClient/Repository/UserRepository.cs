﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_7")]
    public class UserRepository : AbstractRepository, IUserRepository
    {
        public UserRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<Login> Login(string accountKey)
        {
            if (string.IsNullOrWhiteSpace(accountKey))
                throw new ArgumentException("Argument is null or whitespace", nameof(accountKey));

            var parameters = new HashSet<ApiParameter>();
            var postParameters = new SortedSet<PostParameter> {new StringPostParameter("accountkey", accountKey)};

            return Client.CallApiMethod<Login>(
                new ApiMethod(ApiV1Constants.UserLogin, HttpMethod.Post, parameters, postParameters)
                );
        }

        public Task<Login> Login(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("Argument is null or whitespace", nameof(login));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Argument is null or whitespace", nameof(password));

            var parameters = new HashSet<ApiParameter>();
            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("login", login),
                new StringPostParameter("password", password)
            };

            return Client.CallApiMethod<Login>(
                new ApiMethod(ApiV1Constants.UserLogin, HttpMethod.Post, parameters, postParameters)
                );
        }

        public Task<List<Link>> Favorities()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.UserFavorites, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Link>> Observed()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.UserObserved, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Tag>> Tags()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Tag>>(
                new ApiMethod(ApiV1Constants.UserTags, HttpMethod.Get, parameters)
                );
        }

        [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_7_5")]
        public Task<HtmlResponse> Connect()
        {
            var parameters = new HashSet<ApiParameter>();
            
            return Client.CallApiMethod<HtmlResponse>(
                new ApiMethod(ApiV1Constants.UserConnect, HttpMethod.Post, parameters)
                );
        }
    }
}