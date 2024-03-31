using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Security.AccessControl;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;
using System.Xml.Serialization;
using Microsoft.Maui.Controls;



namespace MauiApp7
{

    




    public partial class Wichard_Page_Main : ContentPage
    {

        
        public int count = 0;
        public  LocalDbService _dbService;
        public int _editCustomerID;



        private async void Refresh()
        {
            #region[Загрузка из БД]

            Player player33;
            _dbService = new LocalDbService();
            player33 = await _dbService.GetById(((MauiApp7.Player)this.Background.BindingContext).Id);

            #endregion

            #region[Заполнение данных из БД]



            #endregion

            #region[Заполнение данных из БД]

            nameEntryField.Text = "1";
            JobEntryField.Text = "1";
            RaceEntryField.Text = "1";
            SexEntryField.Text = "1";
            AgeEntryField.Text = "1";
            IntelligenceEntryField.Text = "1";
            ReflexesEntryField.Text = "1";
            DexterityEntryField.Text = "1";
            BodyEntryField.Text = "1";
            SpeedEntryField.Text = "1";
            EmpathyEntryField.Text = "1";
            RepairEntryField.Text = "1";
            WillEntryField.Text = "1";
            restEntryField.Text = "1";
            WeightEntryField.Text = "1";
            EnduranceEntryField.Text = "1";
            HPEntryField.Text = "1";
            JumpEntryField.Text = "1";
            RunEntryField.Text = "1";
            FatigueEntryField.Text = "1";
            LuckEntryField.Text = "1";
            HP_EntryField.Text = "1";
            Stamm_EntryField.Text = "1";
            Energy_EntryField.Text = "1";
            Luck_EntryField.Text = "1";
            Concentrat_EntryField.Text = "1";
            Adrenalin_EntryField.Text = "1";
            EXP_EntryField.Text = "1";
            Name_WEntryField.Text = "1";
            Accuracy_WEntryField.Text = "1";
            Damage_WEntryField.Text = "1";
            Durable_WEntryField.Text = "1";
            Grip_WEntryField.Text = "1";
            Dist_WEntryField.Text = "1";
            Effects_WEntryField.Text = "1";
            Hidden_WEntryField.Text = "1";
            Improvement_WEntryField.Text = "1";
            Weight_WEntryField.Text = "1";
            H_D_11_AEntryField.Text = "1";
            H_PB_12_AEntryField.Text = "1";
            B_D_21_AEntryField.Text = "1";
            B_PB_22_AEntryField.Text = "1";
            LH_D_34_AEntryField.Text = "1";
            LH_PB_35_AEntryField.Text = "1";
            RH_D_31_AEntryField.Text = "1";
            RH_PB_32_AEntryField.Text = "1";
            LL_D_14_AEntryField.Text = "1";
            LL_PB_15_AEntryField.Text = "1";
            RL_D_42_AEntryField.Text = "1";
            RL_PB_52_AEntryField.Text = "1";
            AttentionEntryField.Text = "1";
            Attention_DB_EntryField.Text = "1";
            Attention_I_EntryField.Text = "1";
            TradeEntryField.Text = "1";
            Trade_DB_EntryField.Text = "1";
            Trade_I_EntryField.Text = "1";
            DeductionEntryField.Text = "1";
            Deduction_DB_EntryField.Text = "1";
            Deduction_I_EntryField.Text = "1";
            EducationEntryField.Text = "1";
            Education_DB_EntryField.Text = "1";
            Education_I_EntryField.Text = "1";
            L_UniversalEntryField.Text = "1";
            L_Universal_DB_EntryField.Text = "1";
            L_Universal_I_EntryField.Text = "1";
            L_S_SEntryField.Text = "1";
            L_KEntryField.Text = "1";
            L_K_DB_EntryField.Text = "1";
            L_K_I_EntryField.Text = "1";
            MonstrologyEntryField.Text = "1";
            Monstrology_DB_EntryField.Text = "1";
            Monstrology_I_EntryField.Text = "1";
            EtiquetteEntryField.Text = "1";
            Etiquette_DB_EntryField.Text = "1";
            Etiquette_I_EntryField.Text = "1";
            OrientationEntryField.Text = "1";
            Orientation_DB_EntryField.Text = "1";
            Orientation_I_EntryField.Text = "1";
            TacticsEntryField.Text = "1";
            Tactics_DB_EntryField.Text = "1";
            Tactics_I_EntryField.Text = "1";
            KnowledgeEntryField.Text = "1";
            Knowledge_DB_EntryField.Text = "1";
            Knowledge_I_EntryField.Text = "1";
            SurvivalEntryField.Text = "1";
            Survival_DB_EntryField.Text = "1";
            Survival_I_EntryField.Text = "1";
            Shoot_BowEntryField.Text = "1";
            Shoot_Bow_DB_EntryField.Text = "1";
            Shoot_Bow_D_EntryField.Text = "1";
            AthleticsEntryField.Text = "1";
            Athletics_DB_EntryField.Text = "1";
            Athletics_D_EntryField.Text = "1";
            ShootCrossbowEntryField.Text = "1";
            ShootCrossbow_DB_EntryField.Text = "1";
            ShootCrossbow_D_EntryField.Text = "1";
            SleightEntryField.Text = "1";
            Sleight_DB_EntryField.Text = "1";
            Sleight_D_EntryField.Text = "1";
            StealthEntryField.Text = "1";
            Stealth_DB_EntryField.Text = "1";
            Stealth_D_EntryField.Text = "1";
            Alchemy_EntryField.Text = "1";
            Alchemy_DB_EntryField.Text = "1";
            Alchemy_C_EntryField.Text = "1";
            Crafting_EntryField.Text = "1";
            Crafting_DB_EntryField.Text = "1";
            Crafting_C_EntryField.Text = "1";
            Disguise_EntryField.Text = "1";
            Disguise_DB_EntryField.Text = "1";
            Disguise_C_EntryField.Text = "1";
            Medicine_EntryField.Text = "1";
            Medicine_DB_EntryField.Text = "1";
            Medicine_C_EntryField.Text = "1";
            Fake_EntryField.Text = "1";
            Fake_DB_EntryField.Text = "1";
            Fake_C_EntryField.Text = "1";
            Lockpicking_EntryField.Text = "1";
            Lockpicking_DB_EntryField.Text = "1";
            Lockpicking_C_EntryField.Text = "1";
            MTraps_EntryField.Text = "1";
            MTraps_DB_EntryField.Text = "1";
            MTraps_C_EntryField.Text = "1";
            ForceEntryField.Text = "1";
            Force_DB_EntryField.Text = "1";
            Force_I_EntryField.Text = "1";
            DurabilityEntryField.Text = "1";
            Durability_DB_EntryField.Text = "1";
            Durability_I_EntryField.Text = "1";
            Crons_EntryField.Text = "1";
            Orens_EntryField.Text = "1";
            Florens_EntryField.Text = "1";
            Struggle_EntryField.Text = "1";
            Struggle_DB_EntryField.Text = "1";
            Struggle_R_EntryField.Text = "1";
            Evasion_EntryField.Text = "1";
            Evasion_DB_EntryField.Text = "1";
            Evasion_R_EntryField.Text = "1";
            Melee_EntryField.Text = "1";
            Melee_DB_EntryField.Text = "1";
            Melee_R_EntryField.Text = "1";
            Horseback_EntryField.Text = "1";
            Horseback_DB_EntryField.Text = "1";
            Horseback_R_EntryField.Text = "1";
            Sailing_EntryField.Text = "1";
            Sailing_DB_EntryField.Text = "1";
            Sailing_R_EntryField.Text = "1";
            L_Blades_EntryField.Text = "1";
            L_R_DB_EntryField.Text = "1";
            TreeEntryField.Text = "1";
            Tree_DB_EntryField.Text = "1";
            Tree_R_EntryField.Text = "1";
            SwordEntryField.Text = "1";
            Sword_DB_EntryField.Text = "1";
            Sword_R_EntryField.Text = "1";
            Charisma_EntryField.Text = "1";
            Charisma_DB_EntryField.Text = "1";
            Charisma_E_EntryField.Text = "1";
            Deception_EntryField.Text = "1";
            Deception_DB_EntryField.Text = "1";
            Deception_E_EntryField.Text = "1";
            Art_EntryField.Text = "1";
            Art_DB_EntryField.Text = "1";
            Art_E_EntryField.Text = "1";
            Games_EntryField.Text = "1";
            Games_DB_EntryField.Text = "1";
            Games_E_EntryField.Text = "1";
            Appearance_EntryField.Text = "1";
            Appearance_DB_EntryField.Text = "1";
            Appearance_E_EntryField.Text = "1";
            Understand_EntryField.Text = "1";
            Understand_DB_EntryField.Text = "1";
            Understand_E_EntryField.Text = "1";
            Leadership_EntryField.Text = "1";
            Leadership_DB_EntryField.Text = "1";
            Leadership_E_EntryField.Text = "1";
            Belief_EntryField.Text = "1";
            Belief_DB_EntryField.Text = "1";
            Belief_E_EntryField.Text = "1";
            Performance_EntryField.Text = "1";
            Performance_DB_EntryField.Text = "1";
            Performance_E_EntryField.Text = "1";
            Seduction_EntryField.Text = "1";
            Seduction_DB_EntryField.Text = "1";
            Seduction_E_EntryField.Text = "1";
            Bravery_EntryField.Text = "1";
            Bravery_DB_EntryField.Text = "1";
            Bravery_W_EntryField.Text = "1";
            Porcha_EntryField.Text = "1";
            Porcha_DB_EntryField.Text = "1";
            Porcha_W_EntryField.Text = "1";
            Intimidation_EntryField.Text = "1";
            Intimidation_DB_EntryField.Text = "1";
            Intimidation_W_EntryField.Text = "1";
            MSpells_EntryField.Text = "1";
            MSpells_DB_EntryField.Text = "1";
            MSpells_W_EntryField.Text = "1";
            RConviction_EntryField.Text = "1";
            RConviction_DB_EntryField.Text = "1";
            RConviction_W_EntryField.Text = "1";
            MRituals_EntryField.Text = "1";
            MRituals_DB_EntryField.Text = "1";
            MRituals_W_EntryField.Text = "1";
            Equipment_Editor.Text = "1";
            Notes_Editor.Text = "1";
            restEntryField.Text = "1";
            WeightEntryField.Text = "1";
            EnduranceEntryField.Text = "1";
            HPEntryField.Text = "1";
            JumpEntryField.Text = "1";
            RunEntryField.Text = "1";
            FatigueEntryField.Text = "1";
            LuckEntryField.Text = "1";
            Appearance_DB_EntryField2.Text = "1";


            #endregion

            #region[Вычисление навыков]

            if (BodyEntryField.Text != null) { WeightEntryField.Text = String.Format("{0:D2}", (Int32.Parse(BodyEntryField.Text) * 10)); } //Вес Weight }
            if (RunEntryField.Text != null) { RunEntryField.Text = String.Format("{0:D2}", (Int32.Parse(SpeedEntryField.Text) * 3)); } //Бег run
            if (JumpEntryField.Text != null) { JumpEntryField.Text = String.Format("{0:D2}", (Int32.Parse(RunEntryField.Text) / 5)); } //Прыжок Jump

            if (HP_EntryField.Text == null | HP_EntryField.Text == "") { HP_EntryField.Text = HPEntryField.Text; } //ПЗ
            if (Stamm_EntryField.Text == null) { Stamm_EntryField.Text = EnduranceEntryField.Text; } //выносливость
            if (Luck_EntryField.Text == null) { Luck_EntryField.Text = LuckEntryField.Text; } //Удача

            WeightEntryField.Text = String.Format("{0:D2}", (Int32.Parse(BodyEntryField.Text) * 10));
            RunEntryField.Text = String.Format("{0:D2}", (Int32.Parse(SpeedEntryField.Text) * 3));
            JumpEntryField.Text = String.Format("{0:D2}", (Int32.Parse(RunEntryField.Text) / 5));

            switch ((Int32.Parse(BodyEntryField.Text) + Int32.Parse(WillEntryField.Text)) / 2)
            {
                case 1:
                    HPEntryField.Text = String.Format("{0:D2}", 10);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 10); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 2); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 2); //усталость
                    break;
                case 2:
                    HPEntryField.Text = String.Format("{0:D2}", 10);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 10); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 2); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 2); //усталость
                    break;
                case 3:
                    HPEntryField.Text = String.Format("{0:D2}", 15);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 15); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 3); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 3); //усталость
                    break;
                case 4:
                    HPEntryField.Text = String.Format("{0:D2}", 20);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 20); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 4); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 4); //усталость
                    break;
                case 5:
                    HPEntryField.Text = String.Format("{0:D2}", 25);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 25); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 5); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 5); //усталость
                    break;
                case 6:
                    HPEntryField.Text = String.Format("{0:D2}", 30);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 30); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 6); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 6); //усталость
                    break;
                case 7:
                    HPEntryField.Text = String.Format("{0:D2}", 35);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 35); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 7); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 7); //усталость
                    break;
                case 8:
                    HPEntryField.Text = String.Format("{0:D2}", 40);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 40); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 8); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 8); //усталость
                    break;
                case 9:
                    HPEntryField.Text = String.Format("{0:D2}", 45);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 45); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 9); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 9); //усталость
                    break;
                case 10:
                    HPEntryField.Text = String.Format("{0:D2}", 50);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 50); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 10); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 10); //усталость
                    break;
                case 11:
                    HPEntryField.Text = String.Format("{0:D2}", 55);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 55); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 11); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 10); //усталость
                    break;
                case 12:
                    HPEntryField.Text = String.Format("{0:D2}", 60);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 60); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 12); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 10); //усталость
                    break;
                case 13:
                    HPEntryField.Text = String.Format("{0:D2}", 65);  //ПЗ
                    EnduranceEntryField.Text = String.Format("{0:D2}", 65); //выносливость
                    restEntryField.Text = String.Format("{0:D2}", 13); //отдых
                    FatigueEntryField.Text = String.Format("{0:D2}", 10); //усталость
                    break;
                case > 13:
                    HPEntryField.Text = "слишком много";  //ПЗ
                    EnduranceEntryField.Text = "слишком много"; //выносливость
                    restEntryField.Text = "слишком много"; //отдых
                    FatigueEntryField.Text = "слишком много"; //усталость
                    break;

            }

            #endregion

            #region[Заполнение Основ навыков]

            Attention_I_EntryField.Text = IntelligenceEntryField.Text;
            Trade_I_EntryField.Text = IntelligenceEntryField.Text;
            Deduction_I_EntryField.Text = IntelligenceEntryField.Text;
            Education_I_EntryField.Text = IntelligenceEntryField.Text;
            L_Universal_I_EntryField.Text = IntelligenceEntryField.Text;
            L_K_I_EntryField.Text = IntelligenceEntryField.Text;
            Monstrology_I_EntryField.Text = IntelligenceEntryField.Text;
            Etiquette_I_EntryField.Text = IntelligenceEntryField.Text;
            Orientation_I_EntryField.Text = IntelligenceEntryField.Text;
            Tactics_I_EntryField.Text = IntelligenceEntryField.Text;
            Knowledge_I_EntryField.Text = IntelligenceEntryField.Text;
            Survival_I_EntryField.Text = IntelligenceEntryField.Text;

            Shoot_Bow_D_EntryField.Text = DexterityEntryField.Text;
            Athletics_D_EntryField.Text = DexterityEntryField.Text;
            ShootCrossbow_D_EntryField.Text = DexterityEntryField.Text;
            Sleight_D_EntryField.Text = DexterityEntryField.Text;
            Stealth_D_EntryField.Text = DexterityEntryField.Text;

            Alchemy_C_EntryField.Text = RepairEntryField.Text;
            Crafting_C_EntryField.Text = RepairEntryField.Text;
            Disguise_C_EntryField.Text = RepairEntryField.Text;
            Medicine_C_EntryField.Text = RepairEntryField.Text;
            Fake_C_EntryField.Text = RepairEntryField.Text;
            Lockpicking_C_EntryField.Text = RepairEntryField.Text;
            MTraps_C_EntryField.Text = RepairEntryField.Text;

            Force_I_EntryField.Text = BodyEntryField.Text;
            Durability_I_EntryField.Text = BodyEntryField.Text;

            Struggle_R_EntryField.Text = ReflexesEntryField.Text;
            Evasion_R_EntryField.Text = ReflexesEntryField.Text;
            Melee_R_EntryField.Text = ReflexesEntryField.Text;
            Horseback_R_EntryField.Text = ReflexesEntryField.Text;
            Sailing_R_EntryField.Text = ReflexesEntryField.Text;
            Tree_R_EntryField.Text = ReflexesEntryField.Text;
            Sword_R_EntryField.Text = ReflexesEntryField.Text;
            L_R_S.Text = ReflexesEntryField.Text;

            Charisma_E_EntryField.Text = EmpathyEntryField.Text;
            Deception_E_EntryField.Text = EmpathyEntryField.Text;
            Art_E_EntryField.Text = EmpathyEntryField.Text;
            Games_E_EntryField.Text = EmpathyEntryField.Text;
            Appearance_E_EntryField.Text = EmpathyEntryField.Text;
            Understand_E_EntryField.Text = EmpathyEntryField.Text;
            Leadership_E_EntryField.Text = EmpathyEntryField.Text;
            Belief_E_EntryField.Text = EmpathyEntryField.Text;
            Performance_E_EntryField.Text = EmpathyEntryField.Text;
            Seduction_E_EntryField.Text = EmpathyEntryField.Text;

            Bravery_W_EntryField.Text = WillEntryField.Text;
            Porcha_W_EntryField.Text = WillEntryField.Text;
            Intimidation_W_EntryField.Text = WillEntryField.Text;
            MSpells_W_EntryField.Text = WillEntryField.Text;
            RConviction_W_EntryField.Text = WillEntryField.Text;
            MRituals_W_EntryField.Text = WillEntryField.Text;
            Appearance_W_EntryField2.Text = WillEntryField.Text;

            #endregion

            int ad = 0;
        }



        private void RefreshButton_Clicked(object sender, System.EventArgs e)
        {
            //Wichard_load();

            

            

            Refresh();
        }

        public Wichard_Page_Main()
        {
            InitializeComponent();

            var screenWidth = DeviceDisplay.MainDisplayInfo.Width;

            Wichard_load();

            
        }
        
        const string DB_NAME = "demo_local_db.db3";
        public SQLiteAsyncConnection _connection;


        private async void ExportButton_Clicked(object sender, EventArgs e, INavigation navigation)
        {


        }



        void Weight_Calculation(object sender, System.EventArgs e)
        {

            string outputValue = String.Format("{0:D2}", (Int32.Parse(BodyEntryField.Text) * 10));

            WeightEntryField.Text = outputValue;
        }
        void Wichard_load()
        {

            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Player>();

            //if (BodyEntryField.Text != null) { WeightEntryField.Text = String.Format("{0:D2}", (Int32.Parse(BodyEntryField.Text) * 10)); } //Вес Weight }
            //if (RunEntryField.Text != null) { RunEntryField.Text = String.Format("{0:D2}", (Int32.Parse(SpeedEntryField.Text) * 3)); } //Бег run
            //if (JumpEntryField.Text != null) { JumpEntryField.Text = String.Format("{0:D2}", (Int32.Parse(RunEntryField.Text) / 5)); } //Прыжок Jump

            //if (HP_EntryField.Text != null) { HP_EntryField.Text = HPEntryField.Text; } //ПЗ
            //if (EnduranceEntryField.Text != null) { Stamm_EntryField.Text = EnduranceEntryField.Text; } //выносливость

            //Прыжок Jump

            //WeightEntryField.Text = String.Format("{0:D2}", (Int32.Parse(BodyEntryField.Text) * Int32.Parse(WillEntryField.Text) / 2)); //Вес Weight
            if (WillEntryField.Text != null)
            {
                WeightEntryField.Text = String.Format("{0:D2}", (Int32.Parse(BodyEntryField.Text) * 10));
                RunEntryField.Text = String.Format("{0:D2}", (Int32.Parse(SpeedEntryField.Text) * 3));
                JumpEntryField.Text = String.Format("{0:D2}", (Int32.Parse(RunEntryField.Text) / 5));

                Attention_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Trade_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Deduction_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Education_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                L_Universal_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                L_K_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Monstrology_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Etiquette_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Orientation_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Tactics_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Knowledge_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Survival_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
                Shoot_Bow_D_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DexterityEntryField;
                Athletics_D_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DexterityEntryField;
                ShootCrossbow_D_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DexterityEntryField;
                Sleight_D_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DexterityEntryField;
                Stealth_D_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DexterityEntryField;
                Alchemy_C_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RepairEntryField;
                Crafting_C_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RepairEntryField;
                Disguise_C_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RepairEntryField;
                Medicine_C_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RepairEntryField;
                Fake_C_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RepairEntryField;
                Lockpicking_C_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RepairEntryField;
                MTraps_C_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RepairEntryField;
                Force_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).BodyEntryField;
                Durability_I_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).BodyEntryField;
                Struggle_R_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
                Evasion_R_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
                Melee_R_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
                Horseback_R_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
                Sailing_R_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
                Tree_R_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
                Sword_R_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
                L_R_S.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
                Charisma_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Deception_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Art_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Games_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Appearance_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Understand_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Leadership_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Belief_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Performance_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Seduction_E_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
                Bravery_W_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WillEntryField;
                Porcha_W_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WillEntryField;
                Intimidation_W_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WillEntryField;
                MSpells_W_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WillEntryField;
                RConviction_W_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WillEntryField;
                MRituals_W_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WillEntryField;
                Equipment_Editor.Text = ((MauiApp7.Player)this.Background.BindingContext).EquipmentEditor;
                Appearance_W_EntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).WillEntryField;

                switch ((Int32.Parse(BodyEntryField.Text) + Int32.Parse(WillEntryField.Text)) / 2)
                {
                    case 1:
                        HPEntryField.Text = String.Format("{0:D2}", 10);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 10); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 2); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 2); //усталость
                        break;
                    case 2:
                        HPEntryField.Text = String.Format("{0:D2}", 10);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 10); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 2); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 2); //усталость
                        break;
                    case 3:
                        HPEntryField.Text = String.Format("{0:D2}", 15);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 15); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 3); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 3); //усталость
                        break;
                    case 4:
                        HPEntryField.Text = String.Format("{0:D2}", 20);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 20); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 4); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 4); //усталость
                        break;
                    case 5:
                        HPEntryField.Text = String.Format("{0:D2}", 25);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 25); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 5); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 5); //усталость
                        break;
                    case 6:
                        HPEntryField.Text = String.Format("{0:D2}", 30);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 30); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 6); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 6); //усталость
                        break;
                    case 7:
                        HPEntryField.Text = String.Format("{0:D2}", 35);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 35); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 7); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 7); //усталость
                        break;
                    case 8:
                        HPEntryField.Text = String.Format("{0:D2}", 40);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 40); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 8); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 8); //усталость
                        break;
                    case 9:
                        HPEntryField.Text = String.Format("{0:D2}", 45);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 45); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 9); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 9); //усталость
                        break;
                    case 10:
                        HPEntryField.Text = String.Format("{0:D2}", 50);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 50); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 10); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 10); //усталость
                        break;
                    case 11:
                        HPEntryField.Text = String.Format("{0:D2}", 55);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 55); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 11); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 10); //усталость
                        break;
                    case 12:
                        HPEntryField.Text = String.Format("{0:D2}", 60);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 60); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 12); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 10); //усталость
                        break;
                    case 13:
                        HPEntryField.Text = String.Format("{0:D2}", 65);  //ПЗ
                        EnduranceEntryField.Text = String.Format("{0:D2}", 65); //выносливость
                        restEntryField.Text = String.Format("{0:D2}", 13); //отдых
                        FatigueEntryField.Text = String.Format("{0:D2}", 10); //усталость
                        break;
                    case > 13:
                        HPEntryField.Text = "слишком много";  //ПЗ
                        EnduranceEntryField.Text = "слишком много"; //выносливость
                        restEntryField.Text = "слишком много"; //отдых
                        FatigueEntryField.Text = "слишком много"; //усталость
                        break;

                }
            }


            nameEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).NameEntryField;
            RaceEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RaceEntryField;
            SexEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).SexEntryField;
            AgeEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).AgeEntryField;
            IntelligenceEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
            string teststr = ((MauiApp7.Player)this.Background.BindingContext).IntelligenceEntryField;
            ReflexesEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ReflexesEntryField;
            DexterityEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DexterityEntryField;
            BodyEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).BodyEntryField;
            SpeedEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).SpeedEntryField;
            EmpathyEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EmpathyEntryField;
            RepairEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RepairEntryField;
            WillEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WillEntryField;
            restEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RestEntryField;
            WeightEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WeightEntryField;
            EnduranceEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EnduranceEntryField;
            HPEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).HPEntryField;
            JumpEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).JumpEntryField;
            RunEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RunEntryField;
            FatigueEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).FatigueEntryField;
            LuckEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LuckEntryField;
            //ImageEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ImageEntryField;
            HP_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).HP_EntryField2;
            Stamm_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).StammEntryField;
            Name_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).NameWEntryField;
            Name_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).NameWEntryField2;
            Name_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).NameWEntryField3;
            Accuracy_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).AccuracyWEntryField;
            Accuracy_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).AccuracyWEntryField2;
            Accuracy_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).AccuracyWEntryField3;
            Damage_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DamageWEntryField;
            Damage_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).DamageWEntryField2;
            Damage_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).DamageWEntryField3;
            Durable_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DurableWEntryField;
            Durable_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).DurableWEntryField2;
            Durable_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).DurableWEntryField3;
            Grip_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).GripWEntryField;
            Grip_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).GripWEntryField2;
            Grip_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).GripWEntryField3;
            Dist_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DistWEntryField;
            Dist_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).DistWEntryField2;
            Dist_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).DistWEntryField3;
            Effects_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EffectsWEntryField;
            Effects_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).EffectsWEntryField2;
            Effects_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).EffectsWEntryField3;
            Hidden_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).HiddenWEntryField;
            Hidden_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).HiddenWEntryField2;
            Hidden_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).HiddenWEntryField3;
            Improvement_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ImprovementWEntryField;
            Improvement_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).ImprovementWEntryField2;
            Improvement_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).ImprovementWEntryField3;
            Weight_WEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).WeightWEntryField;
            Weight_WEntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).WeightWEntryField2;
            Weight_WEntryField3.Text = ((MauiApp7.Player)this.Background.BindingContext).WeightWEntryField3;
            H_D_11_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).HD11AEntryField;
            H_PB_12_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).HPB12AEntryField;
            B_D_21_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).BD21AEntryField;
            B_PB_22_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).BPB22AEntryField;
            RH_D_31_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RHD31AEntryField;
            RH_PB_32_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RHPB32AEntryField;
            LL_D_14_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LLD14AEntryField;
            LL_PB_15_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LLPB15AEntryField;
            RL_D_42_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RLD42AEntryField;
            RL_PB_52_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RLPB52AEntryField;
            LH_D_34_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LHD34AEntryField;
            LH_PB_35_AEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LHPB35AEntryField;
            AttentionEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).AttentionEntryField;
            TradeEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).TradeEntryField;
            DeductionEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DeductionEntryField;
            EducationEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EducationEntryField;
            L_UniversalEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LUniversalEntryField;
            L_S_SEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LSSEntryField;
            L_KEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LKEntryField;
            MonstrologyEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MonstrologyEntryField;
            EtiquetteEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EtiquetteEntryField;
            OrientationEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).OrientationEntryField;
            TacticsEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).TacticsEntryField;
            KnowledgeEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).KnowledgeEntryField;
            SurvivalEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).SurvivalEntryField;
            Shoot_BowEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ShootBowEntryField;
            AthleticsEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).AthleticsEntryField;
            ShootCrossbowEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ShootCrossbowEntryField;
            SleightEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).SleightEntryField;
            StealthEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).StealthEntryField;
            Alchemy_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).AlchemyEntryField;
            Crafting_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).CraftingEntryField;
            Disguise_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DisguiseEntryField;
            Medicine_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MedicineEntryField;
            Fake_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).FakeEntryField;
            Lockpicking_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LockpickingEntryField;
            MTraps_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MTrapsEntryField;
            Equipment_Editor.Text = ((MauiApp7.Player)this.Background.BindingContext).EquipmentEditor;
            ForceEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ForceEntryField;
            DurabilityEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DurabilityEntryField;
            Struggle_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).StruggleEntryField;
            Evasion_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EvasionEntryField;
            Melee_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MeleeEntryField;
            Horseback_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).HorsebackEntryField;
            Sailing_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).SailingEntryField;
            L_Blades_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LBladesEntryField;
            TreeEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).TreeEntryField;
            SwordEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).SwordEntryField;
            Charisma_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).CharismaEntryField;
            Deception_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).DeceptionEntryField;
            Art_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ArtEntryField;
            Games_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).GamesEntryField;
            Appearance_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).AppearanceEntryField;
            Understand_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).UnderstandEntryField;
            Leadership_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).LeadershipEntryField;
            Belief_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).BeliefEntryField;
            Performance_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).PerformanceEntryField;
            Seduction_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).SeductionEntryField;
            Bravery_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).BraveryEntryField;
            Porcha_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).PorchaEntryField;
            Intimidation_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).IntimidationEntryField;
            MSpells_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MSpellsEntryField;
            Appearance_EntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).AppearanceEntryField2;
            RConviction_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RConvictionEntryField;
            MRituals_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MRitualsEntryField;
            Notes_Editor.Text = ((MauiApp7.Player)this.Background.BindingContext).NotesEditor;
            Attention_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Attention_DB_EntryField;
            Attention_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Attention_DB_EntryField;
            Trade_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Trade_DB_EntryField;
            Deduction_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Deduction_DB_EntryField;
            Education_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Education_DB_EntryField;
            L_Universal_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).L_Universal_DB_EntryField;
            Monstrology_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Monstrology_DB_EntryField;
            Etiquette_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Etiquette_DB_EntryField;
            Orientation_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Orientation_DB_EntryField;
            Tactics_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Tactics_DB_EntryField;
            Knowledge_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Knowledge_DB_EntryField;
            Survival_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Survival_DB_EntryField;
            Shoot_Bow_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Shoot_Bow_DB_EntryField;
            Athletics_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Athletics_DB_EntryField;
            ShootCrossbow_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).ShootCrossbow_DB_EntryField;
            Sleight_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Sleight_DB_EntryField;
            Stealth_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Stealth_DB_EntryField;
            Alchemy_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Alchemy_DB_EntryField;
            Crafting_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Crafting_DB_EntryField;
            Disguise_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Disguise_DB_EntryField;
            Medicine_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Medicine_DB_EntryField;
            Fake_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Fake_DB_EntryField;
            Lockpicking_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Lockpicking_DB_EntryField;
            MTraps_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MTraps_DB_EntryField;
            Force_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Force_DB_EntryField;
            Durability_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Durability_DB_EntryField;
            Struggle_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Struggle_DB_EntryField;
            Evasion_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Evasion_DB_EntryField;
            Melee_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Melee_DB_EntryField;
            Horseback_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Horseback_DB_EntryField;
            Sailing_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Sailing_DB_EntryField;
            L_R_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).L_R_DB_EntryField;
            Tree_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Tree_DB_EntryField;
            Sword_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Sword_DB_EntryField;
            Charisma_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Charisma_DB_EntryField;
            Deception_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Deception_DB_EntryField;
            Art_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Art_DB_EntryField;
            Games_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Games_DB_EntryField;
            Appearance_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Appearance_DB_EntryField;
            Understand_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Understand_DB_EntryField;
            Leadership_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Leadership_DB_EntryField;
            Belief_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Belief_DB_EntryField;
            Performance_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Performance_DB_EntryField;
            Seduction_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Seduction_DB_EntryField;
            Bravery_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Bravery_DB_EntryField;
            Porcha_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Porcha_DB_EntryField;
            Intimidation_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Intimidation_DB_EntryField;
            MSpells_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MSpells_DB_EntryField;
            Appearance_DB_EntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).Appearance_DB_EntryField2;
            RConviction_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).RConviction_DB_EntryField;
            MRituals_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).MRituals_DB_EntryField;
            L_S_DB.Text = ((MauiApp7.Player)this.Background.BindingContext).L_S_DB;
            L_K_DB_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).L_K_DB_EntryField;
            Crons_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Crons_EntryField;
            Orens_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Orens_EntryField;
            Florens_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Florens_EntryField;
            //HP_EntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).HP_EntryField2;
            //Stamm_EntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).Stamm_EntryField2;
            Energy_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Energy_EntryField;
            //Energy_EntryField2.Text = ((MauiApp7.Player)this.Background.BindingContext).Energy_EntryField2;
            EXP_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).EXP_EntryField;

            JobEntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).JobEntryField; 
            Adrenalin_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Adrenalin_EntryField;
            //Adrenalin2_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Adrenalin2_EntryField;
            Concentrat_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Concentrat_EntryField;
            //Concentrat2_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Concentrat2_EntryField;
            Luck_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Luck_EntryField;
            //Luck2_EntryField.Text = ((MauiApp7.Player)this.Background.BindingContext).Luck2_EntryField;





        }

        //public async void List_test_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
            
        //    var Player = (Player)e.Item;
            

        //    var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");
        //    switch (action)
        //    {
        //        case "Edit":
        //            _editCustomerID = Player.Id;
        //            nameEntryField.Text = Player.NameEntryField;
        //            RaceEntryField.Text = Player.RaceEntryField; SexEntryField.Text = Player.SexEntryField;
        //            break;

        //        case "Delete":
        //            await _dbService.Delete(Player);
        //            //List_test.ItemsSource = await _dbService.GetCustomers();
        //            break;
        //    }
        //}




        DateTime dateTime = new DateTime();
        private async void saveButton_Clicked(object sender, EventArgs e)
        {

            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));

            if (_editCustomerID == 0)
            {
                // Add Customer
                await _connection.InsertAsync(new Player
                {

                    DataEntryField= DateTime.Now,
                    NameEntryField = nameEntryField.Text,
                    RaceEntryField = RaceEntryField.Text,
                    SexEntryField = SexEntryField.Text,
                    AgeEntryField = AgeEntryField.Text,
                    IntelligenceEntryField = IntelligenceEntryField.Text,
                    ReflexesEntryField = ReflexesEntryField.Text,
                    DexterityEntryField = DexterityEntryField.Text,
                    BodyEntryField = BodyEntryField.Text,
                    SpeedEntryField = SpeedEntryField.Text,
                    EmpathyEntryField = EmpathyEntryField.Text,
                    RepairEntryField = RepairEntryField.Text,
                    WillEntryField = WillEntryField.Text,
                    RestEntryField = restEntryField.Text,
                    WeightEntryField = WeightEntryField.Text,
                    EnduranceEntryField = EnduranceEntryField.Text,
                    HPEntryField = HPEntryField.Text,
                    JumpEntryField = JumpEntryField.Text,
                    RunEntryField = RunEntryField.Text,
                    FatigueEntryField = FatigueEntryField.Text,
                    LuckEntryField = LuckEntryField.Text,
                    //ImageEntryField = ImageEntryField.Text,
                    HPEntryField2 = HP_EntryField.Text,
                    StammEntryField = Stamm_EntryField.Text,
                    NameWEntryField = Name_WEntryField.Text,
                    NameWEntryField2 = Name_WEntryField2.Text,
                    NameWEntryField3 = Name_WEntryField3.Text,
                    AccuracyWEntryField = Accuracy_WEntryField.Text,
                    AccuracyWEntryField2 = Accuracy_WEntryField2.Text,
                    AccuracyWEntryField3 = Accuracy_WEntryField3.Text,
                    DamageWEntryField = Damage_WEntryField.Text,
                    DamageWEntryField2 = Damage_WEntryField2.Text,
                    DamageWEntryField3 = Damage_WEntryField3.Text,
                    DurableWEntryField = Durable_WEntryField.Text,
                    DurableWEntryField2 = Durable_WEntryField2.Text,
                    DurableWEntryField3 = Durable_WEntryField3.Text,
                    GripWEntryField = Grip_WEntryField.Text,
                    GripWEntryField2 = Grip_WEntryField2.Text,
                    GripWEntryField3 = Grip_WEntryField3.Text,
                    DistWEntryField = Dist_WEntryField.Text,
                    DistWEntryField2 = Dist_WEntryField2.Text,
                    DistWEntryField3 = Dist_WEntryField3.Text,
                    EffectsWEntryField = Effects_WEntryField.Text,
                    EffectsWEntryField2 = Effects_WEntryField2.Text,
                    EffectsWEntryField3 = Effects_WEntryField3.Text,
                    HiddenWEntryField = Hidden_WEntryField.Text,
                    HiddenWEntryField2 = Hidden_WEntryField2.Text,
                    HiddenWEntryField3 = Hidden_WEntryField3.Text,
                    ImprovementWEntryField = Improvement_WEntryField.Text,
                    ImprovementWEntryField2 = Improvement_WEntryField2.Text,
                    ImprovementWEntryField3 = Improvement_WEntryField3.Text,
                    WeightWEntryField = Weight_WEntryField.Text,
                    WeightWEntryField2 = Weight_WEntryField2.Text,
                    WeightWEntryField3 = Weight_WEntryField3.Text,
                    HD11AEntryField = H_D_11_AEntryField.Text,
                    HPB12AEntryField = H_PB_12_AEntryField.Text,
                    BD21AEntryField = B_D_21_AEntryField.Text,
                    BPB22AEntryField = B_PB_22_AEntryField.Text,
                    RHD31AEntryField = RH_D_31_AEntryField.Text,
                    RHPB32AEntryField = RH_PB_32_AEntryField.Text,
                    LLD14AEntryField = LL_D_14_AEntryField.Text,
                    LLPB15AEntryField = LL_PB_15_AEntryField.Text,
                    RLD42AEntryField = RL_D_42_AEntryField.Text,
                    RLPB52AEntryField = RL_PB_52_AEntryField.Text,
                    LHD34AEntryField = LH_D_34_AEntryField.Text,
                    LHPB35AEntryField = LH_PB_35_AEntryField.Text,
                    AttentionEntryField = AttentionEntryField.Text,
                    TradeEntryField = TradeEntryField.Text,
                    DeductionEntryField = DeductionEntryField.Text,
                    EducationEntryField = EducationEntryField.Text,
                    LUniversalEntryField = L_UniversalEntryField.Text,
                    LSSEntryField = L_S_SEntryField.Text,
                    LKEntryField = L_KEntryField.Text,
                    MonstrologyEntryField = MonstrologyEntryField.Text,
                    EtiquetteEntryField = EtiquetteEntryField.Text,
                    OrientationEntryField = OrientationEntryField.Text,
                    TacticsEntryField = TacticsEntryField.Text,
                    KnowledgeEntryField = KnowledgeEntryField.Text,
                    SurvivalEntryField = SurvivalEntryField.Text,
                    ShootBowEntryField = Shoot_BowEntryField.Text,
                    AthleticsEntryField = AthleticsEntryField.Text,
                    ShootCrossbowEntryField = ShootCrossbowEntryField.Text,
                    SleightEntryField = SleightEntryField.Text,
                    StealthEntryField = StealthEntryField.Text,
                    AlchemyEntryField = Alchemy_EntryField.Text,
                    CraftingEntryField = Crafting_EntryField.Text,
                    DisguiseEntryField = Disguise_EntryField.Text,
                    MedicineEntryField = Medicine_EntryField.Text,
                    FakeEntryField = Fake_EntryField.Text,
                    LockpickingEntryField = Lockpicking_EntryField.Text,
                    MTrapsEntryField = MTraps_EntryField.Text,
                    EquipmentEditor = Equipment_Editor.Text,
                    ForceEntryField = ForceEntryField.Text,
                    DurabilityEntryField = DurabilityEntryField.Text,
                    StruggleEntryField = Struggle_EntryField.Text,
                    EvasionEntryField = Evasion_EntryField.Text,
                    MeleeEntryField = Melee_EntryField.Text,
                    HorsebackEntryField = Horseback_EntryField.Text,
                    SailingEntryField = Sailing_EntryField.Text,
                    LBladesEntryField = L_Blades_EntryField.Text,
                    TreeEntryField = TreeEntryField.Text,
                    SwordEntryField = SwordEntryField.Text,
                    CharismaEntryField = Charisma_EntryField.Text,
                    DeceptionEntryField = Deception_EntryField.Text,
                    ArtEntryField = Art_EntryField.Text,
                    GamesEntryField = Games_EntryField.Text,
                    AppearanceEntryField = Appearance_EntryField.Text,
                    UnderstandEntryField = Understand_EntryField.Text,
                    LeadershipEntryField = Leadership_EntryField.Text,
                    BeliefEntryField = Belief_EntryField.Text,
                    PerformanceEntryField = Performance_EntryField.Text,
                    SeductionEntryField = Seduction_EntryField.Text,
                    BraveryEntryField = Bravery_EntryField.Text,
                    PorchaEntryField = Porcha_EntryField.Text,
                    IntimidationEntryField = Intimidation_EntryField.Text,
                    MSpellsEntryField = MSpells_EntryField.Text,
                    AppearanceEntryField2 = Appearance_EntryField2.Text,
                    RConvictionEntryField = RConviction_EntryField.Text,
                    MRitualsEntryField = MRituals_EntryField.Text,
                    NotesEditor = Notes_Editor.Text,
                    Attention_DB_EntryField = Attention_DB_EntryField.Text,
                    Trade_DB_EntryField = Trade_DB_EntryField.Text,
                    Deduction_DB_EntryField = Deduction_DB_EntryField.Text,
                    Education_DB_EntryField = Education_DB_EntryField.Text,
                    L_Universal_DB_EntryField = L_Universal_DB_EntryField.Text,
                    Monstrology_DB_EntryField = Monstrology_DB_EntryField.Text,
                    Etiquette_DB_EntryField = Etiquette_DB_EntryField.Text,
                    Orientation_DB_EntryField = Orientation_DB_EntryField.Text,
                    Tactics_DB_EntryField = Tactics_DB_EntryField.Text,
                    Knowledge_DB_EntryField = Knowledge_DB_EntryField.Text,
                    Survival_DB_EntryField = Survival_DB_EntryField.Text,
                    Shoot_Bow_DB_EntryField = Shoot_Bow_DB_EntryField.Text,
                    Athletics_DB_EntryField = Athletics_DB_EntryField.Text,
                    ShootCrossbow_DB_EntryField = ShootCrossbow_DB_EntryField.Text,
                    Sleight_DB_EntryField = Sleight_DB_EntryField.Text,
                    Stealth_DB_EntryField = Stealth_DB_EntryField.Text,
                    Alchemy_DB_EntryField = Alchemy_DB_EntryField.Text,
                    Crafting_DB_EntryField = Crafting_DB_EntryField.Text,
                    Disguise_DB_EntryField = Disguise_DB_EntryField.Text,
                    Medicine_DB_EntryField = Medicine_DB_EntryField.Text,
                    Fake_DB_EntryField = Fake_DB_EntryField.Text,
                    Lockpicking_DB_EntryField = Lockpicking_DB_EntryField.Text,
                    MTraps_DB_EntryField = MTraps_DB_EntryField.Text,
                    Force_DB_EntryField = Force_DB_EntryField.Text,
                    Durability_DB_EntryField = Durability_DB_EntryField.Text,
                    Struggle_DB_EntryField = Struggle_DB_EntryField.Text,
                    Evasion_DB_EntryField = Evasion_DB_EntryField.Text,
                    Melee_DB_EntryField = Melee_DB_EntryField.Text,
                    Horseback_DB_EntryField = Horseback_DB_EntryField.Text,
                    Sailing_DB_EntryField = Sailing_DB_EntryField.Text,
                    L_R_DB_EntryField = L_R_DB_EntryField.Text,
                    Tree_DB_EntryField = Tree_DB_EntryField.Text,
                    Sword_DB_EntryField = Sword_DB_EntryField.Text,
                    Charisma_DB_EntryField = Charisma_DB_EntryField.Text,
                    Deception_DB_EntryField = Deception_DB_EntryField.Text,
                    Art_DB_EntryField = Art_DB_EntryField.Text,
                    Games_DB_EntryField = Games_DB_EntryField.Text,
                    Appearance_DB_EntryField = Appearance_DB_EntryField.Text,
                    Understand_DB_EntryField = Understand_DB_EntryField.Text,
                    Leadership_DB_EntryField = Leadership_DB_EntryField.Text,
                    Belief_DB_EntryField = Belief_DB_EntryField.Text,
                    Performance_DB_EntryField = Performance_DB_EntryField.Text,
                    Seduction_DB_EntryField = Seduction_DB_EntryField.Text,
                    Bravery_DB_EntryField = Bravery_DB_EntryField.Text,
                    Porcha_DB_EntryField = Porcha_DB_EntryField.Text,
                    Intimidation_DB_EntryField = Intimidation_DB_EntryField.Text,
                    MSpells_DB_EntryField = MSpells_DB_EntryField.Text,
                    Appearance_DB_EntryField2 = Appearance_DB_EntryField2.Text,
                    RConviction_DB_EntryField = RConviction_DB_EntryField.Text,
                    MRituals_DB_EntryField = MRituals_DB_EntryField.Text,
                    L_S_DB = L_S_DB.Text,
                    L_K_DB_EntryField = L_K_DB_EntryField.Text,
                    Crons_EntryField = Crons_EntryField.Text,
                    Orens_EntryField = Orens_EntryField.Text,
                    Florens_EntryField = Florens_EntryField.Text,
                    Stamm_EntryField2 = "",
                    Energy_EntryField = Energy_EntryField.Text,
                    Energy_EntryField2 = "",
                    EXP_EntryField = EXP_EntryField.Text,

                    JobEntryField = JobEntryField.Text,
                    Adrenalin_EntryField = Adrenalin_EntryField.Text,
                    Adrenalin2_EntryField = "",
                    Concentrat_EntryField = Concentrat_EntryField.Text,
                    Concentrat2_EntryField = "",
                    Luck_EntryField = Luck_EntryField.Text,
                    Luck2_EntryField = "",
                    


                });
            }
            else
            {
                // Edit Customer
                await _connection.UpdateAsync(new Player
                {
                    DataEntryField = DateTime.Now,
                    NameEntryField = nameEntryField.Text,
                    RaceEntryField = RaceEntryField.Text,
                    SexEntryField = SexEntryField.Text,
                    AgeEntryField = AgeEntryField.Text,
                    IntelligenceEntryField = IntelligenceEntryField.Text,
                    ReflexesEntryField = ReflexesEntryField.Text,
                    DexterityEntryField = DexterityEntryField.Text,
                    BodyEntryField = BodyEntryField.Text,
                    SpeedEntryField = SpeedEntryField.Text,
                    EmpathyEntryField = EmpathyEntryField.Text,
                    RepairEntryField = RepairEntryField.Text,
                    WillEntryField = WillEntryField.Text,
                    RestEntryField = restEntryField.Text,
                    WeightEntryField = WeightEntryField.Text,
                    EnduranceEntryField = EnduranceEntryField.Text,
                    HPEntryField2 = HPEntryField.Text,
                    JumpEntryField = JumpEntryField.Text,
                    RunEntryField = RunEntryField.Text,
                    FatigueEntryField = FatigueEntryField.Text,
                    LuckEntryField = LuckEntryField.Text,
                    //ImageEntryField = ImageEntryField.Text,
                    HPEntryField = HP_EntryField.Text,
                    StammEntryField = Stamm_EntryField.Text,
                    NameWEntryField = Name_WEntryField.Text,
                    NameWEntryField2 = Name_WEntryField2.Text,
                    NameWEntryField3 = Name_WEntryField3.Text,
                    AccuracyWEntryField = Accuracy_WEntryField.Text,
                    AccuracyWEntryField2 = Accuracy_WEntryField2.Text,
                    AccuracyWEntryField3 = Accuracy_WEntryField3.Text,
                    DamageWEntryField = Damage_WEntryField.Text,
                    DamageWEntryField2 = Damage_WEntryField2.Text,
                    DamageWEntryField3 = Damage_WEntryField3.Text,
                    DurableWEntryField = Durable_WEntryField.Text,
                    DurableWEntryField2 = Durable_WEntryField2.Text,
                    DurableWEntryField3 = Durable_WEntryField3.Text,
                    GripWEntryField = Grip_WEntryField.Text,
                    GripWEntryField2 = Grip_WEntryField2.Text,
                    GripWEntryField3 = Grip_WEntryField3.Text,
                    DistWEntryField = Dist_WEntryField.Text,
                    DistWEntryField2 = Dist_WEntryField2.Text,
                    DistWEntryField3 = Dist_WEntryField3.Text,
                    EffectsWEntryField = Effects_WEntryField.Text,
                    EffectsWEntryField2 = Effects_WEntryField2.Text,
                    EffectsWEntryField3 = Effects_WEntryField3.Text,
                    HiddenWEntryField = Hidden_WEntryField.Text,
                    HiddenWEntryField2 = Hidden_WEntryField2.Text,
                    HiddenWEntryField3 = Hidden_WEntryField3.Text,
                    ImprovementWEntryField = Improvement_WEntryField.Text,
                    ImprovementWEntryField2 = Improvement_WEntryField2.Text,
                    ImprovementWEntryField3 = Improvement_WEntryField3.Text,
                    WeightWEntryField = Weight_WEntryField.Text,
                    WeightWEntryField2 = Weight_WEntryField2.Text,
                    WeightWEntryField3 = Weight_WEntryField3.Text,
                    HD11AEntryField = H_D_11_AEntryField.Text,
                    HPB12AEntryField = H_PB_12_AEntryField.Text,
                    BD21AEntryField = B_D_21_AEntryField.Text,
                    BPB22AEntryField = B_PB_22_AEntryField.Text,
                    RHD31AEntryField = RH_D_31_AEntryField.Text,
                    RHPB32AEntryField = RH_PB_32_AEntryField.Text,
                    LLD14AEntryField = LL_D_14_AEntryField.Text,
                    LLPB15AEntryField = LL_PB_15_AEntryField.Text,
                    RLD42AEntryField = RL_D_42_AEntryField.Text,
                    RLPB52AEntryField = RL_PB_52_AEntryField.Text,
                    LHD34AEntryField = LH_D_34_AEntryField.Text,
                    LHPB35AEntryField = LH_PB_35_AEntryField.Text,
                    AttentionEntryField = AttentionEntryField.Text,
                    TradeEntryField = TradeEntryField.Text,
                    DeductionEntryField = DeductionEntryField.Text,
                    EducationEntryField = EducationEntryField.Text,
                    LUniversalEntryField = L_UniversalEntryField.Text,
                    LSSEntryField = L_S_SEntryField.Text,
                    LKEntryField = L_KEntryField.Text,
                    MonstrologyEntryField = MonstrologyEntryField.Text,
                    EtiquetteEntryField = EtiquetteEntryField.Text,
                    OrientationEntryField = OrientationEntryField.Text,
                    TacticsEntryField = TacticsEntryField.Text,
                    KnowledgeEntryField = KnowledgeEntryField.Text,
                    SurvivalEntryField = SurvivalEntryField.Text,
                    ShootBowEntryField = Shoot_BowEntryField.Text,
                    AthleticsEntryField = AthleticsEntryField.Text,
                    ShootCrossbowEntryField = ShootCrossbowEntryField.Text,
                    SleightEntryField = SleightEntryField.Text,
                    StealthEntryField = StealthEntryField.Text,
                    AlchemyEntryField = Alchemy_EntryField.Text,
                    CraftingEntryField = Crafting_EntryField.Text,
                    DisguiseEntryField = Disguise_EntryField.Text,
                    MedicineEntryField = Medicine_EntryField.Text,
                    FakeEntryField = Fake_EntryField.Text,
                    LockpickingEntryField = Lockpicking_EntryField.Text,
                    MTrapsEntryField = MTraps_EntryField.Text,
                    EquipmentEditor = Equipment_Editor.Text,
                    ForceEntryField = ForceEntryField.Text,
                    DurabilityEntryField = DurabilityEntryField.Text,
                    StruggleEntryField = Struggle_EntryField.Text,
                    EvasionEntryField = Evasion_EntryField.Text,
                    MeleeEntryField = Melee_EntryField.Text,
                    HorsebackEntryField = Horseback_EntryField.Text,
                    SailingEntryField = Sailing_EntryField.Text,
                    LBladesEntryField = L_Blades_EntryField.Text,
                    TreeEntryField = TreeEntryField.Text,
                    SwordEntryField = SwordEntryField.Text,
                    CharismaEntryField = Charisma_EntryField.Text,
                    DeceptionEntryField = Deception_EntryField.Text,
                    ArtEntryField = Art_EntryField.Text,
                    GamesEntryField = Games_EntryField.Text,
                    AppearanceEntryField = Appearance_EntryField.Text,
                    UnderstandEntryField = Understand_EntryField.Text,
                    LeadershipEntryField = Leadership_EntryField.Text,
                    BeliefEntryField = Belief_EntryField.Text,
                    PerformanceEntryField = Performance_EntryField.Text,
                    SeductionEntryField = Seduction_EntryField.Text,
                    BraveryEntryField = Bravery_EntryField.Text,
                    PorchaEntryField = Porcha_EntryField.Text,
                    IntimidationEntryField = Intimidation_EntryField.Text,
                    MSpellsEntryField = MSpells_EntryField.Text,
                    AppearanceEntryField2 = Appearance_EntryField2.Text,
                    RConvictionEntryField = RConviction_EntryField.Text,
                    MRitualsEntryField = MRituals_EntryField.Text,
                    NotesEditor = Notes_Editor.Text,
                    Attention_DB_EntryField = Attention_DB_EntryField.Text,
                    Trade_DB_EntryField = Trade_DB_EntryField.Text,
                    Deduction_DB_EntryField = Deduction_DB_EntryField.Text,
                    Education_DB_EntryField = Education_DB_EntryField.Text,
                    L_Universal_DB_EntryField = L_Universal_DB_EntryField.Text,
                    Monstrology_DB_EntryField = Monstrology_DB_EntryField.Text,
                    Etiquette_DB_EntryField = Etiquette_DB_EntryField.Text,
                    Orientation_DB_EntryField = Orientation_DB_EntryField.Text,
                    Tactics_DB_EntryField = Tactics_DB_EntryField.Text,
                    Knowledge_DB_EntryField = Knowledge_DB_EntryField.Text,
                    Survival_DB_EntryField = Survival_DB_EntryField.Text,
                    Shoot_Bow_DB_EntryField = Shoot_Bow_DB_EntryField.Text,
                    Athletics_DB_EntryField = Athletics_DB_EntryField.Text,
                    ShootCrossbow_DB_EntryField = ShootCrossbow_DB_EntryField.Text,
                    Sleight_DB_EntryField = Sleight_DB_EntryField.Text,
                    Stealth_DB_EntryField = Stealth_DB_EntryField.Text,
                    Alchemy_DB_EntryField = Alchemy_DB_EntryField.Text,
                    Crafting_DB_EntryField = Crafting_DB_EntryField.Text,
                    Disguise_DB_EntryField = Disguise_DB_EntryField.Text,
                    Medicine_DB_EntryField = Medicine_DB_EntryField.Text,
                    Fake_DB_EntryField = Fake_DB_EntryField.Text,
                    Lockpicking_DB_EntryField = Lockpicking_DB_EntryField.Text,
                    MTraps_DB_EntryField = MTraps_DB_EntryField.Text,
                    Force_DB_EntryField = Force_DB_EntryField.Text,
                    Durability_DB_EntryField = Durability_DB_EntryField.Text,
                    Struggle_DB_EntryField = Struggle_DB_EntryField.Text,
                    Evasion_DB_EntryField = Evasion_DB_EntryField.Text,
                    Melee_DB_EntryField = Melee_DB_EntryField.Text,
                    Horseback_DB_EntryField = Horseback_DB_EntryField.Text,
                    Sailing_DB_EntryField = Sailing_DB_EntryField.Text,
                    L_R_DB_EntryField = L_R_DB_EntryField.Text,
                    Tree_DB_EntryField = Tree_DB_EntryField.Text,
                    Sword_DB_EntryField = Sword_DB_EntryField.Text,
                    Charisma_DB_EntryField = Charisma_DB_EntryField.Text,
                    Deception_DB_EntryField = Deception_DB_EntryField.Text,
                    Art_DB_EntryField = Art_DB_EntryField.Text,
                    Games_DB_EntryField = Games_DB_EntryField.Text,
                    Appearance_DB_EntryField = Appearance_DB_EntryField.Text,
                    Understand_DB_EntryField = Understand_DB_EntryField.Text,
                    Leadership_DB_EntryField = Leadership_DB_EntryField.Text,
                    Belief_DB_EntryField = Belief_DB_EntryField.Text,
                    Performance_DB_EntryField = Performance_DB_EntryField.Text,
                    Seduction_DB_EntryField = Seduction_DB_EntryField.Text,
                    Bravery_DB_EntryField = Bravery_DB_EntryField.Text,
                    Porcha_DB_EntryField = Porcha_DB_EntryField.Text,
                    Intimidation_DB_EntryField = Intimidation_DB_EntryField.Text,
                    MSpells_DB_EntryField = MSpells_DB_EntryField.Text,
                    Appearance_DB_EntryField2 = Appearance_DB_EntryField2.Text,
                    RConviction_DB_EntryField = RConviction_DB_EntryField.Text,
                    MRituals_DB_EntryField = MRituals_DB_EntryField.Text,
                    L_S_DB = L_S_DB.Text,
                    L_K_DB_EntryField = L_K_DB_EntryField.Text,
                    Crons_EntryField = Crons_EntryField.Text,
                    Orens_EntryField = Orens_EntryField.Text,
                    Florens_EntryField = Florens_EntryField.Text,
                    Stamm_EntryField2 = "",
                    Energy_EntryField = Energy_EntryField.Text,
                    Energy_EntryField2 = "",
                    EXP_EntryField = EXP_EntryField.Text,

                    JobEntryField = JobEntryField.Text,
                    Adrenalin_EntryField = Adrenalin_EntryField.Text,
                    Adrenalin2_EntryField = "",
                    Concentrat_EntryField = Concentrat_EntryField.Text,
                    Concentrat2_EntryField = "",
                    Luck_EntryField = Luck_EntryField.Text,
                    Luck2_EntryField = "",




                });
                _editCustomerID = 0;
            }
            DateTime DatatestEntryField = dateTime;
            nameEntryField.Text = string.Empty;
            RaceEntryField.Text = string.Empty;
            SexEntryField.Text = string.Empty;
        }


        #region [Увеличение и уменьшение значения в блоке реакции]


        private bool decreaseButtonPressed = false;
        private const int LongPressDurationMilliseconds = 500;
        private void IncreaseButton_Clicked2(object sender, EventArgs e)
        {
            if (sender is Button button && button.Parent is HorizontalStackLayout stackLayout)
            {
                var entry = stackLayout.Children.FirstOrDefault(child => child is Entry) as Entry;
                if (entry != null && int.TryParse(entry.Text, out int value))
                {
                    entry.Text = (value + 1).ToString();
                }
            }
        }

        private void DecreaseButton_Clicked2(object sender, EventArgs e)
        {
            if (sender is Button button && button.Parent is HorizontalStackLayout stackLayout)
            {
                var entry = stackLayout.Children.FirstOrDefault(child => child is Entry) as Entry;
                if (entry != null && int.TryParse(entry.Text, out int value))
                {
                    entry.Text = (value - 1).ToString();
                }
            }
        }

        #region[долгое Уменьшение]
        private async void  DecreaseButton_Pressed(object sender, EventArgs e)
        {
            decreaseButtonPressed = true;

            Device.StartTimer(TimeSpan.FromMilliseconds(LongPressDurationMilliseconds), () =>
            {
                if (decreaseButtonPressed)
                {
                    // Возвращаем false, чтобы таймер не запускался снова
                    return false;
                }
                else
                {
                    // Если кнопка больше не нажата, останавливаем таймер
                    return false;
                }
            });
        }

        #region

        public class InputDialogPage : ContentPage
        {
            private Entry inputEntry;
            private Button okButton;

            public string InputValue { get; private set; }

            public InputDialogPage()
            {
                Title = "Input Dialog";

                inputEntry = new Entry();
                okButton = new Button { Text = "OK" };
                okButton.Clicked += OnOKButtonClicked;

                Content = new StackLayout
                {
                    Padding = new Thickness(20),
                    Children = {
                    new Label { Text = "Введите значение:" },
                    inputEntry,
                    okButton
                }
                };
            }

            private async void OnOKButtonClicked(object sender, EventArgs e)
            {
                InputValue = inputEntry.Text;
                await Navigation.PopModalAsync();
            }

            public async Task<string> WaitForInputAsync()
            {
                await Navigation.PushModalAsync(this);
                await Task.Delay(100); // Чтобы дать время для отображения страницы
                await Task.Run(() =>
                {
                    while (InputValue == null)
                    {
                        // Ожидаем ввода значения
                    }
                });
                return InputValue;
            }
        }
        #endregion

        private async Task<int> Decreasemsgbox()
        {
            // Сброс флага при отпускании кнопки



            //int result = (Int32.Parse(result1));
            int result = 0;
            return result;
        }
        private void DecreaseButton_Released(object sender, EventArgs e)
        {
            // Сброс флага при отпускании кнопки
            decreaseButtonPressed = false;
        }


        #endregion


        #region[долгое Увеличение]
        private void IncreaseButton_Pressed(object sender, EventArgs e)
        {
            // Установка флага, что кнопка нажата
            decreaseButtonPressed = true;

            // Запуск таймера для определения долгого нажатия
            Device.StartTimer(TimeSpan.FromMilliseconds(LongPressDurationMilliseconds), () =>
            {
                if (decreaseButtonPressed)
                {
                    DisplayAlert("Увеличение", "Увеличение.", "OK");
                    
                    // Действие, выполняемое при долгом нажатии
                    // Например, уменьшить значение поля NumberEntry
                }
                return false; // Возвращаем false, чтобы таймер остановился после первого выполнения
            });
        }

        private void IncreaseButton_Released(object sender, EventArgs e)
        {
            // Сброс флага при отпускании кнопки
            decreaseButtonPressed = false;
        }
        #endregion

        #endregion

        #region [Кнопка назад]

        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            Back.Clicked += ToUserMainPagePage;
        }
        private async void ToUserMainPagePage(object? sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new MainPage(_dbService));
            await Shell.Current.GoToAsync("///MainPage");
            //MainPage.Wichard_Button.IsEnabled = Enabled;

        }
        #endregion

        #region[Увеличение интерфейса]

        //void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        //{
        //    if (e.Status == GestureStatus.Started)
        //    {
        //        // Фиксируем начальный масштаб при начале масштабирования
        //        startScale = Main.Scale;
        //        Main.AnchorX = e.ScaleOrigin.X;
        //        Main.AnchorY = e.ScaleOrigin.Y;
        //    }
        //    else if (e.Status == GestureStatus.Running)
        //    {
        //        // Вычисляем новый масштаб на основе изменения масштаба от жеста
        //        double delta = e.Scale - 1;
        //        currentScale += delta;
        //        currentScale = Math.Max(1, currentScale);

        //        // Применяем новый масштаб к объекту
        //        Main.Scale = startScale * currentScale;
        //    }
        //}


        //void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        //{
        //    // Перемещаем объект при жесте перетаскивания
        //    if (e.StatusType == GestureStatus.Running)
        //    {
        //        Main.TranslationX += e.TotalX;
        //        Main.TranslationY += e.TotalY;
        //    }
        //}

        private void IncreaseButton_Clicked(object sender, EventArgs e)
        {
            // Увеличиваем масштаб ScrollView при нажатии кнопки "+"
            Main.Scale *= 1.1; // Например, увеличиваем масштаб на 10%
            Main.AnchorX = 0; // Установка AnchorX в 1 для правого края
            Main.AnchorY = 0; // Установка AnchorY в 0 для верхнего края
        }

        private void DecreaseButton_Clicked(object sender, EventArgs e)
        {
            // Уменьшаем масштаб ScrollView при нажатии кнопки "-"
            Main.Scale *= 0.9; // Например, уменьшаем масштаб на 10%
            Main.AnchorX = 0; // Установка AnchorX в 1 для правого края
            Main.AnchorY = 0; // Установка AnchorY в 0 для верхнего края
        }

        #endregion



    }



    public class StringToColorConverter2 : IValueConverter
    {

        public object Buff { get; set; }

        public object Debuff { set; get; }
        public object Skill { set; get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {



            int skill;
            switch (((Microsoft.Maui.Controls.InputView)this.Skill).Text)
            {
                case null:
                    skill = 0;
                    break;
                case "":
                    skill = 0;
                    break;
                case " ":
                    skill = 0;
                    break;
                default:
                    skill = Int32.Parse(((InputView)this.Skill).Text?.ToString().Trim().ToLower());
                    break;
            }

            var buf = ((Microsoft.Maui.Controls.InputView)parameter).Text switch
            {
                null => 0,
                "" => 0,
                " " => 0,
                _ => Int32.Parse(((((InputView)parameter).Text))?.ToString().Trim().ToLower()),
            };
            int debuf;
            switch (((Microsoft.Maui.Controls.InputView)this.Debuff).Text)
            {
                case null:
                    debuf = 0;
                    break;
                case "":
                    debuf = 0;
                    break;
                case " ":
                    debuf = 0;
                    break;
                default:
                    debuf = Int32.Parse(((InputView)this.Debuff).Text?.ToString().Trim().ToLower());
                    break;
            }


            int all = skill - debuf + buf;
            return all;




            //int zero = 0;
            //return zero;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            int skill;
            switch (((Microsoft.Maui.Controls.InputView)this.Skill).Text)
            { 
                case null:
                     skill = 0;
                    break;
                case "":
                     skill = 0;
                    break;
                case " ":
                     skill = 0;
                    break;
                default:
                    skill = Int32.Parse(((InputView)this.Skill).Text?.ToString().Trim().ToLower());
                    break;
            }

            int buf;
            switch (((Microsoft.Maui.Controls.InputView)parameter).Text)
            {
                case null:
                    buf = 0;
                    break;
                case "":
                    buf = 0;
                    break;
                case " ":
                    buf = 0;
                    break;
                default:
                    buf = Int32.Parse(((((InputView)parameter).Text))?.ToString().Trim().ToLower());
                    break;
            }


            int debuf;
            switch (((Microsoft.Maui.Controls.InputView)this.Debuff).Text)
            {
                case null:
                    debuf = 0;
                    break;
                case "":
                    debuf = 0;
                    break;
                case " ":
                    debuf = 0;
                    break;
                default:
                    debuf = Int32.Parse(((InputView)this.Debuff).Text?.ToString().Trim().ToLower());
                    break;
            }


            int all = skill - debuf + buf;
            return all;





            //int zero = 0;
            //return zero;
        }


    }

    #region test



    #endregion









}
