using System.Collections.Generic;
using RestClientApp.Components;
using RestClientApp.Constants;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace RestClientApp.Screens {
    public class SplashScreen : StatelessWidget {
        public override Widget build(BuildContext context) {
            if (Application.platform == RuntimePlatform.Android) {
                return new Container(
                    color: CColors.White);
            }

            return new Container(
                color: CColors.White,
                child: new Center(
                    child: new Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        crossAxisAlignment: CrossAxisAlignment.center,
                        children: new List<Widget> {
                            new Container(
                                width: 200,
                                height: 200,
                                margin: EdgeInsets.only(bottom: 0, top: 0),
                                child: Image.asset("image/iOS/AppIcon.imageset/AppIcon",
                                    fit: BoxFit.cover))
                        })
                ));
        }
    }
}