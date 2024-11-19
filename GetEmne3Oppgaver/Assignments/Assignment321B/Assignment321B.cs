using GetEmne3Oppgaver;

namespace Emne3GetAcademyOppgaver.Assignments.Assignment321B;

public class Assignment321B : IAssignment
{
    public void Run()
    {
        var gearPieces = new[]
        {
            new { Name = "Azure Defender Helm", Type = "Helmet", Rarity = "Blue", StatBoost = "+10 Defense" },
            new { Name = "Royal Sapphire Chestplate", Type = "Chestplate", Rarity = "Blue", StatBoost = "+20 Defense" },
            new { Name = "Amethyst Warden Boots", Type = "Boots", Rarity = "Purple", StatBoost = "+15 Speed" },
            new { Name = "Indigo Blade", Type = "Weapon", Rarity = "Blue", StatBoost = "+25 Attack" },
            new { Name = "Violet Guardian Shield", Type = "Shield", Rarity = "Purple", StatBoost = "+30 Defense" },
            new { Name = "Cerulean Archer's Gloves", Type = "Gloves", Rarity = "Blue", StatBoost = "+10 Dexterity" },
            new { Name = "Plum Sorcerer's Robe", Type = "Chestplate", Rarity = "Purple", StatBoost = "+40 Magic Power" },
            new { Name = "Periwinkle Greatsword", Type = "Weapon", Rarity = "Blue", StatBoost = "+30 Attack" },
            new { Name = "Lavender Cloak of Shadows", Type = "Cloak", Rarity = "Purple", StatBoost = "+50 Stealth" }
        };
        
        string rarity = Console.ReadLine();
        foreach (var gear in gearPieces)
        {
            if (gear.Rarity.Equals(rarity))
            {
                Console.WriteLine(gear.Name);
            }
        }
        
        //Probably worse performance here but might be useful somewhere else. Goes through the list once to find the items then goes through again to display data.
        // var fitleredList = Array.FindAll(gearPieces, gear => gear.Rarity.Equals(rarity)); 
        // foreach (var item in fitleredList)
        // {
        //     Console.WriteLine(item);
        // }

    }
}