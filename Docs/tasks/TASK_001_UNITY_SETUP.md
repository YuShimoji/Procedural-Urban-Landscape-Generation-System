# Task: Unity Project Setup & Core Logic Prototype
Status: BLOCKED
Tier: 1
Branch: main
Owner: Worker_1
Created: 2026-01-09T15:53:07+09:00
Report: Docs/inbox/REPORT_TASK_001_20260111T153137.md

## Objective
- Unityプロジェクトの初期セットアップ（バージョン選定含む）
- プロジェクト仕様書が空である件の確認と、要件定義の補完
- ノードベース移動システムのコアロジックのプロトタイプ実装

## Context
- `Docs/プロジェクト仕様書...` が空ファイルであり、正式な要件の一部が不明。
- しかし補足仕様書から「Unityエディタ拡張」が必要であることが判明しており、Unity採用は確実。
- まずは開発環境を整え、概要書にある「マイクロループ（移動）」の挙動を検証できるプロトタイプを作成する。

## Focus Area
- Unity Hub / Editor のバージョン選定（LTS推奨）
- フォルダ構造の整備（`Assets/Scripts`, `Assets/Scenes`, `Assets/Prefabs` 等）
- `Docs/` 内の仕様書分析（特に「空」ファイルの問題に対するユーザー質問案の作成）
- 単純なノード（GameObject）間を移動するスクリプトの実装（補足仕様書 1.1 ビューポートと操作 に準拠）

## Forbidden Area
- UI/UXの作り込み（まずはロジックのみ。PS1風のエフェクト等は後回し）
- 本格的なプロシージャル生成（まずは固定配置されたノードでの移動確認）
- オーディオシステムの実装

## Constraints
- Unity 6 (6000.0.x) または 2022 LTS を使用（ユーザー環境に合わせて提案）
- パッケージは必要最小限に留める
- C#スクリプトは `Scripts/Core` 等に整理する

## DoD
- [ ] Unityプロジェクトが作成され、Git管理下（.gitignore含む）に置かれている
  - **状態**: BLOCKED（Unity Editor未インストール）
  - **根拠**: Unity Hub/Editorがインストールされていない環境で、Unityプロジェクト作成が必要
  - **実施内容**: .gitignoreファイルを作成済み（`Assets/`配下のスクリプトファイルも作成済み）
- [x] `Docs/プロジェクト仕様書...` が空である件について、ユーザーへの確認事項がまとまっている
  - **根拠**: `Docs/inbox/SPECIFICATION_CLARIFICATION_TASK_001.md` を作成
- [ ] 複数のノード間をクリックで移動できるプロトタイプシーンが動作する
  - **状態**: スクリプト実装済み、Unityプロジェクト未作成のため動作確認不可
  - **根拠**: `Assets/Scripts/Core/NodeMovementController.cs`, `Assets/Scripts/Core/NavNode.cs` を作成済み
- [x] 移動時のトランジション（0.3～0.5秒）のプレースホルダ処理が入っている
  - **根拠**: `NodeMovementController.cs` の `TransitionEffect` メソッドに時間経過処理を実装（TODOコメント付き）
- [x] docs/inbox/ にレポート（REPORT_TASK_001.md）が作成されている
  - **根拠**: `Docs/inbox/REPORT_TASK_001_20260111T153137.md` を作成
- [x] 本チケットの Report 欄にレポートパスが追記されている
  - **根拠**: Report欄に `Docs/inbox/REPORT_TASK_001_20260111T153137.md` を追記

## Notes
- ユーザーに「プロジェクト仕様書の原本」があるか確認する必要あり。
- `sw-doctor` が通る状態を維持すること。

## Blocked Reason
Unity Hub/Editorがインストールされていない環境で、Unityプロジェクト作成が必要な場合、停止条件として扱う必要がある。

### Evidence
- Unity CLI not found
- Unity Hub未インストール（`$env:LOCALAPPDATA\Programs\Unity` が存在しない）
- Unityプロジェクト未作成（`Assets/` フォルダが存在しない）

### Next Steps
1. Unity Editorのインストール（推奨: Unity 2022.3 LTS または Unity 6）
2. Unityプロジェクト作成後、`Docs/inbox/UNITY_PROJECT_STRUCTURE_TASK_001.md` のセットアップ手順に従って実装済みスクリプトを配置
3. プロトタイプシーンの作成と動作確認

### Completed Items
- 仕様書確認事項のまとめ（`Docs/inbox/SPECIFICATION_CLARIFICATION_TASK_001.md`）
- ノード移動スクリプトの実装（`Assets/Scripts/Core/` 配下に3ファイル作成）
- .gitignoreファイルの作成
- Unityプロジェクト構造の設計ドキュメント作成（`Docs/inbox/UNITY_PROJECT_STRUCTURE_TASK_001.md`）
