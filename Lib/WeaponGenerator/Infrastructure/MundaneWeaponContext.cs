
public class MundaneWeaponContext
{
    public List<MundaneWeapon> MundaneWeapons;
    public List<ExtraDamage> ExtraDamages;

    public MundaneWeaponContext()
    {
        MundaneWeapons = new List<MundaneWeapon>([
            new MundaneWeapon("Battleaxe",  ["Versatile"],              new WeaponDamage(1, 8, "Slashing"),     0, 0),
            new MundaneWeapon("Flail",      [],                         new WeaponDamage(1, 8, "Bludgeoning"),  0, 0),
            new MundaneWeapon("Glaive",     ["Reach", "TwoHanded"],     new WeaponDamage(1, 10, "Slashing"),    0, 0),
            new MundaneWeapon("Greataxe",   ["TwoHanded"],              new WeaponDamage(1, 12, "Slashing"),    0, 0),
            new MundaneWeapon("Greatsword", ["TwoHanded"],              new WeaponDamage(2, 6, "Slashing"),     0, 0),
            new MundaneWeapon("Halberd",    ["TwoHanded"],              new WeaponDamage(1, 10, "Slashing"),    0, 0),
            new MundaneWeapon("Lance",      ["Lance"],                  new WeaponDamage(1, 12, "Piercing"),    0, 0),
            new MundaneWeapon("Longsword",  ["Versatile"],              new WeaponDamage(1, 8, "Slashing"),     0, 0),
            new MundaneWeapon("Maul",       ["TwoHanded"],              new WeaponDamage(2, 6, "Bludgeoning"),  0, 0),
            new MundaneWeapon("Morningstar",[],                         new WeaponDamage(1, 8, "Piercing"),     0, 0),
            new MundaneWeapon("Pike",       ["Reach", "TwoHanded"],     new WeaponDamage(1, 10, "Piercing"),    0, 0),
            new MundaneWeapon("Rapier",     ["Finesse"],                new WeaponDamage(1, 8, "Piercing"),     0, 0),
            new MundaneWeapon("Scimitar",   ["Finesse", "Light"],       new WeaponDamage(1, 6, "Slashing"),     0, 0),
            new MundaneWeapon("Shortsword", ["Finesse", "Light"],       new WeaponDamage(1, 6, "Piercing"),     0, 0),
            new MundaneWeapon("Trident",    ["Thrown", "Versatile"],    new WeaponDamage(1, 6, "Piercing"),     0, 0),
            new MundaneWeapon("War Pick",   [],                         new WeaponDamage(1, 8, "Piercing"),     0, 0),
            new MundaneWeapon("Warhammer",  ["Versatile"],              new WeaponDamage(1, 8, "Bludgeoning"),  0, 0),
            new MundaneWeapon("Whip",       ["Finesse", "Reach"],       new WeaponDamage(1, 4, "Slashing"),     0, 0),
        ]);

        ExtraDamages = new List<ExtraDamage>(
            [
                new ExtraDamage(new WeaponDamage(1, 6, "Acid"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(2, 6, "Acid"), ["Uncommon", "Rare"]),
                new ExtraDamage(new WeaponDamage(3, 6, "Acid"), ["Very Rare", "Legendary"]),
                new ExtraDamage(new WeaponDamage(4, 6, "Acid"), ["Legendary"]),
                new ExtraDamage(new WeaponDamage(1, 12, "Bludgeoning"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(2, 12, "Bludgeoning"), ["Rare", "Very Rare"]),
                new ExtraDamage(new WeaponDamage(3, 12, "Bludgeoning"), ["Very Rare", "Legendary"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Cold"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Fire"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Force"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Lightning"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Necrotic"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(2, 4, "Piercing"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(4, 4, "Piercing"), ["Uncommon", "Rare"]),
                new ExtraDamage(new WeaponDamage(5, 4, "Piercing"), ["Rare", "Very Rare"]),
                new ExtraDamage(new WeaponDamage(6, 6, "Piercing"), ["Very Rare", "Legendary"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Poison"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Psychic"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Radiant"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Slashing"), ["Uncommon"]),
                new ExtraDamage(new WeaponDamage(1, 6, "Thunder"), ["Uncommon"]),
            ]
        );
    }
}



