# AI-102 ラボ15

## 概要

- サンプルのMP3ファイル https://github.com/MicrosoftLearning/mslearn-ai-language/raw/refs/heads/main/Labfiles/09-audio-chat/data/avocados.mp3 を生成AIモデルに送信し、音声を踏まえた指示を行う。
- 生成AIとして マイクロソフトの`Phi-4-multimodal-instruct`を使用。このモデルはマルチモーダルモデルでありテキストだけではなく音声などのデータを入力することができる
- Chat Completion APIに、テキストに加えて音声も送る。
- ChatGPTなどのチャットで、音声ファイルをアップロードして「この音声ファイルを要約して」といった指示をするのに相当

## 手順

- ラボ15を起動
- ターミナルを開き、本リポジトリを git clone
- .NET SDK 10 インストール https://dotnet.microsoft.com/ja-jp/download/dotnet/10.0
- VSCode インストール  https://code.visualstudio.com/
- Azure AI Foundryにサインイン、プロジェクトを作成、`Phi-4-multimodal-instruct`をデプロイ。
- 以下の環境変数をセット
  - `AI_DEPLOY_NAME` : モデルID（デプロイ名）、例: `Phi-4-multimodal-instruct`
  - `AI_ENDPOINT` エンドポイント、例: `https://project52667194-resource.services.ai.azure.com/models` 末尾に models が付く点に注意
  - `AI_KEY`: キー（キー1）
- クローンしたフォルダをVSCodeで開く
- VSCode内のターミナルで `Get-ChildItem Env:` を実行し、環境変数が読み取れるかを確認。
- VSCode内のターミナルで `dotnet run`

## 実行結果例

以下のような応答が得られる（応答は毎回変わる）

```
A customer called to add 5 pounds of avocados to their order for the next month, speaking from a Fourth coffee shop on Madison Avenue.
```

参考訳
```
マディソン街の「フォースコーヒー」ショップのパーカーが、来月の注文に 5 ポンドのアボカドを追加したいと電話をかけてきました。
```

備考: 「Fourth Coffee」は、マイクロソフトがよく使用する架空の会社名。


## 参考

オリジナルのラボ手順書

https://microsoftlearning.github.io/mslearn-ai-language/Instructions/Labs/09-audio-chat.html
