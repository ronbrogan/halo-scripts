namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_03a_oldmombasa : ScenarioScriptBase
    {
        public ScenarioEntity<IBloc> temp_bridge_ball { get; set; }
        public ScenarioEntity<IScenery> anchor_intro { get; set; }
        public ScenarioEntity<IScenery> iac { get; set; }
        public ScenarioEntity<IScenery> scarab { get; set; }
        public ScenarioEntity<IScenery> scope { get; set; }
        public ScenarioEntity<IScenery> helmet { get; set; }
        public ScenarioEntity<IScenery> magazine { get; set; }
        public ScenarioEntity<IScenery> battle_rifle_01 { get; set; }
        public ScenarioEntity<IScenery> battle_rifle_02 { get; set; }
        public ScenarioEntity<IScenery> sniper_rifle { get; set; }
        public ScenarioEntity<IBloc> e1_truck0 { get; set; }
        public ScenarioEntity<IBloc> e1_truck1 { get; set; }
        public ScenarioEntity<IScenery> iac_bridge { get; set; }
        public ScenarioEntity<IScenery> speaker0 { get; set; }
        public ScenarioEntity<IScenery> speaker1 { get; set; }
        public ScenarioEntity<IScenery> speaker2 { get; set; }
        public ScenarioEntity<IScenery> speaker3 { get; set; }
        public ScenarioEntity<IScenery> speaker4 { get; set; }
        public ScenarioEntity<IScenery> speaker6 { get; set; }
        public ScenarioEntity<IScenery> speaker7 { get; set; }
        public ScenarioEntity<IScenery> speaker8 { get; set; }
        public ScenarioEntity<IScenery> intro_railing_01 { get; set; }
        public ScenarioEntity<IScenery> intro_railing_02 { get; set; }
        public ScenarioEntity<IScenery> intro_railing_03 { get; set; }
        public ScenarioEntity<IScenery> intro_railing_04 { get; set; }
        public ScenarioEntity<IScenery> intro_railing_05 { get; set; }
        public ScenarioEntity<IScenery> intro_railing_06 { get; set; }
        public ScenarioEntity<IScenery> intro_railing_07 { get; set; }
        public ScenarioEntity<IScenery> carrier { get; set; }
        public ScenarioEntity<IScenery> scarab_turret { get; set; }
        public ScenarioEntity<IScenery> crashed_pelican { get; set; }
        public ScenarioEntity<IScenery> e2_hunter_smoke { get; set; }
        public ScenarioEntity<IScenery> e2_hunter_door_sound_source { get; set; }
        public ScenarioEntity<IScenery> intro_flak_01 { get; set; }
        public ScenarioEntity<IScenery> intro_flak_02 { get; set; }
        public ScenarioEntity<IScenery> intro_crash_01 { get; set; }
        public ScenarioEntity<IScenery> intro_crash_02 { get; set; }
        public ScenarioEntity<IScenery> intro_crash_03 { get; set; }
        public ScenarioEntity<IScenery> intro_crash_04 { get; set; }
        public ScenarioEntity<IScenery> intro_crash_05 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_01 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_02 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_03 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_04 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_05 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_06 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_07 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_08 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_09 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_10 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_11 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_12 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_13 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_14 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_15 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_16 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_17 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_18 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_19 { get; set; }
        public ScenarioEntity<IScenery> offending_palm_20 { get; set; }
        public ScenarioEntity<IBloc> the_fiscal_year { get; set; }
        public ScenarioEntity<IUnit> johnson { get; set; }
        public ScenarioEntity<IUnit> pilot { get; set; }
        public ScenarioEntity<IUnit> copilot { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> spotter { get; set; }
        public ScenarioEntity<IUnit> sniper { get; set; }
        public ScenarioEntity<IUnit> odst_01 { get; set; }
        public ScenarioEntity<IUnit> odst_02 { get; set; }
        public ScenarioEntity<IUnit> odst_03 { get; set; }
        public ScenarioEntity<IUnit> odst_04 { get; set; }
        public ScenarioEntity<IUnit> e3_hidden0 { get; set; }
        public ScenarioEntity<IUnit> e3_hidden1 { get; set; }
        public ScenarioEntity<IVehicle> e9_guntower0 { get; set; }
        public ScenarioEntity<IVehicle> e10_guntower0 { get; set; }
        public ScenarioEntity<IVehicle> pelican_03 { get; set; }
        public ScenarioEntity<IVehicle> pelican_01 { get; set; }
        public ScenarioEntity<IVehicle> pelican_02 { get; set; }
        public ScenarioEntity<IVehicle> pelican_04 { get; set; }
        public ScenarioEntity<IVehicle> e1_gun { get; set; }
        public ScenarioEntity<IVehicle> e12_warthog0 { get; set; }
        public ScenarioEntity<IVehicle> warthog_for_the_masses { get; set; }
        public ScenarioEntity<IWeapon> e5_cov_inf0_pistol { get; set; }
        public ScenarioEntity<IWeapon> e7_gun0 { get; set; }
        public ScenarioEntity<IWeapon> e11_rocket_launcher0 { get; set; }
        public ScenarioEntity<IWeapon> e12_scarab_gun { get; set; }
        public ScenarioEntity<IWeapon> intro_scarab_gun { get; set; }
        public ScenarioEntity<IWeapon> intro_scarab_gun_turret { get; set; }
        public ScenarioEntity<IWeapon> key { get; set; }
        public ScenarioEntity<IWeapon> e1_ghost_key { get; set; }
        public ScenarioEntity<IDevice> e11_pod0_inserter { get; set; }
        public ScenarioEntity<IDevice> e11_pod1_inserter { get; set; }
        public ScenarioEntity<IDevice> e11_pod2_inserter { get; set; }
        public ScenarioEntity<IDevice> e11_pod3_inserter { get; set; }
        public ScenarioEntity<IDevice> e11_pod4_inserter { get; set; }
        public ScenarioEntity<IDevice> e11_pod5_inserter { get; set; }
        public ScenarioEntity<IDevice> e9_watchtower0_base { get; set; }
        public ScenarioEntity<IDevice> e9_watchtower0_pod { get; set; }
        public ScenarioEntity<IDevice> e11_watchtower0_base { get; set; }
        public ScenarioEntity<IDevice> e11_watchtower0_pod { get; set; }
        public ScenarioEntity<IDevice> e2_hunter_door { get; set; }
        public ScenarioEntity<IDevice> e11_pod6_inserter { get; set; }
        public ScenarioEntity<IDevice> tunnel_scarab { get; set; }
        public ICameraPathTarget cinematic_test0 => Scenario.CameraPathTargets[0];
        public ICameraPathTarget cinematic_test1 => Scenario.CameraPathTargets[1];
        public ICameraPathTarget cinematic_test2 => Scenario.CameraPathTargets[2];
        public ICameraPathTarget cinematic_test3 => Scenario.CameraPathTargets[3];
        public ICameraPathTarget e8_prediction => Scenario.CameraPathTargets[4];
        public ICameraPathTarget e1_prediction => Scenario.CameraPathTargets[5];
        public Squad_e1_mars_johnson e1_mars_johnson { get; set; }
        public Squad_e1_mars_inf0 e1_mars_inf0 { get; set; }
        public Squad_e1_mars_inf1 e1_mars_inf1 { get; set; }
        public Squad_e1_mars_inf2 e1_mars_inf2 { get; set; }
        public Squad_e1_mars_pelican0 e1_mars_pelican0 { get; set; }
        public Squad_e1_cov_inf0_0 e1_cov_inf0_0 { get; set; }
        public Squad_e1_cov_inf0_1 e1_cov_inf0_1 { get; set; }
        public Squad_e1_cov_inf0_2 e1_cov_inf0_2 { get; set; }
        public Squad_e1_cov_inf0_3 e1_cov_inf0_3 { get; set; }
        public Squad_e1_cov_inf1_0 e1_cov_inf1_0 { get; set; }
        public Squad_e1_cov_inf1_1 e1_cov_inf1_1 { get; set; }
        public Squad_e1_cov_inf2_0 e1_cov_inf2_0 { get; set; }
        public Squad_e1_cov_inf2_1 e1_cov_inf2_1 { get; set; }
        public Squad_e1_cov_inf2_2 e1_cov_inf2_2 { get; set; }
        public Squad_e1_cov_inf2_3 e1_cov_inf2_3 { get; set; }
        public Squad_e1_cov_inf2_4 e1_cov_inf2_4 { get; set; }
        public Squad_e1_cov_inf2_5 e1_cov_inf2_5 { get; set; }
        public Squad_e1_cov_inf2_6 e1_cov_inf2_6 { get; set; }
        public Squad_e1_cov_inf2_7 e1_cov_inf2_7 { get; set; }
        public Squad_e1_cov_inf3_0 e1_cov_inf3_0 { get; set; }
        public Squad_e1_cov_inf3_1 e1_cov_inf3_1 { get; set; }
        public Squad_e1_cov_inf3_2 e1_cov_inf3_2 { get; set; }
        public Squad_e1_cov_inf4_0 e1_cov_inf4_0 { get; set; }
        public Squad_e1_cov_inf4_1 e1_cov_inf4_1 { get; set; }
        public Squad_e1_cov_inf4_2 e1_cov_inf4_2 { get; set; }
        public Squad_e1_cov_snipers0 e1_cov_snipers0 { get; set; }
        public Squad_e1_cov_phantom0_0 e1_cov_phantom0_0 { get; set; }
        public Squad_e1_cov_phantom0_1 e1_cov_phantom0_1 { get; set; }
        public Squad_e2_mars_inf0 e2_mars_inf0 { get; set; }
        public Squad_e2_mars_johnson e2_mars_johnson { get; set; }
        public Squad_e2_cov_inf0 e2_cov_inf0 { get; set; }
        public Squad_e2_cov_hunters0 e2_cov_hunters0 { get; set; }
        public Squad_e3_mars_inf0 e3_mars_inf0 { get; set; }
        public Squad_e3_mars_inf1 e3_mars_inf1 { get; set; }
        public Squad_e3_mars_johnson e3_mars_johnson { get; set; }
        public Squad_e3_mars_pelican0 e3_mars_pelican0 { get; set; }
        public Squad_e3_cov_inf0_0 e3_cov_inf0_0 { get; set; }
        public Squad_e3_cov_inf0_1 e3_cov_inf0_1 { get; set; }
        public Squad_e3_cov_inf0_2 e3_cov_inf0_2 { get; set; }
        public Squad_e3_cov_inf0_3 e3_cov_inf0_3 { get; set; }
        public Squad_e4_mars_inf0 e4_mars_inf0 { get; set; }
        public Squad_e4_cov_inf0_0 e4_cov_inf0_0 { get; set; }
        public Squad_e4_cov_inf0_1 e4_cov_inf0_1 { get; set; }
        public Squad_e4_cov_inf1_0 e4_cov_inf1_0 { get; set; }
        public Squad_e4_cov_inf1_1 e4_cov_inf1_1 { get; set; }
        public Squad_e4_cov_inf2 e4_cov_inf2 { get; set; }
        public Squad_e4_cov_snipers0_0 e4_cov_snipers0_0 { get; set; }
        public Squad_e4_cov_snipers0_1 e4_cov_snipers0_1 { get; set; }
        public Squad_e4_cov_snipers0_2 e4_cov_snipers0_2 { get; set; }
        public Squad_e5_mars_inf0 e5_mars_inf0 { get; set; }
        public Squad_e5_cov_inf0_0 e5_cov_inf0_0 { get; set; }
        public Squad_e5_cov_inf0_1 e5_cov_inf0_1 { get; set; }
        public Squad_e5_cov_inf1_0 e5_cov_inf1_0 { get; set; }
        public Squad_e5_cov_inf1_1 e5_cov_inf1_1 { get; set; }
        public Squad_e5_cov_inf2 e5_cov_inf2 { get; set; }
        public Squad_e5_cov_inf3 e5_cov_inf3 { get; set; }
        public Squad_e5_cov_inf4 e5_cov_inf4 { get; set; }
        public Squad_e5b_cov_inf0 e5b_cov_inf0 { get; set; }
        public Squad_e6_mars_inf0 e6_mars_inf0 { get; set; }
        public Squad_e6_mars_inf0_1 e6_mars_inf0_1 { get; set; }
        public Squad_e6_mars_inf1 e6_mars_inf1 { get; set; }
        public Squad_e6_cov_inf0_0 e6_cov_inf0_0 { get; set; }
        public Squad_e6_cov_inf0_1 e6_cov_inf0_1 { get; set; }
        public Squad_e6_cov_inf0_2 e6_cov_inf0_2 { get; set; }
        public Squad_e6_cov_inf1 e6_cov_inf1 { get; set; }
        public Squad_e7_mars_inf0 e7_mars_inf0 { get; set; }
        public Squad_e7_cov_inf0 e7_cov_inf0 { get; set; }
        public Squad_e8_mars_inf0 e8_mars_inf0 { get; set; }
        public Squad_e8_mars_warthog0 e8_mars_warthog0 { get; set; }
        public Squad_e8_cov_inf0 e8_cov_inf0 { get; set; }
        public Squad_e8_cov_inf1 e8_cov_inf1 { get; set; }
        public Squad_e8_cov_inf2 e8_cov_inf2 { get; set; }
        public Squad_e8_cov_ghosts0_0 e8_cov_ghosts0_0 { get; set; }
        public Squad_e8_cov_ghosts0_1 e8_cov_ghosts0_1 { get; set; }
        public Squad_e8_cov_phantom0 e8_cov_phantom0 { get; set; }
        public Squad_____BEACH____ ____BEACH____ { get; set; }
        public Squad_e9_mars_test e9_mars_test { get; set; }
        public Squad_e9_mars_warthog0 e9_mars_warthog0 { get; set; }
        public Squad_e9_cov_ghosts0 e9_cov_ghosts0 { get; set; }
        public Squad_e9_cov_shadow0 e9_cov_shadow0 { get; set; }
        public Squad_e9_cov_inf0 e9_cov_inf0 { get; set; }
        public Squad_e9_cov_inf1_0 e9_cov_inf1_0 { get; set; }
        public Squad_e9_cov_inf1_1 e9_cov_inf1_1 { get; set; }
        public Squad_e9_cov_inf1_2 e9_cov_inf1_2 { get; set; }
        public Squad_e10_mars_test e10_mars_test { get; set; }
        public Squad_e10_mars_warthog0 e10_mars_warthog0 { get; set; }
        public Squad_e10_mars_inf0 e10_mars_inf0 { get; set; }
        public Squad_e10_cov_inf0 e10_cov_inf0 { get; set; }
        public Squad_e10_cov_inf1 e10_cov_inf1 { get; set; }
        public Squad_e10_cov_ghosts0_0 e10_cov_ghosts0_0 { get; set; }
        public Squad_e10_cov_ghosts0_1 e10_cov_ghosts0_1 { get; set; }
        public Squad_e10_cov_ghosts1 e10_cov_ghosts1 { get; set; }
        public Squad_e10_cov_phantom0 e10_cov_phantom0 { get; set; }
        public Squad_e11_mars_inf0 e11_mars_inf0 { get; set; }
        public Squad_e11_mars_warthog0 e11_mars_warthog0 { get; set; }
        public Squad_e11_cov_inf0 e11_cov_inf0 { get; set; }
        public Squad_e11_cov_inf1_0 e11_cov_inf1_0 { get; set; }
        public Squad_e11_cov_inf1_1 e11_cov_inf1_1 { get; set; }
        public Squad_e11_cov_inf2 e11_cov_inf2 { get; set; }
        public Squad_e11_cov_ghosts0_0 e11_cov_ghosts0_0 { get; set; }
        public Squad_e11_cov_ghosts0_1 e11_cov_ghosts0_1 { get; set; }
        public Squad_____TUNNEL____ ____TUNNEL____ { get; set; }
        public Squad_e12_mars_warthog0 e12_mars_warthog0 { get; set; }
        public Squad_e12_mars_warthog1 e12_mars_warthog1 { get; set; }
        public Squad_e12_mars_inf0 e12_mars_inf0 { get; set; }
        public Squad_e12_mars_inf1 e12_mars_inf1 { get; set; }
        public Squad_e12_cov_inf0_0 e12_cov_inf0_0 { get; set; }
        public Squad_e12_cov_inf0_1 e12_cov_inf0_1 { get; set; }
        public Squad_e12_cov_inf0_2 e12_cov_inf0_2 { get; set; }
        public Squad_e12_cov_inf0_3 e12_cov_inf0_3 { get; set; }
        public Squad_e12_cov_inf0_4 e12_cov_inf0_4 { get; set; }
        public Squad_e12_cov_inf0_5 e12_cov_inf0_5 { get; set; }
        public Squad_e12_cov_inf0_6 e12_cov_inf0_6 { get; set; }
        public Squad_e12_cov_creep0 e12_cov_creep0 { get; set; }
        public Squad_e12_cov_ghosts0 e12_cov_ghosts0 { get; set; }
        public Squad_e12_scarab_gunner e12_scarab_gunner { get; set; }
        public Squad_e13_mars_warthog0 e13_mars_warthog0 { get; set; }
        public Squad_e13_cov_creep0_0 e13_cov_creep0_0 { get; set; }
        public Squad_e13_cov_creep0_1 e13_cov_creep0_1 { get; set; }
        public Squad_e13_cov_creep0_2 e13_cov_creep0_2 { get; set; }
        public Squad_e13_cov_creep0_3 e13_cov_creep0_3 { get; set; }
        public Squad_e13_cov_creep0_4 e13_cov_creep0_4 { get; set; }
        public Squad_e13_cov_creep0_5 e13_cov_creep0_5 { get; set; }
        public Squad_e13_cov_creep0_6 e13_cov_creep0_6 { get; set; }
        public Squad_e13_cov_creep0_7 e13_cov_creep0_7 { get; set; }
        public Squad_e13_cov_ghosts0 e13_cov_ghosts0 { get; set; }
        public Squad_e13_cov_ghosts1 e13_cov_ghosts1 { get; set; }
        public Squad_test test { get; set; }
        public Squad_intro_hog_01 intro_hog_01 { get; set; }
        public Squad_intro_hog_02 intro_hog_02 { get; set; }
        public Squad_intro_hog_03 intro_hog_03 { get; set; }
        public Squad_intro_hog_04 intro_hog_04 { get; set; }
        public IAiActorDefinition marines => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition covenant1 => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition e1_mars => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition e1_cov => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition e1_cov_inf0 => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition e1_cov_inf1 => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition e1_cov_inf2 => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition e1_cov_inf3 => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition e1_cov_inf4 => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition e1_cov_phantom0 => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition e2_mars => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition e2_cov => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition e3_mars => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition e3_cov => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition e3_cov_inf0 => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition e4_mars => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition e4_cov => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition e4_cov_inf0 => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition e4_cov_inf1 => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition e4_cov_snipers0 => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition e5_mars => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition e5_cov => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition e5_cov_inf0 => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition e5_cov_inf1 => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition e6_mars => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition e6_cov => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition e7_mars => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition e7_cov => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition e8_mars => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition e8_cov => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition e8_cov_ghosts0 => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition e9_mars => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition e9_cov => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition e9_cov_inf1 => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition e10_mars => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition e10_cov => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition e10_cov_ghosts0 => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition e11_mars => Scenario.AiSquadGroupDefinitions[37];
        public IAiActorDefinition e11_cov => Scenario.AiSquadGroupDefinitions[38];
        public IAiActorDefinition e11_cov_ghosts0 => Scenario.AiSquadGroupDefinitions[39];
        public IAiActorDefinition e12_mars => Scenario.AiSquadGroupDefinitions[40];
        public IAiActorDefinition e12_cov => Scenario.AiSquadGroupDefinitions[41];
        public IAiActorDefinition e12_cov_inf0 => Scenario.AiSquadGroupDefinitions[42];
        public IAiActorDefinition e13_mars => Scenario.AiSquadGroupDefinitions[43];
        public IAiActorDefinition e13_cov => Scenario.AiSquadGroupDefinitions[44];
        public IAiActorDefinition e13_cov_creep0 => Scenario.AiSquadGroupDefinitions[45];
        public IAiActorDefinition test1 => Scenario.AiSquadGroupDefinitions[46];
        public IAiActorDefinition e6_cov_inf0 => Scenario.AiSquadGroupDefinitions[47];
        public IAiOrders e1_mars_johnson_init0 => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders e1_mars_johnson_init1 => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders e1_mars_johnson_engage => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders e1_mars_johnson_advance0 => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders e1_mars_johnson_advance1 => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders e1_mars_johnson_advance2 => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders e1_mars_johnson_cower0 => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders e1_mars_inf0_init0 => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders e1_mars_inf0_init1 => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders e1_mars_inf0_engage => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders e1_mars_inf0_advance0 => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders e1_mars_inf0_advance1 => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders e1_mars_inf0_advance2 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders e1_mars_inf0_cower0 => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders e1_mars_inf1_init0 => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders e1_mars_inf1_init1 => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders e1_mars_inf1_engage => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders e1_mars_inf1_advance0 => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders e1_mars_inf1_advance1 => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders e1_mars_inf1_advance2 => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders e1_mars_inf1_cower0 => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders e1_cov_inf0_0_init => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders e1_cov_inf0_1_init => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders e1_cov_inf0_2_init => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders e1_cov_inf0_3_init => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders e1_cov_inf0_3_engage0 => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders e1_cov_inf1_0_init => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders e1_cov_inf1_1_init => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders e1_cov_inf1_engage0 => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders e1_cov_inf2_engage0 => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders e1_cov_inf2_advance0 => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders e1_cov_inf2_advance1 => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders e1_cov_inf2_2_init => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders e1_cov_inf2_4_init => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders e1_cov_inf2_5_init => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders e1_cov_inf2_7_init => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders e1_cov_inf3_init => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders e1_cov_inf3_advance0 => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders e1_cov_inf3_2_init => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders e1_cov_inf4_0_init => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders e1_cov_inf4_1_init => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders e1_cov_phantom0_init => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders e2_mars_inf0_init => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders e2_mars_inf0_engage => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders e2_mars_inf0_cower => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders e2_mars_inf0_follow => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders e2_mars_johnson_init => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders e2_mars_johnson_advance => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders e2_cov_hunters0_init => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders e2_cov_hunters0_cover0 => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders e2_cov_hunters0_follow => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders e2_cov_inf0_init => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders e2_cov_inf0_flee => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders e3_mars_inf0_wait => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders e3_mars_inf0_advance0 => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders e3_mars_inf0_advance1 => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders e3_mars_inf0_advance2 => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders e3_mars_johnson_wait => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders e3_mars_johnson_engage0 => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders e3_cov_inf0_0_init => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders e3_cov_inf0_0_regroup => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders e3_cov_inf0_1_init => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders e3_cov_inf0_2_init => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders e4_mars_inf0_wait0 => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders e4_mars_inf0_engage0 => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders e4_mars_inf0_engage1 => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders e4_mars_inf0_wait2 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders e4_cov_inf0_init => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders e4_cov_inf0_regroup => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders e4_cov_inf1_init => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders e4_cov_inf2_init => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders e4_cov_snipers0_0_init => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders e4_cov_snipers0_1_init => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders e4_cov_snipers0_2_init => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders e5_mars_inf0_follow => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders e5_mars_inf0_engage0 => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders e5_mars_inf0_engage1 => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders e5_mars_inf0_wait => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders e5_cov_inf0_0_init => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders e5_cov_inf0_1_init => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders e5_cov_inf1_0_init => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders e5_cov_inf1_1_init => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders e5_cov_inf1_retreat0 => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders e5_cov_inf2_init => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders e5_cov_inf3_init => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders e5_cov_inf4_init => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders e6_mars_inf0_follow => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders e6_mars_inf0_attack => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders e6_mars_inf0_advance => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders e6_mars_inf1_init => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders e6_mars_inf2_init => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders e6_cov_inf0_0_init => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders e6_cov_inf0_1_init => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders e6_cov_inf0_2_init => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders e6_cov_inf0_alert_right => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders e6_cov_inf0_alert_left => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders e6_cov_inf0_advance0 => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders e6_cov_inf1_init => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders e6_cov_inf1_retreat => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders e7_mars_inf0_follow => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders e7_mars_inf0_hide => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders e7_mars_inf0_attack => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders e7_cov_inf0_init => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders e7_cov_inf0_scramble => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders e8_mars_inf0_init => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders e8_mars_inf0_cower0 => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders e8_mars_inf0_engage0 => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders e8_mars_inf0_wait => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders e8_mars_warthog0_init => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders e8_mars_warthog0_continue => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders e8_cov_inf0_init => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders e8_cov_inf1_init => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders e8_cov_inf2_init => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders e8_cov_ghosts0_0_init => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders e8_cov_ghosts0_1_init => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders e8_cov_phantom0_init => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders ____BEACH____1 => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders e9_mars_warthog0_advance0 => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders e9_mars_warthog0_advance1 => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders e9_mars_warthog0_continue => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders e9_cov_ghosts0_init => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders e9_cov_creep0_init => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders e9_cov_inf0_init => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders e9_cov_inf0_retreat0 => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders e9_cov_inf1_0_init => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders e9_cov_inf1_1_init => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders e9_cov_inf1_2_init => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders e9_cov_inf1_regroup0 => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders e10_mars_warthog0_engage0 => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders e10_mars_warthog0_engage1 => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders e10_mars_warthog0_cower0 => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders e10_mars_warthog0_engage2 => Scenario.AiOrderDefinitions[131].GameObject;
        public IAiOrders e10_mars_warthog0_continue => Scenario.AiOrderDefinitions[132].GameObject;
        public IAiOrders e10_cov_inf0_init => Scenario.AiOrderDefinitions[133].GameObject;
        public IAiOrders e10_cov_inf1_init => Scenario.AiOrderDefinitions[134].GameObject;
        public IAiOrders e10_cov_ghosts0_engage0 => Scenario.AiOrderDefinitions[135].GameObject;
        public IAiOrders e10_cov_ghosts0_cower0 => Scenario.AiOrderDefinitions[136].GameObject;
        public IAiOrders e10_cov_ghosts1_init => Scenario.AiOrderDefinitions[137].GameObject;
        public IAiOrders e10_cov_phantom0_init => Scenario.AiOrderDefinitions[138].GameObject;
        public IAiOrders e10_cov_phantom0_retreat0 => Scenario.AiOrderDefinitions[139].GameObject;
        public IAiOrders e11_mars_inf0_init => Scenario.AiOrderDefinitions[140].GameObject;
        public IAiOrders e11_mars_inf0_advance0 => Scenario.AiOrderDefinitions[141].GameObject;
        public IAiOrders e11_mars_warthog0_engage0 => Scenario.AiOrderDefinitions[142].GameObject;
        public IAiOrders e11_mars_warthog0_engage1 => Scenario.AiOrderDefinitions[143].GameObject;
        public IAiOrders e11_mars_warthog0_engage2 => Scenario.AiOrderDefinitions[144].GameObject;
        public IAiOrders e11_mars_warthog0_continue => Scenario.AiOrderDefinitions[145].GameObject;
        public IAiOrders e11_cov_phantom0_init => Scenario.AiOrderDefinitions[146].GameObject;
        public IAiOrders e11_cov_inf0_init => Scenario.AiOrderDefinitions[147].GameObject;
        public IAiOrders e11_cov_inf1_0_init => Scenario.AiOrderDefinitions[148].GameObject;
        public IAiOrders e11_cov_inf1_1_init => Scenario.AiOrderDefinitions[149].GameObject;
        public IAiOrders e11_cov_inf2_init => Scenario.AiOrderDefinitions[150].GameObject;
        public IAiOrders e11_cov_ghosts0_init => Scenario.AiOrderDefinitions[151].GameObject;
        public IAiOrders e11_cov_ghosts0_regroup => Scenario.AiOrderDefinitions[152].GameObject;
        public IAiOrders ____TUNNEL____1 => Scenario.AiOrderDefinitions[153].GameObject;
        public IAiOrders e12_mars_inf1_init => Scenario.AiOrderDefinitions[154].GameObject;
        public IAiOrders e12_mars_warthog0_engage0 => Scenario.AiOrderDefinitions[155].GameObject;
        public IAiOrders e12_mars_warthog0_engage1 => Scenario.AiOrderDefinitions[156].GameObject;
        public IAiOrders e12_mars_warthog0_engage2 => Scenario.AiOrderDefinitions[157].GameObject;
        public IAiOrders e12_mars_warthog0_engage4 => Scenario.AiOrderDefinitions[158].GameObject;
        public IAiOrders e12_mars_warthog0_engage_ghosts => Scenario.AiOrderDefinitions[159].GameObject;
        public IAiOrders e12_mars_warthog0_engage_creep => Scenario.AiOrderDefinitions[160].GameObject;
        public IAiOrders e12_mars_warthog0_continue => Scenario.AiOrderDefinitions[161].GameObject;
        public IAiOrders e12_mars_warthog1_init => Scenario.AiOrderDefinitions[162].GameObject;
        public IAiOrders e12_mars_warthog1_continue => Scenario.AiOrderDefinitions[163].GameObject;
        public IAiOrders e12_cov_inf0_0_init => Scenario.AiOrderDefinitions[164].GameObject;
        public IAiOrders e12_cov_inf0_1_init => Scenario.AiOrderDefinitions[165].GameObject;
        public IAiOrders e12_cov_inf0_2_init => Scenario.AiOrderDefinitions[166].GameObject;
        public IAiOrders e12_cov_inf0_3_init => Scenario.AiOrderDefinitions[167].GameObject;
        public IAiOrders e12_cov_inf0_4_init => Scenario.AiOrderDefinitions[168].GameObject;
        public IAiOrders e12_cov_inf0_5_init => Scenario.AiOrderDefinitions[169].GameObject;
        public IAiOrders e12_cov_inf0_6_init => Scenario.AiOrderDefinitions[170].GameObject;
        public IAiOrders e12_cov_creep0_init => Scenario.AiOrderDefinitions[171].GameObject;
        public IAiOrders e12_cov_ghosts0_init => Scenario.AiOrderDefinitions[172].GameObject;
        public IAiOrders e12_cov_ghosts0_follow => Scenario.AiOrderDefinitions[173].GameObject;
        public IAiOrders e13_mars_warthog0_drive0 => Scenario.AiOrderDefinitions[174].GameObject;
        public IAiOrders e13_cov_creep0_drive => Scenario.AiOrderDefinitions[175].GameObject;
        public IAiOrders e13_cov_creep0_defend => Scenario.AiOrderDefinitions[176].GameObject;
        public IAiOrders e13_cov_ghosts0_init => Scenario.AiOrderDefinitions[177].GameObject;
        public IAiOrders e13_cov_ghosts1_init => Scenario.AiOrderDefinitions[178].GameObject;
        public IAiOrders e13_mars_warthog0_drive1 => Scenario.AiOrderDefinitions[179].GameObject;
        public IAiOrders e13_mars_warthog0_drive2 => Scenario.AiOrderDefinitions[180].GameObject;
        public IAiOrders e13_mars_ride_into_sunset => Scenario.AiOrderDefinitions[181].GameObject;
        public IAiOrders e5b_cov_inf0_sray => Scenario.AiOrderDefinitions[182].GameObject;
        public IAiOrders e1_cov_snipers0_init => Scenario.AiOrderDefinitions[183].GameObject;
        public ILocationFlag e1_door_breaker => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag e2_test => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag e2_wall_breaker => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag e2_wall_tap => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag e3_test => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag e4_test => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag e5_test => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag e5_looking_at_grunt => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag e6_test => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag e7_test => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag e7_door_breaker0 => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag e8_test => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag e9_test => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag e10_test => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag e11_test => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag e11_pod0 => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag e11_pod1 => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag e11_pod2 => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag e11_pod3 => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag e11_pod4 => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag e11_pod5 => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag e11_cov_inf1_entry => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag e12_test => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag e13_test => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag anchor_flag_intro => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag e1_longsword_rocket0 => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag e1_longsword_rocket1 => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag e1_longsword_rocket2 => Scenario.LocationFlagDefinitions[27];
        public ILocationFlag e1_cov_inf3_entrance => Scenario.LocationFlagDefinitions[28];
        public ILocationFlag e9_dialog_trigger => Scenario.LocationFlagDefinitions[29];
        public ILocationFlag e11_tunnel_entrance => Scenario.LocationFlagDefinitions[30];
        public ILocationFlag intro_railing_flag_01 => Scenario.LocationFlagDefinitions[31];
        public ILocationFlag intro_railing_flag_02 => Scenario.LocationFlagDefinitions[32];
        public ILocationFlag intro_railing_flag_03 => Scenario.LocationFlagDefinitions[33];
        public ILocationFlag intro_railing_flag_04 => Scenario.LocationFlagDefinitions[34];
        public ILocationFlag bsp_1_2_garage => Scenario.LocationFlagDefinitions[35];
        public ILocationFlag bsp_2_1_garage => Scenario.LocationFlagDefinitions[36];
        public ILocationFlag e5b_return => Scenario.LocationFlagDefinitions[37];
        public ILocationFlag e2_cov_hunters0_entry => Scenario.LocationFlagDefinitions[38];
        public ILocationFlag intro_junction_flag_01 => Scenario.LocationFlagDefinitions[39];
        public ILocationFlag bus_flag_01 => Scenario.LocationFlagDefinitions[40];
        public ILocationFlag bus_flag_02 => Scenario.LocationFlagDefinitions[41];
        public ICinematicTitle title0 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title1 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title2 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume bsp_1_0 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_1_2 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume bsp_2_1 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume tv_e1_cov_inf0_2_begin => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume tv_e1_cov_inf2_1_unsafe => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume tv_e1_cov_inf2_2_unsafe => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume tv_e1_cov_inf2_3_unsafe => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume tv_e1_cov_inf2_4_unsafe => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume tv_e1_cov_inf2_5_unsafe => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume tv_e1_cov_inf4_retreat => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume tv_e1_cov_inf4_1_unsafe => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume tv_e1_cov_inf4_2_unsafe => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_e1_near_falcon => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume tv_e2_hunters_bypassed => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_e3_main_begin0 => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_e3_main_begin1 => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_e3_crossing_street => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_e4_main_begin => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume tv_e4_player_moved_up => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume tv_e4_cov_inf1_main_begin => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume tv_e5_player_advanced => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume tv_e5_main_begin0 => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume tv_e5_main_begin1 => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_e5_ambush_trigger0 => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_e5_ambush_trigger1 => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume tv_e5_ambush_trigger2 => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_e5_advanced0 => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_e6_main_begin0 => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume tv_e6_main_begin1 => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume tv_e6_main_begin2 => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume tv_e6_hotel_entrance => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_e6_lead0 => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_e6_lead1 => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume tv_e6_hotel_vicinity => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume tv_e6_left_side => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_e6_right_side => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_e7_main_begin => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_e7_cov_inf0_init => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_e7_cov_inf0_alert => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_e7_cov_inf0_spring_ambush => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_e8_main_begin => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume tv_e8_hotel_exit => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_e8_area => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume tv_e8_second_floor_unsafe => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_e8_cov_inf1_1_unsafe => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_e8_mars_inf2_1_unsafe => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_e9_main_begin => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume tv_e9_near_entrance => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume tv_e9_bypass => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume tv_e10_main_begin => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume tv_e11_main_begin => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume tv_e11_tunnel_entrance => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume tv_e12_main_begin => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume tv_e12_mars_inf1_begin => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume tv_e12_cov_inf0_1_begin => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume tv_e12_cov_inf0_2_begin => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume tv_e12_cov_inf0_3_begin => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume tv_e12_cov_inf0_4_begin => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume tv_e12_player_passed_warthog1 => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume tv_e12_cov_ghosts0_begin => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume tv_e12_scarab_begin => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume tv_e13_cov_creep0_reins0 => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume tv_e13_creep0_begin => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume tv_e13_cov_creep0_6_begin => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume tv_mission_end => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume tv_e3_exit => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume tv_e2_main_begin => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume tv_e2_main_begin_exclude => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume tv_e13_dialog => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume tv_e9_flock0 => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume tv_e9_flock1 => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume tv_e11_flock0 => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume tv_e4_flock0 => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume tv_e7_hall => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume tv_e8_vehicle_spawn_area => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume tv_e1_building_entrance => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume tv_e9_near_guntower => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume tv_e1_crash_area_exit => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume tv_e1_main_area_entrance => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume tv_e12_mars_warthog1_begin => Scenario.TriggerVolumes[80].GameObject;
        public ITriggerVolume tv_e3_johnson_required => Scenario.TriggerVolumes[81].GameObject;
        public ITriggerVolume tv_e3_johnson_teleport_unsafe => Scenario.TriggerVolumes[82].GameObject;
        public ITriggerVolume tv_e13_cov_creep0_reins1 => Scenario.TriggerVolumes[83].GameObject;
        public ITriggerVolume tv_e13_main_begin => Scenario.TriggerVolumes[84].GameObject;
        public ITriggerVolume tv_e10_cov_phantom0_begin => Scenario.TriggerVolumes[85].GameObject;
        public ITriggerVolume tv_e10_mars_warthog0_unsafe => Scenario.TriggerVolumes[86].GameObject;
        public ITriggerVolume tv_e11_area => Scenario.TriggerVolumes[87].GameObject;
        public ITriggerVolume tv_e11_on_fort => Scenario.TriggerVolumes[88].GameObject;
        public ITriggerVolume tv_e11_near_exit => Scenario.TriggerVolumes[89].GameObject;
        public ITriggerVolume tv_e11_tunnel => Scenario.TriggerVolumes[90].GameObject;
        public ITriggerVolume tv_e1_on_building => Scenario.TriggerVolumes[91].GameObject;
        public ITriggerVolume tv_e1_inside_building => Scenario.TriggerVolumes[92].GameObject;
        public ITriggerVolume tv_e1_top_floor => Scenario.TriggerVolumes[93].GameObject;
        public ITriggerVolume tv_e13_waypoint0 => Scenario.TriggerVolumes[94].GameObject;
        public ITriggerVolume tv_e13_waypoint1 => Scenario.TriggerVolumes[95].GameObject;
        public ITriggerVolume tv_e12_cov_inf0_6_begin => Scenario.TriggerVolumes[96].GameObject;
        public ITriggerVolume tv_e12_cov_inf0_6_migrate => Scenario.TriggerVolumes[97].GameObject;
        public ITriggerVolume tv_e12_cov_inf0_5_begin => Scenario.TriggerVolumes[98].GameObject;
        public ITriggerVolume tv_e9_dialogue => Scenario.TriggerVolumes[99].GameObject;
        public ITriggerVolume tv_dark_area0 => Scenario.TriggerVolumes[100].GameObject;
        public ITriggerVolume tv_dark_area1 => Scenario.TriggerVolumes[101].GameObject;
        public ITriggerVolume tv_dark_area2 => Scenario.TriggerVolumes[102].GameObject;
        public ITriggerVolume tv_dark_area3 => Scenario.TriggerVolumes[103].GameObject;
        public ITriggerVolume tv_beach => Scenario.TriggerVolumes[104].GameObject;
        public ITriggerVolume tv_e11_mars_warthog0_unsafe => Scenario.TriggerVolumes[105].GameObject;
        public ITriggerVolume tv_e9_retreat_checkpoint => Scenario.TriggerVolumes[106].GameObject;
        public ITriggerVolume tv_e8_cov_inf2_begin => Scenario.TriggerVolumes[107].GameObject;
        public ITriggerVolume tv_e1_cov_inf0_1_begin => Scenario.TriggerVolumes[108].GameObject;
        public ITriggerVolume tv_e12_mars_warthog0_preserve => Scenario.TriggerVolumes[109].GameObject;
        public ITriggerVolume tv_e10_music => Scenario.TriggerVolumes[110].GameObject;
        public ITriggerVolume tv_e13_end_entrance => Scenario.TriggerVolumes[111].GameObject;
        public ITriggerVolume tv_e5_cov_inf1_unsafe0 => Scenario.TriggerVolumes[112].GameObject;
        public ITriggerVolume tv_e5_cov_inf1_unsafe1 => Scenario.TriggerVolumes[113].GameObject;
        public ITriggerVolume tv_e5_cov_inf1_done => Scenario.TriggerVolumes[114].GameObject;
        public ITriggerVolume tv_e3_mars_pelican0_begin => Scenario.TriggerVolumes[115].GameObject;
        public ITriggerVolume tv_e5b_main => Scenario.TriggerVolumes[116].GameObject;
        public ITriggerVolume tv_e5_advanced1 => Scenario.TriggerVolumes[117].GameObject;
        public ITriggerVolume tv_e13_end_area => Scenario.TriggerVolumes[118].GameObject;
        public ITriggerVolume tv_e5_ghost_key => Scenario.TriggerVolumes[119].GameObject;
        public ITriggerVolume tv_e5b_bounds => Scenario.TriggerVolumes[120].GameObject;
        public ITriggerVolume tv_e4_cov_inf2_begin => Scenario.TriggerVolumes[121].GameObject;
        public ITriggerVolume tv_e1_cov_sniper0_0_unsafe => Scenario.TriggerVolumes[122].GameObject;
        public ITriggerVolume tv_e1_cov_sniper0_1_unsafe => Scenario.TriggerVolumes[123].GameObject;
        public ITriggerVolume tv_e1_cov_sniper0_2_unsafe => Scenario.TriggerVolumes[124].GameObject;
        public ITriggerVolume tv_e1_cov_sniper0_3_unsafe => Scenario.TriggerVolumes[125].GameObject;
        public ITriggerVolume tv_e1_cov_inf1_unsafe => Scenario.TriggerVolumes[126].GameObject;
        public ITriggerVolume tv_e1_ghost_key => Scenario.TriggerVolumes[127].GameObject;
        public ITriggerVolume tv_e4_end_of_street => Scenario.TriggerVolumes[128].GameObject;
        public ITriggerVolume tv_e1_prediction => Scenario.TriggerVolumes[129].GameObject;
        public ITriggerVolume tv_e5_main_begin2 => Scenario.TriggerVolumes[130].GameObject;
        public ITriggerVolume tv_e10_early_begin => Scenario.TriggerVolumes[131].GameObject;
        public IStartingProfile starting_profile => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile respawn_profile => Scenario.StartingProfileDefinitions[1].GameObject;
        public IStartingProfile wimpy => Scenario.StartingProfileDefinitions[2].GameObject;
        public IDeviceGroup e9_watchtower0 => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup e11_watchtower0 => Scenario.DeviceGroupDefinitions[1].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            temp_bridge_ball = new ScenarioEntity<IBloc>(0, scenarioTag.WellKnownItems[0]);
            anchor_intro = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            iac = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            scarab = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            scope = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            helmet = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            magazine = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            battle_rifle_01 = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            battle_rifle_02 = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            sniper_rifle = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            e1_truck0 = new ScenarioEntity<IBloc>(10, scenarioTag.WellKnownItems[10]);
            e1_truck1 = new ScenarioEntity<IBloc>(11, scenarioTag.WellKnownItems[11]);
            iac_bridge = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            speaker0 = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            speaker1 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            speaker2 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            speaker3 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            speaker4 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            speaker6 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            speaker7 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            speaker8 = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            intro_railing_01 = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            intro_railing_02 = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            intro_railing_03 = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            intro_railing_04 = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            intro_railing_05 = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            intro_railing_06 = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            intro_railing_07 = new ScenarioEntity<IScenery>(27, scenarioTag.WellKnownItems[27]);
            carrier = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            scarab_turret = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            crashed_pelican = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            e2_hunter_smoke = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            e2_hunter_door_sound_source = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            intro_flak_01 = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            intro_flak_02 = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            intro_crash_01 = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            intro_crash_02 = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            intro_crash_03 = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            intro_crash_04 = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            intro_crash_05 = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            offending_palm_01 = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            offending_palm_02 = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            offending_palm_03 = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            offending_palm_04 = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            offending_palm_05 = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            offending_palm_06 = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            offending_palm_07 = new ScenarioEntity<IScenery>(46, scenarioTag.WellKnownItems[46]);
            offending_palm_08 = new ScenarioEntity<IScenery>(47, scenarioTag.WellKnownItems[47]);
            offending_palm_09 = new ScenarioEntity<IScenery>(48, scenarioTag.WellKnownItems[48]);
            offending_palm_10 = new ScenarioEntity<IScenery>(49, scenarioTag.WellKnownItems[49]);
            offending_palm_11 = new ScenarioEntity<IScenery>(50, scenarioTag.WellKnownItems[50]);
            offending_palm_12 = new ScenarioEntity<IScenery>(51, scenarioTag.WellKnownItems[51]);
            offending_palm_13 = new ScenarioEntity<IScenery>(52, scenarioTag.WellKnownItems[52]);
            offending_palm_14 = new ScenarioEntity<IScenery>(53, scenarioTag.WellKnownItems[53]);
            offending_palm_15 = new ScenarioEntity<IScenery>(54, scenarioTag.WellKnownItems[54]);
            offending_palm_16 = new ScenarioEntity<IScenery>(55, scenarioTag.WellKnownItems[55]);
            offending_palm_17 = new ScenarioEntity<IScenery>(56, scenarioTag.WellKnownItems[56]);
            offending_palm_18 = new ScenarioEntity<IScenery>(57, scenarioTag.WellKnownItems[57]);
            offending_palm_19 = new ScenarioEntity<IScenery>(58, scenarioTag.WellKnownItems[58]);
            offending_palm_20 = new ScenarioEntity<IScenery>(59, scenarioTag.WellKnownItems[59]);
            the_fiscal_year = new ScenarioEntity<IBloc>(60, scenarioTag.WellKnownItems[60]);
            johnson = new ScenarioEntity<IUnit>(61, scenarioTag.WellKnownItems[61]);
            pilot = new ScenarioEntity<IUnit>(62, scenarioTag.WellKnownItems[62]);
            copilot = new ScenarioEntity<IUnit>(63, scenarioTag.WellKnownItems[63]);
            chief = new ScenarioEntity<IUnit>(64, scenarioTag.WellKnownItems[64]);
            miranda = new ScenarioEntity<IUnit>(65, scenarioTag.WellKnownItems[65]);
            spotter = new ScenarioEntity<IUnit>(66, scenarioTag.WellKnownItems[66]);
            sniper = new ScenarioEntity<IUnit>(67, scenarioTag.WellKnownItems[67]);
            odst_01 = new ScenarioEntity<IUnit>(68, scenarioTag.WellKnownItems[68]);
            odst_02 = new ScenarioEntity<IUnit>(69, scenarioTag.WellKnownItems[69]);
            odst_03 = new ScenarioEntity<IUnit>(70, scenarioTag.WellKnownItems[70]);
            odst_04 = new ScenarioEntity<IUnit>(71, scenarioTag.WellKnownItems[71]);
            e3_hidden0 = new ScenarioEntity<IUnit>(72, scenarioTag.WellKnownItems[72]);
            e3_hidden1 = new ScenarioEntity<IUnit>(73, scenarioTag.WellKnownItems[73]);
            e9_guntower0 = new ScenarioEntity<IVehicle>(74, scenarioTag.WellKnownItems[74]);
            e10_guntower0 = new ScenarioEntity<IVehicle>(75, scenarioTag.WellKnownItems[75]);
            pelican_03 = new ScenarioEntity<IVehicle>(76, scenarioTag.WellKnownItems[76]);
            pelican_01 = new ScenarioEntity<IVehicle>(77, scenarioTag.WellKnownItems[77]);
            pelican_02 = new ScenarioEntity<IVehicle>(78, scenarioTag.WellKnownItems[78]);
            pelican_04 = new ScenarioEntity<IVehicle>(79, scenarioTag.WellKnownItems[79]);
            e1_gun = new ScenarioEntity<IVehicle>(80, scenarioTag.WellKnownItems[80]);
            e12_warthog0 = new ScenarioEntity<IVehicle>(81, scenarioTag.WellKnownItems[81]);
            warthog_for_the_masses = new ScenarioEntity<IVehicle>(82, scenarioTag.WellKnownItems[82]);
            e5_cov_inf0_pistol = new ScenarioEntity<IWeapon>(83, scenarioTag.WellKnownItems[83]);
            e7_gun0 = new ScenarioEntity<IWeapon>(84, scenarioTag.WellKnownItems[84]);
            e11_rocket_launcher0 = new ScenarioEntity<IWeapon>(85, scenarioTag.WellKnownItems[85]);
            e12_scarab_gun = new ScenarioEntity<IWeapon>(86, scenarioTag.WellKnownItems[86]);
            intro_scarab_gun = new ScenarioEntity<IWeapon>(87, scenarioTag.WellKnownItems[87]);
            intro_scarab_gun_turret = new ScenarioEntity<IWeapon>(88, scenarioTag.WellKnownItems[88]);
            key = new ScenarioEntity<IWeapon>(89, scenarioTag.WellKnownItems[89]);
            e1_ghost_key = new ScenarioEntity<IWeapon>(90, scenarioTag.WellKnownItems[90]);
            e11_pod0_inserter = new ScenarioEntity<IDevice>(91, scenarioTag.WellKnownItems[91]);
            e11_pod1_inserter = new ScenarioEntity<IDevice>(92, scenarioTag.WellKnownItems[92]);
            e11_pod2_inserter = new ScenarioEntity<IDevice>(93, scenarioTag.WellKnownItems[93]);
            e11_pod3_inserter = new ScenarioEntity<IDevice>(94, scenarioTag.WellKnownItems[94]);
            e11_pod4_inserter = new ScenarioEntity<IDevice>(95, scenarioTag.WellKnownItems[95]);
            e11_pod5_inserter = new ScenarioEntity<IDevice>(96, scenarioTag.WellKnownItems[96]);
            e9_watchtower0_base = new ScenarioEntity<IDevice>(97, scenarioTag.WellKnownItems[97]);
            e9_watchtower0_pod = new ScenarioEntity<IDevice>(98, scenarioTag.WellKnownItems[98]);
            e11_watchtower0_base = new ScenarioEntity<IDevice>(99, scenarioTag.WellKnownItems[99]);
            e11_watchtower0_pod = new ScenarioEntity<IDevice>(100, scenarioTag.WellKnownItems[100]);
            e2_hunter_door = new ScenarioEntity<IDevice>(101, scenarioTag.WellKnownItems[101]);
            e11_pod6_inserter = new ScenarioEntity<IDevice>(102, scenarioTag.WellKnownItems[102]);
            tunnel_scarab = new ScenarioEntity<IDevice>(103, scenarioTag.WellKnownItems[103]);
            e1_mars_johnson = new Squad_e1_mars_johnson(scenarioTag);
            e1_mars_inf0 = new Squad_e1_mars_inf0(scenarioTag);
            e1_mars_inf1 = new Squad_e1_mars_inf1(scenarioTag);
            e1_mars_inf2 = new Squad_e1_mars_inf2(scenarioTag);
            e1_mars_pelican0 = new Squad_e1_mars_pelican0(scenarioTag);
            e1_cov_inf0_0 = new Squad_e1_cov_inf0_0(scenarioTag);
            e1_cov_inf0_1 = new Squad_e1_cov_inf0_1(scenarioTag);
            e1_cov_inf0_2 = new Squad_e1_cov_inf0_2(scenarioTag);
            e1_cov_inf0_3 = new Squad_e1_cov_inf0_3(scenarioTag);
            e1_cov_inf1_0 = new Squad_e1_cov_inf1_0(scenarioTag);
            e1_cov_inf1_1 = new Squad_e1_cov_inf1_1(scenarioTag);
            e1_cov_inf2_0 = new Squad_e1_cov_inf2_0(scenarioTag);
            e1_cov_inf2_1 = new Squad_e1_cov_inf2_1(scenarioTag);
            e1_cov_inf2_2 = new Squad_e1_cov_inf2_2(scenarioTag);
            e1_cov_inf2_3 = new Squad_e1_cov_inf2_3(scenarioTag);
            e1_cov_inf2_4 = new Squad_e1_cov_inf2_4(scenarioTag);
            e1_cov_inf2_5 = new Squad_e1_cov_inf2_5(scenarioTag);
            e1_cov_inf2_6 = new Squad_e1_cov_inf2_6(scenarioTag);
            e1_cov_inf2_7 = new Squad_e1_cov_inf2_7(scenarioTag);
            e1_cov_inf3_0 = new Squad_e1_cov_inf3_0(scenarioTag);
            e1_cov_inf3_1 = new Squad_e1_cov_inf3_1(scenarioTag);
            e1_cov_inf3_2 = new Squad_e1_cov_inf3_2(scenarioTag);
            e1_cov_inf4_0 = new Squad_e1_cov_inf4_0(scenarioTag);
            e1_cov_inf4_1 = new Squad_e1_cov_inf4_1(scenarioTag);
            e1_cov_inf4_2 = new Squad_e1_cov_inf4_2(scenarioTag);
            e1_cov_snipers0 = new Squad_e1_cov_snipers0(scenarioTag);
            e1_cov_phantom0_0 = new Squad_e1_cov_phantom0_0(scenarioTag);
            e1_cov_phantom0_1 = new Squad_e1_cov_phantom0_1(scenarioTag);
            e2_mars_inf0 = new Squad_e2_mars_inf0(scenarioTag);
            e2_mars_johnson = new Squad_e2_mars_johnson(scenarioTag);
            e2_cov_inf0 = new Squad_e2_cov_inf0(scenarioTag);
            e2_cov_hunters0 = new Squad_e2_cov_hunters0(scenarioTag);
            e3_mars_inf0 = new Squad_e3_mars_inf0(scenarioTag);
            e3_mars_inf1 = new Squad_e3_mars_inf1(scenarioTag);
            e3_mars_johnson = new Squad_e3_mars_johnson(scenarioTag);
            e3_mars_pelican0 = new Squad_e3_mars_pelican0(scenarioTag);
            e3_cov_inf0_0 = new Squad_e3_cov_inf0_0(scenarioTag);
            e3_cov_inf0_1 = new Squad_e3_cov_inf0_1(scenarioTag);
            e3_cov_inf0_2 = new Squad_e3_cov_inf0_2(scenarioTag);
            e3_cov_inf0_3 = new Squad_e3_cov_inf0_3(scenarioTag);
            e4_mars_inf0 = new Squad_e4_mars_inf0(scenarioTag);
            e4_cov_inf0_0 = new Squad_e4_cov_inf0_0(scenarioTag);
            e4_cov_inf0_1 = new Squad_e4_cov_inf0_1(scenarioTag);
            e4_cov_inf1_0 = new Squad_e4_cov_inf1_0(scenarioTag);
            e4_cov_inf1_1 = new Squad_e4_cov_inf1_1(scenarioTag);
            e4_cov_inf2 = new Squad_e4_cov_inf2(scenarioTag);
            e4_cov_snipers0_0 = new Squad_e4_cov_snipers0_0(scenarioTag);
            e4_cov_snipers0_1 = new Squad_e4_cov_snipers0_1(scenarioTag);
            e4_cov_snipers0_2 = new Squad_e4_cov_snipers0_2(scenarioTag);
            e5_mars_inf0 = new Squad_e5_mars_inf0(scenarioTag);
            e5_cov_inf0_0 = new Squad_e5_cov_inf0_0(scenarioTag);
            e5_cov_inf0_1 = new Squad_e5_cov_inf0_1(scenarioTag);
            e5_cov_inf1_0 = new Squad_e5_cov_inf1_0(scenarioTag);
            e5_cov_inf1_1 = new Squad_e5_cov_inf1_1(scenarioTag);
            e5_cov_inf2 = new Squad_e5_cov_inf2(scenarioTag);
            e5_cov_inf3 = new Squad_e5_cov_inf3(scenarioTag);
            e5_cov_inf4 = new Squad_e5_cov_inf4(scenarioTag);
            e5b_cov_inf0 = new Squad_e5b_cov_inf0(scenarioTag);
            e6_mars_inf0 = new Squad_e6_mars_inf0(scenarioTag);
            e6_mars_inf0_1 = new Squad_e6_mars_inf0_1(scenarioTag);
            e6_mars_inf1 = new Squad_e6_mars_inf1(scenarioTag);
            e6_cov_inf0_0 = new Squad_e6_cov_inf0_0(scenarioTag);
            e6_cov_inf0_1 = new Squad_e6_cov_inf0_1(scenarioTag);
            e6_cov_inf0_2 = new Squad_e6_cov_inf0_2(scenarioTag);
            e6_cov_inf1 = new Squad_e6_cov_inf1(scenarioTag);
            e7_mars_inf0 = new Squad_e7_mars_inf0(scenarioTag);
            e7_cov_inf0 = new Squad_e7_cov_inf0(scenarioTag);
            e8_mars_inf0 = new Squad_e8_mars_inf0(scenarioTag);
            e8_mars_warthog0 = new Squad_e8_mars_warthog0(scenarioTag);
            e8_cov_inf0 = new Squad_e8_cov_inf0(scenarioTag);
            e8_cov_inf1 = new Squad_e8_cov_inf1(scenarioTag);
            e8_cov_inf2 = new Squad_e8_cov_inf2(scenarioTag);
            e8_cov_ghosts0_0 = new Squad_e8_cov_ghosts0_0(scenarioTag);
            e8_cov_ghosts0_1 = new Squad_e8_cov_ghosts0_1(scenarioTag);
            e8_cov_phantom0 = new Squad_e8_cov_phantom0(scenarioTag);
            ____BEACH____ = new Squad_____BEACH____(scenarioTag);
            e9_mars_test = new Squad_e9_mars_test(scenarioTag);
            e9_mars_warthog0 = new Squad_e9_mars_warthog0(scenarioTag);
            e9_cov_ghosts0 = new Squad_e9_cov_ghosts0(scenarioTag);
            e9_cov_shadow0 = new Squad_e9_cov_shadow0(scenarioTag);
            e9_cov_inf0 = new Squad_e9_cov_inf0(scenarioTag);
            e9_cov_inf1_0 = new Squad_e9_cov_inf1_0(scenarioTag);
            e9_cov_inf1_1 = new Squad_e9_cov_inf1_1(scenarioTag);
            e9_cov_inf1_2 = new Squad_e9_cov_inf1_2(scenarioTag);
            e10_mars_test = new Squad_e10_mars_test(scenarioTag);
            e10_mars_warthog0 = new Squad_e10_mars_warthog0(scenarioTag);
            e10_mars_inf0 = new Squad_e10_mars_inf0(scenarioTag);
            e10_cov_inf0 = new Squad_e10_cov_inf0(scenarioTag);
            e10_cov_inf1 = new Squad_e10_cov_inf1(scenarioTag);
            e10_cov_ghosts0_0 = new Squad_e10_cov_ghosts0_0(scenarioTag);
            e10_cov_ghosts0_1 = new Squad_e10_cov_ghosts0_1(scenarioTag);
            e10_cov_ghosts1 = new Squad_e10_cov_ghosts1(scenarioTag);
            e10_cov_phantom0 = new Squad_e10_cov_phantom0(scenarioTag);
            e11_mars_inf0 = new Squad_e11_mars_inf0(scenarioTag);
            e11_mars_warthog0 = new Squad_e11_mars_warthog0(scenarioTag);
            e11_cov_inf0 = new Squad_e11_cov_inf0(scenarioTag);
            e11_cov_inf1_0 = new Squad_e11_cov_inf1_0(scenarioTag);
            e11_cov_inf1_1 = new Squad_e11_cov_inf1_1(scenarioTag);
            e11_cov_inf2 = new Squad_e11_cov_inf2(scenarioTag);
            e11_cov_ghosts0_0 = new Squad_e11_cov_ghosts0_0(scenarioTag);
            e11_cov_ghosts0_1 = new Squad_e11_cov_ghosts0_1(scenarioTag);
            ____TUNNEL____ = new Squad_____TUNNEL____(scenarioTag);
            e12_mars_warthog0 = new Squad_e12_mars_warthog0(scenarioTag);
            e12_mars_warthog1 = new Squad_e12_mars_warthog1(scenarioTag);
            e12_mars_inf0 = new Squad_e12_mars_inf0(scenarioTag);
            e12_mars_inf1 = new Squad_e12_mars_inf1(scenarioTag);
            e12_cov_inf0_0 = new Squad_e12_cov_inf0_0(scenarioTag);
            e12_cov_inf0_1 = new Squad_e12_cov_inf0_1(scenarioTag);
            e12_cov_inf0_2 = new Squad_e12_cov_inf0_2(scenarioTag);
            e12_cov_inf0_3 = new Squad_e12_cov_inf0_3(scenarioTag);
            e12_cov_inf0_4 = new Squad_e12_cov_inf0_4(scenarioTag);
            e12_cov_inf0_5 = new Squad_e12_cov_inf0_5(scenarioTag);
            e12_cov_inf0_6 = new Squad_e12_cov_inf0_6(scenarioTag);
            e12_cov_creep0 = new Squad_e12_cov_creep0(scenarioTag);
            e12_cov_ghosts0 = new Squad_e12_cov_ghosts0(scenarioTag);
            e12_scarab_gunner = new Squad_e12_scarab_gunner(scenarioTag);
            e13_mars_warthog0 = new Squad_e13_mars_warthog0(scenarioTag);
            e13_cov_creep0_0 = new Squad_e13_cov_creep0_0(scenarioTag);
            e13_cov_creep0_1 = new Squad_e13_cov_creep0_1(scenarioTag);
            e13_cov_creep0_2 = new Squad_e13_cov_creep0_2(scenarioTag);
            e13_cov_creep0_3 = new Squad_e13_cov_creep0_3(scenarioTag);
            e13_cov_creep0_4 = new Squad_e13_cov_creep0_4(scenarioTag);
            e13_cov_creep0_5 = new Squad_e13_cov_creep0_5(scenarioTag);
            e13_cov_creep0_6 = new Squad_e13_cov_creep0_6(scenarioTag);
            e13_cov_creep0_7 = new Squad_e13_cov_creep0_7(scenarioTag);
            e13_cov_ghosts0 = new Squad_e13_cov_ghosts0(scenarioTag);
            e13_cov_ghosts1 = new Squad_e13_cov_ghosts1(scenarioTag);
            test = new Squad_test(scenarioTag);
            intro_hog_01 = new Squad_intro_hog_01(scenarioTag);
            intro_hog_02 = new Squad_intro_hog_02(scenarioTag);
            intro_hog_03 = new Squad_intro_hog_03(scenarioTag);
            intro_hog_04 = new Squad_intro_hog_04(scenarioTag);
        }

        public class Squad_e1_mars_johnson
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition johnson0 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_e1_mars_johnson(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition marine0 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[0];
            public IAiActorDefinition marine1 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_e1_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_mars_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition marine0 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_e1_mars_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_mars_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_e1_mars_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_mars_pelican0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[0];
            public IAiActorDefinition gunner0 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[1];
            public IAiActorDefinition gunner1 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_e1_mars_pelican0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition grunt0 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[0];
            public IAiActorDefinition grunt1 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition grunt2 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_e1_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition grunt0 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[0];
            public IAiActorDefinition grunt1 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_e1_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_e1_cov_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf0_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_e1_cov_inf0_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_e1_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_e1_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_e1_cov_inf2_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_e1_cov_inf2_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_e1_cov_inf2_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_e1_cov_inf2_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2_4
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_e1_cov_inf2_4(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2_5
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[3];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_e1_cov_inf2_5(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2_6
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_e1_cov_inf2_6(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2_7
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad_e1_cov_inf2_7(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf3_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[5];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[6];
            public IAiActorDefinition starting_locations_71 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_e1_cov_inf3_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf3_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_e1_cov_inf3_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf3_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_e1_cov_inf3_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf4_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite0 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[0];
            public IAiActorDefinition grunt1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition grunt2 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition grunt3 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[3];
            public IAiActorDefinition grunt4 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[4];
            public IAiActorDefinition elite1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_e1_cov_inf4_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf4_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[0];
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_e1_cov_inf4_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf4_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_e1_cov_inf4_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_snipers0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition sniper0 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[0];
            public IAiActorDefinition sniper1 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[1];
            public IAiActorDefinition sniper2 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[2];
            public IAiActorDefinition sniper3 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[3];
            public IAiActorDefinition sniper4 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_e1_cov_snipers0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_phantom0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_e1_cov_phantom0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_phantom0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_e1_cov_phantom0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_e2_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_mars_johnson
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_e2_mars_johnson(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_e2_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_cov_hunters0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hunter0 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[0];
            public IAiActorDefinition hunter1 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_e2_cov_hunters0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_e3_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_mars_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_e3_mars_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_mars_johnson
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_e3_mars_johnson(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_mars_pelican0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_e3_mars_pelican0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_e3_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_e3_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_e3_cov_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_inf0_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_e3_cov_inf0_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_e4_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_e4_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_e4_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_e4_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_e4_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_e4_cov_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_snipers0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_e4_cov_snipers0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_snipers0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_e4_cov_snipers0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_snipers0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition sniper0 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[0];
            public IAiActorDefinition sniper1 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[1];
            public IAiActorDefinition sniper2 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_e4_cov_snipers0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_e5_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition sniper0 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[0];
            public IAiActorDefinition sniper1 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[1];
            public IAiActorDefinition sniper2 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[2];
            public IAiActorDefinition sniper3 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_e5_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_e5_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_e5_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_e5_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition sniper0 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad_e5_cov_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_e5_cov_inf3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf4
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_e5_cov_inf4(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5b_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_e5b_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_e6_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_mars_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_e6_mars_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_mars_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition marine0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[0];
            public IAiActorDefinition marine1 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_e6_mars_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition grunt0 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_e6_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_e6_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_e6_cov_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_e6_cov_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition marine0 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_e7_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_e7_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_e8_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_e8_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_e8_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[4];
            public IAiActorDefinition starting_locations_51 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[5];
            public IAiActorDefinition starting_locations_61 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[6];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[7];
            public IAiActorDefinition starting_locations_81 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_e8_cov_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[1];
            public IAiActorDefinition grunt0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_e8_cov_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_e8_cov_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_e8_cov_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_e8_cov_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_____BEACH____
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_____BEACH____(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_mars_test
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad_e9_mars_test(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_e9_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_e9_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_cov_shadow0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_e9_cov_shadow0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_e9_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_e9_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_e9_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_cov_inf1_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_e9_cov_inf1_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_mars_test
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_e10_mars_test(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[85];
            public Squad_e10_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[86];
            public Squad_e10_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[87];
            public Squad_e10_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition gunner0 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[88];
            public Squad_e10_cov_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[89];
            public Squad_e10_cov_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[90];
            public Squad_e10_cov_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_ghosts1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[91];
            public Squad_e10_cov_ghosts1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[92];
            public Squad_e10_cov_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[93];
            public Squad_e11_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[94];
            public Squad_e11_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[95];
            public Squad_e11_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite0 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[0];
            public IAiActorDefinition elite1 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[1];
            public IAiActorDefinition elite2 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[96];
            public Squad_e11_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite0 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[0];
            public IAiActorDefinition elite1 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[1];
            public IAiActorDefinition elite2 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[2];
            public IAiActorDefinition elite3 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[97];
            public Squad_e11_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_cov_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[98];
            public Squad_e11_cov_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_cov_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[0];
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[99];
            public Squad_e11_cov_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_cov_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[100];
            public Squad_e11_cov_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_____TUNNEL____
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[101];
            public Squad_____TUNNEL____(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[102];
            public Squad_e12_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_mars_warthog1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[103];
            public Squad_e12_mars_warthog1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[104];
            public Squad_e12_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_mars_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[105];
            public Squad_e12_mars_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[3];
            public IAiActorDefinition starting_locations_41 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[106];
            public Squad_e12_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[107];
            public Squad_e12_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[0];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[108];
            public Squad_e12_cov_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[109];
            public Squad_e12_cov_inf0_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_4
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[3];
            public IAiActorDefinition starting_locations_41 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[110];
            public Squad_e12_cov_inf0_4(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_5
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[111];
            public Squad_e12_cov_inf0_5(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_6
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[112];
            public Squad_e12_cov_inf0_6(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_creep0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[4];
            public IAiActorDefinition starting_locations_61 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[113];
            public Squad_e12_cov_creep0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[114];
            public Squad_e12_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_scarab_gunner
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition gunner => ScenarioTag.AiSquadDefinitions[115].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[115];
            public Squad_e12_scarab_gunner(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[0];
            public IAiActorDefinition warthog1 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[116];
            public Squad_e13_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_creep0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[117].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[117].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[117];
            public Squad_e13_cov_creep0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_creep0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[118].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[118].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[118];
            public Squad_e13_cov_creep0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_creep0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[119];
            public Squad_e13_cov_creep0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_creep0_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[120];
            public Squad_e13_cov_creep0_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_creep0_4
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[121].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[121].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[121];
            public Squad_e13_cov_creep0_4(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_creep0_5
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[122];
            public Squad_e13_cov_creep0_5(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_creep0_6
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[123];
            public Squad_e13_cov_creep0_6(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_creep0_7
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition creep0 => ScenarioTag.AiSquadDefinitions[124].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[124].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[124];
            public Squad_e13_cov_creep0_7(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[0];
            public IAiActorDefinition ghost2 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[1];
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[125];
            public Squad_e13_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_ghosts1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[126];
            public Squad_e13_cov_ghosts1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_test
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[127];
            public Squad_test(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_intro_hog_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hog => ScenarioTag.AiSquadDefinitions[128].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[128].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[128];
            public Squad_intro_hog_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_intro_hog_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hog => ScenarioTag.AiSquadDefinitions[129].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[129].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[129];
            public Squad_intro_hog_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_intro_hog_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hog => ScenarioTag.AiSquadDefinitions[130].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[130].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[130];
            public Squad_intro_hog_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_intro_hog_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hog => ScenarioTag.AiSquadDefinitions[131].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[131].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[131];
            public Squad_intro_hog_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}