namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_06a_sentinelwalls : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> plugabsorber05 { get; set; }
        public ScenarioEntity<IScenery> plugabsorber06 { get; set; }
        public ScenarioEntity<IScenery> plugabsorber07 { get; set; }
        public ScenarioEntity<IScenery> plugabsorber08 { get; set; }
        public ScenarioEntity<IScenery> johnson_rifle { get; set; }
        public ScenarioEntity<IScenery> miranda_smg_01 { get; set; }
        public ScenarioEntity<IScenery> miranda_smg_02 { get; set; }
        public ScenarioEntity<IScenery> brute_shot_01 { get; set; }
        public ScenarioEntity<IScenery> absorber_e { get; set; }
        public ScenarioEntity<IScenery> absorber_f { get; set; }
        public ScenarioEntity<IScenery> absorber_g { get; set; }
        public ScenarioEntity<IScenery> absorber_h { get; set; }
        public ScenarioEntity<IScenery> absorber_i { get; set; }
        public ScenarioEntity<IScenery> anchor_intro { get; set; }
        public ScenarioEntity<IScenery> absorber_ledge_b { get; set; }
        public ScenarioEntity<IScenery> absorber_ledge_c { get; set; }
        public ScenarioEntity<IScenery> qz_cov_def_sound_a { get; set; }
        public ScenarioEntity<IScenery> qz_cov_def_sound_b { get; set; }
        public ScenarioEntity<IScenery> qz_cov_def_sound_c { get; set; }
        public ScenarioEntity<IScenery> qz_cov_def_sound_d { get; set; }
        public ScenarioEntity<IScenery> qz_cov_def_sound_e { get; set; }
        public ScenarioEntity<IScenery> qz_cov_def_sound_g { get; set; }
        public ScenarioEntity<IScenery> qz_cov_def_sound_f { get; set; }
        public ScenarioEntity<IScenery> phantom_int { get; set; }
        public ScenarioEntity<IScenery> absorber_ins { get; set; }
        public ScenarioEntity<IScenery> absorber_a { get; set; }
        public ScenarioEntity<IScenery> absorber_b { get; set; }
        public ScenarioEntity<IScenery> absorber_c { get; set; }
        public ScenarioEntity<IScenery> absorber_d { get; set; }
        public ScenarioEntity<IScenery> absorber_plug_landing { get; set; }
        public ScenarioEntity<IScenery> anchor_x06 { get; set; }
        public ScenarioEntity<IScenery> delta_halo { get; set; }
        public ScenarioEntity<IScenery> matte_mount_doom { get; set; }
        public ScenarioEntity<IScenery> qz_ini_sound_a { get; set; }
        public ScenarioEntity<IScenery> qz_ini_sound_b { get; set; }
        public ScenarioEntity<IScenery> qz_ini_sound_cave { get; set; }
        public ScenarioEntity<IScenery> texture_camera { get; set; }
        public ScenarioEntity<IScenery> elite_hg_prop_01 { get; set; }
        public ScenarioEntity<IScenery> elite_hg_prop_02 { get; set; }
        public ScenarioEntity<IScenery> elite_hg_prop_03 { get; set; }
        public ScenarioEntity<IScenery> elite_hg_prop_04 { get; set; }
        public ScenarioEntity<IScenery> elite_hg_prop_05 { get; set; }
        public ScenarioEntity<IScenery> elite_hg_prop_06 { get; set; }
        public ScenarioEntity<IScenery> elite_hg_prop_07 { get; set; }
        public ScenarioEntity<IScenery> elite_hg_prop_08 { get; set; }
        public ScenarioEntity<IScenery> carbine { get; set; }
        public ScenarioEntity<IScenery> x06_pike_01 { get; set; }
        public ScenarioEntity<IScenery> x06_pike_02 { get; set; }
        public ScenarioEntity<IScenery> x06_pike_03 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_0 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_1 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_2 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_3 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_11 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_12 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_13 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_14 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_15 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_16 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_17 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_18 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_22 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_23 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_24 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_25 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_26 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_27 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_28 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_29 { get; set; }
        public ScenarioEntity<IBloc> bsp0_crate_30 { get; set; }
        public ScenarioEntity<IScenery> texture_space { get; set; }
        public ScenarioEntity<IScenery> texture_halo { get; set; }
        public ScenarioEntity<IScenery> intro_turret_base { get; set; }
        public ScenarioEntity<IScenery> x06_helmet { get; set; }
        public ScenarioEntity<IScenery> factory_sound { get; set; }
        public ScenarioEntity<IScenery> index_holo { get; set; }
        public ScenarioEntity<IScenery> hall_c_sound { get; set; }
        public ScenarioEntity<IScenery> conduit_b_sound { get; set; }
        public ScenarioEntity<IScenery> matte_substance { get; set; }
        public ScenarioEntity<IScenery> matte_stardust { get; set; }
        public ScenarioEntity<IScenery> offending_column_01 { get; set; }
        public ScenarioEntity<IScenery> offending_column_02 { get; set; }
        public ScenarioEntity<IScenery> offending_column_03 { get; set; }
        public ScenarioEntity<IScenery> offending_column_04 { get; set; }
        public ScenarioEntity<IScenery> offending_column_05 { get; set; }
        public ScenarioEntity<IScenery> offending_column_06 { get; set; }
        public ScenarioEntity<IScenery> offending_column_07 { get; set; }
        public ScenarioEntity<IScenery> offending_column_08 { get; set; }
        public ScenarioEntity<IScenery> offending_column_09 { get; set; }
        public ScenarioEntity<IScenery> offending_column_10 { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> truth { get; set; }
        public ScenarioEntity<IUnit> mercy { get; set; }
        public ScenarioEntity<IUnit> commander { get; set; }
        public ScenarioEntity<IUnit> so_elite_01 { get; set; }
        public ScenarioEntity<IUnit> so_elite_02 { get; set; }
        public ScenarioEntity<IUnit> brute_hg_01 { get; set; }
        public ScenarioEntity<IUnit> brute_hg_02 { get; set; }
        public ScenarioEntity<IUnit> dervish { get; set; }
        public ScenarioEntity<IUnit> brute_hg_03 { get; set; }
        public ScenarioEntity<IUnit> brute_01 { get; set; }
        public ScenarioEntity<IUnit> brute_02 { get; set; }
        public ScenarioEntity<IUnit> brute_03 { get; set; }
        public ScenarioEntity<IUnit> brute_04 { get; set; }
        public ScenarioEntity<IUnit> elite_hg_01 { get; set; }
        public ScenarioEntity<IUnit> elite_hg_02 { get; set; }
        public ScenarioEntity<IUnit> monitor { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_2 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_3 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_4 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_5 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_6 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_7 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_8 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_9 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_10 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_11 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_12 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_13 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_14 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_15 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_16 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_17 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_18 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_19 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_20 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_22 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_23 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_24 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_25 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_27 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_28 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_29 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_30 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_31 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_32 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_33 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_34 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_36 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_37 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_39 { get; set; }
        public ScenarioEntity<IUnit> bsp0_body_40 { get; set; }
        public ScenarioEntity<IVehicle> throne_truth { get; set; }
        public ScenarioEntity<IVehicle> throne_mercy { get; set; }
        public ScenarioEntity<IVehicle> phantom_01 { get; set; }
        public ScenarioEntity<IVehicle> ins_em_a { get; set; }
        public ScenarioEntity<IVehicle> ins_em_b { get; set; }
        public ScenarioEntity<IVehicle> ins_em_c { get; set; }
        public ScenarioEntity<IVehicle> hall_a_em_c { get; set; }
        public ScenarioEntity<IVehicle> hall_a_em_d { get; set; }
        public ScenarioEntity<IVehicle> hall_a_em_g { get; set; }
        public ScenarioEntity<IVehicle> hall_a_em_h { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_e { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_f { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_h { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_g { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_m { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_n { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_o { get; set; }
        public ScenarioEntity<IVehicle> hall_b_em_f { get; set; }
        public ScenarioEntity<IVehicle> hall_b_em_g { get; set; }
        public ScenarioEntity<IVehicle> hall_b_em_h { get; set; }
        public ScenarioEntity<IVehicle> hall_b_em_d { get; set; }
        public ScenarioEntity<IVehicle> hall_b_em_e { get; set; }
        public ScenarioEntity<IVehicle> hall_b_em_a { get; set; }
        public ScenarioEntity<IVehicle> hall_b_em_b { get; set; }
        public ScenarioEntity<IVehicle> hall_b_em_c { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_a { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_b { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_c { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_d { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_e { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_f { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_g { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_h { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_em_i { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_bk_em_a { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_bk_em_b { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_bk_em_c { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_bk_em_d { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_bk_em_e { get; set; }
        public ScenarioEntity<IVehicle> plug_holder_bk_em_f { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_a { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_c { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_i { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_j { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_k { get; set; }
        public ScenarioEntity<IVehicle> cond_a_em_l { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_a { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_b { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_c { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_d { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_e { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_f { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_g { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_h { get; set; }
        public ScenarioEntity<IVehicle> ledge_a_em_i { get; set; }
        public ScenarioEntity<IVehicle> intro_sen_maj { get; set; }
        public ScenarioEntity<IVehicle> phantom_02 { get; set; }
        public ScenarioEntity<IVehicle> plugabsorber01 { get; set; }
        public ScenarioEntity<IVehicle> plugabsorber02 { get; set; }
        public ScenarioEntity<IVehicle> plugabsorber03 { get; set; }
        public ScenarioEntity<IVehicle> plugabsorber04 { get; set; }
        public ScenarioEntity<IVehicle> plug_launch_em_a { get; set; }
        public ScenarioEntity<IVehicle> plug_launch_em_b { get; set; }
        public ScenarioEntity<IVehicle> plug_launch_em_c { get; set; }
        public ScenarioEntity<IVehicle> plug_launch_em_d { get; set; }
        public ScenarioEntity<IVehicle> plug_launch_em_e { get; set; }
        public ScenarioEntity<IVehicle> plug_launch_em_f { get; set; }
        public ScenarioEntity<IVehicle> plug_launch_em_g { get; set; }
        public ScenarioEntity<IVehicle> plug_launch_em_h { get; set; }
        public ScenarioEntity<IVehicle> cond_b_em_b { get; set; }
        public ScenarioEntity<IVehicle> cond_b_em_a { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_0 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_1 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_2 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_3 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_4 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_5 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_6 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_7 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_8 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_9 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_10 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_11 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_12 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_13 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_14 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_15 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_16 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_17 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_18 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_19 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_20 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_21 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_22 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_23 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_24 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_25 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_26 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_27 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_28 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_29 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_30 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_31 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_32 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_33 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_34 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_35 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_36 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_37 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_38 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_39 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_40 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_41 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_42 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_43 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_44 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp0_equip_45 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_0 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_1 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_2 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_3 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_4 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_5 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_6 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_7 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_8 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_9 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_10 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_11 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_12 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_13 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_14 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_15 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_16 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_17 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_18 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_19 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_20 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_21 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_22 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_23 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_24 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_25 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_26 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_27 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_28 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_29 { get; set; }
        public ScenarioEntity<IStartingProfile> bsp1_equip_30 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_1 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_2 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_3 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_4 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_5 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_6 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_7 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_8 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_9 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_10 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_11 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_12 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_13 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_14 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_15 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_16 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_17 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_18 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_19 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_20 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_22 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_23 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_24 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_25 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_26 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_27 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_28 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_29 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_30 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_31 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_32 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_33 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_34 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_35 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_36 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_37 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_38 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_39 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_40 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_41 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_42 { get; set; }
        public ScenarioEntity<IWeapon> bsp0_weapon_43 { get; set; }
        public ScenarioEntity<IWeapon> intro_turret { get; set; }
        public ScenarioEntity<IWeapon> ice_cream_head { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_0 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_1 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_2 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_3 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_4 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_5 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_6 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_7 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_8 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_9 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_10 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_11 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_12 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_13 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_14 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_15 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_16 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_17 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_18 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_19 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_20 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_21 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_22 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_23 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_24 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_25 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_26 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_27 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_28 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_29 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_30 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_31 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_32 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_33 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_34 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_35 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_36 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_37 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_38 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_39 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_40 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_41 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_42 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_43 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_44 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_45 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_46 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_47 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_48 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_49 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_50 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_51 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_52 { get; set; }
        public ScenarioEntity<IWeapon> bsp1_weapon_53 { get; set; }
        public ScenarioEntity<ISound> plug_doors_open { get; set; }
        public ScenarioEntity<ISound> plug_doors_closed { get; set; }
        public ScenarioEntity<IDevice> plug_switch { get; set; }
        public ScenarioEntity<IDevice> plug { get; set; }
        public ScenarioEntity<IDevice> plug_keylock_c { get; set; }
        public ScenarioEntity<IDevice> plug_keylock_d { get; set; }
        public ScenarioEntity<IDevice> plug_thick_fr { get; set; }
        public ScenarioEntity<IDevice> plug_thick_br { get; set; }
        public ScenarioEntity<IDevice> plug_thick_bl { get; set; }
        public ScenarioEntity<IDevice> plug_thick_fl { get; set; }
        public ScenarioEntity<IDevice> plug_thin_br { get; set; }
        public ScenarioEntity<IDevice> plug_thin_bl { get; set; }
        public ScenarioEntity<IDevice> plug_thin_fl { get; set; }
        public ScenarioEntity<IDevice> plug_thin_fr { get; set; }
        public ScenarioEntity<IDevice> piston_a { get; set; }
        public ScenarioEntity<IDevice> piston_b { get; set; }
        public ScenarioEntity<IDevice> piston_c { get; set; }
        public ScenarioEntity<IDevice> piston_d { get; set; }
        public ScenarioEntity<IDevice> piston_e { get; set; }
        public ScenarioEntity<IDevice> piston_f { get; set; }
        public ScenarioEntity<IDevice> piston_h { get; set; }
        public ScenarioEntity<IDevice> tower_a_base { get; set; }
        public ScenarioEntity<IDevice> tower_a_pod { get; set; }
        public ScenarioEntity<IDevice> tower_b_base { get; set; }
        public ScenarioEntity<IDevice> tower_b_pod { get; set; }
        public ScenarioEntity<IDevice> piston_ins { get; set; }
        public ScenarioEntity<IDevice> plug_lock_a { get; set; }
        public ScenarioEntity<IDevice> plug_lock_b { get; set; }
        public ScenarioEntity<IDevice> plug_lock_c { get; set; }
        public ScenarioEntity<IDevice> plug_lock_d { get; set; }
        public ScenarioEntity<IDevice> plug_lock_e { get; set; }
        public ScenarioEntity<IDevice> plug_lock_f { get; set; }
        public ScenarioEntity<IDevice> piston_plug_landing { get; set; }
        public ScenarioEntity<IDevice> qz_door { get; set; }
        public ScenarioEntity<IDevice> plugholder_door { get; set; }
        public ScenarioEntity<IDevice> qz_ent_pod_a { get; set; }
        public ScenarioEntity<IDevice> qz_ent_pod_b { get; set; }
        public ScenarioEntity<IDevice> qz_ent_pod_c { get; set; }
        public ScenarioEntity<IDevice> qz_ent_pod_d { get; set; }
        public ScenarioEntity<IDevice> qz_ent_pod_e { get; set; }
        public ScenarioEntity<IDevice> piston_ledge_b { get; set; }
        public ScenarioEntity<IDevice> piston_ledge_c { get; set; }
        public ScenarioEntity<IDevice> piston_i { get; set; }
        public ScenarioEntity<IDevice> piston_g { get; set; }
        public ScenarioEntity<IDevice> ledge_a_door_a { get; set; }
        public ScenarioEntity<IDevice> ledge_a_door_b { get; set; }
        public ScenarioEntity<IDevice> ledge_a_door_c { get; set; }
        public ScenarioEntity<IDevice> ledge_a_door_d { get; set; }
        public ScenarioEntity<IDevice> ledge_a_door_e { get; set; }
        public ScenarioEntity<IDevice> ledge_a_door_f { get; set; }
        public ScenarioEntity<IDevice> plug_door_a { get; set; }
        public ScenarioEntity<IDevice> plug_door_b { get; set; }
        public ScenarioEntity<IDevice> containment_field { get; set; }
        public ScenarioEntity<IDevice> sanctum_door { get; set; }
        public ScenarioEntity<IDevice> plug_switch_housing { get; set; }
        public ScenarioEntity<IDevice> factory { get; set; }
        public ScenarioEntity<IDevice> ins_switch_a { get; set; }
        public ScenarioEntity<IDevice> ins_switch_b { get; set; }
        public ScenarioEntity<IDevice> ins_switch_c { get; set; }
        public ScenarioEntity<IDevice> ins_switch_d { get; set; }
        public ScenarioEntity<IDevice> a_switch_a { get; set; }
        public ScenarioEntity<IDevice> a_switch_b { get; set; }
        public ScenarioEntity<IDevice> a_switch_c { get; set; }
        public ScenarioEntity<IDevice> a_switch_d { get; set; }
        public ScenarioEntity<IDevice> b_switch_a { get; set; }
        public ScenarioEntity<IDevice> b_switch_b { get; set; }
        public ScenarioEntity<IDevice> b_switch_c { get; set; }
        public ScenarioEntity<IDevice> b_switch_d { get; set; }
        public ScenarioEntity<IDevice> c_switch_a { get; set; }
        public ScenarioEntity<IDevice> c_switch_b { get; set; }
        public ScenarioEntity<IDevice> c_switch_c { get; set; }
        public ScenarioEntity<IDevice> c_switch_d { get; set; }
        public ScenarioEntity<IDevice> d_switch_a { get; set; }
        public ScenarioEntity<IDevice> d_switch_b { get; set; }
        public ScenarioEntity<IDevice> d_switch_c { get; set; }
        public ScenarioEntity<IDevice> d_switch_d { get; set; }
        public ScenarioEntity<IDevice> plug_landing_switch_a { get; set; }
        public ScenarioEntity<IDevice> plug_landing_switch_b { get; set; }
        public ScenarioEntity<IDevice> plug_landing_switch_c { get; set; }
        public ScenarioEntity<IDevice> plug_landing_switch_d { get; set; }
        public ScenarioEntity<IDevice> e_switch_a { get; set; }
        public ScenarioEntity<IDevice> e_switch_b { get; set; }
        public ScenarioEntity<IDevice> e_switch_c { get; set; }
        public ScenarioEntity<IDevice> e_switch_d { get; set; }
        public ScenarioEntity<IDevice> f_switch_a { get; set; }
        public ScenarioEntity<IDevice> f_switch_b { get; set; }
        public ScenarioEntity<IDevice> f_switch_c { get; set; }
        public ScenarioEntity<IDevice> f_switch_d { get; set; }
        public ScenarioEntity<IDevice> g_switch_a { get; set; }
        public ScenarioEntity<IDevice> g_switch_b { get; set; }
        public ScenarioEntity<IDevice> g_switch_c { get; set; }
        public ScenarioEntity<IDevice> g_switch_d { get; set; }
        public ScenarioEntity<IDevice> h_switch_a { get; set; }
        public ScenarioEntity<IDevice> h_switch_b { get; set; }
        public ScenarioEntity<IDevice> h_switch_c { get; set; }
        public ScenarioEntity<IDevice> h_switch_d { get; set; }
        public ScenarioEntity<IDevice> i_switch_a { get; set; }
        public ScenarioEntity<IDevice> i_switch_b { get; set; }
        public ScenarioEntity<IDevice> i_switch_c { get; set; }
        public ScenarioEntity<IDevice> i_switch_d { get; set; }
        public ScenarioEntity<IDevice> ledge_b_switch_a { get; set; }
        public ScenarioEntity<IDevice> ledge_b_switch_b { get; set; }
        public ScenarioEntity<IDevice> ledge_b_switch_c { get; set; }
        public ScenarioEntity<IDevice> ledge_b_switch_d { get; set; }
        public ScenarioEntity<IDevice> ledge_c_switch_a { get; set; }
        public ScenarioEntity<IDevice> ledge_c_switch_b { get; set; }
        public ScenarioEntity<IDevice> ledge_c_switch_c { get; set; }
        public ScenarioEntity<IDevice> ledge_c_switch_d { get; set; }
        public ScenarioEntity<IDevice> plug_switch_d { get; set; }
        public ScenarioEntity<IDevice> plug_switch_a { get; set; }
        public ScenarioEntity<IDevice> plug_switch_b { get; set; }
        public ScenarioEntity<IDevice> plug_switch_c { get; set; }
        public ICameraPathTarget test => Scenario.CameraPathTargets[0].GameObject;
        public ICameraPathTarget texture_camera1 => Scenario.CameraPathTargets[1].GameObject;
        public Squad_pussy_grunt1 pussy_grunt1 { get; set; }
        public Squad_ins_con_mid ins_con_mid { get; set; }
        public Squad_ins_con_bk ins_con_bk { get; set; }
        public Squad_insertion_sen insertion_sen { get; set; }
        public Squad_ins_con_slide ins_con_slide { get; set; }
        public Squad_hall_a_con_ini hall_a_con_ini { get; set; }
        public Squad_hall_a_con_bk hall_a_con_bk { get; set; }
        public Squad_hall_a_sen hall_a_sen { get; set; }
        public Squad_cond_a_cov cond_a_cov { get; set; }
        public Squad_cond_a_sen_ini cond_a_sen_ini { get; set; }
        public Squad_cond_a_sen_a cond_a_sen_a { get; set; }
        public Squad_cond_a_sen_b cond_a_sen_b { get; set; }
        public Squad_hall_b_cov hall_b_cov { get; set; }
        public Squad_hall_b_sen hall_b_sen { get; set; }
        public Squad_plug_launch_cov plug_launch_cov { get; set; }
        public Squad_plug_launch_enforcer plug_launch_enforcer { get; set; }
        public Squad_plug_launch_sen plug_launch_sen { get; set; }
        public Squad_gap_phantom gap_phantom { get; set; }
        public Squad_gap_flood_lt gap_flood_lt { get; set; }
        public Squad_gap_flood_rt gap_flood_rt { get; set; }
        public Squad_plug_holder_sen plug_holder_sen { get; set; }
        public Squad_plug_holder_sen_elim plug_holder_sen_elim { get; set; }
        public Squad_plug_holder_bk_sen plug_holder_bk_sen { get; set; }
        public Squad_plug_holder_enforcer plug_holder_enforcer { get; set; }
        public Squad_plugholder_sen_bk_ini plugholder_sen_bk_ini { get; set; }
        public Squad_plug_holder_flood_a plug_holder_flood_a { get; set; }
        public Squad_plug_holder_flood_b plug_holder_flood_b { get; set; }
        public Squad_plug_holder_flood_c plug_holder_flood_c { get; set; }
        public Squad_plug_holder_flood_d plug_holder_flood_d { get; set; }
        public Squad_plugholder_inf plugholder_inf { get; set; }
        public Squad_plugholder_bk_flood_a plugholder_bk_flood_a { get; set; }
        public Squad_plugholder_bk_flood_b plugholder_bk_flood_b { get; set; }
        public Squad_plugholder_bk_infec_a plugholder_bk_infec_a { get; set; }
        public Squad_plugholder_bk_infec_b plugholder_bk_infec_b { get; set; }
        public Squad_plugholder_lower_hall_flood plugholder_lower_hall_flood { get; set; }
        public Squad_plugholder_lower_hall_infec plugholder_lower_hall_infec { get; set; }
        public Squad_hall_c_marines hall_c_marines { get; set; }
        public Squad_hall_c_infec hall_c_infec { get; set; }
        public Squad_hall_c_flood_near hall_c_flood_near { get; set; }
        public Squad_hall_c_flood_mid hall_c_flood_mid { get; set; }
        public Squad_hall_c_flood_far hall_c_flood_far { get; set; }
        public Squad_hall_c_flood_c hall_c_flood_c { get; set; }
        public Squad_hall_c_flood_d hall_c_flood_d { get; set; }
        public Squad_hall_c_flood_e hall_c_flood_e { get; set; }
        public Squad_hall_c_flood_f hall_c_flood_f { get; set; }
        public Squad_hall_c_carrier_c hall_c_carrier_c { get; set; }
        public Squad_hall_c_carrier_d hall_c_carrier_d { get; set; }
        public Squad_hall_c_carrier_e hall_c_carrier_e { get; set; }
        public Squad_hall_c_sen_tube hall_c_sen_tube { get; set; }
        public Squad_hall_c_em_sen hall_c_em_sen { get; set; }
        public Squad_ledge_a_enforcer ledge_a_enforcer { get; set; }
        public Squad_ledge_a_sen_ini ledge_a_sen_ini { get; set; }
        public Squad_ledge_a_sen ledge_a_sen { get; set; }
        public Squad_ledge_a_flood_ini ledge_a_flood_ini { get; set; }
        public Squad_ledge_a_flood_b ledge_a_flood_b { get; set; }
        public Squad_ledge_a_flood_c ledge_a_flood_c { get; set; }
        public Squad_ledge_a_flood_d1 ledge_a_flood_d1 { get; set; }
        public Squad_ledge_a_flood_d2 ledge_a_flood_d2 { get; set; }
        public Squad_ledge_a_flood_e ledge_a_flood_e { get; set; }
        public Squad_ledge_a_flood_f ledge_a_flood_f { get; set; }
        public Squad_ledge_a_flood_bot_a ledge_a_flood_bot_a { get; set; }
        public Squad_ledge_a_flood_bot_b ledge_a_flood_bot_b { get; set; }
        public Squad_cond_b_flood_tube_a cond_b_flood_tube_a { get; set; }
        public Squad_cond_b_flood_a_ini_a cond_b_flood_a_ini_a { get; set; }
        public Squad_cond_b_flood_a_ini_b cond_b_flood_a_ini_b { get; set; }
        public Squad_cond_b_flood_a_ini_c cond_b_flood_a_ini_c { get; set; }
        public Squad_cond_b_carrier_a cond_b_carrier_a { get; set; }
        public Squad_cond_b_flood_a cond_b_flood_a { get; set; }
        public Squad_cond_b_flood_b cond_b_flood_b { get; set; }
        public Squad_cond_b_flood_c cond_b_flood_c { get; set; }
        public Squad_cond_b_enforcer cond_b_enforcer { get; set; }
        public Squad_cond_b_flood_b_ini cond_b_flood_b_ini { get; set; }
        public Squad_cond_b_flood_c_ini_a cond_b_flood_c_ini_a { get; set; }
        public Squad_cond_b_flood_c_ini_b cond_b_flood_c_ini_b { get; set; }
        public Squad_cond_b_humans cond_b_humans { get; set; }
        public Squad_cond_b_infection_c cond_b_infection_c { get; set; }
        public Squad_cond_b_sen_b cond_b_sen_b { get; set; }
        public Squad_cond_b_sen_tube_b cond_b_sen_tube_b { get; set; }
        public Squad_ledge_c_flood_dead ledge_c_flood_dead { get; set; }
        public Squad_ledge_c_flood_fr ledge_c_flood_fr { get; set; }
        public Squad_ledge_c_flood_bk ledge_c_flood_bk { get; set; }
        public Squad_ledge_c_infec_fr ledge_c_infec_fr { get; set; }
        public Squad_ledge_c_infec_bk ledge_c_infec_bk { get; set; }
        public Squad_qz_initial_flood_ini qz_initial_flood_ini { get; set; }
        public Squad_qz_initial_flood_carrier_ini qz_initial_flood_carrier_ini { get; set; }
        public Squad_qz_initial_flood_bridge qz_initial_flood_bridge { get; set; }
        public Squad_qz_initial_flood_camp qz_initial_flood_camp { get; set; }
        public Squad_qz_initial_flood_carrier_camp qz_initial_flood_carrier_camp { get; set; }
        public Squad_qz_initial_flood_cave qz_initial_flood_cave { get; set; }
        public Squad_qz_ini_ins_pods qz_ini_ins_pods { get; set; }
        public Squad_qz_cov_def_flood_ini qz_cov_def_flood_ini { get; set; }
        public Squad_qz_cov_def_flood_a qz_cov_def_flood_a { get; set; }
        public Squad_qz_cov_def_flood_b qz_cov_def_flood_b { get; set; }
        public Squad_qz_cov_def_flood_c qz_cov_def_flood_c { get; set; }
        public Squad_qz_cov_def_flood_d qz_cov_def_flood_d { get; set; }
        public Squad_qz_cov_def_flood_e qz_cov_def_flood_e { get; set; }
        public Squad_qz_cov_def_flood_f qz_cov_def_flood_f { get; set; }
        public Squad_qz_cov_def_flood_g qz_cov_def_flood_g { get; set; }
        public Squad_qz_cov_def_carrier qz_cov_def_carrier { get; set; }
        public Squad_qz_cov_def_soc qz_cov_def_soc { get; set; }
        public Squad_qz_cov_def_cov qz_cov_def_cov { get; set; }
        public Squad_qz_ini_turrets qz_ini_turrets { get; set; }
        public Squad_qz_camp_turrets qz_camp_turrets { get; set; }
        public Squad_ledge_c_phantom ledge_c_phantom { get; set; }
        public Squad_ledge_b_sen ledge_b_sen { get; set; }
        public Squad_ledge_b_flood ledge_b_flood { get; set; }
        public Squad_ledge_a_flood_dead ledge_a_flood_dead { get; set; }
        public Squad_qz_phantom qz_phantom { get; set; }
        public Squad_brutes_01 brutes_01 { get; set; }
        public Squad_brutes_02 brutes_02 { get; set; }
        public Squad_elites_01 elites_01 { get; set; }
        public Squad_elites_02 elites_02 { get; set; }
        public Squad_elites_03 elites_03 { get; set; }
        public IAiActorDefinition enemies => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition constructors => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition sentinels => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition flood => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition covenant1 => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition humans => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition insertion_sentinels => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition ins_cons => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition hall_a_sentinels => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition hall_a_cons => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition cond_a_sentinels => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition hall_b_sentinels => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition plug_launch_sentinels => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition plug_holder_sentinels => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition plug_holder_sentinels_bk => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition plug_holder_flood => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition plug_holder_flood_bk => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition hall_c_sentinels => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition hall_c_flood => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition ledge_a_flood => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition ledge_a_sentinels => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition cond_b_flood => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition cond_b_sentinels => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition ledge_c_flood => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition qz_ini_flood => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition qz_cov_def_flood => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition hall_c_flood_carrier => Scenario.AiSquadGroupDefinitions[26];
        public IAiOrders ins_bk => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders ins_mid => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders ins_top => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders ins_all => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders ins_sen_slide => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders ins_run_away => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders hall_a_all => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders hall_a_beam => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders hall_a_constructors => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders hall_a_runway => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders cond_a_cov_ini => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders cond_a_cov_follow => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders cond_a_sen_ini1 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders cond_a_sen_follow => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders hall_b_all => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders hall_b_cov_ini => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders hall_b_cov_follow => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders plug_launch_cov_ini => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders plug_launch_cov_follow => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders plug_launch_sen_high => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders plug_launch_sen_low => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders plug_launch_enf_high => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders plug_launch_enf_low => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders plug_cov => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders plug_cov_all => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders gap_phantom1 => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders gap_flood => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders plugholder_sen => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders plugholder_sen_eliminator => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders plugholder_enforcer_ini => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders plugholder_enforcer => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders plugholder_enforcer_bk => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders plugholder_sen_ini => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders plugholder_sen_bk => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders plugholder_flood => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders plugholder_flood_bk => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders plugholder_lower_hall => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders hall_c_marines1 => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders hall_c_flood_ini => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders hall_c_sen_tube1 => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders hall_c_floor_follow => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders hall_c_sen_follow => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders hall_c_floor_b => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders hall_c_floor_c => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders hall_c_floor_d => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders hall_c_floor_e => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders ledge_a_enf_lt => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders ledge_a_enf_rt => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders ledge_a_sen_ini1 => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders ledge_a_sen_bot_a => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders ledge_a_sen_bot_b => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders ledge_a_sen_follow => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders ledge_a_flood_ini1 => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders ledge_a_flood_d_fr => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders ledge_a_flood_d_bk => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders ledge_a_flood_bot_a1 => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders ledge_a_flood_bot_b1 => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders ledge_a_floor_follow => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders cond_b_flood_a_ini_a1 => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders cond_b_flood_a_ini_b1 => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders cond_b_flood_a_ini_c1 => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders cond_b_floor_follow_a => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders cond_b_floor_follow_b => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders cond_b_floor_follow_c => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders cond_b_sen_b_ini => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders cond_b_sen_tube_b1 => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders cond_b_humans1 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders cond_b_flood_c_ini_a1 => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders cond_b_flood_c_ini_b1 => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders cond_b_enforcer1 => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders cond_b_flood_b_ini1 => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders ledge_a_flood_fr => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders ledge_c_flood_fr_retreat => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders ledge_a_flood_bk => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders qz_flood_ini => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders qz_ini_flood_b => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders qz_initial_bridge => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders qz_initial_camp => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders qz_initial_cave => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders qz_ini_spec_elites => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders qz_cov_def_flood_a1 => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders qz_cov_def_flood_b1 => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders qz_cov_def_flood_c1 => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders qz_cov_def_flood_d1 => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders qz_cov_def_flood_e1 => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders qz_cov_def_flood_f1 => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders qz_cov_def_flood_g1 => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders qz_cov_def_hill => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders qz_cov_def_cov_a => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders qz_cov_def_cov_b => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders qz_cov_def_cov_c => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders qz_cov_def_cov_ab => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders qz_cov_def_cov_bc => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders qz_cov_def_cov_ac => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders qz_cov_def_cov_tower => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders qz_cov_def_carrier1 => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders qz_cov_def_follow => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders qz_cov_def_jugg_ini => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders cond_b_tube_b => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders test1 => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders pussy_grunt2 => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders hall_a_cov => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders ledge_b_sen1 => Scenario.AiOrderDefinitions[102].GameObject;
        public ILocationFlag anchor_flag_intro => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[1].GameObject;
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[2].GameObject;
        public ILocationFlag insertion_a => Scenario.LocationFlagDefinitions[3].GameObject;
        public ILocationFlag insertion_b => Scenario.LocationFlagDefinitions[4].GameObject;
        public ILocationFlag hall_a_a => Scenario.LocationFlagDefinitions[5].GameObject;
        public ILocationFlag hall_a_b => Scenario.LocationFlagDefinitions[6].GameObject;
        public ILocationFlag conduit_a_a => Scenario.LocationFlagDefinitions[7].GameObject;
        public ILocationFlag conduit_a_b => Scenario.LocationFlagDefinitions[8].GameObject;
        public ILocationFlag hall_b_a => Scenario.LocationFlagDefinitions[9].GameObject;
        public ILocationFlag hall_b_b => Scenario.LocationFlagDefinitions[10].GameObject;
        public ILocationFlag plug_launch_a => Scenario.LocationFlagDefinitions[11].GameObject;
        public ILocationFlag plug_launch_b => Scenario.LocationFlagDefinitions[12].GameObject;
        public ILocationFlag plug_landing_a => Scenario.LocationFlagDefinitions[13].GameObject;
        public ILocationFlag plug_landing_b => Scenario.LocationFlagDefinitions[14].GameObject;
        public ILocationFlag hall_c_a => Scenario.LocationFlagDefinitions[15].GameObject;
        public ILocationFlag hall_c_b => Scenario.LocationFlagDefinitions[16].GameObject;
        public ILocationFlag ledge_a_a => Scenario.LocationFlagDefinitions[17].GameObject;
        public ILocationFlag ledge_a_b => Scenario.LocationFlagDefinitions[18].GameObject;
        public ILocationFlag conduit_b_a => Scenario.LocationFlagDefinitions[19].GameObject;
        public ILocationFlag conduit_b_b => Scenario.LocationFlagDefinitions[20].GameObject;
        public ILocationFlag ledge_b_a => Scenario.LocationFlagDefinitions[21].GameObject;
        public ILocationFlag ledge_b_b => Scenario.LocationFlagDefinitions[22].GameObject;
        public ILocationFlag ledge_c_a => Scenario.LocationFlagDefinitions[23].GameObject;
        public ILocationFlag ledge_c_b => Scenario.LocationFlagDefinitions[24].GameObject;
        public ILocationFlag qz_initial_a => Scenario.LocationFlagDefinitions[25].GameObject;
        public ILocationFlag qz_initial_b => Scenario.LocationFlagDefinitions[26].GameObject;
        public ILocationFlag cov_defense_a => Scenario.LocationFlagDefinitions[27].GameObject;
        public ILocationFlag cov_defense_b => Scenario.LocationFlagDefinitions[28].GameObject;
        public ILocationFlag mortar_a => Scenario.LocationFlagDefinitions[29].GameObject;
        public ILocationFlag mortar_b => Scenario.LocationFlagDefinitions[30].GameObject;
        public ILocationFlag mortar_c => Scenario.LocationFlagDefinitions[31].GameObject;
        public ILocationFlag mortar_d => Scenario.LocationFlagDefinitions[32].GameObject;
        public ILocationFlag mortar_e => Scenario.LocationFlagDefinitions[33].GameObject;
        public ILocationFlag mortar_f => Scenario.LocationFlagDefinitions[34].GameObject;
        public ILocationFlag anchor_flag_x06 => Scenario.LocationFlagDefinitions[35].GameObject;
        public ILocationFlag cutscene_flags_36 => Scenario.LocationFlagDefinitions[36].GameObject;
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_2 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title_3 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ICinematicTitle cinematic_title0 => Scenario.CinematicTitleDefinitions[3].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume bsp_1_2 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume tv_hall_a => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume tv_conduit_a => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume tv_hall_b => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume tv_plug_launch => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume tv_plug_land => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume tv_hall_c => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume tv_ledge_a => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume tv_conduit_b => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume tv_ledge_b => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume tv_ledge_c => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume tv_qz_initial => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_cov_defense => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume _null => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_ins_fr => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_ins_bk => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_ins_slide_bottom => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_hall_a_fr => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume tv_hall_a_mid => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume tv_hall_a_bk => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume tv_cond_a_a => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume tv_cond_a_b => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume tv_cond_a_c => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_hall_b_fr => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_hall_b_mid => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume tv_hall_b_bk => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_plug_launch_rt_high => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_plug_launch_rt_low => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume tv_plug_launch_lt_high => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume tv_plug_launch_lt_low => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume tv_plugholder_a => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_plugholder_b => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_plugholder_d => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume tv_plugholder_e => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume tv_plugholder_f => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_hall_c_a => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_hall_c_b => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_hall_c_c => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_hall_c_d => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_hall_c_e => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_ledge_a_top_b => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume tv_ledge_a_top_c => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_ledge_a_top_d1 => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume tv_ledge_a_top_d2 => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_ledge_a_top_e => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_ledge_a_top_f => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_ledge_a_top_g => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume tv_ledge_a_bot_a => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume tv_ledge_a_bot_b => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume tv_cond_b_a1 => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume tv_cond_b_a2 => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume tv_cond_b_b1 => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume tv_cond_b_b2 => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume tv_cond_b_c => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume tv_cond_b_hum_dead => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume tv_ledge_c_fr => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume tv_ledge_c_bk => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume tv_qz_camp => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume tv_qz_cave => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume tv_qz_bridge => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume tv_qz_cov_def_hill => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume cond_a_flock_a => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume cond_a_flock_b => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume tv_plug_down => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume gap_flock_b => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume gap_flock_a => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume cond_a_flock_c => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume cond_a_flock_d => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume kill_insertion => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume tv_cond_a_bk => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume tv_piston_a => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume tv_piston_b => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume tv_piston_c => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume tv_piston_d => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume tv_piston_plug_landing => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume tv_piston_e => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume tv_piston_f => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume tv_piston_g => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume tv_piston_h => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume tv_piston_i => Scenario.TriggerVolumes[80].GameObject;
        public ITriggerVolume tv_piston_ledge_b => Scenario.TriggerVolumes[81].GameObject;
        public ITriggerVolume tv_piston_ledge_c => Scenario.TriggerVolumes[82].GameObject;
        public ITriggerVolume tv_piston_ins => Scenario.TriggerVolumes[83].GameObject;
        public ITriggerVolume kill_plug => Scenario.TriggerVolumes[84].GameObject;
        public ITriggerVolume kill_trench => Scenario.TriggerVolumes[85].GameObject;
        public ITriggerVolume kill_qz_a => Scenario.TriggerVolumes[86].GameObject;
        public ITriggerVolume kill_qz_b => Scenario.TriggerVolumes[87].GameObject;
        public ITriggerVolume kill_qz_c => Scenario.TriggerVolumes[88].GameObject;
        public ITriggerVolume kill_qz_d => Scenario.TriggerVolumes[89].GameObject;
        public ITriggerVolume kill_qz_e => Scenario.TriggerVolumes[90].GameObject;
        public ITriggerVolume kill_qz_f => Scenario.TriggerVolumes[91].GameObject;
        public ITriggerVolume tv_pussy_grunt => Scenario.TriggerVolumes[92].GameObject;
        public ITriggerVolume tv_insertion_tube => Scenario.TriggerVolumes[93].GameObject;
        public ITriggerVolume kill_ledge_b => Scenario.TriggerVolumes[94].GameObject;
        public ITriggerVolume kill_ledge_c => Scenario.TriggerVolumes[95].GameObject;
        public ITriggerVolume tv_slide_a => Scenario.TriggerVolumes[96].GameObject;
        public ITriggerVolume tv_slide_b => Scenario.TriggerVolumes[97].GameObject;
        public ITriggerVolume tv_music_06a_10 => Scenario.TriggerVolumes[98].GameObject;
        public ITriggerVolume kill => Scenario.TriggerVolumes[99].GameObject;
        public ITriggerVolume kill1 => Scenario.TriggerVolumes[100].GameObject;
        public ITriggerVolume kill2 => Scenario.TriggerVolumes[101].GameObject;
        public ITriggerVolume kill3 => Scenario.TriggerVolumes[102].GameObject;
        public ITriggerVolume kill4 => Scenario.TriggerVolumes[103].GameObject;
        public ITriggerVolume tv_game_won => Scenario.TriggerVolumes[104].GameObject;
        public ITriggerVolume kill5 => Scenario.TriggerVolumes[105].GameObject;
        public ITriggerVolume kill6 => Scenario.TriggerVolumes[106].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile player_starting_profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IDeviceGroup plug1 => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup plug_door_a1 => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup plug_door_b1 => Scenario.DeviceGroupDefinitions[2].GameObject;
        public IDeviceGroup device_groups_1 => Scenario.DeviceGroupDefinitions[3].GameObject;
        public IDeviceGroup group_ins => Scenario.DeviceGroupDefinitions[4].GameObject;
        public IDeviceGroup group_a => Scenario.DeviceGroupDefinitions[5].GameObject;
        public IDeviceGroup group_b => Scenario.DeviceGroupDefinitions[6].GameObject;
        public IDeviceGroup group_c => Scenario.DeviceGroupDefinitions[7].GameObject;
        public IDeviceGroup group_d => Scenario.DeviceGroupDefinitions[8].GameObject;
        public IDeviceGroup group_plug_landing => Scenario.DeviceGroupDefinitions[9].GameObject;
        public IDeviceGroup group_e => Scenario.DeviceGroupDefinitions[10].GameObject;
        public IDeviceGroup group_f => Scenario.DeviceGroupDefinitions[11].GameObject;
        public IDeviceGroup group_g => Scenario.DeviceGroupDefinitions[12].GameObject;
        public IDeviceGroup group_h => Scenario.DeviceGroupDefinitions[13].GameObject;
        public IDeviceGroup group_i => Scenario.DeviceGroupDefinitions[14].GameObject;
        public IDeviceGroup group_ledge_b => Scenario.DeviceGroupDefinitions[15].GameObject;
        public IDeviceGroup group_ledge_c => Scenario.DeviceGroupDefinitions[16].GameObject;
        public IDeviceGroup group_plug_a => Scenario.DeviceGroupDefinitions[17].GameObject;
        public IDeviceGroup group_plug_b => Scenario.DeviceGroupDefinitions[18].GameObject;
        public IDeviceGroup group_plug_c => Scenario.DeviceGroupDefinitions[19].GameObject;
        public IDeviceGroup group_plug_d => Scenario.DeviceGroupDefinitions[20].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            plugabsorber05 = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            plugabsorber06 = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            plugabsorber07 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            plugabsorber08 = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            johnson_rifle = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            miranda_smg_01 = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            miranda_smg_02 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            brute_shot_01 = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            absorber_e = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            absorber_f = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            absorber_g = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            absorber_h = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            absorber_i = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            anchor_intro = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            absorber_ledge_b = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            absorber_ledge_c = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            qz_cov_def_sound_a = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            qz_cov_def_sound_b = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            qz_cov_def_sound_c = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            qz_cov_def_sound_d = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            qz_cov_def_sound_e = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            qz_cov_def_sound_g = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            qz_cov_def_sound_f = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            phantom_int = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            absorber_ins = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            absorber_a = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            absorber_b = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            absorber_c = new ScenarioEntity<IScenery>(27, scenarioTag.WellKnownItems[27]);
            absorber_d = new ScenarioEntity<IScenery>(28, scenarioTag.WellKnownItems[28]);
            absorber_plug_landing = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            anchor_x06 = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            delta_halo = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            matte_mount_doom = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            qz_ini_sound_a = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            qz_ini_sound_b = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            qz_ini_sound_cave = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            texture_camera = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            elite_hg_prop_01 = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            elite_hg_prop_02 = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            elite_hg_prop_03 = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            elite_hg_prop_04 = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            elite_hg_prop_05 = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            elite_hg_prop_06 = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            elite_hg_prop_07 = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            elite_hg_prop_08 = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            carbine = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            x06_pike_01 = new ScenarioEntity<IScenery>(46, scenarioTag.WellKnownItems[46]);
            x06_pike_02 = new ScenarioEntity<IScenery>(47, scenarioTag.WellKnownItems[47]);
            x06_pike_03 = new ScenarioEntity<IScenery>(48, scenarioTag.WellKnownItems[48]);
            bsp0_crate_0 = new ScenarioEntity<IBloc>(49, scenarioTag.WellKnownItems[49]);
            bsp0_crate_1 = new ScenarioEntity<IBloc>(50, scenarioTag.WellKnownItems[50]);
            bsp0_crate_2 = new ScenarioEntity<IBloc>(51, scenarioTag.WellKnownItems[51]);
            bsp0_crate_3 = new ScenarioEntity<IBloc>(52, scenarioTag.WellKnownItems[52]);
            bsp0_crate_11 = new ScenarioEntity<IBloc>(53, scenarioTag.WellKnownItems[53]);
            bsp0_crate_12 = new ScenarioEntity<IBloc>(54, scenarioTag.WellKnownItems[54]);
            bsp0_crate_13 = new ScenarioEntity<IBloc>(55, scenarioTag.WellKnownItems[55]);
            bsp0_crate_14 = new ScenarioEntity<IBloc>(56, scenarioTag.WellKnownItems[56]);
            bsp0_crate_15 = new ScenarioEntity<IBloc>(57, scenarioTag.WellKnownItems[57]);
            bsp0_crate_16 = new ScenarioEntity<IBloc>(58, scenarioTag.WellKnownItems[58]);
            bsp0_crate_17 = new ScenarioEntity<IBloc>(59, scenarioTag.WellKnownItems[59]);
            bsp0_crate_18 = new ScenarioEntity<IBloc>(60, scenarioTag.WellKnownItems[60]);
            bsp0_crate_22 = new ScenarioEntity<IBloc>(61, scenarioTag.WellKnownItems[61]);
            bsp0_crate_23 = new ScenarioEntity<IBloc>(62, scenarioTag.WellKnownItems[62]);
            bsp0_crate_24 = new ScenarioEntity<IBloc>(63, scenarioTag.WellKnownItems[63]);
            bsp0_crate_25 = new ScenarioEntity<IBloc>(64, scenarioTag.WellKnownItems[64]);
            bsp0_crate_26 = new ScenarioEntity<IBloc>(65, scenarioTag.WellKnownItems[65]);
            bsp0_crate_27 = new ScenarioEntity<IBloc>(66, scenarioTag.WellKnownItems[66]);
            bsp0_crate_28 = new ScenarioEntity<IBloc>(67, scenarioTag.WellKnownItems[67]);
            bsp0_crate_29 = new ScenarioEntity<IBloc>(68, scenarioTag.WellKnownItems[68]);
            bsp0_crate_30 = new ScenarioEntity<IBloc>(69, scenarioTag.WellKnownItems[69]);
            texture_space = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            texture_halo = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            intro_turret_base = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            x06_helmet = new ScenarioEntity<IScenery>(73, scenarioTag.WellKnownItems[73]);
            factory_sound = new ScenarioEntity<IScenery>(74, scenarioTag.WellKnownItems[74]);
            index_holo = new ScenarioEntity<IScenery>(75, scenarioTag.WellKnownItems[75]);
            hall_c_sound = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            conduit_b_sound = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            matte_substance = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            matte_stardust = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            offending_column_01 = new ScenarioEntity<IScenery>(80, scenarioTag.WellKnownItems[80]);
            offending_column_02 = new ScenarioEntity<IScenery>(81, scenarioTag.WellKnownItems[81]);
            offending_column_03 = new ScenarioEntity<IScenery>(82, scenarioTag.WellKnownItems[82]);
            offending_column_04 = new ScenarioEntity<IScenery>(83, scenarioTag.WellKnownItems[83]);
            offending_column_05 = new ScenarioEntity<IScenery>(84, scenarioTag.WellKnownItems[84]);
            offending_column_06 = new ScenarioEntity<IScenery>(85, scenarioTag.WellKnownItems[85]);
            offending_column_07 = new ScenarioEntity<IScenery>(86, scenarioTag.WellKnownItems[86]);
            offending_column_08 = new ScenarioEntity<IScenery>(87, scenarioTag.WellKnownItems[87]);
            offending_column_09 = new ScenarioEntity<IScenery>(88, scenarioTag.WellKnownItems[88]);
            offending_column_10 = new ScenarioEntity<IScenery>(89, scenarioTag.WellKnownItems[89]);
            tartarus = new ScenarioEntity<IUnit>(90, scenarioTag.WellKnownItems[90]);
            truth = new ScenarioEntity<IUnit>(91, scenarioTag.WellKnownItems[91]);
            mercy = new ScenarioEntity<IUnit>(92, scenarioTag.WellKnownItems[92]);
            commander = new ScenarioEntity<IUnit>(93, scenarioTag.WellKnownItems[93]);
            so_elite_01 = new ScenarioEntity<IUnit>(94, scenarioTag.WellKnownItems[94]);
            so_elite_02 = new ScenarioEntity<IUnit>(95, scenarioTag.WellKnownItems[95]);
            brute_hg_01 = new ScenarioEntity<IUnit>(96, scenarioTag.WellKnownItems[96]);
            brute_hg_02 = new ScenarioEntity<IUnit>(97, scenarioTag.WellKnownItems[97]);
            dervish = new ScenarioEntity<IUnit>(98, scenarioTag.WellKnownItems[98]);
            brute_hg_03 = new ScenarioEntity<IUnit>(99, scenarioTag.WellKnownItems[99]);
            brute_01 = new ScenarioEntity<IUnit>(100, scenarioTag.WellKnownItems[100]);
            brute_02 = new ScenarioEntity<IUnit>(101, scenarioTag.WellKnownItems[101]);
            brute_03 = new ScenarioEntity<IUnit>(102, scenarioTag.WellKnownItems[102]);
            brute_04 = new ScenarioEntity<IUnit>(103, scenarioTag.WellKnownItems[103]);
            elite_hg_01 = new ScenarioEntity<IUnit>(104, scenarioTag.WellKnownItems[104]);
            elite_hg_02 = new ScenarioEntity<IUnit>(105, scenarioTag.WellKnownItems[105]);
            monitor = new ScenarioEntity<IUnit>(106, scenarioTag.WellKnownItems[106]);
            bsp0_body_2 = new ScenarioEntity<IUnit>(107, scenarioTag.WellKnownItems[107]);
            bsp0_body_3 = new ScenarioEntity<IUnit>(108, scenarioTag.WellKnownItems[108]);
            bsp0_body_4 = new ScenarioEntity<IUnit>(109, scenarioTag.WellKnownItems[109]);
            bsp0_body_5 = new ScenarioEntity<IUnit>(110, scenarioTag.WellKnownItems[110]);
            bsp0_body_6 = new ScenarioEntity<IUnit>(111, scenarioTag.WellKnownItems[111]);
            bsp0_body_7 = new ScenarioEntity<IUnit>(112, scenarioTag.WellKnownItems[112]);
            bsp0_body_8 = new ScenarioEntity<IUnit>(113, scenarioTag.WellKnownItems[113]);
            bsp0_body_9 = new ScenarioEntity<IUnit>(114, scenarioTag.WellKnownItems[114]);
            bsp0_body_10 = new ScenarioEntity<IUnit>(115, scenarioTag.WellKnownItems[115]);
            bsp0_body_11 = new ScenarioEntity<IUnit>(116, scenarioTag.WellKnownItems[116]);
            bsp0_body_12 = new ScenarioEntity<IUnit>(117, scenarioTag.WellKnownItems[117]);
            bsp0_body_13 = new ScenarioEntity<IUnit>(118, scenarioTag.WellKnownItems[118]);
            bsp0_body_14 = new ScenarioEntity<IUnit>(119, scenarioTag.WellKnownItems[119]);
            bsp0_body_15 = new ScenarioEntity<IUnit>(120, scenarioTag.WellKnownItems[120]);
            bsp0_body_16 = new ScenarioEntity<IUnit>(121, scenarioTag.WellKnownItems[121]);
            bsp0_body_17 = new ScenarioEntity<IUnit>(122, scenarioTag.WellKnownItems[122]);
            bsp0_body_18 = new ScenarioEntity<IUnit>(123, scenarioTag.WellKnownItems[123]);
            bsp0_body_19 = new ScenarioEntity<IUnit>(124, scenarioTag.WellKnownItems[124]);
            bsp0_body_20 = new ScenarioEntity<IUnit>(125, scenarioTag.WellKnownItems[125]);
            bsp0_body_22 = new ScenarioEntity<IUnit>(126, scenarioTag.WellKnownItems[126]);
            bsp0_body_23 = new ScenarioEntity<IUnit>(127, scenarioTag.WellKnownItems[127]);
            bsp0_body_24 = new ScenarioEntity<IUnit>(128, scenarioTag.WellKnownItems[128]);
            bsp0_body_25 = new ScenarioEntity<IUnit>(129, scenarioTag.WellKnownItems[129]);
            bsp0_body_27 = new ScenarioEntity<IUnit>(130, scenarioTag.WellKnownItems[130]);
            bsp0_body_28 = new ScenarioEntity<IUnit>(131, scenarioTag.WellKnownItems[131]);
            bsp0_body_29 = new ScenarioEntity<IUnit>(132, scenarioTag.WellKnownItems[132]);
            bsp0_body_30 = new ScenarioEntity<IUnit>(133, scenarioTag.WellKnownItems[133]);
            bsp0_body_31 = new ScenarioEntity<IUnit>(134, scenarioTag.WellKnownItems[134]);
            bsp0_body_32 = new ScenarioEntity<IUnit>(135, scenarioTag.WellKnownItems[135]);
            bsp0_body_33 = new ScenarioEntity<IUnit>(136, scenarioTag.WellKnownItems[136]);
            bsp0_body_34 = new ScenarioEntity<IUnit>(137, scenarioTag.WellKnownItems[137]);
            bsp0_body_36 = new ScenarioEntity<IUnit>(138, scenarioTag.WellKnownItems[138]);
            bsp0_body_37 = new ScenarioEntity<IUnit>(139, scenarioTag.WellKnownItems[139]);
            bsp0_body_39 = new ScenarioEntity<IUnit>(140, scenarioTag.WellKnownItems[140]);
            bsp0_body_40 = new ScenarioEntity<IUnit>(141, scenarioTag.WellKnownItems[141]);
            throne_truth = new ScenarioEntity<IVehicle>(142, scenarioTag.WellKnownItems[142]);
            throne_mercy = new ScenarioEntity<IVehicle>(143, scenarioTag.WellKnownItems[143]);
            phantom_01 = new ScenarioEntity<IVehicle>(144, scenarioTag.WellKnownItems[144]);
            ins_em_a = new ScenarioEntity<IVehicle>(145, scenarioTag.WellKnownItems[145]);
            ins_em_b = new ScenarioEntity<IVehicle>(146, scenarioTag.WellKnownItems[146]);
            ins_em_c = new ScenarioEntity<IVehicle>(147, scenarioTag.WellKnownItems[147]);
            hall_a_em_c = new ScenarioEntity<IVehicle>(148, scenarioTag.WellKnownItems[148]);
            hall_a_em_d = new ScenarioEntity<IVehicle>(149, scenarioTag.WellKnownItems[149]);
            hall_a_em_g = new ScenarioEntity<IVehicle>(150, scenarioTag.WellKnownItems[150]);
            hall_a_em_h = new ScenarioEntity<IVehicle>(151, scenarioTag.WellKnownItems[151]);
            cond_a_em_e = new ScenarioEntity<IVehicle>(152, scenarioTag.WellKnownItems[152]);
            cond_a_em_f = new ScenarioEntity<IVehicle>(153, scenarioTag.WellKnownItems[153]);
            cond_a_em_h = new ScenarioEntity<IVehicle>(154, scenarioTag.WellKnownItems[154]);
            cond_a_em_g = new ScenarioEntity<IVehicle>(155, scenarioTag.WellKnownItems[155]);
            cond_a_em_m = new ScenarioEntity<IVehicle>(156, scenarioTag.WellKnownItems[156]);
            cond_a_em_n = new ScenarioEntity<IVehicle>(157, scenarioTag.WellKnownItems[157]);
            cond_a_em_o = new ScenarioEntity<IVehicle>(158, scenarioTag.WellKnownItems[158]);
            hall_b_em_f = new ScenarioEntity<IVehicle>(159, scenarioTag.WellKnownItems[159]);
            hall_b_em_g = new ScenarioEntity<IVehicle>(160, scenarioTag.WellKnownItems[160]);
            hall_b_em_h = new ScenarioEntity<IVehicle>(161, scenarioTag.WellKnownItems[161]);
            hall_b_em_d = new ScenarioEntity<IVehicle>(162, scenarioTag.WellKnownItems[162]);
            hall_b_em_e = new ScenarioEntity<IVehicle>(163, scenarioTag.WellKnownItems[163]);
            hall_b_em_a = new ScenarioEntity<IVehicle>(164, scenarioTag.WellKnownItems[164]);
            hall_b_em_b = new ScenarioEntity<IVehicle>(165, scenarioTag.WellKnownItems[165]);
            hall_b_em_c = new ScenarioEntity<IVehicle>(166, scenarioTag.WellKnownItems[166]);
            plug_holder_em_a = new ScenarioEntity<IVehicle>(167, scenarioTag.WellKnownItems[167]);
            plug_holder_em_b = new ScenarioEntity<IVehicle>(168, scenarioTag.WellKnownItems[168]);
            plug_holder_em_c = new ScenarioEntity<IVehicle>(169, scenarioTag.WellKnownItems[169]);
            plug_holder_em_d = new ScenarioEntity<IVehicle>(170, scenarioTag.WellKnownItems[170]);
            plug_holder_em_e = new ScenarioEntity<IVehicle>(171, scenarioTag.WellKnownItems[171]);
            plug_holder_em_f = new ScenarioEntity<IVehicle>(172, scenarioTag.WellKnownItems[172]);
            plug_holder_em_g = new ScenarioEntity<IVehicle>(173, scenarioTag.WellKnownItems[173]);
            plug_holder_em_h = new ScenarioEntity<IVehicle>(174, scenarioTag.WellKnownItems[174]);
            plug_holder_em_i = new ScenarioEntity<IVehicle>(175, scenarioTag.WellKnownItems[175]);
            plug_holder_bk_em_a = new ScenarioEntity<IVehicle>(176, scenarioTag.WellKnownItems[176]);
            plug_holder_bk_em_b = new ScenarioEntity<IVehicle>(177, scenarioTag.WellKnownItems[177]);
            plug_holder_bk_em_c = new ScenarioEntity<IVehicle>(178, scenarioTag.WellKnownItems[178]);
            plug_holder_bk_em_d = new ScenarioEntity<IVehicle>(179, scenarioTag.WellKnownItems[179]);
            plug_holder_bk_em_e = new ScenarioEntity<IVehicle>(180, scenarioTag.WellKnownItems[180]);
            plug_holder_bk_em_f = new ScenarioEntity<IVehicle>(181, scenarioTag.WellKnownItems[181]);
            cond_a_em_a = new ScenarioEntity<IVehicle>(182, scenarioTag.WellKnownItems[182]);
            cond_a_em_c = new ScenarioEntity<IVehicle>(183, scenarioTag.WellKnownItems[183]);
            cond_a_em_i = new ScenarioEntity<IVehicle>(184, scenarioTag.WellKnownItems[184]);
            cond_a_em_j = new ScenarioEntity<IVehicle>(185, scenarioTag.WellKnownItems[185]);
            cond_a_em_k = new ScenarioEntity<IVehicle>(186, scenarioTag.WellKnownItems[186]);
            cond_a_em_l = new ScenarioEntity<IVehicle>(187, scenarioTag.WellKnownItems[187]);
            ledge_a_em_a = new ScenarioEntity<IVehicle>(188, scenarioTag.WellKnownItems[188]);
            ledge_a_em_b = new ScenarioEntity<IVehicle>(189, scenarioTag.WellKnownItems[189]);
            ledge_a_em_c = new ScenarioEntity<IVehicle>(190, scenarioTag.WellKnownItems[190]);
            ledge_a_em_d = new ScenarioEntity<IVehicle>(191, scenarioTag.WellKnownItems[191]);
            ledge_a_em_e = new ScenarioEntity<IVehicle>(192, scenarioTag.WellKnownItems[192]);
            ledge_a_em_f = new ScenarioEntity<IVehicle>(193, scenarioTag.WellKnownItems[193]);
            ledge_a_em_g = new ScenarioEntity<IVehicle>(194, scenarioTag.WellKnownItems[194]);
            ledge_a_em_h = new ScenarioEntity<IVehicle>(195, scenarioTag.WellKnownItems[195]);
            ledge_a_em_i = new ScenarioEntity<IVehicle>(196, scenarioTag.WellKnownItems[196]);
            intro_sen_maj = new ScenarioEntity<IVehicle>(197, scenarioTag.WellKnownItems[197]);
            phantom_02 = new ScenarioEntity<IVehicle>(198, scenarioTag.WellKnownItems[198]);
            plugabsorber01 = new ScenarioEntity<IVehicle>(199, scenarioTag.WellKnownItems[199]);
            plugabsorber02 = new ScenarioEntity<IVehicle>(200, scenarioTag.WellKnownItems[200]);
            plugabsorber03 = new ScenarioEntity<IVehicle>(201, scenarioTag.WellKnownItems[201]);
            plugabsorber04 = new ScenarioEntity<IVehicle>(202, scenarioTag.WellKnownItems[202]);
            plug_launch_em_a = new ScenarioEntity<IVehicle>(203, scenarioTag.WellKnownItems[203]);
            plug_launch_em_b = new ScenarioEntity<IVehicle>(204, scenarioTag.WellKnownItems[204]);
            plug_launch_em_c = new ScenarioEntity<IVehicle>(205, scenarioTag.WellKnownItems[205]);
            plug_launch_em_d = new ScenarioEntity<IVehicle>(206, scenarioTag.WellKnownItems[206]);
            plug_launch_em_e = new ScenarioEntity<IVehicle>(207, scenarioTag.WellKnownItems[207]);
            plug_launch_em_f = new ScenarioEntity<IVehicle>(208, scenarioTag.WellKnownItems[208]);
            plug_launch_em_g = new ScenarioEntity<IVehicle>(209, scenarioTag.WellKnownItems[209]);
            plug_launch_em_h = new ScenarioEntity<IVehicle>(210, scenarioTag.WellKnownItems[210]);
            cond_b_em_b = new ScenarioEntity<IVehicle>(211, scenarioTag.WellKnownItems[211]);
            cond_b_em_a = new ScenarioEntity<IVehicle>(212, scenarioTag.WellKnownItems[212]);
            bsp0_equip_0 = new ScenarioEntity<IStartingProfile>(213, scenarioTag.WellKnownItems[213]);
            bsp0_equip_1 = new ScenarioEntity<IStartingProfile>(214, scenarioTag.WellKnownItems[214]);
            bsp0_equip_2 = new ScenarioEntity<IStartingProfile>(215, scenarioTag.WellKnownItems[215]);
            bsp0_equip_3 = new ScenarioEntity<IStartingProfile>(216, scenarioTag.WellKnownItems[216]);
            bsp0_equip_4 = new ScenarioEntity<IStartingProfile>(217, scenarioTag.WellKnownItems[217]);
            bsp0_equip_5 = new ScenarioEntity<IStartingProfile>(218, scenarioTag.WellKnownItems[218]);
            bsp0_equip_6 = new ScenarioEntity<IStartingProfile>(219, scenarioTag.WellKnownItems[219]);
            bsp0_equip_7 = new ScenarioEntity<IStartingProfile>(220, scenarioTag.WellKnownItems[220]);
            bsp0_equip_8 = new ScenarioEntity<IStartingProfile>(221, scenarioTag.WellKnownItems[221]);
            bsp0_equip_9 = new ScenarioEntity<IStartingProfile>(222, scenarioTag.WellKnownItems[222]);
            bsp0_equip_10 = new ScenarioEntity<IStartingProfile>(223, scenarioTag.WellKnownItems[223]);
            bsp0_equip_11 = new ScenarioEntity<IStartingProfile>(224, scenarioTag.WellKnownItems[224]);
            bsp0_equip_12 = new ScenarioEntity<IStartingProfile>(225, scenarioTag.WellKnownItems[225]);
            bsp0_equip_13 = new ScenarioEntity<IStartingProfile>(226, scenarioTag.WellKnownItems[226]);
            bsp0_equip_14 = new ScenarioEntity<IStartingProfile>(227, scenarioTag.WellKnownItems[227]);
            bsp0_equip_15 = new ScenarioEntity<IStartingProfile>(228, scenarioTag.WellKnownItems[228]);
            bsp0_equip_16 = new ScenarioEntity<IStartingProfile>(229, scenarioTag.WellKnownItems[229]);
            bsp0_equip_17 = new ScenarioEntity<IStartingProfile>(230, scenarioTag.WellKnownItems[230]);
            bsp0_equip_18 = new ScenarioEntity<IStartingProfile>(231, scenarioTag.WellKnownItems[231]);
            bsp0_equip_19 = new ScenarioEntity<IStartingProfile>(232, scenarioTag.WellKnownItems[232]);
            bsp0_equip_20 = new ScenarioEntity<IStartingProfile>(233, scenarioTag.WellKnownItems[233]);
            bsp0_equip_21 = new ScenarioEntity<IStartingProfile>(234, scenarioTag.WellKnownItems[234]);
            bsp0_equip_22 = new ScenarioEntity<IStartingProfile>(235, scenarioTag.WellKnownItems[235]);
            bsp0_equip_23 = new ScenarioEntity<IStartingProfile>(236, scenarioTag.WellKnownItems[236]);
            bsp0_equip_24 = new ScenarioEntity<IStartingProfile>(237, scenarioTag.WellKnownItems[237]);
            bsp0_equip_25 = new ScenarioEntity<IStartingProfile>(238, scenarioTag.WellKnownItems[238]);
            bsp0_equip_26 = new ScenarioEntity<IStartingProfile>(239, scenarioTag.WellKnownItems[239]);
            bsp0_equip_27 = new ScenarioEntity<IStartingProfile>(240, scenarioTag.WellKnownItems[240]);
            bsp0_equip_28 = new ScenarioEntity<IStartingProfile>(241, scenarioTag.WellKnownItems[241]);
            bsp0_equip_29 = new ScenarioEntity<IStartingProfile>(242, scenarioTag.WellKnownItems[242]);
            bsp0_equip_30 = new ScenarioEntity<IStartingProfile>(243, scenarioTag.WellKnownItems[243]);
            bsp0_equip_31 = new ScenarioEntity<IStartingProfile>(244, scenarioTag.WellKnownItems[244]);
            bsp0_equip_32 = new ScenarioEntity<IStartingProfile>(245, scenarioTag.WellKnownItems[245]);
            bsp0_equip_33 = new ScenarioEntity<IStartingProfile>(246, scenarioTag.WellKnownItems[246]);
            bsp0_equip_34 = new ScenarioEntity<IStartingProfile>(247, scenarioTag.WellKnownItems[247]);
            bsp0_equip_35 = new ScenarioEntity<IStartingProfile>(248, scenarioTag.WellKnownItems[248]);
            bsp0_equip_36 = new ScenarioEntity<IStartingProfile>(249, scenarioTag.WellKnownItems[249]);
            bsp0_equip_37 = new ScenarioEntity<IStartingProfile>(250, scenarioTag.WellKnownItems[250]);
            bsp0_equip_38 = new ScenarioEntity<IStartingProfile>(251, scenarioTag.WellKnownItems[251]);
            bsp0_equip_39 = new ScenarioEntity<IStartingProfile>(252, scenarioTag.WellKnownItems[252]);
            bsp0_equip_40 = new ScenarioEntity<IStartingProfile>(253, scenarioTag.WellKnownItems[253]);
            bsp0_equip_41 = new ScenarioEntity<IStartingProfile>(254, scenarioTag.WellKnownItems[254]);
            bsp0_equip_42 = new ScenarioEntity<IStartingProfile>(255, scenarioTag.WellKnownItems[255]);
            bsp0_equip_43 = new ScenarioEntity<IStartingProfile>(256, scenarioTag.WellKnownItems[256]);
            bsp0_equip_44 = new ScenarioEntity<IStartingProfile>(257, scenarioTag.WellKnownItems[257]);
            bsp0_equip_45 = new ScenarioEntity<IStartingProfile>(258, scenarioTag.WellKnownItems[258]);
            bsp1_equip_0 = new ScenarioEntity<IStartingProfile>(259, scenarioTag.WellKnownItems[259]);
            bsp1_equip_1 = new ScenarioEntity<IStartingProfile>(260, scenarioTag.WellKnownItems[260]);
            bsp1_equip_2 = new ScenarioEntity<IStartingProfile>(261, scenarioTag.WellKnownItems[261]);
            bsp1_equip_3 = new ScenarioEntity<IStartingProfile>(262, scenarioTag.WellKnownItems[262]);
            bsp1_equip_4 = new ScenarioEntity<IStartingProfile>(263, scenarioTag.WellKnownItems[263]);
            bsp1_equip_5 = new ScenarioEntity<IStartingProfile>(264, scenarioTag.WellKnownItems[264]);
            bsp1_equip_6 = new ScenarioEntity<IStartingProfile>(265, scenarioTag.WellKnownItems[265]);
            bsp1_equip_7 = new ScenarioEntity<IStartingProfile>(266, scenarioTag.WellKnownItems[266]);
            bsp1_equip_8 = new ScenarioEntity<IStartingProfile>(267, scenarioTag.WellKnownItems[267]);
            bsp1_equip_9 = new ScenarioEntity<IStartingProfile>(268, scenarioTag.WellKnownItems[268]);
            bsp1_equip_10 = new ScenarioEntity<IStartingProfile>(269, scenarioTag.WellKnownItems[269]);
            bsp1_equip_11 = new ScenarioEntity<IStartingProfile>(270, scenarioTag.WellKnownItems[270]);
            bsp1_equip_12 = new ScenarioEntity<IStartingProfile>(271, scenarioTag.WellKnownItems[271]);
            bsp1_equip_13 = new ScenarioEntity<IStartingProfile>(272, scenarioTag.WellKnownItems[272]);
            bsp1_equip_14 = new ScenarioEntity<IStartingProfile>(273, scenarioTag.WellKnownItems[273]);
            bsp1_equip_15 = new ScenarioEntity<IStartingProfile>(274, scenarioTag.WellKnownItems[274]);
            bsp1_equip_16 = new ScenarioEntity<IStartingProfile>(275, scenarioTag.WellKnownItems[275]);
            bsp1_equip_17 = new ScenarioEntity<IStartingProfile>(276, scenarioTag.WellKnownItems[276]);
            bsp1_equip_18 = new ScenarioEntity<IStartingProfile>(277, scenarioTag.WellKnownItems[277]);
            bsp1_equip_19 = new ScenarioEntity<IStartingProfile>(278, scenarioTag.WellKnownItems[278]);
            bsp1_equip_20 = new ScenarioEntity<IStartingProfile>(279, scenarioTag.WellKnownItems[279]);
            bsp1_equip_21 = new ScenarioEntity<IStartingProfile>(280, scenarioTag.WellKnownItems[280]);
            bsp1_equip_22 = new ScenarioEntity<IStartingProfile>(281, scenarioTag.WellKnownItems[281]);
            bsp1_equip_23 = new ScenarioEntity<IStartingProfile>(282, scenarioTag.WellKnownItems[282]);
            bsp1_equip_24 = new ScenarioEntity<IStartingProfile>(283, scenarioTag.WellKnownItems[283]);
            bsp1_equip_25 = new ScenarioEntity<IStartingProfile>(284, scenarioTag.WellKnownItems[284]);
            bsp1_equip_26 = new ScenarioEntity<IStartingProfile>(285, scenarioTag.WellKnownItems[285]);
            bsp1_equip_27 = new ScenarioEntity<IStartingProfile>(286, scenarioTag.WellKnownItems[286]);
            bsp1_equip_28 = new ScenarioEntity<IStartingProfile>(287, scenarioTag.WellKnownItems[287]);
            bsp1_equip_29 = new ScenarioEntity<IStartingProfile>(288, scenarioTag.WellKnownItems[288]);
            bsp1_equip_30 = new ScenarioEntity<IStartingProfile>(289, scenarioTag.WellKnownItems[289]);
            bsp0_weapon_1 = new ScenarioEntity<IWeapon>(290, scenarioTag.WellKnownItems[290]);
            bsp0_weapon_2 = new ScenarioEntity<IWeapon>(291, scenarioTag.WellKnownItems[291]);
            bsp0_weapon_3 = new ScenarioEntity<IWeapon>(292, scenarioTag.WellKnownItems[292]);
            bsp0_weapon_4 = new ScenarioEntity<IWeapon>(293, scenarioTag.WellKnownItems[293]);
            bsp0_weapon_5 = new ScenarioEntity<IWeapon>(294, scenarioTag.WellKnownItems[294]);
            bsp0_weapon_6 = new ScenarioEntity<IWeapon>(295, scenarioTag.WellKnownItems[295]);
            bsp0_weapon_7 = new ScenarioEntity<IWeapon>(296, scenarioTag.WellKnownItems[296]);
            bsp0_weapon_8 = new ScenarioEntity<IWeapon>(297, scenarioTag.WellKnownItems[297]);
            bsp0_weapon_9 = new ScenarioEntity<IWeapon>(298, scenarioTag.WellKnownItems[298]);
            bsp0_weapon_10 = new ScenarioEntity<IWeapon>(299, scenarioTag.WellKnownItems[299]);
            bsp0_weapon_11 = new ScenarioEntity<IWeapon>(300, scenarioTag.WellKnownItems[300]);
            bsp0_weapon_12 = new ScenarioEntity<IWeapon>(301, scenarioTag.WellKnownItems[301]);
            bsp0_weapon_13 = new ScenarioEntity<IWeapon>(302, scenarioTag.WellKnownItems[302]);
            bsp0_weapon_14 = new ScenarioEntity<IWeapon>(303, scenarioTag.WellKnownItems[303]);
            bsp0_weapon_15 = new ScenarioEntity<IWeapon>(304, scenarioTag.WellKnownItems[304]);
            bsp0_weapon_16 = new ScenarioEntity<IWeapon>(305, scenarioTag.WellKnownItems[305]);
            bsp0_weapon_17 = new ScenarioEntity<IWeapon>(306, scenarioTag.WellKnownItems[306]);
            bsp0_weapon_18 = new ScenarioEntity<IWeapon>(307, scenarioTag.WellKnownItems[307]);
            bsp0_weapon_19 = new ScenarioEntity<IWeapon>(308, scenarioTag.WellKnownItems[308]);
            bsp0_weapon_20 = new ScenarioEntity<IWeapon>(309, scenarioTag.WellKnownItems[309]);
            bsp0_weapon_22 = new ScenarioEntity<IWeapon>(310, scenarioTag.WellKnownItems[310]);
            bsp0_weapon_23 = new ScenarioEntity<IWeapon>(311, scenarioTag.WellKnownItems[311]);
            bsp0_weapon_24 = new ScenarioEntity<IWeapon>(312, scenarioTag.WellKnownItems[312]);
            bsp0_weapon_25 = new ScenarioEntity<IWeapon>(313, scenarioTag.WellKnownItems[313]);
            bsp0_weapon_26 = new ScenarioEntity<IWeapon>(314, scenarioTag.WellKnownItems[314]);
            bsp0_weapon_27 = new ScenarioEntity<IWeapon>(315, scenarioTag.WellKnownItems[315]);
            bsp0_weapon_28 = new ScenarioEntity<IWeapon>(316, scenarioTag.WellKnownItems[316]);
            bsp0_weapon_29 = new ScenarioEntity<IWeapon>(317, scenarioTag.WellKnownItems[317]);
            bsp0_weapon_30 = new ScenarioEntity<IWeapon>(318, scenarioTag.WellKnownItems[318]);
            bsp0_weapon_31 = new ScenarioEntity<IWeapon>(319, scenarioTag.WellKnownItems[319]);
            bsp0_weapon_32 = new ScenarioEntity<IWeapon>(320, scenarioTag.WellKnownItems[320]);
            bsp0_weapon_33 = new ScenarioEntity<IWeapon>(321, scenarioTag.WellKnownItems[321]);
            bsp0_weapon_34 = new ScenarioEntity<IWeapon>(322, scenarioTag.WellKnownItems[322]);
            bsp0_weapon_35 = new ScenarioEntity<IWeapon>(323, scenarioTag.WellKnownItems[323]);
            bsp0_weapon_36 = new ScenarioEntity<IWeapon>(324, scenarioTag.WellKnownItems[324]);
            bsp0_weapon_37 = new ScenarioEntity<IWeapon>(325, scenarioTag.WellKnownItems[325]);
            bsp0_weapon_38 = new ScenarioEntity<IWeapon>(326, scenarioTag.WellKnownItems[326]);
            bsp0_weapon_39 = new ScenarioEntity<IWeapon>(327, scenarioTag.WellKnownItems[327]);
            bsp0_weapon_40 = new ScenarioEntity<IWeapon>(328, scenarioTag.WellKnownItems[328]);
            bsp0_weapon_41 = new ScenarioEntity<IWeapon>(329, scenarioTag.WellKnownItems[329]);
            bsp0_weapon_42 = new ScenarioEntity<IWeapon>(330, scenarioTag.WellKnownItems[330]);
            bsp0_weapon_43 = new ScenarioEntity<IWeapon>(331, scenarioTag.WellKnownItems[331]);
            intro_turret = new ScenarioEntity<IWeapon>(332, scenarioTag.WellKnownItems[332]);
            ice_cream_head = new ScenarioEntity<IWeapon>(333, scenarioTag.WellKnownItems[333]);
            bsp1_weapon_0 = new ScenarioEntity<IWeapon>(334, scenarioTag.WellKnownItems[334]);
            bsp1_weapon_1 = new ScenarioEntity<IWeapon>(335, scenarioTag.WellKnownItems[335]);
            bsp1_weapon_2 = new ScenarioEntity<IWeapon>(336, scenarioTag.WellKnownItems[336]);
            bsp1_weapon_3 = new ScenarioEntity<IWeapon>(337, scenarioTag.WellKnownItems[337]);
            bsp1_weapon_4 = new ScenarioEntity<IWeapon>(338, scenarioTag.WellKnownItems[338]);
            bsp1_weapon_5 = new ScenarioEntity<IWeapon>(339, scenarioTag.WellKnownItems[339]);
            bsp1_weapon_6 = new ScenarioEntity<IWeapon>(340, scenarioTag.WellKnownItems[340]);
            bsp1_weapon_7 = new ScenarioEntity<IWeapon>(341, scenarioTag.WellKnownItems[341]);
            bsp1_weapon_8 = new ScenarioEntity<IWeapon>(342, scenarioTag.WellKnownItems[342]);
            bsp1_weapon_9 = new ScenarioEntity<IWeapon>(343, scenarioTag.WellKnownItems[343]);
            bsp1_weapon_10 = new ScenarioEntity<IWeapon>(344, scenarioTag.WellKnownItems[344]);
            bsp1_weapon_11 = new ScenarioEntity<IWeapon>(345, scenarioTag.WellKnownItems[345]);
            bsp1_weapon_12 = new ScenarioEntity<IWeapon>(346, scenarioTag.WellKnownItems[346]);
            bsp1_weapon_13 = new ScenarioEntity<IWeapon>(347, scenarioTag.WellKnownItems[347]);
            bsp1_weapon_14 = new ScenarioEntity<IWeapon>(348, scenarioTag.WellKnownItems[348]);
            bsp1_weapon_15 = new ScenarioEntity<IWeapon>(349, scenarioTag.WellKnownItems[349]);
            bsp1_weapon_16 = new ScenarioEntity<IWeapon>(350, scenarioTag.WellKnownItems[350]);
            bsp1_weapon_17 = new ScenarioEntity<IWeapon>(351, scenarioTag.WellKnownItems[351]);
            bsp1_weapon_18 = new ScenarioEntity<IWeapon>(352, scenarioTag.WellKnownItems[352]);
            bsp1_weapon_19 = new ScenarioEntity<IWeapon>(353, scenarioTag.WellKnownItems[353]);
            bsp1_weapon_20 = new ScenarioEntity<IWeapon>(354, scenarioTag.WellKnownItems[354]);
            bsp1_weapon_21 = new ScenarioEntity<IWeapon>(355, scenarioTag.WellKnownItems[355]);
            bsp1_weapon_22 = new ScenarioEntity<IWeapon>(356, scenarioTag.WellKnownItems[356]);
            bsp1_weapon_23 = new ScenarioEntity<IWeapon>(357, scenarioTag.WellKnownItems[357]);
            bsp1_weapon_24 = new ScenarioEntity<IWeapon>(358, scenarioTag.WellKnownItems[358]);
            bsp1_weapon_25 = new ScenarioEntity<IWeapon>(359, scenarioTag.WellKnownItems[359]);
            bsp1_weapon_26 = new ScenarioEntity<IWeapon>(360, scenarioTag.WellKnownItems[360]);
            bsp1_weapon_27 = new ScenarioEntity<IWeapon>(361, scenarioTag.WellKnownItems[361]);
            bsp1_weapon_28 = new ScenarioEntity<IWeapon>(362, scenarioTag.WellKnownItems[362]);
            bsp1_weapon_29 = new ScenarioEntity<IWeapon>(363, scenarioTag.WellKnownItems[363]);
            bsp1_weapon_30 = new ScenarioEntity<IWeapon>(364, scenarioTag.WellKnownItems[364]);
            bsp1_weapon_31 = new ScenarioEntity<IWeapon>(365, scenarioTag.WellKnownItems[365]);
            bsp1_weapon_32 = new ScenarioEntity<IWeapon>(366, scenarioTag.WellKnownItems[366]);
            bsp1_weapon_33 = new ScenarioEntity<IWeapon>(367, scenarioTag.WellKnownItems[367]);
            bsp1_weapon_34 = new ScenarioEntity<IWeapon>(368, scenarioTag.WellKnownItems[368]);
            bsp1_weapon_35 = new ScenarioEntity<IWeapon>(369, scenarioTag.WellKnownItems[369]);
            bsp1_weapon_36 = new ScenarioEntity<IWeapon>(370, scenarioTag.WellKnownItems[370]);
            bsp1_weapon_37 = new ScenarioEntity<IWeapon>(371, scenarioTag.WellKnownItems[371]);
            bsp1_weapon_38 = new ScenarioEntity<IWeapon>(372, scenarioTag.WellKnownItems[372]);
            bsp1_weapon_39 = new ScenarioEntity<IWeapon>(373, scenarioTag.WellKnownItems[373]);
            bsp1_weapon_40 = new ScenarioEntity<IWeapon>(374, scenarioTag.WellKnownItems[374]);
            bsp1_weapon_41 = new ScenarioEntity<IWeapon>(375, scenarioTag.WellKnownItems[375]);
            bsp1_weapon_42 = new ScenarioEntity<IWeapon>(376, scenarioTag.WellKnownItems[376]);
            bsp1_weapon_43 = new ScenarioEntity<IWeapon>(377, scenarioTag.WellKnownItems[377]);
            bsp1_weapon_44 = new ScenarioEntity<IWeapon>(378, scenarioTag.WellKnownItems[378]);
            bsp1_weapon_45 = new ScenarioEntity<IWeapon>(379, scenarioTag.WellKnownItems[379]);
            bsp1_weapon_46 = new ScenarioEntity<IWeapon>(380, scenarioTag.WellKnownItems[380]);
            bsp1_weapon_47 = new ScenarioEntity<IWeapon>(381, scenarioTag.WellKnownItems[381]);
            bsp1_weapon_48 = new ScenarioEntity<IWeapon>(382, scenarioTag.WellKnownItems[382]);
            bsp1_weapon_49 = new ScenarioEntity<IWeapon>(383, scenarioTag.WellKnownItems[383]);
            bsp1_weapon_50 = new ScenarioEntity<IWeapon>(384, scenarioTag.WellKnownItems[384]);
            bsp1_weapon_51 = new ScenarioEntity<IWeapon>(385, scenarioTag.WellKnownItems[385]);
            bsp1_weapon_52 = new ScenarioEntity<IWeapon>(386, scenarioTag.WellKnownItems[386]);
            bsp1_weapon_53 = new ScenarioEntity<IWeapon>(387, scenarioTag.WellKnownItems[387]);
            plug_doors_open = new ScenarioEntity<ISound>(388, scenarioTag.WellKnownItems[388]);
            plug_doors_closed = new ScenarioEntity<ISound>(389, scenarioTag.WellKnownItems[389]);
            plug_switch = new ScenarioEntity<IDevice>(391, scenarioTag.WellKnownItems[391]);
            plug = new ScenarioEntity<IDevice>(392, scenarioTag.WellKnownItems[392]);
            plug_keylock_c = new ScenarioEntity<IDevice>(393, scenarioTag.WellKnownItems[393]);
            plug_keylock_d = new ScenarioEntity<IDevice>(394, scenarioTag.WellKnownItems[394]);
            plug_thick_fr = new ScenarioEntity<IDevice>(395, scenarioTag.WellKnownItems[395]);
            plug_thick_br = new ScenarioEntity<IDevice>(396, scenarioTag.WellKnownItems[396]);
            plug_thick_bl = new ScenarioEntity<IDevice>(397, scenarioTag.WellKnownItems[397]);
            plug_thick_fl = new ScenarioEntity<IDevice>(398, scenarioTag.WellKnownItems[398]);
            plug_thin_br = new ScenarioEntity<IDevice>(399, scenarioTag.WellKnownItems[399]);
            plug_thin_bl = new ScenarioEntity<IDevice>(400, scenarioTag.WellKnownItems[400]);
            plug_thin_fl = new ScenarioEntity<IDevice>(401, scenarioTag.WellKnownItems[401]);
            plug_thin_fr = new ScenarioEntity<IDevice>(402, scenarioTag.WellKnownItems[402]);
            piston_a = new ScenarioEntity<IDevice>(403, scenarioTag.WellKnownItems[403]);
            piston_b = new ScenarioEntity<IDevice>(404, scenarioTag.WellKnownItems[404]);
            piston_c = new ScenarioEntity<IDevice>(405, scenarioTag.WellKnownItems[405]);
            piston_d = new ScenarioEntity<IDevice>(406, scenarioTag.WellKnownItems[406]);
            piston_e = new ScenarioEntity<IDevice>(407, scenarioTag.WellKnownItems[407]);
            piston_f = new ScenarioEntity<IDevice>(408, scenarioTag.WellKnownItems[408]);
            piston_h = new ScenarioEntity<IDevice>(409, scenarioTag.WellKnownItems[409]);
            tower_a_base = new ScenarioEntity<IDevice>(410, scenarioTag.WellKnownItems[410]);
            tower_a_pod = new ScenarioEntity<IDevice>(411, scenarioTag.WellKnownItems[411]);
            tower_b_base = new ScenarioEntity<IDevice>(412, scenarioTag.WellKnownItems[412]);
            tower_b_pod = new ScenarioEntity<IDevice>(413, scenarioTag.WellKnownItems[413]);
            piston_ins = new ScenarioEntity<IDevice>(414, scenarioTag.WellKnownItems[414]);
            plug_lock_a = new ScenarioEntity<IDevice>(415, scenarioTag.WellKnownItems[415]);
            plug_lock_b = new ScenarioEntity<IDevice>(416, scenarioTag.WellKnownItems[416]);
            plug_lock_c = new ScenarioEntity<IDevice>(417, scenarioTag.WellKnownItems[417]);
            plug_lock_d = new ScenarioEntity<IDevice>(418, scenarioTag.WellKnownItems[418]);
            plug_lock_e = new ScenarioEntity<IDevice>(419, scenarioTag.WellKnownItems[419]);
            plug_lock_f = new ScenarioEntity<IDevice>(420, scenarioTag.WellKnownItems[420]);
            piston_plug_landing = new ScenarioEntity<IDevice>(421, scenarioTag.WellKnownItems[421]);
            qz_door = new ScenarioEntity<IDevice>(422, scenarioTag.WellKnownItems[422]);
            plugholder_door = new ScenarioEntity<IDevice>(423, scenarioTag.WellKnownItems[423]);
            qz_ent_pod_a = new ScenarioEntity<IDevice>(424, scenarioTag.WellKnownItems[424]);
            qz_ent_pod_b = new ScenarioEntity<IDevice>(425, scenarioTag.WellKnownItems[425]);
            qz_ent_pod_c = new ScenarioEntity<IDevice>(426, scenarioTag.WellKnownItems[426]);
            qz_ent_pod_d = new ScenarioEntity<IDevice>(427, scenarioTag.WellKnownItems[427]);
            qz_ent_pod_e = new ScenarioEntity<IDevice>(428, scenarioTag.WellKnownItems[428]);
            piston_ledge_b = new ScenarioEntity<IDevice>(429, scenarioTag.WellKnownItems[429]);
            piston_ledge_c = new ScenarioEntity<IDevice>(430, scenarioTag.WellKnownItems[430]);
            piston_i = new ScenarioEntity<IDevice>(431, scenarioTag.WellKnownItems[431]);
            piston_g = new ScenarioEntity<IDevice>(432, scenarioTag.WellKnownItems[432]);
            ledge_a_door_a = new ScenarioEntity<IDevice>(433, scenarioTag.WellKnownItems[433]);
            ledge_a_door_b = new ScenarioEntity<IDevice>(434, scenarioTag.WellKnownItems[434]);
            ledge_a_door_c = new ScenarioEntity<IDevice>(435, scenarioTag.WellKnownItems[435]);
            ledge_a_door_d = new ScenarioEntity<IDevice>(436, scenarioTag.WellKnownItems[436]);
            ledge_a_door_e = new ScenarioEntity<IDevice>(437, scenarioTag.WellKnownItems[437]);
            ledge_a_door_f = new ScenarioEntity<IDevice>(438, scenarioTag.WellKnownItems[438]);
            plug_door_a = new ScenarioEntity<IDevice>(439, scenarioTag.WellKnownItems[439]);
            plug_door_b = new ScenarioEntity<IDevice>(440, scenarioTag.WellKnownItems[440]);
            containment_field = new ScenarioEntity<IDevice>(441, scenarioTag.WellKnownItems[441]);
            sanctum_door = new ScenarioEntity<IDevice>(442, scenarioTag.WellKnownItems[442]);
            plug_switch_housing = new ScenarioEntity<IDevice>(443, scenarioTag.WellKnownItems[443]);
            factory = new ScenarioEntity<IDevice>(444, scenarioTag.WellKnownItems[444]);
            ins_switch_a = new ScenarioEntity<IDevice>(445, scenarioTag.WellKnownItems[445]);
            ins_switch_b = new ScenarioEntity<IDevice>(446, scenarioTag.WellKnownItems[446]);
            ins_switch_c = new ScenarioEntity<IDevice>(447, scenarioTag.WellKnownItems[447]);
            ins_switch_d = new ScenarioEntity<IDevice>(448, scenarioTag.WellKnownItems[448]);
            a_switch_a = new ScenarioEntity<IDevice>(449, scenarioTag.WellKnownItems[449]);
            a_switch_b = new ScenarioEntity<IDevice>(450, scenarioTag.WellKnownItems[450]);
            a_switch_c = new ScenarioEntity<IDevice>(451, scenarioTag.WellKnownItems[451]);
            a_switch_d = new ScenarioEntity<IDevice>(452, scenarioTag.WellKnownItems[452]);
            b_switch_a = new ScenarioEntity<IDevice>(453, scenarioTag.WellKnownItems[453]);
            b_switch_b = new ScenarioEntity<IDevice>(454, scenarioTag.WellKnownItems[454]);
            b_switch_c = new ScenarioEntity<IDevice>(455, scenarioTag.WellKnownItems[455]);
            b_switch_d = new ScenarioEntity<IDevice>(456, scenarioTag.WellKnownItems[456]);
            c_switch_a = new ScenarioEntity<IDevice>(457, scenarioTag.WellKnownItems[457]);
            c_switch_b = new ScenarioEntity<IDevice>(458, scenarioTag.WellKnownItems[458]);
            c_switch_c = new ScenarioEntity<IDevice>(459, scenarioTag.WellKnownItems[459]);
            c_switch_d = new ScenarioEntity<IDevice>(460, scenarioTag.WellKnownItems[460]);
            d_switch_a = new ScenarioEntity<IDevice>(461, scenarioTag.WellKnownItems[461]);
            d_switch_b = new ScenarioEntity<IDevice>(462, scenarioTag.WellKnownItems[462]);
            d_switch_c = new ScenarioEntity<IDevice>(463, scenarioTag.WellKnownItems[463]);
            d_switch_d = new ScenarioEntity<IDevice>(464, scenarioTag.WellKnownItems[464]);
            plug_landing_switch_a = new ScenarioEntity<IDevice>(465, scenarioTag.WellKnownItems[465]);
            plug_landing_switch_b = new ScenarioEntity<IDevice>(466, scenarioTag.WellKnownItems[466]);
            plug_landing_switch_c = new ScenarioEntity<IDevice>(467, scenarioTag.WellKnownItems[467]);
            plug_landing_switch_d = new ScenarioEntity<IDevice>(468, scenarioTag.WellKnownItems[468]);
            e_switch_a = new ScenarioEntity<IDevice>(469, scenarioTag.WellKnownItems[469]);
            e_switch_b = new ScenarioEntity<IDevice>(470, scenarioTag.WellKnownItems[470]);
            e_switch_c = new ScenarioEntity<IDevice>(471, scenarioTag.WellKnownItems[471]);
            e_switch_d = new ScenarioEntity<IDevice>(472, scenarioTag.WellKnownItems[472]);
            f_switch_a = new ScenarioEntity<IDevice>(473, scenarioTag.WellKnownItems[473]);
            f_switch_b = new ScenarioEntity<IDevice>(474, scenarioTag.WellKnownItems[474]);
            f_switch_c = new ScenarioEntity<IDevice>(475, scenarioTag.WellKnownItems[475]);
            f_switch_d = new ScenarioEntity<IDevice>(476, scenarioTag.WellKnownItems[476]);
            g_switch_a = new ScenarioEntity<IDevice>(477, scenarioTag.WellKnownItems[477]);
            g_switch_b = new ScenarioEntity<IDevice>(478, scenarioTag.WellKnownItems[478]);
            g_switch_c = new ScenarioEntity<IDevice>(479, scenarioTag.WellKnownItems[479]);
            g_switch_d = new ScenarioEntity<IDevice>(480, scenarioTag.WellKnownItems[480]);
            h_switch_a = new ScenarioEntity<IDevice>(481, scenarioTag.WellKnownItems[481]);
            h_switch_b = new ScenarioEntity<IDevice>(482, scenarioTag.WellKnownItems[482]);
            h_switch_c = new ScenarioEntity<IDevice>(483, scenarioTag.WellKnownItems[483]);
            h_switch_d = new ScenarioEntity<IDevice>(484, scenarioTag.WellKnownItems[484]);
            i_switch_a = new ScenarioEntity<IDevice>(485, scenarioTag.WellKnownItems[485]);
            i_switch_b = new ScenarioEntity<IDevice>(486, scenarioTag.WellKnownItems[486]);
            i_switch_c = new ScenarioEntity<IDevice>(487, scenarioTag.WellKnownItems[487]);
            i_switch_d = new ScenarioEntity<IDevice>(488, scenarioTag.WellKnownItems[488]);
            ledge_b_switch_a = new ScenarioEntity<IDevice>(489, scenarioTag.WellKnownItems[489]);
            ledge_b_switch_b = new ScenarioEntity<IDevice>(490, scenarioTag.WellKnownItems[490]);
            ledge_b_switch_c = new ScenarioEntity<IDevice>(491, scenarioTag.WellKnownItems[491]);
            ledge_b_switch_d = new ScenarioEntity<IDevice>(492, scenarioTag.WellKnownItems[492]);
            ledge_c_switch_a = new ScenarioEntity<IDevice>(493, scenarioTag.WellKnownItems[493]);
            ledge_c_switch_b = new ScenarioEntity<IDevice>(494, scenarioTag.WellKnownItems[494]);
            ledge_c_switch_c = new ScenarioEntity<IDevice>(495, scenarioTag.WellKnownItems[495]);
            ledge_c_switch_d = new ScenarioEntity<IDevice>(496, scenarioTag.WellKnownItems[496]);
            plug_switch_d = new ScenarioEntity<IDevice>(497, scenarioTag.WellKnownItems[497]);
            plug_switch_a = new ScenarioEntity<IDevice>(498, scenarioTag.WellKnownItems[498]);
            plug_switch_b = new ScenarioEntity<IDevice>(499, scenarioTag.WellKnownItems[499]);
            plug_switch_c = new ScenarioEntity<IDevice>(500, scenarioTag.WellKnownItems[500]);
            pussy_grunt1 = new Squad_pussy_grunt1(scenarioTag);
            ins_con_mid = new Squad_ins_con_mid(scenarioTag);
            ins_con_bk = new Squad_ins_con_bk(scenarioTag);
            insertion_sen = new Squad_insertion_sen(scenarioTag);
            ins_con_slide = new Squad_ins_con_slide(scenarioTag);
            hall_a_con_ini = new Squad_hall_a_con_ini(scenarioTag);
            hall_a_con_bk = new Squad_hall_a_con_bk(scenarioTag);
            hall_a_sen = new Squad_hall_a_sen(scenarioTag);
            cond_a_cov = new Squad_cond_a_cov(scenarioTag);
            cond_a_sen_ini = new Squad_cond_a_sen_ini(scenarioTag);
            cond_a_sen_a = new Squad_cond_a_sen_a(scenarioTag);
            cond_a_sen_b = new Squad_cond_a_sen_b(scenarioTag);
            hall_b_cov = new Squad_hall_b_cov(scenarioTag);
            hall_b_sen = new Squad_hall_b_sen(scenarioTag);
            plug_launch_cov = new Squad_plug_launch_cov(scenarioTag);
            plug_launch_enforcer = new Squad_plug_launch_enforcer(scenarioTag);
            plug_launch_sen = new Squad_plug_launch_sen(scenarioTag);
            gap_phantom = new Squad_gap_phantom(scenarioTag);
            gap_flood_lt = new Squad_gap_flood_lt(scenarioTag);
            gap_flood_rt = new Squad_gap_flood_rt(scenarioTag);
            plug_holder_sen = new Squad_plug_holder_sen(scenarioTag);
            plug_holder_sen_elim = new Squad_plug_holder_sen_elim(scenarioTag);
            plug_holder_bk_sen = new Squad_plug_holder_bk_sen(scenarioTag);
            plug_holder_enforcer = new Squad_plug_holder_enforcer(scenarioTag);
            plugholder_sen_bk_ini = new Squad_plugholder_sen_bk_ini(scenarioTag);
            plug_holder_flood_a = new Squad_plug_holder_flood_a(scenarioTag);
            plug_holder_flood_b = new Squad_plug_holder_flood_b(scenarioTag);
            plug_holder_flood_c = new Squad_plug_holder_flood_c(scenarioTag);
            plug_holder_flood_d = new Squad_plug_holder_flood_d(scenarioTag);
            plugholder_inf = new Squad_plugholder_inf(scenarioTag);
            plugholder_bk_flood_a = new Squad_plugholder_bk_flood_a(scenarioTag);
            plugholder_bk_flood_b = new Squad_plugholder_bk_flood_b(scenarioTag);
            plugholder_bk_infec_a = new Squad_plugholder_bk_infec_a(scenarioTag);
            plugholder_bk_infec_b = new Squad_plugholder_bk_infec_b(scenarioTag);
            plugholder_lower_hall_flood = new Squad_plugholder_lower_hall_flood(scenarioTag);
            plugholder_lower_hall_infec = new Squad_plugholder_lower_hall_infec(scenarioTag);
            hall_c_marines = new Squad_hall_c_marines(scenarioTag);
            hall_c_infec = new Squad_hall_c_infec(scenarioTag);
            hall_c_flood_near = new Squad_hall_c_flood_near(scenarioTag);
            hall_c_flood_mid = new Squad_hall_c_flood_mid(scenarioTag);
            hall_c_flood_far = new Squad_hall_c_flood_far(scenarioTag);
            hall_c_flood_c = new Squad_hall_c_flood_c(scenarioTag);
            hall_c_flood_d = new Squad_hall_c_flood_d(scenarioTag);
            hall_c_flood_e = new Squad_hall_c_flood_e(scenarioTag);
            hall_c_flood_f = new Squad_hall_c_flood_f(scenarioTag);
            hall_c_carrier_c = new Squad_hall_c_carrier_c(scenarioTag);
            hall_c_carrier_d = new Squad_hall_c_carrier_d(scenarioTag);
            hall_c_carrier_e = new Squad_hall_c_carrier_e(scenarioTag);
            hall_c_sen_tube = new Squad_hall_c_sen_tube(scenarioTag);
            hall_c_em_sen = new Squad_hall_c_em_sen(scenarioTag);
            ledge_a_enforcer = new Squad_ledge_a_enforcer(scenarioTag);
            ledge_a_sen_ini = new Squad_ledge_a_sen_ini(scenarioTag);
            ledge_a_sen = new Squad_ledge_a_sen(scenarioTag);
            ledge_a_flood_ini = new Squad_ledge_a_flood_ini(scenarioTag);
            ledge_a_flood_b = new Squad_ledge_a_flood_b(scenarioTag);
            ledge_a_flood_c = new Squad_ledge_a_flood_c(scenarioTag);
            ledge_a_flood_d1 = new Squad_ledge_a_flood_d1(scenarioTag);
            ledge_a_flood_d2 = new Squad_ledge_a_flood_d2(scenarioTag);
            ledge_a_flood_e = new Squad_ledge_a_flood_e(scenarioTag);
            ledge_a_flood_f = new Squad_ledge_a_flood_f(scenarioTag);
            ledge_a_flood_bot_a = new Squad_ledge_a_flood_bot_a(scenarioTag);
            ledge_a_flood_bot_b = new Squad_ledge_a_flood_bot_b(scenarioTag);
            cond_b_flood_tube_a = new Squad_cond_b_flood_tube_a(scenarioTag);
            cond_b_flood_a_ini_a = new Squad_cond_b_flood_a_ini_a(scenarioTag);
            cond_b_flood_a_ini_b = new Squad_cond_b_flood_a_ini_b(scenarioTag);
            cond_b_flood_a_ini_c = new Squad_cond_b_flood_a_ini_c(scenarioTag);
            cond_b_carrier_a = new Squad_cond_b_carrier_a(scenarioTag);
            cond_b_flood_a = new Squad_cond_b_flood_a(scenarioTag);
            cond_b_flood_b = new Squad_cond_b_flood_b(scenarioTag);
            cond_b_flood_c = new Squad_cond_b_flood_c(scenarioTag);
            cond_b_enforcer = new Squad_cond_b_enforcer(scenarioTag);
            cond_b_flood_b_ini = new Squad_cond_b_flood_b_ini(scenarioTag);
            cond_b_flood_c_ini_a = new Squad_cond_b_flood_c_ini_a(scenarioTag);
            cond_b_flood_c_ini_b = new Squad_cond_b_flood_c_ini_b(scenarioTag);
            cond_b_humans = new Squad_cond_b_humans(scenarioTag);
            cond_b_infection_c = new Squad_cond_b_infection_c(scenarioTag);
            cond_b_sen_b = new Squad_cond_b_sen_b(scenarioTag);
            cond_b_sen_tube_b = new Squad_cond_b_sen_tube_b(scenarioTag);
            ledge_c_flood_dead = new Squad_ledge_c_flood_dead(scenarioTag);
            ledge_c_flood_fr = new Squad_ledge_c_flood_fr(scenarioTag);
            ledge_c_flood_bk = new Squad_ledge_c_flood_bk(scenarioTag);
            ledge_c_infec_fr = new Squad_ledge_c_infec_fr(scenarioTag);
            ledge_c_infec_bk = new Squad_ledge_c_infec_bk(scenarioTag);
            qz_initial_flood_ini = new Squad_qz_initial_flood_ini(scenarioTag);
            qz_initial_flood_carrier_ini = new Squad_qz_initial_flood_carrier_ini(scenarioTag);
            qz_initial_flood_bridge = new Squad_qz_initial_flood_bridge(scenarioTag);
            qz_initial_flood_camp = new Squad_qz_initial_flood_camp(scenarioTag);
            qz_initial_flood_carrier_camp = new Squad_qz_initial_flood_carrier_camp(scenarioTag);
            qz_initial_flood_cave = new Squad_qz_initial_flood_cave(scenarioTag);
            qz_ini_ins_pods = new Squad_qz_ini_ins_pods(scenarioTag);
            qz_cov_def_flood_ini = new Squad_qz_cov_def_flood_ini(scenarioTag);
            qz_cov_def_flood_a = new Squad_qz_cov_def_flood_a(scenarioTag);
            qz_cov_def_flood_b = new Squad_qz_cov_def_flood_b(scenarioTag);
            qz_cov_def_flood_c = new Squad_qz_cov_def_flood_c(scenarioTag);
            qz_cov_def_flood_d = new Squad_qz_cov_def_flood_d(scenarioTag);
            qz_cov_def_flood_e = new Squad_qz_cov_def_flood_e(scenarioTag);
            qz_cov_def_flood_f = new Squad_qz_cov_def_flood_f(scenarioTag);
            qz_cov_def_flood_g = new Squad_qz_cov_def_flood_g(scenarioTag);
            qz_cov_def_carrier = new Squad_qz_cov_def_carrier(scenarioTag);
            qz_cov_def_soc = new Squad_qz_cov_def_soc(scenarioTag);
            qz_cov_def_cov = new Squad_qz_cov_def_cov(scenarioTag);
            qz_ini_turrets = new Squad_qz_ini_turrets(scenarioTag);
            qz_camp_turrets = new Squad_qz_camp_turrets(scenarioTag);
            ledge_c_phantom = new Squad_ledge_c_phantom(scenarioTag);
            ledge_b_sen = new Squad_ledge_b_sen(scenarioTag);
            ledge_b_flood = new Squad_ledge_b_flood(scenarioTag);
            ledge_a_flood_dead = new Squad_ledge_a_flood_dead(scenarioTag);
            qz_phantom = new Squad_qz_phantom(scenarioTag);
            brutes_01 = new Squad_brutes_01(scenarioTag);
            brutes_02 = new Squad_brutes_02(scenarioTag);
            elites_01 = new Squad_elites_01(scenarioTag);
            elites_02 = new Squad_elites_02(scenarioTag);
            elites_03 = new Squad_elites_03(scenarioTag);
        }

        public class Squad_pussy_grunt1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_pussy_grunt1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ins_con_mid
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[1].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[1].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[1].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_ins_con_mid(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ins_con_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition shooter => ScenarioTag.AiSquadDefinitions[2].StartingLocations[0];
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[2].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_ins_con_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_insertion_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[3].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[3].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[3].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_insertion_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ins_con_slide
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition shooter => ScenarioTag.AiSquadDefinitions[4].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_ins_con_slide(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_con_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition sp_0 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[0];
            public IAiActorDefinition sp_1 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition sp_2 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_hall_a_con_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_con_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_hall_a_con_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_a_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[7].StartingLocations[0];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[7].StartingLocations[1];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[7].StartingLocations[2];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[7].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_hall_a_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_a_cov
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_cond_a_cov(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_a_sen_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_cond_a_sen_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_a_sen_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[10].StartingLocations[0];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[10].StartingLocations[1];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[10].StartingLocations[2];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[10].StartingLocations[3];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[10].StartingLocations[4];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[10].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_cond_a_sen_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_a_sen_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[11].StartingLocations[0];
            public IAiActorDefinition j => ScenarioTag.AiSquadDefinitions[11].StartingLocations[1];
            public IAiActorDefinition k => ScenarioTag.AiSquadDefinitions[11].StartingLocations[2];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[11].StartingLocations[3];
            public IAiActorDefinition m => ScenarioTag.AiSquadDefinitions[11].StartingLocations[4];
            public IAiActorDefinition n => ScenarioTag.AiSquadDefinitions[11].StartingLocations[5];
            public IAiActorDefinition o => ScenarioTag.AiSquadDefinitions[11].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_cond_a_sen_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_b_cov
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[4];
            public IAiActorDefinition wimp => ScenarioTag.AiSquadDefinitions[12].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_hall_b_cov(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_b_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[13].StartingLocations[0];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[13].StartingLocations[1];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[13].StartingLocations[2];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[13].StartingLocations[3];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[13].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_hall_b_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_launch_cov
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_plug_launch_cov(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_launch_enforcer
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_plug_launch_enforcer(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_launch_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[16].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[16].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[16].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[16].StartingLocations[3];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[16].StartingLocations[4];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[16].StartingLocations[5];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[16].StartingLocations[6];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[16].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_plug_launch_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gap_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_gap_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gap_flood_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad_gap_flood_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gap_flood_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_gap_flood_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_holder_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[20].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[20].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[20].StartingLocations[3];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[20].StartingLocations[4];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[20].StartingLocations[5];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[20].StartingLocations[6];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[20].StartingLocations[7];
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[20].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_plug_holder_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_holder_sen_elim
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_plug_holder_sen_elim(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_holder_bk_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[22].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[22].StartingLocations[3];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[22].StartingLocations[4];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[22].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_plug_holder_bk_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_holder_enforcer
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_plug_holder_enforcer(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plugholder_sen_bk_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_plugholder_sen_bk_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_holder_flood_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[25].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_plug_holder_flood_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_holder_flood_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_plug_holder_flood_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_holder_flood_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_plug_holder_flood_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plug_holder_flood_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_plug_holder_flood_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plugholder_inf
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_plugholder_inf(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plugholder_bk_flood_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[10];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[11];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_plugholder_bk_flood_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plugholder_bk_flood_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[10];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[11];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_plugholder_bk_flood_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plugholder_bk_infec_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_plugholder_bk_infec_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plugholder_bk_infec_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_plugholder_bk_infec_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plugholder_lower_hall_flood
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_plugholder_lower_hall_flood(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_plugholder_lower_hall_infec
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_plugholder_lower_hall_infec(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_marines
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[36].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[36].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[36].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[36].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_hall_c_marines(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_infec
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_hall_c_infec(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_flood_near
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_hall_c_flood_near(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_flood_mid
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_hall_c_flood_mid(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_flood_far
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[3];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_hall_c_flood_far(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_flood_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_hall_c_flood_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_flood_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_hall_c_flood_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_flood_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_hall_c_flood_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_flood_f
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_hall_c_flood_f(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_carrier_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_hall_c_carrier_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_carrier_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_hall_c_carrier_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_carrier_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_hall_c_carrier_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_sen_tube
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_hall_c_sen_tube(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_hall_c_em_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[49].StartingLocations[0];
            public IAiActorDefinition j => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition k => ScenarioTag.AiSquadDefinitions[49].StartingLocations[2];
            public IAiActorDefinition l => ScenarioTag.AiSquadDefinitions[49].StartingLocations[3];
            public IAiActorDefinition m => ScenarioTag.AiSquadDefinitions[49].StartingLocations[4];
            public IAiActorDefinition o => ScenarioTag.AiSquadDefinitions[49].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_hall_c_em_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_enforcer
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_ledge_a_enforcer(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_sen_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_ledge_a_sen_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[52].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[52].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[52].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[52].StartingLocations[3];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[52].StartingLocations[4];
            public IAiActorDefinition f => ScenarioTag.AiSquadDefinitions[52].StartingLocations[5];
            public IAiActorDefinition g => ScenarioTag.AiSquadDefinitions[52].StartingLocations[6];
            public IAiActorDefinition h => ScenarioTag.AiSquadDefinitions[52].StartingLocations[7];
            public IAiActorDefinition i => ScenarioTag.AiSquadDefinitions[52].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_ledge_a_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_ledge_a_flood_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[4];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[5];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[6];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad_ledge_a_flood_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_ledge_a_flood_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_d1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_ledge_a_flood_d1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_d2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_ledge_a_flood_d2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_ledge_a_flood_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_f
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_ledge_a_flood_f(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_bot_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_ledge_a_flood_bot_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_bot_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_ledge_a_flood_bot_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_tube_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_cond_b_flood_tube_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_a_ini_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_cond_b_flood_a_ini_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_a_ini_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_cond_b_flood_a_ini_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_a_ini_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_cond_b_flood_a_ini_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_carrier_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_cond_b_carrier_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_cond_b_flood_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_cond_b_flood_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_cond_b_flood_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_enforcer
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[70].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_cond_b_enforcer(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_b_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_cond_b_flood_b_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_c_ini_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_cond_b_flood_c_ini_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_flood_c_ini_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_cond_b_flood_c_ini_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_humans
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[74].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[74].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[74].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_cond_b_humans(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_infection_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_cond_b_infection_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_sen_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[0];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[1];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[2];
            public IAiActorDefinition _4 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[3];
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[76].StartingLocations[4];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[76].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad_cond_b_sen_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_cond_b_sen_tube_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[77].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[77].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[77].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[77].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_cond_b_sen_tube_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_c_flood_dead
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_ledge_c_flood_dead(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_c_flood_fr
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_ledge_c_flood_fr(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_c_flood_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_ledge_c_flood_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_c_infec_fr
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_ledge_c_infec_fr(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_c_infec_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_ledge_c_infec_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_initial_flood_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_qz_initial_flood_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_initial_flood_carrier_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_qz_initial_flood_carrier_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_initial_flood_bridge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[85];
            public Squad_qz_initial_flood_bridge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_initial_flood_camp
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[5];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[6];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[7];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[8];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[9];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[86];
            public Squad_qz_initial_flood_camp(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_initial_flood_carrier_camp
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[87];
            public Squad_qz_initial_flood_carrier_camp(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_initial_flood_cave
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[88];
            public Squad_qz_initial_flood_cave(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ini_ins_pods
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[89].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[89].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[89].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[89].StartingLocations[3];
            public IAiActorDefinition e => ScenarioTag.AiSquadDefinitions[89].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[89];
            public Squad_qz_ini_ins_pods(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_flood_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[90];
            public Squad_qz_cov_def_flood_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_flood_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[91];
            public Squad_qz_cov_def_flood_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_flood_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[92];
            public Squad_qz_cov_def_flood_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_flood_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[3];
            public IAiActorDefinition starting_locations_41 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[93];
            public Squad_qz_cov_def_flood_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_flood_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[94].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[94];
            public Squad_qz_cov_def_flood_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_flood_e
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[95].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[95];
            public Squad_qz_cov_def_flood_e(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_flood_f
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[96];
            public Squad_qz_cov_def_flood_f(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_flood_g
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[1];
            public IAiActorDefinition starting_locations_41 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[97];
            public Squad_qz_cov_def_flood_g(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_carrier
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[98];
            public Squad_qz_cov_def_carrier(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_soc
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition soc => ScenarioTag.AiSquadDefinitions[99].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[99];
            public Squad_qz_cov_def_soc(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_cov
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[100];
            public Squad_qz_cov_def_cov(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ini_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[101].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[101].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[101];
            public Squad_qz_ini_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_camp_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[102].StartingLocations[0];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[102].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[102];
            public Squad_qz_camp_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_c_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom => ScenarioTag.AiSquadDefinitions[103].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[103];
            public Squad_ledge_c_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_b_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[104].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[104];
            public Squad_ledge_b_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_b_flood
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[5];
            public IAiActorDefinition starting_locations_61 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[6];
            public IAiActorDefinition starting_locations_71 => ScenarioTag.AiSquadDefinitions[105].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[105];
            public Squad_ledge_b_flood(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ledge_a_flood_dead
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[106];
            public Squad_ledge_a_flood_dead(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[107];
            public Squad_qz_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_brutes_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[108];
            public Squad_brutes_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_brutes_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[109];
            public Squad_brutes_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_elites_01
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[110];
            public Squad_elites_01(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_elites_02
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[0];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[111];
            public Squad_elites_02(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_elites_03
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[112];
            public Squad_elites_03(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}