﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using Azure.AI.Language.Conversations.Perf.Infrastructure;
using Azure.Test.Perf;
using CommandLine;

namespace Azure.AI.Language.Conversations.Perf.Scenarios
{
    public class AnalyzeConversation : AnalysisScenarioBase<AnalyzeConversation.ConversationAnalysisClient>
    {
        public AnalyzeConversation(ConversationAnalysisClient options) : base(options)
        {
        }

        public override void Run(CancellationToken cancellationToken)
        {
            Client.AnalyzeConversation("Send an email to Carol about the tomorrow's demo", TestEnvironment.Project);
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            await Client.AnalyzeConversationAsync("Send an email to Carol about the tomorrow's demo", TestEnvironment.Project);
        }

        public class ConversationAnalysisClient : PerfOptions
        {
            // TODO: Replace with actual options.
            [Option("delay", Default = 100, HelpText = "Delay between gets (milliseconds)")]
            public int Delay { get; set; }
        }
    }
}
