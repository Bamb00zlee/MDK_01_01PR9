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
using Voin_Patrusheva.Classes;

namespace Voin_Patrusheva
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hard hardVoin = new Hard(100);
        private Legkie legkiyVoin = new Legkie(100);
        public MainWindow()
        {
            InitializeComponent();
        }

        // тяжелые доспехи
        private void AttackHard(object sender, MouseButtonEventArgs e)
        {
            // Берем урон из левого текстбокса
            if (int.TryParse(HDYron.Text, out int yron))
            {
                hardVoin.GetYron(yron);

                playerHealthLD.Content = "Жизненные показатели: " + hardVoin.lives;

                if (hardVoin.lives <= 0)
                {
                    playerHealthLD.Content = "Жизненные показатели: умер";
                }
            }
        }

        // легкие доспехи
        private void AttackEnemy(object sender, MouseButtonEventArgs e)
        {
            // Берем урон из правого текстбокса
            if (int.TryParse(LDYron.Text, out int yron))
            {
                legkiyVoin.GetYron(yron);

                playerHealthHD.Content = "Жизненные показатели: " + legkiyVoin.lives;

                if (legkiyVoin.lives <= 0)
                {
                    playerHealthHD.Content = "Жизненные показатели: умер";
                }
            }
        }
    }
}
