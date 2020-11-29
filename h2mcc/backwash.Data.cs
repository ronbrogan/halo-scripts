namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_backwash : ScenarioScriptBase
    {
        public ScenarioEntity<ISound> core1 { get; set; }
        public ScenarioEntity<ISound> core2 { get; set; }
        public ScenarioEntity<ISound> core3 { get; set; }
        public ScenarioEntity<ISound> core4 { get; set; }
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            core1 = new ScenarioEntity<ISound>(0, scenarioTag.WellKnownItems[0]);
            core2 = new ScenarioEntity<ISound>(1, scenarioTag.WellKnownItems[1]);
            core3 = new ScenarioEntity<ISound>(2, scenarioTag.WellKnownItems[2]);
            core4 = new ScenarioEntity<ISound>(3, scenarioTag.WellKnownItems[3]);
        }
    }
}