using System.Collections.Generic;


namespace BuffSystem
{
        
    // Copyright Sami S.

    // use of any kind without a written permission 
    // from the author is not allowed.

    // DO NOT:
    // Fork, clone, copy or use in any shape or form.
    
    [System.Serializable]
    public class Item
    {
        public string name;

        // these will be added/removed
        // from base stats
        public List<StatMod> mods; 
    }

}

