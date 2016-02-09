using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IMyWykopRepository
    {
        Task<List<Notification>> HashTagsNotifications(int page = 1);
        Task<RecivedCount> HashTagsNotificationsCount();
        Task<List<MyWykop>> Index(int page = 1);
        Task<BooleanModel> MarkAsReadNotification(int notificationId);
        Task<List<MyWykop>> Mine(int page = 1);
        Task<List<Notification>> Notifications(int page = 1);
        Task<RecivedCount> NotificationsCount();
        Task<List<MyWykop>> Observing(int page = 1);
        Task<object> ReadHashTagNotification();
        Task<object> ReadNotification();
        Task<List<MyWykop>> Recived(int page = 1);
        Task<List<MyWykop>> Tags(int page = 1);
        Task<List<MyWykop>> Users(int page = 1);
    }
}