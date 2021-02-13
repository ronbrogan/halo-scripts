namespace OpenH2.Scripts.Generatedscenarios.ui
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_mainmenu : ScenarioScriptBase
    {
        public ScenarioEntity<IUnit> ui_player2 { get; set; }
        public ScenarioEntity<IScenery> plasma_screen_lower { get; set; }
        public ScenarioEntity<IScenery> plasma_screen_upper { get; set; }
        public ScenarioEntity<IUnit> ui_player1 { get; set; }
        public ScenarioEntity<IUnit> ui_player3 { get; set; }
        public ScenarioEntity<IUnit> ui_player4 { get; set; }
        public ScenarioEntity<IScenery> halo_ring2 { get; set; }
        public ScenarioEntity<IUnit> ui_player1b { get; set; }
        public ScenarioEntity<IUnit> ui_player2b { get; set; }
        public ScenarioEntity<IUnit> ui_player3b { get; set; }
        public ScenarioEntity<IUnit> ui_player4b { get; set; }
        public ScenarioEntity<IUnit> ui_player1c { get; set; }
        public ScenarioEntity<IUnit> ui_player1d { get; set; }
        public ScenarioEntity<IScenery> ui_carrier { get; set; }
        public ScenarioEntity<IScenery> ui_flak_01 { get; set; }
        public ScenarioEntity<IScenery> ui_flak_02 { get; set; }
        public ScenarioEntity<IScenery> ui_flak_03 { get; set; }
        public ScenarioEntity<IScenery> ui_flak_04 { get; set; }
        public ScenarioEntity<IScenery> ui_flak_05 { get; set; }
        public ICameraPathTarget Unnamed => Scenario.CameraPathTargets[0];
        public ICameraPathTarget scene_01_alphahalo => Scenario.CameraPathTargets[1];
        public ICameraPathTarget scene_02_earth => Scenario.CameraPathTargets[2];
        public ICameraPathTarget scene_04_highcharity => Scenario.CameraPathTargets[3];
        public ICameraPathTarget scene_03_deltahalo => Scenario.CameraPathTargets[4];
        public ICameraPathTarget scene_05_empty => Scenario.CameraPathTargets[5];
        public ICameraPathTarget ui_path_01 => Scenario.CameraPathTargets[6];
        public ICameraPathTarget ui_path_02 => Scenario.CameraPathTargets[7];
        public ICameraPathTarget ui_path_03 => Scenario.CameraPathTargets[8];
        public ICameraPathTarget ui_path_04 => Scenario.CameraPathTargets[9];
        public ICameraPathTarget ui_path_05 => Scenario.CameraPathTargets[10];
        public ICameraPathTarget ui_path_06 => Scenario.CameraPathTargets[11];
        public ICameraPathTarget ui_path_07 => Scenario.CameraPathTargets[12];
        public ICameraPathTarget ui_path_08 => Scenario.CameraPathTargets[13];
        public ICameraPathTarget ui_path_09 => Scenario.CameraPathTargets[14];
        public ICameraPathTarget ui_path_10 => Scenario.CameraPathTargets[15];
        public ICameraPathTarget ui_path_11 => Scenario.CameraPathTargets[16];
        public ICameraPathTarget ui_path_12 => Scenario.CameraPathTargets[17];
        public ILocationFlag anchor_flag_x01 => Scenario.LocationFlagDefinitions[0];
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            ui_player2 = new ScenarioEntity<IUnit>(0, scenarioTag.WellKnownItems[0]);
            plasma_screen_lower = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            plasma_screen_upper = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            ui_player1 = new ScenarioEntity<IUnit>(3, scenarioTag.WellKnownItems[3]);
            ui_player3 = new ScenarioEntity<IUnit>(4, scenarioTag.WellKnownItems[4]);
            ui_player4 = new ScenarioEntity<IUnit>(5, scenarioTag.WellKnownItems[5]);
            halo_ring2 = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            ui_player1b = new ScenarioEntity<IUnit>(7, scenarioTag.WellKnownItems[7]);
            ui_player2b = new ScenarioEntity<IUnit>(8, scenarioTag.WellKnownItems[8]);
            ui_player3b = new ScenarioEntity<IUnit>(9, scenarioTag.WellKnownItems[9]);
            ui_player4b = new ScenarioEntity<IUnit>(10, scenarioTag.WellKnownItems[10]);
            ui_player1c = new ScenarioEntity<IUnit>(11, scenarioTag.WellKnownItems[11]);
            ui_player1d = new ScenarioEntity<IUnit>(12, scenarioTag.WellKnownItems[12]);
            ui_carrier = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            ui_flak_01 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            ui_flak_02 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            ui_flak_03 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            ui_flak_04 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            ui_flak_05 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
        }
    }
}