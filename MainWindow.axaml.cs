using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace HolaAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Title = "Triple T";
        saludo.Text = "Saludos desde C#";
        saludo.Foreground = Brushes.Crimson;
    }

    private void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        MyButton.Content = "¡Me has pulsado!";
    }
}