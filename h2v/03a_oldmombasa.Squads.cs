namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_03a_oldmombasa : ScenarioScriptBase
    {
        public Squad_e1_mars_johnson e1_mars_johnson { get; set; }
        public Squad_e1_mars_inf0 e1_mars_inf0 { get; set; }
        public Squad_e1_mars_inf1 e1_mars_inf1 { get; set; }
        public Squad_e1_mars_inf2 e1_mars_inf2 { get; set; }
        public Squad_e1_mars_pelican0 e1_mars_pelican0 { get; set; }
        public Squad_e1_cov_inf0_0 e1_cov_inf0_0 { get; set; }
        public Squad_e1_cov_inf0_1 e1_cov_inf0_1 { get; set; }
        public Squad_e1_cov_inf0_2 e1_cov_inf0_2 { get; set; }
        public Squad_e1_cov_inf0_3 e1_cov_inf0_3 { get; set; }
        public Squad_e1_cov_inf1_0 e1_cov_inf1_0 { get; set; }
        public Squad_e1_cov_inf1_1 e1_cov_inf1_1 { get; set; }
        public Squad_e1_cov_inf2_0 e1_cov_inf2_0 { get; set; }
        public Squad_e1_cov_inf2_1 e1_cov_inf2_1 { get; set; }
        public Squad_e1_cov_inf2_2 e1_cov_inf2_2 { get; set; }
        public Squad_e1_cov_inf2_3 e1_cov_inf2_3 { get; set; }
        public Squad_e1_cov_inf2_4 e1_cov_inf2_4 { get; set; }
        public Squad_e1_cov_inf2_5 e1_cov_inf2_5 { get; set; }
        public Squad_e1_cov_inf2_6 e1_cov_inf2_6 { get; set; }
        public Squad_e1_cov_inf2_7 e1_cov_inf2_7 { get; set; }
        public Squad_e1_cov_inf3_0 e1_cov_inf3_0 { get; set; }
        public Squad_e1_cov_inf3_1 e1_cov_inf3_1 { get; set; }
        public Squad_e1_cov_inf3_2 e1_cov_inf3_2 { get; set; }
        public Squad_e1_cov_inf4_0 e1_cov_inf4_0 { get; set; }
        public Squad_e1_cov_inf4_1 e1_cov_inf4_1 { get; set; }
        public Squad_e1_cov_inf4_2 e1_cov_inf4_2 { get; set; }
        public Squad_e1_cov_snipers0 e1_cov_snipers0 { get; set; }
        public Squad_e1_cov_phantom0_0 e1_cov_phantom0_0 { get; set; }
        public Squad_e1_cov_phantom0_1 e1_cov_phantom0_1 { get; set; }
        public Squad_e2_mars_inf0 e2_mars_inf0 { get; set; }
        public Squad_e2_mars_johnson e2_mars_johnson { get; set; }
        public Squad_e2_cov_inf0 e2_cov_inf0 { get; set; }
        public Squad_e2_cov_hunters0 e2_cov_hunters0 { get; set; }
        public Squad_e3_mars_inf0 e3_mars_inf0 { get; set; }
        public Squad_e3_mars_inf1 e3_mars_inf1 { get; set; }
        public Squad_e3_mars_johnson e3_mars_johnson { get; set; }
        public Squad_e3_mars_pelican0 e3_mars_pelican0 { get; set; }
        public Squad_e3_cov_inf0_0 e3_cov_inf0_0 { get; set; }
        public Squad_e3_cov_inf0_1 e3_cov_inf0_1 { get; set; }
        public Squad_e3_cov_inf0_2 e3_cov_inf0_2 { get; set; }
        public Squad_e3_cov_inf0_3 e3_cov_inf0_3 { get; set; }
        public Squad_e4_mars_inf0 e4_mars_inf0 { get; set; }
        public Squad_e4_cov_inf0_0 e4_cov_inf0_0 { get; set; }
        public Squad_e4_cov_inf0_1 e4_cov_inf0_1 { get; set; }
        public Squad_e4_cov_inf1_0 e4_cov_inf1_0 { get; set; }
        public Squad_e4_cov_inf1_1 e4_cov_inf1_1 { get; set; }
        public Squad_e4_cov_inf2 e4_cov_inf2 { get; set; }
        public Squad_e4_cov_snipers0_0 e4_cov_snipers0_0 { get; set; }
        public Squad_e4_cov_snipers0_1 e4_cov_snipers0_1 { get; set; }
        public Squad_e4_cov_snipers0_2 e4_cov_snipers0_2 { get; set; }
        public Squad_e5_mars_inf0 e5_mars_inf0 { get; set; }
        public Squad_e5_cov_inf0_0 e5_cov_inf0_0 { get; set; }
        public Squad_e5_cov_inf0_1 e5_cov_inf0_1 { get; set; }
        public Squad_e5_cov_inf1_0 e5_cov_inf1_0 { get; set; }
        public Squad_e5_cov_inf1_1 e5_cov_inf1_1 { get; set; }
        public Squad_e5_cov_inf2 e5_cov_inf2 { get; set; }
        public Squad_e5_cov_inf3 e5_cov_inf3 { get; set; }
        public Squad_e5_cov_inf4 e5_cov_inf4 { get; set; }
        public Squad_e5b_cov_inf0 e5b_cov_inf0 { get; set; }
        public Squad_e6_mars_inf0 e6_mars_inf0 { get; set; }
        public Squad_e6_mars_inf0_1 e6_mars_inf0_1 { get; set; }
        public Squad_e6_mars_inf1 e6_mars_inf1 { get; set; }
        public Squad_e6_cov_inf0_0 e6_cov_inf0_0 { get; set; }
        public Squad_e6_cov_inf0_1 e6_cov_inf0_1 { get; set; }
        public Squad_e6_cov_inf0_2 e6_cov_inf0_2 { get; set; }
        public Squad_e6_cov_inf1 e6_cov_inf1 { get; set; }
        public Squad_e7_mars_inf0 e7_mars_inf0 { get; set; }
        public Squad_e7_cov_inf0 e7_cov_inf0 { get; set; }
        public Squad_e8_mars_inf0 e8_mars_inf0 { get; set; }
        public Squad_e8_mars_warthog0 e8_mars_warthog0 { get; set; }
        public Squad_e8_cov_inf0 e8_cov_inf0 { get; set; }
        public Squad_e8_cov_inf1 e8_cov_inf1 { get; set; }
        public Squad_e8_cov_inf2 e8_cov_inf2 { get; set; }
        public Squad_e8_cov_ghosts0_0 e8_cov_ghosts0_0 { get; set; }
        public Squad_e8_cov_ghosts0_1 e8_cov_ghosts0_1 { get; set; }
        public Squad_e8_cov_phantom0 e8_cov_phantom0 { get; set; }
        public Squad_____BEACH____1 ____BEACH____1 { get; set; }
        public Squad_e9_mars_test e9_mars_test { get; set; }
        public Squad_e9_mars_warthog0 e9_mars_warthog0 { get; set; }
        public Squad_e9_cov_ghosts0 e9_cov_ghosts0 { get; set; }
        public Squad_e9_cov_shadow0 e9_cov_shadow0 { get; set; }
        public Squad_e9_cov_inf0 e9_cov_inf0 { get; set; }
        public Squad_e9_cov_inf1_0 e9_cov_inf1_0 { get; set; }
        public Squad_e9_cov_inf1_1 e9_cov_inf1_1 { get; set; }
        public Squad_e9_cov_inf1_2 e9_cov_inf1_2 { get; set; }
        public Squad_e10_mars_test e10_mars_test { get; set; }
        public Squad_e10_mars_warthog0 e10_mars_warthog0 { get; set; }
        public Squad_e10_mars_inf0 e10_mars_inf0 { get; set; }
        public Squad_e10_cov_inf0 e10_cov_inf0 { get; set; }
        public Squad_e10_cov_inf1 e10_cov_inf1 { get; set; }
        public Squad_e10_cov_ghosts0_0 e10_cov_ghosts0_0 { get; set; }
        public Squad_e10_cov_ghosts0_1 e10_cov_ghosts0_1 { get; set; }
        public Squad_e10_cov_ghosts1 e10_cov_ghosts1 { get; set; }
        public Squad_e10_cov_phantom0 e10_cov_phantom0 { get; set; }
        public Squad_e11_mars_inf0 e11_mars_inf0 { get; set; }
        public Squad_e11_mars_warthog0 e11_mars_warthog0 { get; set; }
        public Squad_e11_cov_inf0 e11_cov_inf0 { get; set; }
        public Squad_e11_cov_inf1_0 e11_cov_inf1_0 { get; set; }
        public Squad_e11_cov_inf1_1 e11_cov_inf1_1 { get; set; }
        public Squad_e11_cov_inf2 e11_cov_inf2 { get; set; }
        public Squad_e11_cov_ghosts0_0 e11_cov_ghosts0_0 { get; set; }
        public Squad_e11_cov_ghosts0_1 e11_cov_ghosts0_1 { get; set; }
        public Squad_____TUNNEL____1 ____TUNNEL____1 { get; set; }
        public Squad_e12_mars_warthog0 e12_mars_warthog0 { get; set; }
        public Squad_e12_mars_warthog1 e12_mars_warthog1 { get; set; }
        public Squad_e12_mars_inf0 e12_mars_inf0 { get; set; }
        public Squad_e12_mars_inf1 e12_mars_inf1 { get; set; }
        public Squad_e12_cov_inf0_0 e12_cov_inf0_0 { get; set; }
        public Squad_e12_cov_inf0_1 e12_cov_inf0_1 { get; set; }
        public Squad_e12_cov_inf0_2 e12_cov_inf0_2 { get; set; }
        public Squad_e12_cov_inf0_3 e12_cov_inf0_3 { get; set; }
        public Squad_e12_cov_inf0_4 e12_cov_inf0_4 { get; set; }
        public Squad_e12_cov_inf0_5 e12_cov_inf0_5 { get; set; }
        public Squad_e12_cov_inf0_6 e12_cov_inf0_6 { get; set; }
        public Squad_e12_cov_creep0 e12_cov_creep0 { get; set; }
        public Squad_e12_cov_ghosts0 e12_cov_ghosts0 { get; set; }
        public Squad_e12_scarab_gunner e12_scarab_gunner { get; set; }
        public Squad_e13_mars_warthog0 e13_mars_warthog0 { get; set; }
        public Squad_e13_cov_creep0_0 e13_cov_creep0_0 { get; set; }
        public Squad_e13_cov_creep0_1 e13_cov_creep0_1 { get; set; }
        public Squad_e13_cov_creep0_2 e13_cov_creep0_2 { get; set; }
        public Squad_e13_cov_creep0_3 e13_cov_creep0_3 { get; set; }
        public Squad_e13_cov_creep0_4 e13_cov_creep0_4 { get; set; }
        public Squad_e13_cov_creep0_5 e13_cov_creep0_5 { get; set; }
        public Squad_e13_cov_creep0_6 e13_cov_creep0_6 { get; set; }
        public Squad_e13_cov_creep0_7 e13_cov_creep0_7 { get; set; }
        public Squad_e13_cov_ghosts0 e13_cov_ghosts0 { get; set; }
        public Squad_e13_cov_ghosts1 e13_cov_ghosts1 { get; set; }
        public Squad_test1 test1 { get; set; }
        public Squad_intro_hog_01 intro_hog_01 { get; set; }
        public Squad_intro_hog_02 intro_hog_02 { get; set; }
        public Squad_intro_hog_03 intro_hog_03 { get; set; }
        public Squad_intro_hog_04 intro_hog_04 { get; set; }
        [SpawnCounts(1, 1)]
        public class Squad_e1_mars_johnson : SquadBase
        {
            public IAiActorDefinition johnson0 => Squad.StartingLocations[0];
            public Squad_e1_mars_johnson(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "e1_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e1_mars_inf0 : SquadBase
        {
            public IAiActorDefinition marine0 => Squad.StartingLocations[0];
            public IAiActorDefinition marine1 => Squad.StartingLocations[1];
            public Squad_e1_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "e1_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_mars_inf1 : SquadBase
        {
            public IAiActorDefinition marine0 => Squad.StartingLocations[0];
            public Squad_e1_mars_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "e1_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e1_mars_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public Squad_e1_mars_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "e1_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e1_mars_pelican0 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public IAiActorDefinition gunner0 => Squad.StartingLocations[1];
            public IAiActorDefinition gunner1 => Squad.StartingLocations[2];
            public Squad_e1_mars_pelican0(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "e1_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e1_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition grunt0 => Squad.StartingLocations[0];
            public IAiActorDefinition grunt1 => Squad.StartingLocations[1];
            public IAiActorDefinition grunt2 => Squad.StartingLocations[2];
            public Squad_e1_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "e1_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e1_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition grunt0 => Squad.StartingLocations[0];
            public IAiActorDefinition grunt1 => Squad.StartingLocations[1];
            public Squad_e1_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "e1_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 4)]
        public class Squad_e1_cov_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e1_cov_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "e1_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e1_cov_inf0_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e1_cov_inf0_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "e1_cov_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e1_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e1_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "e1_cov_inf1")
            {
            }
        }

        [SpawnCounts(0, 3)]
        public class Squad_e1_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e1_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "e1_cov_inf1")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf2_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public Squad_e1_cov_inf2_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "e1_cov_inf2")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf2_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_cov_inf2_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "e1_cov_inf2")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e1_cov_inf2_2 : SquadBase
        {
            public Squad_e1_cov_inf2_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "e1_cov_inf2")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf2_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_cov_inf2_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "e1_cov_inf2")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf2_4 : SquadBase
        {
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_cov_inf2_4(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "e1_cov_inf2")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf2_5 : SquadBase
        {
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[4];
            public Squad_e1_cov_inf2_5(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "e1_cov_inf2")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf2_6 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_cov_inf2_6(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "e1_cov_inf2")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf2_7 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_cov_inf2_7(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "e1_cov_inf2")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_e1_cov_inf3_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_71 => Squad.StartingLocations[7];
            public Squad_e1_cov_inf3_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "e1_cov_inf3")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e1_cov_inf3_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e1_cov_inf3_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "e1_cov_inf3")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_inf3_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e1_cov_inf3_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "e1_cov_inf3")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf4_0 : SquadBase
        {
            public IAiActorDefinition elite0 => Squad.StartingLocations[0];
            public IAiActorDefinition grunt1 => Squad.StartingLocations[1];
            public IAiActorDefinition grunt2 => Squad.StartingLocations[2];
            public IAiActorDefinition grunt3 => Squad.StartingLocations[3];
            public IAiActorDefinition grunt4 => Squad.StartingLocations[4];
            public IAiActorDefinition elite1 => Squad.StartingLocations[5];
            public Squad_e1_cov_inf4_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "e1_cov_inf4")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_inf4_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_cov_inf4_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "e1_cov_inf4")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_inf4_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e1_cov_inf4_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "e1_cov_inf4")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_cov_snipers0 : SquadBase
        {
            public IAiActorDefinition sniper0 => Squad.StartingLocations[0];
            public IAiActorDefinition sniper1 => Squad.StartingLocations[1];
            public IAiActorDefinition sniper2 => Squad.StartingLocations[2];
            public IAiActorDefinition sniper3 => Squad.StartingLocations[3];
            public IAiActorDefinition sniper4 => Squad.StartingLocations[4];
            public Squad_e1_cov_snipers0(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "e1_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_phantom0_0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e1_cov_phantom0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "e1_cov_phantom0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_cov_phantom0_1 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e1_cov_phantom0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "e1_cov_phantom0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e2_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e2_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "e2_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e2_mars_johnson : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e2_mars_johnson(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "e2_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e2_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e2_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "e2_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e2_cov_hunters0 : SquadBase
        {
            public IAiActorDefinition hunter0 => Squad.StartingLocations[0];
            public IAiActorDefinition hunter1 => Squad.StartingLocations[1];
            public Squad_e2_cov_hunters0(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "e2_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e3_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e3_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "e3_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e3_mars_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e3_mars_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "e3_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e3_mars_johnson : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e3_mars_johnson(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "e3_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e3_mars_pelican0 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e3_mars_pelican0(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "e3_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e3_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e3_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "e3_cov_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e3_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e3_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "e3_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e3_cov_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e3_cov_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "e3_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e3_cov_inf0_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e3_cov_inf0_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "e3_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e4_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e4_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "e4_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e4_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public Squad_e4_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "e4_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e4_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e4_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "e4_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e4_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e4_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "e4_cov_inf1")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e4_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e4_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "e4_cov_inf1")
            {
            }
        }

        [SpawnCounts(0, 2)]
        public class Squad_e4_cov_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e4_cov_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "e4_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e4_cov_snipers0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e4_cov_snipers0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "e4_cov_snipers0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e4_cov_snipers0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e4_cov_snipers0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "e4_cov_snipers0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e4_cov_snipers0_2 : SquadBase
        {
            public IAiActorDefinition sniper0 => Squad.StartingLocations[0];
            public IAiActorDefinition sniper1 => Squad.StartingLocations[1];
            public IAiActorDefinition sniper2 => Squad.StartingLocations[2];
            public Squad_e4_cov_snipers0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "e4_cov_snipers0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e5_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e5_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "e5_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e5_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition sniper0 => Squad.StartingLocations[0];
            public IAiActorDefinition sniper1 => Squad.StartingLocations[1];
            public IAiActorDefinition sniper2 => Squad.StartingLocations[2];
            public IAiActorDefinition sniper3 => Squad.StartingLocations[3];
            public Squad_e5_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "e5_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e5_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e5_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "e5_cov_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e5_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e5_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "e5_cov_inf1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e5_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e5_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "e5_cov_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e5_cov_inf2 : SquadBase
        {
            public IAiActorDefinition sniper0 => Squad.StartingLocations[0];
            public Squad_e5_cov_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "e5_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e5_cov_inf3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e5_cov_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "e5_cov")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e5_cov_inf4 : SquadBase
        {
            public Squad_e5_cov_inf4(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "e5_cov")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e5b_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_e5b_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 57)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e6_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e6_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "e6_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_mars_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e6_mars_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "e6_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_mars_inf1 : SquadBase
        {
            public IAiActorDefinition marine0 => Squad.StartingLocations[0];
            public IAiActorDefinition marine1 => Squad.StartingLocations[1];
            public Squad_e6_mars_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "e6_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition grunt0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e6_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "e6_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e6_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "e6_cov_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e6_cov_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e6_cov_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "e6_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_cov_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e6_cov_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "e6_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e7_mars_inf0 : SquadBase
        {
            public IAiActorDefinition marine0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e7_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "e7_mars")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e7_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public Squad_e7_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "e7_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e8_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e8_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "e8_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e8_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "e8_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e8_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "e8_cov")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e8_cov_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_51 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_61 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_81 => Squad.StartingLocations[8];
            public Squad_e8_cov_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "e8_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e8_cov_inf2 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition grunt0 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e8_cov_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "e8_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_cov_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e8_cov_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "e8_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_cov_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e8_cov_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "e8_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e8_cov_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e8_cov_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "e8_cov")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_____BEACH____1 : SquadBase
        {
            public Squad_____BEACH____1(ScenarioTag ScenarioTag) : base(ScenarioTag, 75)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_mars_test : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e9_mars_test(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "e9_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "e9_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e9_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e9_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "e9_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_cov_shadow0 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e9_cov_shadow0(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "e9_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e9_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_e9_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "e9_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e9_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "e9_cov_inf1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_e9_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "e9_cov_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e9_cov_inf1_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_e9_cov_inf1_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "e9_cov_inf1")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e10_mars_test : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e10_mars_test(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "e10_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "e10_mars")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e10_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_e10_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "e10_mars")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e10_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e10_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "e10_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_cov_inf1 : SquadBase
        {
            public IAiActorDefinition gunner0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e10_cov_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "e10_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_cov_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_cov_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "e10_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_cov_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_cov_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "e10_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_cov_ghosts1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e10_cov_ghosts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "e10_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e10_cov_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e10_cov_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "e10_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e11_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e11_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "e11_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e11_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e11_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 94, "e11_mars")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e11_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_e11_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "e11_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e11_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition elite0 => Squad.StartingLocations[0];
            public IAiActorDefinition elite1 => Squad.StartingLocations[1];
            public IAiActorDefinition elite2 => Squad.StartingLocations[2];
            public Squad_e11_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "e11_cov")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e11_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition elite0 => Squad.StartingLocations[0];
            public IAiActorDefinition elite1 => Squad.StartingLocations[1];
            public IAiActorDefinition elite2 => Squad.StartingLocations[2];
            public IAiActorDefinition elite3 => Squad.StartingLocations[3];
            public Squad_e11_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "e11_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e11_cov_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e11_cov_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "e11_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e11_cov_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public IAiActorDefinition ghost1 => Squad.StartingLocations[1];
            public Squad_e11_cov_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "e11_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e11_cov_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e11_cov_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "e11_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_____TUNNEL____1 : SquadBase
        {
            public Squad_____TUNNEL____1(ScenarioTag ScenarioTag) : base(ScenarioTag, 101, "e11_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e12_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 102, "e12_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_mars_warthog1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e12_mars_warthog1(ScenarioTag ScenarioTag) : base(ScenarioTag, 103, "e12_mars")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e12_mars_inf0 : SquadBase
        {
            public Squad_e12_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "e12_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_mars_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e12_mars_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 105, "e12_mars")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e12_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_41 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[5];
            public Squad_e12_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 106, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_e12_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_e12_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 107, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_cov_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[1];
            public Squad_e12_cov_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 108, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_cov_inf0_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public Squad_e12_cov_inf0_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 109, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e12_cov_inf0_4 : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_41 => Squad.StartingLocations[4];
            public Squad_e12_cov_inf0_4(ScenarioTag ScenarioTag) : base(ScenarioTag, 110, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e12_cov_inf0_5 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e12_cov_inf0_5(ScenarioTag ScenarioTag) : base(ScenarioTag, 111, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e12_cov_inf0_6 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public Squad_e12_cov_inf0_6(ScenarioTag ScenarioTag) : base(ScenarioTag, 112, "e12_cov_inf0")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e12_cov_creep0 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_61 => Squad.StartingLocations[5];
            public Squad_e12_cov_creep0(ScenarioTag ScenarioTag) : base(ScenarioTag, 113, "e12_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e12_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 114, "e12_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e12_scarab_gunner : SquadBase
        {
            public IAiActorDefinition gunner => Squad.StartingLocations[0];
            public Squad_e12_scarab_gunner(ScenarioTag ScenarioTag) : base(ScenarioTag, 115)
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e13_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public IAiActorDefinition warthog1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e13_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 116, "e13_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_cov_creep0_0 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_cov_creep0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 117, "e13_cov_creep0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_cov_creep0_1 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_cov_creep0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 118, "e13_cov_creep0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_cov_creep0_2 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_cov_creep0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 119, "e13_cov_creep0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_cov_creep0_3 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_cov_creep0_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 120, "e13_cov_creep0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_cov_creep0_4 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_cov_creep0_4(ScenarioTag ScenarioTag) : base(ScenarioTag, 121, "e13_cov_creep0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_cov_creep0_5 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_cov_creep0_5(ScenarioTag ScenarioTag) : base(ScenarioTag, 122, "e13_cov_creep0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e13_cov_creep0_6 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_e13_cov_creep0_6(ScenarioTag ScenarioTag) : base(ScenarioTag, 123, "e13_cov_creep0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e13_cov_creep0_7 : SquadBase
        {
            public IAiActorDefinition creep0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e13_cov_creep0_7(ScenarioTag ScenarioTag) : base(ScenarioTag, 124, "e13_cov_creep0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e13_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition ghost1 => Squad.StartingLocations[0];
            public IAiActorDefinition ghost2 => Squad.StartingLocations[1];
            public IAiActorDefinition ghost0 => Squad.StartingLocations[2];
            public Squad_e13_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 125, "e13_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e13_cov_ghosts1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e13_cov_ghosts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 126, "e13_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_test1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_test1(ScenarioTag ScenarioTag) : base(ScenarioTag, 127)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_intro_hog_01 : SquadBase
        {
            public IAiActorDefinition hog => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_intro_hog_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 128)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_intro_hog_02 : SquadBase
        {
            public IAiActorDefinition hog => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_intro_hog_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 129)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_intro_hog_03 : SquadBase
        {
            public IAiActorDefinition hog => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_intro_hog_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 130)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_intro_hog_04 : SquadBase
        {
            public IAiActorDefinition hog => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_intro_hog_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 131)
            {
            }
        }
    }
}