namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\03a_oldmombasa\\03a_oldmombasa")]
    public partial class scnr_03a_oldmombasa : ScenarioScriptBase
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
        bool g_e13_started;
        bool g_e13_creep_end0_free;
        bool g_e13_creep_end1_free;
        bool g_e13_creep_end2_free;
        bool g_e12_started;
        bool g_e11_started;
        bool g_e11_cov_phantom0_leaving;
        IVehicle g_e8_warthog;
        IVehicle g_e10_warthog;
        bool g_e10_cov_phantom0_leaving;
        EffectTag g_e11_pod_impact_effect;
        bool g_e10_started;
        bool g_e10_cov_phantom0_arrived;
        bool g_e10_cov_ghosts0_unloaded;
        bool g_e9_started;
        bool g_e8_started;
        bool g_e8_cov_phantom0_arrived;
        bool g_e8_cov_phantom0_leaving;
        bool g_e8_cov_inf1_unloaded;
        bool g_e7_started;
        bool g_e6_started;
        bool g_e5b_started;
        bool g_e5b_finished;
        bool g_e5_started;
        bool g_e5_cov_inf1_done;
        int g_e5_cov_inf1_max;
        int g_e5_cov_inf1_spawn_delay;
        bool g_e4_started;
        bool g_e3_started;
        bool g_e3_mars_pelican0_arrived;
        bool g_e3_mars_pelican0_landed;
        bool g_e3_johnson_should_load;
        bool g_e3_johnson_in_pelican;
        int g_e3_cov_inf0_0_limit;
        bool g_e2_started;
        bool g_e2_door_breached;
        bool g_e2_cov_hunters0_active;
        bool g_e1_started;
        int g_e1_cov_inf2_spawned;
        int g_e1_cov_inf2_limit;
        bool g_e1_cov_inf2_wave0;
        bool g_e1_cov_phantom0_1_arrived;
        bool g_e1_cov_phantom0_1_retreating;
        bool g_e1_cov_inf4_0_arrived;
        bool g_e1_mars_pelican0_appeared;
        bool g_e1_mars_pelican0_departing;
        int g_e1_cov_snipers0_limit;
        public scnr_03a_oldmombasa(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 75;
            this.g_mission_over = false;
            this._15_seconds = 450;
            this._30_seconds = 900;
            this._45_seconds = 900;
            this.one_minute = 1800;
            this.two_minutes = 3600;
            this.g_e13_started = false;
            this.g_e13_creep_end0_free = true;
            this.g_e13_creep_end1_free = true;
            this.g_e13_creep_end2_free = true;
            this.g_e12_started = false;
            this.g_e11_started = false;
            this.g_e11_cov_phantom0_leaving = false;
            this.g_e8_warthog = default(IVehicle);
            this.g_e10_warthog = default(IVehicle);
            this.g_e10_cov_phantom0_leaving = false;
            this.g_e11_pod_impact_effect = Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\earthcity\\e11_insertion_pod_impact", 2191925358U);
            this.g_e10_started = false;
            this.g_e10_cov_phantom0_arrived = false;
            this.g_e10_cov_ghosts0_unloaded = false;
            this.g_e9_started = false;
            this.g_e8_started = false;
            this.g_e8_cov_phantom0_arrived = false;
            this.g_e8_cov_phantom0_leaving = false;
            this.g_e8_cov_inf1_unloaded = false;
            this.g_e7_started = false;
            this.g_e6_started = false;
            this.g_e5b_started = false;
            this.g_e5b_finished = false;
            this.g_e5_started = false;
            this.g_e5_cov_inf1_done = false;
            this.g_e5_cov_inf1_max = 10;
            this.g_e5_cov_inf1_spawn_delay = 30;
            this.g_e4_started = false;
            this.g_e3_started = false;
            this.g_e3_mars_pelican0_arrived = false;
            this.g_e3_mars_pelican0_landed = false;
            this.g_e3_johnson_should_load = false;
            this.g_e3_johnson_in_pelican = false;
            this.g_e3_cov_inf0_0_limit = 12;
            this.g_e2_started = false;
            this.g_e2_door_breached = false;
            this.g_e2_cov_hunters0_active = false;
            this.g_e1_started = false;
            this.g_e1_cov_inf2_spawned = 0;
            this.g_e1_cov_inf2_limit = 0;
            this.g_e1_cov_inf2_wave0 = true;
            this.g_e1_cov_phantom0_1_arrived = false;
            this.g_e1_cov_phantom0_1_retreating = false;
            this.g_e1_cov_inf4_0_arrived = false;
            this.g_e1_mars_pelican0_appeared = false;
            this.g_e1_mars_pelican0_departing = false;
            this.g_e1_cov_snipers0_limit = 2;
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
        public async Task _03_intro_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intro_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _03_intro_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intro_02_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _03_intro_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intro_03_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _03_intro_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intro_04_predict));
        }

        [ScriptMethod(28, Lifecycle.Dormant)]
        public async Task c03_intro_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\music\\c03_intro_01_mus", 3840869241U), default(IGameObject), 1F);
            Engine.print("c03_intro score 01 start");
        }

        [ScriptMethod(29, Lifecycle.Dormant)]
        public async Task c03_intro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_01_fol", 3840934778U), default(IGameObject), 1F);
            Engine.print("c03_intro foley 01 start");
        }

        [ScriptMethod(30, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene1_01()
        {
            Engine.object_set_function_variable(pelican_01.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(pelican_02.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(pelican_03.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(pelican_04.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(pelican_01.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(pelican_02.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(pelican_03.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(pelican_04.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(pelican_01.Entity, "hover_audio", 1F, 0F);
            Engine.object_set_function_variable(pelican_02.Entity, "hover_audio", 1F, 0F);
            Engine.object_set_function_variable(pelican_03.Entity, "hover_audio", 1F, 0F);
            Engine.object_set_function_variable(pelican_04.Entity, "hover_audio", 1F, 0F);
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            Engine.sound_class_set_gain("vehicle", 1F, 115);
            Engine.object_set_velocity(pelican_01.Entity, 8F);
            Engine.object_set_velocity(pelican_02.Entity, 8F);
            Engine.object_set_velocity(pelican_03.Entity, 8F);
            await Engine.sleep(130);
            Engine.sound_class_set_gain("vehicle", 0F, 120);
        }

        [ScriptMethod(31, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene1_02()
        {
            await Engine.sleep(260);
            Engine.sound_class_set_gain("vehicle", 0.5F, 10);
        }

        [ScriptMethod(32, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene1_03()
        {
            await Engine.sleep(350);
            Engine.sound_class_set_gain("vehicle", 0F, 10);
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene1_04()
        {
            await Engine.sleep(435);
            Engine.sound_class_set_gain("vehicle", 0.5F, 10);
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c03_1010_cor()
        {
            await Engine.sleep(212);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1010_cor", 3841000315U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c03_1010_cor", 1F);
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c03_1011_cor()
        {
            await Engine.sleep(265);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1011_cor", 3841065852U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c03_1011_cor", 2F);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c03_1020_mir()
        {
            await Engine.sleep(333);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1020_mir", 3841131389U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c03_1020_mir", 1F);
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c03_1021_mir()
        {
            await Engine.sleep(357);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1021_mir", 3841196926U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("c03_1021_mir", 1F);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c03_1030_jon()
        {
            await Engine.sleep(396);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1030_jon", 3841262463U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c03_1030_jon", 5F);
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task c03_1040_jon()
        {
            await Engine.sleep(560);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1040_jon", 3841328000U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_1040_jon", 4F);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c03_1050_och_1()
        {
            await Engine.sleep(684);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1050_och", 3841393537U), pilot.Entity, 1F);
            Engine.cinematic_subtitle("c03_1050_och", 1F);
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c03_1050_och_2()
        {
            await Engine.sleep(684);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1050_och", 3841393537U), copilot.Entity, 1F);
            Engine.cinematic_subtitle("c03_1050_och", 2F);
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c03_intro_shake_01_1()
        {
            await Engine.sleep(113);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            Engine.player_effect_stop(1.5F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c03_intro_shake_01_2()
        {
            await Engine.sleep(259);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            await Engine.sleep(91);
            Engine.player_effect_stop(0F);
            Engine.print("shake stop");
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task c03_intro_shake_01_3()
        {
            await Engine.sleep(560);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task c03_intro_01_dof_1()
        {
            await Engine.sleep(436);
            Engine.print("dof values: 12 5 5 0 0 0 0");
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(12F, 5F, 5F, 0F, 0F, 0F, 0F);
            await Engine.sleep(123);
            Engine.print("dof stop");
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task cinematic_light_01_city_01()
        {
            Engine.cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            Engine.cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(pilot.Entity, true);
            Engine.object_uses_cinematic_lighting(copilot.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_01.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_02.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_03.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_04.Entity, true);
            Engine.object_uses_cinematic_lighting(iac.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_bridge.Entity, true);
            Engine.object_uses_cinematic_lighting(carrier.Entity, true);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task cinematic_light_01_pelican_01()
        {
            await Engine.sleep(259);
            Engine.object_destroy(carrier.Entity);
            Engine.print("destroy carrier");
            Engine.cinematic_lighting_set_primary_light(4F, 278F, 0.54902F, 0.478431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-34F, 154F, 0.14902F, 0.141176F, 0.180392F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            await Engine.sleep(86);
            Engine.fade_out(1F, 1F, 1F, 5);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task cinematic_light_01_iac_01()
        {
            await Engine.sleep(350);
            Engine.object_hide(chief.Entity, true);
            Engine.print("hide chief");
            Engine.cinematic_lighting_set_primary_light(-52F, 282F, 0.156863F, 0.180392F, 0.333333F);
            Engine.cinematic_lighting_set_secondary_light(-75F, 150F, 0.121569F, 0.121569F, 0.180392F);
            Engine.cinematic_lighting_set_ambient_light(0.0588235F, 0.0509804F, 0.0392157F);
            await Engine.sleep(20);
            Engine.fade_in(1F, 1F, 1F, 5);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task cinematic_light_01_city_02()
        {
            await Engine.sleep(435);
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(iac_bridge.Entity);
            Engine.print("destroy miranda, iac bridge");
            Engine.cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            Engine.cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task cinematic_light_01_pelican_02()
        {
            await Engine.sleep(558);
            Engine.print("light pelican");
            Engine.cinematic_lighting_set_primary_light(29F, 116F, 0.478431F, 0.415686F, 0.329412F);
            Engine.cinematic_lighting_set_secondary_light(20F, 272F, 0.235294F, 0.235294F, 0.384314F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task c03_intro_01_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(iac);
            Engine.object_create_anew(pelican_01);
            Engine.object_create_anew(pelican_02);
            Engine.object_create_anew(pelican_03);
            Engine.object_create_anew(pelican_04);
            Engine.object_cinematic_lod(iac.Entity, true);
            Engine.object_cinematic_lod(pelican_01.Entity, true);
            Engine.object_cinematic_lod(pelican_02.Entity, true);
            Engine.object_cinematic_lod(pelican_03.Entity, true);
            Engine.object_cinematic_lod(pelican_04.Entity, true);
            Engine.object_cinematic_visibility(iac.Entity, true);
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task c03_intro_01_setup()
        {
            Engine.object_create_anew(chief);
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(pilot);
            Engine.object_create_anew(copilot);
            Engine.object_create_anew(iac_bridge);
            Engine.object_create_anew(carrier);
            Engine.unit_set_emotional_state(miranda.Entity, "inquisitive", 0.25F, 0);
            Engine.object_set_scale(carrier.Entity, 0.4F, 0);
            Engine.object_set_function_variable(carrier.Entity, "grav_lift_control", 1F, 0F);
            Engine.object_create_anew(intro_flak_01);
            Engine.object_create_anew(intro_flak_02);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(pilot.Entity, true);
            Engine.object_cinematic_lod(copilot.Entity, true);
            Engine.object_cinematic_lod(carrier.Entity, true);
            Engine.object_set_permutation(copilot.Entity, "head", "smith");
            Engine.unit_set_emotional_state(johnson.Entity, "happy", 0.25F, 0);
            Engine.unit_set_emotional_state(pilot.Entity, "angry", 0.25F, 0);
            Engine.unit_set_emotional_state(copilot.Entity, "angry", 0.25F, 0);
            Engine.wake(new ScriptMethodReference(c03_intro_score_01));
            Engine.wake(new ScriptMethodReference(c03_intro_foley_01));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene1_01));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene1_02));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene1_03));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene1_04));
            Engine.wake(new ScriptMethodReference(c03_1010_cor));
            Engine.wake(new ScriptMethodReference(c03_1011_cor));
            Engine.wake(new ScriptMethodReference(c03_1020_mir));
            Engine.wake(new ScriptMethodReference(c03_1021_mir));
            Engine.wake(new ScriptMethodReference(c03_1030_jon));
            Engine.wake(new ScriptMethodReference(c03_1040_jon));
            Engine.wake(new ScriptMethodReference(c03_1050_och_1));
            Engine.wake(new ScriptMethodReference(c03_1050_och_2));
            Engine.wake(new ScriptMethodReference(c03_intro_shake_01_1));
            Engine.wake(new ScriptMethodReference(c03_intro_shake_01_2));
            Engine.wake(new ScriptMethodReference(c03_intro_shake_01_3));
            Engine.wake(new ScriptMethodReference(cinematic_light_01_city_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_01_pelican_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_01_iac_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_01_city_02));
            Engine.wake(new ScriptMethodReference(cinematic_light_01_pelican_02));
        }

        [ScriptMethod(53, Lifecycle.Static)]
        public async Task c03_intro_01_cleanup()
        {
            Engine.object_destroy(pelican_04.Entity);
            Engine.player_effect_stop(0F);
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task c03_intro_scene_01()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("oldmombasa_intro");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.c03_intro_01_problem_actors();
            await this._03_intro_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\music\\c03_intro_01_mus", 3840869241U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_01_fol", 3840934778U));
            await Engine.sleep(this.prediction_offset);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intro\\03_intro", 3841459074U), "03_intro_01", default(IUnit), anchor_flag_intro);
            await this.c03_intro_01_setup();
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intro\\03_intro", 3841524611U), "mc_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "johnson_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\03_intro\\03_intro", 3841721222U), "miranda_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pilot.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "marine1_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(copilot.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "marine2_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel1_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel2_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel3_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel4_01", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\03_intro\\03_intro", 3846308812U), "iac_01", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(iac_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\03_intro\\03_intro", 3846374349U), "iac_bridge_01", anchor_intro.Entity);
            await Engine.sleep(10);
            Engine.fade_in(0F, 0F, 0F, 60);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._03_intro_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_02_fol", 3846439886U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c03_intro_01_cleanup();
        }

        [ScriptMethod(55, Lifecycle.CommandScript)]
        public async Task cs_hog_01()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.object_set_velocity(Engine.ai_vehicle_get(this.ai_current_actor), 1F);
            Engine.cs_vehicle_speed(0.9F);
            Engine.ai_vehicle_enter_immediate(intro_hog_01.driver, Engine.ai_vehicle_get_from_starting_location(intro_hog_01.hog), "warthog_d");
            await Engine.sleep(1);
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("intro_hog_targets/p0"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(56, Lifecycle.CommandScript)]
        public async Task cs_hog_02()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.object_set_velocity(Engine.ai_vehicle_get(this.ai_current_actor), 1F);
            Engine.cs_vehicle_speed(0.9F);
            Engine.ai_vehicle_enter_immediate(intro_hog_02.driver, Engine.ai_vehicle_get_from_starting_location(intro_hog_02.hog), "warthog_d");
            await Engine.sleep(1);
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("intro_hog_targets/p0"));
        }

        [ScriptMethod(57, Lifecycle.CommandScript)]
        public async Task cs_hog_03()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.object_set_velocity(Engine.ai_vehicle_get(this.ai_current_actor), 1F);
            Engine.ai_vehicle_enter_immediate(intro_hog_03.driver, Engine.ai_vehicle_get_from_starting_location(intro_hog_03.hog), "warthog_d");
            Engine.cs_vehicle_speed(0.9F);
            await Engine.sleep(1);
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("intro_hog_targets/p1"));
        }

        [ScriptMethod(58, Lifecycle.CommandScript)]
        public async Task cs_hog_04()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.object_set_velocity(Engine.ai_vehicle_get(this.ai_current_actor), 1F);
            Engine.cs_vehicle_speed(0.9F);
            Engine.ai_vehicle_enter_immediate(intro_hog_04.driver, Engine.ai_vehicle_get_from_starting_location(intro_hog_04.hog), "warthog_d");
            await Engine.sleep(1);
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("intro_hog_targets/p1"));
        }

        [ScriptMethod(59, Lifecycle.Dormant)]
        public async Task intro_hogs()
        {
            await Engine.sleep(146);
            Engine.ai_place(intro_hog_01.Squad);
            Engine.ai_place(intro_hog_02.Squad);
            Engine.ai_place(intro_hog_03.Squad);
            Engine.ai_place(intro_hog_04.Squad);
            Engine.cs_run_command_script(intro_hog_01.driver, new ScriptMethodReference(cs_hog_01));
            Engine.cs_run_command_script(intro_hog_02.driver, new ScriptMethodReference(cs_hog_02));
            Engine.cs_run_command_script(intro_hog_03.driver, new ScriptMethodReference(cs_hog_03));
            Engine.cs_run_command_script(intro_hog_04.driver, new ScriptMethodReference(cs_hog_04));
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c03_intro_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_02_fol", 3846439886U), default(IGameObject), 1F);
            Engine.print("c03_intro foley 02 start");
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene2_01()
        {
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            await Engine.sleep(144);
            Engine.sound_class_set_gain("vehicle", 0.25F, 0);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene2_03()
        {
            await Engine.sleep(145);
            Engine.sound_class_set_gain("vehicle", 0.25F, 15);
            Engine.sound_class_set_gain("vehicle", 0.5F, 120);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene2_04()
        {
            await Engine.sleep(280);
            Engine.sound_class_set_gain("vehicle", 0.25F, 10);
            Engine.sound_class_set_gain("vehicle", 0.5F, 75);
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene2_05()
        {
            await Engine.sleep(480);
            Engine.sound_class_set_gain("vehicle", 0.5F, 50);
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task c03_1060_cor()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1060_cor", 3846505423U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c03_1060_cor", 5F);
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task c03_1070_cor()
        {
            await Engine.sleep(150);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1070_cor", 3846570960U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c03_1070_cor", 3F);
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task c03_1080_mrs()
        {
            await Engine.sleep(290);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1080_mrs", 3846636497U), spotter.Entity, 1F, "radio_default_in");
            Engine.cinematic_subtitle("c03_1080_mrs", 4F);
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c03_1090_dp1()
        {
            await Engine.sleep(407);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1090_dp1", 3846702034U), default(IGameObject), 1F, "radio_default_out");
            Engine.cinematic_subtitle("c03_1090_dp1", 1F);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c03_intro_shake_02()
        {
            await Engine.sleep(350);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            Engine.player_effect_stop(1.5F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c03_intro_fov_01()
        {
            await Engine.sleep(232);
            Engine.camera_set_field_of_view(36F, 0);
            Engine.print("fov change: 50 -> 16 over 0 ticks");
            await Engine.sleep(13);
            Engine.camera_set_field_of_view(60F, 14);
            Engine.print("fov change: 16 -> 50 over 14 ticks");
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_02()
        {
            Engine.cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            Engine.cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
            Engine.object_uses_cinematic_lighting(sniper.Entity, true);
            Engine.object_uses_cinematic_lighting(spotter.Entity, true);
            Engine.object_uses_cinematic_lighting(sniper_rifle.Entity, true);
            Engine.object_uses_cinematic_lighting(scope.Entity, true);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task white_flash()
        {
            await Engine.sleep(130);
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(30);
            Engine.fade_in(1F, 1F, 1F, 15);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task erase_hogs()
        {
            Engine.time_code_reset();
            await Engine.sleep(279);
            Engine.print("erase hogs");
            Engine.ai_erase(intro_hog_01.Squad);
            Engine.ai_erase(intro_hog_02.Squad);
            Engine.ai_erase(intro_hog_03.Squad);
            Engine.ai_erase(intro_hog_04.Squad);
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task c03_intro_02_setup()
        {
            Engine.object_create_anew(sniper);
            Engine.object_create_anew(spotter);
            Engine.object_create_anew(sniper_rifle);
            Engine.object_create_anew(scope);
            Engine.object_cinematic_lod(sniper.Entity, true);
            Engine.object_cinematic_lod(spotter.Entity, true);
            Engine.object_cinematic_lod(sniper_rifle.Entity, true);
            Engine.object_cinematic_lod(scope.Entity, true);
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene2_01));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene2_03));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene2_04));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene2_05));
            Engine.unit_set_emotional_state(sniper.Entity, "pensive", 0.5F, 0);
            Engine.unit_set_emotional_state(spotter.Entity, "pain", 0.5F, 0);
            Engine.wake(new ScriptMethodReference(c03_intro_foley_02));
            Engine.wake(new ScriptMethodReference(c03_1060_cor));
            Engine.wake(new ScriptMethodReference(c03_1070_cor));
            Engine.wake(new ScriptMethodReference(c03_1080_mrs));
            Engine.wake(new ScriptMethodReference(c03_1090_dp1));
            Engine.wake(new ScriptMethodReference(intro_hogs));
            Engine.wake(new ScriptMethodReference(erase_hogs));
            Engine.wake(new ScriptMethodReference(c03_intro_shake_02));
            Engine.wake(new ScriptMethodReference(c03_intro_fov_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_scene_02));
            Engine.wake(new ScriptMethodReference(white_flash));
        }

        [ScriptMethod(75, Lifecycle.Static)]
        public async Task c03_intro_02_cleanup()
        {
            Engine.object_destroy(sniper.Entity);
            Engine.object_destroy(spotter.Entity);
            Engine.object_destroy(scope.Entity);
        }

        [ScriptMethod(76, Lifecycle.Static)]
        public async Task c03_intro_scene_02()
        {
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intro\\03_intro", 3841459074U), "03_intro_02", default(IUnit), anchor_flag_intro);
            await this.c03_intro_02_setup();
            Engine.pvs_set_object(pelican_01.Entity);
            Engine.custom_animation_relative(sniper.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "sniper_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(spotter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "spotter_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel1_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel2_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel3_02", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(sniper_rifle.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\sniper_rifle\\03_intro\\03_intro", 3846767571U), "sniper_rifle_02", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(scope.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\human\\military\\spotting_scope\\03_intro\\03_intro", 3846833108U), "scope_02", anchor_intro.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._03_intro_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_03_fol", 3846898645U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c03_intro_02_cleanup();
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task c03_intro_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_03_fol", 3846898645U), default(IGameObject), 1F);
            Engine.print("c03_intro foley 03 start");
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene3_01()
        {
            await Engine.sleep(635);
            Engine.sound_class_set_gain("vehicle", 0F, 5);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene3_02()
        {
            await Engine.sleep(640);
            Engine.sound_class_set_gain("vehicle", 0.5F, 135);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene3_03()
        {
            await Engine.sleep(805);
            Engine.object_set_function_variable(pelican_01.Entity, "turn_absolute", 1F, 75F);
            Engine.object_set_function_variable(pelican_02.Entity, "turn_absolute", 1F, 75F);
            Engine.object_set_function_variable(pelican_03.Entity, "turn_absolute", 1F, 75F);
            Engine.object_set_function_variable(pelican_01.Entity, "banking_audio", 1F, 75F);
            Engine.object_set_function_variable(pelican_02.Entity, "banking_audio", 1F, 75F);
            Engine.object_set_function_variable(pelican_03.Entity, "banking_audio", 1F, 75F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task c03_1100_dp1()
        {
            await Engine.sleep(5);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1100_dp1", 3846964182U), pilot.Entity, 1F);
            Engine.cinematic_subtitle("c03_1100_dp1", 1F);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task c03_1110_jon()
        {
            await Engine.sleep(63);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1110_jon", 3847029719U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_1110_jon", 1F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c03_1120_jon()
        {
            await Engine.sleep(135);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1120_jon", 3847095256U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_1120_jon", 2F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task c03_1130_lhd()
        {
            await Engine.sleep(190);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1130_lhd", 3847160793U), default(IGameObject), 1F, "radio_default_in");
            Engine.cinematic_subtitle("c03_1130_lhd", 4F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task c03_1140_lhd()
        {
            await Engine.sleep(314);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1140_lhd", 3847226330U), default(IGameObject), 1F, "radio_default_out");
            Engine.cinematic_subtitle("c03_1140_lhd", 5F);
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task c03_1150_dp2()
        {
            await Engine.sleep(490);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1150_dp2", 3847291867U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c03_1150_dp2", 1F);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task c03_intro_shake_03()
        {
            await Engine.sleep(0);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            await Engine.sleep(405);
            Engine.player_effect_stop(0F);
            Engine.print("shake stop");
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task c03_intro_03_dof_1()
        {
            await Engine.sleep(96);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 0F, 1F, 1F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(83);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task c03_intro_03_dof_2()
        {
            await Engine.sleep(319);
            Engine.print("dof values: 3 0 0 0 1 1 0");
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(3F, 0F, 0F, 0F, 1F, 1F, 0F);
            await Engine.sleep(85);
            Engine.print("dof values: 9 2.5 2.5 0 0 0 0");
            Engine.cinematic_screen_effect_set_depth_of_field(9F, 2.5F, 2.5F, 0F, 0F, 0F, 0F);
            await Engine.sleep(116);
            Engine.print("dof stop");
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_03()
        {
            Engine.cinematic_lighting_set_primary_light(29F, 116F, 0.478431F, 0.415686F, 0.329412F);
            Engine.cinematic_lighting_set_secondary_light(20F, 272F, 0.235294F, 0.235294F, 0.384314F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(odst_01.Entity, true);
            Engine.object_uses_cinematic_lighting(odst_02.Entity, true);
            Engine.object_uses_cinematic_lighting(odst_03.Entity, true);
            Engine.object_uses_cinematic_lighting(odst_04.Entity, true);
            Engine.object_uses_cinematic_lighting(helmet.Entity, true);
            Engine.object_uses_cinematic_lighting(battle_rifle_01.Entity, true);
            Engine.object_uses_cinematic_lighting(battle_rifle_02.Entity, true);
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task cinematic_light_troopbay_03_01()
        {
            await Engine.sleep(178);
            Engine.print("light bay");
            Engine.object_hide(odst_01.Entity, false);
            Engine.object_hide(odst_02.Entity, false);
            Engine.object_hide(odst_03.Entity, false);
            Engine.cinematic_lighting_set_primary_light(4F, 278F, 0.54902F, 0.478431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-34F, 154F, 0.14902F, 0.141176F, 0.180392F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task cinematic_light_chief_03_01()
        {
            await Engine.sleep(318);
            Engine.print("light chief rev");
            Engine.object_hide(chief.Entity, false);
            Engine.object_hide(odst_04.Entity, false);
            Engine.cinematic_lighting_set_primary_light(4F, 240F, 0.54902F, 0.478431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-34F, 154F, 0.145098F, 0.141176F, 0.184314F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task cinematic_light_street_03_01()
        {
            await Engine.sleep(403);
            Engine.print("light street");
            Engine.cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            Engine.cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task save_dof_01()
        {
            await Engine.sleep(318);
            Engine.print("delete marines, hide pelican");
            Engine.object_destroy(odst_01.Entity);
            Engine.object_destroy(odst_02.Entity);
            Engine.object_destroy(odst_03.Entity);
            Engine.object_destroy(battle_rifle_01.Entity);
            Engine.object_destroy(battle_rifle_02.Entity);
            Engine.object_destroy(sniper_rifle.Entity);
            Engine.object_hide(pelican_03.Entity, true);
            Engine.object_hide(offending_palm_01.Entity, true);
            Engine.object_hide(offending_palm_02.Entity, true);
            Engine.object_hide(offending_palm_03.Entity, true);
            Engine.object_hide(offending_palm_04.Entity, true);
            Engine.object_hide(offending_palm_05.Entity, true);
            Engine.object_hide(offending_palm_06.Entity, true);
            Engine.object_hide(offending_palm_07.Entity, true);
            Engine.object_hide(offending_palm_08.Entity, true);
            Engine.object_hide(offending_palm_09.Entity, true);
            Engine.object_hide(offending_palm_10.Entity, true);
            Engine.object_hide(offending_palm_11.Entity, true);
            Engine.object_hide(offending_palm_12.Entity, true);
            Engine.object_hide(offending_palm_13.Entity, true);
            Engine.object_hide(offending_palm_14.Entity, true);
            Engine.object_hide(offending_palm_15.Entity, true);
            Engine.object_hide(offending_palm_16.Entity, true);
            Engine.object_hide(offending_palm_17.Entity, true);
            Engine.object_hide(offending_palm_18.Entity, true);
            Engine.object_hide(offending_palm_19.Entity, true);
            Engine.object_hide(offending_palm_20.Entity, true);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task show_trees_pelican()
        {
            await Engine.sleep(405);
            Engine.print("show trees, pelican");
            Engine.object_hide(pelican_03.Entity, false);
            Engine.object_hide(offending_palm_01.Entity, false);
            Engine.object_hide(offending_palm_02.Entity, false);
            Engine.object_hide(offending_palm_03.Entity, false);
            Engine.object_hide(offending_palm_04.Entity, false);
            Engine.object_hide(offending_palm_05.Entity, false);
            Engine.object_hide(offending_palm_06.Entity, false);
            Engine.object_hide(offending_palm_07.Entity, false);
            Engine.object_hide(offending_palm_08.Entity, false);
            Engine.object_hide(offending_palm_09.Entity, false);
            Engine.object_hide(offending_palm_10.Entity, false);
            Engine.object_hide(offending_palm_11.Entity, false);
            Engine.object_hide(offending_palm_12.Entity, false);
            Engine.object_hide(offending_palm_13.Entity, false);
            Engine.object_hide(offending_palm_14.Entity, false);
            Engine.object_hide(offending_palm_15.Entity, false);
            Engine.object_hide(offending_palm_16.Entity, false);
            Engine.object_hide(offending_palm_17.Entity, false);
            Engine.object_hide(offending_palm_18.Entity, false);
            Engine.object_hide(offending_palm_19.Entity, false);
            Engine.object_hide(offending_palm_20.Entity, false);
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task c03_intro_03_setup()
        {
            Engine.object_create_anew(odst_01);
            Engine.object_create_anew(odst_02);
            Engine.object_create_anew(odst_03);
            Engine.object_create_anew(odst_04);
            Engine.object_create_anew(helmet);
            Engine.object_create_anew(battle_rifle_01);
            Engine.object_create_anew(battle_rifle_02);
            Engine.object_cinematic_lod(odst_01.Entity, true);
            Engine.object_cinematic_lod(odst_02.Entity, true);
            Engine.object_cinematic_lod(odst_03.Entity, true);
            Engine.object_cinematic_lod(odst_04.Entity, true);
            Engine.object_cinematic_lod(helmet.Entity, true);
            Engine.object_cinematic_lod(battle_rifle_01.Entity, true);
            Engine.object_cinematic_lod(battle_rifle_02.Entity, true);
            Engine.object_hide(odst_01.Entity, true);
            Engine.object_hide(odst_02.Entity, true);
            Engine.object_hide(odst_03.Entity, true);
            Engine.object_hide(odst_04.Entity, true);
            Engine.object_set_permutation(odst_01.Entity, "head", "morgan");
            Engine.object_set_permutation(odst_02.Entity, "head", "perez");
            Engine.object_set_permutation(odst_03.Entity, "head", "walter");
            Engine.object_set_permutation(odst_04.Entity, "head", "banks");
            Engine.unit_set_emotional_state(odst_01.Entity, "angry", 0.25F, 0);
            Engine.unit_set_emotional_state(odst_02.Entity, "angry", 0.25F, 0);
            Engine.unit_set_emotional_state(odst_03.Entity, "angry", 0.25F, 0);
            Engine.unit_set_emotional_state(odst_04.Entity, "angry", 0.25F, 0);
            Engine.object_set_region_state(odst_03.Entity, "helmet", destroyed);
            Engine.object_set_region_state(odst_04.Entity, "helmet", destroyed);
            Engine.objects_attach(odst_01.Entity, "right hand", battle_rifle_01.Entity, "");
            Engine.objects_attach(odst_02.Entity, "right hand", battle_rifle_02.Entity, "");
            Engine.wake(new ScriptMethodReference(c03_intro_foley_03));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene3_01));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene3_02));
            Engine.wake(new ScriptMethodReference(c03_intro_sound_scene3_03));
            Engine.wake(new ScriptMethodReference(c03_1100_dp1));
            Engine.wake(new ScriptMethodReference(c03_1110_jon));
            Engine.wake(new ScriptMethodReference(c03_1120_jon));
            Engine.wake(new ScriptMethodReference(c03_1130_lhd));
            Engine.wake(new ScriptMethodReference(c03_1140_lhd));
            Engine.wake(new ScriptMethodReference(c03_1150_dp2));
            Engine.wake(new ScriptMethodReference(save_dof_01));
            Engine.wake(new ScriptMethodReference(show_trees_pelican));
            Engine.wake(new ScriptMethodReference(c03_intro_shake_03));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_scene_03));
            Engine.wake(new ScriptMethodReference(cinematic_light_troopbay_03_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_chief_03_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_street_03_01));
        }

        [ScriptMethod(97, Lifecycle.Static)]
        public async Task c03_intro_03_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy_containing("odst");
            Engine.object_destroy(helmet.Entity);
            Engine.object_destroy(battle_rifle_01.Entity);
            Engine.object_destroy(battle_rifle_02.Entity);
            Engine.object_destroy(sniper_rifle.Entity);
            Engine.object_destroy(magazine.Entity);
        }

        [ScriptMethod(98, Lifecycle.Static)]
        public async Task c03_intro_scene_03()
        {
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intro\\03_intro", 3841459074U), "03_intro_03", default(IUnit), anchor_flag_intro);
            await this.c03_intro_03_setup();
            Engine.pvs_set_object(pelican_01.Entity);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intro\\03_intro", 3841524611U), "mc_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "johnson_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pilot.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "marine1_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(copilot.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "marine2_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(odst_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "odst1_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(odst_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "odst2_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(odst_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "odst3_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(odst_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "odst4_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel1_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel2_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel3_03", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(helmet.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\helmet_odst\\03_intro\\03_intro", 3847357404U), "helmet_03", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(sniper_rifle.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\sniper_rifle\\03_intro\\03_intro", 3846767571U), "sniper_rifle_03", anchor_intro.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._03_intro_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_04_fol", 3847422941U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c03_intro_03_cleanup();
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task intro_scarab_gun_charge()
        {
            await Engine.sleep(200);
            Engine.print("scarab gun charge");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_beam_charging", 3847488478U), scarab.Entity, "primary_trigger");
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task intro_scarab_gun_fire()
        {
            Engine.object_create(intro_scarab_gun);
            Engine.objects_attach(scarab.Entity, "primary_trigger", intro_scarab_gun.Entity, "");
            await Engine.sleep(240);
            Engine.print("scarab gun fire");
            Engine.object_hide(intro_scarab_gun.Entity, true);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("intro_scarab_gun"), 0, true);
            await Engine.sleep(120);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("intro_scarab_gun"), 0, false);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task intro_scarab_turret_fire()
        {
            Engine.object_create(intro_scarab_gun_turret);
            Engine.objects_attach(scarab_turret.Entity, "primary_trigger", intro_scarab_gun_turret.Entity, "");
            Engine.object_hide(intro_scarab_gun_turret.Entity, true);
            await Engine.sleep(285);
            Engine.print("scarab turret fire");
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("intro_scarab_gun_turret"), 0, true);
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task effect_pelican_hit_01()
        {
            await Engine.sleep(265);
            Engine.print("pelican hit");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit", 3847816163U), pelican_01.Entity, "johnson");
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task effect_pelican_impact_01()
        {
            await Engine.sleep(410);
            Engine.print("pelican impact 1");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit_small", 3848995829U), pelican_03.Entity, "light_cockpit_back");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit_small", 3848995829U), pelican_03.Entity, "hardpoint_left");
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task effect_pelican_impact_02()
        {
            await Engine.sleep(434);
            Engine.print("pelican impact 2");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit", 3847816163U), pelican_03.Entity, "johnson");
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3849061366U), intro_junction_flag_01);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task effect_blow_railings()
        {
            await Engine.sleep(450);
            Engine.print("blow railings far");
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3849061366U), intro_railing_flag_01);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3849061366U), intro_railing_flag_02);
            await Engine.sleep(5);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3849061366U), intro_railing_flag_03);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3849061366U), intro_railing_flag_04);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task c03_intro_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_04_fol", 3847422941U), default(IGameObject), 1F);
            Engine.print("c03_intro foley 04 start");
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task c03_1160_dp2()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1160_dp2", 3849126903U), pilot.Entity, 1F);
            Engine.cinematic_subtitle("c03_1160_dp2", 2F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task c03_intro_fov_02()
        {
            await Engine.sleep(382);
            Engine.camera_set_field_of_view(30F, 0);
            Engine.print("fov change: 50 -> 20 over 0 ticks");
            await Engine.sleep(18);
            Engine.camera_set_field_of_view(60F, 20);
            Engine.print("fov change: 20 -> 50 over 20 ticks");
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task c03_intro_shake_04()
        {
            await Engine.sleep(137);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.5F, 0F);
            Engine.player_effect_stop(1F);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task c03_intro_04_dof_1()
        {
            await Engine.sleep(58);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 1F, 1F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(59);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task c03_intro_04_dof_3()
        {
            await Engine.sleep(382);
            Engine.print("dof stop");
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_04()
        {
            Engine.cinematic_lighting_set_primary_light(29F, 116F, 0.478431F, 0.415686F, 0.329412F);
            Engine.cinematic_lighting_set_secondary_light(20F, 272F, 0.235294F, 0.235294F, 0.384314F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task cinematic_light_street_04_01()
        {
            await Engine.sleep(117);
            Engine.print("light street");
            Engine.cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            Engine.cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task effect_big_foot()
        {
            Engine.time_code_reset();
            await Engine.sleep(126);
            Engine.print("big foot");
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3849061366U), bus_flag_01);
            Engine.damage_new(Engine.GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3849061366U), bus_flag_02);
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task c03_intro_04_setup()
        {
            Engine.object_create_anew(scarab);
            Engine.object_create_anew(scarab_turret);
            Engine.object_create_anew_containing("intro_railing");
            Engine.object_create_anew_containing("intro_crash");
            Engine.object_create_anew(the_fiscal_year);
            Engine.object_cinematic_lod(scarab.Entity, true);
            Engine.object_cinematic_lod(scarab_turret.Entity, true);
            Engine.object_cinematic_lod(the_fiscal_year.Entity, true);
            Engine.object_uses_cinematic_lighting(scarab.Entity, true);
            Engine.object_uses_cinematic_lighting(scarab_turret.Entity, true);
            Engine.wake(new ScriptMethodReference(c03_intro_foley_04));
            Engine.wake(new ScriptMethodReference(c03_1160_dp2));
            Engine.wake(new ScriptMethodReference(c03_intro_fov_02));
            Engine.wake(new ScriptMethodReference(c03_intro_shake_04));
            Engine.wake(new ScriptMethodReference(intro_scarab_gun_charge));
            Engine.wake(new ScriptMethodReference(intro_scarab_gun_fire));
            Engine.wake(new ScriptMethodReference(intro_scarab_turret_fire));
            Engine.wake(new ScriptMethodReference(effect_big_foot));
            Engine.wake(new ScriptMethodReference(effect_pelican_hit_01));
            Engine.wake(new ScriptMethodReference(effect_pelican_impact_01));
            Engine.wake(new ScriptMethodReference(effect_pelican_impact_02));
            Engine.wake(new ScriptMethodReference(effect_blow_railings));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_scene_04));
            Engine.wake(new ScriptMethodReference(cinematic_light_street_04_01));
        }

        [ScriptMethod(116, Lifecycle.Static)]
        public async Task c03_intro_04_cleanup()
        {
            Engine.object_destroy(pilot.Entity);
            Engine.object_destroy(copilot.Entity);
            Engine.object_destroy_containing("scarab");
            Engine.object_destroy_containing("pelican");
            Engine.object_destroy(the_fiscal_year.Entity);
        }

        [ScriptMethod(117, Lifecycle.Static)]
        public async Task c03_intro_scene_04()
        {
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intro\\03_intro", 3841459074U), "03_intro_04", default(IUnit), anchor_flag_intro);
            await this.c03_intro_04_setup();
            Engine.pvs_set_object(pelican_01.Entity);
            Engine.custom_animation_relative(pilot.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "marine1_04", false, anchor_intro.Entity);
            Engine.custom_animation_relative(copilot.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3841590148U), "marine2_04", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel1_04", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel2_04", false, anchor_intro.Entity);
            Engine.custom_animation_relative(pelican_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3846243275U), "pel3_04", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(scarab.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\03_intro\\03_intro", 3849192440U), "scarab_04", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(scarab_turret.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\03_intro\\03_intro", 3849257977U), "scarab_upper_gun_04", anchor_intro.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 60));
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.5F, 2F);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.print("cut to black");
            Engine.fade_out(0F, 0F, 0F, 5);
            await Engine.sleep(5);
            await this.c03_intro_04_cleanup();
            await Engine.sleep(30);
            Engine.player_effect_stop(0F);
        }

        [ScriptMethod(118, Lifecycle.Static)]
        public async Task c03_intro()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("earthcity_cine_intro_bsp"));
            await Engine.sleep(1);
            await this.c03_intro_scene_01();
            await this.c03_intro_scene_02();
            await this.c03_intro_scene_03();
            await this.c03_intro_scene_04();
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(119, Lifecycle.Static)]
        public async Task chief_recovery_sequence()
        {
            Engine.camera_control(false);
            Engine.player_camera_control(true);
            Engine.set_global_sound_environment(1F, 1F, 0F, 0F, 1000, 0F);
            if (GameDifficulty.Easy() == Engine.game_difficulty_get_real())
            {
                Engine.print("recovery - easy");
                Engine.fade_out(0F, 0F, 0F, 0);
                Engine.cinematic_start_movie("oldmombasa_chief_recovery_easy");
                Engine.cinematic_start();
                Engine.cinematic_show_letterbox_immediate(true);
                Engine.interpolator_start("blurry_vision", 1F, 0.001F);
                await Engine.sleep(30);
                Engine.fade_in(0F, 0F, 0F, 30);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\mission\\l03_9000_cor", 3849323514U), default(IGameObject), 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound_remastered\\visual_effects\\oldmombasa_intro_tinnitus", 2187010083U), default(IGameObject), 1F);
                await Engine.sleep(35);
                Engine.fade_out(0F, 0F, 0F, 30);
                await Engine.sleep(45);
                Engine.fade_in(0F, 0F, 0F, 20);
                await Engine.sleep(25);
                Engine.fade_out(0F, 0F, 0F, 15);
                await Engine.sleep(20);
                Engine.fade_in(0F, 0F, 0F, 15);
                Engine.player_enable_input(false);
                Engine.cinematic_stop();
                Engine.cinematic_show_letterbox_immediate(true);
                Engine.interpolator_start("blurry_vision", 0F, 3F);
                await Engine.sleep(30);
                Engine.player_enable_input(true);
                Engine.set_global_sound_environment(1F, 1F, 1F, 1F, 8000, 0F);
            }

            if (GameDifficulty.Normal() == Engine.game_difficulty_get_real())
            {
                Engine.print("recovery - normal");
                Engine.fade_out(0F, 0F, 0F, 0);
                Engine.cinematic_start_movie("oldmombasa_chief_recovery_normal");
                Engine.cinematic_start();
                Engine.cinematic_show_letterbox_immediate(true);
                Engine.interpolator_start("blurry_vision", 1F, 0.001F);
                await Engine.sleep(30);
                Engine.fade_in(0F, 0F, 0F, 30);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\mission\\l03_9030_cor", 3849389051U), default(IGameObject), 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound_remastered\\visual_effects\\oldmombasa_intro_tinnitus", 2187010083U), default(IGameObject), 1F);
                await Engine.sleep(35);
                Engine.fade_out(0F, 0F, 0F, 30);
                await Engine.sleep(45);
                Engine.fade_in(0F, 0F, 0F, 20);
                await Engine.sleep(25);
                Engine.fade_out(0F, 0F, 0F, 15);
                await Engine.sleep(20);
                Engine.fade_in(0F, 0F, 0F, 15);
                Engine.player_enable_input(false);
                Engine.cinematic_stop();
                Engine.cinematic_show_letterbox_immediate(true);
                Engine.interpolator_start("blurry_vision", 0F, 3F);
                await Engine.sleep(30);
                Engine.player_enable_input(true);
                Engine.set_global_sound_environment(1F, 1F, 1F, 1F, 8000, 0F);
            }

            if (GameDifficulty.Heroic() == Engine.game_difficulty_get_real())
            {
                Engine.print("recovery - heroic");
                Engine.fade_out(0F, 0F, 0F, 0);
                Engine.cinematic_start_movie("oldmombasa_chief_recovery_heroic");
                Engine.cinematic_start();
                Engine.cinematic_show_letterbox_immediate(true);
                Engine.interpolator_start("blurry_vision", 1F, 0.001F);
                await Engine.sleep(30);
                Engine.fade_in(0F, 0F, 0F, 30);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\mission\\l03_9020_cor", 3849454588U), default(IGameObject), 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound_remastered\\visual_effects\\oldmombasa_intro_tinnitus", 2187010083U), default(IGameObject), 1F);
                await Engine.sleep(35);
                Engine.fade_out(0F, 0F, 0F, 30);
                await Engine.sleep(45);
                Engine.fade_in(0F, 0F, 0F, 20);
                await Engine.sleep(25);
                Engine.fade_out(0F, 0F, 0F, 15);
                await Engine.sleep(20);
                Engine.fade_in(0F, 0F, 0F, 15);
                Engine.player_enable_input(false);
                Engine.cinematic_stop();
                Engine.cinematic_show_letterbox_immediate(true);
                Engine.interpolator_start("blurry_vision", 0F, 3F);
                await Engine.sleep(30);
                Engine.player_enable_input(true);
                Engine.set_global_sound_environment(1F, 1F, 1F, 1F, 8000, 0F);
            }

            if (GameDifficulty.Legendary() == Engine.game_difficulty_get_real())
            {
                Engine.print("recovery - legendary");
                Engine.fade_out(0F, 0F, 0F, 0);
                Engine.cinematic_start_movie("oldmombasa_chief_recovery_get_real");
                Engine.cinematic_start();
                Engine.cinematic_show_letterbox_immediate(true);
                Engine.interpolator_start("blurry_vision", 1F, 0.001F);
                await Engine.sleep(30);
                Engine.fade_in(0F, 0F, 0F, 30);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\mission\\l03_9010_cor", 3849520125U), default(IGameObject), 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound_remastered\\visual_effects\\oldmombasa_intro_tinnitus", 2187010083U), default(IGameObject), 1F);
                await Engine.sleep(35);
                Engine.fade_out(0F, 0F, 0F, 30);
                await Engine.sleep(45);
                Engine.fade_in(0F, 0F, 0F, 20);
                await Engine.sleep(25);
                Engine.fade_out(0F, 0F, 0F, 15);
                await Engine.sleep(20);
                Engine.fade_in(0F, 0F, 0F, 15);
                Engine.player_enable_input(false);
                Engine.cinematic_stop();
                Engine.cinematic_show_letterbox_immediate(true);
                Engine.interpolator_start("blurry_vision", 0F, 3F);
                await Engine.sleep(30);
                Engine.player_enable_input(true);
                Engine.set_global_sound_environment(1F, 1F, 1F, 1F, 8000, 0F);
            }
        }

        [ScriptMethod(120, Lifecycle.Static)]
        public async Task cinematic_intro()
        {
            if (await this.cinematic_skip_start())
            {
                await this.c03_intro();
            }

            await this.cinematic_skip_stop();
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task chapter_title0()
        {
            await Engine.sleep(30);
            Engine.cinematic_set_title(title0);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
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

        [ScriptMethod(123, Lifecycle.Dormant)]
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

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task objective0_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task objective0_clear()
        {
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task objective1_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task objective1_clear()
        {
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task objective2_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task objective2_clear()
        {
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task objective3_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task objective3_clear()
        {
            Engine.objectives_finish_up_to(3);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task objective4_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(4);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task objective4_clear()
        {
            Engine.objectives_finish_up_to(4);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task music_03a_01_start()
        {
            Engine.print("music 03a_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_01", 2187075620U), default(IGameObject), 1F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task music_03a_01_stop()
        {
            Engine.print("music 03a_01 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_01", 2187075620U));
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task music_03a_02_stop_alt()
        {
            await Engine.sleep(this.two_minutes);
            Engine.print("music 03a_02 stop alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_02", 2187468842U), false);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task music_03a_02_stop()
        {
            await Engine.sleep(this.one_minute);
            Engine.print("music 03a_02 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_02", 2187468842U));
            Engine.sleep_forever(new ScriptMethodReference(music_03a_02_stop_alt));
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task music_03a_02_start_alt()
        {
            Engine.print("music 03a_02 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_02", 2187468842U), true);
            Engine.wake(new ScriptMethodReference(music_03a_02_stop_alt));
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task music_03a_02_start()
        {
            Engine.print("music 03a_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_02", 2187468842U), default(IGameObject), 1F);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task music_03a_03_start()
        {
            Engine.print("music 03a_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_03", 2188255286U), default(IGameObject), 1F);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task music_03a_03_stop()
        {
            Engine.print("music 03a_03 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_03", 2188255286U));
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task music_03a_04_start()
        {
            Engine.print("music 03a_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_04", 2188779582U), default(IGameObject), 1F);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task music_03a_04_stop()
        {
            Engine.print("music 03a_04 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_04", 2188779582U));
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task music_03a_05_start()
        {
            await Engine.sleep(60);
            Engine.print("music 03a_05 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_05", 2189172804U), default(IGameObject), 1F);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task music_03a_05_stop()
        {
            Engine.print("music 03a_05 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_05", 2189172804U));
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task music_03a_06_start()
        {
            Engine.print("music 03a_06 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_06", 2189697100U), default(IGameObject), 1F);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task music_03a_06_stop()
        {
            Engine.print("music 03a_06 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_06", 2189697100U));
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task music_03a_065_start()
        {
            Engine.print("music 03a_065 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_065", 2190090322U), default(IGameObject), 1F);
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task music_03a_065_stop()
        {
            await Engine.sleep(this.two_minutes);
            Engine.print("music 03a_065 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_065", 2190090322U));
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task music_03a_065_start_alt()
        {
            Engine.print("music 03a_065 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_065", 2190090322U), true);
            Engine.wake(new ScriptMethodReference(music_03a_065_stop));
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task music_03a_066_start()
        {
            Engine.print("music 03a_066 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_066", 2190745692U), default(IGameObject), 1F);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task music_03a_067_start()
        {
            Engine.print("music 03a_067 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_067", 2191007840U), default(IGameObject), 1F);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task music_03a_067_stop()
        {
            Engine.print("music 03a_067 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_067", 2191007840U));
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task music_03a_07_start()
        {
            Engine.print("music 03a_07 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_07", 2191401062U), default(IGameObject), 1F);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task music_03a_07_stop()
        {
            Engine.print("music 03a_07 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_07", 2191401062U));
        }

        [ScriptMethod(156, Lifecycle.Static)]
        public async Task<bool> player_in_vehicle()
        {
            return Engine.unit_in_vehicle(Engine.unit(await this.player0())) || (bool)Engine.game_is_cooperative() && Engine.unit_in_vehicle(Engine.unit(await this.player1()));
        }

        [ScriptMethod(157, Lifecycle.Static)]
        public async Task<bool> players_in_vehicle()
        {
            return Engine.unit_in_vehicle(Engine.unit(await this.player0())) && !((bool)Engine.game_is_cooperative()) || Engine.unit_in_vehicle(Engine.unit(await this.player1()));
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task flashlight_control()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.structure_bsp_index() == 2 || Engine.volume_test_objects(tv_dark_area0, Engine.players()) || Engine.volume_test_objects(tv_dark_area1, Engine.players()) || Engine.volume_test_objects(tv_dark_area2, Engine.players()) || Engine.volume_test_objects(tv_dark_area3, Engine.players()))
                {
                    Engine.game_can_use_flashlights(true);
                    Engine.weapon_enable_warthog_chaingun_light(true);
                }
                else
                {
                    Engine.game_can_use_flashlights(false);
                    Engine.weapon_enable_warthog_chaingun_light(false);
                }

                return false;
            }, 60);
        }

        [ScriptMethod(159, Lifecycle.CommandScript)]
        public async Task cs_e13_mars_continue()
        {
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_mars_exit/p0"));
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_mars_exit/p1"));
            Engine.cs_ignore_obstacles(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_mars_exit/p2"));
        }

        [ScriptMethod(160, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_unload()
        {
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_sc01");
            Engine.ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(161, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_end0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/first_end"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/end_facing"));
            await Engine.sleep(150);
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_unload));
        }

        [ScriptMethod(162, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_end1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/second_end"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/end_facing"));
            await Engine.sleep(150);
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_unload));
        }

        [ScriptMethod(163, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_end2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/third_end"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/end_facing"));
            await Engine.sleep(150);
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_unload));
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_drive1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p11"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/end"));
            if (this.g_e13_creep_end0_free == true)
            {
                Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_end0));
                this.g_e13_creep_end0_free = false;
            }
            else if (this.g_e13_creep_end1_free == true)
            {
                Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_end1));
                this.g_e13_creep_end1_free = false;
            }
            else if (this.g_e13_creep_end2_free == true)
            {
                Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_end2));
                this.g_e13_creep_end2_free = false;
            }
        }

        [ScriptMethod(165, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_drive0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p2"), 1F);
            Engine.cs_ignore_obstacles(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p2_0"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p3"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p4"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p5"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p5_1"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p6"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p7"), 0.5F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p8"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p9_0"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p9_1"), 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_chase/p10"), 1F);
        }

        [ScriptMethod(166, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_0_decision()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            if ((short)Engine.ai_living_count(e13_cov_creep0_1.creep0) <= 0 && (short)Engine.ai_living_count(e13_cov_creep0_2.creep0) <= 0)
            {
                Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_drive1));
                Engine.ai_set_orders(this.ai_current_squad, e13_cov_creep0_defend);
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_0_mid"));
                Engine.cs_vehicle_boost(false);
                Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_0_mid_facing"));
                await Engine.sleep(60);
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_p_l01");
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_p_r01");
                await Engine.sleep(60);
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_sc01");
                Engine.ai_vehicle_exit(this.ai_current_actor);
                await Engine.sleep(30);
                Engine.ai_vehicle_enter(this.ai_current_actor, Engine.ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost0));
            }
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_1_decision()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            if ((short)Engine.ai_living_count(e13_cov_creep0_0.creep0) <= 0 && (short)Engine.ai_living_count(e13_cov_creep0_2.creep0) <= 0)
            {
                Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_drive1));
                Engine.ai_set_orders(this.ai_current_squad, e13_cov_creep0_defend);
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_1_mid"));
                Engine.cs_vehicle_boost(false);
                Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_1_mid_facing"));
                await Engine.sleep(60);
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_p_l01");
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_p_r01");
                await Engine.sleep(60);
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_sc01");
                Engine.ai_vehicle_exit(this.ai_current_actor);
                await Engine.sleep(30);
                Engine.ai_vehicle_enter(this.ai_current_actor, Engine.ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost1));
            }
        }

        [ScriptMethod(168, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_2_decision()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            if ((short)Engine.ai_living_count(e13_cov_creep0_0.creep0) > 0 && (short)Engine.ai_living_count(e13_cov_creep0_1.creep0) > 0)
            {
                Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_drive1));
                Engine.ai_set_orders(this.ai_current_squad, e13_cov_creep0_defend);
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_2_mid"));
                Engine.cs_vehicle_boost(false);
                Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_2_mid_facing"));
                await Engine.sleep(60);
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_p_l01");
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_p_r01");
                await Engine.sleep(60);
                Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "creep_sc01");
                Engine.ai_vehicle_exit(this.ai_current_actor);
                await Engine.sleep(30);
                Engine.ai_vehicle_enter(this.ai_current_actor, Engine.ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost2));
            }
        }

        [ScriptMethod(169, Lifecycle.CommandScript)]
        public async Task cs_e13_mars_warthog0_drive()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_alert(true);
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e13_mars_warthog1_ketchup/p0"), Engine.GetReference<ISpatialPoint>("e13_mars_warthog1_ketchup/p1"));
        }

        [ScriptMethod(170, Lifecycle.Static)]
        public async Task<bool> e13_end_clear()
        {
            return !(Engine.volume_test_objects(tv_e13_end_area, Engine.ai_actors(e13_cov)));
        }

        [ScriptMethod(171, Lifecycle.Static)]
        public async Task<bool> e13_waypoint1_clear()
        {
            return !(Engine.volume_test_objects(tv_e13_waypoint1, Engine.ai_actors(e13_cov)));
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task<bool> e13_waypoint1()
        {
            return Engine.volume_test_objects(tv_e13_waypoint1, Engine.ai_actors(this.ai_current_squad));
        }

        [ScriptMethod(173, Lifecycle.Static)]
        public async Task<bool> e13_waypoint0()
        {
            return Engine.volume_test_objects(tv_e13_waypoint0, Engine.ai_actors(this.ai_current_squad));
        }

        [ScriptMethod(174, Lifecycle.Static)]
        public async Task e13_mars_exit()
        {
            Engine.cs_run_command_script(this.ai_current_squad, new ScriptMethodReference(cs_e13_mars_continue));
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task e13_navpoints()
        {
            Engine.activate_team_nav_point_object(_default, player, Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0), 1.5F);
            await Engine.sleep_until(async () => Engine.unit_get_health(Engine.ai_get_unit(e13_cov_creep0_0.creep0)) <= 0F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0)) < Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0)) || Engine.volume_test_objects(tv_e13_waypoint1, Engine.players()));
            Engine.deactivate_team_nav_point_object(player, Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0));
            Engine.activate_team_nav_point_object(_default, player, Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0), 1.5F);
            await Engine.sleep_until(async () => Engine.unit_get_health(Engine.ai_get_unit(e13_cov_creep0_1.creep0)) <= 0F || Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0)) < Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0)) || Engine.volume_test_objects(tv_e13_waypoint1, Engine.players()));
            Engine.deactivate_team_nav_point_object(player, Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0));
            Engine.activate_team_nav_point_object(_default, player, Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0), 1.5F);
            await Engine.sleep_until(async () => Engine.unit_get_health(Engine.ai_get_unit(e13_cov_creep0_2.creep0)) <= 0F || Engine.volume_test_objects(tv_e13_waypoint1, Engine.players()));
            Engine.deactivate_team_nav_point_object(player, Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0));
            if (Engine.unit_get_health(Engine.ai_get_unit(e13_cov_creep0_3.creep0)) > 0F)
            {
                Engine.activate_team_nav_point_object(_default, player, Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_3.creep0), 1.5F);
                await Engine.sleep_until(async () => Engine.unit_get_health(Engine.ai_get_unit(e13_cov_creep0_3.creep0)) <= 0F || Engine.volume_test_objects(tv_e13_end_entrance, Engine.players()));
            }

            Engine.deactivate_team_nav_point_object(player, Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_3.creep0));
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task e13_cov_ghosts1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e13_cov_creep0_6_begin, Engine.players()), 15);
            Engine.ai_place(e13_cov_ghosts1.Squad);
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task e13_cov_creep0_ghost_aux()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e13_creep0_begin, Engine.players()), 15);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0), "creep_sc01", Engine.ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost0));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0), "creep_sc01", Engine.ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost1));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0), "creep_sc01", Engine.ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost2));
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e13_cov_creep0_0.creep0) <= 0)
                {
                    Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0), "creep_sc01");
                }

                if ((short)Engine.ai_living_count(e13_cov_creep0_1.creep0) <= 0)
                {
                    Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0), "creep_sc01");
                }

                if ((short)Engine.ai_living_count(e13_cov_creep0_2.creep0) <= 0)
                {
                    Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0), "creep_sc01");
                }

                return false;
            }, 60);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task e13_cov_creep0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e13_creep0_begin, Engine.players()));
            Engine.wake(new ScriptMethodReference(music_03a_067_stop));
            Engine.wake(new ScriptMethodReference(music_03a_07_start));
            Engine.ai_place(e13_cov_ghosts0.Squad);
            Engine.ai_place(e13_cov_creep0_0.Squad);
            Engine.ai_place(e13_cov_creep0_1.Squad);
            Engine.ai_place(e13_cov_creep0_2.Squad);
            await Engine.sleep(2);
            Engine.wake(new ScriptMethodReference(e13_cov_creep0_ghost_aux));
            Engine.cs_queue_command_script(e13_cov_creep0_0.creep0, new ScriptMethodReference(cs_e13_cov_creep0_0_decision));
            Engine.cs_queue_command_script(e13_cov_creep0_1.creep0, new ScriptMethodReference(cs_e13_cov_creep0_1_decision));
            Engine.cs_queue_command_script(e13_cov_creep0_2.creep0, new ScriptMethodReference(cs_e13_cov_creep0_2_decision));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e13_dialog, Engine.players()));
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0590"));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e13_cov_creep0_reins0, Engine.players()), 15);
            Engine.game_save();
            if ((short)Engine.ai_living_count(e13_cov_creep0_0.creep0) <= 0 || (short)Engine.ai_living_count(e13_cov_creep0_1.creep0) <= 0 || (short)Engine.ai_living_count(e13_cov_creep0_2.creep0) <= 0)
            {
                Engine.ai_place(e13_cov_creep0_3.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e13_cov_creep0_6_begin, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_03a_07_stop));
            Engine.game_save();
            Engine.ai_place(e13_cov_creep0_6.Squad);
            await Engine.sleep(30);
            Engine.object_dynamic_simulation_disable(Engine.ai_vehicle_get_from_starting_location(e13_cov_creep0_6.creep0), true);
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task e13_mars_warthog0_main()
        {
            Engine.ai_migrate(e12_mars_warthog0.Squad, e13_mars_warthog0.Squad);
            Engine.ai_migrate(e12_mars_warthog1.Squad, e13_mars_warthog0.Squad);
            Engine.ai_disposable(e13_mars_warthog0.Squad, false);
            Engine.ai_renew(e13_mars_warthog0.Squad);
            Engine.cs_run_command_script(e13_mars_warthog0.Squad, new ScriptMethodReference(cs_e13_mars_warthog0_drive));
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task e13_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e13_main_begin, Engine.players()), 10);
            this.g_e13_started = true;
            Engine.print("e13_main");
            Engine.data_mine_set_mission_segment("e13_tunnel_convoy");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e13_mars_warthog0_main));
            Engine.wake(new ScriptMethodReference(e13_cov_creep0_main));
            Engine.wake(new ScriptMethodReference(e13_cov_ghosts1_main));
        }

        [ScriptMethod(181, Lifecycle.Static)]
        public async Task test_tunnel_convoy()
        {
            Engine.switch_bsp(2);
            Engine.object_teleport(await this.player0(), e13_test);
            Engine.ai_place(e13_mars_warthog0.Squad);
            if (!(this.g_e13_started))
            {
                Engine.wake(new ScriptMethodReference(e13_main));
            }
        }

        [ScriptMethod(182, Lifecycle.CommandScript)]
        public async Task cs_e12_mars_horrible_cleanup()
        {
            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 50F && !(Engine.unit_in_vehicle(Engine.ai_get_unit(this.ai_current_actor))))
            {
                Engine.ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(183, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_ghost_drop()
        {
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(this.ai_current_actor), true);
            Engine.ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(184, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_0_ghost0()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e12_cov_inf0_0.Squad) >= this.ai_combat_status_active, 15);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e12_patrol/p0_2"));
        }

        [ScriptMethod(185, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_0_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e12_patrol/p0_0"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e12_patrol/p0_1"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(186, Lifecycle.CommandScript)]
        public async Task cs_e12_scarab_gunner()
        {
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e12_scarab/p0"));
            await Engine.sleep(165);
        }

        [ScriptMethod(187, Lifecycle.CommandScript)]
        public async Task cs_e12_mars_warthog0_cleanup()
        {
            if (!(Engine.volume_test_object(tv_e12_mars_warthog0_preserve, Engine.ai_get_object(this.ai_current_actor))))
            {
                Engine.ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(188, Lifecycle.CommandScript)]
        public async Task cs_e12_ghosts_entry()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_moving(true);
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(150);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task e12_cov_ghosts0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()), 15);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_cov_ghosts0_begin, Engine.players()), 15);
            Engine.ai_place(e12_cov_ghosts0.Squad);
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task scarab_walk_front_var0()
        {
            Engine.print("scarab_walk_front_var0");
            Engine.device_set_position_track(tunnel_scarab.Entity, "combat:walk_front:var0", 0F);
            Engine.device_animate_position(tunnel_scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(tunnel_scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task e12_event_warthog()
        {
            Engine.object_create(e12_warthog0);
            Engine.object_set_velocity(e12_warthog0.Entity, 11F, 0F, 0.25F);
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task e12_event_scarab_gun()
        {
            Engine.object_create(e12_scarab_gun);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e12_scarab_gun"), 0, true);
            await Engine.sleep(90);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e12_scarab_gun"), 0, false);
            Engine.wake(new ScriptMethodReference(e12_cov_ghosts0_main));
            await Engine.sleep(60);
            Engine.object_destroy(e12_scarab_gun.Entity);
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task e12_event_scarab()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()), 8);
            Engine.wake(new ScriptMethodReference(e12_event_warthog));
            await Engine.sleep(26);
            Engine.wake(new ScriptMethodReference(e12_event_scarab_gun));
            Engine.wake(new ScriptMethodReference(music_03a_066_start));
            Engine.wake(new ScriptMethodReference(music_03a_067_start));
            Engine.object_create(tunnel_scarab);
            Engine.pvs_set_object(tunnel_scarab.Entity);
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            if (Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()))
            {
                await this.scarab_walk_front_var0();
            }

            Engine.object_destroy(tunnel_scarab.Entity);
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task e12_cortana_dialog()
        {
            await Engine.sleep(30);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0070"));
            await Engine.sleep(20);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0080"));
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task e12_cov_creep0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_cov_inf0_5_begin, Engine.players()), 10);
            Engine.ai_place(e12_cov_creep0.Squad);
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task e12_cov_inf0_main()
        {
            Engine.ai_place(e12_cov_inf0_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_cov_inf0_2_begin, Engine.players()), 10);
            Engine.game_save();
            Engine.ai_disposable(e12_cov_inf0_0.Squad, true);
            Engine.ai_place(e12_cov_inf0_1.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_cov_inf0_3_begin, Engine.players()), 10);
            Engine.ai_disposable(e12_cov_inf0_1.Squad, true);
            Engine.ai_place(e12_cov_inf0_2.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_cov_inf0_6_begin, Engine.players()), 10);
            Engine.game_save();
            Engine.ai_disposable(e12_cov_inf0_2.Squad, true);
            Engine.ai_place(e12_cov_inf0_6.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_cov_inf0_4_begin, Engine.players()), 10);
            Engine.game_save();
            Engine.ai_place(e12_cov_inf0_4.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_cov_inf0_6_migrate, Engine.players()), 10);
            Engine.ai_migrate(e12_cov_inf0_6.Squad, e12_cov_inf0_4.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_scarab_begin, Engine.players()), 8);
            Engine.ai_disposable(e12_cov_inf0_4.Squad, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_cov_inf0_5_begin, Engine.players()), 10);
            Engine.game_save();
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task e12_mars_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_mars_inf1_begin, Engine.players()), 15);
            Engine.ai_place(e12_mars_inf1.Squad);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task e12_mars_inf0_main()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task e12_mars_warthog1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_mars_warthog1_begin, Engine.players()), 10);
            Engine.cs_run_command_script(e12_mars_warthog0.Squad, new ScriptMethodReference(cs_e12_mars_horrible_cleanup));
            await Engine.sleep(15);
            if ((short)Engine.ai_living_count(e12_mars_warthog0.Squad) <= 2)
            {
                Engine.ai_place(e12_mars_warthog1.Squad);
            }
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task e12_mars_warthog0_main()
        {
            Engine.ai_migrate(e11_mars_warthog0.Squad, e12_mars_warthog0.Squad);
            Engine.ai_renew(e12_mars_warthog0.Squad);
            Engine.ai_disposable(e12_mars_warthog0.Squad, false);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.cs_run_command_script(e12_mars_warthog0.Squad, new ScriptMethodReference(cs_e12_mars_warthog0_cleanup));
            await Engine.sleep(15);
            Engine.game_save();
            if ((short)Engine.ai_living_count(e12_mars_warthog0.Squad) < 4)
            {
                Engine.ai_place(e12_mars_warthog0.Squad);
            }
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task e12_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_main_begin, Engine.players()), 15);
            this.g_e12_started = true;
            Engine.print("e12_main");
            Engine.data_mine_set_mission_segment("e12_tunnel_blockades");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(chapter_title2));
            Engine.wake(new ScriptMethodReference(e13_main));
            Engine.wake(new ScriptMethodReference(e12_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e12_cov_creep0_main));
            Engine.wake(new ScriptMethodReference(e12_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e12_mars_warthog0_main));
            Engine.wake(new ScriptMethodReference(e12_mars_warthog1_main));
            Engine.wake(new ScriptMethodReference(e12_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e12_mars_inf1_main));
            Engine.wake(new ScriptMethodReference(e12_event_scarab));
            Engine.wake(new ScriptMethodReference(e12_cortana_dialog));
            await Engine.sleep_until(async () => this.g_e13_started);
            Engine.sleep_forever(new ScriptMethodReference(e12_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_cov_creep0_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_cov_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_mars_warthog0_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_mars_warthog1_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_mars_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_event_scarab));
            Engine.sleep_forever(new ScriptMethodReference(e12_cortana_dialog));
            Engine.ai_disposable(e12_cov, true);
        }

        [ScriptMethod(202, Lifecycle.Static)]
        public async Task test_tunnel_blockades()
        {
            Engine.switch_bsp(2);
            Engine.object_teleport(await this.player0(), e12_test);
            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(203, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_phantom0_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e11_cov_phantom0/p0"), 1F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e11_cov_phantom0/p1"), Engine.GetReference<ISpatialPoint>("e11_cov_phantom0/p2"), 1F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e11_cov_phantom0/p2"), Engine.GetReference<ISpatialPoint>("e11_cov_phantom0/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_cov_phantom0/p3"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_inf0_shoot0()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e11_patrol/s0"));
            await Engine.sleep((short)Engine.random_range(this._30_seconds, this.one_minute));
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_inf0_shoot1()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e11_patrol/s1"));
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e11_patrol/p1"));
                await Engine.sleep((short)Engine.random_range(60, 90));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e11_patrol/p0"));
                await Engine.sleep((short)Engine.random_range(90, 120));
                return false;
            }, 30, this._30_seconds);
        }

        [ScriptMethod(206, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_inf0_shoot2()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e11_patrol/s2"));
            await Engine.sleep((short)Engine.random_range(this._30_seconds, this.one_minute));
        }

        [ScriptMethod(207, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_ghosts0_entry()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("e11_cov_ghosts0/p0"), Engine.GetReference<ISpatialPoint>("e11_cov_ghosts0/p1"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e11_cov_ghosts0/p1"));
        }

        [ScriptMethod(208, Lifecycle.Static)]
        public async Task<bool> e11_cov_phantom0_leaving()
        {
            return this.g_e11_cov_phantom0_leaving == true;
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_0_insertion0()
        {
            Engine.ai_place(e11_cov_inf1_0.elite0);
            Engine.object_create(e11_pod0_inserter);
            Engine.objects_attach(e11_pod0_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e11_cov_inf1_0.elite0), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e11_pod0_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e11_pod0_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e11_pod_impact_effect, Engine.ai_vehicle_get(e11_cov_inf1_0.elite0), "pod_attach");
            Engine.objects_detach(e11_pod0_inserter.Entity, Engine.ai_vehicle_get(e11_cov_inf1_0.elite0));
            Engine.object_destroy(e11_pod0_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e11_cov_inf1_0.elite0), "door", 500F);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(e11_cov_inf1_0.elite0);
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_0_insertion1()
        {
            Engine.ai_place(e11_cov_inf1_0.elite1);
            Engine.object_create(e11_pod1_inserter);
            Engine.objects_attach(e11_pod1_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e11_cov_inf1_0.elite1), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e11_pod1_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e11_pod1_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e11_pod_impact_effect, Engine.ai_vehicle_get(e11_cov_inf1_0.elite1), "pod_attach");
            Engine.objects_detach(e11_pod1_inserter.Entity, Engine.ai_vehicle_get(e11_cov_inf1_0.elite1));
            Engine.object_destroy(e11_pod1_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e11_cov_inf1_0.elite1), "door", 500F);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(e11_cov_inf1_0.elite1);
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_0_insertion2()
        {
            Engine.ai_place(e11_cov_inf1_0.elite2);
            Engine.object_create(e11_pod2_inserter);
            Engine.objects_attach(e11_pod2_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e11_cov_inf1_0.elite2), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e11_pod2_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e11_pod2_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e11_pod_impact_effect, Engine.ai_vehicle_get(e11_cov_inf1_0.elite2), "pod_attach");
            Engine.objects_detach(e11_pod2_inserter.Entity, Engine.ai_vehicle_get(e11_cov_inf1_0.elite2));
            Engine.object_destroy(e11_pod2_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e11_cov_inf1_0.elite2), "door", 500F);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(e11_cov_inf1_0.elite2);
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_1_insertion0()
        {
            Engine.ai_place(e11_cov_inf1_1.elite0);
            Engine.object_create(e11_pod3_inserter);
            Engine.objects_attach(e11_pod3_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e11_cov_inf1_1.elite0), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e11_pod3_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e11_pod3_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e11_pod_impact_effect, Engine.ai_vehicle_get(e11_cov_inf1_1.elite0), "pod_attach");
            Engine.objects_detach(e11_pod3_inserter.Entity, Engine.ai_vehicle_get(e11_cov_inf1_1.elite0));
            Engine.object_destroy(e11_pod3_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e11_cov_inf1_1.elite0), "door", 500F);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(e11_cov_inf1_1.elite0);
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_1_insertion1()
        {
            Engine.ai_place(e11_cov_inf1_1.elite1);
            Engine.object_create(e11_pod4_inserter);
            Engine.objects_attach(e11_pod4_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e11_cov_inf1_1.elite1), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e11_pod4_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e11_pod4_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e11_pod_impact_effect, Engine.ai_vehicle_get(e11_cov_inf1_1.elite1), "pod_attach");
            Engine.objects_detach(e11_pod4_inserter.Entity, Engine.ai_vehicle_get(e11_cov_inf1_1.elite1));
            Engine.object_destroy(e11_pod4_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e11_cov_inf1_1.elite1), "door", 500F);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(e11_cov_inf1_1.elite1);
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_1_insertion2()
        {
            Engine.ai_place(e11_cov_inf1_1.elite2);
            Engine.object_create(e11_pod5_inserter);
            Engine.objects_attach(e11_pod5_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e11_cov_inf1_1.elite2), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e11_pod5_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e11_pod5_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e11_pod_impact_effect, Engine.ai_vehicle_get(e11_cov_inf1_1.elite2), "pod_attach");
            Engine.objects_detach(e11_pod5_inserter.Entity, Engine.ai_vehicle_get(e11_cov_inf1_1.elite2));
            Engine.object_destroy(e11_pod5_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e11_cov_inf1_1.elite2), "door", 500F);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(e11_cov_inf1_1.elite2);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_1_insertion3()
        {
            Engine.ai_place(e11_cov_inf1_1.elite3);
            Engine.object_create(e11_pod6_inserter);
            Engine.objects_attach(e11_pod6_inserter.Entity, "pod_attach", Engine.ai_vehicle_get(e11_cov_inf1_1.elite3), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(e11_pod6_inserter.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(e11_pod6_inserter.Entity) >= 1F, 1);
            Engine.effect_new_on_object_marker(this.g_e11_pod_impact_effect, Engine.ai_vehicle_get(e11_cov_inf1_1.elite3), "pod_attach");
            Engine.objects_detach(e11_pod6_inserter.Entity, Engine.ai_vehicle_get(e11_cov_inf1_1.elite3));
            Engine.object_destroy(e11_pod6_inserter.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(e11_cov_inf1_1.elite3), "door", 500F);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(e11_cov_inf1_1.elite3);
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task e11_warthog_approach_horn()
        {
            Engine.print("honk");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U), Engine.ai_vehicle_get_from_starting_location(e11_mars_warthog0.warthog0), 1.5F);
            await Engine.sleep(30);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U));
        }

        [ScriptMethod(217, Lifecycle.CommandScript)]
        public async Task cs_e11_warthog_approach()
        {
            Engine.cs_approach_player(10F, 100F, 100F);
            Engine.wake(new ScriptMethodReference(e11_warthog_approach_horn));
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_approach_player(5F, 100F, 100F);
            await Engine.sleep_until(async () => await this.player_in_vehicle() || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 10F || !(Engine.unit_in_vehicle(Engine.ai_get_unit(this.ai_current_actor))));
        }

        [ScriptMethod(218, Lifecycle.Dormant)]
        public async Task e11_miranda_dialog()
        {
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0560"));
            Engine.game_save();
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task e11_dialog()
        {
            await Engine.sleep(150);
            await Engine.sleep_until(async () => Engine.objects_can_see_flag(Engine.players(), e11_cov_inf1_entry, 15F) && Engine.volume_test_objects_all(tv_e11_area, Engine.players()));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e11_tunnel_entrance, Engine.players()));
            Engine.ai_play_line_on_object(default(IGameObject), "0580") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task e11_navpoint()
        {
            await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), e11_tunnel_entrance) > 50F, 30, this._30_seconds);
            Engine.print("navpoint up");
            Engine.activate_team_nav_point_flag(_default, player, e11_tunnel_entrance, 0F);
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task e11_navpoint_kill()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e11_tunnel_entrance, Engine.players()), 15);
            Engine.sleep_forever(new ScriptMethodReference(e11_navpoint));
            Engine.print("navpoint down");
            Engine.deactivate_team_nav_point_flag(player, e11_tunnel_entrance);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task e11_cov_phantom0_main()
        {
            await Engine.sleep_until(async () => this.g_e10_cov_phantom0_leaving, 15);
            Engine.ai_set_orders(e10_cov_phantom0.Squad, e11_cov_phantom0_init);
            await Engine.sleep_until(async () => Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e10_cov_phantom0.phantom0), "target_front") >= 2 || Engine.object_get_health(Engine.ai_vehicle_get(e10_cov_phantom0.phantom0)) <= 0.05F || (short)Engine.ai_spawn_count(e11_cov_ghosts0_1.Squad) > 0, 30, this.one_minute);
            await Engine.sleep_until(async () => Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e10_cov_phantom0.phantom0), "target_front") >= 2 || Engine.object_get_health(Engine.ai_vehicle_get(e10_cov_phantom0.phantom0)) <= 0.05F, 30, this.one_minute);
            this.g_e11_cov_phantom0_leaving = true;
            Engine.cs_run_command_script(e10_cov_phantom0.phantom0, new ScriptMethodReference(cs_e11_cov_phantom0_exit));
            await Engine.sleep(120);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e11_navpoint));
            Engine.wake(new ScriptMethodReference(e11_navpoint_kill));
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task e11_cov_ghosts0_main()
        {
            Engine.ai_migrate(e10_cov_ghosts0, e11_cov_ghosts0_0.Squad);
            Engine.ai_place(e11_cov_ghosts0_0.Squad, (short)Engine.pin(3F - (float)Engine.ai_living_count(e11_cov_ghosts0_0.Squad), 0F, 2F));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e11_cov_ghosts0) <= 0);
            Engine.game_save();
            await Engine.sleep(this._30_seconds);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_e11_area, Engine.players()));
            Engine.ai_place(e11_cov_ghosts0_1.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e11_cov_ghosts0) <= 0);
            Engine.game_save();
            await Engine.sleep(this._30_seconds);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_e11_area, Engine.players()));
            Engine.ai_place(e11_cov_ghosts0_1.Squad);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task e11_cov_inf2_main()
        {
            Engine.ai_place(e11_cov_inf2.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e11_on_fort, Engine.players()) || Engine.objects_distance_to_flag(Engine.players(), e11_cov_inf1_entry) < 40F, 10);
            Engine.device_group_set_immediate(e11_watchtower0, 1F);
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e11_on_fort, Engine.players()) || Engine.volume_test_objects(tv_e11_near_exit, Engine.players()), 10);
            await Engine.sleep(30);
            if (!(Engine.volume_test_objects(tv_e11_near_exit, Engine.players())))
            {
                await Engine.sleep_until(async () => Engine.objects_can_see_flag(Engine.players(), e11_cov_inf1_entry, 25F), 60, 300);
                Engine.wake(new ScriptMethodReference(e11_cov_inf1_0_insertion0));
                await Engine.sleep(20);
                Engine.wake(new ScriptMethodReference(e11_cov_inf1_0_insertion1));
                await Engine.sleep(10);
                if ((short)Engine.ai_living_count(covenant1) < 10)
                {
                    Engine.wake(new ScriptMethodReference(e11_cov_inf1_0_insertion2));
                }
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e11_near_exit, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(e11_cov_inf1_1_insertion0));
            await Engine.sleep(15);
            Engine.wake(new ScriptMethodReference(e11_cov_inf1_1_insertion1));
            await Engine.sleep(7);
            if ((short)Engine.ai_living_count(covenant1) < 10)
            {
                Engine.wake(new ScriptMethodReference(e11_cov_inf1_1_insertion2));
            }

            await Engine.sleep(25);
            if ((short)Engine.ai_living_count(covenant1) < 10)
            {
                Engine.wake(new ScriptMethodReference(e11_cov_inf1_1_insertion3));
            }
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task e11_cov_inf0_main()
        {
            Engine.ai_place(e11_cov_inf0.Squad);
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task e11_mars_inf0_main()
        {
            if (!((bool)Engine.game_is_cooperative()))
            {
                Engine.ai_place(e11_mars_inf0.Squad, (short)Engine.pin(3F - (float)Engine.ai_living_count(marines), 1F, 2F));
            }
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task e11_mars_warthog0_main()
        {
            Engine.ai_migrate(e10_mars_warthog0.Squad, e11_mars_warthog0.Squad);
            Engine.ai_migrate(e10_mars_inf0.Squad, e11_mars_warthog0.Squad);
            Engine.ai_renew(e11_mars_warthog0.Squad);
            Engine.ai_disposable(e11_mars_warthog0.Squad, false);
            await Engine.sleep_until(async () => !(await this.player_in_vehicle()) && !(Engine.volume_test_object(tv_beach, this.g_e8_warthog)) || Engine.object_get_health(this.g_e8_warthog) <= 0F && !(Engine.volume_test_object(tv_beach, this.g_e10_warthog)) || Engine.object_get_health(this.g_e10_warthog) <= 0F);
            await Engine.sleep(this._15_seconds);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e11_mars_warthog0_unsafe, Engine.players())));
            Engine.ai_place(e11_mars_warthog0.Squad);
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task e11_warthog_for_the_masses()
        {
            await Engine.sleep(300);
            Engine.object_create(warthog_for_the_masses);
            await Engine.sleep(2);
            Engine.object_cannot_die(warthog_for_the_masses.Entity, true);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task e11_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e11_main_begin, Engine.players()), 15);
            this.g_e11_started = true;
            Engine.print("e11_main");
            Engine.data_mine_set_mission_segment("e11_tunnel_entrance");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(objective3_clear));
            Engine.wake(new ScriptMethodReference(objective4_set));
            Engine.wake(new ScriptMethodReference(e11_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e11_mars_warthog0_main));
            Engine.wake(new ScriptMethodReference(e11_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e11_cov_inf2_main));
            Engine.wake(new ScriptMethodReference(e11_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e11_cov_phantom0_main));
            Engine.wake(new ScriptMethodReference(e11_dialog));
            Engine.wake(new ScriptMethodReference(e11_miranda_dialog));
            Engine.wake(new ScriptMethodReference(e11_warthog_for_the_masses));
            await Engine.sleep_until(async () => this.g_e12_started);
            Engine.sleep_forever(new ScriptMethodReference(e11_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_mars_warthog0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_cov_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_cov_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_cov_phantom0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_dialog));
            Engine.ai_disposable(e11_cov, true);
            await Engine.sleep_until(async () => this.g_e13_started);
            Engine.ai_erase(e11_mars);
            Engine.ai_erase(e11_cov);
        }

        [ScriptMethod(231, Lifecycle.Static)]
        public async Task test_tunnel_entrance()
        {
            Engine.switch_bsp(1);
            Engine.object_teleport(await this.player0(), e11_test);
            Engine.ai_place(e11_mars_warthog0.Squad);
            if (!(this.g_e11_started))
            {
                Engine.wake(new ScriptMethodReference(e11_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(232, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_guntower_shoot()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e10_cov_guntower/p0")), 
                    async () => await Engine.sleep((short)Engine.random_range(125, 200)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e10_cov_guntower/p1")), 
                    async () => await Engine.sleep((short)Engine.random_range(125, 200)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e10_cov_guntower/p2")), 
                    async () => await Engine.sleep((short)Engine.random_range(125, 200)));
                return (float)Engine.ai_strength(this.ai_current_actor) <= 0.65F || (float)Engine.ai_strength(this.ai_current_squad) <= 0.5F;
            });
            Engine.ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(233, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_phantom0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e10_cov_phantom0/p0"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e10_cov_phantom0/p1"));
            this.g_e10_cov_phantom0_arrived = true;
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e10_cov_phantom0/p2"), Engine.GetReference<ISpatialPoint>("e10_cov_phantom0/p2_facing"), 0.5F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e10_cov_phantom0/p2_facing"));
            await Engine.sleep(30);
            this.g_e10_cov_ghosts0_unloaded = true;
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_sc");
        }

        [ScriptMethod(234, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_phantom0_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e10_cov_phantom0/p2_facing"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e10_cov_phantom0/p3"), 1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e10_cov_phantom0/p4"), 1F);
            await Engine.sleep_until(async () => this.g_e11_started);
        }

        [ScriptMethod(235, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_inf0_patrol1()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_patrol/p2"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e10_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e10_patrol/f0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_patrol/p3"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(236, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_inf0_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_patrol/p0"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e10_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e10_patrol/f0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e10_patrol/p1"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task e10_warthog_approach_horn()
        {
            Engine.print("honk");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U), this.g_e10_warthog, 1.5F);
            await Engine.sleep(30);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U));
        }

        [ScriptMethod(238, Lifecycle.CommandScript)]
        public async Task cs_e10_warthog_approach()
        {
            Engine.cs_approach_player(10F, 100F, 100F);
            Engine.wake(new ScriptMethodReference(e10_warthog_approach_horn));
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_approach_player(5F, 100F, 100F);
            await Engine.sleep_until(async () => await this.player_in_vehicle() || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 10F || !(Engine.unit_in_vehicle(Engine.ai_get_unit(this.ai_current_actor))));
        }

        [ScriptMethod(239, Lifecycle.Static)]
        public async Task<bool> e10_cov_phantom0_threat()
        {
            return this.g_e10_cov_phantom0_arrived && !(this.g_e10_cov_phantom0_leaving);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task e10_cov_phantom0_main()
        {
            await Engine.sleep_until(async () => (float)Engine.ai_strength(e10_cov) <= 0.4F || Engine.volume_test_objects(tv_e10_cov_phantom0_begin, Engine.players()), 15);
            Engine.ai_place(e10_cov_phantom0.Squad);
            await Engine.sleep_until(async () => this.g_e10_cov_ghosts0_unloaded);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e10_cov_ghosts0_1.Squad) > 0 && (short)Engine.ai_living_count(e10_cov_ghosts0) <= 0 || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e10_cov_phantom0.phantom0), "target_front") >= 3 || Engine.object_get_health(Engine.ai_vehicle_get(e10_cov_phantom0.phantom0)) <= 0.05F || this.g_e11_started, 30, this.one_minute);
            this.g_e10_cov_phantom0_leaving = true;
            Engine.ai_set_orders(e10_cov_phantom0.Squad, e10_cov_phantom0_retreat0);
            Engine.cs_run_command_script(e10_cov_phantom0.phantom0, new ScriptMethodReference(cs_e10_cov_phantom0_exit));
            await Engine.sleep(120);
            Engine.game_save();
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task e10_cov_ghosts0_main()
        {
            Engine.ai_place(e10_cov_ghosts1.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e10_cov_phantom0.Squad) > 0);
            Engine.ai_place_in_vehicle(e10_cov_ghosts0_0.Squad, e10_cov_phantom0.Squad);
            await Engine.sleep_until(async () => this.g_e10_cov_ghosts0_unloaded && (short)Engine.ai_living_count(e10_cov_ghosts0) <= 1);
            Engine.ai_place(e10_cov_ghosts0_1.Squad);
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task e10_cov_inf1_main()
        {
            Engine.ai_place(e10_cov_inf1.Squad);
            Engine.ai_vehicle_reserve(e10_guntower0.Entity, true);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task e10_cov_inf0_main()
        {
            Engine.ai_place(e10_cov_inf0.Squad);
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task e10_mars_warthog0_main()
        {
            Engine.ai_migrate(e9_mars_test.Squad, e10_mars_warthog0.Squad);
            Engine.ai_migrate(e9_mars_warthog0.Squad, e10_mars_warthog0.Squad);
            Engine.ai_renew(e10_mars_warthog0.Squad);
            Engine.ai_disposable(e10_mars_warthog0.Squad, false);
            await Engine.sleep_until(async () => !(await this.player_in_vehicle()) && !(Engine.volume_test_object(tv_beach, this.g_e8_warthog)) || Engine.object_get_health(this.g_e8_warthog) <= 0F);
            await Engine.sleep(this._15_seconds);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e10_mars_warthog0_unsafe, Engine.players())));
            Engine.ai_place(e10_mars_warthog0.Squad);
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task e10_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_early_begin, Engine.players()) || Engine.volume_test_objects(tv_e10_main_begin, Engine.players()), 16);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_main_begin, Engine.players()), 15);
            this.g_e10_started = true;
            Engine.print("e10_main");
            Engine.data_mine_set_mission_segment("e10_beach_fort");
            Engine.wake(new ScriptMethodReference(e10_mars_warthog0_main));
            Engine.wake(new ScriptMethodReference(e10_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e10_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e10_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e10_cov_phantom0_main));
            await Engine.sleep_until(async () => this.g_e11_started);
            Engine.sleep_forever(new ScriptMethodReference(e10_mars_warthog0_main));
            Engine.sleep_forever(new ScriptMethodReference(e10_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e10_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e10_cov_ghosts0_main));
            Engine.ai_disposable(e10_cov, true);
            Engine.ai_disposable(e10_cov_phantom0.Squad, false);
        }

        [ScriptMethod(246, Lifecycle.Static)]
        public async Task test_beach_fort()
        {
            Engine.switch_bsp(1);
            Engine.object_teleport(await this.player0(), e10_test);
            Engine.ai_place(e10_mars_test.Squad);
            if (!(this.g_e10_started))
            {
                Engine.wake(new ScriptMethodReference(e10_main));
            }

            if (!(this.g_e11_started))
            {
                Engine.wake(new ScriptMethodReference(e11_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task cs_e9_cov_guntower_shoot()
        {
            Engine.cs_force_combat_status(3);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e9_cov_guntower/p0")), 
                    async () => await Engine.sleep((short)Engine.random_range(125, 200)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e9_cov_guntower/p1")), 
                    async () => await Engine.sleep((short)Engine.random_range(125, 200)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e9_cov_guntower/p2")), 
                    async () => await Engine.sleep((short)Engine.random_range(125, 200)));
                return (float)Engine.ai_strength(this.ai_current_actor) <= 0.65F || (float)Engine.ai_strength(this.ai_current_squad) <= 0.5F;
            });
            Engine.ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(248, Lifecycle.CommandScript)]
        public async Task cs_e9_cov_guntower_abort()
        {
            Engine.cs_crouch(false);
        }

        [ScriptMethod(249, Lifecycle.CommandScript)]
        public async Task cs_e9_beach_chatter_scene()
        {
            Engine.cs_switch("marine0");
            Engine.cs_play_line("0520");
            await Engine.sleep(15);
            Engine.cs_switch("marine1");
            Engine.cs_play_line("0530");
            await Engine.sleep(10);
            if ((short)Engine.ai_combat_status(this.ai_current_squad) < this.ai_combat_status_active)
            {
                Engine.cs_switch("marine0");
                Engine.cs_play_line("0540");
                await Engine.sleep(15);
            }

            if ((short)Engine.ai_combat_status(this.ai_current_squad) >= this.ai_combat_status_active)
            {
                Engine.ai_play_line_on_object(default(IGameObject), "0550") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(250, Lifecycle.CommandScript)]
        public async Task cs_e9_cov_inf1_2_patrol()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e9_patrol/p2"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e9_patrol/p3"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(251, Lifecycle.CommandScript)]
        public async Task cs_e9_cov_inf1_0_patrol()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e9_patrol/p0"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e9_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e9_patrol/f0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e9_patrol/p1"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(252, Lifecycle.CommandScript)]
        public async Task cs_e9_warthog_abort()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task e9_warthog_approach_horn()
        {
            Engine.print("honk");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U), this.g_e8_warthog, 1.5F);
            await Engine.sleep(30);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U));
        }

        [ScriptMethod(254, Lifecycle.CommandScript)]
        public async Task cs_e9_warthog_follow()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_moving(false);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_approach_player(10F, 100F, 100F);
                Engine.wake(new ScriptMethodReference(e9_warthog_approach_horn));
                Engine.cs_vehicle_speed(0.5F);
                Engine.cs_approach_player(5F, 100F, 100F);
                await Engine.sleep_until(async () => await this.player_in_vehicle() || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 8F || !(Engine.unit_in_vehicle(Engine.ai_get_unit(this.ai_current_actor))));
                return await this.player_in_vehicle() || !(Engine.unit_in_vehicle(Engine.ai_get_unit(this.ai_current_actor)));
            }, 30, this.two_minutes);
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task e9_cortana_dialog()
        {
            await Engine.sleep_until(async () => Engine.objects_can_see_flag(Engine.players(), e9_dialog_trigger, 25F) || Engine.volume_test_objects(tv_e9_dialogue, Engine.players()), 5, this._30_seconds);
            await Engine.sleep(15);
            Engine.print("highest concentration under carrier");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0050"));
            await Engine.sleep(15);
            await Engine.sleep_until(async () => Engine.objects_can_see_flag(Engine.players(), e9_dialog_trigger, 25F) || Engine.volume_test_objects(tv_e9_dialogue, Engine.players()), 5, 150);
            Engine.print("that bridge is the best route");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0060"));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_main_begin, Engine.players()));
            await Engine.sleep_until(async () => Engine.ai_scene("e9_beach_chatter_scene", new ScriptMethodReference(cs_e9_beach_chatter_scene), e9_mars_warthog0.Squad), 30, 300);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task e9_warthog_navpoint()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e8_mars_warthog0.Squad) > 0);
            if (!(await this.player_in_vehicle()))
            {
                Engine.activate_team_nav_point_object(_default, player, this.g_e8_warthog, 1F);
            }
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task e9_warthog_navpoint_kill()
        {
            await Engine.sleep_until(async () => await this.player_in_vehicle() || Engine.unit_get_health(this.g_e8_warthog) <= 0F);
            Engine.deactivate_team_nav_point_object(player, this.g_e8_warthog);
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task e9_retreat_checkpoint0()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_retreat_checkpoint, Engine.players()), this._30_seconds);
            Engine.game_save();
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task e9_retreat_checkpoint1()
        {
            Engine.sleep_forever(new ScriptMethodReference(e9_retreat_checkpoint0));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_retreat_checkpoint, Engine.players()), this._30_seconds);
            Engine.game_save();
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task e9_music()
        {
            Engine.wake(new ScriptMethodReference(music_03a_05_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_beach, Engine.players()));
            Engine.wake(new ScriptMethodReference(music_03a_05_stop));
            Engine.wake(new ScriptMethodReference(music_03a_06_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_near_entrance, Engine.players()));
            Engine.wake(new ScriptMethodReference(music_03a_06_stop));
            Engine.wake(new ScriptMethodReference(music_03a_065_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_music, Engine.players()));
            await Engine.sleep(150);
            Engine.wake(new ScriptMethodReference(music_03a_065_start_alt));
            await Engine.sleep_until(async () => this.g_e11_started);
            Engine.wake(new ScriptMethodReference(music_03a_065_stop));
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task e9_cov_inf1_main()
        {
            Engine.ai_place(e9_cov_inf1_2.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(covenant1), 0F, 1F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_main_begin, Engine.players()), 15);
            Engine.ai_place(e9_cov_inf1_0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(covenant1), 1F, 3F));
            Engine.ai_place(e9_cov_inf1_1.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(covenant1), 1F, 2F));
            Engine.ai_vehicle_reserve(e9_guntower0.Entity, true);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e9_cov_inf1) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task e9_cov_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_near_entrance, Engine.players()) || (short)Engine.ai_spawn_count(e9_cov_ghosts0.Squad) > 0, 30);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_near_entrance, Engine.players()) || (short)Engine.ai_living_count(e9_cov_inf1) <= 1, 15);
            Engine.ai_place(e9_cov_inf0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(e9_cov), 3F, 7F));
            Engine.wake(new ScriptMethodReference(e9_retreat_checkpoint0));
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task e9_cov_shadow0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_retreat_checkpoint, Engine.players()), 15);
            Engine.ai_place(e9_cov_shadow0.Squad);
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task e9_cov_ghosts0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e9_cov_ghosts0.Squad) <= 0 && Engine.volume_test_objects(tv_e9_near_entrance, Engine.players()) || Engine.volume_test_objects(tv_e9_bypass, Engine.players()) || (short)Engine.ai_living_count(e9_cov_inf1) <= 3, 15);
            Engine.ai_place(e9_cov_ghosts0.Squad);
            Engine.wake(new ScriptMethodReference(e9_retreat_checkpoint0));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_bypass, Engine.players()), 15);
            Engine.ai_migrate(e9_cov_ghosts0.Squad, e10_cov_ghosts0_0.Squad);
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task e9_mars_warthog0_main()
        {
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e8_vehicle_spawn_area, Engine.players())));
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e8_mars_warthog0.Squad) > 0, 30);
            Engine.ai_migrate(e8_mars_warthog0.Squad, e9_mars_warthog0.Squad);
            Engine.ai_renew(e9_mars_warthog0.Squad);
            Engine.ai_disposable(e9_mars_warthog0.Squad, false);
            Engine.cs_run_command_script(e9_mars_warthog0.Squad, new ScriptMethodReference(cs_e9_warthog_abort));
            Engine.ai_vehicle_reserve_seat(this.g_e8_warthog, "warthog_d", false);
            Engine.ai_vehicle_enter(e9_mars_warthog0.Squad, this.g_e8_warthog, "warthog_d");
            if (!(await this.player_in_vehicle()))
            {
                await Engine.sleep_until(async () => Engine.vehicle_test_seat_list(this.g_e8_warthog, "warthog_d", Engine.ai_actors(e9_mars)), 30, 900);
                Engine.cs_run_command_script(Engine.object_get_ai(Engine.vehicle_driver(this.g_e8_warthog)), new ScriptMethodReference(cs_e9_warthog_follow));
            }
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task e9_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_main_begin, Engine.players()), 15);
            this.g_e9_started = true;
            Engine.print("e9_main");
            Engine.data_mine_set_mission_segment("e9_beach_infantry");
            Engine.game_save_no_timeout();
            Engine.wake(new ScriptMethodReference(e9_music));
            Engine.wake(new ScriptMethodReference(chapter_title1));
            Engine.wake(new ScriptMethodReference(objective3_set));
            Engine.wake(new ScriptMethodReference(e9_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e9_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e9_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e9_cov_shadow0_main));
            Engine.wake(new ScriptMethodReference(e9_mars_warthog0_main));
            Engine.wake(new ScriptMethodReference(e9_cortana_dialog));
            Engine.wake(new ScriptMethodReference(e9_warthog_navpoint));
            Engine.wake(new ScriptMethodReference(e9_warthog_navpoint_kill));
            Engine.wake(new ScriptMethodReference(e9_music));
            await Engine.sleep_until(async () => this.g_e10_started);
            Engine.sleep_forever(new ScriptMethodReference(e9_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_cov_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_cov_shadow0_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_mars_warthog0_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_cortana_dialog));
            Engine.sleep_forever(new ScriptMethodReference(e9_retreat_checkpoint0));
            Engine.sleep_forever(new ScriptMethodReference(e9_retreat_checkpoint1));
            Engine.ai_disposable(e9_cov, true);
            await Engine.sleep_until(async () => this.g_e12_started);
            Engine.ai_erase(e9_mars);
            Engine.ai_erase(e9_cov);
        }

        [ScriptMethod(267, Lifecycle.Static)]
        public async Task test_beach_infantry()
        {
            Engine.switch_bsp(1);
            Engine.object_teleport(await this.player0(), e9_test);
            Engine.ai_place(e9_mars_test.Squad);
            if (!(this.g_e9_started))
            {
                Engine.wake(new ScriptMethodReference(e9_main));
            }

            if (!(this.g_e10_started))
            {
                Engine.wake(new ScriptMethodReference(e10_main));
            }

            if (!(this.g_e11_started))
            {
                Engine.wake(new ScriptMethodReference(e11_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(268, Lifecycle.Static)]
        public async Task<bool> e8_cov_phantom0_arrived()
        {
            return this.g_e8_cov_phantom0_arrived == true;
        }

        [ScriptMethod(269, Lifecycle.Static)]
        public async Task<bool> e8_cov_phantom0_leaving()
        {
            return this.g_e8_cov_phantom0_leaving == true;
        }

        [ScriptMethod(270, Lifecycle.Static)]
        public async Task<bool> e8_cov_ghosts0_nearby()
        {
            return Engine.volume_test_objects(tv_e8_area, Engine.ai_actors(e8_cov_ghosts0));
        }

        [ScriptMethod(271, Lifecycle.CommandScript)]
        public async Task cs_e8_warthog_intro_scene()
        {
            Engine.cs_look_player(true);
            Engine.ai_play_line_at_player(this.ai_current_actor, "0510") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(272, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_warthog0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.object_cannot_take_damage(Engine.ai_actors(this.ai_current_squad));
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e8_mars_warthog0_entry/p0"), Engine.GetReference<ISpatialPoint>("e8_mars_warthog0_entry/p1"));
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U), Engine.ai_vehicle_get(this.ai_current_actor), 1.5F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_mars_warthog0_entry/p1"));
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U));
            Engine.object_can_take_damage(Engine.ai_actors(this.ai_current_squad));
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "warthog_p");
            await Engine.sleep(10);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U), Engine.ai_vehicle_get(this.ai_current_actor), 1.5F);
            await Engine.sleep(8);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U));
            await Engine.sleep(5);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U), Engine.ai_vehicle_get(this.ai_current_actor), 1.5F);
            await Engine.sleep(10);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4185331543U));
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "warthog_d");
            Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get_from_starting_location(e8_mars_warthog0.warthog0), "warthog_d", true);
        }

        [ScriptMethod(273, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_phantom0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p1_1"), 1F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p1_facing"));
            await Engine.sleep(60);
            this.g_e8_cov_phantom0_arrived = true;
            Engine.object_set_phantom_power(Engine.ai_vehicle_get(this.ai_current_actor), true);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_a");
            await Engine.sleep(90);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_b");
            await Engine.sleep(90);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_c");
            this.g_e8_cov_inf1_unloaded = true;
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get(this.ai_current_actor), false);
            await Engine.sleep(120);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p1_facing"));
            this.g_e8_cov_phantom0_leaving = true;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p4"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p5"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_ghosts0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_cov_ghosts0_entry/p0"));
            await Engine.sleep((short)Engine.random_range(0, 30));
            Engine.cs_vehicle_boost(false);
        }

        [ScriptMethod(275, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_inf0_no_assholes()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_abort_on_damage(true);
            await Engine.sleep((short)Engine.random_range(15, 45));
            Engine.ai_magically_see(this.ai_current_squad, e8_cov_phantom0.Squad);
            Engine.cs_aim_object(true, Engine.ai_vehicle_get(e8_cov_phantom0.phantom0));
            await Engine.sleep_until(async () => this.g_e8_cov_phantom0_arrived);
        }

        [ScriptMethod(276, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_inf2_patrol2()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_patrol/p2")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_patrol/p3")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_patrol/p4")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)));
                return false;
            });
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_inf2_patrol1()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_patrol/p0"));
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e8_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e8_patrol/f0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_patrol/p1"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(278, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_inf2_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_uninspected);
            Engine.cs_abort_on_damage(true);
            Engine.cs_look_object(true, Engine.ai_get_object(e8_cov_inf2.grunt0));
            Engine.sleep_forever();
        }

        [ScriptMethod(279, Lifecycle.Dormant)]
        public async Task e8_warthog_scene()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("e8_warthog_intro_scene", new ScriptMethodReference(cs_e8_warthog_intro_scene), e8_mars_warthog0.warthog0) || (short)Engine.ai_living_count(e8_mars_warthog0.warthog0) <= 0, 5, this.two_minutes);
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task e8_cov_ghosts0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e8_mars_warthog0.Squad) > 0, 15);
            await Engine.sleep(180);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e8_vehicle_spawn_area, Engine.players())));
            Engine.ai_place(e8_cov_ghosts0_0.Squad, 1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e8_cov_ghosts0) <= 0);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e8_vehicle_spawn_area, Engine.players())));
            Engine.ai_place(e8_cov_ghosts0_0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(covenant1), 0F, 2F));
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task e8_cov_phantom0_main()
        {
            Engine.ai_place(e8_cov_phantom0.Squad);
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task e8_cov_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e8_cov_inf2_begin, Engine.players()), 15);
            Engine.ai_place(e8_cov_inf2.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(e8_cov), 1F, 4F));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e8_cov_inf2.Squad) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task e8_cov_inf1_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e8_cov_phantom0.Squad) > 0);
            Engine.ai_place_in_vehicle(e8_cov_inf1.Squad, e8_cov_phantom0.Squad);
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task e8_cov_inf0_main()
        {
            Engine.ai_place(e8_cov_inf0.Squad);
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task e8_mars_warthog0_main()
        {
            await Engine.sleep_until(async () => this.g_e9_started || this.g_e8_cov_inf1_unloaded && (short)Engine.ai_living_count(e8_cov_inf1.Squad) <= 5 && (short)Engine.structure_bsp_index() == 1, 15, this.one_minute);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1 && !(Engine.volume_test_objects(tv_e8_vehicle_spawn_area, Engine.players())));
            Engine.ai_place(e8_mars_warthog0.Squad);
            await Engine.sleep(3);
            this.g_e8_warthog = Engine.ai_vehicle_get_from_starting_location(e8_mars_warthog0.warthog0);
            Engine.wake(new ScriptMethodReference(e8_warthog_scene));
            await Engine.sleep(450);
            Engine.object_can_take_damage(Engine.ai_actors(e8_mars_warthog0.Squad));
            await Engine.sleep_until(async () => await this.player_in_vehicle() && (short)Engine.ai_living_count(e8_cov_inf1.Squad) <= 0 || this.g_e9_started);
            Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get_from_starting_location(e8_mars_warthog0.warthog0), "warthog_d", false);
            if (!(this.g_e9_started))
            {
                Engine.wake(new ScriptMethodReference(e9_main));
            }
        }

        [ScriptMethod(286, Lifecycle.Dormant)]
        public async Task e8_mars_inf0_main()
        {
            Engine.ai_migrate(e7_mars_inf0.Squad, e8_mars_inf0.Squad);
            Engine.ai_renew(e8_mars_inf0.Squad);
            Engine.ai_disposable(e8_mars_inf0.Squad, false);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e8_cov_inf0.Squad) > 0 && (short)Engine.ai_living_count(e8_cov_inf0.Squad) <= 0);
            Engine.cs_run_command_script(e8_mars_inf0.Squad, new ScriptMethodReference(cs_e8_mars_inf0_no_assholes));
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task e8_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e8_main_begin, Engine.players()), 15);
            this.g_e8_started = true;
            Engine.print("e8_main");
            Engine.data_mine_set_mission_segment("e8_hotel_exit");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_03a_04_stop));
            Engine.wake(new ScriptMethodReference(objective2_clear));
            Engine.wake(new ScriptMethodReference(e9_main));
            Engine.wake(new ScriptMethodReference(e10_main));
            Engine.wake(new ScriptMethodReference(e11_main));
            Engine.wake(new ScriptMethodReference(e8_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e8_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e8_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e8_cov_inf2_main));
            Engine.wake(new ScriptMethodReference(e8_cov_phantom0_main));
            Engine.wake(new ScriptMethodReference(e8_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e8_mars_warthog0_main));
            await Engine.sleep_until(async () => this.g_e9_started);
            Engine.ai_disposable(e8_cov, true);
            Engine.ai_disposable(e8_cov_phantom0.Squad, false);
            await Engine.sleep_until(async () => this.g_e10_started);
            Engine.sleep_forever(new ScriptMethodReference(e8_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_cov_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_cov_phantom0_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_cov_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e8_mars_warthog0_main));
            Engine.ai_disposable(e8_mars, true);
        }

        [ScriptMethod(288, Lifecycle.Static)]
        public async Task test_hotel_exit()
        {
            Engine.switch_bsp(1);
            Engine.object_teleport(await this.player0(), e8_test);
            Engine.ai_place(e8_mars_inf0.Squad);
            if (!(this.g_e8_started))
            {
                Engine.wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(289, Lifecycle.Static)]
        public async Task<bool> oes_e7_spring_ambush()
        {
            return Engine.volume_test_objects(tv_e7_cov_inf0_spring_ambush, Engine.ai_actors(e7_cov_inf0.Squad)) || (short)Engine.ai_combat_status(e7_cov_inf0.Squad) >= this.ai_combat_status_certain && (short)Engine.ai_spawn_count(e7_cov_inf0.Squad) > 0;
        }

        [ScriptMethod(290, Lifecycle.CommandScript)]
        public async Task cs_e7_hide()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_enable_moving(true);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e7_hallway_ambush/f0"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e7_hallway_ambush/f0"));
            await Engine.sleep_until(async () => await this.oes_e7_spring_ambush());
        }

        [ScriptMethod(291, Lifecycle.CommandScript)]
        public async Task cs_e7_cov_inf0_entry()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e7_hallway_ambush/cov1"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e7_hallway_ambush/cov1"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e7_hallway_ambush/cov0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e7_hallway_ambush/cov1"));
        }

        [ScriptMethod(292, Lifecycle.CommandScript)]
        public async Task cs_e7_abort()
        {
            Engine.cs_crouch(false);
        }

        [ScriptMethod(293, Lifecycle.CommandScript)]
        public async Task cs_e7_hotel_hall_scene0()
        {
            Engine.cs_play_line("0470");
        }

        [ScriptMethod(294, Lifecycle.CommandScript)]
        public async Task cs_e7_hotel_hall_scene1()
        {
            Engine.cs_play_line("0480");
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task e7_cov_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e7_cov_inf0_init, Engine.players()), 15);
            await Engine.sleep(15);
            Engine.object_create(e7_gun0);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e7_gun0"), 0, true);
            await Engine.sleep(10);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e7_gun0"), 0, false);
            await Engine.sleep(10);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e7_gun0"), 0, true);
            await Engine.sleep(10);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e7_gun0"), 0, false);
            Engine.ai_place(e7_cov_inf0.Squad);
            await Engine.sleep(20);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e7_gun0"), 0, true);
            await Engine.sleep(8);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e7_gun0"), 0, false);
            Engine.object_destroy(e7_gun0.Entity);
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_e7_hall, Engine.players()) || Engine.volume_test_objects(tv_e7_hall, Engine.ai_actors(e7_mars)) || (bool)Engine.player_flashlight_on())
                {
                    Engine.ai_set_blind(e7_cov_inf0.Squad, false);
                }
                else
                {
                    Engine.ai_set_blind(e7_cov_inf0.Squad, true);
                }

                return await this.oes_e7_spring_ambush();
            }, 2);
            Engine.cs_run_command_script(e7_cov_inf0.Squad, new ScriptMethodReference(cs_e7_abort));
            Engine.ai_set_blind(e7_cov_inf0.Squad, false);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task e7_mars_inf0_main()
        {
            Engine.ai_migrate(e6_mars_inf1.marine0, e7_mars_inf0.Squad);
            Engine.ai_migrate(e6_mars_inf1.marine1, e7_mars_inf0.Squad);
            Engine.ai_renew(e7_mars_inf0.Squad);
            Engine.ai_disposable(e7_mars_inf0.Squad, false);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e6_mars_inf0.Squad) <= 0 || (short)Engine.ai_living_count(e7_mars_inf0.Squad) >= 3)
                {
                    return 1F == 1F;
                }
                else
                {
                    Engine.print("migrated an actor");
                    Engine.ai_attach_units(Engine.unit(Engine.list_get(Engine.ai_actors(e6_mars_inf0.Squad), 0)), e7_mars_inf0.Squad);
                    return 1F == 0F;
                }
            });
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e7_cov_inf0.Squad) > 0, 10);
            Engine.cs_run_command_script(e7_mars_inf0.Squad, new ScriptMethodReference(cs_e7_hide));
            Engine.ai_disregard(Engine.ai_actors(e7_mars_inf0.Squad), true);
            Engine.ai_scene("e7_hotel_hall_scene0", new ScriptMethodReference(cs_e7_hotel_hall_scene0), e7_mars_inf0.Squad) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await Engine.sleep_until(async () => await this.oes_e7_spring_ambush(), 2);
            Engine.cs_run_command_script(e7_mars_inf0.Squad, new ScriptMethodReference(cs_e7_abort));
            Engine.ai_disregard(Engine.ai_actors(e7_mars_inf0.Squad), false);
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task e7_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e7_main_begin, Engine.players()), 15);
            this.g_e7_started = true;
            Engine.print("e7_main");
            Engine.data_mine_set_mission_segment("e7_hotel_hall");
            Engine.game_save();
            Engine.player_training_activate_flashlight();
            Engine.wake(new ScriptMethodReference(e7_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e7_cov_inf0_main));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1, 1);
            Engine.camera_predict_resources_at_point(e8_prediction);
            Engine.ai_disposable(e7_cov, true);
            await Engine.sleep_until(async () => this.g_e9_started);
            Engine.sleep_forever(new ScriptMethodReference(e7_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e7_cov_inf0_main));
            await Engine.sleep_until(async () => this.g_e10_started);
            Engine.ai_erase(e7_mars);
            Engine.ai_erase(e7_cov);
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task test_hotel_hall()
        {
            Engine.object_teleport(await this.player0(), e7_test);
            Engine.ai_place(e7_mars_inf0.Squad);
            if (!(this.g_e7_started))
            {
                Engine.wake(new ScriptMethodReference(e7_main));
            }

            if (!(this.g_e8_started))
            {
                Engine.wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(299, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf1_odst()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.cs_shoot(false, Engine.ai_get_object(this.ai_current_actor));
                await Engine.sleep(4);
                if (Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) < 0.5F)
                {
                    Engine.cs_crouch(true);
                }

                await Engine.sleep_until(async () => Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) >= 0.49F, 5);
                Engine.cs_crouch(false);
                await Engine.sleep(15);
                Engine.cs_shoot(true, Engine.list_get(Engine.ai_actors(e6_cov_inf0), (short)Engine.random_range(0, Engine.list_count(Engine.ai_actors(e6_cov_inf0)))));
                await Engine.sleep_until(async () => Engine.object_get_health(Engine.ai_get_object(this.ai_current_actor)) < 0.5F || (short)Engine.ai_living_count(e6_cov_inf0) <= 0, 5, 60);
                return (short)Engine.ai_living_count(e6_cov_inf0) <= 0;
            }, 15);
        }

        [ScriptMethod(300, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf1_cower()
        {
            Engine.cs_crouch(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(301, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf0_1_cower()
        {
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_hotel_entrance, Engine.players()));
        }

        [ScriptMethod(302, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf1_abort()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(303, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf1_lead()
        {
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_e6_hotel_vicinity, Engine.players()))
                {
                    Engine.cs_enable_looking(true);
                    Engine.cs_face_player(false);
                    Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e6_mars_inf1_lead/p1"));
                    await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e6_hotel_vicinity, Engine.players())));
                }
                else
                {
                    Engine.cs_enable_looking(false);
                    Engine.cs_face_player(true);
                    Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e6_mars_inf1_lead/p0"));
                    await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_hotel_vicinity, Engine.players()));
                }

                return false;
            }, 15);
        }

        [ScriptMethod(304, Lifecycle.CommandScript)]
        public async Task cs_e6_hotel_greeting_scene()
        {
            Engine.cs_enable_targeting(false);
            Engine.cs_look_player(true);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e6_mars_inf1_lead/p0"));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 7F, 15);
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "8070"));
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.cs_look_player(false);
            Engine.cs_enable_looking(true);
            Engine.cs_approach_player(2F, 5F, 10F);
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0460"));
            Engine.wake(new ScriptMethodReference(music_03a_04_start));
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e6_mars_inf1_lead/p1"));
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_mars_inf1_lead));
        }

        [ScriptMethod(305, Lifecycle.CommandScript)]
        public async Task cs_e6_hotel_grunt_scene()
        {
            Engine.cs_play_line("0430");
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task cs_e6_hotel_rescue_scene()
        {
            Engine.cs_play_line("0450");
        }

        [ScriptMethod(307, Lifecycle.Static)]
        public async Task<bool> e6_cov_inf0_not_a_threat()
        {
            return (short)Engine.ai_living_count(e6_cov) <= 4 && (short)Engine.ai_fighting_count(e6_cov) <= 0;
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task e6_cov_inf1_main()
        {
            if (!(Engine.volume_test_objects(tv_e6_main_begin2, Engine.players())))
            {
                Engine.sleep_forever();
            }

            Engine.ai_place(e6_cov_inf1.Squad);
            await Engine.sleep_until(async () => Engine.ai_scene("e6_hotel_grunt_scene", new ScriptMethodReference(cs_e6_hotel_grunt_scene), e6_cov_inf1.Squad), 30, this.two_minutes);
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task e6_cov_inf0_main()
        {
            Engine.ai_place(e6_cov_inf0_2.Squad);
            Engine.ai_place(e6_cov_inf0_0.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(covenant1), 1F, 2F));
            Engine.ai_place(e6_cov_inf0_1.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(covenant1), 0F, 2F));
        }

        [ScriptMethod(310, Lifecycle.Dormant)]
        public async Task e6_mars_inf1_main()
        {
            Engine.ai_place(e6_mars_inf1.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_hotel_vicinity, Engine.players()) || await this.e6_cov_inf0_not_a_threat(), 10);
            await Engine.sleep_until(async () => Engine.ai_scene("e6_hotel_greeting_scene", new ScriptMethodReference(cs_e6_hotel_greeting_scene), e6_mars_inf1.marine0) || (short)Engine.ai_living_count(e6_mars_inf1.marine0) <= 0 || Engine.volume_test_objects(tv_e6_hotel_entrance, Engine.players()), 5);
            await Engine.sleep(20);
            Engine.cs_run_command_script(e6_mars_inf1.marine1, new ScriptMethodReference(cs_e6_mars_inf1_abort));
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_hotel_entrance, Engine.players()), 15);
            Engine.cs_run_command_script(e6_mars_inf1.marine0, new ScriptMethodReference(cs_e6_mars_inf1_abort));
        }

        [ScriptMethod(311, Lifecycle.Dormant)]
        public async Task e6_mars_inf0_main()
        {
            Engine.ai_migrate(e5_mars_inf0.Squad, e6_mars_inf0.Squad);
            Engine.ai_renew(e6_mars_inf0.Squad);
            Engine.ai_disposable(e6_mars_inf0.Squad, false);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e6_cov_inf0) > 0);
            Engine.ai_place(e6_mars_inf0_1.Squad, (short)(2 - (float)Engine.ai_living_count(e6_mars_inf0.Squad)));
            Engine.ai_migrate(e6_mars_inf0_1.Squad, e6_mars_inf0.Squad);
            Engine.ai_renew(e6_mars_inf0.Squad);
            Engine.ai_disposable(e6_mars_inf0.Squad, false);
        }

        [ScriptMethod(312, Lifecycle.Dormant)]
        public async Task e6_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_main_begin0, Engine.players()) || Engine.volume_test_objects(tv_e6_main_begin1, Engine.players()) || Engine.volume_test_objects(tv_e6_main_begin2, Engine.players()), 15);
            this.g_e6_started = true;
            Engine.print("e6_main");
            Engine.data_mine_set_mission_segment("e6_hotel_entrance");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_03a_03_stop));
            Engine.wake(new ScriptMethodReference(e7_main));
            Engine.wake(new ScriptMethodReference(e6_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e6_mars_inf1_main));
            Engine.wake(new ScriptMethodReference(e6_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e6_cov_inf1_main));
            await Engine.sleep_until(async () => this.g_e7_started);
            Engine.ai_disposable(e6_cov, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.sleep_forever(new ScriptMethodReference(e6_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e6_mars_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e6_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e6_cov_inf1_main));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.ai_erase(e6_mars);
            Engine.ai_erase(e6_cov);
        }

        [ScriptMethod(313, Lifecycle.Static)]
        public async Task test_hotel_entrance()
        {
            Engine.object_teleport(await this.player0(), e6_test);
            Engine.ai_place(e6_mars_inf0.Squad);
            if (!(this.g_e6_started))
            {
                Engine.wake(new ScriptMethodReference(e6_main));
            }

            if (!(this.g_e8_started))
            {
                Engine.wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(314, Lifecycle.Static)]
        public async Task e5b_reset_player()
        {
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
            Engine.object_teleport(await this.player0(), e5b_return);
            Engine.unit_add_equipment(Engine.unit(await this.player0()), wimpy, true, true);
            await Engine.sleep(5);
            Engine.fade_in(1F, 1F, 1F, 5);
            await Engine.sleep(5);
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task e5b_resetter()
        {
            await Engine.sleep_until(async () =>
            {
                if (!(Engine.volume_test_object(tv_e5b_bounds, await this.player0())))
                {
                    await this.e5b_reset_player();
                }

                return this.g_e5b_finished;
            });
        }

        [ScriptMethod(316, Lifecycle.Dormant)]
        public async Task e5b_inf0_main()
        {
            Engine.ai_place(e5b_cov_inf0.Squad, 1);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await Engine.sleep(90);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, false);
            Engine.ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5b_cov_inf0.Squad) <= 0);
            Engine.garbage_collect_now();
            Engine.ai_place(e5b_cov_inf0.Squad, 2);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await Engine.sleep(90);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, false);
            Engine.ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5b_cov_inf0.Squad) <= 0);
            Engine.garbage_collect_now();
            Engine.ai_place(e5b_cov_inf0.Squad, 3);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await Engine.sleep(90);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, false);
            Engine.ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5b_cov_inf0.Squad) <= 0);
            Engine.garbage_collect_now();
            Engine.ai_place(e5b_cov_inf0.Squad, 4);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await Engine.sleep(90);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, false);
            Engine.ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5b_cov_inf0.Squad) <= 0);
            Engine.garbage_collect_now();
            Engine.ai_place(e5b_cov_inf0.Squad, 5);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await Engine.sleep(90);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, false);
            Engine.ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5b_cov_inf0.Squad) <= 0);
            Engine.garbage_collect_now();
            Engine.ai_place(e5b_cov_inf0.Squad, 6);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await Engine.sleep(90);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, false);
            Engine.ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5b_cov_inf0.Squad) <= 0);
            Engine.garbage_collect_now();
            Engine.ai_place(e5b_cov_inf0.Squad, 7);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await Engine.sleep(90);
            Engine.ai_set_active_camo(e5b_cov_inf0.Squad, false);
            Engine.ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5b_cov_inf0.Squad) <= 0);
            Engine.garbage_collect_now();
            this.g_e5b_finished = true;
            Engine.ice_cream_flavor_stock(5);
        }

        [ScriptMethod(317, Lifecycle.Dormant)]
        public async Task e5b_main()
        {
            if ((bool)Engine.game_is_cooperative() || !(await this.difficulty_legendary()) || !(0 == (short)Engine.random_range(0, 7)))
            {
                Engine.sleep_forever();
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5b_main, Engine.players()), 15);
            Engine.game_save_cancel();
            Engine.game_save();
            await Engine.sleep_until(async () => !((bool)Engine.game_saving()), 1);
            if (!((bool)Engine.game_reverted()))
            {
                this.g_e5b_started = true;
                Engine.object_create(key);
                await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4242086585U)) && Engine.volume_test_object(tv_e5b_main, await this.player0()), 5);
                await Engine.sleep(30);
                await this.e5b_reset_player();
                Engine.wake(new ScriptMethodReference(e5b_inf0_main));
                Engine.wake(new ScriptMethodReference(e5b_resetter));
            }
        }

        [ScriptMethod(318, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_inf0_guard0()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e5_cov_ambush/look0")), 
                    async () => await Engine.sleep((short)Engine.random_range(100, 150)), 
                    async () => Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e5_cov_ambush/look1")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                    async () => Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e5_cov_ambush/look2")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)));
                return false;
            }, 5);
        }

        [ScriptMethod(319, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_inf0_wait()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("e5_cov_inf0_ambush_sprung", this.ai_current_squad), 5);
        }

        [ScriptMethod(320, Lifecycle.Static)]
        public async Task<bool> e5_cov_inf0_ambush_trigger()
        {
            return Engine.volume_test_objects(tv_e5_ambush_trigger0, Engine.players()) || Engine.volume_test_objects(tv_e5_ambush_trigger1, Engine.players()) || Engine.volume_test_objects(tv_e5_ambush_trigger2, Engine.players());
        }

        [ScriptMethod(321, Lifecycle.Static)]
        public async Task<bool> e5_cov_inf1_done()
        {
            return this.g_e5_cov_inf1_done == true;
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task e5_cov_inf4_main()
        {
            Engine.ai_migrate(e4_cov_inf1, e5_cov_inf4.Squad);
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task e5_cov_inf3_main()
        {
            if (!(await this.difficulty_legendary()))
            {
                Engine.sleep_forever();
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_player_advanced, Engine.players()));
            if ((short)Engine.ai_living_count(covenant1) < 15)
            {
                Engine.ai_place(e5_cov_inf3.Squad);
            }
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task e5_cov_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_player_advanced, Engine.players()));
            if ((short)Engine.ai_living_count(covenant1) < 15)
            {
                Engine.ai_place(e5_cov_inf2.Squad);
            }
        }

        [ScriptMethod(325, Lifecycle.Static)]
        public async Task e5_cov_inf1_0_spawn()
        {
            Engine.print("e5_cov_inf1_0_spawn");
            if ((short)Engine.ai_living_count(e5_cov_inf1) <= 1 && !(Engine.volume_test_objects(tv_e5_cov_inf1_unsafe0, Engine.players())) && !(Engine.volume_test_objects(tv_e5_cov_inf1_done, Engine.players())))
            {
                Engine.ai_place(e5_cov_inf1_0.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(e5_cov), 0F, 4F));
                Engine.ai_set_orders(e5_cov_inf1_0.Squad, e5_cov_inf1_0_init);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_cov_inf1) <= 1 || Engine.volume_test_objects(tv_e5_cov_inf1_done, Engine.players()));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_cov_inf1_done, Engine.players()), 30, this.g_e5_cov_inf1_spawn_delay);
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task e5_cov_inf1_1_spawn()
        {
            Engine.print("e5_cov_inf1_1_spawn");
            if ((short)Engine.ai_living_count(e5_cov_inf1) <= 1 && !(Engine.volume_test_objects(tv_e5_cov_inf1_unsafe1, Engine.players())) && !(Engine.volume_test_objects(tv_e5_cov_inf1_done, Engine.players())))
            {
                Engine.ai_place(e5_cov_inf1_1.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(e5_cov), 0F, 4F));
                Engine.ai_set_orders(e5_cov_inf1_1.Squad, e5_cov_inf1_1_init);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_cov_inf1) <= 1 || Engine.volume_test_objects(tv_e5_cov_inf1_done, Engine.players()));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_cov_inf1_done, Engine.players()), 30, this.g_e5_cov_inf1_spawn_delay);
        }

        [ScriptMethod(327, Lifecycle.Dormant)]
        public async Task e5_cov_inf1_main()
        {
            Engine.ai_migrate(e4_cov_inf2.Squad, e5_cov_inf1_1.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_advanced0, Engine.players()), 15);
            if (await this.difficulty_heroic())
            {
                this.g_e5_cov_inf1_max = 16;
                this.g_e5_cov_inf1_spawn_delay = 15;
            }

            if (await this.difficulty_legendary())
            {
                this.g_e5_cov_inf1_max = 30;
                this.g_e5_cov_inf1_spawn_delay = 5;
            }

            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_e5_main_begin0, Engine.players()))
                {
                    await this.e5_cov_inf1_0_spawn();
                }
                else
                {
                    await this.e5_cov_inf1_1_spawn();
                }

                if (!(Engine.volume_test_objects(tv_e5_main_begin0, Engine.players())))
                {
                    await this.e5_cov_inf1_0_spawn();
                }
                else
                {
                    await this.e5_cov_inf1_1_spawn();
                }

                if (!(this.g_e5b_started))
                {
                    Engine.game_save();
                }

                return (float)Engine.ai_spawn_count(e5_cov_inf1_0.Squad) + (float)Engine.ai_spawn_count(e5_cov_inf1_1.Squad) >= this.g_e5_cov_inf1_max || Engine.volume_test_objects(tv_e5_cov_inf1_done, Engine.players());
            });
            this.g_e5_cov_inf1_done = true;
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task e5_cov_inf0_main()
        {
            Engine.ai_place(e5_cov_inf0_0.sniper0);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_cov_inf0) < 1 || Engine.volume_test_objects(tv_e5_advanced1, Engine.players()));
            if ((short)Engine.ai_living_count(covenant1) < 15)
            {
                Engine.ai_place(e5_cov_inf0_0.sniper1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_cov_inf0) < 2 || Engine.volume_test_objects(tv_e5_advanced1, Engine.players()));
            if ((short)Engine.ai_living_count(covenant1) < 15)
            {
                Engine.ai_place(e5_cov_inf0_0.sniper2);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_cov_inf0) < 2 || Engine.volume_test_objects(tv_e5_advanced1, Engine.players()));
            if ((short)Engine.ai_living_count(covenant1) < 15)
            {
                Engine.ai_place(e5_cov_inf0_0.sniper3);
            }
        }

        [ScriptMethod(329, Lifecycle.Dormant)]
        public async Task e5_mars_inf0_main()
        {
            Engine.ai_migrate(e4_mars_inf0.Squad, e5_mars_inf0.Squad);
            Engine.ai_renew(e5_mars_inf0.Squad);
            Engine.ai_disposable(e5_mars_inf0.Squad, false);
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task e5_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_main_begin0, Engine.players()) || Engine.volume_test_objects(tv_e5_main_begin1, Engine.players()) || Engine.volume_test_objects(tv_e5_main_begin2, Engine.players()));
            this.g_e5_started = true;
            Engine.print("e5_main");
            Engine.data_mine_set_mission_segment("e5_neighborhood");
            if (!(this.g_e5b_started))
            {
                Engine.game_save();
            }

            Engine.wake(new ScriptMethodReference(music_03a_03_stop));
            Engine.wake(new ScriptMethodReference(e5_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e5_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e5_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e5_cov_inf2_main));
            Engine.wake(new ScriptMethodReference(e5_cov_inf3_main));
            Engine.wake(new ScriptMethodReference(e5_cov_inf4_main));
            await Engine.sleep_until(async () => this.g_e6_started);
            Engine.ai_disposable(e5_cov, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1 || this.g_e5b_started);
            Engine.sleep_forever(new ScriptMethodReference(e5_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_cov_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_cov_inf3_main));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1 || this.g_e5b_started);
            Engine.ai_erase(e5_mars);
            Engine.ai_erase(e5_cov);
        }

        [ScriptMethod(331, Lifecycle.Static)]
        public async Task test_neighborhood()
        {
            Engine.object_teleport(await this.player0(), e5_test);
            Engine.ai_place(e5_mars_inf0.Squad);
            if (!(this.g_e5_started))
            {
                Engine.wake(new ScriptMethodReference(e5_main));
            }

            if (!(this.g_e6_started))
            {
                Engine.wake(new ScriptMethodReference(e6_main));
            }

            if (!(this.g_e8_started))
            {
                Engine.wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf0_0_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_patrol/p2"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(60, 90));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                Engine.cs_enable_looking(true);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_patrol/p3"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(60, 90));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                Engine.cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf0_0_patrol1()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_patrol/p4"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(60, 90));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                Engine.cs_enable_looking(true);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_patrol/p5"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(60, 90));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                Engine.cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf0_2_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_patrol/p0"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(60, 90));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                Engine.cs_enable_looking(true);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_patrol/p1"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(60, 90));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                Engine.cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(335, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf0_1_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_patrol/p6"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                await Engine.sleep((short)Engine.random_range(60, 90));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e4_patrol/f0"));
                Engine.cs_enable_looking(true);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e4_patrol/p7"));
                Engine.cs_enable_looking(false);
                Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e4_patrol/f1"));
                await Engine.sleep((short)Engine.random_range(45, 60));
                Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("e4_patrol/f1"));
                Engine.cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf2_lurk()
        {
            Engine.cs_crouch(true);
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_squad) >= this.ai_combat_status_clear_los || Engine.volume_test_objects(tv_e4_cov_inf2_begin, Engine.players()), 15);
        }

        [ScriptMethod(337, Lifecycle.Dormant)]
        public async Task e4_cov_snipers0_main()
        {
            Engine.ai_place(e4_cov_snipers0_0.Squad);
            Engine.ai_place(e4_cov_snipers0_1.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e4_cov_snipers0) < 3 || Engine.volume_test_objects(tv_e4_cov_inf1_main_begin, Engine.players()));
            if ((short)Engine.ai_living_count(e4_cov_snipers0) < 3)
            {
                Engine.ai_place(e4_cov_snipers0_2.sniper0);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e4_cov_snipers0) < 3 || Engine.volume_test_objects(tv_e4_player_moved_up, Engine.players()));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e4_cov_snipers0) < 3 || Engine.volume_test_objects(tv_e4_player_moved_up, Engine.players()));
            if ((short)Engine.ai_living_count(e4_cov_snipers0) < 3)
            {
                Engine.ai_place(e4_cov_snipers0_2.sniper1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e4_cov_snipers0) < 3 || Engine.volume_test_objects(tv_e4_player_moved_up, Engine.players()));
            if ((short)Engine.ai_living_count(e4_cov_snipers0) < 3)
            {
                Engine.ai_place(e4_cov_snipers0_2.sniper2);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e4_cov_snipers0) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task e4_cov_inf2_main()
        {
            if (await this.difficulty_normal())
            {
                Engine.sleep_forever();
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_player_moved_up, Engine.players()), 15);
            if (await this.difficulty_legendary() && (short)Engine.random_range(0, 3) == 0)
            {
                Engine.ai_place(e4_cov_inf2.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(e4_cov), 1F, 3F));
            }
            else
            {
                Engine.ai_place(e4_cov_inf2.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(e4_cov), 1F, 2F));
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e4_cov_inf2.Squad) <= 0 || this.g_e5_started);
            Engine.game_save();
        }

        [ScriptMethod(339, Lifecycle.Dormant)]
        public async Task e4_cov_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_player_moved_up, Engine.players()) || (short)Engine.ai_living_count(e4_cov_snipers0_0.Squad) <= 1, 15);
            Engine.ai_place(e4_cov_inf1_0.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(e4_cov), 2F, 4F));
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e4_cov) < 6 && !(Engine.volume_test_objects(tv_e4_end_of_street, Engine.players())))
                {
                    Engine.ai_place(e4_cov_inf1_0.Squad, 2);
                }

                return (short)Engine.ai_spawn_count(e4_cov_inf1) >= 8 || Engine.volume_test_objects(tv_e4_end_of_street, Engine.players());
            }, 90);
        }

        [ScriptMethod(340, Lifecycle.Dormant)]
        public async Task e4_cov_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_player_moved_up, Engine.players()) || (short)Engine.ai_living_count(e4_cov_snipers0_1.Squad) <= 0 && (short)Engine.ai_living_count(e4_cov_snipers0_2.Squad) <= 1, 15);
            Engine.ai_place(e4_cov_inf0_0.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(e4_cov), 0F, 2F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_player_moved_up, Engine.players()) || (short)Engine.ai_living_count(e4_cov_inf0_0.Squad) <= 0, 15);
            if (!(Engine.volume_test_objects(tv_e4_player_moved_up, Engine.players())))
            {
                Engine.ai_place(e4_cov_inf0_1.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(e4_cov), 0F, 2F));
            }
        }

        [ScriptMethod(341, Lifecycle.Dormant)]
        public async Task e4_mars_inf0_main()
        {
            Engine.ai_migrate(e3_mars_inf0.Squad, e4_mars_inf0.Squad);
            Engine.ai_migrate(e3_mars_inf1.Squad, e4_mars_inf0.Squad);
            Engine.ai_renew(e4_mars_inf0.Squad);
            Engine.ai_disposable(e4_mars_inf0.Squad, false);
        }

        [ScriptMethod(342, Lifecycle.Dormant)]
        public async Task e4_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_main_begin, Engine.players()));
            this.g_e4_started = true;
            Engine.print("e4_main");
            Engine.data_mine_set_mission_segment("e4_sniper_alley");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_03a_03_start));
            Engine.wake(new ScriptMethodReference(e5_main));
            Engine.wake(new ScriptMethodReference(e5b_main));
            Engine.wake(new ScriptMethodReference(objective1_clear));
            Engine.wake(new ScriptMethodReference(objective2_set));
            Engine.wake(new ScriptMethodReference(e4_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e4_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e4_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e4_cov_inf2_main));
            Engine.wake(new ScriptMethodReference(e4_cov_snipers0_main));
            await Engine.sleep_until(async () => this.g_e5_started || this.g_e6_started);
            Engine.sleep_forever(new ScriptMethodReference(e4_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_cov_snipers0_main));
            Engine.ai_disposable(e4_cov, true);
        }

        [ScriptMethod(343, Lifecycle.Static)]
        public async Task test_sniper_alley()
        {
            Engine.object_teleport(await this.player0(), e4_test);
            Engine.ai_place(e4_mars_inf0.Squad);
            if (!(this.g_e4_started))
            {
                Engine.wake(new ScriptMethodReference(e4_main));
            }

            if (!(this.g_e6_started))
            {
                Engine.wake(new ScriptMethodReference(e6_main));
            }

            if (!(this.g_e8_started))
            {
                Engine.wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task cs_e3_sniper_intro_scene()
        {
            Engine.ai_play_line(this.ai_current_actor, "0370") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task e3_mars_sniper_scene()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("e3_sniper_intro_scene", new ScriptMethodReference(cs_e3_sniper_intro_scene), e3_mars), 30, 450);
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_inf0_1_intro()
        {
            Engine.cs_crouch(true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e3_cov_sniper/p0"));
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_certain, 10);
            await Engine.sleep(15);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e3_cov_sniper/p0"));
            Engine.wake(new ScriptMethodReference(e3_mars_sniper_scene));
            await Engine.sleep(30);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e3_cov_sniper/p1"));
            await Engine.sleep(90);
        }

        [ScriptMethod(347, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_inf0_1_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_looking(false);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e3_patrol/f0")), 
                    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e3_patrol/f1")), 
                    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e3_patrol/f2")), 
                    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e3_patrol/f3")), 
                    async () => await Engine.sleep((short)Engine.random_range(60, 90)));
                return false;
            });
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_pelican0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e3_mars_evac/p2"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e3_mars_evac/p0"));
            this.g_e3_mars_pelican0_arrived = true;
            await Engine.sleep(45);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e3_mars_evac/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e3_mars_evac/p3"), 1F);
            this.g_e3_mars_pelican0_landed = true;
            Engine.sleep_forever();
        }

        [ScriptMethod(349, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_pelican0_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e3_mars_evac/p4"), 1F);
            await Engine.sleep(30);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e3_mars_evac/p2"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(350, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_johnson_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_mars_evac/johnson0"));
            Engine.cs_enable_targeting(true);
            await Engine.sleep_until(async () => this.g_e3_johnson_should_load, 5);
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.cs_face_object(true, Engine.ai_get_object(e3_mars_pelican0.pelican0));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_mars_evac/johnson1"));
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.ai_get_object(this.ai_current_actor), await this.player0(), 10F) || (bool)Engine.game_is_cooperative() && Engine.objects_can_see_object(Engine.ai_get_object(this.ai_current_actor), await this.player1(), 10F), 1);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor), 15F), 2, 30);
            await Engine.sleep(20);
            Engine.ai_play_line_at_player(e3_mars_johnson.Squad, "0970") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(20);
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3841852296U), "combat:rifle:wave", true);
            await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
        }

        [ScriptMethod(351, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_johnson_slam()
        {
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_mars_evac/johnson1"));
            Engine.ai_vehicle_enter_immediate(this.ai_current_actor, Engine.ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e");
        }

        [ScriptMethod(352, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_inf1_ride()
        {
            await Engine.sleep_until(async () => this.g_e3_mars_pelican0_landed, 5);
            Engine.ai_vehicle_exit(this.ai_current_actor);
            Engine.cs_enable_targeting(true);
            Engine.cs_enable_moving(true);
            await Engine.sleep(60);
            if (this.g_e4_started)
            {
                Engine.ai_migrate(this.ai_current_actor, e4_mars_inf0.Squad);
            }
            else
            {
                Engine.ai_migrate(this.ai_current_actor, e3_mars_inf0.Squad);
            }
        }

        [ScriptMethod(353, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_johnson_teleport()
        {
            Engine.cs_teleport(Engine.GetReference<ISpatialPoint>("e3_mars_evac/johnson_teleport0"), Engine.GetReference<ISpatialPoint>("e3_mars_evac/johnson_teleport1"));
        }

        [ScriptMethod(354, Lifecycle.Static)]
        public async Task<bool> e3_mars_pelican0_arrived()
        {
            return this.g_e3_mars_pelican0_arrived == true;
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task<bool> e3_mars_johnson_loaded()
        {
            return this.g_e3_johnson_in_pelican == true;
        }

        [ScriptMethod(356, Lifecycle.Static)]
        public async Task<bool> e3_cov_inf0_0_should_regroup()
        {
            return this.g_e4_started || (short)Engine.ai_spawn_count(e3_cov_inf0_0.Squad) >= this.g_e3_cov_inf0_0_limit && (short)Engine.ai_living_count(e3_cov_inf0_0.Squad) <= 4;
        }

        [ScriptMethod(357, Lifecycle.Dormant)]
        public async Task e3_cov_inf0_main()
        {
            Engine.ai_place(e3_cov_inf0_0.Squad);
            Engine.ai_place(e3_cov_inf0_1.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e3_cov_inf0) <= 2 || Engine.volume_test_objects(tv_e3_crossing_street, Engine.players()), 15);
            Engine.ai_place(e3_cov_inf0_2.Squad);
        }

        [ScriptMethod(358, Lifecycle.Dormant)]
        public async Task e3_mars_pelican0_main()
        {
            await Engine.sleep_until(async () => this.g_e4_started || Engine.volume_test_objects(tv_e3_mars_pelican0_begin, Engine.players()) || (short)Engine.ai_spawn_count(e3_cov_inf0) > 0 && (short)Engine.ai_living_count(e3_cov_inf0) <= 2, 30, this.two_minutes);
            Engine.ai_place(e3_mars_pelican0.Squad);
            Engine.cs_run_command_script(e3_mars_pelican0.pelican0, new ScriptMethodReference(cs_e3_mars_pelican0_entry));
            await Engine.sleep_until(async () => this.g_e3_johnson_in_pelican, 5);
            Engine.cs_run_command_script(e3_mars_pelican0.pelican0, new ScriptMethodReference(cs_e3_mars_pelican0_exit));
        }

        [ScriptMethod(359, Lifecycle.Dormant)]
        public async Task e3_mars_inf1_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e3_mars_pelican0.Squad) > 0);
            Engine.ai_place(e3_mars_inf1.Squad, (short)Engine.pin(3F - (float)Engine.ai_living_count(e3_mars_inf0.Squad), 0F, 3F));
            Engine.ai_vehicle_enter_immediate(e3_mars_inf1.Squad, Engine.ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_p_r");
        }

        [ScriptMethod(360, Lifecycle.Dormant)]
        public async Task e3_mars_inf0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_cov_hunters0.Squad) <= 0 || Engine.volume_test_objects(tv_e3_crossing_street, Engine.players()), 30, this.one_minute);
            Engine.ai_migrate(e2_mars_inf0.Squad, e3_mars_inf0.Squad);
            Engine.ai_renew(e3_mars_inf0.Squad);
            Engine.ai_disposable(e3_mars_inf0.Squad, false);
            await Engine.sleep_until(async () => this.g_e3_johnson_in_pelican);
            Engine.ai_migrate(e3_mars_johnson.Squad, e3_mars_inf0.Squad);
            Engine.ai_disposable(e3_mars_inf0.Squad, false);
        }

        [ScriptMethod(361, Lifecycle.Dormant)]
        public async Task e3_mars_johnson_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_cov_hunters0.Squad) <= 0 || Engine.volume_test_objects(tv_e3_crossing_street, Engine.players()), 30, this.one_minute);
            Engine.ai_migrate(e1_mars_johnson.Squad, e3_mars_johnson.Squad);
            Engine.ai_migrate(e2_mars_johnson.Squad, e3_mars_johnson.Squad);
            Engine.ai_disposable(e3_mars_johnson.Squad, false);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e3_mars_pelican0.Squad) > 0, 15);
            if (!(Engine.volume_test_objects(tv_e3_johnson_required, Engine.ai_actors(e3_mars_johnson.Squad))))
            {
                await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e3_johnson_teleport_unsafe, Engine.players())));
                Engine.cs_run_command_script(e3_mars_johnson.Squad, new ScriptMethodReference(cs_e3_mars_johnson_teleport));
            }

            await Engine.sleep_until(async () => this.g_e3_mars_pelican0_arrived, 15);
            Engine.wake(new ScriptMethodReference(objective1_clear));
            Engine.cs_run_command_script(e3_mars_johnson.Squad, new ScriptMethodReference(cs_e3_mars_johnson_exit));
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0940"));
            await Engine.sleep(20);
            await Engine.sleep(Engine.ai_play_line(e3_mars_johnson.Squad, "0950"));
            await Engine.sleep(15);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0960"));
            this.g_e3_johnson_should_load = true;
            await Engine.sleep_until(async () => !(Engine.cs_command_script_queued(e3_mars_johnson.Squad, new ScriptMethodReference(cs_e3_mars_johnson_exit))), 1);
            Engine.ai_vehicle_enter(e3_mars_johnson.Squad, Engine.ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e");
            await Engine.sleep_until(async () => Engine.vehicle_test_seat_list(Engine.ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e", Engine.ai_actors(e3_mars_pelican0.Squad)), 30, 300);
            if (!(Engine.vehicle_test_seat_list(Engine.ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e", Engine.ai_actors(e3_mars_pelican0.Squad))))
            {
                Engine.cs_run_command_script(e3_mars_johnson.Squad, new ScriptMethodReference(cs_e3_mars_johnson_slam));
            }

            await Engine.sleep_until(async () => Engine.vehicle_test_seat_list(Engine.ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e", Engine.ai_actors(e3_mars_pelican0.Squad)), 30, this._30_seconds);
            this.g_e3_johnson_in_pelican = true;
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(objective2_set));
            Engine.wake(new ScriptMethodReference(music_03a_03_start));
        }

        [ScriptMethod(362, Lifecycle.Dormant)]
        public async Task e3_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e3_main_begin0, Engine.players()) || Engine.volume_test_objects(tv_e3_main_begin1, Engine.players()));
            this.g_e3_started = true;
            Engine.print("e3_main");
            Engine.data_mine_set_mission_segment("e3_highway_underpass");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_03a_01_stop));
            Engine.wake(new ScriptMethodReference(music_03a_02_stop));
            Engine.wake(new ScriptMethodReference(objective1_set));
            Engine.wake(new ScriptMethodReference(e4_main));
            Engine.wake(new ScriptMethodReference(e6_main));
            Engine.wake(new ScriptMethodReference(e3_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e3_mars_inf1_main));
            Engine.wake(new ScriptMethodReference(e3_mars_johnson_main));
            Engine.wake(new ScriptMethodReference(e3_mars_pelican0_main));
            Engine.wake(new ScriptMethodReference(e3_cov_inf0_main));
            await Engine.sleep_until(async () => this.g_e4_started || this.g_e6_started);
            Engine.sleep_forever(new ScriptMethodReference(e3_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_mars_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_mars_sniper_scene));
            Engine.ai_disposable(e3_cov, true);
        }

        [ScriptMethod(363, Lifecycle.Static)]
        public async Task test_marching_infantry()
        {
            Engine.object_teleport(await this.player0(), e3_test);
            Engine.ai_place(e3_mars_inf0.Squad);
            Engine.ai_place(e3_mars_johnson.Squad);
            Engine.object_cannot_take_damage(Engine.ai_actors(e3_mars_johnson.Squad));
            if (!(this.g_e3_started))
            {
                Engine.wake(new ScriptMethodReference(e3_main));
            }

            if (!(this.g_e8_started))
            {
                Engine.wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(364, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_hunters0_taunt()
        {
            this.g_e2_cov_hunters0_active = true;
            Engine.cs_abort_on_damage(true);
            if ((float)Engine.ai_strength(this.ai_current_actor) > 0.98F)
            {
                Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\hunter\\hunter", 4276034731U), "combat:unarmed:shakefist", true);
                await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
            }
        }

        [ScriptMethod(365, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_hunters0_0_entry()
        {
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e2_cov_hunters0_taunt));
            await Engine.sleep(220);
            Engine.cs_force_combat_status(2);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_abort_on_damage(true);
            Engine.cs_look_player(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e2_cov_hunters0_entry/p0_1"));
            Engine.cs_face_player(true);
            Engine.cs_movement_mode(this.ai_movement_combat);
            await Engine.sleep_until(async () => await this.player_in_vehicle() || Engine.objects_distance_to_object(Engine.ai_actors(this.ai_current_squad), await this.player0()) <= 3F || (bool)Engine.game_is_cooperative() && Engine.objects_distance_to_object(Engine.ai_actors(this.ai_current_squad), await this.player1()) <= 3F || (bool)Engine.ai_trigger_test("generic_player_fired", this.ai_current_squad) && Engine.objects_can_see_flag(Engine.players(), e2_cov_hunters0_entry, 20F) || (float)Engine.ai_strength(this.ai_current_squad) < 0.98F, 5, 120);
            if (!(await this.player_in_vehicle() || Engine.objects_distance_to_object(Engine.ai_actors(this.ai_current_squad), await this.player0()) <= 3F || (bool)Engine.game_is_cooperative() && Engine.objects_distance_to_object(Engine.ai_actors(this.ai_current_squad), await this.player1()) <= 3F || (bool)Engine.ai_trigger_test("generic_player_fired", this.ai_current_squad) && Engine.objects_can_see_flag(Engine.players(), e2_cov_hunters0_entry, 20F) || (float)Engine.ai_strength(this.ai_current_squad) < 0.98F))
            {
                Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\hunter\\hunter", 4276034731U), "combat:unarmed:taunt", true);
                await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
            }

            await Engine.sleep_until(async () => await this.player_in_vehicle() || Engine.objects_distance_to_object(Engine.ai_actors(this.ai_current_squad), await this.player0()) <= 4F || (bool)Engine.game_is_cooperative() && Engine.objects_distance_to_object(Engine.ai_actors(this.ai_current_squad), await this.player1()) <= 4F || (bool)Engine.ai_trigger_test("generic_player_fired", this.ai_current_squad) && Engine.objects_can_see_flag(Engine.players(), e2_cov_hunters0_entry, 20F) || (float)Engine.ai_strength(this.ai_current_squad) < 0.98F, 5, 120);
        }

        [ScriptMethod(366, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_hunters0_1_entry()
        {
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e2_cov_hunters0_taunt));
            await Engine.sleep(220);
            Engine.cs_force_combat_status(2);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_abort_on_damage(true);
            Engine.cs_look_player(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e2_cov_hunters0_entry/p1"));
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => await this.player_in_vehicle() || Engine.objects_distance_to_object(Engine.ai_actors(this.ai_current_squad), await this.player0()) <= 4F || (bool)Engine.game_is_cooperative() && Engine.objects_distance_to_object(Engine.ai_actors(this.ai_current_squad), await this.player1()) <= 4F || (bool)Engine.ai_trigger_test("generic_player_fired", this.ai_current_squad) && Engine.objects_can_see_flag(Engine.players(), e2_cov_hunters0_entry, 20F) || (float)Engine.ai_strength(this.ai_current_squad) < 1F, 5, 240);
        }

        [ScriptMethod(367, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_inf0_watch()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_hunters_bypassed, Engine.players()) || (bool)Engine.ai_trigger_test("e2_cov_hunters0_active", e2_cov_hunters0.Squad), 15);
        }

        [ScriptMethod(368, Lifecycle.CommandScript)]
        public async Task cs_e2_mars_johnson0_dialogue0()
        {
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3841852296U), "combat:rifle:hold", true);
            await Engine.sleep(10);
            await Engine.sleep(Engine.ai_play_line(e2_mars_johnson.Squad, "0930"));
        }

        [ScriptMethod(369, Lifecycle.CommandScript)]
        public async Task cs_e2_mars_johnson0_watch()
        {
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e2_mars_watch/p1"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e2_mars_watch/watch"));
            await Engine.sleep_until(async () => this.g_e2_door_breached);
            Engine.cs_aim_object(true, Engine.ai_get_object(e2_cov_hunters0.hunter0));
            await Engine.sleep_until(async () => this.g_e2_cov_hunters0_active, 10, this._30_seconds);
        }

        [ScriptMethod(370, Lifecycle.CommandScript)]
        public async Task cs_e2_mars_inf0_watch()
        {
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("e2_mars_inf0_positions"));
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => this.g_e2_door_breached);
            Engine.cs_aim_object(true, Engine.ai_get_object(e2_cov_hunters0.hunter0));
            await Engine.sleep_until(async () => this.g_e2_cov_hunters0_active, 10, this._30_seconds);
        }

        [ScriptMethod(371, Lifecycle.CommandScript)]
        public async Task cs_e2_mars_continue()
        {
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("e2_mars_wait"));
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("generic_player_within_4wu", e2_mars) || (bool)Engine.ai_trigger_test("e2_cov_hunters0_bypassed", e2_mars) || this.g_e3_started, 15);
        }

        [ScriptMethod(372, Lifecycle.Dormant)]
        public async Task e2_dialog()
        {
            await Engine.sleep(75);
            await Engine.sleep_until(async () => this.g_e2_door_breached);
            await Engine.sleep(120);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0340"));
            Engine.cs_run_command_script(e2_mars_johnson.Squad, new ScriptMethodReference(cs_e2_mars_johnson0_dialogue0));
            await Engine.sleep_until(async () => (float)Engine.ai_strength(e2_cov_hunters0.Squad) <= 0.8F, 30, this._30_seconds);
            if (!((float)Engine.ai_strength(e2_cov_hunters0.Squad) <= 0.8F))
            {
                Engine.ai_play_line_on_object(default(IGameObject), "0350") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_cov_hunters0.Squad) <= 0);
            await Engine.sleep(60);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0280"));
            await Engine.sleep(25);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0290"));
            await Engine.sleep(20);
            Engine.ai_play_line_on_object(default(IGameObject), "0300") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(373, Lifecycle.Dormant)]
        public async Task e2_cov_inf0_main()
        {
            Engine.ai_place(e2_cov_inf0.Squad);
        }

        [ScriptMethod(374, Lifecycle.Dormant)]
        public async Task e2_cov_hunters0_main()
        {
            await Engine.sleep_until(async () => Engine.objects_can_see_flag(Engine.players(), e2_wall_tap, 30F), 15, this.one_minute);
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\materials\\hard\\metal_thin\\metal_thin_large", 4249819951U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\visual_effects\\explosion_medium_metal_bits", 2192121969U));
            await Engine.sleep(30);
            Engine.device_set_position(e2_hunter_door.Entity, 0.5F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\materials\\hard\\metal_thin\\metal_thin_large", 4249819951U), e2_hunter_door_sound_source.Entity, 1F);
            Engine.object_damage_damage_section(e2_hunter_door.Entity, "body_hit0", 1.1F);
            Engine.object_create(e2_hunter_smoke);
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(e2_dialog));
            Engine.wake(new ScriptMethodReference(objective0_clear));
            Engine.ai_place(e2_cov_hunters0.Squad);
            await Engine.sleep(60);
            Engine.device_set_position(e2_hunter_door.Entity, 1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\materials\\hard\\metal_thin\\metal_thin_large", 4249819951U), e2_hunter_door_sound_source.Entity, 1F);
            Engine.object_damage_damage_section(e2_hunter_door.Entity, "body_hit1", 1.1F);
            await Engine.sleep(160);
            Engine.device_set_position_immediate(e2_hunter_door.Entity, 0.01F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\explosion_medium_metal_bits", 2192121969U), e2_hunter_door_sound_source.Entity, 1F);
            await Engine.sleep(1);
            Engine.object_damage_damage_section(e2_hunter_door.Entity, "body_main", 1.1F);
            await Engine.sleep(1);
            Engine.device_set_position_immediate(e2_hunter_door.Entity, 1F);
            Engine.object_destroy(e2_hunter_smoke.Entity);
            this.g_e2_door_breached = true;
            Engine.wake(new ScriptMethodReference(music_03a_01_stop));
            Engine.wake(new ScriptMethodReference(music_03a_02_start_alt));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_cov_hunters0.Squad) <= 0 || this.g_e3_started);
            Engine.wake(new ScriptMethodReference(objective1_set));
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_03a_02_stop));
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task e2_mars_inf0_main()
        {
            Engine.ai_migrate(e1_mars_inf0.Squad, e2_mars_inf0.Squad);
            Engine.ai_migrate(e1_mars_inf1.Squad, e2_mars_inf0.Squad);
            Engine.ai_renew(e2_mars_inf0.Squad);
            Engine.ai_disposable(e2_mars_inf0.Squad, false);
            Engine.cs_run_command_script(e2_mars_inf0.Squad, new ScriptMethodReference(cs_e2_mars_inf0_watch));
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task e2_mars_johnson_main()
        {
            Engine.ai_migrate(e1_mars_johnson.Squad, e2_mars_johnson.Squad);
            Engine.ai_disposable(e2_mars_johnson.Squad, false);
            Engine.cs_run_command_script(e2_mars_johnson.Squad, new ScriptMethodReference(cs_e2_mars_johnson0_watch));
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e2_cov_hunters0.Squad) > 0);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_cov_hunters0.Squad) <= 0);
            Engine.cs_run_command_script(e2_mars, new ScriptMethodReference(cs_e2_mars_continue));
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task e2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_main_begin, Engine.players()) && !(Engine.volume_test_objects_all(tv_e2_main_begin_exclude, Engine.players())), 15);
            this.g_e2_started = true;
            Engine.print("e2_main");
            Engine.data_mine_set_mission_segment("e2_hunter_intro");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e2_cov_hunters0_main));
            Engine.wake(new ScriptMethodReference(e2_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e2_mars_johnson_main));
            await Engine.sleep_until(async () => this.g_e3_started);
            Engine.sleep_forever(new ScriptMethodReference(e2_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_mars_johnson_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_cov_hunters0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_dialog));
            Engine.ai_disposable(e2_cov, true);
        }

        [ScriptMethod(378, Lifecycle.Static)]
        public async Task test_hunter_intro()
        {
            Engine.object_teleport(await this.player0(), e2_test);
            Engine.ai_place(e2_mars_inf0.Squad);
            Engine.ai_place(e2_mars_johnson.Squad);
            if (!(this.g_e2_started))
            {
                Engine.wake(new ScriptMethodReference(e2_main));
            }

            if (!(this.g_e3_started))
            {
                Engine.wake(new ScriptMethodReference(e3_main));
            }

            if (!(this.g_e8_started))
            {
                Engine.wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(379, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_pelican0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_mars_pelican/p0_facing"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e1_mars_pelican/p0"));
            this.g_e1_mars_pelican0_appeared = true;
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e1_mars_pelican/p1_facing"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e1_mars_pelican/p1"));
            await Engine.sleep(75);
            Engine.print("pilot: looks too tight down there");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0900"));
            this.g_e1_mars_pelican0_departing = true;
            Engine.cs_vehicle_speed(0.75F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e1_mars_pelican/p2"), 0.5F);
            await Engine.sleep(60);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e1_mars_pelican/p1_facing"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_mars_pelican/p3"));
            this.g_e1_mars_pelican0_departing = true;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_mars_pelican/p4"), 1F);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(380, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_johnson_finale()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_mars_johnson_finale/p0"));
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e2_cov_hunters0.Squad) > 0);
            await Engine.sleep(90);
        }

        [ScriptMethod(381, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_johnson_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_crouch(true);
            await Engine.sleep(105);
            Engine.cs_crouch(false);
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0850"));
            await Engine.sleep(15);
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0110"));
            await Engine.sleep(10);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_mars_entry/p2"));
        }

        [ScriptMethod(382, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_crouch(true);
            await Engine.sleep(120);
            Engine.cs_crouch(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_mars_entry/p4"));
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep(300);
        }

        [ScriptMethod(383, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_entry0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_crouch(true);
            await Engine.sleep(120);
            Engine.cs_crouch(false);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep(300);
        }

        [ScriptMethod(384, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_phantom0_0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_0_entry/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_0_entry/p1"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(385, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_phantom0_1_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p0"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p1_facing"));
            this.g_e1_cov_phantom0_1_arrived = true;
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p1"), 1F);
            await Engine.sleep(15);
            Engine.cs_vehicle_speed(0.66F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p2"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p3"), Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p3_facing"), 0.5F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p3_facing"));
            Engine.object_set_phantom_power(Engine.ai_vehicle_get(this.ai_current_actor), true);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_a");
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_b");
            await Engine.sleep(60);
            this.g_e1_cov_inf4_0_arrived = true;
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get(this.ai_current_actor), false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p4"), 0.5F);
            await Engine.sleep(150);
            Engine.cs_vehicle_speed(0.4F);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p3_facing"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p5"), 1F);
            this.g_e1_cov_phantom0_1_retreating = true;
            Engine.cs_vehicle_speed(0.75F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p6"));
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p7"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(386, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_grunt0()
        {
            Engine.cs_enable_dialogue(true);
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e1_patrol/grunt0"));
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || (short)Engine.ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_visible, 10);
            Engine.cs_approach(Engine.ai_get_object(this.ai_current_actor), 0.1F, 0.1F, 0.1F);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_dangerous, 3, 25);
            Engine.cs_movement_mode(this.ai_movement_flee);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/grunt1"));
        }

        [ScriptMethod(387, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_0_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/p0")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/p1")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/p2")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)));
                return false;
            });
        }

        [ScriptMethod(388, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_0_patrol1()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/p3"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/p4"));
                await Engine.sleep((short)Engine.random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(389, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_3_patrol0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/p7")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/p8")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_patrol/p9")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)));
                return false;
            });
        }

        [ScriptMethod(390, Lifecycle.Static)]
        public async Task<bool> johnson_has_sniping_weapon()
        {
            return Engine.unit_has_weapon(Engine.ai_get_unit(e1_mars_johnson.johnson0), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\sniper_rifle\\sniper_rifle.weapon", 4229569018U)) || Engine.unit_has_weapon(Engine.ai_get_unit(e1_mars_johnson.johnson0), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle.weapon", 3788636252U));
        }

        [ScriptMethod(391, Lifecycle.Static)]
        public async Task<bool> e1_cov_inf0_grunts_alerted()
        {
            return (short)Engine.ai_combat_status(e1_cov_inf0_0.grunt1) >= this.ai_combat_status_alert || (short)Engine.ai_combat_status(e1_cov_inf0_0.grunt2) >= this.ai_combat_status_alert || (short)Engine.ai_combat_status(e1_cov_inf0_1.Squad) >= this.ai_combat_status_alert;
        }

        [ScriptMethod(392, Lifecycle.Static)]
        public async Task<bool> e1_cov_inf2_under_limit()
        {
            return this.g_e1_cov_inf2_spawned < this.g_e1_cov_inf2_limit;
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task<bool> e1_cov_inf2_spawn_ready()
        {
            return (short)Engine.ai_living_count(e1_cov_inf2) <= 1 && (short)Engine.ai_fighting_count(e1_cov_inf2) <= 0;
        }

        [ScriptMethod(394, Lifecycle.Static)]
        public async Task e1_cov_inf2_sleep_until_respawn()
        {
            await Engine.sleep_until(async () => await this.e1_cov_inf2_spawn_ready(), 31, this.two_minutes);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_on_building, Engine.players()), 30, 150);
        }

        [ScriptMethod(395, Lifecycle.Static)]
        public async Task e1_cov_inf2_6_spawn()
        {
            if (!(Engine.volume_test_objects(tv_e1_cov_inf2_1_unsafe, Engine.players())))
            {
                Engine.game_save();
                await Engine.sleep(5);
                Engine.ai_place(e1_cov_inf2_6.Squad, (short)Engine.min(5F, 10F - (float)Engine.ai_living_count(e1_cov_inf2)));
                Engine.ai_set_orders(e1_cov_inf2_6.Squad, e1_cov_inf2_engage0);
                await Engine.sleep(2);
                Engine.ai_magically_see(e1_mars_johnson.Squad, e1_cov_inf2_5.Squad);
                this.g_e1_cov_inf2_spawned = (short)(this.g_e1_cov_inf2_spawned + 1);
                await this.e1_cov_inf2_sleep_until_respawn();
            }
        }

        [ScriptMethod(396, Lifecycle.Static)]
        public async Task e1_cov_inf2_5_spawn()
        {
            if (!(Engine.volume_test_objects(tv_e1_cov_inf2_5_unsafe, Engine.players())))
            {
                Engine.game_save();
                await Engine.sleep(5);
                Engine.ai_place(e1_cov_inf2_5.Squad, (short)Engine.min(5F, 10F - (float)Engine.ai_living_count(e1_cov_inf2)));
                Engine.ai_set_orders(e1_cov_inf2_5.Squad, e1_cov_inf2_5_init);
                await Engine.sleep(2);
                Engine.ai_magically_see(e1_mars_johnson.Squad, e1_cov_inf2_5.Squad);
                this.g_e1_cov_inf2_spawned = (short)(this.g_e1_cov_inf2_spawned + 1);
                await Engine.sleep(120);
                if (this.g_e1_cov_inf2_wave0)
                {
                    Engine.ai_play_line(e1_mars_johnson.johnson0, "0210") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                }

                await this.e1_cov_inf2_sleep_until_respawn();
            }
        }

        [ScriptMethod(397, Lifecycle.Static)]
        public async Task e1_cov_inf2_3_spawn()
        {
            if (!(Engine.volume_test_objects(tv_e1_cov_inf2_3_unsafe, Engine.players())))
            {
                Engine.game_save();
                await Engine.sleep(5);
                Engine.ai_place(e1_cov_inf2_3.Squad, (short)Engine.min(5F, 10F - (float)Engine.ai_living_count(e1_cov_inf2)));
                Engine.ai_set_orders(e1_cov_inf2_3.Squad, e1_cov_inf2_engage0);
                await Engine.sleep(2);
                Engine.ai_magically_see(e1_mars_johnson.Squad, e1_cov_inf2_3.Squad);
                this.g_e1_cov_inf2_spawned = (short)(this.g_e1_cov_inf2_spawned + 1);
                await Engine.sleep(120);
                if (this.g_e1_cov_inf2_wave0)
                {
                    Engine.ai_play_line(e1_mars_johnson.johnson0, "0170") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                }

                await this.e1_cov_inf2_sleep_until_respawn();
            }
        }

        [ScriptMethod(398, Lifecycle.Static)]
        public async Task e1_cov_inf2_1_spawn()
        {
            if (!(Engine.volume_test_objects(tv_e1_cov_inf2_1_unsafe, Engine.players())))
            {
                Engine.game_save();
                await Engine.sleep(5);
                Engine.ai_place(e1_cov_inf2_1.Squad, (short)Engine.min(5F, 10F - (float)Engine.ai_living_count(e1_cov_inf2)));
                Engine.ai_set_orders(e1_cov_inf2_1.Squad, e1_cov_inf2_engage0);
                await Engine.sleep(2);
                Engine.ai_magically_see(e1_mars_johnson.Squad, e1_cov_inf2_1.Squad);
                this.g_e1_cov_inf2_spawned = (short)(this.g_e1_cov_inf2_spawned + 1);
                await Engine.sleep(90);
                if (!(this.g_e1_cov_inf2_wave0))
                {
                    Engine.ai_play_line(e1_mars_johnson.johnson0, "0150") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                }

                await this.e1_cov_inf2_sleep_until_respawn();
            }
        }

        [ScriptMethod(399, Lifecycle.Dormant)]
        public async Task e1_mars_pelican0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_inf4_1.Squad) > 0 && (short)Engine.ai_living_count(e1_cov_inf4) <= 3);
            Engine.ai_place(e1_mars_pelican0.Squad);
            Engine.ai_vehicle_enter_immediate(e1_mars_pelican0.gunner0, Engine.ai_vehicle_get(e1_mars_pelican0.pelican0), "pelican_g");
            Engine.ai_vehicle_enter_immediate(e1_mars_pelican0.gunner1, Engine.ai_vehicle_get(e1_mars_pelican0.pelican0), "pelican_g_rear");
            Engine.cs_run_command_script(e1_mars_pelican0.pelican0, new ScriptMethodReference(cs_e1_mars_pelican0_entry));
            await Engine.sleep_until(async () => this.g_e1_mars_pelican0_departing, 30);
            Engine.wake(new ScriptMethodReference(e2_main));
        }

        [ScriptMethod(400, Lifecycle.Dormant)]
        public async Task e1_cov_phantom0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_main_area_entrance, Engine.players()), 5);
            await Engine.sleep_until(async () => await this.e1_cov_inf0_grunts_alerted(), 30, this._30_seconds);
            Engine.ai_place(e1_cov_phantom0_0.Squad);
            Engine.cs_run_command_script(e1_cov_phantom0_0.phantom0, new ScriptMethodReference(cs_e1_cov_phantom0_0_entry));
            Engine.sleep_forever();
            Engine.ai_place(e1_cov_phantom0_1.Squad);
            Engine.wake(new ScriptMethodReference(music_03a_01_start));
        }

        [ScriptMethod(401, Lifecycle.Dormant)]
        public async Task e1_cov_snipers0_main()
        {
            if (await this.difficulty_legendary())
            {
                this.g_e1_cov_snipers0_limit = 5;
            }

            Engine.begin_random(async () =>
            {
                if ((short)Engine.ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(Engine.volume_test_objects(tv_e1_cov_sniper0_0_unsafe, Engine.players())))
                    {
                        Engine.ai_place(e1_cov_snipers0.sniper0);
                        Engine.game_save();
                        await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await Engine.sleep((short)Engine.random_range(this.one_minute, this.two_minutes));
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(Engine.volume_test_objects(tv_e1_cov_sniper0_1_unsafe, Engine.players())))
                    {
                        Engine.ai_place(e1_cov_snipers0.sniper1);
                        Engine.game_save();
                        await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await Engine.sleep((short)Engine.random_range(this.one_minute, this.two_minutes));
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(Engine.volume_test_objects(tv_e1_cov_sniper0_2_unsafe, Engine.players())))
                    {
                        Engine.ai_place(e1_cov_snipers0.sniper2);
                        Engine.game_save();
                        await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await Engine.sleep((short)Engine.random_range(this.one_minute, this.two_minutes));
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(Engine.volume_test_objects(tv_e1_cov_sniper0_3_unsafe, Engine.players())))
                    {
                        Engine.ai_place(e1_cov_snipers0.sniper3);
                        Engine.game_save();
                        await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await Engine.sleep((short)Engine.random_range(this.one_minute, this.two_minutes));
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(Engine.volume_test_objects(tv_e1_cov_sniper0_3_unsafe, Engine.players())))
                    {
                        Engine.ai_place(e1_cov_snipers0.sniper4);
                        Engine.game_save();
                        await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await Engine.sleep((short)Engine.random_range(this.one_minute, this.two_minutes));
                    }
                }
            });
        }

        [ScriptMethod(402, Lifecycle.Dormant)]
        public async Task e1_cov_inf4_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_phantom0_1.Squad) > 0, 10);
            if (await this.difficulty_heroic())
            {
                Engine.ai_place_in_vehicle(e1_cov_inf4_0.elite1, e1_cov_phantom0_1.Squad);
            }

            if (await this.difficulty_legendary())
            {
                Engine.ai_place_in_vehicle(e1_cov_inf4_2.Squad, e1_cov_phantom0_1.Squad);
            }

            Engine.ai_place_in_vehicle(e1_cov_inf4_0.Squad, e1_cov_phantom0_1.Squad);
            await Engine.sleep_until(async () => this.g_e1_cov_inf4_0_arrived);
            await Engine.sleep(300);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_inf4) <= 2 && !(Engine.volume_test_objects(tv_e1_cov_inf4_1_unsafe, Engine.players())), 30, this.two_minutes);
            Engine.ai_place(e1_cov_inf4_1.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(e1_cov_inf4), 2F, 5F));
        }

        [ScriptMethod(403, Lifecycle.Dormant)]
        public async Task e1_cov_inf3_main()
        {
            Engine.ai_place(e1_cov_inf3_2.Squad);
            await Engine.sleep_until(async () => (float)Engine.ai_strength(e1_cov_inf3_2.Squad) <= 0.75F && Engine.objects_can_see_flag(Engine.players(), e1_cov_inf3_entrance, 25F), 5, this._30_seconds);
            Engine.ai_place(e1_cov_inf3_0.Squad, (short)(5 - (float)Engine.ai_living_count(e1_cov_inf3)));
            await Engine.sleep(30);
            Engine.ai_play_line(e1_mars_johnson.johnson0, "0270") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e1_cov_inf3) < 3)
                {
                    Engine.ai_place(e1_cov_inf3_1.Squad, 2);
                }

                return (short)Engine.ai_spawn_count(e1_cov_inf3) >= 10;
            });
            Engine.ai_set_orders(e1_cov_inf3, e1_cov_inf3_advance0);
        }

        [ScriptMethod(404, Lifecycle.Dormant)]
        public async Task e1_cov_inf2_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_inf1) <= 1 && (short)Engine.ai_spawn_count(e1_cov_inf1) > 0, 30, this.one_minute);
            await this.e1_cov_inf2_sleep_until_respawn();
            this.g_e1_cov_inf2_spawned = 0;
            this.g_e1_cov_inf2_limit = 2;
            if (await this.difficulty_heroic())
            {
                this.g_e1_cov_inf2_limit = 2;
            }

            if (await this.difficulty_legendary())
            {
                this.g_e1_cov_inf2_limit = 3;
            }

            if (!(await this.difficulty_normal()))
            {
                Engine.wake(new ScriptMethodReference(e1_cov_snipers0_main));
            }

            Engine.begin_random(async () =>
            {
                if (await this.e1_cov_inf2_under_limit())
                {
                    await this.e1_cov_inf2_1_spawn();
                }
            }, 
                async () =>
            {
                if (await this.e1_cov_inf2_under_limit())
                {
                    await this.e1_cov_inf2_3_spawn();
                }
            }, 
                async () =>
            {
                if (await this.e1_cov_inf2_under_limit())
                {
                    await this.e1_cov_inf2_6_spawn();
                }
            });
            await this.e1_cov_inf2_sleep_until_respawn();
            Engine.game_save();
            await Engine.sleep(60);
            await this.e1_cov_inf2_5_spawn();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_inf2) <= 1 && (short)Engine.ai_fighting_count(e1_cov_inf2) <= 0);
            Engine.garbage_collect_now();
            Engine.game_save();
            await Engine.sleep(15);
            Engine.wake(new ScriptMethodReference(e1_cov_inf3_main));
            await Engine.sleep(30);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_inf3_1.Squad) > 0 && (short)Engine.ai_living_count(e1_cov_inf3) <= 2 && (short)Engine.ai_fighting_count(e1_cov_inf3) <= 0, 30, this.two_minutes);
            Engine.ai_disposable(e1_cov_inf3, true);
            Engine.game_save();
            await Engine.sleep(30);
            Engine.garbage_collect_now();
            this.g_e1_cov_inf2_wave0 = false;
            this.g_e1_cov_inf2_spawned = 0;
            this.g_e1_cov_inf2_limit = 2;
            if (await this.difficulty_heroic())
            {
                this.g_e1_cov_inf2_limit = 3;
            }

            if (await this.difficulty_legendary())
            {
                this.g_e1_cov_inf2_limit = 3;
            }

            Engine.begin_random(async () =>
            {
                if (await this.e1_cov_inf2_under_limit())
                {
                    await this.e1_cov_inf2_1_spawn();
                }
            }, 
                async () =>
            {
                if (await this.e1_cov_inf2_under_limit())
                {
                    await this.e1_cov_inf2_3_spawn();
                }
            }, 
                async () =>
            {
                if (await this.e1_cov_inf2_under_limit())
                {
                    await this.e1_cov_inf2_5_spawn();
                }
            }, 
                async () =>
            {
                if (await this.e1_cov_inf2_under_limit())
                {
                    await this.e1_cov_inf2_6_spawn();
                }
            });
            await this.e1_cov_inf2_sleep_until_respawn();
            Engine.game_save();
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(e1_cov_phantom0_main));
            Engine.wake(new ScriptMethodReference(e1_cov_inf4_main));
        }

        [ScriptMethod(405, Lifecycle.Dormant)]
        public async Task e1_cov_inf1_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_inf0_2.Squad) > 0 && (short)Engine.ai_living_count(e1_cov_inf0) <= 1 && (short)Engine.ai_fighting_count(e1_cov_inf0) <= 0, 30);
            Engine.game_save();
            await Engine.sleep(120);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e1_cov_inf1_unsafe, Engine.players())));
            Engine.ai_place(e1_cov_inf1);
            Engine.ai_magically_see(e1_cov_inf1, e1_mars);
        }

        [ScriptMethod(406, Lifecycle.Dormant)]
        public async Task e1_cov_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_crash_area_exit, Engine.players()) || Engine.volume_test_objects(tv_e1_main_area_entrance, Engine.players()) || Engine.volume_test_objects(tv_e1_prediction, Engine.players()), 5);
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\characters\\grunt\\grunt", 4114944975U));
            Engine.camera_predict_resources_at_point(e1_prediction);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_crash_area_exit, Engine.players()) || Engine.volume_test_objects(tv_e1_main_area_entrance, Engine.players()), 5);
            Engine.ai_place(e1_cov_inf0_0.Squad);
            Engine.ai_place(e1_cov_inf0_3.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_inf0) <= 3 || Engine.volume_test_objects(tv_e1_cov_inf0_1_begin, Engine.players()), 15);
            Engine.ai_place(e1_cov_inf0_1.grunt0);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_inf0) <= 3 || Engine.volume_test_objects(tv_e1_cov_inf0_1_begin, Engine.players()), 15);
            Engine.ai_place(e1_cov_inf0_1.grunt1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e1_cov_inf0_3.Squad) <= 0 || Engine.volume_test_objects(tv_e1_cov_inf0_2_begin, Engine.players()), 15);
            Engine.ai_place(e1_cov_inf0_2.Squad);
            await Engine.sleep(5);
            Engine.ai_magically_see(e1_cov_inf0_2.Squad, e1_mars_inf0.Squad);
            Engine.wake(new ScriptMethodReference(e1_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e1_cov_inf2_main));
        }

        [ScriptMethod(407, Lifecycle.Dormant)]
        public async Task e1_mars_inf1_main()
        {
            Engine.ai_place(e1_mars_inf1.Squad);
        }

        [ScriptMethod(408, Lifecycle.Dormant)]
        public async Task e1_mars_inf0_main()
        {
            Engine.ai_place(e1_mars_inf0.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_phantom0_1.Squad) > 0 && (short)Engine.ai_living_count(e1_cov_phantom0_1.Squad) <= 0);
        }

        [ScriptMethod(409, Lifecycle.Dormant)]
        public async Task e1_mars_johnson_main()
        {
            Engine.ai_place(e1_mars_johnson.Squad);
            Engine.object_cannot_die(Engine.ai_get_object(e1_mars_johnson.johnson0), true);
            Engine.cs_run_command_script(e1_mars_johnson.Squad, new ScriptMethodReference(cs_e1_mars_johnson_entry));
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_inf0_2.Squad) > 0 && (short)Engine.ai_living_count(e1_cov_inf0_2.Squad) <= 0);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_on_building, Engine.ai_actors(e1_mars_johnson.Squad)), 30, 450);
            await Engine.sleep(Engine.ai_play_line(e1_mars_johnson.johnson0, "0120"));
            Engine.print("they know we're here");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(objective0_set));
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_inf1) > 0);
            await Engine.sleep(60);
            Engine.ai_play_line(e1_mars_johnson.johnson0, "0130") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e1_cov_phantom0_0.Squad) > 0);
            await Engine.sleep_until(async () => this.g_e1_cov_phantom0_1_arrived);
            await Engine.sleep(60);
            await Engine.sleep(Engine.ai_play_line(e1_mars_johnson.johnson0, "0890"));
            await Engine.sleep_until(async () => this.g_e1_mars_pelican0_appeared, 15);
            Engine.cs_run_command_script(e1_mars_johnson.Squad, new ScriptMethodReference(cs_e1_mars_johnson_finale));
            await Engine.sleep_until(async () => this.g_e1_mars_pelican0_departing, 3, this.one_minute);
            await Engine.sleep(20);
            await Engine.sleep(Engine.ai_play_line(e1_mars_johnson.johnson0, "0910"));
            Engine.wake(new ScriptMethodReference(music_03a_02_start));
        }

        [ScriptMethod(410, Lifecycle.Dormant)]
        public async Task e1_key()
        {
            Engine.object_create(e1_ghost_key);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4242086585U)) && Engine.volume_test_object(tv_e1_ghost_key, await this.player0()) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4242086585U)) && Engine.volume_test_object(tv_e1_ghost_key, await this.player1()));
            Engine.ice_cream_flavor_stock(6);
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task e1_main()
        {
            this.g_e1_started = true;
            Engine.print("e1_main");
            Engine.data_mine_set_mission_segment("e1_rooftop_defense");
            Engine.wake(new ScriptMethodReference(e3_main));
            Engine.wake(new ScriptMethodReference(e8_main));
            Engine.wake(new ScriptMethodReference(e12_main));
            Engine.wake(new ScriptMethodReference(e1_mars_johnson_main));
            Engine.wake(new ScriptMethodReference(e1_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e1_mars_inf1_main));
            Engine.wake(new ScriptMethodReference(e1_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e1_cov_phantom0_main));
            Engine.wake(new ScriptMethodReference(e1_mars_pelican0_main));
            Engine.wake(new ScriptMethodReference(e1_key));
            await Engine.sleep_until(async () => this.g_e2_started);
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_snipers0_main));
            await Engine.sleep_until(async () => this.g_e3_started);
            Engine.sleep_forever(new ScriptMethodReference(e1_mars_johnson_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_mars_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_inf3_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_inf4_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_phantom0_main));
            Engine.ai_disposable(e1_cov, true);
            Engine.ai_disposable(e1_cov_phantom0, false);
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            Engine.wake(new ScriptMethodReference(flashlight_control));
            await this.cinematic_snap_to_black();
            await this.cinematic_intro();
            Engine.wake(new ScriptMethodReference(e1_main));
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.chief_recovery_sequence();
            Engine.wake(new ScriptMethodReference(chapter_title0));
            await Engine.sleep(150);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mission_end, Engine.players()), 8);
            this.g_mission_over = true;
            await this.playtest_mission();
            await Engine.sleep(15);
            Engine.sound_class_set_gain("", 0F, 15);
            await this.cinematic_fade_to_white();
            await Engine.sleep(15);
            Engine.game_won();
        }

        [ScriptMethod(413, Lifecycle.Static)]
        public async Task start()
        {
            Engine.wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(414, Lifecycle.Startup)]
        public async Task mission_main()
        {
            Engine.ai_allegiance(player, human);
            Engine.ai_allegiance(covenant, prophet);
            Engine.objectives_clear();
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task _03_intro_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 2);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3849585662U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3850765328U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 4);
            await Engine.sleep(113);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3852272679U), 2);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 76, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3853321271U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 57, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 62, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853648956U), 0);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            await Engine.sleep(76);
            Engine.print("predicting chief");
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 19);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 19);
            await Engine.sleep(91);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3855483992U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3859022990U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3859022990U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 2);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3855483992U), 0);
            await Engine.sleep(81);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 71, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3850765328U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853648956U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788177493U), 4);
            await Engine.sleep(121);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 58);
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task _03_intro_02_predict()
        {
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 71, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853648956U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3853321271U), 0);
            await Engine.sleep(130);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 65);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\sniper_rifle\\sniper_rifle", 3865314542U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3865773301U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\spotting_scope\\spotting_scope", 3866428671U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3866756356U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3783000070U), 2);
            await Engine.sleep(12);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 107);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 108);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 109);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 110);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 111);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 112);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 113);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 114);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 115);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\turrets\\chaingun\\chaingun", 3871016261U), 3);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 55);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 54);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 61);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\turrets\\chaingun\\chaingun", 3871016261U), 2);
            await Engine.sleep(28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\turrets\\chaingun\\chaingun", 3871016261U), 1);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            await Engine.sleep(21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 70);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 119);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 120);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 122);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 123);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 16);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3866756356U), 0);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3868591392U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\warthog\\turrets\\chaingun\\chaingun", 3871016261U), 1);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            await Engine.sleep(16);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3853321271U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 65);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\sniper_rifle\\sniper_rifle", 3865314542U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3865773301U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\spotting_scope\\spotting_scope", 3866428671U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            await Engine.sleep(54);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, true);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            await Engine.sleep(15);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3866756356U), 0);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3853321271U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3871737168U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3871933779U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            await Engine.sleep(19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task _03_intro_03_predict()
        {
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 69);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\helmet_standard\\helmet_standard", 3872327001U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3788767326U), 2);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            await Engine.sleep(16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            await Engine.sleep(47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            await Engine.sleep(44);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            await Engine.sleep(25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3788767326U), 2);
            await Engine.sleep(57);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 73);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\sniper_rifle\\sniper_rifle", 3865314542U), 2);
            await Engine.sleep(35);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3853780030U), 19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3866756356U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3865773301U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\helmet_standard\\helmet_standard", 3872327001U), 0);
            await Engine.sleep(66);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 69);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            await Engine.sleep(27);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            await Engine.sleep(54);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3866756356U), 1);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
        }

        [ScriptMethod(418, Lifecycle.Dormant)]
        public async Task _03_intro_04_predict()
        {
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3865773301U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            await Engine.sleep(23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            await Engine.sleep(20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3873703278U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3874620796U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3875407240U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3876062610U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3876390295U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3866756356U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3876980128U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\vent_wall_a\\vent_wall_a", 3878421942U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3878684090U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3878684090U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3878684090U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3871933779U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3871737168U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3853321271U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, true);
            await Engine.sleep(8);
            await Engine.sleep(19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            await Engine.sleep(27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            await Engine.sleep(13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3876390295U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3865773301U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 7);
            await Engine.sleep(9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\garbage\\civ_wheel\\civ_wheel", 3878946238U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3876390295U), 3);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3876062610U), 0);
            await Engine.sleep(51);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3876062610U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3871933779U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3871737168U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3853321271U), 0);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 4);
            await Engine.sleep(36);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3876062610U), 0);
            await Engine.sleep(26);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3850765328U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 1);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3872392538U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3874620796U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3875407240U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3876062610U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3868067096U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3866756356U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3865773301U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            await Engine.sleep(79);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            await Engine.sleep(22);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3875734925U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\garbage\\civ_wheel\\civ_wheel", 3878946238U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3876390295U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3866756356U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3876980128U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3878684090U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3878684090U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3878684090U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3871933779U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3871933779U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3871737168U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3860989100U), 71);
            await Engine.sleep(19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\vent_wall_a\\vent_wall_a", 3878421942U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3871737168U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            await Engine.sleep(17);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\junction_box_lg_garbage2\\junction_box_lg_garbage2", 3879339460U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\junction_box_lg_garbage1\\junction_box_lg_garbage1", 3879404997U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3865773301U), 0);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_c\\concrete_chunk_c", 3879470534U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3879798219U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_f\\concrete_chunk_f", 3879863756U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_d\\concrete_chunk_d", 3879929293U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3853321271U), 0);
        }
    }
}