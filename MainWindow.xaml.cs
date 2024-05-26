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

namespace _03.ToDoList_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToDoButton_Click(object sender, RoutedEventArgs e)
        {
            //assign ToDoInput text to string
            string input = ToDoInput.Text;
            //check if string is not empty
            if (!string.IsNullOrEmpty(input))
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = input,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                ToDoList.Children.Add(textBlock);
                //MainScroller always go to the bottom
                MainScroll.ScrollToEnd();
            }
            ToDoInput.Clear();
            ToDoInput.Focus();
        }
    }
}