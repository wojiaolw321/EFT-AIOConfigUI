using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System;


namespace AIOConfigUI
{
    public class ModelsService
    {

    }
    public class ConfigFile
    {
        public string Path { get; set; }

        public JObject JConfig { get; set; }
        public void ReadJsonFromFile()
        {
            this.Path = Directory.GetCurrentDirectory() + @"\config\config.json";
            if (File.Exists(Path))
            {
                StreamReader reader = File.OpenText(Path);
                JObject jConfig = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                reader.Close();
                this.JConfig = jConfig;
            }
            else
            {
                Sunny.UI.UIMessageBox.Show("config.json无效！");
            }

            
        }

        public void WriteJSONToFile()
        {
            File.WriteAllText(this.Path, this.JConfig.ToString());
        }

        public items LoadItems()
        {
            return new items()
            {
                AllExaminedItems = (bool)JConfig["items"]["AllExaminedItems"],
                WeightOptions = (bool)JConfig["items"]["WeightOptions"],
                WeightChanger = (int)JConfig["items"]["WeightChanger"],
                MoreStack = (bool)JConfig["items"]["MoreStack"],
                MaxStackAmount = (int)JConfig["items"]["MaxStackAmount"],
                EquipRigsWithArmors = (bool)JConfig["items"]["EquipRigsWithArmors"],
                ForceMoneyStack = (bool)JConfig["items"]["ForceMoneyStack"],
                ForcedMoneyStack = (int)JConfig["items"]["ForcedMoneyStack"],
                RemoveSecureContainerFilters = (bool)JConfig["items"]["RemoveSecureContainerFilters"],
                RemoveBackpacksRestrictions = (bool)JConfig["items"]["RemoveBackpacksRestrictions"],
                RemoveContainersRestrictions = (bool)JConfig["items"]["RemoveContainersRestrictions"],
                InRaidModdable = (bool)JConfig["items"]["InRaidModdable"],
                IncreaseLootExp = (bool)JConfig["items"]["IncreaseLootExp"],
                LootExpPerc = (int)JConfig["items"]["LootExpPerc"],
                IncreaseExamineExp = (bool)JConfig["items"]["IncreaseLootExp"],
                ExamineExpPerc = (int)JConfig["items"]["ExamineExpPerc"]
            };
        }

        public void EditItems(items i)
        {
            JConfig["items"]["AllExaminedItems"] = i.AllExaminedItems;
            JConfig["items"]["WeightOptions"] = i.WeightOptions;
            JConfig["items"]["WeightChanger"] = i.WeightChanger;
            JConfig["items"]["MoreStack"] = i.MoreStack;
            JConfig["items"]["MaxStackAmount"] = i.MaxStackAmount;
            JConfig["items"]["EquipRigsWithArmors"] = i.EquipRigsWithArmors;
            JConfig["items"]["ForceMoneyStack"] = i.ForceMoneyStack;
            JConfig["items"]["ForcedMoneyStack"] = i.ForcedMoneyStack;
            JConfig["items"]["RemoveSecureContainerFilters"] = i.RemoveSecureContainerFilters;
            JConfig["items"]["RemoveBackpacksRestrictions"] = i.RemoveBackpacksRestrictions;
            JConfig["items"]["RemoveContainersRestrictions"] = i.RemoveContainersRestrictions;
            JConfig["items"]["IncreaseLootExp"] = i.IncreaseLootExp;
            JConfig["items"]["LootExpPerc"] = i.LootExpPerc;
            JConfig["items"]["IncreaseLootExp"] = i.IncreaseLootExp;
            JConfig["items"]["InRaidModdable"] = i.InRaidModdable;
            JConfig["items"]["IncreaseLootExp"] = i.IncreaseLootExp;
            JConfig["items"]["ExamineExpPerc"] = i.ExamineExpPerc;
        }


