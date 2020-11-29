namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_containment : ScenarioScriptBase
    {
        public ScenarioEntity<IDevice> base_gate_machine_0 { get; set; }
        public ScenarioEntity<IDevice> base_gate_machine_1 { get; set; }
        public ScenarioEntity<IDevice> group_2 { get; set; }
        public ScenarioEntity<IDevice> group_3 { get; set; }
        public ScenarioEntity<IDevice> base_switch_1 { get; set; }
        public ScenarioEntity<IDevice> base_swtich_0 { get; set; }
        public IStartingProfile Unnamed => Scenario.StartingProfileDefinitions[0].GameObject;
        public IDeviceGroup device_groups_2 => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup device_groups_3 => Scenario.DeviceGroupDefinitions[1].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            base_gate_machine_0 = new ScenarioEntity<IDevice>(0, scenarioTag.WellKnownItems[0]);
            base_gate_machine_1 = new ScenarioEntity<IDevice>(1, scenarioTag.WellKnownItems[1]);
            group_2 = new ScenarioEntity<IDevice>(2, scenarioTag.WellKnownItems[2]);
            group_3 = new ScenarioEntity<IDevice>(3, scenarioTag.WellKnownItems[3]);
            base_switch_1 = new ScenarioEntity<IDevice>(4, scenarioTag.WellKnownItems[4]);
            base_swtich_0 = new ScenarioEntity<IDevice>(5, scenarioTag.WellKnownItems[5]);
        }
    }
}