using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[FlagsAttribute]
public enum Allergen
{
    Eggs = 1 << 0,
    Peanuts = 1 << 1,
    Shellfish = 1 << 2,
    Strawberries = 1 << 3,
    Tomatoes = 1 << 4,
    Chocolate = 1 << 5,
    Pollen = 1 << 6,
    Cats = 1 << 7
}
public class Allergies
{
    private readonly int Mask;

    public Allergies(int mask)
    {
        Mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        Allergen AllergyList = (Allergen)Mask;
        return AllergyList.HasFlag(allergen);
    }

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen)).Cast<Allergen>().Where(x => IsAllergicTo(x)).ToArray();
    }
}