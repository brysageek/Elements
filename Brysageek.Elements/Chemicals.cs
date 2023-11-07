using System.Collections.ObjectModel;

namespace Brysageek.Elements
{
    public sealed class Chemicals : ReadOnlyCollection<ChemicalElement>
    {
        private static readonly Lazy<Chemicals> ChemicalElements = new(() => new Chemicals(new ChemicalElementList()));

        public static Chemicals All => ChemicalElements.Value;
        public static ChemicalElement Hydrogen => ChemicalElements.Value[0];
        public static ChemicalElement Lithium => ChemicalElements.Value[1];
        public static ChemicalElement Beryllium => ChemicalElements.Value[2];

        private Chemicals(IList<ChemicalElement> list) : base(list)
        {
        }
    }
}
