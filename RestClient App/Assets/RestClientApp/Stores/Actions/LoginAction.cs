using System.Collections.Generic;
using Unity.UIWidgets.Redux;
using Unity.UIWidgets.widgets;
using RestClientApp.Models;
using RestClientApp.Services;

namespace RestClientApp.Stores {

    public class LogoutAction : BaseAction {
        public BuildContext context;
    }

    public class LoginFailureAction : BaseAction {
        public BuildContext context;
    }

    public class LoginAction : RequestAction {
    }

    public class LoginSuccessAction : BaseAction {
        public LoginInfo loginInfo;
    }

    public static partial class Actions {

        public static object loginByEmail() {
            return new ThunkAction<AppState>((dispatcher, getState) => {
                var email = getState().loginState.email;
                var password = getState().loginState.password;
                return LoginService.LoginByEmail(email, password)
                .Then(loginInfo => {
                    dispatcher.dispatch(new LoginSuccessAction {
                        loginInfo = loginInfo
                    });
                })
                .Catch(error => dispatcher.dispatch(new LoginFailureAction()));
            });
        }
    }
}