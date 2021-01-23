using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    public static List<Item> itemsForCraft = new List<Item>();

    public static Item gauntlets_of_Strength = new Item("Gauntlets of Strength", "Gauntlets_of_Strength", new List<Item>());
    public static Item recipe = new Item("Recipe", "Recipe", new List<Item>());
    public static Item ring_of_Protection = new Item("Ring of Protection", "Ring_of_Protection", new List<Item>());
    public static Item sages_Mask = new Item("Sages Mask", "Sages_Mask", new List<Item>());
    public static Item blades_of_Attack = new Item("Blades of Attack", "Blades_of_Attack", new List<Item>());
    public static Item fluffy_Hat = new Item("Fluffy Hat", "Fluffy_Hat", new List<Item>());
    public static Item blitz_Knuckles = new Item("Blitz Knuckles", "Blitz_Knuckles", new List<Item>());
    public static Item robe_of_the_Magi = new Item("Robe of the Magi", "Robe_of_the_Magi", new List<Item>());
    public static Item chainmail = new Item("Chainmail", "Chainmail", new List<Item>());
    public static Item cloak = new Item("Cloak", "Cloak", new List<Item>());
    public static Item claymore = new Item("Claymore", "Claymore", new List<Item>());
    public static Item blade_of_Alacrity = new Item("Blade of Alacrity", "Blade_of_Alacrity", new List<Item>());
    public static Item morbid_Mask = new Item("Morbid Mask", "Morbid_Mask", new List<Item>());
    public static Item ring_of_Health = new Item("Ring of Health", "Ring_of_Health", new List<Item>());
    public static Item ring_of_Regen = new Item("Ring of Regen", "Ring_of_Regen", new List<Item>());
    public static Item voodoo_Mask = new Item("Voodoo Mask", "Voodoo_Mask", new List<Item>());
    public static Item energy_Booster = new Item("Energy Booster", "Energy_Booster", new List<Item>());
    public static Item vitality_Booste = new Item("Vitality Booste", "Vitality_Booste", new List<Item>());
    public static Item point_Booster = new Item("Point Booster", "Point_Booster", new List<Item>());
    public static Item magic_Stick = new Item("Magic Stick", "Magic_Stick", new List<Item>());
    public static Item iron_Branch = new Item("Iron Branch", "Iron_Branch", new List<Item>());
    public static Item staff_of_Wizardry = new Item("Staff of Wizardry", "Staff_of_Wizardry", new List<Item>());
    public static Item void_Stone = new Item("Void stone", "Void_Stone", new List<Item>());
    public static Item shadow_Amulet = new Item("Shadow Amulet", "Shadow_Amulet", new List<Item>());
    public static Item broadsword = new Item("Broadsword", "Broadsword", new List<Item>());
    public static Item quarterstaff = new Item("Quarterstaff", "Quarterstaff", new List<Item>());
    public static Item reaver = new Item("Reaver", "Reaver", new List<Item>());
    public static Item belt_of_Strength = new Item("Belt of Strength", "Belt_of_Strength", new List<Item>());
    public static Item wind_Lace = new Item("Wind Lace", "Wind_Lace", new List<Item>());
    public static Item boots_of_Speed = new Item("Boots of Speed", "Boots_of_Speed", new List<Item>());
    public static Item crown = new Item("Crown", "Crown", new List<Item>());
    public static Item helm_of_Iron_Will = new Item("Helm of Iron Will", "Helm_of_Iron_Will", new List<Item>());
    public static Item gloves_of_Haste = new Item("Gloves of Haste", "Gloves_of_Haste", new List<Item>());
    public static Item blight_Stone = new Item("Blight Stone", "Blight_Stone", new List<Item>());
    public static Item ultimate_Orb = new Item("Ultimate Orb", "Ultimate_Orb", new List<Item>());
    public static Item circlet = new Item("Circlet", "Circlet", new List<Item>());
    public static Item ogre_Axe = new Item("Ogre_Axe", "Ogre_Axe", new List<Item>());
    public static Item mithril_Hammer = new Item("Mithril Hammer", "Mithril_Hammer", new List<Item>());
    public static Item platemail = new Item("Platemail", "Platemail", new List<Item>());
    public static Item javelin = new Item("Javelin", "Javelin", new List<Item>());
    public static Item hyperstone = new Item("Hyperstone", "Hyperstone", new List<Item>());
    public static Item talisman_of_Evasion = new Item("Talisman of Evasion", "Talisman_of_Evasion", new List<Item>());
    public static Item mystic_Staff = new Item("Mystic Staff", "Mystic_Staff", new List<Item>());
    public static Item quelling_Blade = new Item("Quelling Blade", "Quelling_Blade", new List<Item>());
    public static Item demon_Edge = new Item("Demon Edge", "Demon_Edge", new List<Item>());
    public static Item infused_Raindrops = new Item("Infused Raindrops", "Infused_Raindrops", new List<Item>());
    public static Item eaglesong = new Item("Eaglesong", "Eaglesong", new List<Item>());
    public static Item band_of_Elvenskin = new Item("Band of Elvenskin", "Band_of_Elvenskin", new List<Item>());

    public static Item ring_of_Tarrasque = new Item("Ring of Tarrasque", "Ring_of_Tarrasque", new List<Item>() { pusto, pusto });
    public static Item pusto = new Item("Pusto", "", new List<Item>() { pusto, pusto });

    public static Item soul_Booster = new Item("Soul Booster", "Soul_Booster", new List<Item>() { vitality_Booste, energy_Booster, point_Booster });
    public static Item kaya = new Item("Kaya", "Kaya", new List<Item>() { staff_of_Wizardry, robe_of_the_Magi, recipe });
    public static Item headdress = new Item("Headdress", "Headdress", new List<Item>() { ring_of_Regen, recipe });
    public static Item buckler_Inactive = new Item("Buckler Inactive", "Buckler_Inactive", new List<Item>() { ring_of_Protection, recipe });
    public static Item ring_of_Basilius_Active = new Item("Ring of Basilius Active", "Ring_of_Basilius_Active", new List<Item>() { sages_Mask, recipe });
    public static Item magic_Wand = new Item("Magic Wand", "Magic_Wand", new List<Item>() { magic_Stick, iron_Branch, iron_Branch, recipe });
    public static Item aether_Lens = new Item("Aether Lens", "Aether_Lens", new List<Item>() { energy_Booster, void_Stone, recipe });
    public static Item oblivion_Staff = new Item("Oblivion Staff", "Oblivion_Staff", new List<Item>() { quarterstaff, robe_of_the_Magi, sages_Mask });
    public static Item arcane_Boots = new Item("arcane Boots", "Arcane_Boots", new List<Item>() { boots_of_Speed, energy_Booster });
    public static Item perseverance = new Item("Perseverance", "Perseverance", new List<Item>() { ring_of_Health, void_Stone });
    public static Item maelstrom = new Item("Maelstrom", "Maelstrom", new List<Item>() { mithril_Hammer, javelin });
    public static Item sange = new Item("Sange", "Sange", new List<Item>() { ogre_Axe, belt_of_Strength, recipe });
    public static Item yasha = new Item("Yasha", "Yasha", new List<Item>() { blade_of_Alacrity, band_of_Elvenskin, recipe });
    public static Item vanguard = new Item("Vanguard", "Vanguard", new List<Item>() { ring_of_Health, vitality_Booste });
    public static Item null_Talisman = new Item("Null Talisman", "Null_Talisman", new List<Item>() { ring_of_Health, vitality_Booste });
    public static Item bracer = new Item("Bracer", "Bracer", new List<Item>() { circlet, gauntlets_of_Strength, recipe });


    public static Item urn_of_Shadows = new Item("Urn of Shadows", "Urn_of_Shadows", new List<Item>() { sages_Mask, circlet, ring_of_Protection, recipe });
    public static Item spirit_Vessel = new Item("Spirit_Vessel", "Spirit_Vessel", new List<Item>() { urn_of_Shadows, vitality_Booste, recipe });
    public static Item necronomicon_1 = new Item("Necronomicon 1", "Necronomicon_1", new List<Item>() { sages_Mask, sages_Mask, belt_of_Strength, recipe });
    public static Item aeon_Disk = new Item("Aeon Disk", "Aeon_Disk", new List<Item>() { vitality_Booste, energy_Booster, recipe });
    public static Item veil_of_Discord = new Item("Veil of Discord", "Veil_of_Discord", new List<Item>() { ring_of_Basilius_Active, crown, recipe });
    public static Item assault_Cuirass = new Item("Assault Cuirass", "Assault_Cuirass", new List<Item>() { platemail, hyperstone, buckler_Inactive, recipe });
    public static Item battle_Fury = new Item("Battle Fury", "Battle_Fury", new List<Item>() { broadsword, claymore, perseverance, quelling_Blade });
    public static Item euls_Scepter_of_Divinity = new Item("Euls Scepter of Divinity", "Euls_Scepter_of_Divinity", new List<Item>() { staff_of_Wizardry, void_Stone, wind_Lace, recipe });
    public static Item wind_Waker = new Item("Wind Waker", "Wind_Waker", new List<Item>() { mystic_Staff, euls_Scepter_of_Divinity, recipe });
    public static Item rod_of_Atos = new Item("Rod of Atos", "Rod_of_Atos", new List<Item>() { staff_of_Wizardry, crown, crown, recipe });
    public static Item crimson_guard = new Item("Crimson guard", "Crimson_guard", new List<Item>() { vanguard, helm_of_Iron_Will, recipe });
    public static Item heavens_Halberd = new Item("Heaven's Halberd", "Heaven's_Halberd", new List<Item>() { sange, talisman_of_Evasion, recipe });
    public static Item mjollnir = new Item("Mjollnir", "Mjollnir", new List<Item>() { maelstrom, hyperstone, recipe });
    public static Item lotus_Orb = new Item("Lotus Orb", "Lotus_Orb", new List<Item>() { perseverance, platemail, energy_Booster });
    public static Item desolator = new Item("Desolator", "Desolator", new List<Item>() { mithril_Hammer, mithril_Hammer, blight_Stone });
    public static Item aghanims_Scepter = new Item("Aghanim's_Scepter", "Aghanim's_Scepter", new List<Item>() { point_Booster, staff_of_Wizardry, ogre_Axe, blade_of_Alacrity });
    public static Item echo_Sabre = new Item("Echo Sabre", "Echo_Sabre", new List<Item>() { ogre_Axe, oblivion_Staff });
    public static Item helm_of_the_Dominator = new Item("Helm of the Dominator", "Helm_of_the_Dominator", new List<Item>() { helm_of_Iron_Will, crown, recipe });
    public static Item helm_of_the_Dominator_2 = new Item("Helm of the Dominator 2", "Helm_of_the_Dominator_2", new List<Item>() { helm_of_the_Dominator, ultimate_Orb, recipe });
    public static Item medallion_of_Courage = new Item("Medallion of Courage", "Medallion_of_Courage", new List<Item>() { chainmail, sages_Mask, blight_Stone });
    public static Item solar_Crest = new Item("Solar Crest", "Solar_Crest", new List<Item>() { medallion_of_Courage, ultimate_Orb, wind_Lace, recipe });
    public static Item armlet_of_Mordiggian = new Item("Armlet of Mordiggian", "Armlet_of_Mordiggian", new List<Item>() { helm_of_Iron_Will, gloves_of_Haste, blades_of_Attack, recipe });
    public static Item dagon = new Item("Dagon", "Dagon", new List<Item>() { staff_of_Wizardry, crown, recipe });
    public static Item glimmer_Cape = new Item("Glimmer Cape", "Glimmer_Cape", new List<Item>() { shadow_Amulet, cloak, recipe });
    public static Item drum_of_Endurance = new Item("Drum of Endurance", "Drum_of_Endurance", new List<Item>() { robe_of_the_Magi, belt_of_Strength, wind_Lace, recipe });
    public static Item satanic = new Item("Satanic", "Satanic", new List<Item>() { morbid_Mask, claymore, reaver });
    public static Item heart_of_Tarrasque = new Item("Heart of Tarrasque", "Heart_of_Tarrasque", new List<Item>() { vitality_Booste, reaver, recipe });
    public static Item shadow_Blade = new Item("Shadow Blade", "Shadow_Blade", new List<Item>() { shadow_Amulet, blitz_Knuckles, broadsword });
    public static Item silver_Edge = new Item("Silver Edge Blade", "Silver_Edge", new List<Item>() { shadow_Blade, oblivion_Staff, recipe });
    public static Item octarine_Core = new Item("Octarine Core", "Octarine_Core", new List<Item>() { aether_Lens, soul_Booster });
    public static Item bloodstone = new Item("Bloodstone", "Bloodstone", new List<Item>() { kaya, soul_Booster, voodoo_Mask });
    public static Item holy_Locket = new Item("Holy Locket", "Holy_Locket", new List<Item>() { headdress, fluffy_Hat, energy_Booster, magic_Wand, recipe });
    public static Item hood_of_Defiance = new Item("Hood of Defiance", "Hood_of_Defiance", new List<Item>() { ring_of_Health, cloak, ring_of_Regen });
    public static Item eternal_Shroud = new Item("Eternal Shroud", "Eternal_Shroud", new List<Item>() { hood_of_Defiance, voodoo_Mask, recipe });
    public static Item mekansm = new Item("Mekansm", "Mekansm", new List<Item>() { headdress, chainmail, recipe });
    public static Item guardian_Greaves = new Item("Guardian Greaves", "Guardian_Greaves", new List<Item>() { mekansm, arcane_Boots, buckler_Inactive, recipe });
    public static Item vladmirs_Offering = new Item("Vladmirs Offering", "Vladmirs_Offering", new List<Item>() { buckler_Inactive, ring_of_Basilius_Active, morbid_Mask, blades_of_Attack, recipe });
    public static Item mage_Slaye = new Item("Mage Slaye", "Mage_Slayer", new List<Item>() { cloak, claymore, blade_of_Alacrity, recipe });
    public static Item witch_Blade = new Item("Witch Blade", "Witch_Blade", new List<Item>() { blitz_Knuckles, robe_of_the_Magi, chainmail, recipe });
    public static Item falcon_Blade = new Item("Falcon Blade", "Falcon_Blade", new List<Item>() { sages_Mask, blades_of_Attack, fluffy_Hat, recipe });
    public static Item soul_Ring = new Item("Soul Ring", "Soul_Ring", new List<Item>() { ring_of_Protection, gauntlets_of_Strength, gauntlets_of_Strength, recipe });
    public static Item gleipnir = new Item("Gleipnir", "Gleipnir", new List<Item>() { maelstrom, rod_of_Atos, recipe });

    public static List<Item> GetItemsForCraft()
    {
        List<Item> items = new List<Item>();
        for (int i = 0; i < itemsForCraft.Count; i++)
        {
            items.Add(itemsForCraft[i]);
        }
        return items;
    }
}

public class Item
{
    public string Name;
    public string Image;
    public List<Item> Craft = new List<Item>();

    public Item(string name, string image, List<Item> craft)
    {
        Name = name;
        Image = image;
        Craft = craft;
        if (craft.Count == 0)
        {
            Items.itemsForCraft.Add(this);
        }
    }
}
