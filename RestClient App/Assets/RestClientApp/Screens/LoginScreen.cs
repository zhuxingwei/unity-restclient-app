using System.Collections.Generic;
using RestClientApp.Components;
using RestClientApp.Constants;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace RestClientApp.Screens {
    public class LoginScreen : StatelessWidget {
        public override Widget build(BuildContext context) {
            return new Container(
                color: CColors.White,
                child: new CustomSafeArea(
                    child: null
                )
            );
        }
    }
}