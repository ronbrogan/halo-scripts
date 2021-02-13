namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_04a_gasgiant : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> anchor03 { get; set; }
        public ScenarioEntity<IScenery> outro_seraph { get; set; }
        public ScenarioEntity<IScenery> holo_drone_2 { get; set; }
        public ScenarioEntity<IScenery> holo_drone_1 { get; set; }
        public ScenarioEntity<IScenery> sarcophagus { get; set; }
        public ScenarioEntity<IBloc> recycling_can_a { get; set; }
        public ScenarioEntity<IBloc> recycling_can_b { get; set; }
        public ScenarioEntity<IBloc> recycling_can_c { get; set; }
        public ScenarioEntity<IScenery> honor_guard_02 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_04 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_05 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_06 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_14 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_15 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_16 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_17 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_18 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_19 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_20 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_28 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_29 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_30 { get; set; }
        public ScenarioEntity<IBloc> elev_crate_01 { get; set; }
        public ScenarioEntity<IBloc> elev_crate_02 { get; set; }
        public ScenarioEntity<IBloc> hangar_can_a { get; set; }
        public ScenarioEntity<IBloc> hangar_can_b { get; set; }
        public ScenarioEntity<IBloc> hangar_can_c { get; set; }
        public ScenarioEntity<IBloc> hangar_can_d { get; set; }
        public ScenarioEntity<IBloc> underhangar_can_a { get; set; }
        public ScenarioEntity<IBloc> underhangar_can_b { get; set; }
        public ScenarioEntity<IBloc> bottling_can_a { get; set; }
        public ScenarioEntity<IBloc> bottling_can_b { get; set; }
        public ScenarioEntity<IBloc> help_can_01 { get; set; }
        public ScenarioEntity<IBloc> help_can_02 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_31 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_32 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_33 { get; set; }
        public ScenarioEntity<IScenery> honor_guard_34 { get; set; }
        public ScenarioEntity<IScenery> hammer { get; set; }
        public ScenarioEntity<IScenery> null_intro { get; set; }
        public ScenarioEntity<IScenery> anchor02 { get; set; }
        public ScenarioEntity<IScenery> phantom_int { get; set; }
        public ScenarioEntity<IScenery> matte_halo_01 { get; set; }
        public ScenarioEntity<IScenery> matte_threshold { get; set; }
        public ScenarioEntity<IScenery> matte_mine { get; set; }
        public ScenarioEntity<IScenery> matte_structure_top { get; set; }
        public ScenarioEntity<IScenery> matte_structure { get; set; }
        public ScenarioEntity<IScenery> matte_high_charity { get; set; }
        public ScenarioEntity<IScenery> hangar_door_ingame { get; set; }
        public ScenarioEntity<IScenery> beam_rifle01 { get; set; }
        public ScenarioEntity<IScenery> plasma_rifle01 { get; set; }
        public ScenarioEntity<IScenery> plasma_rifle02 { get; set; }
        public ScenarioEntity<IScenery> plasma_rifle03 { get; set; }
        public ScenarioEntity<IScenery> plasma_rifle04 { get; set; }
        public ScenarioEntity<IScenery> plasma_rifle05 { get; set; }
        public ScenarioEntity<IScenery> plasma_rifle06 { get; set; }
        public ScenarioEntity<IScenery> plasma_pistol01 { get; set; }
        public ScenarioEntity<IScenery> plasma_pistol02 { get; set; }
        public ScenarioEntity<IScenery> plasma_pistol03 { get; set; }
        public ScenarioEntity<IScenery> energy_blade02 { get; set; }
        public ScenarioEntity<IScenery> plasma_pistol04 { get; set; }
        public ScenarioEntity<IBloc> rec_can_a_01 { get; set; }
        public ScenarioEntity<IBloc> rec_can_a_02 { get; set; }
        public ScenarioEntity<IBloc> rec_can_a_03 { get; set; }
        public ScenarioEntity<IBloc> rec_can_a_04 { get; set; }
        public ScenarioEntity<IBloc> rec_can_a_06 { get; set; }
        public ScenarioEntity<IBloc> rec_can_a_07 { get; set; }
        public ScenarioEntity<IBloc> rec_can_b_01 { get; set; }
        public ScenarioEntity<IBloc> rec_can_b_02 { get; set; }
        public ScenarioEntity<IBloc> rec_can_c_01 { get; set; }
        public ScenarioEntity<IBloc> rec_can_c_02 { get; set; }
        public ScenarioEntity<IBloc> rec_can_c_03 { get; set; }
        public ScenarioEntity<IBloc> rec_can_c_04 { get; set; }
        public ScenarioEntity<IBloc> rec_can_c_06 { get; set; }
        public ScenarioEntity<IScenery> blocker_l { get; set; }
        public ScenarioEntity<IScenery> blocker_r { get; set; }
        public ScenarioEntity<IScenery> anchor_x04b { get; set; }
        public ScenarioEntity<IScenery> anchor_x04a { get; set; }
        public ScenarioEntity<IScenery> gas01 { get; set; }
        public ScenarioEntity<IScenery> gas02 { get; set; }
        public ScenarioEntity<IScenery> gas03 { get; set; }
        public ScenarioEntity<IScenery> gas04 { get; set; }
        public ScenarioEntity<IScenery> gas05 { get; set; }
        public ScenarioEntity<IScenery> gas06 { get; set; }
        public ScenarioEntity<IScenery> gas07 { get; set; }
        public ScenarioEntity<IScenery> gas08 { get; set; }
        public ScenarioEntity<IScenery> gas09 { get; set; }
        public ScenarioEntity<IScenery> gas10 { get; set; }
        public ScenarioEntity<IScenery> approach_here { get; set; }
        public ScenarioEntity<IScenery> energy_blade01 { get; set; }
        public ScenarioEntity<IScenery> jail_ledge { get; set; }
        public ScenarioEntity<IBloc> hang_can_01 { get; set; }
        public ScenarioEntity<IBloc> hang_can_02 { get; set; }
        public ScenarioEntity<IBloc> hang_can_03 { get; set; }
        public ScenarioEntity<IBloc> hang_can_04 { get; set; }
        public ScenarioEntity<IBloc> hang_can_05 { get; set; }
        public ScenarioEntity<IBloc> underhang_can_01 { get; set; }
        public ScenarioEntity<IBloc> underhang_can_02 { get; set; }
        public ScenarioEntity<IBloc> underhang_can_03 { get; set; }
        public ScenarioEntity<IBloc> underhang_can_04 { get; set; }
        public ScenarioEntity<IBloc> bott_can_01 { get; set; }
        public ScenarioEntity<IBloc> bott_can_02 { get; set; }
        public ScenarioEntity<IScenery> intro_fleet { get; set; }
        public ScenarioEntity<IScenery> stardust_01 { get; set; }
        public ScenarioEntity<IScenery> stardust_02 { get; set; }
        public ScenarioEntity<IUnit> brute_01 { get; set; }
        public ScenarioEntity<IUnit> brute_02 { get; set; }
        public ScenarioEntity<IUnit> dervish { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> jackal_01 { get; set; }
        public ScenarioEntity<IUnit> jackal_02 { get; set; }
        public ScenarioEntity<IUnit> jackal_03 { get; set; }
        public ScenarioEntity<IUnit> truth { get; set; }
        public ScenarioEntity<IUnit> mercy { get; set; }
        public ScenarioEntity<IUnit> commander { get; set; }
        public ScenarioEntity<IUnit> elite01 { get; set; }
        public ScenarioEntity<IUnit> dervish02 { get; set; }
        public ScenarioEntity<IUnit> elite02 { get; set; }
        public ScenarioEntity<IUnit> elite03 { get; set; }
        public ScenarioEntity<IUnit> elite04 { get; set; }
        public ScenarioEntity<IUnit> elite05 { get; set; }
        public ScenarioEntity<IUnit> elite06 { get; set; }
        public ScenarioEntity<IUnit> elite07 { get; set; }
        public ScenarioEntity<IUnit> grunt01 { get; set; }
        public ScenarioEntity<IUnit> grunt02 { get; set; }
        public ScenarioEntity<IUnit> grunt03 { get; set; }
        public ScenarioEntity<IUnit> grunt04 { get; set; }
        public ScenarioEntity<IUnit> heretic_leader_holo_01 { get; set; }
        public ScenarioEntity<IVehicle> throne_truth { get; set; }
        public ScenarioEntity<IVehicle> throne_mercy { get; set; }
        public ScenarioEntity<IVehicle> phantom01 { get; set; }
        public ScenarioEntity<IVehicle> phantom02 { get; set; }
        public ScenarioEntity<IVehicle> phantom03 { get; set; }
        public ScenarioEntity<IVehicle> phantom_01 { get; set; }
        public ScenarioEntity<IVehicle> phantom_02 { get; set; }
        public ScenarioEntity<IVehicle> phantom_03 { get; set; }
        public ScenarioEntity<IVehicle> extra09a { get; set; }
        public ScenarioEntity<IVehicle> extra09b { get; set; }
        public ScenarioEntity<IVehicle> extra08a { get; set; }
        public ScenarioEntity<IVehicle> extra08b { get; set; }
        public ScenarioEntity<IVehicle> extra06a { get; set; }
        public ScenarioEntity<IVehicle> extra06b { get; set; }
        public ScenarioEntity<IVehicle> extra05a { get; set; }
        public ScenarioEntity<IVehicle> extra05b { get; set; }
        public ScenarioEntity<IVehicle> extra10a { get; set; }
        public ScenarioEntity<IVehicle> extra10b { get; set; }
        public ScenarioEntity<IVehicle> extra02a { get; set; }
        public ScenarioEntity<IVehicle> extra02b { get; set; }
        public ScenarioEntity<IVehicle> extra02c { get; set; }
        public ScenarioEntity<IVehicle> extra02d { get; set; }
        public ScenarioEntity<IVehicle> extra12a { get; set; }
        public ScenarioEntity<IVehicle> extra12b { get; set; }
        public ScenarioEntity<IVehicle> extra12c { get; set; }
        public ScenarioEntity<IVehicle> extra03a { get; set; }
        public ScenarioEntity<IVehicle> extra03b { get; set; }
        public ScenarioEntity<IVehicle> extra03c { get; set; }
        public ScenarioEntity<IVehicle> extra01a { get; set; }
        public ScenarioEntity<IVehicle> extra01b { get; set; }
        public ScenarioEntity<IVehicle> extra01c { get; set; }
        public ScenarioEntity<IVehicle> extra01d { get; set; }
        public ScenarioEntity<IVehicle> extra11a { get; set; }
        public ScenarioEntity<IVehicle> extra11b { get; set; }
        public ScenarioEntity<IVehicle> extra11c { get; set; }
        public ScenarioEntity<IVehicle> extra04a { get; set; }
        public ScenarioEntity<IVehicle> extra04b { get; set; }
        public ScenarioEntity<IVehicle> extra14a { get; set; }
        public ScenarioEntity<IVehicle> extra14b { get; set; }
        public ScenarioEntity<IVehicle> extra07a { get; set; }
        public ScenarioEntity<IVehicle> extra07b { get; set; }
        public ScenarioEntity<IVehicle> extra07c { get; set; }
        public ScenarioEntity<IVehicle> extra15a { get; set; }
        public ScenarioEntity<IVehicle> extra15b { get; set; }
        public ScenarioEntity<IVehicle> extra13a { get; set; }
        public ScenarioEntity<IVehicle> extra13b { get; set; }
        public ScenarioEntity<IVehicle> extra13c { get; set; }
        public ScenarioEntity<IVehicle> mid_banshee_01 { get; set; }
        public ScenarioEntity<IVehicle> mid_banshee_02 { get; set; }
        public ScenarioEntity<IVehicle> hl_banshee { get; set; }
        public ScenarioEntity<IWeapon> bday_cake { get; set; }
        public ScenarioEntity<ISound> alpha_gas_exterior { get; set; }
        public ScenarioEntity<ISound> filthy_audio1 { get; set; }
        public ScenarioEntity<ISound> filthy_audio2 { get; set; }
        public ScenarioEntity<ISound> big_filthy_audio1 { get; set; }
        public ScenarioEntity<IDevice> viewroom_exit01 { get; set; }
        public ScenarioEntity<IDevice> viewroom_entry { get; set; }
        public ScenarioEntity<IDevice> banshee_ledge_access_01 { get; set; }
        public ScenarioEntity<IDevice> bottling_midway { get; set; }
        public ScenarioEntity<IDevice> lab_exit_ext { get; set; }
        public ScenarioEntity<IDevice> arm_02_entry_ext { get; set; }
        public ScenarioEntity<IDevice> viewroom_exit02 { get; set; }
        public ScenarioEntity<IDevice> elev_hangar { get; set; }
        public ScenarioEntity<IDevice> seraph { get; set; }
        public ScenarioEntity<IDevice> banshee_ledge_access_02 { get; set; }
        public ScenarioEntity<IDevice> x1sided05 { get; set; }
        public ScenarioEntity<IDevice> hangar_switch01 { get; set; }
        public ScenarioEntity<IDevice> hangar_switch02 { get; set; }
        public ScenarioEntity<IDevice> rec_center_entry_ext { get; set; }
        public ScenarioEntity<IDevice> rec_center_entry_int { get; set; }
        public ScenarioEntity<IDevice> rec_cen_rein_01r { get; set; }
        public ScenarioEntity<IDevice> rec_cen_rein_01l { get; set; }
        public ScenarioEntity<IDevice> hang_01r { get; set; }
        public ScenarioEntity<IDevice> hang_02r { get; set; }
        public ScenarioEntity<IDevice> hang_03r { get; set; }
        public ScenarioEntity<IDevice> hang_01l { get; set; }
        public ScenarioEntity<IDevice> hang_02l { get; set; }
        public ScenarioEntity<IDevice> hang_03l { get; set; }
        public ScenarioEntity<IDevice> hangar_exit { get; set; }
        public ScenarioEntity<IDevice> underhangar_entry { get; set; }
        public ScenarioEntity<IDevice> underhangar_exit { get; set; }
        public ScenarioEntity<IDevice> bottling_entry { get; set; }
        public ScenarioEntity<IDevice> hangar_door_cinematic { get; set; }
        public ScenarioEntity<IDevice> x04_door_01 { get; set; }
        public ScenarioEntity<IDevice> hangar_door_switch_r { get; set; }
        public ScenarioEntity<IDevice> hangar_door_switch_l { get; set; }
        public ScenarioEntity<IDevice> x04_button { get; set; }
        public Squad_intro_elites intro_elites { get; set; }
        public Squad_intro_phantom intro_phantom { get; set; }
        public Squad_allies_grunts_01 allies_grunts_01 { get; set; }
        public Squad_allies_elites_01 allies_elites_01 { get; set; }
        public Squad_hacker hacker { get; set; }
        public Squad_rec_center_heretic_01 rec_center_heretic_01 { get; set; }
        public Squad_rec_center_heretic_02 rec_center_heretic_02 { get; set; }
        public Squad_rec_center_grunts_01 rec_center_grunts_01 { get; set; }
        public Squad_rec_center_grunts_02L rec_center_grunts_02L { get; set; }
        public Squad_rec_center_grunts_02R rec_center_grunts_02R { get; set; }
        public Squad_rec_center_grunts_03 rec_center_grunts_03 { get; set; }
        public Squad_rec_center_heretic_03 rec_center_heretic_03 { get; set; }
        public Squad_rec_center_heretic_04 rec_center_heretic_04 { get; set; }
        public Squad_rec_center_grunts_04 rec_center_grunts_04 { get; set; }
        public Squad_rec_center_heretic_05 rec_center_heretic_05 { get; set; }
        public Squad_rec_center_grunts_05 rec_center_grunts_05 { get; set; }
        public Squad_rec_center_grunts_06 rec_center_grunts_06 { get; set; }
        public Squad_rec_center_heretic_06 rec_center_heretic_06 { get; set; }
        public Squad_rec_center_grunts_07 rec_center_grunts_07 { get; set; }
        public Squad_rec_cen_rein_her_01L rec_cen_rein_her_01L { get; set; }
        public Squad_rec_cen_rein_grt_01L rec_cen_rein_grt_01L { get; set; }
        public Squad_rec_cen_rein_her_01R rec_cen_rein_her_01R { get; set; }
        public Squad_rec_cen_rein_grt_01R rec_cen_rein_grt_01R { get; set; }
        public Squad_hangar_heretic_01R hangar_heretic_01R { get; set; }
        public Squad_hangar_heretic_01L hangar_heretic_01L { get; set; }
        public Squad_hangar_grunts_01R hangar_grunts_01R { get; set; }
        public Squad_hangar_grunts_01L hangar_grunts_01L { get; set; }
        public Squad_hangar_heretic_02L hangar_heretic_02L { get; set; }
        public Squad_hangar_heretic_02R hangar_heretic_02R { get; set; }
        public Squad_hangar_heretic_05 hangar_heretic_05 { get; set; }
        public Squad_hangar_grunts_03 hangar_grunts_03 { get; set; }
        public Squad_hangar_rein_her_01L hangar_rein_her_01L { get; set; }
        public Squad_hangar_rein_her_01R hangar_rein_her_01R { get; set; }
        public Squad_hangar_rein_her_02L hangar_rein_her_02L { get; set; }
        public Squad_hangar_rein_her_02R hangar_rein_her_02R { get; set; }
        public Squad_hangar_rein_her_03L hangar_rein_her_03L { get; set; }
        public Squad_hangar_rein_her_03R hangar_rein_her_03R { get; set; }
        public Squad_hangar_sentinels_flit hangar_sentinels_flit { get; set; }
        public Squad_hangar_helper_01 hangar_helper_01 { get; set; }
        public Squad_hangar_helper_02 hangar_helper_02 { get; set; }
        public Squad_hangar_helper_03 hangar_helper_03 { get; set; }
        public Squad_hangar_phantom hangar_phantom { get; set; }
        public Squad_reinforce_elites_01 reinforce_elites_01 { get; set; }
        public Squad_reinforce_grunts_01 reinforce_grunts_01 { get; set; }
        public Squad_hangar_sentinel_swarm hangar_sentinel_swarm { get; set; }
        public Squad_hangar_heretic_heavies_L hangar_heretic_heavies_L { get; set; }
        public Squad_hangar_heretic_heavies_R hangar_heretic_heavies_R { get; set; }
        public Squad_hangar_a50_01r_high hangar_a50_01r_high { get; set; }
        public Squad_hangar_a50_01l_high hangar_a50_01l_high { get; set; }
        public Squad_hangar_a50_02r_high hangar_a50_02r_high { get; set; }
        public Squad_hangar_a50_02l_high hangar_a50_02l_high { get; set; }
        public Squad_hangar_a50_03r_high hangar_a50_03r_high { get; set; }
        public Squad_hangar_a50_03l_high hangar_a50_03l_high { get; set; }
        public Squad_hangar_a50_01r_low hangar_a50_01r_low { get; set; }
        public Squad_hangar_a50_01l_low hangar_a50_01l_low { get; set; }
        public Squad_hangar_a50_02r_low hangar_a50_02r_low { get; set; }
        public Squad_hangar_a50_02l_low hangar_a50_02l_low { get; set; }
        public Squad_hangar_a50_03r_low hangar_a50_03r_low { get; set; }
        public Squad_hangar_a50_03l_low hangar_a50_03l_low { get; set; }
        public Squad_hangar_grunts_04R hangar_grunts_04R { get; set; }
        public Squad_hangar_grunts_04L hangar_grunts_04L { get; set; }
        public Squad_hangar_heretic_06R hangar_heretic_06R { get; set; }
        public Squad_hangar_heretic_06C hangar_heretic_06C { get; set; }
        public Squad_hangar_heretic_06L hangar_heretic_06L { get; set; }
        public Squad_hangar_grunts_end hangar_grunts_end { get; set; }
        public Squad_first_hall_heretic_01 first_hall_heretic_01 { get; set; }
        public Squad_first_hall_grunts_01 first_hall_grunts_01 { get; set; }
        public Squad_first_hall_heretic_02 first_hall_heretic_02 { get; set; }
        public Squad_first_hall_heretic_03 first_hall_heretic_03 { get; set; }
        public Squad_reinforce_elites_02 reinforce_elites_02 { get; set; }
        public Squad_reinforce_grunts_02 reinforce_grunts_02 { get; set; }
        public Squad_underhangar_heretic_01 underhangar_heretic_01 { get; set; }
        public Squad_underhangar_heretic_02 underhangar_heretic_02 { get; set; }
        public Squad_underhangar_grunts_01 underhangar_grunts_01 { get; set; }
        public Squad_underhangar_grunts_02 underhangar_grunts_02 { get; set; }
        public Squad_underhangar_grunts_03 underhangar_grunts_03 { get; set; }
        public Squad_underhangar_rein_her_01 underhangar_rein_her_01 { get; set; }
        public Squad_underhangar_rein_her_02 underhangar_rein_her_02 { get; set; }
        public Squad_second_hall_heretic_01 second_hall_heretic_01 { get; set; }
        public Squad_second_hall_grunts_01 second_hall_grunts_01 { get; set; }
        public Squad_second_hall_heretic_02 second_hall_heretic_02 { get; set; }
        public Squad_second_hall_heretic_03 second_hall_heretic_03 { get; set; }
        public Squad_second_hall_grunts_02 second_hall_grunts_02 { get; set; }
        public Squad_second_hall_grunts_03 second_hall_grunts_03 { get; set; }
        public Squad_second_hall_heretic_04 second_hall_heretic_04 { get; set; }
        public Squad_second_hall_heretic_05 second_hall_heretic_05 { get; set; }
        public Squad_second_hall_heretic_06 second_hall_heretic_06 { get; set; }
        public Squad_heretic_leader_01 heretic_leader_01 { get; set; }
        public Squad_heretic_leader_02 heretic_leader_02 { get; set; }
        public Squad_heretic_leader_03 heretic_leader_03 { get; set; }
        public Squad_reinforce_elites_03 reinforce_elites_03 { get; set; }
        public Squad_reinforce_grunts_03 reinforce_grunts_03 { get; set; }
        public Squad_bottling_heretics_01 bottling_heretics_01 { get; set; }
        public Squad_bottling_grunts_01 bottling_grunts_01 { get; set; }
        public Squad_bottling_heretics_02 bottling_heretics_02 { get; set; }
        public Squad_bottling_grunts_02 bottling_grunts_02 { get; set; }
        public Squad_bottling_heretics_03 bottling_heretics_03 { get; set; }
        public Squad_bottling_grunts_03 bottling_grunts_03 { get; set; }
        public Squad_bottling_heretics_04 bottling_heretics_04 { get; set; }
        public Squad_bottling_grunts_04 bottling_grunts_04 { get; set; }
        public Squad_bottling_heretics_05 bottling_heretics_05 { get; set; }
        public Squad_bottling_grunts_05 bottling_grunts_05 { get; set; }
        public Squad_bottling_sentinels_01 bottling_sentinels_01 { get; set; }
        public Squad_bottling_sentinels_02 bottling_sentinels_02 { get; set; }
        public Squad_bottling_sentinels_03 bottling_sentinels_03 { get; set; }
        public Squad_ledge_banshees_01 ledge_banshees_01 { get; set; }
        public Squad_allied_phantom_01 allied_phantom_01 { get; set; }
        public Squad_dogfight_initial_enemies dogfight_initial_enemies { get; set; }
        public Squad_dogfight_enemies dogfight_enemies { get; set; }
        public Squad_dog_turrets_01 dog_turrets_01 { get; set; }
        public Squad_dog_turret_men_01 dog_turret_men_01 { get; set; }
        public Squad_dog_turrets_02 dog_turrets_02 { get; set; }
        public Squad_dog_turret_men_02 dog_turret_men_02 { get; set; }
        public Squad_dog_flak_02 dog_flak_02 { get; set; }
        public Squad_dog_turrets_03 dog_turrets_03 { get; set; }
        public Squad_dog_turret_men_03 dog_turret_men_03 { get; set; }
        public Squad_dog_sen_03 dog_sen_03 { get; set; }
        public Squad_dog_turrets_04 dog_turrets_04 { get; set; }
        public Squad_dog_turret_men_04 dog_turret_men_04 { get; set; }
        public Squad_dog_flak_04 dog_flak_04 { get; set; }
        public Squad_dog_sen_05 dog_sen_05 { get; set; }
        public Squad_dog_turrets_06 dog_turrets_06 { get; set; }
        public Squad_dog_turret_men_06 dog_turret_men_06 { get; set; }
        public Squad_dog_sen_06 dog_sen_06 { get; set; }
        public Squad_dog_turrets_07 dog_turrets_07 { get; set; }
        public Squad_dog_turret_men_07 dog_turret_men_07 { get; set; }
        public Squad_dog_flak_07 dog_flak_07 { get; set; }
        public Squad_hl_escort_sentinels hl_escort_sentinels { get; set; }
        public Squad_allies_elites_03 allies_elites_03 { get; set; }
        public Squad_allies_grunts_03 allies_grunts_03 { get; set; }
        public Squad_resupply_phantom resupply_phantom { get; set; }
        public Squad_eye01 eye01 { get; set; }
        public Squad_eye02 eye02 { get; set; }
        public Squad_eye03 eye03 { get; set; }
        public Squad_eye04 eye04 { get; set; }
        public Squad_eye05 eye05 { get; set; }
        public Squad_eye06 eye06 { get; set; }
        public Squad_eye07 eye07 { get; set; }
        public Squad_eye08 eye08 { get; set; }
        public Squad_eye09 eye09 { get; set; }
        public Squad_resupply_banshee resupply_banshee { get; set; }
        public Squad_arm02_final_grunts arm02_final_grunts { get; set; }
        public Squad_arm02_final_heretics arm02_final_heretics { get; set; }
        public Squad_bday_party bday_party { get; set; }
        public Squad_chasers chasers { get; set; }
        public Squad_turret_test turret_test { get; set; }
        public IAiActorDefinition all_allies => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition all_enemies => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition arm01_allies => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition allies_elites => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition allies_grunts => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition rec_center_heretics => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition rec_center_h_entry => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition rec_center_h_slope => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition rec_center_h_below => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition rec_center_h_end => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition hangar_heretics => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition hangar_heretics_init => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition hangar_heretics_after => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition hangar_sentinels => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition a50_high => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition a50_low => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition first_hall_heretics => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition underhangar_heretics => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition second_hall_heretics => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition bottling_enemies => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition bottling_heretics => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition bottling_firsthalf => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition bottling_heretics_start => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition bottling_sentinels => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition dogfighters_01 => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition dogfight_allies => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition arm02_allies => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition dog_obj_emplaced_01 => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition dog_obj_emplaced_02 => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition dog_obj_emplaced_03 => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition dog_obj_emplaced_04 => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition dog_obj_emplaced_05 => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition dog_obj_emplaced_06 => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition dog_obj_emplaced_07 => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition dog_07_turrets => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition eyes_in_the_sky => Scenario.AiSquadGroupDefinitions[35];
        public IAiOrders lz_phantoms => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders deploy_elites => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders lz_lingerers => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders lz_linger => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders allies_enter => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders allies_rec_hide => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders allies_rec_center_all => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders allies_rec_center_under => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders get_on_hangar_elev => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders standby_hangar_elev => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders ride_hangar_elev => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders rec_center_patrol_01L => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders rec_center_patrol_01R => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders rec_center_patrol_02 => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders rec_center_patrol_03 => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders rec_center_patrol_04 => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders rec_center_h_01 => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders rec_center_h_02 => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders rec_center_h_03 => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders rec_center_h_04 => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders rec_center_h_05 => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders rec_center_h_06 => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders rec_center_h_07 => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders rec_center_h_08 => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders rec_center_h_09 => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders rec_center_h_04_retreat => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders rec_center_h_05_retreat => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders rec_center_h_06_retreat => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders rec_center_h_07_retreat => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders rec_center_h_08_retreat => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders allies_hangar_top => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders allies_hangar_bottom => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders hangar_rein_hold => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders hangar_rein_enter_L => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders hangar_rein_enter_R => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders testit => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders hangar_h_wave_01R => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders hangar_h_wave_01L => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders hangar_h_wave_02R => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders hangar_h_wave_02L => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders hangar_h_wave_03R => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders hangar_h_wave_03L => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders defend_switch => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders defend_switch_L => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders defend_switch_R => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders hangar_h_wave_04 => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders hangar_h_wave_05r => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders hangar_h_wave_05c => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders hangar_h_wave_05l => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders hangar_h_wave_end => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders hangar_s_helpers => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders hangar_s_wave_02_top => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders hangar_s_wave_02_low => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders allies_first_hall => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders halls_hangar_to_under_p1 => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders halls_hangar_to_under_p2 => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders allies_underhangar => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders underhangar_heretics_01 => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders underhangar_heretics_01b => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders underhangar_heretics_02 => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders underhangar_heretics_03 => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders underhangar_heretics_04 => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders allies_second_hall => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders under_to_bottling_01 => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders under_to_bottling_02 => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders under_to_bottling_03 => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders under_to_bottling_04 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders allies_bottling => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders bottling_h_low_01 => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders bottling_h_low_01r => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders bottling_h_low_02 => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders bottling_h_low_02r => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders bottling_h_low_03 => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders bottling_h_high_01 => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders bottling_h_high_01r => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders bottling_h_high_02 => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders bottling_h_high_03 => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders bottling_h_wave_04 => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders bottling_h_wave_04r => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders bottling_h_wave_05_high => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders bottling_h_wave_05_low => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders bottling_h_wave_06 => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders bottling_s_wave_01 => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders bottling_s_wave_02 => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders bottling_s_wave_03 => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders bottling_s_wave_04_low => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders bottling_s_wave_04_top => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders bottling_s_wave_05 => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders dogfight01_cell_01 => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders dogfight01_cell_02 => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders dogfight01_cell_03 => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders dogfight01_cell_04 => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders dogfight01_cell_05 => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders dogfight01_cell_06 => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders dogfight01_cell_07 => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders dog_ph_obj_01 => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders dog_ph_obj_02 => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders dog_ph_obj_03 => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders dog_ph_obj_04 => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders dog_ph_obj_05 => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders dog_ph_obj_06 => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders dog_ph_obj_07 => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders emplace_01 => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders emplace_02 => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders emplace_03_h => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders emplace_03_s => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders emplace_04 => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders emplace_05 => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders emplace_06_h => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders emplace_06_s => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders emplace_07 => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders escort_sentinels => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders allies_arm02_lz => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders dog_ph_obj_park => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders arm02_SWAT => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders phantom_brings_banshee => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders phantom_brings_prod_01 => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders see_player => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders a50_high_r_far => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders a50_high_r_near => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders a50_high_l_far => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders a50_high_l_near => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders a50_low_l => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders a50_low_r => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders chase01 => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders chase02 => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders chase03 => Scenario.AiOrderDefinitions[126].GameObject;
        public ILocationFlag cinematic_anchor => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag cinematic_anchor02 => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag cinematic_anchor03 => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag hangar_top_player0 => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag hangar_top_player1 => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag hangar_top_ally01 => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag hangar_top_ally02 => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag hangar_top_ally03 => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag hangar_top_ally04 => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag underhangar_player0 => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag underhangar_player1 => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag underhangar_ally01 => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag underhangar_ally02 => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag underhangar_ally03 => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag underhangar_ally04 => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag bottling_player0 => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag bottling_player1 => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag bottling_ally01 => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag bottling_ally02 => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag bottling_ally03 => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag bottling_ally04 => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag banshee_ledge_player0 => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag banshee_ledge_player1 => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag spawn_pt_01 => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag spawn_pt_02 => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag spawn_pt_03 => Scenario.LocationFlagDefinitions[27];
        public ILocationFlag spawn_pt_04 => Scenario.LocationFlagDefinitions[28];
        public ILocationFlag spawn_pt_05 => Scenario.LocationFlagDefinitions[29];
        public ILocationFlag spawn_pt_06 => Scenario.LocationFlagDefinitions[30];
        public ILocationFlag spawn_pt_07 => Scenario.LocationFlagDefinitions[31];
        public ILocationFlag spawn_pt_08 => Scenario.LocationFlagDefinitions[32];
        public ILocationFlag anchor_flag_x04a => Scenario.LocationFlagDefinitions[33];
        public ILocationFlag anchor_flag_x04b => Scenario.LocationFlagDefinitions[34];
        public ILocationFlag hang_L_e_01 => Scenario.LocationFlagDefinitions[35];
        public ILocationFlag hang_L_e_02 => Scenario.LocationFlagDefinitions[36];
        public ILocationFlag hang_L_g_01 => Scenario.LocationFlagDefinitions[37];
        public ILocationFlag hang_L_g_02 => Scenario.LocationFlagDefinitions[38];
        public ILocationFlag hang_R_e_01 => Scenario.LocationFlagDefinitions[39];
        public ILocationFlag hang_R_e_02 => Scenario.LocationFlagDefinitions[40];
        public ILocationFlag hang_R_g_01 => Scenario.LocationFlagDefinitions[41];
        public ILocationFlag hang_R_g_02 => Scenario.LocationFlagDefinitions[42];
        public ILocationFlag _01a => Scenario.LocationFlagDefinitions[43];
        public ILocationFlag _01b => Scenario.LocationFlagDefinitions[44];
        public ILocationFlag _01c => Scenario.LocationFlagDefinitions[45];
        public ILocationFlag _01d => Scenario.LocationFlagDefinitions[46];
        public ILocationFlag _02a => Scenario.LocationFlagDefinitions[47];
        public ILocationFlag _02b => Scenario.LocationFlagDefinitions[48];
        public ILocationFlag _02c => Scenario.LocationFlagDefinitions[49];
        public ILocationFlag _02d => Scenario.LocationFlagDefinitions[50];
        public ILocationFlag _03a => Scenario.LocationFlagDefinitions[51];
        public ILocationFlag _03b => Scenario.LocationFlagDefinitions[52];
        public ILocationFlag _03c => Scenario.LocationFlagDefinitions[53];
        public ILocationFlag _04a => Scenario.LocationFlagDefinitions[54];
        public ILocationFlag _04b => Scenario.LocationFlagDefinitions[55];
        public ILocationFlag _05a => Scenario.LocationFlagDefinitions[56];
        public ILocationFlag _05b => Scenario.LocationFlagDefinitions[57];
        public ILocationFlag _06a => Scenario.LocationFlagDefinitions[58];
        public ILocationFlag _06b => Scenario.LocationFlagDefinitions[59];
        public ILocationFlag _07a => Scenario.LocationFlagDefinitions[60];
        public ILocationFlag _07b => Scenario.LocationFlagDefinitions[61];
        public ILocationFlag _07c => Scenario.LocationFlagDefinitions[62];
        public ILocationFlag _08a => Scenario.LocationFlagDefinitions[63];
        public ILocationFlag _08b => Scenario.LocationFlagDefinitions[64];
        public ILocationFlag _09a => Scenario.LocationFlagDefinitions[65];
        public ILocationFlag _09b => Scenario.LocationFlagDefinitions[66];
        public ILocationFlag _10a => Scenario.LocationFlagDefinitions[67];
        public ILocationFlag _10b => Scenario.LocationFlagDefinitions[68];
        public ILocationFlag _11a => Scenario.LocationFlagDefinitions[69];
        public ILocationFlag _11b => Scenario.LocationFlagDefinitions[70];
        public ILocationFlag _11c => Scenario.LocationFlagDefinitions[71];
        public ILocationFlag _12a => Scenario.LocationFlagDefinitions[72];
        public ILocationFlag _12b => Scenario.LocationFlagDefinitions[73];
        public ILocationFlag _12c => Scenario.LocationFlagDefinitions[74];
        public ILocationFlag _13a => Scenario.LocationFlagDefinitions[75];
        public ILocationFlag _13b => Scenario.LocationFlagDefinitions[76];
        public ILocationFlag _13c => Scenario.LocationFlagDefinitions[77];
        public ILocationFlag _14a => Scenario.LocationFlagDefinitions[78];
        public ILocationFlag _14b => Scenario.LocationFlagDefinitions[79];
        public ILocationFlag _15a => Scenario.LocationFlagDefinitions[80];
        public ILocationFlag _15b => Scenario.LocationFlagDefinitions[81];
        public ILocationFlag gas011 => Scenario.LocationFlagDefinitions[82];
        public ILocationFlag banshee_intro => Scenario.LocationFlagDefinitions[83];
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_2 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ITriggerVolume vol_starting_locations => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume vol_leaving_lz => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume vol_phantom_kill => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume vol_entry_landing => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume vol_entry_area => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume vol_entering_facility => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume vol_recycling_all => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume vol_recycling_start => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume vol_heretic_chat => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume vol_rec_slope_top => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume vol_recycling_mid_01 => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume vol_recycling_mid_02 => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume vol_rec_slope_end => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume vol_leaving_rec_center => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume vol_hangar_lift_top => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume vol_elev_to_hangar => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume vol_on_hangar_lift_top => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume vol_trigger_helpers => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume vol_hangar_elev_bottom => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume vol_hangar_elev_left => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume vol_hangar_elev_right => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume vol_hangar_left_start => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume vol_hangar_start_left => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume vol_hangar_start_right => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume vol_hangar_mid_left => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume vol_hangar_mid_right => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume vol_hangar_end_right => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume vol_hangar_end_left => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume vol_hangar_left => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume vol_hangar_right => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume vol_hangar_top => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume vol_hangar_low => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume vol_hangar_near_half => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume vol_hangar_far_half => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume vol_hangar_two_thirds => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume vol_hangar_center => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume vol_hangar_center_end => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume vol_hangar_center_exit => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume vol_hangar_by_door => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume vol_hang_rein_entry_l => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume vol_hang_rein_entry_r => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume vol_hangar_spawn_01r => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume vol_hangar_spawn_02r => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume vol_hangar_spawn_03r => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume vol_hangar_spawn_01l => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume vol_hangar_spawn_02l => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume vol_hangar_spawn_03l => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume vol_leaving_hangar => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume vol_hangar_reenter => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume vol_first_hall_01 => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume vol_underhangar_reinforce => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume vol_underhangar_from_top => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume vol_underhangar_low => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume vol_underhangar_top => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume vol_underhangar_from_bottom => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume vol_underhangar_start => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume vol_underhangar_halfway => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume vol_underhangar_end => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume vol_2nd_hall_01 => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume vol_2nd_hall_02 => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume vol_2nd_hall_03 => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume vol_hl_delete_01 => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume vol_bottling_reinforce => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume vol_bottling_enter => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume vol_bottling_really_inside => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume vol_bottling_mid01 => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume vol_bottling_mid02 => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume vol_bottling_mid03 => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume vol_hl_retreat_02 => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume vol_bottling_back => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume vol_bottling_back_top => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume vol_hl_delete_02 => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume vol_bottling_exit_r => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume vol_bottling_exit_l => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume vol_on_banshee_ledge => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume vol_dog_obj_02 => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume vol_dog_obj_03 => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume vol_dog_obj_04 => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume vol_dog_obj_05 => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume vol_dog_obj_06 => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume vol_dog_obj_07 => Scenario.TriggerVolumes[80].GameObject;
        public ITriggerVolume vol_arm_02_lz => Scenario.TriggerVolumes[81].GameObject;
        public ITriggerVolume vol_04a_game_won => Scenario.TriggerVolumes[82].GameObject;
        public ITriggerVolume kill_lz_pit => Scenario.TriggerVolumes[83].GameObject;
        public ITriggerVolume kill_recycling_pit => Scenario.TriggerVolumes[84].GameObject;
        public ITriggerVolume kill_recycling_left => Scenario.TriggerVolumes[85].GameObject;
        public ITriggerVolume kill_recycling_right => Scenario.TriggerVolumes[86].GameObject;
        public ITriggerVolume kill_hangar_pit_01 => Scenario.TriggerVolumes[87].GameObject;
        public ITriggerVolume kill_hangar_pit_02 => Scenario.TriggerVolumes[88].GameObject;
        public ITriggerVolume kill_hangar_pit_03 => Scenario.TriggerVolumes[89].GameObject;
        public ITriggerVolume kill_hangar_pit_04 => Scenario.TriggerVolumes[90].GameObject;
        public ITriggerVolume kill_underhangar_pit_01 => Scenario.TriggerVolumes[91].GameObject;
        public ITriggerVolume kill_underhangar_pit_02 => Scenario.TriggerVolumes[92].GameObject;
        public ITriggerVolume kill_bottling_pit_01 => Scenario.TriggerVolumes[93].GameObject;
        public ITriggerVolume kill_bottling_pit_02 => Scenario.TriggerVolumes[94].GameObject;
        public ITriggerVolume vol_recycling_can_all => Scenario.TriggerVolumes[95].GameObject;
        public ITriggerVolume vol_hangar_can_all => Scenario.TriggerVolumes[96].GameObject;
        public ITriggerVolume vol_underhangar_can_all => Scenario.TriggerVolumes[97].GameObject;
        public ITriggerVolume vol_bottling_can_all => Scenario.TriggerVolumes[98].GameObject;
        public ITriggerVolume bsp_0_3 => Scenario.TriggerVolumes[99].GameObject;
        public ITriggerVolume bsp_3_0 => Scenario.TriggerVolumes[100].GameObject;
        public ITriggerVolume trans_3_0 => Scenario.TriggerVolumes[101].GameObject;
        public ITriggerVolume trans_0_3 => Scenario.TriggerVolumes[102].GameObject;
        public ITriggerVolume trans_3_01 => Scenario.TriggerVolumes[103].GameObject;
        public ITriggerVolume vol_arm02_air => Scenario.TriggerVolumes[104].GameObject;
        public ITriggerVolume vol_stuck_01 => Scenario.TriggerVolumes[105].GameObject;
        public ITriggerVolume vol_stuck_02 => Scenario.TriggerVolumes[106].GameObject;
        public ITriggerVolume vol_stuck_03 => Scenario.TriggerVolumes[107].GameObject;
        public ITriggerVolume vol_stuck_04 => Scenario.TriggerVolumes[108].GameObject;
        public ITriggerVolume vol_stuck_05 => Scenario.TriggerVolumes[109].GameObject;
        public ITriggerVolume vol_stuck_06 => Scenario.TriggerVolumes[110].GameObject;
        public ITriggerVolume vol_stuck_07 => Scenario.TriggerVolumes[111].GameObject;
        public ITriggerVolume vol_stuck_08 => Scenario.TriggerVolumes[112].GameObject;
        public ITriggerVolume vol_stuck_09 => Scenario.TriggerVolumes[113].GameObject;
        public ITriggerVolume vol_stuck_10 => Scenario.TriggerVolumes[114].GameObject;
        public ITriggerVolume vol_stuck_11 => Scenario.TriggerVolumes[115].GameObject;
        public ITriggerVolume vol_stuck_12 => Scenario.TriggerVolumes[116].GameObject;
        public ITriggerVolume vol_stuck_13 => Scenario.TriggerVolumes[117].GameObject;
        public ITriggerVolume vol_stuck_14 => Scenario.TriggerVolumes[118].GameObject;
        public ITriggerVolume vol_stuck_15 => Scenario.TriggerVolumes[119].GameObject;
        public ITriggerVolume vol_grunt_bday => Scenario.TriggerVolumes[120].GameObject;
        public ITriggerVolume vol_real_win => Scenario.TriggerVolumes[121].GameObject;
        public ITriggerVolume kill_banshee_ledge => Scenario.TriggerVolumes[122].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile player_starting_profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IStartingProfile swap => Scenario.StartingProfileDefinitions[2].GameObject;
        public IDeviceGroup elev_hangar1 => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup hangar_door => Scenario.DeviceGroupDefinitions[1].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            anchor03 = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            outro_seraph = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            holo_drone_2 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            holo_drone_1 = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            sarcophagus = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            recycling_can_a = new ScenarioEntity<IBloc>(5, scenarioTag.WellKnownItems[5]);
            recycling_can_b = new ScenarioEntity<IBloc>(6, scenarioTag.WellKnownItems[6]);
            recycling_can_c = new ScenarioEntity<IBloc>(7, scenarioTag.WellKnownItems[7]);
            honor_guard_02 = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            honor_guard_04 = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            honor_guard_05 = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            honor_guard_06 = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            honor_guard_14 = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            honor_guard_15 = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            honor_guard_16 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            honor_guard_17 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            honor_guard_18 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            honor_guard_19 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            honor_guard_20 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            honor_guard_28 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            honor_guard_29 = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            honor_guard_30 = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            elev_crate_01 = new ScenarioEntity<IBloc>(22, scenarioTag.WellKnownItems[22]);
            elev_crate_02 = new ScenarioEntity<IBloc>(23, scenarioTag.WellKnownItems[23]);
            hangar_can_a = new ScenarioEntity<IBloc>(24, scenarioTag.WellKnownItems[24]);
            hangar_can_b = new ScenarioEntity<IBloc>(25, scenarioTag.WellKnownItems[25]);
            hangar_can_c = new ScenarioEntity<IBloc>(26, scenarioTag.WellKnownItems[26]);
            hangar_can_d = new ScenarioEntity<IBloc>(27, scenarioTag.WellKnownItems[27]);
            underhangar_can_a = new ScenarioEntity<IBloc>(28, scenarioTag.WellKnownItems[28]);
            underhangar_can_b = new ScenarioEntity<IBloc>(29, scenarioTag.WellKnownItems[29]);
            bottling_can_a = new ScenarioEntity<IBloc>(30, scenarioTag.WellKnownItems[30]);
            bottling_can_b = new ScenarioEntity<IBloc>(31, scenarioTag.WellKnownItems[31]);
            help_can_01 = new ScenarioEntity<IBloc>(32, scenarioTag.WellKnownItems[32]);
            help_can_02 = new ScenarioEntity<IBloc>(33, scenarioTag.WellKnownItems[33]);
            honor_guard_31 = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            honor_guard_32 = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            honor_guard_33 = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            honor_guard_34 = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            hammer = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            null_intro = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            anchor02 = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            phantom_int = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            matte_halo_01 = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            matte_threshold = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            matte_mine = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            matte_structure_top = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            matte_structure = new ScenarioEntity<IScenery>(46, scenarioTag.WellKnownItems[46]);
            matte_high_charity = new ScenarioEntity<IScenery>(47, scenarioTag.WellKnownItems[47]);
            hangar_door_ingame = new ScenarioEntity<IScenery>(48, scenarioTag.WellKnownItems[48]);
            beam_rifle01 = new ScenarioEntity<IScenery>(49, scenarioTag.WellKnownItems[49]);
            plasma_rifle01 = new ScenarioEntity<IScenery>(50, scenarioTag.WellKnownItems[50]);
            plasma_rifle02 = new ScenarioEntity<IScenery>(51, scenarioTag.WellKnownItems[51]);
            plasma_rifle03 = new ScenarioEntity<IScenery>(52, scenarioTag.WellKnownItems[52]);
            plasma_rifle04 = new ScenarioEntity<IScenery>(53, scenarioTag.WellKnownItems[53]);
            plasma_rifle05 = new ScenarioEntity<IScenery>(54, scenarioTag.WellKnownItems[54]);
            plasma_rifle06 = new ScenarioEntity<IScenery>(55, scenarioTag.WellKnownItems[55]);
            plasma_pistol01 = new ScenarioEntity<IScenery>(56, scenarioTag.WellKnownItems[56]);
            plasma_pistol02 = new ScenarioEntity<IScenery>(57, scenarioTag.WellKnownItems[57]);
            plasma_pistol03 = new ScenarioEntity<IScenery>(58, scenarioTag.WellKnownItems[58]);
            energy_blade02 = new ScenarioEntity<IScenery>(59, scenarioTag.WellKnownItems[59]);
            plasma_pistol04 = new ScenarioEntity<IScenery>(60, scenarioTag.WellKnownItems[60]);
            rec_can_a_01 = new ScenarioEntity<IBloc>(61, scenarioTag.WellKnownItems[61]);
            rec_can_a_02 = new ScenarioEntity<IBloc>(62, scenarioTag.WellKnownItems[62]);
            rec_can_a_03 = new ScenarioEntity<IBloc>(63, scenarioTag.WellKnownItems[63]);
            rec_can_a_04 = new ScenarioEntity<IBloc>(64, scenarioTag.WellKnownItems[64]);
            rec_can_a_06 = new ScenarioEntity<IBloc>(65, scenarioTag.WellKnownItems[65]);
            rec_can_a_07 = new ScenarioEntity<IBloc>(66, scenarioTag.WellKnownItems[66]);
            rec_can_b_01 = new ScenarioEntity<IBloc>(67, scenarioTag.WellKnownItems[67]);
            rec_can_b_02 = new ScenarioEntity<IBloc>(68, scenarioTag.WellKnownItems[68]);
            rec_can_c_01 = new ScenarioEntity<IBloc>(69, scenarioTag.WellKnownItems[69]);
            rec_can_c_02 = new ScenarioEntity<IBloc>(70, scenarioTag.WellKnownItems[70]);
            rec_can_c_03 = new ScenarioEntity<IBloc>(71, scenarioTag.WellKnownItems[71]);
            rec_can_c_04 = new ScenarioEntity<IBloc>(72, scenarioTag.WellKnownItems[72]);
            rec_can_c_06 = new ScenarioEntity<IBloc>(73, scenarioTag.WellKnownItems[73]);
            blocker_l = new ScenarioEntity<IScenery>(74, scenarioTag.WellKnownItems[74]);
            blocker_r = new ScenarioEntity<IScenery>(75, scenarioTag.WellKnownItems[75]);
            anchor_x04b = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            anchor_x04a = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            gas01 = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            gas02 = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            gas03 = new ScenarioEntity<IScenery>(80, scenarioTag.WellKnownItems[80]);
            gas04 = new ScenarioEntity<IScenery>(81, scenarioTag.WellKnownItems[81]);
            gas05 = new ScenarioEntity<IScenery>(82, scenarioTag.WellKnownItems[82]);
            gas06 = new ScenarioEntity<IScenery>(83, scenarioTag.WellKnownItems[83]);
            gas07 = new ScenarioEntity<IScenery>(84, scenarioTag.WellKnownItems[84]);
            gas08 = new ScenarioEntity<IScenery>(85, scenarioTag.WellKnownItems[85]);
            gas09 = new ScenarioEntity<IScenery>(86, scenarioTag.WellKnownItems[86]);
            gas10 = new ScenarioEntity<IScenery>(87, scenarioTag.WellKnownItems[87]);
            approach_here = new ScenarioEntity<IScenery>(88, scenarioTag.WellKnownItems[88]);
            energy_blade01 = new ScenarioEntity<IScenery>(89, scenarioTag.WellKnownItems[89]);
            jail_ledge = new ScenarioEntity<IScenery>(90, scenarioTag.WellKnownItems[90]);
            hang_can_01 = new ScenarioEntity<IBloc>(91, scenarioTag.WellKnownItems[91]);
            hang_can_02 = new ScenarioEntity<IBloc>(92, scenarioTag.WellKnownItems[92]);
            hang_can_03 = new ScenarioEntity<IBloc>(93, scenarioTag.WellKnownItems[93]);
            hang_can_04 = new ScenarioEntity<IBloc>(94, scenarioTag.WellKnownItems[94]);
            hang_can_05 = new ScenarioEntity<IBloc>(95, scenarioTag.WellKnownItems[95]);
            underhang_can_01 = new ScenarioEntity<IBloc>(96, scenarioTag.WellKnownItems[96]);
            underhang_can_02 = new ScenarioEntity<IBloc>(97, scenarioTag.WellKnownItems[97]);
            underhang_can_03 = new ScenarioEntity<IBloc>(98, scenarioTag.WellKnownItems[98]);
            underhang_can_04 = new ScenarioEntity<IBloc>(99, scenarioTag.WellKnownItems[99]);
            bott_can_01 = new ScenarioEntity<IBloc>(100, scenarioTag.WellKnownItems[100]);
            bott_can_02 = new ScenarioEntity<IBloc>(101, scenarioTag.WellKnownItems[101]);
            intro_fleet = new ScenarioEntity<IScenery>(102, scenarioTag.WellKnownItems[102]);
            stardust_01 = new ScenarioEntity<IScenery>(103, scenarioTag.WellKnownItems[103]);
            stardust_02 = new ScenarioEntity<IScenery>(104, scenarioTag.WellKnownItems[104]);
            brute_01 = new ScenarioEntity<IUnit>(105, scenarioTag.WellKnownItems[105]);
            brute_02 = new ScenarioEntity<IUnit>(106, scenarioTag.WellKnownItems[106]);
            dervish = new ScenarioEntity<IUnit>(107, scenarioTag.WellKnownItems[107]);
            tartarus = new ScenarioEntity<IUnit>(108, scenarioTag.WellKnownItems[108]);
            jackal_01 = new ScenarioEntity<IUnit>(109, scenarioTag.WellKnownItems[109]);
            jackal_02 = new ScenarioEntity<IUnit>(110, scenarioTag.WellKnownItems[110]);
            jackal_03 = new ScenarioEntity<IUnit>(111, scenarioTag.WellKnownItems[111]);
            truth = new ScenarioEntity<IUnit>(112, scenarioTag.WellKnownItems[112]);
            mercy = new ScenarioEntity<IUnit>(113, scenarioTag.WellKnownItems[113]);
            commander = new ScenarioEntity<IUnit>(114, scenarioTag.WellKnownItems[114]);
            elite01 = new ScenarioEntity<IUnit>(115, scenarioTag.WellKnownItems[115]);
            dervish02 = new ScenarioEntity<IUnit>(116, scenarioTag.WellKnownItems[116]);
            elite02 = new ScenarioEntity<IUnit>(117, scenarioTag.WellKnownItems[117]);
            elite03 = new ScenarioEntity<IUnit>(118, scenarioTag.WellKnownItems[118]);
            elite04 = new ScenarioEntity<IUnit>(119, scenarioTag.WellKnownItems[119]);
            elite05 = new ScenarioEntity<IUnit>(120, scenarioTag.WellKnownItems[120]);
            elite06 = new ScenarioEntity<IUnit>(121, scenarioTag.WellKnownItems[121]);
            elite07 = new ScenarioEntity<IUnit>(122, scenarioTag.WellKnownItems[122]);
            grunt01 = new ScenarioEntity<IUnit>(123, scenarioTag.WellKnownItems[123]);
            grunt02 = new ScenarioEntity<IUnit>(124, scenarioTag.WellKnownItems[124]);
            grunt03 = new ScenarioEntity<IUnit>(125, scenarioTag.WellKnownItems[125]);
            grunt04 = new ScenarioEntity<IUnit>(126, scenarioTag.WellKnownItems[126]);
            heretic_leader_holo_01 = new ScenarioEntity<IUnit>(127, scenarioTag.WellKnownItems[127]);
            throne_truth = new ScenarioEntity<IVehicle>(128, scenarioTag.WellKnownItems[128]);
            throne_mercy = new ScenarioEntity<IVehicle>(129, scenarioTag.WellKnownItems[129]);
            phantom01 = new ScenarioEntity<IVehicle>(130, scenarioTag.WellKnownItems[130]);
            phantom02 = new ScenarioEntity<IVehicle>(131, scenarioTag.WellKnownItems[131]);
            phantom03 = new ScenarioEntity<IVehicle>(132, scenarioTag.WellKnownItems[132]);
            phantom_01 = new ScenarioEntity<IVehicle>(133, scenarioTag.WellKnownItems[133]);
            phantom_02 = new ScenarioEntity<IVehicle>(134, scenarioTag.WellKnownItems[134]);
            phantom_03 = new ScenarioEntity<IVehicle>(135, scenarioTag.WellKnownItems[135]);
            extra09a = new ScenarioEntity<IVehicle>(136, scenarioTag.WellKnownItems[136]);
            extra09b = new ScenarioEntity<IVehicle>(137, scenarioTag.WellKnownItems[137]);
            extra08a = new ScenarioEntity<IVehicle>(138, scenarioTag.WellKnownItems[138]);
            extra08b = new ScenarioEntity<IVehicle>(139, scenarioTag.WellKnownItems[139]);
            extra06a = new ScenarioEntity<IVehicle>(140, scenarioTag.WellKnownItems[140]);
            extra06b = new ScenarioEntity<IVehicle>(141, scenarioTag.WellKnownItems[141]);
            extra05a = new ScenarioEntity<IVehicle>(142, scenarioTag.WellKnownItems[142]);
            extra05b = new ScenarioEntity<IVehicle>(143, scenarioTag.WellKnownItems[143]);
            extra10a = new ScenarioEntity<IVehicle>(144, scenarioTag.WellKnownItems[144]);
            extra10b = new ScenarioEntity<IVehicle>(145, scenarioTag.WellKnownItems[145]);
            extra02a = new ScenarioEntity<IVehicle>(146, scenarioTag.WellKnownItems[146]);
            extra02b = new ScenarioEntity<IVehicle>(147, scenarioTag.WellKnownItems[147]);
            extra02c = new ScenarioEntity<IVehicle>(148, scenarioTag.WellKnownItems[148]);
            extra02d = new ScenarioEntity<IVehicle>(149, scenarioTag.WellKnownItems[149]);
            extra12a = new ScenarioEntity<IVehicle>(150, scenarioTag.WellKnownItems[150]);
            extra12b = new ScenarioEntity<IVehicle>(151, scenarioTag.WellKnownItems[151]);
            extra12c = new ScenarioEntity<IVehicle>(152, scenarioTag.WellKnownItems[152]);
            extra03a = new ScenarioEntity<IVehicle>(153, scenarioTag.WellKnownItems[153]);
            extra03b = new ScenarioEntity<IVehicle>(154, scenarioTag.WellKnownItems[154]);
            extra03c = new ScenarioEntity<IVehicle>(155, scenarioTag.WellKnownItems[155]);
            extra01a = new ScenarioEntity<IVehicle>(156, scenarioTag.WellKnownItems[156]);
            extra01b = new ScenarioEntity<IVehicle>(157, scenarioTag.WellKnownItems[157]);
            extra01c = new ScenarioEntity<IVehicle>(158, scenarioTag.WellKnownItems[158]);
            extra01d = new ScenarioEntity<IVehicle>(159, scenarioTag.WellKnownItems[159]);
            extra11a = new ScenarioEntity<IVehicle>(160, scenarioTag.WellKnownItems[160]);
            extra11b = new ScenarioEntity<IVehicle>(161, scenarioTag.WellKnownItems[161]);
            extra11c = new ScenarioEntity<IVehicle>(162, scenarioTag.WellKnownItems[162]);
            extra04a = new ScenarioEntity<IVehicle>(163, scenarioTag.WellKnownItems[163]);
            extra04b = new ScenarioEntity<IVehicle>(164, scenarioTag.WellKnownItems[164]);
            extra14a = new ScenarioEntity<IVehicle>(165, scenarioTag.WellKnownItems[165]);
            extra14b = new ScenarioEntity<IVehicle>(166, scenarioTag.WellKnownItems[166]);
            extra07a = new ScenarioEntity<IVehicle>(167, scenarioTag.WellKnownItems[167]);
            extra07b = new ScenarioEntity<IVehicle>(168, scenarioTag.WellKnownItems[168]);
            extra07c = new ScenarioEntity<IVehicle>(169, scenarioTag.WellKnownItems[169]);
            extra15a = new ScenarioEntity<IVehicle>(170, scenarioTag.WellKnownItems[170]);
            extra15b = new ScenarioEntity<IVehicle>(171, scenarioTag.WellKnownItems[171]);
            extra13a = new ScenarioEntity<IVehicle>(172, scenarioTag.WellKnownItems[172]);
            extra13b = new ScenarioEntity<IVehicle>(173, scenarioTag.WellKnownItems[173]);
            extra13c = new ScenarioEntity<IVehicle>(174, scenarioTag.WellKnownItems[174]);
            mid_banshee_01 = new ScenarioEntity<IVehicle>(175, scenarioTag.WellKnownItems[175]);
            mid_banshee_02 = new ScenarioEntity<IVehicle>(176, scenarioTag.WellKnownItems[176]);
            hl_banshee = new ScenarioEntity<IVehicle>(177, scenarioTag.WellKnownItems[177]);
            bday_cake = new ScenarioEntity<IWeapon>(178, scenarioTag.WellKnownItems[178]);
            alpha_gas_exterior = new ScenarioEntity<ISound>(179, scenarioTag.WellKnownItems[179]);
            filthy_audio1 = new ScenarioEntity<ISound>(180, scenarioTag.WellKnownItems[180]);
            filthy_audio2 = new ScenarioEntity<ISound>(181, scenarioTag.WellKnownItems[181]);
            big_filthy_audio1 = new ScenarioEntity<ISound>(182, scenarioTag.WellKnownItems[182]);
            viewroom_exit01 = new ScenarioEntity<IDevice>(215, scenarioTag.WellKnownItems[215]);
            viewroom_entry = new ScenarioEntity<IDevice>(216, scenarioTag.WellKnownItems[216]);
            banshee_ledge_access_01 = new ScenarioEntity<IDevice>(217, scenarioTag.WellKnownItems[217]);
            bottling_midway = new ScenarioEntity<IDevice>(218, scenarioTag.WellKnownItems[218]);
            lab_exit_ext = new ScenarioEntity<IDevice>(219, scenarioTag.WellKnownItems[219]);
            arm_02_entry_ext = new ScenarioEntity<IDevice>(220, scenarioTag.WellKnownItems[220]);
            viewroom_exit02 = new ScenarioEntity<IDevice>(221, scenarioTag.WellKnownItems[221]);
            elev_hangar = new ScenarioEntity<IDevice>(222, scenarioTag.WellKnownItems[222]);
            seraph = new ScenarioEntity<IDevice>(223, scenarioTag.WellKnownItems[223]);
            banshee_ledge_access_02 = new ScenarioEntity<IDevice>(224, scenarioTag.WellKnownItems[224]);
            x1sided05 = new ScenarioEntity<IDevice>(225, scenarioTag.WellKnownItems[225]);
            hangar_switch01 = new ScenarioEntity<IDevice>(226, scenarioTag.WellKnownItems[226]);
            hangar_switch02 = new ScenarioEntity<IDevice>(227, scenarioTag.WellKnownItems[227]);
            rec_center_entry_ext = new ScenarioEntity<IDevice>(228, scenarioTag.WellKnownItems[228]);
            rec_center_entry_int = new ScenarioEntity<IDevice>(229, scenarioTag.WellKnownItems[229]);
            rec_cen_rein_01r = new ScenarioEntity<IDevice>(230, scenarioTag.WellKnownItems[230]);
            rec_cen_rein_01l = new ScenarioEntity<IDevice>(231, scenarioTag.WellKnownItems[231]);
            hang_01r = new ScenarioEntity<IDevice>(232, scenarioTag.WellKnownItems[232]);
            hang_02r = new ScenarioEntity<IDevice>(233, scenarioTag.WellKnownItems[233]);
            hang_03r = new ScenarioEntity<IDevice>(234, scenarioTag.WellKnownItems[234]);
            hang_01l = new ScenarioEntity<IDevice>(235, scenarioTag.WellKnownItems[235]);
            hang_02l = new ScenarioEntity<IDevice>(236, scenarioTag.WellKnownItems[236]);
            hang_03l = new ScenarioEntity<IDevice>(237, scenarioTag.WellKnownItems[237]);
            hangar_exit = new ScenarioEntity<IDevice>(238, scenarioTag.WellKnownItems[238]);
            underhangar_entry = new ScenarioEntity<IDevice>(239, scenarioTag.WellKnownItems[239]);
            underhangar_exit = new ScenarioEntity<IDevice>(240, scenarioTag.WellKnownItems[240]);
            bottling_entry = new ScenarioEntity<IDevice>(241, scenarioTag.WellKnownItems[241]);
            hangar_door_cinematic = new ScenarioEntity<IDevice>(242, scenarioTag.WellKnownItems[242]);
            x04_door_01 = new ScenarioEntity<IDevice>(243, scenarioTag.WellKnownItems[243]);
            hangar_door_switch_r = new ScenarioEntity<IDevice>(244, scenarioTag.WellKnownItems[244]);
            hangar_door_switch_l = new ScenarioEntity<IDevice>(245, scenarioTag.WellKnownItems[245]);
            x04_button = new ScenarioEntity<IDevice>(246, scenarioTag.WellKnownItems[246]);
            intro_elites = new Squad_intro_elites(scenarioTag);
            intro_phantom = new Squad_intro_phantom(scenarioTag);
            allies_grunts_01 = new Squad_allies_grunts_01(scenarioTag);
            allies_elites_01 = new Squad_allies_elites_01(scenarioTag);
            hacker = new Squad_hacker(scenarioTag);
            rec_center_heretic_01 = new Squad_rec_center_heretic_01(scenarioTag);
            rec_center_heretic_02 = new Squad_rec_center_heretic_02(scenarioTag);
            rec_center_grunts_01 = new Squad_rec_center_grunts_01(scenarioTag);
            rec_center_grunts_02L = new Squad_rec_center_grunts_02L(scenarioTag);
            rec_center_grunts_02R = new Squad_rec_center_grunts_02R(scenarioTag);
            rec_center_grunts_03 = new Squad_rec_center_grunts_03(scenarioTag);
            rec_center_heretic_03 = new Squad_rec_center_heretic_03(scenarioTag);
            rec_center_heretic_04 = new Squad_rec_center_heretic_04(scenarioTag);
            rec_center_grunts_04 = new Squad_rec_center_grunts_04(scenarioTag);
            rec_center_heretic_05 = new Squad_rec_center_heretic_05(scenarioTag);
            rec_center_grunts_05 = new Squad_rec_center_grunts_05(scenarioTag);
            rec_center_grunts_06 = new Squad_rec_center_grunts_06(scenarioTag);
            rec_center_heretic_06 = new Squad_rec_center_heretic_06(scenarioTag);
            rec_center_grunts_07 = new Squad_rec_center_grunts_07(scenarioTag);
            rec_cen_rein_her_01L = new Squad_rec_cen_rein_her_01L(scenarioTag);
            rec_cen_rein_grt_01L = new Squad_rec_cen_rein_grt_01L(scenarioTag);
            rec_cen_rein_her_01R = new Squad_rec_cen_rein_her_01R(scenarioTag);
            rec_cen_rein_grt_01R = new Squad_rec_cen_rein_grt_01R(scenarioTag);
            hangar_heretic_01R = new Squad_hangar_heretic_01R(scenarioTag);
            hangar_heretic_01L = new Squad_hangar_heretic_01L(scenarioTag);
            hangar_grunts_01R = new Squad_hangar_grunts_01R(scenarioTag);
            hangar_grunts_01L = new Squad_hangar_grunts_01L(scenarioTag);
            hangar_heretic_02L = new Squad_hangar_heretic_02L(scenarioTag);
            hangar_heretic_02R = new Squad_hangar_heretic_02R(scenarioTag);
            hangar_heretic_05 = new Squad_hangar_heretic_05(scenarioTag);
            hangar_grunts_03 = new Squad_hangar_grunts_03(scenarioTag);
            hangar_rein_her_01L = new Squad_hangar_rein_her_01L(scenarioTag);
            hangar_rein_her_01R = new Squad_hangar_rein_her_01R(scenarioTag);
            hangar_rein_her_02L = new Squad_hangar_rein_her_02L(scenarioTag);
            hangar_rein_her_02R = new Squad_hangar_rein_her_02R(scenarioTag);
            hangar_rein_her_03L = new Squad_hangar_rein_her_03L(scenarioTag);
            hangar_rein_her_03R = new Squad_hangar_rein_her_03R(scenarioTag);
            hangar_sentinels_flit = new Squad_hangar_sentinels_flit(scenarioTag);
            hangar_helper_01 = new Squad_hangar_helper_01(scenarioTag);
            hangar_helper_02 = new Squad_hangar_helper_02(scenarioTag);
            hangar_helper_03 = new Squad_hangar_helper_03(scenarioTag);
            hangar_phantom = new Squad_hangar_phantom(scenarioTag);
            reinforce_elites_01 = new Squad_reinforce_elites_01(scenarioTag);
            reinforce_grunts_01 = new Squad_reinforce_grunts_01(scenarioTag);
            hangar_sentinel_swarm = new Squad_hangar_sentinel_swarm(scenarioTag);
            hangar_heretic_heavies_L = new Squad_hangar_heretic_heavies_L(scenarioTag);
            hangar_heretic_heavies_R = new Squad_hangar_heretic_heavies_R(scenarioTag);
            hangar_a50_01r_high = new Squad_hangar_a50_01r_high(scenarioTag);
            hangar_a50_01l_high = new Squad_hangar_a50_01l_high(scenarioTag);
            hangar_a50_02r_high = new Squad_hangar_a50_02r_high(scenarioTag);
            hangar_a50_02l_high = new Squad_hangar_a50_02l_high(scenarioTag);
            hangar_a50_03r_high = new Squad_hangar_a50_03r_high(scenarioTag);
            hangar_a50_03l_high = new Squad_hangar_a50_03l_high(scenarioTag);
            hangar_a50_01r_low = new Squad_hangar_a50_01r_low(scenarioTag);
            hangar_a50_01l_low = new Squad_hangar_a50_01l_low(scenarioTag);
            hangar_a50_02r_low = new Squad_hangar_a50_02r_low(scenarioTag);
            hangar_a50_02l_low = new Squad_hangar_a50_02l_low(scenarioTag);
            hangar_a50_03r_low = new Squad_hangar_a50_03r_low(scenarioTag);
            hangar_a50_03l_low = new Squad_hangar_a50_03l_low(scenarioTag);
            hangar_grunts_04R = new Squad_hangar_grunts_04R(scenarioTag);
            hangar_grunts_04L = new Squad_hangar_grunts_04L(scenarioTag);
            hangar_heretic_06R = new Squad_hangar_heretic_06R(scenarioTag);
            hangar_heretic_06C = new Squad_hangar_heretic_06C(scenarioTag);
            hangar_heretic_06L = new Squad_hangar_heretic_06L(scenarioTag);
            hangar_grunts_end = new Squad_hangar_grunts_end(scenarioTag);
            first_hall_heretic_01 = new Squad_first_hall_heretic_01(scenarioTag);
            first_hall_grunts_01 = new Squad_first_hall_grunts_01(scenarioTag);
            first_hall_heretic_02 = new Squad_first_hall_heretic_02(scenarioTag);
            first_hall_heretic_03 = new Squad_first_hall_heretic_03(scenarioTag);
            reinforce_elites_02 = new Squad_reinforce_elites_02(scenarioTag);
            reinforce_grunts_02 = new Squad_reinforce_grunts_02(scenarioTag);
            underhangar_heretic_01 = new Squad_underhangar_heretic_01(scenarioTag);
            underhangar_heretic_02 = new Squad_underhangar_heretic_02(scenarioTag);
            underhangar_grunts_01 = new Squad_underhangar_grunts_01(scenarioTag);
            underhangar_grunts_02 = new Squad_underhangar_grunts_02(scenarioTag);
            underhangar_grunts_03 = new Squad_underhangar_grunts_03(scenarioTag);
            underhangar_rein_her_01 = new Squad_underhangar_rein_her_01(scenarioTag);
            underhangar_rein_her_02 = new Squad_underhangar_rein_her_02(scenarioTag);
            second_hall_heretic_01 = new Squad_second_hall_heretic_01(scenarioTag);
            second_hall_grunts_01 = new Squad_second_hall_grunts_01(scenarioTag);
            second_hall_heretic_02 = new Squad_second_hall_heretic_02(scenarioTag);
            second_hall_heretic_03 = new Squad_second_hall_heretic_03(scenarioTag);
            second_hall_grunts_02 = new Squad_second_hall_grunts_02(scenarioTag);
            second_hall_grunts_03 = new Squad_second_hall_grunts_03(scenarioTag);
            second_hall_heretic_04 = new Squad_second_hall_heretic_04(scenarioTag);
            second_hall_heretic_05 = new Squad_second_hall_heretic_05(scenarioTag);
            second_hall_heretic_06 = new Squad_second_hall_heretic_06(scenarioTag);
            heretic_leader_01 = new Squad_heretic_leader_01(scenarioTag);
            heretic_leader_02 = new Squad_heretic_leader_02(scenarioTag);
            heretic_leader_03 = new Squad_heretic_leader_03(scenarioTag);
            reinforce_elites_03 = new Squad_reinforce_elites_03(scenarioTag);
            reinforce_grunts_03 = new Squad_reinforce_grunts_03(scenarioTag);
            bottling_heretics_01 = new Squad_bottling_heretics_01(scenarioTag);
            bottling_grunts_01 = new Squad_bottling_grunts_01(scenarioTag);
            bottling_heretics_02 = new Squad_bottling_heretics_02(scenarioTag);
            bottling_grunts_02 = new Squad_bottling_grunts_02(scenarioTag);
            bottling_heretics_03 = new Squad_bottling_heretics_03(scenarioTag);
            bottling_grunts_03 = new Squad_bottling_grunts_03(scenarioTag);
            bottling_heretics_04 = new Squad_bottling_heretics_04(scenarioTag);
            bottling_grunts_04 = new Squad_bottling_grunts_04(scenarioTag);
            bottling_heretics_05 = new Squad_bottling_heretics_05(scenarioTag);
            bottling_grunts_05 = new Squad_bottling_grunts_05(scenarioTag);
            bottling_sentinels_01 = new Squad_bottling_sentinels_01(scenarioTag);
            bottling_sentinels_02 = new Squad_bottling_sentinels_02(scenarioTag);
            bottling_sentinels_03 = new Squad_bottling_sentinels_03(scenarioTag);
            ledge_banshees_01 = new Squad_ledge_banshees_01(scenarioTag);
            allied_phantom_01 = new Squad_allied_phantom_01(scenarioTag);
            dogfight_initial_enemies = new Squad_dogfight_initial_enemies(scenarioTag);
            dogfight_enemies = new Squad_dogfight_enemies(scenarioTag);
            dog_turrets_01 = new Squad_dog_turrets_01(scenarioTag);
            dog_turret_men_01 = new Squad_dog_turret_men_01(scenarioTag);
            dog_turrets_02 = new Squad_dog_turrets_02(scenarioTag);
            dog_turret_men_02 = new Squad_dog_turret_men_02(scenarioTag);
            dog_flak_02 = new Squad_dog_flak_02(scenarioTag);
            dog_turrets_03 = new Squad_dog_turrets_03(scenarioTag);
            dog_turret_men_03 = new Squad_dog_turret_men_03(scenarioTag);
            dog_sen_03 = new Squad_dog_sen_03(scenarioTag);
            dog_turrets_04 = new Squad_dog_turrets_04(scenarioTag);
            dog_turret_men_04 = new Squad_dog_turret_men_04(scenarioTag);
            dog_flak_04 = new Squad_dog_flak_04(scenarioTag);
            dog_sen_05 = new Squad_dog_sen_05(scenarioTag);
            dog_turrets_06 = new Squad_dog_turrets_06(scenarioTag);
            dog_turret_men_06 = new Squad_dog_turret_men_06(scenarioTag);
            dog_sen_06 = new Squad_dog_sen_06(scenarioTag);
            dog_turrets_07 = new Squad_dog_turrets_07(scenarioTag);
            dog_turret_men_07 = new Squad_dog_turret_men_07(scenarioTag);
            dog_flak_07 = new Squad_dog_flak_07(scenarioTag);
            hl_escort_sentinels = new Squad_hl_escort_sentinels(scenarioTag);
            allies_elites_03 = new Squad_allies_elites_03(scenarioTag);
            allies_grunts_03 = new Squad_allies_grunts_03(scenarioTag);
            resupply_phantom = new Squad_resupply_phantom(scenarioTag);
            eye01 = new Squad_eye01(scenarioTag);
            eye02 = new Squad_eye02(scenarioTag);
            eye03 = new Squad_eye03(scenarioTag);
            eye04 = new Squad_eye04(scenarioTag);
            eye05 = new Squad_eye05(scenarioTag);
            eye06 = new Squad_eye06(scenarioTag);
            eye07 = new Squad_eye07(scenarioTag);
            eye08 = new Squad_eye08(scenarioTag);
            eye09 = new Squad_eye09(scenarioTag);
            resupply_banshee = new Squad_resupply_banshee(scenarioTag);
            arm02_final_grunts = new Squad_arm02_final_grunts(scenarioTag);
            arm02_final_heretics = new Squad_arm02_final_heretics(scenarioTag);
            bday_party = new Squad_bday_party(scenarioTag);
            chasers = new Squad_chasers(scenarioTag);
            turret_test = new Squad_turret_test(scenarioTag);
        }

        public class Squad_intro_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _01 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[0];
            public IAiActorDefinition _02 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_intro_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_intro_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _01 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[0];
            public IAiActorDefinition _02 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[1];
            public IAiActorDefinition _03 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_intro_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition grunt02 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[0];
            public IAiActorDefinition grunt01 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_allies_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite04 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_allies_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hacker
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hacker => ScenarioTag.AiSquadDefinitions[4].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_hacker(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_heretic_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h01 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_rec_center_heretic_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_heretic_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h01 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_rec_center_heretic_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_rec_center_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_grunts_02L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_rec_center_grunts_02L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_grunts_02R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_rec_center_grunts_02R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[0];
            public IAiActorDefinition testme => ScenarioTag.AiSquadDefinitions[10].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_rec_center_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_heretic_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h01 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[0];
            public IAiActorDefinition h02 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_rec_center_heretic_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_heretic_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h01 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_rec_center_heretic_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_grunts_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_rec_center_grunts_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_heretic_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h01 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[0];
            public IAiActorDefinition h02 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_rec_center_heretic_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_grunts_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_rec_center_grunts_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_grunts_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_rec_center_grunts_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_heretic_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_rec_center_heretic_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_center_grunts_07
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad_rec_center_grunts_07(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_cen_rein_her_01L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_rec_cen_rein_her_01L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_cen_rein_grt_01L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_rec_cen_rein_grt_01L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_cen_rein_her_01R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_rec_cen_rein_her_01R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_rec_cen_rein_grt_01R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_rec_cen_rein_grt_01R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_01R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_hangar_heretic_01R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_01L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_hangar_heretic_01L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_grunts_01R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_hangar_grunts_01R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_grunts_01L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_hangar_grunts_01L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_02L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_hangar_heretic_02L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_02R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_hangar_heretic_02R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_hangar_heretic_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_hangar_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_rein_her_01L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_hangar_rein_her_01L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_rein_her_01R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_hangar_rein_her_01R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_rein_her_02L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_hangar_rein_her_02L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_rein_her_02R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_hangar_rein_her_02R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_rein_her_03L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_hangar_rein_her_03L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_rein_her_03R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_hangar_rein_her_03R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_sentinels_flit
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition l1 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[0];
            public IAiActorDefinition l2 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[1];
            public IAiActorDefinition r1 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[2];
            public IAiActorDefinition r2 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[3];
            public IAiActorDefinition c1 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[4];
            public IAiActorDefinition c2 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_hangar_sentinels_flit(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_helper_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition helper01 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_hangar_helper_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_helper_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition helper01 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_hangar_helper_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_helper_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_hangar_helper_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pilot => ScenarioTag.AiSquadDefinitions[41].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_hangar_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_reinforce_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_reinforce_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_reinforce_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_reinforce_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_sentinel_swarm
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition l1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[0];
            public IAiActorDefinition l2 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[1];
            public IAiActorDefinition r1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[2];
            public IAiActorDefinition r2 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[3];
            public IAiActorDefinition c1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_hangar_sentinel_swarm(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_heavies_L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _02a => ScenarioTag.AiSquadDefinitions[45].StartingLocations[0];
            public IAiActorDefinition _02b => ScenarioTag.AiSquadDefinitions[45].StartingLocations[1];
            public IAiActorDefinition _03a => ScenarioTag.AiSquadDefinitions[45].StartingLocations[2];
            public IAiActorDefinition _03b => ScenarioTag.AiSquadDefinitions[45].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_hangar_heretic_heavies_L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_heavies_R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _02a => ScenarioTag.AiSquadDefinitions[46].StartingLocations[0];
            public IAiActorDefinition _02b => ScenarioTag.AiSquadDefinitions[46].StartingLocations[1];
            public IAiActorDefinition _03a => ScenarioTag.AiSquadDefinitions[46].StartingLocations[2];
            public IAiActorDefinition _03b => ScenarioTag.AiSquadDefinitions[46].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_hangar_heretic_heavies_R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_01r_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_hangar_a50_01r_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_01l_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_hangar_a50_01l_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_02r_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_hangar_a50_02r_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_02l_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_hangar_a50_02l_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_03r_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_hangar_a50_03r_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_03l_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_hangar_a50_03l_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_01r_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_hangar_a50_01r_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_01l_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad_hangar_a50_01l_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_02r_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_hangar_a50_02r_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_02l_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_hangar_a50_02l_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_03r_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_hangar_a50_03r_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_a50_03l_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_hangar_a50_03l_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_grunts_04R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_hangar_grunts_04R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_grunts_04L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_hangar_grunts_04L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_06R
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_hangar_heretic_06R(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_06C
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_hangar_heretic_06C(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_heretic_06L
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_hangar_heretic_06L(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hangar_grunts_end
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_hangar_grunts_end(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_first_hall_heretic_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h01 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_first_hall_heretic_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_first_hall_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_first_hall_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_first_hall_heretic_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h02 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_first_hall_heretic_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_first_hall_heretic_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_first_hall_heretic_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_reinforce_elites_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_reinforce_elites_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_reinforce_grunts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_reinforce_grunts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_underhangar_heretic_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_underhangar_heretic_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_underhangar_heretic_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_underhangar_heretic_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_underhangar_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_underhangar_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_underhangar_grunts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_underhangar_grunts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_underhangar_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_underhangar_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_underhangar_rein_her_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad_underhangar_rein_her_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_underhangar_rein_her_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_underhangar_rein_her_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_heretic_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h01 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_second_hall_heretic_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_second_hall_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_heretic_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h05a => ScenarioTag.AiSquadDefinitions[80].StartingLocations[0];
            public IAiActorDefinition h05b => ScenarioTag.AiSquadDefinitions[80].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_second_hall_heretic_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_heretic_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h02 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_second_hall_heretic_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_grunts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[0];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[1];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[2];
            public IAiActorDefinition _4 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_second_hall_grunts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h03 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_second_hall_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_heretic_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h07a => ScenarioTag.AiSquadDefinitions[84].StartingLocations[0];
            public IAiActorDefinition h07b => ScenarioTag.AiSquadDefinitions[84].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_second_hall_heretic_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_heretic_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition h04 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[85];
            public Squad_second_hall_heretic_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_second_hall_heretic_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[86];
            public Squad_second_hall_heretic_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_heretic_leader_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[87];
            public Squad_heretic_leader_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_heretic_leader_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[88];
            public Squad_heretic_leader_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_heretic_leader_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[89];
            public Squad_heretic_leader_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_reinforce_elites_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[90];
            public Squad_reinforce_elites_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_reinforce_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[91];
            public Squad_reinforce_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_heretics_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[92];
            public Squad_bottling_heretics_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_grunts_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[93];
            public Squad_bottling_grunts_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_heretics_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[94];
            public Squad_bottling_heretics_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_grunts_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[95];
            public Squad_bottling_grunts_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_heretics_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[96];
            public Squad_bottling_heretics_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[97];
            public Squad_bottling_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_heretics_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[98];
            public Squad_bottling_heretics_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_grunts_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[99];
            public Squad_bottling_grunts_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_heretics_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[100];
            public Squad_bottling_heretics_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_grunts_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition l1 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[0];
            public IAiActorDefinition l2 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[1];
            public IAiActorDefinition l3 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[2];
            public IAiActorDefinition r1 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[3];
            public IAiActorDefinition r2 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[4];
            public IAiActorDefinition r3 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[101];
            public Squad_bottling_grunts_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_sentinels_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition tube01 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[0];
            public IAiActorDefinition tube02 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[1];
            public IAiActorDefinition tube03 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[102];
            public Squad_bottling_sentinels_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_sentinels_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[103];
            public Squad_bottling_sentinels_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bottling_sentinels_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[104].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[104].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[104];
            public Squad_bottling_sentinels_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_banshees_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[105].StartingLocations[0];
            public IAiActorDefinition center => ScenarioTag.AiSquadDefinitions[105].StartingLocations[1];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[105].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[105];
            public Squad_ledge_banshees_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allied_phantom_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[106].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[106];
            public Squad_allied_phantom_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dogfight_initial_enemies
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[107];
            public Squad_dogfight_initial_enemies(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dogfight_enemies
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pt_01 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[0];
            public IAiActorDefinition pt_02 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[1];
            public IAiActorDefinition pt_03 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[2];
            public IAiActorDefinition pt_04 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[3];
            public IAiActorDefinition pt_05 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[4];
            public IAiActorDefinition pt_06 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[5];
            public IAiActorDefinition pt_07 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[6];
            public IAiActorDefinition pt_08 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[108];
            public Squad_dogfight_enemies(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turrets_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[109].StartingLocations[0];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[109].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[109];
            public Squad_dog_turrets_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turret_men_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[110].StartingLocations[0];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[110].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[110];
            public Squad_dog_turret_men_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turrets_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[111].StartingLocations[0];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[111].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[111];
            public Squad_dog_turrets_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turret_men_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[112].StartingLocations[0];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[112].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[112];
            public Squad_dog_turret_men_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_flak_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[113];
            public Squad_dog_flak_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turrets_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[114].StartingLocations[0];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[114].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[114];
            public Squad_dog_turrets_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turret_men_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[115];
            public Squad_dog_turret_men_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_sen_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition l1 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[0];
            public IAiActorDefinition l2 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[1];
            public IAiActorDefinition l3 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[2];
            public IAiActorDefinition r1 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[3];
            public IAiActorDefinition r2 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[4];
            public IAiActorDefinition r3 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[116];
            public Squad_dog_sen_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turrets_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[117].StartingLocations[0];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[117].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[117];
            public Squad_dog_turrets_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turret_men_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[118].StartingLocations[0];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[118].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[118];
            public Squad_dog_turret_men_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_flak_04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[119];
            public Squad_dog_flak_04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_sen_05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a1 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[0];
            public IAiActorDefinition a2 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[1];
            public IAiActorDefinition a3 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[2];
            public IAiActorDefinition c1 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[3];
            public IAiActorDefinition c2 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[4];
            public IAiActorDefinition c3 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[120];
            public Squad_dog_sen_05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turrets_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition left => ScenarioTag.AiSquadDefinitions[121].StartingLocations[0];
            public IAiActorDefinition right => ScenarioTag.AiSquadDefinitions[121].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[121];
            public Squad_dog_turrets_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turret_men_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[122];
            public Squad_dog_turret_men_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_sen_06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition l1 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[0];
            public IAiActorDefinition l2 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[1];
            public IAiActorDefinition l3 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[2];
            public IAiActorDefinition r1 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[3];
            public IAiActorDefinition r2 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[4];
            public IAiActorDefinition r3 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[123];
            public Squad_dog_sen_06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turrets_07
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _01 => ScenarioTag.AiSquadDefinitions[124].StartingLocations[0];
            public IAiActorDefinition _02 => ScenarioTag.AiSquadDefinitions[124].StartingLocations[1];
            public IAiActorDefinition _03 => ScenarioTag.AiSquadDefinitions[124].StartingLocations[2];
            public IAiActorDefinition _04 => ScenarioTag.AiSquadDefinitions[124].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[124];
            public Squad_dog_turrets_07(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_turret_men_07
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _01 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[0];
            public IAiActorDefinition _02 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[1];
            public IAiActorDefinition _03 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[2];
            public IAiActorDefinition _04 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[125];
            public Squad_dog_turret_men_07(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_dog_flak_07
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[126];
            public Squad_dog_flak_07(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hl_escort_sentinels
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[127];
            public Squad_hl_escort_sentinels(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_elites_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite01 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[0];
            public IAiActorDefinition elite02 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[128];
            public Squad_allies_elites_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_allies_grunts_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition grunt01 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[0];
            public IAiActorDefinition grunt02 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[129];
            public Squad_allies_grunts_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_resupply_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[0];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[1];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[2];
            public IAiActorDefinition _4 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[130];
            public Squad_resupply_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[131];
            public Squad_eye01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[132];
            public Squad_eye02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[133];
            public Squad_eye03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye04
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[134];
            public Squad_eye04(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye05
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[135];
            public Squad_eye05(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye06
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[136].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[136];
            public Squad_eye06(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye07
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[137].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[137];
            public Squad_eye07(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye08
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[138];
            public Squad_eye08(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_eye09
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[139];
            public Squad_eye09(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_resupply_banshee
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[140].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[140];
            public Squad_resupply_banshee(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_arm02_final_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[141];
            public Squad_arm02_final_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_arm02_final_heretics
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[142].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[142].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[142].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[142];
            public Squad_arm02_final_heretics(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_bday_party
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[143];
            public Squad_bday_party(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_chasers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[144];
            public Squad_chasers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_turret_test
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[145];
            public Squad_turret_test(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}