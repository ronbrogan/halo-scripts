namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_warlock : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> alpha { get; set; }
        public ScenarioEntity<IScenery> charlie { get; set; }
        public ScenarioEntity<IScenery> bravo { get; set; }
        public ScenarioEntity<IScenery> delta { get; set; }
        public ScenarioEntity<IScenery> neutral { get; set; }
        public ITriggerVolume kill_volume_ruins => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume kill_volume_tree => Scenario.TriggerVolumes[1].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            alpha = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            charlie = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            bravo = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            delta = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            neutral = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
        }
    }
}