# Stat Buff System (Unity / C#)

![Stat system image](/doc/stat_system_1.PNG)

## What is it?

An example how one could setup simple RPG game like stat/stat buff system where player character has items with special powers. When player wields these items, their special "buffs" or modifiers will be applied to comparable player stat/attribute, which define features of the player character.

This is a code only example, there are no visuals.

# How to use
Open the Unity project and scene and run the program. Add and remove items to see how these modify player stats. 

# Features
Stat boosts can be positive or negative. Stat boosts can be either flat/integer buffs, or percentage buffs. Percentage buffs are calculated after all flat buffs have been added. When item is removed, its stat buff influence too is removed. Adding an armor will reduce character speed, whereas adding a magic ring will boost character's magic skill. 

![Stat system image](/doc/stat_system_2.PNG)

 
# Classes

##  Player.cs
Test class which shows how stats and stat buffs work.

## StatManager.cs
Class which holds player character stats and added stat buffs from items. Use this class to add and remove stat buffs and get the final modified stat values.

## Stat.cs
Class that defines a stat that can be buffed.

## StatMod
Class that defines a stat buff/modifier.

##  Item
Simple item, pretty much an item id with stat buffs.

# Editor Classes

## StatDrawer.cs

A Custom Property Drawer for Stat class. This will make Stat class look easier on eyes. As it is a Property Drawer, automatic layout can't be used.

![Stat system image](/doc/stat_system_4.PNG)


## StatModDrawer.cs

A Custom Property Drawer for StatMod class.

![Stat system image](/doc/stat_system_3.PNG)


# About
I created this stat buff system for myself, as a learning experience.

# Copyright 
Created by Sami S. use of any kind without a written permission from the author is not allowed. But feel free to take a look.
