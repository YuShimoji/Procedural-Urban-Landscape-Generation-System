# AI Context

## 基本情報

- **最終更新**: 2026-01-09T14:11:00+09:00
- **更新者**: AI Agent (Setup)

## レポート設定（推奨）

- **report_style**: standard
  - 例: `brief` / `standard` / `detailed`（他の値でもよい）
  - 目安: `brief` = 目的/結論/次アクション中心、`standard` = 要点+根拠+差分、`detailed` = 手順/根拠/ログも残す
  - 抜け漏れ防止: `standard` 以上では「次の中断可能点 / 決定事項 / リスク/懸念 / 短期（Next）」の更新を推奨
  - 運用: 重要な結論/決定/リスク/次アクションは、チャットで完結させず本ファイルへ転記する
- **mode**: discovery
  - 例: `discovery` / `implementation` / `review` / `release` / `incident` / `maintenance`（他の値でもよい）

## プロジェクト概要

- **プロジェクト名**: Procedural Urban Landscape Generation System (P-ULGSS)
- **概要**: 無限都市探索型アドベンチャーゲーム
- **仕様書**: `Docs/` 配下に格納
  - プロジェクト仕様書： Procedural Urban Landscape Generation System (P-ULGSS)
  - プロジェクト概要書：無限都市探索型アドベンチャー
  - 補足仕様書：インターフェース・オーディオ・開発ツール

## 現在のミッション

- **タイトル**: プロジェクト初期セットアップ
- **Issue**: なし
- **ブランチ**: main
- **関連PR**: なし
- **進捗**: 80% / セットアップ中

## 次の中断可能点

- Phase 4: 参照の固定化完了後
- Phase 6: 変更のコミット完了後

## 決定事項

- shared-workflows をサブモジュールとして `.shared-workflows/` に導入
- 運用ストレージとして `docs/tasks/` および `docs/inbox/` を作成
- レポートスタイルは `standard` を採用

## リスク/懸念

- 仕様書が `Docs/` と `docs/` の2箇所に分散する可能性
  - 対応: `Docs/` は仕様書専用、`docs/` は運用ドキュメント専用として区別

## Backlog（将来提案）

- [ ] 仕様書のマークダウン化（推定: 1日、優先度: 中）
- [ ] プロジェクト構造の詳細設計（推定: 3日、優先度: 高）

## タスク管理（短期/中期/長期）

### 短期（Next）

- [x] Phase 0: Bootstrap & 現状確認
- [x] Phase 1: Submodule 導入
- [x] Phase 2: 運用ストレージ作成
- [ ] Phase 3: テンプレ配置
- [ ] Phase 4: 参照の固定化
- [ ] Phase 5: 運用フラグ設定
- [ ] Phase 6: 変更をコミット

### 中期（Later）

- [ ] Orchestrator による本格的な開発開始
- [ ] 開発環境のセットアップ（Unity等）

### 長期（Someday）

- [ ] アルファ版リリース
- [ ] ベータテスト実施

## 備考（自由記述）

- プロジェクトはGit管理下にあり、初期コミット前の状態
- 仕様書は既に3ファイル存在（`Docs/` 配下）
- セットアップ時点ではコードは未作成

## 履歴

- 2026-01-09 14:11: AI_CONTEXT.md を初期化
- 2026-01-09 14:11: プロジェクト初期セットアップ開始
