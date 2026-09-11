/*
order: 70
title: Managed Agents
slug: managed-agents

Configure Cartesia-hosted voice agents with instructions, a voice, an LLM, and tools.
*/

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ManagedAgents_ExposeConfigurationAndLifecycleSurface()
    {
        //// A managed agent configuration combines the prompt, language, LLM, voice, and custom tools.
        var request = new CreateManagedAgentV1Request
        {
            Name = "Multilingual concierge",
            Description = "Answers callers without a customer-hosted voice backend.",
            Config = new CreateManagedAgentV1RequestConfig
            {
                Instructions = "Answer concisely and use the caller's language.",
                InitialMessage = "Hello! How can I help?",
                Language = new CreateManagedAgentV1RequestConfigLanguage
                {
                    Primary = ManagedAgentPrimaryLanguageV1.En,
                },
                Model = new CreateManagedAgentV1RequestConfigModel
                {
                    Id = "anthropic/claude-sonnet-4-20250514",
                    Temperature = 0.2,
                },
                Audio = new CreateManagedAgentV1RequestConfigAudio
                {
                    Output = new CreateManagedAgentV1RequestConfigAudioOutput
                    {
                        VoiceId = "694f9389-aac1-45b6-b726-9d9369183238",
                    },
                },
                Tools =
                [
                    new ManagedAgentToolReferenceV1
                    {
                        Id = "tool_weather",
                    },
                ],
            },
        };

        var json = request.ToJson(SourceGenerationContext.Default);

        json.Should().Contain("\"instructions\":\"Answer concisely and use the caller");
        json.Should().Contain("\"voice_id\":\"694f9389-aac1-45b6-b726-9d9369183238\"");
        json.Should().Contain("\"tools\":[{\"id\":\"tool_weather\"}]");

        //// The generated Agents client includes CRUD, version, model, call, batch, tool, and metric operations.
        var operationNames = typeof(IAgentsClient).GetMethods().Select(method => method.Name).ToHashSet();

        operationNames.Should().Contain([
            "PostV1AgentsAsync",
            "GetV1AgentsAsync",
            "GetV1AgentsByAgentIdAsync",
            "PatchV1AgentsByAgentIdAsync",
            "DeleteV1AgentsByAgentIdAsync",
            "GetV1AgentsByAgentIdVersionsAsync",
            "GetV1AgentsModelsAsync",
            "AgentsCreateOutboundCallAsync",
            "AgentsCreateCallBatchAsync",
            "AgentsCreateMetricAsync",
        ]);
    }
}
