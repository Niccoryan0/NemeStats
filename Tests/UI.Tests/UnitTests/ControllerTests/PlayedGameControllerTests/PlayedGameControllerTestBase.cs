﻿using BusinessLogic.DataAccess;
using BusinessLogic.DataAccess.Repositories;
using BusinessLogic.Logic;
using BusinessLogic.Logic.GameDefinitions;
using BusinessLogic.Logic.PlayedGames;
using BusinessLogic.Logic.Players;
using BusinessLogic.Models;
using BusinessLogic.Models.User;
using NUnit.Framework;
using Rhino.Mocks;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.Controllers;
using UI.Controllers.Helpers;
using UI.Transformations;

namespace UI.Tests.UnitTests.ControllerTests.PlayedGameControllerTests
{
    public class PlayedGameControllerTestBase
    {
        protected NemeStatsDataContext dataContext;
        protected PlayedGameController playedGameController;
        protected PlayedGameController playedGameControllerPartialMock;
        protected PlayedGameRetriever playedGameRetriever;
        protected PlayerRetriever playerRetrieverMock;
        protected PlayedGameDetailsViewModelBuilder playedGameDetailsBuilderMock;
        protected GameDefinitionRetriever gameDefinitionRetrieverMock;
        protected PlayedGameCreator playedGameCreatorMock;
        protected ShowingXResultsMessageBuilder showingXResultsMessageBuilderMock;
        protected UrlHelper urlHelperMock;
        protected string testUserName = "the test user name";
        protected ApplicationUser currentUser;
        protected List<GameDefinition> gameDefinitions;

        [SetUp]
        public virtual void TestSetUp()
        {
            dataContext = MockRepository.GenerateMock<NemeStatsDataContext>();
            playedGameRetriever = MockRepository.GenerateMock<PlayedGameRetriever>();
            playerRetrieverMock = MockRepository.GenerateMock<PlayerRetriever>();
            playedGameDetailsBuilderMock = MockRepository.GenerateMock<PlayedGameDetailsViewModelBuilder>();
            gameDefinitionRetrieverMock = MockRepository.GenerateMock<GameDefinitionRetriever>();
            playedGameCreatorMock = MockRepository.GenerateMock<PlayedGameCreator>();
            showingXResultsMessageBuilderMock = MockRepository.GenerateMock<ShowingXResultsMessageBuilder>();
            urlHelperMock = MockRepository.GenerateMock<UrlHelper>();
            playedGameController = new Controllers.PlayedGameController(
                dataContext,
                playedGameRetriever,
                playerRetrieverMock, 
                playedGameDetailsBuilderMock,
                gameDefinitionRetrieverMock,
                showingXResultsMessageBuilderMock,
                playedGameCreatorMock);
            playedGameController.Url = urlHelperMock;

            playedGameControllerPartialMock = MockRepository.GeneratePartialMock<PlayedGameController>(
                dataContext,
                playedGameRetriever,
                playerRetrieverMock,
                playedGameDetailsBuilderMock,
                gameDefinitionRetrieverMock,
                showingXResultsMessageBuilderMock,
                playedGameCreatorMock);
            playedGameControllerPartialMock.Url = urlHelperMock;

            currentUser = new ApplicationUser()
            {
                CurrentGamingGroupId = 1
            };
            gameDefinitions = new List<GameDefinition>();
            gameDefinitionRetrieverMock.Expect(mock => mock.GetAllGameDefinitions(currentUser.CurrentGamingGroupId.Value))
                .Repeat.Once()
                .Return(gameDefinitions);
        }
    }
}
