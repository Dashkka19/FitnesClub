using Fitnes.DataBase;
using Fitnes.ForPersonal;
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

namespace Fitnes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class GlavnoeMenu : Window
    {
        // Статическая переменная для контроля доступа
        public static bool IsInstructorSelected { get; private set; } = false;
        public GlavnoeMenu()
        {
            InitializeComponent();
        }

        private void Proverka_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, выбран ли RadioButton ManagerClick или InstructorClick
            if (!ManagerClick.IsChecked.Value && !InstructorClick.IsChecked.Value)
            {
                // Выводим сообщение об ошибке
                MessageBox.Show("Пожалуйста, выберите Менеджера или Инструктора.");
                return;
            }

            // Если выбран менеджер, открываем окно менеджера
            if (ManagerClick.IsChecked == true)
            {
                IsInstructorSelected = false; // Устанавливаем, что выбран менеджер
                VhodManagera cfrm = new VhodManagera();
                cfrm.Show();
            }
            // Если выбран Инструктор, открываем окно инструктора
            if (InstructorClick.IsChecked == true)
            {
                IsInstructorSelected = true; // Устанавливаем, что выбран инструктор
                VhodInstructora cfrm = new VhodInstructora();
                cfrm.Show();
            }
        }
    }
}
