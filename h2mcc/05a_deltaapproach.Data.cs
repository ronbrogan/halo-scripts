namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_05a_deltaapproach : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> anchor_x05 { get; set; }
        public ScenarioEntity<IScenery> carrier { get; set; }
        public ScenarioEntity<IScenery> iac { get; set; }
        public ScenarioEntity<IScenery> cigar { get; set; }
        public ScenarioEntity<IScenery> hev_01 { get; set; }
        public ScenarioEntity<IScenery> hev_02 { get; set; }
        public ScenarioEntity<IScenery> hev_03 { get; set; }
        public ScenarioEntity<IScenery> hev_04 { get; set; }
        public ScenarioEntity<IScenery> hev_05 { get; set; }
        public ScenarioEntity<IScenery> hev_06 { get; set; }
        public ScenarioEntity<IScenery> hev_07 { get; set; }
        public ScenarioEntity<IScenery> hev_08 { get; set; }
        public ScenarioEntity<IScenery> hev_09 { get; set; }
        public ScenarioEntity<IScenery> hev_10 { get; set; }
        public ScenarioEntity<IScenery> hev_11 { get; set; }
        public ScenarioEntity<IScenery> hev_12 { get; set; }
        public ScenarioEntity<IScenery> hev_13 { get; set; }
        public ScenarioEntity<IScenery> hev_14 { get; set; }
        public ScenarioEntity<IScenery> hev_15 { get; set; }
        public ScenarioEntity<IScenery> hev_16 { get; set; }
        public ScenarioEntity<IScenery> hev_17 { get; set; }
        public ScenarioEntity<IScenery> hev_bay { get; set; }
        public ScenarioEntity<IScenery> anchor_intro { get; set; }
        public ScenarioEntity<IScenery> rocket_01 { get; set; }
        public ScenarioEntity<IScenery> iac_bridge { get; set; }
        public ScenarioEntity<IScenery> bunker_throne { get; set; }
        public ScenarioEntity<IScenery> courtyard_prophet { get; set; }
        public ScenarioEntity<IScenery> tower1_throne { get; set; }
        public ScenarioEntity<IScenery> matte_substance { get; set; }
        public ScenarioEntity<IScenery> matte_alpha_halo { get; set; }
        public ScenarioEntity<IScenery> matte_delta_halo_close { get; set; }
        public ScenarioEntity<IScenery> matte_clouds_01 { get; set; }
        public ScenarioEntity<IScenery> matte_clouds_02 { get; set; }
        public ScenarioEntity<IScenery> matte_horizon { get; set; }
        public ScenarioEntity<IScenery> matte_islands { get; set; }
        public ScenarioEntity<IScenery> intro_crate_01 { get; set; }
        public ScenarioEntity<IScenery> intro_crate_02 { get; set; }
        public ScenarioEntity<IScenery> smg_01 { get; set; }
        public ScenarioEntity<IScenery> corona_02 { get; set; }
        public ScenarioEntity<IScenery> corona_01 { get; set; }
        public ScenarioEntity<IScenery> corona_03 { get; set; }
        public ScenarioEntity<IScenery> corona_04 { get; set; }
        public ScenarioEntity<IScenery> corona_05 { get; set; }
        public ScenarioEntity<IScenery> corona_06 { get; set; }
        public ScenarioEntity<IScenery> corona_07 { get; set; }
        public ScenarioEntity<IBloc> bomb01 { get; set; }
        public ScenarioEntity<IBloc> bomb02 { get; set; }
        public ScenarioEntity<IBloc> bomb03 { get; set; }
        public ScenarioEntity<IBloc> bomb04 { get; set; }
        public ScenarioEntity<IBloc> bomb05 { get; set; }
        public ScenarioEntity<IBloc> bomb06 { get; set; }
        public ScenarioEntity<IScenery> rack { get; set; }
        public ScenarioEntity<IScenery> court_throne_attach { get; set; }
        public ScenarioEntity<IScenery> court_throne { get; set; }
        public ScenarioEntity<IScenery> court_gen { get; set; }
        public ScenarioEntity<IScenery> x05_debris { get; set; }
        public ScenarioEntity<IScenery> texture_camera { get; set; }
        public ScenarioEntity<IScenery> x05_slipspace { get; set; }
        public ScenarioEntity<IScenery> hev_close_01 { get; set; }
        public ScenarioEntity<IScenery> hev_close_02 { get; set; }
        public ScenarioEntity<IScenery> hev_close_03 { get; set; }
        public ScenarioEntity<IScenery> hev_close_04 { get; set; }
        public ScenarioEntity<IScenery> hev_close_05 { get; set; }
        public ScenarioEntity<IScenery> hev_close_06 { get; set; }
        public ScenarioEntity<IScenery> hev_close_07 { get; set; }
        public ScenarioEntity<IScenery> hev_close_08 { get; set; }
        public ScenarioEntity<IScenery> tree_toy { get; set; }
        public ScenarioEntity<IScenery> hev_chute { get; set; }
        public ScenarioEntity<IScenery> delta_halo { get; set; }
        public ScenarioEntity<IScenery> intro_fire { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> johnson { get; set; }
        public ScenarioEntity<IUnit> nav_officer { get; set; }
        public ScenarioEntity<IUnit> weap_officer { get; set; }
        public ScenarioEntity<IUnit> jackal_01 { get; set; }
        public ScenarioEntity<IUnit> grunt_01 { get; set; }
        public ScenarioEntity<IUnit> chief_intro { get; set; }
        public ScenarioEntity<IUnit> regret02 { get; set; }
        public ScenarioEntity<IUnit> regret01 { get; set; }
        public ScenarioEntity<IUnit> regret03 { get; set; }
        public ScenarioEntity<IUnit> chief_toy { get; set; }
        public ScenarioEntity<IUnit> grunt_toy { get; set; }
        public ScenarioEntity<IVehicle> lz_hog { get; set; }
        public ScenarioEntity<IVehicle> bridge_tank { get; set; }
        public ScenarioEntity<IVehicle> intro_turret { get; set; }
        public ScenarioEntity<IVehicle> intro_turret_02 { get; set; }
        public ScenarioEntity<IStartingProfile> toys_07 { get; set; }
        public ScenarioEntity<IStartingProfile> toys_08 { get; set; }
        public ScenarioEntity<IStartingProfile> toys_09 { get; set; }
        public ScenarioEntity<IStartingProfile> toys_10 { get; set; }
        public ScenarioEntity<IStartingProfile> grenade_toy_01 { get; set; }
        public ScenarioEntity<IStartingProfile> grenade_toy_02 { get; set; }
        public ScenarioEntity<IWeapon> toys_01 { get; set; }
        public ScenarioEntity<IWeapon> toys_02 { get; set; }
        public ScenarioEntity<IWeapon> toys_03 { get; set; }
        public ScenarioEntity<IWeapon> toys_04 { get; set; }
        public ScenarioEntity<IWeapon> toys_05 { get; set; }
        public ScenarioEntity<IWeapon> toys_06 { get; set; }
        public ScenarioEntity<IWeapon> turret_handheld { get; set; }
        public ScenarioEntity<IWeapon> turret_handheld_02 { get; set; }
        public ScenarioEntity<IWeapon> envy { get; set; }
        public ScenarioEntity<IWeapon> jackal_shield { get; set; }
        public ScenarioEntity<ISound> waterfall_far { get; set; }
        public ScenarioEntity<ISound> waterfall_close { get; set; }
        public ScenarioEntity<IDevice> da_bridge { get; set; }
        public ScenarioEntity<IDevice> da_bridge_switch { get; set; }
        public ScenarioEntity<IDevice> real_bridge { get; set; }
        public IAiActorDefinition all_ai => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition all_allies => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition ally_infantry => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition ally_vehicles => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition all_enemies => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition LZ_allies => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition LZ_enemies_all => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition LZ_enemies_turrets => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition LZ_enemies_ledge => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition LZ_enemies_ridge => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition LZ_enemies_structure => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition LZ_enemies_yard => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition LZ_enemies_phantom => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition overlook_jackals => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition bridge_allies => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition bridge_enemies_all => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition bridge_enemies_bunker => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition bridge_bunker_elites => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition bridge_bunker_jackals => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition bridge_bunker_grunts => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition bridge_vehicles_all => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition bridge_farside_enemies => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition winding_path_enemies => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition winding_path_ghosts => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition temple_ent_enemies_all => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition temple_ent_ghosts => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition temple_ent_turrets_near => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition temple_ent_turrets_far => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition tunnel_enemies_all => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition tunnel_infantry => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition tunnel_ghosts => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition old_temple_enemies => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition old_temple_peri_grunts => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition old_temple_peri_jackals => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition old_temple_center_all => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition old_temp_center_tough => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition old_temp_center_fodder => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition old_temple_court_all => Scenario.AiSquadGroupDefinitions[37];
        public IAiActorDefinition old_temple_vehicles => Scenario.AiSquadGroupDefinitions[38];
        public IAiActorDefinition grotto_enemies => Scenario.AiSquadGroupDefinitions[39];
        public IAiActorDefinition grotto_initial => Scenario.AiSquadGroupDefinitions[40];
        public IAiActorDefinition grotto_phantom => Scenario.AiSquadGroupDefinitions[41];
        public IAiActorDefinition grotto_buggers => Scenario.AiSquadGroupDefinitions[42];
        public IAiActorDefinition grotto_enders => Scenario.AiSquadGroupDefinitions[43];
        public IAiActorDefinition approach_enemies => Scenario.AiSquadGroupDefinitions[44];
        public IAiActorDefinition tower1_enemies => Scenario.AiSquadGroupDefinitions[45];
        public IAiOrders allies_lz_entry_ledge => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders allies_lz_entry_ridge => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders allies_lz_entry_ridge_01 => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders allies_lz_entry_ridge_02 => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders allies_lz_entry_ridge_03 => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders allies_lz_structure_left => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders allies_lz_structure_interior => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders allies_lz_all => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders allies_lz_hogs => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders lz_enemies_ledge_01 => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders lz_enemies_ledge_02 => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders lz_enemies_ridge_01 => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders lz_enemies_ridge_02 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders lz_enemies_ridge_01_r => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders lz_enemies_ridge_02_r => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders lz_enemies_yard_01 => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders lz_enemies_yard_02 => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders lz_enemies_structure_front => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders lz_enemies_structure_low => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders lz_enemies_structure_high => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders lz_enemies_turrets => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders lz_enemies_phantom_01 => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders lz_enemies_phantom_02 => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders lz_enemies_structure_go_mid => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders lz_enemies_structure_go_rt => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders lz_enemies_structure_go_left => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders lz_pelican_circle => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders lz_vehicles => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders spectre_ahead => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders allies_overlook_pause => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders allies_overlook_follow => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders overlook_jackals_01 => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders overlook_jackals_02 => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders allies_bridge_pause => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders allies_bridge_advance => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders bridge_assault => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders bridge_farside_front => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders bridge_farside_back => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders bridge_bunker_low_01 => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders bridge_bunker_high_01 => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders bridge_bunker_turrets => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders bridge_crack => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders allies_bridge_bunker => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders bridge_bunker_in_upper_01 => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders bridge_bunker_in_center_01 => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders bridge_bunker_in_lower_01 => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders bridge_bunker_in_lower_02 => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders bridge_ghosts_follow => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders bridge_all_favor_far => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders bridge_all_favor_near => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders bridge_tank_wait => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders allies_bridge_follow_01 => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders allies_bridge_follow_02 => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders allies_bridge_cross => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders bridge_allies_hold => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders bridge_air => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders bridge_pelican_chase => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders allies_w_path_follow => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders allies_w_path_advance => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders winding_path_ghosts1 => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders winding_path_run => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders w_path_end_grunts => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders winding_path_ledge => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders winding_path_columns => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders temple_ent_assault => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders allies_temple_ent_follow => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders allies_temple_ent_advance_01 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders allies_temple_ent_advance_02 => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders allies_temple_ent_advance_03 => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders temple_ent_all => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders temple_ent_back_01 => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders temple_ent_back_02 => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders temple_ent_line_01l => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders temple_ent_line_01c => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders temple_ent_line_01r => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders temple_ent_line_02l => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders temple_ent_line_02c => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders temple_ent_line_02r => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders temple_ent_line_03l => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders temple_ent_line_03c => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders temple_ent_line_03r => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders temple_ent_line_04l => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders temple_ent_line_04c => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders temple_ent_line_04r => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders temple_ent_line_05 => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders temple_ent_ghost_l => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders temple_ent_ghost_r => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders temple_ent_allies_01 => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders temple_ent_allies_02 => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders temple_ent_allies_03 => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders temple_ent_air => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders allies_tunnel_advance => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders allies_tunnel_follow => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders tunnel_ghosts_01 => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders tunnel_ghosts_02 => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders tunnel_infantry_01 => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders tunnel_infantry_02 => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders allies_old_temple_assault => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders allies_old_temple_follow => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders old_temple_vehicles1 => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders old_temple_vehicles_ltd => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders allies_old_temple_advance => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders old_temple_init_center_nr => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders old_temple_init_center_nl => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders old_temple_init_center_fl => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders old_temple_jackal_follow => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders old_temple_seawall_near => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders old_temple_seawall_far => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders old_temple_farwall_near => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders old_temple_farwall_far => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders old_temple_center_01 => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders old_temple_center_03 => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders old_temple_center_04 => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders old_temple_center_05 => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders old_temple_center_06 => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders old_temple_play_cov => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders old_temple_play_hum => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders old_temple_center_allies_01 => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders old_temple_center_allies_03 => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders old_temple_center_allies_05 => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders allies_old_temp_center => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders old_temple_courtyard_01 => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders old_temple_courtyard_02 => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders old_temple_courtyard_03 => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders old_temple_courtyard_04 => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders old_temple_courtyard_05 => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders old_temple_courtyard_06_r => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders old_temple_courtyard_06_f => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders old_temple_courtyard_06_b => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders old_temple_court_allies_01 => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders old_temple_court_allies_02 => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders old_temple_court_allies_04 => Scenario.AiOrderDefinitions[131].GameObject;
        public IAiOrders old_temple_court_allies_05 => Scenario.AiOrderDefinitions[132].GameObject;
        public IAiOrders old_temple_court_allies_06 => Scenario.AiOrderDefinitions[133].GameObject;
        public IAiOrders old_temp_court_allies => Scenario.AiOrderDefinitions[134].GameObject;
        public IAiOrders old_temple_across_01 => Scenario.AiOrderDefinitions[135].GameObject;
        public IAiOrders old_temple_across_02 => Scenario.AiOrderDefinitions[136].GameObject;
        public IAiOrders old_temple_air => Scenario.AiOrderDefinitions[137].GameObject;
        public IAiOrders old_temple_phantom => Scenario.AiOrderDefinitions[138].GameObject;
        public IAiOrders grotto_entry_ledge => Scenario.AiOrderDefinitions[139].GameObject;
        public IAiOrders grotto_near_right_top => Scenario.AiOrderDefinitions[140].GameObject;
        public IAiOrders grotto_near_right_mid => Scenario.AiOrderDefinitions[141].GameObject;
        public IAiOrders grotto_near_left_top => Scenario.AiOrderDefinitions[142].GameObject;
        public IAiOrders grotto_near_bottom => Scenario.AiOrderDefinitions[143].GameObject;
        public IAiOrders grotto_center_right_top => Scenario.AiOrderDefinitions[144].GameObject;
        public IAiOrders grotto_center_right_mid => Scenario.AiOrderDefinitions[145].GameObject;
        public IAiOrders grotto_center_left_top => Scenario.AiOrderDefinitions[146].GameObject;
        public IAiOrders grotto_center_left_mid => Scenario.AiOrderDefinitions[147].GameObject;
        public IAiOrders grotto_center_bottom => Scenario.AiOrderDefinitions[148].GameObject;
        public IAiOrders grotto_far_right_top => Scenario.AiOrderDefinitions[149].GameObject;
        public IAiOrders grotto_far_left_top => Scenario.AiOrderDefinitions[150].GameObject;
        public IAiOrders grotto_far_ridge => Scenario.AiOrderDefinitions[151].GameObject;
        public IAiOrders grotto_far_mid => Scenario.AiOrderDefinitions[152].GameObject;
        public IAiOrders grotto_far_bottom => Scenario.AiOrderDefinitions[153].GameObject;
        public IAiOrders grotto_end_03 => Scenario.AiOrderDefinitions[154].GameObject;
        public IAiOrders grotto_end_02 => Scenario.AiOrderDefinitions[155].GameObject;
        public IAiOrders grotto_end_01 => Scenario.AiOrderDefinitions[156].GameObject;
        public IAiOrders grotto_follow_01 => Scenario.AiOrderDefinitions[157].GameObject;
        public IAiOrders grotto_follow_02 => Scenario.AiOrderDefinitions[158].GameObject;
        public IAiOrders grotto_follow_03 => Scenario.AiOrderDefinitions[159].GameObject;
        public IAiOrders grotto_bridge => Scenario.AiOrderDefinitions[160].GameObject;
        public IAiOrders grotto_end_run => Scenario.AiOrderDefinitions[161].GameObject;
        public IAiOrders allies_grotto_exit => Scenario.AiOrderDefinitions[162].GameObject;
        public IAiOrders allies_approach => Scenario.AiOrderDefinitions[163].GameObject;
        public IAiOrders approach_patrol_01 => Scenario.AiOrderDefinitions[164].GameObject;
        public IAiOrders approach_patrol_02 => Scenario.AiOrderDefinitions[165].GameObject;
        public IAiOrders approach_patrol_03 => Scenario.AiOrderDefinitions[166].GameObject;
        public IAiOrders approach_patrol_04 => Scenario.AiOrderDefinitions[167].GameObject;
        public IAiOrders approach_patrol_05 => Scenario.AiOrderDefinitions[168].GameObject;
        public IAiOrders approach_patrol_06 => Scenario.AiOrderDefinitions[169].GameObject;
        public IAiOrders approach_sleepers => Scenario.AiOrderDefinitions[170].GameObject;
        public IAiOrders approach_fire_01 => Scenario.AiOrderDefinitions[171].GameObject;
        public IAiOrders approach_fire_02 => Scenario.AiOrderDefinitions[172].GameObject;
        public IAiOrders approach_retreat_01 => Scenario.AiOrderDefinitions[173].GameObject;
        public IAiOrders approach_retreat_02 => Scenario.AiOrderDefinitions[174].GameObject;
        public IAiOrders approach_retreat_03 => Scenario.AiOrderDefinitions[175].GameObject;
        public IAiOrders approach_retreat_04 => Scenario.AiOrderDefinitions[176].GameObject;
        public IAiOrders tower1_lower_front => Scenario.AiOrderDefinitions[177].GameObject;
        public IAiOrders tower1_lower_back => Scenario.AiOrderDefinitions[178].GameObject;
        public IAiOrders tower1_upper_left => Scenario.AiOrderDefinitions[179].GameObject;
        public IAiOrders tower1_upper_right => Scenario.AiOrderDefinitions[180].GameObject;
        public IAiOrders allies_tower1 => Scenario.AiOrderDefinitions[181].GameObject;
        public IAiOrders allies_grotto_suppress => Scenario.AiOrderDefinitions[182].GameObject;
        public IAiOrders grotto_buggers_bott_near => Scenario.AiOrderDefinitions[183].GameObject;
        public IAiOrders grotto_sleep => Scenario.AiOrderDefinitions[184].GameObject;
        public IAiOrders grotto_near_crack => Scenario.AiOrderDefinitions[185].GameObject;
        public IAiOrders grotto_leaving_pool => Scenario.AiOrderDefinitions[186].GameObject;
        public IAiOrders approach_buggers => Scenario.AiOrderDefinitions[187].GameObject;
        public IAiOrders approach_buggers_too => Scenario.AiOrderDefinitions[188].GameObject;
        public IAiOrders tower1_all => Scenario.AiOrderDefinitions[189].GameObject;
        public IAiOrders tower1_hg1a => Scenario.AiOrderDefinitions[190].GameObject;
        public IAiOrders tower1_hg1b => Scenario.AiOrderDefinitions[191].GameObject;
        public IAiOrders tower1_hg1a_back => Scenario.AiOrderDefinitions[192].GameObject;
        public IAiOrders tower1_hg1b_back => Scenario.AiOrderDefinitions[193].GameObject;
        public IAiOrders tower1_hg2b => Scenario.AiOrderDefinitions[194].GameObject;
        public ILocationFlag lz_start_player0 => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag lz_start_player1 => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag lz_exit => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag bridge_player1 => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag bridge_player0 => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag winding_path_player0 => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag winding_path_player1 => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag temple_ent_player0 => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag temple_ent_player1 => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag tunnel_player0 => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag tunnel_player1 => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag old_temple_player0 => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag old_temple_player1 => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag grotto_player0 => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag grotto_player1 => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag approach_player0 => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag approach_player1 => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag tower1_player0 => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag tower1_player1 => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag anchor_flag_x05 => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag bunker_1 => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag bunker_2 => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag anchor_flag_intro => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag temp => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag seawall_01 => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag seawall_02 => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag seawall_03 => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag farwall_03 => Scenario.LocationFlagDefinitions[27];
        public ILocationFlag farwall_02 => Scenario.LocationFlagDefinitions[28];
        public ILocationFlag farwall_01 => Scenario.LocationFlagDefinitions[29];
        public ILocationFlag below_near_R => Scenario.LocationFlagDefinitions[30];
        public ILocationFlag below_near_L => Scenario.LocationFlagDefinitions[31];
        public ILocationFlag below_far_L => Scenario.LocationFlagDefinitions[32];
        public ILocationFlag below_far_R => Scenario.LocationFlagDefinitions[33];
        public ILocationFlag debris => Scenario.LocationFlagDefinitions[34];
        public ILocationFlag seawall_alcove_02 => Scenario.LocationFlagDefinitions[35];
        public ILocationFlag seawall_alcove_01 => Scenario.LocationFlagDefinitions[36];
        public ILocationFlag entry_shrine_L => Scenario.LocationFlagDefinitions[37];
        public ILocationFlag entry_shrine_R => Scenario.LocationFlagDefinitions[38];
        public ILocationFlag center_nook => Scenario.LocationFlagDefinitions[39];
        public ILocationFlag grotto_exit => Scenario.LocationFlagDefinitions[40];
        public ILocationFlag old_temple_exit => Scenario.LocationFlagDefinitions[41];
        public ILocationFlag courtyard_exit => Scenario.LocationFlagDefinitions[42];
        public ILocationFlag grotto_center => Scenario.LocationFlagDefinitions[43];
        public ILocationFlag ally_start => Scenario.LocationFlagDefinitions[44];
        public ILocationFlag see_tower1 => Scenario.LocationFlagDefinitions[45];
        public ILocationFlag extra_ghost_02 => Scenario.LocationFlagDefinitions[46];
        public ILocationFlag extra_ghost_01 => Scenario.LocationFlagDefinitions[47];
        public ILocationFlag extra_ghost_03 => Scenario.LocationFlagDefinitions[48];
        public ILocationFlag extra_ghost_04 => Scenario.LocationFlagDefinitions[49];
        public ILocationFlag c05_intro_pod_03 => Scenario.LocationFlagDefinitions[50];
        public ILocationFlag c05_intro_pod_02 => Scenario.LocationFlagDefinitions[51];
        public ILocationFlag c05_intro_pod_01 => Scenario.LocationFlagDefinitions[52];
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_2 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title_3 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume trans_0_1 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_1_0 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume trans_1_0 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume kill_bsp00_all => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume kill_bsp00_lz => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume kill_bsp01_all => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume vol_starting_locations => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume vol_entry_ledge => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume vol_lz_all => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume vol_lz_leaving_ledge => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume vol_lz_trip_ridge_01 => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume vol_lz_trip_ridge_02 => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume vol_lz_trip_ridge_03 => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume vol_lz_leaving_ridge => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume vol_lz_in_yard_01 => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume vol_lz_in_yard_02 => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume vol_lz_in_structure => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume vol_lz_warthog => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume vol_leaving_lz => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume vol_overlook => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume vol_overlook_pause => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume vol_bridge_pause => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume vol_bridge_all => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume vol_bridge_engage => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume vol_bridge_middle => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume vol_bridge_near_bunker => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume vol_bridge_inside_bunker => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume vol_bunker_upper_level => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume vol_bunker_roof => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume vol_bunker_lower_level => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume vol_bunker_backdoor => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume vol_bunker_spawnstop_01 => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume vol_bunker_spawnstop_02 => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume vol_bunker_spawnstop_03 => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume vol_bunker_frontdoors => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume vol_bunker_front => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume vol_bridge_tank => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume vol_bridge_farside_all => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume vol_winding_path => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume vol_winding_path_mid_01 => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume vol_winding_path_mid_02 => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume vol_winding_path_mid_03 => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume vol_waterfall_on => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume vol_waterfall_off => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume vol_old_temple_ent_ent => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume vol_temple_ent_start => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume vol_temple_entrance => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume vol_temple_ent_01 => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume vol_temple_ent_02 => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume vol_temple_ent_03 => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume vol_tunnel_01 => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume vol_tunnel_02 => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume vol_tunnel_03 => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume vol_old_temple_farwall_01 => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume vol_old_temple_farwall_02 => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume vol_old_temple_farwall_03 => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume vol_old_temple_seawall_01 => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume vol_old_temple_seawall_02 => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume vol_old_temple_seawall_03 => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume vol_old_temple_seawall_all => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume vol_old_temple_farwall_all => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume vol_old_temple_see_nook => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume vol_old_temple_below_near => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume vol_old_temple_below_far => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume vol_old_temple_airspace_low => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume vol_old_temple_airspace_high => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume vol_old_temple_close_nuff => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume vol_old_temple_in_court => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume vol_old_temple_court_01 => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume vol_old_temple_court_02 => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume vol_old_temple_court_04 => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume vol_old_temple_court_05 => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume vol_old_temple_court_06 => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume vol_old_temple_dropzone => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume vol_old_temple_center_01 => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume vol_old_temple_center_03 => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume vol_old_temple_center_05 => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume vol_old_temple_far_left => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume vol_old_temple_near_left => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume vol_old_temple_near_right => Scenario.TriggerVolumes[80].GameObject;
        public ITriggerVolume vol_old_temple_far_right => Scenario.TriggerVolumes[81].GameObject;
        public ITriggerVolume vol_old_temple_below => Scenario.TriggerVolumes[82].GameObject;
        public ITriggerVolume vol_old_temple_start => Scenario.TriggerVolumes[83].GameObject;
        public ITriggerVolume vol_old_temple_int_01 => Scenario.TriggerVolumes[84].GameObject;
        public ITriggerVolume vol_old_temple_int_02 => Scenario.TriggerVolumes[85].GameObject;
        public ITriggerVolume vol_old_temple_debris => Scenario.TriggerVolumes[86].GameObject;
        public ITriggerVolume vol_through_debris => Scenario.TriggerVolumes[87].GameObject;
        public ITriggerVolume vol_tunnel_ghost_spawn => Scenario.TriggerVolumes[88].GameObject;
        public ITriggerVolume vol_grotto => Scenario.TriggerVolumes[89].GameObject;
        public ITriggerVolume vol_grotto_first_pool_01 => Scenario.TriggerVolumes[90].GameObject;
        public ITriggerVolume vol_grotto_first_pool_02 => Scenario.TriggerVolumes[91].GameObject;
        public ITriggerVolume vol_grotto_mid_01 => Scenario.TriggerVolumes[92].GameObject;
        public ITriggerVolume vol_grotto_mid_02 => Scenario.TriggerVolumes[93].GameObject;
        public ITriggerVolume vol_grotto_mid_03 => Scenario.TriggerVolumes[94].GameObject;
        public ITriggerVolume vol_grotto_far_top => Scenario.TriggerVolumes[95].GameObject;
        public ITriggerVolume vol_grotto_follow_01 => Scenario.TriggerVolumes[96].GameObject;
        public ITriggerVolume vol_grotto_follow_02 => Scenario.TriggerVolumes[97].GameObject;
        public ITriggerVolume vol_grotto_follow_03 => Scenario.TriggerVolumes[98].GameObject;
        public ITriggerVolume vol_grotto_end => Scenario.TriggerVolumes[99].GameObject;
        public ITriggerVolume vol_grotto_exit => Scenario.TriggerVolumes[100].GameObject;
        public ITriggerVolume vol_approach => Scenario.TriggerVolumes[101].GameObject;
        public ITriggerVolume vol_approach_music => Scenario.TriggerVolumes[102].GameObject;
        public ITriggerVolume vol_approach_ramp => Scenario.TriggerVolumes[103].GameObject;
        public ITriggerVolume vol_no_see_ramp => Scenario.TriggerVolumes[104].GameObject;
        public ITriggerVolume vol_no_see_approach => Scenario.TriggerVolumes[105].GameObject;
        public ITriggerVolume vol_tower1 => Scenario.TriggerVolumes[106].GameObject;
        public ITriggerVolume vol_tower1_see_hg => Scenario.TriggerVolumes[107].GameObject;
        public ITriggerVolume vol_tower1_upper => Scenario.TriggerVolumes[108].GameObject;
        public ITriggerVolume birds_00 => Scenario.TriggerVolumes[109].GameObject;
        public ITriggerVolume vol_tower1_all => Scenario.TriggerVolumes[110].GameObject;
        public ITriggerVolume vol_bridge_ghost_spawn => Scenario.TriggerVolumes[111].GameObject;
        public ITriggerVolume vol_bunker_parking => Scenario.TriggerVolumes[112].GameObject;
        public ITriggerVolume vol_arbiter_envy => Scenario.TriggerVolumes[113].GameObject;
        public ITriggerVolume vol_lights_on_04 => Scenario.TriggerVolumes[114].GameObject;
        public ITriggerVolume vol_lights_on_01 => Scenario.TriggerVolumes[115].GameObject;
        public ITriggerVolume vol_lights_on_02 => Scenario.TriggerVolumes[116].GameObject;
        public ITriggerVolume vol_lights_on_03 => Scenario.TriggerVolumes[117].GameObject;
        public ITriggerVolume vol_lights_on_05 => Scenario.TriggerVolumes[118].GameObject;
        public ITriggerVolume vol_lights_on_06 => Scenario.TriggerVolumes[119].GameObject;
        public ITriggerVolume kill_approach_ramp => Scenario.TriggerVolumes[120].GameObject;
        public IStartingProfile profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IDeviceGroup gondola_01 => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup slanty_elev_01 => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup slanty_elev_02 => Scenario.DeviceGroupDefinitions[2].GameObject;
        public IDeviceGroup gondola_02 => Scenario.DeviceGroupDefinitions[3].GameObject;
        public IDeviceGroup da_bridge1 => Scenario.DeviceGroupDefinitions[4].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            anchor_x05 = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            carrier = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            iac = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            cigar = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            hev_01 = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            hev_02 = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            hev_03 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            hev_04 = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            hev_05 = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            hev_06 = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            hev_07 = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            hev_08 = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            hev_09 = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            hev_10 = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            hev_11 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            hev_12 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            hev_13 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            hev_14 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            hev_15 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            hev_16 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            hev_17 = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            hev_bay = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            anchor_intro = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            rocket_01 = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            iac_bridge = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            bunker_throne = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            courtyard_prophet = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            tower1_throne = new ScenarioEntity<IScenery>(27, scenarioTag.WellKnownItems[27]);
            matte_substance = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            matte_alpha_halo = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            matte_delta_halo_close = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            matte_clouds_01 = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            matte_clouds_02 = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            matte_horizon = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            matte_islands = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            intro_crate_01 = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            intro_crate_02 = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            smg_01 = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            corona_02 = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            corona_01 = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            corona_03 = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            corona_04 = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            corona_05 = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            corona_06 = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            corona_07 = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            bomb01 = new ScenarioEntity<IBloc>(45, scenarioTag.WellKnownItems[45]);
            bomb02 = new ScenarioEntity<IBloc>(46, scenarioTag.WellKnownItems[46]);
            bomb03 = new ScenarioEntity<IBloc>(47, scenarioTag.WellKnownItems[47]);
            bomb04 = new ScenarioEntity<IBloc>(48, scenarioTag.WellKnownItems[48]);
            bomb05 = new ScenarioEntity<IBloc>(49, scenarioTag.WellKnownItems[49]);
            bomb06 = new ScenarioEntity<IBloc>(50, scenarioTag.WellKnownItems[50]);
            rack = new ScenarioEntity<IScenery>(51, scenarioTag.WellKnownItems[51]);
            court_throne_attach = new ScenarioEntity<IScenery>(52, scenarioTag.WellKnownItems[52]);
            court_throne = new ScenarioEntity<IScenery>(53, scenarioTag.WellKnownItems[53]);
            court_gen = new ScenarioEntity<IScenery>(54, scenarioTag.WellKnownItems[54]);
            x05_debris = new ScenarioEntity<IScenery>(55, scenarioTag.WellKnownItems[55]);
            texture_camera = new ScenarioEntity<IScenery>(56, scenarioTag.WellKnownItems[56]);
            x05_slipspace = new ScenarioEntity<IScenery>(57, scenarioTag.WellKnownItems[57]);
            hev_close_01 = new ScenarioEntity<IScenery>(58, scenarioTag.WellKnownItems[58]);
            hev_close_02 = new ScenarioEntity<IScenery>(59, scenarioTag.WellKnownItems[59]);
            hev_close_03 = new ScenarioEntity<IScenery>(60, scenarioTag.WellKnownItems[60]);
            hev_close_04 = new ScenarioEntity<IScenery>(61, scenarioTag.WellKnownItems[61]);
            hev_close_05 = new ScenarioEntity<IScenery>(62, scenarioTag.WellKnownItems[62]);
            hev_close_06 = new ScenarioEntity<IScenery>(63, scenarioTag.WellKnownItems[63]);
            hev_close_07 = new ScenarioEntity<IScenery>(64, scenarioTag.WellKnownItems[64]);
            hev_close_08 = new ScenarioEntity<IScenery>(65, scenarioTag.WellKnownItems[65]);
            tree_toy = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            hev_chute = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            delta_halo = new ScenarioEntity<IScenery>(68, scenarioTag.WellKnownItems[68]);
            intro_fire = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            chief = new ScenarioEntity<IUnit>(70, scenarioTag.WellKnownItems[70]);
            miranda = new ScenarioEntity<IUnit>(71, scenarioTag.WellKnownItems[71]);
            johnson = new ScenarioEntity<IUnit>(72, scenarioTag.WellKnownItems[72]);
            nav_officer = new ScenarioEntity<IUnit>(73, scenarioTag.WellKnownItems[73]);
            weap_officer = new ScenarioEntity<IUnit>(74, scenarioTag.WellKnownItems[74]);
            jackal_01 = new ScenarioEntity<IUnit>(75, scenarioTag.WellKnownItems[75]);
            grunt_01 = new ScenarioEntity<IUnit>(76, scenarioTag.WellKnownItems[76]);
            chief_intro = new ScenarioEntity<IUnit>(77, scenarioTag.WellKnownItems[77]);
            regret02 = new ScenarioEntity<IUnit>(78, scenarioTag.WellKnownItems[78]);
            regret01 = new ScenarioEntity<IUnit>(79, scenarioTag.WellKnownItems[79]);
            regret03 = new ScenarioEntity<IUnit>(80, scenarioTag.WellKnownItems[80]);
            chief_toy = new ScenarioEntity<IUnit>(81, scenarioTag.WellKnownItems[81]);
            grunt_toy = new ScenarioEntity<IUnit>(82, scenarioTag.WellKnownItems[82]);
            lz_hog = new ScenarioEntity<IVehicle>(83, scenarioTag.WellKnownItems[83]);
            bridge_tank = new ScenarioEntity<IVehicle>(84, scenarioTag.WellKnownItems[84]);
            intro_turret = new ScenarioEntity<IVehicle>(85, scenarioTag.WellKnownItems[85]);
            intro_turret_02 = new ScenarioEntity<IVehicle>(86, scenarioTag.WellKnownItems[86]);
            toys_07 = new ScenarioEntity<IStartingProfile>(87, scenarioTag.WellKnownItems[87]);
            toys_08 = new ScenarioEntity<IStartingProfile>(88, scenarioTag.WellKnownItems[88]);
            toys_09 = new ScenarioEntity<IStartingProfile>(89, scenarioTag.WellKnownItems[89]);
            toys_10 = new ScenarioEntity<IStartingProfile>(90, scenarioTag.WellKnownItems[90]);
            grenade_toy_01 = new ScenarioEntity<IStartingProfile>(91, scenarioTag.WellKnownItems[91]);
            grenade_toy_02 = new ScenarioEntity<IStartingProfile>(92, scenarioTag.WellKnownItems[92]);
            toys_01 = new ScenarioEntity<IWeapon>(93, scenarioTag.WellKnownItems[93]);
            toys_02 = new ScenarioEntity<IWeapon>(94, scenarioTag.WellKnownItems[94]);
            toys_03 = new ScenarioEntity<IWeapon>(95, scenarioTag.WellKnownItems[95]);
            toys_04 = new ScenarioEntity<IWeapon>(96, scenarioTag.WellKnownItems[96]);
            toys_05 = new ScenarioEntity<IWeapon>(97, scenarioTag.WellKnownItems[97]);
            toys_06 = new ScenarioEntity<IWeapon>(98, scenarioTag.WellKnownItems[98]);
            turret_handheld = new ScenarioEntity<IWeapon>(99, scenarioTag.WellKnownItems[99]);
            turret_handheld_02 = new ScenarioEntity<IWeapon>(100, scenarioTag.WellKnownItems[100]);
            envy = new ScenarioEntity<IWeapon>(101, scenarioTag.WellKnownItems[101]);
            jackal_shield = new ScenarioEntity<IWeapon>(102, scenarioTag.WellKnownItems[102]);
            waterfall_far = new ScenarioEntity<ISound>(103, scenarioTag.WellKnownItems[103]);
            waterfall_close = new ScenarioEntity<ISound>(104, scenarioTag.WellKnownItems[104]);
            da_bridge = new ScenarioEntity<IDevice>(105, scenarioTag.WellKnownItems[105]);
            da_bridge_switch = new ScenarioEntity<IDevice>(106, scenarioTag.WellKnownItems[106]);
            real_bridge = new ScenarioEntity<IDevice>(107, scenarioTag.WellKnownItems[107]);
            allies_lz_ledge = new Squad_allies_lz_ledge(scenarioTag);
            allies_lz_ridge = new Squad_allies_lz_ridge(scenarioTag);
            LZ_turrets_01 = new Squad_LZ_turrets_01(scenarioTag);
            LZ_turrets_02 = new Squad_LZ_turrets_02(scenarioTag);
            LZ_turrets_03 = new Squad_LZ_turrets_03(scenarioTag);
            LZ_turrets_04 = new Squad_LZ_turrets_04(scenarioTag);
            LZ_elites_ledge = new Squad_LZ_elites_ledge(scenarioTag);
            LZ_grunts_ledge = new Squad_LZ_grunts_ledge(scenarioTag);
            LZ_elites_ridge = new Squad_LZ_elites_ridge(scenarioTag);
            LZ_grunts_ridge = new Squad_LZ_grunts_ridge(scenarioTag);
            LZ_jackals_ridge = new Squad_LZ_jackals_ridge(scenarioTag);
            LZ_elites_yard = new Squad_LZ_elites_yard(scenarioTag);
            LZ_grunts_yard = new Squad_LZ_grunts_yard(scenarioTag);
            LZ_jackals_yard = new Squad_LZ_jackals_yard(scenarioTag);
            LZ_elites_structure = new Squad_LZ_elites_structure(scenarioTag);
            LZ_grunts_structure = new Squad_LZ_grunts_structure(scenarioTag);
            LZ_jackals_structure = new Squad_LZ_jackals_structure(scenarioTag);
            LZ_elites_bunkered = new Squad_LZ_elites_bunkered(scenarioTag);
            LZ_grunts_bunkered = new Squad_LZ_grunts_bunkered(scenarioTag);
            LZ_phantom_01 = new Squad_LZ_phantom_01(scenarioTag);
            LZ_elites_phantom_01 = new Squad_LZ_elites_phantom_01(scenarioTag);
            LZ_grunts_phantom_01 = new Squad_LZ_grunts_phantom_01(scenarioTag);
            LZ_jackals_phantom_01 = new Squad_LZ_jackals_phantom_01(scenarioTag);
            LZ_phantom_02 = new Squad_LZ_phantom_02(scenarioTag);
            LZ_elites_phantom_02 = new Squad_LZ_elites_phantom_02(scenarioTag);
            LZ_grunts_phantom_02 = new Squad_LZ_grunts_phantom_02(scenarioTag);
            LZ_jackals_phantom_02 = new Squad_LZ_jackals_phantom_02(scenarioTag);
            LZ_stealth_phantom_03 = new Squad_LZ_stealth_phantom_03(scenarioTag);
            LZ_pelican_01 = new Squad_LZ_pelican_01(scenarioTag);
            LZ_pelican_02 = new Squad_LZ_pelican_02(scenarioTag);
            LZ_warthog_01 = new Squad_LZ_warthog_01(scenarioTag);
            allies_lz_pelican = new Squad_allies_lz_pelican(scenarioTag);
            overlook_jackals_011 = new Squad_overlook_jackals_011(scenarioTag);
            overlook_jackals_021 = new Squad_overlook_jackals_021(scenarioTag);
            bridge_free_ghost = new Squad_bridge_free_ghost(scenarioTag);
            bridge_farside_wraiths = new Squad_bridge_farside_wraiths(scenarioTag);
            bridge_bunker_turrets1 = new Squad_bridge_bunker_turrets1(scenarioTag);
            bridge_bunker_ghosts = new Squad_bridge_bunker_ghosts(scenarioTag);
            bridge_ghost_elites = new Squad_bridge_ghost_elites(scenarioTag);
            bridge_turret_grunts_01 = new Squad_bridge_turret_grunts_01(scenarioTag);
            bridge_turret_grunts_02 = new Squad_bridge_turret_grunts_02(scenarioTag);
            bridge_bunker_elites_01 = new Squad_bridge_bunker_elites_01(scenarioTag);
            bridge_bunker_elites_02 = new Squad_bridge_bunker_elites_02(scenarioTag);
            bridge_bunker_jackals_01 = new Squad_bridge_bunker_jackals_01(scenarioTag);
            bridge_bunker_jackals_02 = new Squad_bridge_bunker_jackals_02(scenarioTag);
            bridge_bunker_grunts_01 = new Squad_bridge_bunker_grunts_01(scenarioTag);
            bridge_bunker_grunts_02 = new Squad_bridge_bunker_grunts_02(scenarioTag);
            bunker_turret_remen = new Squad_bunker_turret_remen(scenarioTag);
            bridge_crack_jackals = new Squad_bridge_crack_jackals(scenarioTag);
            bridge_crack_grunts = new Squad_bridge_crack_grunts(scenarioTag);
            bridge_backdoor_elites_01 = new Squad_bridge_backdoor_elites_01(scenarioTag);
            bridge_backdoor_jackals_01 = new Squad_bridge_backdoor_jackals_01(scenarioTag);
            bridge_backdoor_grunts_01 = new Squad_bridge_backdoor_grunts_01(scenarioTag);
            bridge_control_elites_01 = new Squad_bridge_control_elites_01(scenarioTag);
            bridge_control_jackals_01 = new Squad_bridge_control_jackals_01(scenarioTag);
            bridge_control_grunts_01 = new Squad_bridge_control_grunts_01(scenarioTag);
            allies_bridge_bunker1 = new Squad_allies_bridge_bunker1(scenarioTag);
            bridge_phantom_01 = new Squad_bridge_phantom_01(scenarioTag);
            bridge_phantom_ghosts_01 = new Squad_bridge_phantom_ghosts_01(scenarioTag);
            bridge_phantom_02 = new Squad_bridge_phantom_02(scenarioTag);
            bridge_phantom_ghosts_02 = new Squad_bridge_phantom_ghosts_02(scenarioTag);
            bridge_farside_ghosts = new Squad_bridge_farside_ghosts(scenarioTag);
            bridge_banshees = new Squad_bridge_banshees(scenarioTag);
            bridge_pelican_chasers = new Squad_bridge_pelican_chasers(scenarioTag);
            bridge_pelican = new Squad_bridge_pelican(scenarioTag);
            bridge_tank1 = new Squad_bridge_tank1(scenarioTag);
            allies_bridge_pelican = new Squad_allies_bridge_pelican(scenarioTag);
            w_path_free_ghost = new Squad_w_path_free_ghost(scenarioTag);
            winding_path_ghosts_01 = new Squad_winding_path_ghosts_01(scenarioTag);
            winding_path_ghosts_02 = new Squad_winding_path_ghosts_02(scenarioTag);
            winding_path_grunts = new Squad_winding_path_grunts(scenarioTag);
            w_path_heavies = new Squad_w_path_heavies(scenarioTag);
            winding_path_ledge_grunts = new Squad_winding_path_ledge_grunts(scenarioTag);
            winding_path_jackals = new Squad_winding_path_jackals(scenarioTag);
            temple_ent_turrets_01 = new Squad_temple_ent_turrets_01(scenarioTag);
            temple_ent_turrets_02 = new Squad_temple_ent_turrets_02(scenarioTag);
            temple_ent_turrets_03 = new Squad_temple_ent_turrets_03(scenarioTag);
            temple_ent_turrets_04 = new Squad_temple_ent_turrets_04(scenarioTag);
            temple_ent_elites_01l = new Squad_temple_ent_elites_01l(scenarioTag);
            temple_ent_elites_01r = new Squad_temple_ent_elites_01r(scenarioTag);
            temple_ent_elites_02l = new Squad_temple_ent_elites_02l(scenarioTag);
            temple_ent_elites_02r = new Squad_temple_ent_elites_02r(scenarioTag);
            temple_ent_jackals_01l = new Squad_temple_ent_jackals_01l(scenarioTag);
            temple_ent_jackals_01r = new Squad_temple_ent_jackals_01r(scenarioTag);
            temple_ent_jackals_02c = new Squad_temple_ent_jackals_02c(scenarioTag);
            temple_ent_bugs_01l = new Squad_temple_ent_bugs_01l(scenarioTag);
            temple_ent_bugs_01c = new Squad_temple_ent_bugs_01c(scenarioTag);
            temple_ent_bugs_01r = new Squad_temple_ent_bugs_01r(scenarioTag);
            temple_ent_bugs_02l = new Squad_temple_ent_bugs_02l(scenarioTag);
            temple_ent_bugs_02c = new Squad_temple_ent_bugs_02c(scenarioTag);
            temple_ent_bugs_02r = new Squad_temple_ent_bugs_02r(scenarioTag);
            temple_ent_grunts_01l = new Squad_temple_ent_grunts_01l(scenarioTag);
            temple_ent_grunts_01r = new Squad_temple_ent_grunts_01r(scenarioTag);
            temple_ent_ghosts_01 = new Squad_temple_ent_ghosts_01(scenarioTag);
            temple_ent_ghosts_02 = new Squad_temple_ent_ghosts_02(scenarioTag);
            temple_ent_banshees = new Squad_temple_ent_banshees(scenarioTag);
            tunnel_ghosts_011 = new Squad_tunnel_ghosts_011(scenarioTag);
            tunnel_ghosts_021 = new Squad_tunnel_ghosts_021(scenarioTag);
            tunnel_grunts = new Squad_tunnel_grunts(scenarioTag);
            tunnel_jackals = new Squad_tunnel_jackals(scenarioTag);
            tunnel_heavies_01 = new Squad_tunnel_heavies_01(scenarioTag);
            tunnel_heavies_02 = new Squad_tunnel_heavies_02(scenarioTag);
            old_temple_turrets = new Squad_old_temple_turrets(scenarioTag);
            old_temple_grunts_near_left = new Squad_old_temple_grunts_near_left(scenarioTag);
            old_temple_grunts_far_left = new Squad_old_temple_grunts_far_left(scenarioTag);
            old_temple_grunts_far_right = new Squad_old_temple_grunts_far_right(scenarioTag);
            old_temple_grunts_center = new Squad_old_temple_grunts_center(scenarioTag);
            old_temple_elites_near_right = new Squad_old_temple_elites_near_right(scenarioTag);
            old_temple_jackals_near_right = new Squad_old_temple_jackals_near_right(scenarioTag);
            old_temple_jackals_below_far = new Squad_old_temple_jackals_below_far(scenarioTag);
            old_temple_jackals_below_near = new Squad_old_temple_jackals_below_near(scenarioTag);
            old_temple_jackals_sea_01 = new Squad_old_temple_jackals_sea_01(scenarioTag);
            old_temple_jackals_sea_02 = new Squad_old_temple_jackals_sea_02(scenarioTag);
            old_temple_jackals_debris = new Squad_old_temple_jackals_debris(scenarioTag);
            old_temple_jackals_corner = new Squad_old_temple_jackals_corner(scenarioTag);
            old_temple_jackals_shrine_L = new Squad_old_temple_jackals_shrine_L(scenarioTag);
            old_temple_jackals_shrine_R = new Squad_old_temple_jackals_shrine_R(scenarioTag);
            old_temple_init_elites_fl = new Squad_old_temple_init_elites_fl(scenarioTag);
            old_temple_init_jackals_fl = new Squad_old_temple_init_jackals_fl(scenarioTag);
            old_temple_init_jackals_nl = new Squad_old_temple_init_jackals_nl(scenarioTag);
            old_temple_init_elites_nr = new Squad_old_temple_init_elites_nr(scenarioTag);
            old_temple_init_jackals_nr = new Squad_old_temple_init_jackals_nr(scenarioTag);
            old_temple_ghosts_far = new Squad_old_temple_ghosts_far(scenarioTag);
            old_temple_phantom1 = new Squad_old_temple_phantom1(scenarioTag);
            old_temple_ghosts_air = new Squad_old_temple_ghosts_air(scenarioTag);
            old_temple_banshees = new Squad_old_temple_banshees(scenarioTag);
            old_temple_pelican1 = new Squad_old_temple_pelican1(scenarioTag);
            allies_old_temple_pelican = new Squad_allies_old_temple_pelican(scenarioTag);
            allies_old_temple_real = new Squad_allies_old_temple_real(scenarioTag);
            old_temple_playfight_e = new Squad_old_temple_playfight_e(scenarioTag);
            old_temple_playfight_g = new Squad_old_temple_playfight_g(scenarioTag);
            old_temple_center_elites_01 = new Squad_old_temple_center_elites_01(scenarioTag);
            old_temple_center_grunts_01 = new Squad_old_temple_center_grunts_01(scenarioTag);
            old_temple_center_grunts_03 = new Squad_old_temple_center_grunts_03(scenarioTag);
            old_temple_center_jackals_04 = new Squad_old_temple_center_jackals_04(scenarioTag);
            old_temple_center_grunts_04 = new Squad_old_temple_center_grunts_04(scenarioTag);
            old_temple_center_elites_05 = new Squad_old_temple_center_elites_05(scenarioTag);
            old_temple_center_jackals_05 = new Squad_old_temple_center_jackals_05(scenarioTag);
            old_temple_courtyard_lure = new Squad_old_temple_courtyard_lure(scenarioTag);
            old_temple_court_elites_01 = new Squad_old_temple_court_elites_01(scenarioTag);
            old_temple_court_grunts_01 = new Squad_old_temple_court_grunts_01(scenarioTag);
            old_temple_court_grunts_02 = new Squad_old_temple_court_grunts_02(scenarioTag);
            old_temple_court_jackals_03 = new Squad_old_temple_court_jackals_03(scenarioTag);
            old_temple_court_grunts_03 = new Squad_old_temple_court_grunts_03(scenarioTag);
            old_temple_court_jackals_04 = new Squad_old_temple_court_jackals_04(scenarioTag);
            old_temple_court_elites_05 = new Squad_old_temple_court_elites_05(scenarioTag);
            old_temple_court_jackals_05 = new Squad_old_temple_court_jackals_05(scenarioTag);
            old_temple_court_jackals_06 = new Squad_old_temple_court_jackals_06(scenarioTag);
            old_temple_court_grunts_06 = new Squad_old_temple_court_grunts_06(scenarioTag);
            courtyard_grunts_end = new Squad_courtyard_grunts_end(scenarioTag);
            old_temp_court_phantom = new Squad_old_temp_court_phantom(scenarioTag);
            grotto_init_01 = new Squad_grotto_init_01(scenarioTag);
            grotto_init_02 = new Squad_grotto_init_02(scenarioTag);
            grotto_init_03 = new Squad_grotto_init_03(scenarioTag);
            grotto_init_04 = new Squad_grotto_init_04(scenarioTag);
            grotto_init_05 = new Squad_grotto_init_05(scenarioTag);
            grotto_init_06 = new Squad_grotto_init_06(scenarioTag);
            grotto_init_07 = new Squad_grotto_init_07(scenarioTag);
            grotto_init_08 = new Squad_grotto_init_08(scenarioTag);
            grotto_init_09 = new Squad_grotto_init_09(scenarioTag);
            grotto_init_10 = new Squad_grotto_init_10(scenarioTag);
            grotto_init_11 = new Squad_grotto_init_11(scenarioTag);
            grotto_buggers_new_01 = new Squad_grotto_buggers_new_01(scenarioTag);
            grotto_sleepers = new Squad_grotto_sleepers(scenarioTag);
            grotto_crack_grunts = new Squad_grotto_crack_grunts(scenarioTag);
            grotto_pool_grunts = new Squad_grotto_pool_grunts(scenarioTag);
            grotto_cave_elites = new Squad_grotto_cave_elites(scenarioTag);
            grotto_cave_jackals_01 = new Squad_grotto_cave_jackals_01(scenarioTag);
            grotto_cave_jackals_02 = new Squad_grotto_cave_jackals_02(scenarioTag);
            grotto_cave_jackals_03 = new Squad_grotto_cave_jackals_03(scenarioTag);
            grotto_buggers_01 = new Squad_grotto_buggers_01(scenarioTag);
            grotto_buggers_02 = new Squad_grotto_buggers_02(scenarioTag);
            grotto_buggers_03 = new Squad_grotto_buggers_03(scenarioTag);
            grotto_end_elites_01 = new Squad_grotto_end_elites_01(scenarioTag);
            grotto_end_elites_02 = new Squad_grotto_end_elites_02(scenarioTag);
            grotto_end_jackals_01 = new Squad_grotto_end_jackals_01(scenarioTag);
            grotto_end_jackals_02 = new Squad_grotto_end_jackals_02(scenarioTag);
            grotto_end_jackals_03 = new Squad_grotto_end_jackals_03(scenarioTag);
            grotto_grunts_end = new Squad_grotto_grunts_end(scenarioTag);
            approach_buggers1 = new Squad_approach_buggers1(scenarioTag);
            approach_buggers_too1 = new Squad_approach_buggers_too1(scenarioTag);
            approach_jackal_01 = new Squad_approach_jackal_01(scenarioTag);
            approach_jackal_02 = new Squad_approach_jackal_02(scenarioTag);
            approach_jackal_03 = new Squad_approach_jackal_03(scenarioTag);
            approach_elite_01 = new Squad_approach_elite_01(scenarioTag);
            approach_elite_02 = new Squad_approach_elite_02(scenarioTag);
            approach_elite_03 = new Squad_approach_elite_03(scenarioTag);
            approach_grunts_01 = new Squad_approach_grunts_01(scenarioTag);
            tower1_hg_01a = new Squad_tower1_hg_01a(scenarioTag);
            tower1_hg_01b = new Squad_tower1_hg_01b(scenarioTag);
            tower1_hg_02a = new Squad_tower1_hg_02a(scenarioTag);
            tower1_hg_02b = new Squad_tower1_hg_02b(scenarioTag);
            tower1_grunts_01 = new Squad_tower1_grunts_01(scenarioTag);
            tower1_grunts_02 = new Squad_tower1_grunts_02(scenarioTag);
            test = new Squad_test(scenarioTag);
            jets = new Squad_jets(scenarioTag);
            envy_elites = new Squad_envy_elites(scenarioTag);
        }
    }
}