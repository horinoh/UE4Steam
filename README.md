# UE4Steam

## やったこと

* DefaultEngine.ini の編集 (ソースコード参照)
* UE4SteamBuild.cs の OnlineSubsysytem まわりのコメントアウトされている部分を有効にする (ソースコード参照)
* UE4Steam.Target.cs のコンストラクタに bUsesSteam = true を追加 (ソースコード参照)
* 一度 Steam のクライアントを立ち上げてログインする、ログインしたら Steam クライアントは閉じて OK
* UE4Steam.uproject 右クリック - Launch game または エディタから Standalone Game で起動する
    * 右下に Steam のオーバーレイが表示されたら OK