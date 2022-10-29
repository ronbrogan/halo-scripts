namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_08b_deltacontrol : ScenarioScriptBase
    {
        public Squad_e1_cov_wraiths0_0 e1_cov_wraiths0_0 { get; set; }
        public Squad_e1_cov_wraiths0_1 e1_cov_wraiths0_1 { get; set; }
        public Squad_e1_cov_spectre0 e1_cov_spectre0 { get; set; }
        public Squad_e1_pro_ghosts0_0 e1_pro_ghosts0_0 { get; set; }
        public Squad_e1_pro_ghosts0_1 e1_pro_ghosts0_1 { get; set; }
        public Squad_e1_pro_ghosts0_2 e1_pro_ghosts0_2 { get; set; }
        public Squad_e1_pro_inf0_0 e1_pro_inf0_0 { get; set; }
        public Squad_e1_pro_inf0_1 e1_pro_inf0_1 { get; set; }
        public Squad_e1_pro_wraith0 e1_pro_wraith0 { get; set; }
        public Squad_e1_pro_phantom0 e1_pro_phantom0 { get; set; }
        public Squad_e2_cov_wraith0 e2_cov_wraith0 { get; set; }
        public Squad_e2_cov_spectre0 e2_cov_spectre0 { get; set; }
        public Squad_e2_pro_inf0 e2_pro_inf0 { get; set; }
        public Squad_e2_pro_ghosts0_0 e2_pro_ghosts0_0 { get; set; }
        public Squad_e2_pro_ghosts0_1 e2_pro_ghosts0_1 { get; set; }
        public Squad_e2_pro_wraith0_0 e2_pro_wraith0_0 { get; set; }
        public Squad_e2_pro_wraith0_1 e2_pro_wraith0_1 { get; set; }
        public Squad_e2_pro_phantom0_0 e2_pro_phantom0_0 { get; set; }
        public Squad_e2_pro_phantom0_1 e2_pro_phantom0_1 { get; set; }
        public Squad_e3_cov_inf0 e3_cov_inf0 { get; set; }
        public Squad_e3_cov_hunters0 e3_cov_hunters0 { get; set; }
        public Squad_e3_pro_inf0_0 e3_pro_inf0_0 { get; set; }
        public Squad_e3_pro_inf0_1 e3_pro_inf0_1 { get; set; }
        public Squad_e3_pro_inf1 e3_pro_inf1 { get; set; }
        public Squad_e3_pro_inf2 e3_pro_inf2 { get; set; }
        public Squad_e4_cov_inf0 e4_cov_inf0 { get; set; }
        public Squad_e4_cov_hunters0 e4_cov_hunters0 { get; set; }
        public Squad_e4_pro_inf0 e4_pro_inf0 { get; set; }
        public Squad_e4_pro_inf1 e4_pro_inf1 { get; set; }
        public Squad_e4_pro_inf2 e4_pro_inf2 { get; set; }
        public Squad_e4_pro_inf3 e4_pro_inf3 { get; set; }
        public Squad_e5_cov_inf0 e5_cov_inf0 { get; set; }
        public Squad_e5_cov_hunters0 e5_cov_hunters0 { get; set; }
        public Squad_e5_cov_grunts0 e5_cov_grunts0 { get; set; }
        public Squad_e5_cov_banshees0 e5_cov_banshees0 { get; set; }
        public Squad_e5_pro_inf0 e5_pro_inf0 { get; set; }
        public Squad_e5_pro_inf1 e5_pro_inf1 { get; set; }
        public Squad_e5_pro_inf2 e5_pro_inf2 { get; set; }
        public Squad_e5_pro_inf3 e5_pro_inf3 { get; set; }
        public Squad_e5_pro_phantom0 e5_pro_phantom0 { get; set; }
        public Squad_control_room_test control_room_test { get; set; }
        public Squad_e6_cov_inf0 e6_cov_inf0 { get; set; }
        public Squad_e6_cov_inf1_0 e6_cov_inf1_0 { get; set; }
        public Squad_e6_cov_inf1_1 e6_cov_inf1_1 { get; set; }
        public Squad_e6_cov_inf1_2 e6_cov_inf1_2 { get; set; }
        public Squad_e6_cov_inf1_3 e6_cov_inf1_3 { get; set; }
        public Squad_e6_cov_hunters0 e6_cov_hunters0 { get; set; }
        public Squad_e6_pro_inf0_0 e6_pro_inf0_0 { get; set; }
        public Squad_e6_pro_inf0_1 e6_pro_inf0_1 { get; set; }
        public Squad_e6_pro_inf0_2 e6_pro_inf0_2 { get; set; }
        public Squad_____SCARAB_RIDE____1 ____SCARAB_RIDE____1 { get; set; }
        public Squad_scarab_gunners scarab_gunners { get; set; }
        public Squad_e7_cov_inf0 e7_cov_inf0 { get; set; }
        public Squad_e7_cov_hunters0 e7_cov_hunters0 { get; set; }
        public Squad_e7_pro_inf0 e7_pro_inf0 { get; set; }
        public Squad_e7_mars_inf0 e7_mars_inf0 { get; set; }
        public Squad_e7_mars_inf1 e7_mars_inf1 { get; set; }
        public Squad_e8_cov_inf0 e8_cov_inf0 { get; set; }
        public Squad_e8_cov_banshees0 e8_cov_banshees0 { get; set; }
        public Squad_e8_mars_inf0 e8_mars_inf0 { get; set; }
        public Squad_e8_pro_wraiths0_0 e8_pro_wraiths0_0 { get; set; }
        public Squad_e8_pro_wraiths0_1 e8_pro_wraiths0_1 { get; set; }
        public Squad_e8_pro_wraiths0_2 e8_pro_wraiths0_2 { get; set; }
        public Squad_e9_pro_inf0 e9_pro_inf0 { get; set; }
        public Squad_e9_pro_inf3_0 e9_pro_inf3_0 { get; set; }
        public Squad_e9_pro_inf3_1 e9_pro_inf3_1 { get; set; }
        public Squad_e9_pro_phantom0 e9_pro_phantom0 { get; set; }
        public Squad_e9_pro_phantom1 e9_pro_phantom1 { get; set; }
        public Squad_e9_pro_spectres0_0 e9_pro_spectres0_0 { get; set; }
        public Squad_e9_pro_spectres0_1 e9_pro_spectres0_1 { get; set; }
        public Squad_e9_pro_banshees0 e9_pro_banshees0 { get; set; }
        public Squad_e10_cov_banshees0 e10_cov_banshees0 { get; set; }
        public Squad_e11_cov_banshees0 e11_cov_banshees0 { get; set; }
        public Squad_e11_pro_wraith0_0 e11_pro_wraith0_0 { get; set; }
        public Squad_e11_pro_wraith0_1 e11_pro_wraith0_1 { get; set; }
        public Squad_e11_pro_wraith1_0 e11_pro_wraith1_0 { get; set; }
        public Squad_e11_pro_wraith1_1 e11_pro_wraith1_1 { get; set; }
        public Squad_e11_pro_wraith1_2 e11_pro_wraith1_2 { get; set; }
        public Squad_e11_pro_wraith1_3 e11_pro_wraith1_3 { get; set; }
        public Squad_e11_pro_phantom0_0 e11_pro_phantom0_0 { get; set; }
        public Squad_e11_pro_phantom0_1 e11_pro_phantom0_1 { get; set; }
        public Squad_e11_pro_ghosts0 e11_pro_ghosts0 { get; set; }
        public Squad_e11_pro_spectres0 e11_pro_spectres0 { get; set; }
        public Squad_e11_pro_banshees0_0 e11_pro_banshees0_0 { get; set; }
        public Squad_e11_pro_banshees0_1 e11_pro_banshees0_1 { get; set; }
        public Squad_____CONTROL_ROOM____1 ____CONTROL_ROOM____1 { get; set; }
        public Squad_e12_cov_inf0_0 e12_cov_inf0_0 { get; set; }
        public Squad_e12_cov_inf0_1 e12_cov_inf0_1 { get; set; }
        public Squad_e12_cov_phantom0 e12_cov_phantom0 { get; set; }
        public Squad_e12_cov_banshees0 e12_cov_banshees0 { get; set; }
        public Squad_e12_pro_inf0_0 e12_pro_inf0_0 { get; set; }
        public Squad_e12_pro_inf0_1 e12_pro_inf0_1 { get; set; }
        public Squad_e12_pro_inf0_2 e12_pro_inf0_2 { get; set; }
        public Squad_e13_cov_inf0_0 e13_cov_inf0_0 { get; set; }
        public Squad_e13_cov_inf0_1 e13_cov_inf0_1 { get; set; }
        public Squad_e13_mars_johnson e13_mars_johnson { get; set; }
        public Squad_e13_mars_miranda e13_mars_miranda { get; set; }
        public Squad_e13_pro_tartarus e13_pro_tartarus { get; set; }
        public Squad_e13_pro_inf0_0 e13_pro_inf0_0 { get; set; }
        public Squad_e13_pro_inf0_1 e13_pro_inf0_1 { get; set; }
        public Squad_e13_sen_monitor e13_sen_monitor { get; set; }
        public Squad_test1 test1 { get; set; }
        public Squad_boss_tartarus boss_tartarus { get; set; }
        public Squad_boss_johnson boss_johnson { get; set; }
        public Squad_boss_brute_start boss_brute_start { get; set; }
        public Squad_boss_elite_start boss_elite_start { get; set; }
        public Squad_boss_monitor1 boss_monitor1 { get; set; }
        public Squad_boss_miranda1 boss_miranda1 { get; set; }
        public Squad_boss_brute_reenforcements1 boss_brute_reenforcements1 { get; set; }
        public Squad_boss_elite_reenforcements1 boss_elite_reenforcements1 { get; set; }
        public Squad_boss_brute_reenforcements_many boss_brute_reenforcements_many { get; set; }
        public Squad_boss_elite_reenforcements_many boss_elite_reenforcements_many { get; set; }
        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_wraiths0_0 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e1_cov_wraiths0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "e1_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_wraiths0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e1_cov_wraiths0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "e1_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_spectre0 : SquadBase
        {
            public IAiActorDefinition spectre0 => Squad.StartingLocations[0];
            public Squad_e1_cov_spectre0(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "e1_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e1_pro_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_pro_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "e1_pro_ghosts0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e1_pro_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_pro_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "e1_pro_ghosts0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e1_pro_ghosts0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_pro_ghosts0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "e1_pro_ghosts0")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e1_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e1_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "e1_pro_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e1_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e1_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "e1_pro_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_pro_wraith0 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e1_pro_wraith0(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "e1_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_pro_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e1_pro_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "e1_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e2_cov_wraith0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e2_cov_wraith0(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "e2_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e2_cov_spectre0 : SquadBase
        {
            public IAiActorDefinition spectre0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e2_cov_spectre0(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "e2_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e2_pro_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e2_pro_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "e2_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e2_pro_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition ghost0 => Squad.StartingLocations[2];
            public IAiActorDefinition ghost1 => Squad.StartingLocations[3];
            public Squad_e2_pro_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "e2_pro_ghosts0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e2_pro_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition ghost0 => Squad.StartingLocations[2];
            public IAiActorDefinition ghost1 => Squad.StartingLocations[3];
            public Squad_e2_pro_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "e2_pro_ghosts0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e2_pro_wraith0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e2_pro_wraith0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "e2_pro_wraith0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e2_pro_wraith0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e2_pro_wraith0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "e2_pro_wraith0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e2_pro_phantom0_0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e2_pro_phantom0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "e2_pro_phantom0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e2_pro_phantom0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e2_pro_phantom0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "e2_pro_phantom0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e3_cov_inf0 : SquadBase
        {
            public IAiActorDefinition elite0 => Squad.StartingLocations[0];
            public Squad_e3_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "e3_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e3_cov_hunters0 : SquadBase
        {
            public IAiActorDefinition hunter0 => Squad.StartingLocations[0];
            public IAiActorDefinition hunter1 => Squad.StartingLocations[1];
            public Squad_e3_cov_hunters0(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "e3_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e3_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e3_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "e3_pro_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e3_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e3_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "e3_pro_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e3_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e3_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "e3_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e3_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e3_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "e3_pro_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e4_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e4_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "e4_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e4_cov_hunters0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e4_cov_hunters0(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "e4_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e4_pro_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e4_pro_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "e4_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e4_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public Squad_e4_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "e4_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e4_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e4_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "e4_pro")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e4_pro_inf3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e4_pro_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "e4_pro")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e5_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e5_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "e5_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e5_cov_hunters0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e5_cov_hunters0(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "e5_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e5_cov_grunts0 : SquadBase
        {
            public Squad_e5_cov_grunts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "e5_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e5_cov_banshees0 : SquadBase
        {
            public Squad_e5_cov_banshees0(ScenarioTag ScenarioTag) : base(ScenarioTag, 34)
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e5_pro_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e5_pro_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "e5_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e5_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e5_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "e5_pro")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e5_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e5_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "e5_pro")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e5_pro_inf3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e5_pro_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "e5_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e5_pro_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e5_pro_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "e5_pro")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_control_room_test : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_control_room_test(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "prophets")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e6_cov_inf0 : SquadBase
        {
            public IAiActorDefinition elite0 => Squad.StartingLocations[0];
            public IAiActorDefinition elite1 => Squad.StartingLocations[1];
            public IAiActorDefinition elite2 => Squad.StartingLocations[2];
            public Squad_e6_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "e6_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e6_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e6_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "e6_cov_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e6_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e6_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "e6_cov_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e6_cov_inf1_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e6_cov_inf1_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "e6_cov_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e6_cov_inf1_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e6_cov_inf1_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "e6_cov_inf1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_cov_hunters0 : SquadBase
        {
            public IAiActorDefinition hunter0 => Squad.StartingLocations[0];
            public IAiActorDefinition hunter1 => Squad.StartingLocations[1];
            public Squad_e6_cov_hunters0(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "e6_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e6_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e6_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "e6_pro_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e6_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e6_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "e6_pro_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e6_pro_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e6_pro_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "e6_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_____SCARAB_RIDE____1 : SquadBase
        {
            public Squad_____SCARAB_RIDE____1(ScenarioTag ScenarioTag) : base(ScenarioTag, 50)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_scarab_gunners : SquadBase
        {
            public IAiActorDefinition main_gunner => Squad.StartingLocations[0];
            public IAiActorDefinition upper_gunner => Squad.StartingLocations[1];
            public IAiActorDefinition rear_gunner => Squad.StartingLocations[2];
            public Squad_scarab_gunners(ScenarioTag ScenarioTag) : base(ScenarioTag, 51)
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e7_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e7_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "e7_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e7_cov_hunters0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e7_cov_hunters0(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "e7_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e7_pro_inf0 : SquadBase
        {
            public IAiActorDefinition captain => Squad.StartingLocations[0];
            public IAiActorDefinition guard0 => Squad.StartingLocations[1];
            public IAiActorDefinition sentry1 => Squad.StartingLocations[2];
            public IAiActorDefinition sentry0 => Squad.StartingLocations[3];
            public Squad_e7_pro_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "e7_pro")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e7_mars_inf0 : SquadBase
        {
            public IAiActorDefinition johnson0 => Squad.StartingLocations[0];
            public IAiActorDefinition marine2 => Squad.StartingLocations[1];
            public IAiActorDefinition marine0 => Squad.StartingLocations[2];
            public Squad_e7_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "e7_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e7_mars_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e7_mars_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "e7_mars")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e8_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e8_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "e8_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e8_cov_banshees0 : SquadBase
        {
            public IAiActorDefinition banshee0 => Squad.StartingLocations[0];
            public IAiActorDefinition banshee1 => Squad.StartingLocations[1];
            public IAiActorDefinition banshee2 => Squad.StartingLocations[2];
            public IAiActorDefinition banshee3 => Squad.StartingLocations[3];
            public IAiActorDefinition banshee4 => Squad.StartingLocations[4];
            public Squad_e8_cov_banshees0(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "e8_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e8_mars_inf0 : SquadBase
        {
            public IAiActorDefinition johnson => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e8_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "e8_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e8_pro_wraiths0_0 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e8_pro_wraiths0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "e8_pro_wraiths0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e8_pro_wraiths0_1 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e8_pro_wraiths0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "e8_pro_wraiths0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e8_pro_wraiths0_2 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e8_pro_wraiths0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "e8_pro_wraiths0")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e9_pro_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e9_pro_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "e9_pro")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_pro_inf3_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e9_pro_inf3_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "e9_pro_inf3")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e9_pro_inf3_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e9_pro_inf3_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "e9_pro_inf3")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e9_pro_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e9_pro_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "e9_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e9_pro_phantom1 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e9_pro_phantom1(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "e9_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_pro_spectres0_0 : SquadBase
        {
            public IAiActorDefinition spectre0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e9_pro_spectres0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "e9_pro_spectres0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_pro_spectres0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_pro_spectres0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "e9_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e9_pro_banshees0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e9_pro_banshees0(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "e9_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_cov_banshees0 : SquadBase
        {
            public IAiActorDefinition banshee0 => Squad.StartingLocations[0];
            public IAiActorDefinition banshee1 => Squad.StartingLocations[1];
            public Squad_e10_cov_banshees0(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "e10_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e11_cov_banshees0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e11_cov_banshees0(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "e10_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_wraith0_0 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e11_pro_wraith0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "e11_pro_wraith0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_wraith0_1 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e11_pro_wraith0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "e11_pro_wraith0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_wraith1_0 : SquadBase
        {
            public IAiActorDefinition wraith => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_e11_pro_wraith1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "e11_pro_wraith1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_wraith1_1 : SquadBase
        {
            public IAiActorDefinition wraith => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_e11_pro_wraith1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "e11_pro_wraith1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_wraith1_2 : SquadBase
        {
            public IAiActorDefinition wraith => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_e11_pro_wraith1_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "e11_pro_wraith1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_wraith1_3 : SquadBase
        {
            public IAiActorDefinition wraith => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_e11_pro_wraith1_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "e11_pro_wraith1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_phantom0_0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e11_pro_phantom0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "e11_pro_phantom0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_phantom0_1 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e11_pro_phantom0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "e11_pro_phantom0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_ghosts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e11_pro_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "e11_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e11_pro_spectres0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e11_pro_spectres0(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "e11_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_banshees0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e11_pro_banshees0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "e11_pro_banshees0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_banshees0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e11_pro_banshees0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "e11_pro_banshees0")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_____CONTROL_ROOM____1 : SquadBase
        {
            public Squad_____CONTROL_ROOM____1(ScenarioTag ScenarioTag) : base(ScenarioTag, 85)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition elite1 => Squad.StartingLocations[0];
            public IAiActorDefinition elite0 => Squad.StartingLocations[1];
            public Squad_e12_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition elite0 => Squad.StartingLocations[0];
            public IAiActorDefinition elite1 => Squad.StartingLocations[1];
            public IAiActorDefinition elite2 => Squad.StartingLocations[2];
            public Squad_e12_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e12_cov_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e12_cov_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "e12_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e12_cov_banshees0 : SquadBase
        {
            public IAiActorDefinition banshee0 => Squad.StartingLocations[0];
            public Squad_e12_cov_banshees0(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "e12_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition brute0 => Squad.StartingLocations[0];
            public IAiActorDefinition brute1 => Squad.StartingLocations[1];
            public Squad_e12_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "e12_pro_inf0")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e12_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition berserker0 => Squad.StartingLocations[3];
            public IAiActorDefinition berserker1 => Squad.StartingLocations[4];
            public Squad_e12_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "e12_pro_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_pro_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition berserker => Squad.StartingLocations[2];
            public Squad_e12_pro_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "e12_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "e13_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e13_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e13_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 94, "e13_cov_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e13_mars_johnson : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e13_mars_johnson(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "e13_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e13_mars_miranda : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e13_mars_miranda(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "e13_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e13_pro_tartarus : SquadBase
        {
            public IAiActorDefinition tartarus0 => Squad.StartingLocations[0];
            public Squad_e13_pro_tartarus(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "e13_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "e13_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e13_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "e13_pro_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e13_sen_monitor : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e13_sen_monitor(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "e13_sen")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_test1 : SquadBase
        {
            public IAiActorDefinition wraith => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_test1(ScenarioTag ScenarioTag) : base(ScenarioTag, 101)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_boss_tartarus : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_boss_tartarus(ScenarioTag ScenarioTag) : base(ScenarioTag, 102)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_boss_johnson : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_boss_johnson(ScenarioTag ScenarioTag) : base(ScenarioTag, 103)
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_boss_brute_start : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_boss_brute_start(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "boss_brute_reenforcements")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_boss_elite_start : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_boss_elite_start(ScenarioTag ScenarioTag) : base(ScenarioTag, 105)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_boss_monitor1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_boss_monitor1(ScenarioTag ScenarioTag) : base(ScenarioTag, 106)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_boss_miranda1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_boss_miranda1(ScenarioTag ScenarioTag) : base(ScenarioTag, 107)
            {
            }
        }

        [SpawnCounts(2, 3)]
        public class Squad_boss_brute_reenforcements1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_boss_brute_reenforcements1(ScenarioTag ScenarioTag) : base(ScenarioTag, 108, "boss_brute_reenforcements")
            {
            }
        }

        [SpawnCounts(3, 2)]
        public class Squad_boss_elite_reenforcements1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_boss_elite_reenforcements1(ScenarioTag ScenarioTag) : base(ScenarioTag, 109, "boss_elite_reenforcements")
            {
            }
        }

        [SpawnCounts(3, 4)]
        public class Squad_boss_brute_reenforcements_many : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_boss_brute_reenforcements_many(ScenarioTag ScenarioTag) : base(ScenarioTag, 110, "boss_brute_reenforcements")
            {
            }
        }

        [SpawnCounts(4, 3)]
        public class Squad_boss_elite_reenforcements_many : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_boss_elite_reenforcements_many(ScenarioTag ScenarioTag) : base(ScenarioTag, 111, "boss_elite_reenforcements")
            {
            }
        }
    }
}