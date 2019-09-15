using System;

namespace RestClientApp.Models {
    [Serializable]
    public class LoginState {
        public LoginInfo loginInfo;
        public string email;
        public string password;
        public bool loading;
        public bool isLoggedIn;
    }
}