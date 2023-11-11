namespace Brysageek.Elements
{
    /// <summary>
    /// A chemical element is a chemical substance that cannot be broken down into other substances.
    /// The basic particle that constitutes a chemical element is the atom, and each chemical element
    /// is distinguished by the number of protons in the nuclei of its atoms, known as its atomic number.
    /// </summary>
    public class ChemicalElement
    {
        public int Group { get; }
        public int Period { get; }
        public int AtomicNumber { get; }
        public float AtomicMass { get; }
        public string? Name { get; }
        public string? Symbol { get; }
        public float FirstIonizationEnergy { get; } 
        public float Electronegativity { get; }
        public MetalClassificationTypes MetalType { get; }
        public bool Radioactive { get; }


        public ChemicalElement(int group, int period, int atomicNumber, float atomicMass, string? name, string? symbol, float firstIonizationEnergy, float electronegativity, MetalClassificationTypes metalType, bool radioactive = false)
        {
            Group = group;
            Period = period;
            AtomicNumber = atomicNumber;
            AtomicMass = atomicMass;
            Name = name;
            Symbol = symbol;
            FirstIonizationEnergy = firstIonizationEnergy;
            Electronegativity = electronegativity;
            MetalType = metalType;
            Radioactive = radioactive;
        }
    }
}
