using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace BuffSystem
{
        
    // Copyright Sami S.

    // use of any kind without a written permission 
    // from the author is not allowed.

    // DO NOT:
    // Fork, clone, copy or use in any shape or form.
    
    public class Player : MonoBehaviour
    {
        
        [Header("Demo UI")]
        public Text statsText;
        public Text playerItemsText;
        public Text itemsText;

        [Header("Demo items")]
        public List<Item> itemsToAdd;
        public List<Item> playerItems;

        [Header("Players stats now")]
        public StatManager sm;


        void Start()
        {
            ShowTotalStats();
        }


        void Update()
        {
            DemoAddRemove();
        }


        void DemoAddRemove()
        {
            // add random item
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (itemsToAdd.Count <= 0)
                    return;

                var pick = UnityEngine.Random.Range(0, itemsToAdd.Count);
                var item = itemsToAdd[pick];

                itemsToAdd.Remove(item);
                playerItems.Add(item);
                sm.AddMods(item.mods);

                ShowTotalStats();
            }

            // remove random item
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (playerItems.Count <= 0)
                    return;

                var pick = UnityEngine.Random.Range(0, playerItems.Count);
                var item = playerItems[pick];

                playerItems.RemoveAt(pick);
                itemsToAdd.Add(item);
                sm.RemoveMods(item.mods);

                ShowTotalStats();
            }
        }


        public void ShowTotalStats()
        {
            statsText.text = "";
            playerItemsText.text = "";
            itemsText.text = "";

            foreach (var i in playerItems)
            {
                playerItemsText.text += i.name + "\n";
            }

            // list items 
            foreach (var i in itemsToAdd)
            {
                itemsText.text += i.name + "\n";
            }

            // list final stat valus for each item
            for (int i = 0; i < sm.stats.Count; i++)
            {
                statsText.text += sm.stats[i].type + ":" + sm.GetFinalStat(sm.stats[i]) + "\n";
            }
        }

    }

}

