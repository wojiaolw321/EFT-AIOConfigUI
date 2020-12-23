using System;
using System.Windows.Forms;

using Sunny.UI;

namespace AIOConfigUI
{
    public partial class AIOConfigUI : UIHeaderAsideMainFrame
    {
        private ConfigFile configFile = new ConfigFile();

        private  hideout userhideout = new hideout ();

        private items useritems = new items();

        private player userplayer = new player();

        private traders usertraders = new traders();

        private raids userraids = new raids();

        private other userother = new other();

        public AIOConfigUI()
        {
            InitializeComponent();
        }

        private void Button_ApplyConfig_Click(object sender, EventArgs e)
        {
            //switch (this.uiTabControlMenu1.SelectedTab.Name)
            //{
            //    case "tabPage_hideout":
            //        UIMessageBox.Show("Save tabPage_hideout");
            //        break;
            //    case "tabPage_items":
            //        MessageBox.Show("Save tabPage_hideout");
            //        break;
            //    case "tabPage_player":
            //        MessageBox.Show("Save tabPage_hideout");
            //        break;
            //    case "tabPage_traders":
            //        MessageBox.Show("Save tabPage_hideout");
            //        break;
            //    case "tabPage_raids":
            //        MessageBox.Show("Save tabPage_hideout");
            //        break;
            //    case "tabPage_other":
            //        MessageBox.Show("Save tabPage_hideout");
            //        break;
            //}
            configFile.EditItems(this.useritems);
            configFile.EditHideOut(this.userhideout);
            configFile.EditPlayer(this.userplayer);
            configFile.EditTraders(this.usertraders);
            configFile.EditRaids(this.userraids);
            configFile.EditOther(this.userother);
            configFile.WriteJSONToFile();
            UIMessageBox.Show("配置修改完成！");
        }

        private void tabPage_hideout_Enter(object sender, EventArgs e)
        {
            
        }

        private void AIOConfigUI_Load(object sender, EventArgs e)
        {
            this.Label_version.Text = "Version : " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            configFile.ReadJsonFromFile();
            this.useritems = configFile.LoadItems();
            this.userhideout = configFile.LoadHideOut();
            this.userplayer = configFile.LoadPlayer();
            this.usertraders = configFile.LoadTraders();
            this.userraids = configFile.LoadRaids();
            this.userother = configFile.LoadOther();

            //LoadHideOut
            this.FastHideoutConstruction.DataBindings.Clear();
            this.FastHideoutConstruction.DataBindings.Add("Checked", this.userhideout, "FastHideoutConstruction", true);
            this.FastHideoutConstruction.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.FastHideoutProduction.DataBindings.Clear();
            this.FastHideoutProduction.DataBindings.Add("Checked", userhideout, "FastHideoutProduction", true);
            this.FastHideoutProduction.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.FastScavCase.DataBindings.Clear();
            this.FastScavCase.DataBindings.Add("Checked", userhideout, "FastScavCase", true);
            this.FastScavCase.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.ScavCasePriceReducer.DataBindings.Clear();
            this.ScavCasePriceReducer.DataBindings.Add("Checked", userhideout, "ScavCasePriceReducer", true);
            this.ScavCasePriceReducer.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            //items
            this.AllExaminedItems.DataBindings.Clear();
            this.AllExaminedItems.DataBindings.Add("Checked", useritems, "AllExaminedItems", true);
            this.AllExaminedItems.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.WeightOptions.DataBindings.Clear();
            this.WeightOptions.DataBindings.Add("Checked", useritems, "WeightOptions", true);
            this.WeightOptions.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.MoreStack.DataBindings.Clear();
            this.MoreStack.DataBindings.Add("Checked", useritems, "MoreStack", true);
            this.MoreStack.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.EquipRigsWithArmors.DataBindings.Clear();
            this.EquipRigsWithArmors.DataBindings.Add("Checked", useritems, "EquipRigsWithArmors", true);
            this.EquipRigsWithArmors.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.ForceMoneyStack.DataBindings.Clear();
            this.ForceMoneyStack.DataBindings.Add("Checked", useritems, "ForceMoneyStack", true);
            this.ForceMoneyStack.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.RemoveSecureContainerFilters.DataBindings.Clear();
            this.RemoveSecureContainerFilters.DataBindings.Add("Checked", useritems, "RemoveSecureContainerFilters", true);
            this.RemoveSecureContainerFilters.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.RemoveBackpacksRestrictions.DataBindings.Clear();
            this.RemoveBackpacksRestrictions.DataBindings.Add("Checked", useritems, "RemoveBackpacksRestrictions", true);
            this.RemoveBackpacksRestrictions.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.RemoveContainersRestrictions.DataBindings.Clear();
            this.RemoveContainersRestrictions.DataBindings.Add("Checked", useritems, "RemoveContainersRestrictions", true);
            this.RemoveContainersRestrictions.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.InRaidModdable.DataBindings.Clear();
            this.InRaidModdable.DataBindings.Add("Checked", useritems, "InRaidModdable", true);
            this.InRaidModdable.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.IncreaseLootExp.DataBindings.Clear();
            this.IncreaseLootExp.DataBindings.Add("Checked", useritems, "IncreaseLootExp", true);
            this.IncreaseLootExp.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.IncreaseExamineExp.DataBindings.Clear();
            this.IncreaseExamineExp.DataBindings.Add("Checked", useritems, "IncreaseExamineExp", true);
            this.IncreaseExamineExp.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.WeightChanger.DataBindings.Add("Value", useritems, "WeightChanger", true);
            this.WeightChanger.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_WeightChanger.DataBindings.Add("Value", useritems, "WeightChanger", true);
            this.UpDown_WeightChanger.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.MaxStackAmount.DataBindings.Add("Value", useritems, "MaxStackAmount", true);
            this.MaxStackAmount.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_MaxStackAmount.DataBindings.Add("Value", useritems, "MaxStackAmount", true);
            this.UpDown_MaxStackAmount.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.ForcedMoneyStack.DataBindings.Add("Value", useritems, "ForcedMoneyStack", true);
            this.ForcedMoneyStack.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_ForcedMoneyStack.DataBindings.Add("Value", useritems, "ForcedMoneyStack", true);
            this.UpDown_ForcedMoneyStack.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);


