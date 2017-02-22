using Microsoft.Practices.ServiceLocation;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Desktop.Modules.Home
{
    [ModuleExport(typeof(HomeModule),InitializationMode=InitializationMode.WhenAvailable)]
    public class HomeModule : IModule
    {
        private IRegionManager _regionManager;
        [ImportingConstructor]
        public HomeModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void Initialize()
        {
            var profileDetailsRegion = _regionManager.Regions["ProfileDetailsRegion"];
            profileDetailsRegion.Add(ServiceLocator.Current.GetInstance<ProfileDetailsView>());
        }
    }
}
