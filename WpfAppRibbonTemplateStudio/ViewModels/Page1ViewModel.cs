using Prism.Mvvm;

namespace WpfAppRibbonTemplateStudio.ViewModels;

public class Page1ViewModel : BindableBase
{
    private string _alias;
    public string Alias
    {
        get { return _alias; }
        set { SetProperty(ref _alias, value); }
    }

    private int _employeeNumber;
    public int EmployeeNumber
    {
        get { return _employeeNumber; }
        set { SetProperty(ref _employeeNumber, value); }
    }
}
