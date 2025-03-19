using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LabWork9.ViewModels;

namespace LabWork9.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
