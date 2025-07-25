# VRMマリオ's アドベンチャー

## プロジェクト概要

Super Mario 3D Landスタイルの3Dアクションプラットフォーマーゲーム。  
VRM形式のマリオキャラクターを使用し、擬人化された コクッパ7人衆 & クッパとのボス戦が特徴。

## 技術仕様

- **Unity**: 2021 LTS
- **VRM**: UniVRM SDK  
- **グラフィック**: URP (Universal Render Pipeline)
- **プラットフォーム**: PC (Windows/Mac)
- **使用パッケージ**: Addressables, Cinemachine, Timeline

## ゲーム要素

### 基本アクション
- ジャンプ、ダブルジャンプ
- ダッシュ、スライディング
- 壁キック
- パワーアップシステム

### ワールド構成
1. 草原ワールド
2. 砂漠ワールド  
3. 雪原ワールド
4. 雲海ワールド
5. ジャングルワールド
6. 溶岩ワールド
7. 水中ワールド
8. クッパ城ワールド

### キャラクター
- **主人公**: VRMマリオ（差し替え可能）
- **ワールドボス**: 擬人化コクッパ7人衆
- **ラスボス**: 擬人化クッパ
- **通常エネミー**: クリボー、ノコノコ など

## プロジェクト構造

```
VRMマリオアドベンチャー/
├── Scripts/           # スクリプトファイル
│   ├── Core/          # ゲーム管理
│   ├── Player/        # プレイヤー制御
│   ├── Camera/        # カメラシステム
│   ├── Stage/         # ステージ管理
│   ├── Boss/          # ボス戦システム
│   ├── Enemies/       # 通常エネミー
│   ├── VRM_System/    # VRMキャラクター管理
│   ├── UI/            # UIシステム
│   ├── Powerups/      # パワーアップ
│   └── Collectibles/  # コレクタブル
├── Assets/            # Unityアセット
└── Documentation/     # ドキュメント
```

## セットアップ手順

1. Unity 2021 LTS で新規3Dプロジェクト作成
2. URP設定を適用
3. 必要パッケージをインストール:
   - UniVRM
   - Cinemachine
   - Timeline
   - Addressables
4. Scripts フォルダの内容をインポート
5. VRMマリオモデルを配置

## 開発進捗

- [x] プロジェクト構造作成
- [x] コアシステム実装
- [x] VRMマリオ制御実装
- [x] ステージシステム実装
- [x] エネミーシステム実装
- [x] ボス戦システム実装
- [x] カメラ・カットシーン実装
- [ ] UI統合
- [ ] パワーアップシステム実装
