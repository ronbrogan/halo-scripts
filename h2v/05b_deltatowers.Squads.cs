namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_05b_deltatowers : ScenarioScriptBase
    {
        public Squad_initial_allies initial_allies { get; set; }
        public Squad_tower1_elites_01 tower1_elites_01 { get; set; }
        public Squad_tower1_elites_02 tower1_elites_02 { get; set; }
        public Squad_tower1_buggers_01 tower1_buggers_01 { get; set; }
        public Squad_tower1_buggers_02 tower1_buggers_02 { get; set; }
        public Squad_bridge_elites_01 bridge_elites_01 { get; set; }
        public Squad_bridge_elites_02 bridge_elites_02 { get; set; }
        public Squad_bridge_elites_03 bridge_elites_03 { get; set; }
        public Squad_bridge_elites_04 bridge_elites_04 { get; set; }
        public Squad_bridge_grunts_01 bridge_grunts_01 { get; set; }
        public Squad_bridge_grunts_02 bridge_grunts_02 { get; set; }
        public Squad_bridge_grunts_03 bridge_grunts_03 { get; set; }
        public Squad_bridge_grunts_04 bridge_grunts_04 { get; set; }
        public Squad_bridge_jackals_01 bridge_jackals_01 { get; set; }
        public Squad_bridge_jackals_02 bridge_jackals_02 { get; set; }
        public Squad_bridge_jackals_03 bridge_jackals_03 { get; set; }
        public Squad_bridge_jackals_04 bridge_jackals_04 { get; set; }
        public Squad_bridge_jackals_05 bridge_jackals_05 { get; set; }
        public Squad_bridge_jackals_06 bridge_jackals_06 { get; set; }
        public Squad_bridge_jackals_07 bridge_jackals_07 { get; set; }
        public Squad_tower2_jackals_01 tower2_jackals_01 { get; set; }
        public Squad_tower2_jackals_02 tower2_jackals_02 { get; set; }
        public Squad_tower2_grunts_01 tower2_grunts_01 { get; set; }
        public Squad_tower2_grunts_02 tower2_grunts_02 { get; set; }
        public Squad_central_platform_hunters central_platform_hunters { get; set; }
        public Squad_central_platform_phantom central_platform_phantom { get; set; }
        public Squad_central_platform_elites_01 central_platform_elites_01 { get; set; }
        public Squad_central_platform_elites_02 central_platform_elites_02 { get; set; }
        public Squad_central_platform_jackals_01 central_platform_jackals_01 { get; set; }
        public Squad_central_platform_jackals_02 central_platform_jackals_02 { get; set; }
        public Squad_central_plat_pelican central_plat_pelican { get; set; }
        public Squad_central_plat_pelican_allies central_plat_pelican_allies { get; set; }
        public Squad_gondola_01_elite_riders gondola_01_elite_riders { get; set; }
        public Squad_gondola_01_grunt_riders gondola_01_grunt_riders { get; set; }
        public Squad_gondola_01_jackal_riders gondola_01_jackal_riders { get; set; }
        public Squad_gondola_01_buggers gondola_01_buggers { get; set; }
        public Squad_gondola_01_phantom gondola_01_phantom { get; set; }
        public Squad_gondola_01_elite_boarders gondola_01_elite_boarders { get; set; }
        public Squad_gondola_01_grunt_boarders_01 gondola_01_grunt_boarders_01 { get; set; }
        public Squad_gondola_01_grunt_boarders_02 gondola_01_grunt_boarders_02 { get; set; }
        public Squad_gondola_01_b_buggers gondola_01_b_buggers { get; set; }
        public Squad_gondola_01_b_elites gondola_01_b_elites { get; set; }
        public Squad_tower3_sleeper tower3_sleeper { get; set; }
        public Squad_tower3_turrets tower3_turrets { get; set; }
        public Squad_tower3_dock_snipers tower3_dock_snipers { get; set; }
        public Squad_tower3_dock_jackals tower3_dock_jackals { get; set; }
        public Squad_tower3_dock_grunts tower3_dock_grunts { get; set; }
        public Squad_tower3_jackals_01 tower3_jackals_01 { get; set; }
        public Squad_tower3_jackals_02 tower3_jackals_02 { get; set; }
        public Squad_tower3_buggers_01 tower3_buggers_01 { get; set; }
        public Squad_tower3_buggers_02 tower3_buggers_02 { get; set; }
        public Squad_tower3_jackals_elev tower3_jackals_elev { get; set; }
        public Squad_tower3_pelican tower3_pelican { get; set; }
        public Squad_tower3_pelican_allies tower3_pelican_allies { get; set; }
        public Squad_tunnel_01_grunts_patrol tunnel_01_grunts_patrol { get; set; }
        public Squad_tunnel_01_grunts_01 tunnel_01_grunts_01 { get; set; }
        public Squad_tunnel_01_grunts_02 tunnel_01_grunts_02 { get; set; }
        public Squad_tunnel_01_grunts_03 tunnel_01_grunts_03 { get; set; }
        public Squad_sunk_chamber_bugs_R_011 sunk_chamber_bugs_R_011 { get; set; }
        public Squad_sunk_chamber_bugs_R_021 sunk_chamber_bugs_R_021 { get; set; }
        public Squad_sunk_chamber_bugs_L_011 sunk_chamber_bugs_L_011 { get; set; }
        public Squad_sunk_chamber_bugs_L_021 sunk_chamber_bugs_L_021 { get; set; }
        public Squad_sunk_chamber_hunters sunk_chamber_hunters { get; set; }
        public Squad_sunk_chamber_init_hg_Ra sunk_chamber_init_hg_Ra { get; set; }
        public Squad_sunk_chamber_init_hg_Rb sunk_chamber_init_hg_Rb { get; set; }
        public Squad_sunk_chamber_init_hg_La sunk_chamber_init_hg_La { get; set; }
        public Squad_sunk_chamber_init_hg_Lb sunk_chamber_init_hg_Lb { get; set; }
        public Squad_sunk_chamber_init_js_R01 sunk_chamber_init_js_R01 { get; set; }
        public Squad_sunk_chamber_init_js_R02 sunk_chamber_init_js_R02 { get; set; }
        public Squad_sunk_chamber_init_js_R03 sunk_chamber_init_js_R03 { get; set; }
        public Squad_sunk_chamber_init_js_R04 sunk_chamber_init_js_R04 { get; set; }
        public Squad_sunk_chamber_init_js_L01 sunk_chamber_init_js_L01 { get; set; }
        public Squad_sunk_chamber_init_js_L02 sunk_chamber_init_js_L02 { get; set; }
        public Squad_sunk_chamber_init_js_L03 sunk_chamber_init_js_L03 { get; set; }
        public Squad_sunk_chamber_init_js_L04 sunk_chamber_init_js_L04 { get; set; }
        public Squad_sunk_chamber_hg_R_01 sunk_chamber_hg_R_01 { get; set; }
        public Squad_sunk_chamber_hg_R_02 sunk_chamber_hg_R_02 { get; set; }
        public Squad_sunk_chamber_hg_L_01 sunk_chamber_hg_L_01 { get; set; }
        public Squad_sunk_chamber_hg_L_02 sunk_chamber_hg_L_02 { get; set; }
        public Squad_sunk_chamber_js_L_01 sunk_chamber_js_L_01 { get; set; }
        public Squad_sunk_chamber_js_L_02 sunk_chamber_js_L_02 { get; set; }
        public Squad_sunk_chamber_js_R_01 sunk_chamber_js_R_01 { get; set; }
        public Squad_sunk_chamber_js_R_02 sunk_chamber_js_R_02 { get; set; }
        public Squad_sunk_chamber_jack_R_01 sunk_chamber_jack_R_01 { get; set; }
        public Squad_sunk_chamber_jack_R_02 sunk_chamber_jack_R_02 { get; set; }
        public Squad_sunk_chamber_jack_L_01 sunk_chamber_jack_L_01 { get; set; }
        public Squad_sunk_chamber_jack_L_02 sunk_chamber_jack_L_02 { get; set; }
        public Squad_sunk_chamber_exit_e_R sunk_chamber_exit_e_R { get; set; }
        public Squad_sunk_chamber_exit_e_L sunk_chamber_exit_e_L { get; set; }
        public Squad_sunk_chamber_exit_j01_R sunk_chamber_exit_j01_R { get; set; }
        public Squad_sunk_chamber_exit_j01_L sunk_chamber_exit_j01_L { get; set; }
        public Squad_sunk_chamber_exit_j02_L sunk_chamber_exit_j02_L { get; set; }
        public Squad_sunk_chamber_exit_j02_R sunk_chamber_exit_j02_R { get; set; }
        public Squad_tunnel_02_elites_01 tunnel_02_elites_01 { get; set; }
        public Squad_tunnel_02_elites_02 tunnel_02_elites_02 { get; set; }
        public Squad_tunnel_02_elites_03 tunnel_02_elites_03 { get; set; }
        public Squad_tunnel_02_elites_04 tunnel_02_elites_04 { get; set; }
        public Squad_tunnel_02_grunts tunnel_02_grunts { get; set; }
        public Squad_tunnel_02_buggers_01 tunnel_02_buggers_01 { get; set; }
        public Squad_tunnel_02_buggers_02 tunnel_02_buggers_02 { get; set; }
        public Squad_island_int_hg island_int_hg { get; set; }
        public Squad_island_int_grunts island_int_grunts { get; set; }
        public Squad_island_gully_buggers_01 island_gully_buggers_01 { get; set; }
        public Squad_island_gully_elites_01 island_gully_elites_01 { get; set; }
        public Squad_island_gully_elites_02 island_gully_elites_02 { get; set; }
        public Squad_island_gully_jackals_01 island_gully_jackals_01 { get; set; }
        public Squad_island_pelican island_pelican { get; set; }
        public Squad_island_pelican_allies island_pelican_allies { get; set; }
        public Squad_island_ext_js_01 island_ext_js_01 { get; set; }
        public Squad_island_ext_js_02 island_ext_js_02 { get; set; }
        public Squad_island_ext_js_03 island_ext_js_03 { get; set; }
        public Squad_island_ext_js_04 island_ext_js_04 { get; set; }
        public Squad_island_ext_grunts_01 island_ext_grunts_01 { get; set; }
        public Squad_island_ext_elites_01 island_ext_elites_01 { get; set; }
        public Squad_island_ext_grunts_02 island_ext_grunts_02 { get; set; }
        public Squad_island_ext_elites_02 island_ext_elites_02 { get; set; }
        public Squad_island_phantom island_phantom { get; set; }
        public Squad_island_phantom_grunts island_phantom_grunts { get; set; }
        public Squad_island_phantom_jackals island_phantom_jackals { get; set; }
        public Squad_island_phantom_elites island_phantom_elites { get; set; }
        public Squad_near_gondola_02_grunts near_gondola_02_grunts { get; set; }
        public Squad_near_gondola_02_jackals near_gondola_02_jackals { get; set; }
        public Squad_gondola_02_jetpacks gondola_02_jetpacks { get; set; }
        public Squad_gondola_02_grunts gondola_02_grunts { get; set; }
        public Squad_gondola_02_banshees1 gondola_02_banshees1 { get; set; }
        public Squad_temple_ent_turrets temple_ent_turrets { get; set; }
        public Squad_temple_ent_grunts temple_ent_grunts { get; set; }
        public Squad_temple_ent_jackals temple_ent_jackals { get; set; }
        public Squad_temple_halls_jackals_01 temple_halls_jackals_01 { get; set; }
        public Squad_temple_halls_jackals_02L temple_halls_jackals_02L { get; set; }
        public Squad_temple_halls_jackals_02R temple_halls_jackals_02R { get; set; }
        public Squad_temple_halls_elites_01 temple_halls_elites_01 { get; set; }
        public Squad_temple_halls_elites_02 temple_halls_elites_02 { get; set; }
        public Squad_temple_hg_01L temple_hg_01L { get; set; }
        public Squad_temple_hg_01R temple_hg_01R { get; set; }
        public Squad_temple_hg_02L temple_hg_02L { get; set; }
        public Squad_temple_hg_02R temple_hg_02R { get; set; }
        public Squad_regret1 regret1 { get; set; }
        public Squad_temple_exit_elites_01 temple_exit_elites_01 { get; set; }
        public Squad_temple_exit_grunts_01 temple_exit_grunts_01 { get; set; }
        public Squad_temple_exit_jackals_02 temple_exit_jackals_02 { get; set; }
        public Squad_temple_exit_elites_02 temple_exit_elites_02 { get; set; }
        public Squad_temple_exit_jackals_03 temple_exit_jackals_03 { get; set; }
        public Squad_temple_exit_elites_04 temple_exit_elites_04 { get; set; }
        public Squad_temple_exit_hg_041 temple_exit_hg_041 { get; set; }
        public Squad_ranger ranger { get; set; }
        public Squad_run run { get; set; }
        public Squad_temp_bsp2_allies temp_bsp2_allies { get; set; }
        public Squad_temp_bsp3_allies temp_bsp3_allies { get; set; }
        public Squad_temple_hg_init temple_hg_init { get; set; }
        public Squad_gondola_01_bugs_new gondola_01_bugs_new { get; set; }
        public Squad_temple_heavies temple_heavies { get; set; }
        public Squad_assassin_elites assassin_elites { get; set; }
        public Squad_honor_grunts_init_R honor_grunts_init_R { get; set; }
        public Squad_honor_grunts_init_L honor_grunts_init_L { get; set; }
        public Squad_honor_grunts_new_L honor_grunts_new_L { get; set; }
        public Squad_honor_grunts_new_R honor_grunts_new_R { get; set; }
        [SpawnCounts(8, 8)]
        public class Squad_initial_allies : SquadBase
        {
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_91 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_92 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_93 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_101 => Squad.StartingLocations[7];
            public Squad_initial_allies(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "allies_infantry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tower1_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_tower1_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tower1_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_tower1_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_tower1_buggers_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_tower1_buggers_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_tower1_buggers_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_tower1_buggers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_bridge_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_bridge_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_elites_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_bridge_elites_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_elites_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_elites_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_grunts_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_grunts_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_jackals_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_jackals_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_jackals_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_jackals_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_jackals_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_jackals_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_jackals_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_jackals_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_jackals_06 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_jackals_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_jackals_07 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bridge_jackals_07(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "bridge_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tower2_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_tower2_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "tower2_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tower2_jackals_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_tower2_jackals_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "tower2_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tower2_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_tower2_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "tower2_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_tower2_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_tower2_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "tower2_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_central_platform_hunters : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_central_platform_hunters(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_central_platform_phantom : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_central_platform_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_central_platform_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_central_platform_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "central_platform_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_central_platform_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_central_platform_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "central_platform_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_central_platform_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_central_platform_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "central_platform_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_central_platform_jackals_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_central_platform_jackals_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "central_platform_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_central_plat_pelican : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_central_plat_pelican(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "all_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_central_plat_pelican_allies : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[7];
            public Squad_central_plat_pelican_allies(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "allies_infantry")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_gondola_01_elite_riders : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_gondola_01_elite_riders(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_gondola_01_grunt_riders : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_gondola_01_grunt_riders(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_gondola_01_jackal_riders : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_41 => Squad.StartingLocations[3];
            public Squad_gondola_01_jackal_riders(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_gondola_01_buggers : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public Squad_gondola_01_buggers(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gondola_01_phantom : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_gondola_01_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_gondola_01_elite_boarders : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_gondola_01_elite_boarders(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_gondola_01_grunt_boarders_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_gondola_01_grunt_boarders_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_gondola_01_grunt_boarders_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_gondola_01_grunt_boarders_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_gondola_01_b_buggers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_gondola_01_b_buggers(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_gondola_01_b_elites : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_gondola_01_b_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "gondola_01_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tower3_sleeper : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_tower3_sleeper(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tower3_turrets : SquadBase
        {
            public IAiActorDefinition right => Squad.StartingLocations[0];
            public IAiActorDefinition left => Squad.StartingLocations[1];
            public Squad_tower3_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "tower3_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tower3_dock_snipers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_tower3_dock_snipers(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "tower3_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tower3_dock_jackals : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_tower3_dock_jackals(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "tower3_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_tower3_dock_grunts : SquadBase
        {
            public IAiActorDefinition _2 => Squad.StartingLocations[0];
            public IAiActorDefinition _1 => Squad.StartingLocations[1];
            public Squad_tower3_dock_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "tower3_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_tower3_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_tower3_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "tower3_main")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_tower3_jackals_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_tower3_jackals_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "tower3_main")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tower3_buggers_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_tower3_buggers_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "tower3_main")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tower3_buggers_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_tower3_buggers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "tower3_main")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_tower3_jackals_elev : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_tower3_jackals_elev(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "tower3_main")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tower3_pelican : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_tower3_pelican(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "all_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tower3_pelican_allies : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_tower3_pelican_allies(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "allies_infantry")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tunnel_01_grunts_patrol : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_tunnel_01_grunts_patrol(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "tunnel_01_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tunnel_01_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_tunnel_01_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "tunnel_01_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tunnel_01_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_tunnel_01_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "tunnel_01_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tunnel_01_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_tunnel_01_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "tunnel_01_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_sunk_chamber_bugs_R_011 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_bugs_R_011(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "sunken_bugs")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_sunk_chamber_bugs_R_021 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_bugs_R_021(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "sunken_bugs")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_sunk_chamber_bugs_L_011 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_bugs_L_011(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "sunken_bugs")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_sunk_chamber_bugs_L_021 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_bugs_L_021(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "sunken_bugs")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_hunters : SquadBase
        {
            public IAiActorDefinition _2 => Squad.StartingLocations[0];
            public IAiActorDefinition _1 => Squad.StartingLocations[1];
            public Squad_sunk_chamber_hunters(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "sunken_chamber_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_hg_Ra : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_init_hg_Ra(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "sunken_hg_right")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_hg_Rb : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_sunk_chamber_init_hg_Rb(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "sunken_hg_right")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_hg_La : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_init_hg_La(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "sunken_hg_left")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_hg_Lb : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_sunk_chamber_init_hg_Lb(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "sunken_hg_left")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_js_R01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_init_js_R01(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "sunken_rightside_snipers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_js_R02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_init_js_R02(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "sunken_rightside_snipers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_js_R03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_sunk_chamber_init_js_R03(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "sunken_rightside_snipers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_js_R04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_sunk_chamber_init_js_R04(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "sunken_rightside_snipers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_js_L01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_init_js_L01(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "sunken_leftside_snipers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_js_L02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_init_js_L02(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "sunken_leftside_snipers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_js_L03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_sunk_chamber_init_js_L03(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "sunken_leftside_snipers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_sunk_chamber_init_js_L04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_sunk_chamber_init_js_L04(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "sunken_leftside_snipers")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_hg_R_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_sunk_chamber_hg_R_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "sunken_hg_right")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_hg_R_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_sunk_chamber_hg_R_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "sunken_hg_right")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_hg_L_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_sunk_chamber_hg_L_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "sunken_hg_left")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_hg_L_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_sunk_chamber_hg_L_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "sunken_hg_left")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_sunk_chamber_js_L_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_js_L_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "sunken_leftside_snipers")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_sunk_chamber_js_L_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_js_L_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "sunken_leftside_snipers")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_sunk_chamber_js_R_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_js_R_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "sunken_rightside_snipers")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_sunk_chamber_js_R_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_sunk_chamber_js_R_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "sunken_rightside_snipers")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_sunk_chamber_jack_R_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_sunk_chamber_jack_R_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "sunken_jacks_right")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_sunk_chamber_jack_R_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_sunk_chamber_jack_R_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "sunken_jacks_right")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_sunk_chamber_jack_L_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_sunk_chamber_jack_L_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "sunken_jacks_left")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_sunk_chamber_jack_L_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_sunk_chamber_jack_L_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "sunken_jacks_left")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_exit_e_R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_sunk_chamber_exit_e_R(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "sunken_chamber_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_exit_e_L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_sunk_chamber_exit_e_L(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "sunken_chamber_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_exit_j01_R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_sunk_chamber_exit_j01_R(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "sunken_chamber_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_exit_j01_L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_sunk_chamber_exit_j01_L(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "sunken_chamber_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_exit_j02_L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_sunk_chamber_exit_j02_L(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "sunken_chamber_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_sunk_chamber_exit_j02_R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_sunk_chamber_exit_j02_R(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "sunken_chamber_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tunnel_02_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_tunnel_02_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "tunnel_02_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tunnel_02_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_tunnel_02_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 94, "tunnel_02_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tunnel_02_elites_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_tunnel_02_elites_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "tunnel_02_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tunnel_02_elites_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_tunnel_02_elites_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "tunnel_02_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tunnel_02_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_tunnel_02_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "tunnel_02_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tunnel_02_buggers_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_tunnel_02_buggers_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "tunnel_02_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_tunnel_02_buggers_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_tunnel_02_buggers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "tunnel_02_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_island_int_hg : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_island_int_hg(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "island_int_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_island_int_grunts : SquadBase
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
            public Squad_island_int_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 101, "island_int_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_island_gully_buggers_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_island_gully_buggers_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 102, "island_gully_enemies")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_island_gully_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_island_gully_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 103, "island_gully_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_island_gully_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_island_gully_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "island_gully_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_island_gully_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_island_gully_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 105, "island_gully_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_island_pelican : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_island_pelican(ScenarioTag ScenarioTag) : base(ScenarioTag, 106, "all_allies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_island_pelican_allies : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[7];
            public Squad_island_pelican_allies(ScenarioTag ScenarioTag) : base(ScenarioTag, 107, "allies_infantry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_island_ext_js_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_island_ext_js_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 108, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_island_ext_js_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_island_ext_js_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 109, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_island_ext_js_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_island_ext_js_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 110, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_island_ext_js_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_island_ext_js_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 111, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_island_ext_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_island_ext_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 112, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_island_ext_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_island_ext_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 113, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_island_ext_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_island_ext_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 114, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_island_ext_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_island_ext_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 115, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_island_phantom : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_island_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 116, "all_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_island_phantom_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_island_phantom_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 117, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_island_phantom_jackals : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_island_phantom_jackals(ScenarioTag ScenarioTag) : base(ScenarioTag, 118, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_island_phantom_elites : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_island_phantom_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 119, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_near_gondola_02_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_near_gondola_02_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 120, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_near_gondola_02_jackals : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_near_gondola_02_jackals(ScenarioTag ScenarioTag) : base(ScenarioTag, 121, "island_main_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_gondola_02_jetpacks : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_gondola_02_jetpacks(ScenarioTag ScenarioTag) : base(ScenarioTag, 122, "gondola_02_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_gondola_02_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_gondola_02_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 123, "gondola_02_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_gondola_02_banshees1 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_gondola_02_banshees1(ScenarioTag ScenarioTag) : base(ScenarioTag, 124, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_turrets : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_temple_ent_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 125, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_temple_ent_grunts : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public Squad_temple_ent_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 126, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_temple_ent_jackals : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_temple_ent_jackals(ScenarioTag ScenarioTag) : base(ScenarioTag, 127, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_temple_halls_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_temple_halls_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 128, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_temple_halls_jackals_02L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_temple_halls_jackals_02L(ScenarioTag ScenarioTag) : base(ScenarioTag, 129, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_temple_halls_jackals_02R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_temple_halls_jackals_02R(ScenarioTag ScenarioTag) : base(ScenarioTag, 130, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_temple_halls_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_halls_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 131, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_halls_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_halls_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 132, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_hg_01L : SquadBase
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
            public Squad_temple_hg_01L(ScenarioTag ScenarioTag) : base(ScenarioTag, 133, "temple_hg")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_hg_01R : SquadBase
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
            public Squad_temple_hg_01R(ScenarioTag ScenarioTag) : base(ScenarioTag, 134, "temple_hg")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_hg_02L : SquadBase
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
            public Squad_temple_hg_02L(ScenarioTag ScenarioTag) : base(ScenarioTag, 135, "temple_hg")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_hg_02R : SquadBase
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
            public Squad_temple_hg_02R(ScenarioTag ScenarioTag) : base(ScenarioTag, 136, "temple_hg")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_regret1 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public IAiActorDefinition _5 => Squad.StartingLocations[4];
            public IAiActorDefinition _6 => Squad.StartingLocations[5];
            public IAiActorDefinition _7 => Squad.StartingLocations[6];
            public IAiActorDefinition _8 => Squad.StartingLocations[7];
            public IAiActorDefinition _9 => Squad.StartingLocations[8];
            public IAiActorDefinition _10 => Squad.StartingLocations[9];
            public IAiActorDefinition _11 => Squad.StartingLocations[10];
            public IAiActorDefinition _12 => Squad.StartingLocations[11];
            public IAiActorDefinition _13 => Squad.StartingLocations[12];
            public IAiActorDefinition _14 => Squad.StartingLocations[13];
            public IAiActorDefinition _15 => Squad.StartingLocations[14];
            public IAiActorDefinition _16 => Squad.StartingLocations[15];
            public IAiActorDefinition _17 => Squad.StartingLocations[16];
            public IAiActorDefinition _18 => Squad.StartingLocations[17];
            public IAiActorDefinition _19 => Squad.StartingLocations[18];
            public IAiActorDefinition _20 => Squad.StartingLocations[19];
            public IAiActorDefinition _21 => Squad.StartingLocations[20];
            public Squad_regret1(ScenarioTag ScenarioTag) : base(ScenarioTag, 137, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_exit_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_exit_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 138, "temple_escape_enemies")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_temple_exit_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_temple_exit_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 139, "temple_escape_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_temple_exit_jackals_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_temple_exit_jackals_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 140, "temple_escape_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_temple_exit_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_temple_exit_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 141, "temple_escape_enemies")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_temple_exit_jackals_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_temple_exit_jackals_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 142, "temple_escape_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_exit_elites_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_exit_elites_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 143, "temple_escape_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_exit_hg_041 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_exit_hg_041(ScenarioTag ScenarioTag) : base(ScenarioTag, 144, "temple_escape_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_ranger : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_ranger(ScenarioTag ScenarioTag) : base(ScenarioTag, 145, "temple_rangers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_run : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_run(ScenarioTag ScenarioTag) : base(ScenarioTag, 146, "all_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temp_bsp2_allies : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temp_bsp2_allies(ScenarioTag ScenarioTag) : base(ScenarioTag, 147, "all_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temp_bsp3_allies : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temp_bsp3_allies(ScenarioTag ScenarioTag) : base(ScenarioTag, 148, "all_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_hg_init : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_temple_hg_init(ScenarioTag ScenarioTag) : base(ScenarioTag, 149, "temple_hg")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_gondola_01_bugs_new : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_gondola_01_bugs_new(ScenarioTag ScenarioTag) : base(ScenarioTag, 150)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_heavies : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_temple_heavies(ScenarioTag ScenarioTag) : base(ScenarioTag, 151, "temple_entry_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_assassin_elites : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_assassin_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 152)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_honor_grunts_init_R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_honor_grunts_init_R(ScenarioTag ScenarioTag) : base(ScenarioTag, 153, "temple_honor_grunts")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_honor_grunts_init_L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_honor_grunts_init_L(ScenarioTag ScenarioTag) : base(ScenarioTag, 154, "temple_honor_grunts")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_honor_grunts_new_L : SquadBase
        {
            public IAiActorDefinition _02 => Squad.StartingLocations[0];
            public IAiActorDefinition _01 => Squad.StartingLocations[1];
            public IAiActorDefinition _03 => Squad.StartingLocations[2];
            public IAiActorDefinition _04 => Squad.StartingLocations[3];
            public IAiActorDefinition _05 => Squad.StartingLocations[4];
            public Squad_honor_grunts_new_L(ScenarioTag ScenarioTag) : base(ScenarioTag, 155, "temple_honor_grunts")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_honor_grunts_new_R : SquadBase
        {
            public IAiActorDefinition _05 => Squad.StartingLocations[0];
            public IAiActorDefinition _04 => Squad.StartingLocations[1];
            public IAiActorDefinition _03 => Squad.StartingLocations[2];
            public IAiActorDefinition _01 => Squad.StartingLocations[3];
            public IAiActorDefinition _02 => Squad.StartingLocations[4];
            public Squad_honor_grunts_new_R(ScenarioTag ScenarioTag) : base(ScenarioTag, 156, "temple_honor_grunts")
            {
            }
        }
    }
}