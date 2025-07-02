# AI-102 ラボ15

- サンプルのMP3ファイル https://github.com/MicrosoftLearning/mslearn-ai-language/raw/refs/heads/main/Labfiles/09-audio-chat/data/avocados.mp3 を生成AIモデルに送信し、音声を踏まえた指示を行う。
- Chat Completion APIに、テキストに加えて音声も送る。
- ChatGPTなどのチャットで、音声ファイルをアップロードして「この音声ファイルを要約して」といった指示をするのに相当

## 手順

- ラボ15を起動
- 本リポジトリを git clone
- .NET SDK 10 インストール https://dotnet.microsoft.com/ja-jp/download/dotnet/10.0
- VSCode インストール  https://code.visualstudio.com/
- Azure AI Foundryにサインイン、プロジェクトを作成、`Phi-4-multimodal-instruct`をデプロイ。
- 以下の環境変数をセット
  - `AI_DEPLOY_NAME` : モデルID（デプロイ名）、例: `Phi-4-multimodal-instruct`
  - `AI_ENDPOINT` エンドポイント、例: `https://project52667194-resource.services.ai.azure.com/models`
  - `AI_KEY`: キー（キー1）
- クローンしたフォルダをVSCodeで開く
- VSCode内のターミナルで `dotnet run`

## 実行結果例

以下のような応答が得られる（応答は毎回変わる）

```
The customer who is represented by Parker from Fourth Coffee on Madison Avenue is calling to update an existing order with an additional request for 5 pounds of avocados planned for the upcoming month.
```

参考訳
```
マディソン アベニューの Fourth Coffee のパーカーが担当する顧客は、来月予定されている 5 ポンドのアボカドの追加注文を、既存の注文に更新するために電話をかけてきました。
```


