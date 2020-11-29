namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_needle : ScenarioScriptBase
    {
        public ScenarioEntity<ISound> beam_low { get; set; }
        public ScenarioEntity<ISound> island { get; set; }
        public ScenarioEntity<IScenery> blue_flag { get; set; }
        public ScenarioEntity<IScenery> red_flag { get; set; }
        public ScenarioEntity<IScenery> n_flag { get; set; }
        public ScenarioEntity<IScenery> terr1 { get; set; }
        public ScenarioEntity<IScenery> terr2 { get; set; }
        public ScenarioEntity<IScenery> terr4 { get; set; }
        public ScenarioEntity<IScenery> terr3 { get; set; }
        public ScenarioEntity<IScenery> terr5 { get; set; }
        public ScenarioEntity<ISound> beam_main { get; set; }
        public ScenarioEntity<ISound> beam_outer { get; set; }
        public ITriggerVolume kill_trigger => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume kill_trigger_lightbeam => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume kill_trigger_lightbeam2 => Scenario.TriggerVolumes[2].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            beam_low = new ScenarioEntity<ISound>(1, scenarioTag.WellKnownItems[1]);
            island = new ScenarioEntity<ISound>(2, scenarioTag.WellKnownItems[2]);
            blue_flag = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            red_flag = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            n_flag = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            terr1 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            terr2 = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            terr4 = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            terr3 = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            terr5 = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            beam_main = new ScenarioEntity<ISound>(11, scenarioTag.WellKnownItems[11]);
            beam_outer = new ScenarioEntity<ISound>(12, scenarioTag.WellKnownItems[12]);
        }
    }
}