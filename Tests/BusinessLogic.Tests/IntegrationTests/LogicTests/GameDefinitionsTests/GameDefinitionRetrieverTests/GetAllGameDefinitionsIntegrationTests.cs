﻿using System.Data.Entity;
using BusinessLogic.DataAccess;
using BusinessLogic.Logic.GameDefinitions;
using BusinessLogic.Models;
using BusinessLogic.Models.Games;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Rhino.Mocks.Constraints;
using Is = NUnit.Framework.Is;

namespace BusinessLogic.Tests.IntegrationTests.LogicTests.GameDefinitionsTests.GameDefinitionRetrieverTests
{
    [TestFixture]
    public class GetAllGameDefinitionsIntegrationTests : IntegrationTestBase
    {
        protected GameDefinitionRetriever retriever;
        protected IList<GameDefinitionSummary> actualGameDefinitionSummaries;

        [SetUp]
        public void SetUp()
        {
            using(NemeStatsDataContext dataContext = new NemeStatsDataContext())
            {
                retriever = new GameDefinitionRetriever(dataContext);
                this.actualGameDefinitionSummaries = retriever.GetAllGameDefinitions(testUserWithDefaultGamingGroup.CurrentGamingGroupId.Value);
            }
            
        }

        [Test]
        public void ItOnlyGetsGameDefinitionsForTheCurrentPlayersGamingGroup()
        {
            Assert.True(this.actualGameDefinitionSummaries.All(game => game.GamingGroupId == testUserWithDefaultGamingGroup.CurrentGamingGroupId));
        }

        [Test]
        public void ItSortsGameDefinitionsByNameAscending()
        {
            string previousName = null;

            foreach (GameDefinition gameDefinition in this.actualGameDefinitionSummaries)
            {
                if (previousName != null)
                {
                    Assert.LessOrEqual(previousName, gameDefinition.Name);
                }

                previousName = gameDefinition.Name;
            }
        }

        [Test]
        public void ItGetsBackChampionInformation()
        {
            Assert.That(this.actualGameDefinitionSummaries.All(game => game.Champion != null), Is.True);
        }

        [Test]
        public void ItGetsBackPreviousChampionInformation()
        {
            Assert.That(this.actualGameDefinitionSummaries.All(game => game.PreviousChampion != null), Is.True);

        }

        [Test, Ignore("Miscellaneous integration test that might be occassionally useful but not worth slowing things down.")]
        public void TryGamingGroup1()
        {
            using (NemeStatsDataContext dataContext = new NemeStatsDataContext())
            {
                retriever = new GameDefinitionRetriever(dataContext);
                IList<GameDefinitionSummary> gameDefinitionSummaries = retriever.GetAllGameDefinitions(1);

                foreach (GameDefinitionSummary summary in gameDefinitionSummaries)
                {
                    if (summary.ChampionId != null)
                    {
                        Assert.That(summary.Champion, Is.Not.Null);
                        Assert.That(summary.Champion.Player, Is.Not.Null);
                    }
                }
            }
        }
    }
}