        public hideout LoadHideOut()
        {
            return new hideout()
            {
                FastHideoutConstruction = (bool)JConfig["hideout"]["FastHideoutConstruction"],
                FastHideoutProduction = (bool)JConfig["hideout"]["FastHideoutProduction"],
                FastScavCase = (bool)JConfig["hideout"]["FastScavCase"],
                ScavCasePriceReducer = (bool)JConfig["hideout"]["ScavCasePriceReducer"]
            };
        }

        public void EditHideOut(hideout h)
        {
            JConfig["hideout"]["FastHideoutConstruction"] = h.FastHideoutConstruction;
            JConfig["hideout"]["FastHideoutProduction"] = h.FastHideoutProduction;
            JConfig["hideout"]["FastScavCase"] = h.FastScavCase;
            JConfig["hideout"]["ScavCasePriceReducer"] = h.ScavCasePriceReducer;
        }

        public player LoadPlayer()
        {
            return new player()
            {
                RemoveScavTimer = (bool)JConfig["player"]["RemoveScavTimer"],
                ChangeSkillProgressionMultiplier = (bool)JConfig["player"]["ChangeSkillProgressionMultiplier"],
                SkillMultiplier = (int)JConfig["player"]["SkillMultiplier"],
                ChangeWeaponSkillMultiplier = (bool)JConfig["player"]["ChangeWeaponSkillMultiplier"],
                WeaponSkillMultiplier = (int)JConfig["player"]["WeaponSkillMultiplier"],
                DisableSkillFatigue = (bool)JConfig["player"]["DisableSkillFatigue"],
                SkillMinEffectiveness = (float)JConfig["player"]["SkillMinEffectiveness"],
                SkillFatiguePerPoint = (float)JConfig["player"]["SkillFatiguePerPoint"],
                SkillFreshEffectiveness = (float)JConfig["player"]["SkillFreshEffectiveness"],
                SkillFreshPoints = (int)JConfig["player"]["SkillFreshPoints"],
                SkillPointsBeforeFatigue = (int)JConfig["player"]["SkillPointsBeforeFatigue"],
                SkillFatigueReset = (int)JConfig["player"]["SkillFatigueReset"],
                ChangeMaxStamina = (bool)JConfig["player"]["ChangeMaxStamina"],
                NewMaxStamina = (int)JConfig["player"]["NewMaxStamina"],
                UnlimitedStamina = (bool)JConfig["player"]["UnlimitedStamina"],
                RemoveInRaidsRestrictions = (bool)JConfig["player"]["RemoveInRaidsRestrictions"],
                AllSkillsMaster = (bool)JConfig["player"]["AllSkillsMaster"]
            };
        }
        public void EditPlayer(player p)
        {
            JConfig["player"]["RemoveScavTimer"] = p.RemoveScavTimer;
            JConfig["player"]["ChangeSkillProgressionMultiplier"] = p.ChangeSkillProgressionMultiplier;
            JConfig["player"]["SkillMultiplier"] = p.SkillMultiplier;
            JConfig["player"]["ChangeWeaponSkillMultiplier"] = p.ChangeWeaponSkillMultiplier;
            JConfig["player"]["WeaponSkillMultiplier"] = p.WeaponSkillMultiplier;
            JConfig["player"]["DisableSkillFatigue"] = p.DisableSkillFatigue;
            JConfig["player"]["SkillMinEffectiveness"] = Convert.ToDouble( p.SkillMinEffectiveness.ToString("0.0000"));
            JConfig["player"]["SkillFatiguePerPoint"] = Convert.ToDouble(p.SkillFatiguePerPoint.ToString("0.0"));
            JConfig["player"]["SkillFreshEffectiveness"] = Convert.ToDouble(p.SkillFreshEffectiveness.ToString("0.0"));
            JConfig["player"]["SkillFreshPoints"] = p.SkillFreshPoints;
            JConfig["player"]["SkillPointsBeforeFatigue"] = p.SkillPointsBeforeFatigue;
            JConfig["player"]["SkillFatigueReset"] = p.SkillFatigueReset;
            JConfig["player"]["ChangeMaxStamina"] = p.ChangeMaxStamina;
            JConfig["player"]["NewMaxStamina"] = p.NewMaxStamina;
            JConfig["player"]["UnlimitedStamina"] = p.UnlimitedStamina;
            JConfig["player"]["RemoveInRaidsRestrictions"] = p.RemoveInRaidsRestrictions;
            JConfig["player"]["AllSkillsMaster"] = p.AllSkillsMaster;
        }

