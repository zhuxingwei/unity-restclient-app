using System;

namespace RestClientApp.Models {
    [Serializable]
    public class LoginInfo {
        public string userId;
        public string userFullName;
        public string userAvatar;
        public string authId;
        public bool anonymous;
        public string title;
    }
}