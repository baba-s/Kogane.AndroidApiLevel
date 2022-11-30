# Kogane Android Api Level

アプリケーションを実行している Android 端末の API Level を取得できるパッケージ

## 使用例

```cs
// アプリケーションを実行している Android 端末の API Level
Debug.Log( AndroidApiLevel.Value );

// アプリケーションを実行している Android 端末のバージョンが 13 以上なら true
Debug.Log( AndroidApiLevel.IsAndroidVersion13OrHigher );
```