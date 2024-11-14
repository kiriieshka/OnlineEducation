using OnlineEducation.customcontrols;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace OnlineEducation
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }


        private void Close_Click1(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public ObservableCollection<ScheduleEntry> ScheduleEntries { get; set; }

        private void LoadSchedule()
        {
            ScheduleEntries = new ObservableCollection<ScheduleEntry>
            {
                new ScheduleEntry { Time = "9:00 - 10:00" },
                new ScheduleEntry { Time = "10:00 - 11:00" },
                new ScheduleEntry { Time = "11:00 - 12:00" },
                new ScheduleEntry { Time = "12:00 - 13:00" },
                new ScheduleEntry { Time = "13:00 - 14:00" }
            };
        }

        private void SaveScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика сохранения расписания (в файл, базу данных и т.д.)
            MessageBox.Show("Расписание сохранено!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void ScheduleDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

