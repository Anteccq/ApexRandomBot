#  Apex Random Bot

この Bot は新しくリニューアルしました！
移動先は[**こちら**](https://github.com/Anteccq/ApexRandomGachaBot)

>Apex のレジェンドと武器をランダムで決めてくれる Discord Bot です。

この Discord Bot を動かすには、`appsettings.{Environment}.json` ファイルが必要です。

```json:appsettings.{Environment}.json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "DiscordToken": "{Your token}"
}
```

## コマンド一覧
### レジェンド
```
!legend
```
### 武器
```
!weapon
```
### レジェント&武器
```
!all
```
### ヘルプ
```
!help
```

## 開発環境
* .NET Core 3.1

## License
Under the MIT.