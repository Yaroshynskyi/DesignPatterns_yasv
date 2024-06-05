using _5_Builder;

class Program
{
    static void Main(string[] args)
    {
        CharacterBuilder heroBuilder = new HeroBuilder();
        Director director = new Director(heroBuilder);
        director.ConstructCharacter();
        Character hero = director.GetCharacter();
        hero.Display();

        CharacterBuilder enemyBuilder = new EnemyBuilder();
        director = new Director(enemyBuilder);
        director.ConstructCharacter();
        Character enemy = director.GetCharacter();
        enemy.Display();
    }
}