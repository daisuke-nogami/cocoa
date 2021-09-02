---
title: "Pull Requestが取り込まれるまで"
weight: 200
type: docs
---

# Pull Requestが取り込まれるまで
Pull Requestは貢献の一つです。Pull Requestでは一般的に次の手順で取り込まれます。

## Issueの投稿
Issueを投稿します。これはコラボレーターだけでなく、すべてのコントリビューターの皆様に行っていただけます。

## トリアージ

### GitHubコミュニティとして
コラボレーターにより現象の再現性などを確認後、必要に応じてラベルを付けます。また、開発チームによる確認が必要と思われたものについては`waiting-confirmation`ラベルを付与します。

### 開発チームとして
開発チームによる確認が行われます。確認が完了すると開発チームが運用している課題管理システムに登録されます。この際、Internal Tracking IDをIssueのDescriptionに付記します。確認が完了すると`confirmed`のラベルに変更します（IssueとInternal Tracking IDは1:1の関係ではありません。1つのIssueに複数のIDが対応する場合があります）。

## 担当の割り当て
Issueの担当を決めます。コントリビューターの皆様で担当しても良いという方はその旨申し出てください。`help wanted` / `welcome-contribution` のラベルがついているものを優先して対応いただけると助かります。申し出をいただければコラボレーターがIssueにassignします。assignについては、同じIssueに対して複数のコラボレーターが作業をすることで後から調整が必要になったり、誰かの労力が無駄になることを避ける目的があります。何卒ご協力ください。

## Pull Requestの作成
Pull Requestを作成します。基本的には`develop`ブランチ向けに出します（大きめの変更の場合、`feature`ブランチを用意することもあります）。Pull Reqeustを出す際は、必ずDescriptionに対応するIssue番号を記載してください。

## コードレビュー

### GitHubコミュニティによるコードレビュー
コラボレーターがPull Requestをレビューします。Approve権限はコラボレーターにしかありませんが、コントリビューターの皆様どなたでもコードレビューに参加できます。

### 開発チームによるコードレビュー
コラボレーターがApproveした後、開発チームがコードレビューをします。

## Pull Requestの取り込み
Pull Reqeustが取り込まれます。Pull Reqeustの作成時期と、取り込み時期によってはコンフリクトが起こる可能性もあります。
その場合、コンフリクトの解消をお願いする場合があります。