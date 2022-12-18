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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace lab_dop_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<DataGridItem> _tmp = new ObservableCollection<DataGridItem>();
        readonly Window _window = Application.Current.MainWindow;

        public MainWindow()
        {
            InitializeComponent();
            _window = Application.Current.MainWindow;
            _tmp.Add(new DataGridItem(1.0));
            _tmp.Add(new DataGridItem(1.0));
            _tmp.Add(new DataGridItem(8.0));
            _tmp.Add(new DataGridItem(9.0));
            _tmp.Add(new DataGridItem(10.0));
            DataGridMain.ItemsSource = _tmp;
        }

        /// <summary>
        /// Изменения шрифта для всей формы
        /// </summary>
        /// <param name="newFont">Название нового шрифта, например "Arial"</param>
        private void ChangeFont(string newFont)
        {
            this.FontFamily = new FontFamily(newFont);
        }

        /// <summary>
        /// Применение шрифта из ComboBox
        /// </summary>
        private void ComboBoxOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ComboBoxItem)ComboBoxFont.SelectedItem;
            if (selectedItem is null) return;
            if (ComboBoxItemTitle.IsSelected)
            {
                ComboBoxFont.SelectedItem = null;
                return;
            }

            ChangeFont(selectedItem.Content.ToString());
        }

        /// <summary>
        /// Добавить новый шрифт в ComboBox из textbox по нажатию на Enter
        /// </summary>
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

        /// <summary>
        /// Удалить выделенный в DataGrid элемент
        /// </summary>
        private void MenuItem_Delete_OnClick(object sender, RoutedEventArgs e)
        {
            var numbers = DataGridMain.SelectedItems.OfType<DataGridItem>().ToList();

            // Remove items
            var tmp = (ObservableCollection<DataGridItem>)DataGridMain.ItemsSource;
            foreach (var dataGridItem in numbers)
            {
                tmp.Remove(dataGridItem);
            }
        }

        /// <summary>
        /// Определить количество и сумму чисел с четной целой частью
        /// </summary>
        private void MenuItem_CalcSum_OnClick(object sender, RoutedEventArgs e)
        {
            var numbers = DataGridMain.Items.OfType<DataGridItem>().Where(item => (int)item.Number % 2 == 0).ToList();

            MessageBox.Show($"Количество: {numbers.Count}\nСумма: {numbers.Sum(item => item.Number)}");
        }

        /// <summary>
        /// Определить среднее геометрическое дробной части положительных чисел.
        /// Результат выдать в качестве сообщения
        /// </summary>
        private void MenuItem_CalcGeo_OnClick(object sender, RoutedEventArgs e)
        {
            var numbers = DataGridMain.Items.OfType<DataGridItem>().Where(x => x.Number > 0).ToList();
            double agr = 1.0;

            foreach (var i in numbers)
                agr *= i.Number - (int)i.Number;
            
            MessageBox.Show($"Ответ: {Math.Pow(agr, 1.0 / numbers.Count)}");
        }
        
        /// <summary>
        /// Добавить строку из TextBox
        /// </summary>
        private void MenuItemAddItemFromTextBoxOnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxForListBox.Text))
            {
                MessageBox.Show("Need content in TextBox");
                return;
            }

            ListBox1.Items.Add(TextBoxForListBox.Text);
            TextBoxForListBox.Text = "";
        }

        /// <summary>
        /// Удалить выделенные элементы
        /// </summary>
        private void MenuItemRemoveItemFromListBoxOnClick(object sender, RoutedEventArgs e)
        {
            foreach (string s in ListBox1.SelectedItems.OfType<string>().ToList())
                ListBox1.Items.Remove(s);
        }

        /// <summary>
        /// Найти текст, составленный из строк максимальной и минимальной длины
        /// </summary>
        private void MenuItemShowMinMaxTextOnClick(object sender, RoutedEventArgs e)
        {
            if (ListBox1.Items.Count == 0)
            {
                MessageBox.Show("Need content in ListBox");
                return;
            }
            var dataByConditionSortedLen = ListBox1.Items.OfType<string>().OrderBy(x => x.Length);
            MessageBox.Show($"{dataByConditionSortedLen.Last()}\n{dataByConditionSortedLen.First()}", "Текст, составленный из строк максимальной и минимальной длины");
        }

        /// <summary>
        /// Найти текст, полученный после удаления пробелов из нечетных строк и удвоения пробелов в четных строчках
        /// </summary>
        private void MenuItemShowEditedTextOnClick(object sender, RoutedEventArgs e)
        {
            if (ListBox1.Items.Count == 0)
            {
                MessageBox.Show("Need content in ListBox");
                return;
            }

            var elCnt = 1;
            var answer = "Text: ";
            foreach (var item in ListBox1.Items.OfType<string>())
            {
                answer += elCnt % 2 == 0 ? item.Replace(" ", "") : item.Replace(" ", "  ");
                elCnt++;
            }

            MessageBox.Show(answer);
        }

        private void CheckBoxOnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            RadioButtonPanel.IsEnabled = !RadioButtonPanel.IsEnabled;
        }

        private void RadioButtonOnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Красный":
                {
                    this.Background = new SolidColorBrush(Colors.Red);
                    break;
                }
                case "Голубой":
                {
                    this.Background = new SolidColorBrush(Colors.Blue);
                    break;
                }
                case "Зеленый":
                {
                    this.Background = new SolidColorBrush(Colors.Green);
                    break;
                }
                case "Серый":
                {
                    this.Background = new SolidColorBrush(Colors.Gray);
                    break;
                }
                case "Белый":
                {
                    this.Background = new SolidColorBrush(Colors.White);
                    break;
                }
                case "Желтый":
                {
                    this.Background = new SolidColorBrush(Colors.Yellow);
                    break;
                }
            }
        }
    }
}