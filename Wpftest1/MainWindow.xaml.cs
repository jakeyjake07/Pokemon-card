using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpftest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PokemonCardModel _pikachu;
        private PokemonCardModel _charmander;
        private PokemonCardModel _squirtle;
        public MainWindow()
        {
            InitializeComponent();

            _pikachu = new PokemonCardModel
            {
                Name = "Pikachu",
                Hp = "80",
                SubInfo = "Pikachu is very heavy and short",
                ElementType = ElementType.Electric,
                Attacks =
                {
                    new PokemonAttack
                    {
                        Name = "Lightning bolt",
                        Damage = "70",
                        Description = "bzzzzzz",
                        ElementType = ElementType.Electric
                    },

                    new PokemonAttack
                    {
                        Name = "Quick Attack",
                        Damage = "20",
                        Description = "Quick asf",
                        ElementType = ElementType.Electric
                    }


                },
                Weakness = "Rock",
                Resistance = "Water",
                Retreat = "Go home",
                SetNumber = "19/151",
                FooterText = "Always brimming with power",
                Rarity = "DOT"
            };


            _charmander = new PokemonCardModel
            {
                Name = "Charmander",
                Hp = "85",
                SubInfo = "Charmander is very warm",
                ElementType = ElementType.Fire,
                Attacks =
                {
                    new PokemonAttack
                    {
                        Name = "Firebreath",
                        Damage = "100",
                        Description = "Rawr",
                        ElementType = ElementType.Fire
                    },

                    new PokemonAttack
                    {
                        Name = "Claw",
                        Damage = "20",
                        Description = "Sharp claws",
                        ElementType = ElementType.Colorless
                    }
                },

                Weakness = "Water",
                Resistance = "Rock",
                Retreat = "Go Home",
                SetNumber = "4/151",
                FooterText = "Hot as fire",
                Rarity = "DOT"

            };

            _squirtle = new PokemonCardModel()
            {
                Name = "Squirtle",
                Hp = "75",
                SubInfo = "Squirtle is wet and light",
                ElementType = ElementType.Water,
                Attacks =
                {
                    new PokemonAttack
                    {
                        Name = "Bubbles",
                        Damage = "50",
                        Description = "ooOoOOo",
                        ElementType = ElementType.Water
                    },

                    new PokemonAttack
                    {
                        Name = "Claw",
                        Damage = "20",
                        Description = "Sharp claws",
                        ElementType = ElementType.Colorless
                    }
                },

                Weakness = "Electric",
                Resistance = "Rock",
                Retreat = "Go Home",
                SetNumber = "7/151",
                FooterText = "Slippery",
                Rarity = "DOT"
            };


           SetupWindow(_pikachu);

        }
        
        public void OpenSelectionWindowClick(Object sender, RoutedEventArgs e)
        {
            var picker = new SelectionWindow(_pikachu, _charmander, _squirtle) { Owner = this };
            if (picker.ShowDialog() == true)
            {
                SetupWindow(picker.SelectedPokemon);
            }
        }
        public void SetupWindow(PokemonCardModel pokemon)
        {
            NameTextBlock.Text = pokemon.Name;
            HpTextBlock.Text = pokemon.Hp;
            SubInfoTextBlock.Text = pokemon.SubInfo;


            Attack1IconTextBlock.Text = pokemon.Attacks[0].ElementType.ToString();
            Attack1NameTextBlock.Text = pokemon.Attacks[0].Name;
            Attack1DMGTextBlock.Text = pokemon.Attacks[0].Damage;
            Attack1DescTextBlock.Text = pokemon.Attacks[0].Description;

            Attack2Icon.Text = pokemon.Attacks[1].ElementType.ToString();
            Attack2NameTextBlock.Text = pokemon.Attacks[1].Name;
            Attack2DMGTextBlock.Text = pokemon.Attacks[1].Damage;
            Attack2DescTextBlock.Text = pokemon.Attacks[1].Description;

            WeaknessTextBlock.Text = pokemon.Weakness;
            ResistanceTextBlock.Text = pokemon.Resistance;
            RetreatTextBlock.Text = pokemon.Retreat;
            
            SetNumberTextBlock.Text = pokemon.SetNumber;
            FooterTextTextBlock.Text = pokemon.FooterText;
            CopyWrightTextBlock.Text = pokemon.Rarity;



        }

    }

}