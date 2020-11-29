namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_turf : ScenarioScriptBase
    {
        public ScenarioEntity<ISound> Unnamed { get; set; }
        public IStartingProfile first_spawn_profile => Scenario.StartingProfileDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            Unnamed = new ScenarioEntity<ISound>(0, scenarioTag.WellKnownItems[0]);
        }
    }
}