namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_08a_deltacliffs : ScenarioScriptBase
    {
        public ScenarioEntity<IBloc> e8_barricade0 { get; set; }
        public ScenarioEntity<IBloc> e2_antennae { get; set; }
        public ScenarioEntity<IBloc> e9_trap_target0 { get; set; }
        public ScenarioEntity<IBloc> e9_trap_target1 { get; set; }
        public ScenarioEntity<IScenery> anchor_intro { get; set; }
        public ScenarioEntity<IScenery> scarab_01 { get; set; }
        public ScenarioEntity<IScenery> anchor_intra1 { get; set; }
        public ScenarioEntity<IScenery> teleport { get; set; }
        public ScenarioEntity<IUnit> e1_elite0 { get; set; }
        public ScenarioEntity<IUnit> e1_elite1 { get; set; }
        public ScenarioEntity<IUnit> e1_elite2 { get; set; }
        public ScenarioEntity<IUnit> e1_elite3 { get; set; }
        public ScenarioEntity<IUnit> e1_elite4 { get; set; }
        public ScenarioEntity<IUnit> e1_elite5 { get; set; }
        public ScenarioEntity<IUnit> dervish { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> monitor { get; set; }
        public ScenarioEntity<IUnit> commander { get; set; }
        public ScenarioEntity<IUnit> dervish_01 { get; set; }
        public ScenarioEntity<IUnit> brute_01 { get; set; }
        public ScenarioEntity<IUnit> brute_02 { get; set; }
        public ScenarioEntity<IUnit> brute_03 { get; set; }
        public ScenarioEntity<IUnit> brute_04 { get; set; }
        public ScenarioEntity<IUnit> test { get; set; }
        public ScenarioEntity<IUnit> bruty { get; set; }
        public ScenarioEntity<IVehicle> phantom_01 { get; set; }
        public ScenarioEntity<IVehicle> phantom_02 { get; set; }
        public ScenarioEntity<IVehicle> wraith_01 { get; set; }
        public ScenarioEntity<IWeapon> e1_gun0 { get; set; }
        public ScenarioEntity<IWeapon> e1_gun1 { get; set; }
        public ScenarioEntity<IWeapon> e1_gun2 { get; set; }
        public ScenarioEntity<IWeapon> e1_gun3 { get; set; }
        public ScenarioEntity<IWeapon> e1_gun4 { get; set; }
        public ScenarioEntity<IWeapon> intro_plasma_rifle { get; set; }
        public ScenarioEntity<IWeapon> key { get; set; }
        public ScenarioEntity<IDevice> e1_pod0_inserter { get; set; }
        public ScenarioEntity<IDevice> e1_pod1_inserter { get; set; }
        public ScenarioEntity<IDevice> e1_pod2_inserter { get; set; }
        public ScenarioEntity<IDevice> e10_pod0_inserter { get; set; }
        public ScenarioEntity<IDevice> e10_pod1_inserter { get; set; }
        public ScenarioEntity<IDevice> e10_pod2_inserter { get; set; }
        public ScenarioEntity<IDevice> e10_pod3_inserter { get; set; }
        public ScenarioEntity<IDevice> e6_ghost_ledge_door { get; set; }
        public ScenarioEntity<IDevice> e4_door0 { get; set; }
        public ScenarioEntity<IDevice> e3_exit_door { get; set; }
        public ScenarioEntity<IDevice> e10_exit_door { get; set; }
        public ScenarioEntity<IDevice> intra1_door { get; set; }
        public Squad_e1_cov_inf0 e1_cov_inf0 { get; set; }
        public Squad_e1_cov_inf1 e1_cov_inf1 { get; set; }
        public Squad_e1_cov_inf2 e1_cov_inf2 { get; set; }
        public Squad_e1_cov_phantom0 e1_cov_phantom0 { get; set; }
        public Squad_e1_pro_inf0_0 e1_pro_inf0_0 { get; set; }
        public Squad_e1_pro_inf0_1 e1_pro_inf0_1 { get; set; }
        public Squad_e1_pro_inf0_1_1 e1_pro_inf0_1_1 { get; set; }
        public Squad_e1_pro_inf0_2 e1_pro_inf0_2 { get; set; }
        public Squad_e1_pro_inf0_3 e1_pro_inf0_3 { get; set; }
        public Squad_e1_pro_inf1 e1_pro_inf1 { get; set; }
        public Squad_e2_cov_inf0 e2_cov_inf0 { get; set; }
        public Squad_e2_cov_inf1 e2_cov_inf1 { get; set; }
        public Squad_e2_cov_gold_elite e2_cov_gold_elite { get; set; }
        public Squad_e2_cov_grunts0 e2_cov_grunts0 { get; set; }
        public Squad_e2_pro_inf0 e2_pro_inf0 { get; set; }
        public Squad_e2_pro_inf1 e2_pro_inf1 { get; set; }
        public Squad_e2_pro_inf2 e2_pro_inf2 { get; set; }
        public Squad_e2_pro_inf3 e2_pro_inf3 { get; set; }
        public Squad_e3_cov_inf0 e3_cov_inf0 { get; set; }
        public Squad_e3_cov_gold_elite e3_cov_gold_elite { get; set; }
        public Squad_e3_cov_grunts0 e3_cov_grunts0 { get; set; }
        public Squad_e3_pro_inf0_0 e3_pro_inf0_0 { get; set; }
        public Squad_e3_pro_inf0_1 e3_pro_inf0_1 { get; set; }
        public Squad_e3_pro_inf1 e3_pro_inf1 { get; set; }
        public Squad_e4_cov_inf0 e4_cov_inf0 { get; set; }
        public Squad_e4_cov_gold_elite e4_cov_gold_elite { get; set; }
        public Squad_e4_pro_inf0_0 e4_pro_inf0_0 { get; set; }
        public Squad_e4_pro_inf0_1 e4_pro_inf0_1 { get; set; }
        public Squad_e4_pro_inf1 e4_pro_inf1 { get; set; }
        public Squad_e4_pro_inf2_0 e4_pro_inf2_0 { get; set; }
        public Squad_e4_pro_inf2_1 e4_pro_inf2_1 { get; set; }
        public Squad_e5_cov_inf0 e5_cov_inf0 { get; set; }
        public Squad_e5_cov_gold_elite e5_cov_gold_elite { get; set; }
        public Squad_e5_cov_grunts0 e5_cov_grunts0 { get; set; }
        public Squad_e5_pro_inf0 e5_pro_inf0 { get; set; }
        public Squad_e5_pro_inf1 e5_pro_inf1 { get; set; }
        public Squad_e6_cov_inf0 e6_cov_inf0 { get; set; }
        public Squad_e6_cov_inf1 e6_cov_inf1 { get; set; }
        public Squad_e6_cov_gold_elite e6_cov_gold_elite { get; set; }
        public Squad_e6_cov_ghosts0 e6_cov_ghosts0 { get; set; }
        public Squad_e6_cov_grunts0 e6_cov_grunts0 { get; set; }
        public Squad_e6_pro_inf0_0 e6_pro_inf0_0 { get; set; }
        public Squad_e6_pro_inf0_1 e6_pro_inf0_1 { get; set; }
        public Squad_e6_pro_inf1 e6_pro_inf1 { get; set; }
        public Squad_e6_pro_phantom0 e6_pro_phantom0 { get; set; }
        public Squad_____GHOST_SECTION____ ____GHOST_SECTION____ { get; set; }
        public Squad_e7_cov_inf0 e7_cov_inf0 { get; set; }
        public Squad_e7_cov_ghosts0 e7_cov_ghosts0 { get; set; }
        public Squad_e7_cov_ghosts1 e7_cov_ghosts1 { get; set; }
        public Squad_e7_pro_inf0_0 e7_pro_inf0_0 { get; set; }
        public Squad_e7_pro_inf0_1 e7_pro_inf0_1 { get; set; }
        public Squad_e7_pro_inf1_0 e7_pro_inf1_0 { get; set; }
        public Squad_e7_pro_inf1_1 e7_pro_inf1_1 { get; set; }
        public Squad_e7_pro_inf1_2 e7_pro_inf1_2 { get; set; }
        public Squad_e7_pro_inf2 e7_pro_inf2 { get; set; }
        public Squad_e8_cov_inf0 e8_cov_inf0 { get; set; }
        public Squad_e8_cov_ghosts0 e8_cov_ghosts0 { get; set; }
        public Squad_e8_pro_inf0 e8_pro_inf0 { get; set; }
        public Squad_e8_pro_inf1_0 e8_pro_inf1_0 { get; set; }
        public Squad_e8_pro_inf1_1 e8_pro_inf1_1 { get; set; }
        public Squad_e8_pro_inf2 e8_pro_inf2 { get; set; }
        public Squad_e8_pro_spectre0 e8_pro_spectre0 { get; set; }
        public Squad_e9_cov_ghosts0 e9_cov_ghosts0 { get; set; }
        public Squad_e9_pro_inf0_0 e9_pro_inf0_0 { get; set; }
        public Squad_e9_pro_inf0_1 e9_pro_inf0_1 { get; set; }
        public Squad_e9_pro_inf0_2 e9_pro_inf0_2 { get; set; }
        public Squad_e9_pro_inf1 e9_pro_inf1 { get; set; }
        public Squad_e9_pro_inf2 e9_pro_inf2 { get; set; }
        public Squad_e9_pro_inf3 e9_pro_inf3 { get; set; }
        public Squad_e9_pro_phantom0 e9_pro_phantom0 { get; set; }
        public Squad_e10_cov_inf0 e10_cov_inf0 { get; set; }
        public Squad_e10_cov_ghosts0 e10_cov_ghosts0 { get; set; }
        public Squad_e10_pro_inf0_0 e10_pro_inf0_0 { get; set; }
        public Squad_e10_pro_inf0_1 e10_pro_inf0_1 { get; set; }
        public Squad_e10_pro_inf1_0 e10_pro_inf1_0 { get; set; }
        public Squad_e10_pro_inf1_1 e10_pro_inf1_1 { get; set; }
        public Squad_e10_pro_inf1_2 e10_pro_inf1_2 { get; set; }
        public Squad_e10_pro_inf2_0 e10_pro_inf2_0 { get; set; }
        public Squad_e10_pro_inf2_1 e10_pro_inf2_1 { get; set; }
        public Squad_e10_pro_inf3 e10_pro_inf3 { get; set; }
        public Squad_e10_pro_wraith0_0 e10_pro_wraith0_0 { get; set; }
        public Squad_e10_pro_wraith0_1 e10_pro_wraith0_1 { get; set; }
        public Squad_e10_pro_phantom0 e10_pro_phantom0 { get; set; }
        public Squad_e10_pro_ghosts0_0 e10_pro_ghosts0_0 { get; set; }
        public Squad_e10_pro_ghosts0_1 e10_pro_ghosts0_1 { get; set; }
        public IAiActorDefinition covenant1 => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition prophets => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition e1_cov => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition e1_pro => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition e1_pro_inf0 => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition e2_cov => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition e2_pro => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition e3_cov => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition e3_pro => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition e3_pro_inf0 => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition e4_cov => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition e4_pro => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition e4_pro_inf0 => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition e4_pro_inf2 => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition e5_cov => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition e5_pro => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition e6_cov => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition e6_pro => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition e6_pro_inf0 => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition ____GHOST_SECTION____1 => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition e7_cov => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition e7_pro => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition e7_pro_inf => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition e7_pro_inf0 => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition e7_pro_inf1 => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition e8_cov => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition e8_pro => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition e8_pro_inf1 => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition e9_cov => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition e9_pro => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition e9_pro_inf0 => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition e10_cov => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition e10_pro => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition e10_pro_inf0 => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition e10_pro_inf1 => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition e10_pro_ghosts0 => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition e10_pro_inf2 => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition e10_pro_wraith0 => Scenario.AiSquadGroupDefinitions[37];
        public IAiOrders e1_cov_inf1_init => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders e1_cov_inf1_engage0 => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders e1_cov_inf1_wait0 => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders e1_cov_inf2_init => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders e1_cov_inf_continue => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders e1_pro_inf0_init => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders e1_pro_inf0_alert => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders e1_pro_inf0_search => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders e1_pro_inf0_regroup => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders e1_pro_inf0_3_init => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders e1_pro_inf1_init => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders e2_cov_inf0_init => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders e2_cov_inf0_advance0 => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders e2_cov_inf0_advance1 => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders e2_cov_inf0_advance2 => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders e2_cov_inf0_continue => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders e2_cov_grunts0_init => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders e2_pro_inf0_init => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders e2_pro_inf1_init => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders e2_pro_inf2_init => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders e2_pro_inf3_init => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders e3_cov_inf0_init => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders e3_cov_inf0_advance0 => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders e3_cov_inf0_advance1 => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders e3_cov_gold_elite_murder => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders e3_cov_gold_elite_continue => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders e3_pro_inf0_0_init => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders e3_pro_inf0_1_init => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders e3_pro_inf0_1_retreat => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders e3_pro_inf1_init => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders e4_cov_inf0_init => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders e4_cov_inf0_advance0 => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders e4_cov_inf0_advance1 => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders e4_cov_inf0_advance2 => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders e4_cov_inf0_follow => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders e4_cov_gold_elite_init => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders e4_cov_gold_elite_advance0 => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders e4_cov_gold_elite_advance1 => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders e4_cov_gold_elite_advance2 => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders e4_cov_gold_elite_continue => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders e4_pro_inf0_0_init => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders e4_pro_inf0_1_init => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders e4_pro_inf1_init => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders e4_pro_inf2_0_init => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders e4_pro_inf2_0_follow => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders e4_pro_inf2_1_init => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders e5_cov_inf0_init => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders e5_cov_inf0_advance0 => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders e5_cov_inf0_advance1 => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders e5_cov_gold_elite_init => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders e5_cov_gold_elite_killomatic => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders e5_cov_gold_elite_advance0 => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders e5_cov_grunts0_init => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders e5_cov_grunts0_flee => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders e5_cov_grunts0_advance => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders e5_pro_inf0_init => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders e5_pro_inf1_init => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders e6_cov_inf0_init => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders e6_cov_inf0_advance0 => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders e6_cov_inf0_advance1 => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders e6_cov_inf0_continue => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders e6_cov_gold_elite_chopchop => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders e6_cov_ghosts0_continue => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders e6_cov_grunts0_init => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders e6_cov_grunts0_advance0 => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders e6_pro_inf0_0_init => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders e6_pro_inf0_1_init => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders e6_pro_inf1_init => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders e6_pro_phantom0_init => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders e6_pro_phantom0_follow0 => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders e6_pro_phantom0_follow1 => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders ____GHOST_SECTION____2 => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders e7_cov_inf0_init => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders e7_cov_inf0_advance0 => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders e7_cov_inf0_advance1 => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders e7_cov_inf0_continue => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders e7_cov_ghosts0_init => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders e7_cov_ghosts0_wait0 => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders e7_pro_inf0_0_init => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders e7_pro_inf0_1_init => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders e7_pro_inf0_retreat => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders e7_pro_inf1_engage0 => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders e7_pro_inf1_engage1 => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders e7_pro_inf2_init => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders e7_pro_creep0_init => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders e8_cov_inf0_init => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders e8_cov_ghosts0_init => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders e8_cov_ghosts0_continue => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders e8_pro_inf0_init => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders e8_pro_inf1_init => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders e8_pro_inf2_init => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders e8_pro_shadow0_init => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders e8_pro_shadow0_engage => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders e8_pro_shadow0_follow => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders e9_cov_ghosts0_init => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders e9_pro_inf0_init => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders e9_pro_inf0_1_init => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders e9_pro_inf0_1_retreat => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders e9_pro_inf0_2_init => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders e9_pro_inf1_init => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders e9_pro_inf2_init => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders e10_cov_inf0_init => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders e10_cov_inf0_advance0 => Scenario.AiOrderDefinitions[102].GameObject;
        public IAiOrders e10_cov_ghosts0_init => Scenario.AiOrderDefinitions[103].GameObject;
        public IAiOrders e10_cov_ghosts0_follow0 => Scenario.AiOrderDefinitions[104].GameObject;
        public IAiOrders e10_cov_ghosts0_cower0 => Scenario.AiOrderDefinitions[105].GameObject;
        public IAiOrders e10_cov_ghosts0_follow1 => Scenario.AiOrderDefinitions[106].GameObject;
        public IAiOrders e10_pro_inf0_0_init => Scenario.AiOrderDefinitions[107].GameObject;
        public IAiOrders e10_pro_inf0_1_init => Scenario.AiOrderDefinitions[108].GameObject;
        public IAiOrders e10_pro_inf1_defend0 => Scenario.AiOrderDefinitions[109].GameObject;
        public IAiOrders e10_pro_inf1_1_init => Scenario.AiOrderDefinitions[110].GameObject;
        public IAiOrders e10_pro_inf2_init => Scenario.AiOrderDefinitions[111].GameObject;
        public IAiOrders e10_pro_inf2_retreat0 => Scenario.AiOrderDefinitions[112].GameObject;
        public IAiOrders e10_pro_inf2_retreat1 => Scenario.AiOrderDefinitions[113].GameObject;
        public IAiOrders e10_pro_wraith0_0_init => Scenario.AiOrderDefinitions[114].GameObject;
        public IAiOrders e10_pro_wraith0_0_engage0 => Scenario.AiOrderDefinitions[115].GameObject;
        public IAiOrders e10_pro_wraith0_0_engage1 => Scenario.AiOrderDefinitions[116].GameObject;
        public IAiOrders e10_pro_wraith0_1_init => Scenario.AiOrderDefinitions[117].GameObject;
        public IAiOrders e10_pro_phantom0_init => Scenario.AiOrderDefinitions[118].GameObject;
        public IAiOrders e10_pro_ghosts0_init => Scenario.AiOrderDefinitions[119].GameObject;
        public IAiOrders e7_cov_ghosts0_continue => Scenario.AiOrderDefinitions[120].GameObject;
        public IAiOrders e10_pro_inf3_init => Scenario.AiOrderDefinitions[121].GameObject;
        public IAiOrders e10_pro_inf3_retreat0 => Scenario.AiOrderDefinitions[122].GameObject;
        public IAiOrders e9_pro_inf3_init => Scenario.AiOrderDefinitions[123].GameObject;
        public IAiOrders e10_pro_inf1_0_init => Scenario.AiOrderDefinitions[124].GameObject;
        public IAiOrders e10_cov_inf0_follow => Scenario.AiOrderDefinitions[125].GameObject;
        public ILocationFlag e2_test => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag e3_test => Scenario.LocationFlagDefinitions[1].GameObject;
        public ILocationFlag e5_test => Scenario.LocationFlagDefinitions[2].GameObject;
        public ILocationFlag e6_test => Scenario.LocationFlagDefinitions[3].GameObject;
        public ILocationFlag e7_test => Scenario.LocationFlagDefinitions[4].GameObject;
        public ILocationFlag e10_test => Scenario.LocationFlagDefinitions[5].GameObject;
        public ILocationFlag e9_test => Scenario.LocationFlagDefinitions[6].GameObject;
        public ILocationFlag anchor_flag_intro => Scenario.LocationFlagDefinitions[7].GameObject;
        public ILocationFlag anchor_flag_intra1 => Scenario.LocationFlagDefinitions[8].GameObject;
        public ILocationFlag player0_start => Scenario.LocationFlagDefinitions[9].GameObject;
        public ILocationFlag player1_start => Scenario.LocationFlagDefinitions[10].GameObject;
        public ILocationFlag player0_end => Scenario.LocationFlagDefinitions[11].GameObject;
        public ILocationFlag player1_end => Scenario.LocationFlagDefinitions[12].GameObject;
        public ICinematicTitle title0 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title1 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title2 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ITriggerVolume bsp_0_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume bsp_1_0 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_1_01 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume bsp_0_11 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume tv_e1_ledge => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume tv_e1_second_wall => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume tv_e1_third_wall => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume tv_e1_exit => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume tv_e2_main_begin => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume tv_e2_rock_ramp => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume tv_e2_upper_ramp => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume tv_e2_pro_inf3_begin => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume tv_e2_main_end => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_e3_main_begin => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume tv_e3_lower_level => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_e3_exit => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_e4_main_begin => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_e4_second_step => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_e4_first_step => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume tv_e4_ground_floor => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume tv_e5_main_begin => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume tv_e5_lower_level => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume tv_e6_main_begin => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume tv_e6_near_ghosts => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_e6_on_ledge0 => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_e7_main_begin0 => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume tv_e8_main_begin => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_e9_main_begin => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_e8_area => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume tv_e4_ground_floor_exit => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume tv_e10_inf1_1_init => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume tv_e10_inf1_2_init => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_e10_near_exit => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_e10_main_begin => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume tv_e10_armory_entrance => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume tv_mission_end => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_e7_near_fighting => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_e7_exit => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_e10_other_side => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_e5_exit => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_e2_cov_inf1_unsafe => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_e9_first_drop => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume tv_e9_trap_trigger0 => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_e9_trap_trigger1 => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume tv_e10_bridge => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_e10_pro_inf2_retreat0 => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_e10_pro_inf2_retreat2 => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_e10_pro_inf2_retreat3 => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume tv_e10_second_half => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume tv_e10_armory_exit => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume tv_e7_main_begin1 => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume tv_e2_pro_inf1_begin => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume tv_e10_armory => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume tv_e1_main_area => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume tv_e1_pro_inf0_begin => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume tv_e10_entrance => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume tv_e7_middle_section => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume tv_e7_end_section => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume tv_e7_first_section => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume tv_e7_pro_inf1_0_unsafe => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume tv_e7_pro_inf1_2_unsafe => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume tv_e7_grunts_unsafe => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume tv_e8_spectre_begin => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume tv_e3_near_exit => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume tv_e9_pro_inf3_begin => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume tv_e10_first_half_floor => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume tv_e4_pre_main => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume tv_e1_area_entrance => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume tv_e10_exit_door => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume tv_e10_pro_inf1_do_or_die => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume kill_e2_0 => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume tv_e6_ledge0 => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume tv_e6_ledge1 => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume tv_e6_pro_inf1_begin => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume tv_e8_exit => Scenario.TriggerVolumes[74].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile player_starting_profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IDeviceGroup foo => Scenario.DeviceGroupDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            e8_barricade0 = new ScenarioEntity<IBloc>(0, scenarioTag.WellKnownItems[0]);
            e2_antennae = new ScenarioEntity<IBloc>(1, scenarioTag.WellKnownItems[1]);
            e9_trap_target0 = new ScenarioEntity<IBloc>(2, scenarioTag.WellKnownItems[2]);
            e9_trap_target1 = new ScenarioEntity<IBloc>(3, scenarioTag.WellKnownItems[3]);
            anchor_intro = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            scarab_01 = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            anchor_intra1 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            teleport = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            e1_elite0 = new ScenarioEntity<IUnit>(8, scenarioTag.WellKnownItems[8]);
            e1_elite1 = new ScenarioEntity<IUnit>(9, scenarioTag.WellKnownItems[9]);
            e1_elite2 = new ScenarioEntity<IUnit>(10, scenarioTag.WellKnownItems[10]);
            e1_elite3 = new ScenarioEntity<IUnit>(11, scenarioTag.WellKnownItems[11]);
            e1_elite4 = new ScenarioEntity<IUnit>(12, scenarioTag.WellKnownItems[12]);
            e1_elite5 = new ScenarioEntity<IUnit>(13, scenarioTag.WellKnownItems[13]);
            dervish = new ScenarioEntity<IUnit>(14, scenarioTag.WellKnownItems[14]);
            tartarus = new ScenarioEntity<IUnit>(15, scenarioTag.WellKnownItems[15]);
            miranda = new ScenarioEntity<IUnit>(16, scenarioTag.WellKnownItems[16]);
            monitor = new ScenarioEntity<IUnit>(17, scenarioTag.WellKnownItems[17]);
            commander = new ScenarioEntity<IUnit>(18, scenarioTag.WellKnownItems[18]);
            dervish_01 = new ScenarioEntity<IUnit>(19, scenarioTag.WellKnownItems[19]);
            brute_01 = new ScenarioEntity<IUnit>(20, scenarioTag.WellKnownItems[20]);
            brute_02 = new ScenarioEntity<IUnit>(21, scenarioTag.WellKnownItems[21]);
            brute_03 = new ScenarioEntity<IUnit>(22, scenarioTag.WellKnownItems[22]);
            brute_04 = new ScenarioEntity<IUnit>(23, scenarioTag.WellKnownItems[23]);
            test = new ScenarioEntity<IUnit>(24, scenarioTag.WellKnownItems[24]);
            bruty = new ScenarioEntity<IUnit>(25, scenarioTag.WellKnownItems[25]);
            phantom_01 = new ScenarioEntity<IVehicle>(26, scenarioTag.WellKnownItems[26]);
            phantom_02 = new ScenarioEntity<IVehicle>(27, scenarioTag.WellKnownItems[27]);
            wraith_01 = new ScenarioEntity<IVehicle>(28, scenarioTag.WellKnownItems[28]);
            e1_gun0 = new ScenarioEntity<IWeapon>(29, scenarioTag.WellKnownItems[29]);
            e1_gun1 = new ScenarioEntity<IWeapon>(30, scenarioTag.WellKnownItems[30]);
            e1_gun2 = new ScenarioEntity<IWeapon>(31, scenarioTag.WellKnownItems[31]);
            e1_gun3 = new ScenarioEntity<IWeapon>(32, scenarioTag.WellKnownItems[32]);
            e1_gun4 = new ScenarioEntity<IWeapon>(33, scenarioTag.WellKnownItems[33]);
            intro_plasma_rifle = new ScenarioEntity<IWeapon>(34, scenarioTag.WellKnownItems[34]);
            key = new ScenarioEntity<IWeapon>(35, scenarioTag.WellKnownItems[35]);
            e1_pod0_inserter = new ScenarioEntity<IDevice>(36, scenarioTag.WellKnownItems[36]);
            e1_pod1_inserter = new ScenarioEntity<IDevice>(37, scenarioTag.WellKnownItems[37]);
            e1_pod2_inserter = new ScenarioEntity<IDevice>(38, scenarioTag.WellKnownItems[38]);
            e10_pod0_inserter = new ScenarioEntity<IDevice>(39, scenarioTag.WellKnownItems[39]);
            e10_pod1_inserter = new ScenarioEntity<IDevice>(40, scenarioTag.WellKnownItems[40]);
            e10_pod2_inserter = new ScenarioEntity<IDevice>(41, scenarioTag.WellKnownItems[41]);
            e10_pod3_inserter = new ScenarioEntity<IDevice>(42, scenarioTag.WellKnownItems[42]);
            e6_ghost_ledge_door = new ScenarioEntity<IDevice>(43, scenarioTag.WellKnownItems[43]);
            e4_door0 = new ScenarioEntity<IDevice>(44, scenarioTag.WellKnownItems[44]);
            e3_exit_door = new ScenarioEntity<IDevice>(45, scenarioTag.WellKnownItems[45]);
            e10_exit_door = new ScenarioEntity<IDevice>(46, scenarioTag.WellKnownItems[46]);
            intra1_door = new ScenarioEntity<IDevice>(47, scenarioTag.WellKnownItems[47]);
            e1_cov_inf0 = new Squad_e1_cov_inf0(scenarioTag);
            e1_cov_inf1 = new Squad_e1_cov_inf1(scenarioTag);
            e1_cov_inf2 = new Squad_e1_cov_inf2(scenarioTag);
            e1_cov_phantom0 = new Squad_e1_cov_phantom0(scenarioTag);
            e1_pro_inf0_0 = new Squad_e1_pro_inf0_0(scenarioTag);
            e1_pro_inf0_1 = new Squad_e1_pro_inf0_1(scenarioTag);
            e1_pro_inf0_1_1 = new Squad_e1_pro_inf0_1_1(scenarioTag);
            e1_pro_inf0_2 = new Squad_e1_pro_inf0_2(scenarioTag);
            e1_pro_inf0_3 = new Squad_e1_pro_inf0_3(scenarioTag);
            e1_pro_inf1 = new Squad_e1_pro_inf1(scenarioTag);
            e2_cov_inf0 = new Squad_e2_cov_inf0(scenarioTag);
            e2_cov_inf1 = new Squad_e2_cov_inf1(scenarioTag);
            e2_cov_gold_elite = new Squad_e2_cov_gold_elite(scenarioTag);
            e2_cov_grunts0 = new Squad_e2_cov_grunts0(scenarioTag);
            e2_pro_inf0 = new Squad_e2_pro_inf0(scenarioTag);
            e2_pro_inf1 = new Squad_e2_pro_inf1(scenarioTag);
            e2_pro_inf2 = new Squad_e2_pro_inf2(scenarioTag);
            e2_pro_inf3 = new Squad_e2_pro_inf3(scenarioTag);
            e3_cov_inf0 = new Squad_e3_cov_inf0(scenarioTag);
            e3_cov_gold_elite = new Squad_e3_cov_gold_elite(scenarioTag);
            e3_cov_grunts0 = new Squad_e3_cov_grunts0(scenarioTag);
            e3_pro_inf0_0 = new Squad_e3_pro_inf0_0(scenarioTag);
            e3_pro_inf0_1 = new Squad_e3_pro_inf0_1(scenarioTag);
            e3_pro_inf1 = new Squad_e3_pro_inf1(scenarioTag);
            e4_cov_inf0 = new Squad_e4_cov_inf0(scenarioTag);
            e4_cov_gold_elite = new Squad_e4_cov_gold_elite(scenarioTag);
            e4_pro_inf0_0 = new Squad_e4_pro_inf0_0(scenarioTag);
            e4_pro_inf0_1 = new Squad_e4_pro_inf0_1(scenarioTag);
            e4_pro_inf1 = new Squad_e4_pro_inf1(scenarioTag);
            e4_pro_inf2_0 = new Squad_e4_pro_inf2_0(scenarioTag);
            e4_pro_inf2_1 = new Squad_e4_pro_inf2_1(scenarioTag);
            e5_cov_inf0 = new Squad_e5_cov_inf0(scenarioTag);
            e5_cov_gold_elite = new Squad_e5_cov_gold_elite(scenarioTag);
            e5_cov_grunts0 = new Squad_e5_cov_grunts0(scenarioTag);
            e5_pro_inf0 = new Squad_e5_pro_inf0(scenarioTag);
            e5_pro_inf1 = new Squad_e5_pro_inf1(scenarioTag);
            e6_cov_inf0 = new Squad_e6_cov_inf0(scenarioTag);
            e6_cov_inf1 = new Squad_e6_cov_inf1(scenarioTag);
            e6_cov_gold_elite = new Squad_e6_cov_gold_elite(scenarioTag);
            e6_cov_ghosts0 = new Squad_e6_cov_ghosts0(scenarioTag);
            e6_cov_grunts0 = new Squad_e6_cov_grunts0(scenarioTag);
            e6_pro_inf0_0 = new Squad_e6_pro_inf0_0(scenarioTag);
            e6_pro_inf0_1 = new Squad_e6_pro_inf0_1(scenarioTag);
            e6_pro_inf1 = new Squad_e6_pro_inf1(scenarioTag);
            e6_pro_phantom0 = new Squad_e6_pro_phantom0(scenarioTag);
            ____GHOST_SECTION____ = new Squad_____GHOST_SECTION____(scenarioTag);
            e7_cov_inf0 = new Squad_e7_cov_inf0(scenarioTag);
            e7_cov_ghosts0 = new Squad_e7_cov_ghosts0(scenarioTag);
            e7_cov_ghosts1 = new Squad_e7_cov_ghosts1(scenarioTag);
            e7_pro_inf0_0 = new Squad_e7_pro_inf0_0(scenarioTag);
            e7_pro_inf0_1 = new Squad_e7_pro_inf0_1(scenarioTag);
            e7_pro_inf1_0 = new Squad_e7_pro_inf1_0(scenarioTag);
            e7_pro_inf1_1 = new Squad_e7_pro_inf1_1(scenarioTag);
            e7_pro_inf1_2 = new Squad_e7_pro_inf1_2(scenarioTag);
            e7_pro_inf2 = new Squad_e7_pro_inf2(scenarioTag);
            e8_cov_inf0 = new Squad_e8_cov_inf0(scenarioTag);
            e8_cov_ghosts0 = new Squad_e8_cov_ghosts0(scenarioTag);
            e8_pro_inf0 = new Squad_e8_pro_inf0(scenarioTag);
            e8_pro_inf1_0 = new Squad_e8_pro_inf1_0(scenarioTag);
            e8_pro_inf1_1 = new Squad_e8_pro_inf1_1(scenarioTag);
            e8_pro_inf2 = new Squad_e8_pro_inf2(scenarioTag);
            e8_pro_spectre0 = new Squad_e8_pro_spectre0(scenarioTag);
            e9_cov_ghosts0 = new Squad_e9_cov_ghosts0(scenarioTag);
            e9_pro_inf0_0 = new Squad_e9_pro_inf0_0(scenarioTag);
            e9_pro_inf0_1 = new Squad_e9_pro_inf0_1(scenarioTag);
            e9_pro_inf0_2 = new Squad_e9_pro_inf0_2(scenarioTag);
            e9_pro_inf1 = new Squad_e9_pro_inf1(scenarioTag);
            e9_pro_inf2 = new Squad_e9_pro_inf2(scenarioTag);
            e9_pro_inf3 = new Squad_e9_pro_inf3(scenarioTag);
            e9_pro_phantom0 = new Squad_e9_pro_phantom0(scenarioTag);
            e10_cov_inf0 = new Squad_e10_cov_inf0(scenarioTag);
            e10_cov_ghosts0 = new Squad_e10_cov_ghosts0(scenarioTag);
            e10_pro_inf0_0 = new Squad_e10_pro_inf0_0(scenarioTag);
            e10_pro_inf0_1 = new Squad_e10_pro_inf0_1(scenarioTag);
            e10_pro_inf1_0 = new Squad_e10_pro_inf1_0(scenarioTag);
            e10_pro_inf1_1 = new Squad_e10_pro_inf1_1(scenarioTag);
            e10_pro_inf1_2 = new Squad_e10_pro_inf1_2(scenarioTag);
            e10_pro_inf2_0 = new Squad_e10_pro_inf2_0(scenarioTag);
            e10_pro_inf2_1 = new Squad_e10_pro_inf2_1(scenarioTag);
            e10_pro_inf3 = new Squad_e10_pro_inf3(scenarioTag);
            e10_pro_wraith0_0 = new Squad_e10_pro_wraith0_0(scenarioTag);
            e10_pro_wraith0_1 = new Squad_e10_pro_wraith0_1(scenarioTag);
            e10_pro_phantom0 = new Squad_e10_pro_phantom0(scenarioTag);
            e10_pro_ghosts0_0 = new Squad_e10_pro_ghosts0_0(scenarioTag);
            e10_pro_ghosts0_1 = new Squad_e10_pro_ghosts0_1(scenarioTag);
        }

        public class Squad_e1_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[0].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_e1_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition stealth_major => ScenarioTag.AiSquadDefinitions[1].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_e1_cov_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition gold_elite => ScenarioTag.AiSquadDefinitions[2].StartingLocations[1];
            public IAiActorDefinition elite1 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[2];
            public IAiActorDefinition elite2 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_e1_cov_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_cov_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_e1_cov_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition brute0 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_e1_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition brute0 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_e1_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_inf0_1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition brute0 => ScenarioTag.AiSquadDefinitions[6].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[6];
            public Squad_e1_pro_inf0_1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[7].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[7];
            public Squad_e1_pro_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_inf0_3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[8].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[8];
            public Squad_e1_pro_inf0_3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e1_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition brute0 => ScenarioTag.AiSquadDefinitions[9].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[9];
            public Squad_e1_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[2];
            public IAiActorDefinition stealth_major => ScenarioTag.AiSquadDefinitions[10].StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[10].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[10];
            public Squad_e2_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_cov_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[11].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[11];
            public Squad_e2_cov_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_cov_gold_elite
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[12].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[12];
            public Squad_e2_cov_gold_elite(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_cov_grunts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[1];
            public IAiActorDefinition grunt0 => ScenarioTag.AiSquadDefinitions[13].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[13];
            public Squad_e2_cov_grunts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[14].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[14];
            public Squad_e2_pro_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[15].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[15];
            public Squad_e2_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[16].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[16];
            public Squad_e2_pro_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e2_pro_inf3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[17].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[17];
            public Squad_e2_pro_inf3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition stealth_major => ScenarioTag.AiSquadDefinitions[18].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[18].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[18];
            public Squad_e3_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_gold_elite
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[19].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[19];
            public Squad_e3_cov_gold_elite(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_cov_grunts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition grunt0 => ScenarioTag.AiSquadDefinitions[20].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[20];
            public Squad_e3_cov_grunts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[21].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[21];
            public Squad_e3_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[22].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[22];
            public Squad_e3_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e3_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[23].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[23];
            public Squad_e3_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[24].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[24];
            public Squad_e4_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_cov_gold_elite
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[25];
            public Squad_e4_cov_gold_elite(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[26].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[26];
            public Squad_e4_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[27].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[27];
            public Squad_e4_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[28].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[28];
            public Squad_e4_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf2_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[29].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[29];
            public Squad_e4_pro_inf2_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e4_pro_inf2_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[30].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[30];
            public Squad_e4_pro_inf2_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[31].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[31];
            public Squad_e5_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_gold_elite
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[32].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[32];
            public Squad_e5_cov_gold_elite(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_cov_grunts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[33].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[33];
            public Squad_e5_cov_grunts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_pro_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition turret0 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[5];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[34].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[34];
            public Squad_e5_pro_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e5_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[35].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[35];
            public Squad_e5_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[36].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[36];
            public Squad_e6_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[37].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[37];
            public Squad_e6_cov_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_gold_elite
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[38].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[38];
            public Squad_e6_cov_gold_elite(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[1];
            public IAiActorDefinition ghost2 => ScenarioTag.AiSquadDefinitions[39].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[39];
            public Squad_e6_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_cov_grunts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[40].StartingLocations[5];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[40];
            public Squad_e6_cov_grunts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[41].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[41];
            public Squad_e6_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[42].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[42];
            public Squad_e6_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[43].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[43];
            public Squad_e6_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e6_pro_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[44].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[44];
            public Squad_e6_pro_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_____GHOST_SECTION____
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[45];
            public Squad_____GHOST_SECTION____(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[46].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[46];
            public Squad_e7_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[47].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[47];
            public Squad_e7_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_cov_ghosts1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[1];
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[48].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[48];
            public Squad_e7_cov_ghosts1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[49].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[49];
            public Squad_e7_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition turret0 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[50].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[50];
            public Squad_e7_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_pro_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[51].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[51];
            public Squad_e7_pro_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_pro_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[52].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[52];
            public Squad_e7_pro_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_pro_inf1_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[53].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[53];
            public Squad_e7_pro_inf1_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e7_pro_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[54].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[54];
            public Squad_e7_pro_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition turret0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[1];
            public IAiActorDefinition grunt0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[2];
            public IAiActorDefinition grunt1 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[3];
            public IAiActorDefinition grunt2 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[4];
            public IAiActorDefinition ghost0 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[5];
            public IAiActorDefinition ghost1 => ScenarioTag.AiSquadDefinitions[55].StartingLocations[6];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[55];
            public Squad_e8_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[56].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[56];
            public Squad_e8_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_pro_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[57].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[57];
            public Squad_e8_pro_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_pro_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[1];
            public IAiActorDefinition starting_locations_11 => ScenarioTag.AiSquadDefinitions[58].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[58];
            public Squad_e8_pro_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_pro_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[59].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[59];
            public Squad_e8_pro_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_pro_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[60].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[60];
            public Squad_e8_pro_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e8_pro_spectre0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[61].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[61];
            public Squad_e8_pro_spectre0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[62].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[62];
            public Squad_e9_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[63].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[63];
            public Squad_e9_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[64].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[64];
            public Squad_e9_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf0_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[65].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[65];
            public Squad_e9_pro_inf0_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[66].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[66];
            public Squad_e9_pro_inf1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[67].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[67];
            public Squad_e9_pro_inf2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_inf3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[68].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[68];
            public Squad_e9_pro_inf3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e9_pro_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[69].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[69];
            public Squad_e9_pro_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_inf0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition elite0 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[1];
            public IAiActorDefinition elite1 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[2];
            public IAiActorDefinition elite2 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[3];
            public IAiActorDefinition elite3 => ScenarioTag.AiSquadDefinitions[70].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[70];
            public Squad_e10_cov_inf0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_cov_ghosts0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[71].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[71];
            public Squad_e10_cov_ghosts0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_inf0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[72].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[72];
            public Squad_e10_pro_inf0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_inf0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[73].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[73];
            public Squad_e10_pro_inf0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_inf1_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[74].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[74];
            public Squad_e10_pro_inf1_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_inf1_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[2];
            public IAiActorDefinition starting_locations_21 => ScenarioTag.AiSquadDefinitions[75].StartingLocations[3];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[75];
            public Squad_e10_pro_inf1_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_inf1_2
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[76].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[76];
            public Squad_e10_pro_inf1_2(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_inf2_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[77].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[77];
            public Squad_e10_pro_inf2_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_inf2_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[78].StartingLocations[4];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[78];
            public Squad_e10_pro_inf2_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_inf3
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[79].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[79];
            public Squad_e10_pro_inf3(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_wraith0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition wraith0 => ScenarioTag.AiSquadDefinitions[80].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[80];
            public Squad_e10_pro_wraith0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_wraith0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[81].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[81];
            public Squad_e10_pro_wraith0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_phantom0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition phantom0 => ScenarioTag.AiSquadDefinitions[82].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[82];
            public Squad_e10_pro_phantom0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_ghosts0_0
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[83].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[83];
            public Squad_e10_pro_ghosts0_0(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_e10_pro_ghosts0_1
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[84].StartingLocations[2];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[84];
            public Squad_e10_pro_ghosts0_1(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}