namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_07a_highcharity : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> hammer { get; set; }
        public ScenarioEntity<IScenery> index { get; set; }
        public ScenarioEntity<IScenery> tentacle_capture_01 { get; set; }
        public ScenarioEntity<IScenery> tentacle_chief { get; set; }
        public ScenarioEntity<IScenery> tentacle_capture_02 { get; set; }
        public ScenarioEntity<IScenery> tentacle_capture_03 { get; set; }
        public ScenarioEntity<IScenery> tentacle_capture_04 { get; set; }
        public ScenarioEntity<IScenery> tentacle_capture_05 { get; set; }
        public ScenarioEntity<IScenery> tentacle_arbiter { get; set; }
        public ScenarioEntity<IScenery> anchor_intro_a { get; set; }
        public ScenarioEntity<IScenery> matte_high_charity { get; set; }
        public ScenarioEntity<IScenery> anchor_intro_b { get; set; }
        public ScenarioEntity<IScenery> anchor_intro_c { get; set; }
        public ScenarioEntity<IScenery> index_intro { get; set; }
        public ScenarioEntity<IScenery> bsp_0_holo_a { get; set; }
        public ScenarioEntity<IScenery> bsp_0_holo_h { get; set; }
        public ScenarioEntity<IScenery> bsp_0_holo_g { get; set; }
        public ScenarioEntity<IScenery> bsp_0_holo_i { get; set; }
        public ScenarioEntity<IScenery> dervish_ped_fr_b { get; set; }
        public ScenarioEntity<IScenery> anchor_intra1 { get; set; }
        public ScenarioEntity<IScenery> bsp_0_holo_j { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_f { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_a { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_b { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_c { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_d { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_e { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_g { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_h { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_k { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_l { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_m { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_n { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_o { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_p { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_j { get; set; }
        public ScenarioEntity<IScenery> maus_inner_holo_i { get; set; }
        public ScenarioEntity<IScenery> jail_a_plasma_rifle { get; set; }
        public ScenarioEntity<IScenery> jail_a_needler { get; set; }
        public ScenarioEntity<IScenery> jail_b_plasma_rifle { get; set; }
        public ScenarioEntity<IScenery> jail_b_plasma_pistol { get; set; }
        public ScenarioEntity<IScenery> jail_b_carbine { get; set; }
        public ScenarioEntity<IScenery> jail_ped_a { get; set; }
        public ScenarioEntity<IScenery> jail_ped_b { get; set; }
        public ScenarioEntity<IScenery> jail_ped_c { get; set; }
        public ScenarioEntity<IScenery> jail_ped_d { get; set; }
        public ScenarioEntity<IScenery> jail_ped_e { get; set; }
        public ScenarioEntity<IScenery> jail_ped_f { get; set; }
        public ScenarioEntity<IScenery> jail_ped_g { get; set; }
        public ScenarioEntity<IScenery> jail_ped_h { get; set; }
        public ScenarioEntity<IScenery> jail_ped_i { get; set; }
        public ScenarioEntity<IScenery> jail_ped_j { get; set; }
        public ScenarioEntity<IScenery> jail_ped_k { get; set; }
        public ScenarioEntity<IScenery> jail_ped_l { get; set; }
        public ScenarioEntity<IScenery> jail_ped_m { get; set; }
        public ScenarioEntity<IScenery> jail_ped_n { get; set; }
        public ScenarioEntity<IScenery> jail_ped_o { get; set; }
        public ScenarioEntity<IScenery> jail_ped_p { get; set; }
        public ScenarioEntity<IScenery> jail_ped_q { get; set; }
        public ScenarioEntity<IScenery> jail_ped_r { get; set; }
        public ScenarioEntity<IScenery> jail_ped_t { get; set; }
        public ScenarioEntity<IScenery> jail_ped_s { get; set; }
        public ScenarioEntity<IScenery> jail_ped_u { get; set; }
        public ScenarioEntity<IScenery> maus_bridge_holo_b { get; set; }
        public ScenarioEntity<IScenery> maus_bridge_holo_a { get; set; }
        public ScenarioEntity<IScenery> maus_bridge_holo_c { get; set; }
        public ScenarioEntity<IScenery> maus_bridge_holo_d { get; set; }
        public ScenarioEntity<IScenery> maus_bridge_holo_e { get; set; }
        public ScenarioEntity<IScenery> maus_bridge_holo_f { get; set; }
        public ScenarioEntity<IScenery> maus_room_holo_c { get; set; }
        public ScenarioEntity<IScenery> maus_room_holo_d { get; set; }
        public ScenarioEntity<IScenery> maus_room_holo_f { get; set; }
        public ScenarioEntity<IScenery> maus_room_holo_g { get; set; }
        public ScenarioEntity<IScenery> maus_room_holo_i { get; set; }
        public ScenarioEntity<IScenery> maus_room_holo_j { get; set; }
        public ScenarioEntity<IScenery> maus_room_holo_k { get; set; }
        public ScenarioEntity<IScenery> hall_a_holo_d { get; set; }
        public ScenarioEntity<IScenery> hall_a_holo_h { get; set; }
        public ScenarioEntity<IScenery> hall_a_holo_k { get; set; }
        public ScenarioEntity<IScenery> hall_a_holo_o { get; set; }
        public ScenarioEntity<IScenery> grand_b_holo_a { get; set; }
        public ScenarioEntity<IScenery> grand_b_holo_b { get; set; }
        public ScenarioEntity<IScenery> room_a_holo_a { get; set; }
        public ScenarioEntity<IScenery> room_a_holo_d { get; set; }
        public ScenarioEntity<IScenery> room_a_holo_g { get; set; }
        public ScenarioEntity<IScenery> room_a_holo_h { get; set; }
        public ScenarioEntity<IScenery> room_a_holo_i { get; set; }
        public ScenarioEntity<IScenery> room_a_holo_l { get; set; }
        public ScenarioEntity<IScenery> room_a_holo_m { get; set; }
        public ScenarioEntity<IScenery> bsp_0_holo_c { get; set; }
        public ScenarioEntity<IScenery> bsp_0_holo_f { get; set; }
        public ScenarioEntity<IScenery> ledge_col_a { get; set; }
        public ScenarioEntity<IScenery> ledge_col_b { get; set; }
        public ScenarioEntity<IScenery> ledge_col_c { get; set; }
        public ScenarioEntity<IScenery> ledge_col_d { get; set; }
        public ScenarioEntity<IScenery> ledge_col_e { get; set; }
        public ScenarioEntity<IScenery> ledge_col_f { get; set; }
        public ScenarioEntity<IScenery> garden_a_holo_a { get; set; }
        public ScenarioEntity<IScenery> ioc_effect { get; set; }
        public ScenarioEntity<IScenery> bsp_0_holo_b { get; set; }
        public ScenarioEntity<IScenery> anchor_x08 { get; set; }
        public ScenarioEntity<IScenery> intro_fleet_01 { get; set; }
        public ScenarioEntity<IScenery> intro_pike_01 { get; set; }
        public ScenarioEntity<IScenery> intro_pike_02 { get; set; }
        public ScenarioEntity<IScenery> intro_pike_03 { get; set; }
        public ScenarioEntity<IScenery> intro_pike_04 { get; set; }
        public ScenarioEntity<IScenery> intro_pike_05 { get; set; }
        public ScenarioEntity<IScenery> intro_pike_06 { get; set; }
        public ScenarioEntity<IScenery> grunt_card { get; set; }
        public ScenarioEntity<IScenery> intro_fleet_02 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_01 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_02 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_03 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_04 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_05 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_06 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_07 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_08 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_09 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_10 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_11 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_12 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_13 { get; set; }
        public ScenarioEntity<IScenery> intro_crowd_14 { get; set; }
        public ScenarioEntity<IScenery> holo_cam { get; set; }
        public ScenarioEntity<IScenery> texture_camera { get; set; }
        public ScenarioEntity<IScenery> teleport { get; set; }
        public ScenarioEntity<IScenery> intra_pike_01 { get; set; }
        public ScenarioEntity<IScenery> intra_pike_02 { get; set; }
        public ScenarioEntity<IScenery> holo_generator { get; set; }
        public ScenarioEntity<IScenery> council_sound_a { get; set; }
        public ScenarioEntity<IScenery> council_sound_b { get; set; }
        public ScenarioEntity<IScenery> council_sound_c { get; set; }
        public ScenarioEntity<IScenery> council_sound_d { get; set; }
        public ScenarioEntity<IScenery> stardust_01 { get; set; }
        public ScenarioEntity<IScenery> stardust_02 { get; set; }
        public ScenarioEntity<IScenery> delta_halo { get; set; }
        public ScenarioEntity<IScenery> corr_a_sound_a { get; set; }
        public ScenarioEntity<IScenery> corr_a_sound_b { get; set; }
        public ScenarioEntity<IScenery> corr_a_sound_c { get; set; }
        public ScenarioEntity<IScenery> corr_a_sound_d { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_a { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_b { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_c { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_d { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_e { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_f { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_g { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_h { get; set; }
        public ScenarioEntity<IScenery> ioc_sound_a { get; set; }
        public ScenarioEntity<IScenery> ioc_sound_c { get; set; }
        public ScenarioEntity<IScenery> midtower_sound_a { get; set; }
        public ScenarioEntity<IScenery> midtower_sound_b { get; set; }
        public ScenarioEntity<IScenery> midtower_sound_c { get; set; }
        public ScenarioEntity<IScenery> midtower_sound_d { get; set; }
        public ScenarioEntity<IScenery> midtower_sound_e { get; set; }
        public ScenarioEntity<IScenery> garden_b_sound_a { get; set; }
        public ScenarioEntity<IScenery> garden_b_sound_b { get; set; }
        public ScenarioEntity<IScenery> garden_b_sound_c { get; set; }
        public ScenarioEntity<IScenery> garden_b_sound_d { get; set; }
        public ScenarioEntity<IScenery> ioc_sound_b { get; set; }
        public ScenarioEntity<IScenery> garden_b_sound_e { get; set; }
        public ScenarioEntity<IScenery> garden_b_sound_f { get; set; }
        public ScenarioEntity<IScenery> garden_b_sound_g { get; set; }
        public ScenarioEntity<IScenery> garden_b_sound_h { get; set; }
        public ScenarioEntity<IScenery> rupture { get; set; }
        public ScenarioEntity<IScenery> matte_substance { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_0 { get; set; }
        public ScenarioEntity<IBloc> bsp1_crate_0 { get; set; }
        public ScenarioEntity<IBloc> bsp1_crate_1 { get; set; }
        public ScenarioEntity<IBloc> bsp1_crate_2 { get; set; }
        public ScenarioEntity<IBloc> bsp1_crate_3 { get; set; }
        public ScenarioEntity<IBloc> bsp1_crate_4 { get; set; }
        public ScenarioEntity<IBloc> bsp1_crate_5 { get; set; }
        public ScenarioEntity<IBloc> bsp1_crate_6 { get; set; }
        public ScenarioEntity<IBloc> bsp1_crate_7 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_0 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_1 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_21 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_2 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_3 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_4 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_5 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_6 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_7 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_8 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_9 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_10 { get; set; }
        public ScenarioEntity<IBloc> bsp2_crate_11 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_0 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_1 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_2 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_3 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_4 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_5 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_6 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_7 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_8 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_9 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_10 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_11 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_12 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_13 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_14 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_15 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_16 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_17 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_18 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_19 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_20 { get; set; }
        public ScenarioEntity<IBloc> bsp3_crate_21 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_0 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_1 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_2 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_3 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_4 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_5 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_6 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_7 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_8 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_9 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_10 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_11 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_12 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_13 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_14 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_15 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_16 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_17 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_18 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_19 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_20 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_21 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_22 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_23 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_24 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_27 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_28 { get; set; }
        public ScenarioEntity<IBloc> bsp3b_crate_29 { get; set; }
        public ScenarioEntity<IBloc> bsp4_crate_0 { get; set; }
        public ScenarioEntity<IBloc> bsp4_crate_1 { get; set; }
        public ScenarioEntity<IBloc> bsp4_crate_2 { get; set; }
        public ScenarioEntity<IBloc> bsp4_crate_3 { get; set; }
        public ScenarioEntity<IBloc> bsp4_crate_4 { get; set; }
        public ScenarioEntity<IBloc> bsp4_crate_5 { get; set; }
        public ScenarioEntity<IScenery> corr_b_sound_i { get; set; }
        public ScenarioEntity<IScenery> ext_a_sound_a { get; set; }
        public ScenarioEntity<IScenery> ext_a_sound_b { get; set; }
        public ScenarioEntity<IScenery> ext_a_sound_d { get; set; }
        public ScenarioEntity<IScenery> ext_a_sound_e { get; set; }
        public ScenarioEntity<IScenery> ext_a_sound_f { get; set; }
        public ScenarioEntity<IScenery> ext_a_sound_g { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> _2401 { get; set; }
        public ScenarioEntity<IUnit> dervish { get; set; }
        public ScenarioEntity<IUnit> johnson { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> truth { get; set; }
        public ScenarioEntity<IUnit> mercy { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> brute_01 { get; set; }
        public ScenarioEntity<IUnit> brute_02 { get; set; }
        public ScenarioEntity<IUnit> brute_03 { get; set; }
        public ScenarioEntity<IUnit> brute_04 { get; set; }
        public ScenarioEntity<IUnit> infection_form_01 { get; set; }
        public ScenarioEntity<IUnit> monitor { get; set; }
        public ScenarioEntity<IUnit> infection_form_02 { get; set; }
        public ScenarioEntity<IUnit> brute_05 { get; set; }
        public ScenarioEntity<IUnit> brute_06 { get; set; }
        public ScenarioEntity<IUnit> grunt_01 { get; set; }
        public ScenarioEntity<IUnit> grunt_02 { get; set; }
        public ScenarioEntity<IUnit> grunt_03 { get; set; }
        public ScenarioEntity<IUnit> grunt_04 { get; set; }
        public ScenarioEntity<IUnit> grunt_05 { get; set; }
        public ScenarioEntity<IUnit> jackal_01 { get; set; }
        public ScenarioEntity<IUnit> jackal_02 { get; set; }
        public ScenarioEntity<IUnit> brute_intro_01 { get; set; }
        public ScenarioEntity<IUnit> brute_intro_02 { get; set; }
        public ScenarioEntity<IUnit> brute_intro_03 { get; set; }
        public ScenarioEntity<IUnit> brute_intro_04 { get; set; }
        public ScenarioEntity<IUnit> mercy_intro { get; set; }
        public ScenarioEntity<IUnit> truth_intro { get; set; }
        public ScenarioEntity<IUnit> chief_intro { get; set; }
        public ScenarioEntity<IUnit> cortana { get; set; }
        public ScenarioEntity<IUnit> gravemind { get; set; }
        public ScenarioEntity<IUnit> mercy_no_crown { get; set; }
        public ScenarioEntity<IUnit> regret { get; set; }
        public ScenarioEntity<IUnit> bsp2_body_1 { get; set; }
        public ScenarioEntity<IUnit> bsp2_body_2 { get; set; }
        public ScenarioEntity<IUnit> bsp2_body_3 { get; set; }
        public ScenarioEntity<IUnit> bsp2_body_4 { get; set; }
        public ScenarioEntity<IUnit> bsp2_body_5 { get; set; }
        public ScenarioEntity<IVehicle> phantom_01 { get; set; }
        public ScenarioEntity<IVehicle> phantom_02 { get; set; }
        public ScenarioEntity<IVehicle> phantom_03 { get; set; }
        public ScenarioEntity<IVehicle> throne_mercy { get; set; }
        public ScenarioEntity<IVehicle> throne_truth { get; set; }
        public ScenarioEntity<IVehicle> throne_truth_intro { get; set; }
        public ScenarioEntity<IVehicle> throne_mercy_intro { get; set; }
        public ScenarioEntity<IWeapon> ice_cream_head { get; set; }
        public ScenarioEntity<IWeapon> chief_needler { get; set; }
        public ScenarioEntity<IDevice> lift_b_control { get; set; }
        public ScenarioEntity<IDevice> garden_tram_a { get; set; }
        public ScenarioEntity<IDevice> garden_tram_b { get; set; }
        public ScenarioEntity<IDevice> garden_tram_d { get; set; }
        public ScenarioEntity<IDevice> garden_tram_c { get; set; }
        public ScenarioEntity<IDevice> jail_down { get; set; }
        public ScenarioEntity<IDevice> room_b_lift { get; set; }
        public ScenarioEntity<IDevice> jail_up { get; set; }
        public ScenarioEntity<IDevice> council_door_right_a { get; set; }
        public ScenarioEntity<IDevice> council_door_right_b { get; set; }
        public ScenarioEntity<IDevice> council_door_right_c { get; set; }
        public ScenarioEntity<IDevice> council_door_left_a { get; set; }
        public ScenarioEntity<IDevice> council_door_left_b { get; set; }
        public ScenarioEntity<IDevice> council_door_left_c { get; set; }
        public ScenarioEntity<IDevice> council_door_upper_right_a { get; set; }
        public ScenarioEntity<IDevice> council_door_upper_right_b { get; set; }
        public ScenarioEntity<IDevice> council_door_upper_right_c { get; set; }
        public ScenarioEntity<IDevice> council_door_upper_left_a { get; set; }
        public ScenarioEntity<IDevice> council_door_upper_left_b { get; set; }
        public ScenarioEntity<IDevice> council_door_upper_left_c { get; set; }
        public ScenarioEntity<IDevice> garden_tram_a_bk { get; set; }
        public ScenarioEntity<IDevice> garden_tram_b_bk { get; set; }
        public ScenarioEntity<IDevice> dervish_lift_down { get; set; }
        public ScenarioEntity<IDevice> dervish_lift_up { get; set; }
        public ScenarioEntity<IDevice> garden_tram_c_bk { get; set; }
        public ScenarioEntity<IDevice> garden_tram_d_bk { get; set; }
        public ScenarioEntity<IDevice> mid_tower_door_bk { get; set; }
        public ScenarioEntity<IDevice> council_exit { get; set; }
        public ScenarioEntity<IDevice> council_ped { get; set; }
        public ScenarioEntity<IDevice> maus_door_end { get; set; }
        public ScenarioEntity<IDevice> maus_inner_ent { get; set; }
        public ScenarioEntity<IDevice> maus_inner_exit { get; set; }
        public ScenarioEntity<IDevice> maus_inner_door_a { get; set; }
        public ScenarioEntity<IDevice> maus_inner_door_b { get; set; }
        public ScenarioEntity<IDevice> maus_inner_door_c { get; set; }
        public ScenarioEntity<IDevice> maus_inner_door_d { get; set; }
        public ScenarioEntity<IDevice> maus_inner_door_e { get; set; }
        public ScenarioEntity<IDevice> maus_inner_door_f { get; set; }
        public ScenarioEntity<IDevice> jail_b_door_f { get; set; }
        public ScenarioEntity<IDevice> jail_a_door_a { get; set; }
        public ScenarioEntity<IDevice> jail_a_door_b { get; set; }
        public ScenarioEntity<IDevice> jail_a_door_c { get; set; }
        public ScenarioEntity<IDevice> jail_a_door_d { get; set; }
        public ScenarioEntity<IDevice> jail_a_door_e { get; set; }
        public ScenarioEntity<IDevice> jail_a_door_f { get; set; }
        public ScenarioEntity<IDevice> jail_b_door_a { get; set; }
        public ScenarioEntity<IDevice> jail_b_door_b { get; set; }
        public ScenarioEntity<IDevice> jail_b_door_c { get; set; }
        public ScenarioEntity<IDevice> jail_b_door_d { get; set; }
        public ScenarioEntity<IDevice> jail_b_door_e { get; set; }
        public ScenarioEntity<IDevice> jail_door_h { get; set; }
        public ScenarioEntity<IDevice> jail_door_n { get; set; }
        public ScenarioEntity<IDevice> jail_door_c { get; set; }
        public ScenarioEntity<IDevice> jail_door_d { get; set; }
        public ScenarioEntity<IDevice> jail_door_e { get; set; }
        public ScenarioEntity<IDevice> jail_door_f { get; set; }
        public ScenarioEntity<IDevice> jail_door_g { get; set; }
        public ScenarioEntity<IDevice> jail_door_i { get; set; }
        public ScenarioEntity<IDevice> jail_door_j { get; set; }
        public ScenarioEntity<IDevice> jail_door_k { get; set; }
        public ScenarioEntity<IDevice> jail_door_l { get; set; }
        public ScenarioEntity<IDevice> jail_door_m { get; set; }
        public ScenarioEntity<IDevice> room_a_lift { get; set; }
        public ScenarioEntity<IDevice> hall_a_jackal_door { get; set; }
        public ScenarioEntity<IDevice> hall_b_jackal_door { get; set; }
        public ScenarioEntity<IDevice> corr_a_mid_door { get; set; }
        public ScenarioEntity<IDevice> room_a_door1 { get; set; }
        public ScenarioEntity<IDevice> dervish_ledge_lower_door { get; set; }
        public ScenarioEntity<IDevice> grand_a_exit { get; set; }
        public ScenarioEntity<IDevice> room_b_exit { get; set; }
        public ScenarioEntity<IDevice> midtower_exit { get; set; }
        public ScenarioEntity<IDevice> grand_a_ent_door { get; set; }
        public ScenarioEntity<IDevice> grand_b_exit { get; set; }
        public ScenarioEntity<IDevice> ioc { get; set; }
        public ScenarioEntity<IDevice> tram_a_effect { get; set; }
        public ScenarioEntity<IDevice> tram_a_bk_effect { get; set; }
        public ScenarioEntity<IDevice> jail_up_effect { get; set; }
        public ScenarioEntity<IDevice> room_a_lift_effect { get; set; }
        public ScenarioEntity<IDevice> room_b_lift_effect { get; set; }
        public ScenarioEntity<IDevice> garden_tram_c_effect { get; set; }
        public ScenarioEntity<IDevice> garden_tram_c_bk_effect { get; set; }
        public ScenarioEntity<IDevice> garden_tram_d_effect { get; set; }
        public ScenarioEntity<IDevice> garden_tram_d_bk_effect { get; set; }
        public ScenarioEntity<IDevice> tram_b_effect { get; set; }
        public ScenarioEntity<IDevice> tram_b_bk_effect { get; set; }
        public ScenarioEntity<IDevice> midtower_ent_door { get; set; }
        public ScenarioEntity<IDevice> maus_bsp_4_door { get; set; }
        public ScenarioEntity<IDevice> sarcophagus { get; set; }
        public ScenarioEntity<IDevice> grand_b_door1 { get; set; }
        public ScenarioEntity<IDevice> maus_ent_door_a { get; set; }
        public ScenarioEntity<IDevice> maus_ent_door_b { get; set; }
        public ScenarioEntity<IDevice> ice_cream_effect { get; set; }
        public ICameraPathTarget test1 => Scenario.CameraPathTargets[0];
        public IAiActorDefinition cortana1 => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition all_enemies => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition prophets => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition covenant1 => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition marines => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition council_prophets => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition council_prophets_floor => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition council_prophets_upper => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition dervish_ledge_prophets => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition dervish_ledge_lower => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition dervish_ledge_left => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition dervish_ledge_right => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition grand_a_prophets => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition hall_a_prophets => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition hall_a_rein_prophet => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition hall_b_prophets => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition room_a_prophets => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition room_a_reins => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition jail_marines => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition jail_prophets => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition cell_a_prophets => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition cell_b_prophets => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition jail_cell_outer_guards_a => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition jail_cell_outer_guards_b => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition maus_bridge_prophets => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition maus_bridge_covenant => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition maus_room_covenant => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition maus_room_cov_ini => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition maus_room_prophet => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition maus_inner_covenant => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition maus_inner_prophets => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition maus_inner_buggers => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition room_b_prophets => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition room_b_covenant => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition corridor_b_prophets => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition corridor_b_covenant => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition midtower_prophets => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition midtower_covenant => Scenario.AiSquadGroupDefinitions[37];
        public IAiActorDefinition ext_a_prophets => Scenario.AiSquadGroupDefinitions[38];
        public IAiActorDefinition ext_a_covenant => Scenario.AiSquadGroupDefinitions[39];
        public IAiActorDefinition ext_a_prophets_floor => Scenario.AiSquadGroupDefinitions[40];
        public IAiActorDefinition ext_b_prophets_low => Scenario.AiSquadGroupDefinitions[41];
        public IAiActorDefinition ext_b_prophets => Scenario.AiSquadGroupDefinitions[42];
        public IAiActorDefinition ext_b_covenant_low => Scenario.AiSquadGroupDefinitions[43];
        public IAiActorDefinition ext_b_covenant => Scenario.AiSquadGroupDefinitions[44];
        public IAiActorDefinition garden_a_prophet => Scenario.AiSquadGroupDefinitions[45];
        public IAiActorDefinition garden_a_covenant => Scenario.AiSquadGroupDefinitions[46];
        public IAiActorDefinition garden_b_prophet => Scenario.AiSquadGroupDefinitions[47];
        public IAiActorDefinition garden_b_covenant => Scenario.AiSquadGroupDefinitions[48];
        public IAiActorDefinition ext_a_prophets_bk => Scenario.AiSquadGroupDefinitions[49];
        public IAiActorDefinition maus_hall_covenant => Scenario.AiSquadGroupDefinitions[50];
        public IAiActorDefinition grand_b_hunters => Scenario.AiSquadGroupDefinitions[51];
        public IAiOrders marines_corr_b => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders marines_ext_a => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders marines_gardens_a => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders marines_midtower => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders marines_gardens_b => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders marines_ext_b => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders marines_maus_halls => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders marines_maus_room_bridge => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders marines_maus_int => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders test2 => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders cortana_0 => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders cortana_1 => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders cortana_2 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders cortana_3a => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders cortana_3b => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders cortana_4 => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders council_grunt_retreat => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders council_fr => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders council_rt_fr => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders council_rt_bk => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders council_lt_fr => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders council_lt_bk => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders council_upper_rt_fr => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders council_upper_rt_bk => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders council_upper_lt_fr => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders council_upper_lt_bk => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders council_bk => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders council_brute_ini => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders council_floor_all => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders dervish_grand_hall_brutes => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders dervish_grand_hall_grunts => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders ledge_brutes_honor_ini => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders ledge_jackals_ini => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders ledge_chieftan => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders ledge_chieftan_lift => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders ledge_rt_fr => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders ledge_rt_bk => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders ledge_lt_fr => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders ledge_lt_bk => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders ledge_minor_lt_fr => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders ledge_minor_lt_bk => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders ledge_minor_rt_fr => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders ledge_minor_rt_bk => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders ledge_bot_grunts => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders ledge_bot_jackals => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders maus_inner_hunters => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders maus_inner_elites_ini => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders maus_inner_buggers_ini => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders maus_inner_brutes_ini => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders maus_inner_middle => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders maus_inner_upper => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders maus_inner_lt_fr => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders maus_inner_lt_bk => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders maus_inner_rt_fr => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders maus_inner_rt_bk => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders maus_inner_follow => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders jail_test => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders jail_a_marines_ini => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders jails_marines_follow => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders jail_b_marines_ini => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders cortana_jail => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders jail_follow => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders jail_jackals_ini => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders jail_brutes_ini => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders jail_grunts_ini => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders jail_a_brute => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders jail_a_jackals => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders jail_b_brute => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders jail_b_grunts => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders room_b_marines => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders jail_cov_top => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders jail_cov_mid => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders jail_cov_bot => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders jail_marines_top => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders jail_marines_mid => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders jail_marines_bot => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders jail_guard_cell_a => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders jail_guard_cell_b => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders jail_guard_alert_cell_a => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders jail_guard_alert_cell_b => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders maus_bridge_elites_ini => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders maus_bridge_prophets_ini => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders maus_bridge_buggers_ini => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders maus_bridge_prophets_all => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders maus_bridge_grunt_reins => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders maus_bridge_elite_reins => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders maus_bridge_hunters => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders maus_bridge_grunt_rein_b => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders maus_ent_collapse => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders maus_bridge_buggers_rein => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders maus_room_elite_lt => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders maus_room_elite_rt => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders maus_room_grunt_lt => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders maus_room_grunt_rt => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders maus_room_brute_bk => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders maus_room_jackal_bk_lt => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders maus_room_jackal_bk_rt => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders maus_room_lt_reins => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders maus_room_rt_reins => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders maus_hall_grunts => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders hall_a_jackal_ini => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders hall_a_brute_ini => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders hall_a_jackal_ini1 => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders hall_a_brute_reins => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders hall_a_grunt_reins => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders hall_a_grunt_rein_bk => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders hall_a_brute_rein_bk => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders hall_b_jackal => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders hall_b_brutes => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders hall_b_grunts => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders room_a_brutes_ini => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders room_a_jackal_ini => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders room_a_brutes_bk => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders room_a_follow => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders room_a_bk_reins => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders room_a_bot => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders marines_a_guard_b => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders marines_b_guard_a => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders room_b_brutes_ini => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders room_b_elites => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders room_b_buggers => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders room_b_bugger_follow => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders hall_c_elites => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders hall_c_buggers => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders hall_c_brutes_rein => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders grand_b_hunter_a => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders hall_d_elites => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders hall_d_brutes => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders hall_d_jackals_bk => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders hall_d_jackals_fr => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders midtower_elites => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders midtower_buggers => Scenario.AiOrderDefinitions[131].GameObject;
        public IAiOrders midtower_brutes => Scenario.AiOrderDefinitions[132].GameObject;
        public IAiOrders midtower_jackals => Scenario.AiOrderDefinitions[133].GameObject;
        public IAiOrders midtower_elite_rein => Scenario.AiOrderDefinitions[134].GameObject;
        public IAiOrders midtower_exit1 => Scenario.AiOrderDefinitions[135].GameObject;
        public IAiOrders ext_a_jackal_snipers_a => Scenario.AiOrderDefinitions[136].GameObject;
        public IAiOrders ext_a_jackal_snipers_b => Scenario.AiOrderDefinitions[137].GameObject;
        public IAiOrders ext_a_jackal_snipers_c => Scenario.AiOrderDefinitions[138].GameObject;
        public IAiOrders ext_a_jackal_snipers_d => Scenario.AiOrderDefinitions[139].GameObject;
        public IAiOrders ext_a_watch_brutes => Scenario.AiOrderDefinitions[140].GameObject;
        public IAiOrders ext_a_watch_elites_ini => Scenario.AiOrderDefinitions[141].GameObject;
        public IAiOrders ext_a_watch_elites_follow => Scenario.AiOrderDefinitions[142].GameObject;
        public IAiOrders ext_a_watch_elites_a => Scenario.AiOrderDefinitions[143].GameObject;
        public IAiOrders ext_a_watch_elites_c => Scenario.AiOrderDefinitions[144].GameObject;
        public IAiOrders ext_a_watch_elites_d => Scenario.AiOrderDefinitions[145].GameObject;
        public IAiOrders ext_a_hunters_ini => Scenario.AiOrderDefinitions[146].GameObject;
        public IAiOrders ext_a_brute_door => Scenario.AiOrderDefinitions[147].GameObject;
        public IAiOrders ext_a_brute_ini => Scenario.AiOrderDefinitions[148].GameObject;
        public IAiOrders ext_a_buggers => Scenario.AiOrderDefinitions[149].GameObject;
        public IAiOrders ext_a_rangers => Scenario.AiOrderDefinitions[150].GameObject;
        public IAiOrders ext_a_elite_ini => Scenario.AiOrderDefinitions[151].GameObject;
        public IAiOrders ext_a_buggers_bk => Scenario.AiOrderDefinitions[152].GameObject;
        public IAiOrders ext_a_brutes_bk => Scenario.AiOrderDefinitions[153].GameObject;
        public IAiOrders garden_a_jackal_snipers => Scenario.AiOrderDefinitions[154].GameObject;
        public IAiOrders ext_b_elite_a => Scenario.AiOrderDefinitions[155].GameObject;
        public IAiOrders ext_b_brute_a => Scenario.AiOrderDefinitions[156].GameObject;
        public IAiOrders ext_b_grunts_b => Scenario.AiOrderDefinitions[157].GameObject;
        public IAiOrders ext_b_brutes_b => Scenario.AiOrderDefinitions[158].GameObject;
        public IAiOrders ext_b_jackal_a => Scenario.AiOrderDefinitions[159].GameObject;
        public IAiOrders ext_b_brutes_low_door => Scenario.AiOrderDefinitions[160].GameObject;
        public IAiOrders ext_b_brutes_low => Scenario.AiOrderDefinitions[161].GameObject;
        public IAiOrders ext_b_grunts_low => Scenario.AiOrderDefinitions[162].GameObject;
        public IAiOrders ext_b_elites_bk_door => Scenario.AiOrderDefinitions[163].GameObject;
        public IAiOrders ext_b_grunt_bk_door => Scenario.AiOrderDefinitions[164].GameObject;
        public IAiOrders ext_b_elites_lt => Scenario.AiOrderDefinitions[165].GameObject;
        public IAiOrders ext_b_grunts_lt => Scenario.AiOrderDefinitions[166].GameObject;
        public IAiOrders ext_b_cov_dump => Scenario.AiOrderDefinitions[167].GameObject;
        public IAiOrders ext_b_prophet_dump => Scenario.AiOrderDefinitions[168].GameObject;
        public IAiOrders maus_hall_elites_stealth => Scenario.AiOrderDefinitions[169].GameObject;
        public IAiOrders hall_b_grunts_bk => Scenario.AiOrderDefinitions[170].GameObject;
        public IAiOrders garden_a_brute_a => Scenario.AiOrderDefinitions[171].GameObject;
        public IAiOrders garden_a_brute_b => Scenario.AiOrderDefinitions[172].GameObject;
        public IAiOrders garden_a_brute_c => Scenario.AiOrderDefinitions[173].GameObject;
        public IAiOrders garden_a_elite_a => Scenario.AiOrderDefinitions[174].GameObject;
        public IAiOrders garden_a_elite_b => Scenario.AiOrderDefinitions[175].GameObject;
        public IAiOrders garden_a_elite_c => Scenario.AiOrderDefinitions[176].GameObject;
        public IAiOrders garden_a_pro_dump => Scenario.AiOrderDefinitions[177].GameObject;
        public IAiOrders garden_a_cov_dump => Scenario.AiOrderDefinitions[178].GameObject;
        public IAiOrders garden_a_elites_ini => Scenario.AiOrderDefinitions[179].GameObject;
        public IAiOrders garden_a_grunt_ini => Scenario.AiOrderDefinitions[180].GameObject;
        public IAiOrders garden_a_brute_lt => Scenario.AiOrderDefinitions[181].GameObject;
        public IAiOrders garden_a_brute_rt => Scenario.AiOrderDefinitions[182].GameObject;
        public IAiOrders garden_a_ranger_fr => Scenario.AiOrderDefinitions[183].GameObject;
        public IAiOrders garden_a_ranger_mid => Scenario.AiOrderDefinitions[184].GameObject;
        public IAiOrders garden_a_ranger_bk => Scenario.AiOrderDefinitions[185].GameObject;
        public IAiOrders garden_b_brute => Scenario.AiOrderDefinitions[186].GameObject;
        public IAiOrders garden_a_grunt_a => Scenario.AiOrderDefinitions[187].GameObject;
        public IAiOrders garden_a_grunt_b => Scenario.AiOrderDefinitions[188].GameObject;
        public IAiOrders garden_a_grunt_c => Scenario.AiOrderDefinitions[189].GameObject;
        public IAiOrders ledge_brutes_ini => Scenario.AiOrderDefinitions[190].GameObject;
        public IAiOrders grand_a_turret => Scenario.AiOrderDefinitions[191].GameObject;
        public IAiOrders ext_a_tram_a => Scenario.AiOrderDefinitions[192].GameObject;
        public IAiOrders ext_a_prophets_follow => Scenario.AiOrderDefinitions[193].GameObject;
        public IAiOrders ext_a_covenant_follow => Scenario.AiOrderDefinitions[194].GameObject;
        public IAiOrders ext_a_follow_elites => Scenario.AiOrderDefinitions[195].GameObject;
        public IAiOrders ext_a_brute_bk_door => Scenario.AiOrderDefinitions[196].GameObject;
        public IAiOrders ext_b_brute_ramp => Scenario.AiOrderDefinitions[197].GameObject;
        public IAiOrders grand_b_hunter_b => Scenario.AiOrderDefinitions[198].GameObject;
        public IAiOrders maus_room_cov_follow => Scenario.AiOrderDefinitions[199].GameObject;
        public IAiOrders maus_room_prophet_follow => Scenario.AiOrderDefinitions[200].GameObject;
        public IAiOrders maus_bridge_cov_screw => Scenario.AiOrderDefinitions[201].GameObject;
        public IAiOrders maus_bridge_prophet_screw => Scenario.AiOrderDefinitions[202].GameObject;
        public IAiOrders ice_cream_grunt => Scenario.AiOrderDefinitions[203].GameObject;
        public IAiOrders garden_a_elites_bk => Scenario.AiOrderDefinitions[204].GameObject;
        public IAiOrders garden_a_grunt_bk => Scenario.AiOrderDefinitions[205].GameObject;
        public IAiOrders garden_a_jackal_bk => Scenario.AiOrderDefinitions[206].GameObject;
        public IAiOrders gardne_a_brute_bk => Scenario.AiOrderDefinitions[207].GameObject;
        public IAiOrders maus_inner_bk => Scenario.AiOrderDefinitions[208].GameObject;
        public IAiOrders maus_inner_zealot => Scenario.AiOrderDefinitions[209].GameObject;
        public IAiOrders maus_inner_spec => Scenario.AiOrderDefinitions[210].GameObject;
        public ILocationFlag council_chamber => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag halls => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag garden => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag mausoleum => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag anchor_flag_x08 => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag anchor_flag_intra1 => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag anchor_flag_intro_a => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag anchor_flag_intro_b => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag anchor_flag_intro_c => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag cortana_council => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag cortana_ledge => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag cortana_ledge_fr => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag cor_maus_inner_a => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag cor_maus_inner_b => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag cor_maus_inner_c => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag cor_maus_inner_d => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag cor_maus_inner_e => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag cor_maus_inner_f => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag cor_maus_inner_g => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag cor_maus_inner_h => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag cor_maus_inner_i => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag cor_maus_inner_j => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag jails0_tele => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag jails1_tele => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag corrb0_tele => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag corrb1_tele => Scenario.LocationFlagDefinitions[27];
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_2 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title_3 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ICinematicTitle title_4 => Scenario.CinematicTitleDefinitions[3].GameObject;
        public ITriggerVolume tv_garden_a_tram => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_1_0 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume bsp_1_2 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume bsp_2_3 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume bsp_3_4 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume bsp_4_5 => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume bsp_5_4 => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume _null => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume tv_room_a_lift_bot => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume tv_room_a_lift_top => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume tv_dervish_ledge => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume tv_corridors_a => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_tower_a_ext => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume tv_mid_tower_room => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_gardens_b => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_tower_b_ext => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_mausoleum_ext => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_mausoleum => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume life_cliffb_fish => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume life_dervish_gullsdw => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume life_jailroach1 => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume life_cliffa_birds => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume life_cliffa_closebirds => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_council_fr => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_council_lt_fr => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume tv_council_lt_bk => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_council_rt_fr => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_council_rt_bk => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume tv_council_door_left_a => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume tv_council_door_left_b => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume tv_council_door_left_c => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_council_door_right_a => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_council_door_right_b => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume tv_council_door_right_c => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume tv_council_door_upper_right_a => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_council_door_upper_right_b => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_council_door_upper_right_c => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_council_door_upper_left_a => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_council_door_upper_left_b => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_council_door_upper_left_c => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_council_bk => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume tv_dervish_grand_hall => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_dervish_ledge_fr => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume tv_dervish_ledge_bk => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_dervish_ledge_lift => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_dervish_ledge_lower => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_maus_inner_mid => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume tv_maus_ent => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume tv_maus_inner_door_a => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume tv_maus_inner_door_b => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume tv_maus_inner_door_c => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume tv_maus_inner_door_d => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume tv_maus_inner_door_e => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume tv_maus_inner_door_f => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume tv_game_won => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume tv_jails => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume tv_jail_a_ent => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume tv_jail_top => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume tv_jail_mid => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume tv_jail_bot => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume tv_jail_door_g => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume tv_jail_door_i => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume tv_jail_door_j => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume tv_jail_door_c => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume tv_jail_door_d => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume tv_jail_door_e => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume tv_jail_door_f => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume tv_jail_door_k => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume tv_jail_door_l => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume tv_jail_door_m => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume tv_cell_a => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume tv_cell_b => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume tv_maus_bridge_fr => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume tv_maus_bridge_mid => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume tv_maus_bridge_bk => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume tv_maus_bridge => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume tv_maus_room => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume tv_maus_room_bk => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume tv_hall_a_jackal_patrol => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume tv_hall_a_bk => Scenario.TriggerVolumes[80].GameObject;
        public ITriggerVolume tv_hall_b => Scenario.TriggerVolumes[81].GameObject;
        public ITriggerVolume tv_hall_b_jackal => Scenario.TriggerVolumes[82].GameObject;
        public ITriggerVolume tv_room_a_mid => Scenario.TriggerVolumes[83].GameObject;
        public ITriggerVolume tv_room_a_bk => Scenario.TriggerVolumes[84].GameObject;
        public ITriggerVolume tv_room_a_bot => Scenario.TriggerVolumes[85].GameObject;
        public ITriggerVolume tv_room_a_door_a => Scenario.TriggerVolumes[86].GameObject;
        public ITriggerVolume tv_room_a_door_b => Scenario.TriggerVolumes[87].GameObject;
        public ITriggerVolume tv_room_a_door_c => Scenario.TriggerVolumes[88].GameObject;
        public ITriggerVolume tv_room_a => Scenario.TriggerVolumes[89].GameObject;
        public ITriggerVolume tv_room_a_tube => Scenario.TriggerVolumes[90].GameObject;
        public ITriggerVolume tv_grand_a => Scenario.TriggerVolumes[91].GameObject;
        public ITriggerVolume tv_council_hall => Scenario.TriggerVolumes[92].GameObject;
        public ITriggerVolume tv_jail_b_ent => Scenario.TriggerVolumes[93].GameObject;
        public ITriggerVolume tv_room_b => Scenario.TriggerVolumes[94].GameObject;
        public ITriggerVolume tv_hall_c => Scenario.TriggerVolumes[95].GameObject;
        public ITriggerVolume tv_hall_c_bk => Scenario.TriggerVolumes[96].GameObject;
        public ITriggerVolume tv_grand_b => Scenario.TriggerVolumes[97].GameObject;
        public ITriggerVolume tv_hall_d => Scenario.TriggerVolumes[98].GameObject;
        public ITriggerVolume tv_midtower_mid => Scenario.TriggerVolumes[99].GameObject;
        public ITriggerVolume tv_midtower_bk => Scenario.TriggerVolumes[100].GameObject;
        public ITriggerVolume tv_ext_a_mid => Scenario.TriggerVolumes[101].GameObject;
        public ITriggerVolume tv_ext_a_lt => Scenario.TriggerVolumes[102].GameObject;
        public ITriggerVolume tv_ext_a_rt => Scenario.TriggerVolumes[103].GameObject;
        public ITriggerVolume tv_ext_a_exit => Scenario.TriggerVolumes[104].GameObject;
        public ITriggerVolume tv_gardens_a => Scenario.TriggerVolumes[105].GameObject;
        public ITriggerVolume tv_start => Scenario.TriggerVolumes[106].GameObject;
        public ITriggerVolume tv_ext_b_low => Scenario.TriggerVolumes[107].GameObject;
        public ITriggerVolume tv_ext_b => Scenario.TriggerVolumes[108].GameObject;
        public ITriggerVolume tv_ext_b_lt => Scenario.TriggerVolumes[109].GameObject;
        public ITriggerVolume tv_tower_a_ramp => Scenario.TriggerVolumes[110].GameObject;
        public ITriggerVolume tv_garden_a_fr => Scenario.TriggerVolumes[111].GameObject;
        public ITriggerVolume tv_garden_a_mid => Scenario.TriggerVolumes[112].GameObject;
        public ITriggerVolume tv_garden_a_bk => Scenario.TriggerVolumes[113].GameObject;
        public ITriggerVolume tv_tram_b => Scenario.TriggerVolumes[114].GameObject;
        public ITriggerVolume tv_mid_tower => Scenario.TriggerVolumes[115].GameObject;
        public ITriggerVolume tv_garden_b_fr => Scenario.TriggerVolumes[116].GameObject;
        public ITriggerVolume tv_garden_b_mid => Scenario.TriggerVolumes[117].GameObject;
        public ITriggerVolume tv_garden_b_bk => Scenario.TriggerVolumes[118].GameObject;
        public ITriggerVolume bsp_3_2 => Scenario.TriggerVolumes[119].GameObject;
        public ITriggerVolume kill => Scenario.TriggerVolumes[120].GameObject;
        public ITriggerVolume tv_council_ext => Scenario.TriggerVolumes[121].GameObject;
        public ITriggerVolume kill1 => Scenario.TriggerVolumes[122].GameObject;
        public ITriggerVolume bsp_4_3 => Scenario.TriggerVolumes[123].GameObject;
        public ITriggerVolume tv_maus_ent_door_a => Scenario.TriggerVolumes[124].GameObject;
        public ITriggerVolume tv_maus_ent_door_b => Scenario.TriggerVolumes[125].GameObject;
        public ITriggerVolume tv_tram_a_no_save => Scenario.TriggerVolumes[126].GameObject;
        public ITriggerVolume kill2 => Scenario.TriggerVolumes[127].GameObject;
        public ITriggerVolume kill3 => Scenario.TriggerVolumes[128].GameObject;
        public ITriggerVolume kill4 => Scenario.TriggerVolumes[129].GameObject;
        public ITriggerVolume kill5 => Scenario.TriggerVolumes[130].GameObject;
        public ITriggerVolume kill6 => Scenario.TriggerVolumes[131].GameObject;
        public ITriggerVolume kill7 => Scenario.TriggerVolumes[132].GameObject;
        public ITriggerVolume tv_ice_cream => Scenario.TriggerVolumes[133].GameObject;
        public ITriggerVolume tv_garden_a_fr_suck => Scenario.TriggerVolumes[134].GameObject;
        public ITriggerVolume tv_sc_gardens_b => Scenario.TriggerVolumes[135].GameObject;
        public ITriggerVolume tv_tram_b_no_save => Scenario.TriggerVolumes[136].GameObject;
        public ITriggerVolume tv_tram_c_no_save => Scenario.TriggerVolumes[137].GameObject;
        public ITriggerVolume tv_tram_d_no_save => Scenario.TriggerVolumes[138].GameObject;
        public ITriggerVolume tv_garden_a_tram_b => Scenario.TriggerVolumes[139].GameObject;
        public ITriggerVolume kill_maus => Scenario.TriggerVolumes[140].GameObject;
        public ITriggerVolume tv_room_b_start => Scenario.TriggerVolumes[141].GameObject;
        public ITriggerVolume kill8 => Scenario.TriggerVolumes[142].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile player_starting_profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IStartingProfile jail_a_a => Scenario.StartingProfileDefinitions[2].GameObject;
        public IStartingProfile jail_a_b => Scenario.StartingProfileDefinitions[3].GameObject;
        public IStartingProfile jail_b_a => Scenario.StartingProfileDefinitions[4].GameObject;
        public IStartingProfile jail_b_b => Scenario.StartingProfileDefinitions[5].GameObject;
        public IStartingProfile jail_b_c => Scenario.StartingProfileDefinitions[6].GameObject;
        public IDeviceGroup cell_a => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup cell_b => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup maus_door_ent => Scenario.DeviceGroupDefinitions[2].GameObject;
        public IDeviceGroup maus_door_exit => Scenario.DeviceGroupDefinitions[3].GameObject;
        public IDeviceGroup maus_door_end1 => Scenario.DeviceGroupDefinitions[4].GameObject;
        public IDeviceGroup jail_a_doors1 => Scenario.DeviceGroupDefinitions[5].GameObject;
        public IDeviceGroup jail_b_doors1 => Scenario.DeviceGroupDefinitions[6].GameObject;
        public IDeviceGroup jail_a_group_a => Scenario.DeviceGroupDefinitions[7].GameObject;
        public IDeviceGroup jail_a_group_b => Scenario.DeviceGroupDefinitions[8].GameObject;
        public IDeviceGroup jail_a_group_c => Scenario.DeviceGroupDefinitions[9].GameObject;
        public IDeviceGroup jail_b_group_a => Scenario.DeviceGroupDefinitions[10].GameObject;
        public IDeviceGroup jail_b_group_b => Scenario.DeviceGroupDefinitions[11].GameObject;
        public IDeviceGroup jail_b_group_c => Scenario.DeviceGroupDefinitions[12].GameObject;
        public IDeviceGroup maus_hall_door_open => Scenario.DeviceGroupDefinitions[13].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            hammer = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            index = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            tentacle_capture_01 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            tentacle_chief = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            tentacle_capture_02 = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            tentacle_capture_03 = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            tentacle_capture_04 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            tentacle_capture_05 = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            tentacle_arbiter = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            anchor_intro_a = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            matte_high_charity = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            anchor_intro_b = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            anchor_intro_c = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            index_intro = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            bsp_0_holo_a = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            bsp_0_holo_h = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            bsp_0_holo_g = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            bsp_0_holo_i = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            dervish_ped_fr_b = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            anchor_intra1 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            bsp_0_holo_j = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            maus_inner_holo_f = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            maus_inner_holo_a = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            maus_inner_holo_b = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            maus_inner_holo_c = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            maus_inner_holo_d = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            maus_inner_holo_e = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            maus_inner_holo_g = new ScenarioEntity<IScenery>(27, scenarioTag.WellKnownItems[27]);
            maus_inner_holo_h = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            maus_inner_holo_k = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            maus_inner_holo_l = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            maus_inner_holo_m = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            maus_inner_holo_n = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            maus_inner_holo_o = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            maus_inner_holo_p = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            maus_inner_holo_j = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            maus_inner_holo_i = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            jail_a_plasma_rifle = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            jail_a_needler = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            jail_b_plasma_rifle = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            jail_b_plasma_pistol = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            jail_b_carbine = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            jail_ped_a = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            jail_ped_b = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            jail_ped_c = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            jail_ped_d = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            jail_ped_e = new ScenarioEntity<IScenery>(46, scenarioTag.WellKnownItems[46]);
            jail_ped_f = new ScenarioEntity<IScenery>(47, scenarioTag.WellKnownItems[47]);
            jail_ped_g = new ScenarioEntity<IScenery>(48, scenarioTag.WellKnownItems[48]);
            jail_ped_h = new ScenarioEntity<IScenery>(49, scenarioTag.WellKnownItems[49]);
            jail_ped_i = new ScenarioEntity<IScenery>(50, scenarioTag.WellKnownItems[50]);
            jail_ped_j = new ScenarioEntity<IScenery>(51, scenarioTag.WellKnownItems[51]);
            jail_ped_k = new ScenarioEntity<IScenery>(52, scenarioTag.WellKnownItems[52]);
            jail_ped_l = new ScenarioEntity<IScenery>(53, scenarioTag.WellKnownItems[53]);
            jail_ped_m = new ScenarioEntity<IScenery>(54, scenarioTag.WellKnownItems[54]);
            jail_ped_n = new ScenarioEntity<IScenery>(55, scenarioTag.WellKnownItems[55]);
            jail_ped_o = new ScenarioEntity<IScenery>(56, scenarioTag.WellKnownItems[56]);
            jail_ped_p = new ScenarioEntity<IScenery>(57, scenarioTag.WellKnownItems[57]);
            jail_ped_q = new ScenarioEntity<IScenery>(58, scenarioTag.WellKnownItems[58]);
            jail_ped_r = new ScenarioEntity<IScenery>(59, scenarioTag.WellKnownItems[59]);
            jail_ped_t = new ScenarioEntity<IScenery>(60, scenarioTag.WellKnownItems[60]);
            jail_ped_s = new ScenarioEntity<IScenery>(61, scenarioTag.WellKnownItems[61]);
            jail_ped_u = new ScenarioEntity<IScenery>(62, scenarioTag.WellKnownItems[62]);
            maus_bridge_holo_b = new ScenarioEntity<IScenery>(63, scenarioTag.WellKnownItems[63]);
            maus_bridge_holo_a = new ScenarioEntity<IScenery>(64, scenarioTag.WellKnownItems[64]);
            maus_bridge_holo_c = new ScenarioEntity<IScenery>(65, scenarioTag.WellKnownItems[65]);
            maus_bridge_holo_d = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            maus_bridge_holo_e = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            maus_bridge_holo_f = new ScenarioEntity<IScenery>(68, scenarioTag.WellKnownItems[68]);
            maus_room_holo_c = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            maus_room_holo_d = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            maus_room_holo_f = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            maus_room_holo_g = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            maus_room_holo_i = new ScenarioEntity<IScenery>(73, scenarioTag.WellKnownItems[73]);
            maus_room_holo_j = new ScenarioEntity<IScenery>(74, scenarioTag.WellKnownItems[74]);
            maus_room_holo_k = new ScenarioEntity<IScenery>(75, scenarioTag.WellKnownItems[75]);
            hall_a_holo_d = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            hall_a_holo_h = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            hall_a_holo_k = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            hall_a_holo_o = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            grand_b_holo_a = new ScenarioEntity<IScenery>(80, scenarioTag.WellKnownItems[80]);
            grand_b_holo_b = new ScenarioEntity<IScenery>(81, scenarioTag.WellKnownItems[81]);
            room_a_holo_a = new ScenarioEntity<IScenery>(82, scenarioTag.WellKnownItems[82]);
            room_a_holo_d = new ScenarioEntity<IScenery>(83, scenarioTag.WellKnownItems[83]);
            room_a_holo_g = new ScenarioEntity<IScenery>(84, scenarioTag.WellKnownItems[84]);
            room_a_holo_h = new ScenarioEntity<IScenery>(85, scenarioTag.WellKnownItems[85]);
            room_a_holo_i = new ScenarioEntity<IScenery>(86, scenarioTag.WellKnownItems[86]);
            room_a_holo_l = new ScenarioEntity<IScenery>(87, scenarioTag.WellKnownItems[87]);
            room_a_holo_m = new ScenarioEntity<IScenery>(88, scenarioTag.WellKnownItems[88]);
            bsp_0_holo_c = new ScenarioEntity<IScenery>(89, scenarioTag.WellKnownItems[89]);
            bsp_0_holo_f = new ScenarioEntity<IScenery>(90, scenarioTag.WellKnownItems[90]);
            ledge_col_a = new ScenarioEntity<IScenery>(91, scenarioTag.WellKnownItems[91]);
            ledge_col_b = new ScenarioEntity<IScenery>(92, scenarioTag.WellKnownItems[92]);
            ledge_col_c = new ScenarioEntity<IScenery>(93, scenarioTag.WellKnownItems[93]);
            ledge_col_d = new ScenarioEntity<IScenery>(94, scenarioTag.WellKnownItems[94]);
            ledge_col_e = new ScenarioEntity<IScenery>(95, scenarioTag.WellKnownItems[95]);
            ledge_col_f = new ScenarioEntity<IScenery>(96, scenarioTag.WellKnownItems[96]);
            garden_a_holo_a = new ScenarioEntity<IScenery>(97, scenarioTag.WellKnownItems[97]);
            ioc_effect = new ScenarioEntity<IScenery>(98, scenarioTag.WellKnownItems[98]);
            bsp_0_holo_b = new ScenarioEntity<IScenery>(99, scenarioTag.WellKnownItems[99]);
            anchor_x08 = new ScenarioEntity<IScenery>(100, scenarioTag.WellKnownItems[100]);
            intro_fleet_01 = new ScenarioEntity<IScenery>(101, scenarioTag.WellKnownItems[101]);
            intro_pike_01 = new ScenarioEntity<IScenery>(102, scenarioTag.WellKnownItems[102]);
            intro_pike_02 = new ScenarioEntity<IScenery>(103, scenarioTag.WellKnownItems[103]);
            intro_pike_03 = new ScenarioEntity<IScenery>(104, scenarioTag.WellKnownItems[104]);
            intro_pike_04 = new ScenarioEntity<IScenery>(105, scenarioTag.WellKnownItems[105]);
            intro_pike_05 = new ScenarioEntity<IScenery>(106, scenarioTag.WellKnownItems[106]);
            intro_pike_06 = new ScenarioEntity<IScenery>(107, scenarioTag.WellKnownItems[107]);
            grunt_card = new ScenarioEntity<IScenery>(108, scenarioTag.WellKnownItems[108]);
            intro_fleet_02 = new ScenarioEntity<IScenery>(109, scenarioTag.WellKnownItems[109]);
            intro_crowd_01 = new ScenarioEntity<IScenery>(110, scenarioTag.WellKnownItems[110]);
            intro_crowd_02 = new ScenarioEntity<IScenery>(111, scenarioTag.WellKnownItems[111]);
            intro_crowd_03 = new ScenarioEntity<IScenery>(112, scenarioTag.WellKnownItems[112]);
            intro_crowd_04 = new ScenarioEntity<IScenery>(113, scenarioTag.WellKnownItems[113]);
            intro_crowd_05 = new ScenarioEntity<IScenery>(114, scenarioTag.WellKnownItems[114]);
            intro_crowd_06 = new ScenarioEntity<IScenery>(115, scenarioTag.WellKnownItems[115]);
            intro_crowd_07 = new ScenarioEntity<IScenery>(116, scenarioTag.WellKnownItems[116]);
            intro_crowd_08 = new ScenarioEntity<IScenery>(117, scenarioTag.WellKnownItems[117]);
            intro_crowd_09 = new ScenarioEntity<IScenery>(118, scenarioTag.WellKnownItems[118]);
            intro_crowd_10 = new ScenarioEntity<IScenery>(119, scenarioTag.WellKnownItems[119]);
            intro_crowd_11 = new ScenarioEntity<IScenery>(120, scenarioTag.WellKnownItems[120]);
            intro_crowd_12 = new ScenarioEntity<IScenery>(121, scenarioTag.WellKnownItems[121]);
            intro_crowd_13 = new ScenarioEntity<IScenery>(122, scenarioTag.WellKnownItems[122]);
            intro_crowd_14 = new ScenarioEntity<IScenery>(123, scenarioTag.WellKnownItems[123]);
            holo_cam = new ScenarioEntity<IScenery>(124, scenarioTag.WellKnownItems[124]);
            texture_camera = new ScenarioEntity<IScenery>(125, scenarioTag.WellKnownItems[125]);
            teleport = new ScenarioEntity<IScenery>(126, scenarioTag.WellKnownItems[126]);
            intra_pike_01 = new ScenarioEntity<IScenery>(127, scenarioTag.WellKnownItems[127]);
            intra_pike_02 = new ScenarioEntity<IScenery>(128, scenarioTag.WellKnownItems[128]);
            holo_generator = new ScenarioEntity<IScenery>(129, scenarioTag.WellKnownItems[129]);
            council_sound_a = new ScenarioEntity<IScenery>(130, scenarioTag.WellKnownItems[130]);
            council_sound_b = new ScenarioEntity<IScenery>(131, scenarioTag.WellKnownItems[131]);
            council_sound_c = new ScenarioEntity<IScenery>(132, scenarioTag.WellKnownItems[132]);
            council_sound_d = new ScenarioEntity<IScenery>(133, scenarioTag.WellKnownItems[133]);
            stardust_01 = new ScenarioEntity<IScenery>(134, scenarioTag.WellKnownItems[134]);
            stardust_02 = new ScenarioEntity<IScenery>(135, scenarioTag.WellKnownItems[135]);
            delta_halo = new ScenarioEntity<IScenery>(136, scenarioTag.WellKnownItems[136]);
            corr_a_sound_a = new ScenarioEntity<IScenery>(137, scenarioTag.WellKnownItems[137]);
            corr_a_sound_b = new ScenarioEntity<IScenery>(138, scenarioTag.WellKnownItems[138]);
            corr_a_sound_c = new ScenarioEntity<IScenery>(139, scenarioTag.WellKnownItems[139]);
            corr_a_sound_d = new ScenarioEntity<IScenery>(140, scenarioTag.WellKnownItems[140]);
            corr_b_sound_a = new ScenarioEntity<IScenery>(141, scenarioTag.WellKnownItems[141]);
            corr_b_sound_b = new ScenarioEntity<IScenery>(142, scenarioTag.WellKnownItems[142]);
            corr_b_sound_c = new ScenarioEntity<IScenery>(143, scenarioTag.WellKnownItems[143]);
            corr_b_sound_d = new ScenarioEntity<IScenery>(144, scenarioTag.WellKnownItems[144]);
            corr_b_sound_e = new ScenarioEntity<IScenery>(145, scenarioTag.WellKnownItems[145]);
            corr_b_sound_f = new ScenarioEntity<IScenery>(146, scenarioTag.WellKnownItems[146]);
            corr_b_sound_g = new ScenarioEntity<IScenery>(147, scenarioTag.WellKnownItems[147]);
            corr_b_sound_h = new ScenarioEntity<IScenery>(148, scenarioTag.WellKnownItems[148]);
            ioc_sound_a = new ScenarioEntity<IScenery>(149, scenarioTag.WellKnownItems[149]);
            ioc_sound_c = new ScenarioEntity<IScenery>(150, scenarioTag.WellKnownItems[150]);
            midtower_sound_a = new ScenarioEntity<IScenery>(151, scenarioTag.WellKnownItems[151]);
            midtower_sound_b = new ScenarioEntity<IScenery>(152, scenarioTag.WellKnownItems[152]);
            midtower_sound_c = new ScenarioEntity<IScenery>(153, scenarioTag.WellKnownItems[153]);
            midtower_sound_d = new ScenarioEntity<IScenery>(154, scenarioTag.WellKnownItems[154]);
            midtower_sound_e = new ScenarioEntity<IScenery>(155, scenarioTag.WellKnownItems[155]);
            garden_b_sound_a = new ScenarioEntity<IScenery>(156, scenarioTag.WellKnownItems[156]);
            garden_b_sound_b = new ScenarioEntity<IScenery>(157, scenarioTag.WellKnownItems[157]);
            garden_b_sound_c = new ScenarioEntity<IScenery>(158, scenarioTag.WellKnownItems[158]);
            garden_b_sound_d = new ScenarioEntity<IScenery>(159, scenarioTag.WellKnownItems[159]);
            ioc_sound_b = new ScenarioEntity<IScenery>(160, scenarioTag.WellKnownItems[160]);
            garden_b_sound_e = new ScenarioEntity<IScenery>(161, scenarioTag.WellKnownItems[161]);
            garden_b_sound_f = new ScenarioEntity<IScenery>(162, scenarioTag.WellKnownItems[162]);
            garden_b_sound_g = new ScenarioEntity<IScenery>(163, scenarioTag.WellKnownItems[163]);
            garden_b_sound_h = new ScenarioEntity<IScenery>(164, scenarioTag.WellKnownItems[164]);
            rupture = new ScenarioEntity<IScenery>(165, scenarioTag.WellKnownItems[165]);
            matte_substance = new ScenarioEntity<IScenery>(166, scenarioTag.WellKnownItems[166]);
            bsp0_crate_0 = new ScenarioEntity<IBloc>(167, scenarioTag.WellKnownItems[167]);
            bsp1_crate_0 = new ScenarioEntity<IBloc>(168, scenarioTag.WellKnownItems[168]);
            bsp1_crate_1 = new ScenarioEntity<IBloc>(169, scenarioTag.WellKnownItems[169]);
            bsp1_crate_2 = new ScenarioEntity<IBloc>(170, scenarioTag.WellKnownItems[170]);
            bsp1_crate_3 = new ScenarioEntity<IBloc>(171, scenarioTag.WellKnownItems[171]);
            bsp1_crate_4 = new ScenarioEntity<IBloc>(172, scenarioTag.WellKnownItems[172]);
            bsp1_crate_5 = new ScenarioEntity<IBloc>(173, scenarioTag.WellKnownItems[173]);
            bsp1_crate_6 = new ScenarioEntity<IBloc>(174, scenarioTag.WellKnownItems[174]);
            bsp1_crate_7 = new ScenarioEntity<IBloc>(175, scenarioTag.WellKnownItems[175]);
            bsp2_crate_0 = new ScenarioEntity<IBloc>(176, scenarioTag.WellKnownItems[176]);
            bsp2_crate_1 = new ScenarioEntity<IBloc>(177, scenarioTag.WellKnownItems[177]);
            bsp2_crate_21 = new ScenarioEntity<IBloc>(178, scenarioTag.WellKnownItems[178]);
            bsp2_crate_2 = new ScenarioEntity<IBloc>(179, scenarioTag.WellKnownItems[179]);
            bsp2_crate_3 = new ScenarioEntity<IBloc>(180, scenarioTag.WellKnownItems[180]);
            bsp2_crate_4 = new ScenarioEntity<IBloc>(181, scenarioTag.WellKnownItems[181]);
            bsp2_crate_5 = new ScenarioEntity<IBloc>(182, scenarioTag.WellKnownItems[182]);
            bsp2_crate_6 = new ScenarioEntity<IBloc>(183, scenarioTag.WellKnownItems[183]);
            bsp2_crate_7 = new ScenarioEntity<IBloc>(184, scenarioTag.WellKnownItems[184]);
            bsp2_crate_8 = new ScenarioEntity<IBloc>(185, scenarioTag.WellKnownItems[185]);
            bsp2_crate_9 = new ScenarioEntity<IBloc>(186, scenarioTag.WellKnownItems[186]);
            bsp2_crate_10 = new ScenarioEntity<IBloc>(187, scenarioTag.WellKnownItems[187]);
            bsp2_crate_11 = new ScenarioEntity<IBloc>(188, scenarioTag.WellKnownItems[188]);
            bsp3_crate_0 = new ScenarioEntity<IBloc>(189, scenarioTag.WellKnownItems[189]);
            bsp3_crate_1 = new ScenarioEntity<IBloc>(190, scenarioTag.WellKnownItems[190]);
            bsp3_crate_2 = new ScenarioEntity<IBloc>(191, scenarioTag.WellKnownItems[191]);
            bsp3_crate_3 = new ScenarioEntity<IBloc>(192, scenarioTag.WellKnownItems[192]);
            bsp3_crate_4 = new ScenarioEntity<IBloc>(193, scenarioTag.WellKnownItems[193]);
            bsp3_crate_5 = new ScenarioEntity<IBloc>(194, scenarioTag.WellKnownItems[194]);
            bsp3_crate_6 = new ScenarioEntity<IBloc>(195, scenarioTag.WellKnownItems[195]);
            bsp3_crate_7 = new ScenarioEntity<IBloc>(196, scenarioTag.WellKnownItems[196]);
            bsp3_crate_8 = new ScenarioEntity<IBloc>(197, scenarioTag.WellKnownItems[197]);
            bsp3_crate_9 = new ScenarioEntity<IBloc>(198, scenarioTag.WellKnownItems[198]);
            bsp3_crate_10 = new ScenarioEntity<IBloc>(199, scenarioTag.WellKnownItems[199]);
            bsp3_crate_11 = new ScenarioEntity<IBloc>(200, scenarioTag.WellKnownItems[200]);
            bsp3_crate_12 = new ScenarioEntity<IBloc>(201, scenarioTag.WellKnownItems[201]);
            bsp3_crate_13 = new ScenarioEntity<IBloc>(202, scenarioTag.WellKnownItems[202]);
            bsp3_crate_14 = new ScenarioEntity<IBloc>(203, scenarioTag.WellKnownItems[203]);
            bsp3_crate_15 = new ScenarioEntity<IBloc>(204, scenarioTag.WellKnownItems[204]);
            bsp3_crate_16 = new ScenarioEntity<IBloc>(205, scenarioTag.WellKnownItems[205]);
            bsp3_crate_17 = new ScenarioEntity<IBloc>(206, scenarioTag.WellKnownItems[206]);
            bsp3_crate_18 = new ScenarioEntity<IBloc>(207, scenarioTag.WellKnownItems[207]);
            bsp3_crate_19 = new ScenarioEntity<IBloc>(208, scenarioTag.WellKnownItems[208]);
            bsp3_crate_20 = new ScenarioEntity<IBloc>(209, scenarioTag.WellKnownItems[209]);
            bsp3_crate_21 = new ScenarioEntity<IBloc>(210, scenarioTag.WellKnownItems[210]);
            bsp3b_crate_0 = new ScenarioEntity<IBloc>(211, scenarioTag.WellKnownItems[211]);
            bsp3b_crate_1 = new ScenarioEntity<IBloc>(212, scenarioTag.WellKnownItems[212]);
            bsp3b_crate_2 = new ScenarioEntity<IBloc>(213, scenarioTag.WellKnownItems[213]);
            bsp3b_crate_3 = new ScenarioEntity<IBloc>(214, scenarioTag.WellKnownItems[214]);
            bsp3b_crate_4 = new ScenarioEntity<IBloc>(215, scenarioTag.WellKnownItems[215]);
            bsp3b_crate_5 = new ScenarioEntity<IBloc>(216, scenarioTag.WellKnownItems[216]);
            bsp3b_crate_6 = new ScenarioEntity<IBloc>(217, scenarioTag.WellKnownItems[217]);
            bsp3b_crate_7 = new ScenarioEntity<IBloc>(218, scenarioTag.WellKnownItems[218]);
            bsp3b_crate_8 = new ScenarioEntity<IBloc>(219, scenarioTag.WellKnownItems[219]);
            bsp3b_crate_9 = new ScenarioEntity<IBloc>(220, scenarioTag.WellKnownItems[220]);
            bsp3b_crate_10 = new ScenarioEntity<IBloc>(221, scenarioTag.WellKnownItems[221]);
            bsp3b_crate_11 = new ScenarioEntity<IBloc>(222, scenarioTag.WellKnownItems[222]);
            bsp3b_crate_12 = new ScenarioEntity<IBloc>(223, scenarioTag.WellKnownItems[223]);
            bsp3b_crate_13 = new ScenarioEntity<IBloc>(224, scenarioTag.WellKnownItems[224]);
            bsp3b_crate_14 = new ScenarioEntity<IBloc>(225, scenarioTag.WellKnownItems[225]);
            bsp3b_crate_15 = new ScenarioEntity<IBloc>(226, scenarioTag.WellKnownItems[226]);
            bsp3b_crate_16 = new ScenarioEntity<IBloc>(227, scenarioTag.WellKnownItems[227]);
            bsp3b_crate_17 = new ScenarioEntity<IBloc>(228, scenarioTag.WellKnownItems[228]);
            bsp3b_crate_18 = new ScenarioEntity<IBloc>(229, scenarioTag.WellKnownItems[229]);
            bsp3b_crate_19 = new ScenarioEntity<IBloc>(230, scenarioTag.WellKnownItems[230]);
            bsp3b_crate_20 = new ScenarioEntity<IBloc>(231, scenarioTag.WellKnownItems[231]);
            bsp3b_crate_21 = new ScenarioEntity<IBloc>(232, scenarioTag.WellKnownItems[232]);
            bsp3b_crate_22 = new ScenarioEntity<IBloc>(233, scenarioTag.WellKnownItems[233]);
            bsp3b_crate_23 = new ScenarioEntity<IBloc>(234, scenarioTag.WellKnownItems[234]);
            bsp3b_crate_24 = new ScenarioEntity<IBloc>(235, scenarioTag.WellKnownItems[235]);
            bsp3b_crate_27 = new ScenarioEntity<IBloc>(236, scenarioTag.WellKnownItems[236]);
            bsp3b_crate_28 = new ScenarioEntity<IBloc>(237, scenarioTag.WellKnownItems[237]);
            bsp3b_crate_29 = new ScenarioEntity<IBloc>(238, scenarioTag.WellKnownItems[238]);
            bsp4_crate_0 = new ScenarioEntity<IBloc>(239, scenarioTag.WellKnownItems[239]);
            bsp4_crate_1 = new ScenarioEntity<IBloc>(240, scenarioTag.WellKnownItems[240]);
            bsp4_crate_2 = new ScenarioEntity<IBloc>(241, scenarioTag.WellKnownItems[241]);
            bsp4_crate_3 = new ScenarioEntity<IBloc>(242, scenarioTag.WellKnownItems[242]);
            bsp4_crate_4 = new ScenarioEntity<IBloc>(243, scenarioTag.WellKnownItems[243]);
            bsp4_crate_5 = new ScenarioEntity<IBloc>(244, scenarioTag.WellKnownItems[244]);
            corr_b_sound_i = new ScenarioEntity<IScenery>(245, scenarioTag.WellKnownItems[245]);
            ext_a_sound_a = new ScenarioEntity<IScenery>(246, scenarioTag.WellKnownItems[246]);
            ext_a_sound_b = new ScenarioEntity<IScenery>(247, scenarioTag.WellKnownItems[247]);
            ext_a_sound_d = new ScenarioEntity<IScenery>(248, scenarioTag.WellKnownItems[248]);
            ext_a_sound_e = new ScenarioEntity<IScenery>(249, scenarioTag.WellKnownItems[249]);
            ext_a_sound_f = new ScenarioEntity<IScenery>(250, scenarioTag.WellKnownItems[250]);
            ext_a_sound_g = new ScenarioEntity<IScenery>(251, scenarioTag.WellKnownItems[251]);
            chief = new ScenarioEntity<IUnit>(252, scenarioTag.WellKnownItems[252]);
            _2401 = new ScenarioEntity<IUnit>(253, scenarioTag.WellKnownItems[253]);
            dervish = new ScenarioEntity<IUnit>(254, scenarioTag.WellKnownItems[254]);
            johnson = new ScenarioEntity<IUnit>(255, scenarioTag.WellKnownItems[255]);
            miranda = new ScenarioEntity<IUnit>(256, scenarioTag.WellKnownItems[256]);
            truth = new ScenarioEntity<IUnit>(257, scenarioTag.WellKnownItems[257]);
            mercy = new ScenarioEntity<IUnit>(258, scenarioTag.WellKnownItems[258]);
            tartarus = new ScenarioEntity<IUnit>(259, scenarioTag.WellKnownItems[259]);
            brute_01 = new ScenarioEntity<IUnit>(260, scenarioTag.WellKnownItems[260]);
            brute_02 = new ScenarioEntity<IUnit>(261, scenarioTag.WellKnownItems[261]);
            brute_03 = new ScenarioEntity<IUnit>(262, scenarioTag.WellKnownItems[262]);
            brute_04 = new ScenarioEntity<IUnit>(263, scenarioTag.WellKnownItems[263]);
            infection_form_01 = new ScenarioEntity<IUnit>(264, scenarioTag.WellKnownItems[264]);
            monitor = new ScenarioEntity<IUnit>(265, scenarioTag.WellKnownItems[265]);
            infection_form_02 = new ScenarioEntity<IUnit>(266, scenarioTag.WellKnownItems[266]);
            brute_05 = new ScenarioEntity<IUnit>(267, scenarioTag.WellKnownItems[267]);
            brute_06 = new ScenarioEntity<IUnit>(268, scenarioTag.WellKnownItems[268]);
            grunt_01 = new ScenarioEntity<IUnit>(269, scenarioTag.WellKnownItems[269]);
            grunt_02 = new ScenarioEntity<IUnit>(270, scenarioTag.WellKnownItems[270]);
            grunt_03 = new ScenarioEntity<IUnit>(271, scenarioTag.WellKnownItems[271]);
            grunt_04 = new ScenarioEntity<IUnit>(272, scenarioTag.WellKnownItems[272]);
            grunt_05 = new ScenarioEntity<IUnit>(273, scenarioTag.WellKnownItems[273]);
            jackal_01 = new ScenarioEntity<IUnit>(274, scenarioTag.WellKnownItems[274]);
            jackal_02 = new ScenarioEntity<IUnit>(275, scenarioTag.WellKnownItems[275]);
            brute_intro_01 = new ScenarioEntity<IUnit>(276, scenarioTag.WellKnownItems[276]);
            brute_intro_02 = new ScenarioEntity<IUnit>(277, scenarioTag.WellKnownItems[277]);
            brute_intro_03 = new ScenarioEntity<IUnit>(278, scenarioTag.WellKnownItems[278]);
            brute_intro_04 = new ScenarioEntity<IUnit>(279, scenarioTag.WellKnownItems[279]);
            mercy_intro = new ScenarioEntity<IUnit>(280, scenarioTag.WellKnownItems[280]);
            truth_intro = new ScenarioEntity<IUnit>(281, scenarioTag.WellKnownItems[281]);
            chief_intro = new ScenarioEntity<IUnit>(282, scenarioTag.WellKnownItems[282]);
            cortana = new ScenarioEntity<IUnit>(283, scenarioTag.WellKnownItems[283]);
            gravemind = new ScenarioEntity<IUnit>(284, scenarioTag.WellKnownItems[284]);
            mercy_no_crown = new ScenarioEntity<IUnit>(285, scenarioTag.WellKnownItems[285]);
            regret = new ScenarioEntity<IUnit>(286, scenarioTag.WellKnownItems[286]);
            bsp2_body_1 = new ScenarioEntity<IUnit>(287, scenarioTag.WellKnownItems[287]);
            bsp2_body_2 = new ScenarioEntity<IUnit>(288, scenarioTag.WellKnownItems[288]);
            bsp2_body_3 = new ScenarioEntity<IUnit>(289, scenarioTag.WellKnownItems[289]);
            bsp2_body_4 = new ScenarioEntity<IUnit>(290, scenarioTag.WellKnownItems[290]);
            bsp2_body_5 = new ScenarioEntity<IUnit>(291, scenarioTag.WellKnownItems[291]);
            phantom_01 = new ScenarioEntity<IVehicle>(292, scenarioTag.WellKnownItems[292]);
            phantom_02 = new ScenarioEntity<IVehicle>(293, scenarioTag.WellKnownItems[293]);
            phantom_03 = new ScenarioEntity<IVehicle>(294, scenarioTag.WellKnownItems[294]);
            throne_mercy = new ScenarioEntity<IVehicle>(295, scenarioTag.WellKnownItems[295]);
            throne_truth = new ScenarioEntity<IVehicle>(296, scenarioTag.WellKnownItems[296]);
            throne_truth_intro = new ScenarioEntity<IVehicle>(297, scenarioTag.WellKnownItems[297]);
            throne_mercy_intro = new ScenarioEntity<IVehicle>(298, scenarioTag.WellKnownItems[298]);
            ice_cream_head = new ScenarioEntity<IWeapon>(299, scenarioTag.WellKnownItems[299]);
            chief_needler = new ScenarioEntity<IWeapon>(300, scenarioTag.WellKnownItems[300]);
            lift_b_control = new ScenarioEntity<IDevice>(301, scenarioTag.WellKnownItems[301]);
            garden_tram_a = new ScenarioEntity<IDevice>(302, scenarioTag.WellKnownItems[302]);
            garden_tram_b = new ScenarioEntity<IDevice>(303, scenarioTag.WellKnownItems[303]);
            garden_tram_d = new ScenarioEntity<IDevice>(304, scenarioTag.WellKnownItems[304]);
            garden_tram_c = new ScenarioEntity<IDevice>(305, scenarioTag.WellKnownItems[305]);
            jail_down = new ScenarioEntity<IDevice>(306, scenarioTag.WellKnownItems[306]);
            room_b_lift = new ScenarioEntity<IDevice>(307, scenarioTag.WellKnownItems[307]);
            jail_up = new ScenarioEntity<IDevice>(308, scenarioTag.WellKnownItems[308]);
            council_door_right_a = new ScenarioEntity<IDevice>(309, scenarioTag.WellKnownItems[309]);
            council_door_right_b = new ScenarioEntity<IDevice>(310, scenarioTag.WellKnownItems[310]);
            council_door_right_c = new ScenarioEntity<IDevice>(311, scenarioTag.WellKnownItems[311]);
            council_door_left_a = new ScenarioEntity<IDevice>(312, scenarioTag.WellKnownItems[312]);
            council_door_left_b = new ScenarioEntity<IDevice>(313, scenarioTag.WellKnownItems[313]);
            council_door_left_c = new ScenarioEntity<IDevice>(314, scenarioTag.WellKnownItems[314]);
            council_door_upper_right_a = new ScenarioEntity<IDevice>(315, scenarioTag.WellKnownItems[315]);
            council_door_upper_right_b = new ScenarioEntity<IDevice>(316, scenarioTag.WellKnownItems[316]);
            council_door_upper_right_c = new ScenarioEntity<IDevice>(317, scenarioTag.WellKnownItems[317]);
            council_door_upper_left_a = new ScenarioEntity<IDevice>(318, scenarioTag.WellKnownItems[318]);
            council_door_upper_left_b = new ScenarioEntity<IDevice>(319, scenarioTag.WellKnownItems[319]);
            council_door_upper_left_c = new ScenarioEntity<IDevice>(320, scenarioTag.WellKnownItems[320]);
            garden_tram_a_bk = new ScenarioEntity<IDevice>(321, scenarioTag.WellKnownItems[321]);
            garden_tram_b_bk = new ScenarioEntity<IDevice>(322, scenarioTag.WellKnownItems[322]);
            dervish_lift_down = new ScenarioEntity<IDevice>(323, scenarioTag.WellKnownItems[323]);
            dervish_lift_up = new ScenarioEntity<IDevice>(324, scenarioTag.WellKnownItems[324]);
            garden_tram_c_bk = new ScenarioEntity<IDevice>(325, scenarioTag.WellKnownItems[325]);
            garden_tram_d_bk = new ScenarioEntity<IDevice>(326, scenarioTag.WellKnownItems[326]);
            mid_tower_door_bk = new ScenarioEntity<IDevice>(327, scenarioTag.WellKnownItems[327]);
            council_exit = new ScenarioEntity<IDevice>(328, scenarioTag.WellKnownItems[328]);
            council_ped = new ScenarioEntity<IDevice>(329, scenarioTag.WellKnownItems[329]);
            maus_door_end = new ScenarioEntity<IDevice>(330, scenarioTag.WellKnownItems[330]);
            maus_inner_ent = new ScenarioEntity<IDevice>(331, scenarioTag.WellKnownItems[331]);
            maus_inner_exit = new ScenarioEntity<IDevice>(332, scenarioTag.WellKnownItems[332]);
            maus_inner_door_a = new ScenarioEntity<IDevice>(333, scenarioTag.WellKnownItems[333]);
            maus_inner_door_b = new ScenarioEntity<IDevice>(334, scenarioTag.WellKnownItems[334]);
            maus_inner_door_c = new ScenarioEntity<IDevice>(335, scenarioTag.WellKnownItems[335]);
            maus_inner_door_d = new ScenarioEntity<IDevice>(336, scenarioTag.WellKnownItems[336]);
            maus_inner_door_e = new ScenarioEntity<IDevice>(337, scenarioTag.WellKnownItems[337]);
            maus_inner_door_f = new ScenarioEntity<IDevice>(338, scenarioTag.WellKnownItems[338]);
            jail_b_door_f = new ScenarioEntity<IDevice>(339, scenarioTag.WellKnownItems[339]);
            jail_a_door_a = new ScenarioEntity<IDevice>(340, scenarioTag.WellKnownItems[340]);
            jail_a_door_b = new ScenarioEntity<IDevice>(341, scenarioTag.WellKnownItems[341]);
            jail_a_door_c = new ScenarioEntity<IDevice>(342, scenarioTag.WellKnownItems[342]);
            jail_a_door_d = new ScenarioEntity<IDevice>(343, scenarioTag.WellKnownItems[343]);
            jail_a_door_e = new ScenarioEntity<IDevice>(344, scenarioTag.WellKnownItems[344]);
            jail_a_door_f = new ScenarioEntity<IDevice>(345, scenarioTag.WellKnownItems[345]);
            jail_b_door_a = new ScenarioEntity<IDevice>(346, scenarioTag.WellKnownItems[346]);
            jail_b_door_b = new ScenarioEntity<IDevice>(347, scenarioTag.WellKnownItems[347]);
            jail_b_door_c = new ScenarioEntity<IDevice>(348, scenarioTag.WellKnownItems[348]);
            jail_b_door_d = new ScenarioEntity<IDevice>(349, scenarioTag.WellKnownItems[349]);
            jail_b_door_e = new ScenarioEntity<IDevice>(350, scenarioTag.WellKnownItems[350]);
            jail_door_h = new ScenarioEntity<IDevice>(351, scenarioTag.WellKnownItems[351]);
            jail_door_n = new ScenarioEntity<IDevice>(352, scenarioTag.WellKnownItems[352]);
            jail_door_c = new ScenarioEntity<IDevice>(353, scenarioTag.WellKnownItems[353]);
            jail_door_d = new ScenarioEntity<IDevice>(354, scenarioTag.WellKnownItems[354]);
            jail_door_e = new ScenarioEntity<IDevice>(355, scenarioTag.WellKnownItems[355]);
            jail_door_f = new ScenarioEntity<IDevice>(356, scenarioTag.WellKnownItems[356]);
            jail_door_g = new ScenarioEntity<IDevice>(357, scenarioTag.WellKnownItems[357]);
            jail_door_i = new ScenarioEntity<IDevice>(358, scenarioTag.WellKnownItems[358]);
            jail_door_j = new ScenarioEntity<IDevice>(359, scenarioTag.WellKnownItems[359]);
            jail_door_k = new ScenarioEntity<IDevice>(360, scenarioTag.WellKnownItems[360]);
            jail_door_l = new ScenarioEntity<IDevice>(361, scenarioTag.WellKnownItems[361]);
            jail_door_m = new ScenarioEntity<IDevice>(362, scenarioTag.WellKnownItems[362]);
            room_a_lift = new ScenarioEntity<IDevice>(363, scenarioTag.WellKnownItems[363]);
            hall_a_jackal_door = new ScenarioEntity<IDevice>(364, scenarioTag.WellKnownItems[364]);
            hall_b_jackal_door = new ScenarioEntity<IDevice>(365, scenarioTag.WellKnownItems[365]);
            corr_a_mid_door = new ScenarioEntity<IDevice>(366, scenarioTag.WellKnownItems[366]);
            room_a_door1 = new ScenarioEntity<IDevice>(367, scenarioTag.WellKnownItems[367]);
            dervish_ledge_lower_door = new ScenarioEntity<IDevice>(368, scenarioTag.WellKnownItems[368]);
            grand_a_exit = new ScenarioEntity<IDevice>(369, scenarioTag.WellKnownItems[369]);
            room_b_exit = new ScenarioEntity<IDevice>(370, scenarioTag.WellKnownItems[370]);
            midtower_exit = new ScenarioEntity<IDevice>(371, scenarioTag.WellKnownItems[371]);
            grand_a_ent_door = new ScenarioEntity<IDevice>(372, scenarioTag.WellKnownItems[372]);
            grand_b_exit = new ScenarioEntity<IDevice>(373, scenarioTag.WellKnownItems[373]);
            ioc = new ScenarioEntity<IDevice>(374, scenarioTag.WellKnownItems[374]);
            tram_a_effect = new ScenarioEntity<IDevice>(375, scenarioTag.WellKnownItems[375]);
            tram_a_bk_effect = new ScenarioEntity<IDevice>(376, scenarioTag.WellKnownItems[376]);
            jail_up_effect = new ScenarioEntity<IDevice>(377, scenarioTag.WellKnownItems[377]);
            room_a_lift_effect = new ScenarioEntity<IDevice>(378, scenarioTag.WellKnownItems[378]);
            room_b_lift_effect = new ScenarioEntity<IDevice>(379, scenarioTag.WellKnownItems[379]);
            garden_tram_c_effect = new ScenarioEntity<IDevice>(380, scenarioTag.WellKnownItems[380]);
            garden_tram_c_bk_effect = new ScenarioEntity<IDevice>(381, scenarioTag.WellKnownItems[381]);
            garden_tram_d_effect = new ScenarioEntity<IDevice>(382, scenarioTag.WellKnownItems[382]);
            garden_tram_d_bk_effect = new ScenarioEntity<IDevice>(383, scenarioTag.WellKnownItems[383]);
            tram_b_effect = new ScenarioEntity<IDevice>(384, scenarioTag.WellKnownItems[384]);
            tram_b_bk_effect = new ScenarioEntity<IDevice>(385, scenarioTag.WellKnownItems[385]);
            midtower_ent_door = new ScenarioEntity<IDevice>(386, scenarioTag.WellKnownItems[386]);
            maus_bsp_4_door = new ScenarioEntity<IDevice>(387, scenarioTag.WellKnownItems[387]);
            sarcophagus = new ScenarioEntity<IDevice>(388, scenarioTag.WellKnownItems[388]);
            grand_b_door1 = new ScenarioEntity<IDevice>(389, scenarioTag.WellKnownItems[389]);
            maus_ent_door_a = new ScenarioEntity<IDevice>(390, scenarioTag.WellKnownItems[390]);
            maus_ent_door_b = new ScenarioEntity<IDevice>(391, scenarioTag.WellKnownItems[391]);
            ice_cream_effect = new ScenarioEntity<IDevice>(392, scenarioTag.WellKnownItems[392]);
            c07_infection_old = new Squad_c07_infection_old(scenarioTag);
            empty = new Squad_empty(scenarioTag);
            cortana_01 = new Squad_cortana_01(scenarioTag);
            cortana_11 = new Squad_cortana_11(scenarioTag);
            cortana_grand_b = new Squad_cortana_grand_b(scenarioTag);
            cortana_corridor_a = new Squad_cortana_corridor_a(scenarioTag);
            cortana_room_a = new Squad_cortana_room_a(scenarioTag);
            cortana_room_b = new Squad_cortana_room_b(scenarioTag);
            cortana_corridor_b = new Squad_cortana_corridor_b(scenarioTag);
            cortana_jail1 = new Squad_cortana_jail1(scenarioTag);
            cortana_3a1 = new Squad_cortana_3a1(scenarioTag);
            cortana_3b1 = new Squad_cortana_3b1(scenarioTag);
            cortana_41 = new Squad_cortana_41(scenarioTag);
            cortana_maus_room = new Squad_cortana_maus_room(scenarioTag);
            cortana_maus_bridge = new Squad_cortana_maus_bridge(scenarioTag);
            cortana_maus = new Squad_cortana_maus(scenarioTag);
            marines_bsp2 = new Squad_marines_bsp2(scenarioTag);
            marines_bsp3 = new Squad_marines_bsp3(scenarioTag);
            _______COUNCIL_CHAMBER_______ = new Squad________COUNCIL_CHAMBER_______(scenarioTag);
            council_brute_ini1 = new Squad_council_brute_ini1(scenarioTag);
            council_grunt_ini = new Squad_council_grunt_ini(scenarioTag);
            council_brute_ped = new Squad_council_brute_ped(scenarioTag);
            council_rt_grunt_a = new Squad_council_rt_grunt_a(scenarioTag);
            council_rt_grunt_b = new Squad_council_rt_grunt_b(scenarioTag);
            council_rt_grunt_c = new Squad_council_rt_grunt_c(scenarioTag);
            council_lt_grunt_a = new Squad_council_lt_grunt_a(scenarioTag);
            council_lt_grunt_b = new Squad_council_lt_grunt_b(scenarioTag);
            council_lt_grunt_c = new Squad_council_lt_grunt_c(scenarioTag);
            council_rt_brute_a = new Squad_council_rt_brute_a(scenarioTag);
            council_rt_brute_b = new Squad_council_rt_brute_b(scenarioTag);
            council_rt_brute_c = new Squad_council_rt_brute_c(scenarioTag);
            council_lt_brute_a = new Squad_council_lt_brute_a(scenarioTag);
            council_lt_brute_b = new Squad_council_lt_brute_b(scenarioTag);
            council_lt_brute_c = new Squad_council_lt_brute_c(scenarioTag);
            council_rt_upper_brute_a = new Squad_council_rt_upper_brute_a(scenarioTag);
            council_rt_upper_brute_b = new Squad_council_rt_upper_brute_b(scenarioTag);
            council_rt_upper_brute_c = new Squad_council_rt_upper_brute_c(scenarioTag);
            council_lt_upper_brute_a = new Squad_council_lt_upper_brute_a(scenarioTag);
            council_lt_upper_brute_b = new Squad_council_lt_upper_brute_b(scenarioTag);
            council_lt_upper_brute_c = new Squad_council_lt_upper_brute_c(scenarioTag);
            grand_a_brutes = new Squad_grand_a_brutes(scenarioTag);
            grand_a_grunts = new Squad_grand_a_grunts(scenarioTag);
            grand_a_turret1 = new Squad_grand_a_turret1(scenarioTag);
            ledge_brutes_honor_ini1 = new Squad_ledge_brutes_honor_ini1(scenarioTag);
            ledge_brutes_ini1 = new Squad_ledge_brutes_ini1(scenarioTag);
            ledge_jackal_left = new Squad_ledge_jackal_left(scenarioTag);
            ledge_jackal_right = new Squad_ledge_jackal_right(scenarioTag);
            ledge_lift_brute_rt = new Squad_ledge_lift_brute_rt(scenarioTag);
            ledge_lift_brute_lt = new Squad_ledge_lift_brute_lt(scenarioTag);
            ledge_lift_chieftan = new Squad_ledge_lift_chieftan(scenarioTag);
            ledge_lift_grunt_rt = new Squad_ledge_lift_grunt_rt(scenarioTag);
            ledge_lift_grunt_lt = new Squad_ledge_lift_grunt_lt(scenarioTag);
            ledge_bot_grunts1 = new Squad_ledge_bot_grunts1(scenarioTag);
            ledge_bot_jackals1 = new Squad_ledge_bot_jackals1(scenarioTag);
            _______CORIDORS_A_______ = new Squad________CORIDORS_A_______(scenarioTag);
            hall_a_jackal_patrol_ini = new Squad_hall_a_jackal_patrol_ini(scenarioTag);
            hall_a_brute_ini1 = new Squad_hall_a_brute_ini1(scenarioTag);
            hall_a_jackal_ini2 = new Squad_hall_a_jackal_ini2(scenarioTag);
            hall_a_brute_rein = new Squad_hall_a_brute_rein(scenarioTag);
            hall_a_brute_rein_bk1 = new Squad_hall_a_brute_rein_bk1(scenarioTag);
            hall_a_grunt_rein = new Squad_hall_a_grunt_rein(scenarioTag);
            hall_a_grunt_rein_bk1 = new Squad_hall_a_grunt_rein_bk1(scenarioTag);
            hall_b_brutes1 = new Squad_hall_b_brutes1(scenarioTag);
            hall_b_grunts1 = new Squad_hall_b_grunts1(scenarioTag);
            hall_b_grunts_bk1 = new Squad_hall_b_grunts_bk1(scenarioTag);
            hall_b_jackals = new Squad_hall_b_jackals(scenarioTag);
            room_a_brutes_ini1 = new Squad_room_a_brutes_ini1(scenarioTag);
            room_a_jackals_ini = new Squad_room_a_jackals_ini(scenarioTag);
            room_a_brutes_bk1 = new Squad_room_a_brutes_bk1(scenarioTag);
            room_a_brutes_a = new Squad_room_a_brutes_a(scenarioTag);
            room_a_brutes_b = new Squad_room_a_brutes_b(scenarioTag);
            room_a_brutes_c = new Squad_room_a_brutes_c(scenarioTag);
            room_a_grunts_a = new Squad_room_a_grunts_a(scenarioTag);
            room_a_grunts_b = new Squad_room_a_grunts_b(scenarioTag);
            room_a_grunts_c = new Squad_room_a_grunts_c(scenarioTag);
            room_a_tube_fodder = new Squad_room_a_tube_fodder(scenarioTag);
            _________JAIL_________ = new Squad__________JAIL_________(scenarioTag);
            jail_trash = new Squad_jail_trash(scenarioTag);
            jail_brutes_ini1 = new Squad_jail_brutes_ini1(scenarioTag);
            jail_grunts_ini1 = new Squad_jail_grunts_ini1(scenarioTag);
            jail_jackals_ini1 = new Squad_jail_jackals_ini1(scenarioTag);
            jail_brutes_down = new Squad_jail_brutes_down(scenarioTag);
            jail_grunts_down = new Squad_jail_grunts_down(scenarioTag);
            jail_jackals_down = new Squad_jail_jackals_down(scenarioTag);
            jail_a_marines = new Squad_jail_a_marines(scenarioTag);
            jail_a_brute1 = new Squad_jail_a_brute1(scenarioTag);
            jail_a_jackals1 = new Squad_jail_a_jackals1(scenarioTag);
            jail_b_marines = new Squad_jail_b_marines(scenarioTag);
            jail_b_brutes = new Squad_jail_b_brutes(scenarioTag);
            jail_b_grunts1 = new Squad_jail_b_grunts1(scenarioTag);
            jail_guard_brute_cell_a = new Squad_jail_guard_brute_cell_a(scenarioTag);
            jail_guard_jackal_cell_a = new Squad_jail_guard_jackal_cell_a(scenarioTag);
            jail_guard_brute_cell_b = new Squad_jail_guard_brute_cell_b(scenarioTag);
            jail_guard_jackal_cell_b = new Squad_jail_guard_jackal_cell_b(scenarioTag);
            jail_brute_c = new Squad_jail_brute_c(scenarioTag);
            jail_brute_d = new Squad_jail_brute_d(scenarioTag);
            jail_brute_e = new Squad_jail_brute_e(scenarioTag);
            jail_brute_f = new Squad_jail_brute_f(scenarioTag);
            jail_brute_g = new Squad_jail_brute_g(scenarioTag);
            jail_brute_i = new Squad_jail_brute_i(scenarioTag);
            jail_brute_j = new Squad_jail_brute_j(scenarioTag);
            jail_brute_k = new Squad_jail_brute_k(scenarioTag);
            jail_brute_l = new Squad_jail_brute_l(scenarioTag);
            jail_brute_m = new Squad_jail_brute_m(scenarioTag);
            jail_grunt_c = new Squad_jail_grunt_c(scenarioTag);
            jail_grunt_d = new Squad_jail_grunt_d(scenarioTag);
            jail_grunt_e = new Squad_jail_grunt_e(scenarioTag);
            jail_grunt_f = new Squad_jail_grunt_f(scenarioTag);
            jail_grunt_g = new Squad_jail_grunt_g(scenarioTag);
            jail_grunt_i = new Squad_jail_grunt_i(scenarioTag);
            jail_grunt_j = new Squad_jail_grunt_j(scenarioTag);
            jail_grunt_k = new Squad_jail_grunt_k(scenarioTag);
            jail_grunt_l = new Squad_jail_grunt_l(scenarioTag);
            jail_grunt_m = new Squad_jail_grunt_m(scenarioTag);
            jail_jackal_c = new Squad_jail_jackal_c(scenarioTag);
            jail_jackal_d = new Squad_jail_jackal_d(scenarioTag);
            jail_jackal_e = new Squad_jail_jackal_e(scenarioTag);
            jail_jackal_f = new Squad_jail_jackal_f(scenarioTag);
            jail_jackal_g = new Squad_jail_jackal_g(scenarioTag);
            jail_jackal_i = new Squad_jail_jackal_i(scenarioTag);
            jail_jackal_j = new Squad_jail_jackal_j(scenarioTag);
            jail_jackal_k = new Squad_jail_jackal_k(scenarioTag);
            jail_jackal_l = new Squad_jail_jackal_l(scenarioTag);
            jail_jackal_m = new Squad_jail_jackal_m(scenarioTag);
            _______CORRIDORS_B_______ = new Squad________CORRIDORS_B_______(scenarioTag);
            room_b_marines1 = new Squad_room_b_marines1(scenarioTag);
            room_b_brutes_ini1 = new Squad_room_b_brutes_ini1(scenarioTag);
            room_b_elites1 = new Squad_room_b_elites1(scenarioTag);
            room_b_buggers1 = new Squad_room_b_buggers1(scenarioTag);
            hall_c_elites1 = new Squad_hall_c_elites1(scenarioTag);
            hall_c_buggers1 = new Squad_hall_c_buggers1(scenarioTag);
            hall_c_brute_reins = new Squad_hall_c_brute_reins(scenarioTag);
            hall_c_bugger_reins = new Squad_hall_c_bugger_reins(scenarioTag);
            hall_d_elites1 = new Squad_hall_d_elites1(scenarioTag);
            hall_d_brutes1 = new Squad_hall_d_brutes1(scenarioTag);
            hall_d_jackals_fr1 = new Squad_hall_d_jackals_fr1(scenarioTag);
            hall_d_jackals_bk1 = new Squad_hall_d_jackals_bk1(scenarioTag);
            grand_b_hunter_a1 = new Squad_grand_b_hunter_a1(scenarioTag);
            grand_b_hunter_b1 = new Squad_grand_b_hunter_b1(scenarioTag);
            _______EXT_A_______ = new Squad________EXT_A_______(scenarioTag);
            ext_a_jackal_snipers_a1 = new Squad_ext_a_jackal_snipers_a1(scenarioTag);
            ext_a_jackal_snipers_b1 = new Squad_ext_a_jackal_snipers_b1(scenarioTag);
            ext_a_jackal_snipers_c1 = new Squad_ext_a_jackal_snipers_c1(scenarioTag);
            ext_a_jackal_snipers_d1 = new Squad_ext_a_jackal_snipers_d1(scenarioTag);
            ext_a_watch_brutes1 = new Squad_ext_a_watch_brutes1(scenarioTag);
            ext_a_watch_elites = new Squad_ext_a_watch_elites(scenarioTag);
            ext_a_hunters = new Squad_ext_a_hunters(scenarioTag);
            ext_a_brute_door1 = new Squad_ext_a_brute_door1(scenarioTag);
            ext_a_elite_ini1 = new Squad_ext_a_elite_ini1(scenarioTag);
            ext_a_brute_ini1 = new Squad_ext_a_brute_ini1(scenarioTag);
            ext_a_rangers1 = new Squad_ext_a_rangers1(scenarioTag);
            ext_a_buggers1 = new Squad_ext_a_buggers1(scenarioTag);
            ext_a_brute_bk_door1 = new Squad_ext_a_brute_bk_door1(scenarioTag);
            ext_a_buggers_bk1 = new Squad_ext_a_buggers_bk1(scenarioTag);
            ext_a_brutes_bk1 = new Squad_ext_a_brutes_bk1(scenarioTag);
            _______GARDEN_A_______ = new Squad________GARDEN_A_______(scenarioTag);
            garden_a_elites = new Squad_garden_a_elites(scenarioTag);
            garden_a_grunts = new Squad_garden_a_grunts(scenarioTag);
            garden_a_brute_lt1 = new Squad_garden_a_brute_lt1(scenarioTag);
            garden_a_brute_rt1 = new Squad_garden_a_brute_rt1(scenarioTag);
            garden_a_jackal_snipers1 = new Squad_garden_a_jackal_snipers1(scenarioTag);
            garden_a_buggers = new Squad_garden_a_buggers(scenarioTag);
            garden_a_brute_a1 = new Squad_garden_a_brute_a1(scenarioTag);
            garden_a_brute_b1 = new Squad_garden_a_brute_b1(scenarioTag);
            garden_a_brute_c1 = new Squad_garden_a_brute_c1(scenarioTag);
            garden_a_elite_a1 = new Squad_garden_a_elite_a1(scenarioTag);
            garden_a_elite_b1 = new Squad_garden_a_elite_b1(scenarioTag);
            garden_a_elite_c1 = new Squad_garden_a_elite_c1(scenarioTag);
            garden_a_rangers = new Squad_garden_a_rangers(scenarioTag);
            garden_a_elites_bk1 = new Squad_garden_a_elites_bk1(scenarioTag);
            garden_a_grunts_bk = new Squad_garden_a_grunts_bk(scenarioTag);
            garden_a_jackals_bk = new Squad_garden_a_jackals_bk(scenarioTag);
            garden_a_brutes_bk = new Squad_garden_a_brutes_bk(scenarioTag);
            _______MID_TOWER_______ = new Squad________MID_TOWER_______(scenarioTag);
            midtower_turrets = new Squad_midtower_turrets(scenarioTag);
            midtower_elites1 = new Squad_midtower_elites1(scenarioTag);
            midtower_elite_reins = new Squad_midtower_elite_reins(scenarioTag);
            mid_tower_hunters = new Squad_mid_tower_hunters(scenarioTag);
            midtower_buggers_ini = new Squad_midtower_buggers_ini(scenarioTag);
            midtower_bugger_rein = new Squad_midtower_bugger_rein(scenarioTag);
            midtower_brutes1 = new Squad_midtower_brutes1(scenarioTag);
            midtower_jackals1 = new Squad_midtower_jackals1(scenarioTag);
            midtower_buggers_hall = new Squad_midtower_buggers_hall(scenarioTag);
            _______GARDEN_B_______ = new Squad________GARDEN_B_______(scenarioTag);
            garden_b_grunt_a = new Squad_garden_b_grunt_a(scenarioTag);
            garden_b_grunt_b = new Squad_garden_b_grunt_b(scenarioTag);
            garden_b_grunt_c = new Squad_garden_b_grunt_c(scenarioTag);
            garden_b_brute_ini = new Squad_garden_b_brute_ini(scenarioTag);
            _______EXT_B_______ = new Squad________EXT_B_______(scenarioTag);
            ext_b_brute_ramp1 = new Squad_ext_b_brute_ramp1(scenarioTag);
            ext_b_elite_a1 = new Squad_ext_b_elite_a1(scenarioTag);
            ext_b_brute_a1 = new Squad_ext_b_brute_a1(scenarioTag);
            ext_b_grunts_b1 = new Squad_ext_b_grunts_b1(scenarioTag);
            ext_b_brutes_b1 = new Squad_ext_b_brutes_b1(scenarioTag);
            ext_b_grunts_low1 = new Squad_ext_b_grunts_low1(scenarioTag);
            ext_b_brutes_low1 = new Squad_ext_b_brutes_low1(scenarioTag);
            ext_b_jackal_a1 = new Squad_ext_b_jackal_a1(scenarioTag);
            ext_b_grunt_bk_door1 = new Squad_ext_b_grunt_bk_door1(scenarioTag);
            ext_b_elites_bk_door1 = new Squad_ext_b_elites_bk_door1(scenarioTag);
            ext_b_elites_stealth = new Squad_ext_b_elites_stealth(scenarioTag);
            ext_b_grunts_lt1 = new Squad_ext_b_grunts_lt1(scenarioTag);
            ext_b_brutes_low_door1 = new Squad_ext_b_brutes_low_door1(scenarioTag);
            ext_b_jackal_b = new Squad_ext_b_jackal_b(scenarioTag);
            ext_b_jackal_c = new Squad_ext_b_jackal_c(scenarioTag);
            ext_b_cov_dump1 = new Squad_ext_b_cov_dump1(scenarioTag);
            ext_b_prophet_dump1 = new Squad_ext_b_prophet_dump1(scenarioTag);
            _______MAUSOLEUM_______ = new Squad________MAUSOLEUM_______(scenarioTag);
            maus_hall_elites_stealth1 = new Squad_maus_hall_elites_stealth1(scenarioTag);
            maus_hall_grunts1 = new Squad_maus_hall_grunts1(scenarioTag);
            maus_room_elite_lt1 = new Squad_maus_room_elite_lt1(scenarioTag);
            maus_room_elite_rt1 = new Squad_maus_room_elite_rt1(scenarioTag);
            maus_room_grunt_lt1 = new Squad_maus_room_grunt_lt1(scenarioTag);
            maus_room_grunt_rt1 = new Squad_maus_room_grunt_rt1(scenarioTag);
            maus_room_brute_bk1 = new Squad_maus_room_brute_bk1(scenarioTag);
            maus_room_jackal_bk_lt1 = new Squad_maus_room_jackal_bk_lt1(scenarioTag);
            maus_room_jackal_bk_rt1 = new Squad_maus_room_jackal_bk_rt1(scenarioTag);
            maus_room_lt_elite_reins = new Squad_maus_room_lt_elite_reins(scenarioTag);
            maus_room_rt_elite_reins = new Squad_maus_room_rt_elite_reins(scenarioTag);
            maus_room_lt_grunt_reins = new Squad_maus_room_lt_grunt_reins(scenarioTag);
            maus_room_rt_grunt_reins = new Squad_maus_room_rt_grunt_reins(scenarioTag);
            maus_bridge_elite_turret = new Squad_maus_bridge_elite_turret(scenarioTag);
            maus_bridge_elites_ini1 = new Squad_maus_bridge_elites_ini1(scenarioTag);
            maus_bridge_elite_rein = new Squad_maus_bridge_elite_rein(scenarioTag);
            maus_bridge_grunt_rein = new Squad_maus_bridge_grunt_rein(scenarioTag);
            maus_bridge_grunt_rein_b1 = new Squad_maus_bridge_grunt_rein_b1(scenarioTag);
            maus_bridge_hunters1 = new Squad_maus_bridge_hunters1(scenarioTag);
            maus_bridge_buggers_ini1 = new Squad_maus_bridge_buggers_ini1(scenarioTag);
            maus_bridge_brutes_ini = new Squad_maus_bridge_brutes_ini(scenarioTag);
            maus_bridge_jackals_ini = new Squad_maus_bridge_jackals_ini(scenarioTag);
            maus_inner_hunters_ini = new Squad_maus_inner_hunters_ini(scenarioTag);
            maus_inner_elites_ini1 = new Squad_maus_inner_elites_ini1(scenarioTag);
            maus_inner_grunts_ini = new Squad_maus_inner_grunts_ini(scenarioTag);
            maus_inner_turrets = new Squad_maus_inner_turrets(scenarioTag);
            maus_inner_brutes_ini1 = new Squad_maus_inner_brutes_ini1(scenarioTag);
            maus_inner_brutes_rein = new Squad_maus_inner_brutes_rein(scenarioTag);
            maus_inner_buggers_lt = new Squad_maus_inner_buggers_lt(scenarioTag);
            maus_inner_buggers_rt = new Squad_maus_inner_buggers_rt(scenarioTag);
            maus_inner_brutes_a = new Squad_maus_inner_brutes_a(scenarioTag);
            maus_inner_brutes_b = new Squad_maus_inner_brutes_b(scenarioTag);
            maus_inner_brutes_c = new Squad_maus_inner_brutes_c(scenarioTag);
            maus_inner_brutes_d = new Squad_maus_inner_brutes_d(scenarioTag);
            maus_inner_brutes_e = new Squad_maus_inner_brutes_e(scenarioTag);
            maus_inner_brutes_f = new Squad_maus_inner_brutes_f(scenarioTag);
            maus_inner_elites_d = new Squad_maus_inner_elites_d(scenarioTag);
            maus_inner_elites_e = new Squad_maus_inner_elites_e(scenarioTag);
            maus_inner_elites_f = new Squad_maus_inner_elites_f(scenarioTag);
            maus_inner_elites_ultra = new Squad_maus_inner_elites_ultra(scenarioTag);
            maus_inner_elites_spec = new Squad_maus_inner_elites_spec(scenarioTag);
            maus_inner_elite_zealot = new Squad_maus_inner_elite_zealot(scenarioTag);
            squads_244 = new Squad_squads_244(scenarioTag);
            ice_cream_grunt1 = new Squad_ice_cream_grunt1(scenarioTag);
            c07_infection = new Squad_c07_infection(scenarioTag);
        }
    }
}