namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_waterworks : ScenarioScriptBase
    {
        public ScenarioEntity<ISound> building { get; set; }
        public ITriggerVolume kill_bottomless_pit => Scenario.TriggerVolumes[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            building = new ScenarioEntity<ISound>(0, scenarioTag.WellKnownItems[0]);
        }
    }
}