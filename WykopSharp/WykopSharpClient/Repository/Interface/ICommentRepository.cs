using System;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface ICommentRepository
    {
        Task<RecivedId> Add(string body, int linkId, int precedentCommentId = -1);
        Task<RecivedId> Add(string body, Uri embed, int linkId, int precedentCommentId = -1);
        Task<RecivedId> Add(string body, ByteFile file, int linkId, int precedentCommentId = -1);
        Task<RecivedId> Delete(int commentId);
        Task<RecivedId> Edit(string body, int commentId);
        Task<RecivedVote> Minus(int linkId, int commentId);
        Task<RecivedVote> Plus(int linkId, int commentId);
    }
}