using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeMyWykopRepository : IMyWykopRepository
    {
        public Task<List<Notification>> HashTagsNotifications(int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedCount> HashTagsNotificationsCount()
        {
            throw new NotImplementedException();
        }

        public Task<List<IWykopItem>> Index(int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> MarkAsReadNotification(int notificationId)
        {
            throw new NotImplementedException();
        }

        public Task<List<IWykopItem>> Mine(int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> Notifications(int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedCount> NotificationsCount()
        {
            throw new NotImplementedException();
        }

        public Task<List<IWykopItem>> Observing(int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<object> ReadHashTagNotification()
        {
            throw new NotImplementedException();
        }

        public Task<object> ReadNotification()
        {
            throw new NotImplementedException();
        }

        public Task<List<IWykopItem>> Recived(int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<IWykopItem>> Tags(int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<IWykopItem>> Users(int page = 1)
        {
            throw new NotImplementedException();
        }
    }
}
