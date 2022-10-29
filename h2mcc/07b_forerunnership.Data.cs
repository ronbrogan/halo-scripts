namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_07b_forerunnership : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> anchor_intra1 { get; set; }
        public ScenarioEntity<IScenery> e6_howler1 { get; set; }
        public ScenarioEntity<IScenery> e6_howler2 { get; set; }
        public ScenarioEntity<IScenery> e9_howler1 { get; set; }
        public ScenarioEntity<IScenery> e6_howler_spec2 { get; set; }
        public ScenarioEntity<IScenery> e6_howler_spec1 { get; set; }
        public ScenarioEntity<IScenery> e12_howler1 { get; set; }
        public ScenarioEntity<IScenery> e6_howler4 { get; set; }
        public ScenarioEntity<IScenery> e6_howler_spec3 { get; set; }
        public ScenarioEntity<IScenery> e6_howler_spec4 { get; set; }
        public ScenarioEntity<IScenery> e10_howler1 { get; set; }
        public ScenarioEntity<IScenery> e10_howler2 { get; set; }
        public ScenarioEntity<IScenery> e10_howler3 { get; set; }
        public ScenarioEntity<IScenery> e10_howler4 { get; set; }
        public ScenarioEntity<IScenery> e12_howler2 { get; set; }
        public ScenarioEntity<IScenery> e1_broadcast1 { get; set; }
        public ScenarioEntity<IScenery> e1_broadcast2 { get; set; }
        public ScenarioEntity<IScenery> e1_broadcast3 { get; set; }
        public ScenarioEntity<IScenery> e1_broadcast4 { get; set; }
        public ScenarioEntity<IScenery> e1_broadcast5 { get; set; }
        public ScenarioEntity<IScenery> e1_broadcast6 { get; set; }
        public ScenarioEntity<IScenery> e10_broadcast1 { get; set; }
        public ScenarioEntity<IScenery> e10_broadcast2 { get; set; }
        public ScenarioEntity<IScenery> e10_broadcast3 { get; set; }
        public ScenarioEntity<IScenery> e10_broadcast5 { get; set; }
        public ScenarioEntity<IScenery> e10_broadcast6 { get; set; }
        public ScenarioEntity<IScenery> e6_broadcast1 { get; set; }
        public ScenarioEntity<IScenery> e8_broadcast1 { get; set; }
        public ScenarioEntity<IScenery> e8_howler1 { get; set; }
        public ScenarioEntity<IScenery> e8_howler3 { get; set; }
        public ScenarioEntity<IScenery> ledge_1 { get; set; }
        public ScenarioEntity<IScenery> ledge_2 { get; set; }
        public ScenarioEntity<IScenery> ledge_3 { get; set; }
        public ScenarioEntity<IScenery> ledge_4 { get; set; }
        public ScenarioEntity<IScenery> ledge_5 { get; set; }
        public ScenarioEntity<IScenery> ledge_6 { get; set; }
        public ScenarioEntity<IScenery> ledge_7 { get; set; }
        public ScenarioEntity<IScenery> ledge_8 { get; set; }
        public ScenarioEntity<IScenery> ledge_9 { get; set; }
        public ScenarioEntity<IScenery> ledge_10 { get; set; }
        public ScenarioEntity<IScenery> ledge_11 { get; set; }
        public ScenarioEntity<IScenery> ledge_99 { get; set; }
        public ScenarioEntity<IScenery> ledge_98 { get; set; }
        public ScenarioEntity<IScenery> ledge_97 { get; set; }
        public ScenarioEntity<IBloc> e12_right_a { get; set; }
        public ScenarioEntity<IBloc> e12_left_d { get; set; }
        public ScenarioEntity<IBloc> e12_right_d { get; set; }
        public ScenarioEntity<IBloc> e12_right_q { get; set; }
        public ScenarioEntity<IBloc> e12_right_f { get; set; }
        public ScenarioEntity<IBloc> e12_left_h { get; set; }
        public ScenarioEntity<IBloc> e12_right_j { get; set; }
        public ScenarioEntity<IBloc> e12_left_i { get; set; }
        public ScenarioEntity<IBloc> e12_left_j { get; set; }
        public ScenarioEntity<IBloc> e12_left_m { get; set; }
        public ScenarioEntity<IBloc> e12_right_m { get; set; }
        public ScenarioEntity<IScenery> anchor_outro1 { get; set; }
        public ScenarioEntity<IScenery> anchor_outro2 { get; set; }
        public ScenarioEntity<IScenery> cap { get; set; }
        public ScenarioEntity<IScenery> ring_01 { get; set; }
        public ScenarioEntity<IScenery> ring_02 { get; set; }
        public ScenarioEntity<IScenery> ring_03 { get; set; }
        public ScenarioEntity<IScenery> ring_04 { get; set; }
        public ScenarioEntity<IScenery> ring_05 { get; set; }
        public ScenarioEntity<IScenery> ring_06 { get; set; }
        public ScenarioEntity<IScenery> ring_07 { get; set; }
        public ScenarioEntity<IScenery> ring_08 { get; set; }
        public ScenarioEntity<IScenery> forerunner_ship { get; set; }
        public ScenarioEntity<IScenery> alcove { get; set; }
        public ScenarioEntity<IScenery> matte_high_charity { get; set; }
        public ScenarioEntity<IScenery> matte_substance { get; set; }
        public ScenarioEntity<IScenery> conduit { get; set; }
        public ScenarioEntity<IScenery> takeoff_dust { get; set; }
        public ScenarioEntity<IScenery> cortana_base { get; set; }
        public ScenarioEntity<IScenery> slipspace { get; set; }
        public ScenarioEntity<IScenery> e5_speaker0 { get; set; }
        public ScenarioEntity<IScenery> e5_speaker1 { get; set; }
        public ScenarioEntity<IScenery> e5_speaker2 { get; set; }
        public ScenarioEntity<IScenery> e5_speaker3 { get; set; }
        public ScenarioEntity<IScenery> e5_speaker4 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker0 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker1 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker2 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker3 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker4 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker5 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker_gm0 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker_gm1 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker_gm2 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker_gm3 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker_gm4 { get; set; }
        public ScenarioEntity<IScenery> e8_speaker_gm5 { get; set; }
        public ScenarioEntity<IScenery> e12_speaker0 { get; set; }
        public ScenarioEntity<IScenery> e12_speaker1 { get; set; }
        public ScenarioEntity<IScenery> e12_speaker2 { get; set; }
        public ScenarioEntity<IScenery> e12_speaker3 { get; set; }
        public ScenarioEntity<IScenery> e12_speaker4 { get; set; }
        public ScenarioEntity<IScenery> e10_speaker0 { get; set; }
        public ScenarioEntity<IScenery> e10_speaker1 { get; set; }
        public ScenarioEntity<IScenery> e10_speaker2 { get; set; }
        public ScenarioEntity<IScenery> e10_speaker3 { get; set; }
        public ScenarioEntity<IScenery> e10_speaker4 { get; set; }
        public ScenarioEntity<IScenery> e10_speaker5 { get; set; }
        public ScenarioEntity<IScenery> e6_speaker0 { get; set; }
        public ScenarioEntity<IScenery> e6_speaker1 { get; set; }
        public ScenarioEntity<IScenery> e6_speaker2 { get; set; }
        public ScenarioEntity<IScenery> e6_speaker3 { get; set; }
        public ScenarioEntity<IScenery> e6_speaker4 { get; set; }
        public ScenarioEntity<IScenery> e6_speaker5 { get; set; }
        public ScenarioEntity<IScenery> e6_speaker_gm0 { get; set; }
        public ScenarioEntity<IScenery> e6_speaker_gm1 { get; set; }
        public ScenarioEntity<IScenery> e5_speaker5 { get; set; }
        public ScenarioEntity<IScenery> end_ped_a { get; set; }
        public ScenarioEntity<IScenery> end_ped_b { get; set; }
        public ScenarioEntity<IScenery> offending_crate_01 { get; set; }
        public ScenarioEntity<IScenery> offending_crate_02 { get; set; }
        public ScenarioEntity<IScenery> outro_fleet_01 { get; set; }
        public ScenarioEntity<IScenery> outro_fleet_02 { get; set; }
        public ScenarioEntity<IScenery> bloom_quad { get; set; }
        public ScenarioEntity<IScenery> e12_speaker5 { get; set; }
        public ScenarioEntity<IScenery> e12_speaker6 { get; set; }
        public ScenarioEntity<IScenery> e12_speaker7 { get; set; }
        public ScenarioEntity<IScenery> e12_speaker8 { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> mercy { get; set; }
        public ScenarioEntity<IUnit> cortana { get; set; }
        public ScenarioEntity<IUnit> infection_01 { get; set; }
        public ScenarioEntity<IUnit> e10_dead_body { get; set; }
        public ScenarioEntity<IUnit> chief_outro { get; set; }
        public ScenarioEntity<IUnit> cortana_outro { get; set; }
        public ScenarioEntity<IUnit> e1_mercy1 { get; set; }
        public ScenarioEntity<IUnit> infection_02 { get; set; }
        public ScenarioEntity<IVehicle> throne_mercy { get; set; }
        public ScenarioEntity<IVehicle> phantom_03 { get; set; }
        public ScenarioEntity<IVehicle> phantom_01 { get; set; }
        public ScenarioEntity<IVehicle> phantom_02 { get; set; }
        public ScenarioEntity<IVehicle> pelican_01 { get; set; }
        public ScenarioEntity<IWeapon> key { get; set; }
        public ScenarioEntity<IDevice> sanctum_lift_old { get; set; }
        public ScenarioEntity<IDevice> lift_a_control { get; set; }
        public ScenarioEntity<IDevice> lift_b_control { get; set; }
        public ScenarioEntity<IDevice> lift_c { get; set; }
        public ScenarioEntity<IDevice> lift_c_control { get; set; }
        public ScenarioEntity<IDevice> lift_d { get; set; }
        public ScenarioEntity<IDevice> lift_d_control { get; set; }
        public ScenarioEntity<IDevice> maus_platform_d { get; set; }
        public ScenarioEntity<IDevice> maus_platform_c { get; set; }
        public ScenarioEntity<IDevice> maus_platform_a { get; set; }
        public ScenarioEntity<IDevice> maus_platform_b { get; set; }
        public ScenarioEntity<IDevice> gravity_bridge_a1 { get; set; }
        public ScenarioEntity<IDevice> e6_cave_door1 { get; set; }
        public ScenarioEntity<IDevice> gravity_bridge_b1 { get; set; }
        public ScenarioEntity<IDevice> gravity_bridge_a2 { get; set; }
        public ScenarioEntity<IDevice> gravity_bridge_c1 { get; set; }
        public ScenarioEntity<IDevice> e6_cave_door2 { get; set; }
        public ScenarioEntity<IDevice> e8_cave_door2 { get; set; }
        public ScenarioEntity<IDevice> e10_high_sanctum_door { get; set; }
        public ScenarioEntity<IDevice> tube2_stopped { get; set; }
        public ScenarioEntity<IDevice> e10_sanctum_door { get; set; }
        public ScenarioEntity<IDevice> sanctum_lift { get; set; }
        public ScenarioEntity<IDevice> e10_stuck_door { get; set; }
        public ScenarioEntity<IDevice> e5_plasma_door { get; set; }
        public ScenarioEntity<IDevice> e10_tube_door { get; set; }
        public ScenarioEntity<IDevice> sanctum_lift_control { get; set; }
        public ScenarioEntity<IDevice> lift_effect_a { get; set; }
        public ScenarioEntity<IDevice> lift_effect_b { get; set; }
        public IAiActorDefinition all_enemies => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition prophets => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition flood => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition e1_prophets_master => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition e1_prophets_ledge => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition e1_flood_master => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition e1_flood_group_1 => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition e1_flood_group_2 => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition e5_buggers => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition e5_flood_master => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition e6_flood_group_1 => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition e6_flood_group_2 => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition e6_flood_group_3 => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition e6_flood_infection_forms => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition e6_flood_master => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition e6_flood_storm => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition e6_flood_group_total => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition e6_pro_hall_grp_master => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition e6_pro_hall_grp_1 => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition e6_pro_hall_grp_2 => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition e6_pro_cave1 => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition e9_flood_master => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition e10_flood_master => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition e10_prophets_master => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition e12_flood_tube1 => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition e12_flood_tube_master => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition e12_flood_rush => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition e12_flood_fight => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition e13_prophets_master => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition e10_pro_inner_sanctum => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition e10_flood_storm => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition e12_pro_group3 => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition e12_prophets_master => Scenario.AiSquadGroupDefinitions[32];
        public IAiOrders e1_pro_inf1_hold => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders e1_pro_inf2_retreat => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders e1_pro_inf2_counterattack => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders e1_pro_inf3_hold => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders e1_pro_inf4_hold => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders e1_fld_inf4_z_attk => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders e1_fld_inf1_secure => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders e1_fld_inf1_clear => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders e1_fld_swarm1_clear => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders e1_fld_inf2_clear => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders e1_fld_inf3_clear => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders e1_fld_inf1_enter => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders e1_fld_inf2_attack => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders e1_fld_inf2_enter => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders e1_fld_inf3_enter => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders e1_fld_inf4_enter => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders e1_fld_inf4_clear => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders e1_fld_inf5_hold => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders e1_fld_inf5_clear => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders e1_fld_gitem => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders e2_pro_inf1_hall_patrol => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders e3_pro_inf1_hold => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders e3_pro_inf2_march => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders e3_pro_inf2_fallback => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders e5_bugger_test => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders e5_bugger_plat_b => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders e5_pro_bug2_c_attk => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders e5_bugger_plat_d => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders e5_pro_inf1 => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders e5_pro_inf1_leave => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders e5_pro_inf2_sniper => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders e5_pro_bug1_assault => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders e5_pro_bug1_attk_player => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders e5_fld_inf1_charge => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders e5_fld_inf2_attk => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders e5_fld_inf2_z_attk => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders e6_fld_inf1_hold => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders e6_fld_inf2_attack => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders e6_pro_inf2_hold => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders e6_pro_inf1_hold => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders e6_pro_inf3_hold => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders e6_pro_inf3_retreat => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders e6_fld_inf1_a_attk => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders e6_fld_inf2_lure => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders e6_fld_inf5_attk => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders e6_fld_storm => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders e6_flood_final => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders e8_fld_inf1_hunt => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders e6_fld_go_go_go => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders e6_fld_stop_stop => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders e8_pro_inf1_enter => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders e8_pro_inf1_hold => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders e8_fld_inf1_held => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders e8_fld_inf1_z => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders e8_pro_inf1_sweep => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders e9_fld_inf1 => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders e9_fld_storm => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders e10_pro_inf1_hold => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders e10_fld_storm => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders e10_fld_storm_z => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders e10_fld_inf1_fallback => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders e12_pro_inf1_grunt_hold => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders e12_pro_inf1_grunt_retreat => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders e12_pro_inf2_right => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders e12_pro_inf2_fallback => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders e12_pro_inf3_hold => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders e12_pro_inf4_left => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders e12_fld_bot_frnt => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders e12_fld_bot_back => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders e12_fld_inf3_left_attk => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders e12_fld_inf3_right_attk => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders e12_fld_l_mid => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders e12_fld_r_mid => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders e12_get_the_player => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders e10_cov_inf1 => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders e12_pro_inf4_right => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders e12_pro_inf2_left => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders e12_cs_banshee1 => Scenario.AiOrderDefinitions[77].GameObject;
        public ILocationFlag anchor_flag_intra1 => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag e9_smasher1 => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag e9_smasher2 => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag e9_smasher3 => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag e9_smasher4 => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag e9_smasher5 => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag e9_smasher6 => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag e9_smasher7 => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag bsp_0_1_source => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag bsp_0_1_offset => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag bsp_3_4_source => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag bsp_3_4_offset => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag bsp_4_5_offset => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag bsp_5_4_offset => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag bsp_2_4_source => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag bsp_2_4_offset => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag anchor_flag_outro1 => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag anchor_flag_outro2 => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag player0_end => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag player1_end => Scenario.LocationFlagDefinitions[21];
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_2 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title_3 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ICinematicTitle title_4 => Scenario.CinematicTitleDefinitions[3].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume bsp_1_2 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_2_1 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume bsp_2_4 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume tv_e1_trigger2 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume tv_e1_trigger4 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume tv_e1_trigger5 => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume tv_e1_gitem1 => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume tv_e1_gitem2 => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume kill_trigger => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume tv_e2_trigger1 => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume tv_e2_trigger2 => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume tv_e3_trigger1 => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_e3_trigger2 => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume tv_e5_platform_start => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_e5_platform_a1 => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_e5_platform_a2 => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_e5_platform_b1 => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_e5_platform_c1 => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume tv_e5_trigger1 => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume tv_e5_trigger2 => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume tv_e5_trigger3 => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume tv_e5_trigger9 => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume tv_e5_plat_b => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_e5_plat_c => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_e5_trigger_chase => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume kill_trigger1 => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_e6_trigger1 => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_e6_trigger3 => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume tv_e6_cave_check => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume tv_e6_infinite1 => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume tv_e6_infinite2 => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_e6_infinite3 => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_e6_ambusher => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume tv_e6_trigger6_chase => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume tv_e6_final_start => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_e7_trigger1 => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_e7_trigger2 => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_e8_trigger2_a => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_e8_trigger2_b => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_e8_cave_check => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_e8_end => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume kill_trigger2 => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_e9_trigger1 => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume tv_e9_trigger2 => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_e9_hall_check => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_e9_end => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_e10_hide => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume tv_e10_trigger1 => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume tv_e10_trigger2 => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume tv_e10_trigger5 => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume tv_e10_trigger6 => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume tv_e10_trigger9 => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume tv_e10_hall_check => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume tv_e12_trigger1 => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume tv_e12_end => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume tv_e12_safety_r => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume tv_e12_safety_l => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume tv_e12_conduit_check => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume tv_e12_trigger9 => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume kill_trigger3 => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume kill_trigger21 => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume kill_trigger31 => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume kill_trigger4 => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume tv_e10_screen => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume tv_e12_tickle => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume tv_e6_talkbox => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume tv_e8_talkbox => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume tv_e6_waitforit => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume tv_e9_surprise => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume tv_e1_ledge_check => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume tv_sanctum_lift => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume kill_sanctum_crusher => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume tv_e12_final_dialogue => Scenario.TriggerVolumes[73].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile coop_respawn => Scenario.StartingProfileDefinitions[1].GameObject;
        public IDeviceGroup lift_a => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup lift_b => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup lift_c1 => Scenario.DeviceGroupDefinitions[2].GameObject;
        public IDeviceGroup lift_d1 => Scenario.DeviceGroupDefinitions[3].GameObject;
        public IDeviceGroup maus_platform_a1 => Scenario.DeviceGroupDefinitions[4].GameObject;
        public IDeviceGroup sanctum_lift1 => Scenario.DeviceGroupDefinitions[5].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            anchor_intra1 = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            e6_howler1 = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            e6_howler2 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            e9_howler1 = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            e6_howler_spec2 = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            e6_howler_spec1 = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            e12_howler1 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            e6_howler4 = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            e6_howler_spec3 = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            e6_howler_spec4 = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            e10_howler1 = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            e10_howler2 = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            e10_howler3 = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            e10_howler4 = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            e12_howler2 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            e1_broadcast1 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            e1_broadcast2 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            e1_broadcast3 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            e1_broadcast4 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            e1_broadcast5 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            e1_broadcast6 = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            e10_broadcast1 = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            e10_broadcast2 = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            e10_broadcast3 = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            e10_broadcast5 = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            e10_broadcast6 = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            e6_broadcast1 = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            e8_broadcast1 = new ScenarioEntity<IScenery>(27, scenarioTag.WellKnownItems[27]);
            e8_howler1 = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            e8_howler3 = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            ledge_1 = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            ledge_2 = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            ledge_3 = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            ledge_4 = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            ledge_5 = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            ledge_6 = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            ledge_7 = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            ledge_8 = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            ledge_9 = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            ledge_10 = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            ledge_11 = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            ledge_99 = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            ledge_98 = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            ledge_97 = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            e12_right_a = new ScenarioEntity<IBloc>(44, scenarioTag.WellKnownItems[44]);
            e12_left_d = new ScenarioEntity<IBloc>(45, scenarioTag.WellKnownItems[45]);
            e12_right_d = new ScenarioEntity<IBloc>(46, scenarioTag.WellKnownItems[46]);
            e12_right_q = new ScenarioEntity<IBloc>(47, scenarioTag.WellKnownItems[47]);
            e12_right_f = new ScenarioEntity<IBloc>(48, scenarioTag.WellKnownItems[48]);
            e12_left_h = new ScenarioEntity<IBloc>(49, scenarioTag.WellKnownItems[49]);
            e12_right_j = new ScenarioEntity<IBloc>(50, scenarioTag.WellKnownItems[50]);
            e12_left_i = new ScenarioEntity<IBloc>(51, scenarioTag.WellKnownItems[51]);
            e12_left_j = new ScenarioEntity<IBloc>(52, scenarioTag.WellKnownItems[52]);
            e12_left_m = new ScenarioEntity<IBloc>(53, scenarioTag.WellKnownItems[53]);
            e12_right_m = new ScenarioEntity<IBloc>(54, scenarioTag.WellKnownItems[54]);
            anchor_outro1 = new ScenarioEntity<IScenery>(55, scenarioTag.WellKnownItems[55]);
            anchor_outro2 = new ScenarioEntity<IScenery>(56, scenarioTag.WellKnownItems[56]);
            cap = new ScenarioEntity<IScenery>(57, scenarioTag.WellKnownItems[57]);
            ring_01 = new ScenarioEntity<IScenery>(58, scenarioTag.WellKnownItems[58]);
            ring_02 = new ScenarioEntity<IScenery>(59, scenarioTag.WellKnownItems[59]);
            ring_03 = new ScenarioEntity<IScenery>(60, scenarioTag.WellKnownItems[60]);
            ring_04 = new ScenarioEntity<IScenery>(61, scenarioTag.WellKnownItems[61]);
            ring_05 = new ScenarioEntity<IScenery>(62, scenarioTag.WellKnownItems[62]);
            ring_06 = new ScenarioEntity<IScenery>(63, scenarioTag.WellKnownItems[63]);
            ring_07 = new ScenarioEntity<IScenery>(64, scenarioTag.WellKnownItems[64]);
            ring_08 = new ScenarioEntity<IScenery>(65, scenarioTag.WellKnownItems[65]);
            forerunner_ship = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            alcove = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            matte_high_charity = new ScenarioEntity<IScenery>(68, scenarioTag.WellKnownItems[68]);
            matte_substance = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            conduit = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            takeoff_dust = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            cortana_base = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            slipspace = new ScenarioEntity<IScenery>(73, scenarioTag.WellKnownItems[73]);
            e5_speaker0 = new ScenarioEntity<IScenery>(74, scenarioTag.WellKnownItems[74]);
            e5_speaker1 = new ScenarioEntity<IScenery>(75, scenarioTag.WellKnownItems[75]);
            e5_speaker2 = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            e5_speaker3 = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            e5_speaker4 = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            e8_speaker0 = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            e8_speaker1 = new ScenarioEntity<IScenery>(80, scenarioTag.WellKnownItems[80]);
            e8_speaker2 = new ScenarioEntity<IScenery>(81, scenarioTag.WellKnownItems[81]);
            e8_speaker3 = new ScenarioEntity<IScenery>(82, scenarioTag.WellKnownItems[82]);
            e8_speaker4 = new ScenarioEntity<IScenery>(83, scenarioTag.WellKnownItems[83]);
            e8_speaker5 = new ScenarioEntity<IScenery>(84, scenarioTag.WellKnownItems[84]);
            e8_speaker_gm0 = new ScenarioEntity<IScenery>(85, scenarioTag.WellKnownItems[85]);
            e8_speaker_gm1 = new ScenarioEntity<IScenery>(86, scenarioTag.WellKnownItems[86]);
            e8_speaker_gm2 = new ScenarioEntity<IScenery>(87, scenarioTag.WellKnownItems[87]);
            e8_speaker_gm3 = new ScenarioEntity<IScenery>(88, scenarioTag.WellKnownItems[88]);
            e8_speaker_gm4 = new ScenarioEntity<IScenery>(89, scenarioTag.WellKnownItems[89]);
            e8_speaker_gm5 = new ScenarioEntity<IScenery>(90, scenarioTag.WellKnownItems[90]);
            e12_speaker0 = new ScenarioEntity<IScenery>(91, scenarioTag.WellKnownItems[91]);
            e12_speaker1 = new ScenarioEntity<IScenery>(92, scenarioTag.WellKnownItems[92]);
            e12_speaker2 = new ScenarioEntity<IScenery>(93, scenarioTag.WellKnownItems[93]);
            e12_speaker3 = new ScenarioEntity<IScenery>(94, scenarioTag.WellKnownItems[94]);
            e12_speaker4 = new ScenarioEntity<IScenery>(95, scenarioTag.WellKnownItems[95]);
            e10_speaker0 = new ScenarioEntity<IScenery>(96, scenarioTag.WellKnownItems[96]);
            e10_speaker1 = new ScenarioEntity<IScenery>(97, scenarioTag.WellKnownItems[97]);
            e10_speaker2 = new ScenarioEntity<IScenery>(98, scenarioTag.WellKnownItems[98]);
            e10_speaker3 = new ScenarioEntity<IScenery>(99, scenarioTag.WellKnownItems[99]);
            e10_speaker4 = new ScenarioEntity<IScenery>(100, scenarioTag.WellKnownItems[100]);
            e10_speaker5 = new ScenarioEntity<IScenery>(101, scenarioTag.WellKnownItems[101]);
            e6_speaker0 = new ScenarioEntity<IScenery>(102, scenarioTag.WellKnownItems[102]);
            e6_speaker1 = new ScenarioEntity<IScenery>(103, scenarioTag.WellKnownItems[103]);
            e6_speaker2 = new ScenarioEntity<IScenery>(104, scenarioTag.WellKnownItems[104]);
            e6_speaker3 = new ScenarioEntity<IScenery>(105, scenarioTag.WellKnownItems[105]);
            e6_speaker4 = new ScenarioEntity<IScenery>(106, scenarioTag.WellKnownItems[106]);
            e6_speaker5 = new ScenarioEntity<IScenery>(107, scenarioTag.WellKnownItems[107]);
            e6_speaker_gm0 = new ScenarioEntity<IScenery>(108, scenarioTag.WellKnownItems[108]);
            e6_speaker_gm1 = new ScenarioEntity<IScenery>(109, scenarioTag.WellKnownItems[109]);
            e5_speaker5 = new ScenarioEntity<IScenery>(110, scenarioTag.WellKnownItems[110]);
            end_ped_a = new ScenarioEntity<IScenery>(111, scenarioTag.WellKnownItems[111]);
            end_ped_b = new ScenarioEntity<IScenery>(112, scenarioTag.WellKnownItems[112]);
            offending_crate_01 = new ScenarioEntity<IScenery>(113, scenarioTag.WellKnownItems[113]);
            offending_crate_02 = new ScenarioEntity<IScenery>(114, scenarioTag.WellKnownItems[114]);
            outro_fleet_01 = new ScenarioEntity<IScenery>(115, scenarioTag.WellKnownItems[115]);
            outro_fleet_02 = new ScenarioEntity<IScenery>(116, scenarioTag.WellKnownItems[116]);
            bloom_quad = new ScenarioEntity<IScenery>(117, scenarioTag.WellKnownItems[117]);
            e12_speaker5 = new ScenarioEntity<IScenery>(118, scenarioTag.WellKnownItems[118]);
            e12_speaker6 = new ScenarioEntity<IScenery>(119, scenarioTag.WellKnownItems[119]);
            e12_speaker7 = new ScenarioEntity<IScenery>(120, scenarioTag.WellKnownItems[120]);
            e12_speaker8 = new ScenarioEntity<IScenery>(121, scenarioTag.WellKnownItems[121]);
            chief = new ScenarioEntity<IUnit>(122, scenarioTag.WellKnownItems[122]);
            mercy = new ScenarioEntity<IUnit>(123, scenarioTag.WellKnownItems[123]);
            cortana = new ScenarioEntity<IUnit>(124, scenarioTag.WellKnownItems[124]);
            infection_01 = new ScenarioEntity<IUnit>(125, scenarioTag.WellKnownItems[125]);
            e10_dead_body = new ScenarioEntity<IUnit>(126, scenarioTag.WellKnownItems[126]);
            chief_outro = new ScenarioEntity<IUnit>(127, scenarioTag.WellKnownItems[127]);
            cortana_outro = new ScenarioEntity<IUnit>(128, scenarioTag.WellKnownItems[128]);
            e1_mercy1 = new ScenarioEntity<IUnit>(129, scenarioTag.WellKnownItems[129]);
            infection_02 = new ScenarioEntity<IUnit>(130, scenarioTag.WellKnownItems[130]);
            throne_mercy = new ScenarioEntity<IVehicle>(131, scenarioTag.WellKnownItems[131]);
            phantom_03 = new ScenarioEntity<IVehicle>(132, scenarioTag.WellKnownItems[132]);
            phantom_01 = new ScenarioEntity<IVehicle>(133, scenarioTag.WellKnownItems[133]);
            phantom_02 = new ScenarioEntity<IVehicle>(134, scenarioTag.WellKnownItems[134]);
            pelican_01 = new ScenarioEntity<IVehicle>(135, scenarioTag.WellKnownItems[135]);
            key = new ScenarioEntity<IWeapon>(136, scenarioTag.WellKnownItems[136]);
            sanctum_lift_old = new ScenarioEntity<IDevice>(137, scenarioTag.WellKnownItems[137]);
            lift_a_control = new ScenarioEntity<IDevice>(138, scenarioTag.WellKnownItems[138]);
            lift_b_control = new ScenarioEntity<IDevice>(139, scenarioTag.WellKnownItems[139]);
            lift_c = new ScenarioEntity<IDevice>(140, scenarioTag.WellKnownItems[140]);
            lift_c_control = new ScenarioEntity<IDevice>(141, scenarioTag.WellKnownItems[141]);
            lift_d = new ScenarioEntity<IDevice>(142, scenarioTag.WellKnownItems[142]);
            lift_d_control = new ScenarioEntity<IDevice>(143, scenarioTag.WellKnownItems[143]);
            maus_platform_d = new ScenarioEntity<IDevice>(144, scenarioTag.WellKnownItems[144]);
            maus_platform_c = new ScenarioEntity<IDevice>(145, scenarioTag.WellKnownItems[145]);
            maus_platform_a = new ScenarioEntity<IDevice>(146, scenarioTag.WellKnownItems[146]);
            maus_platform_b = new ScenarioEntity<IDevice>(147, scenarioTag.WellKnownItems[147]);
            gravity_bridge_a1 = new ScenarioEntity<IDevice>(148, scenarioTag.WellKnownItems[148]);
            e6_cave_door1 = new ScenarioEntity<IDevice>(149, scenarioTag.WellKnownItems[149]);
            gravity_bridge_b1 = new ScenarioEntity<IDevice>(150, scenarioTag.WellKnownItems[150]);
            gravity_bridge_a2 = new ScenarioEntity<IDevice>(151, scenarioTag.WellKnownItems[151]);
            gravity_bridge_c1 = new ScenarioEntity<IDevice>(152, scenarioTag.WellKnownItems[152]);
            e6_cave_door2 = new ScenarioEntity<IDevice>(153, scenarioTag.WellKnownItems[153]);
            e8_cave_door2 = new ScenarioEntity<IDevice>(154, scenarioTag.WellKnownItems[154]);
            e10_high_sanctum_door = new ScenarioEntity<IDevice>(155, scenarioTag.WellKnownItems[155]);
            tube2_stopped = new ScenarioEntity<IDevice>(156, scenarioTag.WellKnownItems[156]);
            e10_sanctum_door = new ScenarioEntity<IDevice>(157, scenarioTag.WellKnownItems[157]);
            sanctum_lift = new ScenarioEntity<IDevice>(158, scenarioTag.WellKnownItems[158]);
            e10_stuck_door = new ScenarioEntity<IDevice>(159, scenarioTag.WellKnownItems[159]);
            e5_plasma_door = new ScenarioEntity<IDevice>(160, scenarioTag.WellKnownItems[160]);
            e10_tube_door = new ScenarioEntity<IDevice>(161, scenarioTag.WellKnownItems[161]);
            sanctum_lift_control = new ScenarioEntity<IDevice>(162, scenarioTag.WellKnownItems[162]);
            lift_effect_a = new ScenarioEntity<IDevice>(163, scenarioTag.WellKnownItems[163]);
            lift_effect_b = new ScenarioEntity<IDevice>(164, scenarioTag.WellKnownItems[164]);
            e1_pro_inf1 = new Squad_e1_pro_inf1(scenarioTag);
            e1_pro_inf2 = new Squad_e1_pro_inf2(scenarioTag);
            e1_pro_inf3 = new Squad_e1_pro_inf3(scenarioTag);
            e1_fld_inf1 = new Squad_e1_fld_inf1(scenarioTag);
            e1_fld_inf2 = new Squad_e1_fld_inf2(scenarioTag);
            e1_fld_inf3 = new Squad_e1_fld_inf3(scenarioTag);
            e1_fld_inf4 = new Squad_e1_fld_inf4(scenarioTag);
            e1_fld_inf4_z = new Squad_e1_fld_inf4_z(scenarioTag);
            e1_fld_inf5 = new Squad_e1_fld_inf5(scenarioTag);
            e1_fld_gitem1 = new Squad_e1_fld_gitem1(scenarioTag);
            e1_fld_gitem2 = new Squad_e1_fld_gitem2(scenarioTag);
            e1_CS_pelican1 = new Squad_e1_CS_pelican1(scenarioTag);
            e1_CS_pelican2 = new Squad_e1_CS_pelican2(scenarioTag);
            e2_pro_inf1 = new Squad_e2_pro_inf1(scenarioTag);
            e3_pro_inf1 = new Squad_e3_pro_inf1(scenarioTag);
            e3_pro_inf1_a = new Squad_e3_pro_inf1_a(scenarioTag);
            e3_pro_inf2 = new Squad_e3_pro_inf2(scenarioTag);
            e5_pro_inf11 = new Squad_e5_pro_inf11(scenarioTag);
            e5_pro_inf2 = new Squad_e5_pro_inf2(scenarioTag);
            e5_pro_bug1 = new Squad_e5_pro_bug1(scenarioTag);
            e5_pro_bug2_b = new Squad_e5_pro_bug2_b(scenarioTag);
            e5_pro_bug2_c = new Squad_e5_pro_bug2_c(scenarioTag);
            e5_fld_inf1 = new Squad_e5_fld_inf1(scenarioTag);
            e5_fld_inf2 = new Squad_e5_fld_inf2(scenarioTag);
            e5_fld_inf2_z = new Squad_e5_fld_inf2_z(scenarioTag);
            e6_pro_inf2 = new Squad_e6_pro_inf2(scenarioTag);
            e6_pro_inf2_a = new Squad_e6_pro_inf2_a(scenarioTag);
            e6_pro_inf3 = new Squad_e6_pro_inf3(scenarioTag);
            e6_pro_inf3_a = new Squad_e6_pro_inf3_a(scenarioTag);
            e6_fld_inf1 = new Squad_e6_fld_inf1(scenarioTag);
            e6_fld_inf1_a = new Squad_e6_fld_inf1_a(scenarioTag);
            e6_fld_inf2_z = new Squad_e6_fld_inf2_z(scenarioTag);
            e6_fld_inf2_a = new Squad_e6_fld_inf2_a(scenarioTag);
            e6_fld_inf2_b = new Squad_e6_fld_inf2_b(scenarioTag);
            e6_fld_inf2_c = new Squad_e6_fld_inf2_c(scenarioTag);
            e6_fld_inf2_d = new Squad_e6_fld_inf2_d(scenarioTag);
            e6_fld_inf3 = new Squad_e6_fld_inf3(scenarioTag);
            e6_fld_inf4 = new Squad_e6_fld_inf4(scenarioTag);
            e6_fld_inf5 = new Squad_e6_fld_inf5(scenarioTag);
            e6_fld_swarm3 = new Squad_e6_fld_swarm3(scenarioTag);
            e8_pro_inf1 = new Squad_e8_pro_inf1(scenarioTag);
            e8_fld_inf1 = new Squad_e8_fld_inf1(scenarioTag);
            e8_fld_swarm1 = new Squad_e8_fld_swarm1(scenarioTag);
            e9_fld_swarm1 = new Squad_e9_fld_swarm1(scenarioTag);
            e9_fld_swarm2 = new Squad_e9_fld_swarm2(scenarioTag);
            e9_fld_inf11 = new Squad_e9_fld_inf11(scenarioTag);
            e9_fld_inf2 = new Squad_e9_fld_inf2(scenarioTag);
            e9_fld_inf3_a = new Squad_e9_fld_inf3_a(scenarioTag);
            e9_fld_inf3_b = new Squad_e9_fld_inf3_b(scenarioTag);
            e9_fld_inf3_c = new Squad_e9_fld_inf3_c(scenarioTag);
            e9_fld_inf3_d = new Squad_e9_fld_inf3_d(scenarioTag);
            e9_fld_inf3_e = new Squad_e9_fld_inf3_e(scenarioTag);
            e9_fld_inf3_f = new Squad_e9_fld_inf3_f(scenarioTag);
            e10_pro_inf1 = new Squad_e10_pro_inf1(scenarioTag);
            e10_pro_inf1_a = new Squad_e10_pro_inf1_a(scenarioTag);
            e10_fld_inf1 = new Squad_e10_fld_inf1(scenarioTag);
            e10_cov_inf11 = new Squad_e10_cov_inf11(scenarioTag);
            e10_fld_swarm1 = new Squad_e10_fld_swarm1(scenarioTag);
            e11_pro_inf1 = new Squad_e11_pro_inf1(scenarioTag);
            e11_fld_inf1 = new Squad_e11_fld_inf1(scenarioTag);
            e12_cov_inf1 = new Squad_e12_cov_inf1(scenarioTag);
            e12_pro_inf2_left1 = new Squad_e12_pro_inf2_left1(scenarioTag);
            e12_pro_inf2_right1 = new Squad_e12_pro_inf2_right1(scenarioTag);
            e12_pro_inf3_end = new Squad_e12_pro_inf3_end(scenarioTag);
            e12_pro_inf4_right1 = new Squad_e12_pro_inf4_right1(scenarioTag);
            e12_pro_inf4_left1 = new Squad_e12_pro_inf4_left1(scenarioTag);
            e12_fld_inf3_right = new Squad_e12_fld_inf3_right(scenarioTag);
            e12_fld_inf2_right = new Squad_e12_fld_inf2_right(scenarioTag);
            e12_fld_inf1_right = new Squad_e12_fld_inf1_right(scenarioTag);
            e12_fld_inf3_left = new Squad_e12_fld_inf3_left(scenarioTag);
            e12_fld_inf2_left = new Squad_e12_fld_inf2_left(scenarioTag);
            e12_fld_inf1_left = new Squad_e12_fld_inf1_left(scenarioTag);
            e12_fld_inf4 = new Squad_e12_fld_inf4(scenarioTag);
            e12_CS_pelican1 = new Squad_e12_CS_pelican1(scenarioTag);
            e12_CS_banshee1 = new Squad_e12_CS_banshee1(scenarioTag);
            cinematic_fld_inf0 = new Squad_cinematic_fld_inf0(scenarioTag);
            cinematic_fld_inf1 = new Squad_cinematic_fld_inf1(scenarioTag);
            cortana1 = new Squad_cortana1(scenarioTag);
        }
    }
}