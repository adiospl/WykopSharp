using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Enumerable;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_12")]
    public class EntryRepository : AbstractRepository
    {
        public EntryRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<Entry> Index(int entryId)
        {
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", entryId)
            };

            return Client.CallApiMethodWithAuth<Entry>(
                new ApiMethod(ApiV1Constants.EntriesIndex, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<RecivedId> Add(string body)
        {
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));

            var parameters = GetApiParameterSet();
            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("accountkey", Client.AccountKey),
                new StringPostParameter("body", body),
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.EntriesAdd, HttpMethod.Post, parameters, postParameters)
                );
        }

        public Task<RecivedId> Add(string body, Uri embed)
        {
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));
            if (embed == null)
                throw new ArgumentNullException(nameof(embed));
            if (string.IsNullOrWhiteSpace(embed.ToString()))
                throw new ArgumentException("Argument is null or whitespace", nameof(embed));

            var parameters = GetApiParameterSet();
            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("accountkey", Client.AccountKey),
                new StringPostParameter("body", body),
                new StringPostParameter("embed", embed.ToString())
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.EntriesAdd, HttpMethod.Post, parameters, postParameters)
                );
        }

        public Task<RecivedId> Add(string body, ByteFile file)
        {
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));
            if (file == null) throw new ArgumentNullException(nameof(file));

            var parameters = GetApiParameterSet();
            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("accountkey", Client.AccountKey),
                new StringPostParameter("body", body),
                new BytePostParameter("embed", file)
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.EntriesAdd, HttpMethod.Post, parameters, postParameters)
                );
        }

        public Task<RecivedId> Edit(int entryId, string body)
        {
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", entryId)
            };

            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("accountkey", Client.AccountKey),
                new StringPostParameter("body", body)
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.EntriesEdit, HttpMethod.Post, parameters, methodParameters, postParameters)
                );
        }

        public Task<RecivedId> Delete(int entryId)
        {
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", entryId)
            };

            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("accountkey", Client.AccountKey)
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.EntriesDelete, HttpMethod.Post, parameters, methodParameters,
                    postParameters)
                );
        }

        public Task<RecivedId> AddComment(int entryId, string body, Uri embed)
        {
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));
            if (embed == null)
                throw new ArgumentNullException(nameof(embed));
            if (string.IsNullOrWhiteSpace(embed.ToString()))
                throw new ArgumentException("Argument is null or whitespace", nameof(embed));
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", entryId)
            };

            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("accountkey", Client.AccountKey),
                new StringPostParameter("body", body),
                new StringPostParameter("embed", embed.ToString())
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.EntriesAddComment, HttpMethod.Post, parameters, methodParameters, postParameters)
                );
        }

        public Task<RecivedId> EditComment(int entryId, int entryCommentId, string body)
        {
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));
            if (entryCommentId <= 0) throw new ArgumentOutOfRangeException(nameof(entryCommentId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", entryId),
                new StringMethodParameter("param2", entryCommentId)
            };

            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("accountkey", Client.AccountKey),
                new StringPostParameter("body", body)
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.EntriesEditComment, HttpMethod.Post, parameters, methodParameters,
                    postParameters)
                );
        }

        public Task<RecivedId> DeleteComment(int entryId, int entryCommentId)
        {
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));
            if (entryCommentId <= 0) throw new ArgumentOutOfRangeException(nameof(entryCommentId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", entryId),
                new StringMethodParameter("param2", entryCommentId)
            };

            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("accountkey", Client.AccountKey)
            };

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.EntriesDeleteComment, HttpMethod.Post, parameters, methodParameters,
                    postParameters)
                );
        }

        public Task<RecivedVote> Vote(EntryType entryType, int entryId, int commentId = 0)
        {
            if (!Enum.IsDefined(typeof (EntryType), entryType))
                throw new ArgumentOutOfRangeException(nameof(entryType));
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", entryType.ToString()),
                new StringMethodParameter("param2", entryId)
            };
            if (entryType == EntryType.Comment && commentId != 0)
            {
                methodParameters.Add(new StringMethodParameter("param3", commentId));
            }

            return Client.CallApiMethodWithAuth<RecivedVote>(
                new ApiMethod(ApiV1Constants.EntriesVote, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<RecivedVote> Unvote(EntryType entryType, int entryId, int commentId = 0)
        {
            if (!Enum.IsDefined(typeof (EntryType), entryType))
                throw new ArgumentOutOfRangeException(nameof(entryType));
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", entryType.ToString()),
                new StringMethodParameter("param2", entryId)
            };
            if (entryType == EntryType.Comment && commentId != 0)
            {
                methodParameters.Add(new StringMethodParameter("param3", commentId));
            }

            return Client.CallApiMethodWithAuth<RecivedVote>(
                new ApiMethod(ApiV1Constants.EntriesUnvote, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanResponse> Favorite(int entryId)
        {
            if (entryId <= 0) throw new ArgumentOutOfRangeException(nameof(entryId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", entryId)
            };

            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.EntriesFavorite, HttpMethod.Get, parameters, methodParameters)
                );
        }
    }
}