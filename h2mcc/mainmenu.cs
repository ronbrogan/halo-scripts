namespace OpenH2.Scripts.Generatedscenarios.ui
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\ui\\mainmenu\\mainmenu")]
    public partial class scnr_mainmenu : ScenarioScriptBase
    {
        [ScriptMethod(Lifecycle.Startup)]
        public async Task mainmenu_initialize()
        {
            Engine.cinematic_start();
            Engine.print("enabling cinematic lighting and shadows");
            Engine.cinematic_lighting_set_primary_light(45F, 240F, 0.45F, 0.45F, 0.45F);
            Engine.cinematic_lighting_set_secondary_light(-45F, 30F, 0.1F, 0.1F, 0.1F);
            Engine.cinematic_lighting_set_ambient_light(0.1F, 0.1F, 0.1F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.object_uses_cinematic_lighting(ui_player1.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player2.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player3.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player4.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player1b.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player2b.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player3b.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player4b.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player1c.Entity, true);
            Engine.object_uses_cinematic_lighting(ui_player1d.Entity, true);
            Engine.cinematic_lightmap_shadow_enable();
            Engine.object_set_function_variable(ui_carrier.Entity, "grav_lift_control", 1F, 0F);
        }

        [ScriptMethod(Lifecycle.Continuous)]
        public async Task mainmenu_flythrough()
        {
            Engine.camera_control(true);
            Engine.camera_set(ui_path_01, 0);
            await Engine.sleep(90);
            Engine.camera_set(ui_path_02, 500);
            await Engine.sleep(250);
            Engine.camera_set(ui_path_03, 500);
            await Engine.sleep(250);
            Engine.camera_set(ui_path_04, 500);
            await Engine.sleep(250);
            Engine.camera_set(ui_path_05, 500);
            await Engine.sleep(250);
            Engine.camera_set(ui_path_06, 500);
            await Engine.sleep(250);
            Engine.camera_set(ui_path_07, 500);
            await Engine.sleep(250);
            Engine.camera_set(ui_path_08, 500);
            await Engine.sleep(250);
            Engine.camera_set(ui_path_09, 500);
            await Engine.sleep(250);
            Engine.camera_set(ui_path_10, 400);
            await Engine.sleep(200);
            Engine.camera_set(ui_path_11, 400);
            await Engine.sleep(200);
            Engine.camera_set(ui_path_12, 400);
            await Engine.sleep(200);
            Engine.camera_set(ui_path_01, 300);
            await Engine.sleep(300);
        }
    }
}