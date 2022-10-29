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
        public Squad_____GHOST_SECTION____2 ____GHOST_SECTION____2 { get; set; }
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
        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e1_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "e1_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_inf1 : SquadBase
        {
            public IAiActorDefinition stealth_major => Squad.StartingLocations[0];
            public Squad_e1_cov_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "e1_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e1_cov_inf2 : SquadBase
        {
            public IAiActorDefinition gold_elite => Squad.StartingLocations[0];
            public IAiActorDefinition elite1 => Squad.StartingLocations[1];
            public IAiActorDefinition elite2 => Squad.StartingLocations[2];
            public Squad_e1_cov_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "e1_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_phantom0 : SquadBase
        {
            public Squad_e1_cov_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "e1_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition brute0 => Squad.StartingLocations[0];
            public Squad_e1_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "e1_pro_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition brute0 => Squad.StartingLocations[0];
            public Squad_e1_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "e1_pro_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_pro_inf0_1_1 : SquadBase
        {
            public IAiActorDefinition brute0 => Squad.StartingLocations[0];
            public Squad_e1_pro_inf0_1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "e1_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e1_pro_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e1_pro_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "e1_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e1_pro_inf0_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e1_pro_inf0_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "e1_pro_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_pro_inf1 : SquadBase
        {
            public IAiActorDefinition brute0 => Squad.StartingLocations[0];
            public Squad_e1_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "prophets")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e2_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition stealth_major => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public Squad_e2_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "e2_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e2_cov_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e2_cov_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "e2_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e2_cov_gold_elite : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e2_cov_gold_elite(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "e2_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e2_cov_grunts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition grunt0 => Squad.StartingLocations[1];
            public Squad_e2_cov_grunts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "e2_cov")
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
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e2_pro_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "e2_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e2_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e2_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "e2_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e2_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e2_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "e2_pro")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e2_pro_inf3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e2_pro_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "e2_pro")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e3_cov_inf0 : SquadBase
        {
            public IAiActorDefinition stealth_major => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e3_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "e3_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e3_cov_gold_elite : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e3_cov_gold_elite(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "e3_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e3_cov_grunts0 : SquadBase
        {
            public IAiActorDefinition grunt0 => Squad.StartingLocations[0];
            public Squad_e3_cov_grunts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "e3_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e3_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
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
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_e3_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "e3_pro_inf0")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e3_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e3_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 23)
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e4_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e4_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "e4_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e4_cov_gold_elite : SquadBase
        {
            public Squad_e4_cov_gold_elite(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "e4_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e4_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e4_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "e4_pro_inf0")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e4_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e4_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "e4_pro_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e4_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e4_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "e4_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e4_pro_inf2_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e4_pro_inf2_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "e4_pro_inf2")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e4_pro_inf2_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e4_pro_inf2_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "e4_pro_inf2")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e5_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e5_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "e5_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e5_cov_gold_elite : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e5_cov_gold_elite(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "e5_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e5_cov_grunts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e5_cov_grunts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "e5_cov")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e5_pro_inf0 : SquadBase
        {
            public IAiActorDefinition turret0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[5];
            public Squad_e5_pro_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "e5_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e5_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e5_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "e5_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e6_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "e6_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_cov_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e6_cov_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "e6_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e6_cov_gold_elite : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e6_cov_gold_elite(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "e6_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public IAiActorDefinition ghost2 => Squad.StartingLocations[1];
            public Squad_e6_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "e6_cov")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e6_cov_grunts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e6_cov_grunts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "e6_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e6_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "e6_pro_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e6_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e6_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "e6_pro_inf0")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e6_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e6_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "e6_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e6_pro_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e6_pro_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "e6_pro")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_____GHOST_SECTION____2 : SquadBase
        {
            public Squad_____GHOST_SECTION____2(ScenarioTag ScenarioTag) : base(ScenarioTag, 45)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e7_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e7_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "e7_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e7_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public Squad_e7_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "e7_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e7_cov_ghosts1 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public IAiActorDefinition ghost1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e7_cov_ghosts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "e7_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e7_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e7_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "e7_pro_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e7_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition turret0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e7_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "e7_pro_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e7_pro_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e7_pro_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "e7_pro_inf1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e7_pro_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e7_pro_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "e7_pro_inf1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e7_pro_inf1_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e7_pro_inf1_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "e7_pro_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e7_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e7_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "e7_pro")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e8_cov_inf0 : SquadBase
        {
            public IAiActorDefinition turret0 => Squad.StartingLocations[0];
            public IAiActorDefinition grunt0 => Squad.StartingLocations[1];
            public IAiActorDefinition grunt1 => Squad.StartingLocations[2];
            public IAiActorDefinition grunt2 => Squad.StartingLocations[3];
            public IAiActorDefinition ghost0 => Squad.StartingLocations[4];
            public IAiActorDefinition ghost1 => Squad.StartingLocations[5];
            public Squad_e8_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "e8_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e8_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "e8_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_pro_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_e8_pro_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "e8_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_pro_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[1];
            public Squad_e8_pro_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "e8_pro_inf1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e8_pro_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e8_pro_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "e8_pro_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e8_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e8_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "e8_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_pro_spectre0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e8_pro_spectre0(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "e8_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e9_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e9_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "e9_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "e9_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "e9_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_pro_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_pro_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "e9_pro_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e9_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e9_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "e9_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e9_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e9_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "e9_pro")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_pro_inf3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_pro_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "e9_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e9_pro_phantom0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e9_pro_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "e9_pro")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e10_cov_inf0 : SquadBase
        {
            public IAiActorDefinition elite0 => Squad.StartingLocations[0];
            public IAiActorDefinition elite1 => Squad.StartingLocations[1];
            public IAiActorDefinition elite2 => Squad.StartingLocations[2];
            public IAiActorDefinition elite3 => Squad.StartingLocations[3];
            public Squad_e10_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "e10_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e10_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e10_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "e10_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_pro_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_pro_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "e10_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_pro_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_pro_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "e10_pro_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_pro_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_pro_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "e10_pro_inf1")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e10_pro_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public Squad_e10_pro_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "e10_pro_inf1")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e10_pro_inf1_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e10_pro_inf1_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "e10_pro_inf1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e10_pro_inf2_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e10_pro_inf2_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "e10_pro_inf2")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e10_pro_inf2_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e10_pro_inf2_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "e10_pro_inf2")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_pro_inf3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_pro_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "e10_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e10_pro_wraith0_0 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e10_pro_wraith0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "e10_pro_wraith0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e10_pro_wraith0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e10_pro_wraith0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "e10_pro_wraith0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e10_pro_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e10_pro_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "e10_pro")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e10_pro_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e10_pro_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "e10_pro_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_pro_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_pro_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "e10_pro_ghosts0")
            {
            }
        }
    }
}