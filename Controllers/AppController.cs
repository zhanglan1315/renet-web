using Microsoft.AspNetCore.Mvc;

namespace Renet.Web
{
  public class AppController : ControllerBase
  {
    public string Home()
    {
      return "welcome to renet api";
    }
  }
}
