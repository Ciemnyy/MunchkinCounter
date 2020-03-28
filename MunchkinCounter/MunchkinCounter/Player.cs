namespace MunchkinCounter
{
    public class Player
    {
        public bool isCultist;
        public int level;
        public string name;
        public Genders gender;
        public Genders originalGender;

        public Player(string _name, Genders _gender)
        {
            isCultist = false;
            level = 1;
            name = _name;
            gender = _gender;
        }
        public static bool operator ==(Player player1, Player player2)
        {
            return player1.name == player2.name && player1.originalGender == player2.originalGender;
        }
        public static bool operator !=(Player player1, Player player2)
        {
            return player1.name != player2.name || player1.originalGender != player2.originalGender;
        }
    }
}
