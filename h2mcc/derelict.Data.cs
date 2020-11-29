namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_derelict : ScenarioScriptBase
    {
        public ScenarioEntity<IBloc> alpha_lift { get; set; }
        public ScenarioEntity<IBloc> beta_lift { get; set; }
        public ScenarioEntity<IScenery> alpha_ctf_terr { get; set; }
        public ScenarioEntity<IScenery> bravo_ctf_terr { get; set; }
        public ScenarioEntity<IScenery> hall1_terr { get; set; }
        public ScenarioEntity<IScenery> hall2_terr { get; set; }
        public ScenarioEntity<IScenery> center_low { get; set; }
        public ScenarioEntity<IScenery> blue_effect { get; set; }
        public ScenarioEntity<IScenery> red_effect { get; set; }
        public ScenarioEntity<IScenery> drips_1 { get; set; }
        public ScenarioEntity<IScenery> drips_2 { get; set; }
        public ScenarioEntity<IScenery> drips_3 { get; set; }
        public ScenarioEntity<IScenery> drips_4 { get; set; }
        public ScenarioEntity<IScenery> drips_5 { get; set; }
        public ScenarioEntity<IScenery> drips_6 { get; set; }
        public ScenarioEntity<IScenery> drips_7 { get; set; }
        public ScenarioEntity<IScenery> lametrees { get; set; }
        public ScenarioEntity<ISound> red { get; set; }
        public ScenarioEntity<ISound> blue { get; set; }
        public ScenarioEntity<ISound> throb { get; set; }
        public ScenarioEntity<ISound> redf { get; set; }
        public ScenarioEntity<ISound> bluef { get; set; }
        public ScenarioEntity<IScenery> drips_8 { get; set; }
        public ScenarioEntity<ISound> cool_middle { get; set; }
        public ITriggerVolume kill_top => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume kill_bottom => Scenario.TriggerVolumes[1].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            alpha_lift = new ScenarioEntity<IBloc>(0, scenarioTag.WellKnownItems[0]);
            beta_lift = new ScenarioEntity<IBloc>(1, scenarioTag.WellKnownItems[1]);
            alpha_ctf_terr = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            bravo_ctf_terr = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            hall1_terr = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            hall2_terr = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            center_low = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            blue_effect = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            red_effect = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            drips_1 = new ScenarioEntity<IScenery>(113, scenarioTag.WellKnownItems[113]);
            drips_2 = new ScenarioEntity<IScenery>(114, scenarioTag.WellKnownItems[114]);
            drips_3 = new ScenarioEntity<IScenery>(115, scenarioTag.WellKnownItems[115]);
            drips_4 = new ScenarioEntity<IScenery>(116, scenarioTag.WellKnownItems[116]);
            drips_5 = new ScenarioEntity<IScenery>(117, scenarioTag.WellKnownItems[117]);
            drips_6 = new ScenarioEntity<IScenery>(118, scenarioTag.WellKnownItems[118]);
            drips_7 = new ScenarioEntity<IScenery>(119, scenarioTag.WellKnownItems[119]);
            lametrees = new ScenarioEntity<IScenery>(120, scenarioTag.WellKnownItems[120]);
            red = new ScenarioEntity<ISound>(121, scenarioTag.WellKnownItems[121]);
            blue = new ScenarioEntity<ISound>(122, scenarioTag.WellKnownItems[122]);
            throb = new ScenarioEntity<ISound>(123, scenarioTag.WellKnownItems[123]);
            redf = new ScenarioEntity<ISound>(124, scenarioTag.WellKnownItems[124]);
            bluef = new ScenarioEntity<ISound>(125, scenarioTag.WellKnownItems[125]);
            drips_8 = new ScenarioEntity<IScenery>(126, scenarioTag.WellKnownItems[126]);
            cool_middle = new ScenarioEntity<ISound>(127, scenarioTag.WellKnownItems[127]);
        }
    }
}