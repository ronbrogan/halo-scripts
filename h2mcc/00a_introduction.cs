namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\00a_introduction\\00a_introduction")]
    public partial class scnr_00a_introduction : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        public scnr_00a_introduction(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
        }

#endregion
        [ScriptMethod(Lifecycle.Static)]
        public async Task<IUnit> player0()
        {
            return Engine.unit(Engine.list_get(Engine.players(), 0));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<IUnit> player1()
        {
            return Engine.unit(Engine.list_get(Engine.players(), 1));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<int> player_count()
        {
            return Engine.list_count(Engine.players());
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task end_segment()
        {
            Engine.camera_control(true);
            Engine.cinematic_start();
            Engine.fade_out(0F, 0F, 0F, 15);
            await Engine.sleep(30);
            Engine.print("end gameplay segment!  thank you for playing!");
            await Engine.sleep(15);
            Engine.print("grab jaime or paul to give feedback!");
            Engine.player_action_test_reset();
            await Engine.sleep(15);
            Engine.print("press the �a� button to reset!");
            await Engine.sleep_until(async () => (bool)Engine.player_action_test_accept());
            Engine.print("reloading map...");
            await Engine.sleep(15);
            Engine.map_reset();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> difficulty_legendary()
        {
            return Engine.game_difficulty_get() // Couldn't generate cast from 'String' to 'GameDifficulty'
 == "legendary";
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> difficulty_heroic()
        {
            return Engine.game_difficulty_get() // Couldn't generate cast from 'String' to 'GameDifficulty'
 == "heroic";
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> difficulty_normal()
        {
            return Engine.game_difficulty_get() // Couldn't generate cast from 'String' to 'GameDifficulty'
 == "normal";
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> cinematic_skip_start()
        {
            Engine.cinematic_skip_start_internal();
            Engine.game_save_cinematic_skip();
            await Engine.sleep_until(async () => !((bool)Engine.game_saving()), 1);
            return !((bool)Engine.game_reverted());
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_skip_stop()
        {
            Engine.cinematic_skip_stop_internal();
            if (!((bool)Engine.game_reverted()))
            {
                Engine.game_revert();
            }
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_fade_to_white()
        {
            Engine.player_enable_input(false);
            Engine.player_camera_control(false);
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_start();
            Engine.fade_out(1F, 1F, 1F, 30);
            await Engine.sleep(30);
            Engine.camera_control(true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_fade_from_white()
        {
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_stop();
            Engine.camera_control(false);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.player_enable_input(true);
            Engine.player_camera_control(true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_fade_from_white_bars()
        {
            Engine.cinematic_stop();
            Engine.cinematic_show_letterbox_immediate(true);
            Engine.camera_control(false);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.player_enable_input(true);
            Engine.player_camera_control(true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_fade_from_black_bars()
        {
            Engine.cinematic_stop();
            Engine.cinematic_show_letterbox_immediate(true);
            Engine.camera_control(false);
            Engine.fade_in(0F, 0F, 0F, 15);
            await Engine.sleep(15);
            Engine.player_enable_input(true);
            Engine.player_camera_control(true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_fade_to_black()
        {
            Engine.player_enable_input(false);
            Engine.player_camera_control(false);
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_start();
            Engine.fade_out(0F, 0F, 0F, 30);
            await Engine.sleep(30);
            Engine.camera_control(true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_fade_from_black()
        {
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_stop();
            Engine.camera_control(false);
            Engine.fade_in(0F, 0F, 0F, 15);
            await Engine.sleep(15);
            Engine.player_enable_input(true);
            Engine.player_camera_control(true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_snap_to_black()
        {
            Engine.player_enable_input(false);
            Engine.player_camera_control(false);
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.hud_cinematic_fade(0F, 0F);
            Engine.cinematic_start();
            Engine.cinematic_show_letterbox_immediate(true);
            Engine.camera_control(true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_snap_to_white()
        {
            Engine.player_enable_input(false);
            Engine.player_camera_control(false);
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.hud_cinematic_fade(0F, 0F);
            Engine.cinematic_start();
            Engine.cinematic_show_letterbox_immediate(true);
            Engine.camera_control(true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_stash_players()
        {
            Engine.object_hide(await this.player0(), true);
            Engine.object_hide(await this.player1(), true);
            Engine.object_cannot_take_damage(Engine.players());
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_unstash_players()
        {
            Engine.object_hide(await this.player0(), false);
            Engine.object_hide(await this.player1(), false);
            Engine.object_can_take_damage(Engine.players());
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _stealth_toggle_monitor()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () =>
                {
                    if (Engine.unit_get_shield(await this.player0()) >= 1F && (bool)Engine.player_action_test_vision_trigger())
                    {
                        return 1F == 1F;
                    }
                    else
                    {
                        Engine.player_action_test_reset();
                        return 1F == 0F;
                    }
                }, 1);
                Engine.cheat_active_camouflage_by_player(0, true);
                Engine.print("stealth engaged");
                Engine.unit_set_maximum_vitality(await this.player0(), 50F, 0F);
                Engine.unit_set_current_vitality(await this.player0(), 50F, 0F);
                Engine.object_set_shield(await this.player0(), 0F);
                await Engine.sleep(30);
                Engine.player_action_test_reset();
                await Engine.sleep_until(async () => Engine.object_get_health(await this.player0()) < 1F || (bool)Engine.player_action_test_vision_trigger(), 1);
                Engine.cheat_active_camouflage_by_player(0, false);
                Engine.print("stealth disengaged");
                Engine.unit_set_maximum_vitality(await this.player0(), 30F, 70F);
                Engine.object_set_shield(await this.player0(), 0F);
                await Engine.sleep(30);
                Engine.player_action_test_reset();
                return false;
            }, 1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _stealth_timer_monitor()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () =>
                {
                    if ((bool)Engine.player_action_test_vision_trigger())
                    {
                        return 1F == 1F;
                    }
                    else
                    {
                        Engine.player_action_test_reset();
                        return 1F == 0F;
                    }
                }, 1);
                Engine.cheat_active_camouflage_by_player(0, true);
                Engine.print("stealth engaged");
                await Engine.sleep(15);
                Engine.player_action_test_reset();
                await Engine.sleep_until(async () => (bool)Engine.player_action_test_vision_trigger() || (bool)Engine.player_action_test_primary_trigger() || (bool)Engine.player_action_test_grenade_trigger() || (bool)Engine.player_action_test_melee(), 1, 9 * 30);
                Engine.cheat_active_camouflage_by_player(0, false);
                Engine.print("stealth disengaged");
                await Engine.sleep(30);
                Engine.player_action_test_reset();
                await Engine.sleep_until(async () =>
                {
                    Engine.print("+");
                    return false;
                }, 30, 5 * 30);
                return false;
            }, 1);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task activate_stealth_toggle_monitor()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task activate_stealth_timer_monitor()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task playtest_mission()
        {
            if ((bool)Engine.game_is_playtest())
            {
                await Engine.sleep(30);
                Engine.hud_set_training_text("playtest_raisehand");
                Engine.hud_show_training_text(true);
                Engine.player_action_test_reset();
                await Engine.sleep_until(async () => (bool)Engine.player_action_test_accept(), 1);
                Engine.hud_show_training_text(false);
                await Engine.sleep(30);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3957066342U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\hc_introcine_love\\hc_cin_volume\\hc_cin_volume", 3835822892U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3800236301U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3837789002U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_02\\halo_destroyed_02", 3798204654U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_01\\halo_destroyed_01", 3796500692U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\threshold_space\\threshold_space", 3795910859U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3799843079U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\battle_cruiser", 3790602362U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3822781029U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3836740410U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await Engine.sleep(216);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_01b_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3800236301U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3955886676U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3954117177U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\hc_introcine_love\\hc_cin_volume\\hc_cin_volume", 3835822892U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3933538559U), 102);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3933538559U), 103);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3933538559U), 104);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3933538559U), 105);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3933538559U), 106);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3933538559U), 107);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3933538559U), 108);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3933538559U), 109);
            await Engine.sleep(32);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_02_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 46, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3954117177U), 1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 9);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 32);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, false);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3957066342U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            await Engine.sleep(39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 34);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795124415U), 0);
            await Engine.sleep(114);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3821404752U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3821404752U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 5);
            await Engine.sleep(89);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 2);
            await Engine.sleep(100);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3954117177U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\reach_space\\reach_space", 3798597876U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\battle_cruiser", 3790602362U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\pillarofautumn\\pillarofautumn", 3793682601U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3837789002U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3838182224U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_02\\halo_destroyed_02", 3798204654U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_01\\halo_destroyed_01", 3796500692U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\threshold_space\\threshold_space", 3795910859U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await Engine.sleep(151);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3799843079U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_04_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_05_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\hc_introcine_love\\hc_cin_volume\\hc_cin_volume", 3835822892U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3800236301U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await Engine.sleep(60);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_06_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795124415U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3957066342U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 5);
            await Engine.sleep(25);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await Engine.sleep(93);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            await Engine.sleep(87);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 7);
            await Engine.sleep(110);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 1);
            await Engine.sleep(43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 2);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_07_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo_exploding\\halo_exploding", 3791847565U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_08_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3957066342U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3821404752U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3821404752U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\hc_introcine_love\\hc_cin_volume\\hc_cin_volume", 3835822892U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3800236301U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3824484991U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            await Engine.sleep(75);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 5);
            await Engine.sleep(80);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795124415U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 10);
            await Engine.sleep(118);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 2);
            await Engine.sleep(412);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            await Engine.sleep(111);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3957066342U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858236546U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3954117177U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_09_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3821404752U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3821404752U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795124415U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 10);
            await Engine.sleep(77);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3954117177U), 0);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, false);
            await Engine.sleep(41);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795124415U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 34);
            await Engine.sleep(11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 10);
            await Engine.sleep(92);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 46, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3957066342U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3954117177U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            await Engine.sleep(122);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 7);
            await Engine.sleep(68);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_10_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3957066342U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819110957U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3954117177U), 0);
            await Engine.sleep(123);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 46, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3838903131U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795124415U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3958246008U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3821404752U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3821404752U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3949988346U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883075069U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 0);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            await Engine.sleep(89);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            await Engine.sleep(75);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3887924807U), 2);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _01_intro_01_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\moon\\moon", 3814064608U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\earth_space\\earth_space", 3810066851U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3808493963U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 3835036448U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\ss_prop", 3829400266U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo\\cairo", 3826188953U), 0);
            await Engine.sleep(146);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\pillarofautumn\\pillarofautumn", 3793682601U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3836740410U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _01_intro_02_predict()
        {
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3920955455U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3920955455U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3920955455U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3920955455U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\power_core\\power_core", 3811574202U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\optics\\optics", 3811049906U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\equipment_cart\\equipment_cart", 3810460073U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_armory\\cairo_armory", 3814457830U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3903981372U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\helmet\\helmet", 3812164035U), 0);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_01_predict_stub()
        {
            Engine.wake(x01_01_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_01b_predict_stub()
        {
            Engine.wake(x01_01b_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_02_predict_stub()
        {
            Engine.wake(x01_02_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_03_predict_stub()
        {
            Engine.wake(x01_03_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_04_predict_stub()
        {
            Engine.wake(x01_04_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_05_predict_stub()
        {
            Engine.wake(x01_05_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_06_predict_stub()
        {
            Engine.wake(x01_06_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_07_predict_stub()
        {
            Engine.wake(x01_07_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_08_predict_stub()
        {
            Engine.wake(x01_08_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_09_predict_stub()
        {
            Engine.wake(x01_09_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_10_predict_stub()
        {
            Engine.wake(x01_10_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _01_intro_01_predict_stub()
        {
            Engine.wake(_01_intro_01_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _01_intro_02_predict_stub()
        {
            Engine.wake(_01_intro_02_predict);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_score_01a()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\music\\x01_01_mus", 3959556748U), default(IGameObject), 1F);
            Engine.print("x01 score 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_foley_01a()
        {
            await Engine.sleep(60);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_01a_fol", 3959622285U), default(IGameObject), 1F);
            Engine.print("x01 foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_supratitle_01()
        {
            await Engine.sleep(420);
            Engine.cinematic_set_title(cinematic_title0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_01a()
        {
            Engine.cinematic_lighting_set_primary_light(-23F, 152F, 0.576471F, 0.513726F, 0.4F);
            Engine.cinematic_lighting_set_secondary_light(38F, 222F, 0.141176F, 0.141176F, 0.290196F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(carrier_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_02.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_03.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_04.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_05.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_01b_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew_containing("banshee");
            Engine.object_cinematic_lod(banshee_01.Entity, true);
            Engine.object_cinematic_lod(banshee_02.Entity, true);
            Engine.object_cinematic_lod(banshee_03.Entity, true);
            Engine.object_cinematic_lod(banshee_04.Entity, true);
            Engine.object_cinematic_lod(banshee_05.Entity, true);
            Engine.object_cinematic_lod(banshee_06.Entity, true);
            Engine.object_cinematic_lod(banshee_07.Entity, true);
            Engine.object_cinematic_lod(banshee_08.Entity, true);
            Engine.object_cinematic_lod(banshee_09.Entity, true);
            Engine.object_cinematic_lod(banshee_10.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_01a_setup()
        {
            Engine.object_create_anew(x01_fleet);
            Engine.object_create_anew(carrier_01);
            Engine.object_create_anew_containing("cruiser");
            Engine.object_create_anew(matte_high_charity);
            Engine.object_create_anew(matte_threshold);
            Engine.object_create_anew(matte_halo_01);
            Engine.object_create_anew(matte_halo_02);
            Engine.object_create_anew(matte_stardust_01);
            Engine.object_create_anew(matte_stardust_02);
            Engine.object_cinematic_lod(carrier_01.Entity, true);
            Engine.object_cinematic_lod(cruiser_01.Entity, true);
            Engine.object_cinematic_lod(cruiser_02.Entity, true);
            Engine.object_cinematic_lod(cruiser_03.Entity, true);
            Engine.object_cinematic_lod(cruiser_04.Entity, true);
            Engine.object_cinematic_lod(cruiser_05.Entity, true);
            Engine.wake(x01_score_01a);
            Engine.wake(x01_foley_01a);
            Engine.wake(x01_supratitle_01);
            Engine.wake(cinematic_lighting_scene_01a);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_01a()
        {
            Engine.sound_class_set_gain("amb", 0F, 0);
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("introduction");
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.x01_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_01a_fol", 3959622285U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\music\\x01_01_mus", 3959556748U));
            await Engine.sleep(this.prediction_offset);
            await Engine.sleep(45);
            await this.x01_01a_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_01", default(IUnit), anchor_flag_x01a);
            Engine.fade_in(0F, 0F, 0F, 90);
            Engine.scenery_animation_start_relative(carrier_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x01\\x01", 3959753359U), "01_capital_ship_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "01_ship01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "01_ship02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_03.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "01_ship03", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_04.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "01_ship04", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_05.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "01_ship05", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_high_charity.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\x01\\x01", 3959884433U), "high_charity_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_threshold.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\threshold_space\\x01\\x01", 3959949970U), "threshold_space_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_halo_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_01\\x01\\x01", 3960015507U), "halo_destroyed01_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_halo_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_02\\x01\\x01", 3960081044U), "halo_destroyed02_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_stardust_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\x01\\x01", 3960146581U), "stardust01_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_stardust_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\x01\\x01", 3960146581U), "stardust02_01", anchor_x01a.Entity);
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_01b_predict_stub();
            await this.x01_01b_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_01b_fol", 3960212118U));
            await Engine.sleep((short)((float)Engine.camera_time() - 1));
            Engine.cinematic_screen_effect_set_crossfade(2F);
            await Engine.sleep(1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_foley_01b()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_01b_fol", 3960212118U), default(IGameObject), 1F);
            Engine.print("x01 foley 01b start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0010_der()
        {
            await Engine.sleep(203);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0010_der", 3960277655U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0010_der", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task banshee_audio()
        {
            Engine.sound_class_set_gain("vehicle_engine", 0F, 0);
            Engine.sound_class_set_gain("vehicle_engine", 1F, 120);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task banshee_hotness()
        {
            Engine.object_set_function_variable(banshee_01.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_02.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_03.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_04.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_05.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_06.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_07.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_08.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_09.Entity, "engine_audio", 1F, 1F);
            Engine.object_set_function_variable(banshee_10.Entity, "engine_audio", 1F, 1F);
            await Engine.sleep(30);
            Engine.object_set_function_variable(banshee_06.Entity, "wingtips", 1F, 1F);
            Engine.object_set_function_variable(banshee_07.Entity, "wingtips", 1F, 1F);
            Engine.print("contrails start");
            await Engine.sleep(150);
            Engine.object_clear_function_variable(banshee_06.Entity, "wingtips");
            Engine.object_clear_function_variable(banshee_07.Entity, "wingtips");
            Engine.print("contrails stop");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_01b()
        {
            Engine.cinematic_lighting_set_primary_light(-59F, 308F, 0.466667F, 0.517647F, 0.643137F);
            Engine.cinematic_lighting_set_secondary_light(-5F, 360F, 0.270588F, 0.313726F, 0.380392F);
            Engine.cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(banshee_01.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_02.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_03.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_04.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_05.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_06.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_07.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_08.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_09.Entity, true);
            Engine.object_uses_cinematic_lighting(banshee_10.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_01b_setup()
        {
            Engine.object_destroy(x01_fleet.Entity);
            Engine.object_create_anew(mercy);
            Engine.object_create_anew(regret);
            Engine.object_create_anew(throne_mercy);
            Engine.object_create_anew(throne_regret);
            Engine.objects_attach(mercy.Entity, "", throne_mercy.Entity, "driver_cinematic");
            Engine.objects_attach(regret.Entity, "", throne_regret.Entity, "driver_cinematic");
            Engine.object_create_anew_containing("matte");
            Engine.object_destroy_containing("carrier");
            Engine.object_destroy(x01_fleet.Entity);
            Engine.wake(x01_foley_01b);
            Engine.wake(x01_0010_der);
            Engine.wake(banshee_audio);
            Engine.wake(banshee_hotness);
            Engine.wake(cinematic_lighting_scene_01b);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_01b()
        {
            Engine.sound_class_set_gain("amb", 1F, 1);
            Engine.print("x01 scene 01b start");
            await this.x01_01b_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_01b", default(IUnit), anchor_flag_x01b);
            Engine.custom_animation_relative(banshee_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee01_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee02_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee03_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee04_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee05_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee06_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee07_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_08.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee08_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_09.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee09_01b", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(banshee_10.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3960343192U), "banshee10_01b", false, anchor_x01b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_02_fol", 3960408729U));
            await Engine.sleep((short)((float)Engine.camera_time() - 1));
            Engine.cinematic_screen_effect_set_crossfade(1F);
            await Engine.sleep(1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_02_fol", 3960408729U), default(IGameObject), 1F);
            Engine.print("x01 foley 02 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0020_pot()
        {
            await Engine.sleep(19);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0020_pot", 3960474266U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x01_0020_pot", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0030_der()
        {
            await Engine.sleep(100);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0030_der", 3960539803U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x01_0030_der", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0040_pcc()
        {
            await Engine.sleep(170);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0040_pcc", 3960605340U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0040_pcc", 7F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0050_pom()
        {
            await Engine.sleep(289);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0050_pom", 3960670877U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x01_0050_pom", 2.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0060_der()
        {
            await Engine.sleep(391);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0060_der", 3960736414U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x01_0060_der", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_02_fov()
        {
            await Engine.sleep(196);
            Engine.camera_set_field_of_view(80F, 0);
            Engine.print("fov change: 60 -> 80 over 0 ticks");
            await Engine.sleep(90);
            Engine.camera_set_field_of_view(47F, 0);
            Engine.print("fov change: 80 -> 47 over 0 ticks");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_02()
        {
            Engine.cinematic_lighting_set_primary_light(-90F, 116F, 0.4F, 0.4F, 0.4F);
            Engine.cinematic_lighting_set_secondary_light(-26F, 148F, 0.3F, 0.25F, 0.3F);
            Engine.cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            Engine.render_lights_enable_cinematic_shadow(true, dervish.Entity, "head", 0.4F);
            Engine.rasterizer_bloom_override_threshold(0.25F);
            Engine.rasterizer_bloom_override_brightness(0.7F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(regret.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(prophet_counc_01.Entity, true);
            Engine.object_uses_cinematic_lighting(prophet_counc_02.Entity, true);
            Engine.object_uses_cinematic_lighting(prophet_counc_03.Entity, true);
            Engine.object_uses_cinematic_lighting(prophet_counc_04.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_01.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_02.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_03.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_04.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_05.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_06.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_07.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_08.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_09.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_10.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_11.Entity, true);
            Engine.object_uses_cinematic_lighting(ehg_12.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_regret.Entity, true);
            Engine.object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_03_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(poa_01);
            Engine.object_create_anew_containing("cruiser");
            Engine.object_create_anew(matte_reach);
            Engine.object_cinematic_lod(poa_01.Entity, true);
            Engine.object_cinematic_lod(cruiser_01.Entity, true);
            Engine.object_cinematic_lod(cruiser_02.Entity, true);
            Engine.object_cinematic_lod(cruiser_03.Entity, true);
            Engine.object_cinematic_lod(cruiser_04.Entity, true);
            Engine.object_cinematic_lod(cruiser_05.Entity, true);
            Engine.object_cinematic_lod(cruiser_06.Entity, true);
            Engine.object_cinematic_lod(cruiser_07.Entity, true);
            Engine.object_cinematic_lod(cruiser_08.Entity, true);
            Engine.object_cinematic_lod(cruiser_09.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task create_councillors_01()
        {
            await Engine.sleep(196);
            Engine.print("create councillors");
            Engine.object_create_anew_containing("elc");
            Engine.object_create_anew_containing("pcc");
            Engine.object_uses_cinematic_lighting(elc_01.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_02.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_03.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_04.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_05.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_06.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_07.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_08.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_09.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_10.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_11.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_12.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_13.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_14.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_15.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_16.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_17.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_18.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_19.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_20.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_21.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_22.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_23.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_24.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_25.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_26.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_27.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_28.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_29.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_30.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_01.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_02.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_03.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_04.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_05.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_06.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_07.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_08.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_09.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_10.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_11.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_12.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_13.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_14.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_15.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_16.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_17.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_18.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_19.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_20.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_21.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_22.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_23.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_24.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_25.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_26.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_27.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_28.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_29.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_30.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_31.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_32.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_02_setup()
        {
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew_containing("ehg");
            Engine.object_create_anew(hammer);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(mercy.Entity, true);
            Engine.object_cinematic_lod(regret.Entity, true);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(throne_mercy.Entity, true);
            Engine.object_cinematic_lod(throne_regret.Entity, true);
            Engine.object_cinematic_lod(hammer.Entity, true);
            Engine.object_set_function_variable(tartarus.Entity, "invincibility", 0F, 0F);
            Engine.wake(x01_foley_02);
            Engine.wake(x01_0020_pot);
            Engine.wake(x01_0030_der);
            Engine.wake(x01_0040_pcc);
            Engine.wake(x01_0050_pom);
            Engine.wake(x01_0060_der);
            Engine.wake(create_councillors_01);
            Engine.wake(x01_02_fov);
            Engine.wake(cinematic_lighting_scene_02);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_02_cleanup()
        {
            Engine.object_destroy(prophet_counc_03.Entity);
            Engine.object_destroy(prophet_counc_04.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_02()
        {
            Engine.print("x01 scene 02 start");
            await this.x01_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_02", default(IUnit), anchor_flag_x01b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3960801951U), "dervish_02", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "mercy_02", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "regret_02", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3960998562U), "tartarus_02", false, anchor_x01b.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x01\\x01", 3961064099U), "hammer_02", anchor_x01b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_03_predict_stub();
            await this.x01_03_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_03_fol", 3961129636U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.x01_02_cleanup();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_03_fol", 3961129636U), default(IGameObject), 1F);
            Engine.print("x01 foley 03 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0070_der()
        {
            await Engine.sleep(65);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0070_der", 3961195173U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0070_der", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_03()
        {
            Engine.cinematic_lighting_set_primary_light(69F, 232F, 0.290196F, 0.32549F, 0.243137F);
            Engine.cinematic_lighting_set_secondary_light(-2F, 76F, 0.129412F, 0.141176F, 0.270588F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(poa_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_02.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_03.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_04.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_05.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_06.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_07.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_08.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_09.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_10.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_11.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_12.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_03_setup()
        {
            Engine.object_create(halo_whole);
            Engine.object_create_anew(matte_reach);
            Engine.object_create_anew(matte_stardust_01);
            Engine.wake(x01_foley_03);
            Engine.wake(x01_0070_der);
            Engine.wake(cinematic_lighting_scene_03);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_03()
        {
            Engine.sound_class_set_gain("amb", 0F, 1);
            await this.x01_03_setup();
            Engine.camera_set_field_of_view(60F, 0);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_03", default(IUnit), anchor_flag_x01a);
            Engine.fade_in(1F, 1F, 1F, 15);
            Engine.scenery_animation_start_relative(poa_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\x01\\x01", 3961260710U), "poa_03", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_03.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship03", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_04.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship04", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_05.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship05", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_06.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship06", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_07.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship07", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_08.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship08", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_09.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "03_ship09", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_reach.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\reach_space\\x01\\x01", 3961326247U), "reach_space_03", anchor_x01a.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - 1));
            Engine.cinematic_screen_effect_set_crossfade(2F);
            await Engine.sleep(1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0080_por()
        {
            await Engine.sleep(12);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0080_por", 3961391784U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0080_por", 5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0090_der()
        {
            await Engine.sleep(152);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0090_der", 3961457321U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0090_der", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0100_por()
        {
            await Engine.sleep(180);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0100_por", 3961522858U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0100_por", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0110_der()
        {
            await Engine.sleep(238);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0110_der", 3961588395U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0110_der", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_04()
        {
            Engine.cinematic_lighting_set_primary_light(-42F, 60F, 0.4F, 0.380392F, 0.270588F);
            Engine.cinematic_lighting_set_secondary_light(38F, 222F, 0.141176F, 0.141176F, 0.290196F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(halo_whole.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_10.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_11.Entity, true);
            Engine.object_uses_cinematic_lighting(cruiser_12.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_04_setup()
        {
            Engine.wake(x01_0080_por);
            Engine.wake(x01_0090_der);
            Engine.wake(x01_0100_por);
            Engine.wake(x01_0110_der);
            Engine.wake(cinematic_lighting_scene_04);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_04_cleanup()
        {
            Engine.object_destroy(poa_01.Entity);
            Engine.object_destroy(halo_whole.Entity);
            Engine.object_destroy_containing("cruiser");
            Engine.object_destroy_containing("matte");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_04()
        {
            Engine.print("x01 scene 04 start");
            await this.x01_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_04", default(IUnit), anchor_flag_x01a);
            Engine.scenery_animation_start_relative(cruiser_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_03.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship03", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_04.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship04", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_05.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship05", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_06.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship06", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_07.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship07", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_08.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship08", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_09.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship09", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_10.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship10", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_11.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship11", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cruiser_12.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3959818896U), "04_ship12", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_threshold.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\threshold_space\\x01\\x01", 3959949970U), "threshold_space_04", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(halo_whole.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x01\\x01", 3961653932U), "halo_04", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_stardust_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\x01\\x01", 3960146581U), "stardust01_04", anchor_x01a.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_05_fol", 3961719469U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.wake(x01_04_cleanup);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_05_fol", 3961719469U), default(IGameObject), 1F);
            Engine.print("x01 foley 05 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0120_por()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0120_por", 3961785006U), regret.Entity, 1F);
            Engine.cinematic_subtitle("x01_0120_por", 4F);
            Engine.unit_set_emotional_state(regret.Entity, "arrogant", 0.5F, 90);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0130_por()
        {
            await Engine.sleep(141);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0130_por", 3961850543U), regret.Entity, 1F);
            Engine.cinematic_subtitle("x01_0130_por", 3F);
            Engine.unit_set_emotional_state(regret.Entity, "angry", 1F, 30);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_05()
        {
            Engine.cinematic_lighting_set_primary_light(-90F, 116F, 0.4F, 0.4F, 0.4F);
            Engine.cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            Engine.cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            Engine.rasterizer_bloom_override_threshold(0.25F);
            Engine.rasterizer_bloom_override_brightness(0.7F);
            Engine.object_uses_cinematic_lighting(mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(regret.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_05_setup()
        {
            Engine.wake(x01_foley_05);
            Engine.wake(x01_0120_por);
            Engine.wake(x01_0130_por);
            Engine.wake(cinematic_lighting_scene_05);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_05()
        {
            Engine.sound_class_set_gain("amb", 1F, 1);
            await this.x01_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_05", default(IUnit), anchor_flag_x01b);
            Engine.fade_in(1F, 1F, 1F, 15);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "mercy_05", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "regret_05", false, anchor_x01b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_06_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_06_fol", 3961916080U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_foley_06()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_06_fol", 3961916080U), default(IGameObject), 1F);
            Engine.print("x01 foley 06 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0140_der()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0140_der", 3961981617U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x01_0140_der", 4F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0150_cch()
        {
            await Engine.sleep(112);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0150_cch", 3962047154U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0150_cch", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0160_pom()
        {
            await Engine.sleep(199);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0160_pom", 3962112691U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x01_0160_pom", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0170_pot()
        {
            await Engine.sleep(330);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0170_pot", 3962178228U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x01_0170_pot", 6F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0180_der()
        {
            await Engine.sleep(524);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0180_der", 3962243765U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0180_der", 8F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_06()
        {
            Engine.cinematic_lighting_set_primary_light(-90F, 116F, 0.258824F, 0.258824F, 0.317647F);
            Engine.cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            Engine.cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            Engine.rasterizer_bloom_override_threshold(0.25F);
            Engine.rasterizer_bloom_override_brightness(0.7F);
            Engine.print("new bloom .25 .7");
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(truth.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(regret.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_06_setup()
        {
            Engine.object_create_anew(truth);
            Engine.object_create_anew(throne_truth);
            Engine.object_cinematic_lod(truth.Entity, true);
            Engine.object_cinematic_lod(throne_truth.Entity, true);
            Engine.objects_attach(truth.Entity, "", throne_truth.Entity, "driver_cinematic");
            Engine.wake(x01_foley_06);
            Engine.wake(x01_0140_der);
            Engine.wake(x01_0150_cch);
            Engine.wake(x01_0160_pom);
            Engine.wake(x01_0170_pot);
            Engine.wake(x01_0180_der);
            Engine.wake(cinematic_lighting_scene_06);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_07_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(halo_exploding);
            Engine.object_cinematic_lod(halo_exploding.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_06()
        {
            Engine.print("x01 scene 06 start");
            await this.x01_06_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_06", default(IUnit), anchor_flag_x01b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3960801951U), "dervish_06", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "truth_06", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "mercy_06", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "regret_06", false, anchor_x01b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_07_predict_stub();
            await this.x01_07_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_07_fol", 3962309302U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_foley_07()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_07_fol", 3962309302U), default(IGameObject), 1F);
            Engine.print("x01 foley 07 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0190_der()
        {
            await Engine.sleep(93);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0190_der", 3962374839U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0190_der", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_07()
        {
            Engine.cinematic_lighting_set_primary_light(56F, 18F, 0.4F, 0.380392F, 0.270588F);
            Engine.cinematic_lighting_set_secondary_light(-77F, 40F, 0.172549F, 0.172549F, 0.372549F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(halo_exploding.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task halo_explosion()
        {
            await Engine.sleep(60);
            Engine.print("effect - halo explosion");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01\\halo_destruction", 3962440376U), halo_exploding.Entity, "explosion_poa_front");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_07_setup()
        {
            Engine.wake(x01_foley_07);
            Engine.wake(x01_0190_der);
            Engine.wake(halo_explosion);
            Engine.wake(cinematic_lighting_scene_07);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\alpha_halo_explosion", 3962702524U), halo_exploding.Entity, "explosion_poa_front");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_07()
        {
            Engine.sound_class_set_gain("amb", 0F, 1);
            await this.x01_07_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_07", default(IUnit), anchor_flag_x01a);
            Engine.fade_in(1F, 1F, 1F, 15);
            Engine.scenery_animation_start_relative(halo_exploding.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo_exploding\\x01\\x01", 3963226820U), "halo_07", anchor_x01a.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_08_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.object_destroy(halo_exploding.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0200_pcc()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0200_pcc", 3963292357U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0200_pcc", 7F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0210_tar()
        {
            await Engine.sleep(244);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0210_tar", 3963357894U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x01_0210_tar", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0220_por()
        {
            await Engine.sleep(279);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0220_por", 3963423431U), regret.Entity, 1F);
            Engine.cinematic_subtitle("x01_0220_por", 7F);
            Engine.unit_set_emotional_state(regret.Entity, "angry", 0.5F, 60);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0230_pot()
        {
            await Engine.sleep(470);
            Engine.unit_set_emotional_state(truth.Entity, "angry", 0.25F, 60);
            await Engine.sleep(20);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0230_pot", 3963488968U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x01_0230_pot", 7F);
            Engine.unit_set_emotional_state(regret.Entity, "shocked", 0.5F, 30);
            await Engine.sleep(60);
            Engine.unit_set_emotional_state(regret.Entity, "arrogant", 0.5F, 60);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0240_pot()
        {
            await Engine.sleep(705);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0240_pot", 3963554505U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x01_0240_pot", 6F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_08_fov()
        {
            await Engine.sleep(689);
            Engine.camera_set_field_of_view(38F, 0);
            Engine.print("fov change: 60 -> 38 over 0 ticks");
            await Engine.sleep(111);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 38 -> 60 over 0 ticks");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_08()
        {
            Engine.cinematic_lighting_set_primary_light(-90F, 116F, 0.4F, 0.4F, 0.4F);
            Engine.cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            Engine.cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            Engine.rasterizer_bloom_override_threshold(0.25F);
            Engine.rasterizer_bloom_override_brightness(0.7F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(truth.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(regret.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(prophet_counc_01.Entity, true);
            Engine.object_uses_cinematic_lighting(prophet_counc_02.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_counc_01.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_counc_02.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_08_setup()
        {
            Engine.object_destroy(elc_26.Entity);
            Engine.object_destroy(elc_27.Entity);
            Engine.object_destroy(pcc_33.Entity);
            Engine.object_destroy(pcc_34.Entity);
            Engine.object_create_anew(prophet_counc_01);
            Engine.object_create_anew(prophet_counc_02);
            Engine.object_create_anew(elite_counc_01);
            Engine.object_create_anew(elite_counc_02);
            Engine.object_cinematic_lod(prophet_counc_01.Entity, true);
            Engine.object_cinematic_lod(prophet_counc_02.Entity, true);
            Engine.object_cinematic_lod(elite_counc_01.Entity, true);
            Engine.object_cinematic_lod(elite_counc_02.Entity, true);
            Engine.wake(x01_0200_pcc);
            Engine.wake(x01_0210_tar);
            Engine.wake(x01_0220_por);
            Engine.wake(x01_0230_pot);
            Engine.wake(x01_0240_pot);
            Engine.wake(x01_08_fov);
            Engine.wake(cinematic_lighting_scene_08);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_08_cleanup()
        {
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
            Engine.object_destroy(elite_counc_01.Entity);
            Engine.object_destroy(elite_counc_02.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_08()
        {
            Engine.sound_class_set_gain("amb", 1F, 1);
            Engine.print("x01 scene 08 start");
            await this.x01_08_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_08", default(IUnit), anchor_flag_x01b);
            Engine.fade_in(1F, 1F, 1F, 15);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3960801951U), "dervish_08", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "truth_08", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "mercy_08", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "regret_08", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3960998562U), "tartarus_08", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(prophet_counc_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "prophet01_08", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(prophet_counc_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "prophet02_08", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(elite_counc_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x01\\x01", 3963620042U), "elite01_08", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(elite_counc_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x01\\x01", 3963620042U), "elite02_08", false, anchor_x01b.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x01\\x01", 3961064099U), "hammer_08", anchor_x01b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_09_predict_stub();
            await Engine.sleep((short)Engine.camera_time());
            await this.x01_08_cleanup();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0250_pc1()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0250_pc1", 3963685579U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0250_pc1", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0260_pcc()
        {
            await Engine.sleep(60);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0260_pcc", 3963751116U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0260_pcc", 9F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0270_der()
        {
            await Engine.sleep(252);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0270_der", 3963816653U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x01_0270_der", 4F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0280_pot()
        {
            await Engine.sleep(376);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0280_pot", 3963882190U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x01_0280_pot", 3F);
            await Engine.sleep(30);
            Engine.unit_set_emotional_state(truth.Entity, "arrogant", 0.5F, 60);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0290_tar()
        {
            await Engine.sleep(494);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0290_tar", 3963947727U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x01_0290_tar", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_09_fov()
        {
            await Engine.sleep(441);
            Engine.camera_set_field_of_view(38F, 0);
            Engine.print("fov change: 60 -> 38 over 0 ticks");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_09()
        {
            Engine.cinematic_lighting_set_primary_light(-90F, 116F, 0.258824F, 0.258824F, 0.317647F);
            Engine.cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            Engine.cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            Engine.object_uses_cinematic_lighting(hammer.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_26.Entity, true);
            Engine.object_uses_cinematic_lighting(elc_27.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_10_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_02);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_09_setup()
        {
            Engine.object_create_anew(elc_26);
            Engine.object_create_anew(elc_27);
            Engine.wake(x01_0250_pc1);
            Engine.wake(x01_0260_pcc);
            Engine.wake(x01_0270_der);
            Engine.wake(x01_0280_pot);
            Engine.wake(x01_0290_tar);
            Engine.wake(x01_09_fov);
            Engine.wake(cinematic_lighting_scene_09);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_09_cleanup()
        {
            Engine.object_destroy(prophet_counc_01.Entity);
            Engine.object_destroy(prophet_counc_02.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_09()
        {
            Engine.print("x01 scene 09 start");
            await this.x01_09_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_09", default(IUnit), anchor_flag_x01b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3960801951U), "dervish_09", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "truth_09", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "mercy_09", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "regret_09", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3960998562U), "tartarus_09", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(prophet_counc_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "prophet01_09", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(prophet_counc_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "prophet02_09", false, anchor_x01b.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x01\\x01", 3961064099U), "hammer_09", anchor_x01b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x01_10_predict_stub();
            await this.x01_10_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\music\\x01_c01_intro_trans_mus", 3964013264U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x01_09_cleanup();
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_score_10()
        {
            await Engine.sleep(79);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\music\\x01_c01_intro_trans_mus", 3964013264U), default(IGameObject), 1F);
            Engine.print("x01 score 10 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0300_pot()
        {
            await Engine.sleep(20);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0300_pot", 3964078801U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x01_0300_pot", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0310_cch()
        {
            await Engine.sleep(98);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0310_cch", 3964144338U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0310_cch", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0320_pot()
        {
            await Engine.sleep(180);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0320_pot", 3964209875U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x01_0320_pot", 4F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x01_0330_pot()
        {
            await Engine.sleep(329);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0330_pot", 3964275412U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x01_0330_pot", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_10()
        {
            Engine.cinematic_lighting_set_primary_light(19F, 298F, 0.266667F, 0.266667F, 0.317647F);
            Engine.cinematic_lighting_set_secondary_light(-53F, 106F, 0.168627F, 0.168627F, 0.223529F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_19.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_20.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_23.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_24.Entity, true);
            Engine.object_uses_cinematic_lighting(pcc_25.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task improve_framerate()
        {
            Engine.time_code_reset();
            await Engine.sleep(223);
            Engine.print("improve framerate");
            Engine.object_destroy_containing("pcc");
            Engine.object_destroy_containing("elc");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_10_setup()
        {
            Engine.object_create_anew(pcc_19);
            Engine.object_create_anew(pcc_20);
            Engine.object_create_anew(pcc_23);
            Engine.object_create_anew(pcc_24);
            Engine.object_create_anew(pcc_25);
            Engine.wake(x01_score_10);
            Engine.wake(improve_framerate);
            Engine.wake(x01_0300_pot);
            Engine.wake(x01_0310_cch);
            Engine.wake(x01_0320_pot);
            Engine.wake(x01_0330_pot);
            Engine.wake(cinematic_lighting_scene_10);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_10_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(truth.Entity);
            Engine.object_destroy(mercy.Entity);
            Engine.object_destroy(regret.Entity);
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy_containing("throne");
            Engine.object_destroy_containing("brute");
            Engine.object_destroy_containing("ehg");
            Engine.object_destroy(hammer.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x01_scene_10()
        {
            await this.x01_10_setup();
            Engine.camera_set_field_of_view(60F, 0);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3959687822U), "x01_10", default(IUnit), anchor_flag_x01b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3960801951U), "dervish_10", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "truth_10", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "mercy_10", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3960933025U), "regret_10", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3960998562U), "tartarus_10", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3960998562U), "brute01_10", false, anchor_x01b.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3960998562U), "brute02_10", false, anchor_x01b.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x01\\x01", 3961064099U), "hammer_10", anchor_x01b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_intro_01_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_intro\\foley\\c01_intro_01_fol", 3964340949U));
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - 16));
            Engine.cinematic_screen_effect_set_crossfade(1F);
            await Engine.sleep(1);
            await this.x01_10_cleanup();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_intro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_intro\\foley\\c01_intro_01_fol", 3964340949U), default(IGameObject), 1F);
            Engine.print("c01 intro foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_1010_qtm()
        {
            await Engine.sleep(390);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1010_qtm", 3964406486U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c01_1010_qtm", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_intro_supratitle_01()
        {
            await Engine.sleep(285);
            Engine.cinematic_set_title(cinematic_title1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lens_flares()
        {
            Engine.object_create_anew_containing("yellow_01");
            await Engine.sleep(15);
            Engine.object_create_anew_containing("yellow_02");
            await Engine.sleep(15);
            Engine.object_create_anew_containing("red");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_intro_dof_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(404);
            Engine.object_destroy(athens.Entity);
            Engine.object_destroy(malta.Entity);
            Engine.object_destroy(poa_01.Entity);
            Engine.print("rack focus");
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1.5F, 1F, 1F, 0F, 0F, 0F, 0F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_c01_scene_01()
        {
            Engine.cinematic_lighting_set_primary_light(-11F, 360F, 0.415686F, 0.415686F, 0.501961F);
            Engine.cinematic_lighting_set_secondary_light(41F, 230F, 0F, 0F, 0F);
            Engine.cinematic_lighting_set_ambient_light(0.0588235F, 0.0470588F, 0.0431373F);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(cairo.Entity, true);
            Engine.object_uses_cinematic_lighting(malta.Entity, true);
            Engine.object_uses_cinematic_lighting(athens.Entity, true);
            Engine.object_uses_cinematic_lighting(poa_01.Entity, true);
            Engine.object_uses_cinematic_lighting(poa_02.Entity, true);
            Engine.object_uses_cinematic_lighting(poa_03.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_01.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_02.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_03.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_04.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_05.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_01.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_02.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_03.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_04.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_05.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_06.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_08.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c01_02_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(master_guns);
            Engine.object_create_anew(armory);
            Engine.object_create_anew(cart);
            Engine.object_create_anew(optics);
            Engine.object_create_anew(power_supply);
            Engine.object_cinematic_lod(master_guns.Entity, true);
            Engine.object_cinematic_lod(armory.Entity, true);
            Engine.object_cinematic_lod(cart.Entity, true);
            Engine.object_cinematic_lod(optics.Entity, true);
            Engine.object_cinematic_lod(power_supply.Entity, true);
            Engine.object_hide(master_guns.Entity, true);
            Engine.object_hide(armory.Entity, true);
            Engine.object_hide(cart.Entity, true);
            Engine.object_hide(optics.Entity, true);
            Engine.object_hide(power_supply.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task ships_unhide()
        {
            await Engine.sleep(150);
            Engine.print("ships unhide");
            Engine.object_hide(poa_01.Entity, false);
            Engine.object_hide(poa_02.Entity, false);
            Engine.object_hide(poa_03.Entity, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c01_intro_scene_01_setup()
        {
            Engine.object_create_anew(cairo);
            Engine.object_create_anew(malta);
            Engine.object_create_anew(athens);
            Engine.object_create_anew_containing("iac");
            Engine.object_create_anew_containing("poa");
            Engine.object_create_anew_containing("fighter");
            Engine.object_hide(poa_01.Entity, true);
            Engine.object_hide(poa_02.Entity, true);
            Engine.object_hide(poa_03.Entity, true);
            Engine.object_create_anew(matte_earth);
            Engine.object_create_anew(matte_moon);
            Engine.object_cinematic_lod(cairo.Entity, true);
            Engine.object_cinematic_lod(malta.Entity, true);
            Engine.object_cinematic_lod(athens.Entity, true);
            Engine.wake(c01_intro_foley_01);
            Engine.wake(c01_1010_qtm);
            Engine.wake(ships_unhide);
            Engine.wake(c01_intro_supratitle_01);
            Engine.wake(lens_flares);
            Engine.wake(cinematic_lighting_c01_scene_01);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c01_intro_scene_01_cleanup()
        {
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
            Engine.object_destroy(cairo.Entity);
            Engine.object_destroy(athens.Entity);
            Engine.object_destroy(malta.Entity);
            Engine.object_destroy_containing("iac");
            Engine.object_destroy_containing("poa");
            Engine.object_destroy_containing("fighter");
            Engine.object_destroy_containing("matte");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c01_intro_scene_01()
        {
            Engine.sound_class_set_gain("amb", 0F, 1);
            await this.c01_intro_scene_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_intro\\01_intro", 3964472023U), "01_intro_01", default(IUnit), anchor_flag_x01a);
            Engine.scenery_animation_start_relative(athens.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\01_intro\\01_intro", 3964537560U), "ss_prop01_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cairo.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo\\cairo", 3829203655U), "01_intro_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(malta.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\01_intro\\01_intro", 3964537560U), "ss_prop03_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(iac_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3964603097U), "iac_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(iac_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3964603097U), "iac_02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(iac_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3964603097U), "iac_03", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(iac_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3964603097U), "iac_04", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(iac_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3964603097U), "iac_05", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(poa_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\01_intro\\01_intro", 3964668634U), "poa_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(poa_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\01_intro\\01_intro", 3964668634U), "poa_02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(poa_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\01_intro\\01_intro", 3964668634U), "poa_03", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(fighter_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3964734171U), "longsword_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(fighter_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3964734171U), "longsword_02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(fighter_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3964734171U), "longsword_03", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(fighter_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3964734171U), "longsword_04", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(fighter_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3964734171U), "longsword_05", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(fighter_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3964734171U), "longsword_06", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(fighter_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3964734171U), "longsword_07", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(fighter_08.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3964734171U), "longsword_08", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_earth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\earth_space\\01_intro\\01_intro", 3964799708U), "earth_space_01", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(matte_moon.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\moon\\01_intro\\01_intro", 3964865245U), "moon_01", anchor_x01a.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_intro_02_predict_stub();
            await this.c01_02_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_intro\\foley\\c01_intro_02_fol", 3964930782U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_intro_scene_01_cleanup();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_intro_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_intro\\foley\\c01_intro_02_fol", 3964930782U), default(IGameObject), 1F);
            Engine.print("c01 intro foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_1020_qtm()
        {
            await Engine.sleep(18);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1020_qtm", 3964996319U), master_guns.Entity, 1F);
            Engine.cinematic_subtitle("c01_1020_qtm", 2F);
            Engine.unit_set_emotional_state(master_guns.Entity, "annoyed", 1F, 0);
            Engine.print("master guns - annoyed 1 0");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_1030_qtm()
        {
            await Engine.sleep(91);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1030_qtm", 3965061856U), master_guns.Entity, 1F);
            Engine.cinematic_subtitle("c01_1030_qtm", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_1040_qtm()
        {
            await Engine.sleep(173);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1040_qtm", 3965127393U), master_guns.Entity, 1F);
            Engine.cinematic_subtitle("c01_1040_qtm", 2F);
            Engine.unit_set_emotional_state(master_guns.Entity, "angry", 1F, 15);
            Engine.print("master guns - angry 1 15");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c01_1050_mas()
        {
            await Engine.sleep(396);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1050_mas", 3965192930U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c01_1050_mas", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cinematic_lighting_c01_scene_02()
        {
            Engine.cinematic_lighting_set_primary_light(12F, 184F, 0.117647F, 0.109804F, 0.0901961F);
            Engine.cinematic_lighting_set_secondary_light(-48F, 106F, 0.113725F, 0.113725F, 0.0941177F);
            Engine.cinematic_lighting_set_ambient_light(0.0352941F, 0.0392157F, 0.0666667F);
            Engine.render_lights_enable_cinematic_shadow(true, chief.Entity, "head", 0.25F);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(master_guns.Entity, true);
            Engine.object_uses_cinematic_lighting(armory.Entity, true);
            Engine.object_uses_cinematic_lighting(cart.Entity, true);
            Engine.object_uses_cinematic_lighting(optics.Entity, true);
            Engine.object_uses_cinematic_lighting(power_supply.Entity, true);
            Engine.object_uses_cinematic_lighting(helmet.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c01_intro_scene_02_setup()
        {
            Engine.object_hide(master_guns.Entity, false);
            Engine.object_hide(armory.Entity, false);
            Engine.object_hide(cart.Entity, false);
            Engine.object_hide(optics.Entity, false);
            Engine.object_hide(power_supply.Entity, false);
            Engine.object_create_anew(chief);
            Engine.object_create_anew(helmet);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(helmet.Entity, true);
            Engine.wake(c01_intro_foley_02);
            Engine.wake(c01_1020_qtm);
            Engine.wake(c01_1030_qtm);
            Engine.wake(c01_1040_qtm);
            Engine.wake(c01_1050_mas);
            Engine.wake(cinematic_lighting_c01_scene_02);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c01_intro_scene_02_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(master_guns.Entity);
            Engine.object_destroy(armory.Entity);
            Engine.object_destroy(cart.Entity);
            Engine.object_destroy(optics.Entity);
            Engine.object_destroy(power_supply.Entity);
            Engine.object_destroy(helmet.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c01_intro_scene_02()
        {
            Engine.disable_render_light_suppressor();
            Engine.sound_class_set_gain("amb", 1F, 1);
            await this.c01_intro_scene_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_intro\\01_intro", 3964472023U), "01_intro_02", default(IUnit), anchor_flag_x01a);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_intro\\01_intro", 3965258467U), "chief_02", false, anchor_x01a.Entity);
            Engine.custom_animation_relative(master_guns.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\01_intro\\01_intro", 3965324004U), "quartermaster_02", false, anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(armory.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_armory\\01_intro\\01_intro", 3965455078U), "cairo_armory_02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(cart.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\equipment_cart\\01_intro\\01_intro", 3965520615U), "equipment_cart_02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(optics.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\optics\\01_intro\\01_intro", 3965586152U), "optics_02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(power_supply.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\power_core\\01_intro\\01_intro", 3965651689U), "power_supply_02", anchor_x01a.Entity);
            Engine.scenery_animation_start_relative(helmet.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\helmet\\01_intro\\01_intro", 3965717226U), "helmet_02", anchor_x01a.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.sound_class_set_gain("amb", 0F, 15);
            Engine.enable_render_light_suppressor();
            Engine.loading_screen_fade_to_white();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task intro()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.sound_class_set_gain("device_door", 0F, 0);
            Engine.cinematic_outro_start();
            await this.x01_scene_01a();
            await this.x01_scene_01b();
            await this.x01_scene_02();
            await this.x01_scene_03();
            await this.x01_scene_04();
            await this.x01_scene_05();
            await this.x01_scene_06();
            await this.x01_scene_07();
            await this.x01_scene_08();
            await this.x01_scene_09();
            await this.x01_scene_10();
            await this.c01_intro_scene_01();
            await this.c01_intro_scene_02();
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(Lifecycle.Startup)]
        public async Task _fade_out()
        {
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_0"));
            if (await this.cinematic_skip_start())
            {
                await this.intro();
            }

            await this.cinematic_skip_stop();
            Engine.game_won();
        }
    }
}