        public traders LoadTraders() 
        {
            return new traders()
            {
                AllQuestsAvailable = (bool)JConfig["traders"]["AllQuestsAvailable"],
                AllClothesFree = (bool)JConfig["traders"]["AllClothesFree"],
                AllClotheForEverySide = (bool)JConfig["traders"]["AllClotheForEverySide"],
                ChangeFleaMarketLvl = (bool)JConfig["traders"]["ChangeFleaMarketLvl"],
                FleaMarketMiniLvl = (int)JConfig["traders"]["FleaMarketMiniLvl"],
                IncreaseTherapistHealingPrice = (bool)JConfig["traders"]["IncreaseTherapistHealingPrice"],
                TherapistNewHealingPrice = (int)JConfig["traders"]["TherapistNewHealingPrice"],
                MaxInsuranceStorageTime = (bool)JConfig["traders"]["MaxInsuranceStorageTime"],
                AllTraders4Stars = (bool)JConfig["traders"]["AllTraders4Stars"]
            };
        }

        public void EditTraders(traders t) 
        {
            JConfig["traders"]["AllQuestsAvailable"] = t.AllQuestsAvailable;
            JConfig["traders"]["AllClothesFree"] = t.AllClothesFree;
            JConfig["traders"]["AllClotheForEverySide"] = t.AllClotheForEverySide;
            JConfig["traders"]["ChangeFleaMarketLvl"] = t.ChangeFleaMarketLvl;
            JConfig["traders"]["FleaMarketMiniLvl"] = t.FleaMarketMiniLvl;
            JConfig["traders"]["IncreaseTherapistHealingPrice"] = t.IncreaseTherapistHealingPrice;
            JConfig["traders"]["TherapistNewHealingPrice"] = t.TherapistNewHealingPrice;
            JConfig["traders"]["MaxInsuranceStorageTime"] = t.MaxInsuranceStorageTime;
            JConfig["traders"]["AllTraders4Stars"] = t.AllTraders4Stars;
        }

        public raids LoadRaids() 
        {
            return new raids() 
            {
                ChangeLootMultipiers = (bool)JConfig["raids"]["ChangeLootMultipiers"],
                NoExtractsRestrictions = (bool)JConfig["raids"]["NoExtractsRestrictions"],
                AllExtractionsAvailable = (bool)JConfig["raids"]["AllExtractionsAvailable"],
                IncreasedBossChance = (bool)JConfig["raids"]["IncreasedBossChance"],
                ExtendedRaid = (bool)JConfig["raids"]["ExtendedRaid"],
                RemoveLabKeycard = (bool)JConfig["raids"]["RemoveLabKeycard"]
            };
        }

        public void EditRaids(raids r) 
        {
            JConfig["raids"]["ChangeLootMultipiers"] = r.ChangeLootMultipiers;
            JConfig["raids"]["NoExtractsRestrictions"] = r.NoExtractsRestrictions;
            JConfig["raids"]["AllExtractionsAvailable"] = r.AllExtractionsAvailable;
            JConfig["raids"]["IncreasedBossChance"] = r.IncreasedBossChance;
            JConfig["raids"]["ExtendedRaid"] = r.ExtendedRaid;
            JConfig["raids"]["RemoveLabKeycard"] = r.RemoveLabKeycard;
        }

        public other LoadOther() 
        {
            return new other() 
            {
                HideWarningMessage = (bool)JConfig["other"]["HideWarningMessage"]
            };
        }
        public void EditOther(other o) 
        {
            JConfig["other"]["HideWarningMessage"] = o.HideWarningMessage;
        }

    }
}
