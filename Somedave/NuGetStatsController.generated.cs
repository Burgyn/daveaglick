// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
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
namespace Somedave.Controllers
{
    public partial class NuGetStatsController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public NuGetStatsController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected NuGetStatsController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Leaderboard()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Leaderboard);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Package()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Package);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PackagePost()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PackagePost);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public NuGetStatsController Actions { get { return MVC.NuGetStats; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "NuGetStats";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "NuGetStats";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Status = "Status";
            public readonly string Footer = "Footer";
            public readonly string Leaderboard = "Leaderboard";
            public readonly string Package = "Package";
            public readonly string PackagePost = "PackagePost";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Status = "Status";
            public const string Footer = "Footer";
            public const string Leaderboard = "Leaderboard";
            public const string Package = "Package";
            public const string PackagePost = "PackagePost";
        }


        static readonly ActionParamsClass_Leaderboard s_params_Leaderboard = new ActionParamsClass_Leaderboard();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Leaderboard LeaderboardParams { get { return s_params_Leaderboard; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Leaderboard
        {
            public readonly string leaderboard = "leaderboard";
        }
        static readonly ActionParamsClass_Package s_params_Package = new ActionParamsClass_Package();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Package PackageParams { get { return s_params_Package; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Package
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_PackagePost s_params_PackagePost = new ActionParamsClass_PackagePost();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PackagePost PackagePostParams { get { return s_params_PackagePost; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PackagePost
        {
            public readonly string id = "id";
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
                public readonly string Footer = "Footer";
                public readonly string Index = "Index";
                public readonly string Leaderboard = "Leaderboard";
                public readonly string Package = "Package";
                public readonly string Status = "Status";
            }
            public readonly string Footer = "~/Views/NuGetStats/Footer.cshtml";
            public readonly string Index = "~/Views/NuGetStats/Index.cshtml";
            public readonly string Leaderboard = "~/Views/NuGetStats/Leaderboard.cshtml";
            public readonly string Package = "~/Views/NuGetStats/Package.cshtml";
            public readonly string Status = "~/Views/NuGetStats/Status.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_NuGetStatsController : Somedave.Controllers.NuGetStatsController
    {
        public T4MVC_NuGetStatsController() : base(Dummy.Instance) { }

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
        partial void StatusOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Status()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Status);
            StatusOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void FooterOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Footer()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Footer);
            FooterOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void LeaderboardOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string leaderboard);

        [NonAction]
        public override System.Web.Mvc.ActionResult Leaderboard(string leaderboard)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Leaderboard);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "leaderboard", leaderboard);
            LeaderboardOverride(callInfo, leaderboard);
            return callInfo;
        }

        [NonAction]
        partial void PackageOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Package(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Package);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            PackageOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void PackagePostOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult PackagePost(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PackagePost);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            PackagePostOverride(callInfo, id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591