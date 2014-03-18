using System;
using System.Windows.Input;
using Endurance.Re.ReSolver.Infrastructure.Constants;
using Endurance.Re.ReSolver.Infrastructure.Events;
using Endurance.Re.ReSolver.ProgramModule.View;
using Endurance.Re.ReSolver.ProgramModule.ViewModel;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;

namespace CatWorkbookPrismPoc.ProgramModule.Commands
{
    public class ProgramModuleViewCommand : ICommand
    {
        #region Fields

        private IProgramTaskButtonViewModel _viewModel;
        private IRegionManager _regionManager;
        private IEventAggregator _eventAggregator;

        #endregion

        #region Constructor

        public ProgramModuleViewCommand(IProgramTaskButtonViewModel viewModel, IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _viewModel = viewModel;
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
        }

        #endregion

        #region ICommand Members

        /// <summary>
        /// Whether ProgramViewModuleCommand is enabled.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Actions to take when CanExceute() changes
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        /// <summary>
        /// Executes the ShowModuleAViewCommand
        /// </summary>
        public void Execute(object parameter)
        {
            // Show Ribbon Tab
            //var programModuleTab = new Uri(typeof(ProgramRibbonView).FullName, UriKind.Relative);
            //_regionManager.RequestNavigate(RegionNames.RibbonRegion, programModuleTab);

            // Show Navigator
            //var programModuleNavigator = new Uri(typeof(ProgramModuleNavigatorView).FullName, UriKind.Relative);
            //_regionManager.RequestNavigate(RegionNames.NavigatorRegion, programModuleNavigator);

            /* We invoke the NavigationCompleted() callback 
             * method in our final  navigation request. */

            // Show Workspace
            var programModuleWorkspace = new Uri(typeof(ProgramView).FullName, UriKind.Relative);
            _regionManager.RequestNavigate(RegionNames.WorkspaceRegion, programModuleWorkspace, NavigationCompleted);
        }


        #endregion

        #region Private Methods

        private void NavigationCompleted(NavigationResult result)
        {
            // Exit if navigation was not successful
            if (result.Result != true)
                return;

            // Publish ViewRequestedEvent
            var navigationCompletedEvent = _eventAggregator.GetEvent<NavigationCompletedEvent>();
            navigationCompletedEvent.Publish("ProgramModule");
        }

        #endregion
    }
}
