using System;
namespace PlayersAndMonsters
{
    public class DarkWizard: Wizard
    {
        public DarkWizard(string username, int level) : base(username, level)
        {

        }
        public override string ToString()
        {
            return base.ToString() + ". This is a DarkWizard";
        }
    }
}
