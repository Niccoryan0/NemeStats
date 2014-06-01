﻿using BusinessLogic.DataAccess;
using BusinessLogic.Logic;
using BusinessLogic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tests.IntegrationTests.Logic
{
    [TestFixture]
    public class PlayedGameRepositoryIntegrationTests
    {
        private NerdScorekeeperDbContext dbContext;
        private PlayedGame playedGame;

        [TestFixtureSetUp]
        public void SetUp()
        {
            dbContext = new NerdScorekeeperDbContext();
            int playedGameId = dbContext.GameDefinitions.First(x => x.Name == DataSeeder.GAME_NAME_SMALL_WORLD).PlayedGames.First().Id;
            playedGame = new PlayedGameRepository(dbContext).GetPlayedGameDetails(playedGameId);
        }

        [Test]
        public void ItRetrievesThePlayedGame()
        {
            Assert.NotNull(playedGame);
        }
       
        [Test]
        public void ItHasBeenSeededWithAtLeastTwoPlayerGameResults()
        {
            Assert.GreaterOrEqual(2, playedGame.PlayerGameResults.Count());
        }

        [Test]
        public void ItRetrievesTheGameDefinition()
        {
            Assert.NotNull(playedGame.GameDefinition);
        }

        [Test]
        public void ItReturnsNullIfNoPlayedGameFound()
        {
            PlayedGame notFoundPlayedGame = new PlayedGameRepository(dbContext).GetPlayedGameDetails(-1);
            Assert.Null(notFoundPlayedGame);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }
    }
}