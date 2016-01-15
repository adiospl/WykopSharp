using System;

namespace WykopSharpClient
{
    public static class ApiV1Constants
    {
        #region ADD

        [Obsolete("Add/Index is deprecated.")] public const string AddIndex = "Add/Index";

        #endregion

        #region TAGS

        public const string TagsIndex = "Tags/Index";

        #endregion

        #region COMMENTS

        public const string CommentsAdd = "Comments/Add";
        public const string CommentsPlus = "Comments/Plus";
        public const string CommentsMinus = "Comments/Minus";
        public const string CommentsEdit = "Comments/Edit";
        public const string CommentsDelete = "Comments/Delete";

        #endregion

        #region LINK

        public const string LinkIndex = "Link/Index";
        public const string LinkDig = "Link/Dig";
        public const string LinkCancel = "Link/Cancel";
        public const string LinkBury = "Link/Bury";
        public const string LinkComments = "Link/Comments";
        public const string LinkReports = "Link/Reports";
        public const string LinkDigs = "Link/Digs";
        public const string LinkRelated = "Link/Related";
        public const string LinkObserve = "Link/Observe";
        public const string LinkFavorite = "Link/Favorite";
        public const string LinkBuryreasons = "Link/Buryreasons";

        #endregion

        #region LINKS

        public const string LinksPromoted = "Links/Promoted";
        public const string LinksUpcomming = "Links/Upcomming";

        #endregion

        #region POPULAR

        public const string PopularPromoted = "Popular/Promoted";
        public const string PopularUpcomming = "Popular/Upcomming";

        #endregion

        #region PROFILE

        // GET
        public const string ProfileIndex = "Profile/Index";
        public const string ProfileAdded = "Profile/Added";
        public const string ProfilePublished = "Profile/Published";
        public const string ProfileCommented = "Profile/Commented";
        public const string ProfileComments = "Profile/Comments";
        public const string ProfileDigged = "Profile/Digged";
        public const string ProfileBuried = "Profile/Buried";
        public const string ProfileFollowers = "Profile/Followers";
        public const string ProfileFollowed = "Profile/Followed";
        public const string ProfileFavorites = "Profile/Favorites";
        public const string ProfileEntries = "Profile/Entries";
        public const string ProfileEntriesComments = "Profile/EntriesComments";
        public const string ProfileRelatedLinks = "Profile/RelatedQuery";

        // POST
        public const string ProfileObserve = "Profile/Observe";
        public const string ProfileUnobserve = "Profile/Unobserve";
        public const string ProfileBlock = "Profile/Block";
        public const string ProfileUnblock = "Profile/Unblock";

        #endregion

        #region SEARCH

        public const string SearchIndex = "Search/Index";
        public const string SearchLinks = "Search/Links";
        public const string SearchEntries = "Search/Entries";
        public const string SearchProfiles = "Search/Profiles";

        #endregion

        #region USER

        public const string UserLogin = "User/Login"; // input login, password, response apikey
        public const string UserFavorites = "User/Favorites";
        public const string UserObserved = "User/Observed";
        public const string UserTags = "User/Tags";
        public const string UserConnect = "User/Connect";

        #endregion

        #region TOP

        public const string TopIndex = "Top/Index";
        public const string TopDate = "Top/Date";
        public const string TopHits = "Top/Hits";

        #endregion

        #region RELATED

        public const string RelatedPlus = "Related/Plus";
        public const string RelatedMinus = "Related/Minus";
        public const string RelatedAdd = "Related/Add";

        #endregion

        #region MYWYKOP

        public const string MyWykopIndex = "Mywykop/Index";
        public const string MyWykopTags = "Mywykop/Tags";
        public const string MyWykopUsers = "Mywykop/Users";

        [Obsolete("Mywykop/Observing is deprecated.")] public const string MyWykopObserving = "Mywykop/Observing";

        [Obsolete("Mywykop/Mine is deprecated.")] public const string MyWykopMine = "Mywykop/Mine";

        [Obsolete("Mywykop/Received is deprecated.")] public const string MyWykopReceived = "Mywykop/Received";

        // Notifications
        public const string MyWykopNotifications = "Mywykop/Notifications";
        public const string MyWykopNotificationsCount = "Mywykop/NotificationsCount";
        public const string MyWykopHashTagsNotifications = "Mywykop/HashTagsNotifications";
        public const string MyWykopHashTagsNotificationsCount = "Mywykop/HashTagsNotificationsCount";
        public const string MyWykopReadNotifications = "Mywykop/ReadNotifications";
        public const string MyWykopReadHashTagsNotifications = "Mywykop/ReadHashTagsNotifications";
        public const string MyWykopMarkAsReadNotification = "Mywykop/MarkAsReadNotification";

        #endregion

        #region ENTRIES

        public const string EntriesIndex = "Entries/Index";
        public const string EntriesAdd = "Entries/Add";
        public const string EntriesEdit = "Entries/Edit";
        public const string EntriesDelete = "Entries/Delete";
        public const string EntriesAddComment = "Entries/AddComment";
        public const string EntriesEditComment = "Entries/EditComment";
        public const string EntriesDeleteComment = "Entries/DeleteComment";
        public const string EntriesVote = "Entries/Vote";
        public const string EntriesUnvote = "Entries/Unvote";
        public const string EntriesFavorite = "Entries/Favorite";

        #endregion

        #region RANK

        public const string RankIndex = "Rank/Index";
        public const string RankVotes = "Rank/Votes";
        public const string RankComments = "Rank/Comments";
        public const string RankEntries = "Rank/Entries";
        public const string RankEntriesComments = "Rank/EntriesComments";

        #endregion

        #region FAVORITES

        public const string FavoritesIndex = "Favorites/Index";
        public const string FavoritesComments = "Favorites/Comments";
        public const string FavoritesEntries = "Favorites/Entries";
        public const string FavoritesLists = "Favorites/Lists";

        #endregion

        #region STREAM

        public const string StreamIndex = "Stream/Index";
        public const string StreamHot = "Stream/Hot";

        #endregion

        #region TAG

        public const string TagIndex = "Tag/Index";
        public const string TagLinks = "Tag/Links";
        public const string TagEntries = "Tag/Entries";
        public const string TagObserve = "Tag/Observe";
        public const string TagUnobserve = "Tag/Unobserve";
        public const string TagBlock = "Tag/Block";
        public const string TagUnblock = "Tag/Unblock";

        #endregion

        #region PM

        public const string PmConversationsList = "Pm/ConversationsList";
        public const string PmConversation = "Pm/Conversation";
        public const string PmSendMessage = "Pm/SendMessage";
        public const string PmDeleteConversation = "Pm/DeleteConversation";

        #endregion

        #region OBSERVATORY

        public const string ObservatoryVotes = "Observatory/Votes";
        public const string ObservatoryComments = "Observatory/Comments";
        public const string ObservatoryEntries = "Observatory/Entries";
        public const string ObservatoryEntriesComments = "Observatory/EntriesComments";

        #endregion
    }
}