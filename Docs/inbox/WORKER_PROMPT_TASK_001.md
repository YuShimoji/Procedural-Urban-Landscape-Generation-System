# Worker Prompt: TASK_001_UNITY_SETUP

```xml
<instruction>
あなたは分散開発チームの Worker です。割り当てられた 1 タスクだけを完遂し、証跡を残してください。
</instruction>

<context>
<mission_log>
作業開始時に `.cursor/MISSION_LOG.md` を読み込み、現在のフェーズと進捗を確認してください。
作業完了時に MISSION_LOG.md を更新し、進捗を記録してください。

現在の状態:
- Mission ID: ORCH_20260111_RESUME+09:00
- 現在のフェーズ: Phase 5（Worker起動用プロンプト生成）
- ステータス: IN_PROGRESS
- アクティブタスク: TASK_001 (Tier 1, Status: OPEN)
</mission_log>

<ssot_reference>
Phase 0: 参照と整備
- SSOT: .shared-workflows/docs/Windsurf_AI_Collab_Rules_latest.md（無ければ docs/ 配下を参照し、必ず `ensure-ssot.js` で取得を試す）
- 進捗: Docs/HANDOVER.md
- チケット: Docs/tasks/TASK_001_UNITY_SETUP.md（**存在確認: `Test-Path Docs/tasks/TASK_001_UNITY_SETUP.md` または `ls Docs/tasks/TASK_001_UNITY_SETUP.md`**）
- AI_CONTEXT: AI_CONTEXT.md
- SSOT 未整備・ensure-ssot.js 不在で解決できない場合は停止条件
</ssot_reference>

<preconditions>
Phase 1: 前提の固定
- Tier: 1
- Branch: main
- Report Target: docs/inbox/REPORT_TASK_001_<ISO8601>.md（ISO8601形式のタイムスタンプを付与）
- GitHubAutoApprove: Docs/HANDOVER.md の記述を参照（記載: true）
- ブランチが異なる場合:
  - `git status -sb` で未コミットが無いことを確認
  - `git switch main` で切替を試す
  - 破壊的操作が必要なら停止条件
</preconditions>

<boundaries>
Phase 2: 境界
- Focus Area: 
  - Unity Hub / Editor のバージョン選定（LTS推奨）
  - フォルダ構造の整備（`Assets/Scripts`, `Assets/Scenes`, `Assets/Prefabs` 等）
  - `Docs/` 内の仕様書分析（特に「空」ファイルの問題に対するユーザー質問案の作成）
  - 単純なノード（GameObject）間を移動するスクリプトの実装（補足仕様書 1.1 ビューポートと操作 に準拠）
- Forbidden Area: 
  - UI/UXの作り込み（まずはロジックのみ。PS1風のエフェクト等は後回し）
  - 本格的なプロシージャル生成（まずは固定配置されたノードでの移動確認）
  - オーディオシステムの実装
- DoD: 
  - [ ] Unityプロジェクトが作成され、Git管理下（.gitignore含む）に置かれている
  - [ ] `Docs/プロジェクト仕様書...` が空である件について、ユーザーへの確認事項がまとまっている
  - [ ] 複数のノード間をクリックで移動できるプロトタイプシーンが動作する
  - [ ] 移動時のトランジション（0.3～0.5秒）のプレースホルダ処理が入っている
  - [ ] docs/inbox/ にレポート（REPORT_TASK_001_<ISO8601>.md）が作成されている
  - [ ] 本チケットの Report 欄にレポートパスが追記されている
</boundaries>
</context>

<workflow>
<phase name="Phase 0: 参照と整備">
<step>
1. `.cursor/MISSION_LOG.md` を読み込み、現在のフェーズと進捗を確認。
2. SSOT: .shared-workflows/docs/Windsurf_AI_Collab_Rules_latest.md（無ければ docs/ 配下を参照し、必ず `ensure-ssot.js` で取得を試す）
3. 進捗: Docs/HANDOVER.md
4. チケット: Docs/tasks/TASK_001_UNITY_SETUP.md（**存在確認: `Test-Path Docs/tasks/TASK_001_UNITY_SETUP.md` または `ls Docs/tasks/TASK_001_UNITY_SETUP.md`**）
5. AI_CONTEXT.md を読み、プロジェクト背景を把握
6. SSOT 未整備・ensure-ssot.js 不在で解決できない場合は停止条件
</step>
</phase>

<phase name="Phase 1: 前提の固定">
<step>
1. Tier: 1
2. Branch: main
3. Report Target: docs/inbox/REPORT_TASK_001_<ISO8601>.md
4. GitHubAutoApprove: Docs/HANDOVER.md の記述を参照（記載: true）
5. ブランチが異なる場合:
   - `git status -sb` で未コミットが無いことを確認
   - `git switch main` で切替を試す
   - 破壊的操作が必要なら停止条件
6. MISSION_LOG.md を更新（Phase 1 完了を記録）。
</step>
</phase>

<phase name="Phase 2: 境界確認">
<step>
1. Focus Area: 
   - Unity Hub / Editor のバージョン選定（LTS推奨）
   - フォルダ構造の整備（`Assets/Scripts`, `Assets/Scenes`, `Assets/Prefabs` 等）
   - `Docs/` 内の仕様書分析（特に「空」ファイルの問題に対するユーザー質問案の作成）
   - 単純なノード（GameObject）間を移動するスクリプトの実装（補足仕様書 1.1 ビューポートと操作 に準拠）
2. Forbidden Area: 
   - UI/UXの作り込み（まずはロジックのみ。PS1風のエフェクト等は後回し）
   - 本格的なプロシージャル生成（まずは固定配置されたノードでの移動確認）
   - オーディオシステムの実装
3. DoD: 
   - [ ] Unityプロジェクトが作成され、Git管理下（.gitignore含む）に置かれている
   - [ ] `Docs/プロジェクト仕様書...` が空である件について、ユーザーへの確認事項がまとまっている
   - [ ] 複数のノード間をクリックで移動できるプロトタイプシーンが動作する
   - [ ] 移動時のトランジション（0.3～0.5秒）のプレースホルダ処理が入っている
   - [ ] docs/inbox/ にレポート（REPORT_TASK_001_<ISO8601>.md）が作成されている
   - [ ] 本チケットの Report 欄にレポートパスが追記されている
4. MISSION_LOG.md を更新（Phase 2 完了を記録）。
</step>
</phase>

<phase name="Phase 3: 実行ルール">
<step>
1. **DoD 各項目の実行可能性確認（必須）**:
   - DoD 各項目を確認し、実行可能かどうかを判断する
   - Unityプロジェクト作成は環境依存（Unity Hub/Editorが必要）
   - 仕様書分析は実行可能
   - ノード移動スクリプトの実装は実行可能
   - 環境依存のタスクの場合、停止条件として扱うか、代替手段を取るかを判断する

2. チャットで完結させない。成果はファイル（docs/tasks / docs/inbox / docs/HANDOVER / git）に残す。

3. コマンドは実行して結果で判断。失敗は「失敗」と明記し、根拠と次手を出す。

4. 指示コマンドが無い場合: `Get-Command <cmd>` 等で確認 → 代替案提示 → それでも依存追加/外部通信が必要なら停止。

5. 「念のため」のテスト/フォールバック/リファクタは禁止（DoD 従属のみ）。

6. ダブルチェック:
   - テスト/Push/長時間待機は結果を確認し、未達なら完了扱いにしない。
   - `git status -sb` で差分を常に把握。

7. タイムアウトを宣言し、無限待機しない。

8. MISSION_LOG.md を更新（Phase 3 完了を記録、実行内容を記録）。
</step>
</phase>

<phase name="Phase 4: 納品 & 検証">
<step>
**必須: DoD の実際の達成確認（表面的な確認ではなく、実際に実施した内容を記録）**

1. **DoD 各項目の達成確認（必須）**:
   - DoD 各項目に対して、**実際に実施した内容**を記録する（「確認済み」などの表面的な記述は禁止）
   - 実施したコマンド: `<cmd>=<result>`
   - 実施した調査: `<調査内容>=<結果>`
   - 実施した実装: `<実装内容>=<結果>`

2. チケットを DONE に更新する前に、DoD 各項目の達成根拠を確認する:
   - DoD 各項目が実際に達成されているかを確認する
   - 環境依存で実行不可能な項目がある場合、停止条件として扱うか、代替手段を取るかを判断する

3. チケットを DONE に更新し、DoD 各項目に対して根拠（差分 or テスト結果 or 調査結果）を記入

4. docs/inbox/ にレポート（以下テンプレ）を作成/更新し、`node .shared-workflows/scripts/report-validator.js <REPORT_PATH_TARGET>` を実行。結果をレポートに記載

5. docs/HANDOVER.md を更新し、次回 Orchestrator が把握できるよう記録

6. 実行したテストを `<cmd>=<result>` 形式でレポートとチケットに残す

7. `git status -sb` をクリーンにしてから commit（必要なら push）。push は GitHubAutoApprove=true の場合のみ

8. MISSION_LOG.md を更新（Phase 4 完了を記録、納品物のパスを記録）。
</step>
</phase>

<phase name="Phase 5: チャット出力">
<step>
1. 完了時: `Done: Docs/tasks/TASK_001_UNITY_SETUP.md. Report: docs/inbox/REPORT_TASK_001_<ISO8601>.md. Tests: <cmd>=<result>.`
2. ブロッカー継続時: `Blocked: Docs/tasks/TASK_001_UNITY_SETUP.md. Reason: <要点>. Next: <候補>. Report: docs/inbox/REPORT_TASK_001_<ISO8601>.md.`
3. MISSION_LOG.md を更新（Phase 5 完了を記録）。
</step>
</phase>
</workflow>

<stop_conditions>
停止条件:
- Forbidden Area に触れないと解決できない
- 仕様仮定が3件以上
- SSOT が取得できない / `ensure-ssot.js` でも解決不可
- 依存追加 / 外部通信（fetch/pull/push 等）が必要で GitHubAutoApprove=true が未確認
- 破壊的・復旧困難操作（rebase/reset/force push 等）が必要
- 数分以上の待機が必須、またはタイムアウト超過が見込まれる
- Unity Hub/Editor がインストールされていない環境で、Unityプロジェクト作成が必要な場合
- 代替手段が取れない場合、停止条件として扱う
</stop_conditions>

<stop_output>
停止時の必須アウトプット:
1. チケット Docs/tasks/TASK_001_UNITY_SETUP.md を IN_PROGRESS/BLOCKED のまま更新  
   - 事実 / 根拠ログ要点 / 次手 1-3 件 / Report パスを必ず追記
2. docs/inbox/ に未完了レポートを作成し、調査結果・詰まり・次手を記録
3. 変更は commit する（push は GitHubAutoApprove=true の場合のみ自律実行）。push 不要時は「push pending」を明記
4. チャット 1 行: `Blocked: Docs/tasks/TASK_001_UNITY_SETUP.md. Reason: <要点>. Next: <候補>. Report: docs/inbox/REPORT_TASK_001_<ISO8601>.md.`
5. MISSION_LOG.md を更新（停止理由と次手を記録）。
</stop_output>

<output_format>
納品レポート（docs/inbox/REPORT_TASK_001_<ISO8601>.md）フォーマット:
# Report: Unity Project Setup & Core Logic Prototype

**Timestamp**: <ISO8601>  
**Actor**: Worker  
**Ticket**: Docs/tasks/TASK_001_UNITY_SETUP.md  
**Type**: Worker  
**Duration**: <所要時間>  
**Changes**: <変更量要約>

## 概要
- <作業の概要を記載>

## Changes
- <file>: <詳細変更内容（何をどう変更したか）>

## Decisions
- <decision>: <理由>

## Verification
- <command>: <result（成功/失敗とログ要点）>

## Risk
- <潜在リスク>

## Remaining
- なし / <残件>

## Blocked（State: BLOCKED の場合）
- Reason / Evidence / Options（1〜3）

## Handover
- Orchestrator への申し送り（次手・注意点・未解決事項）

## 次のアクション
- <次のアクションを記載>

## Proposals（任意）
- 担当外で気づいた改善案・次回タスク候補
</output_format>

<self_correction>
- ファイルパスは **動的に確認** すること（`ls`, `find`, `Test-Path` 等を使用）。ハードコード禁止。
- エラーが発生した場合は、MISSION_LOG.md に記録し、復旧手順を試行する。
- 3回試行しても解決しない場合のみ、状況と試行内容を整理してユーザーに判断を仰ぐ。
- MISSION_LOG.md は常に最新状態を保つこと。各フェーズ完了時に必ず更新する。
</self_correction>
```
