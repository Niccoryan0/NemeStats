﻿using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using BusinessLogic.Models.User;
using NUnit.Framework;
using Rhino.Mocks;
using StructureMap.AutoMocking;
using UI.Areas.Api;
using UI.Transformations;

namespace UI.Tests.UnitTests.AreasTests.ApiTests.ControllersTests
{
    public abstract class ApiControllerTestBase<T> where T : ApiControllerBase
    {
        protected RhinoAutoMocker<T> _autoMocker;
        protected ApplicationUser _applicationUser;
        protected const int EXPECTED_GAMING_GROUP_ID = 2;

        [SetUp]
        public void BaseSetUp()
        {
            AutomapperConfiguration.Configure();
            this._autoMocker = new RhinoAutoMocker<T>();
            var controllerContextMock = MockRepository.GeneratePartialMock<HttpControllerContext>();
            var actionDescriptorMock = MockRepository.GenerateMock<HttpActionDescriptor>();
            this._autoMocker.ClassUnderTest.ActionContext = new HttpActionContext(controllerContextMock, actionDescriptorMock);

            this._applicationUser = new ApplicationUser
            {
                Id = "application user id",
                CurrentGamingGroupId = EXPECTED_GAMING_GROUP_ID
            };
            _autoMocker.ClassUnderTest.CurrentUser = this._applicationUser;

            this._autoMocker.ClassUnderTest.Request = new HttpRequestMessage();
            this._autoMocker.ClassUnderTest.Request.SetConfiguration(new HttpConfiguration());
        }
    }
}
