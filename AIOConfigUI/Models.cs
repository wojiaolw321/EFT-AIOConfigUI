using System.ComponentModel;
namespace AIOConfigUI
{
    public class Models
    {
       
    }
 
    public class hideout
    {
        public bool FastHideoutConstruction { get; set; }
        public bool FastHideoutProduction { get; set; }
        public bool FastScavCase { get; set; }
        public bool ScavCasePriceReducer { get; set; }
    }
    public class items
    {
        public bool AllExaminedItems { get; set; }
        public bool WeightOptions { get; set; }
        public int WeightChanger { get; set; }
        public bool MoreStack { get; set; }
        public int MaxStackAmount { get; set; }
        public bool EquipRigsWithArmors { get; set; }
        public bool ForceMoneyStack { get; set; }
        public int ForcedMoneyStack { get; set; }
        public bool RemoveSecureContainerFilters { get; set; }
        public bool RemoveBackpacksRestrictions { get; set; }
        public bool RemoveContainersRestrictions { get; set; }
        public bool InRaidModdable { get; set; }
        public bool IncreaseLootExp { get; set; }
        public int LootExpPerc { get; set; }
        public bool IncreaseExamineExp { get; set; }
        public int ExamineExpPerc { get; set; }
    }


    public class player
    {
        public bool RemoveScavTimer { get; set; }
        public bool ChangeSkillProgressionMultiplier { get; set; }
        public int SkillMultiplier { get; set; }
        public bool ChangeWeaponSkillMultiplier { get; set; }
        public int WeaponSkillMultiplier { get; set; }
        public bool DisableSkillFatigue { get; set; }
        public float SkillMinEffectiveness { get; set; }
        public float SkillFatiguePerPoint { get; set; }
        public float SkillFreshEffectiveness { get; set; }
        public int SkillFreshPoints { get; set; }
        public int SkillPointsBeforeFatigue { get; set; }
        public int SkillFatigueReset { get; set; }
        public bool ChangeMaxStamina { get; set; }
        public int NewMaxStamina { get; set; }
        public bool UnlimitedStamina { get; set; }
        public bool RemoveInRaidsRestrictions { get; set; }
        public bool AllSkillsMaster { get; set; }

    }

    public class traders
    {
        public bool AllQuestsAvailable { get; set; }

        public bool AllClothesFree { get; set; }

        public bool AllClotheForEverySide { get; set; }

        public bool ChangeFleaMarketLvl { get; set; }

        public int FleaMarketMiniLvl { get; set; }

        public bool IncreaseTherapistHealingPrice { get; set; }
        public int TherapistNewHealingPrice { get; set; }
        public bool MaxInsuranceStorageTime { get; set; }

        public bool AllTraders4Stars { get; set; }
    }
    public class raids
    {
        public bool ChangeLootMultipiers { get; set; }
        public bool NoExtractsRestrictions { get; set; }
        public bool AllExtractionsAvailable { get; set; }
        public bool IncreasedBossChance { get; set; }
        public bool ExtendedRaid { get; set; }
        public bool RemoveLabKeycard { get; set; }
    }

    public class other
    {
        public bool HideWarningMessage { get; set; }
    }

}
