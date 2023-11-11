﻿using System.Collections.ObjectModel;

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
        public static ChemicalElement Rubidium => ChemicalElements.Value[36];
        public static ChemicalElement Strontium => ChemicalElements.Value[37];
        public static ChemicalElement Yttrium => ChemicalElements.Value[38];
        public static ChemicalElement Zirconium => ChemicalElements.Value[39];
        public static ChemicalElement Niobium => ChemicalElements.Value[40];
        public static ChemicalElement Molybdenum => ChemicalElements.Value[41];
        public static ChemicalElement Technetium => ChemicalElements.Value[42];
        public static ChemicalElement Ruthenium => ChemicalElements.Value[43];
        public static ChemicalElement Rhodium => ChemicalElements.Value[44];
        public static ChemicalElement Palladium => ChemicalElements.Value[45];
        public static ChemicalElement Silver => ChemicalElements.Value[46];
        public static ChemicalElement Cadmium => ChemicalElements.Value[47];
        public static ChemicalElement Indium => ChemicalElements.Value[48];
        public static ChemicalElement Tin => ChemicalElements.Value[49];
        public static ChemicalElement Antimony => ChemicalElements.Value[50];
        public static ChemicalElement Tellurium => ChemicalElements.Value[51];
        public static ChemicalElement Iodine => ChemicalElements.Value[52];
        public static ChemicalElement Xenon => ChemicalElements.Value[53];
        public static ChemicalElement Cesium => ChemicalElements.Value[54];
        public static ChemicalElement Barium => ChemicalElements.Value[55];
        public static ChemicalElement Lanthanum => ChemicalElements.Value[56];
        public static ChemicalElement Cerium => ChemicalElements.Value[57];
        public static ChemicalElement Praseodymium => ChemicalElements.Value[58];
        public static ChemicalElement Neodymium => ChemicalElements.Value[59];
        public static ChemicalElement Promethium => ChemicalElements.Value[60];
        public static ChemicalElement Samarium => ChemicalElements.Value[61];
        public static ChemicalElement Europium => ChemicalElements.Value[62];
        public static ChemicalElement Gadolinium => ChemicalElements.Value[63];
        public static ChemicalElement Terbium => ChemicalElements.Value[64];
        public static ChemicalElement Dysprosium => ChemicalElements.Value[65];
        public static ChemicalElement Holmium => ChemicalElements.Value[66];
        public static ChemicalElement Erbium => ChemicalElements.Value[67];
        public static ChemicalElement Thulium => ChemicalElements.Value[68];
        public static ChemicalElement Ytterbium => ChemicalElements.Value[69];
        public static ChemicalElement Lutetium => ChemicalElements.Value[70];
        public static ChemicalElement Hafnium => ChemicalElements.Value[71];
        public static ChemicalElement Tantalum => ChemicalElements.Value[72];
        public static ChemicalElement Tungsten => ChemicalElements.Value[73];
        public static ChemicalElement Rhenium => ChemicalElements.Value[74];
        public static ChemicalElement Osmium => ChemicalElements.Value[75];
        public static ChemicalElement Iridium => ChemicalElements.Value[76];
        public static ChemicalElement Platinum => ChemicalElements.Value[77];
        public static ChemicalElement Gold => ChemicalElements.Value[78];
        public static ChemicalElement Mercury => ChemicalElements.Value[79];
        public static ChemicalElement Thallium => ChemicalElements.Value[80];
        public static ChemicalElement Lead => ChemicalElements.Value[81];
        public static ChemicalElement Bismuth => ChemicalElements.Value[82];
        public static ChemicalElement Polonium => ChemicalElements.Value[83];
        public static ChemicalElement Astatine => ChemicalElements.Value[84];
        public static ChemicalElement Radon => ChemicalElements.Value[85];





        private Chemicals(IList<ChemicalElement> list) : base(list)
        {
        }
    }
}
