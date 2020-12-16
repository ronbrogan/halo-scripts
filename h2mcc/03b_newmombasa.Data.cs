namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_03b_newmombasa : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> scarab_01 { get; set; }
        public ScenarioEntity<IScenery> iac { get; set; }
        public ScenarioEntity<IScenery> carrier_02 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge0_0 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge0_3 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge0_1 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge0_4 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge0_5 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge0_2 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_0 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_1 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_2 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_3 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_4 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_5 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_6 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_7 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_8 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge1_9 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge2_0 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge2_1 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge2_2 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge2_3 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge2_4 { get; set; }
        public ScenarioEntity<IScenery> e22_bridge2_5 { get; set; }
        public ScenarioEntity<IScenery> anchor_x03_03 { get; set; }
        public ScenarioEntity<IScenery> scarab_02 { get; set; }
        public ScenarioEntity<IScenery> rifle_01 { get; set; }
        public ScenarioEntity<IScenery> rifle_03 { get; set; }
        public ScenarioEntity<IScenery> rifle_02 { get; set; }
        public ScenarioEntity<IScenery> anchor_x03_01 { get; set; }
        public ScenarioEntity<IScenery> rear_gun { get; set; }
        public ScenarioEntity<IScenery> anchor_intra1 { get; set; }
        public ScenarioEntity<IScenery> dont_fuck_with_me0 { get; set; }
        public ScenarioEntity<IScenery> dont_fuck_with_me1 { get; set; }
        public ScenarioEntity<IScenery> texture_camera { get; set; }
        public ScenarioEntity<IScenery> cinematic_tollbooth { get; set; }
        public ScenarioEntity<IScenery> iac_bridge { get; set; }
        public ScenarioEntity<IScenery> carrier { get; set; }
        public ScenarioEntity<IScenery> x03_smoke { get; set; }
        public ScenarioEntity<IScenery> x03_shockwave_close { get; set; }
        public ScenarioEntity<IScenery> x03_shockwave_far { get; set; }
        public ScenarioEntity<IScenery> x03_bus { get; set; }
        public ScenarioEntity<IScenery> x03_truck { get; set; }
        public ScenarioEntity<IScenery> x03_generator { get; set; }
        public ScenarioEntity<IScenery> x03_dumpster { get; set; }
        public ScenarioEntity<IScenery> x03_palm_01 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_02 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_03 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_04 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_05 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_06 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_07 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_08 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_09 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_10 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_11 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_12 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_13 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_14 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_15 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_16 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_17 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_18 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_19 { get; set; }
        public ScenarioEntity<IScenery> x03_palm_20 { get; set; }
        public ScenarioEntity<IScenery> x03_slipspace_collapse { get; set; }
        public ScenarioEntity<IScenery> cigar { get; set; }
        public ScenarioEntity<IScenery> ui_test_ship { get; set; }
        public ScenarioEntity<IScenery> x03_shockwave_start { get; set; }
        public ScenarioEntity<IScenery> e19_tree0 { get; set; }
        public ScenarioEntity<IScenery> e19_tree1 { get; set; }
        public ScenarioEntity<IScenery> with_me_do_not_fuck0 { get; set; }
        public ScenarioEntity<IScenery> dont_fuck0 { get; set; }
        public ScenarioEntity<IScenery> dont_fuck1 { get; set; }
        public ScenarioEntity<IScenery> dont_fuck2 { get; set; }
        public ScenarioEntity<IScenery> dont_fuck3 { get; set; }
        public ScenarioEntity<IScenery> dont_fuck4 { get; set; }
        public ScenarioEntity<IScenery> dont_fuck_with_me2 { get; set; }
        public ScenarioEntity<IScenery> anchor_x03_02 { get; set; }
        public ScenarioEntity<IUnit> temp_bridge_johnson { get; set; }
        public ScenarioEntity<IUnit> johnson { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> marine_02 { get; set; }
        public ScenarioEntity<IUnit> marine_01 { get; set; }
        public ScenarioEntity<IUnit> pilot { get; set; }
        public ScenarioEntity<IUnit> hood { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> johnson_03 { get; set; }
        public ScenarioEntity<IUnit> pilot_02 { get; set; }
        public ScenarioEntity<IUnit> nav_officer { get; set; }
        public ScenarioEntity<IUnit> johnson_02 { get; set; }
        public ScenarioEntity<IVehicle> e17_test_tank { get; set; }
        public ScenarioEntity<IVehicle> temp_bridge_tank { get; set; }
        public ScenarioEntity<IVehicle> scorpion_01 { get; set; }
        public ScenarioEntity<IVehicle> pelican_01b { get; set; }
        public ScenarioEntity<IVehicle> pelican_02 { get; set; }
        public ScenarioEntity<IVehicle> e23_gun { get; set; }
        public ScenarioEntity<IVehicle> scorpion_02 { get; set; }
        public ScenarioEntity<IVehicle> pelican_01a { get; set; }
        public ScenarioEntity<IWeapon> e22_scarab_gun { get; set; }
        public ScenarioEntity<IWeapon> key { get; set; }
        public ScenarioEntity<IDevice> scarab { get; set; }
        public ScenarioEntity<IDevice> e17_door0 { get; set; }
        public ScenarioEntity<IDevice> e17_door1 { get; set; }
        public ScenarioEntity<IDevice> e22_door0 { get; set; }
        public ScenarioEntity<IDevice> e22_door1 { get; set; }
        public ScenarioEntity<IDevice> e22_door2 { get; set; }
        public ScenarioEntity<IDevice> e22_door3 { get; set; }
        public ICameraPathTarget bridge_p0 => Scenario.CameraPathTargets[0].GameObject;
        public ICameraPathTarget bridge_p1 => Scenario.CameraPathTargets[1].GameObject;
        public ICameraPathTarget bridge_p1_0 => Scenario.CameraPathTargets[2].GameObject;
        public ICameraPathTarget bridge_p2 => Scenario.CameraPathTargets[3].GameObject;
        public ICameraPathTarget bridge_p2_0 => Scenario.CameraPathTargets[4].GameObject;
        public ICameraPathTarget bridge_p3 => Scenario.CameraPathTargets[5].GameObject;
        public ICameraPathTarget bridge_p5 => Scenario.CameraPathTargets[6].GameObject;
        public ICameraPathTarget bridge_p6 => Scenario.CameraPathTargets[7].GameObject;
        public ICameraPathTarget bridge_p7 => Scenario.CameraPathTargets[8].GameObject;
        public ICameraPathTarget bridge_p8 => Scenario.CameraPathTargets[9].GameObject;
        public ICameraPathTarget bridge_p9 => Scenario.CameraPathTargets[10].GameObject;
        public ICameraPathTarget bridge_p0_0 => Scenario.CameraPathTargets[11].GameObject;
        public ICameraPathTarget bridge_p4 => Scenario.CameraPathTargets[12].GameObject;
        public ICameraPathTarget ui_test_01 => Scenario.CameraPathTargets[13].GameObject;
        public ICameraPathTarget ui_test_02 => Scenario.CameraPathTargets[14].GameObject;
        public ICameraPathTarget ui_test_03 => Scenario.CameraPathTargets[15].GameObject;
        public ICameraPathTarget ui_test_04 => Scenario.CameraPathTargets[16].GameObject;
        public ICameraPathTarget ui_test_05 => Scenario.CameraPathTargets[17].GameObject;
        public ICameraPathTarget ui_test_06 => Scenario.CameraPathTargets[18].GameObject;
        public ICameraPathTarget ui_test_07 => Scenario.CameraPathTargets[19].GameObject;
        public ICameraPathTarget ui_test_08 => Scenario.CameraPathTargets[20].GameObject;
        public ICameraPathTarget ui_test_09 => Scenario.CameraPathTargets[21].GameObject;
        public ICameraPathTarget ui_test_10 => Scenario.CameraPathTargets[22].GameObject;
        public ICameraPathTarget ui_test_11 => Scenario.CameraPathTargets[23].GameObject;
        public ICameraPathTarget ui_test_12 => Scenario.CameraPathTargets[24].GameObject;
        public ICameraPathTarget ui_test_13 => Scenario.CameraPathTargets[25].GameObject;
        public ICameraPathTarget c03_intra1_01 => Scenario.CameraPathTargets[26].GameObject;
        public ICameraPathTarget c03_intra1_02 => Scenario.CameraPathTargets[27].GameObject;
        public Squad_scarab_gunners scarab_gunners { get; set; }
        public Squad_e14_mars_inf0 e14_mars_inf0 { get; set; }
        public Squad_e14_mars_pelican0 e14_mars_pelican0 { get; set; }
        public Squad_e14_cov_ghosts0_0 e14_cov_ghosts0_0 { get; set; }
        public Squad_e14_cov_ghosts0_1 e14_cov_ghosts0_1 { get; set; }
        public Squad_e14_cov_wraiths0 e14_cov_wraiths0 { get; set; }
        public Squad_e14_cov_snipers0 e14_cov_snipers0 { get; set; }
        public Squad_e15_mars_inf0 e15_mars_inf0 { get; set; }
        public Squad_e15_cov_inf0 e15_cov_inf0 { get; set; }
        public Squad_e15_cov_inf1 e15_cov_inf1 { get; set; }
        public Squad_e15_cov_inf2_0 e15_cov_inf2_0 { get; set; }
        public Squad_e15_cov_inf2_1 e15_cov_inf2_1 { get; set; }
        public Squad_e15_cov_phantom0_0 e15_cov_phantom0_0 { get; set; }
        public Squad_e15_cov_phantom0_1 e15_cov_phantom0_1 { get; set; }
        public Squad_e15_cov_phantom1 e15_cov_phantom1 { get; set; }
        public Squad_e15_cov_banshees0 e15_cov_banshees0 { get; set; }
        public Squad_e16_mars_inf0 e16_mars_inf0 { get; set; }
        public Squad_e16_cov_wraiths0_0 e16_cov_wraiths0_0 { get; set; }
        public Squad_e16_cov_wraiths0_1 e16_cov_wraiths0_1 { get; set; }
        public Squad_e16_cov_wraiths1 e16_cov_wraiths1 { get; set; }
        public Squad_e16_cov_ghosts0_0 e16_cov_ghosts0_0 { get; set; }
        public Squad_e16_cov_ghosts0_1 e16_cov_ghosts0_1 { get; set; }
        public Squad_e16_cov_ghosts1 e16_cov_ghosts1 { get; set; }
        public Squad_e16_cov_banshees0_0 e16_cov_banshees0_0 { get; set; }
        public Squad_e16_cov_banshees0_1 e16_cov_banshees0_1 { get; set; }
        public Squad_e16_cov_inf0_0 e16_cov_inf0_0 { get; set; }
        public Squad_e16_cov_inf0_1 e16_cov_inf0_1 { get; set; }
        public Squad_e16_cov_inf0_2 e16_cov_inf0_2 { get; set; }
        public Squad_e16_cov_phantom0 e16_cov_phantom0 { get; set; }
        public Squad_e17_mars_inf0 e17_mars_inf0 { get; set; }
        public Squad_e17_cov_inf0_0 e17_cov_inf0_0 { get; set; }
        public Squad_e17_cov_inf0_1 e17_cov_inf0_1 { get; set; }
        public Squad_e17_cov_inf0_2 e17_cov_inf0_2 { get; set; }
        public Squad_e17_cov_inf0_3 e17_cov_inf0_3 { get; set; }
        public Squad_e17_cov_inf1_0 e17_cov_inf1_0 { get; set; }
        public Squad_e17_cov_inf1_1 e17_cov_inf1_1 { get; set; }
        public Squad_e17_cov_inf2_0 e17_cov_inf2_0 { get; set; }
        public Squad_e17_cov_inf2_1 e17_cov_inf2_1 { get; set; }
        public Squad_e17_cov_inf2_2 e17_cov_inf2_2 { get; set; }
        public Squad_e17_cov_inf2_3 e17_cov_inf2_3 { get; set; }
        public Squad_e17_cov_ghosts0 e17_cov_ghosts0 { get; set; }
        public Squad_____PARK____ ____PARK____ { get; set; }
        public Squad_e18_mars_inf0 e18_mars_inf0 { get; set; }
        public Squad_e18_mars_warthog0 e18_mars_warthog0 { get; set; }
        public Squad_e18_cov_inf0 e18_cov_inf0 { get; set; }
        public Squad_e18_cov_inf1_0 e18_cov_inf1_0 { get; set; }
        public Squad_e18_cov_inf1_1 e18_cov_inf1_1 { get; set; }
        public Squad_e18_cov_ghosts0 e18_cov_ghosts0 { get; set; }
        public Squad_e19_mars_warthog0 e19_mars_warthog0 { get; set; }
        public Squad_e19_cov_inf0 e19_cov_inf0 { get; set; }
        public Squad_e19_cov_wraiths0_0 e19_cov_wraiths0_0 { get; set; }
        public Squad_e19_cov_ghosts0_0 e19_cov_ghosts0_0 { get; set; }
        public Squad_e19_cov_ghosts0_1 e19_cov_ghosts0_1 { get; set; }
        public Squad_____NEW_CITY____ ____NEW_CITY____ { get; set; }
        public Squad_e20_mars_warthog1 e20_mars_warthog1 { get; set; }
        public Squad_e20_mars_warthog0 e20_mars_warthog0 { get; set; }
        public Squad_e20_cov_ghosts0 e20_cov_ghosts0 { get; set; }
        public Squad_e21_mars_warthog0 e21_mars_warthog0 { get; set; }
        public Squad_e21_mars_inf0 e21_mars_inf0 { get; set; }
        public Squad_e21_mars_inf1 e21_mars_inf1 { get; set; }
        public Squad_e21_mars_pelican0 e21_mars_pelican0 { get; set; }
        public Squad_e21_mars_pelican1 e21_mars_pelican1 { get; set; }
        public Squad_e21_cov_wraiths0_0 e21_cov_wraiths0_0 { get; set; }
        public Squad_e21_cov_wraiths0_1 e21_cov_wraiths0_1 { get; set; }
        public Squad_e21_cov_wraiths0_2 e21_cov_wraiths0_2 { get; set; }
        public Squad_e21_cov_ghosts0_0 e21_cov_ghosts0_0 { get; set; }
        public Squad_e21_cov_ghosts0_1 e21_cov_ghosts0_1 { get; set; }
        public Squad_e21_cov_ghosts0_2 e21_cov_ghosts0_2 { get; set; }
        public Squad_e21_cov_phantom0 e21_cov_phantom0 { get; set; }
        public Squad_e21_cov_phantom1 e21_cov_phantom1 { get; set; }
        public Squad_e21_cov_creep0 e21_cov_creep0 { get; set; }
        public Squad_e21_cov_inf0 e21_cov_inf0 { get; set; }
        public Squad_e22_mars_inf0 e22_mars_inf0 { get; set; }
        public Squad_e22_mars_inf1 e22_mars_inf1 { get; set; }
        public Squad_e22_mars_inf2 e22_mars_inf2 { get; set; }
        public Squad_e22_mars_inf3 e22_mars_inf3 { get; set; }
        public Squad_e22_mars_scorpions0 e22_mars_scorpions0 { get; set; }
        public Squad_e23_mars_inf0 e23_mars_inf0 { get; set; }
        public Squad_e23_mars_inf1 e23_mars_inf1 { get; set; }
        public Squad_e23_mars_pelican0_0 e23_mars_pelican0_0 { get; set; }
        public Squad_e23_mars_pelican0_1 e23_mars_pelican0_1 { get; set; }
        public Squad_e23_mars_pelican1_0 e23_mars_pelican1_0 { get; set; }
        public Squad_e23_mars_pelican1_1 e23_mars_pelican1_1 { get; set; }
        public Squad_e23_mars_pelican2 e23_mars_pelican2 { get; set; }
        public Squad_e23_cov_inf0_0 e23_cov_inf0_0 { get; set; }
        public Squad_e23_cov_inf0_1 e23_cov_inf0_1 { get; set; }
        public Squad_e23_cov_inf0_2 e23_cov_inf0_2 { get; set; }
        public Squad_e23_cov_inf0_3 e23_cov_inf0_3 { get; set; }
        public Squad_e23_cov_inf0_4 e23_cov_inf0_4 { get; set; }
        public Squad_e23_cov_inf1_0 e23_cov_inf1_0 { get; set; }
        public Squad_e23_cov_inf1_1 e23_cov_inf1_1 { get; set; }
        public Squad_e18_cov_inf2_0 e18_cov_inf2_0 { get; set; }
        public Squad_e18_cov_inf2_1 e18_cov_inf2_1 { get; set; }
        public IAiActorDefinition marines => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition covenant1 => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition e14_mars => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition e14_cov => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition e14_cov_ghosts0 => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition e15_mars => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition e15_cov => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition e15_cov_inf2 => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition e15_cov_phantom0 => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition e16_mars => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition e16_cov => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition e16_cov_wraiths0 => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition e16_cov_ghosts0 => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition e16_cov_banshees0 => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition e16_cov_inf0 => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition e17_mars => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition e17_cov => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition e17_cov_inf0 => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition e17_cov_inf1 => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition e17_cov_inf2 => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition e18_mars => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition e18_cov => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition e18_cov_inf1 => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition e18_cov_inf2 => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition e19_mars => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition e19_cov => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition e19_cov_wraiths0 => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition e19_cov_ghosts0 => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition e20_mars => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition e20_cov => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition e21_mars => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition e21_cov => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition e21_cov_wraiths0 => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition e21_cov_ghosts0 => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition e22_mars => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition e23_mars => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition e23_mars_inf2 => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition e23_cov => Scenario.AiSquadGroupDefinitions[37];
        public IAiActorDefinition e23_cov_inf0 => Scenario.AiSquadGroupDefinitions[38];
        public IAiActorDefinition e23_cov_inf1 => Scenario.AiSquadGroupDefinitions[39];
        public IAiActorDefinition e23_mars_pelican0 => Scenario.AiSquadGroupDefinitions[40];
        public IAiOrders scarab_gunners_init => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders e14_mars_inf0_init => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders e14_mars_inf0_engage0 => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders e14_mars_inf0_engage1 => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders e14_mars_inf0_engage2 => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders e14_mars_inf0_engage3 => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders e14_mars_inf0_engage4 => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders e14_mars_inf0_engage5 => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders e14_mars_inf0_continue => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders e14_cov_ghosts0_engage0 => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders e14_cov_ghosts0_engage1 => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders e14_cov_ghosts0_engage2 => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders e14_cov_ghosts0_engage3 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders e14_cov_ghosts0_engage4 => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders e14_cov_ghosts0_engage5 => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders e14_cov_wraiths0_init => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders e14_cov_wraiths0_retreat => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders e14_cov_snipers0_init => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders e15_mars_inf0_follow => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders e15_cov_inf0_init => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders e15_cov_inf1_init => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders e15_cov_inf1_ambush => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders e15_cov_inf2_0_init => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders e15_cov_inf2_0_ambush => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders e15_cov_inf2_1_init => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders e15_cov_inf2_1_ambush => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders e15_cov_phantom0_0_init => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders e15_cov_phantom0_1_init => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders e15_cov_banshees01 => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders e16_mars_inf0_init => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders e16_mars_inf0_advance0 => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders e16_mars_inf0_advance1 => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders e16_mars_inf0_continue => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders e16_cov_inf0_flee0 => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders e16_cov_inf0_flee1 => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders e16_cov_wraiths0_init => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders e16_cov_wraiths1_init => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders e16_cov_ghosts0_init => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders e16_cov_ghosts0_retreat0 => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders e16_cov_ghosts0_retreat1 => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders e16_cov_ghosts1_engage => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders e16_cov_ghosts1_retreat => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders e16_cov_banshees0_init => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders e16_cov_banshees0_guard0 => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders e16_cov_phantom0_init => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders e17_mars_inf0_init => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders e17_mars_inf0_wait0 => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders e17_mars_inf0_advance0 => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders e17_mars_inf0_advance1 => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders e17_mars_inf0_advance2 => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders e17_mars_inf0_advance3 => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders e17_mars_inf0_advance4 => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders e17_mars_inf0_continue => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders e17_cov_inf0_section0 => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders e17_cov_inf0_section1 => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders e17_cov_inf0_section2 => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders e17_cov_inf0_section3 => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders e17_cov_inf0_2_init => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders e17_cov_inf0_3_init => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders e17_cov_inf1_init => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders e17_cov_inf1_section0 => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders e17_cov_inf1_section1 => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders e17_cov_inf1_section2 => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders e17_cov_inf1_section3 => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders e17_cov_inf1_engage0 => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders e17_cov_inf2_0_init => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders e17_cov_inf2_1_init => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders e17_cov_inf2_2_init => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders e17_cov_inf2_3_init => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders ____PARK____1 => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders e18_mars_inf0_init => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders e18_mars_inf0_advance0 => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders e18_mars_inf0_advance1 => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders e18_mars_inf0_advance2 => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders e18_mars_warthog0_init => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders e18_mars_warthog0_continue => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders e18_cov_inf0_init => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders e18_cov_inf0_retreat0 => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders e18_cov_inf1_0_init => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders e18_cov_inf1_1_init => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders e18_cov_inf2_init => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders e18_cov_ghosts0_init => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders e19_mars_warthog0_wraith => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders e19_mars_warthog0_ghosts => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders e19_mars_warthog0_continue => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders e19_cov_inf0_init => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders e19_cov_wraiths0_0_init => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders e19_cov_ghosts0_init => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders e20_mars_warthog0_init => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders e20_mars_warthog0_continue => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders e20_mars_warthog1_init => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders e20_cov_ghosts0_init => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders e21_mars_inf0_init => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders e21_mars_warthog0_phantom0 => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders e21_mars_warthog0_wraiths => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders e21_mars_warthog0_phantom1 => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders e21_mars_warthog0_ghosts => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders e21_mars_warthog0_done => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders e21_mars_inf1_init => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders e21_mars_inf1_engage0 => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders e21_mars_pelican0_init => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders e21_mars_pelican0_advance0 => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders e21_mars_pelican1_init => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders e21_cov_wraiths0_0_init => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders e21_cov_wraiths0_1_init => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders e21_cov_wraiths0_1_withdraw => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders e21_cov_wraiths0_retreat => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders e21_cov_ghosts0_guard0 => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders e21_cov_ghosts0_guard1 => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders e21_cov_ghosts0_engage => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders e21_cov_ghosts0_2_init => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders e21_cov_phantom0_init => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders e21_cov_phantom1_init => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders e21_cov_creep0_init => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders e21_cov_inf0_init => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders e21_cov_inf0_retreat => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders e22_mars_inf0_init => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders e22_mars_inf0_advance0 => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders e22_mars_inf0_advance1 => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders e22_mars_inf2_init => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders e22_mars_inf1_init => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders e23_mars_inf0_bridge1 => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders e23_mars_inf0_bridge2 => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders e23_mars_inf0_endpoint0 => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders e23_mars_inf1_bridge0 => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders e23_mars_inf1_bridge2 => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders e23_mars_inf1_endpoint0 => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders e23_cov_inf0_guard0 => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders e23_cov_inf0_guard1 => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders e23_cov_inf1_init => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders e23_cov_inf1_engage0 => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders e23_cov_inf1_1_init => Scenario.AiOrderDefinitions[131].GameObject;
        public ILocationFlag temp_bridge_rosebud => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag e14_test => Scenario.LocationFlagDefinitions[1].GameObject;
        public ILocationFlag e15_test => Scenario.LocationFlagDefinitions[2].GameObject;
        public ILocationFlag e16_test => Scenario.LocationFlagDefinitions[3].GameObject;
        public ILocationFlag e17_test => Scenario.LocationFlagDefinitions[4].GameObject;
        public ILocationFlag e18_test => Scenario.LocationFlagDefinitions[5].GameObject;
        public ILocationFlag e20_test => Scenario.LocationFlagDefinitions[6].GameObject;
        public ILocationFlag e21_test => Scenario.LocationFlagDefinitions[7].GameObject;
        public ILocationFlag e22_test => Scenario.LocationFlagDefinitions[8].GameObject;
        public ILocationFlag e22_nasty_player_synch1 => Scenario.LocationFlagDefinitions[9].GameObject;
        public ILocationFlag e23_test => Scenario.LocationFlagDefinitions[10].GameObject;
        public ILocationFlag p0_starting_loc => Scenario.LocationFlagDefinitions[11].GameObject;
        public ILocationFlag p1_starting_loc => Scenario.LocationFlagDefinitions[12].GameObject;
        public ILocationFlag anchor_flag_intra1 => Scenario.LocationFlagDefinitions[13].GameObject;
        public ILocationFlag flag_rupture => Scenario.LocationFlagDefinitions[14].GameObject;
        public ILocationFlag flag_shockwave_far => Scenario.LocationFlagDefinitions[15].GameObject;
        public ILocationFlag e23_scarab_start => Scenario.LocationFlagDefinitions[16].GameObject;
        public ILocationFlag anchor_flag_x03_01 => Scenario.LocationFlagDefinitions[17].GameObject;
        public ILocationFlag anchor_flag_x03_03 => Scenario.LocationFlagDefinitions[18].GameObject;
        public ILocationFlag e18_scarab_start => Scenario.LocationFlagDefinitions[19].GameObject;
        public ILocationFlag e22_scarab_start => Scenario.LocationFlagDefinitions[20].GameObject;
        public ILocationFlag e22_navpoint => Scenario.LocationFlagDefinitions[21].GameObject;
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[22].GameObject;
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[23].GameObject;
        public ILocationFlag anchor_flag_x03_02 => Scenario.LocationFlagDefinitions[24].GameObject;
        public ILocationFlag x03_flag_smoke_01 => Scenario.LocationFlagDefinitions[25].GameObject;
        public ILocationFlag player0_end => Scenario.LocationFlagDefinitions[26].GameObject;
        public ILocationFlag player1_end => Scenario.LocationFlagDefinitions[27].GameObject;
        public ICinematicTitle title0_normal => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title0_heroic => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title0_legendary => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ICinematicTitle title1 => Scenario.CinematicTitleDefinitions[3].GameObject;
        public ICinematicTitle title2 => Scenario.CinematicTitleDefinitions[4].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume bsp_1_0 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume tv_cutscene_bridge_main_begin => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume tv_e14_blockade0 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume tv_e14_blockade1 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume tv_e14_blockade2 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume tv_e14_blockade3 => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume tv_e14_blockade4 => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume tv_e14_blockade5 => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume tv_e15_main_begin => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume tv_e15_cov_inf1_spring => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume tv_e15_cov_phantoms0_begin => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume tv_e15_cov_inf2_1_spring => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_e16_main_begin => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume tv_e16_toll_plaza => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_e16_tunnel => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_e16_bridge_end => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_e17_main_begin => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_e17_on_back_wall => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume tv_e17_second_wall => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume tv_e18_main_begin => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume tv_e19_main_begin0 => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume tv_e19_scarab_withdraws => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume tv_e19_player_advanced => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_e20_main_begin => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_e21_main_begin => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume tv_e21_boulevard0 => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_e21_boulevard1 => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_e21_cov_inf0_unsafe => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume tv_e22_main_begin => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume tv_e22_no_teleport => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume tv_e22_begin_scarab_sequence => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_e22_stairwell => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_e22_scarab_entry_begin => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume tv_e22_mars_inf2_visible => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume tv_e22_mars_inf0_visible => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_e22_mars_inf3_begin => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_e21_mars_inf0_unsafe => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_e21_mars_inf1_begin => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_scarab_in_view => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_scarab_in_range => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_e22_near_building => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume tv_e22_away_from_building => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_scarab_passed_overhead => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume tv_scarab_beside_building2 => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_scarab_nearing_bridge0 => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_scarab_below_bridge0 => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_scarab_nearing_bridge1 => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume tv_scarab_below_bridge1 => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume tv_scarab_below_bridge2 => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume tv_scarab_below_bridge3 => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume tv_scarab_below_bridge4 => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume tv_scarab_gap0 => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume tv_scarab_gap1 => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume tv_scarab_gap2 => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume tv_scarab_gap3 => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume tv_scarab_gap4 => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume tv_scarab_gap5 => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume tv_e23_mars_inf2_1_begin => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume tv_e23_mars_inf2_2_begin => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume tv_e23_mars_inf2_reins => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume tv_e23_main_begin => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume tv_e21_cov_creep0_main => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume tv_e15_phantom_drop_zone0 => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume tv_e21_cov_phantom_erase => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume tv_e17_objectives => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume tv_e23_mars_pelican0_begin => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume tv_e17_section0 => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume tv_e17_section1 => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume tv_e17_section2 => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume tv_e17_section3 => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume tv_e17_cov_inf2_1_begin => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume tv_e17_near_second_wall => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume tv_e17_near_first_wall => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume tv_e17_exit => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume tv_e22_advanced_inside => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume tv_e23_mars_pelican1_begin => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume tv_e19_cov_ghosts0_1_unsafe => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume tv_e16_cov_inf0_1_begin => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume tv_e16_cov_inf0_2_begin => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume tv_e16_cov_inf0_flee1 => Scenario.TriggerVolumes[80].GameObject;
        public ITriggerVolume tv_e14_mars_inf0_advance => Scenario.TriggerVolumes[81].GameObject;
        public ITriggerVolume tv_e17_on_first_wall => Scenario.TriggerVolumes[82].GameObject;
        public ITriggerVolume tv_e17_in_water => Scenario.TriggerVolumes[83].GameObject;
        public ITriggerVolume tv_scarab => Scenario.TriggerVolumes[84].GameObject;
        public ITriggerVolume tv_scarab_stairwell => Scenario.TriggerVolumes[85].GameObject;
        public ITriggerVolume tv_scarab_interior => Scenario.TriggerVolumes[86].GameObject;
        public ITriggerVolume tv_e15_phantom_drop_zone1 => Scenario.TriggerVolumes[87].GameObject;
        public ITriggerVolume tv_e19_cov_inf0_begin => Scenario.TriggerVolumes[88].GameObject;
        public ITriggerVolume tv_e23_scarab_corner_continue => Scenario.TriggerVolumes[89].GameObject;
        public ITriggerVolume tv_e19_main_begin1 => Scenario.TriggerVolumes[90].GameObject;
        public ITriggerVolume kill_e23_0 => Scenario.TriggerVolumes[91].GameObject;
        public ITriggerVolume kill_e23_1 => Scenario.TriggerVolumes[92].GameObject;
        public ITriggerVolume kill_e23_2 => Scenario.TriggerVolumes[93].GameObject;
        public ITriggerVolume kill_e14_0 => Scenario.TriggerVolumes[94].GameObject;
        public ITriggerVolume kill_e18_0 => Scenario.TriggerVolumes[95].GameObject;
        public ITriggerVolume tv_e22_street_cleanup => Scenario.TriggerVolumes[96].GameObject;
        public ITriggerVolume test => Scenario.TriggerVolumes[97].GameObject;
        public ITriggerVolume trans_0_1 => Scenario.TriggerVolumes[98].GameObject;
        public ITriggerVolume trans_1_0 => Scenario.TriggerVolumes[99].GameObject;
        public ITriggerVolume tv_dark_area0 => Scenario.TriggerVolumes[100].GameObject;
        public ITriggerVolume tv_e17_near_exit => Scenario.TriggerVolumes[101].GameObject;
        public ITriggerVolume tv_e17_on_ramp => Scenario.TriggerVolumes[102].GameObject;
        public ITriggerVolume tv_e22_doorway => Scenario.TriggerVolumes[103].GameObject;
        public ITriggerVolume tv_e21_cov_wraith0_2_unsafe => Scenario.TriggerVolumes[104].GameObject;
        public ITriggerVolume tv_e23_entry_door => Scenario.TriggerVolumes[105].GameObject;
        public ITriggerVolume tv_e18_cov_inf2_1_unsafe0 => Scenario.TriggerVolumes[106].GameObject;
        public ITriggerVolume tv_e18_second_half => Scenario.TriggerVolumes[107].GameObject;
        public ITriggerVolume tv_e18_cov_inf2_1_unsafe1 => Scenario.TriggerVolumes[108].GameObject;
        public ITriggerVolume flock0 => Scenario.TriggerVolumes[109].GameObject;
        public ITriggerVolume flock1 => Scenario.TriggerVolumes[110].GameObject;
        public ITriggerVolume flock2 => Scenario.TriggerVolumes[111].GameObject;
        public ITriggerVolume flock3 => Scenario.TriggerVolumes[112].GameObject;
        public ITriggerVolume tv_e17_migration_area => Scenario.TriggerVolumes[113].GameObject;
        public ITriggerVolume tv_e17_first_wall_approach => Scenario.TriggerVolumes[114].GameObject;
        public ITriggerVolume tv_e17_cov_inf0_2_init => Scenario.TriggerVolumes[115].GameObject;
        public ITriggerVolume tv_scarab_no_save => Scenario.TriggerVolumes[116].GameObject;
        public IStartingProfile starting_profile => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile respawn_profile => Scenario.StartingProfileDefinitions[1].GameObject;
        public IDeviceGroup e17_tunnel_door0 => Scenario.DeviceGroupDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            scarab_01 = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            iac = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            carrier_02 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            e22_bridge0_0 = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            e22_bridge0_3 = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            e22_bridge0_1 = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            e22_bridge0_4 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            e22_bridge0_5 = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            e22_bridge0_2 = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            e22_bridge1_0 = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            e22_bridge1_1 = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            e22_bridge1_2 = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            e22_bridge1_3 = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            e22_bridge1_4 = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            e22_bridge1_5 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            e22_bridge1_6 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            e22_bridge1_7 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            e22_bridge1_8 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            e22_bridge1_9 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            e22_bridge2_0 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            e22_bridge2_1 = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            e22_bridge2_2 = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            e22_bridge2_3 = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            e22_bridge2_4 = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            e22_bridge2_5 = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            anchor_x03_03 = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            scarab_02 = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            rifle_01 = new ScenarioEntity<IScenery>(27, scenarioTag.WellKnownItems[27]);
            rifle_03 = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            rifle_02 = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            anchor_x03_01 = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            rear_gun = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            anchor_intra1 = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            dont_fuck_with_me0 = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            dont_fuck_with_me1 = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            texture_camera = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            cinematic_tollbooth = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            iac_bridge = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            carrier = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            x03_smoke = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            x03_shockwave_close = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            x03_shockwave_far = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            x03_bus = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            x03_truck = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            x03_generator = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            x03_dumpster = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            x03_slipspace_collapse = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            cigar = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            ui_test_ship = new ScenarioEntity<IScenery>(68, scenarioTag.WellKnownItems[68]);
            x03_shockwave_start = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            e19_tree0 = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            e19_tree1 = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            with_me_do_not_fuck0 = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            dont_fuck0 = new ScenarioEntity<IScenery>(73, scenarioTag.WellKnownItems[73]);
            dont_fuck1 = new ScenarioEntity<IScenery>(74, scenarioTag.WellKnownItems[74]);
            dont_fuck2 = new ScenarioEntity<IScenery>(75, scenarioTag.WellKnownItems[75]);
            dont_fuck3 = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            dont_fuck4 = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            dont_fuck_with_me2 = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            anchor_x03_02 = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            temp_bridge_johnson = new ScenarioEntity<IUnit>(80, scenarioTag.WellKnownItems[80]);
            johnson = new ScenarioEntity<IUnit>(81, scenarioTag.WellKnownItems[81]);
            chief = new ScenarioEntity<IUnit>(82, scenarioTag.WellKnownItems[82]);
            marine_02 = new ScenarioEntity<IUnit>(83, scenarioTag.WellKnownItems[83]);
            marine_01 = new ScenarioEntity<IUnit>(84, scenarioTag.WellKnownItems[84]);
            pilot = new ScenarioEntity<IUnit>(85, scenarioTag.WellKnownItems[85]);
            hood = new ScenarioEntity<IUnit>(86, scenarioTag.WellKnownItems[86]);
            miranda = new ScenarioEntity<IUnit>(87, scenarioTag.WellKnownItems[87]);
            johnson_03 = new ScenarioEntity<IUnit>(88, scenarioTag.WellKnownItems[88]);
            pilot_02 = new ScenarioEntity<IUnit>(89, scenarioTag.WellKnownItems[89]);
            nav_officer = new ScenarioEntity<IUnit>(90, scenarioTag.WellKnownItems[90]);
            johnson_02 = new ScenarioEntity<IUnit>(91, scenarioTag.WellKnownItems[91]);
            e17_test_tank = new ScenarioEntity<IVehicle>(92, scenarioTag.WellKnownItems[92]);
            temp_bridge_tank = new ScenarioEntity<IVehicle>(93, scenarioTag.WellKnownItems[93]);
            scorpion_01 = new ScenarioEntity<IVehicle>(94, scenarioTag.WellKnownItems[94]);
            pelican_01b = new ScenarioEntity<IVehicle>(95, scenarioTag.WellKnownItems[95]);
            pelican_02 = new ScenarioEntity<IVehicle>(96, scenarioTag.WellKnownItems[96]);
            e23_gun = new ScenarioEntity<IVehicle>(97, scenarioTag.WellKnownItems[97]);
            scorpion_02 = new ScenarioEntity<IVehicle>(98, scenarioTag.WellKnownItems[98]);
            pelican_01a = new ScenarioEntity<IVehicle>(99, scenarioTag.WellKnownItems[99]);
            e22_scarab_gun = new ScenarioEntity<IWeapon>(100, scenarioTag.WellKnownItems[100]);
            key = new ScenarioEntity<IWeapon>(101, scenarioTag.WellKnownItems[101]);
            scarab = new ScenarioEntity<IDevice>(102, scenarioTag.WellKnownItems[102]);
            e17_door0 = new ScenarioEntity<IDevice>(103, scenarioTag.WellKnownItems[103]);
            e17_door1 = new ScenarioEntity<IDevice>(104, scenarioTag.WellKnownItems[104]);
            e22_door0 = new ScenarioEntity<IDevice>(105, scenarioTag.WellKnownItems[105]);
            e22_door1 = new ScenarioEntity<IDevice>(106, scenarioTag.WellKnownItems[106]);
            e22_door2 = new ScenarioEntity<IDevice>(107, scenarioTag.WellKnownItems[107]);
            e22_door3 = new ScenarioEntity<IDevice>(108, scenarioTag.WellKnownItems[108]);
            scarab_gunners = new Squad_scarab_gunners(scenarioTag);
            e14_mars_inf0 = new Squad_e14_mars_inf0(scenarioTag);
            e14_mars_pelican0 = new Squad_e14_mars_pelican0(scenarioTag);
            e14_cov_ghosts0_0 = new Squad_e14_cov_ghosts0_0(scenarioTag);
            e14_cov_ghosts0_1 = new Squad_e14_cov_ghosts0_1(scenarioTag);
            e14_cov_wraiths0 = new Squad_e14_cov_wraiths0(scenarioTag);
            e14_cov_snipers0 = new Squad_e14_cov_snipers0(scenarioTag);
            e15_mars_inf0 = new Squad_e15_mars_inf0(scenarioTag);
            e15_cov_inf0 = new Squad_e15_cov_inf0(scenarioTag);
            e15_cov_inf1 = new Squad_e15_cov_inf1(scenarioTag);
            e15_cov_inf2_0 = new Squad_e15_cov_inf2_0(scenarioTag);
            e15_cov_inf2_1 = new Squad_e15_cov_inf2_1(scenarioTag);
            e15_cov_phantom0_0 = new Squad_e15_cov_phantom0_0(scenarioTag);
            e15_cov_phantom0_1 = new Squad_e15_cov_phantom0_1(scenarioTag);
            e15_cov_phantom1 = new Squad_e15_cov_phantom1(scenarioTag);
            e15_cov_banshees0 = new Squad_e15_cov_banshees0(scenarioTag);
            e16_mars_inf0 = new Squad_e16_mars_inf0(scenarioTag);
            e16_cov_wraiths0_0 = new Squad_e16_cov_wraiths0_0(scenarioTag);
            e16_cov_wraiths0_1 = new Squad_e16_cov_wraiths0_1(scenarioTag);
            e16_cov_wraiths1 = new Squad_e16_cov_wraiths1(scenarioTag);
            e16_cov_ghosts0_0 = new Squad_e16_cov_ghosts0_0(scenarioTag);
            e16_cov_ghosts0_1 = new Squad_e16_cov_ghosts0_1(scenarioTag);
            e16_cov_ghosts1 = new Squad_e16_cov_ghosts1(scenarioTag);
            e16_cov_banshees0_0 = new Squad_e16_cov_banshees0_0(scenarioTag);
            e16_cov_banshees0_1 = new Squad_e16_cov_banshees0_1(scenarioTag);
            e16_cov_inf0_0 = new Squad_e16_cov_inf0_0(scenarioTag);
            e16_cov_inf0_1 = new Squad_e16_cov_inf0_1(scenarioTag);
            e16_cov_inf0_2 = new Squad_e16_cov_inf0_2(scenarioTag);
            e16_cov_phantom0 = new Squad_e16_cov_phantom0(scenarioTag);
            e17_mars_inf0 = new Squad_e17_mars_inf0(scenarioTag);
            e17_cov_inf0_0 = new Squad_e17_cov_inf0_0(scenarioTag);
            e17_cov_inf0_1 = new Squad_e17_cov_inf0_1(scenarioTag);
            e17_cov_inf0_2 = new Squad_e17_cov_inf0_2(scenarioTag);
            e17_cov_inf0_3 = new Squad_e17_cov_inf0_3(scenarioTag);
            e17_cov_inf1_0 = new Squad_e17_cov_inf1_0(scenarioTag);
            e17_cov_inf1_1 = new Squad_e17_cov_inf1_1(scenarioTag);
            e17_cov_inf2_0 = new Squad_e17_cov_inf2_0(scenarioTag);
            e17_cov_inf2_1 = new Squad_e17_cov_inf2_1(scenarioTag);
            e17_cov_inf2_2 = new Squad_e17_cov_inf2_2(scenarioTag);
            e17_cov_inf2_3 = new Squad_e17_cov_inf2_3(scenarioTag);
            e17_cov_ghosts0 = new Squad_e17_cov_ghosts0(scenarioTag);
            ____PARK____ = new Squad_____PARK____(scenarioTag);
            e18_mars_inf0 = new Squad_e18_mars_inf0(scenarioTag);
            e18_mars_warthog0 = new Squad_e18_mars_warthog0(scenarioTag);
            e18_cov_inf0 = new Squad_e18_cov_inf0(scenarioTag);
            e18_cov_inf1_0 = new Squad_e18_cov_inf1_0(scenarioTag);
            e18_cov_inf1_1 = new Squad_e18_cov_inf1_1(scenarioTag);
            e18_cov_ghosts0 = new Squad_e18_cov_ghosts0(scenarioTag);
            e19_mars_warthog0 = new Squad_e19_mars_warthog0(scenarioTag);
            e19_cov_inf0 = new Squad_e19_cov_inf0(scenarioTag);
            e19_cov_wraiths0_0 = new Squad_e19_cov_wraiths0_0(scenarioTag);
            e19_cov_ghosts0_0 = new Squad_e19_cov_ghosts0_0(scenarioTag);
            e19_cov_ghosts0_1 = new Squad_e19_cov_ghosts0_1(scenarioTag);
            ____NEW_CITY____ = new Squad_____NEW_CITY____(scenarioTag);
            e20_mars_warthog1 = new Squad_e20_mars_warthog1(scenarioTag);
            e20_mars_warthog0 = new Squad_e20_mars_warthog0(scenarioTag);
            e20_cov_ghosts0 = new Squad_e20_cov_ghosts0(scenarioTag);
            e21_mars_warthog0 = new Squad_e21_mars_warthog0(scenarioTag);
            e21_mars_inf0 = new Squad_e21_mars_inf0(scenarioTag);
            e21_mars_inf1 = new Squad_e21_mars_inf1(scenarioTag);
            e21_mars_pelican0 = new Squad_e21_mars_pelican0(scenarioTag);
            e21_mars_pelican1 = new Squad_e21_mars_pelican1(scenarioTag);
            e21_cov_wraiths0_0 = new Squad_e21_cov_wraiths0_0(scenarioTag);
            e21_cov_wraiths0_1 = new Squad_e21_cov_wraiths0_1(scenarioTag);
            e21_cov_wraiths0_2 = new Squad_e21_cov_wraiths0_2(scenarioTag);
            e21_cov_ghosts0_0 = new Squad_e21_cov_ghosts0_0(scenarioTag);
            e21_cov_ghosts0_1 = new Squad_e21_cov_ghosts0_1(scenarioTag);
            e21_cov_ghosts0_2 = new Squad_e21_cov_ghosts0_2(scenarioTag);
            e21_cov_phantom0 = new Squad_e21_cov_phantom0(scenarioTag);
            e21_cov_phantom1 = new Squad_e21_cov_phantom1(scenarioTag);
            e21_cov_creep0 = new Squad_e21_cov_creep0(scenarioTag);
            e21_cov_inf0 = new Squad_e21_cov_inf0(scenarioTag);
            e22_mars_inf0 = new Squad_e22_mars_inf0(scenarioTag);
            e22_mars_inf1 = new Squad_e22_mars_inf1(scenarioTag);
            e22_mars_inf2 = new Squad_e22_mars_inf2(scenarioTag);
            e22_mars_inf3 = new Squad_e22_mars_inf3(scenarioTag);
            e22_mars_scorpions0 = new Squad_e22_mars_scorpions0(scenarioTag);
            e23_mars_inf0 = new Squad_e23_mars_inf0(scenarioTag);
            e23_mars_inf1 = new Squad_e23_mars_inf1(scenarioTag);
            e23_mars_pelican0_0 = new Squad_e23_mars_pelican0_0(scenarioTag);
            e23_mars_pelican0_1 = new Squad_e23_mars_pelican0_1(scenarioTag);
            e23_mars_pelican1_0 = new Squad_e23_mars_pelican1_0(scenarioTag);
            e23_mars_pelican1_1 = new Squad_e23_mars_pelican1_1(scenarioTag);
            e23_mars_pelican2 = new Squad_e23_mars_pelican2(scenarioTag);
            e23_cov_inf0_0 = new Squad_e23_cov_inf0_0(scenarioTag);
            e23_cov_inf0_1 = new Squad_e23_cov_inf0_1(scenarioTag);
            e23_cov_inf0_2 = new Squad_e23_cov_inf0_2(scenarioTag);
            e23_cov_inf0_3 = new Squad_e23_cov_inf0_3(scenarioTag);
            e23_cov_inf0_4 = new Squad_e23_cov_inf0_4(scenarioTag);
            e23_cov_inf1_0 = new Squad_e23_cov_inf1_0(scenarioTag);
            e23_cov_inf1_1 = new Squad_e23_cov_inf1_1(scenarioTag);
            e18_cov_inf2_0 = new Squad_e18_cov_inf2_0(scenarioTag);
            e18_cov_inf2_1 = new Squad_e18_cov_inf2_1(scenarioTag);
        }

        public class Squad_scarab_gunners
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition main_gunner => ScenarioTag.AiSquadDefinitions[0].StartingLocations[0];
            public IAiActorDefinition upper_gunner => ScenarioTag.AiSquadDefinitions[0].StartingLocations[1];
            public IAiActorDefinition rear_gunner => ScenarioTag.AiSquadDefinitions[0].StartingLocations[2];
            public IAiActorDefinition right_gunner0 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[3];
            public IAiActorDefinition right_gunner1 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[4];
            public IAiActorDefinition left_gunner0 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[5];
            public IAiActorDefinition left_gunner1 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_scarab_gunners(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e14_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition scorpion0 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[2];
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[3];
            public IAiActorDefinition warthog1 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_e14_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e14_mars_pelican0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[0];
            public IAiActorDefinition johnson0 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[1];
            public IAiActorDefinition gunner0 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_e14_mars_pelican0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e14_cov_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_e14_cov_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e14_cov_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_e14_cov_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e14_cov_wraiths0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_e14_cov_wraiths0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e14_cov_snipers0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_e14_cov_snipers0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[0];
            public IAiActorDefinition marine0 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_e15_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_e15_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_cov_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition bugger0 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[0];
            public IAiActorDefinition bugger1 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[1];
            public IAiActorDefinition bugger2 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[2];
            public IAiActorDefinition bugger3 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[3];
            public IAiActorDefinition bugger4 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[4];
            public IAiActorDefinition bugger5 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_e15_cov_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_cov_inf2_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_e15_cov_inf2_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_cov_inf2_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_e15_cov_inf2_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_cov_phantom0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_e15_cov_phantom0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_cov_phantom0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_e15_cov_phantom0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_cov_phantom1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_e15_cov_phantom1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e15_cov_banshees0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition banshee0 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[0];
            public IAiActorDefinition banshee1 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_e15_cov_banshees0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_e16_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_wraiths0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[0];
            public IAiActorDefinition wraith1 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_e16_cov_wraiths0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_wraiths0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad_e16_cov_wraiths0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_wraiths1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_e16_cov_wraiths1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_e16_cov_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[0];
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_e16_cov_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_ghosts1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_e16_cov_ghosts1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_banshees0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_e16_cov_banshees0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_banshees0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_e16_cov_banshees0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_e16_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_e16_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_e16_cov_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e16_cov_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_e16_cov_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[0];
            public IAiActorDefinition passenger0 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_e17_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_e17_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_e17_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_e17_cov_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf0_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_e17_cov_inf0_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_e17_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_e17_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf2_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_e17_cov_inf2_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf2_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_e17_cov_inf2_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf2_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_e17_cov_inf2_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_inf2_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_e17_cov_inf2_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e17_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_e17_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_____PARK____
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_____PARK____(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e18_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_e18_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e18_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_e18_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e18_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_e18_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e18_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_e18_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e18_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_e18_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e18_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_e18_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e19_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_e19_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e19_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_e19_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e19_cov_wraiths0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_e19_cov_wraiths0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e19_cov_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_e19_cov_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e19_cov_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_e19_cov_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_____NEW_CITY____
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_____NEW_CITY____(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e20_mars_warthog1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition gunner0 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[0];
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[1];
            public IAiActorDefinition spare => ScenarioTag.AiSquadDefinitions[54].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad_e20_mars_warthog1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e20_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[1];
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_e20_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e20_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[0];
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_e20_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_mars_warthog0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog0 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_e21_mars_warthog0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_e21_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_mars_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_e21_mars_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_mars_pelican0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[0];
            public IAiActorDefinition scorpion0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_e21_mars_pelican0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_mars_pelican1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_e21_mars_pelican1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_wraiths0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_e21_cov_wraiths0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_wraiths0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_e21_cov_wraiths0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_wraiths0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_e21_cov_wraiths0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[0];
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_e21_cov_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_e21_cov_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_ghosts0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_e21_cov_ghosts0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_e21_cov_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_phantom1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_e21_cov_phantom1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_creep0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_e21_cov_creep0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_e21_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition perez => ScenarioTag.AiSquadDefinitions[72].StartingLocations[0];
            public IAiActorDefinition guard0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[1];
            public IAiActorDefinition guard2 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[2];
            public IAiActorDefinition guard1 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[3];
            public IAiActorDefinition medic0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_e22_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_mars_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition lieutenant => ScenarioTag.AiSquadDefinitions[73].StartingLocations[0];
            public IAiActorDefinition marine0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[1];
            public IAiActorDefinition marine1 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_e22_mars_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_mars_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition marine0 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[0];
            public IAiActorDefinition marine1 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[1];
            public IAiActorDefinition marine2 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[2];
            public IAiActorDefinition marine3 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[3];
            public IAiActorDefinition marine4 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_e22_mars_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_mars_inf3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_e22_mars_inf3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_mars_scorpions0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition scorpion0 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad_e22_mars_scorpions0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_mars_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_e23_mars_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_mars_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_e23_mars_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_mars_pelican0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[0];
            public IAiActorDefinition gunner0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[1];
            public IAiActorDefinition gunner1 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_e23_mars_pelican0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_mars_pelican0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[0];
            public IAiActorDefinition gunner0 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[1];
            public IAiActorDefinition gunner1 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_e23_mars_pelican0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_mars_pelican1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_e23_mars_pelican1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_mars_pelican1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_e23_mars_pelican1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_mars_pelican2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican0 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[0];
            public IAiActorDefinition pelican1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[1];
            public IAiActorDefinition pelican2 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[2];
            public IAiActorDefinition gunner0 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[3];
            public IAiActorDefinition gunner1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_e23_mars_pelican2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_e23_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[85];
            public Squad_e23_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_cov_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[1];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[2];
            public IAiActorDefinition starting_locations_32 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[86];
            public Squad_e23_cov_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_cov_inf0_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[87];
            public Squad_e23_cov_inf0_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_cov_inf0_4
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[88];
            public Squad_e23_cov_inf0_4(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ultra0 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[89];
            public Squad_e23_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot0 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[0];
            public IAiActorDefinition pilot1 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[90];
            public Squad_e23_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e18_cov_inf2_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[91];
            public Squad_e18_cov_inf2_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e18_cov_inf2_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition sniper0 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[0];
            public IAiActorDefinition sniper1 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[92];
            public Squad_e18_cov_inf2_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}