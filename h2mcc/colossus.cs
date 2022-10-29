namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\multi\\colossus\\colossus")]
    public partial class scnr_colossus : ScenarioScriptBase
    {
#region Fields
        int launch_time;
        public scnr_colossus(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.launch_time = 400;
        }

#endregion
        [ScriptMethod(0, Lifecycle.Continuous)]
        public async Task recycling_can_spawner_r()
        {
            await sleep(200);
            if (list_count(hanger_can_01.Entity) == 0)
            {
                object_create(hanger_can_01);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_02.Entity) == 0)
            {
                object_create(hanger_can_02);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_03.Entity) == 0)
            {
                object_create(hanger_can_03);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_04.Entity) == 0)
            {
                object_create(hanger_can_04);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_05.Entity) == 0)
            {
                object_create(hanger_can_05);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_06.Entity) == 0)
            {
                object_create(hanger_can_06);
                await sleep(this.launch_time);
            }
        }

        [ScriptMethod(1, Lifecycle.Continuous)]
        public async Task recycling_can_spawner_l()
        {
            if (list_count(hanger_can_07.Entity) == 0)
            {
                object_create(hanger_can_07);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_08.Entity) == 0)
            {
                object_create(hanger_can_08);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_09.Entity) == 0)
            {
                object_create(hanger_can_09);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_10.Entity) == 0)
            {
                object_create(hanger_can_10);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_11.Entity) == 0)
            {
                object_create(hanger_can_11);
                await sleep(this.launch_time);
            }

            if (list_count(hanger_can_12.Entity) == 0)
            {
                object_create(hanger_can_12);
                await sleep(this.launch_time);
            }
        }

        [ScriptMethod(2, Lifecycle.Continuous)]
        public async Task hanger_can_killer()
        {
            object_destroy(list_get(volume_return_objects(can_kill_volume), 0));
        }
    }
}