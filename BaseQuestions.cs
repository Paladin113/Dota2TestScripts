using System.Collections.Generic;
public class BaseQuestions
{
    public List<Questions> questions = new List<Questions>();
    public List<Questions> BaseActive()
    {
        questions.Add(new Questions("Сколько длится эффект от руны иллюзий?", "", "75", "45", "60", "90", 4, "Rune_of_Illusion", ""));

        questions.Add(new Questions("На какой волне крипов появляется первая катапульта?", "", "11", "7", "15", "10", 3, "Siege_Creep", ""));

        questions.Add(new Questions("Сколько разновидностей крипов-сатиров существует в доте?", "Satyr Tormenter, Satyr Mindstealer, Satyr Banisher.", "3", "2", "4", "5", 1, "", ""));

        questions.Add(new Questions("Как называется объект, в который превращается Phoenix, применив Supernova?", "", "Phoenix Sun", "Phoenix Egg", "Fire Egg", "Fire Sun", 3, "Phoenix4", ""));

        questions.Add(new Questions("Сколько опыта можно получить, зачистив лагерь обычных глиняных големов?", "Mud Golems - 32 опыта, Shard Golems - 17 опыта.", "132", "120", "108", "144", 3, "Mud_golem", ""));

        questions.Add(new Questions("Сколько предметов нужно для сборки Crimson Guard?", "Рецепт, Helm of iron will, Ring of health, Vitality booster.", "4", "5", "6", "3", 1, "Crimson_guard", ""));

        questions.Add(new Questions("Какая из этих способностей не позволяет юнитам проходить сквозь препятствия?", "", "Slark - Shadow Dance", "Lich - Sinister Gaze", "Clockwerk - Jetpack", "Dark - Dark Ascension", 1, "", ""));

        questions.Add(new Questions("Что бросает Bounty Hunter в противника, когда использует способность Track?", "Используется модель такая же, что и у банки Alchemist.", "Банка", "Кинжал", "Листовку", "Сюрикен", 2, "Bounty4", ""));

        questions.Add(new Questions("Какой из этих предметов дороже остальных?", "", "Abyssal Blade", "Gleipnir", "Divine Rapier", "Bloodthorn", 3, "", ""));

        questions.Add(new Questions("У какого из этих персонажей нет анимации ранения?", "", "Sven", "Monkey King", "Wraith King", "Rubick", 2, "", ""));

        questions.Add(new Questions("Сколько деревьев максимально может бросить Tiny во время применения Tree Volley?", "", "6", "3", "9", "12", 2, "TinyAghanim", ""));

        questions.Add(new Questions("Какой из этих способностей нет у сатиров?", "", "Critical Strike", "Mana Burn", "Shockwave", "Unholy Aura", 2, "", ""));

        questions.Add(new Questions("Какой из этих предметов дороже остальных?", "", "Blight Stone", "Sage's Mask", "Fluffy Hat", "Ring of Regen", 1, "", ""));

        questions.Add(new Questions("Для сборки какого из этих предметов не нужен рецепт?", "", "Lotus Orb", "Helm of the Dominator", "Falcon Blade", "Solar Crest", 2, "", ""));

        questions.Add(new Questions("Сколько ударов крипы/иллюзии/прочие юниты-не-герои разбивают Sentry Ward?", "", "10", "8", "5", "7", 3, "Sentry_Ward", ""));

        questions.Add(new Questions("На какой минуте игры крипы на линии достигают своей максимальной мощности?", "", "225", "120", "400", "600", 4, "", ""));

        questions.Add(new Questions("У какого из этих героев самый высокий прирост интеллекта за уровень?", "", "Medusa", "Windranger", "Hoodwink", "Storm Spirit", 2, "", ""));

        questions.Add(new Questions("Какой из этих предметов нельзя собрать, используя только потайную лавку?", "", "Bloodstone", "Lotus Orb", "Eye of Skadi", "Scythe of Vyse", 1, "", ""));

        questions.Add(new Questions("Какое максимальное кол-во целей может поразить Static Charge от Mjollnir?", "", "5", "7", "4", "6", 2, "Mjollnir", ""));

        questions.Add(new Questions("Сколько предметов в игре накладывает Silence ( Hex не учитывать )?", "Orchid Malevelence, Bloodthorne, Mind Breaker, Mask of Madness.", "4", "5", "6", "3", 2, "", ""));

        questions.Add(new Questions("Сколько единиц маны восстанавливает Cheese?", "", "1500", "1000", "2000", "2500", 2, "Cheese", ""));

        questions.Add(new Questions("У какого из этих предметов самый дорогой рецепт?", "", "Daedalus", "Linken's Sphere", "Gleipnir", "Heart of Tarrasque", 2, "", ""));

        questions.Add(new Questions("Какая дальность атаки у Фонтана?", "", "1200", "1000", "1600", "1400", 2, "", ""));

        questions.Add(new Questions("За какого из этих нейтральных крипов дают больше всего опыта?", "", "Dark Troll Summoner", "Alpha Wolf", "HellBear", "Satyr Mindstealer", 3, "", ""));

        questions.Add(new Questions("Какая их этих способностей обладает наибольшим кулдауном на 1 уровне без талантов?", "Finger of Death 160 сек., Ravage 150 сек., Echo Slam 150 сек., Dark Ascension 140 сек.", "Lion - Finger of Death", "Night Stalker - Dark Ascension", "Tidehunter - Ravage", "Earthshaker - Echo Slam", 2, "", ""));

        questions.Add(new Questions("Какова стоимость Necronomicon 3-го уровня?", "", "4550", "4850", "5150", "4650", 4, "Necronomicon3", ""));

        questions.Add(new Questions("Какой знак зодиака появляется над противником, когда Spirit Breaker берет разгон на него?", "", "Телец", "Овен", "Лев", "Козерог", 2, "Spirit_breaker1", ""));

        questions.Add(new Questions("Какому герою принадлежит имя Zharvakko?", "", "Witch Doctor", "Jakiro", "Dazzle", "Disruptor", 2, "", ""));

        questions.Add(new Questions("Какое из этих утверждений правильное?", "", "У Broodmother 6 глаз, 8 ног", "У Broodmother 6 глаз, 6 ног", "У Broodmother 8 глаз, 8 ног", "У Broodmother 8 глаз, 6 ног", 2, "", ""));

        questions.Add(new Questions("Оригинальный посох какого персонажа основан на разновидности посохов у буддистских священиков под названием - Хакхарра?", "", "Dazzle", "Chen", "Whitch Doctor", "Warlock", 4, "", ""));

        questions.Add(new Questions("У какого героя есть анимация, повторяющая смерть Терминатора?", "", "Clockwerk", "Lion", "Shadow Fiend", "Timbersaw", 1, "", ""));

        questions.Add(new Questions("В каком году Necrolyte был переименован на Necrophos?", "", "2013 ", "2012", "2014", "2015", 3, "Necrolyte", ""));

        questions.Add(new Questions("Уничтожение какого объекта приносит больше всего опыта?", "Всё кроме Stasis Trap не даёт опыта", "Stasis Trap - Techies", "Nimbus - Zeus", "Sentry Ward", "Tombstone - Undying", 5, "", ""));

        questions.Add(new Questions("Какой герой понимает язык Io и Phoenix?", "", "Puck", "Enigma", "Arc Warden", "Oracle", 2, "", ""));

        questions.Add(new Questions("Сколько персонажей может разговаривать на языке 'Озкавош'?", "Doom, Shadow Demon, Shadow Fiend, Terrorblade, Legion Commander", "5 ", "3", "8", "6", 2, "", ""));

        questions.Add(new Questions("На сколько использование выкупа увеличивает следующее время возрождения?", "", "25", "35", "45", "55", 2, "", ""));

        questions.Add(new Questions("Таланты какого из героев увеличивают ночной обзор?", "", "Winter Wyvern", "Night Stalker", "Batraider", "Slardar", 3, "", ""));

        questions.Add(new Questions("С какой периодичностью происходит усиление крипов на линии?", "", "7,5 минут", "2,5 минуты", "5,5 минут", "10,5 минут", 4, "", ""));

        questions.Add(new Questions("Какая надпись появляется под Tusk, если Rubick украдет Warlus Punch и попадет в Tusk?", "", "Sucker Punch", "Magus Punch", "Stolen Punch", "Walrus Punch", 2, "Tusk4", ""));

        questions.Add(new Questions("Какого героя зовут Lyralei?", "", "Windranger", "Crystal Maiden", "Enchantress", "Legion Commander", 2, "", ""));

        questions.Add(new Questions("Из какой части игровой модели Abaddon исходит Mist Coil?", "", "Рот", "Левая рука", "Конь", "Правая рука", 4, "Abaddon1", ""));

        questions.Add(new Questions("Какой из этих персонажей женского пола?", "", "Spectre", "Bane", "Morphling", "Pugna", 1, "", ""));

        questions.Add(new Questions("Сколько персонажей имеет возможность совершить самоубийство?", "Alchemist, Rubick, Morphling, Pugna, Techies", "5", "3", "2", "4", 5, "", ""));

        questions.Add(new Questions("Сколько существует способностей, которые напрямую дают игроку дополнительное золото?", "Jinada, Track, Greevil's Greed, Devour", "4", "1", "2", "3", 5, "", ""));

        questions.Add(new Questions("Какого предмета нет в составе Holy Locket?", "", "Void Stone", "Fluffy Hat", "Energy Booster", "Magic Wand", 2, "Holy_Locket", ""));

        questions.Add(new Questions("Кто из этих героев имеет самый большой прирост ловкости?", "", "Leshrac", "Invoker", "Silencer", "Enchantress", 4, "", ""));

        questions.Add(new Questions("Какого из этих персонажей добавили в Dota 2 раньше других?", "", "Juggernaut", "Bounty Hunter", "Riki", "Centaur Warrunner", 2, "", ""));

        questions.Add(new Questions("Для сборки какого из этих предметов надо больше всего составляющих?", "Ring of Regen, Рецеапт:Headdress, Ring of Protection, Рецепт:Buckler, Chainmail, Рецепт:Mekansm, Boots of Speed, Energy Booster, Рецепт:Guardian Greaves", "Guardian Greaves", "Sange and Yasha", "Abyssal Blade", "Wind Waker", 1, "", ""));

        questions.Add(new Questions("Сколько способностей накладывает на врага эффект страха?", "Dark Willow - Terrorize, Lone Druid (и Spirit Bear) - Savage Roar, Queen of Pain - Scream of Pain, Shadow Fiend - Requiem of Souls, Terrorblade - Terror Wave, Vengeful Spirit - Nether Swap", "6", "5", "4", "3", 5, "", ""));

        questions.Add(new Questions("Кто из нейтральных крипов может кастовать скилл Mana Burn?", "", "Satyr", "Troll", "Harpy", "Ancient Thunderhide", 1, "Satyr_Mana_burn", ""));

        questions.Add(new Questions("Сколько ударов максимально может выдержать Phoenix Sun со всеми бустами?", "", "16", "18", "14", "12", 2, "Phoenix4", ""));

        questions.Add(new Questions("Вписав какое сокращение в строке поиска лавки, мы получим Iron Branch?", "", "gg", "wp", "np", "ez", 2, "Branches", ""));

        questions.Add(new Questions("Сколько здоровья восстанавливает Cheese?", "", "2500", "1500", "2000", "3000", 2, "Cheese", ""));

        questions.Add(new Questions("В каком патче у Tiny 'отобрали' улучшение от Aghanim's Scepeter и добавили 2 новые способности?", "", "7.07", "7.08", "7.06", "7.05", 2, "Tiny", ""));

        questions.Add(new Questions("Талант какого героя дает больше всего вампиризма?", "", "Luna 25-го уровня", "Sven 15-го уровня", "Slardar 20-го уровня", "Arc Warden 25-го уровня", 2, "", ""));

        questions.Add(new Questions("У какого из этих персонажей наибольший прирост силы?", "", "Earth Spirit", "Tiny", "Io", "Dragon Knight", 3, "", ""));

        questions.Add(new Questions("У какого героя нет своего анонсера в Dota 2?", "", "Nyx Assassin", "Monkey King", "Axe", "Death Prophet", 1, "", ""));

        questions.Add(new Questions("Серию из скольки убийств нужно сделать, чтобы заработать Godlike?", "", "9", "7", "8", "10", 4, "", ""));

        questions.Add(new Questions("Сколько способностей накладывает на врага эффект 'Сон'?", "Nightmare, Echo Stomp, Song of the Siren, Riki - Sleeping Dart", "4", "2", "3", "1", 3, "", ""));

        questions.Add(new Questions("У какого из этих героев самая высокая базовая дальность атаки?", "", "Ancient Apparition", "Lina", "Sniper", "Clinkz", 3, "", ""));

        questions.Add(new Questions("У какого из этих героев основным атрибутом является интеллект?", "", "Void Spirit", "Nyx Assassin", "Hoodwink", "Phoenix", 1, "", ""));

        questions.Add(new Questions("Сколько способностей в Dota 2 обладает эффектом 'Гипноз'?", "Sinister Gaze, Aether Remnant, Keeper of the Light - Will-O-Wisp", "3", "0", "1", "2", 4, "", ""));

        questions.Add(new Questions("Сколько зарядов Bloodstone теряется при смерти героя?", "", "3", "2", "1", "50%", 2, "Bloodstone", ""));

        questions.Add(new Questions("На сколько секунд Heaven's Halberd обезоруживает героя ближнего боя?", "", "3", "6", "4", "5", 2, "Heaven's_Halberd", ""));

        questions.Add(new Questions("В каком году Skeleton King превратился в Wraith King?", "", "2013", "2012", "2014", "2015", 3, "Skeleton_King", ""));

        questions.Add(new Questions("Какое время перезарядки у выкупа?", "", "480 сек", "180 сек", "300 сек", "540 сек", 2, "", ""));

        questions.Add(new Questions("Уничтожение какого существа или предмета дает больше всего золота?", "", "Tombstone", "Nimbus", "Healing Ward", "Familiar", 1, "", ""));

        questions.Add(new Questions("Чему Legion Commander делает комплимент, когда обращается к Gyrocopter, Tusk и Zeus?", "", "Усам", "Имени", "Силе", "Расе", 1, "Legion_commander", ""));

        questions.Add(new Questions("Сколько опыта можно получить, зачистив малый лагерь кентавров?", "", "121", "81", "101", "141", 3, "", ""));

        questions.Add(new Questions("У какого из этих героев самый высокий начальный показатель силы?", "", "Kunkka", "Axe", "Brewmaster", "Chaos Knight", 3, "", ""));

        questions.Add(new Questions("Какой герой часто использует знаменитую фразу Scorpion из игры Mortal Kombat?", "", "Pudge", "Sand King", "Nyx", "Clockwerk", 1, "", ""));

        questions.Add(new Questions("Действие какой руны длится меньше всего?", "", "Ускорение", "Двойной урон", "Невидимость", "Волшебство", 1, "", ""));

        questions.Add(new Questions("За сколько золота можно продать Refresher Shard?", "", "500", "550", "525", "575", 1, "Refresher_Shard", ""));

        questions.Add(new Questions("Какой герой был назван в честь немецкого физика?", "", "Magnus", "Puck", "Lina", "Leshrac", 1, "", ""));

        questions.Add(new Questions("На модели какого героя есть надпись 'Здесь был Riki'?", "", "Treant Protector", "Tiny", "Axe", "Timbersaw", 1, "", ""));

        questions.Add(new Questions("Какой из героев появился в основном клиенте игры раньше других?", "", "Winter Wyvern", "Monkey King", "Underlord", "Arc Warden", 1, "", ""));

        questions.Add(new Questions("Сколько героев могут изменить свой тип базовой атаки?", "Dragon Knight, Lone Druid, Morphling, Rubick, Terrorblade, Troll Warlord", "6", "3", "4", "5", 5, "", ""));

        questions.Add(new Questions("Сколько способностей может создать Invoker?", "", "10", "9", "11", "12", 1, "Invoker4", ""));

        questions.Add(new Questions("Какой из этих предметов нельзя положить в ранец?", "", "Bloodstone", "Cheese", "Book of Shadows", "Moon Shard", 1, "", ""));

        questions.Add(new Questions("Какой из ниже представленных предметов самый дорогой?", "", "Heaven's Halberd", "Desolator", "Mage Slayer", "Aeon Disk", 2, "", ""));

        questions.Add(new Questions("У какого из этих предметов самый дешевый рецепт?", "", "Gleipnir", "Eternal Shroud", "Skull Basher", "Aeon Disk", 1, "", ""));

        questions.Add(new Questions("Сколько героев имеет королевские титулы в своем названии?", "Wraith King, Sand King, Monkey King, Queen of Pain", "4", "5", "2", "3", 3, "", ""));

        questions.Add(new Questions("У какого из этих героев самый высокий показатель интеллекта на 1 уровне?", "", "Lina", "Queen of Pain", "Rubick", "Silencer", 4, "", ""));

        questions.Add(new Questions("Сколько брони у Roshan в самом начале матча?", "", "20", "14", "16", "18", 4, "Roshan", ""));

        questions.Add(new Questions("Кого так приветствует Abbadon?", "", "Bounty Hunter", "Tidehunter", "Night Stalker", "Riki", 1, "Abaddon", "Abad_ally_06"));

        questions.Add(new Questions("Какая стандартная длина фиссуры Earthshaker?", "", "1400", "1300", "1100", "1200", 2, "Earthshaker1", ""));

        questions.Add(new Questions("У какого из этих героев самая высокая скорость передвижения?", "", "Legion Commander", "Lina", "Luna", "Leshrac", 3, "", ""));

        questions.Add(new Questions("При подборе какой руны происходит этот звук?", "", "Bounty Rune", "Haste Rune", "Double Damage Rune", "Arcane Rune", 3, "", "RuneBounty"));

        questions.Add(new Questions("Как называется пассивная способность Necrophos?", "", "Heartstopper Aura", "Sadist", "Ghost Shroud", "Death Pulse", 1, "Necrolyte3", ""));

        questions.Add(new Questions("Длительность жизни суммонов Beast Master?", "", "60 секунд", "30 секунд", "45 секунд", "50 секунд", 3, "Beastmaster2", ""));

        questions.Add(new Questions("Какой вид дизейбла имеет Sinister Gaze у Lich?", "", "Гипноз", "Страх", "Сон", "Провокация", 1, "Lich3", ""));

        questions.Add(new Questions("Сколько пальцев на руке у Axe?", "", "3", "2", "4", "5", 1, "Axe", ""));

        questions.Add(new Questions("", "", "Mirana", "Phantom Lancer", "Naga Siren", "Weaver", 1, "Mirana_talant", ""));

        questions.Add(new Questions("Кто здесь лишний?", "", "Vengeful Spirit", "Void Spirit", "Earth Spirit", "Storm Spirit", 1, "", ""));

        questions.Add(new Questions("Какое имя носит Bane?", "", "Atropos", "Nyctasha", "Nightmare", "Bane", 2, "Bane", ""));

        questions.Add(new Questions("", "", "Enigma", "Lone Druid", "Bristleback", "Treant Protector", 2, "Enigma_talant", ""));

        questions.Add(new Questions("Базовая скорость передвижения Viper?", "", "275", "285", "295", "265", 4, "Viper", ""));

        questions.Add(new Questions("Сколько всего братьев-спиритов в Dota 2?", "Storm Spirit, Ember Spitit, Earth Spirit, Void Spirit.", "4", "5", "2", "3", 1, "", ""));

        questions.Add(new Questions("Сколько предметов можно собрать из Crown?", "Meteor Hammer, Helm of the Dominator, Dagon, Veil of Discord, Rod of Atos", "5", "3", "4", "2", 3, "Crown", ""));

        questions.Add(new Questions("Сколько предметов можно собрать из Boots of Speed?", "Boots of Travel 1,2, Phase Boots, Power Treads, Tranquil Boots, Arcane Boots, Guardian Greaves", "7", "4", "5", "6", 4, "Boots_of_Speed", ""));

        questions.Add(new Questions("Сколько предметов можно собрать из Ultimate Orb?", "Scythe of Vyse, Linken's Sphere, Eye of Skadi, Helm of the Dominator 2, Solar Crest, Manta Style", "6", "4", "5", "3", 4, "Ultimate_Orb", ""));

        questions.Add(new Questions("Сколько предметов можно собрать из Sacred Relic?", "Nullifier, Divine Rapier, Radiance", "3", "5", "2", "4", 1, "Sacred_Relic", ""));

        questions.Add(new Questions("Какой герой не имеет дизейбл 'Страх'?", "", "Queen of Pain", "Dark Willow", "Lone Druid", "Terrorblade", 1, "", ""));

        questions.Add(new Questions("", "", "Spirit Breaker", "Night Stalker", "IO", "Ogre Magi", 2, "Spirit_breaker_talant", ""));

        questions.Add(new Questions("Кто из этих героев не может создать иллюзию своего героя?", "", "Grimstroke", "Vengeful Spirit", "Shadow Demon", "Phantom Lancer", 1, "", ""));

        questions.Add(new Questions("Сколько Immortal посохов имеет Crystal Maiden?", "Ice Blossom, Golden Ice Blossom, White Sentry", "3", "2", "1", "0", 2, "Crystal_maiden", ""));

        questions.Add(new Questions("Базовая скорость передвижения Crystal Maiden?", "", "280", "270", "300", "290", 2, "Crystal_maiden", ""));

        questions.Add(new Questions("Базовая скорость передвижения Pugna?", "", "330", "320", "300", "290", 4, "Pugna", ""));

        questions.Add(new Questions("Базовая скорость передвижения Io?", "", "320", "310", "290", "300", 4, "Wisp", ""));

        questions.Add(new Questions("Базовая скорость передвижения Abaddon?", "", "325", "315", "305", "335", 3, "Abaddon", ""));

        questions.Add(new Questions("Базовая скорость передвижения Shadow Shaman?", "", "285", "295", "305", "290", 3, "Shadow_shaman", ""));

        questions.Add(new Questions("На сколько увеличивается урон от Finger of Death у Lion за каждое убийство ультимейтом без таланта?", "", "40", "30", "50", "20", 1, "Lion4", ""));

        questions.Add(new Questions("У кого больше прирост интеллекта за уровень?", "", "Outworld Destroyer", "Medusa", "Storm Spirit", "Skywrath Mage", 2, "", ""));

        questions.Add(new Questions("У кого больше прирост силы за уровень?", "", "Slardar", "Bristleback", "Ogre Magi", "Wraith King", 4, "", ""));

        questions.Add(new Questions("У кого больше прирост ловкости за уровень?", "", "Shadow Fiend", "Juggernaut", "Luna", "Anti-Mage", 3, "", ""));

        questions.Add(new Questions("У кого больше прирост интеллекта за уровень?", "", "Storm Spirit", "Keeper of the light", "Lina", "Nature's Prophet", 1, "", ""));

        questions.Add(new Questions("У кого больше прирост силы?", "", "Tiny", "Omniknight", "Legion Commander", "Night Stalker", 1, "", ""));

        questions.Add(new Questions("Какого типа урона не существует?", "Существует осадный тип атаки. Напимер у катапульты", "Осадного", "Физического", "Магического", "Чистого", 1, "", ""));

        questions.Add(new Questions("Через сколько времени после смерти появляется Roshan?", "", "8-11 минут", "6-9 минут", "7-10 минут", "5-8 минут", 1, "Roshan", ""));

        questions.Add(new Questions("Какова длительность жизни копии у Arc Warden на 1 уровне прокачивания способности?", "", "18", "20", "22", "16", 2, "Arc_Warden4", ""));

        questions.Add(new Questions("Сколько нужно нанести ударов героем по Phantom's Embrace у Grimstroke на 3 уровне прокачивания способности без таланта?", "", "3", "2", "4", "5", 2, "Grimstroke2", ""));

        questions.Add(new Questions("Сколько нужно нанести ударов существом по Phantom's Embrace у Grimstroke на 3 уровне прокачивания способности без таланта?", "", "9", "3", "6", "ы", 5, "Grimstroke2", ""));

        questions.Add(new Questions("Сколько длится действие Shallow Grave у Dazzle?", "", "4/4.5/5/5.5", "6", "5/6/7/8", "5", 2, "Dazzle2", ""));

        questions.Add(new Questions("На какого героя первым была создана аркана?", "", "Lina", "Terrorblade", "Legion Commander", "Techies", 1, "", ""));

        questions.Add(new Questions("В каком году вышла самая первая аркана в Dota 2?", "", "2013", "2012", "2011", "2014", 2, "", ""));

        questions.Add(new Questions("Сколько нужно атак для уничтожения Will-O-Wisp у Keeper Of The Light?", "", "6", "3", "5", "4", 2, "Keeper_Of_The_Light4", ""));

        questions.Add(new Questions("Какое имя у Keeper Of The Light?", "", "Ezalor", "Antonidas", "Chakra", "Aghanim", 1, "Keeper_of_the_light", ""));

        questions.Add(new Questions("Сколько существует способностей, способных изменить время суток в игре?", "Eclipse, Dark Ascension, Supernova", "3", "2", "1", "4", 2, "", ""));

        questions.Add(new Questions("Какой тип урона имеет Meat Hook у Pudge?", "", "Чистый", "Магический", "Физический", "", 1, "Pudge1", ""));

        questions.Add(new Questions("Какой тип урона имеет Bash Of The Deep у Slardar?", "", "Физический", "Чистый", "Магический", "", 1, "Slardar3", ""));

        questions.Add(new Questions("Какой тип урона имеет Stifling Dagger у Phantom Assasin?", "", "Физический", "Чистый", "Магический", "", 1, "Phantom_assassin1", ""));

        questions.Add(new Questions("Какой тип урона имеет Headshot y Sniper?", "", "Физический", "Чистый", "Магический", "", 1, "Sniper2", ""));

        questions.Add(new Questions("Какой тип урона имеет Heartstopper Aura y Necrophos?", "", "Магический", "Физический", "Чистый", "", 1, "Necrolyte3", ""));

        questions.Add(new Questions("Сколько максимально иллюзий может создать Phantom Lancer со способности Juxtapose на 1 уровне прокачивания?", "", "6", "7", "5", "Не ограничено", 1, "Phantom_lancer4", ""));

        questions.Add(new Questions("Какой кулдаун имеет способность Light Strike Array y Lina?", "", "10/9/8/7", "6", "8/7/6/5", "7", 2, "Lina2", ""));

        questions.Add(new Questions("Сколько иллюзий может вызвать Naga Siren со способности Mirror Image без таланта?", "", "3", "5", "6", "4", 1, "Naga_siren1", ""));

        questions.Add(new Questions("Сколько героев в Dota 2?", "", "120", "119", "118", "121", 2, "", ""));

        questions.Add(new Questions("Сколько героев в Dota 2 имеют пассивную ультимативную способность?", "Bristleback, Dazzle, Drow Ranger, Enchantress, Meppo, Ogre Magi, Phantom Assassin, Phantom Lancer, Riki, Tiny, Wraith King", "11", "7", "5", "9", 4, "", ""));

        questions.Add(new Questions("Кто из этих героев принадлежит мужскому полу?", "Enigma является бесполым существом", "Pugna", "Enigma", "Hoodwink", "Phoenix", 1, "", ""));

        questions.Add(new Questions("Какой из этих героев не имеет оружия в руках?", "", "Leshrac", "Disruptor", "Razor", "Snapfire", 1, "", ""));

        questions.Add(new Questions("Какому герою принадлежит имя - Nerif?", "", "Oracle", "Hoodwink", "Monkey King", "Dark Seer", 2, "", ""));

        questions.Add(new Questions("Какому герою принадлежит имя - Arachnia?", "", "Broodmother", "Weaver", "Nyx", "Sand King", 1, "", ""));

        questions.Add(new Questions("Какому герою принадлежит имя - Gondar?", "", "Bounty Hunter", "Bristleback", "Pangolier", "Leshrac", 1, "", ""));

        questions.Add(new Questions("Какой из этих героев имеет только физический тип урона?", "Магический урон: Lifestealer - Infest, Sniper - Assassinate, Weaver - Shukuchi", "Slardar", "Lifestealer", "Sniper", "Weaver", 1, "", ""));

        questions.Add(new Questions("Какой самый популярный герой по количеству сыгранных матчей за всё время?", "", "Pudge", "Sniper", "Invoker", "Phantom Assassin", 1, "", ""));

        questions.Add(new Questions("Не скрыться от него ни душе. Никто не знает, что он с ними делает. О ком это высказывание?", "", "Shadow Fiend", "Bounty Hunter", "Oracle", "Enigma", 1, "", ""));

        questions.Add(new Questions("Он занимает высокий пост мага при дворе Жуткого гнезда, но дни его полны печали. О ком это высказывание?", "", "Skywrath Mage", "Grimstroke", "Silencer", "Invoker", 1, "", ""));

        questions.Add(new Questions("Наследница королевской династии и первая претендентка на Лучезарный трон отреклась от мирских земель и титулов, посвятив свою жизнь богине Луны Селемине. О ком это высказывание?", "", "Mirana", "Luna", "Vengeful Spirit", "Drow Ranger", 2, "", ""));

        questions.Add(new Questions("Какому герою принадлежит фраза: 'Мне нужны... витаминки'?", "", "Undying", "Pudge", "Snapfire", "Venomancer", 4, "", ""));

        questions.Add(new Questions("Какому герою принадлежит фраза: 'Я б тебя еще пристрелила, да по трупам стрелять - скука'?", "", "Windranger", "Hoodwink", "Mirana", "Drow Ranger", 1, "", ""));

        questions.Add(new Questions("Какому герою принадлежит фраза: 'Вы погибнете в пожаре'?", "", "Oracle", "Warlock", "Lina", "Ember Spirit", 5, "", ""));

        questions.Add(new Questions("Какому герою принадлежит фраза?", "", "Bristleback", "Batrider", "Tusk", "Centaur Warrunner", 1, "", "Bristle_attack_22"));

        questions.Add(new Questions("У какого из этих героев базовая скорость меньше 300 единиц?", "", "Dark Seer", "Axe", "Snapfire", "Phantom Assassin", 2, "", ""));

        questions.Add(new Questions("Сколько в доте героев, у которых оружием является лук?", "Clinkz, Drow Ranger, Medusa, Mirana, Windranger. У Hoodwink арбалет", "5", "2", "3", "4", 4, "", ""));

        questions.Add(new Questions("С какой минуты начинают выпадать предметы 1 тира?", "", "7", "5", "6", "8", 1, "", ""));

        questions.Add(new Questions("С какой минуты начинают выпадать предметы 2 тира?", "", "17", "10", "12", "15", 1, "", ""));

        questions.Add(new Questions("С какой минуты начинают выпадать предметы 3 тира?", "", "27", "20", "37", "30", 1, "", ""));

        questions.Add(new Questions("С какой минуты начинают выпадать предметы 4 тира?", "", "37", "47", "40", "30", 1, "", ""));

        questions.Add(new Questions("С какой минуты начинают выпадать предметы 5 тира?", "", "60", "50", "67", "57", 1, "", ""));

        questions.Add(new Questions("Какая стоимость у Divine Rapier?", "", "6000", "6200", "6300", "6100", 1, "Divine_Rapier", ""));

        questions.Add(new Questions("Сколько золота в минуту дает Philosopher's Stone?", "", "70", "80", "90", "60", 2, "Philosopher's_Stone", ""));

        questions.Add(new Questions("Что не входит в состав Crimson Guard?", "", "Buckler", "Vanguard", "Hell of Iron Will", "Рецепт", 3, "Crimson_guard", ""));

        questions.Add(new Questions("Сколько уклонения даёт Scurry у Hoodwink на 4 уровне прокачки?", "", "32%", "40%", "36%", "28%", 3, "", ""));

        questions.Add(new Questions("Какому из этих предметов Tinker не может сбросить перезарядку способностью Rearm?", "", "Tango(не свой)", "Bloodstone", "Guardian Greaves", "Gleipnir", 2, "Tinker4", ""));

        questions.Add(new Questions("Mars бог - ...", "", "Войны", "Грома", "Огня", "Земли", 1, "", ""));

        questions.Add(new Questions("Какой тип урона имеет спосоность Diabolic Edict у Leshrac?", "", "Физический", "Чистый", "Магический", "Осадный", 2, "Leshrac2", ""));

        questions.Add(new Questions("Сколько предметов дают вампиризм?", "Morbid Mask, Vladmir's Offering, Mask of Madness, Satanic, Possessed Mask, Paladin Sword", "6", "3", "4", "5", 4, "", ""));

        questions.Add(new Questions("На каком уровне героя, курьер становится летающим?", "", "4", "5", "6", "7", 2, "", ""));

        questions.Add(new Questions("Сколько секунд длится первый телепорт к Outpost?", "", "6", "3", "4", "5", 3, "", ""));

        questions.Add(new Questions("Что нельзя выкопать с помощью Trusty Shovel?", "", "Clarity", "Healing Salve", "Kobold", "Town Portal Scroll", 1, "Trusty_Shovel", ""));

        questions.Add(new Questions("Какой из этих героев продержит дольше в сайленсе на 30 уровне, без талантов?", "", "Doom", "Drow Ranger", "Bloodseeker", "Silencer", 1, "", ""));

        questions.Add(new Questions("У какого героя процент замедления больше, чем у других на 4 уровне прокачки, без талантов?", "Flux - 50%, Dual Breath - 40%, Stone Gaze - 35%, Ignite - 26%", "Arc Warden - Flux", "Ogre Magi - Ignite", "Medusa – Stone Gaze", "Jakiro - Dual Breath", 1, "", ""));

        questions.Add(new Questions("У какого героя стан длится дольше всех на последнем уровне прокачки, без талантов?", "Magnus - 3.75, Lion - 2.6, Nyx - 2.6, Vengeful Spirit - 1.7", "Magnus", "Lion", "Nyx Assasin", "Vengeful Spirit", 2, "", ""));

        questions.Add(new Questions("При убийстве какого героя Legion Commander произносит эту фразу", "", "Medusa", "Night Stalker", "Faceless Void", "Bane", 4, "Legion_commander", "Legcom_rival_06"));

        questions.Add(new Questions("Какому герою принадлежит этот звук?", "", "Weaver", "Venomancer", "Medusa", "Razor", 1, "", "Weaver_projectile_launch1"));

        questions.Add(new Questions("Какому герою принадлежит этот звук?", "", "Templar Assassin", "Arc Warden", "Tinker", "Disruptor", 1, "", "Templar_Assassin_projectile_launch2"));

        questions.Add(new Questions("Какому герою принадлежит этот звук?", "", "Oracle", "Dark Willow", "Disruptor", "Invoker", 1, "", "Fate's_Edict_cast"));

        questions.Add(new Questions("", "", "Windranger", "Drow Ranger", "Razor", "Shadow Fiend", 1, "Windranger_talant", ""));

        questions.Add(new Questions("", "", "Dark Willow", "Rubick", "Arc Warden", "Crystal Maiden", 1, "Dark_Willow_Talant", ""));

        questions.Add(new Questions("", "", "Invoker", "Tinker", "Ancient Apparition", "Morphling", 1, "Invoker_talant", ""));

        questions.Add(new Questions("", "", "Lich", "Lion", "Rubick", "Treant Protector", 1, "Lich_talant", ""));

        questions.Add(new Questions("", "", "Drow Ranger", "Windranger", "Shadow Fiend", "Viper", 1, "Drow_ranger_talant", ""));

        questions.Add(new Questions("Какая из этих способностей не имеет чистый урон?", "", "Phoenix - Sun Ray", "Invoker - Sun Strike", "Timbersaw - Whirling Death", "Tinker - Laser", 1, "", ""));

        questions.Add(new Questions("Какой предмет дает 100% попадание по герою, даже сквозь миссы?", "", "Bloodthorn", "Monkey King Bar", "Javelin", "Silver Edge", 1, "", ""));

        questions.Add(new Questions("Сколько всего рун в игре?", "Arcane, Bounty, Double Damage, Haste, Illusion, Invisibility, Regeneration", "7", "6", "8", "5", 3, "", ""));

        questions.Add(new Questions("Что из этого не дает предмет Butterfly?", "", "+30 к скорости передвижения", "+30 к ловкости", "+30 к скорости атаки", "+35% к уклонению", 1, "", ""));

        questions.Add(new Questions("Какова длительность перезарядки Black King Bar?", "", "70", "60", "90", "50", 2, "", ""));

        questions.Add(new Questions("Какова длительность Observer Ward?", "", "6", "7", "5", "8", 2, "", ""));

        questions.Add(new Questions("Какова длительность Sentry Ward?", "", "8", "6", "7", "5", 4, "", ""));

        questions.Add(new Questions("Какая из этих способностей проходит сквозь невосприимчивость к магии?", "", "Death Prophet - Exorcism", "Monkey King - Boundless Strike", "Sniper - Assassinate", "Alchemist - Acid Spray", 1, "", ""));

        questions.Add(new Questions("Сколько шариков-духов летает вокруг Io от способности Spirits?", "", "5", "6", "4", "7", 1, "", ""));

        questions.Add(new Questions("", "", "Beast Master", "Bristleback", "Axe", "Tusk", 2, "Beast_Master_talant", ""));

        questions.Add(new Questions("", "", "Phantom Assasin", "Chaos Knight", "Weaver", "Bloodseeker", 1, "Phantom_Assasin_Talant", ""));

        questions.Add(new Questions("У кого из этих героев больше всего активных способностей c Aghanim's Scepter и Aghanim's Shard", "Terrorblade: 1 - Reflection, 2 - Conjure Image, 3 - Metamorphosis, 4 - Demon Zeal, 5 - Terror Wave, 6 - Sunder. У остальных по 5 активных способностей", "Terrorblade", "Ogre Magi", "Tinker", "Zeus", 1, "", ""));

        questions.Add(new Questions("Кому принадлежит этот звук?", "", "Snapfire", "Sniper", "Gyrocopter", "Techies", 1, "", "Weapons_hero_snapfire_attack"));

        questions.Add(new Questions("При убийстве какого героя Arc Warden произносит эту фразу", "", "Keeper of the Light", "Io", "Phoenix", "Zeus", 3, "Arc_Warden", "Arcwar_rival_07"));

        questions.Add(new Questions("Кого Templar Assasin называет хозяином?", "", "Void Spirit", "Abbadon", "Terrorblade", "Anti Mage", 2, "", ""));

        questions.Add(new Questions("Кто научил Huskar'а лечению?", "", "Dazzle", "Witch Doctor", "Его отец", "Он сам научился", 1, "", ""));

        questions.Add(new Questions("Какую из этих способностей нельзя задоджить с помощью Blink Dagger?", "", "Alchemist - Unstable Concotion", "Viper - Viper Strike", "Ogre Magi - Ignite ", "Naga Siren - Ensnare", 3, "Blink_Dagger", ""));

        questions.Add(new Questions("Если Oracle даст False Promise союзнику с 10 hp, и в него нажмет Ice Blast Ancient Apparition, что произойдет?", "", "Союзник умрет моментально", "Союзник не получит эффект Ice Blast", "Союзник умрет по окончанию ульты Oracle", "", 4, "Oracle4", ""));

        questions.Add(new Questions("Сколько нужно нанести ударов своему Observer Ward с полным здоровьем для уничтожения?", "", "6", "10", "5", "2", 3, "Observer_Ward", ""));

        questions.Add(new Questions("Какой тип урона блокирует Frost Shield у Lich?", "", "Физический", "Магический", "Чистый", "Любой", 1, "Lich2", ""));

        questions.Add(new Questions("Какую из этих способностей нельзя задоджить с помощью Blink Dagger?", "", "Spectre - Spectral Dagger", "Sniper - Assassinate", "Sniper - Assassinate", "Skywrath Mage - Concussive Shot", 1, "Blink_Dagger", ""));

        questions.Add(new Questions("Чем можно убить Troll Warlord под действием Battle Trance?", "", "Axe - Culling Blade", "Necrophos - Reaper's Scythe", "Ancient Apparition - Ice Blast", "Lion - Finger of Death", 1, "", ""));

        questions.Add(new Questions("Какую из этих способностей не снимает Lotus Orb?", "", "Shadow Demon - Demonic Purge", "Underlord - Pit of Malice", "Doom - Infernal Blade", "Pugna - Decrepify", 1, "Lotus_Orb", ""));

        questions.Add(new Questions("Что может вывести вас из смоков?", "", "Башня", "Варды", "Иллюзия", "Аванпост", 1, "Smoke_of_Deceit", ""));

        questions.Add(new Questions("Какой из этих героев не сможет восполнить себе здоровье своими способностями под Ice Blast?", "", "Abaddon", "Terrorblade", "Weaver", "Все не смогут", 3, "Ancient_Apparition4", ""));

        questions.Add(new Questions("Во что не может превратиться Monkey King при использовании Mischiff?", "", "В Mango", "В Cheese", "В Tango", "В Clarity", 1, "Monkey_King5", ""));

        questions.Add(new Questions("Какой дизарм нельзя спуржить?", "", "Heaven's Halberd", "Invoker - Deafening Blast", "Pangolier - Lucky Shot", "Oracle - Fate's Edict", 2, "", ""));

        questions.Add(new Questions("Какое свойство не имеет некрономикон воин 3-го уровня?", "", "Ускоренное передвижение", "Раскрытие невидимых существ и вардов", "Наносит урон убийце некрономикона воина", "Выжигает ману", 2, "Necronomicon_Warrior", ""));

        questions.Add(new Questions("Какой из этих предметов не увеличивает реген маны?", "", "Gleipnir", "Silver Edge", "Necronomicon", "Octarine Core", 3, "", ""));

        questions.Add(new Questions("Что дает Aghanim's Scepter Magnus'у?", "", "Shockwave's возвращаются обратно", "Уменьшение перезарядки и расход маны у Skewer", "Уменьшение перезарядки Reverse Polarity", "Делает Empower аурой", 1, "Aghanim's_Scepter", ""));

        questions.Add(new Questions("Какое из этих заклинаний Rubick не может украсть?", "", "Табличку у Techies", "Borrowed Time у Abaddon", "Phantom Rush у Phantom Lancer", "Bulwark у Mars", 2, "Rubic4", ""));

        questions.Add(new Questions("Какое из этих заклинаний Rubick может украсть?", "", "Bulwark у Mars", "Invoke у Invoker", "Morph у Morphling", "Табличку у Techies", 3, "Rubic4", ""));

        questions.Add(new Questions("Сколько максимально душ может быть у Shadow Fiend с Aghanim's Scepter?", "", "25", "20", "36", "48", 2, "Necromastery", ""));

        questions.Add(new Questions("Если Legion Commander нажмет Duel в Anti-Mage под Counterspell, что произойдет?", "", "Counterspell заблокирует и отразит Duel", "Будет двойная Duel", "Duel не состоится", "", 2, "Legion_commander4", ""));

        questions.Add(new Questions("Сколько базовое передвижение у Hoodwink?", "", "320", "330", "310", "300", 2, "Hoodwink", ""));

        questions.Add(new Questions("Сколько существует предметов способных увеличить дальность атаки?", "Ballista, Broom Handle, Dragon Lance, Enchanted Quiver, Grove Bow, Hurricane Pike, Telescope", "7", "6", "5", "4", 5, "", ""));

        questions.Add(new Questions("Какой из этих предметов не дает дополнительную дальность атаки?", "", "Seer Stone", "Telescope", "Enchanted Quiver", "Ballista", 1, "", ""));

        questions.Add(new Questions("Сколько вражеской брони снимает Desolator?", "", "7", "5", "8", "6", 1, "Desolator", ""));

        questions.Add(new Questions("Какой радиус действия имеет Light Strike Arrey у Lina?", "", "225", "300", "250", "275", 3, "Lina2", ""));

        questions.Add(new Questions("Одежда какого героя раньше была красной?", "", "Silencer", "Omniknight", "Invoker", "Axe", 2, "", ""));

        questions.Add(new Questions("Сколько маны стоит Cuilling Blade 3-го уровня у Axe?", "", "180", "120", "210", "150", 2, "Axe4", ""));

        questions.Add(new Questions("Сколько разновидностей малых лагерей нейтральных крипов существует в игре?", "Лагерь кобольдов, Лагерь холмовых троллей, Лагерь холмовых троллей и кобольда-бригадира, Лагерь воул-убийц, Лагерь призраков, Лагерь гарпий", "6", "7", "4", "5", 3, "", ""));

        questions.Add(new Questions("Сколько урона добавляет Quelling Blade героям дальнего боя?", "", "6", "5", "7", "8", 3, "Quelling_Blade", ""));

        questions.Add(new Questions("Какое из этих существ имеет больше всего здоровья?", "", "Satyr Tormenter", "Wildwing Ripper", "Hellbear Smasher", "Mud Golem", 4, "", ""));

        questions.Add(new Questions("На какой минуте игры Slam у Roshan достигает максимальной мощи?", "", "100", "60", "80", "120", 4, "Slam_Roshan", ""));

        questions.Add(new Questions("Какой из этих объектов способен блочить спауны лесных крипов?", "", "Juggernaut - Healing Ward", "Animal Courier", "Techies - Stasis Trap", "Void Spirit - Astral Spirit", 2, "", ""));

        questions.Add(new Questions("Сколько героев имеет способность в названии которой есть слово Remnant?", "Earph Spirit - Stone Remnant, Storm Spirit - Static Remnant, Ember Spirit - Fire Remnant, Void Spirit - Aether Remnant", "4", "3", "2", "1", 2, "", ""));

        questions.Add(new Questions("Сколько секунд длится минимальное время возраждения курьера?", "", "67", "60", "57", "50", 5, "Animal_Courier", ""));

        questions.Add(new Questions("В каком году появилась функция скана мини-карты?", "", "2016", "2017", "2014", "2015", 3, "Scan", ""));

        questions.Add(new Questions("Какой герой появился в игре во время Nemesis Assasin Event?", "", "Oracle", "Monkey King", "Terrorblade", "Arc Warden", 2, "Nemesis_Assasin_Event", ""));

        questions.Add(new Questions("Какой из этих предметов появился в игре раньше других?", "", "Glimmer Cape", "Blight Stone", "Faerie Fire", "Tome of Knowledge", 3, "", ""));

        questions.Add(new Questions("У какого из этих героев наивысшая скорость полёта снаряда?", "Ancient Apparation - 1250, Io - 1200, Tinker - 900, Oracle - 900", "Ancient Apparation", "Tinker", "Oracle", "Io", 1, "", ""));

        questions.Add(new Questions("Сколько здоровья восстанавливает Tango, если съесть обычное дерево?", "", "112", "100", "124", "136", 3, "Tango", ""));

        questions.Add(new Questions("Сколько процентов маны и здоровья в секунду восстанавливает руна регенерации?", "", "6", "15", "9", "12", 3, "Regeneration", ""));

        questions.Add(new Questions("Кто был главным врагом врагом на последнем уровне ивента Dark Moon?", "", "Invoker", "Wraith King", "Aghanim", "Roshan", 3, "", ""));

        questions.Add(new Questions("Сколько золота получит игрок, продав Cheese?", "", "500", "600", "550", "450", 1, "Cheese", ""));

        questions.Add(new Questions("Какая из этих атак не обладает эффектом True Strike по умолчанию?", "", "Witch Doctoc - Death Ward", "Pangolier - Swashbuckle", "Phantom Assassin - Stifling Dagger", "Monkey King - Boundless Strike", 2, "", ""));

        questions.Add(new Questions("У какой из этих способностей наибольший манакост?", "", "Ursa - Earthshock", "Kunkka - X Marks the Spot", "Dragon Knight - Elder Dragon Form", "Templar Assasin - Meld", 2, "", ""));

        questions.Add(new Questions("Что из этого появилось в игре раньше?", "", "Манго", "Таланты", "Руна волшебства", "Скан карты", 2, "", ""));

        questions.Add(new Questions("Кто входит в инвиз быстрее остальных?", "Clinkz - 0.6, Sand King - 0.7, Riki - 2, Mirana", "Clinkz", "Sand King", "Riki", "Mirana", 2, "", ""));

        questions.Add(new Questions("Сколько здоровья и маны восстанавливает фонтан в секунду?", "", "5% HP и 6% MP", "5% HP и 5% MP", "6% HP и 6% MP", "6% HP и 5% MP", 4, "Rejuvenation_Aura", ""));

        questions.Add(new Questions("Сколько золото даёт первая руна богатства всей команде?", "", "200", "250", "150", "100", 2, "Bounty_Rune", ""));

        questions.Add(new Questions("Этот герой был искусным манипулятором. Выполняя прихоти правителей и волшебников, он делал вид, что подчиняется им. На самом деле он захватывал их разум и личность, а потом превращал в своих марионеток. Герой создал целый культ имени себя, но его труды были уничтожены. Кто этот коварный манипулятор?", "", "Shadow Demon", "Nyx Assassin", "Terrorblade", "Bane", 2, "", ""));

        questions.Add(new Questions("Их ненавидели все. Там, где проходили они, оставались только разрушенные города и множество бедствий. Однако их это нисколько не смущало, ведь им было важно только то, как далеко они смогут продвинуться в своих изысканиях. О ком речь?", "Речь про трех подрывников Techies, которые уничтожили Устричную бухту и город Тотерин. Все это, конечно, не со зла, а от любви к науке и взрывам.", "Techies", "Arc Warden", "Chaos Knight", "Meepo", 2, "", ""));

        questions.Add(new Questions("Этот герой был помощником странствующего мошенника-чудотворца. Вместе они за небольшую плату показывали крестьянам «магию». К несчастью, однажды обманутые клиенты убили мошенника-чудотворца, но сами пали от рук нашего героя, который в этот раз продемонстрировал уже настоящую магию. Так о ком речь?", "Речь про Shadow Shaman, который долгое время использовал магию только для заработка и увеселения толпы в деревнях. После смерти своего старшего наставника он стал более воинственным.", "Shadow Shaman", "Rubick", "Lion", "Invoker", 2, "", ""));

        questions.Add(new Questions("В мире людей этого персонажа почитали, боялись, а некоторые даже боготворили. Но вот в своем царстве у героя были проблемы с авторитетом. Чтобы стать могущественнее и бросить вызов своим соперникам, герой заключил договор с Ногхом и забрал его силы. Под каким же именем мы знаем это персонажа в Dota 2?", "Queen of Pain боялась, что теряет авторитет в темном царстве, в то время как ее соперники только набирают силы. Чтобы исправить ситуацию, Акаша обратилась за помощью к некогда могущественному принцу Ногху, которого она подчинила. Он передал ей свою силу, чтобы та защитила его королевство.", "Queen of Pain", "Night Stalker", "Leshrac", "Enigma", 4, "", ""));

        questions.Add(new Questions("Когда-то этот персонаж был частью могучей армии, но теперь он странствует по миру только в компании своего верного летописца, который документирует каждый смачный удар и совершённый подвиг героя. Так кто же из персонажей «Доты» любит посражаться и при этом хочет запечатлеть свои поступки в истории?", "Axe был могучим воином и мечтал стать предводителем армии Красного Тумана, но добиться своей цели не смог. Поэтому Axe решил искать славу в приключениях, а все его подвиги записывал молодой эльф. В один из походов он смог в одиночку захватить крепость и победить чародея, который обменялся телами с Axe.", "Axe", "Phantom Lancer", "Silencer", "Tusk", 1, "", ""));

        questions.Add(new Questions("До 15 лет наш герой был рабом в Квейне. Все изменилось после того, как вражеская армия захватила город и предложила мирным жителям присоединиться к войску. Он согласился, хотя первое время вместо сражений он был чернорабочим. Как же зовут сейчас этого персонажа?", "Такой незавидный путь прошла Legion Commander, прежде чем стать одним из сильнейших воинов Легиона. Об этом она рассказала своему сослуживцу перед одним из сражений, которое было описано в комиксе «Острие копья».", "Legion Commander", "Sven", "Omniknight", "Dragon Knight", 3, "", ""));

        questions.Add(new Questions("Одна из воительниц «Доты» была наследницей королевской династии, но отреклась от престола и посвятила свою жизнь служению богине. Помимо участия в войне Древних, она охраняет Серебристые Леса от чужаков. О ком речь?", "Это описание Mirana в самой Dota 2.", "Mirana", "Luna", "Windranger", "Enchantress", 2, "", ""));

        questions.Add(new Questions("Ротунд’йер был обычным монахом, который сумел добиться поста кардинала. На этой должности он обманом забирал владения у богатых. Однажды это заметили и его сместили с должности, отправив на смертельно опасное задание. Но наш герой, к удивлению многих, не умер. Как же его звали?", "Necrophos продвинулся по карьерной лестнице во время эпидемии чумы. Пока другие священники лечили людей, он занимался темными делами. Позже его осудили и в наказание отправили присматривать за чумными пациентами. К тому моменту Necrophos уже пропитался заразой и сам был ходячей болезнью.", "Necrophos", "Abaddon", "Omniknight", "Dazzle", 2, "", ""));

        questions.Add(new Questions("Один из героев «Доты» провел 500 лет в заточении по воле древних богов. Получив прощение, он рвался вернуться на войну, но перед этим выступал на гладиаторской арене. О ком же речь?", "Monkey King из-за своего характера был заточен на 500 лет. О том, как после своего освобождения герой зарабатывал на бойцовской арене, можно прочесть в комиксе «Новый путь».", "Monkey King", "Juggernaut", "Mars", "Troll Warlord", 3, "", ""));

        questions.Add(new Questions("Zeus был лишен части своей божественной силы. В описании персонажа в «Доте» сказано, что всему виной его ревнивая жена. Однако кое-кто вернул Zeus частицу его силы, чтобы тот был готов к великой битве с древними богами. Кто же сделал этот подарок Zeus?", "В комиксе «Осколок Луны» Arc Warden рассказал Zeus о своем плане уничтожить божества, чтобы закончить войну. В качестве доказательства своих слов и серьезных намерений Arc Warden вернул Zeus частицу его силы.", "Arc Warden", "Invoker", "Skywrath Mage", "Rubick", 2, "", ""));

        questions.Add(new Questions("Большинство персонажей «Доты» воинственны, а вот наш герой, несмотря на грозный вид, не любит пустого насилия и гордо называет себя художником. А еще у него большая коллекция бесценных рукописей, которыми он не прочь поделиться. Так о ком же речь?", "Об этом Valve рассказала в комиксе «Новые соседи». В нем Crystal Maiden познакомилась с Winter Wyvern в ее ледяной крепости, наполненной бесценными книгами. Дракониха даже отдала волшебнице несколько своих реликвий, чтобы возместить ущерб за съеденный скот", "Winter Wyvern", "Dazzle", "Keeper of The Light", "Grimstroke", 4, "", ""));

        questions.Add(new Questions("Алхимик Седрик призвал с помощью ритуала одного из могущественных персонажей Dota 2, чтобы обрести его силу, однако в итоге сам пал от его магии и превратился в прислужника. Кого же призвал Седрик?", "Enigma сам разбросал по миру книги с заклинанием своего призыва, чтобы подчинять алхимиков, жаждущих новых знаний. Бедный Седрик в итоге превратился в одного из эйдолонов. Об этом Valve рассказала в комиксе «Ритуал призыва»", "Enigma", "Doom", "Shadow Demon", "Shadow Fiend", 3, "", ""));

        questions.Add(new Questions("Сколько предметов в доте имеют механику уменьшения кулдауна?", "Octarine Core, Quickening Charm, Spell Prism, Telescope. Refresher имеет механику сброса кулдауна", "4", "3", "2", "1", 3, "", ""));

        questions.Add(new Questions("Сколько способностей в доте имеют механику уменьшения кулдауна?", "Nyx Assassin - Burrow, Keeper of the Light - Chakra Magic, Dazzle - Bad Juju. Rearm имеет механику сброса кулдауна", "3", "2", "4", "1", 4, "", ""));

        questions.Add(new Questions("Сколько предметов в доте имеют механику сброса кулдауна?", "Ex Machina, Refresher Orb, Refresher Shard и Shadow Amulet при применении на себя", "4", "3", "2", "1", 5, "", ""));

        questions.Add(new Questions("Сколько способностей в доте имеют механику сброса кулдауна?", "Axe - Culling Blade, Grimstroke - Phantom's Embrace, Invoker - Invoke, Phoenix - Supernova, Tinker - Rearm, Clockwerk - Overclocking", "6", "4", "3", "5", 5, "", ""));

        questions.Add(new Questions("У кого из этих героев 4 пальца на одной руке?", "", "Sniper", "Slardar", "Pudge", "Ursa", 3, "", ""));

        questions.Add(new Questions("У кого из этих героев 3 пальца на одной руке?", "", "Meppo", "Enigma", "Weaver", "Morphling", 2, "", ""));

        questions.Add(new Questions("Какой сейчас патч в игре?", "", "7.28b", "7.28", "7.28a", "7.28c", 1, "", ""));

        questions.Add(new Questions("Что из этого не является механикой привязки?", "", "Ember Spirit - Searing Chains", "Grimstroke - Soulbind", "Puck - Dream Coil", "Slark - Pounce", 2, "", ""));

        questions.Add(new Questions("Что из этого не является источником ослепления?", "", "Arc Warden - Magnetic Field", "Radiance - Burn", "Broodmother - Incapacitating Bite", "Troll Warlord - Whirling Axes (Melee)", 2, "", ""));

        questions.Add(new Questions("Что из этого не является источником оцепенения?", "", "Medusa - Stone Gaze", "Techies - Stasis Trap", "Oracle - Fortune's End", "Underlord - Pit of Malice", 1, "", ""));

        questions.Add(new Questions("Какая способность не отключает пасивные способности?", "", "Doom - Infernal Blade", "Nyx Assassin - Vendetta", "Shadow Demon - Demonic Purge", "Viper - Nethertoxin", 2, "", ""));

        questions.Add(new Questions("Какая из способностей не обезоруживает заклинателя?", "Lucky shot обезаруживает врага, а не заклинателя.", "Pangolier - Lucky shot", "Batrider - Flaming Lasso", "Huskar - Life Break", "Timbersaw - Timber Chain", 3, "", ""));

        questions.Add(new Questions("На сколько процентов Echo Sabre замедляет скорость передвижения?", "", "100%", "80%", "60%", "40%", 3, "Echo_Sabre", ""));

        questions.Add(new Questions("Какая стандартная длина у Meat Hook?", "", "1300", "1200", "1100", "1400", 4, "Pudge1", ""));

        questions.Add(new Questions("С помощью какой способности нельзя убить курьера?", "", "Bloodseeker - Rapture", "Enigma - Black Hole", "Pudge - Dismember", "Bane - Fiend's Grip", 2, "", ""));

        questions.Add(new Questions("При убийстве какого героя Crystal Maiden произносит эту фразу?", "", "Tusk", "Ancient Apparition", "Juggernaut", "Lina", 1, "Crystal_maiden", "Cm_rival_19"));

        questions.Add(new Questions("При встречи какой девушки Keeper of the Light говорит эту фразу?", "", "Vengeful Spirit", "Lina", "Crystal Maiden", "Windranger", 5, "Keeper_of_the_light", "Keep_ally_11"));

        questions.Add(new Questions("При убийстве какого героя Shadow Shaman произносит эту фразу?", "", "Witch Doctor", "Dazzle", "Lion", "Oracle", 2, "Shadow_shaman", "Shad_killspecial_01"));

        questions.Add(new Questions("При убийстве какого героя Wraith King произносит эту фразу?", "", "Terrorblade", "Undying", "Necrophos", "Monkey King", 4, "Wraith_King", "Wraith_rival_24"));

        questions.Add(new Questions("При убийстве какого героя Pudge произносит эту фразу?", "", "Windranger", "Morphling", "Enigma", "Io", 3, "Pudge", "Pud_rival_06"));

        questions.Add(new Questions("При встречи какого героя Slark произносит эту фразу?", "", "Slardar", "Venomancer", "Medusa", "Naga Siren", 1, "Slark", "Slark_ally_03"));

        questions.Add(new Questions("При встречи какого героя Kunkka произносит эту фразу?", "", "Tidehunter", "Slardar", "Slark", "Viper", 3, "Kunkka", "Kunk_ally_02"));

        questions.Add(new Questions("При встречи какого героя Luna произносит эту фразу?", "", "Vengeful Spirit", "Storm Spirit", "Ember Spirit", "Spirit Breaker", 1, "Luna", "Luna_ally_01"));

        questions.Add(new Questions("При встречи какого героя Nyx произносит эту фразу?", "", "Lion", "Doom", "Warlock", "Shadow Demon", 4, "Nyx", "Nyx_ally_05"));

        questions.Add(new Questions("Какому герою принадлежит эта фраза?", "Эту редкую фразу Omniknight произносит когда вы делаете 5 быстрых нажатий на него", "Omniknight", "Juggernaut", "Sven", "Phantom Lancer", 1, "", "Omni_rare_01"));

        questions.Add(new Questions("Какому герою принадлежит эта фраза?", "Эту фразу произносит Earth Spirit когда заполняет Bottle", "Earth Spirit", "Omniknight", "Sven", "Dragon Knight", 2, "", "Earthspi_bottle_01"));

        questions.Add(new Questions("Какому герою принадлежит эта фраза?", "Эту редкую фразу Centaur Warrunner произносит когда вы делаете 5 быстрых нажатий на него", "Centaur Warrunner", "Elder Titan", "Dragon Knight", "Sven", 2, "", "Cent_ally_19"));

        questions.Add(new Questions("Какому герою принадлежит эта фраза?", "Эту редкую фразу Spirit Breaker произносит когда вы делаете 5 быстрых нажатий на него", "Spirit Breaker", "Elder Titan", "Magnus", "Outworld Destroyer", 2, "", "Spir_rare_05"));

        questions.Add(new Questions("Что делает Lycan когда произносит эту фразу?", "Эту фразу Lycan произносит с 5% вероятностью, когда берет руну иллюзий", "Берет руну иллюзий", "В окружении 2 и больше союзников", "Применяет Summon Wolves", "Нажимает Helm of the Dominator", 3, "Lycan", "Lycan_illus_02"));

        questions.Add(new Questions("Что делает Witch Doctor когда произносит эту фразу?", "", "Берет Aegis of the Immortal", "Получает убийство", "Умирает", "Покупает Divine Rapier", 3, "Witch_Doctor", "Wdoc_immort_02"));

        questions.Add(new Questions("Какую способность использует Invoker когда произноит эту фразу?", "", "Ice Wall", "Forge Spirit", "Deafening Blast", "Tornado", 2, "Invoker", "Invo_ability_icewall_03"));

        questions.Add(new Questions("Какую способность использует Dazzle когда произноит эту фразу?", "", "Shallow Grave", "Poison Touch", "Shadow Wave", "", 3, "Dazzle", "Dazz_ability_shalgrave_01"));

        questions.Add(new Questions("Что делает Clockwerk когда произносит эту фразу?", "", "Возрождается", "Встреча Timbersaw", "Насмешка", "Уникальная реплика при нажатии", 3, "Clockwerk", "Ratt_respawn_18"));

        questions.Add(new Questions("Какому герою принадлежит эта фраза?", "", "Pudge", "Wraith King", "Slardar", "Lifestealer", 1, "", "Pud_death_06"));

        questions.Add(new Questions("Сколько раз можно прокачать сферу у инвокера?", "", "13", "14", "12", "11", 2, "Invoker3", ""));

        questions.Add(new Questions("На сколько секунд оглушает способность Horn Toss у Magnus с Aghanim's Shard?", "", "0.25", "0", "0.5", "0.75", 2, "Magnus4", ""));

        questions.Add(new Questions("Сколько брони снижает Orb of Destruction?", "", "4", "3", "5", "6", 2, "Orb_of_Destruction", ""));

        questions.Add(new Questions("Какому предмету пренадлежит этот звук?", "", "Shadow Amulet", "Shadow Blade", "Silver Edge", "Glimmer Cape", 2, "", "Shadow_Amulet"));

        questions.Add(new Questions("Сколько урона получают иллюзии дальнего боя с Manta Style?", "", "400%", "350%", "300%", "250%", 2, "Manta_Style", ""));

        questions.Add(new Questions("Какому предмету пренадлежит этот звук?", "", "Diffusal Blade", "Gleipnir", "Mjollnir", "Maelstrom", 2, "", "Diffusal_Blade"));

        questions.Add(new Questions("Сколько урона получают иллюзии ближнего боя с Manta Style?", "", "350%", "400%", "300%", "250%", 2, "Manta_Style", ""));

        questions.Add(new Questions(Items.gleipnir, new List<Item> { Items.euls_Scepter_of_Divinity, Items.mystic_Staff, Items.reaver }, 2));

        questions.Add(new Questions("Сколько урона даёт Satanic?", "", "55", "45", "65", "75", 3, "Satanic", ""));

        questions.Add(new Questions("Сколько скелетов максимально может создать Wraith King с помощью способности Vampiric Spirit?", "", "14", "8", "10", "16", 3, "Wraith_King2", ""));

        questions.Add(new Questions("Сколько здоровья даёт сила?", "", "20", "25", "15", "10", 1, "", ""));

        questions.Add(new Questions("Сколько брони даёт ловкость?", "", "0,16", "0,2", "0,1", "0,14", 3, "", ""));

        questions.Add(new Questions("Сколько опыта получает клон Meepo?", "", "30%", "40%", "50%", "20%", 3, "Meepo4", ""));

        questions.Add(new Questions("Сколько опыта получает клон Meepo если рядом с ним есть два союзника?", "", "10%", "40%", "30%", "20%", 4, "Meepo4", ""));

        questions.Add(new Questions("На каком расстоянии даётся опыт?", "", "1500", "1800", "2100", "1200", 4, "", ""));

        questions.Add(new Questions("Множитель опыта у Midas?", "", "210%", "180%", "110%", "160%", 3, "Hand_of_Midas", ""));

        questions.Add(new Questions("У какого из этих героев талант на 15-м уровне даёт больше всего брони?", "", "Warlock", "Earth Spirit", "Earthshaker", "Mars", 4, "", ""));

        questions.Add(new Questions("Сколько урона блокируют герои ближнего боя с 50% вероятностью?", "", "16", "14", "12", "10", 3, "", ""));

        questions.Add(new Questions("Какой из этих крипов имеет самое большое сопротивление магии?", "Eidolon - 50%, Familiar - 35%, Undying Zombie - 33%, Spiderling - 25%", "Enigma - Eidolon", "Broodmother - Spiderling", "Visage - Familiar", "Undying Zombie", 5, "", ""));

        questions.Add(new Questions("У какого из этих героев талант на 10-м уровне даёт больше всего сопротивления магии?", "Bane - 15%, Vengeful Spirit - 12%, Enchantress - 12%, Death Prophet - 12%", "Bane", "Enchantress", "Vengeful Spirit", "Death Prophet", 4, "", ""));

        questions.Add(new Questions("Что делает War Drums Aura у Ancient Rumblehide?", "", "Аура увеличения точности на 40%", "Аура увеличения скорости атаки на 40", "Аура увеличения скорости передвижения на 15%", "Аура сопротивления урона на 10%", 5, "War_Drums_Aura_Ancient_Thunderhide", ""));

        questions.Add(new Questions("Какая регенерация здоровья у Казармы мечников?", "", "5", "2", "8", "11", 2, "", ""));

        questions.Add(new Questions("Что из этого даёт больше обзора ночью на последнем уровне?", "", "Lycan - Shapeshift", "Batrider - Firefly", "Monkey King - Tree Dance", "Winter Wyvern - Arctic Burn", 3, "", ""));

        questions.Add(new Questions("Время жизни деревца от Iron Branch?", "", "20 сек", "25 сек", "30 сек", "15 сек", 3, "Branches", ""));

        questions.Add(new Questions("Какая дальность обзора башен днём?", "", "1900", "1800", "1700", "1600", 5, "", ""));

        questions.Add(new Questions("Сколько регенерации даёт 1-я башня?", "", "1", "2", "3", "4", 3, "Tower_Protection", ""));

        questions.Add(new Questions("К какой игре фраза является отсылкой (Eng: War Never Changes)?", "«Война никогда не меняется» (War Never Changes) — фраза, звучащая во всех вступительных роликах серии игр Fallout, ставшая своего рода «визитной карточкой» игры", "Fallout", "Total War", "Call of Duty", "Battlefield", 4, "Legion_commander", "Legcom_rare_02"));

        questions.Add(new Questions("К какому фильму фраза Omniknight является отсылкой (Eng: I chose wisely)?", "", "Indiana Jones", "The Choice", "The Lord of the Rings", "Back to the Future", 3, "", "Omni_purch_02"));

        questions.Add(new Questions("Сколько защиты даёт 1-я башня?", "", "1", "2", "3", "4", 4, "Tower_Protection", ""));

        questions.Add(new Questions("При убийстве Lina и Ember Spirit Arc Warden может сказать редкую фразу, к чему эта отсылка (Eng: Flame is no match for the Arc)?", "Flame is no match for the Arc. — «Пламя не может тягаться с электричеством.» является отсылкой к мультсериалу «Аватар» где некоторые маги огня могли стать мастерами молний", "Avatar", "Black Lightning", "Thor", "Tesla", 4, "Arc_Warden", "Arcwar_rival_14"));

        questions.Add(new Questions("Сколько предметов в доте дают уклонение?", "Butterfly, Heaven's Halberd, Talisman of Evasion, Trickster Cloak, Elven Tunic", "5", "3", "6", "4", 4, "", ""));

        questions.Add(new Questions("Сколько способностей дают уклонение?", "Arc Warden - Magnetic Field, Brewmaster - Drunken Brawler, Clinkz - Strafe, Phantom Assassin - Blur, Windranger - Windrun", "5", "4", "3", "2", 4, "", ""));

        questions.Add(new Questions("Сколько способностей в доте дают эффет ослепления с талантами (Дают шанс промаха врагу)?", "Broodmother - Incapacitating Bite, Drow Ranger - Gust, Keeper of the Light - Blinding Light, Riki - Smoke Screen, Sand King - Sand Storm, Tinker - Laser, Troll Warlord - Whirling Axes (Melee)", "7", "6", "5", "4", 5, "", ""));

        questions.Add(new Questions("Сколько золото дадут если убить Phoenix Sun?", "Помимо золото за убийство героя, сверху дадут 20 золота", "20", "0", "40", "60", 5, "Phoenix4", ""));

        questions.Add(new Questions("У кого больше средний урон с удара по башне на 1-ой минуте?", "Крип-мечник - 14.7 урона, Крип-маг - 7.05, Гигантский волк - 9.3, Штормовая гарпия - 10.05", "Крип-мечник", "Крип-маг", "Штормовая гарпия", "Гигантский волк", 4, "", ""));

        questions.Add(new Questions("На какой минуте все линии получают +1 крипа мечника?", "", "15", "10", "20", "25", 3, "", ""));

        questions.Add(new Questions("Сколько сеток может поставить Broodmother с аганимом?", "", "18", "20", "16", "14", 4, "Broodmother2", ""));

        questions.Add(new Questions("Сколько урона наносит Walrus Kick у Tusk?", "", "350", "0", "250", "150", 3, "Tusk5", ""));

        questions.Add(new Questions("Сколько оглушений совершает Malefice у Enigma без таланта?", "", "3", "4", "5", "2", 2, "Enigma1", ""));

        questions.Add(new Questions("Сколько максимально физического урона Dazzle может нанести с помощью Shadow Wave на 4 уровне без талантов?", "7 целей по 140 урона", "980", "840", "700", "560", 4, "Dazzle3", ""));

        questions.Add(new Questions("После какого события Legion Commander стала понимать язык Озкавош?", "", "После получения арканы", "После того как заключила сделку с Shadow Fiend", "После того как ее проклял Doom ", "После службы на Shadow Demon", 2, "", ""));

        questions.Add(new Questions("Чей ультимейт в приоритете на смену суток в игре?", "", "Phoenix", "Luna", "Night Stalker", "Тот, который будет первым закастован", 4, "", ""));

        questions.Add(new Questions("Какая длительность страха у способности Terrorblade - Terror Wave?", "", "2.5", "3.75", "3.5", "2.75", 3, "Terror5", ""));

        questions.Add(new Questions("Сколько урона Slark наносит себе способностью Dark Pact на 4 уровне без талантов?", "", "150", "200", "100", "250", 3, "Slark1", ""));

        questions.Add(new Questions("На сколько снижает восстановление здоровья Envenomed Weapon у Vhoul Assassin?", "", "35%", "5%", "25%", "15%", 5, "Vhoul_Assassin1", ""));

        questions.Add(new Questions("Сколько требуется атак не-героя чтобы разрушить Undying - Tombstone на последнем уровне с талантом?", "", "52", "44", "36", "28", 5, "Undying3", ""));

        questions.Add(new Questions("Сколько сопротивления магии даёт Demolish у Spirit Bear на 4-м уровне прокачки?", "", "40%", "33%", "26%", "0%", 3, "Demolish", ""));

        questions.Add(new Questions("Сколько магического урона наносит суммарно способность Battery Assault у Clockwerk на 1 уровне прокачки?", "", "320", "260", "200", "140", 4, "Clockwerk1", ""));

        questions.Add(new Questions("Единственный кто называет Ursa по имени?", "", "Lone Druid", "Roshan", "Treant Protector", "Crystal Maiden", 2, "", ""));

        questions.Add(new Questions("Сколько сопротивления эффектам даёт Elder Dragon Form у Dragon Knight на последнем уровне прокачки с аганимом?", "", "0%", "15%", "25%", "40%", 5, "Dragon_kngiht4", ""));

        questions.Add(new Questions("При убийстве какого героя Storm Spirit произносит эту фразу?", "", "Tinker", "Nature's Prophet", "Enchantress", "Enigma", 4, "Storm_spirit", "Stormspirit_rival_06"));

        questions.Add(new Questions("При убийстве какого героя Sniper произносит эту фразу?", "", "Clinkz", "Snapfire", "Techies", "Techies", 5, "Sniper", "Snip_kill_arrow_03"));

        questions.Add(new Questions("При убийстве какого героя Razor произносит эту фразу?", "", "Jakiro", "Storm Spirit", "Kunkka", "Gyrocopter", 5, "Razor", "Raz_rival_15"));

        questions.Add(new Questions("При убийстве какого героя Windranger произносит эту фразу?", "", "Drow Ranger", "Medusa", "Mirana", "", 1, "Windranger", "Wind_rivaltrax_04"));

        questions.Add(new Questions("При убийстве какого героя Skywrath Mage произносит эту фразу?", "", "Viper", "Pudge", "Venomancer", "Necrophos", 5, "Skywrath_mage", "Drag_rival_10"));

        questions.Add(new Questions("При встречи какого героя Doom произносит эту фразу?", "", "Shadow Fiend", "Shadow Demon", "Terrorblade", "Legion Commander", 2, "Doom", "Doom_ally_02"));

        questions.Add(new Questions("При встречи какого героя Sven произносит эту фразу?", "", "Chen", "Omniknight", "Chaos Knight", "Dragon Knight", 3, "Sven", "Sven_rivals_general_07"));

        questions.Add(new Questions("При встречи какого героя Gyrocopter произносит эту фразу?", "", "Outworld Destroyer", "Enigma", "Underlord", "Shadow Demon", 2, "Gyrocopter", "Gyro_ally_05"));

        questions.Add(new Questions("При убийстве какого героя Underlord произносит эту фразу?", "", "Shadow Demon", "Enigma", "Outworld Destroyer", "Rubick", 4, "Underlord", "Abys_rival_09"));

        questions.Add(new Questions("При убийстве какого героя Ember Spirit произносит эту фразу?", "", "Abaddon", "Wraith King", "Phoenix", "Pugna", 5, "", "Embr_rival_04"));

        questions.Add(new Questions("Кто произносит этот звук?", "", "Mirana", "Luna", "Crystal Maiden", "Windranger", 1, "", "Mir_rare_01"));

        questions.Add(new Questions("Что происходит когда Winter Wyvern говори эту фразу?", "", "Возрождается", "Встреча Mars", "Уникальная фраза при нажатии", "Серия из 3-х убийств", 4, "Winter_wyvern", "Winwyv_respawn_03"));

        questions.Add(new Questions("На сколько процентов Overload у Storm Spirit замедляет скорость передвижения?", "", "80%", "100%", "60%", "40%", 3, "Storm_spirit3", ""));

        questions.Add(new Questions("Сколько Take Aim у Sniper даёт дальности атаки на 4 уровне с талантом?", "", "500", "600", "400", "700", 4, "Sniper3", ""));

        questions.Add(new Questions("На сколько секунд замедляет Plasma Field у Razor?", "", "1.5 сек", "1 сек", "2 сек", "0.5 сек", 2, "Razor1", ""));

        questions.Add(new Questions("На сколько Focus Fire у Windranger снижает урон на 3 уровне без таланта?", "", "30%", "20%", "50%", "40%", 2, "Windranger4", ""));

        questions.Add(new Questions("Сколько маны стоит Arcane Bolt у Skywrath Mage?", "", "90", "80", "70", "100", 2, "Skywrath_mage1", ""));

        questions.Add(new Questions("Какой порог здоровья для добивания союзника под действием Doom, Shadow Strike, Venomous Gale?", "", "25%", "10%", "15%", "20?", 4, "", ""));

        questions.Add(new Questions("При каком пороге можно заденаить Supernove у Phoenix?", "", "50%", "30%", "10%", "70%", 5, "Phoenix4", ""));

        questions.Add(new Questions("О какой способности Doom речь 'Люцифер рад поделиться клеймом, полученным после изгнания'?", "", "Infernal Blade", "Devour", "Scorched Earth", "Doom", 3, "Doom", ""));

        questions.Add(new Questions("Какой интервал атак у Автоматической Турили у Gyrocopter с Aghanim's Scepter?", "", "1.2 сек", "1.1 сек", "1.0 сек", "0.9 сек", 3, "Gyrocopter", ""));

        questions.Add(new Questions("Какое число волн у способности Firestorm у Underlord без таланта?", "", "6", "5", "4", "3", 3, "Underlord1", ""));

        questions.Add(new Questions("Через сколько минут с момента поднятия исчезнет Aegis?", "", "5", "6", "8", "7", 1, "Aegis", ""));

        questions.Add(new Questions("Сколько скорости атаки даёт Blitz Knuckles?", "", "35", "45", "15", "25", 1, "Blitz_Knuckles", ""));

        questions.Add(new Questions("Сколько брони снижает Stygian Desolator?", "", "10", "9", "8", "7", 2, "Stygian_Desolator", ""));

        questions.Add(new Questions("Сколько сопротивление магии даёт Bloodstone?", "", "0%", "5%", "10%", "15%", 2, "Bloodstone", ""));

        questions.Add(new Questions("Какой кулдаун у Shadow Amulet при применении его на союзника?", "", "7 сек", "10 сек", "4 сек", "0 сек", 3, "Shadow_Amulet", ""));

        questions.Add(new Questions("Как Zeus оказался на битве древних?", "Гере надоело смотреть на измены своего мужа со смертными, а потому она изгнала его на битву древних.", "Его отправила жена", "Он пришел доказать своё величие", "Ему нужно было отыскать друга", "Отправился в помощь древним богам", 1, "Zeus", ""));

        questions.Add(new Questions("Кто такой Roshan?", "Однажды он решил обокрасть торговца, но в мире Dota 2 они охраняются богами, когда торговец его поймал, Roshan Решил убить его, за что Боги прокляли его и превратили в чудовище", "Проклятый вор", "Страж охраняющий врата демонов", "Древний монстр", "Чудовище созданное Аганимом", 1, "Roshan", ""));

        questions.Add(new Questions("Почему битва древних никогда не закончится?", "Dota 2 — мир, который состоит из мультивселенных, а каждая игра — это лишь один из исходов, и чтобы закончить противостояние, должны пасть оба древних.", "Из-за мультивселенных", "Потому, что мир Dota 2 проклят", "Потому, что Enigma не хочет отпускать героев", "Чудовище созданное Аганимом", 2, "", ""));

        questions.Add(new Questions("Чьим питомцем раньше был Viper?", "Об этом нам говорит сам Pugna, когда убивает вайпера 'Ах, Вайпер, мой бывший питомец.'", "Pugna", "Necrophos", "Pudge", "Venomancer", 1, "Viper", ""));

        questions.Add(new Questions("Какая из этих способностей не даёт 100% попадание по врагу?", "", "Drow Ranger - Marksmanship", "Pangolier - Swashbuckle", "Tusk - Walrus PUNCH!", "Monkey King - Boundless Strike", 2, "", ""));

        questions.Add(new Questions("Какая из этих способностей нанесёт больше урона по одной цели на последнем уровне без талантов и без Aghanim's Scepter?", "Scorched Earth - 900, Blade Fury - 800, Magnetize - 720, Supernova - 720", "Doom - Scorched Earth", "Earth Spirit - Magnetize", "Phoenix - Supernova", "Juggernaut - Blade Fury", 3, "", ""));

        questions.Add(new Questions("Какая из этих способностей даёт больше дальность атаки без талантов?", "Tree Grab - 350, Lil' Shredder - 300, Psi Blades - 240, Chilling Touch - 240", "Tiny - Tree Grab", "Templar Assassin - Psi Blades", "Snapfire - Lil' Shredder", "Ancient Apparition - Chilling Touch", 4, "", ""));

        questions.Add(new Questions("Какой из этих предметов можно использовать курьером?", "", "Smoke of Deceit", "Wards", "Dagon", "Dust", 1, "Animal_Courier", ""));

        questions.Add(new Questions("Что из этого не дает Null Talisman?", "Null Talisman даёт +2 к силе", "+3 к силе", "+3% к урону от заклинаний", "+0,6 к восстановлению маны", "+5 к интеллекту", 1, "Null_Talisman", ""));

        questions.Add(new Questions("Сколько длится глиф на крипах?", "", "4 сек.", "5 сек.", "6 сек.", "3 сек.", 3, "Glyph_of_Fortification", ""));

        questions.Add(new Questions("Сколько длится глиф на строениях?", "", "7 сек.", "6 сек.", "5 сек.", "8 сек.", 4, "Glyph_of_Fortification", ""));

        questions.Add(new Questions("Какой из этих предментов дороже?", "", "Все стоят одинаково", "Overwhelming Blink", "Arcane Blink", "Swift Blink", 1, "Arcane_Blink", ""));

        questions.Add(new Questions("Что из этого не даёт Falcon Blade?", "", "25 к скорости атаки", "175 к зоровья", "1.8 к восстановлению маны", "10 к урону", 1, "Falcon_Blade", ""));

        questions.Add(new Questions(Items.spirit_Vessel, new List<Item> { Items.wind_Lace, }, 1));

        questions.Add(new Questions(Items.necronomicon_1, new List<Item> { Items.staff_of_Wizardry, Items.belt_of_Strength, Items.helm_of_Iron_Will }, 3));

        questions.Add(new Questions(Items.aeon_Disk, new List<Item> { Items.point_Booster }, 1));

        questions.Add(new Questions(Items.veil_of_Discord, new List<Item> { Items.helm_of_Iron_Will, Items.null_Talisman, Items.robe_of_the_Magi }, 2));

        questions.Add(new Questions(Items.assault_Cuirass, new List<Item> { Items.chainmail }, 1));

        questions.Add(new Questions(Items.battle_Fury, new List<Item> { Items.mithril_Hammer, Items.demon_Edge, Items.recipe }, 1));

        questions.Add(new Questions(Items.euls_Scepter_of_Divinity, new List<Item> { Items.sages_Mask, Items.robe_of_the_Magi }, 1));

        questions.Add(new Questions(Items.wind_Waker, new List<Item> { Items.staff_of_Wizardry, Items.robe_of_the_Magi, Items.void_Stone, Items.rod_of_Atos, Items.maelstrom }, 1));

        questions.Add(new Questions(Items.rod_of_Atos, new List<Item> { Items.bracer, Items.staff_of_Wizardry, Items.vitality_Booste }, 1));

        questions.Add(new Questions(Items.crimson_guard, new List<Item> { Items.buckler_Inactive, Items.platemail, Items.chainmail }, 1));

        questions.Add(new Questions(Items.heavens_Halberd, new List<Item> { Items.belt_of_Strength, Items.ogre_Axe }, 1));

        questions.Add(new Questions(Items.mjollnir, new List<Item> { Items.javelin, Items.gloves_of_Haste, Items.mithril_Hammer }, 1));

        questions.Add(new Questions(Items.lotus_Orb, new List<Item> { Items.ring_of_Health, Items.void_Stone, Items.vitality_Booste, Items.point_Booster, Items.recipe, Items.chainmail }, 3));

        questions.Add(new Questions(Items.desolator, new List<Item> { Items.recipe, Items.claymore, Items.claymore, Items.broadsword, Items.broadsword }, 1));

        questions.Add(new Questions(Items.aghanims_Scepter, new List<Item> { Items.recipe, Items.vitality_Booste, Items.energy_Booster }, 1));

        questions.Add(new Questions(Items.echo_Sabre, new List<Item> { Items.belt_of_Strength, Items.heavens_Halberd, Items.quarterstaff, Items.sages_Mask, Items.robe_of_the_Magi, Items.gloves_of_Haste }, 1));

        questions.Add(new Questions(Items.urn_of_Shadows, new List<Item> { Items.gauntlets_of_Strength, Items.gauntlets_of_Strength, Items.infused_Raindrops, Items.iron_Branch, Items.magic_Stick }, 2));

        questions.Add(new Questions(Items.helm_of_the_Dominator_2, new List<Item> { Items.helm_of_Iron_Will, Items.platemail, Items.headdress, Items.soul_Booster, Items.reaver, Items.mystic_Staff, Items.eaglesong }, 1));

        questions.Add(new Questions(Items.helm_of_the_Dominator, new List<Item> { Items.broadsword, Items.gloves_of_Haste, Items.headdress, Items.ring_of_Health, Items.morbid_Mask }, 3));

        questions.Add(new Questions(Items.solar_Crest, new List<Item> { Items.talisman_of_Evasion, Items.blight_Stone }, 3));

        questions.Add(new Questions(Items.medallion_of_Courage, new List<Item> { Items.recipe, Items.circlet, Items.crown, Items.ring_of_Protection, Items.ring_of_Regen, Items.wind_Lace }, 2));

        questions.Add(new Questions(Items.armlet_of_Mordiggian, new List<Item> { Items.quarterstaff, Items.chainmail, Items.bracer, Items.ring_of_Health, Items.platemail, Items.crown }, 1));

        questions.Add(new Questions(Items.dagon, new List<Item> { Items.belt_of_Strength, Items.band_of_Elvenskin, Items.robe_of_the_Magi, Items.null_Talisman, Items.mystic_Staff, Items.circlet }, 1));

        questions.Add(new Questions(Items.guardian_Greaves, new List<Item> { Items.platemail, Items.chainmail, Items.headdress, Items.energy_Booster }, 1));

        questions.Add(new Questions(Items.mekansm, new List<Item> { Items.buckler_Inactive, Items.ring_of_Health, Items.ring_of_Protection }, 2));

        questions.Add(new Questions(Items.glimmer_Cape, new List<Item> { Items.gloves_of_Haste, Items.shadow_Blade, Items.hood_of_Defiance, Items.headdress, Items.sages_Mask, Items.chainmail, Items.voodoo_Mask }, 1));

        questions.Add(new Questions(Items.drum_of_Endurance, new List<Item> { Items.crown, Items.sages_Mask, Items.gloves_of_Haste, Items.bracer, Items.band_of_Elvenskin, Items.buckler_Inactive, Items.blitz_Knuckles }, 4));

        questions.Add(new Questions(Items.satanic, new List<Item> { Items.recipe, Items.mithril_Hammer, Items.helm_of_the_Dominator, Items.broadsword, Items.eaglesong, Items.mystic_Staff }, 1));

        questions.Add(new Questions(Items.heart_of_Tarrasque, new List<Item> { Items.ogre_Axe, Items.belt_of_Strength, Items.point_Booster, Items.ring_of_Tarrasque }, 1));

        questions.Add(new Questions(Items.silver_Edge, new List<Item> { Items.echo_Sabre, Items.ultimate_Orb, Items.shadow_Amulet, Items.sange, Items.yasha }, 1));

        questions.Add(new Questions(Items.shadow_Blade, new List<Item> { Items.claymore, Items.quarterstaff, Items.mithril_Hammer, Items.gloves_of_Haste, Items.recipe }, 1));

        questions.Add(new Questions(Items.octarine_Core, new List<Item> { Items.voodoo_Mask, Items.mystic_Staff, Items.energy_Booster, Items.kaya, Items.recipe }, 1));

        questions.Add(new Questions(Items.bloodstone, new List<Item> { Items.perseverance, Items.soul_Ring, Items.recipe }, 1));

        questions.Add(new Questions(Items.holy_Locket, new List<Item> { Items.ring_of_Tarrasque, Items.holy_Locket, Items.magic_Stick, Items.void_Stone }, 5));

        questions.Add(new Questions(Items.hood_of_Defiance, new List<Item> { Items.ring_of_Regen, Items.helm_of_Iron_Will, Items.voodoo_Mask, Items.recipe }, 1));

        questions.Add(new Questions(Items.eternal_Shroud, new List<Item> { Items.ring_of_Health, Items.cloak, Items.kaya }, 2));

        questions.Add(new Questions(Items.vladmirs_Offering, new List<Item> { Items.headdress, Items.gloves_of_Haste, Items.circlet, Items.ring_of_Regen, Items.ring_of_Protection, Items.crown }, 3));

        questions.Add(new Questions(Items.mage_Slaye, new List<Item> { Items.claymore, Items.mithril_Hammer, Items.ogre_Axe, Items.blitz_Knuckles, Items.chainmail, Items.robe_of_the_Magi, Items.staff_of_Wizardry }, 5));

        questions.Add(new Questions(Items.witch_Blade, new List<Item> { Items.claymore, Items.mithril_Hammer, Items.ogre_Axe, Items.staff_of_Wizardry, Items.blade_of_Alacrity, Items.broadsword, Items.cloak, Items.javelin }, 5));

        questions.Add(new Questions(Items.falcon_Blade, new List<Item> { Items.gloves_of_Haste, Items.ring_of_Regen, Items.ring_of_Protection, Items.crown, Items.chainmail, Items.circlet, Items.broadsword, Items.wind_Lace }, 3));

        questions.Add(new Questions("Какого типа урона от атаки не существует?", "Типы урона дают примущество над разными типами брони. Примеры: Обычный - Крип мечник, Проникающий - Крип-маг, Герой - Рошан", "Режущий", "Обычный", "Проникающий", "Герой", 2, "", ""));

        questions.Add(new Questions("У кого из этих героев меньше всего активных способностей c Aghanim's Scepter и Aghanim's Shard", "Timbersaw: 1 - Whirling Death, 2 - Timber Chain, 3 - Second Chakram, 4 - Flamethrower, 5 - Chakram. У остальных по 6 ативных способностей", "Timbersaw", "Kunkka", "Clockwerk", "Grimstroke", 2, "", ""));

        questions.Add(new Questions("У кого из этих героев меньше всего активных способностей c Aghanim's Scepter и Aghanim's Shard", "Chen: 1 - Penitence, 2 - Holy Persuasion, 3 - Divine Favor, 4 - Hand of God. У остальных по 5 ативных способностей", "Chen", "Magnus", "Jakiro", "Templar Assassin", 2, "", ""));

        questions.Add(new Questions("У кого из этих героев больше всего активных способностей c Aghanim's Scepter и Aghanim's Shard", "Spectre: 1 - Spectral Dagger, 2 - Dispersion, 3 - Reality, 4 - Shadow Step, 5 - Haunt. У остальных по 4 ативных способности", "Spectre", "Alchemist", "Dark Seer", "Anti-Mage", 2, "", ""));

        questions.Add(new Questions("Какую из этих способностей не снимает Lotus Orb?", "", "Grimstroke - Phantom's Embrace", "Brewmaster - Cinder Brew", "Pangolier - Lucky Shot", "Queen of Pain - Shadow Strike", 2, "Lotus_Orb", ""));

        questions.Add(new Questions("Какую из этих способностей снимает Lotus Orb?", "", "Dark Willow - Terrorize", "Bane - Fiend's Grip", "Invoker - Deafening Blast", "Pudge - Dismember", 2, "Lotus_Orb", ""));

        questions.Add(new Questions("Что может вывести вас из смоков?", "", "Копия Arc Warden", "Oracle способностью Fortune's End", "Трон", "Spirit Bear у Lone Druid", 3, "Smoke_of_Deceit", ""));

        questions.Add(new Questions("Во чтоz` не может превратиться Monkey King при использовании Mischiff?", "Если Рошан мертв, то в его логове всегда превращает в Roshan. В логове после 1-ой смерти превращает в Aegis of the Immortal, 2-ой Cheese, 3-ей Refresher Shard", "Aghanim's Blessing", "Aegis of the Immortal", "Roshan", "Refresher Shard", 1, "Monkey_King5", ""));

        questions.Add(new Questions("С помощью какой способности нельзя убить курьера?", "", "Omniknight - Purification", "Bristleback - Quill Spray", "Beastmaster - Primel Roar", "Spirit Breaker - Nether Strike", 2, "", ""));

        questions.Add(new Questions("Сколько урона наносит способность Tidal Wave у Kunkka?", "", "225", "275", "325", "375", 3, "Tidal_Wave", ""));

        return questions;
    }
}
