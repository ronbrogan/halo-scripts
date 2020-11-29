namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_midship : ScenarioScriptBase
    {
        public ITriggerVolume main_activate => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume floor_0_stop => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume left_activate => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume right_activate => Scenario.TriggerVolumes[3].GameObject;
        public IDeviceGroup big_door => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup platform_power => Scenario.DeviceGroupDefinitions[1].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
        }
    }
}