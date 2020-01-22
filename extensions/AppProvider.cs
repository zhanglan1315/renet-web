using Microsoft.AspNetCore.Builder;

namespace Renet.Web
{
  public interface IAppProvider
  {
    void ResolveApp(IApplicationBuilder app);

    void Boot();
  }

  public abstract class AppProvider : IAppProvider
  {
    protected IApplicationBuilder App;

    public void ResolveApp(IApplicationBuilder app)
    {
      App = app;
    }

    public abstract void Boot();
  }
}
