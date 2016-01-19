using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_19")]
    public class TagsRepository : AbstractRepository, ITagsRepository
    {
        public TagsRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<PopularTag>> Popular()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<PopularTag>>(
                new ApiMethod(ApiV1Constants.TagsIndex, HttpMethod.Get, parameters)
                );
        }
    }
}