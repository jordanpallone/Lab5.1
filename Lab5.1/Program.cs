using System;
using System.Collections.Generic;

namespace Lab5._1
{
    class GameCharacter
    {
        private string CharName;
        private int CharStrength;
        private int CharIntelligence;

        public GameCharacter(string name, int strength, int smarts)
        {
            CharName = name;
            CharStrength = strength;
            CharIntelligence = smarts;
        }

        public string pubName
        {
            get
            {
                return CharName;
            }
            set
            {
                CharName = value;
            }
        }

        public int pubStrength
        {
            get
            {
                return CharStrength;
            }
            set
            {
                CharStrength = value;
            }
        }

        public int pubIntelli
        {
            get
            {
                return CharIntelligence;
            }
            set
            {
                CharIntelligence = value;
            }
        }

        public virtual string Play()
        {
            return $"{CharName} (intelligence: {CharIntelligence}, strength: {CharStrength})";
        }
    }

    class Warrior : GameCharacter
    {
        private string WeaponType;

        public Warrior(string name, int strength, int smarts, string weapon) :base(name, strength, smarts)
        {
            pubName = name;
            pubStrength = strength;
            pubIntelli = smarts;
            WeaponType = weapon;
        }

        public override string Play()
        {
            return $"{pubName} (intelligence: {pubIntelli}, strength: {pubStrength}) {WeaponType}";
        }

        public string pubWeapon
        {
            get { return WeaponType; }
            set { WeaponType = value; }
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        private int MagicalEnergy;

        public MagicUsingCharacter(string name, int strength, int smarts, int magEng) : base(name, strength, smarts)
        {
            pubName = name;
            pubStrength = strength;
            pubIntelli = smarts;
            MagicalEnergy = magEng;
        }

        public override string Play()
        {
            return $"{pubName} (intelligence: {pubIntelli}, strength: {pubStrength}, magic: {MagicalEnergy})";
        }

        public int pubMagic
        {
            get { return MagicalEnergy; }
            set { MagicalEnergy = value; }
        }
    }

    class Wizard : MagicUsingCharacter
    {
        private int SpellNumber;

        public Wizard(string name, int strength, int smarts, int magEng, int spNum) : base(name, strength, smarts, magEng)
        {
            pubName = name;
            pubStrength = strength;
            pubIntelli = smarts;
            pubMagic = magEng;
            SpellNumber = spNum;
        }

        public override string Play()
        {
            return $"{pubName} (intelligence: {pubIntelli}, strength: {pubStrength}, magic: {pubMagic}) {SpellNumber} spells";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(new Warrior("Warrior One", 5, 7, "Weapon One"));
            characters.Add(new Warrior("Warrior Two", 1, 2, "Weapon Two"));
            characters.Add(new Warrior("Warrior Three", 3, 4, "Weapon Three"));
            characters.Add(new Wizard("Wizard One", 8, 9, 3, 2));

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine(character.Play());
                
            }
        }
    }
}
