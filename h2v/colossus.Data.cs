namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_colossus : ScenarioScriptBase
    {
        public ScenarioEntity<IBloc> hanger_can_01 { get; set; }
        public ScenarioEntity<IBloc> static_01 { get; set; }
        public ScenarioEntity<IBloc> static_02 { get; set; }
        public ScenarioEntity<IBloc> static_03 { get; set; }
        public ScenarioEntity<IBloc> static_04 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_07 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_02 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_03 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_04 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_05 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_06 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_08 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_09 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_10 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_11 { get; set; }
        public ScenarioEntity<IBloc> hanger_can_12 { get; set; }
        public ITriggerVolume can_kill_volume => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume kill_eamon => Scenario.TriggerVolumes[1].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            hanger_can_01 = new ScenarioEntity<IBloc>(0, scenarioTag.WellKnownItems[0]);
            static_01 = new ScenarioEntity<IBloc>(1, scenarioTag.WellKnownItems[1]);
            static_02 = new ScenarioEntity<IBloc>(2, scenarioTag.WellKnownItems[2]);
            static_03 = new ScenarioEntity<IBloc>(3, scenarioTag.WellKnownItems[3]);
            static_04 = new ScenarioEntity<IBloc>(4, scenarioTag.WellKnownItems[4]);
            hanger_can_07 = new ScenarioEntity<IBloc>(5, scenarioTag.WellKnownItems[5]);
            hanger_can_02 = new ScenarioEntity<IBloc>(6, scenarioTag.WellKnownItems[6]);
            hanger_can_03 = new ScenarioEntity<IBloc>(7, scenarioTag.WellKnownItems[7]);
            hanger_can_04 = new ScenarioEntity<IBloc>(8, scenarioTag.WellKnownItems[8]);
            hanger_can_05 = new ScenarioEntity<IBloc>(9, scenarioTag.WellKnownItems[9]);
            hanger_can_06 = new ScenarioEntity<IBloc>(10, scenarioTag.WellKnownItems[10]);
            hanger_can_08 = new ScenarioEntity<IBloc>(11, scenarioTag.WellKnownItems[11]);
            hanger_can_09 = new ScenarioEntity<IBloc>(12, scenarioTag.WellKnownItems[12]);
            hanger_can_10 = new ScenarioEntity<IBloc>(13, scenarioTag.WellKnownItems[13]);
            hanger_can_11 = new ScenarioEntity<IBloc>(14, scenarioTag.WellKnownItems[14]);
            hanger_can_12 = new ScenarioEntity<IBloc>(15, scenarioTag.WellKnownItems[15]);
        }
    }
}