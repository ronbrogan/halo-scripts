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
        public ICameraPathTarget test1 => Scenario.CameraPathTargets[0].GameObject;
        public Squad_c07_infection_old c07_infection_old { get; set; }
        public Squad_empty empty { get; set; }
        public Squad_cortana_0 cortana_0 { get; set; }
        public Squad_cortana_1 cortana_1 { get; set; }
        public Squad_cortana_grand_b cortana_grand_b { get; set; }
        public Squad_cortana_corridor_a cortana_corridor_a { get; set; }
        public Squad_cortana_room_a cortana_room_a { get; set; }
        public Squad_cortana_room_b cortana_room_b { get; set; }
        public Squad_cortana_corridor_b cortana_corridor_b { get; set; }
        public Squad_cortana_jail cortana_jail { get; set; }
        public Squad_cortana_3a cortana_3a { get; set; }
        public Squad_cortana_3b cortana_3b { get; set; }
        public Squad_cortana_4 cortana_4 { get; set; }
        public Squad_cortana_maus_room cortana_maus_room { get; set; }
        public Squad_cortana_maus_bridge cortana_maus_bridge { get; set; }
        public Squad_cortana_maus cortana_maus { get; set; }
        public Squad_marines_bsp2 marines_bsp2 { get; set; }
        public Squad_marines_bsp3 marines_bsp3 { get; set; }
        public Squad________COUNCIL_CHAMBER_______ _______COUNCIL_CHAMBER_______ { get; set; }
        public Squad_council_brute_ini council_brute_ini { get; set; }
        public Squad_council_grunt_ini council_grunt_ini { get; set; }
        public Squad_council_brute_ped council_brute_ped { get; set; }
        public Squad_council_rt_grunt_a council_rt_grunt_a { get; set; }
        public Squad_council_rt_grunt_b council_rt_grunt_b { get; set; }
        public Squad_council_rt_grunt_c council_rt_grunt_c { get; set; }
        public Squad_council_lt_grunt_a council_lt_grunt_a { get; set; }
        public Squad_council_lt_grunt_b council_lt_grunt_b { get; set; }
        public Squad_council_lt_grunt_c council_lt_grunt_c { get; set; }
        public Squad_council_rt_brute_a council_rt_brute_a { get; set; }
        public Squad_council_rt_brute_b council_rt_brute_b { get; set; }
        public Squad_council_rt_brute_c council_rt_brute_c { get; set; }
        public Squad_council_lt_brute_a council_lt_brute_a { get; set; }
        public Squad_council_lt_brute_b council_lt_brute_b { get; set; }
        public Squad_council_lt_brute_c council_lt_brute_c { get; set; }
        public Squad_council_rt_upper_brute_a council_rt_upper_brute_a { get; set; }
        public Squad_council_rt_upper_brute_b council_rt_upper_brute_b { get; set; }
        public Squad_council_rt_upper_brute_c council_rt_upper_brute_c { get; set; }
        public Squad_council_lt_upper_brute_a council_lt_upper_brute_a { get; set; }
        public Squad_council_lt_upper_brute_b council_lt_upper_brute_b { get; set; }
        public Squad_council_lt_upper_brute_c council_lt_upper_brute_c { get; set; }
        public Squad_grand_a_brutes grand_a_brutes { get; set; }
        public Squad_grand_a_grunts grand_a_grunts { get; set; }
        public Squad_grand_a_turret grand_a_turret { get; set; }
        public Squad_ledge_brutes_honor_ini ledge_brutes_honor_ini { get; set; }
        public Squad_ledge_brutes_ini ledge_brutes_ini { get; set; }
        public Squad_ledge_jackal_left ledge_jackal_left { get; set; }
        public Squad_ledge_jackal_right ledge_jackal_right { get; set; }
        public Squad_ledge_lift_brute_rt ledge_lift_brute_rt { get; set; }
        public Squad_ledge_lift_brute_lt ledge_lift_brute_lt { get; set; }
        public Squad_ledge_lift_chieftan ledge_lift_chieftan { get; set; }
        public Squad_ledge_lift_grunt_rt ledge_lift_grunt_rt { get; set; }
        public Squad_ledge_lift_grunt_lt ledge_lift_grunt_lt { get; set; }
        public Squad_ledge_bot_grunts ledge_bot_grunts { get; set; }
        public Squad_ledge_bot_jackals ledge_bot_jackals { get; set; }
        public Squad________CORIDORS_A_______ _______CORIDORS_A_______ { get; set; }
        public Squad_hall_a_jackal_patrol_ini hall_a_jackal_patrol_ini { get; set; }
        public Squad_hall_a_brute_ini hall_a_brute_ini { get; set; }
        public Squad_hall_a_jackal_ini hall_a_jackal_ini { get; set; }
        public Squad_hall_a_brute_rein hall_a_brute_rein { get; set; }
        public Squad_hall_a_brute_rein_bk hall_a_brute_rein_bk { get; set; }
        public Squad_hall_a_grunt_rein hall_a_grunt_rein { get; set; }
        public Squad_hall_a_grunt_rein_bk hall_a_grunt_rein_bk { get; set; }
        public Squad_hall_b_brutes hall_b_brutes { get; set; }
        public Squad_hall_b_grunts hall_b_grunts { get; set; }
        public Squad_hall_b_grunts_bk hall_b_grunts_bk { get; set; }
        public Squad_hall_b_jackals hall_b_jackals { get; set; }
        public Squad_room_a_brutes_ini room_a_brutes_ini { get; set; }
        public Squad_room_a_jackals_ini room_a_jackals_ini { get; set; }
        public Squad_room_a_brutes_bk room_a_brutes_bk { get; set; }
        public Squad_room_a_brutes_a room_a_brutes_a { get; set; }
        public Squad_room_a_brutes_b room_a_brutes_b { get; set; }
        public Squad_room_a_brutes_c room_a_brutes_c { get; set; }
        public Squad_room_a_grunts_a room_a_grunts_a { get; set; }
        public Squad_room_a_grunts_b room_a_grunts_b { get; set; }
        public Squad_room_a_grunts_c room_a_grunts_c { get; set; }
        public Squad_room_a_tube_fodder room_a_tube_fodder { get; set; }
        public Squad__________JAIL_________ _________JAIL_________ { get; set; }
        public Squad_jail_trash jail_trash { get; set; }
        public Squad_jail_brutes_ini jail_brutes_ini { get; set; }
        public Squad_jail_grunts_ini jail_grunts_ini { get; set; }
        public Squad_jail_jackals_ini jail_jackals_ini { get; set; }
        public Squad_jail_brutes_down jail_brutes_down { get; set; }
        public Squad_jail_grunts_down jail_grunts_down { get; set; }
        public Squad_jail_jackals_down jail_jackals_down { get; set; }
        public Squad_jail_a_marines jail_a_marines { get; set; }
        public Squad_jail_a_brute jail_a_brute { get; set; }
        public Squad_jail_a_jackals jail_a_jackals { get; set; }
        public Squad_jail_b_marines jail_b_marines { get; set; }
        public Squad_jail_b_brutes jail_b_brutes { get; set; }
        public Squad_jail_b_grunts jail_b_grunts { get; set; }
        public Squad_jail_guard_brute_cell_a jail_guard_brute_cell_a { get; set; }
        public Squad_jail_guard_jackal_cell_a jail_guard_jackal_cell_a { get; set; }
        public Squad_jail_guard_brute_cell_b jail_guard_brute_cell_b { get; set; }
        public Squad_jail_guard_jackal_cell_b jail_guard_jackal_cell_b { get; set; }
        public Squad_jail_brute_c jail_brute_c { get; set; }
        public Squad_jail_brute_d jail_brute_d { get; set; }
        public Squad_jail_brute_e jail_brute_e { get; set; }
        public Squad_jail_brute_f jail_brute_f { get; set; }
        public Squad_jail_brute_g jail_brute_g { get; set; }
        public Squad_jail_brute_i jail_brute_i { get; set; }
        public Squad_jail_brute_j jail_brute_j { get; set; }
        public Squad_jail_brute_k jail_brute_k { get; set; }
        public Squad_jail_brute_l jail_brute_l { get; set; }
        public Squad_jail_brute_m jail_brute_m { get; set; }
        public Squad_jail_grunt_c jail_grunt_c { get; set; }
        public Squad_jail_grunt_d jail_grunt_d { get; set; }
        public Squad_jail_grunt_e jail_grunt_e { get; set; }
        public Squad_jail_grunt_f jail_grunt_f { get; set; }
        public Squad_jail_grunt_g jail_grunt_g { get; set; }
        public Squad_jail_grunt_i jail_grunt_i { get; set; }
        public Squad_jail_grunt_j jail_grunt_j { get; set; }
        public Squad_jail_grunt_k jail_grunt_k { get; set; }
        public Squad_jail_grunt_l jail_grunt_l { get; set; }
        public Squad_jail_grunt_m jail_grunt_m { get; set; }
        public Squad_jail_jackal_c jail_jackal_c { get; set; }
        public Squad_jail_jackal_d jail_jackal_d { get; set; }
        public Squad_jail_jackal_e jail_jackal_e { get; set; }
        public Squad_jail_jackal_f jail_jackal_f { get; set; }
        public Squad_jail_jackal_g jail_jackal_g { get; set; }
        public Squad_jail_jackal_i jail_jackal_i { get; set; }
        public Squad_jail_jackal_j jail_jackal_j { get; set; }
        public Squad_jail_jackal_k jail_jackal_k { get; set; }
        public Squad_jail_jackal_l jail_jackal_l { get; set; }
        public Squad_jail_jackal_m jail_jackal_m { get; set; }
        public Squad________CORRIDORS_B_______ _______CORRIDORS_B_______ { get; set; }
        public Squad_room_b_marines room_b_marines { get; set; }
        public Squad_room_b_brutes_ini room_b_brutes_ini { get; set; }
        public Squad_room_b_elites room_b_elites { get; set; }
        public Squad_room_b_buggers room_b_buggers { get; set; }
        public Squad_hall_c_elites hall_c_elites { get; set; }
        public Squad_hall_c_buggers hall_c_buggers { get; set; }
        public Squad_hall_c_brute_reins hall_c_brute_reins { get; set; }
        public Squad_hall_c_bugger_reins hall_c_bugger_reins { get; set; }
        public Squad_hall_d_elites hall_d_elites { get; set; }
        public Squad_hall_d_brutes hall_d_brutes { get; set; }
        public Squad_hall_d_jackals_fr hall_d_jackals_fr { get; set; }
        public Squad_hall_d_jackals_bk hall_d_jackals_bk { get; set; }
        public Squad_grand_b_hunter_a grand_b_hunter_a { get; set; }
        public Squad_grand_b_hunter_b grand_b_hunter_b { get; set; }
        public Squad________EXT_A_______ _______EXT_A_______ { get; set; }
        public Squad_ext_a_jackal_snipers_a ext_a_jackal_snipers_a { get; set; }
        public Squad_ext_a_jackal_snipers_b ext_a_jackal_snipers_b { get; set; }
        public Squad_ext_a_jackal_snipers_c ext_a_jackal_snipers_c { get; set; }
        public Squad_ext_a_jackal_snipers_d ext_a_jackal_snipers_d { get; set; }
        public Squad_ext_a_watch_brutes ext_a_watch_brutes { get; set; }
        public Squad_ext_a_watch_elites ext_a_watch_elites { get; set; }
        public Squad_ext_a_hunters ext_a_hunters { get; set; }
        public Squad_ext_a_brute_door ext_a_brute_door { get; set; }
        public Squad_ext_a_elite_ini ext_a_elite_ini { get; set; }
        public Squad_ext_a_brute_ini ext_a_brute_ini { get; set; }
        public Squad_ext_a_rangers ext_a_rangers { get; set; }
        public Squad_ext_a_buggers ext_a_buggers { get; set; }
        public Squad_ext_a_brute_bk_door ext_a_brute_bk_door { get; set; }
        public Squad_ext_a_buggers_bk ext_a_buggers_bk { get; set; }
        public Squad_ext_a_brutes_bk ext_a_brutes_bk { get; set; }
        public Squad________GARDEN_A_______ _______GARDEN_A_______ { get; set; }
        public Squad_garden_a_elites garden_a_elites { get; set; }
        public Squad_garden_a_grunts garden_a_grunts { get; set; }
        public Squad_garden_a_brute_lt garden_a_brute_lt { get; set; }
        public Squad_garden_a_brute_rt garden_a_brute_rt { get; set; }
        public Squad_garden_a_jackal_snipers garden_a_jackal_snipers { get; set; }
        public Squad_garden_a_buggers garden_a_buggers { get; set; }
        public Squad_garden_a_brute_a garden_a_brute_a { get; set; }
        public Squad_garden_a_brute_b garden_a_brute_b { get; set; }
        public Squad_garden_a_brute_c garden_a_brute_c { get; set; }
        public Squad_garden_a_elite_a garden_a_elite_a { get; set; }
        public Squad_garden_a_elite_b garden_a_elite_b { get; set; }
        public Squad_garden_a_elite_c garden_a_elite_c { get; set; }
        public Squad_garden_a_rangers garden_a_rangers { get; set; }
        public Squad_garden_a_elites_bk garden_a_elites_bk { get; set; }
        public Squad_garden_a_grunts_bk garden_a_grunts_bk { get; set; }
        public Squad_garden_a_jackals_bk garden_a_jackals_bk { get; set; }
        public Squad_garden_a_brutes_bk garden_a_brutes_bk { get; set; }
        public Squad________MID_TOWER_______ _______MID_TOWER_______ { get; set; }
        public Squad_midtower_turrets midtower_turrets { get; set; }
        public Squad_midtower_elites midtower_elites { get; set; }
        public Squad_midtower_elite_reins midtower_elite_reins { get; set; }
        public Squad_mid_tower_hunters mid_tower_hunters { get; set; }
        public Squad_midtower_buggers_ini midtower_buggers_ini { get; set; }
        public Squad_midtower_bugger_rein midtower_bugger_rein { get; set; }
        public Squad_midtower_brutes midtower_brutes { get; set; }
        public Squad_midtower_jackals midtower_jackals { get; set; }
        public Squad_midtower_buggers_hall midtower_buggers_hall { get; set; }
        public Squad________GARDEN_B_______ _______GARDEN_B_______ { get; set; }
        public Squad_garden_b_grunt_a garden_b_grunt_a { get; set; }
        public Squad_garden_b_grunt_b garden_b_grunt_b { get; set; }
        public Squad_garden_b_grunt_c garden_b_grunt_c { get; set; }
        public Squad_garden_b_brute_ini garden_b_brute_ini { get; set; }
        public Squad________EXT_B_______ _______EXT_B_______ { get; set; }
        public Squad_ext_b_brute_ramp ext_b_brute_ramp { get; set; }
        public Squad_ext_b_elite_a ext_b_elite_a { get; set; }
        public Squad_ext_b_brute_a ext_b_brute_a { get; set; }
        public Squad_ext_b_grunts_b ext_b_grunts_b { get; set; }
        public Squad_ext_b_brutes_b ext_b_brutes_b { get; set; }
        public Squad_ext_b_grunts_low ext_b_grunts_low { get; set; }
        public Squad_ext_b_brutes_low ext_b_brutes_low { get; set; }
        public Squad_ext_b_jackal_a ext_b_jackal_a { get; set; }
        public Squad_ext_b_grunt_bk_door ext_b_grunt_bk_door { get; set; }
        public Squad_ext_b_elites_bk_door ext_b_elites_bk_door { get; set; }
        public Squad_ext_b_elites_stealth ext_b_elites_stealth { get; set; }
        public Squad_ext_b_grunts_lt ext_b_grunts_lt { get; set; }
        public Squad_ext_b_brutes_low_door ext_b_brutes_low_door { get; set; }
        public Squad_ext_b_jackal_b ext_b_jackal_b { get; set; }
        public Squad_ext_b_jackal_c ext_b_jackal_c { get; set; }
        public Squad_ext_b_cov_dump ext_b_cov_dump { get; set; }
        public Squad_ext_b_prophet_dump ext_b_prophet_dump { get; set; }
        public Squad________MAUSOLEUM_______ _______MAUSOLEUM_______ { get; set; }
        public Squad_maus_hall_elites_stealth maus_hall_elites_stealth { get; set; }
        public Squad_maus_hall_grunts maus_hall_grunts { get; set; }
        public Squad_maus_room_elite_lt maus_room_elite_lt { get; set; }
        public Squad_maus_room_elite_rt maus_room_elite_rt { get; set; }
        public Squad_maus_room_grunt_lt maus_room_grunt_lt { get; set; }
        public Squad_maus_room_grunt_rt maus_room_grunt_rt { get; set; }
        public Squad_maus_room_brute_bk maus_room_brute_bk { get; set; }
        public Squad_maus_room_jackal_bk_lt maus_room_jackal_bk_lt { get; set; }
        public Squad_maus_room_jackal_bk_rt maus_room_jackal_bk_rt { get; set; }
        public Squad_maus_room_lt_elite_reins maus_room_lt_elite_reins { get; set; }
        public Squad_maus_room_rt_elite_reins maus_room_rt_elite_reins { get; set; }
        public Squad_maus_room_lt_grunt_reins maus_room_lt_grunt_reins { get; set; }
        public Squad_maus_room_rt_grunt_reins maus_room_rt_grunt_reins { get; set; }
        public Squad_maus_bridge_elite_turret maus_bridge_elite_turret { get; set; }
        public Squad_maus_bridge_elites_ini maus_bridge_elites_ini { get; set; }
        public Squad_maus_bridge_elite_rein maus_bridge_elite_rein { get; set; }
        public Squad_maus_bridge_grunt_rein maus_bridge_grunt_rein { get; set; }
        public Squad_maus_bridge_grunt_rein_b maus_bridge_grunt_rein_b { get; set; }
        public Squad_maus_bridge_hunters maus_bridge_hunters { get; set; }
        public Squad_maus_bridge_buggers_ini maus_bridge_buggers_ini { get; set; }
        public Squad_maus_bridge_brutes_ini maus_bridge_brutes_ini { get; set; }
        public Squad_maus_bridge_jackals_ini maus_bridge_jackals_ini { get; set; }
        public Squad_maus_inner_hunters_ini maus_inner_hunters_ini { get; set; }
        public Squad_maus_inner_elites_ini maus_inner_elites_ini { get; set; }
        public Squad_maus_inner_grunts_ini maus_inner_grunts_ini { get; set; }
        public Squad_maus_inner_turrets maus_inner_turrets { get; set; }
        public Squad_maus_inner_brutes_ini maus_inner_brutes_ini { get; set; }
        public Squad_maus_inner_brutes_rein maus_inner_brutes_rein { get; set; }
        public Squad_maus_inner_buggers_lt maus_inner_buggers_lt { get; set; }
        public Squad_maus_inner_buggers_rt maus_inner_buggers_rt { get; set; }
        public Squad_maus_inner_brutes_a maus_inner_brutes_a { get; set; }
        public Squad_maus_inner_brutes_b maus_inner_brutes_b { get; set; }
        public Squad_maus_inner_brutes_c maus_inner_brutes_c { get; set; }
        public Squad_maus_inner_brutes_d maus_inner_brutes_d { get; set; }
        public Squad_maus_inner_brutes_e maus_inner_brutes_e { get; set; }
        public Squad_maus_inner_brutes_f maus_inner_brutes_f { get; set; }
        public Squad_maus_inner_elites_d maus_inner_elites_d { get; set; }
        public Squad_maus_inner_elites_e maus_inner_elites_e { get; set; }
        public Squad_maus_inner_elites_f maus_inner_elites_f { get; set; }
        public Squad_maus_inner_elites_ultra maus_inner_elites_ultra { get; set; }
        public Squad_maus_inner_elites_spec maus_inner_elites_spec { get; set; }
        public Squad_maus_inner_elite_zealot maus_inner_elite_zealot { get; set; }
        public Squad_squads_244 squads_244 { get; set; }
        public Squad_ice_cream_grunt ice_cream_grunt { get; set; }
        public Squad_c07_infection c07_infection { get; set; }
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
        public IAiOrders cortana_01 => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders cortana_11 => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders cortana_2 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders cortana_3a1 => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders cortana_3b1 => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders cortana_41 => Scenario.AiOrderDefinitions[15].GameObject;
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
        public IAiOrders council_brute_ini1 => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders council_floor_all => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders dervish_grand_hall_brutes => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders dervish_grand_hall_grunts => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders ledge_brutes_honor_ini1 => Scenario.AiOrderDefinitions[31].GameObject;
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
        public IAiOrders ledge_bot_grunts1 => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders ledge_bot_jackals1 => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders maus_inner_hunters => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders maus_inner_elites_ini1 => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders maus_inner_buggers_ini => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders maus_inner_brutes_ini1 => Scenario.AiOrderDefinitions[48].GameObject;
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
        public IAiOrders cortana_jail1 => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders jail_follow => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders jail_jackals_ini1 => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders jail_brutes_ini1 => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders jail_grunts_ini1 => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders jail_a_brute1 => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders jail_a_jackals1 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders jail_b_brute => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders jail_b_grunts1 => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders room_b_marines1 => Scenario.AiOrderDefinitions[69].GameObject;
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
        public IAiOrders maus_bridge_elites_ini1 => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders maus_bridge_prophets_ini => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders maus_bridge_buggers_ini1 => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders maus_bridge_prophets_all => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders maus_bridge_grunt_reins => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders maus_bridge_elite_reins => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders maus_bridge_hunters1 => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders maus_bridge_grunt_rein_b1 => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders maus_ent_collapse => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders maus_bridge_buggers_rein => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders maus_room_elite_lt1 => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders maus_room_elite_rt1 => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders maus_room_grunt_lt1 => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders maus_room_grunt_rt1 => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders maus_room_brute_bk1 => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders maus_room_jackal_bk_lt1 => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders maus_room_jackal_bk_rt1 => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders maus_room_lt_reins => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders maus_room_rt_reins => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders maus_hall_grunts1 => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders hall_a_jackal_ini1 => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders hall_a_brute_ini1 => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders hall_a_jackal_ini2 => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders hall_a_brute_reins => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders hall_a_grunt_reins => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders hall_a_grunt_rein_bk1 => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders hall_a_brute_rein_bk1 => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders hall_b_jackal => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders hall_b_brutes1 => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders hall_b_grunts1 => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders room_a_brutes_ini1 => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders room_a_jackal_ini => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders room_a_brutes_bk1 => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders room_a_follow => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders room_a_bk_reins => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders room_a_bot => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders marines_a_guard_b => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders marines_b_guard_a => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders room_b_brutes_ini1 => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders room_b_elites1 => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders room_b_buggers1 => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders room_b_bugger_follow => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders hall_c_elites1 => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders hall_c_buggers1 => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders hall_c_brutes_rein => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders grand_b_hunter_a1 => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders hall_d_elites1 => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders hall_d_brutes1 => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders hall_d_jackals_bk1 => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders hall_d_jackals_fr1 => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders midtower_elites1 => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders midtower_buggers => Scenario.AiOrderDefinitions[131].GameObject;
        public IAiOrders midtower_brutes1 => Scenario.AiOrderDefinitions[132].GameObject;
        public IAiOrders midtower_jackals1 => Scenario.AiOrderDefinitions[133].GameObject;
        public IAiOrders midtower_elite_rein => Scenario.AiOrderDefinitions[134].GameObject;
        public IAiOrders midtower_exit1 => Scenario.AiOrderDefinitions[135].GameObject;
        public IAiOrders ext_a_jackal_snipers_a1 => Scenario.AiOrderDefinitions[136].GameObject;
        public IAiOrders ext_a_jackal_snipers_b1 => Scenario.AiOrderDefinitions[137].GameObject;
        public IAiOrders ext_a_jackal_snipers_c1 => Scenario.AiOrderDefinitions[138].GameObject;
        public IAiOrders ext_a_jackal_snipers_d1 => Scenario.AiOrderDefinitions[139].GameObject;
        public IAiOrders ext_a_watch_brutes1 => Scenario.AiOrderDefinitions[140].GameObject;
        public IAiOrders ext_a_watch_elites_ini => Scenario.AiOrderDefinitions[141].GameObject;
        public IAiOrders ext_a_watch_elites_follow => Scenario.AiOrderDefinitions[142].GameObject;
        public IAiOrders ext_a_watch_elites_a => Scenario.AiOrderDefinitions[143].GameObject;
        public IAiOrders ext_a_watch_elites_c => Scenario.AiOrderDefinitions[144].GameObject;
        public IAiOrders ext_a_watch_elites_d => Scenario.AiOrderDefinitions[145].GameObject;
        public IAiOrders ext_a_hunters_ini => Scenario.AiOrderDefinitions[146].GameObject;
        public IAiOrders ext_a_brute_door1 => Scenario.AiOrderDefinitions[147].GameObject;
        public IAiOrders ext_a_brute_ini1 => Scenario.AiOrderDefinitions[148].GameObject;
        public IAiOrders ext_a_buggers1 => Scenario.AiOrderDefinitions[149].GameObject;
        public IAiOrders ext_a_rangers1 => Scenario.AiOrderDefinitions[150].GameObject;
        public IAiOrders ext_a_elite_ini1 => Scenario.AiOrderDefinitions[151].GameObject;
        public IAiOrders ext_a_buggers_bk1 => Scenario.AiOrderDefinitions[152].GameObject;
        public IAiOrders ext_a_brutes_bk1 => Scenario.AiOrderDefinitions[153].GameObject;
        public IAiOrders garden_a_jackal_snipers1 => Scenario.AiOrderDefinitions[154].GameObject;
        public IAiOrders ext_b_elite_a1 => Scenario.AiOrderDefinitions[155].GameObject;
        public IAiOrders ext_b_brute_a1 => Scenario.AiOrderDefinitions[156].GameObject;
        public IAiOrders ext_b_grunts_b1 => Scenario.AiOrderDefinitions[157].GameObject;
        public IAiOrders ext_b_brutes_b1 => Scenario.AiOrderDefinitions[158].GameObject;
        public IAiOrders ext_b_jackal_a1 => Scenario.AiOrderDefinitions[159].GameObject;
        public IAiOrders ext_b_brutes_low_door1 => Scenario.AiOrderDefinitions[160].GameObject;
        public IAiOrders ext_b_brutes_low1 => Scenario.AiOrderDefinitions[161].GameObject;
        public IAiOrders ext_b_grunts_low1 => Scenario.AiOrderDefinitions[162].GameObject;
        public IAiOrders ext_b_elites_bk_door1 => Scenario.AiOrderDefinitions[163].GameObject;
        public IAiOrders ext_b_grunt_bk_door1 => Scenario.AiOrderDefinitions[164].GameObject;
        public IAiOrders ext_b_elites_lt => Scenario.AiOrderDefinitions[165].GameObject;
        public IAiOrders ext_b_grunts_lt1 => Scenario.AiOrderDefinitions[166].GameObject;
        public IAiOrders ext_b_cov_dump1 => Scenario.AiOrderDefinitions[167].GameObject;
        public IAiOrders ext_b_prophet_dump1 => Scenario.AiOrderDefinitions[168].GameObject;
        public IAiOrders maus_hall_elites_stealth1 => Scenario.AiOrderDefinitions[169].GameObject;
        public IAiOrders hall_b_grunts_bk1 => Scenario.AiOrderDefinitions[170].GameObject;
        public IAiOrders garden_a_brute_a1 => Scenario.AiOrderDefinitions[171].GameObject;
        public IAiOrders garden_a_brute_b1 => Scenario.AiOrderDefinitions[172].GameObject;
        public IAiOrders garden_a_brute_c1 => Scenario.AiOrderDefinitions[173].GameObject;
        public IAiOrders garden_a_elite_a1 => Scenario.AiOrderDefinitions[174].GameObject;
        public IAiOrders garden_a_elite_b1 => Scenario.AiOrderDefinitions[175].GameObject;
        public IAiOrders garden_a_elite_c1 => Scenario.AiOrderDefinitions[176].GameObject;
        public IAiOrders garden_a_pro_dump => Scenario.AiOrderDefinitions[177].GameObject;
        public IAiOrders garden_a_cov_dump => Scenario.AiOrderDefinitions[178].GameObject;
        public IAiOrders garden_a_elites_ini => Scenario.AiOrderDefinitions[179].GameObject;
        public IAiOrders garden_a_grunt_ini => Scenario.AiOrderDefinitions[180].GameObject;
        public IAiOrders garden_a_brute_lt1 => Scenario.AiOrderDefinitions[181].GameObject;
        public IAiOrders garden_a_brute_rt1 => Scenario.AiOrderDefinitions[182].GameObject;
        public IAiOrders garden_a_ranger_fr => Scenario.AiOrderDefinitions[183].GameObject;
        public IAiOrders garden_a_ranger_mid => Scenario.AiOrderDefinitions[184].GameObject;
        public IAiOrders garden_a_ranger_bk => Scenario.AiOrderDefinitions[185].GameObject;
        public IAiOrders garden_b_brute => Scenario.AiOrderDefinitions[186].GameObject;
        public IAiOrders garden_a_grunt_a => Scenario.AiOrderDefinitions[187].GameObject;
        public IAiOrders garden_a_grunt_b => Scenario.AiOrderDefinitions[188].GameObject;
        public IAiOrders garden_a_grunt_c => Scenario.AiOrderDefinitions[189].GameObject;
        public IAiOrders ledge_brutes_ini1 => Scenario.AiOrderDefinitions[190].GameObject;
        public IAiOrders grand_a_turret1 => Scenario.AiOrderDefinitions[191].GameObject;
        public IAiOrders ext_a_tram_a => Scenario.AiOrderDefinitions[192].GameObject;
        public IAiOrders ext_a_prophets_follow => Scenario.AiOrderDefinitions[193].GameObject;
        public IAiOrders ext_a_covenant_follow => Scenario.AiOrderDefinitions[194].GameObject;
        public IAiOrders ext_a_follow_elites => Scenario.AiOrderDefinitions[195].GameObject;
        public IAiOrders ext_a_brute_bk_door1 => Scenario.AiOrderDefinitions[196].GameObject;
        public IAiOrders ext_b_brute_ramp1 => Scenario.AiOrderDefinitions[197].GameObject;
        public IAiOrders grand_b_hunter_b1 => Scenario.AiOrderDefinitions[198].GameObject;
        public IAiOrders maus_room_cov_follow => Scenario.AiOrderDefinitions[199].GameObject;
        public IAiOrders maus_room_prophet_follow => Scenario.AiOrderDefinitions[200].GameObject;
        public IAiOrders maus_bridge_cov_screw => Scenario.AiOrderDefinitions[201].GameObject;
        public IAiOrders maus_bridge_prophet_screw => Scenario.AiOrderDefinitions[202].GameObject;
        public IAiOrders ice_cream_grunt1 => Scenario.AiOrderDefinitions[203].GameObject;
        public IAiOrders garden_a_elites_bk1 => Scenario.AiOrderDefinitions[204].GameObject;
        public IAiOrders garden_a_grunt_bk => Scenario.AiOrderDefinitions[205].GameObject;
        public IAiOrders garden_a_jackal_bk => Scenario.AiOrderDefinitions[206].GameObject;
        public IAiOrders gardne_a_brute_bk => Scenario.AiOrderDefinitions[207].GameObject;
        public IAiOrders maus_inner_bk => Scenario.AiOrderDefinitions[208].GameObject;
        public IAiOrders maus_inner_zealot => Scenario.AiOrderDefinitions[209].GameObject;
        public IAiOrders maus_inner_spec => Scenario.AiOrderDefinitions[210].GameObject;
        public ILocationFlag council_chamber => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag halls => Scenario.LocationFlagDefinitions[1].GameObject;
        public ILocationFlag garden => Scenario.LocationFlagDefinitions[2].GameObject;
        public ILocationFlag mausoleum => Scenario.LocationFlagDefinitions[3].GameObject;
        public ILocationFlag anchor_flag_x08 => Scenario.LocationFlagDefinitions[4].GameObject;
        public ILocationFlag anchor_flag_intra1 => Scenario.LocationFlagDefinitions[5].GameObject;
        public ILocationFlag anchor_flag_intro_a => Scenario.LocationFlagDefinitions[6].GameObject;
        public ILocationFlag anchor_flag_intro_b => Scenario.LocationFlagDefinitions[7].GameObject;
        public ILocationFlag anchor_flag_intro_c => Scenario.LocationFlagDefinitions[8].GameObject;
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[9].GameObject;
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[10].GameObject;
        public ILocationFlag cortana_council => Scenario.LocationFlagDefinitions[11].GameObject;
        public ILocationFlag cortana_ledge => Scenario.LocationFlagDefinitions[12].GameObject;
        public ILocationFlag cortana_ledge_fr => Scenario.LocationFlagDefinitions[13].GameObject;
        public ILocationFlag cor_maus_inner_a => Scenario.LocationFlagDefinitions[14].GameObject;
        public ILocationFlag cor_maus_inner_b => Scenario.LocationFlagDefinitions[15].GameObject;
        public ILocationFlag cor_maus_inner_c => Scenario.LocationFlagDefinitions[16].GameObject;
        public ILocationFlag cor_maus_inner_d => Scenario.LocationFlagDefinitions[17].GameObject;
        public ILocationFlag cor_maus_inner_e => Scenario.LocationFlagDefinitions[18].GameObject;
        public ILocationFlag cor_maus_inner_f => Scenario.LocationFlagDefinitions[19].GameObject;
        public ILocationFlag cor_maus_inner_g => Scenario.LocationFlagDefinitions[20].GameObject;
        public ILocationFlag cor_maus_inner_h => Scenario.LocationFlagDefinitions[21].GameObject;
        public ILocationFlag cor_maus_inner_i => Scenario.LocationFlagDefinitions[22].GameObject;
        public ILocationFlag cor_maus_inner_j => Scenario.LocationFlagDefinitions[23].GameObject;
        public ILocationFlag jails0_tele => Scenario.LocationFlagDefinitions[24].GameObject;
        public ILocationFlag jails1_tele => Scenario.LocationFlagDefinitions[25].GameObject;
        public ILocationFlag corrb0_tele => Scenario.LocationFlagDefinitions[26].GameObject;
        public ILocationFlag corrb1_tele => Scenario.LocationFlagDefinitions[27].GameObject;
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
            cortana_0 = new Squad_cortana_0(scenarioTag);
            cortana_1 = new Squad_cortana_1(scenarioTag);
            cortana_grand_b = new Squad_cortana_grand_b(scenarioTag);
            cortana_corridor_a = new Squad_cortana_corridor_a(scenarioTag);
            cortana_room_a = new Squad_cortana_room_a(scenarioTag);
            cortana_room_b = new Squad_cortana_room_b(scenarioTag);
            cortana_corridor_b = new Squad_cortana_corridor_b(scenarioTag);
            cortana_jail = new Squad_cortana_jail(scenarioTag);
            cortana_3a = new Squad_cortana_3a(scenarioTag);
            cortana_3b = new Squad_cortana_3b(scenarioTag);
            cortana_4 = new Squad_cortana_4(scenarioTag);
            cortana_maus_room = new Squad_cortana_maus_room(scenarioTag);
            cortana_maus_bridge = new Squad_cortana_maus_bridge(scenarioTag);
            cortana_maus = new Squad_cortana_maus(scenarioTag);
            marines_bsp2 = new Squad_marines_bsp2(scenarioTag);
            marines_bsp3 = new Squad_marines_bsp3(scenarioTag);
            _______COUNCIL_CHAMBER_______ = new Squad________COUNCIL_CHAMBER_______(scenarioTag);
            council_brute_ini = new Squad_council_brute_ini(scenarioTag);
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
            grand_a_turret = new Squad_grand_a_turret(scenarioTag);
            ledge_brutes_honor_ini = new Squad_ledge_brutes_honor_ini(scenarioTag);
            ledge_brutes_ini = new Squad_ledge_brutes_ini(scenarioTag);
            ledge_jackal_left = new Squad_ledge_jackal_left(scenarioTag);
            ledge_jackal_right = new Squad_ledge_jackal_right(scenarioTag);
            ledge_lift_brute_rt = new Squad_ledge_lift_brute_rt(scenarioTag);
            ledge_lift_brute_lt = new Squad_ledge_lift_brute_lt(scenarioTag);
            ledge_lift_chieftan = new Squad_ledge_lift_chieftan(scenarioTag);
            ledge_lift_grunt_rt = new Squad_ledge_lift_grunt_rt(scenarioTag);
            ledge_lift_grunt_lt = new Squad_ledge_lift_grunt_lt(scenarioTag);
            ledge_bot_grunts = new Squad_ledge_bot_grunts(scenarioTag);
            ledge_bot_jackals = new Squad_ledge_bot_jackals(scenarioTag);
            _______CORIDORS_A_______ = new Squad________CORIDORS_A_______(scenarioTag);
            hall_a_jackal_patrol_ini = new Squad_hall_a_jackal_patrol_ini(scenarioTag);
            hall_a_brute_ini = new Squad_hall_a_brute_ini(scenarioTag);
            hall_a_jackal_ini = new Squad_hall_a_jackal_ini(scenarioTag);
            hall_a_brute_rein = new Squad_hall_a_brute_rein(scenarioTag);
            hall_a_brute_rein_bk = new Squad_hall_a_brute_rein_bk(scenarioTag);
            hall_a_grunt_rein = new Squad_hall_a_grunt_rein(scenarioTag);
            hall_a_grunt_rein_bk = new Squad_hall_a_grunt_rein_bk(scenarioTag);
            hall_b_brutes = new Squad_hall_b_brutes(scenarioTag);
            hall_b_grunts = new Squad_hall_b_grunts(scenarioTag);
            hall_b_grunts_bk = new Squad_hall_b_grunts_bk(scenarioTag);
            hall_b_jackals = new Squad_hall_b_jackals(scenarioTag);
            room_a_brutes_ini = new Squad_room_a_brutes_ini(scenarioTag);
            room_a_jackals_ini = new Squad_room_a_jackals_ini(scenarioTag);
            room_a_brutes_bk = new Squad_room_a_brutes_bk(scenarioTag);
            room_a_brutes_a = new Squad_room_a_brutes_a(scenarioTag);
            room_a_brutes_b = new Squad_room_a_brutes_b(scenarioTag);
            room_a_brutes_c = new Squad_room_a_brutes_c(scenarioTag);
            room_a_grunts_a = new Squad_room_a_grunts_a(scenarioTag);
            room_a_grunts_b = new Squad_room_a_grunts_b(scenarioTag);
            room_a_grunts_c = new Squad_room_a_grunts_c(scenarioTag);
            room_a_tube_fodder = new Squad_room_a_tube_fodder(scenarioTag);
            _________JAIL_________ = new Squad__________JAIL_________(scenarioTag);
            jail_trash = new Squad_jail_trash(scenarioTag);
            jail_brutes_ini = new Squad_jail_brutes_ini(scenarioTag);
            jail_grunts_ini = new Squad_jail_grunts_ini(scenarioTag);
            jail_jackals_ini = new Squad_jail_jackals_ini(scenarioTag);
            jail_brutes_down = new Squad_jail_brutes_down(scenarioTag);
            jail_grunts_down = new Squad_jail_grunts_down(scenarioTag);
            jail_jackals_down = new Squad_jail_jackals_down(scenarioTag);
            jail_a_marines = new Squad_jail_a_marines(scenarioTag);
            jail_a_brute = new Squad_jail_a_brute(scenarioTag);
            jail_a_jackals = new Squad_jail_a_jackals(scenarioTag);
            jail_b_marines = new Squad_jail_b_marines(scenarioTag);
            jail_b_brutes = new Squad_jail_b_brutes(scenarioTag);
            jail_b_grunts = new Squad_jail_b_grunts(scenarioTag);
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
            room_b_marines = new Squad_room_b_marines(scenarioTag);
            room_b_brutes_ini = new Squad_room_b_brutes_ini(scenarioTag);
            room_b_elites = new Squad_room_b_elites(scenarioTag);
            room_b_buggers = new Squad_room_b_buggers(scenarioTag);
            hall_c_elites = new Squad_hall_c_elites(scenarioTag);
            hall_c_buggers = new Squad_hall_c_buggers(scenarioTag);
            hall_c_brute_reins = new Squad_hall_c_brute_reins(scenarioTag);
            hall_c_bugger_reins = new Squad_hall_c_bugger_reins(scenarioTag);
            hall_d_elites = new Squad_hall_d_elites(scenarioTag);
            hall_d_brutes = new Squad_hall_d_brutes(scenarioTag);
            hall_d_jackals_fr = new Squad_hall_d_jackals_fr(scenarioTag);
            hall_d_jackals_bk = new Squad_hall_d_jackals_bk(scenarioTag);
            grand_b_hunter_a = new Squad_grand_b_hunter_a(scenarioTag);
            grand_b_hunter_b = new Squad_grand_b_hunter_b(scenarioTag);
            _______EXT_A_______ = new Squad________EXT_A_______(scenarioTag);
            ext_a_jackal_snipers_a = new Squad_ext_a_jackal_snipers_a(scenarioTag);
            ext_a_jackal_snipers_b = new Squad_ext_a_jackal_snipers_b(scenarioTag);
            ext_a_jackal_snipers_c = new Squad_ext_a_jackal_snipers_c(scenarioTag);
            ext_a_jackal_snipers_d = new Squad_ext_a_jackal_snipers_d(scenarioTag);
            ext_a_watch_brutes = new Squad_ext_a_watch_brutes(scenarioTag);
            ext_a_watch_elites = new Squad_ext_a_watch_elites(scenarioTag);
            ext_a_hunters = new Squad_ext_a_hunters(scenarioTag);
            ext_a_brute_door = new Squad_ext_a_brute_door(scenarioTag);
            ext_a_elite_ini = new Squad_ext_a_elite_ini(scenarioTag);
            ext_a_brute_ini = new Squad_ext_a_brute_ini(scenarioTag);
            ext_a_rangers = new Squad_ext_a_rangers(scenarioTag);
            ext_a_buggers = new Squad_ext_a_buggers(scenarioTag);
            ext_a_brute_bk_door = new Squad_ext_a_brute_bk_door(scenarioTag);
            ext_a_buggers_bk = new Squad_ext_a_buggers_bk(scenarioTag);
            ext_a_brutes_bk = new Squad_ext_a_brutes_bk(scenarioTag);
            _______GARDEN_A_______ = new Squad________GARDEN_A_______(scenarioTag);
            garden_a_elites = new Squad_garden_a_elites(scenarioTag);
            garden_a_grunts = new Squad_garden_a_grunts(scenarioTag);
            garden_a_brute_lt = new Squad_garden_a_brute_lt(scenarioTag);
            garden_a_brute_rt = new Squad_garden_a_brute_rt(scenarioTag);
            garden_a_jackal_snipers = new Squad_garden_a_jackal_snipers(scenarioTag);
            garden_a_buggers = new Squad_garden_a_buggers(scenarioTag);
            garden_a_brute_a = new Squad_garden_a_brute_a(scenarioTag);
            garden_a_brute_b = new Squad_garden_a_brute_b(scenarioTag);
            garden_a_brute_c = new Squad_garden_a_brute_c(scenarioTag);
            garden_a_elite_a = new Squad_garden_a_elite_a(scenarioTag);
            garden_a_elite_b = new Squad_garden_a_elite_b(scenarioTag);
            garden_a_elite_c = new Squad_garden_a_elite_c(scenarioTag);
            garden_a_rangers = new Squad_garden_a_rangers(scenarioTag);
            garden_a_elites_bk = new Squad_garden_a_elites_bk(scenarioTag);
            garden_a_grunts_bk = new Squad_garden_a_grunts_bk(scenarioTag);
            garden_a_jackals_bk = new Squad_garden_a_jackals_bk(scenarioTag);
            garden_a_brutes_bk = new Squad_garden_a_brutes_bk(scenarioTag);
            _______MID_TOWER_______ = new Squad________MID_TOWER_______(scenarioTag);
            midtower_turrets = new Squad_midtower_turrets(scenarioTag);
            midtower_elites = new Squad_midtower_elites(scenarioTag);
            midtower_elite_reins = new Squad_midtower_elite_reins(scenarioTag);
            mid_tower_hunters = new Squad_mid_tower_hunters(scenarioTag);
            midtower_buggers_ini = new Squad_midtower_buggers_ini(scenarioTag);
            midtower_bugger_rein = new Squad_midtower_bugger_rein(scenarioTag);
            midtower_brutes = new Squad_midtower_brutes(scenarioTag);
            midtower_jackals = new Squad_midtower_jackals(scenarioTag);
            midtower_buggers_hall = new Squad_midtower_buggers_hall(scenarioTag);
            _______GARDEN_B_______ = new Squad________GARDEN_B_______(scenarioTag);
            garden_b_grunt_a = new Squad_garden_b_grunt_a(scenarioTag);
            garden_b_grunt_b = new Squad_garden_b_grunt_b(scenarioTag);
            garden_b_grunt_c = new Squad_garden_b_grunt_c(scenarioTag);
            garden_b_brute_ini = new Squad_garden_b_brute_ini(scenarioTag);
            _______EXT_B_______ = new Squad________EXT_B_______(scenarioTag);
            ext_b_brute_ramp = new Squad_ext_b_brute_ramp(scenarioTag);
            ext_b_elite_a = new Squad_ext_b_elite_a(scenarioTag);
            ext_b_brute_a = new Squad_ext_b_brute_a(scenarioTag);
            ext_b_grunts_b = new Squad_ext_b_grunts_b(scenarioTag);
            ext_b_brutes_b = new Squad_ext_b_brutes_b(scenarioTag);
            ext_b_grunts_low = new Squad_ext_b_grunts_low(scenarioTag);
            ext_b_brutes_low = new Squad_ext_b_brutes_low(scenarioTag);
            ext_b_jackal_a = new Squad_ext_b_jackal_a(scenarioTag);
            ext_b_grunt_bk_door = new Squad_ext_b_grunt_bk_door(scenarioTag);
            ext_b_elites_bk_door = new Squad_ext_b_elites_bk_door(scenarioTag);
            ext_b_elites_stealth = new Squad_ext_b_elites_stealth(scenarioTag);
            ext_b_grunts_lt = new Squad_ext_b_grunts_lt(scenarioTag);
            ext_b_brutes_low_door = new Squad_ext_b_brutes_low_door(scenarioTag);
            ext_b_jackal_b = new Squad_ext_b_jackal_b(scenarioTag);
            ext_b_jackal_c = new Squad_ext_b_jackal_c(scenarioTag);
            ext_b_cov_dump = new Squad_ext_b_cov_dump(scenarioTag);
            ext_b_prophet_dump = new Squad_ext_b_prophet_dump(scenarioTag);
            _______MAUSOLEUM_______ = new Squad________MAUSOLEUM_______(scenarioTag);
            maus_hall_elites_stealth = new Squad_maus_hall_elites_stealth(scenarioTag);
            maus_hall_grunts = new Squad_maus_hall_grunts(scenarioTag);
            maus_room_elite_lt = new Squad_maus_room_elite_lt(scenarioTag);
            maus_room_elite_rt = new Squad_maus_room_elite_rt(scenarioTag);
            maus_room_grunt_lt = new Squad_maus_room_grunt_lt(scenarioTag);
            maus_room_grunt_rt = new Squad_maus_room_grunt_rt(scenarioTag);
            maus_room_brute_bk = new Squad_maus_room_brute_bk(scenarioTag);
            maus_room_jackal_bk_lt = new Squad_maus_room_jackal_bk_lt(scenarioTag);
            maus_room_jackal_bk_rt = new Squad_maus_room_jackal_bk_rt(scenarioTag);
            maus_room_lt_elite_reins = new Squad_maus_room_lt_elite_reins(scenarioTag);
            maus_room_rt_elite_reins = new Squad_maus_room_rt_elite_reins(scenarioTag);
            maus_room_lt_grunt_reins = new Squad_maus_room_lt_grunt_reins(scenarioTag);
            maus_room_rt_grunt_reins = new Squad_maus_room_rt_grunt_reins(scenarioTag);
            maus_bridge_elite_turret = new Squad_maus_bridge_elite_turret(scenarioTag);
            maus_bridge_elites_ini = new Squad_maus_bridge_elites_ini(scenarioTag);
            maus_bridge_elite_rein = new Squad_maus_bridge_elite_rein(scenarioTag);
            maus_bridge_grunt_rein = new Squad_maus_bridge_grunt_rein(scenarioTag);
            maus_bridge_grunt_rein_b = new Squad_maus_bridge_grunt_rein_b(scenarioTag);
            maus_bridge_hunters = new Squad_maus_bridge_hunters(scenarioTag);
            maus_bridge_buggers_ini = new Squad_maus_bridge_buggers_ini(scenarioTag);
            maus_bridge_brutes_ini = new Squad_maus_bridge_brutes_ini(scenarioTag);
            maus_bridge_jackals_ini = new Squad_maus_bridge_jackals_ini(scenarioTag);
            maus_inner_hunters_ini = new Squad_maus_inner_hunters_ini(scenarioTag);
            maus_inner_elites_ini = new Squad_maus_inner_elites_ini(scenarioTag);
            maus_inner_grunts_ini = new Squad_maus_inner_grunts_ini(scenarioTag);
            maus_inner_turrets = new Squad_maus_inner_turrets(scenarioTag);
            maus_inner_brutes_ini = new Squad_maus_inner_brutes_ini(scenarioTag);
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
            ice_cream_grunt = new Squad_ice_cream_grunt(scenarioTag);
            c07_infection = new Squad_c07_infection(scenarioTag);
        }

        public class Squad_c07_infection_old
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _0 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[1];
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[2];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[3];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[4];
            public IAiActorDefinition _4 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[5];
            public IAiActorDefinition _5 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[6];
            public IAiActorDefinition _6 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[7];
            public IAiActorDefinition _7 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[8];
            public IAiActorDefinition _8 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[9];
            public IAiActorDefinition _9 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[10];
            public IAiActorDefinition _10 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[11];
            public IAiActorDefinition _11 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[12];
            public IAiActorDefinition _12 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[13];
            public IAiActorDefinition _13 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[14];
            public IAiActorDefinition _14 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[15];
            public IAiActorDefinition _15 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[16];
            public IAiActorDefinition _16 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[17];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_c07_infection_old(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_empty
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_empty(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[2].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[2].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[2].StartingLocations[3];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[2].StartingLocations[4];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[2].StartingLocations[5];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[2].StartingLocations[6];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[2].StartingLocations[7];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[2].StartingLocations[8];
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[2].StartingLocations[9];
            public IAiActorDefinition j => ScenarioTag.AiSquadDefinitions[2].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_cortana_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_cortana_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_grand_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[4].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[4].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_cortana_grand_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_corridor_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[5].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[5].StartingLocations[3];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[5].StartingLocations[4];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[5].StartingLocations[5];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[5].StartingLocations[6];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[5].StartingLocations[7];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[5].StartingLocations[8];
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[5].StartingLocations[9];
            public IAiActorDefinition j => ScenarioTag.AiSquadDefinitions[5].StartingLocations[10];
            public IAiActorDefinition k => ScenarioTag.AiSquadDefinitions[5].StartingLocations[11];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[5].StartingLocations[12];
            public IAiActorDefinition m => ScenarioTag.AiSquadDefinitions[5].StartingLocations[13];
            public IAiActorDefinition n => ScenarioTag.AiSquadDefinitions[5].StartingLocations[14];
            public IAiActorDefinition o => ScenarioTag.AiSquadDefinitions[5].StartingLocations[15];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_cortana_corridor_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_room_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[6].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[6].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[6].StartingLocations[3];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[6].StartingLocations[4];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[6].StartingLocations[5];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[6].StartingLocations[6];
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[6].StartingLocations[7];
            public IAiActorDefinition j => ScenarioTag.AiSquadDefinitions[6].StartingLocations[8];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[6].StartingLocations[9];
            public IAiActorDefinition m => ScenarioTag.AiSquadDefinitions[6].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_cortana_room_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_room_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_cortana_room_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_corridor_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_cortana_corridor_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_jail
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[9].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[9].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[9].StartingLocations[3];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[9].StartingLocations[4];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[9].StartingLocations[5];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[9].StartingLocations[6];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[9].StartingLocations[7];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[9].StartingLocations[8];
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[9].StartingLocations[9];
            public IAiActorDefinition j => ScenarioTag.AiSquadDefinitions[9].StartingLocations[10];
            public IAiActorDefinition k => ScenarioTag.AiSquadDefinitions[9].StartingLocations[11];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[9].StartingLocations[12];
            public IAiActorDefinition m => ScenarioTag.AiSquadDefinitions[9].StartingLocations[13];
            public IAiActorDefinition n => ScenarioTag.AiSquadDefinitions[9].StartingLocations[14];
            public IAiActorDefinition o => ScenarioTag.AiSquadDefinitions[9].StartingLocations[15];
            public IAiActorDefinition p => ScenarioTag.AiSquadDefinitions[9].StartingLocations[16];
            public IAiActorDefinition q => ScenarioTag.AiSquadDefinitions[9].StartingLocations[17];
            public IAiActorDefinition r => ScenarioTag.AiSquadDefinitions[9].StartingLocations[18];
            public IAiActorDefinition s => ScenarioTag.AiSquadDefinitions[9].StartingLocations[19];
            public IAiActorDefinition t => ScenarioTag.AiSquadDefinitions[9].StartingLocations[20];
            public IAiActorDefinition u => ScenarioTag.AiSquadDefinitions[9].StartingLocations[21];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_cortana_jail(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_3a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition tram_a => ScenarioTag.AiSquadDefinitions[10].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_cortana_3a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_3b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_cortana_3b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_4
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_cortana_4(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_maus_room
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[13].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[13].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[13].StartingLocations[3];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[13].StartingLocations[4];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[13].StartingLocations[5];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[13].StartingLocations[6];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[13].StartingLocations[7];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[13].StartingLocations[8];
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[13].StartingLocations[9];
            public IAiActorDefinition j => ScenarioTag.AiSquadDefinitions[13].StartingLocations[10];
            public IAiActorDefinition k => ScenarioTag.AiSquadDefinitions[13].StartingLocations[11];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[13].StartingLocations[12];
            public IAiActorDefinition m => ScenarioTag.AiSquadDefinitions[13].StartingLocations[13];
            public IAiActorDefinition n => ScenarioTag.AiSquadDefinitions[13].StartingLocations[14];
            public IAiActorDefinition o => ScenarioTag.AiSquadDefinitions[13].StartingLocations[15];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_cortana_maus_room(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_maus_bridge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[14].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[14].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[14].StartingLocations[3];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[14].StartingLocations[4];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[14].StartingLocations[5];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[14].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_cortana_maus_bridge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cortana_maus
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[15].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[15].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[15].StartingLocations[3];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[15].StartingLocations[4];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[15].StartingLocations[5];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[15].StartingLocations[6];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[15].StartingLocations[7];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[15].StartingLocations[8];
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[15].StartingLocations[9];
            public IAiActorDefinition j => ScenarioTag.AiSquadDefinitions[15].StartingLocations[10];
            public IAiActorDefinition k => ScenarioTag.AiSquadDefinitions[15].StartingLocations[11];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[15].StartingLocations[12];
            public IAiActorDefinition m => ScenarioTag.AiSquadDefinitions[15].StartingLocations[13];
            public IAiActorDefinition n => ScenarioTag.AiSquadDefinitions[15].StartingLocations[14];
            public IAiActorDefinition o => ScenarioTag.AiSquadDefinitions[15].StartingLocations[15];
            public IAiActorDefinition p => ScenarioTag.AiSquadDefinitions[15].StartingLocations[16];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_cortana_maus(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_marines_bsp2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_marines_bsp2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_marines_bsp3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_marines_bsp3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________COUNCIL_CHAMBER_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad________COUNCIL_CHAMBER_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_brute_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_council_brute_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_grunt_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[20].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[20].StartingLocations[3];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[20].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_council_grunt_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_brute_ped
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[21].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[21].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[21].StartingLocations[3];
            public IAiActorDefinition chief => ScenarioTag.AiSquadDefinitions[21].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_council_brute_ped(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_grunt_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_council_rt_grunt_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_grunt_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_council_rt_grunt_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_grunt_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_council_rt_grunt_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_grunt_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_council_lt_grunt_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_grunt_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_council_lt_grunt_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_grunt_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_council_lt_grunt_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_brute_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[1];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_council_rt_brute_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_brute_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_council_rt_brute_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_brute_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_council_rt_brute_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_brute_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_council_lt_brute_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_brute_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_council_lt_brute_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_brute_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_council_lt_brute_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_upper_brute_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_council_rt_upper_brute_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_upper_brute_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_council_rt_upper_brute_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_rt_upper_brute_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_council_rt_upper_brute_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_upper_brute_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_council_lt_upper_brute_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_upper_brute_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_council_lt_upper_brute_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_council_lt_upper_brute_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_council_lt_upper_brute_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grand_a_brutes
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_grand_a_brutes(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grand_a_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_grand_a_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grand_a_turret
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_grand_a_turret(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_brutes_honor_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_ledge_brutes_honor_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_brutes_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_ledge_brutes_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_jackal_left
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_ledge_jackal_left(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_jackal_right
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_ledge_jackal_right(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_lift_brute_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_ledge_lift_brute_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_lift_brute_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_ledge_lift_brute_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_lift_chieftan
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_ledge_lift_chieftan(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_lift_grunt_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_ledge_lift_grunt_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_lift_grunt_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_ledge_lift_grunt_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_bot_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_ledge_bot_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_bot_jackals
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_ledge_bot_jackals(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________CORIDORS_A_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad________CORIDORS_A_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_jackal_patrol_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_hall_a_jackal_patrol_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_brute_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_hall_a_brute_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_jackal_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_hall_a_jackal_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_brute_rein
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_hall_a_brute_rein(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_brute_rein_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_hall_a_brute_rein_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_grunt_rein
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_hall_a_grunt_rein(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_grunt_rein_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_hall_a_grunt_rein_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_b_brutes
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_hall_b_brutes(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_b_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[5];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_hall_b_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_b_grunts_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_hall_b_grunts_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_b_jackals
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_hall_b_jackals(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_brutes_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_room_a_brutes_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_jackals_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_room_a_jackals_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_brutes_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_room_a_brutes_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_brutes_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_room_a_brutes_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_brutes_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_room_a_brutes_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_brutes_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_room_a_brutes_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_grunts_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_room_a_grunts_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_grunts_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_room_a_grunts_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_grunts_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_room_a_grunts_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_a_tube_fodder
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_room_a_tube_fodder(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad__________JAIL_________
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad__________JAIL_________(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_trash
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_jail_trash(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brutes_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_jail_brutes_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunts_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_jail_grunts_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackals_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_jail_jackals_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brutes_down
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_jail_brutes_down(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunts_down
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[2];
            public IAiActorDefinition t1 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[3];
            public IAiActorDefinition t2 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_jail_grunts_down(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackals_down
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_jail_jackals_down(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_a_marines
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[84].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[84].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_jail_a_marines(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_a_brute
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[85];
            public Squad_jail_a_brute(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_a_jackals
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[86];
            public Squad_jail_a_jackals(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_b_marines
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[87].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[87].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[87].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[87];
            public Squad_jail_b_marines(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_b_brutes
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[88];
            public Squad_jail_b_brutes(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_b_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[89];
            public Squad_jail_b_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_guard_brute_cell_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[90];
            public Squad_jail_guard_brute_cell_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_guard_jackal_cell_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[2];
            public IAiActorDefinition starting_locations_21 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[91];
            public Squad_jail_guard_jackal_cell_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_guard_brute_cell_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[92];
            public Squad_jail_guard_brute_cell_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_guard_jackal_cell_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[93];
            public Squad_jail_guard_jackal_cell_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[94];
            public Squad_jail_brute_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[95];
            public Squad_jail_brute_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[96];
            public Squad_jail_brute_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_f
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[97];
            public Squad_jail_brute_f(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_g
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[98];
            public Squad_jail_brute_g(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_i
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[99];
            public Squad_jail_brute_i(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_j
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[100];
            public Squad_jail_brute_j(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_k
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[101].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[101];
            public Squad_jail_brute_k(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[102];
            public Squad_jail_brute_l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_brute_m
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[103].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[103];
            public Squad_jail_brute_m(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[104];
            public Squad_jail_grunt_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[105];
            public Squad_jail_grunt_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[106];
            public Squad_jail_grunt_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_f
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[107];
            public Squad_jail_grunt_f(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_g
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[108];
            public Squad_jail_grunt_g(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_i
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[109];
            public Squad_jail_grunt_i(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_j
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[110];
            public Squad_jail_grunt_j(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_k
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[111];
            public Squad_jail_grunt_k(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[112];
            public Squad_jail_grunt_l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_grunt_m
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[113];
            public Squad_jail_grunt_m(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[114];
            public Squad_jail_jackal_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[115];
            public Squad_jail_jackal_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[116];
            public Squad_jail_jackal_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_f
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[117].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[117].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[117];
            public Squad_jail_jackal_f(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_g
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[118].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[118].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[118];
            public Squad_jail_jackal_g(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_i
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[119];
            public Squad_jail_jackal_i(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_j
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[120];
            public Squad_jail_jackal_j(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_k
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[121].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[121].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[121];
            public Squad_jail_jackal_k(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_l
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[122];
            public Squad_jail_jackal_l(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_jail_jackal_m
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[123];
            public Squad_jail_jackal_m(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________CORRIDORS_B_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[124];
            public Squad________CORRIDORS_B_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_b_marines
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[125].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[125];
            public Squad_room_b_marines(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_b_brutes_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[126].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[126];
            public Squad_room_b_brutes_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_b_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[127];
            public Squad_room_b_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_room_b_buggers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[4];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[5];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[6];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[7];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[8];
            public IAiActorDefinition starting_locations_12 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[9];
            public IAiActorDefinition starting_locations_13 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[10];
            public IAiActorDefinition starting_locations_14 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[11];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[128];
            public Squad_room_b_buggers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[129];
            public Squad_hall_c_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_buggers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[130].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[130];
            public Squad_hall_c_buggers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_brute_reins
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[131];
            public Squad_hall_c_brute_reins(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_bugger_reins
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[132];
            public Squad_hall_c_bugger_reins(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_d_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[133];
            public Squad_hall_d_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_d_brutes
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[134];
            public Squad_hall_d_brutes(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_d_jackals_fr
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[135];
            public Squad_hall_d_jackals_fr(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_d_jackals_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[136].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[136].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[136];
            public Squad_hall_d_jackals_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grand_b_hunter_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[137].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[137];
            public Squad_grand_b_hunter_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_grand_b_hunter_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[138];
            public Squad_grand_b_hunter_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________EXT_A_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[139];
            public Squad________EXT_A_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_jackal_snipers_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[140].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[140];
            public Squad_ext_a_jackal_snipers_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_jackal_snipers_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[141];
            public Squad_ext_a_jackal_snipers_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_jackal_snipers_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[142].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[142];
            public Squad_ext_a_jackal_snipers_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_jackal_snipers_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[143].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[143];
            public Squad_ext_a_jackal_snipers_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_watch_brutes
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[144];
            public Squad_ext_a_watch_brutes(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_watch_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[145];
            public Squad_ext_a_watch_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_hunters
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[146].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[146];
            public Squad_ext_a_hunters(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_brute_door
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[147].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[147].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[147].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[147];
            public Squad_ext_a_brute_door(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_elite_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[148];
            public Squad_ext_a_elite_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_brute_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[149];
            public Squad_ext_a_brute_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_rangers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[150].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[150].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[150];
            public Squad_ext_a_rangers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_buggers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[151].StartingLocations[11];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[151];
            public Squad_ext_a_buggers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_brute_bk_door
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[152].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[152];
            public Squad_ext_a_brute_bk_door(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_buggers_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[153];
            public Squad_ext_a_buggers_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_brutes_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[154];
            public Squad_ext_a_brutes_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________GARDEN_A_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[155];
            public Squad________GARDEN_A_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[156];
            public Squad_garden_a_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[157];
            public Squad_garden_a_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_brute_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[158].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[158].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[158];
            public Squad_garden_a_brute_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_brute_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[159].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[159].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[159];
            public Squad_garden_a_brute_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_jackal_snipers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[160];
            public Squad_garden_a_jackal_snipers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_buggers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[161];
            public Squad_garden_a_buggers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_brute_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[162];
            public Squad_garden_a_brute_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_brute_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[163].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[163];
            public Squad_garden_a_brute_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_brute_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[164].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[164];
            public Squad_garden_a_brute_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_elite_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[165];
            public Squad_garden_a_elite_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_elite_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[166].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[166];
            public Squad_garden_a_elite_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_elite_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[167].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[167];
            public Squad_garden_a_elite_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_rangers
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[168].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[168].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[168];
            public Squad_garden_a_rangers(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_elites_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[169].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[169].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[169];
            public Squad_garden_a_elites_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_grunts_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[170].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[170].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[170];
            public Squad_garden_a_grunts_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_jackals_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[171].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[171].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[171].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[171];
            public Squad_garden_a_jackals_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_a_brutes_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[172].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[172].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[172];
            public Squad_garden_a_brutes_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________MID_TOWER_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[173];
            public Squad________MID_TOWER_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_midtower_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[174].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[174].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[174];
            public Squad_midtower_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_midtower_elites
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[175].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[175].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[175].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[175].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[175];
            public Squad_midtower_elites(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_midtower_elite_reins
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[176].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[176].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[176].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[176];
            public Squad_midtower_elite_reins(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_mid_tower_hunters
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[177];
            public Squad_mid_tower_hunters(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_midtower_buggers_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[11];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[12];
            public IAiActorDefinition starting_locations_12 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[13];
            public IAiActorDefinition starting_locations_13 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[14];
            public IAiActorDefinition starting_locations_14 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[15];
            public IAiActorDefinition starting_locations_15 => ScenarioTag.AiSquadDefinitions[178].StartingLocations[16];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[178];
            public Squad_midtower_buggers_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_midtower_bugger_rein
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[11];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[12];
            public IAiActorDefinition starting_locations_12 => ScenarioTag.AiSquadDefinitions[179].StartingLocations[13];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[179];
            public Squad_midtower_bugger_rein(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_midtower_brutes
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[180].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[180];
            public Squad_midtower_brutes(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_midtower_jackals
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[181].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[181].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[181];
            public Squad_midtower_jackals(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_midtower_buggers_hall
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[182].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[182].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[182];
            public Squad_midtower_buggers_hall(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________GARDEN_B_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[183];
            public Squad________GARDEN_B_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_b_grunt_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[184].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[184].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[184].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[184].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[184];
            public Squad_garden_b_grunt_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_b_grunt_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[185].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[185].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[185].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[185].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[185];
            public Squad_garden_b_grunt_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_b_grunt_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[186].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[186].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[186].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[186].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[186];
            public Squad_garden_b_grunt_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_garden_b_brute_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[187].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[187].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[187].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[187].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[187];
            public Squad_garden_b_brute_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________EXT_B_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[188];
            public Squad________EXT_B_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_brute_ramp
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[189].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[189].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[189].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[189];
            public Squad_ext_b_brute_ramp(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_elite_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[190].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[190];
            public Squad_ext_b_elite_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_brute_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[191].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[191];
            public Squad_ext_b_brute_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_grunts_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[192].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[192];
            public Squad_ext_b_grunts_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_brutes_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[193].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[193].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[193];
            public Squad_ext_b_brutes_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_grunts_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[194].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[194].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[194].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[194].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[194].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[194];
            public Squad_ext_b_grunts_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_brutes_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[195].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[195].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[195];
            public Squad_ext_b_brutes_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_jackal_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[196].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[196];
            public Squad_ext_b_jackal_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_grunt_bk_door
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[197].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[197];
            public Squad_ext_b_grunt_bk_door(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_elites_bk_door
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[198].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[198].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[198].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[198].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[198];
            public Squad_ext_b_elites_bk_door(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_elites_stealth
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[199].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[199].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[199];
            public Squad_ext_b_elites_stealth(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_grunts_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[200].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[200].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[200].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[200].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[200];
            public Squad_ext_b_grunts_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_brutes_low_door
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[201].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[201].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[201].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[201].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[201].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[201].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[201].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[201].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[201];
            public Squad_ext_b_brutes_low_door(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_jackal_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[202];
            public Squad_ext_b_jackal_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_jackal_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[203];
            public Squad_ext_b_jackal_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_cov_dump
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[204];
            public Squad_ext_b_cov_dump(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_b_prophet_dump
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[205];
            public Squad_ext_b_prophet_dump(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad________MAUSOLEUM_______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[206];
            public Squad________MAUSOLEUM_______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_hall_elites_stealth
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[207].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[207].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[207];
            public Squad_maus_hall_elites_stealth(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_hall_grunts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[208].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[208].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[208].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[208].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[208].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[208].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[208];
            public Squad_maus_hall_grunts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_elite_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[209].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[209];
            public Squad_maus_room_elite_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_elite_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[210].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[210];
            public Squad_maus_room_elite_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_grunt_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[211].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[211].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[211].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[211].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[211].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[211];
            public Squad_maus_room_grunt_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_grunt_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[212].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[212].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[212].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[212].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[212].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[212].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[212];
            public Squad_maus_room_grunt_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_brute_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[213].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[213].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[213].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[213];
            public Squad_maus_room_brute_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_jackal_bk_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[214].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[214].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[214];
            public Squad_maus_room_jackal_bk_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_jackal_bk_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[215].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[215].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[215];
            public Squad_maus_room_jackal_bk_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_lt_elite_reins
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[216].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[216];
            public Squad_maus_room_lt_elite_reins(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_rt_elite_reins
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[217].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[217];
            public Squad_maus_room_rt_elite_reins(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_lt_grunt_reins
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[218].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[218].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[218].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[218];
            public Squad_maus_room_lt_grunt_reins(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_room_rt_grunt_reins
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[219].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[219].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[219].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[219];
            public Squad_maus_room_rt_grunt_reins(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_elite_turret
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[220].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[220].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[220].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[220];
            public Squad_maus_bridge_elite_turret(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_elites_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[221].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[221].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[221].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[221].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[221];
            public Squad_maus_bridge_elites_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_elite_rein
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[222].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[222].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[222];
            public Squad_maus_bridge_elite_rein(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_grunt_rein
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[223].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[223].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[223].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[223].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[223];
            public Squad_maus_bridge_grunt_rein(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_grunt_rein_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[224].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[224].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[224].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[224].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[224];
            public Squad_maus_bridge_grunt_rein_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_hunters
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[225].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[225].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[225];
            public Squad_maus_bridge_hunters(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_buggers_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[11];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[226].StartingLocations[12];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[226];
            public Squad_maus_bridge_buggers_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_brutes_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[227].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[227].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[227].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[227];
            public Squad_maus_bridge_brutes_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_bridge_jackals_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[228].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[228].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[228];
            public Squad_maus_bridge_jackals_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_hunters_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[229].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[229].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[229];
            public Squad_maus_inner_hunters_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_elites_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[230].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[230].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[230].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[230];
            public Squad_maus_inner_elites_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_grunts_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[231];
            public Squad_maus_inner_grunts_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[232].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[232].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[232];
            public Squad_maus_inner_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_brutes_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[233].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[233].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[233].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[233];
            public Squad_maus_inner_brutes_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_brutes_rein
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[234].StartingLocations[1];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[234].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[234].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[234].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[234].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[234].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[234];
            public Squad_maus_inner_brutes_rein(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_buggers_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[235].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[235].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[235].StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[235].StartingLocations[4];
            public IAiActorDefinition starting_locations_41 => ScenarioTag.AiSquadDefinitions[235].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[235].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[235];
            public Squad_maus_inner_buggers_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_buggers_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[236].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[236].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[236].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[236].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[236].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[236].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[236];
            public Squad_maus_inner_buggers_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_brutes_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[237].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[237].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[237];
            public Squad_maus_inner_brutes_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_brutes_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[238].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[238].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[238];
            public Squad_maus_inner_brutes_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_brutes_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[239].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[239].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[239];
            public Squad_maus_inner_brutes_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_brutes_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[240].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[240].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[240];
            public Squad_maus_inner_brutes_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_brutes_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[241].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[241].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[241];
            public Squad_maus_inner_brutes_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_brutes_f
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[242].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[242].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[242];
            public Squad_maus_inner_brutes_f(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_elites_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[243].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[243].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[243];
            public Squad_maus_inner_elites_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_elites_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[244].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[244].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[244];
            public Squad_maus_inner_elites_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_elites_f
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[245].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[245].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[245];
            public Squad_maus_inner_elites_f(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_elites_ultra
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[246].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[246].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[246].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[246].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[246];
            public Squad_maus_inner_elites_ultra(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_elites_spec
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[247].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[247].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[247].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[247].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[247];
            public Squad_maus_inner_elites_spec(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_maus_inner_elite_zealot
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[248].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[248].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[248];
            public Squad_maus_inner_elite_zealot(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_244
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[249];
            public Squad_squads_244(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ice_cream_grunt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[250].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[250];
            public Squad_ice_cream_grunt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_c07_infection
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[251].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[251].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[251].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[251].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[251].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[251].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[251].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[251].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[251];
            public Squad_c07_infection(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}