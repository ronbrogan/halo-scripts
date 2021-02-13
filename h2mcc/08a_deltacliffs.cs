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
            this.g_e10_pod_impact_effect = Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\earthcity\\e11_insertion_pod_impact", 4262730717U);
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
            this.g_e1_pod_impact_effect = Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\earthcity\\e11_insertion_pod_impact", 4262730717U);
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
        public async Task _08_intro_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intro_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _08_intra1_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra1_01_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _08_intra1_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra1_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _08_intra1_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra1_03_predict));
        }

        [ScriptMethod(28, Lifecycle.Dormant)]
        public async Task c08_intro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intro\\foley\\c08_intro_01_fol", 3822256733U), default(IGameObject), 1F);
            Engine.print("c08_intro foley 01 start");
        }

        [ScriptMethod(29, Lifecycle.Dormant)]
        public async Task intro_fov()
        {
            await Engine.sleep(279);
            Engine.print("fov change: 70 -> 50 over 0 ticks");
            Engine.camera_set_field_of_view(50F, 0);
        }

        [ScriptMethod(30, Lifecycle.Dormant)]
        public async Task intro_dof()
        {
            await Engine.sleep(484);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(60);
            Engine.print("rack focus");
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0.5F, 1F, 0.5F, 0F, 1F);
            await Engine.sleep(103);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(31, Lifecycle.Dormant)]
        public async Task effect_teleport()
        {
            await Engine.sleep(240);
            Engine.print("effect - teleport");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\cinematic_teleport", 3822322270U), teleport.Entity, "marker");
        }

        [ScriptMethod(32, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intro()
        {
            Engine.cinematic_lighting_set_primary_light(16F, -32F, 0.501961F, 0.501961F, 0.4F);
            Engine.cinematic_lighting_set_secondary_light(13F, 120F, 0.231373F, 0.231373F, 0.388235F);
            Engine.cinematic_lighting_set_ambient_light(0.14902F, 0.14902F, 0.101961F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_plasma_rifle.Entity, true);
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task plasma_rifle_attach()
        {
            await Engine.sleep(705);
            Engine.objects_attach(dervish.Entity, "right_hand_elite", intro_plasma_rifle.Entity, "");
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task c08_intro_setup()
        {
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(teleport);
            Engine.object_create_anew(intro_plasma_rifle);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.wake(new ScriptMethodReference(c08_intro_foley_01));
            Engine.wake(new ScriptMethodReference(effect_teleport));
            Engine.wake(new ScriptMethodReference(intro_fov));
            Engine.wake(new ScriptMethodReference(plasma_rifle_attach));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intro));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task c08_intro()
        {
            Engine.sound_class_set_gain("amb", 0F, 0);
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp0"));
            await Engine.sleep(1);
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltacliffs_intro");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(70F, 0);
            Engine.sound_class_set_gain("amb", 1F, 60);
            await this._08_intro_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intro\\foley\\c08_intro_01_fol", 3822256733U));
            await Engine.sleep(100);
            await this.c08_intro_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intro\\08_intro", 3822977640U), "08_intro_01", default(IUnit), anchor_flag_intro);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intro\\08_intro", 3823043177U), "dervish_01", false, anchor_intro.Entity);
            Engine.fade_in(0F, 0F, 0F, 30);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.sound_class_set_gain("amb", 0F, 15);
            await Engine.sleep(15);
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(intro_plasma_rifle.Entity);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c08_intra1_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_01_fol", 3823174251U), default(IGameObject), 1F);
            Engine.print("c08_intra1 foley 01 start");
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c08_2010_soc()
        {
            await Engine.sleep(461);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2010_soc", 3823239788U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c08_2010_soc", 3F);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c04_intra1_dof_01()
        {
            Engine.time_code_reset();
            Engine.time_code_show(true);
            Engine.time_code_start(true);
            await Engine.sleep(80);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1.5F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            Engine.print("rack focus");
            Engine.time_code_reset();
            await Engine.sleep(120);
            Engine.cinematic_screen_effect_set_depth_of_field(1.5F, 0F, 0.5F, 0.5F, 0.5F, 0F, 0.5F);
            Engine.print("rack focus");
            Engine.time_code_reset();
            await Engine.sleep(50);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            Engine.print("rack focus");
            Engine.time_code_reset();
            await Engine.sleep(86);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra1_01()
        {
            Engine.cinematic_lighting_set_primary_light(40F, 134F, 0.321569F, 0.321569F, 0.290196F);
            Engine.cinematic_lighting_set_secondary_light(8F, 274F, 0.301961F, 0.290196F, 0.45098F);
            Engine.cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            Engine.object_uses_cinematic_lighting(dervish_01.Entity, true);
            Engine.object_uses_cinematic_lighting(commander.Entity, true);
            Engine.object_uses_cinematic_lighting(wraith_01.Entity, true);
            Engine.object_uses_cinematic_lighting(scarab_01.Entity, true);
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task c08_intra1_01_setup()
        {
            Engine.object_create_anew(dervish_01);
            Engine.object_create_anew(commander);
            Engine.object_create_anew(wraith_01);
            Engine.object_cinematic_lod(dervish_01.Entity, true);
            Engine.object_cinematic_lod(commander.Entity, true);
            Engine.object_cinematic_lod(wraith_01.Entity, true);
            Engine.cinematic_clone_players_weapon(dervish_01.Entity, "right_hand_elite", "");
            Engine.wake(new ScriptMethodReference(c08_intra1_foley_01));
            Engine.wake(new ScriptMethodReference(c08_2010_soc));
            Engine.wake(new ScriptMethodReference(c04_intra1_dof_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intra1_01));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task c08_intra1_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltacliffs_intra1");
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(50F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this._08_intra1_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_01_fol", 3823174251U));
            await Engine.sleep(this.prediction_offset);
            await this.c08_intra1_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra1\\08_intra1", 3823305325U), "08_intra1_01", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(dervish_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra1\\08_intra1", 3823370862U), "dervish_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\08_intra1\\08_intra1", 3823436399U), "commander_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(wraith_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\wraith\\08_intra1\\08_intra1", 3823567473U), "wraith_01", false, anchor_intra1.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._08_intra1_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\music\\c08_intra1_02_mus", 3823633010U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_02_fol", 3823698547U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c08_intra1_sound_scene2_01()
        {
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 0F);
            await Engine.sleep(210);
            Engine.sound_class_set_gain("vehicle", 1F, 60);
            await Engine.sleep(60);
            Engine.sound_class_set_gain("vehicle", 0F, 150);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c08_intra1_score_02()
        {
            await Engine.sleep(337);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\music\\c08_intra1_02_mus", 3823633010U), default(IGameObject), 1F);
            Engine.print("c08_intra1 score 02 start");
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task c08_intra1_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_02_fol", 3823698547U), default(IGameObject), 1F);
            Engine.print("c08_intra1 foley 02 start");
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task c08_2020_der()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2020_der", 3823764084U), dervish_01.Entity, 1F);
            Engine.cinematic_subtitle("c08_2020_der", 3F);
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task c08_2030_soc()
        {
            await Engine.sleep(77);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2030_soc", 3823829621U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c08_2030_soc", 4F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task c04_intra1_dof_02()
        {
            await Engine.sleep(427);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1.22F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(84);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(100);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 0.5F, 0F, 0F, 0F, 0.5F, 0.5F);
            Engine.print("rack focus");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra1_02()
        {
            Engine.cinematic_lighting_set_primary_light(40F, 134F, 0.321569F, 0.321569F, 0.290196F);
            Engine.cinematic_lighting_set_secondary_light(8F, 274F, 0.301961F, 0.290196F, 0.45098F);
            Engine.cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            Engine.object_uses_cinematic_lighting(phantom_01.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_02.Entity, true);
        }

        [ScriptMethod(49, Lifecycle.Static)]
        public async Task c08_intra1_02_setup()
        {
            Engine.object_create_anew(phantom_01);
            Engine.object_create_anew(phantom_02);
            Engine.object_cinematic_lod(phantom_01.Entity, true);
            Engine.object_cinematic_lod(phantom_02.Entity, true);
            Engine.wake(new ScriptMethodReference(c08_intra1_sound_scene2_01));
            Engine.wake(new ScriptMethodReference(c08_intra1_score_02));
            Engine.wake(new ScriptMethodReference(c08_intra1_foley_02));
            Engine.wake(new ScriptMethodReference(c08_2020_der));
            Engine.wake(new ScriptMethodReference(c08_2030_soc));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intra1_02));
        }

        [ScriptMethod(50, Lifecycle.Static)]
        public async Task c08_intra1_02_cleanup()
        {
            Engine.object_destroy(dervish_01.Entity);
            Engine.object_destroy(commander.Entity);
            Engine.object_destroy(phantom_02.Entity);
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task c08_intra1_scene_02()
        {
            await this.c08_intra1_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra1\\08_intra1", 3823305325U), "08_intra1_02", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(dervish_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra1\\08_intra1", 3823370862U), "dervish_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\08_intra1\\08_intra1", 3823436399U), "commander_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(wraith_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\wraith\\08_intra1\\08_intra1", 3823567473U), "wraith_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\08_intra1\\08_intra1", 3823895158U), "phantom01_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\08_intra1\\08_intra1", 3823895158U), "phantom02_02", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._08_intra1_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_03_fol", 3823960695U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c08_intra1_02_cleanup();
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task c08_intra1_sound_scene3_01()
        {
            Engine.object_set_function_variable(phantom_01.Entity, "engine_hack", 0F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 0F, 0F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_audio", 0F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 0F, 0F);
            Engine.object_set_function_variable(phantom_01.Entity, "hover_audio", 0F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 0F, 0F);
            Engine.sound_class_set_gain("vehicle", 1F, 30);
            await Engine.sleep(120);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 180F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 180F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 180F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 180F);
            Engine.object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 180F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 180F);
            Engine.sound_class_set_gain("vehicle", 0F, 180);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c08_intra1_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_03_fol", 3823960695U), default(IGameObject), 1F);
            Engine.print("c08_intra1 foley 03 start");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c08_2040_tar()
        {
            await Engine.sleep(268);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2040_tar", 3824026232U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_2040_tar", 2F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra1_03()
        {
            Engine.cinematic_lighting_set_primary_light(40F, 134F, 0.321569F, 0.321569F, 0.290196F);
            Engine.cinematic_lighting_set_secondary_light(8F, 274F, 0.301961F, 0.290196F, 0.45098F);
            Engine.cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(monitor.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_03.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_04.Entity, true);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task show_brutes()
        {
            await Engine.sleep(199);
            Engine.print("show brutes");
            Engine.object_hide(brute_01.Entity, false);
            Engine.object_hide(brute_02.Entity, false);
            Engine.object_hide(brute_03.Entity, false);
            Engine.object_hide(brute_04.Entity, false);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task door_close()
        {
            await Engine.sleep(430);
            Engine.print("door close");
            Engine.device_set_position(intra1_door.Entity, 0F);
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task c08_intra1_03_setup()
        {
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(monitor);
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_02);
            Engine.object_create_anew(brute_03);
            Engine.object_create_anew(brute_04);
            Engine.object_set_function_variable(monitor.Entity, "talking", 0F, 0F);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(monitor.Entity, true);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
            Engine.object_cinematic_lod(brute_03.Entity, true);
            Engine.object_cinematic_lod(brute_04.Entity, true);
            Engine.object_hide(brute_01.Entity, true);
            Engine.object_hide(brute_02.Entity, true);
            Engine.object_hide(brute_03.Entity, true);
            Engine.object_hide(brute_04.Entity, true);
            Engine.object_create_anew(intra1_door);
            Engine.device_set_position_immediate(intra1_door.Entity, 1F);
            Engine.wake(new ScriptMethodReference(show_brutes));
            Engine.wake(new ScriptMethodReference(door_close));
            Engine.wake(new ScriptMethodReference(c08_intra1_sound_scene3_01));
            Engine.wake(new ScriptMethodReference(c08_intra1_foley_03));
            Engine.wake(new ScriptMethodReference(c08_2040_tar));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intra1_03));
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c08_intra1_03_cleanup()
        {
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(monitor.Entity);
            Engine.object_destroy_containing("brute");
            Engine.object_destroy(phantom_01.Entity);
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task c08_intra1_scene_03()
        {
            Engine.cinematic_lightmap_shadow_enable();
            await this.c08_intra1_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra1\\08_intra1", 3823305325U), "08_intra1_03", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3824091769U), "tartarus_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra1\\08_intra1", 3824222843U), "miranda_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra1\\08_intra1", 3829007044U), "monitor_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3824091769U), "brute01_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3824091769U), "brute02_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3824091769U), "brute03_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra1\\08_intra1", 3824091769U), "brute04_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\08_intra1\\08_intra1", 3823895158U), "phantom01_03", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c08_intra1_03_cleanup();
            Engine.cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task c08_intra1()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp0"));
            await Engine.sleep(1);
            await this.c08_intra1_scene_01();
            await this.c08_intra1_scene_02();
            await this.c08_intra1_scene_03();
            Engine.cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task<bool> player_in_vehicle()
        {
            return Engine.unit_in_vehicle(Engine.unit(await this.player0())) || (bool)Engine.game_is_cooperative() && Engine.unit_in_vehicle(Engine.unit(await this.player1()));
        }

        [ScriptMethod(63, Lifecycle.Static)]
        public async Task<bool> players_in_vehicle()
        {
            return Engine.unit_in_vehicle(Engine.unit(await this.player0())) && !((bool)Engine.game_is_cooperative()) || Engine.unit_in_vehicle(Engine.unit(await this.player1()));
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
            await Engine.sleep(30);
            Engine.print("new objective set: defend yourself from the brutes");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task objective0_clear()
        {
            Engine.print("objective complete: defend yourself from the brutes");
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task objective1_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set: exact vengeance on the traitor brutes");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task objective1_clear()
        {
            Engine.print("objective complete: exact vengeance on the traitor brutes");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task objective2_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set: continue to the canyon floor");
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task objective2_clear()
        {
            Engine.print("objective complete: continue to the canyon floor");
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task objective3_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set: raze the brute encampment");
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task music_08a_01_stop()
        {
            Engine.print("music 08a_01 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_01", 4260240311U));
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task music_08a_01_start_alt()
        {
            Engine.print("music 08a_01 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_01", 4260240311U), true);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task music_08a_01_start()
        {
            Engine.print("music 08a_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_01", 4260240311U), default(IGameObject), 1F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task music_08a_02_stop()
        {
            Engine.print("music 08a_02 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_02", 4261026755U));
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task music_08a_02_start()
        {
            Engine.print("music 08a_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_02", 4261026755U), default(IGameObject), 1F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task music_08a_03_stop()
        {
            Engine.print("music 08a_03 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_03", 4261419977U));
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task music_08a_03_start_alt()
        {
            Engine.print("music 08a_01 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_03", 4261419977U), true);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task music_08a_03_start()
        {
            Engine.print("music 08a_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_03", 4261419977U), default(IGameObject), 1F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task music_08a_04_start()
        {
            Engine.print("music 08a_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_04", 4262206421U), default(IGameObject), 1F);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task music_08a_05_start()
        {
            Engine.print("music 08a_05 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08a_deltacliffs\\08a_music\\08a_05", 4262468569U), default(IGameObject), 1F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task chapter_title0()
        {
            await Engine.sleep(30);
            Engine.cinematic_set_title(title0);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task chapter_title1()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task chapter_title2()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title2);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task<bool> e10_player_dismounted()
        {
            return !(Engine.unit_in_vehicle(Engine.unit(await this.player0()))) || !(Engine.unit_in_vehicle(Engine.unit(await this.player1())));
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task<bool> e10_pro_inf_alerted()
        {
            return (short)Engine.ai_combat_status(e10_pro_inf0) >= this.ai_combat_status_certain || (short)Engine.ai_combat_status(e10_pro_inf1) >= this.ai_combat_status_certain;
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task<bool> e10_player_holding_launcher()
        {
            return Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher.weapon", 4161738223U));
        }

        [ScriptMethod(89, Lifecycle.Static)]
        public async Task<bool> e10_pro_phantom0_should_retreat()
        {
            return Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e10_pro_phantom0.phantom0), "target_front") >= 3 || Engine.object_get_health(Engine.ai_vehicle_get(e10_pro_phantom0.phantom0)) <= 0.05F;
        }

        [ScriptMethod(90, Lifecycle.CommandScript)]
        public async Task cs_e10_pro_phantom0_entry()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p3"));
            Engine.cs_enable_targeting(true);
            if ((short)Engine.ai_spawn_count(e10_pro_ghosts0_1.Squad) > 0)
            {
                Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p3_1"), 0.5F);
                await Engine.sleep(20);
                Engine.vehicle_unload(Engine.ai_vehicle_get(e10_pro_phantom0.phantom0), "phantom_sc");
                await Engine.sleep(40);
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p3"));
            }

            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => await this.e10_pro_phantom0_should_retreat(), 30, this.one_minute);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_targeting(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e10_pro_phantom0_entry/p4"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(91, Lifecycle.CommandScript)]
        public async Task cs_e10_weapon_scene0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            this.g_e10_weapon_scene0_actor = Engine.ai_get_unit(this.ai_current_actor);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_armory/p0"));
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e10_armory/rocket_launchers"));
            await Engine.sleep(10);
            Engine.print("elite: what vulgar weapons");
            Engine.ai_play_line(this.ai_current_actor, "0500") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(30);
            Engine.cs_look_player(true);
            await Engine.sleep(45);
        }

        [ScriptMethod(92, Lifecycle.CommandScript)]
        public async Task cs_e10_weapon_scene1()
        {
            Engine.cs_look_object(true, Engine.ai_vehicle_get(e10_pro_phantom0.phantom0));
            await Engine.sleep(30);
            Engine.cs_look_player(true);
            await Engine.sleep(15);
            Engine.print("elite: perhaps i spoke too soon");
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0510"));
        }

        [ScriptMethod(93, Lifecycle.CommandScript)]
        public async Task cs_e10_pro_inf1_0_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_patrol/p0"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e10_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(90, 120));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e10_patrol/f0"));
                Engine.cs_enable_looking(true);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_patrol/p1"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e10_patrol/f1"));
                await Engine.sleep((short)Engine.random_range(90, 120));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e10_patrol/f1"));
                Engine.cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(94, Lifecycle.CommandScript)]
        public async Task cs_e10_pro_inf1_0_patrol1()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_patrol/p2"));
                Engine.cs_movement_mode(this.ai_movement_combat);
                Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e10_patrol/s0"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e10_patrol/s0"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e10_patrol/s0"));
                await Engine.sleep((short)Engine.random_range(60, 150));
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e10_patrol/s0"));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e10_patrol/s0"));
                Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("e10_patrol/s0"));
                Engine.cs_movement_mode(this.ai_movement_patrol);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_patrol/p3"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e10_patrol/f1"));
                await Engine.sleep((short)Engine.random_range(90, 120));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e10_patrol/f1"));
                return false;
            });
        }

        [ScriptMethod(95, Lifecycle.CommandScript)]
        public async Task cs_e10_pro_ghosts0_entry()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_pro_ghosts0/p0"));
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task e10_pod0_insertion()
        {
            Engine.ai_place(e10_cov_inf0.elite0);
            Engine.object_create(e10_pod0_inserter);
            Engine.objects_attach(e10_pod0_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e10_cov_inf0.elite0), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e10_pod0_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e10_pod0_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e10_pod_impact_effect, Engine.ai_vehicle_get(e10_cov_inf0.elite0), "pod_attach");
            Engine.objects_detach(e10_pod0_inserter.Entity, Engine.ai_vehicle_get(e10_cov_inf0.elite0));
            Engine.object_destroy(e10_pod0_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.ai_vehicle_exit(e10_cov_inf0.elite0);
            await Engine.sleep(10);
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e10_cov_inf0.elite0), "door", 500F);
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task e10_pod1_insertion()
        {
            Engine.ai_place(e10_cov_inf0.elite1);
            Engine.object_create(e10_pod1_inserter);
            Engine.objects_attach(e10_pod1_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e10_cov_inf0.elite1), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e10_pod1_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e10_pod1_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e10_pod_impact_effect, Engine.ai_vehicle_get(e10_cov_inf0.elite1), "pod_attach");
            Engine.objects_detach(e10_pod1_inserter.Entity, Engine.ai_vehicle_get(e10_cov_inf0.elite1));
            Engine.object_destroy(e10_pod1_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.ai_vehicle_exit(e10_cov_inf0.elite1);
            await Engine.sleep(10);
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e10_cov_inf0.elite1), "door", 500F);
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task e10_pod2_insertion()
        {
            Engine.ai_place(e10_cov_inf0.elite2);
            Engine.object_create(e10_pod2_inserter);
            Engine.objects_attach(e10_pod2_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e10_cov_inf0.elite2), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e10_pod2_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e10_pod2_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e10_pod_impact_effect, Engine.ai_vehicle_get(e10_cov_inf0.elite2), "pod_attach");
            Engine.objects_detach(e10_pod2_inserter.Entity, Engine.ai_vehicle_get(e10_cov_inf0.elite2));
            Engine.object_destroy(e10_pod2_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.ai_vehicle_exit(e10_cov_inf0.elite2);
            await Engine.sleep(10);
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e10_cov_inf0.elite2), "door", 500F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task e10_pod3_insertion()
        {
            Engine.ai_place(e10_cov_inf0.elite3);
            Engine.object_create(e10_pod3_inserter);
            Engine.objects_attach(e10_pod3_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e10_cov_inf0.elite3), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e10_pod3_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e10_pod3_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e10_pod_impact_effect, Engine.ai_vehicle_get(e10_cov_inf0.elite3), "pod_attach");
            Engine.objects_detach(e10_pod3_inserter.Entity, Engine.ai_vehicle_get(e10_cov_inf0.elite3));
            Engine.object_destroy(e10_pod3_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.ai_vehicle_exit(e10_cov_inf0.elite3);
            await Engine.sleep(10);
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e10_cov_inf0.elite3), "door", 500F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task e10_weapon_scene()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_armory, Engine.players()) && Engine.volume_test_objects(tv_e10_armory, Engine.ai_actors(e10_cov_inf0.Squad)));
            await Engine.sleep_until(async () => Engine.ai_scene("e10_weapon_scene0", cs_e10_weapon_scene0, e10_cov_inf0.Squad), 15);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e10_armory, Engine.players())), 15);
            await Engine.sleep_until(async () => Engine.ai_scene("e10_weapon_scene1", cs_e10_weapon_scene1, Engine.object_get_ai(this.g_e10_weapon_scene0_actor)), 15);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task e10_fallback_checkpoint0()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_armory, Engine.players()));
            Engine.game_save();
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task e10_pro_phantom0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_armory_entrance, Engine.players()) || Engine.volume_test_objects(tv_e10_second_half, Engine.players()), 15);
            Engine.game_save();
            Engine.ai_place(e10_pro_phantom0.Squad);
            Engine.cs_run_command_script(e10_pro_phantom0.phantom0, cs_e10_pro_phantom0_entry);
            if ((short)Engine.ai_living_count(e10_pro_wraith0) <= 0)
            {
                Engine.ai_place_in_vehicle(e10_pro_ghosts0_1.Squad, e10_pro_phantom0.Squad);
            }
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task e10_pro_ghosts0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_pro_inf2_retreat0, Engine.players()), 15);
            Engine.ai_place(e10_pro_ghosts0_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_pro_inf2_retreat2, Engine.players()), 15);
            Engine.ai_place(e10_pro_ghosts0_0.Squad);
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task e10_pro_wraith0_main()
        {
            Engine.ai_place(e10_pro_wraith0);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e10_pro_wraith0) <= 0, 15);
            Engine.game_save();
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task e10_pro_inf3_main()
        {
            Engine.ai_place(e10_pro_inf3.Squad, 1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_bridge, Engine.players()), 15);
            Engine.ai_place(e10_pro_inf3.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_second_half, Engine.players()), 15);
            Engine.ai_place(e10_pro_inf3.Squad, (short)(2 - (float)Engine.ai_living_count(e10_pro_inf3.Squad)));
            Engine.ai_set_orders(e10_pro_inf3.Squad, e10_pro_inf3_retreat0);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task e10_pro_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_armory_entrance, Engine.players()) || Engine.volume_test_objects(tv_e10_second_half, Engine.players()), 15);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e10_pro_wraith0_1.Squad) <= 0 || Engine.volume_test_objects(tv_e10_pro_inf2_retreat0, Engine.players()), 15);
            Engine.ai_place(e10_pro_inf2_0.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(prophets), 2F, 4F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_pro_inf2_retreat0, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e10_fallback_checkpoint0));
            await Engine.sleep(60);
            Engine.ai_place(e10_pro_inf2_1.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(prophets), 0F, 4F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_near_exit, Engine.players()), 15);
            Engine.ai_place(e10_pro_inf2_1.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(prophets), 0F, 4F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_pro_inf2_retreat2, Engine.players()), 15);
            Engine.ai_place(e10_pro_inf2_1.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(prophets), 0F, 4F));
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task e10_pro_inf1_main()
        {
            Engine.ai_place(e10_pro_inf1_0.Squad);
            await Engine.sleep_until(async () => await this.e10_pro_inf_alerted());
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_inf1_1_init, Engine.players()), 15, 300);
            Engine.ai_place(e10_pro_inf1_1.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_inf1_2_init, Engine.players()), 15);
            if (await this.difficulty_normal())
            {
                this.g_e10_pro_inf1_2_count = 3;
            }

            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save() || Engine.volume_test_objects(tv_e10_pro_inf1_do_or_die, Engine.players()), 15);
            Engine.game_save();
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e10_pro_inf1) <= 2)
                {
                    Engine.game_save();
                    await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_armory_entrance, Engine.players()), 15, 450);
                    Engine.ai_place(e10_pro_inf1_2.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e10_pro_inf1), 1F, this.g_e10_pro_inf1_2_count));
                    this.g_e10_pro_inf1_2_count = (short)(this.g_e10_pro_inf1_2_count - 1);
                }

                return this.g_e10_pro_inf1_2_count <= 0 || Engine.volume_test_objects(tv_e10_armory_entrance, Engine.players());
            }, 15);
            if (Engine.volume_test_objects(tv_e10_armory_entrance, Engine.players()))
            {
                Engine.ai_disposable(e10_pro_inf1, true);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e10_pro_inf1) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task e10_pro_inf0_main()
        {
            Engine.ai_place(e10_pro_inf0_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_armory_entrance, Engine.players()) || Engine.volume_test_objects(tv_e10_second_half, Engine.players()), 15);
            Engine.game_save();
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task e10_cov_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_bridge, Engine.players()), 15);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e10_pro_wraith0_0.Squad) <= 0);
            Engine.wake(new ScriptMethodReference(e10_pod0_insertion));
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(e10_pod1_insertion));
            Engine.wake(new ScriptMethodReference(e10_weapon_scene));
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task e10_cov_ghosts0_main()
        {
            Engine.ai_migrate(e9_cov_ghosts0.Squad, e10_cov_ghosts0.Squad);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task e10_key()
        {
            if (!(await this.difficulty_legendary()))
            {
                Engine.sleep_forever();
            }

            Engine.object_create(key);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4179498750U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4179498750U)));
            Engine.ice_cream_flavor_stock(7);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task e10_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_main_begin, Engine.players()), 15);
            this.g_e10_started = true;
            Engine.print("e10_main");
            Engine.data_mine_set_mission_segment("e10_brute_camp");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_08a_04_start));
            Engine.wake(new ScriptMethodReference(chapter_title2));
            Engine.wake(new ScriptMethodReference(objective2_clear));
            Engine.wake(new ScriptMethodReference(objective3_set));
            Engine.wake(new ScriptMethodReference(e10_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e10_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e10_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e10_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e10_pro_inf2_main));
            Engine.wake(new ScriptMethodReference(e10_pro_inf3_main));
            Engine.wake(new ScriptMethodReference(e10_pro_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e10_pro_wraith0_main));
            Engine.wake(new ScriptMethodReference(e10_key));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_exit_door, Engine.players()) && Engine.device_get_position(e10_exit_door.Entity) > 0F, 15);
        }

        [ScriptMethod(113, Lifecycle.Static)]
        public async Task test_brute_camp()
        {
            Engine.object_teleport(await this.player0(), e10_test);
            Engine.ai_place(e10_cov_ghosts0.Squad);
            if (!(this.g_e10_started))
            {
                Engine.wake(new ScriptMethodReference(e10_main));
            }

            Engine.ai_place(e9_pro_inf3.Squad);
        }

        [ScriptMethod(114, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_inf1_trap()
        {
            Engine.cs_enable_dialogue(true);
            Engine.cs_abort_on_damage(true);
            Engine.cs_face_object(true, e9_trap_target0.Entity);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_trap_trigger0, Engine.players()), 5);
            Engine.cs_face_object(false, e9_trap_target0.Entity);
            Engine.cs_shoot(true, e9_trap_target0.Entity);
            await Engine.sleep_until(async () => Engine.object_get_health(e9_trap_target0.Entity) <= 0F || Engine.volume_test_objects(tv_e9_trap_trigger1, Engine.players()), 2);
            Engine.cs_shoot(false, e9_trap_target0.Entity);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_trap_trigger1, Engine.players()), 5);
            Engine.cs_shoot(true, e9_trap_target1.Entity);
            await Engine.sleep_until(async () => Engine.object_get_health(e9_trap_target1.Entity) <= 0F, 2, 30);
            await Engine.sleep((short)Engine.random_range(20, 60));
        }

        [ScriptMethod(115, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_inf1_abort()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(116, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_phantom0_overflight()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0/p3"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task e9_weather_control()
        {
            Engine.weather_stop(120F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_first_drop, Engine.players()), 15);
            Engine.weather_stop(90F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_trap_trigger1, Engine.players()), 15);
            Engine.weather_stop(60F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_pro_inf3_begin, Engine.players()), 15);
            Engine.weather_stop(30F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_entrance, Engine.players()), 15);
            Engine.weather_stop(15F);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task e9_pro_phantom0_main()
        {
            Engine.ai_place(e9_pro_phantom0.Squad);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task e9_pro_inf3_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_pro_inf3_begin, Engine.players()), 15);
            Engine.game_save();
            Engine.ai_place(e9_pro_inf3.Squad);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task e9_pro_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_first_drop, Engine.players()), 15);
            Engine.ai_place(e9_pro_inf2.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 2F, 4F));
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task e9_pro_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_first_drop, Engine.players()), 15);
            Engine.ai_place(e9_pro_inf1.Squad);
            Engine.cs_run_command_script(e9_pro_inf1.Squad, cs_e9_pro_inf1_trap);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_trap_trigger0, Engine.players()), 5);
            await Engine.sleep_until(async () => (float)Engine.ai_strength(e9_pro_inf1.Squad) < 0.9F, 15, 300);
            Engine.cs_run_command_script(e9_pro_inf1.Squad, cs_e9_pro_inf1_abort);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task e9_pro_inf0_main()
        {
            Engine.ai_place(e9_pro_inf0_0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 0F, 2F));
            Engine.ai_place(e9_pro_inf0_1.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 0F, 2F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_trap_trigger0, Engine.players()) || (short)Engine.ai_living_count(e9_pro_inf0) <= 0, 5);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_trap_trigger0, Engine.players()), 5);
            Engine.ai_place(e9_pro_inf0_2.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 0F, 2F));
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task e9_cov_ghosts0_main()
        {
            Engine.ai_place(e9_cov_ghosts0.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e8_pro_spectre0.Squad) <= 0 && (short)Engine.ai_living_count(e8_pro) <= 2);
            Engine.ai_migrate(e8_cov_inf0.Squad, e9_cov_ghosts0.Squad);
            Engine.ai_migrate(e8_cov_ghosts0.Squad, e9_cov_ghosts0.Squad);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task e9_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_main_begin, Engine.players()), 15);
            this.g_e9_started = true;
            Engine.print("e9_main");
            Engine.data_mine_set_mission_segment("e9_ski_run");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_08a_03_stop));
            Engine.wake(new ScriptMethodReference(e10_main));
            Engine.wake(new ScriptMethodReference(e9_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e9_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e9_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e9_pro_inf2_main));
            Engine.wake(new ScriptMethodReference(e9_pro_inf3_main));
            Engine.wake(new ScriptMethodReference(e9_pro_phantom0_main));
            Engine.wake(new ScriptMethodReference(e9_weather_control));
            await Engine.sleep_until(async () => this.g_e10_started);
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_inf3_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_phantom0_main));
            Engine.ai_disposable(e9_pro, true);
            Engine.ai_disposable(e9_pro_phantom0.Squad, false);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task test_ski_run()
        {
            Engine.object_teleport(await this.player0(), e9_test);
            Engine.ai_place(e9_cov_ghosts0.Squad);
            if (!(this.g_e9_started))
            {
                Engine.wake(new ScriptMethodReference(e9_main));
            }
        }

        [ScriptMethod(126, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_inf0_init()
        {
            Engine.cs_enable_dialogue(true);
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("generic_player_sighted", this.ai_current_squad), 10);
            Engine.cs_movement_mode(this.ai_movement_flee);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e8_spectre_begin, Engine.players()), 15);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e8_pro_spectre0.Squad) > 0 && (short)Engine.ai_living_count(e8_pro_spectre0.Squad) <= 1 || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 2F, 10, 450);
            await Engine.sleep((short)Engine.random_range(0, 45));
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.ai_vehicle_enter(this.ai_current_actor, Engine.ai_vehicle_get_from_starting_location(e8_cov_inf0.turret0));
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task e8_pro_spectre0_main()
        {
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e8_exit, Engine.players()) || (short)Engine.ai_living_count(e8_pro) <= 2, 15);
            Engine.ai_place(e8_pro_spectre0.Squad);
            await Engine.sleep(1);
            Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get(e8_pro_spectre0.starting_locations_0), "spectre_p_l", true);
            Engine.wake(new ScriptMethodReference(music_08a_03_start_alt));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e8_pro_spectre0.Squad) <= 0);
            Engine.wake(new ScriptMethodReference(music_08a_03_stop));
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task e8_pro_inf2_main()
        {
            Engine.ai_place(e8_pro_inf2.Squad);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task e8_pro_inf1_main()
        {
            Engine.ai_place(e8_pro_inf1_0.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e8_pro_inf1) <= 0 || Engine.volume_test_objects(tv_e8_exit, Engine.players()));
            Engine.ai_place(e8_pro_inf1_1.Squad, (short)(4 - (float)Engine.ai_living_count(e8_pro_inf1)));
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task e8_pro_inf0_main()
        {
            Engine.ai_place(e8_pro_inf0.Squad);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task e8_cov_inf0_main()
        {
            Engine.ai_place(e8_cov_inf0.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(covenant1), 4F, 6F));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e8_cov_inf0.ghost0), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e8_cov_inf0.ghost1), true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_main_begin, Engine.players()), 15);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e8_cov_inf0.ghost0), false);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e8_cov_inf0.ghost1), false);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task e8_cov_ghosts0_main()
        {
            Engine.ai_migrate(e7_cov_ghosts0.Squad, e8_cov_ghosts0.Squad);
            Engine.ai_migrate(e7_cov_ghosts1.Squad, e8_cov_ghosts0.Squad);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task e8_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e8_main_begin, Engine.players()), 15);
            this.g_e8_started = true;
            Engine.print("e8_main");
            Engine.data_mine_set_mission_segment("e8_kidney1");
            Engine.game_save();
            Engine.weather_start(120F);
            Engine.wake(new ScriptMethodReference(e9_main));
            Engine.wake(new ScriptMethodReference(e8_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e8_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e8_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e8_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e8_pro_inf2_main));
            Engine.wake(new ScriptMethodReference(e8_pro_spectre0_main));
            await Engine.sleep_until(async () => this.g_e9_started);
            Engine.sleep_forever(new ScriptMethodReference(e8_cov_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_pro_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_pro_spectre0_main));
            Engine.ai_disposable(e8_pro, true);
        }

        [ScriptMethod(134, Lifecycle.CommandScript)]
        public async Task cs_e7_cov_grunt0()
        {
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("generic_player_sighted", this.ai_current_squad) || (short)Engine.ai_combat_status(e7_pro_inf0_0.Squad) >= this.ai_combat_status_active, 15);
            Engine.cs_enable_dialogue(true);
            Engine.cs_face_player(true);
            await Engine.sleep((short)Engine.random_range(25, 45));
            Engine.cs_movement_mode(this.ai_movement_flee);
            Engine.cs_face_player(false);
            Engine.cs_enable_looking(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e7_patrol/p0_2"));
            await Engine.sleep_until(async () => !(Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), "c_turret_ap_d", Engine.ai_actors(e7_pro_inf0))) && !(Engine.volume_test_objects(tv_e7_grunts_unsafe, Engine.ai_actors(e7_pro_inf0))), 60);
            Engine.cs_movement_mode(this.ai_movement_combat);
            await Engine.sleep((short)Engine.random_range(25, 45));
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), false);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), false);
            Engine.ai_vehicle_enter(this.ai_current_actor, Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0));
        }

        [ScriptMethod(135, Lifecycle.CommandScript)]
        public async Task cs_e7_cov_grunt1()
        {
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("generic_player_sighted", this.ai_current_squad) || (short)Engine.ai_combat_status(e7_pro_inf0_0.Squad) >= this.ai_combat_status_active, 15);
            Engine.cs_enable_dialogue(true);
            Engine.cs_face_player(true);
            await Engine.sleep((short)Engine.random_range(25, 45));
            Engine.cs_movement_mode(this.ai_movement_flee);
            Engine.cs_face_player(false);
            Engine.cs_enable_looking(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e7_patrol/p1_2"));
            await Engine.sleep_until(async () => !(Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), "c_turret_ap_d", Engine.ai_actors(e7_pro_inf0))) && !(Engine.volume_test_objects(tv_e7_grunts_unsafe, Engine.ai_actors(e7_pro_inf0))), 60);
            Engine.cs_movement_mode(this.ai_movement_combat);
            await Engine.sleep((short)Engine.random_range(25, 45));
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), false);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost1), false);
            Engine.ai_vehicle_enter(this.ai_current_actor, Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost1));
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task e7_pro_inf2_main()
        {
            Engine.ai_place(e7_pro_inf2.Squad);
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task e7_pro_inf1_spawn()
        {
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e7_pro_inf1_0_unsafe, Engine.players())), 10, 60);
            if (!(Engine.volume_test_objects(tv_e7_pro_inf1_0_unsafe, Engine.players())))
            {
                Engine.ai_place(e7_pro_inf1_0.Squad);
            }
            else if (!(Engine.volume_test_objects(tv_e7_end_section, Engine.players())))
            {
                Engine.ai_place(e7_pro_inf1_1.Squad);
            }
            else if (!(Engine.volume_test_objects(tv_e7_pro_inf1_2_unsafe, Engine.players())))
            {
                Engine.ai_place(e7_pro_inf1_2.Squad);
            }
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task e7_pro_inf1_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e7_pro_inf0) <= 1 || Engine.volume_test_objects(tv_e7_middle_section, Engine.players()), 15);
            Engine.ai_migrate(e7_pro_inf0, e7_pro_inf1_0.Squad);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e7_pro_inf) <= 2)
                {
                    await this.e7_pro_inf1_spawn();
                }

                return Engine.volume_test_objects(tv_e8_main_begin, Engine.players()) || (short)Engine.ai_spawn_count(e7_pro_inf1) >= 16;
            }, 15);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task e7_pro_inf0_main()
        {
            Engine.ai_place(e7_pro_inf0_0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 1F, 3F));
            Engine.ai_place(e7_pro_inf0_1.Squad);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task e7_cov_ghosts1_main()
        {
            Engine.ai_place(e7_cov_ghosts1.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e7_cov_ghosts0.Squad), 2F, 4F));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost1), true);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e7_grunts_unsafe, Engine.ai_actors(e7_pro_inf0))), 60);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost0), false);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e7_cov_ghosts1.ghost1), false);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task e7_cov_ghosts0_main()
        {
            Engine.ai_migrate(e6_cov, e7_cov_ghosts0.Squad);
            Engine.wake(new ScriptMethodReference(e7_cov_ghosts1_main));
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task e7_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e7_main_begin0, Engine.players()) || Engine.volume_test_objects(tv_e7_main_begin1, Engine.players()), 15);
            this.g_e7_started = true;
            Engine.print("e7_main");
            Engine.data_mine_set_mission_segment("e7_kidney0");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_08a_03_start));
            Engine.wake(new ScriptMethodReference(e8_main));
            Engine.wake(new ScriptMethodReference(e7_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e7_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e7_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e7_pro_inf2_main));
            await Engine.sleep_until(async () => this.g_e8_started);
            Engine.sleep_forever(new ScriptMethodReference(e7_cov_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e7_cov_ghosts1_main));
            Engine.sleep_forever(new ScriptMethodReference(e7_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e7_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e7_pro_inf2_main));
            await Engine.sleep_until(async () => this.g_e8_started);
            Engine.ai_disposable(e7_pro, true);
        }

        [ScriptMethod(143, Lifecycle.Static)]
        public async Task test_kidney0()
        {
            Engine.object_teleport(await this.player0(), e7_test);
            if (!(this.g_e7_started))
            {
                Engine.wake(new ScriptMethodReference(e7_main));
            }

            await Engine.sleep(1);
            Engine.drop("objects\\vehicles\\ghost\\ghost");
        }

        [ScriptMethod(144, Lifecycle.CommandScript)]
        public async Task cs_e6_weapon_scene()
        {
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0480"));
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task e6_weapon_scene()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("e6_weapon_scene", cs_e6_weapon_scene, e6_cov) || (short)Engine.ai_living_count(e6_pro_inf1.Squad) <= 0, 15, this.two_minutes);
            await Engine.sleep_until(async () => Engine.ai_scene("e6_weapon_scene", cs_e6_weapon_scene, e6_cov), 15, 300);
        }

        [ScriptMethod(146, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_phantom0_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p0"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p0_1"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p1"), Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p2"), 1F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p2"), 0.5F);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("e6_player_exited_onto_ledge", e6_pro_inf1.Squad) || this.g_e7_started || Engine.volume_test_objects(tv_e6_ledge0, Engine.players()) || Engine.volume_test_objects(tv_e6_ledge1, Engine.players()), 15);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get(this.ai_current_actor), true);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_a");
            await Engine.sleep(100);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_b");
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get(this.ai_current_actor), false);
            this.g_e6_pro_inf1_arrived = true;
            Engine.wake(new ScriptMethodReference(e6_weapon_scene));
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p3"), Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_entry/p2"));
        }

        [ScriptMethod(147, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_phantom0_exit()
        {
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_exit/p0"), Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_exit/p1"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e6_pro_phantom0_exit/p1"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(148, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_inf0_1_firing()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e6_pro_inf0_ambush/p0"));
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => Engine.device_get_position(e6_ghost_ledge_door.Entity) > 0F, 15);
            Engine.cs_enable_dialogue(true);
            await Engine.sleep(15);
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("e6_pro_inf0_ambush/p0"));
            Engine.cs_enable_targeting(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_on_ledge0, Engine.players()) || (float)Engine.ai_strength(this.ai_current_squad) < 0.95F, 10, 90);
            await Engine.sleep_until(async () => (float)Engine.ai_strength(this.ai_current_squad) < 0.95F, 10, 60);
        }

        [ScriptMethod(149, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_inf0_0_firing()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e6_pro_inf0_ambush/p0"));
            await Engine.sleep_until(async () => Engine.device_get_position(e6_ghost_ledge_door.Entity) > 0F, 15);
            Engine.cs_enable_dialogue(true);
            await Engine.sleep(15);
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("e6_pro_inf0_ambush/p0"));
            Engine.cs_enable_targeting(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_on_ledge0, Engine.players()) || (float)Engine.ai_strength(this.ai_current_squad) < 0.95F, 10, 90);
        }

        [ScriptMethod(150, Lifecycle.CommandScript)]
        public async Task cs_e6_pro_inf1_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e6_pro_inf1_entry/p0"));
            Engine.ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(151, Lifecycle.Static)]
        public async Task<bool> e6_pro_phantom0_should_retreat()
        {
            return Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e6_pro_phantom0.phantom0), "target_front") >= 3 || Engine.object_get_health(Engine.ai_vehicle_get(e6_pro_phantom0.phantom0)) <= 0.05F;
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task e6_objectives()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e6_pro_phantom0.Squad) > 0);
            await Engine.sleep_until(async () => await this.e6_pro_phantom0_should_retreat() || Engine.volume_test_objects(tv_e7_main_begin0, Engine.players()) || Engine.volume_test_objects(tv_e7_main_begin1, Engine.players()));
            Engine.wake(new ScriptMethodReference(objective1_clear));
            Engine.wake(new ScriptMethodReference(objective2_set));
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task e6_pro_phantom0_main()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(e6_ghost_ledge_door.Entity) > 0F, 15);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_on_ledge0, Engine.players()), 15, 210);
            Engine.ai_place(e6_pro_phantom0.Squad);
            await Engine.sleep_until(async () => this.g_e6_pro_inf1_arrived);
            await Engine.sleep_until(async () => this.g_e7_started || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e6_pro_phantom0.phantom0), "target_front") >= 3 || Engine.object_get_health(Engine.ai_vehicle_get(e6_pro_phantom0.phantom0)) <= 0.05F || this.g_e6_pro_inf1_arrived && (short)Engine.ai_living_count(e6_pro_inf1.Squad) <= 0);
            Engine.cs_run_command_script(e6_pro_phantom0.phantom0, cs_e6_pro_phantom0_exit);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task e6_pro_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_pro_inf1_begin, Engine.players()), 15);
            Engine.ai_place(e6_pro_inf1.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(e6_pro_inf0), 2F, 6F));
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task e6_pro_inf0_main()
        {
            Engine.ai_place(e6_pro_inf0);
            await Engine.sleep(6);
            Engine.objects_predict(Engine.ai_actors(e6_pro_inf0));
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task e6_cov_ghosts0_main()
        {
            Engine.ai_place(e6_cov_ghosts0.Squad);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e6_cov_ghosts0.ghost0), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e6_cov_ghosts0.ghost2), true);
            await Engine.sleep_until(async () => this.g_e6_pro_inf1_arrived);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e6_pro_inf0) <= 0 && (short)Engine.ai_living_count(e6_pro_inf1.Squad) <= 0 && (short)Engine.ai_spawn_count(e6_pro_inf1.Squad) > 0 || this.g_e7_started || await this.player_in_vehicle(), 30, this.two_minutes);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e6_cov_ghosts0.ghost0), false);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(e6_cov_ghosts0.ghost2), false);
            Engine.ai_migrate(e6_cov_inf0.Squad, e6_cov_ghosts0.Squad);
            Engine.ai_migrate(e6_cov_gold_elite.Squad, e6_cov_ghosts0.Squad);
            Engine.ai_enter_squad_vehicles(e6_cov_ghosts0.Squad);
            await Engine.sleep_until(async () => await this.player_in_vehicle());
            Engine.wake(new ScriptMethodReference(music_08a_03_start));
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task e6_cov_gold_elite_main()
        {
            Engine.ai_migrate(e5_cov_gold_elite.Squad, e6_cov_gold_elite.Squad);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e6_cov_gold_elite.Squad);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task e6_cov_inf1_main()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task e6_cov_grunts0_main()
        {
            Engine.ai_migrate(e5_cov_grunts0.Squad, e6_cov_grunts0.Squad);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e6_cov_grunts0.Squad);
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task e6_cov_inf0_main()
        {
            Engine.ai_migrate(e5_cov_inf0.Squad, e6_cov_inf0.Squad);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e6_cov_inf0.Squad);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task e6_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_main_begin, Engine.players()) && (short)Engine.structure_bsp_index() == 0, 15);
            this.g_e6_started = true;
            Engine.print("e6_main");
            Engine.data_mine_set_mission_segment("e6_ghost_ledge");
            Engine.game_save();
            Engine.device_operates_automatically_set(e6_ghost_ledge_door.Entity, true);
            Engine.wake(new ScriptMethodReference(chapter_title1));
            Engine.wake(new ScriptMethodReference(e7_main));
            Engine.wake(new ScriptMethodReference(e6_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e6_cov_gold_elite_main));
            Engine.wake(new ScriptMethodReference(e6_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e6_cov_grunts0_main));
            Engine.wake(new ScriptMethodReference(e6_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e6_pro_inf1_main));
            await Engine.sleep_until(async () => this.g_e7_started);
            Engine.ai_disposable(e6_pro, true);
            Engine.ai_disposable(e6_pro_phantom0.Squad, false);
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task test_ghost_ledge()
        {
            Engine.object_teleport(await this.player0(), e6_test);
            Engine.ai_place(e6_cov_inf0.Squad);
            Engine.ai_place(e6_cov_gold_elite.Squad);
            if (!(this.g_e6_started))
            {
                Engine.wake(new ScriptMethodReference(e6_main));
            }
        }

        [ScriptMethod(163, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_gold_elite_creep()
        {
            Engine.cs_enable_dialogue(true);
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e5_cov_gold_elite_creep/p0"));
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e5_pro_inf0.Squad) >= this.ai_combat_status_dangerous);
            await Engine.sleep(60);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e5_cov_gold_elite_creep/p1"));
            Engine.sleep_forever();
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_gold_elite_attack()
        {
            Engine.cs_crouch(false);
        }

        [ScriptMethod(165, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_grunts0_cower()
        {
            Engine.cs_movement_mode(this.ai_movement_flee);
            Engine.ai_disregard(this.ai_current_actor, true);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_pro) < 3 || (float)Engine.ai_strength(e5_cov_grunts0.Squad) <= 0.8F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 0.75F || this.g_e5_grunts_released >= 2, 15);
            this.g_e5_grunts_released = (short)(this.g_e5_grunts_released + 1);
            Engine.cs_enable_dialogue(true);
            Engine.cs_look_player(true);
            await Engine.sleep((short)Engine.random_range(15, 45));
            Engine.ai_disregard(this.ai_current_actor, false);
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task e5_pro_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_exit, Engine.players()) || (short)Engine.ai_living_count(e5_pro_inf0.Squad) <= 3 && (short)Engine.ai_spawn_count(e5_pro_inf0.Squad) > 0, 20);
            Engine.ai_place(e5_pro_inf1.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 1F, 4F));
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task e5_pro_inf0_main()
        {
            Engine.ai_place(e5_pro_inf0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 2F, 6F));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(e5_pro_inf0.turret0), true);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task e5_cov_grunts0_main()
        {
            Engine.ai_place(e5_cov_grunts0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(covenant1) + (float)Engine.ai_living_count(prophets), 1F, 5F));
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task e5_cov_gold_elite_main()
        {
            Engine.ai_migrate(e4_cov_gold_elite.Squad, e5_cov_gold_elite.Squad);
            Engine.ai_renew(e5_cov_gold_elite.Squad);
            Engine.cs_run_command_script(e5_cov_gold_elite.Squad, cs_e5_cov_gold_elite_creep);
            await Engine.sleep_until(async () => (float)Engine.ai_strength(e5_cov_gold_elite.Squad) < 1F || (float)Engine.ai_strength(e5_pro_inf0.Squad) < 0.5F || Engine.volume_test_objects(tv_e5_lower_level, Engine.players()), 5);
            Engine.cs_run_command_script(e5_cov_gold_elite.Squad, cs_e5_cov_gold_elite_attack);
            Engine.ai_set_orders(e5_cov_gold_elite.Squad, e5_cov_gold_elite_killomatic);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task e5_cov_inf0_main()
        {
            Engine.ai_migrate(e4_cov_inf0.Squad, e5_cov_inf0.Squad);
            Engine.ai_renew(e5_cov_inf0.Squad);
            Engine.wake(new ScriptMethodReference(e5_cov_grunts0_main));
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task e5_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_main_begin, Engine.players()), 15);
            this.g_e5_started = true;
            Engine.print("e5_main");
            Engine.data_mine_set_mission_segment("e5_ramp_room1");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e5_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e5_cov_gold_elite_main));
            Engine.wake(new ScriptMethodReference(e5_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e5_pro_inf1_main));
            await Engine.sleep_until(async () => this.g_e6_started);
            Engine.sleep_forever(new ScriptMethodReference(e5_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_cov_gold_elite_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_pro_inf1_main));
            Engine.ai_disposable(e5_pro, true);
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task test_ramp_room2()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e5_test);
            Engine.ai_place(e5_cov_inf0.Squad);
            Engine.ai_place(e5_cov_gold_elite.Squad);
            if (!(this.g_e5_started))
            {
                Engine.wake(new ScriptMethodReference(e5_main));
            }

            if (!(this.g_e6_started))
            {
                Engine.wake(new ScriptMethodReference(e6_main));
            }
        }

        [ScriptMethod(173, Lifecycle.CommandScript)]
        public async Task cs_e4_alarm_scene()
        {
            Engine.cs_switch("brute0");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0450"));
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_alarm_scene/p0"));
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0400"));
            await Engine.sleep((short)((float)Engine.ai_play_line(this.ai_current_actor, "0440") - 30));
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task e4_pro_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_first_step, Engine.players()), 15);
            Engine.ai_place(e4_pro_inf2_0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 1F, 4F));
            await Engine.sleep(150);
            await Engine.sleep_until(async () => Engine.ai_scene("e4_alarm_scene", cs_e4_alarm_scene, e4_pro_inf0) || (short)Engine.ai_living_count(e4_pro_inf2_0.Squad) <= 0, 15);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task e4_pro_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_second_step, Engine.players()), 15);
            Engine.game_save();
            await Engine.sleep(15);
            Engine.ai_place(e4_pro_inf1.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 1F, 4F));
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task e4_pro_inf0_main()
        {
            Engine.ai_place(e4_pro_inf0_0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(prophets), 1F, 5F));
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task e4_cov_gold_elite_main()
        {
            Engine.ai_migrate(e3_cov_gold_elite.Squad, e4_cov_gold_elite.Squad);
            Engine.ai_renew(e4_cov_gold_elite.Squad);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task e4_cov_inf0_main()
        {
            Engine.ai_migrate(e3_cov_inf0.Squad, e4_cov_inf0.Squad);
            Engine.ai_renew(e4_cov_inf0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_first_step, Engine.players()), 15);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_ground_floor_exit, Engine.players()) || (short)Engine.ai_fighting_count(e4_pro) <= 2, 15);
            Engine.device_operates_automatically_set(e4_door0.Entity, true);
            Engine.ai_place(e4_cov_inf0.Squad, (short)Engine.pin(3F - (float)Engine.ai_living_count(covenant1), 1F, 3F));
            Engine.ai_set_orders(e4_cov_inf0.Squad, e4_cov_inf0_advance2);
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task e4_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_pre_main, Engine.players()), 15);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_main_begin, Engine.players()), 15);
            this.g_e4_started = true;
            Engine.print("e4_main");
            Engine.data_mine_set_mission_segment("e4_step_room");
            Engine.wake(new ScriptMethodReference(e5_main));
            Engine.wake(new ScriptMethodReference(e4_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e4_cov_gold_elite_main));
            Engine.wake(new ScriptMethodReference(e4_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e4_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e4_pro_inf2_main));
            await Engine.sleep_until(async () => this.g_e5_started);
            Engine.sleep_forever(new ScriptMethodReference(e4_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_cov_gold_elite_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_pro_inf2_main));
            Engine.ai_disposable(e4_pro, true);
        }

        [ScriptMethod(180, Lifecycle.CommandScript)]
        public async Task cs_e3_alarm_scene()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_alarm_scene/p0"));
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0410"));
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0440"));
        }

        [ScriptMethod(181, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_grunts0_cower()
        {
            Engine.cs_movement_mode(this.ai_movement_flee);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("generic_player_within_2wu", this.ai_current_squad) && !(Engine.volume_test_objects(tv_e3_lower_level, Engine.ai_actors(e3_pro_inf0))) || (float)Engine.ai_strength(this.ai_current_squad) <= 0.5F);
            Engine.cs_look_player(true);
            Engine.print("grunt scene");
            Engine.ai_play_line_at_player(this.ai_current_actor, "0460") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.sleep_forever();
        }

        [ScriptMethod(182, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_gold_elite_charge()
        {
            Engine.cs_enable_dialogue(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_sword_elites/p0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_sword_elites/p1"));
            Engine.cs_jump(10F, 4F);
        }

        [ScriptMethod(183, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_stealth_major_charge()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.ai_set_active_camo(this.ai_current_actor, true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_sword_elites/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_sword_elites/p3"));
            Engine.ai_set_active_camo(this.ai_current_actor, false);
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task e3_pro_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(e3_exit_door.Entity) > 0F && Engine.volume_test_objects(tv_e3_near_exit, Engine.players()), 15);
            Engine.ai_place(e3_pro_inf1.Squad);
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task e3_pro_inf0_main()
        {
            await Engine.sleep(5);
            Engine.ai_place(e3_pro_inf0_0.Squad);
            Engine.ai_place(e3_pro_inf0_1.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(prophets), 1F, 4F));
            await Engine.sleep_until(async () => Engine.ai_scene("e3_alarm_scene", cs_e3_alarm_scene, e3_pro_inf0) || (short)Engine.ai_living_count(e3_pro_inf0) <= 0, 15);
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task e3_cov_grunts0_main()
        {
            Engine.ai_place(e3_cov_grunts0.Squad);
            Engine.ai_disregard(Engine.ai_actors(e3_cov_grunts0.Squad), true);
            Engine.cs_run_command_script(e3_cov_grunts0.Squad, cs_e3_cov_grunts0_cower);
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task e3_cov_gold_elite_main()
        {
            Engine.ai_migrate(e2_cov_gold_elite.Squad, e3_cov_gold_elite.Squad);
            Engine.ai_renew(e3_cov_gold_elite.Squad);
            Engine.cs_run_command_script(e3_cov_gold_elite.Squad, cs_e3_cov_gold_elite_charge);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task e3_cov_inf0_main()
        {
            Engine.ai_migrate(e2_cov_inf0.Squad, e3_cov_inf0.Squad);
            Engine.ai_renew(e3_cov_inf0.Squad);
            Engine.cs_run_command_script(Engine.object_get_ai(this.g_cov_stealth_major), cs_e3_cov_stealth_major_charge);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task e3_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e3_main_begin, Engine.players()), 15);
            this.g_e3_started = true;
            Engine.print("e3_main");
            Engine.data_mine_set_mission_segment("e3_ramp_room0");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e4_main));
            Engine.wake(new ScriptMethodReference(e3_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e3_cov_gold_elite_main));
            Engine.wake(new ScriptMethodReference(e3_cov_grunts0_main));
            Engine.wake(new ScriptMethodReference(e3_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e3_pro_inf1_main));
            await Engine.sleep_until(async () => this.g_e4_started);
            Engine.sleep_forever(new ScriptMethodReference(e3_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_cov_gold_elite_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_cov_grunts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_pro_inf1_main));
            Engine.ai_disposable(e3_pro, true);
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task test_ramp_room1()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e3_test);
            Engine.ai_place(e3_cov_inf0.Squad);
            this.g_cov_stealth_major = Engine.ai_get_unit(e3_cov_inf0.stealth_major);
            Engine.ai_place(e3_cov_gold_elite.Squad);
            if (!(this.g_e3_started))
            {
                Engine.wake(new ScriptMethodReference(e3_main));
            }
        }

        [ScriptMethod(191, Lifecycle.CommandScript)]
        public async Task cs_e2_alarm_scene()
        {
            Engine.cs_switch("brute0");
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0420"));
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0430"));
            Engine.cs_enable_dialogue(true);
            Engine.cs_switch("brute1");
            Engine.cs_enable_moving(false);
            Engine.cs_enable_targeting(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_alarm_scene/p0"));
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(e2_antennae.Entity) <= 0F, 5);
            Engine.cs_enable_targeting(false);
            if (Engine.object_get_health(e2_antennae.Entity) > 0F)
            {
                Engine.cs_face_object(true, e2_antennae.Entity);
                Engine.print("brute1 operates the antennae");
                await Engine.sleep_until(async () => Engine.object_get_health(e2_antennae.Entity) <= 0F, 5, 60);
                if (Engine.object_get_health(e2_antennae.Entity) > 0F)
                {
                    this.g_brute_alarm_level = (short)(this.g_brute_alarm_level + 1);
                }
                else
                {
                    Engine.print("brute1 growls");
                    await Engine.sleep(20);
                }
            }
            else
            {
                Engine.print("brute1 growls");
                await Engine.sleep(20);
            }
        }

        [ScriptMethod(192, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_grunts0_flee()
        {
            Engine.cs_enable_dialogue(true);
            Engine.cs_face_player(true);
            await Engine.sleep((short)Engine.random_range(0, 60));
            Engine.cs_face_player(false);
            Engine.cs_movement_mode(this.ai_movement_flee);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.ai_renew(this.ai_current_actor), 
                    async () => Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_cov_grunts_flee/p0")), 
                    async () => await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) < 1F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => Engine.ai_renew(this.ai_current_actor), 
                    async () => Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_cov_grunts_flee/p1")), 
                    async () => await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) < 1F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => Engine.ai_renew(this.ai_current_actor), 
                    async () => Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_cov_grunts_flee/p2")), 
                    async () => await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) < 1F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => Engine.ai_renew(this.ai_current_actor), 
                    async () => Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_cov_grunts_flee/p3")), 
                    async () => await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) < 1F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => Engine.ai_renew(this.ai_current_actor), 
                    async () => Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_cov_grunts_flee/p4")), 
                    async () => await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) < 1F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 1F, 5), 
                    async () => Engine.ai_renew(this.ai_current_actor), 
                    async () => Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_cov_grunts_flee/p5")), 
                    async () => await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) < 1F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 1F, 5));
                return Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 1F;
            });
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), false);
            Engine.ai_migrate(this.ai_current_actor, e2_cov_inf0.Squad);
        }

        [ScriptMethod(193, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_grunts0_abort()
        {
            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 2F)
            {
                Engine.cs_crouch(true);
            }
            else
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 4F);
            }
        }

        [ScriptMethod(194, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_gold_elite_charge0()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_looking(false);
            Engine.ai_play_line(this.ai_current_actor, "0370") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e2_sword_elites/p0"));
            Engine.cs_enable_dialogue(true);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_sword_elites/p1"));
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.objects_distance_to_object(Engine.ai_actors(e2_pro_inf0.Squad), Engine.ai_get_object(this.ai_current_actor)) <= 2F);
        }

        [ScriptMethod(195, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_stealth_elite_charge0()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_looking(false);
            Engine.ai_renew(this.ai_current_actor);
            Engine.ai_set_active_camo(this.ai_current_actor, true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e2_sword_elites/p2"));
            Engine.cs_crouch(true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e2_sword_elites/p1"));
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e2_sword_elites/p3"));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.ai_actors(e2_pro_inf0.Squad), Engine.ai_get_object(this.ai_current_actor)) <= 2F || (float)Engine.ai_strength(this.ai_current_actor) <= 0.75F || (short)Engine.ai_living_count(e2_pro_inf0.Squad) <= 1);
            Engine.ai_set_active_camo(this.ai_current_actor, false);
        }

        [ScriptMethod(196, Lifecycle.Static)]
        public async Task e2_cov_sword_elites_charge0()
        {
            Engine.cs_run_command_script(e2_cov_gold_elite.Squad, cs_e2_cov_gold_elite_charge0);
            Engine.cs_run_command_script(Engine.object_get_ai(this.g_cov_stealth_major), cs_e2_cov_stealth_elite_charge0);
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task e2_alarm_scene()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e2_pro_inf0.Squad) >= this.ai_combat_status_visible, 15);
            await Engine.sleep_until(async () => Engine.ai_scene("e2_alarm_scene", cs_e2_alarm_scene, e2_pro_inf0.Squad), 15, 300);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task e2_pro_inf3_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e2_pro_inf1.Squad) > 0 && (short)Engine.ai_living_count(e2_pro_inf1.Squad) <= 0 || Engine.volume_test_objects(tv_e2_pro_inf3_begin, Engine.players()));
            Engine.ai_place(e2_pro_inf3.Squad, (short)Engine.pin(9F - (float)Engine.ai_living_count(prophets), 2F, 6F));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_pro_inf3.Squad) <= 0 && (bool)Engine.game_safe_to_save());
            Engine.game_save();
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task e2_pro_inf2_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_pro_inf0.Squad) <= 2 || Engine.volume_test_objects(tv_e2_pro_inf1_begin, Engine.players()));
            Engine.ai_place(e2_pro_inf2.Squad);
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task e2_pro_inf1_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_pro_inf0.Squad) <= 0 || Engine.volume_test_objects(tv_e2_pro_inf1_begin, Engine.players()));
            Engine.game_save();
            await Engine.sleep(15);
            Engine.ai_place(e2_pro_inf1.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(e2_pro_inf0.Squad), 0F, 4F));
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task e2_pro_inf0_main()
        {
            Engine.ai_place(e2_pro_inf0.Squad);
            Engine.wake(new ScriptMethodReference(e2_alarm_scene));
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task e2_cov_grunts0_main()
        {
            Engine.ai_place(e2_cov_grunts0.Squad);
            Engine.ai_disregard(Engine.ai_actors(e2_cov_grunts0.Squad), true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("generic_player_sighted", e2_cov_grunts0.Squad), 5);
            await Engine.sleep(Engine.ai_play_line_at_player(e2_cov_grunts0.grunt0, "0330"));
            Engine.cs_run_command_script(e2_cov_grunts0.Squad, cs_e2_cov_grunts0_flee);
            await Engine.sleep(300);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_pro) <= 4 && (short)Engine.ai_fighting_count(e2_pro) <= 0);
            Engine.cs_run_command_script(e2_cov_grunts0.Squad, cs_e2_cov_grunts0_abort);
            Engine.ai_disregard(Engine.ai_actors(e2_cov_grunts0.Squad), false);
            Engine.ai_migrate(e2_cov_grunts0.Squad, e2_cov_inf0.Squad);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task e2_cov_gold_elite_main()
        {
            await Engine.sleep_until(async () => this.g_e2_safe_to_migrate_inf2);
            Engine.ai_migrate(e1_cov_inf2.gold_elite, e2_cov_gold_elite.Squad);
            Engine.ai_migrate(e1_cov_inf2.Squad, e2_cov_inf0.Squad);
            await Engine.sleep(5);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e2_cov_inf0.Squad);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e2_cov_gold_elite.Squad);
            Engine.ai_renew(e2_cov_gold_elite.Squad);
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task e2_cov_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_pro_inf1_begin, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_08a_02_stop));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_cov) <= 1);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e2_cov_inf1_unsafe, Engine.players())), 15);
            Engine.ai_place(e2_cov_inf1.Squad);
            Engine.ai_migrate(e2_cov_inf1.Squad, e2_cov_inf0.Squad);
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task e2_cov_inf0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_inf1.Squad) > 0);
            Engine.ai_migrate(e1_cov_inf1.Squad, e2_cov_inf0.Squad);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1, 15);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e2_cov_inf0.Squad);
            Engine.ai_renew(e2_cov_inf0.Squad);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task e2_main()
        {
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1, 15);
            this.g_e2_started = true;
            Engine.print("e2_main");
            Engine.data_mine_set_mission_segment("e2_cylinder_room");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_08a_01_stop));
            Engine.wake(new ScriptMethodReference(music_08a_02_start));
            Engine.wake(new ScriptMethodReference(e3_main));
            Engine.wake(new ScriptMethodReference(e2_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e2_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e2_cov_gold_elite_main));
            Engine.wake(new ScriptMethodReference(e2_cov_grunts0_main));
            Engine.wake(new ScriptMethodReference(e2_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e2_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e2_pro_inf2_main));
            Engine.wake(new ScriptMethodReference(e2_pro_inf3_main));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_main_end, Engine.players()), 15);
            Engine.sleep_forever(new ScriptMethodReference(e2_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_cov_gold_elite_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_cov_grunts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_pro_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_pro_inf3_main));
            Engine.ai_disposable(e2_pro, true);
        }

        [ScriptMethod(207, Lifecycle.Static)]
        public async Task test_cylinder_room()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e2_test);
            Engine.ai_place(e2_cov_inf0.Squad);
            this.g_cov_stealth_major = Engine.ai_get_unit(e2_cov_inf0.stealth_major);
            Engine.ai_place(e2_cov_gold_elite.Squad);
            if (!(this.g_e2_started))
            {
                Engine.wake(new ScriptMethodReference(e2_main));
            }
        }

        [ScriptMethod(208, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_inf0_0_patrol0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_uninspected);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p0"));
            Engine.cs_aim_object(true, e1_elite0.Entity);
            Engine.ai_play_line_at_player(this.ai_current_actor, "0230") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(15);
            Engine.cs_aim_object(false, e1_elite0.Entity);
            Engine.cs_shoot(true, e1_elite0.Entity);
            await Engine.sleep(30);
            Engine.cs_shoot(false, e1_elite0.Entity);
            await Engine.sleep((short)Engine.random_range(30, 60));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p1"));
            Engine.cs_aim_object(true, e1_elite1.Entity);
            await Engine.sleep((short)Engine.random_range(60, 90));
            Engine.cs_aim_object(false, e1_elite1.Entity);
            Engine.cs_shoot(true, e1_elite1.Entity);
            await Engine.sleep(30);
            Engine.cs_shoot(false, e1_elite1.Entity);
            await Engine.sleep((short)Engine.random_range(30, 60));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p2"));
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p2_look0"));
            await Engine.sleep((short)Engine.random_range(45, 75));
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p2_look1"));
            await Engine.sleep((short)Engine.random_range(60, 90));
            Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p2_look1"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p3"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p3_look0"));
            await Engine.sleep((short)Engine.random_range(210, 300));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_0_patrol/p3_look1"));
        }

        [ScriptMethod(209, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_inf0_1_patrol0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_uninspected);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p0"));
            await Engine.sleep(30);
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 4042723031U), "patrol:any:any:posing:var1", true);
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0240"));
            await Engine.sleep(25);
            Engine.ai_play_line(e1_pro_inf0_1_1.brute0, "0250") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep((short)Engine.random_range(90, 120));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1"));
            Engine.cs_aim_object(true, e1_elite2.Entity);
            await Engine.sleep((short)Engine.random_range(60, 90));
            Engine.cs_aim_object(false, e1_elite2.Entity);
            Engine.cs_shoot(true, e1_elite2.Entity);
            await Engine.sleep(30);
            Engine.cs_shoot(false, e1_elite2.Entity);
            await Engine.sleep((short)Engine.random_range(30, 60));
            if ((short)Engine.ai_living_count(e1_pro_inf0_0.Squad) > 0)
            {
                await Engine.sleep(Engine.ai_play_line(e1_pro_inf0_0.brute0, "0260"));
                Engine.ai_play_line(e1_pro_inf0_1.brute0, "0270") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }

            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1_look0"));
            await Engine.sleep((short)Engine.random_range(60, 90));
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1_look0"));
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p2"));
                Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p2_look0"));
                await Engine.sleep((short)Engine.random_range(210, 300));
                Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p2_look0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1"));
                Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1_look0"));
                await Engine.sleep((short)Engine.random_range(210, 300));
                Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e1_pro_inf0_1_patrol/p1_look0"));
                return false;
            });
        }

        [ScriptMethod(210, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_inf0_1_patrol1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_uninspected);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_2_patrol/p0"));
            Engine.cs_aim_object(true, e1_elite3.Entity);
            await Engine.sleep((short)Engine.random_range(60, 90));
            Engine.cs_aim_object(false, e1_elite3.Entity);
            Engine.cs_shoot(true, e1_elite3.Entity);
            await Engine.sleep(30);
            Engine.cs_shoot(false, e1_elite3.Entity);
            await Engine.sleep((short)Engine.random_range(30, 60));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_inf0_2_patrol/p1"));
            Engine.cs_aim_object(true, e1_elite4.Entity);
            await Engine.sleep((short)Engine.random_range(60, 90));
            Engine.cs_aim_object(false, e1_elite4.Entity);
            Engine.cs_shoot(true, e1_elite4.Entity);
            await Engine.sleep(30);
            Engine.cs_shoot(false, e1_elite4.Entity);
            await Engine.sleep((short)Engine.random_range(30, 60));
            Engine.cs_aim_object(true, e1_elite5.Entity);
            await Engine.sleep((short)Engine.random_range(90, 120));
            Engine.cs_aim_object(false, e1_elite4.Entity);
            Engine.cs_shoot(true, e1_elite4.Entity);
            await Engine.sleep(30);
            Engine.cs_shoot(false, e1_elite4.Entity);
            await Engine.sleep((short)Engine.random_range(30, 60));
        }

        [ScriptMethod(211, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_scene()
        {
            Engine.custom_animation_loop(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3979873048U), "combat:unarmed:mortal_wound", false);
            Engine.unit_set_maximum_vitality(Engine.ai_get_unit(this.ai_current_actor), 5F, 0F);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 3F);
            Engine.cs_look_player(true);
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0200"));
            await Engine.sleep(45);
            this.g_e1_cov_inf0_should_die = true;
            Engine.unit_stop_custom_animation(Engine.ai_get_unit(this.ai_current_actor));
            Engine.sleep_forever();
        }

        [ScriptMethod(212, Lifecycle.CommandScript)]
        public async Task cs_e1_stealth_major_scene()
        {
            Engine.ai_set_active_camo(this.ai_current_actor, false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_watch_pods/p1"));
            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 5F)
            {
                Engine.cs_look_player(true);
            }
            else
            {
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e1_zealot/p1"));
            }

            Engine.print("stealth: by the prophets...");
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3979873048U), "combat:sword:posing:var1", true);
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0300"));
            await Engine.sleep(20);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 5F, 10, 450);
            Engine.cs_face_player(true);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.ai_get_object(this.ai_current_actor), await this.player0(), 10F) || (bool)Engine.game_is_cooperative() && Engine.objects_can_see_object(Engine.ai_get_object(this.ai_current_actor), await this.player1(), 10F), 1, 30);
            Engine.print("stealth: they have shed our brother's blood...");
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3979873048U), "combat:sword:posing:var4", true);
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0310"));
            Engine.wake(new ScriptMethodReference(music_08a_02_start));
            this.g_e1_stealth_major_done = true;
            Engine.sleep_forever();
        }

        [ScriptMethod(213, Lifecycle.CommandScript)]
        public async Task cs_e1_watch_pods()
        {
            await Engine.sleep(15);
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("e1_watch_pods/p0"));
            Engine.cs_look_object(true, Engine.ai_vehicle_get(e1_cov_inf2.gold_elite));
            Engine.cs_face_object(true, Engine.ai_vehicle_get(e1_cov_inf2.gold_elite));
            await Engine.sleep_until(async () => this.g_e1_zealot_revealed, 10);
            Engine.print("stealth: a zealot? so much for stealth...");
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0320"));
        }

        [ScriptMethod(214, Lifecycle.CommandScript)]
        public async Task cs_e1_zealot_intro()
        {
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e1_zealot/p0"));
            await Engine.sleep(25);
            Engine.ai_play_line(this.ai_current_actor, "0330") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.print("zealot: over so soon? bah");
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e1_zealot/p1"));
            await Engine.sleep(30);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task e1_pod0_insertion()
        {
            Engine.ai_place(e1_cov_inf2.gold_elite);
            Engine.object_create(e1_pod0_inserter);
            Engine.objects_attach(e1_pod0_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e1_cov_inf2.gold_elite), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e1_pod0_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e1_pod0_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e1_pod_impact_effect, Engine.ai_vehicle_get(e1_cov_inf2.gold_elite), "pod_attach");
            Engine.objects_detach(e1_pod0_inserter.Entity, Engine.ai_vehicle_get(e1_cov_inf2.gold_elite));
            Engine.object_destroy(e1_pod0_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            this.g_e1_zealot_revealed = true;
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.ai_vehicle_exit(e1_cov_inf2.gold_elite);
            await Engine.sleep(10);
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e1_cov_inf2.gold_elite), "door", 500F);
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task e1_pod1_insertion()
        {
            Engine.ai_place(e1_cov_inf2.elite1);
            Engine.object_create(e1_pod1_inserter);
            Engine.objects_attach(e1_pod1_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e1_cov_inf2.elite1), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e1_pod1_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e1_pod1_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e1_pod_impact_effect, Engine.ai_vehicle_get(e1_cov_inf2.elite1), "pod_attach");
            Engine.objects_detach(e1_pod1_inserter.Entity, Engine.ai_vehicle_get(e1_cov_inf2.elite1));
            Engine.object_destroy(e1_pod1_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.ai_vehicle_exit(e1_cov_inf2.elite1);
            await Engine.sleep(10);
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e1_cov_inf2.elite1), "door", 500F);
        }

        [ScriptMethod(217, Lifecycle.Dormant)]
        public async Task e1_pod2_insertion()
        {
            Engine.ai_place(e1_cov_inf2.elite2);
            Engine.object_create(e1_pod2_inserter);
            Engine.objects_attach(e1_pod2_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e1_cov_inf2.elite2), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e1_pod2_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e1_pod2_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e1_pod_impact_effect, Engine.ai_vehicle_get(e1_cov_inf2.elite2), "pod_attach");
            Engine.objects_detach(e1_pod2_inserter.Entity, Engine.ai_vehicle_get(e1_cov_inf2.elite2));
            Engine.object_destroy(e1_pod2_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.ai_vehicle_exit(e1_cov_inf2.elite2);
            await Engine.sleep(10);
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e1_cov_inf2.elite2), "door", 500F);
            await Engine.sleep(30);
            this.g_e2_safe_to_migrate_inf2 = true;
        }

        [ScriptMethod(218, Lifecycle.Dormant)]
        public async Task e1_objectives()
        {
            await Engine.sleep(150);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_inf0.Squad) <= 0 || (short)Engine.ai_combat_status(e1_pro) > this.ai_combat_status_active, 30, this.one_minute);
            Engine.wake(new ScriptMethodReference(objective0_set));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_inf2.Squad) > 0, 15);
            await Engine.sleep(150);
            Engine.wake(new ScriptMethodReference(objective0_clear));
            Engine.wake(new ScriptMethodReference(objective1_set));
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task e1_guns_aux()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_area_entrance, Engine.players()), 15);
            Engine.object_create(e1_gun4);
            await Engine.sleep(1);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun4"), 0, true);
            await Engine.sleep(10);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun4"), 0, false);
            await Engine.sleep(1);
            Engine.object_destroy(e1_gun4.Entity);
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task e1_guns()
        {
            Engine.wake(new ScriptMethodReference(e1_guns_aux));
            Engine.object_create(e1_gun0);
            Engine.object_create(e1_gun1);
            await Engine.sleep(1);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun0"), 0, true);
            await Engine.sleep(5);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun0"), 0, false);
            Engine.object_destroy(e1_gun0.Entity);
            await Engine.sleep(15);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun1"), 0, true);
            await Engine.sleep(5);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun1"), 0, false);
            await Engine.sleep(1);
            Engine.object_destroy(e1_gun1.Entity);
            await Engine.sleep(90);
            Engine.object_create(e1_gun2);
            await Engine.sleep(1);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun2"), 0, true);
            await Engine.sleep(15);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun2"), 0, false);
            await Engine.sleep(1);
            Engine.object_destroy(e1_gun2.Entity);
            await Engine.sleep(60);
            Engine.object_create(e1_gun3);
            await Engine.sleep(1);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun3"), 0, true);
            await Engine.sleep(30);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun3"), 0, false);
            await Engine.sleep(90);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun3"), 0, true);
            await Engine.sleep(20);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e1_gun3"), 0, false);
            await Engine.sleep(1);
            Engine.object_destroy(e1_gun3.Entity);
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task e1_music_aux()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_third_wall, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_08a_01_start_alt));
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task e1_pro_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_second_wall, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e1_music_aux));
            Engine.ai_place(e1_pro_inf1.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e1_pro_inf1.Squad) >= this.ai_combat_status_clear_los || (short)Engine.ai_living_count(e1_pro_inf1.Squad) <= 0, 30, this._30_seconds);
            Engine.print("alerted");
            if ((short)Engine.ai_combat_status(e1_pro_inf1.Squad) >= this.ai_combat_status_clear_los)
            {
                this.g_e1_pro_inf1_was_alerted = true;
            }

            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e1_pro_inf1.Squad) <= this.ai_combat_status_active, 10);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e1_pro_inf1.Squad) <= this.ai_combat_status_alert, 10, 240);
            Engine.print("alerted");
            if ((short)Engine.ai_living_count(e1_pro_inf1.Squad) > 0 && (short)Engine.ai_living_count(e1_pro_inf0) > 0)
            {
                if (this.g_e1_pro_inf1_was_alerted)
                {
                    Engine.print("cpn: he's just an elite--kill him!");
                    Engine.ai_play_line(e1_pro_inf1.brute0, "0290") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                    await Engine.sleep(20);
                    Engine.custom_animation(Engine.ai_get_unit(e1_pro_inf1.brute0), Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 4042723031U), "combat:support:hold", true);
                    await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                }
                else
                {
                    Engine.ai_play_line(e1_pro_inf1.brute0, "0280") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                }

                await Engine.sleep(30);
                Engine.ai_set_orders(e1_pro_inf0, e1_pro_inf0_search);
                this.g_e1_pro_inf0_searching = true;
            }
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task e1_pro_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_pro_inf0_begin, Engine.players()), 15);
            Engine.ai_place(e1_pro_inf0_0.Squad);
            Engine.ai_place(e1_pro_inf0_1.Squad);
            Engine.ai_place(e1_pro_inf0_1_1.Squad);
            Engine.cs_run_command_script(e1_pro_inf0_0.Squad, cs_e1_pro_inf0_0_patrol0);
            Engine.cs_run_command_script(e1_pro_inf0_1.brute0, cs_e1_pro_inf0_1_patrol0);
            Engine.cs_run_command_script(e1_pro_inf0_1_1.brute0, cs_e1_pro_inf0_1_patrol1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_pro_inf0) <= 0 || Engine.volume_test_objects(tv_e1_second_wall, Engine.players()), 15);
            await Engine.sleep(15);
            Engine.ai_place(e1_pro_inf0_2.Squad);
            Engine.ai_place(e1_pro_inf0_3.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_pro_inf0) <= 0, 15);
            Engine.game_save();
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task e1_cov_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_exit, Engine.players()), 15);
            await Engine.sleep_until(async () => this.g_e1_stealth_major_done || (short)Engine.ai_spawn_count(e1_cov_inf1.Squad) > 0 && (short)Engine.ai_living_count(e1_cov_inf1.Squad) <= 0);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.wake(new ScriptMethodReference(e1_pod0_insertion));
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(e1_pod1_insertion));
            await Engine.sleep(15);
            Engine.wake(new ScriptMethodReference(e1_pod2_insertion));
            await Engine.sleep_until(async () => !(Engine.unit_in_vehicle(Engine.ai_get_unit(e1_cov_inf2.gold_elite))), 15);
            await Engine.sleep(15);
            if ((short)Engine.ai_living_count(e1_pro) <= 0)
            {
                Engine.cs_run_command_script(e1_cov_inf2.gold_elite, cs_e1_zealot_intro);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_exit, Engine.ai_get_object(e1_cov_inf2.gold_elite)), 15);
            if (Engine.volume_test_objects(tv_e1_ledge, Engine.players()))
            {
                Engine.print("zlt: there are brutes to kill!");
                Engine.ai_play_line(e1_cov_inf2.gold_elite, "0340") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
            else
            {
                Engine.print("zlt: wait up!");
                Engine.ai_play_line(e1_cov_inf2.gold_elite, "0350") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task e1_cov_inf1_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_pro_inf1.Squad) > 0 && (short)Engine.ai_living_count(e1_pro_inf0) <= 0 || Engine.volume_test_objects(tv_e1_exit, Engine.players()), 15);
            Engine.ai_place(e1_cov_inf1.Squad);
            this.g_cov_stealth_major = Engine.ai_get_unit(e1_cov_inf1.stealth_major);
            await Engine.sleep_until(async () => Engine.ai_scene("e1_stealth_major_scene", cs_e1_stealth_major_scene, e1_cov_inf1.Squad) || (short)Engine.ai_spawn_count(e1_cov_inf2.Squad) > 0, 10);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_pro) <= 0 && (short)Engine.ai_spawn_count(e1_cov_inf2.Squad) > 0, 5);
            Engine.cs_run_command_script(e1_cov_inf1.Squad, cs_e1_watch_pods);
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task e1_cov_inf0_main()
        {
            Engine.ai_place(e1_cov_inf0.Squad);
            Engine.ai_disregard(Engine.ai_actors(e1_cov_inf0.Squad), true);
            this.g_e1_wounded_elite = Engine.ai_get_unit(e1_cov_inf0.Squad);
            Engine.unit_kill(this.g_e1_wounded_elite);
            await Engine.sleep(13);
            Engine.biped_ragdoll(this.g_e1_wounded_elite);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3921086529U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3921086529U)), 10, this.one_minute);
            await Engine.sleep(20);
            Engine.print("corpse: the brutes...");
            await Engine.sleep(Engine.ai_play_line_on_object(this.g_e1_wounded_elite, "0200"));
            await Engine.sleep(30);
            Engine.game_save();
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task e1_main()
        {
            this.g_e1_started = true;
            Engine.print("e1_main");
            Engine.data_mine_set_mission_segment("e1_stealthy_insertion");
            Engine.wake(new ScriptMethodReference(e2_main));
            Engine.wake(new ScriptMethodReference(e1_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e1_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e1_cov_inf2_main));
            Engine.wake(new ScriptMethodReference(e1_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e1_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e1_objectives));
            Engine.wake(new ScriptMethodReference(e1_guns));
            await Engine.sleep_until(async () => this.g_e2_started);
            Engine.ai_disposable(e1_pro, true);
            await Engine.sleep_until(async () => this.g_e3_started);
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_objectives));
            Engine.sleep_forever(new ScriptMethodReference(e1_guns));
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            Engine.sound_class_set_gain("amb", 1F, 5);
            Engine.wake(new ScriptMethodReference(music_08a_01_start));
            await Engine.sleep(2);
            Engine.object_cannot_take_damage(Engine.players());
            Engine.object_hide(await this.player0(), true);
            Engine.object_hide(await this.player1(), true);
            await this.cinematic_snap_to_white();
            await this.cinematic_intro();
            Engine.object_teleport(await this.player0(), player0_start);
            Engine.object_teleport(await this.player1(), player1_start);
            Engine.object_hide(await this.player0(), false);
            Engine.object_hide(await this.player1(), false);
            Engine.object_can_take_damage(Engine.players());
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(new ScriptMethodReference(chapter_title0));
            Engine.wake(new ScriptMethodReference(e1_main));
            Engine.wake(new ScriptMethodReference(e6_main));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mission_end, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_08a_05_start));
            await this.playtest_mission();
            await Engine.sleep(15);
            await this.cinematic_fade_to_white();
            if (Engine.unit_in_vehicle(Engine.unit(await this.player0())))
            {
                Engine.object_teleport(Engine.object_get_parent(await this.player0()), player0_end);
            }
            else
            {
                Engine.object_teleport(await this.player0(), player0_end);
            }

            if (Engine.unit_in_vehicle(Engine.unit(await this.player1())))
            {
                Engine.object_teleport(Engine.object_get_parent(await this.player1()), player1_end);
            }
            else
            {
                Engine.object_teleport(await this.player1(), player1_end);
            }

            Engine.object_hide(await this.player0(), false);
            Engine.object_hide(await this.player1(), false);
            Engine.object_cannot_take_damage(Engine.players());
            await Engine.sleep(5);
            await this.cinematic_outro();
            await Engine.sleep(5);
            Engine.game_won();
        }

        [ScriptMethod(229, Lifecycle.Static)]
        public async Task start()
        {
            Engine.wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(230, Lifecycle.Startup)]
        public async Task mission_main()
        {
            Engine.sound_class_set_gain("amb", 0F, 0);
            Engine.ai_allegiance(player, covenant);
            Engine.weather_stop(0F);
            Engine.objectives_clear();
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task _08_intro_01_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 86, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 114, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 118, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 93, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 103, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 95, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 81, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 65, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 109, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 47, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 60, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 88, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 76, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 134, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 36, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 133, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 136, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 130, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 20, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 122, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 125, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 132, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 9, true);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 45, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3829924562U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3835757355U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3836150577U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom", 3783000070U), 5);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3836871484U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3836150577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3836937021U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3837002558U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3836150577U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3836871484U), 1);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, true);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3837068095U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3837068095U), 10);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3838837594U), 0);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            await Engine.sleep(24);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, true);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 49, true);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 46, true);
            await Engine.sleep(18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3836871484U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 137, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_outdoor_toughy\\lightfixture_outdoor_toughy", 3839165279U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 49, false);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 102, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 36, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3837002558U), 1);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 137, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_outdoor_toughy\\lightfixture_outdoor_toughy", 3839165279U), 0);
            await Engine.sleep(100);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 65, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 81, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 95, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 103, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 118, false);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 1);
            await Engine.sleep(45);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 65, false);
            await Engine.sleep(93);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 127, false);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, true);
            await Engine.sleep(22);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            await Engine.sleep(15);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 133, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 136, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 131, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 130, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 138, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 47, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 125, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 137, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 132, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 49, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3836871484U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3836150577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3837002558U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3835757355U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3836937021U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_outdoor_toughy\\lightfixture_outdoor_toughy", 3839165279U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3835757355U), 2);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3836937021U), 1);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 1);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 102, false);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await Engine.sleep(15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\invisible_box1x2x2\\invisible_box1x2x2", 3839558501U), 0);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 24, true);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 3, false);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 36, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 0);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3839820649U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3839820649U), 1);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            await Engine.sleep(39);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 3);
            await Engine.sleep(46);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 21, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 127, false);
            await Engine.sleep(9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 3);
            await Engine.sleep(91);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 127, false);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task _08_intra1_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 47, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 130, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3835757355U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3836150577U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\brute_shot\\projectiles\\grenade\\grenade", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3841328000U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3841328000U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3841917833U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 68);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 70);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3843621795U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 2);
            await Engine.sleep(80);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 2);
            await Engine.sleep(30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 3);
            await Engine.sleep(16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 2);
            await Engine.sleep(25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 40, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 2);
            await Engine.sleep(17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 68);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 70);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3843621795U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 9);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 32);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            await Engine.sleep(13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            await Engine.sleep(31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3841917833U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 3);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            await Engine.sleep(78);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 40, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 1);
            await Engine.sleep(83);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 3);
            await Engine.sleep(37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 0);
            await Engine.sleep(57);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 0);
            await Engine.sleep(19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 0);
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task _08_intra1_02_predict()
        {
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3837068095U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3837068095U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3841917833U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 3);
            await Engine.sleep(57);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 125, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 44, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 68);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 70);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3843621795U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3844015017U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3830252247U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 1);
            await Engine.sleep(156);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3836937021U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3836150577U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3836871484U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 74, false);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3836937021U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 1);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 48, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 22, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3837002558U), 0);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 18, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3837068095U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3837068095U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 1);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 4);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 122, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 0);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3843621795U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3785162791U), 0);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 7);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3844080554U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 7);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            await Engine.sleep(26);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 125, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 79, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 49, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 51, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 52, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 108, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 48, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3836871484U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3836150577U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3836937021U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3829859025U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3841917833U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3844015017U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 50, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 10, true);
            await Engine.sleep(31);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 43, true);
            await Engine.sleep(38);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 132, false);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 0);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 1);
            await Engine.sleep(21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 4);
            await Engine.sleep(66);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 42, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task _08_intra1_03_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 79, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 72, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 74, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 40, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3844801461U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 68);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 70);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3842311055U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3843621795U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3843687332U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3841917833U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3844015017U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_m\\redalder_m", 3836871484U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3829924562U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_angled\\redalder_angled", 3837002558U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3836150577U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3836937021U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplings\\redalder_saplings", 3835757355U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 109, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 86, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 11, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3847226330U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847947237U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847947237U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3829072581U), 1);
            await Engine.sleep(154);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 23, false);
            await Engine.sleep(21);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 124, false);
            await Engine.sleep(24);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 126, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 53, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 123, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08a_deltacliffs\\deltacontrolroom_bsp0"), 8, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3836216114U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3844866998U), 40);
            await Engine.sleep(58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847947237U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847947237U), 1);
        }
    }
}