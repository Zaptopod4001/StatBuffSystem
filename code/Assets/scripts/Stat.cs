using System.Collections.Generic;

namespace BuffSystem
{
        
    // Copyright Sami S.

    // use of any kind without a written permission 
    // from the author is not allowed.

    // DO NOT:
    // Fork, clone, copy or use in any shape or form.
    
    [System.Serializable]
    public class Stat
    {
        public StatType type;   // type like: magic
        public int value;       // base int value of stat
        public int flatMods;    // current flat mods
        public int percentMods; // current percent mods
    }



    // Stat modifier classes

    public enum StatType
    {
        Strength,
        Magic,
        Speed
    }


    public enum Kind
    {
        Flat,
        Percent,
    }


    [System.Serializable]
    public class StatMod
    {
        public int value;
        public StatType type; // only used info on assign
        public Kind kind; // only used info on assign
    }

}

