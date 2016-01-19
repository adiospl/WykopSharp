using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Enumerable;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeEntryRepository : IEntryRepository
    {
        public Task<RecivedId> Add(string body)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> Add(string body, Uri embed)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> Add(string body, ByteFile file)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> AddComment(int entryId, string body, Uri embed)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> Delete(int entryId)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> DeleteComment(int entryId, int entryCommentId)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> Edit(int entryId, string body)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> EditComment(int entryId, int entryCommentId, string body)
        {
            throw new NotImplementedException();
        }

        public Task<UserFavorite> Favorite(int entryId)
        {
            throw new NotImplementedException();
        }

        public Task<Entry> Index(int entryId)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedVote> Unvote(EntryType entryType, int entryId, int commentId = 0)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedVote> Vote(EntryType entryType, int entryId, int commentId = 0)
        {
            throw new NotImplementedException();
        }
    }
}
