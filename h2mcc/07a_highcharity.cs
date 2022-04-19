namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\07a_highcharity\\07a_highcharity")]
    public partial class scnr_07a_highcharity : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool debug;
        bool dialogue;
        bool g_play_cinematics;
        int sleep_lower_bound;
        int sleep_upper_bound;
        bool g_cheiftan;
        bool g_dervish_ledge_orders;
        bool g_room_a_door;
        bool g_sc_ioc_finished;
        bool g_jail_a_free;
        bool g_jail_b_free;
        bool g_jail_a_finished;
        bool g_jail_b_finished;
        bool g_marine_mig_garden_a;
        bool g_marine_mig_midtower;
        bool g_marine_mig_garden_b;
        bool g_marine_mig_ext_b;
        bool g_marine_mig_maus;
        bool g_marine_mig_maus_room;
        bool g_marine_mig_maus_int;
        bool g_music_07a_01;
        bool g_music_07a_02;
        bool g_music_07a_03;
        bool g_music_07a_03_alt;
        bool g_music_07a_04;
        bool g_music_07a_04_alt;
        bool g_music_07a_05;
        bool g_music_07a_06;
        bool g_music_07a_07;
        bool g_music_07a_07_alt;
        bool g_music_07a_08;
        bool g_council_initial;
        bool g_council_exit_reminder;
        bool g_council_reminder_played;
        bool g_ledge_reminder;
        int dialogue_pause;
        bool g_jail_exit_reminder;
        bool g_jail_exit_reminder_played;
        bool g_sc_room_b_done;
        bool g_corr_b_exit_finished;
        bool g_ioc_reminder;
        bool g_ioc_reminder_played;
        bool g_truth_speaking;
        bool g_council_over;
        bool g_council_wave;
        int g_council_count;
        int g_council_limit;
        bool g_council_orders;
        bool g_council_floor_wave;
        int g_council_floor_wave_count;
        int g_council_floor_wave_limit;
        bool g_council_upper;
        int g_council_upper_limit;
        int g_council_upper_count;
        bool g_ledge_turret_left;
        bool g_ledge_turret_right;
        bool g_corridor_a_active;
        bool g_jail_prophets_ini_active;
        bool jail_a_doors_open;
        bool jail_b_doors_open;
        bool g_jail_door;
        int g_jail_door_limit;
        int g_jail_door_count;
        bool g_jail_spawner;
        int g_jail_spawn_limit;
        int g_jail_spawn_count;
        bool g_jail_round_lift_spawned;
        bool g_ext_a_snipers;
        int g_ext_a_snipers_count;
        int g_ext_a_snipers_index;
        bool g_ext_a_fliers;
        bool g_midtower_prophet_rein;
        bool g_ext_b_dump;
        bool g_maus_bridge_fr;
        bool g_maus_inner_order_trans;
        bool g_maus_inner;
        bool g_maus_inner_wave_pause;
        bool g_maus_inner_wave_end;
        int g_maus_inner_count;
        int g_maus_inner_limit;
        int g_maus_inner_wave_count;
        int g_maus_inner_wave_limit;
        public scnr_07a_highcharity(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.debug = true;
            this.dialogue = true;
            this.g_play_cinematics = true;
            this.sleep_lower_bound = 120;
            this.sleep_upper_bound = 180;
            this.g_cheiftan = false;
            this.g_dervish_ledge_orders = false;
            this.g_room_a_door = false;
            this.g_sc_ioc_finished = false;
            this.g_jail_a_free = false;
            this.g_jail_b_free = false;
            this.g_jail_a_finished = false;
            this.g_jail_b_finished = false;
            this.g_marine_mig_garden_a = false;
            this.g_marine_mig_midtower = false;
            this.g_marine_mig_garden_b = false;
            this.g_marine_mig_ext_b = false;
            this.g_marine_mig_maus = false;
            this.g_marine_mig_maus_room = false;
            this.g_marine_mig_maus_int = false;
            this.g_music_07a_01 = false;
            this.g_music_07a_02 = false;
            this.g_music_07a_03 = false;
            this.g_music_07a_03_alt = false;
            this.g_music_07a_04 = false;
            this.g_music_07a_04_alt = false;
            this.g_music_07a_05 = false;
            this.g_music_07a_06 = false;
            this.g_music_07a_07 = false;
            this.g_music_07a_07_alt = false;
            this.g_music_07a_08 = false;
            this.g_council_initial = false;
            this.g_council_exit_reminder = false;
            this.g_council_reminder_played = false;
            this.g_ledge_reminder = false;
            this.dialogue_pause = 7;
            this.g_jail_exit_reminder = false;
            this.g_jail_exit_reminder_played = false;
            this.g_sc_room_b_done = false;
            this.g_corr_b_exit_finished = false;
            this.g_ioc_reminder = false;
            this.g_ioc_reminder_played = false;
            this.g_truth_speaking = false;
            this.g_council_over = false;
            this.g_council_wave = false;
            this.g_council_count = 0;
            this.g_council_limit = 0;
            this.g_council_orders = false;
            this.g_council_floor_wave = false;
            this.g_council_floor_wave_count = 0;
            this.g_council_floor_wave_limit = 0;
            this.g_council_upper = true;
            this.g_council_upper_limit = 0;
            this.g_council_upper_count = 0;
            this.g_ledge_turret_left = false;
            this.g_ledge_turret_right = false;
            this.g_corridor_a_active = false;
            this.g_jail_prophets_ini_active = false;
            this.jail_a_doors_open = false;
            this.jail_b_doors_open = false;
            this.g_jail_door = true;
            this.g_jail_door_limit = 0;
            this.g_jail_door_count = 0;
            this.g_jail_spawner = true;
            this.g_jail_spawn_limit = 0;
            this.g_jail_spawn_count = 0;
            this.g_jail_round_lift_spawned = false;
            this.g_ext_a_snipers = true;
            this.g_ext_a_snipers_count = 0;
            this.g_ext_a_snipers_index = 4;
            this.g_ext_a_fliers = false;
            this.g_midtower_prophet_rein = false;
            this.g_ext_b_dump = false;
            this.g_maus_bridge_fr = false;
            this.g_maus_inner_order_trans = false;
            this.g_maus_inner = false;
            this.g_maus_inner_wave_pause = true;
            this.g_maus_inner_wave_end = false;
            this.g_maus_inner_count = 0;
            this.g_maus_inner_limit = 0;
            this.g_maus_inner_wave_count = 0;
            this.g_maus_inner_wave_limit = 0;
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

        [ScriptMethod(24, Lifecycle.CommandScript)]
        public async Task cs_c07_infection()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("c07_infection_a"));
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("c07_infection_b"));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x08_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_01_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x08_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x08_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_03_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x08_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_04_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x08_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_05_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x08_06a_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_06a_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x08_06b_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_06b_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x08_06c_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_06c_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x08_07_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_07_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task x08_08_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_08_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task x08_09_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_09_predict));
        }

        [ScriptMethod(36, Lifecycle.Static)]
        public async Task x08_10_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_10_predict));
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task x08_11_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x08_11_predict));
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task _07_intro_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intro_01_predict));
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task _07_intro_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intro_02_predict));
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task _07_intro_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intro_03_predict));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task _07_intro_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intro_04_predict));
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task _07_intra1_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intra1_01_predict));
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task _07_intra1_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intra1_02_predict));
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task _07_intra1_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intra1_03_predict));
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task _07_intra1_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intra1_04_predict));
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task x08_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\music\\x08_01_mus", 3845325757U), default(IGameObject), 1F);
            Engine.print("x08 score 01 start");
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x08_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_01_fol", 3845391294U), default(IGameObject), 1F);
            Engine.print("x08 foley 01 start");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task blurry_vision()
        {
            Engine.interpolator_start("blurry_vision", 1F, 0.001F);
            await Engine.sleep(30);
            Engine.fade_in(0F, 0F, 0F, 30);
            await Engine.sleep(45);
            Engine.fade_out(0F, 0F, 0F, 30);
            await Engine.sleep(45);
            Engine.fade_in(0F, 0F, 0F, 20);
            Engine.interpolator_start("blurry_vision", 0F, 2F);
            await Engine.sleep(30);
            Engine.fade_out(0F, 0F, 0F, 20);
            await Engine.sleep(20);
            Engine.interpolator_start("blurry_vision", 1F, 0.001F);
            await Engine.sleep(25);
            Engine.fade_in(0F, 0F, 0F, 10);
            Engine.interpolator_start("blurry_vision", 0F, 2F);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task x08_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(-90F, 0F, 0.0352941F, 0.278431F, 0.301961F);
            Engine.cinematic_lighting_set_secondary_light(-4F, 316F, 0.156863F, 0.109804F, 0F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.25F);
            Engine.rasterizer_bloom_override_brightness(0.4F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(gravemind.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_chief.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_capture_01.Entity, true);
            Engine.render_lights_enable_cinematic_shadow(true, chief.Entity, "head", 0.1F);
        }

        [ScriptMethod(50, Lifecycle.Static)]
        public async Task x08_01_setup()
        {
            Engine.object_create_anew(chief);
            Engine.object_create_anew(gravemind);
            Engine.object_create_anew(tentacle_chief);
            Engine.object_create_anew(tentacle_capture_01);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(gravemind.Entity, true);
            Engine.object_cinematic_lod(tentacle_chief.Entity, true);
            Engine.object_cinematic_lod(tentacle_capture_01.Entity, true);
            Engine.wake(new ScriptMethodReference(x08_score_01));
            Engine.wake(new ScriptMethodReference(x08_foley_01));
            Engine.wake(new ScriptMethodReference(blurry_vision));
            Engine.wake(new ScriptMethodReference(x08_cinematic_light_01));
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task x08_scene_01()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("highcharity_1");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.x08_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\music\\x08_01_mus", 3845325757U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_01_fol", 3845391294U));
            await Engine.sleep(this.prediction_offset);
            await this.x08_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_01", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_01", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_01", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_01", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven01_01", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_02_fol", 3845850053U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task x08_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_02_fol", 3845850053U), default(IGameObject), 1F);
            Engine.print("x08 foley 02 start");
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task x08_0020_cor()
        {
            await Engine.sleep(40);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0020_cor", 3845915590U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x08_0020_cor", 2F);
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task x08_0030_grv()
        {
            await Engine.sleep(134);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0030_grv", 3845981127U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0030_grv", 9F);
        }

        [ScriptMethod(55, Lifecycle.Static)]
        public async Task x08_02_setup()
        {
            Engine.wake(new ScriptMethodReference(x08_foley_02));
            Engine.wake(new ScriptMethodReference(x08_0020_cor));
            Engine.wake(new ScriptMethodReference(x08_0030_grv));
        }

        [ScriptMethod(56, Lifecycle.Static)]
        public async Task x08_scene_02()
        {
            await this.x08_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_02", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_02", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_02", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_02", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven01_02", anchor_x08.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_03_fol", 3846046664U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task x08_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_03_fol", 3846046664U), default(IGameObject), 1F);
            Engine.print("x08 foley 03 start");
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task x08_0060_mas()
        {
            await Engine.sleep(259);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0060_mas", 3846112201U), chief.Entity, 1F);
            Engine.cinematic_subtitle("x08_0060_mas", 3F);
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task x08_03_setup()
        {
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(tentacle_capture_02);
            Engine.object_create_anew(tentacle_capture_03);
            Engine.object_create_anew(tentacle_capture_04);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(tentacle_capture_02.Entity, true);
            Engine.object_cinematic_lod(tentacle_capture_03.Entity, true);
            Engine.object_cinematic_lod(tentacle_capture_04.Entity, true);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.render_lights_enable_cinematic_shadow(true, dervish.Entity, "head", 0.2F);
            Engine.object_uses_cinematic_lighting(tentacle_capture_02.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_capture_03.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_capture_04.Entity, true);
            Engine.wake(new ScriptMethodReference(x08_foley_03));
            Engine.wake(new ScriptMethodReference(x08_0060_mas));
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task x08_scene_03()
        {
            await this.x08_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_03", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_03", false, anchor_x08.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_03", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_03", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_03", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_03", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven01_03", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_03", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_03", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_03", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_04_fol", 3846374349U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task x08_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_04_fol", 3846374349U), default(IGameObject), 1F);
            Engine.print("x08 foley 04 start");
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task x08_0070_der()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0070_der", 3846439886U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x08_0070_der", 2F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task x08_0080_grv()
        {
            await Engine.sleep(20);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0080_grv", 3846505423U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0080_grv", 13F);
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task x08_0090_grv()
        {
            await Engine.sleep(402);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0090_grv", 3846570960U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0090_grv", 10F);
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task x08_0100_der()
        {
            await Engine.sleep(683);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0100_der", 3846636497U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x08_0100_der", 6F);
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task x08_04_setup()
        {
            Engine.wake(new ScriptMethodReference(x08_foley_04));
            Engine.wake(new ScriptMethodReference(x08_0070_der));
            Engine.wake(new ScriptMethodReference(x08_0080_grv));
            Engine.wake(new ScriptMethodReference(x08_0090_grv));
            Engine.wake(new ScriptMethodReference(x08_0100_der));
        }

        [ScriptMethod(67, Lifecycle.Static)]
        public async Task x08_scene_04()
        {
            await this.x08_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_04", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_04", false, anchor_x08.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_04", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_04", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_04", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_04", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven01_04", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_04", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_04", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_04", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_05_fol", 3846702034U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x08_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_05_fol", 3846702034U), default(IGameObject), 1F);
            Engine.print("x08 foley 05 start");
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x08_0110_grv()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0110_grv", 3846767571U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0110_grv", 3F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task x08_0120_grv()
        {
            await Engine.sleep(86);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0120_grv", 3846833108U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0120_grv", 7F);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task x08_0130_grv()
        {
            await Engine.sleep(324);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0130_grv", 3846898645U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0130_grv", 6F);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task x08_05_setup()
        {
            Engine.object_create_anew(regret);
            Engine.object_create_anew(_2401);
            Engine.object_create_anew(tentacle_capture_05);
            Engine.object_cinematic_lod(regret.Entity, true);
            Engine.object_cinematic_lod(_2401.Entity, true);
            Engine.object_cinematic_lod(tentacle_capture_05.Entity, true);
            Engine.object_uses_cinematic_lighting(regret.Entity, true);
            Engine.render_lights_enable_cinematic_shadow(true, regret.Entity, "head", 0.1F);
            Engine.object_uses_cinematic_lighting(_2401.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_capture_05.Entity, true);
            Engine.wake(new ScriptMethodReference(x08_foley_05));
            Engine.wake(new ScriptMethodReference(x08_0110_grv));
            Engine.wake(new ScriptMethodReference(x08_0120_grv));
            Engine.wake(new ScriptMethodReference(x08_0130_grv));
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task x08_scene_05()
        {
            await this.x08_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_05", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_05", false, anchor_x08.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_05", false, anchor_x08.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3846964182U), "regret_05", false, anchor_x08.Entity);
            Engine.custom_animation_relative(_2401.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3847095256U), "tangent_05", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_05", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_05", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_05", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven01_05", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_05", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_05", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_05", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven05_05", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_06a_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06a_fol", 3847160793U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task x08_foley_06a()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06a_fol", 3847160793U), default(IGameObject), 1F);
            Engine.print("x08 foley 06a start");
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x08_0140_pnt()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0140_pnt", 3847226330U), _2401.Entity, 1F);
            Engine.cinematic_subtitle("x08_0140_pnt", 7F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x08_0150_por()
        {
            await Engine.sleep(198);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0150_por", 3847291867U), regret.Entity, 1F);
            Engine.cinematic_subtitle("x08_0150_por", 7F);
        }

        [ScriptMethod(77, Lifecycle.Static)]
        public async Task x08_06a_setup()
        {
            Engine.object_destroy(gravemind.Entity);
            Engine.wake(new ScriptMethodReference(x08_foley_06a));
            Engine.wake(new ScriptMethodReference(x08_0140_pnt));
            Engine.wake(new ScriptMethodReference(x08_0150_por));
        }

        [ScriptMethod(78, Lifecycle.Static)]
        public async Task x08_scene_06a()
        {
            await this.x08_06a_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_06a", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_06a", false, anchor_x08.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3846964182U), "regret_06a", false, anchor_x08.Entity);
            Engine.custom_animation_relative(_2401.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3847095256U), "tangent_06a", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_06a", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_06a", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_06a", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_06a", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven05_06a", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_06b_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06b_fol", 3847357404U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task x08_foley_06b()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06b_fol", 3847357404U), default(IGameObject), 1F);
            Engine.print("x08 foley 06b start");
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task x08_0180_pnt()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0180_pnt", 3847422941U), _2401.Entity, 1F);
            Engine.cinematic_subtitle("x08_0180_pnt", 3.5F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x08_0190_pnt()
        {
            await Engine.sleep(105);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0190_pnt", 3847488478U), _2401.Entity, 1F);
            Engine.cinematic_subtitle("x08_0190_pnt", 5F);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x08_0200_por()
        {
            await Engine.sleep(268);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0200_por", 3847554015U), regret.Entity, 1F);
            Engine.cinematic_subtitle("x08_0200_por", 2F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x08_0210_por()
        {
            await Engine.sleep(343);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0210_por", 3847619552U), regret.Entity, 1F);
            Engine.cinematic_subtitle("x08_0210_por", 4F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x08_0220_pnt()
        {
            await Engine.sleep(453);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0220_pnt", 3847685089U), _2401.Entity, 1F);
            Engine.cinematic_subtitle("x08_0220_pnt", 8.5F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x08_0230_por()
        {
            await Engine.sleep(714);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0230_por", 3847750626U), regret.Entity, 1F);
            Engine.cinematic_subtitle("x08_0230_por", 12.5F);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task x08_06b_setup()
        {
            Engine.wake(new ScriptMethodReference(x08_foley_06b));
            Engine.wake(new ScriptMethodReference(x08_0180_pnt));
            Engine.wake(new ScriptMethodReference(x08_0190_pnt));
            Engine.wake(new ScriptMethodReference(x08_0200_por));
            Engine.wake(new ScriptMethodReference(x08_0210_por));
            Engine.wake(new ScriptMethodReference(x08_0220_pnt));
            Engine.wake(new ScriptMethodReference(x08_0230_por));
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task x08_scene_06b()
        {
            await this.x08_06b_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_06b", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_06b", false, anchor_x08.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3846964182U), "regret_06b", false, anchor_x08.Entity);
            Engine.custom_animation_relative(_2401.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3847095256U), "tangent_06b", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_06b", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven01_06b", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven05_06b", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_06c_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06c_fol", 3847816163U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x08_foley_06c()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06c_fol", 3847816163U), default(IGameObject), 1F);
            Engine.print("x08 foley 06c start");
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x08_0240_pnt()
        {
            await Engine.sleep(351);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0240_pnt", 3847881700U), _2401.Entity, 1F);
            Engine.cinematic_subtitle("x08_0240_pnt", 5.5F);
        }

        [ScriptMethod(90, Lifecycle.Static)]
        public async Task x08_06c_setup()
        {
            Engine.wake(new ScriptMethodReference(x08_foley_06c));
            Engine.wake(new ScriptMethodReference(x08_0240_pnt));
        }

        [ScriptMethod(91, Lifecycle.Static)]
        public async Task x08_scene_06c()
        {
            await this.x08_06c_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_06c", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_06c", false, anchor_x08.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3846964182U), "regret_06c", false, anchor_x08.Entity);
            Engine.custom_animation_relative(_2401.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3847095256U), "tangent_06c", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_06c", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_06c", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_06c", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_06c", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven05_06c", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 10));
            Engine.object_create_anew(gravemind);
            Engine.object_uses_cinematic_lighting(gravemind.Entity, true);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_07_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_07_fol", 3847947237U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x08_foley_07()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_07_fol", 3847947237U), default(IGameObject), 1F);
            Engine.print("x08 foley 07 start");
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x08_0250_grv()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0250_grv", 3848012774U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0250_grv", 5F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task x08_0260_grv()
        {
            await Engine.sleep(152);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0260_grv", 3848078311U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0260_grv", 6F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task x08_0251_por()
        {
            await Engine.sleep(270);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0251_por", 3848143848U), regret.Entity, 1F);
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task x08_07_setup()
        {
            Engine.wake(new ScriptMethodReference(x08_foley_07));
            Engine.wake(new ScriptMethodReference(x08_0250_grv));
            Engine.wake(new ScriptMethodReference(x08_0260_grv));
            Engine.wake(new ScriptMethodReference(x08_0251_por));
        }

        [ScriptMethod(97, Lifecycle.Static)]
        public async Task x08_scene_07()
        {
            await this.x08_07_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_07", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3846964182U), "regret_07", false, anchor_x08.Entity);
            Engine.custom_animation_relative(_2401.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3847095256U), "tangent_07", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_07", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven05_07", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_08_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_08_fol", 3848209385U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x08_foley_08()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_08_fol", 3848209385U), default(IGameObject), 1F);
            Engine.print("x08 foley 08 start");
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x08_0270_grv()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0270_grv", 3848274922U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0270_grv", 12F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x08_0280_grv()
        {
            await Engine.sleep(351);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0280_grv", 3848340459U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0280_grv", 15F);
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x08_08_setup()
        {
            Engine.object_destroy(tentacle_capture_05.Entity);
            Engine.wake(new ScriptMethodReference(x08_foley_08));
            Engine.wake(new ScriptMethodReference(x08_0270_grv));
            Engine.wake(new ScriptMethodReference(x08_0280_grv));
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x08_scene_08()
        {
            await this.x08_08_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_08", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_08", false, anchor_x08.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_08", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_08", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_08", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_08", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_08", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_08", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_08", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_09_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_09_fol", 3848405996U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x08_foley_09()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_09_fol", 3848405996U), default(IGameObject), 1F);
            Engine.print("x08 foley 09 start");
        }

        [ScriptMethod(104, Lifecycle.Static)]
        public async Task x08_scene_09()
        {
            Engine.wake(new ScriptMethodReference(x08_foley_09));
            Engine.object_destroy(regret.Entity);
            Engine.object_destroy(_2401.Entity);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_09", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_09", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_09", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_09", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_09", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_09", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_10_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_10_fol", 3848471533U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x08_foley_10()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_10_fol", 3848471533U), default(IGameObject), 1F);
            Engine.print("x08 foley 10 start");
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task x08_0340_mas()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0340_mas", 3848537070U), chief.Entity, 1F);
            Engine.cinematic_subtitle("x08_0340_mas", 5F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task x08_0350_der()
        {
            await Engine.sleep(147);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0350_der", 3848602607U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x08_0350_der", 6F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task x08_0360_grv()
        {
            await Engine.sleep(323);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0360_grv", 3848668144U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0360_grv", 8F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task x08_0370_grv()
        {
            await Engine.sleep(561);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0370_grv", 3848733681U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0370_grv", 9F);
        }

        [ScriptMethod(110, Lifecycle.Static)]
        public async Task x08_10_setup()
        {
            Engine.wake(new ScriptMethodReference(x08_foley_10));
            Engine.wake(new ScriptMethodReference(x08_0340_mas));
            Engine.wake(new ScriptMethodReference(x08_0350_der));
            Engine.wake(new ScriptMethodReference(x08_0360_grv));
            Engine.wake(new ScriptMethodReference(x08_0370_grv));
        }

        [ScriptMethod(111, Lifecycle.Static)]
        public async Task x08_scene_10()
        {
            await this.x08_10_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_10", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_10", false, anchor_x08.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_10", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_10", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_10", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_10", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven01_10", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_10", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_10", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_10", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x08_11_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\music\\x08_11_mus", 3848799218U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_11_fol", 3848864755U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x08_foley_11()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_11_fol", 3848864755U), default(IGameObject), 1F);
            Engine.print("x08 foley 11 start");
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task x08_score_11()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\music\\x08_11_mus", 3848799218U), default(IGameObject), 1F);
            Engine.print("x08 score 11 start");
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x08_0380_grv()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0380_grv", 3848930292U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0380_grv", 7F);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task x08_0390_grv()
        {
            await Engine.sleep(207);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0390_grv", 3848995829U), gravemind.Entity, 1F);
            Engine.cinematic_subtitle("x08_0390_grv", 8.5F);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task x08_teleport_build()
        {
            await Engine.sleep(470);
            Engine.print("effect - teleport build");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_01.Entity, "teleport06");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_02.Entity, "teleport06");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_03.Entity, "teleport06");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_04.Entity, "teleport06");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_01.Entity, "teleport05");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_02.Entity, "teleport05");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_03.Entity, "teleport05");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_04.Entity, "teleport05");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_01.Entity, "teleport04");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_02.Entity, "teleport04");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_03.Entity, "teleport04");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_04.Entity, "teleport04");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_01.Entity, "teleport03");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_02.Entity, "teleport03");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_03.Entity, "teleport03");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_04.Entity, "teleport03");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_01.Entity, "teleport02");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_02.Entity, "teleport02");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_03.Entity, "teleport02");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_04.Entity, "teleport02");
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_01.Entity, "teleport01");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_02.Entity, "teleport01");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_03.Entity, "teleport01");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3849061366U), tentacle_capture_04.Entity, "teleport01");
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task x08_teleport_characters()
        {
            await Engine.sleep(470);
            Engine.print("effect - teleport dervish");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\regret_teleport", 3849454588U), dervish.Entity, "body");
            await Engine.sleep(5);
            Engine.print("effect - teleport chief");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\regret_teleport", 3849454588U), chief.Entity, "body");
        }

        [ScriptMethod(118, Lifecycle.Static)]
        public async Task x08_11_setup()
        {
            Engine.wake(new ScriptMethodReference(x08_score_11));
            Engine.wake(new ScriptMethodReference(x08_foley_11));
            Engine.wake(new ScriptMethodReference(x08_0380_grv));
            Engine.wake(new ScriptMethodReference(x08_0390_grv));
            Engine.wake(new ScriptMethodReference(x08_teleport_build));
            Engine.wake(new ScriptMethodReference(x08_teleport_characters));
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x08_11_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(gravemind.Entity);
            Engine.object_destroy(tentacle_chief.Entity);
            Engine.object_destroy(tentacle_arbiter.Entity);
            Engine.object_destroy_containing("tentacle_capture");
        }

        [ScriptMethod(120, Lifecycle.Static)]
        public async Task x08_scene_11()
        {
            await this.x08_11_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3845456831U), "x08_11", default(IUnit), anchor_flag_x08);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3845522368U), "chief_11", false, anchor_x08.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3846177738U), "dervish_11", false, anchor_x08.Entity);
            Engine.custom_animation_relative(gravemind.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3845587905U), "gm_mouth_11", false, anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3845718979U), "tc_mc_11", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_arbiter.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3846308812U), "tc_arb_11", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven01_11", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven02_11", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven03_11", anchor_x08.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3845784516U), "tc_driven04_11", anchor_x08.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(0F, 0F, 0F, 5);
            await Engine.sleep(5);
            Engine.wake(new ScriptMethodReference(x08_11_cleanup));
            await Engine.sleep(30);
        }

        [ScriptMethod(121, Lifecycle.Static)]
        public async Task x08()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("gravemind"));
            await Engine.sleep(1);
            await this.x08_scene_01();
            await this.x08_scene_02();
            await this.x08_scene_03();
            await this.x08_scene_04();
            await this.x08_scene_05();
            await this.x08_scene_06a();
            await this.x08_scene_06b();
            await this.x08_scene_06c();
            await this.x08_scene_07();
            await this.x08_scene_08();
            await this.x08_scene_09();
            await this.x08_scene_10();
            await this.x08_scene_11();
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task c07_intro_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(18F, 56F, 0.227451F, 0.129412F, 0.223529F);
            Engine.cinematic_lighting_set_secondary_light(-26F, 134F, 0.196078F, 0.188235F, 0.286275F);
            Engine.cinematic_lighting_set_ambient_light(0.180392F, 0.176471F, 0.207843F);
            Engine.object_uses_cinematic_lighting(delta_halo.Entity, true);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task c07_intro_01_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(delta_halo);
            Engine.object_create_anew(matte_substance);
            Engine.object_create_anew(matte_high_charity);
            Engine.object_create_anew_containing("intro_fleet");
            Engine.object_create_anew_containing("stardust");
        }

        [ScriptMethod(124, Lifecycle.Static)]
        public async Task c07_intro_02_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(brute_intro_01);
            Engine.object_create_anew(brute_intro_02);
            Engine.object_create_anew(brute_intro_03);
            Engine.object_create_anew(brute_intro_04);
            Engine.object_create_anew(brute_05);
            Engine.object_create_anew(brute_06);
            Engine.object_create_anew(grunt_01);
            Engine.object_create_anew(grunt_02);
            Engine.object_create_anew(grunt_03);
            Engine.object_create_anew(grunt_04);
            Engine.object_create_anew(grunt_05);
            Engine.object_create_anew(jackal_01);
            Engine.object_create_anew(jackal_02);
            Engine.object_create_anew_containing("intro_pike");
            Engine.object_create_anew_containing("intro_crowd");
            Engine.object_cinematic_lod(brute_intro_01.Entity, true);
            Engine.object_cinematic_lod(brute_intro_02.Entity, true);
            Engine.object_cinematic_lod(brute_intro_03.Entity, true);
            Engine.object_cinematic_lod(brute_intro_04.Entity, true);
            Engine.object_cinematic_lod(brute_05.Entity, true);
            Engine.object_cinematic_lod(brute_06.Entity, true);
            Engine.object_cinematic_lod(grunt_01.Entity, true);
            Engine.object_cinematic_lod(grunt_02.Entity, true);
            Engine.object_cinematic_lod(grunt_03.Entity, true);
            Engine.object_cinematic_lod(grunt_04.Entity, true);
            Engine.object_cinematic_lod(grunt_05.Entity, true);
            Engine.object_cinematic_lod(jackal_01.Entity, true);
            Engine.object_cinematic_lod(jackal_02.Entity, true);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task c07_intro_01_cleanup()
        {
            Engine.object_destroy(delta_halo.Entity);
            Engine.object_destroy(matte_substance.Entity);
            Engine.object_destroy(matte_high_charity.Entity);
            Engine.object_destroy_containing("fleet");
            Engine.object_destroy_containing("stardust");
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task c07_intro_scene_01()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.wake(new ScriptMethodReference(c07_intro_cinematic_light_01));
            Engine.camera_control(true);
            Engine.cinematic_start_movie("highcharity_intro");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._07_intro_01_predict_stub();
            Engine.wake(new ScriptMethodReference(c07_intro_01_problem_actors));
            await Engine.sleep(this.prediction_offset);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intro\\07_intro", 3850241032U), "07_intro_01", default(IUnit), anchor_flag_intro_a);
            Engine.scenery_animation_start_relative(delta_halo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\07_intro\\07_intro", 3850306569U), "halo_01", anchor_intro_a.Entity);
            Engine.scenery_animation_start_relative(matte_high_charity.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\07_intro\\07_intro", 3850372106U), "high_charity_exterior_01", anchor_intro_a.Entity);
            Engine.scenery_animation_start_relative(matte_substance.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\07_intro\\07_intro", 3850437643U), "substance_01", anchor_intro_a.Entity);
            Engine.scenery_animation_start_relative(stardust_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\07_intro\\07_intro", 3850503180U), "stardust01_01", anchor_intro_a.Entity);
            Engine.scenery_animation_start_relative(stardust_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\07_intro\\07_intro", 3850503180U), "stardust02_01", anchor_intro_a.Entity);
            await Engine.sleep(15);
            Engine.fade_in(0F, 0F, 0F, 60);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intro_02_predict_stub();
            await this.c07_intro_02_problem_actors();
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_02_fol", 3850568717U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c07_intro_01_cleanup();
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task c07_intro_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_02_fol", 3850568717U), default(IGameObject), 1F);
            Engine.print("c07_intro foley 02 start");
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task c07_1010_pot()
        {
            await Engine.sleep(200);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1010_pot", 3850634254U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c07_1010_pot", 3F);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task c07_intro_dof_02()
        {
            Engine.time_code_reset();
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0F, 1F, 1F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(83);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 1F, 0.5F, 1F, 0F, 0.5F);
            Engine.print("rack focus");
            await Engine.sleep(56);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task lightmap_shadows_on()
        {
            await Engine.sleep(141);
            Engine.print("enable lightmap shadows");
            Engine.cinematic_lightmap_shadow_enable();
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task c07_intro_cinematic_light_02()
        {
            Engine.cinematic_lighting_set_primary_light(25F, 190F, 0.470588F, 0.368627F, 0.541176F);
            Engine.cinematic_lighting_set_secondary_light(-36F, 0F, 0.160784F, 0.176471F, 0.345098F);
            Engine.cinematic_lighting_set_ambient_light(0.105882F, 0.0941177F, 0.0784314F);
            Engine.object_uses_cinematic_lighting(brute_intro_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_intro_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_intro_03.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_intro_04.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_05.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_06.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_01.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_02.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_03.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_04.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_05.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_01.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_02.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_pike_01.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_pike_02.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_pike_03.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_pike_04.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_pike_05.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_pike_06.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_01.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_02.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_03.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_04.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_05.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_06.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_07.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_08.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_09.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_10.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_11.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_12.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_13.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_crowd_14.Entity, true);
        }

        [ScriptMethod(132, Lifecycle.Static)]
        public async Task c07_intro_03_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(truth_intro);
            Engine.object_create_anew(mercy_intro);
            Engine.object_create_anew(throne_truth_intro);
            Engine.object_create_anew(throne_mercy_intro);
            Engine.object_create_anew(index_intro);
            Engine.object_cinematic_lod(truth_intro.Entity, true);
            Engine.object_cinematic_lod(mercy_intro.Entity, true);
            Engine.object_cinematic_lod(throne_truth_intro.Entity, true);
            Engine.object_cinematic_lod(throne_mercy_intro.Entity, true);
            Engine.object_cinematic_lod(index_intro.Entity, true);
            Engine.objects_attach(truth_intro.Entity, "driver", throne_truth_intro.Entity, "driver_cinematic");
            Engine.objects_attach(mercy_intro.Entity, "driver", throne_mercy_intro.Entity, "driver_cinematic");
        }

        [ScriptMethod(133, Lifecycle.Static)]
        public async Task c07_intro_02_setup()
        {
            Engine.wake(new ScriptMethodReference(c07_intro_foley_02));
            Engine.wake(new ScriptMethodReference(c07_1010_pot));
            Engine.wake(new ScriptMethodReference(lightmap_shadows_on));
            Engine.wake(new ScriptMethodReference(c07_intro_dof_02));
            Engine.wake(new ScriptMethodReference(c07_intro_cinematic_light_02));
            if (GameDifficulty.Legendary() == Engine.game_difficulty_get_real())
            {
                Engine.object_create_anew(grunt_card);
            }
        }

        [ScriptMethod(134, Lifecycle.Static)]
        public async Task c07_intro_02_cleanup()
        {
            Engine.object_destroy(grunt_03.Entity);
            Engine.object_destroy(grunt_04.Entity);
            Engine.object_destroy(grunt_05.Entity);
            Engine.object_destroy(jackal_01.Entity);
            Engine.object_destroy(jackal_02.Entity);
            Engine.object_destroy(grunt_card.Entity);
            Engine.object_destroy_containing("intro_crowd");
        }

        [ScriptMethod(135, Lifecycle.Static)]
        public async Task c07_intro_scene_02()
        {
            await this.c07_intro_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intro\\07_intro", 3850241032U), "07_intro_02", default(IUnit), anchor_flag_intro_c);
            Engine.custom_animation_relative(brute_intro_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute01_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute02_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute03_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute04_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute05_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute06_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt01_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt02_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt03_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt04_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt05_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(jackal_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\07_intro\\07_intro", 3850896402U), "jackal01_02", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(jackal_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\07_intro\\07_intro", 3850896402U), "jackal02_02", false, anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike01_02", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike02_02", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike03_02", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike04_02", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike05_02", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike06_02", anchor_intro_c.Entity);
            await Engine.sleep(5);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intro_03_predict_stub();
            await this.c07_intro_03_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_03_fol", 3851027476U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_intro_02_cleanup();
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task c07_intro_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_03_fol", 3851027476U), default(IGameObject), 1F);
            Engine.print("c07_intro foley 03 start");
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task c07_1020_pot()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1020_pot", 3851093013U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c07_1020_pot", 6F);
            Engine.unit_set_emotional_state(truth_intro.Entity, "pensive", 0.25F, 0);
            Engine.print("truth - pensive .25 0");
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task c07_1030_pot()
        {
            await Engine.sleep(181);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1030_pot", 3851158550U), truth_intro.Entity, 1F);
            Engine.cinematic_subtitle("c07_1030_pot", 9F);
            await Engine.sleep(180);
            Engine.unit_set_emotional_state(truth_intro.Entity, "happy", 0.25F, 90);
            Engine.print("truth - happy .25 90");
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task c07_1040_pot()
        {
            await Engine.sleep(451);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1040_pot", 3851224087U), truth_intro.Entity, 1F);
            Engine.cinematic_subtitle("c07_1040_pot", 6F);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task c07_intro_03_fov()
        {
            Engine.time_code_reset();
            await Engine.sleep(178);
            Engine.print("change fov");
            Engine.camera_set_field_of_view(40F, 0);
            Engine.time_code_reset();
            await Engine.sleep(166);
            Engine.print("change fov");
            Engine.camera_set_field_of_view(50F, 0);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task c07_intro_cinematic_light_03()
        {
            Engine.cinematic_lighting_set_primary_light(44F, 166F, 0.317647F, 0.282353F, 0.376471F);
            Engine.cinematic_lighting_set_secondary_light(-69F, 348F, 0.290196F, 0.227451F, 0.537255F);
            Engine.cinematic_lighting_set_ambient_light(0.054902F, 0.0470588F, 0.0392157F);
            Engine.object_uses_cinematic_lighting(truth_intro.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy_intro.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_truth_intro.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_mercy_intro.Entity, true);
            Engine.object_uses_cinematic_lighting(index_intro.Entity, true);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task texture_camera_start()
        {
            Engine.time_code_reset();
            await Engine.sleep(178);
            Engine.print("texture camera start");
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            Engine.object_hide(mercy.Entity, true);
            Engine.object_hide(throne_mercy.Entity, true);
            Engine.object_hide(brute_intro_01.Entity, true);
            Engine.object_hide(brute_intro_02.Entity, true);
            Engine.object_hide(brute_intro_03.Entity, true);
            Engine.object_hide(brute_intro_04.Entity, true);
            Engine.object_hide(brute_05.Entity, true);
            Engine.object_hide(brute_06.Entity, true);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task texture_camera_stop()
        {
            await Engine.sleep(344);
            Engine.print("texture camera stop");
            Engine.texture_camera_off();
            Engine.object_hide(mercy.Entity, false);
            Engine.object_hide(throne_mercy.Entity, false);
            Engine.object_hide(brute_intro_01.Entity, false);
            Engine.object_hide(brute_intro_02.Entity, false);
            Engine.object_hide(brute_intro_03.Entity, false);
            Engine.object_hide(brute_intro_04.Entity, false);
            Engine.object_hide(brute_05.Entity, false);
            Engine.object_hide(brute_06.Entity, false);
        }

        [ScriptMethod(144, Lifecycle.Static)]
        public async Task c07_intro_03_setup()
        {
            Engine.cinematic_lightmap_shadow_disable();
            Engine.object_create_anew(chief_needler);
            Engine.object_create_anew(texture_camera);
            Engine.object_create_anew(holo_cam);
            Engine.object_cinematic_lod(chief_needler.Entity, true);
            Engine.object_cinematic_lod(holo_cam.Entity, true);
            Engine.objects_attach(grunt_02.Entity, "right_hand", chief_needler.Entity, "");
            Engine.wake(new ScriptMethodReference(c07_intro_foley_03));
            Engine.wake(new ScriptMethodReference(c07_1020_pot));
            Engine.wake(new ScriptMethodReference(c07_1030_pot));
            Engine.wake(new ScriptMethodReference(c07_1040_pot));
            Engine.wake(new ScriptMethodReference(c07_intro_03_fov));
            Engine.wake(new ScriptMethodReference(texture_camera_start));
            Engine.wake(new ScriptMethodReference(texture_camera_stop));
            Engine.wake(new ScriptMethodReference(c07_intro_cinematic_light_03));
        }

        [ScriptMethod(145, Lifecycle.Static)]
        public async Task c07_intro_03_cleanup()
        {
            Engine.object_destroy(brute_intro_03.Entity);
            Engine.object_destroy(brute_intro_04.Entity);
            Engine.object_destroy(brute_05.Entity);
            Engine.object_destroy(brute_06.Entity);
        }

        [ScriptMethod(146, Lifecycle.Static)]
        public async Task c07_intro_scene_03()
        {
            await this.c07_intro_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intro\\07_intro", 3850241032U), "07_intro_03", default(IUnit), anchor_flag_intro_c);
            Engine.custom_animation_relative(truth_intro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intro\\07_intro", 3851289624U), "truth_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(mercy_intro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intro\\07_intro", 3851289624U), "mercy_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute01_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute02_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute03_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute04_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute05_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute06_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt01_03", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt02_03", false, anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(texture_camera.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\07_intro\\07_intro", 3851420698U), "tex_camera_03", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(holo_cam.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\holo_cam\\07_intro\\07_intro", 3851486235U), "holo_cam_03", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(index_intro.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\07_intro\\07_intro", 3851551772U), "index_03", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike01_03", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike02_03", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike03_03", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike04_03", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike05_03", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike06_03", anchor_intro_c.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intro_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_04_fol", 3851617309U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_intro_03_cleanup();
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task c07_intro_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_04_fol", 3851617309U), default(IGameObject), 1F);
            Engine.print("c07_intro foley 04 start");
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task c07_1050_pot()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1050_pot", 3851682846U), truth_intro.Entity, 1F);
            Engine.cinematic_subtitle("c07_1050_pot", 5F);
            Engine.unit_set_emotional_state(truth_intro.Entity, "happy", 0.25F, 0);
            Engine.unit_set_emotional_state(truth_intro.Entity, "happy", 0.5F, 60);
            Engine.print("truth - happy .5 60");
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task c07_1060_mas()
        {
            await Engine.sleep(217);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1060_mas", 3851748383U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c07_1060_mas", 1F);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task c07_1070_crz()
        {
            await Engine.sleep(236);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1070_crz", 3851813920U), grunt_01.Entity, 1F);
            Engine.cinematic_subtitle("c07_1070_crz", 2F);
            Engine.unit_set_emotional_state(truth_intro.Entity, "shocked", 0.75F, 0);
            Engine.print("truth - shocked .75 0");
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task c07_1080_pot()
        {
            await Engine.sleep(412);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1080_pot", 3851879457U), truth_intro.Entity, 1F);
            Engine.cinematic_subtitle("c07_1080_pot", 2F);
            await Engine.sleep(30);
            Engine.unit_set_emotional_state(truth_intro.Entity, "arrogant", 0.5F, 30);
            Engine.print("truth - arrogant .5 30");
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task effect_chief_teleport()
        {
            Engine.print("effect - teleport");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\cinematic_teleport", 3851944994U), teleport.Entity, "marker");
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task intro_chief_arrival()
        {
            await Engine.sleep(142);
            Engine.print("chief arrival");
            Engine.custom_animation_relative(chief_intro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intro\\07_intro", 3852076068U), "chief_04", false, anchor_intro_c.Entity);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task needler_attach()
        {
            Engine.time_code_reset();
            await Engine.sleep(230);
            Engine.objects_detach(grunt_02.Entity, chief_needler.Entity);
            Engine.print("needler detach");
            await Engine.sleep(80);
            Engine.objects_attach(chief_intro.Entity, "right_hand", chief_needler.Entity, "");
            Engine.print("needler attach");
        }

        [ScriptMethod(155, Lifecycle.Static)]
        public async Task c07_intro_04_setup()
        {
            Engine.object_create_anew(teleport);
            Engine.object_create_anew(chief_intro);
            Engine.object_cinematic_lod(chief_intro.Entity, true);
            Engine.object_uses_cinematic_lighting(chief_intro.Entity, true);
            Engine.render_lights_enable_cinematic_shadow(true, chief_intro.Entity, "head", 0.4F);
            Engine.wake(new ScriptMethodReference(c07_intro_foley_04));
            Engine.wake(new ScriptMethodReference(c07_1050_pot));
            Engine.wake(new ScriptMethodReference(c07_1060_mas));
            Engine.wake(new ScriptMethodReference(c07_1070_crz));
            Engine.wake(new ScriptMethodReference(c07_1080_pot));
            Engine.wake(new ScriptMethodReference(intro_chief_arrival));
            Engine.wake(new ScriptMethodReference(needler_attach));
            Engine.wake(new ScriptMethodReference(effect_chief_teleport));
        }

        [ScriptMethod(156, Lifecycle.Static)]
        public async Task c07_intro_04_cleanup()
        {
            Engine.object_destroy(chief_intro.Entity);
            Engine.object_destroy_containing("truth");
            Engine.object_destroy_containing("mercy");
            Engine.object_destroy(brute_intro_01.Entity);
            Engine.object_destroy(brute_intro_02.Entity);
            Engine.object_destroy(grunt_01.Entity);
            Engine.object_destroy(grunt_02.Entity);
            Engine.object_destroy(index_intro.Entity);
            Engine.object_destroy(holo_cam.Entity);
            Engine.object_destroy(teleport.Entity);
            Engine.object_destroy_containing("intro_pike");
            Engine.object_destroy(chief_needler.Entity);
        }

        [ScriptMethod(157, Lifecycle.Static)]
        public async Task c07_intro_scene_04()
        {
            await this.c07_intro_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intro\\07_intro", 3850241032U), "07_intro_04", default(IUnit), anchor_flag_intro_c);
            Engine.custom_animation_relative(truth_intro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intro\\07_intro", 3851289624U), "truth_04", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(mercy_intro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intro\\07_intro", 3851289624U), "mercy_04", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute01_04", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(brute_intro_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3850699791U), "brute02_04", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt01_04", false, anchor_intro_c.Entity);
            Engine.custom_animation_relative(grunt_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3850830865U), "grunt02_04", false, anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(index_intro.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\07_intro\\07_intro", 3851551772U), "index_04", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(texture_camera.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\07_intro\\07_intro", 3851420698U), "tex_camera_04", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(holo_cam.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\holo_cam\\07_intro\\07_intro", 3851486235U), "holo_cam_04", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike01_04", anchor_intro_c.Entity);
            Engine.scenery_animation_start_relative(intro_pike_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3850961939U), "pike02_04", anchor_intro_c.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c07_intro_04_cleanup();
        }

        [ScriptMethod(158, Lifecycle.Static)]
        public async Task c07_intro()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.sound_class_set_gain("amb", 0F, 15);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_0"));
            await Engine.sleep(1);
            await this.c07_intro_scene_01();
            Engine.sound_class_set_gain("amb", 1F, 15);
            await this.c07_intro_scene_02();
            await this.c07_intro_scene_03();
            await this.c07_intro_scene_04();
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task c07_intra1_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\music\\c07_intra1_01_mus", 3852141605U), default(IGameObject), 1F);
            Engine.print("c07_intra1 score 01 start");
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_01_fol", 3852207142U), default(IGameObject), 1F);
            Engine.print("c07_intra1 foley 01 start");
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task c07_2010_tar()
        {
            await Engine.sleep(128);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2010_tar", 3852272679U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c07_2010_tar", 2F);
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task c07_intra1_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(23F, 74F, 0.258824F, 0.270588F, 0.368627F);
            Engine.cinematic_lighting_set_secondary_light(-40F, 276F, 0.407843F, 0.345098F, 0.317647F);
            Engine.cinematic_lighting_set_ambient_light(0.0431373F, 0.0470588F, 0.0666667F);
            Engine.object_uses_cinematic_lighting(truth.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(monitor.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_03.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_04.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_truth.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_01.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_02.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_03.Entity, true);
            Engine.object_uses_cinematic_lighting(hammer.Entity, true);
            Engine.object_uses_cinematic_lighting(intra_pike_01.Entity, true);
            Engine.object_uses_cinematic_lighting(intra_pike_02.Entity, true);
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task hide_pikes()
        {
            Engine.time_code_reset();
            await Engine.sleep(300);
            Engine.print("hide pikes");
            Engine.object_hide(intra_pike_01.Entity, true);
            Engine.object_hide(intra_pike_02.Entity, true);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task show_pikes()
        {
            await Engine.sleep(400);
            Engine.print("show pikes");
            Engine.object_hide(intra_pike_01.Entity, false);
            Engine.object_hide(intra_pike_02.Entity, false);
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task johnson_emotion()
        {
            Engine.unit_set_emotional_state(johnson.Entity, "angry", 0.25F, 0);
            await Engine.sleep(277);
            Engine.unit_set_emotional_state(johnson.Entity, "pain", 0.5F, 30);
            Engine.print("johnson - pain .5 30");
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task miranda_emotion()
        {
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.1F, 0);
            await Engine.sleep(375);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.4F, 60);
            Engine.print("miranda - shocked .25 60");
        }

        [ScriptMethod(167, Lifecycle.Static)]
        public async Task c07_intra1_01_setup()
        {
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(truth);
            Engine.object_create_anew(mercy);
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_02);
            Engine.object_create_anew(brute_03);
            Engine.object_create_anew(brute_04);
            Engine.object_create_anew(monitor);
            Engine.object_create_anew(hammer);
            Engine.object_create_anew(throne_truth);
            Engine.object_create_anew(throne_mercy);
            Engine.object_create_anew(phantom_01);
            Engine.object_create_anew(phantom_02);
            Engine.object_create_anew(phantom_03);
            Engine.object_create_anew_containing("intra_pike");
            Engine.object_set_function_variable(monitor.Entity, "talking", 0F, 0F);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(truth.Entity, true);
            Engine.object_cinematic_lod(mercy.Entity, true);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
            Engine.object_cinematic_lod(brute_03.Entity, true);
            Engine.object_cinematic_lod(brute_04.Entity, true);
            Engine.object_cinematic_lod(monitor.Entity, true);
            Engine.object_cinematic_lod(hammer.Entity, true);
            Engine.object_cinematic_lod(throne_truth.Entity, true);
            Engine.object_cinematic_lod(throne_mercy.Entity, true);
            Engine.object_cinematic_lod(phantom_01.Entity, true);
            Engine.object_cinematic_lod(phantom_02.Entity, true);
            Engine.object_cinematic_lod(phantom_03.Entity, true);
            Engine.objects_attach(truth.Entity, "driver", throne_truth.Entity, "driver_cinematic");
            Engine.objects_attach(mercy.Entity, "driver", throne_mercy.Entity, "driver_cinematic");
            Engine.wake(new ScriptMethodReference(c07_intra1_score_01));
            Engine.wake(new ScriptMethodReference(c07_intra1_foley_01));
            Engine.wake(new ScriptMethodReference(c07_2010_tar));
            Engine.wake(new ScriptMethodReference(johnson_emotion));
            Engine.wake(new ScriptMethodReference(miranda_emotion));
            Engine.wake(new ScriptMethodReference(hide_pikes));
            Engine.wake(new ScriptMethodReference(show_pikes));
            Engine.wake(new ScriptMethodReference(c07_intra1_cinematic_light_01));
        }

        [ScriptMethod(168, Lifecycle.Static)]
        public async Task c07_intra1_01_cleanup()
        {
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy(monitor.Entity);
            Engine.object_destroy(brute_01.Entity);
            Engine.object_destroy(brute_02.Entity);
        }

        [ScriptMethod(169, Lifecycle.Static)]
        public async Task c07_intra1_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("highcharity_intra1");
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this._07_intra1_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_01_fol", 3852207142U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\music\\c07_intra1_01_mus", 3852141605U));
            await Engine.sleep(this.prediction_offset);
            await this.c07_intra1_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3852338216U), "07_intra1_01", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\07_intra1\\07_intra1", 3852403753U), "miranda_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\07_intra1\\07_intra1", 3857187954U), "johnson_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3857319028U), "truth_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3857319028U), "mercy_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\07_intra1\\07_intra1", 3857384565U), "monitor_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "tartarus_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute01_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute02_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute03_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute04_01", false, anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\07_intra1\\07_intra1", 3857515639U), "hammer_01", anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(intra_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3857581176U), "pike01_01", anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(intra_pike_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3857581176U), "pike02_01", anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom1_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom2_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom3_01", false, anchor_intra1.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intra1_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_02_fol", 3857712250U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_intra1_01_cleanup();
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_02_fol", 3857712250U), default(IGameObject), 1F);
            Engine.print("c07_intra1 foley 02 start");
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task c07_2020_pot()
        {
            await Engine.sleep(52);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2020_pot", 3857777787U), truth.Entity, 1F);
            Engine.cinematic_subtitle("c07_2020_pot", 4F);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task c07_2030_tar()
        {
            await Engine.sleep(163);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2030_tar", 3857843324U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c07_2030_tar", 4F);
            await Engine.sleep(90);
            Engine.print("spawn infection-forms");
            Engine.ai_place(c07_infection.Squad);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task c07_intra1_02_fov_01()
        {
            await Engine.sleep(347);
            Engine.print("fov change: 60 -> 8 over 20 ticks");
            Engine.camera_set_field_of_view(8F, 20);
        }

        [ScriptMethod(174, Lifecycle.Static)]
        public async Task c07_intra1_02_setup()
        {
            Engine.object_cannot_take_damage(truth.Entity);
            Engine.object_cannot_take_damage(mercy.Entity);
            Engine.object_cannot_take_damage(tartarus.Entity);
            Engine.object_cannot_take_damage(brute_03.Entity);
            Engine.object_cannot_take_damage(brute_04.Entity);
            Engine.object_cannot_take_damage(infection_form_01.Entity);
            Engine.object_cannot_take_damage(infection_form_02.Entity);
            Engine.object_create_anew(infection_form_01);
            Engine.object_create_anew(index);
            Engine.object_cinematic_lod(infection_form_01.Entity, true);
            Engine.object_cinematic_lod(index.Entity, true);
            Engine.wake(new ScriptMethodReference(c07_intra1_foley_02));
            Engine.wake(new ScriptMethodReference(c07_2020_pot));
            Engine.wake(new ScriptMethodReference(c07_2030_tar));
            Engine.wake(new ScriptMethodReference(c07_intra1_02_fov_01));
        }

        [ScriptMethod(175, Lifecycle.Static)]
        public async Task c07_intra1_02_cleanup()
        {
            Engine.objects_detach(mercy.Entity, throne_mercy.Entity);
            Engine.object_destroy(mercy.Entity);
            Engine.object_hide(index.Entity, true);
        }

        [ScriptMethod(176, Lifecycle.Static)]
        public async Task c07_intra1_scene_02()
        {
            await this.c07_intra1_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3852338216U), "07_intra1_02", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3857319028U), "truth_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3857319028U), "mercy_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "tartarus_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute03_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute04_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(infection_form_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3857908861U), "infection01_02", false, anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\07_intra1\\07_intra1", 3857515639U), "hammer_02", anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(index.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\07_intra1\\07_intra1", 3857974398U), "index_02", anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(intra_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3857581176U), "pike01_02", anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom1_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom2_02", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom3_02", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intra1_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_03_fol", 3858039935U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_intra1_02_cleanup();
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_03_fol", 3858039935U), default(IGameObject), 1F);
            Engine.print("c07_intra1 foley 03 start");
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task c07_2040_pom()
        {
            await Engine.sleep(295);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2040_pom", 3858105472U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("c07_2040_pom", 4F);
            Engine.unit_set_emotional_state(mercy.Entity, "scared", 1F, 30);
            Engine.print("mercy - scared 1 30");
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task effect_infection_burrow()
        {
            await Engine.sleep(302);
            Engine.print("effect - infection burrow");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\07\\flood_burrowing", 3858171009U), infection_form_02.Entity, "mouth");
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task infection_pop_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(162);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3858236546U), infection_form_01.Entity, "");
            Engine.object_hide(infection_form_01.Entity, true);
            await Engine.sleep(51);
            Engine.object_hide(infection_form_01.Entity, false);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3858236546U), infection_form_01.Entity, "");
            Engine.object_hide(infection_form_01.Entity, true);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task infection_pop_02()
        {
            await Engine.sleep(171);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3858236546U), infection_form_02.Entity, "");
            Engine.object_hide(infection_form_02.Entity, true);
            await Engine.sleep(2);
            Engine.object_hide(infection_form_02.Entity, false);
            await Engine.sleep(7);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3858236546U), infection_form_02.Entity, "");
            Engine.object_hide(infection_form_02.Entity, true);
            await Engine.sleep(9);
            Engine.object_hide(infection_form_02.Entity, false);
            await Engine.sleep(17);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3858236546U), infection_form_02.Entity, "");
            Engine.object_hide(infection_form_02.Entity, true);
            await Engine.sleep(10);
            Engine.object_hide(infection_form_02.Entity, false);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task kill_infection_forms()
        {
            await Engine.sleep(158);
            Engine.print("erase infection forms");
            Engine.ai_erase(c07_infection.Squad);
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task delete_mercy_throne()
        {
            await Engine.sleep(308);
            Engine.print("destroy mercy's throne");
            Engine.object_destroy(throne_mercy.Entity);
        }

        [ScriptMethod(184, Lifecycle.Static)]
        public async Task c07_intra1_03_setup()
        {
            Engine.object_create_anew(mercy_no_crown);
            Engine.object_create_anew(infection_form_02);
            Engine.object_cinematic_lod(mercy_no_crown.Entity, true);
            Engine.object_cinematic_lod(infection_form_02.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy_no_crown.Entity, true);
            Engine.object_uses_cinematic_lighting(infection_form_02.Entity, true);
            Engine.objects_attach(mercy_no_crown.Entity, "driver", throne_mercy.Entity, "driver_cinematic");
            Engine.wake(new ScriptMethodReference(c07_intra1_foley_03));
            Engine.wake(new ScriptMethodReference(c07_2040_pom));
            Engine.wake(new ScriptMethodReference(delete_mercy_throne));
            Engine.wake(new ScriptMethodReference(kill_infection_forms));
            Engine.wake(new ScriptMethodReference(infection_pop_01));
            Engine.wake(new ScriptMethodReference(infection_pop_02));
            Engine.wake(new ScriptMethodReference(effect_infection_burrow));
        }

        [ScriptMethod(185, Lifecycle.Static)]
        public async Task c07_intra1_03_cleanup()
        {
            Engine.object_destroy(infection_form_02.Entity);
            Engine.object_destroy(hammer.Entity);
            Engine.object_destroy_containing("intra_pike");
        }

        [ScriptMethod(186, Lifecycle.Static)]
        public async Task c07_intra1_scene_03()
        {
            await this.c07_intra1_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3852338216U), "07_intra1_03", default(IUnit), anchor_flag_intra1);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3857319028U), "truth_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(mercy_no_crown.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3857319028U), "mercy_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "tartarus_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute03_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute04_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(infection_form_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3857908861U), "infection01_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(infection_form_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3857908861U), "infection02_03", false, anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\07_intra1\\07_intra1", 3857515639U), "hammer_03", anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(intra_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3857581176U), "pike01_03", anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(intra_pike_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3857581176U), "pike02_03", anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom1_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom2_03", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom3_03", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intra1_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_04_fol", 3858957453U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_intra1_03_cleanup();
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_04_fol", 3858957453U), default(IGameObject), 1F);
            Engine.print("c07_intra1 foley 04 start");
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task c07_2050_pot()
        {
            await Engine.sleep(64);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2050_pot", 3859022990U), truth.Entity, 1F);
            Engine.cinematic_subtitle("c07_2050_pot", 1F);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task c07_2060_pot()
        {
            await Engine.sleep(132);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2060_pot", 3859088527U), truth.Entity, 1F);
            Engine.cinematic_subtitle("c07_2060_pot", 3F);
            await Engine.sleep(45);
            Engine.unit_set_emotional_state(tartarus.Entity, "pensive", 0.5F, 60);
            Engine.print("tartarus - shocked .5 60");
            Engine.unit_set_emotional_state(mercy.Entity, "shocked", 1F, 0);
            Engine.print("mercy - shocked 1 0");
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task c07_2070_pot()
        {
            await Engine.sleep(231);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2070_pot", 3859154064U), truth.Entity, 1F);
            Engine.cinematic_subtitle("c07_2070_pot", 2F);
            Engine.unit_set_emotional_state(mercy.Entity, "pain", 1F, 60);
            Engine.print("mercy - pain 1 60");
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task c07_intra1_dof_04()
        {
            Engine.time_code_reset();
            await Engine.sleep(384);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 0.75F, 0.75F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(106);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 0.75F, 0F, 0.5F, 0F, 0.75F, 0.5F);
            Engine.print("rack focus");
        }

        [ScriptMethod(192, Lifecycle.Static)]
        public async Task c07_intra1_04_setup()
        {
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\07\\flood_burrowing", 3858171009U), infection_form_01.Entity, "mouth");
            Engine.object_hide(index.Entity, false);
            Engine.object_hide(infection_form_01.Entity, false);
            Engine.wake(new ScriptMethodReference(c07_intra1_foley_04));
            Engine.wake(new ScriptMethodReference(c07_2050_pot));
            Engine.wake(new ScriptMethodReference(c07_2060_pot));
            Engine.wake(new ScriptMethodReference(c07_2070_pot));
            Engine.wake(new ScriptMethodReference(c07_intra1_dof_04));
            Engine.unit_set_emotional_state(tartarus.Entity, "shocked", 0.5F, 0);
            Engine.print("tartarus - shocked .5 0");
        }

        [ScriptMethod(193, Lifecycle.Static)]
        public async Task c07_intra1_04_cleanup()
        {
            Engine.object_destroy(truth.Entity);
            Engine.object_destroy(mercy_no_crown.Entity);
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy(brute_03.Entity);
            Engine.object_destroy(brute_04.Entity);
            Engine.object_destroy(infection_form_01.Entity);
            Engine.object_destroy(throne_mercy.Entity);
            Engine.object_destroy(phantom_01.Entity);
            Engine.object_destroy(phantom_02.Entity);
            Engine.object_destroy(phantom_03.Entity);
            Engine.object_destroy(index.Entity);
        }

        [ScriptMethod(194, Lifecycle.Static)]
        public async Task c07_intra1_scene_04()
        {
            await this.c07_intra1_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3852338216U), "07_intra1_04", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3857319028U), "truth_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(mercy_no_crown.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3857319028U), "mercy_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "tartarus_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute03_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3857450102U), "brute04_04", false, anchor_intra1.Entity);
            Engine.scenery_animation_start_relative(index.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\07_intra1\\07_intra1", 3857974398U), "index_04", anchor_intra1.Entity);
            Engine.custom_animation_relative(infection_form_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3857908861U), "infection01_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom1_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom2_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3857646713U), "phantom3_04", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 60));
            Engine.fade_out(0F, 0F, 0F, 60);
            await Engine.sleep(60);
            await this.c07_intra1_04_cleanup();
            Engine.cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(195, Lifecycle.Static)]
        public async Task c07_intra1()
        {
            Engine.sound_class_set_gain("vehicle", 0.25F, 1);
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_5"));
            await Engine.sleep(1);
            await this.c07_intra1_scene_01();
            await this.c07_intra1_scene_02();
            await this.c07_intra1_scene_03();
            await this.c07_intra1_scene_04();
        }

        [ScriptMethod(196, Lifecycle.Static)]
        public async Task test()
        {
            Engine.print("effect - infection burrow");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\07\\flood_burrowing", 3858171009U), infection_form_02.Entity, "mouth");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\07\\flood_burrowing", 3858171009U), infection_form_01.Entity, "mouth");
        }

        [ScriptMethod(197, Lifecycle.CommandScript)]
        public async Task cs_jump()
        {
            Engine.cs_jump_to_point(0F, 5F);
        }

        [ScriptMethod(198, Lifecycle.CommandScript)]
        public async Task cs_abort()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(199, Lifecycle.CommandScript)]
        public async Task cs_alert()
        {
            Engine.cs_abort_on_alert(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task cs_alert_combat()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.sleep_forever();
        }

        [ScriptMethod(201, Lifecycle.Static)]
        public async Task test_rumble()
        {
            Engine.damage_object(Engine.GetTag<DamageEffectTag>("objects\\cinematics\\human\\inamberclad_to_scale\\damage_effects\\ioc_flyby", 2203656577U), await this.player0());
        }

        [ScriptMethod(202, Lifecycle.Static)]
        public async Task test_ioc()
        {
            Engine.object_create(ioc_effect);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\inamberclad_flyby\\slipspace", 2203722114U), rupture.Entity, 1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\inamberclad_flyby\\inamberclad_flyby", 2203853188U), default(IGameObject), 1F);
            await Engine.sleep(3);
            Engine.object_create(ioc);
            Engine.device_set_position_track(ioc.Entity, "high_charity_flyby", 0F);
            Engine.device_animate_position(ioc.Entity, 1F, 15F, 0F, 0F, false);
            await Engine.sleep(30);
            Engine.object_destroy(ioc_effect.Entity);
            await Engine.sleep(30);
            Engine.damage_object(Engine.GetTag<DamageEffectTag>("objects\\cinematics\\human\\inamberclad_to_scale\\damage_effects\\ioc_flyby", 2203656577U), await this.player0());
            await Engine.sleep_until(async () => Engine.device_get_position(ioc.Entity) >= 1F);
            Engine.object_destroy(ioc.Entity);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task bullshit()
        {
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.object_destroy_containing("bsp0_crate");
            Engine.object_destroy_containing("bsp1_crate");
            Engine.object_destroy_containing("bsp2_crate");
            Engine.object_destroy_containing("bsp2_body");
            await Engine.sleep(1);
            Engine.object_create_anew_containing("bsp3_body");
            Engine.object_create_anew_containing("bsp3_crate");
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 4);
            Engine.object_destroy_containing("bsp3_body");
            Engine.object_destroy_containing("bsp3_crate");
            await Engine.sleep(1);
            Engine.object_create_anew_containing("bsp3b_body");
            Engine.object_create_anew_containing("bsp3b_crate");
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 5);
            Engine.object_destroy_containing("bsp3b_body");
            Engine.object_destroy_containing("bsp3b_crate");
            await Engine.sleep(1);
            Engine.object_create_anew_containing("bsp4_body");
            Engine.object_create_anew_containing("bsp4_crate");
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task cs_expand_cortana()
        {
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.01F, 0);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            await Engine.sleep(5);
            Engine.object_dynamic_simulation_disable(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.unit_set_emotional_state(Engine.ai_get_unit(this.ai_current_actor), "pensive", 0.5F, 0);
            await Engine.sleep(1);
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), false);
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.65F, 20);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task cs_shrink_cortana()
        {
            Engine.cs_enable_dialogue(false);
            await Engine.sleep(60);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), Engine.ai_get_object(this.ai_current_actor), "effect");
            await Engine.sleep(3);
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.01F, 10);
            await Engine.sleep(30);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task ice_cream_angry()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ice_cream, Engine.players()));
            Engine.object_create(ice_cream_effect);
            Engine.object_create(ice_cream_head);
            Engine.ai_place(ice_cream_grunt.Squad);
            await Engine.sleep(1);
            Engine.device_set_position(ice_cream_effect.Entity, 1F);
            Engine.ai_set_active_camo(ice_cream_grunt.Squad, true);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head.weapon", 4238351075U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head.weapon", 4238351075U)));
            if (this.debug)
            {
                Engine.print("you're going to get fat!!!!! or dead...");
            }

            if (this.debug)
            {
                Engine.print("because now everyone is angry!!!!");
            }

            Engine.ice_cream_flavor_stock(13);
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task music_07a_01()
        {
            await Engine.sleep_until(async () => this.g_music_07a_01);
            if (this.debug)
            {
                Engine.print("start music 07a_01");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_01", 2204443021U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_07a_01));
            if (this.debug)
            {
                Engine.print("stop music 07a_01");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_01", 2204443021U));
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task music_07a_02()
        {
            await Engine.sleep_until(async () => this.g_music_07a_02);
            if (this.debug)
            {
                Engine.print("start music 07a_02");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_02", 2204836243U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_07a_02));
            if (this.debug)
            {
                Engine.print("stop music 07a_02");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_02", 2204836243U));
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task music_07a_03()
        {
            await Engine.sleep_until(async () => this.g_music_07a_03);
            if (this.debug)
            {
                Engine.print("start music 07a_03");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_03", 2205229465U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => this.g_music_07a_03_alt);
            if (this.debug)
            {
                Engine.print("set music 07a_03 alternate");
            }

            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_03", 2205229465U), true);
            await Engine.sleep_until(async () => !(this.g_music_07a_03));
            if (this.debug)
            {
                Engine.print("stop music 07a_03");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_03", 2205229465U));
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task music_07a_04()
        {
            await Engine.sleep_until(async () => this.g_music_07a_04);
            if (this.debug)
            {
                Engine.print("start music 07a_04");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_04", 2205753761U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => this.g_music_07a_04_alt);
            if (this.debug)
            {
                Engine.print("set music 07a_04 alternate");
            }

            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_04", 2205753761U), true);
            await Engine.sleep_until(async () => !(this.g_music_07a_04));
            if (this.debug)
            {
                Engine.print("stop music 07a_04");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_04", 2205753761U));
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task music_07a_05()
        {
            await Engine.sleep_until(async () => this.g_music_07a_05);
            if (this.debug)
            {
                Engine.print("start music 07a_05");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_05", 2206409131U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_07a_05));
            if (this.debug)
            {
                Engine.print("stop music 07a_05");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_05", 2206409131U));
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task music_07a_06()
        {
            await Engine.sleep_until(async () => this.g_music_07a_06);
            if (this.debug)
            {
                Engine.print("start music 07a_06");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_06", 2206802353U), default(IGameObject), 1F);
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task music_07a_07()
        {
            await Engine.sleep_until(async () => this.g_music_07a_07);
            if (this.debug)
            {
                Engine.print("start music 07a_07");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_07", 2207064501U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => this.g_music_07a_07_alt);
            if (this.debug)
            {
                Engine.print("set music 07a_07 alternate");
            }

            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_07", 2207064501U), true);
            await Engine.sleep_until(async () => !(this.g_music_07a_07));
            if (this.debug)
            {
                Engine.print("stop music 07a_07");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_07", 2207064501U));
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task music_07a_08()
        {
            await Engine.sleep_until(async () => this.g_music_07a_08);
            if (this.debug)
            {
                Engine.print("start music 07a_08");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_08", 2207850945U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_07a_08));
            if (this.debug)
            {
                Engine.print("stop music 07a_08");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_08", 2207850945U));
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task chapter_job()
        {
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task chapter_thanks()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_2);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(217, Lifecycle.Dormant)]
        public async Task chapter_grudge()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_3);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(218, Lifecycle.Dormant)]
        public async Task chapter_graves()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_4);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task objective_locate_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("locate the prophet of truth and the index.");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task objective_locate_clear()
        {
            Engine.print("objective complete:");
            Engine.print("locate the prophet of truth and the index.");
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task objective_rescue_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("rescue the marines being held in the detention-block.");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task objective_rescue_clear()
        {
            Engine.print("objective complete:");
            Engine.print("rescue the marines being held in the detention-block.");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task objective_truth_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("follow the prophet of truth to the far tower.");
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task objective_truth_clear()
        {
            Engine.print("objective complete:");
            Engine.print("follow the prophet of truth to the far tower.");
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task objective_phantom_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("stop the prophet of truth from boarding his phantom.");
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task objective_phantom_clear()
        {
            Engine.print("objective complete:");
            Engine.print("stop the prophet of truth from boarding his phantom.");
            Engine.objectives_finish_up_to(3);
        }

        [ScriptMethod(227, Lifecycle.Static)]
        public async Task erase_cortana()
        {
            if (this.debug)
            {
                Engine.print("erasing cortana...");
            }

            Engine.cs_run_command_script(cortana1, new ScriptMethodReference(cs_shrink_cortana));
            await Engine.sleep(1);
        }

        [ScriptMethod(228, Lifecycle.Static)]
        public async Task sc_this_way_a()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: this way, chief!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2000"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(229, Lifecycle.Static)]
        public async Task sc_this_way_b()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: over here, chief!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2010"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(230, Lifecycle.Static)]
        public async Task sc_this_way_c()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: chief! let's go");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2020"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(231, Lifecycle.Static)]
        public async Task sc_this_way_d()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: come on, chief!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2030"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(232, Lifecycle.Static)]
        public async Task sc_this_way_e()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: through here!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2040"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(233, Lifecycle.Static)]
        public async Task sc_this_way_f()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: go on through!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2050"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task sc_council_ini()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: brutes!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2070"));
            await Engine.sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                Engine.print("cortana: the faster you kill those brutes the better");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2100"));
            this.g_council_initial = true;
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task sc_brutes_berserk()
        {
            if ((short)Engine.ai_living_count(council_brute_ini.Squad) > 0)
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: they don't have shield generators, but take them out before...");
                }

                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2080"));
                await Engine.sleep(this.dialogue_pause);
            }

            if ((short)Engine.ai_living_count(council_brute_ini.Squad) > 0)
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: it's berserking!");
                }

                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2090"));
            }
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task sc_council_exit_reminder()
        {
            await Engine.sleep((short)(30 * 20));
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_council_bk, Engine.players()) || Engine.volume_test_objects(tv_council_lt_bk, Engine.players()) || Engine.volume_test_objects(tv_council_rt_bk, Engine.players()))
                {
                    if (this.g_council_exit_reminder)
                    {
                        Engine.sleep_forever();
                    }

                    if (this.dialogue)
                    {
                        Engine.print("cortana: they've locked it from below");
                    }

                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2130"));
                    await Engine.sleep((short)(this.dialogue_pause * 2));
                    if (this.g_council_exit_reminder)
                    {
                        Engine.sleep_forever();
                    }

                    if (this.dialogue)
                    {
                        Engine.print("cortana: there's a door at the other end of the chamber");
                    }

                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2120"));
                    this.g_council_reminder_played = true;
                }

                if (this.g_council_reminder_played)
                {
                    this.g_council_reminder_played = false;
                    await Engine.sleep((short)(30 * 30));
                }

                return this.g_council_exit_reminder;
            }, 60);
        }

        [ScriptMethod(237, Lifecycle.Static)]
        public async Task sc_council_mid()
        {
            await Engine.sleep((short)Engine.random_range(15, 45));
            if (this.dialogue)
            {
                Engine.print("brute: the demon has infiltrated the council chamber?!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4271840482U), council_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4271840482U), council_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4271840482U), council_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4271840482U), council_sound_d.Entity, 1F, 1);
            await Engine.sleep(1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4271840482U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("brute: protect the hierarchs! seal the exits!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4271906019U), council_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4271906019U), council_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4271906019U), council_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4271906019U), council_sound_d.Entity, 1F, 1);
            await Engine.sleep(1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4271906019U)));
            await Engine.sleep((short)(this.dialogue_pause * 2));
            if (this.dialogue)
            {
                Engine.print("cortana: oh, i don't think so");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2190"));
            await Engine.sleep((short)(this.dialogue_pause * 4));
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task sc_council_exit_leave()
        {
            await Engine.sleep(150);
            if (Engine.volume_test_objects(tv_council_ext, Engine.players()))
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: don't worry. you can pick me up later");
                }

                await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2180"));
            }

            await this.erase_cortana();
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task sc_council_exit()
        {
            await Engine.sleep((short)Engine.random_range(15, 45));
            if (this.dialogue)
            {
                Engine.print("cortana: put me down on one of the pedestals near the door.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2110"));
            Engine.wake(new ScriptMethodReference(sc_council_exit_reminder));
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.players(), bsp_0_holo_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), bsp_0_holo_a.Entity) < 2.5F)
                {
                    Engine.ai_place(cortana_0.a);
                    this.g_council_exit_reminder = true;
                    await Engine.sleep(5);
                    Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), bsp_0_holo_a.Entity, "effect");
                }
                else if (Engine.objects_distance_to_object(Engine.players(), bsp_0_holo_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), bsp_0_holo_b.Entity) < 2.5F)
                {
                    Engine.ai_place(cortana_0.b);
                    this.g_council_exit_reminder = true;
                    await Engine.sleep(5);
                    Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), bsp_0_holo_b.Entity, "effect");
                }

                return this.g_council_exit_reminder;
            }, 5);
            await Engine.sleep(90);
            if (this.dialogue)
            {
                Engine.print("cortana: that prophet - truth - he has the index!");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: you've got to take it back from him!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2150"));
            await Engine.sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                Engine.print("cortana: let me get these doors...");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2140"));
            await Engine.sleep(this.dialogue_pause);
            Engine.device_closes_automatically_set(council_exit.Entity, false);
            Engine.device_operates_automatically_set(council_exit.Entity, true);
            await Engine.sleep(1);
            Engine.device_set_position(council_exit.Entity, 1F);
            await Engine.sleep(15);
            Engine.game_save();
            if (this.dialogue)
            {
                Engine.print("cortana: go. it'll be easier to track truth if i stay in the network");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2170"));
            await Engine.sleep(this.dialogue_pause);
            this.g_music_07a_01 = true;
            Engine.wake(new ScriptMethodReference(sc_council_exit_leave));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_council_hall, Engine.players()), 5);
            await Engine.sleep(30);
            await this.erase_cortana();
            Engine.device_closes_automatically_set(council_exit.Entity, true);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task sc_grand_a_exit()
        {
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_0.f);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), bsp_0_holo_f.Entity, "effect");
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), bsp_0_holo_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), bsp_0_holo_f.Entity) < 4F);
            this.g_music_07a_02 = true;
            if (this.dialogue)
            {
                Engine.print("cortana: right this way chief!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2060"));
            Engine.device_one_sided_set(grand_a_exit.Entity, false);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_ledge_fr, Engine.players()));
            await Engine.sleep(30);
            await this.erase_cortana();
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task sc_ledge_chieftan()
        {
            if (this.g_cheiftan)
            {
                Engine.sleep_forever();
            }

            await Engine.sleep(30);
            if (this.dialogue)
            {
                Engine.print("cortana: watch out for the captain!");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: it's got a brute shot");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2200"));
            this.g_cheiftan = true;
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task sc_ledge_down_reminder()
        {
            await Engine.sleep(300);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_ledge_lift, Engine.players()));
            if (this.g_ledge_reminder)
            {
                Engine.sleep_forever();
            }

            if (this.dialogue)
            {
                Engine.print("cortana: after that stunt on the cairo,");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: i know you're not afraid of heights.");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2240"));
            await Engine.sleep((short)(this.dialogue_pause * 3));
            await Engine.sleep(300);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_ledge_lift, Engine.players()));
            if (this.g_ledge_reminder)
            {
                Engine.sleep_forever();
            }

            if (this.dialogue)
            {
                Engine.print("cortana: fine, i won't watch");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: meet you at the bottom, ok?");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2250"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task sc_ledge_down()
        {
            await Engine.sleep_until(async () => this.g_cheiftan && (short)Engine.ai_living_count(dervish_ledge_prophets) <= 3);
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_0.i);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), bsp_0_holo_i.Entity, "effect");
            await Engine.sleep(90);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_dervish_ledge_fr, Engine.ai_actors(prophets))) && !(Engine.volume_test_objects(tv_dervish_ledge_bk, Engine.ai_actors(prophets))));
            this.g_dervish_ledge_orders = true;
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), bsp_0_holo_i.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), bsp_0_holo_i.Entity) < 2F);
            if (this.dialogue)
            {
                Engine.print("cortana: truth is moving through the lower-levels of the tower.");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2210"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: i'll reverse this grav-lift. drop down, try to cut him off.");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2220"));
            await Engine.sleep(this.dialogue_pause);
            Engine.game_save();
            Engine.device_closes_automatically_set(dervish_lift_up.Entity, false);
            Engine.device_set_position(dervish_lift_up.Entity, 1F);
            await Engine.sleep(30);
            Engine.object_destroy(dervish_lift_up.Entity);
            Engine.object_create(dervish_lift_down);
            await Engine.sleep(5);
            if (this.dialogue)
            {
                Engine.print("cortana: it's safe really. just step in");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_0.Squad, "2230"));
            await Engine.sleep(this.dialogue_pause);
            Engine.wake(new ScriptMethodReference(sc_ledge_down_reminder));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_ledge_lower, Engine.players()));
            this.g_ledge_reminder = true;
            await this.erase_cortana();
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task sc_corridor_a_amb()
        {
            await Engine.sleep((short)Engine.random_range(15, 45));
            if (this.dialogue)
            {
                Engine.print("brute: reinforce all approaches to the holding-pens!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4271971556U), corr_a_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4271971556U), corr_a_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4271971556U), corr_a_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4271971556U), corr_a_sound_d.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4271971556U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("brute: slay the demon on sight!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4272037093U), corr_a_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4272037093U), corr_a_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4272037093U), corr_a_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4272037093U), corr_a_sound_d.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4272037093U)));
            await Engine.sleep((short)(this.dialogue_pause * 5));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), grand_b_holo_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), grand_b_holo_b.Entity) < 5F, 5);
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_grand_b.b);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), grand_b_holo_b.Entity, "effect");
            await Engine.sleep(30);
            if (this.dialogue)
            {
                Engine.print("cortana: they're beefing-up their patrols. stay sharp.");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_grand_b.Squad, "2260"));
            Engine.game_save_no_timeout();
            await Engine.sleep(30);
            Engine.device_set_position(grand_b_exit.Entity, 1F);
            await Engine.sleep(90);
            await this.erase_cortana();
            Engine.device_closes_automatically_set(grand_b_exit.Entity, true);
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task sc_jail_info()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: wait a minute... i'm reading marine iff transponders!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2270"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: the signals are originating somewhere below your position.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2280"));
            Engine.game_save_no_timeout();
            Engine.ai_place(hall_b_jackals.Squad);
            Engine.wake(new ScriptMethodReference(objective_locate_clear));
            Engine.wake(new ScriptMethodReference(objective_rescue_set));
        }

        [ScriptMethod(246, Lifecycle.Dormant)]
        public async Task sc_room_a_lift()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hall_b_prophets) <= 3);
            Engine.ai_place(cortana_corridor_a.o);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), hall_a_holo_o.Entity, "effect");
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), hall_a_holo_o.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_holo_o.Entity) < 4.5F);
            if (this.dialogue)
            {
                Engine.print("cortana: there's another lift in the next room");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_corridor_a.Squad, "2290"));
            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => this.g_room_a_door && Engine.volume_test_objects(tv_room_a, Engine.players()));
            await this.erase_cortana();
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task sc_room_a_down()
        {
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_room_a.m);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), room_a_holo_m.Entity, "effect");
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), jail_down.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), jail_down.Entity) < 3.5F, 5);
            await Engine.sleep(15);
            if (this.dialogue)
            {
                Engine.print("cortana: here, chief! jump in!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_room_a.Squad, "2300"));
            Engine.ai_place(room_a_tube_fodder.Squad);
            Engine.device_set_power(room_a_lift.Entity, 0F);
            Engine.device_set_position(room_a_lift_effect.Entity, 1F);
            await Engine.sleep(30);
            Engine.device_set_position(jail_down.Entity, 1F);
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task sc_jail_down()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: there are two groups of marines in this detention-block.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2310"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: i'll zero their locations - you neutralize the guards... quietly");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2320"));
            await Engine.sleep(30);
            this.g_music_07a_03 = true;
            Engine.game_save_immediate();
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task sc_cell_a_ent()
        {
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_jail.h);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), jail_ped_h.Entity, "effect");
            await Engine.sleep(60);
            if (this.dialogue)
            {
                Engine.print("cortana: come to middle-level, chief!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2350"));
            await Engine.sleep((short)(this.dialogue_pause * 3));
            if (this.g_jail_a_finished || this.g_jail_b_finished)
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: more guards! get ready!");
                }

                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2380"));
            }
            else
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: the marines are just inside. careful of the guards.");
                }

                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2360"));
            }

            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), jail_ped_h.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), jail_ped_h.Entity) < 3F, 5);
            Engine.game_save();
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task sc_cell_b_ent()
        {
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_jail.n);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), jail_ped_n.Entity, "effect");
            await Engine.sleep(60);
            if (this.dialogue)
            {
                Engine.print("cortana: chief! come to the lower level!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2370"));
            await Engine.sleep((short)(this.dialogue_pause * 3));
            if (this.g_jail_a_finished || this.g_jail_b_finished)
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: more guards! get ready!");
                }

                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2380"));
            }
            else
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: the marines are just inside. careful of the guards.");
                }

                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2360"));
            }

            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), jail_ped_n.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), jail_ped_n.Entity) < 3F, 5);
            Engine.game_save();
        }

        [ScriptMethod(251, Lifecycle.Dormant)]
        public async Task sc_first_cell()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(90);
            if (this.dialogue)
            {
                Engine.print("cortana: listen-up marines. the chief's hunting a prophet,");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: and you're gonna help him kill it.");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_jail.Squad, "2390"));
            await Engine.sleep(this.dialogue_pause);
            this.g_music_07a_03_alt = true;
            if (this.dialogue)
            {
                Engine.print("marine: no sense sticking around here!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(jail_marines, "4000"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("marine: affirmative!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(jail_marines, "4010"));
            await Engine.sleep((short)(this.dialogue_pause * 5));
            if (this.dialogue)
            {
                Engine.print("cortana: one more group of marines to go");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_jail.Squad, "2400"));
            await Engine.sleep(this.dialogue_pause);
            Engine.game_save_no_timeout();
            await Engine.sleep(90);
            Engine.ai_dialogue_enable(true);
            await this.erase_cortana();
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task sc_second_cell()
        {
            await Engine.sleep(90);
            if (this.dialogue)
            {
                Engine.print("marine: good on ya");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(jail_marines, "4020"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("marine: thanks");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(jail_marines, "4030"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: that's all the marines, chief. good work.");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_jail.Squad, "2410"));
            await Engine.sleep(this.dialogue_pause);
            Engine.game_save_no_timeout();
            await Engine.sleep(90);
            Engine.wake(new ScriptMethodReference(objective_rescue_clear));
            await this.erase_cortana();
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task sc_jail_exit()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: we'll get out of here the same way we came in:");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: the central grav-lift");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2420"));
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task sc_lift_reins()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: hostile reinforcements! coming down the lift!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2430"));
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task sc_jail_clear_reminder()
        {
            await Engine.sleep((short)(30 * 20));
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_jail_top, Engine.players()) || Engine.volume_test_objects(tv_jail_mid, Engine.players()) || Engine.volume_test_objects(tv_jail_bot, Engine.players()))
                {
                    if (this.g_jail_exit_reminder)
                    {
                        Engine.sleep_forever();
                    }

                    if (this.dialogue)
                    {
                        Engine.print("cortana: we've got to get after truth, chief! step into the lift!");
                    }

                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2450"));
                    this.g_jail_exit_reminder_played = true;
                }

                if (this.g_jail_exit_reminder_played)
                {
                    this.g_jail_exit_reminder_played = false;
                    await Engine.sleep((short)(30 * 20));
                }

                return this.g_jail_exit_reminder;
            }, 60);
        }

        [ScriptMethod(256, Lifecycle.CommandScript)]
        public async Task cs_marines_exit()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/exit"));
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task sc_jail_clear()
        {
            if ((short)Engine.random_range(0, 2) == 0)
            {
                Engine.ai_place(cortana_jail.a);
                await Engine.sleep(5);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), jail_ped_a.Entity, "effect");
            }
            else
            {
                Engine.ai_place(cortana_jail.b);
                await Engine.sleep(5);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), jail_ped_b.Entity, "effect");
            }

            await Engine.sleep(90);
            Engine.object_destroy(jail_down.Entity);
            Engine.device_set_position(jail_up_effect.Entity, 1F);
            await Engine.sleep(30);
            Engine.object_create(jail_up);
            Engine.object_create(room_b_lift);
            Engine.device_set_position(room_b_lift_effect.Entity, 1F);
            Engine.pvs_set_object(jail_ped_a.Entity);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), jail_ped_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), jail_ped_a.Entity) < 3F || Engine.objects_distance_to_object(Engine.players(), jail_ped_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), jail_ped_b.Entity) < 3F, 5);
            if (this.dialogue)
            {
                Engine.print("cortana: the lift is clear. step on in!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_jail.Squad, "2440"));
            await Engine.sleep(this.dialogue_pause);
            Engine.cs_run_command_script(marines, new ScriptMethodReference(cs_marines_exit));
            Engine.wake(new ScriptMethodReference(sc_jail_clear_reminder));
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task sc_room_b()
        {
            await Engine.sleep(150);
            if (this.dialogue)
            {
                Engine.print("truth: fear not my brothers! the sacred icon is secure!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4270529742U), corr_b_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4270529742U), corr_b_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4270529742U), corr_b_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4270529742U), corr_b_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4270529742U), corr_b_sound_i.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4270529742U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("truth: it was tartarus and his brutes who took the icon from the flood!");
            }

            if (this.dialogue)
            {
                Engine.print("truth: for that, they have our thanks!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4270595279U), corr_b_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4270595279U), corr_b_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4270595279U), corr_b_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4270595279U), corr_b_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4270595279U), corr_b_sound_i.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4270595279U)));
            await Engine.sleep((short)(this.dialogue_pause * 4));
            if (this.dialogue)
            {
                Engine.print("cortana: excellent! truth is broadcasting on the move.");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: it'll make him much easier to track");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2460"));
            this.g_sc_room_b_done = true;
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task sc_corridor_b_exit()
        {
            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save());
            if (this.dialogue)
            {
                Engine.print("truth: the elites have failed to protect the prophets,");
            }

            if (this.dialogue)
            {
                Engine.print("truth: and in doing so, put all our lives at risk!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_e.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_f.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_g.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_h.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U), corr_b_sound_i.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4271054038U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("truth: let no warrior forget his oath: thou, in faith,");
            }

            if (this.dialogue)
            {
                Engine.print("truth: will keep us safe whilst we find the path!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_e.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_f.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_g.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_h.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U), corr_b_sound_i.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4271185112U)));
            await Engine.sleep((short)(this.dialogue_pause * 4));
            if (this.dialogue)
            {
                Engine.print("cortana: i've got a fix on truth just outside this tower, chief");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2470"));
            await Engine.sleep(this.dialogue_pause);
            this.g_music_07a_04 = true;
            if (this.dialogue)
            {
                Engine.print("cortana: there's an exit nearby - hurry!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2480"));
            await Engine.sleep((short)(this.dialogue_pause * 5));
            this.g_corr_b_exit_finished = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task sc_network()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(grand_b_hunters) <= 0 || Engine.volume_test_objects(tv_tower_a_ext, Engine.players()));
            await Engine.sleep(30);
            await Engine.sleep_until(async () => this.g_corr_b_exit_finished);
            if (this.dialogue)
            {
                Engine.print("truth: with my blessing, the brutes now lead our fleets.");
            }

            if (this.dialogue)
            {
                Engine.print("truth: they ask for your allegiance, and you shall give it!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4271119575U), ext_a_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4271119575U), ext_a_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4271119575U), ext_a_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4271119575U), ext_a_sound_e.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4271119575U), ext_a_sound_f.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4271119575U), ext_a_sound_g.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4271119575U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: you wouldn't believe the number of kill systems the");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: covenant are throwing-down around me.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2490"));
            await Engine.sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                Engine.print("cortana: not to worry - it's pretty sloppy stuff.");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: i guess they never expected a hostile intelligence");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: to penetrate their network from the inside!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2500"));
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task in_amber_clad()
        {
            Engine.object_create(ioc_effect);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\inamberclad_flyby\\slipspace", 2203722114U), rupture.Entity, 1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\inamberclad_flyby\\inamberclad_flyby", 2203853188U), default(IGameObject), 1F);
            await Engine.sleep(3);
            Engine.object_create(ioc);
            Engine.device_set_position_track(ioc.Entity, "high_charity_flyby", 0F);
            Engine.device_animate_position(ioc.Entity, 1F, 15F, 0F, 0F, false);
            await Engine.sleep(30);
            Engine.object_destroy(ioc_effect.Entity);
            await Engine.sleep(30);
            Engine.damage_object(Engine.GetTag<DamageEffectTag>("objects\\cinematics\\human\\inamberclad_to_scale\\damage_effects\\ioc_flyby", 2203656577U), await this.player0());
            await Engine.sleep_until(async () => Engine.device_get_position(ioc.Entity) >= 1F);
            Engine.object_destroy(ioc.Entity);
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task sc_ioc_reminder()
        {
            await Engine.sleep((short)(30 * 10));
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_garden_a_tram, Engine.players()))
                {
                    if (this.g_council_exit_reminder)
                    {
                        Engine.sleep_forever();
                    }

                    if (this.dialogue)
                    {
                        Engine.print("cortana: just step into the pad. it'll move you forward automatically.");
                    }

                    await Engine.sleep(Engine.ai_play_line_at_player(cortana_3a.Squad, "2570"));
                    this.g_ioc_reminder_played = true;
                    await Engine.sleep(30);
                }

                if (this.g_ioc_reminder_played)
                {
                    this.g_ioc_reminder_played = false;
                    await Engine.sleep((short)(30 * 20));
                }

                return this.g_ioc_reminder;
            }, 60);
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task sc_truth_a()
        {
            this.g_truth_speaking = true;
            if (this.dialogue)
            {
                Engine.print("cortana: they covenant just destroyed two of their own ships,");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: and i'm hearing reports of small arms fire throughout their fleet.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2520"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("truth: creatures of the covenant: the path is broad,");
            }

            if (this.dialogue)
            {
                Engine.print("truth: and we shall walk it side-by-side!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0180_pot", 4270791890U), ioc_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0180_pot", 4270791890U), ioc_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0180_pot", 4270791890U), ioc_sound_c.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0180_pot", 4270791890U)));
            await Engine.sleep(this.dialogue_pause);
            this.g_truth_speaking = false;
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task sc_in_amber_clad()
        {
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_3a.tram_a);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), garden_a_holo_a.Entity, "effect");
            await Engine.sleep(120);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), garden_a_holo_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), garden_a_holo_a.Entity) < 4F, 5);
            if (this.dialogue)
            {
                Engine.print("cortana: slip-space rupture!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_3a.Squad, "2530"));
            await Engine.sleep(this.dialogue_pause);
            this.g_music_07a_05 = true;
            Engine.wake(new ScriptMethodReference(in_amber_clad));
            if (this.dialogue)
            {
                Engine.print("cortana: it's in amber clad!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_3a.Squad, "2531"));
            await Engine.sleep(this.dialogue_pause);
            this.g_sc_ioc_finished = true;
            await Engine.sleep_until(async () => !(this.g_truth_speaking));
            if (this.dialogue)
            {
                Engine.print("truth: be glad! the reward for all your toil, all your sacrifice,");
            }

            if (this.dialogue)
            {
                Engine.print("truth: is near at hand!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0320_pot", 4271709408U), ioc_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0320_pot", 4271709408U), ioc_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0320_pot", 4271709408U), ioc_sound_c.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0320_pot", 4271709408U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: hailing... no response!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_3a.Squad, "2540"));
            await Engine.sleep(this.dialogue_pause);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.device_get_position(ioc.Entity) >= 0.9F);
            await Engine.sleep(30);
            if (this.dialogue)
            {
                Engine.print("cortana: she's crashed into another tower ahead of our position.");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: i'll keep trying to make contact,");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: but i'm not registering any human vital-signs...");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_3a.Squad, "2550"));
            await Engine.sleep((short)(this.dialogue_pause * 10));
            this.g_music_07a_04 = false;
            Engine.wake(new ScriptMethodReference(sc_ioc_reminder));
            Engine.game_save();
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task sc_garden_a_tram_reminder()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: truth has a big enough lead as it is, chief. get going!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2580"));
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task sc_drive_elites()
        {
            await Engine.sleep((short)Engine.random_range(30, 90));
            if (this.dialogue)
            {
                Engine.print("truth: at this moment, the councilors gather on halo to see the icon safely placed!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4270660816U), midtower_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4270660816U), midtower_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4270660816U), midtower_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4270660816U), midtower_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4270660816U), midtower_sound_e.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4270660816U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("brute: rise, pack-brothers! death to the elites!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4272102630U), midtower_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4272102630U), midtower_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4272102630U), midtower_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4272102630U), midtower_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4272102630U), midtower_sound_e.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4272102630U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("truth: there are those who said this day would never come.");
            }

            if (this.dialogue)
            {
                Engine.print("truth: what have they to say now?");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4271643871U), midtower_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4271643871U), midtower_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4271643871U), midtower_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4271643871U), midtower_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4271643871U), midtower_sound_e.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4271643871U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("brute: once the towers are cleared, we'll drive them from the lower districts!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4272168167U), midtower_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4272168167U), midtower_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4272168167U), midtower_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4272168167U), midtower_sound_d.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4272168167U), midtower_sound_e.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4272168167U)));
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task sc_gardens_b()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_sc_gardens_b, Engine.players()));
            if (this.dialogue)
            {
                Engine.print("truth: i have listened to the oracle, and it confirmed our dearest hope:");
            }

            if (this.dialogue)
            {
                Engine.print("truth: the great journey begins with halo!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U), garden_b_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U), garden_b_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U), garden_b_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U), garden_b_sound_e.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U), garden_b_sound_f.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U), garden_b_sound_g.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U), garden_b_sound_h.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U), garden_b_sound_d.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4271512797U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("brute: the elites are falling back to the mausoleum!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U), garden_b_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U), garden_b_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U), garden_b_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U), garden_b_sound_e.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U), garden_b_sound_f.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U), garden_b_sound_g.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U), garden_b_sound_h.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U), garden_b_sound_d.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4272233704U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("brute: fools! their arbiter can do nothing for them now!");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U), garden_b_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U), garden_b_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U), garden_b_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U), garden_b_sound_e.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U), garden_b_sound_f.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U), garden_b_sound_g.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U), garden_b_sound_h.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U), garden_b_sound_d.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4272299241U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("truth: who would doubt the prophets?");
            }

            if (this.dialogue)
            {
                Engine.print("truth: what have we foretold that has not come to pass?");
            }

            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U), garden_b_sound_a.Entity, 1F);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U), garden_b_sound_b.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U), garden_b_sound_c.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U), garden_b_sound_e.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U), garden_b_sound_f.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U), garden_b_sound_g.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U), garden_b_sound_h.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U), garden_b_sound_d.Entity, 1F, 1);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4271578334U)));
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task sc_catch_truth()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: if we're going to catch truth, we'll need to take a short-cut -");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: straight through this mausoleum");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2610"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: look on the bright side. for now,");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: they seem much more interested in killing each other");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2620"));
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task sc_maus_interior()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_ent, Engine.players()) || Engine.device_get_position(maus_inner_ent.Entity) >= 0F);
            await Engine.sleep(30);
            Engine.ai_place(cortana_maus.a);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), maus_inner_holo_a.Entity, "effect");
            await Engine.sleep(45);
            if (this.dialogue)
            {
                Engine.print("cortana: you might consider sitting this one out");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_maus.Squad, "2630"));
            await Engine.sleep(30);
            this.g_music_07a_07 = true;
            await Engine.sleep(60);
            await this.erase_cortana();
        }

        [ScriptMethod(270, Lifecycle.Static)]
        public async Task sc_maus_breather()
        {
            Engine.ai_place(cortana_maus.j);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), maus_inner_holo_j.Entity, "effect");
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), maus_inner_holo_j.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), maus_inner_holo_j.Entity) < 6F, 30, 30 * 60 * 2);
            if (this.dialogue)
            {
                Engine.print("cortana: hang on... i'm picking-up two more transponders...");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_maus.Squad, "2640"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: it's the commander and johnsom!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_maus.Squad, "2650"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: they're closing on truth's position, chief!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_maus.Squad, "2660"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: they'll need your help!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_maus.Squad, "2670"));
            this.g_music_07a_07_alt = true;
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task sc_maus_exit()
        {
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_maus.f);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), maus_inner_holo_f.Entity, "effect");
            Engine.device_one_sided_set(maus_inner_exit.Entity, false);
            await Engine.sleep(1);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), maus_inner_holo_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), maus_inner_holo_f.Entity) < 7F, 5);
            await this.erase_cortana();
            if (this.dialogue)
            {
                Engine.print("cortana: this way, chief!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cortana_maus.Squad, "2000"));
            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_game_won, Engine.players()), 1);
            this.g_music_07a_08 = false;
            await Engine.sleep(75);
            if (this.dialogue)
            {
                Engine.print("cortana: this isn't good. i'm getting confirmed reports of flood");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: leaving in amber clad's wreckage");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2590"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: let's get the index, and find a way out of here -");
            }

            if (this.dialogue)
            {
                Engine.print("cortana: before things get really ugly!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2600"));
            await Engine.sleep(30);
            await this.cinematic_fade_to_white();
            Engine.ai_erase_all();
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        Engine.print("c07_intra_1");
                    }

                    await this.c07_intra1();
                }

                await this.cinematic_skip_stop();
            }

            if (this.debug)
            {
                Engine.print("you win");
            }

            await this.playtest_mission();
            Engine.game_won();
        }

        [ScriptMethod(272, Lifecycle.Dormant)]
        public async Task marine_migration()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.structure_bsp_index() == 2)
                {
                    if (this.debug)
                    {
                        Engine.print("migrate into corridor b");
                    }

                    Engine.ai_set_orders(marines, marines_corr_b);
                }
                else if ((short)Engine.structure_bsp_index() == 3)
                {
                    if (this.debug)
                    {
                        Engine.print("migrate into exterior a");
                    }

                    Engine.ai_set_orders(marines, marines_ext_a);
                }

                return this.g_marine_mig_garden_a;
            });
            await Engine.sleep(30);
            if (this.debug)
            {
                Engine.print("migrate into gardens a");
            }

            Engine.ai_set_orders(marines, marines_gardens_a);
            await Engine.sleep_until(async () => this.g_marine_mig_midtower);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.structure_bsp_index() == 3)
                {
                    if (this.debug)
                    {
                        Engine.print("migrate into mid-tower");
                    }

                    Engine.ai_set_orders(marines, marines_midtower);
                }
                else if ((short)Engine.structure_bsp_index() == 4)
                {
                    if (this.debug)
                    {
                        Engine.print("migrate into gardens b");
                    }

                    Engine.ai_set_orders(marines, marines_gardens_b);
                }

                return this.g_marine_mig_ext_b;
            });
            await Engine.sleep(30);
            if (this.debug)
            {
                Engine.print("migrate into exterior b");
            }

            Engine.ai_set_orders(marines, marines_ext_b);
            await Engine.sleep_until(async () => this.g_marine_mig_maus);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.structure_bsp_index() == 4)
                {
                    if (this.debug)
                    {
                        Engine.print("migrate into mausoleum halls");
                    }

                    Engine.ai_set_orders(marines, marines_maus_halls);
                }
                else if ((short)Engine.structure_bsp_index() == 5)
                {
                    if (this.debug)
                    {
                        Engine.print("migrate into mausoleum room bridge");
                    }

                    Engine.ai_set_orders(marines, marines_maus_room_bridge);
                }

                return this.g_marine_mig_maus_int;
            });
            await Engine.sleep(30);
            if (this.debug)
            {
                Engine.print("migrate into mausoleum interior");
            }

            Engine.ai_set_orders(marines, marines_maus_int);
        }

        [ScriptMethod(273, Lifecycle.Dormant)]
        public async Task grand_b_door()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.structure_bsp_index() == 2)
                {
                    Engine.device_operates_automatically_set(grand_b_door1.Entity, true);
                }
                else if ((short)Engine.structure_bsp_index() == 3)
                {
                    Engine.device_operates_automatically_set(grand_b_door1.Entity, false);
                }

                return false;
            }, 1);
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task cs_council_grunt_a()
        {
            Engine.cs_movement_mode(3);
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("council/p0"));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_council_door_right_a, Engine.players()) || (short)Engine.ai_living_count(council_brute_ini.Squad) <= 0);
        }

        [ScriptMethod(275, Lifecycle.CommandScript)]
        public async Task cs_council_grunt_b()
        {
            Engine.cs_movement_mode(3);
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("council/p1"));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_council_door_right_b, Engine.players()) || (short)Engine.ai_living_count(council_brute_ini.Squad) <= 0);
        }

        [ScriptMethod(276, Lifecycle.CommandScript)]
        public async Task cs_council_grunt_c()
        {
            Engine.cs_movement_mode(3);
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("council/p2"));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_council_door_left_a, Engine.players()) || (short)Engine.ai_living_count(council_brute_ini.Squad) <= 0);
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task cs_council_grunt_d()
        {
            Engine.cs_movement_mode(3);
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("council/p3"));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_council_door_left_b, Engine.players()) || (short)Engine.ai_living_count(council_brute_ini.Squad) <= 0);
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task ai_council_brutes_berserk()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(council_brute_ini.Squad) <= 1, 1);
            if ((short)Engine.ai_living_count(council_brute_ini.Squad) > 0)
            {
                Engine.ai_set_orders(council_brute_ini.Squad, council_floor_all);
                Engine.ai_berserk(council_brute_ini.Squad, true);
                await Engine.sleep_until(async () => this.g_council_initial);
                Engine.wake(new ScriptMethodReference(sc_brutes_berserk));
            }
        }

        [ScriptMethod(279, Lifecycle.Static)]
        public async Task ai_council_left_a()
        {
            if (!(Engine.volume_test_objects(tv_council_door_left_a, Engine.players())) && Engine.device_get_position(council_door_left_a.Entity) == 0F)
            {
                if (this.debug)
                {
                    Engine.print("left a");
                }

                Engine.ai_place(council_lt_brute_a.Squad);
                Engine.ai_place(council_lt_grunt_a.Squad);
                this.g_council_count = (short)(this.g_council_count + 1);
                if (this.g_council_count == this.g_council_limit)
                {
                    this.g_council_wave = false;
                }
            }
        }

        [ScriptMethod(280, Lifecycle.Static)]
        public async Task ai_council_left_b()
        {
            if (!(Engine.volume_test_objects(tv_council_door_left_b, Engine.players())) && Engine.device_get_position(council_door_left_b.Entity) == 0F)
            {
                if (this.debug)
                {
                    Engine.print("left b");
                }

                Engine.ai_place(council_lt_brute_b.Squad);
                Engine.ai_place(council_lt_grunt_b.Squad);
                this.g_council_count = (short)(this.g_council_count + 1);
                if (this.g_council_count == this.g_council_limit)
                {
                    this.g_council_wave = false;
                }
            }
        }

        [ScriptMethod(281, Lifecycle.Static)]
        public async Task ai_council_left_c()
        {
            if (!(Engine.volume_test_objects(tv_council_door_left_c, Engine.players())) && Engine.device_get_position(council_door_left_c.Entity) == 0F)
            {
                if (this.debug)
                {
                    Engine.print("left c");
                }

                Engine.ai_place(council_lt_brute_c.Squad);
                Engine.ai_place(council_lt_grunt_c.Squad);
                this.g_council_count = (short)(this.g_council_count + 1);
                if (this.g_council_count == this.g_council_limit)
                {
                    this.g_council_wave = false;
                }
            }
        }

        [ScriptMethod(282, Lifecycle.Static)]
        public async Task ai_council_right_a()
        {
            if (!(Engine.volume_test_objects(tv_council_door_right_a, Engine.players())) && Engine.device_get_position(council_door_right_a.Entity) == 0F)
            {
                if (this.debug)
                {
                    Engine.print("right a");
                }

                Engine.ai_place(council_rt_brute_a.Squad);
                Engine.ai_place(council_rt_grunt_a.Squad);
                this.g_council_count = (short)(this.g_council_count + 1);
                if (this.g_council_count == this.g_council_limit)
                {
                    this.g_council_wave = false;
                }
            }
        }

        [ScriptMethod(283, Lifecycle.Static)]
        public async Task ai_council_right_b()
        {
            if (!(Engine.volume_test_objects(tv_council_door_right_b, Engine.players())) && Engine.device_get_position(council_door_right_b.Entity) == 0F)
            {
                if (this.debug)
                {
                    Engine.print("right b");
                }

                Engine.ai_place(council_rt_brute_b.Squad);
                Engine.ai_place(council_rt_grunt_b.Squad);
                this.g_council_count = (short)(this.g_council_count + 1);
                if (this.g_council_count == this.g_council_limit)
                {
                    this.g_council_wave = false;
                }
            }
        }

        [ScriptMethod(284, Lifecycle.Static)]
        public async Task ai_council_right_c()
        {
            if (!(Engine.volume_test_objects(tv_council_door_right_c, Engine.players())) && Engine.device_get_position(council_door_right_c.Entity) == 0F)
            {
                if (this.debug)
                {
                    Engine.print("right c");
                }

                Engine.ai_place(council_rt_brute_c.Squad);
                Engine.ai_place(council_rt_grunt_c.Squad);
                this.g_council_count = (short)(this.g_council_count + 1);
                if (this.g_council_count == this.g_council_limit)
                {
                    this.g_council_wave = false;
                }
            }
        }

        [ScriptMethod(285, Lifecycle.Static)]
        public async Task ai_council_rt_fr()
        {
            if (this.debug)
            {
                Engine.print("right front");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_left_a();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_left_b();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_right_c();
                }
            });
        }

        [ScriptMethod(286, Lifecycle.Static)]
        public async Task ai_council_rt_bk()
        {
            if (this.debug)
            {
                Engine.print("right back");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_left_b();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_left_c();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_right_a();
                }
            });
        }

        [ScriptMethod(287, Lifecycle.Static)]
        public async Task ai_council_lt_fr()
        {
            if (this.debug)
            {
                Engine.print("left front");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_left_c();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_right_a();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_right_b();
                }
            });
        }

        [ScriptMethod(288, Lifecycle.Static)]
        public async Task ai_council_lt_bk()
        {
            if (this.debug)
            {
                Engine.print("left back");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_left_a();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_right_b();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_right_c();
                }
            });
        }

        [ScriptMethod(289, Lifecycle.Static)]
        public async Task ai_council_fr()
        {
            if (this.debug)
            {
                Engine.print("front");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_left_a();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_right_a();
                }
            });
        }

        [ScriptMethod(290, Lifecycle.Static)]
        public async Task ai_council_bk()
        {
            if (this.debug)
            {
                Engine.print("back");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_left_c();
                }
            }, 
                async () =>
            {
                if (this.g_council_wave)
                {
                    await this.ai_council_right_c();
                }
            });
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task ai_council_orders()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_council_rt_fr, Engine.players()))
                {
                    Engine.ai_set_orders(council_prophets_floor, council_rt_fr);
                }
                else if (Engine.volume_test_objects(tv_council_rt_bk, Engine.players()))
                {
                    Engine.ai_set_orders(council_prophets_floor, council_rt_bk);
                }
                else if (Engine.volume_test_objects(tv_council_lt_fr, Engine.players()))
                {
                    Engine.ai_set_orders(council_prophets_floor, council_lt_fr);
                }
                else if (Engine.volume_test_objects(tv_council_lt_bk, Engine.players()))
                {
                    Engine.ai_set_orders(council_prophets_floor, council_lt_bk);
                }

                return this.g_council_orders;
            });
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task ai_council_upper_migrate()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(council_prophets_floor) <= 0 || (float)Engine.ai_strength(council_prophets_upper) <= 0.4F, 30, 30 * 40);
            await Engine.sleep(30);
            Engine.ai_migrate(council_prophets_upper, council_rt_brute_a.Squad);
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task ai_council_upper()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(council_prophets) <= 2);
            await Engine.sleep(120);
            Engine.begin_random(async () =>
            {
                if (this.g_council_upper)
                {
                    Engine.ai_place(council_rt_upper_brute_a.Squad);
                    this.g_council_upper_count = (short)(this.g_council_upper_count + 1);
                    if (this.g_council_upper_count == this.g_council_upper_limit)
                    {
                        this.g_council_upper = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_council_upper)
                {
                    Engine.ai_place(council_rt_upper_brute_b.Squad);
                    this.g_council_upper_count = (short)(this.g_council_upper_count + 1);
                    if (this.g_council_upper_count == this.g_council_upper_limit)
                    {
                        this.g_council_upper = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_council_upper)
                {
                    Engine.ai_place(council_rt_upper_brute_c.Squad);
                    this.g_council_upper_count = (short)(this.g_council_upper_count + 1);
                    if (this.g_council_upper_count == this.g_council_upper_limit)
                    {
                        this.g_council_upper = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_council_upper)
                {
                    Engine.ai_place(council_lt_upper_brute_a.Squad);
                    this.g_council_upper_count = (short)(this.g_council_upper_count + 1);
                    if (this.g_council_upper_count == this.g_council_upper_limit)
                    {
                        this.g_council_upper = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_council_upper)
                {
                    Engine.ai_place(council_lt_upper_brute_b.Squad);
                    this.g_council_upper_count = (short)(this.g_council_upper_count + 1);
                    if (this.g_council_upper_count == this.g_council_upper_limit)
                    {
                        this.g_council_upper = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_council_upper)
                {
                    Engine.ai_place(council_lt_upper_brute_c.Squad);
                    this.g_council_upper_count = (short)(this.g_council_upper_count + 1);
                    if (this.g_council_upper_count == this.g_council_upper_limit)
                    {
                        this.g_council_upper = false;
                    }
                }
            });
            Engine.wake(new ScriptMethodReference(ai_council_upper_migrate));
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task ai_council_floor_spawn()
        {
            this.g_council_wave = true;
            if (await this.difficulty_normal())
            {
                this.g_council_floor_wave_limit = 1;
                this.g_council_limit = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_council_floor_wave_limit = 1;
                this.g_council_limit = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_council_floor_wave_limit = 2;
                this.g_council_limit = 2;
            }

            if (await this.difficulty_normal())
            {
                this.g_council_upper_limit = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_council_upper_limit = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_council_upper_limit = 2;
            }

            Engine.data_mine_set_mission_segment("enc_council_wave_1");
            await this.sc_council_mid();
            Engine.game_save();
            await Engine.sleep(120);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(council_prophets_floor) <= 0);
                Engine.game_save();
                await Engine.sleep((short)Engine.random_range(this.sleep_lower_bound, this.sleep_upper_bound));
                if (this.debug)
                {
                    Engine.print("begin wave 1");
                }

                this.g_council_wave = true;
                this.g_council_count = 0;
                if (Engine.volume_test_objects(tv_council_fr, Engine.players()))
                {
                    await this.ai_council_fr();
                }
                else if (Engine.volume_test_objects(tv_council_rt_fr, Engine.players()))
                {
                    await this.ai_council_rt_fr();
                }
                else if (Engine.volume_test_objects(tv_council_rt_bk, Engine.players()))
                {
                    await this.ai_council_rt_bk();
                }
                else if (Engine.volume_test_objects(tv_council_lt_fr, Engine.players()))
                {
                    await this.ai_council_lt_fr();
                }
                else if (Engine.volume_test_objects(tv_council_lt_bk, Engine.players()))
                {
                    await this.ai_council_lt_bk();
                }
                else if (Engine.volume_test_objects(tv_council_bk, Engine.players()))
                {
                    await this.ai_council_bk();
                }

                this.g_council_floor_wave_count = (short)(this.g_council_floor_wave_count + 1);
                if (this.g_council_floor_wave_count == this.g_council_floor_wave_limit)
                {
                    this.g_council_floor_wave = true;
                }

                return this.g_council_floor_wave;
            });
            if (this.debug)
            {
                Engine.print("wave 1 over");
            }

            this.g_council_floor_wave = false;
            this.g_council_floor_wave_count = 0;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(council_prophets_floor) <= 0);
            await Engine.sleep(150);
            Engine.data_mine_set_mission_segment("enc_council_pedestal");
            Engine.game_save();
            await Engine.sleep(15);
            if (this.debug)
            {
                Engine.print("pedestal, sides and upper");
            }

            Engine.ai_place(council_brute_ped.a);
            Engine.ai_place(council_brute_ped.b);
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(council_brute_ped.chief);
                Engine.wake(new ScriptMethodReference(sc_ledge_chieftan));
            }

            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                Engine.ai_place(council_rt_grunt_c.Squad, 1);
                Engine.ai_place(council_lt_grunt_c.Squad, 1);
            }

            if (await this.difficulty_legendary())
            {
                Engine.ai_place(council_rt_grunt_b.Squad, 1);
                Engine.ai_place(council_lt_grunt_b.Squad, 1);
            }

            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(ai_council_upper));
            await Engine.sleep(30);
            Engine.device_set_position(council_ped.Entity, 0F);
            await Engine.sleep(5);
            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                await Engine.sleep_until(async () =>
                {
                    await Engine.sleep_until(async () => (short)Engine.ai_living_count(council_prophets) <= 0);
                    Engine.game_save();
                    Engine.data_mine_set_mission_segment("enc_council_wave_2");
                    await Engine.sleep((short)Engine.random_range(this.sleep_lower_bound, this.sleep_upper_bound));
                    if (this.debug)
                    {
                        Engine.print("begin wave 2");
                    }

                    this.g_council_wave = true;
                    this.g_council_count = 0;
                    if (Engine.volume_test_objects(tv_council_fr, Engine.players()))
                    {
                        await this.ai_council_fr();
                    }
                    else if (Engine.volume_test_objects(tv_council_rt_fr, Engine.players()))
                    {
                        await this.ai_council_rt_fr();
                    }
                    else if (Engine.volume_test_objects(tv_council_rt_bk, Engine.players()))
                    {
                        await this.ai_council_rt_bk();
                    }
                    else if (Engine.volume_test_objects(tv_council_lt_fr, Engine.players()))
                    {
                        await this.ai_council_lt_fr();
                    }
                    else if (Engine.volume_test_objects(tv_council_lt_bk, Engine.players()))
                    {
                        await this.ai_council_lt_bk();
                    }
                    else if (Engine.volume_test_objects(tv_council_bk, Engine.players()))
                    {
                        await this.ai_council_bk();
                    }

                    this.g_council_floor_wave_count = (short)(this.g_council_floor_wave_count + 1);
                    if (this.g_council_floor_wave_count == this.g_council_floor_wave_limit)
                    {
                        this.g_council_floor_wave = true;
                    }

                    return this.g_council_floor_wave;
                });
            }

            Engine.print("wave 2 over");
            this.g_council_floor_wave = false;
            this.g_council_over = true;
        }

        [ScriptMethod(295, Lifecycle.CommandScript)]
        public async Task cs_grand_a_grunt_a()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("grand_a/p0"), 2F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("grand_a/p1"), 2F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("grand_a/p2"), 2F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("grand_a/p3"), 2F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 15)));
                return false;
            });
        }

        [ScriptMethod(296, Lifecycle.CommandScript)]
        public async Task cs_grand_a_grunt_b()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("grand_a/p4"), 2F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("grand_a/p5"), 2F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("grand_a/p6"), 2F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("grand_a/p7"), 2F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 15)));
                return false;
            });
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task create_ledge_columns()
        {
            Engine.begin_random(async () => Engine.object_create(ledge_col_a), 
                async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                async () => Engine.object_create(ledge_col_b), 
                async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                async () => Engine.object_create(ledge_col_c), 
                async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                async () => Engine.object_create(ledge_col_d), 
                async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                async () => Engine.object_create(ledge_col_e), 
                async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                async () => Engine.object_create(ledge_col_f), 
                async () => await Engine.sleep((short)Engine.random_range(45, 90)));
        }

        [ScriptMethod(298, Lifecycle.CommandScript)]
        public async Task cs_ledge_jackals_lt()
        {
            Engine.cs_abort_on_alert(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge/lt_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge/lt_1"));
                return false;
            });
        }

        [ScriptMethod(299, Lifecycle.CommandScript)]
        public async Task cs_ledge_jackals_rt()
        {
            Engine.cs_abort_on_alert(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge/rt_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge/rt_1"));
                return false;
            });
        }

        [ScriptMethod(300, Lifecycle.CommandScript)]
        public async Task cs_ledge_brute_a()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge/b1_2"));
        }

        [ScriptMethod(301, Lifecycle.CommandScript)]
        public async Task cs_ledge_brute_b()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge/b2_2"));
        }

        [ScriptMethod(302, Lifecycle.CommandScript)]
        public async Task cs_lift_jump()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge/p0"));
            Engine.cs_jump_to_point(0F, 5F);
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task ledge_fr_orders()
        {
            Engine.ai_set_orders(ledge_lift_brute_rt.Squad, ledge_rt_fr);
            Engine.ai_set_orders(ledge_lift_brute_lt.Squad, ledge_lt_fr);
            Engine.ai_set_orders(ledge_lift_grunt_rt.Squad, ledge_minor_rt_fr);
            Engine.ai_set_orders(ledge_lift_grunt_lt.Squad, ledge_minor_lt_fr);
            Engine.ai_set_orders(ledge_jackal_right.Squad, ledge_minor_rt_fr);
            Engine.ai_set_orders(ledge_jackal_left.Squad, ledge_minor_lt_fr);
            Engine.ai_set_orders(ledge_lift_chieftan.Squad, ledge_chieftan);
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task ledge_bk_orders()
        {
            Engine.ai_set_orders(ledge_lift_brute_rt.Squad, ledge_rt_bk);
            Engine.ai_set_orders(ledge_lift_brute_lt.Squad, ledge_lt_bk);
            Engine.ai_set_orders(ledge_lift_grunt_rt.Squad, ledge_minor_rt_bk);
            Engine.ai_set_orders(ledge_lift_grunt_lt.Squad, ledge_minor_lt_bk);
            Engine.ai_set_orders(ledge_jackal_right.Squad, ledge_minor_rt_bk);
            Engine.ai_set_orders(ledge_jackal_left.Squad, ledge_minor_lt_bk);
            Engine.ai_set_orders(ledge_lift_chieftan.Squad, ledge_chieftan_lift);
        }

        [ScriptMethod(305, Lifecycle.Dormant)]
        public async Task ai_dervish_ledge_orders()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(dervish_ledge_prophets) >= this.ai_combat_status_active);
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_dervish_ledge_fr, Engine.players()))
                {
                    await Engine.sleep((short)Engine.random_range(5, 30));
                    await this.ledge_fr_orders();
                }
                else if (Engine.volume_test_objects(tv_dervish_ledge_bk, Engine.players()))
                {
                    await Engine.sleep((short)Engine.random_range(5, 30));
                    await this.ledge_bk_orders();
                }
                else if (Engine.volume_test_objects(tv_dervish_ledge_lift, Engine.players()))
                {
                    await Engine.sleep((short)Engine.random_range(5, 30));
                    await this.ledge_bk_orders();
                }

                return this.g_dervish_ledge_orders;
            });
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task cs_ledge_turrets_left()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            if (!(this.g_ledge_turret_left))
            {
                this.g_ledge_turret_left = true;
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p2"));
                Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p2"));
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p3"));
                Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p3"));
            }
        }

        [ScriptMethod(307, Lifecycle.CommandScript)]
        public async Task cs_ledge_turrets_right()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            if (!(this.g_ledge_turret_right))
            {
                this.g_ledge_turret_right = true;
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p0"));
                Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p0"));
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p1"));
                Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p1"));
            }
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task ai_ledge_lift()
        {
            Engine.ai_place(ledge_lift_grunt_lt.Squad, 2);
            Engine.ai_place(ledge_lift_grunt_rt.Squad);
            await Engine.sleep(120);
            if ((short)Engine.ai_living_count(dervish_ledge_prophets) <= 5 && await this.difficulty_heroic() || await this.difficulty_legendary() && !(Engine.volume_test_objects(tv_dervish_ledge_lift, Engine.players())))
            {
                Engine.ai_place(ledge_lift_grunt_lt.Squad);
                Engine.ai_place(ledge_lift_grunt_rt.Squad, 2);
            }

            await Engine.sleep(150);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dervish_ledge_prophets) <= 6);
            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                Engine.ai_place(ledge_lift_brute_lt.Squad);
                Engine.ai_place(ledge_lift_brute_rt.Squad);
            }

            Engine.ai_place(ledge_lift_chieftan.Squad);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), Engine.ai_get_object(ledge_lift_chieftan.Squad), 45F) && Engine.volume_test_objects(tv_dervish_ledge_lift, Engine.ai_get_object(ledge_lift_chieftan.Squad)), 30, 30 * 20);
            Engine.wake(new ScriptMethodReference(sc_ledge_chieftan));
            this.g_music_07a_01 = false;
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task ai_ledge_lower()
        {
            Engine.ai_place(ledge_bot_grunts.Squad);
            Engine.ai_place(ledge_bot_jackals.Squad);
        }

        [ScriptMethod(310, Lifecycle.CommandScript)]
        public async Task cs_hall_a_jackal_ini_a()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_looking(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/jackal_patrol_p0"), 1F);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p0"));
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_hall_a_jackal_patrol, Engine.players())) && Engine.device_get_position(hall_a_jackal_door.Entity) <= 0F, 5);
            if (!(this.g_corridor_a_active))
            {
                Engine.ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(311, Lifecycle.CommandScript)]
        public async Task cs_hall_a_jackal_ini_b()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_looking(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/jackal_patrol_p1"), 1F);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p0"));
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_hall_a_jackal_patrol, Engine.players())) && Engine.device_get_position(hall_a_jackal_door.Entity) <= 0F, 5);
            if (!(this.g_corridor_a_active))
            {
                Engine.ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(312, Lifecycle.CommandScript)]
        public async Task cs_hall_a_jackal_ini_c()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_looking(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/jackal_patrol_p2"), 1F);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p0"));
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_hall_a_jackal_patrol, Engine.players())) && Engine.device_get_position(hall_a_jackal_door.Entity) <= 0F, 5);
            if (!(this.g_corridor_a_active))
            {
                Engine.ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(313, Lifecycle.CommandScript)]
        public async Task cs_hall_a_brute_ini()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/b_p0"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/b_p1"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/b_p2"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/b_p3"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/b_p4"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p0")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                    async () => Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("hall_a/look_p0")), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p1")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                    async () => Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("hall_a/look_p1")), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p2")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                    async () => Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("hall_a/look_p2")), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p3")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                    async () => Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("hall_a/look_p3")));
                return false;
            });
        }

        [ScriptMethod(314, Lifecycle.CommandScript)]
        public async Task cs_hall_a_jackal_ini()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_certain);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/j_p0"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/j_p1"), 1F), 
                    async () => Engine.begin_random(async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p0")), 
    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p2")), 
    async () => await Engine.sleep((short)Engine.random_range(60, 90))), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/j_p2"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/j_p3"), 1F), 
                    async () => Engine.begin_random(async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p1")), 
    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p3")), 
    async () => await Engine.sleep((short)Engine.random_range(60, 90))), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/j_p4"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/j_p5"), 1F), 
                    async () => Engine.begin_random(async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p0")), 
    async () => await Engine.sleep((short)Engine.random_range(60, 90)), 
    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p3")), 
    async () => await Engine.sleep((short)Engine.random_range(60, 90))), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_a/j_p6"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)));
                return false;
            });
        }

        [ScriptMethod(315, Lifecycle.CommandScript)]
        public async Task cs_hall_b_jackal_a()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_looking(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_b/jackal_p0"), 1F);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p0"));
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_hall_b_jackal, Engine.players())) && Engine.device_get_position(hall_b_jackal_door.Entity) <= 0F, 5);
            Engine.device_one_sided_set(hall_b_jackal_door.Entity, true);
        }

        [ScriptMethod(316, Lifecycle.CommandScript)]
        public async Task cs_hall_b_jackal_b()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_looking(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_b/jackal_p1"), 1F);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("hall_a/look_p0"));
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_hall_b_jackal, Engine.players())) && Engine.device_get_position(hall_b_jackal_door.Entity) <= 0F, 5);
            Engine.device_one_sided_set(hall_b_jackal_door.Entity, true);
        }

        [ScriptMethod(317, Lifecycle.CommandScript)]
        public async Task cs_hall_b_brutes()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_b/p0"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_b/p1"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_b/p2"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_b/p3"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hall_b/p4"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)));
                return false;
            });
        }

        [ScriptMethod(318, Lifecycle.CommandScript)]
        public async Task cs_hall_b_wake_grunts()
        {
            if (this.g_corridor_a_active)
            {
                Engine.cs_force_combat_status(this.ai_combat_status_alert);
            }
        }

        [ScriptMethod(319, Lifecycle.CommandScript)]
        public async Task cs_room_a_brute_ini()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_a/p0"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_a/p1"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("room_a/look_p0")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                    async () => Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("room_a/look_p0")), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("room_a/look_p1")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                    async () => Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("hall_a/look_p1")));
                return false;
            });
        }

        [ScriptMethod(320, Lifecycle.CommandScript)]
        public async Task cs_room_a_jackal_ini()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_a/p4"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_a/p5"), 1F), 
                    async () => await Engine.sleep((short)Engine.random_range(0, 45)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("room_a/look_p0")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("room_a/look_p1")), 
                    async () => await Engine.sleep((short)Engine.random_range(45, 90)));
                return false;
            });
        }

        [ScriptMethod(321, Lifecycle.CommandScript)]
        public async Task cs_room_a_brutes_bk()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("room_a/look_p0")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 150)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("room_a/look_p2")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 150)), 
                    async () => Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("room_a/look_p3")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 150)));
                return false;
            });
        }

        [ScriptMethod(322, Lifecycle.CommandScript)]
        public async Task cs_room_a_to_jail()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_a/stand_p0"));
            Engine.cs_move_in_direction(0F, 1F, 180F);
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task room_a_door()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(room_a_door1.Entity) > 0F, 5);
            this.g_room_a_door = true;
            if (this.debug)
            {
                Engine.print("room a door opened");
            }
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task corridor_a_activate()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(hall_a_prophets) >= this.ai_combat_status_active);
            this.g_corridor_a_active = true;
            if (this.debug)
            {
                Engine.print("corridor a prophets active");
            }
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task ai_hall_a_prophets()
        {
            if (this.debug)
            {
                Engine.print("hall a initial prophets");
            }

            Engine.ai_place(hall_a_jackal_patrol_ini.Squad);
            Engine.ai_place(hall_a_brute_ini.Squad);
            Engine.ai_place(hall_a_jackal_ini.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hall_a_prophets) <= 1 || Engine.volume_test_objects(tv_hall_a_bk, Engine.players()));
            Engine.game_save();
            if (this.g_corridor_a_active)
            {
                if (this.debug)
                {
                    Engine.print("hall a reinforcements");
                }

                Engine.ai_place(hall_a_brute_rein.Squad);
                Engine.ai_place(hall_a_grunt_rein.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(hall_a_prophets), 0F, 2F));
                await Engine.sleep(1);
                Engine.ai_place(hall_a_brute_rein_bk.Squad);
                Engine.ai_place(hall_a_grunt_rein_bk.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(hall_a_prophets), 0F, 2F));
            }
        }

        [ScriptMethod(326, Lifecycle.Dormant)]
        public async Task ai_room_a()
        {
            Engine.ai_place(room_a_brutes_ini.Squad);
            Engine.ai_place(room_a_jackals_ini.Squad);
            Engine.ai_place(room_a_brutes_bk.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_room_a_mid, Engine.players()) || (short)Engine.ai_living_count(room_a_prophets) <= 2 && (short)Engine.ai_combat_status(room_a_prophets) >= this.ai_combat_status_active);
            if ((short)Engine.ai_combat_status(room_a_prophets) >= this.ai_combat_status_active && (short)Engine.ai_living_count(room_a_prophets) <= 2)
            {
                Engine.ai_place(room_a_brutes_a.Squad);
                Engine.ai_place(room_a_brutes_c.Squad);
                await Engine.sleep(1);
                Engine.ai_place(room_a_grunts_a.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(room_a_prophets), 0F, 2F));
                Engine.ai_place(room_a_grunts_c.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(room_a_prophets), 0F, 2F));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_room_a_bk, Engine.players()));
            if ((short)Engine.ai_combat_status(room_a_prophets) >= this.ai_combat_status_active && (short)Engine.ai_living_count(room_a_prophets) <= 4)
            {
                Engine.ai_place(room_a_brutes_b.Squad);
                Engine.ai_place(room_a_grunts_b.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(room_a_prophets), 0F, 2F));
            }
        }

        [ScriptMethod(327, Lifecycle.Static)]
        public async Task test_room_a_to_jail()
        {
            Engine.wake(new ScriptMethodReference(sc_room_a_down));
            Engine.ai_place(room_a_brutes_ini.Squad);
            Engine.ai_place(room_a_jackals_ini.Squad);
            Engine.ai_place(room_a_brutes_bk.Squad);
            await Engine.sleep(150);
            Engine.cs_run_command_script(room_a_prophets, new ScriptMethodReference(cs_room_a_to_jail));
        }

        [ScriptMethod(328, Lifecycle.CommandScript)]
        public async Task cs_ignore_jail_a_marines()
        {
            Engine.cs_abort_on_damage(false);
            Engine.ai_disregard(Engine.ai_actors(jail_a_marines.Squad), true);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => this.g_jail_a_free);
        }

        [ScriptMethod(329, Lifecycle.CommandScript)]
        public async Task cs_ignore_jail_b_marines()
        {
            Engine.cs_abort_on_damage(false);
            Engine.ai_disregard(Engine.ai_actors(jail_b_marines.Squad), true);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => this.g_jail_b_free);
        }

        [ScriptMethod(330, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_a()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p0"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p1"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p2"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(331, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_b()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p3"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p4"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p5"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_c()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p6"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p7"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p8"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_d()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p9"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p10"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p11"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_e()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p12"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p13"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p14"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(335, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_f()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p15"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p16"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_jackal_patrol/p17"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task cs_cell_a_jackal_a()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_a_p0"), 1F);
                await Engine.sleep((short)Engine.random_range(5, 45));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_a_p1"), 1F);
                await Engine.sleep((short)Engine.random_range(5, 45));
                return false;
            });
        }

        [ScriptMethod(337, Lifecycle.CommandScript)]
        public async Task cs_cell_a_jackal_b()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_a_p2"), 1F);
                await Engine.sleep((short)Engine.random_range(5, 45));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_a_p3"), 1F);
                await Engine.sleep((short)Engine.random_range(5, 45));
                return false;
            });
        }

        [ScriptMethod(338, Lifecycle.CommandScript)]
        public async Task cs_cell_a_brute()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_a_p4"), 1F);
                await Engine.sleep((short)Engine.random_range(5, 10));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_a_p5"), 1F);
                await Engine.sleep((short)Engine.random_range(5, 10));
                return false;
            });
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task cs_cell_b_brute()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_b_p0"), 1F);
                await Engine.sleep((short)Engine.random_range(5, 10));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_b_p1"), 1F);
                await Engine.sleep((short)Engine.random_range(5, 10));
                return false;
            });
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task cs_jail_a_marine_a()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_a_plasma_rifle"));
            await Engine.sleep(5);
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3852534827U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await Engine.sleep(15);
            Engine.unit_add_equipment(Engine.ai_get_unit(this.ai_current_actor), jail_a_a, true, true);
            Engine.object_destroy(jail_a_plasma_rifle.Entity);
            await Engine.sleep(15);
            Engine.cs_stop_custom_animation();
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task cs_jail_a_marine_b()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_a_needler"));
            await Engine.sleep(5);
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3852534827U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await Engine.sleep(15);
            Engine.unit_add_equipment(Engine.ai_get_unit(this.ai_current_actor), jail_a_b, true, true);
            Engine.object_destroy(jail_a_needler.Entity);
            await Engine.sleep(15);
            Engine.cs_stop_custom_animation();
        }

        [ScriptMethod(342, Lifecycle.CommandScript)]
        public async Task cs_jail_b_marine_a()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_b_carbine"));
            await Engine.sleep(5);
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3852534827U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await Engine.sleep(15);
            Engine.unit_add_equipment(Engine.ai_get_unit(this.ai_current_actor), jail_b_a, true, true);
            Engine.object_destroy(jail_b_carbine.Entity);
            await Engine.sleep(15);
            Engine.cs_stop_custom_animation();
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task cs_jail_b_marine_b()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_b_plasma_rifle"));
            await Engine.sleep(5);
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3852534827U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await Engine.sleep(15);
            Engine.unit_add_equipment(Engine.ai_get_unit(this.ai_current_actor), jail_b_b, true, true);
            Engine.object_destroy(jail_b_plasma_rifle.Entity);
            await Engine.sleep(15);
            Engine.cs_stop_custom_animation();
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task cs_jail_b_marine_c()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jails/jail_b_plasma_pistol"));
            await Engine.sleep(5);
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3852534827U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await Engine.sleep(15);
            Engine.unit_add_equipment(Engine.ai_get_unit(this.ai_current_actor), jail_b_c, true, true);
            Engine.object_destroy(jail_b_plasma_pistol.Entity);
            await Engine.sleep(15);
            Engine.cs_stop_custom_animation();
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task ai_cell_a_guards()
        {
            if (this.debug)
            {
                Engine.print("cell a guards");
            }

            Engine.ai_place(jail_guard_brute_cell_a.Squad);
            Engine.ai_place(jail_guard_jackal_cell_a.Squad);
            await Engine.sleep(1);
            if (this.g_jail_prophets_ini_active)
            {
                Engine.ai_set_orders(jail_cell_outer_guards_a, jail_guard_alert_cell_a);
            }
        }

        [ScriptMethod(346, Lifecycle.Dormant)]
        public async Task ai_cell_b_guards()
        {
            if (this.debug)
            {
                Engine.print("cell b guards");
            }

            Engine.ai_place(jail_guard_brute_cell_b.Squad);
            Engine.ai_place(jail_guard_jackal_cell_b.Squad);
            await Engine.sleep(1);
            if (this.g_jail_prophets_ini_active)
            {
                Engine.ai_set_orders(jail_cell_outer_guards_b, jail_guard_alert_cell_b);
            }
        }

        [ScriptMethod(347, Lifecycle.CommandScript)]
        public async Task cs_lift_grunt_a()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_turret/p0"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("jail_turret/p0"));
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task cs_lift_grunt_b()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("jail_turret/p1"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("jail_turret/p1"));
        }

        [ScriptMethod(349, Lifecycle.Dormant)]
        public async Task jail_a_doors()
        {
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_jail.p);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), jail_ped_p.Entity, "effect");
            await Engine.sleep_until(async () => this.jail_a_doors_open);
            Engine.ai_disregard(Engine.ai_actors(jail_a_marines.Squad), false);
            Engine.ai_set_orders(jail_a_marines.Squad, jail_marines_mid);
            this.g_jail_a_free = true;
            await Engine.sleep(15);
            Engine.cs_run_command_script(jail_a_marines.a, new ScriptMethodReference(cs_jail_a_marine_a));
            Engine.cs_run_command_script(jail_a_marines.b, new ScriptMethodReference(cs_jail_a_marine_b));
            if (this.g_jail_a_finished || this.g_jail_b_finished)
            {
                Engine.wake(new ScriptMethodReference(sc_second_cell));
            }
            else
            {
                Engine.wake(new ScriptMethodReference(sc_first_cell));
            }

            await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_cell_a, Engine.players())));
            await Engine.sleep(90);
            this.g_jail_a_finished = true;
        }

        [ScriptMethod(350, Lifecycle.Dormant)]
        public async Task jail_b_doors()
        {
            await this.erase_cortana();
            await Engine.sleep(1);
            Engine.ai_place(cortana_jail.q);
            await Engine.sleep(5);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 2203984262U), jail_ped_q.Entity, "effect");
            await Engine.sleep_until(async () => this.jail_b_doors_open);
            Engine.ai_disregard(Engine.ai_actors(jail_b_marines.Squad), false);
            Engine.ai_set_orders(jail_b_marines.Squad, jail_marines_bot);
            this.g_jail_b_free = true;
            await Engine.sleep(15);
            Engine.cs_run_command_script(jail_b_marines.a, new ScriptMethodReference(cs_jail_b_marine_a));
            Engine.cs_run_command_script(jail_b_marines.b, new ScriptMethodReference(cs_jail_b_marine_b));
            Engine.cs_run_command_script(jail_b_marines.c, new ScriptMethodReference(cs_jail_b_marine_c));
            if (this.g_jail_a_finished || this.g_jail_b_finished)
            {
                Engine.wake(new ScriptMethodReference(sc_second_cell));
            }
            else
            {
                Engine.wake(new ScriptMethodReference(sc_first_cell));
            }

            await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_cell_b, Engine.players())));
            await Engine.sleep(60);
            this.g_jail_b_finished = true;
        }

        [ScriptMethod(351, Lifecycle.Dormant)]
        public async Task cor_open_a()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(cell_a_prophets) <= 0);
            await Engine.sleep(60);
            Engine.begin_random(async () => Engine.device_group_set(jail_a_door_b.Entity, jail_a_group_a, 1F), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.device_group_set(jail_a_door_a.Entity, jail_a_group_b, 1F), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.device_group_set(jail_a_door_c.Entity, jail_a_group_c, 1F), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)));
            this.jail_a_doors_open = true;
        }

        [ScriptMethod(352, Lifecycle.Dormant)]
        public async Task cor_open_b()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(cell_b_prophets) <= 0);
            await Engine.sleep(60);
            Engine.begin_random(async () => Engine.device_group_set(jail_b_door_c.Entity, jail_b_group_a, 1F), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.device_group_set(jail_b_door_b.Entity, jail_b_group_b, 1F), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.device_group_set(jail_b_door_a.Entity, jail_b_group_c, 1F), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)));
            this.jail_b_doors_open = true;
        }

        [ScriptMethod(353, Lifecycle.Dormant)]
        public async Task ai_jail_a()
        {
            Engine.data_mine_set_mission_segment("enc_jail_cell_a");
            Engine.game_save();
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(sc_cell_a_ent));
            Engine.wake(new ScriptMethodReference(ai_cell_a_guards));
            await Engine.sleep(15);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_jail_a_ent, Engine.players()), 1);
            Engine.ai_place(jail_a_marines.Squad);
            Engine.ai_place(jail_a_brute.Squad);
            Engine.ai_place(jail_a_jackals.Squad);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(cor_open_a));
            Engine.wake(new ScriptMethodReference(jail_a_doors));
            await Engine.sleep_until(async () => this.g_jail_a_finished);
            Engine.game_save();
        }

        [ScriptMethod(354, Lifecycle.Dormant)]
        public async Task ai_jail_b()
        {
            Engine.data_mine_set_mission_segment("enc_jail_cell_b");
            Engine.game_save();
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(sc_cell_b_ent));
            Engine.wake(new ScriptMethodReference(ai_cell_b_guards));
            await Engine.sleep(15);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_jail_b_ent, Engine.players()), 1);
            Engine.ai_place(jail_b_marines.Squad);
            Engine.ai_place(jail_b_brutes.Squad);
            Engine.ai_place(jail_b_grunts.Squad);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(cor_open_b));
            Engine.wake(new ScriptMethodReference(jail_b_doors));
            await Engine.sleep_until(async () => this.g_jail_b_finished);
            Engine.game_save();
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task ai_jail_door_c()
        {
            if (this.debug)
            {
                Engine.print("door c");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_c.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_c.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_c.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(356, Lifecycle.Static)]
        public async Task ai_jail_door_d()
        {
            if (this.debug)
            {
                Engine.print("door d");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_d.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_d.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_d.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(357, Lifecycle.Static)]
        public async Task ai_jail_door_e()
        {
            if (this.debug)
            {
                Engine.print("door e");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_e.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_e.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_e.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(358, Lifecycle.Static)]
        public async Task ai_jail_door_f()
        {
            if (this.debug)
            {
                Engine.print("door f");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_f.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_f.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_f.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(359, Lifecycle.Static)]
        public async Task ai_jail_door_g()
        {
            if (this.debug)
            {
                Engine.print("door g");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_g.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_g.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_g.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(360, Lifecycle.Static)]
        public async Task ai_jail_door_i()
        {
            if (this.debug)
            {
                Engine.print("door i");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_i.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_i.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_i.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(361, Lifecycle.Static)]
        public async Task ai_jail_door_j()
        {
            if (this.debug)
            {
                Engine.print("door j");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_j.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_j.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_j.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(362, Lifecycle.Static)]
        public async Task ai_jail_door_k()
        {
            if (this.debug)
            {
                Engine.print("door k");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_k.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_k.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_k.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(363, Lifecycle.Static)]
        public async Task ai_jail_door_l()
        {
            if (this.debug)
            {
                Engine.print("door l");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_l.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_l.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_l.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(364, Lifecycle.Static)]
        public async Task ai_jail_door_m()
        {
            if (this.debug)
            {
                Engine.print("door m");
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_brute_m.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_grunt_m.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_door)
                {
                    Engine.ai_place(jail_jackal_m.Squad);
                    this.g_jail_door_count = (short)(this.g_jail_door_count + 1);
                    if (this.g_jail_door_count == this.g_jail_door_limit)
                    {
                        this.g_jail_door = false;
                    }
                }
            });
            this.g_jail_door = true;
            this.g_jail_door_count = 0;
        }

        [ScriptMethod(365, Lifecycle.Static)]
        public async Task ai_jail_spawner()
        {
            if (this.debug)
            {
                Engine.print("jail spawner!!!!");
            }

            Engine.game_save_no_timeout();
            if (await this.difficulty_normal())
            {
                this.g_jail_spawn_limit = 1;
                this.g_jail_door_limit = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_jail_spawn_limit = 1;
                this.g_jail_door_limit = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_jail_spawn_limit = 2;
                this.g_jail_door_limit = 2;
            }

            Engine.begin_random(async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_c.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_c, Engine.players())))
                    {
                        await this.ai_jail_door_c();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_d.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_d, Engine.players())))
                    {
                        await this.ai_jail_door_d();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_e.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_e, Engine.players())))
                    {
                        await this.ai_jail_door_e();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_f.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_f, Engine.players())))
                    {
                        await this.ai_jail_door_f();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_g.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_g, Engine.players())))
                    {
                        await this.ai_jail_door_g();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_i.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_i, Engine.players())))
                    {
                        await this.ai_jail_door_i();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_j.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_j, Engine.players())))
                    {
                        await this.ai_jail_door_j();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_k.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_k, Engine.players())))
                    {
                        await this.ai_jail_door_k();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_l.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_l, Engine.players())))
                    {
                        await this.ai_jail_door_l();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            }, 
                async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (Engine.device_get_position(jail_door_m.Entity) <= 0F && !(Engine.volume_test_objects(tv_jail_door_m, Engine.players())))
                    {
                        await this.ai_jail_door_c();
                        this.g_jail_spawn_count = (short)(this.g_jail_spawn_count + 1);
                        if (this.g_jail_spawn_count == this.g_jail_spawn_limit)
                        {
                            this.g_jail_spawner = false;
                        }
                    }
                }
            });
            this.g_jail_spawner = true;
            this.g_jail_spawn_count = 0;
        }

        [ScriptMethod(366, Lifecycle.Dormant)]
        public async Task ai_jail_down_lift()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_jail_top, Engine.players()) && (short)Engine.ai_living_count(jail_prophets) <= 2, 30, 30 * 30);
            Engine.data_mine_set_mission_segment("enc_jail_down_lift");
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(sc_lift_reins));
            Engine.begin_random(async () => Engine.ai_place(jail_jackals_down.Squad), 
                async () => await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_jail_top, Engine.ai_actors(jail_jackals_down.Squad)), 30, 450), 
                async () => Engine.ai_place(jail_grunts_down.Squad), 
                async () => await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_jail_top, Engine.ai_actors(jail_grunts_down.Squad)), 30, 450));
            Engine.ai_place(jail_brutes_down.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_jail_top, Engine.ai_actors(jail_brutes_down.Squad)), 30, 450);
            await Engine.sleep(90);
            this.g_jail_round_lift_spawned = true;
            Engine.wake(new ScriptMethodReference(sc_jail_clear));
        }

        [ScriptMethod(367, Lifecycle.Dormant)]
        public async Task ai_prophets_ini_active()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(jail_prophets) >= this.ai_combat_status_active);
            if (this.debug)
            {
                Engine.print("jail prophets active");
            }

            this.g_jail_prophets_ini_active = true;
            Engine.ai_set_orders(jail_grunts_ini.Squad, jail_cov_top);
            Engine.ai_set_orders(jail_jackals_ini.Squad, jail_cov_top);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(jail_prophets) <= 2);
            await this.ai_jail_spawner();
        }

        [ScriptMethod(368, Lifecycle.CommandScript)]
        public async Task cs_room_b_brute_ini_a()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_b/p0"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_b/p1"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(369, Lifecycle.CommandScript)]
        public async Task cs_room_b_brute_ini_b()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_b/p2"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_b/p3"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(370, Lifecycle.CommandScript)]
        public async Task cs_room_b_brute_ini_c()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_b/p4"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("room_b/p5"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(371, Lifecycle.Dormant)]
        public async Task ai_room_b_buggers()
        {
            Engine.ai_place(room_b_buggers.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(room_b_buggers.Squad) <= 2);
            if (Engine.volume_test_objects_all(tv_room_b, Engine.players()) && Engine.device_get_position(room_b_exit.Entity) == 0F)
            {
                Engine.ai_place(room_b_buggers.Squad);
            }
        }

        [ScriptMethod(372, Lifecycle.Dormant)]
        public async Task ai_corridor_b()
        {
            if ((float)Engine.ai_living_count(corridor_b_prophets) + (float)Engine.ai_living_count(corridor_b_covenant) <= 8F)
            {
                Engine.ai_place(hall_c_elites.Squad);
            }

            Engine.ai_place(hall_c_buggers.Squad);
            await Engine.sleep(1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(corridor_b_prophets) <= 2);
            Engine.ai_place(hall_c_brute_reins.Squad);
        }

        [ScriptMethod(373, Lifecycle.Dormant)]
        public async Task ai_ext_a_elite_ini()
        {
            Engine.ai_place(ext_a_elite_ini.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(ext_a_brute_ini.Squad) <= 0);
            Engine.ai_migrate(ext_a_elite_ini.Squad, ext_a_watch_elites.Squad);
        }

        [ScriptMethod(374, Lifecycle.Dormant)]
        public async Task ai_ext_a_brute_ini()
        {
            Engine.ai_place(ext_a_brute_ini.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(ext_a_elite_ini.Squad) <= 0);
            Engine.ai_migrate(ext_a_brute_ini.Squad, ext_a_watch_brutes.Squad);
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task ai_ext_a_hunters()
        {
            Engine.ai_place(ext_a_hunters.Squad);
            await Engine.sleep(150);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(ext_a_prophets) <= 4 || Engine.volume_test_objects(tv_ext_a_mid, Engine.players()));
            if ((float)Engine.ai_living_count(ext_a_prophets) + (float)Engine.ai_living_count(ext_a_covenant) <= 6F)
            {
                Engine.ai_place(ext_a_brute_door.Squad);
            }
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task ai_ext_a_prophet_migrate()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(ext_a_covenant) <= 0)
                {
                    Engine.ai_set_orders(ext_a_watch_brutes.Squad, ext_a_prophets_follow);
                    Engine.ai_set_orders(ext_a_brute_door.Squad, ext_a_prophets_follow);
                    Engine.ai_set_orders(ext_a_brute_ini.Squad, ext_a_prophets_follow);
                    Engine.ai_set_orders(ext_a_buggers.Squad, ext_a_prophets_follow);
                }

                if ((short)Engine.ai_living_count(ext_a_prophets) <= 0)
                {
                    Engine.ai_set_orders(ext_a_covenant, ext_a_covenant_follow);
                }

                return false;
            }, 90);
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task ai_ext_a_snipers()
        {
            if (this.g_ext_a_snipers)
            {
                Engine.ai_place(ext_a_jackal_snipers_a.Squad);
                this.g_ext_a_snipers_count = (short)(this.g_ext_a_snipers_count + 1);
                if (this.g_ext_a_snipers_count == this.g_ext_a_snipers_index)
                {
                    this.g_ext_a_snipers = false;
                }
            }

            if (this.g_ext_a_snipers)
            {
                Engine.ai_place(ext_a_jackal_snipers_b.Squad);
                this.g_ext_a_snipers_count = (short)(this.g_ext_a_snipers_count + 1);
                if (this.g_ext_a_snipers_count == this.g_ext_a_snipers_index)
                {
                    this.g_ext_a_snipers = false;
                }
            }

            if (this.g_ext_a_snipers)
            {
                Engine.ai_place(ext_a_jackal_snipers_c.Squad);
                this.g_ext_a_snipers_count = (short)(this.g_ext_a_snipers_count + 1);
                if (this.g_ext_a_snipers_count == this.g_ext_a_snipers_index)
                {
                    this.g_ext_a_snipers = false;
                }
            }

            if (this.g_ext_a_snipers)
            {
                Engine.ai_place(ext_a_jackal_snipers_d.Squad);
                this.g_ext_a_snipers_count = (short)(this.g_ext_a_snipers_count + 1);
                if (this.g_ext_a_snipers_count == this.g_ext_a_snipers_index)
                {
                    this.g_ext_a_snipers = false;
                }
            }
        }

        [ScriptMethod(378, Lifecycle.Dormant)]
        public async Task ai_ext_a_fliers()
        {
            await Engine.sleep_until(async () => (float)Engine.ai_living_count(ext_a_prophets) + (float)Engine.ai_living_count(ext_a_covenant) <= 3F);
            if (!(this.g_ext_a_fliers))
            {
                Engine.ai_place(ext_a_rangers.Squad);
                Engine.ai_place(ext_a_buggers.Squad);
            }
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task tram_a_no_save()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_tram_a_no_save, Engine.players()))
                {
                    Engine.game_save_cancel();
                }

                return false;
            }, 1);
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task tram_b_no_save()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_tram_b_no_save, Engine.players()))
                {
                    Engine.game_save_cancel();
                }

                return false;
            }, 1);
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task tram_c_no_save()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_tram_c_no_save, Engine.players()))
                {
                    Engine.game_save_cancel();
                }

                return false;
            }, 1);
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task tram_d_no_save()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_tram_d_no_save, Engine.players()))
                {
                    Engine.game_save_cancel();
                }

                return false;
            }, 1);
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task ai_garden_a_ini()
        {
            Engine.ai_place(garden_a_elites.Squad);
            Engine.ai_place(garden_a_grunts.Squad);
            Engine.ai_place(garden_a_brute_lt.Squad);
            Engine.ai_place(garden_a_brute_rt.Squad);
            Engine.ai_place(garden_a_jackal_snipers.Squad);
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task ai_garden_a_rangers()
        {
            await Engine.sleep_until(async () => (float)Engine.ai_living_count(garden_a_prophet) + (float)Engine.ai_living_count(garden_a_covenant) <= 5F);
            Engine.ai_place(garden_a_rangers.Squad);
        }

        [ScriptMethod(385, Lifecycle.CommandScript)]
        public async Task cs_garden_a_turret_bk_a()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_a_turrets/p0"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("garden_a_turrets/p0"));
        }

        [ScriptMethod(386, Lifecycle.CommandScript)]
        public async Task cs_garden_a_turret_bk_b()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_a_turrets/p1"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("garden_a_turrets/p1"));
        }

        [ScriptMethod(387, Lifecycle.Dormant)]
        public async Task garden_a_tram_b_on()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_garden_a_tram_b, Engine.players()), 5);
            Engine.object_destroy(garden_tram_b_bk.Entity);
            await Engine.sleep(30);
            Engine.object_create(garden_tram_b);
        }

        [ScriptMethod(388, Lifecycle.CommandScript)]
        public async Task cs_midtower_buggers_hall()
        {
            Engine.cs_abort_on_damage(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("midtower/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("midtower/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("midtower/p2"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("midtower/p3"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("midtower/p4"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("midtower/p5"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("midtower/p6"));
        }

        [ScriptMethod(389, Lifecycle.Dormant)]
        public async Task ai_midtower_buggers_rein()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_midtower_mid, Engine.players()) || (short)Engine.ai_living_count(midtower_prophets) <= 3);
            if ((float)Engine.ai_living_count(midtower_prophets) + (float)Engine.ai_living_count(midtower_covenant) <= 4F)
            {
                Engine.ai_place(midtower_bugger_rein.Squad);
            }

            if (this.debug)
            {
                Engine.print("bugger reinforcements");
            }
        }

        [ScriptMethod(390, Lifecycle.Dormant)]
        public async Task ai_midtower_cov_rein()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_midtower_mid, Engine.players()) || (short)Engine.ai_living_count(midtower_covenant) <= 1 || this.g_midtower_prophet_rein);
            if ((float)Engine.ai_living_count(midtower_prophets) + (float)Engine.ai_living_count(midtower_covenant) <= 4F)
            {
                Engine.ai_place(midtower_elite_reins.Squad);
                if (this.debug)
                {
                    Engine.print("covenant reinforcements");
                }

                await Engine.sleep(5);
                Engine.device_set_position(midtower_exit.Entity, 1F);
            }
        }

        [ScriptMethod(391, Lifecycle.Dormant)]
        public async Task ai_midtower_prophets()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_midtower_bk, Engine.players()) || (short)Engine.ai_living_count(midtower_prophets) <= 2);
            if (Engine.volume_test_objects(tv_midtower_bk, Engine.players()))
            {
                Engine.ai_place(midtower_brutes.Squad);
                if ((short)Engine.ai_living_count(midtower_prophets) <= 3)
                {
                    Engine.ai_place(midtower_jackals.Squad);
                }

                this.g_midtower_prophet_rein = true;
                if (this.debug)
                {
                    Engine.print("exit prophets");
                }
            }

            await Engine.sleep(1);
            if (!(this.g_midtower_prophet_rein))
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_midtower_bk, Engine.players()), 10, 30 * 15);
                Engine.ai_place(midtower_brutes.Squad);
                if ((short)Engine.ai_living_count(midtower_prophets) <= 3)
                {
                    Engine.ai_place(midtower_jackals.Squad);
                }

                this.g_midtower_prophet_rein = true;
                if (this.debug)
                {
                    Engine.print("exit prophets");
                }
            }
        }

        [ScriptMethod(392, Lifecycle.CommandScript)]
        public async Task cs_garden_b_grunts()
        {
            Engine.cs_movement_mode(3);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p0")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p1")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p2")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p3")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p4")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p5")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p6")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p7")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p8")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p9")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p10")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p11")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p12")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p13")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("garden_b/p14")));
                return false;
            });
        }

        [ScriptMethod(393, Lifecycle.CommandScript)]
        public async Task garden_b_brute_berserk()
        {
            Engine.ai_berserk(garden_b_brute_ini.Squad, true);
            Engine.ai_magically_see(garden_b_prophet, garden_b_covenant);
        }

        [ScriptMethod(394, Lifecycle.Dormant)]
        public async Task ai_ext_b_dump()
        {
            await Engine.sleep_until(async () => this.g_ext_b_dump, 30, 30 * 25);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_low, Engine.players()) || (short)Engine.ai_living_count(ext_b_covenant) <= 0 || (short)Engine.ai_living_count(ext_b_prophets) <= 0);
            await Engine.sleep(60);
            if (this.debug)
            {
                Engine.print("--- migrating enemies --- migrating enemies ---");
            }

            Engine.ai_migrate(ext_b_covenant, ext_b_cov_dump.Squad);
            Engine.ai_migrate(ext_b_prophets, ext_b_prophet_dump.Squad);
        }

        [ScriptMethod(395, Lifecycle.Dormant)]
        public async Task ai_ext_b_reins()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_low, Engine.players()) || (short)Engine.ai_living_count(all_enemies) <= 4);
            if (this.debug)
            {
                Engine.print("far door covenant");
            }

            Engine.ai_place(ext_b_grunt_bk_door.Squad);
            Engine.ai_place(ext_b_elites_bk_door.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(all_enemies), 1F, 3F));
            await Engine.sleep(1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_low, Engine.players()) || (short)Engine.ai_living_count(all_enemies) <= 4);
            if (this.debug)
            {
                Engine.print("lower door brutes");
            }

            Engine.ai_place(ext_b_brutes_low_door.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(all_enemies), 1F, 4F));
        }

        [ScriptMethod(396, Lifecycle.CommandScript)]
        public async Task cs_ext_b_grunts_low()
        {
            Engine.cs_movement_mode(3);
            Engine.cs_abort_on_damage(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p0")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p1")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p2")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p3")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p4")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p5")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p6")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p7")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("ext_b/p8")));
                return false;
            });
        }

        [ScriptMethod(397, Lifecycle.CommandScript)]
        public async Task cs_maus_hall_grunts()
        {
            Engine.cs_movement_mode(3);
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_hall/p0"), 2F), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_hall/p2"), 2F), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_hall/p4"), 2F), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_hall/p5"), 2F), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_hall/p6"), 2F), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_hall/p7"), 2F), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_hall/p8"), 2F), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_hall/p9"), 2F));
                return false;
            });
        }

        [ScriptMethod(398, Lifecycle.Dormant)]
        public async Task maus_door()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.structure_bsp_index() == 4)
                {
                    Engine.device_operates_automatically_set(maus_bsp_4_door.Entity, false);
                }
                else if ((short)Engine.structure_bsp_index() == 5)
                {
                    Engine.device_operates_automatically_set(maus_bsp_4_door.Entity, true);
                }

                return false;
            }, 5);
        }

        [ScriptMethod(399, Lifecycle.CommandScript)]
        public async Task cs_maus_room_elite_lt()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_room/p0"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_room/p1"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_room/p2"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_room/p3"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(400, Lifecycle.CommandScript)]
        public async Task cs_maus_room_elite_rt()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_room/p4"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_room/p5"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_room/p6"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("maus_room/p7"), 1F);
                await Engine.sleep((short)Engine.random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(401, Lifecycle.Dormant)]
        public async Task ai_maus_room_ini()
        {
            Engine.ai_place(maus_room_elite_lt.Squad);
            Engine.ai_place(maus_room_elite_rt.Squad);
            if ((short)Engine.ai_living_count(all_enemies) <= 6)
            {
                Engine.ai_place(maus_room_grunt_lt.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(all_enemies), 0F, 2F));
                Engine.ai_place(maus_room_grunt_rt.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(all_enemies), 0F, 2F));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_room_bk, Engine.players()) || (short)Engine.ai_living_count(maus_room_covenant) <= 2);
            Engine.ai_place(maus_room_lt_elite_reins.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(all_enemies), 0F, 1F));
            Engine.ai_place(maus_room_rt_elite_reins.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(all_enemies), 0F, 1F));
            await Engine.sleep(1);
            Engine.ai_place(maus_room_lt_grunt_reins.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(all_enemies), 0F, 2F));
            Engine.ai_place(maus_room_rt_grunt_reins.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(all_enemies), 0F, 2F));
        }

        [ScriptMethod(402, Lifecycle.Dormant)]
        public async Task ai_maus_bridge_ini()
        {
            if (this.debug)
            {
                Engine.print("initial bridge");
            }

            if ((short)Engine.ai_living_count(all_enemies) < 4)
            {
                Engine.ai_place(maus_bridge_elite_turret.Squad, 2);
            }
            else
            {
                Engine.ai_place(maus_bridge_elite_turret.Squad, 1);
            }

            Engine.ai_place(maus_bridge_elites_ini.Squad);
            Engine.ai_place(maus_bridge_brutes_ini.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(all_enemies), 0F, 3F));
            Engine.ai_place(maus_bridge_jackals_ini.Squad);
            await Engine.sleep_until(async () => this.g_maus_bridge_fr || (bool)Engine.ai_trigger_test("maus_bridge_elites_ini", maus_bridge_elites_ini.Squad) || (short)Engine.ai_living_count(maus_bridge_prophets) <= 1);
            await Engine.sleep(1);
            if (this.debug)
            {
                Engine.print("bugger reinforcements");
            }

            Engine.ai_place(maus_bridge_buggers_ini.Squad, (short)Engine.pin(11F - (float)Engine.ai_living_count(all_enemies), 0F, 5F));
        }

        [ScriptMethod(403, Lifecycle.Dormant)]
        public async Task ai_maus_inner_order_transitions()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(maus_inner_prophets) <= 0)
                {
                    Engine.ai_vehicle_exit(maus_inner_turrets.Squad);
                    Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(maus_inner_turrets.a), true);
                    Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(maus_inner_turrets.b), true);
                    await Engine.sleep(60);
                    Engine.ai_set_orders(maus_inner_elites_ini.Squad, maus_inner_follow);
                    Engine.ai_set_orders(maus_inner_turrets.Squad, maus_inner_follow);
                }

                if ((short)Engine.ai_living_count(maus_inner_elites_ini.Squad) <= 0 && (short)Engine.ai_living_count(maus_inner_prophets) <= 0)
                {
                    Engine.ai_set_orders(maus_inner_hunters_ini.Squad, maus_inner_follow);
                }

                if ((short)Engine.ai_living_count(maus_inner_covenant) <= 0)
                {
                    Engine.ai_set_orders(maus_inner_prophets, maus_inner_follow);
                }

                return this.g_maus_inner_order_trans;
            }, 60);
        }

        [ScriptMethod(404, Lifecycle.Dormant)]
        public async Task ai_maus_inner_brute_reins()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(maus_inner_brutes_ini.Squad) <= 0);
            await Engine.sleep(90);
            Engine.ai_place(maus_inner_brutes_rein.Squad);
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(ai_maus_inner_order_transitions));
        }

        [ScriptMethod(405, Lifecycle.Static)]
        public async Task ai_maus_inner_brute_a()
        {
            if (this.debug)
            {
                Engine.print("door a");
            }

            if (!(Engine.volume_test_objects(tv_maus_inner_door_a, Engine.players())) && Engine.device_get_position(maus_inner_door_a.Entity) == 0F)
            {
                Engine.ai_place(maus_inner_brutes_a.Squad);
                this.g_maus_inner_count = (short)(this.g_maus_inner_count + 1);
                if (this.g_maus_inner_count == this.g_maus_inner_limit)
                {
                    this.g_maus_inner = false;
                }
            }
        }

        [ScriptMethod(406, Lifecycle.Static)]
        public async Task ai_maus_inner_brute_b()
        {
            if (this.debug)
            {
                Engine.print("door b");
            }

            if (!(Engine.volume_test_objects(tv_maus_inner_door_b, Engine.players())) && Engine.device_get_position(maus_inner_door_b.Entity) == 0F)
            {
                Engine.ai_place(maus_inner_brutes_b.Squad);
                this.g_maus_inner_count = (short)(this.g_maus_inner_count + 1);
                if (this.g_maus_inner_count == this.g_maus_inner_limit)
                {
                    this.g_maus_inner = false;
                }
            }
        }

        [ScriptMethod(407, Lifecycle.Static)]
        public async Task ai_maus_inner_brute_c()
        {
            if (this.debug)
            {
                Engine.print("door c");
            }

            if (!(Engine.volume_test_objects(tv_maus_inner_door_c, Engine.players())) && Engine.device_get_position(maus_inner_door_c.Entity) == 0F)
            {
                Engine.ai_place(maus_inner_brutes_c.Squad);
                this.g_maus_inner_count = (short)(this.g_maus_inner_count + 1);
                if (this.g_maus_inner_count == this.g_maus_inner_limit)
                {
                    this.g_maus_inner = false;
                }
            }
        }

        [ScriptMethod(408, Lifecycle.Static)]
        public async Task ai_maus_inner_brute_d()
        {
            if (this.debug)
            {
                Engine.print("door d");
            }

            if (!(Engine.volume_test_objects(tv_maus_inner_door_d, Engine.players())) && Engine.device_get_position(maus_inner_door_d.Entity) == 0F)
            {
                Engine.ai_place(maus_inner_brutes_d.Squad);
                this.g_maus_inner_count = (short)(this.g_maus_inner_count + 1);
                if (this.g_maus_inner_count == this.g_maus_inner_limit)
                {
                    this.g_maus_inner = false;
                }
            }
        }

        [ScriptMethod(409, Lifecycle.Static)]
        public async Task ai_maus_inner_brute_e()
        {
            if (this.debug)
            {
                Engine.print("door e");
            }

            if (!(Engine.volume_test_objects(tv_maus_inner_door_e, Engine.players())) && Engine.device_get_position(maus_inner_door_e.Entity) == 0F)
            {
                Engine.ai_place(maus_inner_brutes_e.Squad);
                this.g_maus_inner_count = (short)(this.g_maus_inner_count + 1);
                if (this.g_maus_inner_count == this.g_maus_inner_limit)
                {
                    this.g_maus_inner = false;
                }
            }
        }

        [ScriptMethod(410, Lifecycle.Static)]
        public async Task ai_maus_inner_brute_f()
        {
            if (this.debug)
            {
                Engine.print("door f");
            }

            if (!(Engine.volume_test_objects(tv_maus_inner_door_f, Engine.players())) && Engine.device_get_position(maus_inner_door_f.Entity) == 0F)
            {
                Engine.ai_place(maus_inner_brutes_f.Squad);
                this.g_maus_inner_count = (short)(this.g_maus_inner_count + 1);
                if (this.g_maus_inner_count == this.g_maus_inner_limit)
                {
                    this.g_maus_inner = false;
                }
            }
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task ai_maus_inner_spawn()
        {
            if (await this.difficulty_normal())
            {
                this.g_maus_inner_wave_limit = 1;
                this.g_maus_inner_limit = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_maus_inner_wave_limit = 2;
                this.g_maus_inner_limit = 1;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_maus_inner_wave_limit = 3;
                this.g_maus_inner_limit = 2;
            }

            await Engine.sleep_until(async () =>
            {
                this.g_maus_inner = true;
                this.g_maus_inner_count = 0;
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(maus_inner_prophets) <= 1);
                await Engine.sleep((short)Engine.random_range(this.sleep_lower_bound, this.sleep_upper_bound));
                Engine.begin_random(async () =>
                {
                    if (this.g_maus_inner)
                    {
                        await this.ai_maus_inner_brute_a();
                    }
                }, 
                    async () =>
                {
                    if (this.g_maus_inner)
                    {
                        await this.ai_maus_inner_brute_b();
                    }
                }, 
                    async () =>
                {
                    if (this.g_maus_inner)
                    {
                        await this.ai_maus_inner_brute_c();
                    }
                }, 
                    async () =>
                {
                    if (this.g_maus_inner)
                    {
                        await this.ai_maus_inner_brute_d();
                    }
                }, 
                    async () =>
                {
                    if (this.g_maus_inner)
                    {
                        await this.ai_maus_inner_brute_e();
                    }
                }, 
                    async () =>
                {
                    if (this.g_maus_inner)
                    {
                        await this.ai_maus_inner_brute_f();
                    }
                });
                await Engine.sleep((short)Engine.random_range(this.sleep_lower_bound, this.sleep_upper_bound));
                if ((short)Engine.random_range(0, 2) == 0)
                {
                    Engine.ai_place(maus_inner_buggers_lt.Squad);
                }
                else
                {
                    Engine.ai_place(maus_inner_buggers_rt.Squad);
                }

                await Engine.sleep(1);
                Engine.ai_set_orders(maus_inner_buggers, maus_inner_follow);
                this.g_maus_inner_wave_count = (short)(this.g_maus_inner_wave_count + 1);
                if (this.g_maus_inner_wave_count == this.g_maus_inner_wave_limit)
                {
                    this.g_maus_inner_wave_pause = false;
                    await Engine.sleep_until(async () => this.g_maus_inner_wave_pause);
                }

                if (this.g_maus_inner_wave_count == (short)(this.g_maus_inner_wave_limit * 2))
                {
                    this.g_maus_inner_wave_end = true;
                }

                return this.g_maus_inner_wave_end;
            });
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task ai_maus_inner_elites_final()
        {
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_maus_ent_door_a, Engine.players())) && Engine.device_get_position(maus_ent_door_a.Entity) <= 0F && !(Engine.volume_test_objects(tv_maus_ent_door_b, Engine.players())) && Engine.device_get_position(maus_ent_door_b.Entity) <= 0F);
            Engine.ai_place(maus_inner_elites_ultra.Squad);
            await Engine.sleep(45);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_maus_ent_door_a, Engine.players())) && Engine.device_get_position(maus_ent_door_a.Entity) <= 0F && !(Engine.volume_test_objects(tv_maus_ent_door_b, Engine.players())) && Engine.device_get_position(maus_ent_door_b.Entity) <= 0F);
            Engine.ai_place(maus_inner_elites_spec.Squad);
            await Engine.sleep(45);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_maus_ent_door_a, Engine.players())) && Engine.device_get_position(maus_ent_door_a.Entity) <= 0F && !(Engine.volume_test_objects(tv_maus_ent_door_b, Engine.players())) && Engine.device_get_position(maus_ent_door_b.Entity) <= 0F);
            Engine.ai_place(maus_inner_elite_zealot.Squad);
        }

        [ScriptMethod(413, Lifecycle.Dormant)]
        public async Task enc_council_chamber()
        {
            Engine.data_mine_set_mission_segment("enc_council_ini");
            if (this.debug)
            {
                Engine.print("initialize council chamber encounters");
            }

            Engine.game_save();
            Engine.object_hide(holo_generator.Entity, false);
            Engine.device_set_position_immediate(council_ped.Entity, 0.75F);
            Engine.device_set_position(council_ped.Entity, 1F);
            Engine.ai_place(council_grunt_ini.Squad);
            Engine.ai_place(council_brute_ini.Squad);
            Engine.wake(new ScriptMethodReference(ai_council_brutes_berserk));
            await Engine.sleep(90);
            Engine.wake(new ScriptMethodReference(sc_council_ini));
            await Engine.sleep(90);
            Engine.device_one_sided_set(council_door_left_a.Entity, true);
            Engine.device_one_sided_set(council_door_left_b.Entity, true);
            Engine.device_one_sided_set(council_door_left_c.Entity, true);
            Engine.device_one_sided_set(council_door_right_a.Entity, true);
            Engine.device_one_sided_set(council_door_right_b.Entity, true);
            Engine.device_one_sided_set(council_door_right_c.Entity, true);
            Engine.wake(new ScriptMethodReference(ai_council_orders));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(council_prophets_floor) <= 0);
            Engine.wake(new ScriptMethodReference(ai_council_floor_spawn));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(prophets) <= 0 && this.g_council_over);
            await Engine.sleep(75);
            Engine.wake(new ScriptMethodReference(music_07a_01));
            Engine.wake(new ScriptMethodReference(sc_council_exit));
            await Engine.sleep_until(async () => Engine.device_get_position(council_exit.Entity) >= 0.8F);
            Engine.ai_place(grand_a_grunts.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_grand_hall, Engine.players()), 10);
            Engine.data_mine_set_mission_segment("enc_grand_a");
            Engine.game_save();
            Engine.ai_place(grand_a_brutes.Squad);
            Engine.ai_place(grand_a_turret.Squad);
            if (await this.difficulty_normal())
            {
                Engine.ai_place(ledge_brutes_ini.Squad, 1);
            }
            else
            {
                Engine.ai_place(ledge_brutes_ini.Squad);
            }

            if (await this.difficulty_normal())
            {
                Engine.ai_place(ledge_brutes_honor_ini.Squad, 1);
            }
            else
            {
                Engine.ai_place(ledge_brutes_honor_ini.Squad);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(grand_a_prophets) <= 2, 30, 210);
            Engine.wake(new ScriptMethodReference(music_07a_02));
            Engine.wake(new ScriptMethodReference(sc_grand_a_exit));
        }

        [ScriptMethod(414, Lifecycle.Dormant)]
        public async Task enc_dervish_ledge()
        {
            Engine.data_mine_set_mission_segment("enc_ledge_ini");
            if (this.debug)
            {
                Engine.print("initialize dervish ledge encounters");
            }

            Engine.game_save();
            Engine.ai_disposable(council_prophets, true);
            Engine.ai_place(ledge_jackal_left.Squad);
            Engine.ai_place(ledge_jackal_right.Squad);
            Engine.wake(new ScriptMethodReference(ai_dervish_ledge_orders));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_ledge_fr, Engine.players()));
            await Engine.sleep((short)Engine.random_range(15, 45));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_ledge_bk, Engine.players()) || (short)Engine.ai_living_count(dervish_ledge_prophets) <= 2, 10);
            Engine.data_mine_set_mission_segment("enc_ledge_lift");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(ai_ledge_lift));
            Engine.wake(new ScriptMethodReference(sc_ledge_down));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_ledge_lower, Engine.players()));
            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_ledge_lower");
            Engine.wake(new ScriptMethodReference(ai_ledge_lower));
            this.g_music_07a_02 = false;
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task enc_corridors_a()
        {
            Engine.data_mine_set_mission_segment("enc_high_hall_a");
            if (this.debug)
            {
                Engine.print("initialize corridor a encounters");
            }

            Engine.ai_disposable(grand_a_prophets, true);
            Engine.ai_disposable(dervish_ledge_prophets, true);
            Engine.wake(new ScriptMethodReference(corridor_a_activate));
            Engine.wake(new ScriptMethodReference(ai_hall_a_prophets));
            Engine.wake(new ScriptMethodReference(sc_corridor_a_amb));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_b, Engine.players()), 5);
            Engine.data_mine_set_mission_segment("enc_high_hall_b");
            Engine.wake(new ScriptMethodReference(sc_jail_info));
            Engine.ai_place(hall_b_brutes.Squad);
            Engine.ai_place(hall_b_grunts.Squad);
            Engine.ai_place(hall_b_grunts_bk.Squad);
            Engine.wake(new ScriptMethodReference(sc_room_a_lift));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_room_a, Engine.players()), 1);
            Engine.data_mine_set_mission_segment("enc_room_a");
            Engine.game_save();
            Engine.device_operates_automatically_set(room_a_door1.Entity, true);
            Engine.wake(new ScriptMethodReference(ai_room_a));
            Engine.wake(new ScriptMethodReference(room_a_door));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_room_a_bot, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(sc_room_a_down));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_room_a_tube, Engine.players()));
            Engine.cs_run_command_script(room_a_prophets, new ScriptMethodReference(cs_room_a_to_jail));
            Engine.ai_migrate(room_a_prophets, jail_trash.Squad);
            await this.erase_cortana();
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task enc_jails()
        {
            Engine.data_mine_set_mission_segment("enc_jail_ini");
            if (this.debug)
            {
                Engine.print("initialize jails encounters");
            }

            Engine.ai_disposable(hall_a_prophets, true);
            Engine.ai_disposable(hall_b_prophets, true);
            Engine.device_set_power(room_a_lift.Entity, 0F);
            Engine.device_set_position(room_a_lift_effect.Entity, 1F);
            Engine.device_set_position(jail_down.Entity, 1F);
            Engine.ai_erase(room_a_tube_fodder.Squad);
            Engine.ai_place(jail_brutes_ini.Squad);
            Engine.ai_place(jail_grunts_ini.Squad);
            Engine.ai_place(jail_jackals_ini.Squad);
            Engine.wake(new ScriptMethodReference(music_07a_03));
            Engine.wake(new ScriptMethodReference(ai_prophets_ini_active));
            Engine.wake(new ScriptMethodReference(sc_jail_down));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(jail_brutes_ini.Squad) <= 0 && (short)Engine.ai_living_count(jail_jackals_ini.Squad) <= 0);
            Engine.game_save();
            if (this.g_jail_prophets_ini_active)
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(jail_prophets) <= 0);
            }
            else
            {
                Engine.sleep_forever(new ScriptMethodReference(ai_prophets_ini_active));
            }

            if ((short)Engine.random_range(0, 2) == 0)
            {
                Engine.wake(new ScriptMethodReference(ai_jail_a));
            }
            else
            {
                Engine.wake(new ScriptMethodReference(ai_jail_b));
            }

            await Engine.sleep_until(async () => this.g_jail_a_finished || this.g_jail_b_finished);
            await this.ai_jail_spawner();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            if (this.g_jail_a_finished)
            {
                Engine.wake(new ScriptMethodReference(ai_jail_b));
            }
            else
            {
                Engine.wake(new ScriptMethodReference(ai_jail_a));
            }

            await Engine.sleep_until(async () => this.g_jail_a_finished && this.g_jail_b_finished);
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.wake(new ScriptMethodReference(sc_jail_exit));
            await this.ai_jail_spawner();
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(ai_jail_down_lift));
            await Engine.sleep_until(async () => this.g_jail_round_lift_spawned);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_jail_top, Engine.players())) && !(Engine.volume_test_objects_all(tv_jail_mid, Engine.players())) && !(Engine.volume_test_objects_all(tv_jail_bot, Engine.players())));
            await this.erase_cortana();
            this.g_music_07a_03 = false;
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task enc_corridors_b()
        {
            Engine.data_mine_set_mission_segment("enc_corridors_b");
            if (this.debug)
            {
                Engine.print("initialize corridor b encounters");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            this.g_jail_exit_reminder = true;
            if (!(this.g_jail_a_finished) && !(this.g_jail_b_finished))
            {
                Engine.object_destroy(jail_down.Entity);
                Engine.object_create(jail_up);
                Engine.object_create(room_b_lift);
                Engine.device_set_position(room_b_lift_effect.Entity, 1F);
                await Engine.sleep(1);
                Engine.ai_place(room_b_marines.Squad);
            }

            Engine.ai_disposable(jail_prophets, true);
            Engine.wake(new ScriptMethodReference(sc_room_b));
            Engine.wake(new ScriptMethodReference(grand_b_door));
            Engine.wake(new ScriptMethodReference(objective_truth_set));
            Engine.ai_set_orders(marines, marines_corr_b);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_room_b_start, Engine.players()), 5);
            Engine.pvs_clear();
            Engine.ai_place(room_b_elites.Squad);
            Engine.wake(new ScriptMethodReference(ai_room_b_buggers));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_c, Engine.players()));
            Engine.game_save();
            Engine.cs_run_command_script(marines, new ScriptMethodReference(cs_abort));
            Engine.wake(new ScriptMethodReference(ai_corridor_b));
            Engine.wake(new ScriptMethodReference(marine_migration));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_c_bk, Engine.players()), 1);
            Engine.ai_disposable(room_b_prophets, true);
            Engine.ai_disposable(room_b_covenant, true);
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            if ((short)Engine.ai_living_count(corridor_b_prophets) <= 4)
            {
                Engine.ai_place(hall_c_bugger_reins.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_d, Engine.players()));
            Engine.wake(new ScriptMethodReference(sc_corridor_b_exit));
            Engine.ai_place(hall_d_elites.Squad);
            Engine.ai_place(hall_d_brutes.Squad);
            if ((float)Engine.ai_living_count(corridor_b_prophets) + (float)Engine.ai_living_count(corridor_b_covenant) <= 8F)
            {
                Engine.ai_place(hall_d_jackals_bk.Squad);
            }

            await Engine.sleep(1);
            if ((float)Engine.ai_living_count(corridor_b_prophets) + (float)Engine.ai_living_count(corridor_b_covenant) <= 8F)
            {
                Engine.ai_place(hall_d_jackals_fr.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_grand_b, Engine.players()));
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_07a_04));
            Engine.ai_place(grand_b_hunter_a.Squad);
            Engine.ai_place(grand_b_hunter_b.Squad);
            Engine.ai_disposable(corridor_b_prophets, true);
            Engine.ai_disposable(corridor_b_covenant, true);
            Engine.objects_predict(Engine.ai_actors(ext_a_prophets));
            Engine.objects_predict(Engine.ai_actors(ext_a_covenant));
            Engine.wake(new ScriptMethodReference(sc_network));
        }

        [ScriptMethod(418, Lifecycle.Dormant)]
        public async Task enc_tower_a_ext()
        {
            Engine.data_mine_set_mission_segment("enc_tower_a_exterior");
            if (this.debug)
            {
                Engine.print("initialize tower a exterior encounters");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            if (await this.difficulty_legendary())
            {
                Engine.wake(new ScriptMethodReference(ice_cream_angry));
            }

            Engine.ai_disposable(corridor_b_prophets, true);
            Engine.ai_disposable(corridor_b_covenant, true);
            Engine.wake(new ScriptMethodReference(ai_ext_a_snipers));
            Engine.ai_place(ext_a_watch_brutes.Squad);
            Engine.ai_place(ext_a_watch_elites.Squad);
            Engine.wake(new ScriptMethodReference(ai_ext_a_hunters));
            Engine.wake(new ScriptMethodReference(ai_ext_a_elite_ini));
            Engine.wake(new ScriptMethodReference(ai_ext_a_brute_ini));
            Engine.wake(new ScriptMethodReference(ai_ext_a_prophet_migrate));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_mid, Engine.players()) || (float)Engine.ai_living_count(ext_a_prophets) + (float)Engine.ai_living_count(ext_a_covenant) <= 6F, 10);
            Engine.ai_disposable(grand_b_hunters, true);
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.wake(new ScriptMethodReference(ai_ext_a_fliers));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_exit, Engine.players()));
            this.g_ext_a_fliers = true;
            Engine.ai_place(ext_a_brute_bk_door.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_tower_a_ramp, Engine.players()), 10);
            this.g_music_07a_04_alt = true;
            Engine.wake(new ScriptMethodReference(sc_truth_a));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_garden_a_tram, Engine.players()) || (short)Engine.ai_living_count(ext_a_brutes_bk.Squad) <= 0 && (short)Engine.ai_living_count(ext_a_buggers_bk.Squad) <= 0, 10);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(sc_in_amber_clad));
            Engine.wake(new ScriptMethodReference(tram_a_no_save));
            await Engine.sleep(60);
            if (!(Engine.volume_test_objects(tv_tram_a_no_save, Engine.players())))
            {
                Engine.game_save();
            }

            Engine.wake(new ScriptMethodReference(music_07a_05));
            await Engine.sleep_until(async () => this.g_sc_ioc_finished);
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }
        }

        [ScriptMethod(419, Lifecycle.Dormant)]
        public async Task enc_gardens_a()
        {
            Engine.data_mine_set_mission_segment("enc_gardens_a");
            if (this.debug)
            {
                Engine.print("initialize hanging gardens a encounters");
            }

            Engine.game_save();
            await this.erase_cortana();
            Engine.ai_disposable(ext_a_prophets, true);
            Engine.ai_disposable(ext_a_covenant, true);
            this.g_marine_mig_garden_a = true;
            this.g_ioc_reminder = true;
            Engine.wake(new ScriptMethodReference(ai_garden_a_ini));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_garden_a_fr_suck, Engine.players()) || Engine.volume_test_objects(tv_garden_a_fr, Engine.players()), 5);
            if (this.debug)
            {
                Engine.print("garden a fr");
            }

            Engine.ai_place(garden_a_brute_a.Squad);
            Engine.ai_place(garden_a_brute_b.Squad);
            Engine.ai_place(garden_a_brute_c.Squad);
            Engine.ai_place(garden_a_elite_a.Squad);
            Engine.ai_place(garden_a_elite_b.Squad);
            Engine.ai_place(garden_a_elite_c.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_garden_a_mid, Engine.players()));
            if (this.debug)
            {
                Engine.print("garden a mid");
            }

            Engine.game_save();
            this.g_music_07a_05 = false;
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.wake(new ScriptMethodReference(ai_garden_a_rangers));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_garden_a_bk, Engine.players()));
            if (this.debug)
            {
                Engine.print("garden a bk");
            }

            Engine.game_save();
            Engine.wake(new ScriptMethodReference(garden_a_tram_b_on));
            Engine.ai_place(garden_a_elites_bk.Squad);
            Engine.ai_place(garden_a_grunts_bk.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(all_enemies), 0F, 2F));
            await Engine.sleep(1);
            Engine.ai_place(garden_a_brutes_bk.Squad);
            Engine.ai_place(garden_a_jackals_bk.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(all_enemies), 0F, 2F));
        }

        [ScriptMethod(420, Lifecycle.Dormant)]
        public async Task ai_midtower_ini()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(midtower_ent_door.Entity) > 0F, 10);
            Engine.ai_place(midtower_buggers_hall.Squad);
        }

        [ScriptMethod(421, Lifecycle.Dormant)]
        public async Task enc_mid_tower()
        {
            Engine.data_mine_set_mission_segment("enc_mid_tower");
            if (this.debug)
            {
                Engine.print("initialize midspan tower encounters");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_disposable(garden_a_prophet, true);
            Engine.ai_disposable(garden_a_covenant, true);
            this.g_marine_mig_midtower = true;
            Engine.wake(new ScriptMethodReference(sc_drive_elites));
            Engine.wake(new ScriptMethodReference(ai_midtower_ini));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mid_tower_room, Engine.players()));
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.game_save();
            Engine.ai_place(midtower_elites.Squad);
            Engine.ai_place(midtower_buggers_ini.Squad);
            Engine.wake(new ScriptMethodReference(ai_midtower_buggers_rein));
            Engine.wake(new ScriptMethodReference(ai_midtower_cov_rein));
            Engine.wake(new ScriptMethodReference(ai_midtower_prophets));
            Engine.wake(new ScriptMethodReference(music_07a_06));
        }

        [ScriptMethod(422, Lifecycle.Dormant)]
        public async Task enc_gardens_b()
        {
            Engine.data_mine_set_mission_segment("enc_gardens_b");
            if (this.debug)
            {
                Engine.print("initialize hanging gardens b encounters");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            this.g_music_07a_06 = true;
            Engine.ai_disposable(midtower_prophets, true);
            Engine.ai_disposable(midtower_covenant, true);
            Engine.wake(new ScriptMethodReference(sc_gardens_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_garden_b_fr, Engine.players()));
            if (this.debug)
            {
                Engine.print("garden b fr");
            }

            Engine.game_save();
            Engine.ai_place(garden_b_grunt_a.Squad);
            Engine.ai_place(garden_b_grunt_b.Squad);
            Engine.ai_place(garden_b_grunt_c.Squad);
            Engine.ai_place(garden_b_brute_ini.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_garden_b_mid, Engine.players()));
            if (this.debug)
            {
                Engine.print("garden b mid");
            }

            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_garden_b_bk, Engine.players()));
            if (this.debug)
            {
                Engine.print("garden b bk");
            }

            Engine.game_save();
            Engine.wake(new ScriptMethodReference(tram_d_no_save));
        }

        [ScriptMethod(423, Lifecycle.Dormant)]
        public async Task enc_tower_b_ext()
        {
            Engine.data_mine_set_mission_segment("enc_tower_b_exterior");
            if (this.debug)
            {
                Engine.print("initialize tower b exterior encounters");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_disposable(garden_b_prophet, true);
            Engine.ai_disposable(garden_b_covenant, true);
            this.g_marine_mig_ext_b = true;
            Engine.wake(new ScriptMethodReference(objective_truth_clear));
            Engine.wake(new ScriptMethodReference(objective_phantom_set));
            Engine.ai_place(ext_b_brute_ramp.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b, Engine.players()), 5);
            if (this.debug)
            {
                Engine.print("initial enemies");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_place(ext_b_elite_a.Squad);
            Engine.ai_place(ext_b_brute_a.Squad);
            Engine.ai_place(ext_b_grunts_b.Squad);
            Engine.ai_place(ext_b_brutes_b.Squad);
            Engine.ai_place(ext_b_grunts_low.Squad);
            Engine.ai_place(ext_b_brutes_low.Squad);
            Engine.ai_place(ext_b_jackal_a.Squad);
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(ai_ext_b_reins));
            Engine.wake(new ScriptMethodReference(ai_ext_b_dump));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_lt, Engine.players()));
            this.g_ext_b_dump = true;
            if (this.debug)
            {
                Engine.print("placing left covenant");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_place(ext_b_grunts_lt.Squad);
            Engine.ai_place(ext_b_elites_stealth.Squad);
        }

        [ScriptMethod(424, Lifecycle.Dormant)]
        public async Task enc_mausoleum_ext()
        {
            Engine.data_mine_set_mission_segment("enc_maus_grand");
            if (this.debug)
            {
                Engine.print("initialize mausoleum exterior encounters");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_disposable(ext_b_prophets, true);
            Engine.ai_disposable(ext_b_covenant, true);
            this.g_marine_mig_maus = true;
            Engine.wake(new ScriptMethodReference(maus_door));
            Engine.ai_place(maus_hall_grunts.Squad);
            Engine.ai_place(maus_hall_elites_stealth.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_room, Engine.players()), 5);
            Engine.data_mine_set_mission_segment("enc_maus_room");
            Engine.game_save();
            Engine.cs_run_command_script(covenant1, new ScriptMethodReference(cs_abort));
            Engine.ai_set_orders(maus_hall_covenant, maus_room_cov_follow);
            this.g_marine_mig_maus_room = true;
            Engine.wake(new ScriptMethodReference(ai_maus_room_ini));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_room_bk, Engine.players()), 10);
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_place(maus_room_brute_bk.Squad);
            Engine.ai_place(maus_room_jackal_bk_lt.Squad);
            Engine.ai_place(maus_room_jackal_bk_rt.Squad);
            Engine.ai_set_orders(maus_hall_covenant, maus_room_cov_follow);
            Engine.ai_set_orders(maus_room_covenant, maus_room_cov_follow);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_bridge, Engine.players()), 5);
            Engine.data_mine_set_mission_segment("enc_maus_bridge");
            Engine.game_save();
            await this.erase_cortana();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_set_orders(maus_hall_covenant, maus_bridge_cov_screw);
            Engine.ai_set_orders(maus_room_prophet, maus_bridge_prophet_screw);
            Engine.ai_set_orders(maus_room_covenant, maus_bridge_cov_screw);
            Engine.sleep_forever(new ScriptMethodReference(ai_maus_room_ini));
            Engine.ai_disposable(maus_hall_covenant, true);
            Engine.wake(new ScriptMethodReference(ai_maus_bridge_ini));
            Engine.wake(new ScriptMethodReference(sc_catch_truth));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_bridge_fr, Engine.players()), 10);
            this.g_maus_bridge_fr = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_bridge_mid, Engine.players()), 10);
            Engine.game_save();
            if (this.debug)
            {
                Engine.print("bridge reinforcements wave 1");
            }

            Engine.ai_place(maus_bridge_elite_rein.Squad, (short)Engine.pin(12F - (float)Engine.ai_living_count(all_enemies), 1F, 2F));
            await Engine.sleep(1);
            Engine.ai_place(maus_bridge_grunt_rein.Squad, (short)Engine.pin(10F - (float)Engine.ai_living_count(all_enemies), 0F, 4F));
            await Engine.sleep(1);
            Engine.ai_place(maus_bridge_buggers_ini.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(all_enemies), 2F, 5F));
            Engine.ai_set_orders(maus_bridge_buggers_ini.Squad, maus_bridge_buggers_rein);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_bridge_bk, Engine.players()), 10);
            if (this.debug)
            {
                Engine.print("bridge reinforcements wave 2");
            }

            Engine.game_save();
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_place(maus_bridge_grunt_rein_b.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(all_enemies), 0F, 4F));
            Engine.ai_place(maus_bridge_hunters.Squad);
        }

        [ScriptMethod(425, Lifecycle.Dormant)]
        public async Task enc_mausoleum()
        {
            Engine.data_mine_set_mission_segment("enc_mausoleum");
            if (this.debug)
            {
                Engine.print("initialize mausoleum encounters");
            }

            Engine.game_save();
            Engine.kill_volume_disable(kill_maus);
            this.g_marine_mig_maus_int = true;
            if ((short)Engine.ai_living_count(marines) <= 3)
            {
                Engine.ai_renew(marines);
            }

            Engine.ai_disposable(maus_room_prophet, true);
            Engine.ai_disposable(maus_room_covenant, true);
            Engine.ai_disposable(maus_bridge_prophets, true);
            Engine.ai_disposable(maus_bridge_covenant, true);
            Engine.ai_set_orders(maus_bridge_covenant, maus_ent_collapse);
            Engine.ai_set_orders(maus_bridge_prophets, maus_ent_collapse);
            Engine.ai_place(maus_inner_elites_ini.Squad);
            Engine.ai_place(maus_inner_brutes_ini.Squad);
            Engine.ai_place(maus_inner_buggers_lt.Squad);
            Engine.wake(new ScriptMethodReference(music_07a_07));
            Engine.wake(new ScriptMethodReference(sc_maus_interior));
            await Engine.sleep(120);
            Engine.kill_volume_enable(kill_maus);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_maus_inner_mid, Engine.players()) || (short)Engine.ai_living_count(maus_inner_covenant) <= 1);
            Engine.game_save();
            await Engine.sleep(5);
            Engine.ai_place(maus_inner_hunters_ini.Squad);
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(ai_maus_inner_brute_reins));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(maus_inner_prophets) <= 0 && (short)Engine.ai_living_count(maus_inner_covenant) <= 0, 30, 30 * 60 * 10);
            Engine.game_save();
            this.g_maus_inner_order_trans = true;
            await this.sc_maus_breather();
            Engine.data_mine_set_mission_segment("enc_maus_midpoint");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_07a_08));
            Engine.wake(new ScriptMethodReference(ai_maus_inner_elites_final));
            this.g_music_07a_07 = false;
            this.g_music_07a_08 = true;
            await Engine.sleep(60);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(sc_maus_exit));
        }

        [ScriptMethod(426, Lifecycle.Static)]
        public async Task cutscenes()
        {
            await this.x08();
            await Engine.sleep(30);
            await this.c07_intro();
            await Engine.sleep(30);
            await this.c07_intra1();
        }

        [ScriptMethod(427, Lifecycle.Dormant)]
        public async Task mission_highcharity()
        {
            await this.cinematic_snap_to_white();
            Engine.object_hide(holo_generator.Entity, true);
            Engine.switch_bsp(0);
            if (this.g_play_cinematics == true)
            {
                Engine.sound_suppress_ambience_update_on_revert();
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        Engine.print("x08");
                    }

                    await this.x08();
                }

                await this.cinematic_skip_stop();
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        Engine.print("c07_intro");
                    }

                    await this.c07_intro();
                }

                await this.cinematic_skip_stop();
            }

            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), player0_start);
            Engine.object_teleport(await this.player1(), player1_start);
            Engine.wake(new ScriptMethodReference(enc_council_chamber));
            Engine.wake(new ScriptMethodReference(bullshit));
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(new ScriptMethodReference(chapter_job));
            Engine.wake(new ScriptMethodReference(objective_locate_set));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dervish_ledge, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_dervish_ledge));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_corridors_a, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_corridors_a));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_jails, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_jails));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_room_a_tube, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_corridors_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_tower_a_ext, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_tower_a_ext));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_gardens_a, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_gardens_a));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mid_tower, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_mid_tower));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_gardens_b, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_gardens_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_tower_b_ext, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_tower_b_ext));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mausoleum_ext, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_mausoleum_ext));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mausoleum, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_mausoleum));
        }

        [ScriptMethod(428, Lifecycle.Static)]
        public async Task start()
        {
            Engine.wake(new ScriptMethodReference(mission_highcharity));
        }

        [ScriptMethod(429, Lifecycle.Startup)]
        public async Task mission_main()
        {
            Engine.ai_allegiance(player, human);
            Engine.ai_allegiance(human, player);
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(430, Lifecycle.Dormant)]
        public async Task x08_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3859219601U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3859219601U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\fp_needler\\fp_needler", 3803251003U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\fp_needler\\fp_needler", 3803251003U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3860792489U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3861382322U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner\\high_banner", 3861906618U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3863807191U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\holo_generator\\holo_generator", 3864593635U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3865380079U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3865511153U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 5);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\gravemind"), 0, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3867280652U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3867280652U), 1);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\tentacle_capture_driven", 3868722466U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\tentacle_capture_driven", 3868722466U), 1);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\tentacle_capture_masterchief", 3868984614U), 0);
        }

        [ScriptMethod(431, Lifecycle.Dormant)]
        public async Task x08_02_predict()
        {
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3867280652U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3867280652U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\tentacle_capture_masterchief", 3868984614U), 0);
        }

        [ScriptMethod(432, Lifecycle.Dormant)]
        public async Task x08_03_predict()
        {
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3869050151U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3869050151U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\tentacle_capture_driven", 3868722466U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\tentacle_capture_driven", 3868722466U), 1);
            await Engine.sleep(145);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3869050151U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3869050151U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\tentacle_capture_masterchief", 3868984614U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3867280652U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3867280652U), 1);
        }

        [ScriptMethod(433, Lifecycle.Dormant)]
        public async Task x08_04_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(434, Lifecycle.Dormant)]
        public async Task x08_05_predict()
        {
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\floodregret\\floodregret", 3871212872U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\floodregret\\floodregret", 3871212872U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\floodregret\\floodregret", 3871212872U), 2);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\monitor_flood_infected\\monitor_flood_infected", 3872916834U), 0);
        }

        [ScriptMethod(435, Lifecycle.Dormant)]
        public async Task x08_06a_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(436, Lifecycle.Dormant)]
        public async Task x08_06b_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(437, Lifecycle.Dormant)]
        public async Task x08_06c_predict()
        {
            await Engine.sleep(512);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3867280652U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3867280652U), 1);
        }

        [ScriptMethod(438, Lifecycle.Dormant)]
        public async Task x08_07_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(439, Lifecycle.Dormant)]
        public async Task x08_08_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(440, Lifecycle.Dormant)]
        public async Task x08_09_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(441, Lifecycle.Dormant)]
        public async Task x08_10_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(442, Lifecycle.Dormant)]
        public async Task x08_11_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(443, Lifecycle.Dormant)]
        public async Task _07_intro_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3873703278U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3873768815U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3874293111U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3874620796U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3875014018U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3875210629U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3875865999U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3786604605U), 0);
        }

        [ScriptMethod(444, Lifecycle.Dormant)]
        public async Task _07_intro_02_predict()
        {
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3835560744U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3875931536U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 3876980128U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 3877242276U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_planter\\high_planter", 3878421942U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_holo_ped\\high_holo_ped", 3879208386U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 3879273923U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3881043422U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3881043422U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3881043422U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3881043422U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3881043422U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3882681847U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3865511153U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner_small\\high_banner_small", 3885696549U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3885827623U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 3885893160U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3860792489U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            await Engine.sleep(25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 1);
            await Engine.sleep(24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\ambient_life\\seagull\\seagull", 3886089771U), 0);
            await Engine.sleep(21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 3);
            await Engine.sleep(54);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 3879273923U), 0);
            await Engine.sleep(75);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_planter\\high_planter", 3878421942U), 0);
            await Engine.sleep(17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 3885893160U), 0);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3886417456U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
        }

        [ScriptMethod(445, Lifecycle.Dormant)]
        public async Task _07_intro_03_predict()
        {
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3885827623U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3861382322U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3865380079U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner\\high_banner", 3861906618U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3863807191U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\holo_cam\\holo_cam", 3886745141U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3887597122U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            await Engine.sleep(176);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 2);
            await Engine.sleep(166);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 41);
            await Engine.sleep(167);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\holo_cam\\holo_cam", 3886745141U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3887597122U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3861382322U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3865380079U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3885827623U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_holo_ped\\high_holo_ped", 3879208386U), 0);
        }

        [ScriptMethod(446, Lifecycle.Dormant)]
        public async Task _07_intro_04_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            await Engine.sleep(53);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\holo_cam\\holo_cam", 3886745141U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3887597122U), 0);
            await Engine.sleep(37);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3861382322U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3865380079U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3885827623U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_holo_ped\\high_holo_ped", 3879208386U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3885827623U), 0);
            await Engine.sleep(21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 1);
            await Engine.sleep(15);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner\\high_banner", 3861906618U), 0);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 19);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            await Engine.sleep(73);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3863807191U), 0);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner\\high_banner", 3861906618U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3865380079U), 0);
            await Engine.sleep(47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 5);
            await Engine.sleep(11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3862824136U), 0);
            await Engine.sleep(22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 1);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3863807191U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3865511153U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 41);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3887597122U), 0);
            await Engine.sleep(23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 1);
            await Engine.sleep(17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 2);
        }

        [ScriptMethod(447, Lifecycle.Dormant)]
        public async Task _07_intra1_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3861382322U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3859219601U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3859219601U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\fp_needler\\fp_needler", 3803251003U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\fp_needler\\fp_needler", 3803251003U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3822912103U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\holo_generator\\holo_generator", 3864593635U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3893954211U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3893954211U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3822912103U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3866297597U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3887597122U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3894478507U), 0);
            await Engine.sleep(16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3895330488U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3900049152U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3900049152U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3865511153U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901556503U), 2);
            await Engine.sleep(110);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3875931536U), 0);
            await Engine.sleep(33);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            await Engine.sleep(74);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            await Engine.sleep(28);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 60);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901556503U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3873768815U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3805348187U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\flak_cannon\\flak_cannon", 3902015262U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787391049U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\brute_shot\\brute_shot", 3902867243U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3873703278U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3906275167U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3906275167U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3907389296U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3908634499U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3908634499U), 1);
            await Engine.sleep(62);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 4, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 4);
            await Engine.sleep(58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 12);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895789247U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3894478507U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3865511153U), 0);
        }

        [ScriptMethod(448, Lifecycle.Dormant)]
        public async Task _07_intra1_02_predict()
        {
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3909224332U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3886417456U), 0);
            await Engine.sleep(72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 2);
            await Engine.sleep(103);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3895330488U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3860792489U), 0);
            await Engine.sleep(100);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3909224332U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3909224332U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3894478507U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 1);
            await Engine.sleep(71);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 2);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3909224332U), 1);
        }

        [ScriptMethod(449, Lifecycle.Dormant)]
        public async Task _07_intra1_03_predict()
        {
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3895330488U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3873703278U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3906275167U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3906275167U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3907389296U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3908634499U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3908634499U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3860792489U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 3);
            await Engine.sleep(100);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3909224332U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3894478507U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 2);
            await Engine.sleep(51);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3909224332U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3875931536U), 0);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3873703278U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3908634499U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3908634499U), 1);
            await Engine.sleep(16);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3875931536U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3860792489U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            await Engine.sleep(17);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3873310056U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3873703278U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3906275167U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3906275167U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3903391539U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3907389296U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3883599365U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3908634499U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3908634499U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3865511153U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3909224332U), 2);
            await Engine.sleep(27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            await Engine.sleep(18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 2);
            await Engine.sleep(49);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3894478507U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 1);
        }

        [ScriptMethod(450, Lifecycle.Dormant)]
        public async Task _07_intra1_04_predict()
        {
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3886417456U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3860792489U), 0);
            await Engine.sleep(43);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3894675118U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3895264951U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 2);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3887793733U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3892709008U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 1);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3894478507U), 0);
            await Engine.sleep(67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 41);
            await Engine.sleep(147);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883664902U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3894478507U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 0);
            await Engine.sleep(111);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3893298841U), 2);
        }

        [ScriptMethod(451, Lifecycle.Static)]
        public async Task test_halls()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(1);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), halls);
            Engine.fade_in(0F, 0F, 0F, 60);
            await Engine.sleep(10);
            Engine.player_enable_input(true);
        }

        [ScriptMethod(452, Lifecycle.Static)]
        public async Task test_jails()
        {
            Engine.switch_bsp(2);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), jails0_tele);
            Engine.object_teleport(await this.player1(), jails1_tele);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_jails, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_jails));
        }

        [ScriptMethod(453, Lifecycle.Static)]
        public async Task test_corridors_b()
        {
            Engine.switch_bsp(2);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), corrb0_tele);
            Engine.object_teleport(await this.player1(), corrb1_tele);
            await Engine.sleep(90);
            Engine.wake(new ScriptMethodReference(enc_corridors_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_tower_a_ext, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_tower_a_ext));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_gardens_a, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_gardens_a));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mid_tower, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_mid_tower));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_gardens_b, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_gardens_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_tower_b_ext, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_tower_b_ext));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mausoleum_ext, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_mausoleum_ext));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mausoleum, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(enc_mausoleum));
        }

        [ScriptMethod(454, Lifecycle.Static)]
        public async Task test_gardens()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(3);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), garden);
            Engine.fade_in(0F, 0F, 0F, 60);
            await Engine.sleep(10);
            Engine.player_enable_input(true);
        }

        [ScriptMethod(455, Lifecycle.Static)]
        public async Task test_mausoleum()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(4);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), mausoleum);
            Engine.fade_in(0F, 0F, 0F, 60);
            await Engine.sleep(10);
            Engine.player_enable_input(true);
        }
    }
}