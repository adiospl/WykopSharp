using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WykopSharp;
using WykopSharp.Interface;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient
{
    public interface IWykopSharpClient : IApiRequestClient
    {
        ICommentRepository Comments { get; }
        IConversationRepository Conversation { get; }
        bool Disposed { get; set; }
        IEntryRepository Entries { get; }
        IFavoritiesRepository Favorities { get; }
        ILinkRepository Link { get; }
        ILinksRepository Links { get; }
        IMyWykopRepository MyWykop { get; }
        IObservatoryRepository Observatory { get; }
        IPopularRepository Popular { get; }
        IProfileRepository Profiles { get; }
        IRankRepository Rank { get; }
        IRelatedRepository Related { get; }
        ISearchRepository Search { get; }
        IStreamRepository Stream { get; }
        ITagRepository Tag { get; }
        ITagsRepository Tags { get; }
        ITopRepository Top { get; }
        IUserRepository User { get; }
        string UserKey { get; set; }

        Login Authenticate();
        Login Authenticate(string login, string password);
        Task<TResult> CallApiMethodWithAuth<TResult>(ApiMethod method, IEnumerable<JsonConverter> converters = null) where TResult : class;
    }
}