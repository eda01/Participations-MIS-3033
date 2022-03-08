using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;

namespace JSONPokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://pokeapi.co/api/v2/pokemon/?offset=0&limit=1200";

            string json;

            //HttpClient client = new HttpClient();

            //client.Dispose();

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;

                PokeAPI api = JsonConvert.DeserializeObject<PokeAPI>(json);

                foreach (var character in api.results)
                {
                    lstCharacters.Items.Add(character);
                }
            }


        }
    }
}
