namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_headlong : ScenarioScriptBase
    {
        public ITriggerVolume floor_1_stop => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume floor_1_pad => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume floor_0_stop => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume floor_0_pad => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume kill_shark => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume kill_bldg1 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume kill_bldg2 => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume kill_bldg3 => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume kill_bldg4 => Scenario.TriggerVolumes[8].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
        }
    }
}