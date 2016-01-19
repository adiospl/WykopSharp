# WykopSharp
Klient API serwisu Wykop.pl dla C# .NET.

# Przykład użycia:
## Wysłanie PM

        private async Task<BooleanResponse> SendMessage(string appKey, string appSecret, string userKey)
        {
            var file = new ByteFile("resource\\test.PNG");

            var test = @"( ͡°( ͡° ͜ʖ( ͡° ͜ʖ ͡°)ʖ ͡°) ͡°)";

            using (var client = WykopSharpClientFactory.Create<WykopSharpClient.WykopSharpClient>(appKey, appSecret, userKey))
            {
                client.Authenticate();

                var result = await client.Conversation.Send("adios", test, file);
                return result;
            }
        }

# Powiązane:
  * [Wykop API dokumentacja]
  * [Newtonson JSON]
  
   [Wykop API dokumentacja]: <http://www.wykop.pl/dla-programistow/api/>
   [Newtonson JSON]: <http://www.newtonsoft.com/json>
   
### Version
not versioned yet ;-)

### Todos
 - Porządek z Modelem
 - Check in unit test
 
