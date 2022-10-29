namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\08a_deltacliffs\\08a_deltacliffs")]
    public partial class scnr_08a_deltacliffs : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool g_mission_over;
        int _15_seconds;
        int _30_seconds;
        int _45_seconds;
        int one_minute;
        int two_minutes;
        IUnit g_cov_stealth_major;
        IUnit g_cov_gold_elite;
        int g_brute_alarm_level;
        bool g_e10_started;
        int g_e10_pro_inf1_2_count;
        IUnit g_e10_weapon_scene0_actor;
        EffectTag g_e10_pod_impact_effect;
        bool g_e9_started;
        bool g_e8_started;
        bool g_e7_started;
        bool g_e6_started;
        bool g_e6_pro_inf1_arrived;
        bool g_e5_started;
        int g_e5_grunts_released;
        bool g_e4_started;
        bool g_e3_started;
        bool g_e2_started;
        bool g_e2_safe_to_migrate_inf2;
        bool g_e1_started;
        IUnit g_e1_wounded_elite;
        bool g_e1_cov_inf0_should_die;
        bool g_e1_pro_inf0_searching;
        bool g_e1_pro_inf1_was_alerted;
        bool g_e1_stealth_major_done;
        bool g_e1_zealot_revealed;
        EffectTag g_e1_pod_impact_effect;
        public scnr_08a_deltacliffs(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.g_mission_over = false;
            this._15_seconds = 450;
            this._30_seconds = 900;
            this._45_seconds = 900;
            this.one_minute = 1800;
            this.two_minutes = 3600;
            this.g_cov_stealth_major = default(IUnit);
            this.g_cov_gold_elite = default(IUnit);
            this.g_brute_alarm_level = 0;
            this.g_e10_started = false;
            this.g_e10_pro_inf1_2_count = 4;
            this.g_e10_weapon_scene0_actor = default(IUnit);
            this.g_e10_pod_impact_effect = GetTag<EffectTag>("effects\\scenarios\\solo\\earthcity\\e11_insertion_pod_impact", 4196669425U);
            this.g_e9_started = false;
            this.g_e8_started = false;
            this.g_e7_started = false;
            this.g_e6_started = false;
            this.g_e6_pro_inf1_arrived = false;
            this.g_e5_started = false;
            this.g_e5_grunts_released = 0;
            this.g_e4_started = false;
            this.g_e3_started = false;
            this.g_e2_started = false;
            this.g_e2_safe_to_migrate_inf2 = false;
            this.g_e1_started = false;
            this.g_e1_wounded_elite = default(IUnit);
            this.g_e1_cov_inf0_should_die = false;
            this.g_e1_pro_inf0_searching = false;
            this.g_e1_pro_inf1_was_alerted = false;
            this.g_e1_stealth_major_done = false;
            this.g_e1_zealot_revealed = false;
            this.g_e1_pod_impact_effect = GetTag<EffectTag>("effects\\scenarios\\solo\\earthcity\\e11_insertion_pod_impact", 4196669425U);
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
        public async Task _08_intro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intro_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _08_intra1_01_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra1_01_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _08_intra1_02_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra1_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _08_intra1_03_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra1_03_predict));
        }

        [ScriptMethod(28, Lifecycle.Dormant)]
        public async Task c08_intro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intro\\foley\\c08_intro_01_fol", 3817013773U), default(IGameObject), 1F);
            print("c08_intro foley 01 start");
        }

        [ScriptMethod(29, Lifecycle.Dormant)]
        public async Task intro_fov()
        {
            await sleep(279);
            print("fov change: 70 -> 50 over 0 ticks");
            camera_set_field_of_view(50F, 0);
        }

        [ScriptMethod(30, Lifecycle.Dormant)]
        public async Task intro_dof()
        {
            await sleep(484);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            print("rack focus");
            await sleep(60);
            print("rack focus");
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0.5F, 1F, 0.5F, 0F, 1F);
            await sleep(103);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(31, Lifecycle.Dormant)]
        public async Task effect_teleport()
        {
            await sleep(240);
            print("effect - teleport");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\cinematic_teleport", 3817079310U), teleport.Entity, "marker");
        }

        [ScriptMethod(32, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intro()
        {
            cinematic_lighting_set_primary_light(16F, -32F, 0.501961F, 0.501961F, 0.4F);
            cinematic_lighting_set_secondary_light(13F, 120F, 0.231373F, 0.231373F, 0.388235F);
            cinematic_lighting_set_ambient_light(0.14902F, 0.14902F, 0.101961F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(intro_plasma_rifle.Entity, true);
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task plasma_rifle_attach()
        {
            await sleep(705);
            objects_attach(dervish.Entity, "right_hand_elite", intro_plasma_rifle.Entity, "");
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task c08_intro_setup()
        {
            object_create_anew(dervish);
            object_create_anew(teleport);
            object_create_anew(intro_plasma_rifle);
            object_cinematic_lod(dervish.Entity, true);
            wake(new ScriptMethodReference(c08_intro_foley_01));
            wake(new ScriptMethodReference(effect_teleport));
            wake(new ScriptMethodReference(intro_fov));
            wake(new ScriptMethodReference(plasma_rifle_attach));
            wake(new ScriptMethodReference(cinematic_lighting_intro));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task c08_intro()
        {
            sound_class_set_gain("amb", 0F, 0);
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp0"));
            await sleep(1);
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(70F, 0);
            sound_class_set_gain("amb", 1F, 60);
            await this._08_intro_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intro\\foley\\c08_intro_01_fol", 3817013773U));
            await sleep(100);
            await this.c08_intro_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intro\\08_intro", 3817734680U), "08_intro_01", default(IUnit), anchor_flag_intro);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intro\\08_intro", 3817800217U), "dervish_01", false, anchor_intro.Entity);
            fade_in(0F, 0F, 0F, 30);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            sound_class_set_gain("amb", 0F, 15);
            await sleep(15);
            object_destroy(dervish.Entity);
            object_destroy(intro_plasma_rifle.Entity);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c08_intra1_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_01_fol", 3817931291U), default(IGameObject), 1F);
            print("c08_intra1 foley 01 start");
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c08_2010_soc()
        {
            await sleep(461);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2010_soc", 3817996828U), commander.Entity, 1F);
            cinematic_subtitle("c08_2010_soc", 3F);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c04_intra1_dof_01()
        {
            time_code_reset();
            time_code_show(true);
            time_code_start(true);
            await sleep(80);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1.5F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            print("rack focus");
            time_code_reset();
            await sleep(120);
            cinematic_screen_effect_set_depth_of_field(1.5F, 0F, 0.5F, 0.5F, 0.5F, 0F, 0.5F);
            print("rack focus");
            time_code_reset();
            await sleep(50);
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            print("rack focus");
            time_code_reset();
            await sleep(86);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra1_01()
        {
            cinematic_lighting_set_primary_light(40F, 134F, 0.321569F, 0.321569F, 0.290196F);
            cinematic_lighting_set_secondary_light(8F, 274F, 0.301961F, 0.290196F, 0.45098F);
            cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            object_uses_cinematic_lighting(dervish_01.Entity, true);
            object_uses_cinematic_lighting(commander.Entity, true);
            object_uses_cinematic_lighting(wraith_01.Entity, true);
            object_uses_cinematic_lighting(scarab_01.Entity, true);
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task c08_intra1_01_setup()
        {
            object_create_anew(dervish_01);
            object_create_anew(commander);
            object_create_anew(wraith_01);
            object_cinematic_lod(dervish_01.Entity, true);
            object_cinematic_lod(commander.Entity, true);
            object_cinematic_lod(wraith_01.Entity, true);
            cinematic_clone_players_weapon(dervish_01.Entity, "right_hand_elite", "");
            wake(new ScriptMethodReference(c08_intra1_foley_01));
            wake(new ScriptMethodReference(c08_2010_soc));
            wake(new ScriptMethodReference(c04_intra1_dof_01));
            wake(new ScriptMethodReference(cinematic_lighting_intra1_01));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task c08_intra1_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(50F, 0);
            cinematic_lightmap_shadow_enable();
            await this._08_intra1_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_01_fol", 3817931291U));
            await sleep(this.prediction_offset);
            await this.c08_intra1_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra1\\08_intra1", 3818062365U), "08_intra1_01", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(dervish_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra1\\08_intra1", 3818127902U), "dervish_01", false, anchor_intra1.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\08_intra1\\08_intra1", 3818193439U), "commander_01", false, anchor_intra1.Entity);
            custom_animation_relative(wraith_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\wraith\\08_intra1\\08_intra1", 3818324513U), "wraith_01", false, anchor_intra1.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._08_intra1_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\music\\c08_intra1_02_mus", 3818390050U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_02_fol", 3818455587U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c08_intra1_sound_scene2_01()
        {
            sound_class_set_gain("vehicle", 0F, 0);
            object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 0F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 0F);
            await sleep(210);
            sound_class_set_gain("vehicle", 1F, 60);
            await sleep(60);
            sound_class_set_gain("vehicle", 0F, 150);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c08_intra1_score_02()
        {
            await sleep(337);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\music\\c08_intra1_02_mus", 3818390050U), default(IGameObject), 1F);
            print("c08_intra1 score 02 start");
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task c08_intra1_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_02_fol", 3818455587U), default(IGameObject), 1F);
            print("c08_intra1 foley 02 start");
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task c08_2020_der()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2020_der", 3818521124U), dervish_01.Entity, 1F);
            cinematic_subtitle("c08_2020_der", 3F);
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task c08_2030_soc()
        {
            await sleep(77);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2030_soc", 3818586661U), commander.Entity, 1F);
            cinematic_subtitle("c08_2030_soc", 4F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task c04_intra1_dof_02()
        {
            await sleep(427);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1.22F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(84);
            cinematic_screen_effect_set_depth_of_field(0.5F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(100);
            cinematic_screen_effect_set_depth_of_field(0.5F, 0.5F, 0F, 0F, 0F, 0.5F, 0.5F);
            print("rack focus");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra1_02()
        {
            cinematic_lighting_set_primary_light(40F, 134F, 0.321569F, 0.321569F, 0.290196F);
            cinematic_lighting_set_secondary_light(8F, 274F, 0.301961F, 0.290196F, 0.45098F);
            cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            object_uses_cinematic_lighting(phantom_01.Entity, true);
            object_uses_cinematic_lighting(phantom_02.Entity, true);
        }

        [ScriptMethod(49, Lifecycle.Static)]
        public async Task c08_intra1_02_setup()
        {
            object_create_anew(phantom_01);
            object_create_anew(phantom_02);
            object_cinematic_lod(phantom_01.Entity, true);
            object_cinematic_lod(phantom_02.Entity, true);
            wake(new ScriptMethodReference(c08_intra1_sound_scene2_01));
            wake(new ScriptMethodReference(c08_intra1_score_02));
            wake(new ScriptMethodReference(c08_intra1_foley_02));
            wake(new ScriptMethodReference(c08_2020_der));
            wake(new ScriptMethodReference(c08_2030_soc));
            wake(new ScriptMethodReference(cinematic_lighting_intra1_02));
        }

        [ScriptMethod(50, Lifecycle.Static)]
        public async Task c08_intra1_02_cleanup()
        {
            object_destroy(dervish_01.Entity);
            object_destroy(commander.Entity);
            object_destroy(phantom_02.Entity);
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task c08_intra1_scene_02()
        {
            await this.c08_intra1_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra1\\08_intra1", 3818062365U), "08_intra1_02", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(dervish_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra1\\08_intra1", 3818127902U), "dervish_02", false, anchor_intra1.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\08_intra1\\08_intra1", 3818193439U), "commander_02", false, anchor_intra1.Entity);
            custom_animation_relative(wraith_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\wraith\\08_intra1\\08_intra1", 3818324513U), "wraith_02", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\08_intra1\\08_intra1", 3818652198U), "phantom01_02", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\08_intra1\\08_intra1", 3818652198U), "phantom02_02", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._08_intra1_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_03_fol", 3818717735U));
            await sleep((short)camera_time());
            await this.c08_intra1_02_cleanup();
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task c08_intra1_sound_scene3_01()
        {
            object_set_function_variable(phantom_01.Entity, "engine_hack", 0F, 0F);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 0F, 0F);
            object_set_function_variable(phantom_01.Entity, "engine_audio", 0F, 0F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 0F, 0F);
            object_set_function_variable(phantom_01.Entity, "hover_audio", 0F, 0F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 0F, 0F);
            sound_class_set_gain("vehicle", 1F, 30);
            await sleep(120);
            object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 180F);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 180F);
            object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 180F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 180F);
            object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 180F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 180F);
            sound_class_set_gain("vehicle", 0F, 180);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c08_intra1_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_03_fol", 3818717735U), default(IGameObject), 1F);
            print("c08_intra1 foley 03 start");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c08_2040_tar()
        {
            await sleep(268);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2040_tar", 3818783272U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_2040_tar", 2F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra1_03()
        {
            cinematic_lighting_set_primary_light(40F, 134F, 0.321569F, 0.321569F, 0.290196F);
            cinematic_lighting_set_secondary_light(8F, 274F, 0.301961F, 0.290196F, 0.45098F);
            cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(monitor.Entity, true);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(brute_03.Entity, true);
            object_uses_cinematic_lighting(brute_04.Entity, true);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task show_brutes()
        {
            await sleep(199);
            print("show brutes");
            object_hide(brute_01.Entity, false);
            object_hide(brute_02.Entity, false);
            object_hide(brute_03.Entity, false);
            object_hide(brute_04.Entity, false);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task door_close()
        {
            await sleep(430);
            print("door close");
            device_set_position(intra1_door.Entity, 0F);
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task c08_intra1_03_setup()
        {
            object_create_anew(tartarus);
            object_create_anew(miranda);
            object_create_anew(monitor);
            object_create_anew(brute_01);
            object_create_anew(brute_02);
            object_create_anew(brute_03);
            object_create_anew(brute_04);
            object_set_function_variable(monitor.Entity, "talking", 0F, 0F);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(monitor.Entity, true);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
            object_cinematic_lod(brute_03.Entity, true);
            object_cinematic_lod(brute_04.Entity, true);
            object_hide(brute_01.Entity, true);
            object_hide(brute_02.Entity, true);
            object_hide(brute_03.Entity, true);
            object_hide(brute_04.Entity, true);
            object_create_anew(intra1_door);
            device_set_position_immediate(intra1_door.Entity, 1F);
            wake(new ScriptMethodReference(show_brutes));
            wake(new ScriptMethodReference(door_close));
            wake(new ScriptMethodReference(c08_intra1_sound_scene3_01));
            wake(new ScriptMethodReference(c08_intra1_foley_03));
            wake(new ScriptMethodReference(c08_2040_tar));
            wake(new ScriptMethodReference(cinematic_lighting_intra1_03));
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c08_intra1_03_cleanup()
        {
            object_destroy(tartarus.Entity);
            object_destroy(miranda.Entity);
            object_destroy(monitor.Entity);
            object_destroy_containing("brute");
            object_destroy(phantom_01.Entity);
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task c08_intra1_scene_03()
        {
            cinematic_lightmap_shadow_enable();
            await this.c08_intra1_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra1\\08_intra1", 3818062365U), "08_intra1_03", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3818848809U), "tartarus_03", false, anchor_intra1.Entity);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra1\\08_intra1", 3818979883U), "miranda_03", false, anchor_intra1.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra1\\08_intra1", 3821535826U), "monitor_03", false, anchor_intra1.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3818848809U), "brute01_03", false, anchor_intra1.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3818848809U), "brute02_03", false, anchor_intra1.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3818848809U), "brute03_03", false, anchor_intra1.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3818848809U), "brute04_03", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\08_intra1\\08_intra1", 3818652198U), "phantom01_03", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c08_intra1_03_cleanup();
            cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task c08_intra1()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp0"));
            await sleep(1);
            await this.c08_intra1_scene_01();
            await this.c08_intra1_scene_02();
            await this.c08_intra1_scene_03();
            cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task<bool> player_in_vehicle()
        {
            return unit_in_vehicle(unit(await this.player0())) || (bool)game_is_cooperative() && unit_in_vehicle(unit(await this.player1()));
        }

        [ScriptMethod(63, Lifecycle.Static)]
        public async Task<bool> players_in_vehicle()
        {
            return unit_in_vehicle(unit(await this.player0())) && !((bool)game_is_cooperative()) || unit_in_vehicle(unit(await this.player1()));
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task cinematic_intro()
        {
            if (await this.cinematic_skip_start())
            {
                await this.c08_intro();
            }

            await this.cinematic_skip_stop();
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task cinematic_outro()
        {
            if (await this.cinematic_skip_start())
            {
                await this.c08_intra1();
            }

            await this.cinematic_skip_stop();
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task objective0_set()
        {
            await sleep(30);
            print("new objective set: defend yourself from the brutes");
            objectives_show_up_to(0);
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task objective0_clear()
        {
            print("objective complete: defend yourself from the brutes");
            objectives_finish_up_to(0);
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task objective1_set()
        {
            await sleep(30);
            print("new objective set: exact vengeance on the traitor brutes");
            objectives_show_up_to(1);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task objective1_clear()
        {
            print("objective complete: exact vengeance on the traitor brutes");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task objective2_set()
        {
            await sleep(30);
            print("new objective set: continue to the canyon floor");
            objectives_show_up_to(2);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task objective2_clear()
        {
            print("objective complete: continue to the canyon floor");
            objectives_finish_up_to(2);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task objective3_set()
        {
            await sleep(30);
            print("new objective set: raze the brute encampment");
            objectives_show_up_to(3);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task music_08a_01_stop()
        {
            print("music 08a_01 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_01", 4195424222U));
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task music_08a_01_start_alt()
        {
            print("music 08a_01 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_01", 4195424222U), true);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task music_08a_01_start()
        {
            print("music 08a_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_01", 4195424222U), default(IGameObject), 1F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task music_08a_02_stop()
        {
            print("music 08a_02 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_02", 4195817444U));
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task music_08a_02_start()
        {
            print("music 08a_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_02", 4195817444U), default(IGameObject), 1F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task music_08a_03_stop()
        {
            print("music 08a_03 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_03", 4196014055U));
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task music_08a_03_start_alt()
        {
            print("music 08a_01 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_03", 4196014055U), true);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task music_08a_03_start()
        {
            print("music 08a_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_03", 4196014055U), default(IGameObject), 1F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task music_08a_04_start()
        {
            print("music 08a_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_04", 4196407277U), default(IGameObject), 1F);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task music_08a_05_start()
        {
            print("music 08a_05 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_05", 4196538351U), default(IGameObject), 1F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task chapter_title0()
        {
            await sleep(30);
            cinematic_set_title(title0);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task chapter_title1()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task chapter_title2()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task<bool> e10_player_dismounted()
        {
            return !(unit_in_vehicle(unit(await this.player0()))) || !(unit_in_vehicle(unit(await this.player1())));
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task<bool> e10_pro_inf_alerted()
        {
            return (short)ai_combat_status(e10_pro_inf0) >= this.ai_combat_status_certain || (short)ai_combat_status(e10_pro_inf1) >= this.ai_combat_status_certain;
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task<bool> e10_player_holding_launcher()
        {
            return unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher.weapon", 4105900699U));
        }

        [ScriptMethod(89, Lifecycle.Static)]
        public async Task<bool> e10_pro_phantom0_should_retreat()
        {
            return object_model_targets_destroyed(ai_vehicle_get(e10_pro_phantom0.phantom0), "target_front") >= 3 || object_get_health(ai_vehicle_get(e10_pro_phantom0.phantom0)) <= 0.05F;
        }

        [ScriptMethod(90, Lifecycle.CommandScript)]
        public async Task cs_e10_pro_phantom0_entry()
        {
            cs_fly_by(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p3"));
            cs_enable_targeting(true);
            if ((short)ai_spawn_count(e10_pro_ghosts0_1.Squad) > 0)
            {
                cs_fly_to(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p3_1"), 0.5F);
                await sleep(20);
                vehicle_unload(ai_vehicle_get(e10_pro_phantom0.phantom0), "phantom_sc");
                await sleep(40);
                cs_fly_by(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p3"));
            }

            cs_enable_moving(true);
            await sleep_until(async () => await this.e10_pro_phantom0_should_retreat(), 30, this.one_minute);
            cs_enable_moving(false);
            cs_enable_targeting(false);
            cs_fly_to(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p4"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(91, Lifecycle.CommandScript)]
        public async Task cs_e10_weapon_scene0()
        {
            cs_enable_pathfinding_failsafe(true);
            this.g_e10_weapon_scene0_actor = ai_get_unit(this.ai_current_actor);
            cs_go_to(GetReference<ISpatialPoint>("e10_armory/p0"));
            cs_look(true, GetReference<ISpatialPoint>("e10_armory/rocket_launchers"));
            await sleep(10);
            print("elite: what vulgar weapons");
            ai_play_line(this.ai_current_actor, "0500") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(30);
            cs_look_player(true);
            await sleep(45);
        }

        [ScriptMethod(92, Lifecycle.CommandScript)]
        public async Task cs_e10_weapon_scene1()
        {
            cs_look_object(true, ai_vehicle_get(e10_pro_phantom0.phantom0));
            await sleep(30);
            cs_look_player(true);
            await sleep(15);
            print("elite: perhaps i spoke too soon");
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0510"));
        }

        [ScriptMethod(93, Lifecycle.CommandScript)]
        public async Task cs_e10_pro_inf1_0_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e10_patrol/p0"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e10_patrol/f0"));
                await sleep((short)random_range(90, 120));
                cs_look(false, GetReference<ISpatialPoint>("e10_patrol/f0"));
                cs_enable_looking(true);
                cs_go_to(GetReference<ISpatialPoint>("e10_patrol/p1"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e10_patrol/f1"));
                await sleep((short)random_range(90, 120));
                cs_look(false, GetReference<ISpatialPoint>("e10_patrol/f1"));
                cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(94, Lifecycle.CommandScript)]
        public async Task cs_e10_pro_inf1_0_patrol1()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e10_patrol/p2"));
                cs_movement_mode(this.ai_movement_combat);
                cs_aim(true, GetReference<ISpatialPoint>("e10_patrol/s0"));
                cs_look(true, GetReference<ISpatialPoint>("e10_patrol/s0"));
                await sleep((short)random_range(30, 60));
                cs_shoot_point(true, GetReference<ISpatialPoint>("e10_patrol/s0"));
                await sleep((short)random_range(60, 150));
                cs_shoot_point(false, GetReference<ISpatialPoint>("e10_patrol/s0"));
                cs_look(false, GetReference<ISpatialPoint>("e10_patrol/s0"));
                cs_aim(false, GetReference<ISpatialPoint>("e10_patrol/s0"));
                cs_movement_mode(this.ai_movement_patrol);
                cs_go_to(GetReference<ISpatialPoint>("e10_patrol/p3"));
                cs_look(true, GetReference<ISpatialPoint>("e10_patrol/f1"));
                await sleep((short)random_range(90, 120));
                cs_look(false, GetReference<ISpatialPoint>("e10_patrol/f1"));
                return false;
            });
        }

        [ScriptMethod(95, Lifecycle.CommandScript)]
        public async Task cs_e10_pro_ghosts0_entry()
        {
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e10_pro_ghosts0/p0"));
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task e10_pod0_insertion()
        {
            ai_place(e10_cov_inf0.elite0);
            object_create(e10_pod0_inserter);
            objects_attach(e10_pod0_inserter.Entity, "pod_attach", ai_vehicle_get(e10_cov_inf0.elite0), "pod_attach");
            await sleep(1);
            device_set_position(e10_pod0_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e10_pod0_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e10_pod_impact_effect, ai_vehicle_get(e10_cov_inf0.elite0), "pod_attach");
            objects_detach(e10_pod0_inserter.Entity, ai_vehicle_get(e10_cov_inf0.elite0));
            object_destroy(e10_pod0_inserter.Entity);
            await sleep((short)random_range(20, 45));
            ai_vehicle_exit(e10_cov_inf0.elite0);
            await sleep(10);
            object_damage_damage_section(ai_vehicle_get(e10_cov_inf0.elite0), "door", 500F);
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task e10_pod1_insertion()
        {
            ai_place(e10_cov_inf0.elite1);
            object_create(e10_pod1_inserter);
            objects_attach(e10_pod1_inserter.Entity, "pod_attach", ai_vehicle_get(e10_cov_inf0.elite1), "pod_attach");
            await sleep(1);
            device_set_position(e10_pod1_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e10_pod1_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e10_pod_impact_effect, ai_vehicle_get(e10_cov_inf0.elite1), "pod_attach");
            objects_detach(e10_pod1_inserter.Entity, ai_vehicle_get(e10_cov_inf0.elite1));
            object_destroy(e10_pod1_inserter.Entity);
            await sleep((short)random_range(20, 45));
            ai_vehicle_exit(e10_cov_inf0.elite1);
            await sleep(10);
            object_damage_damage_section(ai_vehicle_get(e10_cov_inf0.elite1), "door", 500F);
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task e10_pod2_insertion()
        {
            ai_place(e10_cov_inf0.elite2);
            object_create(e10_pod2_inserter);
            objects_attach(e10_pod2_inserter.Entity, "pod_attach", ai_vehicle_get(e10_cov_inf0.elite2), "pod_attach");
            await sleep(1);
            device_set_position(e10_pod2_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e10_pod2_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e10_pod_impact_effect, ai_vehicle_get(e10_cov_inf0.elite2), "pod_attach");
            objects_detach(e10_pod2_inserter.Entity, ai_vehicle_get(e10_cov_inf0.elite2));
            object_destroy(e10_pod2_inserter.Entity);
            await sleep((short)random_range(20, 45));
            ai_vehicle_exit(e10_cov_inf0.elite2);
            await sleep(10);
            object_damage_damage_section(ai_vehicle_get(e10_cov_inf0.elite2), "door", 500F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task e10_pod3_insertion()
        {
            ai_place(e10_cov_inf0.elite3);
            object_create(e10_pod3_inserter);
            objects_attach(e10_pod3_inserter.Entity, "pod_attach", ai_vehicle_get(e10_cov_inf0.elite3), "pod_attach");
            await sleep(1);
            device_set_position(e10_pod3_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e10_pod3_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e10_pod_impact_effect, ai_vehicle_get(e10_cov_inf0.elite3), "pod_attach");
            objects_detach(e10_pod3_inserter.Entity, ai_vehicle_get(e10_cov_inf0.elite3));
            object_destroy(e10_pod3_inserter.Entity);
            await sleep((short)random_range(20, 45));
            ai_vehicle_exit(e10_cov_inf0.elite3);
            await sleep(10);
            object_damage_damage_section(ai_vehicle_get(e10_cov_inf0.elite3), "door", 500F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task e10_weapon_scene()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_armory, players()) && volume_test_objects(tv_e10_armory, ai_actors(e10_cov_inf0.Squad)));
            await sleep_until(async () => ai_scene("e10_weapon_scene0", new ScriptMethodReference(cs_e10_weapon_scene0), e10_cov_inf0.Squad), 15);
            await sleep_until(async () => !(volume_test_objects(tv_e10_armory, players())), 15);
            await sleep_until(async () => ai_scene("e10_weapon_scene1", new ScriptMethodReference(cs_e10_weapon_scene1), object_get_ai(this.g_e10_weapon_scene0_actor)), 15);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task e10_fallback_checkpoint0()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_armory, players()));
            game_save();
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task e10_pro_phantom0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_armory_entrance, players()) || volume_test_objects(tv_e10_second_half, players()), 15);
            game_save();
            ai_place(e10_pro_phantom0.Squad);
            cs_run_command_script(e10_pro_phantom0.phantom0, new ScriptMethodReference(cs_e10_pro_phantom0_entry));
            if ((short)ai_living_count(e10_pro_wraith0) <= 0)
            {
                ai_place_in_vehicle(e10_pro_ghosts0_1.Squad, e10_pro_phantom0.Squad);
            }
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task e10_pro_ghosts0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_pro_inf2_retreat0, players()), 15);
            ai_place(e10_pro_ghosts0_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e10_pro_inf2_retreat2, players()), 15);
            ai_place(e10_pro_ghosts0_0.Squad);
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task e10_pro_wraith0_main()
        {
            ai_place(e10_pro_wraith0);
            await sleep_until(async () => (short)ai_living_count(e10_pro_wraith0) <= 0, 15);
            game_save();
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task e10_pro_inf3_main()
        {
            ai_place(e10_pro_inf3.Squad, 1);
            await sleep_until(async () => volume_test_objects(tv_e10_bridge, players()), 15);
            ai_place(e10_pro_inf3.Squad);
            await sleep_until(async () => volume_test_objects(tv_e10_second_half, players()), 15);
            ai_place(e10_pro_inf3.Squad, (short)(2 - (float)ai_living_count(e10_pro_inf3.Squad)));
            ai_set_orders(e10_pro_inf3.Squad, e10_pro_inf3_retreat0);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task e10_pro_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_armory_entrance, players()) || volume_test_objects(tv_e10_second_half, players()), 15);
            await sleep_until(async () => (short)ai_living_count(e10_pro_wraith0_1.Squad) <= 0 || volume_test_objects(tv_e10_pro_inf2_retreat0, players()), 15);
            ai_place(e10_pro_inf2_0.Squad, (short)pin(7F - (float)ai_living_count(prophets), 2F, 4F));
            await sleep_until(async () => volume_test_objects(tv_e10_pro_inf2_retreat0, players()), 15);
            wake(new ScriptMethodReference(e10_fallback_checkpoint0));
            await sleep(60);
            ai_place(e10_pro_inf2_1.Squad, (short)pin(7F - (float)ai_living_count(prophets), 0F, 4F));
            await sleep_until(async () => volume_test_objects(tv_e10_near_exit, players()), 15);
            ai_place(e10_pro_inf2_1.Squad, (short)pin(7F - (float)ai_living_count(prophets), 0F, 4F));
            await sleep_until(async () => volume_test_objects(tv_e10_pro_inf2_retreat2, players()), 15);
            ai_place(e10_pro_inf2_1.Squad, (short)pin(7F - (float)ai_living_count(prophets), 0F, 4F));
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task e10_pro_inf1_main()
        {
            ai_place(e10_pro_inf1_0.Squad);
            await sleep_until(async () => await this.e10_pro_inf_alerted());
            await sleep_until(async () => volume_test_objects(tv_e10_inf1_1_init, players()), 15, 300);
            ai_place(e10_pro_inf1_1.Squad);
            await sleep_until(async () => volume_test_objects(tv_e10_inf1_2_init, players()), 15);
            if (await this.difficulty_normal())
            {
                this.g_e10_pro_inf1_2_count = 3;
            }

            await sleep_until(async () => (bool)game_safe_to_save() || volume_test_objects(tv_e10_pro_inf1_do_or_die, players()), 15);
            game_save();
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e10_pro_inf1) <= 2)
                {
                    game_save();
                    await sleep_until(async () => volume_test_objects(tv_e10_armory_entrance, players()), 15, 450);
                    ai_place(e10_pro_inf1_2.Squad, (short)pin(4F - (float)ai_living_count(e10_pro_inf1), 1F, this.g_e10_pro_inf1_2_count));
                    this.g_e10_pro_inf1_2_count = (short)(this.g_e10_pro_inf1_2_count - 1);
                }

                return this.g_e10_pro_inf1_2_count <= 0 || volume_test_objects(tv_e10_armory_entrance, players());
            }, 15);
            if (volume_test_objects(tv_e10_armory_entrance, players()))
            {
                ai_disposable(e10_pro_inf1, true);
            }

            await sleep_until(async () => (short)ai_living_count(e10_pro_inf1) <= 0);
            game_save();
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task e10_pro_inf0_main()
        {
            ai_place(e10_pro_inf0_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e10_armory_entrance, players()) || volume_test_objects(tv_e10_second_half, players()), 15);
            game_save();
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task e10_cov_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_bridge, players()), 15);
            await sleep_until(async () => (short)ai_living_count(e10_pro_wraith0_0.Squad) <= 0);
            wake(new ScriptMethodReference(e10_pod0_insertion));
            await sleep(30);
            wake(new ScriptMethodReference(e10_pod1_insertion));
            wake(new ScriptMethodReference(e10_weapon_scene));
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task e10_cov_ghosts0_main()
        {
            ai_migrate(e9_cov_ghosts0.Squad, e10_cov_ghosts0.Squad);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task e10_key()
        {
            if (!(await this.difficulty_legendary()))
            {
                sleep_forever();
            }

            object_create(key);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4119794543U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4119794543U)));
            ice_cream_flavor_stock(7);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task e10_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_main_begin, players()), 15);
            this.g_e10_started = true;
            print("e10_main");
            data_mine_set_mission_segment("e10_brute_camp");
            game_save();
            wake(new ScriptMethodReference(music_08a_04_start));
            wake(new ScriptMethodReference(chapter_title2));
            wake(new ScriptMethodReference(objective2_clear));
            wake(new ScriptMethodReference(objective3_set));
            wake(new ScriptMethodReference(e10_cov_ghosts0_main));
            wake(new ScriptMethodReference(e10_cov_inf0_main));
            wake(new ScriptMethodReference(e10_pro_inf0_main));
            wake(new ScriptMethodReference(e10_pro_inf1_main));
            wake(new ScriptMethodReference(e10_pro_inf2_main));
            wake(new ScriptMethodReference(e10_pro_inf3_main));
            wake(new ScriptMethodReference(e10_pro_ghosts0_main));
            wake(new ScriptMethodReference(e10_pro_wraith0_main));
            wake(new ScriptMethodReference(e10_key));
            await sleep_until(async () => volume_test_objects(tv_e10_exit_door, players()) && device_get_position(e10_exit_door.Entity) > 0F, 15);
        }

        [ScriptMethod(113, Lifecycle.Static)]
        public async Task test_brute_camp()
        {
            object_teleport(await this.player0(), e10_test);
            ai_place(e10_cov_ghosts0.Squad);
            if (!(this.g_e10_started))
            {
                wake(new ScriptMethodReference(e10_main));
            }

            ai_place(e9_pro_inf3.Squad);
        }

        [ScriptMethod(114, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_inf1_trap()
        {
            cs_enable_dialogue(true);
            cs_abort_on_damage(true);
            cs_face_object(true, e9_trap_target0.Entity);
            await sleep_until(async () => volume_test_objects(tv_e9_trap_trigger0, players()), 5);
            cs_face_object(false, e9_trap_target0.Entity);
            cs_shoot(true, e9_trap_target0.Entity);
            await sleep_until(async () => object_get_health(e9_trap_target0.Entity) <= 0F || volume_test_objects(tv_e9_trap_trigger1, players()), 2);
            cs_shoot(false, e9_trap_target0.Entity);
            await sleep_until(async () => volume_test_objects(tv_e9_trap_trigger1, players()), 5);
            cs_shoot(true, e9_trap_target1.Entity);
            await sleep_until(async () => object_get_health(e9_trap_target1.Entity) <= 0F, 2, 30);
            await sleep((short)random_range(20, 60));
        }

        [ScriptMethod(115, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_inf1_abort()
        {
            await sleep(1);
        }

        [ScriptMethod(116, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_phantom0_overflight()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e9_pro_phantom0/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e9_pro_phantom0/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("e9_pro_phantom0/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("e9_pro_phantom0/p3"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task e9_weather_control()
        {
            weather_stop(120F);
            await sleep_until(async () => volume_test_objects(tv_e9_first_drop, players()), 15);
            weather_stop(90F);
            await sleep_until(async () => volume_test_objects(tv_e9_trap_trigger1, players()), 15);
            weather_stop(60F);
            await sleep_until(async () => volume_test_objects(tv_e9_pro_inf3_begin, players()), 15);
            weather_stop(30F);
            await sleep_until(async () => volume_test_objects(tv_e10_entrance, players()), 15);
            weather_stop(15F);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task e9_pro_phantom0_main()
        {
            ai_place(e9_pro_phantom0.Squad);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task e9_pro_inf3_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_pro_inf3_begin, players()), 15);
            game_save();
            ai_place(e9_pro_inf3.Squad);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task e9_pro_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_first_drop, players()), 15);
            ai_place(e9_pro_inf2.Squad, (short)pin(10F - (float)ai_living_count(prophets), 2F, 4F));
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task e9_pro_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_first_drop, players()), 15);
            ai_place(e9_pro_inf1.Squad);
            cs_run_command_script(e9_pro_inf1.Squad, new ScriptMethodReference(cs_e9_pro_inf1_trap));
            await sleep_until(async () => volume_test_objects(tv_e9_trap_trigger0, players()), 5);
            await sleep_until(async () => (float)ai_strength(e9_pro_inf1.Squad) < 0.9F, 15, 300);
            cs_run_command_script(e9_pro_inf1.Squad, new ScriptMethodReference(cs_e9_pro_inf1_abort));
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task e9_pro_inf0_main()
        {
            ai_place(e9_pro_inf0_0.Squad, (short)pin(10F - (float)ai_living_count(prophets), 0F, 2F));
            ai_place(e9_pro_inf0_1.Squad, (short)pin(10F - (float)ai_living_count(prophets), 0F, 2F));
            await sleep_until(async () => volume_test_objects(tv_e9_trap_trigger0, players()) || (short)ai_living_count(e9_pro_inf0) <= 0, 5);
            game_save();
            await sleep_until(async () => volume_test_objects(tv_e9_trap_trigger0, players()), 5);
            ai_place(e9_pro_inf0_2.Squad, (short)pin(10F - (float)ai_living_count(prophets), 0F, 2F));
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task e9_cov_ghosts0_main()
        {
            ai_place(e9_cov_ghosts0.Squad);
            await sleep_until(async () => (short)ai_living_count(e8_pro_spectre0.Squad) <= 0 && (short)ai_living_count(e8_pro) <= 2);
            ai_migrate(e8_cov_inf0.Squad, e9_cov_ghosts0.Squad);
            ai_migrate(e8_cov_ghosts0.Squad, e9_cov_ghosts0.Squad);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task e9_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_main_begin, players()), 15);
            this.g_e9_started = true;
            print("e9_main");
            data_mine_set_mission_segment("e9_ski_run");
            game_save();
            wake(new ScriptMethodReference(music_08a_03_stop));
            wake(new ScriptMethodReference(e10_main));
            wake(new ScriptMethodReference(e9_cov_ghosts0_main));
            wake(new ScriptMethodReference(e9_pro_inf0_main));
            wake(new ScriptMethodReference(e9_pro_inf1_main));
            wake(new ScriptMethodReference(e9_pro_inf2_main));
            wake(new ScriptMethodReference(e9_pro_inf3_main));
            wake(new ScriptMethodReference(e9_pro_phantom0_main));
            wake(new ScriptMethodReference(e9_weather_control));
            await sleep_until(async () => this.g_e10_started);
            sleep_forever(new ScriptMethodReference(e9_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e9_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e9_pro_inf2_main));
            sleep_forever(new ScriptMethodReference(e9_pro_inf3_main));
            sleep_forever(new ScriptMethodReference(e9_pro_phantom0_main));
            ai_disposable(e9_pro, true);
            ai_disposable(e9_pro_phantom0.Squad, false);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task test_ski_run()
        {
            object_teleport(await this.player0(), e9_test);
            ai_place(e9_cov_ghosts0.Squad);
            if (!(this.g_e9_started))
            {
                wake(new ScriptMethodReference(e9_main));
            }
        }

        [ScriptMethod(126, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_inf0_init()
        {
            cs_enable_dialogue(true);
            cs_movement_mode(this.ai_movement_patrol);
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            cs_enable_looking(true);
            await sleep_until(async () => (bool)ai_trigger_test("generic_player_sighted", this.ai_current_squad), 10);
            cs_movement_mode(this.ai_movement_flee);
            cs_enable_moving(true);
            await sleep_until(async () => volume_test_objects(tv_e8_spectre_begin, players()), 15);
            await sleep_until(async () => (short)ai_spawn_count(e8_pro_spectre0.Squad) > 0 && (short)ai_living_count(e8_pro_spectre0.Squad) <= 1 || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 2F, 10, 450);
            await sleep((short)random_range(0, 45));
            cs_movement_mode(this.ai_movement_combat);
            ai_vehicle_enter(this.ai_current_actor, ai_vehicle_get_from_starting_location(e8_cov_inf0.turret0));
            ai_disregard(ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task e8_pro_spectre0_main()
        {
            await sleep(30);
            await sleep_until(async () => volume_test_objects(tv_e8_exit, players()) || (short)ai_living_count(e8_pro) <= 2, 15);
            ai_place(e8_pro_spectre0.Squad);
            await sleep(1);
            ai_vehicle_reserve_seat(ai_vehicle_get(e8_pro_spectre0.starting_locations_0), "spectre_p_l", true);
            wake(new ScriptMethodReference(music_08a_03_start_alt));
            await sleep_until(async () => (short)ai_living_count(e8_pro_spectre0.Squad) <= 0);
            wake(new ScriptMethodReference(music_08a_03_stop));
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task e8_pro_inf2_main()
        {
            ai_place(e8_pro_inf2.Squad);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task e8_pro_inf1_main()
        {
            ai_place(e8_pro_inf1_0.Squad);
            await sleep_until(async () => (short)ai_living_count(e8_pro_inf1) <= 0 || volume_test_objects(tv_e8_exit, players()));
            ai_place(e8_pro_inf1_1.Squad, (short)(4 - (float)ai_living_count(e8_pro_inf1)));
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task e8_pro_inf0_main()
        {
            ai_place(e8_pro_inf0.Squad);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task e8_cov_inf0_main()
        {
            ai_place(e8_cov_inf0.Squad, (short)pin(6F - (float)ai_living_count(covenant1), 4F, 6F));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e8_cov_inf0.ghost0), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e8_cov_inf0.ghost1), true);
            await sleep_until(async () => volume_test_objects(tv_e9_main_begin, players()), 15);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e8_cov_inf0.ghost0), false);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e8_cov_inf0.ghost1), false);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task e8_cov_ghosts0_main()
        {
            ai_migrate(e7_cov_ghosts0.Squad, e8_cov_ghosts0.Squad);
            ai_migrate(e7_cov_ghosts1.Squad, e8_cov_ghosts0.Squad);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task e8_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e8_main_begin, players()), 15);
            this.g_e8_started = true;
            print("e8_main");
            data_mine_set_mission_segment("e8_kidney1");
            game_save();
            weather_start(120F);
            wake(new ScriptMethodReference(e9_main));
            wake(new ScriptMethodReference(e8_cov_inf0_main));
            wake(new ScriptMethodReference(e8_cov_ghosts0_main));
            wake(new ScriptMethodReference(e8_pro_inf0_main));
            wake(new ScriptMethodReference(e8_pro_inf1_main));
            wake(new ScriptMethodReference(e8_pro_inf2_main));
            wake(new ScriptMethodReference(e8_pro_spectre0_main));
            await sleep_until(async () => this.g_e9_started);
            sleep_forever(new ScriptMethodReference(e8_cov_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e8_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e8_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e8_pro_inf2_main));
            sleep_forever(new ScriptMethodReference(e8_pro_spectre0_main));
            ai_disposable(e8_pro, true);
        }

        [ScriptMethod(134, Lifecycle.CommandScript)]
        public async Task cs_e7_cov_grunt0()
        {
            cs_movement_mode(this.ai_movement_patrol);
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            cs_enable_looking(true);
            await sleep_until(async () => (bool)ai_trigger_test("generic_player_sighted", this.ai_current_squad) || (short)ai_combat_status(e7_pro_inf0_0.Squad) >= this.ai_combat_status_active, 15);
            cs_enable_dialogue(true);
            cs_face_player(true);
            await sleep((short)random_range(25, 45));
            cs_movement_mode(this.ai_movement_flee);
            cs_face_player(false);
            cs_enable_looking(true);
            cs_go_to(GetReference<ISpatialPoint>("e7_patrol/p0_2"));
            await sleep_until(async () => !(vehicle_test_seat_list(ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), "c_turret_ap_d", ai_actors(e7_pro_inf0))) && !(volume_test_objects(tv_e7_grunts_unsafe, ai_actors(e7_pro_inf0))), 60);
            cs_movement_mode(this.ai_movement_combat);
            await sleep((short)random_range(25, 45));
            ai_disregard(ai_get_object(this.ai_current_actor), false);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), false);
            ai_vehicle_enter(this.ai_current_actor, ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0));
        }

        [ScriptMethod(135, Lifecycle.CommandScript)]
        public async Task cs_e7_cov_grunt1()
        {
            cs_movement_mode(this.ai_movement_patrol);
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            cs_enable_looking(true);
            await sleep_until(async () => (bool)ai_trigger_test("generic_player_sighted", this.ai_current_squad) || (short)ai_combat_status(e7_pro_inf0_0.Squad) >= this.ai_combat_status_active, 15);
            cs_enable_dialogue(true);
            cs_face_player(true);
            await sleep((short)random_range(25, 45));
            cs_movement_mode(this.ai_movement_flee);
            cs_face_player(false);
            cs_enable_looking(true);
            cs_go_to(GetReference<ISpatialPoint>("e7_patrol/p1_2"));
            await sleep_until(async () => !(vehicle_test_seat_list(ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), "c_turret_ap_d", ai_actors(e7_pro_inf0))) && !(volume_test_objects(tv_e7_grunts_unsafe, ai_actors(e7_pro_inf0))), 60);
            cs_movement_mode(this.ai_movement_combat);
            await sleep((short)random_range(25, 45));
            ai_disregard(ai_get_object(this.ai_current_actor), false);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost1), false);
            ai_vehicle_enter(this.ai_current_actor, ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost1));
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task e7_pro_inf2_main()
        {
            ai_place(e7_pro_inf2.Squad);
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task e7_pro_inf1_spawn()
        {
            await sleep_until(async () => !(volume_test_objects(tv_e7_pro_inf1_0_unsafe, players())), 10, 60);
            if (!(volume_test_objects(tv_e7_pro_inf1_0_unsafe, players())))
            {
                ai_place(e7_pro_inf1_0.Squad);
            }
            else if (!(volume_test_objects(tv_e7_end_section, players())))
            {
                ai_place(e7_pro_inf1_1.Squad);
            }
            else if (!(volume_test_objects(tv_e7_pro_inf1_2_unsafe, players())))
            {
                ai_place(e7_pro_inf1_2.Squad);
            }
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task e7_pro_inf1_main()
        {
            await sleep_until(async () => (short)ai_living_count(e7_pro_inf0) <= 1 || volume_test_objects(tv_e7_middle_section, players()), 15);
            ai_migrate(e7_pro_inf0, e7_pro_inf1_0.Squad);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e7_pro_inf) <= 2)
                {
                    await this.e7_pro_inf1_spawn();
                }

                return volume_test_objects(tv_e8_main_begin, players()) || (short)ai_spawn_count(e7_pro_inf1) >= 16;
            }, 15);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task e7_pro_inf0_main()
        {
            ai_place(e7_pro_inf0_0.Squad, (short)pin(10F - (float)ai_living_count(prophets), 1F, 3F));
            ai_place(e7_pro_inf0_1.Squad);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task e7_cov_ghosts1_main()
        {
            ai_place(e7_cov_ghosts1.Squad, (short)pin(4F - (float)ai_living_count(e7_cov_ghosts0.Squad), 2F, 4F));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost1), true);
            await sleep_until(async () => !(volume_test_objects(tv_e7_grunts_unsafe, ai_actors(e7_pro_inf0))), 60);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), false);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost1), false);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task e7_cov_ghosts0_main()
        {
            ai_migrate(e6_cov, e7_cov_ghosts0.Squad);
            wake(new ScriptMethodReference(e7_cov_ghosts1_main));
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task e7_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e7_main_begin0, players()) || volume_test_objects(tv_e7_main_begin1, players()), 15);
            this.g_e7_started = true;
            print("e7_main");
            data_mine_set_mission_segment("e7_kidney0");
            game_save();
            wake(new ScriptMethodReference(music_08a_03_start));
            wake(new ScriptMethodReference(e8_main));
            wake(new ScriptMethodReference(e7_cov_ghosts0_main));
            wake(new ScriptMethodReference(e7_pro_inf0_main));
            wake(new ScriptMethodReference(e7_pro_inf1_main));
            wake(new ScriptMethodReference(e7_pro_inf2_main));
            await sleep_until(async () => this.g_e8_started);
            sleep_forever(new ScriptMethodReference(e7_cov_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e7_cov_ghosts1_main));
            sleep_forever(new ScriptMethodReference(e7_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e7_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e7_pro_inf2_main));
            await sleep_until(async () => this.g_e8_started);
            ai_disposable(e7_pro, true);
        }

        [ScriptMethod(143, Lifecycle.Static)]
        public async Task test_kidney0()
        {
            object_teleport(await this.player0(), e7_test);
            if (!(this.g_e7_started))
            {
                wake(new ScriptMethodReference(e7_main));
            }

            await sleep(1);
            drop("objects\\vehicles\\ghost\\ghost");
        }

        [ScriptMethod(144, Lifecycle.CommandScript)]
        public async Task cs_e6_weapon_scene()
        {
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0480"));
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task e6_weapon_scene()
        {
            await sleep_until(async () => ai_scene("e6_weapon_scene", new ScriptMethodReference(cs_e6_weapon_scene), e6_cov) || (short)ai_living_count(e6_pro_inf1.Squad) <= 0, 15, this.two_minutes);
            await sleep_until(async () => ai_scene("e6_weapon_scene", new ScriptMethodReference(cs_e6_weapon_scene), e6_cov), 15, 300);
        }

        [ScriptMethod(146, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_phantom0_entry()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p0"));
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p0_1"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p1"), GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p2"), 1F);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p2"), 0.5F);
            await sleep_until(async () => (bool)ai_trigger_test("e6_player_exited_onto_ledge", e6_pro_inf1.Squad) || this.g_e7_started || volume_test_objects(tv_e6_ledge0, players()) || volume_test_objects(tv_e6_ledge1, players()), 15);
            object_set_phantom_power(ai_vehicle_get(this.ai_current_actor), true);
            await sleep(30);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_a");
            await sleep(100);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_b");
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get(this.ai_current_actor), false);
            this.g_e6_pro_inf1_arrived = true;
            wake(new ScriptMethodReference(e6_weapon_scene));
            cs_vehicle_speed(1F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p3"), GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p2"));
        }

        [ScriptMethod(147, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_phantom0_exit()
        {
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e6_pro_phantom0_exit/p0"), GetReference<ISpatialPoint>("e6_pro_phantom0_exit/p1"));
            cs_vehicle_boost(true);
            cs_fly_to(GetReference<ISpatialPoint>("e6_pro_phantom0_exit/p1"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(148, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_inf0_1_firing()
        {
            cs_abort_on_damage(true);
            cs_aim(true, GetReference<ISpatialPoint>("e6_pro_inf0_ambush/p0"));
            cs_crouch(true);
            await sleep_until(async () => device_get_position(e6_ghost_ledge_door.Entity) > 0F, 15);
            cs_enable_dialogue(true);
            await sleep(15);
            cs_aim(false, GetReference<ISpatialPoint>("e6_pro_inf0_ambush/p0"));
            cs_enable_targeting(true);
            await sleep_until(async () => volume_test_objects(tv_e6_on_ledge0, players()) || (float)ai_strength(this.ai_current_squad) < 0.95F, 10, 90);
            await sleep_until(async () => (float)ai_strength(this.ai_current_squad) < 0.95F, 10, 60);
        }

        [ScriptMethod(149, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_inf0_0_firing()
        {
            cs_abort_on_damage(true);
            cs_aim(true, GetReference<ISpatialPoint>("e6_pro_inf0_ambush/p0"));
            await sleep_until(async () => device_get_position(e6_ghost_ledge_door.Entity) > 0F, 15);
            cs_enable_dialogue(true);
            await sleep(15);
            cs_aim(false, GetReference<ISpatialPoint>("e6_pro_inf0_ambush/p0"));
            cs_enable_targeting(true);
            await sleep_until(async () => volume_test_objects(tv_e6_on_ledge0, players()) || (float)ai_strength(this.ai_current_squad) < 0.95F, 10, 90);
        }

        [ScriptMethod(150, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_inf1_entry()
        {
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e6_pro_inf1_entry/p0"));
            ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(151, Lifecycle.Static)]
        public async Task<bool> e6_pro_phantom0_should_retreat()
        {
            return object_model_targets_destroyed(ai_vehicle_get(e6_pro_phantom0.phantom0), "target_front") >= 3 || object_get_health(ai_vehicle_get(e6_pro_phantom0.phantom0)) <= 0.05F;
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task e6_objectives()
        {
            await sleep_until(async () => (short)ai_spawn_count(e6_pro_phantom0.Squad) > 0);
            await sleep_until(async () => await this.e6_pro_phantom0_should_retreat() || volume_test_objects(tv_e7_main_begin0, players()) || volume_test_objects(tv_e7_main_begin1, players()));
            wake(new ScriptMethodReference(objective1_clear));
            wake(new ScriptMethodReference(objective2_set));
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task e6_pro_phantom0_main()
        {
            await sleep_until(async () => device_get_position(e6_ghost_ledge_door.Entity) > 0F, 15);
            await sleep_until(async () => volume_test_objects(tv_e6_on_ledge0, players()), 15, 210);
            ai_place(e6_pro_phantom0.Squad);
            await sleep_until(async () => this.g_e6_pro_inf1_arrived);
            await sleep_until(async () => this.g_e7_started || object_model_targets_destroyed(ai_vehicle_get(e6_pro_phantom0.phantom0), "target_front") >= 3 || object_get_health(ai_vehicle_get(e6_pro_phantom0.phantom0)) <= 0.05F || this.g_e6_pro_inf1_arrived && (short)ai_living_count(e6_pro_inf1.Squad) <= 0);
            cs_run_command_script(e6_pro_phantom0.phantom0, new ScriptMethodReference(cs_e6_pro_phantom0_exit));
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task e6_pro_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_pro_inf1_begin, players()), 15);
            ai_place(e6_pro_inf1.Squad, (short)pin(6F - (float)ai_living_count(e6_pro_inf0), 2F, 6F));
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task e6_pro_inf0_main()
        {
            ai_place(e6_pro_inf0);
            await sleep(6);
            objects_predict(ai_actors(e6_pro_inf0));
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task e6_cov_ghosts0_main()
        {
            ai_place(e6_cov_ghosts0.Squad);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e6_cov_ghosts0.ghost0), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e6_cov_ghosts0.ghost2), true);
            await sleep_until(async () => this.g_e6_pro_inf1_arrived);
            await sleep_until(async () => (short)ai_living_count(e6_pro_inf0) <= 0 && (short)ai_living_count(e6_pro_inf1.Squad) <= 0 && (short)ai_spawn_count(e6_pro_inf1.Squad) > 0 || this.g_e7_started || await this.player_in_vehicle(), 30, this.two_minutes);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e6_cov_ghosts0.ghost0), false);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(e6_cov_ghosts0.ghost2), false);
            ai_migrate(e6_cov_inf0.Squad, e6_cov_ghosts0.Squad);
            ai_migrate(e6_cov_gold_elite.Squad, e6_cov_ghosts0.Squad);
            ai_enter_squad_vehicles(e6_cov_ghosts0.Squad);
            await sleep_until(async () => await this.player_in_vehicle());
            wake(new ScriptMethodReference(music_08a_03_start));
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task e6_cov_gold_elite_main()
        {
            ai_migrate(e5_cov_gold_elite.Squad, e6_cov_gold_elite.Squad);
            ai_teleport_to_starting_location_if_outside_bsp(e6_cov_gold_elite.Squad);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task e6_cov_inf1_main()
        {
            await sleep(1);
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task e6_cov_grunts0_main()
        {
            ai_migrate(e5_cov_grunts0.Squad, e6_cov_grunts0.Squad);
            ai_teleport_to_starting_location_if_outside_bsp(e6_cov_grunts0.Squad);
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task e6_cov_inf0_main()
        {
            ai_migrate(e5_cov_inf0.Squad, e6_cov_inf0.Squad);
            ai_teleport_to_starting_location_if_outside_bsp(e6_cov_inf0.Squad);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task e6_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_main_begin, players()) && (short)structure_bsp_index() == 0, 15);
            this.g_e6_started = true;
            print("e6_main");
            data_mine_set_mission_segment("e6_ghost_ledge");
            game_save();
            device_operates_automatically_set(e6_ghost_ledge_door.Entity, true);
            wake(new ScriptMethodReference(chapter_title1));
            wake(new ScriptMethodReference(e7_main));
            wake(new ScriptMethodReference(e6_cov_inf0_main));
            wake(new ScriptMethodReference(e6_cov_gold_elite_main));
            wake(new ScriptMethodReference(e6_cov_ghosts0_main));
            wake(new ScriptMethodReference(e6_cov_grunts0_main));
            wake(new ScriptMethodReference(e6_pro_inf0_main));
            wake(new ScriptMethodReference(e6_pro_inf1_main));
            await sleep_until(async () => this.g_e7_started);
            ai_disposable(e6_pro, true);
            ai_disposable(e6_pro_phantom0.Squad, false);
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task test_ghost_ledge()
        {
            object_teleport(await this.player0(), e6_test);
            ai_place(e6_cov_inf0.Squad);
            ai_place(e6_cov_gold_elite.Squad);
            if (!(this.g_e6_started))
            {
                wake(new ScriptMethodReference(e6_main));
            }
        }

        [ScriptMethod(163, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_gold_elite_creep()
        {
            cs_enable_dialogue(true);
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e5_cov_gold_elite_creep/p0"));
            cs_crouch(true);
            await sleep_until(async () => (short)ai_combat_status(e5_pro_inf0.Squad) >= this.ai_combat_status_dangerous);
            await sleep(60);
            cs_go_to(GetReference<ISpatialPoint>("e5_cov_gold_elite_creep/p1"));
            sleep_forever();
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_gold_elite_attack()
        {
            cs_crouch(false);
        }

        [ScriptMethod(165, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_grunts0_cower()
        {
            cs_movement_mode(this.ai_movement_flee);
            ai_disregard(this.ai_current_actor, true);
            await sleep_until(async () => (short)ai_living_count(e5_pro) < 3 || (float)ai_strength(e5_cov_grunts0.Squad) <= 0.8F || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 0.75F || this.g_e5_grunts_released >= 2, 15);
            this.g_e5_grunts_released = (short)(this.g_e5_grunts_released + 1);
            cs_enable_dialogue(true);
            cs_look_player(true);
            await sleep((short)random_range(15, 45));
            ai_disregard(this.ai_current_actor, false);
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task e5_pro_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_exit, players()) || (short)ai_living_count(e5_pro_inf0.Squad) <= 3 && (short)ai_spawn_count(e5_pro_inf0.Squad) > 0, 20);
            ai_place(e5_pro_inf1.Squad, (short)pin(10F - (float)ai_living_count(prophets), 1F, 4F));
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task e5_pro_inf0_main()
        {
            ai_place(e5_pro_inf0.Squad, (short)pin(10F - (float)ai_living_count(prophets), 2F, 6F));
            ai_vehicle_reserve(ai_vehicle_get(e5_pro_inf0.turret0), true);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task e5_cov_grunts0_main()
        {
            ai_place(e5_cov_grunts0.Squad, (short)pin(10F - (float)ai_living_count(covenant1) + (float)ai_living_count(prophets), 1F, 5F));
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task e5_cov_gold_elite_main()
        {
            ai_migrate(e4_cov_gold_elite.Squad, e5_cov_gold_elite.Squad);
            ai_renew(e5_cov_gold_elite.Squad);
            cs_run_command_script(e5_cov_gold_elite.Squad, new ScriptMethodReference(cs_e5_cov_gold_elite_creep));
            await sleep_until(async () => (float)ai_strength(e5_cov_gold_elite.Squad) < 1F || (float)ai_strength(e5_pro_inf0.Squad) < 0.5F || volume_test_objects(tv_e5_lower_level, players()), 5);
            cs_run_command_script(e5_cov_gold_elite.Squad, new ScriptMethodReference(cs_e5_cov_gold_elite_attack));
            ai_set_orders(e5_cov_gold_elite.Squad, e5_cov_gold_elite_killomatic);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task e5_cov_inf0_main()
        {
            ai_migrate(e4_cov_inf0.Squad, e5_cov_inf0.Squad);
            ai_renew(e5_cov_inf0.Squad);
            wake(new ScriptMethodReference(e5_cov_grunts0_main));
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task e5_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_main_begin, players()), 15);
            this.g_e5_started = true;
            print("e5_main");
            data_mine_set_mission_segment("e5_ramp_room1");
            game_save();
            wake(new ScriptMethodReference(e5_cov_inf0_main));
            wake(new ScriptMethodReference(e5_cov_gold_elite_main));
            wake(new ScriptMethodReference(e5_pro_inf0_main));
            wake(new ScriptMethodReference(e5_pro_inf1_main));
            await sleep_until(async () => this.g_e6_started);
            sleep_forever(new ScriptMethodReference(e5_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e5_cov_gold_elite_main));
            sleep_forever(new ScriptMethodReference(e5_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e5_pro_inf1_main));
            ai_disposable(e5_pro, true);
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task test_ramp_room2()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), e5_test);
            ai_place(e5_cov_inf0.Squad);
            ai_place(e5_cov_gold_elite.Squad);
            if (!(this.g_e5_started))
            {
                wake(new ScriptMethodReference(e5_main));
            }

            if (!(this.g_e6_started))
            {
                wake(new ScriptMethodReference(e6_main));
            }
        }

        [ScriptMethod(173, Lifecycle.CommandScript)]
        public async Task cs_e4_alarm_scene()
        {
            cs_switch("brute0");
            await sleep(ai_play_line(this.ai_current_actor, "0450"));
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e4_alarm_scene/p0"));
            await sleep(ai_play_line(this.ai_current_actor, "0400"));
            await sleep((short)((float)ai_play_line(this.ai_current_actor, "0440") - 30));
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task e4_pro_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_first_step, players()), 15);
            ai_place(e4_pro_inf2_0.Squad, (short)pin(10F - (float)ai_living_count(prophets), 1F, 4F));
            await sleep(150);
            await sleep_until(async () => ai_scene("e4_alarm_scene", new ScriptMethodReference(cs_e4_alarm_scene), e4_pro_inf0) || (short)ai_living_count(e4_pro_inf2_0.Squad) <= 0, 15);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task e4_pro_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_second_step, players()), 15);
            game_save();
            await sleep(15);
            ai_place(e4_pro_inf1.Squad, (short)pin(10F - (float)ai_living_count(prophets), 1F, 4F));
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task e4_pro_inf0_main()
        {
            ai_place(e4_pro_inf0_0.Squad, (short)pin(10F - (float)ai_living_count(prophets), 1F, 5F));
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task e4_cov_gold_elite_main()
        {
            ai_migrate(e3_cov_gold_elite.Squad, e4_cov_gold_elite.Squad);
            ai_renew(e4_cov_gold_elite.Squad);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task e4_cov_inf0_main()
        {
            ai_migrate(e3_cov_inf0.Squad, e4_cov_inf0.Squad);
            ai_renew(e4_cov_inf0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e4_first_step, players()), 15);
            await sleep_until(async () => volume_test_objects(tv_e4_ground_floor_exit, players()) || (short)ai_fighting_count(e4_pro) <= 2, 15);
            device_operates_automatically_set(e4_door0.Entity, true);
            ai_place(e4_cov_inf0.Squad, (short)pin(3F - (float)ai_living_count(covenant1), 1F, 3F));
            ai_set_orders(e4_cov_inf0.Squad, e4_cov_inf0_advance2);
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task e4_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_pre_main, players()), 15);
            game_save();
            await sleep_until(async () => volume_test_objects(tv_e4_main_begin, players()), 15);
            this.g_e4_started = true;
            print("e4_main");
            data_mine_set_mission_segment("e4_step_room");
            wake(new ScriptMethodReference(e5_main));
            wake(new ScriptMethodReference(e4_cov_inf0_main));
            wake(new ScriptMethodReference(e4_cov_gold_elite_main));
            wake(new ScriptMethodReference(e4_pro_inf0_main));
            wake(new ScriptMethodReference(e4_pro_inf1_main));
            wake(new ScriptMethodReference(e4_pro_inf2_main));
            await sleep_until(async () => this.g_e5_started);
            sleep_forever(new ScriptMethodReference(e4_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e4_cov_gold_elite_main));
            sleep_forever(new ScriptMethodReference(e4_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e4_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e4_pro_inf2_main));
            ai_disposable(e4_pro, true);
        }

        [ScriptMethod(180, Lifecycle.CommandScript)]
        public async Task cs_e3_alarm_scene()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e3_alarm_scene/p0"));
            await sleep(ai_play_line(this.ai_current_actor, "0410"));
            await sleep(ai_play_line(this.ai_current_actor, "0440"));
        }

        [ScriptMethod(181, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_grunts0_cower()
        {
            cs_movement_mode(this.ai_movement_flee);
            await sleep_until(async () => (bool)ai_trigger_test("generic_player_within_2wu", this.ai_current_squad) && !(volume_test_objects(tv_e3_lower_level, ai_actors(e3_pro_inf0))) || (float)ai_strength(this.ai_current_squad) <= 0.5F);
            cs_look_player(true);
            print("grunt scene");
            ai_play_line_at_player(this.ai_current_actor, "0460") // Couldn't generate cast from 'Short' to 'Void'
            ;
            sleep_forever();
        }

        [ScriptMethod(182, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_gold_elite_charge()
        {
            cs_enable_dialogue(true);
            cs_go_to(GetReference<ISpatialPoint>("e3_sword_elites/p0"));
            cs_go_to(GetReference<ISpatialPoint>("e3_sword_elites/p1"));
            cs_jump(10F, 4F);
        }

        [ScriptMethod(183, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_stealth_major_charge()
        {
            cs_enable_pathfinding_failsafe(true);
            ai_set_active_camo(this.ai_current_actor, true);
            cs_go_to(GetReference<ISpatialPoint>("e3_sword_elites/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e3_sword_elites/p3"));
            ai_set_active_camo(this.ai_current_actor, false);
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task e3_pro_inf1_main()
        {
            await sleep_until(async () => device_get_position(e3_exit_door.Entity) > 0F && volume_test_objects(tv_e3_near_exit, players()), 15);
            ai_place(e3_pro_inf1.Squad);
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task e3_pro_inf0_main()
        {
            await sleep(5);
            ai_place(e3_pro_inf0_0.Squad);
            ai_place(e3_pro_inf0_1.Squad, (short)pin(8F - (float)ai_living_count(prophets), 1F, 4F));
            await sleep_until(async () => ai_scene("e3_alarm_scene", new ScriptMethodReference(cs_e3_alarm_scene), e3_pro_inf0) || (short)ai_living_count(e3_pro_inf0) <= 0, 15);
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task e3_cov_grunts0_main()
        {
            ai_place(e3_cov_grunts0.Squad);
            ai_disregard(ai_actors(e3_cov_grunts0.Squad), true);
            cs_run_command_script(e3_cov_grunts0.Squad, new ScriptMethodReference(cs_e3_cov_grunts0_cower));
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task e3_cov_gold_elite_main()
        {
            ai_migrate(e2_cov_gold_elite.Squad, e3_cov_gold_elite.Squad);
            ai_renew(e3_cov_gold_elite.Squad);
            cs_run_command_script(e3_cov_gold_elite.Squad, new ScriptMethodReference(cs_e3_cov_gold_elite_charge));
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task e3_cov_inf0_main()
        {
            ai_migrate(e2_cov_inf0.Squad, e3_cov_inf0.Squad);
            ai_renew(e3_cov_inf0.Squad);
            cs_run_command_script(object_get_ai(this.g_cov_stealth_major), new ScriptMethodReference(cs_e3_cov_stealth_major_charge));
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task e3_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e3_main_begin, players()), 15);
            this.g_e3_started = true;
            print("e3_main");
            data_mine_set_mission_segment("e3_ramp_room0");
            game_save();
            wake(new ScriptMethodReference(e4_main));
            wake(new ScriptMethodReference(e3_cov_inf0_main));
            wake(new ScriptMethodReference(e3_cov_gold_elite_main));
            wake(new ScriptMethodReference(e3_cov_grunts0_main));
            wake(new ScriptMethodReference(e3_pro_inf0_main));
            wake(new ScriptMethodReference(e3_pro_inf1_main));
            await sleep_until(async () => this.g_e4_started);
            sleep_forever(new ScriptMethodReference(e3_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e3_cov_gold_elite_main));
            sleep_forever(new ScriptMethodReference(e3_cov_grunts0_main));
            sleep_forever(new ScriptMethodReference(e3_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e3_pro_inf1_main));
            ai_disposable(e3_pro, true);
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task test_ramp_room1()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), e3_test);
            ai_place(e3_cov_inf0.Squad);
            this.g_cov_stealth_major = ai_get_unit(e3_cov_inf0.stealth_major);
            ai_place(e3_cov_gold_elite.Squad);
            if (!(this.g_e3_started))
            {
                wake(new ScriptMethodReference(e3_main));
            }
        }

        [ScriptMethod(191, Lifecycle.CommandScript)]
        public async Task cs_e2_alarm_scene()
        {
            cs_switch("brute0");
            cs_enable_moving(true);
            cs_enable_targeting(true);
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0420"));
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0430"));
            cs_enable_dialogue(true);
            cs_switch("brute1");
            cs_enable_moving(false);
            cs_enable_targeting(true);
            cs_enable_pathfinding_failsafe(true);
            cs_start_to(GetReference<ISpatialPoint>("e2_alarm_scene/p0"));
            await sleep_until(async () => !((bool)cs_moving()) || object_get_health(e2_antennae.Entity) <= 0F, 5);
            cs_enable_targeting(false);
            if (object_get_health(e2_antennae.Entity) > 0F)
            {
                cs_face_object(true, e2_antennae.Entity);
                print("brute1 operates the antennae");
                await sleep_until(async () => object_get_health(e2_antennae.Entity) <= 0F, 5, 60);
                if (object_get_health(e2_antennae.Entity) > 0F)
                {
                    this.g_brute_alarm_level = (short)(this.g_brute_alarm_level + 1);
                }
                else
                {
                    print("brute1 growls");
                    await sleep(20);
                }
            }
            else
            {
                print("brute1 growls");
                await sleep(20);
            }
        }

        [ScriptMethod(192, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_grunts0_flee()
        {
            cs_enable_dialogue(true);
            cs_face_player(true);
            await sleep((short)random_range(0, 60));
            cs_face_player(false);
            cs_movement_mode(this.ai_movement_flee);
            await sleep_until(async () =>
            {
                begin_random(async () => ai_renew(this.ai_current_actor), 
                    async () => cs_start_to(GetReference<ISpatialPoint>("e2_cov_grunts_flee/p0")), 
                    async () => await sleep_until(async () => !((bool)cs_moving()) || object_get_health(ai_get_object(this.ai_current_actor)) < 1F || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => ai_renew(this.ai_current_actor), 
                    async () => cs_start_to(GetReference<ISpatialPoint>("e2_cov_grunts_flee/p1")), 
                    async () => await sleep_until(async () => !((bool)cs_moving()) || object_get_health(ai_get_object(this.ai_current_actor)) < 1F || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => ai_renew(this.ai_current_actor), 
                    async () => cs_start_to(GetReference<ISpatialPoint>("e2_cov_grunts_flee/p2")), 
                    async () => await sleep_until(async () => !((bool)cs_moving()) || object_get_health(ai_get_object(this.ai_current_actor)) < 1F || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => ai_renew(this.ai_current_actor), 
                    async () => cs_start_to(GetReference<ISpatialPoint>("e2_cov_grunts_flee/p3")), 
                    async () => await sleep_until(async () => !((bool)cs_moving()) || object_get_health(ai_get_object(this.ai_current_actor)) < 1F || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => ai_renew(this.ai_current_actor), 
                    async () => cs_start_to(GetReference<ISpatialPoint>("e2_cov_grunts_flee/p4")), 
                    async () => await sleep_until(async () => !((bool)cs_moving()) || object_get_health(ai_get_object(this.ai_current_actor)) < 1F || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => ai_renew(this.ai_current_actor), 
                    async () => cs_start_to(GetReference<ISpatialPoint>("e2_cov_grunts_flee/p5")), 
                    async () => await sleep_until(async () => !((bool)cs_moving()) || object_get_health(ai_get_object(this.ai_current_actor)) < 1F || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 1F, 5));
                return objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 1F;
            });
            ai_disregard(ai_get_object(this.ai_current_actor), false);
            ai_migrate(this.ai_current_actor, e2_cov_inf0.Squad);
        }

        [ScriptMethod(193, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_grunts0_abort()
        {
            if (objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 2F)
            {
                cs_crouch(true);
            }
            else
            {
                await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 4F);
            }
        }

        [ScriptMethod(194, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_gold_elite_charge0()
        {
            cs_enable_moving(true);
            cs_enable_looking(true);
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            cs_enable_moving(false);
            cs_enable_looking(false);
            ai_play_line(this.ai_current_actor, "0370") // Couldn't generate cast from 'Short' to 'Void'
            ;
            cs_go_to(GetReference<ISpatialPoint>("e2_sword_elites/p0"));
            cs_enable_dialogue(true);
            cs_start_to(GetReference<ISpatialPoint>("e2_sword_elites/p1"));
            await sleep_until(async () => !((bool)cs_moving()) || objects_distance_to_object(ai_actors(e2_pro_inf0.Squad), ai_get_object(this.ai_current_actor)) <= 2F);
        }

        [ScriptMethod(195, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_stealth_elite_charge0()
        {
            cs_enable_moving(true);
            cs_enable_looking(true);
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            cs_enable_moving(false);
            cs_enable_looking(false);
            ai_renew(this.ai_current_actor);
            ai_set_active_camo(this.ai_current_actor, true);
            cs_go_to(GetReference<ISpatialPoint>("e2_sword_elites/p2"));
            cs_crouch(true);
            cs_face(true, GetReference<ISpatialPoint>("e2_sword_elites/p1"));
            cs_start_to(GetReference<ISpatialPoint>("e2_sword_elites/p3"));
            await sleep_until(async () => objects_distance_to_object(ai_actors(e2_pro_inf0.Squad), ai_get_object(this.ai_current_actor)) <= 2F || (float)ai_strength(this.ai_current_actor) <= 0.75F || (short)ai_living_count(e2_pro_inf0.Squad) <= 1);
            ai_set_active_camo(this.ai_current_actor, false);
        }

        [ScriptMethod(196, Lifecycle.Static)]
        public async Task e2_cov_sword_elites_charge0()
        {
            cs_run_command_script(e2_cov_gold_elite.Squad, new ScriptMethodReference(cs_e2_cov_gold_elite_charge0));
            cs_run_command_script(object_get_ai(this.g_cov_stealth_major), new ScriptMethodReference(cs_e2_cov_stealth_elite_charge0));
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task e2_alarm_scene()
        {
            await sleep_until(async () => (short)ai_combat_status(e2_pro_inf0.Squad) >= this.ai_combat_status_visible, 15);
            await sleep_until(async () => ai_scene("e2_alarm_scene", new ScriptMethodReference(cs_e2_alarm_scene), e2_pro_inf0.Squad), 15, 300);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task e2_pro_inf3_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e2_pro_inf1.Squad) > 0 && (short)ai_living_count(e2_pro_inf1.Squad) <= 0 || volume_test_objects(tv_e2_pro_inf3_begin, players()));
            ai_place(e2_pro_inf3.Squad, (short)pin(9F - (float)ai_living_count(prophets), 2F, 6F));
            await sleep_until(async () => (short)ai_living_count(e2_pro_inf3.Squad) <= 0 && (bool)game_safe_to_save());
            game_save();
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task e2_pro_inf2_main()
        {
            await sleep_until(async () => (short)ai_living_count(e2_pro_inf0.Squad) <= 2 || volume_test_objects(tv_e2_pro_inf1_begin, players()));
            ai_place(e2_pro_inf2.Squad);
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task e2_pro_inf1_main()
        {
            await sleep_until(async () => (short)ai_living_count(e2_pro_inf0.Squad) <= 0 || volume_test_objects(tv_e2_pro_inf1_begin, players()));
            game_save();
            await sleep(15);
            ai_place(e2_pro_inf1.Squad, (short)pin(6F - (float)ai_living_count(e2_pro_inf0.Squad), 0F, 4F));
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task e2_pro_inf0_main()
        {
            ai_place(e2_pro_inf0.Squad);
            wake(new ScriptMethodReference(e2_alarm_scene));
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task e2_cov_grunts0_main()
        {
            ai_place(e2_cov_grunts0.Squad);
            ai_disregard(ai_actors(e2_cov_grunts0.Squad), true);
            await sleep_until(async () => (bool)ai_trigger_test("generic_player_sighted", e2_cov_grunts0.Squad), 5);
            await sleep(ai_play_line_at_player(e2_cov_grunts0.grunt0, "0330"));
            cs_run_command_script(e2_cov_grunts0.Squad, new ScriptMethodReference(cs_e2_cov_grunts0_flee));
            await sleep(300);
            await sleep_until(async () => (short)ai_living_count(e2_pro) <= 4 && (short)ai_fighting_count(e2_pro) <= 0);
            cs_run_command_script(e2_cov_grunts0.Squad, new ScriptMethodReference(cs_e2_cov_grunts0_abort));
            ai_disregard(ai_actors(e2_cov_grunts0.Squad), false);
            ai_migrate(e2_cov_grunts0.Squad, e2_cov_inf0.Squad);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task e2_cov_gold_elite_main()
        {
            await sleep_until(async () => this.g_e2_safe_to_migrate_inf2);
            ai_migrate(e1_cov_inf2.gold_elite, e2_cov_gold_elite.Squad);
            ai_migrate(e1_cov_inf2.Squad, e2_cov_inf0.Squad);
            await sleep(5);
            ai_teleport_to_starting_location_if_outside_bsp(e2_cov_inf0.Squad);
            ai_teleport_to_starting_location_if_outside_bsp(e2_cov_gold_elite.Squad);
            ai_renew(e2_cov_gold_elite.Squad);
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task e2_cov_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e2_pro_inf1_begin, players()), 15);
            wake(new ScriptMethodReference(music_08a_02_stop));
            await sleep_until(async () => (short)ai_living_count(e2_cov) <= 1);
            await sleep_until(async () => !(volume_test_objects(tv_e2_cov_inf1_unsafe, players())), 15);
            ai_place(e2_cov_inf1.Squad);
            ai_migrate(e2_cov_inf1.Squad, e2_cov_inf0.Squad);
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task e2_cov_inf0_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_inf1.Squad) > 0);
            ai_migrate(e1_cov_inf1.Squad, e2_cov_inf0.Squad);
            await sleep_until(async () => (short)structure_bsp_index() == 1, 15);
            ai_teleport_to_starting_location_if_outside_bsp(e2_cov_inf0.Squad);
            ai_renew(e2_cov_inf0.Squad);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task e2_main()
        {
            await sleep_until(async () => (short)structure_bsp_index() == 1, 15);
            this.g_e2_started = true;
            print("e2_main");
            data_mine_set_mission_segment("e2_cylinder_room");
            game_save();
            wake(new ScriptMethodReference(music_08a_01_stop));
            wake(new ScriptMethodReference(music_08a_02_start));
            wake(new ScriptMethodReference(e3_main));
            wake(new ScriptMethodReference(e2_cov_inf0_main));
            wake(new ScriptMethodReference(e2_cov_inf1_main));
            wake(new ScriptMethodReference(e2_cov_gold_elite_main));
            wake(new ScriptMethodReference(e2_cov_grunts0_main));
            wake(new ScriptMethodReference(e2_pro_inf0_main));
            wake(new ScriptMethodReference(e2_pro_inf1_main));
            wake(new ScriptMethodReference(e2_pro_inf2_main));
            wake(new ScriptMethodReference(e2_pro_inf3_main));
            await sleep_until(async () => volume_test_objects(tv_e2_main_end, players()), 15);
            sleep_forever(new ScriptMethodReference(e2_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e2_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e2_cov_gold_elite_main));
            sleep_forever(new ScriptMethodReference(e2_cov_grunts0_main));
            sleep_forever(new ScriptMethodReference(e2_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e2_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e2_pro_inf2_main));
            sleep_forever(new ScriptMethodReference(e2_pro_inf3_main));
            ai_disposable(e2_pro, true);
        }

        [ScriptMethod(207, Lifecycle.Static)]
        public async Task test_cylinder_room()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), e2_test);
            ai_place(e2_cov_inf0.Squad);
            this.g_cov_stealth_major = ai_get_unit(e2_cov_inf0.stealth_major);
            ai_place(e2_cov_gold_elite.Squad);
            if (!(this.g_e2_started))
            {
                wake(new ScriptMethodReference(e2_main));
            }
        }

        [ScriptMethod(208, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_inf0_0_patrol0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_uninspected);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p0"));
            cs_aim_object(true, e1_elite0.Entity);
            ai_play_line_at_player(this.ai_current_actor, "0230") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(15);
            cs_aim_object(false, e1_elite0.Entity);
            cs_shoot(true, e1_elite0.Entity);
            await sleep(30);
            cs_shoot(false, e1_elite0.Entity);
            await sleep((short)random_range(30, 60));
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p1"));
            cs_aim_object(true, e1_elite1.Entity);
            await sleep((short)random_range(60, 90));
            cs_aim_object(false, e1_elite1.Entity);
            cs_shoot(true, e1_elite1.Entity);
            await sleep(30);
            cs_shoot(false, e1_elite1.Entity);
            await sleep((short)random_range(30, 60));
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p2"));
            cs_look(true, GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p2_look0"));
            await sleep((short)random_range(45, 75));
            cs_look(true, GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p2_look1"));
            await sleep((short)random_range(60, 90));
            cs_look(false, GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p2_look1"));
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p3"));
            cs_face(true, GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p3_look0"));
            await sleep((short)random_range(210, 300));
            cs_face(true, GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p3_look1"));
        }

        [ScriptMethod(209, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_inf0_1_patrol0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_uninspected);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p0"));
            await sleep(30);
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 4009430235U), "patrol:any:any:posing:var1", true);
            await sleep(ai_play_line(this.ai_current_actor, "0240"));
            await sleep(25);
            ai_play_line(e1_pro_inf0_1_1.brute0, "0250") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep((short)random_range(90, 120));
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1"));
            cs_aim_object(true, e1_elite2.Entity);
            await sleep((short)random_range(60, 90));
            cs_aim_object(false, e1_elite2.Entity);
            cs_shoot(true, e1_elite2.Entity);
            await sleep(30);
            cs_shoot(false, e1_elite2.Entity);
            await sleep((short)random_range(30, 60));
            if ((short)ai_living_count(e1_pro_inf0_0.Squad) > 0)
            {
                await sleep(ai_play_line(e1_pro_inf0_0.brute0, "0260"));
                ai_play_line(e1_pro_inf0_1.brute0, "0270") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }

            cs_face(true, GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1_look0"));
            await sleep((short)random_range(60, 90));
            cs_face(false, GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1_look0"));
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p2"));
                cs_face(true, GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p2_look0"));
                await sleep((short)random_range(210, 300));
                cs_face(false, GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p2_look0"));
                cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1"));
                cs_face(true, GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1_look0"));
                await sleep((short)random_range(210, 300));
                cs_face(false, GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1_look0"));
                return false;
            });
        }

        [ScriptMethod(210, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_inf0_1_patrol1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_uninspected);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_2_patrol/p0"));
            cs_aim_object(true, e1_elite3.Entity);
            await sleep((short)random_range(60, 90));
            cs_aim_object(false, e1_elite3.Entity);
            cs_shoot(true, e1_elite3.Entity);
            await sleep(30);
            cs_shoot(false, e1_elite3.Entity);
            await sleep((short)random_range(30, 60));
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_inf0_2_patrol/p1"));
            cs_aim_object(true, e1_elite4.Entity);
            await sleep((short)random_range(60, 90));
            cs_aim_object(false, e1_elite4.Entity);
            cs_shoot(true, e1_elite4.Entity);
            await sleep(30);
            cs_shoot(false, e1_elite4.Entity);
            await sleep((short)random_range(30, 60));
            cs_aim_object(true, e1_elite5.Entity);
            await sleep((short)random_range(90, 120));
            cs_aim_object(false, e1_elite4.Entity);
            cs_shoot(true, e1_elite4.Entity);
            await sleep(30);
            cs_shoot(false, e1_elite4.Entity);
            await sleep((short)random_range(30, 60));
        }

        [ScriptMethod(211, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_scene()
        {
            custom_animation_loop(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3955165582U), "combat:unarmed:mortal_wound", false);
            unit_set_maximum_vitality(ai_get_unit(this.ai_current_actor), 5F, 0F);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 3F);
            cs_look_player(true);
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0200"));
            await sleep(45);
            this.g_e1_cov_inf0_should_die = true;
            unit_stop_custom_animation(ai_get_unit(this.ai_current_actor));
            sleep_forever();
        }

        [ScriptMethod(212, Lifecycle.CommandScript)]
        public async Task cs_e1_stealth_major_scene()
        {
            ai_set_active_camo(this.ai_current_actor, false);
            cs_go_to(GetReference<ISpatialPoint>("e1_watch_pods/p1"));
            if (objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 5F)
            {
                cs_look_player(true);
            }
            else
            {
                cs_look(true, GetReference<ISpatialPoint>("e1_zealot/p1"));
            }

            print("stealth: by the prophets...");
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3955165582U), "combat:sword:posing:var1", true);
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0300"));
            await sleep(20);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 5F, 10, 450);
            cs_face_player(true);
            await sleep(30);
            await sleep_until(async () => objects_can_see_object(ai_get_object(this.ai_current_actor), await this.player0(), 10F) || (bool)game_is_cooperative() && objects_can_see_object(ai_get_object(this.ai_current_actor), await this.player1(), 10F), 1, 30);
            print("stealth: they have shed our brother's blood...");
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3955165582U), "combat:sword:posing:var4", true);
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0310"));
            wake(new ScriptMethodReference(music_08a_02_start));
            this.g_e1_stealth_major_done = true;
            sleep_forever();
        }

        [ScriptMethod(213, Lifecycle.CommandScript)]
        public async Task cs_e1_watch_pods()
        {
            await sleep(15);
            cs_go_to_nearest(GetReference<ISpatialPoint>("e1_watch_pods/p0"));
            cs_look_object(true, ai_vehicle_get(e1_cov_inf2.gold_elite));
            cs_face_object(true, ai_vehicle_get(e1_cov_inf2.gold_elite));
            await sleep_until(async () => this.g_e1_zealot_revealed, 10);
            print("stealth: a zealot? so much for stealth...");
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0320"));
        }

        [ScriptMethod(214, Lifecycle.CommandScript)]
        public async Task cs_e1_zealot_intro()
        {
            cs_look(true, GetReference<ISpatialPoint>("e1_zealot/p0"));
            await sleep(25);
            ai_play_line(this.ai_current_actor, "0330") // Couldn't generate cast from 'Short' to 'Void'
            ;
            print("zealot: over so soon? bah");
            cs_look(true, GetReference<ISpatialPoint>("e1_zealot/p1"));
            await sleep(30);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task e1_pod0_insertion()
        {
            ai_place(e1_cov_inf2.gold_elite);
            object_create(e1_pod0_inserter);
            objects_attach(e1_pod0_inserter.Entity, "pod_attach", ai_vehicle_get(e1_cov_inf2.gold_elite), "pod_attach");
            await sleep(1);
            device_set_position(e1_pod0_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e1_pod0_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e1_pod_impact_effect, ai_vehicle_get(e1_cov_inf2.gold_elite), "pod_attach");
            objects_detach(e1_pod0_inserter.Entity, ai_vehicle_get(e1_cov_inf2.gold_elite));
            object_destroy(e1_pod0_inserter.Entity);
            await sleep((short)random_range(20, 45));
            this.g_e1_zealot_revealed = true;
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            ai_vehicle_exit(e1_cov_inf2.gold_elite);
            await sleep(10);
            object_damage_damage_section(ai_vehicle_get(e1_cov_inf2.gold_elite), "door", 500F);
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task e1_pod1_insertion()
        {
            ai_place(e1_cov_inf2.elite1);
            object_create(e1_pod1_inserter);
            objects_attach(e1_pod1_inserter.Entity, "pod_attach", ai_vehicle_get(e1_cov_inf2.elite1), "pod_attach");
            await sleep(1);
            device_set_position(e1_pod1_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e1_pod1_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e1_pod_impact_effect, ai_vehicle_get(e1_cov_inf2.elite1), "pod_attach");
            objects_detach(e1_pod1_inserter.Entity, ai_vehicle_get(e1_cov_inf2.elite1));
            object_destroy(e1_pod1_inserter.Entity);
            await sleep((short)random_range(20, 45));
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            ai_vehicle_exit(e1_cov_inf2.elite1);
            await sleep(10);
            object_damage_damage_section(ai_vehicle_get(e1_cov_inf2.elite1), "door", 500F);
        }

        [ScriptMethod(217, Lifecycle.Dormant)]
        public async Task e1_pod2_insertion()
        {
            ai_place(e1_cov_inf2.elite2);
            object_create(e1_pod2_inserter);
            objects_attach(e1_pod2_inserter.Entity, "pod_attach", ai_vehicle_get(e1_cov_inf2.elite2), "pod_attach");
            await sleep(1);
            device_set_position(e1_pod2_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e1_pod2_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e1_pod_impact_effect, ai_vehicle_get(e1_cov_inf2.elite2), "pod_attach");
            objects_detach(e1_pod2_inserter.Entity, ai_vehicle_get(e1_cov_inf2.elite2));
            object_destroy(e1_pod2_inserter.Entity);
            await sleep((short)random_range(20, 45));
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            ai_vehicle_exit(e1_cov_inf2.elite2);
            await sleep(10);
            object_damage_damage_section(ai_vehicle_get(e1_cov_inf2.elite2), "door", 500F);
            await sleep(30);
            this.g_e2_safe_to_migrate_inf2 = true;
        }

        [ScriptMethod(218, Lifecycle.Dormant)]
        public async Task e1_objectives()
        {
            await sleep(150);
            await sleep_until(async () => (short)ai_living_count(e1_cov_inf0.Squad) <= 0 || (short)ai_combat_status(e1_pro) > this.ai_combat_status_active, 30, this.one_minute);
            wake(new ScriptMethodReference(objective0_set));
            await sleep_until(async () => (short)ai_living_count(e1_cov_inf2.Squad) > 0, 15);
            await sleep(150);
            wake(new ScriptMethodReference(objective0_clear));
            wake(new ScriptMethodReference(objective1_set));
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task e1_guns_aux()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_area_entrance, players()), 15);
            object_create(e1_gun4);
            await sleep(1);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun4"), 0, true);
            await sleep(10);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun4"), 0, false);
            await sleep(1);
            object_destroy(e1_gun4.Entity);
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task e1_guns()
        {
            wake(new ScriptMethodReference(e1_guns_aux));
            object_create(e1_gun0);
            object_create(e1_gun1);
            await sleep(1);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun0"), 0, true);
            await sleep(5);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun0"), 0, false);
            object_destroy(e1_gun0.Entity);
            await sleep(15);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun1"), 0, true);
            await sleep(5);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun1"), 0, false);
            await sleep(1);
            object_destroy(e1_gun1.Entity);
            await sleep(90);
            object_create(e1_gun2);
            await sleep(1);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun2"), 0, true);
            await sleep(15);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun2"), 0, false);
            await sleep(1);
            object_destroy(e1_gun2.Entity);
            await sleep(60);
            object_create(e1_gun3);
            await sleep(1);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun3"), 0, true);
            await sleep(30);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun3"), 0, false);
            await sleep(90);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun3"), 0, true);
            await sleep(20);
            weapon_hold_trigger(GetReference<IWeaponReference>("e1_gun3"), 0, false);
            await sleep(1);
            object_destroy(e1_gun3.Entity);
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task e1_music_aux()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_third_wall, players()), 15);
            wake(new ScriptMethodReference(music_08a_01_start_alt));
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task e1_pro_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_second_wall, players()), 15);
            wake(new ScriptMethodReference(e1_music_aux));
            ai_place(e1_pro_inf1.Squad);
            await sleep_until(async () => (short)ai_combat_status(e1_pro_inf1.Squad) >= this.ai_combat_status_clear_los || (short)ai_living_count(e1_pro_inf1.Squad) <= 0, 30, this._30_seconds);
            print("alerted");
            if ((short)ai_combat_status(e1_pro_inf1.Squad) >= this.ai_combat_status_clear_los)
            {
                this.g_e1_pro_inf1_was_alerted = true;
            }

            await sleep_until(async () => (short)ai_combat_status(e1_pro_inf1.Squad) <= this.ai_combat_status_active, 10);
            await sleep_until(async () => (short)ai_combat_status(e1_pro_inf1.Squad) <= this.ai_combat_status_alert, 10, 240);
            print("alerted");
            if ((short)ai_living_count(e1_pro_inf1.Squad) > 0 && (short)ai_living_count(e1_pro_inf0) > 0)
            {
                if (this.g_e1_pro_inf1_was_alerted)
                {
                    print("cpn: he's just an elite--kill him!");
                    ai_play_line(e1_pro_inf1.brute0, "0290") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                    await sleep(20);
                    custom_animation(ai_get_unit(e1_pro_inf1.brute0), GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 4009430235U), "combat:support:hold", true);
                    await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                }
                else
                {
                    ai_play_line(e1_pro_inf1.brute0, "0280") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                }

                await sleep(30);
                ai_set_orders(e1_pro_inf0, e1_pro_inf0_search);
                this.g_e1_pro_inf0_searching = true;
            }
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task e1_pro_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_pro_inf0_begin, players()), 15);
            ai_place(e1_pro_inf0_0.Squad);
            ai_place(e1_pro_inf0_1.Squad);
            ai_place(e1_pro_inf0_1_1.Squad);
            cs_run_command_script(e1_pro_inf0_0.Squad, new ScriptMethodReference(cs_e1_pro_inf0_0_patrol0));
            cs_run_command_script(e1_pro_inf0_1.brute0, new ScriptMethodReference(cs_e1_pro_inf0_1_patrol0));
            cs_run_command_script(e1_pro_inf0_1_1.brute0, new ScriptMethodReference(cs_e1_pro_inf0_1_patrol1));
            await sleep_until(async () => (short)ai_living_count(e1_pro_inf0) <= 0 || volume_test_objects(tv_e1_second_wall, players()), 15);
            await sleep(15);
            ai_place(e1_pro_inf0_2.Squad);
            ai_place(e1_pro_inf0_3.Squad);
            await sleep_until(async () => (short)ai_living_count(e1_pro_inf0) <= 0, 15);
            game_save();
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task e1_cov_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_exit, players()), 15);
            await sleep_until(async () => this.g_e1_stealth_major_done || (short)ai_spawn_count(e1_cov_inf1.Squad) > 0 && (short)ai_living_count(e1_cov_inf1.Squad) <= 0);
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            wake(new ScriptMethodReference(e1_pod0_insertion));
            await sleep(60);
            wake(new ScriptMethodReference(e1_pod1_insertion));
            await sleep(15);
            wake(new ScriptMethodReference(e1_pod2_insertion));
            await sleep_until(async () => !(unit_in_vehicle(ai_get_unit(e1_cov_inf2.gold_elite))), 15);
            await sleep(15);
            if ((short)ai_living_count(e1_pro) <= 0)
            {
                cs_run_command_script(e1_cov_inf2.gold_elite, new ScriptMethodReference(cs_e1_zealot_intro));
            }

            await sleep_until(async () => volume_test_objects(tv_e1_exit, ai_get_object(e1_cov_inf2.gold_elite)), 15);
            if (volume_test_objects(tv_e1_ledge, players()))
            {
                print("zlt: there are brutes to kill!");
                ai_play_line(e1_cov_inf2.gold_elite, "0340") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
            else
            {
                print("zlt: wait up!");
                ai_play_line(e1_cov_inf2.gold_elite, "0350") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task e1_cov_inf1_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e1_pro_inf1.Squad) > 0 && (short)ai_living_count(e1_pro_inf0) <= 0 || volume_test_objects(tv_e1_exit, players()), 15);
            ai_place(e1_cov_inf1.Squad);
            this.g_cov_stealth_major = ai_get_unit(e1_cov_inf1.stealth_major);
            await sleep_until(async () => ai_scene("e1_stealth_major_scene", new ScriptMethodReference(cs_e1_stealth_major_scene), e1_cov_inf1.Squad) || (short)ai_spawn_count(e1_cov_inf2.Squad) > 0, 10);
            await sleep_until(async () => (short)ai_living_count(e1_pro) <= 0 && (short)ai_spawn_count(e1_cov_inf2.Squad) > 0, 5);
            cs_run_command_script(e1_cov_inf1.Squad, new ScriptMethodReference(cs_e1_watch_pods));
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task e1_cov_inf0_main()
        {
            ai_place(e1_cov_inf0.Squad);
            ai_disregard(ai_actors(e1_cov_inf0.Squad), true);
            this.g_e1_wounded_elite = ai_get_unit(e1_cov_inf0.Squad);
            unit_kill(this.g_e1_wounded_elite);
            await sleep(13);
            biped_ragdoll(this.g_e1_wounded_elite);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3904243520U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3904243520U)), 10, this.one_minute);
            await sleep(20);
            print("corpse: the brutes...");
            await sleep(ai_play_line_on_object(this.g_e1_wounded_elite, "0200"));
            await sleep(30);
            game_save();
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task e1_main()
        {
            this.g_e1_started = true;
            print("e1_main");
            data_mine_set_mission_segment("e1_stealthy_insertion");
            wake(new ScriptMethodReference(e2_main));
            wake(new ScriptMethodReference(e1_cov_inf0_main));
            wake(new ScriptMethodReference(e1_cov_inf1_main));
            wake(new ScriptMethodReference(e1_cov_inf2_main));
            wake(new ScriptMethodReference(e1_pro_inf0_main));
            wake(new ScriptMethodReference(e1_pro_inf1_main));
            wake(new ScriptMethodReference(e1_objectives));
            wake(new ScriptMethodReference(e1_guns));
            await sleep_until(async () => this.g_e2_started);
            ai_disposable(e1_pro, true);
            await sleep_until(async () => this.g_e3_started);
            sleep_forever(new ScriptMethodReference(e1_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e1_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e1_cov_inf2_main));
            sleep_forever(new ScriptMethodReference(e1_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e1_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e1_objectives));
            sleep_forever(new ScriptMethodReference(e1_guns));
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            sound_class_set_gain("amb", 1F, 5);
            wake(new ScriptMethodReference(music_08a_01_start));
            await sleep(2);
            object_cannot_take_damage(players());
            object_hide(await this.player0(), true);
            object_hide(await this.player1(), true);
            await this.cinematic_snap_to_white();
            await this.cinematic_intro();
            object_teleport(await this.player0(), player0_start);
            object_teleport(await this.player1(), player1_start);
            object_hide(await this.player0(), false);
            object_hide(await this.player1(), false);
            object_can_take_damage(players());
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(chapter_title0));
            wake(new ScriptMethodReference(e1_main));
            wake(new ScriptMethodReference(e6_main));
            await sleep_until(async () => volume_test_objects(tv_mission_end, players()), 15);
            wake(new ScriptMethodReference(music_08a_05_start));
            await this.playtest_mission();
            await sleep(15);
            await this.cinematic_fade_to_white();
            if (unit_in_vehicle(unit(await this.player0())))
            {
                object_teleport(object_get_parent(await this.player0()), player0_end);
            }
            else
            {
                object_teleport(await this.player0(), player0_end);
            }

            if (unit_in_vehicle(unit(await this.player1())))
            {
                object_teleport(object_get_parent(await this.player1()), player1_end);
            }
            else
            {
                object_teleport(await this.player1(), player1_end);
            }

            object_hide(await this.player0(), false);
            object_hide(await this.player1(), false);
            object_cannot_take_damage(players());
            await sleep(5);
            await this.cinematic_outro();
            await sleep(5);
            game_won();
        }

        [ScriptMethod(229, Lifecycle.Static)]
        public async Task start()
        {
            wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(230, Lifecycle.Startup)]
        public async Task mission_main()
        {
            sound_class_set_gain("amb", 0F, 0);
            ai_allegiance(player, covenant);
            weather_stop(0F);
            objectives_clear();
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task _08_intro_01_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 86, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 114, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 118, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 93, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 103, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 95, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 81, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 65, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 109, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 47, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 60, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 88, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 76, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 134, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 36, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 133, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 136, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 130, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 20, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 122, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 125, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 132, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 9, true);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 45, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3822453344U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3828286137U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3828679359U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3782934533U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3782934533U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3782934533U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3782934533U), 5);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3829400266U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3828679359U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3829465803U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3829531340U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3828679359U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3829400266U), 1);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, true);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3829596877U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3829596877U), 10);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3831366376U), 0);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            await sleep(24);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, true);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 49, true);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 46, true);
            await sleep(18);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3829400266U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 137, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_outdoor_toughy\\lightfixture_outdoor_toughy", 3831694061U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 49, false);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 102, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 36, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3829531340U), 1);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 137, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_outdoor_toughy\\lightfixture_outdoor_toughy", 3831694061U), 0);
            await sleep(100);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 65, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 81, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 95, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 103, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 118, false);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 1);
            await sleep(45);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 65, false);
            await sleep(93);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 127, false);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, true);
            await sleep(22);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            await sleep(15);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 133, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 136, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 130, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 47, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 125, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 137, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 132, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 49, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3829400266U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3828679359U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3829531340U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3828286137U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3829465803U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_outdoor_toughy\\lightfixture_outdoor_toughy", 3831694061U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3828286137U), 2);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3829465803U), 1);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 1);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 102, false);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await sleep(15);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\invisible_box1x2x2\\invisible_box1x2x2", 3832087283U), 0);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 24, true);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 3, false);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 36, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 0);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3832349431U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3832349431U), 1);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            await sleep(39);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 3);
            await sleep(46);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 127, false);
            await sleep(9);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 3);
            await sleep(91);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 127, false);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task _08_intra1_01_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 47, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 130, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3828286137U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3828679359U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\brute_shot\\projectiles\\grenade\\grenade", 3833398023U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3833856782U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3833856782U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3834446615U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 68);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 70);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3836150577U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 2);
            await sleep(80);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 2);
            await sleep(30);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 3);
            await sleep(16);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 2);
            await sleep(25);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 40, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 2);
            await sleep(17);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 68);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 70);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3836150577U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 9);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 32);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await sleep(13);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            await sleep(31);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3834446615U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 3);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            await sleep(78);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 40, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 1);
            await sleep(83);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 3);
            await sleep(37);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 0);
            await sleep(57);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 0);
            await sleep(19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 0);
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task _08_intra1_02_predict()
        {
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3829596877U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3829596877U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3834446615U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 3);
            await sleep(57);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 125, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 68);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 70);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3836150577U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 9);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3836543799U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3822781029U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 1);
            await sleep(156);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3829465803U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3828679359U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3829400266U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 74, false);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3829465803U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 1);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 48, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3829531340U), 0);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 18, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3829596877U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3829596877U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 1);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 4);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 122, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 0);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3836150577U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785097254U), 0);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 7);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3836609336U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 7);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            await sleep(26);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 125, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 79, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 49, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 51, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 52, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 108, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 48, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3829400266U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3828679359U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3829465803U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3822387807U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3834446615U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3836543799U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 50, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 10, true);
            await sleep(31);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            await sleep(38);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 132, false);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 0);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 1);
            await sleep(21);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 4);
            await sleep(66);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task _08_intra1_03_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 79, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 74, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 40, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3837330243U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 68);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 70);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3834839837U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3836150577U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3836216114U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3834446615U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3836543799U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3829400266U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3822453344U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3829531340U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3828679359U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3829465803U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3828286137U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 109, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 86, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 11, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3839755112U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3840476019U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3840476019U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 34);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3821601363U), 1);
            await sleep(154);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, false);
            await sleep(21);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            await sleep(24);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3828744896U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3837395780U), 40);
            await sleep(58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3840476019U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3840476019U), 1);
        }
    }
}