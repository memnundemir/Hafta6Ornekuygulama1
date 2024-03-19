using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oyun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int[] sifre = new int[] { 2, 2, 3, 1, 0, 0, 1, 3, 2, 1, 0 };
        int index = 0;
       
        public MainWindow()
        {
            InitializeComponent();


           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ekran.RowDefinitions.Add(new RowDefinition() { });
            ekran.RowDefinitions.Add(new RowDefinition() { });


            ekran.ColumnDefinitions.Add(new ColumnDefinition() { });
            ekran.ColumnDefinitions.Add(new ColumnDefinition() { });

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Button btn = new Button();
                    btn.Margin = new Thickness(5);
                    ekran.Children.Add(btn);

                    Grid.SetColumn(btn, i);
                    Grid.SetRow(btn, j);

                    btn.Click += Btn_Click;

                    btn.Content = "i: " + i + "j: " + j;

                }
            }



        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button a = (Button)sender;

            if (sifre[index] == ekran.Children.IndexOf(a))
            {
                index++;
            }
            else
                index = 0;
            if (index == sifre.Length) this.Close();
        }
    }
}