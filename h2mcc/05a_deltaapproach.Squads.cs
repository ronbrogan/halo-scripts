namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_05a_deltaapproach : ScenarioScriptBase
    {
        public Squad_allies_lz_ledge allies_lz_ledge { get; set; }
        public Squad_allies_lz_ridge allies_lz_ridge { get; set; }
        public Squad_LZ_turrets_01 LZ_turrets_01 { get; set; }
        public Squad_LZ_turrets_02 LZ_turrets_02 { get; set; }
        public Squad_LZ_turrets_03 LZ_turrets_03 { get; set; }
        public Squad_LZ_turrets_04 LZ_turrets_04 { get; set; }
        public Squad_LZ_elites_ledge LZ_elites_ledge { get; set; }
        public Squad_LZ_grunts_ledge LZ_grunts_ledge { get; set; }
        public Squad_LZ_elites_ridge LZ_elites_ridge { get; set; }
        public Squad_LZ_grunts_ridge LZ_grunts_ridge { get; set; }
        public Squad_LZ_jackals_ridge LZ_jackals_ridge { get; set; }
        public Squad_LZ_elites_yard LZ_elites_yard { get; set; }
        public Squad_LZ_grunts_yard LZ_grunts_yard { get; set; }
        public Squad_LZ_jackals_yard LZ_jackals_yard { get; set; }
        public Squad_LZ_elites_structure LZ_elites_structure { get; set; }
        public Squad_LZ_grunts_structure LZ_grunts_structure { get; set; }
        public Squad_LZ_jackals_structure LZ_jackals_structure { get; set; }
        public Squad_LZ_elites_bunkered LZ_elites_bunkered { get; set; }
        public Squad_LZ_grunts_bunkered LZ_grunts_bunkered { get; set; }
        public Squad_LZ_phantom_01 LZ_phantom_01 { get; set; }
        public Squad_LZ_elites_phantom_01 LZ_elites_phantom_01 { get; set; }
        public Squad_LZ_grunts_phantom_01 LZ_grunts_phantom_01 { get; set; }
        public Squad_LZ_jackals_phantom_01 LZ_jackals_phantom_01 { get; set; }
        public Squad_LZ_phantom_02 LZ_phantom_02 { get; set; }
        public Squad_LZ_elites_phantom_02 LZ_elites_phantom_02 { get; set; }
        public Squad_LZ_grunts_phantom_02 LZ_grunts_phantom_02 { get; set; }
        public Squad_LZ_jackals_phantom_02 LZ_jackals_phantom_02 { get; set; }
        public Squad_LZ_stealth_phantom_03 LZ_stealth_phantom_03 { get; set; }
        public Squad_LZ_pelican_01 LZ_pelican_01 { get; set; }
        public Squad_LZ_pelican_02 LZ_pelican_02 { get; set; }
        public Squad_LZ_warthog_01 LZ_warthog_01 { get; set; }
        public Squad_allies_lz_pelican allies_lz_pelican { get; set; }
        public Squad_overlook_jackals_011 overlook_jackals_011 { get; set; }
        public Squad_overlook_jackals_021 overlook_jackals_021 { get; set; }
        public Squad_bridge_free_ghost bridge_free_ghost { get; set; }
        public Squad_bridge_farside_wraiths bridge_farside_wraiths { get; set; }
        public Squad_bridge_bunker_turrets1 bridge_bunker_turrets1 { get; set; }
        public Squad_bridge_bunker_ghosts bridge_bunker_ghosts { get; set; }
        public Squad_bridge_ghost_elites bridge_ghost_elites { get; set; }
        public Squad_bridge_turret_grunts_01 bridge_turret_grunts_01 { get; set; }
        public Squad_bridge_turret_grunts_02 bridge_turret_grunts_02 { get; set; }
        public Squad_bridge_bunker_elites_01 bridge_bunker_elites_01 { get; set; }
        public Squad_bridge_bunker_elites_02 bridge_bunker_elites_02 { get; set; }
        public Squad_bridge_bunker_jackals_01 bridge_bunker_jackals_01 { get; set; }
        public Squad_bridge_bunker_jackals_02 bridge_bunker_jackals_02 { get; set; }
        public Squad_bridge_bunker_grunts_01 bridge_bunker_grunts_01 { get; set; }
        public Squad_bridge_bunker_grunts_02 bridge_bunker_grunts_02 { get; set; }
        public Squad_bunker_turret_remen bunker_turret_remen { get; set; }
        public Squad_bridge_crack_jackals bridge_crack_jackals { get; set; }
        public Squad_bridge_crack_grunts bridge_crack_grunts { get; set; }
        public Squad_bridge_backdoor_elites_01 bridge_backdoor_elites_01 { get; set; }
        public Squad_bridge_backdoor_jackals_01 bridge_backdoor_jackals_01 { get; set; }
        public Squad_bridge_backdoor_grunts_01 bridge_backdoor_grunts_01 { get; set; }
        public Squad_bridge_control_elites_01 bridge_control_elites_01 { get; set; }
        public Squad_bridge_control_jackals_01 bridge_control_jackals_01 { get; set; }
        public Squad_bridge_control_grunts_01 bridge_control_grunts_01 { get; set; }
        public Squad_allies_bridge_bunker1 allies_bridge_bunker1 { get; set; }
        public Squad_bridge_phantom_01 bridge_phantom_01 { get; set; }
        public Squad_bridge_phantom_ghosts_01 bridge_phantom_ghosts_01 { get; set; }
        public Squad_bridge_phantom_02 bridge_phantom_02 { get; set; }
        public Squad_bridge_phantom_ghosts_02 bridge_phantom_ghosts_02 { get; set; }
        public Squad_bridge_farside_ghosts bridge_farside_ghosts { get; set; }
        public Squad_bridge_banshees bridge_banshees { get; set; }
        public Squad_bridge_pelican_chasers bridge_pelican_chasers { get; set; }
        public Squad_bridge_pelican bridge_pelican { get; set; }
        public Squad_bridge_tank1 bridge_tank1 { get; set; }
        public Squad_allies_bridge_pelican allies_bridge_pelican { get; set; }
        public Squad_w_path_free_ghost w_path_free_ghost { get; set; }
        public Squad_winding_path_ghosts_01 winding_path_ghosts_01 { get; set; }
        public Squad_winding_path_ghosts_02 winding_path_ghosts_02 { get; set; }
        public Squad_winding_path_grunts winding_path_grunts { get; set; }
        public Squad_w_path_heavies w_path_heavies { get; set; }
        public Squad_winding_path_ledge_grunts winding_path_ledge_grunts { get; set; }
        public Squad_winding_path_jackals winding_path_jackals { get; set; }
        public Squad_temple_ent_turrets_01 temple_ent_turrets_01 { get; set; }
        public Squad_temple_ent_turrets_02 temple_ent_turrets_02 { get; set; }
        public Squad_temple_ent_turrets_03 temple_ent_turrets_03 { get; set; }
        public Squad_temple_ent_turrets_04 temple_ent_turrets_04 { get; set; }
        public Squad_temple_ent_elites_01l temple_ent_elites_01l { get; set; }
        public Squad_temple_ent_elites_01r temple_ent_elites_01r { get; set; }
        public Squad_temple_ent_elites_02l temple_ent_elites_02l { get; set; }
        public Squad_temple_ent_elites_02r temple_ent_elites_02r { get; set; }
        public Squad_temple_ent_jackals_01l temple_ent_jackals_01l { get; set; }
        public Squad_temple_ent_jackals_01r temple_ent_jackals_01r { get; set; }
        public Squad_temple_ent_jackals_02c temple_ent_jackals_02c { get; set; }
        public Squad_temple_ent_bugs_01l temple_ent_bugs_01l { get; set; }
        public Squad_temple_ent_bugs_01c temple_ent_bugs_01c { get; set; }
        public Squad_temple_ent_bugs_01r temple_ent_bugs_01r { get; set; }
        public Squad_temple_ent_bugs_02l temple_ent_bugs_02l { get; set; }
        public Squad_temple_ent_bugs_02c temple_ent_bugs_02c { get; set; }
        public Squad_temple_ent_bugs_02r temple_ent_bugs_02r { get; set; }
        public Squad_temple_ent_grunts_01l temple_ent_grunts_01l { get; set; }
        public Squad_temple_ent_grunts_01r temple_ent_grunts_01r { get; set; }
        public Squad_temple_ent_ghosts_01 temple_ent_ghosts_01 { get; set; }
        public Squad_temple_ent_ghosts_02 temple_ent_ghosts_02 { get; set; }
        public Squad_temple_ent_banshees temple_ent_banshees { get; set; }
        public Squad_tunnel_ghosts_011 tunnel_ghosts_011 { get; set; }
        public Squad_tunnel_ghosts_021 tunnel_ghosts_021 { get; set; }
        public Squad_tunnel_grunts tunnel_grunts { get; set; }
        public Squad_tunnel_jackals tunnel_jackals { get; set; }
        public Squad_tunnel_heavies_01 tunnel_heavies_01 { get; set; }
        public Squad_tunnel_heavies_02 tunnel_heavies_02 { get; set; }
        public Squad_old_temple_turrets old_temple_turrets { get; set; }
        public Squad_old_temple_grunts_near_left old_temple_grunts_near_left { get; set; }
        public Squad_old_temple_grunts_far_left old_temple_grunts_far_left { get; set; }
        public Squad_old_temple_grunts_far_right old_temple_grunts_far_right { get; set; }
        public Squad_old_temple_grunts_center old_temple_grunts_center { get; set; }
        public Squad_old_temple_elites_near_right old_temple_elites_near_right { get; set; }
        public Squad_old_temple_jackals_near_right old_temple_jackals_near_right { get; set; }
        public Squad_old_temple_jackals_below_far old_temple_jackals_below_far { get; set; }
        public Squad_old_temple_jackals_below_near old_temple_jackals_below_near { get; set; }
        public Squad_old_temple_jackals_sea_01 old_temple_jackals_sea_01 { get; set; }
        public Squad_old_temple_jackals_sea_02 old_temple_jackals_sea_02 { get; set; }
        public Squad_old_temple_jackals_debris old_temple_jackals_debris { get; set; }
        public Squad_old_temple_jackals_corner old_temple_jackals_corner { get; set; }
        public Squad_old_temple_jackals_shrine_L old_temple_jackals_shrine_L { get; set; }
        public Squad_old_temple_jackals_shrine_R old_temple_jackals_shrine_R { get; set; }
        public Squad_old_temple_init_elites_fl old_temple_init_elites_fl { get; set; }
        public Squad_old_temple_init_jackals_fl old_temple_init_jackals_fl { get; set; }
        public Squad_old_temple_init_jackals_nl old_temple_init_jackals_nl { get; set; }
        public Squad_old_temple_init_elites_nr old_temple_init_elites_nr { get; set; }
        public Squad_old_temple_init_jackals_nr old_temple_init_jackals_nr { get; set; }
        public Squad_old_temple_ghosts_far old_temple_ghosts_far { get; set; }
        public Squad_old_temple_phantom1 old_temple_phantom1 { get; set; }
        public Squad_old_temple_ghosts_air old_temple_ghosts_air { get; set; }
        public Squad_old_temple_banshees old_temple_banshees { get; set; }
        public Squad_old_temple_pelican1 old_temple_pelican1 { get; set; }
        public Squad_allies_old_temple_pelican allies_old_temple_pelican { get; set; }
        public Squad_allies_old_temple_real allies_old_temple_real { get; set; }
        public Squad_old_temple_playfight_e old_temple_playfight_e { get; set; }
        public Squad_old_temple_playfight_g old_temple_playfight_g { get; set; }
        public Squad_old_temple_center_elites_01 old_temple_center_elites_01 { get; set; }
        public Squad_old_temple_center_grunts_01 old_temple_center_grunts_01 { get; set; }
        public Squad_old_temple_center_grunts_03 old_temple_center_grunts_03 { get; set; }
        public Squad_old_temple_center_jackals_04 old_temple_center_jackals_04 { get; set; }
        public Squad_old_temple_center_grunts_04 old_temple_center_grunts_04 { get; set; }
        public Squad_old_temple_center_elites_05 old_temple_center_elites_05 { get; set; }
        public Squad_old_temple_center_jackals_05 old_temple_center_jackals_05 { get; set; }
        public Squad_old_temple_courtyard_lure old_temple_courtyard_lure { get; set; }
        public Squad_old_temple_court_elites_01 old_temple_court_elites_01 { get; set; }
        public Squad_old_temple_court_grunts_01 old_temple_court_grunts_01 { get; set; }
        public Squad_old_temple_court_grunts_02 old_temple_court_grunts_02 { get; set; }
        public Squad_old_temple_court_jackals_03 old_temple_court_jackals_03 { get; set; }
        public Squad_old_temple_court_grunts_03 old_temple_court_grunts_03 { get; set; }
        public Squad_old_temple_court_jackals_04 old_temple_court_jackals_04 { get; set; }
        public Squad_old_temple_court_elites_05 old_temple_court_elites_05 { get; set; }
        public Squad_old_temple_court_jackals_05 old_temple_court_jackals_05 { get; set; }
        public Squad_old_temple_court_jackals_06 old_temple_court_jackals_06 { get; set; }
        public Squad_old_temple_court_grunts_06 old_temple_court_grunts_06 { get; set; }
        public Squad_courtyard_grunts_end courtyard_grunts_end { get; set; }
        public Squad_old_temp_court_phantom old_temp_court_phantom { get; set; }
        public Squad_grotto_init_01 grotto_init_01 { get; set; }
        public Squad_grotto_init_02 grotto_init_02 { get; set; }
        public Squad_grotto_init_03 grotto_init_03 { get; set; }
        public Squad_grotto_init_04 grotto_init_04 { get; set; }
        public Squad_grotto_init_05 grotto_init_05 { get; set; }
        public Squad_grotto_init_06 grotto_init_06 { get; set; }
        public Squad_grotto_init_07 grotto_init_07 { get; set; }
        public Squad_grotto_init_08 grotto_init_08 { get; set; }
        public Squad_grotto_init_09 grotto_init_09 { get; set; }
        public Squad_grotto_init_10 grotto_init_10 { get; set; }
        public Squad_grotto_init_11 grotto_init_11 { get; set; }
        public Squad_grotto_buggers_new_01 grotto_buggers_new_01 { get; set; }
        public Squad_grotto_sleepers grotto_sleepers { get; set; }
        public Squad_grotto_crack_grunts grotto_crack_grunts { get; set; }
        public Squad_grotto_pool_grunts grotto_pool_grunts { get; set; }
        public Squad_grotto_cave_elites grotto_cave_elites { get; set; }
        public Squad_grotto_cave_jackals_01 grotto_cave_jackals_01 { get; set; }
        public Squad_grotto_cave_jackals_02 grotto_cave_jackals_02 { get; set; }
        public Squad_grotto_cave_jackals_03 grotto_cave_jackals_03 { get; set; }
        public Squad_grotto_buggers_01 grotto_buggers_01 { get; set; }
        public Squad_grotto_buggers_02 grotto_buggers_02 { get; set; }
        public Squad_grotto_buggers_03 grotto_buggers_03 { get; set; }
        public Squad_grotto_end_elites_01 grotto_end_elites_01 { get; set; }
        public Squad_grotto_end_elites_02 grotto_end_elites_02 { get; set; }
        public Squad_grotto_end_jackals_01 grotto_end_jackals_01 { get; set; }
        public Squad_grotto_end_jackals_02 grotto_end_jackals_02 { get; set; }
        public Squad_grotto_end_jackals_03 grotto_end_jackals_03 { get; set; }
        public Squad_grotto_grunts_end grotto_grunts_end { get; set; }
        public Squad_approach_buggers1 approach_buggers1 { get; set; }
        public Squad_approach_buggers_too1 approach_buggers_too1 { get; set; }
        public Squad_approach_jackal_01 approach_jackal_01 { get; set; }
        public Squad_approach_jackal_02 approach_jackal_02 { get; set; }
        public Squad_approach_jackal_03 approach_jackal_03 { get; set; }
        public Squad_approach_elite_01 approach_elite_01 { get; set; }
        public Squad_approach_elite_02 approach_elite_02 { get; set; }
        public Squad_approach_elite_03 approach_elite_03 { get; set; }
        public Squad_approach_grunts_01 approach_grunts_01 { get; set; }
        public Squad_tower1_hg_01a tower1_hg_01a { get; set; }
        public Squad_tower1_hg_01b tower1_hg_01b { get; set; }
        public Squad_tower1_hg_02a tower1_hg_02a { get; set; }
        public Squad_tower1_hg_02b tower1_hg_02b { get; set; }
        public Squad_tower1_grunts_01 tower1_grunts_01 { get; set; }
        public Squad_tower1_grunts_02 tower1_grunts_02 { get; set; }
        public Squad_test test { get; set; }
        public Squad_jets jets { get; set; }
        public Squad_envy_elites envy_elites { get; set; }
        [SpawnCounts(3, 3)]
        public class Squad_allies_lz_ledge : SquadBase
        {
            public IAiActorDefinition ally02 => Squad.StartingLocations[0];
            public IAiActorDefinition ally01 => Squad.StartingLocations[1];
            public IAiActorDefinition ally03 => Squad.StartingLocations[2];
            public Squad_allies_lz_ledge(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "LZ_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_allies_lz_ridge : SquadBase
        {
            public IAiActorDefinition ally01 => Squad.StartingLocations[0];
            public IAiActorDefinition ally02 => Squad.StartingLocations[1];
            public Squad_allies_lz_ridge(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "LZ_allies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_LZ_turrets_01 : SquadBase
        {
            public IAiActorDefinition mesa => Squad.StartingLocations[0];
            public Squad_LZ_turrets_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "LZ_enemies_turrets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_LZ_turrets_02 : SquadBase
        {
            public IAiActorDefinition ridge => Squad.StartingLocations[0];
            public Squad_LZ_turrets_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "LZ_enemies_turrets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_LZ_turrets_03 : SquadBase
        {
            public IAiActorDefinition high => Squad.StartingLocations[0];
            public Squad_LZ_turrets_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "LZ_enemies_turrets")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_LZ_turrets_04 : SquadBase
        {
            public IAiActorDefinition structure => Squad.StartingLocations[0];
            public Squad_LZ_turrets_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "LZ_enemies_turrets")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_LZ_elites_ledge : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_LZ_elites_ledge(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "LZ_enemies_ledge")
            {
            }
        }

        [SpawnCounts(13, 13)]
        public class Squad_LZ_grunts_ledge : SquadBase
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
            public Squad_LZ_grunts_ledge(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "LZ_enemies_ledge")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_LZ_elites_ridge : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_LZ_elites_ridge(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "LZ_enemies_ridge")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_LZ_grunts_ridge : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_51 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_61 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public Squad_LZ_grunts_ridge(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "LZ_enemies_ridge")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_LZ_jackals_ridge : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_LZ_jackals_ridge(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "LZ_enemies_ridge")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_LZ_elites_yard : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_LZ_elites_yard(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "LZ_enemies_yard")
            {
            }
        }

        [SpawnCounts(10, 10)]
        public class Squad_LZ_grunts_yard : SquadBase
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
            public Squad_LZ_grunts_yard(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "LZ_enemies_yard")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_LZ_jackals_yard : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_LZ_jackals_yard(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "LZ_enemies_yard")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_LZ_elites_structure : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_LZ_elites_structure(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "LZ_enemies_structure")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_LZ_grunts_structure : SquadBase
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
            public Squad_LZ_grunts_structure(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "LZ_enemies_structure")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_LZ_jackals_structure : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_LZ_jackals_structure(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "LZ_enemies_structure")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_LZ_elites_bunkered : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_LZ_elites_bunkered(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "LZ_enemies_structure")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_LZ_grunts_bunkered : SquadBase
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
            public Squad_LZ_grunts_bunkered(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "LZ_enemies_structure")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_LZ_phantom_01 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_LZ_phantom_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "LZ_enemies_all")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_LZ_elites_phantom_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_LZ_elites_phantom_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "LZ_enemies_phantom")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_LZ_grunts_phantom_01 : SquadBase
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
            public Squad_LZ_grunts_phantom_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "LZ_enemies_phantom")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_LZ_jackals_phantom_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_LZ_jackals_phantom_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "LZ_enemies_phantom")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_LZ_phantom_02 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_LZ_phantom_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "LZ_enemies_all")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_LZ_elites_phantom_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_LZ_elites_phantom_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "LZ_enemies_phantom")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_LZ_grunts_phantom_02 : SquadBase
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
            public Squad_LZ_grunts_phantom_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "LZ_enemies_phantom")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_LZ_jackals_phantom_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_LZ_jackals_phantom_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "LZ_enemies_phantom")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_LZ_stealth_phantom_03 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public Squad_LZ_stealth_phantom_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "LZ_enemies_phantom")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_LZ_pelican_01 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public IAiActorDefinition gunner01 => Squad.StartingLocations[1];
            public Squad_LZ_pelican_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "all_ai")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_LZ_pelican_02 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public IAiActorDefinition gunner01 => Squad.StartingLocations[1];
            public Squad_LZ_pelican_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "all_ai")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_LZ_warthog_01 : SquadBase
        {
            public IAiActorDefinition driver => Squad.StartingLocations[0];
            public Squad_LZ_warthog_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "ally_vehicles")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_allies_lz_pelican : SquadBase
        {
            public IAiActorDefinition snipergirl => Squad.StartingLocations[0];
            public IAiActorDefinition sniperboy => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_81 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[7];
            public Squad_allies_lz_pelican(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "LZ_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_overlook_jackals_011 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_overlook_jackals_011(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "overlook_jackals")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_overlook_jackals_021 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_overlook_jackals_021(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "overlook_jackals")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_free_ghost : SquadBase
        {
            public IAiActorDefinition _2 => Squad.StartingLocations[0];
            public IAiActorDefinition _4 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _1 => Squad.StartingLocations[3];
            public Squad_bridge_free_ghost(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "ally_vehicles")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_farside_wraiths : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_bridge_farside_wraiths(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "bridge_farside_enemies")
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_bridge_bunker_turrets1 : SquadBase
        {
            public IAiActorDefinition bunker_01 => Squad.StartingLocations[0];
            public IAiActorDefinition bunker_02 => Squad.StartingLocations[1];
            public IAiActorDefinition bunker_03 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_bridge_bunker_turrets1(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "bridge_enemies_bunker")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_bunker_ghosts : SquadBase
        {
            public IAiActorDefinition l => Squad.StartingLocations[0];
            public IAiActorDefinition r => Squad.StartingLocations[1];
            public Squad_bridge_bunker_ghosts(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "bridge_vehicles_all")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_ghost_elites : SquadBase
        {
            public IAiActorDefinition r => Squad.StartingLocations[0];
            public IAiActorDefinition l => Squad.StartingLocations[1];
            public Squad_bridge_ghost_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "bridge_bunker_elites")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_turret_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bridge_turret_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "bridge_bunker_grunts")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_turret_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_turret_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "bridge_bunker_grunts")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_bunker_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_bunker_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "bridge_bunker_elites")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_bunker_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_bunker_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "bridge_bunker_elites")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_bunker_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_bunker_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "bridge_bunker_jackals")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_bunker_jackals_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_bunker_jackals_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "bridge_bunker_jackals")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_bridge_bunker_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_bridge_bunker_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "bridge_bunker_grunts")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_bridge_bunker_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_bridge_bunker_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "bridge_bunker_grunts")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bunker_turret_remen : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public Squad_bunker_turret_remen(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "bridge_bunker_grunts")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_crack_jackals : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bridge_crack_jackals(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "bridge_enemies_bunker")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_crack_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_crack_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "bridge_enemies_bunker")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_backdoor_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_backdoor_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "bridge_bunker_elites")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_backdoor_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_backdoor_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "bridge_bunker_jackals")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_bridge_backdoor_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_bridge_backdoor_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "bridge_bunker_grunts")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_control_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bridge_control_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "bridge_bunker_elites")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_control_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_control_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "bridge_bunker_jackals")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_bridge_control_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_bridge_control_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "bridge_bunker_grunts")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_allies_bridge_bunker1 : SquadBase
        {
            public IAiActorDefinition _1a => Squad.StartingLocations[0];
            public IAiActorDefinition _1b => Squad.StartingLocations[1];
            public IAiActorDefinition _2a => Squad.StartingLocations[2];
            public IAiActorDefinition _2b => Squad.StartingLocations[3];
            public Squad_allies_bridge_bunker1(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "bridge_allies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_phantom_01 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_bridge_phantom_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_phantom_ghosts_01 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_phantom_ghosts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "bridge_vehicles_all")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_phantom_02 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_bridge_phantom_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_phantom_ghosts_02 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_bridge_phantom_ghosts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "bridge_vehicles_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_farside_ghosts : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_farside_ghosts(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "bridge_farside_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_banshees : SquadBase
        {
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_banshees(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "bridge_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_pelican_chasers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bridge_pelican_chasers(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "bridge_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_pelican : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public IAiActorDefinition gunner1 => Squad.StartingLocations[1];
            public Squad_bridge_pelican(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "all_ai")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_tank1 : SquadBase
        {
            public IAiActorDefinition driver => Squad.StartingLocations[0];
            public Squad_bridge_tank1(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "ally_vehicles")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_allies_bridge_pelican : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[7];
            public Squad_allies_bridge_pelican(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "bridge_allies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_w_path_free_ghost : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_w_path_free_ghost(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "ally_vehicles")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_winding_path_ghosts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public Squad_winding_path_ghosts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "winding_path_ghosts")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_winding_path_ghosts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_winding_path_ghosts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "winding_path_ghosts")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_winding_path_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_winding_path_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "winding_path_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_w_path_heavies : SquadBase
        {
            public IAiActorDefinition _0 => Squad.StartingLocations[0];
            public IAiActorDefinition _1 => Squad.StartingLocations[1];
            public IAiActorDefinition _2 => Squad.StartingLocations[2];
            public Squad_w_path_heavies(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "winding_path_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_winding_path_ledge_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_winding_path_ledge_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "winding_path_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_winding_path_jackals : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_winding_path_jackals(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "winding_path_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_turrets_01 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_temple_ent_turrets_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "temple_ent_turrets_near")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_turrets_02 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_temple_ent_turrets_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "temple_ent_turrets_near")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_turrets_03 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_temple_ent_turrets_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "temple_ent_turrets_far")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_turrets_04 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_temple_ent_turrets_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "temple_ent_turrets_far")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_temple_ent_elites_01l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_temple_ent_elites_01l(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_temple_ent_elites_01r : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_temple_ent_elites_01r(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_temple_ent_elites_02l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_temple_ent_elites_02l(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_temple_ent_elites_02r : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_temple_ent_elites_02r(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_jackals_01l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_ent_jackals_01l(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_jackals_01r : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_ent_jackals_01r(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_jackals_02c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_temple_ent_jackals_02c(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_bugs_01l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_ent_bugs_01l(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_bugs_01c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_ent_bugs_01c(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_bugs_01r : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_ent_bugs_01r(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_bugs_02l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_ent_bugs_02l(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_bugs_02c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_ent_bugs_02c(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_bugs_02r : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_temple_ent_bugs_02r(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_temple_ent_grunts_01l : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_temple_ent_grunts_01l(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_temple_ent_grunts_01r : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_temple_ent_grunts_01r(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_ghosts_01 : SquadBase
        {
            public IAiActorDefinition r => Squad.StartingLocations[0];
            public IAiActorDefinition l => Squad.StartingLocations[1];
            public Squad_temple_ent_ghosts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "temple_ent_ghosts")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_ghosts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_temple_ent_ghosts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 94, "temple_ent_ghosts")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_temple_ent_banshees : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_temple_ent_banshees(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tunnel_ghosts_011 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_tunnel_ghosts_011(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "tunnel_ghosts")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tunnel_ghosts_021 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_tunnel_ghosts_021(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "tunnel_ghosts")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_tunnel_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_tunnel_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "tunnel_infantry")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_tunnel_jackals : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_61 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_62 => Squad.StartingLocations[5];
            public Squad_tunnel_jackals(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "tunnel_infantry")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tunnel_heavies_01 : SquadBase
        {
            public IAiActorDefinition _0 => Squad.StartingLocations[0];
            public IAiActorDefinition _1 => Squad.StartingLocations[1];
            public Squad_tunnel_heavies_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "tunnel_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_tunnel_heavies_02 : SquadBase
        {
            public IAiActorDefinition _2 => Squad.StartingLocations[0];
            public IAiActorDefinition _3 => Squad.StartingLocations[1];
            public Squad_tunnel_heavies_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 101, "tunnel_enemies_all")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_turrets : SquadBase
        {
            public IAiActorDefinition far_r => Squad.StartingLocations[0];
            public IAiActorDefinition near_l => Squad.StartingLocations[1];
            public IAiActorDefinition far_l => Squad.StartingLocations[2];
            public IAiActorDefinition center => Squad.StartingLocations[3];
            public Squad_old_temple_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 102, "old_temple_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_old_temple_grunts_near_left : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_old_temple_grunts_near_left(ScenarioTag ScenarioTag) : base(ScenarioTag, 103, "old_temple_peri_grunts")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_old_temple_grunts_far_left : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_old_temple_grunts_far_left(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "old_temple_peri_grunts")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_old_temple_grunts_far_right : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_grunts_far_right(ScenarioTag ScenarioTag) : base(ScenarioTag, 105, "old_temple_peri_grunts")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_old_temple_grunts_center : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_old_temple_grunts_center(ScenarioTag ScenarioTag) : base(ScenarioTag, 106, "old_temple_peri_grunts")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_old_temple_elites_near_right : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_old_temple_elites_near_right(ScenarioTag ScenarioTag) : base(ScenarioTag, 107, "old_temple_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_jackals_near_right : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_jackals_near_right(ScenarioTag ScenarioTag) : base(ScenarioTag, 108, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_old_temple_jackals_below_far : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_old_temple_jackals_below_far(ScenarioTag ScenarioTag) : base(ScenarioTag, 109, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_old_temple_jackals_below_near : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_old_temple_jackals_below_near(ScenarioTag ScenarioTag) : base(ScenarioTag, 110, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_jackals_sea_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_jackals_sea_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 111, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_jackals_sea_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_jackals_sea_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 112, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_jackals_debris : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_jackals_debris(ScenarioTag ScenarioTag) : base(ScenarioTag, 113, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_jackals_corner : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_jackals_corner(ScenarioTag ScenarioTag) : base(ScenarioTag, 114, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_jackals_shrine_L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_jackals_shrine_L(ScenarioTag ScenarioTag) : base(ScenarioTag, 115, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_jackals_shrine_R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_jackals_shrine_R(ScenarioTag ScenarioTag) : base(ScenarioTag, 116, "old_temple_peri_jackals")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_old_temple_init_elites_fl : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_old_temple_init_elites_fl(ScenarioTag ScenarioTag) : base(ScenarioTag, 117, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_old_temple_init_jackals_fl : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[1];
            public Squad_old_temple_init_jackals_fl(ScenarioTag ScenarioTag) : base(ScenarioTag, 118, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_init_jackals_nl : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_init_jackals_nl(ScenarioTag ScenarioTag) : base(ScenarioTag, 119, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_old_temple_init_elites_nr : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_old_temple_init_elites_nr(ScenarioTag ScenarioTag) : base(ScenarioTag, 120, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_init_jackals_nr : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_init_jackals_nr(ScenarioTag ScenarioTag) : base(ScenarioTag, 121, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_ghosts_far : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_ghosts_far(ScenarioTag ScenarioTag) : base(ScenarioTag, 122, "old_temple_vehicles")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_old_temple_phantom1 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_old_temple_phantom1(ScenarioTag ScenarioTag) : base(ScenarioTag, 123, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_ghosts_air : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_old_temple_ghosts_air(ScenarioTag ScenarioTag) : base(ScenarioTag, 124, "old_temple_vehicles")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_banshees : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_banshees(ScenarioTag ScenarioTag) : base(ScenarioTag, 125, "old_temple_vehicles")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_pelican1 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public IAiActorDefinition gunner1 => Squad.StartingLocations[1];
            public Squad_old_temple_pelican1(ScenarioTag ScenarioTag) : base(ScenarioTag, 126, "all_ai")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_allies_old_temple_pelican : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[7];
            public Squad_allies_old_temple_pelican(ScenarioTag ScenarioTag) : base(ScenarioTag, 127, "all_allies")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_allies_old_temple_real : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_allies_old_temple_real(ScenarioTag ScenarioTag) : base(ScenarioTag, 128, "ally_infantry")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_playfight_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_playfight_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 129, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_old_temple_playfight_g : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_old_temple_playfight_g(ScenarioTag ScenarioTag) : base(ScenarioTag, 130, "old_temp_center_fodder")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_center_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_center_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 131, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_old_temple_center_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_old_temple_center_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 132, "old_temp_center_fodder")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_old_temple_center_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_old_temple_center_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 133, "old_temp_center_fodder")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_old_temple_center_jackals_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_old_temple_center_jackals_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 134, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_old_temple_center_grunts_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_old_temple_center_grunts_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 135, "old_temp_center_fodder")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_center_elites_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_center_elites_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 136, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_center_jackals_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_old_temple_center_jackals_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 137, "old_temp_center_tough")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_old_temple_courtyard_lure : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_old_temple_courtyard_lure(ScenarioTag ScenarioTag) : base(ScenarioTag, 138, "old_temp_center_fodder")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_court_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_court_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 139, "old_temple_court_all")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_old_temple_court_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_old_temple_court_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 140, "old_temple_court_all")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_court_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_old_temple_court_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 141, "old_temple_court_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_court_jackals_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public Squad_old_temple_court_jackals_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 142, "old_temple_court_all")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_old_temple_court_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_51 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_61 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[4];
            public Squad_old_temple_court_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 143, "old_temple_court_all")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_old_temple_court_jackals_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public Squad_old_temple_court_jackals_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 144, "old_temple_court_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_court_elites_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_court_elites_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 145, "old_temple_court_all")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_old_temple_court_jackals_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_old_temple_court_jackals_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 146, "old_temple_court_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_old_temple_court_jackals_06 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_old_temple_court_jackals_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 147, "old_temple_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_old_temple_court_grunts_06 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_old_temple_court_grunts_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 148, "old_temple_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_courtyard_grunts_end : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_courtyard_grunts_end(ScenarioTag ScenarioTag) : base(ScenarioTag, 149, "old_temple_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_old_temp_court_phantom : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_old_temp_court_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 150, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_init_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_init_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 151, "grotto_initial")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_init_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grotto_init_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 152, "grotto_initial")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_init_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grotto_init_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 153, "grotto_initial")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_init_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grotto_init_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 154, "grotto_initial")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_init_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grotto_init_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 155, "grotto_initial")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_init_06 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grotto_init_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 156, "grotto_initial")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_init_07 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grotto_init_07(ScenarioTag ScenarioTag) : base(ScenarioTag, 157, "grotto_initial")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_init_08 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_grotto_init_08(ScenarioTag ScenarioTag) : base(ScenarioTag, 158, "grotto_initial")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_init_09 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_grotto_init_09(ScenarioTag ScenarioTag) : base(ScenarioTag, 159, "grotto_initial")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_init_10 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_init_10(ScenarioTag ScenarioTag) : base(ScenarioTag, 160, "grotto_initial")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_init_11 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_init_11(ScenarioTag ScenarioTag) : base(ScenarioTag, 161, "grotto_initial")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_grotto_buggers_new_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_grotto_buggers_new_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 162, "grotto_buggers")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_sleepers : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_grotto_sleepers(ScenarioTag ScenarioTag) : base(ScenarioTag, 163, "grotto_enemies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_grotto_crack_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_grotto_crack_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 164, "grotto_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_pool_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_pool_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 165, "grotto_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_cave_elites : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_grotto_cave_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 166, "grotto_phantom")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_cave_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_grotto_cave_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 167, "grotto_phantom")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_cave_jackals_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_grotto_cave_jackals_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 168, "grotto_phantom")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_cave_jackals_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_grotto_cave_jackals_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 169, "grotto_phantom")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_grotto_buggers_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_grotto_buggers_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 170, "grotto_buggers")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_grotto_buggers_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_grotto_buggers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 171, "grotto_buggers")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_grotto_buggers_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_grotto_buggers_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 172, "grotto_buggers")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_end_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_end_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 173, "grotto_enders")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_grotto_end_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_end_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 174, "grotto_enders")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_end_jackals_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_end_jackals_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 175, "grotto_enders")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_end_jackals_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_end_jackals_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 176, "grotto_enders")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_end_jackals_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_grotto_end_jackals_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 177, "grotto_enders")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_grotto_grunts_end : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public Squad_grotto_grunts_end(ScenarioTag ScenarioTag) : base(ScenarioTag, 178, "grotto_enders")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_approach_buggers1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_approach_buggers1(ScenarioTag ScenarioTag) : base(ScenarioTag, 179, "approach_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_approach_buggers_too1 : SquadBase
        {
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_13 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[8];
            public Squad_approach_buggers_too1(ScenarioTag ScenarioTag) : base(ScenarioTag, 180, "approach_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_approach_jackal_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_approach_jackal_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 181, "approach_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_approach_jackal_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_approach_jackal_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 182, "approach_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_approach_jackal_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_approach_jackal_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 183, "approach_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_approach_elite_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_approach_elite_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 184, "approach_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_approach_elite_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_approach_elite_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 185, "approach_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_approach_elite_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_approach_elite_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 186, "approach_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_approach_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_approach_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 187, "approach_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tower1_hg_01a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_tower1_hg_01a(ScenarioTag ScenarioTag) : base(ScenarioTag, 188, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tower1_hg_01b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_tower1_hg_01b(ScenarioTag ScenarioTag) : base(ScenarioTag, 189, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tower1_hg_02a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_tower1_hg_02a(ScenarioTag ScenarioTag) : base(ScenarioTag, 190, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tower1_hg_02b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_tower1_hg_02b(ScenarioTag ScenarioTag) : base(ScenarioTag, 191, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_tower1_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_tower1_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 192, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_tower1_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_tower1_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 193, "tower1_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_test : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_test(ScenarioTag ScenarioTag) : base(ScenarioTag, 194, "all_ai")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_jets : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_jets(ScenarioTag ScenarioTag) : base(ScenarioTag, 195, "temple_ent_enemies_all")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_envy_elites : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_envy_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 196, "all_enemies")
            {
            }
        }
    }
}