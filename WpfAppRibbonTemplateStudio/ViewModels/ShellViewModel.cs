using System.Windows.Input;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

using WpfAppRibbonTemplateStudio.Constants;
using WpfAppRibbonTemplateStudio.Contracts.Services;

namespace WpfAppRibbonTemplateStudio.ViewModels;

public class ShellViewModel : BindableBase
{
    private readonly IRegionManager _regionManager;
    private readonly IRightPaneService _rightPaneService;
    private IRegionNavigationService _navigationService;
    private ICommand _loadedCommand;
    private ICommand _unloadedCommand;

    public ICommand LoadedCommand => _loadedCommand ?? (_loadedCommand = new DelegateCommand(OnLoaded));

    public ICommand UnloadedCommand => _unloadedCommand ?? (_unloadedCommand = new DelegateCommand(OnUnloaded));

    public ShellViewModel(IRegionManager regionManager, IRightPaneService rightPaneService)
    {
        _regionManager = regionManager;
        _rightPaneService = rightPaneService;
    }

    private void OnLoaded()
    {
        _navigationService = _regionManager.Regions[Regions.Main].NavigationService;
        _navigationService.RequestNavigate(PageKeys.Main);
    }

    // Images Icons are added to the project as resources: Build Action -> xcopy files
    
    ICommand _menuItem1InvokedCommand;
    public ICommand NavigateHomePageInvokedCommand => _menuItem1InvokedCommand ?? (_menuItem1InvokedCommand = new DelegateCommand(RequestNavigateHome));

    private void RequestNavigateHome()
    {
        //if (_navigationService.CanNavigate(target))
        //{
            _navigationService.RequestNavigate(PageKeys.Main);
        //}
    }

    ICommand _menuItem2InvokedCommand;
    public ICommand NavigateMetroIconPacksPageInvokedCommand => _menuItem2InvokedCommand ?? (_menuItem2InvokedCommand = new DelegateCommand(RequestNavigateMetroIconPacks));

    private void RequestNavigateMetroIconPacks()
    {
        //if (_navigationService.CanNavigate(target))
        //{
        _navigationService.RequestNavigate(PageKeys.MetroIconPacks);
        //}
    }

    ICommand _menuItem3InvokedCommand;
    public ICommand NavigateListDetailsPageInvokedCommand => _menuItem3InvokedCommand ?? (_menuItem3InvokedCommand = new DelegateCommand(RequestNavigateListDetails));

    private void RequestNavigateListDetails()
    {
        _navigationService.RequestNavigate(PageKeys.ListDetails);
    }

    ICommand _menuItem4InvokedCommand;
    public ICommand NavigatePage1InvokedCommand => _menuItem4InvokedCommand ?? (_menuItem4InvokedCommand = new DelegateCommand(RequestNavigatePage1));

    private void RequestNavigatePage1()
    {
        _navigationService.RequestNavigate(PageKeys.Page1);
    }

    ICommand _menuItem5InvokedCommand;
    public ICommand NavigateDataGridPageInvokedCommand => _menuItem5InvokedCommand ?? (_menuItem5InvokedCommand = new DelegateCommand(RequestNavigateDataGrid));

    private void RequestNavigateDataGrid()
    {
        _navigationService.RequestNavigate(PageKeys.DataGrid);
    }

    ICommand _menuItem6_InvokedCommand;
    public ICommand NavigateContentGridPageInvokedCommand => _menuItem6_InvokedCommand ?? (_menuItem6_InvokedCommand = new DelegateCommand(RequestNavigateContentGrid));

    private void RequestNavigateContentGrid()
    {
        _navigationService.RequestNavigate(PageKeys.ContentGrid);
    }
    

    private void OnUnloaded()
    {
        _regionManager.Regions.Remove(Regions.Main);
        _rightPaneService.CleanUp();
    }
}
