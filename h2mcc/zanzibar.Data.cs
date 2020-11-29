namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_zanzibar : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> bob { get; set; }
        public ScenarioEntity<IScenery> bob1 { get; set; }
        public ScenarioEntity<IScenery> bob2 { get; set; }
        public ScenarioEntity<IScenery> bob3 { get; set; }
        public ScenarioEntity<IScenery> rifle { get; set; }
        public ScenarioEntity<IScenery> blade { get; set; }
        public ScenarioEntity<IBloc> e3_coil_01 { get; set; }
        public ScenarioEntity<IBloc> e3_coil_02 { get; set; }
        public ScenarioEntity<IBloc> e3_coil_03 { get; set; }
        public ScenarioEntity<IUnit> elite { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IWeapon> e3_flag { get; set; }
        public ScenarioEntity<IDevice> house_gate { get; set; }
        public ICameraPathTarget tour_1 => Scenario.CameraPathTargets[0].GameObject;
        public ICameraPathTarget tour_2 => Scenario.CameraPathTargets[1].GameObject;
        public ICameraPathTarget tour_3 => Scenario.CameraPathTargets[2].GameObject;
        public ICameraPathTarget tour_4 => Scenario.CameraPathTargets[3].GameObject;
        public ICameraPathTarget tour_5 => Scenario.CameraPathTargets[4].GameObject;
        public ICameraPathTarget tour_6 => Scenario.CameraPathTargets[5].GameObject;
        public ICameraPathTarget tour_7 => Scenario.CameraPathTargets[6].GameObject;
        public ICameraPathTarget tour_8 => Scenario.CameraPathTargets[7].GameObject;
        public ICameraPathTarget tour_9 => Scenario.CameraPathTargets[8].GameObject;
        public ICameraPathTarget tour_10 => Scenario.CameraPathTargets[9].GameObject;
        public ICameraPathTarget tour_11 => Scenario.CameraPathTargets[10].GameObject;
        public ICameraPathTarget tour_12a => Scenario.CameraPathTargets[11].GameObject;
        public ICameraPathTarget tour_12b => Scenario.CameraPathTargets[12].GameObject;
        public ICameraPathTarget tour_13 => Scenario.CameraPathTargets[13].GameObject;
        public ICameraPathTarget tour_14 => Scenario.CameraPathTargets[14].GameObject;
        public ICameraPathTarget tour_15 => Scenario.CameraPathTargets[15].GameObject;
        public ICameraPathTarget tour_16 => Scenario.CameraPathTargets[16].GameObject;
        public ICameraPathTarget tour_17 => Scenario.CameraPathTargets[17].GameObject;
        public ICameraPathTarget tour_18a => Scenario.CameraPathTargets[18].GameObject;
        public ICameraPathTarget tour_18b => Scenario.CameraPathTargets[19].GameObject;
        public ICameraPathTarget tour_19a => Scenario.CameraPathTargets[20].GameObject;
        public ICameraPathTarget tour_19b => Scenario.CameraPathTargets[21].GameObject;
        public ICameraPathTarget tour_20 => Scenario.CameraPathTargets[22].GameObject;
        public ICameraPathTarget tour_21 => Scenario.CameraPathTargets[23].GameObject;
        public ICameraPathTarget tour_22 => Scenario.CameraPathTargets[24].GameObject;
        public ICameraPathTarget tour_23 => Scenario.CameraPathTargets[25].GameObject;
        public ICameraPathTarget tour_24b => Scenario.CameraPathTargets[26].GameObject;
        public ICameraPathTarget tour_25 => Scenario.CameraPathTargets[27].GameObject;
        public ICameraPathTarget tour_26 => Scenario.CameraPathTargets[28].GameObject;
        public ICameraPathTarget tour_27 => Scenario.CameraPathTargets[29].GameObject;
        public ICameraPathTarget intro_1 => Scenario.CameraPathTargets[30].GameObject;
        public ICameraPathTarget intro_2 => Scenario.CameraPathTargets[31].GameObject;
        public ICameraPathTarget intro_3 => Scenario.CameraPathTargets[32].GameObject;
        public ICameraPathTarget intro_chief_1 => Scenario.CameraPathTargets[33].GameObject;
        public ICameraPathTarget intro_chief_2 => Scenario.CameraPathTargets[34].GameObject;
        public ICameraPathTarget intro_chief_3 => Scenario.CameraPathTargets[35].GameObject;
        public ICameraPathTarget intro_chief_4 => Scenario.CameraPathTargets[36].GameObject;
        public ICameraPathTarget intro_chief_5 => Scenario.CameraPathTargets[37].GameObject;
        public ICameraPathTarget intro_chief_6 => Scenario.CameraPathTargets[38].GameObject;
        public ICameraPathTarget intro_chief_7 => Scenario.CameraPathTargets[39].GameObject;
        public ICameraPathTarget intro_chief_8 => Scenario.CameraPathTargets[40].GameObject;
        public ICameraPathTarget intro_elite_1 => Scenario.CameraPathTargets[41].GameObject;
        public ICameraPathTarget intro_elite_2 => Scenario.CameraPathTargets[42].GameObject;
        public ICameraPathTarget intro_elite_3 => Scenario.CameraPathTargets[43].GameObject;
        public ICameraPathTarget intro_elite_4 => Scenario.CameraPathTargets[44].GameObject;
        public ICameraPathTarget intro_elite_5 => Scenario.CameraPathTargets[45].GameObject;
        public ICameraPathTarget intro_elite_6 => Scenario.CameraPathTargets[46].GameObject;
        public ICameraPathTarget intro_elite_7 => Scenario.CameraPathTargets[47].GameObject;
        public ICameraPathTarget tour_24a => Scenario.CameraPathTargets[48].GameObject;
        public ILocationFlag e3_crane_destroy => Scenario.LocationFlagDefinitions[0].GameObject;
        public ILocationFlag e3_coil_destroy => Scenario.LocationFlagDefinitions[1].GameObject;
        public ILocationFlag e3_roost_destroy_01 => Scenario.LocationFlagDefinitions[2].GameObject;
        public ILocationFlag e3_roost_destroy_02 => Scenario.LocationFlagDefinitions[3].GameObject;
        public ILocationFlag e3_roost_destroy_03 => Scenario.LocationFlagDefinitions[4].GameObject;
        public ILocationFlag e3_roost_destroy_04 => Scenario.LocationFlagDefinitions[5].GameObject;
        public ITriggerVolume kill_sharks => Scenario.TriggerVolumes[0].GameObject;
        public IDeviceGroup gate => Scenario.DeviceGroupDefinitions[0].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            bob = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            bob1 = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            bob2 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            bob3 = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            rifle = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            blade = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            e3_coil_01 = new ScenarioEntity<IBloc>(6, scenarioTag.WellKnownItems[6]);
            e3_coil_02 = new ScenarioEntity<IBloc>(7, scenarioTag.WellKnownItems[7]);
            e3_coil_03 = new ScenarioEntity<IBloc>(8, scenarioTag.WellKnownItems[8]);
            elite = new ScenarioEntity<IUnit>(9, scenarioTag.WellKnownItems[9]);
            chief = new ScenarioEntity<IUnit>(10, scenarioTag.WellKnownItems[10]);
            e3_flag = new ScenarioEntity<IWeapon>(11, scenarioTag.WellKnownItems[11]);
            house_gate = new ScenarioEntity<IDevice>(14, scenarioTag.WellKnownItems[14]);
        }
    }
}