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
        [ScriptMethod(0, Lifecycle.Startup)]
        public async Task mainmenu_initialize()
        {
            cinematic_start();
            print("enabling cinematic lighting and shadows");
            cinematic_lighting_set_primary_light(45F, 240F, 0.45F, 0.45F, 0.45F);
            cinematic_lighting_set_secondary_light(-45F, 30F, 0.1F, 0.1F, 0.1F);
            cinematic_lighting_set_ambient_light(0.1F, 0.1F, 0.1F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            object_uses_cinematic_lighting(ui_player1.Entity, true);
            object_uses_cinematic_lighting(ui_player2.Entity, true);
            object_uses_cinematic_lighting(ui_player3.Entity, true);
            object_uses_cinematic_lighting(ui_player4.Entity, true);
            object_uses_cinematic_lighting(ui_player1b.Entity, true);
            object_uses_cinematic_lighting(ui_player2b.Entity, true);
            object_uses_cinematic_lighting(ui_player3b.Entity, true);
            object_uses_cinematic_lighting(ui_player4b.Entity, true);
            object_uses_cinematic_lighting(ui_player1c.Entity, true);
            object_uses_cinematic_lighting(ui_player1d.Entity, true);
            cinematic_lightmap_shadow_enable();
            object_set_function_variable(ui_carrier.Entity, "grav_lift_control", 1F, 0F);
        }

        [ScriptMethod(1, Lifecycle.Continuous)]
        public async Task mainmenu_flythrough()
        {
            camera_control(true);
            camera_set(ui_path_01, 0);
            await sleep(90);
            camera_set(ui_path_02, 500);
            await sleep(250);
            camera_set(ui_path_03, 500);
            await sleep(250);
            camera_set(ui_path_04, 500);
            await sleep(250);
            camera_set(ui_path_05, 500);
            await sleep(250);
            camera_set(ui_path_06, 500);
            await sleep(250);
            camera_set(ui_path_07, 500);
            await sleep(250);
            camera_set(ui_path_08, 500);
            await sleep(250);
            camera_set(ui_path_09, 500);
            await sleep(250);
            camera_set(ui_path_10, 400);
            await sleep(200);
            camera_set(ui_path_11, 400);
            await sleep(200);
            camera_set(ui_path_12, 400);
            await sleep(200);
            camera_set(ui_path_01, 300);
            await sleep(300);
        }
    }
}