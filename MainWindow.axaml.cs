using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia;
namespace HolaAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Title = "Triple T";
        saludo.Text = "JavierCumplidoNúñez";
        saludo.Foreground = Brushes.Crimson;
        saludo.FontSize = 20;
        saludo.Margin = new Thickness(10);
        var extra = new Button
        {
            Content = "Botón en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };
        panel.Children.Add(extra);
        extra.Click += VentanaCS_Click;
        MyButton.Click += OnButtonClick;
    }
    private void VentanaCS_Click(object? sender, RoutedEventArgs e)
    {
        new VentanaCS().Show();

    }

    private void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        saludo.Text = "¡Me has pulsado!";
    }


}