// Battle challenge

Random dice = new Random();

int heroHealth = 10;
int monsterHealth = 10;

while (heroHealth > 0 && monsterHealth > 0) 
{
    // Player attacks monster
    int heroAttack = dice.Next(1, 11);
    monsterHealth -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health");

    if(monsterHealth < 0) continue;

    // Monster attacks player
    int monsterAttack = dice.Next(1, 11);
    heroHealth -= monsterAttack;
    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health");
}

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");