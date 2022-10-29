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
        public ICameraPathTarget test1 => Scenario.CameraPathTargets[0];
        public ICameraPathTarget insertion_temp => Scenario.CameraPathTargets[1];
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
        public IAiOrders qz_cov_def_spec_ops => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders qz_cov_def_vehicles => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders qz_cov_def_enf_all => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders veh_int_elim_lt => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders veh_int_elim_rt => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders veh_int_enf_a => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders veh_int_enf_b => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders veh_int_enf_c => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders veh_int_scorpion => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders veh_int_ => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders veh_int_sen_ini => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders veh_int_flood_b1 => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders veh_int_cov => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders qz_ext_a_exit_enf => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders qz_ext_a_dam_flood_ini => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders qz_ext_a_dam_sen => Scenario.AiOrderDefinitions[54].GameObject;
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
        public IAiOrders qz_ext_a_ghosts => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders qz_ext_a_jugg => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders qz_ext_a_wraith_ledge => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders qz_ext_a_spec_ops => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders qz_ext_a_wraith_bk => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders fact_ent_enf => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders fact_ent_sen => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders fact_ent_scorpion => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders fact_ent_flood_wraith_a => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders fact_ent_flood_wraith_b => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders gorge_jugg_a => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders gorge_jugg_b => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders gorge_jugg_b_all => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders gorge_enf => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders gorge_sen => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders gorge_flood_ini => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders gorge_flood_all => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders gorge_flood_bk => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders qz_ext_b_humans => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders qz_ext_b_scorpion => Scenario.AiOrderDefinitions[125].GameObject;
        public IAiOrders qz_ext_b_fact_wraith => Scenario.AiOrderDefinitions[126].GameObject;
        public IAiOrders qz_ext_b_fact_ghosts => Scenario.AiOrderDefinitions[127].GameObject;
        public IAiOrders qz_ext_b_fact_ghosts_spare => Scenario.AiOrderDefinitions[128].GameObject;
        public IAiOrders qz_ext_b_fact_flood => Scenario.AiOrderDefinitions[129].GameObject;
        public IAiOrders qz_ext_b_fact_jugg => Scenario.AiOrderDefinitions[130].GameObject;
        public IAiOrders qz_ext_b_fact_all => Scenario.AiOrderDefinitions[131].GameObject;
        public IAiOrders qz_ext_b_fat_exit => Scenario.AiOrderDefinitions[132].GameObject;
        public IAiOrders factory2_jugg => Scenario.AiOrderDefinitions[133].GameObject;
        public IAiOrders factory2_flood_ini => Scenario.AiOrderDefinitions[134].GameObject;
        public IAiOrders factory2_flood_bk => Scenario.AiOrderDefinitions[135].GameObject;
        public IAiOrders factory2_flood_mid => Scenario.AiOrderDefinitions[136].GameObject;
        public IAiOrders factory2_flood_tunner => Scenario.AiOrderDefinitions[137].GameObject;
        public IAiOrders factory2_sen_tunner => Scenario.AiOrderDefinitions[138].GameObject;
        public IAiOrders qz_ext_b_wraith_a => Scenario.AiOrderDefinitions[139].GameObject;
        public IAiOrders qz_ext_b_wraith_b => Scenario.AiOrderDefinitions[140].GameObject;
        public IAiOrders qz_ext_b_vehicles => Scenario.AiOrderDefinitions[141].GameObject;
        public IAiOrders qz_ext_b_ent_scorpion => Scenario.AiOrderDefinitions[142].GameObject;
        public IAiOrders qz_ext_b_ent_wraith => Scenario.AiOrderDefinitions[143].GameObject;
        public IAiOrders qz_ext_b_ent_turrets => Scenario.AiOrderDefinitions[144].GameObject;
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
        public IAiOrders qz_ext_a_enf_a => Scenario.AiOrderDefinitions[159].GameObject;
        public IAiOrders qz_ext_a_flood_wraith_fr => Scenario.AiOrderDefinitions[160].GameObject;
        public IAiOrders qz_ext_a_flood_mid => Scenario.AiOrderDefinitions[161].GameObject;
        public IAiOrders qz_cov_def_mid => Scenario.AiOrderDefinitions[162].GameObject;
        public IAiOrders veh_int_flood_follow => Scenario.AiOrderDefinitions[163].GameObject;
        public IAiOrders veh_int_wraith => Scenario.AiOrderDefinitions[164].GameObject;
        public IAiOrders qz_ext_a_flood_c => Scenario.AiOrderDefinitions[165].GameObject;
        public IAiOrders qz_ext_a_enf_bk => Scenario.AiOrderDefinitions[166].GameObject;
        public IAiOrders qz_ext_a_flood_d => Scenario.AiOrderDefinitions[167].GameObject;
        public IAiOrders ext_a_sen_elim_bk => Scenario.AiOrderDefinitions[168].GameObject;
        public IAiOrders qz_ext_a_flood_c2 => Scenario.AiOrderDefinitions[169].GameObject;
        public IAiOrders qz_ext_b_ent_enf => Scenario.AiOrderDefinitions[170].GameObject;
        public IAiOrders qz_ext_b_ghost_bk => Scenario.AiOrderDefinitions[171].GameObject;
        public IAiOrders qz_ext_b_enf_a => Scenario.AiOrderDefinitions[172].GameObject;
        public IAiOrders qz_ext_b_enf_b => Scenario.AiOrderDefinitions[173].GameObject;
        public IAiOrders qz_ext_b_flood_follow => Scenario.AiOrderDefinitions[174].GameObject;
        public IAiOrders ext_b_exit_flood_follow => Scenario.AiOrderDefinitions[175].GameObject;
        public ILocationFlag bsp_2_3_bsp3_offset => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag anchor_flag_x06 => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag anchor_flag_x07 => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag anchor_flag_intro => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag vehicle_int_a => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag vehicle_int_b => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag qz_ext_a_a => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag qz_ext_a_b => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag factory_ent_a => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag factory_ent_b => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag factory1_a => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag factory1_b => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag gorge_a => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag gorge_b => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag factory2_a => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag factory2_b => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag qz_ext_b_a => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag qz_ext_b_b => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag key_ride_a => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag key_ride_b => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag library_a => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag library_b => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag anchor_flag_intra2 => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag key_ent0 => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag key_ent1 => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag e20_test => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag e21_test => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag e23_test => Scenario.LocationFlagDefinitions[27];
        public ILocationFlag bsp_3_2_bsp2_offset => Scenario.LocationFlagDefinitions[28];
        public ILocationFlag anchor_flag_intra1 => Scenario.LocationFlagDefinitions[29];
        public ILocationFlag e26_fld_infs0_0 => Scenario.LocationFlagDefinitions[30];
        public ILocationFlag e26_fld_infs0_1 => Scenario.LocationFlagDefinitions[31];
        public ILocationFlag e26_fld_infs0_2 => Scenario.LocationFlagDefinitions[32];
        public ILocationFlag e26_fld_infs0_3 => Scenario.LocationFlagDefinitions[33];
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[34];
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[35];
        public ILocationFlag bsp_0_1_garage => Scenario.LocationFlagDefinitions[36];
        public ILocationFlag player0_end => Scenario.LocationFlagDefinitions[37];
        public ILocationFlag player1_end => Scenario.LocationFlagDefinitions[38];
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
            qz_cov_def_spec_ops1 = new Squad_qz_cov_def_spec_ops1(scenarioTag);
            qz_cov_def_enforcer_a = new Squad_qz_cov_def_enforcer_a(scenarioTag);
            qz_cov_def_enforcer_b = new Squad_qz_cov_def_enforcer_b(scenarioTag);
            qz_cov_def_sen_elim = new Squad_qz_cov_def_sen_elim(scenarioTag);
            ______VEHICLE_INTERIOR______ = new Squad_______VEHICLE_INTERIOR______(scenarioTag);
            veh_int_enf_a1 = new Squad_veh_int_enf_a1(scenarioTag);
            veh_int_enf_b1 = new Squad_veh_int_enf_b1(scenarioTag);
            veh_int_enf_d = new Squad_veh_int_enf_d(scenarioTag);
            veh_int_sen_elim_ini = new Squad_veh_int_sen_elim_ini(scenarioTag);
            veh_int_sen_elim_lt = new Squad_veh_int_sen_elim_lt(scenarioTag);
            veh_int_sen_elim_rt = new Squad_veh_int_sen_elim_rt(scenarioTag);
            veh_int_scorpion1 = new Squad_veh_int_scorpion1(scenarioTag);
            veh_int_flood_ghosts_ini = new Squad_veh_int_flood_ghosts_ini(scenarioTag);
            veh_int_flood_hog_bk = new Squad_veh_int_flood_hog_bk(scenarioTag);
            veh_int_flood_ghosts_bk = new Squad_veh_int_flood_ghosts_bk(scenarioTag);
            veh_int_flood_bk = new Squad_veh_int_flood_bk(scenarioTag);
            veh_int_wraith1 = new Squad_veh_int_wraith1(scenarioTag);
            veh_int_turrets = new Squad_veh_int_turrets(scenarioTag);
            ________EXTERIOR_A________ = new Squad_________EXTERIOR_A________(scenarioTag);
            qz_ext_a_phantom = new Squad_qz_ext_a_phantom(scenarioTag);
            qz_ext_a_spec_ops1 = new Squad_qz_ext_a_spec_ops1(scenarioTag);
            qz_ext_a_ghosts1 = new Squad_qz_ext_a_ghosts1(scenarioTag);
            qz_ext_a_dam_human = new Squad_qz_ext_a_dam_human(scenarioTag);
            qz_ext_a_dam_enf = new Squad_qz_ext_a_dam_enf(scenarioTag);
            qz_ext_a_dam_enf_door = new Squad_qz_ext_a_dam_enf_door(scenarioTag);
            qz_ext_a_dam_sen1 = new Squad_qz_ext_a_dam_sen1(scenarioTag);
            qz_ext_a_dam_sen_elim = new Squad_qz_ext_a_dam_sen_elim(scenarioTag);
            qz_ext_a_dam_flood_ini1 = new Squad_qz_ext_a_dam_flood_ini1(scenarioTag);
            qz_ext_a_dam_flood_cliff_a = new Squad_qz_ext_a_dam_flood_cliff_a(scenarioTag);
            qz_ext_a_dam_flood_cliff_b = new Squad_qz_ext_a_dam_flood_cliff_b(scenarioTag);
            qz_ext_a_flood_wraith_fr1 = new Squad_qz_ext_a_flood_wraith_fr1(scenarioTag);
            qz_ext_a_flood_wraith_bk = new Squad_qz_ext_a_flood_wraith_bk(scenarioTag);
            qz_ext_a_flood_wraith_ledge = new Squad_qz_ext_a_flood_wraith_ledge(scenarioTag);
            qz_ext_a_flood_rocket = new Squad_qz_ext_a_flood_rocket(scenarioTag);
            qz_ext_a_flood_c1 = new Squad_qz_ext_a_flood_c1(scenarioTag);
            qz_ext_a_flood_c21 = new Squad_qz_ext_a_flood_c21(scenarioTag);
            qz_ext_a_flood_d1 = new Squad_qz_ext_a_flood_d1(scenarioTag);
            qz_ext_a_flood_ghosts = new Squad_qz_ext_a_flood_ghosts(scenarioTag);
            qz_ext_a_enf_a1 = new Squad_qz_ext_a_enf_a1(scenarioTag);
            qz_ext_a_enf_b = new Squad_qz_ext_a_enf_b(scenarioTag);
            qz_ext_a_enf_bk1 = new Squad_qz_ext_a_enf_bk1(scenarioTag);
            ext_a_sen_elim_bk1 = new Squad_ext_a_sen_elim_bk1(scenarioTag);
            ext_a_flood_ghost_fr = new Squad_ext_a_flood_ghost_fr(scenarioTag);
            squads_160 = new Squad_squads_160(scenarioTag);
            squads_161 = new Squad_squads_161(scenarioTag);
            squads_162 = new Squad_squads_162(scenarioTag);
            squads_163 = new Squad_squads_163(scenarioTag);
            squads_164 = new Squad_squads_164(scenarioTag);
            ______CRASHED_FACTORY______ = new Squad_______CRASHED_FACTORY______(scenarioTag);
            fact_ent_enf1 = new Squad_fact_ent_enf1(scenarioTag);
            fact_ent_sen1 = new Squad_fact_ent_sen1(scenarioTag);
            fact_ent_flood_turrets = new Squad_fact_ent_flood_turrets(scenarioTag);
            fact_ent_flood_scorpion = new Squad_fact_ent_flood_scorpion(scenarioTag);
            fact_ent_flood_wraith_a1 = new Squad_fact_ent_flood_wraith_a1(scenarioTag);
            fact_ent_flood_wraith_b1 = new Squad_fact_ent_flood_wraith_b1(scenarioTag);
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
            gorge_jugg_a1 = new Squad_gorge_jugg_a1(scenarioTag);
            gorge_jugg_b1 = new Squad_gorge_jugg_b1(scenarioTag);
            gorge_enf1 = new Squad_gorge_enf1(scenarioTag);
            gorge_sen1 = new Squad_gorge_sen1(scenarioTag);
            gorge_flood_bk1 = new Squad_gorge_flood_bk1(scenarioTag);
            gorge_flood_ini1 = new Squad_gorge_flood_ini1(scenarioTag);
            gorge_flood_bk_cave = new Squad_gorge_flood_bk_cave(scenarioTag);
            factory2_sen_dead = new Squad_factory2_sen_dead(scenarioTag);
            factory2_flood_ini1 = new Squad_factory2_flood_ini1(scenarioTag);
            factory2_flood_mid1 = new Squad_factory2_flood_mid1(scenarioTag);
            factory2_flood_bk1 = new Squad_factory2_flood_bk1(scenarioTag);
            factory2_jugg1 = new Squad_factory2_jugg1(scenarioTag);
            factory2_flood_bk_tunnel = new Squad_factory2_flood_bk_tunnel(scenarioTag);
            factory2_sen_bk_tunnel = new Squad_factory2_sen_bk_tunnel(scenarioTag);
            ______EXT_B______ = new Squad_______EXT_B______(scenarioTag);
            qz_ext_b_fact_scorpion = new Squad_qz_ext_b_fact_scorpion(scenarioTag);
            qz_ext_b_fact_humans = new Squad_qz_ext_b_fact_humans(scenarioTag);
            qz_ext_b_fact_wraith1 = new Squad_qz_ext_b_fact_wraith1(scenarioTag);
            qz_ext_b_fact_ghosts1 = new Squad_qz_ext_b_fact_ghosts1(scenarioTag);
            qz_ext_b_fact_warthog = new Squad_qz_ext_b_fact_warthog(scenarioTag);
            qz_ext_b_fact_ghost_bk = new Squad_qz_ext_b_fact_ghost_bk(scenarioTag);
            qz_ext_b_fact_ghosts_spare1 = new Squad_qz_ext_b_fact_ghosts_spare1(scenarioTag);
            qz_ext_b_fact_flood1 = new Squad_qz_ext_b_fact_flood1(scenarioTag);
            qz_ext_b_cov_phantom = new Squad_qz_ext_b_cov_phantom(scenarioTag);
            qz_ext_b_cov_ghosts = new Squad_qz_ext_b_cov_ghosts(scenarioTag);
            qz_ext_b_cov_spectre = new Squad_qz_ext_b_cov_spectre(scenarioTag);
            qz_ext_b_cov_spec_ops = new Squad_qz_ext_b_cov_spec_ops(scenarioTag);
            qz_ext_b_wraith_a1 = new Squad_qz_ext_b_wraith_a1(scenarioTag);
            qz_ext_b_wraith_b1 = new Squad_qz_ext_b_wraith_b1(scenarioTag);
            qz_ext_b_ghosts_a = new Squad_qz_ext_b_ghosts_a(scenarioTag);
            qz_ext_b_ghosts_b = new Squad_qz_ext_b_ghosts_b(scenarioTag);
            qz_ext_b_warthog = new Squad_qz_ext_b_warthog(scenarioTag);
            qz_ext_b_warthog_gauss = new Squad_qz_ext_b_warthog_gauss(scenarioTag);
            qz_ext_b_enf_a1 = new Squad_qz_ext_b_enf_a1(scenarioTag);
            qz_ext_b_enf_b1 = new Squad_qz_ext_b_enf_b1(scenarioTag);
            qz_ext_b_ent_scorpion1 = new Squad_qz_ext_b_ent_scorpion1(scenarioTag);
            qz_ext_b_ent_wraith_a = new Squad_qz_ext_b_ent_wraith_a(scenarioTag);
            qz_ext_b_ent_cov_phantom = new Squad_qz_ext_b_ent_cov_phantom(scenarioTag);
            qz_ext_b_ent_turrets1 = new Squad_qz_ext_b_ent_turrets1(scenarioTag);
            qz_ext_b_ent_flood_bk = new Squad_qz_ext_b_ent_flood_bk(scenarioTag);
            qz_ext_b_ent_ghost_bk = new Squad_qz_ext_b_ent_ghost_bk(scenarioTag);
            qz_ext_b_ent_enf1 = new Squad_qz_ext_b_ent_enf1(scenarioTag);
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
    }
}