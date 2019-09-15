using System.Collections.Generic;
using Unity.UIWidgets.widgets;
using UnityEngine;
using RestClientApp.Components;
using RestClientApp.Screens;
using RSG;

namespace RestClientApp {

    static class MainNavigatorRoutes {
        public const string Root = "/";
        public const string Splash = "/splash";
        public const string Home = "/home";
        public const string Login = "/login";
        public const string History = "/history";
        public const string AboutUs = "/aboutUs";
    }

    public class Router : StatelessWidget
    {
        static readonly GlobalKey globalKey = GlobalKey.key("main-router");
        static readonly RouteObserve<PageRoute> _routeObserve = new RouteObserve<PageRoute>();

        public static NavigatorState navigator {
            get { return globalKey.currentState as NavigatorState; }
        }
        
        public static RouteObserve<PageRoute> routeObserve {
            get { return _routeObserve; }
        }

        static Dictionary<string, WidgetBuilder> mainRoutes {
            get {
                var routes = new Dictionary<string, WidgetBuilder> {
                    // {MainNavigatorRoutes.History, context => new HistoryScreenConnector()},
                    {MainNavigatorRoutes.Login, context => new LoginScreen()},
                    // {MainNavigatorRoutes.AboutUs, context => new AboutUsScreenConnector()}
                };
                if (Application.isEditor) {
                    routes.Add(MainNavigatorRoutes.Root, context => new SplashScreen());
                    routes.Add(MainNavigatorRoutes.Home, context => new HomeScreen());
                }
                else {
                    routes.Add(MainNavigatorRoutes.Splash, context => new SplashScreen());
                    routes.Add(MainNavigatorRoutes.Home, context => new HomeScreen());
                    routes.Add(MainNavigatorRoutes.Root, context => new RootScreen());
                }


                return routes;
            }
        }

        static Dictionary<string, WidgetBuilder> fullScreenRoutes {
            get {
                return new Dictionary<string, WidgetBuilder> {
                    {MainNavigatorRoutes.Login, context => new LoginScreen()}
                };
            }
        }

        public override Widget build(BuildContext context) {
            return new WillPopScope(
                onWillPop: () => { return Promise<bool>.Resolved(true); },
                child: new Navigator(
                    key: globalKey,
                    observers: new List<NavigatorObserver> {
                        _routeObserve
                    },
                    onGenerateRoute: settings => {
                        return new PageRouteBuilder(
                            settings: settings,
                            (context1, animation, secondaryAnimation) => mainRoutes[settings.name](context1),
                            (context1, animation, secondaryAnimation, child) => {
                                if (fullScreenRoutes.ContainsKey(settings.name)) {
                                    return new ModalPageTransition(
                                        routeAnimation: animation,
                                        child: child
                                    );
                                }

                                return new PushPageTransition(
                                    routeAnimation: animation,
                                    child: child
                                );
                            }
                        );
                    }
                )
            );
        }
    }
}