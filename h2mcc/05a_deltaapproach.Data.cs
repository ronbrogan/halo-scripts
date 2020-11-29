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
        public Squad_allies_lz_ledge allies_lz_ledge { get; set; }
        public Squad_allies_lz_ridge allies_lz_ridge { get; set; }
        public Squad_LZ_turrets_01 LZ_turrets_01 { get; set; }
        public Squad_LZ_turrets_02 LZ_turrets_02 { get; set; }
        public Squad_LZ_turrets_03 LZ_turrets_03 { get; set; }
        public Squad_LZ_turrets_04 LZ_turrets_04 { get; set; }
        public Squad_LZ_elites_ledge LZ_elites_ledge { get; set; }
        public Squad_LZ_grunts_ledge LZ_grunts_ledge { get; set; }
        public Squad_LZ_elites_ridge LZ_elites_ridge { get; set; }
        public Squad_LZ_grunts_ridge LZ_grunts_ridge { get; set; }
        public Squad_LZ_jackals_ridge LZ_jackals_ridge { get; set; }
        public Squad_LZ_elites_yard LZ_elites_yard { get; set; }
        public Squad_LZ_grunts_yard LZ_grunts_yard { get; set; }
        public Squad_LZ_jackals_yard LZ_jackals_yard { get; set; }
        public Squad_LZ_elites_structure LZ_elites_structure { get; set; }
        public Squad_LZ_grunts_structure LZ_grunts_structure { get; set; }
        public Squad_LZ_jackals_structure LZ_jackals_structure { get; set; }
        public Squad_LZ_elites_bunkered LZ_elites_bunkered { get; set; }
        public Squad_LZ_grunts_bunkered LZ_grunts_bunkered { get; set; }
        public Squad_LZ_phantom_01 LZ_phantom_01 { get; set; }
        public Squad_LZ_elites_phantom_01 LZ_elites_phantom_01 { get; set; }
        public Squad_LZ_grunts_phantom_01 LZ_grunts_phantom_01 { get; set; }
        public Squad_LZ_jackals_phantom_01 LZ_jackals_phantom_01 { get; set; }
        public Squad_LZ_phantom_02 LZ_phantom_02 { get; set; }
        public Squad_LZ_elites_phantom_02 LZ_elites_phantom_02 { get; set; }
        public Squad_LZ_grunts_phantom_02 LZ_grunts_phantom_02 { get; set; }
        public Squad_LZ_jackals_phantom_02 LZ_jackals_phantom_02 { get; set; }
        public Squad_LZ_stealth_phantom_03 LZ_stealth_phantom_03 { get; set; }
        public Squad_LZ_pelican_01 LZ_pelican_01 { get; set; }
        public Squad_LZ_pelican_02 LZ_pelican_02 { get; set; }
        public Squad_LZ_warthog_01 LZ_warthog_01 { get; set; }
        public Squad_allies_lz_pelican allies_lz_pelican { get; set; }
        public Squad_overlook_jackals_01 overlook_jackals_01 { get; set; }
        public Squad_overlook_jackals_02 overlook_jackals_02 { get; set; }
        public Squad_bridge_free_ghost bridge_free_ghost { get; set; }
        public Squad_bridge_farside_wraiths bridge_farside_wraiths { get; set; }
        public Squad_bridge_bunker_turrets bridge_bunker_turrets { get; set; }
        public Squad_bridge_bunker_ghosts bridge_bunker_ghosts { get; set; }
        public Squad_bridge_ghost_elites bridge_ghost_elites { get; set; }
        public Squad_bridge_turret_grunts_01 bridge_turret_grunts_01 { get; set; }
        public Squad_bridge_turret_grunts_02 bridge_turret_grunts_02 { get; set; }
        public Squad_bridge_bunker_elites_01 bridge_bunker_elites_01 { get; set; }
        public Squad_bridge_bunker_elites_02 bridge_bunker_elites_02 { get; set; }
        public Squad_bridge_bunker_jackals_01 bridge_bunker_jackals_01 { get; set; }
        public Squad_bridge_bunker_jackals_02 bridge_bunker_jackals_02 { get; set; }
        public Squad_bridge_bunker_grunts_01 bridge_bunker_grunts_01 { get; set; }
        public Squad_bridge_bunker_grunts_02 bridge_bunker_grunts_02 { get; set; }
        public Squad_bunker_turret_remen bunker_turret_remen { get; set; }
        public Squad_bridge_crack_jackals bridge_crack_jackals { get; set; }
        public Squad_bridge_crack_grunts bridge_crack_grunts { get; set; }
        public Squad_bridge_backdoor_elites_01 bridge_backdoor_elites_01 { get; set; }
        public Squad_bridge_backdoor_jackals_01 bridge_backdoor_jackals_01 { get; set; }
        public Squad_bridge_backdoor_grunts_01 bridge_backdoor_grunts_01 { get; set; }
        public Squad_bridge_control_elites_01 bridge_control_elites_01 { get; set; }
        public Squad_bridge_control_jackals_01 bridge_control_jackals_01 { get; set; }
        public Squad_bridge_control_grunts_01 bridge_control_grunts_01 { get; set; }
        public Squad_allies_bridge_bunker allies_bridge_bunker { get; set; }
        public Squad_bridge_phantom_01 bridge_phantom_01 { get; set; }
        public Squad_bridge_phantom_ghosts_01 bridge_phantom_ghosts_01 { get; set; }
        public Squad_bridge_phantom_02 bridge_phantom_02 { get; set; }
        public Squad_bridge_phantom_ghosts_02 bridge_phantom_ghosts_02 { get; set; }
        public Squad_bridge_farside_ghosts bridge_farside_ghosts { get; set; }
        public Squad_bridge_banshees bridge_banshees { get; set; }
        public Squad_bridge_pelican_chasers bridge_pelican_chasers { get; set; }
        public Squad_bridge_pelican bridge_pelican { get; set; }
        public Squad_bridge_tank1 bridge_tank1 { get; set; }
        public Squad_allies_bridge_pelican allies_bridge_pelican { get; set; }
        public Squad_w_path_free_ghost w_path_free_ghost { get; set; }
        public Squad_winding_path_ghosts_01 winding_path_ghosts_01 { get; set; }
        public Squad_winding_path_ghosts_02 winding_path_ghosts_02 { get; set; }
        public Squad_winding_path_grunts winding_path_grunts { get; set; }
        public Squad_w_path_heavies w_path_heavies { get; set; }
        public Squad_winding_path_ledge_grunts winding_path_ledge_grunts { get; set; }
        public Squad_winding_path_jackals winding_path_jackals { get; set; }
        public Squad_temple_ent_turrets_01 temple_ent_turrets_01 { get; set; }
        public Squad_temple_ent_turrets_02 temple_ent_turrets_02 { get; set; }
        public Squad_temple_ent_turrets_03 temple_ent_turrets_03 { get; set; }
        public Squad_temple_ent_turrets_04 temple_ent_turrets_04 { get; set; }
        public Squad_temple_ent_elites_01l temple_ent_elites_01l { get; set; }
        public Squad_temple_ent_elites_01r temple_ent_elites_01r { get; set; }
        public Squad_temple_ent_elites_02l temple_ent_elites_02l { get; set; }
        public Squad_temple_ent_elites_02r temple_ent_elites_02r { get; set; }
        public Squad_temple_ent_jackals_01l temple_ent_jackals_01l { get; set; }
        public Squad_temple_ent_jackals_01r temple_ent_jackals_01r { get; set; }
        public Squad_temple_ent_jackals_02c temple_ent_jackals_02c { get; set; }
        public Squad_temple_ent_bugs_01l temple_ent_bugs_01l { get; set; }
        public Squad_temple_ent_bugs_01c temple_ent_bugs_01c { get; set; }
        public Squad_temple_ent_bugs_01r temple_ent_bugs_01r { get; set; }
        public Squad_temple_ent_bugs_02l temple_ent_bugs_02l { get; set; }
        public Squad_temple_ent_bugs_02c temple_ent_bugs_02c { get; set; }
        public Squad_temple_ent_bugs_02r temple_ent_bugs_02r { get; set; }
        public Squad_temple_ent_grunts_01l temple_ent_grunts_01l { get; set; }
        public Squad_temple_ent_grunts_01r temple_ent_grunts_01r { get; set; }
        public Squad_temple_ent_ghosts_01 temple_ent_ghosts_01 { get; set; }
        public Squad_temple_ent_ghosts_02 temple_ent_ghosts_02 { get; set; }
        public Squad_temple_ent_banshees temple_ent_banshees { get; set; }
        public Squad_tunnel_ghosts_01 tunnel_ghosts_01 { get; set; }
        public Squad_tunnel_ghosts_02 tunnel_ghosts_02 { get; set; }
        public Squad_tunnel_grunts tunnel_grunts { get; set; }
        public Squad_tunnel_jackals tunnel_jackals { get; set; }
        public Squad_tunnel_heavies_01 tunnel_heavies_01 { get; set; }
        public Squad_tunnel_heavies_02 tunnel_heavies_02 { get; set; }
        public Squad_old_temple_turrets old_temple_turrets { get; set; }
        public Squad_old_temple_grunts_near_left old_temple_grunts_near_left { get; set; }
        public Squad_old_temple_grunts_far_left old_temple_grunts_far_left { get; set; }
        public Squad_old_temple_grunts_far_right old_temple_grunts_far_right { get; set; }
        public Squad_old_temple_grunts_center old_temple_grunts_center { get; set; }
        public Squad_old_temple_elites_near_right old_temple_elites_near_right { get; set; }
        public Squad_old_temple_jackals_near_right old_temple_jackals_near_right { get; set; }
        public Squad_old_temple_jackals_below_far old_temple_jackals_below_far { get; set; }
        public Squad_old_temple_jackals_below_near old_temple_jackals_below_near { get; set; }
        public Squad_old_temple_jackals_sea_01 old_temple_jackals_sea_01 { get; set; }
        public Squad_old_temple_jackals_sea_02 old_temple_jackals_sea_02 { get; set; }
        public Squad_old_temple_jackals_debris old_temple_jackals_debris { get; set; }
        public Squad_old_temple_jackals_corner old_temple_jackals_corner { get; set; }
        public Squad_old_temple_jackals_shrine_L old_temple_jackals_shrine_L { get; set; }
        public Squad_old_temple_jackals_shrine_R old_temple_jackals_shrine_R { get; set; }
        public Squad_old_temple_init_elites_fl old_temple_init_elites_fl { get; set; }
        public Squad_old_temple_init_jackals_fl old_temple_init_jackals_fl { get; set; }
        public Squad_old_temple_init_jackals_nl old_temple_init_jackals_nl { get; set; }
        public Squad_old_temple_init_elites_nr old_temple_init_elites_nr { get; set; }
        public Squad_old_temple_init_jackals_nr old_temple_init_jackals_nr { get; set; }
        public Squad_old_temple_ghosts_far old_temple_ghosts_far { get; set; }
        public Squad_old_temple_phantom old_temple_phantom { get; set; }
        public Squad_old_temple_ghosts_air old_temple_ghosts_air { get; set; }
        public Squad_old_temple_banshees old_temple_banshees { get; set; }
        public Squad_old_temple_pelican1 old_temple_pelican1 { get; set; }
        public Squad_allies_old_temple_pelican allies_old_temple_pelican { get; set; }
        public Squad_allies_old_temple_real allies_old_temple_real { get; set; }
        public Squad_old_temple_playfight_e old_temple_playfight_e { get; set; }
        public Squad_old_temple_playfight_g old_temple_playfight_g { get; set; }
        public Squad_old_temple_center_elites_01 old_temple_center_elites_01 { get; set; }
        public Squad_old_temple_center_grunts_01 old_temple_center_grunts_01 { get; set; }
        public Squad_old_temple_center_grunts_03 old_temple_center_grunts_03 { get; set; }
        public Squad_old_temple_center_jackals_04 old_temple_center_jackals_04 { get; set; }
        public Squad_old_temple_center_grunts_04 old_temple_center_grunts_04 { get; set; }
        public Squad_old_temple_center_elites_05 old_temple_center_elites_05 { get; set; }
        public Squad_old_temple_center_jackals_05 old_temple_center_jackals_05 { get; set; }
        public Squad_old_temple_courtyard_lure old_temple_courtyard_lure { get; set; }
        public Squad_old_temple_court_elites_01 old_temple_court_elites_01 { get; set; }
        public Squad_old_temple_court_grunts_01 old_temple_court_grunts_01 { get; set; }
        public Squad_old_temple_court_grunts_02 old_temple_court_grunts_02 { get; set; }
        public Squad_old_temple_court_jackals_03 old_temple_court_jackals_03 { get; set; }
        public Squad_old_temple_court_grunts_03 old_temple_court_grunts_03 { get; set; }
        public Squad_old_temple_court_jackals_04 old_temple_court_jackals_04 { get; set; }
        public Squad_old_temple_court_elites_05 old_temple_court_elites_05 { get; set; }
        public Squad_old_temple_court_jackals_05 old_temple_court_jackals_05 { get; set; }
        public Squad_old_temple_court_jackals_06 old_temple_court_jackals_06 { get; set; }
        public Squad_old_temple_court_grunts_06 old_temple_court_grunts_06 { get; set; }
        public Squad_courtyard_grunts_end courtyard_grunts_end { get; set; }
        public Squad_old_temp_court_phantom old_temp_court_phantom { get; set; }
        public Squad_grotto_init_01 grotto_init_01 { get; set; }
        public Squad_grotto_init_02 grotto_init_02 { get; set; }
        public Squad_grotto_init_03 grotto_init_03 { get; set; }
        public Squad_grotto_init_04 grotto_init_04 { get; set; }
        public Squad_grotto_init_05 grotto_init_05 { get; set; }
        public Squad_grotto_init_06 grotto_init_06 { get; set; }
        public Squad_grotto_init_07 grotto_init_07 { get; set; }
        public Squad_grotto_init_08 grotto_init_08 { get; set; }
        public Squad_grotto_init_09 grotto_init_09 { get; set; }
        public Squad_grotto_init_10 grotto_init_10 { get; set; }
        public Squad_grotto_init_11 grotto_init_11 { get; set; }
        public Squad_grotto_buggers_new_01 grotto_buggers_new_01 { get; set; }
        public Squad_grotto_sleepers grotto_sleepers { get; set; }
        public Squad_grotto_crack_grunts grotto_crack_grunts { get; set; }
        public Squad_grotto_pool_grunts grotto_pool_grunts { get; set; }
        public Squad_grotto_cave_elites grotto_cave_elites { get; set; }
        public Squad_grotto_cave_jackals_01 grotto_cave_jackals_01 { get; set; }
        public Squad_grotto_cave_jackals_02 grotto_cave_jackals_02 { get; set; }
        public Squad_grotto_cave_jackals_03 grotto_cave_jackals_03 { get; set; }
        public Squad_grotto_buggers_01 grotto_buggers_01 { get; set; }
        public Squad_grotto_buggers_02 grotto_buggers_02 { get; set; }
        public Squad_grotto_buggers_03 grotto_buggers_03 { get; set; }
        public Squad_grotto_end_elites_01 grotto_end_elites_01 { get; set; }
        public Squad_grotto_end_elites_02 grotto_end_elites_02 { get; set; }
        public Squad_grotto_end_jackals_01 grotto_end_jackals_01 { get; set; }
        public Squad_grotto_end_jackals_02 grotto_end_jackals_02 { get; set; }
        public Squad_grotto_end_jackals_03 grotto_end_jackals_03 { get; set; }
        public Squad_grotto_grunts_end grotto_grunts_end { get; set; }
        public Squad_approach_buggers approach_buggers { get; set; }
        public Squad_approach_buggers_too approach_buggers_too { get; set; }
        public Squad_approach_jackal_01 approach_jackal_01 { get; set; }
        public Squad_approach_jackal_02 approach_jackal_02 { get; set; }
        public Squad_approach_jackal_03 approach_jackal_03 { get; set; }
        public Squad_approach_elite_01 approach_elite_01 { get; set; }
        public Squad_approach_elite_02 approach_elite_02 { get; set; }
        public Squad_approach_elite_03 approach_elite_03 { get; set; }
        public Squad_approach_grunts_01 approach_grunts_01 { get; set; }
        public Squad_tower1_hg_01a tower1_hg_01a { get; set; }
        public Squad_tower1_hg_01b tower1_hg_01b { get; set; }
        public Squad_tower1_hg_02a tower1_hg_02a { get; set; }
        public Squad_tower1_hg_02b tower1_hg_02b { get; set; }
        public Squad_tower1_grunts_01 tower1_grunts_01 { get; set; }
        public Squad_tower1_grunts_02 tower1_grunts_02 { get; set; }
        public Squad_test test { get; set; }
        public Squad_jets jets { get; set; }
        public Squad_envy_elites envy_elites { get; set; }
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
        public IAiOrders overlook_jackals_011 => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders overlook_jackals_021 => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders allies_bridge_pause => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders allies_bridge_advance => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders bridge_assault => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders bridge_farside_front => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders bridge_farside_back => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders bridge_bunker_low_01 => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders bridge_bunker_high_01 => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders bridge_bunker_turrets1 => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders bridge_crack => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders allies_bridge_bunker1 => Scenario.AiOrderDefinitions[42].GameObject;
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
        public IAiOrders tunnel_ghosts_011 => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders tunnel_ghosts_021 => Scenario.AiOrderDefinitions[94].GameObject;
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
        public IAiOrders old_temple_phantom1 => Scenario.AiOrderDefinitions[138].GameObject;
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
        public IAiOrders approach_buggers1 => Scenario.AiOrderDefinitions[187].GameObject;
        public IAiOrders approach_buggers_too1 => Scenario.AiOrderDefinitions[188].GameObject;
        public IAiOrders tower1_all => Scenario.AiOrderDefinitions[189].GameObject;
        public IAiOrders tower1_hg1a => Scenario.AiOrderDefinitions[190].GameObject;
        public IAiOrders tower1_hg1b => Scenario.AiOrderDefinitions[191].GameObject;
        public IAiOrders tower1_hg1a_back => Scenario.AiOrderDefinitions[192].GameObject;
        public IAiOrders tower1_hg1b_back => Scenario.AiOrderDefinitions[193].GameObject;
        public IAiOrders tower1_hg2b => Scenario.AiOrderDefinitions[194].GameObject;
        public ILocationFlag lz_start_player0 => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag lz_start_player1 => Scenario.LocationFlagDefinitions[1].GameObject;
        public ILocationFlag lz_exit => Scenario.LocationFlagDefinitions[2].GameObject;
        public ILocationFlag bridge_player1 => Scenario.LocationFlagDefinitions[3].GameObject;
        public ILocationFlag bridge_player0 => Scenario.LocationFlagDefinitions[4].GameObject;
        public ILocationFlag winding_path_player0 => Scenario.LocationFlagDefinitions[5].GameObject;
        public ILocationFlag winding_path_player1 => Scenario.LocationFlagDefinitions[6].GameObject;
        public ILocationFlag temple_ent_player0 => Scenario.LocationFlagDefinitions[7].GameObject;
        public ILocationFlag temple_ent_player1 => Scenario.LocationFlagDefinitions[8].GameObject;
        public ILocationFlag tunnel_player0 => Scenario.LocationFlagDefinitions[9].GameObject;
        public ILocationFlag tunnel_player1 => Scenario.LocationFlagDefinitions[10].GameObject;
        public ILocationFlag old_temple_player0 => Scenario.LocationFlagDefinitions[11].GameObject;
        public ILocationFlag old_temple_player1 => Scenario.LocationFlagDefinitions[12].GameObject;
        public ILocationFlag grotto_player0 => Scenario.LocationFlagDefinitions[13].GameObject;
        public ILocationFlag grotto_player1 => Scenario.LocationFlagDefinitions[14].GameObject;
        public ILocationFlag approach_player0 => Scenario.LocationFlagDefinitions[15].GameObject;
        public ILocationFlag approach_player1 => Scenario.LocationFlagDefinitions[16].GameObject;
        public ILocationFlag tower1_player0 => Scenario.LocationFlagDefinitions[17].GameObject;
        public ILocationFlag tower1_player1 => Scenario.LocationFlagDefinitions[18].GameObject;
        public ILocationFlag anchor_flag_x05 => Scenario.LocationFlagDefinitions[19].GameObject;
        public ILocationFlag bunker_1 => Scenario.LocationFlagDefinitions[20].GameObject;
        public ILocationFlag bunker_2 => Scenario.LocationFlagDefinitions[21].GameObject;
        public ILocationFlag anchor_flag_intro => Scenario.LocationFlagDefinitions[22].GameObject;
        public ILocationFlag temp => Scenario.LocationFlagDefinitions[23].GameObject;
        public ILocationFlag seawall_01 => Scenario.LocationFlagDefinitions[24].GameObject;
        public ILocationFlag seawall_02 => Scenario.LocationFlagDefinitions[25].GameObject;
        public ILocationFlag seawall_03 => Scenario.LocationFlagDefinitions[26].GameObject;
        public ILocationFlag farwall_03 => Scenario.LocationFlagDefinitions[27].GameObject;
        public ILocationFlag farwall_02 => Scenario.LocationFlagDefinitions[28].GameObject;
        public ILocationFlag farwall_01 => Scenario.LocationFlagDefinitions[29].GameObject;
        public ILocationFlag below_near_R => Scenario.LocationFlagDefinitions[30].GameObject;
        public ILocationFlag below_near_L => Scenario.LocationFlagDefinitions[31].GameObject;
        public ILocationFlag below_far_L => Scenario.LocationFlagDefinitions[32].GameObject;
        public ILocationFlag below_far_R => Scenario.LocationFlagDefinitions[33].GameObject;
        public ILocationFlag debris => Scenario.LocationFlagDefinitions[34].GameObject;
        public ILocationFlag seawall_alcove_02 => Scenario.LocationFlagDefinitions[35].GameObject;
        public ILocationFlag seawall_alcove_01 => Scenario.LocationFlagDefinitions[36].GameObject;
        public ILocationFlag entry_shrine_L => Scenario.LocationFlagDefinitions[37].GameObject;
        public ILocationFlag entry_shrine_R => Scenario.LocationFlagDefinitions[38].GameObject;
        public ILocationFlag center_nook => Scenario.LocationFlagDefinitions[39].GameObject;
        public ILocationFlag grotto_exit => Scenario.LocationFlagDefinitions[40].GameObject;
        public ILocationFlag old_temple_exit => Scenario.LocationFlagDefinitions[41].GameObject;
        public ILocationFlag courtyard_exit => Scenario.LocationFlagDefinitions[42].GameObject;
        public ILocationFlag grotto_center => Scenario.LocationFlagDefinitions[43].GameObject;
        public ILocationFlag ally_start => Scenario.LocationFlagDefinitions[44].GameObject;
        public ILocationFlag see_tower1 => Scenario.LocationFlagDefinitions[45].GameObject;
        public ILocationFlag extra_ghost_02 => Scenario.LocationFlagDefinitions[46].GameObject;
        public ILocationFlag extra_ghost_01 => Scenario.LocationFlagDefinitions[47].GameObject;
        public ILocationFlag extra_ghost_03 => Scenario.LocationFlagDefinitions[48].GameObject;
        public ILocationFlag extra_ghost_04 => Scenario.LocationFlagDefinitions[49].GameObject;
        public ILocationFlag c05_intro_pod_03 => Scenario.LocationFlagDefinitions[50].GameObject;
        public ILocationFlag c05_intro_pod_02 => Scenario.LocationFlagDefinitions[51].GameObject;
        public ILocationFlag c05_intro_pod_01 => Scenario.LocationFlagDefinitions[52].GameObject;
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
            overlook_jackals_01 = new Squad_overlook_jackals_01(scenarioTag);
            overlook_jackals_02 = new Squad_overlook_jackals_02(scenarioTag);
            bridge_free_ghost = new Squad_bridge_free_ghost(scenarioTag);
            bridge_farside_wraiths = new Squad_bridge_farside_wraiths(scenarioTag);
            bridge_bunker_turrets = new Squad_bridge_bunker_turrets(scenarioTag);
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
            allies_bridge_bunker = new Squad_allies_bridge_bunker(scenarioTag);
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
            tunnel_ghosts_01 = new Squad_tunnel_ghosts_01(scenarioTag);
            tunnel_ghosts_02 = new Squad_tunnel_ghosts_02(scenarioTag);
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
            old_temple_phantom = new Squad_old_temple_phantom(scenarioTag);
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
            approach_buggers = new Squad_approach_buggers(scenarioTag);
            approach_buggers_too = new Squad_approach_buggers_too(scenarioTag);
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

        public class Squad_allies_lz_ledge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ally02 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[1];
            public IAiActorDefinition ally01 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[2];
            public IAiActorDefinition ally03 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_allies_lz_ledge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_lz_ridge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ally01 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[1];
            public IAiActorDefinition ally02 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_allies_lz_ridge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_turrets_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition mesa => ScenarioTag.AiSquadDefinitions[2].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_LZ_turrets_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_turrets_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ridge => ScenarioTag.AiSquadDefinitions[3].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_LZ_turrets_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_turrets_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition high => ScenarioTag.AiSquadDefinitions[4].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_LZ_turrets_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_turrets_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition structure => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_LZ_turrets_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_elites_ledge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[3];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_LZ_elites_ledge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_grunts_ledge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[11];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[12];
            public IAiActorDefinition starting_locations_12 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[13];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_LZ_grunts_ledge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_elites_ridge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[3];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_LZ_elites_ridge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_grunts_ridge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[5];
            public IAiActorDefinition starting_locations_51 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[6];
            public IAiActorDefinition starting_locations_61 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_LZ_grunts_ridge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_jackals_ridge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_LZ_jackals_ridge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_elites_yard
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_LZ_elites_yard(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_grunts_yard
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_LZ_grunts_yard(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_jackals_yard
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[3];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_LZ_jackals_yard(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_elites_structure
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_LZ_elites_structure(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_grunts_structure
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_LZ_grunts_structure(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_jackals_structure
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_LZ_jackals_structure(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_elites_bunkered
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_LZ_elites_bunkered(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_grunts_bunkered
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad_LZ_grunts_bunkered(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_phantom_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[19].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_LZ_phantom_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_elites_phantom_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_LZ_elites_phantom_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_grunts_phantom_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_LZ_grunts_phantom_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_jackals_phantom_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_LZ_jackals_phantom_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_phantom_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[23].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_LZ_phantom_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_elites_phantom_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_LZ_elites_phantom_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_grunts_phantom_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_LZ_grunts_phantom_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_jackals_phantom_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_LZ_jackals_phantom_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_stealth_phantom_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[2];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_LZ_stealth_phantom_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_pelican_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[28].StartingLocations[1];
            public IAiActorDefinition gunner01 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_LZ_pelican_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_pelican_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[29].StartingLocations[1];
            public IAiActorDefinition gunner01 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_LZ_pelican_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_LZ_warthog_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_LZ_warthog_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_lz_pelican
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition snipergirl => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition sniperboy => ScenarioTag.AiSquadDefinitions[31].StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[5];
            public IAiActorDefinition starting_locations_81 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[6];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[7];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_allies_lz_pelican(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_overlook_jackals_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_overlook_jackals_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_overlook_jackals_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_overlook_jackals_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_free_ghost
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[1];
            public IAiActorDefinition _4 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[2];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[3];
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_bridge_free_ghost(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_farside_wraiths
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_bridge_farside_wraiths(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_bunker_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition bunker_01 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[1];
            public IAiActorDefinition bunker_02 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[2];
            public IAiActorDefinition bunker_03 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_bridge_bunker_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_bunker_ghosts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[37].StartingLocations[1];
            public IAiActorDefinition r => ScenarioTag.AiSquadDefinitions[37].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_bridge_bunker_ghosts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_ghost_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition r => ScenarioTag.AiSquadDefinitions[38].StartingLocations[1];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[38].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_bridge_ghost_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_turret_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_bridge_turret_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_turret_grunts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_bridge_turret_grunts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_bunker_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_bridge_bunker_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_bunker_elites_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_bridge_bunker_elites_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_bunker_jackals_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_bridge_bunker_jackals_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_bunker_jackals_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_bridge_bunker_jackals_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_bunker_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_bridge_bunker_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_bunker_grunts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_bridge_bunker_grunts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bunker_turret_remen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[2];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_bunker_turret_remen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_crack_jackals
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_bridge_crack_jackals(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_crack_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_bridge_crack_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_backdoor_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_bridge_backdoor_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_backdoor_jackals_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_bridge_backdoor_jackals_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_backdoor_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_bridge_backdoor_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_control_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_bridge_control_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_control_jackals_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad_bridge_control_jackals_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_control_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_bridge_control_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_bridge_bunker
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1a => ScenarioTag.AiSquadDefinitions[56].StartingLocations[1];
            public IAiActorDefinition _1b => ScenarioTag.AiSquadDefinitions[56].StartingLocations[2];
            public IAiActorDefinition _2a => ScenarioTag.AiSquadDefinitions[56].StartingLocations[3];
            public IAiActorDefinition _2b => ScenarioTag.AiSquadDefinitions[56].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_allies_bridge_bunker(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_phantom_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_bridge_phantom_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_phantom_ghosts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_bridge_phantom_ghosts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_phantom_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_bridge_phantom_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_phantom_ghosts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_bridge_phantom_ghosts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_farside_ghosts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_bridge_farside_ghosts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_banshees
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_bridge_banshees(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_pelican_chasers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_bridge_pelican_chasers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_pelican
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[64].StartingLocations[1];
            public IAiActorDefinition gunner1 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_bridge_pelican(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bridge_tank1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[65].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_bridge_tank1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_bridge_pelican
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[5];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[6];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[7];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_allies_bridge_pelican(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_w_path_free_ghost
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_w_path_free_ghost(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_winding_path_ghosts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_winding_path_ghosts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_winding_path_ghosts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_winding_path_ghosts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_winding_path_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_winding_path_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_w_path_heavies
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[1];
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[2];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_w_path_heavies(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_winding_path_ledge_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_winding_path_ledge_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_winding_path_jackals
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_winding_path_jackals(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_turrets_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_temple_ent_turrets_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_turrets_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_temple_ent_turrets_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_turrets_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad_temple_ent_turrets_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_turrets_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_temple_ent_turrets_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_elites_01l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_temple_ent_elites_01l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_elites_01r
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_temple_ent_elites_01r(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_elites_02l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_temple_ent_elites_02l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_elites_02r
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_temple_ent_elites_02r(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_jackals_01l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_temple_ent_jackals_01l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_jackals_01r
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_temple_ent_jackals_01r(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_jackals_02c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_temple_ent_jackals_02c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_bugs_01l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[85];
            public Squad_temple_ent_bugs_01l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_bugs_01c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[86];
            public Squad_temple_ent_bugs_01c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_bugs_01r
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[87];
            public Squad_temple_ent_bugs_01r(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_bugs_02l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[88];
            public Squad_temple_ent_bugs_02l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_bugs_02c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[89];
            public Squad_temple_ent_bugs_02c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_bugs_02r
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[90];
            public Squad_temple_ent_bugs_02r(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_grunts_01l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[91];
            public Squad_temple_ent_grunts_01l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_grunts_01r
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[92];
            public Squad_temple_ent_grunts_01r(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_ghosts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition r => ScenarioTag.AiSquadDefinitions[93].StartingLocations[1];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[93].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[93];
            public Squad_temple_ent_ghosts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_ghosts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[94];
            public Squad_temple_ent_ghosts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_temple_ent_banshees
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[95];
            public Squad_temple_ent_banshees(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tunnel_ghosts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[96];
            public Squad_tunnel_ghosts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tunnel_ghosts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[97];
            public Squad_tunnel_ghosts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tunnel_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[98];
            public Squad_tunnel_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tunnel_jackals
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[2];
            public IAiActorDefinition starting_locations_61 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[5];
            public IAiActorDefinition starting_locations_62 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[99];
            public Squad_tunnel_jackals(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tunnel_heavies_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _0 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[1];
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[100];
            public Squad_tunnel_heavies_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tunnel_heavies_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[1];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[101];
            public Squad_tunnel_heavies_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition far_r => ScenarioTag.AiSquadDefinitions[102].StartingLocations[1];
            public IAiActorDefinition near_l => ScenarioTag.AiSquadDefinitions[102].StartingLocations[2];
            public IAiActorDefinition far_l => ScenarioTag.AiSquadDefinitions[102].StartingLocations[3];
            public IAiActorDefinition center => ScenarioTag.AiSquadDefinitions[102].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[102];
            public Squad_old_temple_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_grunts_near_left
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[103];
            public Squad_old_temple_grunts_near_left(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_grunts_far_left
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[104];
            public Squad_old_temple_grunts_far_left(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_grunts_far_right
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[105];
            public Squad_old_temple_grunts_far_right(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_grunts_center
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[106];
            public Squad_old_temple_grunts_center(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_elites_near_right
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[107];
            public Squad_old_temple_elites_near_right(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_near_right
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[108];
            public Squad_old_temple_jackals_near_right(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_below_far
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[109];
            public Squad_old_temple_jackals_below_far(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_below_near
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[110];
            public Squad_old_temple_jackals_below_near(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_sea_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[111];
            public Squad_old_temple_jackals_sea_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_sea_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[112];
            public Squad_old_temple_jackals_sea_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_debris
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[113];
            public Squad_old_temple_jackals_debris(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_corner
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[114];
            public Squad_old_temple_jackals_corner(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_shrine_L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[115];
            public Squad_old_temple_jackals_shrine_L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_jackals_shrine_R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[116];
            public Squad_old_temple_jackals_shrine_R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_init_elites_fl
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[117].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[117];
            public Squad_old_temple_init_elites_fl(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_init_jackals_fl
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[118].StartingLocations[1];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[118].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[118];
            public Squad_old_temple_init_jackals_fl(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_init_jackals_nl
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[119];
            public Squad_old_temple_init_jackals_nl(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_init_elites_nr
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[120];
            public Squad_old_temple_init_elites_nr(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_init_jackals_nr
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[121].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[121].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[121];
            public Squad_old_temple_init_jackals_nr(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_ghosts_far
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[122];
            public Squad_old_temple_ghosts_far(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[123].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[123];
            public Squad_old_temple_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_ghosts_air
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[124].StartingLocations[1];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[124].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[124];
            public Squad_old_temple_ghosts_air(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_banshees
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[125];
            public Squad_old_temple_banshees(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_pelican1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[126].StartingLocations[1];
            public IAiActorDefinition gunner1 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[126];
            public Squad_old_temple_pelican1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_old_temple_pelican
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[5];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[6];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[7];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[127];
            public Squad_allies_old_temple_pelican(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_old_temple_real
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[128];
            public Squad_allies_old_temple_real(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_playfight_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[129];
            public Squad_old_temple_playfight_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_playfight_g
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[130];
            public Squad_old_temple_playfight_g(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_center_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[131];
            public Squad_old_temple_center_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_center_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[132];
            public Squad_old_temple_center_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_center_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[133];
            public Squad_old_temple_center_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_center_jackals_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[134];
            public Squad_old_temple_center_jackals_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_center_grunts_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[135];
            public Squad_old_temple_center_grunts_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_center_elites_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[136].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[136].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[136];
            public Squad_old_temple_center_elites_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_center_jackals_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[137].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[137].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[137].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[137];
            public Squad_old_temple_center_jackals_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_courtyard_lure
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[138];
            public Squad_old_temple_courtyard_lure(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[139];
            public Squad_old_temple_court_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[140].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[140].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[140].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[140];
            public Squad_old_temple_court_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_grunts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[141];
            public Squad_old_temple_court_grunts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_jackals_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[142].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[142].StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[142].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[142];
            public Squad_old_temple_court_jackals_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[2];
            public IAiActorDefinition starting_locations_51 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[3];
            public IAiActorDefinition starting_locations_61 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[143];
            public Squad_old_temple_court_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_jackals_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[144];
            public Squad_old_temple_court_jackals_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_elites_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[145];
            public Squad_old_temple_court_elites_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_jackals_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[146].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[146].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[146].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[146];
            public Squad_old_temple_court_jackals_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_jackals_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[147].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[147].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[147];
            public Squad_old_temple_court_jackals_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temple_court_grunts_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[148];
            public Squad_old_temple_court_grunts_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_courtyard_grunts_end
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[149];
            public Squad_courtyard_grunts_end(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_old_temp_court_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[150].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[150];
            public Squad_old_temp_court_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[151];
            public Squad_grotto_init_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[152].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[152];
            public Squad_grotto_init_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[153];
            public Squad_grotto_init_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[154];
            public Squad_grotto_init_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[155].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[155];
            public Squad_grotto_init_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[156];
            public Squad_grotto_init_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_07
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[157];
            public Squad_grotto_init_07(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_08
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[158].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[158];
            public Squad_grotto_init_08(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_09
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[159].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[159];
            public Squad_grotto_init_09(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_10
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[160];
            public Squad_grotto_init_10(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_init_11
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[161].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[161].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[161];
            public Squad_grotto_init_11(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_buggers_new_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[162];
            public Squad_grotto_buggers_new_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_sleepers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[163].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[163];
            public Squad_grotto_sleepers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_crack_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[164].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[164].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[164].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[164];
            public Squad_grotto_crack_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_pool_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[165];
            public Squad_grotto_pool_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_cave_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[166].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[166].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[166];
            public Squad_grotto_cave_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_cave_jackals_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[167].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[167];
            public Squad_grotto_cave_jackals_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_cave_jackals_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[168].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[168];
            public Squad_grotto_cave_jackals_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_cave_jackals_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[169].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[169];
            public Squad_grotto_cave_jackals_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_buggers_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[170].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[170].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[170].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[170].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[170];
            public Squad_grotto_buggers_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_buggers_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[171].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[171].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[171].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[171].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[171];
            public Squad_grotto_buggers_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_buggers_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[172].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[172].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[172].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[172].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[172];
            public Squad_grotto_buggers_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_end_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[173].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[173].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[173];
            public Squad_grotto_end_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_end_elites_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[174].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[174].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[174];
            public Squad_grotto_end_elites_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_end_jackals_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[175].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[175].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[175];
            public Squad_grotto_end_jackals_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_end_jackals_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[176].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[176].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[176];
            public Squad_grotto_end_jackals_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_end_jackals_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[177].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[177].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[177];
            public Squad_grotto_end_jackals_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grotto_grunts_end
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[2];
            public IAiActorDefinition starting_locations_21 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[178];
            public Squad_grotto_grunts_end(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_buggers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[179];
            public Squad_approach_buggers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_buggers_too
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[3];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[4];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[5];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[6];
            public IAiActorDefinition starting_locations_12 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[7];
            public IAiActorDefinition starting_locations_13 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[8];
            public IAiActorDefinition starting_locations_14 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[180];
            public Squad_approach_buggers_too(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_jackal_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[181].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[181];
            public Squad_approach_jackal_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_jackal_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[182].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[182];
            public Squad_approach_jackal_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_jackal_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[183].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[183];
            public Squad_approach_jackal_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_elite_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[184].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[184];
            public Squad_approach_elite_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_elite_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[185].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[185];
            public Squad_approach_elite_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_elite_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[186].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[186];
            public Squad_approach_elite_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_approach_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[187].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[187].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[187];
            public Squad_approach_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tower1_hg_01a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[188].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[188];
            public Squad_tower1_hg_01a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tower1_hg_01b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[189].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[189];
            public Squad_tower1_hg_01b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tower1_hg_02a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[190].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[190];
            public Squad_tower1_hg_02a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tower1_hg_02b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[191].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[191];
            public Squad_tower1_hg_02b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tower1_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[192];
            public Squad_tower1_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tower1_grunts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[193].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[193].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[193].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[193].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[193].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[193].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[193];
            public Squad_tower1_grunts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_test
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[194].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[194];
            public Squad_test(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[195].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[195].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[195];
            public Squad_jets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_envy_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[196].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[196].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[196];
            public Squad_envy_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}