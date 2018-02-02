namespace System.Web.Routing {
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;



    [TypeForwardedFrom("System.Web.Routing, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
    public abstract class RouteBase {

        /*
         * 1、解析请求URL的路由数据，并封装在RouteData对象中
         *    根据路由模板的模式与代表请求地址的URL进行匹配，
         *      在匹配成功的情况下 ： 返回一个封装路由信息的RouteData对象。
         *      在匹配失败的情况下 ： 返回Null
         * **/
        public abstract RouteData GetRouteData(HttpContextBase httpContext);

        /*
         * 2、指定的路由变量列表(包括路由变量的名称和值)与URL模板进行匹配：
         *      匹配成功：用指定的参数(values)去填充路由模板中的路由变量占位符并得到一个完整的URL,这个URL被封装成VirtualPathData对象
         *      匹配失败：返回Null
         * 
         * **/
        public abstract VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values);


        /*
         * 3、是否对现有的物理文件实施路由，默认值为true
         * 
         * **/
        // Default needs to be true to avoid breaking change
        private bool _routeExistingFiles = true;
        public bool RouteExistingFiles {
            get {
                return _routeExistingFiles;
            }
            set {
                _routeExistingFiles = value;
            }
        }
    }
}
