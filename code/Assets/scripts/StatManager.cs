using System.Collections.Generic;
using UnityEngine;

namespace BuffSystem
{
          
    // Copyright Sami S.

    // use of any kind without a written permission 
    // from the author is not allowed.

    // DO NOT:
    // Fork, clone, copy or use in any shape or form.
      
    [System.Serializable]
    public class StatManager
    {
        // base values
        public List<Stat> stats;

        public void AddMods(List<StatMod> mods)
        {
            foreach (var m in mods)
            {
                var stat = Get(m.type);

                if (m.kind == Kind.Flat)
                    stat.flatMods += m.value;

                if (m.kind == Kind.Percent)
                    stat.percentMods += m.value;
            }
        }


        public void RemoveMods(List<StatMod> mods)
        {
            foreach (var m in mods)
            {
                var stat = Get(m.type);

                if (m.kind == Kind.Flat)
                    stat.flatMods -= m.value;

                if (m.kind == Kind.Percent)
                    stat.percentMods -= m.value;
            }
        }


        public int GetFinalStat(Stat stat)
        {
            var per = ((100f + stat.percentMods) / 100f);

            var total = (stat.value + stat.flatMods) * per;

            return Mathf.RoundToInt(total);
        }


        public Stat Get(StatType type)
        {
            foreach (var s in stats)
            {
                if (s.type == type)
                    return s;
            }

            return null;
        }
    }

}

