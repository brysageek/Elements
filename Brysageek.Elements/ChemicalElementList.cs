namespace Brysageek.Elements
{
    internal class ChemicalElementList : List<ChemicalElement>
    {
        public ChemicalElementList()
        {
            Add(new ChemicalElement(1, 1, 1,
                1.00794f, "Hydrogen", "H", 1312.0f,
               2.20f, MetalClassificationTypes.NonMetal));

            Add(new ChemicalElement(18, 1, 2,
                4.002602f, "Helium", "He", 2372.3f,
                0.0f, MetalClassificationTypes.NobleGas));

            Add(new ChemicalElement(1, 2, 3,
                6.941f, "Lithium", "Li", 520.2f,
                0.98f, MetalClassificationTypes.AlkaliMetal));

            Add(new ChemicalElement(2, 2, 4,
                9.012182f, "Beryllium", "Be", 899.5f,
                  1.57f, MetalClassificationTypes.AlkalineMetal));

            Add(new ChemicalElement(13, 2, 5,
                10.811f, "Boron", "B", 800.6f,
                2.04f, MetalClassificationTypes.Metalloid));

            Add(new ChemicalElement(14, 2, 6,
                12.0107f, "Carbon", "C", 1086.5f,
                2.55f, MetalClassificationTypes.NonMetal));

            Add(new ChemicalElement(15, 2, 7,
                14.0067f, "Nitrogen", "N", 1402.3f,
                3.04f, MetalClassificationTypes.NonMetal));

            Add(new ChemicalElement(16, 2, 8,
                15.9994f, "Oxygen", "O", 1313.9f,
                3.44f, MetalClassificationTypes.NonMetal));

            Add(new ChemicalElement(17, 2, 9,
                18.998403f, "Fluorine", "F", 1681.0f,
                3.98f, MetalClassificationTypes.Halogen));

            Add(new ChemicalElement(18, 2, 10,
                20.1797f, "Neon", "Ne", 2080.7f,
                0.0f, MetalClassificationTypes.NobleGas));

            Add(new ChemicalElement(1, 3, 11,
                22.98976f, "Sodium", "Na", 495.8f,
                0.93f, MetalClassificationTypes.AlkaliMetal));

            Add(new ChemicalElement(2, 3, 12,
                24.3050f, "Magnesium", "Mg", 737.7f,
                1.31f, MetalClassificationTypes.AlkalineMetal));

            Add(new ChemicalElement(13, 3, 13,
                26.98153f, "Aluminum", "Al", 577.5f,
                1.61f, MetalClassificationTypes.OtherMetal));

            Add(new ChemicalElement(14, 3, 14,
                28.0855f, "Silicon", "Si", 786.5f,
                1.90f, MetalClassificationTypes.Metalloid));

            Add(new ChemicalElement(15, 3, 15,
                30.97696f, "Phosphorus", "P", 1011.8f,
                2.19f, MetalClassificationTypes.NonMetal));

            Add(new ChemicalElement(16, 3, 16,
                32.065f, "Sulfur", "S", 999.6f,
                2.58f, MetalClassificationTypes.NonMetal));

            Add(new ChemicalElement(17, 3, 17,
                35.453f, "Chlorine", "Cl", 1251.2f,
                3.16f, MetalClassificationTypes.Halogen));

            Add(new ChemicalElement(18, 3, 18,
                39.948f, "Argon", "Ar", 1520.6f,
                0.0f, MetalClassificationTypes.NobleGas));

            Add(new ChemicalElement(1, 4, 19,
                39.0983f, "Potassium", "K", 418.8f,
                0.82f, MetalClassificationTypes.AlkaliMetal));

            Add(new ChemicalElement(2, 4, 20,
                40.078f, "Calcium", "Ca", 589.8f,
                1.00f, MetalClassificationTypes.AlkalineMetal));

            Add(new ChemicalElement(3, 4, 21,
                44.95591f, "Scandium", "Sc", 633.1f,
                1.36f, MetalClassificationTypes.Lanthanoid));

            Add(new ChemicalElement(4, 4, 22,
                47.867f, "Titanium", "Ti", 658.8f,
                1.54f, MetalClassificationTypes.Lanthanoid));
        }
    }
}