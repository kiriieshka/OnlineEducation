using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace OnlineEducation.customcontrols
{
    public partial class MenuButtons : UserControl
    {
        private Window _currentWindow;
        public MenuButtons()
        {
            InitializeComponent();
            this.DataContext = new MenuButtonViewModel();
        }

        // Свойство Icon
        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(MenuButtons));

        // Свойство IconWidth
        public int IconWidth
        {
            get { return (int)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(int), typeof(MenuButtons));

        // Свойство IndicatorBrush
        public SolidColorBrush IndicatorBrush
        {
            get { return (SolidColorBrush)GetValue(IndicatorBrushProperty); }
            set { SetValue(IndicatorBrushProperty, value); }
        }

        public static readonly DependencyProperty IndicatorBrushProperty =
            DependencyProperty.Register("IndicatorBrush", typeof(SolidColorBrush), typeof(MenuButtons));

        // Свойство IndicatorCornerRadius
        public int IndicatorCornerRadius
        {
            get { return (int)GetValue(IndicatorCornerRadiusProperty); }
            set { SetValue(IndicatorCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty IndicatorCornerRadiusProperty =
            DependencyProperty.Register("IndicatorCornerRadius", typeof(int), typeof(MenuButtons));

        // Свойство Text
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MenuButtons));

        // Свойство Padding
        public new Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

        public static new readonly DependencyProperty PaddingProperty =
            DependencyProperty.Register("Padding", typeof(Thickness), typeof(MenuButtons));

        // Свойство IsSelected
        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(MenuButtons));

        // Свойство GroupName
        public string GroupName
        {
            get { return (string)GetValue(GroupNameProperty); }
            set { SetValue(GroupNameProperty, value); }
        }

        public static readonly DependencyProperty GroupNameProperty =
            DependencyProperty.Register("GroupName", typeof(string), typeof(MenuButtons));

        // Обработчик события для RadioButton
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Логика обработки нажатия на радио-кнопку
            RadioButton radioButton = sender as RadioButton;
            string windowName = radioButton?.Tag.ToString();
            // Закрываем предыдущее окно, если оно открыто
            _currentWindow?.Close();

            switch (windowName)
            {
                case "Window1":
                    MainWindow window1 = new MainWindow();
                    window1.Show();
                    break;
                case "Window2":
                    Window2 window2 = new Window2();
                    window2.Show();
                    break;
                case "Window3":
                    Window3 window3 = new Window3();
                    window3.Show();
                    break;
                //case "Window4":
                    //MainWindow window4 = new Window4();
                   // window4.Show();
                   // break;
                default:
                    break;
            }
        }
            //Обобщенный метод для открытия окон
            private void OpenWindow<T>() where T : Window, new()
            {
            // Создание и отображение окна
            T window = new T();
            window.Show();
            }
        }
}
