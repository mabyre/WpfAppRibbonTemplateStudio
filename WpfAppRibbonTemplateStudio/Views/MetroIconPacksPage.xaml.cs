using System.Windows.Controls;

namespace WpfAppRibbonTemplateStudio.Views;

public partial class MetroIconPacksPage : UserControl
{
    bool toggle = true;

    public MetroIconPacksPage()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        if (toggle)
        {
            TextBlockDemo.Text = "Coucou 1";
            toggle = false;
        }
        else
        {
            TextBlockDemo.Text = "Coucou 2";
            toggle = true;
        }
    }
}
