namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_triplicate : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> assault { get; set; }
        public ScenarioEntity<IScenery> territories { get; set; }
        public ScenarioEntity<IScenery> territories_2 { get; set; }
        public ScenarioEntity<IScenery> territories_3 { get; set; }
        public ScenarioEntity<IDevice> eastbound_train { get; set; }
        public ScenarioEntity<IDevice> westbound_train { get; set; }
        public ScenarioEntity<IDevice> eastbound_death { get; set; }
        public ScenarioEntity<IDevice> westbound_death { get; set; }
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            assault = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            territories = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            territories_2 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            territories_3 = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            eastbound_train = new ScenarioEntity<IDevice>(4, scenarioTag.WellKnownItems[4]);
            westbound_train = new ScenarioEntity<IDevice>(5, scenarioTag.WellKnownItems[5]);
            eastbound_death = new ScenarioEntity<IDevice>(6, scenarioTag.WellKnownItems[6]);
            westbound_death = new ScenarioEntity<IDevice>(7, scenarioTag.WellKnownItems[7]);
        }
    }
}