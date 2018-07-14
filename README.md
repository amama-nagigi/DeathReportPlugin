# DeathReportPlugin

Show DeathReport Overlay for FFXIV ACT OverlayPlugin\
Needs [RainbowMage/OverlayPlugin](https://github.com/RainbowMage/OverlayPlugin)

誰かがやられたときのログをオーバーレイで出力します。\
[RainbowMage/OverlayPlugin](https://github.com/RainbowMage/OverlayPlugin)のアドオンとして作成させていただいてます。

![DeathReportPlugin](https://github.com/amama-nagigi/Garage/blob/master/DeathReportPlugin/01.png?raw=true)
## 要件

* [Advanced Combat Tracker](https://advancedcombattracker.com/)
* FFXIV Plugin
* [RainbowMage/OverlayPlugin](https://github.com/RainbowMage/OverlayPlugin)

## インストール方法

当リポジトリのreleaseからダウンロードしたファイルを、OverlayPluginのフォルダ内に直接上書きしてください。

```
OverlayPlugin
|
+ addons
| - DeathReportPlugin.dll
|
+ resources
  - deathreport.html
```

## 使い方

OverlayPluginでOverlayを追加してください。 \
パーティメンバーがやられると、やられたログとその直前に受けたダメージや回復をオーバーレイで表示します。 \

`deathreport.html`は好きにいじってください。
