using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TokenizedTag;


namespace TokenizedTagTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Tags = new() { "Test", "Wahnsinn", "123", "Warum" };

            InitializeComponent();

            //ProjectsControl.AllTags
        }

        public List<string> Tags { get; set; }

        public string Text { get; set; }

        private void ProjectsControl_TagApplied(object sender, TokenizedTag.TokenizedTagEventArgs e)
        {
            LastApplied.Content = e.Item.Text;
        }

        private void ProjectsControl_TagClick(object sender, TokenizedTag.TokenizedTagEventArgs e)
        {
            LastClicked.Content = e.Item.Text;
        }

        private void ProjectsControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Exception when navigating through AutoCompleteBox
            //if (e.AddedItems.Count > 0)
            //    SelectionChanged.Content = e.AddedItems.Cast<TokenizedTagItem>().Last().Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProjectsControl.AllTags = Tags;
        }
    }
}
