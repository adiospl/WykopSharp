using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeProfileRepository : IProfileRepository
    {
        public Task<List<Link>> Added(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Block(string profileName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Buried(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Commented(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> Comments(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Digged(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entry>> Entries(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<EntryComment>> EntriesComments(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Favorities(string profileName, int listId, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Profile>> Followed(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Profile>> Followers(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> Index(string profileName)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Observe(string profileName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Published(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<RelatedLink>> Related(string profileName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Unblock(string profileName)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Unobserve(string profileName)
        {
            throw new NotImplementedException();
        }
    }
}
