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
        [ScriptMethod(0, Lifecycle.Static)]
        public async Task<IUnit> player0()
        {
            return unit(list_get(players(), 0));
        }

        [ScriptMethod(1, Lifecycle.Static)]
        public async Task<IUnit> player1()
        {
            return unit(list_get(players(), 1));
        }

        [ScriptMethod(2, Lifecycle.Static)]
        public async Task<int> player_count()
        {
            return list_count(players());
        }

        [ScriptMethod(3, Lifecycle.Static)]
        public async Task end_segment()
        {
            camera_control(true);
            cinematic_start();
            fade_out(0F, 0F, 0F, 15);
            await sleep(30);
            print("end gameplay segment!  thank you for playing!");
            await sleep(15);
            print("grab jaime or paul to give feedback!");
            player_action_test_reset();
            await sleep(15);
            print("press the �a� button to reset!");
            await sleep_until(async () => (bool)player_action_test_accept());
            print("reloading map...");
            await sleep(15);
            map_reset();
        }

        [ScriptMethod(4, Lifecycle.Static)]
        public async Task<bool> difficulty_legendary()
        {
            return game_difficulty_get() == GameDifficulty.Legendary();
        }

        [ScriptMethod(5, Lifecycle.Static)]
        public async Task<bool> difficulty_heroic()
        {
            return game_difficulty_get() == GameDifficulty.Heroic();
        }

        [ScriptMethod(6, Lifecycle.Static)]
        public async Task<bool> difficulty_normal()
        {
            return game_difficulty_get() == GameDifficulty.Normal();
        }

        [ScriptMethod(7, Lifecycle.Static)]
        public async Task<bool> cinematic_skip_start()
        {
            cinematic_skip_start_internal();
            game_save_cinematic_skip();
            await sleep_until(async () => !((bool)game_saving()), 1);
            return !((bool)game_reverted());
        }

        [ScriptMethod(8, Lifecycle.Static)]
        public async Task cinematic_skip_stop()
        {
            cinematic_skip_stop_internal();
            if (!((bool)game_reverted()))
            {
                game_revert();
            }
        }

        [ScriptMethod(9, Lifecycle.Static)]
        public async Task cinematic_fade_to_white()
        {
            player_enable_input(false);
            player_camera_control(false);
            hud_cinematic_fade(0F, 0.5F);
            cinematic_start();
            fade_out(1F, 1F, 1F, 30);
            await sleep(30);
            camera_control(true);
        }

        [ScriptMethod(10, Lifecycle.Static)]
        public async Task cinematic_fade_from_white()
        {
            hud_cinematic_fade(1F, 0.5F);
            cinematic_stop();
            camera_control(false);
            fade_in(1F, 1F, 1F, 15);
            await sleep(15);
            player_enable_input(true);
            player_camera_control(true);
        }

        [ScriptMethod(11, Lifecycle.Static)]
        public async Task cinematic_fade_from_white_bars()
        {
            cinematic_stop();
            cinematic_show_letterbox_immediate(true);
            camera_control(false);
            fade_in(1F, 1F, 1F, 15);
            await sleep(15);
            player_enable_input(true);
            player_camera_control(true);
        }

        [ScriptMethod(12, Lifecycle.Static)]
        public async Task cinematic_fade_from_black_bars()
        {
            cinematic_stop();
            cinematic_show_letterbox_immediate(true);
            camera_control(false);
            fade_in(0F, 0F, 0F, 15);
            await sleep(15);
            player_enable_input(true);
            player_camera_control(true);
        }

        [ScriptMethod(13, Lifecycle.Static)]
        public async Task cinematic_fade_to_black()
        {
            player_enable_input(false);
            player_camera_control(false);
            hud_cinematic_fade(0F, 0.5F);
            cinematic_start();
            fade_out(0F, 0F, 0F, 30);
            await sleep(30);
            camera_control(true);
        }

        [ScriptMethod(14, Lifecycle.Static)]
        public async Task cinematic_fade_from_black()
        {
            hud_cinematic_fade(1F, 0.5F);
            cinematic_stop();
            camera_control(false);
            fade_in(0F, 0F, 0F, 15);
            await sleep(15);
            player_enable_input(true);
            player_camera_control(true);
        }

        [ScriptMethod(15, Lifecycle.Static)]
        public async Task cinematic_snap_to_black()
        {
            player_enable_input(false);
            player_camera_control(false);
            fade_out(0F, 0F, 0F, 0);
            hud_cinematic_fade(0F, 0F);
            cinematic_start();
            cinematic_show_letterbox_immediate(true);
            camera_control(true);
        }

        [ScriptMethod(16, Lifecycle.Static)]
        public async Task cinematic_snap_to_white()
        {
            player_enable_input(false);
            player_camera_control(false);
            fade_out(1F, 1F, 1F, 0);
            hud_cinematic_fade(0F, 0F);
            cinematic_start();
            cinematic_show_letterbox_immediate(true);
            camera_control(true);
        }

        [ScriptMethod(17, Lifecycle.Static)]
        public async Task cinematic_stash_players()
        {
            object_hide(await this.player0(), true);
            object_hide(await this.player1(), true);
            object_cannot_take_damage(players());
        }

        [ScriptMethod(18, Lifecycle.Static)]
        public async Task cinematic_unstash_players()
        {
            object_hide(await this.player0(), false);
            object_hide(await this.player1(), false);
            object_can_take_damage(players());
        }

        [ScriptMethod(19, Lifecycle.Dormant)]
        public async Task _stealth_toggle_monitor()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () =>
                {
                    if (unit_get_shield(await this.player0()) >= 1F && (bool)player_action_test_vision_trigger())
                    {
                        return 1F == 1F;
                    }
                    else
                    {
                        player_action_test_reset();
                        return 1F == 0F;
                    }
                }, 1);
                cheat_active_camouflage_by_player(0, true);
                print("stealth engaged");
                unit_set_maximum_vitality(await this.player0(), 50F, 0F);
                unit_set_current_vitality(await this.player0(), 50F, 0F);
                object_set_shield(await this.player0(), 0F);
                await sleep(30);
                player_action_test_reset();
                await sleep_until(async () => object_get_health(await this.player0()) < 1F || (bool)player_action_test_vision_trigger(), 1);
                cheat_active_camouflage_by_player(0, false);
                print("stealth disengaged");
                unit_set_maximum_vitality(await this.player0(), 30F, 70F);
                object_set_shield(await this.player0(), 0F);
                await sleep(30);
                player_action_test_reset();
                return false;
            }, 1);
        }

        [ScriptMethod(20, Lifecycle.Dormant)]
        public async Task _stealth_timer_monitor()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () =>
                {
                    if ((bool)player_action_test_vision_trigger())
                    {
                        return 1F == 1F;
                    }
                    else
                    {
                        player_action_test_reset();
                        return 1F == 0F;
                    }
                }, 1);
                cheat_active_camouflage_by_player(0, true);
                print("stealth engaged");
                await sleep(15);
                player_action_test_reset();
                await sleep_until(async () => (bool)player_action_test_vision_trigger() || (bool)player_action_test_primary_trigger() || (bool)player_action_test_grenade_trigger() || (bool)player_action_test_melee(), 1, 9 * 30);
                cheat_active_camouflage_by_player(0, false);
                print("stealth disengaged");
                await sleep(30);
                player_action_test_reset();
                await sleep_until(async () =>
                {
                    print("+");
                    return false;
                }, 30, 5 * 30);
                return false;
            }, 1);
        }

        [ScriptMethod(21, Lifecycle.Static)]
        public async Task activate_stealth_toggle_monitor()
        {
            await sleep(1);
        }

        [ScriptMethod(22, Lifecycle.Static)]
        public async Task activate_stealth_timer_monitor()
        {
            await sleep(1);
        }

        [ScriptMethod(23, Lifecycle.Static)]
        public async Task playtest_mission()
        {
            if ((bool)game_is_playtest())
            {
                await sleep(30);
                hud_set_training_text("playtest_raisehand");
                hud_show_training_text(true);
                player_action_test_reset();
                await sleep_until(async () => (bool)player_action_test_accept(), 1);
                hud_show_training_text(false);
                await sleep(30);
            }
        }

        [ScriptMethod(24, Lifecycle.Dormant)]
        public async Task x01_01_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3958049397U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\hc_introcine_love\\hc_cin_volume\\hc_cin_volume", 3836412725U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3801022745U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3838378835U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_02\\halo_destroyed_02", 3798991098U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_01\\halo_destroyed_01", 3797287136U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\threshold_space\\threshold_space", 3796697303U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3800629523U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\battle_cruiser", 3790602362U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3823436399U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3837330243U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await sleep(216);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
        }

        [ScriptMethod(25, Lifecycle.Dormant)]
        public async Task x01_01b_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3801022745U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3956869731U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3955100232U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\hc_introcine_love\\hc_cin_volume\\hc_cin_volume", 3836412725U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3934521614U), 102);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3934521614U), 103);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3934521614U), 104);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3934521614U), 105);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3934521614U), 106);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3934521614U), 107);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3934521614U), 108);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\banshee\\banshee", 3934521614U), 109);
            await sleep(32);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
        }

        [ScriptMethod(26, Lifecycle.Dormant)]
        public async Task x01_02_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 46, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3955100232U), 1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 9);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 32);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, false);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3958049397U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            await sleep(39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 34);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795910859U), 0);
            await sleep(114);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3822060122U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3822060122U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 5);
            await sleep(89);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 2);
            await sleep(100);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3955100232U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 0);
        }

        [ScriptMethod(27, Lifecycle.Dormant)]
        public async Task x01_03_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\reach_space\\reach_space", 3799384320U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\battle_cruiser", 3790602362U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\pillarofautumn\\pillarofautumn", 3794469045U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3838378835U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3838772057U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_02\\halo_destroyed_02", 3798991098U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_01\\halo_destroyed_01", 3797287136U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\threshold_space\\threshold_space", 3796697303U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await sleep(151);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3800629523U), 0);
        }

        [ScriptMethod(28, Lifecycle.Dormant)]
        public async Task x01_04_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(29, Lifecycle.Dormant)]
        public async Task x01_05_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 9);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\hc_introcine_love\\hc_cin_volume\\hc_cin_volume", 3836412725U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 32);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3801022745U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await sleep(60);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
        }

        [ScriptMethod(30, Lifecycle.Dormant)]
        public async Task x01_06_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795910859U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3958049397U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 5);
            await sleep(25);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await sleep(93);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            await sleep(87);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 7);
            await sleep(110);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 1);
            await sleep(43);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 2);
        }

        [ScriptMethod(31, Lifecycle.Dormant)]
        public async Task x01_07_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo_exploding\\halo_exploding", 3792634009U), 0);
        }

        [ScriptMethod(32, Lifecycle.Dormant)]
        public async Task x01_08_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3958049397U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3822060122U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3822060122U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\hc_introcine_love\\hc_cin_volume\\hc_cin_volume", 3836412725U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 32);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3801022745U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3825140361U), 9);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            await sleep(75);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 5);
            await sleep(80);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795910859U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 10);
            await sleep(118);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 2);
            await sleep(412);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            await sleep(111);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3958049397U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3858891916U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3955100232U), 0);
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task x01_09_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3822060122U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3822060122U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795910859U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 10);
            await sleep(77);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3955100232U), 0);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, false);
            await sleep(41);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795910859U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 34);
            await sleep(11);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 10);
            await sleep(92);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 46, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3958049397U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3955100232U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            await sleep(122);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 7);
            await sleep(68);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task x01_10_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 40);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3958049397U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_councillor_prop\\elite_councillor_prop", 3819766327U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3955100232U), 0);
            await sleep(123);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 46, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3839492964U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3795910859U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3959229063U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3822060122U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet_councillor_prop\\prophet_councillor_prop", 3822060122U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3950971401U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3883730439U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 0);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            await sleep(89);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            await sleep(75);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3888711251U), 2);
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task _01_intro_01_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\moon\\moon", 3814719978U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\earth_space\\earth_space", 3810853295U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3809280407U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 3835626281U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\ss_prop", 3829990099U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo\\cairo", 3826844323U), 0);
            await sleep(146);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\pillarofautumn\\pillarofautumn", 3794469045U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3837330243U), 0);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task _01_intro_02_predict()
        {
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3921741899U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3921741899U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3921741899U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3921741899U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\power_core\\power_core", 3812360646U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\optics\\optics", 3811836350U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\equipment_cart\\equipment_cart", 3811246517U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_armory\\cairo_armory", 3815113200U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3788177493U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3904767816U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\helmet\\helmet", 3812950479U), 0);
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task x01_01_predict_stub()
        {
            wake(new ScriptMethodReference(x01_01_predict));
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task x01_01b_predict_stub()
        {
            wake(new ScriptMethodReference(x01_01b_predict));
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task x01_02_predict_stub()
        {
            wake(new ScriptMethodReference(x01_02_predict));
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task x01_03_predict_stub()
        {
            wake(new ScriptMethodReference(x01_03_predict));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task x01_04_predict_stub()
        {
            wake(new ScriptMethodReference(x01_04_predict));
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task x01_05_predict_stub()
        {
            wake(new ScriptMethodReference(x01_05_predict));
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task x01_06_predict_stub()
        {
            wake(new ScriptMethodReference(x01_06_predict));
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task x01_07_predict_stub()
        {
            wake(new ScriptMethodReference(x01_07_predict));
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task x01_08_predict_stub()
        {
            wake(new ScriptMethodReference(x01_08_predict));
        }

        [ScriptMethod(46, Lifecycle.Static)]
        public async Task x01_09_predict_stub()
        {
            wake(new ScriptMethodReference(x01_09_predict));
        }

        [ScriptMethod(47, Lifecycle.Static)]
        public async Task x01_10_predict_stub()
        {
            wake(new ScriptMethodReference(x01_10_predict));
        }

        [ScriptMethod(48, Lifecycle.Static)]
        public async Task _01_intro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_01_intro_01_predict));
        }

        [ScriptMethod(49, Lifecycle.Static)]
        public async Task _01_intro_02_predict_stub()
        {
            wake(new ScriptMethodReference(_01_intro_02_predict));
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task x01_score_01a()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\music\\x01_01_mus", 3960539803U), default(IGameObject), 1F);
            print("x01 score 01 start");
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task x01_foley_01a()
        {
            await sleep(60);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_01a_fol", 3960605340U), default(IGameObject), 1F);
            print("x01 foley 01 start");
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task x01_supratitle_01()
        {
            await sleep(420);
            cinematic_set_title(cinematic_title0);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_01a()
        {
            cinematic_lighting_set_primary_light(-23F, 152F, 0.576471F, 0.513726F, 0.4F);
            cinematic_lighting_set_secondary_light(38F, 222F, 0.141176F, 0.141176F, 0.290196F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(carrier_01.Entity, true);
            object_uses_cinematic_lighting(cruiser_01.Entity, true);
            object_uses_cinematic_lighting(cruiser_02.Entity, true);
            object_uses_cinematic_lighting(cruiser_03.Entity, true);
            object_uses_cinematic_lighting(cruiser_04.Entity, true);
            object_uses_cinematic_lighting(cruiser_05.Entity, true);
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task x01_01b_problem_actors()
        {
            print("problem actors");
            object_create_anew_containing("banshee");
            object_cinematic_lod(banshee_01.Entity, true);
            object_cinematic_lod(banshee_02.Entity, true);
            object_cinematic_lod(banshee_03.Entity, true);
            object_cinematic_lod(banshee_04.Entity, true);
            object_cinematic_lod(banshee_05.Entity, true);
            object_cinematic_lod(banshee_06.Entity, true);
            object_cinematic_lod(banshee_07.Entity, true);
            object_cinematic_lod(banshee_08.Entity, true);
            object_cinematic_lod(banshee_09.Entity, true);
            object_cinematic_lod(banshee_10.Entity, true);
        }

        [ScriptMethod(55, Lifecycle.Static)]
        public async Task x01_01a_setup()
        {
            object_create_anew(x01_fleet);
            object_create_anew(carrier_01);
            object_create_anew_containing("cruiser");
            object_create_anew(matte_high_charity);
            object_create_anew(matte_threshold);
            object_create_anew(matte_halo_01);
            object_create_anew(matte_halo_02);
            object_create_anew(matte_stardust_01);
            object_create_anew(matte_stardust_02);
            object_cinematic_lod(carrier_01.Entity, true);
            object_cinematic_lod(cruiser_01.Entity, true);
            object_cinematic_lod(cruiser_02.Entity, true);
            object_cinematic_lod(cruiser_03.Entity, true);
            object_cinematic_lod(cruiser_04.Entity, true);
            object_cinematic_lod(cruiser_05.Entity, true);
            wake(new ScriptMethodReference(x01_score_01a));
            wake(new ScriptMethodReference(x01_foley_01a));
            wake(new ScriptMethodReference(x01_supratitle_01));
            wake(new ScriptMethodReference(cinematic_lighting_scene_01a));
        }

        [ScriptMethod(56, Lifecycle.Static)]
        public async Task x01_scene_01a()
        {
            sound_class_set_gain("amb", 0F, 0);
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start_movie("introduction");
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.x01_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_01a_fol", 3960605340U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\music\\x01_01_mus", 3960539803U));
            await sleep(this.prediction_offset);
            await sleep(45);
            await this.x01_01a_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_01", default(IUnit), anchor_flag_x01a);
            fade_in(0F, 0F, 0F, 90);
            scenery_animation_start_relative(carrier_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x01\\x01", 3960736414U), "01_capital_ship_01", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "01_ship01", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "01_ship02", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_03.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "01_ship03", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_04.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "01_ship04", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_05.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "01_ship05", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_high_charity.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\x01\\x01", 3960867488U), "high_charity_01", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_threshold.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\threshold_space\\x01\\x01", 3960933025U), "threshold_space_01", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_halo_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_01\\x01\\x01", 3960998562U), "halo_destroyed01_01", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_halo_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_02\\x01\\x01", 3961064099U), "halo_destroyed02_01", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_stardust_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\x01\\x01", 3961129636U), "stardust01_01", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_stardust_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\x01\\x01", 3961129636U), "stardust02_01", anchor_x01a.Entity);
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_01b_predict_stub();
            await this.x01_01b_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_01b_fol", 3961195173U));
            await sleep((short)((float)camera_time() - 1));
            cinematic_screen_effect_set_crossfade(2F);
            await sleep(1);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task x01_foley_01b()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_01b_fol", 3961195173U), default(IGameObject), 1F);
            print("x01 foley 01b start");
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task x01_0010_der()
        {
            await sleep(203);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0010_der", 3961260710U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0010_der", 1F);
        }

        [ScriptMethod(59, Lifecycle.Dormant)]
        public async Task banshee_audio()
        {
            sound_class_set_gain("vehicle_engine", 0F, 0);
            sound_class_set_gain("vehicle_engine", 1F, 120);
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task banshee_hotness()
        {
            object_set_function_variable(banshee_01.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_02.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_03.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_04.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_05.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_06.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_07.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_08.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_09.Entity, "engine_audio", 1F, 1F);
            object_set_function_variable(banshee_10.Entity, "engine_audio", 1F, 1F);
            await sleep(30);
            object_set_function_variable(banshee_06.Entity, "wingtips", 1F, 1F);
            object_set_function_variable(banshee_07.Entity, "wingtips", 1F, 1F);
            print("contrails start");
            await sleep(150);
            object_clear_function_variable(banshee_06.Entity, "wingtips");
            object_clear_function_variable(banshee_07.Entity, "wingtips");
            print("contrails stop");
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_01b()
        {
            cinematic_lighting_set_primary_light(-59F, 308F, 0.466667F, 0.517647F, 0.643137F);
            cinematic_lighting_set_secondary_light(-5F, 360F, 0.270588F, 0.313726F, 0.380392F);
            cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(banshee_01.Entity, true);
            object_uses_cinematic_lighting(banshee_02.Entity, true);
            object_uses_cinematic_lighting(banshee_03.Entity, true);
            object_uses_cinematic_lighting(banshee_04.Entity, true);
            object_uses_cinematic_lighting(banshee_05.Entity, true);
            object_uses_cinematic_lighting(banshee_06.Entity, true);
            object_uses_cinematic_lighting(banshee_07.Entity, true);
            object_uses_cinematic_lighting(banshee_08.Entity, true);
            object_uses_cinematic_lighting(banshee_09.Entity, true);
            object_uses_cinematic_lighting(banshee_10.Entity, true);
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task x01_01b_setup()
        {
            object_destroy(x01_fleet.Entity);
            object_create_anew(mercy);
            object_create_anew(regret);
            object_create_anew(throne_mercy);
            object_create_anew(throne_regret);
            objects_attach(mercy.Entity, "", throne_mercy.Entity, "driver_cinematic");
            objects_attach(regret.Entity, "", throne_regret.Entity, "driver_cinematic");
            object_create_anew_containing("matte");
            object_destroy_containing("carrier");
            object_destroy(x01_fleet.Entity);
            wake(new ScriptMethodReference(x01_foley_01b));
            wake(new ScriptMethodReference(x01_0010_der));
            wake(new ScriptMethodReference(banshee_audio));
            wake(new ScriptMethodReference(banshee_hotness));
            wake(new ScriptMethodReference(cinematic_lighting_scene_01b));
        }

        [ScriptMethod(63, Lifecycle.Static)]
        public async Task x01_scene_01b()
        {
            sound_class_set_gain("amb", 1F, 1);
            print("x01 scene 01b start");
            await this.x01_01b_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_01b", default(IUnit), anchor_flag_x01b);
            custom_animation_relative(banshee_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee01_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee02_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee03_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_04.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee04_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_05.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee05_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_06.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee06_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_07.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee07_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_08.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee08_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_09.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee09_01b", false, anchor_x01b.Entity);
            custom_animation_relative(banshee_10.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\banshee\\x01\\x01", 3961326247U), "banshee10_01b", false, anchor_x01b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_02_fol", 3961391784U));
            await sleep((short)((float)camera_time() - 1));
            cinematic_screen_effect_set_crossfade(1F);
            await sleep(1);
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task x01_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_02_fol", 3961391784U), default(IGameObject), 1F);
            print("x01 foley 02 start");
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task x01_0020_pot()
        {
            await sleep(19);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0020_pot", 3961457321U), truth.Entity, 1F);
            cinematic_subtitle("x01_0020_pot", 3F);
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task x01_0030_der()
        {
            await sleep(100);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0030_der", 3961522858U), dervish.Entity, 1F);
            cinematic_subtitle("x01_0030_der", 3F);
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task x01_0040_pcc()
        {
            await sleep(170);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0040_pcc", 3961588395U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0040_pcc", 7F);
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x01_0050_pom()
        {
            await sleep(289);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0050_pom", 3961653932U), mercy.Entity, 1F);
            cinematic_subtitle("x01_0050_pom", 2.5F);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x01_0060_der()
        {
            await sleep(391);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0060_der", 3961719469U), dervish.Entity, 1F);
            cinematic_subtitle("x01_0060_der", 2F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task x01_02_fov()
        {
            await sleep(196);
            camera_set_field_of_view(80F, 0);
            print("fov change: 60 -> 80 over 0 ticks");
            await sleep(90);
            camera_set_field_of_view(47F, 0);
            print("fov change: 80 -> 47 over 0 ticks");
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_02()
        {
            cinematic_lighting_set_primary_light(-90F, 116F, 0.258824F, 0.258824F, 0.317647F);
            cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            render_lights_enable_cinematic_shadow(true, dervish.Entity, "head", 0.4F);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(mercy.Entity, true);
            object_uses_cinematic_lighting(regret.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(prophet_counc_01.Entity, true);
            object_uses_cinematic_lighting(prophet_counc_02.Entity, true);
            object_uses_cinematic_lighting(prophet_counc_03.Entity, true);
            object_uses_cinematic_lighting(prophet_counc_04.Entity, true);
            object_uses_cinematic_lighting(ehg_01.Entity, true);
            object_uses_cinematic_lighting(ehg_02.Entity, true);
            object_uses_cinematic_lighting(ehg_03.Entity, true);
            object_uses_cinematic_lighting(ehg_04.Entity, true);
            object_uses_cinematic_lighting(ehg_05.Entity, true);
            object_uses_cinematic_lighting(ehg_06.Entity, true);
            object_uses_cinematic_lighting(ehg_07.Entity, true);
            object_uses_cinematic_lighting(ehg_08.Entity, true);
            object_uses_cinematic_lighting(ehg_09.Entity, true);
            object_uses_cinematic_lighting(ehg_10.Entity, true);
            object_uses_cinematic_lighting(ehg_11.Entity, true);
            object_uses_cinematic_lighting(ehg_12.Entity, true);
            object_uses_cinematic_lighting(throne_mercy.Entity, true);
            object_uses_cinematic_lighting(throne_regret.Entity, true);
            object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task x01_03_problem_actors()
        {
            print("problem actors");
            object_create_anew(poa_01);
            object_create_anew_containing("cruiser");
            object_create_anew(matte_reach);
            object_cinematic_lod(poa_01.Entity, true);
            object_cinematic_lod(cruiser_01.Entity, true);
            object_cinematic_lod(cruiser_02.Entity, true);
            object_cinematic_lod(cruiser_03.Entity, true);
            object_cinematic_lod(cruiser_04.Entity, true);
            object_cinematic_lod(cruiser_05.Entity, true);
            object_cinematic_lod(cruiser_06.Entity, true);
            object_cinematic_lod(cruiser_07.Entity, true);
            object_cinematic_lod(cruiser_08.Entity, true);
            object_cinematic_lod(cruiser_09.Entity, true);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task create_councillors_01()
        {
            await sleep(196);
            print("create councillors");
            object_create_anew_containing("elc");
            object_create_anew_containing("pcc");
            object_uses_cinematic_lighting(elc_01.Entity, true);
            object_uses_cinematic_lighting(elc_02.Entity, true);
            object_uses_cinematic_lighting(elc_03.Entity, true);
            object_uses_cinematic_lighting(elc_04.Entity, true);
            object_uses_cinematic_lighting(elc_05.Entity, true);
            object_uses_cinematic_lighting(elc_06.Entity, true);
            object_uses_cinematic_lighting(elc_07.Entity, true);
            object_uses_cinematic_lighting(elc_08.Entity, true);
            object_uses_cinematic_lighting(elc_09.Entity, true);
            object_uses_cinematic_lighting(elc_10.Entity, true);
            object_uses_cinematic_lighting(elc_11.Entity, true);
            object_uses_cinematic_lighting(elc_12.Entity, true);
            object_uses_cinematic_lighting(elc_13.Entity, true);
            object_uses_cinematic_lighting(elc_14.Entity, true);
            object_uses_cinematic_lighting(elc_15.Entity, true);
            object_uses_cinematic_lighting(elc_16.Entity, true);
            object_uses_cinematic_lighting(elc_17.Entity, true);
            object_uses_cinematic_lighting(elc_18.Entity, true);
            object_uses_cinematic_lighting(elc_19.Entity, true);
            object_uses_cinematic_lighting(elc_20.Entity, true);
            object_uses_cinematic_lighting(elc_21.Entity, true);
            object_uses_cinematic_lighting(elc_22.Entity, true);
            object_uses_cinematic_lighting(elc_23.Entity, true);
            object_uses_cinematic_lighting(elc_24.Entity, true);
            object_uses_cinematic_lighting(elc_25.Entity, true);
            object_uses_cinematic_lighting(elc_26.Entity, true);
            object_uses_cinematic_lighting(elc_27.Entity, true);
            object_uses_cinematic_lighting(elc_28.Entity, true);
            object_uses_cinematic_lighting(elc_29.Entity, true);
            object_uses_cinematic_lighting(elc_30.Entity, true);
            object_uses_cinematic_lighting(pcc_01.Entity, true);
            object_uses_cinematic_lighting(pcc_02.Entity, true);
            object_uses_cinematic_lighting(pcc_03.Entity, true);
            object_uses_cinematic_lighting(pcc_04.Entity, true);
            object_uses_cinematic_lighting(pcc_05.Entity, true);
            object_uses_cinematic_lighting(pcc_06.Entity, true);
            object_uses_cinematic_lighting(pcc_07.Entity, true);
            object_uses_cinematic_lighting(pcc_08.Entity, true);
            object_uses_cinematic_lighting(pcc_09.Entity, true);
            object_uses_cinematic_lighting(pcc_10.Entity, true);
            object_uses_cinematic_lighting(pcc_11.Entity, true);
            object_uses_cinematic_lighting(pcc_12.Entity, true);
            object_uses_cinematic_lighting(pcc_13.Entity, true);
            object_uses_cinematic_lighting(pcc_14.Entity, true);
            object_uses_cinematic_lighting(pcc_15.Entity, true);
            object_uses_cinematic_lighting(pcc_16.Entity, true);
            object_uses_cinematic_lighting(pcc_17.Entity, true);
            object_uses_cinematic_lighting(pcc_18.Entity, true);
            object_uses_cinematic_lighting(pcc_19.Entity, true);
            object_uses_cinematic_lighting(pcc_20.Entity, true);
            object_uses_cinematic_lighting(pcc_21.Entity, true);
            object_uses_cinematic_lighting(pcc_22.Entity, true);
            object_uses_cinematic_lighting(pcc_23.Entity, true);
            object_uses_cinematic_lighting(pcc_24.Entity, true);
            object_uses_cinematic_lighting(pcc_25.Entity, true);
            object_uses_cinematic_lighting(pcc_26.Entity, true);
            object_uses_cinematic_lighting(pcc_27.Entity, true);
            object_uses_cinematic_lighting(pcc_28.Entity, true);
            object_uses_cinematic_lighting(pcc_29.Entity, true);
            object_uses_cinematic_lighting(pcc_30.Entity, true);
            object_uses_cinematic_lighting(pcc_31.Entity, true);
            object_uses_cinematic_lighting(pcc_32.Entity, true);
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task x01_02_setup()
        {
            object_create_anew(dervish);
            object_create_anew(tartarus);
            object_create_anew_containing("ehg");
            object_create_anew(hammer);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(mercy.Entity, true);
            object_cinematic_lod(regret.Entity, true);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(throne_mercy.Entity, true);
            object_cinematic_lod(throne_regret.Entity, true);
            object_cinematic_lod(hammer.Entity, true);
            object_set_function_variable(tartarus.Entity, "invincibility", 0F, 0F);
            wake(new ScriptMethodReference(x01_foley_02));
            wake(new ScriptMethodReference(x01_0020_pot));
            wake(new ScriptMethodReference(x01_0030_der));
            wake(new ScriptMethodReference(x01_0040_pcc));
            wake(new ScriptMethodReference(x01_0050_pom));
            wake(new ScriptMethodReference(x01_0060_der));
            wake(new ScriptMethodReference(create_councillors_01));
            wake(new ScriptMethodReference(x01_02_fov));
            wake(new ScriptMethodReference(cinematic_lighting_scene_02));
        }

        [ScriptMethod(75, Lifecycle.Static)]
        public async Task x01_02_cleanup()
        {
            object_destroy(prophet_counc_03.Entity);
            object_destroy(prophet_counc_04.Entity);
        }

        [ScriptMethod(76, Lifecycle.Static)]
        public async Task x01_scene_02()
        {
            print("x01 scene 02 start");
            await this.x01_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_02", default(IUnit), anchor_flag_x01b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3961785006U), "dervish_02", false, anchor_x01b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "mercy_02", false, anchor_x01b.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "regret_02", false, anchor_x01b.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3961981617U), "tartarus_02", false, anchor_x01b.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x01\\x01", 3962047154U), "hammer_02", anchor_x01b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_03_predict_stub();
            await this.x01_03_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_03_fol", 3962112691U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.x01_02_cleanup();
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x01_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_03_fol", 3962112691U), default(IGameObject), 1F);
            print("x01 foley 03 start");
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x01_0070_der()
        {
            await sleep(65);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0070_der", 3962178228U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0070_der", 2F);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_03()
        {
            cinematic_lighting_set_primary_light(69F, 232F, 0.290196F, 0.32549F, 0.243137F);
            cinematic_lighting_set_secondary_light(-2F, 76F, 0.129412F, 0.141176F, 0.270588F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(poa_01.Entity, true);
            object_uses_cinematic_lighting(cruiser_01.Entity, true);
            object_uses_cinematic_lighting(cruiser_02.Entity, true);
            object_uses_cinematic_lighting(cruiser_03.Entity, true);
            object_uses_cinematic_lighting(cruiser_04.Entity, true);
            object_uses_cinematic_lighting(cruiser_05.Entity, true);
            object_uses_cinematic_lighting(cruiser_06.Entity, true);
            object_uses_cinematic_lighting(cruiser_07.Entity, true);
            object_uses_cinematic_lighting(cruiser_08.Entity, true);
            object_uses_cinematic_lighting(cruiser_09.Entity, true);
            object_uses_cinematic_lighting(cruiser_10.Entity, true);
            object_uses_cinematic_lighting(cruiser_11.Entity, true);
            object_uses_cinematic_lighting(cruiser_12.Entity, true);
        }

        [ScriptMethod(80, Lifecycle.Static)]
        public async Task x01_03_setup()
        {
            object_create(halo_whole);
            object_create_anew(matte_reach);
            object_create_anew(matte_stardust_01);
            wake(new ScriptMethodReference(x01_foley_03));
            wake(new ScriptMethodReference(x01_0070_der));
            wake(new ScriptMethodReference(cinematic_lighting_scene_03));
        }

        [ScriptMethod(81, Lifecycle.Static)]
        public async Task x01_scene_03()
        {
            sound_class_set_gain("amb", 0F, 1);
            await this.x01_03_setup();
            camera_set_field_of_view(60F, 0);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_03", default(IUnit), anchor_flag_x01a);
            fade_in(1F, 1F, 1F, 15);
            scenery_animation_start_relative(poa_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\x01\\x01", 3962243765U), "poa_03", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship01", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship02", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_03.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship03", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_04.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship04", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_05.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship05", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_06.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship06", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_07.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship07", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_08.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship08", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_09.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "03_ship09", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_reach.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\reach_space\\x01\\x01", 3962309302U), "reach_space_03", anchor_x01a.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_04_predict_stub();
            await sleep((short)((float)camera_time() - 1));
            cinematic_screen_effect_set_crossfade(2F);
            await sleep(1);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x01_0080_por()
        {
            await sleep(12);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0080_por", 3962374839U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0080_por", 5F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x01_0090_der()
        {
            await sleep(152);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0090_der", 3962440376U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0090_der", 1F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x01_0100_por()
        {
            await sleep(180);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0100_por", 3962505913U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0100_por", 2F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x01_0110_der()
        {
            await sleep(238);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0110_der", 3962571450U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0110_der", 1F);
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_04()
        {
            cinematic_lighting_set_primary_light(-42F, 60F, 0.4F, 0.380392F, 0.270588F);
            cinematic_lighting_set_secondary_light(38F, 222F, 0.141176F, 0.141176F, 0.290196F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(halo_whole.Entity, true);
            object_uses_cinematic_lighting(cruiser_10.Entity, true);
            object_uses_cinematic_lighting(cruiser_11.Entity, true);
            object_uses_cinematic_lighting(cruiser_12.Entity, true);
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task x01_04_setup()
        {
            wake(new ScriptMethodReference(x01_0080_por));
            wake(new ScriptMethodReference(x01_0090_der));
            wake(new ScriptMethodReference(x01_0100_por));
            wake(new ScriptMethodReference(x01_0110_der));
            wake(new ScriptMethodReference(cinematic_lighting_scene_04));
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x01_04_cleanup()
        {
            object_destroy(poa_01.Entity);
            object_destroy(halo_whole.Entity);
            object_destroy_containing("cruiser");
            object_destroy_containing("matte");
        }

        [ScriptMethod(89, Lifecycle.Static)]
        public async Task x01_scene_04()
        {
            print("x01 scene 04 start");
            await this.x01_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_04", default(IUnit), anchor_flag_x01a);
            scenery_animation_start_relative(cruiser_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship01", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship02", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_03.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship03", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_04.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship04", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_05.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship05", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_06.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship06", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_07.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship07", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_08.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship08", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_09.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship09", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_10.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship10", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_11.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship11", anchor_x01a.Entity);
            scenery_animation_start_relative(cruiser_12.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\battle_cruiser\\x01\\x01", 3960801951U), "04_ship12", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_threshold.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\threshold_space\\x01\\x01", 3960933025U), "threshold_space_04", anchor_x01a.Entity);
            scenery_animation_start_relative(halo_whole.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x01\\x01", 3962636987U), "halo_04", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_stardust_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\x01\\x01", 3961129636U), "stardust01_04", anchor_x01a.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_05_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_05_fol", 3962702524U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            wake(new ScriptMethodReference(x01_04_cleanup));
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task x01_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_05_fol", 3962702524U), default(IGameObject), 1F);
            print("x01 foley 05 start");
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task x01_0120_por()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0120_por", 3962768061U), regret.Entity, 1F);
            cinematic_subtitle("x01_0120_por", 4F);
            unit_set_emotional_state(regret.Entity, "arrogant", 0.5F, 90);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x01_0130_por()
        {
            await sleep(141);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0130_por", 3962833598U), regret.Entity, 1F);
            cinematic_subtitle("x01_0130_por", 3F);
            unit_set_emotional_state(regret.Entity, "angry", 1F, 30);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_05()
        {
            cinematic_lighting_set_primary_light(-90F, 116F, 0.258824F, 0.258824F, 0.317647F);
            cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(mercy.Entity, true);
            object_uses_cinematic_lighting(regret.Entity, true);
        }

        [ScriptMethod(94, Lifecycle.Static)]
        public async Task x01_05_setup()
        {
            wake(new ScriptMethodReference(x01_foley_05));
            wake(new ScriptMethodReference(x01_0120_por));
            wake(new ScriptMethodReference(x01_0130_por));
            wake(new ScriptMethodReference(cinematic_lighting_scene_05));
        }

        [ScriptMethod(95, Lifecycle.Static)]
        public async Task x01_scene_05()
        {
            sound_class_set_gain("amb", 1F, 1);
            await this.x01_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_05", default(IUnit), anchor_flag_x01b);
            fade_in(1F, 1F, 1F, 15);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "mercy_05", false, anchor_x01b.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "regret_05", false, anchor_x01b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_06_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_06_fol", 3962899135U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task x01_foley_06()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_06_fol", 3962899135U), default(IGameObject), 1F);
            print("x01 foley 06 start");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x01_0140_der()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0140_der", 3962964672U), dervish.Entity, 1F);
            cinematic_subtitle("x01_0140_der", 4F);
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x01_0150_cch()
        {
            await sleep(112);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0150_cch", 3963030209U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0150_cch", 3F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x01_0160_pom()
        {
            await sleep(199);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0160_pom", 3963095746U), mercy.Entity, 1F);
            cinematic_subtitle("x01_0160_pom", 2F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x01_0170_pot()
        {
            await sleep(330);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0170_pot", 3963161283U), truth.Entity, 1F);
            cinematic_subtitle("x01_0170_pot", 6F);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task x01_0180_der()
        {
            await sleep(524);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0180_der", 3963226820U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0180_der", 8F);
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_06()
        {
            cinematic_lighting_set_primary_light(-90F, 116F, 0.258824F, 0.258824F, 0.317647F);
            cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(truth.Entity, true);
            object_uses_cinematic_lighting(mercy.Entity, true);
            object_uses_cinematic_lighting(regret.Entity, true);
        }

        [ScriptMethod(103, Lifecycle.Static)]
        public async Task x01_06_setup()
        {
            object_create_anew(truth);
            object_create_anew(throne_truth);
            object_cinematic_lod(truth.Entity, true);
            object_cinematic_lod(throne_truth.Entity, true);
            objects_attach(truth.Entity, "", throne_truth.Entity, "driver_cinematic");
            wake(new ScriptMethodReference(x01_foley_06));
            wake(new ScriptMethodReference(x01_0140_der));
            wake(new ScriptMethodReference(x01_0150_cch));
            wake(new ScriptMethodReference(x01_0160_pom));
            wake(new ScriptMethodReference(x01_0170_pot));
            wake(new ScriptMethodReference(x01_0180_der));
            wake(new ScriptMethodReference(cinematic_lighting_scene_06));
        }

        [ScriptMethod(104, Lifecycle.Static)]
        public async Task x01_07_problem_actors()
        {
            print("problem actors");
            object_create_anew(halo_exploding);
            object_cinematic_lod(halo_exploding.Entity, true);
        }

        [ScriptMethod(105, Lifecycle.Static)]
        public async Task x01_scene_06()
        {
            print("x01 scene 06 start");
            await this.x01_06_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_06", default(IUnit), anchor_flag_x01b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3961785006U), "dervish_06", false, anchor_x01b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "truth_06", false, anchor_x01b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "mercy_06", false, anchor_x01b.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "regret_06", false, anchor_x01b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_07_predict_stub();
            await this.x01_07_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_07_fol", 3963292357U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task x01_foley_07()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\foley\\x01_07_fol", 3963292357U), default(IGameObject), 1F);
            print("x01 foley 07 start");
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task x01_0190_der()
        {
            await sleep(93);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0190_der", 3963357894U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0190_der", 1F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_07()
        {
            cinematic_lighting_set_primary_light(56F, 18F, 0.4F, 0.380392F, 0.270588F);
            cinematic_lighting_set_secondary_light(-77F, 40F, 0.172549F, 0.172549F, 0.372549F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(halo_exploding.Entity, true);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task halo_explosion()
        {
            await sleep(60);
            print("effect - halo explosion");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01\\halo_destruction", 3963423431U), halo_exploding.Entity, "explosion_poa_front");
        }

        [ScriptMethod(110, Lifecycle.Static)]
        public async Task x01_07_setup()
        {
            wake(new ScriptMethodReference(x01_foley_07));
            wake(new ScriptMethodReference(x01_0190_der));
            wake(new ScriptMethodReference(halo_explosion));
            wake(new ScriptMethodReference(cinematic_lighting_scene_07));
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\alpha_halo_explosion", 3963685579U), halo_exploding.Entity, "explosion_poa_front");
        }

        [ScriptMethod(111, Lifecycle.Static)]
        public async Task x01_scene_07()
        {
            sound_class_set_gain("amb", 0F, 1);
            await this.x01_07_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_07", default(IUnit), anchor_flag_x01a);
            fade_in(1F, 1F, 1F, 15);
            scenery_animation_start_relative(halo_exploding.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo_exploding\\x01\\x01", 3964209875U), "halo_07", anchor_x01a.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_08_predict_stub();
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            object_destroy(halo_exploding.Entity);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x01_0200_pcc()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0200_pcc", 3964275412U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0200_pcc", 7F);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task x01_0210_tar()
        {
            await sleep(244);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0210_tar", 3964340949U), tartarus.Entity, 1F);
            cinematic_subtitle("x01_0210_tar", 1F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x01_0220_por()
        {
            await sleep(279);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0220_por", 3964406486U), regret.Entity, 1F);
            cinematic_subtitle("x01_0220_por", 7F);
            unit_set_emotional_state(regret.Entity, "angry", 0.5F, 60);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task x01_0230_pot()
        {
            await sleep(470);
            unit_set_emotional_state(truth.Entity, "angry", 0.25F, 60);
            await sleep(20);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0230_pot", 3964472023U), truth.Entity, 1F);
            cinematic_subtitle("x01_0230_pot", 7F);
            unit_set_emotional_state(regret.Entity, "shocked", 0.5F, 30);
            await sleep(60);
            unit_set_emotional_state(regret.Entity, "arrogant", 0.5F, 60);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task x01_0240_pot()
        {
            await sleep(705);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0240_pot", 3964537560U), truth.Entity, 1F);
            cinematic_subtitle("x01_0240_pot", 6F);
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task x01_08_fov()
        {
            await sleep(689);
            camera_set_field_of_view(38F, 0);
            print("fov change: 60 -> 38 over 0 ticks");
            await sleep(111);
            camera_set_field_of_view(60F, 0);
            print("fov change: 38 -> 60 over 0 ticks");
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_08()
        {
            cinematic_lighting_set_primary_light(-90F, 116F, 0.258824F, 0.258824F, 0.317647F);
            cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(truth.Entity, true);
            object_uses_cinematic_lighting(mercy.Entity, true);
            object_uses_cinematic_lighting(regret.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(prophet_counc_01.Entity, true);
            object_uses_cinematic_lighting(prophet_counc_02.Entity, true);
            object_uses_cinematic_lighting(elite_counc_01.Entity, true);
            object_uses_cinematic_lighting(elite_counc_02.Entity, true);
        }

        [ScriptMethod(119, Lifecycle.Static)]
        public async Task x01_08_setup()
        {
            object_destroy(elc_26.Entity);
            object_destroy(elc_27.Entity);
            object_destroy(pcc_33.Entity);
            object_destroy(pcc_34.Entity);
            object_create_anew(prophet_counc_01);
            object_create_anew(prophet_counc_02);
            object_create_anew(elite_counc_01);
            object_create_anew(elite_counc_02);
            object_cinematic_lod(prophet_counc_01.Entity, true);
            object_cinematic_lod(prophet_counc_02.Entity, true);
            object_cinematic_lod(elite_counc_01.Entity, true);
            object_cinematic_lod(elite_counc_02.Entity, true);
            wake(new ScriptMethodReference(x01_0200_pcc));
            wake(new ScriptMethodReference(x01_0210_tar));
            wake(new ScriptMethodReference(x01_0220_por));
            wake(new ScriptMethodReference(x01_0230_pot));
            wake(new ScriptMethodReference(x01_0240_pot));
            wake(new ScriptMethodReference(x01_08_fov));
            wake(new ScriptMethodReference(cinematic_lighting_scene_08));
        }

        [ScriptMethod(120, Lifecycle.Static)]
        public async Task x01_08_cleanup()
        {
            cinematic_screen_effect_stop();
            print("rack focus stop");
            object_destroy(elite_counc_01.Entity);
            object_destroy(elite_counc_02.Entity);
        }

        [ScriptMethod(121, Lifecycle.Static)]
        public async Task x01_scene_08()
        {
            sound_class_set_gain("amb", 1F, 1);
            print("x01 scene 08 start");
            await this.x01_08_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_08", default(IUnit), anchor_flag_x01b);
            fade_in(1F, 1F, 1F, 15);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3961785006U), "dervish_08", false, anchor_x01b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "truth_08", false, anchor_x01b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "mercy_08", false, anchor_x01b.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "regret_08", false, anchor_x01b.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3961981617U), "tartarus_08", false, anchor_x01b.Entity);
            custom_animation_relative(prophet_counc_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "prophet01_08", false, anchor_x01b.Entity);
            custom_animation_relative(prophet_counc_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "prophet02_08", false, anchor_x01b.Entity);
            custom_animation_relative(elite_counc_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x01\\x01", 3964603097U), "elite01_08", false, anchor_x01b.Entity);
            custom_animation_relative(elite_counc_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x01\\x01", 3964603097U), "elite02_08", false, anchor_x01b.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x01\\x01", 3962047154U), "hammer_08", anchor_x01b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_09_predict_stub();
            await sleep((short)camera_time());
            await this.x01_08_cleanup();
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task x01_0250_pc1()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0250_pc1", 3964668634U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0250_pc1", 3F);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task x01_0260_pcc()
        {
            await sleep(60);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0260_pcc", 3964734171U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0260_pcc", 9F);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x01_0270_der()
        {
            await sleep(252);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0270_der", 3964799708U), dervish.Entity, 1F);
            cinematic_subtitle("x01_0270_der", 4F);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task x01_0280_pot()
        {
            await sleep(376);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0280_pot", 3964865245U), truth.Entity, 1F);
            cinematic_subtitle("x01_0280_pot", 3F);
            await sleep(30);
            unit_set_emotional_state(truth.Entity, "arrogant", 0.5F, 60);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task x01_0290_tar()
        {
            await sleep(494);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0290_tar", 3964930782U), tartarus.Entity, 1F);
            cinematic_subtitle("x01_0290_tar", 1F);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task x01_09_fov()
        {
            await sleep(441);
            camera_set_field_of_view(38F, 0);
            print("fov change: 60 -> 38 over 0 ticks");
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_09()
        {
            cinematic_lighting_set_primary_light(-90F, 116F, 0.258824F, 0.258824F, 0.317647F);
            cinematic_lighting_set_secondary_light(-26F, 148F, 0.254902F, 0.203922F, 0.270588F);
            cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            object_uses_cinematic_lighting(hammer.Entity, true);
            object_uses_cinematic_lighting(elc_26.Entity, true);
            object_uses_cinematic_lighting(elc_27.Entity, true);
        }

        [ScriptMethod(129, Lifecycle.Static)]
        public async Task x01_10_problem_actors()
        {
            print("problem actors");
            object_create_anew(brute_01);
            object_create_anew(brute_02);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
        }

        [ScriptMethod(130, Lifecycle.Static)]
        public async Task x01_09_setup()
        {
            object_create_anew(elc_26);
            object_create_anew(elc_27);
            wake(new ScriptMethodReference(x01_0250_pc1));
            wake(new ScriptMethodReference(x01_0260_pcc));
            wake(new ScriptMethodReference(x01_0270_der));
            wake(new ScriptMethodReference(x01_0280_pot));
            wake(new ScriptMethodReference(x01_0290_tar));
            wake(new ScriptMethodReference(x01_09_fov));
            wake(new ScriptMethodReference(cinematic_lighting_scene_09));
        }

        [ScriptMethod(131, Lifecycle.Static)]
        public async Task x01_09_cleanup()
        {
            object_destroy(prophet_counc_01.Entity);
            object_destroy(prophet_counc_02.Entity);
        }

        [ScriptMethod(132, Lifecycle.Static)]
        public async Task x01_scene_09()
        {
            print("x01 scene 09 start");
            await this.x01_09_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_09", default(IUnit), anchor_flag_x01b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3961785006U), "dervish_09", false, anchor_x01b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "truth_09", false, anchor_x01b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "mercy_09", false, anchor_x01b.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "regret_09", false, anchor_x01b.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3961981617U), "tartarus_09", false, anchor_x01b.Entity);
            custom_animation_relative(prophet_counc_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "prophet01_09", false, anchor_x01b.Entity);
            custom_animation_relative(prophet_counc_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "prophet02_09", false, anchor_x01b.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x01\\x01", 3962047154U), "hammer_09", anchor_x01b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x01_10_predict_stub();
            await this.x01_10_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\music\\x01_c01_intro_trans_mus", 3964996319U));
            await sleep((short)camera_time());
            await this.x01_09_cleanup();
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task x01_score_10()
        {
            await sleep(79);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x01\\music\\x01_c01_intro_trans_mus", 3964996319U), default(IGameObject), 1F);
            print("x01 score 10 start");
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task x01_0300_pot()
        {
            await sleep(20);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0300_pot", 3965061856U), truth.Entity, 1F);
            cinematic_subtitle("x01_0300_pot", 2F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task x01_0310_cch()
        {
            await sleep(98);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0310_cch", 3965127393U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0310_cch", 3F);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task x01_0320_pot()
        {
            await sleep(180);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0320_pot", 3965192930U), default(IGameObject), 1F);
            cinematic_subtitle("x01_0320_pot", 4F);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task x01_0330_pot()
        {
            await sleep(329);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x01_0330_pot", 3965258467U), truth.Entity, 1F);
            cinematic_subtitle("x01_0330_pot", 2F);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_10()
        {
            cinematic_lighting_set_primary_light(19F, 298F, 0.266667F, 0.266667F, 0.317647F);
            cinematic_lighting_set_secondary_light(-53F, 106F, 0.168627F, 0.168627F, 0.223529F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(pcc_19.Entity, true);
            object_uses_cinematic_lighting(pcc_20.Entity, true);
            object_uses_cinematic_lighting(pcc_23.Entity, true);
            object_uses_cinematic_lighting(pcc_24.Entity, true);
            object_uses_cinematic_lighting(pcc_25.Entity, true);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task improve_framerate()
        {
            time_code_reset();
            await sleep(223);
            print("improve framerate");
            object_destroy_containing("pcc");
            object_destroy_containing("elc");
        }

        [ScriptMethod(140, Lifecycle.Static)]
        public async Task x01_10_setup()
        {
            object_create_anew(pcc_19);
            object_create_anew(pcc_20);
            object_create_anew(pcc_23);
            object_create_anew(pcc_24);
            object_create_anew(pcc_25);
            wake(new ScriptMethodReference(x01_score_10));
            wake(new ScriptMethodReference(improve_framerate));
            wake(new ScriptMethodReference(x01_0300_pot));
            wake(new ScriptMethodReference(x01_0310_cch));
            wake(new ScriptMethodReference(x01_0320_pot));
            wake(new ScriptMethodReference(x01_0330_pot));
            wake(new ScriptMethodReference(cinematic_lighting_scene_10));
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task x01_10_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy(truth.Entity);
            object_destroy(mercy.Entity);
            object_destroy(regret.Entity);
            object_destroy(tartarus.Entity);
            object_destroy_containing("throne");
            object_destroy_containing("brute");
            object_destroy_containing("ehg");
            object_destroy(hammer.Entity);
        }

        [ScriptMethod(142, Lifecycle.Static)]
        public async Task x01_scene_10()
        {
            await this.x01_10_setup();
            camera_set_field_of_view(60F, 0);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x01\\x01", 3960670877U), "x01_10", default(IUnit), anchor_flag_x01b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x01\\x01", 3961785006U), "dervish_10", false, anchor_x01b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "truth_10", false, anchor_x01b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "mercy_10", false, anchor_x01b.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x01\\x01", 3961916080U), "regret_10", false, anchor_x01b.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3961981617U), "tartarus_10", false, anchor_x01b.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3961981617U), "brute01_10", false, anchor_x01b.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x01\\x01", 3961981617U), "brute02_10", false, anchor_x01b.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x01\\x01", 3962047154U), "hammer_10", anchor_x01b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_intro_01_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_intro\\foley\\c01_intro_01_fol", 3965324004U));
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - 16));
            cinematic_screen_effect_set_crossfade(1F);
            await sleep(1);
            await this.x01_10_cleanup();
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task c01_intro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_intro\\foley\\c01_intro_01_fol", 3965324004U), default(IGameObject), 1F);
            print("c01 intro foley 01 start");
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task c01_1010_qtm()
        {
            await sleep(390);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1010_qtm", 3965389541U), default(IGameObject), 1F);
            cinematic_subtitle("c01_1010_qtm", 3F);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task c01_intro_supratitle_01()
        {
            await sleep(285);
            cinematic_set_title(cinematic_title1);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task lens_flares()
        {
            object_create_anew_containing("yellow_01");
            await sleep(15);
            object_create_anew_containing("yellow_02");
            await sleep(15);
            object_create_anew_containing("red");
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task c01_intro_dof_01()
        {
            time_code_reset();
            await sleep(404);
            object_destroy(athens.Entity);
            object_destroy(malta.Entity);
            object_destroy(poa_01.Entity);
            print("rack focus");
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1.5F, 1F, 1F, 0F, 0F, 0F, 0F);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task cinematic_lighting_c01_scene_01()
        {
            cinematic_lighting_set_primary_light(-11F, 360F, 0.415686F, 0.415686F, 0.501961F);
            cinematic_lighting_set_secondary_light(41F, 230F, 0F, 0F, 0F);
            cinematic_lighting_set_ambient_light(0.0588235F, 0.0470588F, 0.0431373F);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(cairo.Entity, true);
            object_uses_cinematic_lighting(malta.Entity, true);
            object_uses_cinematic_lighting(athens.Entity, true);
            object_uses_cinematic_lighting(poa_01.Entity, true);
            object_uses_cinematic_lighting(poa_02.Entity, true);
            object_uses_cinematic_lighting(poa_03.Entity, true);
            object_uses_cinematic_lighting(iac_01.Entity, true);
            object_uses_cinematic_lighting(iac_02.Entity, true);
            object_uses_cinematic_lighting(iac_03.Entity, true);
            object_uses_cinematic_lighting(iac_04.Entity, true);
            object_uses_cinematic_lighting(iac_05.Entity, true);
            object_uses_cinematic_lighting(fighter_01.Entity, true);
            object_uses_cinematic_lighting(fighter_02.Entity, true);
            object_uses_cinematic_lighting(fighter_03.Entity, true);
            object_uses_cinematic_lighting(fighter_04.Entity, true);
            object_uses_cinematic_lighting(fighter_05.Entity, true);
            object_uses_cinematic_lighting(fighter_06.Entity, true);
            object_uses_cinematic_lighting(fighter_08.Entity, true);
        }

        [ScriptMethod(149, Lifecycle.Static)]
        public async Task c01_02_problem_actors()
        {
            print("problem actors");
            object_create_anew(master_guns);
            object_create_anew(armory);
            object_create_anew(cart);
            object_create_anew(optics);
            object_create_anew(power_supply);
            object_cinematic_lod(master_guns.Entity, true);
            object_cinematic_lod(armory.Entity, true);
            object_cinematic_lod(cart.Entity, true);
            object_cinematic_lod(optics.Entity, true);
            object_cinematic_lod(power_supply.Entity, true);
            object_hide(master_guns.Entity, true);
            object_hide(armory.Entity, true);
            object_hide(cart.Entity, true);
            object_hide(optics.Entity, true);
            object_hide(power_supply.Entity, true);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task ships_unhide()
        {
            await sleep(150);
            print("ships unhide");
            object_hide(poa_01.Entity, false);
            object_hide(poa_02.Entity, false);
            object_hide(poa_03.Entity, false);
        }

        [ScriptMethod(151, Lifecycle.Static)]
        public async Task c01_intro_scene_01_setup()
        {
            object_create_anew(cairo);
            object_create_anew(malta);
            object_create_anew(athens);
            object_create_anew_containing("iac");
            object_create_anew_containing("poa");
            object_create_anew_containing("fighter");
            object_hide(poa_01.Entity, true);
            object_hide(poa_02.Entity, true);
            object_hide(poa_03.Entity, true);
            object_create_anew(matte_earth);
            object_create_anew(matte_moon);
            object_cinematic_lod(cairo.Entity, true);
            object_cinematic_lod(malta.Entity, true);
            object_cinematic_lod(athens.Entity, true);
            wake(new ScriptMethodReference(c01_intro_foley_01));
            wake(new ScriptMethodReference(c01_1010_qtm));
            wake(new ScriptMethodReference(ships_unhide));
            wake(new ScriptMethodReference(c01_intro_supratitle_01));
            wake(new ScriptMethodReference(lens_flares));
            wake(new ScriptMethodReference(cinematic_lighting_c01_scene_01));
        }

        [ScriptMethod(152, Lifecycle.Static)]
        public async Task c01_intro_scene_01_cleanup()
        {
            cinematic_screen_effect_stop();
            print("rack focus stop");
            object_destroy(cairo.Entity);
            object_destroy(athens.Entity);
            object_destroy(malta.Entity);
            object_destroy_containing("iac");
            object_destroy_containing("poa");
            object_destroy_containing("fighter");
            object_destroy_containing("matte");
        }

        [ScriptMethod(153, Lifecycle.Static)]
        public async Task c01_intro_scene_01()
        {
            sound_class_set_gain("amb", 0F, 1);
            await this.c01_intro_scene_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_intro\\01_intro", 3965455078U), "01_intro_01", default(IUnit), anchor_flag_x01a);
            scenery_animation_start_relative(athens.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\01_intro\\01_intro", 3965520615U), "ss_prop01_01", anchor_x01a.Entity);
            scenery_animation_start_relative(cairo.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo\\cairo", 3829793488U), "01_intro_01", anchor_x01a.Entity);
            scenery_animation_start_relative(malta.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\01_intro\\01_intro", 3965520615U), "ss_prop03_01", anchor_x01a.Entity);
            scenery_animation_start_relative(iac_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3965586152U), "iac_01", anchor_x01a.Entity);
            scenery_animation_start_relative(iac_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3965586152U), "iac_02", anchor_x01a.Entity);
            scenery_animation_start_relative(iac_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3965586152U), "iac_03", anchor_x01a.Entity);
            scenery_animation_start_relative(iac_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3965586152U), "iac_04", anchor_x01a.Entity);
            scenery_animation_start_relative(iac_05.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_intro\\01_intro", 3965586152U), "iac_05", anchor_x01a.Entity);
            scenery_animation_start_relative(poa_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\01_intro\\01_intro", 3965651689U), "poa_01", anchor_x01a.Entity);
            scenery_animation_start_relative(poa_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\01_intro\\01_intro", 3965651689U), "poa_02", anchor_x01a.Entity);
            scenery_animation_start_relative(poa_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\01_intro\\01_intro", 3965651689U), "poa_03", anchor_x01a.Entity);
            scenery_animation_start_relative(fighter_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3965717226U), "longsword_01", anchor_x01a.Entity);
            scenery_animation_start_relative(fighter_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3965717226U), "longsword_02", anchor_x01a.Entity);
            scenery_animation_start_relative(fighter_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3965717226U), "longsword_03", anchor_x01a.Entity);
            scenery_animation_start_relative(fighter_04.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3965717226U), "longsword_04", anchor_x01a.Entity);
            scenery_animation_start_relative(fighter_05.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3965717226U), "longsword_05", anchor_x01a.Entity);
            scenery_animation_start_relative(fighter_06.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3965717226U), "longsword_06", anchor_x01a.Entity);
            scenery_animation_start_relative(fighter_07.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3965717226U), "longsword_07", anchor_x01a.Entity);
            scenery_animation_start_relative(fighter_08.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_intro\\01_intro", 3965717226U), "longsword_08", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_earth.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\earth_space\\01_intro\\01_intro", 3965782763U), "earth_space_01", anchor_x01a.Entity);
            scenery_animation_start_relative(matte_moon.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\moon\\01_intro\\01_intro", 3965848300U), "moon_01", anchor_x01a.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_intro_02_predict_stub();
            await this.c01_02_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_intro\\foley\\c01_intro_02_fol", 3965913837U));
            await sleep((short)camera_time());
            await this.c01_intro_scene_01_cleanup();
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task c01_intro_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_intro\\foley\\c01_intro_02_fol", 3965913837U), default(IGameObject), 1F);
            print("c01 intro foley 01 start");
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task c01_1020_qtm()
        {
            await sleep(18);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1020_qtm", 3965979374U), master_guns.Entity, 1F);
            cinematic_subtitle("c01_1020_qtm", 2F);
            unit_set_emotional_state(master_guns.Entity, "annoyed", 1F, 0);
            print("master guns - annoyed 1 0");
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task c01_1030_qtm()
        {
            await sleep(91);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1030_qtm", 3966044911U), master_guns.Entity, 1F);
            cinematic_subtitle("c01_1030_qtm", 2F);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task c01_1040_qtm()
        {
            await sleep(173);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1040_qtm", 3966110448U), master_guns.Entity, 1F);
            cinematic_subtitle("c01_1040_qtm", 2F);
            unit_set_emotional_state(master_guns.Entity, "angry", 1F, 15);
            print("master guns - angry 1 15");
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task c01_1050_mas()
        {
            await sleep(396);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_1050_mas", 3966175985U), chief.Entity, 1F);
            cinematic_subtitle("c01_1050_mas", 1F);
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task cinematic_lighting_c01_scene_02()
        {
            cinematic_lighting_set_primary_light(12F, 184F, 0.117647F, 0.109804F, 0.0901961F);
            cinematic_lighting_set_secondary_light(-48F, 106F, 0.113725F, 0.113725F, 0.0941177F);
            cinematic_lighting_set_ambient_light(0.0352941F, 0.0392157F, 0.0666667F);
            render_lights_enable_cinematic_shadow(true, chief.Entity, "head", 0.25F);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(master_guns.Entity, true);
            object_uses_cinematic_lighting(armory.Entity, true);
            object_uses_cinematic_lighting(cart.Entity, true);
            object_uses_cinematic_lighting(optics.Entity, true);
            object_uses_cinematic_lighting(power_supply.Entity, true);
            object_uses_cinematic_lighting(helmet.Entity, true);
        }

        [ScriptMethod(160, Lifecycle.Static)]
        public async Task c01_intro_scene_02_setup()
        {
            object_hide(master_guns.Entity, false);
            object_hide(armory.Entity, false);
            object_hide(cart.Entity, false);
            object_hide(optics.Entity, false);
            object_hide(power_supply.Entity, false);
            object_create_anew(chief);
            object_create_anew(helmet);
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(helmet.Entity, true);
            wake(new ScriptMethodReference(c01_intro_foley_02));
            wake(new ScriptMethodReference(c01_1020_qtm));
            wake(new ScriptMethodReference(c01_1030_qtm));
            wake(new ScriptMethodReference(c01_1040_qtm));
            wake(new ScriptMethodReference(c01_1050_mas));
            wake(new ScriptMethodReference(cinematic_lighting_c01_scene_02));
        }

        [ScriptMethod(161, Lifecycle.Static)]
        public async Task c01_intro_scene_02_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(master_guns.Entity);
            object_destroy(armory.Entity);
            object_destroy(cart.Entity);
            object_destroy(optics.Entity);
            object_destroy(power_supply.Entity);
            object_destroy(helmet.Entity);
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task c01_intro_scene_02()
        {
            disable_render_light_suppressor();
            sound_class_set_gain("amb", 1F, 1);
            await this.c01_intro_scene_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_intro\\01_intro", 3965455078U), "01_intro_02", default(IUnit), anchor_flag_x01a);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_intro\\01_intro", 3966241522U), "chief_02", false, anchor_x01a.Entity);
            custom_animation_relative(master_guns.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\01_intro\\01_intro", 3966307059U), "quartermaster_02", false, anchor_x01a.Entity);
            scenery_animation_start_relative(armory.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_armory\\01_intro\\01_intro", 3966438133U), "cairo_armory_02", anchor_x01a.Entity);
            scenery_animation_start_relative(cart.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\equipment_cart\\01_intro\\01_intro", 3966503670U), "equipment_cart_02", anchor_x01a.Entity);
            scenery_animation_start_relative(optics.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\optics\\01_intro\\01_intro", 3966569207U), "optics_02", anchor_x01a.Entity);
            scenery_animation_start_relative(power_supply.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\power_core\\01_intro\\01_intro", 3966634744U), "power_supply_02", anchor_x01a.Entity);
            scenery_animation_start_relative(helmet.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\helmet\\01_intro\\01_intro", 3966700281U), "helmet_02", anchor_x01a.Entity);
            await sleep((short)((float)camera_time() - 15));
            sound_class_set_gain("amb", 0F, 15);
            enable_render_light_suppressor();
            loading_screen_fade_to_white();
        }

        [ScriptMethod(163, Lifecycle.Static)]
        public async Task intro()
        {
            texture_cache_flush();
            geometry_cache_flush();
            sound_class_set_gain("device_door", 0F, 0);
            cinematic_outro_start();
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
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(164, Lifecycle.Startup)]
        public async Task _fade_out()
        {
            switch_bsp_by_name(GetReference<IBsp>("high_0"));
            if (await this.cinematic_skip_start())
            {
                await this.intro();
            }

            await this.cinematic_skip_stop();
            game_won();
        }
    }
}