using System;
using System.Windows;
using System.Windows.Controls;

namespace Prakt9
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

        Films[] films;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            films = new Films[7];
            for (int i = 0; i < films.Length; i++)
                films[i] = new Films("Введите название", "Введите жанр", 2000, 100);

            dataGridFilmLibrary.ItemsSource = films;
        }

        private void dataGridFilmLibrary_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int rowIndex = e.Row.GetIndex();
            int columnIndex = e.Column.DisplayIndex;
            int n;
            switch (columnIndex)
            {
                case 0:
                    films[rowIndex].Name = ((TextBox)e.EditingElement).Text;
                    break;
                case 1:
                    films[rowIndex].Genre = ((TextBox)e.EditingElement).Text;
                    break;
                case 2:
                    if (Int32.TryParse(((TextBox)e.EditingElement).Text, out n))
                        films[rowIndex].Year = n;
                    else MessageBox.Show("Введите правильное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                case 3:
                    if (Int32.TryParse(((TextBox)e.EditingElement).Text, out n))
                        films[rowIndex].Length = n;
                    else MessageBox.Show("Введите правильное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            tbSearchResult.Clear();

            for (int i = 0; i < films.Length; i++)
                if (films[i].Genre == tbSearchByGenre.Text) tbSearchResult.Text += $"{films[i].Name}\n";
        }

        private void miInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Антонишин Кирилл Сергеевич\n" +
                "Практическая работа №9\n" +
                "Заполнить таблицу фильмотеки на 7 кассет с полями: фильм, жанр, год выпуска, продолжительность просмотра. " +
                "Вывести результат на экран. Вывести список фильмов заданного жанра.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
