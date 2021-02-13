namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_08b_deltacontrol : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> delete_me { get; set; }
        public ScenarioEntity<IScenery> e6_jail_shield0 { get; set; }
        public ScenarioEntity<IScenery> e6_jail_shield1 { get; set; }
        public ScenarioEntity<IScenery> e6_jail_shield2 { get; set; }
        public ScenarioEntity<IScenery> e6_jail_shield3 { get; set; }
        public ScenarioEntity<IScenery> e6_jail_shield4 { get; set; }
        public ScenarioEntity<IScenery> e6_jail_shield5 { get; set; }
        public ScenarioEntity<IScenery> hammer { get; set; }
        public ScenarioEntity<IScenery> index { get; set; }
        public ScenarioEntity<IScenery> anchor_intra3 { get; set; }
        public ScenarioEntity<IScenery> anchor_intra2 { get; set; }
        public ScenarioEntity<IScenery> cov_sniper { get; set; }
        public ScenarioEntity<IScenery> scarab_01 { get; set; }
        public ScenarioEntity<IScenery> index_cheat { get; set; }
        public ScenarioEntity<IScenery> anchor_intra1 { get; set; }
        public ScenarioEntity<IScenery> rotors_x09 { get; set; }
        public ScenarioEntity<IScenery> index_x09 { get; set; }
        public ScenarioEntity<IScenery> anchor_x09_02 { get; set; }
        public ScenarioEntity<IScenery> matte_halo { get; set; }
        public ScenarioEntity<IScenery> matte_high_charity { get; set; }
        public ScenarioEntity<IScenery> matte_substance { get; set; }
        public ScenarioEntity<IScenery> matte_moon { get; set; }
        public ScenarioEntity<IScenery> matte_earth { get; set; }
        public ScenarioEntity<IScenery> forerunner_ship { get; set; }
        public ScenarioEntity<IScenery> cairo { get; set; }
        public ScenarioEntity<IScenery> cairo_bridge { get; set; }
        public ScenarioEntity<IScenery> halo { get; set; }
        public ScenarioEntity<IScenery> x09_chamber_door { get; set; }
        public ScenarioEntity<IScenery> spore_01 { get; set; }
        public ScenarioEntity<IScenery> spore_02 { get; set; }
        public ScenarioEntity<IScenery> spore_03 { get; set; }
        public ScenarioEntity<IScenery> tentacle_01 { get; set; }
        public ScenarioEntity<IScenery> tentacle_02 { get; set; }
        public ScenarioEntity<IScenery> tentacle_03 { get; set; }
        public ScenarioEntity<IScenery> tentacle_04 { get; set; }
        public ScenarioEntity<IScenery> tentacle_05 { get; set; }
        public ScenarioEntity<IScenery> tentacle_06 { get; set; }
        public ScenarioEntity<IScenery> anchor_x10 { get; set; }
        public ScenarioEntity<IScenery> texture_camera { get; set; }
        public ScenarioEntity<IScenery> anchor_x09_01 { get; set; }
        public ScenarioEntity<IScenery> x09_halo_bang { get; set; }
        public ScenarioEntity<IScenery> x09_halo_whimper { get; set; }
        public ScenarioEntity<IScenery> x09_alcove { get; set; }
        public ScenarioEntity<IScenery> scarab_screen { get; set; }
        public ScenarioEntity<IBloc> x09_lift { get; set; }
        public ScenarioEntity<IScenery> slipspace { get; set; }
        public ScenarioEntity<IBloc> boss_object_1 { get; set; }
        public ScenarioEntity<IBloc> boss_object_4 { get; set; }
        public ScenarioEntity<IBloc> boss_object_5 { get; set; }
        public ScenarioEntity<IBloc> boss_object_6 { get; set; }
        public ScenarioEntity<IBloc> boss_object_7 { get; set; }
        public ScenarioEntity<IBloc> boss_object_8 { get; set; }
        public ScenarioEntity<IBloc> boss_object_9 { get; set; }
        public ScenarioEntity<IBloc> boss_object_10 { get; set; }
        public ScenarioEntity<IBloc> boss_object_11 { get; set; }
        public ScenarioEntity<IBloc> boss_object_12 { get; set; }
        public ScenarioEntity<IBloc> boss_object_13 { get; set; }
        public ScenarioEntity<IBloc> boss_object_14 { get; set; }
        public ScenarioEntity<IBloc> boss_object_15 { get; set; }
        public ScenarioEntity<IBloc> boss_object_16 { get; set; }
        public ScenarioEntity<IBloc> boss_object_17 { get; set; }
        public ScenarioEntity<IBloc> boss_object_18 { get; set; }
        public ScenarioEntity<IScenery> cairo_effect01 { get; set; }
        public ScenarioEntity<IScenery> cairo_effect02 { get; set; }
        public ScenarioEntity<IScenery> cairo_effect04 { get; set; }
        public ScenarioEntity<IScenery> cairo_effect03 { get; set; }
        public ScenarioEntity<IScenery> cairo_effect05 { get; set; }
        public ScenarioEntity<IScenery> cairo_effect06 { get; set; }
        public ScenarioEntity<IBloc> c08_intra3_lift { get; set; }
        public ScenarioEntity<IScenery> cortana_stand { get; set; }
        public ScenarioEntity<IScenery> earth_battle { get; set; }
        public ScenarioEntity<IScenery> bloom_quad { get; set; }
        public ScenarioEntity<IBloc> boss_object_19 { get; set; }
        public ScenarioEntity<IBloc> boss_object_20 { get; set; }
        public ScenarioEntity<IBloc> boss_object_21 { get; set; }
        public ScenarioEntity<IBloc> boss_object_22 { get; set; }
        public ScenarioEntity<IScenery> blast_base { get; set; }
        public ScenarioEntity<IScenery> earth_battle2 { get; set; }
        public ScenarioEntity<IScenery> blast_base2 { get; set; }
        public ScenarioEntity<IScenery> boss_object_index { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> johnson { get; set; }
        public ScenarioEntity<IUnit> dervish { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> monitor { get; set; }
        public ScenarioEntity<IUnit> brute_01 { get; set; }
        public ScenarioEntity<IUnit> brute_02 { get; set; }
        public ScenarioEntity<IUnit> brute_03 { get; set; }
        public ScenarioEntity<IUnit> brute_04 { get; set; }
        public ScenarioEntity<IUnit> dervish_02 { get; set; }
        public ScenarioEntity<IUnit> johnson_02 { get; set; }
        public ScenarioEntity<IUnit> commander { get; set; }
        public ScenarioEntity<IUnit> hood { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> officer_01 { get; set; }
        public ScenarioEntity<IUnit> officer_02 { get; set; }
        public ScenarioEntity<IUnit> cortana { get; set; }
        public ScenarioEntity<IVehicle> e12_test_banshee { get; set; }
        public ScenarioEntity<IVehicle> wraith_01 { get; set; }
        public ScenarioEntity<IVehicle> e8_banshee0 { get; set; }
        public ScenarioEntity<IVehicle> e8_banshee1 { get; set; }
        public ScenarioEntity<IWeapon> key { get; set; }
        public ScenarioEntity<IWeapon> boss_object_23 { get; set; }
        public ScenarioEntity<IWeapon> boss_object_24 { get; set; }
        public ScenarioEntity<IDevice> s8_hunter_door_switch { get; set; }
        public ScenarioEntity<IDevice> scarab { get; set; }
        public ScenarioEntity<IDevice> e13_boss_platform { get; set; }
        public ScenarioEntity<IDevice> e2_exit_door { get; set; }
        public ScenarioEntity<IDevice> e13_rotors { get; set; }
        public ScenarioEntity<IDevice> e12_door0 { get; set; }
        public ScenarioEntity<IDevice> e12_door1 { get; set; }
        public ScenarioEntity<IDevice> e11_door0 { get; set; }
        public ScenarioEntity<IDevice> e11_exit_door { get; set; }
        public ScenarioEntity<IDevice> e7_door0 { get; set; }
        public ScenarioEntity<IDevice> e6_door0 { get; set; }
        public ScenarioEntity<IDevice> scarab_door { get; set; }
        public ScenarioEntity<IDevice> repository { get; set; }
        public ScenarioEntity<IDevice> beacon_03 { get; set; }
        public ScenarioEntity<IDevice> i_dont_exist { get; set; }
        public ScenarioEntity<IDevice> beacon_02 { get; set; }
        public ScenarioEntity<IDevice> beacon_01 { get; set; }
        public ScenarioEntity<IDevice> boss_object_controlw { get; set; }
        public ICameraPathTarget platform_01a => Scenario.CameraPathTargets[0];
        public ICameraPathTarget platform_01b => Scenario.CameraPathTargets[1];
        public ICameraPathTarget platform_02 => Scenario.CameraPathTargets[2];
        public Squad_e1_cov_wraiths0_0 e1_cov_wraiths0_0 { get; set; }
        public Squad_e1_cov_wraiths0_1 e1_cov_wraiths0_1 { get; set; }
        public Squad_e1_cov_spectre0 e1_cov_spectre0 { get; set; }
        public Squad_e1_pro_ghosts0_0 e1_pro_ghosts0_0 { get; set; }
        public Squad_e1_pro_ghosts0_1 e1_pro_ghosts0_1 { get; set; }
        public Squad_e1_pro_ghosts0_2 e1_pro_ghosts0_2 { get; set; }
        public Squad_e1_pro_inf0_0 e1_pro_inf0_0 { get; set; }
        public Squad_e1_pro_inf0_1 e1_pro_inf0_1 { get; set; }
        public Squad_e1_pro_wraith0 e1_pro_wraith0 { get; set; }
        public Squad_e1_pro_phantom0 e1_pro_phantom0 { get; set; }
        public Squad_e2_cov_wraith0 e2_cov_wraith0 { get; set; }
        public Squad_e2_cov_spectre0 e2_cov_spectre0 { get; set; }
        public Squad_e2_pro_inf0 e2_pro_inf0 { get; set; }
        public Squad_e2_pro_ghosts0_0 e2_pro_ghosts0_0 { get; set; }
        public Squad_e2_pro_ghosts0_1 e2_pro_ghosts0_1 { get; set; }
        public Squad_e2_pro_wraith0_0 e2_pro_wraith0_0 { get; set; }
        public Squad_e2_pro_wraith0_1 e2_pro_wraith0_1 { get; set; }
        public Squad_e2_pro_phantom0_0 e2_pro_phantom0_0 { get; set; }
        public Squad_e2_pro_phantom0_1 e2_pro_phantom0_1 { get; set; }
        public Squad_e3_cov_inf0 e3_cov_inf0 { get; set; }
        public Squad_e3_cov_hunters0 e3_cov_hunters0 { get; set; }
        public Squad_e3_pro_inf0_0 e3_pro_inf0_0 { get; set; }
        public Squad_e3_pro_inf0_1 e3_pro_inf0_1 { get; set; }
        public Squad_e3_pro_inf1 e3_pro_inf1 { get; set; }
        public Squad_e3_pro_inf2 e3_pro_inf2 { get; set; }
        public Squad_e4_cov_inf0 e4_cov_inf0 { get; set; }
        public Squad_e4_cov_hunters0 e4_cov_hunters0 { get; set; }
        public Squad_e4_pro_inf0 e4_pro_inf0 { get; set; }
        public Squad_e4_pro_inf1 e4_pro_inf1 { get; set; }
        public Squad_e4_pro_inf2 e4_pro_inf2 { get; set; }
        public Squad_e4_pro_inf3 e4_pro_inf3 { get; set; }
        public Squad_e5_cov_inf0 e5_cov_inf0 { get; set; }
        public Squad_e5_cov_hunters0 e5_cov_hunters0 { get; set; }
        public Squad_e5_cov_grunts0 e5_cov_grunts0 { get; set; }
        public Squad_e5_cov_banshees0 e5_cov_banshees0 { get; set; }
        public Squad_e5_pro_inf0 e5_pro_inf0 { get; set; }
        public Squad_e5_pro_inf1 e5_pro_inf1 { get; set; }
        public Squad_e5_pro_inf2 e5_pro_inf2 { get; set; }
        public Squad_e5_pro_inf3 e5_pro_inf3 { get; set; }
        public Squad_e5_pro_phantom0 e5_pro_phantom0 { get; set; }
        public Squad_control_room_test control_room_test { get; set; }
        public Squad_e6_cov_inf0 e6_cov_inf0 { get; set; }
        public Squad_e6_cov_inf1_0 e6_cov_inf1_0 { get; set; }
        public Squad_e6_cov_inf1_1 e6_cov_inf1_1 { get; set; }
        public Squad_e6_cov_inf1_2 e6_cov_inf1_2 { get; set; }
        public Squad_e6_cov_inf1_3 e6_cov_inf1_3 { get; set; }
        public Squad_e6_cov_hunters0 e6_cov_hunters0 { get; set; }
        public Squad_e6_pro_inf0_0 e6_pro_inf0_0 { get; set; }
        public Squad_e6_pro_inf0_1 e6_pro_inf0_1 { get; set; }
        public Squad_e6_pro_inf0_2 e6_pro_inf0_2 { get; set; }
        public Squad_____SCARAB_RIDE____ ____SCARAB_RIDE____ { get; set; }
        public Squad_scarab_gunners scarab_gunners { get; set; }
        public Squad_e7_cov_inf0 e7_cov_inf0 { get; set; }
        public Squad_e7_cov_hunters0 e7_cov_hunters0 { get; set; }
        public Squad_e7_pro_inf0 e7_pro_inf0 { get; set; }
        public Squad_e7_mars_inf0 e7_mars_inf0 { get; set; }
        public Squad_e7_mars_inf1 e7_mars_inf1 { get; set; }
        public Squad_e8_cov_inf0 e8_cov_inf0 { get; set; }
        public Squad_e8_cov_banshees0 e8_cov_banshees0 { get; set; }
        public Squad_e8_mars_inf0 e8_mars_inf0 { get; set; }
        public Squad_e8_pro_wraiths0_0 e8_pro_wraiths0_0 { get; set; }
        public Squad_e8_pro_wraiths0_1 e8_pro_wraiths0_1 { get; set; }
        public Squad_e8_pro_wraiths0_2 e8_pro_wraiths0_2 { get; set; }
        public Squad_e9_pro_inf0 e9_pro_inf0 { get; set; }
        public Squad_e9_pro_inf3_0 e9_pro_inf3_0 { get; set; }
        public Squad_e9_pro_inf3_1 e9_pro_inf3_1 { get; set; }
        public Squad_e9_pro_phantom0 e9_pro_phantom0 { get; set; }
        public Squad_e9_pro_phantom1 e9_pro_phantom1 { get; set; }
        public Squad_e9_pro_spectres0_0 e9_pro_spectres0_0 { get; set; }
        public Squad_e9_pro_spectres0_1 e9_pro_spectres0_1 { get; set; }
        public Squad_e9_pro_banshees0 e9_pro_banshees0 { get; set; }
        public Squad_e10_cov_banshees0 e10_cov_banshees0 { get; set; }
        public Squad_e11_cov_banshees0 e11_cov_banshees0 { get; set; }
        public Squad_e11_pro_wraith0_0 e11_pro_wraith0_0 { get; set; }
        public Squad_e11_pro_wraith0_1 e11_pro_wraith0_1 { get; set; }
        public Squad_e11_pro_wraith1_0 e11_pro_wraith1_0 { get; set; }
        public Squad_e11_pro_wraith1_1 e11_pro_wraith1_1 { get; set; }
        public Squad_e11_pro_wraith1_2 e11_pro_wraith1_2 { get; set; }
        public Squad_e11_pro_wraith1_3 e11_pro_wraith1_3 { get; set; }
        public Squad_e11_pro_phantom0_0 e11_pro_phantom0_0 { get; set; }
        public Squad_e11_pro_phantom0_1 e11_pro_phantom0_1 { get; set; }
        public Squad_e11_pro_ghosts0 e11_pro_ghosts0 { get; set; }
        public Squad_e11_pro_spectres0 e11_pro_spectres0 { get; set; }
        public Squad_e11_pro_banshees0_0 e11_pro_banshees0_0 { get; set; }
        public Squad_e11_pro_banshees0_1 e11_pro_banshees0_1 { get; set; }
        public Squad_____CONTROL_ROOM____ ____CONTROL_ROOM____ { get; set; }
        public Squad_e12_cov_inf0_0 e12_cov_inf0_0 { get; set; }
        public Squad_e12_cov_inf0_1 e12_cov_inf0_1 { get; set; }
        public Squad_e12_cov_phantom0 e12_cov_phantom0 { get; set; }
        public Squad_e12_cov_banshees0 e12_cov_banshees0 { get; set; }
        public Squad_e12_pro_inf0_0 e12_pro_inf0_0 { get; set; }
        public Squad_e12_pro_inf0_1 e12_pro_inf0_1 { get; set; }
        public Squad_e12_pro_inf0_2 e12_pro_inf0_2 { get; set; }
        public Squad_e13_cov_inf0_0 e13_cov_inf0_0 { get; set; }
        public Squad_e13_cov_inf0_1 e13_cov_inf0_1 { get; set; }
        public Squad_e13_mars_johnson e13_mars_johnson { get; set; }
        public Squad_e13_mars_miranda e13_mars_miranda { get; set; }
        public Squad_e13_pro_tartarus e13_pro_tartarus { get; set; }
        public Squad_e13_pro_inf0_0 e13_pro_inf0_0 { get; set; }
        public Squad_e13_pro_inf0_1 e13_pro_inf0_1 { get; set; }
        public Squad_e13_sen_monitor e13_sen_monitor { get; set; }
        public Squad_test test { get; set; }
        public Squad_boss_tartarus boss_tartarus { get; set; }
        public Squad_boss_johnson boss_johnson { get; set; }
        public Squad_boss_brute_start boss_brute_start { get; set; }
        public Squad_boss_elite_start boss_elite_start { get; set; }
        public Squad_boss_monitor boss_monitor { get; set; }
        public Squad_boss_miranda boss_miranda { get; set; }
        public Squad_boss_brute_reenforcements boss_brute_reenforcements { get; set; }
        public Squad_boss_elite_reenforcements boss_elite_reenforcements { get; set; }
        public Squad_boss_brute_reenforcements_many boss_brute_reenforcements_many { get; set; }
        public Squad_boss_elite_reenforcements_many boss_elite_reenforcements_many { get; set; }
        public IAiActorDefinition covenant1 => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition prophets => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition marines => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition sentinels => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition e1_cov => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition e1_cov_wraiths0 => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition e1_pro => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition e1_pro_inf0 => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition e1_pro_ghosts0 => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition e2_cov => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition e2_pro => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition e2_pro_ghosts0 => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition e2_pro_wraith0 => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition e2_pro_phantom0 => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition e3_cov => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition e3_pro => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition e3_pro_inf0 => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition e4_cov => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition e4_pro => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition e5_cov => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition e5_pro => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition e6_cov => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition e6_cov_inf1 => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition e6_pro => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition e6_pro_inf0 => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition e7_cov => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition e7_pro => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition e7_mars => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition e8_cov => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition e8_mars => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition e8_pro => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition e8_pro_wraiths0 => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition e9_cov => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition e9_pro => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition e9_pro_inf2 => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition e9_pro_inf3 => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition e9_pro_spectres0 => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition e10_cov => Scenario.AiSquadGroupDefinitions[37];
        public IAiActorDefinition e11_cov => Scenario.AiSquadGroupDefinitions[38];
        public IAiActorDefinition e11_pro => Scenario.AiSquadGroupDefinitions[39];
        public IAiActorDefinition e11_pro_inf0 => Scenario.AiSquadGroupDefinitions[40];
        public IAiActorDefinition e11_pro_wraith0 => Scenario.AiSquadGroupDefinitions[41];
        public IAiActorDefinition e11_pro_wraith1 => Scenario.AiSquadGroupDefinitions[42];
        public IAiActorDefinition e11_pro_phantom0 => Scenario.AiSquadGroupDefinitions[43];
        public IAiActorDefinition e11_pro_banshees0 => Scenario.AiSquadGroupDefinitions[44];
        public IAiActorDefinition e12_cov => Scenario.AiSquadGroupDefinitions[45];
        public IAiActorDefinition e12_cov_inf0 => Scenario.AiSquadGroupDefinitions[46];
        public IAiActorDefinition e12_pro => Scenario.AiSquadGroupDefinitions[47];
        public IAiActorDefinition e12_pro_inf0 => Scenario.AiSquadGroupDefinitions[48];
        public IAiActorDefinition e13_cov => Scenario.AiSquadGroupDefinitions[49];
        public IAiActorDefinition e13_cov_inf0 => Scenario.AiSquadGroupDefinitions[50];
        public IAiActorDefinition e13_mars => Scenario.AiSquadGroupDefinitions[51];
        public IAiActorDefinition e13_pro => Scenario.AiSquadGroupDefinitions[52];
        public IAiActorDefinition e13_pro_inf0 => Scenario.AiSquadGroupDefinitions[53];
        public IAiActorDefinition e13_sen => Scenario.AiSquadGroupDefinitions[54];
        public IAiActorDefinition boss_brute_reenforcements1 => Scenario.AiSquadGroupDefinitions[55];
        public IAiActorDefinition boss_elite_reenforcements1 => Scenario.AiSquadGroupDefinitions[56];
        public IAiOrders e1_cov_wraiths0_engage0 => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders e1_cov_wraiths0_engage1 => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders e1_cov_wraiths0_engage2 => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders e1_cov_wraiths0_engage3 => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders e1_cov_wraiths0_engage4 => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders e1_cov_wraiths0_engage5 => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders e1_cov_wraiths0_engage6 => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders e1_pro_ghosts0_engage0 => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders e1_pro_ghosts0_regroup0 => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders e1_pro_ghosts0_engage1 => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders e1_pro_ghosts0_regroup1 => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders e1_pro_ghosts0_engage2 => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders e1_pro_ghosts0_regroup2 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders e1_pro_ghosts0_engage3 => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders e1_pro_ghosts0_regroup3 => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders e1_pro_ghosts0_engage4 => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders e1_pro_ghosts0_regroup4 => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders e1_pro_ghosts0_engage5 => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders e1_pro_ghosts0_engage6 => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders e1_pro_inf0_0_init => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders e1_pro_inf0_1_init => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders e1_pro_phantom0_init => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders e1_pro_wraith0_init => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders e2_cov_wraith0_init => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders e2_cov_spectre0_init => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders e2_pro_inf0_init => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders e2_pro_inf0_engage0 => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders e2_pro_ghosts0_0_init => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders e2_pro_ghosts0_0_engage0 => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders e2_pro_ghosts0_1_init => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders e2_pro_ghosts0_1_engage0 => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders e2_pro_wraith0_0_init => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders e2_pro_wraith0_1_init => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders e2_pro_phantom0_0_init => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders e3_cov_inf0_advance0 => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders e3_cov_inf0_advance1 => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders e3_cov_inf0_advance2 => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders e3_cov_inf0_advance3 => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders e3_cov_inf0_continue => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders e3_cov_hunters0_init => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders e3_cov_hunters0_advance0 => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders e3_cov_hunters0_continue => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders e3_pro_inf0_init => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders e3_pro_inf0_retreat0 => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders e3_pro_inf0_retreat1 => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders e3_pro_inf1_init => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders e3_pro_inf2_init => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders e4_cov_inf0_init => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders e4_cov_inf0_advance0 => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders e4_cov_inf0_advance1 => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders e4_cov_inf0_advance2 => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders e4_cov_inf0_continue => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders e4_cov_hunters0_init => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders e4_cov_hunters0_advance0 => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders e4_cov_hunters0_advance1 => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders e4_cov_hunters0_continue => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders e4_pro_inf0_init => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders e4_pro_inf0_defend0 => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders e4_pro_inf0_defend1 => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders e4_pro_inf1_init => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders e4_pro_inf1_advance0 => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders e4_pro_inf1_retreat0 => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders e4_pro_inf1_retreat1 => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders e4_pro_inf2_init => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders e4_pro_inf3_init => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders e4_sen_inf0_engage => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders e5_cov_inf0_init => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders e5_cov_inf0_advance0 => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders e5_cov_inf0_cower0 => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders e5_cov_inf0_advance1 => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders e5_cov_inf0_continue => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders e5_cov_hunters0_init => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders e5_cov_hunters0_advance0 => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders e5_cov_hunters0_advance1 => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders e5_cov_hunters0_continue => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders e5_pro_inf0_init => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders e5_pro_inf0_retreat0 => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders e5_pro_inf0_retreat1 => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders e5_pro_inf1_init => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders e5_pro_inf2_init => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders e5_pro_inf2_engage => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders e5_pro_phantom0_init => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders e5_pro_inf3_init => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders e6_cov_inf0_init => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders e6_cov_inf0_advance0 => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders e6_cov_inf0_engage0 => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders e6_cov_inf0_continue => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders e6_cov_hunters0_init => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders e6_cov_hunters0_advance0 => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders e6_cov_hunters0_engage0 => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders e6_cov_hunters0_engage1 => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders e6_cov_hunters0_continue => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders e6_pro_inf0_init => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders e6_pro_inf0_1_init => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders e6_pro_inf0_retreat0 => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders ____SCARAB_RIDE____1 => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders scarab_gunners_init => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders e7_cov_inf0_init => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders e7_cov_inf0_engage0 => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders e7_cov_hunters0_init => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders e7_cov_hunters0_engage0 => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders e7_pro_inf0_init => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders e7_mars_inf0_init => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders e7_mars_inf1_init => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders e8_cov_inf0_init => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders e8_cov_banshees0_init => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders e8_mars_inf0_init => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders e8_mars_inf0_defend0 => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders e8_pro_wraiths0_0_init => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders e8_pro_wraiths0_1_init => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders e8_pro_wraiths0_2_init => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders e9_pro_inf0_init => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders e9_pro_inf3_init => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders e9_pro_phantom0_init => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders e9_pro_spectres0_engage0 => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders e9_pro_spectres0_engage1 => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders e9_pro_spectres0_engage2 => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders e10_cov_banshees0_init => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders e11_cov_banshees0_init => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders e11_pro_wraith0_0_init => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders e11_pro_wraith0_1_init => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders e11_pro_wraith1_0_init => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders e11_pro_wraith1_1_init => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders e11_pro_wraith1_2_init => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders e11_pro_wraith1_3_init => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders e11_pro_phantom0_0_init => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders e11_pro_phantom0_1_init => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders e11_pro_ghosts0_init => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders e11_pro_spectres0_init => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders e11_pro_banshees0_init => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders ____CONTROL_ROOM____1 => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders e12_cov_inf0_0_init => Scenario.AiOrderDefinitions[131].GameObject;
        public IAiOrders e12_cov_inf0_1_init => Scenario.AiOrderDefinitions[132].GameObject;
        public IAiOrders e12_cov_inf0_advance0 => Scenario.AiOrderDefinitions[133].GameObject;
        public IAiOrders e12_cov_inf0_advance1 => Scenario.AiOrderDefinitions[134].GameObject;
        public IAiOrders e12_cov_inf0_engage0_right => Scenario.AiOrderDefinitions[135].GameObject;
        public IAiOrders e12_cov_inf0_engage0_left => Scenario.AiOrderDefinitions[136].GameObject;
        public IAiOrders e12_cov_inf0_engage1_right => Scenario.AiOrderDefinitions[137].GameObject;
        public IAiOrders e12_cov_inf0_engage1_left => Scenario.AiOrderDefinitions[138].GameObject;
        public IAiOrders e12_cov_phantom0_init => Scenario.AiOrderDefinitions[139].GameObject;
        public IAiOrders e12_pro_inf0_init => Scenario.AiOrderDefinitions[140].GameObject;
        public IAiOrders e12_pro_inf0_defend0 => Scenario.AiOrderDefinitions[141].GameObject;
        public IAiOrders e12_pro_inf0_defend1 => Scenario.AiOrderDefinitions[142].GameObject;
        public IAiOrders e13_pro_tartarus_init => Scenario.AiOrderDefinitions[143].GameObject;
        public IAiOrders e13_cov_inf0_engage0 => Scenario.AiOrderDefinitions[144].GameObject;
        public IAiOrders e13_cov_inf0_engage1 => Scenario.AiOrderDefinitions[145].GameObject;
        public IAiOrders e13_cov_inf0_engage2 => Scenario.AiOrderDefinitions[146].GameObject;
        public IAiOrders e13_cov_inf0_engage3 => Scenario.AiOrderDefinitions[147].GameObject;
        public IAiOrders e13_pro_inf0_engage0 => Scenario.AiOrderDefinitions[148].GameObject;
        public IAiOrders e13_pro_inf0_engage1 => Scenario.AiOrderDefinitions[149].GameObject;
        public IAiOrders e13_pro_inf0_engage2 => Scenario.AiOrderDefinitions[150].GameObject;
        public IAiOrders e13_pro_inf0_engage3 => Scenario.AiOrderDefinitions[151].GameObject;
        public IAiOrders boss_tartarus_mid => Scenario.AiOrderDefinitions[152].GameObject;
        public IAiOrders boss_johnson_outer => Scenario.AiOrderDefinitions[153].GameObject;
        public IAiOrders boss_johnson_ledge => Scenario.AiOrderDefinitions[154].GameObject;
        public IAiOrders boss_brutes_ledge => Scenario.AiOrderDefinitions[155].GameObject;
        public IAiOrders boss_tartarus_ledge => Scenario.AiOrderDefinitions[156].GameObject;
        public IAiOrders boss_elites_ledge => Scenario.AiOrderDefinitions[157].GameObject;
        public IAiOrders boss_monitor1 => Scenario.AiOrderDefinitions[158].GameObject;
        public IAiOrders boss_miranda1 => Scenario.AiOrderDefinitions[159].GameObject;
        public IAiOrders boss_elite_mid => Scenario.AiOrderDefinitions[160].GameObject;
        public IAiOrders e9_pro_banshees0_init => Scenario.AiOrderDefinitions[161].GameObject;
        public IAiOrders boss_brute_mid => Scenario.AiOrderDefinitions[162].GameObject;
        public ILocationFlag e2_test => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag e3_test => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag e4_test => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag e5_test => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag e6_test => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag e7_test => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag e12_test => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag anchor_flag_intra3 => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag e8_scarab => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag e9_scarab => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag e10_scarab => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag anchor_flag_intra2 => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag anchor_flag_intra1 => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag e13_cutscene_trigger => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag anchor_flag_x09_02 => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag anchor_flag_x10 => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag anchor_flag_x09_01 => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag anchor_flag_x09_03 => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag e11_exit_door1 => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag e11_pro_phantom0_spawn => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag e11_pro_phantom1_spawn => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag e12_cov_banshees0_spawn => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag boss_player0_flag => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag boss_player1_flag => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag player0_e8_start => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag player1_e8_start => Scenario.LocationFlagDefinitions[27];
        public ILocationFlag player0_e8_stash => Scenario.LocationFlagDefinitions[28];
        public ILocationFlag player1_e8_stash => Scenario.LocationFlagDefinitions[29];
        public ILocationFlag e11_door_explosion => Scenario.LocationFlagDefinitions[30];
        public ILocationFlag boss_tartarus_respawn_flag => Scenario.LocationFlagDefinitions[31];
        public ILocationFlag player0_stash => Scenario.LocationFlagDefinitions[32];
        public ILocationFlag player1_stash => Scenario.LocationFlagDefinitions[33];
        public ICinematicTitle title0 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title1 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title2 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume bsp_1_0 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_1_01 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume bsp_0_11 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume bsp_1_02 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume bsp_0_12 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume bsp_0_13 => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume bsp_1_03 => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume bsp_0_2 => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume tv_e1_advance0 => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume tv_e1_advance1 => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume tv_e1_advance2 => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume tv_e1_advance3 => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_e1_advance4 => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume tv_e1_advance5 => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_e3_player_advance0 => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_e3_player_advance1 => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_e3_player_advance2 => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_e3_pro_inf0_begin => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume tv_e3_main_begin => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume tv_e4_main_begin => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume tv_e4_player_advance0 => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume tv_e4_player_advance1 => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume tv_e4_player_advance2 => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_e4_corner => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_e4_main_shutdown => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume test1 => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_e5_main_begin => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_e5_bridge_exit => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume tv_e5_pro_inf3_init => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume bottom => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume middle => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_e6_player_advance0 => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_e6_main_begin => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume bsp_2_0 => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume bsp_0_21 => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_e5_pro_phantom0_begin => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_e7_main_begin => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_e7_on_ledge => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_e12_ledge => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_e12_ledge_entrance => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_e12_swap_room_halfway => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume tv_e3_pro_inf1_begin => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_scarab => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume tv_scarab_banshee_dock => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_e11_main_begin => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_e1_canyon_entry => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_e2_near_perimeter => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume tv_e2_main_begin => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume tv_e2_pro_wraiths0_begin => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume tv_e11_scarab0 => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume tv_e11_scarab0_entrance => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume tv_e3_ramp_room => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume tv_e6_main_room => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume tv_e13_cutscene_trigger0 => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume tv_e13_cutscene_trigger1 => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume kill_e13_0 => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume tv_e8_exit => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume tv_e9_main_begin => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume tv_e9_first_bend => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume tv_e9_second_bend => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume tv_e9_canyon_end => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume kill_e8_0 => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume tv_e11_inner_cove => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume tv_e11_exit_vicinity => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume tv_scarab_interior => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume kill_e2_0 => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume tv_e11_outer_cove => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume tv_e8_scarab_fire_unsafe => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume tv_e12_chamber_entered => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume tv_e12_antechamber => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume tv_e12_antechamber_halfway => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume tv_boss_johnson_outer => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume tv_boss_platform => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume tv_e7_brute_area => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume tv_boss_ledge => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume tv_e4_halfway => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume tv_e9_pro_banshees0_stop => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume tv_e12_pro_inf0_end => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume tv_e12_cov_banshee0_begin => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume tv_e11_pro_wraiths1_begin => Scenario.TriggerVolumes[80].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            delete_me = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            e6_jail_shield0 = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            e6_jail_shield1 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            e6_jail_shield2 = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            e6_jail_shield3 = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            e6_jail_shield4 = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            e6_jail_shield5 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            hammer = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            index = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            anchor_intra3 = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            anchor_intra2 = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            cov_sniper = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            scarab_01 = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            index_cheat = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            anchor_intra1 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            rotors_x09 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            index_x09 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            anchor_x09_02 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            matte_halo = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            matte_high_charity = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            matte_substance = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            matte_moon = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            matte_earth = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            forerunner_ship = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            cairo = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            cairo_bridge = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            halo = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            x09_chamber_door = new ScenarioEntity<IScenery>(27, scenarioTag.WellKnownItems[27]);
            spore_01 = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            spore_02 = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            spore_03 = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            tentacle_01 = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            tentacle_02 = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            tentacle_03 = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            tentacle_04 = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            tentacle_05 = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            tentacle_06 = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            anchor_x10 = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            texture_camera = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            anchor_x09_01 = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            x09_halo_bang = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            x09_halo_whimper = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            x09_alcove = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            scarab_screen = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            x09_lift = new ScenarioEntity<IBloc>(44, scenarioTag.WellKnownItems[44]);
            slipspace = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            boss_object_1 = new ScenarioEntity<IBloc>(46, scenarioTag.WellKnownItems[46]);
            boss_object_4 = new ScenarioEntity<IBloc>(47, scenarioTag.WellKnownItems[47]);
            boss_object_5 = new ScenarioEntity<IBloc>(48, scenarioTag.WellKnownItems[48]);
            boss_object_6 = new ScenarioEntity<IBloc>(49, scenarioTag.WellKnownItems[49]);
            boss_object_7 = new ScenarioEntity<IBloc>(50, scenarioTag.WellKnownItems[50]);
            boss_object_8 = new ScenarioEntity<IBloc>(51, scenarioTag.WellKnownItems[51]);
            boss_object_9 = new ScenarioEntity<IBloc>(52, scenarioTag.WellKnownItems[52]);
            boss_object_10 = new ScenarioEntity<IBloc>(53, scenarioTag.WellKnownItems[53]);
            boss_object_11 = new ScenarioEntity<IBloc>(54, scenarioTag.WellKnownItems[54]);
            boss_object_12 = new ScenarioEntity<IBloc>(55, scenarioTag.WellKnownItems[55]);
            boss_object_13 = new ScenarioEntity<IBloc>(56, scenarioTag.WellKnownItems[56]);
            boss_object_14 = new ScenarioEntity<IBloc>(57, scenarioTag.WellKnownItems[57]);
            boss_object_15 = new ScenarioEntity<IBloc>(58, scenarioTag.WellKnownItems[58]);
            boss_object_16 = new ScenarioEntity<IBloc>(59, scenarioTag.WellKnownItems[59]);
            boss_object_17 = new ScenarioEntity<IBloc>(60, scenarioTag.WellKnownItems[60]);
            boss_object_18 = new ScenarioEntity<IBloc>(61, scenarioTag.WellKnownItems[61]);
            cairo_effect01 = new ScenarioEntity<IScenery>(62, scenarioTag.WellKnownItems[62]);
            cairo_effect02 = new ScenarioEntity<IScenery>(63, scenarioTag.WellKnownItems[63]);
            cairo_effect04 = new ScenarioEntity<IScenery>(64, scenarioTag.WellKnownItems[64]);
            cairo_effect03 = new ScenarioEntity<IScenery>(65, scenarioTag.WellKnownItems[65]);
            cairo_effect05 = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            cairo_effect06 = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            c08_intra3_lift = new ScenarioEntity<IBloc>(68, scenarioTag.WellKnownItems[68]);
            cortana_stand = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            earth_battle = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            bloom_quad = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            boss_object_19 = new ScenarioEntity<IBloc>(72, scenarioTag.WellKnownItems[72]);
            boss_object_20 = new ScenarioEntity<IBloc>(73, scenarioTag.WellKnownItems[73]);
            boss_object_21 = new ScenarioEntity<IBloc>(74, scenarioTag.WellKnownItems[74]);
            boss_object_22 = new ScenarioEntity<IBloc>(75, scenarioTag.WellKnownItems[75]);
            blast_base = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            earth_battle2 = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            blast_base2 = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            boss_object_index = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            miranda = new ScenarioEntity<IUnit>(80, scenarioTag.WellKnownItems[80]);
            johnson = new ScenarioEntity<IUnit>(81, scenarioTag.WellKnownItems[81]);
            dervish = new ScenarioEntity<IUnit>(82, scenarioTag.WellKnownItems[82]);
            tartarus = new ScenarioEntity<IUnit>(83, scenarioTag.WellKnownItems[83]);
            monitor = new ScenarioEntity<IUnit>(84, scenarioTag.WellKnownItems[84]);
            brute_01 = new ScenarioEntity<IUnit>(85, scenarioTag.WellKnownItems[85]);
            brute_02 = new ScenarioEntity<IUnit>(86, scenarioTag.WellKnownItems[86]);
            brute_03 = new ScenarioEntity<IUnit>(87, scenarioTag.WellKnownItems[87]);
            brute_04 = new ScenarioEntity<IUnit>(88, scenarioTag.WellKnownItems[88]);
            dervish_02 = new ScenarioEntity<IUnit>(89, scenarioTag.WellKnownItems[89]);
            johnson_02 = new ScenarioEntity<IUnit>(90, scenarioTag.WellKnownItems[90]);
            commander = new ScenarioEntity<IUnit>(91, scenarioTag.WellKnownItems[91]);
            hood = new ScenarioEntity<IUnit>(92, scenarioTag.WellKnownItems[92]);
            chief = new ScenarioEntity<IUnit>(93, scenarioTag.WellKnownItems[93]);
            officer_01 = new ScenarioEntity<IUnit>(94, scenarioTag.WellKnownItems[94]);
            officer_02 = new ScenarioEntity<IUnit>(95, scenarioTag.WellKnownItems[95]);
            cortana = new ScenarioEntity<IUnit>(96, scenarioTag.WellKnownItems[96]);
            e12_test_banshee = new ScenarioEntity<IVehicle>(97, scenarioTag.WellKnownItems[97]);
            wraith_01 = new ScenarioEntity<IVehicle>(98, scenarioTag.WellKnownItems[98]);
            e8_banshee0 = new ScenarioEntity<IVehicle>(99, scenarioTag.WellKnownItems[99]);
            e8_banshee1 = new ScenarioEntity<IVehicle>(100, scenarioTag.WellKnownItems[100]);
            key = new ScenarioEntity<IWeapon>(101, scenarioTag.WellKnownItems[101]);
            boss_object_23 = new ScenarioEntity<IWeapon>(102, scenarioTag.WellKnownItems[102]);
            boss_object_24 = new ScenarioEntity<IWeapon>(103, scenarioTag.WellKnownItems[103]);
            s8_hunter_door_switch = new ScenarioEntity<IDevice>(104, scenarioTag.WellKnownItems[104]);
            scarab = new ScenarioEntity<IDevice>(105, scenarioTag.WellKnownItems[105]);
            e13_boss_platform = new ScenarioEntity<IDevice>(106, scenarioTag.WellKnownItems[106]);
            e2_exit_door = new ScenarioEntity<IDevice>(107, scenarioTag.WellKnownItems[107]);
            e13_rotors = new ScenarioEntity<IDevice>(108, scenarioTag.WellKnownItems[108]);
            e12_door0 = new ScenarioEntity<IDevice>(109, scenarioTag.WellKnownItems[109]);
            e12_door1 = new ScenarioEntity<IDevice>(110, scenarioTag.WellKnownItems[110]);
            e11_door0 = new ScenarioEntity<IDevice>(111, scenarioTag.WellKnownItems[111]);
            e11_exit_door = new ScenarioEntity<IDevice>(112, scenarioTag.WellKnownItems[112]);
            e7_door0 = new ScenarioEntity<IDevice>(113, scenarioTag.WellKnownItems[113]);
            e6_door0 = new ScenarioEntity<IDevice>(114, scenarioTag.WellKnownItems[114]);
            scarab_door = new ScenarioEntity<IDevice>(115, scenarioTag.WellKnownItems[115]);
            repository = new ScenarioEntity<IDevice>(116, scenarioTag.WellKnownItems[116]);
            beacon_03 = new ScenarioEntity<IDevice>(117, scenarioTag.WellKnownItems[117]);
            i_dont_exist = new ScenarioEntity<IDevice>(118, scenarioTag.WellKnownItems[118]);
            beacon_02 = new ScenarioEntity<IDevice>(119, scenarioTag.WellKnownItems[119]);
            beacon_01 = new ScenarioEntity<IDevice>(120, scenarioTag.WellKnownItems[120]);
            boss_object_controlw = new ScenarioEntity<IDevice>(121, scenarioTag.WellKnownItems[121]);
            e1_cov_wraiths0_0 = new Squad_e1_cov_wraiths0_0(scenarioTag);
            e1_cov_wraiths0_1 = new Squad_e1_cov_wraiths0_1(scenarioTag);
            e1_cov_spectre0 = new Squad_e1_cov_spectre0(scenarioTag);
            e1_pro_ghosts0_0 = new Squad_e1_pro_ghosts0_0(scenarioTag);
            e1_pro_ghosts0_1 = new Squad_e1_pro_ghosts0_1(scenarioTag);
            e1_pro_ghosts0_2 = new Squad_e1_pro_ghosts0_2(scenarioTag);
            e1_pro_inf0_0 = new Squad_e1_pro_inf0_0(scenarioTag);
            e1_pro_inf0_1 = new Squad_e1_pro_inf0_1(scenarioTag);
            e1_pro_wraith0 = new Squad_e1_pro_wraith0(scenarioTag);
            e1_pro_phantom0 = new Squad_e1_pro_phantom0(scenarioTag);
            e2_cov_wraith0 = new Squad_e2_cov_wraith0(scenarioTag);
            e2_cov_spectre0 = new Squad_e2_cov_spectre0(scenarioTag);
            e2_pro_inf0 = new Squad_e2_pro_inf0(scenarioTag);
            e2_pro_ghosts0_0 = new Squad_e2_pro_ghosts0_0(scenarioTag);
            e2_pro_ghosts0_1 = new Squad_e2_pro_ghosts0_1(scenarioTag);
            e2_pro_wraith0_0 = new Squad_e2_pro_wraith0_0(scenarioTag);
            e2_pro_wraith0_1 = new Squad_e2_pro_wraith0_1(scenarioTag);
            e2_pro_phantom0_0 = new Squad_e2_pro_phantom0_0(scenarioTag);
            e2_pro_phantom0_1 = new Squad_e2_pro_phantom0_1(scenarioTag);
            e3_cov_inf0 = new Squad_e3_cov_inf0(scenarioTag);
            e3_cov_hunters0 = new Squad_e3_cov_hunters0(scenarioTag);
            e3_pro_inf0_0 = new Squad_e3_pro_inf0_0(scenarioTag);
            e3_pro_inf0_1 = new Squad_e3_pro_inf0_1(scenarioTag);
            e3_pro_inf1 = new Squad_e3_pro_inf1(scenarioTag);
            e3_pro_inf2 = new Squad_e3_pro_inf2(scenarioTag);
            e4_cov_inf0 = new Squad_e4_cov_inf0(scenarioTag);
            e4_cov_hunters0 = new Squad_e4_cov_hunters0(scenarioTag);
            e4_pro_inf0 = new Squad_e4_pro_inf0(scenarioTag);
            e4_pro_inf1 = new Squad_e4_pro_inf1(scenarioTag);
            e4_pro_inf2 = new Squad_e4_pro_inf2(scenarioTag);
            e4_pro_inf3 = new Squad_e4_pro_inf3(scenarioTag);
            e5_cov_inf0 = new Squad_e5_cov_inf0(scenarioTag);
            e5_cov_hunters0 = new Squad_e5_cov_hunters0(scenarioTag);
            e5_cov_grunts0 = new Squad_e5_cov_grunts0(scenarioTag);
            e5_cov_banshees0 = new Squad_e5_cov_banshees0(scenarioTag);
            e5_pro_inf0 = new Squad_e5_pro_inf0(scenarioTag);
            e5_pro_inf1 = new Squad_e5_pro_inf1(scenarioTag);
            e5_pro_inf2 = new Squad_e5_pro_inf2(scenarioTag);
            e5_pro_inf3 = new Squad_e5_pro_inf3(scenarioTag);
            e5_pro_phantom0 = new Squad_e5_pro_phantom0(scenarioTag);
            control_room_test = new Squad_control_room_test(scenarioTag);
            e6_cov_inf0 = new Squad_e6_cov_inf0(scenarioTag);
            e6_cov_inf1_0 = new Squad_e6_cov_inf1_0(scenarioTag);
            e6_cov_inf1_1 = new Squad_e6_cov_inf1_1(scenarioTag);
            e6_cov_inf1_2 = new Squad_e6_cov_inf1_2(scenarioTag);
            e6_cov_inf1_3 = new Squad_e6_cov_inf1_3(scenarioTag);
            e6_cov_hunters0 = new Squad_e6_cov_hunters0(scenarioTag);
            e6_pro_inf0_0 = new Squad_e6_pro_inf0_0(scenarioTag);
            e6_pro_inf0_1 = new Squad_e6_pro_inf0_1(scenarioTag);
            e6_pro_inf0_2 = new Squad_e6_pro_inf0_2(scenarioTag);
            ____SCARAB_RIDE____ = new Squad_____SCARAB_RIDE____(scenarioTag);
            scarab_gunners = new Squad_scarab_gunners(scenarioTag);
            e7_cov_inf0 = new Squad_e7_cov_inf0(scenarioTag);
            e7_cov_hunters0 = new Squad_e7_cov_hunters0(scenarioTag);
            e7_pro_inf0 = new Squad_e7_pro_inf0(scenarioTag);
            e7_mars_inf0 = new Squad_e7_mars_inf0(scenarioTag);
            e7_mars_inf1 = new Squad_e7_mars_inf1(scenarioTag);
            e8_cov_inf0 = new Squad_e8_cov_inf0(scenarioTag);
            e8_cov_banshees0 = new Squad_e8_cov_banshees0(scenarioTag);
            e8_mars_inf0 = new Squad_e8_mars_inf0(scenarioTag);
            e8_pro_wraiths0_0 = new Squad_e8_pro_wraiths0_0(scenarioTag);
            e8_pro_wraiths0_1 = new Squad_e8_pro_wraiths0_1(scenarioTag);
            e8_pro_wraiths0_2 = new Squad_e8_pro_wraiths0_2(scenarioTag);
            e9_pro_inf0 = new Squad_e9_pro_inf0(scenarioTag);
            e9_pro_inf3_0 = new Squad_e9_pro_inf3_0(scenarioTag);
            e9_pro_inf3_1 = new Squad_e9_pro_inf3_1(scenarioTag);
            e9_pro_phantom0 = new Squad_e9_pro_phantom0(scenarioTag);
            e9_pro_phantom1 = new Squad_e9_pro_phantom1(scenarioTag);
            e9_pro_spectres0_0 = new Squad_e9_pro_spectres0_0(scenarioTag);
            e9_pro_spectres0_1 = new Squad_e9_pro_spectres0_1(scenarioTag);
            e9_pro_banshees0 = new Squad_e9_pro_banshees0(scenarioTag);
            e10_cov_banshees0 = new Squad_e10_cov_banshees0(scenarioTag);
            e11_cov_banshees0 = new Squad_e11_cov_banshees0(scenarioTag);
            e11_pro_wraith0_0 = new Squad_e11_pro_wraith0_0(scenarioTag);
            e11_pro_wraith0_1 = new Squad_e11_pro_wraith0_1(scenarioTag);
            e11_pro_wraith1_0 = new Squad_e11_pro_wraith1_0(scenarioTag);
            e11_pro_wraith1_1 = new Squad_e11_pro_wraith1_1(scenarioTag);
            e11_pro_wraith1_2 = new Squad_e11_pro_wraith1_2(scenarioTag);
            e11_pro_wraith1_3 = new Squad_e11_pro_wraith1_3(scenarioTag);
            e11_pro_phantom0_0 = new Squad_e11_pro_phantom0_0(scenarioTag);
            e11_pro_phantom0_1 = new Squad_e11_pro_phantom0_1(scenarioTag);
            e11_pro_ghosts0 = new Squad_e11_pro_ghosts0(scenarioTag);
            e11_pro_spectres0 = new Squad_e11_pro_spectres0(scenarioTag);
            e11_pro_banshees0_0 = new Squad_e11_pro_banshees0_0(scenarioTag);
            e11_pro_banshees0_1 = new Squad_e11_pro_banshees0_1(scenarioTag);
            ____CONTROL_ROOM____ = new Squad_____CONTROL_ROOM____(scenarioTag);
            e12_cov_inf0_0 = new Squad_e12_cov_inf0_0(scenarioTag);
            e12_cov_inf0_1 = new Squad_e12_cov_inf0_1(scenarioTag);
            e12_cov_phantom0 = new Squad_e12_cov_phantom0(scenarioTag);
            e12_cov_banshees0 = new Squad_e12_cov_banshees0(scenarioTag);
            e12_pro_inf0_0 = new Squad_e12_pro_inf0_0(scenarioTag);
            e12_pro_inf0_1 = new Squad_e12_pro_inf0_1(scenarioTag);
            e12_pro_inf0_2 = new Squad_e12_pro_inf0_2(scenarioTag);
            e13_cov_inf0_0 = new Squad_e13_cov_inf0_0(scenarioTag);
            e13_cov_inf0_1 = new Squad_e13_cov_inf0_1(scenarioTag);
            e13_mars_johnson = new Squad_e13_mars_johnson(scenarioTag);
            e13_mars_miranda = new Squad_e13_mars_miranda(scenarioTag);
            e13_pro_tartarus = new Squad_e13_pro_tartarus(scenarioTag);
            e13_pro_inf0_0 = new Squad_e13_pro_inf0_0(scenarioTag);
            e13_pro_inf0_1 = new Squad_e13_pro_inf0_1(scenarioTag);
            e13_sen_monitor = new Squad_e13_sen_monitor(scenarioTag);
            test = new Squad_test(scenarioTag);
            boss_tartarus = new Squad_boss_tartarus(scenarioTag);
            boss_johnson = new Squad_boss_johnson(scenarioTag);
            boss_brute_start = new Squad_boss_brute_start(scenarioTag);
            boss_elite_start = new Squad_boss_elite_start(scenarioTag);
            boss_monitor = new Squad_boss_monitor(scenarioTag);
            boss_miranda = new Squad_boss_miranda(scenarioTag);
            boss_brute_reenforcements = new Squad_boss_brute_reenforcements(scenarioTag);
            boss_elite_reenforcements = new Squad_boss_elite_reenforcements(scenarioTag);
            boss_brute_reenforcements_many = new Squad_boss_brute_reenforcements_many(scenarioTag);
            boss_elite_reenforcements_many = new Squad_boss_elite_reenforcements_many(scenarioTag);
        }

        public class Squad_e1_cov_wraiths0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_e1_cov_wraiths0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_wraiths0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_e1_cov_wraiths0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_spectre0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition spectre0 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_e1_cov_spectre0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_e1_pro_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_e1_pro_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_ghosts0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_e1_pro_ghosts0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_e1_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_e1_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_wraith0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_e1_pro_wraith0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_e1_pro_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_cov_wraith0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_e2_cov_wraith0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_cov_spectre0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition spectre0 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_e2_cov_spectre0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_e2_pro_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[1];
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[2];
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_e2_pro_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[1];
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[2];
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_e2_pro_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_wraith0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_e2_pro_wraith0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_wraith0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_e2_pro_wraith0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_phantom0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_e2_pro_phantom0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_phantom0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad_e2_pro_phantom0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite0 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_e3_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_hunters0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hunter0 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[0];
            public IAiActorDefinition hunter1 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_e3_cov_hunters0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_e3_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_e3_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_e3_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_pro_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_e3_pro_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_e4_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_hunters0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_e4_cov_hunters0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_e4_pro_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_e4_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_e4_pro_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_e4_pro_inf3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_e5_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_hunters0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_e5_cov_hunters0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_grunts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_e5_cov_grunts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_banshees0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_e5_cov_banshees0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_pro_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_e5_pro_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_e5_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_pro_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_e5_pro_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_pro_inf3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_e5_pro_inf3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_pro_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_e5_pro_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_control_room_test
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_control_room_test(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite0 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[0];
            public IAiActorDefinition elite1 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[1];
            public IAiActorDefinition elite2 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_e6_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_e6_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_e6_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf1_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_e6_cov_inf1_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf1_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_e6_cov_inf1_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_hunters0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hunter0 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[0];
            public IAiActorDefinition hunter1 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_e6_cov_hunters0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_e6_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_e6_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_pro_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_e6_pro_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_____SCARAB_RIDE____
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_____SCARAB_RIDE____(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_scarab_gunners
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition main_gunner => ScenarioTag.AiSquadDefinitions[51].StartingLocations[0];
            public IAiActorDefinition upper_gunner => ScenarioTag.AiSquadDefinitions[51].StartingLocations[1];
            public IAiActorDefinition rear_gunner => ScenarioTag.AiSquadDefinitions[51].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_scarab_gunners(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_e7_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_cov_hunters0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_e7_cov_hunters0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_pro_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition captain => ScenarioTag.AiSquadDefinitions[54].StartingLocations[0];
            public IAiActorDefinition guard0 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[1];
            public IAiActorDefinition sentry1 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[2];
            public IAiActorDefinition sentry0 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad_e7_pro_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition johnson0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[0];
            public IAiActorDefinition marine2 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[1];
            public IAiActorDefinition marine0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_e7_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_mars_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_e7_mars_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_e8_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_banshees0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition banshee0 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[0];
            public IAiActorDefinition banshee1 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition banshee2 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition banshee3 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[3];
            public IAiActorDefinition banshee4 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_e8_cov_banshees0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition johnson => ScenarioTag.AiSquadDefinitions[59].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_e8_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_pro_wraiths0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_e8_pro_wraiths0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_pro_wraiths0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_e8_pro_wraiths0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_pro_wraiths0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_e8_pro_wraiths0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_e9_pro_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf3_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_e9_pro_inf3_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf3_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_e9_pro_inf3_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_e9_pro_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_phantom1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_e9_pro_phantom1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_spectres0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition spectre0 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_e9_pro_spectres0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_spectres0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_e9_pro_spectres0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_banshees0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_e9_pro_banshees0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_banshees0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition banshee0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[0];
            public IAiActorDefinition banshee1 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_e10_cov_banshees0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_cov_banshees0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_e11_cov_banshees0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_wraith0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_e11_pro_wraith0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_wraith0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_e11_pro_wraith0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_wraith1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith => ScenarioTag.AiSquadDefinitions[75].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[75].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_e11_pro_wraith1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_wraith1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith => ScenarioTag.AiSquadDefinitions[76].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[76].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad_e11_pro_wraith1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_wraith1_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith => ScenarioTag.AiSquadDefinitions[77].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[77].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_e11_pro_wraith1_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_wraith1_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith => ScenarioTag.AiSquadDefinitions[78].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[78].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_e11_pro_wraith1_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_phantom0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_e11_pro_phantom0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_phantom0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_e11_pro_phantom0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_e11_pro_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_spectres0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_e11_pro_spectres0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_banshees0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_e11_pro_banshees0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e11_pro_banshees0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_e11_pro_banshees0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_____CONTROL_ROOM____
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[85];
            public Squad_____CONTROL_ROOM____(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite1 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[0];
            public IAiActorDefinition elite0 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[86];
            public Squad_e12_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite0 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[0];
            public IAiActorDefinition elite1 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[1];
            public IAiActorDefinition elite2 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[87];
            public Squad_e12_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[88];
            public Squad_e12_cov_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_cov_banshees0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition banshee0 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[89];
            public Squad_e12_cov_banshees0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition brute0 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[0];
            public IAiActorDefinition brute1 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[90];
            public Squad_e12_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[2];
            public IAiActorDefinition berserker0 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[3];
            public IAiActorDefinition berserker1 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[91];
            public Squad_e12_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e12_pro_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[1];
            public IAiActorDefinition berserker => ScenarioTag.AiSquadDefinitions[92].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[92];
            public Squad_e12_pro_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[93];
            public Squad_e13_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[94];
            public Squad_e13_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_mars_johnson
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[95];
            public Squad_e13_mars_johnson(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_mars_miranda
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[96];
            public Squad_e13_mars_miranda(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_pro_tartarus
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition tartarus0 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[97];
            public Squad_e13_pro_tartarus(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[98];
            public Squad_e13_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[99];
            public Squad_e13_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e13_sen_monitor
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[100];
            public Squad_e13_sen_monitor(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_test
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith => ScenarioTag.AiSquadDefinitions[101].StartingLocations[0];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[101].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[101];
            public Squad_test(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_tartarus
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[102];
            public Squad_boss_tartarus(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_johnson
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[103];
            public Squad_boss_johnson(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_brute_start
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[104];
            public Squad_boss_brute_start(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_elite_start
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[105];
            public Squad_boss_elite_start(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_monitor
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[106];
            public Squad_boss_monitor(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_miranda
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[107];
            public Squad_boss_miranda(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_brute_reenforcements
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[108];
            public Squad_boss_brute_reenforcements(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_elite_reenforcements
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[109];
            public Squad_boss_elite_reenforcements(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_brute_reenforcements_many
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[110];
            public Squad_boss_brute_reenforcements_many(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_boss_elite_reenforcements_many
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[111];
            public Squad_boss_elite_reenforcements_many(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}