using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace OnlineEducation.customcontrols
{
    public class MenuButtonViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MenuItem> _menuItems;
        private MenuItem _selectedItem;

        public ObservableCollection<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set
            {
                if (_menuItems != value)
                {
                    _menuItems = value;
                    OnPropertyChanged(nameof(MenuItems));
                }
            }
        }

        public MenuItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                    UpdateMenuItems(); // Обновляем список кнопок при выборе
                }
            }
        }

        public MenuButtonViewModel()
        {
            // Инициализация коллекции
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem { Text = "Button 1", Tag = "Window3" },
                new MenuItem { Text = "Button 2", Tag = "Window4" },
                new MenuItem { Text = "Button 3", Tag = "Window2" },
                new MenuItem { Text = "Button 4", Tag = "Window1" }
            };
        }

        private void UpdateMenuItems()
        {
            if (SelectedItem != null)
            {
                // Обновляем список, исключая выбранный элемент
                var updatedItems = _menuItems.Where(item => item != SelectedItem).ToList();
                MenuItems = new ObservableCollection<MenuItem>(updatedItems);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MenuItem
    {
        public string Text { get; set; }
        public string Tag { get; set; }
        public bool IsChecked { get; set; }
    }
}
