using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Helpers;

namespace MunchkinCounter
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Player> players;

        public MainPage()
        {
            InitializeComponent();
            LoadPlayers();
            DisplayPlayers();
        }
        private void LoadPlayers()
        { 
            players = new List<Player>
            {
                new Player("test1", Genders.Female),
                new Player("test2", Genders.Male)
            };
        }
        private void DisplayPlayers()
        {
            List<string> playersData = new List<string>();
            players.Select(z => new { z.name, z.gender }).ToList().ForEach(x => { playersData.Add(string.Format("{0} {1}", x.name, x.gender.ToSymbol())); });
            playerList.BindingContext = playersData;
        }
        private void Add_Player_Clicked(object sender, EventArgs e)
        { 
            players.AddUnique(new Player("test3", Genders.Female));
            DisplayPlayers();
        }
        private void Remove_Player_Clicked(object sender, EventArgs e)
        {
            var playerData = playerList.SelectedItem.ToString().Split(' ');
            players.RemoveAll(z => playerData[0] == z.name && playerData[1] == z.gender.ToSymbol());
            DisplayPlayers();
            buttonRemove.IsEnabled = false;
        }
        private void New_Game_Clicked(object sender, EventArgs e)
        {

        }
        private void PlayerList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            buttonRemove.IsEnabled = null != playerList.SelectedItem;
        }
    }
}
