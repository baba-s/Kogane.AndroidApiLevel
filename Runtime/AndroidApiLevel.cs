using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// アプリケーションを実行している Android 端末の API Level を取得できるクラス
    /// </summary>
    public static class AndroidApiLevel
    {
        //================================================================================
        // プロパティ
        //================================================================================
        /// <summary>
        /// アプリケーションを実行している Android 端末の API Level を返します
        /// </summary>
        public static int Value
        {
            get
            {
#if UNITY_EDITOR || UNITY_ANDROID
                if ( Application.isEditor ) return -1;
                using var version = new AndroidJavaClass( "android.os.Build$VERSION" );
                return version.GetStatic<int>( "SDK_INT" );
#else
                return -1;
#endif
            }
        }

        /// <summary>
        /// アプリケーションを実行している Android 端末のバージョンが 13 以上なら true を返します
        /// </summary>
        public static bool IsAndroidVersion13OrHigher => 33 <= Value;
    }
}