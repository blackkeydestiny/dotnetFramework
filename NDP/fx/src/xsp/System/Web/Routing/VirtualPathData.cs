namespace System.Web.Routing {
    using System;
    using System.Runtime.CompilerServices;

    [TypeForwardedFrom("System.Web.Routing, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
    public class VirtualPathData {


        private string _virtualPath;
        private RouteValueDictionary _dataTokens = new RouteValueDictionary();


        // ===========================================构造函数=========================================================================
        public VirtualPathData(RouteBase route, string virtualPath) {
            Route = route;
            VirtualPath = virtualPath;
        }
        // ===========================================构造函数=========================================================================



        // ===========================================属性=========================================================================
        /*
         * 自定义的路由变量
         * **/
        public RouteValueDictionary DataTokens {
            get {
                return _dataTokens;
            }
        }

        /*
         * 路由对象
         * **/
        public RouteBase Route {
            get;
            set;
        }

        /*
         * 生成完成的URL
         * **/
        public string VirtualPath {
            get {
                return _virtualPath ?? String.Empty;
            }
            set {
                _virtualPath = value;
            }
        }
        // ===========================================属性=========================================================================

    }
}