            this.LootExpPerc.DataBindings.Add("Value", useritems, "LootExpPerc", true);
            this.LootExpPerc.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_LootExpPerc.DataBindings.Add("Value", useritems, "LootExpPerc", true);
            this.UpDown_LootExpPerc.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.ExamineExpPerc.DataBindings.Add("Value", useritems, "ExamineExpPerc", true);
            this.ExamineExpPerc.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_ExamineExpPerc.DataBindings.Add("Value", useritems, "ExamineExpPerc", true);
            this.UpDown_ExamineExpPerc.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            

            //Player
            this.RemoveScavTimer.DataBindings.Clear();
            this.RemoveScavTimer.DataBindings.Add("Checked", userplayer, "RemoveScavTimer", true);
            this.RemoveScavTimer.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.ChangeSkillProgressionMultiplier.DataBindings.Clear();
            this.ChangeSkillProgressionMultiplier.DataBindings.Add("Checked", userplayer, "ChangeSkillProgressionMultiplier", true);
            this.ChangeSkillProgressionMultiplier.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.DisableSkillFatigue.DataBindings.Clear();
            this.DisableSkillFatigue.DataBindings.Add("Checked", userplayer, "DisableSkillFatigue", true);
            this.DisableSkillFatigue.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.ChangeMaxStamina.DataBindings.Clear();
            this.ChangeMaxStamina.DataBindings.Add("Checked", userplayer, "ChangeMaxStamina", true);
            this.ChangeMaxStamina.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.UnlimitedStamina.DataBindings.Clear();
            this.UnlimitedStamina.DataBindings.Add("Checked", userplayer, "UnlimitedStamina", true);
            this.UnlimitedStamina.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.RemoveInRaidsRestrictions.DataBindings.Clear();
            this.RemoveInRaidsRestrictions.DataBindings.Add("Checked", userplayer, "RemoveInRaidsRestrictions", true);
            this.RemoveInRaidsRestrictions.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.AllSkillsMaster.DataBindings.Clear();
            this.AllSkillsMaster.DataBindings.Add("Checked", userplayer, "AllSkillsMaster", true);
            this.AllSkillsMaster.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.ChangeWeaponSkillMultiplier.DataBindings.Clear();
            this.ChangeWeaponSkillMultiplier.DataBindings.Add("Checked", userplayer, "ChangeWeaponSkillMultiplier", true);
            this.ChangeWeaponSkillMultiplier.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.SkillMultiplier.DataBindings.Add("Value", userplayer, "SkillMultiplier", true);
            this.SkillMultiplier.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_SkillMultiplier.DataBindings.Add("Value", userplayer, "SkillMultiplier", true);
            this.UpDown_SkillMultiplier.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);
            
