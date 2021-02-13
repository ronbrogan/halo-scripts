namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\01b_spacestation\\01b_spacestation")]
    public partial class scnr_01b_spacestation : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int delay_blink;
        int delay_dawdle;
        int delay_tutorial;
        int delay_prompt;
        int delay_witness;
        int delay_wait;
        int delay_late;
        int delay_lost;
        bool mark_bsp0;
        bool mark_bsp1;
        bool mark_bsp2;
        bool mark_bsp3;
        bool mark_bsp4;
        bool mark_bsp5;
        bool gbl_1st_waves;
        int sound_offset;
        int prediction_offset;
        int seconds;
        bool mark_1st_waves_end;
        bool mark_bomb2_objective;
        bool mark_1st_blast;
        int timer_flavor;
        int global_flavor_delay;
        bool mark_flavor_disable;
        bool mark_flavor_vacuum;
        bool mark_flavor_brace;
        bool mark_flavor_gun;
        bool mark_flavor_dck;
        bool mark_flavor_trm1;
        bool mark_flavor_atr1;
        bool mark_flavor_bay2;
        bool mark_flavor_bay1;
        bool mark_flavor_atr2;
        bool mark_flavor_1st;
        bool mark_flavor_board;
        bool mark_flavor_bomb;
        bool mark_flavor_init;
        bool mark_flavor_megg;
        bool mark_flavor_safe_cycle;
        int counter_flavor_brace;
        int counter_flavor_gun;
        int counter_flavor_dck;
        int counter_flavor_atr2;
        int counter_flavor_atr1;
        int counter_flavor_1st;
        int counter_flavor_init;
        int counter_flavor_board_safe;
        int counter_flavor_board;
        int counter_flavor_bomb_safe;
        int counter_flavor_bomb;
        public scnr_01b_spacestation(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.delay_blink = 30 * 3;
            this.delay_dawdle = 30 * 10;
            this.delay_tutorial = 30 * 15;
            this.delay_prompt = 30 * 10;
            this.delay_witness = 30 * 5;
            this.delay_wait = 30 * 10;
            this.delay_late = 30 * 45;
            this.delay_lost = 30 * 60;
            this.mark_bsp0 = false;
            this.mark_bsp1 = false;
            this.mark_bsp2 = false;
            this.mark_bsp3 = false;
            this.mark_bsp4 = false;
            this.mark_bsp5 = false;
            this.gbl_1st_waves = false;
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.seconds = 30;
            this.mark_1st_waves_end = false;
            this.mark_bomb2_objective = false;
            this.mark_1st_blast = false;
            this.timer_flavor = 0;
            this.global_flavor_delay = (short)(20 * this.seconds);
            this.mark_flavor_disable = false;
            this.mark_flavor_vacuum = false;
            this.mark_flavor_brace = false;
            this.mark_flavor_gun = false;
            this.mark_flavor_dck = false;
            this.mark_flavor_trm1 = false;
            this.mark_flavor_atr1 = false;
            this.mark_flavor_bay2 = false;
            this.mark_flavor_bay1 = false;
            this.mark_flavor_atr2 = false;
            this.mark_flavor_1st = false;
            this.mark_flavor_board = false;
            this.mark_flavor_bomb = false;
            this.mark_flavor_init = false;
            this.mark_flavor_megg = false;
            this.mark_flavor_safe_cycle = false;
            this.counter_flavor_brace = 0;
            this.counter_flavor_gun = 0;
            this.counter_flavor_dck = 0;
            this.counter_flavor_atr2 = 0;
            this.counter_flavor_atr1 = 0;
            this.counter_flavor_1st = 0;
            this.counter_flavor_init = 0;
            this.counter_flavor_board_safe = 0;
            this.counter_flavor_board = 0;
            this.counter_flavor_bomb_safe = 0;
            this.counter_flavor_bomb = 0;
        }

