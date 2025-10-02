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
using System.Windows.Shapes;

namespace Wpftest1
{
    /// <summary>
    /// Interaction logic for SelectionWindow.xaml
    /// </summary>
    public partial class SelectionWindow : Window
    {
        public PokemonCardModel SelectedPokemon { get; set; }
        public SelectionWindow(PokemonCardModel pikachu, PokemonCardModel charmander, PokemonCardModel squirtle)
        {
            InitializeComponent();
            PikachuButton.Tag = pikachu;
            CharmanderButton.Tag = charmander;
            SquirtleButton.Tag = squirtle;
        }
        private void Choose_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            SelectedPokemon = (PokemonCardModel)btn.Tag;
            DialogResult = true;
        }

        private void CharmanderButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }   

}
