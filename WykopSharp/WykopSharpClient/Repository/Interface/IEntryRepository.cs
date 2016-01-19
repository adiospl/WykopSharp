using System;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Enumerable;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IEntryRepository
    {
        Task<RecivedId> Add(string body);
        Task<RecivedId> Add(string body, Uri embed);
        Task<RecivedId> Add(string body, ByteFile file);
        Task<RecivedId> AddComment(int entryId, string body, Uri embed);
        Task<RecivedId> Delete(int entryId);
        Task<RecivedId> DeleteComment(int entryId, int entryCommentId);
        Task<RecivedId> Edit(int entryId, string body);
        Task<RecivedId> EditComment(int entryId, int entryCommentId, string body);
        Task<UserFavorite> Favorite(int entryId);
        Task<Entry> Index(int entryId);
        Task<RecivedVote> Unvote(EntryType entryType, int entryId, int commentId = 0);
        Task<RecivedVote> Vote(EntryType entryType, int entryId, int commentId = 0);
    }
}