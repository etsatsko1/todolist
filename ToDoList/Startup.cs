using Microsoft.Owin;
using NLog;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoList.Startup))]
namespace ToDoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            ConfigureAuth(app);
        }
    }
}
