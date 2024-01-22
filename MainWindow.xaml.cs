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

namespace savichev9pr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public Classes.Warrior1 Warior1 = new Classes.Warrior1(100, 10, 2);
        public Classes.Warrior2 Warior2 = new Classes.Warrior2(100, 10, 2);
        public void AttackEnemy(object sender, MouseButtonEventArgs e)
        {
            if (Warior1.Health > 0)
            {
                Warior1.damage();
                InfoPlayer();
                if (Warior1.Health <= 0)
                {
                    MessageBox.Show("Game Over");
                    InfoPlayer();
                }
            }
        }
        private void AttackEnemy2(object sender, MouseButtonEventArgs e)
        {
            if (Warior2.Health > 0)
            {
                Warior2.damage();
                InfoPlayer();
                if (Warior2.Health <= 0)
                {
                    MessageBox.Show("Game Over");
                    InfoPlayer();
                }
            }
        }

        public void InfoPlayer()
        {
            playerHP.Content = "Жизненные показатели: " + Warior1.Health;
            playerAR.Content = "Броня: " + Warior1.Armor;

            playerHP1.Content = "Жизненные показатели: " + Warior2.Health;
            playerAR1.Content = "Броня: " + Warior2.Armor;
        }
    }
}
