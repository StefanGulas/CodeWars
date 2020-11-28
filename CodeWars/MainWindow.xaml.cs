using System.Windows;

namespace CodeWars
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      DataContext = this;
      var translation = new NumberTranslation();
    }
  }

}


