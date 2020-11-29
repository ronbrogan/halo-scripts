namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_dune : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> ramps { get; set; }
        public ScenarioEntity<IScenery> crap { get; set; }
        public ScenarioEntity<IDevice> shroud_01 { get; set; }
        public ScenarioEntity<IDevice> shroud_02 { get; set; }
        public ScenarioEntity<IDevice> gate { get; set; }
        public ScenarioEntity<IDevice> tele_switch { get; set; }
        public ITriggerVolume kill => Scenario.TriggerVolumes[0].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IDeviceGroup shrouds => Scenario.DeviceGroupDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            ramps = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            crap = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            shroud_01 = new ScenarioEntity<IDevice>(2, scenarioTag.WellKnownItems[2]);
            shroud_02 = new ScenarioEntity<IDevice>(3, scenarioTag.WellKnownItems[3]);
            gate = new ScenarioEntity<IDevice>(4, scenarioTag.WellKnownItems[4]);
            tele_switch = new ScenarioEntity<IDevice>(5, scenarioTag.WellKnownItems[5]);
        }
    }
}