using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_18")]
    public class ConversationRepository : AbstractRepository
    {
        public ConversationRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<ConversationList> List()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<ConversationList>(
                new ApiMethod(ApiV1Constants.PmConversationsList, HttpMethod.Get, parameters)
                );
        }

        public Task<List<PmMessage>> Show(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Argument is null or whitespace", nameof(username));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", username)
            };
            
            return Client.CallApiMethodWithAuth<List<PmMessage>>(
                new ApiMethod(ApiV1Constants.PmConversationsList, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanResponse> Delete(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Argument is null or whitespace", nameof(username));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", username)
            };
            
            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.PmDeleteConversation, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanResponse> Send(string username, string body, string embed = null)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Argument is null or whitespace", nameof(username));
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", username)
            };
            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("body", body)
            };
            if (!string.IsNullOrWhiteSpace(embed))
                postParameters.Add(new StringPostParameter("embed", embed));
            
            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.PmSendMessage, HttpMethod.Post, parameters, methodParameters,
                    postParameters)
                );
        }

        public Task<BooleanResponse> Send(string username, string body, ByteFile file)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Argument is null or whitespace", nameof(username));
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentException("Argument is null or whitespace", nameof(body));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", username)
            };
            var postParameters = new SortedSet<PostParameter>
            {
                new StringPostParameter("body", body),
                new BytePostParameter("embed", file)
            };
            
            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.PmSendMessage, HttpMethod.Post, parameters, methodParameters,
                    postParameters)
                );
        }
    }
}