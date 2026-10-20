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
        saludo.Text = "Saludos desde C#";
        saludo.Foreground = Brushes.Crimson;
        var extra = new Button
        {
            Content = "Botón creado en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };
            panel.Children.Add(extra);
            MyButton.Click += Boton_Click;

        }
    private void Boton_Click(object? sender, RoutedEventArgs e) 
    {
        MyButton.Content = "¡Me has pulsado c#!";
    }

    private void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        MyButton.Content = "¡Me has pulsado!";
    }
    

}