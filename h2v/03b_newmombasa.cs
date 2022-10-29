namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\03b_newmombasa\\03b_newmombasa")]
    public partial class scnr_03b_newmombasa : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool g_mission_over;
        int _30_seconds;
        int _45_seconds;
        int one_minute;
        int two_minutes;
        bool g_e23_scarab_arrived;
        bool g_e23_scarab_climbed_down;
        bool g_e23_scarab_before_bridge0;
        bool g_e23_scarab_under_bridge0;
        bool g_e23_scarab_before_bridge1;
        bool g_e23_scarab_under_bridge1;
        bool g_e23_scarab_before_bridge2;
        bool g_e23_scarab_under_bridge2;
        bool g_e23_scarab_after_bridge2;
        bool g_e23_scarab_after_turn;
        bool g_e23_scarab_arrived_at_end;
        float g_scarab_interpolation;
        bool g_e23_started;
        bool g_e23_mars_pelican0_appeared;
        bool g_e23_scarab_active;
        int g_e23_target_pelican;
        bool g_e23_mars_pelican2_2_active;
        IGameObject g_target;
        bool g_e22_started;
        bool g_e22_scarab_visible;
        bool g_e22_scarab_appeared;
        bool g_e22_scarab_advancing;
        bool g_e22_scarab_before_climb;
        bool g_e22_scarab_started_climb;
        bool g_e22_scarab_mid_climb;
        bool g_e22_scarab_past_climb;
        bool g_e22_done_street_cleanup;
        bool g_e22_scorpion_asplode;
        bool g_e21_started;
        bool g_e21_cov_phantom0_retreating;
        bool g_e21_cov_phantom1_retreating;
        bool g_e20_started;
        bool g_e19_started;
        bool g_e18_started;
        int g_e18_orbit_count;
        int g_e18_cov_inf2_spawn_max;
        bool g_e18_mars_warthog0_spoke;
        bool g_e17_started;
        bool g_e17_mars_warthog0_arrived;
        bool g_e16_started;
        bool g_e15_started;
        bool g_e14_started;
        int g_e14_ghost_respawn_limit;
        public scnr_03b_newmombasa(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.g_mission_over = false;
            this._30_seconds = 900;
            this._45_seconds = 900;
            this.one_minute = 1800;
            this.two_minutes = 3600;
            this.g_e23_scarab_arrived = false;
            this.g_e23_scarab_climbed_down = false;
            this.g_e23_scarab_before_bridge0 = false;
            this.g_e23_scarab_under_bridge0 = false;
            this.g_e23_scarab_before_bridge1 = false;
            this.g_e23_scarab_under_bridge1 = false;
            this.g_e23_scarab_before_bridge2 = false;
            this.g_e23_scarab_under_bridge2 = false;
            this.g_e23_scarab_after_bridge2 = false;
            this.g_e23_scarab_after_turn = false;
            this.g_e23_scarab_arrived_at_end = false;
            this.g_scarab_interpolation = 0.25F;
            this.g_e23_started = false;
            this.g_e23_mars_pelican0_appeared = false;
            this.g_e23_scarab_active = true;
            this.g_e23_target_pelican = -1;
            this.g_e23_mars_pelican2_2_active = false;
            this.g_target = default(IGameObject);
            this.g_e22_started = false;
            this.g_e22_scarab_visible = false;
            this.g_e22_scarab_appeared = false;
            this.g_e22_scarab_advancing = false;
            this.g_e22_scarab_before_climb = false;
            this.g_e22_scarab_started_climb = false;
            this.g_e22_scarab_mid_climb = false;
            this.g_e22_scarab_past_climb = false;
            this.g_e22_done_street_cleanup = false;
            this.g_e22_scorpion_asplode = false;
            this.g_e21_started = false;
            this.g_e21_cov_phantom0_retreating = false;
            this.g_e21_cov_phantom1_retreating = false;
            this.g_e20_started = false;
            this.g_e19_started = false;
            this.g_e18_started = false;
            this.g_e18_orbit_count = 0;
            this.g_e18_cov_inf2_spawn_max = 5;
            this.g_e18_mars_warthog0_spoke = false;
            this.g_e17_started = false;
            this.g_e17_mars_warthog0_arrived = false;
            this.g_e16_started = false;
            this.g_e15_started = false;
            this.g_e14_started = false;
            this.g_e14_ghost_respawn_limit = 8;
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
        public async Task _03_intra1_01_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intra1_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _03_intra1_02a_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intra1_02a_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _03_intra1_02b_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intra1_02b_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _03_intra1_02c_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intra1_02c_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task _03_intra1_03_predict_stub()
        {
            wake(new ScriptMethodReference(_03_intra1_03_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x03_01_predict_stub()
        {
            wake(new ScriptMethodReference(x03_01_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x03_02_predict_stub()
        {
            wake(new ScriptMethodReference(x03_02_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x03_03_predict_stub()
        {
            wake(new ScriptMethodReference(x03_03_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x03_04_predict_stub()
        {
            wake(new ScriptMethodReference(x03_04_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x03_05_predict_stub()
        {
            wake(new ScriptMethodReference(x03_05_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task x03_06_predict_stub()
        {
            wake(new ScriptMethodReference(x03_06_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task x03_07_predict_stub()
        {
            print("!!!07 predict");
            wake(new ScriptMethodReference(x03_07_predict));
        }

        [ScriptMethod(36, Lifecycle.Static)]
        public async Task x03_08_predict_stub()
        {
            print("!!!08 predict");
            wake(new ScriptMethodReference(x03_08_predict));
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c03_intra1_sound_scene1_01()
        {
            sound_class_set_gain("vehicle_engine", 0F, 0);
            await sleep(390);
            sound_class_set_gain("vehicle_engine", 0.5F, 60);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c03_intra1_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\music\\c03_intra1_01_mus", 3819110957U), default(IGameObject), 1F);
            print("c03_intro score 01 start");
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task c03_intra1_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_01_fol", 3819176494U), default(IGameObject), 1F);
            print("c03_intro foley 01 start");
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c03_2010_mr3()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2010_mr3", 3819242031U), marine_01.Entity, 1F);
            cinematic_subtitle("c03_2010_mr3", 4F);
            unit_set_emotional_state(marine_01.Entity, "scared", 1F, 0);
            print("marine_01 - scared 1 0");
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c03_2020_mr4()
        {
            unit_set_emotional_state(marine_02.Entity, "shocked", 0.25F, 0);
            print("marine_02 - shocked .25 0");
            await sleep(200);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2020_mr4", 3819307568U), marine_02.Entity, 1F);
            cinematic_subtitle("c03_2020_mr4", 2F);
            await sleep(15);
            unit_set_emotional_state(marine_02.Entity, "angry", 0.5F, 30);
            print("marine_02 - angry .5 30");
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c03_2030_mr4()
        {
            await sleep(278);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2030_mr4", 3819373105U), marine_02.Entity, 1F);
            cinematic_subtitle("c03_2030_mr4", 3F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c03_intra1_fov_01()
        {
            time_code_reset();
            await sleep(263);
            camera_set_field_of_view(14F, 0);
            await sleep(1);
            camera_set_field_of_view(10F, 144);
            time_code_reset();
            await sleep(144);
            camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task drop_tank()
        {
            await sleep(598);
            objects_detach(pelican_01a.Entity, scorpion_01.Entity);
            print("special delivery");
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task destroy_scarab()
        {
            await sleep(410);
            object_destroy(scarab_01.Entity);
            print("destroy scarab");
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task c03_intra1_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(27F, 228F, 0.360784F, 0.317647F, 0.203922F);
            cinematic_lighting_set_secondary_light(-35F, 100F, 0.0901961F, 0.109804F, 0.14902F);
            cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.0666667F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(marine_01.Entity, true);
            object_uses_cinematic_lighting(marine_02.Entity, true);
            object_uses_cinematic_lighting(rifle_01.Entity, true);
            object_uses_cinematic_lighting(rifle_02.Entity, true);
            object_uses_cinematic_lighting(rifle_03.Entity, true);
            object_uses_cinematic_lighting(pelican_01a.Entity, true);
            object_uses_cinematic_lighting(scarab_02.Entity, true);
            object_uses_cinematic_lighting(scorpion_01.Entity, true);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task c03_intra1_problem_actors()
        {
            print("problem actors");
            object_create_anew(marine_01);
            object_create_anew(marine_02);
            object_create_anew(rifle_02);
            object_create_anew(rifle_03);
            object_cinematic_lod(marine_01.Entity, true);
            object_cinematic_lod(marine_02.Entity, true);
            objects_attach(marine_01.Entity, "right hand", rifle_02.Entity, "");
            objects_attach(marine_02.Entity, "right hand", rifle_03.Entity, "");
            object_set_permutation(marine_02.Entity, "head", "michelle");
        }

        [ScriptMethod(48, Lifecycle.Static)]
        public async Task c03_intra1_01_setup()
        {
            object_create_anew(chief);
            object_create_anew(johnson);
            object_create_anew(pelican_01a);
            object_create_anew(scorpion_01);
            object_create_anew(scarab_01);
            object_create_anew(rifle_01);
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(pelican_01a.Entity, true);
            object_cinematic_lod(scorpion_01.Entity, true);
            object_cinematic_lod(scarab_01.Entity, true);
            objects_attach(chief.Entity, "right hand", rifle_01.Entity, "");
            objects_attach(pelican_01a.Entity, "pelican_sc_01", scorpion_01.Entity, "scorpion_b_t");
            object_set_function_variable(pelican_01a.Entity, "hover", 1F, 0F);
            wake(new ScriptMethodReference(c03_intra1_sound_scene1_01));
            wake(new ScriptMethodReference(c03_intra1_score_01));
            wake(new ScriptMethodReference(c03_intra1_foley_01));
            wake(new ScriptMethodReference(c03_2010_mr3));
            wake(new ScriptMethodReference(c03_2020_mr4));
            wake(new ScriptMethodReference(c03_2030_mr4));
            wake(new ScriptMethodReference(c03_intra1_fov_01));
            wake(new ScriptMethodReference(c03_intra1_cinematic_light_01));
            wake(new ScriptMethodReference(drop_tank));
            wake(new ScriptMethodReference(destroy_scarab));
        }

        [ScriptMethod(49, Lifecycle.Static)]
        public async Task c03_intra1_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._03_intra1_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\music\\c03_intra1_01_mus", 3819110957U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_01_fol", 3819176494U));
            wake(new ScriptMethodReference(c03_intra1_problem_actors));
            await sleep(this.prediction_offset);
            await this.c03_intra1_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_01", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_01", false, anchor_intra1.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_01", false, anchor_intra1.Entity);
            custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_01", false, anchor_intra1.Entity);
            custom_animation_relative(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_01", false, anchor_intra1.Entity);
            custom_animation_relative(pelican_01a.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intra1\\03_intra1", 3819700790U), "pelican_01", false, anchor_intra1.Entity);
            scenery_animation_start_relative(scarab_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\03_intra1\\03_intra1", 3819766327U), "scarab_01", anchor_intra1.Entity);
            await sleep(45);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._03_intra1_02a_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_02a_fol", 3819831864U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task c03_intra1_foley_02a()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_02a_fol", 3819831864U), default(IGameObject), 1F);
            print("c03_intro foley 02a start");
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task c03_2040_jon()
        {
            await sleep(115);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2040_jon", 3819897401U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2040_jon", 1F);
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task c03_2050_mr4()
        {
            await sleep(161);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2050_mr4", 3819962938U), marine_02.Entity, 1F);
            cinematic_subtitle("c03_2050_mr4", 1F);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c03_2060_mr3()
        {
            await sleep(200);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2060_mr3", 3820028475U), marine_01.Entity, 1F);
            cinematic_subtitle("c03_2060_mr3", 3F);
            unit_set_emotional_state(marine_01.Entity, "scared", 0.5F, 30);
            print("marine_01 - angry .5 30");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c03_2070_jon()
        {
            await sleep(288);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2070_jon", 3820094012U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2070_jon", 1F);
            unit_set_emotional_state(johnson.Entity, "angry", 0.5F, 30);
            print("johnson - angry .5 30");
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task c03_2080_mr3()
        {
            await sleep(328);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2080_mr3", 3820159549U), marine_01.Entity, 1F);
            cinematic_subtitle("c03_2080_mr3", 1F);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task c03_2090_jon()
        {
            await sleep(370);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2090_jon", 3820225086U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2090_jon", 1F);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task swap_tanks()
        {
            await sleep(200);
            object_destroy(scorpion_01.Entity);
            object_create_anew(scorpion_02);
            object_cinematic_lod(scorpion_02.Entity, true);
            object_uses_cinematic_lighting(scorpion_02.Entity, true);
            print("swap tanks");
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task c03_intra1_02a_setup()
        {
            wake(new ScriptMethodReference(c03_2040_jon));
            wake(new ScriptMethodReference(c03_2050_mr4));
            wake(new ScriptMethodReference(c03_2060_mr3));
            wake(new ScriptMethodReference(c03_2070_jon));
            wake(new ScriptMethodReference(c03_2080_mr3));
            wake(new ScriptMethodReference(c03_2090_jon));
            wake(new ScriptMethodReference(c03_intra1_foley_02a));
            wake(new ScriptMethodReference(swap_tanks));
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c03_intra1_scene_02a()
        {
            await this.c03_intra1_02a_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02a", default(IUnit), anchor_flag_intra1);
            custom_animation_relative_loop(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02a", false, anchor_intra1.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02a", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02a", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02a", false, anchor_intra1.Entity);
            custom_animation_relative(pelican_01a.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intra1\\03_intra1", 3819700790U), "pelican_02a", false, anchor_intra1.Entity);
            custom_animation_relative_loop(scorpion_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\scorpion\\03_intra1\\03_intra1", 3820290623U), "scorpion_02a", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._03_intra1_02b_predict_stub();
            await sleep((short)camera_time());
            object_destroy(pelican_01a.Entity);
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c03_intra1_speech_easy()
        {
            custom_animation_relative_loop(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02b_easy", false, anchor_intra1.Entity);
            custom_animation_relative_loop(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02b", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02b", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02b", false, anchor_intra1.Entity);
            await sleep(5);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2097_jon", 3820356160U), default(IGameObject), 1F);
            cinematic_subtitle("c03_2097_jon", 8F);
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task c03_intra1_speech_normal()
        {
            custom_animation_relative_loop(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02b_easy", false, anchor_intra1.Entity);
            custom_animation_relative_loop(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02b", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02b", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02b", false, anchor_intra1.Entity);
            await sleep(5);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2091_jon", 3820421697U), default(IGameObject), 1F);
            cinematic_subtitle("c03_2091_jon", 8F);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task c03_intra1_speech_heroic()
        {
            custom_animation_relative_loop(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02b_easy", false, anchor_intra1.Entity);
            custom_animation_relative_loop(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02b", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02b", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02b", false, anchor_intra1.Entity);
            await sleep(5);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2093_jon", 3820487234U), default(IGameObject), 1F);
            cinematic_subtitle("c03_2093_jon", 8F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task c03_intra1_speech_legendary()
        {
            custom_animation_relative_loop(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02b_easy", false, anchor_intra1.Entity);
            custom_animation_relative_loop(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02b", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02b", false, anchor_intra1.Entity);
            custom_animation_relative_loop(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02b", false, anchor_intra1.Entity);
            await sleep(5);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2095_jon", 3820552771U), default(IGameObject), 1F);
            cinematic_subtitle("c03_2095_jon", 8F);
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task c03_intra1_scene_02b()
        {
            if (GameDifficulty.Easy() == game_difficulty_get_real())
            {
                print("easy speech");
                wake(new ScriptMethodReference(c03_intra1_speech_easy));
                camera_set(c03_intra1_01, 0);
                camera_set(c03_intra1_02, 261);
                await sleep(261);
                await sleep(15);
            }

            if (GameDifficulty.Normal() == game_difficulty_get_real())
            {
                print("normal speech");
                wake(new ScriptMethodReference(c03_intra1_speech_normal));
                camera_set(c03_intra1_01, 0);
                camera_set(c03_intra1_02, 246);
                await sleep(246);
                await sleep(15);
            }

            if (GameDifficulty.Heroic() == game_difficulty_get_real())
            {
                print("heroic speech");
                wake(new ScriptMethodReference(c03_intra1_speech_heroic));
                camera_set(c03_intra1_01, 0);
                camera_set(c03_intra1_02, 290);
                await sleep(290);
                await sleep(15);
            }

            if (GameDifficulty.Legendary() == game_difficulty_get_real())
            {
                print("legendary speech");
                wake(new ScriptMethodReference(c03_intra1_speech_legendary));
                camera_set(c03_intra1_01, 0);
                camera_set(c03_intra1_02, 320);
                await sleep(320);
                await sleep(15);
            }

            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._03_intra1_02c_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_02c_fol", 3820618308U));
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task c03_intra1_foley_02c()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_02c_fol", 3820618308U), default(IGameObject), 1F);
            print("c03_intra1 foley 02c start");
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task c03_2092_jon()
        {
            await sleep(4);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2092_jon", 3820683845U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2092_jon", 2F);
            await sleep(65);
            unit_set_emotional_state(marine_01.Entity, "shocked", 0.5F, 30);
            print("marine_01 - shocked .5 30");
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task c03_2094_jon()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2094_jon", 3820749382U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2094_jon", 2F);
            await sleep(65);
            unit_set_emotional_state(marine_01.Entity, "shocked", 0.5F, 30);
            print("marine_01 - shocked .5 30");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c03_2096_jon()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2096_jon", 3820814919U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2096_jon", 2F);
            await sleep(65);
            unit_set_emotional_state(marine_01.Entity, "shocked", 0.5F, 30);
            print("marine_01 - shocked .5 30");
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c03_2098_jon()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2098_jon", 3820880456U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2098_jon", 2F);
            await sleep(65);
            unit_set_emotional_state(marine_01.Entity, "shocked", 0.5F, 30);
            print("marine_01 - shocked .5 30");
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c03_2100_mr4()
        {
            await sleep(81);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2100_mr4", 3820945993U), marine_02.Entity, 1F);
            cinematic_subtitle("c03_2100_mr4", 1F);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task c03_2100_mr4_hard()
        {
            await sleep(86);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2100_mr4", 3820945993U), marine_02.Entity, 1F);
            cinematic_subtitle("c03_2100_mr4", 1F);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task c03_2100_mr4_leg()
        {
            await sleep(102);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2100_mr4", 3820945993U), marine_02.Entity, 1F);
            cinematic_subtitle("c03_2100_mr4", 1F);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task c03_2110_jon()
        {
            await sleep(119);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2110_jon", 3821011530U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2110_jon", 3F);
            await sleep(90);
            unit_set_emotional_state(marine_01.Entity, "repulsed", 0.25F, 60);
            print("marine_01 - repulsed .25 60");
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c03_2110_jon_leg()
        {
            await sleep(133);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2110_jon", 3821011530U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2110_jon", 3F);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task c03_2120_jon()
        {
            await sleep(235);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2120_jon", 3821077067U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2120_jon", 3F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task c03_2120_jon_leg()
        {
            await sleep(249);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2120_jon", 3821077067U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2120_jon", 2F);
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task c03_2130_mr4()
        {
            await sleep(301);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2130_mr4", 3821142604U), marine_02.Entity, 1F);
            cinematic_subtitle("c03_2130_mr4", 1F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c03_2130_mr4_leg()
        {
            await sleep(315);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2130_mr4", 3821142604U), marine_02.Entity, 1F);
            cinematic_subtitle("c03_2130_mr4", 1F);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task c03_2140_cor()
        {
            await sleep(352);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2140_cor", 3821208141U), default(IGameObject), 1F, "radio_default_in");
            cinematic_subtitle("c03_2140_cor", 3F);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task c03_2140_cor_leg()
        {
            await sleep(366);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2140_cor", 3821208141U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c03_2140_cor", 3F);
        }

        [ScriptMethod(81, Lifecycle.Static)]
        public async Task c03_intra1_scene_02c()
        {
            unit_set_emotional_state(johnson.Entity, "angry", 0.5F, 0);
            print("johnson - angry .5 0");
            unit_set_emotional_state(marine_01.Entity, "scared", 0.5F, 0);
            print("marine_01 - scared .5 0");
            if (GameDifficulty.Easy() == game_difficulty_get_real())
            {
                print("easy speech");
                object_create_anew(cigar);
                wake(new ScriptMethodReference(c03_2098_jon));
                wake(new ScriptMethodReference(c03_2100_mr4));
                wake(new ScriptMethodReference(c03_2110_jon));
                wake(new ScriptMethodReference(c03_2120_jon));
                wake(new ScriptMethodReference(c03_2130_mr4));
                wake(new ScriptMethodReference(c03_2140_cor));
                wake(new ScriptMethodReference(c03_intra1_foley_02c));
                camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02ce", default(IUnit), anchor_flag_intra1);
                custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02ce", false, anchor_intra1.Entity);
                custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02ce", false, anchor_intra1.Entity);
                custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02ce", false, anchor_intra1.Entity);
                custom_animation_relative(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02ce", false, anchor_intra1.Entity);
                scenery_animation_start_relative(cigar.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_good\\03_intra1\\03_intra1", 3821273678U), "cigar_02e", anchor_intra1.Entity);
            }

            if (GameDifficulty.Normal() == game_difficulty_get_real())
            {
                print("normal speech");
                object_create_anew(cigar);
                wake(new ScriptMethodReference(c03_2092_jon));
                wake(new ScriptMethodReference(c03_2100_mr4));
                wake(new ScriptMethodReference(c03_2110_jon));
                wake(new ScriptMethodReference(c03_2120_jon));
                wake(new ScriptMethodReference(c03_2130_mr4));
                wake(new ScriptMethodReference(c03_2140_cor));
                wake(new ScriptMethodReference(c03_intra1_foley_02c));
                camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02cn", default(IUnit), anchor_flag_intra1);
                custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02cn", false, anchor_intra1.Entity);
                custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02cn", false, anchor_intra1.Entity);
                custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02cn", false, anchor_intra1.Entity);
                custom_animation_relative(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02cn", false, anchor_intra1.Entity);
                scenery_animation_start_relative(cigar.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_good\\03_intra1\\03_intra1", 3821273678U), "cigar_02n", anchor_intra1.Entity);
            }

            if (GameDifficulty.Heroic() == game_difficulty_get_real())
            {
                print("heroic speech");
                object_create_anew(cigar);
                wake(new ScriptMethodReference(c03_2094_jon));
                wake(new ScriptMethodReference(c03_2100_mr4_hard));
                wake(new ScriptMethodReference(c03_2110_jon));
                wake(new ScriptMethodReference(c03_2120_jon));
                wake(new ScriptMethodReference(c03_2130_mr4));
                wake(new ScriptMethodReference(c03_2140_cor));
                wake(new ScriptMethodReference(c03_intra1_foley_02c));
                camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02ch", default(IUnit), anchor_flag_intra1);
                custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02ch", false, anchor_intra1.Entity);
                custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02ch", false, anchor_intra1.Entity);
                custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02ch", false, anchor_intra1.Entity);
                custom_animation_relative(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02ch", false, anchor_intra1.Entity);
                scenery_animation_start_relative(cigar.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_good\\03_intra1\\03_intra1", 3821273678U), "cigar_02h", anchor_intra1.Entity);
            }

            if (GameDifficulty.Legendary() == game_difficulty_get_real())
            {
                print("legendary speech");
                object_create_anew(cigar);
                wake(new ScriptMethodReference(c03_2096_jon));
                wake(new ScriptMethodReference(c03_2100_mr4_leg));
                wake(new ScriptMethodReference(c03_2110_jon_leg));
                wake(new ScriptMethodReference(c03_2120_jon_leg));
                wake(new ScriptMethodReference(c03_2130_mr4_leg));
                wake(new ScriptMethodReference(c03_2140_cor_leg));
                wake(new ScriptMethodReference(c03_intra1_foley_02c));
                camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02cl", default(IUnit), anchor_flag_intra1);
                custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02cl", false, anchor_intra1.Entity);
                custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02cl", false, anchor_intra1.Entity);
                custom_animation_relative(marine_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02cl", false, anchor_intra1.Entity);
                custom_animation_relative(marine_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02cl", false, anchor_intra1.Entity);
                scenery_animation_start_relative(cigar.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_good\\03_intra1\\03_intra1", 3821273678U), "cigar_02l", anchor_intra1.Entity);
            }

            await sleep((short)((float)camera_time() - 15));
            object_destroy(pelican_01a.Entity);
            object_destroy(cigar.Entity);
            print("problem actors");
            object_create_anew(pelican_01b);
            object_create_anew(rear_gun);
            object_cinematic_lod(pelican_01b.Entity, true);
            object_cinematic_lod(rear_gun.Entity, true);
            object_uses_cinematic_lighting(pelican_01b.Entity, true);
            object_uses_cinematic_lighting(rear_gun.Entity, true);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._03_intra1_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_03_fol", 3821339215U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task c03_intra1_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_03_fol", 3821339215U), default(IGameObject), 1F);
            print("c03_intra1 foley 03 start");
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c03_2150_jon()
        {
            await sleep(59);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2150_jon", 3821404752U), johnson.Entity, 1F);
            cinematic_subtitle("c03_2150_jon", 2F);
            await sleep(15);
            unit_set_emotional_state(johnson.Entity, "amorous", 1F, 15);
            print("johnson - amorous 1 15");
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task c03_intra1_cinematic_light_03()
        {
            cinematic_lighting_set_primary_light(31F, 72F, 0.105882F, 0.0941177F, 0.0705882F);
            cinematic_lighting_set_secondary_light(17F, 56F, 0.0784314F, 0.0784314F, 0.129412F);
            cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0392157F);
        }

        [ScriptMethod(85, Lifecycle.Static)]
        public async Task c03_intra1_03_setup()
        {
            wake(new ScriptMethodReference(c03_2150_jon));
            wake(new ScriptMethodReference(c03_intra1_foley_03));
            wake(new ScriptMethodReference(c03_intra1_cinematic_light_03));
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task c03_intra1_03_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(johnson.Entity);
            object_destroy(marine_01.Entity);
            object_destroy(marine_02.Entity);
            object_destroy(rear_gun.Entity);
            object_destroy(pelican_01b.Entity);
            object_destroy(scorpion_02.Entity);
            object_destroy(rifle_01.Entity);
            object_destroy(rifle_02.Entity);
            object_destroy(rifle_03.Entity);
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task c03_intra1_scene_03()
        {
            await this.c03_intra1_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_03", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_03", false, anchor_intra1.Entity);
            custom_animation_relative(pelican_01b.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intra1\\03_intra1", 3819700790U), "pelican_03", false, anchor_intra1.Entity);
            scenery_animation_start_relative(rear_gun.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\03_intra1\\03_intra1", 3821470289U), "rear_gun_03", anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c03_intra1_03_cleanup();
            await sleep(30);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task c03_intra1()
        {
            texture_cache_flush();
            geometry_cache_flush();
            sound_class_set_gain("vehicle_collision", 0F, 0);
            sound_class_set_gain("amb", 0.25F, 1);
            switch_bsp_by_name(GetReference<IBsp>("earthcity_3b"));
            await sleep(1);
            await this.c03_intra1_scene_01();
            await this.c03_intra1_scene_02a();
            await this.c03_intra1_scene_02b();
            await this.c03_intra1_scene_02c();
            await this.c03_intra1_scene_03();
            sound_class_set_gain("vehicle_collision", 1F, 1);
            sound_class_set_gain("amb", 1F, 1);
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x03_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_01_fol", 3821535826U), default(IGameObject), 1F);
            print("x03 foley 01 start");
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task x03_0010_jon()
        {
            await sleep(484);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0010_jon", 3821601363U), johnson.Entity, 1F, "radio_default");
            cinematic_subtitle("x03_0010_jon", 2F);
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task x03_0020_mir()
        {
            await sleep(552);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0020_mir", 3821666900U), default(IGameObject), 1F, "radio_default");
            cinematic_subtitle("x03_0020_mir", 1.5F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x03_fov_01()
        {
            await sleep(88);
            print("fov change: 65 -> 45 over 90 ticks");
            camera_set_field_of_view(55F, 90);
            await sleep(91);
            print("fov change: 45 -> 50 over 0 ticks");
            camera_set_field_of_view(60F, 0);
            await sleep(299);
            print("fov change: 50 -> 20 over 0 ticks");
            camera_set_field_of_view(20F, 0);
            object_destroy(scarab_02.Entity);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x03_01_dof_1()
        {
            await sleep(479);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 1F, 1F, 0F, 0F, 0F, 0F);
            print("rack focus");
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task scarab_shake_1()
        {
            await sleep(135);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task scarab_shake_2()
        {
            await sleep(179);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.4F, 0F);
            await sleep(25);
            player_effect_stop(3F);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task effect_scarab_death()
        {
            await sleep(27);
            print("blow main-gun");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion_mouth", 3821732437U), scarab_02.Entity, "primary_trigger");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "head_destroyed_cine");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "neck_destroyed_cine");
            await sleep(3);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "neck_destroyed2_cine");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "knee_destroyed_cine");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "belly_destroyed_cine");
            await sleep(3);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "calf_destroyed_cine");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "knee_destroyed02_cine");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task effect_smoke_start()
        {
            await sleep(165);
            print("smoke start");
            object_create(x03_smoke);
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task effect_smoke_stop()
        {
            await sleep(475);
            print("smoke stop");
            object_destroy(x03_smoke.Entity);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task effect_grav_lift()
        {
            await sleep(330);
            object_set_function_variable(carrier.Entity, "grav_lift_control", 0F, 75F);
            print("grav-lift deactivate");
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_01()
        {
            cinematic_lighting_set_primary_light(31F, 72F, 0.529412F, 0.466667F, 0.396078F);
            cinematic_lighting_set_secondary_light(-60F, 180F, 0.0627451F, 0.0588235F, 0.117647F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(johnson_02.Entity, true);
            object_uses_cinematic_lighting(pilot.Entity, true);
            object_uses_cinematic_lighting(pelican_01a.Entity, true);
            object_uses_cinematic_lighting(scarab_02.Entity, true);
            object_uses_cinematic_lighting(carrier.Entity, true);
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x03_01_setup()
        {
            object_create_anew(chief);
            object_create_anew(johnson_02);
            object_create_anew(pilot);
            object_create_anew(pelican_01a);
            object_create_anew(scarab_02);
            object_create_anew(carrier);
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(johnson_02.Entity, true);
            object_cinematic_lod(pilot.Entity, true);
            object_cinematic_lod(pelican_01a.Entity, true);
            object_cinematic_lod(scarab_02.Entity, true);
            object_cinematic_lod(carrier.Entity, true);
            cinematic_clone_players_weapon(chief.Entity, "right_hand", "");
            object_set_function_variable(carrier.Entity, "grav_lift_control", 1F, 0F);
            wake(new ScriptMethodReference(x03_0010_jon));
            wake(new ScriptMethodReference(x03_0020_mir));
            wake(new ScriptMethodReference(x03_foley_01));
            wake(new ScriptMethodReference(x03_fov_01));
            wake(new ScriptMethodReference(x03_01_dof_1));
            wake(new ScriptMethodReference(scarab_shake_1));
            wake(new ScriptMethodReference(scarab_shake_2));
            wake(new ScriptMethodReference(effect_grav_lift));
            wake(new ScriptMethodReference(effect_scarab_death));
            wake(new ScriptMethodReference(effect_smoke_start));
            wake(new ScriptMethodReference(effect_smoke_stop));
            wake(new ScriptMethodReference(x03_cinematic_lighting_01));
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x03_01_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(johnson_02.Entity);
            object_destroy(pilot.Entity);
            object_destroy(pelican_01a.Entity);
            object_destroy(carrier.Entity);
            object_destroy(x03_smoke.Entity);
        }

        [ScriptMethod(103, Lifecycle.Static)]
        public async Task x03_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.x03_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_01_fol", 3821535826U));
            await sleep(this.prediction_offset);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_01", default(IUnit), anchor_flag_x03_01);
            await this.x03_01_setup();
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x03\\x03", 3823501936U), "chief_01", false, anchor_x03_01.Entity);
            custom_animation_relative(johnson_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "johnson_01", false, anchor_x03_01.Entity);
            custom_animation_relative(pilot.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "pilot_01", false, anchor_x03_01.Entity);
            custom_animation_relative(pelican_01a.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\x03\\x03", 3823633010U), "pelican_01", false, anchor_x03_01.Entity);
            scenery_animation_start_relative(scarab_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\x03\\x03", 3823698547U), "scarab_01", anchor_x03_01.Entity);
            scenery_animation_start_relative(carrier.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_01", anchor_x03_01.Entity);
            await sleep(15);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_02_fol", 3823829621U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.x03_01_cleanup();
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task c03_intra1_sound_scene2_01()
        {
            await sleep(30);
            sound_class_set_gain("vehicle_engine", 0.2F, 60);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x03_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_02_fol", 3823829621U), default(IGameObject), 1F);
            print("x03 foley 02 start");
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task x03_0030_mir()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0030_mir", 3823895158U), miranda.Entity, 1F);
            cinematic_subtitle("x03_0030_mir", 2F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task x03_0040_jon()
        {
            await sleep(73);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0040_jon", 3823960695U), johnson_03.Entity, 1F, "radio_default");
            cinematic_subtitle("x03_0040_jon", 1F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task x03_0050_lhd()
        {
            await sleep(106);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0050_lhd", 3824026232U), hood.Entity, 1F, "radio_default");
            cinematic_subtitle("x03_0050_lhd", 1F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task x03_0060_mir()
        {
            await sleep(133);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0060_mir", 3824091769U), miranda.Entity, 1F);
            cinematic_subtitle("x03_0060_mir", 3F);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x03_texture_camera_scene_02()
        {
            print("texture camera start");
            object_create_anew(texture_camera);
            texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            scenery_animation_start_relative(texture_camera.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\x03\\x03", 3824157306U), "texture_camera_02", anchor_x03_02.Entity);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_02()
        {
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-14F, 150F, 0.09F, 0.09F, 0.22F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(iac_bridge.Entity, true);
            object_uses_cinematic_lighting(hood.Entity, true);
            object_uses_cinematic_lighting(johnson_03.Entity, true);
            object_uses_cinematic_lighting(pilot_02.Entity, true);
        }

        [ScriptMethod(112, Lifecycle.Static)]
        public async Task x03_03_problem_actors()
        {
            print("problem actors");
            object_create_anew(iac);
            object_cinematic_lod(iac.Entity, true);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task delete_johnson()
        {
            await sleep(150);
            print("delete johnson and pelican");
            object_destroy(johnson_03.Entity);
            object_destroy(pilot_02.Entity);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x03_emotion_02()
        {
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            print("miranda - angry .25 0");
            unit_set_emotional_state(johnson.Entity, "angry", 0.5F, 0);
            print("johnson - angry .5 0");
            unit_set_emotional_state(hood.Entity, "angry", 0.25F, 0);
            print("hood - angry .25 0");
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task x03_02_setup()
        {
            object_create_anew(miranda);
            object_create_anew(hood);
            object_create(johnson_03);
            object_create(pilot_02);
            object_create_anew(iac_bridge);
            object_create_anew(pelican_02);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(hood.Entity, true);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(pilot.Entity, true);
            object_cinematic_lod(iac_bridge.Entity, true);
            object_cinematic_lod(pelican_02.Entity, true);
            wake(new ScriptMethodReference(c03_intra1_sound_scene2_01));
            wake(new ScriptMethodReference(x03_foley_02));
            wake(new ScriptMethodReference(x03_0030_mir));
            wake(new ScriptMethodReference(x03_0040_jon));
            wake(new ScriptMethodReference(x03_0050_lhd));
            wake(new ScriptMethodReference(x03_0060_mir));
            wake(new ScriptMethodReference(delete_johnson));
            wake(new ScriptMethodReference(x03_emotion_02));
            wake(new ScriptMethodReference(x03_texture_camera_scene_02));
            wake(new ScriptMethodReference(x03_cinematic_lighting_02));
        }

        [ScriptMethod(116, Lifecycle.Static)]
        public async Task x03_scene_02()
        {
            cinematic_screen_effect_stop();
            print("rack focus stop");
            camera_set_field_of_view(60F, 0);
            await this.x03_02_predict_stub();
            await this.x03_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_02", default(IUnit), anchor_flag_x03_02);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x03\\x03", 3824222843U), "miranda_02", false, anchor_x03_02.Entity);
            custom_animation_relative(johnson_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "johnson_02", false, anchor_x03_02.Entity);
            custom_animation_relative(pilot_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "pilot_02", false, anchor_x03_02.Entity);
            custom_animation_relative(hood.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x03\\x03", 3826647712U), "hood_02", false, anchor_x03_02.Entity);
            custom_animation_relative(pelican_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\x03\\x03", 3823633010U), "pelican_02", false, anchor_x03_02.Entity);
            scenery_animation_start_relative(iac_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x03\\x03", 3826778786U), "iacbridge_02", anchor_x03_02.Entity);
            await sleep(20);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x03_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\music\\x03_03_mus", 3826844323U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_03_fol", 3826909860U));
            await sleep((short)((float)camera_time() - 15));
            await this.x03_03_problem_actors();
            await sleep((short)camera_time());
            print("texture camera stop");
            object_hide(hood.Entity, true);
            print("hide hood");
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task x03_score_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\music\\x03_03_mus", 3826844323U), default(IGameObject), 1F);
            print("x03 score 03 start");
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task x03_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_03_fol", 3826909860U), default(IGameObject), 1F);
            print("x03 foley 03 start");
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x03_0070_lhd()
        {
            await sleep(0);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0070_lhd", 3826975397U), default(IGameObject), 1F, "radio_default");
            cinematic_subtitle("x03_0070_lhd", 1F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task x03_0080_lhd()
        {
            await sleep(50);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0080_lhd", 3827040934U), default(IGameObject), 1F, "radio_default");
            cinematic_subtitle("x03_0080_lhd", 2F);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task x03_0090_nv1()
        {
            await sleep(195);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0090_nv1", 3827106471U), default(IGameObject), 1F);
            cinematic_subtitle("x03_0090_nv1", 3F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task x03_fov_03()
        {
            await sleep(27);
            print("fov change: 5 -> 50 over 38 ticks");
            camera_set_field_of_view(60F, 38);
            await sleep(191);
            print("fov change: 50 -> 15 over 26 ticks");
            camera_set_field_of_view(25F, 26);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task effect_slipspace_open()
        {
            await sleep(161);
            print("effect - slipspace open");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\03\\slipspace_open", 3827172008U), carrier_02.Entity, "bow");
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_03()
        {
            cinematic_lighting_set_primary_light(31F, 68F, 0.513726F, 0.415686F, 0.313726F);
            cinematic_lighting_set_secondary_light(-63F, 42F, 0.0901961F, 0.0901961F, 0.117647F);
            cinematic_lighting_set_ambient_light(0.0823529F, 0.0823529F, 0.0823529F);
            object_uses_cinematic_lighting(iac.Entity, true);
            object_uses_cinematic_lighting(carrier_02.Entity, true);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task x03_04_problem_actors()
        {
            print("problem actors");
            object_create_anew(nav_officer);
            object_cinematic_lod(nav_officer.Entity, true);
            object_uses_cinematic_lighting(nav_officer.Entity, true);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task hide_iac_crew_03()
        {
            print("hide iac bridge");
            object_hide(miranda.Entity, true);
            object_hide(iac_bridge.Entity, true);
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x03_03_setup()
        {
            object_create_anew(carrier_02);
            object_cinematic_lod(carrier_02.Entity, true);
            wake(new ScriptMethodReference(x03_0070_lhd));
            wake(new ScriptMethodReference(x03_0080_lhd));
            wake(new ScriptMethodReference(x03_0090_nv1));
            wake(new ScriptMethodReference(x03_score_03));
            wake(new ScriptMethodReference(x03_foley_03));
            wake(new ScriptMethodReference(x03_fov_03));
            wake(new ScriptMethodReference(x03_cinematic_lighting_03));
            wake(new ScriptMethodReference(effect_slipspace_open));
            wake(new ScriptMethodReference(hide_iac_crew_03));
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task x03_scene_03()
        {
            print("fov change: 50 -> 5 over 0 ticks");
            camera_set_field_of_view(15F, 0);
            await this.x03_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_03", default(IUnit), anchor_flag_x03_02);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x03\\x03", 3827892915U), "iac_03", anchor_x03_02.Entity);
            scenery_animation_start_relative(carrier_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_03", anchor_x03_02.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x03_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_04_fol", 3827958452U));
            await this.x03_04_problem_actors();
            await sleep((short)((float)camera_time() - 5));
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task x03_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_04_fol", 3827958452U), default(IGameObject), 1F);
            print("x03 foley 04 start");
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task x03_0100_nv1()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0100_nv1", 3828023989U), nav_officer.Entity, 1F);
            cinematic_subtitle("x03_0100_nv1", 2F);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task x03_0110_mir()
        {
            await sleep(121);
            object_hide(iac.Entity, true);
            object_hide(carrier_02.Entity, true);
            print("hide iac, carrier");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0110_mir", 3828089526U), miranda.Entity, 1F);
            cinematic_subtitle("x03_0110_mir", 1F);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 30);
            print("miranda - shocked .25 30");
            await sleep(30);
            object_hide(hood.Entity, false);
            print("unhide hoodr");
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task x03_0120_lhd()
        {
            await sleep(175);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0120_lhd", 3828155063U), hood.Entity, 1F, "radio_default");
            cinematic_subtitle("x03_0120_lhd", 2F);
            unit_set_emotional_state(hood.Entity, "angry", 0.5F, 30);
            print("hood - angry .5 30");
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task x03_texture_camera_scene_04()
        {
            print("texture camera start");
            object_create_anew(texture_camera);
            texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            scenery_animation_start_relative(texture_camera.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\x03\\x03", 3824157306U), "texture_camera_04", anchor_x03_02.Entity);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_04()
        {
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-14F, 150F, 0.09F, 0.09F, 0.22F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task x03_emotion_04()
        {
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            print("miranda - angry .25 0");
            unit_set_emotional_state(hood.Entity, "angry", 0.25F, 0);
            print("hood - angry .25 0");
            unit_set_emotional_state(nav_officer.Entity, "angry", 0.25F, 0);
            print("nav_officer - angry .25 0");
            await sleep(20);
            unit_set_emotional_state(nav_officer.Entity, "shocked", 0.5F, 30);
            print("nav_officer - shocked .5 30");
        }

        [ScriptMethod(136, Lifecycle.Static)]
        public async Task x03_04_setup()
        {
            object_hide(miranda.Entity, false);
            object_hide(iac_bridge.Entity, false);
            cinematic_set_near_clip_distance(0.05F);
            print("setting near clip distance to .05");
            wake(new ScriptMethodReference(x03_0100_nv1));
            wake(new ScriptMethodReference(x03_0110_mir));
            wake(new ScriptMethodReference(x03_0120_lhd));
            wake(new ScriptMethodReference(x03_foley_04));
            wake(new ScriptMethodReference(x03_texture_camera_scene_04));
            wake(new ScriptMethodReference(x03_cinematic_lighting_04));
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task x03_scene_04()
        {
            print("fov change: 15 -> 50 over 0 ticks");
            camera_set_field_of_view(60F, 0);
            await this.x03_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_04", default(IUnit), anchor_flag_x03_02);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x03\\x03", 3824222843U), "miranda_04", false, anchor_x03_02.Entity);
            custom_animation_relative(hood.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x03\\x03", 3826647712U), "hood_04", false, anchor_x03_02.Entity);
            custom_animation_relative(nav_officer.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "nav_04", false, anchor_x03_02.Entity);
            scenery_animation_start_relative(iac_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x03\\x03", 3826778786U), "iacbridge_04", anchor_x03_02.Entity);
            scenery_animation_start_relative(carrier_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_04", anchor_x03_02.Entity);
            await sleep(10);
            fade_in(1F, 1F, 1F, 5);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x03_05_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_05_fol", 3828220600U));
            await sleep((short)camera_time());
            object_destroy(hood.Entity);
            texture_camera_off();
            print("texture camera stop");
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task x03_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_05_fol", 3828220600U), default(IGameObject), 1F);
            print("x03 foley 05 start");
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task x03_0130_mir()
        {
            await sleep(94);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0130_mir", 3828286137U), default(IGameObject), 1F);
            cinematic_subtitle("x03_0130_mir", 1.5F);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task effect_iac_engines()
        {
            await sleep(112);
            print("effect - engine");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\03\\iac_engine_fire", 3828351674U), iac.Entity, "");
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task effect_slipspace_widen()
        {
            await sleep(0);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\03\\slipspace_widening", 3828679359U), carrier_02.Entity, "bow");
            print("slipspace open");
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_05()
        {
            cinematic_lighting_set_primary_light(31F, 42F, 0.662745F, 0.470588F, 0.278431F);
            cinematic_lighting_set_secondary_light(-18F, 30F, 0.121569F, 0.113725F, 0.219608F);
            cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0392157F);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task delete_pelican()
        {
            await sleep(87);
            object_destroy(pelican_02.Entity);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task hide_iac_crew_05()
        {
            print("hide iac bridge");
            object_hide(miranda.Entity, true);
            object_hide(nav_officer.Entity, true);
            object_hide(iac_bridge.Entity, true);
        }

        [ScriptMethod(145, Lifecycle.Static)]
        public async Task x03_05_setup()
        {
            object_hide(iac.Entity, false);
            object_hide(carrier_02.Entity, false);
            cinematic_set_near_clip_distance(0.06F);
            print("resetting near clip distance to .06");
            wake(new ScriptMethodReference(x03_foley_05));
            wake(new ScriptMethodReference(x03_0130_mir));
            wake(new ScriptMethodReference(x03_cinematic_lighting_05));
            wake(new ScriptMethodReference(effect_iac_engines));
            wake(new ScriptMethodReference(effect_slipspace_widen));
            wake(new ScriptMethodReference(delete_pelican));
            wake(new ScriptMethodReference(hide_iac_crew_05));
        }

        [ScriptMethod(146, Lifecycle.Static)]
        public async Task x03_scene_05()
        {
            await this.x03_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_05", default(IUnit), anchor_flag_x03_02);
            custom_animation_relative(pelican_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\x03\\x03", 3823633010U), "pelican_05", false, anchor_x03_02.Entity);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x03\\x03", 3827892915U), "iac_05", anchor_x03_02.Entity);
            scenery_animation_start_relative(carrier_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_05", anchor_x03_02.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x03_06_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_06_fol", 3828744896U));
            await sleep((short)((float)camera_time() - 5));
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task x03_foley_06()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_06_fol", 3828744896U), default(IGameObject), 1F);
            print("x03 foley 06 start");
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task x03_0140_nv1()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0140_nv1", 3828810433U), nav_officer.Entity, 1F);
            cinematic_subtitle("x03_0140_nv1", 2F);
            unit_set_emotional_state(miranda.Entity, "angry", 0.15F, 0);
            print("miranda - angry .15 0");
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task x03_0150_mir()
        {
            await sleep(55);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0150_mir", 3828875970U), miranda.Entity, 1F);
            cinematic_subtitle("x03_0150_mir", 1F);
            unit_set_emotional_state(miranda.Entity, "angry", 0.35F, 45);
            print("miranda - angry .35 45");
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task x03_fov_06()
        {
            await sleep(53);
            print("fov change: 80 -> 60 over 0 ticks");
            camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task x03_texture_camera_scene_06()
        {
            print("texture camera start");
            object_create_anew(texture_camera);
            texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            scenery_animation_start_relative(texture_camera.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\x03\\x03", 3824157306U), "texture_camera_06", anchor_x03_02.Entity);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_06()
        {
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-14F, 150F, 0.09F, 0.09F, 0.22F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(153, Lifecycle.Static)]
        public async Task x03_06_setup()
        {
            object_hide(miranda.Entity, false);
            object_hide(nav_officer.Entity, false);
            object_hide(iac_bridge.Entity, false);
            wake(new ScriptMethodReference(x03_0140_nv1));
            wake(new ScriptMethodReference(x03_0150_mir));
            wake(new ScriptMethodReference(x03_foley_06));
            wake(new ScriptMethodReference(x03_texture_camera_scene_06));
            wake(new ScriptMethodReference(x03_fov_06));
            wake(new ScriptMethodReference(x03_cinematic_lighting_06));
        }

        [ScriptMethod(154, Lifecycle.Static)]
        public async Task x03_06_cleanup()
        {
            object_destroy(miranda.Entity);
            object_destroy(nav_officer.Entity);
            object_destroy(iac_bridge.Entity);
        }

        [ScriptMethod(155, Lifecycle.Static)]
        public async Task x03_scene_06()
        {
            camera_set_field_of_view(80F, 0);
            await this.x03_06_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_06", default(IUnit), anchor_flag_x03_02);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x03\\x03", 3824222843U), "miranda_06", false, anchor_x03_02.Entity);
            custom_animation_relative(nav_officer.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "nav_06", false, anchor_x03_02.Entity);
            scenery_animation_start_relative(iac_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x03\\x03", 3826778786U), "iacbridge_06", anchor_x03_02.Entity);
            scenery_animation_start_relative(carrier_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_06", anchor_x03_02.Entity);
            await sleep(10);
            fade_in(1F, 1F, 1F, 5);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x03_07_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_07_fol", 3828941507U));
            await sleep((short)camera_time());
            await this.x03_06_cleanup();
            texture_camera_off();
            print("texture camera stop");
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task x03_foley_07()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_07_fol", 3828941507U), default(IGameObject), 1F);
            print("x03 foley 07 start");
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task effect_slipspace_collapse()
        {
            await sleep(150);
            object_create_anew(x03_slipspace_collapse);
            print("effect - slipspace collapse");
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task effect_shockwave_start()
        {
            await sleep(218);
            object_create_anew(x03_shockwave_start);
            print("effect - shockwave start");
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task shockwave_shake_01()
        {
            time_code_reset();
            await sleep(234);
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.4F, 1F);
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_07()
        {
            cinematic_lighting_set_primary_light(31F, 42F, 0.662745F, 0.470588F, 0.278431F);
            cinematic_lighting_set_secondary_light(-18F, 30F, 0.121569F, 0.113725F, 0.219608F);
            cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0392157F);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task delete_iac()
        {
            await sleep(152);
            object_destroy(iac.Entity);
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task delete_carrier()
        {
            await sleep(172);
            object_destroy(carrier_02.Entity);
        }

        [ScriptMethod(163, Lifecycle.Static)]
        public async Task x03_07_setup()
        {
            wake(new ScriptMethodReference(delete_iac));
            wake(new ScriptMethodReference(delete_carrier));
            wake(new ScriptMethodReference(effect_slipspace_collapse));
            wake(new ScriptMethodReference(effect_shockwave_start));
            wake(new ScriptMethodReference(shockwave_shake_01));
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\03\\slipspace_widening", 3828679359U), carrier_02.Entity, "bow");
            wake(new ScriptMethodReference(x03_cinematic_lighting_07));
            wake(new ScriptMethodReference(x03_foley_07));
        }

        [ScriptMethod(164, Lifecycle.Static)]
        public async Task x03_scene_07()
        {
            await this.x03_07_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_07", default(IUnit), anchor_flag_x03_02);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x03\\x03", 3827892915U), "iac_07", anchor_x03_02.Entity);
            scenery_animation_start_relative(carrier_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_07", anchor_x03_02.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x03_08_predict_stub();
            await sleep((short)((float)camera_time() - 5));
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
            player_effect_stop(0F);
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task effect_ease_on_down_the_road()
        {
            await sleep(0);
            object_create_anew(x03_shockwave_close);
            print("effetc - tetsuo!!!");
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task effect_akira()
        {
            await sleep(130);
            object_create_anew(x03_shockwave_far);
            print("effect - kaneda!!!");
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task shockwave_shake_02()
        {
            time_code_reset();
            await sleep(40);
            print("shake start");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.5F, 2F);
            time_code_reset();
            await sleep(89);
            print("shake stop");
            player_effect_stop(0F);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task shockwave_shake_03()
        {
            time_code_reset();
            await sleep(270);
            print("shake start");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 6F);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task final_fade()
        {
            await sleep(125);
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
            await sleep(10);
            fade_in(1F, 1F, 1F, 5);
        }

        [ScriptMethod(170, Lifecycle.Static)]
        public async Task x03_08_setup()
        {
            object_create_anew(x03_bus);
            object_create_anew(x03_truck);
            object_create_anew(x03_generator);
            object_create_anew(x03_dumpster);
            object_destroy_containing("x03_palm");
            object_destroy(x03_shockwave_start.Entity);
            object_destroy(x03_slipspace_collapse.Entity);
            wake(new ScriptMethodReference(effect_ease_on_down_the_road));
            wake(new ScriptMethodReference(final_fade));
            wake(new ScriptMethodReference(effect_akira));
            wake(new ScriptMethodReference(shockwave_shake_02));
            wake(new ScriptMethodReference(shockwave_shake_03));
        }

        [ScriptMethod(171, Lifecycle.Static)]
        public async Task x03_08_cleanup()
        {
            object_destroy(x03_shockwave_close.Entity);
            object_destroy(x03_shockwave_far.Entity);
            object_destroy(x03_bus.Entity);
            object_destroy(x03_truck.Entity);
            object_destroy(x03_generator.Entity);
            object_destroy(x03_dumpster.Entity);
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task x03_scene_08()
        {
            await this.x03_08_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_08", default(IUnit), anchor_flag_x03_03);
            scenery_animation_start_relative(x03_bus.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\civilian\\bus\\x03\\x03", 3829007044U), "bus_08", anchor_x03_03.Entity);
            scenery_animation_start_relative(x03_truck.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\civilian\\panel_truck\\x03\\x03", 3829072581U), "panel_truck_08", anchor_x03_03.Entity);
            scenery_animation_start_relative(x03_generator.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_big_generator\\x03\\x03", 3829138118U), "big_generator_08", anchor_x03_03.Entity);
            scenery_animation_start_relative(x03_dumpster.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_dumpster\\x03\\x03", 3829203655U), "dumpster_08", anchor_x03_03.Entity);
            await sleep(10);
            fade_in(1F, 1F, 1F, 5);
            await sleep((short)((float)camera_time() - 5));
            fade_out(0F, 0F, 0F, 5);
            await sleep(5);
            player_effect_stop(1F);
            await this.x03_08_cleanup();
            await sleep(150);
        }

        [ScriptMethod(173, Lifecycle.Static)]
        public async Task x03()
        {
            texture_cache_flush();
            geometry_cache_flush();
            sound_class_set_gain("vehicle", 0.5F, 0);
            sound_class_set_gain("amb", 0.5F, 0);
            switch_bsp_by_name(GetReference<IBsp>("earthcity_4"));
            await sleep(1);
            await this.x03_scene_01();
            switch_bsp_by_name(GetReference<IBsp>("earthcity_cine_intro_bsp"));
            await sleep(5);
            await this.x03_scene_02();
            await this.x03_scene_03();
            await this.x03_scene_04();
            await this.x03_scene_05();
            await this.x03_scene_06();
            await this.x03_scene_07();
            await this.x03_scene_08();
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task chapter_title0()
        {
            await sleep(30);
            if (await this.difficulty_legendary())
            {
                cinematic_set_title(title0_legendary);
            }
            else if (await this.difficulty_heroic())
            {
                cinematic_set_title(title0_heroic);
            }
            else
            {
                cinematic_set_title(title0_normal);
            }

            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
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

        [ScriptMethod(176, Lifecycle.Dormant)]
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

        [ScriptMethod(177, Lifecycle.Static)]
        public async Task cinematic_intro()
        {
            if (await this.cinematic_skip_start())
            {
                await this.c03_intra1();
            }

            await this.cinematic_skip_stop();
        }

        [ScriptMethod(178, Lifecycle.Static)]
        public async Task cinematic_outro()
        {
            if (await this.cinematic_skip_start())
            {
                await this.x03();
            }

            await this.cinematic_skip_stop();
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task objective0_set()
        {
            await sleep(90);
            objectives_show_up_to(0);
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task objective0_clear()
        {
            objectives_finish_up_to(0);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task objective1_set()
        {
            await sleep_until(async () => volume_test_objects(tv_e17_objectives, players()), 15);
            await sleep(30);
            objectives_show_up_to(1);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task objective1_clear()
        {
            objectives_finish_up_to(1);
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task objective2_set()
        {
            await sleep(300);
            objectives_show_up_to(2);
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task objective2_clear()
        {
            objectives_finish_up_to(2);
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task objective3_set()
        {
            await sleep(30);
            objectives_show_up_to(3);
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task music_03b_01_stop()
        {
            print("music 03b_01 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_01", 4292222485U));
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task music_03b_01_start_alt()
        {
            print("music 03b_01 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_01", 4292222485U), true);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task music_03b_01_start()
        {
            print("music 03b_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_01", 4292222485U), default(IGameObject), 1F);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task music_03b_02_stop()
        {
            print("music 03b_02 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_02", 4292615707U));
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task music_03b_02_start()
        {
            print("music 03b_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_02", 4292615707U), default(IGameObject), 1F);
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task music_03b_03_stop()
        {
            print("music 03b_03 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_03", 4292812318U));
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task music_03b_03_start()
        {
            print("music 03b_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_03", 4292812318U), default(IGameObject), 1F);
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task music_03b_04_stop()
        {
            print("music 03b_04 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_04", 4293074466U));
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task music_03b_04_start_alt()
        {
            await sleep_until(async () => volume_test_objects(tv_scarab, players()), 15);
            print("music 03b_04 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_04", 4293074466U), true);
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task music_03b_04_start()
        {
            await sleep_until(async () => volume_test_objects(tv_e23_entry_door, players()), 15);
            print("music 03b_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_04", 4293074466U), default(IGameObject), 1F);
        }

        [ScriptMethod(196, Lifecycle.Static)]
        public async Task<bool> player_in_vehicle()
        {
            return unit_in_vehicle(unit(await this.player0())) || (bool)game_is_cooperative() && unit_in_vehicle(unit(await this.player1()));
        }

        [ScriptMethod(197, Lifecycle.Static)]
        public async Task<bool> players_in_vehicle()
        {
            return unit_in_vehicle(unit(await this.player0())) && !((bool)game_is_cooperative()) || unit_in_vehicle(unit(await this.player1()));
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task flashlight_control()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_dark_area0, players()))
                {
                    game_can_use_flashlights(true);
                }
                else
                {
                    game_can_use_flashlights(false);
                }

                return false;
            }, 60);
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task scarab_no_save()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(tv_scarab_no_save, players()), 5);
                game_save_cancel();
                print("game save canceled");
                return false;
            }, 1);
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task cs_scarab_load_main_gun()
        {
            object_hide(ai_get_object(this.ai_current_actor), true);
            vehicle_load_magic(unit(object_at_marker(scarab.Entity, "primary_trigger")), "scarab_turret_d", ai_get_object(this.ai_current_actor));
            sleep_forever();
        }

        [ScriptMethod(201, Lifecycle.CommandScript)]
        public async Task cs_scarab_load_upper_gun()
        {
            object_hide(ai_get_object(this.ai_current_actor), true);
            vehicle_load_magic(unit(object_at_marker(scarab.Entity, "t_f_turret")), "scarab_turret_d", ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(202, Lifecycle.CommandScript)]
        public async Task cs_scarab_load_rear_gun()
        {
            object_hide(ai_get_object(this.ai_current_actor), true);
            vehicle_load_magic(unit(object_at_marker(scarab.Entity, "t_b_turret")), "scarab_turret_d", ai_get_object(this.ai_current_actor));
            sleep_forever();
        }

        [ScriptMethod(203, Lifecycle.Static)]
        public async Task scarab_idle_var0()
        {
            print("scarab_idle_var0");
            device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(204, Lifecycle.Static)]
        public async Task scarab_idle_firing()
        {
            print("scarab_idle_var0");
            device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(205, Lifecycle.Static)]
        public async Task scarab_idle_to_walk_front()
        {
            print("scarab_idle_to_walk_front");
            device_set_position_track(scarab.Entity, "combat:idle:2:walk_front", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 3F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(206, Lifecycle.Static)]
        public async Task scarab_idle_to_walk_front_fast()
        {
            print("scarab_idle_to_walk_front");
            device_set_position_track(scarab.Entity, "combat:idle:2:walk_front", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 2F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(207, Lifecycle.Static)]
        public async Task scarab_walk_front_var0()
        {
            print("scarab_walk_front_var0");
            device_set_position_track(scarab.Entity, "combat:walk_front:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(208, Lifecycle.Static)]
        public async Task scarab_walk_front_var0_fast()
        {
            print("scarab_walk_front_var0");
            device_set_position_track(scarab.Entity, "combat:walk_front:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 80F / 30F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(209, Lifecycle.Static)]
        public async Task scarab_walk_front_low_var0()
        {
            print("scarab_walk_front_low_var0");
            device_set_position_track(scarab.Entity, "combat:walk_front:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 8F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(210, Lifecycle.Static)]
        public async Task scarab_walk_front_to_idle()
        {
            print("scarab_walk_front_to_idle");
            device_set_position_track(scarab.Entity, "combat:walk_front:2:idle", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 3F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(211, Lifecycle.Static)]
        public async Task scarab_walk_front_to_idle_fast()
        {
            print("scarab_walk_front_to_idle");
            device_set_position_track(scarab.Entity, "combat:walk_front:2:idle", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 2F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(212, Lifecycle.Static)]
        public async Task scarab_idle_turn_22_left()
        {
            print("scarab_idle_turn_22_left");
            device_set_position_track(scarab.Entity, "combat:turn_22_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(213, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_left()
        {
            print("scarab_idle_turn_45_left");
            device_set_position_track(scarab.Entity, "combat:turn_45_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(214, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_right()
        {
            print("scarab_idle_turn_45_right");
            device_set_position_track(scarab.Entity, "combat:turn_45_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(215, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_15_left()
        {
            print("scarab_walk_front_turn_15_left");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_15_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(216, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_15_right()
        {
            print("scarab_walk_front_turn_15_right");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_15_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_22_left()
        {
            print("scarab_walk_front_turn_22_left");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_22_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_45_left()
        {
            print("scarab_walk_front_turn_45_left");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_45_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_45_right()
        {
            print("scarab_walk_front_turn_45_right");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_45_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(220, Lifecycle.Static)]
        public async Task scarab_walk_front_to_walk_low()
        {
            print("scarab_walk_front_to_walk_low");
            device_set_position_track(scarab.Entity, "combat:walk_front:2:walk_narrow_front", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(221, Lifecycle.Static)]
        public async Task scarab_walk_low_to_walk_front()
        {
            print("scarab_walk_narrow_to_walk_front");
            device_set_position_track(scarab.Entity, "combat:walk_narrow_front:2:walk_front", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(222, Lifecycle.Static)]
        public async Task scarab_walk_low_var0()
        {
            print("scarab_walk_narrow_var0");
            device_set_position_track(scarab.Entity, "combat:walk_narrow_front:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(223, Lifecycle.Static)]
        public async Task scarab_idle_to_twist_5_left()
        {
            print("scarab_idle_to_twist_5_right");
            device_set_position_track(scarab.Entity, "combat:idle_to_twist_5_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(224, Lifecycle.Static)]
        public async Task scarab_idle_to_twist_5_right()
        {
            print("scarab_idle_to_twist_5_right");
            device_set_position_track(scarab.Entity, "combat:idle_to_twist_5_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(225, Lifecycle.Static)]
        public async Task scarab_twist_5_left()
        {
            print("scarab_twist_5_left");
            device_set_position_track(scarab.Entity, "combat:twist_5_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(226, Lifecycle.Static)]
        public async Task scarab_twist_5_left_firing()
        {
            print("scarab_twist_5_left");
            device_set_position_track(scarab.Entity, "combat:twist_5_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(227, Lifecycle.Static)]
        public async Task scarab_twist_5_right()
        {
            print("scarab_twist_5_right");
            device_set_position_track(scarab.Entity, "combat:twist_5_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(228, Lifecycle.Static)]
        public async Task scarab_twist_5_right_firing()
        {
            print("scarab_twist_5_right");
            device_set_position_track(scarab.Entity, "combat:twist_5_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(229, Lifecycle.Static)]
        public async Task scarab_twist_5_left_to_idle()
        {
            print("scarab_twist_5_left_to_idle");
            device_set_position_track(scarab.Entity, "combat:twist_5_left_to_idle", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(230, Lifecycle.Static)]
        public async Task scarab_twist_5_right_to_idle()
        {
            print("scarab_twist_5_left_to_idle");
            device_set_position_track(scarab.Entity, "combat:twist_5_right_to_idle", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(231, Lifecycle.Static)]
        public async Task scarab_gun_open_instant()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_open");
            device_animate_overlay(scarab.Entity, 1F, 0.05F, 0F, 0F);
        }

        [ScriptMethod(232, Lifecycle.Static)]
        public async Task scarab_gun_open()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_open");
            device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(233, Lifecycle.Static)]
        public async Task scarab_gun_fire()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire");
            device_animate_overlay(scarab.Entity, 1F, 6F, 0F, 0F);
        }

        [ScriptMethod(234, Lifecycle.Static)]
        public async Task scarab_gun_close()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_close");
            device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(235, Lifecycle.Static)]
        public async Task scarab_gun_open_down_instant()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_down_open");
            device_animate_overlay(scarab.Entity, 1F, 0.05F, 0F, 0F);
        }

        [ScriptMethod(236, Lifecycle.Static)]
        public async Task scarab_gun_open_down()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_down_open");
            device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(237, Lifecycle.Static)]
        public async Task scarab_gun_fire_down()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_down");
            device_animate_overlay(scarab.Entity, 1F, 6F, 0F, 0F);
        }

        [ScriptMethod(238, Lifecycle.Static)]
        public async Task scarab_gun_close_down()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_down_close");
            device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(239, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_0_entry()
        {
            cs_vehicle_boost(true);
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p1"));
            object_destroy(ai_vehicle_get(this.ai_current_actor));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(240, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_1_entry()
        {
            cs_vehicle_boost(true);
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p3"));
            object_destroy(ai_vehicle_get(this.ai_current_actor));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(241, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_gunners0()
        {
            await sleep(60);
            if (!(volume_test_objects(tv_scarab, players())))
            {
                cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/leg1"));
            }

            await sleep(60);
            cs_shoot_point(false, GetReference<ISpatialPoint>("e22_scarab_target/leg1"));
            await sleep(1);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(242, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_gunners1()
        {
            await sleep(120);
            if (!(volume_test_objects(tv_scarab, players())))
            {
                cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/leg0"));
            }

            await sleep(60);
            cs_shoot_point(false, GetReference<ISpatialPoint>("e22_scarab_target/leg0"));
            await sleep(1);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(243, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_2_entry()
        {
            cs_vehicle_boost(true);
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p4"));
            cs_vehicle_boost(false);
            cs_face(true, GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/f0"));
            cs_fly_to(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p5"));
            if (this.g_e23_scarab_after_turn)
            {
                cs_run_command_script(e23_mars_pelican2.gunner0, new ScriptMethodReference(cs_e23_mars_pelican2_gunners0));
                cs_run_command_script(e23_mars_pelican2.gunner1, new ScriptMethodReference(cs_e23_mars_pelican2_gunners1));
            }

            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p6"), 16F);
            this.g_e23_mars_pelican2_2_active = false;
            cs_face(false, GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/f0"));
            cs_face(true, GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p7"));
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p6"), 2F);
            cs_face(false, GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p7"));
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p7"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p8"));
            cs_fly_by(GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p1"));
            object_destroy(ai_vehicle_get(this.ai_current_actor));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(244, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_inf1_shoot()
        {
            await sleep_until(async () => this.g_e23_scarab_climbed_down, 15);
            await sleep((short)random_range(10, 30));
            cs_enable_moving(true);
            await sleep_until(async () =>
            {
                cs_shoot(true, list_get(ai_actors(e23_cov_inf0), (short)random_range(0, list_count(ai_actors(e23_cov_inf0)))));
                await sleep((short)random_range(45, 75));
                return this.g_e23_scarab_before_bridge0;
            }, 15);
            ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(245, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_inf0_shoot()
        {
            await sleep_until(async () => this.g_e23_scarab_under_bridge0, 15);
            await sleep((short)random_range(100, 120));
            await sleep_until(async () =>
            {
                cs_shoot(true, list_get(ai_actors(e23_cov_inf0), (short)random_range(0, list_count(ai_actors(e23_cov_inf0)))));
                await sleep((short)random_range(45, 75));
                return this.g_e23_scarab_before_bridge1;
            }, 15);
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task cs_e23_cov_inf1_pilot_exit()
        {
            objects_detach(scarab.Entity, ai_get_object(this.ai_current_actor));
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4041871220U), "scarab_d_r:any:any:exit", true);
            await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
            unit_stop_custom_animation(ai_get_unit(this.ai_current_actor));
            object_cannot_die(ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task cs_e23_cov_inf1_pilot0()
        {
            object_cannot_die(ai_get_object(this.ai_current_actor), true);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e23_cov_inf1_pilot_exit));
            cs_abort_on_damage(true);
            custom_animation_loop(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4041871220U), "scarab_d_r:any:any:idle:var0", false);
            objects_attach(scarab.Entity, "scarab_d_l", ai_get_object(this.ai_current_actor), "");
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 7F, 10);
            objects_detach(scarab.Entity, ai_get_object(this.ai_current_actor));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 3F, 10);
        }

        [ScriptMethod(248, Lifecycle.CommandScript)]
        public async Task cs_e23_cov_inf1_pilot1()
        {
            object_cannot_die(ai_get_object(this.ai_current_actor), true);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e23_cov_inf1_pilot_exit));
            cs_abort_on_damage(true);
            custom_animation_loop(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4041871220U), "scarab_d_r:any:any:idle:var0", false);
            objects_attach(scarab.Entity, "scarab_d_r", ai_get_object(this.ai_current_actor), "");
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 7F, 10);
            objects_detach(scarab.Entity, ai_get_object(this.ai_current_actor));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 3F, 10);
        }

        [ScriptMethod(249, Lifecycle.CommandScript)]
        public async Task cs_e23_scarab_upper_gun()
        {
            cs_shoot(true, ai_vehicle_get(e23_mars_pelican0_1.pelican0));
            await sleep(120);
        }

        [ScriptMethod(250, Lifecycle.CommandScript)]
        public async Task cs_best_cs_ever()
        {
            cs_approach(this.g_target, 0.5F, 5F, 50F);
            await sleep_until(async () =>
            {
                cs_crouch(true);
                await sleep(8);
                cs_crouch(false);
                await sleep(8);
                return false;
            }, 1);
        }

        [ScriptMethod(251, Lifecycle.Static)]
        public async Task<bool> e23_scarab_before_bridge0()
        {
            return this.g_e23_scarab_before_bridge0 == true;
        }

        [ScriptMethod(252, Lifecycle.Static)]
        public async Task<bool> e23_scarab_before_bridge1()
        {
            return this.g_e23_scarab_before_bridge1 == true;
        }

        [ScriptMethod(253, Lifecycle.Static)]
        public async Task<bool> e23_scarab_before_bridge2()
        {
            return this.g_e23_scarab_before_bridge2 == true;
        }

        [ScriptMethod(254, Lifecycle.Static)]
        public async Task<bool> e23_scarab_after_bridge2()
        {
            return this.g_e23_scarab_after_bridge2 == true;
        }

        [ScriptMethod(255, Lifecycle.Static)]
        public async Task<bool> e23_scarab_after_turn()
        {
            return this.g_e23_scarab_after_turn == true;
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task scarab_upper_gunner_main()
        {
            ai_place(scarab_gunners.upper_gunner);
            await sleep(5);
            cs_run_command_script(scarab_gunners.upper_gunner, new ScriptMethodReference(cs_e23_scarab_upper_gun));
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task e23_scarab()
        {
            wake(new ScriptMethodReference(scarab_no_save));
            pvs_set_object(scarab.Entity);
            ai_erase(scarab_gunners.main_gunner);
            device_set_position_track(scarab.Entity, "finale_climb_off_buildings", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 401F / 30F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
            this.g_e23_scarab_climbed_down = true;
            await sleep_until(async () => this.g_e23_started, 1);
            await this.scarab_walk_front_var0();
            this.g_e23_scarab_before_bridge0 = true;
            await this.scarab_walk_front_to_walk_low();
            await this.scarab_walk_low_var0();
            await this.scarab_walk_low_var0();
            this.g_e23_scarab_under_bridge0 = true;
            if (await this.difficulty_legendary())
            {
                await this.scarab_walk_low_to_walk_front();
                await this.scarab_walk_front_var0();
            }
            else
            {
                await this.scarab_walk_low_var0();
                await this.scarab_walk_low_var0();
            }

            this.g_e23_scarab_before_bridge1 = true;
            if (await this.difficulty_legendary())
            {
                await this.scarab_walk_front_to_walk_low();
            }
            else
            {
                await this.scarab_walk_low_var0();
            }

            await this.scarab_walk_low_var0();
            await this.scarab_walk_low_var0();
            this.g_e23_scarab_under_bridge1 = true;
            if (await this.difficulty_legendary())
            {
                await this.scarab_walk_low_to_walk_front();
            }
            else
            {
                await this.scarab_walk_low_var0();
            }

            if (await this.difficulty_legendary())
            {
                await this.scarab_walk_front_var0();
            }
            else
            {
                await this.scarab_walk_low_var0();
            }

            this.g_e23_scarab_before_bridge2 = true;
            if (await this.difficulty_legendary())
            {
                await this.scarab_walk_front_to_walk_low();
            }
            else
            {
                await this.scarab_walk_low_var0();
                await this.scarab_walk_low_var0();
            }

            await this.scarab_walk_low_var0();
            await this.scarab_walk_low_var0();
            this.g_e23_scarab_under_bridge2 = true;
            await this.scarab_walk_low_to_walk_front();
            this.g_e23_scarab_after_bridge2 = true;
            await this.scarab_walk_front_to_idle();
            await sleep_until(async () => volume_test_objects(tv_e23_scarab_corner_continue, players()), 1);
            game_save();
            await this.scarab_idle_turn_22_left();
            await this.scarab_idle_turn_45_left();
            this.g_e23_scarab_after_turn = true;
            await this.scarab_idle_turn_22_left();
            await this.scarab_idle_to_walk_front();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_turn_15_left();
            if (await this.difficulty_legendary())
            {
                await this.scarab_walk_front_var0();
                await this.scarab_walk_front_turn_15_right();
            }
            else
            {
                await this.scarab_walk_front_turn_15_right();
                await this.scarab_walk_front_var0();
            }

            print("cortana: it can't go any further this way. we have it trapped!");
            ai_play_line_on_object(default(IGameObject), "2030") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await this.scarab_walk_front_to_idle();
            this.g_e23_scarab_arrived_at_end = true;
            await this.scarab_gun_open();
            await this.scarab_idle_var0();
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.g_e23_scarab_active)
                    {
                        if (this.g_e23_scarab_active)
                        {
                            await this.scarab_idle_to_twist_5_right();
                        }

                        if (this.g_e23_scarab_active)
                        {
                            if ((short)random_range(0, 2) == 0)
                            {
                                await this.scarab_twist_5_right();
                            }
                        }

                        if (this.g_e23_scarab_active)
                        {
                            await this.scarab_twist_5_right_to_idle();
                        }
                    }
                }, 
                    async () =>
                {
                    if (this.g_e23_scarab_active)
                    {
                        if (this.g_e23_scarab_active)
                        {
                            await this.scarab_idle_to_twist_5_left();
                        }

                        if (this.g_e23_scarab_active)
                        {
                            if ((short)random_range(0, 2) == 0)
                            {
                                await this.scarab_twist_5_left();
                            }
                        }

                        if (this.g_e23_scarab_active)
                        {
                            await this.scarab_twist_5_left_to_idle();
                        }
                    }
                });
                return !(this.g_e23_scarab_active);
            }, 1);
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task e23_ultra_dialogue()
        {
            await sleep_until(async () => (short)ai_combat_status(e23_cov_inf1_0.Squad) >= this.ai_combat_status_clear_los);
            await sleep_until(async () => (short)ai_combat_status(e23_cov_inf1_0.Squad) <= this.ai_combat_status_active);
            print("cortana: careful chief, that elite was an ultra! and those pilots are no pushovers either!!");
            ai_play_line_on_object(default(IGameObject), "2050") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task e23_ultra_dialogue_kill()
        {
            await sleep_until(async () => (short)ai_living_count(e23_cov_inf1_0.ultra0) <= 0, 15);
            sleep_forever(new ScriptMethodReference(e23_ultra_dialogue));
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task e23_dialogue_boarding()
        {
            await sleep(30);
            print("cortana: chief, you're going to have to board the scarab!");
            ai_play_line_on_object(default(IGameObject), "2020") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(600);
            print("cortana: we can't do anything more to that scarab from here");
            ai_play_line_on_object(default(IGameObject), "2040") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(75);
            activate_team_nav_point_object(_default, player, scarab.Entity, 8.5F);
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task e23_dialogue_boarding_kill()
        {
            await sleep_until(async () => this.g_mission_over || volume_test_objects(tv_scarab, players()), 15);
            sleep_forever(new ScriptMethodReference(e23_dialogue_boarding));
            deactivate_team_nav_point_object(player, scarab.Entity);
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task e23_best_cs_ever()
        {
            if (!(await this.difficulty_legendary()))
            {
                sleep_forever();
            }

            if (!((short)random_range(0, 10) == 0))
            {
                sleep_forever();
            }

            this.g_target = await this.player0();
            await sleep_until(async () => object_get_health(this.g_target) <= 0F, 10);
            cs_run_command_script(e23_cov_inf1_0.ultra0, new ScriptMethodReference(cs_best_cs_ever));
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task e23_cov_inf1_main()
        {
            await sleep_until(async () => this.g_e23_scarab_climbed_down, 5);
            await sleep_until(async () => volume_test_objects(tv_scarab_stairwell, players()), 15);
            ai_place(e23_cov_inf1_1.Squad);
            ai_place(e23_cov_inf1_0.Squad, (short)pin(4F - (float)ai_living_count(e23_cov_inf0), 1F, 3F));
            wake(new ScriptMethodReference(e23_ultra_dialogue));
            wake(new ScriptMethodReference(e23_ultra_dialogue_kill));
            wake(new ScriptMethodReference(e23_best_cs_ever));
            await sleep_until(async () => !(cs_command_script_queued(e23_cov_inf1_1.pilot0, new ScriptMethodReference(cs_e23_cov_inf1_pilot0))) && !(cs_command_script_queued(e23_cov_inf1_1.pilot1, new ScriptMethodReference(cs_e23_cov_inf1_pilot1))));
            this.g_e23_scarab_active = false;
            await sleep_until(async () => (short)ai_living_count(e23_cov_inf1) <= 0);
            this.g_mission_over = true;
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task e23_cov_inf0_main()
        {
            await sleep_until(async () => this.g_e23_scarab_climbed_down, 5);
            ai_place(e23_cov_inf0_0.Squad);
            await sleep_until(async () => this.g_e23_scarab_under_bridge1 || (short)ai_living_count(e23_cov_inf0) <= 2 || volume_test_objects(tv_scarab_interior, players()), 15);
            ai_place(e23_cov_inf0_1.Squad, (short)pin(6F - (float)ai_living_count(e23_cov_inf0), 0F, 4F));
            await sleep_until(async () => this.g_e23_scarab_under_bridge2 || (short)ai_living_count(e23_cov_inf0) <= 2 || volume_test_objects(tv_scarab_interior, players()), 15);
            ai_place(e23_cov_inf0_2.Squad, (short)pin(6F - (float)ai_living_count(e23_cov_inf0), 0F, 3F));
            await sleep_until(async () => this.g_e23_scarab_arrived_at_end || (short)ai_living_count(e23_cov_inf0) <= 2 || volume_test_objects(tv_scarab_interior, players()), 15);
            ai_place(e23_cov_inf0_3.Squad, (short)pin(6F - (float)ai_living_count(e23_cov_inf0), 0F, 2F));
            await sleep_until(async () => this.g_e23_scarab_arrived_at_end || volume_test_objects(tv_scarab, players()), 15);
            ai_place(e23_cov_inf0_4.Squad, (short)pin(6F - (float)ai_living_count(e23_cov_inf0), 0F, 5F));
            game_save();
            await sleep_until(async () => (short)ai_living_count(e23_cov_inf0) <= 2);
            wake(new ScriptMethodReference(e23_dialogue_boarding));
            await sleep(10);
            wake(new ScriptMethodReference(e23_dialogue_boarding_kill));
            await sleep_until(async () => (short)ai_living_count(e23_cov_inf0) <= 0);
            game_save();
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task e23_mars_pelican2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e23_mars_pelican0_begin, players()), 15);
            await sleep_until(async () =>
            {
                begin_random(async () => ai_place(e23_mars_pelican2.pelican0), 
                    async () => await sleep((short)random_range(60, 90)), 
                    async () => await sleep_until(async () => (short)ai_living_count(e23_mars_pelican2.Squad) < 2), 
                    async () => ai_place(e23_mars_pelican2.pelican1), 
                    async () => await sleep((short)random_range(60, 90)), 
                    async () => await sleep_until(async () => (short)ai_living_count(e23_mars_pelican2.Squad) < 2), 
                    async () => ai_place(e23_mars_pelican2.pelican0), 
                    async () => await sleep((short)random_range(60, 90)), 
                    async () => await sleep_until(async () => (short)ai_living_count(e23_mars_pelican2.Squad) < 2), 
                    async () => ai_place(e23_mars_pelican2.pelican1), 
                    async () => await sleep((short)random_range(60, 90)), 
                    async () => await sleep_until(async () => (short)ai_living_count(e23_mars_pelican2.Squad) < 2), 
                    async () => ai_place(e23_mars_pelican2.pelican2), 
                    async () => ai_place(e23_mars_pelican2.gunner0), 
                    async () => ai_place(e23_mars_pelican2.gunner1), 
                    async () => await sleep(1), 
                    async () => vehicle_load_magic(ai_vehicle_get(e23_mars_pelican2.pelican2), "pelican_g_pod", ai_get_object(e23_mars_pelican2.gunner0)), 
                    async () => vehicle_load_magic(ai_vehicle_get(e23_mars_pelican2.pelican2), "pelican_g_pod", ai_get_object(e23_mars_pelican2.gunner1)), 
                    async () => this.g_e23_mars_pelican2_2_active = true, 
                    async () => await sleep_until(async () => !(this.g_e23_mars_pelican2_2_active)), 
                    async () => await sleep_until(async () => (short)ai_living_count(e23_mars_pelican2.Squad) < 2));
                return this.g_mission_over;
            });
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task e23_mars_pelican1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e23_mars_pelican1_begin, players()), 15);
            ai_place(e23_mars_pelican1_0.Squad);
            await sleep(60);
            ai_place(e23_mars_pelican1_1.Squad);
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task e23_mars_pelican0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e23_mars_pelican0_begin, players()) || this.g_e23_scarab_under_bridge1, 15);
            ai_place(e23_mars_pelican0);
            ai_vehicle_enter_immediate(e23_mars_pelican0_0.gunner0, ai_vehicle_get(e23_mars_pelican0_0.pelican0), "pelican_g_pod");
            ai_vehicle_enter_immediate(e23_mars_pelican0_0.gunner1, ai_vehicle_get(e23_mars_pelican0_0.pelican0), "pelican_g_pod");
            ai_vehicle_enter_immediate(e23_mars_pelican0_1.gunner0, ai_vehicle_get(e23_mars_pelican0_1.pelican0), "pelican_g_pod");
            ai_vehicle_enter_immediate(e23_mars_pelican0_1.gunner1, ai_vehicle_get(e23_mars_pelican0_1.pelican0), "pelican_g_pod");
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task e23_mars_inf1_main()
        {
            ai_migrate(e22_mars_inf1.Squad, e23_mars_inf1.Squad);
            ai_place(e23_mars_inf1.Squad, (short)(3 - (float)ai_living_count(e23_mars_inf1.Squad)));
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task e23_mars_inf0_main()
        {
            ai_place(e23_mars_inf0.Squad);
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task e23_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e23_main_begin, players()), 15);
            this.g_e23_started = true;
            print("e23_main");
            data_mine_set_mission_segment("e23_scarab_boarding");
            game_save();
            if (await this.difficulty_legendary())
            {
                object_destroy(e23_gun.Entity);
            }

            wake(new ScriptMethodReference(music_03b_04_start));
            wake(new ScriptMethodReference(music_03b_04_start_alt));
            kill_volume_enable(kill_e23_0);
            kill_volume_enable(kill_e23_1);
            kill_volume_enable(kill_e23_2);
            wake(new ScriptMethodReference(e23_mars_inf1_main));
            wake(new ScriptMethodReference(e23_mars_pelican2_main));
            wake(new ScriptMethodReference(e23_cov_inf0_main));
            wake(new ScriptMethodReference(e23_cov_inf1_main));
        }

        [ScriptMethod(271, Lifecycle.Static)]
        public async Task test_scarab_boarding()
        {
            object_teleport(await this.player0(), e23_test);
            object_create(scarab);
            pvs_set_object(scarab.Entity);
            object_teleport(scarab.Entity, e23_scarab_start);
            this.g_e23_scarab_arrived = true;
            if (!(this.g_e23_started))
            {
                wake(new ScriptMethodReference(e23_main));
            }

            wake(new ScriptMethodReference(e23_scarab));
        }

        [ScriptMethod(272, Lifecycle.CommandScript)]
        public async Task cs_e22_mars1_go()
        {
            cs_enable_pathfinding_failsafe(true);
            ai_vehicle_exit(this.ai_current_actor);
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf1/p0"));
        }

        [ScriptMethod(273, Lifecycle.CommandScript)]
        public async Task cs_e22_mars1_lieutenant()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_enable_looking(false);
            cs_look(true, GetReference<ISpatialPoint>("e22_mars_inf1/scarab_entry"));
            await sleep_until(async () => volume_test_objects(tv_e22_scarab_entry_begin, players()), 10);
            cs_look_player(true);
            await sleep_until(async () => device_get_position(e22_door3.Entity) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 3.5F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F, 5);
            await sleep(30);
            print("lt: when i asked for reinforcements...");
            await sleep((short)((float)ai_play_line(this.ai_current_actor, "0770") - 75));
            cs_look(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep(55);
            cs_aim(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep(27);
            cs_crouch(true);
            await sleep(ai_play_line(this.ai_current_actor, "8030"));
            print("lf: we got trouble");
            await sleep_until(async () => (short)ai_living_count(e22_mars_scorpions0.Squad) <= 0, 15);
            await sleep(60);
            print("gnr: alright, this is the shit");
            await sleep((short)((float)ai_play_line(e22_mars_inf1.marine0, "8060") - 30));
            cs_look_object(true, ai_get_object(e22_mars_inf1.marine0));
            await sleep(45);
            print("lt: marine, did i give you permission to bitch?");
            await sleep(ai_play_line(this.ai_current_actor, "8010"));
            cs_look(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            cs_movement_mode(this.ai_movement_combat);
            cs_aim(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_before_climb, 5);
            print("lt: i don't think it's stopping");
            ai_play_line(this.ai_current_actor, "0790") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep_until(async () => this.g_e22_scarab_mid_climb, 5);
            cs_crouch(false);
            await sleep(90);
            ai_play_line(this.ai_current_actor, "8040") // Couldn't generate cast from 'Short' to 'Void'
            ;
            print("lt: that thing is starting to piss me off");
            await sleep(100);
            cs_aim(false, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            cs_face_player(true);
            ai_play_line(this.ai_current_actor, "0830") // Couldn't generate cast from 'Short' to 'Void'
            ;
            print("lt: marines, time to kill us a scarab");
            cs_look_player(false);
            await sleep(30);
            cs_enable_looking(true);
            cs_start_to(GetReference<ISpatialPoint>("e22_mars_inf1/p0"));
            await sleep(20);
            cs_run_command_script(e22_mars_inf1.marine0, new ScriptMethodReference(cs_e22_mars1_go));
            await sleep(20);
            cs_run_command_script(e22_mars_inf0.perez, new ScriptMethodReference(cs_e22_mars1_go));
            wake(new ScriptMethodReference(objective3_set));
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task cs_e22_mars0_crouch()
        {
            cs_enable_dialogue(true);
            cs_movement_mode(this.ai_movement_combat);
            cs_crouch(true);
            cs_look_player(true);
            sleep_forever();
        }

        [ScriptMethod(275, Lifecycle.CommandScript)]
        public async Task cs_e22_mars0_stand()
        {
            cs_enable_dialogue(true);
            cs_movement_mode(this.ai_movement_patrol);
            cs_look_player(true);
            sleep_forever();
        }

        [ScriptMethod(276, Lifecycle.CommandScript)]
        public async Task cs_e22_mars0_perez()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_face_player(true);
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf0_perez/p0"));
            cs_start_approach_player(3F, 20F, 35F);
            print("perez: hey chief!");
            await sleep_until(async () => !(await this.players_in_vehicle()), 10);
            cs_approach_player(1.5F, 5F, 10F);
            cs_face_player(true);
            await sleep((short)((float)ai_play_line_at_player(this.ai_current_actor, "0710") - 30));
            cs_face_player(false);
            cs_enable_looking(true);
            cs_start_to(GetReference<ISpatialPoint>("e22_mars_inf0_perez/p1"));
            await sleep(45);
            cs_look_player(true);
            print("the lt. got hit");
            await sleep(ai_play_line(this.ai_current_actor, "0730"));
            await sleep(15);
            print("who in charge");
            await sleep((short)((float)ai_play_line_on_object(default(IGameObject), "0740") - 30));
            cs_look_player(true);
            await sleep(45);
            await sleep_until(async () => !((bool)cs_moving()), 5);
            cs_face_player(true);
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0750"));
            cs_face_player(false);
            cs_look_player(false);
            cs_enable_looking(true);
            cs_start_to(GetReference<ISpatialPoint>("e22_mars_inf0_perez/p2"));
            print("c'mon, i'll show you");
            ai_play_line(this.ai_current_actor, "0760") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(20);
            await sleep_until(async () => !((bool)cs_moving()), 5);
            cs_look_player(true);
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf1_crouch()
        {
            cs_crouch(true);
            cs_face(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            cs_aim(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await sleep(150);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_before_climb, 5);
            cs_shoot_point(false, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            ai_vehicle_exit(this.ai_current_actor);
            await sleep_until(async () => this.g_e22_scarab_mid_climb, 5);
            await sleep(20);
            cs_crouch(false);
            await sleep_until(async () => this.g_e22_scarab_past_climb, 5);
            await sleep((short)random_range(20, 40));
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf1/p0"));
        }

        [ScriptMethod(278, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf1_marine1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(3);
            cs_start_to(GetReference<ISpatialPoint>("e22_mars_inf1/p1"));
            cs_look(true, GetReference<ISpatialPoint>("e22_mars_scorpions0/scarab_target"));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 11F, 5);
            cs_face_player(true);
            ai_play_line_at_player(this.ai_current_actor, "0840") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 4F, 5);
            cs_face_player(false);
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf1/p0"));
        }

        [ScriptMethod(279, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine_end()
        {
            cs_face(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            cs_crouch(true);
            await sleep_until(async () => this.g_e22_scarab_mid_climb, 5);
            cs_crouch(false);
            await sleep_until(async () => this.g_e22_scarab_past_climb, 5);
            cs_force_combat_status(2);
            sleep_forever();
        }

        [ScriptMethod(280, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine0()
        {
            cs_force_combat_status(3);
            cs_crouch(true);
            await sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await sleep((short)random_range(30, 45));
            cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await sleep((short)random_range(120, 150));
            cs_shoot_point(false, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            cs_crouch(false);
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf2/p0"));
            cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e22_mars_inf2_marine_end));
        }

        [ScriptMethod(281, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine1()
        {
            cs_force_combat_status(3);
            await sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await sleep((short)random_range(30, 45));
            cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await sleep((short)random_range(120, 150));
            cs_shoot_point(false, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            ai_vehicle_exit(this.ai_current_actor);
            cs_crouch(false);
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf2/p1"));
            cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e22_mars_inf2_marine_end));
        }

        [ScriptMethod(282, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine2()
        {
            cs_force_combat_status(3);
            cs_crouch(true);
            await sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await sleep((short)random_range(30, 45));
            cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await sleep((short)random_range(180, 210));
            cs_shoot_point(false, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            cs_crouch(false);
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf2/p2"));
            cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e22_mars_inf2_marine_end));
        }

        [ScriptMethod(283, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine3()
        {
            cs_force_combat_status(3);
            await sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await sleep((short)random_range(30, 45));
            cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await sleep((short)random_range(180, 210));
            cs_shoot_point(false, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            ai_vehicle_exit(this.ai_current_actor);
            cs_crouch(false);
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf2/p3"));
            cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e22_mars_inf2_marine_end));
        }

        [ScriptMethod(284, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine4()
        {
            cs_force_combat_status(3);
            cs_crouch(true);
            await sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await sleep((short)random_range(30, 45));
            cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await sleep((short)random_range(240, 270));
            cs_shoot_point(false, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            cs_crouch(false);
            cs_go_to(GetReference<ISpatialPoint>("e22_mars_inf2/p4"));
            cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e22_mars_inf2_marine_end));
        }

        [ScriptMethod(285, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_scorpion0()
        {
            cs_force_combat_status(3);
            cs_aim(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scarab_visible, 5);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await sleep_until(async () => this.g_e22_scorpion_asplode, 5);
            unit_kill(ai_vehicle_get(this.ai_current_actor));
        }

        [ScriptMethod(286, Lifecycle.CommandScript)]
        public async Task cs_e22_scarab_main_gun()
        {
            cs_shoot(true, ai_vehicle_get(e22_mars_scorpions0.scorpion0));
            await sleep(120);
            this.g_e22_scorpion_asplode = true;
            await sleep(45);
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task e22_scarab_climbing_events()
        {
            await sleep(45);
            this.g_e22_scarab_started_climb = true;
            print("g_e22_scarab_started_climb ");
            await sleep(100);
            this.g_e22_scarab_mid_climb = true;
            print("g_e22_scarab_mid_climb ");
            print("todo: boom boom dust shakes");
            await sleep(90);
            this.g_e22_scarab_past_climb = true;
            print("g_e22_scarab_past_climb ");
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task e22_scarab_advancing_events()
        {
            this.g_e22_scarab_advancing = true;
            print("g_e22_scarab_advancing ");
            await sleep(259);
            object_damage_damage_section(e22_bridge0_2.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge0_3.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge0_4.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge0_5.Entity, "main", 1F);
            await sleep(2);
            object_damage_damage_section(e22_bridge0_0.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge0_1.Entity, "main", 1F);
            await sleep(118);
            object_damage_damage_section(e22_bridge1_2.Entity, "main", 1F);
            await sleep(1);
            object_damage_damage_section(e22_bridge1_0.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge1_1.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge1_3.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge1_4.Entity, "main", 1F);
            await sleep(1);
            object_damage_damage_section(e22_bridge1_5.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge1_6.Entity, "main", 1F);
            await sleep(1);
            object_damage_damage_section(e22_bridge1_7.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge1_8.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge1_9.Entity, "main", 1F);
            await sleep(19);
            object_damage_damage_section(e22_bridge2_0.Entity, "main", 1F);
            await sleep(1);
            object_damage_damage_section(e22_bridge2_3.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge2_5.Entity, "main", 1F);
            await sleep(1);
            object_damage_damage_section(e22_bridge2_1.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge2_2.Entity, "main", 1F);
            object_damage_damage_section(e22_bridge2_4.Entity, "main", 1F);
            await sleep(30);
            this.g_e22_scarab_before_climb = true;
            print("g_e22_scarab_before_climb ");
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task e22_scarab_appearance_events()
        {
            await sleep(60);
            this.g_e22_scarab_visible = true;
            await sleep(180);
            this.g_e22_scarab_appeared = true;
            print("g_e22_scarab_appeared ");
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task e22_scarab_intro_gun()
        {
            object_create(e22_scarab_gun);
            weapon_hold_trigger(GetReference<IWeaponReference>("e22_scarab_gun"), 0, true);
            await sleep(45);
            weapon_hold_trigger(GetReference<IWeaponReference>("e22_scarab_gun"), 0, false);
            await sleep(60);
            object_destroy(e22_scarab_gun.Entity);
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task e22_scarab()
        {
            await sleep_until(async () => volume_test_objects(tv_e22_begin_scarab_sequence, players()), 10);
            await sleep_until(async () => volume_test_objects(tv_e22_scarab_entry_begin, players()), 10);
            wake(new ScriptMethodReference(e22_scarab_intro_gun));
            wake(new ScriptMethodReference(chapter_title2));
            await sleep(50);
            ai_place(scarab_gunners.main_gunner);
            object_create_anew(scarab);
            object_teleport(scarab.Entity, e22_scarab_start);
            pvs_set_object(scarab.Entity);
            wake(new ScriptMethodReference(e22_scarab_appearance_events));
            await this.scarab_gun_open_down_instant();
            device_set_position_track(scarab.Entity, "finale_enter", 0F);
            device_animate_position(scarab.Entity, 1F, 266F / 30F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
            cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e22_scarab_main_gun));
            await this.scarab_gun_fire_down();
            await this.scarab_idle_firing();
            wake(new ScriptMethodReference(e22_scarab_advancing_events));
            await this.scarab_idle_to_walk_front_fast();
            await this.scarab_walk_front_var0_fast();
            await this.scarab_gun_close_down();
            await this.scarab_walk_front_var0_fast();
            await this.scarab_walk_front_var0_fast();
            await this.scarab_walk_front_var0_fast();
            await this.scarab_walk_front_var0_fast();
            wake(new ScriptMethodReference(e22_scarab_climbing_events));
            device_set_position_track(scarab.Entity, "finale_climb_on_buildings", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 446F / 30F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
            this.g_e23_scarab_arrived = true;
            begin_random(async () =>
            {
                if (!(this.g_e23_started))
                {
                    await this.scarab_idle_to_twist_5_right();
                    await this.scarab_twist_5_right_to_idle();
                }
            }, 
                async () =>
            {
                if (!(this.g_e23_started))
                {
                    await this.scarab_idle_to_twist_5_left();
                    await this.scarab_twist_5_left_to_idle();
                }
            });
            wake(new ScriptMethodReference(e23_scarab));
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task e22_nasty_player_synch()
        {
            await sleep_until(async () => volume_test_objects(tv_e22_begin_scarab_sequence, players()), 5);
            volume_teleport_players_not_inside(tv_e22_no_teleport, e22_nasty_player_synch1);
            await sleep_until(async () =>
            {
                if (list_count(volume_return_objects_by_type(tv_e22_street_cleanup, 2)) > 0)
                {
                    object_destroy(list_get(volume_return_objects_by_type(tv_e22_street_cleanup, 2), 0));
                    return 1F == 0F;
                }
                else
                {
                    return 1F == 1F;
                }
            }, 1);
            garbage_collect_unsafe();
            this.g_e22_done_street_cleanup = true;
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task e22_objective()
        {
            await sleep_until(async () => volume_test_objects(tv_e22_scarab_entry_begin, players()), 5);
            wake(new ScriptMethodReference(objective2_clear));
            await sleep_until(async () => this.g_e22_scarab_past_climb);
            wake(new ScriptMethodReference(objective3_set));
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task e22_dialogue()
        {
            await sleep_until(async () => volume_test_objects(tv_e22_away_from_building, players()), 5, this._30_seconds);
            ai_play_line_on_object(default(IGameObject), "2000") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(75);
            activate_team_nav_point_flag(_default, player, e22_navpoint, 0F);
            await sleep_until(async () => volume_test_objects(tv_e22_near_building, players()), 5, 450);
            if (!(volume_test_objects(tv_e22_near_building, players())))
            {
                ai_play_line_on_object(default(IGameObject), "2010") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task e22_dialogue_kill()
        {
            await sleep_until(async () => this.g_e23_started || volume_test_objects(tv_e22_main_begin, players()), 10);
            sleep_forever(new ScriptMethodReference(e22_dialogue));
            await sleep_until(async () => this.g_e23_started || volume_test_objects(tv_e22_doorway, players()), 10);
            deactivate_team_nav_point_flag(player, e22_navpoint);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task e22_mars_inf3_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e22_mars_inf3_begin, players()), 10);
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task e22_mars_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e22_begin_scarab_sequence, players()), 10);
            ai_place(e22_mars_inf2.Squad);
            ai_erase(e21_mars_pelican1.Squad);
            cs_run_command_script(e22_mars_inf2.marine0, new ScriptMethodReference(cs_e22_mars_inf2_marine0));
            cs_run_command_script(e22_mars_inf2.marine1, new ScriptMethodReference(cs_e22_mars_inf2_marine1));
            cs_run_command_script(e22_mars_inf2.marine2, new ScriptMethodReference(cs_e22_mars_inf2_marine2));
            cs_run_command_script(e22_mars_inf2.marine3, new ScriptMethodReference(cs_e22_mars_inf2_marine3));
            cs_run_command_script(e22_mars_inf2.marine4, new ScriptMethodReference(cs_e22_mars_inf2_marine4));
        }

        [ScriptMethod(298, Lifecycle.Dormant)]
        public async Task e22_mars_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e22_begin_scarab_sequence, players()), 10);
            ai_place(e22_mars_inf1.lieutenant);
            ai_place(e22_mars_inf1.marine0);
            object_set_permutation(ai_get_object(e22_mars_inf1.lieutenant), "comm_pack", "on");
            await sleep_until(async () => this.g_e22_scarab_past_climb, 5);
            device_operates_automatically_set(e22_door1.Entity, true);
            device_operates_automatically_set(e22_door2.Entity, true);
            device_closes_automatically_set(e22_door1.Entity, false);
            device_closes_automatically_set(e22_door2.Entity, false);
            device_set_position(e22_door1.Entity, 1F);
            device_set_position(e22_door2.Entity, 1F);
            ai_place(e22_mars_inf1.marine1);
            if ((short)ai_living_count(e22_mars_inf1.lieutenant) <= 0)
            {
                cs_run_command_script(e22_mars_inf1.marine0, new ScriptMethodReference(cs_e22_mars1_go));
                cs_run_command_script(e22_mars_inf0.perez, new ScriptMethodReference(cs_e22_mars1_go));
            }
        }

        [ScriptMethod(299, Lifecycle.Dormant)]
        public async Task e22_mars_inf0_main()
        {
            device_set_position(e22_door0.Entity, 1F);
            device_operates_automatically_set(e22_door0.Entity, true);
            ai_place(e22_mars_inf0.perez);
            ai_place(e22_mars_inf0.guard0);
            ai_place(e22_mars_inf0.guard2);
            await sleep_until(async () => volume_test_objects(tv_e22_main_begin, players()), 15);
            ai_place(e22_mars_inf0.guard1);
            ai_place(e22_mars_inf0.medic0);
            ai_migrate(e21_mars_warthog0.Squad, e22_mars_inf0.Squad);
            ai_vehicle_exit(e22_mars_inf0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e22_stairwell, players()) || volume_test_objects(tv_e22_stairwell, ai_get_object(e22_mars_inf0.perez)), 15);
            ai_set_orders(e22_mars_inf0.Squad, e22_mars_inf0_advance1);
            await sleep_until(async () => volume_test_objects(tv_e22_mars_inf3_begin, players()), 10);
            await sleep_until(async () => !(volume_test_objects(tv_e22_mars_inf0_visible, players())));
            ai_erase(e22_mars_inf0.guard0);
            ai_erase(e22_mars_inf0.guard1);
            ai_erase(e22_mars_inf0.guard2);
            ai_erase(e22_mars_inf0.medic0);
        }

        [ScriptMethod(300, Lifecycle.Dormant)]
        public async Task e22_mars_scorpions0_main()
        {
            await sleep_until(async () => this.g_e22_done_street_cleanup, 10);
            ai_place(e22_mars_scorpions0.Squad);
            cs_run_command_script(e22_mars_scorpions0.scorpion0, new ScriptMethodReference(cs_e22_mars_scorpion0));
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task e22_main()
        {
            this.g_e22_started = true;
            print("e22_main");
            data_mine_set_mission_segment("e22_scarab_intro");
            game_save();
            wake(new ScriptMethodReference(e23_main));
            wake(new ScriptMethodReference(music_03b_03_stop));
            wake(new ScriptMethodReference(e22_nasty_player_synch));
            wake(new ScriptMethodReference(e22_mars_inf0_main));
            wake(new ScriptMethodReference(e22_mars_inf1_main));
            wake(new ScriptMethodReference(e22_mars_inf2_main));
            wake(new ScriptMethodReference(e22_mars_inf3_main));
            wake(new ScriptMethodReference(e22_mars_scorpions0_main));
            wake(new ScriptMethodReference(e22_scarab));
            wake(new ScriptMethodReference(e22_objective));
            wake(new ScriptMethodReference(e22_dialogue));
            wake(new ScriptMethodReference(e22_dialogue_kill));
            await sleep_until(async () => this.g_e23_started);
            sleep_forever(new ScriptMethodReference(e22_nasty_player_synch));
            sleep_forever(new ScriptMethodReference(e22_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e22_mars_inf1_main));
            sleep_forever(new ScriptMethodReference(e22_mars_inf2_main));
            sleep_forever(new ScriptMethodReference(e22_mars_inf3_main));
            sleep_forever(new ScriptMethodReference(e22_mars_scorpions0_main));
            sleep_forever(new ScriptMethodReference(e22_dialogue));
        }

        [ScriptMethod(302, Lifecycle.Static)]
        public async Task test_scarab_intro()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), e22_test);
            object_destroy(scarab.Entity);
            if (!(this.g_e22_started))
            {
                wake(new ScriptMethodReference(e22_main));
            }
        }

        [ScriptMethod(303, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_phantom0_bombard()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_definite);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e21_cov_bombard/p5")), 
                    async () => await sleep(120), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e21_cov_bombard/p6")), 
                    async () => await sleep(120), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e21_cov_bombard/p7")), 
                    async () => await sleep(120), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e21_cov_bombard/p8")), 
                    async () => await sleep(120));
                return false;
            });
        }

        [ScriptMethod(304, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_wraiths0_bombard()
        {
            cs_abort_on_damage(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e21_cov_bombard/p0")), 
                    async () => await sleep(60), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e21_cov_bombard/p1")), 
                    async () => await sleep(60), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("e21_cov_bombard/p2")), 
                    async () => await sleep(60));
                return false;
            });
        }

        [ScriptMethod(305, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_abort_bombard()
        {
            await sleep(1);
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_phantom1_entry()
        {
            cs_fly_by(GetReference<ISpatialPoint>("e21_cov_phantom1_entry/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e21_cov_phantom1_entry/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("e21_cov_phantom1_entry/p2"));
            await sleep(15);
            cs_fly_to(GetReference<ISpatialPoint>("e21_cov_phantom1_entry/p3"), 0.5F);
            await sleep(30);
            begin_random(async () => vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_sc01"), 
                async () => await sleep(15), 
                async () => vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_sc02"), 
                async () => await sleep(15));
            await sleep(15);
        }

        [ScriptMethod(307, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_phantom_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e21_cov_phantom_exit/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("e21_cov_phantom_exit/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("e21_cov_phantom_exit/p2"), 0.5F);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(308, Lifecycle.CommandScript)]
        public async Task cs_e21_mars_pelican0_entry()
        {
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p1"), 0.5F);
            cs_face(true, GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p1_facing"));
            sleep_forever();
        }

        [ScriptMethod(309, Lifecycle.CommandScript)]
        public async Task cs_e21_mars_pelican0_exit()
        {
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p3"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p4"));
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p5"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(310, Lifecycle.CommandScript)]
        public async Task cs_e21_mars_pelican1_entry()
        {
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p0_1"));
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p0_2"));
            cs_fly_to(GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p1"), 0.5F);
            cs_face(true, GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p1_facing"));
            await sleep(30);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "pelican_p");
            await sleep(180);
            cs_face(false, GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p1_facing"));
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p3"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p4"));
            cs_fly_by(GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p5"));
            object_destroy(ai_vehicle_get(this.ai_current_actor));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(311, Lifecycle.CommandScript)]
        public async Task cs_e21_mars_inf1_exit()
        {
            cs_go_to(GetReference<ISpatialPoint>("e21_mars_inf1/p0"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task<bool> e21_cov_phantom1_retreating()
        {
            return this.g_e21_cov_phantom1_retreating == true;
        }

        [ScriptMethod(313, Lifecycle.Static)]
        public async Task<bool> e21_cov_phantom0_retreating()
        {
            return this.g_e21_cov_phantom0_retreating == true;
        }

        [ScriptMethod(314, Lifecycle.Dormant)]
        public async Task e21_dialog()
        {
            await sleep_until(async () => volume_test_objects(tv_e21_boulevard1, players()), 15);
            await sleep(ai_play_line_on_object(default(IGameObject), "0690"));
            await sleep(10);
            await sleep(ai_play_line_on_object(default(IGameObject), "0700"));
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task e21_cov_creep0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e21_cov_creep0_main, players()) || volume_test_objects(tv_e21_cov_inf0_unsafe, players()), 15);
            ai_place(e21_cov_creep0.Squad);
        }

        [ScriptMethod(316, Lifecycle.Dormant)]
        public async Task e21_cov_phantom1_main()
        {
            await sleep_until(async () => (short)ai_living_count(e21_cov_wraiths0) <= 1, 30, this.two_minutes);
            ai_place(e21_cov_phantom1.Squad);
            ai_place(e21_cov_ghosts0_0.Squad);
            await sleep(2);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(e21_cov_phantom1.phantom0), "phantom_sc01", ai_vehicle_get_from_starting_location(e21_cov_ghosts0_0.ghost0));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(e21_cov_phantom1.phantom0), "phantom_sc02", ai_vehicle_get_from_starting_location(e21_cov_ghosts0_0.ghost1));
            cs_run_command_script(e21_cov_phantom1.phantom0, new ScriptMethodReference(cs_e21_cov_phantom1_entry));
            await sleep_until(async () => object_get_health(ai_vehicle_get(e21_cov_phantom1.phantom0)) <= 0.05F || object_model_targets_destroyed(ai_vehicle_get(e21_cov_phantom1.phantom0), "target_front") >= 3, 10, this.one_minute);
            this.g_e21_cov_phantom1_retreating = true;
            cs_run_command_script(e21_cov_phantom1.phantom0, new ScriptMethodReference(cs_e21_cov_phantom_exit));
        }

        [ScriptMethod(317, Lifecycle.Dormant)]
        public async Task e21_cov_wraiths0_main()
        {
            ai_place(e21_cov_wraiths0_0.Squad);
            ai_place(e21_cov_wraiths0_1.Squad);
            await sleep(2);
            ai_vehicle_reserve(ai_vehicle_get(e21_cov_wraiths0_0.wraith0), true);
            ai_vehicle_reserve(ai_vehicle_get(e21_cov_wraiths0_1.wraith0), true);
            await sleep_until(async () => (short)ai_living_count(e21_cov_wraiths0) <= 1 || volume_test_objects(tv_e21_cov_wraith0_2_unsafe, players()), 15);
            if (!(volume_test_objects(tv_e21_cov_wraith0_2_unsafe, players())))
            {
                ai_place(e21_cov_wraiths0_2.Squad, (short)pin(2F - (float)ai_living_count(e21_cov_wraiths0), 0F, 1F));
            }

            await sleep(2);
            ai_vehicle_reserve(ai_vehicle_get(e21_cov_wraiths0_2.wraith0), true);
            wake(new ScriptMethodReference(e21_cov_phantom1_main));
        }

        [ScriptMethod(318, Lifecycle.Dormant)]
        public async Task e21_cov_inf0_main()
        {
            ai_place(e21_cov_inf0.Squad);
        }

        [ScriptMethod(319, Lifecycle.Dormant)]
        public async Task e21_mars_pelican1_main()
        {
            await sleep_until(async () => this.g_e21_cov_phantom1_retreating);
            await sleep(60);
            ai_place(e21_mars_pelican1.Squad);
            cs_run_command_script(e21_mars_pelican1.pelican0, new ScriptMethodReference(cs_e21_mars_pelican1_entry));
        }

        [ScriptMethod(320, Lifecycle.Dormant)]
        public async Task e21_mars_pelican0_main()
        {
            await sleep_until(async () => this.g_e21_cov_phantom1_retreating);
            ai_place(e21_mars_pelican0.pelican0);
            cs_run_command_script(e21_mars_pelican0.pelican0, new ScriptMethodReference(cs_e21_mars_pelican0_entry));
            ai_place(e21_mars_pelican0.scorpion0);
            vehicle_load_magic(ai_vehicle_get(e21_mars_pelican0.pelican0), "pelican_lc", ai_vehicle_get_from_starting_location(e21_mars_pelican0.scorpion0));
            await sleep_until(async () => volume_test_objects(tv_e22_begin_scarab_sequence, players()), 15);
            cs_run_command_script(e21_mars_pelican0.pelican0, new ScriptMethodReference(cs_e21_mars_pelican0_exit));
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task e21_mars_warthog0_main()
        {
            ai_migrate(e20_mars_warthog0.Squad, e21_mars_warthog0.Squad);
            ai_migrate(e20_mars_warthog1.Squad, e21_mars_warthog0.Squad);
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task e21_mars_inf1_main()
        {
            await sleep_until(async () => this.g_e21_cov_phantom0_retreating, 15);
            ai_place(e21_mars_inf1.Squad);
            ai_disregard(ai_actors(e21_mars_inf1.Squad), true);
            await sleep_until(async () => this.g_e22_started);
            cs_run_command_script(e21_mars_inf1.Squad, new ScriptMethodReference(cs_e21_mars_inf1_exit));
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task e21_mars_inf0_main()
        {
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e21_mars_inf0.Squad) < 2 && (short)ai_spawn_count(e21_mars_inf0.Squad) < 10 && !(volume_test_objects(tv_e21_mars_inf0_unsafe, players())))
                {
                    ai_place(e21_mars_inf0.Squad, 1);
                }

                return (short)ai_spawn_count(e21_mars_inf0.Squad) >= 10 || this.g_e22_started;
            });
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task e21_main_end_condition()
        {
            await sleep_until(async () => this.g_e21_cov_phantom1_retreating);
            await sleep_until(async () => (short)ai_living_count(e21_cov_ghosts0) <= 0 && (short)ai_living_count(e21_cov_wraiths0) <= 0, 30, this.one_minute);
            wake(new ScriptMethodReference(e22_main));
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task e21_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e21_main_begin, players()), 15);
            this.g_e21_started = true;
            print("e21_main");
            data_mine_set_mission_segment("e21_hospital_seige");
            game_save();
            wake(new ScriptMethodReference(e21_main_end_condition));
            wake(new ScriptMethodReference(e21_mars_warthog0_main));
            wake(new ScriptMethodReference(e21_mars_pelican0_main));
            wake(new ScriptMethodReference(e21_mars_pelican1_main));
            wake(new ScriptMethodReference(e21_cov_inf0_main));
            wake(new ScriptMethodReference(e21_cov_wraiths0_main));
            wake(new ScriptMethodReference(e21_dialog));
            await sleep_until(async () => this.g_e22_started);
            sleep_forever(new ScriptMethodReference(e21_mars_warthog0_main));
            sleep_forever(new ScriptMethodReference(e21_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e21_mars_inf1_main));
            sleep_forever(new ScriptMethodReference(e21_cov_creep0_main));
            sleep_forever(new ScriptMethodReference(e21_cov_wraiths0_main));
            sleep_forever(new ScriptMethodReference(e21_cov_phantom1_main));
            sleep_forever(new ScriptMethodReference(e21_dialog));
            ai_disposable(e21_cov, true);
            ai_disposable(e21_cov_phantom0.Squad, false);
            ai_disposable(e21_cov_phantom1.Squad, false);
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task test_hospital_seige()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), e21_test);
            object_destroy(scarab.Entity);
            ai_place(e21_mars_warthog0.Squad);
            if (!(this.g_e21_started))
            {
                wake(new ScriptMethodReference(e21_main));
            }
        }

        [ScriptMethod(327, Lifecycle.Dormant)]
        public async Task e20_cov_ghosts0_main()
        {
            ai_migrate(e19_cov_ghosts0, e20_cov_ghosts0.Squad);
            ai_place(e20_cov_ghosts0.Squad);
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task e20_mars_warthog1_main()
        {
            ai_place(e20_mars_warthog1.Squad);
            if ((short)ai_living_count(e20_mars_warthog0.Squad) > 1)
            {
                ai_erase(e20_mars_warthog1.spare);
            }
        }

        [ScriptMethod(329, Lifecycle.Dormant)]
        public async Task e20_mars_warthog0_main()
        {
            ai_migrate(e19_mars_warthog0.Squad, e20_mars_warthog0.Squad);
            wake(new ScriptMethodReference(e20_mars_warthog1_main));
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task e20_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e20_main_begin, players()), 15);
            this.g_e20_started = true;
            print("e20_main");
            data_mine_set_mission_segment("e20_road_skirmish");
            game_save();
            wake(new ScriptMethodReference(music_03b_03_start));
            wake(new ScriptMethodReference(e20_mars_warthog0_main));
            wake(new ScriptMethodReference(e20_cov_ghosts0_main));
            await sleep_until(async () => this.g_e21_started);
            ai_disposable(e20_cov, true);
        }

        [ScriptMethod(331, Lifecycle.Static)]
        public async Task test_road_skirmishes()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), e20_test);
            object_destroy(scarab.Entity);
            ai_place(e20_mars_warthog0.Squad);
            wake(new ScriptMethodReference(e20_main));
            wake(new ScriptMethodReference(e21_main));
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task cs_e19_cov_ghosts0_1_entry1()
        {
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e19_cov_ghosts0_1/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e19_cov_ghosts0_1/p3"));
            await sleep(60);
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task cs_e19_cov_ghosts0_1_entry0()
        {
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e19_cov_ghosts0_1/p0"));
            cs_go_to(GetReference<ISpatialPoint>("e19_cov_ghosts0_1/p1"));
            await sleep(60);
        }

        [ScriptMethod(334, Lifecycle.Dormant)]
        public async Task e19_cov_ghosts0_main()
        {
            ai_migrate(e18_cov_ghosts0.Squad, e19_cov_ghosts0_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e19_player_advanced, players()), 15);
            ai_place(e19_cov_ghosts0_0.Squad);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e19_cov_ghosts0) <= 0)
                {
                    await sleep(300);
                    await sleep_until(async () => !(volume_test_objects(tv_e19_cov_ghosts0_1_unsafe, players())));
                    ai_place(e19_cov_ghosts0_1.Squad);
                }

                return (short)ai_spawn_count(e19_cov_ghosts0) >= 6;
            });
        }

        [ScriptMethod(335, Lifecycle.Dormant)]
        public async Task e19_cov_wraiths0_main()
        {
            ai_place(e19_cov_wraiths0_0.Squad);
        }

        [ScriptMethod(336, Lifecycle.Dormant)]
        public async Task e19_cov_inf0_main()
        {
            ai_place(e19_cov_inf0.Squad);
        }

        [ScriptMethod(337, Lifecycle.Dormant)]
        public async Task e19_mars_inf0_main()
        {
            ai_migrate(e18_mars_inf0.Squad, e19_mars_warthog0.Squad);
            ai_migrate(e18_mars_warthog0.Squad, e19_mars_warthog0.Squad);
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task e19_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e19_main_begin0, players()) || volume_test_objects(tv_e19_main_begin1, players()), 15);
            this.g_e19_started = true;
            print("e19_main");
            data_mine_set_mission_segment("e19_park");
            game_save();
            object_create_anew(e19_tree0);
            object_create_anew(e19_tree1);
            wake(new ScriptMethodReference(e19_mars_inf0_main));
            wake(new ScriptMethodReference(e19_cov_inf0_main));
            wake(new ScriptMethodReference(e19_cov_wraiths0_main));
            wake(new ScriptMethodReference(e19_cov_ghosts0_main));
            await sleep_until(async () => this.g_e20_started);
            sleep_forever(new ScriptMethodReference(e19_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e19_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e19_cov_wraiths0_main));
            sleep_forever(new ScriptMethodReference(e19_cov_ghosts0_main));
            ai_disposable(e19_cov, true);
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task cs_e18_mars_warthog0_orbit()
        {
            await sleep_until(async () =>
            {
                cs_go_by(GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p4"), GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p5"));
                cs_go_by(GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p5"), GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p6"));
                cs_go_by(GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p6"), GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p0"));
                cs_go_by(GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p0"), GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p1"));
                cs_go_by(GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p1"), GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p2"));
                cs_go_by(GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p2"), GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p3"));
                cs_go_by(GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p3"), GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p4"));
                if (vehicle_test_seat_list(ai_vehicle_get(this.ai_current_actor), "warthog_g", players()) || vehicle_test_seat_list(ai_vehicle_get(this.ai_current_actor), "warthog_p", players()))
                {
                    this.g_e18_orbit_count = (short)(this.g_e18_orbit_count + 1);
                }

                return this.g_e19_started || (short)ai_living_count(e18_cov_inf1_1.Squad) <= 0 || this.g_e18_orbit_count >= 2;
            }, 1);
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task cs_e18_mars_warthog0_approach0()
        {
            cs_approach_player(5F, 50F, 50F);
            if (!(this.g_e18_mars_warthog0_spoke))
            {
                ai_play_line_at_player(this.ai_current_actor, "8000") // Couldn't generate cast from 'Short' to 'Void'
                ;
                print("could use a gunner, sir!");
                this.g_e18_mars_warthog0_spoke = true;
            }

            await sleep_until(async () => objects_distance_to_object(ai_actors(e18_mars_warthog0.warthog0), await this.player0()) > 7F || unit_in_vehicle(unit(await this.player0())), 15, 600);
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task cs_e18_mars_warthog0_approach1()
        {
            cs_approach_player(5F, 50F, 50F);
            if (!(this.g_e18_mars_warthog0_spoke))
            {
                ai_play_line_at_player(this.ai_current_actor, "8000") // Couldn't generate cast from 'Short' to 'Void'
                ;
                print("could use a gunner, sir!");
                this.g_e18_mars_warthog0_spoke = true;
            }

            await sleep_until(async () => objects_distance_to_object(ai_actors(e18_mars_warthog0.warthog0), await this.player1()) > 7F || unit_in_vehicle(unit(await this.player1())), 15, 600);
        }

        [ScriptMethod(342, Lifecycle.CommandScript)]
        public async Task cs_e18_mars_warthog0_abort()
        {
            await sleep(1);
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task cs_e18_cov_inf0_sniper0()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_dangerous);
            cs_aim_object(true, ai_vehicle_get(e18_mars_warthog0.warthog0));
            sleep_forever();
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task cs_e18_cov_inf2_1_entry0()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_go_to(GetReference<ISpatialPoint>("e18_cov_inf2_entry/p0"));
            cs_go_to(GetReference<ISpatialPoint>("e18_cov_inf2_entry/p1"));
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task e18_scarab_main()
        {
            object_create_anew(scarab);
            object_teleport(scarab.Entity, e18_scarab_start);
            pvs_set_object(scarab.Entity);
            await sleep_until(async () =>
            {
                device_set_position_track(scarab.Entity, "park_idle", 0F);
                device_animate_position(scarab.Entity, 1F, 119F / 30F, 0F, 0F, true);
                await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
                return volume_test_objects(tv_e19_scarab_withdraws, players());
            }, 1, this._30_seconds);
            device_set_position_track(scarab.Entity, "park_exit", 0F);
            device_animate_position(scarab.Entity, 1F, 831F / 30F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_turn_22_left();
            await this.scarab_walk_front_turn_22_left();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_to_idle();
            await this.scarab_idle_turn_45_right();
            await this.scarab_idle_turn_45_right();
            await this.scarab_idle_to_walk_front();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_to_idle();
            object_destroy(scarab.Entity);
        }

        [ScriptMethod(346, Lifecycle.Dormant)]
        public async Task e18_cov_ghosts0_main()
        {
            await sleep_until(async () => (short)ai_living_count(e18_cov_inf1_1.Squad) <= 0 || volume_test_objects(tv_e19_main_begin1, players()));
            if (!(volume_test_objects(tv_e19_main_begin1, players())))
            {
                ai_place(e18_cov_ghosts0.Squad);
            }
        }

        [ScriptMethod(347, Lifecycle.Static)]
        public async Task e18_cov_inf2_spawn()
        {
            if (volume_test_objects(tv_e18_second_half, players()))
            {
                if (!(volume_test_objects(tv_e18_cov_inf2_1_unsafe1, players())))
                {
                    ai_place(e18_cov_inf2_1.sniper1);
                }

                if (!(volume_test_objects(tv_e18_cov_inf2_1_unsafe0, players())))
                {
                    ai_place(e18_cov_inf2_1.sniper0);
                }
            }
        }

        [ScriptMethod(348, Lifecycle.Dormant)]
        public async Task e18_cov_inf2_main()
        {
            ai_place(e18_cov_inf2_0.Squad);
            if (await this.difficulty_heroic())
            {
                this.g_e18_cov_inf2_spawn_max = 8;
            }

            if (await this.difficulty_legendary())
            {
                this.g_e18_cov_inf2_spawn_max = 12;
            }

            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e18_cov_inf2) < 1 || (short)ai_living_count(e18_cov_inf1) < 5 && (short)ai_living_count(e18_cov_inf2) < 2 || await this.difficulty_legendary() && (short)ai_living_count(e18_cov_inf1) < 4 && (short)ai_living_count(e18_cov_inf2) < 2)
                {
                    await this.e18_cov_inf2_spawn();
                    await sleep((short)random_range(60, 300));
                }

                return (short)ai_spawn_count(e18_cov_inf2) >= this.g_e18_cov_inf2_spawn_max;
            });
        }

        [ScriptMethod(349, Lifecycle.Dormant)]
        public async Task e18_cov_inf1_main()
        {
            ai_place(e18_cov_inf1);
        }

        [ScriptMethod(350, Lifecycle.Dormant)]
        public async Task e18_cov_inf0_main()
        {
            ai_place(e18_cov_inf0.Squad);
        }

        [ScriptMethod(351, Lifecycle.Dormant)]
        public async Task e18_mars_warthog0_main()
        {
            ai_place(e18_mars_warthog0.Squad);
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(ai_actors(e18_mars_warthog0.warthog0), await this.player0()) < 6F && !(unit_in_vehicle(unit(await this.player0()))))
                {
                    cs_stack_command_script(e18_mars_warthog0.warthog0, new ScriptMethodReference(cs_e18_mars_warthog0_approach0));
                    await sleep_until(async () => !(unit_in_vehicle(ai_get_unit(e18_mars_warthog0.warthog0))), 30, 900);
                }
                else if ((bool)game_is_cooperative() && objects_distance_to_object(ai_actors(e18_mars_warthog0.warthog0), await this.player1()) < 6F && !(unit_in_vehicle(unit(await this.player1()))))
                {
                    cs_stack_command_script(e18_mars_warthog0.warthog0, new ScriptMethodReference(cs_e18_mars_warthog0_approach1));
                    await sleep_until(async () => !(unit_in_vehicle(ai_get_unit(e18_mars_warthog0.warthog0))), 30, 900);
                }

                return !(unit_in_vehicle(ai_get_unit(e18_mars_warthog0.warthog0)));
            }, 15);
            print("omg?");
            cs_run_command_script(e18_mars_warthog0.warthog0, new ScriptMethodReference(cs_e18_mars_warthog0_abort));
        }

        [ScriptMethod(352, Lifecycle.Dormant)]
        public async Task e18_mars_inf0_main()
        {
            ai_migrate(e17_mars_inf0.Squad, e18_mars_inf0.Squad);
        }

        [ScriptMethod(353, Lifecycle.Dormant)]
        public async Task e18_key()
        {
            if (!(await this.difficulty_legendary()))
            {
                sleep_forever();
            }

            object_create(key);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4219345360U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4219345360U)));
            ice_cream_flavor_stock(9);
        }

        [ScriptMethod(354, Lifecycle.Dormant)]
        public async Task e18_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e18_main_begin, players()), 15);
            this.g_e18_started = true;
            print("e18_main");
            data_mine_set_mission_segment("e18_park");
            game_save();
            kill_volume_enable(kill_e18_0);
            object_destroy(e19_tree0.Entity);
            object_destroy(e19_tree1.Entity);
            wake(new ScriptMethodReference(chapter_title1));
            wake(new ScriptMethodReference(objective1_clear));
            wake(new ScriptMethodReference(objective2_set));
            wake(new ScriptMethodReference(e19_main));
            wake(new ScriptMethodReference(e20_main));
            wake(new ScriptMethodReference(e21_main));
            wake(new ScriptMethodReference(e18_mars_inf0_main));
            wake(new ScriptMethodReference(e18_mars_warthog0_main));
            wake(new ScriptMethodReference(e18_cov_inf0_main));
            wake(new ScriptMethodReference(e18_cov_inf1_main));
            wake(new ScriptMethodReference(e18_cov_inf2_main));
            wake(new ScriptMethodReference(e18_cov_ghosts0_main));
            wake(new ScriptMethodReference(e18_scarab_main));
            wake(new ScriptMethodReference(e18_key));
            await sleep_until(async () => this.g_e19_started);
            sleep_forever(new ScriptMethodReference(e18_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e18_mars_warthog0_main));
            sleep_forever(new ScriptMethodReference(e18_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e18_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e18_cov_inf2_main));
            sleep_forever(new ScriptMethodReference(e18_cov_ghosts0_main));
            ai_disposable(e18_cov, true);
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task test_park()
        {
            switch_bsp(1);
            object_teleport(await this.player0(), e18_test);
            ai_place(e18_mars_inf0.Squad);
            if (!(this.g_e18_started))
            {
                wake(new ScriptMethodReference(e18_main));
            }
        }

        [ScriptMethod(356, Lifecycle.CommandScript)]
        public async Task cs_e17_mars_inf0_drive()
        {
            cs_enable_pathfinding_failsafe(true);
            object_cannot_die(ai_get_object(e17_mars_inf0.warthog0), true);
            object_cannot_die(ai_get_object(e17_mars_inf0.passenger0), true);
            cs_go_to(GetReference<ISpatialPoint>("e17_mars_inf0_entry/p0"));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 13F || volume_test_objects(tv_e17_near_first_wall, players()), 15, this.one_minute);
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4166391464U), ai_vehicle_get(this.ai_current_actor), 1.5F);
            await sleep(5);
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4166391464U));
            await sleep(5);
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4166391464U), ai_vehicle_get(this.ai_current_actor), 1.5F);
            await sleep(15);
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4166391464U));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 10F || (float)ai_strength(this.ai_current_actor) <= 0.5F || (float)ai_strength(this.ai_current_squad) <= 0.75F || volume_test_objects(tv_e17_first_wall_approach, players()), 15, 600);
            cs_go_by(GetReference<ISpatialPoint>("e17_mars_inf0_entry/p0_1"), GetReference<ISpatialPoint>("e17_mars_inf0_entry/p1"));
            cs_go_to(GetReference<ISpatialPoint>("e17_mars_inf0_entry/p1"));
            this.g_e17_mars_warthog0_arrived = true;
            await sleep(20);
            object_cannot_die(ai_get_object(e17_mars_inf0.warthog0), false);
            object_cannot_die(ai_get_object(e17_mars_inf0.passenger0), false);
            ai_vehicle_exit(e17_mars_inf0.warthog0);
            ai_vehicle_exit(e17_mars_inf0.passenger0);
        }

        [ScriptMethod(357, Lifecycle.CommandScript)]
        public async Task cs_e17_shotgun_scene()
        {
            print("marine: hey, sir!");
            cs_approach_player(1F, 10F, 15F);
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0640"));
            await sleep_until(async () => !(unit_has_weapon(ai_get_unit(this.ai_current_actor), GetTag<BaseTag>("objects\\weapons\\rifle\\shotgun\\shotgun.weapon", 4216396195U))) || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 5F, 15, this.one_minute);
        }

        [ScriptMethod(358, Lifecycle.CommandScript)]
        public async Task cs_e17_cov_inf0_0_turret0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_deploy_turret(GetReference<ISpatialPoint>("e17_turrets/p0"));
        }

        [ScriptMethod(359, Lifecycle.CommandScript)]
        public async Task cs_e17_cov_ghost0_entry0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p0"));
            await sleep(30);
            cs_vehicle_boost(false);
            cs_go_to(GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p0"), 0.1F);
            cs_face(true, GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p1"));
            await sleep(60);
            cs_vehicle_boost(true);
            cs_face(false, GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p1"));
            cs_go_to(GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p1"));
            await sleep(30);
            cs_vehicle_boost(false);
        }

        [ScriptMethod(360, Lifecycle.CommandScript)]
        public async Task cs_e17_mars_selective_migrate()
        {
            if (unit_in_vehicle(ai_get_unit(this.ai_current_actor)) && volume_test_object(tv_e17_migration_area, ai_get_object(this.ai_current_actor)) && (short)ai_living_count(e17_mars_inf0.Squad) <= 2)
            {
                ai_migrate(this.ai_current_actor, e17_mars_inf0.Squad);
            }
        }

        [ScriptMethod(361, Lifecycle.CommandScript)]
        public async Task cs_e17_cov_inf0_2_ambush()
        {
            cs_abort_on_combat_status(this.ai_combat_status_dangerous);
            cs_abort_on_damage(true);
            cs_crouch(true);
            cs_enable_looking(true);
            await sleep_until(async () => volume_test_object(tv_e17_section3, ai_get_object(this.ai_current_actor)) || (float)ai_strength(this.ai_current_squad) < 1F, 10);
        }

        [ScriptMethod(362, Lifecycle.Static)]
        public async Task<bool> e17_door0_open()
        {
            return device_get_position(e17_door0.Entity) >= 0.5F;
        }

        [ScriptMethod(363, Lifecycle.Static)]
        public async Task<bool> e17_door1_open()
        {
            return device_get_position(e17_door1.Entity) >= 0.5F;
        }

        [ScriptMethod(364, Lifecycle.Static)]
        public async Task<bool> e17_mars_warthog0_can_wait()
        {
            return this.g_e17_mars_warthog0_arrived || volume_test_objects(tv_e17_on_first_wall, players());
        }

        [ScriptMethod(365, Lifecycle.Dormant)]
        public async Task e17_doors_main()
        {
            device_set_position(e17_door1.Entity, 1F);
            await sleep_until(async () => volume_test_objects(tv_e17_section2, players()), 15);
            device_set_position(e17_door0.Entity, 1F);
        }

        [ScriptMethod(366, Lifecycle.Dormant)]
        public async Task e17_shotgun_scene()
        {
            await sleep_until(async () => ai_scene("e17_shotgun_scene", new ScriptMethodReference(cs_e17_shotgun_scene), e17_mars_inf0.passenger0), 5, this.two_minutes);
        }

        [ScriptMethod(367, Lifecycle.Dormant)]
        public async Task e17_dialog()
        {
            await sleep_until(async () => volume_test_objects(tv_e17_on_first_wall, players()), 15);
            await sleep(ai_play_line_on_object(default(IGameObject), "0650"));
            await sleep(20);
            await sleep_until(async () => volume_test_objects(tv_e17_section0, players()), 15);
            await sleep_until(async () => (bool)game_safe_to_save(), 30, this.one_minute);
            ai_play_line_on_object(default(IGameObject), "0660") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(368, Lifecycle.Dormant)]
        public async Task e17_cov_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e17_near_first_wall, players()), 15);
            ai_place(e17_cov_inf2_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e17_cov_inf2_1_begin, players()), 15);
            ai_place(e17_cov_inf2_1.Squad);
            await sleep_until(async () => volume_test_objects(tv_e17_section2, players()), 15);
            ai_place(e17_cov_inf2_2.Squad);
            await sleep_until(async () => volume_test_objects(tv_e17_section3, players()), 15);
            ai_place(e17_cov_inf2_3.Squad, (short)pin(3F - (float)ai_living_count(e17_cov_inf2), 0F, 1F));
        }

        [ScriptMethod(369, Lifecycle.Dormant)]
        public async Task e17_cov_inf1_main()
        {
            ai_place(e17_cov_inf1_0.Squad);
        }

        [ScriptMethod(370, Lifecycle.Dormant)]
        public async Task e17_cov_inf0_aux()
        {
            await sleep_until(async () => volume_test_objects(tv_e17_cov_inf0_2_init, players()), 15);
            ai_place(e17_cov_inf0_2.Squad);
            await sleep_until(async () => volume_test_objects(tv_e17_near_second_wall, players()), 15);
            if (await this.difficulty_legendary())
            {
                ai_place(e17_cov_inf0_3.Squad);
            }
        }

        [ScriptMethod(371, Lifecycle.Dormant)]
        public async Task e17_cov_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e17_near_first_wall, players()), 15);
            wake(new ScriptMethodReference(e17_cov_inf0_aux));
            game_save();
            wake(new ScriptMethodReference(music_03b_02_stop));
            await sleep_until(async () => volume_test_objects(tv_e17_on_first_wall, players()), 15);
            ai_place(e17_cov_inf0_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e17_section1, players()), 15);
            if ((short)ai_living_count(e17_cov_inf0) <= 4)
            {
                ai_place(e17_cov_inf0_1.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_e17_section2, players()), 15);
            game_save();
            await sleep(30);
            if ((short)ai_living_count(e17_cov_inf0) <= 4)
            {
                ai_place(e17_cov_inf0_1.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_e17_section3, players()), 15);
            if ((short)ai_living_count(e17_cov_inf0) <= 4)
            {
                ai_place(e17_cov_inf0_1.Squad);
            }
        }

        [ScriptMethod(372, Lifecycle.Dormant)]
        public async Task e17_mars_inf0_main()
        {
            cs_run_command_script(e16_mars_inf0.Squad, new ScriptMethodReference(cs_e17_mars_selective_migrate));
            await sleep(15);
            ai_place(e17_mars_inf0.Squad);
            ai_vehicle_reserve(ai_vehicle_get(e17_mars_inf0.warthog0), true);
            ai_disposable(e16_mars, true);
            wake(new ScriptMethodReference(e17_shotgun_scene));
        }

        [ScriptMethod(373, Lifecycle.Dormant)]
        public async Task e17_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e17_main_begin, players()), 15);
            this.g_e17_started = true;
            print("e17_main");
            data_mine_set_mission_segment("e17_flooded_tunnel");
            game_save();
            wake(new ScriptMethodReference(objective0_clear));
            wake(new ScriptMethodReference(objective1_set));
            wake(new ScriptMethodReference(e17_mars_inf0_main));
            wake(new ScriptMethodReference(e17_cov_inf0_main));
            wake(new ScriptMethodReference(e17_cov_inf1_main));
            wake(new ScriptMethodReference(e17_cov_inf2_main));
            wake(new ScriptMethodReference(e17_doors_main));
            await sleep_until(async () => this.g_e18_started);
            sleep_forever(new ScriptMethodReference(e17_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e17_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e17_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e17_cov_inf2_main));
            sleep_forever(new ScriptMethodReference(e17_doors_main));
            sleep_forever(new ScriptMethodReference(e17_dialog));
            ai_disposable(e17_cov, true);
        }

        [ScriptMethod(374, Lifecycle.Static)]
        public async Task test_flooded_tunnel()
        {
            object_teleport(await this.player0(), e17_test);
            object_create(e17_test_tank);
            if (!(this.g_e17_started))
            {
                wake(new ScriptMethodReference(e17_main));
            }

            if (!(this.g_e18_started))
            {
                wake(new ScriptMethodReference(e18_main));
            }
        }

        [ScriptMethod(375, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_ghosts0_advance1()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_enable_targeting(true);
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/start"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p0"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p5"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p6"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p7"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p8"));
        }

        [ScriptMethod(376, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_ghosts0_advance0()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_enable_targeting(true);
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/start"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p0"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p1"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p3"));
            cs_go_to(GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p4"));
        }

        [ScriptMethod(377, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_banshee_boost0()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e16_cov_banshees0/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e16_cov_banshees0/p1"));
            await sleep((short)random_range(30, 60));
        }

        [ScriptMethod(378, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_banshee_boost1()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e16_cov_banshees0/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("e16_cov_banshees0/p3"));
            await sleep((short)random_range(30, 60));
        }

        [ScriptMethod(379, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_inf0_last_stand()
        {
            cs_abort_on_damage(true);
            cs_enable_targeting(true);
            cs_face_player(true);
            cs_crouch(true);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 12F || (float)ai_strength(this.ai_current_actor) <= 0.9F || (float)ai_strength(this.ai_current_squad) <= 0.5F);
        }

        [ScriptMethod(380, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_phantom0_entry()
        {
            cs_vehicle_boost(true);
            await sleep(135);
        }

        [ScriptMethod(381, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_phantom0_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e16_cov_phantom0/p0"), GetReference<ISpatialPoint>("e16_cov_phantom0/p1"), 1F);
            cs_fly_by(GetReference<ISpatialPoint>("e16_cov_phantom0/p1"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e16_cov_phantom0/p2"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(382, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_wraiths1_entry()
        {
            cs_enable_moving(true);
            cs_vehicle_boost(true);
            await sleep(180);
        }

        [ScriptMethod(383, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_ghosts1_entry()
        {
            cs_enable_moving(true);
            cs_vehicle_boost(true);
            await sleep(150);
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task e16_cov_phantom0_main()
        {
            await sleep_until(async () => (short)ai_living_count(e16_cov_wraiths1.Squad) <= 0);
            ai_place(e16_cov_phantom0.Squad);
            await sleep_until(async () => object_get_health(ai_vehicle_get(e16_cov_phantom0.phantom0)) <= 0.05F || object_model_targets_destroyed(ai_vehicle_get(e16_cov_phantom0.phantom0), "target_front") >= 2, 30);
            cs_run_command_script(e16_cov_phantom0.phantom0, new ScriptMethodReference(cs_e16_cov_phantom0_exit));
        }

        [ScriptMethod(385, Lifecycle.Dormant)]
        public async Task e16_cov_wraiths1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e16_toll_plaza, players()) || (float)ai_living_count(e16_cov_ghosts1.Squad) + (float)ai_living_count(e16_cov_banshees0) <= 1F);
            ai_place(e16_cov_wraiths1.Squad);
        }

        [ScriptMethod(386, Lifecycle.Dormant)]
        public async Task e16_cov_ghosts1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e16_toll_plaza, players()) || (short)ai_living_count(e16_cov_banshees0) <= 1);
            ai_place(e16_cov_ghosts1.Squad, (short)(3 - (float)ai_living_count(e16_cov_ghosts0)));
        }

        [ScriptMethod(387, Lifecycle.Dormant)]
        public async Task e16_cov_banshees0_main()
        {
            ai_migrate(e15_cov_banshees01.Squad, e16_cov_banshees0_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e16_bridge_end, players()), 15);
            ai_place(e16_cov_banshees0_1.Squad, (short)(3 - (float)ai_living_count(e16_cov_banshees0)));
            await sleep(150);
            ai_play_line_on_object(default(IGameObject), "0620") // Couldn't generate cast from 'Short' to 'Void'
            ;
            wake(new ScriptMethodReference(music_03b_01_start_alt));
            game_save();
            wake(new ScriptMethodReference(e16_cov_ghosts1_main));
            await sleep_until(async () => (short)ai_spawn_count(e16_cov_ghosts1.Squad) > 0 && (float)ai_living_count(e16_cov_ghosts1.Squad) + (float)ai_living_count(e16_cov_banshees0) <= 1F);
            game_save();
            ai_place(e16_cov_banshees0_1.Squad);
            wake(new ScriptMethodReference(e16_cov_wraiths1_main));
        }

        [ScriptMethod(388, Lifecycle.Dormant)]
        public async Task e16_cov_ghosts0_main()
        {
            ai_place(e16_cov_ghosts0_0.Squad);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e16_cov_wraiths0) <= 0 && (short)ai_living_count(e16_cov_ghosts0) < 4 || (short)ai_living_count(e16_cov_ghosts0) < 3)
                {
                    ai_place(e16_cov_ghosts0_1.Squad, 1);
                }

                return volume_test_objects(tv_e16_bridge_end, players()) || (short)ai_spawn_count(e16_cov_ghosts0) >= 10;
            }, 90);
            game_save();
        }

        [ScriptMethod(389, Lifecycle.Dormant)]
        public async Task e16_cov_wraiths0_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e16_cov_wraiths0) > 0);
            await sleep_until(async () => volume_test_objects(tv_e16_toll_plaza, players()) || (short)ai_living_count(e16_cov_wraiths0_0.Squad) <= 0);
            game_save();
        }

        [ScriptMethod(390, Lifecycle.Dormant)]
        public async Task e16_cov_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e16_tunnel, players()), 15);
            game_save();
            await sleep(15);
            wake(new ScriptMethodReference(music_03b_01_stop));
            wake(new ScriptMethodReference(music_03b_02_start));
            await sleep_until(async () => volume_test_objects(tv_e16_cov_inf0_1_begin, players()), 15);
            ai_place(e16_cov_inf0_1.Squad, (short)pin(9F - (float)ai_living_count(e16_cov_inf0), 0F, 2F));
            await sleep_until(async () => volume_test_objects(tv_e16_cov_inf0_2_begin, players()), 15);
            ai_place(e16_cov_inf0_2.Squad, (short)pin(9F - (float)ai_living_count(e16_cov_inf0), 0F, 1F));
        }

        [ScriptMethod(391, Lifecycle.Dormant)]
        public async Task e16_mars_inf0_main()
        {
            ai_migrate(e15_mars_inf0.Squad, e16_mars_inf0.Squad);
        }

        [ScriptMethod(392, Lifecycle.Dormant)]
        public async Task e16_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e16_main_begin, players()), 15);
            this.g_e16_started = true;
            print("e16_main");
            data_mine_set_mission_segment("e16_bridge_descent");
            game_save();
            wake(new ScriptMethodReference(e16_mars_inf0_main));
            wake(new ScriptMethodReference(e16_cov_inf0_main));
            wake(new ScriptMethodReference(e16_cov_wraiths0_main));
            wake(new ScriptMethodReference(e16_cov_ghosts0_main));
            wake(new ScriptMethodReference(e16_cov_banshees0_main));
            await sleep_until(async () => this.g_e17_started);
            sleep_forever(new ScriptMethodReference(e16_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e16_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e16_cov_wraiths0_main));
            sleep_forever(new ScriptMethodReference(e16_cov_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e16_cov_wraiths1_main));
            sleep_forever(new ScriptMethodReference(e16_cov_ghosts1_main));
            sleep_forever(new ScriptMethodReference(e16_cov_banshees0_main));
            ai_disposable(e16_cov, true);
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            ai_erase(e16_mars);
            ai_erase(e16_cov);
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task test_bridge_descent()
        {
            object_teleport(await this.player0(), e16_test);
            ai_place(e16_mars_inf0.Squad);
            if (!(this.g_e16_started))
            {
                wake(new ScriptMethodReference(e16_main));
            }

            if (!(this.g_e17_started))
            {
                wake(new ScriptMethodReference(e17_main));
            }

            if (!(this.g_e18_started))
            {
                wake(new ScriptMethodReference(e18_main));
            }
        }

        [ScriptMethod(394, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom0_1_entry()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p0"));
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p2"));
        }

        [ScriptMethod(395, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom0_1_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            if ((short)ai_living_count(e16_cov_wraiths0_0.wraith1) > 0)
            {
                cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p4"));
                cs_face_player(true);
                cs_fly_to(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p5"), 1F);
                cs_fly_to(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p6"), 0.5F);
                if (!(volume_test_objects(tv_e15_phantom_drop_zone1, players())))
                {
                    await sleep(75);
                    vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_lc");
                    await sleep(20);
                }

                cs_face_player(false);
                cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p5"), 1F);
                cs_fly_to_and_face(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p7_1"), GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p8"));
            }
            else
            {
                cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p7"));
            }

            cs_fly_to(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p8"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p8"), GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p9"), 1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p9"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(396, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom0_0_entry()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p0"));
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p2"));
        }

        [ScriptMethod(397, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom0_0_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            if ((short)ai_living_count(e16_cov_wraiths0_0.wraith0) > 0)
            {
                cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p4"));
                cs_fly_to(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p5"), 1F);
                cs_face_player(true);
                cs_fly_to(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p6"), 0.5F);
                if (!(volume_test_objects(tv_e15_phantom_drop_zone0, players())))
                {
                    await sleep(75);
                    vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_lc");
                    await sleep(20);
                }

                cs_face_player(false);
                cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p5"), 1F);
                cs_fly_to_and_face(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p7"), GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p8"), 1F);
            }

            cs_fly_to_and_face(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p3"), GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p8"), 0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p8"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p8"), GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p9"), 1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p9"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(398, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom1_entry()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e15_overflights/p0"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(399, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_banshee0_0_entry()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e15_overflights/p1"));
        }

        [ScriptMethod(400, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_banshee0_1_entry()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e15_overflights/p2"));
        }

        [ScriptMethod(401, Lifecycle.CommandScript)]
        public async Task cs_e15_mars_inf0_unload()
        {
            if ((short)ai_living_count(e15_mars_inf0.Squad) > 1 && !(unit_has_weapon(ai_get_unit(this.ai_current_actor), GetTag<BaseTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher.weapon", 4213709178U))))
            {
                await sleep(30);
                ai_vehicle_exit(this.ai_current_actor);
            }
        }

        [ScriptMethod(402, Lifecycle.CommandScript)]
        public async Task cs_e15_mars_inf0_init()
        {
            cs_enable_targeting(true);
            cs_crouch(true);
            await sleep_until(async () => this.g_e16_started || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 8F, 15);
        }

        [ScriptMethod(403, Lifecycle.CommandScript)]
        public async Task cs_e15_mars_inf0_abort()
        {
            await sleep(1);
        }

        [ScriptMethod(404, Lifecycle.Static)]
        public async Task oes_e14_blind()
        {
            ai_set_blind(this.ai_current_squad, true);
            ai_set_deaf(this.ai_current_squad, true);
        }

        [ScriptMethod(405, Lifecycle.Static)]
        public async Task oes_e14_unblind()
        {
            ai_set_blind(this.ai_current_squad, false);
            ai_set_deaf(this.ai_current_squad, false);
        }

        [ScriptMethod(406, Lifecycle.Dormant)]
        public async Task e15_cov_banshees0_main()
        {
            ai_place(e15_cov_banshees01.Squad);
            cs_run_command_script(e15_cov_banshees01.banshee0, new ScriptMethodReference(cs_e15_cov_banshee0_0_entry));
            cs_run_command_script(e15_cov_banshees01.banshee1, new ScriptMethodReference(cs_e15_cov_banshee0_1_entry));
        }

        [ScriptMethod(407, Lifecycle.Dormant)]
        public async Task e15_cov_wraith1_main()
        {
            await sleep(2);
            ai_place(e16_cov_wraiths0_0.wraith1);
            ai_braindead(e16_cov_wraiths0_0.wraith1, true);
            await sleep(2);
            vehicle_load_magic(ai_vehicle_get(e15_cov_phantom0_1.phantom0), "phantom_lc", ai_vehicle_get(e16_cov_wraiths0_0.wraith1));
            await sleep_until(async () => (short)ai_living_count(e16_cov_wraiths0_0.wraith1) <= 0 || !(unit_in_vehicle(ai_vehicle_get(e16_cov_wraiths0_0.wraith1))));
            vehicle_unload(ai_vehicle_get(e15_cov_phantom0_1.phantom0), "phantom_lc");
            ai_braindead(e16_cov_wraiths0_0.wraith1, false);
        }

        [ScriptMethod(408, Lifecycle.Dormant)]
        public async Task e15_cov_wraith0_main()
        {
            await sleep(2);
            ai_place(e16_cov_wraiths0_0.wraith0);
            ai_braindead(e16_cov_wraiths0_0.wraith0, true);
            await sleep(2);
            vehicle_load_magic(ai_vehicle_get(e15_cov_phantom0_0.phantom0), "phantom_lc", ai_vehicle_get(e16_cov_wraiths0_0.wraith0));
            await sleep_until(async () => (short)ai_living_count(e16_cov_wraiths0_0.wraith0) <= 0 || !(unit_in_vehicle(ai_vehicle_get(e16_cov_wraiths0_0.wraith0))));
            vehicle_unload(ai_vehicle_get(e15_cov_phantom0_0.phantom0), "phantom_lc");
            ai_braindead(e16_cov_wraiths0_0.wraith0, false);
        }

        [ScriptMethod(409, Lifecycle.Dormant)]
        public async Task e15_cov_phantom1_main()
        {
            ai_place(e15_cov_phantom1.Squad);
            await sleep_until(async () => objects_distance_to_object(players(), ai_vehicle_get(e15_cov_phantom1.phantom0)) <= 20F, 5, this._30_seconds);
            wake(new ScriptMethodReference(music_03b_01_start));
            await sleep(10);
            game_save_no_timeout();
        }

        [ScriptMethod(410, Lifecycle.Dormant)]
        public async Task e15_cov_phantom0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e15_cov_phantoms0_begin, players()), 15);
            ai_place(e15_cov_phantom0_0.Squad);
            await sleep_until(async () => this.g_e16_started || object_get_health(ai_vehicle_get(e15_cov_phantom0_0.phantom0)) <= 0.05F || object_model_targets_destroyed(ai_vehicle_get(e15_cov_phantom0_0.phantom0), "target_front") >= 2, 30, this.one_minute);
            cs_queue_command_script(e15_cov_phantom0_0.phantom0, new ScriptMethodReference(cs_e15_cov_phantom0_0_exit));
            ai_place(e15_cov_phantom0_1.Squad);
            wake(new ScriptMethodReference(e15_cov_wraith1_main));
            await sleep_until(async () => this.g_e16_started || object_get_health(ai_vehicle_get(e15_cov_phantom0_1.phantom0)) <= 0.05F || object_model_targets_destroyed(ai_vehicle_get(e15_cov_phantom0_1.phantom0), "target_front") >= 2 || (short)ai_living_count(e16_cov_wraiths0_0.wraith1) <= 0, 30, this.one_minute);
            cs_queue_command_script(e15_cov_phantom0_1.phantom0, new ScriptMethodReference(cs_e15_cov_phantom0_1_exit));
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task e15_cov_inf2_main()
        {
            ai_place(e15_cov_inf2_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e15_cov_inf1_spring, players()), 15);
            ai_place(e15_cov_inf2_1.Squad, (short)(10 - (float)ai_living_count(e15_cov)));
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task e15_cov_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e15_cov_inf1_spring, players()), 15);
            ai_place(e15_cov_inf1.Squad);
            await sleep(5);
            object_set_velocity(ai_get_object(e15_cov_inf1.bugger0), 2F, 0F, 5F);
            object_set_velocity(ai_get_object(e15_cov_inf1.bugger1), 2F, 0F, 5F);
            object_set_velocity(ai_get_object(e15_cov_inf1.bugger2), 3F, 0F, 6F);
            object_set_velocity(ai_get_object(e15_cov_inf1.bugger3), 2F, 0F, 5F);
            object_set_velocity(ai_get_object(e15_cov_inf1.bugger4), 3F, 0F, 6F);
            object_set_velocity(ai_get_object(e15_cov_inf1.bugger5), 2F, 0F, 5F);
        }

        [ScriptMethod(413, Lifecycle.Dormant)]
        public async Task e15_cov_inf0_main()
        {
            ai_place(e15_cov_inf0.Squad);
        }

        [ScriptMethod(414, Lifecycle.Dormant)]
        public async Task e15_mars_inf0_main()
        {
            ai_migrate(e14_mars_inf0.Squad, e15_mars_inf0.Squad);
            ai_place(e15_mars_inf0.Squad, (short)pin(3F - (float)ai_living_count(e15_mars_inf0.Squad), 1F, 2F));
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task e15_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e15_main_begin, players()), 15);
            this.g_e15_started = true;
            print("e15_main");
            data_mine_set_mission_segment("e15_bridge_summit");
            game_save();
            wake(new ScriptMethodReference(e15_mars_inf0_main));
            wake(new ScriptMethodReference(e15_cov_phantom0_main));
            wake(new ScriptMethodReference(e15_cov_phantom1_main));
            wake(new ScriptMethodReference(e15_cov_banshees0_main));
            await sleep_until(async () => this.g_e17_started);
            sleep_forever(new ScriptMethodReference(e15_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e15_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e15_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e15_cov_inf2_main));
            sleep_forever(new ScriptMethodReference(e15_cov_phantom0_main));
            sleep_forever(new ScriptMethodReference(e15_cov_banshees0_main));
            ai_disposable(e15_cov, true);
            ai_disposable(e15_cov_phantom0, false);
        }

        [ScriptMethod(416, Lifecycle.Static)]
        public async Task test_bridge_summit()
        {
            object_teleport(await this.player0(), e15_test);
            ai_place(e15_mars_inf0.Squad);
            if (!(this.g_e15_started))
            {
                wake(new ScriptMethodReference(e15_main));
            }

            if (!(this.g_e16_started))
            {
                wake(new ScriptMethodReference(e16_main));
            }

            if (!(this.g_e17_started))
            {
                wake(new ScriptMethodReference(e17_main));
            }

            if (!(this.g_e18_started))
            {
                wake(new ScriptMethodReference(e18_main));
            }
        }

        [ScriptMethod(417, Lifecycle.CommandScript)]
        public async Task cs_e14_cov_wraiths0_bombard()
        {
            cs_enable_moving(true);
            await sleep_until(async () =>
            {
                if (unit_in_vehicle(unit(await this.player1())))
                {
                    cs_shoot(true, await this.player1());
                }

                if (unit_in_vehicle(unit(await this.player0())))
                {
                    cs_shoot(true, await this.player0());
                }

                await sleep_until(async () => volume_test_objects(tv_e14_blockade4, players()), 15, 150);
                cs_shoot(false, await this.player0());
                cs_shoot(false, await this.player1());
                await sleep_until(async () => volume_test_objects(tv_e14_blockade4, players()), 15, 300);
                return volume_test_objects(tv_e14_blockade4, players());
            });
        }

        [ScriptMethod(418, Lifecycle.CommandScript)]
        public async Task cs_e14_mars_pelican0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.25F);
            await sleep_until(async () => volume_test_objects(tv_e14_mars_inf0_advance, players()) || await this.player_in_vehicle(), 15);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("e14_mars_pelican0/p8"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e14_mars_pelican0/p6"), GetReference<ISpatialPoint>("e14_mars_pelican0/p7"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e14_mars_pelican0/p6"));
            cs_fly_by(GetReference<ISpatialPoint>("e14_mars_pelican0/p7"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(419, Lifecycle.CommandScript)]
        public async Task cs_e14_cov_ghosts0_advance0()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_enable_targeting(true);
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p0"));
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p1"));
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p3"));
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p4"));
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p5"));
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p6"));
        }

        [ScriptMethod(420, Lifecycle.CommandScript)]
        public async Task cs_e14_cov_ghosts0_advance1()
        {
            cs_abort_on_damage(true);
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_enable_targeting(true);
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p3"));
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p4"));
            cs_go_to(GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p5"));
        }

        [ScriptMethod(421, Lifecycle.Dormant)]
        public async Task e14_cov_snipers0_main()
        {
            await sleep(1);
        }

        [ScriptMethod(422, Lifecycle.Dormant)]
        public async Task e14_cov_wraiths0_main()
        {
            ai_place(e14_cov_wraiths0.wraith0);
            await sleep_until(async () => volume_test_objects(tv_e14_blockade0, players()), 15);
            cs_run_command_script(e14_cov_wraiths0.Squad, new ScriptMethodReference(cs_e14_cov_wraiths0_bombard));
        }

        [ScriptMethod(423, Lifecycle.Dormant)]
        public async Task e14_cov_ghosts1_main()
        {
            await sleep(1);
        }

        [ScriptMethod(424, Lifecycle.Dormant)]
        public async Task e14_cov_ghosts0_main()
        {
            ai_place(e14_cov_ghosts0_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e14_blockade0, players()), 15);
            ai_place(e14_cov_ghosts0_1.Squad, (short)pin(4F - (float)ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await sleep_until(async () => volume_test_objects(tv_e14_blockade1, players()), 15);
            ai_place(e14_cov_ghosts0_1.Squad, (short)pin(4F - (float)ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await sleep_until(async () => volume_test_objects(tv_e14_blockade2, players()), 15);
            ai_place(e14_cov_ghosts0_1.Squad, (short)pin(4F - (float)ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await sleep_until(async () => volume_test_objects(tv_e14_blockade3, players()), 15);
            ai_place(e14_cov_ghosts0_1.Squad, (short)pin(4F - (float)ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await sleep_until(async () => volume_test_objects(tv_e14_blockade4, players()), 15);
            ai_place(e14_cov_ghosts0_1.Squad, (short)pin(4F - (float)ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await sleep_until(async () => volume_test_objects(tv_e14_blockade5, players()), 15);
            ai_place(e14_cov_ghosts0_1.Squad, (short)pin(4F - (float)ai_living_count(e14_cov_ghosts0), 0F, 2F));
        }

        [ScriptMethod(425, Lifecycle.Dormant)]
        public async Task e14_mars_pelican0_main()
        {
            ai_place(e14_mars_pelican0.Squad);
            object_cannot_take_damage(ai_actors(e14_mars_pelican0.Squad));
            ai_vehicle_enter_immediate(e14_mars_pelican0.gunner0, ai_vehicle_get(e14_mars_pelican0.pelican0), "pelican_g");
            ai_vehicle_enter_immediate(e14_mars_pelican0.johnson0, ai_vehicle_get(e14_mars_pelican0.pelican0), "pelican_g_rear");
        }

        [ScriptMethod(426, Lifecycle.Dormant)]
        public async Task e14_mars_inf0_main()
        {
            ai_place(e14_mars_inf0.Squad);
            ai_vehicle_reserve_seat(ai_vehicle_get_from_starting_location(e14_mars_inf0.scorpion0), "scorpion_d", true);
            if ((bool)game_is_cooperative())
            {
                ai_place(e14_mars_inf0.warthog0);
                ai_vehicle_reserve_seat(ai_vehicle_get_from_starting_location(e14_mars_inf0.warthog0), "warthog_d", true);
            }
            else
            {
                ai_place(e14_mars_inf0.warthog1);
                ai_vehicle_reserve_seat(ai_vehicle_get_from_starting_location(e14_mars_inf0.warthog1), "warthog_d", true);
            }
        }

        [ScriptMethod(427, Lifecycle.Dormant)]
        public async Task e14_main()
        {
            this.g_e14_started = true;
            print("e14_main");
            data_mine_set_mission_segment("e14_bridge_ascent");
            game_save();
            kill_volume_enable(kill_e14_0);
            wake(new ScriptMethodReference(objective0_set));
            wake(new ScriptMethodReference(e15_main));
            wake(new ScriptMethodReference(e16_main));
            wake(new ScriptMethodReference(e17_main));
            wake(new ScriptMethodReference(e18_main));
            wake(new ScriptMethodReference(e14_mars_inf0_main));
            wake(new ScriptMethodReference(e14_mars_pelican0_main));
            wake(new ScriptMethodReference(e14_cov_ghosts0_main));
            wake(new ScriptMethodReference(e14_cov_ghosts1_main));
            wake(new ScriptMethodReference(e14_cov_wraiths0_main));
            wake(new ScriptMethodReference(e14_cov_snipers0_main));
            await sleep_until(async () => this.g_e15_started);
            sleep_forever(new ScriptMethodReference(e14_mars_inf0_main));
            sleep_forever(new ScriptMethodReference(e14_cov_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e14_cov_ghosts1_main));
            sleep_forever(new ScriptMethodReference(e14_cov_wraiths0_main));
            sleep_forever(new ScriptMethodReference(e14_cov_snipers0_main));
            ai_disposable(e14_cov, true);
        }

        [ScriptMethod(428, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            wake(new ScriptMethodReference(flashlight_control));
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
            wake(new ScriptMethodReference(e14_main));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(chapter_title0));
            await sleep_until(async () => this.g_mission_over, 8);
            wake(new ScriptMethodReference(music_03b_04_stop));
            await sleep(60);
            await this.playtest_mission();
            await sleep(15);
            await this.cinematic_fade_to_white();
            object_cannot_take_damage(players());
            object_hide(await this.player0(), true);
            object_hide(await this.player1(), true);
            object_teleport(await this.player0(), player0_end);
            object_teleport(await this.player1(), player1_end);
            object_destroy(scarab.Entity);
            ai_erase(e23_cov);
            ai_erase(e23_mars);
            await this.cinematic_outro();
            game_won();
        }

        [ScriptMethod(429, Lifecycle.Static)]
        public async Task start()
        {
            wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(430, Lifecycle.Startup)]
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

        [ScriptMethod(431, Lifecycle.Dormant)]
        public async Task _03_intra1_01_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_barrier\\toll_barrier", 3838509909U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 3);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 47, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 16, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3838575446U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_road_signal\\sign_road_signal", 3839427427U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3842048907U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 19);
            await sleep(15);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 13);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            await sleep(74);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 49, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 87);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 99);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 89);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 90);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 91);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 92);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 93);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 94);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 95);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 96);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 97);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_cone\\road_cone", 3848209385U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\crush_barrel\\crush_barrel\\crush_barrel", 3848602607U), 0);
            await sleep(31);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 25);
            await sleep(33);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            await sleep(17);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\multi\\zanzibar\\dumpster\\dumpster", 3849257977U), 0);
            await sleep(83);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 48, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 16);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 17);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 18);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 20);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 21);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 22);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 24);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 25);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 26);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 27);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 28);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 29);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 30);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 31);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3838575446U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3850830865U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_rear_gun\\scarab_rear_gun", 3851158550U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3851486235U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_mid_garb\\bridge_light_mid_garb", 3852010531U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_brace_garb\\bridge_light_brace_garb", 3852272679U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech\\crate_tech", 3852338216U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853583419U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_lit_garb\\bridge_light_lit_garb", 3854828622U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_street_arch\\sign_street_arch", 3854959696U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech_giant\\crate_tech_giant", 3855156307U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\tire\\tire", 3855221844U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis_tire\\uberchassis_tire", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\pallet\\pallet", 3855549529U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 3855811677U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing\\crate_packing", 3856008288U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\drum_55gal\\drum_55gal", 3856204899U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 38, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\weapons\\smg\\smg", 3856401510U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 1);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 19, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 25, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 38, false);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 1);
            await sleep(85);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech\\crate_tech", 3852338216U), 0);
            await sleep(49);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 87);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 99);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 89);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 90);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 91);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 92);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 93);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 94);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 95);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 96);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 97);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 1);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 45, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853583419U), 0);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 0);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 2, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, true);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 1);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 1);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 23, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 48, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_mid_garb\\bridge_light_mid_garb", 3852010531U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\pallet\\pallet", 3855549529U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 3855811677U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing\\crate_packing", 3856008288U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\tire\\tire", 3855221844U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\drum_55gal\\drum_55gal", 3856204899U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\weapons\\smg\\smg", 3856401510U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_street_arch\\sign_street_arch", 3854959696U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_lit_garb\\bridge_light_lit_garb", 3854828622U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech_giant\\crate_tech_giant", 3855156307U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_brace_garb\\bridge_light_brace_garb", 3852272679U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\multi\\zanzibar\\dumpster\\dumpster", 3849257977U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, true);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 1);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech\\crate_tech", 3852338216U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis_tire\\uberchassis_tire", 3855483992U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 34, false);
            await sleep(30);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_road_signal\\sign_road_signal", 3839427427U), 1);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 2);
            await sleep(58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 25);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_h\\concrete_chunk_h", 3856729195U), 0);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
        }

        [ScriptMethod(432, Lifecycle.Dormant)]
        public async Task _03_intra1_02a_predict()
        {
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 49, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\crush_barrel\\crush_barrel\\crush_barrel", 3848602607U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_j\\concrete_chunk_j", 3856794732U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_barrier\\toll_barrier", 3838509909U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await sleep(75);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            await sleep(32);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 48, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_mid_garb\\bridge_light_mid_garb", 3852010531U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_brace_garb\\bridge_light_brace_garb", 3852272679U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech\\crate_tech", 3852338216U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853583419U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_lit_garb\\bridge_light_lit_garb", 3854828622U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_street_arch\\sign_street_arch", 3854959696U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech_giant\\crate_tech_giant", 3855156307U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\tire\\tire", 3855221844U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis_tire\\uberchassis_tire", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\pallet\\pallet", 3855549529U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 3855811677U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing\\crate_packing", 3856008288U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\drum_55gal\\drum_55gal", 3856204899U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\weapons\\smg\\smg", 3856401510U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 1);
            await sleep(26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 56);
            await sleep(60);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 49, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_road_signal\\sign_road_signal", 3839427427U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_h\\concrete_chunk_h", 3856729195U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_barrier\\toll_barrier", 3838509909U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\multi\\zanzibar\\dumpster\\dumpster", 3849257977U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
        }

        [ScriptMethod(433, Lifecycle.Dormant)]
        public async Task _03_intra1_02b_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(434, Lifecycle.Dormant)]
        public async Task _03_intra1_02c_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_cone\\road_cone", 3848209385U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\crush_barrel\\crush_barrel\\crush_barrel", 3848602607U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_h\\concrete_chunk_h", 3856729195U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_j\\concrete_chunk_j", 3856794732U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await sleep(157);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 49, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_h\\concrete_chunk_h", 3856729195U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\multi\\zanzibar\\dumpster\\dumpster", 3849257977U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await sleep(35);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_good\\cigar_good", 3856991343U), 0);
        }

        [ScriptMethod(435, Lifecycle.Dormant)]
        public async Task _03_intra1_03_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 1);
            await sleep(11);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_trashcan\\streetobj_trashcan", 3857319028U), 0);
        }

        [ScriptMethod(436, Lifecycle.Dormant)]
        public async Task x03_01_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 66, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 76, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 68, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 97, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 156, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 157, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 154, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 160, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 155, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 153, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 164, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 130, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 161, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 158, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 132, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 165, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 131, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 103, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 113, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 159, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 133, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 134, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 166, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 101, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 111, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 135, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 136, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 167, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 112, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 119, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 114, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 118, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 152, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 77, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 81, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 80, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 96, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 97, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 16);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 17);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 18);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 20);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 21);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 22);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 24);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 25);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 26);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 27);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 28);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 29);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 30);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 31);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3838575446U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3850830865U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_rear_gun\\scarab_rear_gun", 3851158550U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3851486235U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3857581176U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\powerups\\rocket_launcher_ammo\\rocket_launcher_ammo", 3857908861U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\vent_wall_a\\vent_wall_a", 3858302083U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\case_ap_turret\\case_ap_turret", 3858564231U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\case\\case", 3858760842U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3858957453U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\fixed\\h_turret_mp\\h_turret_mp", 3860006045U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\powerups\\shotgun_ammo\\shotgun_ammo", 3860268193U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\powerups\\battle_rifle_ammo\\battle_rifle_ammo", 3807969667U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3860595878U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\nm_control_box\\nm_control_box", 3861710007U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 95, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 6);
            await sleep(63);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 95, true);
            await sleep(15);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 13, true);
            await sleep(26);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 95, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 27, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 97, true);
            await sleep(36);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 47, true);
            await sleep(35);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 157, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 103, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 160, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 130, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 102, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 164, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 132, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 36, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 2);
            await sleep(109);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 154, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 47, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 153, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 51, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 158, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 35, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3860595878U), 2);
            await sleep(140);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 161, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 157, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 165, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 131, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 103, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 113, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 159, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 160, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 133, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 164, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 130, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 102, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 166, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 101, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 134, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 111, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 132, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 136, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 135, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 167, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 112, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 114, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 118, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 152, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 81, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 33, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\human\\military\\case\\case", 3858760842U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\nm_control_box\\nm_control_box", 3861710007U), 0);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 1);
        }

        [ScriptMethod(437, Lifecycle.Dormant)]
        public async Task x03_02_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 4);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 57, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 62, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3842048907U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 1);
            await sleep(50);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 76, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
            await sleep(43);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            await sleep(104);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3868198170U), 0);
        }

        [ScriptMethod(438, Lifecycle.Dormant)]
        public async Task x03_03_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3860595878U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3842048907U), 0);
            await sleep(24);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 57, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 62, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            await sleep(28);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            await sleep(67);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 76, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
        }

        [ScriptMethod(439, Lifecycle.Dormant)]
        public async Task x03_04_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            await sleep(2);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 1);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            await sleep(11);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            await sleep(110);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 2);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3868198170U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
        }

        [ScriptMethod(440, Lifecycle.Dormant)]
        public async Task x03_05_predict()
        {
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3860595878U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3868198170U), 0);
            await sleep(22);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            await sleep(85);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            await sleep(90);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
        }

        [ScriptMethod(441, Lifecycle.Dormant)]
        public async Task x03_06_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 2);
            await sleep(2);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            await sleep(40);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 76, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
            await sleep(28);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
        }

        [ScriptMethod(442, Lifecycle.Dormant)]
        public async Task x03_07_predict()
        {
            await sleep(50);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3869508910U), 0);
            await sleep(21);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853583419U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3869508910U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\slipspace_shockwave_start\\slipspace_shockwave_start", 3869574447U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3870164280U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3870360891U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_big_generator\\streetobj_big_generator", 3870557502U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_dumpster\\streetobj_dumpster", 3871147335U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 2);
        }

        [ScriptMethod(443, Lifecycle.Dormant)]
        public async Task x03_08_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\slipspace_shockwave_closeup\\slipspace_shockwave_closeup", 3872261464U), 0);
            await sleep(72);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 2);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 1);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3869508910U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\slipspace_shockwave\\slipspace_shockwave", 3872458075U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 62, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 57, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 4);
        }
    }
}