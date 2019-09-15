using System;
using System.Collections.Generic;
using UnityEngine;

namespace RestClientApp.Models {
    [Serializable]
    public class AppState {
      public int Count { get; set; }
      public LoginState loginState { get; set; }

      public static AppState initialState() {
          // var loginInfo = null;
          var isLogin = false;

          return new AppState {
              Count = PlayerPrefs.GetInt("count", 0),
              loginState = new LoginState {
                  email = "",
                  password = "",
                  loginInfo = null,
                  isLoggedIn = isLogin,
                  loading = false
              }
          };
        }
    }
}