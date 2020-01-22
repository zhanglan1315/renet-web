namespace Renet.Web
{
  public class WebRoutes : RouterProvider
  {
    public override void Define()
    {
      Post("/", "AppController.Home");
      Get("/test", "AppController.Test");
      Post("{*url}", "AppController.UrlNotFound");
    }
  }
}
