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
        public ScenarioEntity<IDevice> tram { get; set; }
        public ScenarioEntity<IDevice> door_tram_1 { get; set; }
        public ScenarioEntity<IDevice> door_tram_3 { get; set; }
        public ScenarioEntity<IDevice> door_tram_4 { get; set; }
        public ScenarioEntity<IDevice> zapper_control { get; set; }
        public ScenarioEntity<IDevice> starting_cage { get; set; }
        public ScenarioEntity<IDevice> door_elevator_tram_bot { get; set; }
        public ScenarioEntity<IDevice> looker_light_bottom_red { get; set; }
        public ScenarioEntity<IDevice> looker_light_right_red { get; set; }
        public ScenarioEntity<IDevice> looker_light_left_red { get; set; }
        public ScenarioEntity<IDevice> looker_light_top_red { get; set; }
        public ScenarioEntity<IDevice> elevator_tram { get; set; }
        public ScenarioEntity<IDevice> wall_elevator_tram_bot { get; set; }
        public ScenarioEntity<IDevice> door_tram_2 { get; set; }
        public ScenarioEntity<IScenery> inamberclad { get; set; }
        public ScenarioEntity<IDevice> zapper_cage { get; set; }
        public ScenarioEntity<IDevice> inhibitor { get; set; }
        public ScenarioEntity<IDevice> wall_tram { get; set; }
        public ScenarioEntity<IDevice> wall_platform_1 { get; set; }
        public ScenarioEntity<IDevice> wall_platform_2 { get; set; }
        public ScenarioEntity<IDevice> wall_platform_3 { get; set; }
        public ScenarioEntity<IDevice> wall_platform_4 { get; set; }
        public ScenarioEntity<IDevice> looker_light_top_green { get; set; }
        public ScenarioEntity<IDevice> looker_light_bottom_green { get; set; }
        public ScenarioEntity<IDevice> looker_light_right_green { get; set; }
        public ScenarioEntity<IDevice> looker_light_left_green { get; set; }
        public ScenarioEntity<IDevice> wall_platform_5 { get; set; }
        public ScenarioEntity<IDevice> zapper { get; set; }
        public ScenarioEntity<IDevice> iac_intro { get; set; }
        public ScenarioEntity<IDevice> iac_tram { get; set; }
        public ScenarioEntity<IWeapon> cookiesncream { get; set; }
        public ScenarioEntity<IUnit> tram_marine_1 { get; set; }
        public ScenarioEntity<IUnit> tram_marine_2 { get; set; }
        public ScenarioEntity<IUnit> tram_marine_3 { get; set; }
        public ScenarioEntity<IUnit> tram_marine_4 { get; set; }
        public ScenarioEntity<IUnit> tram_marine_5 { get; set; }
        public ScenarioEntity<IUnit> tram_marine_6 { get; set; }
        public ScenarioEntity<IUnit> tram_marine_7 { get; set; }
        public Squad_guns guns { get; set; }
        public Squad_johnson johnson { get; set; }
        public Squad_tracker_elite tracker_elite { get; set; }
        public Squad_atr1_mar atr1_mar { get; set; }
        public Squad_mid_mar mid_mar { get; set; }
        public Squad_atr2_mar atr2_mar { get; set; }
        public IAiOrders tracker_order => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders atr2_order => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders mid_order => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders atr2_order1 => Scenario.AiOrderDefinitions[3].GameObject;
        public ILocationFlag tram_flag => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag zapper_flag => Scenario.LocationFlagDefinitions[1].GameObject;
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ITriggerVolume tv_elevator_tram_bot => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume tv_start_spot => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume tv_tracker => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume tv_tram => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume tv_elevator_tram_fat => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume tv_zapper => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume tv_station => Scenario.TriggerVolumes[6].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IDeviceGroup zapper_power => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup tracker_power => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup looker_power => Scenario.DeviceGroupDefinitions[2].GameObject;
        public IDeviceGroup zapper_control_power => Scenario.DeviceGroupDefinitions[3].GameObject;
        public IDeviceGroup looker_control_power => Scenario.DeviceGroupDefinitions[4].GameObject;
        public IDeviceGroup tracker_control_power => Scenario.DeviceGroupDefinitions[5].GameObject;
        public IDeviceGroup zapper_control_group => Scenario.DeviceGroupDefinitions[6].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            tram = new ScenarioEntity<IDevice>(0, scenarioTag.WellKnownItems[0]);
            door_tram_1 = new ScenarioEntity<IDevice>(1, scenarioTag.WellKnownItems[1]);
            door_tram_3 = new ScenarioEntity<IDevice>(2, scenarioTag.WellKnownItems[2]);
            door_tram_4 = new ScenarioEntity<IDevice>(3, scenarioTag.WellKnownItems[3]);
            zapper_control = new ScenarioEntity<IDevice>(4, scenarioTag.WellKnownItems[4]);
            starting_cage = new ScenarioEntity<IDevice>(5, scenarioTag.WellKnownItems[5]);
            door_elevator_tram_bot = new ScenarioEntity<IDevice>(6, scenarioTag.WellKnownItems[6]);
            looker_light_bottom_red = new ScenarioEntity<IDevice>(7, scenarioTag.WellKnownItems[7]);
            looker_light_right_red = new ScenarioEntity<IDevice>(8, scenarioTag.WellKnownItems[8]);
            looker_light_left_red = new ScenarioEntity<IDevice>(9, scenarioTag.WellKnownItems[9]);
            looker_light_top_red = new ScenarioEntity<IDevice>(10, scenarioTag.WellKnownItems[10]);
            elevator_tram = new ScenarioEntity<IDevice>(11, scenarioTag.WellKnownItems[11]);
            wall_elevator_tram_bot = new ScenarioEntity<IDevice>(12, scenarioTag.WellKnownItems[12]);
            door_tram_2 = new ScenarioEntity<IDevice>(13, scenarioTag.WellKnownItems[13]);
            inamberclad = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            zapper_cage = new ScenarioEntity<IDevice>(15, scenarioTag.WellKnownItems[15]);
            inhibitor = new ScenarioEntity<IDevice>(16, scenarioTag.WellKnownItems[16]);
            wall_tram = new ScenarioEntity<IDevice>(17, scenarioTag.WellKnownItems[17]);
            wall_platform_1 = new ScenarioEntity<IDevice>(18, scenarioTag.WellKnownItems[18]);
            wall_platform_2 = new ScenarioEntity<IDevice>(19, scenarioTag.WellKnownItems[19]);
            wall_platform_3 = new ScenarioEntity<IDevice>(20, scenarioTag.WellKnownItems[20]);
            wall_platform_4 = new ScenarioEntity<IDevice>(21, scenarioTag.WellKnownItems[21]);
            looker_light_top_green = new ScenarioEntity<IDevice>(22, scenarioTag.WellKnownItems[22]);
            looker_light_bottom_green = new ScenarioEntity<IDevice>(23, scenarioTag.WellKnownItems[23]);
            looker_light_right_green = new ScenarioEntity<IDevice>(24, scenarioTag.WellKnownItems[24]);
            looker_light_left_green = new ScenarioEntity<IDevice>(25, scenarioTag.WellKnownItems[25]);
            wall_platform_5 = new ScenarioEntity<IDevice>(26, scenarioTag.WellKnownItems[26]);
            zapper = new ScenarioEntity<IDevice>(27, scenarioTag.WellKnownItems[27]);
            iac_intro = new ScenarioEntity<IDevice>(28, scenarioTag.WellKnownItems[28]);
            iac_tram = new ScenarioEntity<IDevice>(29, scenarioTag.WellKnownItems[29]);
            cookiesncream = new ScenarioEntity<IWeapon>(30, scenarioTag.WellKnownItems[30]);
            tram_marine_1 = new ScenarioEntity<IUnit>(31, scenarioTag.WellKnownItems[31]);
            tram_marine_2 = new ScenarioEntity<IUnit>(32, scenarioTag.WellKnownItems[32]);
            tram_marine_3 = new ScenarioEntity<IUnit>(33, scenarioTag.WellKnownItems[33]);
            tram_marine_4 = new ScenarioEntity<IUnit>(34, scenarioTag.WellKnownItems[34]);
            tram_marine_5 = new ScenarioEntity<IUnit>(35, scenarioTag.WellKnownItems[35]);
            tram_marine_6 = new ScenarioEntity<IUnit>(36, scenarioTag.WellKnownItems[36]);
            tram_marine_7 = new ScenarioEntity<IUnit>(37, scenarioTag.WellKnownItems[37]);
            guns = new Squad_guns(scenarioTag);
            johnson = new Squad_johnson(scenarioTag);
            tracker_elite = new Squad_tracker_elite(scenarioTag);
            atr1_mar = new Squad_atr1_mar(scenarioTag);
            mid_mar = new Squad_mid_mar(scenarioTag);
            atr2_mar = new Squad_atr2_mar(scenarioTag);
        }

        public class Squad_guns
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition guns => ScenarioTag.AiSquadDefinitions[0].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[0];
            public Squad_guns(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_johnson
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition johnson => ScenarioTag.AiSquadDefinitions[1].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[1];
            public Squad_johnson(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_tracker_elite
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[2].StartingLocations[1];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[2];
            public Squad_tracker_elite(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_atr1_mar
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[3].StartingLocations[8];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[3];
            public Squad_atr1_mar(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_mid_mar
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[4].StartingLocations[7];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[4];
            public Squad_mid_mar(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }

        public class Squad_atr2_mar
        {
            public ScenarioTag ScenarioTag { get; set; }
            public IAiActorDefinition starting_locations_0 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[1];
            public IAiActorDefinition starting_locations_1 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[2];
            public IAiActorDefinition starting_locations_2 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[3];
            public IAiActorDefinition starting_locations_3 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[4];
            public IAiActorDefinition starting_locations_4 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[5];
            public IAiActorDefinition starting_locations_5 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[6];
            public IAiActorDefinition starting_locations_6 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[7];
            public IAiActorDefinition starting_locations_7 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[8];
            public IAiActorDefinition starting_locations_8 => ScenarioTag.AiSquadDefinitions[5].StartingLocations[9];
            public IAiActorDefinition Squad => ScenarioTag.AiSquadDefinitions[5];
            public Squad_atr2_mar(ScenarioTag ScenarioTag)
            {
                this.ScenarioTag = ScenarioTag;
            }
        }
    }
}