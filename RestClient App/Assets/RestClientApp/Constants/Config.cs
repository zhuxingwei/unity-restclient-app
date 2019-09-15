namespace RestClientApp.Constants {
    public static class Config {
        public const string apiAddress = "https://connect.unity.com";

        public const string domain = ".proyecto26.com";

        public const string termsOfService = "https://unity3d.com/legal/terms-of-service";

        public const string privacyPolicy = "https://unity3d.com/legal/privacy-policy";

        public const string versionNumber = "1.0.0";

        public const int versionCode = 1;

#if UNITY_IOS
        public const string platform = "ios";
        public const string store = "appstore";
#elif UNITY_ANDROID
        public const string platform = "android";

//        public const string store = "test";
        public const string store = "official";
#else
        public const string platform = "";
        public const string store = "";
#endif
    }
}