using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallTime.Classes
{
    public class Session
    {
        public enum Keys
        {
            CallTime_UserID,
            CallTime_UserFirstName,
            CallTime_UserLastName,
            CallTime_UserEmail,
            CallTime_SessionID
        };
        private static string GetKeyName(Keys key)
        {
            return Enum.GetName(typeof(Keys), key);
        }

        private static void SetToSession<T>(string key, T value)
        {
            HttpContext.Current.Session[key] = value;
        }
    }
}