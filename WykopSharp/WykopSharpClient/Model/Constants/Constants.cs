using System;
using System.Collections.Generic;

namespace WykopSharpClient.Model.Constants
{
    public enum UserType
    {
        Green,
        Orange,
        Maroon,
        Administrator,
        Banned,
        Deleted,
        Customer
    }

    public static class UserGroup
    {
        public static Dictionary<int, Tuple<UserType, string>> Colors = new Dictionary<int, Tuple<UserType, string>>
        {
            {0, new Tuple<UserType, string>(UserType.Green, "#339933")},
            {1, new Tuple<UserType, string>(UserType.Orange, "#FF5917")},
            {2, new Tuple<UserType, string>(UserType.Maroon, "#BB0000")},
            {5, new Tuple<UserType, string>(UserType.Administrator, "#000000")},
            {1001, new Tuple<UserType, string>(UserType.Banned, "#999999")},
            {1002, new Tuple<UserType, string>(UserType.Deleted, "#999999")},
            {2001, new Tuple<UserType, string>(UserType.Customer, "#3F6FA0")}
        };
    }
}