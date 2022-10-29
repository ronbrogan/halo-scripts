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
        int tick_seconds;
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
            this.tick_seconds = game_tick_rate();
            this.mark_1st_waves_end = false;
            this.mark_bomb2_objective = false;
            this.mark_1st_blast = false;
            this.timer_flavor = 0;
            this.global_flavor_delay = (short)(20 * this.tick_seconds);
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

        [ScriptMethod(24, Lifecycle.Static)]
        public async Task x02_01_predict_stub()
        {
            wake(new ScriptMethodReference(x02_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x02_02_predict_stub()
        {
            wake(new ScriptMethodReference(x02_02_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x02_03_predict_stub()
        {
            wake(new ScriptMethodReference(x02_03_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x02_04a_predict_stub()
        {
            wake(new ScriptMethodReference(x02_04a_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x02_04b_predict_stub()
        {
            wake(new ScriptMethodReference(x02_04b_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x02_05_predict_stub()
        {
            wake(new ScriptMethodReference(x02_05_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x02_06_predict_stub()
        {
            wake(new ScriptMethodReference(x02_06_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x02_07_predict_stub()
        {
            wake(new ScriptMethodReference(x02_07_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x02_08_predict_stub()
        {
            wake(new ScriptMethodReference(x02_08_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x02_09_predict_stub()
        {
            wake(new ScriptMethodReference(x02_09_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task x02_10_predict_stub()
        {
            wake(new ScriptMethodReference(x02_10_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task _01_outro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_01_predict));
        }

        [ScriptMethod(36, Lifecycle.Static)]
        public async Task _01_outro_02_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_02_predict));
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task _01_outro_03_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_03_predict));
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task _01_outro_04_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_04_predict));
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task _01_outro_05_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_05_predict));
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task _01_outro_06_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_06_predict));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task _01_outro_07_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_07_predict));
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task _01_outro_08_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_08_predict));
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task _01_outro_09_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_09_predict));
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task _01_outro_10_predict_stub()
        {
            wake(new ScriptMethodReference(_01_outro_10_predict));
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task x02_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_01_mus", 4122153850U), default(IGameObject), 1F);
            print("x02 score 01 start");
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task x02_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_01_fol", 4122219387U), default(IGameObject), 1F);
            print("x02 foley 01 start");
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x02_0010_mas()
        {
            await sleep(20);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0010_mas", 4122284924U), chief_x02_01.Entity, 1F);
            cinematic_subtitle("x02_0010_mas", 2F);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task x02_0020_jon()
        {
            await sleep(80);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0020_jon", 4122350461U), johnson_x02_01.Entity, 1F);
            cinematic_subtitle("x02_0020_jon", 2.5F);
            unit_set_emotional_state(johnson_x02_01.Entity, "annoyed", 0.75F, 10);
            print("johnson - annoyed .75 15");
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task x02_0030_jon()
        {
            await sleep(181);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0030_jon", 4122415998U), johnson_x02_01.Entity, 1F);
            cinematic_subtitle("x02_0030_jon", 2.5F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task x02_0040_jon()
        {
            await sleep(270);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0040_jon", 4122481535U), johnson_x02_01.Entity, 1F);
            cinematic_subtitle("x02_0040_jon", 2F);
            unit_set_emotional_state(johnson_x02_01.Entity, "happy", 0.75F, 30);
            print("johnson - happy .75 30");
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task x02_0050_jon()
        {
            await sleep(333);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0050_jon", 4122547072U), johnson_x02_01.Entity, 1F);
            cinematic_subtitle("x02_0050_jon", 2F);
            await sleep(10);
            unit_set_emotional_state(johnson_x02_01.Entity, "pensive", 1F, 60);
            print("johnson - pensive 1 60");
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task x02_01_dof()
        {
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(0.85F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            print("rack focus");
            await sleep(164);
            cinematic_screen_effect_stop();
            print("rack focus stop");
            await sleep(104);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            print("rack focus");
            await sleep(147);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_01()
        {
            cinematic_lighting_set_primary_light(67F, 208F, 0.458824F, 0.407843F, 0.34902F);
            cinematic_lighting_set_secondary_light(45F, 120F, 0.215686F, 0.207843F, 0.25098F);
            cinematic_lighting_set_ambient_light(0.0823529F, 0.0823529F, 0.0823529F);
            object_uses_cinematic_lighting(chief_x02_01.Entity, true);
            object_uses_cinematic_lighting(johnson_x02_01.Entity, true);
            object_uses_cinematic_lighting(marine_x02_01.Entity, true);
            object_uses_cinematic_lighting(marine_x02_02.Entity, true);
            object_uses_cinematic_lighting(marine_x02_03.Entity, true);
            object_uses_cinematic_lighting(marine_x02_04.Entity, true);
            object_uses_cinematic_lighting(marine_x02_05.Entity, true);
            object_uses_cinematic_lighting(marine_x02_06.Entity, true);
            object_uses_cinematic_lighting(marine_x02_07.Entity, true);
            object_uses_cinematic_lighting(marine_x02_08.Entity, true);
            object_uses_cinematic_lighting(marine_door_01.Entity, true);
            object_uses_cinematic_lighting(marine_door_02.Entity, true);
            object_uses_cinematic_lighting(johnson_hat.Entity, true);
            object_uses_cinematic_lighting(x02_drone_01.Entity, true);
            object_uses_cinematic_lighting(x02_drone_02.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task x02_02_problem_actors()
        {
            print("problem actors");
            object_create_anew(dervish);
            object_create_anew(tartarus);
            object_create_anew(brute_01);
            object_create_anew(brute_02);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task x02_hum_crowd_01a()
        {
            print("first marine crowd");
            custom_animation_loop(marine_x02_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_whistle_loop", false);
            custom_animation_loop(marine_x02_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_fist_loop", false);
            custom_animation_loop(marine_x02_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_clapping_loop", false);
            await sleep(5);
            custom_animation_loop(marine_x02_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_clapping_loop", false);
            await sleep(10);
            custom_animation_loop(marine_x02_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_clapping_loop", false);
            await sleep(10);
            custom_animation_loop(marine_x02_06.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_whistle_loop", false);
            await sleep(10);
            custom_animation_loop(marine_x02_07.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_clapping_loop", false);
            await sleep(10);
            custom_animation_loop(marine_x02_08.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_clapping_loop", false);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task x02_hum_crowd_01b()
        {
            await sleep(268);
            print("second marine crowd");
            object_destroy(marine_x02_01.Entity);
            object_destroy(marine_x02_02.Entity);
            object_destroy(marine_x02_03.Entity);
            object_destroy(marine_x02_04.Entity);
            object_destroy(marine_x02_05.Entity);
            object_create_anew(marine_x02_09);
            object_create_anew(marine_x02_10);
            object_create_anew(marine_x02_11);
            object_create_anew(marine_x02_12);
            object_uses_cinematic_lighting(marine_x02_09.Entity, true);
            object_uses_cinematic_lighting(marine_x02_10.Entity, true);
            object_uses_cinematic_lighting(marine_x02_11.Entity, true);
            object_uses_cinematic_lighting(marine_x02_12.Entity, true);
            custom_animation_loop(marine_x02_09.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_whistle_loop", false);
            custom_animation_loop(marine_x02_10.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_fist_loop", false);
            custom_animation_loop(marine_x02_11.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_clapping_loop", false);
            await sleep(10);
            custom_animation_loop(marine_x02_12.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_clapping_loop", false);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task open_bridge_door()
        {
            await sleep(417);
            print("open bridge door");
            device_set_position(x02_bridge_door.Entity, 1F);
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task x02_01_setup()
        {
            object_destroy_type_mask(2052);
            object_destroy(offending_light.Entity);
            object_create_anew(chief_x02_01);
            object_create_anew(johnson_x02_01);
            object_create_anew(johnson_hat);
            object_set_permutation(johnson_x02_01.Entity, "helmet", "");
            object_create_anew(marine_door_01);
            object_create_anew(marine_door_02);
            object_set_permutation(marine_door_01.Entity, "head", "smith");
            object_set_permutation(marine_door_02.Entity, "head", "perez");
            object_create_anew(marine_x02_01);
            object_create_anew(marine_x02_02);
            object_create_anew(marine_x02_03);
            object_create_anew(marine_x02_04);
            object_create_anew(marine_x02_05);
            object_create_anew(marine_x02_06);
            object_create_anew(marine_x02_07);
            object_create_anew(marine_x02_08);
            object_create_anew(x02_drone_01);
            object_create_anew(x02_drone_02);
            object_cinematic_lod(chief_x02_01.Entity, true);
            object_cinematic_lod(johnson_x02_01.Entity, true);
            object_cinematic_lod(marine_x02_01.Entity, true);
            object_cinematic_lod(marine_x02_02.Entity, true);
            object_cinematic_lod(marine_x02_03.Entity, true);
            object_cinematic_lod(marine_x02_04.Entity, true);
            object_cinematic_lod(marine_x02_05.Entity, true);
            object_cinematic_lod(marine_x02_06.Entity, true);
            object_cinematic_lod(marine_x02_07.Entity, true);
            object_cinematic_lod(marine_x02_08.Entity, true);
            wake(new ScriptMethodReference(x02_score_01));
            wake(new ScriptMethodReference(x02_foley_01));
            wake(new ScriptMethodReference(x02_0010_mas));
            wake(new ScriptMethodReference(x02_0020_jon));
            wake(new ScriptMethodReference(x02_0030_jon));
            wake(new ScriptMethodReference(x02_0040_jon));
            wake(new ScriptMethodReference(x02_0050_jon));
            wake(new ScriptMethodReference(x02_hum_crowd_01a));
            wake(new ScriptMethodReference(x02_hum_crowd_01b));
            wake(new ScriptMethodReference(x02_01_dof));
            wake(new ScriptMethodReference(cinematic_lighting_x02_01));
            wake(new ScriptMethodReference(open_bridge_door));
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task x02_01_cleanup()
        {
            object_destroy(chief_x02_01.Entity);
            object_destroy(johnson_x02_01.Entity);
            object_destroy_containing("marine_x02");
            object_destroy_containing("marine_door");
            object_destroy_containing("drone");
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task x02_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("spacestation_1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.x02_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_01_mus", 4122153850U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_01b_fol", 4122743683U));
            await sleep(this.prediction_offset);
            await this.x02_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_01", default(IUnit), anchor_flag_x02_01);
            custom_animation_relative(chief_x02_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4122874757U), "chief_01", false, anchor_x02_01.Entity);
            custom_animation_relative(johnson_x02_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "johnson_01", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_door_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine02_01", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_door_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine04_01", false, anchor_x02_01.Entity);
            scenery_animation_start_relative(johnson_hat.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\dress_cap\\x02\\x02", 4122940294U), "dress_cap_01", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_drone_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\news_drone\\x02\\x02", 4123005831U), "news_drone01_01", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_drone_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\news_drone\\x02\\x02", 4123005831U), "news_drone02_01", anchor_x02_01.Entity);
            await sleep(20);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_01b_fol", 4122743683U));
            await sleep((short)((float)camera_time() - 15));
            await this.x02_02_problem_actors();
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.x02_01_cleanup();
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task x02_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_01b_fol", 4122743683U), default(IGameObject), 1F);
            print("x02 foley 02 start");
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task x02_0070_gch()
        {
            await sleep(386);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0070_gch", 4123071368U), default(IGameObject), 1F);
            cinematic_subtitle("x02_0070_gch", 2F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task x02_fov_02()
        {
            await sleep(384);
            camera_set_field_of_view(30F, 0);
            print("fov change: 60 -> 30 over 0 ticks");
            await sleep(71);
            camera_set_field_of_view(60F, 0);
            print("fov change: 30 -> 60 over 0 ticks");
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_02()
        {
            cinematic_lighting_set_primary_light(90F, 248F, 0.345098F, 0.286275F, 0.270588F);
            cinematic_lighting_set_secondary_light(90F, 36F, 0.0784314F, 0.0745098F, 0.0901961F);
            cinematic_lighting_set_ambient_light(0.0509804F, 0.0509804F, 0.0509804F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(grunt_01.Entity, true);
            object_uses_cinematic_lighting(grunt_02.Entity, true);
            object_uses_cinematic_lighting(grunt_03.Entity, true);
            object_uses_cinematic_lighting(jackal_01.Entity, true);
            object_uses_cinematic_lighting(hammer.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task place_cov_crowd_01a()
        {
            await sleep(60);
            print("place crowd 01a");
            object_create_anew_containing("cov_crowd_01a");
            object_create_anew(problem_guard);
            object_uses_cinematic_lighting(cov_crowd_01a_01.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_02.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_03.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_04.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_05.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_06.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_07.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_08.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_09.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_10.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_11.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_12.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_13.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_14.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_15.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_16.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_17.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_18.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_19.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_20.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_21.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_22.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_23.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_24.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_25.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_26.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_27.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_28.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_29.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_30.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_31.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_32.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01a_33.Entity, true);
            object_uses_cinematic_lighting(problem_guard.Entity, true);
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task place_cov_crowd_01b()
        {
            await sleep(249);
            print("place crowd 01b");
            object_destroy_containing("cov_crowd_01a");
            object_destroy(problem_guard.Entity);
            object_create_anew_containing("cov_crowd_01b");
            object_uses_cinematic_lighting(cov_crowd_01b_01.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_03.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_04.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_05.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_06.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_07.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_08.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_09.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_10.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_11.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_12.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_13.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_14.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_15.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01b_16.Entity, true);
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task place_cov_crowd_01c()
        {
            await sleep(384);
            print("place crowd 01c");
            object_destroy_containing("cov_crowd_01b");
            object_create_anew_containing("cov_crowd_01c");
            object_uses_cinematic_lighting(cov_crowd_01c_01.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01c_02.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01c_03.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01c_04.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01c_05.Entity, true);
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task place_cov_crowd_01d()
        {
            time_code_reset();
            await sleep(610);
            print("place crowd 01d");
            object_destroy_containing("cov_crowd_01c");
            object_create_anew_containing("cov_crowd_01d");
            object_uses_cinematic_lighting(cov_crowd_01d_01.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_02.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_03.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_04.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_05.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_06.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_07.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_08.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_09.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_10.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_11.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_12.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_13.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_14.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_15.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_16.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_17.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_18.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_19.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_20.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_01d_21.Entity, true);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task place_cov_crowd_distant()
        {
            await sleep(456);
            print("place crowd distant");
            object_create_anew_containing("x02_crowd_distant");
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task activate_manacles()
        {
            await sleep(666);
            print("activate manacle");
            object_set_function_variable(x02_manacle_01.Entity, "manacle_on", 0F, 1F);
            await sleep(20);
            object_set_function_variable(x02_manacle_02.Entity, "manacle_on", 0F, 1F);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task create_columns()
        {
            object_create_anew(x02_column_01);
            object_create_anew(x02_column_06);
            await sleep(30);
            object_create_anew(x02_column_02);
            object_create_anew(x02_column_05);
            await sleep(30);
            object_create_anew(x02_column_03);
            object_create_anew(x02_column_04);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task x02_02_setup()
        {
            object_create_anew(grunt_01);
            object_create_anew(grunt_02);
            object_create_anew(grunt_03);
            object_create_anew(jackal_01);
            object_create_anew(hammer);
            object_create_anew_containing("x02_manacle");
            object_cinematic_lod(grunt_01.Entity, true);
            object_cinematic_lod(grunt_02.Entity, true);
            object_cinematic_lod(grunt_03.Entity, true);
            object_cinematic_lod(jackal_01.Entity, true);
            object_cinematic_lod(hammer.Entity, true);
            wake(new ScriptMethodReference(x02_foley_02));
            wake(new ScriptMethodReference(x02_0070_gch));
            wake(new ScriptMethodReference(x02_fov_02));
            wake(new ScriptMethodReference(place_cov_crowd_01a));
            wake(new ScriptMethodReference(place_cov_crowd_01b));
            wake(new ScriptMethodReference(place_cov_crowd_01c));
            wake(new ScriptMethodReference(place_cov_crowd_01d));
            wake(new ScriptMethodReference(place_cov_crowd_distant));
            wake(new ScriptMethodReference(create_columns));
            wake(new ScriptMethodReference(activate_manacles));
            wake(new ScriptMethodReference(cinematic_lighting_x02_02));
            device_set_position(x02_door_02.Entity, 1F);
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task x02_02_cleanup()
        {
            object_destroy(brute_01.Entity);
            object_destroy(brute_02.Entity);
            object_destroy(grunt_01.Entity);
            object_destroy(grunt_02.Entity);
            object_destroy(grunt_03.Entity);
            object_destroy(jackal_01.Entity);
            object_destroy(hammer.Entity);
            object_destroy_containing("cov_crowd_01");
            object_destroy_containing("crowd_distant");
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task x02_scene_02()
        {
            await this.x02_02_predict_stub();
            await this.x02_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_02", default(IUnit), anchor_flag_x02_02);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x02\\x02", 4123136905U), "dervish_02", false, anchor_x02_02.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4123267979U), "tartarus_02", false, anchor_x02_02.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4123267979U), "brute01_02", false, anchor_x02_02.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4123267979U), "brute02_02", false, anchor_x02_02.Entity);
            custom_animation_relative(grunt_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4123399053U), "grunt01_02", false, anchor_x02_02.Entity);
            custom_animation_relative(grunt_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4123399053U), "grunt02_02", false, anchor_x02_02.Entity);
            custom_animation_relative(grunt_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4123399053U), "grunt03_02", false, anchor_x02_02.Entity);
            custom_animation_relative(jackal_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x02\\x02", 4123464590U), "jackal01_02", false, anchor_x02_02.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x02\\x02", 4123530127U), "hammer_02", anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_manacle_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4123595664U), "manacle1_02", anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_manacle_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4123595664U), "manacle2_02", anchor_x02_02.Entity);
            await sleep(30);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x02_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_02_fol", 4123661201U));
            await sleep((short)camera_time());
            await this.x02_02_cleanup();
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x02_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_02_fol", 4123661201U), default(IGameObject), 1F);
            print("x02 foley 03 start");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x02_0090_tar()
        {
            await sleep(40);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0090_tar", 4123726738U), tartarus.Entity, 1F);
            cinematic_subtitle("x02_0090_tar", 2F);
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x02_0100_der()
        {
            await sleep(106);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0100_der", 4123792275U), dervish.Entity, 1F);
            cinematic_subtitle("x02_0100_der", 3.5F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x02_0110_tar()
        {
            await sleep(213);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0110_tar", 4123857812U), tartarus.Entity, 1F);
            cinematic_subtitle("x02_0110_tar", 1.5F);
            unit_set_emotional_state(tartarus.Entity, "inquisitive", 1F, 60);
            print("tartarus - inquisitive 1 60");
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task effect_beam_01_start()
        {
            await sleep(297);
            print("effect - beam 01 start");
            object_create(beam_start_01);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task effect_beams()
        {
            await sleep(378);
            print("effect - beam 01");
            object_create(beam_01);
            await sleep(69);
            print("effect - beam 02");
            object_create(beam_02);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task place_cov_crowd_02()
        {
            await sleep(480);
            print("place crowd 02");
            object_create_anew_containing("cov_crowd_02");
            object_uses_cinematic_lighting(cov_crowd_02_01.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_02.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_03.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_04.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_05.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_06.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_07.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_08.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_09.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_10.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_11.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_12.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_13.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_14.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_15.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_16.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_17.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_18.Entity, true);
            object_uses_cinematic_lighting(cov_crowd_02_19.Entity, true);
        }

        [ScriptMethod(82, Lifecycle.Static)]
        public async Task x02_03_setup()
        {
            wake(new ScriptMethodReference(x02_foley_03));
            wake(new ScriptMethodReference(x02_0090_tar));
            wake(new ScriptMethodReference(x02_0100_der));
            wake(new ScriptMethodReference(x02_0110_tar));
            wake(new ScriptMethodReference(effect_beam_01_start));
            wake(new ScriptMethodReference(effect_beams));
            wake(new ScriptMethodReference(place_cov_crowd_02));
        }

        [ScriptMethod(83, Lifecycle.Static)]
        public async Task x02_scene_03_cleanup()
        {
            object_destroy_containing("beam");
            object_destroy_containing("cov_crowd_02");
        }

        [ScriptMethod(84, Lifecycle.Static)]
        public async Task x02_scene_03()
        {
            await this.x02_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_03", default(IUnit), anchor_flag_x02_02);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x02\\x02", 4123136905U), "dervish_03", false, anchor_x02_02.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4123267979U), "tartarus_03", false, anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_manacle_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4123595664U), "manacle1_03", anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_manacle_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4123595664U), "manacle2_03", anchor_x02_02.Entity);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_03_fol", 4123923349U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.x02_scene_03_cleanup();
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x02_foley_04a()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_03_fol", 4123923349U), default(IGameObject), 1F);
            print("x02 foley 04a start");
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task x02_0140_lhd()
        {
            await sleep(300);
            unit_set_emotional_state(hood_x02.Entity, "happy", 0.25F, 30);
            print("hood - happy .25 30");
            await sleep(41);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0140_lhd", 4123988886U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0140_lhd", 2F);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task marine_whisper()
        {
            await sleep(413);
            print("marine whisper");
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\earthcity\\whisper", 4124054423U), marine_01.Entity, 1F);
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x02_0150_lhd()
        {
            await sleep(430);
            unit_set_emotional_state(hood_x02.Entity, "angry", 0.25F, 60);
            print("hood - angry .25 60");
            await sleep(50);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0150_lhd", 4124119960U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0150_lhd", 1.5F);
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x02_0160_cor()
        {
            unit_set_emotional_state(cortana_x02.Entity, "angry", 0.15F, 0);
            print("cortana - angry .15 0");
            await sleep(524);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0160_cor", 4124185497U), cortana_x02.Entity, 1F);
            cinematic_subtitle("x02_0160_cor", 3F);
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task effect_cortana_on()
        {
            await sleep(521);
            print("cortana_on");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4124251034U), x02_cortana_stand.Entity, "holo_effect");
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_04a()
        {
            cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            object_uses_cinematic_lighting(chief_x02.Entity, true);
            object_uses_cinematic_lighting(johnson_x02.Entity, true);
            object_uses_cinematic_lighting(hood_x02.Entity, true);
            object_uses_cinematic_lighting(miranda_x02.Entity, true);
            object_uses_cinematic_lighting(cortana_x02.Entity, true);
            object_uses_cinematic_lighting(marine_01.Entity, true);
            object_uses_cinematic_lighting(marine_02.Entity, true);
            object_uses_cinematic_lighting(marine_03.Entity, true);
            object_uses_cinematic_lighting(marine_04.Entity, true);
            object_uses_cinematic_lighting(marine_plant_01.Entity, true);
            object_uses_cinematic_lighting(marine_plant_02.Entity, true);
            object_uses_cinematic_lighting(marine_plant_03.Entity, true);
            object_uses_cinematic_lighting(marine_plant_04.Entity, true);
            object_uses_cinematic_lighting(marine_plant_05.Entity, true);
            object_uses_cinematic_lighting(marine_plant_06.Entity, true);
            object_uses_cinematic_lighting(marine_plant_07.Entity, true);
            object_uses_cinematic_lighting(x02_cortana_stand.Entity, true);
            object_uses_cinematic_lighting(x02_medal_tray.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x02_marine_crowd_01()
        {
            await sleep(0);
            print("create marine crowd 02");
            object_create_anew_containing("x02_marine_prop_01a");
            await sleep(10);
            object_create_anew_containing("x02_marine_prop_01b");
            object_uses_cinematic_lighting(x02_marine_prop_01a_01.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01b_02.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01a_03.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01b_04.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01a_05.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01a_06.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01a_07.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01b_08.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01a_09.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01b_10.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01a_11.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01b_12.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01a_13.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01b_14.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01a_15.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_01b_16.Entity, true);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x02_marine_crowd_02()
        {
            await sleep(0);
            print("create marine crowd 02");
            object_create_anew_containing("x02_marine_prop_02a");
            await sleep(5);
            object_create_anew_containing("x02_marine_prop_02b");
            await sleep(10);
            object_create_anew_containing("x02_marine_prop_02c");
            object_uses_cinematic_lighting(x02_marine_prop_02a_01.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_02.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_03.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_05.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_06.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_07.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_08.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_09.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_10.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_11.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_12.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_13.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_14.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_16.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_17.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_18.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_19.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_20.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_21.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_22.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_23.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_24.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_25.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_26.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_27.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_28.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_29.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02a_30.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02b_31.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_02c_32.Entity, true);
        }

        [ScriptMethod(94, Lifecycle.Static)]
        public async Task x02_04a_setup()
        {
            object_create_anew(chief_x02);
            object_create_anew(hood_x02);
            object_create_anew(cortana_x02);
            object_create_anew(miranda_x02);
            object_create_anew(johnson_x02);
            object_create_anew(marine_01);
            object_create_anew(marine_02);
            object_create_anew(marine_03);
            object_create_anew(marine_04);
            object_create_anew(marine_plant_01);
            object_create_anew(marine_plant_02);
            object_create_anew(marine_plant_03);
            object_create_anew(marine_plant_04);
            object_create_anew(marine_plant_05);
            object_create_anew(marine_plant_06);
            object_create_anew(marine_plant_07);
            object_set_permutation(marine_01.Entity, "head", "perez");
            object_set_permutation(marine_02.Entity, "head", "smith");
            object_set_permutation(marine_03.Entity, "head", "walter");
            object_set_permutation(marine_04.Entity, "head", "dion");
            object_create_anew(x02_cortana_stand);
            object_create_anew(x02_medal_tray);
            object_create_anew(x02_unsc_logo);
            object_cinematic_lod(chief_x02.Entity, true);
            object_cinematic_lod(hood_x02.Entity, true);
            object_cinematic_lod(cortana_x02.Entity, true);
            object_cinematic_lod(miranda_x02.Entity, true);
            object_cinematic_lod(johnson_x02.Entity, true);
            object_cinematic_lod(marine_01.Entity, true);
            object_cinematic_lod(marine_02.Entity, true);
            object_cinematic_lod(marine_03.Entity, true);
            object_cinematic_lod(marine_04.Entity, true);
            object_cinematic_lod(marine_plant_01.Entity, true);
            object_cinematic_lod(marine_plant_02.Entity, true);
            object_cinematic_lod(marine_plant_03.Entity, true);
            object_cinematic_lod(marine_plant_04.Entity, true);
            object_cinematic_lod(marine_plant_05.Entity, true);
            object_cinematic_lod(marine_plant_06.Entity, true);
            object_cinematic_lod(marine_plant_07.Entity, true);
            wake(new ScriptMethodReference(x02_foley_04a));
            wake(new ScriptMethodReference(x02_0140_lhd));
            wake(new ScriptMethodReference(marine_whisper));
            wake(new ScriptMethodReference(x02_0150_lhd));
            wake(new ScriptMethodReference(x02_0160_cor));
            wake(new ScriptMethodReference(x02_marine_crowd_01));
            wake(new ScriptMethodReference(x02_marine_crowd_02));
            wake(new ScriptMethodReference(effect_cortana_on));
            wake(new ScriptMethodReference(cinematic_lighting_x02_04a));
        }

        [ScriptMethod(95, Lifecycle.Static)]
        public async Task x02_scene_04a_cleanup()
        {
            object_destroy(marine_05.Entity);
            object_destroy(marine_06.Entity);
            object_destroy(marine_07.Entity);
            object_destroy(marine_08.Entity);
            object_destroy_containing("x02_marine_prop_01");
            object_destroy_containing("x02_marine_prop_02");
            object_destroy_containing("marine_plant");
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task x02_scene_04a()
        {
            cinematic_lightmap_shadow_enable();
            await this.x02_04a_predict_stub();
            await this.x02_04a_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_04a", default(IUnit), anchor_flag_x02_01);
            custom_animation_relative(chief_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4122874757U), "chief_04a", false, anchor_x02_01.Entity);
            custom_animation_relative(johnson_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "johnson_04a", false, anchor_x02_01.Entity);
            custom_animation_relative(hood_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4125103015U), "hood_04a", false, anchor_x02_01.Entity);
            custom_animation_relative(miranda_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x02\\x02", 4125234089U), "miranda_04a", false, anchor_x02_01.Entity);
            custom_animation_relative(cortana_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x02\\x02", 4125299626U), "cortana_04a", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine01_04a", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine02_04a", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine03_04a", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine04_04a", false, anchor_x02_01.Entity);
            custom_animation_loop(marine_plant_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_whistle_loop", false);
            custom_animation_loop(marine_plant_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_fist_loop", false);
            custom_animation_loop(marine_plant_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_clapping_loop", false);
            custom_animation_loop(marine_plant_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_whistle_loop", false);
            custom_animation_loop(marine_plant_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_whistle_loop", false);
            custom_animation_loop(marine_plant_06.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_whistle_loop", false);
            custom_animation_loop(marine_plant_07.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine_fist_loop", false);
            scenery_animation_start_relative(x02_cortana_stand.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4125365163U), "cortana_stand_04a", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_medal_tray.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\medal_tray\\x02\\x02", 4125430700U), "medal_tray_04a", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_unsc_logo.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\x02\\x02", 4125496237U), "unsc_logo_04a", anchor_x02_01.Entity);
            await sleep(30);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x02_04b_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_04_fol", 4125561774U));
            await sleep((short)camera_time());
            await this.x02_scene_04a_cleanup();
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x02_foley_04b()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_04_fol", 4125561774U), default(IGameObject), 1F);
            print("x02 foley 04b start");
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x02_0170_lhd()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0170_lhd", 4125627311U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0170_lhd", 3F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x02_0180_cor()
        {
            await sleep(10);
            unit_set_emotional_state(cortana_x02.Entity, "angry", 0.25F, 0);
            await sleep(117);
            unit_set_emotional_state(cortana_x02.Entity, "happy", 0.25F, 60);
            print("cortana - happy .15 60");
            await sleep(30);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0180_cor", 4125692848U), cortana_x02.Entity, 1F);
            cinematic_subtitle("x02_0180_cor", 1F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x02_0190_mas()
        {
            await sleep(194);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0190_mas", 4125758385U), chief_x02.Entity, 1F);
            cinematic_subtitle("x02_0190_mas", 1F);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task x02_0200_jon()
        {
            await sleep(189);
            unit_set_emotional_state(johnson_x02.Entity, "arrogant", 1F, 0);
            print("johnson - amorous 1 0");
            await sleep(5);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0200_jon", 4125823922U), johnson_x02.Entity, 1F);
            cinematic_subtitle("x02_0200_jon", 1F);
            await sleep(30);
            unit_set_emotional_state(johnson_x02.Entity, "annoyed", 0.5F, 30);
            print("johnson - annoyed .5 30");
            await sleep(40);
            unit_set_emotional_state(johnson_x02.Entity, "pensive", 1F, 5);
            print("johnson - pensive 1 5");
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task x02_0210_lhd()
        {
            await sleep(255);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0210_lhd", 4125889459U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0210_lhd", 1F);
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x02_0220_lhd()
        {
            await sleep(293);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0220_lhd", 4125954996U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0220_lhd", 5F);
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task x02_0230_lhd()
        {
            await sleep(435);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0230_lhd", 4126020533U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0230_lhd", 3F);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_04b()
        {
            cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            object_uses_cinematic_lighting(medal_01.Entity, true);
            object_uses_cinematic_lighting(medal_02.Entity, true);
            object_uses_cinematic_lighting(medal_03.Entity, true);
        }

        [ScriptMethod(106, Lifecycle.Static)]
        public async Task x02_04b_setup()
        {
            object_create_anew_containing("medal");
            cinematic_set_near_clip_distance(0.043F);
            print("setting near clip distance to .043");
            wake(new ScriptMethodReference(x02_foley_04b));
            wake(new ScriptMethodReference(x02_0170_lhd));
            wake(new ScriptMethodReference(x02_0180_cor));
            wake(new ScriptMethodReference(x02_0190_mas));
            wake(new ScriptMethodReference(x02_0200_jon));
            wake(new ScriptMethodReference(x02_0210_lhd));
            wake(new ScriptMethodReference(x02_0220_lhd));
            wake(new ScriptMethodReference(x02_0230_lhd));
        }

        [ScriptMethod(107, Lifecycle.Static)]
        public async Task x02_scene_04b()
        {
            await this.x02_04b_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_04b", default(IUnit), anchor_flag_x02_01);
            custom_animation_relative(chief_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4122874757U), "chief_04b", false, anchor_x02_01.Entity);
            custom_animation_relative(johnson_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "johnson_04b", false, anchor_x02_01.Entity);
            custom_animation_relative(hood_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4125103015U), "hood_04b", false, anchor_x02_01.Entity);
            custom_animation_relative(cortana_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x02\\x02", 4125299626U), "cortana_04b", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine01_04b", false, anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_cortana_stand.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4125365163U), "cortana_stand_04b", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_medal_tray.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\medal_tray\\x02\\x02", 4125430700U), "medal_tray_04b", anchor_x02_01.Entity);
            scenery_animation_start_relative(medal_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\colonial_cross\\x02\\x02", 4126086070U), "cross1_04b", anchor_x02_01.Entity);
            scenery_animation_start_relative(medal_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\colonial_cross\\x02\\x02", 4126086070U), "cross2_04b", anchor_x02_01.Entity);
            scenery_animation_start_relative(medal_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\colonial_cross\\x02\\x02", 4126086070U), "cross3_04b", anchor_x02_01.Entity);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_05_mus", 4126151607U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_05_fol", 4126217144U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task x02_score_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_05_mus", 4126151607U), default(IGameObject), 1F);
            print("x02 score 05 start");
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task x02_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_05_fol", 4126217144U), default(IGameObject), 1F);
            print("x02 foley 05 start");
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x02_0240_tar()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0240_tar", 4126282681U), tartarus.Entity, 1F);
            cinematic_subtitle("x02_0240_tar", 3F);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x02_0250_tar()
        {
            await sleep(88);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0250_tar", 4126348218U), tartarus.Entity, 1F);
            cinematic_subtitle("x02_0250_tar", 3F);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x02_0270_tar()
        {
            await sleep(245);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0270_tar", 4126413755U), tartarus.Entity, 1F);
            cinematic_subtitle("x02_0270_tar", 2F);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\02\\charred_smoke_medium", 4126479292U), dervish.Entity, "head");
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task effect_body_smoke()
        {
            await sleep(0);
            print("effect - body smoke");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\02\\charred_smoke_medium", 4126479292U), dervish.Entity, "head");
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_05()
        {
            cinematic_lighting_set_primary_light(90F, 248F, 0.345098F, 0.286275F, 0.270588F);
            cinematic_lighting_set_secondary_light(90F, 36F, 0.0784314F, 0.0745098F, 0.0901961F);
            cinematic_lighting_set_ambient_light(0.0509804F, 0.0509804F, 0.0509804F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(grunt_01.Entity, true);
            object_uses_cinematic_lighting(grunt_02.Entity, true);
            object_uses_cinematic_lighting(grunt_03.Entity, true);
            object_uses_cinematic_lighting(jackal_01.Entity, true);
            object_uses_cinematic_lighting(jackal_02.Entity, true);
            object_uses_cinematic_lighting(hunter_01.Entity, true);
            object_uses_cinematic_lighting(hunter_02.Entity, true);
            object_uses_cinematic_lighting(hunter_03.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task x02_05_setup()
        {
            object_create_anew(dervish);
            object_create_anew(tartarus);
            object_create_anew(brute_01);
            object_create_anew(brute_02);
            object_create_anew(grunt_01);
            object_create_anew(grunt_02);
            object_create_anew(grunt_03);
            object_create_anew(jackal_01);
            object_create_anew(jackal_02);
            object_create_anew(hunter_01);
            object_create_anew(hunter_02);
            object_create_anew(hunter_03);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
            object_cinematic_lod(grunt_01.Entity, true);
            object_cinematic_lod(grunt_02.Entity, true);
            object_cinematic_lod(grunt_03.Entity, true);
            object_cinematic_lod(jackal_01.Entity, true);
            object_cinematic_lod(jackal_02.Entity, true);
            object_cinematic_lod(hunter_01.Entity, true);
            object_cinematic_lod(hunter_02.Entity, true);
            object_cinematic_lod(hunter_03.Entity, true);
            object_set_function_variable(dervish.Entity, "elite_burnt", 0F, 0F);
            cinematic_set_near_clip_distance(0.06F);
            print("resetting near clip distance to .06");
            wake(new ScriptMethodReference(x02_score_05));
            wake(new ScriptMethodReference(x02_foley_05));
            wake(new ScriptMethodReference(x02_0240_tar));
            wake(new ScriptMethodReference(x02_0250_tar));
            wake(new ScriptMethodReference(x02_0270_tar));
            wake(new ScriptMethodReference(effect_body_smoke));
            wake(new ScriptMethodReference(cinematic_lighting_x02_05));
        }

        [ScriptMethod(116, Lifecycle.Static)]
        public async Task x02_05_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy(brute_01.Entity);
            object_destroy(brute_02.Entity);
            object_destroy(grunt_01.Entity);
            object_destroy(grunt_02.Entity);
            object_destroy(grunt_03.Entity);
            object_destroy(jackal_01.Entity);
            object_destroy(jackal_02.Entity);
            object_destroy(hunter_01.Entity);
            object_destroy(hunter_02.Entity);
            object_destroy(hunter_03.Entity);
        }

        [ScriptMethod(117, Lifecycle.Static)]
        public async Task x02_scene_05()
        {
            cinematic_lightmap_shadow_disable();
            await this.x02_05_predict_stub();
            await this.x02_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_05", default(IUnit), anchor_flag_x02_02);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x02\\x02", 4123136905U), "dervish_05", false, anchor_x02_02.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4123267979U), "tartarus_05", false, anchor_x02_02.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4123267979U), "brute01_05", false, anchor_x02_02.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4123267979U), "brute02_05", false, anchor_x02_02.Entity);
            custom_animation_relative(grunt_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4123399053U), "grunt01_05", false, anchor_x02_02.Entity);
            custom_animation_relative(grunt_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4123399053U), "grunt02_05", false, anchor_x02_02.Entity);
            custom_animation_relative(grunt_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\x02\\x02", 4123399053U), "grunt03_05", false, anchor_x02_02.Entity);
            custom_animation_relative(jackal_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x02\\x02", 4123464590U), "jackal01_05", false, anchor_x02_02.Entity);
            custom_animation_relative(jackal_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x02\\x02", 4123464590U), "jackal02_05", false, anchor_x02_02.Entity);
            custom_animation_relative(hunter_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\hunter\\x02\\x02", 4126741440U), "hunter01_05", false, anchor_x02_02.Entity);
            custom_animation_relative(hunter_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\hunter\\x02\\x02", 4126741440U), "hunter02_05", false, anchor_x02_02.Entity);
            custom_animation_relative(hunter_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\hunter\\x02\\x02", 4126741440U), "hunter03_05", false, anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_manacle_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4123595664U), "manacle1_05", anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_manacle_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4123595664U), "manacle2_05", anchor_x02_02.Entity);
            await sleep(30);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_06_fol", 4126806977U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.x02_05_cleanup();
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task x02_foley_06()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_06_fol", 4126806977U), default(IGameObject), 1F);
            print("x02 foley 06 start");
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x02_0280_lhd()
        {
            await sleep(165);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0280_lhd", 4126872514U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0280_lhd", 2F);
            unit_set_emotional_state(miranda_x02.Entity, "pensive", 0.25F, 0);
            print("miranda - pensive .25 0");
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task x02_0290_lhd()
        {
            await sleep(217);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0290_lhd", 4126938051U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0290_lhd", 4.5F);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task x02_0300_lhd()
        {
            await sleep(356);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0300_lhd", 4127003588U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0300_lhd", 6.5F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task x02_0310_lhd()
        {
            await sleep(556);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0310_lhd", 4127069125U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0310_lhd", 2.5F);
            unit_set_emotional_state(miranda_x02.Entity, "shocked", 0.25F, 60);
            print("miranda - shocked .25 60");
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_06()
        {
            cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            object_uses_cinematic_lighting(chief_x02.Entity, true);
            object_uses_cinematic_lighting(johnson_x02.Entity, true);
            object_uses_cinematic_lighting(hood_x02.Entity, true);
            object_uses_cinematic_lighting(miranda_x02.Entity, true);
            object_uses_cinematic_lighting(cortana_x02.Entity, true);
            object_uses_cinematic_lighting(marine_01.Entity, true);
            object_uses_cinematic_lighting(marine_02.Entity, true);
            object_uses_cinematic_lighting(marine_03.Entity, true);
            object_uses_cinematic_lighting(marine_04.Entity, true);
            object_uses_cinematic_lighting(medal_01.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x02_marine_crowd_03()
        {
            await sleep(0);
            print("create marine crowd 02");
            object_create_anew_containing("x02_marine_prop_03");
            object_uses_cinematic_lighting(x02_marine_prop_03_01.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_02.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_03.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_04.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_05.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_06.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_07.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_08.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_09.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_10.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_11.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_12.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_13.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_14.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_16.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_17.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_18.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_19.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_20.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_21.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_22.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_23.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_24.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_25.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_26.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_27.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_28.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_29.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_30.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_31.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_32.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_33.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_34.Entity, true);
            object_uses_cinematic_lighting(x02_marine_prop_03_35.Entity, true);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task x02_06_setup()
        {
            object_create_anew(chief_x02);
            object_create_anew(hood_x02);
            object_create_anew(cortana_x02);
            object_create_anew(miranda_x02);
            object_create_anew(johnson_x02);
            object_create_anew(marine_01);
            object_create_anew(marine_02);
            object_create_anew(marine_03);
            object_create_anew(marine_04);
            object_create_anew(medal_01);
            object_cinematic_lod(chief_x02.Entity, true);
            object_cinematic_lod(hood_x02.Entity, true);
            object_cinematic_lod(cortana_x02.Entity, true);
            object_cinematic_lod(miranda_x02.Entity, true);
            object_cinematic_lod(johnson_x02.Entity, true);
            object_cinematic_lod(marine_01.Entity, true);
            object_cinematic_lod(marine_02.Entity, true);
            object_cinematic_lod(marine_03.Entity, true);
            object_cinematic_lod(marine_04.Entity, true);
            object_cinematic_lod(medal_01.Entity, true);
            object_set_permutation(marine_01.Entity, "head", "perez");
            object_set_permutation(marine_02.Entity, "head", "smith");
            object_set_permutation(marine_03.Entity, "head", "walter");
            object_set_permutation(marine_04.Entity, "head", "dion");
            wake(new ScriptMethodReference(x02_marine_crowd_03));
            wake(new ScriptMethodReference(x02_foley_06));
            wake(new ScriptMethodReference(x02_0280_lhd));
            wake(new ScriptMethodReference(x02_0290_lhd));
            wake(new ScriptMethodReference(x02_0300_lhd));
            wake(new ScriptMethodReference(x02_0310_lhd));
            wake(new ScriptMethodReference(cinematic_lighting_x02_06));
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task x02_06_cleanup()
        {
            object_hide(marine_01.Entity, true);
            object_destroy_containing("medal");
            object_destroy_containing("x02_marine_prop_03");
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x02_scene_06()
        {
            cinematic_lightmap_shadow_enable();
            await this.x02_06_predict_stub();
            await this.x02_06_setup();
            disable_render_light_suppressor();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_06", default(IUnit), anchor_flag_x02_01);
            custom_animation_relative(chief_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4122874757U), "chief_06", false, anchor_x02_01.Entity);
            custom_animation_relative(johnson_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "johnson_06", false, anchor_x02_01.Entity);
            custom_animation_relative(hood_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4125103015U), "hood_06", false, anchor_x02_01.Entity);
            custom_animation_relative(miranda_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x02\\x02", 4125234089U), "miranda_06", false, anchor_x02_01.Entity);
            custom_animation_relative(cortana_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x02\\x02", 4125299626U), "cortana_06", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine01_06", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine02_06", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine03_06", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine04_06", false, anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_cortana_stand.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4125365163U), "cortana_stand_06", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_medal_tray.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\medal_tray\\x02\\x02", 4125430700U), "medal_tray_06", anchor_x02_01.Entity);
            scenery_animation_start_relative(medal_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\medals\\colonial_cross\\x02\\x02", 4126086070U), "cross1_06", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_unsc_logo.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\x02\\x02", 4125496237U), "unsc_logo_06", anchor_x02_01.Entity);
            await sleep(30);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_08_mus", 4127134662U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_07_fol", 4127200199U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            enable_render_light_suppressor();
            await this.x02_06_cleanup();
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task x02_score_08()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\music\\x02_08_mus", 4127134662U), default(IGameObject), 1F);
            print("x02 score 08 start");
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task x02_foley_07()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_07_fol", 4127200199U), default(IGameObject), 1F);
            print("x02 foley 07 start");
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task x02_0320_der()
        {
            await sleep(540);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0320_der", 4127265736U), default(IGameObject), 1F);
            cinematic_subtitle("x02_0320_der", 4F);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task x02_07_dof_01()
        {
            await sleep(80);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1.5F, 1F, 1F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(70);
            cinematic_screen_effect_set_depth_of_field(1.5F, 1F, 0F, 0.5F, 0F, 1F, 0.5F);
            print("rack focus");
            await sleep(80);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task effect_helmet_smoke()
        {
            await sleep(0);
            print("effect - helmet smoke");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\02\\charred_smoke_small", 4127331273U), x02_elite_helmet.Entity, "head");
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task effect_brand()
        {
            await sleep(425);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\cinematics\\branding_iron\\branding_iron_burn", 4127396810U), branding_iron_02.Entity, "smoke");
            print("ouch");
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_07()
        {
            cinematic_lighting_set_primary_light(90F, 248F, 0.345098F, 0.286275F, 0.270588F);
            cinematic_lighting_set_secondary_light(90F, 36F, 0.0784314F, 0.0745098F, 0.0901961F);
            cinematic_lighting_set_ambient_light(0.0509804F, 0.0509804F, 0.0509804F);
            object_uses_cinematic_lighting(dervish_nude.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(x02_elite_helmet.Entity, true);
            object_uses_cinematic_lighting(branding_iron_01.Entity, true);
            object_uses_cinematic_lighting(branding_iron_02.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task backup_brand()
        {
            await sleep(231);
            scenery_animation_start_relative(branding_iron_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\branding_iron\\x02\\x02", 4127527884U), "branding_iron01_07", anchor_x02_02.Entity);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task bring_back_brand()
        {
            await sleep(90);
            object_hide(branding_iron_02.Entity, false);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task delete_brand()
        {
            await sleep(363);
            print("destroy branding-iron");
            object_destroy(branding_iron_01.Entity);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task emotion_tartarus_07()
        {
            await sleep(180);
            unit_set_emotional_state(tartarus.Entity, "pensive", 1F, 0);
            print("tartarus - pensive 1 0");
            await sleep(63);
            unit_set_emotional_state(tartarus.Entity, "amorous", 1F, 30);
            print("tartaurs - amorous 1 30");
        }

        [ScriptMethod(139, Lifecycle.Static)]
        public async Task x02_07_setup()
        {
            object_create_anew(dervish_nude);
            object_create_anew(tartarus);
            object_create_anew(x02_elite_helmet);
            object_create_anew(branding_iron_01);
            object_create_anew(branding_iron_02);
            object_create_anew_containing("cov_crowd_02");
            wake(new ScriptMethodReference(delete_brand));
            object_cinematic_lod(dervish_nude.Entity, true);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(branding_iron_01.Entity, true);
            object_cinematic_lod(branding_iron_02.Entity, true);
            wake(new ScriptMethodReference(x02_foley_07));
            wake(new ScriptMethodReference(x02_0320_der));
            wake(new ScriptMethodReference(effect_helmet_smoke));
            wake(new ScriptMethodReference(backup_brand));
            wake(new ScriptMethodReference(effect_brand));
            wake(new ScriptMethodReference(cinematic_lighting_x02_07));
            wake(new ScriptMethodReference(emotion_tartarus_07));
        }

        [ScriptMethod(140, Lifecycle.Static)]
        public async Task x02_07_cleanup()
        {
            object_destroy(dervish_nude.Entity);
            object_destroy(tartarus.Entity);
            object_destroy_containing("cov_crowd_02");
            object_destroy(x02_elite_helmet.Entity);
            object_destroy_containing("branding");
            object_destroy_containing("x02_column");
            object_destroy_containing("x02_manacle");
            object_destroy_containing("x02_dervish_lift");
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task x02_scene_07()
        {
            cinematic_lightmap_shadow_disable();
            await this.x02_07_predict_stub();
            await this.x02_07_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_07", default(IUnit), anchor_flag_x02_02);
            custom_animation_relative(dervish_nude.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x02_alt\\x02_alt", 4127593421U), "dervish_07", false, anchor_x02_02.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x02\\x02", 4123267979U), "tartarus_07", false, anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_elite_helmet.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\elite_helmet_charred\\elite_helmet_charred", 4127724495U), "helmet_charred_07", anchor_x02_02.Entity);
            scenery_animation_start_relative(branding_iron_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\branding_iron\\x02\\x02", 4127527884U), "branding_iron02_07", anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_manacle_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4123595664U), "manacle1_07", anchor_x02_02.Entity);
            scenery_animation_start_relative(x02_manacle_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\manacles\\x02\\x02", 4123595664U), "manacle2_07", anchor_x02_02.Entity);
            object_hide(branding_iron_02.Entity, true);
            wake(new ScriptMethodReference(bring_back_brand));
            await sleep(5);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_08_fol", 4127790032U));
            wake(new ScriptMethodReference(x02_score_08));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.x02_07_cleanup();
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task x02_foley_08()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_08_fol", 4127790032U), default(IGameObject), 1F);
            print("x02 foley 08 start");
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task x02_0330_cor()
        {
            await sleep(1);
            unit_set_emotional_state(hood_x02.Entity, "shocked", 0.25F, 0);
            unit_set_emotional_state(cortana_x02.Entity, "angry", 0.5F, 0);
            await sleep(71);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0330_cor", 4127855569U), cortana_x02.Entity, 1F);
            cinematic_subtitle("x02_0330_cor", 3F);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task x02_0340_lhd()
        {
            unit_set_emotional_state(hood_x02.Entity, "angry", 0.5F, 15);
            print("hood - angry .5 15");
            await sleep(150);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0340_lhd", 4127921106U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0340_lhd", 1F);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task x02_0350_cor()
        {
            await sleep(180);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0350_cor", 4127986643U), cortana_x02.Entity, 1F);
            cinematic_subtitle("x02_0350_cor", 4F);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task x02_0360_ahp()
        {
            await sleep(311);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0360_ahp", 4128052180U), default(IGameObject), 1F, "radio_default");
            cinematic_subtitle("x02_0360_ahp", 3F);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task x02_0370_lhd()
        {
            unit_set_emotional_state(hood_x02.Entity, "pensive", 0.5F, 15);
            print("hood - pensive .5 15");
            unit_set_emotional_state(miranda_x02.Entity, "shocked", 0.15F, 0);
            await sleep(415);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0370_lhd", 4128117717U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0370_lhd", 4F);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task x02_0380_lhd()
        {
            await sleep(548);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0380_lhd", 4128183254U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0380_lhd", 2.5F);
            await sleep(75);
            unit_set_emotional_state(miranda_x02.Entity, "angry", 0.5F, 15);
            print("miranda - angry .5 15");
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task x02_0390_mir()
        {
            await sleep(632);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0390_mir", 4128248791U), miranda_x02.Entity, 1F);
            cinematic_subtitle("x02_0390_mir", 1F);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task x02_0400_lhd()
        {
            await sleep(676);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0400_lhd", 4128314328U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0400_lhd", 4F);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task x02_0405_cor()
        {
            await sleep(793);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0405_cor", 4128379865U), cortana_x02.Entity, 1F);
            cinematic_subtitle("x02_0405_cor", 1F);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task x02_0410_lhd()
        {
            await sleep(825);
            unit_set_emotional_state(hood_x02.Entity, "annoyed", 0.75F, 60);
            print("hood - annoyed .75 60");
            await sleep(30);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0410_lhd", 4128445402U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0410_lhd", 5F);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task effect_cortana_off()
        {
            await sleep(809);
            print("cortana off");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4124251034U), x02_cortana_stand.Entity, "holo_effect");
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_08()
        {
            cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            object_uses_cinematic_lighting(chief_x02.Entity, true);
            object_uses_cinematic_lighting(johnson_x02.Entity, true);
            object_uses_cinematic_lighting(hood_x02.Entity, true);
            object_uses_cinematic_lighting(miranda_x02.Entity, true);
            object_uses_cinematic_lighting(cortana_x02.Entity, true);
            object_uses_cinematic_lighting(marine_02.Entity, true);
            object_uses_cinematic_lighting(marine_03.Entity, true);
            object_uses_cinematic_lighting(marine_04.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(155, Lifecycle.Static)]
        public async Task x02_08_setup()
        {
            object_create(chief_x02);
            object_create_anew(hood_x02);
            object_create_anew(cortana_x02);
            object_create_anew(miranda_x02);
            object_create_anew(johnson_x02);
            object_create_anew(marine_02);
            object_create_anew(marine_03);
            object_create_anew(marine_04);
            object_create_anew(x02_tactical_display);
            object_cinematic_lod(chief_x02.Entity, true);
            object_cinematic_lod(hood_x02.Entity, true);
            object_cinematic_lod(cortana_x02.Entity, true);
            object_cinematic_lod(miranda_x02.Entity, true);
            object_cinematic_lod(johnson_x02.Entity, true);
            object_cinematic_lod(marine_02.Entity, true);
            object_cinematic_lod(marine_03.Entity, true);
            object_cinematic_lod(marine_04.Entity, true);
            object_set_permutation(marine_02.Entity, "head", "smith");
            object_set_permutation(marine_03.Entity, "head", "walter");
            object_set_permutation(marine_04.Entity, "head", "dion");
            wake(new ScriptMethodReference(x02_foley_08));
            wake(new ScriptMethodReference(x02_0330_cor));
            wake(new ScriptMethodReference(x02_0340_lhd));
            wake(new ScriptMethodReference(x02_0350_cor));
            wake(new ScriptMethodReference(x02_0360_ahp));
            wake(new ScriptMethodReference(x02_0370_lhd));
            wake(new ScriptMethodReference(x02_0380_lhd));
            wake(new ScriptMethodReference(x02_0390_mir));
            wake(new ScriptMethodReference(x02_0400_lhd));
            wake(new ScriptMethodReference(x02_0405_cor));
            wake(new ScriptMethodReference(x02_0410_lhd));
            wake(new ScriptMethodReference(effect_cortana_off));
            wake(new ScriptMethodReference(cinematic_lighting_x02_08));
        }

        [ScriptMethod(156, Lifecycle.Static)]
        public async Task x02_scene_08_cleanup()
        {
            object_destroy(miranda_x02.Entity);
            object_destroy(cortana_x02.Entity);
            object_destroy(marine_02.Entity);
            object_destroy(marine_03.Entity);
            object_destroy(marine_04.Entity);
        }

        [ScriptMethod(157, Lifecycle.Static)]
        public async Task x02_scene_08()
        {
            cinematic_lightmap_shadow_enable();
            await this.x02_08_predict_stub();
            await this.x02_08_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_08", default(IUnit), anchor_flag_x02_01);
            custom_animation_relative(chief_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4122874757U), "chief_08", false, anchor_x02_01.Entity);
            custom_animation_relative(johnson_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "johnson_08", false, anchor_x02_01.Entity);
            custom_animation_relative(hood_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4125103015U), "hood_08", false, anchor_x02_01.Entity);
            custom_animation_relative(miranda_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x02\\x02", 4125234089U), "miranda_08", false, anchor_x02_01.Entity);
            custom_animation_relative(cortana_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x02\\x02", 4125299626U), "cortana_08", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine02_08", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine03_08", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine04_08", false, anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_cortana_stand.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4125365163U), "cortana_stand_08", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_unsc_logo.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\x02\\x02", 4125496237U), "unsc_logo_08", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_tactical_display.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\x02\\x02", 4128510939U), "display_large_08", anchor_x02_01.Entity);
            await sleep(30);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x02_09_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_09_fol", 4128576476U));
            await sleep((short)camera_time());
            await this.x02_scene_08_cleanup();
        }

        [ScriptMethod(158, Lifecycle.CommandScript)]
        public async Task cs_x02_panic_01()
        {
            cs_force_combat_status(3);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("x02_run/p0"));
                cs_look(true, GetReference<ISpatialPoint>("x02_look/p0"));
                await sleep(60);
                cs_go_to(GetReference<ISpatialPoint>("x02_run/p1"));
                cs_look(true, GetReference<ISpatialPoint>("x02_look/p1"));
                return false;
            });
        }

        [ScriptMethod(159, Lifecycle.CommandScript)]
        public async Task cs_x02_panic_02()
        {
            cs_force_combat_status(3);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("x02_run/p2"));
                cs_look(true, GetReference<ISpatialPoint>("x02_look/p2"));
                await sleep(60);
                cs_go_to(GetReference<ISpatialPoint>("x02_run/p3"));
                cs_look(true, GetReference<ISpatialPoint>("x02_look/p3"));
                return false;
            });
        }

        [ScriptMethod(160, Lifecycle.CommandScript)]
        public async Task cs_x02_panic_03()
        {
            cs_force_combat_status(3);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("x02_run/p0"));
                cs_look(true, GetReference<ISpatialPoint>("x02_look/p0"));
                await sleep(60);
                cs_go_to(GetReference<ISpatialPoint>("x02_run/p2"));
                cs_look(true, GetReference<ISpatialPoint>("x02_look/p2"));
                return false;
            });
        }

        [ScriptMethod(161, Lifecycle.CommandScript)]
        public async Task cs_x02_panic_04()
        {
            cs_force_combat_status(3);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("x02_run/p3"));
                cs_look(true, GetReference<ISpatialPoint>("x02_look/p3"));
                await sleep(60);
                cs_go_to(GetReference<ISpatialPoint>("x02_run/p1"));
                cs_look(true, GetReference<ISpatialPoint>("x02_look/p1"));
                return false;
            });
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task x02_foley_09()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_09_fol", 4128576476U), default(IGameObject), 1F);
            print("x02 foley 09 start");
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task x02_0420_to1()
        {
            await sleep(107);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0420_to1", 4128642013U), default(IGameObject), 1F);
            cinematic_subtitle("x02_0420_to1", 1.5F);
            unit_set_emotional_state(marine_01.Entity, "annoyed", 0.5F, 0);
            unit_set_emotional_state(marine_01.Entity, "pensive", 0.5F, 0);
            await sleep(45);
            unit_set_emotional_state(marine_01.Entity, "annoyed", 1F, 10);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task x02_0430_to1()
        {
            await sleep(159);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0430_to1", 4128707550U), marine_01.Entity, 1F);
            cinematic_subtitle("x02_0430_to1", 1.5F);
            await sleep(10);
            unit_set_emotional_state(marine_01.Entity, "shocked", 0.25F, 0);
            print("marine_01 - shocked .5 0");
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task x02_0440_lhd()
        {
            await sleep(208);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0440_lhd", 4128773087U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0440_lhd", 5F);
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task x02_0450_lhd()
        {
            await sleep(367);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0450_lhd", 4128838624U), hood_x02.Entity, 1F);
            cinematic_subtitle("x02_0450_lhd", 3F);
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task x02_0460_mas()
        {
            await sleep(462);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0460_mas", 4128904161U), chief_x02.Entity, 1F);
            cinematic_subtitle("x02_0460_mas", 1F);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task x02_0480_mas()
        {
            await sleep(497);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0480_mas", 4128969698U), chief_x02.Entity, 1F);
            cinematic_subtitle("x02_0480_mas", 1F);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task x02_0490_jon()
        {
            await sleep(529);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\x02_0490_jon", 4129035235U), johnson_x02.Entity, 1F);
            cinematic_subtitle("x02_0490_jon", 2F);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_09()
        {
            cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task x02_fov_09_01()
        {
            await sleep(166);
            camera_set_field_of_view(23F, 10);
            print("fov change: 60 -> 23 over 10 ticks");
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task x02_fov_09_02()
        {
            await sleep(206);
            camera_set_field_of_view(60F, 0);
            print("fov change: 23 -> 60 over 0 ticks");
        }

        [ScriptMethod(173, Lifecycle.Static)]
        public async Task place_x02_ai()
        {
            ai_place(x02_panic_01.Squad);
            ai_place(x02_panic_02.Squad);
            ai_place(x02_panic_03.Squad);
            ai_place(x02_panic_04.Squad);
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task x02_09_setup()
        {
            object_hide(marine_01.Entity, false);
            wake(new ScriptMethodReference(x02_foley_09));
            wake(new ScriptMethodReference(x02_0420_to1));
            wake(new ScriptMethodReference(x02_0430_to1));
            wake(new ScriptMethodReference(x02_0440_lhd));
            wake(new ScriptMethodReference(x02_0450_lhd));
            wake(new ScriptMethodReference(x02_0460_mas));
            wake(new ScriptMethodReference(x02_0480_mas));
            wake(new ScriptMethodReference(x02_0490_jon));
            await this.place_x02_ai();
            wake(new ScriptMethodReference(x02_fov_09_01));
            wake(new ScriptMethodReference(x02_fov_09_02));
            wake(new ScriptMethodReference(cinematic_lighting_x02_09));
        }

        [ScriptMethod(175, Lifecycle.Static)]
        public async Task x02_scene_09()
        {
            wake(new ScriptMethodReference(x02_09_setup));
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_09", default(IUnit), anchor_flag_x02_01);
            custom_animation_relative(chief_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4122874757U), "chief_09", false, anchor_x02_01.Entity);
            custom_animation_relative(johnson_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "johnson_09", false, anchor_x02_01.Entity);
            custom_animation_relative(hood_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4125103015U), "hood_09", false, anchor_x02_01.Entity);
            custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "marine01_09", false, anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_tactical_display.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\x02\\x02", 4128510939U), "display_large_09", anchor_x02_01.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x02_10_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_10_fol", 4129100772U));
            await sleep((short)camera_time());
            object_destroy(marine_01.Entity);
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task x02_foley_10()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\x02\\foley\\x02_10_fol", 4129100772U), default(IGameObject), 1F);
            print("x02 foley 10 start");
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x02_10()
        {
            cinematic_lighting_set_primary_light(61F, 116F, 0.356863F, 0.317647F, 0.301961F);
            cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            cinematic_lighting_set_ambient_light(0.105882F, 0.101961F, 0.14902F);
            object_uses_cinematic_lighting(poa_x02.Entity, true);
            object_uses_cinematic_lighting(fighter_x02_01.Entity, true);
            object_uses_cinematic_lighting(fighter_x02_02.Entity, true);
            object_uses_cinematic_lighting(fighter_x02_03.Entity, true);
            object_uses_cinematic_lighting(fighter_x02_04.Entity, true);
            object_uses_cinematic_lighting(fighter_x02_05.Entity, true);
            object_uses_cinematic_lighting(fighter_x02_06.Entity, true);
            object_uses_cinematic_lighting(fighter_x02_07.Entity, true);
            object_uses_cinematic_lighting(fighter_x02_08.Entity, true);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task fighters_unhide()
        {
            await sleep(5);
            print("fighters unhide");
            object_hide(fighter_x02_01.Entity, false);
            object_hide(fighter_x02_02.Entity, false);
            object_hide(fighter_x02_03.Entity, false);
            object_hide(fighter_x02_04.Entity, false);
            object_hide(fighter_x02_05.Entity, false);
            object_hide(fighter_x02_06.Entity, false);
            object_hide(fighter_x02_07.Entity, false);
            object_hide(fighter_x02_08.Entity, false);
        }

        [ScriptMethod(179, Lifecycle.Static)]
        public async Task x02_10_setup()
        {
            object_create(poa_x02);
            object_create(fighter_x02_01);
            object_create(fighter_x02_02);
            object_create(fighter_x02_03);
            object_create(fighter_x02_04);
            object_create(fighter_x02_05);
            object_create(fighter_x02_06);
            object_create(fighter_x02_07);
            object_create(fighter_x02_08);
            object_cinematic_lod(poa_x02.Entity, true);
            object_cinematic_lod(fighter_x02_01.Entity, true);
            object_cinematic_lod(fighter_x02_02.Entity, true);
            object_cinematic_lod(fighter_x02_03.Entity, true);
            object_cinematic_lod(fighter_x02_04.Entity, true);
            object_cinematic_lod(fighter_x02_05.Entity, true);
            object_cinematic_lod(fighter_x02_06.Entity, true);
            object_cinematic_lod(fighter_x02_07.Entity, true);
            object_cinematic_lod(fighter_x02_08.Entity, true);
            object_hide(fighter_x02_01.Entity, true);
            object_hide(fighter_x02_02.Entity, true);
            object_hide(fighter_x02_03.Entity, true);
            object_hide(fighter_x02_04.Entity, true);
            object_hide(fighter_x02_05.Entity, true);
            object_hide(fighter_x02_06.Entity, true);
            object_hide(fighter_x02_07.Entity, true);
            object_hide(fighter_x02_08.Entity, true);
            wake(new ScriptMethodReference(x02_foley_10));
            wake(new ScriptMethodReference(fighters_unhide));
            wake(new ScriptMethodReference(cinematic_lighting_x02_10));
        }

        [ScriptMethod(180, Lifecycle.Static)]
        public async Task x02_scene_10_cleanup()
        {
            object_destroy(chief_x02.Entity);
            object_destroy(johnson_x02.Entity);
            object_destroy(hood_x02.Entity);
            object_destroy(x02_cortana_stand.Entity);
            object_destroy(x02_tactical_display.Entity);
            object_destroy(poa_x02.Entity);
            object_destroy_containing("fighter_x02");
        }

        [ScriptMethod(181, Lifecycle.Static)]
        public async Task x02_scene_10()
        {
            await this.x02_10_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x02\\x02", 4122809220U), "x02_10", default(IUnit), anchor_flag_x02_01);
            custom_animation_relative(chief_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x02\\x02", 4122874757U), "chief_10", false, anchor_x02_01.Entity);
            custom_animation_relative(johnson_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 4122612609U), "johnson_10", false, anchor_x02_01.Entity);
            custom_animation_relative(hood_x02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x02\\x02", 4125103015U), "hood_10", false, anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_cortana_stand.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\x02\\x02", 4125365163U), "cortana_stand_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(x02_tactical_display.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\x02\\x02", 4128510939U), "display_large_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(poa_x02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\x02\\x02", 4129166309U), "poa_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(fighter_x02_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4129231846U), "longsword01_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(fighter_x02_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4129231846U), "longsword02_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(fighter_x02_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4129231846U), "longsword03_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(fighter_x02_04.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4129231846U), "longsword04_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(fighter_x02_05.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4129231846U), "longsword05_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(fighter_x02_06.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4129231846U), "longsword06_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(fighter_x02_07.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4129231846U), "longsword07_10", anchor_x02_01.Entity);
            scenery_animation_start_relative(fighter_x02_08.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\x02\\x02", 4129231846U), "longsword08_10", anchor_x02_01.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.x02_scene_10_cleanup();
            await sleep(30);
        }

        [ScriptMethod(182, Lifecycle.Static)]
        public async Task x02()
        {
            texture_cache_flush();
            geometry_cache_flush();
            cinematic_enable_ambience_details(false);
            sound_class_set_gain("device_machinery", 0F, 15);
            switch_bsp_by_name(GetReference<IBsp>("01_bsp_0"));
            await sleep(1);
            await this.x02_scene_01();
            switch_bsp_by_name(GetReference<IBsp>("high_0"));
            await sleep(5);
            await this.x02_scene_02();
            await this.x02_scene_03();
            switch_bsp_by_name(GetReference<IBsp>("01_bsp_1"));
            await sleep(5);
            await this.x02_scene_04a();
            await this.x02_scene_04b();
            switch_bsp_by_name(GetReference<IBsp>("high_0"));
            await sleep(5);
            await this.x02_scene_05();
            switch_bsp_by_name(GetReference<IBsp>("01_bsp_1"));
            await sleep(5);
            await this.x02_scene_06();
            switch_bsp_by_name(GetReference<IBsp>("high_0"));
            await sleep(5);
            await this.x02_scene_07();
            switch_bsp_by_name(GetReference<IBsp>("01_bsp_1"));
            await sleep(5);
            await this.x02_scene_08();
            await this.x02_scene_09();
            await this.x02_scene_10();
            sound_class_set_gain("device_machinery", 1F, 15);
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task c01_outro_score_01()
        {
            await sleep(259);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\music\\c01_outro_01_mus", 4129297383U), default(IGameObject), 1F);
            print("c01_outro score 01 start");
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task c01_outro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_01_fol", 4129362920U), default(IGameObject), 1F);
            print("c01_outro foley 01 start");
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task c01_9010_cor()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9010_cor", 4129428457U), cortana.Entity, 1F);
            cinematic_subtitle("c01_9010_cor", 2F);
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task c01_9050_mas()
        {
            await sleep(311);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9050_mas", 4129493994U), chief.Entity, 1F);
            cinematic_subtitle("c01_9050_mas", 2F);
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task c01_9060_cor()
        {
            await sleep(349);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9060_cor", 4129559531U), default(IGameObject), 1F);
            cinematic_subtitle("c01_9060_cor", 2F);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task c01_9070_mir()
        {
            await sleep(393);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9070_mir", 4129625068U), default(IGameObject), 1F, "radio_default");
            cinematic_subtitle("c01_9070_mir", 2F);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task cinematic_lighting_outro_01()
        {
            cinematic_lighting_set_primary_light(33F, 188F, 0.388235F, 0.380392F, 0.372549F);
            cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(cortana.Entity, true);
            object_uses_cinematic_lighting(pickle.Entity, true);
            object_uses_cinematic_lighting(outro_cortana_stand.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task effects_cortana_transfer()
        {
            await sleep(125);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4124251034U), outro_cortana_base.Entity, "marker");
            await sleep(20);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\masterchief\\data_transfer", 4129690605U), chief.Entity, "right_hand");
        }

        [ScriptMethod(191, Lifecycle.Static)]
        public async Task test()
        {
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4124251034U), outro_cortana_base.Entity, "marker");
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task bomb_deactivate()
        {
            await sleep(284);
            print("bomb deactivate");
            object_set_function_variable(pickle.Entity, "flare", 0F, 1F);
        }

        [ScriptMethod(193, Lifecycle.Static)]
        public async Task c01_outro_02_problem_actors()
        {
            print("problem actors");
            object_create_anew(miranda);
            object_create_anew(johnson);
            object_create_anew(iac_bridge_outro_01);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(iac_bridge_outro_01.Entity, true);
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task upload_cortana()
        {
            time_code_reset();
            await sleep(135);
            print("upload cortana");
            object_destroy(cortana.Entity);
        }

        [ScriptMethod(195, Lifecycle.Static)]
        public async Task c01_outro_01_setup()
        {
            object_create_anew(chief);
            object_create_anew(cortana);
            object_create_anew(pickle);
            object_create_anew(outro_cortana_stand);
            object_create_anew(outro_cortana_base);
            object_destroy_containing("outro_crate");
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(cortana.Entity, true);
            object_cinematic_lod(pickle.Entity, true);
            object_cinematic_lod(outro_cortana_stand.Entity, true);
            wake(new ScriptMethodReference(c01_outro_score_01));
            wake(new ScriptMethodReference(c01_outro_foley_01));
            wake(new ScriptMethodReference(c01_9010_cor));
            wake(new ScriptMethodReference(c01_9050_mas));
            wake(new ScriptMethodReference(c01_9060_cor));
            wake(new ScriptMethodReference(c01_9070_mir));
            wake(new ScriptMethodReference(effects_cortana_transfer));
            wake(new ScriptMethodReference(upload_cortana));
            wake(new ScriptMethodReference(bomb_deactivate));
            wake(new ScriptMethodReference(cinematic_lighting_outro_01));
        }

        [ScriptMethod(196, Lifecycle.Static)]
        public async Task c01_outro_01_cleanup()
        {
            object_destroy(outro_cortana_stand.Entity);
            object_destroy(outro_cortana_base.Entity);
        }

        [ScriptMethod(197, Lifecycle.Static)]
        public async Task c01_outro_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("spacestation_outro");
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.x02_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\music\\c01_outro_01_mus", 4129297383U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_01_fol", 4129362920U));
            await sleep(this.prediction_offset);
            await this.c01_outro_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_01", default(IUnit), anchor_flag_outro1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_01", false, anchor_outro1.Entity);
            custom_animation_relative(cortana.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\01_outro\\01_outro", 4129887216U), "cortana_01", false, anchor_outro1.Entity);
            scenery_animation_start_relative(pickle.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_01", anchor_outro1.Entity);
            scenery_animation_start_relative(outro_cortana_stand.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\01_outro\\01_outro", 4130018290U), "cortana_stand_01", anchor_outro1.Entity);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 4124251034U), outro_cortana_base.Entity, "marker");
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_outro_02_predict_stub();
            await this.c01_outro_02_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_02_fol", 4130083827U));
            await sleep((short)camera_time());
            await this.c01_outro_01_cleanup();
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task c01_outro_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_02_fol", 4130083827U), default(IGameObject), 1F);
            print("c01_outro foley 02 start");
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task c01_9080_mir()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9080_mir", 4130149364U), miranda.Entity, 1F);
            cinematic_subtitle("c01_9080_mir", 3F);
            await sleep(1);
            unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 0);
            unit_set_emotional_state(hood.Entity, "annoyed", 0.5F, 0);
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task c01_9090_lhd()
        {
            await sleep(113);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9090_lhd", 4130214901U), hood.Entity, 1F);
            cinematic_subtitle("c01_9090_lhd", 4F);
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task c01_9100_mas()
        {
            await sleep(227);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9100_mas", 4130280438U), default(IGameObject), 1F, "radio_default");
            cinematic_subtitle("c01_9100_mas", 1F);
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task c01_9110_mas()
        {
            await sleep(250);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9110_mas", 4130345975U), chief.Entity, 1F);
            cinematic_subtitle("c01_9110_mas", 1F);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task c01_9120_lhd()
        {
            await sleep(290);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9120_lhd", 4130411512U), hood.Entity, 1F);
            cinematic_subtitle("c01_9120_lhd", 2F);
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task c01_9130_mas()
        {
            await sleep(343);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9130_mas", 4130477049U), default(IGameObject), 1F, "radio_default");
            cinematic_subtitle("c01_9130_mas", 2F);
            await sleep(77);
            unit_set_emotional_state(hood.Entity, "happy", 0.25F, 90);
            print("hood - happy .25 90");
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task c01_9140_lhd()
        {
            await sleep(436);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9140_lhd", 4130542586U), hood.Entity, 1F);
            cinematic_subtitle("c01_9140_lhd", 1F);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bridges_01a()
        {
            time_code_reset();
            print("light miranda");
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(iac_bridge_outro_01.Entity, true);
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bridges_01b()
        {
            await sleep(111);
            print("light hood");
            cinematic_lighting_set_primary_light(-21F, 102F, 0.368627F, 0.333333F, 0.258824F);
            cinematic_lighting_set_secondary_light(13F, 294F, 0.192157F, 0.2F, 0.243137F);
            cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
            object_uses_cinematic_lighting(hood.Entity, true);
            object_uses_cinematic_lighting(cairo_bridge.Entity, true);
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task cinematic_lighting_chief_01()
        {
            await sleep(240);
            print("light chief");
            cinematic_lighting_set_primary_light(-12F, 294F, 0.47451F, 0.419608F, 0.392157F);
            cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(pickle.Entity, true);
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bridges_02()
        {
            await sleep(288);
            print("light hood");
            cinematic_lighting_set_primary_light(-21F, 102F, 0.368627F, 0.333333F, 0.258824F);
            cinematic_lighting_set_secondary_light(13F, 294F, 0.192157F, 0.2F, 0.243137F);
            cinematic_lighting_set_ambient_light(0.00784314F, 0.00784314F, 0.00784314F);
        }

        [ScriptMethod(210, Lifecycle.Static)]
        public async Task c01_outro_02_setup()
        {
            object_create_anew(hood);
            object_create_anew(cairo_bridge);
            object_cinematic_lod(hood.Entity, true);
            object_cinematic_lod(cairo_bridge.Entity, true);
            wake(new ScriptMethodReference(c01_outro_foley_02));
            wake(new ScriptMethodReference(c01_9080_mir));
            wake(new ScriptMethodReference(c01_9090_lhd));
            wake(new ScriptMethodReference(c01_9100_mas));
            wake(new ScriptMethodReference(c01_9110_mas));
            wake(new ScriptMethodReference(c01_9120_lhd));
            wake(new ScriptMethodReference(c01_9130_mas));
            wake(new ScriptMethodReference(c01_9140_lhd));
            wake(new ScriptMethodReference(cinematic_lighting_bridges_01a));
            wake(new ScriptMethodReference(cinematic_lighting_bridges_01b));
            wake(new ScriptMethodReference(cinematic_lighting_chief_01));
            wake(new ScriptMethodReference(cinematic_lighting_bridges_02));
        }

        [ScriptMethod(211, Lifecycle.Static)]
        public async Task c01_outro_02_cleanup()
        {
            object_destroy(hood.Entity);
            object_destroy(miranda.Entity);
            object_destroy(johnson.Entity);
            object_destroy(iac_bridge_outro_01.Entity);
            object_destroy(cairo_bridge.Entity);
        }

        [ScriptMethod(212, Lifecycle.Static)]
        public async Task c01_outro_scene_02()
        {
            pvs_set_object(anchor_outro1.Entity);
            await this.c01_outro_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_02", default(IUnit), anchor_flag_outro1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_02", false, anchor_outro1.Entity);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\01_outro\\01_outro", 4130608123U), "miranda_02", false, anchor_outro1.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\01_outro\\01_outro", 4130673660U), "johnson_02", false, anchor_outro1.Entity);
            custom_animation_relative(hood.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\01_outro\\01_outro", 4130739197U), "hood_02", false, anchor_outro1.Entity);
            scenery_animation_start_relative(pickle.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_02", anchor_outro1.Entity);
            scenery_animation_start_relative(iac_bridge_outro_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\01_outro\\01_outro", 4130804734U), "iac_bridge_02", anchor_outro1.Entity);
            scenery_animation_start_relative(cairo_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge\\01_outro\\01_outro", 4130870271U), "cairo_bridge_02", anchor_outro1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_outro_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_03_fol", 4130935808U));
            await sleep((short)camera_time());
            await this.c01_outro_02_cleanup();
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task c01_outro_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_03_fol", 4130935808U), default(IGameObject), 1F);
            print("c01_outro foley 03 start");
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task doors_outro_03()
        {
            device_set_position(outro_door_01.Entity, 1F);
            await sleep(360);
            device_group_change_only_once_more_set(outro_door_011, false);
            device_set_position(outro_door_01.Entity, 0F);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task outro_sparks_03()
        {
            await sleep(101);
            object_create_anew_containing("sparks_backward");
            objects_attach(pickle.Entity, "sparks01", sparks_backward_01.Entity, "marker");
            objects_attach(pickle.Entity, "sparks03", sparks_backward_02.Entity, "marker");
            objects_attach(pickle.Entity, "sparks04", sparks_backward_03.Entity, "marker");
            objects_attach(pickle.Entity, "sparks07", sparks_backward_04.Entity, "marker");
            objects_attach(pickle.Entity, "sparks08", sparks_backward_05.Entity, "marker");
            await sleep(36);
            object_destroy_containing("sparks_backward");
            await sleep(25);
            object_create_anew_containing("sparks_backward");
            objects_attach(pickle.Entity, "sparks01", sparks_backward_01.Entity, "marker");
            objects_attach(pickle.Entity, "sparks03", sparks_backward_02.Entity, "marker");
            objects_attach(pickle.Entity, "sparks04", sparks_backward_03.Entity, "marker");
            objects_attach(pickle.Entity, "sparks07", sparks_backward_04.Entity, "marker");
            objects_attach(pickle.Entity, "sparks08", sparks_backward_05.Entity, "marker");
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task cinematic_lighting_chief_02()
        {
            print("light chief");
            cinematic_lighting_set_primary_light(33F, 188F, 0.388235F, 0.380392F, 0.372549F);
            cinematic_lighting_set_secondary_light(-28F, 54F, 0.207843F, 0.219608F, 0.258824F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(outro_elevator.Entity, true);
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task c01_outro_03_setup()
        {
            wake(new ScriptMethodReference(c01_outro_foley_03));
            object_create_anew(outro_elevator);
            object_cinematic_lod(outro_elevator.Entity, true);
            wake(new ScriptMethodReference(doors_outro_03));
            wake(new ScriptMethodReference(outro_sparks_03));
            wake(new ScriptMethodReference(cinematic_lighting_chief_02));
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task c01_outro_03_cleanup()
        {
            object_destroy_containing("sparks_backward");
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task c01_outro_scene_03()
        {
            await this.c01_outro_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_03", default(IUnit), anchor_flag_outro1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_03", false, anchor_outro1.Entity);
            scenery_animation_start_relative(pickle.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_03", anchor_outro1.Entity);
            scenery_animation_start_relative(outro_elevator.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\ss_elevator\\01_outro\\01_outro", 4131001345U), "elevator_03", anchor_outro1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_outro_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_04_fol", 4131066882U));
            await sleep((short)camera_time());
            await this.c01_outro_03_cleanup();
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task c01_outro_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_04_fol", 4131066882U), default(IGameObject), 1F);
            print("c01_outro foley 04 start");
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task c01_9150_cor()
        {
            await sleep(30);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9150_cor", 4131132419U), default(IGameObject), 1F);
            cinematic_subtitle("c01_9150_cor", 2F);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task c01_9160_mas()
        {
            await sleep(108);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9160_mas", 4131197956U), chief.Entity, 1F);
            cinematic_subtitle("c01_9160_mas", 2F);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task c01_9170_cor()
        {
            await sleep(154);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9170_cor", 4131263493U), default(IGameObject), 1F);
            cinematic_subtitle("c01_9170_cor", 2F);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task c01_9180_cor()
        {
            await sleep(217);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9180_cor", 4131329030U), default(IGameObject), 1F);
            cinematic_subtitle("c01_9180_cor", 1F);
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task c01_outro_shake_04_01()
        {
            time_code_reset();
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            player_effect_stop(1F);
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task c01_outro_shake_04_02()
        {
            await sleep(105);
            print("shake");
            player_effect_set_max_rotation(0F, 0.35F, 0.35F);
            player_effect_start(0.25F, 0F);
            await sleep(93);
            player_effect_stop(0F);
            print("shake stop");
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task c01_outro_shake_04_03()
        {
            await sleep(227);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 2F);
            await sleep(45);
            player_effect_stop(0F);
            print("shake stop");
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task outro_sparks_03_04()
        {
            object_create_anew_containing("sparks_forward");
            objects_attach(pickle.Entity, "sparks01", sparks_forward_01.Entity, "marker");
            objects_attach(pickle.Entity, "sparks02", sparks_forward_02.Entity, "marker");
            objects_attach(pickle.Entity, "sparks03", sparks_forward_03.Entity, "marker");
            objects_attach(pickle.Entity, "sparks04", sparks_forward_04.Entity, "marker");
            objects_attach(pickle.Entity, "sparks05", sparks_forward_05.Entity, "marker");
            objects_attach(pickle.Entity, "sparks06", sparks_forward_06.Entity, "marker");
            objects_attach(pickle.Entity, "sparks07", sparks_forward_07.Entity, "marker");
            objects_attach(pickle.Entity, "sparks08", sparks_forward_08.Entity, "marker");
            await sleep(490);
            object_destroy_containing("sparks_forward");
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task doors_outro_04()
        {
            await sleep(300);
            device_set_position(outro_door_02.Entity, 1F);
            await sleep(150);
            device_group_change_only_once_more_set(outro_door_021, false);
            device_set_position(outro_door_02.Entity, 0F);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task create_bloom_quad()
        {
            time_code_reset();
            await sleep(273);
            print("create bloom quad");
            object_create_anew(bloom_quad);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task top_light()
        {
            await sleep(105);
            print("delete top light");
            objects_detach(outro_elevator.Entity, elevator_light_top.Entity);
            object_destroy(elevator_light_top.Entity);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task bottom_light()
        {
            await sleep(198);
            print("create bottom light");
            object_create_anew(elevator_light_bottom);
            objects_attach(outro_elevator.Entity, "light_red02", elevator_light_bottom.Entity, "");
        }

        [ScriptMethod(233, Lifecycle.Static)]
        public async Task c01_outro_04_setup()
        {
            render_lights_enable_cinematic_shadow(true, chief.Entity, "head", 0.4F);
            object_create_anew(matte_earth);
            object_create_anew(elevator_light_top);
            object_create_anew(elevator_light_flash);
            objects_attach(outro_elevator.Entity, "light_red01", elevator_light_top.Entity, "");
            wake(new ScriptMethodReference(c01_outro_foley_04));
            wake(new ScriptMethodReference(c01_9150_cor));
            wake(new ScriptMethodReference(c01_9160_mas));
            wake(new ScriptMethodReference(c01_9170_cor));
            wake(new ScriptMethodReference(c01_9180_cor));
            wake(new ScriptMethodReference(doors_outro_04));
            wake(new ScriptMethodReference(outro_sparks_03_04));
            wake(new ScriptMethodReference(create_bloom_quad));
            wake(new ScriptMethodReference(top_light));
            wake(new ScriptMethodReference(bottom_light));
            wake(new ScriptMethodReference(c01_outro_shake_04_01));
            wake(new ScriptMethodReference(c01_outro_shake_04_02));
            wake(new ScriptMethodReference(c01_outro_shake_04_03));
        }

        [ScriptMethod(234, Lifecycle.Static)]
        public async Task c01_outro_04_cleanup()
        {
            objects_detach(outro_elevator.Entity, elevator_light_bottom.Entity);
            object_destroy_containing("elevator");
            object_destroy(bloom_quad.Entity);
        }

        [ScriptMethod(235, Lifecycle.Static)]
        public async Task c01_outro_scene_04()
        {
            await this.c01_outro_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_04", default(IUnit), anchor_flag_outro1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_04", false, anchor_outro1.Entity);
            scenery_animation_start_relative(pickle.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_04", anchor_outro1.Entity);
            scenery_animation_start_relative(outro_elevator.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\ss_elevator\\01_outro\\01_outro", 4131001345U), "elevator_04", anchor_outro1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_outro_05_predict_stub();
            object_create_anew(outro_fleet);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_05_fol", 4131394567U));
            await sleep((short)camera_time());
            await this.c01_outro_04_cleanup();
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task c01_outro_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_05_fol", 4131394567U), default(IGameObject), 1F);
            print("c01_outro foley 05 start");
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task c01_9190_cor()
        {
            await sleep(293);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9190_cor", 4131460104U), default(IGameObject), 1F);
            cinematic_subtitle("c01_9190_cor", 2F);
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task c01_9200_cor()
        {
            await sleep(355);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9200_cor", 4131525641U), default(IGameObject), 1F);
            cinematic_subtitle("c01_9200_cor", 1F);
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task c01_9210_mas()
        {
            await sleep(412);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9210_mas", 4131591178U), chief.Entity, 1F);
            cinematic_subtitle("c01_9210_mas", 1F);
            object_create_anew(outro_fleet);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task c01_outro_shake_05_01()
        {
            time_code_reset();
            await sleep(470);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bay_01()
        {
            print("light bay");
            cinematic_lighting_set_primary_light(81F, 88F, 0.360784F, 0.372549F, 0.462745F);
            cinematic_lighting_set_secondary_light(0F, 0F, 0.160784F, 0.152941F, 0.211765F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(outro_fighter_01.Entity, true);
            object_uses_cinematic_lighting(outro_fighter_02.Entity, true);
            object_uses_cinematic_lighting(outro_seraph.Entity, true);
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task lever()
        {
            await sleep(240);
            device_set_position(outro_lever.Entity, 1F);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task airlock()
        {
            await sleep(470);
            device_set_position(outro_door_03.Entity, 1F);
        }

        [ScriptMethod(244, Lifecycle.Static)]
        public async Task c01_outro_05_setup()
        {
            object_create_anew(outro_fighter_01);
            object_create_anew(outro_fighter_02);
            object_create_anew(outro_seraph);
            object_cinematic_lod(outro_fighter_01.Entity, true);
            object_cinematic_lod(outro_fighter_02.Entity, true);
            object_cinematic_lod(outro_seraph.Entity, true);
            object_cinematic_visibility(outro_fighter_01.Entity, true);
            object_cinematic_visibility(outro_fighter_02.Entity, true);
            object_cinematic_visibility(outro_seraph.Entity, true);
            wake(new ScriptMethodReference(lever));
            wake(new ScriptMethodReference(airlock));
            wake(new ScriptMethodReference(c01_outro_foley_05));
            wake(new ScriptMethodReference(c01_9190_cor));
            wake(new ScriptMethodReference(c01_9200_cor));
            wake(new ScriptMethodReference(c01_9210_mas));
            wake(new ScriptMethodReference(c01_outro_shake_05_01));
            wake(new ScriptMethodReference(cinematic_lighting_bay_01));
        }

        [ScriptMethod(245, Lifecycle.Static)]
        public async Task c01_outro_05_cleanup()
        {
            object_destroy(outro_fighter_01.Entity);
            object_destroy(outro_fighter_02.Entity);
            object_destroy(outro_seraph.Entity);
        }

        [ScriptMethod(246, Lifecycle.Static)]
        public async Task c01_outro_scene_05()
        {
            await this.c01_outro_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_05", default(IUnit), anchor_flag_outro1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_05", false, anchor_outro1.Entity);
            scenery_animation_start_relative(pickle.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_05", anchor_outro1.Entity);
            scenery_animation_start_relative(matte_earth.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\earth_space\\01_outro\\01_outro", 4131656715U), "earth_matte_05", anchor_outro1.Entity);
            scenery_animation_start_relative(outro_fighter_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4131722252U), "longsword01_05", anchor_outro1.Entity);
            scenery_animation_start_relative(outro_fighter_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4131722252U), "longsword02_05", anchor_outro1.Entity);
            scenery_animation_start_relative(outro_seraph.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 4131787789U), "01_outro_05", anchor_outro1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_outro_06_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\music\\c01_outro_06_mus", 4131853326U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_06_fol", 4131918863U));
            await sleep((short)camera_time());
            await this.c01_outro_05_cleanup();
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task c01_outro_music_06()
        {
            await sleep(233);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\music\\c01_outro_06_mus", 4131853326U), default(IGameObject), 1F);
            print("c01_outro music 06 start");
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task c01_outro_foley_06()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_06_fol", 4131918863U), default(IGameObject), 1F);
            print("c01_outro foley 06 start");
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task c01_outro_shake_06_01()
        {
            await sleep(243);
            player_effect_stop(2F);
            print("shake stop");
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task cinematic_lighting_bay_02()
        {
            print("light bay 02");
            cinematic_lighting_set_primary_light(-12F, 294F, 0.47451F, 0.419608F, 0.392157F);
            cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(251, Lifecycle.Dormant)]
        public async Task final_sparks()
        {
            time_code_reset();
            await sleep(132);
            print("sparks start");
            object_create_anew_containing("sparks_forward");
            objects_attach(pickle.Entity, "sparks01", sparks_forward_01.Entity, "marker");
            objects_attach(pickle.Entity, "sparks02", sparks_forward_02.Entity, "marker");
            objects_attach(pickle.Entity, "sparks03", sparks_forward_03.Entity, "marker");
            objects_attach(pickle.Entity, "sparks04", sparks_forward_04.Entity, "marker");
            objects_attach(pickle.Entity, "sparks05", sparks_forward_05.Entity, "marker");
            objects_attach(pickle.Entity, "sparks06", sparks_forward_06.Entity, "marker");
            objects_attach(pickle.Entity, "sparks07", sparks_forward_07.Entity, "marker");
            objects_attach(pickle.Entity, "sparks08", sparks_forward_08.Entity, "marker");
            await sleep(8);
            object_destroy_containing("sparks_forward");
            print("sparks stop");
            await sleep(22);
            object_create_anew_containing("sparks_forward");
            print("sparks start");
            objects_attach(pickle.Entity, "sparks01", sparks_forward_01.Entity, "marker");
            objects_attach(pickle.Entity, "sparks02", sparks_forward_02.Entity, "marker");
            objects_attach(pickle.Entity, "sparks03", sparks_forward_03.Entity, "marker");
            objects_attach(pickle.Entity, "sparks04", sparks_forward_04.Entity, "marker");
            objects_attach(pickle.Entity, "sparks05", sparks_forward_05.Entity, "marker");
            objects_attach(pickle.Entity, "sparks06", sparks_forward_06.Entity, "marker");
            objects_attach(pickle.Entity, "sparks07", sparks_forward_07.Entity, "marker");
            objects_attach(pickle.Entity, "sparks08", sparks_forward_08.Entity, "marker");
            await sleep(5);
            object_destroy_containing("sparks_forward");
            print("sparks stop");
            await sleep(29);
            object_create_anew_containing("sparks_forward");
            print("sparks start");
            objects_attach(pickle.Entity, "sparks01", sparks_forward_01.Entity, "marker");
            objects_attach(pickle.Entity, "sparks02", sparks_forward_02.Entity, "marker");
            objects_attach(pickle.Entity, "sparks03", sparks_forward_03.Entity, "marker");
            objects_attach(pickle.Entity, "sparks04", sparks_forward_04.Entity, "marker");
            objects_attach(pickle.Entity, "sparks05", sparks_forward_05.Entity, "marker");
            objects_attach(pickle.Entity, "sparks06", sparks_forward_06.Entity, "marker");
            objects_attach(pickle.Entity, "sparks07", sparks_forward_07.Entity, "marker");
            objects_attach(pickle.Entity, "sparks08", sparks_forward_08.Entity, "marker");
            await sleep(50);
            object_destroy_containing("sparks_forward");
            print("sparks stop");
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task destroy_fleet()
        {
            await sleep(150);
            print("destroy fleet");
            object_destroy(outro_fleet.Entity);
        }

        [ScriptMethod(253, Lifecycle.Static)]
        public async Task c01_outro_06_setup()
        {
            object_create_anew(airlock_debris_01);
            object_create_anew(airlock_debris_02);
            wake(new ScriptMethodReference(c01_outro_music_06));
            wake(new ScriptMethodReference(c01_outro_foley_06));
            wake(new ScriptMethodReference(c01_outro_shake_06_01));
            wake(new ScriptMethodReference(cinematic_lighting_bay_02));
            wake(new ScriptMethodReference(final_sparks));
            wake(new ScriptMethodReference(destroy_fleet));
        }

        [ScriptMethod(254, Lifecycle.Static)]
        public async Task c01_outro_06_cleanup()
        {
            object_destroy(matte_earth.Entity);
            object_destroy(pickle.Entity);
            object_destroy_containing("airlock_debris");
        }

        [ScriptMethod(255, Lifecycle.Static)]
        public async Task c01_outro_scene_06()
        {
            await this.c01_outro_06_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_06", default(IUnit), anchor_flag_outro1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_06", false, anchor_outro1.Entity);
            scenery_animation_start_relative(pickle.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_06", anchor_outro1.Entity);
            scenery_animation_start_relative(matte_earth.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\earth_space\\01_outro\\01_outro", 4131656715U), "earth_matte_06", anchor_outro1.Entity);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_07_fol", 4131984400U));
            await sleep((short)camera_time());
            fade_out(0F, 0F, 0F, 0);
            await sleep(69);
            await this.c01_outro_06_cleanup();
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task c01_outro_foley_07()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_07_fol", 4131984400U), default(IGameObject), 1F);
            print("c01_outro foley 07 start");
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task effect_covenant_beams()
        {
            await sleep(338);
            object_destroy(carrier_02.Entity);
            print("effect - beam fire");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_beam", 4132049937U), covenant_battery.Entity, "");
            await sleep(40);
            print("effect - beam fire");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_beam", 4132049937U), covenant_battery.Entity, "");
            await sleep(59);
            print("effect - beam fire");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_beam", 4132049937U), covenant_battery.Entity, "");
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task effect_poa_explosions()
        {
            await sleep(444);
            print("effect - poa explosion large");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\poa_hit_small", 4132312085U), poa.Entity, "explosion02");
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task cinematic_lighting_outro_07()
        {
            cinematic_lighting_set_primary_light(-5F, 314F, 0.32549F, 0.27451F, 0.243137F);
            cinematic_lighting_set_secondary_light(19F, 170F, 0.145098F, 0.14902F, 0.313726F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(pickle2.Entity, true);
            object_uses_cinematic_lighting(carrier_01.Entity, true);
            object_uses_cinematic_lighting(carrier_02.Entity, true);
            object_uses_cinematic_lighting(fighter_01.Entity, true);
            object_uses_cinematic_lighting(fighter_02.Entity, true);
            object_uses_cinematic_lighting(poa.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task cinematic_lighting_poa_reverse()
        {
            time_code_reset();
            await sleep(491);
            print("light poa reverse");
            cinematic_lighting_set_primary_light(-68F, 122F, 0.47451F, 0.419608F, 0.392157F);
            cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(261, Lifecycle.Static)]
        public async Task c01_outro_07_setup()
        {
            render_lights_enable_cinematic_shadow(false, chief.Entity, "head", 0.4F);
            object_create_anew(pickle2);
            object_create_anew(carrier_01);
            object_create_anew(carrier_02);
            object_create_anew(fighter_01);
            object_create_anew(fighter_02);
            object_create_anew(poa);
            object_create_anew(covenant_battery);
            object_create_anew(matte_africa);
            object_cinematic_lod(pickle2.Entity, true);
            object_cinematic_lod(carrier_01.Entity, true);
            object_cinematic_lod(carrier_02.Entity, true);
            object_cinematic_lod(fighter_01.Entity, true);
            object_cinematic_lod(fighter_02.Entity, true);
            object_cinematic_lod(poa.Entity, true);
            object_cinematic_lod(covenant_battery.Entity, true);
            object_cinematic_lod(matte_africa.Entity, true);
            object_set_function_variable(pickle2.Entity, "flare", 0F, 1F);
            wake(new ScriptMethodReference(c01_outro_foley_07));
            wake(new ScriptMethodReference(effect_covenant_beams));
            wake(new ScriptMethodReference(effect_poa_explosions));
            wake(new ScriptMethodReference(cinematic_lighting_outro_07));
            wake(new ScriptMethodReference(cinematic_lighting_poa_reverse));
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\poa_flaming_debris", 4133032992U), poa.Entity, "flaming_debris");
        }

        [ScriptMethod(262, Lifecycle.Static)]
        public async Task c01_outro_07_cleanup()
        {
            object_destroy(poa.Entity);
        }

        [ScriptMethod(263, Lifecycle.Static)]
        public async Task c01_outro_scene_07()
        {
            await this._01_outro_07_predict_stub();
            await this.c01_outro_07_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_07", default(IUnit), anchor_flag_outro2);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_07", false, anchor_outro2.Entity);
            scenery_animation_start_relative(pickle2.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_07", anchor_outro2.Entity);
            scenery_animation_start_relative(carrier_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\01_outro\\01_outro", 4133229603U), "capship01_07", anchor_outro2.Entity);
            scenery_animation_start_relative(carrier_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\01_outro\\01_outro", 4133229603U), "capship02_07", anchor_outro2.Entity);
            scenery_animation_start_relative(fighter_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4131722252U), "longsword01_07", anchor_outro2.Entity);
            scenery_animation_start_relative(fighter_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4131722252U), "longsword02_07", anchor_outro2.Entity);
            scenery_animation_start_relative(poa.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\pillarofautumn\\01_outro\\01_outro", 4133295140U), "poa_07", anchor_outro2.Entity);
            scenery_animation_start_relative(covenant_battery.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\01_outro\\01_outro", 4133360677U), "texture_camera_07", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_africa.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\africa_space\\01_outro\\01_outro", 4133426214U), "africa_space_07", anchor_outro2.Entity);
            fade_in(0F, 0F, 0F, 30);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_outro_08_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_08_fol", 4133491751U));
            await sleep((short)camera_time());
            await this.c01_outro_07_cleanup();
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task c01_outro_foley_08()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_08_fol", 4133491751U), default(IGameObject), 1F);
            print("c01_outro foley 08 start");
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task effect_cluster_bombs()
        {
            await sleep(120);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4133557288U), carrier_01.Entity, "cluster01");
            await sleep(5);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4133557288U), carrier_01.Entity, "cluster03");
            await sleep(5);
            await sleep(4);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4133557288U), carrier_01.Entity, "cluster05");
            await sleep(4);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4133557288U), carrier_01.Entity, "cluster06");
            await sleep(3);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4133557288U), carrier_01.Entity, "cluster07");
            await sleep(3);
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task effect_interior_blast()
        {
            await sleep(195);
            print("interior blast");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\cluster_bomb", 4133557288U), blast_base.Entity, "marker");
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task x02_08_dof()
        {
            time_code_reset();
            await sleep(455);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(5F, 0F, 0F, 0F, 1F, 1F, 0F);
            print("rack focus");
            time_code_reset();
            await sleep(116);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task bomb_reactivate()
        {
            await sleep(630);
            print("bomb reactivate");
            object_set_function_variable(pickle2.Entity, "flare", 1F, 0F);
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_08()
        {
            print("light scene 08");
            cinematic_lighting_set_primary_light(-5F, 314F, 0.32549F, 0.27451F, 0.243137F);
            cinematic_lighting_set_secondary_light(19F, 170F, 0.145098F, 0.14902F, 0.313726F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task cinematic_light_carrier_int()
        {
            time_code_reset();
            await sleep(199);
            print("light carrier interior");
            cinematic_lighting_set_primary_light(63F, 356F, 0.305882F, 0.262745F, 0.380392F);
            cinematic_lighting_set_secondary_light(9F, 220F, 0.0784314F, 0.0784314F, 0.160784F);
            cinematic_lighting_set_ambient_light(0.0235294F, 0.027451F, 0.0588235F);
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task save_framerate_08()
        {
            await sleep(199);
            print("hide carrier, africa matte");
            object_hide(carrier_01.Entity, true);
            object_hide(matte_africa.Entity, true);
        }

        [ScriptMethod(272, Lifecycle.Static)]
        public async Task c01_outro_08_setup()
        {
            object_create(matte_carrier_core);
            object_create(matte_carrier_side);
            object_create(matte_carrier_hull);
            object_create_anew(blast_base);
            object_cinematic_visibility(blast_base.Entity, true);
            object_cinematic_lod(matte_carrier_core.Entity, true);
            object_cinematic_lod(matte_carrier_side.Entity, true);
            object_cinematic_lod(matte_carrier_hull.Entity, true);
            wake(new ScriptMethodReference(c01_outro_foley_08));
            wake(new ScriptMethodReference(effect_cluster_bombs));
            wake(new ScriptMethodReference(save_framerate_08));
            wake(new ScriptMethodReference(effect_interior_blast));
            wake(new ScriptMethodReference(bomb_reactivate));
            wake(new ScriptMethodReference(x02_08_dof));
            wake(new ScriptMethodReference(cinematic_lighting_scene_08));
            wake(new ScriptMethodReference(cinematic_light_carrier_int));
        }

        [ScriptMethod(273, Lifecycle.Static)]
        public async Task c01_outro_08_cleanup()
        {
            object_destroy(matte_carrier_core.Entity);
            object_destroy(matte_carrier_side.Entity);
            object_destroy(fighter_01.Entity);
            object_destroy(fighter_02.Entity);
            object_destroy(covenant_battery.Entity);
            object_destroy(blast_base.Entity);
        }

        [ScriptMethod(274, Lifecycle.Static)]
        public async Task c01_outro_scene_08()
        {
            await this.c01_outro_08_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_08", default(IUnit), anchor_flag_outro2);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_08", false, anchor_outro2.Entity);
            scenery_animation_start_relative(pickle2.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_08", anchor_outro2.Entity);
            scenery_animation_start_relative(carrier_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\01_outro\\01_outro", 4133229603U), "capship01_08", anchor_outro2.Entity);
            scenery_animation_start_relative(fighter_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4131722252U), "longsword01_08", anchor_outro2.Entity);
            scenery_animation_start_relative(fighter_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\longsword\\01_outro\\01_outro", 4131722252U), "longsword02_08", anchor_outro2.Entity);
            scenery_animation_start_relative(covenant_battery.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\01_outro\\01_outro", 4133360677U), "texture_camera_08", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_carrier_core.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_core\\01_outro\\01_outro", 4133688362U), "cruiser_core_08", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_carrier_side.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_side\\01_outro\\01_outro", 4133753899U), "cruiser_side_08", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_carrier_hull.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_up\\01_outro\\01_outro", 4133819436U), "cruiser_up_08", anchor_outro2.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_outro_09_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_09_fol", 4133884973U));
            await sleep((short)camera_time());
            await this.c01_outro_08_cleanup();
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task c01_outro_foley_09()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_09_fol", 4133884973U), default(IGameObject), 1F);
            print("c01_outro foley 09 start");
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_09()
        {
            print("light scene 09");
            cinematic_lighting_set_primary_light(-12F, 2F, 0.352941F, 0.109804F, 0.756863F);
            cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(277, Lifecycle.Static)]
        public async Task c01_outro_09_setup()
        {
            wake(new ScriptMethodReference(c01_outro_foley_09));
            wake(new ScriptMethodReference(cinematic_lighting_scene_09));
            object_hide(matte_africa.Entity, false);
            print("unhide africa matte");
        }

        [ScriptMethod(278, Lifecycle.Static)]
        public async Task c01_outro_09_cleanup()
        {
            object_destroy(pickle2.Entity);
            object_destroy(matte_carrier_hull.Entity);
            object_destroy(matte_africa.Entity);
        }

        [ScriptMethod(279, Lifecycle.Static)]
        public async Task c01_outro_scene_09()
        {
            await this.c01_outro_09_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_09", default(IUnit), anchor_flag_outro2);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_09", false, anchor_outro2.Entity);
            scenery_animation_start_relative(pickle2.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\pickle\\01_outro\\01_outro", 4129952753U), "pickle_09", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_carrier_hull.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_up\\01_outro\\01_outro", 4133819436U), "cruiser_up_09", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_africa.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\africa_space\\01_outro\\01_outro", 4133426214U), "africa_space_09", anchor_outro2.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._01_outro_10_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_10_fol", 4133950510U));
            await sleep((short)camera_time());
            await this.c01_outro_09_cleanup();
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task c01_outro_foley_10()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\01_spacestation\\c01_outro\\foley\\c01_outro_10_fol", 4133950510U), default(IGameObject), 1F);
            print("c01_outro foley 10 start");
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task c01_9220_jon()
        {
            await sleep(375);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9220_jon", 4134016047U), johnson.Entity, 1F);
            cinematic_subtitle("c01_9220_jon", 1F);
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task c01_9230_jon()
        {
            await sleep(415);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9230_jon", 4134081584U), johnson.Entity, 1F);
            cinematic_subtitle("c01_9230_jon", 1F);
            unit_set_emotional_state(johnson.Entity, "happy", 0.75F, 90);
            print("johnson - happy .75 90");
            await sleep(41);
            unit_set_emotional_state(miranda.Entity, "happy", 0.25F, 60);
            print("miranda - happy .25 60");
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task c01_9240_mir()
        {
            await sleep(461);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9240_mir", 4134147121U), miranda.Entity, 1F);
            cinematic_subtitle("c01_9240_mir", 2F);
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task c01_9250_mir()
        {
            await sleep(536);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\cinematic\\c01_9250_mir", 4134212658U), default(IGameObject), 1F);
            cinematic_subtitle("c01_9250_mir", 2F);
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task carrier_explosion_tiny()
        {
            await sleep(15);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4134278195U), carrier_01.Entity, "tiny_explosion01");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4134278195U), carrier_01.Entity, "tiny_explosion02");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4134278195U), carrier_01.Entity, "tiny_explosion03");
            await sleep(3);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4134278195U), carrier_01.Entity, "tiny_explosion04");
            await sleep(3);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4134278195U), carrier_01.Entity, "tiny_explosion05");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4134278195U), carrier_01.Entity, "tiny_explosion06");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 4134278195U), carrier_01.Entity, "tiny_explosion07");
        }

        [ScriptMethod(286, Lifecycle.Dormant)]
        public async Task carrier_explosion_medium()
        {
            await sleep(20);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_minor_explosion", 4134605880U), carrier_01.Entity, "tiny_explosion01");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_minor_explosion", 4134605880U), carrier_01.Entity, "tiny_explosion02");
            await sleep(10);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_minor_explosion", 4134605880U), carrier_01.Entity, "tiny_explosion03");
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task carrier_explosion_large()
        {
            await sleep(50);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_major_explosion", 4135195713U), carrier_01.Entity, "major_explosion");
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task white_flash()
        {
            await sleep(185);
            print("white flash");
            fade_out(1F, 1F, 1F, 15);
            await sleep(30);
            object_hide(miranda.Entity, false);
            object_hide(johnson.Entity, false);
            object_hide(iac.Entity, false);
            object_hide(iac_bridge_outro_02.Entity, false);
            object_hide(matte_africa_coast.Entity, false);
            print("unhide miranda, johnson, iac");
            fade_in(1F, 1F, 1F, 15);
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task effect_africa_explosions()
        {
            await sleep(522);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\africa_explosion", 4135392324U), matte_africa_coast.Entity, "explosion1");
            await sleep(20);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\africa_explosion", 4135392324U), matte_africa_coast.Entity, "explosion2");
            await sleep(15);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\africa_explosion", 4135392324U), matte_africa_coast.Entity, "explosion3");
            await sleep(25);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\africa_explosion", 4135392324U), matte_africa_coast.Entity, "explosion4");
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task cinematic_lighting_outro_10()
        {
            cinematic_lighting_set_primary_light(-68F, 122F, 0.47451F, 0.419608F, 0.392157F);
            cinematic_lighting_set_secondary_light(-39F, 296F, 0.156863F, 0.137255F, 0.262745F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task cinematic_lighting_iac_ext_01()
        {
            time_code_reset();
            await sleep(198);
            print("light iac exterior");
            cinematic_lighting_set_primary_light(6F, 0F, 0.47451F, 0.423529F, 0.392157F);
            cinematic_lighting_set_secondary_light(45F, 116F, 0.0784314F, 0.0745098F, 0.101961F);
            cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0470588F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(iac.Entity, true);
            object_uses_cinematic_lighting(iac_bridge_outro_02.Entity, true);
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task cinematic_lighting_iac_interior()
        {
            await sleep(338);
            print("light iac interior");
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task cinematic_lighting_iac_ext_02()
        {
            await sleep(502);
            print("light iac exterior");
            cinematic_lighting_set_primary_light(6F, 0F, 0.47451F, 0.423529F, 0.392157F);
            cinematic_lighting_set_secondary_light(45F, 116F, 0.0784314F, 0.0745098F, 0.101961F);
            cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0470588F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task emotion_10()
        {
            await sleep(226);
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            unit_set_emotional_state(johnson.Entity, "pensive", 0.5F, 0);
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task save_framerate_10()
        {
            object_hide(carrier_01.Entity, false);
            print("unhide carrier");
            object_hide(miranda.Entity, true);
            object_hide(johnson.Entity, true);
            object_hide(iac.Entity, true);
            object_hide(iac_bridge_outro_02.Entity, true);
            object_hide(matte_africa_coast.Entity, true);
            print("hide miranda, johnson, iac");
        }

        [ScriptMethod(296, Lifecycle.Static)]
        public async Task c01_outro_10_setup()
        {
            object_create_anew(miranda);
            object_create_anew(johnson);
            object_create_anew(iac);
            object_create_anew(iac_bridge_outro_02);
            object_create_anew(matte_africa_coast);
            object_cinematic_lod(iac.Entity, true);
            object_cinematic_lod(iac_bridge_outro_02.Entity, true);
            wake(new ScriptMethodReference(c01_outro_foley_10));
            wake(new ScriptMethodReference(c01_9220_jon));
            wake(new ScriptMethodReference(c01_9230_jon));
            wake(new ScriptMethodReference(c01_9240_mir));
            wake(new ScriptMethodReference(c01_9250_mir));
            wake(new ScriptMethodReference(save_framerate_10));
            wake(new ScriptMethodReference(carrier_explosion_tiny));
            wake(new ScriptMethodReference(carrier_explosion_medium));
            wake(new ScriptMethodReference(carrier_explosion_large));
            wake(new ScriptMethodReference(white_flash));
            wake(new ScriptMethodReference(effect_africa_explosions));
            wake(new ScriptMethodReference(cinematic_lighting_outro_10));
            wake(new ScriptMethodReference(cinematic_lighting_iac_ext_01));
            wake(new ScriptMethodReference(cinematic_lighting_iac_interior));
            wake(new ScriptMethodReference(cinematic_lighting_iac_ext_02));
            wake(new ScriptMethodReference(emotion_10));
        }

        [ScriptMethod(297, Lifecycle.Static)]
        public async Task c01_outro_10_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(miranda.Entity);
            object_destroy(johnson.Entity);
            object_destroy(carrier_01.Entity);
            object_destroy_containing("iac");
            object_destroy_containing("matte");
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task c01_outro_scene_10()
        {
            await this.c01_outro_10_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\01_outro\\01_outro", 4129756142U), "01_outro_10", default(IUnit), anchor_flag_outro2);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\01_outro\\01_outro", 4129821679U), "chief_10", false, anchor_outro2.Entity);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\01_outro\\01_outro", 4130608123U), "miranda_10", false, anchor_outro2.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\01_outro\\01_outro", 4130673660U), "johnson_10", false, anchor_outro2.Entity);
            scenery_animation_start_relative(carrier_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\01_outro\\01_outro", 4133229603U), "capship01_10", anchor_outro2.Entity);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\01_outro\\01_outro", 4135523398U), "iac_10", anchor_outro2.Entity);
            scenery_animation_start_relative(iac_bridge_outro_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\01_outro\\01_outro", 4130804734U), "iac_bridge_10", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_africa_coast.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\africa_coast\\01_outro\\01_outro", 4135588935U), "africa_coast_10", anchor_outro2.Entity);
            await sleep((short)((float)camera_time() - 30));
            fade_out(0F, 0F, 0F, 30);
            await sleep(30);
            await this.c01_outro_10_cleanup();
            await sleep(30);
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task c01_outro()
        {
            texture_cache_flush();
            geometry_cache_flush();
            cinematic_enable_ambience_details(false);
            sound_class_set_gain("huge_ass", 0F, 30);
            switch_bsp_by_name(GetReference<IBsp>("01_bsp_3"));
            await sleep(1);
            await this.c01_outro_scene_01();
            await this.c01_outro_scene_02();
            await this.c01_outro_scene_03();
            await this.c01_outro_scene_04();
            await this.c01_outro_scene_05();
            await this.c01_outro_scene_06();
            switch_bsp_by_name(GetReference<IBsp>("01outro_bsp"));
            await sleep(1);
            await this.c01_outro_scene_07();
            await this.c01_outro_scene_08();
            await this.c01_outro_scene_09();
            await this.c01_outro_scene_10();
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(300, Lifecycle.Dormant)]
        public async Task megg_check()
        {
            if (!(await this.difficulty_legendary()))
            {
                sleep_forever();
            }

            if ((bool)game_is_cooperative())
            {
                sleep_forever();
            }

            if (!((bool)ice_cream_flavor_available(3)))
            {
                sleep_forever();
            }

            await sleep_until(async () =>
            {
                if (object_get_shield(await this.player0()) < 1F)
                {
                    print("oops");
                    sleep_forever();
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
                sleep_forever();
            }

            object_create(yorick);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4135654472U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4135654472U)), 1);
            ice_cream_flavor_stock(3);
            print("blam");
        }

        [ScriptMethod(302, Lifecycle.Static)]
        public async Task save_cutscene()
        {
            data_mine_set_mission_segment("01b_cutscene");
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task save_1st_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_1st_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task save_1st_wv4()
        {
            game_save();
            data_mine_set_mission_segment("01b_1st_wv4");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(305, Lifecycle.Static)]
        public async Task save_1st_wv5_end()
        {
            game_save();
            data_mine_set_mission_segment("01b_1st_wv5_end");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(306, Lifecycle.Static)]
        public async Task save_atr2_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_atr2_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(307, Lifecycle.Static)]
        public async Task save_atr2_mid()
        {
            game_save();
            data_mine_set_mission_segment("01b_atr2_mid");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(308, Lifecycle.Static)]
        public async Task save_bay1_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_bay1_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(309, Lifecycle.Static)]
        public async Task save_bay1_mid()
        {
            game_save();
            data_mine_set_mission_segment("01b_bay1_mid");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(310, Lifecycle.Static)]
        public async Task save_bay2_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_bay2_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(311, Lifecycle.Dormant)]
        public async Task save_bay2_retreat()
        {
            await sleep_until(async () => volume_test_objects(tv_bay2_hall, players()));
            game_save();
            data_mine_set_mission_segment("01b_bay2_retreat");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task save_bay2_mid()
        {
            game_save();
            data_mine_set_mission_segment("01b_bay2_mid");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(313, Lifecycle.Dormant)]
        public async Task save_bay2_fnl()
        {
            await sleep_until(async () => (short)ai_living_count(bay2_cov_fnl) == 0, 1);
            game_save();
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(314, Lifecycle.Dormant)]
        public async Task save_arm_start()
        {
            await sleep_until(async () => (short)ai_living_count(arm_cov_stl.Squad) == 0, 1);
            game_save();
            data_mine_set_mission_segment("01b_arm_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task save_atr1_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_atr1_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
            await sleep_until(async () => (short)ai_living_count(atr1_cov_fbalcony) <= 1 && (short)ai_living_count(atr1_cov_bbalcony) <= 1 && volume_test_objects(tv_arm_save, players()), 1);
            game_save();
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
            await sleep_until(async () => (short)ai_living_count(atr1_cov_fbalcony) == 0 && (short)ai_living_count(atr1_cov_bbalcony) == 0 && (short)ai_living_count(atr1_cov_sec_front) == 0 && volume_test_objects(tv_arm_save, players()), 1);
            game_save();
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(316, Lifecycle.Static)]
        public async Task save_trm1_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_trm1_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(317, Lifecycle.Static)]
        public async Task save_dck_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_dck_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(318, Lifecycle.Static)]
        public async Task save_elv_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_elv_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(319, Lifecycle.Static)]
        public async Task save_lvr_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_lvr_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(320, Lifecycle.Static)]
        public async Task save_gun_start()
        {
            game_save();
            data_mine_set_mission_segment("01b_gun_start");
            this.timer_flavor = (short)max(this.timer_flavor, 10F * this.tick_seconds);
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task title_1st()
        {
            cinematic_show_letterbox(true);
            hud_cinematic_fade(0F, 0.5F);
            await sleep(30);
            cinematic_set_title(title_1st1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task title_bay2()
        {
            cinematic_show_letterbox(true);
            hud_cinematic_fade(0F, 0.5F);
            await sleep(30);
            cinematic_set_title(title_bay21);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task title_dck()
        {
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_06", 4136768601U), default(IGameObject), 1F);
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_dck1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task title_gun()
        {
            cinematic_show_letterbox(true);
            hud_cinematic_fade(0F, 0.5F);
            await sleep(30);
            cinematic_set_title(title_gun1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(325, Lifecycle.Static)]
        public async Task<int> timer_flavor_set()
        {
            return (short)random_range((short)(15 * this.tick_seconds), (short)(30 * this.tick_seconds));
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task<int> timer_flavor_set_long()
        {
            return (short)random_range((short)(45 * this.tick_seconds), (short)(60 * this.tick_seconds));
        }

        [ScriptMethod(327, Lifecycle.Static)]
        public async Task flavor_stop()
        {
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2300_lhd", 4137161823U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2310_lhd", 4137227360U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2320_lhd", 4137292897U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2330_lhd", 4137358434U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2100_lhd", 4137423971U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2250_lhd", 4137489508U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2220_lhd", 4137555045U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2190_lhd", 4137620582U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2170_lhd", 4137686119U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2060_lhd", 4137751656U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2080_lhd", 4137817193U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2160_lhd", 4137882730U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2230_lhd", 4137948267U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2210_lhd", 4138013804U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2030_lhd", 4138079341U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2000_lhd", 4138144878U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2010_lhd", 4138210415U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2400_lhd", 4138275952U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0570_cor", 4138341489U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2580_cor", 4138407026U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2590_cor", 4138472563U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2600_cor", 4138538100U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2610_cor", 4138603637U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2630_cor", 4138669174U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2640_cor", 4138734711U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2650_cor", 4138800248U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2660_cor", 4138865785U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2340_lhd", 4138931322U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2350_lhd", 4138996859U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2360_lhd", 4139062396U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2370_lhd", 4139127933U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2380_lhd", 4139193470U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2390_lhd", 4139259007U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2480_lhd", 4139324544U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2490_lhd", 4139390081U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2500_lhd", 4139455618U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2510_lhd", 4139521155U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2520_lhd", 4139586692U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2530_lhd", 4139652229U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2540_lhd", 4139717766U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2200_lhd", 4139783303U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2110_lhd", 4139848840U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2120_lhd", 4139914377U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2130_lhd", 4139979914U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2240_lhd", 4140045451U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2140_lhd", 4140110988U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2260_lhd", 4140176525U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2150_lhd", 4140242062U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2010_lhd", 4138210415U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2000_lhd", 4138144878U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2020_lhd", 4140307599U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2030_lhd", 4138079341U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2040_lhd", 4140373136U));
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task flavor_mission()
        {
            await sleep_until(async () =>
            {
                if (this.mark_flavor_disable)
                {
                    await this.flavor_stop();
                    ai_dialogue_enable(false);
                    await sleep_until(async () => !(this.mark_flavor_disable), 1);
                    await sleep((short)(5 * 30));
                    ai_dialogue_enable(true);
                    this.timer_flavor = (short)max(this.timer_flavor, 5F * 30F);
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
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2300_lhd", 4137161823U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_brace == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2310_lhd", 4137227360U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_brace == 2)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2320_lhd", 4137292897U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_brace == 3)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2330_lhd", 4137358434U), default(IGameObject), 1F, "");
                    }
                    else if (true)
                    {
                        this.counter_flavor_brace = 0;
                    }

                    await sleep((short)random_range((short)(3 * 30), (short)(7 * 30)));
                    damage_players(GetTag<DamageEffectTag>("effects\\scenarios\\objects\\solo\\spacestation\\boarding_craft_shake", 4140438673U));
                    print("klang!");
                    sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_stereo", 4140504210U), default(IGameObject), 1F);
                    await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_stereo", 4140504210U)));
                    this.counter_flavor_brace = (short)(this.counter_flavor_brace + 1);
                    this.timer_flavor = await this.timer_flavor_set();
                    this.mark_flavor_brace = false;
                    return false;
                }
                else if (this.mark_flavor_dck)
                {
                    sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2100_lhd", 4137423971U), default(IGameObject), 1F, "");
                    this.mark_flavor_dck = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_trm1)
                {
                    sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2250_lhd", 4137489508U), default(IGameObject), 1F, "");
                    this.mark_flavor_trm1 = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_atr1)
                {
                    if (this.counter_flavor_atr1 == 0)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2220_lhd", 4137555045U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr1 == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2190_lhd", 4137620582U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr1 == 2)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2170_lhd", 4137686119U), default(IGameObject), 1F, "");
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
                    sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2060_lhd", 4137751656U), default(IGameObject), 1F, "");
                    this.mark_flavor_bay2 = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_bay1)
                {
                    sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2080_lhd", 4137817193U), default(IGameObject), 1F, "");
                    this.mark_flavor_bay1 = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_atr2)
                {
                    if (this.counter_flavor_atr2 == 0)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2160_lhd", 4137882730U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr2 == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2230_lhd", 4137948267U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr2 == 2)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2210_lhd", 4138013804U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_atr2 == 3)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2030_lhd", 4138079341U), default(IGameObject), 1F, "");
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
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2000_lhd", 4138144878U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_1st == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2010_lhd", 4138210415U), default(IGameObject), 1F, "");
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
                    sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2400_lhd", 4138275952U), default(IGameObject), 1F, "");
                    this.mark_flavor_megg = false;
                    this.timer_flavor = await this.timer_flavor_set();
                    return false;
                }
                else if (this.mark_flavor_bomb && (bool)game_safe_to_save())
                {
                    if (!(this.mark_flavor_safe_cycle))
                    {
                        this.mark_flavor_safe_cycle = true;
                    }
                    else if (this.counter_flavor_bomb_safe == 0)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0570_cor", 4138341489U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2580_cor", 4138407026U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 2)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2590_cor", 4138472563U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 3)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2600_cor", 4138538100U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 4)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2610_cor", 4138603637U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 5)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2630_cor", 4138669174U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 6)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2640_cor", 4138734711U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 7)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2650_cor", 4138800248U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_bomb_safe == 8)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2660_cor", 4138865785U), default(IGameObject), 1F, "radio_default");
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
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2340_lhd", 4138931322U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2350_lhd", 4138996859U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 2)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2360_lhd", 4139062396U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 3)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2370_lhd", 4139127933U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 4)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2380_lhd", 4139193470U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_bomb == 5)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2390_lhd", 4139259007U), default(IGameObject), 1F, "");
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
                else if (this.mark_flavor_board && (bool)game_safe_to_save())
                {
                    if (!(this.mark_flavor_safe_cycle))
                    {
                        this.mark_flavor_safe_cycle = true;
                    }
                    else if (this.counter_flavor_board_safe == 0)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2480_lhd", 4139324544U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2490_lhd", 4139390081U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 2)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2500_lhd", 4139455618U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 3)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2510_lhd", 4139521155U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 4)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2520_lhd", 4139586692U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 5)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2530_lhd", 4139652229U), default(IGameObject), 1F, "radio_default");
                    }
                    else if (this.counter_flavor_board_safe == 6)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2540_lhd", 4139717766U), default(IGameObject), 1F, "radio_default");
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
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2200_lhd", 4139783303U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2110_lhd", 4139848840U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 2)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2120_lhd", 4139914377U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 3)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2130_lhd", 4139979914U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 4)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2240_lhd", 4140045451U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 5)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2140_lhd", 4140110988U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 6)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2260_lhd", 4140176525U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_board == 7)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2150_lhd", 4140242062U), default(IGameObject), 1F, "");
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
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2010_lhd", 4138210415U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_init == 1)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2000_lhd", 4138144878U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_init == 2)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2020_lhd", 4140307599U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_init == 3)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2030_lhd", 4138079341U), default(IGameObject), 1F, "");
                    }
                    else if (this.counter_flavor_init == 4)
                    {
                        sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_2040_lhd", 4140373136U), default(IGameObject), 1F, "");
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
            await sleep(1);
        }

        [ScriptMethod(330, Lifecycle.CommandScript)]
        public async Task cs_1st_hichief()
        {
            cs_approach_player(1.5F, 10F, 10F);
        }

        [ScriptMethod(331, Lifecycle.CommandScript)]
        public async Task cs_weapons()
        {
            await sleep((short)random_range(90, 180));
        }

        [ScriptMethod(332, Lifecycle.Dormant)]
        public async Task _1st_tram()
        {
            pvs_set_object(tram.Entity);
            object_create_anew(_1st_tram_wall_1);
            object_create_anew(_1st_tram_wall_2);
            device_set_position_immediate(tram.Entity, 1F);
            device_set_position_immediate(_1st_door_tram.Entity, 1F);
            await sleep(1);
            pvs_clear();
            ai_place(_1st_hum_tram.Squad);
            object_set_permutation(ai_get_object(_1st_hum_johnson.Squad), "helmet", "");
            await sleep(30);
            device_set_position(tram.Entity, 0F);
            await sleep(360);
            device_set_position(_1st_door_tram.Entity, 0F);
            await sleep(90);
            ai_erase(_1st_hum_tram.Squad);
            object_destroy(_1st_tram_wall_1.Entity);
            object_destroy(_1st_tram_wall_2.Entity);
            object_destroy(tram.Entity);
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task cs_1st_fieldoffire()
        {
            cs_aim_object(true, _1st_door_blast.Entity);
            sleep_forever();
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task cs_1st_johnson_deploy()
        {
            cs_face_object(true, _1st_door_blast.Entity);
            await sleep(60);
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3979479806U), "combat:missile:point", true);
            sound_impulse_start(GetTag<SoundTag>("sound_remastered\\weapons\\chain_gun\\place", 4140635284U), ai_get_object(_1st_hum_johnson.Squad), 1F);
            await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
            await sleep(30);
            cs_deploy_turret(GetReference<ISpatialPoint>("1st_turrets/1st_turrets_balcony"));
        }

        [ScriptMethod(335, Lifecycle.Static)]
        public async Task _1st_malta()
        {
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_01", 4140700821U), default(IGameObject), 1F);
            await sleep(30);
            print("how's it going, malta?");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0080_jon", 4141094043U), ai_get_object(_1st_hum_johnson.Squad), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0080_jon", 4141094043U)));
            await sleep(7);
            print("standby...");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0090_mm1", 4141159580U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0090_mm1", 4141159580U)));
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_mono", 4141225117U), default(IGameObject), 1F, "radio_default");
            await sleep(5);
            print("they're latched!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0100_mm1", 4141356191U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0100_mm1", 4141356191U)));
            print("(grunts and snarls)");
            print("check your targets, watch the crossfire!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0120_mm1", 4141421728U), default(IGameObject), 1F, "radio_default");
            await sleep((short)((float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0120_mm1", 4141421728U)) - 60));
            object_create_anew(_1st_craft);
            device_set_position_immediate(_1st_craft.Entity, 1F);
            device_set_position(_1st_craft.Entity, 0F);
            await sleep(65);
            print("they're in standard formation: little bastards up front, big ones in back. good luck, cairo!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0130_mm1", 4141487265U), default(IGameObject), 1F, "radio_default");
            await sleep_until(async () => device_get_position(_1st_craft.Entity) < 0.75F, 1);
            print("docking sound");
            sound_impulse_start(GetTag<SoundTag>("sound_remastered\\ambience\\spacestation\\docking_clangs\\dockingcov_incoming", 4141552802U), default(IGameObject), 1F);
            await sleep_until(async () => device_get_position(_1st_craft.Entity) <= 0.1F, 1);
            print("klang malta!");
            damage_players(GetTag<DamageEffectTag>("effects\\scenarios\\objects\\solo\\spacestation\\boarding_craft_shake", 4140438673U));
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_stereo", 4140504210U), default(IGameObject), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\ambience\\spacestation\\docking_clangs\\docking_stereo", 4140504210U)));
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\ambience\\spacestation\\ss_behind_bulkhead\\ss_behind_bulkhead", 4141618339U), _1st_door_blast.Entity, 1F);
        }

        [ScriptMethod(336, Lifecycle.Dormant)]
        public async Task _1st_waves()
        {
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\solo\\spacestation\\door_charging", 4141880487U), _1st_door_blast.Entity, "");
            await sleep(240);
            object_type_predict(GetTag<BaseTag>("objects\\characters\\elite\\elite", 3822060122U));
            object_type_predict(GetTag<BaseTag>("objects\\characters\\grunt\\grunt", 3901753113U));
            await sleep(30);
            ai_place(_1st_cov_wv1);
            await sleep(30);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 4142732468U), _1st_blast_flag_1);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\explosion_medium_metal_bits", 4142798005U), _1st_door_blast.Entity, 1F);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 4142732468U), _1st_blast_flag_2);
            await sleep(1);
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\ambience\\spacestation\\ss_behind_bulkhead\\ss_behind_bulkhead", 4141618339U));
            object_damage_damage_section(_1st_door_blast.Entity, "main", 1F);
            await sleep(3);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 4142732468U), _1st_blast_flag_1);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 4142732468U), _1st_blast_flag_2);
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_02", 4142863542U), default(IGameObject), 1F);
            cs_run_command_script(_1st_hum, new ScriptMethodReference(cs_clear));
            await sleep(2);
            this.mark_1st_blast = true;
            await sleep_until(async () => (short)ai_living_count(_1st_cov) < 2, 10, 300);
            await sleep_until(async () => (short)ai_living_count(_1st_cov) == 0 || (short)ai_fighting_count(_1st_cov) < 2, 10);
            ai_place(_1st_cov_wv2);
            await sleep_until(async () => (short)ai_living_count(_1st_cov) < 2, 10, 300);
            await sleep_until(async () => (short)ai_living_count(_1st_cov) == 0 || (short)ai_fighting_count(_1st_cov) < 2, 10);
            ai_place(_1st_cov_wv3);
            object_destroy(_1st_door_top.Entity);
            await sleep_until(async () => (short)ai_living_count(_1st_cov) < 2, 10, 300);
            await sleep_until(async () => (short)ai_living_count(_1st_cov) == 0 || (short)ai_fighting_count(_1st_cov) < 2, 10);
            await this.save_1st_wv4();
            await sleep(60);
            ai_place(_1st_cov_wv4);
            await sleep_until(async () => (short)ai_living_count(_1st_cov) < 2, 10, 300);
            await sleep_until(async () => (short)ai_living_count(_1st_cov) == 0 || (short)ai_fighting_count(_1st_cov) < 2, 10);
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
            print("1st");
            this.mark_flavor_init = true;
            ai_place(_1st_hum);
            ai_cannot_die(_1st_hum_johnson.Squad, true);
            await sleep_until(async () => volume_test_objects(tv_1st_hallb, players()), 10);
            ai_set_orders(_1st_hum, _1st_hum_halla);
            device_set_position(bigrack_bsp0a_5.Entity, 1F);
            await sleep(15);
            device_set_position(bigrack_bsp0a_6.Entity, 1F);
            await sleep_until(async () => volume_test_objects(tv_1st_halla, players()), 10);
            ai_set_orders(_1st_hum_floor, _1st_hum_floor1);
            ai_set_orders(_1st_hum_balcony, _1st_hum_balcony1);
            ai_set_orders(_1st_hum_johnson.Squad, _1st_hum_balcony_stairs);
            this.mark_flavor_disable = true;
            await this._1st_malta();
            await sleep_until(async () => volume_test_objects(tv_1st_all, players()), 10);
            cs_run_command_script(_1st_hum_johnson.Squad, new ScriptMethodReference(cs_1st_johnson_deploy));
            await sleep(45);
            print("field of fire on that bulkhead!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0070_jon", 4143256764U), ai_get_object(_1st_hum_johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0070_jon", 4143256764U)));
            cs_queue_command_script(_1st_hum, new ScriptMethodReference(cs_1st_fieldoffire));
            await sleep(30);
            wake(new ScriptMethodReference(title_1st));
            await sleep(30);
            await this.save_1st_start();
            wake(new ScriptMethodReference(_1st_waves));
            print("soon as that door opens...");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0180_jon", 4143322301U), ai_get_object(_1st_hum_johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0180_jon", 4143322301U)));
            print("let 'em have it.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0190_jon", 4143387838U), ai_get_object(_1st_hum_johnson.Squad), 1F);
            objectives_show_up_to(0);
            await sleep(30);
            this.mark_flavor_disable = false;
            wake(new ScriptMethodReference(megg_check));
            await sleep_until(async () => this.mark_1st_blast && volume_test_objects(tv_1st_exit, players()), 10);
            sleep_forever(new ScriptMethodReference(_1st_waves));
            this.mark_1st_waves_end = true;
            this.mark_flavor_init = false;
            this.mark_flavor_atr2 = true;
            this.mark_flavor_board = true;
            ai_place(_1st_cov_hall);
            ai_place(_1st_hum_stairs);
            await sleep_until(async () => volume_test_objects(tv_atr2_security_r, players()), 1);
            ai_disposable(_1st_cov, true);
            await sleep_until(async () => volume_test_objects(tv_atr2_lstair, players()), 1);
            ai_disposable(_1st_hum, true);
            await sleep_until(async () => (short)structure_bsp_index() == 2, 10);
            ai_erase(_1st_cov);
        }

        [ScriptMethod(339, Lifecycle.Dormant)]
        public async Task atr2_mission()
        {
            print("atr2");
            await sleep_until(async () => volume_test_objects(tv_atr2_security_r, players()), 1);
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_02", 4142863542U));
            await this.save_atr2_start();
            ai_disposable(_1st_cov, true);
            ai_place(atr2_hum);
            print("hum bunker behind window");
            await sleep(5);
            ai_place(atr2_cov_floor);
            print("covenant harass below");
            await sleep_until(async () => volume_test_objects(tv_atr2_lstair, players()) || volume_test_objects(tv_atr2_floor_front, players()) || (float)ai_strength(atr2_cov) < 0.35F, 1);
            print("cov assault left stair");
            print("hum repel assault");
            print("cov guard hall");
            if ((short)ai_living_count(atr2_cov) < 7)
            {
                ai_place(atr2_cov_lstair);
            }
            else
            {
                ai_place(atr2_cov_lstair_elt.Squad);
                ai_place(atr2_cov_lstair_rear_elt.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_atr2_floor_front, players()), 1);
            this.mark_flavor_brace = true;
            print("hum take atrium floor");
            ai_place(atr2_cov_bbalcony_grt.Squad);
            await sleep_until(async () => volume_test_objects(tv_atr2_floor_mid, players()), 1);
            await this.save_atr2_mid();
            print("cov retreat to atrium back");
            print("cov guard back balcony");
            print("cov are reenforced");
            if ((short)ai_living_count(atr2_cov) < 7)
            {
                ai_place(atr2_cov_fnl);
            }
            else
            {
                ai_place(atr2_cov_fnl_elt.Squad);
            }

            if ((short)ai_living_count(atr2_cov) < 7)
            {
                ai_place(atr2_cov_re);
            }

            device_set_position(atr2_door_re.Entity, 1F);
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_01", 4140700821U));
            await sleep_until(async () => (short)structure_bsp_index() == 2, 10);
            this.mark_flavor_atr2 = false;
            this.mark_flavor_bay1 = true;
            ai_disposable(atr2_cov, true);
            ai_disposable(atr2_hum, true);
            ai_erase(atr2_cov_re);
            ai_erase(atr2_cov_floor);
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task cs_lookat_malta()
        {
            cs_force_combat_status(2);
            cs_face_object(true, malta.Entity);
            cs_go_to(GetReference<ISpatialPoint>("bay1/window"), 1F);
            sleep_forever();
        }

        [ScriptMethod(341, Lifecycle.Static)]
        public async Task bay1_malta()
        {
            print("boarder effect");
            object_damage_damage_section(malta.Entity, "default", 0.4F);
            cs_run_command_script(bay1_hum, new ScriptMethodReference(cs_lookat_malta));
            await sleep(120);
            await sleep_until(async () => objects_can_see_object(players(), malta.Entity, 35F), 1, 120);
            print("hey...check it out! the malta's already driven off its boarders?!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0200_cky", 4143453375U), ai_get_object(bay1_hum), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0200_cky", 4143453375U)));
            await sleep_until(async () => objects_can_see_object(players(), malta.Entity, 35F), 1, 60);
            print("malta, what is your status, over?");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0210_cor", 4143518912U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0210_cor", 4143518912U)));
            await sleep_until(async () => objects_can_see_object(players(), malta.Entity, 35F), 1, 120);
            print("i don't believe it! they're retreating! we won!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0220_mm1", 4143584449U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0220_mm1", 4143584449U)));
            await sleep_until(async () => objects_can_see_object(players(), malta.Entity, 35F), 1, 120);
            print("explosions!");
            object_damage_damage_section(malta.Entity, "default", 0.4F);
            await sleep(120);
            await sleep_until(async () => objects_can_see_object(players(), malta.Entity, 35F), 1, 120);
            print("boom!");
            object_damage_damage_section(malta.Entity, "default", 1F);
            sound_impulse_start(GetTag<SoundTag>("sound_remastered\\visual_effects\\ss_distship_explode", 4143649986U), default(IGameObject), 1F);
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_03", 4143715523U), default(IGameObject), 1F);
            await sleep(60);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0221_cky", 4144108745U), ai_get_object(bay1_hum), 1F);
            await sleep(90);
            sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\ss_distship_shake_quad", 4144174282U), default(IGameObject), 1F);
            damage_players(GetTag<DamageEffectTag>("effects\\damage_effects\\spacestation_shockwave", 4144370893U));
        }

        [ScriptMethod(342, Lifecycle.Dormant)]
        public async Task bay1_mission()
        {
            print("bay1");
            object_create_anew(bay1_boarding_door);
            await sleep_until(async () => volume_test_objects(tv_bay1_stairs, players()), 1);
            await this.save_bay1_start();
            await sleep(5);
            ai_place(bay1_hum);
            ai_place(bay1_cov_floor);
            ai_place(bay1_cov_catwalk);
            print("hum bunker below");
            print("covenant turrets above");
            print("covenant infantry below");
            await sleep_until(async () => (short)ai_living_count(bay1_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await sleep_until(async () => (short)ai_living_count(bay1_cov_floor_elt.Squad) == 0, 10);
            }

            await sleep_until(async () => (short)ai_living_count(bay1_cov) <= 2 || (short)ai_fighting_count(bay1_cov) <= 1, 10);
            ai_place(bay1_cov_wv2);
            await sleep(15);
            object_destroy(bay1_boarding_door.Entity);
            await sleep_until(async () => !(volume_test_objects(tv_bay1_boarding_tube, players())) && !(volume_test_objects(tv_bay1_boarding_tube, ai_actors(bay1_cov))), 1);
            object_create_anew(bay1_boarding_door);
            await sleep_until(async () => (short)ai_living_count(bay1_cov) < 4, 10);
            if (await this.difficulty_normal())
            {
                await sleep_until(async () => (short)ai_living_count(bay1_cov_wv2_elt.Squad) == 0, 10);
            }

            await sleep_until(async () => (short)ai_living_count(bay1_cov) <= 2 || (short)ai_fighting_count(bay1_cov) <= 1, 10);
            ai_place(bay1_cov_wv3);
            await sleep(15);
            object_destroy(bay1_boarding_door.Entity);
            await sleep_until(async () => !(volume_test_objects(tv_bay1_boarding_tube, players())) && !(volume_test_objects(tv_bay1_boarding_tube, ai_actors(bay1_cov))), 1);
            object_create_anew(bay1_boarding_door);
            await sleep_until(async () => (short)ai_living_count(bay1_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await sleep_until(async () => (short)ai_living_count(bay1_cov_wv3_elt.Squad) == 0, 10);
            }

            await sleep_until(async () => (short)ai_living_count(bay1_cov) <= 2 || (short)ai_fighting_count(bay1_cov) <= 1, 10);
            if (!(await this.difficulty_normal()))
            {
                ai_place(bay1_cov_wv4);
                await sleep(15);
                object_destroy(bay1_boarding_door.Entity);
                await sleep_until(async () => !(volume_test_objects(tv_bay1_boarding_tube, players())) && !(volume_test_objects(tv_bay1_boarding_tube, ai_actors(bay1_cov))), 1);
                object_create_anew(bay1_boarding_door);
            }

            await sleep_until(async () => (short)ai_living_count(bay1_cov) <= 4, 10);
            if (await this.difficulty_legendary())
            {
                await sleep((short)(15 * 30));
                ai_place(bay1_cov_wv5);
                await sleep(15);
                object_destroy(bay1_boarding_door.Entity);
                await sleep_until(async () => !(volume_test_objects(tv_bay1_boarding_tube, players())) && !(volume_test_objects(tv_bay1_boarding_tube, ai_actors(bay1_cov))), 1);
                object_create_anew(bay1_boarding_door);
            }

            this.mark_flavor_disable = true;
            await sleep_until(async () => (short)ai_living_count(bay1_cov) <= 1, 10);
            await sleep_until(async () => (short)ai_living_count(bay1_cov) <= 0, 10, 900);
            await sleep_until(async () => (short)ai_fighting_count(bay1_cov) <= 0, 10);
            await this.bay1_malta();
            await this.save_bay1_mid();
            cs_run_command_script(bay1_hum, new ScriptMethodReference(cs_clear));
            this.mark_flavor_disable = false;
            this.mark_flavor_bay1 = false;
            this.mark_flavor_bay2 = true;
            ai_place(bay1_cov_fnl);
            effect_new(GetTag<EffectTag>("effects\\objects\\weapons\\grenade\\plasma_grenade\\detonation.effect", 4144436430U), bay1_blast_flag_1);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\plasma_grenade\\damage_effects\\plasma_grenade_explosion.damage_effect", 4145288411U), bay1_blast_flag_1);
            await sleep(2);
            effect_new(GetTag<EffectTag>("effects\\objects\\weapons\\grenade\\plasma_grenade\\detonation.effect", 4144436430U), bay1_blast_flag_2);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\plasma_grenade\\damage_effects\\plasma_grenade_explosion.damage_effect", 4145288411U), bay1_blast_flag_2);
            sound_impulse_start(GetTag<SoundTag>("sound_remastered\\visual_effects\\ss_smalldoor_explode", 4145353948U), bay1_door_exit.Entity, 1F);
            sound_impulse_start(GetTag<SoundTag>("sound_remastered\\weapons\\plasma_grenade\\plasma_expl", 4145419485U), bay1_door_exit.Entity, 1F);
            object_destroy(bay1_door_exit.Entity);
            this.mark_flavor_brace = true;
            await sleep_until(async () => volume_test_objects(tv_bay2_hall, players()), 1);
            ai_disposable(bay1_cov, true);
            await sleep_until(async () => (short)structure_bsp_index() == 0, 10);
            ai_erase(bay1_cov);
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task cs_lookat_athens()
        {
            cs_force_combat_status(2);
            cs_face_object(true, athens.Entity);
            cs_go_to(GetReference<ISpatialPoint>("bay2/window"), 1F);
            sleep_forever();
        }

        [ScriptMethod(344, Lifecycle.Static)]
        public async Task bay2_athens()
        {
            print("boarder effect");
            object_damage_damage_section(athens.Entity, "default", 0.4F);
            cs_run_command_script(bay1_hum, new ScriptMethodReference(cs_lookat_athens));
            await sleep(120);
            await sleep_until(async () => objects_can_see_object(players(), athens.Entity, 25F), 1, 120);
            print("uh-oh. they're leaving the athens!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0230_cky", 4145747170U), default(IGameObject), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0230_cky", 4145747170U)));
            await sleep_until(async () => objects_can_see_object(players(), athens.Entity, 25F), 1, 120);
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_04", 4145812707U), default(IGameObject), 1F);
            print("explosions!");
            await sleep(45);
            object_damage_damage_section(athens.Entity, "default", 0.4F);
            await sleep_until(async () => objects_can_see_object(players(), athens.Entity, 25F), 1, 120);
            print("boom!");
            sound_impulse_start(GetTag<SoundTag>("sound_remastered\\visual_effects\\ss_distship_explode", 4143649986U), default(IGameObject), 1F);
            object_damage_damage_section(athens.Entity, "default", 1F);
            await sleep(90);
            sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\ss_distship_shake_quad", 4144174282U), default(IGameObject), 1F);
            damage_players(GetTag<DamageEffectTag>("effects\\damage_effects\\spacestation_shockwave", 4144370893U));
            print("cortana, assessment!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0260_lhd", 4146074855U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0260_lhd", 4146074855U)));
            print("that explosion came from inside the athens - same as the malta. the covenant must have brought something with them. a bomb.");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0270_cor", 4146140392U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0270_cor", 4146140392U)));
            print("then they sure as hell brought one here. chief, find it!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0280_lhd", 4146205929U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0280_lhd", 4146205929U)));
            objectives_finish_up_to(0);
            objectives_show_up_to(1);
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task bay2_mission()
        {
            print("bay2");
            object_create_anew(bay2_boarding_door);
            await sleep_until(async () => volume_test_objects(tv_bay2_hall, players()), 1);
            await this.save_bay2_start();
            ai_place(bay2_hum);
            ai_place(bay2_cov_floor);
            ai_place(bay2_cov_catwalk);
            print("hum bunker below");
            print("covenant turrets above");
            print("covenant infantry below");
            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await sleep_until(async () => (short)ai_living_count(bay2_cov_floor_elt.Squad) == 0, 10);
            }

            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 2 || (short)ai_fighting_count(bay2_cov) <= 1, 10);
            ai_place(bay2_cov_wv2);
            await sleep(15);
            object_destroy(bay2_boarding_door.Entity);
            await sleep_until(async () => !(volume_test_objects(tv_bay2_boarding_tube, players())) && !(volume_test_objects(tv_bay2_boarding_tube, ai_actors(bay2_cov))), 1);
            if (await this.difficulty_normal())
            {
                wake(new ScriptMethodReference(save_bay2_retreat));
            }

            object_create_anew(bay2_boarding_door);
            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await sleep_until(async () => (short)ai_living_count(bay2_cov_wv2_elt.Squad) == 0, 10);
            }

            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 2 || (short)ai_fighting_count(bay2_cov) <= 1, 10);
            ai_place(bay2_cov_wv3);
            await sleep(15);
            object_destroy(bay2_boarding_door.Entity);
            await sleep_until(async () => !(volume_test_objects(tv_bay2_boarding_tube, players())) && !(volume_test_objects(tv_bay2_boarding_tube, ai_actors(bay2_cov))), 1);
            object_create_anew(bay2_boarding_door);
            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 4, 10);
            if (await this.difficulty_normal())
            {
                await sleep_until(async () => (short)ai_living_count(bay2_cov_wv3_elt.Squad) == 0, 10);
            }

            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 2 || (short)ai_fighting_count(bay2_cov) <= 1, 10);
            if (!(await this.difficulty_normal()))
            {
                ai_place(bay2_cov_wv4);
                await sleep(15);
                object_destroy(bay2_boarding_door.Entity);
                await sleep_until(async () => !(volume_test_objects(tv_bay2_boarding_tube, players())) && !(volume_test_objects(tv_bay2_boarding_tube, ai_actors(bay2_cov))), 1);
                object_create_anew(bay2_boarding_door);
            }

            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 4, 10);
            if (await this.difficulty_legendary())
            {
                await sleep((short)(10 * 30));
                ai_place(bay2_cov_wv5);
                await sleep(15);
                object_destroy(bay2_boarding_door.Entity);
                await sleep_until(async () => !(volume_test_objects(tv_bay2_boarding_tube, players())) && !(volume_test_objects(tv_bay2_boarding_tube, ai_actors(bay2_cov))), 1);
                object_create_anew(bay2_boarding_door);
            }

            this.mark_flavor_disable = true;
            await sleep_until(async () => (short)ai_living_count(bay2_cov_catwalk) == 0, 10);
            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 1, 10);
            await sleep_until(async () => (short)ai_living_count(bay2_cov) <= 0, 10, 900);
            await sleep_until(async () => (short)ai_fighting_count(bay2_cov) <= 0, 10);
            await this.bay2_athens();
            await this.save_bay2_mid();
            wake(new ScriptMethodReference(title_bay2));
            this.mark_flavor_disable = false;
            this.mark_flavor_board = false;
            this.mark_flavor_bay2 = false;
            this.mark_flavor_bomb = true;
            ai_place(bay2_cov_fnl);
            device_operates_automatically_set(bay2_door_exit_1.Entity, true);
            device_operates_automatically_set(bay2_door_exit_2.Entity, true);
            wake(new ScriptMethodReference(save_bay2_fnl));
            await sleep_until(async () => (short)structure_bsp_index() == 0, 1);
            device_set_position_immediate(bay2_door_exit_1.Entity, 0F);
            device_set_position_immediate(bay2_door_exit_2.Entity, 0F);
            device_operates_automatically_set(bay2_door_exit_1.Entity, false);
            device_operates_automatically_set(bay2_door_exit_2.Entity, false);
            ai_erase(bay2_cov);
            ai_erase(bay2_hum);
            ai_erase(bay1_hum);
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task cs_arm_guns_grate()
        {
            cs_enable_targeting(true);
            cs_go_to(GetReference<ISpatialPoint>("arm/guns"));
            sleep_forever();
        }

        [ScriptMethod(347, Lifecycle.Dormant)]
        public async Task arm_mission()
        {
            print("arm");
            await sleep(5);
            ai_place(arm_cov_stl.Squad);
            wake(new ScriptMethodReference(save_arm_start));
            await sleep_until(async () => volume_test_objects(tv_arm_start, players()), 1);
            await sleep(3);
            ai_place(arm_hum_guns.Squad);
            ai_cannot_die(arm_hum_guns.Squad, true);
            ai_place(arm_cov_elt.Squad);
            ai_cannot_die(arm_cov_elt.Squad, true);
            this.mark_flavor_disable = true;
            await sleep_until(async () => volume_test_objects(tv_arm_stairs, players()), 1);
            if (await this.difficulty_legendary() && (bool)game_is_cooperative())
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3400_gun", 4146271466U), ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if ((bool)game_is_cooperative())
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3390_gun", 4146337003U), ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if (await this.difficulty_legendary())
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3420_gun", 4146402540U), ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if (await this.difficulty_heroic())
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3410_gun", 4146468077U), ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if (true)
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3380_gun", 4146533614U), ai_get_object(arm_hum_guns.Squad), 1F);
            }

            await sleep(60);
            device_operates_automatically_set(arm_door_charger_1.Entity, true);
            device_operates_automatically_set(arm_door_charger_2.Entity, true);
            await sleep_until(async () => device_get_position(arm_door_charger_1.Entity) >= 0.1F || device_get_position(arm_door_charger_2.Entity) >= 0.1F, 1, 150);
            if (await this.difficulty_legendary() && (bool)game_is_cooperative() && (float)real_random_range(0F, 1F) > 0.9F)
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3450_gun", 4146599151U), ai_get_object(arm_hum_guns.Squad), 1F);
            }
            else if (true)
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3430_gun", 4146664688U), ai_get_object(arm_hum_guns.Squad), 1F);
            }

            await sleep_until(async () => device_get_position(arm_door_charger_1.Entity) >= 0.3F || device_get_position(arm_door_charger_2.Entity) >= 0.3F, 1, (int)((float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3450_gun", 4146599151U)) + (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3430_gun", 4146664688U))));
            ai_cannot_die(arm_hum_guns.Squad, false);
            ai_cannot_die(arm_cov_elt.Squad, false);
            ai_kill(arm_hum_guns.Squad);
            await sleep_until(async () => (short)ai_living_count(arm_cov) == 0 || volume_test_objects(tv_atr1_floor, players()), 1);
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_05", 4146730225U), default(IGameObject), 1F);
            this.mark_flavor_disable = false;
            this.mark_flavor_atr1 = true;
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task cs_atr1_turret_fbalcony()
        {
            cs_deploy_turret(GetReference<ISpatialPoint>("atr1_turrets/fbalcony"));
            damage_new(GetTag<DamageEffectTag>("effects\\damage_effects\\glass_breaker", 4147123447U), fbalcony_flag);
        }

        [ScriptMethod(349, Lifecycle.CommandScript)]
        public async Task cs_atr1_turret_bbalcony()
        {
            cs_deploy_turret(GetReference<ISpatialPoint>("atr1_turrets/bbalcony"));
            damage_new(GetTag<DamageEffectTag>("effects\\damage_effects\\glass_breaker", 4147123447U), bbalcony_flag);
        }

        [ScriptMethod(350, Lifecycle.Dormant)]
        public async Task atr1_mission()
        {
            print("atr1");
            await sleep_until(async () => volume_test_objects(tv_atr1_floor, players()), 1);
            wake(new ScriptMethodReference(save_atr1_start));
            await sleep(15);
            ai_place(atr1_cov_fbalcony);
            ai_place(atr1_cov_bbalcony);
            ai_place(atr1_cov_sec_front);
            this.mark_flavor_brace = true;
            await sleep_until(async () => volume_test_objects(tv_atr1_mid, players()), 1);
            ai_place(atr1_cov_stairs_front);
            await sleep_until(async () => (float)ai_strength(atr1_cov_stairs) < 0.25F || volume_test_objects(tv_atr1_stairs, players()), 1);
            if ((short)ai_living_count(atr1_cov) < 6)
            {
                ai_place(atr1_cov_stairs_back);
            }
            else
            {
                ai_place(atr1_cov_stairs_back_elt.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_atr1_sec, players()), 1);
            if ((short)ai_living_count(atr1_cov) < 6)
            {
                ai_place(atr1_cov_sec_back);
            }
            else
            {
                ai_place(atr1_cov_sec_back_elt.Squad);
            }

            await sleep_until(async () => (short)ai_living_count(atr1_cov_sec_back) == 0 || volume_test_objects(tv_trm1_floor, players()), 1);
            this.mark_flavor_atr1 = false;
            this.mark_flavor_trm1 = true;
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_05", 4146730225U));
            await sleep_until(async () => volume_test_objects(tv_trm1_floor, players()), 1);
            sleep_forever(new ScriptMethodReference(save_atr1_start));
            ai_disposable(atr1_cov, true);
            await sleep_until(async () => (short)structure_bsp_index() == 3, 10);
            ai_erase(atr1_cov);
        }

        [ScriptMethod(351, Lifecycle.CommandScript)]
        public async Task cs_trm1_bunker()
        {
            cs_enable_moving(false);
            cs_crouch(true);
            sleep_forever();
        }

        [ScriptMethod(352, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_player_crouch()
        {
            cs_enable_moving(false);
            cs_crouch(true);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(353, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_miranda_crouch()
        {
            cs_enable_moving(false);
            cs_crouch(true);
            cs_face_object(true, ai_get_object(trm1_hum_miranda.Squad));
            sleep_forever();
        }

        [ScriptMethod(354, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_johnson_crouch()
        {
            cs_enable_moving(false);
            cs_crouch(true);
            cs_face_object(true, ai_get_object(trm1_hum_johnson.Squad));
            sleep_forever();
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task trm1_tomyship()
        {
            cs_run_command_script(trm1_hum_johnson.Squad, new ScriptMethodReference(cs_trm1_lookat_player_crouch));
            print("c'mon, chief! this way!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0290_jon", 4147188984U), default(IGameObject), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0290_jon", 4147188984U)));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(trm1_hum_miranda.Squad)) < 3F && objects_can_see_object(players(), ai_get_object(trm1_hum_miranda.Squad), 25F), 1, 120);
            cs_run_command_script(trm1_hum_miranda.Squad, new ScriptMethodReference(cs_trm1_lookat_player_crouch));
            print("i was almost on-board when they showed up.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0300_mir", 4147254521U), ai_get_object(trm1_hum_miranda.Squad), 1F);
            await sleep(30);
            cs_run_command_script(trm1_hum_johnson.Squad, new ScriptMethodReference(cs_trm1_lookat_miranda_crouch));
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0300_mir", 4147254521U)));
            print("don't worry, ma'am. we'll get 'em!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0310_jon", 4147320058U), ai_get_object(trm1_hum_johnson.Squad), 1F);
            await sleep(30);
            cs_run_command_script(trm1_hum_miranda.Squad, new ScriptMethodReference(cs_trm1_lookat_johnson_crouch));
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0310_jon", 4147320058U)));
            cs_run_command_script(trm1_hum_johnson.Squad, new ScriptMethodReference(cs_clear));
            await sleep(30);
            cs_run_command_script(trm1_hum_miranda.Squad, new ScriptMethodReference(cs_clear));
        }

        [ScriptMethod(356, Lifecycle.CommandScript)]
        public async Task cs_trm1_approach()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_approach(await this.player0(), 2F, 6F, 3F);
            sleep_forever();
        }

        [ScriptMethod(357, Lifecycle.CommandScript)]
        public async Task cs_trm1_moveto_alock()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("trm1/alock"));
        }

        [ScriptMethod(358, Lifecycle.CommandScript)]
        public async Task cs_trm1_moveto_alock_miranda()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("trm1/alock_miranda"));
        }

        [ScriptMethod(359, Lifecycle.CommandScript)]
        public async Task cs_trm1_moveto_alock_johnson()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("trm1/alock_johnson"));
        }

        [ScriptMethod(360, Lifecycle.CommandScript)]
        public async Task cs_trm1_moveto_alock_block()
        {
            cs_go_to(GetReference<ISpatialPoint>("trm1/alock_block"));
        }

        [ScriptMethod(361, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_block()
        {
            cs_enable_moving(false);
            cs_face_object(true, ai_get_object(trm1_hum_block_mar.Squad));
            sleep_forever();
        }

        [ScriptMethod(362, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_player()
        {
            cs_enable_moving(false);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(363, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_miranda()
        {
            cs_enable_moving(false);
            cs_face_object(true, ai_get_object(trm1_hum_miranda.Squad));
            sleep_forever();
        }

        [ScriptMethod(364, Lifecycle.CommandScript)]
        public async Task cs_trm1_lookat_johnson()
        {
            cs_enable_moving(false);
            cs_face_object(true, ai_get_object(trm1_hum_johnson.Squad));
            sleep_forever();
        }

        [ScriptMethod(365, Lifecycle.Dormant)]
        public async Task trm1_bugproblem()
        {
            cs_run_command_script(trm1_hum_block_mar.Squad, new ScriptMethodReference(cs_trm1_approach));
            cs_run_command_script(trm1_hum_miranda.Squad, new ScriptMethodReference(cs_trm1_approach));
            cs_run_command_script(trm1_hum_johnson.Squad, new ScriptMethodReference(cs_trm1_approach));
            await sleep(30);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(trm1_hum_miranda.Squad)) < 2F, 1, 120);
            print("thanks, chief. i owe you one.  take me now!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0380_mir", 4147385595U), ai_get_object(trm1_hum_miranda.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0380_mir", 4147385595U)));
            await sleep_until(async () => volume_test_objects(tv_trm1_block, players()), 1, 180);
            await sleep_until(async () => objects_can_see_object(players(), ai_get_object(trm1_hum_johnson.Squad), 40F), 1, 90);
            if (objects_distance_to_object(players(), ai_get_object(trm1_hum_johnson.Squad)) < 4F)
            {
                print("get going. i'll cover the commander!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0370_jon", 4147451132U), ai_get_object(trm1_hum_johnson.Squad), 1F);
            }

            cs_run_command_script(trm1_hum_miranda.Squad, new ScriptMethodReference(cs_clear));
            cs_run_command_script(trm1_hum_johnson.Squad, new ScriptMethodReference(cs_clear));
        }

        [ScriptMethod(366, Lifecycle.Dormant)]
        public async Task trm1_cleanup()
        {
            await sleep(90);
            await sleep_until(async () => volume_test_objects_all(tv_trm1_start, players()) && device_get_position(trm1_door_exit.Entity) == 0F && await this.player_count() > 0, 1);
            ai_erase(atr1_cov_bbalcony);
            ai_erase(atr1_cov_fbalcony);
            ai_erase(atr1_cov_stairs);
        }

        [ScriptMethod(367, Lifecycle.Dormant)]
        public async Task trm1_mission()
        {
            print("trm1");
            await sleep_until(async () => volume_test_objects(tv_trm1_floor, players()), 1);
            this.mark_flavor_disable = true;
            object_create(trm1_tram);
            await this.save_trm1_start();
            ai_place(trm1_hum_alock);
            object_set_permutation(ai_get_object(trm1_hum_johnson.Squad), "helmet", "");
            ai_cannot_die(trm1_hum_johnson.Squad, true);
            ai_cannot_die(trm1_hum_miranda.Squad, true);
            cs_run_command_script(trm1_hum_johnson.Squad, new ScriptMethodReference(cs_trm1_bunker));
            cs_run_command_script(trm1_hum_miranda.Squad, new ScriptMethodReference(cs_trm1_bunker));
            ai_place(trm1_cov_alock);
            await sleep_until(async () => volume_test_objects(tv_trm1_start, players()), 1);
            wake(new ScriptMethodReference(trm1_cleanup));
            await this.trm1_tomyship();
            await sleep_until(async () => volume_test_objects(tv_trm1_alock, players()) || (short)ai_living_count(trm1_cov_alock) == 0, 1);
            ai_set_orders(trm1_hum_block, trm1_hum_block1);
            await sleep_until(async () => (short)ai_living_count(trm1_cov_alock) == 0, 1);
            wake(new ScriptMethodReference(trm1_bugproblem));
            this.mark_flavor_disable = false;
            await sleep_until(async () => volume_test_objects(tv_trm1_block, players()), 1);
            ai_place(trm1_cov_block);
            ai_magically_see_object(trm1_cov_block, await this.player0());
            ai_magically_see_object(trm1_cov_block, await this.player1());
            await sleep_until(async () => volume_test_objects(tv_dck_mid, players()), 1);
            ai_set_orders(trm1_hum_alock, trm1_hum_iac);
            ai_disposable(trm1_cov_alock, true);
            ai_disposable(trm1_cov_block, true);
            ai_disposable(trm1_hum_alock, true);
            ai_disposable(trm1_hum_block, true);
            await sleep_until(async () => (short)structure_bsp_index() == 3, 10);
            ai_erase(trm1_cov_alock);
            ai_erase(trm1_cov_block);
            ai_erase(trm1_hum_alock);
            ai_erase(trm1_hum_block);
        }

        [ScriptMethod(368, Lifecycle.Dormant)]
        public async Task dck_hog()
        {
            object_create_anew(dck_hog1);
            object_create_anew(dck_hog_rail);
            objects_attach(dck_hog_rail.Entity, "rail", dck_hog1.Entity, "");
            device_set_position_track(dck_hog_rail.Entity, "track:rail", 0F);
            device_animate_position(dck_hog_rail.Entity, 1F, 20F, 0F, 0F, true);
            await sleep((short)(200 * 30));
            object_destroy(dck_hog1.Entity);
            object_destroy(dck_hog_rail.Entity);
        }

        [ScriptMethod(369, Lifecycle.Static)]
        public async Task dck_setusup()
        {
            print("sir! boarders have breached the fire-control center. they have a bomb!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0390_cor", 4147516669U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0390_cor", 4147516669U)));
            print("can you defuse it?");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0400_lhd", 4147582206U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0400_lhd", 4147582206U)));
            print("yes...but i'll need the chief's help to make contact with the detonator.");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0410_cor", 4147647743U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0410_cor", 4147647743U)));
            print("chief, get to the bomb. double-time! cortana, prioritize targets, and fire-at-will!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0450_lhd", 4147713280U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0450_lhd", 4147713280U)));
        }

        [ScriptMethod(370, Lifecycle.Dormant)]
        public async Task dck_mission()
        {
            print("dck");
            await sleep_until(async () => volume_test_objects(tv_dck_start, players()), 1);
            this.mark_flavor_trm1 = false;
            this.mark_flavor_dck = true;
            await sleep_until(async () => volume_test_objects_all(tv_dck_start, players()) && await this.player_count() > 0, 1, 90);
            volume_teleport_players_not_inside(tv_dck_start, dck_enter_flag);
            object_create(dck_wall_enter);
            device_set_position(dck_door_arm_1.Entity, 0F);
            await this.save_dck_start();
            wake(new ScriptMethodReference(title_dck));
            await sleep(45);
            device_set_position(dck_door_arm_2.Entity, 1F);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\ss_airlock\\airlock", 4147778817U), default(IGameObject), 1F);
            await sleep(45);
            physics_set_gravity(0.75F);
            set_global_sound_environment(1F, 1F, 0F, 0F, 1000, 5F);
            this.mark_flavor_vacuum = true;
            ai_place(dck_cov_enter_elt.Squad);
            ai_place(dck_cov_arm1_elt.Squad);
            await sleep_until(async () => volume_test_objects(tv_dck_arm1_back, players()), 1);
            wake(new ScriptMethodReference(dck_hog));
            await sleep_until(async () => volume_test_objects(tv_dck_mid, players()) || (float)ai_strength(dck_cov) <= 0.3F, 1);
            ai_place(dck_cov_arm2);
            ai_magically_see_object(dck_cov_arm2, await this.player0());
            ai_magically_see_object(dck_cov_arm2, await this.player1());
            this.mark_flavor_disable = true;
            await sleep(150);
            await this.dck_setusup();
            this.mark_flavor_disable = false;
            await sleep_until(async () => (short)structure_bsp_index() == 3, 10);
            ai_erase(dck_cov);
        }

        [ScriptMethod(371, Lifecycle.Dormant)]
        public async Task elv_goinloud()
        {
            sleep_forever(new ScriptMethodReference(dck_setusup));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0390_cor", 4147516669U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0400_lhd", 4147582206U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0410_cor", 4147647743U));
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0450_lhd", 4147713280U));
            this.mark_flavor_disable = true;
            print("first echelon, you're with me. blanket those cruisers - take 'em out one-by-one. second echelon, keep those carriers busy!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0470_ahp", 4147909891U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0470_ahp", 4147909891U)));
            await sleep(15);
            print("registering all hostile vessels inside the kill-zone. thirteen cruisers, two assault-carriers. i'm going loud!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0460_cor", 4147975428U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0460_cor", 4147975428U)));
            await sleep_until(async () => objects_can_see_flag(players(), macgun_flag, 25F), 1, 120);
            device_set_power(macgun.Entity, 1F);
            device_set_power(gun_loader.Entity, 1F);
            this.mark_flavor_disable = false;
            await this.save_elv_start();
        }

        [ScriptMethod(372, Lifecycle.Static)]
        public async Task<bool> elv_elevator_test()
        {
            return device_get_position(elv_elevator.Entity) > 0.8F;
        }

        [ScriptMethod(373, Lifecycle.Static)]
        public async Task<bool> elv_elevator_down()
        {
            return volume_test_objects_all(tv_elevator, players());
        }

        [ScriptMethod(374, Lifecycle.Dormant)]
        public async Task elv_mission()
        {
            print("elv");
            await sleep_until(async () => (short)structure_bsp_index() == 3, 1);
            object_type_predict(GetTag<BaseTag>("objects\\characters\\marine\\marine", 3974367920U));
            object_type_predict(GetTag<BaseTag>("objects\\characters\\bugger\\bugger", 4078047453U));
            set_global_sound_environment(1F, 1F, 1F, 1F, 8000, 0F);
            physics_set_gravity(1F);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\ss_airlock\\airlock_repressurize", 4148040965U), default(IGameObject), 1F);
            this.mark_flavor_vacuum = false;
            device_operates_automatically_set(bsp3_door_backward.Entity, false);
            device_operates_automatically_set(bsp3_door_backward_2.Entity, false);
            device_operates_automatically_set(bsp3_door_forward.Entity, true);
            objects_attach(elv_elevator.Entity, "control_1", elv_elevator_control_1.Entity, "");
            objects_attach(elv_elevator.Entity, "control_2", elv_elevator_control_2.Entity, "");
            await this.save_elv_start();
            wake(new ScriptMethodReference(elv_goinloud));
            ai_place(elv_hum_mar.Squad);
            await sleep_until(async () => volume_test_objects(tv_elv_start, players()), 1);
            ai_place(elv_cov_top);
            await sleep(30);
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_07", 4148172039U), default(IGameObject), 1F);
            await sleep_until(async () => (float)ai_strength(elv_cov) <= 0.35F, 10);
            object_type_predict(GetTag<BaseTag>("objects\\characters\\grunt\\grunt", 3901753113U));
            object_type_predict(GetTag<BaseTag>("objects\\characters\\elite\\elite", 3822060122U));
            await sleep(15);
            ai_place(elv_cov_elevator);
            await sleep(5);
            device_set_position(lvr_door_enter_1.Entity, 1F);
            device_set_power(elv_elevator_control_1.Entity, 1F);
            device_set_power(elv_elevator_control_2.Entity, 1F);
            await sleep_until(async () => device_get_position(lvr_door_enter_1.Entity) == 1F, 1);
            await sleep_until(async () => volume_test_objects_all(tv_elevator, ai_actors(elv_cov_elevator)), 1, 20 * 30);
            device_set_position(elv_elevator.Entity, 1F);
            await sleep_until(async () => device_group_get(elv_elevator_position) > 0F, 1, 120 * 30);
            device_set_position(elv_elevator.Entity, 0F);
            device_set_power(elv_elevator_control_1.Entity, 0F);
            device_set_power(elv_elevator_control_2.Entity, 0F);
            await sleep_until(async () => volume_test_objects_all(tv_lvr_enter, players()), 1);
            ai_disposable(elv_cov, true);
            ai_disposable(elv_hum_mar.Squad, true);
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task lvr_carrier_flyby()
        {
            object_create(carrier_01);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenery\\solids\\human_fleet_ships_attack_carrier", 4148434187U), carrier_01.Entity, "bow");
            scenery_animation_start_relative(carrier_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\spacestation\\spacestation", 4149155094U), "capital_ship_01", flyby.Entity);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\spacestation\\cap_ship_flyover", 4149220631U), lvr_flyby_flag.Entity, 1F);
            await sleep(330);
            damage_players(GetTag<DamageEffectTag>("effects\\damage_effects\\carrier_flyby", 4149351705U));
            await sleep_until(async () => scenery_get_animation_time(carrier_01.Entity) == 0, 1);
            object_destroy(carrier_01.Entity);
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task lvr_carriers()
        {
            this.mark_flavor_disable = true;
            print("the carriers are breaking-through, sir! they're heading straight for the cairo!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0500_ahp", 4149417242U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0500_ahp", 4149417242U)));
            await sleep(7);
            print("cortana, concentrate your fire on the first carrier! admiral, do what you can against the second!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0510_lhd", 4149482779U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0510_lhd", 4149482779U)));
            await sleep(8);
            print("everyone form-up! follow my lead!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0520_ahp", 4149548316U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0520_ahp", 4149548316U)));
            this.mark_flavor_disable = false;
            await this.save_lvr_start();
            await sleep_until(async () => volume_test_objects(tv_lvr_back, players()), 1, 15 * 30);
            this.mark_flavor_disable = true;
            print("the first carrier completely ignored us, sir - blew through the malta's debris-field, and headed straight for earth!");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0530_cor", 4149613853U), default(IGameObject), 1F, "radio_default");
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0530_cor", 4149613853U)));
            this.mark_flavor_disable = false;
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task lvr_mission()
        {
            print("lvr");
            await sleep_until(async () => volume_test_objects_all(tv_lvr_enter, players()) && await this.player_count() > 0, 1);
            object_create(lvr_wall_enter);
            device_set_position(lvr_door_enter_1.Entity, 0F);
            wake(new ScriptMethodReference(lvr_carriers));
            await sleep_until(async () => device_get_position(lvr_door_enter_1.Entity) == 0F, 1);
            ai_erase(elv_cov_top);
            await sleep_until(async () => (bool)game_safe_to_save(), 1, 150);
            await this.save_lvr_start();
            await sleep(30);
            ai_place(lvr_cov_wv1);
            wake(new ScriptMethodReference(lvr_carrier_flyby));
            device_set_position(lvr_door_enter_2.Entity, 1F);
            device_set_power(lvr_airlock_blower.Entity, 1F);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\ss_airlock\\airlock", 4147778817U), default(IGameObject), 1F);
            await sleep(30);
            physics_set_gravity(0.75F);
            this.mark_flavor_vacuum = true;
            biped_ragdoll(lvr_body_1.Entity);
            biped_ragdoll(lvr_body_2.Entity);
            await sleep(60);
            set_global_sound_environment(1F, 1F, 0F, 0F, 1000, 5F);
            device_set_power(lvr_airlock_blower.Entity, 0F);
            await sleep_until(async () => volume_test_objects(tv_lvr_back, players()), 1);
            if (!(await this.difficulty_normal()))
            {
                ai_place(lvr_cov_wv2);
            }

            await sleep_until(async () => objects_distance_to_object(players(), gun_elevator_door_top.Entity) < 4F, 1);
            device_operates_automatically_set(gun_elevator_door_top.Entity, true);
            device_set_position_immediate(gun_elevator.Entity, 0.1F);
            device_set_position(gun_elevator.Entity, 0F);
            await sleep_until(async () => volume_test_objects_all(tv_gun_elevator, players()) && await this.player_count() > 0, 1);
            object_create(gun_wall_enter);
            sleep_forever(new ScriptMethodReference(lvr_carriers));
            this.mark_flavor_disable = true;
            device_set_position(gun_elevator.Entity, 1F);
            ai_disposable(gun_cov, true);
            physics_set_gravity(1F);
            set_global_sound_environment(1F, 1F, 1F, 1F, 8000, 0F);
            this.mark_flavor_vacuum = false;
            await sleep(30);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\ss_airlock\\airlock_repressurize", 4148040965U), default(IGameObject), 1F);
            await sleep(30);
            print("there's quite a lot of elites in here, you may need to get creative.");
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_4000_cor", 4149679390U), default(IGameObject), 1F, "radio_default");
            await sleep((short)((float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_4000_cor", 4149679390U)) - 60));
            wake(new ScriptMethodReference(title_gun));
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_08", 4149744927U), default(IGameObject), 1F);
            this.mark_flavor_disable = false;
            ai_erase(lvr_cov);
        }

        [ScriptMethod(378, Lifecycle.CommandScript)]
        public async Task cs_expand_cortana()
        {
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            object_set_scale(ai_get_object(this.ai_current_actor), 0.01F, 1);
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\teleport_in", 4150531371U), ai_get_object(this.ai_current_actor), "body");
            await sleep(1);
            object_set_scale(ai_get_object(this.ai_current_actor), 0.4F, 20);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(379, Lifecycle.CommandScript)]
        public async Task cs_shrink_cortana()
        {
            cs_enable_dialogue(false);
            await sleep(60);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\teleport_out", 4150924593U), ai_get_object(this.ai_current_actor), "body");
            await sleep(3);
            object_set_scale(ai_get_object(this.ai_current_actor), 0.01F, 20);
            await sleep(30);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task gun_flyby()
        {
            object_create(carrier_02);
            scenery_animation_start_relative(carrier_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\spacestation\\spacestation", 4149155094U), "capital_ship_02", anchor_outro1.Entity);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenery\\solids\\human_fleet_ships_attack_carrier", 4148434187U), carrier_02.Entity, "bow");
            await sleep(330);
            damage_players(GetTag<DamageEffectTag>("effects\\damage_effects\\carrier_flyby", 4149351705U));
            await sleep_until(async () => scenery_get_animation_time(carrier_02.Entity) == 0, 1);
            object_destroy(carrier_02.Entity);
        }

        [ScriptMethod(381, Lifecycle.Static)]
        public async Task gun_mission()
        {
            print("gun");
            object_type_predict(GetTag<BaseTag>("objects\\characters\\grunt\\grunt", 3901753113U));
            object_type_predict(GetTag<BaseTag>("objects\\characters\\elite\\elite", 3822060122U));
            await sleep_until(async () => volume_test_objects_all(tv_elv_enter, players()) && await this.player_count() > 0, 1);
            this.mark_flavor_dck = false;
            this.mark_flavor_gun = true;
            object_create(gun_wall_enter);
            await this.save_gun_start();
            ai_place(gun_cov);
            ai_place(gun_hum_mar.Squad);
            wake(new ScriptMethodReference(gun_flyby));
            await sleep_until(async () => (short)ai_living_count(gun_cov) <= 4, 1);
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_08", 4149744927U), true);
            this.mark_flavor_vacuum = true;
            await sleep_until(async () => (short)ai_living_count(gun_cov) == 0, 1);
            this.mark_flavor_bomb = false;
            this.mark_flavor_disable = true;
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\01b_spacestation\\01b_music\\01b_08", 4149744927U));
            await sleep(150);
            await sleep_until(async () => objects_distance_to_object(players(), pickle.Entity) < 4F, 1, 150);
            this.mark_bomb2_objective = true;
        }

        [ScriptMethod(382, Lifecycle.Static)]
        public async Task load_bsp0a()
        {
            object_create_anew(rack_bsp0a_1_smg_1);
            objects_attach(rack_bsp0a_1.Entity, "smg_1", rack_bsp0a_1_smg_1.Entity, "");
            object_create_anew(rack_bsp0a_1_smg_2);
            objects_attach(rack_bsp0a_1.Entity, "smg_2", rack_bsp0a_1_smg_2.Entity, "");
            object_create_anew(rack_bsp0a_2_br_1);
            objects_attach(rack_bsp0a_2.Entity, "br_2", rack_bsp0a_2_br_1.Entity, "");
            object_create_anew(rack_bsp0a_2_br_2);
            objects_attach(rack_bsp0a_2.Entity, "br_3", rack_bsp0a_2_br_2.Entity, "");
            object_create_anew(rack_bsp0a_3_smg_1);
            objects_attach(rack_bsp0a_3.Entity, "smg_1", rack_bsp0a_3_smg_1.Entity, "");
            object_create_anew(rack_bsp0a_3_smg_2);
            objects_attach(rack_bsp0a_3.Entity, "smg_2", rack_bsp0a_3_smg_2.Entity, "");
            object_create_anew(rack_bsp0a_4_br_1);
            objects_attach(rack_bsp0a_4.Entity, "br_2", rack_bsp0a_4_br_1.Entity, "");
            object_create_anew(rack_bsp0a_4_br_2);
            objects_attach(rack_bsp0a_4.Entity, "br_4", rack_bsp0a_4_br_2.Entity, "");
            object_create_anew(rack_bsp0a_5_smg_1);
            objects_attach(rack_bsp0a_5.Entity, "smg_1", rack_bsp0a_5_smg_1.Entity, "");
            object_create_anew(rack_bsp0a_5_smg_2);
            objects_attach(rack_bsp0a_5.Entity, "smg_3", rack_bsp0a_5_smg_2.Entity, "");
            object_create_anew(rack_bsp0a_5_smg_3);
            objects_attach(rack_bsp0a_5.Entity, "smg_4", rack_bsp0a_5_smg_3.Entity, "");
            object_create_anew(rack_bsp0a_6_br_1);
            objects_attach(rack_bsp0a_6.Entity, "br_1", rack_bsp0a_6_br_1.Entity, "");
            object_create_anew(rack_bsp0a_6_br_2);
            objects_attach(rack_bsp0a_6.Entity, "br_2", rack_bsp0a_6_br_2.Entity, "");
            object_create_anew(rack_bsp0a_6_br_3);
            objects_attach(rack_bsp0a_6.Entity, "br_4", rack_bsp0a_6_br_3.Entity, "");
            object_create_anew(bigrack_bsp0a_5_smg_1);
            objects_attach(bigrack_bsp0a_5.Entity, "gun_r_01", bigrack_bsp0a_5_smg_1.Entity, "");
            object_create_anew(bigrack_bsp0a_5_smg_2);
            objects_attach(bigrack_bsp0a_5.Entity, "gun_r_03", bigrack_bsp0a_5_smg_2.Entity, "");
            object_create_anew(bigrack_bsp0a_5_smg_3);
            objects_attach(bigrack_bsp0a_5.Entity, "gun_l_02", bigrack_bsp0a_5_smg_3.Entity, "");
            object_create_anew(bigrack_bsp0a_6_smg_1);
            objects_attach(bigrack_bsp0a_6.Entity, "gun_l_02", bigrack_bsp0a_6_smg_1.Entity, "");
            object_create_anew(bigrack_bsp0a_6_smg_2);
            objects_attach(bigrack_bsp0a_6.Entity, "gun_r_03", bigrack_bsp0a_6_smg_2.Entity, "");
        }

        [ScriptMethod(383, Lifecycle.Static)]
        public async Task load_bsp2()
        {
            object_create_anew(rack_bsp2_1_smg_1);
            objects_attach(rack_bsp2_1.Entity, "smg_1", rack_bsp2_1_smg_1.Entity, "");
            object_create_anew(rack_bsp2_1_smg_2);
            objects_attach(rack_bsp2_1.Entity, "smg_2", rack_bsp2_1_smg_2.Entity, "");
            object_create_anew(rack_bsp2_1_smg_3);
            objects_attach(rack_bsp2_1.Entity, "smg_3", rack_bsp2_1_smg_3.Entity, "");
        }

        [ScriptMethod(384, Lifecycle.Static)]
        public async Task load_bsp0b()
        {
            object_create_anew(rack_bsp0b_1_br_1);
            objects_attach(rack_bsp0b_1.Entity, "br_1", rack_bsp0b_1_br_1.Entity, "");
            object_create_anew(rack_bsp0b_1_br_2);
            objects_attach(rack_bsp0b_1.Entity, "br_3", rack_bsp0b_1_br_2.Entity, "");
            object_create_anew(rack_bsp0b_2_smg_1);
            objects_attach(rack_bsp0b_2.Entity, "smg_2", rack_bsp0b_2_smg_1.Entity, "");
            object_create_anew(rack_bsp0b_2_smg_2);
            objects_attach(rack_bsp0b_2.Entity, "smg_4", rack_bsp0b_2_smg_2.Entity, "");
            object_create_anew(bigrack_bsp0b_1_br_1);
            objects_attach(bigrack_bsp0b_1.Entity, "gun_l_01", bigrack_bsp0b_1_br_1.Entity, "");
            object_create_anew(bigrack_bsp0b_1_br_2);
            objects_attach(bigrack_bsp0b_1.Entity, "gun_r_02", bigrack_bsp0b_1_br_2.Entity, "");
            object_create_anew(bigrack_bsp0b_2_br_1);
            objects_attach(bigrack_bsp0b_2.Entity, "gun_l_03", bigrack_bsp0b_2_br_1.Entity, "");
            object_create_anew(bigrack_bsp0b_3_br_1);
            objects_attach(bigrack_bsp0b_3.Entity, "gun_l_02", bigrack_bsp0b_3_br_1.Entity, "");
            object_create_anew(bigrack_bsp0b_3_br_2);
            objects_attach(bigrack_bsp0b_3.Entity, "gun_r_01", bigrack_bsp0b_3_br_2.Entity, "");
            object_create_anew(bigrack_bsp0b_4_br_1);
            objects_attach(bigrack_bsp0b_4.Entity, "gun_r_02", bigrack_bsp0b_4_br_1.Entity, "");
            object_create_anew(bigrack_bsp0b_5_smg_1);
            objects_attach(bigrack_bsp0b_5.Entity, "gun_r_01", bigrack_bsp0b_5_smg_1.Entity, "");
            object_create_anew(bigrack_bsp0b_6_smg_1);
            objects_attach(bigrack_bsp0b_6.Entity, "gun_l_03", bigrack_bsp0b_6_smg_1.Entity, "");
            object_create_anew(bigrack_bsp0b_6_smg_2);
            objects_attach(bigrack_bsp0b_6.Entity, "gun_r_02", bigrack_bsp0b_6_smg_2.Entity, "");
            object_create_anew(bigrack_bsp0b_7_smg_1);
            objects_attach(bigrack_bsp0b_7.Entity, "gun_r_03", bigrack_bsp0b_7_smg_1.Entity, "");
            object_create_anew(bigrack_bsp0b_8_smg_1);
            objects_attach(bigrack_bsp0b_8.Entity, "gun_l_01", bigrack_bsp0b_8_smg_1.Entity, "");
            object_create_anew(atr1_elevator);
        }

        [ScriptMethod(385, Lifecycle.Static)]
        public async Task load_bsp3()
        {
            object_create_anew(rack_bsp3_1_br_1);
            objects_attach(rack_bsp3_1.Entity, "br_1", rack_bsp3_1_br_1.Entity, "");
            object_create_anew(rack_bsp3_1_br_2);
            objects_attach(rack_bsp3_1.Entity, "br_3", rack_bsp3_1_br_2.Entity, "");
            object_create_anew(rack_bsp3_2_smg_1);
            objects_attach(rack_bsp3_2.Entity, "smg_2", rack_bsp3_2_smg_1.Entity, "");
            object_create_anew(rack_bsp3_2_smg_2);
            objects_attach(rack_bsp3_2.Entity, "smg_4", rack_bsp3_2_smg_2.Entity, "");
            object_create_anew(rack_bsp3_4_br_1);
            objects_attach(rack_bsp3_4.Entity, "br_2", rack_bsp3_4_br_1.Entity, "");
            object_create_anew(rack_bsp3_4_br_2);
            objects_attach(rack_bsp3_4.Entity, "br_2", rack_bsp3_4_br_2.Entity, "");
            object_create_anew(rack_bsp3_5_smg_1);
            objects_attach(rack_bsp3_5.Entity, "smg_3", rack_bsp3_5_smg_1.Entity, "");
        }

        [ScriptMethod(386, Lifecycle.Static)]
        public async Task mission_start()
        {
            print("01b spacestation");
            print("designer - jaime");
            print("env. artsits - paul, dave");
        }

        [ScriptMethod(387, Lifecycle.Static)]
        public async Task mission_setup()
        {
            objectives_clear();
            game_can_use_flashlights(false);
            ai_allegiance(player, human);
            ai_allegiance(covenant, prophet);
            ai_allegiance(prophet, covenant);
            device_set_position_immediate(macgun.Entity, 0F);
            device_set_position_immediate(gun_loader.Entity, 0F);
            device_set_power(macgun.Entity, 0F);
            device_set_power(gun_loader.Entity, 0F);
            object_create(malta);
            object_create(athens);
        }

        [ScriptMethod(388, Lifecycle.Startup)]
        public async Task mission_spacestation()
        {
            if (await this.player_count() == 0)
            {
                sleep_forever();
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
            object_type_predict(GetTag<BaseTag>("scenarios\\objects\\solo\\spacestation\\ss_tram_car\\ss_tram_car", 4150990130U));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.mission_start();
            await this.mission_setup();
            await this.load_bsp0a();
            wake(new ScriptMethodReference(flavor_mission));
            wake(new ScriptMethodReference(_1st_mission));
            wake(new ScriptMethodReference(atr2_mission));
            wake(new ScriptMethodReference(_1st_tram));
            await sleep(1);
            await this.cinematic_fade_from_white();
            await sleep_until(async () => (short)structure_bsp_index() == 2, 1);
            await this.load_bsp2();
            device_operates_automatically_set(bsp2_door_forward.Entity, true);
            wake(new ScriptMethodReference(bay1_mission));
            wake(new ScriptMethodReference(bay2_mission));
            await sleep_until(async () => (short)structure_bsp_index() == 0, 1);
            await this.load_bsp0b();
            wake(new ScriptMethodReference(ice_cream_check));
            wake(new ScriptMethodReference(arm_mission));
            wake(new ScriptMethodReference(atr1_mission));
            wake(new ScriptMethodReference(trm1_mission));
            wake(new ScriptMethodReference(dck_mission));
            await sleep_until(async () => (short)structure_bsp_index() == 3, 1);
            await this.load_bsp3();
            wake(new ScriptMethodReference(elv_mission));
            wake(new ScriptMethodReference(lvr_mission));
            await this.gun_mission();
            await this.playtest_mission();
            await this.save_cutscene();
            await this.cinematic_fade_to_white();
            device_set_power(gun_loader.Entity, 0F);
            device_set_power(macgun.Entity, 0F);
            await sleep(45);
            if (await this.cinematic_skip_start())
            {
                await this.cinematic_stash_players();
                await this.c01_outro();
                await this.cinematic_unstash_players();
            }

            await this.cinematic_skip_stop();
            game_won();
        }

        [ScriptMethod(389, Lifecycle.Static)]
        public async Task cheat_atr2()
        {
            switch_bsp(0);
            object_teleport(await this.player0(), atr2_flag);
        }

        [ScriptMethod(390, Lifecycle.Static)]
        public async Task cheat_bay1()
        {
            switch_bsp(2);
            object_teleport(await this.player0(), bay1_flag);
        }

        [ScriptMethod(391, Lifecycle.Static)]
        public async Task cheat_bay2()
        {
            switch_bsp(2);
            object_teleport(await this.player0(), bay2_flag);
        }

        [ScriptMethod(392, Lifecycle.Static)]
        public async Task cheat_arm()
        {
            switch_bsp(0);
            object_teleport(await this.player0(), arm_flag);
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task cheat_atr1()
        {
            switch_bsp(0);
            wake(new ScriptMethodReference(mission_spacestation));
            object_teleport(await this.player0(), atr1_flag);
        }

        [ScriptMethod(394, Lifecycle.Static)]
        public async Task cheat_trm1()
        {
            switch_bsp(0);
            wake(new ScriptMethodReference(mission_spacestation));
            object_teleport(await this.player0(), trm1_flag);
        }

        [ScriptMethod(395, Lifecycle.Static)]
        public async Task cheat_elv()
        {
            switch_bsp(3);
            wake(new ScriptMethodReference(mission_spacestation));
            wake(new ScriptMethodReference(mission_spacestation));
            object_teleport(await this.player0(), elv_flag);
        }

        [ScriptMethod(396, Lifecycle.Static)]
        public async Task cheat_lvr()
        {
            switch_bsp(3);
            wake(new ScriptMethodReference(mission_spacestation));
            wake(new ScriptMethodReference(mission_spacestation));
            object_teleport(await this.player0(), lvr_flag);
        }

        [ScriptMethod(397, Lifecycle.Static)]
        public async Task cheat_gun()
        {
            switch_bsp(3);
            wake(new ScriptMethodReference(mission_spacestation));
            wake(new ScriptMethodReference(mission_spacestation));
            object_teleport(await this.player0(), gun_flag);
        }

        [ScriptMethod(398, Lifecycle.Dormant)]
        public async Task x02_01_predict()
        {
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 59, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 61, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 75, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 85, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 92, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 95, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 97, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 98, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 101, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 102, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 104, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 106, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 69, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 89, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 91, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 86, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 11, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\ss_prop", 4154922350U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 87, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 100, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 96, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 103, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 110, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4155315572U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787915345U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack_slim\\ss_gun_rack_slim", 4157216145U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\case_ap_turret\\case_ap_turret", 4157740441U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 4158264737U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack\\ss_gun_rack", 4158461348U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 34, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\chair_sofa\\chair_sofa", 4158723496U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\case\\case", 4158985644U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4159182255U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 4159444403U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3783000070U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 87, false);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 33, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_internet_kiosk\\ss_internet_kiosk", 4159641014U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\case_ap_turret\\case_ap_turret", 4157740441U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack\\ss_gun_rack", 4158461348U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4160886217U), 0);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\news_drone\\news_drone", 4161213902U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4159182255U), 0);
            await sleep(156);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 73, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 107, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 89, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 51);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 44);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 39);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack_slim\\ss_gun_rack_slim", 4157216145U), 0);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 63, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 63, true);
            await sleep(90);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 101, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 47, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 48, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 56, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 62, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 50);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 41);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_internet_kiosk\\ss_internet_kiosk", 4159641014U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_tram\\ss_door_tram", 4162065883U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4162328031U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 26, false);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 72, false);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 5, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            await sleep(57);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_0"), 32, true);
            await sleep(57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 55);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 32);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 34);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 4165801492U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 4166325788U), 0);
        }

        [ScriptMethod(399, Lifecycle.Dormant)]
        public async Task x02_02_predict()
        {
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            await sleep(8);
            await sleep(49);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(32);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 4166784547U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 24);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4170716767U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4171306600U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4171568748U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4172027507U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4159182255U), 0);
            await sleep(149);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            await sleep(55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 4166784547U), 8);
            await sleep(87);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 4166325788U), 0);
            await sleep(64);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 4166325788U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 32);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4171306600U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4172027507U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4159182255U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\crowds\\crowd_front_a\\crowd_front_a", 4172748414U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\crowds\\crowd_front_b\\crowd_front_b", 4173141636U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\crowds\\crowd_front_c\\crowd_front_c", 4173207173U), 0);
            await sleep(154);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 4166784547U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 4166325788U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4170716767U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4171306600U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4171568748U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4172027507U), 0);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            await sleep(89);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
        }

        [ScriptMethod(400, Lifecycle.Dormant)]
        public async Task x02_03_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 34);
            await sleep(131);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            await sleep(79);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            await sleep(50);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4172027507U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4160886217U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\fixed\\h_turret_mp\\h_turret_mp", 4173272710U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\fixed\\plasma_cannon\\plasma_cannon", 4173665932U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\fixed\\plasma_cannon\\plasma_cannon", 4173665932U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 8);
            await sleep(36);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4162328031U), 0);
            await sleep(84);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 18, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4159182255U), 0);
            await sleep(25);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, true);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 1);
            await sleep(57);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4170716767U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4171568748U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 73);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 65);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4175566505U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4175763116U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 62);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
        }

        [ScriptMethod(401, Lifecycle.Dormant)]
        public async Task x02_04a_predict()
        {
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, false);
            await sleep(20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            await sleep(19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            await sleep(106);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4175763116U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            await sleep(18);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            await sleep(34);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            await sleep(34);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            await sleep(66);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 65);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 73);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4175763116U), 0);
            await sleep(160);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 2);
            await sleep(95);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
        }

        [ScriptMethod(402, Lifecycle.Dormant)]
        public async Task x02_04b_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4175763116U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4175566505U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\colonial_cross\\colonial_cross", 4176221875U), 0);
            await sleep(81);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            await sleep(36);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            await sleep(66);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4175763116U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\colonial_cross\\colonial_cross", 4176221875U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4175566505U), 0);
            await sleep(107);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            await sleep(124);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4170716767U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4171306600U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4172027507U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 32);
        }

        [ScriptMethod(403, Lifecycle.Dormant)]
        public async Task x02_05_predict()
        {
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 4176484023U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 4176484023U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 4166784547U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 24);
            await sleep(59);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4159182255U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(129);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            await sleep(36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 28);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822191196U), 32);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4172027507U), 0);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4170716767U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4175566505U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 73);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 65);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\medal_tray\\medal_tray", 4175763116U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\medals\\colonial_cross\\colonial_cross", 4176221875U), 0);
        }

        [ScriptMethod(404, Lifecycle.Dormant)]
        public async Task x02_06_predict()
        {
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            await sleep(7);
            await sleep(27);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            await sleep(29);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 2);
            await sleep(41);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            await sleep(101);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            await sleep(98);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            await sleep(131);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_marine_prop\\dress_marine_prop", 4176156338U), 2);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            await sleep(118);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4160886217U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\fixed\\h_turret_mp\\h_turret_mp", 4173272710U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3784114199U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\branding_iron\\branding_iron", 4177598152U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 4171306600U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\elite_helmet_charred\\elite_helmet_charred", 4178056911U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 34);
        }

        [ScriptMethod(405, Lifecycle.Dormant)]
        public async Task x02_07_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            await sleep(9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4178253522U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4178253522U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4178253522U), 13);
            await sleep(71);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4170716767U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4171568748U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4172027507U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 9);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(130);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, true);
            await sleep(57);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4178253522U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4178253522U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 4178253522U), 13);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4170716767U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 4168750657U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4171568748U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 4171634285U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\manacles\\manacles", 4172027507U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 4171699822U), 9);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 0);
            await sleep(75);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 4162721253U), 34);
            await sleep(62);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 4170716767U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 4171568748U), 0);
            await sleep(76);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            await sleep(55);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 4164687363U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\holo_display_large", 4179891947U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4175566505U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 65);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 73);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 8);
        }

        [ScriptMethod(406, Lifecycle.Dormant)]
        public async Task x02_08_predict()
        {
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            await sleep(70);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\holo_display_large", 4179891947U), 0);
            await sleep(78);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 4);
            await sleep(30);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 65);
            await sleep(128);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            await sleep(107);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 65);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 73);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            await sleep(117);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3901884187U), 4);
            await sleep(33);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            await sleep(106);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4175566505U), 0);
        }

        [ScriptMethod(407, Lifecycle.Dormant)]
        public async Task x02_09_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 21, true);
            await sleep(155);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 50);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 19);
            await sleep(15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 37);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 52);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 71);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 71);
            await sleep(19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 52);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\holo_display_large", 4179891947U), 0);
            await sleep(149);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            await sleep(100);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 35);
            await sleep(67);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, true);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            await sleep(25);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\pillarofautumn\\pillarofautumn", 4180547317U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_large\\holo_display_large", 4179891947U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge_holoscreens\\holo_display_unsc_logo\\holo_display_unsc_logo", 4175566505U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 52);
        }

        [ScriptMethod(408, Lifecycle.Dormant)]
        public async Task x02_10_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01a_tutorial\\01_bsp_1"), 1, true);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4181595909U), 1);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 73);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 50);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 35);
            await sleep(78);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4181595909U), 1);
        }

        [ScriptMethod(409, Lifecycle.Dormant)]
        public async Task _01_outro_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_exterior_gun\\ss_exterior_gun_hinge\\ss_exterior_gun_hinge", 4153152851U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\ss_prop", 4154922350U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_tram_car\\ss_tram_car", 4151121204U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_tram_car\\ss_tram_car", 4151121204U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_tram_car\\ss_tram_car", 4151121204U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_tram\\ss_door_tram", 4162065883U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\magnum\\magnum", 3811180980U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\fixed\\h_turret_mp\\weapon\\weapon", 4182054668U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 51);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787915345U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4155315572U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_internet_kiosk\\ss_internet_kiosk", 4159641014U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\case_ap_turret\\case_ap_turret", 4157740441U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\chair_dining\\chair_dining", 4182120205U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\chair_sofa\\chair_sofa", 4158723496U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\trashcan\\trashcan", 4182316816U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_furniture\\table_coffee\\table_coffee", 4182513427U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\case\\case", 4158985644U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 4158264737U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4160886217U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\player_wall\\player_wall", 4182578964U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\dress_cap\\dress_cap", 4159182255U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 4159444403U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4162328031U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 4084863301U), 16);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack\\ss_gun_rack", 4158461348U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing\\crate_packing", 4182644501U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4155315572U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_hab_large\\ss_door_int_hab_large", 4161738198U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\light_red_rotate\\light_red_rotate", 4182841112U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4183562019U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_loader\\ss_gun_loader", 4184217389U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_elevator_gunchamber\\ss_elevator_gunchamber", 4184741685U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 4120384351U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 17, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787915345U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 4185265981U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_hangar_cinematic\\ss_door_hangar_cinematic", 4185593666U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_hangar_door_switch\\ss_hangar_door_switch", 4185986888U), 0);
            await sleep(25);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787915345U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(27);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 37, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 4185265981U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787915345U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 51);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4155315572U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_multi_single\\crate_multi_single", 4186511184U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_multi\\crate_multi", 4186838869U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4160886217U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4162328031U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\debris_mini_b\\debris_mini_b", 4187166554U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\debris_mini_a\\debris_mini_a", 4187756387U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 4159444403U), 0);
            await sleep(137);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_stand_cortana\\ss_stand_cortana", 4174976672U), 0);
            await sleep(133);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 30, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3787915345U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 4185265981U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 26);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 4159444403U), 0);
            await sleep(56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
        }

        [ScriptMethod(410, Lifecycle.Dormant)]
        public async Task _01_outro_02_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 10, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge\\cairo_bridge", 4187821924U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 4189919108U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_boarding_craft\\cov_boarding_craft", 4190836626U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_boarding_craft\\cov_boarding_craft", 4190836626U), 0);
            await sleep(100);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge\\cairo_bridge", 4187821924U), 0);
            await sleep(129);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4183562019U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            await sleep(48);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 4174255765U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge\\cairo_bridge", 4187821924U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(75);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_boarding_craft\\cov_boarding_craft", 4190836626U), 1);
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task _01_outro_03_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 15, false);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4183562019U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\ss_elevator\\ss_elevator", 4191229848U), 0);
            await sleep(100);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4162328031U), 0);
            await sleep(61);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4162328031U), 0);
            await sleep(76);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4160886217U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\ss_elevator\\ss_elevator", 4191229848U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\debris_mini_b\\debris_mini_b", 4187166554U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\debris_mini_a\\debris_mini_a", 4187756387U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 4155315572U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_gun_rack_slim\\ss_gun_rack_slim", 4157216145U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 5, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, false);
            await sleep(25);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            await sleep(51);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 27, true);
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task _01_outro_04_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\earth_space\\earth_space", 4191295385U), 0);
            await sleep(104);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4183562019U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\ss_elevator_light\\ss_elevator_light", 4191623070U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 4185265981U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_multi_single\\crate_multi_single", 4186511184U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 50);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 60);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 14, false);
            await sleep(76);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 4162328031U), 0);
            await sleep(73);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4183562019U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 4191688607U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, false);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            await sleep(26);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 35, false);
        }

        [ScriptMethod(413, Lifecycle.Dormant)]
        public async Task _01_outro_05_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4181595909U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 4191885218U), 0);
            await sleep(197);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\doors\\ss_door_int_mech_small\\ss_door_int_mech_small", 4160886217U), 0);
            await sleep(123);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\earth_space\\earth_space", 4191295385U), 0);
        }

        [ScriptMethod(414, Lifecycle.Dormant)]
        public async Task _01_outro_06_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            await sleep(210);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            await sleep(38);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 2, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 29, false);
            await sleep(50);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 39, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 40, false);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 1, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 28, false);
            await sleep(23);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 19, false);
            await sleep(34);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01_bsp_3"), 10, false);
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task _01_outro_07_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\01b_spacestation\\01outro_bsp"), 0, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4181595909U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\spacestation\\pickle\\pickle", 4183562019U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_space\\africa_space", 4192278440U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 4192475051U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\pillarofautumn\\pillarofautumn", 4180547317U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 4192671662U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3786997827U), 0);
            await sleep(311);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_space\\africa_space", 4192278440U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 4192475051U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            await sleep(193);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 4192671662U), 2);
            await sleep(67);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4181595909U), 1);
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task _01_outro_08_predict()
        {
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\longsword\\longsword", 4181595909U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 4192475051U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_up\\cruiser_interior_up", 4193458106U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_core\\cruiser_interior_core", 4193654717U), 0);
            await sleep(301);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_side\\cruiser_interior_side", 4194113476U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_core\\cruiser_interior_core", 4193654717U), 0);
            await sleep(266);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\cruiser_interior_up\\cruiser_interior_up", 4193458106U), 0);
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task _01_outro_09_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_space\\africa_space", 4192278440U), 0);
        }

        [ScriptMethod(418, Lifecycle.Dormant)]
        public async Task _01_outro_10_predict()
        {
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 4192671662U), 2);
            await sleep(198);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 4156495238U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
            await sleep(17);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 4194310087U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_coast\\africa_coast", 4195162068U), 0);
            await sleep(123);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3974498994U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 4113568503U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 4189919108U), 0);
            await sleep(164);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 4194310087U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\africa_coast\\africa_coast", 4195162068U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 4162459105U), 0);
        }
    }
}