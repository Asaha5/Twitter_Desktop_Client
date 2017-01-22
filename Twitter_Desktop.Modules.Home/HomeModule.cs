using Prism.Mef.Modularity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Desktop.Modules.Home
{
    [ModuleExport(typeof(HomeModule),InitializationMode=InitializationMode.WhenAvailable)]
    class HomeModule : IModule
    {
        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
