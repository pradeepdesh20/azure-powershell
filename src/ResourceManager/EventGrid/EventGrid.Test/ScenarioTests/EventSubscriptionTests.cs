﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.EventGrid.Test.ScenarioTests;
using Microsoft.Azure.ServiceManagement.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.EventGrid.Tests.ScenarioTests
{
    public class EventSubscriptionTests : RMTestBase
    {
        public XunitTracingInterceptor _logger;

        public EventSubscriptionTests(ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_EventSubscriptionToCustomTopics()
        {
            EventGridController.NewInstance.RunPsTest(_logger, "EventSubscriptionTests_CustomTopic");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_EventSubscriptionToCustomTopics2()
        {
            EventGridController.NewInstance.RunPsTest(_logger, "EventSubscriptionTests_CustomTopic2");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_EventSubscriptionToAzureSubscription()
        {
            EventGridController.NewInstance.RunPsTest(_logger, "EventSubscriptionTests_Subscription");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_EventSubscriptionToAzureSubscription2()
        {
            EventGridController.NewInstance.RunPsTest(_logger, "EventSubscriptionTests_Subscription2");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_EventSubscriptionToResourceGroup()
        {
            EventGridController.NewInstance.RunPsTest(_logger, "EventSubscriptionTests_ResourceGroup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_EventSubscriptionToResourceGroup2()
        {
            EventGridController.NewInstance.RunPsTest(_logger, "EventSubscriptionTests_ResourceGroup2");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_EventSubscriptionToResourceCRUD()
        {
            EventGridController.NewInstance.RunPsTest(_logger, "EventSubscriptionTests_Resource");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_EventSubscription_Deadletter()
        {
            EventGridController.NewInstance.RunPsTest(_logger, "EventSubscriptionTests_Deadletter");
        }
    }
}


