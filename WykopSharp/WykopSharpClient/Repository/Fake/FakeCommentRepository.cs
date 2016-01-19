using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeCommentRepository : ICommentRepository
    {
        public Task<RecivedId> Add(string body, int linkId, int precedentCommentId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> Add(string body, Uri embed, int linkId, int precedentCommentId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> Add(string body, ByteFile file, int linkId, int precedentCommentId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> Delete(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedId> Edit(string body, int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedVote> Minus(int linkId, int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedVote> Plus(int linkId, int commentId)
        {
            throw new NotImplementedException();
        }
    }
}
