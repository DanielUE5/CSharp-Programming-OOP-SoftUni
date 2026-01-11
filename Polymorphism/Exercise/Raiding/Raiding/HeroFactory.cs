using Raiding;

public static class HeroFactory
{
    public static BaseHero CreateHero(string name, string heroType)
    {
        switch (heroType)
        {
            case "Druid":
                return new Druid(name);
            case "Paladin":
                return new Paladin(name);
            case "Rogue":
                return new Rogue(name);
            case "Warrior":
                return new Warrior(name);
            default:
                throw new ArgumentException("Invalid hero!");
        }
    }
}
