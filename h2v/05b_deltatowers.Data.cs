namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_05b_deltatowers : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> anchor_outro { get; set; }
        public ScenarioEntity<IScenery> carrier { get; set; }
        public ScenarioEntity<IScenery> index { get; set; }
        public ScenarioEntity<IScenery> anchor_intra1a { get; set; }
        public ScenarioEntity<IScenery> iac_bridge { get; set; }
        public ScenarioEntity<IScenery> in_game_throne { get; set; }
        public ScenarioEntity<IScenery> in_game_prophet { get; set; }
        public ScenarioEntity<IScenery> big_head { get; set; }
        public ScenarioEntity<IScenery> island_throne { get; set; }
        public ScenarioEntity<IScenery> island_int_prophet { get; set; }
        public ScenarioEntity<IScenery> tentacle_capture_02 { get; set; }
        public ScenarioEntity<IScenery> tentacle_capture_01 { get; set; }
        public ScenarioEntity<IScenery> anchor_intra1b { get; set; }
        public ScenarioEntity<IScenery> water_1to2a { get; set; }
        public ScenarioEntity<IScenery> rack { get; set; }
        public ScenarioEntity<IBloc> bomb01 { get; set; }
        public ScenarioEntity<IBloc> bomb02 { get; set; }
        public ScenarioEntity<IBloc> bomb03 { get; set; }
        public ScenarioEntity<IBloc> bomb04 { get; set; }
        public ScenarioEntity<IBloc> bomb05 { get; set; }
        public ScenarioEntity<IBloc> bomb06 { get; set; }
        public ScenarioEntity<IScenery> rack2 { get; set; }
        public ScenarioEntity<IBloc> bomb07 { get; set; }
        public ScenarioEntity<IBloc> bomb08 { get; set; }
        public ScenarioEntity<IBloc> bomb09 { get; set; }
        public ScenarioEntity<IBloc> bomb10 { get; set; }
        public ScenarioEntity<IBloc> bomb12 { get; set; }
        public ScenarioEntity<IBloc> bomb11 { get; set; }
        public ScenarioEntity<IScenery> sunken_throne { get; set; }
        public ScenarioEntity<IScenery> holo_index { get; set; }
        public ScenarioEntity<IScenery> holo_library { get; set; }
        public ScenarioEntity<IScenery> texture_camera { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_01 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_02 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_05 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_06 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_07 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_08 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_09 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_10 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_11 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_12 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_13 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_14 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_15 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_16 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_17 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_18 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_19 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_20 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_21 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_22 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_23 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_24 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_25 { get; set; }
        public ScenarioEntity<IBloc> tower_cluster_26 { get; set; }
        public ScenarioEntity<IScenery> water_1to2b { get; set; }
        public ScenarioEntity<IScenery> water_2to3b { get; set; }
        public ScenarioEntity<IScenery> water_2to3a { get; set; }
        public ScenarioEntity<IScenery> fleet01 { get; set; }
        public ScenarioEntity<IScenery> fleet02 { get; set; }
        public ScenarioEntity<IScenery> fleet_high_char { get; set; }
        public ScenarioEntity<IScenery> rubble { get; set; }
        public ScenarioEntity<IScenery> caustic_light_01 { get; set; }
        public ScenarioEntity<IScenery> bubbles_01 { get; set; }
        public ScenarioEntity<IScenery> bubbles_02 { get; set; }
        public ScenarioEntity<IScenery> intra2_fleet { get; set; }
        public ScenarioEntity<IScenery> cortana_base { get; set; }
        public ScenarioEntity<IScenery> matte_horizon { get; set; }
        public ScenarioEntity<IScenery> outro_beam { get; set; }
        public ScenarioEntity<IScenery> outro_dust_scrape { get; set; }
        public ScenarioEntity<IScenery> outro_dust_land { get; set; }
        public ScenarioEntity<IScenery> cinematic_battle_rifle { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> cortana { get; set; }
        public ScenarioEntity<IUnit> regret { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> pilot { get; set; }
        public ScenarioEntity<IUnit> regret01 { get; set; }
        public ScenarioEntity<IUnit> regret02 { get; set; }
        public ScenarioEntity<IUnit> regret03 { get; set; }
        public ScenarioEntity<IUnit> fake_corpse { get; set; }
        public ScenarioEntity<IUnit> johnson { get; set; }
        public ScenarioEntity<IVehicle> throne_regret { get; set; }
        public ScenarioEntity<IVehicle> pelican_01 { get; set; }
        public ScenarioEntity<IWeapon> assassins { get; set; }
        public ScenarioEntity<IDevice> gondola_01_a { get; set; }
        public ScenarioEntity<IDevice> gondola_02_a { get; set; }
        public ScenarioEntity<IDevice> elev_under { get; set; }
        public ScenarioEntity<IDevice> elev_up { get; set; }
        public ScenarioEntity<IDevice> elev_under_switch_01 { get; set; }
        public ScenarioEntity<IDevice> gondola_02_switch_front { get; set; }
        public ScenarioEntity<IDevice> gondola_01_switch_front { get; set; }
        public ScenarioEntity<IDevice> gondola_01_switch_back { get; set; }
        public ScenarioEntity<IDevice> gondola_02_switch_back { get; set; }
        public ScenarioEntity<IDevice> sunk_chamber_hunter_door { get; set; }
        public ScenarioEntity<IDevice> sunk_chmbr_spwn_r1a { get; set; }
        public ScenarioEntity<IDevice> sunk_chmbr_spwn_r1b { get; set; }
        public ScenarioEntity<IDevice> sunk_chmbr_spwn_r2b { get; set; }
        public ScenarioEntity<IDevice> sunk_chmbr_spwn_r2a { get; set; }
        public ScenarioEntity<IDevice> sunk_chmbr_spwn_l1a { get; set; }
        public ScenarioEntity<IDevice> sunk_chmbr_spwn_l1b { get; set; }
        public ScenarioEntity<IDevice> sunk_chmbr_spwn_l2b { get; set; }
        public ScenarioEntity<IDevice> sunk_chmbr_spwn_l2a { get; set; }
        public ScenarioEntity<IDevice> sunk_chamber_exit_r { get; set; }
        public ScenarioEntity<IDevice> sunk_chamber_exit_l { get; set; }
        public ScenarioEntity<IDevice> elev_up_switch_01 { get; set; }
        public ScenarioEntity<IDevice> gondola_01_b { get; set; }
        public ScenarioEntity<IDevice> gondola_01_launch_a { get; set; }
        public ScenarioEntity<IDevice> gondola_01_launch_b { get; set; }
        public ScenarioEntity<IDevice> gondola_02_b { get; set; }
        public ScenarioEntity<IDevice> gondola_02_launch_b { get; set; }
        public ScenarioEntity<IDevice> gondola_02_launch_a { get; set; }
        public ScenarioEntity<IDevice> temple_spawndoor_01l { get; set; }
        public ScenarioEntity<IDevice> temple_spawndoor_02l { get; set; }
        public ScenarioEntity<IDevice> temple_spawndoor_01r { get; set; }
        public ScenarioEntity<IDevice> temple_spawndoor_02r { get; set; }
        public ScenarioEntity<IDevice> temple_retreat_exit { get; set; }
        public ScenarioEntity<IDevice> door_main { get; set; }
        public ScenarioEntity<IDevice> gondola_02_b_fake { get; set; }
        public IAiActorDefinition all_allies => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition allies_infantry => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition all_enemies => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition tower_cluster_enemies => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition tower1_enemies => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition bridge_enemies => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition tower2_enemies => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition central_platform_enemies => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition gondola_01_enemies => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition tower3_enemies => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition tower3_main => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition tunnel_01_enemies => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition sunken_chamber_enemies => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition sunk_chamber_right_enemies => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition sunk_chamber_left_enemies => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition sunken_rightside_nonsnipers => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition sunken_leftside_nonsnipers => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition sunken_bugs => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition sunken_hg_left => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition sunken_hg_right => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition sunken_leftside_snipers => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition sunken_rightside_snipers => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition sunken_jacks_left => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition sunken_jacks_right => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition tunnel_02_enemies => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition island_all_enemies => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition island_int_enemies => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition island_gully_enemies => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition island_main_enemies => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition gondola_02_enemies => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition temple_entry_enemies => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition temple_center_enemies => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition temple_hg => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition temple_honor_grunts => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition temple_rangers => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition temple_escape_enemies => Scenario.AiSquadGroupDefinitions[35];
        public IAiOrders tower1_allies => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders tower1_upper_allies => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders tower1_lower_front => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders tower1_stairs => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders tower1_upper_back => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders tower1_upper_right => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders tower1_upper_left => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders tower_cluster_ranged_01 => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders tower_cluster_ranged_02 => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders tower_cluster_ranged_03 => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders tower_cluster_ranged_04 => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders tower_cluster_ranged_05 => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders tower_cluster_ranged_06 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders tower_cluster_ranged_07 => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders tower1_ext_allies => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders tower1_ext_01 => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders tower1_ext_02 => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders tower1_ext_03 => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders bridge_allies => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders bridge_01 => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders bridge_02 => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders bridge_03 => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders bridge_04 => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders tower2_ext_allies_01 => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders tower2_ext_01 => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders tower2_ext_02 => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders tower2_ext_03 => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders tower2_allies => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders tower2_upper_01 => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders tower2_upper_02 => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders tower2_upper_03 => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders tower2_lower_perimeter => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders tower2_lower_center => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders tower2_ext_allies_02 => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders tower2_ext_04 => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders tower2_ext_05 => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders central_platform_aware_far => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders central_platform_aware_near => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders central_platform_allies => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders central_platform_center => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders central_platform_exit => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders airspace_central_platform => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders gondola_01_bug_board => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders gondola_01_landing_01 => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders gondola_01_landing_02 => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders gondola_01_landing_03 => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders gondola_01_bunker => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders gondola_01_allies => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders gondola_01_all => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders gondola_01_phantoms => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders gondola_01_ph_drop => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders gondola_01_roof => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders gondola_01_low_fore => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders gondola_01_low_aft => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders gondola_01_b1 => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders tower3_upstairs => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders tower3_gondola_dock => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders tower3_balcony => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders tower3_snipe_spots => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders tower3_balcony_retreat => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders tower3_dock_retreat => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders tower3_allies => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders tower3_on_elev => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders tower3_int_01 => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders tower3_int_02 => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders tower3_int_03 => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders tower3_int_04 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders tower3_int_elev_ridge => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders tower3_int_mid_deck => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders tower3_on_elev1 => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders tunnel_01_suppress => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders tunnel_01_allies => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders tunnel_01_patrol => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders tunnel_01_front_01 => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders tunnel_01_front_02 => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders tunnel_01_front_03 => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders tunnel_01_front_04 => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders sunken_chamber_allies => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders sunk_chamber_patrol_Ra => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders sunk_chamber_patrol_Rb => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders sunk_chamber_patrol_La => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders sunk_chamber_patrol_Lb => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders sunk_chamber_R_01 => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders sunk_chamber_R_02 => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders sunk_chamber_R_03 => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders sunk_chamber_R_04 => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders sunk_chamber_R_05 => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders sunk_chamber_L_01 => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders sunk_chamber_L_02 => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders sunk_chamber_L_03 => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders sunk_chamber_L_04 => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders sunk_chamber_L_05 => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders sunk_chamber_bugs_L_01 => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders sunk_chamber_bugs_L_02 => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders sunk_chamber_bugs_L_03 => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders sunk_chamber_bugs_L_04 => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders sunk_chamber_bugs_R_01 => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders sunk_chamber_bugs_R_02 => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders sunk_chamber_bugs_R_03 => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders sunk_chamber_bugs_R_04 => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders sunken_chamber_exit_01 => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders sunken_chamber_exit_02 => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders sunk_chamber_center => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders sunken_rightside_hide => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders sunken_leftside_hide => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders tunnel_02_suppress => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders tunnel_02_allies => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders tunnel_02_patrol => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders tunnel_02_front_01 => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders tunnel_02_front_02 => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders tunnel_02_front_03 => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders tunnel_02_all => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders tunnel_02_perch_01 => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders tunnel_02_perch_02 => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders tunnel_02_on_elev => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders island_int_allies => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders island_int_patrol => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders island_int_01 => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders island_int_02 => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders island_int_03 => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders island_int_04 => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders island_low_allies => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders island_gully_low => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders island_gully_ridge => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders island_gully_ramp => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders island_gully_high => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders island_gully_retreat => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders airspace_island => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders island_ext_allies => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders island_ext_patrol_01 => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders island_ext_patrol_02 => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders island_ext_patrol_03 => Scenario.AiOrderDefinitions[131].GameObject;
        public IAiOrders island_ext_patrol_04 => Scenario.AiOrderDefinitions[132].GameObject;
        public IAiOrders island_ext_01 => Scenario.AiOrderDefinitions[133].GameObject;
        public IAiOrders island_ext_02 => Scenario.AiOrderDefinitions[134].GameObject;
        public IAiOrders island_ext_03 => Scenario.AiOrderDefinitions[135].GameObject;
        public IAiOrders island_ext_04 => Scenario.AiOrderDefinitions[136].GameObject;
        public IAiOrders island_ext_05L => Scenario.AiOrderDefinitions[137].GameObject;
        public IAiOrders island_ext_05R => Scenario.AiOrderDefinitions[138].GameObject;
        public IAiOrders island_phantom_dummy => Scenario.AiOrderDefinitions[139].GameObject;
        public IAiOrders island_ext_06 => Scenario.AiOrderDefinitions[140].GameObject;
        public IAiOrders island_ext_07 => Scenario.AiOrderDefinitions[141].GameObject;
        public IAiOrders island_ext_08 => Scenario.AiOrderDefinitions[142].GameObject;
        public IAiOrders island_ext_09 => Scenario.AiOrderDefinitions[143].GameObject;
        public IAiOrders island_ext_10 => Scenario.AiOrderDefinitions[144].GameObject;
        public IAiOrders gondola_02_allies => Scenario.AiOrderDefinitions[145].GameObject;
        public IAiOrders gondola_02_all => Scenario.AiOrderDefinitions[146].GameObject;
        public IAiOrders gondola_02_roof => Scenario.AiOrderDefinitions[147].GameObject;
        public IAiOrders gondola_02_low_fore => Scenario.AiOrderDefinitions[148].GameObject;
        public IAiOrders gondola_02_low_aft => Scenario.AiOrderDefinitions[149].GameObject;
        public IAiOrders gondola_02_b_roof => Scenario.AiOrderDefinitions[150].GameObject;
        public IAiOrders gondola_02_b_low => Scenario.AiOrderDefinitions[151].GameObject;
        public IAiOrders gondola_02_jets => Scenario.AiOrderDefinitions[152].GameObject;
        public IAiOrders gondola_02_banshees => Scenario.AiOrderDefinitions[153].GameObject;
        public IAiOrders temple_ent_allies => Scenario.AiOrderDefinitions[154].GameObject;
        public IAiOrders temple_ent_01 => Scenario.AiOrderDefinitions[155].GameObject;
        public IAiOrders temple_ent_02 => Scenario.AiOrderDefinitions[156].GameObject;
        public IAiOrders temple_ent_03 => Scenario.AiOrderDefinitions[157].GameObject;
        public IAiOrders temple_ent_04L => Scenario.AiOrderDefinitions[158].GameObject;
        public IAiOrders temple_ent_04R => Scenario.AiOrderDefinitions[159].GameObject;
        public IAiOrders temple_ent_05 => Scenario.AiOrderDefinitions[160].GameObject;
        public IAiOrders jetpacks_temple => Scenario.AiOrderDefinitions[161].GameObject;
        public IAiOrders temple_ent_retreat => Scenario.AiOrderDefinitions[162].GameObject;
        public IAiOrders temple_halls_allies => Scenario.AiOrderDefinitions[163].GameObject;
        public IAiOrders temple_left_allies => Scenario.AiOrderDefinitions[164].GameObject;
        public IAiOrders temple_right_allies => Scenario.AiOrderDefinitions[165].GameObject;
        public IAiOrders temple_left_01 => Scenario.AiOrderDefinitions[166].GameObject;
        public IAiOrders temple_left_02 => Scenario.AiOrderDefinitions[167].GameObject;
        public IAiOrders temple_left_03 => Scenario.AiOrderDefinitions[168].GameObject;
        public IAiOrders temple_left_04 => Scenario.AiOrderDefinitions[169].GameObject;
        public IAiOrders temple_right_01 => Scenario.AiOrderDefinitions[170].GameObject;
        public IAiOrders temple_right_02 => Scenario.AiOrderDefinitions[171].GameObject;
        public IAiOrders temple_right_03 => Scenario.AiOrderDefinitions[172].GameObject;
        public IAiOrders temple_right_04 => Scenario.AiOrderDefinitions[173].GameObject;
        public IAiOrders temple_left_01_ranger => Scenario.AiOrderDefinitions[174].GameObject;
        public IAiOrders temple_left_02_ranger => Scenario.AiOrderDefinitions[175].GameObject;
        public IAiOrders temple_left_03_ranger => Scenario.AiOrderDefinitions[176].GameObject;
        public IAiOrders temple_left_04_ranger => Scenario.AiOrderDefinitions[177].GameObject;
        public IAiOrders temple_right_01_ranger => Scenario.AiOrderDefinitions[178].GameObject;
        public IAiOrders temple_right_02_ranger => Scenario.AiOrderDefinitions[179].GameObject;
        public IAiOrders temple_right_03_ranger => Scenario.AiOrderDefinitions[180].GameObject;
        public IAiOrders temple_right_04_ranger => Scenario.AiOrderDefinitions[181].GameObject;
        public IAiOrders regret_01 => Scenario.AiOrderDefinitions[182].GameObject;
        public IAiOrders regret_02 => Scenario.AiOrderDefinitions[183].GameObject;
        public IAiOrders regret_03 => Scenario.AiOrderDefinitions[184].GameObject;
        public IAiOrders temple_retreat_allies => Scenario.AiOrderDefinitions[185].GameObject;
        public IAiOrders temple_exit_00 => Scenario.AiOrderDefinitions[186].GameObject;
        public IAiOrders temple_exit_01 => Scenario.AiOrderDefinitions[187].GameObject;
        public IAiOrders temple_exit_02 => Scenario.AiOrderDefinitions[188].GameObject;
        public IAiOrders temple_exit_03 => Scenario.AiOrderDefinitions[189].GameObject;
        public IAiOrders temple_exit_04 => Scenario.AiOrderDefinitions[190].GameObject;
        public IAiOrders temple_exit_hg_04 => Scenario.AiOrderDefinitions[191].GameObject;
        public IAiOrders running => Scenario.AiOrderDefinitions[192].GameObject;
        public IAiOrders temple_left_01_g => Scenario.AiOrderDefinitions[193].GameObject;
        public IAiOrders temple_left_02_g => Scenario.AiOrderDefinitions[194].GameObject;
        public IAiOrders temple_left_03_g => Scenario.AiOrderDefinitions[195].GameObject;
        public IAiOrders temple_left_04_g => Scenario.AiOrderDefinitions[196].GameObject;
        public IAiOrders temple_right_01_g => Scenario.AiOrderDefinitions[197].GameObject;
        public IAiOrders temple_right_02_g => Scenario.AiOrderDefinitions[198].GameObject;
        public IAiOrders temple_right_03_g => Scenario.AiOrderDefinitions[199].GameObject;
        public IAiOrders temple_right_04_g => Scenario.AiOrderDefinitions[200].GameObject;
        public IAiOrders everyone_retreat => Scenario.AiOrderDefinitions[201].GameObject;
        public ILocationFlag player0_hide_bsp3 => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag player1_hide_bsp3 => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag player0_hide_bsp1 => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag player1_hide_bsp1 => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag bridges_player0 => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag bridges_player1 => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag bridges_ally1 => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag bridges_ally2 => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag tower2_player0 => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag tower2_player1 => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag tower2_ally1 => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag tower2_ally2 => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag center_plat_player0 => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag center_plat_player1 => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag center_plat_ally1 => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag center_plat_ally2 => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag gondola_01_player0 => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag gondola_01_player1 => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag gondola_01_ally1 => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag gondola_01_ally2 => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag tower3_player0 => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag tower3_player1 => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag tower3_ally1 => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag tower3_ally2 => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag tunnel_01_player0 => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag tunnel_01_player1 => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag tunnel_01_ally1 => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag tunnel_01_ally2 => Scenario.LocationFlagDefinitions[27];
        public ILocationFlag sunken_chamber_player0 => Scenario.LocationFlagDefinitions[28];
        public ILocationFlag sunken_chamber_player1 => Scenario.LocationFlagDefinitions[29];
        public ILocationFlag sunken_chamber_ally1 => Scenario.LocationFlagDefinitions[30];
        public ILocationFlag sunken_chamber_ally2 => Scenario.LocationFlagDefinitions[31];
        public ILocationFlag tunnel_02_player0 => Scenario.LocationFlagDefinitions[32];
        public ILocationFlag tunnel_02_player1 => Scenario.LocationFlagDefinitions[33];
        public ILocationFlag tunnel_02_ally1 => Scenario.LocationFlagDefinitions[34];
        public ILocationFlag tunnel_02_ally2 => Scenario.LocationFlagDefinitions[35];
        public ILocationFlag island_player0 => Scenario.LocationFlagDefinitions[36];
        public ILocationFlag island_player1 => Scenario.LocationFlagDefinitions[37];
        public ILocationFlag island_ally1 => Scenario.LocationFlagDefinitions[38];
        public ILocationFlag island_ally2 => Scenario.LocationFlagDefinitions[39];
        public ILocationFlag gondola_02_player0 => Scenario.LocationFlagDefinitions[40];
        public ILocationFlag gondola_02_player1 => Scenario.LocationFlagDefinitions[41];
        public ILocationFlag gondola_02_ally1 => Scenario.LocationFlagDefinitions[42];
        public ILocationFlag gondola_02_ally2 => Scenario.LocationFlagDefinitions[43];
        public ILocationFlag temple_ext_player0 => Scenario.LocationFlagDefinitions[44];
        public ILocationFlag temple_ext_player1 => Scenario.LocationFlagDefinitions[45];
        public ILocationFlag temple_ext_ally1 => Scenario.LocationFlagDefinitions[46];
        public ILocationFlag temple_ext_ally2 => Scenario.LocationFlagDefinitions[47];
        public ILocationFlag temple_int_player0 => Scenario.LocationFlagDefinitions[48];
        public ILocationFlag temple_int_player1 => Scenario.LocationFlagDefinitions[49];
        public ILocationFlag temple_int_ally1 => Scenario.LocationFlagDefinitions[50];
        public ILocationFlag temple_int_ally2 => Scenario.LocationFlagDefinitions[51];
        public ILocationFlag temple_return_player0 => Scenario.LocationFlagDefinitions[52];
        public ILocationFlag temple_return_player1 => Scenario.LocationFlagDefinitions[53];
        public ILocationFlag tower2_spawn => Scenario.LocationFlagDefinitions[54];
        public ILocationFlag anchor_flag_outro => Scenario.LocationFlagDefinitions[55];
        public ILocationFlag anchor_flag_intra1b => Scenario.LocationFlagDefinitions[56];
        public ILocationFlag anchor_flag_intra1a => Scenario.LocationFlagDefinitions[57];
        public ILocationFlag tower1_player0 => Scenario.LocationFlagDefinitions[58];
        public ILocationFlag tower1_player1 => Scenario.LocationFlagDefinitions[59];
        public ILocationFlag _1to2_teleport => Scenario.LocationFlagDefinitions[60];
        public ILocationFlag _2to3_teleport => Scenario.LocationFlagDefinitions[61];
        public ILocationFlag holo3 => Scenario.LocationFlagDefinitions[62];
        public ILocationFlag tower_cluster => Scenario.LocationFlagDefinitions[63];
        public ILocationFlag splash_05 => Scenario.LocationFlagDefinitions[64];
        public ILocationFlag splash_03 => Scenario.LocationFlagDefinitions[65];
        public ILocationFlag splash_01 => Scenario.LocationFlagDefinitions[66];
        public ILocationFlag splash_07 => Scenario.LocationFlagDefinitions[67];
        public ILocationFlag splash_08 => Scenario.LocationFlagDefinitions[68];
        public ILocationFlag splash_02 => Scenario.LocationFlagDefinitions[69];
        public ILocationFlag splash_04 => Scenario.LocationFlagDefinitions[70];
        public ILocationFlag splash_06 => Scenario.LocationFlagDefinitions[71];
        public ILocationFlag splash_10 => Scenario.LocationFlagDefinitions[72];
        public ILocationFlag splash_11 => Scenario.LocationFlagDefinitions[73];
        public ILocationFlag splash_12 => Scenario.LocationFlagDefinitions[74];
        public ILocationFlag splash_13 => Scenario.LocationFlagDefinitions[75];
        public ILocationFlag splash_14 => Scenario.LocationFlagDefinitions[76];
        public ILocationFlag splash_15 => Scenario.LocationFlagDefinitions[77];
        public ILocationFlag splash_16 => Scenario.LocationFlagDefinitions[78];
        public ILocationFlag splash_09 => Scenario.LocationFlagDefinitions[79];
        public ILocationFlag splash_17 => Scenario.LocationFlagDefinitions[80];
        public ILocationFlag splash_24 => Scenario.LocationFlagDefinitions[81];
        public ILocationFlag splash_18 => Scenario.LocationFlagDefinitions[82];
        public ILocationFlag splash_19 => Scenario.LocationFlagDefinitions[83];
        public ILocationFlag splash_20 => Scenario.LocationFlagDefinitions[84];
        public ILocationFlag splash_21 => Scenario.LocationFlagDefinitions[85];
        public ILocationFlag splash_22 => Scenario.LocationFlagDefinitions[86];
        public ILocationFlag splash_23 => Scenario.LocationFlagDefinitions[87];
        public ILocationFlag splash_32 => Scenario.LocationFlagDefinitions[88];
        public ILocationFlag splash_25 => Scenario.LocationFlagDefinitions[89];
        public ILocationFlag splash_26 => Scenario.LocationFlagDefinitions[90];
        public ILocationFlag splash_27 => Scenario.LocationFlagDefinitions[91];
        public ILocationFlag splash_28 => Scenario.LocationFlagDefinitions[92];
        public ILocationFlag splash_29 => Scenario.LocationFlagDefinitions[93];
        public ILocationFlag splash_30 => Scenario.LocationFlagDefinitions[94];
        public ILocationFlag splash_31 => Scenario.LocationFlagDefinitions[95];
        public ILocationFlag cortana_effect => Scenario.LocationFlagDefinitions[96];
        public ILocationFlag temple_R_01 => Scenario.LocationFlagDefinitions[97];
        public ILocationFlag temple_R_02 => Scenario.LocationFlagDefinitions[98];
        public ILocationFlag temple_R_03 => Scenario.LocationFlagDefinitions[99];
        public ILocationFlag temple_R_04 => Scenario.LocationFlagDefinitions[100];
        public ILocationFlag temple_R_05 => Scenario.LocationFlagDefinitions[101];
        public ILocationFlag temple_L_05 => Scenario.LocationFlagDefinitions[102];
        public ILocationFlag temple_L_04 => Scenario.LocationFlagDefinitions[103];
        public ILocationFlag temple_L_03 => Scenario.LocationFlagDefinitions[104];
        public ILocationFlag temple_L_01 => Scenario.LocationFlagDefinitions[105];
        public ILocationFlag temple_L_02 => Scenario.LocationFlagDefinitions[106];
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_2 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title_2alt => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ICinematicTitle title_3 => Scenario.CinematicTitleDefinitions[3].GameObject;
        public ITriggerVolume xbsp_0_3 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume trans_0_3 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_3_1 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume trans_3_1 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume xbsp_1_4 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume trans_1_4 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume bsp_4_2 => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume trans_4_2 => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume vol_starting_locations => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume vol____ => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume vol_tower1_lower => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume vol_tower1_upper => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume vol_tower1_upper_right => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume vol_tower1_exit => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume vol_tower1_exit_01 => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume vol_tower1_exit_02 => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume vol_tower1_roof => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume vol_bridge => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume vol_bridge_far_half => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume vol_tower2_ext_entry => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume vol_tower2_entry => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume vol_in_tower2 => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume vol_tower2_exit => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume vol_tower2_by_exit => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume vol_tower2_ext_exit => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume vol_central_platform => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume vol_near_gondola_01 => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume vol_gondola_01 => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume vol_on_gondola_01_forsure => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume vol_gondola_01_mid => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume vol_intro_towers_all => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume vol_tower3_entry => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume vol_tower3_mid => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume vol_tower3_upstairs => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume vol_inside_elev_under => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume vol_elev_shaft_under => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume vol_tunnel_01_entry => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume vol_tunnel_01_mid => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume vol_sunken_chamber_entry => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume vol_sunk_chamber_safe_01 => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume vol_sunk_chamber_safe_02 => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume vol_sunk_chamber_left => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume vol_sunk_chamber_right => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume vol_sunk_chamber_near_01 => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume vol_sunk_chamber_near_02 => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume vol_sunk_chamber_far_01 => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume vol_sunk_chamber_far_02 => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume vol_sunk_chmbr_spwn_r1a => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume vol_sunk_chmbr_spwn_r1b => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume vol_sunk_chmbr_spwn_r2a => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume vol_sunk_chmbr_spwn_r2b => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume vol_sunk_chmbr_spwn_l1a => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume vol_sunk_chmbr_spwn_l1b => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume vol_sunk_chmbr_spwn_l2a => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume vol_sunk_chmbr_spwn_l2b => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume vol_rightside_hide => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume vol_leftside_hide => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume vol_leaving_sunken_chamber => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume vol_tunnel_02_entry => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume vol_tunnel_02_mid_01 => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume vol_tunnel_02_mid_02 => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume vol_tunnel_02_near_elev => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume vol_elev_up_dock => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume vol_inside_elev_up => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume vol_elev_shaft_up => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume vol_island_int_entry => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume vol_island_int_01 => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume vol_island_int_02 => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume vol_island_int_exit => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume vol_island_gully_ridge => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume vol_island_ext_start => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume vol_island_ext_01 => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume vol_island_ext_02 => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume vol_near_gondola_02 => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume vol_island_ext_inner => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume vol_island_ext_outer => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume vol_gondola_02 => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume vol_gondola_02_mid => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume vol_banshee_retreat => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume vol_temple_ext => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume vol_temple_ent_cutscene => Scenario.TriggerVolumes[80].GameObject;
        public ITriggerVolume vol_temple_entry => Scenario.TriggerVolumes[81].GameObject;
        public ITriggerVolume vol_temple_foyer => Scenario.TriggerVolumes[82].GameObject;
        public ITriggerVolume vol_temple_retreat_01 => Scenario.TriggerVolumes[83].GameObject;
        public ITriggerVolume vol_temple_retreat_02 => Scenario.TriggerVolumes[84].GameObject;
        public ITriggerVolume vol_whole_temple => Scenario.TriggerVolumes[85].GameObject;
        public ITriggerVolume vol_temple_left => Scenario.TriggerVolumes[86].GameObject;
        public ITriggerVolume vol_temple_right => Scenario.TriggerVolumes[87].GameObject;
        public ITriggerVolume vol_temple_01 => Scenario.TriggerVolumes[88].GameObject;
        public ITriggerVolume vol_temple_02 => Scenario.TriggerVolumes[89].GameObject;
        public ITriggerVolume vol_temple_03 => Scenario.TriggerVolumes[90].GameObject;
        public ITriggerVolume vol_temple_04 => Scenario.TriggerVolumes[91].GameObject;
        public ITriggerVolume vol_temple_spawnroom_01r => Scenario.TriggerVolumes[92].GameObject;
        public ITriggerVolume vol_temple_spawnroom_02r => Scenario.TriggerVolumes[93].GameObject;
        public ITriggerVolume vol_temple_spawnroom_01l => Scenario.TriggerVolumes[94].GameObject;
        public ITriggerVolume vol_temple_spawnroom_02l => Scenario.TriggerVolumes[95].GameObject;
        public ITriggerVolume kill_bsp01_01 => Scenario.TriggerVolumes[96].GameObject;
        public ITriggerVolume kill_bsp01_02 => Scenario.TriggerVolumes[97].GameObject;
        public ITriggerVolume kill_bsp03 => Scenario.TriggerVolumes[98].GameObject;
        public ITriggerVolume bird_tower_00 => Scenario.TriggerVolumes[99].GameObject;
        public ITriggerVolume bird_temple_01 => Scenario.TriggerVolumes[100].GameObject;
        public ITriggerVolume fish_01 => Scenario.TriggerVolumes[101].GameObject;
        public ITriggerVolume fish_03 => Scenario.TriggerVolumes[102].GameObject;
        public ITriggerVolume fish_tunnel_01 => Scenario.TriggerVolumes[103].GameObject;
        public ITriggerVolume fish_tunnel_02 => Scenario.TriggerVolumes[104].GameObject;
        public ITriggerVolume fish_tunnel_03 => Scenario.TriggerVolumes[105].GameObject;
        public ITriggerVolume fish_tunnel_04 => Scenario.TriggerVolumes[106].GameObject;
        public ITriggerVolume kill_temple_wings => Scenario.TriggerVolumes[107].GameObject;
        public ITriggerVolume kill_no_riders_up => Scenario.TriggerVolumes[108].GameObject;
        public ITriggerVolume kill_no_riders_under => Scenario.TriggerVolumes[109].GameObject;
        public ITriggerVolume vol_assassins => Scenario.TriggerVolumes[110].GameObject;
        public ITriggerVolume vol_tower2_exit_mid => Scenario.TriggerVolumes[111].GameObject;
        public IStartingProfile profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IDeviceGroup gondola_01_switch => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup elev_under_switch => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup elev_up_switch => Scenario.DeviceGroupDefinitions[2].GameObject;
        public IDeviceGroup gondola_02_switch => Scenario.DeviceGroupDefinitions[3].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            anchor_outro = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            carrier = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            index = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            anchor_intra1a = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            iac_bridge = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            in_game_throne = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            in_game_prophet = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            big_head = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            island_throne = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            island_int_prophet = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            tentacle_capture_02 = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            tentacle_capture_01 = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            anchor_intra1b = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            water_1to2a = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            rack = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            bomb01 = new ScenarioEntity<IBloc>(15, scenarioTag.WellKnownItems[15]);
            bomb02 = new ScenarioEntity<IBloc>(16, scenarioTag.WellKnownItems[16]);
            bomb03 = new ScenarioEntity<IBloc>(17, scenarioTag.WellKnownItems[17]);
            bomb04 = new ScenarioEntity<IBloc>(18, scenarioTag.WellKnownItems[18]);
            bomb05 = new ScenarioEntity<IBloc>(19, scenarioTag.WellKnownItems[19]);
            bomb06 = new ScenarioEntity<IBloc>(20, scenarioTag.WellKnownItems[20]);
            rack2 = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            bomb07 = new ScenarioEntity<IBloc>(22, scenarioTag.WellKnownItems[22]);
            bomb08 = new ScenarioEntity<IBloc>(23, scenarioTag.WellKnownItems[23]);
            bomb09 = new ScenarioEntity<IBloc>(24, scenarioTag.WellKnownItems[24]);
            bomb10 = new ScenarioEntity<IBloc>(25, scenarioTag.WellKnownItems[25]);
            bomb12 = new ScenarioEntity<IBloc>(26, scenarioTag.WellKnownItems[26]);
            bomb11 = new ScenarioEntity<IBloc>(27, scenarioTag.WellKnownItems[27]);
            sunken_throne = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            holo_index = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            holo_library = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            texture_camera = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            tower_cluster_01 = new ScenarioEntity<IBloc>(32, scenarioTag.WellKnownItems[32]);
            tower_cluster_02 = new ScenarioEntity<IBloc>(33, scenarioTag.WellKnownItems[33]);
            tower_cluster_05 = new ScenarioEntity<IBloc>(34, scenarioTag.WellKnownItems[34]);
            tower_cluster_06 = new ScenarioEntity<IBloc>(35, scenarioTag.WellKnownItems[35]);
            tower_cluster_07 = new ScenarioEntity<IBloc>(36, scenarioTag.WellKnownItems[36]);
            tower_cluster_08 = new ScenarioEntity<IBloc>(37, scenarioTag.WellKnownItems[37]);
            tower_cluster_09 = new ScenarioEntity<IBloc>(38, scenarioTag.WellKnownItems[38]);
            tower_cluster_10 = new ScenarioEntity<IBloc>(39, scenarioTag.WellKnownItems[39]);
            tower_cluster_11 = new ScenarioEntity<IBloc>(40, scenarioTag.WellKnownItems[40]);
            tower_cluster_12 = new ScenarioEntity<IBloc>(41, scenarioTag.WellKnownItems[41]);
            tower_cluster_13 = new ScenarioEntity<IBloc>(42, scenarioTag.WellKnownItems[42]);
            tower_cluster_14 = new ScenarioEntity<IBloc>(43, scenarioTag.WellKnownItems[43]);
            tower_cluster_15 = new ScenarioEntity<IBloc>(44, scenarioTag.WellKnownItems[44]);
            tower_cluster_16 = new ScenarioEntity<IBloc>(45, scenarioTag.WellKnownItems[45]);
            tower_cluster_17 = new ScenarioEntity<IBloc>(46, scenarioTag.WellKnownItems[46]);
            tower_cluster_18 = new ScenarioEntity<IBloc>(47, scenarioTag.WellKnownItems[47]);
            tower_cluster_19 = new ScenarioEntity<IBloc>(48, scenarioTag.WellKnownItems[48]);
            tower_cluster_20 = new ScenarioEntity<IBloc>(49, scenarioTag.WellKnownItems[49]);
            tower_cluster_21 = new ScenarioEntity<IBloc>(50, scenarioTag.WellKnownItems[50]);
            tower_cluster_22 = new ScenarioEntity<IBloc>(51, scenarioTag.WellKnownItems[51]);
            tower_cluster_23 = new ScenarioEntity<IBloc>(52, scenarioTag.WellKnownItems[52]);
            tower_cluster_24 = new ScenarioEntity<IBloc>(53, scenarioTag.WellKnownItems[53]);
            tower_cluster_25 = new ScenarioEntity<IBloc>(54, scenarioTag.WellKnownItems[54]);
            tower_cluster_26 = new ScenarioEntity<IBloc>(55, scenarioTag.WellKnownItems[55]);
            water_1to2b = new ScenarioEntity<IScenery>(56, scenarioTag.WellKnownItems[56]);
            water_2to3b = new ScenarioEntity<IScenery>(57, scenarioTag.WellKnownItems[57]);
            water_2to3a = new ScenarioEntity<IScenery>(58, scenarioTag.WellKnownItems[58]);
            fleet01 = new ScenarioEntity<IScenery>(59, scenarioTag.WellKnownItems[59]);
            fleet02 = new ScenarioEntity<IScenery>(60, scenarioTag.WellKnownItems[60]);
            fleet_high_char = new ScenarioEntity<IScenery>(61, scenarioTag.WellKnownItems[61]);
            rubble = new ScenarioEntity<IScenery>(62, scenarioTag.WellKnownItems[62]);
            caustic_light_01 = new ScenarioEntity<IScenery>(63, scenarioTag.WellKnownItems[63]);
            bubbles_01 = new ScenarioEntity<IScenery>(64, scenarioTag.WellKnownItems[64]);
            bubbles_02 = new ScenarioEntity<IScenery>(65, scenarioTag.WellKnownItems[65]);
            intra2_fleet = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            cortana_base = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            matte_horizon = new ScenarioEntity<IScenery>(68, scenarioTag.WellKnownItems[68]);
            outro_beam = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            outro_dust_scrape = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            outro_dust_land = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            cinematic_battle_rifle = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            chief = new ScenarioEntity<IUnit>(73, scenarioTag.WellKnownItems[73]);
            cortana = new ScenarioEntity<IUnit>(74, scenarioTag.WellKnownItems[74]);
            regret = new ScenarioEntity<IUnit>(75, scenarioTag.WellKnownItems[75]);
            miranda = new ScenarioEntity<IUnit>(76, scenarioTag.WellKnownItems[76]);
            pilot = new ScenarioEntity<IUnit>(77, scenarioTag.WellKnownItems[77]);
            regret01 = new ScenarioEntity<IUnit>(78, scenarioTag.WellKnownItems[78]);
            regret02 = new ScenarioEntity<IUnit>(79, scenarioTag.WellKnownItems[79]);
            regret03 = new ScenarioEntity<IUnit>(80, scenarioTag.WellKnownItems[80]);
            fake_corpse = new ScenarioEntity<IUnit>(81, scenarioTag.WellKnownItems[81]);
            johnson = new ScenarioEntity<IUnit>(82, scenarioTag.WellKnownItems[82]);
            throne_regret = new ScenarioEntity<IVehicle>(83, scenarioTag.WellKnownItems[83]);
            pelican_01 = new ScenarioEntity<IVehicle>(84, scenarioTag.WellKnownItems[84]);
            assassins = new ScenarioEntity<IWeapon>(85, scenarioTag.WellKnownItems[85]);
            gondola_01_a = new ScenarioEntity<IDevice>(86, scenarioTag.WellKnownItems[86]);
            gondola_02_a = new ScenarioEntity<IDevice>(87, scenarioTag.WellKnownItems[87]);
            elev_under = new ScenarioEntity<IDevice>(88, scenarioTag.WellKnownItems[88]);
            elev_up = new ScenarioEntity<IDevice>(89, scenarioTag.WellKnownItems[89]);
            elev_under_switch_01 = new ScenarioEntity<IDevice>(90, scenarioTag.WellKnownItems[90]);
            gondola_02_switch_front = new ScenarioEntity<IDevice>(91, scenarioTag.WellKnownItems[91]);
            gondola_01_switch_front = new ScenarioEntity<IDevice>(92, scenarioTag.WellKnownItems[92]);
            gondola_01_switch_back = new ScenarioEntity<IDevice>(93, scenarioTag.WellKnownItems[93]);
            gondola_02_switch_back = new ScenarioEntity<IDevice>(94, scenarioTag.WellKnownItems[94]);
            sunk_chamber_hunter_door = new ScenarioEntity<IDevice>(95, scenarioTag.WellKnownItems[95]);
            sunk_chmbr_spwn_r1a = new ScenarioEntity<IDevice>(96, scenarioTag.WellKnownItems[96]);
            sunk_chmbr_spwn_r1b = new ScenarioEntity<IDevice>(97, scenarioTag.WellKnownItems[97]);
            sunk_chmbr_spwn_r2b = new ScenarioEntity<IDevice>(98, scenarioTag.WellKnownItems[98]);
            sunk_chmbr_spwn_r2a = new ScenarioEntity<IDevice>(99, scenarioTag.WellKnownItems[99]);
            sunk_chmbr_spwn_l1a = new ScenarioEntity<IDevice>(100, scenarioTag.WellKnownItems[100]);
            sunk_chmbr_spwn_l1b = new ScenarioEntity<IDevice>(101, scenarioTag.WellKnownItems[101]);
            sunk_chmbr_spwn_l2b = new ScenarioEntity<IDevice>(102, scenarioTag.WellKnownItems[102]);
            sunk_chmbr_spwn_l2a = new ScenarioEntity<IDevice>(103, scenarioTag.WellKnownItems[103]);
            sunk_chamber_exit_r = new ScenarioEntity<IDevice>(104, scenarioTag.WellKnownItems[104]);
            sunk_chamber_exit_l = new ScenarioEntity<IDevice>(105, scenarioTag.WellKnownItems[105]);
            elev_up_switch_01 = new ScenarioEntity<IDevice>(106, scenarioTag.WellKnownItems[106]);
            gondola_01_b = new ScenarioEntity<IDevice>(107, scenarioTag.WellKnownItems[107]);
            gondola_01_launch_a = new ScenarioEntity<IDevice>(108, scenarioTag.WellKnownItems[108]);
            gondola_01_launch_b = new ScenarioEntity<IDevice>(109, scenarioTag.WellKnownItems[109]);
            gondola_02_b = new ScenarioEntity<IDevice>(110, scenarioTag.WellKnownItems[110]);
            gondola_02_launch_b = new ScenarioEntity<IDevice>(111, scenarioTag.WellKnownItems[111]);
            gondola_02_launch_a = new ScenarioEntity<IDevice>(112, scenarioTag.WellKnownItems[112]);
            temple_spawndoor_01l = new ScenarioEntity<IDevice>(113, scenarioTag.WellKnownItems[113]);
            temple_spawndoor_02l = new ScenarioEntity<IDevice>(114, scenarioTag.WellKnownItems[114]);
            temple_spawndoor_01r = new ScenarioEntity<IDevice>(115, scenarioTag.WellKnownItems[115]);
            temple_spawndoor_02r = new ScenarioEntity<IDevice>(116, scenarioTag.WellKnownItems[116]);
            temple_retreat_exit = new ScenarioEntity<IDevice>(117, scenarioTag.WellKnownItems[117]);
            door_main = new ScenarioEntity<IDevice>(118, scenarioTag.WellKnownItems[118]);
            gondola_02_b_fake = new ScenarioEntity<IDevice>(119, scenarioTag.WellKnownItems[119]);
            initial_allies = new Squad_initial_allies(scenarioTag);
            tower1_elites_01 = new Squad_tower1_elites_01(scenarioTag);
            tower1_elites_02 = new Squad_tower1_elites_02(scenarioTag);
            tower1_buggers_01 = new Squad_tower1_buggers_01(scenarioTag);
            tower1_buggers_02 = new Squad_tower1_buggers_02(scenarioTag);
            bridge_elites_01 = new Squad_bridge_elites_01(scenarioTag);
            bridge_elites_02 = new Squad_bridge_elites_02(scenarioTag);
            bridge_elites_03 = new Squad_bridge_elites_03(scenarioTag);
            bridge_elites_04 = new Squad_bridge_elites_04(scenarioTag);
            bridge_grunts_01 = new Squad_bridge_grunts_01(scenarioTag);
            bridge_grunts_02 = new Squad_bridge_grunts_02(scenarioTag);
            bridge_grunts_03 = new Squad_bridge_grunts_03(scenarioTag);
            bridge_grunts_04 = new Squad_bridge_grunts_04(scenarioTag);
            bridge_jackals_01 = new Squad_bridge_jackals_01(scenarioTag);
            bridge_jackals_02 = new Squad_bridge_jackals_02(scenarioTag);
            bridge_jackals_03 = new Squad_bridge_jackals_03(scenarioTag);
            bridge_jackals_04 = new Squad_bridge_jackals_04(scenarioTag);
            bridge_jackals_05 = new Squad_bridge_jackals_05(scenarioTag);
            bridge_jackals_06 = new Squad_bridge_jackals_06(scenarioTag);
            bridge_jackals_07 = new Squad_bridge_jackals_07(scenarioTag);
            tower2_jackals_01 = new Squad_tower2_jackals_01(scenarioTag);
            tower2_jackals_02 = new Squad_tower2_jackals_02(scenarioTag);
            tower2_grunts_01 = new Squad_tower2_grunts_01(scenarioTag);
            tower2_grunts_02 = new Squad_tower2_grunts_02(scenarioTag);
            central_platform_hunters = new Squad_central_platform_hunters(scenarioTag);
            central_platform_phantom = new Squad_central_platform_phantom(scenarioTag);
            central_platform_elites_01 = new Squad_central_platform_elites_01(scenarioTag);
            central_platform_elites_02 = new Squad_central_platform_elites_02(scenarioTag);
            central_platform_jackals_01 = new Squad_central_platform_jackals_01(scenarioTag);
            central_platform_jackals_02 = new Squad_central_platform_jackals_02(scenarioTag);
            central_plat_pelican = new Squad_central_plat_pelican(scenarioTag);
            central_plat_pelican_allies = new Squad_central_plat_pelican_allies(scenarioTag);
            gondola_01_elite_riders = new Squad_gondola_01_elite_riders(scenarioTag);
            gondola_01_grunt_riders = new Squad_gondola_01_grunt_riders(scenarioTag);
            gondola_01_jackal_riders = new Squad_gondola_01_jackal_riders(scenarioTag);
            gondola_01_buggers = new Squad_gondola_01_buggers(scenarioTag);
            gondola_01_phantom = new Squad_gondola_01_phantom(scenarioTag);
            gondola_01_elite_boarders = new Squad_gondola_01_elite_boarders(scenarioTag);
            gondola_01_grunt_boarders_01 = new Squad_gondola_01_grunt_boarders_01(scenarioTag);
            gondola_01_grunt_boarders_02 = new Squad_gondola_01_grunt_boarders_02(scenarioTag);
            gondola_01_b_buggers = new Squad_gondola_01_b_buggers(scenarioTag);
            gondola_01_b_elites = new Squad_gondola_01_b_elites(scenarioTag);
            tower3_sleeper = new Squad_tower3_sleeper(scenarioTag);
            tower3_turrets = new Squad_tower3_turrets(scenarioTag);
            tower3_dock_snipers = new Squad_tower3_dock_snipers(scenarioTag);
            tower3_dock_jackals = new Squad_tower3_dock_jackals(scenarioTag);
            tower3_dock_grunts = new Squad_tower3_dock_grunts(scenarioTag);
            tower3_jackals_01 = new Squad_tower3_jackals_01(scenarioTag);
            tower3_jackals_02 = new Squad_tower3_jackals_02(scenarioTag);
            tower3_buggers_01 = new Squad_tower3_buggers_01(scenarioTag);
            tower3_buggers_02 = new Squad_tower3_buggers_02(scenarioTag);
            tower3_jackals_elev = new Squad_tower3_jackals_elev(scenarioTag);
            tower3_pelican = new Squad_tower3_pelican(scenarioTag);
            tower3_pelican_allies = new Squad_tower3_pelican_allies(scenarioTag);
            tunnel_01_grunts_patrol = new Squad_tunnel_01_grunts_patrol(scenarioTag);
            tunnel_01_grunts_01 = new Squad_tunnel_01_grunts_01(scenarioTag);
            tunnel_01_grunts_02 = new Squad_tunnel_01_grunts_02(scenarioTag);
            tunnel_01_grunts_03 = new Squad_tunnel_01_grunts_03(scenarioTag);
            sunk_chamber_bugs_R_011 = new Squad_sunk_chamber_bugs_R_011(scenarioTag);
            sunk_chamber_bugs_R_021 = new Squad_sunk_chamber_bugs_R_021(scenarioTag);
            sunk_chamber_bugs_L_011 = new Squad_sunk_chamber_bugs_L_011(scenarioTag);
            sunk_chamber_bugs_L_021 = new Squad_sunk_chamber_bugs_L_021(scenarioTag);
            sunk_chamber_hunters = new Squad_sunk_chamber_hunters(scenarioTag);
            sunk_chamber_init_hg_Ra = new Squad_sunk_chamber_init_hg_Ra(scenarioTag);
            sunk_chamber_init_hg_Rb = new Squad_sunk_chamber_init_hg_Rb(scenarioTag);
            sunk_chamber_init_hg_La = new Squad_sunk_chamber_init_hg_La(scenarioTag);
            sunk_chamber_init_hg_Lb = new Squad_sunk_chamber_init_hg_Lb(scenarioTag);
            sunk_chamber_init_js_R01 = new Squad_sunk_chamber_init_js_R01(scenarioTag);
            sunk_chamber_init_js_R02 = new Squad_sunk_chamber_init_js_R02(scenarioTag);
            sunk_chamber_init_js_R03 = new Squad_sunk_chamber_init_js_R03(scenarioTag);
            sunk_chamber_init_js_R04 = new Squad_sunk_chamber_init_js_R04(scenarioTag);
            sunk_chamber_init_js_L01 = new Squad_sunk_chamber_init_js_L01(scenarioTag);
            sunk_chamber_init_js_L02 = new Squad_sunk_chamber_init_js_L02(scenarioTag);
            sunk_chamber_init_js_L03 = new Squad_sunk_chamber_init_js_L03(scenarioTag);
            sunk_chamber_init_js_L04 = new Squad_sunk_chamber_init_js_L04(scenarioTag);
            sunk_chamber_hg_R_01 = new Squad_sunk_chamber_hg_R_01(scenarioTag);
            sunk_chamber_hg_R_02 = new Squad_sunk_chamber_hg_R_02(scenarioTag);
            sunk_chamber_hg_L_01 = new Squad_sunk_chamber_hg_L_01(scenarioTag);
            sunk_chamber_hg_L_02 = new Squad_sunk_chamber_hg_L_02(scenarioTag);
            sunk_chamber_js_L_01 = new Squad_sunk_chamber_js_L_01(scenarioTag);
            sunk_chamber_js_L_02 = new Squad_sunk_chamber_js_L_02(scenarioTag);
            sunk_chamber_js_R_01 = new Squad_sunk_chamber_js_R_01(scenarioTag);
            sunk_chamber_js_R_02 = new Squad_sunk_chamber_js_R_02(scenarioTag);
            sunk_chamber_jack_R_01 = new Squad_sunk_chamber_jack_R_01(scenarioTag);
            sunk_chamber_jack_R_02 = new Squad_sunk_chamber_jack_R_02(scenarioTag);
            sunk_chamber_jack_L_01 = new Squad_sunk_chamber_jack_L_01(scenarioTag);
            sunk_chamber_jack_L_02 = new Squad_sunk_chamber_jack_L_02(scenarioTag);
            sunk_chamber_exit_e_R = new Squad_sunk_chamber_exit_e_R(scenarioTag);
            sunk_chamber_exit_e_L = new Squad_sunk_chamber_exit_e_L(scenarioTag);
            sunk_chamber_exit_j01_R = new Squad_sunk_chamber_exit_j01_R(scenarioTag);
            sunk_chamber_exit_j01_L = new Squad_sunk_chamber_exit_j01_L(scenarioTag);
            sunk_chamber_exit_j02_L = new Squad_sunk_chamber_exit_j02_L(scenarioTag);
            sunk_chamber_exit_j02_R = new Squad_sunk_chamber_exit_j02_R(scenarioTag);
            tunnel_02_elites_01 = new Squad_tunnel_02_elites_01(scenarioTag);
            tunnel_02_elites_02 = new Squad_tunnel_02_elites_02(scenarioTag);
            tunnel_02_elites_03 = new Squad_tunnel_02_elites_03(scenarioTag);
            tunnel_02_elites_04 = new Squad_tunnel_02_elites_04(scenarioTag);
            tunnel_02_grunts = new Squad_tunnel_02_grunts(scenarioTag);
            tunnel_02_buggers_01 = new Squad_tunnel_02_buggers_01(scenarioTag);
            tunnel_02_buggers_02 = new Squad_tunnel_02_buggers_02(scenarioTag);
            island_int_hg = new Squad_island_int_hg(scenarioTag);
            island_int_grunts = new Squad_island_int_grunts(scenarioTag);
            island_gully_buggers_01 = new Squad_island_gully_buggers_01(scenarioTag);
            island_gully_elites_01 = new Squad_island_gully_elites_01(scenarioTag);
            island_gully_elites_02 = new Squad_island_gully_elites_02(scenarioTag);
            island_gully_jackals_01 = new Squad_island_gully_jackals_01(scenarioTag);
            island_pelican = new Squad_island_pelican(scenarioTag);
            island_pelican_allies = new Squad_island_pelican_allies(scenarioTag);
            island_ext_js_01 = new Squad_island_ext_js_01(scenarioTag);
            island_ext_js_02 = new Squad_island_ext_js_02(scenarioTag);
            island_ext_js_03 = new Squad_island_ext_js_03(scenarioTag);
            island_ext_js_04 = new Squad_island_ext_js_04(scenarioTag);
            island_ext_grunts_01 = new Squad_island_ext_grunts_01(scenarioTag);
            island_ext_elites_01 = new Squad_island_ext_elites_01(scenarioTag);
            island_ext_grunts_02 = new Squad_island_ext_grunts_02(scenarioTag);
            island_ext_elites_02 = new Squad_island_ext_elites_02(scenarioTag);
            island_phantom = new Squad_island_phantom(scenarioTag);
            island_phantom_grunts = new Squad_island_phantom_grunts(scenarioTag);
            island_phantom_jackals = new Squad_island_phantom_jackals(scenarioTag);
            island_phantom_elites = new Squad_island_phantom_elites(scenarioTag);
            near_gondola_02_grunts = new Squad_near_gondola_02_grunts(scenarioTag);
            near_gondola_02_jackals = new Squad_near_gondola_02_jackals(scenarioTag);
            gondola_02_jetpacks = new Squad_gondola_02_jetpacks(scenarioTag);
            gondola_02_grunts = new Squad_gondola_02_grunts(scenarioTag);
            gondola_02_banshees1 = new Squad_gondola_02_banshees1(scenarioTag);
            temple_ent_turrets = new Squad_temple_ent_turrets(scenarioTag);
            temple_ent_grunts = new Squad_temple_ent_grunts(scenarioTag);
            temple_ent_jackals = new Squad_temple_ent_jackals(scenarioTag);
            temple_halls_jackals_01 = new Squad_temple_halls_jackals_01(scenarioTag);
            temple_halls_jackals_02L = new Squad_temple_halls_jackals_02L(scenarioTag);
            temple_halls_jackals_02R = new Squad_temple_halls_jackals_02R(scenarioTag);
            temple_halls_elites_01 = new Squad_temple_halls_elites_01(scenarioTag);
            temple_halls_elites_02 = new Squad_temple_halls_elites_02(scenarioTag);
            temple_hg_01L = new Squad_temple_hg_01L(scenarioTag);
            temple_hg_01R = new Squad_temple_hg_01R(scenarioTag);
            temple_hg_02L = new Squad_temple_hg_02L(scenarioTag);
            temple_hg_02R = new Squad_temple_hg_02R(scenarioTag);
            regret1 = new Squad_regret1(scenarioTag);
            temple_exit_elites_01 = new Squad_temple_exit_elites_01(scenarioTag);
            temple_exit_grunts_01 = new Squad_temple_exit_grunts_01(scenarioTag);
            temple_exit_jackals_02 = new Squad_temple_exit_jackals_02(scenarioTag);
            temple_exit_elites_02 = new Squad_temple_exit_elites_02(scenarioTag);
            temple_exit_jackals_03 = new Squad_temple_exit_jackals_03(scenarioTag);
            temple_exit_elites_04 = new Squad_temple_exit_elites_04(scenarioTag);
            temple_exit_hg_041 = new Squad_temple_exit_hg_041(scenarioTag);
            ranger = new Squad_ranger(scenarioTag);
            run = new Squad_run(scenarioTag);
            temp_bsp2_allies = new Squad_temp_bsp2_allies(scenarioTag);
            temp_bsp3_allies = new Squad_temp_bsp3_allies(scenarioTag);
            temple_hg_init = new Squad_temple_hg_init(scenarioTag);
            gondola_01_bugs_new = new Squad_gondola_01_bugs_new(scenarioTag);
            temple_heavies = new Squad_temple_heavies(scenarioTag);
            assassin_elites = new Squad_assassin_elites(scenarioTag);
            honor_grunts_init_R = new Squad_honor_grunts_init_R(scenarioTag);
            honor_grunts_init_L = new Squad_honor_grunts_init_L(scenarioTag);
            honor_grunts_new_L = new Squad_honor_grunts_new_L(scenarioTag);
            honor_grunts_new_R = new Squad_honor_grunts_new_R(scenarioTag);
        }
    }
}