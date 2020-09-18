using Product.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Product
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        //private List<Contact> Contacts;
        private ObservableCollection<Contact> Contacts;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/1.png" });
            Icons.Add(new Icon { IconPath = "Assets/2.png" });
            Icons.Add(new Icon { IconPath = "Assets/3.png" });
            Icons.Add(new Icon { IconPath = "Assets/4.png" });
            Icons.Add(new Icon { IconPath = "Assets/5.png" });
            Icons.Add(new Icon { IconPath = "Assets/6.png" });
            Icons.Add(new Icon { IconPath = "Assets/7.png" });
            Icons.Add(new Icon { IconPath = "Assets/8.png" });
            //Contacts = new List<Contact>();
            Contacts = new ObservableCollection<Contact>();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)AvatarComboBox.SelectedValue).IconPath;
            Contacts.Add(new Contact { Product = ProductTextBox.Text, Descripion = DescripionTextBox.Text, AvatarPath = avatar });
            ProductTextBox.Text = "";
            DescripionTextBox.Text = "";
            AvatarComboBox.SelectedIndex = -1;
            ProductTextBox.Focus(FocusState.Programmatic);
            DescripionTextBox.Focus(FocusState.Programmatic);
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}