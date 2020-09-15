using Lab8.Model;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Newitem> Newitems;
        public MainPage()
        {
            this.InitializeComponent();
            Newitems = new ObservableCollection<Newitem>();
        }

        private void HumburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Financial.IsSelected)
            {
                NewsManager.GetNews("Financial", Newitems);
                TitleTextBlock.Text = "Financial";
            }
            else if (Food.IsSelected)
            {
                NewsManager.GetNews("Food", Newitems);
                TitleTextBlock.Text = "Food";
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Financial.IsSelected = true;
        }
    }
}