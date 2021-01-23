using System;
using System.Collections.Generic;

public class Questions
{
    [NonSerialized] public string question;
    [NonSerialized] public string about;
    [NonSerialized] public string answers1;
    [NonSerialized] public string answers2;
    [NonSerialized] public string answers3;
    [NonSerialized] public string answers4;
    [NonSerialized] public byte tier;
    [NonSerialized] public string image;
    [NonSerialized] public string sound;
    [NonSerialized] public int correctAnswer;
    [NonSerialized] public int numberAnswer;
    [NonSerialized] public int id;
    [NonSerialized] public int repeated = 0;
    [NonSerialized] public byte[] keys;
    [NonSerialized] public Item item;
    [NonSerialized] public List<Item> yourCraft;
    [NonSerialized] public List<Item> fakeItems;


    public Questions(string Question, string About, string Answers1, string Answers2, string Answers3, string Answers4, byte Tier, string Image, string Sound)
    {
        Game.id++;
        id = Game.id;
        question = Question;
        about = About;
        answers1 = Answers1;
        answers2 = Answers2;
        answers3 = Answers3;
        answers4 = Answers4;
        tier = Tier;
        image = Image;
        sound = Sound;
    }

    public Questions(Item Item, List<Item> items, byte Tier)
    {
        Game.id++;
        id = Game.id;
        item = Item;
        fakeItems = items;
        image = Item.Image;
        tier = Tier;
    }
}
