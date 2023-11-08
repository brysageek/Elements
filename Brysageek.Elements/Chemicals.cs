using System.Collections.ObjectModel;

namespace Brysageek.Elements
{
    public sealed class Chemicals : ReadOnlyCollection<ChemicalElement>
    {
        private static readonly Lazy<Chemicals> ChemicalElements = new(() => new Chemicals(new ChemicalElementList()));

        public static Chemicals All => ChemicalElements.Value;
        public static ChemicalElement Hydrogen => ChemicalElements.Value[0];
        public static ChemicalElement Helium => ChemicalElements.Value[1];
        public static ChemicalElement Lithium => ChemicalElements.Value[2];
        public static ChemicalElement Beryllium => ChemicalElements.Value[3];
        public static ChemicalElement Boron => ChemicalElements.Value[4];
        public static ChemicalElement Carbon => ChemicalElements.Value[5];
        public static ChemicalElement Nitrogen => ChemicalElements.Value[6];
        public static ChemicalElement Oxygen => ChemicalElements.Value[7];
        public static ChemicalElement Fluorine => ChemicalElements.Value[8];
        public static ChemicalElement Neon => ChemicalElements.Value[9];
        public static ChemicalElement Sodium => ChemicalElements.Value[10];
        public static ChemicalElement Magnesium => ChemicalElements.Value[11];
        public static ChemicalElement Aluminum => ChemicalElements.Value[12];
        public static ChemicalElement Silicon => ChemicalElements.Value[13];
        public static ChemicalElement Phosphorus => ChemicalElements.Value[14];
        public static ChemicalElement Sulfur => ChemicalElements.Value[15];
        public static ChemicalElement Chlorine => ChemicalElements.Value[16];
        public static ChemicalElement Argon => ChemicalElements.Value[17];
        public static ChemicalElement Potassium => ChemicalElements.Value[18];
        public static ChemicalElement Calcium => ChemicalElements.Value[19];
        public static ChemicalElement Scandium => ChemicalElements.Value[20];
        public static ChemicalElement Titanium => ChemicalElements.Value[21];
        public static ChemicalElement Vanadium => ChemicalElements.Value[22];
        public static ChemicalElement Chromium => ChemicalElements.Value[23];
        public static ChemicalElement Manganese => ChemicalElements.Value[24];
        public static ChemicalElement Iron => ChemicalElements.Value[25];
        public static ChemicalElement Cobalt => ChemicalElements.Value[26];
        public static ChemicalElement Nickel => ChemicalElements.Value[27];
        public static ChemicalElement Copper => ChemicalElements.Value[28];
        public static ChemicalElement Zinc => ChemicalElements.Value[29];
        public static ChemicalElement Gallium => ChemicalElements.Value[30];
        public static ChemicalElement Germanium => ChemicalElements.Value[31];
        public static ChemicalElement Arsenic => ChemicalElements.Value[32];
        public static ChemicalElement Selenium => ChemicalElements.Value[33];
        public static ChemicalElement Bromine => ChemicalElements.Value[34];
        public static ChemicalElement Krypton => ChemicalElements.Value[35];

        private Chemicals(IList<ChemicalElement> list) : base(list)
        {
        }
    }
}
