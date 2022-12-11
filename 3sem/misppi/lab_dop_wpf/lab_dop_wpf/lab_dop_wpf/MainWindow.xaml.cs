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

namespace lab_dop_wpf
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

        private void ChangeFont(string newFont)
        {
            this.FontFamily = new FontFamily(newFont);
        }

        private void ComboBoxOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ComboBoxItem)ComboBoxFont.SelectedItem;
            if (selectedItem is null) return;
            if (ComboBoxItemTitle.IsSelected)
            {
                //ComboBoxTitles.SelectedItem = ComboBoxTitles.Items[ComboBoxTitles.Items.Count-2];
                ComboBoxFont.SelectedItem = null;
                return;
            }

            ChangeFont(selectedItem.Content.ToString());
        }

        private void TextBoxAddTitleOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string newFont = TextBoxAddTitle.Text;
                var cbi = new ComboBoxItem();
                cbi.Content = newFont;
                cbi.FontFamily = new FontFamily(newFont);

                ComboBoxFont.Items.Insert(ComboBoxFont.Items.Count - 1, cbi);
                ChangeFont(newFont);
                ComboBoxFont.SelectedItem = cbi;
            }
        }

        private void MenuItem_Delete_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_CalcSum_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_CalcGeo_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItemAddItemFromTextBoxOnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItemRemoveItemFromListBoxOnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItemShowMinMaxTextOnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItemShowEditedTextOnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BlockComboBoxOnClick(object sender, RoutedEventArgs e)
        {
            ComboBoxFont.IsEnabled = !ComboBoxFont.IsEnabled;
        }
    }
}