using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace BattleBuddy
{
    class JsonHandler
    {
        public List<Monster> ImportMonster(string file)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"json\", file);
            string json = File.ReadAllText(path);
            var jsonDeserial = JsonConvert.DeserializeObject<bestiary>(json);
            List<Monster> monsters = new List<Monster>();
            monsters = jsonDeserial.monster;
            return monsters;
        }
        public List<Player> ImportPlayer(string file)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"json\", file);
            string json = File.ReadAllText(path);
            var jsonDeserial = JsonConvert.DeserializeObject<PlayerList>(json);
            List<Player> players = new List<Player>();
            players = jsonDeserial.player;
            return players;
        }
    }

    public class bestiary
    {
        public List<Monster> monster { get; set; }
    }

    public class PlayerList
    {
        public List<Player> player { get; set; }
    }

    public class Creature
    {
        public string name { get; set; }
        public int ac { get; set; }
        public int hp { get; set; }
        public int speed { get; set; }
        public int str { get; set; }
        public int dex { get; set; }
        public int con { get; set; }
        public int @int { get; set; }
        public int wis { get; set; }
        public int cha { get; set; }
    }
    public class Player : Creature
    {
        public string race { get; set; }
        public string @class { get; set; }
    }

    public class Monster : Creature
    {
        public string source { get; set; }
        public int page { get; set; }
        public List<OtherSource> otherSources { get; set; }
        public string size { get; set; }
        public object type { get; set; }
        public List<string> alignment { get; set; }
        public List<object> ac { get; set; }
        public new Hp hp { get; set; }
        public new Speed speed { get; set; }
        public int str { get; set; }
        public int dex { get; set; }
        public int con { get; set; }
        public int @int { get; set; }
        public int wis { get; set; }
        public int cha { get; set; }
        public Skill skill { get; set; }
        public int passive { get; set; }
        public List<string> languages { get; set; }
        public string cr { get; set; }
        public List<Trait> trait { get; set; }
        public List<Action> action { get; set; }
        public List<string> environment { get; set; }
        public bool hasToken { get; set; }
        public SoundClip soundClip { get; set; }
        public List<string> languageTags { get; set; }
        public List<string> damageTags { get; set; }
        public List<string> miscTags { get; set; }
        public bool hasFluff { get; set; }
        public bool hasFluffImages { get; set; }
        public bool? srd { get; set; }
        public Save save { get; set; }
        public List<string> senses { get; set; }
        public List<Legendary> legendary { get; set; }
        public LegendaryGroup legendaryGroup { get; set; }
        public List<string> traitTags { get; set; }
        public List<string> senseTags { get; set; }
        public List<string> actionTags { get; set; }
        public List<string> conditionInflict { get; set; }
        public List<string> conditionInflictLegendary { get; set; }
        public List<object> immune { get; set; }
        public List<Spellcasting> spellcasting { get; set; }
        public List<string> spellcastingTags { get; set; }
        public string group { get; set; }
        public string dragonCastingColor { get; set; }
        public List<object> resist { get; set; }
        public List<string> conditionImmune { get; set; }
        public List<string> conditionInflictSpell { get; set; }
        public List<Variant> variant { get; set; }
        public List<AltArt> altArt { get; set; }
        public List<string> vulnerable { get; set; }
        public List<Reaction> reaction { get; set; }
        public bool? familiar { get; set; }
    }
    public class OtherSource
    {
        public string source { get; set; }
    }

    public class Hp
    {
        public int average { get; set; }
        public string formula { get; set; }
    }

    public class Speed
    {
        public int walk { get; set; }
        public object fly { get; set; }
        public int? swim { get; set; }
        public int? climb { get; set; }
        public int? burrow { get; set; }
        public bool? canHover { get; set; }
    }

    public class Skill
    {
        public string perception { get; set; }
        public string history { get; set; }
        public string stealth { get; set; }
        public string medicine { get; set; }
        public string religion { get; set; }
        public string persuasion { get; set; }
        public string insight { get; set; }
        public string deception { get; set; }
        public string arcana { get; set; }
        public string athletics { get; set; }
        public string acrobatics { get; set; }
    }

    public class Trait
    {
        public string name { get; set; }
        public List<string> entries { get; set; }
    }

    public class Action
    {
        public string name { get; set; }
        public List<object> entries { get; set; }
    }

    public class SoundClip
    {
        public string type { get; set; }
        public string path { get; set; }
    }

    public class Save
    {
        public string con { get; set; }
        public string @int { get; set; }
        public string wis { get; set; }
        public string dex { get; set; }
        public string cha { get; set; }
        public string str { get; set; }
    }

    public class Legendary
    {
        public string name { get; set; }
        public List<string> entries { get; set; }
    }

    public class LegendaryGroup
    {
        public string name { get; set; }
        public string source { get; set; }
    }

    public class _0
    {
        public List<string> spells { get; set; }
    }

    public class _1
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class _2
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class _3
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class _4
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class _5
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class _6
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class _7
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class _8
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class _9
    {
        public int slots { get; set; }
        public List<string> spells { get; set; }
    }

    public class Spells
    {
        public _0 _0 { get; set; }
        public _1 _1 { get; set; }
        public _2 _2 { get; set; }
        public _3 _3 { get; set; }
        public _4 _4 { get; set; }
        public _5 _5 { get; set; }
        public _6 _6 { get; set; }
        public _7 _7 { get; set; }
        public _8 _8 { get; set; }
        public _9 _9 { get; set; }
    }

    public class Daily
    {
        public List<string> _1e { get; set; }
        public List<string> _2e { get; set; }
    }

    public class Spellcasting
    {
        public string name { get; set; }
        public List<string> headerEntries { get; set; }
        public Spells spells { get; set; }
        public string ability { get; set; }
        public List<string> will { get; set; }
        public List<string> hidden { get; set; }
        public List<string> footerEntries { get; set; }
        public Daily daily { get; set; }
    }

    public class Variant
    {
        public string type { get; set; }
        public string name { get; set; }
        public List<object> entries { get; set; }
    }

    public class AltArt
    {
        public string name { get; set; }
        public string source { get; set; }
        public int? page { get; set; }
    }

    public class Reaction
    {
        public string name { get; set; }
        public List<string> entries { get; set; }
    }
}
