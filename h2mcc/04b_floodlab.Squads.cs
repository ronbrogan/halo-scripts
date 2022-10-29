namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_04b_floodlab : ScenarioScriptBase
    {
        public Squad_disposal_commander disposal_commander { get; set; }
        public Squad_allies_elites_03a allies_elites_03a { get; set; }
        public Squad_allies_elites_03b allies_elites_03b { get; set; }
        public Squad_allies_grunts_03 allies_grunts_03 { get; set; }
        public Squad_disposal_entry_flood disposal_entry_flood { get; set; }
        public Squad_disposal_entry_juggernaut disposal_entry_juggernaut { get; set; }
        public Squad_disposal_entry_heretics disposal_entry_heretics { get; set; }
        public Squad_holo_drone holo_drone { get; set; }
        public Squad_hl_hologram hl_hologram { get; set; }
        public Squad_disposal_infection_01 disposal_infection_01 { get; set; }
        public Squad_disposal_infection_02 disposal_infection_02 { get; set; }
        public Squad_silo_sentinels_initial silo_sentinels_initial { get; set; }
        public Squad_silo_sentinels_resupply silo_sentinels_resupply { get; set; }
        public Squad_silo_flood_initial silo_flood_initial { get; set; }
        public Squad_silo_climbers_01 silo_climbers_01 { get; set; }
        public Squad_silo_climbers_02 silo_climbers_02 { get; set; }
        public Squad_silo_sentinels_below silo_sentinels_below { get; set; }
        public Squad_silo_infection_01 silo_infection_01 { get; set; }
        public Squad_silo_infection_02 silo_infection_02 { get; set; }
        public Squad_silo_infection_03 silo_infection_03 { get; set; }
        public Squad_silo_infection_04 silo_infection_04 { get; set; }
        public Squad_silo_heretics silo_heretics { get; set; }
        public Squad_silo_sentinels_end silo_sentinels_end { get; set; }
        public Squad_silo_flood_halls silo_flood_halls { get; set; }
        public Squad_lab_heretics_01 lab_heretics_01 { get; set; }
        public Squad_lab_turret_grunts_01 lab_turret_grunts_01 { get; set; }
        public Squad_lab_heretics_02 lab_heretics_02 { get; set; }
        public Squad_lab_grunts_02 lab_grunts_02 { get; set; }
        public Squad_lab_exit_turrets lab_exit_turrets { get; set; }
        public Squad_lab_combatforms_01 lab_combatforms_01 { get; set; }
        public Squad_lab_combatforms_02 lab_combatforms_02 { get; set; }
        public Squad_lab_carriers_01 lab_carriers_01 { get; set; }
        public Squad_lab_carriers_02 lab_carriers_02 { get; set; }
        public Squad_lab_infection_01 lab_infection_01 { get; set; }
        public Squad_lab_infection_02 lab_infection_02 { get; set; }
        public Squad_lab_heretics_above lab_heretics_above { get; set; }
        public Squad_lab_juggernaut_above lab_juggernaut_above { get; set; }
        public Squad_bridge_strafer bridge_strafer { get; set; }
        public Squad_allied_phantom_02 allied_phantom_02 { get; set; }
        public Squad_allies_grunts_04 allies_grunts_04 { get; set; }
        public Squad_allies_elites_04 allies_elites_04 { get; set; }
        public Squad_bridge_runners bridge_runners { get; set; }
        public Squad_bridge_h_grunts_init bridge_h_grunts_init { get; set; }
        public Squad_bridge_heretics_R_02 bridge_heretics_R_02 { get; set; }
        public Squad_bridge_h_grunts_R_03 bridge_h_grunts_R_03 { get; set; }
        public Squad_bridge_heretics_R_04 bridge_heretics_R_04 { get; set; }
        public Squad_bridge_sentinels_R_05 bridge_sentinels_R_05 { get; set; }
        public Squad_bridge_heretics_L_02 bridge_heretics_L_02 { get; set; }
        public Squad_bridge_h_grunts_L_03 bridge_h_grunts_L_03 { get; set; }
        public Squad_bridge_heretics_L_04 bridge_heretics_L_04 { get; set; }
        public Squad_bridge_sentinels_L_05 bridge_sentinels_L_05 { get; set; }
        public Squad_bridge_heretics_final bridge_heretics_final { get; set; }
        public Squad_bridge_h_grunts_final bridge_h_grunts_final { get; set; }
        public Squad_bridge_combatforms bridge_combatforms { get; set; }
        public Squad_bridge_carriers bridge_carriers { get; set; }
        public Squad_bridge_infection bridge_infection { get; set; }
        public Squad_heretic_leader_control heretic_leader_control { get; set; }
        public Squad_control_commander_cinematic control_commander_cinematic { get; set; }
        public Squad_control_elites_cinematic control_elites_cinematic { get; set; }
        public Squad_control_flood_wave_01_combat control_flood_wave_01_combat { get; set; }
        public Squad_control_flood_wave_02_combat control_flood_wave_02_combat { get; set; }
        public Squad_control_flood_wave_02_carriers control_flood_wave_02_carriers { get; set; }
        public Squad_control_flood_wave_03_combat control_flood_wave_03_combat { get; set; }
        public Squad_control_flood_wave_03_carriers control_flood_wave_03_carriers { get; set; }
        public Squad_control_infection control_infection { get; set; }
        public Squad_control_sentinels_wave_01 control_sentinels_wave_01 { get; set; }
        public Squad_control_sentinels_wave_03 control_sentinels_wave_03 { get; set; }
        public Squad_allied_phantom_03 allied_phantom_03 { get; set; }
        public Squad_cableroom_flood_init cableroom_flood_init { get; set; }
        public Squad_cableroom_sentinels_init cableroom_sentinels_init { get; set; }
        public Squad_cable_room_combatforms cable_room_combatforms { get; set; }
        public Squad_cable_room_sentinels cable_room_sentinels { get; set; }
        public Squad_control_return_heretics_01 control_return_heretics_01 { get; set; }
        public Squad_control_return_heretics_02 control_return_heretics_02 { get; set; }
        public Squad_control_return_h_grunts_02 control_return_h_grunts_02 { get; set; }
        public Squad_control_return_heretics_03 control_return_heretics_03 { get; set; }
        public Squad_control_return_h_grunts_03 control_return_h_grunts_03 { get; set; }
        public Squad_control_return_sentinels_01 control_return_sentinels_01 { get; set; }
        public Squad_control_return_flood_01 control_return_flood_01 { get; set; }
        public Squad_control_return_flood_02 control_return_flood_02 { get; set; }
        public Squad_control_return_flood_03 control_return_flood_03 { get; set; }
        public Squad_control_return_flood_04 control_return_flood_04 { get; set; }
        public Squad_control_return_carriers_01 control_return_carriers_01 { get; set; }
        public Squad_control_return_carriers_02 control_return_carriers_02 { get; set; }
        public Squad_control_return_carriers_03 control_return_carriers_03 { get; set; }
        public Squad_control_return_carriers_04 control_return_carriers_04 { get; set; }
        public Squad_power_core_heretics_01 power_core_heretics_01 { get; set; }
        public Squad_power_core_h_grunts_01 power_core_h_grunts_01 { get; set; }
        public Squad_power_core_sentinels_01 power_core_sentinels_01 { get; set; }
        public Squad_power_core_combatforms power_core_combatforms { get; set; }
        public Squad_power_core_carriers power_core_carriers { get; set; }
        public Squad_ledge_banshees_02 ledge_banshees_02 { get; set; }
        public Squad_heretic_leader_04 heretic_leader_04 { get; set; }
        public Squad_dervish_01 dervish_01 { get; set; }
        public Squad_dervish_02 dervish_02 { get; set; }
        public Squad_dervish_031 dervish_031 { get; set; }
        public Squad_dogfighters_init dogfighters_init { get; set; }
        public Squad_dogfighters_finale dogfighters_finale { get; set; }
        public Squad_bottling_return_sentinels_01 bottling_return_sentinels_01 { get; set; }
        public Squad_bottling_return_sentinels_02 bottling_return_sentinels_02 { get; set; }
        public Squad_bottling_return_sentinels_03 bottling_return_sentinels_03 { get; set; }
        public Squad_bottling_return_flood_01 bottling_return_flood_01 { get; set; }
        public Squad_bottling_return_combatforms_02 bottling_return_combatforms_02 { get; set; }
        public Squad_bottling_return_carriers_02 bottling_return_carriers_02 { get; set; }
        public Squad_bottling_return_combatforms_03 bottling_return_combatforms_03 { get; set; }
        public Squad_bottling_return_carriers_03 bottling_return_carriers_03 { get; set; }
        public Squad_bottling_return_combatforms_04 bottling_return_combatforms_04 { get; set; }
        public Squad_bottling_return_carriers_04 bottling_return_carriers_04 { get; set; }
        public Squad_second_hall_infection_01 second_hall_infection_01 { get; set; }
        public Squad_second_hall_flood_01 second_hall_flood_01 { get; set; }
        public Squad_second_hall_carriers second_hall_carriers { get; set; }
        public Squad_second_hall_flood_02 second_hall_flood_02 { get; set; }
        public Squad_second_hall_infection_02 second_hall_infection_02 { get; set; }
        public Squad_second_hall_flood_03 second_hall_flood_03 { get; set; }
        public Squad_underhangar_heretics_01 underhangar_heretics_01 { get; set; }
        public Squad_underhangar_h_grunts_01 underhangar_h_grunts_01 { get; set; }
        public Squad_underhangar_heretics_02 underhangar_heretics_02 { get; set; }
        public Squad_underhangar_h_grunts_02 underhangar_h_grunts_02 { get; set; }
        public Squad_underhangar_heretics_03 underhangar_heretics_03 { get; set; }
        public Squad_underhangar_h_grunts_03 underhangar_h_grunts_03 { get; set; }
        public Squad_underhangar_combatforms_init underhangar_combatforms_init { get; set; }
        public Squad_underhangar_carriers_init underhangar_carriers_init { get; set; }
        public Squad_underhangar_carriers_02 underhangar_carriers_02 { get; set; }
        public Squad_underhangar_return_flood_01 underhangar_return_flood_01 { get; set; }
        public Squad_underhangar_return_flood_02 underhangar_return_flood_02 { get; set; }
        public Squad_underhangar_return_flood_03 underhangar_return_flood_03 { get; set; }
        public Squad_underhangar_return_flood_04 underhangar_return_flood_04 { get; set; }
        public Squad_first_hall_flood_01 first_hall_flood_01 { get; set; }
        public Squad_heretic_leader_hangar heretic_leader_hangar { get; set; }
        public Squad_boss_fight_combatforms boss_fight_combatforms { get; set; }
        public Squad_boss_fight_carriers boss_fight_carriers { get; set; }
        public Squad_boss_fight_sentinels boss_fight_sentinels { get; set; }
        public Squad_boss_fight_heretic_leader boss_fight_heretic_leader { get; set; }
        public Squad_boss_fight_hl_hologram_01 boss_fight_hl_hologram_01 { get; set; }
        public Squad_boss_fight_hl_hologram_02 boss_fight_hl_hologram_02 { get; set; }
        public Squad_hl_boss_random hl_boss_random { get; set; }
        public Squad_hl_boss_holo_random_01 hl_boss_holo_random_01 { get; set; }
        public Squad_hl_boss_holo_random_02 hl_boss_holo_random_02 { get; set; }
        public Squad_hl_boss_holo_random_03 hl_boss_holo_random_03 { get; set; }
        public Squad_hl_boss_last hl_boss_last { get; set; }
        public Squad_monitor1 monitor1 { get; set; }
        public Squad_hl_boss_holo_random_04 hl_boss_holo_random_04 { get; set; }
        public Squad_bait_hall_01 bait_hall_01 { get; set; }
        public Squad_bait_hall_02 bait_hall_02 { get; set; }
        public Squad_bait_hall_03 bait_hall_03 { get; set; }
        public Squad_bait_bottling_02 bait_bottling_02 { get; set; }
        public Squad_bait_bottling_01 bait_bottling_01 { get; set; }
        public Squad_famine_cf famine_cf { get; set; }
        public Squad_power_core_swords power_core_swords { get; set; }
        [SpawnCounts(1, 1)]
        public class Squad_disposal_commander : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_disposal_commander(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "all_allies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_allies_elites_03a : SquadBase
        {
            public IAiActorDefinition elite => Squad.StartingLocations[0];
            public Squad_allies_elites_03a(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "allies_elites")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_allies_elites_03b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_allies_elites_03b(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "allies_elites")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_allies_grunts_03 : SquadBase
        {
            public IAiActorDefinition grunt01 => Squad.StartingLocations[0];
            public IAiActorDefinition grunt02 => Squad.StartingLocations[1];
            public Squad_allies_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "arm02_allies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_disposal_entry_flood : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_disposal_entry_flood(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_disposal_entry_juggernaut : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_disposal_entry_juggernaut(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "all_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_disposal_entry_heretics : SquadBase
        {
            public IAiActorDefinition h4 => Squad.StartingLocations[0];
            public IAiActorDefinition h2 => Squad.StartingLocations[1];
            public IAiActorDefinition h3 => Squad.StartingLocations[2];
            public IAiActorDefinition h1 => Squad.StartingLocations[3];
            public Squad_disposal_entry_heretics(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_holo_drone : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_holo_drone(ScenarioTag ScenarioTag) : base(ScenarioTag, 7)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_hl_hologram : SquadBase
        {
            public IAiActorDefinition hl => Squad.StartingLocations[0];
            public Squad_hl_hologram(ScenarioTag ScenarioTag) : base(ScenarioTag, 8)
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_disposal_infection_01 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public IAiActorDefinition _5 => Squad.StartingLocations[4];
            public IAiActorDefinition _6 => Squad.StartingLocations[5];
            public IAiActorDefinition _7 => Squad.StartingLocations[6];
            public IAiActorDefinition _8 => Squad.StartingLocations[7];
            public Squad_disposal_infection_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "disposal_infection")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_disposal_infection_02 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public Squad_disposal_infection_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "disposal_infection")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_silo_sentinels_initial : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_silo_sentinels_initial(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "silo_sentinels_all")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_silo_sentinels_resupply : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public IAiActorDefinition _5 => Squad.StartingLocations[4];
            public IAiActorDefinition _6 => Squad.StartingLocations[5];
            public IAiActorDefinition _7 => Squad.StartingLocations[6];
            public IAiActorDefinition _8 => Squad.StartingLocations[7];
            public Squad_silo_sentinels_resupply(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "silo_sentinels_all")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_silo_flood_initial : SquadBase
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
            public Squad_silo_flood_initial(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "silo_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_silo_climbers_01 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_silo_climbers_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "silo_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_silo_climbers_02 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_silo_climbers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "silo_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_silo_sentinels_below : SquadBase
        {
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_silo_sentinels_below(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "silo_sentinels_all")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_silo_infection_01 : SquadBase
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
            public Squad_silo_infection_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "silo_infection")
            {
            }
        }

        [SpawnCounts(11, 11)]
        public class Squad_silo_infection_02 : SquadBase
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
            public Squad_silo_infection_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "silo_infection")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_silo_infection_03 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public IAiActorDefinition _5 => Squad.StartingLocations[4];
            public IAiActorDefinition _6 => Squad.StartingLocations[5];
            public IAiActorDefinition _7 => Squad.StartingLocations[6];
            public IAiActorDefinition _8 => Squad.StartingLocations[7];
            public Squad_silo_infection_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "silo_infection")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_silo_infection_04 : SquadBase
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
            public Squad_silo_infection_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "silo_infection")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_silo_heretics : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_silo_heretics(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "all_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_silo_sentinels_end : SquadBase
        {
            public Squad_silo_sentinels_end(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "silo_sentinels_all")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_silo_flood_halls : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_silo_flood_halls(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "silo_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_lab_heretics_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_lab_heretics_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "lab_heretics")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_lab_turret_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_lab_turret_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "lab_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_lab_heretics_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_lab_heretics_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "lab_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_lab_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition r => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition l => Squad.StartingLocations[3];
            public Squad_lab_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "lab_turrets")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_lab_exit_turrets : SquadBase
        {
            public IAiActorDefinition l => Squad.StartingLocations[0];
            public IAiActorDefinition r => Squad.StartingLocations[1];
            public Squad_lab_exit_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "lab_turrets")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_lab_combatforms_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_lab_combatforms_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "lab_flood")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_lab_combatforms_02 : SquadBase
        {
            public IAiActorDefinition r5 => Squad.StartingLocations[0];
            public IAiActorDefinition r4 => Squad.StartingLocations[1];
            public IAiActorDefinition r3 => Squad.StartingLocations[2];
            public IAiActorDefinition r2 => Squad.StartingLocations[3];
            public IAiActorDefinition r1 => Squad.StartingLocations[4];
            public IAiActorDefinition l1 => Squad.StartingLocations[5];
            public IAiActorDefinition l2 => Squad.StartingLocations[6];
            public IAiActorDefinition l3 => Squad.StartingLocations[7];
            public IAiActorDefinition l4 => Squad.StartingLocations[8];
            public IAiActorDefinition l5 => Squad.StartingLocations[9];
            public IAiActorDefinition c1 => Squad.StartingLocations[10];
            public IAiActorDefinition c2 => Squad.StartingLocations[11];
            public Squad_lab_combatforms_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "lab_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_lab_carriers_01 : SquadBase
        {
            public IAiActorDefinition init1 => Squad.StartingLocations[0];
            public IAiActorDefinition init2 => Squad.StartingLocations[1];
            public IAiActorDefinition init3 => Squad.StartingLocations[2];
            public IAiActorDefinition init4 => Squad.StartingLocations[3];
            public IAiActorDefinition _1 => Squad.StartingLocations[4];
            public IAiActorDefinition _2 => Squad.StartingLocations[5];
            public IAiActorDefinition _3 => Squad.StartingLocations[6];
            public IAiActorDefinition _4 => Squad.StartingLocations[7];
            public IAiActorDefinition _5 => Squad.StartingLocations[8];
            public IAiActorDefinition _6 => Squad.StartingLocations[9];
            public Squad_lab_carriers_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "lab_carriers")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_lab_carriers_02 : SquadBase
        {
            public IAiActorDefinition c1 => Squad.StartingLocations[0];
            public IAiActorDefinition c2 => Squad.StartingLocations[1];
            public IAiActorDefinition l1 => Squad.StartingLocations[2];
            public IAiActorDefinition l2 => Squad.StartingLocations[3];
            public IAiActorDefinition l3 => Squad.StartingLocations[4];
            public IAiActorDefinition l4 => Squad.StartingLocations[5];
            public IAiActorDefinition l5 => Squad.StartingLocations[6];
            public IAiActorDefinition r1 => Squad.StartingLocations[7];
            public IAiActorDefinition r2 => Squad.StartingLocations[8];
            public IAiActorDefinition r3 => Squad.StartingLocations[9];
            public IAiActorDefinition r4 => Squad.StartingLocations[10];
            public IAiActorDefinition r5 => Squad.StartingLocations[11];
            public Squad_lab_carriers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "lab_carriers")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_lab_infection_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_lab_infection_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "all_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_lab_infection_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_lab_infection_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "all_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_lab_heretics_above : SquadBase
        {
            public IAiActorDefinition h1 => Squad.StartingLocations[0];
            public IAiActorDefinition h2 => Squad.StartingLocations[1];
            public IAiActorDefinition h3 => Squad.StartingLocations[2];
            public IAiActorDefinition h4 => Squad.StartingLocations[3];
            public Squad_lab_heretics_above(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "lab_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_lab_juggernaut_above : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_lab_juggernaut_above(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "lab_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_strafer : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_strafer(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_allied_phantom_02 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_allied_phantom_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 38)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_allies_grunts_04 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public Squad_allies_grunts_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "core_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_allies_elites_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_allies_elites_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "core_allies")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_runners : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_runners(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_h_grunts_init : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_h_grunts_init(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_heretics_R_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bridge_heretics_R_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_h_grunts_R_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_h_grunts_R_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_heretics_R_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_heretics_R_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_sentinels_R_05 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public Squad_bridge_sentinels_R_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "bridge_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_heretics_L_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bridge_heretics_L_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_h_grunts_L_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_h_grunts_L_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_heretics_L_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bridge_heretics_L_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bridge_sentinels_L_05 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public IAiActorDefinition _2 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public Squad_bridge_sentinels_L_05(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "bridge_sentinels")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_bridge_heretics_final : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_bridge_heretics_final(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bridge_h_grunts_final : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bridge_h_grunts_final(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "bridge_heretics")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bridge_combatforms : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bridge_combatforms(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "bridge_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bridge_carriers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bridge_carriers(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "bridge_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_bridge_infection : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_bridge_infection(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_heretic_leader_control : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_heretic_leader_control(ScenarioTag ScenarioTag) : base(ScenarioTag, 56)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_control_commander_cinematic : SquadBase
        {
            public IAiActorDefinition spec_ops_comm => Squad.StartingLocations[0];
            public Squad_control_commander_cinematic(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "all_allies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_control_elites_cinematic : SquadBase
        {
            public IAiActorDefinition elite02 => Squad.StartingLocations[0];
            public IAiActorDefinition elite01 => Squad.StartingLocations[1];
            public Squad_control_elites_cinematic(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "all_allies")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_control_flood_wave_01_combat : SquadBase
        {
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_control_flood_wave_01_combat(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "control_flood")
            {
            }
        }

        [SpawnCounts(10, 10)]
        public class Squad_control_flood_wave_02_combat : SquadBase
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
            public Squad_control_flood_wave_02_combat(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "control_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_control_flood_wave_02_carriers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_control_flood_wave_02_carriers(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "control_flood")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_control_flood_wave_03_combat : SquadBase
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
            public Squad_control_flood_wave_03_combat(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "control_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_control_flood_wave_03_carriers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_control_flood_wave_03_carriers(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "control_flood")
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_control_infection : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[6];
            public Squad_control_infection(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "all_enemies")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_control_sentinels_wave_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_control_sentinels_wave_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "control_sentinels")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_control_sentinels_wave_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_control_sentinels_wave_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "control_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_allied_phantom_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_allied_phantom_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 67)
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_cableroom_flood_init : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_cableroom_flood_init(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "cable_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cableroom_sentinels_init : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_cableroom_sentinels_init(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "cable_sentinels")
            {
            }
        }

        [SpawnCounts(24, 24)]
        public class Squad_cable_room_combatforms : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_01 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_02 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_22 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_32 => Squad.StartingLocations[11];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[12];
            public IAiActorDefinition starting_locations_41 => Squad.StartingLocations[13];
            public IAiActorDefinition starting_locations_42 => Squad.StartingLocations[14];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[15];
            public IAiActorDefinition starting_locations_51 => Squad.StartingLocations[16];
            public IAiActorDefinition starting_locations_52 => Squad.StartingLocations[17];
            public Squad_cable_room_combatforms(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "cable_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_cable_room_sentinels : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_cable_room_sentinels(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "cable_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_control_return_heretics_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_control_return_heretics_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "control_return_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_control_return_heretics_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_control_return_heretics_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "control_return_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_control_return_h_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_control_return_h_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "control_return_heretics")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_control_return_heretics_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_control_return_heretics_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "control_return_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_control_return_h_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_control_return_h_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "control_return_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_control_return_sentinels_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_control_return_sentinels_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "control_return_sentinels")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_control_return_flood_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_control_return_flood_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "control_return_flood")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_control_return_flood_02 : SquadBase
        {
            public IAiActorDefinition mid01 => Squad.StartingLocations[0];
            public IAiActorDefinition mid02 => Squad.StartingLocations[1];
            public IAiActorDefinition peri01 => Squad.StartingLocations[2];
            public IAiActorDefinition peri02 => Squad.StartingLocations[3];
            public IAiActorDefinition peri03 => Squad.StartingLocations[4];
            public IAiActorDefinition peri04 => Squad.StartingLocations[5];
            public IAiActorDefinition mid03 => Squad.StartingLocations[6];
            public IAiActorDefinition mid04 => Squad.StartingLocations[7];
            public Squad_control_return_flood_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "control_return_flood")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_control_return_flood_03 : SquadBase
        {
            public IAiActorDefinition peri01 => Squad.StartingLocations[0];
            public IAiActorDefinition peri02 => Squad.StartingLocations[1];
            public IAiActorDefinition peri03 => Squad.StartingLocations[2];
            public IAiActorDefinition peri04 => Squad.StartingLocations[3];
            public IAiActorDefinition bott01 => Squad.StartingLocations[4];
            public IAiActorDefinition bott02 => Squad.StartingLocations[5];
            public IAiActorDefinition bott03 => Squad.StartingLocations[6];
            public IAiActorDefinition bott04 => Squad.StartingLocations[7];
            public Squad_control_return_flood_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "control_return_flood")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_control_return_flood_04 : SquadBase
        {
            public IAiActorDefinition bott01 => Squad.StartingLocations[0];
            public IAiActorDefinition bott02 => Squad.StartingLocations[1];
            public IAiActorDefinition bott03 => Squad.StartingLocations[2];
            public IAiActorDefinition bott04 => Squad.StartingLocations[3];
            public IAiActorDefinition entry01 => Squad.StartingLocations[4];
            public IAiActorDefinition entry02 => Squad.StartingLocations[5];
            public IAiActorDefinition entry03 => Squad.StartingLocations[6];
            public IAiActorDefinition entry04 => Squad.StartingLocations[7];
            public Squad_control_return_flood_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "control_return_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_control_return_carriers_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_control_return_carriers_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "control_return_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_control_return_carriers_02 : SquadBase
        {
            public IAiActorDefinition peri01 => Squad.StartingLocations[0];
            public IAiActorDefinition peri02 => Squad.StartingLocations[1];
            public IAiActorDefinition mid01 => Squad.StartingLocations[2];
            public IAiActorDefinition mid02 => Squad.StartingLocations[3];
            public Squad_control_return_carriers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "control_return_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_control_return_carriers_03 : SquadBase
        {
            public IAiActorDefinition bott01 => Squad.StartingLocations[0];
            public IAiActorDefinition bott02 => Squad.StartingLocations[1];
            public IAiActorDefinition peri01 => Squad.StartingLocations[2];
            public IAiActorDefinition peri02 => Squad.StartingLocations[3];
            public Squad_control_return_carriers_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "control_return_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_control_return_carriers_04 : SquadBase
        {
            public IAiActorDefinition bott01 => Squad.StartingLocations[0];
            public IAiActorDefinition bott02 => Squad.StartingLocations[1];
            public IAiActorDefinition entry01 => Squad.StartingLocations[2];
            public IAiActorDefinition entry02 => Squad.StartingLocations[3];
            public Squad_control_return_carriers_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "control_return_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_power_core_heretics_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_power_core_heretics_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "power_core_heretics")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_power_core_h_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_power_core_h_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "power_core_heretics")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_power_core_sentinels_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_power_core_sentinels_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "power_core_sentinels")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_power_core_combatforms : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_power_core_combatforms(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "power_core_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_power_core_carriers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_power_core_carriers(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "power_core_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ledge_banshees_02 : SquadBase
        {
            public IAiActorDefinition right => Squad.StartingLocations[0];
            public IAiActorDefinition left => Squad.StartingLocations[1];
            public Squad_ledge_banshees_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 91)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_heretic_leader_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_heretic_leader_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 92)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_dervish_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_dervish_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 93)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_dervish_02 : SquadBase
        {
            public IAiActorDefinition _1 => Squad.StartingLocations[0];
            public Squad_dervish_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 94)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_dervish_031 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_dervish_031(ScenarioTag ScenarioTag) : base(ScenarioTag, 95)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dogfighters_init : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_dogfighters_init(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "dogfighters")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_dogfighters_finale : SquadBase
        {
            public IAiActorDefinition _6 => Squad.StartingLocations[0];
            public IAiActorDefinition _5 => Squad.StartingLocations[1];
            public IAiActorDefinition _3 => Squad.StartingLocations[2];
            public IAiActorDefinition _4 => Squad.StartingLocations[3];
            public IAiActorDefinition _1 => Squad.StartingLocations[4];
            public IAiActorDefinition _2 => Squad.StartingLocations[5];
            public Squad_dogfighters_finale(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "dogfighters")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bottling_return_sentinels_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bottling_return_sentinels_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "bottling_return_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bottling_return_sentinels_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_bottling_return_sentinels_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "bottling_return_sentinels")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bottling_return_sentinels_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bottling_return_sentinels_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "bottling_return_sentinels")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_bottling_return_flood_01 : SquadBase
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
            public Squad_bottling_return_flood_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 101, "bottling_return_flood")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_bottling_return_combatforms_02 : SquadBase
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
            public Squad_bottling_return_combatforms_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 102, "bottling_return_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bottling_return_carriers_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bottling_return_carriers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 103, "bottling_return_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_bottling_return_combatforms_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_bottling_return_combatforms_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "bottling_return_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_bottling_return_carriers_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bottling_return_carriers_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 105, "bottling_return_flood")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_bottling_return_combatforms_04 : SquadBase
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
            public Squad_bottling_return_combatforms_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 106, "bottling_return_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bottling_return_carriers_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bottling_return_carriers_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 107, "bottling_return_flood")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_second_hall_infection_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_second_hall_infection_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 108, "all_enemies")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_second_hall_flood_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_second_hall_flood_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 109, "second_hall_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_second_hall_carriers : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_second_hall_carriers(ScenarioTag ScenarioTag) : base(ScenarioTag, 110, "second_hall_flood")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_second_hall_flood_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_second_hall_flood_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 111, "second_hall_flood")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_second_hall_infection_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_second_hall_infection_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 112, "all_enemies")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_second_hall_flood_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_second_hall_flood_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 113, "second_hall_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_underhangar_heretics_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_underhangar_heretics_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 114, "underhangar_return_heretics")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_underhangar_h_grunts_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_underhangar_h_grunts_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 115, "underhangar_return_heretics")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_underhangar_heretics_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_underhangar_heretics_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 116, "underhangar_return_heretics")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_underhangar_h_grunts_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_underhangar_h_grunts_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 117, "underhangar_return_heretics")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_underhangar_heretics_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_underhangar_heretics_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 118, "underhangar_return_heretics")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_underhangar_h_grunts_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_underhangar_h_grunts_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 119, "underhangar_return_heretics")
            {
            }
        }

        [SpawnCounts(9, 9)]
        public class Squad_underhangar_combatforms_init : SquadBase
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
            public Squad_underhangar_combatforms_init(ScenarioTag ScenarioTag) : base(ScenarioTag, 120, "underhangar_return_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_underhangar_carriers_init : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_underhangar_carriers_init(ScenarioTag ScenarioTag) : base(ScenarioTag, 121, "underhangar_return_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_underhangar_carriers_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_underhangar_carriers_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 122, "underhangar_return_flood")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_underhangar_return_flood_01 : SquadBase
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
            public Squad_underhangar_return_flood_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 123, "underhangar_return_flood")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_underhangar_return_flood_02 : SquadBase
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
            public Squad_underhangar_return_flood_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 124, "underhangar_return_flood")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_underhangar_return_flood_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_13 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_15 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_16 => Squad.StartingLocations[11];
            public Squad_underhangar_return_flood_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 125, "underhangar_return_flood")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_underhangar_return_flood_04 : SquadBase
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
            public Squad_underhangar_return_flood_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 126, "underhangar_return_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_first_hall_flood_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_first_hall_flood_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 127, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_heretic_leader_hangar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_heretic_leader_hangar(ScenarioTag ScenarioTag) : base(ScenarioTag, 128)
            {
            }
        }

        [SpawnCounts(32, 32)]
        public class Squad_boss_fight_combatforms : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_15 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_17 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_18 => Squad.StartingLocations[11];
            public IAiActorDefinition starting_locations_20 => Squad.StartingLocations[12];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[13];
            public IAiActorDefinition starting_locations_24 => Squad.StartingLocations[14];
            public IAiActorDefinition starting_locations_25 => Squad.StartingLocations[15];
            public IAiActorDefinition starting_locations_28 => Squad.StartingLocations[16];
            public IAiActorDefinition starting_locations_29 => Squad.StartingLocations[17];
            public IAiActorDefinition starting_locations_30 => Squad.StartingLocations[18];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[19];
            public IAiActorDefinition starting_locations_201 => Squad.StartingLocations[20];
            public IAiActorDefinition starting_locations_211 => Squad.StartingLocations[21];
            public IAiActorDefinition starting_locations_22 => Squad.StartingLocations[22];
            public IAiActorDefinition starting_locations_23 => Squad.StartingLocations[23];
            public IAiActorDefinition starting_locations_241 => Squad.StartingLocations[24];
            public IAiActorDefinition starting_locations_251 => Squad.StartingLocations[25];
            public IAiActorDefinition starting_locations_26 => Squad.StartingLocations[26];
            public IAiActorDefinition starting_locations_27 => Squad.StartingLocations[27];
            public IAiActorDefinition starting_locations_281 => Squad.StartingLocations[28];
            public IAiActorDefinition starting_locations_291 => Squad.StartingLocations[29];
            public IAiActorDefinition starting_locations_301 => Squad.StartingLocations[30];
            public IAiActorDefinition starting_locations_311 => Squad.StartingLocations[31];
            public Squad_boss_fight_combatforms(ScenarioTag ScenarioTag) : base(ScenarioTag, 129, "hangar_return_flood")
            {
            }
        }

        [SpawnCounts(10, 10)]
        public class Squad_boss_fight_carriers : SquadBase
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
            public Squad_boss_fight_carriers(ScenarioTag ScenarioTag) : base(ScenarioTag, 130, "hangar_return_flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_boss_fight_sentinels : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_boss_fight_sentinels(ScenarioTag ScenarioTag) : base(ScenarioTag, 131, "hangar_return_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_boss_fight_heretic_leader : SquadBase
        {
            public IAiActorDefinition hl => Squad.StartingLocations[0];
            public Squad_boss_fight_heretic_leader(ScenarioTag ScenarioTag) : base(ScenarioTag, 132, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_boss_fight_hl_hologram_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_boss_fight_hl_hologram_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 133, "holo_drones")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_boss_fight_hl_hologram_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_boss_fight_hl_hologram_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 134, "holo_drones")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hl_boss_random : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hl_boss_random(ScenarioTag ScenarioTag) : base(ScenarioTag, 135, "all_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hl_boss_holo_random_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hl_boss_holo_random_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 136, "holo_drones")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hl_boss_holo_random_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hl_boss_holo_random_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 137, "holo_drones")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hl_boss_holo_random_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hl_boss_holo_random_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 138, "holo_drones")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hl_boss_last : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hl_boss_last(ScenarioTag ScenarioTag) : base(ScenarioTag, 139, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_monitor1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_monitor1(ScenarioTag ScenarioTag) : base(ScenarioTag, 140)
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_hl_boss_holo_random_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_hl_boss_holo_random_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 141, "holo_drones")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bait_hall_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bait_hall_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 142, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bait_hall_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bait_hall_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 143, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bait_hall_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bait_hall_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 144, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bait_bottling_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bait_bottling_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 145, "all_enemies")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bait_bottling_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bait_bottling_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 146, "all_enemies")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_famine_cf : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_famine_cf(ScenarioTag ScenarioTag) : base(ScenarioTag, 147, "all_enemies")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_power_core_swords : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_power_core_swords(ScenarioTag ScenarioTag) : base(ScenarioTag, 148, "power_core_heretics")
            {
            }
        }
    }
}