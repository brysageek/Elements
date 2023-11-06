namespace Brysageek.Elements
{
    /// <summary>
    /// A chemical element is a chemical substance that cannot be broken down into other substances.
    /// The basic particle that constitutes a chemical element is the atom, and each chemical element
    /// is distinguished by the number of protons in the nuclei of its atoms, known as its atomic number.
    /// </summary>
    public class ChemicalElement
    {
        public int Group { get; private set; }
        public int Period { get; private set; }
        public int AtomicNumber { get; private set; }
        public float AtomicMass { get; private set; }
        public string? Name { get; private set; }
        public string? Symbol { get; private set; }
        public float FirstIonizationEnergy { get; private set; } 
        public float Electronegativity { get; private set; }
        public int[]? OxidationStates { get; private set; }
        public string? ElectronConfiguration { get; private set; }
        public MetalClassificationType MetalType { get; private set; }

        public ChemicalElement(int group, int period, int atomicNumber, float atomicMass, string? name, string? symbol, float firstIonizationEnergy, float electronegativity, int[]? oxidationStates, string? electronConfiguration, MetalClassificationType metalType)
        {
            Group = group;
            Period = period;
            AtomicNumber = atomicNumber;
            AtomicMass = atomicMass;
            Name = name;
            Symbol = symbol;
            FirstIonizationEnergy = firstIonizationEnergy;
            Electronegativity = electronegativity;
            OxidationStates = oxidationStates;
            ElectronConfiguration = electronConfiguration;
            MetalType = metalType;
        }
    }
}
