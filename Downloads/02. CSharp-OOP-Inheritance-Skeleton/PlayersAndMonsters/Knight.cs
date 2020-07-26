using System;
namespace PlayersAndMonsters
{
    public class Knight :Hero
    {
        public Knight(string username, int level) : base(username, level)
        {

        }
        public override string ToString()
        {
            return base.ToString() + ". This is a Knight";
        }
    }
}
