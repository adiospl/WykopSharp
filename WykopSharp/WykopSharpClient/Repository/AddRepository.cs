using System;

namespace WykopSharpClient.Repository
{
    [Obsolete]
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_9")]
    public class AddRepository : AbstractRepository
    {
        public AddRepository(WykopSharpClient client) : base(client)
        {
        }
    }
}