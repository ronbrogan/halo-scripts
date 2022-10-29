namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_04a_gasgiant : ScenarioScriptBase
    {
        public Squad_intro_elites intro_elites { get; set; }
        public Squad_intro_phantom intro_phantom { get; set; }
        public Squad_allies_grunts_01 allies_grunts_01 { get; set; }
        public Squad_allies_elites_01 allies_elites_01 { get; set; }
        public Squad_hacker hacker { get; set; }
        public Squad_rec_center_heretic_01 rec_center_heretic_01 { get; set; }
        public Squad_rec_center_heretic_02 rec_center_heretic_02 { get; set; }
        public Squad_rec_center_grunts_01 rec_center_grunts_01 { get; set; }
        public Squad_rec_center_grunts_02L rec_center_grunts_02L { get; set; }
        public Squad_rec_center_grunts_02R rec_center_grunts_02R { get; set; }
        public Squad_rec_center_grunts_03 rec_center_grunts_03 { get; set; }
        public Squad_rec_center_heretic_03 rec_center_heretic_03 { get; set; }
        public Squad_rec_center_heretic_04 rec_center_heretic_04 { get; set; }
        public Squad_rec_center_grunts_04 rec_center_grunts_04 { get; set; }
        public Squad_rec_center_heretic_05 rec_center_heretic_05 { get; set; }
        public Squad_rec_center_grunts_05 rec_center_grunts_05 { get; set; }
        public Squad_rec_center_grunts_06 rec_center_grunts_06 { get; set; }
        public Squad_rec_center_heretic_06 rec_center_heretic_06 { get; set; }
        public Squad_rec_center_grunts_07 rec_center_grunts_07 { get; set; }
        public Squad_rec_cen_rein_her_01L rec_cen_rein_her_01L { get; set; }
        public Squad_rec_cen_rein_grt_01L rec_cen_rein_grt_01L { get; set; }
        public Squad_rec_cen_rein_her_01R rec_cen_rein_her_01R { get; set; }
        public Squad_rec_cen_rein_grt_01R rec_cen_rein_grt_01R { get; set; }
        public Squad_hangar_heretic_01R hangar_heretic_01R { get; set; }
        public Squad_hangar_heretic_01L hangar_heretic_01L { get; set; }
        public Squad_hangar_grunts_01R hangar_grunts_01R { get; set; }
        public Squad_hangar_grunts_01L hangar_grunts_01L { get; set; }
        public Squad_hangar_heretic_02L hangar_heretic_02L { get; set; }
        public Squad_hangar_heretic_02R hangar_heretic_02R { get; set; }
        public Squad_hangar_heretic_05 hangar_heretic_05 { get; set; }
        public Squad_hangar_grunts_03 hangar_grunts_03 { get; set; }
        public Squad_hangar_rein_her_01L hangar_rein_her_01L { get; set; }
        public Squad_hangar_rein_her_01R hangar_rein_her_01R { get; set; }
        public Squad_hangar_rein_her_02L hangar_rein_her_02L { get; set; }
        public Squad_hangar_rein_her_02R hangar_rein_her_02R { get; set; }
        public Squad_hangar_rein_her_03L hangar_rein_her_03L { get; set; }
        public Squad_hangar_rein_her_03R hangar_rein_her_03R { get; set; }
        public Squad_hangar_sentinels_flit hangar_sentinels_flit { get; set; }
        public Squad_hangar_helper_01 hangar_helper_01 { get; set; }
        public Squad_hangar_helper_02 hangar_helper_02 { get; set; }
        public Squad_hangar_helper_03 hangar_helper_03 { get; set; }
        public Squad_hangar_phantom hangar_phantom { get; set; }
        public Squad_reinforce_elites_01 reinforce_elites_01 { get; set; }
        public Squad_reinforce_grunts_01 reinforce_grunts_01 { get; set; }
        public Squad_hangar_sentinel_swarm hangar_sentinel_swarm { get; set; }
        public Squad_hangar_heretic_heavies_L hangar_heretic_heavies_L { get; set; }
        public Squad_hangar_heretic_heavies_R hangar_heretic_heavies_R { get; set; }
        public Squad_hangar_a50_01r_high hangar_a50_01r_high { get; set; }
        public Squad_hangar_a50_01l_high hangar_a50_01l_high { get; set; }
        public Squad_hangar_a50_02r_high hangar_a50_02r_high { get; set; }
        public Squad_hangar_a50_02l_high hangar_a50_02l_high { get; set; }
        public Squad_hangar_a50_03r_high hangar_a50_03r_high { get; set; }
        public Squad_hangar_a50_03l_high hangar_a50_03l_high { get; set; }
        public Squad_hangar_a50_01r_low hangar_a50_01r_low { get; set; }
        public Squad_hangar_a50_01l_low hangar_a50_01l_low { get; set; }
        public Squad_hangar_a50_02r_low hangar_a50_02r_low { get; set; }
        public Squad_hangar_a50_02l_low hangar_a50_02l_low { get; set; }
        public Squad_hangar_a50_03r_low hangar_a50_03r_low { get; set; }
        public Squad_hangar_a50_03l_low hangar_a50_03l_low { get; set; }
        public Squad_hangar_grunts_04R hangar_grunts_04R { get; set; }
        public Squad_hangar_grunts_04L hangar_grunts_04L { get; set; }
        public Squad_hangar_heretic_06R hangar_heretic_06R { get; set; }
        public Squad_hangar_heretic_06C hangar_heretic_06C { get; set; }
        public Squad_hangar_heretic_06L hangar_heretic_06L { get; set; }
        public Squad_hangar_grunts_end hangar_grunts_end { get; set; }
        public Squad_first_hall_heretic_01 first_hall_heretic_01 { get; set; }
        public Squad_first_hall_grunts_01 first_hall_grunts_01 { get; set; }
        public Squad_first_hall_heretic_02 first_hall_heretic_02 { get; set; }
        public Squad_first_hall_heretic_03 first_hall_heretic_03 { get; set; }
        public Squad_reinforce_elites_02 reinforce_elites_02 { get; set; }
        public Squad_reinforce_grunts_02 reinforce_grunts_02 { get; set; }
        public Squad_underhangar_heretic_01 underhangar_heretic_01 { get; set; }
        public Squad_underhangar_heretic_02 underhangar_heretic_02 { get; set; }
        public Squad_underhangar_grunts_01 underhangar_grunts_01 { get; set; }
        public Squad_underhangar_grunts_02 underhangar_grunts_02 { get; set; }
        public Squad_underhangar_grunts_03 underhangar_grunts_03 { get; set; }
        public Squad_underhangar_rein_her_01 underhangar_rein_her_01 { get; set; }
        public Squad_underhangar_rein_her_02 underhangar_rein_her_02 { get; set; }
        public Squad_second_hall_heretic_01 second_hall_heretic_01 { get; set; }
        public Squad_second_hall_grunts_01 second_hall_grunts_01 { get; set; }
        public Squad_second_hall_heretic_02 second_hall_heretic_02 { get; set; }
        public Squad_second_hall_heretic_03 second_hall_heretic_03 { get; set; }
        public Squad_second_hall_grunts_02 second_hall_grunts_02 { get; set; }
        public Squad_second_hall_grunts_03 second_hall_grunts_03 { get; set; }
        public Squad_second_hall_heretic_04 second_hall_heretic_04 { get; set; }
        public Squad_second_hall_heretic_05 second_hall_heretic_05 { get; set; }
        public Squad_second_hall_heretic_06 second_hall_heretic_06 { get; set; }
        public Squad_heretic_leader_01 heretic_leader_01 { get; set; }
        public Squad_heretic_leader_02 heretic_leader_02 { get; set; }
        public Squad_heretic_leader_03 heretic_leader_03 { get; set; }
        public Squad_reinforce_elites_03 reinforce_elites_03 { get; set; }
        public Squad_reinforce_grunts_03 reinforce_grunts_03 { get; set; }
        public Squad_bottling_heretics_01 bottling_heretics_01 { get; set; }
        public Squad_bottling_grunts_01 bottling_grunts_01 { get; set; }
        public Squad_bottling_heretics_02 bottling_heretics_02 { get; set; }
        public Squad_bottling_grunts_02 bottling_grunts_02 { get; set; }
        public Squad_bottling_heretics_03 bottling_heretics_03 { get; set; }
        public Squad_bottling_grunts_03 bottling_grunts_03 { get; set; }
        public Squad_bottling_heretics_04 bottling_heretics_04 { get; set; }
        public Squad_bottling_grunts_04 bottling_grunts_04 { get; set; }
        public Squad_bottling_heretics_05 bottling_heretics_05 { get; set; }
        public Squad_bottling_grunts_05 bottling_grunts_05 { get; set; }
        public Squad_bottling_sentinels_01 bottling_sentinels_01 { get; set; }
        public Squad_bottling_sentinels_02 bottling_sentinels_02 { get; set; }
        public Squad_bottling_sentinels_03 bottling_sentinels_03 { get; set; }
        public Squad_ledge_banshees_01 ledge_banshees_01 { get; set; }
        public Squad_allied_phantom_01 allied_phantom_01 { get; set; }
        public Squad_dogfight_initial_enemies dogfight_initial_enemies { get; set; }
        public Squad_dogfight_enemies dogfight_enemies { get; set; }
        public Squad_dog_turrets_01 dog_turrets_01 { get; set; }
        public Squad_dog_turret_men_01 dog_turret_men_01 { get; set; }
        public Squad_dog_turrets_02 dog_turrets_02 { get; set; }
        public Squad_dog_turret_men_02 dog_turret_men_02 { get; set; }
        public Squad_dog_flak_02 dog_flak_02 { get; set; }
        public Squad_dog_turrets_03 dog_turrets_03 { get; set; }
        public Squad_dog_turret_men_03 dog_turret_men_03 { get; set; }
        public Squad_dog_sen_03 dog_sen_03 { get; set; }
        public Squad_dog_turrets_04 dog_turrets_04 { get; set; }
        public Squad_dog_turret_men_04 dog_turret_men_04 { get; set; }
        public Squad_dog_flak_04 dog_flak_04 { get; set; }
        public Squad_dog_sen_05 dog_sen_05 { get; set; }
        public Squad_dog_turrets_06 dog_turrets_06 { get; set; }
        public Squad_dog_turret_men_06 dog_turret_men_06 { get; set; }
        public Squad_dog_sen_06 dog_sen_06 { get; set; }
        public Squad_dog_turrets_07 dog_turrets_07 { get; set; }
        public Squad_dog_turret_men_07 dog_turret_men_07 { get; set; }
        public Squad_dog_flak_07 dog_flak_07 { get; set; }
        public Squad_hl_escort_sentinels hl_escort_sentinels { get; set; }
        public Squad_allies_elites_03 allies_elites_03 { get; set; }
        public Squad_allies_grunts_03 allies_grunts_03 { get; set; }
        public Squad_resupply_phantom resupply_phantom { get; set; }
        public Squad_eye01 eye01 { get; set; }
        public Squad_eye02 eye02 { get; set; }
        public Squad_eye03 eye03 { get; set; }
        public Squad_eye04 eye04 { get; set; }
        public Squad_eye05 eye05 { get; set; }
        public Squad_eye06 eye06 { get; set; }
        public Squad_eye07 eye07 { get; set; }
        public Squad_eye08 eye08 { get; set; }
        public Squad_eye09 eye09 { get; set; }
        public Squad_resupply_banshee resupply_banshee { get; set; }
        public Squad_arm02_final_grunts arm02_final_grunts { get; set; }
        public Squad_arm02_final_heretics arm02_final_heretics { get; set; }
        public Squad_bday_party bday_party { get; set; }
        public Squad_chasers chasers { get; set; }
        public Squad_turret_test turret_test { get; set; }
        [SpawnCounts(2, 2)]
        public class Squad_intro_elites : SquadBase
        {
            public IAiActorDefinition _01 => Squad.StartingLocations[0];
            public IAiActorDefinition _02 => Squad.StartingLocations[1];
            public Squad_intro_elites(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "all_allies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_intro_phantom : SquadBase
        {
            public IAiActorDefinition _01 => Squad.StartingLocations[0];
            public IAiActorDefinition _02 => Squad.StartingLocations[1];
            public IAiActorDefinition _03 => Squad.StartingLocations[2];
            public Squad_intro_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "all_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_allies_grunts_01 : SquadBase
        {
            public IAiActorDefinition grunt02 => Squad.StartingLocations[0];
            public IAiActorDefinition grunt01 => Squad.StartingLocations[1];
            public Squad_allies_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "allies_grunts")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_allies_elites_01 : SquadBase
        {
            public IAiActorDefinition elite04 => Squad.StartingLocations[0];
            public Squad_allies_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "allies_elites")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hacker : SquadBase
        {
            public IAiActorDefinition hacker => Squad.StartingLocations[0];
            public Squad_hacker(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "allies_elites")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_rec_center_heretic_01 : SquadBase
        {
            public IAiActorDefinition h01 => Squad.StartingLocations[0];
            public Squad_rec_center_heretic_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "rec_center_h_entry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_rec_center_heretic_02 : SquadBase
        {
            public IAiActorDefinition h01 => Squad.StartingLocations[0];
            public Squad_rec_center_heretic_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "rec_center_h_entry")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_rec_center_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_rec_center_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "rec_center_h_entry")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_rec_center_grunts_02L : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_rec_center_grunts_02L(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "rec_center_h_slope")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_rec_center_grunts_02R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_rec_center_grunts_02R(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "rec_center_h_slope")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_rec_center_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition testme => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_rec_center_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "rec_center_h_slope")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_rec_center_heretic_03 : SquadBase
        {
            public IAiActorDefinition h01 => Squad.StartingLocations[0];
            public IAiActorDefinition h02 => Squad.StartingLocations[1];
            public Squad_rec_center_heretic_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "rec_center_h_slope")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_rec_center_heretic_04 : SquadBase
        {
            public IAiActorDefinition h01 => Squad.StartingLocations[0];
            public Squad_rec_center_heretic_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "rec_center_h_slope")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_rec_center_grunts_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_rec_center_grunts_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "rec_center_h_slope")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_rec_center_heretic_05 : SquadBase
        {
            public IAiActorDefinition h01 => Squad.StartingLocations[0];
            public IAiActorDefinition h02 => Squad.StartingLocations[1];
            public Squad_rec_center_heretic_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "rec_center_h_below")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_rec_center_grunts_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_rec_center_grunts_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "rec_center_h_below")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_rec_center_grunts_06 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_rec_center_grunts_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "rec_center_h_end")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_rec_center_heretic_06 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_rec_center_heretic_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "rec_center_h_end")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_rec_center_grunts_07 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_rec_center_grunts_07(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "rec_center_h_end")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_rec_cen_rein_her_01L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_rec_cen_rein_her_01L(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "rec_center_h_entry")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_rec_cen_rein_grt_01L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_rec_cen_rein_grt_01L(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "rec_center_h_entry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_rec_cen_rein_her_01R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_rec_cen_rein_her_01R(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "rec_center_h_entry")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_rec_cen_rein_grt_01R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_rec_cen_rein_grt_01R(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "rec_center_h_entry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_heretic_01R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_hangar_heretic_01R(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_heretic_01L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_hangar_heretic_01L(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_grunts_01R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_grunts_01R(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_grunts_01L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_grunts_01L(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_heretic_02L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_hangar_heretic_02L(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_heretic_02R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_hangar_heretic_02R(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_heretic_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_hangar_heretic_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hangar_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_hangar_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_rein_her_01L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_rein_her_01L(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_rein_her_01R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_rein_her_01R(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hangar_rein_her_02L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hangar_rein_her_02L(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hangar_rein_her_02R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hangar_rein_her_02R(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_rein_her_03L : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_hangar_rein_her_03L(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_rein_her_03R : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_hangar_rein_her_03R(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "hangar_heretics_init")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_hangar_sentinels_flit : SquadBase
        {
            public IAiActorDefinition l1 => Squad.StartingLocations[0];
            public IAiActorDefinition l2 => Squad.StartingLocations[1];
            public IAiActorDefinition r1 => Squad.StartingLocations[2];
            public IAiActorDefinition r2 => Squad.StartingLocations[3];
            public IAiActorDefinition c1 => Squad.StartingLocations[4];
            public IAiActorDefinition c2 => Squad.StartingLocations[5];
            public Squad_hangar_sentinels_flit(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "hangar_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_helper_01 : SquadBase
        {
            public IAiActorDefinition helper01 => Squad.StartingLocations[0];
            public Squad_hangar_helper_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "hangar_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_helper_02 : SquadBase
        {
            public IAiActorDefinition helper01 => Squad.StartingLocations[0];
            public Squad_hangar_helper_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "hangar_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_helper_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_hangar_helper_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "hangar_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_phantom : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_hangar_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "all_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_reinforce_elites_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_reinforce_elites_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "allies_elites")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_reinforce_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_reinforce_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "allies_grunts")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_hangar_sentinel_swarm : SquadBase
        {
            public IAiActorDefinition l1 => Squad.StartingLocations[0];
            public IAiActorDefinition l2 => Squad.StartingLocations[1];
            public IAiActorDefinition r1 => Squad.StartingLocations[2];
            public IAiActorDefinition r2 => Squad.StartingLocations[3];
            public IAiActorDefinition c1 => Squad.StartingLocations[4];
            public Squad_hangar_sentinel_swarm(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "hangar_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hangar_heretic_heavies_L : SquadBase
        {
            public IAiActorDefinition _02a => Squad.StartingLocations[0];
            public IAiActorDefinition _02b => Squad.StartingLocations[1];
            public IAiActorDefinition _03a => Squad.StartingLocations[2];
            public IAiActorDefinition _03b => Squad.StartingLocations[3];
            public Squad_hangar_heretic_heavies_L(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "hangar_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hangar_heretic_heavies_R : SquadBase
        {
            public IAiActorDefinition _02a => Squad.StartingLocations[0];
            public IAiActorDefinition _02b => Squad.StartingLocations[1];
            public IAiActorDefinition _03a => Squad.StartingLocations[2];
            public IAiActorDefinition _03b => Squad.StartingLocations[3];
            public Squad_hangar_heretic_heavies_R(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "hangar_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_a50_01r_high : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_a50_01r_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "a50_high")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_a50_01l_high : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_a50_01l_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "a50_high")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_a50_02r_high : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_a50_02r_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "a50_high")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_a50_02l_high : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_a50_02l_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "a50_high")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_a50_03r_high : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_a50_03r_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "a50_high")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_a50_03l_high : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_a50_03l_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "a50_high")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hangar_a50_01r_low : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_hangar_a50_01r_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "a50_high")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hangar_a50_01l_low : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_hangar_a50_01l_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "a50_high")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hangar_a50_02r_low : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_hangar_a50_02r_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "a50_high")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hangar_a50_02l_low : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_hangar_a50_02l_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "a50_high")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hangar_a50_03r_low : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_hangar_a50_03r_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "a50_high")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_hangar_a50_03l_low : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_hangar_a50_03l_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "a50_high")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_grunts_04R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_grunts_04R(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "hangar_heretics_after")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_grunts_04L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_grunts_04L(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "hangar_heretics_after")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_heretic_06R : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_heretic_06R(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "hangar_heretics_after")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hangar_heretic_06C : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_hangar_heretic_06C(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "hangar_heretics_after")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_heretic_06L : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_heretic_06L(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "hangar_heretics_after")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hangar_grunts_end : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hangar_grunts_end(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "hangar_heretics_after")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_first_hall_heretic_01 : SquadBase
        {
            public IAiActorDefinition h01 => Squad.StartingLocations[0];
            public Squad_first_hall_heretic_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "first_hall_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_first_hall_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_first_hall_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "underhangar_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_first_hall_heretic_02 : SquadBase
        {
            public IAiActorDefinition h02 => Squad.StartingLocations[0];
            public Squad_first_hall_heretic_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "first_hall_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_first_hall_heretic_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_first_hall_heretic_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "first_hall_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_reinforce_elites_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_reinforce_elites_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "allies_elites")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_reinforce_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_reinforce_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "allies_grunts")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_underhangar_heretic_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_underhangar_heretic_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "underhangar_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_underhangar_heretic_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_underhangar_heretic_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "underhangar_heretics")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_underhangar_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_underhangar_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "underhangar_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_underhangar_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_underhangar_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "underhangar_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_underhangar_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_underhangar_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "underhangar_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_underhangar_rein_her_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_underhangar_rein_her_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "underhangar_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_underhangar_rein_her_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_underhangar_rein_her_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "underhangar_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_second_hall_heretic_01 : SquadBase
        {
            public IAiActorDefinition h01 => Squad.StartingLocations[0];
            public Squad_second_hall_heretic_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_second_hall_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_second_hall_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_second_hall_heretic_02 : SquadBase
        {
            public IAiActorDefinition h05a => Squad.StartingLocations[0];
            public IAiActorDefinition h05b => Squad.StartingLocations[1];
            public Squad_second_hall_heretic_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_second_hall_heretic_03 : SquadBase
        {
            public IAiActorDefinition h02 => Squad.StartingLocations[0];
            public Squad_second_hall_heretic_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_second_hall_grunts_02 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public Squad_second_hall_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_second_hall_grunts_03 : SquadBase
        {
            public IAiActorDefinition h03 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_second_hall_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_second_hall_heretic_04 : SquadBase
        {
            public IAiActorDefinition h07a => Squad.StartingLocations[0];
            public IAiActorDefinition h07b => Squad.StartingLocations[1];
            public Squad_second_hall_heretic_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_second_hall_heretic_05 : SquadBase
        {
            public IAiActorDefinition h04 => Squad.StartingLocations[0];
            public Squad_second_hall_heretic_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_second_hall_heretic_06 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_second_hall_heretic_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "second_hall_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_heretic_leader_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_heretic_leader_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 87)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_heretic_leader_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_heretic_leader_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 88)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_heretic_leader_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_heretic_leader_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 89)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_reinforce_elites_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_reinforce_elites_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "allies_elites")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_reinforce_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_reinforce_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "allies_grunts")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bottling_heretics_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bottling_heretics_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "bottling_heretics_start")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bottling_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bottling_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "bottling_heretics_start")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bottling_heretics_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bottling_heretics_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 94, "bottling_firsthalf")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bottling_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_bottling_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "bottling_firsthalf")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bottling_heretics_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bottling_heretics_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "bottling_firsthalf")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bottling_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_bottling_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "bottling_firsthalf")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bottling_heretics_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bottling_heretics_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "bottling_heretics")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bottling_grunts_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bottling_grunts_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "bottling_heretics")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bottling_heretics_05 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bottling_heretics_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "bottling_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bottling_grunts_05 : SquadBase
        {
            public IAiActorDefinition l1 => Squad.StartingLocations[0];
            public IAiActorDefinition l2 => Squad.StartingLocations[1];
            public IAiActorDefinition l3 => Squad.StartingLocations[2];
            public IAiActorDefinition r1 => Squad.StartingLocations[3];
            public IAiActorDefinition r2 => Squad.StartingLocations[4];
            public IAiActorDefinition r3 => Squad.StartingLocations[5];
            public Squad_bottling_grunts_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 101, "bottling_heretics")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bottling_sentinels_01 : SquadBase
        {
            public IAiActorDefinition tube01 => Squad.StartingLocations[0];
            public IAiActorDefinition tube02 => Squad.StartingLocations[1];
            public IAiActorDefinition tube03 => Squad.StartingLocations[2];
            public Squad_bottling_sentinels_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 102, "bottling_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bottling_sentinels_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bottling_sentinels_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 103, "bottling_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bottling_sentinels_03 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_bottling_sentinels_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "bottling_sentinels")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_ledge_banshees_01 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition center => Squad.StartingLocations[1];
            public IAiActorDefinition right => Squad.StartingLocations[2];
            public Squad_ledge_banshees_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 105)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_allied_phantom_01 : SquadBase
        {
            public IAiActorDefinition driver => Squad.StartingLocations[0];
            public Squad_allied_phantom_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 106, "dogfight_allies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_dogfight_initial_enemies : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_dogfight_initial_enemies(ScenarioTag ScenarioTag) : base(ScenarioTag, 107, "dogfighters_01")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_dogfight_enemies : SquadBase
        {
            public IAiActorDefinition pt_01 => Squad.StartingLocations[0];
            public IAiActorDefinition pt_02 => Squad.StartingLocations[1];
            public IAiActorDefinition pt_03 => Squad.StartingLocations[2];
            public IAiActorDefinition pt_04 => Squad.StartingLocations[3];
            public IAiActorDefinition pt_05 => Squad.StartingLocations[4];
            public IAiActorDefinition pt_06 => Squad.StartingLocations[5];
            public IAiActorDefinition pt_07 => Squad.StartingLocations[6];
            public IAiActorDefinition pt_08 => Squad.StartingLocations[7];
            public Squad_dogfight_enemies(ScenarioTag ScenarioTag) : base(ScenarioTag, 108, "dogfighters_01")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turrets_01 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_dog_turrets_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 109, "dog_obj_emplaced_01")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turret_men_01 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_dog_turret_men_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 110, "dog_obj_emplaced_01")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turrets_02 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_dog_turrets_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 111, "dog_obj_emplaced_02")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turret_men_02 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_dog_turret_men_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 112, "dog_obj_emplaced_02")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_dog_flak_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_dog_flak_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 113, "dog_obj_emplaced_02")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turrets_03 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_dog_turrets_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 114, "dog_obj_emplaced_03")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turret_men_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_dog_turret_men_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 115, "dog_obj_emplaced_03")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_dog_sen_03 : SquadBase
        {
            public IAiActorDefinition l1 => Squad.StartingLocations[0];
            public IAiActorDefinition l2 => Squad.StartingLocations[1];
            public IAiActorDefinition l3 => Squad.StartingLocations[2];
            public IAiActorDefinition r1 => Squad.StartingLocations[3];
            public IAiActorDefinition r2 => Squad.StartingLocations[4];
            public IAiActorDefinition r3 => Squad.StartingLocations[5];
            public Squad_dog_sen_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 116, "dog_obj_emplaced_03")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turrets_04 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_dog_turrets_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 117, "dog_obj_emplaced_04")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turret_men_04 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_dog_turret_men_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 118, "dog_obj_emplaced_04")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_dog_flak_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_dog_flak_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 119, "dog_obj_emplaced_04")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_dog_sen_05 : SquadBase
        {
            public IAiActorDefinition a1 => Squad.StartingLocations[0];
            public IAiActorDefinition a2 => Squad.StartingLocations[1];
            public IAiActorDefinition a3 => Squad.StartingLocations[2];
            public IAiActorDefinition c1 => Squad.StartingLocations[3];
            public IAiActorDefinition c2 => Squad.StartingLocations[4];
            public IAiActorDefinition c3 => Squad.StartingLocations[5];
            public Squad_dog_sen_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 120, "dog_obj_emplaced_05")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turrets_06 : SquadBase
        {
            public IAiActorDefinition left => Squad.StartingLocations[0];
            public IAiActorDefinition right => Squad.StartingLocations[1];
            public Squad_dog_turrets_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 121, "dog_obj_emplaced_06")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dog_turret_men_06 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_dog_turret_men_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 122, "dog_obj_emplaced_06")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_dog_sen_06 : SquadBase
        {
            public IAiActorDefinition l1 => Squad.StartingLocations[0];
            public IAiActorDefinition l2 => Squad.StartingLocations[1];
            public IAiActorDefinition l3 => Squad.StartingLocations[2];
            public IAiActorDefinition r1 => Squad.StartingLocations[3];
            public IAiActorDefinition r2 => Squad.StartingLocations[4];
            public IAiActorDefinition r3 => Squad.StartingLocations[5];
            public Squad_dog_sen_06(ScenarioTag ScenarioTag) : base(ScenarioTag, 123, "dog_obj_emplaced_06")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_dog_turrets_07 : SquadBase
        {
            public IAiActorDefinition _01 => Squad.StartingLocations[0];
            public IAiActorDefinition _02 => Squad.StartingLocations[1];
            public IAiActorDefinition _03 => Squad.StartingLocations[2];
            public IAiActorDefinition _04 => Squad.StartingLocations[3];
            public Squad_dog_turrets_07(ScenarioTag ScenarioTag) : base(ScenarioTag, 124, "dog_07_turrets")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_dog_turret_men_07 : SquadBase
        {
            public IAiActorDefinition _01 => Squad.StartingLocations[0];
            public IAiActorDefinition _02 => Squad.StartingLocations[1];
            public IAiActorDefinition _03 => Squad.StartingLocations[2];
            public IAiActorDefinition _04 => Squad.StartingLocations[3];
            public Squad_dog_turret_men_07(ScenarioTag ScenarioTag) : base(ScenarioTag, 125, "dog_07_turrets")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_dog_flak_07 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_dog_flak_07(ScenarioTag ScenarioTag) : base(ScenarioTag, 126, "dog_obj_emplaced_07")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_hl_escort_sentinels : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_hl_escort_sentinels(ScenarioTag ScenarioTag) : base(ScenarioTag, 127, "dog_obj_emplaced_07")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_allies_elites_03 : SquadBase
        {
            public IAiActorDefinition elite01 => Squad.StartingLocations[0];
            public IAiActorDefinition elite02 => Squad.StartingLocations[1];
            public Squad_allies_elites_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 128, "arm02_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_allies_grunts_03 : SquadBase
        {
            public IAiActorDefinition grunt01 => Squad.StartingLocations[0];
            public IAiActorDefinition grunt02 => Squad.StartingLocations[1];
            public Squad_allies_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 129, "arm02_allies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_resupply_phantom : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public Squad_resupply_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 130, "all_allies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye01 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye01(ScenarioTag ScenarioTag) : base(ScenarioTag, 131, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye02 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye02(ScenarioTag ScenarioTag) : base(ScenarioTag, 132, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye03 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye03(ScenarioTag ScenarioTag) : base(ScenarioTag, 133, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye04 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye04(ScenarioTag ScenarioTag) : base(ScenarioTag, 134, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye05 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye05(ScenarioTag ScenarioTag) : base(ScenarioTag, 135, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye06 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye06(ScenarioTag ScenarioTag) : base(ScenarioTag, 136, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye07 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye07(ScenarioTag ScenarioTag) : base(ScenarioTag, 137, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye08 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye08(ScenarioTag ScenarioTag) : base(ScenarioTag, 138, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_eye09 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_eye09(ScenarioTag ScenarioTag) : base(ScenarioTag, 139, "eyes_in_the_sky")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_resupply_banshee : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_resupply_banshee(ScenarioTag ScenarioTag) : base(ScenarioTag, 140)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_arm02_final_grunts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_arm02_final_grunts(ScenarioTag ScenarioTag) : base(ScenarioTag, 141, "dog_obj_emplaced_07")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_arm02_final_heretics : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_arm02_final_heretics(ScenarioTag ScenarioTag) : base(ScenarioTag, 142, "dog_obj_emplaced_07")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_bday_party : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_bday_party(ScenarioTag ScenarioTag) : base(ScenarioTag, 143, "rec_center_h_entry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_chasers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_chasers(ScenarioTag ScenarioTag) : base(ScenarioTag, 144)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_turret_test : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_turret_test(ScenarioTag ScenarioTag) : base(ScenarioTag, 145, "allies_grunts")
            {
            }
        }
    }
}