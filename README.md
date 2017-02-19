# Steam
  
* DefaultEngine.ini の設定を貼り付ける
  * https://docs.unrealengine.com/latest/INT/Programming/Online/Steam/index.html#iniconfiguration
* XXX.Target.cs のコンストラクタに bUsesSteam = true を追記
* XXX.uproject に OnlineSubsytemSteam プラグインの項目を追加
  * 一時的に OnlineSubsystemNull にしたい場合は `"Enabled": false` にする
~~~
,
"Plugins": [
  {
    "Name": "OnlineSubsystemSteam",
    "Enabled": true
  }
]
~~~
* スタンドアロンで起動する(PIEではダメ)
  * XXX.uproject 右クリック - Launch game または エディタから Standalone Game で起動する
  * 右下に Steam のオーバーレイが表示されたら OK
  
## オンライン

* XXX.Build.cs のコメントアウトされている OnlineSubsystem を有効にする
  * 必要なら OnlineSubSystemUtils も追加
* オンライン対応には 2PC、2Steam アカウントが必要