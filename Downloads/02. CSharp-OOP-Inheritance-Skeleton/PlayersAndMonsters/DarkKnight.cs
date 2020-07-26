using System;
namespace PlayersAndMonsters
{
    public class DarkKnight:Knight
    {
        public DarkKnight(string username, int level): base(username,level)
        {

        }
        public override string ToString()
        {
            return base.ToString() + ". This is a DarkKnight";
        }
    }
}
