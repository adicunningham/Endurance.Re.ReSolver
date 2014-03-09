using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endurance.Re.ReSolver.Infrastructure.Utility;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace Endurance.Re.ReSolver.ProgramModule
{
    public class ProgramModule : ModuleBase
    {
        public ProgramModule(IUnityContainer container, IRegionManager regionManager)
            : base(container, regionManager)
        {
        }

        protected override void InitializeModule()
        {
        }

        protected override void RegisterTypes()
        {
            throw new NotImplementedException();
        }
    }
}
