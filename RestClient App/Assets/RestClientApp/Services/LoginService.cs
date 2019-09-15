using System;
using RestClientApp.Constants;
using RestClientApp.Models;
using RSG;

namespace RestClientApp.Services {

    [Serializable]
    public class LoginParameter {
        public string email;
        public string password;
    }

    public static class LoginService {

        public static IPromise<LoginInfo> LoginByEmail(string email, string password) {
            var promise = new Promise<LoginInfo>();
            var param = new LoginParameter {
                email = email,
                password = password
            };

            var url = $"{Config.apiAddress}/login";

            // Not implemented
            promise.Reject(null);
            return promise;
        }
    }
}