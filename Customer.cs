using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ColumnAttribute = SQLite.ColumnAttribute;
using TableAttribute = SQLite.TableAttribute;

namespace MauiApp7
{
    [Table("customer")]
    public class Customer
    {
        [PrimaryKey]
        [AutoIncrement]

        [Column("id")]
        public int Id { get; set; }
        [Column("CustomerName")]
        public string CustomerName { get; set; }
        [Column("Mobile")]
        public string Mobile { get; set; }
        [Column("Email")]
        public string Email { get; set; }


    }

    [Table("Player")]
    public class Player
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("Id")]
        public int Id { get; set; }

        [Column("DataEntryField")]
        public DateTime DataEntryField { get; set; }

        [Column("nameEntryField")]
        public string NameEntryField { get; set; }

        [Column("RaceEntryField")]
        public string RaceEntryField { get; set; }

        [Column("SexEntryField")]
        public string SexEntryField { get; set; }

        [Column("AgeEntryField")]
        public string AgeEntryField { get; set; }

        [Column("IntelligenceEntryField")]
        public string IntelligenceEntryField { get; set; }

        [Column("ReflexesEntryField")]
        public string ReflexesEntryField { get; set; }

        [Column("DexterityEntryField")]
        public string DexterityEntryField { get; set; }

        [Column("BodyEntryField")]
        public string BodyEntryField { get; set; }

        [Column("SpeedEntryField")]
        public string SpeedEntryField { get; set; }

        [Column("EmpathyEntryField")]
        public string EmpathyEntryField { get; set; }

        [Column("RepairEntryField")]
        public string RepairEntryField { get; set; }

        [Column("WillEntryField")]
        public string WillEntryField { get; set; }

        [Column("restEntryField")]
        public string RestEntryField { get; set; }

        [Column("WeightEntryField")]
        public string WeightEntryField { get; set; }

        [Column("EnduranceEntryField")]
        public string EnduranceEntryField { get; set; }

        [Column("HPEntryField2")]
        public string HPEntryField2 { get; set; }

        [Column("JumpEntryField")]
        public string JumpEntryField { get; set; }

        [Column("RunEntryField")]
        public string RunEntryField { get; set; }

        [Column("FatigueEntryField")]
        public string FatigueEntryField { get; set; }

        [Column("LuckEntryField")]
        public string LuckEntryField { get; set; }

        [Column("ImageEntryField")]
        public string ImageEntryField { get; set; }

        [Column("HP_EntryField")]
        public string HPEntryField { get; set; }

        [Column("Stamm_EntryField")]
        public string StammEntryField { get; set; }

        [Column("Name_WEntryField")]
        public string NameWEntryField { get; set; }

        [Column("Name_WEntryField2")]
        public string NameWEntryField2 { get; set; }

        [Column("Name_WEntryField3")]
        public string NameWEntryField3 { get; set; }

        [Column("Accuracy_WEntryField")]
        public string AccuracyWEntryField { get; set; }

        [Column("Accuracy_WEntryField2")]
        public string AccuracyWEntryField2 { get; set; }

        [Column("Accuracy_WEntryField3")]
        public string AccuracyWEntryField3 { get; set; }

        [Column("Damage_WEntryField")]
        public string DamageWEntryField { get; set; }

        [Column("Damage_WEntryField2")]
        public string DamageWEntryField2 { get; set; }

        [Column("Damage_WEntryField3")]
        public string DamageWEntryField3 { get; set; }

        [Column("Durable_WEntryField")]
        public string DurableWEntryField { get; set; }

        [Column("Durable_WEntryField2")]
        public string DurableWEntryField2 { get; set; }

        [Column("Durable_WEntryField3")]
        public string DurableWEntryField3 { get; set; }

        [Column("Grip_WEntryField")]
        public string GripWEntryField { get; set; }

        [Column("Grip_WEntryField2")]
        public string GripWEntryField2 { get; set; }

        [Column("Grip_WEntryField3")]
        public string GripWEntryField3 { get; set; }

        [Column("Dist_WEntryField")]
        public string DistWEntryField { get; set; }

        [Column("Dist_WEntryField2")]
        public string DistWEntryField2 { get; set; }

        [Column("Dist_WEntryField3")]
        public string DistWEntryField3 { get; set; }

        [Column("Effects_WEntryField")]
        public string EffectsWEntryField { get; set; }

        [Column("Effects_WEntryField2")]
        public string EffectsWEntryField2 { get; set; }

        [Column("Effects_WEntryField3")]
        public string EffectsWEntryField3 { get; set; }

        [Column("Hidden_WEntryField")]
        public string HiddenWEntryField { get; set; }

        [Column("Hidden_WEntryField2")]
        public string HiddenWEntryField2 { get; set; }

        [Column("Hidden_WEntryField3")]
        public string HiddenWEntryField3 { get; set; }

        [Column("Improvement_WEntryField")]
        public string ImprovementWEntryField { get; set; }

        [Column("Improvement_WEntryField2")]
        public string ImprovementWEntryField2 { get; set; }

        [Column("Improvement_WEntryField3")]
        public string ImprovementWEntryField3 { get; set; }

        [Column("Weight_WEntryField")]
        public string WeightWEntryField { get; set; }

        [Column("Weight_WEntryField2")]
        public string WeightWEntryField2 { get; set; }

        [Column("Weight_WEntryField3")]
        public string WeightWEntryField3 { get; set; }

        [Column("H_D_11_AEntryField")]
        public string HD11AEntryField { get; set; }

        [Column("H_PB_12_AEntryField")]
        public string HPB12AEntryField { get; set; }

        [Column("B_D_21_AEntryField")]
        public string BD21AEntryField { get; set; }

        [Column("B_PB_22_AEntryField")]
        public string BPB22AEntryField { get; set; }

        [Column("RH_D_31_AEntryField")]
        public string RHD31AEntryField { get; set; }

        [Column("RH_PB_32_AEntryField")]
        public string RHPB32AEntryField { get; set; }

        [Column("LL_D_14_AEntryField")]
        public string LLD14AEntryField { get; set; }

        [Column("LL_PB_15_AEntryField")]
        public string LLPB15AEntryField { get; set; }

        [Column("RL_D_42_AEntryField")]
        public string RLD42AEntryField { get; set; }

        [Column("RL_PB_52_AEntryField")]
        public string RLPB52AEntryField { get; set; }

        [Column("LH_D_34_AEntryField")]
        public string LHD34AEntryField { get; set; }

        [Column("LH_PB_35_AEntryField")]
        public string LHPB35AEntryField { get; set; }

        [Column("AttentionEntryField")]
        public string AttentionEntryField { get; set; }

        [Column("TradeEntryField")]
        public string TradeEntryField { get; set; }

        [Column("DeductionEntryField")]
        public string DeductionEntryField { get; set; }

        [Column("EducationEntryField")]
        public string EducationEntryField { get; set; }

        [Column("L_UniversalEntryField")]
        public string LUniversalEntryField { get; set; }

        [Column("L_S_SEntryField")]
        public string LSSEntryField { get; set; }

        [Column("L_KEntryField")]
        public string LKEntryField { get; set; }

        [Column("MonstrologyEntryField")]
        public string MonstrologyEntryField { get; set; }

        [Column("EtiquetteEntryField")]
        public string EtiquetteEntryField { get; set; }

        [Column("OrientationEntryField")]
        public string OrientationEntryField { get; set; }

        [Column("TacticsEntryField")]
        public string TacticsEntryField { get; set; }

        [Column("KnowledgeEntryField")]
        public string KnowledgeEntryField { get; set; }

        [Column("SurvivalEntryField")]
        public string SurvivalEntryField { get; set; }

        [Column("Shoot_BowEntryField")]
        public string ShootBowEntryField { get; set; }

        [Column("AthleticsEntryField")]
        public string AthleticsEntryField { get; set; }

        [Column("ShootCrossbowEntryField")]
        public string ShootCrossbowEntryField { get; set; }

        [Column("SleightEntryField")]
        public string SleightEntryField { get; set; }

        [Column("StealthEntryField")]
        public string StealthEntryField { get; set; }

        [Column("Alchemy_EntryField")]
        public string AlchemyEntryField { get; set; }

        [Column("Crafting_EntryField")]
        public string CraftingEntryField { get; set; }

        [Column("Disguise_EntryField")]
        public string DisguiseEntryField { get; set; }

        [Column("Medicine_EntryField")]
        public string MedicineEntryField { get; set; }

        [Column("Fake_EntryField")]
        public string FakeEntryField { get; set; }

        [Column("Lockpicking_EntryField")]
        public string LockpickingEntryField { get; set; }

        [Column("MTraps_EntryField")]
        public string MTrapsEntryField { get; set; }

        [Column("Equipment_Editor")]
        public string EquipmentEditor { get; set; }

        [Column("ForceEntryField")]
        public string ForceEntryField { get; set; }

        [Column("DurabilityEntryField")]
        public string DurabilityEntryField { get; set; }

        [Column("Struggle_EntryField")]
        public string StruggleEntryField { get; set; }

        [Column("Evasion_EntryField")]
        public string EvasionEntryField { get; set; }

        [Column("Melee_EntryField")]
        public string MeleeEntryField { get; set; }

        [Column("Horseback_EntryField")]
        public string HorsebackEntryField { get; set; }

        [Column("Sailing_EntryField")]
        public string SailingEntryField { get; set; }

        [Column("L_Blades_EntryField")]
        public string LBladesEntryField { get; set; }

        [Column("TreeEntryField")]
        public string TreeEntryField { get; set; }

        [Column("SwordEntryField")]
        public string SwordEntryField { get; set; }

        [Column("Charisma_EntryField")]
        public string CharismaEntryField { get; set; }

        [Column("Deception_EntryField")]
        public string DeceptionEntryField { get; set; }

        [Column("Art_EntryField")]
        public string ArtEntryField { get; set; }

        [Column("Games_EntryField")]
        public string GamesEntryField { get; set; }

        [Column("Appearance_EntryField")]
        public string AppearanceEntryField { get; set; }

        [Column("Understand_EntryField")]
        public string UnderstandEntryField { get; set; }

        [Column("Leadership_EntryField")]
        public string LeadershipEntryField { get; set; }

        [Column("Belief_EntryField")]
        public string BeliefEntryField { get; set; }

        [Column("Performance_EntryField")]
        public string PerformanceEntryField { get; set; }

        [Column("Seduction_EntryField")]
        public string SeductionEntryField { get; set; }

        [Column("Bravery_EntryField")]
        public string BraveryEntryField { get; set; }

        [Column("Porcha_EntryField")]
        public string PorchaEntryField { get; set; }

        [Column("Intimidation_EntryField")]
        public string IntimidationEntryField { get; set; }

        [Column("MSpells_EntryField")]
        public string MSpellsEntryField { get; set; }

        [Column("Appearance_EntryField2")]
        public string AppearanceEntryField2 { get; set; }

        [Column("RConviction_EntryField")]
        public string RConvictionEntryField { get; set; }

        [Column("MRituals_EntryField")]
        public string MRitualsEntryField { get; set; }

        [Column("Notes_Editor")]
        public string NotesEditor { get; set; }

        [Column("Attention_DB_EntryField")]
        public string Attention_DB_EntryField { get; set; }

        [Column("Trade_DB_EntryField")]
        public string Trade_DB_EntryField { get; set; }
        [Column("Deduction_DB_EntryField")]
        public string Deduction_DB_EntryField { get; set; }
        [Column("Education_DB_EntryField")]
        public string Education_DB_EntryField { get; set; }
        [Column("L_Universal_DB_EntryField")]
        public string L_Universal_DB_EntryField { get; set; }
        [Column("Monstrology_DB_EntryField")]
        public string Monstrology_DB_EntryField { get; set; }
        [Column("Etiquette_DB_EntryField")]
        public string Etiquette_DB_EntryField { get; set; }
        [Column("Orientation_DB_EntryField")]
        public string Orientation_DB_EntryField { get; set; }
        [Column("Tactics_DB_EntryField")]
        public string Tactics_DB_EntryField { get; set; }
        [Column("Knowledge_DB_EntryField")]
        public string Knowledge_DB_EntryField { get; set; }
        [Column("Survival_DB_EntryField")]
        public string Survival_DB_EntryField { get; set; }
        [Column("Shoot_Bow_DB_EntryField")]
        public string Shoot_Bow_DB_EntryField { get; set; }
        [Column("Athletics_DB_EntryField")]
        public string Athletics_DB_EntryField { get; set; }
        [Column("ShootCrossbow_DB_EntryField")]
        public string ShootCrossbow_DB_EntryField { get; set; }
        [Column("Sleight_DB_EntryField")]
        public string Sleight_DB_EntryField { get; set; }
        [Column("Stealth_DB_EntryField")]
        public string Stealth_DB_EntryField { get; set; }
        [Column("Alchemy_DB_EntryField")]
        public string Alchemy_DB_EntryField { get; set; }
        [Column("Crafting_DB_EntryField")]
        public string Crafting_DB_EntryField { get; set; }
        [Column("Disguise_DB_EntryField")]
        public string Disguise_DB_EntryField { get; set; }
        [Column("Medicine_DB_EntryField")]
        public string Medicine_DB_EntryField { get; set; }
        [Column("Fake_DB_EntryField")]
        public string Fake_DB_EntryField { get; set; }
        [Column("Lockpicking_DB_EntryField")]
        public string Lockpicking_DB_EntryField { get; set; }
        [Column("MTraps_DB_EntryField")]
        public string MTraps_DB_EntryField { get; set; }
        [Column("Force_DB_EntryField")]
        public string Force_DB_EntryField { get; set; }
        [Column("Durability_DB_EntryField")]
        public string Durability_DB_EntryField { get; set; }
        [Column("Struggle_DB_EntryField")]
        public string Struggle_DB_EntryField { get; set; }
        [Column("Evasion_DB_EntryField")]
        public string Evasion_DB_EntryField { get; set; }
        [Column("Melee_DB_EntryField")]
        public string Melee_DB_EntryField { get; set; }
        [Column("Horseback_DB_EntryField")]
        public string Horseback_DB_EntryField { get; set; }
        [Column("Sailing_DB_EntryField")]
        public string Sailing_DB_EntryField { get; set; }
        [Column("L_R_DB_EntryField")]
        public string L_R_DB_EntryField { get; set; }
        [Column("Tree_DB_EntryField")]
        public string Tree_DB_EntryField { get; set; }
        [Column("Sword_DB_EntryField")]
        public string Sword_DB_EntryField { get; set; }
        [Column("Charisma_DB_EntryField")]
        public string Charisma_DB_EntryField { get; set; }
        [Column("Deception_DB_EntryField")]
        public string Deception_DB_EntryField { get; set; }
        [Column("Art_DB_EntryField")]
        public string Art_DB_EntryField { get; set; }
        [Column("Games_DB_EntryField")]
        public string Games_DB_EntryField { get; set; }
        [Column("Appearance_DB_EntryField")]
        public string Appearance_DB_EntryField { get; set; }
        [Column("Understand_DB_EntryField")]
        public string Understand_DB_EntryField { get; set; }
        [Column("Leadership_DB_EntryField")]
        public string Leadership_DB_EntryField { get; set; }
        [Column("Belief_DB_EntryField")]
        public string Belief_DB_EntryField { get; set; }
        [Column("Performance_DB_EntryField")]
        public string Performance_DB_EntryField { get; set; }
        [Column("Seduction_DB_EntryField")]
        public string Seduction_DB_EntryField { get; set; }
        [Column("Bravery_DB_EntryField")]
        public string Bravery_DB_EntryField { get; set; }
        [Column("Porcha_DB_EntryField")]
        public string Porcha_DB_EntryField { get; set; }
        [Column("Intimidation_DB_EntryField")]
        public string Intimidation_DB_EntryField { get; set; }
        [Column("MSpells_DB_EntryField")]
        public string MSpells_DB_EntryField { get; set; }
        [Column("Appearance_DB_EntryField2")]
        public string Appearance_DB_EntryField2 { get; set; }
        [Column("RConviction_DB_EntryField")]
        public string RConviction_DB_EntryField { get; set; }
        [Column("MRituals_DB_EntryField")]
        public string MRituals_DB_EntryField { get; set; }

        [Column("L_S_DB")]
        public string L_S_DB { get; set; }
        [Column("L_K_DB_EntryField")]
        public string L_K_DB_EntryField { get; set; }
        [Column("Crons_EntryField")]
        public string Crons_EntryField { get; set; }
        [Column("Orens_EntryField")]
        public string Orens_EntryField { get; set; }
        [Column("Florens_EntryField")]
        public string Florens_EntryField { get; set; }
        [Column("HP_EntryField2")]
        public string HP_EntryField2 { get; set; }
        [Column("Stamm_EntryField2")]
        public string Stamm_EntryField2 { get; set; }
        [Column("Energy_EntryField")]
        public string Energy_EntryField { get; set; }
        [Column("Energy_EntryField2")]
        public string Energy_EntryField2 { get; set; }
        [Column("EXP_EntryField")]
        public string EXP_EntryField { get; set; }

        [Column("JobEntryField")]
        public string JobEntryField { get; set; }

        [Column("Adrenalin_EntryField")]
        public string Adrenalin_EntryField { get; set; }
        [Column("Adrenalin2_EntryField")]
        public string Adrenalin2_EntryField { get; set; }
        [Column("Concentrat_EntryField")]
        public string Concentrat_EntryField { get; set; }
        [Column("Concentrat2_EntryField")]
        public string Concentrat2_EntryField { get; set; }
        [Column("Luck_EntryField")]
        public string Luck_EntryField { get; set; }
        [Column("Luck2_EntryField")]
        public string Luck2_EntryField { get; set; }



        public string ToXml()
        {
            // Создание объекта XmlSerializer для класса Player
            XmlSerializer serializer = new XmlSerializer(typeof(Player));

            // Создание StringWriter для записи XML
            StringWriter writer = new StringWriter();

            // Сериализация объекта Player в XML и запись в StringWriter
            serializer.Serialize(writer, this);

            // Получение XML-строки
            string xmlString = writer.ToString();

            return xmlString;
        }

        public static Player FromXml(string xml)
        {
            // Создание объекта XmlSerializer для класса Player
            XmlSerializer serializer = new XmlSerializer(typeof(Player));

            // Создание StringReader для чтения XML
            StringReader reader = new StringReader(xml);

            // Десериализация XML в объект Player
            Player customer = (Player)serializer.Deserialize(reader);

            return customer;
        }

    }


    public class CustomerXML
    {
        public int Id { get; set; }
        public string AccuracyWEntryField { get; set; }
        public string AccuracyWEntryField2 { get; set; }
        public string AccuracyWEntryField3 { get; set; }
        public string Adrenalin2_EntryField { get; set; }
        public string Adrenalin_EntryField { get; set; }
        public string AgeEntryField { get; set; }
        public string AlchemyEntryField { get; set; }
        public string Alchemy_DB_EntryField { get; set; }
        public string AppearanceEntryField { get; set; }
        public string AppearanceEntryField2 { get; set; }
        public string Appearance_DB_EntryField { get; set; }
        public string Appearance_DB_EntryField2 { get; set; }
        public string ArtEntryField { get; set; }
        public string Art_DB_EntryField { get; set; }
        public string AthleticsEntryField { get; set; }
        public string Athletics_DB_EntryField { get; set; }
        public string AttentionEntryField { get; set; }
        public string Attention_DB_EntryField { get; set; }
        public string BD21AEntryField { get; set; }
        public string BPB22AEntryField { get; set; }
        public string BeliefEntryField { get; set; }
        public string Belief_DB_EntryField { get; set; }
        public string BodyEntryField { get; set; }
        public string BraveryEntryField { get; set; }
        public string Bravery_DB_EntryField { get; set; }
        public string CharismaEntryField { get; set; }
        public string Charisma_DB_EntryField { get; set; }
        public string Concentrat2_EntryField { get; set; }
        public string Concentrat_EntryField { get; set; }
        public string CraftingEntryField { get; set; }
        public string Crafting_DB_EntryField { get; set; }
        public string Crons_EntryField { get; set; }
        public string DamageWEntryField { get; set; }
        public string DamageWEntryField2 { get; set; }
        public string DamageWEntryField3 { get; set; }
        public DateTime DataEntryField { get; set; }
        public string DeceptionEntryField { get; set; }
        public string Deception_DB_EntryField { get; set; }
        public string DeductionEntryField { get; set; }
        public string Deduction_DB_EntryField { get; set; }
        public string DexterityEntryField { get; set; }
        public string DisguiseEntryField { get; set; }
        public string Disguise_DB_EntryField { get; set; }
        public string DistWEntryField { get; set; }
        public string DistWEntryField2 { get; set; }
        public string DistWEntryField3 { get; set; }
        public string DurabilityEntryField { get; set; }
        public string Durability_DB_EntryField { get; set; }
        public string DurableWEntryField { get; set; }
        public string DurableWEntryField2 { get; set; }
        public string DurableWEntryField3 { get; set; }
        public string EXP_EntryField { get; set; }
        public string EducationEntryField { get; set; }
        public string Education_DB_EntryField { get; set; }
        public string EffectsWEntryField { get; set; }
        public string EffectsWEntryField2 { get; set; }
        public string EffectsWEntryField3 { get; set; }
        public string EmpathyEntryField { get; set; }
        public string EnduranceEntryField { get; set; }
        public string Energy_EntryField { get; set; }
        public string Energy_EntryField2 { get; set; }
        public string EquipmentEditor { get; set; }
        public string EtiquetteEntryField { get; set; }
        public string Etiquette_DB_EntryField { get; set; }
        public string EvasionEntryField { get; set; }
        public string Evasion_DB_EntryField { get; set; }
        public string FakeEntryField { get; set; }
        public string Fake_DB_EntryField { get; set; }
        public string FatigueEntryField { get; set; }
        public string Florens_EntryField { get; set; }
        public string ForceEntryField { get; set; }
        public string Force_DB_EntryField { get; set; }
        public string GamesEntryField { get; set; }
        public string Games_DB_EntryField { get; set; }
        public string GripWEntryField { get; set; }
        public string GripWEntryField2 { get; set; }
        public string GripWEntryField3 { get; set; }
        public string HD11AEntryField { get; set; }
        public string HPB12AEntryField { get; set; }
        public string HPEntryField { get; set; }
        public string HPEntryField2 { get; set; }
        public string HP_EntryField2 { get; set; }
        public string HiddenWEntryField { get; set; }
        public string HiddenWEntryField2 { get; set; }
        public string HiddenWEntryField3 { get; set; }
        public string HorsebackEntryField { get; set; }
        public string Horseback_DB_EntryField { get; set; }
        public string ImageEntryField { get; set; }
        public string ImprovementWEntryField { get; set; }
        public string lmprovementWEntryField2 { get; set; }
        public string lmprovementWEntryField3 { get; set; }
        public string IntelligenceEntryField { get; set; }
        public string IntimidationEntryField { get; set; }
        public string lntimidation_DB_EntryField { get; set; }
        public string JobEntryField { get; set; }
        public string JumpEntryField { get; set; }
        public string KnowledgeEntryField { get; set; }
        public string Knowledge_DB_EntryField { get; set; }
        public string LBIadesEntryField { get; set; }
        public string LHD34AEntryField { get; set; }
        public string LHPB35AEntryField { get; set; }
        public string LKEntryField { get; set; }
        public string LLD14AEntryField { get; set; }
        public string LLPB15AEntryField { get; set; }
        public string LSSEntryField { get; set; }
        public string LUniversalEntryField { get; set; }
        public string L_K_DB_EntryField { get; set; }
        public string L_R_DB_EntryField { get; set; }
        public string L_S_DB { get; set; }
        public string L_Universal_DB_EntryField { get; set; }
        public string LeadershipEntryField { get; set; }
        public string Leadership_DB_EntryField { get; set; }
        public string LockpickingEntryField { get; set; }
        public string Lockpicking_DB_EntryField { get; set; }
        public string Luck2_EntryField { get; set; }
        public string LuckEntryField { get; set; }
        public string Luck_EntryField { get; set; }
        public string MRitualsEntryField { get; set; }
        public string MRituals_DB_EntryField { get; set; }
        public string MSpellsEntryField { get; set; }
        public string MSpells_DB_EntryField { get; set; }
        public string MTrapsEntryField { get; set; }
        public string MTraps_DB_EntryField { get; set; }
        public string MedicineEntryField { get; set; }
        public string Medicine_DB_EntryField { get; set; }
        public string MeleeEntryField { get; set; }
        public string Melee_DB_EntryField { get; set; }
        public string MonstrologyEntryField { get; set; }
        public string Monstrology_DB_EntryField { get; set; }
        public string NameEntryField { get; set; }
        public string NameWEntryField { get; set; }
        public string NameWEntryField2 { get; set; }
        public string NameWEntryField3 { get; set; }
        public string NotesEditor { get; set; }
        public string Orens_EntryField { get; set; }
        public string OrientationEntryField { get; set; }
        public string Orientation_DB_EntryField { get; set; }
        public string PerformanceEntryField { get; set; }
        public string Performance_DB_EntryField { get; set; }
        public string PorchaEntryField { get; set; }
        public string Porcha_DB_EntryField { get; set; }
        public string RConvictionEntryField { get; set; }
        public string RConviction_DB_EntryField { get; set; }
        public string RHD31AEntryField { get; set; }
        public string RHPB32AEntryField { get; set; }
        public string RLD42AEntryField { get; set; }
        public string RLPB52AEntryField { get; set; }
        public string RaceEntryField { get; set; }
        public string ReflexesEntryField { get; set; }
        public string RepairEntryField { get; set; }
        public string RestEntryField { get; set; }
        public string RunEntryField { get; set; }
        public string SailingEntryField { get; set; }
        public string Sailing_DB_EntryField { get; set; }
        public string SeductionEntryField { get; set; }
        public string Seduction_DB_EntryField { get; set; }
        public string SexEntryField { get; set; }
        public string ShootBowEntryField { get; set; }
        public string ShootCrossbowEntryField { get; set; }
        public string ShootCrossbow_DB_EntryField { get; set; }
        public string Shoot_Bow_DB_EntryField { get; set; }
        public string SleightEntryField { get; set; }
        public string Sleight_DB_EntryField { get; set; }
        public string SpeedEntryField { get; set; }
        public string StammEntryField { get; set; }
        public string Stamm_EntryField2 { get; set; }
        public string StealthEntryField { get; set; }
        public string Stealth_DB_EntryField { get; set; }
        public string StruggleEntryField { get; set; }
        public string Struggle_DB_EntryField { get; set; }
        public string SurvivalEntryField { get; set; }
        public string Survival_DB_EntryField { get; set; }
        public string SwordEntryField { get; set; }
        public string Sword_DB_EntryField { get; set; }
        public string TacticsEntryField { get; set; }
        public string Tactics_DB_EntryField { get; set; }
        public string TradeEntryField { get; set; }
        public string Trade_DB_EntryField { get; set; }
        public string TreeEntryField { get; set; }
        public string Tree_DB_EntryField { get; set; }
        public string UnderstandEntryField { get; set; }
        public string Understand_DB_EntryField { get; set; }
        public string WeightEntryField { get; set; }
        public string WeightWEntryField { get; set; }
        public string WeightWEntryField2 { get; set; }
        public string WeightWEntryField3 { get; set; }
        public string WillEntryField { get; set; }


        public string ToXml()
        {
            // Создание объекта XmlSerializer для класса CustomerXML
            XmlSerializer serializer = new XmlSerializer(typeof(CustomerXML));

            // Создание StringWriter для записи XML
            StringWriter writer = new StringWriter();

            // Сериализация объекта CustomerXML в XML и запись в StringWriter
            serializer.Serialize(writer, this);

            // Получение XML-строки
            string xmlString = writer.ToString();

            return xmlString;
        }

        public static CustomerXML FromXml(string xml)
        {
            // Создание объекта XmlSerializer для класса CustomerXML
            XmlSerializer serializer = new XmlSerializer(typeof(CustomerXML));

            // Создание StringReader для чтения XML
            StringReader reader = new StringReader(xml);

            // Десериализация XML в объект CustomerXML
            CustomerXML customer = (CustomerXML)serializer.Deserialize(reader);

            return customer;
        }
    }
}

