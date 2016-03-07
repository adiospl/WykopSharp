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
        Task<List<IWykopItem>> Index(int page = 1);
        Task<BooleanModel> MarkAsReadNotification(int notificationId);
        Task<List<IWykopItem>> Mine(int page = 1);
        Task<List<Notification>> Notifications(int page = 1);
        Task<RecivedCount> NotificationsCount();
        Task<List<IWykopItem>> Observing(int page = 1);
        Task<object> ReadHashTagNotification();
        Task<object> ReadNotification();
        Task<List<IWykopItem>> Recived(int page = 1);
        Task<List<IWykopItem>> Tags(int page = 1);
        Task<List<IWykopItem>> Users(int page = 1);
    }
}