namespace System.Web.Routing {
    using System.Runtime.CompilerServices;

    /*
     * 
     * IRouteHandler接口在ASP.NET路由系统中具有重要的地位,其重要作用在于提供最终用于处理请求的Httphandler对象(通过调用其GetHttpHandler方法获取)。 
     * **/
    [TypeForwardedFrom("System.Web.Routing, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
    public interface IRouteHandler {
        IHttpHandler GetHttpHandler(RequestContext requestContext);
    }
}
