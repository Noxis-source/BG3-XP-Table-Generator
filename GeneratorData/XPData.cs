using DevExpress.Mvvm;
using GeneratorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG3_XP_Table_Generator {
    public class XPData : BindableBase {
        const int DEFAULT_MaxXP = 100000;
        const int DEFAULT_MinLvl = 1;
        const int DEFAULT_MaxLvl = 12;

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

        public double MaxXP { get => GetValue<double>(); set => SetValue(value); }
        public int MinLvl { get => GetValue<int>(); set => SetValue(value); }
        public int MaxLvl { get => GetValue<int>(); set => SetValue(value); }
        public ProgressionType Progression { get => GetValue<ProgressionType>(); set => SetValue(value); }

        public XPData() {
            MaxXP = DEFAULT_MaxXP;
            MinLvl = DEFAULT_MinLvl;
            MaxLvl = DEFAULT_MaxLvl;
            Progression = ProgressionType.Linear;
        }

        public void GenerateData(ICollection<XPDataRecord> source) {
            if (Progression == ProgressionType.Linear) {
                double limit = MaxLvl + 1;
                double sum = (limit - 1) * (limit / 2.0d);
                double root = MaxXP / sum;

                for (int i = MinLvl; i < limit; i++)
                    source.Add(new XPDataRecord(i, Convert.ToInt32(i * root)));
            }
        }
    }
}
