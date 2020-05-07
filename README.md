# Simple Crafting System (Unity / C#)

![Stat system image](/doc/stat_system_1.png)

## What is it?

An example how one could setup simple RPG game like stat / stat buff system where user has items, and when player wields these items, their special "buffs" or modifiers will be applied to comparable player stats, or player attributes that define functional features of player character.

This is a code only example, there are no visuals.

# How to use
Note: Open Project and the scene, and run the program. Add and remove stats and see how these modify player stats.

# Features
For example, adding an armor will reduce speed, where as adding a magic ring will boost character magic skills. Stat boosts can be positive or negative. Stat boosts can be either flat or integer buffs, or percentage buffs. Percentage buffs are calculated after all flat buffs have been added.

![Stat system image](/doc/stat_system_2.png)

 
# Classes

##  Player.cs
Test class, which shows how stats work.

## StatManager.cs
Class that holds added stats from items, add and remove stats and get the final modified stat values.

## Stat.cs
Class that contains special values given by an Item.

## StatMod
Class that defines values for a stat buff.


# Editor Classes

## StatDrawer.cs

A Custom Property Drawer for Stat class. This will make Stat class look easier to eyes. As it is a Property Drawer, automatic Layout can't be used.

![Stat system image](/doc/stat_system_4.png)


## StatModDrawer.cs

A Custom Property Drawer for StatMod class.

![Stat system image](/doc/stat_system_3.png)


# About
I created this simple stat system for myself, as a learning experience.

# Copyright 
Created by Sami S. use of any kind without a written permission from the author is not allowed. But feel free to take a look.
