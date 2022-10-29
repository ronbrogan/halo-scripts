namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_03b_newmombasa : ScenarioScriptBase
    {
        public Squad_scarab_gunners scarab_gunners { get; set; }
        public Squad_e14_mars_inf0 e14_mars_inf0 { get; set; }
        public Squad_e14_mars_pelican0 e14_mars_pelican0 { get; set; }
        public Squad_e14_cov_ghosts0_0 e14_cov_ghosts0_0 { get; set; }
        public Squad_e14_cov_ghosts0_1 e14_cov_ghosts0_1 { get; set; }
        public Squad_e14_cov_wraiths0 e14_cov_wraiths0 { get; set; }
        public Squad_e14_cov_snipers0 e14_cov_snipers0 { get; set; }
        public Squad_e15_mars_inf0 e15_mars_inf0 { get; set; }
        public Squad_e15_cov_inf0 e15_cov_inf0 { get; set; }
        public Squad_e15_cov_inf1 e15_cov_inf1 { get; set; }
        public Squad_e15_cov_inf2_0 e15_cov_inf2_0 { get; set; }
        public Squad_e15_cov_inf2_1 e15_cov_inf2_1 { get; set; }
        public Squad_e15_cov_phantom0_0 e15_cov_phantom0_0 { get; set; }
        public Squad_e15_cov_phantom0_1 e15_cov_phantom0_1 { get; set; }
        public Squad_e15_cov_phantom1 e15_cov_phantom1 { get; set; }
        public Squad_e15_cov_banshees01 e15_cov_banshees01 { get; set; }
        public Squad_e16_mars_inf0 e16_mars_inf0 { get; set; }
        public Squad_e16_cov_wraiths0_0 e16_cov_wraiths0_0 { get; set; }
        public Squad_e16_cov_wraiths0_1 e16_cov_wraiths0_1 { get; set; }
        public Squad_e16_cov_wraiths1 e16_cov_wraiths1 { get; set; }
        public Squad_e16_cov_ghosts0_0 e16_cov_ghosts0_0 { get; set; }
        public Squad_e16_cov_ghosts0_1 e16_cov_ghosts0_1 { get; set; }
        public Squad_e16_cov_ghosts1 e16_cov_ghosts1 { get; set; }
        public Squad_e16_cov_banshees0_0 e16_cov_banshees0_0 { get; set; }
        public Squad_e16_cov_banshees0_1 e16_cov_banshees0_1 { get; set; }
        public Squad_e16_cov_inf0_0 e16_cov_inf0_0 { get; set; }
        public Squad_e16_cov_inf0_1 e16_cov_inf0_1 { get; set; }
        public Squad_e16_cov_inf0_2 e16_cov_inf0_2 { get; set; }
        public Squad_e16_cov_phantom0 e16_cov_phantom0 { get; set; }
        public Squad_e17_mars_inf0 e17_mars_inf0 { get; set; }
        public Squad_e17_cov_inf0_0 e17_cov_inf0_0 { get; set; }
        public Squad_e17_cov_inf0_1 e17_cov_inf0_1 { get; set; }
        public Squad_e17_cov_inf0_2 e17_cov_inf0_2 { get; set; }
        public Squad_e17_cov_inf0_3 e17_cov_inf0_3 { get; set; }
        public Squad_e17_cov_inf1_0 e17_cov_inf1_0 { get; set; }
        public Squad_e17_cov_inf1_1 e17_cov_inf1_1 { get; set; }
        public Squad_e17_cov_inf2_0 e17_cov_inf2_0 { get; set; }
        public Squad_e17_cov_inf2_1 e17_cov_inf2_1 { get; set; }
        public Squad_e17_cov_inf2_2 e17_cov_inf2_2 { get; set; }
        public Squad_e17_cov_inf2_3 e17_cov_inf2_3 { get; set; }
        public Squad_e17_cov_ghosts0 e17_cov_ghosts0 { get; set; }
        public Squad_____PARK____1 ____PARK____1 { get; set; }
        public Squad_e18_mars_inf0 e18_mars_inf0 { get; set; }
        public Squad_e18_mars_warthog0 e18_mars_warthog0 { get; set; }
        public Squad_e18_cov_inf0 e18_cov_inf0 { get; set; }
        public Squad_e18_cov_inf1_0 e18_cov_inf1_0 { get; set; }
        public Squad_e18_cov_inf1_1 e18_cov_inf1_1 { get; set; }
        public Squad_e18_cov_ghosts0 e18_cov_ghosts0 { get; set; }
        public Squad_e19_mars_warthog0 e19_mars_warthog0 { get; set; }
        public Squad_e19_cov_inf0 e19_cov_inf0 { get; set; }
        public Squad_e19_cov_wraiths0_0 e19_cov_wraiths0_0 { get; set; }
        public Squad_e19_cov_ghosts0_0 e19_cov_ghosts0_0 { get; set; }
        public Squad_e19_cov_ghosts0_1 e19_cov_ghosts0_1 { get; set; }
        public Squad_____NEW_CITY____ ____NEW_CITY____ { get; set; }
        public Squad_e20_mars_warthog1 e20_mars_warthog1 { get; set; }
        public Squad_e20_mars_warthog0 e20_mars_warthog0 { get; set; }
        public Squad_e20_cov_ghosts0 e20_cov_ghosts0 { get; set; }
        public Squad_e21_mars_warthog0 e21_mars_warthog0 { get; set; }
        public Squad_e21_mars_inf0 e21_mars_inf0 { get; set; }
        public Squad_e21_mars_inf1 e21_mars_inf1 { get; set; }
        public Squad_e21_mars_pelican0 e21_mars_pelican0 { get; set; }
        public Squad_e21_mars_pelican1 e21_mars_pelican1 { get; set; }
        public Squad_e21_cov_wraiths0_0 e21_cov_wraiths0_0 { get; set; }
        public Squad_e21_cov_wraiths0_1 e21_cov_wraiths0_1 { get; set; }
        public Squad_e21_cov_wraiths0_2 e21_cov_wraiths0_2 { get; set; }
        public Squad_e21_cov_ghosts0_0 e21_cov_ghosts0_0 { get; set; }
        public Squad_e21_cov_ghosts0_1 e21_cov_ghosts0_1 { get; set; }
        public Squad_e21_cov_ghosts0_2 e21_cov_ghosts0_2 { get; set; }
        public Squad_e21_cov_phantom0 e21_cov_phantom0 { get; set; }
        public Squad_e21_cov_phantom1 e21_cov_phantom1 { get; set; }
        public Squad_e21_cov_creep0 e21_cov_creep0 { get; set; }
        public Squad_e21_cov_inf0 e21_cov_inf0 { get; set; }
        public Squad_e22_mars_inf0 e22_mars_inf0 { get; set; }
        public Squad_e22_mars_inf1 e22_mars_inf1 { get; set; }
        public Squad_e22_mars_inf2 e22_mars_inf2 { get; set; }
        public Squad_e22_mars_inf3 e22_mars_inf3 { get; set; }
        public Squad_e22_mars_scorpions0 e22_mars_scorpions0 { get; set; }
        public Squad_e23_mars_inf0 e23_mars_inf0 { get; set; }
        public Squad_e23_mars_inf1 e23_mars_inf1 { get; set; }
        public Squad_e23_mars_pelican0_0 e23_mars_pelican0_0 { get; set; }
        public Squad_e23_mars_pelican0_1 e23_mars_pelican0_1 { get; set; }
        public Squad_e23_mars_pelican1_0 e23_mars_pelican1_0 { get; set; }
        public Squad_e23_mars_pelican1_1 e23_mars_pelican1_1 { get; set; }
        public Squad_e23_mars_pelican2 e23_mars_pelican2 { get; set; }
        public Squad_e23_cov_inf0_0 e23_cov_inf0_0 { get; set; }
        public Squad_e23_cov_inf0_1 e23_cov_inf0_1 { get; set; }
        public Squad_e23_cov_inf0_2 e23_cov_inf0_2 { get; set; }
        public Squad_e23_cov_inf0_3 e23_cov_inf0_3 { get; set; }
        public Squad_e23_cov_inf0_4 e23_cov_inf0_4 { get; set; }
        public Squad_e23_cov_inf1_0 e23_cov_inf1_0 { get; set; }
        public Squad_e23_cov_inf1_1 e23_cov_inf1_1 { get; set; }
        public Squad_e18_cov_inf2_0 e18_cov_inf2_0 { get; set; }
        public Squad_e18_cov_inf2_1 e18_cov_inf2_1 { get; set; }
        [SpawnCounts(0, 0)]
        public class Squad_scarab_gunners : SquadBase
        {
            public IAiActorDefinition main_gunner => Squad.StartingLocations[0];
            public IAiActorDefinition upper_gunner => Squad.StartingLocations[1];
            public IAiActorDefinition rear_gunner => Squad.StartingLocations[2];
            public IAiActorDefinition right_gunner0 => Squad.StartingLocations[3];
            public IAiActorDefinition right_gunner1 => Squad.StartingLocations[4];
            public IAiActorDefinition left_gunner0 => Squad.StartingLocations[5];
            public IAiActorDefinition left_gunner1 => Squad.StartingLocations[6];
            public Squad_scarab_gunners(ScenarioTag ScenarioTag) : base(ScenarioTag, 0)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e14_mars_inf0 : SquadBase
        {
            public IAiActorDefinition scorpion0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition warthog0 => Squad.StartingLocations[3];
            public IAiActorDefinition warthog1 => Squad.StartingLocations[4];
            public Squad_e14_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "e14_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e14_mars_pelican0 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public IAiActorDefinition johnson0 => Squad.StartingLocations[1];
            public IAiActorDefinition gunner0 => Squad.StartingLocations[2];
            public Squad_e14_mars_pelican0(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "e14_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e14_cov_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e14_cov_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "e14_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e14_cov_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e14_cov_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "e14_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e14_cov_wraiths0 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e14_cov_wraiths0(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "e14_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e14_cov_snipers0 : SquadBase
        {
            public Squad_e14_cov_snipers0(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "e14_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e15_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition marine0 => Squad.StartingLocations[1];
            public Squad_e15_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "e15_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e15_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e15_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "e15_cov")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e15_cov_inf1 : SquadBase
        {
            public IAiActorDefinition bugger0 => Squad.StartingLocations[0];
            public IAiActorDefinition bugger1 => Squad.StartingLocations[1];
            public IAiActorDefinition bugger2 => Squad.StartingLocations[2];
            public IAiActorDefinition bugger3 => Squad.StartingLocations[3];
            public IAiActorDefinition bugger4 => Squad.StartingLocations[4];
            public IAiActorDefinition bugger5 => Squad.StartingLocations[5];
            public Squad_e15_cov_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "e15_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e15_cov_inf2_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e15_cov_inf2_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "e15_cov_inf2")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e15_cov_inf2_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e15_cov_inf2_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "e15_cov_inf2")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e15_cov_phantom0_0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e15_cov_phantom0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "e15_cov_phantom0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e15_cov_phantom0_1 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e15_cov_phantom0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "e15_cov_phantom0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e15_cov_phantom1 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e15_cov_phantom1(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "e15_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e15_cov_banshees01 : SquadBase
        {
            public IAiActorDefinition banshee0 => Squad.StartingLocations[0];
            public IAiActorDefinition banshee1 => Squad.StartingLocations[1];
            public Squad_e15_cov_banshees01(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "e15_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e16_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e16_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "e16_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e16_cov_wraiths0_0 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public IAiActorDefinition wraith1 => Squad.StartingLocations[1];
            public Squad_e16_cov_wraiths0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "e16_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e16_cov_wraiths0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e16_cov_wraiths0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "e16_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e16_cov_wraiths1 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[1];
            public Squad_e16_cov_wraiths1(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "e16_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e16_cov_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e16_cov_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "e16_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e16_cov_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public IAiActorDefinition ghost1 => Squad.StartingLocations[1];
            public Squad_e16_cov_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "e16_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e16_cov_ghosts1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e16_cov_ghosts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "e16_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e16_cov_banshees0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e16_cov_banshees0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "e16_cov_banshees0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e16_cov_banshees0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e16_cov_banshees0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "e16_cov_banshees0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e16_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public Squad_e16_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "e16_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e16_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e16_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "e16_cov_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e16_cov_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e16_cov_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "e16_cov_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e16_cov_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e16_cov_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "e16_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e17_mars_inf0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public IAiActorDefinition passenger0 => Squad.StartingLocations[1];
            public Squad_e17_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "e17_mars")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e17_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e17_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "e17_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e17_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e17_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "e17_cov_inf0")
            {
            }
        }

        [SpawnCounts(0, 2)]
        public class Squad_e17_cov_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e17_cov_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "e17_cov_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e17_cov_inf0_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e17_cov_inf0_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "e17_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e17_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e17_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "e17_cov_inf1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e17_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e17_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "e17_cov_inf1")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e17_cov_inf2_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e17_cov_inf2_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "e17_cov_inf2")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e17_cov_inf2_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e17_cov_inf2_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "e17_cov_inf2")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e17_cov_inf2_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_e17_cov_inf2_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "e17_cov_inf2")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e17_cov_inf2_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e17_cov_inf2_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "e17_cov_inf2")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e17_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e17_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "e17_cov_inf2")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_____PARK____1 : SquadBase
        {
            public Squad_____PARK____1(ScenarioTag ScenarioTag) : base(ScenarioTag, 41)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e18_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e18_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "e18_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e18_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public Squad_e18_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "e18_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e18_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_e18_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "e18_cov")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e18_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[2];
            public Squad_e18_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "e18_cov_inf1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e18_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e18_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "e18_cov_inf1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e18_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e18_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "e18_cov")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e19_mars_warthog0 : SquadBase
        {
            public Squad_e19_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "e19_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e19_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e19_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "e19_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e19_cov_wraiths0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e19_cov_wraiths0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "e19_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e19_cov_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e19_cov_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "e19_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e19_cov_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[1];
            public Squad_e19_cov_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "e19_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_____NEW_CITY____ : SquadBase
        {
            public Squad_____NEW_CITY____(ScenarioTag ScenarioTag) : base(ScenarioTag, 53)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e20_mars_warthog1 : SquadBase
        {
            public IAiActorDefinition gunner0 => Squad.StartingLocations[0];
            public IAiActorDefinition warthog0 => Squad.StartingLocations[1];
            public IAiActorDefinition spare => Squad.StartingLocations[2];
            public Squad_e20_mars_warthog1(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "e20_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e20_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition warthog0 => Squad.StartingLocations[2];
            public Squad_e20_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "e20_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e20_cov_ghosts0 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public IAiActorDefinition ghost1 => Squad.StartingLocations[1];
            public Squad_e20_cov_ghosts0(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "e20_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e21_mars_warthog0 : SquadBase
        {
            public IAiActorDefinition warthog0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e21_mars_warthog0(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "e21_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e21_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e21_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "e21_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e21_mars_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e21_mars_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "e21_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_mars_pelican0 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public IAiActorDefinition scorpion0 => Squad.StartingLocations[1];
            public Squad_e21_mars_pelican0(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "e21_mars")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e21_mars_pelican1 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[5];
            public Squad_e21_mars_pelican1(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "e21_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_cov_wraiths0_0 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e21_cov_wraiths0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "e21_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_cov_wraiths0_1 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e21_cov_wraiths0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "e21_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_cov_wraiths0_2 : SquadBase
        {
            public IAiActorDefinition wraith0 => Squad.StartingLocations[0];
            public Squad_e21_cov_wraiths0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "e21_cov_wraiths0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e21_cov_ghosts0_0 : SquadBase
        {
            public IAiActorDefinition ghost0 => Squad.StartingLocations[0];
            public IAiActorDefinition ghost1 => Squad.StartingLocations[1];
            public Squad_e21_cov_ghosts0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "e21_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e21_cov_ghosts0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e21_cov_ghosts0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "e21_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e21_cov_ghosts0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e21_cov_ghosts0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "e21_cov_ghosts0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_cov_phantom0 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e21_cov_phantom0(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "e21_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_cov_phantom1 : SquadBase
        {
            public IAiActorDefinition phantom0 => Squad.StartingLocations[0];
            public Squad_e21_cov_phantom1(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "e21_cov")
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_e21_cov_creep0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_e21_cov_creep0(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "e21_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e21_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e21_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "e21_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e22_mars_inf0 : SquadBase
        {
            public IAiActorDefinition perez => Squad.StartingLocations[0];
            public IAiActorDefinition guard0 => Squad.StartingLocations[1];
            public IAiActorDefinition guard2 => Squad.StartingLocations[2];
            public IAiActorDefinition guard1 => Squad.StartingLocations[3];
            public IAiActorDefinition medic0 => Squad.StartingLocations[4];
            public Squad_e22_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "e22_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e22_mars_inf1 : SquadBase
        {
            public IAiActorDefinition lieutenant => Squad.StartingLocations[0];
            public IAiActorDefinition marine0 => Squad.StartingLocations[1];
            public IAiActorDefinition marine1 => Squad.StartingLocations[2];
            public Squad_e22_mars_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "e22_mars")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e22_mars_inf2 : SquadBase
        {
            public IAiActorDefinition marine0 => Squad.StartingLocations[0];
            public IAiActorDefinition marine1 => Squad.StartingLocations[1];
            public IAiActorDefinition marine2 => Squad.StartingLocations[2];
            public IAiActorDefinition marine3 => Squad.StartingLocations[3];
            public IAiActorDefinition marine4 => Squad.StartingLocations[4];
            public Squad_e22_mars_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "e22_mars")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e22_mars_inf3 : SquadBase
        {
            public Squad_e22_mars_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "e22_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e22_mars_scorpions0 : SquadBase
        {
            public IAiActorDefinition scorpion0 => Squad.StartingLocations[0];
            public Squad_e22_mars_scorpions0(ScenarioTag ScenarioTag) : base(ScenarioTag, 76)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e23_mars_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e23_mars_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "e23_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e23_mars_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e23_mars_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "e23_mars")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e23_mars_pelican0_0 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public IAiActorDefinition gunner0 => Squad.StartingLocations[1];
            public IAiActorDefinition gunner1 => Squad.StartingLocations[2];
            public Squad_e23_mars_pelican0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "e23_mars_pelican0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e23_mars_pelican0_1 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public IAiActorDefinition gunner0 => Squad.StartingLocations[1];
            public IAiActorDefinition gunner1 => Squad.StartingLocations[2];
            public Squad_e23_mars_pelican0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "e23_mars_pelican0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e23_mars_pelican1_0 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public Squad_e23_mars_pelican1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "e23_mars")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e23_mars_pelican1_1 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public Squad_e23_mars_pelican1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "e23_mars")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e23_mars_pelican2 : SquadBase
        {
            public IAiActorDefinition pelican0 => Squad.StartingLocations[0];
            public IAiActorDefinition pelican1 => Squad.StartingLocations[1];
            public IAiActorDefinition pelican2 => Squad.StartingLocations[2];
            public IAiActorDefinition gunner0 => Squad.StartingLocations[3];
            public IAiActorDefinition gunner1 => Squad.StartingLocations[4];
            public Squad_e23_mars_pelican2(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "e23_mars")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e23_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e23_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "e23_cov_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e23_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e23_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "e23_cov_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e23_cov_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_32 => Squad.StartingLocations[3];
            public Squad_e23_cov_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "e23_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e23_cov_inf0_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_e23_cov_inf0_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "e23_cov_inf0")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e23_cov_inf0_4 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[4];
            public Squad_e23_cov_inf0_4(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "e23_cov_inf0")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e23_cov_inf1_0 : SquadBase
        {
            public IAiActorDefinition ultra0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e23_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "e23_cov_inf1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e23_cov_inf1_1 : SquadBase
        {
            public IAiActorDefinition pilot0 => Squad.StartingLocations[0];
            public IAiActorDefinition pilot1 => Squad.StartingLocations[1];
            public Squad_e23_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "e23_cov_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e18_cov_inf2_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e18_cov_inf2_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "e18_cov_inf2")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e18_cov_inf2_1 : SquadBase
        {
            public IAiActorDefinition sniper0 => Squad.StartingLocations[0];
            public IAiActorDefinition sniper1 => Squad.StartingLocations[1];
            public Squad_e18_cov_inf2_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "e18_cov_inf2")
            {
            }
        }
    }
}