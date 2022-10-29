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
        public Squad_pussy_grunt2 pussy_grunt2 { get; set; }
        public Squad_ins_con_mid ins_con_mid { get; set; }
        public Squad_ins_con_bk ins_con_bk { get; set; }
        public Squad_insertion_sen insertion_sen { get; set; }
        public Squad_ins_con_slide ins_con_slide { get; set; }
        public Squad_hall_a_con_ini hall_a_con_ini { get; set; }
        public Squad_hall_a_con_bk hall_a_con_bk { get; set; }
        public Squad_hall_a_sen hall_a_sen { get; set; }
        public Squad_cond_a_cov cond_a_cov { get; set; }
        public Squad_cond_a_sen_ini1 cond_a_sen_ini1 { get; set; }
        public Squad_cond_a_sen_a cond_a_sen_a { get; set; }
        public Squad_cond_a_sen_b cond_a_sen_b { get; set; }
        public Squad_hall_b_cov hall_b_cov { get; set; }
        public Squad_hall_b_sen hall_b_sen { get; set; }
        public Squad_plug_launch_cov plug_launch_cov { get; set; }
        public Squad_plug_launch_enforcer plug_launch_enforcer { get; set; }
        public Squad_plug_launch_sen plug_launch_sen { get; set; }
        public Squad_gap_phantom1 gap_phantom1 { get; set; }
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
        public Squad_hall_c_marines1 hall_c_marines1 { get; set; }
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
        public Squad_hall_c_sen_tube1 hall_c_sen_tube1 { get; set; }
        public Squad_hall_c_em_sen hall_c_em_sen { get; set; }
        public Squad_ledge_a_enforcer ledge_a_enforcer { get; set; }
        public Squad_ledge_a_sen_ini1 ledge_a_sen_ini1 { get; set; }
        public Squad_ledge_a_sen ledge_a_sen { get; set; }
        public Squad_ledge_a_flood_ini1 ledge_a_flood_ini1 { get; set; }
        public Squad_ledge_a_flood_b ledge_a_flood_b { get; set; }
        public Squad_ledge_a_flood_c ledge_a_flood_c { get; set; }
        public Squad_ledge_a_flood_d1 ledge_a_flood_d1 { get; set; }
        public Squad_ledge_a_flood_d2 ledge_a_flood_d2 { get; set; }
        public Squad_ledge_a_flood_e ledge_a_flood_e { get; set; }
        public Squad_ledge_a_flood_f ledge_a_flood_f { get; set; }
        public Squad_ledge_a_flood_bot_a1 ledge_a_flood_bot_a1 { get; set; }
        public Squad_ledge_a_flood_bot_b1 ledge_a_flood_bot_b1 { get; set; }
        public Squad_cond_b_flood_tube_a cond_b_flood_tube_a { get; set; }
        public Squad_cond_b_flood_a_ini_a1 cond_b_flood_a_ini_a1 { get; set; }
        public Squad_cond_b_flood_a_ini_b1 cond_b_flood_a_ini_b1 { get; set; }
        public Squad_cond_b_flood_a_ini_c1 cond_b_flood_a_ini_c1 { get; set; }
        public Squad_cond_b_carrier_a cond_b_carrier_a { get; set; }
        public Squad_cond_b_flood_a cond_b_flood_a { get; set; }
        public Squad_cond_b_flood_b cond_b_flood_b { get; set; }
        public Squad_cond_b_flood_c cond_b_flood_c { get; set; }
        public Squad_cond_b_enforcer1 cond_b_enforcer1 { get; set; }
        public Squad_cond_b_flood_b_ini1 cond_b_flood_b_ini1 { get; set; }
        public Squad_cond_b_flood_c_ini_a1 cond_b_flood_c_ini_a1 { get; set; }
        public Squad_cond_b_flood_c_ini_b1 cond_b_flood_c_ini_b1 { get; set; }
        public Squad_cond_b_humans1 cond_b_humans1 { get; set; }
        public Squad_cond_b_infection_c cond_b_infection_c { get; set; }
        public Squad_cond_b_sen_b cond_b_sen_b { get; set; }
        public Squad_cond_b_sen_tube_b1 cond_b_sen_tube_b1 { get; set; }
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
        public Squad_qz_cov_def_flood_a1 qz_cov_def_flood_a1 { get; set; }
        public Squad_qz_cov_def_flood_b1 qz_cov_def_flood_b1 { get; set; }
        public Squad_qz_cov_def_flood_c1 qz_cov_def_flood_c1 { get; set; }
        public Squad_qz_cov_def_flood_d1 qz_cov_def_flood_d1 { get; set; }
        public Squad_qz_cov_def_flood_e1 qz_cov_def_flood_e1 { get; set; }
        public Squad_qz_cov_def_flood_f1 qz_cov_def_flood_f1 { get; set; }
        public Squad_qz_cov_def_flood_g1 qz_cov_def_flood_g1 { get; set; }
        public Squad_qz_cov_def_carrier1 qz_cov_def_carrier1 { get; set; }
        public Squad_qz_cov_def_soc qz_cov_def_soc { get; set; }
        public Squad_qz_cov_def_cov qz_cov_def_cov { get; set; }
        public Squad_qz_ini_turrets qz_ini_turrets { get; set; }
        public Squad_qz_camp_turrets qz_camp_turrets { get; set; }
        public Squad_ledge_c_phantom ledge_c_phantom { get; set; }
        public Squad_ledge_b_sen1 ledge_b_sen1 { get; set; }
        public Squad_ledge_b_flood ledge_b_flood { get; set; }
        public Squad_ledge_a_flood_dead ledge_a_flood_dead { get; set; }
        public Squad_qz_phantom qz_phantom { get; set; }
        public Squad_brutes_01 brutes_01 { get; set; }
        public Squad_brutes_02 brutes_02 { get; set; }
        public Squad_elites_01 elites_01 { get; set; }
        public Squad_elites_02 elites_02 { get; set; }
        public Squad_elites_03 elites_03 { get; set; }
        [SpawnCounts(1, 1)]
        public class Squad_pussy_grunt2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_pussy_grunt2(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "covenant1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_ins_con_mid : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_ins_con_mid(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "ins_cons")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ins_con_bk : SquadBase
        {
            public IAiActorDefinition shooter => Squad.StartingLocations[0];
            public IAiActorDefinition a => Squad.StartingLocations[1];
            public Squad_ins_con_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "ins_cons")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_insertion_sen : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public Squad_insertion_sen(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "insertion_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ins_con_slide : SquadBase
        {
            public IAiActorDefinition shooter => Squad.StartingLocations[0];
            public Squad_ins_con_slide(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "ins_cons")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_a_con_ini : SquadBase
        {
            public IAiActorDefinition sp_0 => Squad.StartingLocations[0];
            public IAiActorDefinition sp_1 => Squad.StartingLocations[1];
            public IAiActorDefinition sp_2 => Squad.StartingLocations[2];
            public Squad_hall_a_con_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "hall_a_cons")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_a_con_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_hall_a_con_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "hall_a_cons")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hall_a_sen : SquadBase
        {
            public IAiActorDefinition c => Squad.StartingLocations[0];
            public IAiActorDefinition d => Squad.StartingLocations[1];
            public IAiActorDefinition g => Squad.StartingLocations[2];
            public IAiActorDefinition h => Squad.StartingLocations[3];
            public Squad_hall_a_sen(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "hall_a_sentinels")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cond_a_cov : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_cond_a_cov(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "covenant1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_cond_a_sen_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public Squad_cond_a_sen_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "cond_a_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cond_a_sen_a : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition c => Squad.StartingLocations[1];
            public IAiActorDefinition e => Squad.StartingLocations[2];
            public IAiActorDefinition f => Squad.StartingLocations[3];
            public IAiActorDefinition g => Squad.StartingLocations[4];
            public IAiActorDefinition h => Squad.StartingLocations[5];
            public Squad_cond_a_sen_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "cond_a_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cond_a_sen_b : SquadBase
        {
            public IAiActorDefinition i => Squad.StartingLocations[0];
            public IAiActorDefinition j => Squad.StartingLocations[1];
            public IAiActorDefinition k => Squad.StartingLocations[2];
            public IAiActorDefinition l => Squad.StartingLocations[3];
            public IAiActorDefinition m => Squad.StartingLocations[4];
            public IAiActorDefinition n => Squad.StartingLocations[5];
            public IAiActorDefinition o => Squad.StartingLocations[6];
            public Squad_cond_a_sen_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "cond_a_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hall_b_cov : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition wimp => Squad.StartingLocations[5];
            public Squad_hall_b_cov(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "covenant1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hall_b_sen : SquadBase
        {
            public IAiActorDefinition b => Squad.StartingLocations[0];
            public IAiActorDefinition d => Squad.StartingLocations[1];
            public IAiActorDefinition e => Squad.StartingLocations[2];
            public IAiActorDefinition f => Squad.StartingLocations[3];
            public IAiActorDefinition g => Squad.StartingLocations[4];
            public Squad_hall_b_sen(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "hall_b_sentinels")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_plug_launch_cov : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_plug_launch_cov(ScenarioTag ScenarioTag) : base(ScenarioTag, 14)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_plug_launch_enforcer : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_plug_launch_enforcer(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_plug_launch_sen : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public IAiActorDefinition e => Squad.StartingLocations[4];
            public IAiActorDefinition f => Squad.StartingLocations[5];
            public IAiActorDefinition g => Squad.StartingLocations[6];
            public IAiActorDefinition h => Squad.StartingLocations[7];
            public Squad_plug_launch_sen(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "plug_launch_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gap_phantom1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_gap_phantom1(ScenarioTag ScenarioTag) : base(ScenarioTag, 17)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_gap_flood_lt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_gap_flood_lt(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "plug_holder_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_gap_flood_rt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_gap_flood_rt(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "plug_holder_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_plug_holder_sen : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public IAiActorDefinition e => Squad.StartingLocations[4];
            public IAiActorDefinition f => Squad.StartingLocations[5];
            public IAiActorDefinition g => Squad.StartingLocations[6];
            public IAiActorDefinition h => Squad.StartingLocations[7];
            public IAiActorDefinition i => Squad.StartingLocations[8];
            public Squad_plug_holder_sen(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "plug_holder_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_plug_holder_sen_elim : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_plug_holder_sen_elim(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "plug_holder_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_plug_holder_bk_sen : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public IAiActorDefinition e => Squad.StartingLocations[4];
            public IAiActorDefinition f => Squad.StartingLocations[5];
            public Squad_plug_holder_bk_sen(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "plug_holder_sentinels_bk")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_plug_holder_enforcer : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_plug_holder_enforcer(ScenarioTag ScenarioTag) : base(ScenarioTag, 23)
            {
            }
        }

        [SpawnCounts(2, 4)]
        public class Squad_plugholder_sen_bk_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_plugholder_sen_bk_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "plug_holder_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_plug_holder_flood_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_plug_holder_flood_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "plug_holder_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_plug_holder_flood_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_plug_holder_flood_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "plug_holder_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_plug_holder_flood_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_plug_holder_flood_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "plug_holder_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_plug_holder_flood_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_plug_holder_flood_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "plug_holder_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_plugholder_inf : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public Squad_plugholder_inf(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_plugholder_bk_flood_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[11];
            public Squad_plugholder_bk_flood_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "plug_holder_flood_bk")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_plugholder_bk_flood_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[11];
            public Squad_plugholder_bk_flood_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "plug_holder_flood_bk")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_plugholder_bk_infec_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_plugholder_bk_infec_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_plugholder_bk_infec_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_plugholder_bk_infec_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_plugholder_lower_hall_flood : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_plugholder_lower_hall_flood(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_plugholder_lower_hall_infec : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_plugholder_lower_hall_infec(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_c_marines1 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public Squad_hall_c_marines1(ScenarioTag ScenarioTag) : base(ScenarioTag, 36)
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hall_c_infec : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_hall_c_infec(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "hall_c_flood")
            {
            }
        }

        [SpawnCounts(4, 5)]
        public class Squad_hall_c_flood_near : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hall_c_flood_near(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "hall_c_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hall_c_flood_mid : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_hall_c_flood_mid(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "hall_c_flood")
            {
            }
        }

        [SpawnCounts(4, 5)]
        public class Squad_hall_c_flood_far : SquadBase
        {
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[4];
            public Squad_hall_c_flood_far(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "hall_c_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_hall_c_flood_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_hall_c_flood_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "hall_c_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_hall_c_flood_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public Squad_hall_c_flood_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "hall_c_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_hall_c_flood_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public Squad_hall_c_flood_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "hall_c_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_hall_c_flood_f : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_hall_c_flood_f(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "hall_c_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_c_carrier_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_hall_c_carrier_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "hall_c_flood_carrier")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_c_carrier_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_hall_c_carrier_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "hall_c_flood_carrier")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_c_carrier_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_hall_c_carrier_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "hall_c_flood_carrier")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_c_sen_tube1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_hall_c_sen_tube1(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "hall_c_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hall_c_em_sen : SquadBase
        {
            public IAiActorDefinition i => Squad.StartingLocations[0];
            public IAiActorDefinition j => Squad.StartingLocations[1];
            public IAiActorDefinition k => Squad.StartingLocations[2];
            public IAiActorDefinition l => Squad.StartingLocations[3];
            public IAiActorDefinition m => Squad.StartingLocations[4];
            public IAiActorDefinition o => Squad.StartingLocations[5];
            public Squad_hall_c_em_sen(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "hall_c_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_a_enforcer : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ledge_a_enforcer(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_a_sen_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_ledge_a_sen_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "ledge_a_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_a_sen : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public IAiActorDefinition e => Squad.StartingLocations[4];
            public IAiActorDefinition f => Squad.StartingLocations[5];
            public IAiActorDefinition g => Squad.StartingLocations[6];
            public IAiActorDefinition h => Squad.StartingLocations[7];
            public IAiActorDefinition i => Squad.StartingLocations[8];
            public Squad_ledge_a_sen(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "ledge_a_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_ledge_a_flood_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_ledge_a_flood_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_a_flood_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public Squad_ledge_a_flood_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_a_flood_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_ledge_a_flood_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_ledge_a_flood_d1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_ledge_a_flood_d1(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_ledge_a_flood_d2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_ledge_a_flood_d2(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_a_flood_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_ledge_a_flood_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_a_flood_f : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public Squad_ledge_a_flood_f(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_ledge_a_flood_bot_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_ledge_a_flood_bot_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_ledge_a_flood_bot_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_ledge_a_flood_bot_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "ledge_a_flood")
            {
            }
        }

        [SpawnCounts(2, 4)]
        public class Squad_cond_b_flood_tube_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_cond_b_flood_tube_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_cond_b_flood_a_ini_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_cond_b_flood_a_ini_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_cond_b_flood_a_ini_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_cond_b_flood_a_ini_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_cond_b_flood_a_ini_c1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_cond_b_flood_a_ini_c1(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_cond_b_carrier_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_cond_b_carrier_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cond_b_flood_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_cond_b_flood_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cond_b_flood_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_cond_b_flood_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cond_b_flood_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_cond_b_flood_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cond_b_enforcer1 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public Squad_cond_b_enforcer1(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "cond_b_sentinels")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cond_b_flood_b_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_cond_b_flood_b_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cond_b_flood_c_ini_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_cond_b_flood_c_ini_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_cond_b_flood_c_ini_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_cond_b_flood_c_ini_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "cond_b_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cond_b_humans1 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public Squad_cond_b_humans1(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "humans")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cond_b_infection_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_cond_b_infection_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_cond_b_sen_b : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public IAiActorDefinition a => Squad.StartingLocations[4];
            public IAiActorDefinition b => Squad.StartingLocations[5];
            public Squad_cond_b_sen_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "cond_b_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_cond_b_sen_tube_b1 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public Squad_cond_b_sen_tube_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "cond_b_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_c_flood_dead : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_ledge_c_flood_dead(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "ledge_c_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_ledge_c_flood_fr : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_ledge_c_flood_fr(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "ledge_c_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_ledge_c_flood_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_ledge_c_flood_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "ledge_c_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_c_infec_fr : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_ledge_c_infec_fr(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "ledge_c_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_c_infec_bk : SquadBase
        {
            public Squad_ledge_c_infec_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "ledge_c_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_initial_flood_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_qz_initial_flood_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "qz_ini_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_initial_flood_carrier_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_qz_initial_flood_carrier_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "qz_ini_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_initial_flood_bridge : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[5];
            public Squad_qz_initial_flood_bridge(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "qz_ini_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_qz_initial_flood_camp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[10];
            public Squad_qz_initial_flood_camp(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "qz_ini_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_initial_flood_carrier_camp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_qz_initial_flood_carrier_camp(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "qz_ini_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_initial_flood_cave : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public Squad_qz_initial_flood_cave(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "qz_ini_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_qz_ini_ins_pods : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public IAiActorDefinition e => Squad.StartingLocations[4];
            public Squad_qz_ini_ins_pods(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "covenant1")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_cov_def_flood_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_qz_cov_def_flood_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "qz_cov_def_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_flood_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public Squad_qz_cov_def_flood_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "qz_cov_def_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_flood_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_qz_cov_def_flood_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "qz_cov_def_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_flood_c1 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_41 => Squad.StartingLocations[4];
            public Squad_qz_cov_def_flood_c1(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "qz_cov_def_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_flood_d1 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[4];
            public Squad_qz_cov_def_flood_d1(ScenarioTag ScenarioTag) : base(ScenarioTag, 94, "qz_cov_def_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_flood_e1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public Squad_qz_cov_def_flood_e1(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "qz_cov_def_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_flood_f1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_qz_cov_def_flood_f1(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "qz_cov_def_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_flood_g1 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_41 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_qz_cov_def_flood_g1(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "qz_cov_def_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_cov_def_carrier1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_qz_cov_def_carrier1(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_cov_def_soc : SquadBase
        {
            public IAiActorDefinition soc => Squad.StartingLocations[0];
            public Squad_qz_cov_def_soc(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "covenant1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_cov : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_qz_cov_def_cov(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "covenant1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ini_turrets : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_qz_ini_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 101)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_camp_turrets : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_qz_camp_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 102)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_c_phantom : SquadBase
        {
            public IAiActorDefinition phantom => Squad.StartingLocations[0];
            public Squad_ledge_c_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 103)
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_ledge_b_sen1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_ledge_b_sen1(ScenarioTag ScenarioTag) : base(ScenarioTag, 104)
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_ledge_b_flood : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_61 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_71 => Squad.StartingLocations[7];
            public Squad_ledge_b_flood(ScenarioTag ScenarioTag) : base(ScenarioTag, 105)
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_ledge_a_flood_dead : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_ledge_a_flood_dead(ScenarioTag ScenarioTag) : base(ScenarioTag, 106)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_phantom : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 107)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_brutes_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_brutes_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 108)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_brutes_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_brutes_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 109)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 110)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 111)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_elites_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_elites_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 112)
            {
            }
        }
    }
}