using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_11")]
    public class MyWykopRepository : AbstractRepository, IMyWykopRepository
    {
        public MyWykopRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<IWykopItem>> Index(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<IWykopItem>>(
                new ApiMethod(ApiV1Constants.MyWykopIndex, HttpMethod.Get, parameters),
                new List<Newtonsoft.Json.JsonConverter>() { new WykopItemArrayTypeConverter() }
                );
        }

        public Task<List<IWykopItem>> Tags(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<IWykopItem>>(
                new ApiMethod(ApiV1Constants.MyWykopTags, HttpMethod.Get, parameters),
                new List<Newtonsoft.Json.JsonConverter>() { new WykopItemArrayTypeConverter() }
                );
        }

        public Task<List<IWykopItem>> Users(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<IWykopItem>>(
                new ApiMethod(ApiV1Constants.MyWykopUsers, HttpMethod.Get, parameters),
                new List<Newtonsoft.Json.JsonConverter>() { new WykopItemArrayTypeConverter() }
                );
        }

        [Obsolete]
        public Task<List<IWykopItem>> Observing(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<IWykopItem>>(
                new ApiMethod(ApiV1Constants.MyWykopObserving, HttpMethod.Get, parameters),
                new List<Newtonsoft.Json.JsonConverter>() { new WykopItemArrayTypeConverter() }
                );
        }

        [Obsolete]
        public Task<List<IWykopItem>> Mine(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<IWykopItem>>(
                new ApiMethod(ApiV1Constants.MyWykopMine, HttpMethod.Get, parameters),
                new List<Newtonsoft.Json.JsonConverter>() { new WykopItemArrayTypeConverter() }
                );
        }

        [Obsolete]
        public Task<List<IWykopItem>> Recived(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<IWykopItem>>(
                new ApiMethod(ApiV1Constants.MyWykopReceived, HttpMethod.Get, parameters),
                new List<Newtonsoft.Json.JsonConverter>() { new WykopItemArrayTypeConverter() }
                );
        }

        public Task<List<Notification>> Notifications(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));
            
            return Client.CallApiMethodWithAuth<List<Notification>>(
                new ApiMethod(ApiV1Constants.MyWykopNotifications, HttpMethod.Get, parameters)
                );
        }

        public Task<RecivedCount> NotificationsCount()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<RecivedCount>(
                new ApiMethod(ApiV1Constants.MyWykopNotificationsCount, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Notification>> HashTagsNotifications(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<Notification>>(
                new ApiMethod(ApiV1Constants.MyWykopHashTagsNotifications, HttpMethod.Get, parameters)
                );
        }

        public Task<RecivedCount> HashTagsNotificationsCount()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<RecivedCount>(
                new ApiMethod(ApiV1Constants.MyWykopHashTagsNotificationsCount, HttpMethod.Get, parameters)
                );
        }

        public Task<object> ReadNotification()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<object>(
                new ApiMethod(ApiV1Constants.MyWykopReadNotifications, HttpMethod.Get, parameters)
                );
        }

        public Task<object> ReadHashTagNotification()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<object>(
                new ApiMethod(ApiV1Constants.MyWykopReadHashTagsNotifications, HttpMethod.Get, parameters)
                );
        }

        public Task<BooleanModel> MarkAsReadNotification(int notificationId)
        {
            if (notificationId <= 0) throw new ArgumentOutOfRangeException(nameof(notificationId));
            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", notificationId)
            };

            return Client.CallApiMethodWithAuth<BooleanModel>(
                new ApiMethod(ApiV1Constants.MyWykopMarkAsReadNotification, HttpMethod.Get, parameters, methodParameters)
                );
        }
    }
}