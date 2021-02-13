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
        public async Task _03_intra1_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intra1_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _03_intra1_02a_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intra1_02a_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _03_intra1_02b_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intra1_02b_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _03_intra1_02c_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intra1_02c_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task _03_intra1_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_03_intra1_03_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x03_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x03_01_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x03_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x03_02_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x03_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x03_03_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x03_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x03_04_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x03_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x03_05_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task x03_06_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x03_06_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task x03_07_predict_stub()
        {
            Engine.print("!!!07 predict");
            Engine.wake(new ScriptMethodReference(x03_07_predict));
        }

        [ScriptMethod(36, Lifecycle.Static)]
        public async Task x03_08_predict_stub()
        {
            Engine.print("!!!08 predict");
            Engine.wake(new ScriptMethodReference(x03_08_predict));
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c03_intra1_sound_scene1_01()
        {
            Engine.sound_class_set_gain("vehicle_engine", 0F, 0);
            await Engine.sleep(390);
            Engine.sound_class_set_gain("vehicle_engine", 0.5F, 60);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c03_intra1_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\music\\c03_intra1_01_mus", 3819110957U), default(IGameObject), 1F);
            Engine.print("c03_intro score 01 start");
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task c03_intra1_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_01_fol", 3819176494U), default(IGameObject), 1F);
            Engine.print("c03_intro foley 01 start");
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c03_2010_mr3()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2010_mr3", 3819242031U), marine_01.Entity, 1F);
            Engine.cinematic_subtitle("c03_2010_mr3", 4F);
            Engine.unit_set_emotional_state(marine_01.Entity, "scared", 1F, 0);
            Engine.print("marine_01 - scared 1 0");
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c03_2020_mr4()
        {
            Engine.unit_set_emotional_state(marine_02.Entity, "shocked", 0.25F, 0);
            Engine.print("marine_02 - shocked .25 0");
            await Engine.sleep(200);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2020_mr4", 3819307568U), marine_02.Entity, 1F);
            Engine.cinematic_subtitle("c03_2020_mr4", 2F);
            await Engine.sleep(15);
            Engine.unit_set_emotional_state(marine_02.Entity, "angry", 0.5F, 30);
            Engine.print("marine_02 - angry .5 30");
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c03_2030_mr4()
        {
            await Engine.sleep(278);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2030_mr4", 3819373105U), marine_02.Entity, 1F);
            Engine.cinematic_subtitle("c03_2030_mr4", 3F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c03_intra1_fov_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(263);
            Engine.camera_set_field_of_view(14F, 0);
            await Engine.sleep(1);
            Engine.camera_set_field_of_view(10F, 144);
            Engine.time_code_reset();
            await Engine.sleep(144);
            Engine.camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task drop_tank()
        {
            await Engine.sleep(598);
            Engine.objects_detach(pelican_01a.Entity, scorpion_01.Entity);
            Engine.print("special delivery");
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task destroy_scarab()
        {
            await Engine.sleep(410);
            Engine.object_destroy(scarab_01.Entity);
            Engine.print("destroy scarab");
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task c03_intra1_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(27F, 228F, 0.360784F, 0.317647F, 0.203922F);
            Engine.cinematic_lighting_set_secondary_light(-35F, 100F, 0.0901961F, 0.109804F, 0.14902F);
            Engine.cinematic_lighting_set_ambient_light(0.101961F, 0.101961F, 0.0666667F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_01.Entity, true);
            Engine.object_uses_cinematic_lighting(marine_02.Entity, true);
            Engine.object_uses_cinematic_lighting(rifle_01.Entity, true);
            Engine.object_uses_cinematic_lighting(rifle_02.Entity, true);
            Engine.object_uses_cinematic_lighting(rifle_03.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_01a.Entity, true);
            Engine.object_uses_cinematic_lighting(scarab_02.Entity, true);
            Engine.object_uses_cinematic_lighting(scorpion_01.Entity, true);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task c03_intra1_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(marine_01);
            Engine.object_create_anew(marine_02);
            Engine.object_create_anew(rifle_02);
            Engine.object_create_anew(rifle_03);
            Engine.object_cinematic_lod(marine_01.Entity, true);
            Engine.object_cinematic_lod(marine_02.Entity, true);
            Engine.objects_attach(marine_01.Entity, "right hand", rifle_02.Entity, "");
            Engine.objects_attach(marine_02.Entity, "right hand", rifle_03.Entity, "");
            Engine.object_set_permutation(marine_02.Entity, "head", "michelle");
        }

        [ScriptMethod(48, Lifecycle.Static)]
        public async Task c03_intra1_01_setup()
        {
            Engine.object_create_anew(chief);
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(pelican_01a);
            Engine.object_create_anew(scorpion_01);
            Engine.object_create_anew(scarab_01);
            Engine.object_create_anew(rifle_01);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(pelican_01a.Entity, true);
            Engine.object_cinematic_lod(scorpion_01.Entity, true);
            Engine.object_cinematic_lod(scarab_01.Entity, true);
            Engine.objects_attach(chief.Entity, "right hand", rifle_01.Entity, "");
            Engine.objects_attach(pelican_01a.Entity, "pelican_sc_01", scorpion_01.Entity, "scorpion_b_t");
            Engine.object_set_function_variable(pelican_01a.Entity, "hover", 1F, 0F);
            Engine.wake(new ScriptMethodReference(c03_intra1_sound_scene1_01));
            Engine.wake(new ScriptMethodReference(c03_intra1_score_01));
            Engine.wake(new ScriptMethodReference(c03_intra1_foley_01));
            Engine.wake(new ScriptMethodReference(c03_2010_mr3));
            Engine.wake(new ScriptMethodReference(c03_2020_mr4));
            Engine.wake(new ScriptMethodReference(c03_2030_mr4));
            Engine.wake(new ScriptMethodReference(c03_intra1_fov_01));
            Engine.wake(new ScriptMethodReference(c03_intra1_cinematic_light_01));
            Engine.wake(new ScriptMethodReference(drop_tank));
            Engine.wake(new ScriptMethodReference(destroy_scarab));
        }

        [ScriptMethod(49, Lifecycle.Static)]
        public async Task c03_intra1_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._03_intra1_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\music\\c03_intra1_01_mus", 3819110957U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_01_fol", 3819176494U));
            Engine.wake(new ScriptMethodReference(c03_intra1_problem_actors));
            await Engine.sleep(this.prediction_offset);
            await this.c03_intra1_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_01", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(pelican_01a.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intra1\\03_intra1", 3819700790U), "pelican_01", false, anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(scarab_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\03_intra1\\03_intra1", 3819766327U), "scarab_01", anchor_intra1.Entity);
            await Engine.sleep(45);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._03_intra1_02a_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_02a_fol", 3819831864U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task c03_intra1_foley_02a()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_02a_fol", 3819831864U), default(IGameObject), 1F);
            Engine.print("c03_intro foley 02a start");
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task c03_2040_jon()
        {
            await Engine.sleep(115);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2040_jon", 3819897401U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2040_jon", 1F);
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task c03_2050_mr4()
        {
            await Engine.sleep(161);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2050_mr4", 3819962938U), marine_02.Entity, 1F);
            Engine.cinematic_subtitle("c03_2050_mr4", 1F);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c03_2060_mr3()
        {
            await Engine.sleep(200);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2060_mr3", 3820028475U), marine_01.Entity, 1F);
            Engine.cinematic_subtitle("c03_2060_mr3", 3F);
            Engine.unit_set_emotional_state(marine_01.Entity, "scared", 0.5F, 30);
            Engine.print("marine_01 - angry .5 30");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c03_2070_jon()
        {
            await Engine.sleep(288);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2070_jon", 3820094012U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2070_jon", 1F);
            Engine.unit_set_emotional_state(johnson.Entity, "angry", 0.5F, 30);
            Engine.print("johnson - angry .5 30");
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task c03_2080_mr3()
        {
            await Engine.sleep(328);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2080_mr3", 3820159549U), marine_01.Entity, 1F);
            Engine.cinematic_subtitle("c03_2080_mr3", 1F);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task c03_2090_jon()
        {
            await Engine.sleep(370);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2090_jon", 3820225086U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2090_jon", 1F);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task swap_tanks()
        {
            await Engine.sleep(200);
            Engine.object_destroy(scorpion_01.Entity);
            Engine.object_create_anew(scorpion_02);
            Engine.object_cinematic_lod(scorpion_02.Entity, true);
            Engine.object_uses_cinematic_lighting(scorpion_02.Entity, true);
            Engine.print("swap tanks");
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task c03_intra1_02a_setup()
        {
            Engine.wake(new ScriptMethodReference(c03_2040_jon));
            Engine.wake(new ScriptMethodReference(c03_2050_mr4));
            Engine.wake(new ScriptMethodReference(c03_2060_mr3));
            Engine.wake(new ScriptMethodReference(c03_2070_jon));
            Engine.wake(new ScriptMethodReference(c03_2080_mr3));
            Engine.wake(new ScriptMethodReference(c03_2090_jon));
            Engine.wake(new ScriptMethodReference(c03_intra1_foley_02a));
            Engine.wake(new ScriptMethodReference(swap_tanks));
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c03_intra1_scene_02a()
        {
            await this.c03_intra1_02a_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02a", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative_loop(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02a", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02a", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02a", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02a", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(pelican_01a.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intra1\\03_intra1", 3819700790U), "pelican_02a", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(scorpion_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\scorpion\\03_intra1\\03_intra1", 3820290623U), "scorpion_02a", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._03_intra1_02b_predict_stub();
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(pelican_01a.Entity);
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c03_intra1_speech_easy()
        {
            Engine.custom_animation_relative_loop(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02b_easy", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02b", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02b", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02b", false, anchor_intra1.Entity);
            await Engine.sleep(5);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2097_jon", 3820356160U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c03_2097_jon", 8F);
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task c03_intra1_speech_normal()
        {
            Engine.custom_animation_relative_loop(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02b_easy", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02b", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02b", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02b", false, anchor_intra1.Entity);
            await Engine.sleep(5);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2091_jon", 3820421697U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c03_2091_jon", 8F);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task c03_intra1_speech_heroic()
        {
            Engine.custom_animation_relative_loop(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02b_easy", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02b", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02b", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02b", false, anchor_intra1.Entity);
            await Engine.sleep(5);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2093_jon", 3820487234U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c03_2093_jon", 8F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task c03_intra1_speech_legendary()
        {
            Engine.custom_animation_relative_loop(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02b_easy", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02b", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02b", false, anchor_intra1.Entity);
            Engine.custom_animation_relative_loop(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02b", false, anchor_intra1.Entity);
            await Engine.sleep(5);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2095_jon", 3820552771U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c03_2095_jon", 8F);
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task c03_intra1_scene_02b()
        {
            if (GameDifficulty.Easy() == Engine.game_difficulty_get_real())
            {
                Engine.print("easy speech");
                Engine.wake(new ScriptMethodReference(c03_intra1_speech_easy));
                Engine.camera_set(c03_intra1_01, 0);
                Engine.camera_set(c03_intra1_02, 261);
                await Engine.sleep(261);
                await Engine.sleep(15);
            }

            if (GameDifficulty.Normal() == Engine.game_difficulty_get_real())
            {
                Engine.print("normal speech");
                Engine.wake(new ScriptMethodReference(c03_intra1_speech_normal));
                Engine.camera_set(c03_intra1_01, 0);
                Engine.camera_set(c03_intra1_02, 246);
                await Engine.sleep(246);
                await Engine.sleep(15);
            }

            if (GameDifficulty.Heroic() == Engine.game_difficulty_get_real())
            {
                Engine.print("heroic speech");
                Engine.wake(new ScriptMethodReference(c03_intra1_speech_heroic));
                Engine.camera_set(c03_intra1_01, 0);
                Engine.camera_set(c03_intra1_02, 290);
                await Engine.sleep(290);
                await Engine.sleep(15);
            }

            if (GameDifficulty.Legendary() == Engine.game_difficulty_get_real())
            {
                Engine.print("legendary speech");
                Engine.wake(new ScriptMethodReference(c03_intra1_speech_legendary));
                Engine.camera_set(c03_intra1_01, 0);
                Engine.camera_set(c03_intra1_02, 320);
                await Engine.sleep(320);
                await Engine.sleep(15);
            }

            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._03_intra1_02c_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_02c_fol", 3820618308U));
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task c03_intra1_foley_02c()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_02c_fol", 3820618308U), default(IGameObject), 1F);
            Engine.print("c03_intra1 foley 02c start");
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task c03_2092_jon()
        {
            await Engine.sleep(4);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2092_jon", 3820683845U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2092_jon", 2F);
            await Engine.sleep(65);
            Engine.unit_set_emotional_state(marine_01.Entity, "shocked", 0.5F, 30);
            Engine.print("marine_01 - shocked .5 30");
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task c03_2094_jon()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2094_jon", 3820749382U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2094_jon", 2F);
            await Engine.sleep(65);
            Engine.unit_set_emotional_state(marine_01.Entity, "shocked", 0.5F, 30);
            Engine.print("marine_01 - shocked .5 30");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c03_2096_jon()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2096_jon", 3820814919U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2096_jon", 2F);
            await Engine.sleep(65);
            Engine.unit_set_emotional_state(marine_01.Entity, "shocked", 0.5F, 30);
            Engine.print("marine_01 - shocked .5 30");
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c03_2098_jon()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2098_jon", 3820880456U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2098_jon", 2F);
            await Engine.sleep(65);
            Engine.unit_set_emotional_state(marine_01.Entity, "shocked", 0.5F, 30);
            Engine.print("marine_01 - shocked .5 30");
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c03_2100_mr4()
        {
            await Engine.sleep(81);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2100_mr4", 3820945993U), marine_02.Entity, 1F);
            Engine.cinematic_subtitle("c03_2100_mr4", 1F);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task c03_2100_mr4_hard()
        {
            await Engine.sleep(86);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2100_mr4", 3820945993U), marine_02.Entity, 1F);
            Engine.cinematic_subtitle("c03_2100_mr4", 1F);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task c03_2100_mr4_leg()
        {
            await Engine.sleep(102);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2100_mr4", 3820945993U), marine_02.Entity, 1F);
            Engine.cinematic_subtitle("c03_2100_mr4", 1F);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task c03_2110_jon()
        {
            await Engine.sleep(119);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2110_jon", 3821011530U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2110_jon", 3F);
            await Engine.sleep(90);
            Engine.unit_set_emotional_state(marine_01.Entity, "repulsed", 0.25F, 60);
            Engine.print("marine_01 - repulsed .25 60");
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c03_2110_jon_leg()
        {
            await Engine.sleep(133);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2110_jon", 3821011530U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2110_jon", 3F);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task c03_2120_jon()
        {
            await Engine.sleep(235);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2120_jon", 3821077067U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2120_jon", 3F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task c03_2120_jon_leg()
        {
            await Engine.sleep(249);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2120_jon", 3821077067U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2120_jon", 2F);
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task c03_2130_mr4()
        {
            await Engine.sleep(301);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2130_mr4", 3821142604U), marine_02.Entity, 1F);
            Engine.cinematic_subtitle("c03_2130_mr4", 1F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c03_2130_mr4_leg()
        {
            await Engine.sleep(315);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2130_mr4", 3821142604U), marine_02.Entity, 1F);
            Engine.cinematic_subtitle("c03_2130_mr4", 1F);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task c03_2140_cor()
        {
            await Engine.sleep(352);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2140_cor", 3821208141U), default(IGameObject), 1F, "radio_default_in");
            Engine.cinematic_subtitle("c03_2140_cor", 3F);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task c03_2140_cor_leg()
        {
            await Engine.sleep(366);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2140_cor", 3821208141U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c03_2140_cor", 3F);
        }

        [ScriptMethod(81, Lifecycle.Static)]
        public async Task c03_intra1_scene_02c()
        {
            Engine.unit_set_emotional_state(johnson.Entity, "angry", 0.5F, 0);
            Engine.print("johnson - angry .5 0");
            Engine.unit_set_emotional_state(marine_01.Entity, "scared", 0.5F, 0);
            Engine.print("marine_01 - scared .5 0");
            if (GameDifficulty.Easy() == Engine.game_difficulty_get_real())
            {
                Engine.print("easy speech");
                Engine.object_create_anew(cigar);
                Engine.wake(new ScriptMethodReference(c03_2098_jon));
                Engine.wake(new ScriptMethodReference(c03_2100_mr4));
                Engine.wake(new ScriptMethodReference(c03_2110_jon));
                Engine.wake(new ScriptMethodReference(c03_2120_jon));
                Engine.wake(new ScriptMethodReference(c03_2130_mr4));
                Engine.wake(new ScriptMethodReference(c03_2140_cor));
                Engine.wake(new ScriptMethodReference(c03_intra1_foley_02c));
                Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02ce", default(IUnit), anchor_flag_intra1);
                Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02ce", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02ce", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02ce", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02ce", false, anchor_intra1.Entity);
                Engine.scenery_animation_start_relative(cigar.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_good\\03_intra1\\03_intra1", 3821273678U), "cigar_02e", anchor_intra1.Entity);
            }

            if (GameDifficulty.Normal() == Engine.game_difficulty_get_real())
            {
                Engine.print("normal speech");
                Engine.object_create_anew(cigar);
                Engine.wake(new ScriptMethodReference(c03_2092_jon));
                Engine.wake(new ScriptMethodReference(c03_2100_mr4));
                Engine.wake(new ScriptMethodReference(c03_2110_jon));
                Engine.wake(new ScriptMethodReference(c03_2120_jon));
                Engine.wake(new ScriptMethodReference(c03_2130_mr4));
                Engine.wake(new ScriptMethodReference(c03_2140_cor));
                Engine.wake(new ScriptMethodReference(c03_intra1_foley_02c));
                Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02cn", default(IUnit), anchor_flag_intra1);
                Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02cn", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02cn", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02cn", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02cn", false, anchor_intra1.Entity);
                Engine.scenery_animation_start_relative(cigar.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_good\\03_intra1\\03_intra1", 3821273678U), "cigar_02n", anchor_intra1.Entity);
            }

            if (GameDifficulty.Heroic() == Engine.game_difficulty_get_real())
            {
                Engine.print("heroic speech");
                Engine.object_create_anew(cigar);
                Engine.wake(new ScriptMethodReference(c03_2094_jon));
                Engine.wake(new ScriptMethodReference(c03_2100_mr4_hard));
                Engine.wake(new ScriptMethodReference(c03_2110_jon));
                Engine.wake(new ScriptMethodReference(c03_2120_jon));
                Engine.wake(new ScriptMethodReference(c03_2130_mr4));
                Engine.wake(new ScriptMethodReference(c03_2140_cor));
                Engine.wake(new ScriptMethodReference(c03_intra1_foley_02c));
                Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02ch", default(IUnit), anchor_flag_intra1);
                Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02ch", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02ch", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02ch", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02ch", false, anchor_intra1.Entity);
                Engine.scenery_animation_start_relative(cigar.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_good\\03_intra1\\03_intra1", 3821273678U), "cigar_02h", anchor_intra1.Entity);
            }

            if (GameDifficulty.Legendary() == Engine.game_difficulty_get_real())
            {
                Engine.print("legendary speech");
                Engine.object_create_anew(cigar);
                Engine.wake(new ScriptMethodReference(c03_2096_jon));
                Engine.wake(new ScriptMethodReference(c03_2100_mr4_leg));
                Engine.wake(new ScriptMethodReference(c03_2110_jon_leg));
                Engine.wake(new ScriptMethodReference(c03_2120_jon_leg));
                Engine.wake(new ScriptMethodReference(c03_2130_mr4_leg));
                Engine.wake(new ScriptMethodReference(c03_2140_cor_leg));
                Engine.wake(new ScriptMethodReference(c03_intra1_foley_02c));
                Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_02cl", default(IUnit), anchor_flag_intra1);
                Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\03_intra1\\03_intra1", 3819504179U), "chief_02cl", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_02cl", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(marine_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine01_02cl", false, anchor_intra1.Entity);
                Engine.custom_animation_relative(marine_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "marine02_02cl", false, anchor_intra1.Entity);
                Engine.scenery_animation_start_relative(cigar.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_good\\03_intra1\\03_intra1", 3821273678U), "cigar_02l", anchor_intra1.Entity);
            }

            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.object_destroy(pelican_01a.Entity);
            Engine.object_destroy(cigar.Entity);
            Engine.print("problem actors");
            Engine.object_create_anew(pelican_01b);
            Engine.object_create_anew(rear_gun);
            Engine.object_cinematic_lod(pelican_01b.Entity, true);
            Engine.object_cinematic_lod(rear_gun.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_01b.Entity, true);
            Engine.object_uses_cinematic_lighting(rear_gun.Entity, true);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._03_intra1_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_03_fol", 3821339215U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task c03_intra1_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intra1\\foley\\c03_intra1_03_fol", 3821339215U), default(IGameObject), 1F);
            Engine.print("c03_intra1 foley 03 start");
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c03_2150_jon()
        {
            await Engine.sleep(59);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\c03_2150_jon", 3821404752U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c03_2150_jon", 2F);
            await Engine.sleep(15);
            Engine.unit_set_emotional_state(johnson.Entity, "amorous", 1F, 15);
            Engine.print("johnson - amorous 1 15");
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task c03_intra1_cinematic_light_03()
        {
            Engine.cinematic_lighting_set_primary_light(31F, 72F, 0.105882F, 0.0941177F, 0.0705882F);
            Engine.cinematic_lighting_set_secondary_light(17F, 56F, 0.0784314F, 0.0784314F, 0.129412F);
            Engine.cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0392157F);
        }

        [ScriptMethod(85, Lifecycle.Static)]
        public async Task c03_intra1_03_setup()
        {
            Engine.wake(new ScriptMethodReference(c03_2150_jon));
            Engine.wake(new ScriptMethodReference(c03_intra1_foley_03));
            Engine.wake(new ScriptMethodReference(c03_intra1_cinematic_light_03));
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task c03_intra1_03_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy(marine_01.Entity);
            Engine.object_destroy(marine_02.Entity);
            Engine.object_destroy(rear_gun.Entity);
            Engine.object_destroy(pelican_01b.Entity);
            Engine.object_destroy(scorpion_02.Entity);
            Engine.object_destroy(rifle_01.Entity);
            Engine.object_destroy(rifle_02.Entity);
            Engine.object_destroy(rifle_03.Entity);
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task c03_intra1_scene_03()
        {
            await this.c03_intra1_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\03_intra1\\03_intra1", 3819438642U), "03_intra1_03", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\03_intra1\\03_intra1", 3819569716U), "johnson_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(pelican_01b.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\03_intra1\\03_intra1", 3819700790U), "pelican_03", false, anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(rear_gun.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\03_intra1\\03_intra1", 3821470289U), "rear_gun_03", anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c03_intra1_03_cleanup();
            await Engine.sleep(30);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task c03_intra1()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.sound_class_set_gain("vehicle_collision", 0F, 0);
            Engine.sound_class_set_gain("amb", 0.25F, 1);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("earthcity_3b"));
            await Engine.sleep(1);
            await this.c03_intra1_scene_01();
            await this.c03_intra1_scene_02a();
            await this.c03_intra1_scene_02b();
            await this.c03_intra1_scene_02c();
            await this.c03_intra1_scene_03();
            Engine.sound_class_set_gain("vehicle_collision", 1F, 1);
            Engine.sound_class_set_gain("amb", 1F, 1);
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x03_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_01_fol", 3821535826U), default(IGameObject), 1F);
            Engine.print("x03 foley 01 start");
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task x03_0010_jon()
        {
            await Engine.sleep(484);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0010_jon", 3821601363U), johnson.Entity, 1F, "radio_default");
            Engine.cinematic_subtitle("x03_0010_jon", 2F);
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task x03_0020_mir()
        {
            await Engine.sleep(552);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0020_mir", 3821666900U), default(IGameObject), 1F, "radio_default");
            Engine.cinematic_subtitle("x03_0020_mir", 1.5F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x03_fov_01()
        {
            await Engine.sleep(88);
            Engine.print("fov change: 65 -> 45 over 90 ticks");
            Engine.camera_set_field_of_view(55F, 90);
            await Engine.sleep(91);
            Engine.print("fov change: 45 -> 50 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
            await Engine.sleep(299);
            Engine.print("fov change: 50 -> 20 over 0 ticks");
            Engine.camera_set_field_of_view(20F, 0);
            Engine.object_destroy(scarab_02.Entity);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x03_01_dof_1()
        {
            await Engine.sleep(479);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 1F, 1F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task scarab_shake_1()
        {
            await Engine.sleep(135);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task scarab_shake_2()
        {
            await Engine.sleep(179);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.4F, 0F);
            await Engine.sleep(25);
            Engine.player_effect_stop(3F);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task effect_scarab_death()
        {
            await Engine.sleep(27);
            Engine.print("blow main-gun");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion_mouth", 3821732437U), scarab_02.Entity, "primary_trigger");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "head_destroyed_cine");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "neck_destroyed_cine");
            await Engine.sleep(3);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "neck_destroyed2_cine");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "knee_destroyed_cine");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "belly_destroyed_cine");
            await Engine.sleep(3);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "calf_destroyed_cine");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\covenant\\military\\scarab\\scarab_death_explosion", 3823370862U), scarab_02.Entity, "knee_destroyed02_cine");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task effect_smoke_start()
        {
            await Engine.sleep(165);
            Engine.print("smoke start");
            Engine.object_create(x03_smoke);
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task effect_smoke_stop()
        {
            await Engine.sleep(475);
            Engine.print("smoke stop");
            Engine.object_destroy(x03_smoke.Entity);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task effect_grav_lift()
        {
            await Engine.sleep(330);
            Engine.object_set_function_variable(carrier.Entity, "grav_lift_control", 0F, 75F);
            Engine.print("grav-lift deactivate");
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_01()
        {
            Engine.cinematic_lighting_set_primary_light(31F, 72F, 0.529412F, 0.466667F, 0.396078F);
            Engine.cinematic_lighting_set_secondary_light(-60F, 180F, 0.0627451F, 0.0588235F, 0.117647F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_02.Entity, true);
            Engine.object_uses_cinematic_lighting(pilot.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_01a.Entity, true);
            Engine.object_uses_cinematic_lighting(scarab_02.Entity, true);
            Engine.object_uses_cinematic_lighting(carrier.Entity, true);
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x03_01_setup()
        {
            Engine.object_create_anew(chief);
            Engine.object_create_anew(johnson_02);
            Engine.object_create_anew(pilot);
            Engine.object_create_anew(pelican_01a);
            Engine.object_create_anew(scarab_02);
            Engine.object_create_anew(carrier);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(johnson_02.Entity, true);
            Engine.object_cinematic_lod(pilot.Entity, true);
            Engine.object_cinematic_lod(pelican_01a.Entity, true);
            Engine.object_cinematic_lod(scarab_02.Entity, true);
            Engine.object_cinematic_lod(carrier.Entity, true);
            Engine.cinematic_clone_players_weapon(chief.Entity, "right_hand", "");
            Engine.object_set_function_variable(carrier.Entity, "grav_lift_control", 1F, 0F);
            Engine.wake(new ScriptMethodReference(x03_0010_jon));
            Engine.wake(new ScriptMethodReference(x03_0020_mir));
            Engine.wake(new ScriptMethodReference(x03_foley_01));
            Engine.wake(new ScriptMethodReference(x03_fov_01));
            Engine.wake(new ScriptMethodReference(x03_01_dof_1));
            Engine.wake(new ScriptMethodReference(scarab_shake_1));
            Engine.wake(new ScriptMethodReference(scarab_shake_2));
            Engine.wake(new ScriptMethodReference(effect_grav_lift));
            Engine.wake(new ScriptMethodReference(effect_scarab_death));
            Engine.wake(new ScriptMethodReference(effect_smoke_start));
            Engine.wake(new ScriptMethodReference(effect_smoke_stop));
            Engine.wake(new ScriptMethodReference(x03_cinematic_lighting_01));
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x03_01_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(johnson_02.Entity);
            Engine.object_destroy(pilot.Entity);
            Engine.object_destroy(pelican_01a.Entity);
            Engine.object_destroy(carrier.Entity);
            Engine.object_destroy(x03_smoke.Entity);
        }

        [ScriptMethod(103, Lifecycle.Static)]
        public async Task x03_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.x03_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_01_fol", 3821535826U));
            await Engine.sleep(this.prediction_offset);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_01", default(IUnit), anchor_flag_x03_01);
            await this.x03_01_setup();
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x03\\x03", 3823501936U), "chief_01", false, anchor_x03_01.Entity);
            Engine.custom_animation_relative(johnson_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "johnson_01", false, anchor_x03_01.Entity);
            Engine.custom_animation_relative(pilot.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "pilot_01", false, anchor_x03_01.Entity);
            Engine.custom_animation_relative(pelican_01a.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\x03\\x03", 3823633010U), "pelican_01", false, anchor_x03_01.Entity);
            Engine.scenery_animation_start_relative(scarab_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\x03\\x03", 3823698547U), "scarab_01", anchor_x03_01.Entity);
            Engine.scenery_animation_start_relative(carrier.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_01", anchor_x03_01.Entity);
            await Engine.sleep(15);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_02_fol", 3823829621U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.x03_01_cleanup();
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task c03_intra1_sound_scene2_01()
        {
            await Engine.sleep(30);
            Engine.sound_class_set_gain("vehicle_engine", 0.2F, 60);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x03_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_02_fol", 3823829621U), default(IGameObject), 1F);
            Engine.print("x03 foley 02 start");
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task x03_0030_mir()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0030_mir", 3823895158U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x03_0030_mir", 2F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task x03_0040_jon()
        {
            await Engine.sleep(73);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0040_jon", 3823960695U), johnson_03.Entity, 1F, "radio_default");
            Engine.cinematic_subtitle("x03_0040_jon", 1F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task x03_0050_lhd()
        {
            await Engine.sleep(106);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0050_lhd", 3824026232U), hood.Entity, 1F, "radio_default");
            Engine.cinematic_subtitle("x03_0050_lhd", 1F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task x03_0060_mir()
        {
            await Engine.sleep(133);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0060_mir", 3824091769U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x03_0060_mir", 3F);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x03_texture_camera_scene_02()
        {
            Engine.print("texture camera start");
            Engine.object_create_anew(texture_camera);
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            Engine.scenery_animation_start_relative(texture_camera.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\x03\\x03", 3824157306U), "texture_camera_02", anchor_x03_02.Entity);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_02()
        {
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-14F, 150F, 0.09F, 0.09F, 0.22F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_bridge.Entity, true);
            Engine.object_uses_cinematic_lighting(hood.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_03.Entity, true);
            Engine.object_uses_cinematic_lighting(pilot_02.Entity, true);
        }

        [ScriptMethod(112, Lifecycle.Static)]
        public async Task x03_03_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(iac);
            Engine.object_cinematic_lod(iac.Entity, true);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task delete_johnson()
        {
            await Engine.sleep(150);
            Engine.print("delete johnson and pelican");
            Engine.object_destroy(johnson_03.Entity);
            Engine.object_destroy(pilot_02.Entity);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x03_emotion_02()
        {
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            Engine.print("miranda - angry .25 0");
            Engine.unit_set_emotional_state(johnson.Entity, "angry", 0.5F, 0);
            Engine.print("johnson - angry .5 0");
            Engine.unit_set_emotional_state(hood.Entity, "angry", 0.25F, 0);
            Engine.print("hood - angry .25 0");
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task x03_02_setup()
        {
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(hood);
            Engine.object_create(johnson_03);
            Engine.object_create(pilot_02);
            Engine.object_create_anew(iac_bridge);
            Engine.object_create_anew(pelican_02);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(hood.Entity, true);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(pilot.Entity, true);
            Engine.object_cinematic_lod(iac_bridge.Entity, true);
            Engine.object_cinematic_lod(pelican_02.Entity, true);
            Engine.wake(new ScriptMethodReference(c03_intra1_sound_scene2_01));
            Engine.wake(new ScriptMethodReference(x03_foley_02));
            Engine.wake(new ScriptMethodReference(x03_0030_mir));
            Engine.wake(new ScriptMethodReference(x03_0040_jon));
            Engine.wake(new ScriptMethodReference(x03_0050_lhd));
            Engine.wake(new ScriptMethodReference(x03_0060_mir));
            Engine.wake(new ScriptMethodReference(delete_johnson));
            Engine.wake(new ScriptMethodReference(x03_emotion_02));
            Engine.wake(new ScriptMethodReference(x03_texture_camera_scene_02));
            Engine.wake(new ScriptMethodReference(x03_cinematic_lighting_02));
        }

        [ScriptMethod(116, Lifecycle.Static)]
        public async Task x03_scene_02()
        {
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
            Engine.camera_set_field_of_view(60F, 0);
            await this.x03_02_predict_stub();
            await this.x03_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_02", default(IUnit), anchor_flag_x03_02);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x03\\x03", 3824222843U), "miranda_02", false, anchor_x03_02.Entity);
            Engine.custom_animation_relative(johnson_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "johnson_02", false, anchor_x03_02.Entity);
            Engine.custom_animation_relative(pilot_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "pilot_02", false, anchor_x03_02.Entity);
            Engine.custom_animation_relative(hood.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x03\\x03", 3826647712U), "hood_02", false, anchor_x03_02.Entity);
            Engine.custom_animation_relative(pelican_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\x03\\x03", 3823633010U), "pelican_02", false, anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(iac_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x03\\x03", 3826778786U), "iacbridge_02", anchor_x03_02.Entity);
            await Engine.sleep(20);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x03_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\music\\x03_03_mus", 3826844323U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_03_fol", 3826909860U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            await this.x03_03_problem_actors();
            await Engine.sleep((short)Engine.camera_time());
            Engine.print("texture camera stop");
            Engine.object_hide(hood.Entity, true);
            Engine.print("hide hood");
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task x03_score_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\music\\x03_03_mus", 3826844323U), default(IGameObject), 1F);
            Engine.print("x03 score 03 start");
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task x03_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_03_fol", 3826909860U), default(IGameObject), 1F);
            Engine.print("x03 foley 03 start");
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x03_0070_lhd()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0070_lhd", 3826975397U), default(IGameObject), 1F, "radio_default");
            Engine.cinematic_subtitle("x03_0070_lhd", 1F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task x03_0080_lhd()
        {
            await Engine.sleep(50);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0080_lhd", 3827040934U), default(IGameObject), 1F, "radio_default");
            Engine.cinematic_subtitle("x03_0080_lhd", 2F);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task x03_0090_nv1()
        {
            await Engine.sleep(195);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0090_nv1", 3827106471U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x03_0090_nv1", 3F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task x03_fov_03()
        {
            await Engine.sleep(27);
            Engine.print("fov change: 5 -> 50 over 38 ticks");
            Engine.camera_set_field_of_view(60F, 38);
            await Engine.sleep(191);
            Engine.print("fov change: 50 -> 15 over 26 ticks");
            Engine.camera_set_field_of_view(25F, 26);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task effect_slipspace_open()
        {
            await Engine.sleep(161);
            Engine.print("effect - slipspace open");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\03\\slipspace_open", 3827172008U), carrier_02.Entity, "bow");
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_03()
        {
            Engine.cinematic_lighting_set_primary_light(31F, 68F, 0.513726F, 0.415686F, 0.313726F);
            Engine.cinematic_lighting_set_secondary_light(-63F, 42F, 0.0901961F, 0.0901961F, 0.117647F);
            Engine.cinematic_lighting_set_ambient_light(0.0823529F, 0.0823529F, 0.0823529F);
            Engine.object_uses_cinematic_lighting(iac.Entity, true);
            Engine.object_uses_cinematic_lighting(carrier_02.Entity, true);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task x03_04_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(nav_officer);
            Engine.object_cinematic_lod(nav_officer.Entity, true);
            Engine.object_uses_cinematic_lighting(nav_officer.Entity, true);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task hide_iac_crew_03()
        {
            Engine.print("hide iac bridge");
            Engine.object_hide(miranda.Entity, true);
            Engine.object_hide(iac_bridge.Entity, true);
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x03_03_setup()
        {
            Engine.object_create_anew(carrier_02);
            Engine.object_cinematic_lod(carrier_02.Entity, true);
            Engine.wake(new ScriptMethodReference(x03_0070_lhd));
            Engine.wake(new ScriptMethodReference(x03_0080_lhd));
            Engine.wake(new ScriptMethodReference(x03_0090_nv1));
            Engine.wake(new ScriptMethodReference(x03_score_03));
            Engine.wake(new ScriptMethodReference(x03_foley_03));
            Engine.wake(new ScriptMethodReference(x03_fov_03));
            Engine.wake(new ScriptMethodReference(x03_cinematic_lighting_03));
            Engine.wake(new ScriptMethodReference(effect_slipspace_open));
            Engine.wake(new ScriptMethodReference(hide_iac_crew_03));
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task x03_scene_03()
        {
            Engine.print("fov change: 50 -> 5 over 0 ticks");
            Engine.camera_set_field_of_view(15F, 0);
            await this.x03_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_03", default(IUnit), anchor_flag_x03_02);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x03\\x03", 3827892915U), "iac_03", anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(carrier_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_03", anchor_x03_02.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x03_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_04_fol", 3827958452U));
            await this.x03_04_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task x03_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_04_fol", 3827958452U), default(IGameObject), 1F);
            Engine.print("x03 foley 04 start");
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task x03_0100_nv1()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0100_nv1", 3828023989U), nav_officer.Entity, 1F);
            Engine.cinematic_subtitle("x03_0100_nv1", 2F);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task x03_0110_mir()
        {
            await Engine.sleep(121);
            Engine.object_hide(iac.Entity, true);
            Engine.object_hide(carrier_02.Entity, true);
            Engine.print("hide iac, carrier");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0110_mir", 3828089526U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x03_0110_mir", 1F);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 30);
            Engine.print("miranda - shocked .25 30");
            await Engine.sleep(30);
            Engine.object_hide(hood.Entity, false);
            Engine.print("unhide hoodr");
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task x03_0120_lhd()
        {
            await Engine.sleep(175);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0120_lhd", 3828155063U), hood.Entity, 1F, "radio_default");
            Engine.cinematic_subtitle("x03_0120_lhd", 2F);
            Engine.unit_set_emotional_state(hood.Entity, "angry", 0.5F, 30);
            Engine.print("hood - angry .5 30");
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task x03_texture_camera_scene_04()
        {
            Engine.print("texture camera start");
            Engine.object_create_anew(texture_camera);
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            Engine.scenery_animation_start_relative(texture_camera.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\x03\\x03", 3824157306U), "texture_camera_04", anchor_x03_02.Entity);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_04()
        {
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-14F, 150F, 0.09F, 0.09F, 0.22F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task x03_emotion_04()
        {
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            Engine.print("miranda - angry .25 0");
            Engine.unit_set_emotional_state(hood.Entity, "angry", 0.25F, 0);
            Engine.print("hood - angry .25 0");
            Engine.unit_set_emotional_state(nav_officer.Entity, "angry", 0.25F, 0);
            Engine.print("nav_officer - angry .25 0");
            await Engine.sleep(20);
            Engine.unit_set_emotional_state(nav_officer.Entity, "shocked", 0.5F, 30);
            Engine.print("nav_officer - shocked .5 30");
        }

        [ScriptMethod(136, Lifecycle.Static)]
        public async Task x03_04_setup()
        {
            Engine.object_hide(miranda.Entity, false);
            Engine.object_hide(iac_bridge.Entity, false);
            Engine.cinematic_set_near_clip_distance(0.05F);
            Engine.print("setting near clip distance to .05");
            Engine.wake(new ScriptMethodReference(x03_0100_nv1));
            Engine.wake(new ScriptMethodReference(x03_0110_mir));
            Engine.wake(new ScriptMethodReference(x03_0120_lhd));
            Engine.wake(new ScriptMethodReference(x03_foley_04));
            Engine.wake(new ScriptMethodReference(x03_texture_camera_scene_04));
            Engine.wake(new ScriptMethodReference(x03_cinematic_lighting_04));
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task x03_scene_04()
        {
            Engine.print("fov change: 15 -> 50 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
            await this.x03_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_04", default(IUnit), anchor_flag_x03_02);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x03\\x03", 3824222843U), "miranda_04", false, anchor_x03_02.Entity);
            Engine.custom_animation_relative(hood.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x03\\x03", 3826647712U), "hood_04", false, anchor_x03_02.Entity);
            Engine.custom_animation_relative(nav_officer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "nav_04", false, anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(iac_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x03\\x03", 3826778786U), "iacbridge_04", anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(carrier_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_04", anchor_x03_02.Entity);
            await Engine.sleep(10);
            Engine.fade_in(1F, 1F, 1F, 5);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x03_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_05_fol", 3828220600U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(hood.Entity);
            Engine.texture_camera_off();
            Engine.print("texture camera stop");
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task x03_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_05_fol", 3828220600U), default(IGameObject), 1F);
            Engine.print("x03 foley 05 start");
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task x03_0130_mir()
        {
            await Engine.sleep(94);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0130_mir", 3828286137U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x03_0130_mir", 1.5F);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task effect_iac_engines()
        {
            await Engine.sleep(112);
            Engine.print("effect - engine");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\03\\iac_engine_fire", 3828351674U), iac.Entity, "");
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task effect_slipspace_widen()
        {
            await Engine.sleep(0);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\03\\slipspace_widening", 3828679359U), carrier_02.Entity, "bow");
            Engine.print("slipspace open");
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_05()
        {
            Engine.cinematic_lighting_set_primary_light(31F, 42F, 0.662745F, 0.470588F, 0.278431F);
            Engine.cinematic_lighting_set_secondary_light(-18F, 30F, 0.121569F, 0.113725F, 0.219608F);
            Engine.cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0392157F);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task delete_pelican()
        {
            await Engine.sleep(87);
            Engine.object_destroy(pelican_02.Entity);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task hide_iac_crew_05()
        {
            Engine.print("hide iac bridge");
            Engine.object_hide(miranda.Entity, true);
            Engine.object_hide(nav_officer.Entity, true);
            Engine.object_hide(iac_bridge.Entity, true);
        }

        [ScriptMethod(145, Lifecycle.Static)]
        public async Task x03_05_setup()
        {
            Engine.object_hide(iac.Entity, false);
            Engine.object_hide(carrier_02.Entity, false);
            Engine.cinematic_set_near_clip_distance(0.06F);
            Engine.print("resetting near clip distance to .06");
            Engine.wake(new ScriptMethodReference(x03_foley_05));
            Engine.wake(new ScriptMethodReference(x03_0130_mir));
            Engine.wake(new ScriptMethodReference(x03_cinematic_lighting_05));
            Engine.wake(new ScriptMethodReference(effect_iac_engines));
            Engine.wake(new ScriptMethodReference(effect_slipspace_widen));
            Engine.wake(new ScriptMethodReference(delete_pelican));
            Engine.wake(new ScriptMethodReference(hide_iac_crew_05));
        }

        [ScriptMethod(146, Lifecycle.Static)]
        public async Task x03_scene_05()
        {
            await this.x03_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_05", default(IUnit), anchor_flag_x03_02);
            Engine.custom_animation_relative(pelican_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\x03\\x03", 3823633010U), "pelican_05", false, anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x03\\x03", 3827892915U), "iac_05", anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(carrier_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_05", anchor_x03_02.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x03_06_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_06_fol", 3828744896U));
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task x03_foley_06()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_06_fol", 3828744896U), default(IGameObject), 1F);
            Engine.print("x03 foley 06 start");
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task x03_0140_nv1()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0140_nv1", 3828810433U), nav_officer.Entity, 1F);
            Engine.cinematic_subtitle("x03_0140_nv1", 2F);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.15F, 0);
            Engine.print("miranda - angry .15 0");
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task x03_0150_mir()
        {
            await Engine.sleep(55);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\03_earthcity\\cinematic\\x03_0150_mir", 3828875970U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x03_0150_mir", 1F);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.35F, 45);
            Engine.print("miranda - angry .35 45");
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task x03_fov_06()
        {
            await Engine.sleep(53);
            Engine.print("fov change: 80 -> 60 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task x03_texture_camera_scene_06()
        {
            Engine.print("texture camera start");
            Engine.object_create_anew(texture_camera);
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            Engine.scenery_animation_start_relative(texture_camera.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\x03\\x03", 3824157306U), "texture_camera_06", anchor_x03_02.Entity);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_06()
        {
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-14F, 150F, 0.09F, 0.09F, 0.22F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(153, Lifecycle.Static)]
        public async Task x03_06_setup()
        {
            Engine.object_hide(miranda.Entity, false);
            Engine.object_hide(nav_officer.Entity, false);
            Engine.object_hide(iac_bridge.Entity, false);
            Engine.wake(new ScriptMethodReference(x03_0140_nv1));
            Engine.wake(new ScriptMethodReference(x03_0150_mir));
            Engine.wake(new ScriptMethodReference(x03_foley_06));
            Engine.wake(new ScriptMethodReference(x03_texture_camera_scene_06));
            Engine.wake(new ScriptMethodReference(x03_fov_06));
            Engine.wake(new ScriptMethodReference(x03_cinematic_lighting_06));
        }

        [ScriptMethod(154, Lifecycle.Static)]
        public async Task x03_06_cleanup()
        {
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(nav_officer.Entity);
            Engine.object_destroy(iac_bridge.Entity);
        }

        [ScriptMethod(155, Lifecycle.Static)]
        public async Task x03_scene_06()
        {
            Engine.camera_set_field_of_view(80F, 0);
            await this.x03_06_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_06", default(IUnit), anchor_flag_x03_02);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x03\\x03", 3824222843U), "miranda_06", false, anchor_x03_02.Entity);
            Engine.custom_animation_relative(nav_officer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x03\\x03", 3823567473U), "nav_06", false, anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(iac_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x03\\x03", 3826778786U), "iacbridge_06", anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(carrier_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_06", anchor_x03_02.Entity);
            await Engine.sleep(10);
            Engine.fade_in(1F, 1F, 1F, 5);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x03_07_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_07_fol", 3828941507U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x03_06_cleanup();
            Engine.texture_camera_off();
            Engine.print("texture camera stop");
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task x03_foley_07()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\x03\\foley\\x03_07_fol", 3828941507U), default(IGameObject), 1F);
            Engine.print("x03 foley 07 start");
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task effect_slipspace_collapse()
        {
            await Engine.sleep(150);
            Engine.object_create_anew(x03_slipspace_collapse);
            Engine.print("effect - slipspace collapse");
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task effect_shockwave_start()
        {
            await Engine.sleep(218);
            Engine.object_create_anew(x03_shockwave_start);
            Engine.print("effect - shockwave start");
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task shockwave_shake_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(234);
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.4F, 1F);
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task x03_cinematic_lighting_07()
        {
            Engine.cinematic_lighting_set_primary_light(31F, 42F, 0.662745F, 0.470588F, 0.278431F);
            Engine.cinematic_lighting_set_secondary_light(-18F, 30F, 0.121569F, 0.113725F, 0.219608F);
            Engine.cinematic_lighting_set_ambient_light(0.0392157F, 0.0392157F, 0.0392157F);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task delete_iac()
        {
            await Engine.sleep(152);
            Engine.object_destroy(iac.Entity);
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task delete_carrier()
        {
            await Engine.sleep(172);
            Engine.object_destroy(carrier_02.Entity);
        }

        [ScriptMethod(163, Lifecycle.Static)]
        public async Task x03_07_setup()
        {
            Engine.wake(new ScriptMethodReference(delete_iac));
            Engine.wake(new ScriptMethodReference(delete_carrier));
            Engine.wake(new ScriptMethodReference(effect_slipspace_collapse));
            Engine.wake(new ScriptMethodReference(effect_shockwave_start));
            Engine.wake(new ScriptMethodReference(shockwave_shake_01));
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\03\\slipspace_widening", 3828679359U), carrier_02.Entity, "bow");
            Engine.wake(new ScriptMethodReference(x03_cinematic_lighting_07));
            Engine.wake(new ScriptMethodReference(x03_foley_07));
        }

        [ScriptMethod(164, Lifecycle.Static)]
        public async Task x03_scene_07()
        {
            await this.x03_07_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_07", default(IUnit), anchor_flag_x03_02);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x03\\x03", 3827892915U), "iac_07", anchor_x03_02.Entity);
            Engine.scenery_animation_start_relative(carrier_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x03\\x03", 3823764084U), "carrier_07", anchor_x03_02.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x03_08_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
            Engine.player_effect_stop(0F);
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task effect_ease_on_down_the_road()
        {
            await Engine.sleep(0);
            Engine.object_create_anew(x03_shockwave_close);
            Engine.print("effetc - tetsuo!!!");
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task effect_akira()
        {
            await Engine.sleep(130);
            Engine.object_create_anew(x03_shockwave_far);
            Engine.print("effect - kaneda!!!");
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task shockwave_shake_02()
        {
            Engine.time_code_reset();
            await Engine.sleep(40);
            Engine.print("shake start");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.5F, 2F);
            Engine.time_code_reset();
            await Engine.sleep(89);
            Engine.print("shake stop");
            Engine.player_effect_stop(0F);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task shockwave_shake_03()
        {
            Engine.time_code_reset();
            await Engine.sleep(270);
            Engine.print("shake start");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 6F);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task final_fade()
        {
            await Engine.sleep(125);
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
            await Engine.sleep(10);
            Engine.fade_in(1F, 1F, 1F, 5);
        }

        [ScriptMethod(170, Lifecycle.Static)]
        public async Task x03_08_setup()
        {
            Engine.object_create_anew(x03_bus);
            Engine.object_create_anew(x03_truck);
            Engine.object_create_anew(x03_generator);
            Engine.object_create_anew(x03_dumpster);
            Engine.object_destroy_containing("x03_palm");
            Engine.object_destroy(x03_shockwave_start.Entity);
            Engine.object_destroy(x03_slipspace_collapse.Entity);
            Engine.wake(new ScriptMethodReference(effect_ease_on_down_the_road));
            Engine.wake(new ScriptMethodReference(final_fade));
            Engine.wake(new ScriptMethodReference(effect_akira));
            Engine.wake(new ScriptMethodReference(shockwave_shake_02));
            Engine.wake(new ScriptMethodReference(shockwave_shake_03));
        }

        [ScriptMethod(171, Lifecycle.Static)]
        public async Task x03_08_cleanup()
        {
            Engine.object_destroy(x03_shockwave_close.Entity);
            Engine.object_destroy(x03_shockwave_far.Entity);
            Engine.object_destroy(x03_bus.Entity);
            Engine.object_destroy(x03_truck.Entity);
            Engine.object_destroy(x03_generator.Entity);
            Engine.object_destroy(x03_dumpster.Entity);
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task x03_scene_08()
        {
            await this.x03_08_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x03\\x03", 3823436399U), "x03_08", default(IUnit), anchor_flag_x03_03);
            Engine.scenery_animation_start_relative(x03_bus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\civilian\\bus\\x03\\x03", 3829007044U), "bus_08", anchor_x03_03.Entity);
            Engine.scenery_animation_start_relative(x03_truck.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\civilian\\panel_truck\\x03\\x03", 3829072581U), "panel_truck_08", anchor_x03_03.Entity);
            Engine.scenery_animation_start_relative(x03_generator.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_big_generator\\x03\\x03", 3829138118U), "big_generator_08", anchor_x03_03.Entity);
            Engine.scenery_animation_start_relative(x03_dumpster.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_dumpster\\x03\\x03", 3829203655U), "dumpster_08", anchor_x03_03.Entity);
            await Engine.sleep(10);
            Engine.fade_in(1F, 1F, 1F, 5);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(0F, 0F, 0F, 5);
            await Engine.sleep(5);
            Engine.player_effect_stop(1F);
            await this.x03_08_cleanup();
            await Engine.sleep(150);
        }

        [ScriptMethod(173, Lifecycle.Static)]
        public async Task x03()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.sound_class_set_gain("vehicle", 0.5F, 0);
            Engine.sound_class_set_gain("amb", 0.5F, 0);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("earthcity_4"));
            await Engine.sleep(1);
            await this.x03_scene_01();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("earthcity_cine_intro_bsp"));
            await Engine.sleep(5);
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
            await Engine.sleep(30);
            if (await this.difficulty_legendary())
            {
                Engine.cinematic_set_title(title0_legendary);
            }
            else if (await this.difficulty_heroic())
            {
                Engine.cinematic_set_title(title0_heroic);
            }
            else
            {
                Engine.cinematic_set_title(title0_normal);
            }

            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
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

        [ScriptMethod(176, Lifecycle.Dormant)]
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
            await Engine.sleep(90);
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task objective0_clear()
        {
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task objective1_set()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_objectives, Engine.players()), 15);
            await Engine.sleep(30);
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task objective1_clear()
        {
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task objective2_set()
        {
            await Engine.sleep(300);
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task objective2_clear()
        {
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task objective3_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task music_03b_01_stop()
        {
            Engine.print("music 03b_01 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_01", 4292222485U));
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task music_03b_01_start_alt()
        {
            Engine.print("music 03b_01 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_01", 4292222485U), true);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task music_03b_01_start()
        {
            Engine.print("music 03b_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_01", 4292222485U), default(IGameObject), 1F);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task music_03b_02_stop()
        {
            Engine.print("music 03b_02 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_02", 4292615707U));
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task music_03b_02_start()
        {
            Engine.print("music 03b_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_02", 4292615707U), default(IGameObject), 1F);
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task music_03b_03_stop()
        {
            Engine.print("music 03b_03 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_03", 4292812318U));
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task music_03b_03_start()
        {
            Engine.print("music 03b_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_03", 4292812318U), default(IGameObject), 1F);
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task music_03b_04_stop()
        {
            Engine.print("music 03b_04 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_04", 4293074466U));
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task music_03b_04_start_alt()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_scarab, Engine.players()), 15);
            Engine.print("music 03b_04 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_04", 4293074466U), true);
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task music_03b_04_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e23_entry_door, Engine.players()), 15);
            Engine.print("music 03b_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\03b_newmombasa\\03b_music\\03b_04", 4293074466U), default(IGameObject), 1F);
        }

        [ScriptMethod(196, Lifecycle.Static)]
        public async Task<bool> player_in_vehicle()
        {
            return Engine.unit_in_vehicle(Engine.unit(await this.player0())) || (bool)Engine.game_is_cooperative() && Engine.unit_in_vehicle(Engine.unit(await this.player1()));
        }

        [ScriptMethod(197, Lifecycle.Static)]
        public async Task<bool> players_in_vehicle()
        {
            return Engine.unit_in_vehicle(Engine.unit(await this.player0())) && !((bool)Engine.game_is_cooperative()) || Engine.unit_in_vehicle(Engine.unit(await this.player1()));
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task flashlight_control()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_dark_area0, Engine.players()))
                {
                    Engine.game_can_use_flashlights(true);
                }
                else
                {
                    Engine.game_can_use_flashlights(false);
                }

                return false;
            }, 60);
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task scarab_no_save()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_scarab_no_save, Engine.players()), 5);
                Engine.game_save_cancel();
                Engine.print("game save canceled");
                return false;
            }, 1);
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task cs_scarab_load_main_gun()
        {
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.vehicle_load_magic(Engine.unit(Engine.object_at_marker(scarab.Entity, "primary_trigger")), "scarab_turret_d", Engine.ai_get_object(this.ai_current_actor));
            Engine.sleep_forever();
        }

        [ScriptMethod(201, Lifecycle.CommandScript)]
        public async Task cs_scarab_load_upper_gun()
        {
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.vehicle_load_magic(Engine.unit(Engine.object_at_marker(scarab.Entity, "t_f_turret")), "scarab_turret_d", Engine.ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(202, Lifecycle.CommandScript)]
        public async Task cs_scarab_load_rear_gun()
        {
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.vehicle_load_magic(Engine.unit(Engine.object_at_marker(scarab.Entity, "t_b_turret")), "scarab_turret_d", Engine.ai_get_object(this.ai_current_actor));
            Engine.sleep_forever();
        }

        [ScriptMethod(203, Lifecycle.Static)]
        public async Task scarab_idle_var0()
        {
            Engine.print("scarab_idle_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(204, Lifecycle.Static)]
        public async Task scarab_idle_firing()
        {
            Engine.print("scarab_idle_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(205, Lifecycle.Static)]
        public async Task scarab_idle_to_walk_front()
        {
            Engine.print("scarab_idle_to_walk_front");
            Engine.device_set_position_track(scarab.Entity, "combat:idle:2:walk_front", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 3F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(206, Lifecycle.Static)]
        public async Task scarab_idle_to_walk_front_fast()
        {
            Engine.print("scarab_idle_to_walk_front");
            Engine.device_set_position_track(scarab.Entity, "combat:idle:2:walk_front", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 2F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(207, Lifecycle.Static)]
        public async Task scarab_walk_front_var0()
        {
            Engine.print("scarab_walk_front_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(208, Lifecycle.Static)]
        public async Task scarab_walk_front_var0_fast()
        {
            Engine.print("scarab_walk_front_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 80F / 30F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(209, Lifecycle.Static)]
        public async Task scarab_walk_front_low_var0()
        {
            Engine.print("scarab_walk_front_low_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 8F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(210, Lifecycle.Static)]
        public async Task scarab_walk_front_to_idle()
        {
            Engine.print("scarab_walk_front_to_idle");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front:2:idle", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 3F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(211, Lifecycle.Static)]
        public async Task scarab_walk_front_to_idle_fast()
        {
            Engine.print("scarab_walk_front_to_idle");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front:2:idle", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 2F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(212, Lifecycle.Static)]
        public async Task scarab_idle_turn_22_left()
        {
            Engine.print("scarab_idle_turn_22_left");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_22_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(213, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_left()
        {
            Engine.print("scarab_idle_turn_45_left");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_45_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(214, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_right()
        {
            Engine.print("scarab_idle_turn_45_right");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_45_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(215, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_15_left()
        {
            Engine.print("scarab_walk_front_turn_15_left");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_15_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(216, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_15_right()
        {
            Engine.print("scarab_walk_front_turn_15_right");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_15_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_22_left()
        {
            Engine.print("scarab_walk_front_turn_22_left");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_22_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_45_left()
        {
            Engine.print("scarab_walk_front_turn_45_left");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_45_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_45_right()
        {
            Engine.print("scarab_walk_front_turn_45_right");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_45_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(220, Lifecycle.Static)]
        public async Task scarab_walk_front_to_walk_low()
        {
            Engine.print("scarab_walk_front_to_walk_low");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front:2:walk_narrow_front", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(221, Lifecycle.Static)]
        public async Task scarab_walk_low_to_walk_front()
        {
            Engine.print("scarab_walk_narrow_to_walk_front");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_narrow_front:2:walk_front", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(222, Lifecycle.Static)]
        public async Task scarab_walk_low_var0()
        {
            Engine.print("scarab_walk_narrow_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_narrow_front:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(223, Lifecycle.Static)]
        public async Task scarab_idle_to_twist_5_left()
        {
            Engine.print("scarab_idle_to_twist_5_right");
            Engine.device_set_position_track(scarab.Entity, "combat:idle_to_twist_5_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(224, Lifecycle.Static)]
        public async Task scarab_idle_to_twist_5_right()
        {
            Engine.print("scarab_idle_to_twist_5_right");
            Engine.device_set_position_track(scarab.Entity, "combat:idle_to_twist_5_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(225, Lifecycle.Static)]
        public async Task scarab_twist_5_left()
        {
            Engine.print("scarab_twist_5_left");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(226, Lifecycle.Static)]
        public async Task scarab_twist_5_left_firing()
        {
            Engine.print("scarab_twist_5_left");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(227, Lifecycle.Static)]
        public async Task scarab_twist_5_right()
        {
            Engine.print("scarab_twist_5_right");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(228, Lifecycle.Static)]
        public async Task scarab_twist_5_right_firing()
        {
            Engine.print("scarab_twist_5_right");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(229, Lifecycle.Static)]
        public async Task scarab_twist_5_left_to_idle()
        {
            Engine.print("scarab_twist_5_left_to_idle");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_left_to_idle", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(230, Lifecycle.Static)]
        public async Task scarab_twist_5_right_to_idle()
        {
            Engine.print("scarab_twist_5_left_to_idle");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_right_to_idle", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(231, Lifecycle.Static)]
        public async Task scarab_gun_open_instant()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_open");
            Engine.device_animate_overlay(scarab.Entity, 1F, 0.05F, 0F, 0F);
        }

        [ScriptMethod(232, Lifecycle.Static)]
        public async Task scarab_gun_open()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_open");
            Engine.device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(233, Lifecycle.Static)]
        public async Task scarab_gun_fire()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire");
            Engine.device_animate_overlay(scarab.Entity, 1F, 6F, 0F, 0F);
        }

        [ScriptMethod(234, Lifecycle.Static)]
        public async Task scarab_gun_close()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_close");
            Engine.device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(235, Lifecycle.Static)]
        public async Task scarab_gun_open_down_instant()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_down_open");
            Engine.device_animate_overlay(scarab.Entity, 1F, 0.05F, 0F, 0F);
        }

        [ScriptMethod(236, Lifecycle.Static)]
        public async Task scarab_gun_open_down()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_down_open");
            Engine.device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(237, Lifecycle.Static)]
        public async Task scarab_gun_fire_down()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_down");
            Engine.device_animate_overlay(scarab.Entity, 1F, 6F, 0F, 0F);
        }

        [ScriptMethod(238, Lifecycle.Static)]
        public async Task scarab_gun_close_down()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_down_close");
            Engine.device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(239, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_0_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p1"));
            Engine.object_destroy(Engine.ai_vehicle_get(this.ai_current_actor));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(240, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_1_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p3"));
            Engine.object_destroy(Engine.ai_vehicle_get(this.ai_current_actor));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(241, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_gunners0()
        {
            await Engine.sleep(60);
            if (!(Engine.volume_test_objects(tv_scarab, Engine.players())))
            {
                Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/leg1"));
            }

            await Engine.sleep(60);
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/leg1"));
            await Engine.sleep(1);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(242, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_gunners1()
        {
            await Engine.sleep(120);
            if (!(Engine.volume_test_objects(tv_scarab, Engine.players())))
            {
                Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/leg0"));
            }

            await Engine.sleep(60);
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/leg0"));
            await Engine.sleep(1);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(243, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_pelican2_2_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p4"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/f0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p5"));
            if (this.g_e23_scarab_after_turn)
            {
                Engine.cs_run_command_script(e23_mars_pelican2.gunner0, cs_e23_mars_pelican2_gunners0);
                Engine.cs_run_command_script(e23_mars_pelican2.gunner1, cs_e23_mars_pelican2_gunners1);
            }

            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p6"), 16F);
            this.g_e23_mars_pelican2_2_active = false;
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/f0"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p7"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p6"), 2F);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p7"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p7"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p8"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_mars_pelican2_flyby/p1"));
            Engine.object_destroy(Engine.ai_vehicle_get(this.ai_current_actor));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(244, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_inf1_shoot()
        {
            await Engine.sleep_until(async () => this.g_e23_scarab_climbed_down, 15);
            await Engine.sleep((short)Engine.random_range(10, 30));
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_shoot(true, Engine.list_get(Engine.ai_actors(e23_cov_inf0), (short)Engine.random_range(0, Engine.list_count(Engine.ai_actors(e23_cov_inf0)))));
                await Engine.sleep((short)Engine.random_range(45, 75));
                return this.g_e23_scarab_before_bridge0;
            }, 15);
            Engine.ai_vehicle_exit(this.ai_current_actor);
        }

        [ScriptMethod(245, Lifecycle.CommandScript)]
        public async Task cs_e23_mars_inf0_shoot()
        {
            await Engine.sleep_until(async () => this.g_e23_scarab_under_bridge0, 15);
            await Engine.sleep((short)Engine.random_range(100, 120));
            await Engine.sleep_until(async () =>
            {
                Engine.cs_shoot(true, Engine.list_get(Engine.ai_actors(e23_cov_inf0), (short)Engine.random_range(0, Engine.list_count(Engine.ai_actors(e23_cov_inf0)))));
                await Engine.sleep((short)Engine.random_range(45, 75));
                return this.g_e23_scarab_before_bridge1;
            }, 15);
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task cs_e23_cov_inf1_pilot_exit()
        {
            Engine.objects_detach(scarab.Entity, Engine.ai_get_object(this.ai_current_actor));
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4041871220U), "scarab_d_r:any:any:exit", true);
            await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
            Engine.unit_stop_custom_animation(Engine.ai_get_unit(this.ai_current_actor));
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task cs_e23_cov_inf1_pilot0()
        {
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_queue_command_script(this.ai_current_actor, cs_e23_cov_inf1_pilot_exit);
            Engine.cs_abort_on_damage(true);
            Engine.custom_animation_loop(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4041871220U), "scarab_d_r:any:any:idle:var0", false);
            Engine.objects_attach(scarab.Entity, "scarab_d_l", Engine.ai_get_object(this.ai_current_actor), "");
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 7F, 10);
            Engine.objects_detach(scarab.Entity, Engine.ai_get_object(this.ai_current_actor));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 3F, 10);
        }

        [ScriptMethod(248, Lifecycle.CommandScript)]
        public async Task cs_e23_cov_inf1_pilot1()
        {
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_queue_command_script(this.ai_current_actor, cs_e23_cov_inf1_pilot_exit);
            Engine.cs_abort_on_damage(true);
            Engine.custom_animation_loop(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4041871220U), "scarab_d_r:any:any:idle:var0", false);
            Engine.objects_attach(scarab.Entity, "scarab_d_r", Engine.ai_get_object(this.ai_current_actor), "");
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 7F, 10);
            Engine.objects_detach(scarab.Entity, Engine.ai_get_object(this.ai_current_actor));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 3F, 10);
        }

        [ScriptMethod(249, Lifecycle.CommandScript)]
        public async Task cs_e23_scarab_upper_gun()
        {
            Engine.cs_shoot(true, Engine.ai_vehicle_get(e23_mars_pelican0_1.pelican0));
            await Engine.sleep(120);
        }

        [ScriptMethod(250, Lifecycle.CommandScript)]
        public async Task cs_best_cs_ever()
        {
            Engine.cs_approach(this.g_target, 0.5F, 5F, 50F);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_crouch(true);
                await Engine.sleep(8);
                Engine.cs_crouch(false);
                await Engine.sleep(8);
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
            Engine.ai_place(scarab_gunners.upper_gunner);
            await Engine.sleep(5);
            Engine.cs_run_command_script(scarab_gunners.upper_gunner, cs_e23_scarab_upper_gun);
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task e23_scarab()
        {
            Engine.wake(new ScriptMethodReference(scarab_no_save));
            Engine.pvs_set_object(scarab.Entity);
            Engine.ai_erase(scarab_gunners.main_gunner);
            Engine.device_set_position_track(scarab.Entity, "finale_climb_off_buildings", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 401F / 30F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
            this.g_e23_scarab_climbed_down = true;
            await Engine.sleep_until(async () => this.g_e23_started, 1);
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
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e23_scarab_corner_continue, Engine.players()), 1);
            Engine.game_save();
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

            Engine.print("cortana: it can't go any further this way. we have it trapped!");
            Engine.ai_play_line_on_object(default(IGameObject), "2030") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await this.scarab_walk_front_to_idle();
            this.g_e23_scarab_arrived_at_end = true;
            await this.scarab_gun_open();
            await this.scarab_idle_var0();
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.g_e23_scarab_active)
                    {
                        if (this.g_e23_scarab_active)
                        {
                            await this.scarab_idle_to_twist_5_right();
                        }

                        if (this.g_e23_scarab_active)
                        {
                            if ((short)Engine.random_range(0, 2) == 0)
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
                            if ((short)Engine.random_range(0, 2) == 0)
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
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e23_cov_inf1_0.Squad) >= this.ai_combat_status_clear_los);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e23_cov_inf1_0.Squad) <= this.ai_combat_status_active);
            Engine.print("cortana: careful chief, that elite was an ultra! and those pilots are no pushovers either!!");
            Engine.ai_play_line_on_object(default(IGameObject), "2050") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task e23_ultra_dialogue_kill()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_cov_inf1_0.ultra0) <= 0, 15);
            Engine.sleep_forever(new ScriptMethodReference(e23_ultra_dialogue));
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task e23_dialogue_boarding()
        {
            await Engine.sleep(30);
            Engine.print("cortana: chief, you're going to have to board the scarab!");
            Engine.ai_play_line_on_object(default(IGameObject), "2020") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(600);
            Engine.print("cortana: we can't do anything more to that scarab from here");
            Engine.ai_play_line_on_object(default(IGameObject), "2040") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(75);
            Engine.activate_team_nav_point_object(_default, player, scarab.Entity, 8.5F);
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task e23_dialogue_boarding_kill()
        {
            await Engine.sleep_until(async () => this.g_mission_over || Engine.volume_test_objects(tv_scarab, Engine.players()), 15);
            Engine.sleep_forever(new ScriptMethodReference(e23_dialogue_boarding));
            Engine.deactivate_team_nav_point_object(player, scarab.Entity);
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task e23_best_cs_ever()
        {
            if (!(await this.difficulty_legendary()))
            {
                Engine.sleep_forever();
            }

            if (!((short)Engine.random_range(0, 10) == 0))
            {
                Engine.sleep_forever();
            }

            this.g_target = await this.player0();
            await Engine.sleep_until(async () => Engine.object_get_health(this.g_target) <= 0F, 10);
            Engine.cs_run_command_script(e23_cov_inf1_0.ultra0, cs_best_cs_ever);
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task e23_cov_inf1_main()
        {
            await Engine.sleep_until(async () => this.g_e23_scarab_climbed_down, 5);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_scarab_stairwell, Engine.players()), 15);
            Engine.ai_place(e23_cov_inf1_1.Squad);
            Engine.ai_place(e23_cov_inf1_0.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e23_cov_inf0), 1F, 3F));
            Engine.wake(new ScriptMethodReference(e23_ultra_dialogue));
            Engine.wake(new ScriptMethodReference(e23_ultra_dialogue_kill));
            Engine.wake(new ScriptMethodReference(e23_best_cs_ever));
            await Engine.sleep_until(async () => !(Engine.cs_command_script_queued(e23_cov_inf1_1.pilot0, cs_e23_cov_inf1_pilot0)) && !(Engine.cs_command_script_queued(e23_cov_inf1_1.pilot1, cs_e23_cov_inf1_pilot1)));
            this.g_e23_scarab_active = false;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_cov_inf1) <= 0);
            this.g_mission_over = true;
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task e23_cov_inf0_main()
        {
            await Engine.sleep_until(async () => this.g_e23_scarab_climbed_down, 5);
            Engine.ai_place(e23_cov_inf0_0.Squad);
            await Engine.sleep_until(async () => this.g_e23_scarab_under_bridge1 || (short)Engine.ai_living_count(e23_cov_inf0) <= 2 || Engine.volume_test_objects(tv_scarab_interior, Engine.players()), 15);
            Engine.ai_place(e23_cov_inf0_1.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(e23_cov_inf0), 0F, 4F));
            await Engine.sleep_until(async () => this.g_e23_scarab_under_bridge2 || (short)Engine.ai_living_count(e23_cov_inf0) <= 2 || Engine.volume_test_objects(tv_scarab_interior, Engine.players()), 15);
            Engine.ai_place(e23_cov_inf0_2.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(e23_cov_inf0), 0F, 3F));
            await Engine.sleep_until(async () => this.g_e23_scarab_arrived_at_end || (short)Engine.ai_living_count(e23_cov_inf0) <= 2 || Engine.volume_test_objects(tv_scarab_interior, Engine.players()), 15);
            Engine.ai_place(e23_cov_inf0_3.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(e23_cov_inf0), 0F, 2F));
            await Engine.sleep_until(async () => this.g_e23_scarab_arrived_at_end || Engine.volume_test_objects(tv_scarab, Engine.players()), 15);
            Engine.ai_place(e23_cov_inf0_4.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(e23_cov_inf0), 0F, 5F));
            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_cov_inf0) <= 2);
            Engine.wake(new ScriptMethodReference(e23_dialogue_boarding));
            await Engine.sleep(10);
            Engine.wake(new ScriptMethodReference(e23_dialogue_boarding_kill));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_cov_inf0) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task e23_mars_pelican2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e23_mars_pelican0_begin, Engine.players()), 15);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.ai_place(e23_mars_pelican2.pelican0), 
                    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
                    async () => await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_mars_pelican2.Squad) < 2), 
                    async () => Engine.ai_place(e23_mars_pelican2.pelican1), 
                    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
                    async () => await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_mars_pelican2.Squad) < 2), 
                    async () => Engine.ai_place(e23_mars_pelican2.pelican0), 
                    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
                    async () => await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_mars_pelican2.Squad) < 2), 
                    async () => Engine.ai_place(e23_mars_pelican2.pelican1), 
                    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
                    async () => await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_mars_pelican2.Squad) < 2), 
                    async () => Engine.ai_place(e23_mars_pelican2.pelican2), 
                    async () => Engine.ai_place(e23_mars_pelican2.gunner0), 
                    async () => Engine.ai_place(e23_mars_pelican2.gunner1), 
                    async () => await Engine.sleep(1), 
                    async () => Engine.vehicle_load_magic(Engine.ai_vehicle_get(e23_mars_pelican2.pelican2), "pelican_g_pod", Engine.ai_get_object(e23_mars_pelican2.gunner0)), 
                    async () => Engine.vehicle_load_magic(Engine.ai_vehicle_get(e23_mars_pelican2.pelican2), "pelican_g_pod", Engine.ai_get_object(e23_mars_pelican2.gunner1)), 
                    async () => this.g_e23_mars_pelican2_2_active = true, 
                    async () => await Engine.sleep_until(async () => !(this.g_e23_mars_pelican2_2_active)), 
                    async () => await Engine.sleep_until(async () => (short)Engine.ai_living_count(e23_mars_pelican2.Squad) < 2));
                return this.g_mission_over;
            });
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task e23_mars_pelican1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e23_mars_pelican1_begin, Engine.players()), 15);
            Engine.ai_place(e23_mars_pelican1_0.Squad);
            await Engine.sleep(60);
            Engine.ai_place(e23_mars_pelican1_1.Squad);
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task e23_mars_pelican0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e23_mars_pelican0_begin, Engine.players()) || this.g_e23_scarab_under_bridge1, 15);
            Engine.ai_place(e23_mars_pelican0);
            Engine.ai_vehicle_enter_immediate(e23_mars_pelican0_0.gunner0, Engine.ai_vehicle_get(e23_mars_pelican0_0.pelican0), "pelican_g_pod");
            Engine.ai_vehicle_enter_immediate(e23_mars_pelican0_0.gunner1, Engine.ai_vehicle_get(e23_mars_pelican0_0.pelican0), "pelican_g_pod");
            Engine.ai_vehicle_enter_immediate(e23_mars_pelican0_1.gunner0, Engine.ai_vehicle_get(e23_mars_pelican0_1.pelican0), "pelican_g_pod");
            Engine.ai_vehicle_enter_immediate(e23_mars_pelican0_1.gunner1, Engine.ai_vehicle_get(e23_mars_pelican0_1.pelican0), "pelican_g_pod");
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task e23_mars_inf1_main()
        {
            Engine.ai_migrate(e22_mars_inf1.Squad, e23_mars_inf1.Squad);
            Engine.ai_place(e23_mars_inf1.Squad, (short)(3 - (float)Engine.ai_living_count(e23_mars_inf1.Squad)));
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task e23_mars_inf0_main()
        {
            Engine.ai_place(e23_mars_inf0.Squad);
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task e23_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e23_main_begin, Engine.players()), 15);
            this.g_e23_started = true;
            Engine.print("e23_main");
            Engine.data_mine_set_mission_segment("e23_scarab_boarding");
            Engine.game_save();
            if (await this.difficulty_legendary())
            {
                Engine.object_destroy(e23_gun.Entity);
            }

            Engine.wake(new ScriptMethodReference(music_03b_04_start));
            Engine.wake(new ScriptMethodReference(music_03b_04_start_alt));
            Engine.kill_volume_enable(kill_e23_0);
            Engine.kill_volume_enable(kill_e23_1);
            Engine.kill_volume_enable(kill_e23_2);
            Engine.wake(new ScriptMethodReference(e23_mars_inf1_main));
            Engine.wake(new ScriptMethodReference(e23_mars_pelican2_main));
            Engine.wake(new ScriptMethodReference(e23_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e23_cov_inf1_main));
        }

        [ScriptMethod(271, Lifecycle.Static)]
        public async Task test_scarab_boarding()
        {
            Engine.object_teleport(await this.player0(), e23_test);
            Engine.object_create(scarab);
            Engine.pvs_set_object(scarab.Entity);
            Engine.object_teleport(scarab.Entity, e23_scarab_start);
            this.g_e23_scarab_arrived = true;
            if (!(this.g_e23_started))
            {
                Engine.wake(new ScriptMethodReference(e23_main));
            }

            Engine.wake(new ScriptMethodReference(e23_scarab));
        }

        [ScriptMethod(272, Lifecycle.CommandScript)]
        public async Task cs_e22_mars1_go()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.ai_vehicle_exit(this.ai_current_actor);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf1/p0"));
        }

        [ScriptMethod(273, Lifecycle.CommandScript)]
        public async Task cs_e22_mars1_lieutenant()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_looking(false);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e22_mars_inf1/scarab_entry"));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_scarab_entry_begin, Engine.players()), 10);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => Engine.device_get_position(e22_door3.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 3.5F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F, 5);
            await Engine.sleep(30);
            Engine.print("lt: when i asked for reinforcements...");
            await Engine.sleep((short)((float)Engine.ai_play_line(this.ai_current_actor, "0770") - 75));
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep(55);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep(27);
            Engine.cs_crouch(true);
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "8030"));
            Engine.print("lf: we got trouble");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e22_mars_scorpions0.Squad) <= 0, 15);
            await Engine.sleep(60);
            Engine.print("gnr: alright, this is the shit");
            await Engine.sleep((short)((float)Engine.ai_play_line(e22_mars_inf1.marine0, "8060") - 30));
            Engine.cs_look_object(true, Engine.ai_get_object(e22_mars_inf1.marine0));
            await Engine.sleep(45);
            Engine.print("lt: marine, did i give you permission to bitch?");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "8010"));
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_before_climb, 5);
            Engine.print("lt: i don't think it's stopping");
            Engine.ai_play_line(this.ai_current_actor, "0790") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep_until(async () => this.g_e22_scarab_mid_climb, 5);
            Engine.cs_crouch(false);
            await Engine.sleep(90);
            Engine.ai_play_line(this.ai_current_actor, "8040") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.print("lt: that thing is starting to piss me off");
            await Engine.sleep(100);
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.cs_face_player(true);
            Engine.ai_play_line(this.ai_current_actor, "0830") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.print("lt: marines, time to kill us a scarab");
            Engine.cs_look_player(false);
            await Engine.sleep(30);
            Engine.cs_enable_looking(true);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf1/p0"));
            await Engine.sleep(20);
            Engine.cs_run_command_script(e22_mars_inf1.marine0, cs_e22_mars1_go);
            await Engine.sleep(20);
            Engine.cs_run_command_script(e22_mars_inf0.perez, cs_e22_mars1_go);
            Engine.wake(new ScriptMethodReference(objective3_set));
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task cs_e22_mars0_crouch()
        {
            Engine.cs_enable_dialogue(true);
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.cs_crouch(true);
            Engine.cs_look_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(275, Lifecycle.CommandScript)]
        public async Task cs_e22_mars0_stand()
        {
            Engine.cs_enable_dialogue(true);
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.cs_look_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(276, Lifecycle.CommandScript)]
        public async Task cs_e22_mars0_perez()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_face_player(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf0_perez/p0"));
            Engine.cs_start_approach_player(3F, 20F, 35F);
            Engine.print("perez: hey chief!");
            await Engine.sleep_until(async () => !(await this.players_in_vehicle()), 10);
            Engine.cs_approach_player(1.5F, 5F, 10F);
            Engine.cs_face_player(true);
            await Engine.sleep((short)((float)Engine.ai_play_line_at_player(this.ai_current_actor, "0710") - 30));
            Engine.cs_face_player(false);
            Engine.cs_enable_looking(true);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf0_perez/p1"));
            await Engine.sleep(45);
            Engine.cs_look_player(true);
            Engine.print("the lt. got hit");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0730"));
            await Engine.sleep(15);
            Engine.print("who in charge");
            await Engine.sleep((short)((float)Engine.ai_play_line_on_object(default(IGameObject), "0740") - 30));
            Engine.cs_look_player(true);
            await Engine.sleep(45);
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()), 5);
            Engine.cs_face_player(true);
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0750"));
            Engine.cs_face_player(false);
            Engine.cs_look_player(false);
            Engine.cs_enable_looking(true);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf0_perez/p2"));
            Engine.print("c'mon, i'll show you");
            Engine.ai_play_line(this.ai_current_actor, "0760") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(20);
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()), 5);
            Engine.cs_look_player(true);
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf1_crouch()
        {
            Engine.cs_crouch(true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await Engine.sleep(150);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_before_climb, 5);
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.ai_vehicle_exit(this.ai_current_actor);
            await Engine.sleep_until(async () => this.g_e22_scarab_mid_climb, 5);
            await Engine.sleep(20);
            Engine.cs_crouch(false);
            await Engine.sleep_until(async () => this.g_e22_scarab_past_climb, 5);
            await Engine.sleep((short)Engine.random_range(20, 40));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf1/p0"));
        }

        [ScriptMethod(278, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf1_marine1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(3);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf1/p1"));
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e22_mars_scorpions0/scarab_target"));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 11F, 5);
            Engine.cs_face_player(true);
            Engine.ai_play_line_at_player(this.ai_current_actor, "0840") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 4F, 5);
            Engine.cs_face_player(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf1/p0"));
        }

        [ScriptMethod(279, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine_end()
        {
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => this.g_e22_scarab_mid_climb, 5);
            Engine.cs_crouch(false);
            await Engine.sleep_until(async () => this.g_e22_scarab_past_climb, 5);
            Engine.cs_force_combat_status(2);
            Engine.sleep_forever();
        }

        [ScriptMethod(280, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine0()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await Engine.sleep((short)Engine.random_range(30, 45));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await Engine.sleep((short)Engine.random_range(120, 150));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.cs_crouch(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf2/p0"));
            Engine.cs_run_command_script(this.ai_current_actor, cs_e22_mars_inf2_marine_end);
        }

        [ScriptMethod(281, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine1()
        {
            Engine.cs_force_combat_status(3);
            await Engine.sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await Engine.sleep((short)Engine.random_range(30, 45));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await Engine.sleep((short)Engine.random_range(120, 150));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.ai_vehicle_exit(this.ai_current_actor);
            Engine.cs_crouch(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf2/p1"));
            Engine.cs_run_command_script(this.ai_current_actor, cs_e22_mars_inf2_marine_end);
        }

        [ScriptMethod(282, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine2()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await Engine.sleep((short)Engine.random_range(30, 45));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await Engine.sleep((short)Engine.random_range(180, 210));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.cs_crouch(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf2/p2"));
            Engine.cs_run_command_script(this.ai_current_actor, cs_e22_mars_inf2_marine_end);
        }

        [ScriptMethod(283, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine3()
        {
            Engine.cs_force_combat_status(3);
            await Engine.sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await Engine.sleep((short)Engine.random_range(30, 45));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await Engine.sleep((short)Engine.random_range(180, 210));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.ai_vehicle_exit(this.ai_current_actor);
            Engine.cs_crouch(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf2/p3"));
            Engine.cs_run_command_script(this.ai_current_actor, cs_e22_mars_inf2_marine_end);
        }

        [ScriptMethod(284, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_inf2_marine4()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => this.g_e22_scarab_appeared, 5);
            await Engine.sleep((short)Engine.random_range(30, 45));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_advancing, 5);
            await Engine.sleep((short)Engine.random_range(240, 270));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            Engine.cs_crouch(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_mars_inf2/p4"));
            Engine.cs_run_command_script(this.ai_current_actor, cs_e22_mars_inf2_marine_end);
        }

        [ScriptMethod(285, Lifecycle.CommandScript)]
        public async Task cs_e22_mars_scorpion0()
        {
            Engine.cs_force_combat_status(3);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scarab_visible, 5);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e22_scarab_target/target"));
            await Engine.sleep_until(async () => this.g_e22_scorpion_asplode, 5);
            Engine.unit_kill(Engine.ai_vehicle_get(this.ai_current_actor));
        }

        [ScriptMethod(286, Lifecycle.CommandScript)]
        public async Task cs_e22_scarab_main_gun()
        {
            Engine.cs_shoot(true, Engine.ai_vehicle_get(e22_mars_scorpions0.scorpion0));
            await Engine.sleep(120);
            this.g_e22_scorpion_asplode = true;
            await Engine.sleep(45);
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task e22_scarab_climbing_events()
        {
            await Engine.sleep(45);
            this.g_e22_scarab_started_climb = true;
            Engine.print("g_e22_scarab_started_climb ");
            await Engine.sleep(100);
            this.g_e22_scarab_mid_climb = true;
            Engine.print("g_e22_scarab_mid_climb ");
            Engine.print("todo: boom boom dust shakes");
            await Engine.sleep(90);
            this.g_e22_scarab_past_climb = true;
            Engine.print("g_e22_scarab_past_climb ");
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task e22_scarab_advancing_events()
        {
            this.g_e22_scarab_advancing = true;
            Engine.print("g_e22_scarab_advancing ");
            await Engine.sleep(259);
            Engine.object_damage_damage_section(e22_bridge0_2.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge0_3.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge0_4.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge0_5.Entity, "main", 1F);
            await Engine.sleep(2);
            Engine.object_damage_damage_section(e22_bridge0_0.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge0_1.Entity, "main", 1F);
            await Engine.sleep(118);
            Engine.object_damage_damage_section(e22_bridge1_2.Entity, "main", 1F);
            await Engine.sleep(1);
            Engine.object_damage_damage_section(e22_bridge1_0.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge1_1.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge1_3.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge1_4.Entity, "main", 1F);
            await Engine.sleep(1);
            Engine.object_damage_damage_section(e22_bridge1_5.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge1_6.Entity, "main", 1F);
            await Engine.sleep(1);
            Engine.object_damage_damage_section(e22_bridge1_7.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge1_8.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge1_9.Entity, "main", 1F);
            await Engine.sleep(19);
            Engine.object_damage_damage_section(e22_bridge2_0.Entity, "main", 1F);
            await Engine.sleep(1);
            Engine.object_damage_damage_section(e22_bridge2_3.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge2_5.Entity, "main", 1F);
            await Engine.sleep(1);
            Engine.object_damage_damage_section(e22_bridge2_1.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge2_2.Entity, "main", 1F);
            Engine.object_damage_damage_section(e22_bridge2_4.Entity, "main", 1F);
            await Engine.sleep(30);
            this.g_e22_scarab_before_climb = true;
            Engine.print("g_e22_scarab_before_climb ");
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task e22_scarab_appearance_events()
        {
            await Engine.sleep(60);
            this.g_e22_scarab_visible = true;
            await Engine.sleep(180);
            this.g_e22_scarab_appeared = true;
            Engine.print("g_e22_scarab_appeared ");
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task e22_scarab_intro_gun()
        {
            Engine.object_create(e22_scarab_gun);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e22_scarab_gun"), 0, true);
            await Engine.sleep(45);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e22_scarab_gun"), 0, false);
            await Engine.sleep(60);
            Engine.object_destroy(e22_scarab_gun.Entity);
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task e22_scarab()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_begin_scarab_sequence, Engine.players()), 10);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_scarab_entry_begin, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(e22_scarab_intro_gun));
            Engine.wake(new ScriptMethodReference(chapter_title2));
            await Engine.sleep(50);
            Engine.ai_place(scarab_gunners.main_gunner);
            Engine.object_create_anew(scarab);
            Engine.object_teleport(scarab.Entity, e22_scarab_start);
            Engine.pvs_set_object(scarab.Entity);
            Engine.wake(new ScriptMethodReference(e22_scarab_appearance_events));
            await this.scarab_gun_open_down_instant();
            Engine.device_set_position_track(scarab.Entity, "finale_enter", 0F);
            Engine.device_animate_position(scarab.Entity, 1F, 266F / 30F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
            Engine.cs_stack_command_script(scarab_gunners.main_gunner, cs_e22_scarab_main_gun);
            await this.scarab_gun_fire_down();
            await this.scarab_idle_firing();
            Engine.wake(new ScriptMethodReference(e22_scarab_advancing_events));
            await this.scarab_idle_to_walk_front_fast();
            await this.scarab_walk_front_var0_fast();
            await this.scarab_gun_close_down();
            await this.scarab_walk_front_var0_fast();
            await this.scarab_walk_front_var0_fast();
            await this.scarab_walk_front_var0_fast();
            await this.scarab_walk_front_var0_fast();
            Engine.wake(new ScriptMethodReference(e22_scarab_climbing_events));
            Engine.device_set_position_track(scarab.Entity, "finale_climb_on_buildings", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 446F / 30F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
            this.g_e23_scarab_arrived = true;
            Engine.begin_random(async () =>
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
            Engine.wake(new ScriptMethodReference(e23_scarab));
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task e22_nasty_player_synch()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_begin_scarab_sequence, Engine.players()), 5);
            Engine.volume_teleport_players_not_inside(tv_e22_no_teleport, e22_nasty_player_synch1);
            await Engine.sleep_until(async () =>
            {
                if (Engine.list_count(Engine.volume_return_objects_by_type(tv_e22_street_cleanup, 2)) > 0)
                {
                    Engine.object_destroy(Engine.list_get(Engine.volume_return_objects_by_type(tv_e22_street_cleanup, 2), 0));
                    return 1F == 0F;
                }
                else
                {
                    return 1F == 1F;
                }
            }, 1);
            Engine.garbage_collect_unsafe();
            this.g_e22_done_street_cleanup = true;
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task e22_objective()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_scarab_entry_begin, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(objective2_clear));
            await Engine.sleep_until(async () => this.g_e22_scarab_past_climb);
            Engine.wake(new ScriptMethodReference(objective3_set));
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task e22_dialogue()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_away_from_building, Engine.players()), 5, this._30_seconds);
            Engine.ai_play_line_on_object(default(IGameObject), "2000") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(75);
            Engine.activate_team_nav_point_flag(_default, player, e22_navpoint, 0F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_near_building, Engine.players()), 5, 450);
            if (!(Engine.volume_test_objects(tv_e22_near_building, Engine.players())))
            {
                Engine.ai_play_line_on_object(default(IGameObject), "2010") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task e22_dialogue_kill()
        {
            await Engine.sleep_until(async () => this.g_e23_started || Engine.volume_test_objects(tv_e22_main_begin, Engine.players()), 10);
            Engine.sleep_forever(new ScriptMethodReference(e22_dialogue));
            await Engine.sleep_until(async () => this.g_e23_started || Engine.volume_test_objects(tv_e22_doorway, Engine.players()), 10);
            Engine.deactivate_team_nav_point_flag(player, e22_navpoint);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task e22_mars_inf3_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_mars_inf3_begin, Engine.players()), 10);
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task e22_mars_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_begin_scarab_sequence, Engine.players()), 10);
            Engine.ai_place(e22_mars_inf2.Squad);
            Engine.ai_erase(e21_mars_pelican1.Squad);
            Engine.cs_run_command_script(e22_mars_inf2.marine0, cs_e22_mars_inf2_marine0);
            Engine.cs_run_command_script(e22_mars_inf2.marine1, cs_e22_mars_inf2_marine1);
            Engine.cs_run_command_script(e22_mars_inf2.marine2, cs_e22_mars_inf2_marine2);
            Engine.cs_run_command_script(e22_mars_inf2.marine3, cs_e22_mars_inf2_marine3);
            Engine.cs_run_command_script(e22_mars_inf2.marine4, cs_e22_mars_inf2_marine4);
        }

        [ScriptMethod(298, Lifecycle.Dormant)]
        public async Task e22_mars_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_begin_scarab_sequence, Engine.players()), 10);
            Engine.ai_place(e22_mars_inf1.lieutenant);
            Engine.ai_place(e22_mars_inf1.marine0);
            Engine.object_set_permutation(Engine.ai_get_object(e22_mars_inf1.lieutenant), "comm_pack", "on");
            await Engine.sleep_until(async () => this.g_e22_scarab_past_climb, 5);
            Engine.device_operates_automatically_set(e22_door1.Entity, true);
            Engine.device_operates_automatically_set(e22_door2.Entity, true);
            Engine.device_closes_automatically_set(e22_door1.Entity, false);
            Engine.device_closes_automatically_set(e22_door2.Entity, false);
            Engine.device_set_position(e22_door1.Entity, 1F);
            Engine.device_set_position(e22_door2.Entity, 1F);
            Engine.ai_place(e22_mars_inf1.marine1);
            if ((short)Engine.ai_living_count(e22_mars_inf1.lieutenant) <= 0)
            {
                Engine.cs_run_command_script(e22_mars_inf1.marine0, cs_e22_mars1_go);
                Engine.cs_run_command_script(e22_mars_inf0.perez, cs_e22_mars1_go);
            }
        }

        [ScriptMethod(299, Lifecycle.Dormant)]
        public async Task e22_mars_inf0_main()
        {
            Engine.device_set_position(e22_door0.Entity, 1F);
            Engine.device_operates_automatically_set(e22_door0.Entity, true);
            Engine.ai_place(e22_mars_inf0.perez);
            Engine.ai_place(e22_mars_inf0.guard0);
            Engine.ai_place(e22_mars_inf0.guard2);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_main_begin, Engine.players()), 15);
            Engine.ai_place(e22_mars_inf0.guard1);
            Engine.ai_place(e22_mars_inf0.medic0);
            Engine.ai_migrate(e21_mars_warthog0.Squad, e22_mars_inf0.Squad);
            Engine.ai_vehicle_exit(e22_mars_inf0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_stairwell, Engine.players()) || Engine.volume_test_objects(tv_e22_stairwell, Engine.ai_get_object(e22_mars_inf0.perez)), 15);
            Engine.ai_set_orders(e22_mars_inf0.Squad, e22_mars_inf0_advance1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_mars_inf3_begin, Engine.players()), 10);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e22_mars_inf0_visible, Engine.players())));
            Engine.ai_erase(e22_mars_inf0.guard0);
            Engine.ai_erase(e22_mars_inf0.guard1);
            Engine.ai_erase(e22_mars_inf0.guard2);
            Engine.ai_erase(e22_mars_inf0.medic0);
        }

        [ScriptMethod(300, Lifecycle.Dormant)]
        public async Task e22_mars_scorpions0_main()
        {
            await Engine.sleep_until(async () => this.g_e22_done_street_cleanup, 10);
            Engine.ai_place(e22_mars_scorpions0.Squad);
            Engine.cs_run_command_script(e22_mars_scorpions0.scorpion0, cs_e22_mars_scorpion0);
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task e22_main()
        {
            this.g_e22_started = true;
            Engine.print("e22_main");
            Engine.data_mine_set_mission_segment("e22_scarab_intro");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e23_main));
            Engine.wake(new ScriptMethodReference(music_03b_03_stop));
            Engine.wake(new ScriptMethodReference(e22_nasty_player_synch));
            Engine.wake(new ScriptMethodReference(e22_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e22_mars_inf1_main));
            Engine.wake(new ScriptMethodReference(e22_mars_inf2_main));
            Engine.wake(new ScriptMethodReference(e22_mars_inf3_main));
            Engine.wake(new ScriptMethodReference(e22_mars_scorpions0_main));
            Engine.wake(new ScriptMethodReference(e22_scarab));
            Engine.wake(new ScriptMethodReference(e22_objective));
            Engine.wake(new ScriptMethodReference(e22_dialogue));
            Engine.wake(new ScriptMethodReference(e22_dialogue_kill));
            await Engine.sleep_until(async () => this.g_e23_started);
            Engine.sleep_forever(new ScriptMethodReference(e22_nasty_player_synch));
            Engine.sleep_forever(new ScriptMethodReference(e22_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e22_mars_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e22_mars_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e22_mars_inf3_main));
            Engine.sleep_forever(new ScriptMethodReference(e22_mars_scorpions0_main));
            Engine.sleep_forever(new ScriptMethodReference(e22_dialogue));
        }

        [ScriptMethod(302, Lifecycle.Static)]
        public async Task test_scarab_intro()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e22_test);
            Engine.object_destroy(scarab.Entity);
            if (!(this.g_e22_started))
            {
                Engine.wake(new ScriptMethodReference(e22_main));
            }
        }

        [ScriptMethod(303, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_phantom0_bombard()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_definite);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e21_cov_bombard/p5")), 
                    async () => await Engine.sleep(120), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e21_cov_bombard/p6")), 
                    async () => await Engine.sleep(120), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e21_cov_bombard/p7")), 
                    async () => await Engine.sleep(120), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e21_cov_bombard/p8")), 
                    async () => await Engine.sleep(120));
                return false;
            });
        }

        [ScriptMethod(304, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_wraiths0_bombard()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e21_cov_bombard/p0")), 
                    async () => await Engine.sleep(60), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e21_cov_bombard/p1")), 
                    async () => await Engine.sleep(60), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e21_cov_bombard/p2")), 
                    async () => await Engine.sleep(60));
                return false;
            });
        }

        [ScriptMethod(305, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_abort_bombard()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_phantom1_entry()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_cov_phantom1_entry/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_cov_phantom1_entry/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e21_cov_phantom1_entry/p2"));
            await Engine.sleep(15);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e21_cov_phantom1_entry/p3"), 0.5F);
            await Engine.sleep(30);
            Engine.begin_random(async () => Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_sc01"), 
                async () => await Engine.sleep(15), 
                async () => Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_sc02"), 
                async () => await Engine.sleep(15));
            await Engine.sleep(15);
        }

        [ScriptMethod(307, Lifecycle.CommandScript)]
        public async Task cs_e21_cov_phantom_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_cov_phantom_exit/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e21_cov_phantom_exit/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e21_cov_phantom_exit/p2"), 0.5F);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(308, Lifecycle.CommandScript)]
        public async Task cs_e21_mars_pelican0_entry()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p1"), 0.5F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p1_facing"));
            Engine.sleep_forever();
        }

        [ScriptMethod(309, Lifecycle.CommandScript)]
        public async Task cs_e21_mars_pelican0_exit()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p3"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p4"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican0_entry/p5"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(310, Lifecycle.CommandScript)]
        public async Task cs_e21_mars_pelican1_entry()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p0_1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p0_2"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p1"), 0.5F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p1_facing"));
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "pelican_p");
            await Engine.sleep(180);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p1_facing"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p3"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p4"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_mars_pelican1_entry/p5"));
            Engine.object_destroy(Engine.ai_vehicle_get(this.ai_current_actor));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(311, Lifecycle.CommandScript)]
        public async Task cs_e21_mars_inf1_exit()
        {
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_mars_inf1/p0"));
            Engine.ai_erase(this.ai_current_actor);
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
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e21_boulevard1, Engine.players()), 15);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0690"));
            await Engine.sleep(10);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0700"));
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task e21_cov_creep0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e21_cov_creep0_main, Engine.players()) || Engine.volume_test_objects(tv_e21_cov_inf0_unsafe, Engine.players()), 15);
            Engine.ai_place(e21_cov_creep0.Squad);
        }

        [ScriptMethod(316, Lifecycle.Dormant)]
        public async Task e21_cov_phantom1_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e21_cov_wraiths0) <= 1, 30, this.two_minutes);
            Engine.ai_place(e21_cov_phantom1.Squad);
            Engine.ai_place(e21_cov_ghosts0_0.Squad);
            await Engine.sleep(2);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(e21_cov_phantom1.phantom0), "phantom_sc01", Engine.ai_vehicle_get_from_starting_location(e21_cov_ghosts0_0.ghost0));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(e21_cov_phantom1.phantom0), "phantom_sc02", Engine.ai_vehicle_get_from_starting_location(e21_cov_ghosts0_0.ghost1));
            Engine.cs_run_command_script(e21_cov_phantom1.phantom0, cs_e21_cov_phantom1_entry);
            await Engine.sleep_until(async () => Engine.object_get_health(Engine.ai_vehicle_get(e21_cov_phantom1.phantom0)) <= 0.05F || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e21_cov_phantom1.phantom0), "target_front") >= 3, 10, this.one_minute);
            this.g_e21_cov_phantom1_retreating = true;
            Engine.cs_run_command_script(e21_cov_phantom1.phantom0, cs_e21_cov_phantom_exit);
        }

        [ScriptMethod(317, Lifecycle.Dormant)]
        public async Task e21_cov_wraiths0_main()
        {
            Engine.ai_place(e21_cov_wraiths0_0.Squad);
            Engine.ai_place(e21_cov_wraiths0_1.Squad);
            await Engine.sleep(2);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(e21_cov_wraiths0_0.wraith0), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(e21_cov_wraiths0_1.wraith0), true);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e21_cov_wraiths0) <= 1 || Engine.volume_test_objects(tv_e21_cov_wraith0_2_unsafe, Engine.players()), 15);
            if (!(Engine.volume_test_objects(tv_e21_cov_wraith0_2_unsafe, Engine.players())))
            {
                Engine.ai_place(e21_cov_wraiths0_2.Squad, (short)Engine.pin(2F - (float)Engine.ai_living_count(e21_cov_wraiths0), 0F, 1F));
            }

            await Engine.sleep(2);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(e21_cov_wraiths0_2.wraith0), true);
            Engine.wake(new ScriptMethodReference(e21_cov_phantom1_main));
        }

        [ScriptMethod(318, Lifecycle.Dormant)]
        public async Task e21_cov_inf0_main()
        {
            Engine.ai_place(e21_cov_inf0.Squad);
        }

        [ScriptMethod(319, Lifecycle.Dormant)]
        public async Task e21_mars_pelican1_main()
        {
            await Engine.sleep_until(async () => this.g_e21_cov_phantom1_retreating);
            await Engine.sleep(60);
            Engine.ai_place(e21_mars_pelican1.Squad);
            Engine.cs_run_command_script(e21_mars_pelican1.pelican0, cs_e21_mars_pelican1_entry);
        }

        [ScriptMethod(320, Lifecycle.Dormant)]
        public async Task e21_mars_pelican0_main()
        {
            await Engine.sleep_until(async () => this.g_e21_cov_phantom1_retreating);
            Engine.ai_place(e21_mars_pelican0.pelican0);
            Engine.cs_run_command_script(e21_mars_pelican0.pelican0, cs_e21_mars_pelican0_entry);
            Engine.ai_place(e21_mars_pelican0.scorpion0);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get(e21_mars_pelican0.pelican0), "pelican_lc", Engine.ai_vehicle_get_from_starting_location(e21_mars_pelican0.scorpion0));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e22_begin_scarab_sequence, Engine.players()), 15);
            Engine.cs_run_command_script(e21_mars_pelican0.pelican0, cs_e21_mars_pelican0_exit);
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task e21_mars_warthog0_main()
        {
            Engine.ai_migrate(e20_mars_warthog0.Squad, e21_mars_warthog0.Squad);
            Engine.ai_migrate(e20_mars_warthog1.Squad, e21_mars_warthog0.Squad);
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task e21_mars_inf1_main()
        {
            await Engine.sleep_until(async () => this.g_e21_cov_phantom0_retreating, 15);
            Engine.ai_place(e21_mars_inf1.Squad);
            Engine.ai_disregard(Engine.ai_actors(e21_mars_inf1.Squad), true);
            await Engine.sleep_until(async () => this.g_e22_started);
            Engine.cs_run_command_script(e21_mars_inf1.Squad, cs_e21_mars_inf1_exit);
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task e21_mars_inf0_main()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e21_mars_inf0.Squad) < 2 && (short)Engine.ai_spawn_count(e21_mars_inf0.Squad) < 10 && !(Engine.volume_test_objects(tv_e21_mars_inf0_unsafe, Engine.players())))
                {
                    Engine.ai_place(e21_mars_inf0.Squad, 1);
                }

                return (short)Engine.ai_spawn_count(e21_mars_inf0.Squad) >= 10 || this.g_e22_started;
            });
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task e21_main_end_condition()
        {
            await Engine.sleep_until(async () => this.g_e21_cov_phantom1_retreating);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e21_cov_ghosts0) <= 0 && (short)Engine.ai_living_count(e21_cov_wraiths0) <= 0, 30, this.one_minute);
            Engine.wake(new ScriptMethodReference(e22_main));
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task e21_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e21_main_begin, Engine.players()), 15);
            this.g_e21_started = true;
            Engine.print("e21_main");
            Engine.data_mine_set_mission_segment("e21_hospital_seige");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e21_main_end_condition));
            Engine.wake(new ScriptMethodReference(e21_mars_warthog0_main));
            Engine.wake(new ScriptMethodReference(e21_mars_pelican0_main));
            Engine.wake(new ScriptMethodReference(e21_mars_pelican1_main));
            Engine.wake(new ScriptMethodReference(e21_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e21_cov_wraiths0_main));
            Engine.wake(new ScriptMethodReference(e21_dialog));
            await Engine.sleep_until(async () => this.g_e22_started);
            Engine.sleep_forever(new ScriptMethodReference(e21_mars_warthog0_main));
            Engine.sleep_forever(new ScriptMethodReference(e21_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e21_mars_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e21_cov_creep0_main));
            Engine.sleep_forever(new ScriptMethodReference(e21_cov_wraiths0_main));
            Engine.sleep_forever(new ScriptMethodReference(e21_cov_phantom1_main));
            Engine.sleep_forever(new ScriptMethodReference(e21_dialog));
            Engine.ai_disposable(e21_cov, true);
            Engine.ai_disposable(e21_cov_phantom0.Squad, false);
            Engine.ai_disposable(e21_cov_phantom1.Squad, false);
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task test_hospital_seige()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e21_test);
            Engine.object_destroy(scarab.Entity);
            Engine.ai_place(e21_mars_warthog0.Squad);
            if (!(this.g_e21_started))
            {
                Engine.wake(new ScriptMethodReference(e21_main));
            }
        }

        [ScriptMethod(327, Lifecycle.Dormant)]
        public async Task e20_cov_ghosts0_main()
        {
            Engine.ai_migrate(e19_cov_ghosts0, e20_cov_ghosts0.Squad);
            Engine.ai_place(e20_cov_ghosts0.Squad);
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task e20_mars_warthog1_main()
        {
            Engine.ai_place(e20_mars_warthog1.Squad);
            if ((short)Engine.ai_living_count(e20_mars_warthog0.Squad) > 1)
            {
                Engine.ai_erase(e20_mars_warthog1.spare);
            }
        }

        [ScriptMethod(329, Lifecycle.Dormant)]
        public async Task e20_mars_warthog0_main()
        {
            Engine.ai_migrate(e19_mars_warthog0.Squad, e20_mars_warthog0.Squad);
            Engine.wake(new ScriptMethodReference(e20_mars_warthog1_main));
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task e20_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e20_main_begin, Engine.players()), 15);
            this.g_e20_started = true;
            Engine.print("e20_main");
            Engine.data_mine_set_mission_segment("e20_road_skirmish");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_03b_03_start));
            Engine.wake(new ScriptMethodReference(e20_mars_warthog0_main));
            Engine.wake(new ScriptMethodReference(e20_cov_ghosts0_main));
            await Engine.sleep_until(async () => this.g_e21_started);
            Engine.ai_disposable(e20_cov, true);
        }

        [ScriptMethod(331, Lifecycle.Static)]
        public async Task test_road_skirmishes()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e20_test);
            Engine.object_destroy(scarab.Entity);
            Engine.ai_place(e20_mars_warthog0.Squad);
            Engine.wake(new ScriptMethodReference(e20_main));
            Engine.wake(new ScriptMethodReference(e21_main));
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task cs_e19_cov_ghosts0_1_entry1()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e19_cov_ghosts0_1/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e19_cov_ghosts0_1/p3"));
            await Engine.sleep(60);
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task cs_e19_cov_ghosts0_1_entry0()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e19_cov_ghosts0_1/p0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e19_cov_ghosts0_1/p1"));
            await Engine.sleep(60);
        }

        [ScriptMethod(334, Lifecycle.Dormant)]
        public async Task e19_cov_ghosts0_main()
        {
            Engine.ai_migrate(e18_cov_ghosts0.Squad, e19_cov_ghosts0_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e19_player_advanced, Engine.players()), 15);
            Engine.ai_place(e19_cov_ghosts0_0.Squad);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e19_cov_ghosts0) <= 0)
                {
                    await Engine.sleep(300);
                    await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e19_cov_ghosts0_1_unsafe, Engine.players())));
                    Engine.ai_place(e19_cov_ghosts0_1.Squad);
                }

                return (short)Engine.ai_spawn_count(e19_cov_ghosts0) >= 6;
            });
        }

        [ScriptMethod(335, Lifecycle.Dormant)]
        public async Task e19_cov_wraiths0_main()
        {
            Engine.ai_place(e19_cov_wraiths0_0.Squad);
        }

        [ScriptMethod(336, Lifecycle.Dormant)]
        public async Task e19_cov_inf0_main()
        {
            Engine.ai_place(e19_cov_inf0.Squad);
        }

        [ScriptMethod(337, Lifecycle.Dormant)]
        public async Task e19_mars_inf0_main()
        {
            Engine.ai_migrate(e18_mars_inf0.Squad, e19_mars_warthog0.Squad);
            Engine.ai_migrate(e18_mars_warthog0.Squad, e19_mars_warthog0.Squad);
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task e19_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e19_main_begin0, Engine.players()) || Engine.volume_test_objects(tv_e19_main_begin1, Engine.players()), 15);
            this.g_e19_started = true;
            Engine.print("e19_main");
            Engine.data_mine_set_mission_segment("e19_park");
            Engine.game_save();
            Engine.object_create_anew(e19_tree0);
            Engine.object_create_anew(e19_tree1);
            Engine.wake(new ScriptMethodReference(e19_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e19_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e19_cov_wraiths0_main));
            Engine.wake(new ScriptMethodReference(e19_cov_ghosts0_main));
            await Engine.sleep_until(async () => this.g_e20_started);
            Engine.sleep_forever(new ScriptMethodReference(e19_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e19_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e19_cov_wraiths0_main));
            Engine.sleep_forever(new ScriptMethodReference(e19_cov_ghosts0_main));
            Engine.ai_disposable(e19_cov, true);
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task cs_e18_mars_warthog0_orbit()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p4"), Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p5"));
                Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p5"), Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p6"));
                Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p6"), Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p0"));
                Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p0"), Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p1"));
                Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p1"), Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p2"));
                Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p2"), Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p3"));
                Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p3"), Engine.GetReference<ISpatialPoint>("e18_mars_warthog0_orbit/p4"));
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get(this.ai_current_actor), "warthog_g", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get(this.ai_current_actor), "warthog_p", Engine.players()))
                {
                    this.g_e18_orbit_count = (short)(this.g_e18_orbit_count + 1);
                }

                return this.g_e19_started || (short)Engine.ai_living_count(e18_cov_inf1_1.Squad) <= 0 || this.g_e18_orbit_count >= 2;
            }, 1);
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task cs_e18_mars_warthog0_approach0()
        {
            Engine.cs_approach_player(5F, 50F, 50F);
            if (!(this.g_e18_mars_warthog0_spoke))
            {
                Engine.ai_play_line_at_player(this.ai_current_actor, "8000") // Couldn't generate cast from 'Short' to 'Void'
                ;
                Engine.print("could use a gunner, sir!");
                this.g_e18_mars_warthog0_spoke = true;
            }

            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.ai_actors(e18_mars_warthog0.warthog0), await this.player0()) > 7F || Engine.unit_in_vehicle(Engine.unit(await this.player0())), 15, 600);
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task cs_e18_mars_warthog0_approach1()
        {
            Engine.cs_approach_player(5F, 50F, 50F);
            if (!(this.g_e18_mars_warthog0_spoke))
            {
                Engine.ai_play_line_at_player(this.ai_current_actor, "8000") // Couldn't generate cast from 'Short' to 'Void'
                ;
                Engine.print("could use a gunner, sir!");
                this.g_e18_mars_warthog0_spoke = true;
            }

            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.ai_actors(e18_mars_warthog0.warthog0), await this.player1()) > 7F || Engine.unit_in_vehicle(Engine.unit(await this.player1())), 15, 600);
        }

        [ScriptMethod(342, Lifecycle.CommandScript)]
        public async Task cs_e18_mars_warthog0_abort()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task cs_e18_cov_inf0_sniper0()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_dangerous);
            Engine.cs_aim_object(true, Engine.ai_vehicle_get(e18_mars_warthog0.warthog0));
            Engine.sleep_forever();
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task cs_e18_cov_inf2_1_entry0()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e18_cov_inf2_entry/p0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e18_cov_inf2_entry/p1"));
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task e18_scarab_main()
        {
            Engine.object_create_anew(scarab);
            Engine.object_teleport(scarab.Entity, e18_scarab_start);
            Engine.pvs_set_object(scarab.Entity);
            await Engine.sleep_until(async () =>
            {
                Engine.device_set_position_track(scarab.Entity, "park_idle", 0F);
                Engine.device_animate_position(scarab.Entity, 1F, 119F / 30F, 0F, 0F, true);
                await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
                return Engine.volume_test_objects(tv_e19_scarab_withdraws, Engine.players());
            }, 1, this._30_seconds);
            Engine.device_set_position_track(scarab.Entity, "park_exit", 0F);
            Engine.device_animate_position(scarab.Entity, 1F, 831F / 30F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
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
            Engine.object_destroy(scarab.Entity);
        }

        [ScriptMethod(346, Lifecycle.Dormant)]
        public async Task e18_cov_ghosts0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e18_cov_inf1_1.Squad) <= 0 || Engine.volume_test_objects(tv_e19_main_begin1, Engine.players()));
            if (!(Engine.volume_test_objects(tv_e19_main_begin1, Engine.players())))
            {
                Engine.ai_place(e18_cov_ghosts0.Squad);
            }
        }

        [ScriptMethod(347, Lifecycle.Static)]
        public async Task e18_cov_inf2_spawn()
        {
            if (Engine.volume_test_objects(tv_e18_second_half, Engine.players()))
            {
                if (!(Engine.volume_test_objects(tv_e18_cov_inf2_1_unsafe1, Engine.players())))
                {
                    Engine.ai_place(e18_cov_inf2_1.sniper1);
                }

                if (!(Engine.volume_test_objects(tv_e18_cov_inf2_1_unsafe0, Engine.players())))
                {
                    Engine.ai_place(e18_cov_inf2_1.sniper0);
                }
            }
        }

        [ScriptMethod(348, Lifecycle.Dormant)]
        public async Task e18_cov_inf2_main()
        {
            Engine.ai_place(e18_cov_inf2_0.Squad);
            if (await this.difficulty_heroic())
            {
                this.g_e18_cov_inf2_spawn_max = 8;
            }

            if (await this.difficulty_legendary())
            {
                this.g_e18_cov_inf2_spawn_max = 12;
            }

            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e18_cov_inf2) < 1 || (short)Engine.ai_living_count(e18_cov_inf1) < 5 && (short)Engine.ai_living_count(e18_cov_inf2) < 2 || await this.difficulty_legendary() && (short)Engine.ai_living_count(e18_cov_inf1) < 4 && (short)Engine.ai_living_count(e18_cov_inf2) < 2)
                {
                    await this.e18_cov_inf2_spawn();
                    await Engine.sleep((short)Engine.random_range(60, 300));
                }

                return (short)Engine.ai_spawn_count(e18_cov_inf2) >= this.g_e18_cov_inf2_spawn_max;
            });
        }

        [ScriptMethod(349, Lifecycle.Dormant)]
        public async Task e18_cov_inf1_main()
        {
            Engine.ai_place(e18_cov_inf1);
        }

        [ScriptMethod(350, Lifecycle.Dormant)]
        public async Task e18_cov_inf0_main()
        {
            Engine.ai_place(e18_cov_inf0.Squad);
        }

        [ScriptMethod(351, Lifecycle.Dormant)]
        public async Task e18_mars_warthog0_main()
        {
            Engine.ai_place(e18_mars_warthog0.Squad);
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.ai_actors(e18_mars_warthog0.warthog0), await this.player0()) < 6F && !(Engine.unit_in_vehicle(Engine.unit(await this.player0()))))
                {
                    Engine.cs_stack_command_script(e18_mars_warthog0.warthog0, cs_e18_mars_warthog0_approach0);
                    await Engine.sleep_until(async () => !(Engine.unit_in_vehicle(Engine.ai_get_unit(e18_mars_warthog0.warthog0))), 30, 900);
                }
                else if ((bool)Engine.game_is_cooperative() && Engine.objects_distance_to_object(Engine.ai_actors(e18_mars_warthog0.warthog0), await this.player1()) < 6F && !(Engine.unit_in_vehicle(Engine.unit(await this.player1()))))
                {
                    Engine.cs_stack_command_script(e18_mars_warthog0.warthog0, cs_e18_mars_warthog0_approach1);
                    await Engine.sleep_until(async () => !(Engine.unit_in_vehicle(Engine.ai_get_unit(e18_mars_warthog0.warthog0))), 30, 900);
                }

                return !(Engine.unit_in_vehicle(Engine.ai_get_unit(e18_mars_warthog0.warthog0)));
            }, 15);
            Engine.print("omg?");
            Engine.cs_run_command_script(e18_mars_warthog0.warthog0, cs_e18_mars_warthog0_abort);
        }

        [ScriptMethod(352, Lifecycle.Dormant)]
        public async Task e18_mars_inf0_main()
        {
            Engine.ai_migrate(e17_mars_inf0.Squad, e18_mars_inf0.Squad);
        }

        [ScriptMethod(353, Lifecycle.Dormant)]
        public async Task e18_key()
        {
            if (!(await this.difficulty_legendary()))
            {
                Engine.sleep_forever();
            }

            Engine.object_create(key);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4219345360U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4219345360U)));
            Engine.ice_cream_flavor_stock(9);
        }

        [ScriptMethod(354, Lifecycle.Dormant)]
        public async Task e18_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e18_main_begin, Engine.players()), 15);
            this.g_e18_started = true;
            Engine.print("e18_main");
            Engine.data_mine_set_mission_segment("e18_park");
            Engine.game_save();
            Engine.kill_volume_enable(kill_e18_0);
            Engine.object_destroy(e19_tree0.Entity);
            Engine.object_destroy(e19_tree1.Entity);
            Engine.wake(new ScriptMethodReference(chapter_title1));
            Engine.wake(new ScriptMethodReference(objective1_clear));
            Engine.wake(new ScriptMethodReference(objective2_set));
            Engine.wake(new ScriptMethodReference(e19_main));
            Engine.wake(new ScriptMethodReference(e20_main));
            Engine.wake(new ScriptMethodReference(e21_main));
            Engine.wake(new ScriptMethodReference(e18_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e18_mars_warthog0_main));
            Engine.wake(new ScriptMethodReference(e18_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e18_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e18_cov_inf2_main));
            Engine.wake(new ScriptMethodReference(e18_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e18_scarab_main));
            Engine.wake(new ScriptMethodReference(e18_key));
            await Engine.sleep_until(async () => this.g_e19_started);
            Engine.sleep_forever(new ScriptMethodReference(e18_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e18_mars_warthog0_main));
            Engine.sleep_forever(new ScriptMethodReference(e18_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e18_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e18_cov_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e18_cov_ghosts0_main));
            Engine.ai_disposable(e18_cov, true);
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task test_park()
        {
            Engine.switch_bsp(1);
            Engine.object_teleport(await this.player0(), e18_test);
            Engine.ai_place(e18_mars_inf0.Squad);
            if (!(this.g_e18_started))
            {
                Engine.wake(new ScriptMethodReference(e18_main));
            }
        }

        [ScriptMethod(356, Lifecycle.CommandScript)]
        public async Task cs_e17_mars_inf0_drive()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.object_cannot_die(Engine.ai_get_object(e17_mars_inf0.warthog0), true);
            Engine.object_cannot_die(Engine.ai_get_object(e17_mars_inf0.passenger0), true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e17_mars_inf0_entry/p0"));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 13F || Engine.volume_test_objects(tv_e17_near_first_wall, Engine.players()), 15, this.one_minute);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4166391464U), Engine.ai_vehicle_get(this.ai_current_actor), 1.5F);
            await Engine.sleep(5);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4166391464U));
            await Engine.sleep(5);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4166391464U), Engine.ai_vehicle_get(this.ai_current_actor), 1.5F);
            await Engine.sleep(15);
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\vehicles\\warthog\\warthog_horn\\warthog_horn", 4166391464U));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 10F || (float)Engine.ai_strength(this.ai_current_actor) <= 0.5F || (float)Engine.ai_strength(this.ai_current_squad) <= 0.75F || Engine.volume_test_objects(tv_e17_first_wall_approach, Engine.players()), 15, 600);
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e17_mars_inf0_entry/p0_1"), Engine.GetReference<ISpatialPoint>("e17_mars_inf0_entry/p1"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e17_mars_inf0_entry/p1"));
            this.g_e17_mars_warthog0_arrived = true;
            await Engine.sleep(20);
            Engine.object_cannot_die(Engine.ai_get_object(e17_mars_inf0.warthog0), false);
            Engine.object_cannot_die(Engine.ai_get_object(e17_mars_inf0.passenger0), false);
            Engine.ai_vehicle_exit(e17_mars_inf0.warthog0);
            Engine.ai_vehicle_exit(e17_mars_inf0.passenger0);
        }

        [ScriptMethod(357, Lifecycle.CommandScript)]
        public async Task cs_e17_shotgun_scene()
        {
            Engine.print("marine: hey, sir!");
            Engine.cs_approach_player(1F, 10F, 15F);
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0640"));
            await Engine.sleep_until(async () => !(Engine.unit_has_weapon(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\shotgun\\shotgun.weapon", 4216396195U))) || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 5F, 15, this.one_minute);
        }

        [ScriptMethod(358, Lifecycle.CommandScript)]
        public async Task cs_e17_cov_inf0_0_turret0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("e17_turrets/p0"));
        }

        [ScriptMethod(359, Lifecycle.CommandScript)]
        public async Task cs_e17_cov_ghost0_entry0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p0"));
            await Engine.sleep(30);
            Engine.cs_vehicle_boost(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p0"), 0.1F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p1"));
            await Engine.sleep(60);
            Engine.cs_vehicle_boost(true);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p1"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e17_cov_ghost0_entry/p1"));
            await Engine.sleep(30);
            Engine.cs_vehicle_boost(false);
        }

        [ScriptMethod(360, Lifecycle.CommandScript)]
        public async Task cs_e17_mars_selective_migrate()
        {
            if (Engine.unit_in_vehicle(Engine.ai_get_unit(this.ai_current_actor)) && Engine.volume_test_object(tv_e17_migration_area, Engine.ai_get_object(this.ai_current_actor)) && (short)Engine.ai_living_count(e17_mars_inf0.Squad) <= 2)
            {
                Engine.ai_migrate(this.ai_current_actor, e17_mars_inf0.Squad);
            }
        }

        [ScriptMethod(361, Lifecycle.CommandScript)]
        public async Task cs_e17_cov_inf0_2_ambush()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_dangerous);
            Engine.cs_abort_on_damage(true);
            Engine.cs_crouch(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () => Engine.volume_test_object(tv_e17_section3, Engine.ai_get_object(this.ai_current_actor)) || (float)Engine.ai_strength(this.ai_current_squad) < 1F, 10);
        }

        [ScriptMethod(362, Lifecycle.Static)]
        public async Task<bool> e17_door0_open()
        {
            return Engine.device_get_position(e17_door0.Entity) >= 0.5F;
        }

        [ScriptMethod(363, Lifecycle.Static)]
        public async Task<bool> e17_door1_open()
        {
            return Engine.device_get_position(e17_door1.Entity) >= 0.5F;
        }

        [ScriptMethod(364, Lifecycle.Static)]
        public async Task<bool> e17_mars_warthog0_can_wait()
        {
            return this.g_e17_mars_warthog0_arrived || Engine.volume_test_objects(tv_e17_on_first_wall, Engine.players());
        }

        [ScriptMethod(365, Lifecycle.Dormant)]
        public async Task e17_doors_main()
        {
            Engine.device_set_position(e17_door1.Entity, 1F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_section2, Engine.players()), 15);
            Engine.device_set_position(e17_door0.Entity, 1F);
        }

        [ScriptMethod(366, Lifecycle.Dormant)]
        public async Task e17_shotgun_scene()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("e17_shotgun_scene", cs_e17_shotgun_scene, e17_mars_inf0.passenger0), 5, this.two_minutes);
        }

        [ScriptMethod(367, Lifecycle.Dormant)]
        public async Task e17_dialog()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_on_first_wall, Engine.players()), 15);
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0650"));
            await Engine.sleep(20);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_section0, Engine.players()), 15);
            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save(), 30, this.one_minute);
            Engine.ai_play_line_on_object(default(IGameObject), "0660") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(368, Lifecycle.Dormant)]
        public async Task e17_cov_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_near_first_wall, Engine.players()), 15);
            Engine.ai_place(e17_cov_inf2_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_cov_inf2_1_begin, Engine.players()), 15);
            Engine.ai_place(e17_cov_inf2_1.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_section2, Engine.players()), 15);
            Engine.ai_place(e17_cov_inf2_2.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_section3, Engine.players()), 15);
            Engine.ai_place(e17_cov_inf2_3.Squad, (short)Engine.pin(3F - (float)Engine.ai_living_count(e17_cov_inf2), 0F, 1F));
        }

        [ScriptMethod(369, Lifecycle.Dormant)]
        public async Task e17_cov_inf1_main()
        {
            Engine.ai_place(e17_cov_inf1_0.Squad);
        }

        [ScriptMethod(370, Lifecycle.Dormant)]
        public async Task e17_cov_inf0_aux()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_cov_inf0_2_init, Engine.players()), 15);
            Engine.ai_place(e17_cov_inf0_2.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_near_second_wall, Engine.players()), 15);
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(e17_cov_inf0_3.Squad);
            }
        }

        [ScriptMethod(371, Lifecycle.Dormant)]
        public async Task e17_cov_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_near_first_wall, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e17_cov_inf0_aux));
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_03b_02_stop));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_on_first_wall, Engine.players()), 15);
            Engine.ai_place(e17_cov_inf0_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_section1, Engine.players()), 15);
            if ((short)Engine.ai_living_count(e17_cov_inf0) <= 4)
            {
                Engine.ai_place(e17_cov_inf0_1.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_section2, Engine.players()), 15);
            Engine.game_save();
            await Engine.sleep(30);
            if ((short)Engine.ai_living_count(e17_cov_inf0) <= 4)
            {
                Engine.ai_place(e17_cov_inf0_1.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_section3, Engine.players()), 15);
            if ((short)Engine.ai_living_count(e17_cov_inf0) <= 4)
            {
                Engine.ai_place(e17_cov_inf0_1.Squad);
            }
        }

        [ScriptMethod(372, Lifecycle.Dormant)]
        public async Task e17_mars_inf0_main()
        {
            Engine.cs_run_command_script(e16_mars_inf0.Squad, cs_e17_mars_selective_migrate);
            await Engine.sleep(15);
            Engine.ai_place(e17_mars_inf0.Squad);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(e17_mars_inf0.warthog0), true);
            Engine.ai_disposable(e16_mars, true);
            Engine.wake(new ScriptMethodReference(e17_shotgun_scene));
        }

        [ScriptMethod(373, Lifecycle.Dormant)]
        public async Task e17_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e17_main_begin, Engine.players()), 15);
            this.g_e17_started = true;
            Engine.print("e17_main");
            Engine.data_mine_set_mission_segment("e17_flooded_tunnel");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(objective0_clear));
            Engine.wake(new ScriptMethodReference(objective1_set));
            Engine.wake(new ScriptMethodReference(e17_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e17_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e17_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e17_cov_inf2_main));
            Engine.wake(new ScriptMethodReference(e17_doors_main));
            await Engine.sleep_until(async () => this.g_e18_started);
            Engine.sleep_forever(new ScriptMethodReference(e17_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e17_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e17_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e17_cov_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e17_doors_main));
            Engine.sleep_forever(new ScriptMethodReference(e17_dialog));
            Engine.ai_disposable(e17_cov, true);
        }

        [ScriptMethod(374, Lifecycle.Static)]
        public async Task test_flooded_tunnel()
        {
            Engine.object_teleport(await this.player0(), e17_test);
            Engine.object_create(e17_test_tank);
            if (!(this.g_e17_started))
            {
                Engine.wake(new ScriptMethodReference(e17_main));
            }

            if (!(this.g_e18_started))
            {
                Engine.wake(new ScriptMethodReference(e18_main));
            }
        }

        [ScriptMethod(375, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_ghosts0_advance1()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/start"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p5"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p6"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p7"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p8"));
        }

        [ScriptMethod(376, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_ghosts0_advance0()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/start"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p1"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e16_cov_ghosts0_advance/p4"));
        }

        [ScriptMethod(377, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_banshee_boost0()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e16_cov_banshees0/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e16_cov_banshees0/p1"));
            await Engine.sleep((short)Engine.random_range(30, 60));
        }

        [ScriptMethod(378, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_banshee_boost1()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e16_cov_banshees0/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e16_cov_banshees0/p3"));
            await Engine.sleep((short)Engine.random_range(30, 60));
        }

        [ScriptMethod(379, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_inf0_last_stand()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_face_player(true);
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 12F || (float)Engine.ai_strength(this.ai_current_actor) <= 0.9F || (float)Engine.ai_strength(this.ai_current_squad) <= 0.5F);
        }

        [ScriptMethod(380, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_phantom0_entry()
        {
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(135);
        }

        [ScriptMethod(381, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_phantom0_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e16_cov_phantom0/p0"), Engine.GetReference<ISpatialPoint>("e16_cov_phantom0/p1"), 1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e16_cov_phantom0/p1"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e16_cov_phantom0/p2"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(382, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_wraiths1_entry()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(180);
        }

        [ScriptMethod(383, Lifecycle.CommandScript)]
        public async Task cs_e16_cov_ghosts1_entry()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(150);
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task e16_cov_phantom0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e16_cov_wraiths1.Squad) <= 0);
            Engine.ai_place(e16_cov_phantom0.Squad);
            await Engine.sleep_until(async () => Engine.object_get_health(Engine.ai_vehicle_get(e16_cov_phantom0.phantom0)) <= 0.05F || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e16_cov_phantom0.phantom0), "target_front") >= 2, 30);
            Engine.cs_run_command_script(e16_cov_phantom0.phantom0, cs_e16_cov_phantom0_exit);
        }

        [ScriptMethod(385, Lifecycle.Dormant)]
        public async Task e16_cov_wraiths1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e16_toll_plaza, Engine.players()) || (float)Engine.ai_living_count(e16_cov_ghosts1.Squad) + (float)Engine.ai_living_count(e16_cov_banshees0) <= 1F);
            Engine.ai_place(e16_cov_wraiths1.Squad);
        }

        [ScriptMethod(386, Lifecycle.Dormant)]
        public async Task e16_cov_ghosts1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e16_toll_plaza, Engine.players()) || (short)Engine.ai_living_count(e16_cov_banshees0) <= 1);
            Engine.ai_place(e16_cov_ghosts1.Squad, (short)(3 - (float)Engine.ai_living_count(e16_cov_ghosts0)));
        }

        [ScriptMethod(387, Lifecycle.Dormant)]
        public async Task e16_cov_banshees0_main()
        {
            Engine.ai_migrate(e15_cov_banshees0.Squad, e16_cov_banshees0_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e16_bridge_end, Engine.players()), 15);
            Engine.ai_place(e16_cov_banshees0_1.Squad, (short)(3 - (float)Engine.ai_living_count(e16_cov_banshees0)));
            await Engine.sleep(150);
            Engine.ai_play_line_on_object(default(IGameObject), "0620") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.wake(new ScriptMethodReference(music_03b_01_start_alt));
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e16_cov_ghosts1_main));
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e16_cov_ghosts1.Squad) > 0 && (float)Engine.ai_living_count(e16_cov_ghosts1.Squad) + (float)Engine.ai_living_count(e16_cov_banshees0) <= 1F);
            Engine.game_save();
            Engine.ai_place(e16_cov_banshees0_1.Squad);
            Engine.wake(new ScriptMethodReference(e16_cov_wraiths1_main));
        }

        [ScriptMethod(388, Lifecycle.Dormant)]
        public async Task e16_cov_ghosts0_main()
        {
            Engine.ai_place(e16_cov_ghosts0_0.Squad);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e16_cov_wraiths0) <= 0 && (short)Engine.ai_living_count(e16_cov_ghosts0) < 4 || (short)Engine.ai_living_count(e16_cov_ghosts0) < 3)
                {
                    Engine.ai_place(e16_cov_ghosts0_1.Squad, 1);
                }

                return Engine.volume_test_objects(tv_e16_bridge_end, Engine.players()) || (short)Engine.ai_spawn_count(e16_cov_ghosts0) >= 10;
            }, 90);
            Engine.game_save();
        }

        [ScriptMethod(389, Lifecycle.Dormant)]
        public async Task e16_cov_wraiths0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e16_cov_wraiths0) > 0);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e16_toll_plaza, Engine.players()) || (short)Engine.ai_living_count(e16_cov_wraiths0_0.Squad) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(390, Lifecycle.Dormant)]
        public async Task e16_cov_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e16_tunnel, Engine.players()), 15);
            Engine.game_save();
            await Engine.sleep(15);
            Engine.wake(new ScriptMethodReference(music_03b_01_stop));
            Engine.wake(new ScriptMethodReference(music_03b_02_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e16_cov_inf0_1_begin, Engine.players()), 15);
            Engine.ai_place(e16_cov_inf0_1.Squad, (short)Engine.pin(9F - (float)Engine.ai_living_count(e16_cov_inf0), 0F, 2F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e16_cov_inf0_2_begin, Engine.players()), 15);
            Engine.ai_place(e16_cov_inf0_2.Squad, (short)Engine.pin(9F - (float)Engine.ai_living_count(e16_cov_inf0), 0F, 1F));
        }

        [ScriptMethod(391, Lifecycle.Dormant)]
        public async Task e16_mars_inf0_main()
        {
            Engine.ai_migrate(e15_mars_inf0.Squad, e16_mars_inf0.Squad);
        }

        [ScriptMethod(392, Lifecycle.Dormant)]
        public async Task e16_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e16_main_begin, Engine.players()), 15);
            this.g_e16_started = true;
            Engine.print("e16_main");
            Engine.data_mine_set_mission_segment("e16_bridge_descent");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e16_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e16_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e16_cov_wraiths0_main));
            Engine.wake(new ScriptMethodReference(e16_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e16_cov_banshees0_main));
            await Engine.sleep_until(async () => this.g_e17_started);
            Engine.sleep_forever(new ScriptMethodReference(e16_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e16_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e16_cov_wraiths0_main));
            Engine.sleep_forever(new ScriptMethodReference(e16_cov_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e16_cov_wraiths1_main));
            Engine.sleep_forever(new ScriptMethodReference(e16_cov_ghosts1_main));
            Engine.sleep_forever(new ScriptMethodReference(e16_cov_banshees0_main));
            Engine.ai_disposable(e16_cov, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.ai_erase(e16_mars);
            Engine.ai_erase(e16_cov);
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task test_bridge_descent()
        {
            Engine.object_teleport(await this.player0(), e16_test);
            Engine.ai_place(e16_mars_inf0.Squad);
            if (!(this.g_e16_started))
            {
                Engine.wake(new ScriptMethodReference(e16_main));
            }

            if (!(this.g_e17_started))
            {
                Engine.wake(new ScriptMethodReference(e17_main));
            }

            if (!(this.g_e18_started))
            {
                Engine.wake(new ScriptMethodReference(e18_main));
            }
        }

        [ScriptMethod(394, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom0_1_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p0"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p2"));
        }

        [ScriptMethod(395, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom0_1_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            if ((short)Engine.ai_living_count(e16_cov_wraiths0_0.wraith1) > 0)
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p4"));
                Engine.cs_face_player(true);
                Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p5"), 1F);
                Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p6"), 0.5F);
                if (!(Engine.volume_test_objects(tv_e15_phantom_drop_zone1, Engine.players())))
                {
                    await Engine.sleep(75);
                    Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_lc");
                    await Engine.sleep(20);
                }

                Engine.cs_face_player(false);
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p5"), 1F);
                Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p7_1"), Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p8"));
            }
            else
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p7"));
            }

            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p8"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p8"), Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p9"), 1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_1_entry/p9"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(396, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom0_0_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p0"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p2"));
        }

        [ScriptMethod(397, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom0_0_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            if ((short)Engine.ai_living_count(e16_cov_wraiths0_0.wraith0) > 0)
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p4"));
                Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p5"), 1F);
                Engine.cs_face_player(true);
                Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p6"), 0.5F);
                if (!(Engine.volume_test_objects(tv_e15_phantom_drop_zone0, Engine.players())))
                {
                    await Engine.sleep(75);
                    Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_lc");
                    await Engine.sleep(20);
                }

                Engine.cs_face_player(false);
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p5"), 1F);
                Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p7"), Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p8"), 1F);
            }

            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p3"), Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p8"), 0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p8"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p8"), Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p9"), 1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_cov_phantom0_0_entry/p9"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(398, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_phantom1_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_overflights/p0"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(399, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_banshee0_0_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_overflights/p1"));
        }

        [ScriptMethod(400, Lifecycle.CommandScript)]
        public async Task cs_e15_cov_banshee0_1_entry()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e15_overflights/p2"));
        }

        [ScriptMethod(401, Lifecycle.CommandScript)]
        public async Task cs_e15_mars_inf0_unload()
        {
            if ((short)Engine.ai_living_count(e15_mars_inf0.Squad) > 1 && !(Engine.unit_has_weapon(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<BaseTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher.weapon", 4213709178U))))
            {
                await Engine.sleep(30);
                Engine.ai_vehicle_exit(this.ai_current_actor);
            }
        }

        [ScriptMethod(402, Lifecycle.CommandScript)]
        public async Task cs_e15_mars_inf0_init()
        {
            Engine.cs_enable_targeting(true);
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => this.g_e16_started || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 8F, 15);
        }

        [ScriptMethod(403, Lifecycle.CommandScript)]
        public async Task cs_e15_mars_inf0_abort()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(404, Lifecycle.Static)]
        public async Task oes_e14_blind()
        {
            Engine.ai_set_blind(this.ai_current_squad, true);
            Engine.ai_set_deaf(this.ai_current_squad, true);
        }

        [ScriptMethod(405, Lifecycle.Static)]
        public async Task oes_e14_unblind()
        {
            Engine.ai_set_blind(this.ai_current_squad, false);
            Engine.ai_set_deaf(this.ai_current_squad, false);
        }

        [ScriptMethod(406, Lifecycle.Dormant)]
        public async Task e15_cov_banshees0_main()
        {
            Engine.ai_place(e15_cov_banshees0.Squad);
            Engine.cs_run_command_script(e15_cov_banshees0.banshee0, cs_e15_cov_banshee0_0_entry);
            Engine.cs_run_command_script(e15_cov_banshees0.banshee1, cs_e15_cov_banshee0_1_entry);
        }

        [ScriptMethod(407, Lifecycle.Dormant)]
        public async Task e15_cov_wraith1_main()
        {
            await Engine.sleep(2);
            Engine.ai_place(e16_cov_wraiths0_0.wraith1);
            Engine.ai_braindead(e16_cov_wraiths0_0.wraith1, true);
            await Engine.sleep(2);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get(e15_cov_phantom0_1.phantom0), "phantom_lc", Engine.ai_vehicle_get(e16_cov_wraiths0_0.wraith1));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e16_cov_wraiths0_0.wraith1) <= 0 || !(Engine.unit_in_vehicle(Engine.ai_vehicle_get(e16_cov_wraiths0_0.wraith1))));
            Engine.vehicle_unload(Engine.ai_vehicle_get(e15_cov_phantom0_1.phantom0), "phantom_lc");
            Engine.ai_braindead(e16_cov_wraiths0_0.wraith1, false);
        }

        [ScriptMethod(408, Lifecycle.Dormant)]
        public async Task e15_cov_wraith0_main()
        {
            await Engine.sleep(2);
            Engine.ai_place(e16_cov_wraiths0_0.wraith0);
            Engine.ai_braindead(e16_cov_wraiths0_0.wraith0, true);
            await Engine.sleep(2);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get(e15_cov_phantom0_0.phantom0), "phantom_lc", Engine.ai_vehicle_get(e16_cov_wraiths0_0.wraith0));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e16_cov_wraiths0_0.wraith0) <= 0 || !(Engine.unit_in_vehicle(Engine.ai_vehicle_get(e16_cov_wraiths0_0.wraith0))));
            Engine.vehicle_unload(Engine.ai_vehicle_get(e15_cov_phantom0_0.phantom0), "phantom_lc");
            Engine.ai_braindead(e16_cov_wraiths0_0.wraith0, false);
        }

        [ScriptMethod(409, Lifecycle.Dormant)]
        public async Task e15_cov_phantom1_main()
        {
            Engine.ai_place(e15_cov_phantom1.Squad);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get(e15_cov_phantom1.phantom0)) <= 20F, 5, this._30_seconds);
            Engine.wake(new ScriptMethodReference(music_03b_01_start));
            await Engine.sleep(10);
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(410, Lifecycle.Dormant)]
        public async Task e15_cov_phantom0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e15_cov_phantoms0_begin, Engine.players()), 15);
            Engine.ai_place(e15_cov_phantom0_0.Squad);
            await Engine.sleep_until(async () => this.g_e16_started || Engine.object_get_health(Engine.ai_vehicle_get(e15_cov_phantom0_0.phantom0)) <= 0.05F || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e15_cov_phantom0_0.phantom0), "target_front") >= 2, 30, this.one_minute);
            Engine.cs_queue_command_script(e15_cov_phantom0_0.phantom0, cs_e15_cov_phantom0_0_exit);
            Engine.ai_place(e15_cov_phantom0_1.Squad);
            Engine.wake(new ScriptMethodReference(e15_cov_wraith1_main));
            await Engine.sleep_until(async () => this.g_e16_started || Engine.object_get_health(Engine.ai_vehicle_get(e15_cov_phantom0_1.phantom0)) <= 0.05F || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e15_cov_phantom0_1.phantom0), "target_front") >= 2 || (short)Engine.ai_living_count(e16_cov_wraiths0_0.wraith1) <= 0, 30, this.one_minute);
            Engine.cs_queue_command_script(e15_cov_phantom0_1.phantom0, cs_e15_cov_phantom0_1_exit);
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task e15_cov_inf2_main()
        {
            Engine.ai_place(e15_cov_inf2_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e15_cov_inf1_spring, Engine.players()), 15);
            Engine.ai_place(e15_cov_inf2_1.Squad, (short)(10 - (float)Engine.ai_living_count(e15_cov)));
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task e15_cov_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e15_cov_inf1_spring, Engine.players()), 15);
            Engine.ai_place(e15_cov_inf1.Squad);
            await Engine.sleep(5);
            Engine.object_set_velocity(Engine.ai_get_object(e15_cov_inf1.bugger0), 2F, 0F, 5F);
            Engine.object_set_velocity(Engine.ai_get_object(e15_cov_inf1.bugger1), 2F, 0F, 5F);
            Engine.object_set_velocity(Engine.ai_get_object(e15_cov_inf1.bugger2), 3F, 0F, 6F);
            Engine.object_set_velocity(Engine.ai_get_object(e15_cov_inf1.bugger3), 2F, 0F, 5F);
            Engine.object_set_velocity(Engine.ai_get_object(e15_cov_inf1.bugger4), 3F, 0F, 6F);
            Engine.object_set_velocity(Engine.ai_get_object(e15_cov_inf1.bugger5), 2F, 0F, 5F);
        }

        [ScriptMethod(413, Lifecycle.Dormant)]
        public async Task e15_cov_inf0_main()
        {
            Engine.ai_place(e15_cov_inf0.Squad);
        }

        [ScriptMethod(414, Lifecycle.Dormant)]
        public async Task e15_mars_inf0_main()
        {
            Engine.ai_migrate(e14_mars_inf0.Squad, e15_mars_inf0.Squad);
            Engine.ai_place(e15_mars_inf0.Squad, (short)Engine.pin(3F - (float)Engine.ai_living_count(e15_mars_inf0.Squad), 1F, 2F));
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task e15_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e15_main_begin, Engine.players()), 15);
            this.g_e15_started = true;
            Engine.print("e15_main");
            Engine.data_mine_set_mission_segment("e15_bridge_summit");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e15_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e15_cov_phantom0_main));
            Engine.wake(new ScriptMethodReference(e15_cov_phantom1_main));
            Engine.wake(new ScriptMethodReference(e15_cov_banshees0_main));
            await Engine.sleep_until(async () => this.g_e17_started);
            Engine.sleep_forever(new ScriptMethodReference(e15_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e15_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e15_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e15_cov_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e15_cov_phantom0_main));
            Engine.sleep_forever(new ScriptMethodReference(e15_cov_banshees0_main));
            Engine.ai_disposable(e15_cov, true);
            Engine.ai_disposable(e15_cov_phantom0, false);
        }

        [ScriptMethod(416, Lifecycle.Static)]
        public async Task test_bridge_summit()
        {
            Engine.object_teleport(await this.player0(), e15_test);
            Engine.ai_place(e15_mars_inf0.Squad);
            if (!(this.g_e15_started))
            {
                Engine.wake(new ScriptMethodReference(e15_main));
            }

            if (!(this.g_e16_started))
            {
                Engine.wake(new ScriptMethodReference(e16_main));
            }

            if (!(this.g_e17_started))
            {
                Engine.wake(new ScriptMethodReference(e17_main));
            }

            if (!(this.g_e18_started))
            {
                Engine.wake(new ScriptMethodReference(e18_main));
            }
        }

        [ScriptMethod(417, Lifecycle.CommandScript)]
        public async Task cs_e14_cov_wraiths0_bombard()
        {
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () =>
            {
                if (Engine.unit_in_vehicle(Engine.unit(await this.player1())))
                {
                    Engine.cs_shoot(true, await this.player1());
                }

                if (Engine.unit_in_vehicle(Engine.unit(await this.player0())))
                {
                    Engine.cs_shoot(true, await this.player0());
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade4, Engine.players()), 15, 150);
                Engine.cs_shoot(false, await this.player0());
                Engine.cs_shoot(false, await this.player1());
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade4, Engine.players()), 15, 300);
                return Engine.volume_test_objects(tv_e14_blockade4, Engine.players());
            });
        }

        [ScriptMethod(418, Lifecycle.CommandScript)]
        public async Task cs_e14_mars_pelican0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.25F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_mars_inf0_advance, Engine.players()) || await this.player_in_vehicle(), 15);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e14_mars_pelican0/p8"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e14_mars_pelican0/p6"), Engine.GetReference<ISpatialPoint>("e14_mars_pelican0/p7"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e14_mars_pelican0/p6"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e14_mars_pelican0/p7"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(419, Lifecycle.CommandScript)]
        public async Task cs_e14_cov_ghosts0_advance0()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p1"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p4"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p5"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p6"));
        }

        [ScriptMethod(420, Lifecycle.CommandScript)]
        public async Task cs_e14_cov_ghosts0_advance1()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p4"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e14_cov_ghosts0_advance/p5"));
        }

        [ScriptMethod(421, Lifecycle.Dormant)]
        public async Task e14_cov_snipers0_main()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(422, Lifecycle.Dormant)]
        public async Task e14_cov_wraiths0_main()
        {
            Engine.ai_place(e14_cov_wraiths0.wraith0);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade0, Engine.players()), 15);
            Engine.cs_run_command_script(e14_cov_wraiths0.Squad, cs_e14_cov_wraiths0_bombard);
        }

        [ScriptMethod(423, Lifecycle.Dormant)]
        public async Task e14_cov_ghosts1_main()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(424, Lifecycle.Dormant)]
        public async Task e14_cov_ghosts0_main()
        {
            Engine.ai_place(e14_cov_ghosts0_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade0, Engine.players()), 15);
            Engine.ai_place(e14_cov_ghosts0_1.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade1, Engine.players()), 15);
            Engine.ai_place(e14_cov_ghosts0_1.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade2, Engine.players()), 15);
            Engine.ai_place(e14_cov_ghosts0_1.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade3, Engine.players()), 15);
            Engine.ai_place(e14_cov_ghosts0_1.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade4, Engine.players()), 15);
            Engine.ai_place(e14_cov_ghosts0_1.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e14_cov_ghosts0), 0F, 2F));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e14_blockade5, Engine.players()), 15);
            Engine.ai_place(e14_cov_ghosts0_1.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(e14_cov_ghosts0), 0F, 2F));
        }

        [ScriptMethod(425, Lifecycle.Dormant)]
        public async Task e14_mars_pelican0_main()
        {
            Engine.ai_place(e14_mars_pelican0.Squad);
            Engine.object_cannot_take_damage(Engine.ai_actors(e14_mars_pelican0.Squad));
            Engine.ai_vehicle_enter_immediate(e14_mars_pelican0.gunner0, Engine.ai_vehicle_get(e14_mars_pelican0.pelican0), "pelican_g");
            Engine.ai_vehicle_enter_immediate(e14_mars_pelican0.johnson0, Engine.ai_vehicle_get(e14_mars_pelican0.pelican0), "pelican_g_rear");
        }

        [ScriptMethod(426, Lifecycle.Dormant)]
        public async Task e14_mars_inf0_main()
        {
            Engine.ai_place(e14_mars_inf0.Squad);
            Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get_from_starting_location(e14_mars_inf0.scorpion0), "scorpion_d", true);
            if ((bool)Engine.game_is_cooperative())
            {
                Engine.ai_place(e14_mars_inf0.warthog0);
                Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get_from_starting_location(e14_mars_inf0.warthog0), "warthog_d", true);
            }
            else
            {
                Engine.ai_place(e14_mars_inf0.warthog1);
                Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get_from_starting_location(e14_mars_inf0.warthog1), "warthog_d", true);
            }
        }

        [ScriptMethod(427, Lifecycle.Dormant)]
        public async Task e14_main()
        {
            this.g_e14_started = true;
            Engine.print("e14_main");
            Engine.data_mine_set_mission_segment("e14_bridge_ascent");
            Engine.game_save();
            Engine.kill_volume_enable(kill_e14_0);
            Engine.wake(new ScriptMethodReference(objective0_set));
            Engine.wake(new ScriptMethodReference(e15_main));
            Engine.wake(new ScriptMethodReference(e16_main));
            Engine.wake(new ScriptMethodReference(e17_main));
            Engine.wake(new ScriptMethodReference(e18_main));
            Engine.wake(new ScriptMethodReference(e14_mars_inf0_main));
            Engine.wake(new ScriptMethodReference(e14_mars_pelican0_main));
            Engine.wake(new ScriptMethodReference(e14_cov_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e14_cov_ghosts1_main));
            Engine.wake(new ScriptMethodReference(e14_cov_wraiths0_main));
            Engine.wake(new ScriptMethodReference(e14_cov_snipers0_main));
            await Engine.sleep_until(async () => this.g_e15_started);
            Engine.sleep_forever(new ScriptMethodReference(e14_mars_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e14_cov_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e14_cov_ghosts1_main));
            Engine.sleep_forever(new ScriptMethodReference(e14_cov_wraiths0_main));
            Engine.sleep_forever(new ScriptMethodReference(e14_cov_snipers0_main));
            Engine.ai_disposable(e14_cov, true);
        }

        [ScriptMethod(428, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            Engine.wake(new ScriptMethodReference(flashlight_control));
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
            Engine.wake(new ScriptMethodReference(e14_main));
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(new ScriptMethodReference(chapter_title0));
            await Engine.sleep_until(async () => this.g_mission_over, 8);
            Engine.wake(new ScriptMethodReference(music_03b_04_stop));
            await Engine.sleep(60);
            await this.playtest_mission();
            await Engine.sleep(15);
            await this.cinematic_fade_to_white();
            Engine.object_cannot_take_damage(Engine.players());
            Engine.object_hide(await this.player0(), true);
            Engine.object_hide(await this.player1(), true);
            Engine.object_teleport(await this.player0(), player0_end);
            Engine.object_teleport(await this.player1(), player1_end);
            Engine.object_destroy(scarab.Entity);
            Engine.ai_erase(e23_cov);
            Engine.ai_erase(e23_mars);
            await this.cinematic_outro();
            Engine.game_won();
        }

        [ScriptMethod(429, Lifecycle.Static)]
        public async Task start()
        {
            Engine.wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(430, Lifecycle.Startup)]
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

        [ScriptMethod(431, Lifecycle.Dormant)]
        public async Task _03_intra1_01_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bridge\\bridge", 3787718734U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_barrier\\toll_barrier", 3838509909U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 3);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 47, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 16, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3838575446U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_road_signal\\sign_road_signal", 3839427427U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3842048907U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 19);
            await Engine.sleep(15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 13);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            await Engine.sleep(74);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 49, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 87);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 99);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 89);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 90);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 91);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 92);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 93);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 94);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 95);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 96);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 97);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_cone\\road_cone", 3848209385U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\crush_barrel\\crush_barrel\\crush_barrel", 3848602607U), 0);
            await Engine.sleep(31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 25);
            await Engine.sleep(33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            await Engine.sleep(17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\multi\\zanzibar\\dumpster\\dumpster", 3849257977U), 0);
            await Engine.sleep(83);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 48, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3838575446U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3850830865U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_rear_gun\\scarab_rear_gun", 3851158550U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3851486235U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_mid_garb\\bridge_light_mid_garb", 3852010531U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_brace_garb\\bridge_light_brace_garb", 3852272679U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech\\crate_tech", 3852338216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853583419U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_lit_garb\\bridge_light_lit_garb", 3854828622U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_street_arch\\sign_street_arch", 3854959696U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech_giant\\crate_tech_giant", 3855156307U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\tire\\tire", 3855221844U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis_tire\\uberchassis_tire", 3855483992U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\pallet\\pallet", 3855549529U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 3855811677U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing\\crate_packing", 3856008288U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\drum_55gal\\drum_55gal", 3856204899U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 38, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\weapons\\smg\\smg", 3856401510U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 1);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 19, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 25, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 38, false);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 1);
            await Engine.sleep(85);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech\\crate_tech", 3852338216U), 0);
            await Engine.sleep(49);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 87);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 99);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 89);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 90);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 91);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 92);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 93);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 94);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 95);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 96);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\scorpion", 3845981127U), 97);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\scorpion\\turrets\\cannon\\cannon", 3843621795U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 1);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 45, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853583419U), 0);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 0);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 2, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, true);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 1);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 1);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 23, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 48, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_mid_garb\\bridge_light_mid_garb", 3852010531U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\pallet\\pallet", 3855549529U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 3855811677U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing\\crate_packing", 3856008288U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\tire\\tire", 3855221844U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\drum_55gal\\drum_55gal", 3856204899U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\weapons\\smg\\smg", 3856401510U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_street_arch\\sign_street_arch", 3854959696U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_lit_garb\\bridge_light_lit_garb", 3854828622U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech_giant\\crate_tech_giant", 3855156307U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_brace_garb\\bridge_light_brace_garb", 3852272679U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\multi\\zanzibar\\dumpster\\dumpster", 3849257977U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, true);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 1);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech\\crate_tech", 3852338216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis_tire\\uberchassis_tire", 3855483992U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 34, false);
            await Engine.sleep(30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_road_signal\\sign_road_signal", 3839427427U), 1);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 2);
            await Engine.sleep(58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3834774300U), 25);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_h\\concrete_chunk_h", 3856729195U), 0);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
        }

        [ScriptMethod(432, Lifecycle.Dormant)]
        public async Task _03_intra1_02a_predict()
        {
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 49, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\crush_barrel\\crush_barrel\\crush_barrel", 3848602607U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_j\\concrete_chunk_j", 3856794732U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_barrier\\toll_barrier", 3838509909U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await Engine.sleep(75);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            await Engine.sleep(32);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 48, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_mid_garb\\bridge_light_mid_garb", 3852010531U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_brace_garb\\bridge_light_brace_garb", 3852272679U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech\\crate_tech", 3852338216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853583419U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis", 3852665901U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\bridge_light\\bridge_light", 3853714493U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\urban\\air\\air", 3854632011U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\garbage\\bridge_light_lit_garb\\bridge_light_lit_garb", 3854828622U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_street_arch\\sign_street_arch", 3854959696U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\industrial\\crate_tech_giant\\crate_tech_giant", 3855156307U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\tire\\tire", 3855221844U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\h_semi_trailer\\h_semi_trailer", 3854107715U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\uberchassis\\uberchassis_tire\\uberchassis_tire", 3855483992U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\pallet\\pallet", 3855549529U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing_giant\\crate_packing_giant", 3855811677U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\crate_packing\\crate_packing", 3856008288U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\drum_55gal\\drum_55gal", 3856204899U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\weapons\\smg\\smg", 3856401510U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 1);
            await Engine.sleep(26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 56);
            await Engine.sleep(60);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 49, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_road_signal\\sign_road_signal", 3839427427U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_h\\concrete_chunk_h", 3856729195U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_barrier\\toll_barrier", 3838509909U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\multi\\zanzibar\\dumpster\\dumpster", 3849257977U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
        }

        [ScriptMethod(433, Lifecycle.Dormant)]
        public async Task _03_intra1_02b_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(434, Lifecycle.Dormant)]
        public async Task _03_intra1_02c_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_cone\\road_cone", 3848209385U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\crush_barrel\\crush_barrel\\crush_barrel", 3848602607U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_h\\concrete_chunk_h", 3856729195U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_j\\concrete_chunk_j", 3856794732U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await Engine.sleep(157);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 49, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_h\\concrete_chunk_h", 3856729195U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\concrete_chunks\\concrete_chunk_b\\concrete_chunk_b", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\toll_booth\\toll_booth", 3835822892U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\multi\\zanzibar\\dumpster\\dumpster", 3849257977U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\junction_box_lg\\junction_box_lg", 3848864755U), 2);
            await Engine.sleep(35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_good\\cigar_good", 3856991343U), 0);
        }

        [ScriptMethod(435, Lifecycle.Dormant)]
        public async Task _03_intra1_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_3b"), 3, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 1);
            await Engine.sleep(11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_trashcan\\streetobj_trashcan", 3857319028U), 0);
        }

        [ScriptMethod(436, Lifecycle.Dormant)]
        public async Task x03_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 66, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 76, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 68, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 97, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 156, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 157, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 154, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 160, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 155, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 153, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 164, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 130, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 161, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 158, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 132, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 165, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 131, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 103, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 113, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 159, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 133, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 134, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 166, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 101, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 111, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 135, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 136, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 167, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 112, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 119, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 114, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 118, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 152, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 77, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 81, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 80, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 96, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 97, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3849520125U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3838575446U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3850830865U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_rear_gun\\scarab_rear_gun", 3851158550U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3851486235U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3857581176U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\powerups\\rocket_launcher_ammo\\rocket_launcher_ammo", 3857908861U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\road_objects\\vent_wall_a\\vent_wall_a", 3858302083U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\case_ap_turret\\case_ap_turret", 3858564231U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\case\\case", 3858760842U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3858957453U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\fixed\\h_turret_mp\\h_turret_mp", 3860006045U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\powerups\\shotgun_ammo\\shotgun_ammo", 3860268193U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\powerups\\battle_rifle_ammo\\battle_rifle_ammo", 3807969667U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3860595878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\nm_control_box\\nm_control_box", 3861710007U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 95, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\newmombasa\\newmombasa", 3788111956U), 6);
            await Engine.sleep(63);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 95, true);
            await Engine.sleep(15);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 13, true);
            await Engine.sleep(26);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 95, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 27, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 97, true);
            await Engine.sleep(36);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 47, true);
            await Engine.sleep(35);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 157, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 103, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 160, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 130, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 102, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 164, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 132, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 36, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3842311055U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 1);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3789357159U), 2);
            await Engine.sleep(109);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 154, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 47, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 153, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 51, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 158, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 35, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3860595878U), 2);
            await Engine.sleep(140);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 161, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 157, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 165, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 131, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 103, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 113, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 159, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 160, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 133, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 164, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 130, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 102, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 166, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 101, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 134, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 111, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 132, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 136, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 135, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 167, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 112, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 114, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 118, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 152, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 81, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03b_newmombasa\\earthcity_4"), 33, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\human\\military\\case\\case", 3858760842U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\nm_control_box\\nm_control_box", 3861710007U), 0);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 1);
        }

        [ScriptMethod(437, Lifecycle.Dormant)]
        public async Task x03_02_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 4);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 57, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 62, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3842048907U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3829269192U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 1);
            await Engine.sleep(50);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 76, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
            await Engine.sleep(43);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            await Engine.sleep(104);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3868198170U), 0);
        }

        [ScriptMethod(438, Lifecycle.Dormant)]
        public async Task x03_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3860595878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3842048907U), 0);
            await Engine.sleep(24);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 57, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 62, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            await Engine.sleep(28);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            await Engine.sleep(67);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 76, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
        }

        [ScriptMethod(439, Lifecycle.Dormant)]
        public async Task x03_04_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            await Engine.sleep(2);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3867411726U), 1);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            await Engine.sleep(11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
            await Engine.sleep(110);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 2);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3868198170U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3844604850U), 3);
        }

        [ScriptMethod(440, Lifecycle.Dormant)]
        public async Task x03_05_predict()
        {
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3860595878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3868198170U), 0);
            await Engine.sleep(22);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            await Engine.sleep(85);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            await Engine.sleep(90);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
        }

        [ScriptMethod(441, Lifecycle.Dormant)]
        public async Task x03_06_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3864397024U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3862955210U), 1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3869181225U), 2);
            await Engine.sleep(2);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            await Engine.sleep(40);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 76, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
            await Engine.sleep(28);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
        }

        [ScriptMethod(442, Lifecycle.Dormant)]
        public async Task x03_07_predict()
        {
            await Engine.sleep(50);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3869508910U), 0);
            await Engine.sleep(21);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3853583419U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3869508910U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\slipspace_shockwave_start\\slipspace_shockwave_start", 3869574447U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 23, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_vert_facade\\sign_vert_facade", 3840607093U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hog\\sign_hog", 3870164280U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\signage\\sign_hor_facade\\sign_hor_facade", 3870360891U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_big_generator\\streetobj_big_generator", 3870557502U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\earthcity\\streetobjects\\streetobj_dumpster\\streetobj_dumpster", 3871147335U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\bsp1\\bsp1", 3782934533U), 2);
        }

        [ScriptMethod(443, Lifecycle.Dormant)]
        public async Task x03_08_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\slipspace_shockwave_closeup\\slipspace_shockwave_closeup", 3872261464U), 0);
            await Engine.sleep(72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\panel_truck\\panel_truck", 3851551772U), 2);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 1);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\civilian\\bus\\bus", 3841393537U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3869508910U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\slipspace_shockwave\\slipspace_shockwave", 3872458075U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 65, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 51, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 43, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 75, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 74, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 70, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 69, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 68, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 67, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 66, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 64, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 62, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 57, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 56, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 55, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 54, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 52, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 50, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 49, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 48, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 45, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 44, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 37, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 72, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 61, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 60, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 58, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 47, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 77, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 73, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 63, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 59, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\03a_oldmombasa\\earthcity_cine_intro_bsp"), 8, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\earthcity\\cinematic_newmombasa\\cinematic_newmombasa", 3788767326U), 4);
        }
    }
}