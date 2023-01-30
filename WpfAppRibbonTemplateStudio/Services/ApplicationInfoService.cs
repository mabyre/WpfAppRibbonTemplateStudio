using System.Diagnostics;
using System.Reflection;

using WpfAppRibbonTemplateStudio.Contracts.Services;

namespace WpfAppRibbonTemplateStudio.Services;

public class ApplicationInfoService : IApplicationInfoService
{
    public ApplicationInfoService()
    {
    }

    public Version GetVersion()
    {
        // Set the app version in WpfAppRibbonTemplateStudio > Properties > Package > PackageVersion
        string assemblyLocation = Assembly.GetExecutingAssembly().Location;
        var version = FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
        return new Version(version);
    }
}
