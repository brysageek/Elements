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
        }
    }
}