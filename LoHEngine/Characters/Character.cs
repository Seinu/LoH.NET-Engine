﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
    {
        public int AiAttack, AiDefend, AiSpell;
        public int EquipPow;


        // Order is MaxHealth, CurrHealth, MaxMana, CurrMana, MaxStam, CurrStam, Str, Int, Dex, Speed, Luck, Defense, Magic Defense, Will*/
namespace LoHEngine.Characters
{
    public class Character
    {
        protected Random rand;
        protected int AiAttack, AiDefend, AiSpell;
        public double MaxHealth, MaxMana, MaxStamina;
        public double CurrentHealth, CurrentMana, CurrentStamina;
        public string Equip;
        public int EquipPow;
        //Bows use Str and Dex for Power Calc
        public int Str, Int, Will; // Str and Int are essentially the same except one is for magic one for melee. Will for defense calcs? Will not used currently
        public int Dex, Speed; // Dex is dexerity the ability to control and aim etc. Speed is how fast you can manipulate an attack object or skill.
        public int Luck; // Luck is broadly how lucky you are in RNG such as crit rate, drop rate, collect rate, etc
        public int Resistance; // also known as magic defense
        public int Defense;
        
        
        public double Evade; // Evade is a combination of Dex, Luck, and Speed and how well you can evade an attack
        public double Power; // Power is end calculation of all damage stats
        
        public int Experience, Level, Gold, BankGold, SkillPoint;
        public int MinDamage, MaxDamage;
        public int GoldDropMin, GoldDropMax;
        public string Username, Password;
        public bool isAlive, isGM;
        protected int spellOne, spellTwo, spellThree;
        public bool fled;
        public string Inventory, Bank, Mail;
        public string SkillsKnown, SkillsNotKnown;
        public string CompletedQuests, CurrentQuest;
        public string Date_Create, DateLastLogin;
        public string pos_x, pos_y;
        public bool defending, increaseAttack;
        public string Identifier;
        public int RebirthCount, lvlTotal, Age;
        public bool isFreeRB, isCorrectAge;
        public int HPGrowth, MPGrowth, StamGrowth, StrGrowth, IntGrowth, LuckGrowth, SpeedGrowth, DexGrowth, DefGrowth, ResGrowth, WillGrowth;
        public double CritRate;



        public Character()
        {
            spellOne = 0;
            spellTwo = 0;
            spellThree = 0;
            defending = false;
            increaseAttack = false;
            fled = false;
        }

        public virtual string AI()
        {
            string choice = "";
            return choice;
        }

        public virtual string SpellAI()
        {
            string choice = "";
            return choice;
        }
    }
}
