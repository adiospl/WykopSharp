using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_19")]
    public class TagsRepository : AbstractRepository
    {
        public TagsRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<Tag>> Popular()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Tag>>(
                new ApiMethod(ApiV1Constants.TagsIndex, HttpMethod.Get, parameters)
                );
        }
    }
}