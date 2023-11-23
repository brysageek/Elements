namespace Brysageek.Elements
{
    /// <summary>
    /// A chemical element is a chemical substance that cannot be broken down into other substances.
    /// The basic particle that constitutes a chemical element is the atom, and each chemical element
    /// is distinguished by the number of protons in the nuclei of its atoms, known as its atomic number.
    /// </summary>
    public class ChemicalElement(int group, int period, int atomicNumber, float atomicMass, string? name,
        string? symbol, float firstIonizationEnergy, float electronegativity, MetalClassificationTypes metalType,
        bool radioactive = false)
    {
        public int Group { get; } = group;
        public int Period { get; } = period;
        public int AtomicNumber { get; } = atomicNumber;
        public float AtomicMass { get; } = atomicMass;
        public string? Name { get; } = name;
        public string? Symbol { get; } = symbol;
        public float FirstIonizationEnergy { get; } = firstIonizationEnergy;
        public float Electronegativity { get; } = electronegativity;
        public MetalClassificationTypes MetalType { get; } = metalType;
        public bool Radioactive { get; } = radioactive;

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj) => obj is not ChemicalElement &&
                                                    Math.Abs(AtomicMass - ((ChemicalElement)obj!).AtomicMass) <
                                                    0.0000001;

        protected bool Equals(ChemicalElement other)
        {
            return Group == other.Group &&
                   Period == other.Period &&
                   AtomicNumber == other.AtomicNumber &&
                   AtomicMass.Equals(other.AtomicMass) &&
                   Name == other.Name &&
                   Symbol == other.Symbol &&
                   FirstIonizationEnergy.Equals(other.FirstIonizationEnergy) &&
                   Electronegativity.Equals(other.Electronegativity) &&
                   MetalType == other.MetalType &&
                   Radioactive == other.Radioactive;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(Group);
            hashCode.Add(Period);
            hashCode.Add(AtomicNumber);
            hashCode.Add(AtomicMass);
            hashCode.Add(Name);
            hashCode.Add(Symbol);
            hashCode.Add(FirstIonizationEnergy);
            hashCode.Add(Electronegativity);
            hashCode.Add((int)MetalType);
            hashCode.Add(Radioactive);
            return hashCode.ToHashCode();
        }

        public static bool operator ==(ChemicalElement lhs, ChemicalElement rhs)
        {
            return (Math.Abs(lhs.AtomicMass - rhs.AtomicMass) < 0.00000001);
        }

        public static bool operator !=(ChemicalElement lhs, ChemicalElement rhs)
        {
            return !(Math.Abs(lhs.AtomicMass - rhs.AtomicMass) < 0.0000001);
        }
    }
}