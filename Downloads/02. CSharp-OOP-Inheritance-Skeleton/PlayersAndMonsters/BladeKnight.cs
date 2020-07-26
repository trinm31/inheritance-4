using System;
namespace PlayersAndMonsters
{
    public class BladeKnight:DarkKnight
    {
        public BladeKnight(string username, int level) : base (username,level)
        {
        }
        public override string ToString()
        {
            return base.ToString() + ". This is a BladeKnight";
        }
    }
}
