namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\multi\\needle\\needle")]
    public partial class scnr_needle : ScenarioScriptBase
    {
        [ScriptMethod(Lifecycle.Static)]
        public async Task<IUnit> player0()
        {
            return Engine.unit(Engine.list_get(Engine.players(), 0));
        }
    }
}