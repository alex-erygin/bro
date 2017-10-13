using Nancy;
using System;

namespace BroApp.Modules
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = (_ => {
                return "put your content to Content and access it /content/yourfile.jpg";
            });
        }
    }
}