            this.WeaponSkillMultiplier.DataBindings.Add("Value", userplayer, "WeaponSkillMultiplier", true);
            this.WeaponSkillMultiplier.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_WeaponSkillMultiplier.DataBindings.Add("Value", userplayer, "WeaponSkillMultiplier", true);
            this.UpDown_WeaponSkillMultiplier.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.SkillFreshPoints.DataBindings.Add("Value", userplayer, "SkillFreshPoints", true);
            this.SkillFreshPoints.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_SkillFreshPoints.DataBindings.Add("Value", userplayer, "SkillFreshPoints", true);
            this.UpDown_SkillFreshPoints.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.SkillPointsBeforeFatigue.DataBindings.Add("Value", userplayer, "SkillPointsBeforeFatigue", true);
            this.SkillPointsBeforeFatigue.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_SkillPointsBeforeFatigue.DataBindings.Add("Value", userplayer, "SkillPointsBeforeFatigue", true);
            this.UpDown_SkillPointsBeforeFatigue.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.SkillFatigueReset.DataBindings.Add("Value", userplayer, "SkillFatigueReset", true);
            this.SkillFatigueReset.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_SkillFatigueReset.DataBindings.Add("Value", userplayer, "SkillFatigueReset", true);
            this.UpDown_SkillFatigueReset.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.NewMaxStamina.DataBindings.Add("Value", userplayer, "NewMaxStamina", true);
            this.NewMaxStamina.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_NewMaxStamina.DataBindings.Add("Value", userplayer, "NewMaxStamina", true);
            this.UpDown_NewMaxStamina.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.UpDown_SkillMinEffectiveness.DataBindings.Add("Value", userplayer, "SkillMinEffectiveness", true);
            this.UpDown_SkillMinEffectiveness.ValueChanged += new Sunny.UI.UIDoubleUpDown.OnValueChanged(this.UIDoubleUpDown_ValueChanged);

            this.UpDown_SkillFatiguePerPoint.DataBindings.Add("Value", userplayer, "SkillFatiguePerPoint", true);
            this.UpDown_SkillFatiguePerPoint.ValueChanged += new Sunny.UI.UIDoubleUpDown.OnValueChanged(this.UIDoubleUpDown_ValueChanged);

            this.UpDown_SkillFreshEffectiveness.DataBindings.Add("Value", userplayer, "SkillFreshEffectiveness", true);
            this.UpDown_SkillFreshEffectiveness.ValueChanged += new Sunny.UI.UIDoubleUpDown.OnValueChanged(this.UIDoubleUpDown_ValueChanged);

