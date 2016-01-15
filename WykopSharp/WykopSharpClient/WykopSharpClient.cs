using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WykopSharp;
using WykopSharp.Exceptions;
using WykopSharpClient.Model;
using WykopSharpClient.Repository;

namespace WykopSharpClient
{
    public class WykopSharpClient : ApiRequestClient
    {
        private readonly Lazy<CommentRepository> _comments;
        private readonly Lazy<ConversationRepository> _conversationRepository;
        private readonly Lazy<EntryRepository> _entries;
        private readonly Lazy<FavoritiesRepository> _favoritiesRepository;
        private readonly Lazy<LinkRepository> _link;
        private readonly Lazy<LinksRepository> _links;
        private readonly Lazy<MyWykopRepository> _myWykop;
        private readonly Lazy<ObservatoryRepository> _observatoryRepository;
        private readonly Lazy<PopularRepository> _popular;
        private readonly Lazy<ProfileRepository> _profile;
        private readonly Lazy<RankRepository> _rankRepository;
        private readonly Lazy<RelatedRepository> _related;
        private readonly Lazy<SearchRepository> _search;
        private readonly Lazy<StreamRepository> _streamRepository;
        private readonly Lazy<TagRepository> _tagRepository;
        private readonly Lazy<TagsRepository> _tagsRepository;
        private readonly Lazy<TopRepository> _topRepository;
        
        private string _userKey;
        private bool _disposed;

        public WykopSharpClient(string appKey, string appSecret, string accountKey = null)
            : base(appKey, appSecret, accountKey)
        {
            User =                     new UserRepository(this);
            _entries =                  new Lazy<EntryRepository>(() => new EntryRepository(this));
            _comments =                 new Lazy<CommentRepository>(() => new CommentRepository(this));
            _profile =                  new Lazy<ProfileRepository>(() => new ProfileRepository(this));
            _link =                     new Lazy<LinkRepository>(() => new LinkRepository(this));
            _links =                    new Lazy<LinksRepository>(() => new LinksRepository(this));
            _popular =                  new Lazy<PopularRepository>(() => new PopularRepository(this));
            _search =                   new Lazy<SearchRepository>(() => new SearchRepository(this));
            _related =                  new Lazy<RelatedRepository>(() => new RelatedRepository(this));
            _myWykop =                  new Lazy<MyWykopRepository>(() => new MyWykopRepository(this));
            _rankRepository =           new Lazy<RankRepository>(() => new RankRepository(this));
            _observatoryRepository =    new Lazy<ObservatoryRepository>(() => new ObservatoryRepository(this));
            _favoritiesRepository =     new Lazy<FavoritiesRepository>(() => new FavoritiesRepository(this));
            _streamRepository =         new Lazy<StreamRepository>(() => new StreamRepository(this));
            _tagRepository =            new Lazy<TagRepository>(() => new TagRepository(this));
            _conversationRepository =   new Lazy<ConversationRepository>(() => new ConversationRepository(this));
            _tagsRepository =           new Lazy<TagsRepository>(() => new TagsRepository(this));
            _topRepository =            new Lazy<TopRepository>(() => new TopRepository(this));
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
                catch (AuthenticationException)
                {
                    retries++;
                    Authenticate();

                    if (retries == 2)
                    {
                        throw new NotAbleToReauthorizateException();
                    }
                }

                await Task.Delay(500);
            }
        }

        #region Repositories

        public UserRepository User { get; }
        public EntryRepository Entries              => _entries.Value;
        public CommentRepository Comments           => _comments.Value;
        public ProfileRepository Profiles           => _profile.Value;
        public LinkRepository Link                  => _link.Value;
        public LinksRepository Links                => _links.Value;
        public PopularRepository Popular            => _popular.Value;
        public SearchRepository Search              => _search.Value;
        public RelatedRepository Related            => _related.Value;
        public MyWykopRepository MyWykop            => _myWykop.Value;
        public RankRepository Rank                  => _rankRepository.Value;
        public ObservatoryRepository Observatory    => _observatoryRepository.Value;
        public FavoritiesRepository Favorities      => _favoritiesRepository.Value;
        public StreamRepository Stream              => _streamRepository.Value;
        public TagRepository Tag                    => _tagRepository.Value;
        public ConversationRepository Conversation  => _conversationRepository.Value;
        public TagsRepository Tags                  => _tagsRepository.Value;
        public TopRepository Top                    => _topRepository.Value;

        #endregion
    }
}