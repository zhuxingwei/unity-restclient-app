using System;
using System.Collections.Generic;
using RestClientApp.Components;
using RestClientApp.Stores;
using RestClientApp.Models;
using RestClientApp.Utils;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.Redux;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace RestClientApp {

    public class RestClientApp : UIWidgetsPanel
    {
        protected override void OnEnable() {
            base.OnEnable();
            Screen.fullScreen = false;
            Window.onFrameRateCoolDown = CustomFrameRateCoolDown;
            LoadFonts();

            // Initialize other services
            // WebViewManager.instance.initWebView(this.gameObject);
        }

        static void CustomFrameRateCoolDown() {
            Application.targetFrameRate = 60;
        }

        static void LoadFonts() {
            FontManager.instance.addFont(Resources.Load<Font>("font/Roboto-Regular"), "Roboto-Regular");
            FontManager.instance.addFont(Resources.Load<Font>("font/Roboto-Medium"), "Roboto-Medium");
            FontManager.instance.addFont(Resources.Load<Font>("font/Roboto-Bold"), "Roboto-Bold");
            FontManager.instance.addFont(Resources.Load<Font>("font/Ionicons"), "Ionicons");
        }

        protected override void Update() {
            base.Update();
            if (Input.deviceOrientation == DeviceOrientation.Portrait &&
                Screen.orientation != ScreenOrientation.Portrait) {
                EventBus.publish(EventBusConstant.changeOrientation, new List<object> {ScreenOrientation.Portrait});
            }
            else if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft) {
                if (Screen.orientation != ScreenOrientation.LandscapeLeft) {
                    EventBus.publish(EventBusConstant.changeOrientation,
                        new List<object> {ScreenOrientation.LandscapeLeft});
                }
            }
            else if (Input.deviceOrientation == DeviceOrientation.LandscapeRight) {
                if (Screen.orientation != ScreenOrientation.LandscapeRight) {
                    EventBus.publish(EventBusConstant.changeOrientation,
                        new List<object> {ScreenOrientation.LandscapeRight});
                }
            }
        }

        protected override Widget createWidget() {
            return new StoreProvider<AppState>(
                store: StoreProvider.store,
                new WidgetsApp(
                    home: new Router(),
                    pageRouteBuilder: pageRouteBuilder
                )
            );
        }

        static PageRouteFactory pageRouteBuilder {
            get {
                return (settings, builder) =>
                    new PageRouteBuilder(
                        settings: settings,
                        (context, animation, secondaryAnimation) => builder(context)
                    );
            }
        }

        void OnApplicationFocus(bool hasFocus) {
            if (Application.isEditor) {
                return;
            }
            // Apply effects
        }

        void OnApplicationQuit() {
            if (Application.isEditor) {
                return;
            }
            // Apply effects
        }
    }
}