#endregion
        [ScriptMethod(0, Lifecycle.Static)]
        public async Task<IUnit> player0()
        {
            return Engine.unit(Engine.list_get(Engine.players(), 0));
        }

        [ScriptMethod(1, Lifecycle.Static)]
        public async Task<IUnit> player1()
        {
            return Engine.unit(Engine.list_get(Engine.players(), 1));
        }

        [ScriptMethod(2, Lifecycle.Static)]
        public async Task<int> player_count()
        {
            return Engine.list_count(Engine.players());
        }

        [ScriptMethod(3, Lifecycle.Static)]
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

        [ScriptMethod(4, Lifecycle.Static)]
        public async Task<bool> difficulty_legendary()
        {
            return Engine.game_difficulty_get() == GameDifficulty.Legendary();
        }

        [ScriptMethod(5, Lifecycle.Static)]
        public async Task<bool> difficulty_heroic()
        {
            return Engine.game_difficulty_get() == GameDifficulty.Heroic();
        }

        [ScriptMethod(6, Lifecycle.Static)]
        public async Task<bool> difficulty_normal()
        {
            return Engine.game_difficulty_get() == GameDifficulty.Normal();
        }

        [ScriptMethod(7, Lifecycle.Static)]
        public async Task<bool> cinematic_skip_start()
        {
            Engine.cinematic_skip_start_internal();
            Engine.game_save_cinematic_skip();
            await Engine.sleep_until(async () => !((bool)Engine.game_saving()), 1);
            return !((bool)Engine.game_reverted());
        }

        [ScriptMethod(8, Lifecycle.Static)]
        public async Task cinematic_skip_stop()
        {
            Engine.cinematic_skip_stop_internal();
            if (!((bool)Engine.game_reverted()))
            {
                Engine.game_revert();
            }
        }

        [ScriptMethod(9, Lifecycle.Static)]
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

        [ScriptMethod(10, Lifecycle.Static)]
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

        [ScriptMethod(11, Lifecycle.Static)]
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

        [ScriptMethod(12, Lifecycle.Static)]
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

        [ScriptMethod(13, Lifecycle.Static)]
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

        [ScriptMethod(14, Lifecycle.Static)]
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

        [ScriptMethod(15, Lifecycle.Static)]
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

        [ScriptMethod(16, Lifecycle.Static)]
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

        [ScriptMethod(17, Lifecycle.Static)]
        public async Task cinematic_stash_players()
        {
            Engine.object_hide(await this.player0(), true);
            Engine.object_hide(await this.player1(), true);
            Engine.object_cannot_take_damage(Engine.players());
        }

        [ScriptMethod(18, Lifecycle.Static)]
        public async Task cinematic_unstash_players()
        {
            Engine.object_hide(await this.player0(), false);
            Engine.object_hide(await this.player1(), false);
            Engine.object_can_take_damage(Engine.players());
        }

        [ScriptMethod(19, Lifecycle.Dormant)]
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

        [ScriptMethod(20, Lifecycle.Dormant)]
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

        [ScriptMethod(21, Lifecycle.Static)]
        public async Task activate_stealth_toggle_monitor()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(22, Lifecycle.Static)]
        public async Task activate_stealth_timer_monitor()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(23, Lifecycle.Static)]
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

        [ScriptMethod(24, Lifecycle.Static)]
        public async Task x02_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x02_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_02_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x02_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_03_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x02_04a_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_04a_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x02_04b_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_04b_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x02_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_05_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x02_06_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_06_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x02_07_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_07_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x02_08_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_08_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x02_09_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_09_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task x02_10_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x02_10_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task _01_outro_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_01_predict));
        }

        [ScriptMethod(36, Lifecycle.Static)]
        public async Task _01_outro_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_02_predict));
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task _01_outro_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_03_predict));
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task _01_outro_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_04_predict));
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task _01_outro_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_05_predict));
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task _01_outro_06_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_06_predict));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task _01_outro_07_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_07_predict));
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task _01_outro_08_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_08_predict));
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task _01_outro_09_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_09_predict));
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task _01_outro_10_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_01_outro_10_predict));
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task x02_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_01_mus", 4058910670U), default(IGameObject), 1F);
            Engine.print("x02 score 01 start");
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task x02_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_01_fol", 4058976207U), default(IGameObject), 1F);
            Engine.print("x02 foley 01 start");
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x02_0010_mas()
        {
            await Engine.sleep(20);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0010_mas", 4059041744U), chief_x02_01.Entity, 1F);
            Engine.cinematic_subtitle("x02_0010_mas", 2F);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task x02_0020_jon()
        {
            await Engine.sleep(80);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0020_jon", 4059107281U), johnson_x02_01.Entity, 1F);
            Engine.cinematic_subtitle("x02_0020_jon", 2.5F);
            Engine.unit_set_emotional_state(johnson_x02_01.Entity, "annoyed", 0.75F, 10);
            Engine.print("johnson - annoyed .75 15");
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task x02_0030_jon()
        {
            await Engine.sleep(181);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0030_jon", 4059172818U), johnson_x02_01.Entity, 1F);
            Engine.cinematic_subtitle("x02_0030_jon", 2.5F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task x02_0040_jon()
        {
            await Engine.sleep(270);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0040_jon", 4059238355U), johnson_x02_01.Entity, 1F);
            Engine.cinematic_subtitle("x02_0040_jon", 2F);
            Engine.unit_set_emotional_state(johnson_x02_01.Entity, "happy", 0.75F, 30);
            Engine.print("johnson - happy .75 30");
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task x02_0050_jon()
        {
            await Engine.sleep(333);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0050_jon", 4059303892U), johnson_x02_01.Entity, 1F);
            Engine.cinematic_subtitle("x02_0050_jon", 2F);
            await Engine.sleep(10);
            Engine.unit_set_emotional_state(johnson_x02_01.Entity, "pensive", 1F, 60);
            Engine.print("johnson - pensive 1 60");
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task x02_01_dof()
        {
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(0.85F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(164);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
            await Engine.sleep(104);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(147);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_01()
        {
            Engine.cinematic_lighting_set_primary_light(67F, 208F, 0.458824F, 0.407843F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(45F, 120F, 0.215686F, 0.207843F, 0.25098F);
            Engine.cinematic_lighting_set_ambient_light(0.0823529F, 0.0823529F, 0.0823529F);
            Engine.object_uses_cinematic_lighting(chief_x02_01.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_x02_01.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_01.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_02.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_03.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_04.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_05.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_06.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_07.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_08.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_door_01.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_door_02.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_hat.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_drone_01.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_drone_02.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task x02_02_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_02);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task x02_hum_crowd_01a()
        {
            Engine.print("first marine crowd");
            Engine.custom_animation_loop(marine_x02_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_whistle_loop", false);
            Engine.custom_animation_loop(marine_x02_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_fist_loop", false);
            Engine.custom_animation_loop(marine_x02_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_clapping_loop", false);
            await Engine.sleep(5);
            Engine.custom_animation_loop(marine_x02_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_clapping_loop", false);
            await Engine.sleep(10);
            Engine.custom_animation_loop(marine_x02_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_clapping_loop", false);
            await Engine.sleep(10);
            Engine.custom_animation_loop(marine_x02_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_whistle_loop", false);
            await Engine.sleep(10);
            Engine.custom_animation_loop(marine_x02_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_clapping_loop", false);
            await Engine.sleep(10);
            Engine.custom_animation_loop(marine_x02_08.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_clapping_loop", false);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task x02_hum_crowd_01b()
        {
            await Engine.sleep(268);
            Engine.print("second marine crowd");
            Engine.object_destroy(marine_x02_01.Entity);
            Engine.object_destroy(marine_x02_02.Entity);
            Engine.object_destroy(marine_x02_03.Entity);
            Engine.object_destroy(marine_x02_04.Entity);
            Engine.object_destroy(marine_x02_05.Entity);
            Engine.object_create_anew(marine_x02_09);
            Engine.object_create_anew(marine_x02_10);
            Engine.object_create_anew(marine_x02_11);
            Engine.object_create_anew(marine_x02_12);
            Engine.object_uses_cinematic_lighting(marine_x02_09.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_10.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_11.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_x02_12.Entity, true);
            Engine.custom_animation_loop(marine_x02_09.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_whistle_loop", false);
            Engine.custom_animation_loop(marine_x02_10.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_fist_loop", false);
            Engine.custom_animation_loop(marine_x02_11.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_clapping_loop", false);
            await Engine.sleep(10);
            Engine.custom_animation_loop(marine_x02_12.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_clapping_loop", false);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task open_bridge_door()
        {
            await Engine.sleep(417);
            Engine.print("open bridge door");
            Engine.device_set_position(x02_bridge_door.Entity, 1F);
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task x02_01_setup()
        {
            Engine.object_destroy_type_mask(2052);
            Engine.object_destroy(offending_light.Entity);
            Engine.object_create_anew(chief_x02_01);
            Engine.object_create_anew(johnson_x02_01);
            Engine.object_create_anew(johnson_hat);
            Engine.object_set_permutation(johnson_x02_01.Entity, "helmet", "");
            Engine.object_create_anew(marine_door_01);
            Engine.object_create_anew(marine_door_02);
            Engine.object_set_permutation(marine_door_01.Entity, "head", "smith");
            Engine.object_set_permutation(marine_door_02.Entity, "head", "perez");
            Engine.object_create_anew(marine_x02_01);
            Engine.object_create_anew(marine_x02_02);
            Engine.object_create_anew(marine_x02_03);
            Engine.object_create_anew(marine_x02_04);
            Engine.object_create_anew(marine_x02_05);
            Engine.object_create_anew(marine_x02_06);
            Engine.object_create_anew(marine_x02_07);
            Engine.object_create_anew(marine_x02_08);
            Engine.object_create_anew(x02_drone_01);
            Engine.object_create_anew(x02_drone_02);
            Engine.object_cinematic_lod(chief_x02_01.Entity, true);
            Engine.object_cinematic_lod(johnson_x02_01.Entity, true);
            Engine.object_cinematic_lod(marine_x02_01.Entity, true);
            Engine.object_cinematic_lod(marine_x02_02.Entity, true);
            Engine.object_cinematic_lod(marine_x02_03.Entity, true);
            Engine.object_cinematic_lod(marine_x02_04.Entity, true);
            Engine.object_cinematic_lod(marine_x02_05.Entity, true);
            Engine.object_cinematic_lod(marine_x02_06.Entity, true);
            Engine.object_cinematic_lod(marine_x02_07.Entity, true);
            Engine.object_cinematic_lod(marine_x02_08.Entity, true);
            Engine.wake(new ScriptMethodReference(x02_score_01));
            Engine.wake(new ScriptMethodReference(x02_foley_01));
            Engine.wake(new ScriptMethodReference(x02_0010_mas));
            Engine.wake(new ScriptMethodReference(x02_0020_jon));
            Engine.wake(new ScriptMethodReference(x02_0030_jon));
            Engine.wake(new ScriptMethodReference(x02_0040_jon));
            Engine.wake(new ScriptMethodReference(x02_0050_jon));
            Engine.wake(new ScriptMethodReference(x02_hum_crowd_01a));
            Engine.wake(new ScriptMethodReference(x02_hum_crowd_01b));
            Engine.wake(new ScriptMethodReference(x02_01_dof));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_01));
            Engine.wake(new ScriptMethodReference(open_bridge_door));
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task x02_01_cleanup()
        {
            Engine.object_destroy(chief_x02_01.Entity);
            Engine.object_destroy(johnson_x02_01.Entity);
            Engine.object_destroy_containing("marine_x02");
            Engine.object_destroy_containing("marine_door");
            Engine.object_destroy_containing("drone");
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task x02_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.x02_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_01_mus", 4058910670U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_01b_fol", 4059500503U));
            await Engine.sleep(this.prediction_offset);
            await this.x02_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_01", default(IUnit), anchor_flag_x02_01);
            Engine.custom_animation_relative(chief_x02_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4059631577U), "chief_01", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(johnson_x02_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "johnson_01", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_door_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine02_01", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_door_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine04_01", false, anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(johnson_hat.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\dress_cap\\x02\\x02", 4059697114U), "dress_cap_01", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_drone_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\news_drone\\x02\\x02", 4059762651U), "news_drone01_01", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_drone_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\news_drone\\x02\\x02", 4059762651U), "news_drone02_01", anchor_x02_01.Entity);
            await Engine.sleep(20);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_01b_fol", 4059500503U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            await this.x02_02_problem_actors();
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.x02_01_cleanup();
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task x02_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_01b_fol", 4059500503U), default(IGameObject), 1F);
            Engine.print("x02 foley 02 start");
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task x02_0070_gch()
        {
            await Engine.sleep(386);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0070_gch", 4059828188U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x02_0070_gch", 2F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task x02_fov_02()
        {
            await Engine.sleep(384);
            Engine.camera_set_field_of_view(30F, 0);
            Engine.print("fov change: 60 -> 30 over 0 ticks");
            await Engine.sleep(71);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 30 -> 60 over 0 ticks");
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_02()
        {
            Engine.cinematic_lighting_set_primary_light(90F, 248F, 0.345098F, 0.286275F, 0.270588F);
            Engine.cinematic_lighting_set_secondary_light(90F, 36F, 0.0784314F, 0.0745098F, 0.0901961F);
            Engine.cinematic_lighting_set_ambient_light(0.0509804F, 0.0509804F, 0.0509804F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_01.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_02.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_03.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_01.Entity, true);
            Engine.object_uses_cinematic_lighting(hammer.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task place_cov_crowd_01a()
        {
            await Engine.sleep(60);
            Engine.print("place crowd 01a");
            Engine.object_create_anew_containing("cov_crowd_01a");
            Engine.object_create_anew(problem_guard);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_02.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_03.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_04.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_05.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_06.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_07.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_08.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_09.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_10.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_11.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_12.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_13.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_14.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_15.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_16.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_17.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_18.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_19.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_20.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_21.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_22.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_23.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_24.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_25.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_26.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_27.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_28.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_29.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_30.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_31.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_32.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01a_33.Entity, true);
            Engine.object_uses_cinematic_lighting(problem_guard.Entity, true);
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task place_cov_crowd_01b()
        {
            await Engine.sleep(249);
            Engine.print("place crowd 01b");
            Engine.object_destroy_containing("cov_crowd_01a");
            Engine.object_destroy(problem_guard.Entity);
            Engine.object_create_anew_containing("cov_crowd_01b");
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_03.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_04.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_05.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_06.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_07.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_08.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_09.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_10.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_11.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_12.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_13.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_14.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_15.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01b_16.Entity, true);
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task place_cov_crowd_01c()
        {
            await Engine.sleep(384);
            Engine.print("place crowd 01c");
            Engine.object_destroy_containing("cov_crowd_01b");
            Engine.object_create_anew_containing("cov_crowd_01c");
            Engine.object_uses_cinematic_lighting(cov_crowd_01c_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01c_02.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01c_03.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01c_04.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01c_05.Entity, true);
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task place_cov_crowd_01d()
        {
            Engine.time_code_reset();
            await Engine.sleep(610);
            Engine.print("place crowd 01d");
            Engine.object_destroy_containing("cov_crowd_01c");
            Engine.object_create_anew_containing("cov_crowd_01d");
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_02.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_03.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_04.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_05.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_06.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_07.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_08.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_09.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_10.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_11.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_12.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_13.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_14.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_15.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_16.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_17.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_18.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_19.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_20.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_01d_21.Entity, true);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task place_cov_crowd_distant()
        {
            await Engine.sleep(456);
            Engine.print("place crowd distant");
            Engine.object_create_anew_containing("x02_crowd_distant");
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task activate_manacles()
        {
            await Engine.sleep(666);
            Engine.print("activate manacle");
            Engine.object_set_function_variable(x02_manacle_01.Entity, "manacle_on", 0F, 1F);
            await Engine.sleep(20);
            Engine.object_set_function_variable(x02_manacle_02.Entity, "manacle_on", 0F, 1F);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task create_columns()
        {
            Engine.object_create_anew(x02_column_01);
            Engine.object_create_anew(x02_column_06);
            await Engine.sleep(30);
            Engine.object_create_anew(x02_column_02);
            Engine.object_create_anew(x02_column_05);
            await Engine.sleep(30);
            Engine.object_create_anew(x02_column_03);
            Engine.object_create_anew(x02_column_04);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task x02_02_setup()
        {
            Engine.object_create_anew(grunt_01);
            Engine.object_create_anew(grunt_02);
            Engine.object_create_anew(grunt_03);
            Engine.object_create_anew(jackal_01);
            Engine.object_create_anew(hammer);
            Engine.object_create_anew_containing("x02_manacle");
            Engine.object_cinematic_lod(grunt_01.Entity, true);
            Engine.object_cinematic_lod(grunt_02.Entity, true);
            Engine.object_cinematic_lod(grunt_03.Entity, true);
            Engine.object_cinematic_lod(jackal_01.Entity, true);
            Engine.object_cinematic_lod(hammer.Entity, true);
            Engine.wake(new ScriptMethodReference(x02_foley_02));
            Engine.wake(new ScriptMethodReference(x02_0070_gch));
            Engine.wake(new ScriptMethodReference(x02_fov_02));
            Engine.wake(new ScriptMethodReference(place_cov_crowd_01a));
            Engine.wake(new ScriptMethodReference(place_cov_crowd_01b));
            Engine.wake(new ScriptMethodReference(place_cov_crowd_01c));
            Engine.wake(new ScriptMethodReference(place_cov_crowd_01d));
            Engine.wake(new ScriptMethodReference(place_cov_crowd_distant));
            Engine.wake(new ScriptMethodReference(create_columns));
            Engine.wake(new ScriptMethodReference(activate_manacles));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_02));
            Engine.device_set_position(x02_door_02.Entity, 1F);
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task x02_02_cleanup()
        {
            Engine.object_destroy(brute_01.Entity);
            Engine.object_destroy(brute_02.Entity);
            Engine.object_destroy(grunt_01.Entity);
            Engine.object_destroy(grunt_02.Entity);
            Engine.object_destroy(grunt_03.Entity);
            Engine.object_destroy(jackal_01.Entity);
            Engine.object_destroy(hammer.Entity);
            Engine.object_destroy_containing("cov_crowd_01");
            Engine.object_destroy_containing("crowd_distant");
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task x02_scene_02()
        {
            await this.x02_02_predict_stub();
            await this.x02_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_02", default(IUnit), anchor_flag_x02_02);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x02\\x02", 4059893725U), "dervish_02", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4060024799U), "tartarus_02", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4060024799U), "brute01_02", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4060024799U), "brute02_02", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(grunt_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4060155873U), "grunt01_02", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(grunt_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4060155873U), "grunt02_02", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(grunt_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4060155873U), "grunt03_02", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(jackal_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x02\\x02", 4060221410U), "jackal01_02", false, anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x02\\x02", 4060286947U), "hammer_02", anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_manacle_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4060352484U), "manacle1_02", anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_manacle_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4060352484U), "manacle2_02", anchor_x02_02.Entity);
            await Engine.sleep(30);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x02_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_02_fol", 4060418021U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x02_02_cleanup();
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x02_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_02_fol", 4060418021U), default(IGameObject), 1F);
            Engine.print("x02 foley 03 start");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x02_0090_tar()
        {
            await Engine.sleep(40);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0090_tar", 4060483558U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x02_0090_tar", 2F);
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x02_0100_der()
        {
            await Engine.sleep(106);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0100_der", 4060549095U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x02_0100_der", 3.5F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x02_0110_tar()
        {
            await Engine.sleep(213);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0110_tar", 4060614632U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x02_0110_tar", 1.5F);
            Engine.unit_set_emotional_state(tartarus.Entity, "inquisitive", 1F, 60);
            Engine.print("tartarus - inquisitive 1 60");
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task effect_beam_01_start()
        {
            await Engine.sleep(297);
            Engine.print("effect - beam 01 start");
            Engine.object_create(beam_start_01);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task effect_beams()
        {
            await Engine.sleep(378);
            Engine.print("effect - beam 01");
            Engine.object_create(beam_01);
            await Engine.sleep(69);
            Engine.print("effect - beam 02");
            Engine.object_create(beam_02);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task place_cov_crowd_02()
        {
            await Engine.sleep(480);
            Engine.print("place crowd 02");
            Engine.object_create_anew_containing("cov_crowd_02");
            Engine.object_uses_cinematic_lighting(cov_crowd_02_01.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_02.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_03.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_04.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_05.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_06.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_07.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_08.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_09.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_10.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_11.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_12.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_13.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_14.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_15.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_16.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_17.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_18.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_crowd_02_19.Entity, true);
        }

        [ScriptMethod(82, Lifecycle.Static)]
        public async Task x02_03_setup()
        {
            Engine.wake(new ScriptMethodReference(x02_foley_03));
            Engine.wake(new ScriptMethodReference(x02_0090_tar));
            Engine.wake(new ScriptMethodReference(x02_0100_der));
            Engine.wake(new ScriptMethodReference(x02_0110_tar));
            Engine.wake(new ScriptMethodReference(effect_beam_01_start));
            Engine.wake(new ScriptMethodReference(effect_beams));
            Engine.wake(new ScriptMethodReference(place_cov_crowd_02));
        }

        [ScriptMethod(83, Lifecycle.Static)]
        public async Task x02_scene_03_cleanup()
        {
            Engine.object_destroy_containing("beam");
            Engine.object_destroy_containing("cov_crowd_02");
        }

        [ScriptMethod(84, Lifecycle.Static)]
        public async Task x02_scene_03()
        {
            await this.x02_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_03", default(IUnit), anchor_flag_x02_02);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x02\\x02", 4059893725U), "dervish_03", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4060024799U), "tartarus_03", false, anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_manacle_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4060352484U), "manacle1_03", anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_manacle_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4060352484U), "manacle2_03", anchor_x02_02.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_03_fol", 4060680169U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.x02_scene_03_cleanup();
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x02_foley_04a()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_03_fol", 4060680169U), default(IGameObject), 1F);
            Engine.print("x02 foley 04a start");
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task x02_0140_lhd()
        {
            await Engine.sleep(300);
            Engine.unit_set_emotional_state(hood_x02.Entity, "happy", 0.25F, 30);
            Engine.print("hood - happy .25 30");
            await Engine.sleep(41);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0140_lhd", 4060745706U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0140_lhd", 2F);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task marine_whisper()
        {
            await Engine.sleep(413);
            Engine.print("marine whisper");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\earthcity\\whisper", 4060811243U), marine_01.Entity, 1F);
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x02_0150_lhd()
        {
            await Engine.sleep(430);
            Engine.unit_set_emotional_state(hood_x02.Entity, "angry", 0.25F, 60);
            Engine.print("hood - angry .25 60");
            await Engine.sleep(50);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0150_lhd", 4060876780U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0150_lhd", 1.5F);
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x02_0160_cor()
        {
            Engine.unit_set_emotional_state(cortana_x02.Entity, "angry", 0.15F, 0);
            Engine.print("cortana - angry .15 0");
            await Engine.sleep(524);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0160_cor", 4060942317U), cortana_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0160_cor", 3F);
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task effect_cortana_on()
        {
            await Engine.sleep(521);
            Engine.print("cortana_on");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4061007854U), x02_cortana_stand.Entity, "holo_effect");
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_04a()
        {
            Engine.cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            Engine.cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            Engine.object_uses_cinematic_lighting(chief_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(hood_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(cortana_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_01.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_02.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_03.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_04.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_plant_01.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_plant_02.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_plant_03.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_plant_04.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_plant_05.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_plant_06.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_plant_07.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_cortana_stand.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_medal_tray.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x02_marine_crowd_01()
        {
            await Engine.sleep(0);
            Engine.print("create marine crowd 02");
            Engine.object_create_anew_containing("x02_marine_prop_01a");
            await Engine.sleep(10);
            Engine.object_create_anew_containing("x02_marine_prop_01b");
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_01.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01b_02.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_03.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01b_04.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_05.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_06.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_07.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01b_08.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_09.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01b_10.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_11.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01b_12.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_13.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01b_14.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01a_15.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_01b_16.Entity, true);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x02_marine_crowd_02()
        {
            await Engine.sleep(0);
            Engine.print("create marine crowd 02");
            Engine.object_create_anew_containing("x02_marine_prop_02a");
            await Engine.sleep(5);
            Engine.object_create_anew_containing("x02_marine_prop_02b");
            await Engine.sleep(10);
            Engine.object_create_anew_containing("x02_marine_prop_02c");
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_01.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_02.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_03.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_05.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_06.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_07.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_08.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_09.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_10.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_11.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_12.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_13.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_14.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_16.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_17.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_18.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_19.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_20.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_21.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_22.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_23.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_24.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_25.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_26.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_27.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_28.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_29.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02a_30.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02b_31.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_02c_32.Entity, true);
        }

        [ScriptMethod(94, Lifecycle.Static)]
        public async Task x02_04a_setup()
        {
            Engine.object_create_anew(chief_x02);
            Engine.object_create_anew(hood_x02);
            Engine.object_create_anew(cortana_x02);
            Engine.object_create_anew(miranda_x02);
            Engine.object_create_anew(johnson_x02);
            Engine.object_create_anew(marine_01);
            Engine.object_create_anew(marine_02);
            Engine.object_create_anew(marine_03);
            Engine.object_create_anew(marine_04);
            Engine.object_create_anew(marine_plant_01);
            Engine.object_create_anew(marine_plant_02);
            Engine.object_create_anew(marine_plant_03);
            Engine.object_create_anew(marine_plant_04);
            Engine.object_create_anew(marine_plant_05);
            Engine.object_create_anew(marine_plant_06);
            Engine.object_create_anew(marine_plant_07);
            Engine.object_set_permutation(marine_01.Entity, "head", "perez");
            Engine.object_set_permutation(marine_02.Entity, "head", "smith");
            Engine.object_set_permutation(marine_03.Entity, "head", "walter");
            Engine.object_set_permutation(marine_04.Entity, "head", "dion");
            Engine.object_create_anew(x02_cortana_stand);
            Engine.object_create_anew(x02_medal_tray);
            Engine.object_create_anew(x02_unsc_logo);
            Engine.object_cinematic_lod(chief_x02.Entity, true);
            Engine.object_cinematic_lod(hood_x02.Entity, true);
            Engine.object_cinematic_lod(cortana_x02.Entity, true);
            Engine.object_cinematic_lod(miranda_x02.Entity, true);
            Engine.object_cinematic_lod(johnson_x02.Entity, true);
            Engine.object_cinematic_lod(marine_01.Entity, true);
            Engine.object_cinematic_lod(marine_02.Entity, true);
            Engine.object_cinematic_lod(marine_03.Entity, true);
            Engine.object_cinematic_lod(marine_04.Entity, true);
            Engine.object_cinematic_lod(marine_plant_01.Entity, true);
            Engine.object_cinematic_lod(marine_plant_02.Entity, true);
            Engine.object_cinematic_lod(marine_plant_03.Entity, true);
            Engine.object_cinematic_lod(marine_plant_04.Entity, true);
            Engine.object_cinematic_lod(marine_plant_05.Entity, true);
            Engine.object_cinematic_lod(marine_plant_06.Entity, true);
            Engine.object_cinematic_lod(marine_plant_07.Entity, true);
            Engine.wake(new ScriptMethodReference(x02_foley_04a));
            Engine.wake(new ScriptMethodReference(x02_0140_lhd));
            Engine.wake(new ScriptMethodReference(marine_whisper));
            Engine.wake(new ScriptMethodReference(x02_0150_lhd));
            Engine.wake(new ScriptMethodReference(x02_0160_cor));
            Engine.wake(new ScriptMethodReference(x02_marine_crowd_01));
            Engine.wake(new ScriptMethodReference(x02_marine_crowd_02));
            Engine.wake(new ScriptMethodReference(effect_cortana_on));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_04a));
        }

        [ScriptMethod(95, Lifecycle.Static)]
        public async Task x02_scene_04a_cleanup()
        {
            Engine.object_destroy(marine_05.Entity);
            Engine.object_destroy(marine_06.Entity);
            Engine.object_destroy(marine_07.Entity);
            Engine.object_destroy(marine_08.Entity);
            Engine.object_destroy_containing("x02_marine_prop_01");
            Engine.object_destroy_containing("x02_marine_prop_02");
            Engine.object_destroy_containing("marine_plant");
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task x02_scene_04a()
        {
            Engine.cinematic_lightmap_shadow_enable();
            await this.x02_04a_predict_stub();
            await this.x02_04a_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_04a", default(IUnit), anchor_flag_x02_01);
            Engine.custom_animation_relative(chief_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4059631577U), "chief_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(johnson_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "johnson_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(hood_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4061794298U), "hood_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(miranda_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x02\\x02", 4061925372U), "miranda_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(cortana_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x02\\x02", 4061990909U), "cortana_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine01_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine02_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine03_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine04_04a", false, anchor_x02_01.Entity);
            Engine.custom_animation_loop(marine_plant_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_whistle_loop", false);
            Engine.custom_animation_loop(marine_plant_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_fist_loop", false);
            Engine.custom_animation_loop(marine_plant_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_clapping_loop", false);
            Engine.custom_animation_loop(marine_plant_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_whistle_loop", false);
            Engine.custom_animation_loop(marine_plant_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_whistle_loop", false);
            Engine.custom_animation_loop(marine_plant_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_whistle_loop", false);
            Engine.custom_animation_loop(marine_plant_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine_fist_loop", false);
            Engine.scenery_animation_start_relative(x02_cortana_stand.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4062056446U), "cortana_stand_04a", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_medal_tray.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\medal_tray\\x02\\x02", 4062121983U), "medal_tray_04a", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_unsc_logo.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\x02\\x02", 4062187520U), "unsc_logo_04a", anchor_x02_01.Entity);
            await Engine.sleep(30);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x02_04b_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_04_fol", 4062253057U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x02_scene_04a_cleanup();
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x02_foley_04b()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_04_fol", 4062253057U), default(IGameObject), 1F);
            Engine.print("x02 foley 04b start");
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x02_0170_lhd()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0170_lhd", 4062318594U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0170_lhd", 3F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x02_0180_cor()
        {
            await Engine.sleep(10);
            Engine.unit_set_emotional_state(cortana_x02.Entity, "angry", 0.25F, 0);
            await Engine.sleep(117);
            Engine.unit_set_emotional_state(cortana_x02.Entity, "happy", 0.25F, 60);
            Engine.print("cortana - happy .15 60");
            await Engine.sleep(30);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0180_cor", 4062384131U), cortana_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0180_cor", 1F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x02_0190_mas()
        {
            await Engine.sleep(194);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0190_mas", 4062449668U), chief_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0190_mas", 1F);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task x02_0200_jon()
        {
            await Engine.sleep(189);
            Engine.unit_set_emotional_state(johnson_x02.Entity, "arrogant", 1F, 0);
            Engine.print("johnson - amorous 1 0");
            await Engine.sleep(5);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0200_jon", 4062515205U), johnson_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0200_jon", 1F);
            await Engine.sleep(30);
            Engine.unit_set_emotional_state(johnson_x02.Entity, "annoyed", 0.5F, 30);
            Engine.print("johnson - annoyed .5 30");
            await Engine.sleep(40);
            Engine.unit_set_emotional_state(johnson_x02.Entity, "pensive", 1F, 5);
            Engine.print("johnson - pensive 1 5");
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task x02_0210_lhd()
        {
            await Engine.sleep(255);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0210_lhd", 4062580742U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0210_lhd", 1F);
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x02_0220_lhd()
        {
            await Engine.sleep(293);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0220_lhd", 4062646279U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0220_lhd", 5F);
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task x02_0230_lhd()
        {
            await Engine.sleep(435);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0230_lhd", 4062711816U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0230_lhd", 3F);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_04b()
        {
            Engine.cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            Engine.cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            Engine.object_uses_cinematic_lighting(medal_01.Entity, true);
            Engine.object_uses_cinematic_lighting(medal_02.Entity, true);
            Engine.object_uses_cinematic_lighting(medal_03.Entity, true);
        }

        [ScriptMethod(106, Lifecycle.Static)]
        public async Task x02_04b_setup()
        {
            Engine.object_create_anew_containing("medal");
            Engine.cinematic_set_near_clip_distance(0.043F);
            Engine.print("setting near clip distance to .043");
            Engine.wake(new ScriptMethodReference(x02_foley_04b));
            Engine.wake(new ScriptMethodReference(x02_0170_lhd));
            Engine.wake(new ScriptMethodReference(x02_0180_cor));
            Engine.wake(new ScriptMethodReference(x02_0190_mas));
            Engine.wake(new ScriptMethodReference(x02_0200_jon));
            Engine.wake(new ScriptMethodReference(x02_0210_lhd));
            Engine.wake(new ScriptMethodReference(x02_0220_lhd));
            Engine.wake(new ScriptMethodReference(x02_0230_lhd));
        }

        [ScriptMethod(107, Lifecycle.Static)]
        public async Task x02_scene_04b()
        {
            await this.x02_04b_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_04b", default(IUnit), anchor_flag_x02_01);
            Engine.custom_animation_relative(chief_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4059631577U), "chief_04b", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(johnson_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "johnson_04b", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(hood_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4061794298U), "hood_04b", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(cortana_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x02\\x02", 4061990909U), "cortana_04b", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine01_04b", false, anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_cortana_stand.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4062056446U), "cortana_stand_04b", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_medal_tray.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\medal_tray\\x02\\x02", 4062121983U), "medal_tray_04b", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(medal_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\colonial_cross\\x02\\x02", 4062777353U), "cross1_04b", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(medal_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\colonial_cross\\x02\\x02", 4062777353U), "cross2_04b", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(medal_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\colonial_cross\\x02\\x02", 4062777353U), "cross3_04b", anchor_x02_01.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_05_mus", 4062842890U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_05_fol", 4062908427U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task x02_score_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_05_mus", 4062842890U), default(IGameObject), 1F);
            Engine.print("x02 score 05 start");
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task x02_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_05_fol", 4062908427U), default(IGameObject), 1F);
            Engine.print("x02 foley 05 start");
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x02_0240_tar()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0240_tar", 4062973964U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x02_0240_tar", 3F);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x02_0250_tar()
        {
            await Engine.sleep(88);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0250_tar", 4063039501U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x02_0250_tar", 3F);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x02_0270_tar()
        {
            await Engine.sleep(245);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0270_tar", 4063105038U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x02_0270_tar", 2F);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\02\\charred_smoke_medium", 4063170575U), dervish.Entity, "head");
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task effect_body_smoke()
        {
            await Engine.sleep(0);
            Engine.print("effect - body smoke");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\02\\charred_smoke_medium", 4063170575U), dervish.Entity, "head");
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_05()
        {
            Engine.cinematic_lighting_set_primary_light(90F, 248F, 0.345098F, 0.286275F, 0.270588F);
            Engine.cinematic_lighting_set_secondary_light(90F, 36F, 0.0784314F, 0.0745098F, 0.0901961F);
            Engine.cinematic_lighting_set_ambient_light(0.0509804F, 0.0509804F, 0.0509804F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_01.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_02.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_03.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_01.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_02.Entity, true);
            Engine.object_uses_cinematic_lighting(hunter_01.Entity, true);
            Engine.object_uses_cinematic_lighting(hunter_02.Entity, true);
            Engine.object_uses_cinematic_lighting(hunter_03.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task x02_05_setup()
        {
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_02);
            Engine.object_create_anew(grunt_01);
            Engine.object_create_anew(grunt_02);
            Engine.object_create_anew(grunt_03);
            Engine.object_create_anew(jackal_01);
            Engine.object_create_anew(jackal_02);
            Engine.object_create_anew(hunter_01);
            Engine.object_create_anew(hunter_02);
            Engine.object_create_anew(hunter_03);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
            Engine.object_cinematic_lod(grunt_01.Entity, true);
            Engine.object_cinematic_lod(grunt_02.Entity, true);
            Engine.object_cinematic_lod(grunt_03.Entity, true);
            Engine.object_cinematic_lod(jackal_01.Entity, true);
            Engine.object_cinematic_lod(jackal_02.Entity, true);
            Engine.object_cinematic_lod(hunter_01.Entity, true);
            Engine.object_cinematic_lod(hunter_02.Entity, true);
            Engine.object_cinematic_lod(hunter_03.Entity, true);
            Engine.object_set_function_variable(dervish.Entity, "elite_burnt", 0F, 0F);
            Engine.cinematic_set_near_clip_distance(0.06F);
            Engine.print("resetting near clip distance to .06");
            Engine.wake(new ScriptMethodReference(x02_score_05));
            Engine.wake(new ScriptMethodReference(x02_foley_05));
            Engine.wake(new ScriptMethodReference(x02_0240_tar));
            Engine.wake(new ScriptMethodReference(x02_0250_tar));
            Engine.wake(new ScriptMethodReference(x02_0270_tar));
            Engine.wake(new ScriptMethodReference(effect_body_smoke));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_05));
        }

        [ScriptMethod(116, Lifecycle.Static)]
        public async Task x02_05_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(brute_01.Entity);
            Engine.object_destroy(brute_02.Entity);
            Engine.object_destroy(grunt_01.Entity);
            Engine.object_destroy(grunt_02.Entity);
            Engine.object_destroy(grunt_03.Entity);
            Engine.object_destroy(jackal_01.Entity);
            Engine.object_destroy(jackal_02.Entity);
            Engine.object_destroy(hunter_01.Entity);
            Engine.object_destroy(hunter_02.Entity);
            Engine.object_destroy(hunter_03.Entity);
        }

        [ScriptMethod(117, Lifecycle.Static)]
        public async Task x02_scene_05()
        {
            Engine.cinematic_lightmap_shadow_disable();
            await this.x02_05_predict_stub();
            await this.x02_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_05", default(IUnit), anchor_flag_x02_02);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x02\\x02", 4059893725U), "dervish_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4060024799U), "tartarus_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4060024799U), "brute01_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4060024799U), "brute02_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(grunt_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4060155873U), "grunt01_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(grunt_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4060155873U), "grunt02_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(grunt_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4060155873U), "grunt03_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(jackal_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x02\\x02", 4060221410U), "jackal01_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(jackal_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x02\\x02", 4060221410U), "jackal02_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(hunter_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\hunter\\x02\\x02", 4063432723U), "hunter01_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(hunter_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\hunter\\x02\\x02", 4063432723U), "hunter02_05", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(hunter_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\hunter\\x02\\x02", 4063432723U), "hunter03_05", false, anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_manacle_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4060352484U), "manacle1_05", anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_manacle_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4060352484U), "manacle2_05", anchor_x02_02.Entity);
            await Engine.sleep(30);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_06_fol", 4063498260U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.x02_05_cleanup();
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task x02_foley_06()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_06_fol", 4063498260U), default(IGameObject), 1F);
            Engine.print("x02 foley 06 start");
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x02_0280_lhd()
        {
            await Engine.sleep(165);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0280_lhd", 4063563797U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0280_lhd", 2F);
            Engine.unit_set_emotional_state(miranda_x02.Entity, "pensive", 0.25F, 0);
            Engine.print("miranda - pensive .25 0");
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task x02_0290_lhd()
        {
            await Engine.sleep(217);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0290_lhd", 4063629334U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0290_lhd", 4.5F);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task x02_0300_lhd()
        {
            await Engine.sleep(356);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0300_lhd", 4063694871U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0300_lhd", 6.5F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task x02_0310_lhd()
        {
            await Engine.sleep(556);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0310_lhd", 4063760408U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0310_lhd", 2.5F);
            Engine.unit_set_emotional_state(miranda_x02.Entity, "shocked", 0.25F, 60);
            Engine.print("miranda - shocked .25 60");
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_06()
        {
            Engine.cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            Engine.cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            Engine.object_uses_cinematic_lighting(chief_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(hood_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(cortana_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_01.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_02.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_03.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_04.Entity, true);
            Engine.object_uses_cinematic_lighting(medal_01.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x02_marine_crowd_03()
        {
            await Engine.sleep(0);
            Engine.print("create marine crowd 02");
            Engine.object_create_anew_containing("x02_marine_prop_03");
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_01.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_02.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_03.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_04.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_05.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_06.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_07.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_08.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_09.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_10.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_11.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_12.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_13.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_14.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_16.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_17.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_18.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_19.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_20.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_21.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_22.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_23.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_24.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_25.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_26.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_27.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_28.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_29.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_30.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_31.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_32.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_33.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_34.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_marine_prop_03_35.Entity, true);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task x02_06_setup()
        {
            Engine.object_create_anew(chief_x02);
            Engine.object_create_anew(hood_x02);
            Engine.object_create_anew(cortana_x02);
            Engine.object_create_anew(miranda_x02);
            Engine.object_create_anew(johnson_x02);
            Engine.object_create_anew(marine_01);
            Engine.object_create_anew(marine_02);
            Engine.object_create_anew(marine_03);
            Engine.object_create_anew(marine_04);
            Engine.object_create_anew(medal_01);
            Engine.object_cinematic_lod(chief_x02.Entity, true);
            Engine.object_cinematic_lod(hood_x02.Entity, true);
            Engine.object_cinematic_lod(cortana_x02.Entity, true);
            Engine.object_cinematic_lod(miranda_x02.Entity, true);
            Engine.object_cinematic_lod(johnson_x02.Entity, true);
            Engine.object_cinematic_lod(marine_01.Entity, true);
            Engine.object_cinematic_lod(marine_02.Entity, true);
            Engine.object_cinematic_lod(marine_03.Entity, true);
            Engine.object_cinematic_lod(marine_04.Entity, true);
            Engine.object_cinematic_lod(medal_01.Entity, true);
            Engine.object_set_permutation(marine_01.Entity, "head", "perez");
            Engine.object_set_permutation(marine_02.Entity, "head", "smith");
            Engine.object_set_permutation(marine_03.Entity, "head", "walter");
            Engine.object_set_permutation(marine_04.Entity, "head", "dion");
            Engine.wake(new ScriptMethodReference(x02_marine_crowd_03));
            Engine.wake(new ScriptMethodReference(x02_foley_06));
            Engine.wake(new ScriptMethodReference(x02_0280_lhd));
            Engine.wake(new ScriptMethodReference(x02_0290_lhd));
            Engine.wake(new ScriptMethodReference(x02_0300_lhd));
            Engine.wake(new ScriptMethodReference(x02_0310_lhd));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_06));
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task x02_06_cleanup()
        {
            Engine.object_hide(marine_01.Entity, true);
            Engine.object_destroy_containing("medal");
            Engine.object_destroy_containing("x02_marine_prop_03");
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x02_scene_06()
        {
            Engine.cinematic_lightmap_shadow_enable();
            await this.x02_06_predict_stub();
            await this.x02_06_setup();
            Engine.disable_render_light_suppressor();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_06", default(IUnit), anchor_flag_x02_01);
            Engine.custom_animation_relative(chief_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4059631577U), "chief_06", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(johnson_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "johnson_06", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(hood_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4061794298U), "hood_06", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(miranda_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x02\\x02", 4061925372U), "miranda_06", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(cortana_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x02\\x02", 4061990909U), "cortana_06", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine01_06", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine02_06", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine03_06", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine04_06", false, anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_cortana_stand.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4062056446U), "cortana_stand_06", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_medal_tray.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\medal_tray\\x02\\x02", 4062121983U), "medal_tray_06", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(medal_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\colonial_cross\\x02\\x02", 4062777353U), "cross1_06", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_unsc_logo.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\x02\\x02", 4062187520U), "unsc_logo_06", anchor_x02_01.Entity);
            await Engine.sleep(30);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_08_mus", 4063825945U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_07_fol", 4063891482U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.enable_render_light_suppressor();
            await this.x02_06_cleanup();
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task x02_score_08()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_08_mus", 4063825945U), default(IGameObject), 1F);
            Engine.print("x02 score 08 start");
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task x02_foley_07()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_07_fol", 4063891482U), default(IGameObject), 1F);
            Engine.print("x02 foley 07 start");
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task x02_0320_der()
        {
            await Engine.sleep(540);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0320_der", 4063957019U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x02_0320_der", 4F);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task x02_07_dof_01()
        {
            await Engine.sleep(80);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1.5F, 1F, 1F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(70);
            Engine.cinematic_screen_effect_set_depth_of_field(1.5F, 1F, 0F, 0.5F, 0F, 1F, 0.5F);
            Engine.print("rack focus");
            await Engine.sleep(80);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task effect_helmet_smoke()
        {
            await Engine.sleep(0);
            Engine.print("effect - helmet smoke");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\02\\charred_smoke_small", 4064022556U), x02_elite_helmet.Entity, "head");
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task effect_brand()
        {
            await Engine.sleep(425);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\cinematics\\branding_iron\\branding_iron_burn", 4064088093U), branding_iron_02.Entity, "smoke");
            Engine.print("ouch");
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_07()
        {
            Engine.cinematic_lighting_set_primary_light(90F, 248F, 0.345098F, 0.286275F, 0.270588F);
            Engine.cinematic_lighting_set_secondary_light(90F, 36F, 0.0784314F, 0.0745098F, 0.0901961F);
            Engine.cinematic_lighting_set_ambient_light(0.0509804F, 0.0509804F, 0.0509804F);
            Engine.object_uses_cinematic_lighting(dervish_nude.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(x02_elite_helmet.Entity, true);
            Engine.object_uses_cinematic_lighting(branding_iron_01.Entity, true);
            Engine.object_uses_cinematic_lighting(branding_iron_02.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task backup_brand()
        {
            await Engine.sleep(231);
            Engine.scenery_animation_start_relative(branding_iron_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\branding_iron\\x02\\x02", 4064219167U), "branding_iron01_07", anchor_x02_02.Entity);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task bring_back_brand()
        {
            await Engine.sleep(90);
            Engine.object_hide(branding_iron_02.Entity, false);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task delete_brand()
        {
            await Engine.sleep(363);
            Engine.print("destroy branding-iron");
            Engine.object_destroy(branding_iron_01.Entity);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task emotion_tartarus_07()
        {
            await Engine.sleep(180);
            Engine.unit_set_emotional_state(tartarus.Entity, "pensive", 1F, 0);
            Engine.print("tartarus - pensive 1 0");
            await Engine.sleep(63);
            Engine.unit_set_emotional_state(tartarus.Entity, "amorous", 1F, 30);
            Engine.print("tartaurs - amorous 1 30");
        }

        [ScriptMethod(139, Lifecycle.Static)]
        public async Task x02_07_setup()
        {
            Engine.object_create_anew(dervish_nude);
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(x02_elite_helmet);
            Engine.object_create_anew(branding_iron_01);
            Engine.object_create_anew(branding_iron_02);
            Engine.object_create_anew_containing("cov_crowd_02");
            Engine.wake(new ScriptMethodReference(delete_brand));
            Engine.object_cinematic_lod(dervish_nude.Entity, true);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(branding_iron_01.Entity, true);
            Engine.object_cinematic_lod(branding_iron_02.Entity, true);
            Engine.wake(new ScriptMethodReference(x02_foley_07));
            Engine.wake(new ScriptMethodReference(x02_0320_der));
            Engine.wake(new ScriptMethodReference(effect_helmet_smoke));
            Engine.wake(new ScriptMethodReference(backup_brand));
            Engine.wake(new ScriptMethodReference(effect_brand));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_07));
            Engine.wake(new ScriptMethodReference(emotion_tartarus_07));
        }

        [ScriptMethod(140, Lifecycle.Static)]
        public async Task x02_07_cleanup()
        {
            Engine.object_destroy(dervish_nude.Entity);
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy_containing("cov_crowd_02");
            Engine.object_destroy(x02_elite_helmet.Entity);
            Engine.object_destroy_containing("branding");
            Engine.object_destroy_containing("x02_column");
            Engine.object_destroy_containing("x02_manacle");
            Engine.object_destroy_containing("x02_dervish_lift");
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task x02_scene_07()
        {
            Engine.cinematic_lightmap_shadow_disable();
            await this.x02_07_predict_stub();
            await this.x02_07_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_07", default(IUnit), anchor_flag_x02_02);
            Engine.custom_animation_relative(dervish_nude.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x02_alt\\x02_alt", 4064284704U), "dervish_07", false, anchor_x02_02.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4060024799U), "tartarus_07", false, anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_elite_helmet.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\elite_helmet_charred\\elite_helmet_charred", 4064415778U), "helmet_charred_07", anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(branding_iron_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\branding_iron\\x02\\x02", 4064219167U), "branding_iron02_07", anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_manacle_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4060352484U), "manacle1_07", anchor_x02_02.Entity);
            Engine.scenery_animation_start_relative(x02_manacle_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4060352484U), "manacle2_07", anchor_x02_02.Entity);
            Engine.object_hide(branding_iron_02.Entity, true);
            Engine.wake(new ScriptMethodReference(bring_back_brand));
            await Engine.sleep(5);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_08_fol", 4064481315U));
            Engine.wake(new ScriptMethodReference(x02_score_08));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.x02_07_cleanup();
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task x02_foley_08()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_08_fol", 4064481315U), default(IGameObject), 1F);
            Engine.print("x02 foley 08 start");
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task x02_0330_cor()
        {
            await Engine.sleep(1);
            Engine.unit_set_emotional_state(hood_x02.Entity, "shocked", 0.25F, 0);
            Engine.unit_set_emotional_state(cortana_x02.Entity, "angry", 0.5F, 0);
            await Engine.sleep(71);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0330_cor", 4064546852U), cortana_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0330_cor", 3F);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task x02_0340_lhd()
        {
            Engine.unit_set_emotional_state(hood_x02.Entity, "angry", 0.5F, 15);
            Engine.print("hood - angry .5 15");
            await Engine.sleep(150);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0340_lhd", 4064612389U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0340_lhd", 1F);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task x02_0350_cor()
        {
            await Engine.sleep(180);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0350_cor", 4064677926U), cortana_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0350_cor", 4F);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task x02_0360_ahp()
        {
            await Engine.sleep(311);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0360_ahp", 4064743463U), default(IGameObject), 1F, "radio_default");
            Engine.cinematic_subtitle("x02_0360_ahp", 3F);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task x02_0370_lhd()
        {
            Engine.unit_set_emotional_state(hood_x02.Entity, "pensive", 0.5F, 15);
            Engine.print("hood - pensive .5 15");
            Engine.unit_set_emotional_state(miranda_x02.Entity, "shocked", 0.15F, 0);
            await Engine.sleep(415);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0370_lhd", 4064809000U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0370_lhd", 4F);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task x02_0380_lhd()
        {
            await Engine.sleep(548);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0380_lhd", 4064874537U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0380_lhd", 2.5F);
            await Engine.sleep(75);
            Engine.unit_set_emotional_state(miranda_x02.Entity, "angry", 0.5F, 15);
            Engine.print("miranda - angry .5 15");
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task x02_0390_mir()
        {
            await Engine.sleep(632);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0390_mir", 4064940074U), miranda_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0390_mir", 1F);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task x02_0400_lhd()
        {
            await Engine.sleep(676);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0400_lhd", 4065005611U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0400_lhd", 4F);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task x02_0405_cor()
        {
            await Engine.sleep(793);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0405_cor", 4065071148U), cortana_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0405_cor", 1F);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task x02_0410_lhd()
        {
            await Engine.sleep(825);
            Engine.unit_set_emotional_state(hood_x02.Entity, "annoyed", 0.75F, 60);
            Engine.print("hood - annoyed .75 60");
            await Engine.sleep(30);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0410_lhd", 4065136685U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0410_lhd", 5F);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task effect_cortana_off()
        {
            await Engine.sleep(809);
            Engine.print("cortana off");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4061007854U), x02_cortana_stand.Entity, "holo_effect");
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_08()
        {
            Engine.cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            Engine.cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            Engine.object_uses_cinematic_lighting(chief_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(hood_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(cortana_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_02.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_03.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_04.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(155, Lifecycle.Static)]
        public async Task x02_08_setup()
        {
            Engine.object_create(chief_x02);
            Engine.object_create_anew(hood_x02);
            Engine.object_create_anew(cortana_x02);
            Engine.object_create_anew(miranda_x02);
            Engine.object_create_anew(johnson_x02);
            Engine.object_create_anew(marine_02);
            Engine.object_create_anew(marine_03);
            Engine.object_create_anew(marine_04);
            Engine.object_create_anew(x02_tactical_display);
            Engine.object_cinematic_lod(chief_x02.Entity, true);
            Engine.object_cinematic_lod(hood_x02.Entity, true);
            Engine.object_cinematic_lod(cortana_x02.Entity, true);
            Engine.object_cinematic_lod(miranda_x02.Entity, true);
            Engine.object_cinematic_lod(johnson_x02.Entity, true);
            Engine.object_cinematic_lod(marine_02.Entity, true);
            Engine.object_cinematic_lod(marine_03.Entity, true);
            Engine.object_cinematic_lod(marine_04.Entity, true);
            Engine.object_set_permutation(marine_02.Entity, "head", "smith");
            Engine.object_set_permutation(marine_03.Entity, "head", "walter");
            Engine.object_set_permutation(marine_04.Entity, "head", "dion");
            Engine.wake(new ScriptMethodReference(x02_foley_08));
            Engine.wake(new ScriptMethodReference(x02_0330_cor));
            Engine.wake(new ScriptMethodReference(x02_0340_lhd));
            Engine.wake(new ScriptMethodReference(x02_0350_cor));
            Engine.wake(new ScriptMethodReference(x02_0360_ahp));
            Engine.wake(new ScriptMethodReference(x02_0370_lhd));
            Engine.wake(new ScriptMethodReference(x02_0380_lhd));
            Engine.wake(new ScriptMethodReference(x02_0390_mir));
            Engine.wake(new ScriptMethodReference(x02_0400_lhd));
            Engine.wake(new ScriptMethodReference(x02_0405_cor));
            Engine.wake(new ScriptMethodReference(x02_0410_lhd));
            Engine.wake(new ScriptMethodReference(effect_cortana_off));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_08));
        }

        [ScriptMethod(156, Lifecycle.Static)]
        public async Task x02_scene_08_cleanup()
        {
            Engine.object_destroy(miranda_x02.Entity);
            Engine.object_destroy(cortana_x02.Entity);
            Engine.object_destroy(marine_02.Entity);
            Engine.object_destroy(marine_03.Entity);
            Engine.object_destroy(marine_04.Entity);
        }

        [ScriptMethod(157, Lifecycle.Static)]
        public async Task x02_scene_08()
        {
            Engine.cinematic_lightmap_shadow_enable();
            await this.x02_08_predict_stub();
            await this.x02_08_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_08", default(IUnit), anchor_flag_x02_01);
            Engine.custom_animation_relative(chief_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4059631577U), "chief_08", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(johnson_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "johnson_08", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(hood_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4061794298U), "hood_08", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(miranda_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x02\\x02", 4061925372U), "miranda_08", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(cortana_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x02\\x02", 4061990909U), "cortana_08", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine02_08", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine03_08", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine04_08", false, anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_cortana_stand.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4062056446U), "cortana_stand_08", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_unsc_logo.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\x02\\x02", 4062187520U), "unsc_logo_08", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_tactical_display.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\x02\\x02", 4065202222U), "display_large_08", anchor_x02_01.Entity);
            await Engine.sleep(30);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x02_09_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_09_fol", 4065267759U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x02_scene_08_cleanup();
        }

        [ScriptMethod(158, Lifecycle.CommandScript)]
        public async Task cs_x02_panic_01()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("x02_run/p0"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("x02_look/p0"));
                await Engine.sleep(60);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("x02_run/p1"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("x02_look/p1"));
                return false;
            });
        }

        [ScriptMethod(159, Lifecycle.CommandScript)]
        public async Task cs_x02_panic_02()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("x02_run/p2"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("x02_look/p2"));
                await Engine.sleep(60);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("x02_run/p3"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("x02_look/p3"));
                return false;
            });
        }

        [ScriptMethod(160, Lifecycle.CommandScript)]
        public async Task cs_x02_panic_03()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("x02_run/p0"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("x02_look/p0"));
                await Engine.sleep(60);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("x02_run/p2"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("x02_look/p2"));
                return false;
            });
        }

        [ScriptMethod(161, Lifecycle.CommandScript)]
        public async Task cs_x02_panic_04()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("x02_run/p3"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("x02_look/p3"));
                await Engine.sleep(60);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("x02_run/p1"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("x02_look/p1"));
                return false;
            });
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task x02_foley_09()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_09_fol", 4065267759U), default(IGameObject), 1F);
            Engine.print("x02 foley 09 start");
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task x02_0420_to1()
        {
            await Engine.sleep(107);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0420_to1", 4065333296U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x02_0420_to1", 1.5F);
            Engine.unit_set_emotional_state(marine_01.Entity, "annoyed", 0.5F, 0);
            Engine.unit_set_emotional_state(marine_01.Entity, "pensive", 0.5F, 0);
            await Engine.sleep(45);
            Engine.unit_set_emotional_state(marine_01.Entity, "annoyed", 1F, 10);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task x02_0430_to1()
        {
            await Engine.sleep(159);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0430_to1", 4065398833U), marine_01.Entity, 1F);
            Engine.cinematic_subtitle("x02_0430_to1", 1.5F);
            await Engine.sleep(10);
            Engine.unit_set_emotional_state(marine_01.Entity, "shocked", 0.25F, 0);
            Engine.print("marine_01 - shocked .5 0");
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task x02_0440_lhd()
        {
            await Engine.sleep(208);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0440_lhd", 4065464370U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0440_lhd", 5F);
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task x02_0450_lhd()
        {
            await Engine.sleep(367);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0450_lhd", 4065529907U), hood_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0450_lhd", 3F);
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task x02_0460_mas()
        {
            await Engine.sleep(462);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0460_mas", 4065595444U), chief_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0460_mas", 1F);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task x02_0480_mas()
        {
            await Engine.sleep(497);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0480_mas", 4065660981U), chief_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0480_mas", 1F);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task x02_0490_jon()
        {
            await Engine.sleep(529);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0490_jon", 4065726518U), johnson_x02.Entity, 1F);
            Engine.cinematic_subtitle("x02_0490_jon", 2F);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_09()
        {
            Engine.cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            Engine.cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task x02_fov_09_01()
        {
            await Engine.sleep(166);
            Engine.camera_set_field_of_view(23F, 10);
            Engine.print("fov change: 60 -> 23 over 10 ticks");
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task x02_fov_09_02()
        {
            await Engine.sleep(206);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 23 -> 60 over 0 ticks");
        }

        [ScriptMethod(173, Lifecycle.Static)]
        public async Task place_x02_ai()
        {
            Engine.ai_place(x02_panic_01.Squad);
            Engine.ai_place(x02_panic_02.Squad);
            Engine.ai_place(x02_panic_03.Squad);
            Engine.ai_place(x02_panic_04.Squad);
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task x02_09_setup()
        {
            Engine.object_hide(marine_01.Entity, false);
            Engine.wake(new ScriptMethodReference(x02_foley_09));
            Engine.wake(new ScriptMethodReference(x02_0420_to1));
            Engine.wake(new ScriptMethodReference(x02_0430_to1));
            Engine.wake(new ScriptMethodReference(x02_0440_lhd));
            Engine.wake(new ScriptMethodReference(x02_0450_lhd));
            Engine.wake(new ScriptMethodReference(x02_0460_mas));
            Engine.wake(new ScriptMethodReference(x02_0480_mas));
            Engine.wake(new ScriptMethodReference(x02_0490_jon));
            await this.place_x02_ai();
            Engine.wake(new ScriptMethodReference(x02_fov_09_01));
            Engine.wake(new ScriptMethodReference(x02_fov_09_02));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_09));
        }

        [ScriptMethod(175, Lifecycle.Static)]
        public async Task x02_scene_09()
        {
            Engine.wake(new ScriptMethodReference(x02_09_setup));
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_09", default(IUnit), anchor_flag_x02_01);
            Engine.custom_animation_relative(chief_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4059631577U), "chief_09", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(johnson_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "johnson_09", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(hood_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4061794298U), "hood_09", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "marine01_09", false, anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_tactical_display.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\x02\\x02", 4065202222U), "display_large_09", anchor_x02_01.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x02_10_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_10_fol", 4065792055U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(marine_01.Entity);
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task x02_foley_10()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_10_fol", 4065792055U), default(IGameObject), 1F);
            Engine.print("x02 foley 10 start");
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_10()
        {
            Engine.cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            Engine.cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            Engine.object_uses_cinematic_lighting(poa_x02.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_x02_01.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_x02_02.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_x02_03.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_x02_04.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_x02_05.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_x02_06.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_x02_07.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_x02_08.Entity, true);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task fighters_unhide()
        {
            await Engine.sleep(5);
            Engine.print("fighters unhide");
            Engine.object_hide(fighter_x02_01.Entity, false);
            Engine.object_hide(fighter_x02_02.Entity, false);
            Engine.object_hide(fighter_x02_03.Entity, false);
            Engine.object_hide(fighter_x02_04.Entity, false);
            Engine.object_hide(fighter_x02_05.Entity, false);
            Engine.object_hide(fighter_x02_06.Entity, false);
            Engine.object_hide(fighter_x02_07.Entity, false);
            Engine.object_hide(fighter_x02_08.Entity, false);
        }

        [ScriptMethod(179, Lifecycle.Static)]
        public async Task x02_10_setup()
        {
            Engine.object_create(poa_x02);
            Engine.object_create(fighter_x02_01);
            Engine.object_create(fighter_x02_02);
            Engine.object_create(fighter_x02_03);
            Engine.object_create(fighter_x02_04);
            Engine.object_create(fighter_x02_05);
            Engine.object_create(fighter_x02_06);
            Engine.object_create(fighter_x02_07);
            Engine.object_create(fighter_x02_08);
            Engine.object_cinematic_lod(poa_x02.Entity, true);
            Engine.object_cinematic_lod(fighter_x02_01.Entity, true);
            Engine.object_cinematic_lod(fighter_x02_02.Entity, true);
            Engine.object_cinematic_lod(fighter_x02_03.Entity, true);
            Engine.object_cinematic_lod(fighter_x02_04.Entity, true);
            Engine.object_cinematic_lod(fighter_x02_05.Entity, true);
            Engine.object_cinematic_lod(fighter_x02_06.Entity, true);
            Engine.object_cinematic_lod(fighter_x02_07.Entity, true);
            Engine.object_cinematic_lod(fighter_x02_08.Entity, true);
            Engine.object_hide(fighter_x02_01.Entity, true);
            Engine.object_hide(fighter_x02_02.Entity, true);
            Engine.object_hide(fighter_x02_03.Entity, true);
            Engine.object_hide(fighter_x02_04.Entity, true);
            Engine.object_hide(fighter_x02_05.Entity, true);
            Engine.object_hide(fighter_x02_06.Entity, true);
            Engine.object_hide(fighter_x02_07.Entity, true);
            Engine.object_hide(fighter_x02_08.Entity, true);
            Engine.wake(new ScriptMethodReference(x02_foley_10));
            Engine.wake(new ScriptMethodReference(fighters_unhide));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x02_10));
        }

        [ScriptMethod(180, Lifecycle.Static)]
        public async Task x02_scene_10_cleanup()
        {
            Engine.object_destroy(chief_x02.Entity);
            Engine.object_destroy(johnson_x02.Entity);
            Engine.object_destroy(hood_x02.Entity);
            Engine.object_destroy(x02_cortana_stand.Entity);
            Engine.object_destroy(x02_tactical_display.Entity);
            Engine.object_destroy(poa_x02.Entity);
            Engine.object_destroy_containing("fighter_x02");
        }

        [ScriptMethod(181, Lifecycle.Static)]
        public async Task x02_scene_10()
        {
            await this.x02_10_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4059566040U), "x02_10", default(IUnit), anchor_flag_x02_01);
            Engine.custom_animation_relative(chief_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4059631577U), "chief_10", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(johnson_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4059369429U), "johnson_10", false, anchor_x02_01.Entity);
            Engine.custom_animation_relative(hood_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4061794298U), "hood_10", false, anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_cortana_stand.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4062056446U), "cortana_stand_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(x02_tactical_display.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\x02\\x02", 4065202222U), "display_large_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(poa_x02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\x02\\x02", 4065857592U), "poa_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(fighter_x02_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4065923129U), "longsword01_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(fighter_x02_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4065923129U), "longsword02_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(fighter_x02_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4065923129U), "longsword03_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(fighter_x02_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4065923129U), "longsword04_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(fighter_x02_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4065923129U), "longsword05_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(fighter_x02_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4065923129U), "longsword06_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(fighter_x02_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4065923129U), "longsword07_10", anchor_x02_01.Entity);
            Engine.scenery_animation_start_relative(fighter_x02_08.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4065923129U), "longsword08_10", anchor_x02_01.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.x02_scene_10_cleanup();
            await Engine.sleep(30);
        }

        [ScriptMethod(182, Lifecycle.Static)]
        public async Task x02()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.cinematic_enable_ambience_details(false);
            Engine.sound_class_set_gain("device_machinery", 0F, 15);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("01_bsp_0"));
            await Engine.sleep(1);
            await this.x02_scene_01();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_0"));
            await Engine.sleep(5);
            await this.x02_scene_02();
            await this.x02_scene_03();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("01_bsp_1"));
            await Engine.sleep(5);
            await this.x02_scene_04a();
            await this.x02_scene_04b();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_0"));
            await Engine.sleep(5);
            await this.x02_scene_05();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("01_bsp_1"));
            await Engine.sleep(5);
            await this.x02_scene_06();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_0"));
            await Engine.sleep(5);
            await this.x02_scene_07();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("01_bsp_1"));
            await Engine.sleep(5);
            await this.x02_scene_08();
            await this.x02_scene_09();
            await this.x02_scene_10();
            Engine.sound_class_set_gain("device_machinery", 1F, 15);
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task c01_outro_score_01()
        {
            await Engine.sleep(259);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\music\\c01_outro_01_mus", 4065988666U), default(IGameObject), 1F);
            Engine.print("c01_outro score 01 start");
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task c01_outro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_01_fol", 4066054203U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 01 start");
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task c01_9010_cor()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9010_cor", 4066119740U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c01_9010_cor", 2F);
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task c01_9050_mas()
        {
            await Engine.sleep(311);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9050_mas", 4066185277U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c01_9050_mas", 2F);
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task c01_9060_cor()
        {
            await Engine.sleep(349);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9060_cor", 4066250814U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c01_9060_cor", 2F);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task c01_9070_mir()
        {
            await Engine.sleep(393);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9070_mir", 4066316351U), default(IGameObject), 1F, "radio_default");
            Engine.cinematic_subtitle("c01_9070_mir", 2F);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task cinematic_lighting_outro_01()
        {
            Engine.cinematic_lighting_set_primary_light(33F, 188F, 0.388235F, 0.380392F, 0.372549F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(cortana.Entity, true);
            Engine.object_uses_cinematic_lighting(pickle.Entity, true);
            Engine.object_uses_cinematic_lighting(outro_cortana_stand.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task effects_cortana_transfer()
        {
            await Engine.sleep(125);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4061007854U), outro_cortana_base.Entity, "marker");
            await Engine.sleep(20);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\masterchief\\data_transfer", 4066381888U), chief.Entity, "right_hand");
        }

        [ScriptMethod(191, Lifecycle.Static)]
        public async Task test()
        {
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4061007854U), outro_cortana_base.Entity, "marker");
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task bomb_deactivate()
        {
            await Engine.sleep(284);
            Engine.print("bomb deactivate");
            Engine.object_set_function_variable(pickle.Entity, "flare", 0F, 1F);
        }

        [ScriptMethod(193, Lifecycle.Static)]
        public async Task c01_outro_02_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(iac_bridge_outro_01);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(iac_bridge_outro_01.Entity, true);
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task upload_cortana()
        {
            Engine.time_code_reset();
            await Engine.sleep(135);
            Engine.print("upload cortana");
            Engine.object_destroy(cortana.Entity);
        }

        [ScriptMethod(195, Lifecycle.Static)]
        public async Task c01_outro_01_setup()
        {
            Engine.object_create_anew(chief);
            Engine.object_create_anew(cortana);
            Engine.object_create_anew(pickle);
            Engine.object_create_anew(outro_cortana_stand);
            Engine.object_create_anew(outro_cortana_base);
            Engine.object_destroy_containing("outro_crate");
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(cortana.Entity, true);
            Engine.object_cinematic_lod(pickle.Entity, true);
            Engine.object_cinematic_lod(outro_cortana_stand.Entity, true);
            Engine.wake(new ScriptMethodReference(c01_outro_score_01));
            Engine.wake(new ScriptMethodReference(c01_outro_foley_01));
            Engine.wake(new ScriptMethodReference(c01_9010_cor));
            Engine.wake(new ScriptMethodReference(c01_9050_mas));
            Engine.wake(new ScriptMethodReference(c01_9060_cor));
            Engine.wake(new ScriptMethodReference(c01_9070_mir));
            Engine.wake(new ScriptMethodReference(effects_cortana_transfer));
            Engine.wake(new ScriptMethodReference(upload_cortana));
            Engine.wake(new ScriptMethodReference(bomb_deactivate));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_outro_01));
        }

        [ScriptMethod(196, Lifecycle.Static)]
        public async Task c01_outro_01_cleanup()
        {
            Engine.object_destroy(outro_cortana_stand.Entity);
            Engine.object_destroy(outro_cortana_base.Entity);
        }

        [ScriptMethod(197, Lifecycle.Static)]
        public async Task c01_outro_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.x02_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\music\\c01_outro_01_mus", 4065988666U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_01_fol", 4066054203U));
            await Engine.sleep(this.prediction_offset);
            await this.c01_outro_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_01", default(IUnit), anchor_flag_outro1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_01", false, anchor_outro1.Entity);
            Engine.custom_animation_relative(cortana.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\01_outro\\01_outro", 4066578499U), "cortana_01", false, anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(pickle.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(outro_cortana_stand.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\01_outro\\01_outro", 4066709573U), "cortana_stand_01", anchor_outro1.Entity);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4061007854U), outro_cortana_base.Entity, "marker");
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_outro_02_predict_stub();
            await this.c01_outro_02_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_02_fol", 4066775110U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_outro_01_cleanup();
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task c01_outro_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_02_fol", 4066775110U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 02 start");
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task c01_9080_mir()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9080_mir", 4066840647U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("c01_9080_mir", 3F);
            await Engine.sleep(1);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 0);
            Engine.unit_set_emotional_state(hood.Entity, "annoyed", 0.5F, 0);
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task c01_9090_lhd()
        {
            await Engine.sleep(113);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9090_lhd", 4066906184U), hood.Entity, 1F);
            Engine.cinematic_subtitle("c01_9090_lhd", 4F);
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task c01_9100_mas()
        {
            await Engine.sleep(227);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9100_mas", 4066971721U), default(IGameObject), 1F, "radio_default");
            Engine.cinematic_subtitle("c01_9100_mas", 1F);
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task c01_9110_mas()
        {
            await Engine.sleep(250);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9110_mas", 4067037258U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c01_9110_mas", 1F);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task c01_9120_lhd()
        {
            await Engine.sleep(290);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9120_lhd", 4067102795U), hood.Entity, 1F);
            Engine.cinematic_subtitle("c01_9120_lhd", 2F);
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task c01_9130_mas()
        {
            await Engine.sleep(343);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9130_mas", 4067168332U), default(IGameObject), 1F, "radio_default");
            Engine.cinematic_subtitle("c01_9130_mas", 2F);
            await Engine.sleep(77);
            Engine.unit_set_emotional_state(hood.Entity, "happy", 0.25F, 90);
            Engine.print("hood - happy .25 90");
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task c01_9140_lhd()
        {
            await Engine.sleep(436);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9140_lhd", 4067233869U), hood.Entity, 1F);
            Engine.cinematic_subtitle("c01_9140_lhd", 1F);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bridges_01a()
        {
            Engine.time_code_reset();
            Engine.print("light miranda");
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_bridge_outro_01.Entity, true);
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bridges_01b()
        {
            await Engine.sleep(111);
            Engine.print("light hood");
            Engine.cinematic_lighting_set_primary_light(-21F, 102F, 0.368627F, 0.333333F, 0.258824F);
            Engine.cinematic_lighting_set_secondary_light(13F, 294F, 0.192157F, 0.2F, 0.243137F);
            Engine.cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            Engine.object_uses_cinematic_lighting(hood.Entity, true);
            Engine.object_uses_cinematic_lighting(cairo_bridge.Entity, true);
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task cinematic_lighting_chief_01()
        {
            await Engine.sleep(240);
            Engine.print("light chief");
            Engine.cinematic_lighting_set_primary_light(-12F, 294F, 0.47451F, 0.419608F, 0.392157F);
            Engine.cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(pickle.Entity, true);
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bridges_02()
        {
            await Engine.sleep(288);
            Engine.print("light hood");
            Engine.cinematic_lighting_set_primary_light(-21F, 102F, 0.368627F, 0.333333F, 0.258824F);
            Engine.cinematic_lighting_set_secondary_light(13F, 294F, 0.192157F, 0.2F, 0.243137F);
            Engine.cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
        }

        [ScriptMethod(210, Lifecycle.Static)]
        public async Task c01_outro_02_setup()
        {
            Engine.object_create_anew(hood);
            Engine.object_create_anew(cairo_bridge);
            Engine.object_cinematic_lod(hood.Entity, true);
            Engine.object_cinematic_lod(cairo_bridge.Entity, true);
            Engine.wake(new ScriptMethodReference(c01_outro_foley_02));
            Engine.wake(new ScriptMethodReference(c01_9080_mir));
            Engine.wake(new ScriptMethodReference(c01_9090_lhd));
            Engine.wake(new ScriptMethodReference(c01_9100_mas));
            Engine.wake(new ScriptMethodReference(c01_9110_mas));
            Engine.wake(new ScriptMethodReference(c01_9120_lhd));
            Engine.wake(new ScriptMethodReference(c01_9130_mas));
            Engine.wake(new ScriptMethodReference(c01_9140_lhd));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_bridges_01a));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_bridges_01b));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_chief_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_bridges_02));
        }

        [ScriptMethod(211, Lifecycle.Static)]
        public async Task c01_outro_02_cleanup()
        {
            Engine.object_destroy(hood.Entity);
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy(iac_bridge_outro_01.Entity);
            Engine.object_destroy(cairo_bridge.Entity);
        }

        [ScriptMethod(212, Lifecycle.Static)]
        public async Task c01_outro_scene_02()
        {
            Engine.pvs_set_object(anchor_outro1.Entity);
            await this.c01_outro_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_02", default(IUnit), anchor_flag_outro1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_02", false, anchor_outro1.Entity);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\01_outro\\01_outro", 4067299406U), "miranda_02", false, anchor_outro1.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\01_outro\\01_outro", 4067364943U), "johnson_02", false, anchor_outro1.Entity);
            Engine.custom_animation_relative(hood.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\01_outro\\01_outro", 4067430480U), "hood_02", false, anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(pickle.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(iac_bridge_outro_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\01_outro\\01_outro", 4067496017U), "iac_bridge_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(cairo_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge\\01_outro\\01_outro", 4067561554U), "cairo_bridge_02", anchor_outro1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_outro_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_03_fol", 4067627091U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_outro_02_cleanup();
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task c01_outro_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_03_fol", 4067627091U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 03 start");
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task doors_outro_03()
        {
            Engine.device_set_position(outro_door_01.Entity, 1F);
            await Engine.sleep(360);
            Engine.device_group_change_only_once_more_set(outro_door_011, false);
            Engine.device_set_position(outro_door_01.Entity, 0F);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task outro_sparks_03()
        {
            await Engine.sleep(101);
            Engine.object_create_anew_containing("sparks_backward");
            Engine.objects_attach(pickle.Entity, "sparks01", sparks_backward_01.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks03", sparks_backward_02.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks04", sparks_backward_03.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks07", sparks_backward_04.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks08", sparks_backward_05.Entity, "marker");
            await Engine.sleep(36);
            Engine.object_destroy_containing("sparks_backward");
            await Engine.sleep(25);
            Engine.object_create_anew_containing("sparks_backward");
            Engine.objects_attach(pickle.Entity, "sparks01", sparks_backward_01.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks03", sparks_backward_02.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks04", sparks_backward_03.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks07", sparks_backward_04.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks08", sparks_backward_05.Entity, "marker");
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task cinematic_lighting_chief_02()
        {
            Engine.print("light chief");
            Engine.cinematic_lighting_set_primary_light(33F, 188F, 0.388235F, 0.380392F, 0.372549F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(outro_elevator.Entity, true);
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task c01_outro_03_setup()
        {
            Engine.wake(new ScriptMethodReference(c01_outro_foley_03));
            Engine.object_create_anew(outro_elevator);
            Engine.object_cinematic_lod(outro_elevator.Entity, true);
            Engine.wake(new ScriptMethodReference(doors_outro_03));
            Engine.wake(new ScriptMethodReference(outro_sparks_03));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_chief_02));
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task c01_outro_03_cleanup()
        {
            Engine.object_destroy_containing("sparks_backward");
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task c01_outro_scene_03()
        {
            await this.c01_outro_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_03", default(IUnit), anchor_flag_outro1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_03", false, anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(pickle.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_03", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(outro_elevator.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\ss_elevator\\01_outro\\01_outro", 4067692628U), "elevator_03", anchor_outro1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_outro_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_04_fol", 4067758165U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_outro_03_cleanup();
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task c01_outro_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_04_fol", 4067758165U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 04 start");
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task c01_9150_cor()
        {
            await Engine.sleep(30);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9150_cor", 4067823702U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c01_9150_cor", 2F);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task c01_9160_mas()
        {
            await Engine.sleep(108);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9160_mas", 4067889239U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c01_9160_mas", 2F);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task c01_9170_cor()
        {
            await Engine.sleep(154);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9170_cor", 4067954776U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c01_9170_cor", 2F);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task c01_9180_cor()
        {
            await Engine.sleep(217);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9180_cor", 4068020313U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c01_9180_cor", 1F);
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task c01_outro_shake_04_01()
        {
            Engine.time_code_reset();
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            Engine.player_effect_stop(1F);
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task c01_outro_shake_04_02()
        {
            await Engine.sleep(105);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 0.35F, 0.35F);
            Engine.player_effect_start(0.25F, 0F);
            await Engine.sleep(93);
            Engine.player_effect_stop(0F);
            Engine.print("shake stop");
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task c01_outro_shake_04_03()
        {
            await Engine.sleep(227);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 2F);
            await Engine.sleep(45);
            Engine.player_effect_stop(0F);
            Engine.print("shake stop");
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task outro_sparks_03_04()
        {
            Engine.object_create_anew_containing("sparks_forward");
            Engine.objects_attach(pickle.Entity, "sparks01", sparks_forward_01.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks02", sparks_forward_02.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks03", sparks_forward_03.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks04", sparks_forward_04.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks05", sparks_forward_05.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks06", sparks_forward_06.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks07", sparks_forward_07.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks08", sparks_forward_08.Entity, "marker");
            await Engine.sleep(490);
            Engine.object_destroy_containing("sparks_forward");
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task doors_outro_04()
        {
            await Engine.sleep(300);
            Engine.device_set_position(outro_door_02.Entity, 1F);
            await Engine.sleep(150);
            Engine.device_group_change_only_once_more_set(outro_door_021, false);
            Engine.device_set_position(outro_door_02.Entity, 0F);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task create_bloom_quad()
        {
            Engine.time_code_reset();
            await Engine.sleep(273);
            Engine.print("create bloom quad");
            Engine.object_create_anew(bloom_quad);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task top_light()
        {
            await Engine.sleep(105);
            Engine.print("delete top light");
            Engine.objects_detach(outro_elevator.Entity, elevator_light_top.Entity);
            Engine.object_destroy(elevator_light_top.Entity);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task bottom_light()
        {
            await Engine.sleep(198);
            Engine.print("create bottom light");
            Engine.object_create_anew(elevator_light_bottom);
            Engine.objects_attach(outro_elevator.Entity, "light_red02", elevator_light_bottom.Entity, "");
        }

        [ScriptMethod(233, Lifecycle.Static)]
        public async Task c01_outro_04_setup()
        {
            Engine.render_lights_enable_cinematic_shadow(true, chief.Entity, "head", 0.4F);
            Engine.object_create_anew(matte_earth);
            Engine.object_create_anew(elevator_light_top);
            Engine.object_create_anew(elevator_light_flash);
            Engine.objects_attach(outro_elevator.Entity, "light_red01", elevator_light_top.Entity, "");
            Engine.wake(new ScriptMethodReference(c01_outro_foley_04));
            Engine.wake(new ScriptMethodReference(c01_9150_cor));
            Engine.wake(new ScriptMethodReference(c01_9160_mas));
            Engine.wake(new ScriptMethodReference(c01_9170_cor));
            Engine.wake(new ScriptMethodReference(c01_9180_cor));
            Engine.wake(new ScriptMethodReference(doors_outro_04));
            Engine.wake(new ScriptMethodReference(outro_sparks_03_04));
            Engine.wake(new ScriptMethodReference(create_bloom_quad));
            Engine.wake(new ScriptMethodReference(top_light));
            Engine.wake(new ScriptMethodReference(bottom_light));
            Engine.wake(new ScriptMethodReference(c01_outro_shake_04_01));
            Engine.wake(new ScriptMethodReference(c01_outro_shake_04_02));
            Engine.wake(new ScriptMethodReference(c01_outro_shake_04_03));
        }

        [ScriptMethod(234, Lifecycle.Static)]
        public async Task c01_outro_04_cleanup()
        {
            Engine.objects_detach(outro_elevator.Entity, elevator_light_bottom.Entity);
            Engine.object_destroy_containing("elevator");
            Engine.object_destroy(bloom_quad.Entity);
        }

        [ScriptMethod(235, Lifecycle.Static)]
        public async Task c01_outro_scene_04()
        {
            await this.c01_outro_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_04", default(IUnit), anchor_flag_outro1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_04", false, anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(pickle.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_04", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(outro_elevator.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\ss_elevator\\01_outro\\01_outro", 4067692628U), "elevator_04", anchor_outro1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_outro_05_predict_stub();
            Engine.object_create_anew(outro_fleet);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_05_fol", 4068085850U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_outro_04_cleanup();
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task c01_outro_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_05_fol", 4068085850U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 05 start");
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task c01_9190_cor()
        {
            await Engine.sleep(293);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9190_cor", 4068151387U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c01_9190_cor", 2F);
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task c01_9200_cor()
        {
            await Engine.sleep(355);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9200_cor", 4068216924U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c01_9200_cor", 1F);
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task c01_9210_mas()
        {
            await Engine.sleep(412);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9210_mas", 4068282461U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c01_9210_mas", 1F);
            Engine.object_create_anew(outro_fleet);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task c01_outro_shake_05_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(470);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bay_01()
        {
            Engine.print("light bay");
            Engine.cinematic_lighting_set_primary_light(81F, 88F, 0.360784F, 0.372549F, 0.462745F);
            Engine.cinematic_lighting_set_secondary_light(0F, 0F, 0.160784F, 0.152941F, 0.211765F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(outro_fighter_01.Entity, true);
            Engine.object_uses_cinematic_lighting(outro_fighter_02.Entity, true);
            Engine.object_uses_cinematic_lighting(outro_seraph.Entity, true);
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task lever()
        {
            await Engine.sleep(240);
            Engine.device_set_position(outro_lever.Entity, 1F);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task airlock()
        {
            await Engine.sleep(470);
            Engine.device_set_position(outro_door_03.Entity, 1F);
        }

        [ScriptMethod(244, Lifecycle.Static)]
        public async Task c01_outro_05_setup()
        {
            Engine.object_create_anew(outro_fighter_01);
            Engine.object_create_anew(outro_fighter_02);
            Engine.object_create_anew(outro_seraph);
            Engine.object_cinematic_lod(outro_fighter_01.Entity, true);
            Engine.object_cinematic_lod(outro_fighter_02.Entity, true);
            Engine.object_cinematic_lod(outro_seraph.Entity, true);
            Engine.object_cinematic_visibility(outro_fighter_01.Entity, true);
            Engine.object_cinematic_visibility(outro_fighter_02.Entity, true);
            Engine.object_cinematic_visibility(outro_seraph.Entity, true);
            Engine.wake(new ScriptMethodReference(lever));
            Engine.wake(new ScriptMethodReference(airlock));
            Engine.wake(new ScriptMethodReference(c01_outro_foley_05));
            Engine.wake(new ScriptMethodReference(c01_9190_cor));
            Engine.wake(new ScriptMethodReference(c01_9200_cor));
            Engine.wake(new ScriptMethodReference(c01_9210_mas));
            Engine.wake(new ScriptMethodReference(c01_outro_shake_05_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_bay_01));
        }

        [ScriptMethod(245, Lifecycle.Static)]
        public async Task c01_outro_05_cleanup()
        {
            Engine.object_destroy(outro_fighter_01.Entity);
            Engine.object_destroy(outro_fighter_02.Entity);
            Engine.object_destroy(outro_seraph.Entity);
        }

        [ScriptMethod(246, Lifecycle.Static)]
        public async Task c01_outro_scene_05()
        {
            await this.c01_outro_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_05", default(IUnit), anchor_flag_outro1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_05", false, anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(pickle.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_05", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(matte_earth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\earth_space\\01_outro\\01_outro", 4068347998U), "earth_matte_05", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(outro_fighter_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4068413535U), "longsword01_05", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(outro_fighter_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4068413535U), "longsword02_05", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(outro_seraph.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 4068479072U), "01_outro_05", anchor_outro1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_outro_06_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\music\\c01_outro_06_mus", 4068544609U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_06_fol", 4068610146U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_outro_05_cleanup();
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task c01_outro_music_06()
        {
            await Engine.sleep(233);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\music\\c01_outro_06_mus", 4068544609U), default(IGameObject), 1F);
            Engine.print("c01_outro music 06 start");
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task c01_outro_foley_06()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_06_fol", 4068610146U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 06 start");
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task c01_outro_shake_06_01()
        {
            await Engine.sleep(243);
            Engine.player_effect_stop(2F);
            Engine.print("shake stop");
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bay_02()
        {
            Engine.print("light bay 02");
            Engine.cinematic_lighting_set_primary_light(-12F, 294F, 0.47451F, 0.419608F, 0.392157F);
            Engine.cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(251, Lifecycle.Dormant)]
        public async Task final_sparks()
        {
            Engine.time_code_reset();
            await Engine.sleep(132);
            Engine.print("sparks start");
            Engine.object_create_anew_containing("sparks_forward");
            Engine.objects_attach(pickle.Entity, "sparks01", sparks_forward_01.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks02", sparks_forward_02.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks03", sparks_forward_03.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks04", sparks_forward_04.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks05", sparks_forward_05.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks06", sparks_forward_06.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks07", sparks_forward_07.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks08", sparks_forward_08.Entity, "marker");
            await Engine.sleep(8);
            Engine.object_destroy_containing("sparks_forward");
            Engine.print("sparks stop");
            await Engine.sleep(22);
            Engine.object_create_anew_containing("sparks_forward");
            Engine.print("sparks start");
            Engine.objects_attach(pickle.Entity, "sparks01", sparks_forward_01.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks02", sparks_forward_02.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks03", sparks_forward_03.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks04", sparks_forward_04.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks05", sparks_forward_05.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks06", sparks_forward_06.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks07", sparks_forward_07.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks08", sparks_forward_08.Entity, "marker");
            await Engine.sleep(5);
            Engine.object_destroy_containing("sparks_forward");
            Engine.print("sparks stop");
            await Engine.sleep(29);
            Engine.object_create_anew_containing("sparks_forward");
            Engine.print("sparks start");
            Engine.objects_attach(pickle.Entity, "sparks01", sparks_forward_01.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks02", sparks_forward_02.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks03", sparks_forward_03.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks04", sparks_forward_04.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks05", sparks_forward_05.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks06", sparks_forward_06.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks07", sparks_forward_07.Entity, "marker");
            Engine.objects_attach(pickle.Entity, "sparks08", sparks_forward_08.Entity, "marker");
            await Engine.sleep(50);
            Engine.object_destroy_containing("sparks_forward");
            Engine.print("sparks stop");
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task destroy_fleet()
        {
            await Engine.sleep(150);
            Engine.print("destroy fleet");
            Engine.object_destroy(outro_fleet.Entity);
        }

        [ScriptMethod(253, Lifecycle.Static)]
        public async Task c01_outro_06_setup()
        {
            Engine.object_create_anew(airlock_debris_01);
            Engine.object_create_anew(airlock_debris_02);
            Engine.wake(new ScriptMethodReference(c01_outro_music_06));
            Engine.wake(new ScriptMethodReference(c01_outro_foley_06));
            Engine.wake(new ScriptMethodReference(c01_outro_shake_06_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_bay_02));
            Engine.wake(new ScriptMethodReference(final_sparks));
            Engine.wake(new ScriptMethodReference(destroy_fleet));
        }

        [ScriptMethod(254, Lifecycle.Static)]
        public async Task c01_outro_06_cleanup()
        {
            Engine.object_destroy(matte_earth.Entity);
            Engine.object_destroy(pickle.Entity);
            Engine.object_destroy_containing("airlock_debris");
        }

        [ScriptMethod(255, Lifecycle.Static)]
        public async Task c01_outro_scene_06()
        {
            await this.c01_outro_06_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_06", default(IUnit), anchor_flag_outro1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_06", false, anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(pickle.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_06", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(matte_earth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\earth_space\\01_outro\\01_outro", 4068347998U), "earth_matte_06", anchor_outro1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_07_fol", 4068675683U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(69);
            await this.c01_outro_06_cleanup();
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task c01_outro_foley_07()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_07_fol", 4068675683U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 07 start");
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task effect_covenant_beams()
        {
            await Engine.sleep(338);
            Engine.object_destroy(carrier_02.Entity);
            Engine.print("effect - beam fire");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_beam", 4068741220U), covenant_battery.Entity, "");
            await Engine.sleep(40);
            Engine.print("effect - beam fire");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_beam", 4068741220U), covenant_battery.Entity, "");
            await Engine.sleep(59);
            Engine.print("effect - beam fire");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_beam", 4068741220U), covenant_battery.Entity, "");
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task effect_poa_explosions()
        {
            await Engine.sleep(444);
            Engine.print("effect - poa explosion large");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\poa_hit_small", 4069003368U), poa.Entity, "explosion02");
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task cinematic_lighting_outro_07()
        {
            Engine.cinematic_lighting_set_primary_light(-5F, 314F, 0.32549F, 0.27451F, 0.243137F);
            Engine.cinematic_lighting_set_secondary_light(19F, 170F, 0.145098F, 0.14902F, 0.313726F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(pickle2.Entity, true);
            Engine.object_uses_cinematic_lighting(carrier_01.Entity, true);
            Engine.object_uses_cinematic_lighting(carrier_02.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_01.Entity, true);
            Engine.object_uses_cinematic_lighting(fighter_02.Entity, true);
            Engine.object_uses_cinematic_lighting(poa.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task cinematic_lighting_poa_reverse()
        {
            Engine.time_code_reset();
            await Engine.sleep(491);
            Engine.print("light poa reverse");
            Engine.cinematic_lighting_set_primary_light(-68F, 122F, 0.47451F, 0.419608F, 0.392157F);
            Engine.cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(261, Lifecycle.Static)]
        public async Task c01_outro_07_setup()
        {
            Engine.render_lights_enable_cinematic_shadow(false, chief.Entity, "head", 0.4F);
            Engine.object_create_anew(pickle2);
            Engine.object_create_anew(carrier_01);
            Engine.object_create_anew(carrier_02);
            Engine.object_create_anew(fighter_01);
            Engine.object_create_anew(fighter_02);
            Engine.object_create_anew(poa);
            Engine.object_create_anew(covenant_battery);
            Engine.object_create_anew(matte_africa);
            Engine.object_cinematic_lod(pickle2.Entity, true);
            Engine.object_cinematic_lod(carrier_01.Entity, true);
            Engine.object_cinematic_lod(carrier_02.Entity, true);
            Engine.object_cinematic_lod(fighter_01.Entity, true);
            Engine.object_cinematic_lod(fighter_02.Entity, true);
            Engine.object_cinematic_lod(poa.Entity, true);
            Engine.object_cinematic_lod(covenant_battery.Entity, true);
            Engine.object_cinematic_lod(matte_africa.Entity, true);
            Engine.object_set_function_variable(pickle2.Entity, "flare", 0F, 1F);
            Engine.wake(new ScriptMethodReference(c01_outro_foley_07));
            Engine.wake(new ScriptMethodReference(effect_covenant_beams));
            Engine.wake(new ScriptMethodReference(effect_poa_explosions));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_outro_07));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_poa_reverse));
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\poa_flaming_debris", 4069724275U), poa.Entity, "flaming_debris");
        }

        [ScriptMethod(262, Lifecycle.Static)]
        public async Task c01_outro_07_cleanup()
        {
            Engine.object_destroy(poa.Entity);
        }

        [ScriptMethod(263, Lifecycle.Static)]
        public async Task c01_outro_scene_07()
        {
            await this._01_outro_07_predict_stub();
            await this.c01_outro_07_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_07", default(IUnit), anchor_flag_outro2);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_07", false, anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(pickle2.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_07", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(carrier_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\01_outro\\01_outro", 4069920886U), "capship01_07", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(carrier_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\01_outro\\01_outro", 4069920886U), "capship02_07", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(fighter_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4068413535U), "longsword01_07", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(fighter_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4068413535U), "longsword02_07", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(poa.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\01_outro\\01_outro", 4069986423U), "poa_07", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(covenant_battery.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\01_outro\\01_outro", 4070051960U), "texture_camera_07", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_africa.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\africa_space\\01_outro\\01_outro", 4070117497U), "africa_space_07", anchor_outro2.Entity);
            Engine.fade_in(0F, 0F, 0F, 30);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_outro_08_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_08_fol", 4070183034U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_outro_07_cleanup();
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task c01_outro_foley_08()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_08_fol", 4070183034U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 08 start");
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task effect_cluster_bombs()
        {
            await Engine.sleep(120);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4070248571U), carrier_01.Entity, "cluster01");
            await Engine.sleep(5);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4070248571U), carrier_01.Entity, "cluster03");
            await Engine.sleep(5);
            await Engine.sleep(4);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4070248571U), carrier_01.Entity, "cluster05");
            await Engine.sleep(4);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4070248571U), carrier_01.Entity, "cluster06");
            await Engine.sleep(3);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4070248571U), carrier_01.Entity, "cluster07");
            await Engine.sleep(3);
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task effect_interior_blast()
        {
            await Engine.sleep(195);
            Engine.print("interior blast");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4070248571U), blast_base.Entity, "marker");
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task x02_08_dof()
        {
            Engine.time_code_reset();
            await Engine.sleep(455);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(5F, 0F, 0F, 0F, 1F, 1F, 0F);
            Engine.print("rack focus");
            Engine.time_code_reset();
            await Engine.sleep(116);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task bomb_reactivate()
        {
            await Engine.sleep(630);
            Engine.print("bomb reactivate");
            Engine.object_set_function_variable(pickle2.Entity, "flare", 1F, 0F);
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_08()
        {
            Engine.print("light scene 08");
            Engine.cinematic_lighting_set_primary_light(-5F, 314F, 0.32549F, 0.27451F, 0.243137F);
            Engine.cinematic_lighting_set_secondary_light(19F, 170F, 0.145098F, 0.14902F, 0.313726F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task cinematic_light_carrier_int()
        {
            Engine.time_code_reset();
            await Engine.sleep(199);
            Engine.print("light carrier interior");
            Engine.cinematic_lighting_set_primary_light(63F, 356F, 0.305882F, 0.262745F, 0.380392F);
            Engine.cinematic_lighting_set_secondary_light(9F, 220F, 0.0784314F, 0.0784314F, 0.160784F);
            Engine.cinematic_lighting_set_ambient_light(0.0235294F, 0.027451F, 0.0588235F);
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task save_framerate_08()
        {
            await Engine.sleep(199);
            Engine.print("hide carrier, africa matte");
            Engine.object_hide(carrier_01.Entity, true);
            Engine.object_hide(matte_africa.Entity, true);
        }

        [ScriptMethod(272, Lifecycle.Static)]
        public async Task c01_outro_08_setup()
        {
            Engine.object_create(matte_carrier_core);
            Engine.object_create(matte_carrier_side);
            Engine.object_create(matte_carrier_hull);
            Engine.object_create_anew(blast_base);
            Engine.object_cinematic_visibility(blast_base.Entity, true);
            Engine.object_cinematic_lod(matte_carrier_core.Entity, true);
            Engine.object_cinematic_lod(matte_carrier_side.Entity, true);
            Engine.object_cinematic_lod(matte_carrier_hull.Entity, true);
            Engine.wake(new ScriptMethodReference(c01_outro_foley_08));
            Engine.wake(new ScriptMethodReference(effect_cluster_bombs));
            Engine.wake(new ScriptMethodReference(save_framerate_08));
            Engine.wake(new ScriptMethodReference(effect_interior_blast));
            Engine.wake(new ScriptMethodReference(bomb_reactivate));
            Engine.wake(new ScriptMethodReference(x02_08_dof));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_scene_08));
            Engine.wake(new ScriptMethodReference(cinematic_light_carrier_int));
        }

        [ScriptMethod(273, Lifecycle.Static)]
        public async Task c01_outro_08_cleanup()
        {
            Engine.object_destroy(matte_carrier_core.Entity);
            Engine.object_destroy(matte_carrier_side.Entity);
            Engine.object_destroy(fighter_01.Entity);
            Engine.object_destroy(fighter_02.Entity);
            Engine.object_destroy(covenant_battery.Entity);
            Engine.object_destroy(blast_base.Entity);
        }

        [ScriptMethod(274, Lifecycle.Static)]
        public async Task c01_outro_scene_08()
        {
            await this.c01_outro_08_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_08", default(IUnit), anchor_flag_outro2);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_08", false, anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(pickle2.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_08", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(carrier_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\01_outro\\01_outro", 4069920886U), "capship01_08", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(fighter_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4068413535U), "longsword01_08", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(fighter_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4068413535U), "longsword02_08", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(covenant_battery.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\01_outro\\01_outro", 4070051960U), "texture_camera_08", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_carrier_core.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_core\\01_outro\\01_outro", 4070379645U), "cruiser_core_08", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_carrier_side.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_side\\01_outro\\01_outro", 4070445182U), "cruiser_side_08", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_carrier_hull.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_up\\01_outro\\01_outro", 4070510719U), "cruiser_up_08", anchor_outro2.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_outro_09_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_09_fol", 4070576256U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_outro_08_cleanup();
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task c01_outro_foley_09()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_09_fol", 4070576256U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 09 start");
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_09()
        {
            Engine.print("light scene 09");
            Engine.cinematic_lighting_set_primary_light(-12F, 2F, 0.352941F, 0.109804F, 0.756863F);
            Engine.cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(277, Lifecycle.Static)]
        public async Task c01_outro_09_setup()
        {
            Engine.wake(new ScriptMethodReference(c01_outro_foley_09));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_scene_09));
            Engine.object_hide(matte_africa.Entity, false);
            Engine.print("unhide africa matte");
        }

        [ScriptMethod(278, Lifecycle.Static)]
        public async Task c01_outro_09_cleanup()
        {
            Engine.object_destroy(pickle2.Entity);
            Engine.object_destroy(matte_carrier_hull.Entity);
            Engine.object_destroy(matte_africa.Entity);
        }

        [ScriptMethod(279, Lifecycle.Static)]
        public async Task c01_outro_scene_09()
        {
            await this.c01_outro_09_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_09", default(IUnit), anchor_flag_outro2);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_09", false, anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(pickle2.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4066644036U), "pickle_09", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_carrier_hull.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_up\\01_outro\\01_outro", 4070510719U), "cruiser_up_09", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_africa.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\africa_space\\01_outro\\01_outro", 4070117497U), "africa_space_09", anchor_outro2.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._01_outro_10_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_10_fol", 4070641793U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c01_outro_09_cleanup();
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task c01_outro_foley_10()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_10_fol", 4070641793U), default(IGameObject), 1F);
            Engine.print("c01_outro foley 10 start");
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task c01_9220_jon()
        {
            await Engine.sleep(375);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9220_jon", 4070707330U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c01_9220_jon", 1F);
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task c01_9230_jon()
        {
            await Engine.sleep(415);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9230_jon", 4070772867U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c01_9230_jon", 1F);
            Engine.unit_set_emotional_state(johnson.Entity, "happy", 0.75F, 90);
            Engine.print("johnson - happy .75 90");
            await Engine.sleep(41);
            Engine.unit_set_emotional_state(miranda.Entity, "happy", 0.25F, 60);
            Engine.print("miranda - happy .25 60");
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task c01_9240_mir()
        {
            await Engine.sleep(461);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9240_mir", 4070838404U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("c01_9240_mir", 2F);
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task c01_9250_mir()
        {
            await Engine.sleep(536);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9250_mir", 4070903941U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c01_9250_mir", 2F);
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task carrier_explosion_tiny()
        {
            await Engine.sleep(15);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4070969478U), carrier_01.Entity, "tiny_explosion01");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4070969478U), carrier_01.Entity, "tiny_explosion02");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4070969478U), carrier_01.Entity, "tiny_explosion03");
            await Engine.sleep(3);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4070969478U), carrier_01.Entity, "tiny_explosion04");
            await Engine.sleep(3);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4070969478U), carrier_01.Entity, "tiny_explosion05");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4070969478U), carrier_01.Entity, "tiny_explosion06");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4070969478U), carrier_01.Entity, "tiny_explosion07");
        }

        [ScriptMethod(286, Lifecycle.Dormant)]
        public async Task carrier_explosion_medium()
        {
            await Engine.sleep(20);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_minor_explosion", 4071297163U), carrier_01.Entity, "tiny_explosion01");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_minor_explosion", 4071297163U), carrier_01.Entity, "tiny_explosion02");
            await Engine.sleep(10);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_minor_explosion", 4071297163U), carrier_01.Entity, "tiny_explosion03");
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task carrier_explosion_large()
        {
            await Engine.sleep(50);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_major_explosion", 4071886996U), carrier_01.Entity, "major_explosion");
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task white_flash()
        {
            await Engine.sleep(185);
            Engine.print("white flash");
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(30);
            Engine.object_hide(miranda.Entity, false);
            Engine.object_hide(johnson.Entity, false);
            Engine.object_hide(iac.Entity, false);
            Engine.object_hide(iac_bridge_outro_02.Entity, false);
            Engine.object_hide(matte_africa_coast.Entity, false);
            Engine.print("unhide miranda, johnson, iac");
            Engine.fade_in(1F, 1F, 1F, 15);
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task effect_africa_explosions()
        {
            await Engine.sleep(522);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\africa_explosion", 4072083607U), matte_africa_coast.Entity, "explosion1");
            await Engine.sleep(20);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\africa_explosion", 4072083607U), matte_africa_coast.Entity, "explosion2");
            await Engine.sleep(15);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\africa_explosion", 4072083607U), matte_africa_coast.Entity, "explosion3");
            await Engine.sleep(25);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\africa_explosion", 4072083607U), matte_africa_coast.Entity, "explosion4");
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task cinematic_lighting_outro_10()
        {
            Engine.cinematic_lighting_set_primary_light(-68F, 122F, 0.47451F, 0.419608F, 0.392157F);
            Engine.cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task cinematic_lighting_iac_ext_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(198);
            Engine.print("light iac exterior");
            Engine.cinematic_lighting_set_primary_light(6F, 0F, 0.47451F, 0.423529F, 0.392157F);
            Engine.cinematic_lighting_set_secondary_light(45F, 116F, 0.0784314F, 0.0745098F, 0.101961F);
            Engine.cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0470588F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(iac.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_bridge_outro_02.Entity, true);
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task cinematic_lighting_iac_interior()
        {
            await Engine.sleep(338);
            Engine.print("light iac interior");
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task cinematic_lighting_iac_ext_02()
        {
            await Engine.sleep(502);
            Engine.print("light iac exterior");
            Engine.cinematic_lighting_set_primary_light(6F, 0F, 0.47451F, 0.423529F, 0.392157F);
            Engine.cinematic_lighting_set_secondary_light(45F, 116F, 0.0784314F, 0.0745098F, 0.101961F);
            Engine.cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0470588F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task emotion_10()
        {
            await Engine.sleep(226);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            Engine.unit_set_emotional_state(johnson.Entity, "pensive", 0.5F, 0);
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task save_framerate_10()
        {
            Engine.object_hide(carrier_01.Entity, false);
            Engine.print("unhide carrier");
            Engine.object_hide(miranda.Entity, true);
            Engine.object_hide(johnson.Entity, true);
            Engine.object_hide(iac.Entity, true);
            Engine.object_hide(iac_bridge_outro_02.Entity, true);
            Engine.object_hide(matte_africa_coast.Entity, true);
            Engine.print("hide miranda, johnson, iac");
        }

        [ScriptMethod(296, Lifecycle.Static)]
        public async Task c01_outro_10_setup()
        {
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(iac);
            Engine.object_create_anew(iac_bridge_outro_02);
            Engine.object_create_anew(matte_africa_coast);
            Engine.object_cinematic_lod(iac.Entity, true);
            Engine.object_cinematic_lod(iac_bridge_outro_02.Entity, true);
            Engine.wake(new ScriptMethodReference(c01_outro_foley_10));
            Engine.wake(new ScriptMethodReference(c01_9220_jon));
            Engine.wake(new ScriptMethodReference(c01_9230_jon));
            Engine.wake(new ScriptMethodReference(c01_9240_mir));
            Engine.wake(new ScriptMethodReference(c01_9250_mir));
            Engine.wake(new ScriptMethodReference(save_framerate_10));
            Engine.wake(new ScriptMethodReference(carrier_explosion_tiny));
            Engine.wake(new ScriptMethodReference(carrier_explosion_medium));
            Engine.wake(new ScriptMethodReference(carrier_explosion_large));
            Engine.wake(new ScriptMethodReference(white_flash));
            Engine.wake(new ScriptMethodReference(effect_africa_explosions));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_outro_10));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_iac_ext_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_iac_interior));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_iac_ext_02));
            Engine.wake(new ScriptMethodReference(emotion_10));
        }

        [ScriptMethod(297, Lifecycle.Static)]
        public async Task c01_outro_10_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy(carrier_01.Entity);
            Engine.object_destroy_containing("iac");
            Engine.object_destroy_containing("matte");
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task c01_outro_scene_10()
        {
            await this.c01_outro_10_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4066447425U), "01_outro_10", default(IUnit), anchor_flag_outro2);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4066512962U), "chief_10", false, anchor_outro2.Entity);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\01_outro\\01_outro", 4067299406U), "miranda_10", false, anchor_outro2.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\01_outro\\01_outro", 4067364943U), "johnson_10", false, anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(carrier_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\01_outro\\01_outro", 4069920886U), "capship01_10", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_outro\\01_outro", 4072214681U), "iac_10", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(iac_bridge_outro_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\01_outro\\01_outro", 4067496017U), "iac_bridge_10", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_africa_coast.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\africa_coast\\01_outro\\01_outro", 4072280218U), "africa_coast_10", anchor_outro2.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 30));
            Engine.fade_out(0F, 0F, 0F, 30);
            await Engine.sleep(30);
            await this.c01_outro_10_cleanup();
            await Engine.sleep(30);
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task c01_outro()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.cinematic_enable_ambience_details(false);
            Engine.sound_class_set_gain("huge_ass", 0F, 30);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("01_bsp_3"));
            await Engine.sleep(1);
            await this.c01_outro_scene_01();
            await this.c01_outro_scene_02();
            await this.c01_outro_scene_03();
            await this.c01_outro_scene_04();
            await this.c01_outro_scene_05();
            await this.c01_outro_scene_06();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("01outro_bsp"));
            await Engine.sleep(1);
            await this.c01_outro_scene_07();
            await this.c01_outro_scene_08();
            await this.c01_outro_scene_09();
            await this.c01_outro_scene_10();
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(300, Lifecycle.Dormant)]
        public async Task megg_check()
        {
            if (!(await this.difficulty_legendary()))
            {
                Engine.sleep_forever();
            }

            if ((bool)Engine.game_is_cooperative())
            {
                Engine.sleep_forever();
            }

            if (!((bool)Engine.ice_cream_flavor_available(3)))
            {
                Engine.sleep_forever();
            }

            await Engine.sleep_until(async () =>
            {
                if (Engine.object_get_shield(await this.player0()) < 1F)
                {
                    Engine.print("oops");
                    Engine.sleep_forever();
                    return false;
                }
                else if (this.mark_flavor_gun)
                {
                    this.mark_flavor_megg = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }, 1);
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task ice_cream_check()
        {
            if (!(await this.difficulty_legendary()))
            {
                Engine.sleep_forever();
            }

            Engine.object_create(yorick);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4072345755U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4072345755U)), 1);
            Engine.ice_cream_flavor_stock(3);
            Engine.print("blam");
        }

        [ScriptMethod(302, Lifecycle.Static)]
        public async Task save_cutscene()
        {
            Engine.data_mine_set_mission_segment("01b_cutscene");
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task save_1st_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_1st_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task save_1st_wv4()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_1st_wv4");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(305, Lifecycle.Static)]
        public async Task save_1st_wv5_end()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_1st_wv5_end");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(306, Lifecycle.Static)]
        public async Task save_atr2_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_atr2_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(307, Lifecycle.Static)]
        public async Task save_atr2_mid()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_atr2_mid");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(308, Lifecycle.Static)]
        public async Task save_bay1_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_bay1_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(309, Lifecycle.Static)]
        public async Task save_bay1_mid()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_bay1_mid");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(310, Lifecycle.Static)]
        public async Task save_bay2_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_bay2_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(311, Lifecycle.Dormant)]
        public async Task save_bay2_retreat()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_bay2_hall, Engine.players()));
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_bay2_retreat");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task save_bay2_mid()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_bay2_mid");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(313, Lifecycle.Dormant)]
        public async Task save_bay2_fnl()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov_fnl) == 0, 1);
            Engine.game_save();
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(314, Lifecycle.Dormant)]
        public async Task save_arm_start()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(arm_cov_stl.Squad) == 0, 1);
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_arm_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task save_atr1_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_atr1_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(atr1_cov_fbalcony) <= 1 && (short)Engine.ai_living_count(atr1_cov_bbalcony) <= 1 && Engine.volume_test_objects(tv_arm_save, Engine.players()), 1);
            Engine.game_save();
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(atr1_cov_fbalcony) == 0 && (short)Engine.ai_living_count(atr1_cov_bbalcony) == 0 && (short)Engine.ai_living_count(atr1_cov_sec_front) == 0 && Engine.volume_test_objects(tv_arm_save, Engine.players()), 1);
            Engine.game_save();
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(316, Lifecycle.Static)]
        public async Task save_trm1_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_trm1_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(317, Lifecycle.Static)]
        public async Task save_dck_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_dck_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(318, Lifecycle.Static)]
        public async Task save_elv_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_elv_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(319, Lifecycle.Static)]
        public async Task save_lvr_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_lvr_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(320, Lifecycle.Static)]
        public async Task save_gun_start()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("01b_gun_start");
            this.timer_flavor = (short)Engine.max(this.timer_flavor, 10F * this.seconds);
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task title_1st()
        {
            Engine.cinematic_show_letterbox(true);
            Engine.hud_cinematic_fade(0F, 0.5F);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1st1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task title_bay2()
        {
            Engine.cinematic_show_letterbox(true);
            Engine.hud_cinematic_fade(0F, 0.5F);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_bay21);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task title_dck()
        {
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_06", 4073459884U), default(IGameObject), 1F);
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_dck1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task title_gun()
        {
            Engine.cinematic_show_letterbox(true);
            Engine.hud_cinematic_fade(0F, 0.5F);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_gun1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(325, Lifecycle.Static)]
        public async Task<int> timer_flavor_set()
        {
            return (short)Engine.random_range((short)(15 * this.seconds), (short)(30 * this.seconds));
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task<int> timer_flavor_set_long()
        {
            return (short)Engine.random_range((short)(45 * this.seconds), (short)(60 * this.seconds));
        }

        [ScriptMethod(327, Lifecycle.Static)]
        public async Task flavor_stop()
        {
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2300_lhd", 4073656495U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2310_lhd", 4073722032U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2320_lhd", 4073787569U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2330_lhd", 4073853106U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2100_lhd", 4073918643U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2250_lhd", 4073984180U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2220_lhd", 4074049717U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2190_lhd", 4074115254U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2170_lhd", 4074180791U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2060_lhd", 4074246328U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2080_lhd", 4074311865U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2160_lhd", 4074377402U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2230_lhd", 4074442939U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2210_lhd", 4074508476U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2030_lhd", 4074574013U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2000_lhd", 4074639550U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2010_lhd", 4074705087U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2400_lhd", 4074770624U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0570_cor", 4074836161U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2580_cor", 4074901698U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2590_cor", 4074967235U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2600_cor", 4075032772U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2610_cor", 4075098309U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2630_cor", 4075163846U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2640_cor", 4075229383U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2650_cor", 4075294920U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2660_cor", 4075360457U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2340_lhd", 4075425994U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2350_lhd", 4075491531U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2360_lhd", 4075557068U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2370_lhd", 4075622605U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2380_lhd", 4075688142U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2390_lhd", 4075753679U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2480_lhd", 4075819216U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2490_lhd", 4075884753U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2500_lhd", 4075950290U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2510_lhd", 4076015827U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2520_lhd", 4076081364U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2530_lhd", 4076146901U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2540_lhd", 4076212438U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2200_lhd", 4076277975U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2110_lhd", 4076343512U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2120_lhd", 4076409049U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2130_lhd", 4076474586U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2240_lhd", 4076540123U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2140_lhd", 4076605660U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2260_lhd", 4076671197U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2150_lhd", 4076736734U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2010_lhd", 4074705087U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2000_lhd", 4074639550U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2020_lhd", 4076802271U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2030_lhd", 4074574013U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2040_lhd", 4076867808U));
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task flavor_mission()
        {
            await Engine.sleep_until(async () =>
            {
                if (this.mark_flavor_disable)
                {
                    await this.flavor_stop();
                    Engine.ai_dialogue_enable(false);
                    await Engine.sleep_until(async () => !(this.mark_flavor_disable), 1);
                    await Engine.sleep((short)(5 * this.seconds));
                    Engine.ai_dialogue_enable(true);
                    this.timer_flavor = (short)Engine.max(this.timer_flavor, 5F * this.seconds);
                    return false;
                }
                else if (this.mark_flavor_vacuum)
                {
                    return false;
                }
                else if (this.timer_flavor > 0)
                {
                    this.timer_flavor = (short)(this.timer_flavor - 1);
                    return false;
                }
                else if (this.mark_flavor_brace)
                {
                    if (this.counter_flavor_brace == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2300_lhd", 4073656495U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_brace == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2310_lhd", 4073722032U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_brace == 2)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2320_lhd", 4073787569U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_brace == 3)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2330_lhd", 4073853106U), default(IGameObject), 1F, "");
                    }
                    else if (true)
                    {
                        this.counter_flavor_brace = 0;
                    }

                    await Engine.sleep((short)Engine.random_range((short)(3 * this.seconds), (short)(7 * this.seconds)));
                    Engine.damage_players(Engine.GetTag<DamageEffectTag>("effects\\scenarios\\objects\\solo\\spacestation\\boarding_craft_shake", 4076933345U));
                    Engine.print("klang!");
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_stereo", 4076998882U), default(IGameObject), 1F);
                    await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_stereo", 4076998882U)));
                    this.counter_flavor_brace = (short)(this.counter_flavor_brace + 1);
                    this.timer_flavor = await this.timer_flavor_set();
                    this.mark_flavor_brace = false;
                    return false;
                }
                else if (this.mark_flavor_dck)
                {
                    Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2100_lhd", 4073918643U), default(IGameObject), 1F, "");
                    this.mark_flavor_dck = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_trm1)
                {
                    Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2250_lhd", 4073984180U), default(IGameObject), 1F, "");
                    this.mark_flavor_trm1 = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_atr1)
                {
                    if (this.counter_flavor_atr1 == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2220_lhd", 4074049717U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr1 == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2190_lhd", 4074115254U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr1 == 2)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2170_lhd", 4074180791U), default(IGameObject), 1F, "");
                    }
                    else if (true)
                    {
                        this.mark_flavor_atr1 = false;
                    }

                    this.counter_flavor_atr1 = (short)(this.counter_flavor_atr1 + 1);
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_bay2)
                {
                    Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2060_lhd", 4074246328U), default(IGameObject), 1F, "");
                    this.mark_flavor_bay2 = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_bay1)
                {
                    Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2080_lhd", 4074311865U), default(IGameObject), 1F, "");
                    this.mark_flavor_bay1 = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_atr2)
                {
                    if (this.counter_flavor_atr2 == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2160_lhd", 4074377402U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr2 == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2230_lhd", 4074442939U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr2 == 2)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2210_lhd", 4074508476U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr2 == 3)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2030_lhd", 4074574013U), default(IGameObject), 1F, "");
                    }
                    else if (true)
                    {
                        this.mark_flavor_atr2 = false;
                    }

                    this.counter_flavor_atr2 = (short)(this.counter_flavor_atr2 + 1);
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_1st)
                {
                    if (this.counter_flavor_1st == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2000_lhd", 4074639550U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_1st == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2010_lhd", 4074705087U), default(IGameObject), 1F, "");
                    }
                    else if (true)
                    {
                        this.mark_flavor_1st = false;
                    }

                    this.counter_flavor_1st = (short)(this.counter_flavor_1st + 1);
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_megg)
                {
                    Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2400_lhd", 4074770624U), default(IGameObject), 1F, "");
                    this.mark_flavor_megg = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_bomb && (bool)Engine.game_safe_to_save())
                {
                    if (!(this.mark_flavor_safe_cycle))
                    {
                        this.mark_flavor_safe_cycle = true;
                    }
                    else if (this.counter_flavor_bomb_safe == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0570_cor", 4074836161U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2580_cor", 4074901698U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 2)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2590_cor", 4074967235U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 3)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2600_cor", 4075032772U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 4)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2610_cor", 4075098309U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 5)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2630_cor", 4075163846U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 6)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2640_cor", 4075229383U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 7)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2650_cor", 4075294920U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 8)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2660_cor", 4075360457U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (true)
                    {
                        this.counter_flavor_bomb_safe = 0;
                    }

                    this.counter_flavor_bomb_safe = (short)(this.counter_flavor_bomb_safe + 1);
                    this.timer_flavor = await this.timer_flavor_set_long();
                    return false;
                }
                else if (this.mark_flavor_bomb)
                {
                    if (this.counter_flavor_bomb == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2340_lhd", 4075425994U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2350_lhd", 4075491531U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 2)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2360_lhd", 4075557068U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 3)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2370_lhd", 4075622605U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 4)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2380_lhd", 4075688142U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 5)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2390_lhd", 4075753679U), default(IGameObject), 1F, "");
                    }
                    else if (true)
                    {
                        this.mark_flavor_bomb = false;
                    }

                    this.counter_flavor_bomb = (short)(this.counter_flavor_bomb + 1);
                    this.timer_flavor = await this.timer_flavor_set();
                    this.mark_flavor_safe_cycle = false;
                    return false;
                }
                else if (this.mark_flavor_board && (bool)Engine.game_safe_to_save())
                {
                    if (!(this.mark_flavor_safe_cycle))
                    {
                        this.mark_flavor_safe_cycle = true;
                    }
                    else if (this.counter_flavor_board_safe == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2480_lhd", 4075819216U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2490_lhd", 4075884753U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 2)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2500_lhd", 4075950290U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 3)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2510_lhd", 4076015827U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 4)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2520_lhd", 4076081364U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 5)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2530_lhd", 4076146901U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 6)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2540_lhd", 4076212438U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (true)
                    {
                        this.counter_flavor_board_safe = 0;
                    }

                    this.counter_flavor_board_safe = (short)(this.counter_flavor_board_safe + 1);
                    this.timer_flavor = await this.timer_flavor_set_long();
                    return false;
                }
                else if (this.mark_flavor_board)
                {
                    if (this.counter_flavor_board == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2200_lhd", 4076277975U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2110_lhd", 4076343512U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 2)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2120_lhd", 4076409049U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 3)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2130_lhd", 4076474586U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 4)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2240_lhd", 4076540123U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 5)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2140_lhd", 4076605660U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 6)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2260_lhd", 4076671197U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 7)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2150_lhd", 4076736734U), default(IGameObject), 1F, "");
                    }
                    else if (true)
                    {
                        this.mark_flavor_board = false;
                    }

                    this.counter_flavor_board = (short)(this.counter_flavor_board + 1);
                    this.timer_flavor = await this.timer_flavor_set();
                    this.mark_flavor_safe_cycle = false;
                    return false;
                }
                else if (this.mark_flavor_init)
                {
                    if (this.counter_flavor_init == 0)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2010_lhd", 4074705087U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_init == 1)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2000_lhd", 4074639550U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_init == 2)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2020_lhd", 4076802271U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_init == 3)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2030_lhd", 4074574013U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_init == 4)
                    {
                        Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2040_lhd", 4076867808U), default(IGameObject), 1F, "");
                    }
                    else if (true)
                    {
                        this.mark_flavor_init = false;
                    }

                    this.counter_flavor_init = (short)(this.counter_flavor_init + 1);
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (true)
                {
                    return false;
                }
            }, 1);
        }

        [ScriptMethod(329, Lifecycle.CommandScript)]
        public async Task cs_clear()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(330, Lifecycle.CommandScript)]
        public async Task cs_1st_hichief()
        {
            Engine.cs_approach_player(1.5F, 10F, 10F);
        }

        [ScriptMethod(331, Lifecycle.CommandScript)]
        public async Task cs_weapons()
        {
            await Engine.sleep((short)Engine.random_range(90, 180));
        }

        [ScriptMethod(332, Lifecycle.Dormant)]
        public async Task _1st_tram()
        {
            Engine.pvs_set_object(tram.Entity);
            Engine.object_create_anew(_1st_tram_wall_1);
            Engine.object_create_anew(_1st_tram_wall_2);
            Engine.device_set_position_immediate(tram.Entity, 1F);
            Engine.device_set_position_immediate(_1st_door_tram.Entity, 1F);
            await Engine.sleep(1);
            Engine.pvs_clear();
            Engine.ai_place(_1st_hum_tram.Squad);
            Engine.object_set_permutation(Engine.ai_get_object(_1st_hum_johnson.Squad), "helmet", "");
            await Engine.sleep(30);
            Engine.device_set_position(tram.Entity, 0F);
            await Engine.sleep(360);
            Engine.device_set_position(_1st_door_tram.Entity, 0F);
            await Engine.sleep(90);
            Engine.ai_erase(_1st_hum_tram.Squad);
            Engine.object_destroy(_1st_tram_wall_1.Entity);
            Engine.object_destroy(_1st_tram_wall_2.Entity);
            Engine.object_destroy(tram.Entity);
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task cs_1st_fieldoffire()
        {
            Engine.cs_aim_object(true, _1st_door_blast.Entity);
            Engine.sleep_forever();
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task cs_1st_johnson_deploy()
        {
            Engine.cs_face_object(true, _1st_door_blast.Entity);
            await Engine.sleep(60);
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3945531660U), "combat:missile:point", true);
            await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
            await Engine.sleep(30);
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("1st_turrets/1st_turrets_balcony"));
        }

        [ScriptMethod(335, Lifecycle.Static)]
        public async Task _1st_malta()
        {
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_01", 4077064419U), default(IGameObject), 1F);
            await Engine.sleep(30);
            Engine.print("how's it going, malta?");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0080_jon", 4077261030U), Engine.ai_get_object(_1st_hum_johnson.Squad), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0080_jon", 4077261030U)));
            await Engine.sleep(7);
            Engine.print("standby...");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0090_mm1", 4077326567U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0090_mm1", 4077326567U)));
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_mono", 4077392104U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep(5);
            Engine.print("they're latched!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0100_mm1", 4077457641U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0100_mm1", 4077457641U)));
            Engine.print("(grunts and snarls)");
            Engine.print("check your targets, watch the crossfire!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0120_mm1", 4077523178U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)((float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0120_mm1", 4077523178U)) - 60));
            Engine.object_create_anew(_1st_craft);
            Engine.device_set_position_immediate(_1st_craft.Entity, 1F);
            Engine.device_set_position(_1st_craft.Entity, 0F);
            await Engine.sleep(65);
            Engine.print("they're in standard formation: little bastards up front, big ones in back. good luck, cairo!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0130_mm1", 4077588715U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0130_mm1", 4077588715U)));
            await Engine.sleep_until(async () => Engine.device_get_position(_1st_craft.Entity) <= 0.1F, 1);
            Engine.print("klang!");
            Engine.damage_players(Engine.GetTag<DamageEffectTag>("effects\\scenarios\\objects\\solo\\spacestation\\boarding_craft_shake", 4076933345U));
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_stereo", 4076998882U), default(IGameObject), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_stereo", 4076998882U)));
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\spacestation\\ss_behind_bulkhead\\ss_behind_bulkhead", 4077654252U), _1st_door_blast.Entity, 1F);
        }

        [ScriptMethod(336, Lifecycle.Dormant)]
        public async Task _1st_waves()
        {
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\spacestation\\door_charging", 4077785326U), _1st_door_blast.Entity, "");
            await Engine.sleep(240);
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\elite\\elite", 3817538069U));
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\grunt\\grunt", 3882550773U));
            await Engine.sleep(30);
            Engine.ai_place(_1st_cov_wv1);
            await Engine.sleep(30);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 4078440696U), _1st_blast_flag_1);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\explosion_medium_metal_bits", 4078506233U), _1st_door_blast.Entity, 1F);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 4078440696U), _1st_blast_flag_2);
            await Engine.sleep(1);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\spacestation\\ss_behind_bulkhead\\ss_behind_bulkhead", 4077654252U));
            Engine.object_damage_damage_section(_1st_door_blast.Entity, "main", 1F);
            await Engine.sleep(3);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 4078440696U), _1st_blast_flag_1);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 4078440696U), _1st_blast_flag_2);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_02", 4078571770U), default(IGameObject), 1F);
            Engine.cs_run_command_script(_1st_hum, cs_clear);
            await Engine.sleep(2);
            this.mark_1st_blast = true;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(_1st_cov) < 2, 10, 300);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(_1st_cov) == 0 || (short)Engine.ai_fighting_count(_1st_cov) < 2, 10);
            Engine.ai_place(_1st_cov_wv2);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(_1st_cov) < 2, 10, 300);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(_1st_cov) == 0 || (short)Engine.ai_fighting_count(_1st_cov) < 2, 10);
            Engine.ai_place(_1st_cov_wv3);
            Engine.object_destroy(_1st_door_top.Entity);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(_1st_cov) < 2, 10, 300);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(_1st_cov) == 0 || (short)Engine.ai_fighting_count(_1st_cov) < 2, 10);
            await this.save_1st_wv4();
            await Engine.sleep(60);
            Engine.ai_place(_1st_cov_wv4);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(_1st_cov) < 2, 10, 300);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(_1st_cov) == 0 || (short)Engine.ai_fighting_count(_1st_cov) < 2, 10);
            this.mark_1st_waves_end = true;
            await this.save_1st_wv5_end();
        }

        [ScriptMethod(337, Lifecycle.Static)]
        public async Task<bool> _1st_waves_end()
        {
            if (this.mark_1st_waves_end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task _1st_mission()
        {
            Engine.print("1st");
            this.mark_flavor_init = true;
            Engine.ai_place(_1st_hum);
            Engine.ai_cannot_die(_1st_hum_johnson.Squad, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_1st_hallb, Engine.players()), 10);
            Engine.ai_set_orders(_1st_hum, _1st_hum_halla);
            Engine.device_set_position(bigrack_bsp0a_5.Entity, 1F);
            await Engine.sleep(15);
            Engine.device_set_position(bigrack_bsp0a_6.Entity, 1F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_1st_halla, Engine.players()), 10);
            Engine.ai_set_orders(_1st_hum_floor, _1st_hum_floor1);
            Engine.ai_set_orders(_1st_hum_balcony, _1st_hum_balcony1);
            Engine.ai_set_orders(_1st_hum_johnson.Squad, _1st_hum_balcony_stairs);
            this.mark_flavor_disable = true;
            await this._1st_malta();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_1st_all, Engine.players()), 10);
            Engine.cs_run_command_script(_1st_hum_johnson.Squad, cs_1st_johnson_deploy);
            await Engine.sleep(45);
            Engine.print("field of fire on that bulkhead!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0070_jon", 4078768381U), Engine.ai_get_object(_1st_hum_johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0070_jon", 4078768381U)));
            Engine.cs_queue_command_script(_1st_hum, cs_1st_fieldoffire);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(title_1st));
            await Engine.sleep(30);
            await this.save_1st_start();
            Engine.wake(new ScriptMethodReference(_1st_waves));
            Engine.print("soon as that door opens...");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0180_jon", 4078833918U), Engine.ai_get_object(_1st_hum_johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0180_jon", 4078833918U)));
            Engine.print("let 'em have it.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0190_jon", 4078899455U), Engine.ai_get_object(_1st_hum_johnson.Squad), 1F);
            Engine.objectives_show_up_to(0);
            await Engine.sleep(30);
            this.mark_flavor_disable = false;
            Engine.wake(new ScriptMethodReference(megg_check));
            await Engine.sleep_until(async () => this.mark_1st_blast && Engine.volume_test_objects(tv_1st_exit, Engine.players()), 10);
            Engine.sleep_forever(new ScriptMethodReference(_1st_waves));
            this.mark_1st_waves_end = true;
            this.mark_flavor_init = false;
            this.mark_flavor_atr2 = true;
            this.mark_flavor_board = true;
            Engine.ai_place(_1st_cov_hall);
            Engine.ai_place(_1st_hum_stairs);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr2_security_r, Engine.players()), 1);
            Engine.ai_disposable(_1st_cov, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr2_lstair, Engine.players()), 1);
            Engine.ai_disposable(_1st_hum, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2, 10);
            Engine.ai_erase(_1st_cov);
        }

        [ScriptMethod(339, Lifecycle.Dormant)]
        public async Task atr2_mission()
        {
            Engine.print("atr2");
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr2_security_r, Engine.players()), 1);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_02", 4078571770U));
            await this.save_atr2_start();
            Engine.ai_disposable(_1st_cov, true);
            Engine.ai_place(atr2_hum);
            Engine.print("hum bunker behind window");
            await Engine.sleep(5);
            Engine.ai_place(atr2_cov_floor);
            Engine.print("covenant harass below");
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr2_lstair, Engine.players()) || Engine.volume_test_objects(tv_atr2_floor_front, Engine.players()) || (float)Engine.ai_strength(atr2_cov) < 0.35F, 1);
            Engine.print("cov assault left stair");
            Engine.print("hum repel assault");
            Engine.print("cov guard hall");
            if ((short)Engine.ai_living_count(atr2_cov) < 7)
            {
                Engine.ai_place(atr2_cov_lstair);
            }
            else
            {
                Engine.ai_place(atr2_cov_lstair_elt.Squad);
                Engine.ai_place(atr2_cov_lstair_rear_elt.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr2_floor_front, Engine.players()), 1);
            this.mark_flavor_brace = true;
            Engine.print("hum take atrium floor");
            Engine.ai_place(atr2_cov_bbalcony_grt.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr2_floor_mid, Engine.players()), 1);
            await this.save_atr2_mid();
            Engine.print("cov retreat to atrium back");
            Engine.print("cov guard back balcony");
            Engine.print("cov are reenforced");
            if ((short)Engine.ai_living_count(atr2_cov) < 7)
            {
                Engine.ai_place(atr2_cov_fnl);
            }
            else
            {
                Engine.ai_place(atr2_cov_fnl_elt.Squad);
            }

            if ((short)Engine.ai_living_count(atr2_cov) < 7)
            {
                Engine.ai_place(atr2_cov_re);
            }

            Engine.device_set_position(atr2_door_re.Entity, 1F);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_01", 4077064419U));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2, 10);
            this.mark_flavor_atr2 = false;
            this.mark_flavor_bay1 = true;
            Engine.ai_disposable(atr2_cov, true);
            Engine.ai_disposable(atr2_hum, true);
            Engine.ai_erase(atr2_cov_re);
            Engine.ai_erase(atr2_cov_floor);
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task cs_lookat_malta()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_face_object(true, malta.Entity);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bay1/window"), 1F);
            Engine.sleep_forever();
        }

        [ScriptMethod(341, Lifecycle.Static)]
        public async Task bay1_malta()
        {
            Engine.print("boarder effect");
            Engine.object_damage_damage_section(malta.Entity, "default", 0.4F);
            Engine.cs_run_command_script(bay1_hum, cs_lookat_malta);
            await Engine.sleep(120);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), malta.Entity, 35F), 1, 120);
            Engine.print("hey...check it out! the malta's already driven off its boarders?!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0200_cky", 4078964992U), Engine.ai_get_object(bay1_hum), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0200_cky", 4078964992U)));
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), malta.Entity, 35F), 1, 60);
            Engine.print("malta, what is your status, over?");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0210_cor", 4079030529U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0210_cor", 4079030529U)));
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), malta.Entity, 35F), 1, 120);
            Engine.print("i don't believe it! they're retreating! we won!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0220_mm1", 4079096066U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0220_mm1", 4079096066U)));
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), malta.Entity, 35F), 1, 120);
            Engine.print("explosions!");
            Engine.object_damage_damage_section(malta.Entity, "default", 0.4F);
            await Engine.sleep(120);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), malta.Entity, 35F), 1, 120);
            Engine.print("boom!");
            Engine.object_damage_damage_section(malta.Entity, "default", 1F);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_03", 4079161603U), default(IGameObject), 1F);
            await Engine.sleep(60);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0221_cky", 4079358214U), Engine.ai_get_object(bay1_hum), 1F);
            await Engine.sleep(90);
            Engine.damage_players(Engine.GetTag<DamageEffectTag>("effects\\damage_effects\\spacestation_shockwave", 4079423751U));
        }

        [ScriptMethod(342, Lifecycle.Dormant)]
        public async Task bay1_mission()
        {
            Engine.print("bay1");
            Engine.object_create_anew(bay1_boarding_door);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_bay1_stairs, Engine.players()), 1);
            await this.save_bay1_start();
            await Engine.sleep(5);
            Engine.ai_place(bay1_hum);
            Engine.ai_place(bay1_cov_floor);
            Engine.ai_place(bay1_cov_catwalk);
            Engine.print("hum bunker below");
            Engine.print("covenant turrets above");
            Engine.print("covenant infantry below");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov_floor_elt.Squad) == 0, 10);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) <= 2 || (short)Engine.ai_fighting_count(bay1_cov) <= 1, 10);
            Engine.ai_place(bay1_cov_wv2);
            await Engine.sleep(15);
            Engine.object_destroy(bay1_boarding_door.Entity);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_bay1_boarding_tube, Engine.players())) && !(Engine.volume_test_objects(tv_bay1_boarding_tube, Engine.ai_actors(bay1_cov))), 1);
            Engine.object_create_anew(bay1_boarding_door);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) < 4, 10);
            if (await this.difficulty_normal())
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov_wv2_elt.Squad) == 0, 10);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) <= 2 || (short)Engine.ai_fighting_count(bay1_cov) <= 1, 10);
            Engine.ai_place(bay1_cov_wv3);
            await Engine.sleep(15);
            Engine.object_destroy(bay1_boarding_door.Entity);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_bay1_boarding_tube, Engine.players())) && !(Engine.volume_test_objects(tv_bay1_boarding_tube, Engine.ai_actors(bay1_cov))), 1);
            Engine.object_create_anew(bay1_boarding_door);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov_wv3_elt.Squad) == 0, 10);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) <= 2 || (short)Engine.ai_fighting_count(bay1_cov) <= 1, 10);
            if (!(await this.difficulty_normal()))
            {
                Engine.ai_place(bay1_cov_wv4);
                await Engine.sleep(15);
                Engine.object_destroy(bay1_boarding_door.Entity);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_bay1_boarding_tube, Engine.players())) && !(Engine.volume_test_objects(tv_bay1_boarding_tube, Engine.ai_actors(bay1_cov))), 1);
                Engine.object_create_anew(bay1_boarding_door);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) <= 4, 10);
            if (await this.difficulty_legendary())
            {
                await Engine.sleep((short)(15 * this.seconds));
                Engine.ai_place(bay1_cov_wv5);
                await Engine.sleep(15);
                Engine.object_destroy(bay1_boarding_door.Entity);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_bay1_boarding_tube, Engine.players())) && !(Engine.volume_test_objects(tv_bay1_boarding_tube, Engine.ai_actors(bay1_cov))), 1);
                Engine.object_create_anew(bay1_boarding_door);
            }

            this.mark_flavor_disable = true;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) <= 1, 10);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay1_cov) <= 0, 10, 900);
            await Engine.sleep_until(async () => (short)Engine.ai_fighting_count(bay1_cov) <= 0, 10);
            await this.bay1_malta();
            await this.save_bay1_mid();
            Engine.cs_run_command_script(bay1_hum, cs_clear);
            this.mark_flavor_disable = false;
            this.mark_flavor_bay1 = false;
            this.mark_flavor_bay2 = true;
            Engine.ai_place(bay1_cov_fnl);
            Engine.effect_new(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\grenade\\plasma_grenade\\detonation.effect", 4079489288U), bay1_blast_flag_1);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\plasma_grenade\\damage_effects\\plasma_grenade_explosion.damage_effect", 4080341269U), bay1_blast_flag_1);
            await Engine.sleep(2);
            Engine.effect_new(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\grenade\\plasma_grenade\\detonation.effect", 4079489288U), bay1_blast_flag_2);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\plasma_grenade\\damage_effects\\plasma_grenade_explosion.damage_effect", 4080341269U), bay1_blast_flag_2);
            Engine.object_destroy(bay1_door_exit.Entity);
            this.mark_flavor_brace = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_bay2_hall, Engine.players()), 1);
            Engine.ai_disposable(bay1_cov, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0, 10);
            Engine.ai_erase(bay1_cov);
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task cs_lookat_athens()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_face_object(true, athens.Entity);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bay2/window"), 1F);
            Engine.sleep_forever();
        }

        [ScriptMethod(344, Lifecycle.Static)]
        public async Task bay2_athens()
        {
            Engine.print("boarder effect");
            Engine.object_damage_damage_section(athens.Entity, "default", 0.4F);
            Engine.cs_run_command_script(bay1_hum, cs_lookat_athens);
            await Engine.sleep(120);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), athens.Entity, 25F), 1, 120);
            Engine.print("uh-oh. they're leaving the athens!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0230_cky", 4080406806U), default(IGameObject), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0230_cky", 4080406806U)));
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), athens.Entity, 25F), 1, 120);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_04", 4080472343U), default(IGameObject), 1F);
            Engine.print("explosions!");
            await Engine.sleep(45);
            Engine.object_damage_damage_section(athens.Entity, "default", 0.4F);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), athens.Entity, 25F), 1, 120);
            Engine.print("boom!");
            Engine.object_damage_damage_section(athens.Entity, "default", 1F);
            await Engine.sleep(90);
            Engine.damage_players(Engine.GetTag<DamageEffectTag>("effects\\damage_effects\\spacestation_shockwave", 4079423751U));
            Engine.print("cortana, assessment!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0260_lhd", 4080603417U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0260_lhd", 4080603417U)));
            Engine.print("that explosion came from inside the athens - same as the malta. the covenant must have brought something with them. a bomb.");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0270_cor", 4080668954U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0270_cor", 4080668954U)));
            Engine.print("then they sure as hell brought one here. chief, find it!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0280_lhd", 4080734491U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0280_lhd", 4080734491U)));
            Engine.objectives_finish_up_to(0);
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task bay2_mission()
        {
            Engine.print("bay2");
            Engine.object_create_anew(bay2_boarding_door);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_bay2_hall, Engine.players()), 1);
            await this.save_bay2_start();
            Engine.ai_place(bay2_hum);
            Engine.ai_place(bay2_cov_floor);
            Engine.ai_place(bay2_cov_catwalk);
            Engine.print("hum bunker below");
            Engine.print("covenant turrets above");
            Engine.print("covenant infantry below");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov_floor_elt.Squad) == 0, 10);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 2 || (short)Engine.ai_fighting_count(bay2_cov) <= 1, 10);
            Engine.ai_place(bay2_cov_wv2);
            await Engine.sleep(15);
            Engine.object_destroy(bay2_boarding_door.Entity);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_bay2_boarding_tube, Engine.players())) && !(Engine.volume_test_objects(tv_bay2_boarding_tube, Engine.ai_actors(bay2_cov))), 1);
            if (await this.difficulty_normal())
            {
                Engine.wake(new ScriptMethodReference(save_bay2_retreat));
            }

            Engine.object_create_anew(bay2_boarding_door);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov_wv2_elt.Squad) == 0, 10);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 2 || (short)Engine.ai_fighting_count(bay2_cov) <= 1, 10);
            Engine.ai_place(bay2_cov_wv3);
            await Engine.sleep(15);
            Engine.object_destroy(bay2_boarding_door.Entity);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_bay2_boarding_tube, Engine.players())) && !(Engine.volume_test_objects(tv_bay2_boarding_tube, Engine.ai_actors(bay2_cov))), 1);
            Engine.object_create_anew(bay2_boarding_door);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov_wv3_elt.Squad) == 0, 10);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 2 || (short)Engine.ai_fighting_count(bay2_cov) <= 1, 10);
            if (!(await this.difficulty_normal()))
            {
                Engine.ai_place(bay2_cov_wv4);
                await Engine.sleep(15);
                Engine.object_destroy(bay2_boarding_door.Entity);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_bay2_boarding_tube, Engine.players())) && !(Engine.volume_test_objects(tv_bay2_boarding_tube, Engine.ai_actors(bay2_cov))), 1);
                Engine.object_create_anew(bay2_boarding_door);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 4, 10);
            if (await this.difficulty_legendary())
            {
                await Engine.sleep((short)(10 * this.seconds));
                Engine.ai_place(bay2_cov_wv5);
                await Engine.sleep(15);
                Engine.object_destroy(bay2_boarding_door.Entity);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_bay2_boarding_tube, Engine.players())) && !(Engine.volume_test_objects(tv_bay2_boarding_tube, Engine.ai_actors(bay2_cov))), 1);
                Engine.object_create_anew(bay2_boarding_door);
            }

            this.mark_flavor_disable = true;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov_catwalk) == 0, 10);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 1, 10);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bay2_cov) <= 0, 10, 900);
            await Engine.sleep_until(async () => (short)Engine.ai_fighting_count(bay2_cov) <= 0, 10);
            await this.bay2_athens();
            await this.save_bay2_mid();
            Engine.wake(new ScriptMethodReference(title_bay2));
            this.mark_flavor_disable = false;
            this.mark_flavor_board = false;
            this.mark_flavor_bay2 = false;
            this.mark_flavor_bomb = true;
            Engine.ai_place(bay2_cov_fnl);
            Engine.device_operates_automatically_set(bay2_door_exit_1.Entity, true);
            Engine.device_operates_automatically_set(bay2_door_exit_2.Entity, true);
            Engine.wake(new ScriptMethodReference(save_bay2_fnl));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0, 1);
            Engine.device_set_position_immediate(bay2_door_exit_1.Entity, 0F);
            Engine.device_set_position_immediate(bay2_door_exit_2.Entity, 0F);
            Engine.device_operates_automatically_set(bay2_door_exit_1.Entity, false);
            Engine.device_operates_automatically_set(bay2_door_exit_2.Entity, false);
            Engine.ai_erase(bay2_cov);
            Engine.ai_erase(bay2_hum);
            Engine.ai_erase(bay1_hum);
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task cs_arm_guns_grate()
        {
            Engine.cs_enable_targeting(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("arm/guns"));
            Engine.sleep_forever();
        }

        [ScriptMethod(347, Lifecycle.Dormant)]
        public async Task arm_mission()
        {
            Engine.print("arm");
            await Engine.sleep(5);
            Engine.ai_place(arm_cov_stl.Squad);
            Engine.wake(new ScriptMethodReference(save_arm_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_arm_start, Engine.players()), 1);
            await Engine.sleep(3);
            Engine.ai_place(arm_hum_guns.Squad);
            Engine.ai_cannot_die(arm_hum_guns.Squad, true);
            Engine.ai_place(arm_cov_elt.Squad);
            Engine.ai_cannot_die(arm_cov_elt.Squad, true);
            this.mark_flavor_disable = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_arm_stairs, Engine.players()), 1);
            if (await this.difficulty_legendary() && (bool)Engine.game_is_cooperative())
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3400_gun", 4080800028U), Engine.ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if ((bool)Engine.game_is_cooperative())
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3390_gun", 4080865565U), Engine.ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if (await this.difficulty_legendary())
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3420_gun", 4080931102U), Engine.ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if (await this.difficulty_heroic())
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3410_gun", 4080996639U), Engine.ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if (true)
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3380_gun", 4081062176U), Engine.ai_get_object(arm_hum_guns.Squad), 1F);
            }

            await Engine.sleep(60);
            Engine.device_operates_automatically_set(arm_door_charger_1.Entity, true);
            Engine.device_operates_automatically_set(arm_door_charger_2.Entity, true);
            await Engine.sleep_until(async () => Engine.device_get_position(arm_door_charger_1.Entity) >= 0.1F || Engine.device_get_position(arm_door_charger_2.Entity) >= 0.1F, 1, 150);
            if (await this.difficulty_legendary() && (bool)Engine.game_is_cooperative() && (float)Engine.real_random_range(0F, 1F) > 0.9F)
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3450_gun", 4081127713U), Engine.ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if (true)
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3430_gun", 4081193250U), Engine.ai_get_object(arm_hum_guns.Squad), 1F);
            }

            await Engine.sleep_until(async () => Engine.device_get_position(arm_door_charger_1.Entity) >= 0.3F || Engine.device_get_position(arm_door_charger_2.Entity) >= 0.3F, 1, (int)((float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3450_gun", 4081127713U)) + (float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3430_gun", 4081193250U))));
            Engine.ai_cannot_die(arm_hum_guns.Squad, false);
            Engine.ai_cannot_die(arm_cov_elt.Squad, false);
            Engine.ai_kill(arm_hum_guns.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(arm_cov) == 0 || Engine.volume_test_objects(tv_atr1_floor, Engine.players()), 1);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_05", 4081258787U), default(IGameObject), 1F);
            this.mark_flavor_disable = false;
            this.mark_flavor_atr1 = true;
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task cs_atr1_turret_fbalcony()
        {
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("atr1_turrets/fbalcony"));
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("effects\\damage_effects\\glass_breaker", 4081455398U), fbalcony_flag);
        }

        [ScriptMethod(349, Lifecycle.CommandScript)]
        public async Task cs_atr1_turret_bbalcony()
        {
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("atr1_turrets/bbalcony"));
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("effects\\damage_effects\\glass_breaker", 4081455398U), bbalcony_flag);
        }

        [ScriptMethod(350, Lifecycle.Dormant)]
        public async Task atr1_mission()
        {
            Engine.print("atr1");
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr1_floor, Engine.players()), 1);
            Engine.wake(new ScriptMethodReference(save_atr1_start));
            await Engine.sleep(15);
            Engine.ai_place(atr1_cov_fbalcony);
            Engine.ai_place(atr1_cov_bbalcony);
            Engine.ai_place(atr1_cov_sec_front);
            this.mark_flavor_brace = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr1_mid, Engine.players()), 1);
            Engine.ai_place(atr1_cov_stairs_front);
            await Engine.sleep_until(async () => (float)Engine.ai_strength(atr1_cov_stairs) < 0.25F || Engine.volume_test_objects(tv_atr1_stairs, Engine.players()), 1);
            if ((short)Engine.ai_living_count(atr1_cov) < 6)
            {
                Engine.ai_place(atr1_cov_stairs_back);
            }
            else
            {
                Engine.ai_place(atr1_cov_stairs_back_elt.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_atr1_sec, Engine.players()), 1);
            if ((short)Engine.ai_living_count(atr1_cov) < 6)
            {
                Engine.ai_place(atr1_cov_sec_back);
            }
            else
            {
                Engine.ai_place(atr1_cov_sec_back_elt.Squad);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(atr1_cov_sec_back) == 0 || Engine.volume_test_objects(tv_trm1_floor, Engine.players()), 1);
            this.mark_flavor_atr1 = false;
            this.mark_flavor_trm1 = true;
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_05", 4081258787U));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_trm1_floor, Engine.players()), 1);
            Engine.sleep_forever(new ScriptMethodReference(save_atr1_start));
            Engine.ai_disposable(atr1_cov, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3, 10);
            Engine.ai_erase(atr1_cov);
        }

        [ScriptMethod(351, Lifecycle.CommandScript)]
        public async Task cs_trm1_bunker()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_crouch(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(352, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_player_crouch()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_crouch(true);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(353, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_miranda_crouch()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_crouch(true);
            Engine.cs_face_object(true, Engine.ai_get_object(trm1_hum_miranda.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(354, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_johnson_crouch()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_crouch(true);
            Engine.cs_face_object(true, Engine.ai_get_object(trm1_hum_johnson.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task trm1_tomyship()
        {
            Engine.cs_run_command_script(trm1_hum_johnson.Squad, cs_trm1_lookat_player_crouch);
            Engine.print("c'mon, chief! this way!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0290_jon", 4081520935U), default(IGameObject), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0290_jon", 4081520935U)));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(trm1_hum_miranda.Squad)) < 3F && Engine.objects_can_see_object(Engine.players(), Engine.ai_get_object(trm1_hum_miranda.Squad), 25F), 1, 120);
            Engine.cs_run_command_script(trm1_hum_miranda.Squad, cs_trm1_lookat_player_crouch);
            Engine.print("i was almost on-board when they showed up.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0300_mir", 4081586472U), Engine.ai_get_object(trm1_hum_miranda.Squad), 1F);
            await Engine.sleep(30);
            Engine.cs_run_command_script(trm1_hum_johnson.Squad, cs_trm1_lookat_miranda_crouch);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0300_mir", 4081586472U)));
            Engine.print("don't worry, ma'am. we'll get 'em!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0310_jon", 4081652009U), Engine.ai_get_object(trm1_hum_johnson.Squad), 1F);
            await Engine.sleep(30);
            Engine.cs_run_command_script(trm1_hum_miranda.Squad, cs_trm1_lookat_johnson_crouch);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0310_jon", 4081652009U)));
            Engine.cs_run_command_script(trm1_hum_johnson.Squad, cs_clear);
            await Engine.sleep(30);
            Engine.cs_run_command_script(trm1_hum_miranda.Squad, cs_clear);
        }

        [ScriptMethod(356, Lifecycle.CommandScript)]
        public async Task cs_trm1_approach()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_approach(await this.player0(), 2F, 6F, 3F);
            Engine.sleep_forever();
        }

        [ScriptMethod(357, Lifecycle.CommandScript)]
        public async Task cs_trm1_moveto_alock()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("trm1/alock"));
        }

        [ScriptMethod(358, Lifecycle.CommandScript)]
        public async Task cs_trm1_moveto_alock_miranda()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("trm1/alock_miranda"));
        }

        [ScriptMethod(359, Lifecycle.CommandScript)]
        public async Task cs_trm1_moveto_alock_johnson()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("trm1/alock_johnson"));
        }

        [ScriptMethod(360, Lifecycle.CommandScript)]
        public async Task cs_trm1_moveto_alock_block()
        {
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("trm1/alock_block"));
        }

        [ScriptMethod(361, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_block()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_face_object(true, Engine.ai_get_object(trm1_hum_block_mar.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(362, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_player()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(363, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_miranda()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_face_object(true, Engine.ai_get_object(trm1_hum_miranda.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(364, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_johnson()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_face_object(true, Engine.ai_get_object(trm1_hum_johnson.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(365, Lifecycle.Dormant)]
        public async Task trm1_bugproblem()
        {
            Engine.cs_run_command_script(trm1_hum_block_mar.Squad, cs_trm1_approach);
            Engine.cs_run_command_script(trm1_hum_miranda.Squad, cs_trm1_approach);
            Engine.cs_run_command_script(trm1_hum_johnson.Squad, cs_trm1_approach);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(trm1_hum_miranda.Squad)) < 2F, 1, 120);
            Engine.print("thanks, chief. i owe you one.  take me now!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0380_mir", 4081717546U), Engine.ai_get_object(trm1_hum_miranda.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0380_mir", 4081717546U)));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_trm1_block, Engine.players()), 1, 180);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), Engine.ai_get_object(trm1_hum_johnson.Squad), 40F), 1, 90);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(trm1_hum_johnson.Squad)) < 4F)
            {
                Engine.print("get going. i'll cover the commander!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0370_jon", 4081783083U), Engine.ai_get_object(trm1_hum_johnson.Squad), 1F);
            }

            Engine.cs_run_command_script(trm1_hum_miranda.Squad, cs_clear);
            Engine.cs_run_command_script(trm1_hum_johnson.Squad, cs_clear);
        }

        [ScriptMethod(366, Lifecycle.Dormant)]
        public async Task trm1_cleanup()
        {
            await Engine.sleep(90);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_trm1_start, Engine.players()) && Engine.device_get_position(trm1_door_exit.Entity) == 0F && await this.player_count() > 0, 1);
            Engine.ai_erase(atr1_cov_bbalcony);
            Engine.ai_erase(atr1_cov_fbalcony);
            Engine.ai_erase(atr1_cov_stairs);
        }

        [ScriptMethod(367, Lifecycle.Dormant)]
        public async Task trm1_mission()
        {
            Engine.print("trm1");
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_trm1_floor, Engine.players()), 1);
            this.mark_flavor_disable = true;
            Engine.object_create(trm1_tram);
            await this.save_trm1_start();
            Engine.ai_place(trm1_hum_alock);
            Engine.object_set_permutation(Engine.ai_get_object(trm1_hum_johnson.Squad), "helmet", "");
            Engine.ai_cannot_die(trm1_hum_johnson.Squad, true);
            Engine.ai_cannot_die(trm1_hum_miranda.Squad, true);
            Engine.cs_run_command_script(trm1_hum_johnson.Squad, cs_trm1_bunker);
            Engine.cs_run_command_script(trm1_hum_miranda.Squad, cs_trm1_bunker);
            Engine.ai_place(trm1_cov_alock);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_trm1_start, Engine.players()), 1);
            Engine.wake(new ScriptMethodReference(trm1_cleanup));
            await this.trm1_tomyship();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_trm1_alock, Engine.players()) || (short)Engine.ai_living_count(trm1_cov_alock) == 0, 1);
            Engine.ai_set_orders(trm1_hum_block, trm1_hum_block1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(trm1_cov_alock) == 0, 1);
            Engine.wake(new ScriptMethodReference(trm1_bugproblem));
            this.mark_flavor_disable = false;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_trm1_block, Engine.players()), 1);
            Engine.ai_place(trm1_cov_block);
            Engine.ai_magically_see_object(trm1_cov_block, await this.player0());
            Engine.ai_magically_see_object(trm1_cov_block, await this.player1());
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dck_mid, Engine.players()), 1);
            Engine.ai_set_orders(trm1_hum_alock, trm1_hum_iac);
            Engine.ai_disposable(trm1_cov_alock, true);
            Engine.ai_disposable(trm1_cov_block, true);
            Engine.ai_disposable(trm1_hum_alock, true);
            Engine.ai_disposable(trm1_hum_block, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3, 10);
            Engine.ai_erase(trm1_cov_alock);
            Engine.ai_erase(trm1_cov_block);
            Engine.ai_erase(trm1_hum_alock);
            Engine.ai_erase(trm1_hum_block);
        }

        [ScriptMethod(368, Lifecycle.Dormant)]
        public async Task dck_hog()
        {
            Engine.object_create_anew(dck_hog1);
            Engine.object_create_anew(dck_hog_rail);
            Engine.objects_attach(dck_hog_rail.Entity, "rail", dck_hog1.Entity, "");
            Engine.device_set_position_track(dck_hog_rail.Entity, "track:rail", 0F);
            Engine.device_animate_position(dck_hog_rail.Entity, 1F, 20F, 0F, 0F, true);
            await Engine.sleep((short)(200 * this.seconds));
            Engine.object_destroy(dck_hog1.Entity);
            Engine.object_destroy(dck_hog_rail.Entity);
        }

        [ScriptMethod(369, Lifecycle.Static)]
        public async Task dck_setusup()
        {
            Engine.print("sir! boarders have breached the fire-control center. they have a bomb!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0390_cor", 4081848620U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0390_cor", 4081848620U)));
            Engine.print("can you defuse it?");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0400_lhd", 4081914157U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0400_lhd", 4081914157U)));
            Engine.print("yes...but i'll need the chief's help to make contact with the detonator.");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0410_cor", 4081979694U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0410_cor", 4081979694U)));
            Engine.print("chief, get to the bomb. double-time! cortana, prioritize targets, and fire-at-will!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0450_lhd", 4082045231U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0450_lhd", 4082045231U)));
        }

        [ScriptMethod(370, Lifecycle.Dormant)]
        public async Task dck_mission()
        {
            Engine.print("dck");
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dck_start, Engine.players()), 1);
            this.mark_flavor_trm1 = false;
            this.mark_flavor_dck = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_dck_start, Engine.players()) && await this.player_count() > 0, 1, 90);
            Engine.volume_teleport_players_not_inside(tv_dck_start, dck_enter_flag);
            Engine.object_create(dck_wall_enter);
            Engine.device_set_position(dck_door_arm_1.Entity, 0F);
            await this.save_dck_start();
            Engine.wake(new ScriptMethodReference(title_dck));
            await Engine.sleep(45);
            Engine.device_set_position(dck_door_arm_2.Entity, 1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\ss_airlock\\airlock", 4082110768U), default(IGameObject), 1F);
            await Engine.sleep(45);
            Engine.physics_set_gravity(0.75F);
            Engine.set_global_sound_environment(1F, 1F, 0F, 0F, 1000, 5F);
            this.mark_flavor_vacuum = true;
            Engine.ai_place(dck_cov_enter_elt.Squad);
            Engine.ai_place(dck_cov_arm1_elt.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dck_arm1_back, Engine.players()), 1);
            Engine.wake(new ScriptMethodReference(dck_hog));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dck_mid, Engine.players()) || (float)Engine.ai_strength(dck_cov) <= 0.3F, 1);
            Engine.ai_place(dck_cov_arm2);
            Engine.ai_magically_see_object(dck_cov_arm2, await this.player0());
            Engine.ai_magically_see_object(dck_cov_arm2, await this.player1());
            this.mark_flavor_disable = true;
            await Engine.sleep(150);
            await this.dck_setusup();
            this.mark_flavor_disable = false;
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3, 10);
            Engine.ai_erase(dck_cov);
        }

        [ScriptMethod(371, Lifecycle.Dormant)]
        public async Task elv_goinloud()
        {
            Engine.sleep_forever(new ScriptMethodReference(dck_setusup));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0390_cor", 4081848620U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0400_lhd", 4081914157U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0410_cor", 4081979694U));
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0450_lhd", 4082045231U));
            this.mark_flavor_disable = true;
            Engine.print("first echelon, you're with me. blanket those cruisers - take 'em out one-by-one. second echelon, keep those carriers busy!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0470_ahp", 4082176305U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0470_ahp", 4082176305U)));
            await Engine.sleep(15);
            Engine.print("registering all hostile vessels inside the kill-zone. thirteen cruisers, two assault-carriers. i'm going loud!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0460_cor", 4082241842U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0460_cor", 4082241842U)));
            await Engine.sleep_until(async () => Engine.objects_can_see_flag(Engine.players(), macgun_flag, 25F), 1, 120);
            Engine.device_set_power(macgun.Entity, 1F);
            Engine.device_set_power(gun_loader.Entity, 1F);
            this.mark_flavor_disable = false;
            await this.save_elv_start();
        }

        [ScriptMethod(372, Lifecycle.Static)]
        public async Task<bool> elv_elevator_test()
        {
            return Engine.device_get_position(elv_elevator.Entity) > 0.8F;
        }

        [ScriptMethod(373, Lifecycle.Static)]
        public async Task<bool> elv_elevator_down()
        {
            return Engine.volume_test_objects_all(tv_elevator, Engine.players());
        }

        [ScriptMethod(374, Lifecycle.Dormant)]
        public async Task elv_mission()
        {
            Engine.print("elv");
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3, 1);
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\marine\\marine", 3940485311U));
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\bugger\\bugger", 4020964747U));
            Engine.set_global_sound_environment(1F, 1F, 1F, 1F, 8000, 0F);
            Engine.physics_set_gravity(1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\ss_airlock\\airlock_repressurize", 4082307379U), default(IGameObject), 1F);
            this.mark_flavor_vacuum = false;
            Engine.device_operates_automatically_set(bsp3_door_backward.Entity, false);
            Engine.device_operates_automatically_set(bsp3_door_backward_2.Entity, false);
            Engine.device_operates_automatically_set(bsp3_door_forward.Entity, true);
            Engine.objects_attach(elv_elevator.Entity, "control_1", elv_elevator_control_1.Entity, "");
            Engine.objects_attach(elv_elevator.Entity, "control_2", elv_elevator_control_2.Entity, "");
            await this.save_elv_start();
            Engine.wake(new ScriptMethodReference(elv_goinloud));
            Engine.ai_place(elv_hum_mar.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_elv_start, Engine.players()), 1);
            Engine.ai_place(elv_cov_top);
            await Engine.sleep(30);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_07", 4082372916U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => (float)Engine.ai_strength(elv_cov) <= 0.35F, 10);
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\grunt\\grunt", 3882550773U));
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\elite\\elite", 3817538069U));
            await Engine.sleep(15);
            Engine.ai_place(elv_cov_elevator);
            await Engine.sleep(5);
            Engine.device_set_position(lvr_door_enter_1.Entity, 1F);
            Engine.device_set_power(elv_elevator_control_1.Entity, 1F);
            Engine.device_set_power(elv_elevator_control_2.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(lvr_door_enter_1.Entity) == 1F, 1);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_elevator, Engine.ai_actors(elv_cov_elevator)), 1, (int)(20 * this.seconds));
            Engine.device_set_position(elv_elevator.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_group_get(elv_elevator_position) > 0F, 1, (int)(120 * this.seconds));
            Engine.device_set_position(elv_elevator.Entity, 0F);
            Engine.device_set_power(elv_elevator_control_1.Entity, 0F);
            Engine.device_set_power(elv_elevator_control_2.Entity, 0F);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_lvr_enter, Engine.players()), 1);
            Engine.ai_disposable(elv_cov, true);
            Engine.ai_disposable(elv_hum_mar.Squad, true);
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task lvr_carrier_flyby()
        {
            Engine.object_create(carrier_01);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenery\\solids\\human_fleet_ships_attack_carrier", 4082503990U), carrier_01.Entity, "bow");
            Engine.scenery_animation_start_relative(carrier_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\spacestation\\spacestation", 4083224897U), "capital_ship_01", flyby.Entity);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\spacestation\\cap_ship_flyover", 4083290434U), lvr_flyby_flag.Entity, 1F);
            await Engine.sleep(330);
            Engine.damage_players(Engine.GetTag<DamageEffectTag>("effects\\damage_effects\\carrier_flyby", 4083355971U));
            await Engine.sleep_until(async () => Engine.scenery_get_animation_time(carrier_01.Entity) == 0, 1);
            Engine.object_destroy(carrier_01.Entity);
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task lvr_carriers()
        {
            this.mark_flavor_disable = true;
            Engine.print("the carriers are breaking-through, sir! they're heading straight for the cairo!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0500_ahp", 4083421508U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0500_ahp", 4083421508U)));
            await Engine.sleep(7);
            Engine.print("cortana, concentrate your fire on the first carrier! admiral, do what you can against the second!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0510_lhd", 4083487045U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0510_lhd", 4083487045U)));
            await Engine.sleep(8);
            Engine.print("everyone form-up! follow my lead!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0520_ahp", 4083552582U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0520_ahp", 4083552582U)));
            this.mark_flavor_disable = false;
            await this.save_lvr_start();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_lvr_back, Engine.players()), 1, (int)(15 * this.seconds));
            this.mark_flavor_disable = true;
            Engine.print("the first carrier completely ignored us, sir - blew through the malta's debris-field, and headed straight for earth!");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0530_cor", 4083618119U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0530_cor", 4083618119U)));
            this.mark_flavor_disable = false;
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task lvr_mission()
        {
            Engine.print("lvr");
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_lvr_enter, Engine.players()) && await this.player_count() > 0, 1);
            Engine.object_create(lvr_wall_enter);
            Engine.device_set_position(lvr_door_enter_1.Entity, 0F);
            Engine.wake(new ScriptMethodReference(lvr_carriers));
            await Engine.sleep_until(async () => Engine.device_get_position(lvr_door_enter_1.Entity) == 0F, 1);
            Engine.ai_erase(elv_cov_top);
            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save(), 1, 150);
            await this.save_lvr_start();
            await Engine.sleep(30);
            Engine.ai_place(lvr_cov_wv1);
            Engine.wake(new ScriptMethodReference(lvr_carrier_flyby));
            Engine.device_set_position(lvr_door_enter_2.Entity, 1F);
            Engine.device_set_power(lvr_airlock_blower.Entity, 1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\ss_airlock\\airlock", 4082110768U), default(IGameObject), 1F);
            await Engine.sleep(30);
            Engine.physics_set_gravity(0.75F);
            this.mark_flavor_vacuum = true;
            Engine.biped_ragdoll(lvr_body_1.Entity);
            Engine.biped_ragdoll(lvr_body_2.Entity);
            await Engine.sleep(60);
            Engine.set_global_sound_environment(1F, 1F, 0F, 0F, 1000, 5F);
            Engine.device_set_power(lvr_airlock_blower.Entity, 0F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_lvr_back, Engine.players()), 1);
            if (!(await this.difficulty_normal()))
            {
                Engine.ai_place(lvr_cov_wv2);
            }

            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), gun_elevator_door_top.Entity) < 4F, 1);
            Engine.device_operates_automatically_set(gun_elevator_door_top.Entity, true);
            Engine.device_set_position_immediate(gun_elevator.Entity, 0.1F);
            Engine.device_set_position(gun_elevator.Entity, 0F);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_gun_elevator, Engine.players()) && await this.player_count() > 0, 1);
            Engine.object_create(gun_wall_enter);
            Engine.sleep_forever(new ScriptMethodReference(lvr_carriers));
            this.mark_flavor_disable = true;
            Engine.device_set_position(gun_elevator.Entity, 1F);
            Engine.ai_disposable(gun_cov, true);
            Engine.physics_set_gravity(1F);
            Engine.set_global_sound_environment(1F, 1F, 1F, 1F, 8000, 0F);
            this.mark_flavor_vacuum = false;
            await Engine.sleep(30);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\ss_airlock\\airlock_repressurize", 4082307379U), default(IGameObject), 1F);
            await Engine.sleep(30);
            Engine.print("there's quite a lot of elites in here, you may need to get creative.");
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_4000_cor", 4083683656U), default(IGameObject), 1F, "radio_default");
            await Engine.sleep((short)((float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_4000_cor", 4083683656U)) - 60));
            Engine.wake(new ScriptMethodReference(title_gun));
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_08", 4083749193U), default(IGameObject), 1F);
            this.mark_flavor_disable = false;
            Engine.ai_erase(lvr_cov);
        }

        [ScriptMethod(378, Lifecycle.CommandScript)]
        public async Task cs_expand_cortana()
        {
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.01F, 1);
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\teleport_in", 4084142415U), Engine.ai_get_object(this.ai_current_actor), "body");
            await Engine.sleep(1);
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.4F, 20);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(379, Lifecycle.CommandScript)]
        public async Task cs_shrink_cortana()
        {
            Engine.cs_enable_dialogue(false);
            await Engine.sleep(60);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\teleport_out", 4084535637U), Engine.ai_get_object(this.ai_current_actor), "body");
            await Engine.sleep(3);
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.01F, 20);
            await Engine.sleep(30);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task gun_flyby()
        {
            Engine.object_create(carrier_02);
            Engine.scenery_animation_start_relative(carrier_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\spacestation\\spacestation", 4083224897U), "capital_ship_02", anchor_outro1.Entity);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenery\\solids\\human_fleet_ships_attack_carrier", 4082503990U), carrier_02.Entity, "bow");
            await Engine.sleep(330);
            Engine.damage_players(Engine.GetTag<DamageEffectTag>("effects\\damage_effects\\carrier_flyby", 4083355971U));
            await Engine.sleep_until(async () => Engine.scenery_get_animation_time(carrier_02.Entity) == 0, 1);
            Engine.object_destroy(carrier_02.Entity);
        }

        [ScriptMethod(381, Lifecycle.Static)]
        public async Task gun_mission()
        {
            Engine.print("gun");
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\grunt\\grunt", 3882550773U));
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\elite\\elite", 3817538069U));
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_elv_enter, Engine.players()) && await this.player_count() > 0, 1);
            this.mark_flavor_dck = false;
            this.mark_flavor_gun = true;
            Engine.object_create(gun_wall_enter);
            await this.save_gun_start();
            Engine.ai_place(gun_cov);
            Engine.ai_place(gun_hum_mar.Squad);
            Engine.wake(new ScriptMethodReference(gun_flyby));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(gun_cov) <= 4, 1);
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_08", 4083749193U), true);
            this.mark_flavor_vacuum = true;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(gun_cov) == 0, 1);
            this.mark_flavor_bomb = false;
            this.mark_flavor_disable = true;
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_08", 4083749193U));
            await Engine.sleep(150);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), pickle.Entity) < 4F, 1, 150);
            this.mark_bomb2_objective = true;
        }

        [ScriptMethod(382, Lifecycle.Static)]
        public async Task load_bsp0a()
        {
            Engine.object_create_anew(rack_bsp0a_1_smg_1);
            Engine.objects_attach(rack_bsp0a_1.Entity, "smg_1", rack_bsp0a_1_smg_1.Entity, "");
            Engine.object_create_anew(rack_bsp0a_1_smg_2);
            Engine.objects_attach(rack_bsp0a_1.Entity, "smg_2", rack_bsp0a_1_smg_2.Entity, "");
            Engine.object_create_anew(rack_bsp0a_2_br_1);
            Engine.objects_attach(rack_bsp0a_2.Entity, "br_2", rack_bsp0a_2_br_1.Entity, "");
            Engine.object_create_anew(rack_bsp0a_2_br_2);
            Engine.objects_attach(rack_bsp0a_2.Entity, "br_3", rack_bsp0a_2_br_2.Entity, "");
            Engine.object_create_anew(rack_bsp0a_3_smg_1);
            Engine.objects_attach(rack_bsp0a_3.Entity, "smg_1", rack_bsp0a_3_smg_1.Entity, "");
            Engine.object_create_anew(rack_bsp0a_3_smg_2);
            Engine.objects_attach(rack_bsp0a_3.Entity, "smg_2", rack_bsp0a_3_smg_2.Entity, "");
            Engine.object_create_anew(rack_bsp0a_4_br_1);
            Engine.objects_attach(rack_bsp0a_4.Entity, "br_2", rack_bsp0a_4_br_1.Entity, "");
            Engine.object_create_anew(rack_bsp0a_4_br_2);
            Engine.objects_attach(rack_bsp0a_4.Entity, "br_4", rack_bsp0a_4_br_2.Entity, "");
            Engine.object_create_anew(rack_bsp0a_5_smg_1);
            Engine.objects_attach(rack_bsp0a_5.Entity, "smg_1", rack_bsp0a_5_smg_1.Entity, "");
            Engine.object_create_anew(rack_bsp0a_5_smg_2);
            Engine.objects_attach(rack_bsp0a_5.Entity, "smg_3", rack_bsp0a_5_smg_2.Entity, "");
            Engine.object_create_anew(rack_bsp0a_5_smg_3);
            Engine.objects_attach(rack_bsp0a_5.Entity, "smg_4", rack_bsp0a_5_smg_3.Entity, "");
            Engine.object_create_anew(rack_bsp0a_6_br_1);
            Engine.objects_attach(rack_bsp0a_6.Entity, "br_1", rack_bsp0a_6_br_1.Entity, "");
            Engine.object_create_anew(rack_bsp0a_6_br_2);
            Engine.objects_attach(rack_bsp0a_6.Entity, "br_2", rack_bsp0a_6_br_2.Entity, "");
            Engine.object_create_anew(rack_bsp0a_6_br_3);
            Engine.objects_attach(rack_bsp0a_6.Entity, "br_4", rack_bsp0a_6_br_3.Entity, "");
            Engine.object_create_anew(bigrack_bsp0a_5_smg_1);
            Engine.objects_attach(bigrack_bsp0a_5.Entity, "gun_r_01", bigrack_bsp0a_5_smg_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0a_5_smg_2);
            Engine.objects_attach(bigrack_bsp0a_5.Entity, "gun_r_03", bigrack_bsp0a_5_smg_2.Entity, "");
            Engine.object_create_anew(bigrack_bsp0a_5_smg_3);
            Engine.objects_attach(bigrack_bsp0a_5.Entity, "gun_l_02", bigrack_bsp0a_5_smg_3.Entity, "");
            Engine.object_create_anew(bigrack_bsp0a_6_smg_1);
            Engine.objects_attach(bigrack_bsp0a_6.Entity, "gun_l_02", bigrack_bsp0a_6_smg_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0a_6_smg_2);
            Engine.objects_attach(bigrack_bsp0a_6.Entity, "gun_r_03", bigrack_bsp0a_6_smg_2.Entity, "");
        }

        [ScriptMethod(383, Lifecycle.Static)]
        public async Task load_bsp2()
        {
            Engine.object_create_anew(rack_bsp2_1_smg_1);
            Engine.objects_attach(rack_bsp2_1.Entity, "smg_1", rack_bsp2_1_smg_1.Entity, "");
            Engine.object_create_anew(rack_bsp2_1_smg_2);
            Engine.objects_attach(rack_bsp2_1.Entity, "smg_2", rack_bsp2_1_smg_2.Entity, "");
            Engine.object_create_anew(rack_bsp2_1_smg_3);
            Engine.objects_attach(rack_bsp2_1.Entity, "smg_3", rack_bsp2_1_smg_3.Entity, "");
        }

        [ScriptMethod(384, Lifecycle.Static)]
        public async Task load_bsp0b()
        {
            Engine.object_create_anew(rack_bsp0b_1_br_1);
            Engine.objects_attach(rack_bsp0b_1.Entity, "br_1", rack_bsp0b_1_br_1.Entity, "");
            Engine.object_create_anew(rack_bsp0b_1_br_2);
            Engine.objects_attach(rack_bsp0b_1.Entity, "br_3", rack_bsp0b_1_br_2.Entity, "");
            Engine.object_create_anew(rack_bsp0b_2_smg_1);
            Engine.objects_attach(rack_bsp0b_2.Entity, "smg_2", rack_bsp0b_2_smg_1.Entity, "");
            Engine.object_create_anew(rack_bsp0b_2_smg_2);
            Engine.objects_attach(rack_bsp0b_2.Entity, "smg_4", rack_bsp0b_2_smg_2.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_1_br_1);
            Engine.objects_attach(bigrack_bsp0b_1.Entity, "gun_l_01", bigrack_bsp0b_1_br_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_1_br_2);
            Engine.objects_attach(bigrack_bsp0b_1.Entity, "gun_r_02", bigrack_bsp0b_1_br_2.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_2_br_1);
            Engine.objects_attach(bigrack_bsp0b_2.Entity, "gun_l_03", bigrack_bsp0b_2_br_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_3_br_1);
            Engine.objects_attach(bigrack_bsp0b_3.Entity, "gun_l_02", bigrack_bsp0b_3_br_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_3_br_2);
            Engine.objects_attach(bigrack_bsp0b_3.Entity, "gun_r_01", bigrack_bsp0b_3_br_2.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_4_br_1);
            Engine.objects_attach(bigrack_bsp0b_4.Entity, "gun_r_02", bigrack_bsp0b_4_br_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_5_smg_1);
            Engine.objects_attach(bigrack_bsp0b_5.Entity, "gun_r_01", bigrack_bsp0b_5_smg_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_6_smg_1);
            Engine.objects_attach(bigrack_bsp0b_6.Entity, "gun_l_03", bigrack_bsp0b_6_smg_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_6_smg_2);
            Engine.objects_attach(bigrack_bsp0b_6.Entity, "gun_r_02", bigrack_bsp0b_6_smg_2.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_7_smg_1);
            Engine.objects_attach(bigrack_bsp0b_7.Entity, "gun_r_03", bigrack_bsp0b_7_smg_1.Entity, "");
            Engine.object_create_anew(bigrack_bsp0b_8_smg_1);
            Engine.objects_attach(bigrack_bsp0b_8.Entity, "gun_l_01", bigrack_bsp0b_8_smg_1.Entity, "");
            Engine.object_create_anew(atr1_elevator);
        }

        [ScriptMethod(385, Lifecycle.Static)]
        public async Task load_bsp3()
        {
            Engine.object_create_anew(rack_bsp3_1_br_1);
            Engine.objects_attach(rack_bsp3_1.Entity, "br_1", rack_bsp3_1_br_1.Entity, "");
            Engine.object_create_anew(rack_bsp3_1_br_2);
            Engine.objects_attach(rack_bsp3_1.Entity, "br_3", rack_bsp3_1_br_2.Entity, "");
            Engine.object_create_anew(rack_bsp3_2_smg_1);
            Engine.objects_attach(rack_bsp3_2.Entity, "smg_2", rack_bsp3_2_smg_1.Entity, "");
            Engine.object_create_anew(rack_bsp3_2_smg_2);
            Engine.objects_attach(rack_bsp3_2.Entity, "smg_4", rack_bsp3_2_smg_2.Entity, "");
            Engine.object_create_anew(rack_bsp3_4_br_1);
            Engine.objects_attach(rack_bsp3_4.Entity, "br_2", rack_bsp3_4_br_1.Entity, "");
            Engine.object_create_anew(rack_bsp3_4_br_2);
            Engine.objects_attach(rack_bsp3_4.Entity, "br_2", rack_bsp3_4_br_2.Entity, "");
            Engine.object_create_anew(rack_bsp3_5_smg_1);
            Engine.objects_attach(rack_bsp3_5.Entity, "smg_3", rack_bsp3_5_smg_1.Entity, "");
        }

        [ScriptMethod(386, Lifecycle.Static)]
        public async Task mission_start()
        {
            Engine.print("01b spacestation");
            Engine.print("designer - jaime");
            Engine.print("env. artsits - paul, dave");
        }

        [ScriptMethod(387, Lifecycle.Static)]
        public async Task mission_setup()
        {
            Engine.objectives_clear();
            Engine.game_can_use_flashlights(false);
            Engine.ai_allegiance(player, human);
            Engine.ai_allegiance(covenant, prophet);
            Engine.ai_allegiance(prophet, covenant);
            Engine.device_set_position_immediate(macgun.Entity, 0F);
            Engine.device_set_position_immediate(gun_loader.Entity, 0F);
            Engine.device_set_power(macgun.Entity, 0F);
            Engine.device_set_power(gun_loader.Entity, 0F);
            Engine.object_create(malta);
            Engine.object_create(athens);
        }

        [ScriptMethod(388, Lifecycle.Startup)]
        public async Task mission_spacestation()
        {
            if (await this.player_count() == 0)
            {
                Engine.sleep_forever();
            }

            await this.cinematic_snap_to_white();
            await this.save_cutscene();
            if (await this.cinematic_skip_start())
            {
                await this.cinematic_stash_players();
                await this.x02();
                await this.cinematic_unstash_players();
            }

            await this.cinematic_skip_stop();
            Engine.object_type_predict(Engine.GetTag<BaseTag>("scenarios\\objects\\solo\\spacestation\\ss_tram_car\\ss_tram_car", 4084601174U));
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.mission_start();
            await this.mission_setup();
            await this.load_bsp0a();
            Engine.wake(new ScriptMethodReference(flavor_mission));
            Engine.wake(new ScriptMethodReference(_1st_mission));
            Engine.wake(new ScriptMethodReference(atr2_mission));
            Engine.wake(new ScriptMethodReference(_1st_tram));
            await Engine.sleep(1);
            await this.cinematic_fade_from_white();
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2, 1);
            await this.load_bsp2();
            Engine.device_operates_automatically_set(bsp2_door_forward.Entity, true);
            Engine.wake(new ScriptMethodReference(bay1_mission));
            Engine.wake(new ScriptMethodReference(bay2_mission));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0, 1);
            await this.load_bsp0b();
            Engine.wake(new ScriptMethodReference(ice_cream_check));
            Engine.wake(new ScriptMethodReference(arm_mission));
            Engine.wake(new ScriptMethodReference(atr1_mission));
            Engine.wake(new ScriptMethodReference(trm1_mission));
            Engine.wake(new ScriptMethodReference(dck_mission));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3, 1);
            await this.load_bsp3();
            Engine.wake(new ScriptMethodReference(elv_mission));
            Engine.wake(new ScriptMethodReference(lvr_mission));
            await this.gun_mission();
            await this.playtest_mission();
            await this.save_cutscene();
            await this.cinematic_fade_to_white();
            Engine.device_set_power(gun_loader.Entity, 0F);
            Engine.device_set_power(macgun.Entity, 0F);
            await Engine.sleep(45);
            if (await this.cinematic_skip_start())
            {
                await this.cinematic_stash_players();
                await this.c01_outro();
                await this.cinematic_unstash_players();
            }

            await this.cinematic_skip_stop();
            Engine.game_won();
        }

        [ScriptMethod(389, Lifecycle.Static)]
        public async Task cheat_atr2()
        {
            Engine.switch_bsp(0);
            Engine.object_teleport(await this.player0(), atr2_flag);
        }

        [ScriptMethod(390, Lifecycle.Static)]
        public async Task cheat_bay1()
        {
            Engine.switch_bsp(2);
            Engine.object_teleport(await this.player0(), bay1_flag);
        }

        [ScriptMethod(391, Lifecycle.Static)]
        public async Task cheat_bay2()
        {
            Engine.switch_bsp(2);
            Engine.object_teleport(await this.player0(), bay2_flag);
        }

        [ScriptMethod(392, Lifecycle.Static)]
        public async Task cheat_arm()
        {
            Engine.switch_bsp(0);
            Engine.object_teleport(await this.player0(), arm_flag);
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task cheat_atr1()
        {
            Engine.switch_bsp(0);
            Engine.wake(new ScriptMethodReference(mission_spacestation));
            Engine.object_teleport(await this.player0(), atr1_flag);
        }

        [ScriptMethod(394, Lifecycle.Static)]
        public async Task cheat_trm1()
        {
            Engine.switch_bsp(0);
            Engine.wake(new ScriptMethodReference(mission_spacestation));
            Engine.object_teleport(await this.player0(), trm1_flag);
        }

        [ScriptMethod(395, Lifecycle.Static)]
        public async Task cheat_elv()
        {
            Engine.switch_bsp(3);
            Engine.wake(new ScriptMethodReference(mission_spacestation));
            Engine.wake(new ScriptMethodReference(mission_spacestation));
            Engine.object_teleport(await this.player0(), elv_flag);
        }

        [ScriptMethod(396, Lifecycle.Static)]
        public async Task cheat_lvr()
        {
            Engine.switch_bsp(3);
            Engine.wake(new ScriptMethodReference(mission_spacestation));
            Engine.wake(new ScriptMethodReference(mission_spacestation));
            Engine.object_teleport(await this.player0(), lvr_flag);
        }

        [ScriptMethod(397, Lifecycle.Static)]
        public async Task cheat_gun()
        {
            Engine.switch_bsp(3);
            Engine.wake(new ScriptMethodReference(mission_spacestation));
            Engine.wake(new ScriptMethodReference(mission_spacestation));
            Engine.object_teleport(await this.player0(), gun_flag);
        }

        [ScriptMethod(398, Lifecycle.Dormant)]
        public async Task x02_01_predict()
        {
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 59, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 61, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 75, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 85, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 92, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 95, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 97, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 98, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 101, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 102, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 104, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 106, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 69, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 89, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 91, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 86, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 11, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\ss_prop", 4088271246U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 87, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 100, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 96, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 103, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 110, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4088664468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787849808U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack_slim\\ss_gun_rack_slim", 4090696115U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\case_ap_turret\\case_ap_turret", 4091220411U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 4091744707U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack\\ss_gun_rack", 4091941318U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 34, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\chair_sofa\\chair_sofa", 4092203466U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\case\\case", 4092465614U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4092662225U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 4092924373U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3782934533U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 87, false);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 33, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_internet_kiosk\\ss_internet_kiosk", 4093120984U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\case_ap_turret\\case_ap_turret", 4091220411U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack\\ss_gun_rack", 4091941318U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4094366187U), 0);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\news_drone\\news_drone", 4094693872U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4092662225U), 0);
            await Engine.sleep(156);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 73, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 107, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 89, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 51);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 44);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack_slim\\ss_gun_rack_slim", 4090696115U), 0);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 63, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 63, true);
            await Engine.sleep(90);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 101, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 47, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 48, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 56, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 62, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 50);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_internet_kiosk\\ss_internet_kiosk", 4093120984U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_tram\\ss_door_tram", 4095545853U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4095808001U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 26, false);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 72, false);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 5, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            await Engine.sleep(57);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 32, true);
            await Engine.sleep(57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 4099346999U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 4099871295U), 0);
        }

        [ScriptMethod(399, Lifecycle.Dormant)]
        public async Task x02_02_predict()
        {
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            await Engine.sleep(8);
            await Engine.sleep(49);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(32);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 4100330054U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4104196737U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4104786570U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4105048718U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4105507477U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4092662225U), 0);
            await Engine.sleep(149);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            await Engine.sleep(55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 4100330054U), 8);
            await Engine.sleep(87);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 4099871295U), 0);
            await Engine.sleep(64);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 4099871295U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4104786570U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4105507477U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4092662225U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\crowds\\crowd_front_a\\crowd_front_a", 4106228384U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\crowds\\crowd_front_b\\crowd_front_b", 4106621606U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\crowds\\crowd_front_c\\crowd_front_c", 4106687143U), 0);
            await Engine.sleep(154);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 4100330054U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 4099871295U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4104196737U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4104786570U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4105048718U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4105507477U), 0);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            await Engine.sleep(89);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
        }

        [ScriptMethod(400, Lifecycle.Dormant)]
        public async Task x02_03_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 34);
            await Engine.sleep(131);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            await Engine.sleep(79);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            await Engine.sleep(50);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4105507477U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4094366187U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\fixed\\h_turret_mp\\h_turret_mp", 4106752680U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\fixed\\plasma_cannon\\plasma_cannon", 4107145902U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\fixed\\plasma_cannon\\plasma_cannon", 4107145902U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 8);
            await Engine.sleep(36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4095808001U), 0);
            await Engine.sleep(84);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 18, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4092662225U), 0);
            await Engine.sleep(25);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, true);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 1);
            await Engine.sleep(57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4104196737U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4105048718U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 73);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 65);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4109046475U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4109243086U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
        }

        [ScriptMethod(401, Lifecycle.Dormant)]
        public async Task x02_04a_predict()
        {
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, false);
            await Engine.sleep(20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            await Engine.sleep(19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            await Engine.sleep(106);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4109243086U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            await Engine.sleep(18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            await Engine.sleep(34);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            await Engine.sleep(34);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            await Engine.sleep(66);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 65);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 73);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4109243086U), 0);
            await Engine.sleep(160);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 2);
            await Engine.sleep(95);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
        }

        [ScriptMethod(402, Lifecycle.Dormant)]
        public async Task x02_04b_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4109243086U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4109046475U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\colonial_cross\\colonial_cross", 4109701845U), 0);
            await Engine.sleep(81);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            await Engine.sleep(36);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            await Engine.sleep(66);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4109243086U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\colonial_cross\\colonial_cross", 4109701845U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4109046475U), 0);
            await Engine.sleep(107);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            await Engine.sleep(124);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4104196737U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4104786570U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4105507477U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 32);
        }

        [ScriptMethod(403, Lifecycle.Dormant)]
        public async Task x02_05_predict()
        {
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 4109963993U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 4109963993U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 4100330054U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 24);
            await Engine.sleep(59);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4092662225U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(129);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            await Engine.sleep(36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 28);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3817669143U), 32);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4105507477U), 0);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4104196737U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4109046475U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 73);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 65);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4109243086U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\colonial_cross\\colonial_cross", 4109701845U), 0);
        }

        [ScriptMethod(404, Lifecycle.Dormant)]
        public async Task x02_06_predict()
        {
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            await Engine.sleep(7);
            await Engine.sleep(27);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            await Engine.sleep(29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 2);
            await Engine.sleep(41);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            await Engine.sleep(101);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            await Engine.sleep(98);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            await Engine.sleep(131);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4109636308U), 2);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            await Engine.sleep(118);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4094366187U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\fixed\\h_turret_mp\\h_turret_mp", 4106752680U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784048662U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\branding_iron\\branding_iron", 4111078122U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4104786570U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\elite_helmet_charred\\elite_helmet_charred", 4111536881U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 34);
        }

        [ScriptMethod(405, Lifecycle.Dormant)]
        public async Task x02_07_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            await Engine.sleep(9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4111733492U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4111733492U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4111733492U), 13);
            await Engine.sleep(71);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4104196737U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4105048718U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4105507477U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(130);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            await Engine.sleep(57);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4111733492U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4111733492U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4111733492U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4104196737U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4102230627U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4105048718U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4105114255U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4105507477U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4105179792U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 0);
            await Engine.sleep(75);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4096201223U), 34);
            await Engine.sleep(62);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4104196737U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4105048718U), 0);
            await Engine.sleep(76);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            await Engine.sleep(55);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4098167333U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\holo_display_large", 4113371917U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4109046475U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 65);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 73);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 8);
        }

        [ScriptMethod(406, Lifecycle.Dormant)]
        public async Task x02_08_predict()
        {
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            await Engine.sleep(70);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\holo_display_large", 4113371917U), 0);
            await Engine.sleep(78);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 4);
            await Engine.sleep(30);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 65);
            await Engine.sleep(128);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            await Engine.sleep(107);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 65);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 73);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            await Engine.sleep(117);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3882681847U), 4);
            await Engine.sleep(33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            await Engine.sleep(106);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4109046475U), 0);
        }

        [ScriptMethod(407, Lifecycle.Dormant)]
        public async Task x02_09_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            await Engine.sleep(155);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 50);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 19);
            await Engine.sleep(15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 37);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 52);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 71);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 71);
            await Engine.sleep(19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 52);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\holo_display_large", 4113371917U), 0);
            await Engine.sleep(149);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            await Engine.sleep(100);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 35);
            await Engine.sleep(67);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            await Engine.sleep(25);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\pillarofautumn\\pillarofautumn", 4114027287U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\holo_display_large", 4113371917U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4109046475U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 52);
        }

        [ScriptMethod(408, Lifecycle.Dormant)]
        public async Task x02_10_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4115075879U), 1);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 73);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 50);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 35);
            await Engine.sleep(78);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4115075879U), 1);
        }

        [ScriptMethod(409, Lifecycle.Dormant)]
        public async Task _01_outro_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4086501747U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\ss_prop", 4088271246U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_tram_car\\ss_tram_car", 4084732248U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_tram_car\\ss_tram_car", 4084732248U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_tram_car\\ss_tram_car", 4084732248U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_tram\\ss_door_tram", 4095545853U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\magnum\\magnum", 3808821648U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\fixed\\h_turret_mp\\weapon\\weapon", 4115534638U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 51);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787849808U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4088664468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_internet_kiosk\\ss_internet_kiosk", 4093120984U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\case_ap_turret\\case_ap_turret", 4091220411U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\chair_dining\\chair_dining", 4115600175U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\chair_sofa\\chair_sofa", 4092203466U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\trashcan\\trashcan", 4115731249U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\table_coffee\\table_coffee", 4115927860U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\case\\case", 4092465614U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 4091744707U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4094366187U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\player_wall\\player_wall", 4115993397U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4092662225U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 4092924373U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4095808001U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4025159115U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack\\ss_gun_rack", 4091941318U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing\\crate_packing", 4116058934U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4088664468U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4095218168U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\light_red_rotate\\light_red_rotate", 4116255545U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4116976452U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_loader\\ss_gun_loader", 4117631822U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_elevator_gunchamber\\ss_elevator_gunchamber", 4118156118U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4057141171U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 17, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787849808U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 4118680414U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_hangar_cinematic\\ss_door_hangar_cinematic", 4119008099U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_hangar_door_switch\\ss_hangar_door_switch", 4119401321U), 0);
            await Engine.sleep(25);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787849808U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(27);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 37, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 4118680414U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787849808U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 51);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4088664468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_multi_single\\crate_multi_single", 4119925617U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_multi\\crate_multi", 4120253302U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4094366187U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4095808001U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\debris_mini_b\\debris_mini_b", 4120580987U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\debris_mini_a\\debris_mini_a", 4121170820U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 4092924373U), 0);
            await Engine.sleep(137);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4108456642U), 0);
            await Engine.sleep(133);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 30, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787849808U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 4118680414U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 4092924373U), 0);
            await Engine.sleep(56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
        }

        [ScriptMethod(410, Lifecycle.Dormant)]
        public async Task _01_outro_02_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 10, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge\\cairo_bridge", 4121236357U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 4123333541U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_boarding_craft\\cov_boarding_craft", 4124251059U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_boarding_craft\\cov_boarding_craft", 4124251059U), 0);
            await Engine.sleep(100);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge\\cairo_bridge", 4121236357U), 0);
            await Engine.sleep(129);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4116976452U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            await Engine.sleep(48);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4107735735U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge\\cairo_bridge", 4121236357U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(75);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_boarding_craft\\cov_boarding_craft", 4124251059U), 1);
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task _01_outro_03_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, false);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4116976452U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\ss_elevator\\ss_elevator", 4124644281U), 0);
            await Engine.sleep(100);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4095808001U), 0);
            await Engine.sleep(61);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4095808001U), 0);
            await Engine.sleep(76);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4094366187U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\ss_elevator\\ss_elevator", 4124644281U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\debris_mini_b\\debris_mini_b", 4120580987U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\debris_mini_a\\debris_mini_a", 4121170820U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4088664468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack_slim\\ss_gun_rack_slim", 4090696115U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 5, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, false);
            await Engine.sleep(25);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            await Engine.sleep(51);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 27, true);
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task _01_outro_04_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\earth_space\\earth_space", 4124709818U), 0);
            await Engine.sleep(104);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4116976452U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_elevator_light\\ss_elevator_light", 4125037503U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 4118680414U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_multi_single\\crate_multi_single", 4119925617U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 50);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 60);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            await Engine.sleep(76);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4095808001U), 0);
            await Engine.sleep(73);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4116976452U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 4125103040U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, false);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            await Engine.sleep(26);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, false);
        }

        [ScriptMethod(413, Lifecycle.Dormant)]
        public async Task _01_outro_05_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4115075879U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 4125299651U), 0);
            await Engine.sleep(197);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4094366187U), 0);
            await Engine.sleep(123);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\earth_space\\earth_space", 4124709818U), 0);
        }

        [ScriptMethod(414, Lifecycle.Dormant)]
        public async Task _01_outro_06_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            await Engine.sleep(210);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            await Engine.sleep(38);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            await Engine.sleep(50);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 28, false);
            await Engine.sleep(23);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 19, false);
            await Engine.sleep(34);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 10, false);
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task _01_outro_07_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01outro_bsp"), 0, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4115075879U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4116976452U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_space\\africa_space", 4125692873U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 4125889484U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\pillarofautumn\\pillarofautumn", 4114027287U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 4126086095U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3786932290U), 0);
            await Engine.sleep(311);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_space\\africa_space", 4125692873U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 4125889484U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            await Engine.sleep(193);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 4126086095U), 2);
            await Engine.sleep(67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4115075879U), 1);
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task _01_outro_08_predict()
        {
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4115075879U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 4125889484U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_up\\cruiser_interior_up", 4126872539U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_core\\cruiser_interior_core", 4127069150U), 0);
            await Engine.sleep(301);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_side\\cruiser_interior_side", 4127527909U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_core\\cruiser_interior_core", 4127069150U), 0);
            await Engine.sleep(266);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_up\\cruiser_interior_up", 4126872539U), 0);
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task _01_outro_09_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_space\\africa_space", 4125692873U), 0);
        }

        [ScriptMethod(418, Lifecycle.Dormant)]
        public async Task _01_outro_10_predict()
        {
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 4126086095U), 2);
            await Engine.sleep(198);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4089844134U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
            await Engine.sleep(17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 4127724520U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_coast\\africa_coast", 4128576501U), 0);
            await Engine.sleep(123);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3940616385U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4050784082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 4123333541U), 0);
            await Engine.sleep(164);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 4127724520U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_coast\\africa_coast", 4128576501U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4095939075U), 0);
        }
    }
}