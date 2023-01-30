using WpfAppRibbonTemplateStudio.Models;

namespace WpfAppRibbonTemplateStudio.Contracts.Services;

public interface IThemeSelectorService
{
    void InitializeTheme();

    void SetTheme(AppTheme theme);

    AppTheme GetCurrentTheme();
}
