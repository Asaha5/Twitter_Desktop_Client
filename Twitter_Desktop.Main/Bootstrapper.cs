using Microsoft.Practices.ServiceLocation;
using Prism.Mef;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Twitter_Desktop.Main
{
    public class Bootstrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
        }
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Shell)Shell;
            Application.Current.MainWindow.Show();
        }
    }
}