            //traders
            this.AllQuestsAvailable.DataBindings.Clear();
            this.AllQuestsAvailable.DataBindings.Add("Checked", usertraders, "AllQuestsAvailable", true);
            this.AllQuestsAvailable.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.AllClothesFree.DataBindings.Clear();
            this.AllClothesFree.DataBindings.Add("Checked", usertraders, "AllClothesFree", true);
            this.AllClothesFree.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);


            this.AllClotheForEverySide.DataBindings.Clear();
            this.AllClotheForEverySide.DataBindings.Add("Checked", usertraders, "AllClotheForEverySide", true);
            this.AllClotheForEverySide.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.ChangeFleaMarketLvl.DataBindings.Clear();
            this.ChangeFleaMarketLvl.DataBindings.Add("Checked", usertraders, "ChangeFleaMarketLvl", true);
            this.ChangeFleaMarketLvl.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.IncreaseTherapistHealingPrice.DataBindings.Clear();
            this.IncreaseTherapistHealingPrice.DataBindings.Add("Checked", usertraders, "IncreaseTherapistHealingPrice", true);
            this.IncreaseTherapistHealingPrice.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.MaxInsuranceStorageTime.DataBindings.Clear();
            this.MaxInsuranceStorageTime.DataBindings.Add("Checked", usertraders, "MaxInsuranceStorageTime", true);
            this.MaxInsuranceStorageTime.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.AllTraders4Stars.DataBindings.Clear();
            this.AllTraders4Stars.DataBindings.Add("Checked", usertraders, "AllTraders4Stars", true);
            this.AllTraders4Stars.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);


            this.FleaMarketMiniLvl.DataBindings.Add("Value", usertraders, "FleaMarketMiniLvl", true);
            this.FleaMarketMiniLvl.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_FleaMarketMiniLvl.DataBindings.Add("Value", usertraders, "FleaMarketMiniLvl", true);
            this.UpDown_FleaMarketMiniLvl.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);

            this.TherapistNewHealingPrice.DataBindings.Add("Value", usertraders, "TherapistNewHealingPrice", true);
            this.TherapistNewHealingPrice.ValueChanged += new System.EventHandler(this.UITrackBar_ValueChanged);
            this.UpDown_TherapistNewHealingPrice.DataBindings.Add("Value", usertraders, "TherapistNewHealingPrice", true);
            this.UpDown_TherapistNewHealingPrice.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.UIIntegerUpDown_ValueChanged);


            //raids
            this.ChangeLootMultipiers.DataBindings.Clear();
            this.ChangeLootMultipiers.DataBindings.Add("Checked", userraids, "ChangeLootMultipiers", true);
            this.ChangeLootMultipiers.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.NoExtractsRestrictions.DataBindings.Clear();
            this.NoExtractsRestrictions.DataBindings.Add("Checked", userraids, "NoExtractsRestrictions", true);
            this.NoExtractsRestrictions.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.AllExtractionsAvailable.DataBindings.Clear();
            this.AllExtractionsAvailable.DataBindings.Add("Checked", userraids, "AllExtractionsAvailable", true);
            this.AllExtractionsAvailable.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);
            
            this.IncreasedBossChance.DataBindings.Clear();
            this.IncreasedBossChance.DataBindings.Add("Checked", userraids, "IncreasedBossChance", true);
            this.IncreasedBossChance.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.ExtendedRaid.DataBindings.Clear();
            this.ExtendedRaid.DataBindings.Add("Checked", userraids, "ExtendedRaid", true);
            this.ExtendedRaid.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            this.RemoveLabKeycard.DataBindings.Clear();
            this.RemoveLabKeycard.DataBindings.Add("Checked", userraids, "RemoveLabKeycard", true);
            this.RemoveLabKeycard.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);

            //other
            this.HideWarningMessage.DataBindings.Clear();
            this.HideWarningMessage.DataBindings.Add("Checked", userother, "HideWarningMessage", true);
            this.HideWarningMessage.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.UICheckBox_OnValueChanged);
        }



        private void UICheckBox_OnValueChanged(object sender, bool value)
        {
            UICheckBox uICheckBox = (UICheckBox)sender;
            uICheckBox.DataBindings["Checked"].WriteValue();
        }

        private void UITrackBar_ValueChanged(object sender, EventArgs e)
        {
            UITrackBar uITrackBar = (UITrackBar)sender;
            uITrackBar.DataBindings["Value"].WriteValue();

        }

        private void UIIntegerUpDown_ValueChanged(object sender, int value)
        {
            UIIntegerUpDown uIIntegerUpDown  = (UIIntegerUpDown)sender;
            uIIntegerUpDown.DataBindings["Value"].WriteValue();
        }

        private void Button_ReloadAll_Click(object sender, EventArgs e)
        {
            this.AIOConfigUI_Load(sender, e);
        }

        private void UIDoubleUpDown_ValueChanged(object sender, double value)
        {
            UIDoubleUpDown uIDoubleUpDown = (UIDoubleUpDown)sender;
            uIDoubleUpDown.DataBindings["Value"].WriteValue();
        }
    }
}
