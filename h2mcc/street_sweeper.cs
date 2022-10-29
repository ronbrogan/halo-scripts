namespace OpenH2.Scripts.Generatedscenarios.multi
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\multi\\street_sweeper\\street_sweeper")]
    public partial class scnr_street_sweeper : ScenarioScriptBase
    {
        [ScriptMethod(0, Lifecycle.Static)]
        public async Task<IUnit> player0()
        {
            return unit(list_get(players(), 0));
        }
    }
}