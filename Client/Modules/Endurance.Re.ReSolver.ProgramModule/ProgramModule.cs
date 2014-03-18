using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endurance.Re.ReSolver.Infrastructure.Constants;
using Endurance.Re.ReSolver.Infrastructure.Utility;
using Endurance.Re.ReSolver.ProgramModule.View;
using Endurance.Re.ReSolver.ProgramModule.ViewModel;
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
            RegionManager.RegisterViewWithRegion(RegionNames.TaskbuttonRegion, typeof (ProgramTaskButtonView));
            RegionManager.RegisterViewWithRegion(RegionNames.WorkspaceRegion, typeof (ProgramView));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IProgramViewModel, ProgramViewModel>();
            Container.RegisterType<IProgramTaskButtonViewModel, ProgramTaskButtonViewModel>();
        }
    }
}
