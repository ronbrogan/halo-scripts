namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_elongation : ScenarioScriptBase
    {
        public ScenarioEntity<IBloc> crate_left00 { get; set; }
        public ScenarioEntity<IBloc> crate_right00 { get; set; }
        public ScenarioEntity<IBloc> crate_left01 { get; set; }
        public ScenarioEntity<IBloc> crate_left02 { get; set; }
        public ScenarioEntity<IBloc> crate_left03 { get; set; }
        public ScenarioEntity<IBloc> crate_left04 { get; set; }
        public ScenarioEntity<IBloc> crate_left05 { get; set; }
        public ScenarioEntity<IBloc> crate_left06 { get; set; }
        public ScenarioEntity<IBloc> crate_left07 { get; set; }
        public ScenarioEntity<IBloc> crate_left08 { get; set; }
        public ScenarioEntity<IBloc> crate_left09 { get; set; }
        public ScenarioEntity<IBloc> crate_left10 { get; set; }
        public ScenarioEntity<IBloc> crate_left11 { get; set; }
        public ScenarioEntity<IBloc> crate_right01 { get; set; }
        public ScenarioEntity<IBloc> crate_right02 { get; set; }
        public ScenarioEntity<IBloc> crate_right03 { get; set; }
        public ScenarioEntity<IBloc> crate_right04 { get; set; }
        public ScenarioEntity<IBloc> crate_right05 { get; set; }
        public ScenarioEntity<IBloc> crate_right06 { get; set; }
        public ScenarioEntity<IBloc> crate_right07 { get; set; }
        public ScenarioEntity<IBloc> crate_right08 { get; set; }
        public ScenarioEntity<IBloc> crate_right09 { get; set; }
        public ScenarioEntity<IBloc> crate_right10 { get; set; }
        public ScenarioEntity<IBloc> crate_right11 { get; set; }
        public ITriggerVolume tv_crate_eraser_right => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume tv_crate_eraser_left => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume kill_zone => Scenario.TriggerVolumes[2].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            crate_left00 = new ScenarioEntity<IBloc>(0, scenarioTag.WellKnownItems[0]);
            crate_right00 = new ScenarioEntity<IBloc>(1, scenarioTag.WellKnownItems[1]);
            crate_left01 = new ScenarioEntity<IBloc>(2, scenarioTag.WellKnownItems[2]);
            crate_left02 = new ScenarioEntity<IBloc>(3, scenarioTag.WellKnownItems[3]);
            crate_left03 = new ScenarioEntity<IBloc>(4, scenarioTag.WellKnownItems[4]);
            crate_left04 = new ScenarioEntity<IBloc>(5, scenarioTag.WellKnownItems[5]);
            crate_left05 = new ScenarioEntity<IBloc>(6, scenarioTag.WellKnownItems[6]);
            crate_left06 = new ScenarioEntity<IBloc>(7, scenarioTag.WellKnownItems[7]);
            crate_left07 = new ScenarioEntity<IBloc>(8, scenarioTag.WellKnownItems[8]);
            crate_left08 = new ScenarioEntity<IBloc>(9, scenarioTag.WellKnownItems[9]);
            crate_left09 = new ScenarioEntity<IBloc>(10, scenarioTag.WellKnownItems[10]);
            crate_left10 = new ScenarioEntity<IBloc>(11, scenarioTag.WellKnownItems[11]);
            crate_left11 = new ScenarioEntity<IBloc>(12, scenarioTag.WellKnownItems[12]);
            crate_right01 = new ScenarioEntity<IBloc>(13, scenarioTag.WellKnownItems[13]);
            crate_right02 = new ScenarioEntity<IBloc>(14, scenarioTag.WellKnownItems[14]);
            crate_right03 = new ScenarioEntity<IBloc>(15, scenarioTag.WellKnownItems[15]);
            crate_right04 = new ScenarioEntity<IBloc>(16, scenarioTag.WellKnownItems[16]);
            crate_right05 = new ScenarioEntity<IBloc>(17, scenarioTag.WellKnownItems[17]);
            crate_right06 = new ScenarioEntity<IBloc>(18, scenarioTag.WellKnownItems[18]);
            crate_right07 = new ScenarioEntity<IBloc>(19, scenarioTag.WellKnownItems[19]);
            crate_right08 = new ScenarioEntity<IBloc>(20, scenarioTag.WellKnownItems[20]);
            crate_right09 = new ScenarioEntity<IBloc>(21, scenarioTag.WellKnownItems[21]);
            crate_right10 = new ScenarioEntity<IBloc>(22, scenarioTag.WellKnownItems[22]);
            crate_right11 = new ScenarioEntity<IBloc>(23, scenarioTag.WellKnownItems[23]);
        }
    }
}