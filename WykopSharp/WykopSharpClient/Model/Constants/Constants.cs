using System;
using System.Collections.Generic;

namespace WykopSharpClient.Model.Constants
{
    public enum Type
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
        public static Dictionary<int, Tuple<Type, string>> Colors = new Dictionary<int, Tuple<Type, string>>
        {
            {0, new Tuple<Type, string>(Type.Green, "#339933")},
            {1, new Tuple<Type, string>(Type.Orange, "#FF5917")},
            {2, new Tuple<Type, string>(Type.Maroon, "#BB0000")},
            {5, new Tuple<Type, string>(Type.Administrator, "#000000")},
            {1001, new Tuple<Type, string>(Type.Banned, "#999999")},
            {1002, new Tuple<Type, string>(Type.Deleted, "#999999")},
            {2001, new Tuple<Type, string>(Type.Customer, "#3F6FA0")}
        };
    }
}