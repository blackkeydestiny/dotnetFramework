namespace System.Web.Routing {
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.CompilerServices;



    [TypeForwardedFrom("System.Web.Routing, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
    public class RouteData {


        private IRouteHandler _routeHandler;
        private RouteValueDictionary _values = new RouteValueDictionary();
        private RouteValueDictionary _dataTokens = new RouteValueDictionary();


        // ===========================================构造函数=========================================================================
        public RouteData() {
        }

        public RouteData(RouteBase route, IRouteHandler routeHandler) {
            Route = route;
            RouteHandler = routeHandler;
        }
        // ===========================================构造函数=========================================================================


        
        
        // ===========================================属性=========================================================================

        /*
         * 直接附加到Route上的自定义变量
         * **/
        public RouteValueDictionary DataTokens {
            get {
                return _dataTokens;
            }
        }


        /*
         * Route对象
         * **/
        public RouteBase Route {
            get;
            set;
        }

        /*
         * 通过这个属性可以获得最终处理请求的HttpHandler对象
         * 
         * **/
        public IRouteHandler RouteHandler {
            get {
                return _routeHandler;
            }
            set {
                _routeHandler = value;
            }
        }

        /*
         * 路由变量的字典：解析URL得到的
         * key代表路由变量的名称
         * value代表路由变量的值
         * **/
        public RouteValueDictionary Values {
            get {
                return _values;
            }
        }
        // ===========================================属性=========================================================================



        /*
         * 在某些路由场景中,我们要求Route针对当前请求进行解析得到的变量集合(values属性)必须包含某些固定名称的变量值
         * (比如ASP.NET MVC应用中表示Contro11er和Action名称的变量)
         * 
         * **/
        public string GetRequiredString(string valueName) {
            object value;
            if (Values.TryGetValue(valueName, out value)) {
                string valueString = value as string;
                if (!String.IsNullOrEmpty(valueString)) {
                    return valueString;
                }
            }
            throw new InvalidOperationException(
                String.Format(
                    CultureInfo.CurrentUICulture,
                    SR.GetString(SR.RouteData_RequiredValue),
                    valueName));
        }
    }
}
