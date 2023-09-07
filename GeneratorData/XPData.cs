﻿using DevExpress.Mvvm;
using GeneratorData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BG3_XP_Table_Generator {
    public class XPData : BindableBase {
        public const string TREASURE_TABLE =
@"new treasuretable ""ST_Gold_Trader_Part""
new subtable ""5,1""
StartLevel ""1""
EndLevel ""1""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""6,1""
StartLevel ""2""
EndLevel ""2""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""7,1""
StartLevel ""3""
EndLevel ""3""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""8,1""
StartLevel ""4""
EndLevel ""4""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""9,1""
StartLevel ""5""
EndLevel ""5""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""10,1""
StartLevel ""6""
EndLevel ""6""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""11,1""
StartLevel ""7""
EndLevel ""7""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""12,1""
StartLevel ""8""
EndLevel ""8""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""13,1""
StartLevel ""9""
EndLevel ""9""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""14,1""
StartLevel ""10""
EndLevel ""10""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""15,1""
StartLevel ""11""
EndLevel ""11""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""16,1""
StartLevel ""12""
EndLevel """"
object category ""Gold"",1,0,0,0,0,0,0,0
new treasuretable ""ST_Gold_QuestReward_Part""
new subtable ""20,1""
StartLevel ""1""
EndLevel ""5""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""35,1""
StartLevel ""6""
EndLevel ""8""
object category ""Gold"",1,0,0,0,0,0,0,0
new subtable ""50,1""
StartLevel ""9""
EndLevel """"
object category ""Gold"",1,0,0,0,0,0,0,0
new treasuretable ""GEN_Book_Alchemy""
new subtable ""1,9;2,1""
StartLevel ""1""
EndLevel ""5""
object category ""I_BOOK_Alchemy_AlchemySimplePoison"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_ExtractsRuleOfThree"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_ToxinBasic"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_ElixirArcaneCultivation"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_ElixirDarkvision"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_DrowPoison"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_HealingPotion"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_HealingPotionGreater"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_LightFlask"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_PotionAnimalSpeaking"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_LesserOilSharpness"",1,0,0,0,0,0,0,0
new subtable ""1,9;2,1""
StartLevel ""6""
EndLevel """"
object category ""I_BOOK_Alchemy_PotionsVsElixirs"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_SerpentVenom"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_Coatings"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_WizardsbaneOil"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_Barkskin"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_CrawlerMucus"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_PotionMindReading"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_ElixirNecroticResistance"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_SuperiorPotionHealing"",1,0,0,0,0,0,0,0
object category ""I_BOOK_GLO_Alchemy_WyvernToxin"",1,0,0,0,0,0,0,0
object category ""I_BOOK_Alchemy_ExtractTypes"",1,0,0,0,0,0,0,0";

        [Display(Name = "Maximum XP", GroupName = "Basic Parameters")]
        public double MaxXP { get => GetValue<double>(); set => SetValue(value); }
        [Display(Name = "Minimum Level", GroupName = "Basic Parameters")]
        public int MinLvl { get => GetValue<int>(); set => SetValue(value); }
        [Display(Name = "Maximum Level", GroupName = "Basic Parameters")]
        public int MaxLvl { get => GetValue<int>(); set => SetValue(value); }
        [Display(Name = "Progression Type", GroupName = "Basic Parameters")]
        public ProgressionType Progression { get => GetValue<ProgressionType>(); set => SetValue(value); }
        [Display(Name = "Custom Increment", GroupName = "Custom Parameters")]
        public double CustomIncrement { get => GetValue<double>(); set => SetValue(value); }
        [Display(Name = "Custom Factor", GroupName = "Custom Parameters")]
        public double CustomFactor { get => GetValue<double>(); set => SetValue(value); }
        [Display(Name = "Custom Start Value", GroupName = "Custom Parameters")]
        public double CustomStartValue { get => GetValue<double>(); set => SetValue(value); }
        public ObservableCollection<XPDataRecord> XPDataRecords { get => GetValue<ObservableCollection<XPDataRecord>>(); set => SetValue(value); }

        public XPData() {
            MaxXP = 100000;
            MinLvl = 1;
            MaxLvl = 12;
            Progression = ProgressionType.Linear;
            CustomStartValue = 150.0d;
            CustomIncrement = 100.0d;
            CustomFactor = 1.5d;
            XPDataRecords = new ObservableCollection<XPDataRecord>();
        }

        public void GenerateData() {
            XPDataRecords.Clear();

            switch (Progression) {
                case ProgressionType.Linear:
                    for (int i = MinLvl; i < MaxLvl; i++)
                        XPDataRecords.Add(new XPDataRecord(i, Convert.ToInt32(i * (MaxXP / (MaxLvl * ((MaxLvl + 1) / 2.0d))))));
                    XPDataRecords.Add(new XPDataRecord(MaxLvl, Convert.ToInt32(MaxXP - XPDataRecords.Sum(x => x.XP))));
                    break;
                case ProgressionType.Exponential:
                    for (int i = MinLvl; i < MaxLvl; i++)
                        XPDataRecords.Add(new XPDataRecord(i, Convert.ToInt32(MaxXP * (Math.Pow(2.0, i)) / Math.Pow(2.0, MaxLvl + 1))));
                    XPDataRecords.Add(new XPDataRecord(MaxLvl, Convert.ToInt32(MaxXP - XPDataRecords.Sum(x => x.XP))));
                break;
                case ProgressionType.Quadratic:
                    for (int i = MinLvl; i < MaxLvl; i++)
                        XPDataRecords.Add(new XPDataRecord(i, Convert.ToInt32(MaxXP * (2.0 + Math.Pow(i - 1, 2)) / ((MaxLvl* (MaxLvl - 1) * (2 * MaxLvl - 1)) / 6))));
                    XPDataRecords.Add(new XPDataRecord(MaxLvl, Convert.ToInt32(MaxXP - XPDataRecords.Sum(x => x.XP))));
                break;
                case ProgressionType.Custom:
                    XPDataRecords.Add(new XPDataRecord(MinLvl, Convert.ToInt32(CustomStartValue)));
                    for (int i = MinLvl + 1; i < MaxLvl; i++)
                        XPDataRecords.Add(new XPDataRecord(i, Convert.ToInt32(XPDataRecords.ElementAt(i - 2).XP * CustomFactor + CustomIncrement)));
                    XPDataRecords.Add(new XPDataRecord(MaxLvl, Convert.ToInt32(MaxXP - XPDataRecords.Sum(x => x.XP))));
                    break;
            }

            RaisePropertyChanged(nameof(XPDataRecords));
        }
    }
}