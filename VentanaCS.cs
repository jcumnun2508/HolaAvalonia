using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
namespace HolaAvalonia;   // copia aquí el namespace de MainWindow.axaml.cs
public class VentanaCS : Window
{
    // Campo para poder usar el TextBlock desde cualquier método
    private TextBlock saludo = null!;
    public VentanaCS()
    {
        InitializeComponent();
    }
    // Este método lo escribes tú: aquí se construye la interfaz
    private void InitializeComponent()
    {
        // 1) Propiedades de la ventana: Title, Width y Height
        Title = "P de tu DD C#";
        Width = 500;
        Height = 250;
        // 2) Crea el TextBlock con tu nombre y guárdalo en "saludo"
        saludo = new TextBlock()
        {
            Text = "JavierCumplidoNúñez",
            FontSize = 20,
            Margin = new Thickness(10)
        };
        saludo.Foreground = Brushes.Crimson;
        // 3) Crea el Button con el mismo texto que en MainWindow
        var MyButton = new Button()
        {
            Content = "Púlsame",
            Margin = new Thickness(0, 10, 0, 0),
        };
        MyButton.Click += OnButtonClick;

        var boton = new Button()
        {
            Content = "Botón en C#",
            Margin = new Thickness(0, 10, 0, 0),
        };
        boton.Click += VentanaMW_Click;
        // 4) Asigna a Content un StackPanel que contenga los dos
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(saludo);
        panel.Children.Add(MyButton);
        panel.Children.Add(boton);
        Content = panel;
    }
    private void VentanaMW_Click(object? sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
    }
    private void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        saludo.Text = "¡Me has pulsado!";
    }

}