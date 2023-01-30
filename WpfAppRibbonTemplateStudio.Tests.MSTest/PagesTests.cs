using System.IO;
using System.Reflection;

using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Prism.Regions;

using Unity;

using WpfAppRibbonTemplateStudio.Contracts.Services;
using WpfAppRibbonTemplateStudio.Core.Contracts.Services;
using WpfAppRibbonTemplateStudio.Core.Services;
using WpfAppRibbonTemplateStudio.Models;
using WpfAppRibbonTemplateStudio.Services;
using WpfAppRibbonTemplateStudio.ViewModels;

namespace WpfAppRibbonTemplateStudio.Tests.MSTest;

[TestClass]
public class PagesTests
{
    private readonly IUnityContainer _container;

    public PagesTests()
    {
        _container = new UnityContainer();
        _container.RegisterType<IRegionManager, RegionManager>();

        // Core Services
        _container.RegisterType<IFileService, FileService>();

        // App Services
        _container.RegisterType<IThemeSelectorService, ThemeSelectorService>();
        _container.RegisterType<ISystemService, SystemService>();
        _container.RegisterType<ISampleDataService, SampleDataService>();
        _container.RegisterType<IPersistAndRestoreService, PersistAndRestoreService>();
        _container.RegisterType<IApplicationInfoService, ApplicationInfoService>();

        // Configuration
        var appLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location);
        var configuration = new ConfigurationBuilder()
            .SetBasePath(appLocation)
            .AddJsonFile("appsettings.json")
            .Build();
        var appConfig = configuration
            .GetSection(nameof(AppConfig))
            .Get<AppConfig>();

        // Register configurations to IoC
        _container.RegisterInstance(configuration);
        _container.RegisterInstance(appConfig);
    }

    // TODO: Add tests for functionality you add to ContentGridViewModel.
    [TestMethod]
    public void TestContentGridViewModelCreation()
    {
        var vm = _container.Resolve<ContentGridViewModel>();
        Assert.IsNotNull(vm);
    }

    // TODO: Add tests for functionality you add to DataGridViewModel.
    [TestMethod]
    public void TestDataGridViewModelCreation()
    {
        var vm = _container.Resolve<DataGridViewModel>();
        Assert.IsNotNull(vm);
    }

    // TODO: Add tests for functionality you add to ListDetailsViewModel.
    [TestMethod]
    public void TestListDetailsViewModelCreation()
    {
        var vm = _container.Resolve<ListDetailsViewModel>();
        Assert.IsNotNull(vm);
    }

    // TODO: Add tests for functionality you add to MainViewModel.
    [TestMethod]
    public void TestMainViewModelCreation()
    {
        var vm = _container.Resolve<MainViewModel>();
        Assert.IsNotNull(vm);
    }

    // TODO: Add tests for functionality you add to SettingsViewModel.
    [TestMethod]
    public void TestSettingsViewModelCreation()
    {
        var vm = _container.Resolve<SettingsViewModel>();
        Assert.IsNotNull(vm);
    }
}
