namespace OpenH2.Scripts.Generatedscenarios.shared
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_shared : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> receiver { get; set; }
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            receiver = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
        }
    }
}