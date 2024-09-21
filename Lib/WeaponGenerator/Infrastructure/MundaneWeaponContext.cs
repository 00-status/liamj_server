
public class MundaneWeaponContext
{
    public List<MundaneWeapon> MundaneWeapons;
    public List<ExtraDamage> ExtraDamages;

    public MundaneWeaponContext()
    {
        MundaneWeapons = new List<MundaneWeapon>([
            new MundaneWeapon("Battleaxe",      ["Versatile"],                                      new WeaponDamage(1, 8, "Slashing"),     0, 0),
            new MundaneWeapon("Flail",          [],                                                 new WeaponDamage(1, 8, "Bludgeoning"),  0, 0),
            new MundaneWeapon("Glaive",         ["Reach", "TwoHanded"],                             new WeaponDamage(1, 10, "Slashing"),    0, 0),
            new MundaneWeapon("Greataxe",       ["TwoHanded"],                                      new WeaponDamage(1, 12, "Slashing"),    0, 0),
            new MundaneWeapon("Greatsword",     ["TwoHanded"],                                      new WeaponDamage(2, 6, "Slashing"),     0, 0),
            new MundaneWeapon("Halberd",        ["TwoHanded"],                                      new WeaponDamage(1, 10, "Slashing"),    0, 0),
            new MundaneWeapon("Lance",          ["Lance"],                                          new WeaponDamage(1, 12, "Piercing"),    0, 0),
            new MundaneWeapon("Longsword",      ["Versatile"],                                      new WeaponDamage(1, 8, "Slashing"),     0, 0),
            new MundaneWeapon("Maul",           ["TwoHanded"],                                      new WeaponDamage(2, 6, "Bludgeoning"),  0, 0),
            new MundaneWeapon("Morningstar",    [],                                                 new WeaponDamage(1, 8, "Piercing"),     0, 0),
            new MundaneWeapon("Pike",           ["Reach", "TwoHanded"],                             new WeaponDamage(1, 10, "Piercing"),    0, 0),
            new MundaneWeapon("Rapier",         ["Finesse"],                                        new WeaponDamage(1, 8, "Piercing"),     0, 0),
            new MundaneWeapon("Scimitar",       ["Finesse", "Light"],                               new WeaponDamage(1, 6, "Slashing"),     0, 0),
            new MundaneWeapon("Shortsword",     ["Finesse", "Light"],                               new WeaponDamage(1, 6, "Piercing"),     0, 0),
            new MundaneWeapon("War Pick",       [],                                                 new WeaponDamage(1, 8, "Piercing"),     0, 0),
            new MundaneWeapon("Warhammer",      ["Versatile"],                                      new WeaponDamage(1, 8, "Bludgeoning"),  0, 0),
            new MundaneWeapon("Whip",           ["Finesse", "Reach"],                               new WeaponDamage(1, 4, "Slashing"),     0, 0),
            new MundaneWeapon("Blowgun",        ["Ammunition", "Loading"],                          new WeaponDamage(1, 4, "Piercing"),      25, 100),
            new MundaneWeapon("Hand Crossbow",  ["Ammunition", "Light", "Loading"],                 new WeaponDamage(1, 6, "Piercing"),      30, 120),
            new MundaneWeapon("Heavy Crossbow", ["Ammunition", "Heavy", "Loading", "TwoHanded"],    new WeaponDamage(1, 10, "Piercing"),     100, 400),
            new MundaneWeapon("Light Crossbow", ["Ammunition", "Loading", "TwoHanded"],             new WeaponDamage(1, 8, "Piercing"),      80, 320),
            new MundaneWeapon("Dart",           ["Finesse", "Thrown"],                              new WeaponDamage(1, 4, "Piercing"),      20, 60),
            new MundaneWeapon("Longbow",        ["Ammunition", "Heavy", "TwoHanded"],               new WeaponDamage(1, 8, "Piercing"),      150, 600),
            new MundaneWeapon("Shortbow",       ["Ammunition", "TwoHanded"],                        new WeaponDamage(1, 6, "Piercing"),      80, 320),
            new MundaneWeapon("Sling",          ["Ammunition"],                                     new WeaponDamage(1, 4, "Bludgeoning"),   30, 120),
            new MundaneWeapon("Javelin",        ["Thrown"],                                         new WeaponDamage(1, 6, "Piercing"),      30, 120),
            new MundaneWeapon("Spear",          ["Thrown", "Versatile"],                            new WeaponDamage(1, 6, "Piercing"),      20, 60),
            new MundaneWeapon("Trident",        ["Thrown", "Versatile"],                            new WeaponDamage(1, 6, "Piercing"),      20, 60)
        ]);

        ExtraDamages = new List<ExtraDamage>(
            [
                new ExtraDamage(new WeaponDamage(1, 6, "Acid"),         ["Uncommon"],               ["acid", "bitter"] ),
                new ExtraDamage(new WeaponDamage(2, 6, "Acid"),         ["Uncommon", "Rare"],       ["acid", "bitter"] ),
                new ExtraDamage(new WeaponDamage(3, 6, "Acid"),         ["Very Rare", "Legendary"], ["acid", "bitter"] ),
                new ExtraDamage(new WeaponDamage(4, 6, "Acid"),         ["Legendary"],              ["acid", "bitter"] ),
                new ExtraDamage(new WeaponDamage(1, 12, "Bludgeoning"), ["Uncommon"],               ["crushing", "heavy", "blunt"] ),
                new ExtraDamage(new WeaponDamage(2, 12, "Bludgeoning"), ["Rare", "Very Rare"],      ["crushing", "heavy", "blunt"] ),
                new ExtraDamage(new WeaponDamage(3, 12, "Bludgeoning"), ["Very Rare", "Legendary"], ["crushing", "heavy", "blunt", "massive"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Cold"),         ["Uncommon"],               ["cold", "chilled"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Fire"),         ["Uncommon"],               ["fire", "burning", "hot"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Force"),        ["Uncommon"],               ["forceful"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Lightning"),    ["Uncommon"],               ["lightning", "electric"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Necrotic"),     ["Uncommon"],               ["necrotic", "death"] ),
                new ExtraDamage(new WeaponDamage(2, 4, "Piercing"),     ["Uncommon"],               ["pointy", "jagged"] ),
                new ExtraDamage(new WeaponDamage(4, 4, "Piercing"),     ["Uncommon", "Rare"],       ["pointy", "jagged"] ),
                new ExtraDamage(new WeaponDamage(5, 4, "Piercing"),     ["Rare", "Very Rare"],      ["pointy", "jagged"] ),
                new ExtraDamage(new WeaponDamage(6, 6, "Piercing"),     ["Very Rare", "Legendary"], ["pointy", "jagged", "barbed"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Poison"),       ["Uncommon"],               ["poisonous"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Psychic"),      ["Uncommon"],               ["psychic"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Radiant"),      ["Uncommon"],               ["radiant"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Slashing"),     ["Uncommon"],               ["sharp"] ),
                new ExtraDamage(new WeaponDamage(1, 6, "Thunder"),      ["Uncommon"],               ["thunderous", "loud"] ),
            ]
        );
    }
}
