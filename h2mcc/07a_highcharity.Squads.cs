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
        public Squad_c07_infection_old c07_infection_old { get; set; }
        public Squad_empty empty { get; set; }
        public Squad_cortana_01 cortana_01 { get; set; }
        public Squad_cortana_11 cortana_11 { get; set; }
        public Squad_cortana_grand_b cortana_grand_b { get; set; }
        public Squad_cortana_corridor_a cortana_corridor_a { get; set; }
        public Squad_cortana_room_a cortana_room_a { get; set; }
        public Squad_cortana_room_b cortana_room_b { get; set; }
        public Squad_cortana_corridor_b cortana_corridor_b { get; set; }
        public Squad_cortana_jail1 cortana_jail1 { get; set; }
        public Squad_cortana_3a1 cortana_3a1 { get; set; }
        public Squad_cortana_3b1 cortana_3b1 { get; set; }
        public Squad_cortana_41 cortana_41 { get; set; }
        public Squad_cortana_maus_room cortana_maus_room { get; set; }
        public Squad_cortana_maus_bridge cortana_maus_bridge { get; set; }
        public Squad_cortana_maus cortana_maus { get; set; }
        public Squad_marines_bsp2 marines_bsp2 { get; set; }
        public Squad_marines_bsp3 marines_bsp3 { get; set; }
        public Squad________COUNCIL_CHAMBER_______ _______COUNCIL_CHAMBER_______ { get; set; }
        public Squad_council_brute_ini1 council_brute_ini1 { get; set; }
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
        public Squad_grand_a_turret1 grand_a_turret1 { get; set; }
        public Squad_ledge_brutes_honor_ini1 ledge_brutes_honor_ini1 { get; set; }
        public Squad_ledge_brutes_ini1 ledge_brutes_ini1 { get; set; }
        public Squad_ledge_jackal_left ledge_jackal_left { get; set; }
        public Squad_ledge_jackal_right ledge_jackal_right { get; set; }
        public Squad_ledge_lift_brute_rt ledge_lift_brute_rt { get; set; }
        public Squad_ledge_lift_brute_lt ledge_lift_brute_lt { get; set; }
        public Squad_ledge_lift_chieftan ledge_lift_chieftan { get; set; }
        public Squad_ledge_lift_grunt_rt ledge_lift_grunt_rt { get; set; }
        public Squad_ledge_lift_grunt_lt ledge_lift_grunt_lt { get; set; }
        public Squad_ledge_bot_grunts1 ledge_bot_grunts1 { get; set; }
        public Squad_ledge_bot_jackals1 ledge_bot_jackals1 { get; set; }
        public Squad________CORIDORS_A_______ _______CORIDORS_A_______ { get; set; }
        public Squad_hall_a_jackal_patrol_ini hall_a_jackal_patrol_ini { get; set; }
        public Squad_hall_a_brute_ini1 hall_a_brute_ini1 { get; set; }
        public Squad_hall_a_jackal_ini2 hall_a_jackal_ini2 { get; set; }
        public Squad_hall_a_brute_rein hall_a_brute_rein { get; set; }
        public Squad_hall_a_brute_rein_bk1 hall_a_brute_rein_bk1 { get; set; }
        public Squad_hall_a_grunt_rein hall_a_grunt_rein { get; set; }
        public Squad_hall_a_grunt_rein_bk1 hall_a_grunt_rein_bk1 { get; set; }
        public Squad_hall_b_brutes1 hall_b_brutes1 { get; set; }
        public Squad_hall_b_grunts1 hall_b_grunts1 { get; set; }
        public Squad_hall_b_grunts_bk1 hall_b_grunts_bk1 { get; set; }
        public Squad_hall_b_jackals hall_b_jackals { get; set; }
        public Squad_room_a_brutes_ini1 room_a_brutes_ini1 { get; set; }
        public Squad_room_a_jackals_ini room_a_jackals_ini { get; set; }
        public Squad_room_a_brutes_bk1 room_a_brutes_bk1 { get; set; }
        public Squad_room_a_brutes_a room_a_brutes_a { get; set; }
        public Squad_room_a_brutes_b room_a_brutes_b { get; set; }
        public Squad_room_a_brutes_c room_a_brutes_c { get; set; }
        public Squad_room_a_grunts_a room_a_grunts_a { get; set; }
        public Squad_room_a_grunts_b room_a_grunts_b { get; set; }
        public Squad_room_a_grunts_c room_a_grunts_c { get; set; }
        public Squad_room_a_tube_fodder room_a_tube_fodder { get; set; }
        public Squad__________JAIL_________ _________JAIL_________ { get; set; }
        public Squad_jail_trash jail_trash { get; set; }
        public Squad_jail_brutes_ini1 jail_brutes_ini1 { get; set; }
        public Squad_jail_grunts_ini1 jail_grunts_ini1 { get; set; }
        public Squad_jail_jackals_ini1 jail_jackals_ini1 { get; set; }
        public Squad_jail_brutes_down jail_brutes_down { get; set; }
        public Squad_jail_grunts_down jail_grunts_down { get; set; }
        public Squad_jail_jackals_down jail_jackals_down { get; set; }
        public Squad_jail_a_marines jail_a_marines { get; set; }
        public Squad_jail_a_brute1 jail_a_brute1 { get; set; }
        public Squad_jail_a_jackals1 jail_a_jackals1 { get; set; }
        public Squad_jail_b_marines jail_b_marines { get; set; }
        public Squad_jail_b_brutes jail_b_brutes { get; set; }
        public Squad_jail_b_grunts1 jail_b_grunts1 { get; set; }
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
        public Squad_room_b_marines1 room_b_marines1 { get; set; }
        public Squad_room_b_brutes_ini1 room_b_brutes_ini1 { get; set; }
        public Squad_room_b_elites1 room_b_elites1 { get; set; }
        public Squad_room_b_buggers1 room_b_buggers1 { get; set; }
        public Squad_hall_c_elites1 hall_c_elites1 { get; set; }
        public Squad_hall_c_buggers1 hall_c_buggers1 { get; set; }
        public Squad_hall_c_brute_reins hall_c_brute_reins { get; set; }
        public Squad_hall_c_bugger_reins hall_c_bugger_reins { get; set; }
        public Squad_hall_d_elites1 hall_d_elites1 { get; set; }
        public Squad_hall_d_brutes1 hall_d_brutes1 { get; set; }
        public Squad_hall_d_jackals_fr1 hall_d_jackals_fr1 { get; set; }
        public Squad_hall_d_jackals_bk1 hall_d_jackals_bk1 { get; set; }
        public Squad_grand_b_hunter_a1 grand_b_hunter_a1 { get; set; }
        public Squad_grand_b_hunter_b1 grand_b_hunter_b1 { get; set; }
        public Squad________EXT_A_______ _______EXT_A_______ { get; set; }
        public Squad_ext_a_jackal_snipers_a1 ext_a_jackal_snipers_a1 { get; set; }
        public Squad_ext_a_jackal_snipers_b1 ext_a_jackal_snipers_b1 { get; set; }
        public Squad_ext_a_jackal_snipers_c1 ext_a_jackal_snipers_c1 { get; set; }
        public Squad_ext_a_jackal_snipers_d1 ext_a_jackal_snipers_d1 { get; set; }
        public Squad_ext_a_watch_brutes1 ext_a_watch_brutes1 { get; set; }
        public Squad_ext_a_watch_elites ext_a_watch_elites { get; set; }
        public Squad_ext_a_hunters ext_a_hunters { get; set; }
        public Squad_ext_a_brute_door1 ext_a_brute_door1 { get; set; }
        public Squad_ext_a_elite_ini1 ext_a_elite_ini1 { get; set; }
        public Squad_ext_a_brute_ini1 ext_a_brute_ini1 { get; set; }
        public Squad_ext_a_rangers1 ext_a_rangers1 { get; set; }
        public Squad_ext_a_buggers1 ext_a_buggers1 { get; set; }
        public Squad_ext_a_brute_bk_door1 ext_a_brute_bk_door1 { get; set; }
        public Squad_ext_a_buggers_bk1 ext_a_buggers_bk1 { get; set; }
        public Squad_ext_a_brutes_bk1 ext_a_brutes_bk1 { get; set; }
        public Squad________GARDEN_A_______ _______GARDEN_A_______ { get; set; }
        public Squad_garden_a_elites garden_a_elites { get; set; }
        public Squad_garden_a_grunts garden_a_grunts { get; set; }
        public Squad_garden_a_brute_lt1 garden_a_brute_lt1 { get; set; }
        public Squad_garden_a_brute_rt1 garden_a_brute_rt1 { get; set; }
        public Squad_garden_a_jackal_snipers1 garden_a_jackal_snipers1 { get; set; }
        public Squad_garden_a_buggers garden_a_buggers { get; set; }
        public Squad_garden_a_brute_a1 garden_a_brute_a1 { get; set; }
        public Squad_garden_a_brute_b1 garden_a_brute_b1 { get; set; }
        public Squad_garden_a_brute_c1 garden_a_brute_c1 { get; set; }
        public Squad_garden_a_elite_a1 garden_a_elite_a1 { get; set; }
        public Squad_garden_a_elite_b1 garden_a_elite_b1 { get; set; }
        public Squad_garden_a_elite_c1 garden_a_elite_c1 { get; set; }
        public Squad_garden_a_rangers garden_a_rangers { get; set; }
        public Squad_garden_a_elites_bk1 garden_a_elites_bk1 { get; set; }
        public Squad_garden_a_grunts_bk garden_a_grunts_bk { get; set; }
        public Squad_garden_a_jackals_bk garden_a_jackals_bk { get; set; }
        public Squad_garden_a_brutes_bk garden_a_brutes_bk { get; set; }
        public Squad________MID_TOWER_______ _______MID_TOWER_______ { get; set; }
        public Squad_midtower_turrets midtower_turrets { get; set; }
        public Squad_midtower_elites1 midtower_elites1 { get; set; }
        public Squad_midtower_elite_reins midtower_elite_reins { get; set; }
        public Squad_mid_tower_hunters mid_tower_hunters { get; set; }
        public Squad_midtower_buggers_ini midtower_buggers_ini { get; set; }
        public Squad_midtower_bugger_rein midtower_bugger_rein { get; set; }
        public Squad_midtower_brutes1 midtower_brutes1 { get; set; }
        public Squad_midtower_jackals1 midtower_jackals1 { get; set; }
        public Squad_midtower_buggers_hall midtower_buggers_hall { get; set; }
        public Squad________GARDEN_B_______ _______GARDEN_B_______ { get; set; }
        public Squad_garden_b_grunt_a garden_b_grunt_a { get; set; }
        public Squad_garden_b_grunt_b garden_b_grunt_b { get; set; }
        public Squad_garden_b_grunt_c garden_b_grunt_c { get; set; }
        public Squad_garden_b_brute_ini garden_b_brute_ini { get; set; }
        public Squad________EXT_B_______ _______EXT_B_______ { get; set; }
        public Squad_ext_b_brute_ramp1 ext_b_brute_ramp1 { get; set; }
        public Squad_ext_b_elite_a1 ext_b_elite_a1 { get; set; }
        public Squad_ext_b_brute_a1 ext_b_brute_a1 { get; set; }
        public Squad_ext_b_grunts_b1 ext_b_grunts_b1 { get; set; }
        public Squad_ext_b_brutes_b1 ext_b_brutes_b1 { get; set; }
        public Squad_ext_b_grunts_low1 ext_b_grunts_low1 { get; set; }
        public Squad_ext_b_brutes_low1 ext_b_brutes_low1 { get; set; }
        public Squad_ext_b_jackal_a1 ext_b_jackal_a1 { get; set; }
        public Squad_ext_b_grunt_bk_door1 ext_b_grunt_bk_door1 { get; set; }
        public Squad_ext_b_elites_bk_door1 ext_b_elites_bk_door1 { get; set; }
        public Squad_ext_b_elites_stealth ext_b_elites_stealth { get; set; }
        public Squad_ext_b_grunts_lt1 ext_b_grunts_lt1 { get; set; }
        public Squad_ext_b_brutes_low_door1 ext_b_brutes_low_door1 { get; set; }
        public Squad_ext_b_jackal_b ext_b_jackal_b { get; set; }
        public Squad_ext_b_jackal_c ext_b_jackal_c { get; set; }
        public Squad_ext_b_cov_dump1 ext_b_cov_dump1 { get; set; }
        public Squad_ext_b_prophet_dump1 ext_b_prophet_dump1 { get; set; }
        public Squad________MAUSOLEUM_______ _______MAUSOLEUM_______ { get; set; }
        public Squad_maus_hall_elites_stealth1 maus_hall_elites_stealth1 { get; set; }
        public Squad_maus_hall_grunts1 maus_hall_grunts1 { get; set; }
        public Squad_maus_room_elite_lt1 maus_room_elite_lt1 { get; set; }
        public Squad_maus_room_elite_rt1 maus_room_elite_rt1 { get; set; }
        public Squad_maus_room_grunt_lt1 maus_room_grunt_lt1 { get; set; }
        public Squad_maus_room_grunt_rt1 maus_room_grunt_rt1 { get; set; }
        public Squad_maus_room_brute_bk1 maus_room_brute_bk1 { get; set; }
        public Squad_maus_room_jackal_bk_lt1 maus_room_jackal_bk_lt1 { get; set; }
        public Squad_maus_room_jackal_bk_rt1 maus_room_jackal_bk_rt1 { get; set; }
        public Squad_maus_room_lt_elite_reins maus_room_lt_elite_reins { get; set; }
        public Squad_maus_room_rt_elite_reins maus_room_rt_elite_reins { get; set; }
        public Squad_maus_room_lt_grunt_reins maus_room_lt_grunt_reins { get; set; }
        public Squad_maus_room_rt_grunt_reins maus_room_rt_grunt_reins { get; set; }
        public Squad_maus_bridge_elite_turret maus_bridge_elite_turret { get; set; }
        public Squad_maus_bridge_elites_ini1 maus_bridge_elites_ini1 { get; set; }
        public Squad_maus_bridge_elite_rein maus_bridge_elite_rein { get; set; }
        public Squad_maus_bridge_grunt_rein maus_bridge_grunt_rein { get; set; }
        public Squad_maus_bridge_grunt_rein_b1 maus_bridge_grunt_rein_b1 { get; set; }
        public Squad_maus_bridge_hunters1 maus_bridge_hunters1 { get; set; }
        public Squad_maus_bridge_buggers_ini1 maus_bridge_buggers_ini1 { get; set; }
        public Squad_maus_bridge_brutes_ini maus_bridge_brutes_ini { get; set; }
        public Squad_maus_bridge_jackals_ini maus_bridge_jackals_ini { get; set; }
        public Squad_maus_inner_hunters_ini maus_inner_hunters_ini { get; set; }
        public Squad_maus_inner_elites_ini1 maus_inner_elites_ini1 { get; set; }
        public Squad_maus_inner_grunts_ini maus_inner_grunts_ini { get; set; }
        public Squad_maus_inner_turrets maus_inner_turrets { get; set; }
        public Squad_maus_inner_brutes_ini1 maus_inner_brutes_ini1 { get; set; }
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
        public Squad_ice_cream_grunt1 ice_cream_grunt1 { get; set; }
        public Squad_c07_infection c07_infection { get; set; }
        [SpawnCounts(17, 17)]
        public class Squad_c07_infection_old : SquadBase
        {
            public IAiActorDefinition _0 => Squad.StartingLocations[0];
            public IAiActorDefinition _1 => Squad.StartingLocations[1];
            public IAiActorDefinition _2 => Squad.StartingLocations[2];
            public IAiActorDefinition _3 => Squad.StartingLocations[3];
            public IAiActorDefinition _4 => Squad.StartingLocations[4];
            public IAiActorDefinition _5 => Squad.StartingLocations[5];
            public IAiActorDefinition _6 => Squad.StartingLocations[6];
            public IAiActorDefinition _7 => Squad.StartingLocations[7];
            public IAiActorDefinition _8 => Squad.StartingLocations[8];
            public IAiActorDefinition _9 => Squad.StartingLocations[9];
            public IAiActorDefinition _10 => Squad.StartingLocations[10];
            public IAiActorDefinition _11 => Squad.StartingLocations[11];
            public IAiActorDefinition _12 => Squad.StartingLocations[12];
            public IAiActorDefinition _13 => Squad.StartingLocations[13];
            public IAiActorDefinition _14 => Squad.StartingLocations[14];
            public IAiActorDefinition _15 => Squad.StartingLocations[15];
            public IAiActorDefinition _16 => Squad.StartingLocations[16];
            public Squad_c07_infection_old(ScenarioTag ScenarioTag) : base(ScenarioTag, 0)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_empty : SquadBase
        {
            public Squad_empty(ScenarioTag ScenarioTag) : base(ScenarioTag, 1)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_01 : SquadBase
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
            public IAiActorDefinition j => Squad.StartingLocations[9];
            public Squad_cortana_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_11 : SquadBase
        {
            public Squad_cortana_11(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_grand_b : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_cortana_grand_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_corridor_a : SquadBase
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
            public IAiActorDefinition j => Squad.StartingLocations[9];
            public IAiActorDefinition k => Squad.StartingLocations[10];
            public IAiActorDefinition l => Squad.StartingLocations[11];
            public IAiActorDefinition m => Squad.StartingLocations[12];
            public IAiActorDefinition n => Squad.StartingLocations[13];
            public IAiActorDefinition o => Squad.StartingLocations[14];
            public Squad_cortana_corridor_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_room_a : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition d => Squad.StartingLocations[2];
            public IAiActorDefinition e => Squad.StartingLocations[3];
            public IAiActorDefinition g => Squad.StartingLocations[4];
            public IAiActorDefinition h => Squad.StartingLocations[5];
            public IAiActorDefinition i => Squad.StartingLocations[6];
            public IAiActorDefinition j => Squad.StartingLocations[7];
            public IAiActorDefinition l => Squad.StartingLocations[8];
            public IAiActorDefinition m => Squad.StartingLocations[9];
            public Squad_cortana_room_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_room_b : SquadBase
        {
            public Squad_cortana_room_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_corridor_b : SquadBase
        {
            public Squad_cortana_corridor_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_jail1 : SquadBase
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
            public IAiActorDefinition j => Squad.StartingLocations[9];
            public IAiActorDefinition k => Squad.StartingLocations[10];
            public IAiActorDefinition l => Squad.StartingLocations[11];
            public IAiActorDefinition m => Squad.StartingLocations[12];
            public IAiActorDefinition n => Squad.StartingLocations[13];
            public IAiActorDefinition o => Squad.StartingLocations[14];
            public IAiActorDefinition p => Squad.StartingLocations[15];
            public IAiActorDefinition q => Squad.StartingLocations[16];
            public IAiActorDefinition r => Squad.StartingLocations[17];
            public IAiActorDefinition s => Squad.StartingLocations[18];
            public IAiActorDefinition t => Squad.StartingLocations[19];
            public IAiActorDefinition u => Squad.StartingLocations[20];
            public Squad_cortana_jail1(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_3a1 : SquadBase
        {
            public IAiActorDefinition tram_a => Squad.StartingLocations[0];
            public Squad_cortana_3a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_3b1 : SquadBase
        {
            public Squad_cortana_3b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_41 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_cortana_41(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_maus_room : SquadBase
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
            public IAiActorDefinition j => Squad.StartingLocations[9];
            public IAiActorDefinition k => Squad.StartingLocations[10];
            public IAiActorDefinition l => Squad.StartingLocations[11];
            public IAiActorDefinition m => Squad.StartingLocations[12];
            public IAiActorDefinition n => Squad.StartingLocations[13];
            public IAiActorDefinition o => Squad.StartingLocations[14];
            public Squad_cortana_maus_room(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_maus_bridge : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public IAiActorDefinition e => Squad.StartingLocations[4];
            public IAiActorDefinition f => Squad.StartingLocations[5];
            public Squad_cortana_maus_bridge(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "cortana1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana_maus : SquadBase
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
            public IAiActorDefinition j => Squad.StartingLocations[9];
            public IAiActorDefinition k => Squad.StartingLocations[10];
            public IAiActorDefinition l => Squad.StartingLocations[11];
            public IAiActorDefinition m => Squad.StartingLocations[12];
            public IAiActorDefinition n => Squad.StartingLocations[13];
            public IAiActorDefinition o => Squad.StartingLocations[14];
            public IAiActorDefinition p => Squad.StartingLocations[15];
            public Squad_cortana_maus(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "cortana1")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_marines_bsp2 : SquadBase
        {
            public Squad_marines_bsp2(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "marines")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_marines_bsp3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_marines_bsp3(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "marines")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad________COUNCIL_CHAMBER_______ : SquadBase
        {
            public Squad________COUNCIL_CHAMBER_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 18)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_council_brute_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_brute_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(2, 4)]
        public class Squad_council_grunt_ini : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public Squad_council_grunt_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_council_brute_ped : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition chief => Squad.StartingLocations[3];
            public Squad_council_brute_ped(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_council_rt_grunt_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_council_rt_grunt_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_council_rt_grunt_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_council_rt_grunt_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_council_rt_grunt_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_council_rt_grunt_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_council_lt_grunt_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_council_lt_grunt_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_council_lt_grunt_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_council_lt_grunt_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_council_lt_grunt_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_council_lt_grunt_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_rt_brute_a : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[1];
            public Squad_council_rt_brute_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_rt_brute_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_rt_brute_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_rt_brute_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_rt_brute_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_lt_brute_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_lt_brute_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_lt_brute_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_lt_brute_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_lt_brute_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_lt_brute_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_rt_upper_brute_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_rt_upper_brute_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "council_prophets_upper")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_rt_upper_brute_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_rt_upper_brute_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "council_prophets_upper")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_rt_upper_brute_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_rt_upper_brute_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "council_prophets_upper")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_lt_upper_brute_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_lt_upper_brute_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "council_prophets_upper")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_lt_upper_brute_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_lt_upper_brute_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "council_prophets_upper")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_council_lt_upper_brute_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_council_lt_upper_brute_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "council_prophets_upper")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grand_a_brutes : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grand_a_brutes(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "grand_a_prophets")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_grand_a_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public Squad_grand_a_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "grand_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grand_a_turret1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grand_a_turret1(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "grand_a_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_brutes_honor_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ledge_brutes_honor_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "dervish_ledge_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_brutes_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ledge_brutes_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "dervish_ledge_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_jackal_left : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ledge_jackal_left(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "dervish_ledge_left")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_jackal_right : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ledge_jackal_right(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "dervish_ledge_right")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_lift_brute_rt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ledge_lift_brute_rt(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "dervish_ledge_right")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_lift_brute_lt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ledge_lift_brute_lt(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "dervish_ledge_left")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ledge_lift_chieftan : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ledge_lift_chieftan(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "dervish_ledge_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_lift_grunt_rt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_ledge_lift_grunt_rt(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "dervish_ledge_right")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_lift_grunt_lt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_ledge_lift_grunt_lt(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "dervish_ledge_left")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_bot_grunts1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_ledge_bot_grunts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "dervish_ledge_lower")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_bot_jackals1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ledge_bot_jackals1(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "dervish_ledge_lower")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad________CORIDORS_A_______ : SquadBase
        {
            public Squad________CORIDORS_A_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 54)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_a_jackal_patrol_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_hall_a_jackal_patrol_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "hall_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hall_a_brute_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hall_a_brute_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "hall_a_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_a_jackal_ini2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hall_a_jackal_ini2(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "hall_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hall_a_brute_rein : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_hall_a_brute_rein(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "hall_a_rein_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hall_a_brute_rein_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hall_a_brute_rein_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "hall_a_rein_prophet")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_a_grunt_rein : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_hall_a_grunt_rein(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "hall_a_rein_prophet")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_a_grunt_rein_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hall_a_grunt_rein_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "hall_a_rein_prophet")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_b_brutes1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hall_b_brutes1(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "hall_b_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_b_grunts1 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[5];
            public Squad_hall_b_grunts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "hall_b_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_b_grunts_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_hall_b_grunts_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "hall_b_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_b_jackals : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hall_b_jackals(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "hall_b_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_room_a_brutes_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_room_a_brutes_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "room_a_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_room_a_jackals_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_room_a_jackals_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "room_a_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_room_a_brutes_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_room_a_brutes_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "room_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_room_a_brutes_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_room_a_brutes_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "room_a_reins")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_room_a_brutes_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_room_a_brutes_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "room_a_reins")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_room_a_brutes_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_room_a_brutes_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "room_a_reins")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_room_a_grunts_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_room_a_grunts_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "room_a_reins")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_room_a_grunts_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_room_a_grunts_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "room_a_reins")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_room_a_grunts_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_room_a_grunts_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "room_a_reins")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_room_a_tube_fodder : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_room_a_tube_fodder(ScenarioTag ScenarioTag) : base(ScenarioTag, 75)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad__________JAIL_________ : SquadBase
        {
            public Squad__________JAIL_________(ScenarioTag ScenarioTag) : base(ScenarioTag, 76)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_jail_trash : SquadBase
        {
            public Squad_jail_trash(ScenarioTag ScenarioTag) : base(ScenarioTag, 77)
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_jail_brutes_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brutes_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "jail_prophets")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_jail_grunts_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_jail_grunts_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_jackals_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_jail_jackals_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_brutes_down : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_jail_brutes_down(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "jail_prophets")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_jail_grunts_down : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition t1 => Squad.StartingLocations[2];
            public IAiActorDefinition t2 => Squad.StartingLocations[3];
            public Squad_jail_grunts_down(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackals_down : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_jackals_down(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_a_marines : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_jail_a_marines(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "jail_marines")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_a_brute1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_jail_a_brute1(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "cell_a_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_a_jackals1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_a_jackals1(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "cell_a_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_b_marines : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public Squad_jail_b_marines(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "jail_marines")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_b_brutes : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_jail_b_brutes(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "cell_b_prophets")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_jail_b_grunts1 : SquadBase
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
            public Squad_jail_b_grunts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "cell_b_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_guard_brute_cell_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_jail_guard_brute_cell_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "jail_cell_outer_guards_a")
            {
            }
        }

        [SpawnCounts(2, 4)]
        public class Squad_jail_guard_jackal_cell_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_jail_guard_jackal_cell_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "jail_cell_outer_guards_a")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_guard_brute_cell_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_guard_brute_cell_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "jail_cell_outer_guards_b")
            {
            }
        }

        [SpawnCounts(2, 4)]
        public class Squad_jail_guard_jackal_cell_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_jail_guard_jackal_cell_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "jail_cell_outer_guards_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 94, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_f : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_f(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_g : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_g(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_i : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_i(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_j : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_j(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_k : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_k(ScenarioTag ScenarioTag) : base(ScenarioTag, 101, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_l(ScenarioTag ScenarioTag) : base(ScenarioTag, 102, "jail_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_jail_brute_m : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_brute_m(ScenarioTag ScenarioTag) : base(ScenarioTag, 103, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 105, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 106, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_f : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_f(ScenarioTag ScenarioTag) : base(ScenarioTag, 107, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_g : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_g(ScenarioTag ScenarioTag) : base(ScenarioTag, 108, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_i : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_i(ScenarioTag ScenarioTag) : base(ScenarioTag, 109, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_j : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_j(ScenarioTag ScenarioTag) : base(ScenarioTag, 110, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_k : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_k(ScenarioTag ScenarioTag) : base(ScenarioTag, 111, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_l(ScenarioTag ScenarioTag) : base(ScenarioTag, 112, "jail_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_jail_grunt_m : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_jail_grunt_m(ScenarioTag ScenarioTag) : base(ScenarioTag, 113, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 114, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 115, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 116, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_f : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_f(ScenarioTag ScenarioTag) : base(ScenarioTag, 117, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_g : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_g(ScenarioTag ScenarioTag) : base(ScenarioTag, 118, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_i : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_i(ScenarioTag ScenarioTag) : base(ScenarioTag, 119, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_j : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_j(ScenarioTag ScenarioTag) : base(ScenarioTag, 120, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_k : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_k(ScenarioTag ScenarioTag) : base(ScenarioTag, 121, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_l(ScenarioTag ScenarioTag) : base(ScenarioTag, 122, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jail_jackal_m : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jail_jackal_m(ScenarioTag ScenarioTag) : base(ScenarioTag, 123, "jail_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad________CORRIDORS_B_______ : SquadBase
        {
            public Squad________CORRIDORS_B_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 124, "council_prophets_floor")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_room_b_marines1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_room_b_marines1(ScenarioTag ScenarioTag) : base(ScenarioTag, 125, "marines")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_room_b_brutes_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_room_b_brutes_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 126, "room_b_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_room_b_elites1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_room_b_elites1(ScenarioTag ScenarioTag) : base(ScenarioTag, 127, "room_b_covenant")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_room_b_buggers1 : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_13 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[10];
            public Squad_room_b_buggers1(ScenarioTag ScenarioTag) : base(ScenarioTag, 128, "room_b_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_c_elites1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hall_c_elites1(ScenarioTag ScenarioTag) : base(ScenarioTag, 129, "corridor_b_covenant")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hall_c_buggers1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_hall_c_buggers1(ScenarioTag ScenarioTag) : base(ScenarioTag, 130, "corridor_b_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_c_brute_reins : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hall_c_brute_reins(ScenarioTag ScenarioTag) : base(ScenarioTag, 131, "corridor_b_prophets")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_hall_c_bugger_reins : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_hall_c_bugger_reins(ScenarioTag ScenarioTag) : base(ScenarioTag, 132, "corridor_b_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hall_d_elites1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hall_d_elites1(ScenarioTag ScenarioTag) : base(ScenarioTag, 133, "corridor_b_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_d_brutes1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hall_d_brutes1(ScenarioTag ScenarioTag) : base(ScenarioTag, 134, "corridor_b_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_d_jackals_fr1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hall_d_jackals_fr1(ScenarioTag ScenarioTag) : base(ScenarioTag, 135, "corridor_b_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hall_d_jackals_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hall_d_jackals_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 136, "corridor_b_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grand_b_hunter_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grand_b_hunter_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 137, "grand_b_hunters")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grand_b_hunter_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grand_b_hunter_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 138, "grand_b_hunters")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad________EXT_A_______ : SquadBase
        {
            public Squad________EXT_A_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 139)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_jackal_snipers_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_a_jackal_snipers_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 140, "ext_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_jackal_snipers_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_a_jackal_snipers_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 141, "ext_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_jackal_snipers_c1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_a_jackal_snipers_c1(ScenarioTag ScenarioTag) : base(ScenarioTag, 142, "ext_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_jackal_snipers_d1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_a_jackal_snipers_d1(ScenarioTag ScenarioTag) : base(ScenarioTag, 143, "ext_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_watch_brutes1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_a_watch_brutes1(ScenarioTag ScenarioTag) : base(ScenarioTag, 144, "ext_a_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ext_a_watch_elites : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_ext_a_watch_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 145, "ext_a_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_hunters : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_ext_a_hunters(ScenarioTag ScenarioTag) : base(ScenarioTag, 146, "ext_a_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ext_a_brute_door1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_ext_a_brute_door1(ScenarioTag ScenarioTag) : base(ScenarioTag, 147, "ext_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_elite_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_a_elite_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 148, "ext_a_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_brute_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_a_brute_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 149, "ext_a_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ext_a_rangers1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_a_rangers1(ScenarioTag ScenarioTag) : base(ScenarioTag, 150, "ext_a_covenant")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_ext_a_buggers1 : SquadBase
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
            public Squad_ext_a_buggers1(ScenarioTag ScenarioTag) : base(ScenarioTag, 151, "ext_a_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_a_brute_bk_door1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_a_brute_bk_door1(ScenarioTag ScenarioTag) : base(ScenarioTag, 152)
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_ext_a_buggers_bk1 : SquadBase
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
            public Squad_ext_a_buggers_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 153, "ext_a_prophets_bk")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ext_a_brutes_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_a_brutes_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 154, "ext_a_prophets_bk")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad________GARDEN_A_______ : SquadBase
        {
            public Squad________GARDEN_A_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 155)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_a_elites : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_garden_a_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 156, "garden_a_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_a_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_garden_a_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 157, "garden_a_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_brute_lt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_garden_a_brute_lt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 158, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_brute_rt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_garden_a_brute_rt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 159, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_jackal_snipers1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_garden_a_jackal_snipers1(ScenarioTag ScenarioTag) : base(ScenarioTag, 160, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_garden_a_buggers : SquadBase
        {
            public Squad_garden_a_buggers(ScenarioTag ScenarioTag) : base(ScenarioTag, 161, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_brute_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_garden_a_brute_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 162, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_brute_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_garden_a_brute_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 163, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_brute_c1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_garden_a_brute_c1(ScenarioTag ScenarioTag) : base(ScenarioTag, 164, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_elite_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_garden_a_elite_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 165, "garden_a_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_elite_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_garden_a_elite_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 166, "garden_a_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_garden_a_elite_c1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_garden_a_elite_c1(ScenarioTag ScenarioTag) : base(ScenarioTag, 167, "garden_a_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_a_rangers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_garden_a_rangers(ScenarioTag ScenarioTag) : base(ScenarioTag, 168, "garden_a_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_a_elites_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_garden_a_elites_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 169, "garden_a_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_a_grunts_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_garden_a_grunts_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 170, "garden_a_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_a_jackals_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_garden_a_jackals_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 171, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_a_brutes_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_garden_a_brutes_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 172, "garden_a_prophet")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad________MID_TOWER_______ : SquadBase
        {
            public Squad________MID_TOWER_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 173)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_midtower_turrets : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_midtower_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 174, "midtower_covenant")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_midtower_elites1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_midtower_elites1(ScenarioTag ScenarioTag) : base(ScenarioTag, 175, "midtower_covenant")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_midtower_elite_reins : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_midtower_elite_reins(ScenarioTag ScenarioTag) : base(ScenarioTag, 176, "midtower_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_mid_tower_hunters : SquadBase
        {
            public Squad_mid_tower_hunters(ScenarioTag ScenarioTag) : base(ScenarioTag, 177, "midtower_covenant")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_midtower_buggers_ini : SquadBase
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
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[12];
            public IAiActorDefinition starting_locations_13 => Squad.StartingLocations[13];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[14];
            public IAiActorDefinition starting_locations_15 => Squad.StartingLocations[15];
            public Squad_midtower_buggers_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 178, "midtower_prophets")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_midtower_bugger_rein : SquadBase
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
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[12];
            public Squad_midtower_bugger_rein(ScenarioTag ScenarioTag) : base(ScenarioTag, 179, "midtower_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_midtower_brutes1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_midtower_brutes1(ScenarioTag ScenarioTag) : base(ScenarioTag, 180, "midtower_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_midtower_jackals1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_midtower_jackals1(ScenarioTag ScenarioTag) : base(ScenarioTag, 181, "midtower_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_midtower_buggers_hall : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_midtower_buggers_hall(ScenarioTag ScenarioTag) : base(ScenarioTag, 182, "midtower_prophets")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad________GARDEN_B_______ : SquadBase
        {
            public Squad________GARDEN_B_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 183)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_b_grunt_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_garden_b_grunt_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 184, "garden_b_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_b_grunt_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_garden_b_grunt_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 185, "garden_b_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_b_grunt_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_garden_b_grunt_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 186, "garden_b_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_garden_b_brute_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_garden_b_brute_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 187, "garden_b_prophet")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad________EXT_B_______ : SquadBase
        {
            public Squad________EXT_B_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 188)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_ext_b_brute_ramp1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_ext_b_brute_ramp1(ScenarioTag ScenarioTag) : base(ScenarioTag, 189)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_b_elite_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_b_elite_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 190, "ext_b_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_b_brute_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_b_brute_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 191, "ext_b_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ext_b_grunts_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_ext_b_grunts_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 192, "ext_b_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_b_brutes_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_b_brutes_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 193, "ext_b_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ext_b_grunts_low1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_ext_b_grunts_low1(ScenarioTag ScenarioTag) : base(ScenarioTag, 194, "ext_b_covenant_low")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_b_brutes_low1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_b_brutes_low1(ScenarioTag ScenarioTag) : base(ScenarioTag, 195, "ext_b_prophets_low")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_b_jackal_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_b_jackal_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 196, "ext_b_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_b_grunt_bk_door1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ext_b_grunt_bk_door1(ScenarioTag ScenarioTag) : base(ScenarioTag, 197, "ext_b_covenant")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_ext_b_elites_bk_door1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_ext_b_elites_bk_door1(ScenarioTag ScenarioTag) : base(ScenarioTag, 198, "ext_b_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ext_b_elites_stealth : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_b_elites_stealth(ScenarioTag ScenarioTag) : base(ScenarioTag, 199, "ext_b_covenant")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_ext_b_grunts_lt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_ext_b_grunts_lt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 200, "ext_b_covenant")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_ext_b_brutes_low_door1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_ext_b_brutes_low_door1(ScenarioTag ScenarioTag) : base(ScenarioTag, 201, "ext_b_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_b_jackal_b : SquadBase
        {
            public Squad_ext_b_jackal_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 202, "ext_b_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ext_b_jackal_c : SquadBase
        {
            public Squad_ext_b_jackal_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 203, "ext_b_prophets")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_ext_b_cov_dump1 : SquadBase
        {
            public Squad_ext_b_cov_dump1(ScenarioTag ScenarioTag) : base(ScenarioTag, 204, "ext_b_covenant")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_ext_b_prophet_dump1 : SquadBase
        {
            public Squad_ext_b_prophet_dump1(ScenarioTag ScenarioTag) : base(ScenarioTag, 205, "ext_b_prophets")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad________MAUSOLEUM_______ : SquadBase
        {
            public Squad________MAUSOLEUM_______(ScenarioTag ScenarioTag) : base(ScenarioTag, 206)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_hall_elites_stealth1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_hall_elites_stealth1(ScenarioTag ScenarioTag) : base(ScenarioTag, 207, "maus_hall_covenant")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_maus_hall_grunts1 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[5];
            public Squad_maus_hall_grunts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 208, "maus_hall_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_room_elite_lt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_maus_room_elite_lt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 209, "maus_room_cov_ini")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_room_elite_rt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_maus_room_elite_rt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 210, "maus_room_cov_ini")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_room_grunt_lt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_maus_room_grunt_lt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 211, "maus_room_cov_ini")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_room_grunt_rt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_maus_room_grunt_rt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 212, "maus_room_cov_ini")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_room_brute_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_maus_room_brute_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 213, "maus_room_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_room_jackal_bk_lt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_room_jackal_bk_lt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 214, "maus_room_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_room_jackal_bk_rt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_room_jackal_bk_rt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 215, "maus_room_prophet")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_room_lt_elite_reins : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_maus_room_lt_elite_reins(ScenarioTag ScenarioTag) : base(ScenarioTag, 216, "maus_room_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_room_rt_elite_reins : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_maus_room_rt_elite_reins(ScenarioTag ScenarioTag) : base(ScenarioTag, 217, "maus_room_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_room_lt_grunt_reins : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_maus_room_lt_grunt_reins(ScenarioTag ScenarioTag) : base(ScenarioTag, 218, "maus_room_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_room_rt_grunt_reins : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_maus_room_rt_grunt_reins(ScenarioTag ScenarioTag) : base(ScenarioTag, 219, "maus_room_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_bridge_elite_turret : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_maus_bridge_elite_turret(ScenarioTag ScenarioTag) : base(ScenarioTag, 220, "maus_bridge_covenant")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_maus_bridge_elites_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_maus_bridge_elites_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 221, "maus_bridge_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_bridge_elite_rein : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_maus_bridge_elite_rein(ScenarioTag ScenarioTag) : base(ScenarioTag, 222, "maus_bridge_covenant")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_maus_bridge_grunt_rein : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_maus_bridge_grunt_rein(ScenarioTag ScenarioTag) : base(ScenarioTag, 223, "maus_bridge_covenant")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_maus_bridge_grunt_rein_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_maus_bridge_grunt_rein_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 224, "maus_bridge_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_bridge_hunters1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_bridge_hunters1(ScenarioTag ScenarioTag) : base(ScenarioTag, 225, "maus_bridge_covenant")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_maus_bridge_buggers_ini1 : SquadBase
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
            public Squad_maus_bridge_buggers_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 226, "maus_bridge_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_bridge_brutes_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_maus_bridge_brutes_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 227, "maus_bridge_prophets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_bridge_jackals_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_bridge_jackals_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 228, "maus_bridge_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_hunters_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_hunters_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 229, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_maus_inner_elites_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_maus_inner_elites_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 230, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_maus_inner_grunts_ini : SquadBase
        {
            public Squad_maus_inner_grunts_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 231, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_inner_turrets : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_maus_inner_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 232, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_maus_inner_brutes_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_maus_inner_brutes_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 233, "maus_inner_prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_maus_inner_brutes_rein : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_maus_inner_brutes_rein(ScenarioTag ScenarioTag) : base(ScenarioTag, 234, "maus_inner_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_buggers_lt : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_41 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_maus_inner_buggers_lt(ScenarioTag ScenarioTag) : base(ScenarioTag, 235, "maus_inner_buggers")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_buggers_rt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_maus_inner_buggers_rt(ScenarioTag ScenarioTag) : base(ScenarioTag, 236, "maus_inner_buggers")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_brutes_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_brutes_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 237, "maus_inner_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_brutes_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_brutes_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 238, "maus_inner_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_brutes_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_brutes_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 239, "maus_inner_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_brutes_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_brutes_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 240, "maus_inner_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_brutes_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_brutes_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 241, "maus_inner_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_brutes_f : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_brutes_f(ScenarioTag ScenarioTag) : base(ScenarioTag, 242, "maus_inner_prophets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_elites_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_elites_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 243, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_inner_elites_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_elites_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 244, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_elites_f : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_elites_f(ScenarioTag ScenarioTag) : base(ScenarioTag, 245, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(0, 2)]
        public class Squad_maus_inner_elites_ultra : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_maus_inner_elites_ultra(ScenarioTag ScenarioTag) : base(ScenarioTag, 246, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_maus_inner_elites_spec : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_maus_inner_elites_spec(ScenarioTag ScenarioTag) : base(ScenarioTag, 247, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_maus_inner_elite_zealot : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_maus_inner_elite_zealot(ScenarioTag ScenarioTag) : base(ScenarioTag, 248, "maus_inner_covenant")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_244 : SquadBase
        {
            public Squad_squads_244(ScenarioTag ScenarioTag) : base(ScenarioTag, 249)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ice_cream_grunt1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ice_cream_grunt1(ScenarioTag ScenarioTag) : base(ScenarioTag, 250)
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_c07_infection : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_c07_infection(ScenarioTag ScenarioTag) : base(ScenarioTag, 251)
            {
            }
        }
    }
}