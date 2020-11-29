namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_gemini : ScenarioScriptBase
    {
        public ITriggerVolume kill_balcony => Scenario.TriggerVolumes[0].GameObject;
        public IDeviceGroup lift_power => Scenario.DeviceGroupDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
        }
    }
}