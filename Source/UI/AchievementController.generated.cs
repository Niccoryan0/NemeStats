// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace UI.Controllers
{
    public partial class AchievementController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AchievementController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DetailsForCurrentUser()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DetailsForCurrentUser);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Details()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PlayerAchievement()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PlayerAchievement);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AchievementController Actions { get { return MVC.Achievement; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Achievement";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Achievement";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string DetailsForCurrentUser = "DetailsForCurrentUser";
            public readonly string Details = "Details";
            public readonly string PlayerAchievement = "PlayerAchievement";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string DetailsForCurrentUser = "DetailsForCurrentUser";
            public const string Details = "Details";
            public const string PlayerAchievement = "PlayerAchievement";
        }


        static readonly ActionParamsClass_DetailsForCurrentUser s_params_DetailsForCurrentUser = new ActionParamsClass_DetailsForCurrentUser();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DetailsForCurrentUser DetailsForCurrentUserParams { get { return s_params_DetailsForCurrentUser; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DetailsForCurrentUser
        {
            public readonly string achievementId = "achievementId";
            public readonly string currentUser = "currentUser";
        }
        static readonly ActionParamsClass_Details s_params_Details = new ActionParamsClass_Details();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Details DetailsParams { get { return s_params_Details; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Details
        {
            public readonly string achievementId = "achievementId";
            public readonly string currentUser = "currentUser";
        }
        static readonly ActionParamsClass_PlayerAchievement s_params_PlayerAchievement = new ActionParamsClass_PlayerAchievement();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PlayerAchievement PlayerAchievementParams { get { return s_params_PlayerAchievement; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PlayerAchievement
        {
            public readonly string achievementId = "achievementId";
            public readonly string playerId = "playerId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _RecentAchievementsUnlocked = "_RecentAchievementsUnlocked";
                public readonly string Details = "Details";
                public readonly string Index = "Index";
            }
            public readonly string _RecentAchievementsUnlocked = "~/Views/Achievement/_RecentAchievementsUnlocked.cshtml";
            public readonly string Details = "~/Views/Achievement/Details.cshtml";
            public readonly string Index = "~/Views/Achievement/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_AchievementController : UI.Controllers.AchievementController
    {
        public T4MVC_AchievementController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void DetailsForCurrentUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, BusinessLogic.Models.Achievements.AchievementId achievementId, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult DetailsForCurrentUser(BusinessLogic.Models.Achievements.AchievementId achievementId, BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DetailsForCurrentUser);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "achievementId", achievementId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            DetailsForCurrentUserOverride(callInfo, achievementId, currentUser);
            return callInfo;
        }

        [NonAction]
        partial void DetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, BusinessLogic.Models.Achievements.AchievementId achievementId, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult Details(BusinessLogic.Models.Achievements.AchievementId achievementId, BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "achievementId", achievementId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            DetailsOverride(callInfo, achievementId, currentUser);
            return callInfo;
        }

        [NonAction]
        partial void PlayerAchievementOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, BusinessLogic.Models.Achievements.AchievementId achievementId, int playerId);

        [NonAction]
        public override System.Web.Mvc.ActionResult PlayerAchievement(BusinessLogic.Models.Achievements.AchievementId achievementId, int playerId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PlayerAchievement);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "achievementId", achievementId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "playerId", playerId);
            PlayerAchievementOverride(callInfo, achievementId, playerId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
