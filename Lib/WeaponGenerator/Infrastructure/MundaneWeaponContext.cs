
public class MundaneWeaponContext
{
    public List<MundaneWeapon> MundaneWeapons;

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
    }
}


















