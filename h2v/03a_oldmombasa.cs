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
            this.g_e11_pod_impact_effect = GetTag<EffectTag>("effects\\scenarios\\solo\\earthcity\\e11_insertion_pod_impact", 4267187237U);
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
        public async Task _03_intro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intro_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _03_intro_02_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intro_02_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _03_intro_03_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intro_03_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _03_intro_04_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intro_04_predict));
        }

        [ScriptMethod(28, Lifecycle.Dormant)]
        public async Task c03_intro_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\music\\c03_intro_01_mus", 3833987856U), default(IGameObject), 1F);
            print("c03_intro score 01 start");
        }

        [ScriptMethod(29, Lifecycle.Dormant)]
        public async Task c03_intro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_01_fol", 3834053393U), default(IGameObject), 1F);
            print("c03_intro foley 01 start");
        }

        [ScriptMethod(30, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene1_01()
        {
            object_set_function_variable(pelican_01.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(pelican_02.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(pelican_03.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(pelican_04.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(pelican_01.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(pelican_02.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(pelican_03.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(pelican_04.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(pelican_01.Entity, "hover_audio", 1F, 0F);
            object_set_function_variable(pelican_02.Entity, "hover_audio", 1F, 0F);
            object_set_function_variable(pelican_03.Entity, "hover_audio", 1F, 0F);
            object_set_function_variable(pelican_04.Entity, "hover_audio", 1F, 0F);
            sound_class_set_gain("vehicle", 0F, 0);
            sound_class_set_gain("vehicle", 1F, 115);
            object_set_velocity(pelican_01.Entity, 8F);
            object_set_velocity(pelican_02.Entity, 8F);
            object_set_velocity(pelican_03.Entity, 8F);
            await sleep(130);
            sound_class_set_gain("vehicle", 0F, 120);
        }

        [ScriptMethod(31, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene1_02()
        {
            await sleep(260);
            sound_class_set_gain("vehicle", 0.5F, 10);
        }

        [ScriptMethod(32, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene1_03()
        {
            await sleep(350);
            sound_class_set_gain("vehicle", 0F, 10);
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene1_04()
        {
            await sleep(435);
            sound_class_set_gain("vehicle", 0.5F, 10);
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c03_1010_cor()
        {
            await sleep(212);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1010_cor", 3834118930U), default(IGameObject), 1F);
            cinematic_subtitle("c03_1010_cor", 1F);
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c03_1011_cor()
        {
            await sleep(265);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1011_cor", 3834184467U), default(IGameObject), 1F);
            cinematic_subtitle("c03_1011_cor", 2F);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c03_1020_mir()
        {
            await sleep(333);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1020_mir", 3834250004U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c03_1020_mir", 1F);
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c03_1021_mir()
        {
            await sleep(357);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1021_mir", 3834315541U), miranda.Entity, 1F);
            cinematic_subtitle("c03_1021_mir", 1F);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c03_1030_jon()
        {
            await sleep(396);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1030_jon", 3834381078U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c03_1030_jon", 5F);
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task c03_1040_jon()
        {
            await sleep(560);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1040_jon", 3834446615U), johnson.Entity, 1F);
            cinematic_subtitle("c03_1040_jon", 4F);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c03_1050_och_1()
        {
            await sleep(684);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1050_och", 3834512152U), pilot.Entity, 1F);
            cinematic_subtitle("c03_1050_och", 1F);
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c03_1050_och_2()
        {
            await sleep(684);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1050_och", 3834512152U), copilot.Entity, 1F);
            cinematic_subtitle("c03_1050_och", 2F);
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c03_intro_shake_01_1()
        {
            await sleep(113);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            player_effect_stop(1.5F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c03_intro_shake_01_2()
        {
            await sleep(259);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            await sleep(91);
            player_effect_stop(0F);
            print("shake stop");
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task c03_intro_shake_01_3()
        {
            await sleep(560);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task c03_intro_01_dof_1()
        {
            await sleep(436);
            print("dof values: 12 5 5 0 0 0 0");
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(12F, 5F, 5F, 0F, 0F, 0F, 0F);
            await sleep(123);
            print("dof stop");
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task cinematic_light_01_city_01()
        {
            cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(pilot.Entity, true);
            object_uses_cinematic_lighting(copilot.Entity, true);
            object_uses_cinematic_lighting(pelican_01.Entity, true);
            object_uses_cinematic_lighting(pelican_02.Entity, true);
            object_uses_cinematic_lighting(pelican_03.Entity, true);
            object_uses_cinematic_lighting(pelican_04.Entity, true);
            object_uses_cinematic_lighting(iac.Entity, true);
            object_uses_cinematic_lighting(iac_bridge.Entity, true);
            object_uses_cinematic_lighting(carrier.Entity, true);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task cinematic_light_01_pelican_01()
        {
            await sleep(259);
            object_destroy(carrier.Entity);
            print("destroy carrier");
            cinematic_lighting_set_primary_light(4F, 278F, 0.54902F, 0.478431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-34F, 154F, 0.14902F, 0.141176F, 0.180392F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            await sleep(86);
            fade_out(1F, 1F, 1F, 5);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task cinematic_light_01_iac_01()
        {
            await sleep(350);
            object_hide(chief.Entity, true);
            print("hide chief");
            cinematic_lighting_set_primary_light(-52F, 282F, 0.156863F, 0.180392F, 0.333333F);
            cinematic_lighting_set_secondary_light(-75F, 150F, 0.121569F, 0.121569F, 0.180392F);
            cinematic_lighting_set_ambient_light(0.0588235F, 0.0509804F, 0.0392157F);
            await sleep(20);
            fade_in(1F, 1F, 1F, 5);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task cinematic_light_01_city_02()
        {
            await sleep(435);
            object_destroy(miranda.Entity);
            object_destroy(iac_bridge.Entity);
            print("destroy miranda, iac bridge");
            cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task cinematic_light_01_pelican_02()
        {
            await sleep(558);
            print("light pelican");
            cinematic_lighting_set_primary_light(29F, 116F, 0.478431F, 0.415686F, 0.329412F);
            cinematic_lighting_set_secondary_light(20F, 272F, 0.235294F, 0.235294F, 0.384314F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task c03_intro_01_problem_actors()
        {
            print("problem actors");
            object_create_anew(iac);
            object_create_anew(pelican_01);
            object_create_anew(pelican_02);
            object_create_anew(pelican_03);
            object_create_anew(pelican_04);
            object_cinematic_lod(iac.Entity, true);
            object_cinematic_lod(pelican_01.Entity, true);
            object_cinematic_lod(pelican_02.Entity, true);
            object_cinematic_lod(pelican_03.Entity, true);
            object_cinematic_lod(pelican_04.Entity, true);
            object_cinematic_visibility(iac.Entity, true);
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task c03_intro_01_setup()
        {
            object_create_anew(chief);
            object_create_anew(miranda);
            object_create_anew(johnson);
            object_create_anew(pilot);
            object_create_anew(copilot);
            object_create_anew(iac_bridge);
            object_create_anew(carrier);
            unit_set_emotional_state(miranda.Entity, "inquisitive", 0.25F, 0);
            object_set_scale(carrier.Entity, 0.4F, 0);
            object_set_function_variable(carrier.Entity, "grav_lift_control", 1F, 0F);
            object_create_anew(intro_flak_01);
            object_create_anew(intro_flak_02);
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(pilot.Entity, true);
            object_cinematic_lod(copilot.Entity, true);
            object_cinematic_lod(carrier.Entity, true);
            object_set_permutation(copilot.Entity, "head", "smith");
            unit_set_emotional_state(johnson.Entity, "happy", 0.25F, 0);
            unit_set_emotional_state(pilot.Entity, "angry", 0.25F, 0);
            unit_set_emotional_state(copilot.Entity, "angry", 0.25F, 0);
            wake(new ScriptMethodReference(c03_intro_score_01));
            wake(new ScriptMethodReference(c03_intro_foley_01));
            wake(new ScriptMethodReference(c03_intro_sound_scene1_01));
            wake(new ScriptMethodReference(c03_intro_sound_scene1_02));
            wake(new ScriptMethodReference(c03_intro_sound_scene1_03));
            wake(new ScriptMethodReference(c03_intro_sound_scene1_04));
            wake(new ScriptMethodReference(c03_1010_cor));
            wake(new ScriptMethodReference(c03_1011_cor));
            wake(new ScriptMethodReference(c03_1020_mir));
            wake(new ScriptMethodReference(c03_1021_mir));
            wake(new ScriptMethodReference(c03_1030_jon));
            wake(new ScriptMethodReference(c03_1040_jon));
            wake(new ScriptMethodReference(c03_1050_och_1));
            wake(new ScriptMethodReference(c03_1050_och_2));
            wake(new ScriptMethodReference(c03_intro_shake_01_1));
            wake(new ScriptMethodReference(c03_intro_shake_01_2));
            wake(new ScriptMethodReference(c03_intro_shake_01_3));
            wake(new ScriptMethodReference(cinematic_light_01_city_01));
            wake(new ScriptMethodReference(cinematic_light_01_pelican_01));
            wake(new ScriptMethodReference(cinematic_light_01_iac_01));
            wake(new ScriptMethodReference(cinematic_light_01_city_02));
            wake(new ScriptMethodReference(cinematic_light_01_pelican_02));
        }

        [ScriptMethod(53, Lifecycle.Static)]
        public async Task c03_intro_01_cleanup()
        {
            object_destroy(pelican_04.Entity);
            player_effect_stop(0F);
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task c03_intro_scene_01()
        {
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.c03_intro_01_problem_actors();
            await this._03_intro_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\music\\c03_intro_01_mus", 3833987856U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_01_fol", 3834053393U));
            await sleep(this.prediction_offset);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intro\\03_intro", 3834577689U), "03_intro_01", default(IUnit), anchor_flag_intro);
            await this.c03_intro_01_setup();
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intro\\03_intro", 3834643226U), "mc_01", false, anchor_intro.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "johnson_01", false, anchor_intro.Entity);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\03_intro\\03_intro", 3834839837U), "miranda_01", false, anchor_intro.Entity);
            custom_animation_relative(pilot.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "marine1_01", false, anchor_intro.Entity);
            custom_animation_relative(copilot.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "marine2_01", false, anchor_intro.Entity);
            custom_animation_relative(pelican_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel1_01", false, anchor_intro.Entity);
            custom_animation_relative(pelican_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel2_01", false, anchor_intro.Entity);
            custom_animation_relative(pelican_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel3_01", false, anchor_intro.Entity);
            custom_animation_relative(pelican_04.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel4_01", false, anchor_intro.Entity);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\03_intro\\03_intro", 3837330243U), "iac_01", anchor_intro.Entity);
            scenery_animation_start_relative(iac_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\03_intro\\03_intro", 3837395780U), "iac_bridge_01", anchor_intro.Entity);
            await sleep(10);
            fade_in(0F, 0F, 0F, 60);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._03_intro_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_02_fol", 3837461317U));
            await sleep((short)camera_time());
            await this.c03_intro_01_cleanup();
        }

        [ScriptMethod(55, Lifecycle.CommandScript)]
        public async Task cs_hog_01()
        {
            cs_force_combat_status(3);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            object_set_velocity(ai_vehicle_get(this.ai_current_actor), 1F);
            cs_vehicle_speed(0.9F);
            ai_vehicle_enter_immediate(intro_hog_01.driver, ai_vehicle_get_from_starting_location(intro_hog_01.hog), "warthog_d");
            await sleep(1);
            object_hide(ai_get_object(this.ai_current_actor), true);
            cs_go_to(GetReference<ISpatialPoint>("intro_hog_targets/p0"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(56, Lifecycle.CommandScript)]
        public async Task cs_hog_02()
        {
            cs_force_combat_status(3);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            object_set_velocity(ai_vehicle_get(this.ai_current_actor), 1F);
            cs_vehicle_speed(0.9F);
            ai_vehicle_enter_immediate(intro_hog_02.driver, ai_vehicle_get_from_starting_location(intro_hog_02.hog), "warthog_d");
            await sleep(1);
            object_hide(ai_get_object(this.ai_current_actor), true);
            cs_go_to(GetReference<ISpatialPoint>("intro_hog_targets/p0"));
        }

        [ScriptMethod(57, Lifecycle.CommandScript)]
        public async Task cs_hog_03()
        {
            cs_force_combat_status(3);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            object_set_velocity(ai_vehicle_get(this.ai_current_actor), 1F);
            ai_vehicle_enter_immediate(intro_hog_03.driver, ai_vehicle_get_from_starting_location(intro_hog_03.hog), "warthog_d");
            cs_vehicle_speed(0.9F);
            await sleep(1);
            object_hide(ai_get_object(this.ai_current_actor), true);
            cs_go_to(GetReference<ISpatialPoint>("intro_hog_targets/p1"));
        }

        [ScriptMethod(58, Lifecycle.CommandScript)]
        public async Task cs_hog_04()
        {
            cs_force_combat_status(3);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            object_set_velocity(ai_vehicle_get(this.ai_current_actor), 1F);
            cs_vehicle_speed(0.9F);
            ai_vehicle_enter_immediate(intro_hog_04.driver, ai_vehicle_get_from_starting_location(intro_hog_04.hog), "warthog_d");
            await sleep(1);
            object_hide(ai_get_object(this.ai_current_actor), true);
            cs_go_to(GetReference<ISpatialPoint>("intro_hog_targets/p1"));
        }

        [ScriptMethod(59, Lifecycle.Dormant)]
        public async Task intro_hogs()
        {
            await sleep(146);
            ai_place(intro_hog_01.Squad);
            ai_place(intro_hog_02.Squad);
            ai_place(intro_hog_03.Squad);
            ai_place(intro_hog_04.Squad);
            cs_run_command_script(intro_hog_01.driver, new ScriptMethodReference(cs_hog_01));
            cs_run_command_script(intro_hog_02.driver, new ScriptMethodReference(cs_hog_02));
            cs_run_command_script(intro_hog_03.driver, new ScriptMethodReference(cs_hog_03));
            cs_run_command_script(intro_hog_04.driver, new ScriptMethodReference(cs_hog_04));
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c03_intro_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_02_fol", 3837461317U), default(IGameObject), 1F);
            print("c03_intro foley 02 start");
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene2_01()
        {
            sound_class_set_gain("vehicle", 0F, 0);
            await sleep(144);
            sound_class_set_gain("vehicle", 0.25F, 0);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene2_03()
        {
            await sleep(145);
            sound_class_set_gain("vehicle", 0.25F, 15);
            sound_class_set_gain("vehicle", 0.5F, 120);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene2_04()
        {
            await sleep(280);
            sound_class_set_gain("vehicle", 0.25F, 10);
            sound_class_set_gain("vehicle", 0.5F, 75);
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene2_05()
        {
            await sleep(480);
            sound_class_set_gain("vehicle", 0.5F, 50);
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task c03_1060_cor()
        {
            await sleep(0);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1060_cor", 3837526854U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c03_1060_cor", 5F);
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task c03_1070_cor()
        {
            await sleep(150);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1070_cor", 3837592391U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c03_1070_cor", 3F);
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task c03_1080_mrs()
        {
            await sleep(290);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1080_mrs", 3837657928U), spotter.Entity, 1F, "radio_default_in");
            cinematic_subtitle("c03_1080_mrs", 4F);
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c03_1090_dp1()
        {
            await sleep(407);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1090_dp1", 3837723465U), default(IGameObject), 1F, "radio_default_out");
            cinematic_subtitle("c03_1090_dp1", 1F);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c03_intro_shake_02()
        {
            await sleep(350);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            player_effect_stop(1.5F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c03_intro_fov_01()
        {
            await sleep(232);
            camera_set_field_of_view(36F, 0);
            print("fov change: 50 -> 16 over 0 ticks");
            await sleep(13);
            camera_set_field_of_view(60F, 14);
            print("fov change: 16 -> 50 over 14 ticks");
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_02()
        {
            cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
            object_uses_cinematic_lighting(sniper.Entity, true);
            object_uses_cinematic_lighting(spotter.Entity, true);
            object_uses_cinematic_lighting(sniper_rifle.Entity, true);
            object_uses_cinematic_lighting(scope.Entity, true);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task white_flash()
        {
            await sleep(130);
            fade_out(1F, 1F, 1F, 15);
            await sleep(30);
            fade_in(1F, 1F, 1F, 15);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task erase_hogs()
        {
            time_code_reset();
            await sleep(279);
            print("erase hogs");
            ai_erase(intro_hog_01.Squad);
            ai_erase(intro_hog_02.Squad);
            ai_erase(intro_hog_03.Squad);
            ai_erase(intro_hog_04.Squad);
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task c03_intro_02_setup()
        {
            object_create_anew(sniper);
            object_create_anew(spotter);
            object_create_anew(sniper_rifle);
            object_create_anew(scope);
            object_cinematic_lod(sniper.Entity, true);
            object_cinematic_lod(spotter.Entity, true);
            object_cinematic_lod(sniper_rifle.Entity, true);
            object_cinematic_lod(scope.Entity, true);
            wake(new ScriptMethodReference(c03_intro_sound_scene2_01));
            wake(new ScriptMethodReference(c03_intro_sound_scene2_03));
            wake(new ScriptMethodReference(c03_intro_sound_scene2_04));
            wake(new ScriptMethodReference(c03_intro_sound_scene2_05));
            unit_set_emotional_state(sniper.Entity, "pensive", 0.5F, 0);
            unit_set_emotional_state(spotter.Entity, "pain", 0.5F, 0);
            wake(new ScriptMethodReference(c03_intro_foley_02));
            wake(new ScriptMethodReference(c03_1060_cor));
            wake(new ScriptMethodReference(c03_1070_cor));
            wake(new ScriptMethodReference(c03_1080_mrs));
            wake(new ScriptMethodReference(c03_1090_dp1));
            wake(new ScriptMethodReference(intro_hogs));
            wake(new ScriptMethodReference(erase_hogs));
            wake(new ScriptMethodReference(c03_intro_shake_02));
            wake(new ScriptMethodReference(c03_intro_fov_01));
            wake(new ScriptMethodReference(cinematic_lighting_scene_02));
            wake(new ScriptMethodReference(white_flash));
        }

        [ScriptMethod(75, Lifecycle.Static)]
        public async Task c03_intro_02_cleanup()
        {
            object_destroy(sniper.Entity);
            object_destroy(spotter.Entity);
            object_destroy(scope.Entity);
        }

        [ScriptMethod(76, Lifecycle.Static)]
        public async Task c03_intro_scene_02()
        {
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intro\\03_intro", 3834577689U), "03_intro_02", default(IUnit), anchor_flag_intro);
            await this.c03_intro_02_setup();
            pvs_set_object(pelican_01.Entity);
            custom_animation_relative(sniper.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "sniper_02", false, anchor_intro.Entity);
            custom_animation_relative(spotter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "spotter_02", false, anchor_intro.Entity);
            custom_animation_relative(pelican_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel1_02", false, anchor_intro.Entity);
            custom_animation_relative(pelican_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel2_02", false, anchor_intro.Entity);
            custom_animation_relative(pelican_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel3_02", false, anchor_intro.Entity);
            scenery_animation_start_relative(sniper_rifle.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\sniper_rifle\\03_intro\\03_intro", 3837789002U), "sniper_rifle_02", anchor_intro.Entity);
            scenery_animation_start_relative(scope.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\human\\military\\spotting_scope\\03_intro\\03_intro", 3837854539U), "scope_02", anchor_intro.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._03_intro_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_03_fol", 3837920076U));
            await sleep((short)camera_time());
            await this.c03_intro_02_cleanup();
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task c03_intro_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_03_fol", 3837920076U), default(IGameObject), 1F);
            print("c03_intro foley 03 start");
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene3_01()
        {
            await sleep(635);
            sound_class_set_gain("vehicle", 0F, 5);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene3_02()
        {
            await sleep(640);
            sound_class_set_gain("vehicle", 0.5F, 135);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task c03_intro_sound_scene3_03()
        {
            await sleep(805);
            object_set_function_variable(pelican_01.Entity, "turn_absolute", 1F, 75F);
            object_set_function_variable(pelican_02.Entity, "turn_absolute", 1F, 75F);
            object_set_function_variable(pelican_03.Entity, "turn_absolute", 1F, 75F);
            object_set_function_variable(pelican_01.Entity, "banking_audio", 1F, 75F);
            object_set_function_variable(pelican_02.Entity, "banking_audio", 1F, 75F);
            object_set_function_variable(pelican_03.Entity, "banking_audio", 1F, 75F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task c03_1100_dp1()
        {
            await sleep(5);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1100_dp1", 3837985613U), pilot.Entity, 1F);
            cinematic_subtitle("c03_1100_dp1", 1F);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task c03_1110_jon()
        {
            await sleep(63);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1110_jon", 3838051150U), johnson.Entity, 1F);
            cinematic_subtitle("c03_1110_jon", 1F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c03_1120_jon()
        {
            await sleep(135);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1120_jon", 3838116687U), johnson.Entity, 1F);
            cinematic_subtitle("c03_1120_jon", 2F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task c03_1130_lhd()
        {
            await sleep(190);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1130_lhd", 3838182224U), default(IGameObject), 1F, "radio_default_in");
            cinematic_subtitle("c03_1130_lhd", 4F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task c03_1140_lhd()
        {
            await sleep(314);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1140_lhd", 3838247761U), default(IGameObject), 1F, "radio_default_out");
            cinematic_subtitle("c03_1140_lhd", 5F);
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task c03_1150_dp2()
        {
            await sleep(490);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1150_dp2", 3838313298U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c03_1150_dp2", 1F);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task c03_intro_shake_03()
        {
            await sleep(0);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            await sleep(405);
            player_effect_stop(0F);
            print("shake stop");
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task c03_intro_03_dof_1()
        {
            await sleep(96);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 0F, 1F, 1F, 0F);
            print("rack focus");
            await sleep(83);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task c03_intro_03_dof_2()
        {
            await sleep(319);
            print("dof values: 3 0 0 0 1 1 0");
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(3F, 0F, 0F, 0F, 1F, 1F, 0F);
            await sleep(85);
            print("dof values: 9 2.5 2.5 0 0 0 0");
            cinematic_screen_effect_set_depth_of_field(9F, 2.5F, 2.5F, 0F, 0F, 0F, 0F);
            await sleep(116);
            print("dof stop");
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_03()
        {
            cinematic_lighting_set_primary_light(29F, 116F, 0.478431F, 0.415686F, 0.329412F);
            cinematic_lighting_set_secondary_light(20F, 272F, 0.235294F, 0.235294F, 0.384314F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(odst_01.Entity, true);
            object_uses_cinematic_lighting(odst_02.Entity, true);
            object_uses_cinematic_lighting(odst_03.Entity, true);
            object_uses_cinematic_lighting(odst_04.Entity, true);
            object_uses_cinematic_lighting(helmet.Entity, true);
            object_uses_cinematic_lighting(battle_rifle_01.Entity, true);
            object_uses_cinematic_lighting(battle_rifle_02.Entity, true);
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task cinematic_light_troopbay_03_01()
        {
            await sleep(178);
            print("light bay");
            object_hide(odst_01.Entity, false);
            object_hide(odst_02.Entity, false);
            object_hide(odst_03.Entity, false);
            cinematic_lighting_set_primary_light(4F, 278F, 0.54902F, 0.478431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-34F, 154F, 0.14902F, 0.141176F, 0.180392F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task cinematic_light_chief_03_01()
        {
            await sleep(318);
            print("light chief rev");
            object_hide(chief.Entity, false);
            object_hide(odst_04.Entity, false);
            cinematic_lighting_set_primary_light(4F, 240F, 0.54902F, 0.478431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-34F, 154F, 0.145098F, 0.141176F, 0.184314F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task cinematic_light_street_03_01()
        {
            await sleep(403);
            print("light street");
            cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task save_dof_01()
        {
            await sleep(318);
            print("delete marines, hide pelican");
            object_destroy(odst_01.Entity);
            object_destroy(odst_02.Entity);
            object_destroy(odst_03.Entity);
            object_destroy(battle_rifle_01.Entity);
            object_destroy(battle_rifle_02.Entity);
            object_destroy(sniper_rifle.Entity);
            object_hide(pelican_03.Entity, true);
            object_hide(offending_palm_01.Entity, true);
            object_hide(offending_palm_02.Entity, true);
            object_hide(offending_palm_03.Entity, true);
            object_hide(offending_palm_04.Entity, true);
            object_hide(offending_palm_05.Entity, true);
            object_hide(offending_palm_06.Entity, true);
            object_hide(offending_palm_07.Entity, true);
            object_hide(offending_palm_08.Entity, true);
            object_hide(offending_palm_09.Entity, true);
            object_hide(offending_palm_10.Entity, true);
            object_hide(offending_palm_11.Entity, true);
            object_hide(offending_palm_12.Entity, true);
            object_hide(offending_palm_13.Entity, true);
            object_hide(offending_palm_14.Entity, true);
            object_hide(offending_palm_15.Entity, true);
            object_hide(offending_palm_16.Entity, true);
            object_hide(offending_palm_17.Entity, true);
            object_hide(offending_palm_18.Entity, true);
            object_hide(offending_palm_19.Entity, true);
            object_hide(offending_palm_20.Entity, true);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task show_trees_pelican()
        {
            await sleep(405);
            print("show trees, pelican");
            object_hide(pelican_03.Entity, false);
            object_hide(offending_palm_01.Entity, false);
            object_hide(offending_palm_02.Entity, false);
            object_hide(offending_palm_03.Entity, false);
            object_hide(offending_palm_04.Entity, false);
            object_hide(offending_palm_05.Entity, false);
            object_hide(offending_palm_06.Entity, false);
            object_hide(offending_palm_07.Entity, false);
            object_hide(offending_palm_08.Entity, false);
            object_hide(offending_palm_09.Entity, false);
            object_hide(offending_palm_10.Entity, false);
            object_hide(offending_palm_11.Entity, false);
            object_hide(offending_palm_12.Entity, false);
            object_hide(offending_palm_13.Entity, false);
            object_hide(offending_palm_14.Entity, false);
            object_hide(offending_palm_15.Entity, false);
            object_hide(offending_palm_16.Entity, false);
            object_hide(offending_palm_17.Entity, false);
            object_hide(offending_palm_18.Entity, false);
            object_hide(offending_palm_19.Entity, false);
            object_hide(offending_palm_20.Entity, false);
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task c03_intro_03_setup()
        {
            object_create_anew(odst_01);
            object_create_anew(odst_02);
            object_create_anew(odst_03);
            object_create_anew(odst_04);
            object_create_anew(helmet);
            object_create_anew(battle_rifle_01);
            object_create_anew(battle_rifle_02);
            object_cinematic_lod(odst_01.Entity, true);
            object_cinematic_lod(odst_02.Entity, true);
            object_cinematic_lod(odst_03.Entity, true);
            object_cinematic_lod(odst_04.Entity, true);
            object_cinematic_lod(helmet.Entity, true);
            object_cinematic_lod(battle_rifle_01.Entity, true);
            object_cinematic_lod(battle_rifle_02.Entity, true);
            object_hide(odst_01.Entity, true);
            object_hide(odst_02.Entity, true);
            object_hide(odst_03.Entity, true);
            object_hide(odst_04.Entity, true);
            object_set_permutation(odst_01.Entity, "head", "morgan");
            object_set_permutation(odst_02.Entity, "head", "perez");
            object_set_permutation(odst_03.Entity, "head", "walter");
            object_set_permutation(odst_04.Entity, "head", "banks");
            unit_set_emotional_state(odst_01.Entity, "angry", 0.25F, 0);
            unit_set_emotional_state(odst_02.Entity, "angry", 0.25F, 0);
            unit_set_emotional_state(odst_03.Entity, "angry", 0.25F, 0);
            unit_set_emotional_state(odst_04.Entity, "angry", 0.25F, 0);
            object_set_region_state(odst_03.Entity, "helmet", destroyed);
            object_set_region_state(odst_04.Entity, "helmet", destroyed);
            objects_attach(odst_01.Entity, "right hand", battle_rifle_01.Entity, "");
            objects_attach(odst_02.Entity, "right hand", battle_rifle_02.Entity, "");
            wake(new ScriptMethodReference(c03_intro_foley_03));
            wake(new ScriptMethodReference(c03_intro_sound_scene3_01));
            wake(new ScriptMethodReference(c03_intro_sound_scene3_02));
            wake(new ScriptMethodReference(c03_intro_sound_scene3_03));
            wake(new ScriptMethodReference(c03_1100_dp1));
            wake(new ScriptMethodReference(c03_1110_jon));
            wake(new ScriptMethodReference(c03_1120_jon));
            wake(new ScriptMethodReference(c03_1130_lhd));
            wake(new ScriptMethodReference(c03_1140_lhd));
            wake(new ScriptMethodReference(c03_1150_dp2));
            wake(new ScriptMethodReference(save_dof_01));
            wake(new ScriptMethodReference(show_trees_pelican));
            wake(new ScriptMethodReference(c03_intro_shake_03));
            wake(new ScriptMethodReference(cinematic_lighting_scene_03));
            wake(new ScriptMethodReference(cinematic_light_troopbay_03_01));
            wake(new ScriptMethodReference(cinematic_light_chief_03_01));
            wake(new ScriptMethodReference(cinematic_light_street_03_01));
        }

        [ScriptMethod(97, Lifecycle.Static)]
        public async Task c03_intro_03_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(johnson.Entity);
            object_destroy_containing("odst");
            object_destroy(helmet.Entity);
            object_destroy(battle_rifle_01.Entity);
            object_destroy(battle_rifle_02.Entity);
            object_destroy(sniper_rifle.Entity);
            object_destroy(magazine.Entity);
        }

        [ScriptMethod(98, Lifecycle.Static)]
        public async Task c03_intro_scene_03()
        {
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intro\\03_intro", 3834577689U), "03_intro_03", default(IUnit), anchor_flag_intro);
            await this.c03_intro_03_setup();
            pvs_set_object(pelican_01.Entity);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intro\\03_intro", 3834643226U), "mc_03", false, anchor_intro.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "johnson_03", false, anchor_intro.Entity);
            custom_animation_relative(pilot.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "marine1_03", false, anchor_intro.Entity);
            custom_animation_relative(copilot.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "marine2_03", false, anchor_intro.Entity);
            custom_animation_relative(odst_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "odst1_03", false, anchor_intro.Entity);
            custom_animation_relative(odst_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "odst2_03", false, anchor_intro.Entity);
            custom_animation_relative(odst_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "odst3_03", false, anchor_intro.Entity);
            custom_animation_relative(odst_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "odst4_03", false, anchor_intro.Entity);
            custom_animation_relative(pelican_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel1_03", false, anchor_intro.Entity);
            custom_animation_relative(pelican_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel2_03", false, anchor_intro.Entity);
            custom_animation_relative(pelican_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel3_03", false, anchor_intro.Entity);
            scenery_animation_start_relative(helmet.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\helmet_odst\\03_intro\\03_intro", 3838378835U), "helmet_03", anchor_intro.Entity);
            scenery_animation_start_relative(sniper_rifle.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\sniper_rifle\\03_intro\\03_intro", 3837789002U), "sniper_rifle_03", anchor_intro.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._03_intro_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_04_fol", 3838444372U));
            await sleep((short)camera_time());
            await this.c03_intro_03_cleanup();
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task intro_scarab_gun_charge()
        {
            await sleep(200);
            print("scarab gun charge");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_beam_charging", 3838509909U), scarab.Entity, "primary_trigger");
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task intro_scarab_gun_fire()
        {
            object_create(intro_scarab_gun);
            objects_attach(scarab.Entity, "primary_trigger", intro_scarab_gun.Entity, "");
            await sleep(240);
            print("scarab gun fire");
            object_hide(intro_scarab_gun.Entity, true);
            weapon_hold_trigger(GetReference<IWeaponReference>("intro_scarab_gun"), 0, true);
            await sleep(120);
            weapon_hold_trigger(GetReference<IWeaponReference>("intro_scarab_gun"), 0, false);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task intro_scarab_turret_fire()
        {
            object_create(intro_scarab_gun_turret);
            objects_attach(scarab_turret.Entity, "primary_trigger", intro_scarab_gun_turret.Entity, "");
            object_hide(intro_scarab_gun_turret.Entity, true);
            await sleep(285);
            print("scarab turret fire");
            weapon_hold_trigger(GetReference<IWeaponReference>("intro_scarab_gun_turret"), 0, true);
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task effect_pelican_hit_01()
        {
            await sleep(265);
            print("pelican hit");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit", 3838903131U), pelican_01.Entity, "johnson");
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task effect_pelican_impact_01()
        {
            await sleep(410);
            print("pelican impact 1");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit_small", 3840082797U), pelican_03.Entity, "light_cockpit_back");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit_small", 3840082797U), pelican_03.Entity, "hardpoint_left");
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task effect_pelican_impact_02()
        {
            await sleep(434);
            print("pelican impact 2");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit", 3838903131U), pelican_03.Entity, "johnson");
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3840148334U), intro_junction_flag_01);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task effect_blow_railings()
        {
            await sleep(450);
            print("blow railings far");
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3840148334U), intro_railing_flag_01);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3840148334U), intro_railing_flag_02);
            await sleep(5);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3840148334U), intro_railing_flag_03);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3840148334U), intro_railing_flag_04);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task c03_intro_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_04_fol", 3838444372U), default(IGameObject), 1F);
            print("c03_intro foley 04 start");
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task c03_1160_dp2()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_1160_dp2", 3840213871U), pilot.Entity, 1F);
            cinematic_subtitle("c03_1160_dp2", 2F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task c03_intro_fov_02()
        {
            await sleep(382);
            camera_set_field_of_view(30F, 0);
            print("fov change: 50 -> 20 over 0 ticks");
            await sleep(18);
            camera_set_field_of_view(60F, 20);
            print("fov change: 20 -> 50 over 20 ticks");
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task c03_intro_shake_04()
        {
            await sleep(137);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.5F, 0F);
            player_effect_stop(1F);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task c03_intro_04_dof_1()
        {
            await sleep(58);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(2F, 1F, 1F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(59);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task c03_intro_04_dof_3()
        {
            await sleep(382);
            print("dof stop");
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_04()
        {
            cinematic_lighting_set_primary_light(29F, 116F, 0.478431F, 0.415686F, 0.329412F);
            cinematic_lighting_set_secondary_light(20F, 272F, 0.235294F, 0.235294F, 0.384314F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task cinematic_light_street_04_01()
        {
            await sleep(117);
            print("light street");
            cinematic_lighting_set_primary_light(43F, 122F, 0.54902F, 0.478431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-25F, 98F, 0.317647F, 0.313726F, 0.396078F);
            cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.101961F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task effect_big_foot()
        {
            time_code_reset();
            await sleep(126);
            print("big foot");
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3840148334U), bus_flag_01);
            damage_new(GetTag<DamageEffectTag>("objects\\weapons\\grenade\\frag_grenade\\damage_effects\\frag_grenade_explosion", 3840148334U), bus_flag_02);
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task c03_intro_04_setup()
        {
            object_create_anew(scarab);
            object_create_anew(scarab_turret);
            object_create_anew_containing("intro_railing");
            object_create_anew_containing("intro_crash");
            object_create_anew(the_fiscal_year);
            object_cinematic_lod(scarab.Entity, true);
            object_cinematic_lod(scarab_turret.Entity, true);
            object_cinematic_lod(the_fiscal_year.Entity, true);
            object_uses_cinematic_lighting(scarab.Entity, true);
            object_uses_cinematic_lighting(scarab_turret.Entity, true);
            wake(new ScriptMethodReference(c03_intro_foley_04));
            wake(new ScriptMethodReference(c03_1160_dp2));
            wake(new ScriptMethodReference(c03_intro_fov_02));
            wake(new ScriptMethodReference(c03_intro_shake_04));
            wake(new ScriptMethodReference(intro_scarab_gun_charge));
            wake(new ScriptMethodReference(intro_scarab_gun_fire));
            wake(new ScriptMethodReference(intro_scarab_turret_fire));
            wake(new ScriptMethodReference(effect_big_foot));
            wake(new ScriptMethodReference(effect_pelican_hit_01));
            wake(new ScriptMethodReference(effect_pelican_impact_01));
            wake(new ScriptMethodReference(effect_pelican_impact_02));
            wake(new ScriptMethodReference(effect_blow_railings));
            wake(new ScriptMethodReference(cinematic_lighting_scene_04));
            wake(new ScriptMethodReference(cinematic_light_street_04_01));
        }

        [ScriptMethod(116, Lifecycle.Static)]
        public async Task c03_intro_04_cleanup()
        {
            object_destroy(pilot.Entity);
            object_destroy(copilot.Entity);
            object_destroy_containing("scarab");
            object_destroy_containing("pelican");
            object_destroy(the_fiscal_year.Entity);
        }

        [ScriptMethod(117, Lifecycle.Static)]
        public async Task c03_intro_scene_04()
        {
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intro\\03_intro", 3834577689U), "03_intro_04", default(IUnit), anchor_flag_intro);
            await this.c03_intro_04_setup();
            pvs_set_object(pelican_01.Entity);
            custom_animation_relative(pilot.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "marine1_04", false, anchor_intro.Entity);
            custom_animation_relative(copilot.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intro\\03_intro", 3834708763U), "marine2_04", false, anchor_intro.Entity);
            custom_animation_relative(pelican_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel1_04", false, anchor_intro.Entity);
            custom_animation_relative(pelican_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel2_04", false, anchor_intro.Entity);
            custom_animation_relative(pelican_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intro\\03_intro", 3837264706U), "pel3_04", false, anchor_intro.Entity);
            scenery_animation_start_relative(scarab.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\03_intro\\03_intro", 3840279408U), "scarab_04", anchor_intro.Entity);
            scenery_animation_start_relative(scarab_turret.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\03_intro\\03_intro", 3840344945U), "scarab_upper_gun_04", anchor_intro.Entity);
            await sleep((short)((float)camera_time() - 60));
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.5F, 2F);
            await sleep((short)((float)camera_time() - 5));
            print("cut to black");
            fade_out(0F, 0F, 0F, 5);
            await sleep(5);
            await this.c03_intro_04_cleanup();
            await sleep(30);
            player_effect_stop(0F);
        }

        [ScriptMethod(118, Lifecycle.Static)]
        public async Task c03_intro()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("earthcity_cine_intro_bsp"));
            await sleep(1);
            await this.c03_intro_scene_01();
            await this.c03_intro_scene_02();
            await this.c03_intro_scene_03();
            await this.c03_intro_scene_04();
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(119, Lifecycle.Static)]
        public async Task chief_recovery_sequence()
        {
            camera_control(false);
            player_camera_control(true);
            if (GameDifficulty.Easy() == game_difficulty_get_real())
            {
                print("recovery - easy");
                fade_out(0F, 0F, 0F, 0);
                cinematic_start();
                cinematic_show_letterbox_immediate(true);
                interpolator_start("blurry_vision", 1F, 0.001F);
                await sleep(30);
                fade_in(0F, 0F, 0F, 30);
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\mission\\l03_9000_cor", 3840410482U), default(IGameObject), 1F);
                await sleep(35);
                fade_out(0F, 0F, 0F, 30);
                await sleep(45);
                fade_in(0F, 0F, 0F, 20);
                await sleep(25);
                fade_out(0F, 0F, 0F, 15);
                await sleep(20);
                fade_in(0F, 0F, 0F, 15);
                player_enable_input(false);
                cinematic_stop();
                cinematic_show_letterbox_immediate(true);
                interpolator_start("blurry_vision", 0F, 3F);
                await sleep(30);
                player_enable_input(true);
            }

            if (GameDifficulty.Normal() == game_difficulty_get_real())
            {
                print("recovery - normal");
                fade_out(0F, 0F, 0F, 0);
                cinematic_start();
                cinematic_show_letterbox_immediate(true);
                interpolator_start("blurry_vision", 1F, 0.001F);
                await sleep(30);
                fade_in(0F, 0F, 0F, 30);
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\mission\\l03_9030_cor", 3840476019U), default(IGameObject), 1F);
                await sleep(35);
                fade_out(0F, 0F, 0F, 30);
                await sleep(45);
                fade_in(0F, 0F, 0F, 20);
                await sleep(25);
                fade_out(0F, 0F, 0F, 15);
                await sleep(20);
                fade_in(0F, 0F, 0F, 15);
                player_enable_input(false);
                cinematic_stop();
                cinematic_show_letterbox_immediate(true);
                interpolator_start("blurry_vision", 0F, 3F);
                await sleep(30);
                player_enable_input(true);
            }

            if (GameDifficulty.Heroic() == game_difficulty_get_real())
            {
                print("recovery - heroic");
                fade_out(0F, 0F, 0F, 0);
                cinematic_start();
                cinematic_show_letterbox_immediate(true);
                interpolator_start("blurry_vision", 1F, 0.001F);
                await sleep(30);
                fade_in(0F, 0F, 0F, 30);
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\mission\\l03_9020_cor", 3840541556U), default(IGameObject), 1F);
                await sleep(35);
                fade_out(0F, 0F, 0F, 30);
                await sleep(45);
                fade_in(0F, 0F, 0F, 20);
                await sleep(25);
                fade_out(0F, 0F, 0F, 15);
                await sleep(20);
                fade_in(0F, 0F, 0F, 15);
                player_enable_input(false);
                cinematic_stop();
                cinematic_show_letterbox_immediate(true);
                interpolator_start("blurry_vision", 0F, 3F);
                await sleep(30);
                player_enable_input(true);
            }

            if (GameDifficulty.Legendary() == game_difficulty_get_real())
            {
                print("recovery - legendary");
                fade_out(0F, 0F, 0F, 0);
                cinematic_start();
                cinematic_show_letterbox_immediate(true);
                interpolator_start("blurry_vision", 1F, 0.001F);
                await sleep(30);
                fade_in(0F, 0F, 0F, 30);
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\mission\\l03_9010_cor", 3840607093U), default(IGameObject), 1F);
                await sleep(35);
                fade_out(0F, 0F, 0F, 30);
                await sleep(45);
                fade_in(0F, 0F, 0F, 20);
                await sleep(25);
                fade_out(0F, 0F, 0F, 15);
                await sleep(20);
                fade_in(0F, 0F, 0F, 15);
                player_enable_input(false);
                cinematic_stop();
                cinematic_show_letterbox_immediate(true);
                interpolator_start("blurry_vision", 0F, 3F);
                await sleep(30);
                player_enable_input(true);
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
            await sleep(30);
            cinematic_set_title(title0);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
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

        [ScriptMethod(123, Lifecycle.Dormant)]
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

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task objective0_set()
        {
            await sleep(30);
            objectives_show_up_to(0);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task objective0_clear()
        {
            objectives_finish_up_to(0);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task objective1_set()
        {
            await sleep(30);
            objectives_show_up_to(1);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task objective1_clear()
        {
            objectives_finish_up_to(1);
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task objective2_set()
        {
            await sleep(30);
            objectives_show_up_to(2);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task objective2_clear()
        {
            objectives_finish_up_to(2);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task objective3_set()
        {
            await sleep(30);
            objectives_show_up_to(3);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task objective3_clear()
        {
            objectives_finish_up_to(3);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task objective4_set()
        {
            await sleep(30);
            objectives_show_up_to(4);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task objective4_clear()
        {
            objectives_finish_up_to(4);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task music_03a_01_start()
        {
            print("music 03a_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_01", 4264762368U), default(IGameObject), 1F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task music_03a_01_stop()
        {
            print("music 03a_01 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_01", 4264762368U));
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task music_03a_02_stop_alt()
        {
            await sleep(this.two_minutes);
            print("music 03a_02 stop alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_02", 4264958979U), false);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task music_03a_02_stop()
        {
            await sleep(this.one_minute);
            print("music 03a_02 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_02", 4264958979U));
            sleep_forever(new ScriptMethodReference(music_03a_02_stop_alt));
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task music_03a_02_start_alt()
        {
            print("music 03a_02 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_02", 4264958979U), true);
            wake(new ScriptMethodReference(music_03a_02_stop_alt));
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task music_03a_02_start()
        {
            print("music 03a_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_02", 4264958979U), default(IGameObject), 1F);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task music_03a_03_start()
        {
            print("music 03a_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_03", 4265352201U), default(IGameObject), 1F);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task music_03a_03_stop()
        {
            print("music 03a_03 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_03", 4265352201U));
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task music_03a_04_start()
        {
            print("music 03a_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_04", 4265614349U), default(IGameObject), 1F);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task music_03a_04_stop()
        {
            print("music 03a_04 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_04", 4265614349U));
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task music_03a_05_start()
        {
            await sleep(60);
            print("music 03a_05 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_05", 4265810960U), default(IGameObject), 1F);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task music_03a_05_stop()
        {
            print("music 03a_05 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_05", 4265810960U));
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task music_03a_06_start()
        {
            print("music 03a_06 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_06", 4266073108U), default(IGameObject), 1F);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task music_03a_06_stop()
        {
            print("music 03a_06 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_06", 4266073108U));
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task music_03a_065_start()
        {
            print("music 03a_065 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_065", 4266269719U), default(IGameObject), 1F);
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task music_03a_065_stop()
        {
            await sleep(this.two_minutes);
            print("music 03a_065 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_065", 4266269719U));
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task music_03a_065_start_alt()
        {
            print("music 03a_065 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_065", 4266269719U), true);
            wake(new ScriptMethodReference(music_03a_065_stop));
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task music_03a_066_start()
        {
            print("music 03a_066 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_066", 4266597404U), default(IGameObject), 1F);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task music_03a_067_start()
        {
            print("music 03a_067 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_067", 4266728478U), default(IGameObject), 1F);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task music_03a_067_stop()
        {
            print("music 03a_067 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_067", 4266728478U));
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task music_03a_07_start()
        {
            print("music 03a_07 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_07", 4266925089U), default(IGameObject), 1F);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task music_03a_07_stop()
        {
            print("music 03a_07 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03a_oldmombasa\\03a_music\\03a_07", 4266925089U));
        }

        [ScriptMethod(156, Lifecycle.Static)]
        public async Task<bool> player_in_vehicle()
        {
            return unit_in_vehicle(unit(await this.player0())) || (bool)game_is_cooperative() && unit_in_vehicle(unit(await this.player1()));
        }

        [ScriptMethod(157, Lifecycle.Static)]
        public async Task<bool> players_in_vehicle()
        {
            return unit_in_vehicle(unit(await this.player0())) && !((bool)game_is_cooperative()) || unit_in_vehicle(unit(await this.player1()));
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task flashlight_control()
        {
            await sleep_until(async () =>
            {
                if ((short)structure_bsp_index() == 2 || volume_test_objects(tv_dark_area0, players()) || volume_test_objects(tv_dark_area1, players()) || volume_test_objects(tv_dark_area2, players()) || volume_test_objects(tv_dark_area3, players()))
                {
                    game_can_use_flashlights(true);
                    weapon_enable_warthog_chaingun_light(true);
                }
                else
                {
                    game_can_use_flashlights(false);
                    weapon_enable_warthog_chaingun_light(false);
                }

                return false;
            }, 60);
        }

        [ScriptMethod(159, Lifecycle.CommandScript)]
        public async Task cs_e13_mars_continue()
        {
            cs_go_to(GetReference<ISpatialPoint>("e13_mars_exit/p0"));
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("e13_mars_exit/p1"));
            cs_ignore_obstacles(false);
            cs_go_to(GetReference<ISpatialPoint>("e13_mars_exit/p2"));
        }

        [ScriptMethod(160, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_unload()
        {
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_sc01");
            ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(161, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_end0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/first_end"));
            cs_face(true, GetReference<ISpatialPoint>("e13_cov_creep0_chase/end_facing"));
            await sleep(150);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_unload));
        }

        [ScriptMethod(162, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_end1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/second_end"));
            cs_face(true, GetReference<ISpatialPoint>("e13_cov_creep0_chase/end_facing"));
            await sleep(150);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_unload));
        }

        [ScriptMethod(163, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_end2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/third_end"));
            cs_face(true, GetReference<ISpatialPoint>("e13_cov_creep0_chase/end_facing"));
            await sleep(150);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_unload));
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_drive1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p11"));
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/end"));
            if (this.g_e13_creep_end0_free == true)
            {
                cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_end0));
                this.g_e13_creep_end0_free = false;
            }
            else if (this.g_e13_creep_end1_free == true)
            {
                cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_end1));
                this.g_e13_creep_end1_free = false;
            }
            else if (this.g_e13_creep_end2_free == true)
            {
                cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_end2));
                this.g_e13_creep_end2_free = false;
            }
        }

        [ScriptMethod(165, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_drive0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p2"), 1F);
            cs_ignore_obstacles(false);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p2_0"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p3"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p4"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p5"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p5_1"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p6"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p7"), 0.5F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p8"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p9_0"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p9_1"), 1F);
            cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_chase/p10"), 1F);
        }

        [ScriptMethod(166, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_0_decision()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            if ((short)ai_living_count(e13_cov_creep0_1.creep0) <= 0 && (short)ai_living_count(e13_cov_creep0_2.creep0) <= 0)
            {
                cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_drive1));
                ai_set_orders(this.ai_current_squad, e13_cov_creep0_defend);
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_0_mid"));
                cs_vehicle_boost(false);
                cs_face(true, GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_0_mid_facing"));
                await sleep(60);
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_p_l01");
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_p_r01");
                await sleep(60);
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_sc01");
                ai_vehicle_exit(this.ai_current_actor);
                await sleep(30);
                ai_vehicle_enter(this.ai_current_actor, ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost0));
            }
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_1_decision()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            if ((short)ai_living_count(e13_cov_creep0_0.creep0) <= 0 && (short)ai_living_count(e13_cov_creep0_2.creep0) <= 0)
            {
                cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_drive1));
                ai_set_orders(this.ai_current_squad, e13_cov_creep0_defend);
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_1_mid"));
                cs_vehicle_boost(false);
                cs_face(true, GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_1_mid_facing"));
                await sleep(60);
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_p_l01");
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_p_r01");
                await sleep(60);
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_sc01");
                ai_vehicle_exit(this.ai_current_actor);
                await sleep(30);
                ai_vehicle_enter(this.ai_current_actor, ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost1));
            }
        }

        [ScriptMethod(168, Lifecycle.CommandScript)]
        public async Task cs_e13_cov_creep0_2_decision()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            if ((short)ai_living_count(e13_cov_creep0_0.creep0) > 0 && (short)ai_living_count(e13_cov_creep0_1.creep0) > 0)
            {
                cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e13_cov_creep0_drive1));
                ai_set_orders(this.ai_current_squad, e13_cov_creep0_defend);
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_2_mid"));
                cs_vehicle_boost(false);
                cs_face(true, GetReference<ISpatialPoint>("e13_cov_creep0_mid/creep0_2_mid_facing"));
                await sleep(60);
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_p_l01");
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_p_r01");
                await sleep(60);
                vehicle_unload(ai_vehicle_get(this.ai_current_actor), "creep_sc01");
                ai_vehicle_exit(this.ai_current_actor);
                await sleep(30);
                ai_vehicle_enter(this.ai_current_actor, ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost2));
            }
        }

        [ScriptMethod(169, Lifecycle.CommandScript)]
        public async Task cs_e13_mars_warthog0_drive()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_alert(true);
            cs_go_by(GetReference<ISpatialPoint>("e13_mars_warthog1_ketchup/p0"), GetReference<ISpatialPoint>("e13_mars_warthog1_ketchup/p1"));
        }

        [ScriptMethod(170, Lifecycle.Static)]
        public async Task<bool> e13_end_clear()
        {
            return !(volume_test_objects(tv_e13_end_area, ai_actors(e13_cov)));
        }

        [ScriptMethod(171, Lifecycle.Static)]
        public async Task<bool> e13_waypoint1_clear()
        {
            return !(volume_test_objects(tv_e13_waypoint1, ai_actors(e13_cov)));
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task<bool> e13_waypoint1()
        {
            return volume_test_objects(tv_e13_waypoint1, ai_actors(this.ai_current_squad));
        }

        [ScriptMethod(173, Lifecycle.Static)]
        public async Task<bool> e13_waypoint0()
        {
            return volume_test_objects(tv_e13_waypoint0, ai_actors(this.ai_current_squad));
        }

        [ScriptMethod(174, Lifecycle.Static)]
        public async Task e13_mars_exit()
        {
            cs_run_command_script(this.ai_current_squad, new ScriptMethodReference(cs_e13_mars_continue));
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task e13_navpoints()
        {
            activate_team_nav_point_object(_default, player, ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0), 1.5F);
            await sleep_until(async () => unit_get_health(ai_get_unit(e13_cov_creep0_0.creep0)) <= 0F || objects_distance_to_object(players(), ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0)) < objects_distance_to_object(players(), ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0)) || volume_test_objects(tv_e13_waypoint1, players()));
            deactivate_team_nav_point_object(player, ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0));
            activate_team_nav_point_object(_default, player, ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0), 1.5F);
            await sleep_until(async () => unit_get_health(ai_get_unit(e13_cov_creep0_1.creep0)) <= 0F || objects_distance_to_object(players(), ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0)) < objects_distance_to_object(players(), ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0)) || volume_test_objects(tv_e13_waypoint1, players()));
            deactivate_team_nav_point_object(player, ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0));
            activate_team_nav_point_object(_default, player, ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0), 1.5F);
            await sleep_until(async () => unit_get_health(ai_get_unit(e13_cov_creep0_2.creep0)) <= 0F || volume_test_objects(tv_e13_waypoint1, players()));
            deactivate_team_nav_point_object(player, ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0));
            if (unit_get_health(ai_get_unit(e13_cov_creep0_3.creep0)) > 0F)
            {
                activate_team_nav_point_object(_default, player, ai_vehicle_get_from_starting_location(e13_cov_creep0_3.creep0), 1.5F);
                await sleep_until(async () => unit_get_health(ai_get_unit(e13_cov_creep0_3.creep0)) <= 0F || volume_test_objects(tv_e13_end_entrance, players()));
            }

            deactivate_team_nav_point_object(player, ai_vehicle_get_from_starting_location(e13_cov_creep0_3.creep0));
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task e13_cov_ghosts1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e13_cov_creep0_6_begin, players()), 15);
            ai_place(e13_cov_ghosts1.Squad);
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task e13_cov_creep0_ghost_aux()
        {
            await sleep_until(async () => volume_test_objects(tv_e13_creep0_begin, players()), 15);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0), "creep_sc01", ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost0));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0), "creep_sc01", ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost1));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0), "creep_sc01", ai_vehicle_get_from_starting_location(e13_cov_ghosts0.ghost2));
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e13_cov_creep0_0.creep0) <= 0)
                {
                    vehicle_unload(ai_vehicle_get_from_starting_location(e13_cov_creep0_0.creep0), "creep_sc01");
                }

                if ((short)ai_living_count(e13_cov_creep0_1.creep0) <= 0)
                {
                    vehicle_unload(ai_vehicle_get_from_starting_location(e13_cov_creep0_1.creep0), "creep_sc01");
                }

                if ((short)ai_living_count(e13_cov_creep0_2.creep0) <= 0)
                {
                    vehicle_unload(ai_vehicle_get_from_starting_location(e13_cov_creep0_2.creep0), "creep_sc01");
                }

                return false;
            }, 60);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task e13_cov_creep0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e13_creep0_begin, players()));
            wake(new ScriptMethodReference(music_03a_067_stop));
            wake(new ScriptMethodReference(music_03a_07_start));
            ai_place(e13_cov_ghosts0.Squad);
            ai_place(e13_cov_creep0_0.Squad);
            ai_place(e13_cov_creep0_1.Squad);
            ai_place(e13_cov_creep0_2.Squad);
            await sleep(2);
            wake(new ScriptMethodReference(e13_cov_creep0_ghost_aux));
            cs_queue_command_script(e13_cov_creep0_0.creep0, new ScriptMethodReference(cs_e13_cov_creep0_0_decision));
            cs_queue_command_script(e13_cov_creep0_1.creep0, new ScriptMethodReference(cs_e13_cov_creep0_1_decision));
            cs_queue_command_script(e13_cov_creep0_2.creep0, new ScriptMethodReference(cs_e13_cov_creep0_2_decision));
            await sleep_until(async () => volume_test_objects(tv_e13_dialog, players()));
            await sleep(ai_play_line_on_object(default(IGameObject), "0590"));
            await sleep_until(async () => volume_test_objects(tv_e13_cov_creep0_reins0, players()), 15);
            game_save();
            if ((short)ai_living_count(e13_cov_creep0_0.creep0) <= 0 || (short)ai_living_count(e13_cov_creep0_1.creep0) <= 0 || (short)ai_living_count(e13_cov_creep0_2.creep0) <= 0)
            {
                ai_place(e13_cov_creep0_3.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_e13_cov_creep0_6_begin, players()), 15);
            wake(new ScriptMethodReference(music_03a_07_stop));
            game_save();
            ai_place(e13_cov_creep0_6.Squad);
            await sleep(30);
            object_dynamic_simulation_disable(ai_vehicle_get_from_starting_location(e13_cov_creep0_6.creep0), true);
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task e13_mars_warthog0_main()
        {
            ai_migrate(e12_mars_warthog0.Squad, e13_mars_warthog0.Squad);
            ai_migrate(e12_mars_warthog1.Squad, e13_mars_warthog0.Squad);
            ai_disposable(e13_mars_warthog0.Squad, false);
            ai_renew(e13_mars_warthog0.Squad);
            cs_run_command_script(e13_mars_warthog0.Squad, new ScriptMethodReference(cs_e13_mars_warthog0_drive));
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task e13_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e13_main_begin, players()), 10);
            this.g_e13_started = true;
            print("e13_main");
            data_mine_set_mission_segment("e13_tunnel_convoy");
            game_save();
            wake(new ScriptMethodReference(e13_mars_warthog0_main));
            wake(new ScriptMethodReference(e13_cov_creep0_main));
            wake(new ScriptMethodReference(e13_cov_ghosts1_main));
        }

        [ScriptMethod(181, Lifecycle.Static)]
        public async Task test_tunnel_convoy()
        {
            switch_bsp(2);
            object_teleport(await this.player0(), e13_test);
            ai_place(e13_mars_warthog0.Squad);
            if (!(this.g_e13_started))
            {
                wake(new ScriptMethodReference(e13_main));
            }
        }

        [ScriptMethod(182, Lifecycle.CommandScript)]
        public async Task cs_e12_mars_horrible_cleanup()
        {
            if (objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 50F && !(unit_in_vehicle(ai_get_unit(this.ai_current_actor))))
            {
                ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(183, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_ghost_drop()
        {
            ai_vehicle_reserve(ai_vehicle_get(this.ai_current_actor), true);
            ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(184, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_0_ghost0()
        {
            await sleep_until(async () => (short)ai_combat_status(e12_cov_inf0_0.Squad) >= this.ai_combat_status_active, 15);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e12_patrol/p0_2"));
        }

        [ScriptMethod(185, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_0_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e12_patrol/p0_0"));
                await sleep((short)random_range(30, 60));
                cs_go_to(GetReference<ISpatialPoint>("e12_patrol/p0_1"));
                await sleep((short)random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(186, Lifecycle.CommandScript)]
        public async Task cs_e12_scarab_gunner()
        {
            cs_shoot_point(true, GetReference<ISpatialPoint>("e12_scarab/p0"));
            await sleep(165);
        }

        [ScriptMethod(187, Lifecycle.CommandScript)]
        public async Task cs_e12_mars_warthog0_cleanup()
        {
            if (!(volume_test_object(tv_e12_mars_warthog0_preserve, ai_get_object(this.ai_current_actor))))
            {
                ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(188, Lifecycle.CommandScript)]
        public async Task cs_e12_ghosts_entry()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_moving(true);
            cs_vehicle_boost(true);
            await sleep(150);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task e12_cov_ghosts0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_scarab_begin, players()), 15);
            await sleep_until(async () => volume_test_objects(tv_e12_cov_ghosts0_begin, players()), 15);
            ai_place(e12_cov_ghosts0.Squad);
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task scarab_walk_front_var0()
        {
            print("scarab_walk_front_var0");
            device_set_position_track(tunnel_scarab.Entity, "combat:walk_front:var0", 0F);
            device_animate_position(tunnel_scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(tunnel_scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task e12_event_warthog()
        {
            object_create(e12_warthog0);
            object_set_velocity(e12_warthog0.Entity, 11F, 0F, 0.25F);
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task e12_event_scarab_gun()
        {
            object_create(e12_scarab_gun);
            weapon_hold_trigger(GetReference<IWeaponReference>("e12_scarab_gun"), 0, true);
            await sleep(90);
            weapon_hold_trigger(GetReference<IWeaponReference>("e12_scarab_gun"), 0, false);
            wake(new ScriptMethodReference(e12_cov_ghosts0_main));
            await sleep(60);
            object_destroy(e12_scarab_gun.Entity);
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task e12_event_scarab()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_scarab_begin, players()), 8);
            wake(new ScriptMethodReference(e12_event_warthog));
            await sleep(26);
            wake(new ScriptMethodReference(e12_event_scarab_gun));
            wake(new ScriptMethodReference(music_03a_066_start));
            wake(new ScriptMethodReference(music_03a_067_start));
            object_create(tunnel_scarab);
            pvs_set_object(tunnel_scarab.Entity);
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            if (volume_test_objects(tv_e12_scarab_begin, players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (volume_test_objects(tv_e12_scarab_begin, players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (volume_test_objects(tv_e12_scarab_begin, players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (volume_test_objects(tv_e12_scarab_begin, players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (volume_test_objects(tv_e12_scarab_begin, players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (volume_test_objects(tv_e12_scarab_begin, players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (volume_test_objects(tv_e12_scarab_begin, players()))
            {
                await this.scarab_walk_front_var0();
            }

            if (volume_test_objects(tv_e12_scarab_begin, players()))
            {
                await this.scarab_walk_front_var0();
            }

            object_destroy(tunnel_scarab.Entity);
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task e12_cortana_dialog()
        {
            await sleep(30);
            await sleep(ai_play_line_on_object(default(IGameObject), "0070"));
            await sleep(20);
            await sleep(ai_play_line_on_object(default(IGameObject), "0080"));
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task e12_cov_creep0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_cov_inf0_5_begin, players()), 10);
            ai_place(e12_cov_creep0.Squad);
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task e12_cov_inf0_main()
        {
            ai_place(e12_cov_inf0_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e12_cov_inf0_2_begin, players()), 10);
            game_save();
            ai_disposable(e12_cov_inf0_0.Squad, true);
            ai_place(e12_cov_inf0_1.Squad);
            await sleep_until(async () => volume_test_objects(tv_e12_cov_inf0_3_begin, players()), 10);
            ai_disposable(e12_cov_inf0_1.Squad, true);
            ai_place(e12_cov_inf0_2.Squad);
            await sleep_until(async () => volume_test_objects(tv_e12_cov_inf0_6_begin, players()), 10);
            game_save();
            ai_disposable(e12_cov_inf0_2.Squad, true);
            ai_place(e12_cov_inf0_6.Squad);
            await sleep_until(async () => volume_test_objects(tv_e12_cov_inf0_4_begin, players()), 10);
            game_save();
            ai_place(e12_cov_inf0_4.Squad);
            await sleep_until(async () => volume_test_objects(tv_e12_cov_inf0_6_migrate, players()), 10);
            ai_migrate(e12_cov_inf0_6.Squad, e12_cov_inf0_4.Squad);
            await sleep_until(async () => volume_test_objects(tv_e12_scarab_begin, players()), 8);
            ai_disposable(e12_cov_inf0_4.Squad, true);
            await sleep_until(async () => volume_test_objects(tv_e12_cov_inf0_5_begin, players()), 10);
            game_save();
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task e12_mars_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_mars_inf1_begin, players()), 15);
            ai_place(e12_mars_inf1.Squad);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task e12_mars_inf0_main()
        {
            await sleep(1);
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task e12_mars_warthog1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_mars_warthog1_begin, players()), 10);
            cs_run_command_script(e12_mars_warthog0.Squad, new ScriptMethodReference(cs_e12_mars_horrible_cleanup));
            await sleep(15);
            if ((short)ai_living_count(e12_mars_warthog0.Squad) <= 2)
            {
                ai_place(e12_mars_warthog1.Squad);
            }
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task e12_mars_warthog0_main()
        {
            ai_migrate(e11_mars_warthog0.Squad, e12_mars_warthog0.Squad);
            ai_renew(e12_mars_warthog0.Squad);
            ai_disposable(e12_mars_warthog0.Squad, false);
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            cs_run_command_script(e12_mars_warthog0.Squad, new ScriptMethodReference(cs_e12_mars_warthog0_cleanup));
            await sleep(15);
            game_save();
            if ((short)ai_living_count(e12_mars_warthog0.Squad) < 4)
            {
                ai_place(e12_mars_warthog0.Squad);
            }
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task e12_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_main_begin, players()), 15);
            this.g_e12_started = true;
            print("e12_main");
            data_mine_set_mission_segment("e12_tunnel_blockades");
            game_save();
            wake(new ScriptMethodReference(chapter_title2));
            wake(new ScriptMethodReference(e13_main));
            wake(new ScriptMethodReference(e12_cov_inf0_main));
            wake(new ScriptMethodReference(e12_cov_creep0_main));
            wake(new ScriptMethodReference(e12_cov_ghosts0_main));
            wake(new ScriptMethodReference(e12_mars_warthog0_main));
            wake(new ScriptMethodReference(e12_mars_warthog1_main));
            wake(new ScriptMethodReference(e12_mars_inf0_main));
            wake(new ScriptMethodReference(e12_mars_inf1_main));
            wake(new ScriptMethodReference(e12_event_scarab));
            wake(new ScriptMethodReference(e12_cortana_dialog));
            await sleep_until(async () => this.g_e13_started);
            sleep_forever(new ScriptMethodReference(e12_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e12_cov_creep0_main));
            sleep_forever(new ScriptMethodReference(e12_cov_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e12_mars_warthog0_main));
            sleep_forever(new ScriptMethodReference(e12_mars_warthog1_main));
            sleep_forever(new ScriptMethodReference(e12_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e12_mars_inf1_main));
            sleep_forever(new ScriptMethodReference(e12_event_scarab));
            sleep_forever(new ScriptMethodReference(e12_cortana_dialog));
            ai_disposable(e12_cov, true);
        }

        [ScriptMethod(202, Lifecycle.Static)]
        public async Task test_tunnel_blockades()
        {
            switch_bsp(2);
            object_teleport(await this.player0(), e12_test);
            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(203, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_phantom0_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to(GetReference<ISpatialPoint>("e11_cov_phantom0/p0"), 1F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e11_cov_phantom0/p1"), GetReference<ISpatialPoint>("e11_cov_phantom0/p2"), 1F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e11_cov_phantom0/p2"), GetReference<ISpatialPoint>("e11_cov_phantom0/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("e11_cov_phantom0/p3"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_inf0_shoot0()
        {
            cs_abort_on_damage(true);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e11_patrol/s0"));
            await sleep((short)random_range(this._30_seconds, this.one_minute));
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_inf0_shoot1()
        {
            cs_abort_on_damage(true);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e11_patrol/s1"));
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e11_patrol/p1"));
                await sleep((short)random_range(60, 90));
                cs_go_to(GetReference<ISpatialPoint>("e11_patrol/p0"));
                await sleep((short)random_range(90, 120));
                return false;
            }, 30, this._30_seconds);
        }

        [ScriptMethod(206, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_inf0_shoot2()
        {
            cs_abort_on_damage(true);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e11_patrol/s2"));
            await sleep((short)random_range(this._30_seconds, this.one_minute));
        }

        [ScriptMethod(207, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_ghosts0_entry()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_and_face(GetReference<ISpatialPoint>("e11_cov_ghosts0/p0"), GetReference<ISpatialPoint>("e11_cov_ghosts0/p1"));
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e11_cov_ghosts0/p1"));
        }

        [ScriptMethod(208, Lifecycle.Static)]
        public async Task<bool> e11_cov_phantom0_leaving()
        {
            return this.g_e11_cov_phantom0_leaving == true;
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_0_insertion0()
        {
            ai_place(e11_cov_inf1_0.elite0);
            object_create(e11_pod0_inserter);
            objects_attach(e11_pod0_inserter.Entity, "pod_attach", ai_vehicle_get(e11_cov_inf1_0.elite0), "pod_attach");
            await sleep(1);
            device_set_position(e11_pod0_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e11_pod0_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e11_pod_impact_effect, ai_vehicle_get(e11_cov_inf1_0.elite0), "pod_attach");
            objects_detach(e11_pod0_inserter.Entity, ai_vehicle_get(e11_cov_inf1_0.elite0));
            object_destroy(e11_pod0_inserter.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(e11_cov_inf1_0.elite0), "door", 500F);
            await sleep(30);
            ai_vehicle_exit(e11_cov_inf1_0.elite0);
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_0_insertion1()
        {
            ai_place(e11_cov_inf1_0.elite1);
            object_create(e11_pod1_inserter);
            objects_attach(e11_pod1_inserter.Entity, "pod_attach", ai_vehicle_get(e11_cov_inf1_0.elite1), "pod_attach");
            await sleep(1);
            device_set_position(e11_pod1_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e11_pod1_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e11_pod_impact_effect, ai_vehicle_get(e11_cov_inf1_0.elite1), "pod_attach");
            objects_detach(e11_pod1_inserter.Entity, ai_vehicle_get(e11_cov_inf1_0.elite1));
            object_destroy(e11_pod1_inserter.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(e11_cov_inf1_0.elite1), "door", 500F);
            await sleep(30);
            ai_vehicle_exit(e11_cov_inf1_0.elite1);
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_0_insertion2()
        {
            ai_place(e11_cov_inf1_0.elite2);
            object_create(e11_pod2_inserter);
            objects_attach(e11_pod2_inserter.Entity, "pod_attach", ai_vehicle_get(e11_cov_inf1_0.elite2), "pod_attach");
            await sleep(1);
            device_set_position(e11_pod2_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e11_pod2_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e11_pod_impact_effect, ai_vehicle_get(e11_cov_inf1_0.elite2), "pod_attach");
            objects_detach(e11_pod2_inserter.Entity, ai_vehicle_get(e11_cov_inf1_0.elite2));
            object_destroy(e11_pod2_inserter.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(e11_cov_inf1_0.elite2), "door", 500F);
            await sleep(30);
            ai_vehicle_exit(e11_cov_inf1_0.elite2);
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_1_insertion0()
        {
            ai_place(e11_cov_inf1_1.elite0);
            object_create(e11_pod3_inserter);
            objects_attach(e11_pod3_inserter.Entity, "pod_attach", ai_vehicle_get(e11_cov_inf1_1.elite0), "pod_attach");
            await sleep(1);
            device_set_position(e11_pod3_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e11_pod3_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e11_pod_impact_effect, ai_vehicle_get(e11_cov_inf1_1.elite0), "pod_attach");
            objects_detach(e11_pod3_inserter.Entity, ai_vehicle_get(e11_cov_inf1_1.elite0));
            object_destroy(e11_pod3_inserter.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(e11_cov_inf1_1.elite0), "door", 500F);
            await sleep(30);
            ai_vehicle_exit(e11_cov_inf1_1.elite0);
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_1_insertion1()
        {
            ai_place(e11_cov_inf1_1.elite1);
            object_create(e11_pod4_inserter);
            objects_attach(e11_pod4_inserter.Entity, "pod_attach", ai_vehicle_get(e11_cov_inf1_1.elite1), "pod_attach");
            await sleep(1);
            device_set_position(e11_pod4_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e11_pod4_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e11_pod_impact_effect, ai_vehicle_get(e11_cov_inf1_1.elite1), "pod_attach");
            objects_detach(e11_pod4_inserter.Entity, ai_vehicle_get(e11_cov_inf1_1.elite1));
            object_destroy(e11_pod4_inserter.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(e11_cov_inf1_1.elite1), "door", 500F);
            await sleep(30);
            ai_vehicle_exit(e11_cov_inf1_1.elite1);
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_1_insertion2()
        {
            ai_place(e11_cov_inf1_1.elite2);
            object_create(e11_pod5_inserter);
            objects_attach(e11_pod5_inserter.Entity, "pod_attach", ai_vehicle_get(e11_cov_inf1_1.elite2), "pod_attach");
            await sleep(1);
            device_set_position(e11_pod5_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e11_pod5_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e11_pod_impact_effect, ai_vehicle_get(e11_cov_inf1_1.elite2), "pod_attach");
            objects_detach(e11_pod5_inserter.Entity, ai_vehicle_get(e11_cov_inf1_1.elite2));
            object_destroy(e11_pod5_inserter.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(e11_cov_inf1_1.elite2), "door", 500F);
            await sleep(30);
            ai_vehicle_exit(e11_cov_inf1_1.elite2);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_1_insertion3()
        {
            ai_place(e11_cov_inf1_1.elite3);
            object_create(e11_pod6_inserter);
            objects_attach(e11_pod6_inserter.Entity, "pod_attach", ai_vehicle_get(e11_cov_inf1_1.elite3), "pod_attach");
            await sleep(1);
            device_set_position(e11_pod6_inserter.Entity, 1F);
            await sleep_until(async () => device_get_position(e11_pod6_inserter.Entity) >= 1F, 1);
            effect_new_on_object_marker(this.g_e11_pod_impact_effect, ai_vehicle_get(e11_cov_inf1_1.elite3), "pod_attach");
            objects_detach(e11_pod6_inserter.Entity, ai_vehicle_get(e11_cov_inf1_1.elite3));
            object_destroy(e11_pod6_inserter.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(e11_cov_inf1_1.elite3), "door", 500F);
            await sleep(30);
            ai_vehicle_exit(e11_cov_inf1_1.elite3);
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task e11_warthog_approach_horn()
        {
            print("honk");
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U), ai_vehicle_get_from_starting_location(e11_mars_warthog0.warthog0), 1.5F);
            await sleep(30);
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U));
        }

        [ScriptMethod(217, Lifecycle.CommandScript)]
        public async Task cs_e11_warthog_approach()
        {
            cs_approach_player(10F, 100F, 100F);
            wake(new ScriptMethodReference(e11_warthog_approach_horn));
            cs_vehicle_speed(0.5F);
            cs_approach_player(5F, 100F, 100F);
            await sleep_until(async () => await this.player_in_vehicle() || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 10F || !(unit_in_vehicle(ai_get_unit(this.ai_current_actor))));
        }

        [ScriptMethod(218, Lifecycle.Dormant)]
        public async Task e11_miranda_dialog()
        {
            await sleep(ai_play_line_on_object(default(IGameObject), "0560"));
            game_save();
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task e11_dialog()
        {
            await sleep(150);
            await sleep_until(async () => objects_can_see_flag(players(), e11_cov_inf1_entry, 15F) && volume_test_objects_all(tv_e11_area, players()));
            await sleep_until(async () => volume_test_objects(tv_e11_tunnel_entrance, players()));
            ai_play_line_on_object(default(IGameObject), "0580") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task e11_navpoint()
        {
            await sleep_until(async () => objects_distance_to_flag(players(), e11_tunnel_entrance) > 50F, 30, this._30_seconds);
            print("navpoint up");
            activate_team_nav_point_flag(_default, player, e11_tunnel_entrance, 0F);
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task e11_navpoint_kill()
        {
            await sleep_until(async () => volume_test_objects(tv_e11_tunnel_entrance, players()), 15);
            sleep_forever(new ScriptMethodReference(e11_navpoint));
            print("navpoint down");
            deactivate_team_nav_point_flag(player, e11_tunnel_entrance);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task e11_cov_phantom0_main()
        {
            await sleep_until(async () => this.g_e10_cov_phantom0_leaving, 15);
            ai_set_orders(e10_cov_phantom0.Squad, e11_cov_phantom0_init);
            await sleep_until(async () => object_model_targets_destroyed(ai_vehicle_get(e10_cov_phantom0.phantom0), "target_front") >= 2 || object_get_health(ai_vehicle_get(e10_cov_phantom0.phantom0)) <= 0.05F || (short)ai_spawn_count(e11_cov_ghosts0_1.Squad) > 0, 30, this.one_minute);
            await sleep_until(async () => object_model_targets_destroyed(ai_vehicle_get(e10_cov_phantom0.phantom0), "target_front") >= 2 || object_get_health(ai_vehicle_get(e10_cov_phantom0.phantom0)) <= 0.05F, 30, this.one_minute);
            this.g_e11_cov_phantom0_leaving = true;
            cs_run_command_script(e10_cov_phantom0.phantom0, new ScriptMethodReference(cs_e11_cov_phantom0_exit));
            await sleep(120);
            game_save();
            wake(new ScriptMethodReference(e11_navpoint));
            wake(new ScriptMethodReference(e11_navpoint_kill));
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task e11_cov_ghosts0_main()
        {
            ai_migrate(e10_cov_ghosts0, e11_cov_ghosts0_0.Squad);
            ai_place(e11_cov_ghosts0_0.Squad, (short)pin(3F - (float)ai_living_count(e11_cov_ghosts0_0.Squad), 0F, 2F));
            await sleep_until(async () => (short)ai_living_count(e11_cov_ghosts0) <= 0);
            game_save();
            await sleep(this._30_seconds);
            await sleep_until(async () => volume_test_objects_all(tv_e11_area, players()));
            ai_place(e11_cov_ghosts0_1.Squad);
            await sleep_until(async () => (short)ai_living_count(e11_cov_ghosts0) <= 0);
            game_save();
            await sleep(this._30_seconds);
            await sleep_until(async () => volume_test_objects_all(tv_e11_area, players()));
            ai_place(e11_cov_ghosts0_1.Squad);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task e11_cov_inf2_main()
        {
            ai_place(e11_cov_inf2.Squad);
            await sleep_until(async () => volume_test_objects(tv_e11_on_fort, players()) || objects_distance_to_flag(players(), e11_cov_inf1_entry) < 40F, 10);
            device_group_set_immediate(e11_watchtower0, 1F);
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task e11_cov_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e11_on_fort, players()) || volume_test_objects(tv_e11_near_exit, players()), 10);
            await sleep(30);
            if (!(volume_test_objects(tv_e11_near_exit, players())))
            {
                await sleep_until(async () => objects_can_see_flag(players(), e11_cov_inf1_entry, 25F), 60, 300);
                wake(new ScriptMethodReference(e11_cov_inf1_0_insertion0));
                await sleep(20);
                wake(new ScriptMethodReference(e11_cov_inf1_0_insertion1));
                await sleep(10);
                if ((short)ai_living_count(covenant1) < 10)
                {
                    wake(new ScriptMethodReference(e11_cov_inf1_0_insertion2));
                }
            }

            await sleep_until(async () => volume_test_objects(tv_e11_near_exit, players()), 10);
            wake(new ScriptMethodReference(e11_cov_inf1_1_insertion0));
            await sleep(15);
            wake(new ScriptMethodReference(e11_cov_inf1_1_insertion1));
            await sleep(7);
            if ((short)ai_living_count(covenant1) < 10)
            {
                wake(new ScriptMethodReference(e11_cov_inf1_1_insertion2));
            }

            await sleep(25);
            if ((short)ai_living_count(covenant1) < 10)
            {
                wake(new ScriptMethodReference(e11_cov_inf1_1_insertion3));
            }
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task e11_cov_inf0_main()
        {
            ai_place(e11_cov_inf0.Squad);
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task e11_mars_inf0_main()
        {
            if (!((bool)game_is_cooperative()))
            {
                ai_place(e11_mars_inf0.Squad, (short)pin(3F - (float)ai_living_count(marines), 1F, 2F));
            }
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task e11_mars_warthog0_main()
        {
            ai_migrate(e10_mars_warthog0.Squad, e11_mars_warthog0.Squad);
            ai_migrate(e10_mars_inf0.Squad, e11_mars_warthog0.Squad);
            ai_renew(e11_mars_warthog0.Squad);
            ai_disposable(e11_mars_warthog0.Squad, false);
            await sleep_until(async () => !(await this.player_in_vehicle()) && !(volume_test_object(tv_beach, this.g_e8_warthog)) || object_get_health(this.g_e8_warthog) <= 0F && !(volume_test_object(tv_beach, this.g_e10_warthog)) || object_get_health(this.g_e10_warthog) <= 0F);
            await sleep(this._15_seconds);
            await sleep_until(async () => !(volume_test_objects(tv_e11_mars_warthog0_unsafe, players())));
            ai_place(e11_mars_warthog0.Squad);
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task e11_warthog_for_the_masses()
        {
            await sleep(300);
            object_create(warthog_for_the_masses);
            await sleep(2);
            object_cannot_die(warthog_for_the_masses.Entity, true);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task e11_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e11_main_begin, players()), 15);
            this.g_e11_started = true;
            print("e11_main");
            data_mine_set_mission_segment("e11_tunnel_entrance");
            game_save();
            wake(new ScriptMethodReference(objective3_clear));
            wake(new ScriptMethodReference(objective4_set));
            wake(new ScriptMethodReference(e11_mars_inf0_main));
            wake(new ScriptMethodReference(e11_mars_warthog0_main));
            wake(new ScriptMethodReference(e11_cov_inf1_main));
            wake(new ScriptMethodReference(e11_cov_inf2_main));
            wake(new ScriptMethodReference(e11_cov_ghosts0_main));
            wake(new ScriptMethodReference(e11_cov_phantom0_main));
            wake(new ScriptMethodReference(e11_dialog));
            wake(new ScriptMethodReference(e11_miranda_dialog));
            wake(new ScriptMethodReference(e11_warthog_for_the_masses));
            await sleep_until(async () => this.g_e12_started);
            sleep_forever(new ScriptMethodReference(e11_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e11_mars_warthog0_main));
            sleep_forever(new ScriptMethodReference(e11_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e11_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e11_cov_inf2_main));
            sleep_forever(new ScriptMethodReference(e11_cov_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e11_cov_phantom0_main));
            sleep_forever(new ScriptMethodReference(e11_dialog));
            ai_disposable(e11_cov, true);
            await sleep_until(async () => this.g_e13_started);
            ai_erase(e11_mars);
            ai_erase(e11_cov);
        }

        [ScriptMethod(231, Lifecycle.Static)]
        public async Task test_tunnel_entrance()
        {
            switch_bsp(1);
            object_teleport(await this.player0(), e11_test);
            ai_place(e11_mars_warthog0.Squad);
            if (!(this.g_e11_started))
            {
                wake(new ScriptMethodReference(e11_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(232, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_guntower_shoot()
        {
            await sleep_until(async () =>
            {
                begin_random(async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e10_cov_guntower/p0")), 
                    async () => await sleep((short)random_range(125, 200)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e10_cov_guntower/p1")), 
                    async () => await sleep((short)random_range(125, 200)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e10_cov_guntower/p2")), 
                    async () => await sleep((short)random_range(125, 200)));
                return (float)ai_strength(this.ai_current_actor) <= 0.65F || (float)ai_strength(this.ai_current_squad) <= 0.5F;
            });
            ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(233, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_phantom0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e10_cov_phantom0/p0"));
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("e10_cov_phantom0/p1"));
            this.g_e10_cov_phantom0_arrived = true;
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e10_cov_phantom0/p2"), GetReference<ISpatialPoint>("e10_cov_phantom0/p2_facing"), 0.5F);
            cs_face(true, GetReference<ISpatialPoint>("e10_cov_phantom0/p2_facing"));
            await sleep(30);
            this.g_e10_cov_ghosts0_unloaded = true;
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_sc");
        }

        [ScriptMethod(234, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_phantom0_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_face(true, GetReference<ISpatialPoint>("e10_cov_phantom0/p2_facing"));
            cs_fly_to(GetReference<ISpatialPoint>("e10_cov_phantom0/p3"), 1F);
            cs_fly_to(GetReference<ISpatialPoint>("e10_cov_phantom0/p4"), 1F);
            await sleep_until(async () => this.g_e11_started);
        }

        [ScriptMethod(235, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_inf0_patrol1()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e10_patrol/p2"));
                cs_look(true, GetReference<ISpatialPoint>("e10_patrol/f0"));
                await sleep((short)random_range(30, 60));
                cs_look(false, GetReference<ISpatialPoint>("e10_patrol/f0"));
                cs_go_to(GetReference<ISpatialPoint>("e10_patrol/p3"));
                await sleep((short)random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(236, Lifecycle.CommandScript)]
        public async Task cs_e10_cov_inf0_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e10_patrol/p0"));
                cs_look(true, GetReference<ISpatialPoint>("e10_patrol/f0"));
                await sleep((short)random_range(30, 60));
                cs_look(false, GetReference<ISpatialPoint>("e10_patrol/f0"));
                cs_go_to(GetReference<ISpatialPoint>("e10_patrol/p1"));
                await sleep((short)random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task e10_warthog_approach_horn()
        {
            print("honk");
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U), this.g_e10_warthog, 1.5F);
            await sleep(30);
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U));
        }

        [ScriptMethod(238, Lifecycle.CommandScript)]
        public async Task cs_e10_warthog_approach()
        {
            cs_approach_player(10F, 100F, 100F);
            wake(new ScriptMethodReference(e10_warthog_approach_horn));
            cs_vehicle_speed(0.5F);
            cs_approach_player(5F, 100F, 100F);
            await sleep_until(async () => await this.player_in_vehicle() || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 10F || !(unit_in_vehicle(ai_get_unit(this.ai_current_actor))));
        }

        [ScriptMethod(239, Lifecycle.Static)]
        public async Task<bool> e10_cov_phantom0_threat()
        {
            return this.g_e10_cov_phantom0_arrived && !(this.g_e10_cov_phantom0_leaving);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task e10_cov_phantom0_main()
        {
            await sleep_until(async () => (float)ai_strength(e10_cov) <= 0.4F || volume_test_objects(tv_e10_cov_phantom0_begin, players()), 15);
            ai_place(e10_cov_phantom0.Squad);
            await sleep_until(async () => this.g_e10_cov_ghosts0_unloaded);
            await sleep_until(async () => (short)ai_spawn_count(e10_cov_ghosts0_1.Squad) > 0 && (short)ai_living_count(e10_cov_ghosts0) <= 0 || object_model_targets_destroyed(ai_vehicle_get(e10_cov_phantom0.phantom0), "target_front") >= 3 || object_get_health(ai_vehicle_get(e10_cov_phantom0.phantom0)) <= 0.05F || this.g_e11_started, 30, this.one_minute);
            this.g_e10_cov_phantom0_leaving = true;
            ai_set_orders(e10_cov_phantom0.Squad, e10_cov_phantom0_retreat0);
            cs_run_command_script(e10_cov_phantom0.phantom0, new ScriptMethodReference(cs_e10_cov_phantom0_exit));
            await sleep(120);
            game_save();
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task e10_cov_ghosts0_main()
        {
            ai_place(e10_cov_ghosts1.Squad);
            await sleep_until(async () => (short)ai_spawn_count(e10_cov_phantom0.Squad) > 0);
            ai_place_in_vehicle(e10_cov_ghosts0_0.Squad, e10_cov_phantom0.Squad);
            await sleep_until(async () => this.g_e10_cov_ghosts0_unloaded && (short)ai_living_count(e10_cov_ghosts0) <= 1);
            ai_place(e10_cov_ghosts0_1.Squad);
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task e10_cov_inf1_main()
        {
            ai_place(e10_cov_inf1.Squad);
            ai_vehicle_reserve(e10_guntower0.Entity, true);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task e10_cov_inf0_main()
        {
            ai_place(e10_cov_inf0.Squad);
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task e10_mars_warthog0_main()
        {
            ai_migrate(e9_mars_test.Squad, e10_mars_warthog0.Squad);
            ai_migrate(e9_mars_warthog0.Squad, e10_mars_warthog0.Squad);
            ai_renew(e10_mars_warthog0.Squad);
            ai_disposable(e10_mars_warthog0.Squad, false);
            await sleep_until(async () => !(await this.player_in_vehicle()) && !(volume_test_object(tv_beach, this.g_e8_warthog)) || object_get_health(this.g_e8_warthog) <= 0F);
            await sleep(this._15_seconds);
            await sleep_until(async () => !(volume_test_objects(tv_e10_mars_warthog0_unsafe, players())));
            ai_place(e10_mars_warthog0.Squad);
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task e10_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_early_begin, players()) || volume_test_objects(tv_e10_main_begin, players()), 16);
            game_save();
            await sleep_until(async () => volume_test_objects(tv_e10_main_begin, players()), 15);
            this.g_e10_started = true;
            print("e10_main");
            data_mine_set_mission_segment("e10_beach_fort");
            wake(new ScriptMethodReference(e10_mars_warthog0_main));
            wake(new ScriptMethodReference(e10_cov_inf0_main));
            wake(new ScriptMethodReference(e10_cov_inf1_main));
            wake(new ScriptMethodReference(e10_cov_ghosts0_main));
            wake(new ScriptMethodReference(e10_cov_phantom0_main));
            await sleep_until(async () => this.g_e11_started);
            sleep_forever(new ScriptMethodReference(e10_mars_warthog0_main));
            sleep_forever(new ScriptMethodReference(e10_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e10_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e10_cov_ghosts0_main));
            ai_disposable(e10_cov, true);
            ai_disposable(e10_cov_phantom0.Squad, false);
        }

        [ScriptMethod(246, Lifecycle.Static)]
        public async Task test_beach_fort()
        {
            switch_bsp(1);
            object_teleport(await this.player0(), e10_test);
            ai_place(e10_mars_test.Squad);
            if (!(this.g_e10_started))
            {
                wake(new ScriptMethodReference(e10_main));
            }

            if (!(this.g_e11_started))
            {
                wake(new ScriptMethodReference(e11_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task cs_e9_cov_guntower_shoot()
        {
            cs_force_combat_status(3);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e9_cov_guntower/p0")), 
                    async () => await sleep((short)random_range(125, 200)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e9_cov_guntower/p1")), 
                    async () => await sleep((short)random_range(125, 200)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e9_cov_guntower/p2")), 
                    async () => await sleep((short)random_range(125, 200)));
                return (float)ai_strength(this.ai_current_actor) <= 0.65F || (float)ai_strength(this.ai_current_squad) <= 0.5F;
            });
            ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(248, Lifecycle.CommandScript)]
        public async Task cs_e9_cov_guntower_abort()
        {
            cs_crouch(false);
        }

        [ScriptMethod(249, Lifecycle.CommandScript)]
        public async Task cs_e9_beach_chatter_scene()
        {
            cs_switch("marine0");
            cs_play_line("0520");
            await sleep(15);
            cs_switch("marine1");
            cs_play_line("0530");
            await sleep(10);
            if ((short)ai_combat_status(this.ai_current_squad) < this.ai_combat_status_active)
            {
                cs_switch("marine0");
                cs_play_line("0540");
                await sleep(15);
            }

            if ((short)ai_combat_status(this.ai_current_squad) >= this.ai_combat_status_active)
            {
                ai_play_line_on_object(default(IGameObject), "0550") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(250, Lifecycle.CommandScript)]
        public async Task cs_e9_cov_inf1_2_patrol()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e9_patrol/p2"));
                await sleep((short)random_range(30, 60));
                cs_go_to(GetReference<ISpatialPoint>("e9_patrol/p3"));
                await sleep((short)random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(251, Lifecycle.CommandScript)]
        public async Task cs_e9_cov_inf1_0_patrol()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e9_patrol/p0"));
                cs_look(true, GetReference<ISpatialPoint>("e9_patrol/f0"));
                await sleep((short)random_range(30, 60));
                cs_look(false, GetReference<ISpatialPoint>("e9_patrol/f0"));
                cs_go_to(GetReference<ISpatialPoint>("e9_patrol/p1"));
                await sleep((short)random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(252, Lifecycle.CommandScript)]
        public async Task cs_e9_warthog_abort()
        {
            await sleep(1);
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task e9_warthog_approach_horn()
        {
            print("honk");
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U), this.g_e8_warthog, 1.5F);
            await sleep(30);
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U));
        }

        [ScriptMethod(254, Lifecycle.CommandScript)]
        public async Task cs_e9_warthog_follow()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_enable_moving(false);
            await sleep_until(async () =>
            {
                cs_approach_player(10F, 100F, 100F);
                wake(new ScriptMethodReference(e9_warthog_approach_horn));
                cs_vehicle_speed(0.5F);
                cs_approach_player(5F, 100F, 100F);
                await sleep_until(async () => await this.player_in_vehicle() || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 8F || !(unit_in_vehicle(ai_get_unit(this.ai_current_actor))));
                return await this.player_in_vehicle() || !(unit_in_vehicle(ai_get_unit(this.ai_current_actor)));
            }, 30, this.two_minutes);
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task e9_cortana_dialog()
        {
            await sleep_until(async () => objects_can_see_flag(players(), e9_dialog_trigger, 25F) || volume_test_objects(tv_e9_dialogue, players()), 5, this._30_seconds);
            await sleep(15);
            print("highest concentration under carrier");
            await sleep(ai_play_line_on_object(default(IGameObject), "0050"));
            await sleep(15);
            await sleep_until(async () => objects_can_see_flag(players(), e9_dialog_trigger, 25F) || volume_test_objects(tv_e9_dialogue, players()), 5, 150);
            print("that bridge is the best route");
            await sleep(ai_play_line_on_object(default(IGameObject), "0060"));
            await sleep_until(async () => volume_test_objects(tv_e9_main_begin, players()));
            await sleep_until(async () => ai_scene("e9_beach_chatter_scene", new ScriptMethodReference(cs_e9_beach_chatter_scene), e9_mars_warthog0.Squad), 30, 300);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task e9_warthog_navpoint()
        {
            await sleep_until(async () => (short)ai_spawn_count(e8_mars_warthog0.Squad) > 0);
            if (!(await this.player_in_vehicle()))
            {
                activate_team_nav_point_object(_default, player, this.g_e8_warthog, 1F);
            }
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task e9_warthog_navpoint_kill()
        {
            await sleep_until(async () => await this.player_in_vehicle() || unit_get_health(this.g_e8_warthog) <= 0F);
            deactivate_team_nav_point_object(player, this.g_e8_warthog);
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task e9_retreat_checkpoint0()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_retreat_checkpoint, players()), this._30_seconds);
            game_save();
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task e9_retreat_checkpoint1()
        {
            sleep_forever(new ScriptMethodReference(e9_retreat_checkpoint0));
            await sleep_until(async () => volume_test_objects(tv_e9_retreat_checkpoint, players()), this._30_seconds);
            game_save();
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task e9_music()
        {
            wake(new ScriptMethodReference(music_03a_05_start));
            await sleep_until(async () => volume_test_objects(tv_beach, players()));
            wake(new ScriptMethodReference(music_03a_05_stop));
            wake(new ScriptMethodReference(music_03a_06_start));
            await sleep_until(async () => volume_test_objects(tv_e9_near_entrance, players()));
            wake(new ScriptMethodReference(music_03a_06_stop));
            wake(new ScriptMethodReference(music_03a_065_start));
            await sleep_until(async () => volume_test_objects(tv_e10_music, players()));
            await sleep(150);
            wake(new ScriptMethodReference(music_03a_065_start_alt));
            await sleep_until(async () => this.g_e11_started);
            wake(new ScriptMethodReference(music_03a_065_stop));
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task e9_cov_inf1_main()
        {
            ai_place(e9_cov_inf1_2.Squad, (short)pin(10F - (float)ai_living_count(covenant1), 0F, 1F));
            await sleep_until(async () => volume_test_objects(tv_e9_main_begin, players()), 15);
            ai_place(e9_cov_inf1_0.Squad, (short)pin(10F - (float)ai_living_count(covenant1), 1F, 3F));
            ai_place(e9_cov_inf1_1.Squad, (short)pin(10F - (float)ai_living_count(covenant1), 1F, 2F));
            ai_vehicle_reserve(e9_guntower0.Entity, true);
            await sleep_until(async () => (short)ai_living_count(e9_cov_inf1) <= 0);
            game_save();
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task e9_cov_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_near_entrance, players()) || (short)ai_spawn_count(e9_cov_ghosts0.Squad) > 0, 30);
            await sleep_until(async () => volume_test_objects(tv_e9_near_entrance, players()) || (short)ai_living_count(e9_cov_inf1) <= 1, 15);
            ai_place(e9_cov_inf0.Squad, (short)pin(10F - (float)ai_living_count(e9_cov), 3F, 7F));
            wake(new ScriptMethodReference(e9_retreat_checkpoint0));
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task e9_cov_shadow0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_retreat_checkpoint, players()), 15);
            ai_place(e9_cov_shadow0.Squad);
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task e9_cov_ghosts0_main()
        {
            await sleep_until(async () => (short)ai_living_count(e9_cov_ghosts0.Squad) <= 0 && volume_test_objects(tv_e9_near_entrance, players()) || volume_test_objects(tv_e9_bypass, players()) || (short)ai_living_count(e9_cov_inf1) <= 3, 15);
            ai_place(e9_cov_ghosts0.Squad);
            wake(new ScriptMethodReference(e9_retreat_checkpoint0));
            await sleep_until(async () => volume_test_objects(tv_e9_bypass, players()), 15);
            ai_migrate(e9_cov_ghosts0.Squad, e10_cov_ghosts0_0.Squad);
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task e9_mars_warthog0_main()
        {
            await sleep_until(async () => !(volume_test_objects(tv_e8_vehicle_spawn_area, players())));
            await sleep_until(async () => (short)ai_spawn_count(e8_mars_warthog0.Squad) > 0, 30);
            ai_migrate(e8_mars_warthog0.Squad, e9_mars_warthog0.Squad);
            ai_renew(e9_mars_warthog0.Squad);
            ai_disposable(e9_mars_warthog0.Squad, false);
            cs_run_command_script(e9_mars_warthog0.Squad, new ScriptMethodReference(cs_e9_warthog_abort));
            ai_vehicle_reserve_seat(this.g_e8_warthog, "warthog_d", false);
            ai_vehicle_enter(e9_mars_warthog0.Squad, this.g_e8_warthog, "warthog_d");
            if (!(await this.player_in_vehicle()))
            {
                await sleep_until(async () => vehicle_test_seat_list(this.g_e8_warthog, "warthog_d", ai_actors(e9_mars)), 30, 900);
                cs_run_command_script(object_get_ai(vehicle_driver(this.g_e8_warthog)), new ScriptMethodReference(cs_e9_warthog_follow));
            }
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task e9_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_main_begin, players()), 15);
            this.g_e9_started = true;
            print("e9_main");
            data_mine_set_mission_segment("e9_beach_infantry");
            game_save_no_timeout();
            wake(new ScriptMethodReference(e9_music));
            wake(new ScriptMethodReference(chapter_title1));
            wake(new ScriptMethodReference(objective3_set));
            wake(new ScriptMethodReference(e9_cov_inf0_main));
            wake(new ScriptMethodReference(e9_cov_inf1_main));
            wake(new ScriptMethodReference(e9_cov_ghosts0_main));
            wake(new ScriptMethodReference(e9_cov_shadow0_main));
            wake(new ScriptMethodReference(e9_mars_warthog0_main));
            wake(new ScriptMethodReference(e9_cortana_dialog));
            wake(new ScriptMethodReference(e9_warthog_navpoint));
            wake(new ScriptMethodReference(e9_warthog_navpoint_kill));
            wake(new ScriptMethodReference(e9_music));
            await sleep_until(async () => this.g_e10_started);
            sleep_forever(new ScriptMethodReference(e9_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e9_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e9_cov_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e9_cov_shadow0_main));
            sleep_forever(new ScriptMethodReference(e9_mars_warthog0_main));
            sleep_forever(new ScriptMethodReference(e9_cortana_dialog));
            sleep_forever(new ScriptMethodReference(e9_retreat_checkpoint0));
            sleep_forever(new ScriptMethodReference(e9_retreat_checkpoint1));
            ai_disposable(e9_cov, true);
            await sleep_until(async () => this.g_e12_started);
            ai_erase(e9_mars);
            ai_erase(e9_cov);
        }

        [ScriptMethod(267, Lifecycle.Static)]
        public async Task test_beach_infantry()
        {
            switch_bsp(1);
            object_teleport(await this.player0(), e9_test);
            ai_place(e9_mars_test.Squad);
            if (!(this.g_e9_started))
            {
                wake(new ScriptMethodReference(e9_main));
            }

            if (!(this.g_e10_started))
            {
                wake(new ScriptMethodReference(e10_main));
            }

            if (!(this.g_e11_started))
            {
                wake(new ScriptMethodReference(e11_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
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
            return volume_test_objects(tv_e8_area, ai_actors(e8_cov_ghosts0));
        }

        [ScriptMethod(271, Lifecycle.CommandScript)]
        public async Task cs_e8_warthog_intro_scene()
        {
            cs_look_player(true);
            ai_play_line_at_player(this.ai_current_actor, "0510") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(272, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_warthog0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            object_cannot_take_damage(ai_actors(this.ai_current_squad));
            cs_go_by(GetReference<ISpatialPoint>("e8_mars_warthog0_entry/p0"), GetReference<ISpatialPoint>("e8_mars_warthog0_entry/p1"));
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U), ai_vehicle_get(this.ai_current_actor), 1.5F);
            cs_go_to(GetReference<ISpatialPoint>("e8_mars_warthog0_entry/p1"));
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U));
            object_can_take_damage(ai_actors(this.ai_current_squad));
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "warthog_p");
            await sleep(10);
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U), ai_vehicle_get(this.ai_current_actor), 1.5F);
            await sleep(8);
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U));
            await sleep(5);
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U), ai_vehicle_get(this.ai_current_actor), 1.5F);
            await sleep(10);
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4137555070U));
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "warthog_d");
            ai_vehicle_reserve_seat(ai_vehicle_get_from_starting_location(e8_mars_warthog0.warthog0), "warthog_d", true);
        }

        [ScriptMethod(273, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_phantom0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p1_1"), 1F);
            cs_face(true, GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p1_facing"));
            await sleep(60);
            this.g_e8_cov_phantom0_arrived = true;
            object_set_phantom_power(ai_vehicle_get(this.ai_current_actor), true);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_a");
            await sleep(90);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_b");
            await sleep(90);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_c");
            this.g_e8_cov_inf1_unloaded = true;
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get(this.ai_current_actor), false);
            await sleep(120);
            cs_face(false, GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p1_facing"));
            this.g_e8_cov_phantom0_leaving = true;
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p4"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_phantom0_entry/p5"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_ghosts0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e8_cov_ghosts0_entry/p0"));
            await sleep((short)random_range(0, 30));
            cs_vehicle_boost(false);
        }

        [ScriptMethod(275, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_inf0_no_assholes()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_abort_on_damage(true);
            await sleep((short)random_range(15, 45));
            ai_magically_see(this.ai_current_squad, e8_cov_phantom0.Squad);
            cs_aim_object(true, ai_vehicle_get(e8_cov_phantom0.phantom0));
            await sleep_until(async () => this.g_e8_cov_phantom0_arrived);
        }

        [ScriptMethod(276, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_inf2_patrol2()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_abort_on_damage(true);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("e8_patrol/p2")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e8_patrol/p3")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e8_patrol/p4")), 
                    async () => await sleep((short)random_range(30, 60)));
                return false;
            });
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_inf2_patrol1()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_abort_on_damage(true);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e8_patrol/p0"));
                cs_look(true, GetReference<ISpatialPoint>("e8_patrol/f0"));
                await sleep((short)random_range(30, 60));
                cs_look(false, GetReference<ISpatialPoint>("e8_patrol/f0"));
                cs_go_to(GetReference<ISpatialPoint>("e8_patrol/p1"));
                await sleep((short)random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(278, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_inf2_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_uninspected);
            cs_abort_on_damage(true);
            cs_look_object(true, ai_get_object(e8_cov_inf2.grunt0));
            sleep_forever();
        }

        [ScriptMethod(279, Lifecycle.Dormant)]
        public async Task e8_warthog_scene()
        {
            await sleep_until(async () => ai_scene("e8_warthog_intro_scene", new ScriptMethodReference(cs_e8_warthog_intro_scene), e8_mars_warthog0.warthog0) || (short)ai_living_count(e8_mars_warthog0.warthog0) <= 0, 5, this.two_minutes);
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task e8_cov_ghosts0_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e8_mars_warthog0.Squad) > 0, 15);
            await sleep(180);
            await sleep_until(async () => !(volume_test_objects(tv_e8_vehicle_spawn_area, players())));
            ai_place(e8_cov_ghosts0_0.Squad, 1);
            await sleep_until(async () => (short)ai_living_count(e8_cov_ghosts0) <= 0);
            await sleep_until(async () => !(volume_test_objects(tv_e8_vehicle_spawn_area, players())));
            ai_place(e8_cov_ghosts0_0.Squad, (short)pin(10F - (float)ai_living_count(covenant1), 0F, 2F));
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task e8_cov_phantom0_main()
        {
            ai_place(e8_cov_phantom0.Squad);
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task e8_cov_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e8_cov_inf2_begin, players()), 15);
            ai_place(e8_cov_inf2.Squad, (short)pin(10F - (float)ai_living_count(e8_cov), 1F, 4F));
            await sleep_until(async () => (short)ai_living_count(e8_cov_inf2.Squad) <= 0);
            game_save();
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task e8_cov_inf1_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e8_cov_phantom0.Squad) > 0);
            ai_place_in_vehicle(e8_cov_inf1.Squad, e8_cov_phantom0.Squad);
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task e8_cov_inf0_main()
        {
            ai_place(e8_cov_inf0.Squad);
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task e8_mars_warthog0_main()
        {
            await sleep_until(async () => this.g_e9_started || this.g_e8_cov_inf1_unloaded && (short)ai_living_count(e8_cov_inf1.Squad) <= 5 && (short)structure_bsp_index() == 1, 15, this.one_minute);
            await sleep_until(async () => (short)structure_bsp_index() == 1 && !(volume_test_objects(tv_e8_vehicle_spawn_area, players())));
            ai_place(e8_mars_warthog0.Squad);
            await sleep(3);
            this.g_e8_warthog = ai_vehicle_get_from_starting_location(e8_mars_warthog0.warthog0);
            wake(new ScriptMethodReference(e8_warthog_scene));
            await sleep(450);
            object_can_take_damage(ai_actors(e8_mars_warthog0.Squad));
            await sleep_until(async () => await this.player_in_vehicle() && (short)ai_living_count(e8_cov_inf1.Squad) <= 0 || this.g_e9_started);
            ai_vehicle_reserve_seat(ai_vehicle_get_from_starting_location(e8_mars_warthog0.warthog0), "warthog_d", false);
            if (!(this.g_e9_started))
            {
                wake(new ScriptMethodReference(e9_main));
            }
        }

        [ScriptMethod(286, Lifecycle.Dormant)]
        public async Task e8_mars_inf0_main()
        {
            ai_migrate(e7_mars_inf0.Squad, e8_mars_inf0.Squad);
            ai_renew(e8_mars_inf0.Squad);
            ai_disposable(e8_mars_inf0.Squad, false);
            await sleep_until(async () => (short)ai_spawn_count(e8_cov_inf0.Squad) > 0 && (short)ai_living_count(e8_cov_inf0.Squad) <= 0);
            cs_run_command_script(e8_mars_inf0.Squad, new ScriptMethodReference(cs_e8_mars_inf0_no_assholes));
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task e8_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e8_main_begin, players()), 15);
            this.g_e8_started = true;
            print("e8_main");
            data_mine_set_mission_segment("e8_hotel_exit");
            game_save();
            wake(new ScriptMethodReference(music_03a_04_stop));
            wake(new ScriptMethodReference(objective2_clear));
            wake(new ScriptMethodReference(e9_main));
            wake(new ScriptMethodReference(e10_main));
            wake(new ScriptMethodReference(e11_main));
            wake(new ScriptMethodReference(e8_mars_inf0_main));
            wake(new ScriptMethodReference(e8_cov_inf0_main));
            wake(new ScriptMethodReference(e8_cov_inf1_main));
            wake(new ScriptMethodReference(e8_cov_inf2_main));
            wake(new ScriptMethodReference(e8_cov_phantom0_main));
            wake(new ScriptMethodReference(e8_cov_ghosts0_main));
            wake(new ScriptMethodReference(e8_mars_warthog0_main));
            await sleep_until(async () => this.g_e9_started);
            ai_disposable(e8_cov, true);
            ai_disposable(e8_cov_phantom0.Squad, false);
            await sleep_until(async () => this.g_e10_started);
            sleep_forever(new ScriptMethodReference(e8_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e8_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e8_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e8_cov_inf2_main));
            sleep_forever(new ScriptMethodReference(e8_cov_phantom0_main));
            sleep_forever(new ScriptMethodReference(e8_cov_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e8_mars_warthog0_main));
            ai_disposable(e8_mars, true);
        }

        [ScriptMethod(288, Lifecycle.Static)]
        public async Task test_hotel_exit()
        {
            switch_bsp(1);
            object_teleport(await this.player0(), e8_test);
            ai_place(e8_mars_inf0.Squad);
            if (!(this.g_e8_started))
            {
                wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(289, Lifecycle.Static)]
        public async Task<bool> oes_e7_spring_ambush()
        {
            return volume_test_objects(tv_e7_cov_inf0_spring_ambush, ai_actors(e7_cov_inf0.Squad)) || (short)ai_combat_status(e7_cov_inf0.Squad) >= this.ai_combat_status_certain && (short)ai_spawn_count(e7_cov_inf0.Squad) > 0;
        }

        [ScriptMethod(290, Lifecycle.CommandScript)]
        public async Task cs_e7_hide()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_enable_moving(true);
            cs_look(true, GetReference<ISpatialPoint>("e7_hallway_ambush/f0"));
            cs_aim(true, GetReference<ISpatialPoint>("e7_hallway_ambush/f0"));
            await sleep_until(async () => await this.oes_e7_spring_ambush());
        }

        [ScriptMethod(291, Lifecycle.CommandScript)]
        public async Task cs_e7_cov_inf0_entry()
        {
            cs_ignore_obstacles(true);
            cs_look(true, GetReference<ISpatialPoint>("e7_hallway_ambush/cov1"));
            cs_aim(true, GetReference<ISpatialPoint>("e7_hallway_ambush/cov1"));
            cs_go_to(GetReference<ISpatialPoint>("e7_hallway_ambush/cov0"));
            cs_go_to(GetReference<ISpatialPoint>("e7_hallway_ambush/cov1"));
        }

        [ScriptMethod(292, Lifecycle.CommandScript)]
        public async Task cs_e7_abort()
        {
            cs_crouch(false);
        }

        [ScriptMethod(293, Lifecycle.CommandScript)]
        public async Task cs_e7_hotel_hall_scene0()
        {
            cs_play_line("0470");
        }

        [ScriptMethod(294, Lifecycle.CommandScript)]
        public async Task cs_e7_hotel_hall_scene1()
        {
            cs_play_line("0480");
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task e7_cov_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e7_cov_inf0_init, players()), 15);
            await sleep(15);
            object_create(e7_gun0);
            weapon_hold_trigger(GetReference<IWeaponReference>("e7_gun0"), 0, true);
            await sleep(10);
            weapon_hold_trigger(GetReference<IWeaponReference>("e7_gun0"), 0, false);
            await sleep(10);
            weapon_hold_trigger(GetReference<IWeaponReference>("e7_gun0"), 0, true);
            await sleep(10);
            weapon_hold_trigger(GetReference<IWeaponReference>("e7_gun0"), 0, false);
            ai_place(e7_cov_inf0.Squad);
            await sleep(20);
            weapon_hold_trigger(GetReference<IWeaponReference>("e7_gun0"), 0, true);
            await sleep(8);
            weapon_hold_trigger(GetReference<IWeaponReference>("e7_gun0"), 0, false);
            object_destroy(e7_gun0.Entity);
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_e7_hall, players()) || volume_test_objects(tv_e7_hall, ai_actors(e7_mars)) || (bool)player_flashlight_on())
                {
                    ai_set_blind(e7_cov_inf0.Squad, false);
                }
                else
                {
                    ai_set_blind(e7_cov_inf0.Squad, true);
                }

                return await this.oes_e7_spring_ambush();
            }, 2);
            cs_run_command_script(e7_cov_inf0.Squad, new ScriptMethodReference(cs_e7_abort));
            ai_set_blind(e7_cov_inf0.Squad, false);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task e7_mars_inf0_main()
        {
            ai_migrate(e6_mars_inf1.marine0, e7_mars_inf0.Squad);
            ai_migrate(e6_mars_inf1.marine1, e7_mars_inf0.Squad);
            ai_renew(e7_mars_inf0.Squad);
            ai_disposable(e7_mars_inf0.Squad, false);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e6_mars_inf0.Squad) <= 0 || (short)ai_living_count(e7_mars_inf0.Squad) >= 3)
                {
                    return 1F == 1F;
                }
                else
                {
                    print("migrated an actor");
                    ai_attach_units(unit(list_get(ai_actors(e6_mars_inf0.Squad), 0)), e7_mars_inf0.Squad);
                    return 1F == 0F;
                }
            });
            await sleep_until(async () => (short)ai_spawn_count(e7_cov_inf0.Squad) > 0, 10);
            cs_run_command_script(e7_mars_inf0.Squad, new ScriptMethodReference(cs_e7_hide));
            ai_disregard(ai_actors(e7_mars_inf0.Squad), true);
            ai_scene("e7_hotel_hall_scene0", new ScriptMethodReference(cs_e7_hotel_hall_scene0), e7_mars_inf0.Squad) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await sleep_until(async () => await this.oes_e7_spring_ambush(), 2);
            cs_run_command_script(e7_mars_inf0.Squad, new ScriptMethodReference(cs_e7_abort));
            ai_disregard(ai_actors(e7_mars_inf0.Squad), false);
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task e7_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e7_main_begin, players()), 15);
            this.g_e7_started = true;
            print("e7_main");
            data_mine_set_mission_segment("e7_hotel_hall");
            game_save();
            player_training_activate_flashlight();
            wake(new ScriptMethodReference(e7_mars_inf0_main));
            wake(new ScriptMethodReference(e7_cov_inf0_main));
            await sleep_until(async () => (short)structure_bsp_index() == 1, 1);
            camera_predict_resources_at_point(e8_prediction);
            ai_disposable(e7_cov, true);
            await sleep_until(async () => this.g_e9_started);
            sleep_forever(new ScriptMethodReference(e7_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e7_cov_inf0_main));
            await sleep_until(async () => this.g_e10_started);
            ai_erase(e7_mars);
            ai_erase(e7_cov);
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task test_hotel_hall()
        {
            object_teleport(await this.player0(), e7_test);
            ai_place(e7_mars_inf0.Squad);
            if (!(this.g_e7_started))
            {
                wake(new ScriptMethodReference(e7_main));
            }

            if (!(this.g_e8_started))
            {
                wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(299, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf1_odst()
        {
            await sleep_until(async () =>
            {
                cs_shoot(false, ai_get_object(this.ai_current_actor));
                await sleep(4);
                if (object_get_health(ai_get_object(this.ai_current_actor)) < 0.5F)
                {
                    cs_crouch(true);
                }

                await sleep_until(async () => object_get_health(ai_get_object(this.ai_current_actor)) >= 0.49F, 5);
                cs_crouch(false);
                await sleep(15);
                cs_shoot(true, list_get(ai_actors(e6_cov_inf0), (short)random_range(0, list_count(ai_actors(e6_cov_inf0)))));
                await sleep_until(async () => object_get_health(ai_get_object(this.ai_current_actor)) < 0.5F || (short)ai_living_count(e6_cov_inf0) <= 0, 5, 60);
                return (short)ai_living_count(e6_cov_inf0) <= 0;
            }, 15);
        }

        [ScriptMethod(300, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf1_cower()
        {
            cs_crouch(true);
            sleep_forever();
        }

        [ScriptMethod(301, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf0_1_cower()
        {
            cs_crouch(true);
            await sleep_until(async () => volume_test_objects(tv_e6_hotel_entrance, players()));
        }

        [ScriptMethod(302, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf1_abort()
        {
            await sleep(1);
        }

        [ScriptMethod(303, Lifecycle.CommandScript)]
        public async Task cs_e6_mars_inf1_lead()
        {
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_e6_hotel_vicinity, players()))
                {
                    cs_enable_looking(true);
                    cs_face_player(false);
                    cs_start_to(GetReference<ISpatialPoint>("e6_mars_inf1_lead/p1"));
                    await sleep_until(async () => !(volume_test_objects(tv_e6_hotel_vicinity, players())));
                }
                else
                {
                    cs_enable_looking(false);
                    cs_face_player(true);
                    cs_start_to(GetReference<ISpatialPoint>("e6_mars_inf1_lead/p0"));
                    await sleep_until(async () => volume_test_objects(tv_e6_hotel_vicinity, players()));
                }

                return false;
            }, 15);
        }

        [ScriptMethod(304, Lifecycle.CommandScript)]
        public async Task cs_e6_hotel_greeting_scene()
        {
            cs_enable_targeting(false);
            cs_look_player(true);
            cs_start_to(GetReference<ISpatialPoint>("e6_mars_inf1_lead/p0"));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 7F, 15);
            await sleep(ai_play_line_at_player(this.ai_current_actor, "8070"));
            cs_movement_mode(this.ai_movement_patrol);
            cs_look_player(false);
            cs_enable_looking(true);
            cs_approach_player(2F, 5F, 10F);
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0460"));
            wake(new ScriptMethodReference(music_03a_04_start));
            cs_movement_mode(this.ai_movement_combat);
            cs_go_to(GetReference<ISpatialPoint>("e6_mars_inf1_lead/p1"));
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_mars_inf1_lead));
        }

        [ScriptMethod(305, Lifecycle.CommandScript)]
        public async Task cs_e6_hotel_grunt_scene()
        {
            cs_play_line("0430");
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task cs_e6_hotel_rescue_scene()
        {
            cs_play_line("0450");
        }

        [ScriptMethod(307, Lifecycle.Static)]
        public async Task<bool> e6_cov_inf0_not_a_threat()
        {
            return (short)ai_living_count(e6_cov) <= 4 && (short)ai_fighting_count(e6_cov) <= 0;
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task e6_cov_inf1_main()
        {
            if (!(volume_test_objects(tv_e6_main_begin2, players())))
            {
                sleep_forever();
            }

            ai_place(e6_cov_inf1.Squad);
            await sleep_until(async () => ai_scene("e6_hotel_grunt_scene", new ScriptMethodReference(cs_e6_hotel_grunt_scene), e6_cov_inf1.Squad), 30, this.two_minutes);
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task e6_cov_inf0_main()
        {
            ai_place(e6_cov_inf0_2.Squad);
            ai_place(e6_cov_inf0_0.Squad, (short)pin(10F - (float)ai_living_count(covenant1), 1F, 2F));
            ai_place(e6_cov_inf0_1.Squad, (short)pin(10F - (float)ai_living_count(covenant1), 0F, 2F));
        }

        [ScriptMethod(310, Lifecycle.Dormant)]
        public async Task e6_mars_inf1_main()
        {
            ai_place(e6_mars_inf1.Squad);
            await sleep_until(async () => volume_test_objects(tv_e6_hotel_vicinity, players()) || await this.e6_cov_inf0_not_a_threat(), 10);
            await sleep_until(async () => ai_scene("e6_hotel_greeting_scene", new ScriptMethodReference(cs_e6_hotel_greeting_scene), e6_mars_inf1.marine0) || (short)ai_living_count(e6_mars_inf1.marine0) <= 0 || volume_test_objects(tv_e6_hotel_entrance, players()), 5);
            await sleep(20);
            cs_run_command_script(e6_mars_inf1.marine1, new ScriptMethodReference(cs_e6_mars_inf1_abort));
            game_save();
            await sleep_until(async () => volume_test_objects(tv_e6_hotel_entrance, players()), 15);
            cs_run_command_script(e6_mars_inf1.marine0, new ScriptMethodReference(cs_e6_mars_inf1_abort));
        }

        [ScriptMethod(311, Lifecycle.Dormant)]
        public async Task e6_mars_inf0_main()
        {
            ai_migrate(e5_mars_inf0.Squad, e6_mars_inf0.Squad);
            ai_renew(e6_mars_inf0.Squad);
            ai_disposable(e6_mars_inf0.Squad, false);
            await sleep_until(async () => (short)ai_spawn_count(e6_cov_inf0) > 0);
            ai_place(e6_mars_inf0_1.Squad, (short)(2 - (float)ai_living_count(e6_mars_inf0.Squad)));
            ai_migrate(e6_mars_inf0_1.Squad, e6_mars_inf0.Squad);
            ai_renew(e6_mars_inf0.Squad);
            ai_disposable(e6_mars_inf0.Squad, false);
        }

        [ScriptMethod(312, Lifecycle.Dormant)]
        public async Task e6_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_main_begin0, players()) || volume_test_objects(tv_e6_main_begin1, players()) || volume_test_objects(tv_e6_main_begin2, players()), 15);
            this.g_e6_started = true;
            print("e6_main");
            data_mine_set_mission_segment("e6_hotel_entrance");
            game_save();
            wake(new ScriptMethodReference(music_03a_03_stop));
            wake(new ScriptMethodReference(e7_main));
            wake(new ScriptMethodReference(e6_mars_inf0_main));
            wake(new ScriptMethodReference(e6_mars_inf1_main));
            wake(new ScriptMethodReference(e6_cov_inf0_main));
            wake(new ScriptMethodReference(e6_cov_inf1_main));
            await sleep_until(async () => this.g_e7_started);
            ai_disposable(e6_cov, true);
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            sleep_forever(new ScriptMethodReference(e6_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e6_mars_inf1_main));
            sleep_forever(new ScriptMethodReference(e6_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e6_cov_inf1_main));
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            ai_erase(e6_mars);
            ai_erase(e6_cov);
        }

        [ScriptMethod(313, Lifecycle.Static)]
        public async Task test_hotel_entrance()
        {
            object_teleport(await this.player0(), e6_test);
            ai_place(e6_mars_inf0.Squad);
            if (!(this.g_e6_started))
            {
                wake(new ScriptMethodReference(e6_main));
            }

            if (!(this.g_e8_started))
            {
                wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(314, Lifecycle.Static)]
        public async Task e5b_reset_player()
        {
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
            object_teleport(await this.player0(), e5b_return);
            unit_add_equipment(unit(await this.player0()), wimpy, true, true);
            await sleep(5);
            fade_in(1F, 1F, 1F, 5);
            await sleep(5);
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task e5b_resetter()
        {
            await sleep_until(async () =>
            {
                if (!(volume_test_object(tv_e5b_bounds, await this.player0())))
                {
                    await this.e5b_reset_player();
                }

                return this.g_e5b_finished;
            });
        }

        [ScriptMethod(316, Lifecycle.Dormant)]
        public async Task e5b_inf0_main()
        {
            ai_place(e5b_cov_inf0.Squad, 1);
            ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await sleep(90);
            ai_set_active_camo(e5b_cov_inf0.Squad, false);
            ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await sleep_until(async () => (short)ai_living_count(e5b_cov_inf0.Squad) <= 0);
            garbage_collect_now();
            ai_place(e5b_cov_inf0.Squad, 2);
            ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await sleep(90);
            ai_set_active_camo(e5b_cov_inf0.Squad, false);
            ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await sleep_until(async () => (short)ai_living_count(e5b_cov_inf0.Squad) <= 0);
            garbage_collect_now();
            ai_place(e5b_cov_inf0.Squad, 3);
            ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await sleep(90);
            ai_set_active_camo(e5b_cov_inf0.Squad, false);
            ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await sleep_until(async () => (short)ai_living_count(e5b_cov_inf0.Squad) <= 0);
            garbage_collect_now();
            ai_place(e5b_cov_inf0.Squad, 4);
            ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await sleep(90);
            ai_set_active_camo(e5b_cov_inf0.Squad, false);
            ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await sleep_until(async () => (short)ai_living_count(e5b_cov_inf0.Squad) <= 0);
            garbage_collect_now();
            ai_place(e5b_cov_inf0.Squad, 5);
            ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await sleep(90);
            ai_set_active_camo(e5b_cov_inf0.Squad, false);
            ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await sleep_until(async () => (short)ai_living_count(e5b_cov_inf0.Squad) <= 0);
            garbage_collect_now();
            ai_place(e5b_cov_inf0.Squad, 6);
            ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await sleep(90);
            ai_set_active_camo(e5b_cov_inf0.Squad, false);
            ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await sleep_until(async () => (short)ai_living_count(e5b_cov_inf0.Squad) <= 0);
            garbage_collect_now();
            ai_place(e5b_cov_inf0.Squad, 7);
            ai_set_active_camo(e5b_cov_inf0.Squad, true);
            await sleep(90);
            ai_set_active_camo(e5b_cov_inf0.Squad, false);
            ai_magically_see_object(e5b_cov_inf0.Squad, await this.player0());
            await sleep_until(async () => (short)ai_living_count(e5b_cov_inf0.Squad) <= 0);
            garbage_collect_now();
            this.g_e5b_finished = true;
            ice_cream_flavor_stock(5);
        }

        [ScriptMethod(317, Lifecycle.Dormant)]
        public async Task e5b_main()
        {
            if ((bool)game_is_cooperative() || !(await this.difficulty_legendary()) || !(0 == (short)random_range(0, 7)))
            {
                sleep_forever();
            }

            await sleep_until(async () => volume_test_objects(tv_e5b_main, players()), 15);
            game_save_cancel();
            game_save();
            await sleep_until(async () => !((bool)game_saving()), 1);
            if (!((bool)game_reverted()))
            {
                this.g_e5b_started = true;
                object_create(key);
                await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4183693118U)) && volume_test_object(tv_e5b_main, await this.player0()), 5);
                await sleep(30);
                await this.e5b_reset_player();
                wake(new ScriptMethodReference(e5b_inf0_main));
                wake(new ScriptMethodReference(e5b_resetter));
            }
        }

        [ScriptMethod(318, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_inf0_guard0()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_aim(true, GetReference<ISpatialPoint>("e5_cov_ambush/look0")), 
                    async () => await sleep((short)random_range(100, 150)), 
                    async () => cs_aim(true, GetReference<ISpatialPoint>("e5_cov_ambush/look1")), 
                    async () => await sleep((short)random_range(45, 90)), 
                    async () => cs_aim(true, GetReference<ISpatialPoint>("e5_cov_ambush/look2")), 
                    async () => await sleep((short)random_range(45, 90)));
                return false;
            }, 5);
        }

        [ScriptMethod(319, Lifecycle.CommandScript)]
        public async Task cs_e5_cov_inf0_wait()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_crouch(true);
            await sleep_until(async () => (bool)ai_trigger_test("e5_cov_inf0_ambush_sprung", this.ai_current_squad), 5);
        }

        [ScriptMethod(320, Lifecycle.Static)]
        public async Task<bool> e5_cov_inf0_ambush_trigger()
        {
            return volume_test_objects(tv_e5_ambush_trigger0, players()) || volume_test_objects(tv_e5_ambush_trigger1, players()) || volume_test_objects(tv_e5_ambush_trigger2, players());
        }

        [ScriptMethod(321, Lifecycle.Static)]
        public async Task<bool> e5_cov_inf1_done()
        {
            return this.g_e5_cov_inf1_done == true;
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task e5_cov_inf4_main()
        {
            ai_migrate(e4_cov_inf1, e5_cov_inf4.Squad);
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task e5_cov_inf3_main()
        {
            if (!(await this.difficulty_legendary()))
            {
                sleep_forever();
            }

            await sleep_until(async () => volume_test_objects(tv_e5_player_advanced, players()));
            if ((short)ai_living_count(covenant1) < 15)
            {
                ai_place(e5_cov_inf3.Squad);
            }
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task e5_cov_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_player_advanced, players()));
            if ((short)ai_living_count(covenant1) < 15)
            {
                ai_place(e5_cov_inf2.Squad);
            }
        }

        [ScriptMethod(325, Lifecycle.Static)]
        public async Task e5_cov_inf1_0_spawn()
        {
            print("e5_cov_inf1_0_spawn");
            if ((short)ai_living_count(e5_cov_inf1) <= 1 && !(volume_test_objects(tv_e5_cov_inf1_unsafe0, players())) && !(volume_test_objects(tv_e5_cov_inf1_done, players())))
            {
                ai_place(e5_cov_inf1_0.Squad, (short)pin(7F - (float)ai_living_count(e5_cov), 0F, 4F));
                ai_set_orders(e5_cov_inf1_0.Squad, e5_cov_inf1_0_init);
            }

            await sleep_until(async () => (short)ai_living_count(e5_cov_inf1) <= 1 || volume_test_objects(tv_e5_cov_inf1_done, players()));
            await sleep_until(async () => volume_test_objects(tv_e5_cov_inf1_done, players()), 30, this.g_e5_cov_inf1_spawn_delay);
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task e5_cov_inf1_1_spawn()
        {
            print("e5_cov_inf1_1_spawn");
            if ((short)ai_living_count(e5_cov_inf1) <= 1 && !(volume_test_objects(tv_e5_cov_inf1_unsafe1, players())) && !(volume_test_objects(tv_e5_cov_inf1_done, players())))
            {
                ai_place(e5_cov_inf1_1.Squad, (short)pin(7F - (float)ai_living_count(e5_cov), 0F, 4F));
                ai_set_orders(e5_cov_inf1_1.Squad, e5_cov_inf1_1_init);
            }

            await sleep_until(async () => (short)ai_living_count(e5_cov_inf1) <= 1 || volume_test_objects(tv_e5_cov_inf1_done, players()));
            await sleep_until(async () => volume_test_objects(tv_e5_cov_inf1_done, players()), 30, this.g_e5_cov_inf1_spawn_delay);
        }

        [ScriptMethod(327, Lifecycle.Dormant)]
        public async Task e5_cov_inf1_main()
        {
            ai_migrate(e4_cov_inf2.Squad, e5_cov_inf1_1.Squad);
            await sleep_until(async () => volume_test_objects(tv_e5_advanced0, players()), 15);
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

            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_e5_main_begin0, players()))
                {
                    await this.e5_cov_inf1_0_spawn();
                }
                else
                {
                    await this.e5_cov_inf1_1_spawn();
                }

                if (!(volume_test_objects(tv_e5_main_begin0, players())))
                {
                    await this.e5_cov_inf1_0_spawn();
                }
                else
                {
                    await this.e5_cov_inf1_1_spawn();
                }

                if (!(this.g_e5b_started))
                {
                    game_save();
                }

                return (float)ai_spawn_count(e5_cov_inf1_0.Squad) + (float)ai_spawn_count(e5_cov_inf1_1.Squad) >= this.g_e5_cov_inf1_max || volume_test_objects(tv_e5_cov_inf1_done, players());
            });
            this.g_e5_cov_inf1_done = true;
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task e5_cov_inf0_main()
        {
            ai_place(e5_cov_inf0_0.sniper0);
            await sleep_until(async () => (short)ai_living_count(e5_cov_inf0) < 1 || volume_test_objects(tv_e5_advanced1, players()));
            if ((short)ai_living_count(covenant1) < 15)
            {
                ai_place(e5_cov_inf0_0.sniper1);
            }

            await sleep_until(async () => (short)ai_living_count(e5_cov_inf0) < 2 || volume_test_objects(tv_e5_advanced1, players()));
            if ((short)ai_living_count(covenant1) < 15)
            {
                ai_place(e5_cov_inf0_0.sniper2);
            }

            await sleep_until(async () => (short)ai_living_count(e5_cov_inf0) < 2 || volume_test_objects(tv_e5_advanced1, players()));
            if ((short)ai_living_count(covenant1) < 15)
            {
                ai_place(e5_cov_inf0_0.sniper3);
            }
        }

        [ScriptMethod(329, Lifecycle.Dormant)]
        public async Task e5_mars_inf0_main()
        {
            ai_migrate(e4_mars_inf0.Squad, e5_mars_inf0.Squad);
            ai_renew(e5_mars_inf0.Squad);
            ai_disposable(e5_mars_inf0.Squad, false);
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task e5_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_main_begin0, players()) || volume_test_objects(tv_e5_main_begin1, players()) || volume_test_objects(tv_e5_main_begin2, players()));
            this.g_e5_started = true;
            print("e5_main");
            data_mine_set_mission_segment("e5_neighborhood");
            if (!(this.g_e5b_started))
            {
                game_save();
            }

            wake(new ScriptMethodReference(music_03a_03_stop));
            wake(new ScriptMethodReference(e5_mars_inf0_main));
            wake(new ScriptMethodReference(e5_cov_inf0_main));
            wake(new ScriptMethodReference(e5_cov_inf1_main));
            wake(new ScriptMethodReference(e5_cov_inf2_main));
            wake(new ScriptMethodReference(e5_cov_inf3_main));
            wake(new ScriptMethodReference(e5_cov_inf4_main));
            await sleep_until(async () => this.g_e6_started);
            ai_disposable(e5_cov, true);
            await sleep_until(async () => (short)structure_bsp_index() == 1 || this.g_e5b_started);
            sleep_forever(new ScriptMethodReference(e5_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e5_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e5_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e5_cov_inf2_main));
            sleep_forever(new ScriptMethodReference(e5_cov_inf3_main));
            await sleep_until(async () => (short)structure_bsp_index() == 1 || this.g_e5b_started);
            ai_erase(e5_mars);
            ai_erase(e5_cov);
        }

        [ScriptMethod(331, Lifecycle.Static)]
        public async Task test_neighborhood()
        {
            object_teleport(await this.player0(), e5_test);
            ai_place(e5_mars_inf0.Squad);
            if (!(this.g_e5_started))
            {
                wake(new ScriptMethodReference(e5_main));
            }

            if (!(this.g_e6_started))
            {
                wake(new ScriptMethodReference(e6_main));
            }

            if (!(this.g_e8_started))
            {
                wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf0_0_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e4_patrol/p2"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e4_patrol/f0"));
                await sleep((short)random_range(60, 90));
                cs_look(false, GetReference<ISpatialPoint>("e4_patrol/f0"));
                cs_enable_looking(true);
                cs_go_to(GetReference<ISpatialPoint>("e4_patrol/p3"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e4_patrol/f0"));
                await sleep((short)random_range(60, 90));
                cs_look(false, GetReference<ISpatialPoint>("e4_patrol/f0"));
                cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf0_0_patrol1()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e4_patrol/p4"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e4_patrol/f0"));
                await sleep((short)random_range(60, 90));
                cs_look(false, GetReference<ISpatialPoint>("e4_patrol/f0"));
                cs_enable_looking(true);
                cs_go_to(GetReference<ISpatialPoint>("e4_patrol/p5"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e4_patrol/f0"));
                await sleep((short)random_range(60, 90));
                cs_look(false, GetReference<ISpatialPoint>("e4_patrol/f0"));
                cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf0_2_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e4_patrol/p0"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e4_patrol/f0"));
                await sleep((short)random_range(60, 90));
                cs_look(false, GetReference<ISpatialPoint>("e4_patrol/f0"));
                cs_enable_looking(true);
                cs_go_to(GetReference<ISpatialPoint>("e4_patrol/p1"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e4_patrol/f0"));
                await sleep((short)random_range(60, 90));
                cs_look(false, GetReference<ISpatialPoint>("e4_patrol/f0"));
                cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(335, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf0_1_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e4_patrol/p6"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e4_patrol/f0"));
                await sleep((short)random_range(60, 90));
                cs_look(false, GetReference<ISpatialPoint>("e4_patrol/f0"));
                cs_enable_looking(true);
                cs_go_to(GetReference<ISpatialPoint>("e4_patrol/p7"));
                cs_enable_looking(false);
                cs_look(true, GetReference<ISpatialPoint>("e4_patrol/f1"));
                await sleep((short)random_range(45, 60));
                cs_look(false, GetReference<ISpatialPoint>("e4_patrol/f1"));
                cs_enable_looking(true);
                return false;
            });
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task cs_e4_cov_inf2_lurk()
        {
            cs_crouch(true);
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_squad) >= this.ai_combat_status_clear_los || volume_test_objects(tv_e4_cov_inf2_begin, players()), 15);
        }

        [ScriptMethod(337, Lifecycle.Dormant)]
        public async Task e4_cov_snipers0_main()
        {
            ai_place(e4_cov_snipers0_0.Squad);
            ai_place(e4_cov_snipers0_1.Squad);
            await sleep_until(async () => (short)ai_living_count(e4_cov_snipers0) < 3 || volume_test_objects(tv_e4_cov_inf1_main_begin, players()));
            if ((short)ai_living_count(e4_cov_snipers0) < 3)
            {
                ai_place(e4_cov_snipers0_2.sniper0);
            }

            await sleep_until(async () => (short)ai_living_count(e4_cov_snipers0) < 3 || volume_test_objects(tv_e4_player_moved_up, players()));
            await sleep_until(async () => (short)ai_living_count(e4_cov_snipers0) < 3 || volume_test_objects(tv_e4_player_moved_up, players()));
            if ((short)ai_living_count(e4_cov_snipers0) < 3)
            {
                ai_place(e4_cov_snipers0_2.sniper1);
            }

            await sleep_until(async () => (short)ai_living_count(e4_cov_snipers0) < 3 || volume_test_objects(tv_e4_player_moved_up, players()));
            if ((short)ai_living_count(e4_cov_snipers0) < 3)
            {
                ai_place(e4_cov_snipers0_2.sniper2);
            }

            await sleep_until(async () => (short)ai_living_count(e4_cov_snipers0) <= 0);
            game_save();
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task e4_cov_inf2_main()
        {
            if (await this.difficulty_normal())
            {
                sleep_forever();
            }

            await sleep_until(async () => volume_test_objects(tv_e4_player_moved_up, players()), 15);
            if (await this.difficulty_legendary() && (short)random_range(0, 3) == 0)
            {
                ai_place(e4_cov_inf2.Squad, (short)pin(8F - (float)ai_living_count(e4_cov), 1F, 3F));
            }
            else
            {
                ai_place(e4_cov_inf2.Squad, (short)pin(8F - (float)ai_living_count(e4_cov), 1F, 2F));
            }

            await sleep_until(async () => (short)ai_living_count(e4_cov_inf2.Squad) <= 0 || this.g_e5_started);
            game_save();
        }

        [ScriptMethod(339, Lifecycle.Dormant)]
        public async Task e4_cov_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_player_moved_up, players()) || (short)ai_living_count(e4_cov_snipers0_0.Squad) <= 1, 15);
            ai_place(e4_cov_inf1_0.Squad, (short)pin(7F - (float)ai_living_count(e4_cov), 2F, 4F));
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e4_cov) < 6 && !(volume_test_objects(tv_e4_end_of_street, players())))
                {
                    ai_place(e4_cov_inf1_0.Squad, 2);
                }

                return (short)ai_spawn_count(e4_cov_inf1) >= 8 || volume_test_objects(tv_e4_end_of_street, players());
            }, 90);
        }

        [ScriptMethod(340, Lifecycle.Dormant)]
        public async Task e4_cov_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_player_moved_up, players()) || (short)ai_living_count(e4_cov_snipers0_1.Squad) <= 0 && (short)ai_living_count(e4_cov_snipers0_2.Squad) <= 1, 15);
            ai_place(e4_cov_inf0_0.Squad, (short)pin(8F - (float)ai_living_count(e4_cov), 0F, 2F));
            await sleep_until(async () => volume_test_objects(tv_e4_player_moved_up, players()) || (short)ai_living_count(e4_cov_inf0_0.Squad) <= 0, 15);
            if (!(volume_test_objects(tv_e4_player_moved_up, players())))
            {
                ai_place(e4_cov_inf0_1.Squad, (short)pin(8F - (float)ai_living_count(e4_cov), 0F, 2F));
            }
        }

        [ScriptMethod(341, Lifecycle.Dormant)]
        public async Task e4_mars_inf0_main()
        {
            ai_migrate(e3_mars_inf0.Squad, e4_mars_inf0.Squad);
            ai_migrate(e3_mars_inf1.Squad, e4_mars_inf0.Squad);
            ai_renew(e4_mars_inf0.Squad);
            ai_disposable(e4_mars_inf0.Squad, false);
        }

        [ScriptMethod(342, Lifecycle.Dormant)]
        public async Task e4_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_main_begin, players()));
            this.g_e4_started = true;
            print("e4_main");
            data_mine_set_mission_segment("e4_sniper_alley");
            game_save();
            wake(new ScriptMethodReference(music_03a_03_start));
            wake(new ScriptMethodReference(e5_main));
            wake(new ScriptMethodReference(e5b_main));
            wake(new ScriptMethodReference(objective1_clear));
            wake(new ScriptMethodReference(objective2_set));
            wake(new ScriptMethodReference(e4_mars_inf0_main));
            wake(new ScriptMethodReference(e4_cov_inf0_main));
            wake(new ScriptMethodReference(e4_cov_inf1_main));
            wake(new ScriptMethodReference(e4_cov_inf2_main));
            wake(new ScriptMethodReference(e4_cov_snipers0_main));
            await sleep_until(async () => this.g_e5_started || this.g_e6_started);
            sleep_forever(new ScriptMethodReference(e4_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e4_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e4_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e4_cov_snipers0_main));
            ai_disposable(e4_cov, true);
        }

        [ScriptMethod(343, Lifecycle.Static)]
        public async Task test_sniper_alley()
        {
            object_teleport(await this.player0(), e4_test);
            ai_place(e4_mars_inf0.Squad);
            if (!(this.g_e4_started))
            {
                wake(new ScriptMethodReference(e4_main));
            }

            if (!(this.g_e6_started))
            {
                wake(new ScriptMethodReference(e6_main));
            }

            if (!(this.g_e8_started))
            {
                wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task cs_e3_sniper_intro_scene()
        {
            ai_play_line(this.ai_current_actor, "0370") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task e3_mars_sniper_scene()
        {
            await sleep_until(async () => ai_scene("e3_sniper_intro_scene", new ScriptMethodReference(cs_e3_sniper_intro_scene), e3_mars), 30, 450);
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_inf0_1_intro()
        {
            cs_crouch(true);
            cs_face(true, GetReference<ISpatialPoint>("e3_cov_sniper/p0"));
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_certain, 10);
            await sleep(15);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e3_cov_sniper/p0"));
            wake(new ScriptMethodReference(e3_mars_sniper_scene));
            await sleep(30);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e3_cov_sniper/p1"));
            await sleep(90);
        }

        [ScriptMethod(347, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_inf0_1_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_looking(false);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_look(true, GetReference<ISpatialPoint>("e3_patrol/f0")), 
                    async () => await sleep((short)random_range(60, 90)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("e3_patrol/f1")), 
                    async () => await sleep((short)random_range(60, 90)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("e3_patrol/f2")), 
                    async () => await sleep((short)random_range(60, 90)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("e3_patrol/f3")), 
                    async () => await sleep((short)random_range(60, 90)));
                return false;
            });
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_pelican0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_face(true, GetReference<ISpatialPoint>("e3_mars_evac/p2"));
            cs_fly_to(GetReference<ISpatialPoint>("e3_mars_evac/p0"));
            this.g_e3_mars_pelican0_arrived = true;
            await sleep(45);
            cs_fly_to(GetReference<ISpatialPoint>("e3_mars_evac/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("e3_mars_evac/p3"), 1F);
            this.g_e3_mars_pelican0_landed = true;
            sleep_forever();
        }

        [ScriptMethod(349, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_pelican0_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("e3_mars_evac/p4"), 1F);
            await sleep(30);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("e3_mars_evac/p2"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(350, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_johnson_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e3_mars_evac/johnson0"));
            cs_enable_targeting(true);
            await sleep_until(async () => this.g_e3_johnson_should_load, 5);
            cs_movement_mode(this.ai_movement_patrol);
            cs_face_object(true, ai_get_object(e3_mars_pelican0.pelican0));
            cs_go_to(GetReference<ISpatialPoint>("e3_mars_evac/johnson1"));
            cs_face_player(true);
            await sleep_until(async () => objects_can_see_object(ai_get_object(this.ai_current_actor), await this.player0(), 10F) || (bool)game_is_cooperative() && objects_can_see_object(ai_get_object(this.ai_current_actor), await this.player1(), 10F), 1);
            await sleep_until(async () => objects_can_see_object(players(), ai_get_object(this.ai_current_actor), 15F), 2, 30);
            await sleep(20);
            ai_play_line_at_player(e3_mars_johnson.Squad, "0970") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(20);
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3834970911U), "combat:rifle:wave", true);
            await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
        }

        [ScriptMethod(351, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_johnson_slam()
        {
            cs_go_to(GetReference<ISpatialPoint>("e3_mars_evac/johnson1"));
            ai_vehicle_enter_immediate(this.ai_current_actor, ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e");
        }

        [ScriptMethod(352, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_inf1_ride()
        {
            await sleep_until(async () => this.g_e3_mars_pelican0_landed, 5);
            ai_vehicle_exit(this.ai_current_actor);
            cs_enable_targeting(true);
            cs_enable_moving(true);
            await sleep(60);
            if (this.g_e4_started)
            {
                ai_migrate(this.ai_current_actor, e4_mars_inf0.Squad);
            }
            else
            {
                ai_migrate(this.ai_current_actor, e3_mars_inf0.Squad);
            }
        }

        [ScriptMethod(353, Lifecycle.CommandScript)]
        public async Task cs_e3_mars_johnson_teleport()
        {
            cs_teleport(GetReference<ISpatialPoint>("e3_mars_evac/johnson_teleport0"), GetReference<ISpatialPoint>("e3_mars_evac/johnson_teleport1"));
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
            return this.g_e4_started || (short)ai_spawn_count(e3_cov_inf0_0.Squad) >= this.g_e3_cov_inf0_0_limit && (short)ai_living_count(e3_cov_inf0_0.Squad) <= 4;
        }

        [ScriptMethod(357, Lifecycle.Dormant)]
        public async Task e3_cov_inf0_main()
        {
            ai_place(e3_cov_inf0_0.Squad);
            ai_place(e3_cov_inf0_1.Squad);
            await sleep_until(async () => (short)ai_living_count(e3_cov_inf0) <= 2 || volume_test_objects(tv_e3_crossing_street, players()), 15);
            ai_place(e3_cov_inf0_2.Squad);
        }

        [ScriptMethod(358, Lifecycle.Dormant)]
        public async Task e3_mars_pelican0_main()
        {
            await sleep_until(async () => this.g_e4_started || volume_test_objects(tv_e3_mars_pelican0_begin, players()) || (short)ai_spawn_count(e3_cov_inf0) > 0 && (short)ai_living_count(e3_cov_inf0) <= 2, 30, this.two_minutes);
            ai_place(e3_mars_pelican0.Squad);
            cs_run_command_script(e3_mars_pelican0.pelican0, new ScriptMethodReference(cs_e3_mars_pelican0_entry));
            await sleep_until(async () => this.g_e3_johnson_in_pelican, 5);
            cs_run_command_script(e3_mars_pelican0.pelican0, new ScriptMethodReference(cs_e3_mars_pelican0_exit));
        }

        [ScriptMethod(359, Lifecycle.Dormant)]
        public async Task e3_mars_inf1_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e3_mars_pelican0.Squad) > 0);
            ai_place(e3_mars_inf1.Squad, (short)pin(3F - (float)ai_living_count(e3_mars_inf0.Squad), 0F, 3F));
            ai_vehicle_enter_immediate(e3_mars_inf1.Squad, ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_p_r");
        }

        [ScriptMethod(360, Lifecycle.Dormant)]
        public async Task e3_mars_inf0_main()
        {
            await sleep_until(async () => (short)ai_living_count(e2_cov_hunters0.Squad) <= 0 || volume_test_objects(tv_e3_crossing_street, players()), 30, this.one_minute);
            ai_migrate(e2_mars_inf0.Squad, e3_mars_inf0.Squad);
            ai_renew(e3_mars_inf0.Squad);
            ai_disposable(e3_mars_inf0.Squad, false);
            await sleep_until(async () => this.g_e3_johnson_in_pelican);
            ai_migrate(e3_mars_johnson.Squad, e3_mars_inf0.Squad);
            ai_disposable(e3_mars_inf0.Squad, false);
        }

        [ScriptMethod(361, Lifecycle.Dormant)]
        public async Task e3_mars_johnson_main()
        {
            await sleep_until(async () => (short)ai_living_count(e2_cov_hunters0.Squad) <= 0 || volume_test_objects(tv_e3_crossing_street, players()), 30, this.one_minute);
            ai_migrate(e1_mars_johnson.Squad, e3_mars_johnson.Squad);
            ai_migrate(e2_mars_johnson.Squad, e3_mars_johnson.Squad);
            ai_disposable(e3_mars_johnson.Squad, false);
            await sleep_until(async () => (short)ai_spawn_count(e3_mars_pelican0.Squad) > 0, 15);
            if (!(volume_test_objects(tv_e3_johnson_required, ai_actors(e3_mars_johnson.Squad))))
            {
                await sleep_until(async () => !(volume_test_objects(tv_e3_johnson_teleport_unsafe, players())));
                cs_run_command_script(e3_mars_johnson.Squad, new ScriptMethodReference(cs_e3_mars_johnson_teleport));
            }

            await sleep_until(async () => this.g_e3_mars_pelican0_arrived, 15);
            wake(new ScriptMethodReference(objective1_clear));
            cs_run_command_script(e3_mars_johnson.Squad, new ScriptMethodReference(cs_e3_mars_johnson_exit));
            await sleep(ai_play_line_on_object(default(IGameObject), "0940"));
            await sleep(20);
            await sleep(ai_play_line(e3_mars_johnson.Squad, "0950"));
            await sleep(15);
            await sleep(ai_play_line_on_object(default(IGameObject), "0960"));
            this.g_e3_johnson_should_load = true;
            await sleep_until(async () => !(cs_command_script_queued(e3_mars_johnson.Squad, new ScriptMethodReference(cs_e3_mars_johnson_exit))), 1);
            ai_vehicle_enter(e3_mars_johnson.Squad, ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e");
            await sleep_until(async () => vehicle_test_seat_list(ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e", ai_actors(e3_mars_pelican0.Squad)), 30, 300);
            if (!(vehicle_test_seat_list(ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e", ai_actors(e3_mars_pelican0.Squad))))
            {
                cs_run_command_script(e3_mars_johnson.Squad, new ScriptMethodReference(cs_e3_mars_johnson_slam));
            }

            await sleep_until(async () => vehicle_test_seat_list(ai_vehicle_get(e3_mars_pelican0.pelican0), "pelican_e", ai_actors(e3_mars_pelican0.Squad)), 30, this._30_seconds);
            this.g_e3_johnson_in_pelican = true;
            game_save();
            wake(new ScriptMethodReference(objective2_set));
            wake(new ScriptMethodReference(music_03a_03_start));
        }

        [ScriptMethod(362, Lifecycle.Dormant)]
        public async Task e3_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e3_main_begin0, players()) || volume_test_objects(tv_e3_main_begin1, players()));
            this.g_e3_started = true;
            print("e3_main");
            data_mine_set_mission_segment("e3_highway_underpass");
            game_save();
            wake(new ScriptMethodReference(music_03a_01_stop));
            wake(new ScriptMethodReference(music_03a_02_stop));
            wake(new ScriptMethodReference(objective1_set));
            wake(new ScriptMethodReference(e4_main));
            wake(new ScriptMethodReference(e6_main));
            wake(new ScriptMethodReference(e3_mars_inf0_main));
            wake(new ScriptMethodReference(e3_mars_inf1_main));
            wake(new ScriptMethodReference(e3_mars_johnson_main));
            wake(new ScriptMethodReference(e3_mars_pelican0_main));
            wake(new ScriptMethodReference(e3_cov_inf0_main));
            await sleep_until(async () => this.g_e4_started || this.g_e6_started);
            sleep_forever(new ScriptMethodReference(e3_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e3_mars_inf1_main));
            sleep_forever(new ScriptMethodReference(e3_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e3_mars_sniper_scene));
            ai_disposable(e3_cov, true);
        }

        [ScriptMethod(363, Lifecycle.Static)]
        public async Task test_marching_infantry()
        {
            object_teleport(await this.player0(), e3_test);
            ai_place(e3_mars_inf0.Squad);
            ai_place(e3_mars_johnson.Squad);
            object_cannot_take_damage(ai_actors(e3_mars_johnson.Squad));
            if (!(this.g_e3_started))
            {
                wake(new ScriptMethodReference(e3_main));
            }

            if (!(this.g_e8_started))
            {
                wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(364, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_hunters0_taunt()
        {
            this.g_e2_cov_hunters0_active = true;
            cs_abort_on_damage(true);
            if ((float)ai_strength(this.ai_current_actor) > 0.98F)
            {
                custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\hunter\\hunter", 4214692103U), "combat:unarmed:shakefist", true);
                await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
            }
        }

        [ScriptMethod(365, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_hunters0_0_entry()
        {
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e2_cov_hunters0_taunt));
            await sleep(220);
            cs_force_combat_status(2);
            cs_ignore_obstacles(true);
            cs_abort_on_damage(true);
            cs_look_player(true);
            cs_go_to(GetReference<ISpatialPoint>("e2_cov_hunters0_entry/p0_1"));
            cs_face_player(true);
            cs_movement_mode(this.ai_movement_combat);
            await sleep_until(async () => await this.player_in_vehicle() || objects_distance_to_object(ai_actors(this.ai_current_squad), await this.player0()) <= 3F || (bool)game_is_cooperative() && objects_distance_to_object(ai_actors(this.ai_current_squad), await this.player1()) <= 3F || (bool)ai_trigger_test("generic_player_fired", this.ai_current_squad) && objects_can_see_flag(players(), e2_cov_hunters0_entry, 20F) || (float)ai_strength(this.ai_current_squad) < 0.98F, 5, 120);
            if (!(await this.player_in_vehicle() || objects_distance_to_object(ai_actors(this.ai_current_squad), await this.player0()) <= 3F || (bool)game_is_cooperative() && objects_distance_to_object(ai_actors(this.ai_current_squad), await this.player1()) <= 3F || (bool)ai_trigger_test("generic_player_fired", this.ai_current_squad) && objects_can_see_flag(players(), e2_cov_hunters0_entry, 20F) || (float)ai_strength(this.ai_current_squad) < 0.98F))
            {
                custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\hunter\\hunter", 4214692103U), "combat:unarmed:taunt", true);
                await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
            }

            await sleep_until(async () => await this.player_in_vehicle() || objects_distance_to_object(ai_actors(this.ai_current_squad), await this.player0()) <= 4F || (bool)game_is_cooperative() && objects_distance_to_object(ai_actors(this.ai_current_squad), await this.player1()) <= 4F || (bool)ai_trigger_test("generic_player_fired", this.ai_current_squad) && objects_can_see_flag(players(), e2_cov_hunters0_entry, 20F) || (float)ai_strength(this.ai_current_squad) < 0.98F, 5, 120);
        }

        [ScriptMethod(366, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_hunters0_1_entry()
        {
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e2_cov_hunters0_taunt));
            await sleep(220);
            cs_force_combat_status(2);
            cs_ignore_obstacles(true);
            cs_abort_on_damage(true);
            cs_look_player(true);
            cs_go_to(GetReference<ISpatialPoint>("e2_cov_hunters0_entry/p1"));
            cs_face_player(true);
            await sleep_until(async () => await this.player_in_vehicle() || objects_distance_to_object(ai_actors(this.ai_current_squad), await this.player0()) <= 4F || (bool)game_is_cooperative() && objects_distance_to_object(ai_actors(this.ai_current_squad), await this.player1()) <= 4F || (bool)ai_trigger_test("generic_player_fired", this.ai_current_squad) && objects_can_see_flag(players(), e2_cov_hunters0_entry, 20F) || (float)ai_strength(this.ai_current_squad) < 1F, 5, 240);
        }

        [ScriptMethod(367, Lifecycle.CommandScript)]
        public async Task cs_e2_cov_inf0_watch()
        {
            cs_abort_on_damage(true);
            await sleep_until(async () => volume_test_objects(tv_e2_hunters_bypassed, players()) || (bool)ai_trigger_test("e2_cov_hunters0_active", e2_cov_hunters0.Squad), 15);
        }

        [ScriptMethod(368, Lifecycle.CommandScript)]
        public async Task cs_e2_mars_johnson0_dialogue0()
        {
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3834970911U), "combat:rifle:hold", true);
            await sleep(10);
            await sleep(ai_play_line(e2_mars_johnson.Squad, "0930"));
        }

        [ScriptMethod(369, Lifecycle.CommandScript)]
        public async Task cs_e2_mars_johnson0_watch()
        {
            cs_go_to(GetReference<ISpatialPoint>("e2_mars_watch/p1"));
            cs_aim(true, GetReference<ISpatialPoint>("e2_mars_watch/watch"));
            await sleep_until(async () => this.g_e2_door_breached);
            cs_aim_object(true, ai_get_object(e2_cov_hunters0.hunter0));
            await sleep_until(async () => this.g_e2_cov_hunters0_active, 10, this._30_seconds);
        }

        [ScriptMethod(370, Lifecycle.CommandScript)]
        public async Task cs_e2_mars_inf0_watch()
        {
            cs_go_to_nearest(GetReference<ISpatialPoint>("e2_mars_inf0_positions"));
            cs_crouch(true);
            await sleep_until(async () => this.g_e2_door_breached);
            cs_aim_object(true, ai_get_object(e2_cov_hunters0.hunter0));
            await sleep_until(async () => this.g_e2_cov_hunters0_active, 10, this._30_seconds);
        }

        [ScriptMethod(371, Lifecycle.CommandScript)]
        public async Task cs_e2_mars_continue()
        {
            cs_go_to_nearest(GetReference<ISpatialPoint>("e2_mars_wait"));
            cs_face_player(true);
            await sleep_until(async () => (bool)ai_trigger_test("generic_player_within_4wu", e2_mars) || (bool)ai_trigger_test("e2_cov_hunters0_bypassed", e2_mars) || this.g_e3_started, 15);
        }

        [ScriptMethod(372, Lifecycle.Dormant)]
        public async Task e2_dialog()
        {
            await sleep(75);
            await sleep_until(async () => this.g_e2_door_breached);
            await sleep(120);
            await sleep(ai_play_line_on_object(default(IGameObject), "0340"));
            cs_run_command_script(e2_mars_johnson.Squad, new ScriptMethodReference(cs_e2_mars_johnson0_dialogue0));
            await sleep_until(async () => (float)ai_strength(e2_cov_hunters0.Squad) <= 0.8F, 30, this._30_seconds);
            if (!((float)ai_strength(e2_cov_hunters0.Squad) <= 0.8F))
            {
                ai_play_line_on_object(default(IGameObject), "0350") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }

            await sleep_until(async () => (short)ai_living_count(e2_cov_hunters0.Squad) <= 0);
            await sleep(60);
            await sleep(ai_play_line_on_object(default(IGameObject), "0280"));
            await sleep(25);
            await sleep(ai_play_line_on_object(default(IGameObject), "0290"));
            await sleep(20);
            ai_play_line_on_object(default(IGameObject), "0300") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(373, Lifecycle.Dormant)]
        public async Task e2_cov_inf0_main()
        {
            ai_place(e2_cov_inf0.Squad);
        }

        [ScriptMethod(374, Lifecycle.Dormant)]
        public async Task e2_cov_hunters0_main()
        {
            await sleep_until(async () => objects_can_see_flag(players(), e2_wall_tap, 30F), 15, this.one_minute);
            sound_impulse_predict(GetTag<SoundTag>("sound\\materials\\hard\\metal_thin\\metal_thin_large", 4190902188U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\visual_effects\\explosion_medium_metal_bits", 4267383848U));
            await sleep(30);
            device_set_position(e2_hunter_door.Entity, 0.5F);
            sound_impulse_start(GetTag<SoundTag>("sound\\materials\\hard\\metal_thin\\metal_thin_large", 4190902188U), e2_hunter_door_sound_source.Entity, 1F);
            object_damage_damage_section(e2_hunter_door.Entity, "body_hit0", 1.1F);
            object_create(e2_hunter_smoke);
            await sleep(60);
            wake(new ScriptMethodReference(e2_dialog));
            wake(new ScriptMethodReference(objective0_clear));
            ai_place(e2_cov_hunters0.Squad);
            await sleep(60);
            device_set_position(e2_hunter_door.Entity, 1F);
            sound_impulse_start(GetTag<SoundTag>("sound\\materials\\hard\\metal_thin\\metal_thin_large", 4190902188U), e2_hunter_door_sound_source.Entity, 1F);
            object_damage_damage_section(e2_hunter_door.Entity, "body_hit1", 1.1F);
            await sleep(160);
            device_set_position_immediate(e2_hunter_door.Entity, 0.01F);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\explosion_medium_metal_bits", 4267383848U), e2_hunter_door_sound_source.Entity, 1F);
            await sleep(1);
            object_damage_damage_section(e2_hunter_door.Entity, "body_main", 1.1F);
            await sleep(1);
            device_set_position_immediate(e2_hunter_door.Entity, 1F);
            object_destroy(e2_hunter_smoke.Entity);
            this.g_e2_door_breached = true;
            wake(new ScriptMethodReference(music_03a_01_stop));
            wake(new ScriptMethodReference(music_03a_02_start_alt));
            await sleep_until(async () => (short)ai_living_count(e2_cov_hunters0.Squad) <= 0 || this.g_e3_started);
            wake(new ScriptMethodReference(objective1_set));
            game_save();
            wake(new ScriptMethodReference(music_03a_02_stop));
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task e2_mars_inf0_main()
        {
            ai_migrate(e1_mars_inf0.Squad, e2_mars_inf0.Squad);
            ai_migrate(e1_mars_inf1.Squad, e2_mars_inf0.Squad);
            ai_renew(e2_mars_inf0.Squad);
            ai_disposable(e2_mars_inf0.Squad, false);
            cs_run_command_script(e2_mars_inf0.Squad, new ScriptMethodReference(cs_e2_mars_inf0_watch));
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task e2_mars_johnson_main()
        {
            ai_migrate(e1_mars_johnson.Squad, e2_mars_johnson.Squad);
            ai_disposable(e2_mars_johnson.Squad, false);
            cs_run_command_script(e2_mars_johnson.Squad, new ScriptMethodReference(cs_e2_mars_johnson0_watch));
            await sleep_until(async () => (short)ai_spawn_count(e2_cov_hunters0.Squad) > 0);
            await sleep_until(async () => (short)ai_living_count(e2_cov_hunters0.Squad) <= 0);
            cs_run_command_script(e2_mars, new ScriptMethodReference(cs_e2_mars_continue));
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task e2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e2_main_begin, players()) && !(volume_test_objects_all(tv_e2_main_begin_exclude, players())), 15);
            this.g_e2_started = true;
            print("e2_main");
            data_mine_set_mission_segment("e2_hunter_intro");
            game_save();
            wake(new ScriptMethodReference(e2_cov_hunters0_main));
            wake(new ScriptMethodReference(e2_mars_inf0_main));
            wake(new ScriptMethodReference(e2_mars_johnson_main));
            await sleep_until(async () => this.g_e3_started);
            sleep_forever(new ScriptMethodReference(e2_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e2_mars_johnson_main));
            sleep_forever(new ScriptMethodReference(e2_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e2_cov_hunters0_main));
            sleep_forever(new ScriptMethodReference(e2_dialog));
            ai_disposable(e2_cov, true);
        }

        [ScriptMethod(378, Lifecycle.Static)]
        public async Task test_hunter_intro()
        {
            object_teleport(await this.player0(), e2_test);
            ai_place(e2_mars_inf0.Squad);
            ai_place(e2_mars_johnson.Squad);
            if (!(this.g_e2_started))
            {
                wake(new ScriptMethodReference(e2_main));
            }

            if (!(this.g_e3_started))
            {
                wake(new ScriptMethodReference(e3_main));
            }

            if (!(this.g_e8_started))
            {
                wake(new ScriptMethodReference(e8_main));
            }

            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(379, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_pelican0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_face(true, GetReference<ISpatialPoint>("e1_mars_pelican/p0_facing"));
            cs_fly_to(GetReference<ISpatialPoint>("e1_mars_pelican/p0"));
            this.g_e1_mars_pelican0_appeared = true;
            cs_face(false, GetReference<ISpatialPoint>("e1_mars_pelican/p1_facing"));
            cs_fly_to(GetReference<ISpatialPoint>("e1_mars_pelican/p1"));
            await sleep(75);
            print("pilot: looks too tight down there");
            await sleep(ai_play_line_on_object(default(IGameObject), "0900"));
            this.g_e1_mars_pelican0_departing = true;
            cs_vehicle_speed(0.75F);
            cs_fly_to(GetReference<ISpatialPoint>("e1_mars_pelican/p2"), 0.5F);
            await sleep(60);
            cs_face(false, GetReference<ISpatialPoint>("e1_mars_pelican/p1_facing"));
            cs_fly_by(GetReference<ISpatialPoint>("e1_mars_pelican/p3"));
            this.g_e1_mars_pelican0_departing = true;
            cs_fly_by(GetReference<ISpatialPoint>("e1_mars_pelican/p4"), 1F);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(380, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_johnson_finale()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e1_mars_johnson_finale/p0"));
            await sleep_until(async () => (short)ai_spawn_count(e2_cov_hunters0.Squad) > 0);
            await sleep(90);
        }

        [ScriptMethod(381, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_johnson_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_crouch(true);
            await sleep(105);
            cs_crouch(false);
            await sleep(ai_play_line(this.ai_current_actor, "0850"));
            await sleep(15);
            await sleep(ai_play_line(this.ai_current_actor, "0110"));
            await sleep(10);
            cs_go_to(GetReference<ISpatialPoint>("e1_mars_entry/p2"));
        }

        [ScriptMethod(382, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_crouch(true);
            await sleep(120);
            cs_crouch(false);
            cs_go_to(GetReference<ISpatialPoint>("e1_mars_entry/p4"));
            cs_enable_moving(true);
            cs_enable_looking(true);
            await sleep(300);
        }

        [ScriptMethod(383, Lifecycle.CommandScript)]
        public async Task cs_e1_mars_entry0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_crouch(true);
            await sleep(120);
            cs_crouch(false);
            cs_enable_moving(true);
            cs_enable_looking(true);
            await sleep(300);
        }

        [ScriptMethod(384, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_phantom0_0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e1_cov_phantom0_0_entry/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("e1_cov_phantom0_0_entry/p1"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(385, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_phantom0_1_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p0"));
            cs_face(true, GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p1_facing"));
            this.g_e1_cov_phantom0_1_arrived = true;
            cs_fly_to(GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p1"), 1F);
            await sleep(15);
            cs_vehicle_speed(0.66F);
            cs_fly_to(GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p2"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p3"), GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p3_facing"), 0.5F);
            cs_face(true, GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p3_facing"));
            object_set_phantom_power(ai_vehicle_get(this.ai_current_actor), true);
            await sleep(30);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_a");
            await sleep(60);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_b");
            await sleep(60);
            this.g_e1_cov_inf4_0_arrived = true;
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get(this.ai_current_actor), false);
            cs_fly_to(GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p4"), 0.5F);
            await sleep(150);
            cs_vehicle_speed(0.4F);
            cs_face(false, GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p3_facing"));
            cs_fly_by(GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p5"), 1F);
            this.g_e1_cov_phantom0_1_retreating = true;
            cs_vehicle_speed(0.75F);
            cs_fly_by(GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p6"));
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("e1_cov_phantom0_1_entry/p7"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(386, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_grunt0()
        {
            cs_enable_dialogue(true);
            cs_movement_mode(this.ai_movement_combat);
            cs_start_to(GetReference<ISpatialPoint>("e1_patrol/grunt0"));
            await sleep_until(async () => !((bool)cs_moving()) || (short)ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_visible, 10);
            cs_approach(ai_get_object(this.ai_current_actor), 0.1F, 0.1F, 0.1F);
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_dangerous, 3, 25);
            cs_movement_mode(this.ai_movement_flee);
            cs_go_to(GetReference<ISpatialPoint>("e1_patrol/grunt1"));
        }

        [ScriptMethod(387, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_0_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("e1_patrol/p0")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_patrol/p1")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_patrol/p2")), 
                    async () => await sleep((short)random_range(30, 60)));
                return false;
            });
        }

        [ScriptMethod(388, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_0_patrol1()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e1_patrol/p3"));
                await sleep((short)random_range(30, 60));
                cs_go_to(GetReference<ISpatialPoint>("e1_patrol/p4"));
                await sleep((short)random_range(30, 60));
                return false;
            });
        }

        [ScriptMethod(389, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_inf0_3_patrol0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_looking(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("e1_patrol/p7")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_patrol/p8")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_patrol/p9")), 
                    async () => await sleep((short)random_range(30, 60)));
                return false;
            });
        }

        [ScriptMethod(390, Lifecycle.Static)]
        public async Task<bool> johnson_has_sniping_weapon()
        {
            return unit_has_weapon(ai_get_unit(e1_mars_johnson.johnson0), GetTag<BaseTag>("objects\\weapons\\rifle\\sniper_rifle\\sniper_rifle.weapon", 4174845623U)) || unit_has_weapon(ai_get_unit(e1_mars_johnson.johnson0), GetTag<BaseTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle.weapon", 3788570715U));
        }

        [ScriptMethod(391, Lifecycle.Static)]
        public async Task<bool> e1_cov_inf0_grunts_alerted()
        {
            return (short)ai_combat_status(e1_cov_inf0_0.grunt1) >= this.ai_combat_status_alert || (short)ai_combat_status(e1_cov_inf0_0.grunt2) >= this.ai_combat_status_alert || (short)ai_combat_status(e1_cov_inf0_1.Squad) >= this.ai_combat_status_alert;
        }

        [ScriptMethod(392, Lifecycle.Static)]
        public async Task<bool> e1_cov_inf2_under_limit()
        {
            return this.g_e1_cov_inf2_spawned < this.g_e1_cov_inf2_limit;
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task<bool> e1_cov_inf2_spawn_ready()
        {
            return (short)ai_living_count(e1_cov_inf2) <= 1 && (short)ai_fighting_count(e1_cov_inf2) <= 0;
        }

        [ScriptMethod(394, Lifecycle.Static)]
        public async Task e1_cov_inf2_sleep_until_respawn()
        {
            await sleep_until(async () => await this.e1_cov_inf2_spawn_ready(), 31, this.two_minutes);
            await sleep_until(async () => volume_test_objects(tv_e1_on_building, players()), 30, 150);
        }

        [ScriptMethod(395, Lifecycle.Static)]
        public async Task e1_cov_inf2_6_spawn()
        {
            if (!(volume_test_objects(tv_e1_cov_inf2_1_unsafe, players())))
            {
                game_save();
                await sleep(5);
                ai_place(e1_cov_inf2_6.Squad, (short)min(5F, 10F - (float)ai_living_count(e1_cov_inf2)));
                ai_set_orders(e1_cov_inf2_6.Squad, e1_cov_inf2_engage0);
                await sleep(2);
                ai_magically_see(e1_mars_johnson.Squad, e1_cov_inf2_5.Squad);
                this.g_e1_cov_inf2_spawned = (short)(this.g_e1_cov_inf2_spawned + 1);
                await this.e1_cov_inf2_sleep_until_respawn();
            }
        }

        [ScriptMethod(396, Lifecycle.Static)]
        public async Task e1_cov_inf2_5_spawn()
        {
            if (!(volume_test_objects(tv_e1_cov_inf2_5_unsafe, players())))
            {
                game_save();
                await sleep(5);
                ai_place(e1_cov_inf2_5.Squad, (short)min(5F, 10F - (float)ai_living_count(e1_cov_inf2)));
                ai_set_orders(e1_cov_inf2_5.Squad, e1_cov_inf2_5_init);
                await sleep(2);
                ai_magically_see(e1_mars_johnson.Squad, e1_cov_inf2_5.Squad);
                this.g_e1_cov_inf2_spawned = (short)(this.g_e1_cov_inf2_spawned + 1);
                await sleep(120);
                if (this.g_e1_cov_inf2_wave0)
                {
                    ai_play_line(e1_mars_johnson.johnson0, "0210") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                }

                await this.e1_cov_inf2_sleep_until_respawn();
            }
        }

        [ScriptMethod(397, Lifecycle.Static)]
        public async Task e1_cov_inf2_3_spawn()
        {
            if (!(volume_test_objects(tv_e1_cov_inf2_3_unsafe, players())))
            {
                game_save();
                await sleep(5);
                ai_place(e1_cov_inf2_3.Squad, (short)min(5F, 10F - (float)ai_living_count(e1_cov_inf2)));
                ai_set_orders(e1_cov_inf2_3.Squad, e1_cov_inf2_engage0);
                await sleep(2);
                ai_magically_see(e1_mars_johnson.Squad, e1_cov_inf2_3.Squad);
                this.g_e1_cov_inf2_spawned = (short)(this.g_e1_cov_inf2_spawned + 1);
                await sleep(120);
                if (this.g_e1_cov_inf2_wave0)
                {
                    ai_play_line(e1_mars_johnson.johnson0, "0170") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                }

                await this.e1_cov_inf2_sleep_until_respawn();
            }
        }

        [ScriptMethod(398, Lifecycle.Static)]
        public async Task e1_cov_inf2_1_spawn()
        {
            if (!(volume_test_objects(tv_e1_cov_inf2_1_unsafe, players())))
            {
                game_save();
                await sleep(5);
                ai_place(e1_cov_inf2_1.Squad, (short)min(5F, 10F - (float)ai_living_count(e1_cov_inf2)));
                ai_set_orders(e1_cov_inf2_1.Squad, e1_cov_inf2_engage0);
                await sleep(2);
                ai_magically_see(e1_mars_johnson.Squad, e1_cov_inf2_1.Squad);
                this.g_e1_cov_inf2_spawned = (short)(this.g_e1_cov_inf2_spawned + 1);
                await sleep(90);
                if (!(this.g_e1_cov_inf2_wave0))
                {
                    ai_play_line(e1_mars_johnson.johnson0, "0150") // Couldn't generate cast from 'Short' to 'Void'
                    ;
                }

                await this.e1_cov_inf2_sleep_until_respawn();
            }
        }

        [ScriptMethod(399, Lifecycle.Dormant)]
        public async Task e1_mars_pelican0_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_inf4_1.Squad) > 0 && (short)ai_living_count(e1_cov_inf4) <= 3);
            ai_place(e1_mars_pelican0.Squad);
            ai_vehicle_enter_immediate(e1_mars_pelican0.gunner0, ai_vehicle_get(e1_mars_pelican0.pelican0), "pelican_g");
            ai_vehicle_enter_immediate(e1_mars_pelican0.gunner1, ai_vehicle_get(e1_mars_pelican0.pelican0), "pelican_g_rear");
            cs_run_command_script(e1_mars_pelican0.pelican0, new ScriptMethodReference(cs_e1_mars_pelican0_entry));
            await sleep_until(async () => this.g_e1_mars_pelican0_departing, 30);
            wake(new ScriptMethodReference(e2_main));
        }

        [ScriptMethod(400, Lifecycle.Dormant)]
        public async Task e1_cov_phantom0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_main_area_entrance, players()), 5);
            await sleep_until(async () => await this.e1_cov_inf0_grunts_alerted(), 30, this._30_seconds);
            ai_place(e1_cov_phantom0_0.Squad);
            cs_run_command_script(e1_cov_phantom0_0.phantom0, new ScriptMethodReference(cs_e1_cov_phantom0_0_entry));
            sleep_forever();
            ai_place(e1_cov_phantom0_1.Squad);
            wake(new ScriptMethodReference(music_03a_01_start));
        }

        [ScriptMethod(401, Lifecycle.Dormant)]
        public async Task e1_cov_snipers0_main()
        {
            if (await this.difficulty_legendary())
            {
                this.g_e1_cov_snipers0_limit = 5;
            }

            begin_random(async () =>
            {
                if ((short)ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(volume_test_objects(tv_e1_cov_sniper0_0_unsafe, players())))
                    {
                        ai_place(e1_cov_snipers0.sniper0);
                        game_save();
                        await sleep_until(async () => (short)ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await sleep((short)random_range(this.one_minute, this.two_minutes));
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(volume_test_objects(tv_e1_cov_sniper0_1_unsafe, players())))
                    {
                        ai_place(e1_cov_snipers0.sniper1);
                        game_save();
                        await sleep_until(async () => (short)ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await sleep((short)random_range(this.one_minute, this.two_minutes));
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(volume_test_objects(tv_e1_cov_sniper0_2_unsafe, players())))
                    {
                        ai_place(e1_cov_snipers0.sniper2);
                        game_save();
                        await sleep_until(async () => (short)ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await sleep((short)random_range(this.one_minute, this.two_minutes));
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(volume_test_objects(tv_e1_cov_sniper0_3_unsafe, players())))
                    {
                        ai_place(e1_cov_snipers0.sniper3);
                        game_save();
                        await sleep_until(async () => (short)ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await sleep((short)random_range(this.one_minute, this.two_minutes));
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_spawn_count(e1_cov_snipers0.Squad) < this.g_e1_cov_snipers0_limit)
                {
                    if (!(volume_test_objects(tv_e1_cov_sniper0_3_unsafe, players())))
                    {
                        ai_place(e1_cov_snipers0.sniper4);
                        game_save();
                        await sleep_until(async () => (short)ai_living_count(e1_cov_snipers0.Squad) <= 0);
                        await sleep((short)random_range(this.one_minute, this.two_minutes));
                    }
                }
            });
        }

        [ScriptMethod(402, Lifecycle.Dormant)]
        public async Task e1_cov_inf4_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_phantom0_1.Squad) > 0, 10);
            if (await this.difficulty_heroic())
            {
                ai_place_in_vehicle(e1_cov_inf4_0.elite1, e1_cov_phantom0_1.Squad);
            }

            if (await this.difficulty_legendary())
            {
                ai_place_in_vehicle(e1_cov_inf4_2.Squad, e1_cov_phantom0_1.Squad);
            }

            ai_place_in_vehicle(e1_cov_inf4_0.Squad, e1_cov_phantom0_1.Squad);
            await sleep_until(async () => this.g_e1_cov_inf4_0_arrived);
            await sleep(300);
            await sleep_until(async () => (short)ai_living_count(e1_cov_inf4) <= 2 && !(volume_test_objects(tv_e1_cov_inf4_1_unsafe, players())), 30, this.two_minutes);
            ai_place(e1_cov_inf4_1.Squad, (short)pin(6F - (float)ai_living_count(e1_cov_inf4), 2F, 5F));
        }

        [ScriptMethod(403, Lifecycle.Dormant)]
        public async Task e1_cov_inf3_main()
        {
            ai_place(e1_cov_inf3_2.Squad);
            await sleep_until(async () => (float)ai_strength(e1_cov_inf3_2.Squad) <= 0.75F && objects_can_see_flag(players(), e1_cov_inf3_entrance, 25F), 5, this._30_seconds);
            ai_place(e1_cov_inf3_0.Squad, (short)(5 - (float)ai_living_count(e1_cov_inf3)));
            await sleep(30);
            ai_play_line(e1_mars_johnson.johnson0, "0270") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e1_cov_inf3) < 3)
                {
                    ai_place(e1_cov_inf3_1.Squad, 2);
                }

                return (short)ai_spawn_count(e1_cov_inf3) >= 10;
            });
            ai_set_orders(e1_cov_inf3, e1_cov_inf3_advance0);
        }

        [ScriptMethod(404, Lifecycle.Dormant)]
        public async Task e1_cov_inf2_main()
        {
            await sleep_until(async () => (short)ai_living_count(e1_cov_inf1) <= 1 && (short)ai_spawn_count(e1_cov_inf1) > 0, 30, this.one_minute);
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
                wake(new ScriptMethodReference(e1_cov_snipers0_main));
            }

            begin_random(async () =>
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
            game_save();
            await sleep(60);
            await this.e1_cov_inf2_5_spawn();
            await sleep_until(async () => (short)ai_living_count(e1_cov_inf2) <= 1 && (short)ai_fighting_count(e1_cov_inf2) <= 0);
            garbage_collect_now();
            game_save();
            await sleep(15);
            wake(new ScriptMethodReference(e1_cov_inf3_main));
            await sleep(30);
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_inf3_1.Squad) > 0 && (short)ai_living_count(e1_cov_inf3) <= 2 && (short)ai_fighting_count(e1_cov_inf3) <= 0, 30, this.two_minutes);
            ai_disposable(e1_cov_inf3, true);
            game_save();
            await sleep(30);
            garbage_collect_now();
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

            begin_random(async () =>
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
            game_save();
            await sleep(30);
            wake(new ScriptMethodReference(e1_cov_phantom0_main));
            wake(new ScriptMethodReference(e1_cov_inf4_main));
        }

        [ScriptMethod(405, Lifecycle.Dormant)]
        public async Task e1_cov_inf1_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_inf0_2.Squad) > 0 && (short)ai_living_count(e1_cov_inf0) <= 1 && (short)ai_fighting_count(e1_cov_inf0) <= 0, 30);
            game_save();
            await sleep(120);
            await sleep_until(async () => !(volume_test_objects(tv_e1_cov_inf1_unsafe, players())));
            ai_place(e1_cov_inf1);
            ai_magically_see(e1_cov_inf1, e1_mars);
        }

        [ScriptMethod(406, Lifecycle.Dormant)]
        public async Task e1_cov_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_crash_area_exit, players()) || volume_test_objects(tv_e1_main_area_entrance, players()) || volume_test_objects(tv_e1_prediction, players()), 5);
            object_type_predict(GetTag<BaseTag>("objects\\characters\\grunt\\grunt", 4075753849U));
            camera_predict_resources_at_point(e1_prediction);
            await sleep_until(async () => volume_test_objects(tv_e1_crash_area_exit, players()) || volume_test_objects(tv_e1_main_area_entrance, players()), 5);
            ai_place(e1_cov_inf0_0.Squad);
            ai_place(e1_cov_inf0_3.Squad);
            await sleep_until(async () => (short)ai_living_count(e1_cov_inf0) <= 3 || volume_test_objects(tv_e1_cov_inf0_1_begin, players()), 15);
            ai_place(e1_cov_inf0_1.grunt0);
            await sleep_until(async () => (short)ai_living_count(e1_cov_inf0) <= 3 || volume_test_objects(tv_e1_cov_inf0_1_begin, players()), 15);
            ai_place(e1_cov_inf0_1.grunt1);
            await sleep_until(async () => (short)ai_living_count(e1_cov_inf0_3.Squad) <= 0 || volume_test_objects(tv_e1_cov_inf0_2_begin, players()), 15);
            ai_place(e1_cov_inf0_2.Squad);
            await sleep(5);
            ai_magically_see(e1_cov_inf0_2.Squad, e1_mars_inf0.Squad);
            wake(new ScriptMethodReference(e1_cov_inf1_main));
            wake(new ScriptMethodReference(e1_cov_inf2_main));
        }

        [ScriptMethod(407, Lifecycle.Dormant)]
        public async Task e1_mars_inf1_main()
        {
            ai_place(e1_mars_inf1.Squad);
        }

        [ScriptMethod(408, Lifecycle.Dormant)]
        public async Task e1_mars_inf0_main()
        {
            ai_place(e1_mars_inf0.Squad);
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_phantom0_1.Squad) > 0 && (short)ai_living_count(e1_cov_phantom0_1.Squad) <= 0);
        }

        [ScriptMethod(409, Lifecycle.Dormant)]
        public async Task e1_mars_johnson_main()
        {
            ai_place(e1_mars_johnson.Squad);
            object_cannot_die(ai_get_object(e1_mars_johnson.johnson0), true);
            cs_run_command_script(e1_mars_johnson.Squad, new ScriptMethodReference(cs_e1_mars_johnson_entry));
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_inf0_2.Squad) > 0 && (short)ai_living_count(e1_cov_inf0_2.Squad) <= 0);
            await sleep_until(async () => volume_test_objects(tv_e1_on_building, ai_actors(e1_mars_johnson.Squad)), 30, 450);
            await sleep(ai_play_line(e1_mars_johnson.johnson0, "0120"));
            print("they know we're here");
            game_save();
            wake(new ScriptMethodReference(objective0_set));
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_inf1) > 0);
            await sleep(60);
            ai_play_line(e1_mars_johnson.johnson0, "0130") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep_until(async () => (short)ai_spawn_count(e1_cov_phantom0_0.Squad) > 0);
            await sleep_until(async () => this.g_e1_cov_phantom0_1_arrived);
            await sleep(60);
            await sleep(ai_play_line(e1_mars_johnson.johnson0, "0890"));
            await sleep_until(async () => this.g_e1_mars_pelican0_appeared, 15);
            cs_run_command_script(e1_mars_johnson.Squad, new ScriptMethodReference(cs_e1_mars_johnson_finale));
            await sleep_until(async () => this.g_e1_mars_pelican0_departing, 3, this.one_minute);
            await sleep(20);
            await sleep(ai_play_line(e1_mars_johnson.johnson0, "0910"));
            wake(new ScriptMethodReference(music_03a_02_start));
        }

        [ScriptMethod(410, Lifecycle.Dormant)]
        public async Task e1_key()
        {
            object_create(e1_ghost_key);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4183693118U)) && volume_test_object(tv_e1_ghost_key, await this.player0()) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4183693118U)) && volume_test_object(tv_e1_ghost_key, await this.player1()));
            ice_cream_flavor_stock(6);
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task e1_main()
        {
            this.g_e1_started = true;
            print("e1_main");
            data_mine_set_mission_segment("e1_rooftop_defense");
            wake(new ScriptMethodReference(e3_main));
            wake(new ScriptMethodReference(e8_main));
            wake(new ScriptMethodReference(e12_main));
            wake(new ScriptMethodReference(e1_mars_johnson_main));
            wake(new ScriptMethodReference(e1_mars_inf0_main));
            wake(new ScriptMethodReference(e1_mars_inf1_main));
            wake(new ScriptMethodReference(e1_cov_inf0_main));
            wake(new ScriptMethodReference(e1_cov_phantom0_main));
            wake(new ScriptMethodReference(e1_mars_pelican0_main));
            wake(new ScriptMethodReference(e1_key));
            await sleep_until(async () => this.g_e2_started);
            sleep_forever(new ScriptMethodReference(e1_cov_snipers0_main));
            await sleep_until(async () => this.g_e3_started);
            sleep_forever(new ScriptMethodReference(e1_mars_johnson_main));
            sleep_forever(new ScriptMethodReference(e1_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e1_mars_inf1_main));
            sleep_forever(new ScriptMethodReference(e1_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e1_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e1_cov_inf2_main));
            sleep_forever(new ScriptMethodReference(e1_cov_inf3_main));
            sleep_forever(new ScriptMethodReference(e1_cov_inf4_main));
            sleep_forever(new ScriptMethodReference(e1_cov_phantom0_main));
            ai_disposable(e1_cov, true);
            ai_disposable(e1_cov_phantom0, false);
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            wake(new ScriptMethodReference(flashlight_control));
            await this.cinematic_snap_to_black();
            await this.cinematic_intro();
            wake(new ScriptMethodReference(e1_main));
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.chief_recovery_sequence();
            wake(new ScriptMethodReference(chapter_title0));
            await sleep(150);
            game_save();
            await sleep_until(async () => volume_test_objects(tv_mission_end, players()), 8);
            this.g_mission_over = true;
            await this.playtest_mission();
            await sleep(15);
            sound_class_set_gain("", 0F, 15);
            await this.cinematic_fade_to_white();
            await sleep(15);
            game_won();
        }

        [ScriptMethod(413, Lifecycle.Static)]
        public async Task start()
        {
            wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(414, Lifecycle.Startup)]
        public async Task mission_main()
        {
            ai_allegiance(player, human);
            ai_allegiance(covenant, prophet);
            objectives_clear();
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task _03_intro_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 2);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3840672630U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3841852296U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 4);
            await sleep(113);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3843359647U), 2);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 76, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3844408239U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 57, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 62, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3844735924U), 0);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            await sleep(76);
            print("predicting chief");
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 19);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 19);
            await sleep(91);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3846570960U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3850109958U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3850109958U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 2);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3846570960U), 0);
            await sleep(81);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 71, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3841852296U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3844735924U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788111956U), 4);
            await sleep(121);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 58);
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task _03_intro_02_predict()
        {
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 71, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3844735924U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3844408239U), 0);
            await sleep(130);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 65);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\sniper_rifle\\sniper_rifle", 3856401510U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3856860269U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\spotting_scope\\spotting_scope", 3857515639U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3857843324U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 2);
            await sleep(12);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 107);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 108);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 109);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 110);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 111);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 112);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 113);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 114);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 115);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\turrets\\chaingun\\chaingun", 3862103229U), 3);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 55);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 54);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 61);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\turrets\\chaingun\\chaingun", 3862103229U), 2);
            await sleep(28);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\turrets\\chaingun\\chaingun", 3862103229U), 1);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            await sleep(21);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 70);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 119);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 120);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 122);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 123);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 16);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3857843324U), 0);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\warthog", 3859678360U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\warthog\\turrets\\chaingun\\chaingun", 3862103229U), 1);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            await sleep(16);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3844408239U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 65);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\sniper_rifle\\sniper_rifle", 3856401510U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3856860269U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\spotting_scope\\spotting_scope", 3857515639U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            await sleep(54);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, true);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            await sleep(15);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3857843324U), 0);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3844408239U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3862824136U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3863020747U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            await sleep(19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task _03_intro_03_predict()
        {
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 69);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\helmet_standard\\helmet_standard", 3863413969U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3788701789U), 2);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            await sleep(16);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            await sleep(47);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            await sleep(44);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            await sleep(25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3788701789U), 2);
            await sleep(57);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 73);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\sniper_rifle\\sniper_rifle", 3856401510U), 2);
            await sleep(35);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3844866998U), 19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3857843324U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3856860269U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\helmet_standard\\helmet_standard", 3863413969U), 0);
            await sleep(66);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 69);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            await sleep(27);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            await sleep(54);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3857843324U), 1);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
        }

        [ScriptMethod(418, Lifecycle.Dormant)]
        public async Task _03_intro_04_predict()
        {
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 71);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3856860269U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            await sleep(23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            await sleep(20);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 16);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 17);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 18);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 20);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 21);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 22);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 24);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 25);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 26);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 27);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 28);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 29);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 30);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3864790246U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3865707764U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3866494208U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3867149578U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3867477263U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3857843324U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3868067096U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\vent_wall_a\\vent_wall_a", 3869508910U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3869771058U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3869771058U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3869771058U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3863020747U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3862824136U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3844408239U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, true);
            await sleep(8);
            await sleep(19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            await sleep(27);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            await sleep(13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3867477263U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3856860269U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 7);
            await sleep(9);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\garbage\\civ_wheel\\civ_wheel", 3870033206U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3867477263U), 3);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3867149578U), 0);
            await sleep(51);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3867149578U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3863020747U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3862824136U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3844408239U), 0);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 4);
            await sleep(36);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3867149578U), 0);
            await sleep(26);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3841852296U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 1);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 16);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 17);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 18);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 20);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 21);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 22);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 24);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 25);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 26);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 27);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 28);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 29);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 30);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3863479506U), 31);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3865707764U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3866494208U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3867149578U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\palmtrees\\palmtree_a\\palmtree_a", 3859154064U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3857843324U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3856860269U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            await sleep(79);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            await sleep(22);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3866821893U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\garbage\\civ_wheel\\civ_wheel", 3870033206U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3867477263U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3857843324U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3868067096U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3869771058U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3869771058U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\railing\\railing", 3869771058U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3863020747U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3863020747U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3862824136U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3852076068U), 71);
            await sleep(19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\vent_wall_a\\vent_wall_a", 3869508910U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3862824136U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            await sleep(17);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\junction_box_lg_garbage2\\junction_box_lg_garbage2", 3870426428U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\junction_box_lg_garbage1\\junction_box_lg_garbage1", 3870491965U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_a\\concrete_chunk_a", 3856860269U), 0);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_c\\concrete_chunk_c", 3870557502U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3870885187U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_f\\concrete_chunk_f", 3870950724U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_d\\concrete_chunk_d", 3871016261U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3844408239U), 0);
        }
    }
}