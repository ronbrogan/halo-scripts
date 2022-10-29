namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_01a_tutorial : ScenarioScriptBase
    {
        public Squad_guns guns { get; set; }
        public Squad_johnson johnson { get; set; }
        public Squad_tracker_elite tracker_elite { get; set; }
        public Squad_atr1_mar atr1_mar { get; set; }
        public Squad_mid_mar mid_mar { get; set; }
        public Squad_atr2_mar atr2_mar { get; set; }
        [SpawnCounts(1, 1)]
        public class Squad_guns : SquadBase
        {
            public IAiActorDefinition guns => Squad.StartingLocations[0];
            public Squad_guns(ScenarioTag ScenarioTag) : base(ScenarioTag, 0)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_johnson : SquadBase
        {
            public IAiActorDefinition johnson => Squad.StartingLocations[0];
            public Squad_johnson(ScenarioTag ScenarioTag) : base(ScenarioTag, 1)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_tracker_elite : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_tracker_elite(ScenarioTag ScenarioTag) : base(ScenarioTag, 2)
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_atr1_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_atr1_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 3)
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_mid_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_mid_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 4)
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_atr2_mar : SquadBase
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
            public Squad_atr2_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 5)
            {
            }
        }
    }
}