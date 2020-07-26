using System;
namespace PlayersAndMonsters
{
    public class Elf:Hero
    {

        public Elf(string username, int level) : base(username,level)
        {

        }
        public override string ToString()
        {
            return base.ToString() + ". This is a Elf";
        }
    }
}
