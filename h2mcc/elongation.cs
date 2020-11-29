namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\multi\\elongation\\elongation")]
    public partial class scnr_elongation : ScenarioScriptBase
    {
#region Fields
        int k_crate_spacing;
        public scnr_elongation(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.k_crate_spacing = 400;
        }

#endregion
        [ScriptMethod(Lifecycle.Continuous)]
        public async Task crate_spawner_right()
        {
            Engine.object_create(crate_right00);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_right01);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_right02);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_right03);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_right04);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_right05);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_right06);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_right07);
            await Engine.sleep(this.k_crate_spacing);
        }

        [ScriptMethod(Lifecycle.Continuous)]
        public async Task crate_spawner_left()
        {
            Engine.object_create(crate_left00);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_left01);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_left02);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_left03);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_left04);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_left05);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_left06);
            await Engine.sleep(this.k_crate_spacing);
            Engine.object_create(crate_left07);
            await Engine.sleep(this.k_crate_spacing);
        }

        [ScriptMethod(Lifecycle.Continuous)]
        public async Task crate_eraser()
        {
            Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(tv_crate_eraser_left), 0));
            Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(tv_crate_eraser_right), 0));
        }
    }
}