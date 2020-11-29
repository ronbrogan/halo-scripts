namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_ascension : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> Unnamed { get; set; }
        public ITriggerVolume kill_clouds => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume kill_crossbeam => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume kill_crossbeam_low => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume kill_way_low => Scenario.TriggerVolumes[3].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            Unnamed = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
        }
    }
}