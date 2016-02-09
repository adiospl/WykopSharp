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
    public class FakeLinkRepository : ILinkRepository
    {
        public Task<DigModel> Bury(int linkId, int buryReason)
        {
            throw new NotImplementedException();
        }

        public Task<List<BuryReason>> BuryReasons()
        {
            throw new NotImplementedException();
        }

        public Task<DigModel> Cancel(int linkId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> Comments(int linkId)
        {
            throw new NotImplementedException();
        }

        public Task<DigModel> Dig(int linkId)
        {
            throw new NotImplementedException();
        }

        public Task<DigModel> Digs(int linkId)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Favorite(int linkId)
        {
            throw new NotImplementedException();
        }

        public Task<Link> Index(int linkId)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Observe(int linkId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RelatedLink>> Related(int linkId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Bury>> Reports(int linkId)
        {
            throw new NotImplementedException();
        }
    }
}
