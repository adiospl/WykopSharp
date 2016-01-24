using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WykopSharp;
using WykopSharp.Exceptions;
using WykopSharp.Interface;
using WykopSharpClient.Model;
using WykopSharpClient.Repository;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient
{
    public class WykopSharpClient : ApiRequestClient, IWykopSharpClient
    {
        private readonly Lazy<ICommentRepository> _comments;
        private readonly Lazy<IConversationRepository> _conversationRepository;
        private readonly Lazy<IEntryRepository> _entries;
        private readonly Lazy<IFavoritiesRepository> _favoritiesRepository;
        private readonly Lazy<ILinkRepository> _link;
        private readonly Lazy<ILinksRepository> _links;
        private readonly Lazy<IMyWykopRepository> _myWykop;
        private readonly Lazy<IObservatoryRepository> _observatoryRepository;
        private readonly Lazy<IPopularRepository> _popular;
        private readonly Lazy<IProfileRepository> _profile;
        private readonly Lazy<IRankRepository> _rankRepository;
        private readonly Lazy<IRelatedRepository> _related;
        private readonly Lazy<ISearchRepository> _search;
        private readonly Lazy<IStreamRepository> _streamRepository;
        private readonly Lazy<ITagRepository> _tagRepository;
        private readonly Lazy<ITagsRepository> _tagsRepository;
        private readonly Lazy<ITopRepository> _topRepository;
        
        private string _userKey;
        private bool _disposed;

        public WykopSharpClient(string appKey, string appSecret, string accountKey = null)
            : base(appKey, appSecret, accountKey)
        {
            User =                     new UserRepository(this);
            _entries =                  new Lazy<IEntryRepository>(() => new EntryRepository(this));
            _comments =                 new Lazy<ICommentRepository>(() => new CommentRepository(this));
            _profile =                  new Lazy<IProfileRepository>(() => new ProfileRepository(this));
            _link =                     new Lazy<ILinkRepository>(() => new LinkRepository(this));
            _links =                    new Lazy<ILinksRepository>(() => new LinksRepository(this));
            _popular =                  new Lazy<IPopularRepository>(() => new PopularRepository(this));
            _search =                   new Lazy<ISearchRepository>(() => new SearchRepository(this));
            _related =                  new Lazy<IRelatedRepository>(() => new RelatedRepository(this));
            _myWykop =                  new Lazy<IMyWykopRepository>(() => new MyWykopRepository(this));
            _rankRepository =           new Lazy<IRankRepository>(() => new RankRepository(this));
            _observatoryRepository =    new Lazy<IObservatoryRepository>(() => new ObservatoryRepository(this));
            _favoritiesRepository =     new Lazy<IFavoritiesRepository>(() => new FavoritiesRepository(this));
            _streamRepository =         new Lazy<IStreamRepository>(() => new StreamRepository(this));
            _tagRepository =            new Lazy<ITagRepository>(() => new TagRepository(this));
            _conversationRepository =   new Lazy<IConversationRepository>(() => new ConversationRepository(this));
            _tagsRepository =           new Lazy<ITagsRepository>(() => new TagsRepository(this));
            _topRepository =            new Lazy<ITopRepository>(() => new TopRepository(this));
        }

        public bool Disposed
        {
            set { _disposed = value; }
            get { return _disposed; }
        }

        public string UserKey
        {
            set { _userKey = value; }
            get { return _userKey; }
        }

        protected override void Dispose(bool disposing)
        {
            _disposed = true;
            base.Dispose();
        }

        public Login Authenticate()
        {
            var result = User.Login(AccountKey).Result;
            _userKey = result.Userkey;
            return result;
        }

        public Login Authenticate(string login, string password)
        {
            var result = User.Login(AccountKey).Result;
            _userKey = result.Userkey;
            return result;
        }
        
        public async Task<TResult> CallApiMethodWithAuth<TResult>(ApiMethod method, IEnumerable<JsonConverter> converters = null)
            where TResult : class
        {
            var retries = 0;
            while (true)
            {
                try
                {
                    return await CallApiMethod<TResult>(method, converters);
                }
                catch (AuthorizationException)
                {
                    retries++;
                    method.ApiParameters.RemoveWhere(p => p.Name == "userkey");

                    Authenticate();
                    method.ApiParameters.Add(new ApiParameter("userkey", _userKey));

                    if (retries == 2)
                    {
                        throw new NotAbleToReauthorizateException();
                    }
                }

                await Task.Delay(500);
            }
        }

        #region Repositories

        public IUserRepository User { get; }
        public IEntryRepository Entries              => _entries.Value;
        public ICommentRepository Comments           => _comments.Value;
        public IProfileRepository Profiles           => _profile.Value;
        public ILinkRepository Link                  => _link.Value;
        public ILinksRepository Links                => _links.Value;
        public IPopularRepository Popular            => _popular.Value;
        public ISearchRepository Search              => _search.Value;
        public IRelatedRepository Related            => _related.Value;
        public IMyWykopRepository MyWykop            => _myWykop.Value;
        public IRankRepository Rank                  => _rankRepository.Value;
        public IObservatoryRepository Observatory    => _observatoryRepository.Value;
        public IFavoritiesRepository Favorities      => _favoritiesRepository.Value;
        public IStreamRepository Stream              => _streamRepository.Value;
        public ITagRepository Tag                    => _tagRepository.Value;
        public IConversationRepository Conversation  => _conversationRepository.Value;
        public ITagsRepository Tags                  => _tagsRepository.Value;
        public ITopRepository Top                    => _topRepository.Value;

        #endregion
    }
}