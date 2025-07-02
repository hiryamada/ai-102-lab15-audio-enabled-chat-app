#pragma warning disable SKEXP0070
#pragma warning disable SKEXP0001

using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
kernelBuilder.AddAzureAIInferenceChatCompletion(    
    modelId: Environment.GetEnvironmentVariable("AI_DEPLOY_NAME") ?? "",
    apiKey: Environment.GetEnvironmentVariable("AI_KEY") ?? "",
    endpoint: new Uri(Environment.GetEnvironmentVariable("AI_ENDPOINT") ?? "")
);
Kernel kernel = kernelBuilder.Build();
byte[] audio = File.ReadAllBytes("avocados.mp3");
ChatHistory chatHistory = [];
chatHistory.AddUserMessage([
	new AudioContent(audio, "audio/mpeg"),
	new TextContent("Can you summarize this customer's voice message?")
]);

var chatCompletion = kernel.GetRequiredService<IChatCompletionService>();
var result = await chatCompletion.GetChatMessageContentAsync(chatHistory);
System.Console.WriteLine(result);
