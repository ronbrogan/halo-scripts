namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_highplains : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> crane { get; set; }
        public ScenarioEntity<IScenery> control_room { get; set; }
        public ScenarioEntity<IScenery> center { get; set; }
        public ScenarioEntity<IScenery> red_tower { get; set; }
        public ScenarioEntity<IScenery> blue_tower { get; set; }
        public ScenarioEntity<IScenery> bunker { get; set; }
        public ScenarioEntity<IBloc> hvac_lift { get; set; }
        public ScenarioEntity<ISound> end_of_canal_water___office { get; set; }
        public ScenarioEntity<ISound> end_of_canal_water___storage { get; set; }
        public ScenarioEntity<IScenery> center_high_terries { get; set; }
        public ScenarioEntity<ISound> crane_base { get; set; }
        public ScenarioEntity<ISound> crane_tower_cylinder { get; set; }
        public ScenarioEntity<ISound> garage_ambience { get; set; }
        public ScenarioEntity<ISound> city_on_fire { get; set; }
        public ScenarioEntity<ISound> control_desk { get; set; }
        public ScenarioEntity<ISound> vending_machine { get; set; }
        public ScenarioEntity<ISound> storage1 { get; set; }
        public ScenarioEntity<ISound> storage2 { get; set; }
        public ScenarioEntity<ISound> storage3 { get; set; }
        public ScenarioEntity<ISound> vertical_pipes { get; set; }
        public ScenarioEntity<ISound> high_vent_1 { get; set; }
        public ScenarioEntity<ISound> high_vent_2 { get; set; }
        public ScenarioEntity<ISound> high_vent_6 { get; set; }
        public ScenarioEntity<ISound> high_vent_5 { get; set; }
        public ScenarioEntity<ISound> high_vent_4 { get; set; }
        public ScenarioEntity<ISound> high_vent_3 { get; set; }
        public ScenarioEntity<IScenery> platform { get; set; }
        public ScenarioEntity<IScenery> storage { get; set; }
        public ScenarioEntity<ISound> steam { get; set; }
        public ScenarioEntity<ISound> steamcloseup { get; set; }
        public ScenarioEntity<ISound> broken_light { get; set; }
        public ScenarioEntity<ISound> vertical_pipe2 { get; set; }
        public ScenarioEntity<ISound> vertical_pipe_3 { get; set; }
        public ScenarioEntity<ISound> pipesvent1 { get; set; }
        public ScenarioEntity<ISound> pipesvent2 { get; set; }
        public ScenarioEntity<ISound> roofwalkvent { get; set; }
        public ScenarioEntity<ISound> bigwallvent { get; set; }
        public ScenarioEntity<ISound> bluebasepipes1 { get; set; }
        public ScenarioEntity<ISound> bluebasepipes2 { get; set; }
        public ScenarioEntity<ISound> matthole { get; set; }
        public ITriggerVolume kill_1 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume kill_2 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume kill_3 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume kill_4 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume kill_5 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume kill_6 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume kill_7 => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume kill_8 => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume kill_9 => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume kill_10 => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume kill_11 => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume kill_12 => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume kill_13 => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume kill_14 => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume kill_15 => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume kill_16 => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume kill_17 => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume kill_18 => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume kill_19 => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume kill_20 => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume kill_21 => Scenario.TriggerVolumes[20].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            crane = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            control_room = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            center = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            red_tower = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            blue_tower = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            bunker = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            hvac_lift = new ScenarioEntity<IBloc>(6, scenarioTag.WellKnownItems[6]);
            end_of_canal_water___office = new ScenarioEntity<ISound>(8, scenarioTag.WellKnownItems[8]);
            end_of_canal_water___storage = new ScenarioEntity<ISound>(9, scenarioTag.WellKnownItems[9]);
            center_high_terries = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            crane_base = new ScenarioEntity<ISound>(11, scenarioTag.WellKnownItems[11]);
            crane_tower_cylinder = new ScenarioEntity<ISound>(41, scenarioTag.WellKnownItems[41]);
            garage_ambience = new ScenarioEntity<ISound>(42, scenarioTag.WellKnownItems[42]);
            city_on_fire = new ScenarioEntity<ISound>(43, scenarioTag.WellKnownItems[43]);
            control_desk = new ScenarioEntity<ISound>(45, scenarioTag.WellKnownItems[45]);
            vending_machine = new ScenarioEntity<ISound>(46, scenarioTag.WellKnownItems[46]);
            storage1 = new ScenarioEntity<ISound>(48, scenarioTag.WellKnownItems[48]);
            storage2 = new ScenarioEntity<ISound>(49, scenarioTag.WellKnownItems[49]);
            storage3 = new ScenarioEntity<ISound>(50, scenarioTag.WellKnownItems[50]);
            vertical_pipes = new ScenarioEntity<ISound>(52, scenarioTag.WellKnownItems[52]);
            high_vent_1 = new ScenarioEntity<ISound>(53, scenarioTag.WellKnownItems[53]);
            high_vent_2 = new ScenarioEntity<ISound>(54, scenarioTag.WellKnownItems[54]);
            high_vent_6 = new ScenarioEntity<ISound>(55, scenarioTag.WellKnownItems[55]);
            high_vent_5 = new ScenarioEntity<ISound>(56, scenarioTag.WellKnownItems[56]);
            high_vent_4 = new ScenarioEntity<ISound>(57, scenarioTag.WellKnownItems[57]);
            high_vent_3 = new ScenarioEntity<ISound>(58, scenarioTag.WellKnownItems[58]);
            platform = new ScenarioEntity<IScenery>(60, scenarioTag.WellKnownItems[60]);
            storage = new ScenarioEntity<IScenery>(61, scenarioTag.WellKnownItems[61]);
            steam = new ScenarioEntity<ISound>(64, scenarioTag.WellKnownItems[64]);
            steamcloseup = new ScenarioEntity<ISound>(65, scenarioTag.WellKnownItems[65]);
            broken_light = new ScenarioEntity<ISound>(66, scenarioTag.WellKnownItems[66]);
            vertical_pipe2 = new ScenarioEntity<ISound>(67, scenarioTag.WellKnownItems[67]);
            vertical_pipe_3 = new ScenarioEntity<ISound>(68, scenarioTag.WellKnownItems[68]);
            pipesvent1 = new ScenarioEntity<ISound>(69, scenarioTag.WellKnownItems[69]);
            pipesvent2 = new ScenarioEntity<ISound>(70, scenarioTag.WellKnownItems[70]);
            roofwalkvent = new ScenarioEntity<ISound>(71, scenarioTag.WellKnownItems[71]);
            bigwallvent = new ScenarioEntity<ISound>(72, scenarioTag.WellKnownItems[72]);
            bluebasepipes1 = new ScenarioEntity<ISound>(73, scenarioTag.WellKnownItems[73]);
            bluebasepipes2 = new ScenarioEntity<ISound>(74, scenarioTag.WellKnownItems[74]);
            matthole = new ScenarioEntity<ISound>(75, scenarioTag.WellKnownItems[75]);
        }
    }
}