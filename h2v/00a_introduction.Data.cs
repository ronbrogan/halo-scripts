namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_00a_introduction : ScenarioScriptBase
    {
        public ScenarioEntity<IUnit> dervish { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> prophet_counc_01 { get; set; }
        public ScenarioEntity<IUnit> prophet_counc_02 { get; set; }
        public ScenarioEntity<IUnit> prophet_counc_03 { get; set; }
        public ScenarioEntity<IUnit> prophet_counc_04 { get; set; }
        public ScenarioEntity<IUnit> elite_counc_01 { get; set; }
        public ScenarioEntity<IUnit> elite_counc_02 { get; set; }
        public ScenarioEntity<IUnit> brute_01 { get; set; }
        public ScenarioEntity<IUnit> brute_02 { get; set; }
        public ScenarioEntity<IScenery> cruiser_01 { get; set; }
        public ScenarioEntity<IScenery> cruiser_02 { get; set; }
        public ScenarioEntity<IScenery> cruiser_03 { get; set; }
        public ScenarioEntity<IScenery> cruiser_04 { get; set; }
        public ScenarioEntity<IScenery> cruiser_05 { get; set; }
        public ScenarioEntity<IScenery> cruiser_06 { get; set; }
        public ScenarioEntity<IScenery> cruiser_07 { get; set; }
        public ScenarioEntity<IScenery> cruiser_08 { get; set; }
        public ScenarioEntity<IScenery> cruiser_09 { get; set; }
        public ScenarioEntity<IScenery> cruiser_10 { get; set; }
        public ScenarioEntity<IScenery> cruiser_11 { get; set; }
        public ScenarioEntity<IScenery> cruiser_12 { get; set; }
        public ScenarioEntity<IScenery> anchor_x01b { get; set; }
        public ScenarioEntity<IScenery> anchor_x01a { get; set; }
        public ScenarioEntity<IScenery> hammer { get; set; }
        public ScenarioEntity<IScenery> poa_01 { get; set; }
        public ScenarioEntity<IScenery> halo_exploding { get; set; }
        public ScenarioEntity<IScenery> matte_threshold { get; set; }
        public ScenarioEntity<IScenery> matte_halo_01 { get; set; }
        public ScenarioEntity<IScenery> matte_halo_02 { get; set; }
        public ScenarioEntity<IScenery> matte_reach { get; set; }
        public ScenarioEntity<IVehicle> banshee_01 { get; set; }
        public ScenarioEntity<IVehicle> banshee_02 { get; set; }
        public ScenarioEntity<IVehicle> banshee_03 { get; set; }
        public ScenarioEntity<IVehicle> banshee_04 { get; set; }
        public ScenarioEntity<IVehicle> banshee_05 { get; set; }
        public ScenarioEntity<IVehicle> banshee_06 { get; set; }
        public ScenarioEntity<IVehicle> banshee_07 { get; set; }
        public ScenarioEntity<IVehicle> banshee_08 { get; set; }
        public ScenarioEntity<IVehicle> banshee_09 { get; set; }
        public ScenarioEntity<IVehicle> banshee_10 { get; set; }
        public ScenarioEntity<IScenery> matte_high_charity { get; set; }
        public ScenarioEntity<IScenery> halo_whole { get; set; }
        public ScenarioEntity<IScenery> malta { get; set; }
        public ScenarioEntity<IScenery> cairo { get; set; }
        public ScenarioEntity<IScenery> athens { get; set; }
        public ScenarioEntity<IScenery> iac_01 { get; set; }
        public ScenarioEntity<IScenery> matte_earth { get; set; }
        public ScenarioEntity<IScenery> cart { get; set; }
        public ScenarioEntity<IScenery> optics { get; set; }
        public ScenarioEntity<IScenery> power_supply { get; set; }
        public ScenarioEntity<IScenery> helmet { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> master_guns { get; set; }
        public ScenarioEntity<IScenery> matte_moon { get; set; }
        public ScenarioEntity<IScenery> armory { get; set; }
        public ScenarioEntity<IUnit> regret { get; set; }
        public ScenarioEntity<IUnit> truth { get; set; }
        public ScenarioEntity<IUnit> mercy { get; set; }
        public ScenarioEntity<IVehicle> throne_regret { get; set; }
        public ScenarioEntity<IVehicle> throne_truth { get; set; }
        public ScenarioEntity<IVehicle> throne_mercy { get; set; }
        public ScenarioEntity<IScenery> elc_01 { get; set; }
        public ScenarioEntity<IScenery> elc_02 { get; set; }
        public ScenarioEntity<IScenery> elc_03 { get; set; }
        public ScenarioEntity<IScenery> elc_04 { get; set; }
        public ScenarioEntity<IScenery> elc_05 { get; set; }
        public ScenarioEntity<IScenery> elc_06 { get; set; }
        public ScenarioEntity<IScenery> elc_07 { get; set; }
        public ScenarioEntity<IScenery> elc_08 { get; set; }
        public ScenarioEntity<IScenery> elc_09 { get; set; }
        public ScenarioEntity<IScenery> elc_10 { get; set; }
        public ScenarioEntity<IScenery> elc_11 { get; set; }
        public ScenarioEntity<IScenery> elc_12 { get; set; }
        public ScenarioEntity<IScenery> elc_13 { get; set; }
        public ScenarioEntity<IScenery> elc_14 { get; set; }
        public ScenarioEntity<IScenery> elc_15 { get; set; }
        public ScenarioEntity<IScenery> elc_16 { get; set; }
        public ScenarioEntity<IScenery> elc_17 { get; set; }
        public ScenarioEntity<IScenery> elc_18 { get; set; }
        public ScenarioEntity<IScenery> elc_19 { get; set; }
        public ScenarioEntity<IScenery> elc_20 { get; set; }
        public ScenarioEntity<IScenery> elc_21 { get; set; }
        public ScenarioEntity<IScenery> elc_22 { get; set; }
        public ScenarioEntity<IScenery> elc_23 { get; set; }
        public ScenarioEntity<IScenery> elc_24 { get; set; }
        public ScenarioEntity<IScenery> elc_25 { get; set; }
        public ScenarioEntity<IScenery> elc_26 { get; set; }
        public ScenarioEntity<IScenery> elc_27 { get; set; }
        public ScenarioEntity<IScenery> elc_28 { get; set; }
        public ScenarioEntity<IScenery> elc_29 { get; set; }
        public ScenarioEntity<IScenery> elc_30 { get; set; }
        public ScenarioEntity<IScenery> pcc_01 { get; set; }
        public ScenarioEntity<IScenery> pcc_02 { get; set; }
        public ScenarioEntity<IScenery> pcc_03 { get; set; }
        public ScenarioEntity<IScenery> pcc_04 { get; set; }
        public ScenarioEntity<IScenery> pcc_05 { get; set; }
        public ScenarioEntity<IScenery> pcc_06 { get; set; }
        public ScenarioEntity<IScenery> pcc_07 { get; set; }
        public ScenarioEntity<IScenery> pcc_08 { get; set; }
        public ScenarioEntity<IScenery> pcc_09 { get; set; }
        public ScenarioEntity<IScenery> pcc_10 { get; set; }
        public ScenarioEntity<IScenery> pcc_11 { get; set; }
        public ScenarioEntity<IScenery> pcc_12 { get; set; }
        public ScenarioEntity<IScenery> pcc_13 { get; set; }
        public ScenarioEntity<IScenery> pcc_14 { get; set; }
        public ScenarioEntity<IScenery> pcc_15 { get; set; }
        public ScenarioEntity<IScenery> pcc_16 { get; set; }
        public ScenarioEntity<IScenery> pcc_17 { get; set; }
        public ScenarioEntity<IScenery> pcc_18 { get; set; }
        public ScenarioEntity<IScenery> pcc_19 { get; set; }
        public ScenarioEntity<IScenery> pcc_20 { get; set; }
        public ScenarioEntity<IScenery> pcc_21 { get; set; }
        public ScenarioEntity<IScenery> pcc_22 { get; set; }
        public ScenarioEntity<IScenery> pcc_23 { get; set; }
        public ScenarioEntity<IScenery> pcc_24 { get; set; }
        public ScenarioEntity<IScenery> pcc_25 { get; set; }
        public ScenarioEntity<IScenery> pcc_26 { get; set; }
        public ScenarioEntity<IScenery> pcc_27 { get; set; }
        public ScenarioEntity<IScenery> pcc_28 { get; set; }
        public ScenarioEntity<IScenery> pcc_29 { get; set; }
        public ScenarioEntity<IScenery> pcc_30 { get; set; }
        public ScenarioEntity<IScenery> pcc_31 { get; set; }
        public ScenarioEntity<IScenery> pcc_32 { get; set; }
        public ScenarioEntity<IScenery> carrier_01 { get; set; }
        public ScenarioEntity<IScenery> carrier_02 { get; set; }
        public ScenarioEntity<IScenery> carrier_03 { get; set; }
        public ScenarioEntity<IScenery> carrier_04 { get; set; }
        public ScenarioEntity<IScenery> carrier_05 { get; set; }
        public ScenarioEntity<IScenery> carrier_06 { get; set; }
        public ScenarioEntity<IScenery> carrier_07 { get; set; }
        public ScenarioEntity<IScenery> carrier_08 { get; set; }
        public ScenarioEntity<IScenery> x01_fleet { get; set; }
        public ScenarioEntity<IScenery> ehg_01 { get; set; }
        public ScenarioEntity<IScenery> ehg_02 { get; set; }
        public ScenarioEntity<IScenery> ehg_03 { get; set; }
        public ScenarioEntity<IScenery> ehg_04 { get; set; }
        public ScenarioEntity<IScenery> ehg_05 { get; set; }
        public ScenarioEntity<IScenery> ehg_06 { get; set; }
        public ScenarioEntity<IScenery> ehg_07 { get; set; }
        public ScenarioEntity<IScenery> ehg_08 { get; set; }
        public ScenarioEntity<IScenery> ehg_09 { get; set; }
        public ScenarioEntity<IScenery> ehg_10 { get; set; }
        public ScenarioEntity<IScenery> elc_31 { get; set; }
        public ScenarioEntity<IScenery> elc_32 { get; set; }
        public ScenarioEntity<IScenery> elc_33 { get; set; }
        public ScenarioEntity<IScenery> elc_34 { get; set; }
        public ScenarioEntity<IScenery> elc_35 { get; set; }
        public ScenarioEntity<IScenery> elc_36 { get; set; }
        public ScenarioEntity<IScenery> elc_37 { get; set; }
        public ScenarioEntity<IScenery> elc_38 { get; set; }
        public ScenarioEntity<IScenery> elc_39 { get; set; }
        public ScenarioEntity<IScenery> elc_40 { get; set; }
        public ScenarioEntity<IScenery> elc_41 { get; set; }
        public ScenarioEntity<IScenery> elc_42 { get; set; }
        public ScenarioEntity<IScenery> pcc_33 { get; set; }
        public ScenarioEntity<IScenery> pcc_34 { get; set; }
        public ScenarioEntity<IScenery> pcc_35 { get; set; }
        public ScenarioEntity<IScenery> pcc_36 { get; set; }
        public ScenarioEntity<IScenery> pcc_37 { get; set; }
        public ScenarioEntity<IScenery> pcc_38 { get; set; }
        public ScenarioEntity<IScenery> iac_02 { get; set; }
        public ScenarioEntity<IScenery> iac_03 { get; set; }
        public ScenarioEntity<IScenery> iac_04 { get; set; }
        public ScenarioEntity<IScenery> iac_05 { get; set; }
        public ScenarioEntity<IScenery> poa_02 { get; set; }
        public ScenarioEntity<IScenery> poa_03 { get; set; }
        public ScenarioEntity<IScenery> fighter_01 { get; set; }
        public ScenarioEntity<IScenery> fighter_02 { get; set; }
        public ScenarioEntity<IScenery> fighter_03 { get; set; }
        public ScenarioEntity<IScenery> fighter_04 { get; set; }
        public ScenarioEntity<IScenery> fighter_05 { get; set; }
        public ScenarioEntity<IScenery> fighter_06 { get; set; }
        public ScenarioEntity<IScenery> fighter_07 { get; set; }
        public ScenarioEntity<IScenery> fighter_08 { get; set; }
        public ScenarioEntity<IScenery> ehg_11 { get; set; }
        public ScenarioEntity<IScenery> ehg_12 { get; set; }
        public ScenarioEntity<IScenery> yellow_01a { get; set; }
        public ScenarioEntity<IScenery> yellow_01b { get; set; }
        public ScenarioEntity<IScenery> yellow_02a { get; set; }
        public ScenarioEntity<IScenery> yellow_02b { get; set; }
        public ScenarioEntity<IScenery> red_01 { get; set; }
        public ScenarioEntity<IScenery> matte_stardust_01 { get; set; }
        public ScenarioEntity<IScenery> matte_stardust_02 { get; set; }
        public ILocationFlag anchor_flag_x01 => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag anchor_flag_x01b => Scenario.LocationFlagDefinitions[1].GameObject;
        public ILocationFlag anchor_flag_x01a => Scenario.LocationFlagDefinitions[2].GameObject;
        public ICinematicTitle cinematic_title0 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle cinematic_title1 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            dervish = new ScenarioEntity<IUnit>(0, scenarioTag.WellKnownItems[0]);
            tartarus = new ScenarioEntity<IUnit>(1, scenarioTag.WellKnownItems[1]);
            prophet_counc_01 = new ScenarioEntity<IUnit>(2, scenarioTag.WellKnownItems[2]);
            prophet_counc_02 = new ScenarioEntity<IUnit>(3, scenarioTag.WellKnownItems[3]);
            prophet_counc_03 = new ScenarioEntity<IUnit>(4, scenarioTag.WellKnownItems[4]);
            prophet_counc_04 = new ScenarioEntity<IUnit>(5, scenarioTag.WellKnownItems[5]);
            elite_counc_01 = new ScenarioEntity<IUnit>(6, scenarioTag.WellKnownItems[6]);
            elite_counc_02 = new ScenarioEntity<IUnit>(7, scenarioTag.WellKnownItems[7]);
            brute_01 = new ScenarioEntity<IUnit>(8, scenarioTag.WellKnownItems[8]);
            brute_02 = new ScenarioEntity<IUnit>(9, scenarioTag.WellKnownItems[9]);
            cruiser_01 = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            cruiser_02 = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            cruiser_03 = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            cruiser_04 = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            cruiser_05 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            cruiser_06 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            cruiser_07 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            cruiser_08 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            cruiser_09 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            cruiser_10 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            cruiser_11 = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            cruiser_12 = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            anchor_x01b = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            anchor_x01a = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            hammer = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            poa_01 = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            halo_exploding = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            matte_threshold = new ScenarioEntity<IScenery>(27, scenarioTag.WellKnownItems[27]);
            matte_halo_01 = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            matte_halo_02 = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            matte_reach = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            banshee_01 = new ScenarioEntity<IVehicle>(31, scenarioTag.WellKnownItems[31]);
            banshee_02 = new ScenarioEntity<IVehicle>(32, scenarioTag.WellKnownItems[32]);
            banshee_03 = new ScenarioEntity<IVehicle>(33, scenarioTag.WellKnownItems[33]);
            banshee_04 = new ScenarioEntity<IVehicle>(34, scenarioTag.WellKnownItems[34]);
            banshee_05 = new ScenarioEntity<IVehicle>(35, scenarioTag.WellKnownItems[35]);
            banshee_06 = new ScenarioEntity<IVehicle>(36, scenarioTag.WellKnownItems[36]);
            banshee_07 = new ScenarioEntity<IVehicle>(37, scenarioTag.WellKnownItems[37]);
            banshee_08 = new ScenarioEntity<IVehicle>(38, scenarioTag.WellKnownItems[38]);
            banshee_09 = new ScenarioEntity<IVehicle>(39, scenarioTag.WellKnownItems[39]);
            banshee_10 = new ScenarioEntity<IVehicle>(40, scenarioTag.WellKnownItems[40]);
            matte_high_charity = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            halo_whole = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            malta = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            cairo = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            athens = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            iac_01 = new ScenarioEntity<IScenery>(46, scenarioTag.WellKnownItems[46]);
            matte_earth = new ScenarioEntity<IScenery>(47, scenarioTag.WellKnownItems[47]);
            cart = new ScenarioEntity<IScenery>(48, scenarioTag.WellKnownItems[48]);
            optics = new ScenarioEntity<IScenery>(49, scenarioTag.WellKnownItems[49]);
            power_supply = new ScenarioEntity<IScenery>(50, scenarioTag.WellKnownItems[50]);
            helmet = new ScenarioEntity<IScenery>(51, scenarioTag.WellKnownItems[51]);
            chief = new ScenarioEntity<IUnit>(52, scenarioTag.WellKnownItems[52]);
            master_guns = new ScenarioEntity<IUnit>(53, scenarioTag.WellKnownItems[53]);
            matte_moon = new ScenarioEntity<IScenery>(54, scenarioTag.WellKnownItems[54]);
            armory = new ScenarioEntity<IScenery>(55, scenarioTag.WellKnownItems[55]);
            regret = new ScenarioEntity<IUnit>(56, scenarioTag.WellKnownItems[56]);
            truth = new ScenarioEntity<IUnit>(57, scenarioTag.WellKnownItems[57]);
            mercy = new ScenarioEntity<IUnit>(58, scenarioTag.WellKnownItems[58]);
            throne_regret = new ScenarioEntity<IVehicle>(59, scenarioTag.WellKnownItems[59]);
            throne_truth = new ScenarioEntity<IVehicle>(60, scenarioTag.WellKnownItems[60]);
            throne_mercy = new ScenarioEntity<IVehicle>(61, scenarioTag.WellKnownItems[61]);
            elc_01 = new ScenarioEntity<IScenery>(62, scenarioTag.WellKnownItems[62]);
            elc_02 = new ScenarioEntity<IScenery>(63, scenarioTag.WellKnownItems[63]);
            elc_03 = new ScenarioEntity<IScenery>(64, scenarioTag.WellKnownItems[64]);
            elc_04 = new ScenarioEntity<IScenery>(65, scenarioTag.WellKnownItems[65]);
            elc_05 = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            elc_06 = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            elc_07 = new ScenarioEntity<IScenery>(68, scenarioTag.WellKnownItems[68]);
            elc_08 = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            elc_09 = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            elc_10 = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            elc_11 = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            elc_12 = new ScenarioEntity<IScenery>(73, scenarioTag.WellKnownItems[73]);
            elc_13 = new ScenarioEntity<IScenery>(74, scenarioTag.WellKnownItems[74]);
            elc_14 = new ScenarioEntity<IScenery>(75, scenarioTag.WellKnownItems[75]);
            elc_15 = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            elc_16 = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            elc_17 = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            elc_18 = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            elc_19 = new ScenarioEntity<IScenery>(80, scenarioTag.WellKnownItems[80]);
            elc_20 = new ScenarioEntity<IScenery>(81, scenarioTag.WellKnownItems[81]);
            elc_21 = new ScenarioEntity<IScenery>(82, scenarioTag.WellKnownItems[82]);
            elc_22 = new ScenarioEntity<IScenery>(83, scenarioTag.WellKnownItems[83]);
            elc_23 = new ScenarioEntity<IScenery>(84, scenarioTag.WellKnownItems[84]);
            elc_24 = new ScenarioEntity<IScenery>(85, scenarioTag.WellKnownItems[85]);
            elc_25 = new ScenarioEntity<IScenery>(86, scenarioTag.WellKnownItems[86]);
            elc_26 = new ScenarioEntity<IScenery>(87, scenarioTag.WellKnownItems[87]);
            elc_27 = new ScenarioEntity<IScenery>(88, scenarioTag.WellKnownItems[88]);
            elc_28 = new ScenarioEntity<IScenery>(89, scenarioTag.WellKnownItems[89]);
            elc_29 = new ScenarioEntity<IScenery>(90, scenarioTag.WellKnownItems[90]);
            elc_30 = new ScenarioEntity<IScenery>(91, scenarioTag.WellKnownItems[91]);
            pcc_01 = new ScenarioEntity<IScenery>(92, scenarioTag.WellKnownItems[92]);
            pcc_02 = new ScenarioEntity<IScenery>(93, scenarioTag.WellKnownItems[93]);
            pcc_03 = new ScenarioEntity<IScenery>(94, scenarioTag.WellKnownItems[94]);
            pcc_04 = new ScenarioEntity<IScenery>(95, scenarioTag.WellKnownItems[95]);
            pcc_05 = new ScenarioEntity<IScenery>(96, scenarioTag.WellKnownItems[96]);
            pcc_06 = new ScenarioEntity<IScenery>(97, scenarioTag.WellKnownItems[97]);
            pcc_07 = new ScenarioEntity<IScenery>(98, scenarioTag.WellKnownItems[98]);
            pcc_08 = new ScenarioEntity<IScenery>(99, scenarioTag.WellKnownItems[99]);
            pcc_09 = new ScenarioEntity<IScenery>(100, scenarioTag.WellKnownItems[100]);
            pcc_10 = new ScenarioEntity<IScenery>(101, scenarioTag.WellKnownItems[101]);
            pcc_11 = new ScenarioEntity<IScenery>(102, scenarioTag.WellKnownItems[102]);
            pcc_12 = new ScenarioEntity<IScenery>(103, scenarioTag.WellKnownItems[103]);
            pcc_13 = new ScenarioEntity<IScenery>(104, scenarioTag.WellKnownItems[104]);
            pcc_14 = new ScenarioEntity<IScenery>(105, scenarioTag.WellKnownItems[105]);
            pcc_15 = new ScenarioEntity<IScenery>(106, scenarioTag.WellKnownItems[106]);
            pcc_16 = new ScenarioEntity<IScenery>(107, scenarioTag.WellKnownItems[107]);
            pcc_17 = new ScenarioEntity<IScenery>(108, scenarioTag.WellKnownItems[108]);
            pcc_18 = new ScenarioEntity<IScenery>(109, scenarioTag.WellKnownItems[109]);
            pcc_19 = new ScenarioEntity<IScenery>(110, scenarioTag.WellKnownItems[110]);
            pcc_20 = new ScenarioEntity<IScenery>(111, scenarioTag.WellKnownItems[111]);
            pcc_21 = new ScenarioEntity<IScenery>(112, scenarioTag.WellKnownItems[112]);
            pcc_22 = new ScenarioEntity<IScenery>(113, scenarioTag.WellKnownItems[113]);
            pcc_23 = new ScenarioEntity<IScenery>(114, scenarioTag.WellKnownItems[114]);
            pcc_24 = new ScenarioEntity<IScenery>(115, scenarioTag.WellKnownItems[115]);
            pcc_25 = new ScenarioEntity<IScenery>(116, scenarioTag.WellKnownItems[116]);
            pcc_26 = new ScenarioEntity<IScenery>(117, scenarioTag.WellKnownItems[117]);
            pcc_27 = new ScenarioEntity<IScenery>(118, scenarioTag.WellKnownItems[118]);
            pcc_28 = new ScenarioEntity<IScenery>(119, scenarioTag.WellKnownItems[119]);
            pcc_29 = new ScenarioEntity<IScenery>(120, scenarioTag.WellKnownItems[120]);
            pcc_30 = new ScenarioEntity<IScenery>(121, scenarioTag.WellKnownItems[121]);
            pcc_31 = new ScenarioEntity<IScenery>(122, scenarioTag.WellKnownItems[122]);
            pcc_32 = new ScenarioEntity<IScenery>(123, scenarioTag.WellKnownItems[123]);
            carrier_01 = new ScenarioEntity<IScenery>(124, scenarioTag.WellKnownItems[124]);
            carrier_02 = new ScenarioEntity<IScenery>(125, scenarioTag.WellKnownItems[125]);
            carrier_03 = new ScenarioEntity<IScenery>(126, scenarioTag.WellKnownItems[126]);
            carrier_04 = new ScenarioEntity<IScenery>(127, scenarioTag.WellKnownItems[127]);
            carrier_05 = new ScenarioEntity<IScenery>(128, scenarioTag.WellKnownItems[128]);
            carrier_06 = new ScenarioEntity<IScenery>(129, scenarioTag.WellKnownItems[129]);
            carrier_07 = new ScenarioEntity<IScenery>(130, scenarioTag.WellKnownItems[130]);
            carrier_08 = new ScenarioEntity<IScenery>(131, scenarioTag.WellKnownItems[131]);
            x01_fleet = new ScenarioEntity<IScenery>(132, scenarioTag.WellKnownItems[132]);
            ehg_01 = new ScenarioEntity<IScenery>(133, scenarioTag.WellKnownItems[133]);
            ehg_02 = new ScenarioEntity<IScenery>(134, scenarioTag.WellKnownItems[134]);
            ehg_03 = new ScenarioEntity<IScenery>(135, scenarioTag.WellKnownItems[135]);
            ehg_04 = new ScenarioEntity<IScenery>(136, scenarioTag.WellKnownItems[136]);
            ehg_05 = new ScenarioEntity<IScenery>(137, scenarioTag.WellKnownItems[137]);
            ehg_06 = new ScenarioEntity<IScenery>(138, scenarioTag.WellKnownItems[138]);
            ehg_07 = new ScenarioEntity<IScenery>(139, scenarioTag.WellKnownItems[139]);
            ehg_08 = new ScenarioEntity<IScenery>(140, scenarioTag.WellKnownItems[140]);
            ehg_09 = new ScenarioEntity<IScenery>(141, scenarioTag.WellKnownItems[141]);
            ehg_10 = new ScenarioEntity<IScenery>(142, scenarioTag.WellKnownItems[142]);
            elc_31 = new ScenarioEntity<IScenery>(143, scenarioTag.WellKnownItems[143]);
            elc_32 = new ScenarioEntity<IScenery>(144, scenarioTag.WellKnownItems[144]);
            elc_33 = new ScenarioEntity<IScenery>(145, scenarioTag.WellKnownItems[145]);
            elc_34 = new ScenarioEntity<IScenery>(146, scenarioTag.WellKnownItems[146]);
            elc_35 = new ScenarioEntity<IScenery>(147, scenarioTag.WellKnownItems[147]);
            elc_36 = new ScenarioEntity<IScenery>(148, scenarioTag.WellKnownItems[148]);
            elc_37 = new ScenarioEntity<IScenery>(149, scenarioTag.WellKnownItems[149]);
            elc_38 = new ScenarioEntity<IScenery>(150, scenarioTag.WellKnownItems[150]);
            elc_39 = new ScenarioEntity<IScenery>(151, scenarioTag.WellKnownItems[151]);
            elc_40 = new ScenarioEntity<IScenery>(152, scenarioTag.WellKnownItems[152]);
            elc_41 = new ScenarioEntity<IScenery>(153, scenarioTag.WellKnownItems[153]);
            elc_42 = new ScenarioEntity<IScenery>(154, scenarioTag.WellKnownItems[154]);
            pcc_33 = new ScenarioEntity<IScenery>(155, scenarioTag.WellKnownItems[155]);
            pcc_34 = new ScenarioEntity<IScenery>(156, scenarioTag.WellKnownItems[156]);
            pcc_35 = new ScenarioEntity<IScenery>(157, scenarioTag.WellKnownItems[157]);
            pcc_36 = new ScenarioEntity<IScenery>(158, scenarioTag.WellKnownItems[158]);
            pcc_37 = new ScenarioEntity<IScenery>(159, scenarioTag.WellKnownItems[159]);
            pcc_38 = new ScenarioEntity<IScenery>(160, scenarioTag.WellKnownItems[160]);
            iac_02 = new ScenarioEntity<IScenery>(161, scenarioTag.WellKnownItems[161]);
            iac_03 = new ScenarioEntity<IScenery>(162, scenarioTag.WellKnownItems[162]);
            iac_04 = new ScenarioEntity<IScenery>(163, scenarioTag.WellKnownItems[163]);
            iac_05 = new ScenarioEntity<IScenery>(164, scenarioTag.WellKnownItems[164]);
            poa_02 = new ScenarioEntity<IScenery>(165, scenarioTag.WellKnownItems[165]);
            poa_03 = new ScenarioEntity<IScenery>(166, scenarioTag.WellKnownItems[166]);
            fighter_01 = new ScenarioEntity<IScenery>(167, scenarioTag.WellKnownItems[167]);
            fighter_02 = new ScenarioEntity<IScenery>(168, scenarioTag.WellKnownItems[168]);
            fighter_03 = new ScenarioEntity<IScenery>(169, scenarioTag.WellKnownItems[169]);
            fighter_04 = new ScenarioEntity<IScenery>(170, scenarioTag.WellKnownItems[170]);
            fighter_05 = new ScenarioEntity<IScenery>(171, scenarioTag.WellKnownItems[171]);
            fighter_06 = new ScenarioEntity<IScenery>(172, scenarioTag.WellKnownItems[172]);
            fighter_07 = new ScenarioEntity<IScenery>(173, scenarioTag.WellKnownItems[173]);
            fighter_08 = new ScenarioEntity<IScenery>(174, scenarioTag.WellKnownItems[174]);
            ehg_11 = new ScenarioEntity<IScenery>(175, scenarioTag.WellKnownItems[175]);
            ehg_12 = new ScenarioEntity<IScenery>(176, scenarioTag.WellKnownItems[176]);
            yellow_01a = new ScenarioEntity<IScenery>(177, scenarioTag.WellKnownItems[177]);
            yellow_01b = new ScenarioEntity<IScenery>(178, scenarioTag.WellKnownItems[178]);
            yellow_02a = new ScenarioEntity<IScenery>(179, scenarioTag.WellKnownItems[179]);
            yellow_02b = new ScenarioEntity<IScenery>(180, scenarioTag.WellKnownItems[180]);
            red_01 = new ScenarioEntity<IScenery>(181, scenarioTag.WellKnownItems[181]);
            matte_stardust_01 = new ScenarioEntity<IScenery>(182, scenarioTag.WellKnownItems[182]);
            matte_stardust_02 = new ScenarioEntity<IScenery>(183, scenarioTag.WellKnownItems[183]);
        }
    }
}