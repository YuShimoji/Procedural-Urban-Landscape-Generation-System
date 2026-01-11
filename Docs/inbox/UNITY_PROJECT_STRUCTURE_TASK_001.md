# Unityプロジェクト構造設計: TASK_001

**作成日時**: 2026-01-11T16:00:00+09:00  
**作成者**: Worker  
**関連タスク**: TASK_001_UNITY_SETUP

## プロジェクト構造

```
Assets/
├── Scripts/
│   ├── Core/
│   │   ├── NodeMovementController.cs    # ノード間移動コントローラー
│   │   ├── NavNode.cs                   # ナビゲーションノード
│   │   └── CameraController.cs          # カメラコントローラー
│   ├── Procedural/                      # プロシージャル生成（将来）
│   ├── UI/                              # UIシステム（将来）
│   └── Audio/                           # オーディオシステム（将来）
├── Scenes/
│   └── Prototype/
│       └── NodeMovementTest.unity       # ノード移動プロトタイプシーン
├── Prefabs/
│   ├── NavNode.prefab                   # ナビゲーションノードプレハブ
│   └── CameraRig.prefab                 # カメラリグプレハブ
├── Materials/                           # マテリアル（将来）
├── Textures/                            # テクスチャ（将来）
└── Editor/                              # エディタ拡張（将来）
    └── DebugTools/                      # デバッグツール（補足仕様書3章）
```

## 実装済みスクリプト

### 1. NodeMovementController.cs
- **機能**: ノード間を移動するためのコントローラー
- **仕様準拠**: 補足仕様書 1.1 ビューポートと操作
- **主な機能**:
  - マウスクリックでノードを選択
  - Raycastによるノード検出
  - 0.3～0.5秒のトランジション処理（プレースホルダー）
  - カメラ位置の自動移動

### 2. NavNode.cs
- **機能**: 移動可能な地点を表すノード
- **主な機能**:
  - ノードID管理
  - アクセス可能性フラグ
  - Collider自動追加（エディタ時）
  - Gizmo表示（エディタ時）

### 3. CameraController.cs
- **機能**: カメラの回転制御
- **仕様準拠**: 補足仕様書 1.1 カメラコントロール
- **主な機能**:
  - マウスドラッグによる360度回転
  - ゲームパッドスティック対応
  - 垂直方向（Pitch）クランプ（-60度～+60度）

## セットアップ手順（Unity Editor使用時）

1. **Unityプロジェクト作成**
   - Unity Hubで新規プロジェクト作成
   - テンプレート: 3D (URP推奨)
   - バージョン: Unity 2022.3 LTS または Unity 6

2. **フォルダ構造作成**
   - 上記の構造に従ってフォルダを作成

3. **スクリプト配置**
   - `Assets/Scripts/Core/` に実装済みスクリプトを配置

4. **レイヤー設定**
   - Layer: "NavNode" を作成
   - NavNodeオブジェクトにNavNodeレイヤーを設定

5. **プロトタイプシーン作成**
   - 新規シーン作成: `Assets/Scenes/Prototype/NodeMovementTest.unity`
   - カメラに `CameraController` と `NodeMovementController` をアタッチ
   - 複数のGameObjectを作成し、`NavNode` コンポーネントをアタッチ
   - NavNodeオブジェクトにColliderを追加（BoxCollider推奨）
   - NavNodeオブジェクトをNavNodeレイヤーに設定

6. **動作確認**
   - Playモードで実行
   - マウスドラッグでカメラ回転を確認
   - NavNodeをクリックして移動を確認

## 注意事項

- Unityプロジェクトの作成はUnity Editorが必要です
- 現在の環境ではUnity Editorがインストールされていないため、プロジェクト作成は停止条件として扱います
- スクリプトファイルは既に作成済みですので、Unityプロジェクト作成後に配置してください

## 次のステップ

1. Unity Editorのインストール
2. Unityプロジェクトの作成
3. 上記セットアップ手順の実行
4. プロトタイプシーンの動作確認
