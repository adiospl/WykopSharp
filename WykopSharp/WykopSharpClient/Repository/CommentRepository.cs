using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_1")]
    public class CommentRepository : AbstractRepository
    {
        public CommentRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<RecivedId> Add(string body, Uri embed)
        {
            if (embed == null)
                throw new ArgumentNullException(nameof(embed));
            if (string.IsNullOrWhiteSpace(embed.ToString()))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));

            var parameters = GetApiParameterSet();
            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("body", body),
                new StringPostParameter("embed", embed.ToString())
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.CommentsAdd, HttpMethod.Post, parameters, postParameters)
                );
        }

        public Task<RecivedId> Add(string body, ByteFile file)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));
            if (String.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));

            var parameters = GetApiParameterSet();
            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("body", body),
                new BytePostParameter("embed", file)
            };
            
            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.CommentsAdd, HttpMethod.Post, parameters, postParameters)
                );
        }

        public Task<RecivedVote> Plus(int linkId, int commentId)
        {
            if (commentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(commentId));
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId),
                new StringMethodParameter("param2", commentId)
            };

            return Client.CallApiMethodWithAuth<RecivedVote>(
                new ApiMethod(ApiV1Constants.CommentsPlus, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<RecivedVote> Minus(int linkId, int commentId)
        {
            if (commentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(commentId));
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId),
                new StringMethodParameter("param2", commentId)
            };

            return Client.CallApiMethodWithAuth<RecivedVote>(
                new ApiMethod(ApiV1Constants.CommentsMinus, HttpMethod.Get, parameters, methodParameters)
                );
        }
        
        public Task<RecivedId> Edit(string body, int commentId)
        {
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));
            if (commentId <= 0) throw new ArgumentOutOfRangeException(nameof(commentId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", commentId)
            };

            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("body", body)
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.CommentsEdit, HttpMethod.Post, parameters, methodParameters, postParameters)
                );
        }

        public Task<RecivedId> Delete(int commentId)
        {
            if (commentId <= 0) throw new ArgumentOutOfRangeException(nameof(commentId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", commentId)
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.CommentsDelete, HttpMethod.Get, parameters, methodParameters)
                );
        }
    }
}