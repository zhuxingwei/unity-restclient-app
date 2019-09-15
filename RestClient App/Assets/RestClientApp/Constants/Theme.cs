using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace RestClientApp.Constants {
    public static class Icons {
        public static readonly IconData close = new IconData(0xf129, "Ionicons");
        public static readonly IconData chevron_right = new IconData(0xf125, "Ionicons");
        public static readonly IconData chevron_left = new IconData(0xf124, "Ionicons");
        public static readonly IconData share = new IconData(0xf3ac, "Ionicons");
        public static readonly IconData settings = new IconData(0xf4a7, "Ionicons");
    }

    public static class CTextStyle {
        public static readonly TextStyle H1 = new TextStyle(
            height: 1.06f,
            fontSize: 40,
            fontFamily: "Roboto-Bold",
            color: CColors.TextTitle
        );

        public static readonly TextStyle H2 = new TextStyle(
            height: 1.11f,
            fontSize: 32,
            fontFamily: "Roboto-Bold",
            color: CColors.TextTitle
        );

        public static readonly TextStyle H2White = new TextStyle(
            height: 1.11f,
            fontSize: 32,
            fontFamily: "Roboto-Bold",
            color: CColors.White
        );

        public static readonly TextStyle H3 = new TextStyle(
            height: 1.16f,
            fontSize: 28,
            fontFamily: "Roboto-Bold",
            color: CColors.TextTitle
        );

        public static readonly TextStyle H4 = new TextStyle(
            height: 1.18f,
            fontSize: 24,
            fontFamily: "Roboto-Medium",
            color: CColors.TextTitle
        );

        public static readonly TextStyle H4White = new TextStyle(
            height: 1.18f,
            fontSize: 24,
            fontFamily: "Roboto-Medium",
            color: CColors.White
        );

        public static readonly TextStyle H5 = new TextStyle(
            height: 1.27f,
            fontSize: 20,
            fontFamily: "Roboto-Medium",
            color: CColors.TextTitle
        );
    }

    public static class CColors {
        public static readonly Color Primary = new Color(0xFF2196F3);
        public static readonly Color Secondary = new Color(0xFFF32194);
        public static readonly Color Error = new Color(0xFFF44336);
        public static readonly Color Cancel = new Color(0xFF797979);
        public static readonly Color TextTitle = new Color(0xFF000000);

        public static readonly Color H5White = Color.fromRGBO(255, 255, 255, 0.8f);

        public static readonly Color Transparent = new Color(0x00000000);
        public static readonly Color White = new Color(0xFFFFFFFF);
        public static readonly Color Black = new Color(0xFF000000);
        public static readonly Color Red = new Color(0xFFFF0000);
        public static readonly Color Green = new Color(0xFF00FF00);
        public static readonly Color Blue = new Color(0xFF0000FF);
        public static readonly Color Grey = new Color(0xFF9E9E9E);

        public static readonly Color Background = new Color(0xFFF5F5F5);
    }
}