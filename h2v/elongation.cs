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
        [ScriptMethod(0, Lifecycle.Continuous)]
        public async Task crate_spawner_right()
        {
            object_create(crate_right00);
            await sleep(this.k_crate_spacing);
            object_create(crate_right01);
            await sleep(this.k_crate_spacing);
            object_create(crate_right02);
            await sleep(this.k_crate_spacing);
            object_create(crate_right03);
            await sleep(this.k_crate_spacing);
            object_create(crate_right04);
            await sleep(this.k_crate_spacing);
            object_create(crate_right05);
            await sleep(this.k_crate_spacing);
            object_create(crate_right06);
            await sleep(this.k_crate_spacing);
            object_create(crate_right07);
            await sleep(this.k_crate_spacing);
        }

        [ScriptMethod(1, Lifecycle.Continuous)]
        public async Task crate_spawner_left()
        {
            object_create(crate_left00);
            await sleep(this.k_crate_spacing);
            object_create(crate_left01);
            await sleep(this.k_crate_spacing);
            object_create(crate_left02);
            await sleep(this.k_crate_spacing);
            object_create(crate_left03);
            await sleep(this.k_crate_spacing);
            object_create(crate_left04);
            await sleep(this.k_crate_spacing);
            object_create(crate_left05);
            await sleep(this.k_crate_spacing);
            object_create(crate_left06);
            await sleep(this.k_crate_spacing);
            object_create(crate_left07);
            await sleep(this.k_crate_spacing);
        }

        [ScriptMethod(2, Lifecycle.Continuous)]
        public async Task crate_eraser()
        {
            object_destroy(list_get(volume_return_objects(tv_crate_eraser_left), 0));
            object_destroy(list_get(volume_return_objects(tv_crate_eraser_right), 0));
        }
    }
}