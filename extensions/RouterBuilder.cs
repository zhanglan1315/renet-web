using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Builder;

namespace Renet.Web
{
  public class RouterBuilder
  {
    private string _pattern;

    private string _defaults;

    private HttpMethodRouteConstraint _methods;

    public RouterBuilder Pattern(string pattern)
    {
      return this;
    }

    public RouterBuilder Controller(string controller)
    {
      return this;
    }

    public RouterBuilder Methods(params string[] methods)
    {
      _methods = new HttpMethodRouteConstraint(methods);

      return this;
    }

    public void Build(IEndpointRouteBuilder builder)
    {
      var defaults = _defaults.Split(".");

      builder.MapControllerRoute(
        _defaults,
        _pattern,
        new { controller = defaults[0], action = defaults[1] },
        new { methods = _methods }
      );
    }
  }
}
