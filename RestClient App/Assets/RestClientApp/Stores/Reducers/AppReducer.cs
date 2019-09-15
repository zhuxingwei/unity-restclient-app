using System;
using System.Collections.Generic;
using System.Linq;
using RestClientApp.Models;
using RestClientApp.Utils;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.service;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace RestClientApp.Stores {
    public static class AppReducer {
        static readonly List<string> _nonce = new List<string>();

        public static AppState Reduce(AppState state, object bAction) {
            switch (bAction) {
                case LogoutAction _: {
                    state.loginState.loginInfo = new LoginInfo();
                    state.loginState.isLoggedIn = false;

                    // Clear cookies
                    // Clear user Info
                    // Clear other states
                    break;
                }

                case LoginFailureAction _: {
                    state.loginState.loading = false;
                    break;
                }

                case LoginAction _: {
                    state.loginState.loading = true;
                    break;
                }

                case LoginSuccessAction action: {
                    state.loginState.loading = false;
                    state.loginState.loginInfo = action.loginInfo;
                    state.loginState.isLoggedIn = true;
                    // Initialize other states
                    EventBus.publish(sName: EventBusConstant.login_success, new List<object>());
                    break;
                }
            }

            return state;
        }
    }
}