using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WykopSharp;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Fake;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Fake
{
    public class WykopSharpFakeClient : IWykopSharpClient
    {
        public void Dispose()
        {
            // never dispose
        }

        public Task<TResult> CallApiMethod<TResult>(ApiMethod method, IEnumerable converters = null) where TResult : class
        {
            return null;
        }

        public Task<TResult> CallApiMethod<TResponse, TResult>(ApiMethod method, Func<TResponse, TResult> callback, IEnumerable converters = null) where TResponse : class where TResult : class
        {
            return null;
        }

        public Task<TResult> CallApiMethodWithAuth<TResult>(ApiMethod method, IEnumerable<JsonConverter> converters = null) where TResult : class
        {
            return null;
        }

        public Task<TResult> CallApiMethod<TResult>(ApiMethod method, IEnumerable<JsonConverter> converters = null) where TResult : class
        {
            return null;
        }

        public Task<TResult> CallApiMethod<TResponse, TResult>(ApiMethod method, Func<TResponse, TResult> callback, IEnumerable<JsonConverter> converters = null) where TResponse : class where TResult : class
        {
            return null;
        }

        public Uri GetApiMethodUrl(ApiMethod method)
        {
            return new Uri(method.Url);
        }

        public ICommentRepository Comments { get; } = new FakeCommentRepository();
        public IConversationRepository Conversation { get; } = new FakeConversationRepository();
        public IEntryRepository Entries { get; } = new FakeEntryRepository();
        public IFavoritiesRepository Favorities { get; } = new FakeFavoritiesRepository();
        public ILinkRepository Link { get; } = new FakeLinkRepository();
        public ILinksRepository Links { get; } = new FakeLinksRepository();
        public IMyWykopRepository MyWykop { get; } = new FakeMyWykopRepository();
        public IObservatoryRepository Observatory { get; } = new FakeObservatoryRepository();
        public IPopularRepository Popular { get; } = new FakePopularRepository();
        public IProfileRepository Profiles { get; } = new FakeProfileRepository();
        public IRankRepository Rank { get; } = new FakeRankRepository();
        public IRelatedRepository Related { get; } = new FakeRelatedRepository();
        public ISearchRepository Search { get; } = new FakeSearchRepository();
        public IStreamRepository Stream { get; } = new FakeStreamRepository();
        public ITagRepository Tag { get; } = new FakeTagRepository();
        public ITagsRepository Tags { get; } = new FakeTagsRepository();
        public ITopRepository Top { get; } = new FakeTopRepository();
        public IUserRepository User { get; } = new FakeUserRepository();
        
        public bool Disposed { get; set; }
        public string UserKey { get; set; }

        private Login _fakeLogin => new Login()
        {
            About = "Fake acount",
            Name = "Fake account"
        };

        public Login Authenticate()
        {
            return _fakeLogin;
        }

        public Login Authenticate(string login, string password)
        {
            return _fakeLogin;
        }

    }
}
