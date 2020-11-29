namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_06b_floodzone : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> johnson_rifle { get; set; }
        public ScenarioEntity<IScenery> key_intra2_01 { get; set; }
        public ScenarioEntity<IScenery> key_intra2_02 { get; set; }
        public ScenarioEntity<IBloc> e21_ice4 { get; set; }
        public ScenarioEntity<IBloc> e21_ice0 { get; set; }
        public ScenarioEntity<IBloc> e21_ice1 { get; set; }
        public ScenarioEntity<IBloc> e21_ice2 { get; set; }
        public ScenarioEntity<IBloc> e21_ice3 { get; set; }
        public ScenarioEntity<IBloc> e21_ice5 { get; set; }
        public ScenarioEntity<IBloc> e21_ice6 { get; set; }
        public ScenarioEntity<IBloc> e21_ice7 { get; set; }
        public ScenarioEntity<IScenery> hammer { get; set; }
        public ScenarioEntity<IScenery> anchor_intra2 { get; set; }
        public ScenarioEntity<IScenery> anchor_intra1 { get; set; }
        public ScenarioEntity<IScenery> anchor_x07 { get; set; }
        public ScenarioEntity<IScenery> x07_tentacle { get; set; }
        public ScenarioEntity<IScenery> brute_shot_01 { get; set; }
        public ScenarioEntity<IScenery> brute_shot_02 { get; set; }
        public ScenarioEntity<IScenery> brute_rifle_01 { get; set; }
        public ScenarioEntity<IScenery> brute_rifle_02 { get; set; }
        public ScenarioEntity<IScenery> index_container { get; set; }
        public ScenarioEntity<IScenery> energy_blade { get; set; }
        public ScenarioEntity<IScenery> iac { get; set; }
        public ScenarioEntity<IScenery> miranda_smg_01 { get; set; }
        public ScenarioEntity<IScenery> miranda_smg_02 { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> johnson { get; set; }
        public ScenarioEntity<IUnit> dervish { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> brute_01 { get; set; }
        public ScenarioEntity<IUnit> brute_02 { get; set; }
        public ScenarioEntity<IUnit> brute_03 { get; set; }
        public ScenarioEntity<IUnit> brute_04 { get; set; }
        public ScenarioEntity<IUnit> commander { get; set; }
        public ScenarioEntity<IUnit> dervish_intra1 { get; set; }
        public ScenarioEntity<IUnit> commander_intra1 { get; set; }
        public ScenarioEntity<IUnit> elite_04 { get; set; }
        public ScenarioEntity<IUnit> elite_03 { get; set; }
        public ScenarioEntity<IUnit> elite_02 { get; set; }
        public ScenarioEntity<IUnit> elite_01 { get; set; }
        public ScenarioEntity<IVehicle> throne_truth { get; set; }
        public ScenarioEntity<IVehicle> throne_mercy { get; set; }
        public ScenarioEntity<IVehicle> phantom_01 { get; set; }
        public ScenarioEntity<IVehicle> qz_ext_a_ghost { get; set; }
        public ScenarioEntity<IVehicle> phantom_intra1 { get; set; }
        public ScenarioEntity<IVehicle> spectre_intra1 { get; set; }
        public ScenarioEntity<IWeapon> e26_smg01 { get; set; }
        public ScenarioEntity<IWeapon> e26_smg11 { get; set; }
        public ScenarioEntity<IWeapon> ice_cream_head { get; set; }
        public ScenarioEntity<IWeapon> smg_real_01 { get; set; }
        public ScenarioEntity<IWeapon> smg_real_02 { get; set; }
        public ScenarioEntity<IDevice> key { get; set; }
        public ScenarioEntity<IDevice> key_ride_door0 { get; set; }
        public ScenarioEntity<IDevice> key_ride_door1 { get; set; }
        public ScenarioEntity<IDevice> key_ride_door3 { get; set; }
        public ScenarioEntity<IDevice> key_ride_door2 { get; set; }
        public ScenarioEntity<IDevice> key_human { get; set; }
        public ScenarioEntity<IDevice> human_key_door0 { get; set; }
        public ScenarioEntity<IDevice> human_key_door1 { get; set; }
        public ScenarioEntity<IDevice> human_key_door2 { get; set; }
        public ScenarioEntity<IDevice> qz_door_a { get; set; }
        public ScenarioEntity<IDevice> qz_dam_door_a { get; set; }
        public ScenarioEntity<IDevice> qz_dam_door_b { get; set; }
        public ScenarioEntity<IDevice> qz_dam_door_c { get; set; }
        public ScenarioEntity<IDevice> qz_dam_door_d { get; set; }
        public ScenarioEntity<IDevice> qz_dam_door_e { get; set; }
        public ScenarioEntity<IDevice> qz_watch_base { get; set; }
        public ScenarioEntity<IDevice> veh_int_door_b { get; set; }
        public ScenarioEntity<IDevice> veh_int_door_a { get; set; }
        public ScenarioEntity<IDevice> key_docked { get; set; }
        public ScenarioEntity<IDevice> dam_door_a1 { get; set; }
        public ScenarioEntity<IDevice> dam_door_b1 { get; set; }
        public ScenarioEntity<IDevice> key_switch { get; set; }
        public ScenarioEntity<IDevice> qz_cov_def_tower_pod_a { get; set; }
        public ScenarioEntity<IDevice> qz_cov_def_tower_pod_b { get; set; }
        public ICameraPathTarget test1 => Scenario.CameraPathTargets[0].GameObject;
        public ICameraPathTarget insertion_temp => Scenario.CameraPathTargets[1].GameObject;
        public Squad_empty empty { get; set; }
        public Squad_qz_cov_def_spectre qz_cov_def_spectre { get; set; }
        public Squad_qz_cov_def_ghosts qz_cov_def_ghosts { get; set; }
        public Squad_veh_int_hog_ab veh_int_hog_ab { get; set; }
        public Squad_veh_int_ghost_ab veh_int_ghost_ab { get; set; }
        public Squad_______COVENANT_DEFENSE_____ ______COVENANT_DEFENSE_____ { get; set; }
        public Squad_qz_cov_def_phantom qz_cov_def_phantom { get; set; }
        public Squad_qz_cov_def_spec_ops qz_cov_def_spec_ops { get; set; }
        public Squad_qz_cov_def_enforcer_a qz_cov_def_enforcer_a { get; set; }
        public Squad_qz_cov_def_enforcer_b qz_cov_def_enforcer_b { get; set; }
        public Squad_qz_cov_def_sen_elim qz_cov_def_sen_elim { get; set; }
        public Squad_______VEHICLE_INTERIOR______ ______VEHICLE_INTERIOR______ { get; set; }
        public Squad_veh_int_enf_a veh_int_enf_a { get; set; }
        public Squad_veh_int_enf_b veh_int_enf_b { get; set; }
        public Squad_veh_int_enf_d veh_int_enf_d { get; set; }
        public Squad_veh_int_sen_elim_ini veh_int_sen_elim_ini { get; set; }
        public Squad_veh_int_sen_elim_lt veh_int_sen_elim_lt { get; set; }
        public Squad_veh_int_sen_elim_rt veh_int_sen_elim_rt { get; set; }
        public Squad_veh_int_scorpion veh_int_scorpion { get; set; }
        public Squad_veh_int_flood_ghosts_ini veh_int_flood_ghosts_ini { get; set; }
        public Squad_veh_int_flood_hog_bk veh_int_flood_hog_bk { get; set; }
        public Squad_veh_int_flood_ghosts_bk veh_int_flood_ghosts_bk { get; set; }
        public Squad_veh_int_flood_bk veh_int_flood_bk { get; set; }
        public Squad_veh_int_wraith veh_int_wraith { get; set; }
        public Squad_veh_int_turrets veh_int_turrets { get; set; }
        public Squad_________EXTERIOR_A________ ________EXTERIOR_A________ { get; set; }
        public Squad_qz_ext_a_phantom qz_ext_a_phantom { get; set; }
        public Squad_qz_ext_a_spec_ops qz_ext_a_spec_ops { get; set; }
        public Squad_qz_ext_a_ghosts qz_ext_a_ghosts { get; set; }
        public Squad_qz_ext_a_dam_human qz_ext_a_dam_human { get; set; }
        public Squad_qz_ext_a_dam_enf qz_ext_a_dam_enf { get; set; }
        public Squad_qz_ext_a_dam_enf_door qz_ext_a_dam_enf_door { get; set; }
        public Squad_qz_ext_a_dam_sen qz_ext_a_dam_sen { get; set; }
        public Squad_qz_ext_a_dam_sen_elim qz_ext_a_dam_sen_elim { get; set; }
        public Squad_qz_ext_a_dam_flood_ini qz_ext_a_dam_flood_ini { get; set; }
        public Squad_qz_ext_a_dam_flood_cliff_a qz_ext_a_dam_flood_cliff_a { get; set; }
        public Squad_qz_ext_a_dam_flood_cliff_b qz_ext_a_dam_flood_cliff_b { get; set; }
        public Squad_qz_ext_a_flood_wraith_fr qz_ext_a_flood_wraith_fr { get; set; }
        public Squad_qz_ext_a_flood_wraith_bk qz_ext_a_flood_wraith_bk { get; set; }
        public Squad_qz_ext_a_flood_wraith_ledge qz_ext_a_flood_wraith_ledge { get; set; }
        public Squad_qz_ext_a_flood_rocket qz_ext_a_flood_rocket { get; set; }
        public Squad_qz_ext_a_flood_c qz_ext_a_flood_c { get; set; }
        public Squad_qz_ext_a_flood_c2 qz_ext_a_flood_c2 { get; set; }
        public Squad_qz_ext_a_flood_d qz_ext_a_flood_d { get; set; }
        public Squad_qz_ext_a_flood_ghosts qz_ext_a_flood_ghosts { get; set; }
        public Squad_qz_ext_a_enf_a qz_ext_a_enf_a { get; set; }
        public Squad_qz_ext_a_enf_b qz_ext_a_enf_b { get; set; }
        public Squad_qz_ext_a_enf_bk qz_ext_a_enf_bk { get; set; }
        public Squad_ext_a_sen_elim_bk ext_a_sen_elim_bk { get; set; }
        public Squad_ext_a_flood_ghost_fr ext_a_flood_ghost_fr { get; set; }
        public Squad_squads_160 squads_160 { get; set; }
        public Squad_squads_161 squads_161 { get; set; }
        public Squad_squads_162 squads_162 { get; set; }
        public Squad_squads_163 squads_163 { get; set; }
        public Squad_squads_164 squads_164 { get; set; }
        public Squad_______CRASHED_FACTORY______ ______CRASHED_FACTORY______ { get; set; }
        public Squad_fact_ent_enf fact_ent_enf { get; set; }
        public Squad_fact_ent_sen fact_ent_sen { get; set; }
        public Squad_fact_ent_flood_turrets fact_ent_flood_turrets { get; set; }
        public Squad_fact_ent_flood_scorpion fact_ent_flood_scorpion { get; set; }
        public Squad_fact_ent_flood_wraith_a fact_ent_flood_wraith_a { get; set; }
        public Squad_fact_ent_flood_wraith_b fact_ent_flood_wraith_b { get; set; }
        public Squad_______FACTORY______ ______FACTORY______ { get; set; }
        public Squad_factory_1_flood_intro factory_1_flood_intro { get; set; }
        public Squad_factory_1_flood_initial_mid factory_1_flood_initial_mid { get; set; }
        public Squad_factory_1_flood_initial_end factory_1_flood_initial_end { get; set; }
        public Squad_factory_1_sentinels_intro factory_1_sentinels_intro { get; set; }
        public Squad_factory_1_sentinels_initial_mid factory_1_sentinels_initial_mid { get; set; }
        public Squad_factory_1_sentinels_initial_end factory_1_sentinels_initial_end { get; set; }
        public Squad_factory_1_major factory_1_major { get; set; }
        public Squad_factory_1_sentinels_01_low factory_1_sentinels_01_low { get; set; }
        public Squad_factory_1_sentinels_01_high factory_1_sentinels_01_high { get; set; }
        public Squad_factory_1_sentinels_02_low factory_1_sentinels_02_low { get; set; }
        public Squad_factory_1_sentinels_02_high factory_1_sentinels_02_high { get; set; }
        public Squad_factory_1_sentinels_03_low factory_1_sentinels_03_low { get; set; }
        public Squad_factory_1_sentinels_03_high factory_1_sentinels_03_high { get; set; }
        public Squad_factory_1_flood_end factory_1_flood_end { get; set; }
        public Squad_factory_1_flood_tubes_far factory_1_flood_tubes_far { get; set; }
        public Squad_factory_1_flood_tubes_near factory_1_flood_tubes_near { get; set; }
        public Squad_factory_1_flood_alcove factory_1_flood_alcove { get; set; }
        public Squad_gorge_jugg_a gorge_jugg_a { get; set; }
        public Squad_gorge_jugg_b gorge_jugg_b { get; set; }
        public Squad_gorge_enf gorge_enf { get; set; }
        public Squad_gorge_sen gorge_sen { get; set; }
        public Squad_gorge_flood_bk gorge_flood_bk { get; set; }
        public Squad_gorge_flood_ini gorge_flood_ini { get; set; }
        public Squad_gorge_flood_bk_cave gorge_flood_bk_cave { get; set; }
        public Squad_factory2_sen_dead factory2_sen_dead { get; set; }
        public Squad_factory2_flood_ini factory2_flood_ini { get; set; }
        public Squad_factory2_flood_mid factory2_flood_mid { get; set; }
        public Squad_factory2_flood_bk factory2_flood_bk { get; set; }
        public Squad_factory2_jugg factory2_jugg { get; set; }
        public Squad_factory2_flood_bk_tunnel factory2_flood_bk_tunnel { get; set; }
        public Squad_factory2_sen_bk_tunnel factory2_sen_bk_tunnel { get; set; }
        public Squad_______EXT_B______ ______EXT_B______ { get; set; }
        public Squad_qz_ext_b_fact_scorpion qz_ext_b_fact_scorpion { get; set; }
        public Squad_qz_ext_b_fact_humans qz_ext_b_fact_humans { get; set; }
        public Squad_qz_ext_b_fact_wraith qz_ext_b_fact_wraith { get; set; }
        public Squad_qz_ext_b_fact_ghosts qz_ext_b_fact_ghosts { get; set; }
        public Squad_qz_ext_b_fact_warthog qz_ext_b_fact_warthog { get; set; }
        public Squad_qz_ext_b_fact_ghost_bk qz_ext_b_fact_ghost_bk { get; set; }
        public Squad_qz_ext_b_fact_ghosts_spare qz_ext_b_fact_ghosts_spare { get; set; }
        public Squad_qz_ext_b_fact_flood qz_ext_b_fact_flood { get; set; }
        public Squad_qz_ext_b_cov_phantom qz_ext_b_cov_phantom { get; set; }
        public Squad_qz_ext_b_cov_ghosts qz_ext_b_cov_ghosts { get; set; }
        public Squad_qz_ext_b_cov_spectre qz_ext_b_cov_spectre { get; set; }
        public Squad_qz_ext_b_cov_spec_ops qz_ext_b_cov_spec_ops { get; set; }
        public Squad_qz_ext_b_wraith_a qz_ext_b_wraith_a { get; set; }
        public Squad_qz_ext_b_wraith_b qz_ext_b_wraith_b { get; set; }
        public Squad_qz_ext_b_ghosts_a qz_ext_b_ghosts_a { get; set; }
        public Squad_qz_ext_b_ghosts_b qz_ext_b_ghosts_b { get; set; }
        public Squad_qz_ext_b_warthog qz_ext_b_warthog { get; set; }
        public Squad_qz_ext_b_warthog_gauss qz_ext_b_warthog_gauss { get; set; }
        public Squad_qz_ext_b_enf_a qz_ext_b_enf_a { get; set; }
        public Squad_qz_ext_b_enf_b qz_ext_b_enf_b { get; set; }
        public Squad_qz_ext_b_ent_scorpion qz_ext_b_ent_scorpion { get; set; }
        public Squad_qz_ext_b_ent_wraith_a qz_ext_b_ent_wraith_a { get; set; }
        public Squad_qz_ext_b_ent_cov_phantom qz_ext_b_ent_cov_phantom { get; set; }
        public Squad_qz_ext_b_ent_turrets qz_ext_b_ent_turrets { get; set; }
        public Squad_qz_ext_b_ent_flood_bk qz_ext_b_ent_flood_bk { get; set; }
        public Squad_qz_ext_b_ent_ghost_bk qz_ext_b_ent_ghost_bk { get; set; }
        public Squad_qz_ext_b_ent_enf qz_ext_b_ent_enf { get; set; }
        public Squad_qz_ext_b_ent_flood_tube_a qz_ext_b_ent_flood_tube_a { get; set; }
        public Squad_qz_ext_b_ent_flood_tube_b qz_ext_b_ent_flood_tube_b { get; set; }
        public Squad_squads_156 squads_156 { get; set; }
        public Squad_squads_157 squads_157 { get; set; }
        public Squad_______KEY______ ______KEY______ { get; set; }
        public Squad_e20_cov_inf0 e20_cov_inf0 { get; set; }
        public Squad_e20_fld_combats0_0 e20_fld_combats0_0 { get; set; }
        public Squad_e20_fld_combats0_1 e20_fld_combats0_1 { get; set; }
        public Squad_e20_fld_combats1 e20_fld_combats1 { get; set; }
        public Squad_e21_cov_inf0_0 e21_cov_inf0_0 { get; set; }
        public Squad_e21_cov_inf0_1 e21_cov_inf0_1 { get; set; }
        public Squad_e21_fld_inf0_0 e21_fld_inf0_0 { get; set; }
        public Squad_e21_fld_inf0_1 e21_fld_inf0_1 { get; set; }
        public Squad_e21_fld_inf0_2 e21_fld_inf0_2 { get; set; }
        public Squad_e21_fld_carriers0 e21_fld_carriers0 { get; set; }
        public Squad_e21_fld_inf1_0 e21_fld_inf1_0 { get; set; }
        public Squad_e21_fld_inf1_1 e21_fld_inf1_1 { get; set; }
        public Squad_e21_fld_inf1_2 e21_fld_inf1_2 { get; set; }
        public Squad_e21_fld_carriers1 e21_fld_carriers1 { get; set; }
        public Squad_e22_cov_inf0 e22_cov_inf0 { get; set; }
        public Squad_e22_cov_inf1_0 e22_cov_inf1_0 { get; set; }
        public Squad_e22_cov_inf1_1 e22_cov_inf1_1 { get; set; }
        public Squad_e22_fld_inf0_0 e22_fld_inf0_0 { get; set; }
        public Squad_e22_fld_inf0_1 e22_fld_inf0_1 { get; set; }
        public Squad_e22_fld_inf1 e22_fld_inf1 { get; set; }
        public Squad_e23_cov_inf0 e23_cov_inf0 { get; set; }
        public Squad_e23_fld_inf0_0 e23_fld_inf0_0 { get; set; }
        public Squad_e23_fld_inf0_1 e23_fld_inf0_1 { get; set; }
        public Squad_e24_cov_inf0 e24_cov_inf0 { get; set; }
        public Squad_e24_fld_inf0 e24_fld_inf0 { get; set; }
        public Squad_e24_fld_inf1_0 e24_fld_inf1_0 { get; set; }
        public Squad_e24_fld_inf1_1 e24_fld_inf1_1 { get; set; }
        public Squad_e24_fld_inf2 e24_fld_inf2 { get; set; }
        public Squad_e25_cov_inf0 e25_cov_inf0 { get; set; }
        public Squad_e25_fld_inf0_0 e25_fld_inf0_0 { get; set; }
        public Squad_e25_fld_inf0_1 e25_fld_inf0_1 { get; set; }
        public Squad_e25_fld_inf0_2 e25_fld_inf0_2 { get; set; }
        public Squad_e25_fld_inf1_0 e25_fld_inf1_0 { get; set; }
        public Squad_e25_fld_inf1_1 e25_fld_inf1_1 { get; set; }
        public Squad_e25_fld_inf1_2 e25_fld_inf1_2 { get; set; }
        public Squad_e26_fld_infection_forms0 e26_fld_infection_forms0 { get; set; }
        public Squad_key_ride_tartarus key_ride_tartarus { get; set; }
        public Squad_silly silly { get; set; }
        public Squad_key_cov_dump key_cov_dump { get; set; }
        public Squad_squads_166 squads_166 { get; set; }
        public Squad_squads_167 squads_167 { get; set; }
        public Squad_squads_168 squads_168 { get; set; }
        public Squad_squads_169 squads_169 { get; set; }
        public IAiActorDefinition covenant1 => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition covenant_infantry => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition covenant_vehicles => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition flood => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition flood_vehicles => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition sentinels => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition humans => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition cov_def_sentinels => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition cov_def_enf => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition veh_int_flood => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition veh_int_flood_a => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition veh_int_flood_b => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition veh_int_flood_c => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition veh_int_flood_d => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition veh_int_sen => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition veh_int_sen_a => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition veh_int_sen_b => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition veh_int_sen_c => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition veh_int_sen_d => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition ext_a_flood => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition ext_a_flood_dam_a => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition ext_a_flood_dam_b => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition ext_a_flood_a => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition ext_a_flood_b => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition ext_a_flood_c => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition ext_a_flood_d => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition ext_a_flood_e => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition ext_a_flood_f => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition ext_a_sen => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition ext_a_sen_dam_a => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition ext_a_sen_dam_b => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition ext_a_sen_a => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition ext_a_sen_b => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition ext_a_sen_c => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition ext_a_sen_d => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition ext_a_sen_e => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition ext_a_sen_f => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition fact_ent_sentinels => Scenario.AiSquadGroupDefinitions[37];
        public IAiActorDefinition fact_ent_flood => Scenario.AiSquadGroupDefinitions[38];
        public IAiActorDefinition factory1_enemies => Scenario.AiSquadGroupDefinitions[39];
        public IAiActorDefinition factory1_flood => Scenario.AiSquadGroupDefinitions[40];
        public IAiActorDefinition factory1_sentinels => Scenario.AiSquadGroupDefinitions[41];
        public IAiActorDefinition gorge_enemies => Scenario.AiSquadGroupDefinitions[42];
        public IAiActorDefinition gorge_flood => Scenario.AiSquadGroupDefinitions[43];
        public IAiActorDefinition gorge_sentinels => Scenario.AiSquadGroupDefinitions[44];
        public IAiActorDefinition factory2_enemies => Scenario.AiSquadGroupDefinitions[45];
        public IAiActorDefinition factory2_flood => Scenario.AiSquadGroupDefinitions[46];
        public IAiActorDefinition factory2_sentinels => Scenario.AiSquadGroupDefinitions[47];
        public IAiActorDefinition e20_cov => Scenario.AiSquadGroupDefinitions[48];
        public IAiActorDefinition e20_fld => Scenario.AiSquadGroupDefinitions[49];
        public IAiActorDefinition e20_fld_combats0 => Scenario.AiSquadGroupDefinitions[50];
        public IAiActorDefinition e21_cov => Scenario.AiSquadGroupDefinitions[51];
        public IAiActorDefinition e21_cov_inf0 => Scenario.AiSquadGroupDefinitions[52];
        public IAiActorDefinition e21_fld => Scenario.AiSquadGroupDefinitions[53];
        public IAiActorDefinition e21_fld_inf0 => Scenario.AiSquadGroupDefinitions[54];
        public IAiActorDefinition e21_fld_inf1 => Scenario.AiSquadGroupDefinitions[55];
        public IAiActorDefinition e22_cov => Scenario.AiSquadGroupDefinitions[56];
        public IAiActorDefinition e22_cov_inf1 => Scenario.AiSquadGroupDefinitions[57];
        public IAiActorDefinition e22_fld => Scenario.AiSquadGroupDefinitions[58];
        public IAiActorDefinition e22_fld_inf0 => Scenario.AiSquadGroupDefinitions[59];
        public IAiActorDefinition e23_cov => Scenario.AiSquadGroupDefinitions[60];
        public IAiActorDefinition e23_fld => Scenario.AiSquadGroupDefinitions[61];
        public IAiActorDefinition e23_fld_inf0 => Scenario.AiSquadGroupDefinitions[62];
        public IAiActorDefinition e24_cov => Scenario.AiSquadGroupDefinitions[63];
        public IAiActorDefinition e24_fld => Scenario.AiSquadGroupDefinitions[64];
        public IAiActorDefinition e24_fld_inf1 => Scenario.AiSquadGroupDefinitions[65];
        public IAiActorDefinition e25_cov => Scenario.AiSquadGroupDefinitions[66];
        public IAiActorDefinition e25_fld => Scenario.AiSquadGroupDefinitions[67];
        public IAiActorDefinition e25_fld_inf0 => Scenario.AiSquadGroupDefinitions[68];
        public IAiActorDefinition e25_fld_inf1 => Scenario.AiSquadGroupDefinitions[69];
        public IAiActorDefinition ext_b_enforcers => Scenario.AiSquadGroupDefinitions[70];
        public IAiActorDefinition ext_b_flood => Scenario.AiSquadGroupDefinitions[71];
        public IAiActorDefinition ext_b_flood_a => Scenario.AiSquadGroupDefinitions[72];
        public IAiActorDefinition ext_b_flood_b => Scenario.AiSquadGroupDefinitions[73];
        public IAiActorDefinition ext_b_flood_c => Scenario.AiSquadGroupDefinitions[74];
        public IAiActorDefinition ext_b_flood_d => Scenario.AiSquadGroupDefinitions[75];
        public IAiActorDefinition ext_b_sentinels => Scenario.AiSquadGroupDefinitions[76];
        public IAiActorDefinition ext_b_sentinels_a => Scenario.AiSquadGroupDefinitions[77];
        public IAiActorDefinition ext_b_sentinels_b => Scenario.AiSquadGroupDefinitions[78];
        public IAiActorDefinition ext_b_sentinels_c => Scenario.AiSquadGroupDefinitions[79];
        public IAiActorDefinition ext_b_sentinels_d => Scenario.AiSquadGroupDefinitions[80];
        public IAiOrders cov_follow_cov_def => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders cov_follow_veh_int => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders cov_follow_ext_a_dam => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders cov_follow_ext_a => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders cov_follow_ext_a_fact_ent => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders cov_follow_factory1 => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders cov_follow_gorge => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders cov_follow_factory2 => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders cov_follow_ext_b_fact => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders cov_follow_ext_b => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders cov_follow_ext_b_bk => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders cov_follow_key_ent => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders ________________________ => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders cov_drive_cov_def => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders cov_drive_veh_int_a => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders cov_drive_veh_int_b => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders cov_drive_veh_int_c => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders cov_drive_veh_int_d => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders cov_drive_veh_int_e => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders cov_drive_ext_a_dam_a => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders cov_drive_ext_a_dam_b => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders cov_drive_ext_a_a => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders cov_drive_ext_a_b => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders cov_drive_ext_a_c => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders cov_drive_ext_a_d => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders cov_drive_ext_a_e => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders cov_drive_ext_a_f => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders cov_drive_fact_ent => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders cov_drive_ext_b_a => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders cov_drive_ext_b_b => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders cov_drive_ext_b_c => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders cov_drive_ext_b_d => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders cov_ext_b_exit => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders Orders_174 => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders Orders_160 => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders ________________________1 => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders qz_cov_def_enf_a => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders qz_cov_def_enf_b => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders qz_cov_def_sen => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders qz_cov_def_spec_ops1 => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders qz_cov_def_vehicles => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders qz_cov_def_enf_all => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders veh_int_elim_lt => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders veh_int_elim_rt => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders veh_int_enf_a1 => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders veh_int_enf_b1 => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders veh_int_enf_c => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders veh_int_scorpion1 => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders veh_int_ => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders veh_int_sen_ini => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders veh_int_flood_b1 => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders veh_int_cov => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders qz_ext_a_exit_enf => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders qz_ext_a_dam_flood_ini1 => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders qz_ext_a_dam_sen1 => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders qz_ext_a_dam_sen_low => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders qz_ext_a_dam_low => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders e20_cov_inf0_init => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders e20_cov_inf0_advance0 => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders e20_cov_inf0_advance1 => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders e20_cov_inf0_advance2 => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders e20_cov_inf0_advance3 => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders e20_fld_combats0_pursue => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders e20_fld_combats0_guard0 => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders e20_fld_combats0_guard1 => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders e20_fld_combats0_guard2 => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders e20_fld_combats0_guard3 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders e22_cov_inf0_init => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders e22_cov_inf0_guard0 => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders e22_cov_inf1_0_init => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders e22_cov_inf1_1_init => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders e22_cov_inf1_regroup => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders e22_fld_inf0_0_init => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders e22_fld_inf0_0_engage0 => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders e22_fld_inf0_1_init => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders e22_fld_inf0_1_engage0 => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders e22_fld_inf0_engage1 => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders e23_cov_inf0_init => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders e23_cov_inf0_engage => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders e23_fld_inf0_0_init => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders e23_fld_inf0_1_init => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders e23_fld_inf0_engage => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders e24_cov_inf0_init => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders e24_cov_inf0_engage => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders e24_fld_inf0_guard0 => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders e24_fld_inf0_guard1 => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders e24_fld_inf1_follow => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders e24_fld_inf2_follow => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders e24_fld_inf2_engage => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders e25_fld_inf0_2_engage => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders e25_fld_inf1_2_engage => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders e25_cov_inf0_init => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders factory_1_flood_initial => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders factory_1_flood_exit_fwd => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders factory_1_flood_exit_mid => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders factory_1_flood_exit_back => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders factory_1_flood_tubes_fwd => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders factory_1_sentinels_initial => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders factory_1_major_all => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders factory_1_sentinels_01 => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders factory_1_sentinels_02 => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders factory_1_sentinels_03 => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders factory_1_sentinels_end => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders test2 => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders qz_ext_a_dam_cov => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders qz_ext_a_dam_jugg => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders qz_ext_a_ghosts1 => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders qz_ext_a_jugg => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders qz_ext_a_wraith_ledge => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders qz_ext_a_spec_ops1 => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders qz_ext_a_wraith_bk => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders fact_ent_enf1 => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders fact_ent_sen1 => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders fact_ent_scorpion => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders fact_ent_flood_wraith_a1 => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders fact_ent_flood_wraith_b1 => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders gorge_jugg_a1 => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders gorge_jugg_b1 => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders gorge_jugg_b_all => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders gorge_enf1 => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders gorge_sen1 => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders gorge_flood_ini1 => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders gorge_flood_all => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders gorge_flood_bk1 => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders qz_ext_b_humans => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders qz_ext_b_scorpion => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders qz_ext_b_fact_wraith1 => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders qz_ext_b_fact_ghosts1 => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders qz_ext_b_fact_ghosts_spare1 => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders qz_ext_b_fact_flood1 => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders qz_ext_b_fact_jugg => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders qz_ext_b_fact_all => Scenario.AiOrderDefinitions[131].GameObject;
        public IAiOrders qz_ext_b_fat_exit => Scenario.AiOrderDefinitions[132].GameObject;
        public IAiOrders factory2_jugg1 => Scenario.AiOrderDefinitions[133].GameObject;
        public IAiOrders factory2_flood_ini1 => Scenario.AiOrderDefinitions[134].GameObject;
        public IAiOrders factory2_flood_bk1 => Scenario.AiOrderDefinitions[135].GameObject;
        public IAiOrders factory2_flood_mid1 => Scenario.AiOrderDefinitions[136].GameObject;
        public IAiOrders factory2_flood_tunner => Scenario.AiOrderDefinitions[137].GameObject;
        public IAiOrders factory2_sen_tunner => Scenario.AiOrderDefinitions[138].GameObject;
        public IAiOrders qz_ext_b_wraith_a1 => Scenario.AiOrderDefinitions[139].GameObject;
        public IAiOrders qz_ext_b_wraith_b1 => Scenario.AiOrderDefinitions[140].GameObject;
        public IAiOrders qz_ext_b_vehicles => Scenario.AiOrderDefinitions[141].GameObject;
        public IAiOrders qz_ext_b_ent_scorpion1 => Scenario.AiOrderDefinitions[142].GameObject;
        public IAiOrders qz_ext_b_ent_wraith => Scenario.AiOrderDefinitions[143].GameObject;
        public IAiOrders qz_ext_b_ent_turrets1 => Scenario.AiOrderDefinitions[144].GameObject;
        public IAiOrders qz_ext_b_ent_jugg_bk => Scenario.AiOrderDefinitions[145].GameObject;
        public IAiOrders qz_ext_b_ent_jugg => Scenario.AiOrderDefinitions[146].GameObject;
        public IAiOrders qz_ext_b_infantry => Scenario.AiOrderDefinitions[147].GameObject;
        public IAiOrders e21_cov_inf0_init => Scenario.AiOrderDefinitions[148].GameObject;
        public IAiOrders e21_cov_inf0_0_guard_left => Scenario.AiOrderDefinitions[149].GameObject;
        public IAiOrders e21_cov_inf0_0_guard_right => Scenario.AiOrderDefinitions[150].GameObject;
        public IAiOrders e21_cov_inf0_1_advance_left => Scenario.AiOrderDefinitions[151].GameObject;
        public IAiOrders e21_cov_inf0_1_advance_right => Scenario.AiOrderDefinitions[152].GameObject;
        public IAiOrders e21_fld_inf0_engage0 => Scenario.AiOrderDefinitions[153].GameObject;
        public IAiOrders e21_fld_inf0_engage1 => Scenario.AiOrderDefinitions[154].GameObject;
        public IAiOrders e21_fld_inf1_engage0 => Scenario.AiOrderDefinitions[155].GameObject;
        public IAiOrders e21_fld_inf1_engage1 => Scenario.AiOrderDefinitions[156].GameObject;
        public IAiOrders e21_fld_inf0_0_init => Scenario.AiOrderDefinitions[157].GameObject;
        public IAiOrders key_ride_tartarus_init => Scenario.AiOrderDefinitions[158].GameObject;
        public IAiOrders qz_ext_a_enf_a1 => Scenario.AiOrderDefinitions[159].GameObject;
        public IAiOrders qz_ext_a_flood_wraith_fr1 => Scenario.AiOrderDefinitions[160].GameObject;
        public IAiOrders qz_ext_a_flood_mid => Scenario.AiOrderDefinitions[161].GameObject;
        public IAiOrders qz_cov_def_mid => Scenario.AiOrderDefinitions[162].GameObject;
        public IAiOrders veh_int_flood_follow => Scenario.AiOrderDefinitions[163].GameObject;
        public IAiOrders veh_int_wraith1 => Scenario.AiOrderDefinitions[164].GameObject;
        public IAiOrders qz_ext_a_flood_c1 => Scenario.AiOrderDefinitions[165].GameObject;
        public IAiOrders qz_ext_a_enf_bk1 => Scenario.AiOrderDefinitions[166].GameObject;
        public IAiOrders qz_ext_a_flood_d1 => Scenario.AiOrderDefinitions[167].GameObject;
        public IAiOrders ext_a_sen_elim_bk1 => Scenario.AiOrderDefinitions[168].GameObject;
        public IAiOrders qz_ext_a_flood_c21 => Scenario.AiOrderDefinitions[169].GameObject;
        public IAiOrders qz_ext_b_ent_enf1 => Scenario.AiOrderDefinitions[170].GameObject;
        public IAiOrders qz_ext_b_ghost_bk => Scenario.AiOrderDefinitions[171].GameObject;
        public IAiOrders qz_ext_b_enf_a1 => Scenario.AiOrderDefinitions[172].GameObject;
        public IAiOrders qz_ext_b_enf_b1 => Scenario.AiOrderDefinitions[173].GameObject;
        public IAiOrders qz_ext_b_flood_follow => Scenario.AiOrderDefinitions[174].GameObject;
        public IAiOrders ext_b_exit_flood_follow => Scenario.AiOrderDefinitions[175].GameObject;
        public ILocationFlag bsp_2_3_bsp3_offset => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag anchor_flag_x06 => Scenario.LocationFlagDefinitions[1].GameObject;
        public ILocationFlag anchor_flag_x07 => Scenario.LocationFlagDefinitions[2].GameObject;
        public ILocationFlag anchor_flag_intro => Scenario.LocationFlagDefinitions[3].GameObject;
        public ILocationFlag vehicle_int_a => Scenario.LocationFlagDefinitions[4].GameObject;
        public ILocationFlag vehicle_int_b => Scenario.LocationFlagDefinitions[5].GameObject;
        public ILocationFlag qz_ext_a_a => Scenario.LocationFlagDefinitions[6].GameObject;
        public ILocationFlag qz_ext_a_b => Scenario.LocationFlagDefinitions[7].GameObject;
        public ILocationFlag factory_ent_a => Scenario.LocationFlagDefinitions[8].GameObject;
        public ILocationFlag factory_ent_b => Scenario.LocationFlagDefinitions[9].GameObject;
        public ILocationFlag factory1_a => Scenario.LocationFlagDefinitions[10].GameObject;
        public ILocationFlag factory1_b => Scenario.LocationFlagDefinitions[11].GameObject;
        public ILocationFlag gorge_a => Scenario.LocationFlagDefinitions[12].GameObject;
        public ILocationFlag gorge_b => Scenario.LocationFlagDefinitions[13].GameObject;
        public ILocationFlag factory2_a => Scenario.LocationFlagDefinitions[14].GameObject;
        public ILocationFlag factory2_b => Scenario.LocationFlagDefinitions[15].GameObject;
        public ILocationFlag qz_ext_b_a => Scenario.LocationFlagDefinitions[16].GameObject;
        public ILocationFlag qz_ext_b_b => Scenario.LocationFlagDefinitions[17].GameObject;
        public ILocationFlag key_ride_a => Scenario.LocationFlagDefinitions[18].GameObject;
        public ILocationFlag key_ride_b => Scenario.LocationFlagDefinitions[19].GameObject;
        public ILocationFlag library_a => Scenario.LocationFlagDefinitions[20].GameObject;
        public ILocationFlag library_b => Scenario.LocationFlagDefinitions[21].GameObject;
        public ILocationFlag anchor_flag_intra2 => Scenario.LocationFlagDefinitions[22].GameObject;
        public ILocationFlag key_ent0 => Scenario.LocationFlagDefinitions[23].GameObject;
        public ILocationFlag key_ent1 => Scenario.LocationFlagDefinitions[24].GameObject;
        public ILocationFlag e20_test => Scenario.LocationFlagDefinitions[25].GameObject;
        public ILocationFlag e21_test => Scenario.LocationFlagDefinitions[26].GameObject;
        public ILocationFlag e23_test => Scenario.LocationFlagDefinitions[27].GameObject;
        public ILocationFlag bsp_3_2_bsp2_offset => Scenario.LocationFlagDefinitions[28].GameObject;
        public ILocationFlag anchor_flag_intra1 => Scenario.LocationFlagDefinitions[29].GameObject;
        public ILocationFlag e26_fld_infs0_0 => Scenario.LocationFlagDefinitions[30].GameObject;
        public ILocationFlag e26_fld_infs0_1 => Scenario.LocationFlagDefinitions[31].GameObject;
        public ILocationFlag e26_fld_infs0_2 => Scenario.LocationFlagDefinitions[32].GameObject;
        public ILocationFlag e26_fld_infs0_3 => Scenario.LocationFlagDefinitions[33].GameObject;
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[34].GameObject;
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[35].GameObject;
        public ILocationFlag bsp_0_1_garage => Scenario.LocationFlagDefinitions[36].GameObject;
        public ILocationFlag player0_end => Scenario.LocationFlagDefinitions[37].GameObject;
        public ILocationFlag player1_end => Scenario.LocationFlagDefinitions[38].GameObject;
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_2 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title_3 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ICinematicTitle title_4 => Scenario.CinematicTitleDefinitions[3].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume bsp_1_0 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_1_2 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume bsp_2_1 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume bsp_2_3_bsp3 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume tv_vehicle_int => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume tv_qz_ext_a => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume tv_factory => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume vol_factory_1_enter => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume vol_factory_1_mid_01 => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume vol_factory_1_mid_02 => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume vol_factory_1_mid_03 => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume vol_factory_1_exit => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_qz_ext_b => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume tv_key_ride => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_x07 => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_ext_a_f => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_key_ride_cinematic => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_e20_begin => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume tv_e20_player_advance0 => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume tv_e20_player_advance1 => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume tv_e20_player_advance2 => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume tv_e20_fld_combats1_begin => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume tv_e20_player_cowering => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_e20_dock_entrance => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_e20_fld_combats0_wave1_begin => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume tv_e26_main_begin => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_mission_end0 => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_mission_end1 => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume qz_ext_a_dam_b => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume tv_veh_int_a => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume tv_veh_int_b => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_veh_int_c => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_veh_int_d => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume tv_ext_a_c => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume tv_ext_a_d => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_ext_a_e => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_gorge_mid => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_gorge => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_factory2_enter => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_factory2_mid => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_gorge_bk_cave => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume tv_ext_b_gate => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_ext_b_back => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume tv_ext_b_exit => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_ext_b_mid => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_ext_b_exit_door => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_key_near_lower_spawner => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume tv_key_upper_left_side => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume tv_key_upper_right_side => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume kill => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume kill1 => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume kill2 => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume kill3 => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume kill4 => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume kill5 => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume kill6 => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume kill7 => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume kill8 => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume kill9 => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume kill10 => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume kill_key => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume tv_dam_door_a => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume tv_dam_door_b => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume tv_qz_ext_a_ghost_drop => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume tv_bsp_swap_bullshit => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume tv_ext_a_a => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume tv_ext_a_b => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume tv_ext_a_dam_a => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume cr_constructor => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume tv_music_06b_07 => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume tv_fact_ent_follow => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume tv_ext_a_ghosts_off => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume tv_factory2_bk => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume kill11 => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume tv_ext_b_fact_mid => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume tv_ext_b_exit_tube_a => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume tv_ext_b_exit_tube_b => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume tv_ext_a_fact_ent => Scenario.TriggerVolumes[78].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile player_starting_profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IDeviceGroup rob => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup pis01 => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup rob03 => Scenario.DeviceGroupDefinitions[2].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            johnson_rifle = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            key_intra2_01 = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            key_intra2_02 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            e21_ice4 = new ScenarioEntity<IBloc>(3, scenarioTag.WellKnownItems[3]);
            e21_ice0 = new ScenarioEntity<IBloc>(4, scenarioTag.WellKnownItems[4]);
            e21_ice1 = new ScenarioEntity<IBloc>(5, scenarioTag.WellKnownItems[5]);
            e21_ice2 = new ScenarioEntity<IBloc>(6, scenarioTag.WellKnownItems[6]);
            e21_ice3 = new ScenarioEntity<IBloc>(7, scenarioTag.WellKnownItems[7]);
            e21_ice5 = new ScenarioEntity<IBloc>(8, scenarioTag.WellKnownItems[8]);
            e21_ice6 = new ScenarioEntity<IBloc>(9, scenarioTag.WellKnownItems[9]);
            e21_ice7 = new ScenarioEntity<IBloc>(10, scenarioTag.WellKnownItems[10]);
            hammer = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            anchor_intra2 = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            anchor_intra1 = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            anchor_x07 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            x07_tentacle = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            brute_shot_01 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            brute_shot_02 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            brute_rifle_01 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            brute_rifle_02 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            index_container = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            energy_blade = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            iac = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            miranda_smg_01 = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            miranda_smg_02 = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            miranda = new ScenarioEntity<IUnit>(25, scenarioTag.WellKnownItems[25]);
            johnson = new ScenarioEntity<IUnit>(26, scenarioTag.WellKnownItems[26]);
            dervish = new ScenarioEntity<IUnit>(27, scenarioTag.WellKnownItems[27]);
            tartarus = new ScenarioEntity<IUnit>(28, scenarioTag.WellKnownItems[28]);
            brute_01 = new ScenarioEntity<IUnit>(29, scenarioTag.WellKnownItems[29]);
            brute_02 = new ScenarioEntity<IUnit>(30, scenarioTag.WellKnownItems[30]);
            brute_03 = new ScenarioEntity<IUnit>(31, scenarioTag.WellKnownItems[31]);
            brute_04 = new ScenarioEntity<IUnit>(32, scenarioTag.WellKnownItems[32]);
            commander = new ScenarioEntity<IUnit>(33, scenarioTag.WellKnownItems[33]);
            dervish_intra1 = new ScenarioEntity<IUnit>(34, scenarioTag.WellKnownItems[34]);
            commander_intra1 = new ScenarioEntity<IUnit>(35, scenarioTag.WellKnownItems[35]);
            elite_04 = new ScenarioEntity<IUnit>(36, scenarioTag.WellKnownItems[36]);
            elite_03 = new ScenarioEntity<IUnit>(37, scenarioTag.WellKnownItems[37]);
            elite_02 = new ScenarioEntity<IUnit>(38, scenarioTag.WellKnownItems[38]);
            elite_01 = new ScenarioEntity<IUnit>(39, scenarioTag.WellKnownItems[39]);
            throne_truth = new ScenarioEntity<IVehicle>(40, scenarioTag.WellKnownItems[40]);
            throne_mercy = new ScenarioEntity<IVehicle>(41, scenarioTag.WellKnownItems[41]);
            phantom_01 = new ScenarioEntity<IVehicle>(42, scenarioTag.WellKnownItems[42]);
            qz_ext_a_ghost = new ScenarioEntity<IVehicle>(43, scenarioTag.WellKnownItems[43]);
            phantom_intra1 = new ScenarioEntity<IVehicle>(44, scenarioTag.WellKnownItems[44]);
            spectre_intra1 = new ScenarioEntity<IVehicle>(45, scenarioTag.WellKnownItems[45]);
            e26_smg01 = new ScenarioEntity<IWeapon>(46, scenarioTag.WellKnownItems[46]);
            e26_smg11 = new ScenarioEntity<IWeapon>(47, scenarioTag.WellKnownItems[47]);
            ice_cream_head = new ScenarioEntity<IWeapon>(48, scenarioTag.WellKnownItems[48]);
            smg_real_01 = new ScenarioEntity<IWeapon>(49, scenarioTag.WellKnownItems[49]);
            smg_real_02 = new ScenarioEntity<IWeapon>(50, scenarioTag.WellKnownItems[50]);
            key = new ScenarioEntity<IDevice>(51, scenarioTag.WellKnownItems[51]);
            key_ride_door0 = new ScenarioEntity<IDevice>(52, scenarioTag.WellKnownItems[52]);
            key_ride_door1 = new ScenarioEntity<IDevice>(53, scenarioTag.WellKnownItems[53]);
            key_ride_door3 = new ScenarioEntity<IDevice>(54, scenarioTag.WellKnownItems[54]);
            key_ride_door2 = new ScenarioEntity<IDevice>(55, scenarioTag.WellKnownItems[55]);
            key_human = new ScenarioEntity<IDevice>(56, scenarioTag.WellKnownItems[56]);
            human_key_door0 = new ScenarioEntity<IDevice>(57, scenarioTag.WellKnownItems[57]);
            human_key_door1 = new ScenarioEntity<IDevice>(58, scenarioTag.WellKnownItems[58]);
            human_key_door2 = new ScenarioEntity<IDevice>(59, scenarioTag.WellKnownItems[59]);
            qz_door_a = new ScenarioEntity<IDevice>(60, scenarioTag.WellKnownItems[60]);
            qz_dam_door_a = new ScenarioEntity<IDevice>(61, scenarioTag.WellKnownItems[61]);
            qz_dam_door_b = new ScenarioEntity<IDevice>(62, scenarioTag.WellKnownItems[62]);
            qz_dam_door_c = new ScenarioEntity<IDevice>(63, scenarioTag.WellKnownItems[63]);
            qz_dam_door_d = new ScenarioEntity<IDevice>(64, scenarioTag.WellKnownItems[64]);
            qz_dam_door_e = new ScenarioEntity<IDevice>(65, scenarioTag.WellKnownItems[65]);
            qz_watch_base = new ScenarioEntity<IDevice>(66, scenarioTag.WellKnownItems[66]);
            veh_int_door_b = new ScenarioEntity<IDevice>(67, scenarioTag.WellKnownItems[67]);
            veh_int_door_a = new ScenarioEntity<IDevice>(68, scenarioTag.WellKnownItems[68]);
            key_docked = new ScenarioEntity<IDevice>(69, scenarioTag.WellKnownItems[69]);
            dam_door_a1 = new ScenarioEntity<IDevice>(70, scenarioTag.WellKnownItems[70]);
            dam_door_b1 = new ScenarioEntity<IDevice>(71, scenarioTag.WellKnownItems[71]);
            key_switch = new ScenarioEntity<IDevice>(72, scenarioTag.WellKnownItems[72]);
            qz_cov_def_tower_pod_a = new ScenarioEntity<IDevice>(73, scenarioTag.WellKnownItems[73]);
            qz_cov_def_tower_pod_b = new ScenarioEntity<IDevice>(74, scenarioTag.WellKnownItems[74]);
            empty = new Squad_empty(scenarioTag);
            qz_cov_def_spectre = new Squad_qz_cov_def_spectre(scenarioTag);
            qz_cov_def_ghosts = new Squad_qz_cov_def_ghosts(scenarioTag);
            veh_int_hog_ab = new Squad_veh_int_hog_ab(scenarioTag);
            veh_int_ghost_ab = new Squad_veh_int_ghost_ab(scenarioTag);
            ______COVENANT_DEFENSE_____ = new Squad_______COVENANT_DEFENSE_____(scenarioTag);
            qz_cov_def_phantom = new Squad_qz_cov_def_phantom(scenarioTag);
            qz_cov_def_spec_ops = new Squad_qz_cov_def_spec_ops(scenarioTag);
            qz_cov_def_enforcer_a = new Squad_qz_cov_def_enforcer_a(scenarioTag);
            qz_cov_def_enforcer_b = new Squad_qz_cov_def_enforcer_b(scenarioTag);
            qz_cov_def_sen_elim = new Squad_qz_cov_def_sen_elim(scenarioTag);
            ______VEHICLE_INTERIOR______ = new Squad_______VEHICLE_INTERIOR______(scenarioTag);
            veh_int_enf_a = new Squad_veh_int_enf_a(scenarioTag);
            veh_int_enf_b = new Squad_veh_int_enf_b(scenarioTag);
            veh_int_enf_d = new Squad_veh_int_enf_d(scenarioTag);
            veh_int_sen_elim_ini = new Squad_veh_int_sen_elim_ini(scenarioTag);
            veh_int_sen_elim_lt = new Squad_veh_int_sen_elim_lt(scenarioTag);
            veh_int_sen_elim_rt = new Squad_veh_int_sen_elim_rt(scenarioTag);
            veh_int_scorpion = new Squad_veh_int_scorpion(scenarioTag);
            veh_int_flood_ghosts_ini = new Squad_veh_int_flood_ghosts_ini(scenarioTag);
            veh_int_flood_hog_bk = new Squad_veh_int_flood_hog_bk(scenarioTag);
            veh_int_flood_ghosts_bk = new Squad_veh_int_flood_ghosts_bk(scenarioTag);
            veh_int_flood_bk = new Squad_veh_int_flood_bk(scenarioTag);
            veh_int_wraith = new Squad_veh_int_wraith(scenarioTag);
            veh_int_turrets = new Squad_veh_int_turrets(scenarioTag);
            ________EXTERIOR_A________ = new Squad_________EXTERIOR_A________(scenarioTag);
            qz_ext_a_phantom = new Squad_qz_ext_a_phantom(scenarioTag);
            qz_ext_a_spec_ops = new Squad_qz_ext_a_spec_ops(scenarioTag);
            qz_ext_a_ghosts = new Squad_qz_ext_a_ghosts(scenarioTag);
            qz_ext_a_dam_human = new Squad_qz_ext_a_dam_human(scenarioTag);
            qz_ext_a_dam_enf = new Squad_qz_ext_a_dam_enf(scenarioTag);
            qz_ext_a_dam_enf_door = new Squad_qz_ext_a_dam_enf_door(scenarioTag);
            qz_ext_a_dam_sen = new Squad_qz_ext_a_dam_sen(scenarioTag);
            qz_ext_a_dam_sen_elim = new Squad_qz_ext_a_dam_sen_elim(scenarioTag);
            qz_ext_a_dam_flood_ini = new Squad_qz_ext_a_dam_flood_ini(scenarioTag);
            qz_ext_a_dam_flood_cliff_a = new Squad_qz_ext_a_dam_flood_cliff_a(scenarioTag);
            qz_ext_a_dam_flood_cliff_b = new Squad_qz_ext_a_dam_flood_cliff_b(scenarioTag);
            qz_ext_a_flood_wraith_fr = new Squad_qz_ext_a_flood_wraith_fr(scenarioTag);
            qz_ext_a_flood_wraith_bk = new Squad_qz_ext_a_flood_wraith_bk(scenarioTag);
            qz_ext_a_flood_wraith_ledge = new Squad_qz_ext_a_flood_wraith_ledge(scenarioTag);
            qz_ext_a_flood_rocket = new Squad_qz_ext_a_flood_rocket(scenarioTag);
            qz_ext_a_flood_c = new Squad_qz_ext_a_flood_c(scenarioTag);
            qz_ext_a_flood_c2 = new Squad_qz_ext_a_flood_c2(scenarioTag);
            qz_ext_a_flood_d = new Squad_qz_ext_a_flood_d(scenarioTag);
            qz_ext_a_flood_ghosts = new Squad_qz_ext_a_flood_ghosts(scenarioTag);
            qz_ext_a_enf_a = new Squad_qz_ext_a_enf_a(scenarioTag);
            qz_ext_a_enf_b = new Squad_qz_ext_a_enf_b(scenarioTag);
            qz_ext_a_enf_bk = new Squad_qz_ext_a_enf_bk(scenarioTag);
            ext_a_sen_elim_bk = new Squad_ext_a_sen_elim_bk(scenarioTag);
            ext_a_flood_ghost_fr = new Squad_ext_a_flood_ghost_fr(scenarioTag);
            squads_160 = new Squad_squads_160(scenarioTag);
            squads_161 = new Squad_squads_161(scenarioTag);
            squads_162 = new Squad_squads_162(scenarioTag);
            squads_163 = new Squad_squads_163(scenarioTag);
            squads_164 = new Squad_squads_164(scenarioTag);
            ______CRASHED_FACTORY______ = new Squad_______CRASHED_FACTORY______(scenarioTag);
            fact_ent_enf = new Squad_fact_ent_enf(scenarioTag);
            fact_ent_sen = new Squad_fact_ent_sen(scenarioTag);
            fact_ent_flood_turrets = new Squad_fact_ent_flood_turrets(scenarioTag);
            fact_ent_flood_scorpion = new Squad_fact_ent_flood_scorpion(scenarioTag);
            fact_ent_flood_wraith_a = new Squad_fact_ent_flood_wraith_a(scenarioTag);
            fact_ent_flood_wraith_b = new Squad_fact_ent_flood_wraith_b(scenarioTag);
            ______FACTORY______ = new Squad_______FACTORY______(scenarioTag);
            factory_1_flood_intro = new Squad_factory_1_flood_intro(scenarioTag);
            factory_1_flood_initial_mid = new Squad_factory_1_flood_initial_mid(scenarioTag);
            factory_1_flood_initial_end = new Squad_factory_1_flood_initial_end(scenarioTag);
            factory_1_sentinels_intro = new Squad_factory_1_sentinels_intro(scenarioTag);
            factory_1_sentinels_initial_mid = new Squad_factory_1_sentinels_initial_mid(scenarioTag);
            factory_1_sentinels_initial_end = new Squad_factory_1_sentinels_initial_end(scenarioTag);
            factory_1_major = new Squad_factory_1_major(scenarioTag);
            factory_1_sentinels_01_low = new Squad_factory_1_sentinels_01_low(scenarioTag);
            factory_1_sentinels_01_high = new Squad_factory_1_sentinels_01_high(scenarioTag);
            factory_1_sentinels_02_low = new Squad_factory_1_sentinels_02_low(scenarioTag);
            factory_1_sentinels_02_high = new Squad_factory_1_sentinels_02_high(scenarioTag);
            factory_1_sentinels_03_low = new Squad_factory_1_sentinels_03_low(scenarioTag);
            factory_1_sentinels_03_high = new Squad_factory_1_sentinels_03_high(scenarioTag);
            factory_1_flood_end = new Squad_factory_1_flood_end(scenarioTag);
            factory_1_flood_tubes_far = new Squad_factory_1_flood_tubes_far(scenarioTag);
            factory_1_flood_tubes_near = new Squad_factory_1_flood_tubes_near(scenarioTag);
            factory_1_flood_alcove = new Squad_factory_1_flood_alcove(scenarioTag);
            gorge_jugg_a = new Squad_gorge_jugg_a(scenarioTag);
            gorge_jugg_b = new Squad_gorge_jugg_b(scenarioTag);
            gorge_enf = new Squad_gorge_enf(scenarioTag);
            gorge_sen = new Squad_gorge_sen(scenarioTag);
            gorge_flood_bk = new Squad_gorge_flood_bk(scenarioTag);
            gorge_flood_ini = new Squad_gorge_flood_ini(scenarioTag);
            gorge_flood_bk_cave = new Squad_gorge_flood_bk_cave(scenarioTag);
            factory2_sen_dead = new Squad_factory2_sen_dead(scenarioTag);
            factory2_flood_ini = new Squad_factory2_flood_ini(scenarioTag);
            factory2_flood_mid = new Squad_factory2_flood_mid(scenarioTag);
            factory2_flood_bk = new Squad_factory2_flood_bk(scenarioTag);
            factory2_jugg = new Squad_factory2_jugg(scenarioTag);
            factory2_flood_bk_tunnel = new Squad_factory2_flood_bk_tunnel(scenarioTag);
            factory2_sen_bk_tunnel = new Squad_factory2_sen_bk_tunnel(scenarioTag);
            ______EXT_B______ = new Squad_______EXT_B______(scenarioTag);
            qz_ext_b_fact_scorpion = new Squad_qz_ext_b_fact_scorpion(scenarioTag);
            qz_ext_b_fact_humans = new Squad_qz_ext_b_fact_humans(scenarioTag);
            qz_ext_b_fact_wraith = new Squad_qz_ext_b_fact_wraith(scenarioTag);
            qz_ext_b_fact_ghosts = new Squad_qz_ext_b_fact_ghosts(scenarioTag);
            qz_ext_b_fact_warthog = new Squad_qz_ext_b_fact_warthog(scenarioTag);
            qz_ext_b_fact_ghost_bk = new Squad_qz_ext_b_fact_ghost_bk(scenarioTag);
            qz_ext_b_fact_ghosts_spare = new Squad_qz_ext_b_fact_ghosts_spare(scenarioTag);
            qz_ext_b_fact_flood = new Squad_qz_ext_b_fact_flood(scenarioTag);
            qz_ext_b_cov_phantom = new Squad_qz_ext_b_cov_phantom(scenarioTag);
            qz_ext_b_cov_ghosts = new Squad_qz_ext_b_cov_ghosts(scenarioTag);
            qz_ext_b_cov_spectre = new Squad_qz_ext_b_cov_spectre(scenarioTag);
            qz_ext_b_cov_spec_ops = new Squad_qz_ext_b_cov_spec_ops(scenarioTag);
            qz_ext_b_wraith_a = new Squad_qz_ext_b_wraith_a(scenarioTag);
            qz_ext_b_wraith_b = new Squad_qz_ext_b_wraith_b(scenarioTag);
            qz_ext_b_ghosts_a = new Squad_qz_ext_b_ghosts_a(scenarioTag);
            qz_ext_b_ghosts_b = new Squad_qz_ext_b_ghosts_b(scenarioTag);
            qz_ext_b_warthog = new Squad_qz_ext_b_warthog(scenarioTag);
            qz_ext_b_warthog_gauss = new Squad_qz_ext_b_warthog_gauss(scenarioTag);
            qz_ext_b_enf_a = new Squad_qz_ext_b_enf_a(scenarioTag);
            qz_ext_b_enf_b = new Squad_qz_ext_b_enf_b(scenarioTag);
            qz_ext_b_ent_scorpion = new Squad_qz_ext_b_ent_scorpion(scenarioTag);
            qz_ext_b_ent_wraith_a = new Squad_qz_ext_b_ent_wraith_a(scenarioTag);
            qz_ext_b_ent_cov_phantom = new Squad_qz_ext_b_ent_cov_phantom(scenarioTag);
            qz_ext_b_ent_turrets = new Squad_qz_ext_b_ent_turrets(scenarioTag);
            qz_ext_b_ent_flood_bk = new Squad_qz_ext_b_ent_flood_bk(scenarioTag);
            qz_ext_b_ent_ghost_bk = new Squad_qz_ext_b_ent_ghost_bk(scenarioTag);
            qz_ext_b_ent_enf = new Squad_qz_ext_b_ent_enf(scenarioTag);
            qz_ext_b_ent_flood_tube_a = new Squad_qz_ext_b_ent_flood_tube_a(scenarioTag);
            qz_ext_b_ent_flood_tube_b = new Squad_qz_ext_b_ent_flood_tube_b(scenarioTag);
            squads_156 = new Squad_squads_156(scenarioTag);
            squads_157 = new Squad_squads_157(scenarioTag);
            ______KEY______ = new Squad_______KEY______(scenarioTag);
            e20_cov_inf0 = new Squad_e20_cov_inf0(scenarioTag);
            e20_fld_combats0_0 = new Squad_e20_fld_combats0_0(scenarioTag);
            e20_fld_combats0_1 = new Squad_e20_fld_combats0_1(scenarioTag);
            e20_fld_combats1 = new Squad_e20_fld_combats1(scenarioTag);
            e21_cov_inf0_0 = new Squad_e21_cov_inf0_0(scenarioTag);
            e21_cov_inf0_1 = new Squad_e21_cov_inf0_1(scenarioTag);
            e21_fld_inf0_0 = new Squad_e21_fld_inf0_0(scenarioTag);
            e21_fld_inf0_1 = new Squad_e21_fld_inf0_1(scenarioTag);
            e21_fld_inf0_2 = new Squad_e21_fld_inf0_2(scenarioTag);
            e21_fld_carriers0 = new Squad_e21_fld_carriers0(scenarioTag);
            e21_fld_inf1_0 = new Squad_e21_fld_inf1_0(scenarioTag);
            e21_fld_inf1_1 = new Squad_e21_fld_inf1_1(scenarioTag);
            e21_fld_inf1_2 = new Squad_e21_fld_inf1_2(scenarioTag);
            e21_fld_carriers1 = new Squad_e21_fld_carriers1(scenarioTag);
            e22_cov_inf0 = new Squad_e22_cov_inf0(scenarioTag);
            e22_cov_inf1_0 = new Squad_e22_cov_inf1_0(scenarioTag);
            e22_cov_inf1_1 = new Squad_e22_cov_inf1_1(scenarioTag);
            e22_fld_inf0_0 = new Squad_e22_fld_inf0_0(scenarioTag);
            e22_fld_inf0_1 = new Squad_e22_fld_inf0_1(scenarioTag);
            e22_fld_inf1 = new Squad_e22_fld_inf1(scenarioTag);
            e23_cov_inf0 = new Squad_e23_cov_inf0(scenarioTag);
            e23_fld_inf0_0 = new Squad_e23_fld_inf0_0(scenarioTag);
            e23_fld_inf0_1 = new Squad_e23_fld_inf0_1(scenarioTag);
            e24_cov_inf0 = new Squad_e24_cov_inf0(scenarioTag);
            e24_fld_inf0 = new Squad_e24_fld_inf0(scenarioTag);
            e24_fld_inf1_0 = new Squad_e24_fld_inf1_0(scenarioTag);
            e24_fld_inf1_1 = new Squad_e24_fld_inf1_1(scenarioTag);
            e24_fld_inf2 = new Squad_e24_fld_inf2(scenarioTag);
            e25_cov_inf0 = new Squad_e25_cov_inf0(scenarioTag);
            e25_fld_inf0_0 = new Squad_e25_fld_inf0_0(scenarioTag);
            e25_fld_inf0_1 = new Squad_e25_fld_inf0_1(scenarioTag);
            e25_fld_inf0_2 = new Squad_e25_fld_inf0_2(scenarioTag);
            e25_fld_inf1_0 = new Squad_e25_fld_inf1_0(scenarioTag);
            e25_fld_inf1_1 = new Squad_e25_fld_inf1_1(scenarioTag);
            e25_fld_inf1_2 = new Squad_e25_fld_inf1_2(scenarioTag);
            e26_fld_infection_forms0 = new Squad_e26_fld_infection_forms0(scenarioTag);
            key_ride_tartarus = new Squad_key_ride_tartarus(scenarioTag);
            silly = new Squad_silly(scenarioTag);
            key_cov_dump = new Squad_key_cov_dump(scenarioTag);
            squads_166 = new Squad_squads_166(scenarioTag);
            squads_167 = new Squad_squads_167(scenarioTag);
            squads_168 = new Squad_squads_168(scenarioTag);
            squads_169 = new Squad_squads_169(scenarioTag);
        }

        public class Squad_empty
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_empty(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_spectre
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition spectre => ScenarioTag.AiSquadDefinitions[1].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_qz_cov_def_spectre(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_ghosts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[2].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[2].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_qz_cov_def_ghosts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_hog_ab
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition hog => ScenarioTag.AiSquadDefinitions[3].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_veh_int_hog_ab(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_ghost_ab
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[4].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[4].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_veh_int_ghost_ab(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_______COVENANT_DEFENSE_____
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_______COVENANT_DEFENSE_____(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[6].StartingLocations[1];
            public IAiActorDefinition gun_a => ScenarioTag.AiSquadDefinitions[6].StartingLocations[2];
            public IAiActorDefinition gun_b => ScenarioTag.AiSquadDefinitions[6].StartingLocations[3];
            public IAiActorDefinition gun_c => ScenarioTag.AiSquadDefinitions[6].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_qz_cov_def_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_spec_ops
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[7].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[7].StartingLocations[2];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[7].StartingLocations[3];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[7].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_qz_cov_def_spec_ops(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_enforcer_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_qz_cov_def_enforcer_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_enforcer_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_qz_cov_def_enforcer_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_cov_def_sen_elim
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_qz_cov_def_sen_elim(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_______VEHICLE_INTERIOR______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_______VEHICLE_INTERIOR______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_enf_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_veh_int_enf_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_enf_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_veh_int_enf_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_enf_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_veh_int_enf_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_sen_elim_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_veh_int_sen_elim_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_sen_elim_lt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_veh_int_sen_elim_lt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_sen_elim_rt
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_veh_int_sen_elim_rt(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_scorpion
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition scorpion => ScenarioTag.AiSquadDefinitions[18].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad_veh_int_scorpion(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_flood_ghosts_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[19].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[19].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_veh_int_flood_ghosts_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_flood_hog_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition gunner => ScenarioTag.AiSquadDefinitions[20].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_veh_int_flood_hog_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_flood_ghosts_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[21].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[21].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_veh_int_flood_ghosts_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_flood_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[4];
            public IAiActorDefinition runner => ScenarioTag.AiSquadDefinitions[22].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_veh_int_flood_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_wraith
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith => ScenarioTag.AiSquadDefinitions[23].StartingLocations[1];
            public IAiActorDefinition driver => ScenarioTag.AiSquadDefinitions[23].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_veh_int_wraith(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_veh_int_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_veh_int_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_________EXTERIOR_A________
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_________EXTERIOR_A________(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom => ScenarioTag.AiSquadDefinitions[26].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_qz_ext_a_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_spec_ops
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_qz_ext_a_spec_ops(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_ghosts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[28].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[28].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_qz_ext_a_ghosts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_dam_human
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition pelican => ScenarioTag.AiSquadDefinitions[29].StartingLocations[1];
            public IAiActorDefinition scorpion => ScenarioTag.AiSquadDefinitions[29].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_qz_ext_a_dam_human(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_dam_enf
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_qz_ext_a_dam_enf(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_dam_enf_door
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition c => ScenarioTag.AiSquadDefinitions[31].StartingLocations[2];
            public IAiActorDefinition d => ScenarioTag.AiSquadDefinitions[31].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_qz_ext_a_dam_enf_door(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_dam_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_qz_ext_a_dam_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_dam_sen_elim
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_qz_ext_a_dam_sen_elim(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_dam_flood_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_qz_ext_a_dam_flood_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_dam_flood_cliff_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[2];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[3];
            public IAiActorDefinition starting_locations_12 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[4];
            public IAiActorDefinition starting_locations_13 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[5];
            public IAiActorDefinition starting_locations_14 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[6];
            public IAiActorDefinition starting_locations_15 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[7];
            public IAiActorDefinition starting_locations_16 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[8];
            public IAiActorDefinition starting_locations_17 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_qz_ext_a_dam_flood_cliff_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_dam_flood_cliff_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_qz_ext_a_dam_flood_cliff_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_flood_wraith_fr
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_qz_ext_a_flood_wraith_fr(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_flood_wraith_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_qz_ext_a_flood_wraith_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_flood_wraith_ledge
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_qz_ext_a_flood_wraith_ledge(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_flood_rocket
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_qz_ext_a_flood_rocket(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_flood_c
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_qz_ext_a_flood_c(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_flood_c2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_qz_ext_a_flood_c2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_flood_d
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_qz_ext_a_flood_d(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_flood_ghosts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_qz_ext_a_flood_ghosts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_enf_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[45].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_qz_ext_a_enf_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_enf_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_qz_ext_a_enf_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_a_enf_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_qz_ext_a_enf_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_sen_elim_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_ext_a_sen_elim_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_ext_a_flood_ghost_fr
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_ext_a_flood_ghost_fr(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_160
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_squads_160(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_161
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_squads_161(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_162
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_squads_162(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_163
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_squads_163(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_164
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad_squads_164(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_______CRASHED_FACTORY______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_______CRASHED_FACTORY______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_fact_ent_enf
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_fact_ent_enf(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_fact_ent_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_fact_ent_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_fact_ent_flood_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_fact_ent_flood_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_fact_ent_flood_scorpion
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_fact_ent_flood_scorpion(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_fact_ent_flood_wraith_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_fact_ent_flood_wraith_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_fact_ent_flood_wraith_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_fact_ent_flood_wraith_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_______FACTORY______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_______FACTORY______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_flood_intro
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_factory_1_flood_intro(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_flood_initial_mid
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_factory_1_flood_initial_mid(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_flood_initial_end
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_factory_1_flood_initial_end(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_intro
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_factory_1_sentinels_intro(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_initial_mid
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_factory_1_sentinels_initial_mid(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_initial_end
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_factory_1_sentinels_initial_end(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_major
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_factory_1_major(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_01_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_factory_1_sentinels_01_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_01_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_factory_1_sentinels_01_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_02_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_factory_1_sentinels_02_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_02_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_factory_1_sentinels_02_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_03_low
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_factory_1_sentinels_03_low(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_sentinels_03_high
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_factory_1_sentinels_03_high(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_flood_end
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad_factory_1_flood_end(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_flood_tubes_far
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_factory_1_flood_tubes_far(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_flood_tubes_near
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_factory_1_flood_tubes_near(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory_1_flood_alcove
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_factory_1_flood_alcove(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gorge_jugg_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_gorge_jugg_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gorge_jugg_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_gorge_jugg_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gorge_enf
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_gorge_enf(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gorge_sen
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[11];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[12];
            public IAiActorDefinition starting_locations_12 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[13];
            public IAiActorDefinition starting_locations_13 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[14];
            public IAiActorDefinition starting_locations_14 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[15];
            public IAiActorDefinition starting_locations_15 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[16];
            public IAiActorDefinition starting_locations_16 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[17];
            public IAiActorDefinition starting_locations_17 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[18];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_gorge_sen(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gorge_flood_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[11];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[12];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_gorge_flood_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gorge_flood_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[85].StartingLocations[11];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[85];
            public Squad_gorge_flood_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_gorge_flood_bk_cave
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[86].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[86];
            public Squad_gorge_flood_bk_cave(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory2_sen_dead
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[87].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[87];
            public Squad_factory2_sen_dead(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory2_flood_ini
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[11];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[88].StartingLocations[12];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[88];
            public Squad_factory2_flood_ini(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory2_flood_mid
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[89].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[89];
            public Squad_factory2_flood_mid(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory2_flood_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[3];
            public IAiActorDefinition starting_locations_31 => ScenarioTag.AiSquadDefinitions[90].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[90];
            public Squad_factory2_flood_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory2_jugg
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[91].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[91];
            public Squad_factory2_jugg(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory2_flood_bk_tunnel
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[92].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[92];
            public Squad_factory2_flood_bk_tunnel(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_factory2_sen_bk_tunnel
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[93].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[93];
            public Squad_factory2_sen_bk_tunnel(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_______EXT_B______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[94];
            public Squad_______EXT_B______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_fact_scorpion
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition scorpion => ScenarioTag.AiSquadDefinitions[95].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[95];
            public Squad_qz_ext_b_fact_scorpion(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_fact_humans
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[96].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[96];
            public Squad_qz_ext_b_fact_humans(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_fact_wraith
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[97].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[97];
            public Squad_qz_ext_b_fact_wraith(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_fact_ghosts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[98].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[98];
            public Squad_qz_ext_b_fact_ghosts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_fact_warthog
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog => ScenarioTag.AiSquadDefinitions[99].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[99].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[99];
            public Squad_qz_ext_b_fact_warthog(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_fact_ghost_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[100].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[100];
            public Squad_qz_ext_b_fact_ghost_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_fact_ghosts_spare
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[101].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[101].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[101];
            public Squad_qz_ext_b_fact_ghosts_spare(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_fact_flood
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[11];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[12];
            public IAiActorDefinition starting_locations_12 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[13];
            public IAiActorDefinition starting_locations_13 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[14];
            public IAiActorDefinition starting_locations_14 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[15];
            public IAiActorDefinition starting_locations_15 => ScenarioTag.AiSquadDefinitions[102].StartingLocations[16];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[102];
            public Squad_qz_ext_b_fact_flood(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_cov_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom => ScenarioTag.AiSquadDefinitions[103].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[103];
            public Squad_qz_ext_b_cov_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_cov_ghosts
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition a => ScenarioTag.AiSquadDefinitions[104].StartingLocations[1];
            public IAiActorDefinition b => ScenarioTag.AiSquadDefinitions[104].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[104];
            public Squad_qz_ext_b_cov_ghosts(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_cov_spectre
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition spectre => ScenarioTag.AiSquadDefinitions[105].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[105];
            public Squad_qz_ext_b_cov_spectre(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_cov_spec_ops
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition soc => ScenarioTag.AiSquadDefinitions[106].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[106].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[106];
            public Squad_qz_ext_b_cov_spec_ops(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_wraith_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[107].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[107];
            public Squad_qz_ext_b_wraith_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_wraith_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[108].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[108];
            public Squad_qz_ext_b_wraith_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ghosts_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[109].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[109];
            public Squad_qz_ext_b_ghosts_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ghosts_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[110].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[110];
            public Squad_qz_ext_b_ghosts_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_warthog
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog => ScenarioTag.AiSquadDefinitions[111].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[111].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[111];
            public Squad_qz_ext_b_warthog(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_warthog_gauss
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition warthog => ScenarioTag.AiSquadDefinitions[112].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[112].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[112];
            public Squad_qz_ext_b_warthog_gauss(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_enf_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[113].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[113];
            public Squad_qz_ext_b_enf_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_enf_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[114].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[114];
            public Squad_qz_ext_b_enf_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_scorpion
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[115].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[115];
            public Squad_qz_ext_b_ent_scorpion(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_wraith_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[116].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[116];
            public Squad_qz_ext_b_ent_wraith_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_cov_phantom
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[117].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[117];
            public Squad_qz_ext_b_ent_cov_phantom(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_turrets
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition mp_a => ScenarioTag.AiSquadDefinitions[118].StartingLocations[1];
            public IAiActorDefinition mp_b => ScenarioTag.AiSquadDefinitions[118].StartingLocations[2];
            public IAiActorDefinition mp_c => ScenarioTag.AiSquadDefinitions[118].StartingLocations[3];
            public IAiActorDefinition mp_d => ScenarioTag.AiSquadDefinitions[118].StartingLocations[4];
            public IAiActorDefinition ap_a => ScenarioTag.AiSquadDefinitions[118].StartingLocations[5];
            public IAiActorDefinition ap_b => ScenarioTag.AiSquadDefinitions[118].StartingLocations[6];
            public IAiActorDefinition ap_c => ScenarioTag.AiSquadDefinitions[118].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[118];
            public Squad_qz_ext_b_ent_turrets(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_flood_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[119].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[119];
            public Squad_qz_ext_b_ent_flood_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_ghost_bk
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[120].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[120];
            public Squad_qz_ext_b_ent_ghost_bk(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_enf
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[121].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[121].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[121];
            public Squad_qz_ext_b_ent_enf(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_flood_tube_a
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[4];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[122].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[122];
            public Squad_qz_ext_b_ent_flood_tube_a(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_qz_ext_b_ent_flood_tube_b
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[4];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[123].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[123];
            public Squad_qz_ext_b_ent_flood_tube_b(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_156
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[124];
            public Squad_squads_156(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_157
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[125];
            public Squad_squads_157(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_______KEY______
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[126];
            public Squad_______KEY______(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e20_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[127].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[127];
            public Squad_e20_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e20_fld_combats0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition infs0 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[128].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[128];
            public Squad_e20_fld_combats0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e20_fld_combats0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition _0 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[1];
            public IAiActorDefinition _1 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[2];
            public IAiActorDefinition _2 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[3];
            public IAiActorDefinition _3 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[4];
            public IAiActorDefinition _4 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[5];
            public IAiActorDefinition _5 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[6];
            public IAiActorDefinition _6 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[7];
            public IAiActorDefinition _7 => ScenarioTag.AiSquadDefinitions[129].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[129];
            public Squad_e20_fld_combats0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e20_fld_combats1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[130];
            public Squad_e20_fld_combats1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[131].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[131];
            public Squad_e21_cov_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_cov_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[132].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[132];
            public Squad_e21_cov_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_fld_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[133].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[133];
            public Squad_e21_fld_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_fld_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[134].StartingLocations[11];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[134];
            public Squad_e21_fld_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_fld_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[135].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[135];
            public Squad_e21_fld_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_fld_carriers0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[136].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[136];
            public Squad_e21_fld_carriers0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_fld_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[137];
            public Squad_e21_fld_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_fld_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[138].StartingLocations[10];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[138];
            public Squad_e21_fld_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_fld_inf1_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[139].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[139];
            public Squad_e21_fld_inf1_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e21_fld_carriers1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[140].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[140];
            public Squad_e21_fld_carriers1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[141].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[141];
            public Squad_e22_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_cov_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[142];
            public Squad_e22_cov_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_cov_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[143];
            public Squad_e22_cov_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_fld_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[144].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[144];
            public Squad_e22_fld_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_fld_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[145].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[145];
            public Squad_e22_fld_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e22_fld_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[146];
            public Squad_e22_fld_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[147];
            public Squad_e23_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_fld_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[148].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[148];
            public Squad_e23_fld_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e23_fld_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[149].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[149];
            public Squad_e23_fld_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e24_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[150];
            public Squad_e24_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e24_fld_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[151];
            public Squad_e24_fld_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e24_fld_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[152].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[152].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[152].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[152].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[152].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[152];
            public Squad_e24_fld_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e24_fld_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[153].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[153];
            public Squad_e24_fld_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e24_fld_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[154].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[154];
            public Squad_e24_fld_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e25_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[155];
            public Squad_e25_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e25_fld_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[156].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[156];
            public Squad_e25_fld_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e25_fld_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[157].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[157];
            public Squad_e25_fld_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e25_fld_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[158].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[158].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[158].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[158].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[158].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[158];
            public Squad_e25_fld_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e25_fld_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[159].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[159].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[159].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[159].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[159].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[159];
            public Squad_e25_fld_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e25_fld_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[160].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[160];
            public Squad_e25_fld_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e25_fld_inf1_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[161].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[161].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[161].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[161].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[161].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[161];
            public Squad_e25_fld_inf1_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e26_fld_infection_forms0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition swarm0 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[1];
            public IAiActorDefinition swarm1 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[2];
            public IAiActorDefinition swarm2 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[3];
            public IAiActorDefinition swarm3 => ScenarioTag.AiSquadDefinitions[162].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[162];
            public Squad_e26_fld_infection_forms0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_key_ride_tartarus
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition tartarus => ScenarioTag.AiSquadDefinitions[163].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[163];
            public Squad_key_ride_tartarus(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_silly
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[164].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[164];
            public Squad_silly(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_key_cov_dump
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[9];
            public IAiActorDefinition starting_locations_9 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[10];
            public IAiActorDefinition starting_locations_10 => ScenarioTag.AiSquadDefinitions[165].StartingLocations[11];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[165];
            public Squad_key_cov_dump(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_166
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[166];
            public Squad_squads_166(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_167
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[167];
            public Squad_squads_167(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_168
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[168];
            public Squad_squads_168(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_squads_169
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[169];
            public Squad_squads_169(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}