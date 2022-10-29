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

        [ScriptMethod(24, Lifecycle.CommandScript)]
        public async Task cs_c07_infection()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_nearest(GetReference<ISpatialPoint>("c07_infection_a"));
            cs_go_to_nearest(GetReference<ISpatialPoint>("c07_infection_b"));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x08_01_predict_stub()
        {
            wake(new ScriptMethodReference(x08_01_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x08_02_predict_stub()
        {
            wake(new ScriptMethodReference(x08_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x08_03_predict_stub()
        {
            wake(new ScriptMethodReference(x08_03_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x08_04_predict_stub()
        {
            wake(new ScriptMethodReference(x08_04_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x08_05_predict_stub()
        {
            wake(new ScriptMethodReference(x08_05_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x08_06a_predict_stub()
        {
            wake(new ScriptMethodReference(x08_06a_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x08_06b_predict_stub()
        {
            wake(new ScriptMethodReference(x08_06b_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x08_06c_predict_stub()
        {
            wake(new ScriptMethodReference(x08_06c_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x08_07_predict_stub()
        {
            wake(new ScriptMethodReference(x08_07_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task x08_08_predict_stub()
        {
            wake(new ScriptMethodReference(x08_08_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task x08_09_predict_stub()
        {
            wake(new ScriptMethodReference(x08_09_predict));
        }

        [ScriptMethod(36, Lifecycle.Static)]
        public async Task x08_10_predict_stub()
        {
            wake(new ScriptMethodReference(x08_10_predict));
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task x08_11_predict_stub()
        {
            wake(new ScriptMethodReference(x08_11_predict));
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task _07_intro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intro_01_predict));
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task _07_intro_02_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intro_02_predict));
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task _07_intro_03_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intro_03_predict));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task _07_intro_04_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intro_04_predict));
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task _07_intra1_01_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intra1_01_predict));
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task _07_intra1_02_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intra1_02_predict));
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task _07_intra1_03_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intra1_03_predict));
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task _07_intra1_04_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intra1_04_predict));
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task x08_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\music\\x08_01_mus", 3835757355U), default(IGameObject), 1F);
            print("x08 score 01 start");
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x08_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_01_fol", 3835822892U), default(IGameObject), 1F);
            print("x08 foley 01 start");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task blurry_vision()
        {
            interpolator_start("blurry_vision", 1F, 0.001F);
            await sleep(30);
            fade_in(0F, 0F, 0F, 30);
            await sleep(45);
            fade_out(0F, 0F, 0F, 30);
            await sleep(45);
            fade_in(0F, 0F, 0F, 20);
            interpolator_start("blurry_vision", 0F, 2F);
            await sleep(30);
            fade_out(0F, 0F, 0F, 20);
            await sleep(20);
            interpolator_start("blurry_vision", 1F, 0.001F);
            await sleep(25);
            fade_in(0F, 0F, 0F, 10);
            interpolator_start("blurry_vision", 0F, 2F);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task x08_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(-90F, 0F, 0.0352941F, 0.278431F, 0.301961F);
            cinematic_lighting_set_secondary_light(-4F, 316F, 0.156863F, 0.109804F, 0F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.25F);
            rasterizer_bloom_override_brightness(0.4F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(gravemind.Entity, true);
            object_uses_cinematic_lighting(tentacle_chief.Entity, true);
            object_uses_cinematic_lighting(tentacle_capture_01.Entity, true);
            render_lights_enable_cinematic_shadow(true, chief.Entity, "head", 0.1F);
        }

        [ScriptMethod(50, Lifecycle.Static)]
        public async Task x08_01_setup()
        {
            object_create_anew(chief);
            object_create_anew(gravemind);
            object_create_anew(tentacle_chief);
            object_create_anew(tentacle_capture_01);
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(gravemind.Entity, true);
            object_cinematic_lod(tentacle_chief.Entity, true);
            object_cinematic_lod(tentacle_capture_01.Entity, true);
            wake(new ScriptMethodReference(x08_score_01));
            wake(new ScriptMethodReference(x08_foley_01));
            wake(new ScriptMethodReference(blurry_vision));
            wake(new ScriptMethodReference(x08_cinematic_light_01));
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task x08_scene_01()
        {
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.x08_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\music\\x08_01_mus", 3835757355U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_01_fol", 3835822892U));
            await sleep(this.prediction_offset);
            await this.x08_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_01", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_01", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_01", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_01", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven01_01", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_02_fol", 3836281651U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task x08_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_02_fol", 3836281651U), default(IGameObject), 1F);
            print("x08 foley 02 start");
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task x08_0020_cor()
        {
            await sleep(40);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0020_cor", 3836347188U), default(IGameObject), 1F);
            cinematic_subtitle("x08_0020_cor", 2F);
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task x08_0030_grv()
        {
            await sleep(134);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0030_grv", 3836412725U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0030_grv", 9F);
        }

        [ScriptMethod(55, Lifecycle.Static)]
        public async Task x08_02_setup()
        {
            wake(new ScriptMethodReference(x08_foley_02));
            wake(new ScriptMethodReference(x08_0020_cor));
            wake(new ScriptMethodReference(x08_0030_grv));
        }

        [ScriptMethod(56, Lifecycle.Static)]
        public async Task x08_scene_02()
        {
            await this.x08_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_02", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_02", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_02", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_02", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven01_02", anchor_x08.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_03_fol", 3836478262U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task x08_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_03_fol", 3836478262U), default(IGameObject), 1F);
            print("x08 foley 03 start");
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task x08_0060_mas()
        {
            await sleep(259);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0060_mas", 3836543799U), chief.Entity, 1F);
            cinematic_subtitle("x08_0060_mas", 3F);
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task x08_03_setup()
        {
            object_create_anew(dervish);
            object_create_anew(tentacle_capture_02);
            object_create_anew(tentacle_capture_03);
            object_create_anew(tentacle_capture_04);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(tentacle_capture_02.Entity, true);
            object_cinematic_lod(tentacle_capture_03.Entity, true);
            object_cinematic_lod(tentacle_capture_04.Entity, true);
            object_uses_cinematic_lighting(dervish.Entity, true);
            render_lights_enable_cinematic_shadow(true, dervish.Entity, "head", 0.2F);
            object_uses_cinematic_lighting(tentacle_capture_02.Entity, true);
            object_uses_cinematic_lighting(tentacle_capture_03.Entity, true);
            object_uses_cinematic_lighting(tentacle_capture_04.Entity, true);
            wake(new ScriptMethodReference(x08_foley_03));
            wake(new ScriptMethodReference(x08_0060_mas));
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task x08_scene_03()
        {
            await this.x08_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_03", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_03", false, anchor_x08.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_03", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_03", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_03", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_03", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven01_03", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_03", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_03", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_03", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_04_fol", 3836805947U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task x08_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_04_fol", 3836805947U), default(IGameObject), 1F);
            print("x08 foley 04 start");
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task x08_0070_der()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0070_der", 3836871484U), dervish.Entity, 1F);
            cinematic_subtitle("x08_0070_der", 2F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task x08_0080_grv()
        {
            await sleep(20);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0080_grv", 3836937021U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0080_grv", 13F);
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task x08_0090_grv()
        {
            await sleep(402);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0090_grv", 3837002558U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0090_grv", 10F);
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task x08_0100_der()
        {
            await sleep(683);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0100_der", 3837068095U), dervish.Entity, 1F);
            cinematic_subtitle("x08_0100_der", 6F);
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task x08_04_setup()
        {
            wake(new ScriptMethodReference(x08_foley_04));
            wake(new ScriptMethodReference(x08_0070_der));
            wake(new ScriptMethodReference(x08_0080_grv));
            wake(new ScriptMethodReference(x08_0090_grv));
            wake(new ScriptMethodReference(x08_0100_der));
        }

        [ScriptMethod(67, Lifecycle.Static)]
        public async Task x08_scene_04()
        {
            await this.x08_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_04", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_04", false, anchor_x08.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_04", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_04", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_04", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_04", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven01_04", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_04", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_04", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_04", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_05_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_05_fol", 3837133632U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x08_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_05_fol", 3837133632U), default(IGameObject), 1F);
            print("x08 foley 05 start");
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x08_0110_grv()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0110_grv", 3837199169U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0110_grv", 3F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task x08_0120_grv()
        {
            await sleep(86);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0120_grv", 3837264706U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0120_grv", 7F);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task x08_0130_grv()
        {
            await sleep(324);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0130_grv", 3837330243U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0130_grv", 6F);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task x08_05_setup()
        {
            object_create_anew(regret);
            object_create_anew(_2401);
            object_create_anew(tentacle_capture_05);
            object_cinematic_lod(regret.Entity, true);
            object_cinematic_lod(_2401.Entity, true);
            object_cinematic_lod(tentacle_capture_05.Entity, true);
            object_uses_cinematic_lighting(regret.Entity, true);
            render_lights_enable_cinematic_shadow(true, regret.Entity, "head", 0.1F);
            object_uses_cinematic_lighting(_2401.Entity, true);
            object_uses_cinematic_lighting(tentacle_capture_05.Entity, true);
            wake(new ScriptMethodReference(x08_foley_05));
            wake(new ScriptMethodReference(x08_0110_grv));
            wake(new ScriptMethodReference(x08_0120_grv));
            wake(new ScriptMethodReference(x08_0130_grv));
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task x08_scene_05()
        {
            await this.x08_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_05", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_05", false, anchor_x08.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_05", false, anchor_x08.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3837395780U), "regret_05", false, anchor_x08.Entity);
            custom_animation_relative(_2401.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3837526854U), "tangent_05", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_05", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_05", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_05", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven01_05", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_05", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_05", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_05", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven05_05", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_06a_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06a_fol", 3837592391U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task x08_foley_06a()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06a_fol", 3837592391U), default(IGameObject), 1F);
            print("x08 foley 06a start");
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x08_0140_pnt()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0140_pnt", 3837657928U), _2401.Entity, 1F);
            cinematic_subtitle("x08_0140_pnt", 7F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x08_0150_por()
        {
            await sleep(198);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0150_por", 3837723465U), regret.Entity, 1F);
            cinematic_subtitle("x08_0150_por", 7F);
        }

        [ScriptMethod(77, Lifecycle.Static)]
        public async Task x08_06a_setup()
        {
            object_destroy(gravemind.Entity);
            wake(new ScriptMethodReference(x08_foley_06a));
            wake(new ScriptMethodReference(x08_0140_pnt));
            wake(new ScriptMethodReference(x08_0150_por));
        }

        [ScriptMethod(78, Lifecycle.Static)]
        public async Task x08_scene_06a()
        {
            await this.x08_06a_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_06a", default(IUnit), anchor_flag_x08);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_06a", false, anchor_x08.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3837395780U), "regret_06a", false, anchor_x08.Entity);
            custom_animation_relative(_2401.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3837526854U), "tangent_06a", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_06a", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_06a", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_06a", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_06a", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven05_06a", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_06b_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06b_fol", 3837789002U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task x08_foley_06b()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06b_fol", 3837789002U), default(IGameObject), 1F);
            print("x08 foley 06b start");
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task x08_0180_pnt()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0180_pnt", 3837854539U), _2401.Entity, 1F);
            cinematic_subtitle("x08_0180_pnt", 3.5F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x08_0190_pnt()
        {
            await sleep(105);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0190_pnt", 3837920076U), _2401.Entity, 1F);
            cinematic_subtitle("x08_0190_pnt", 5F);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x08_0200_por()
        {
            await sleep(268);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0200_por", 3837985613U), regret.Entity, 1F);
            cinematic_subtitle("x08_0200_por", 2F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x08_0210_por()
        {
            await sleep(343);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0210_por", 3838051150U), regret.Entity, 1F);
            cinematic_subtitle("x08_0210_por", 4F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x08_0220_pnt()
        {
            await sleep(453);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0220_pnt", 3838116687U), _2401.Entity, 1F);
            cinematic_subtitle("x08_0220_pnt", 8.5F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x08_0230_por()
        {
            await sleep(714);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0230_por", 3838182224U), regret.Entity, 1F);
            cinematic_subtitle("x08_0230_por", 12.5F);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task x08_06b_setup()
        {
            wake(new ScriptMethodReference(x08_foley_06b));
            wake(new ScriptMethodReference(x08_0180_pnt));
            wake(new ScriptMethodReference(x08_0190_pnt));
            wake(new ScriptMethodReference(x08_0200_por));
            wake(new ScriptMethodReference(x08_0210_por));
            wake(new ScriptMethodReference(x08_0220_pnt));
            wake(new ScriptMethodReference(x08_0230_por));
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task x08_scene_06b()
        {
            await this.x08_06b_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_06b", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_06b", false, anchor_x08.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3837395780U), "regret_06b", false, anchor_x08.Entity);
            custom_animation_relative(_2401.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3837526854U), "tangent_06b", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_06b", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven01_06b", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven05_06b", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_06c_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06c_fol", 3838247761U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x08_foley_06c()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_06c_fol", 3838247761U), default(IGameObject), 1F);
            print("x08 foley 06c start");
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x08_0240_pnt()
        {
            await sleep(351);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0240_pnt", 3838313298U), _2401.Entity, 1F);
            cinematic_subtitle("x08_0240_pnt", 5.5F);
        }

        [ScriptMethod(90, Lifecycle.Static)]
        public async Task x08_06c_setup()
        {
            wake(new ScriptMethodReference(x08_foley_06c));
            wake(new ScriptMethodReference(x08_0240_pnt));
        }

        [ScriptMethod(91, Lifecycle.Static)]
        public async Task x08_scene_06c()
        {
            await this.x08_06c_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_06c", default(IUnit), anchor_flag_x08);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_06c", false, anchor_x08.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3837395780U), "regret_06c", false, anchor_x08.Entity);
            custom_animation_relative(_2401.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3837526854U), "tangent_06c", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_06c", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_06c", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_06c", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_06c", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven05_06c", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - 10));
            object_create_anew(gravemind);
            object_uses_cinematic_lighting(gravemind.Entity, true);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_07_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_07_fol", 3838378835U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x08_foley_07()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_07_fol", 3838378835U), default(IGameObject), 1F);
            print("x08 foley 07 start");
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x08_0250_grv()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0250_grv", 3838444372U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0250_grv", 5F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task x08_0260_grv()
        {
            await sleep(152);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0260_grv", 3838509909U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0260_grv", 6F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task x08_0251_por()
        {
            await sleep(270);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0251_por", 3838575446U), regret.Entity, 1F);
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task x08_07_setup()
        {
            wake(new ScriptMethodReference(x08_foley_07));
            wake(new ScriptMethodReference(x08_0250_grv));
            wake(new ScriptMethodReference(x08_0260_grv));
            wake(new ScriptMethodReference(x08_0251_por));
        }

        [ScriptMethod(97, Lifecycle.Static)]
        public async Task x08_scene_07()
        {
            await this.x08_07_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_07", default(IUnit), anchor_flag_x08);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\floodregret\\x08\\x08", 3837395780U), "regret_07", false, anchor_x08.Entity);
            custom_animation_relative(_2401.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\monitor_flood_infected\\x08\\x08", 3837526854U), "tangent_07", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_07", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven05_07", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_08_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_08_fol", 3838640983U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x08_foley_08()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_08_fol", 3838640983U), default(IGameObject), 1F);
            print("x08 foley 08 start");
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x08_0270_grv()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0270_grv", 3838706520U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0270_grv", 12F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x08_0280_grv()
        {
            await sleep(351);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0280_grv", 3838772057U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0280_grv", 15F);
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x08_08_setup()
        {
            object_destroy(tentacle_capture_05.Entity);
            wake(new ScriptMethodReference(x08_foley_08));
            wake(new ScriptMethodReference(x08_0270_grv));
            wake(new ScriptMethodReference(x08_0280_grv));
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x08_scene_08()
        {
            await this.x08_08_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_08", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_08", false, anchor_x08.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_08", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_08", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_08", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_08", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_08", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_08", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_08", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_09_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_09_fol", 3838837594U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x08_foley_09()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_09_fol", 3838837594U), default(IGameObject), 1F);
            print("x08 foley 09 start");
        }

        [ScriptMethod(104, Lifecycle.Static)]
        public async Task x08_scene_09()
        {
            wake(new ScriptMethodReference(x08_foley_09));
            object_destroy(regret.Entity);
            object_destroy(_2401.Entity);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_09", default(IUnit), anchor_flag_x08);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_09", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_09", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_09", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_09", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_09", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_10_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_10_fol", 3838903131U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x08_foley_10()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_10_fol", 3838903131U), default(IGameObject), 1F);
            print("x08 foley 10 start");
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task x08_0340_mas()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0340_mas", 3838968668U), chief.Entity, 1F);
            cinematic_subtitle("x08_0340_mas", 5F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task x08_0350_der()
        {
            await sleep(147);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0350_der", 3839034205U), dervish.Entity, 1F);
            cinematic_subtitle("x08_0350_der", 6F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task x08_0360_grv()
        {
            await sleep(323);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0360_grv", 3839099742U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0360_grv", 8F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task x08_0370_grv()
        {
            await sleep(561);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0370_grv", 3839165279U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0370_grv", 9F);
        }

        [ScriptMethod(110, Lifecycle.Static)]
        public async Task x08_10_setup()
        {
            wake(new ScriptMethodReference(x08_foley_10));
            wake(new ScriptMethodReference(x08_0340_mas));
            wake(new ScriptMethodReference(x08_0350_der));
            wake(new ScriptMethodReference(x08_0360_grv));
            wake(new ScriptMethodReference(x08_0370_grv));
        }

        [ScriptMethod(111, Lifecycle.Static)]
        public async Task x08_scene_10()
        {
            await this.x08_10_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_10", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_10", false, anchor_x08.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_10", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_10", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_10", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_10", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven01_10", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_10", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_10", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_10", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x08_11_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\music\\x08_11_mus", 3839230816U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_11_fol", 3839296353U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x08_foley_11()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\foley\\x08_11_fol", 3839296353U), default(IGameObject), 1F);
            print("x08 foley 11 start");
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task x08_score_11()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\x08\\music\\x08_11_mus", 3839230816U), default(IGameObject), 1F);
            print("x08 score 11 start");
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x08_0380_grv()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0380_grv", 3839361890U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0380_grv", 7F);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task x08_0390_grv()
        {
            await sleep(207);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\x08_0390_grv", 3839427427U), gravemind.Entity, 1F);
            cinematic_subtitle("x08_0390_grv", 8.5F);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task x08_teleport_build()
        {
            await sleep(470);
            print("effect - teleport build");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_01.Entity, "teleport06");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_02.Entity, "teleport06");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_03.Entity, "teleport06");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_04.Entity, "teleport06");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_01.Entity, "teleport05");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_02.Entity, "teleport05");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_03.Entity, "teleport05");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_04.Entity, "teleport05");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_01.Entity, "teleport04");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_02.Entity, "teleport04");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_03.Entity, "teleport04");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_04.Entity, "teleport04");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_01.Entity, "teleport03");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_02.Entity, "teleport03");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_03.Entity, "teleport03");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_04.Entity, "teleport03");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_01.Entity, "teleport02");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_02.Entity, "teleport02");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_03.Entity, "teleport02");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_04.Entity, "teleport02");
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_01.Entity, "teleport01");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_02.Entity, "teleport01");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_03.Entity, "teleport01");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\gravemind\\tentacle_teleport", 3839492964U), tentacle_capture_04.Entity, "teleport01");
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task x08_teleport_characters()
        {
            await sleep(470);
            print("effect - teleport dervish");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\regret_teleport", 3839886186U), dervish.Entity, "body");
            await sleep(5);
            print("effect - teleport chief");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\regret_teleport", 3839886186U), chief.Entity, "body");
        }

        [ScriptMethod(118, Lifecycle.Static)]
        public async Task x08_11_setup()
        {
            wake(new ScriptMethodReference(x08_score_11));
            wake(new ScriptMethodReference(x08_foley_11));
            wake(new ScriptMethodReference(x08_0380_grv));
            wake(new ScriptMethodReference(x08_0390_grv));
            wake(new ScriptMethodReference(x08_teleport_build));
            wake(new ScriptMethodReference(x08_teleport_characters));
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x08_11_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(dervish.Entity);
            object_destroy(gravemind.Entity);
            object_destroy(tentacle_chief.Entity);
            object_destroy(tentacle_arbiter.Entity);
            object_destroy_containing("tentacle_capture");
        }

        [ScriptMethod(120, Lifecycle.Static)]
        public async Task x08_scene_11()
        {
            await this.x08_11_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x08\\x08", 3835888429U), "x08_11", default(IUnit), anchor_flag_x08);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x08\\x08", 3835953966U), "chief_11", false, anchor_x08.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x08\\x08", 3836609336U), "dervish_11", false, anchor_x08.Entity);
            custom_animation_relative(gravemind.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\x08\\x08", 3836019503U), "gm_mouth_11", false, anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\x08\\x08", 3836150577U), "tc_mc_11", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_arbiter.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_arbiter\\x08\\x08", 3836740410U), "tc_arb_11", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven01_11", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven02_11", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven03_11", anchor_x08.Entity);
            scenery_animation_start_relative(tentacle_capture_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\x08\\x08", 3836216114U), "tc_driven04_11", anchor_x08.Entity);
            await sleep((short)((float)camera_time() - 5));
            fade_out(0F, 0F, 0F, 5);
            await sleep(5);
            wake(new ScriptMethodReference(x08_11_cleanup));
            await sleep(30);
        }

        [ScriptMethod(121, Lifecycle.Static)]
        public async Task x08()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("gravemind"));
            await sleep(1);
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
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task c07_intro_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(18F, 56F, 0.227451F, 0.129412F, 0.223529F);
            cinematic_lighting_set_secondary_light(-26F, 134F, 0.196078F, 0.188235F, 0.286275F);
            cinematic_lighting_set_ambient_light(0.180392F, 0.176471F, 0.207843F);
            object_uses_cinematic_lighting(delta_halo.Entity, true);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task c07_intro_01_problem_actors()
        {
            print("problem actors");
            object_create_anew(delta_halo);
            object_create_anew(matte_substance);
            object_create_anew(matte_high_charity);
            object_create_anew_containing("intro_fleet");
            object_create_anew_containing("stardust");
        }

        [ScriptMethod(124, Lifecycle.Static)]
        public async Task c07_intro_02_problem_actors()
        {
            print("problem actors");
            object_create_anew(brute_intro_01);
            object_create_anew(brute_intro_02);
            object_create_anew(brute_intro_03);
            object_create_anew(brute_intro_04);
            object_create_anew(brute_05);
            object_create_anew(brute_06);
            object_create_anew(grunt_01);
            object_create_anew(grunt_02);
            object_create_anew(grunt_03);
            object_create_anew(grunt_04);
            object_create_anew(grunt_05);
            object_create_anew(jackal_01);
            object_create_anew(jackal_02);
            object_create_anew_containing("intro_pike");
            object_create_anew_containing("intro_crowd");
            object_cinematic_lod(brute_intro_01.Entity, true);
            object_cinematic_lod(brute_intro_02.Entity, true);
            object_cinematic_lod(brute_intro_03.Entity, true);
            object_cinematic_lod(brute_intro_04.Entity, true);
            object_cinematic_lod(brute_05.Entity, true);
            object_cinematic_lod(brute_06.Entity, true);
            object_cinematic_lod(grunt_01.Entity, true);
            object_cinematic_lod(grunt_02.Entity, true);
            object_cinematic_lod(grunt_03.Entity, true);
            object_cinematic_lod(grunt_04.Entity, true);
            object_cinematic_lod(grunt_05.Entity, true);
            object_cinematic_lod(jackal_01.Entity, true);
            object_cinematic_lod(jackal_02.Entity, true);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task c07_intro_01_cleanup()
        {
            object_destroy(delta_halo.Entity);
            object_destroy(matte_substance.Entity);
            object_destroy(matte_high_charity.Entity);
            object_destroy_containing("fleet");
            object_destroy_containing("stardust");
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task c07_intro_scene_01()
        {
            fade_out(0F, 0F, 0F, 0);
            wake(new ScriptMethodReference(c07_intro_cinematic_light_01));
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._07_intro_01_predict_stub();
            wake(new ScriptMethodReference(c07_intro_01_problem_actors));
            await sleep(this.prediction_offset);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intro\\07_intro", 3840541556U), "07_intro_01", default(IUnit), anchor_flag_intro_a);
            scenery_animation_start_relative(delta_halo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\07_intro\\07_intro", 3840607093U), "halo_01", anchor_intro_a.Entity);
            scenery_animation_start_relative(matte_high_charity.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\07_intro\\07_intro", 3840672630U), "high_charity_exterior_01", anchor_intro_a.Entity);
            scenery_animation_start_relative(matte_substance.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\07_intro\\07_intro", 3840738167U), "substance_01", anchor_intro_a.Entity);
            scenery_animation_start_relative(stardust_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\07_intro\\07_intro", 3840803704U), "stardust01_01", anchor_intro_a.Entity);
            scenery_animation_start_relative(stardust_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\07_intro\\07_intro", 3840803704U), "stardust02_01", anchor_intro_a.Entity);
            await sleep(15);
            fade_in(0F, 0F, 0F, 60);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intro_02_predict_stub();
            await this.c07_intro_02_problem_actors();
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_02_fol", 3840869241U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c07_intro_01_cleanup();
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task c07_intro_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_02_fol", 3840869241U), default(IGameObject), 1F);
            print("c07_intro foley 02 start");
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task c07_1010_pot()
        {
            await sleep(200);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1010_pot", 3840934778U), default(IGameObject), 1F);
            cinematic_subtitle("c07_1010_pot", 3F);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task c07_intro_dof_02()
        {
            time_code_reset();
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0F, 1F, 1F, 0F);
            print("rack focus");
            await sleep(83);
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 1F, 0.5F, 1F, 0F, 0.5F);
            print("rack focus");
            await sleep(56);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task lightmap_shadows_on()
        {
            await sleep(141);
            print("enable lightmap shadows");
            cinematic_lightmap_shadow_enable();
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task c07_intro_cinematic_light_02()
        {
            cinematic_lighting_set_primary_light(25F, 190F, 0.470588F, 0.368627F, 0.541176F);
            cinematic_lighting_set_secondary_light(-36F, 0F, 0.160784F, 0.176471F, 0.345098F);
            cinematic_lighting_set_ambient_light(0.105882F, 0.0941177F, 0.0784314F);
            object_uses_cinematic_lighting(brute_intro_01.Entity, true);
            object_uses_cinematic_lighting(brute_intro_02.Entity, true);
            object_uses_cinematic_lighting(brute_intro_03.Entity, true);
            object_uses_cinematic_lighting(brute_intro_04.Entity, true);
            object_uses_cinematic_lighting(brute_05.Entity, true);
            object_uses_cinematic_lighting(brute_06.Entity, true);
            object_uses_cinematic_lighting(grunt_01.Entity, true);
            object_uses_cinematic_lighting(grunt_02.Entity, true);
            object_uses_cinematic_lighting(grunt_03.Entity, true);
            object_uses_cinematic_lighting(grunt_04.Entity, true);
            object_uses_cinematic_lighting(grunt_05.Entity, true);
            object_uses_cinematic_lighting(jackal_01.Entity, true);
            object_uses_cinematic_lighting(jackal_02.Entity, true);
            object_uses_cinematic_lighting(intro_pike_01.Entity, true);
            object_uses_cinematic_lighting(intro_pike_02.Entity, true);
            object_uses_cinematic_lighting(intro_pike_03.Entity, true);
            object_uses_cinematic_lighting(intro_pike_04.Entity, true);
            object_uses_cinematic_lighting(intro_pike_05.Entity, true);
            object_uses_cinematic_lighting(intro_pike_06.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_01.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_02.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_03.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_04.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_05.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_06.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_07.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_08.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_09.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_10.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_11.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_12.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_13.Entity, true);
            object_uses_cinematic_lighting(intro_crowd_14.Entity, true);
        }

        [ScriptMethod(132, Lifecycle.Static)]
        public async Task c07_intro_03_problem_actors()
        {
            print("problem actors");
            object_create_anew(truth_intro);
            object_create_anew(mercy_intro);
            object_create_anew(throne_truth_intro);
            object_create_anew(throne_mercy_intro);
            object_create_anew(index_intro);
            object_cinematic_lod(truth_intro.Entity, true);
            object_cinematic_lod(mercy_intro.Entity, true);
            object_cinematic_lod(throne_truth_intro.Entity, true);
            object_cinematic_lod(throne_mercy_intro.Entity, true);
            object_cinematic_lod(index_intro.Entity, true);
            objects_attach(truth_intro.Entity, "driver", throne_truth_intro.Entity, "driver_cinematic");
            objects_attach(mercy_intro.Entity, "driver", throne_mercy_intro.Entity, "driver_cinematic");
        }

        [ScriptMethod(133, Lifecycle.Static)]
        public async Task c07_intro_02_setup()
        {
            wake(new ScriptMethodReference(c07_intro_foley_02));
            wake(new ScriptMethodReference(c07_1010_pot));
            wake(new ScriptMethodReference(lightmap_shadows_on));
            wake(new ScriptMethodReference(c07_intro_dof_02));
            wake(new ScriptMethodReference(c07_intro_cinematic_light_02));
            if (GameDifficulty.Legendary() == game_difficulty_get_real())
            {
                object_create_anew(grunt_card);
            }
        }

        [ScriptMethod(134, Lifecycle.Static)]
        public async Task c07_intro_02_cleanup()
        {
            object_destroy(grunt_03.Entity);
            object_destroy(grunt_04.Entity);
            object_destroy(grunt_05.Entity);
            object_destroy(jackal_01.Entity);
            object_destroy(jackal_02.Entity);
            object_destroy(grunt_card.Entity);
            object_destroy_containing("intro_crowd");
        }

        [ScriptMethod(135, Lifecycle.Static)]
        public async Task c07_intro_scene_02()
        {
            await this.c07_intro_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intro\\07_intro", 3840541556U), "07_intro_02", default(IUnit), anchor_flag_intro_c);
            custom_animation_relative(brute_intro_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute01_02", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute02_02", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute03_02", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute04_02", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute05_02", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_06.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute06_02", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt01_02", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt02_02", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt03_02", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt04_02", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt05_02", false, anchor_intro_c.Entity);
            custom_animation_relative(jackal_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\07_intro\\07_intro", 3841196926U), "jackal01_02", false, anchor_intro_c.Entity);
            custom_animation_relative(jackal_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\07_intro\\07_intro", 3841196926U), "jackal02_02", false, anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike01_02", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike02_02", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_03.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike03_02", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_04.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike04_02", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_05.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike05_02", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_06.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike06_02", anchor_intro_c.Entity);
            await sleep(5);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intro_03_predict_stub();
            await this.c07_intro_03_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_03_fol", 3841328000U));
            await sleep((short)camera_time());
            await this.c07_intro_02_cleanup();
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task c07_intro_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_03_fol", 3841328000U), default(IGameObject), 1F);
            print("c07_intro foley 03 start");
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task c07_1020_pot()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1020_pot", 3841393537U), default(IGameObject), 1F);
            cinematic_subtitle("c07_1020_pot", 6F);
            unit_set_emotional_state(truth_intro.Entity, "pensive", 0.25F, 0);
            print("truth - pensive .25 0");
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task c07_1030_pot()
        {
            await sleep(181);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1030_pot", 3841459074U), truth_intro.Entity, 1F);
            cinematic_subtitle("c07_1030_pot", 9F);
            await sleep(180);
            unit_set_emotional_state(truth_intro.Entity, "happy", 0.25F, 90);
            print("truth - happy .25 90");
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task c07_1040_pot()
        {
            await sleep(451);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1040_pot", 3841524611U), truth_intro.Entity, 1F);
            cinematic_subtitle("c07_1040_pot", 6F);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task c07_intro_03_fov()
        {
            time_code_reset();
            await sleep(178);
            print("change fov");
            camera_set_field_of_view(40F, 0);
            time_code_reset();
            await sleep(166);
            print("change fov");
            camera_set_field_of_view(50F, 0);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task c07_intro_cinematic_light_03()
        {
            cinematic_lighting_set_primary_light(44F, 166F, 0.317647F, 0.282353F, 0.376471F);
            cinematic_lighting_set_secondary_light(-69F, 348F, 0.290196F, 0.227451F, 0.537255F);
            cinematic_lighting_set_ambient_light(0.054902F, 0.0470588F, 0.0392157F);
            object_uses_cinematic_lighting(truth_intro.Entity, true);
            object_uses_cinematic_lighting(mercy_intro.Entity, true);
            object_uses_cinematic_lighting(throne_truth_intro.Entity, true);
            object_uses_cinematic_lighting(throne_mercy_intro.Entity, true);
            object_uses_cinematic_lighting(index_intro.Entity, true);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task texture_camera_start()
        {
            time_code_reset();
            await sleep(178);
            print("texture camera start");
            texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            object_hide(mercy.Entity, true);
            object_hide(throne_mercy.Entity, true);
            object_hide(brute_intro_01.Entity, true);
            object_hide(brute_intro_02.Entity, true);
            object_hide(brute_intro_03.Entity, true);
            object_hide(brute_intro_04.Entity, true);
            object_hide(brute_05.Entity, true);
            object_hide(brute_06.Entity, true);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task texture_camera_stop()
        {
            await sleep(344);
            print("texture camera stop");
            texture_camera_off();
            object_hide(mercy.Entity, false);
            object_hide(throne_mercy.Entity, false);
            object_hide(brute_intro_01.Entity, false);
            object_hide(brute_intro_02.Entity, false);
            object_hide(brute_intro_03.Entity, false);
            object_hide(brute_intro_04.Entity, false);
            object_hide(brute_05.Entity, false);
            object_hide(brute_06.Entity, false);
        }

        [ScriptMethod(144, Lifecycle.Static)]
        public async Task c07_intro_03_setup()
        {
            cinematic_lightmap_shadow_disable();
            object_create_anew(chief_needler);
            object_create_anew(texture_camera);
            object_create_anew(holo_cam);
            object_cinematic_lod(chief_needler.Entity, true);
            object_cinematic_lod(holo_cam.Entity, true);
            objects_attach(grunt_02.Entity, "right_hand", chief_needler.Entity, "");
            wake(new ScriptMethodReference(c07_intro_foley_03));
            wake(new ScriptMethodReference(c07_1020_pot));
            wake(new ScriptMethodReference(c07_1030_pot));
            wake(new ScriptMethodReference(c07_1040_pot));
            wake(new ScriptMethodReference(c07_intro_03_fov));
            wake(new ScriptMethodReference(texture_camera_start));
            wake(new ScriptMethodReference(texture_camera_stop));
            wake(new ScriptMethodReference(c07_intro_cinematic_light_03));
        }

        [ScriptMethod(145, Lifecycle.Static)]
        public async Task c07_intro_03_cleanup()
        {
            object_destroy(brute_intro_03.Entity);
            object_destroy(brute_intro_04.Entity);
            object_destroy(brute_05.Entity);
            object_destroy(brute_06.Entity);
        }

        [ScriptMethod(146, Lifecycle.Static)]
        public async Task c07_intro_scene_03()
        {
            await this.c07_intro_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intro\\07_intro", 3840541556U), "07_intro_03", default(IUnit), anchor_flag_intro_c);
            custom_animation_relative(truth_intro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intro\\07_intro", 3841590148U), "truth_03", false, anchor_intro_c.Entity);
            custom_animation_relative(mercy_intro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intro\\07_intro", 3841590148U), "mercy_03", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute01_03", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute02_03", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute03_03", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute04_03", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute05_03", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_06.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute06_03", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt01_03", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt02_03", false, anchor_intro_c.Entity);
            scenery_animation_start_relative(texture_camera.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\07_intro\\07_intro", 3841721222U), "tex_camera_03", anchor_intro_c.Entity);
            scenery_animation_start_relative(holo_cam.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\holo_cam\\07_intro\\07_intro", 3841786759U), "holo_cam_03", anchor_intro_c.Entity);
            scenery_animation_start_relative(index_intro.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\07_intro\\07_intro", 3841852296U), "index_03", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike01_03", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike02_03", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_03.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike03_03", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_04.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike04_03", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_05.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike05_03", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_06.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike06_03", anchor_intro_c.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intro_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_04_fol", 3841917833U));
            await sleep((short)camera_time());
            await this.c07_intro_03_cleanup();
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task c07_intro_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intro\\foley\\c07_intro_04_fol", 3841917833U), default(IGameObject), 1F);
            print("c07_intro foley 04 start");
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task c07_1050_pot()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1050_pot", 3841983370U), truth_intro.Entity, 1F);
            cinematic_subtitle("c07_1050_pot", 5F);
            unit_set_emotional_state(truth_intro.Entity, "happy", 0.25F, 0);
            unit_set_emotional_state(truth_intro.Entity, "happy", 0.5F, 60);
            print("truth - happy .5 60");
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task c07_1060_mas()
        {
            await sleep(217);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1060_mas", 3842048907U), chief.Entity, 1F);
            cinematic_subtitle("c07_1060_mas", 1F);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task c07_1070_crz()
        {
            await sleep(236);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1070_crz", 3842114444U), grunt_01.Entity, 1F);
            cinematic_subtitle("c07_1070_crz", 2F);
            unit_set_emotional_state(truth_intro.Entity, "shocked", 0.75F, 0);
            print("truth - shocked .75 0");
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task c07_1080_pot()
        {
            await sleep(412);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_1080_pot", 3842179981U), truth_intro.Entity, 1F);
            cinematic_subtitle("c07_1080_pot", 2F);
            await sleep(30);
            unit_set_emotional_state(truth_intro.Entity, "arrogant", 0.5F, 30);
            print("truth - arrogant .5 30");
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task effect_chief_teleport()
        {
            print("effect - teleport");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\cinematic_teleport", 3842245518U), teleport.Entity, "marker");
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task intro_chief_arrival()
        {
            await sleep(142);
            print("chief arrival");
            custom_animation_relative(chief_intro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intro\\07_intro", 3842376592U), "chief_04", false, anchor_intro_c.Entity);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task needler_attach()
        {
            time_code_reset();
            await sleep(230);
            objects_detach(grunt_02.Entity, chief_needler.Entity);
            print("needler detach");
            await sleep(80);
            objects_attach(chief_intro.Entity, "right_hand", chief_needler.Entity, "");
            print("needler attach");
        }

        [ScriptMethod(155, Lifecycle.Static)]
        public async Task c07_intro_04_setup()
        {
            object_create_anew(teleport);
            object_create_anew(chief_intro);
            object_cinematic_lod(chief_intro.Entity, true);
            object_uses_cinematic_lighting(chief_intro.Entity, true);
            render_lights_enable_cinematic_shadow(true, chief_intro.Entity, "head", 0.4F);
            wake(new ScriptMethodReference(c07_intro_foley_04));
            wake(new ScriptMethodReference(c07_1050_pot));
            wake(new ScriptMethodReference(c07_1060_mas));
            wake(new ScriptMethodReference(c07_1070_crz));
            wake(new ScriptMethodReference(c07_1080_pot));
            wake(new ScriptMethodReference(intro_chief_arrival));
            wake(new ScriptMethodReference(needler_attach));
            wake(new ScriptMethodReference(effect_chief_teleport));
        }

        [ScriptMethod(156, Lifecycle.Static)]
        public async Task c07_intro_04_cleanup()
        {
            object_destroy(chief_intro.Entity);
            object_destroy_containing("truth");
            object_destroy_containing("mercy");
            object_destroy(brute_intro_01.Entity);
            object_destroy(brute_intro_02.Entity);
            object_destroy(grunt_01.Entity);
            object_destroy(grunt_02.Entity);
            object_destroy(index_intro.Entity);
            object_destroy(holo_cam.Entity);
            object_destroy(teleport.Entity);
            object_destroy_containing("intro_pike");
            object_destroy(chief_needler.Entity);
        }

        [ScriptMethod(157, Lifecycle.Static)]
        public async Task c07_intro_scene_04()
        {
            await this.c07_intro_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intro\\07_intro", 3840541556U), "07_intro_04", default(IUnit), anchor_flag_intro_c);
            custom_animation_relative(truth_intro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intro\\07_intro", 3841590148U), "truth_04", false, anchor_intro_c.Entity);
            custom_animation_relative(mercy_intro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intro\\07_intro", 3841590148U), "mercy_04", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute01_04", false, anchor_intro_c.Entity);
            custom_animation_relative(brute_intro_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intro\\07_intro", 3841000315U), "brute02_04", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt01_04", false, anchor_intro_c.Entity);
            custom_animation_relative(grunt_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\07_intro\\07_intro", 3841131389U), "grunt02_04", false, anchor_intro_c.Entity);
            scenery_animation_start_relative(index_intro.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\07_intro\\07_intro", 3841852296U), "index_04", anchor_intro_c.Entity);
            scenery_animation_start_relative(texture_camera.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\07_intro\\07_intro", 3841721222U), "tex_camera_04", anchor_intro_c.Entity);
            scenery_animation_start_relative(holo_cam.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\holo_cam\\07_intro\\07_intro", 3841786759U), "holo_cam_04", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike01_04", anchor_intro_c.Entity);
            scenery_animation_start_relative(intro_pike_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intro\\07_intro", 3841262463U), "pike02_04", anchor_intro_c.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c07_intro_04_cleanup();
        }

        [ScriptMethod(158, Lifecycle.Static)]
        public async Task c07_intro()
        {
            texture_cache_flush();
            geometry_cache_flush();
            sound_class_set_gain("amb", 0F, 15);
            switch_bsp_by_name(GetReference<IBsp>("high_0"));
            await sleep(1);
            await this.c07_intro_scene_01();
            sound_class_set_gain("amb", 1F, 15);
            await this.c07_intro_scene_02();
            await this.c07_intro_scene_03();
            await this.c07_intro_scene_04();
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task c07_intra1_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\music\\c07_intra1_01_mus", 3842442129U), default(IGameObject), 1F);
            print("c07_intra1 score 01 start");
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_01_fol", 3842507666U), default(IGameObject), 1F);
            print("c07_intra1 foley 01 start");
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task c07_2010_tar()
        {
            await sleep(128);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2010_tar", 3842573203U), tartarus.Entity, 1F);
            cinematic_subtitle("c07_2010_tar", 2F);
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task c07_intra1_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(23F, 74F, 0.258824F, 0.270588F, 0.368627F);
            cinematic_lighting_set_secondary_light(-40F, 276F, 0.407843F, 0.345098F, 0.317647F);
            cinematic_lighting_set_ambient_light(0.0431373F, 0.0470588F, 0.0666667F);
            object_uses_cinematic_lighting(truth.Entity, true);
            object_uses_cinematic_lighting(mercy.Entity, true);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(monitor.Entity, true);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(brute_03.Entity, true);
            object_uses_cinematic_lighting(brute_04.Entity, true);
            object_uses_cinematic_lighting(throne_truth.Entity, true);
            object_uses_cinematic_lighting(throne_mercy.Entity, true);
            object_uses_cinematic_lighting(phantom_01.Entity, true);
            object_uses_cinematic_lighting(phantom_02.Entity, true);
            object_uses_cinematic_lighting(phantom_03.Entity, true);
            object_uses_cinematic_lighting(hammer.Entity, true);
            object_uses_cinematic_lighting(intra_pike_01.Entity, true);
            object_uses_cinematic_lighting(intra_pike_02.Entity, true);
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task hide_pikes()
        {
            time_code_reset();
            await sleep(300);
            print("hide pikes");
            object_hide(intra_pike_01.Entity, true);
            object_hide(intra_pike_02.Entity, true);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task show_pikes()
        {
            await sleep(400);
            print("show pikes");
            object_hide(intra_pike_01.Entity, false);
            object_hide(intra_pike_02.Entity, false);
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task johnson_emotion()
        {
            unit_set_emotional_state(johnson.Entity, "angry", 0.25F, 0);
            await sleep(277);
            unit_set_emotional_state(johnson.Entity, "pain", 0.5F, 30);
            print("johnson - pain .5 30");
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task miranda_emotion()
        {
            unit_set_emotional_state(miranda.Entity, "shocked", 0.1F, 0);
            await sleep(375);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.4F, 60);
            print("miranda - shocked .25 60");
        }

        [ScriptMethod(167, Lifecycle.Static)]
        public async Task c07_intra1_01_setup()
        {
            object_create_anew(miranda);
            object_create_anew(johnson);
            object_create_anew(truth);
            object_create_anew(mercy);
            object_create_anew(tartarus);
            object_create_anew(brute_01);
            object_create_anew(brute_02);
            object_create_anew(brute_03);
            object_create_anew(brute_04);
            object_create_anew(monitor);
            object_create_anew(hammer);
            object_create_anew(throne_truth);
            object_create_anew(throne_mercy);
            object_create_anew(phantom_01);
            object_create_anew(phantom_02);
            object_create_anew(phantom_03);
            object_create_anew_containing("intra_pike");
            object_set_function_variable(monitor.Entity, "talking", 0F, 0F);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(truth.Entity, true);
            object_cinematic_lod(mercy.Entity, true);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
            object_cinematic_lod(brute_03.Entity, true);
            object_cinematic_lod(brute_04.Entity, true);
            object_cinematic_lod(monitor.Entity, true);
            object_cinematic_lod(hammer.Entity, true);
            object_cinematic_lod(throne_truth.Entity, true);
            object_cinematic_lod(throne_mercy.Entity, true);
            object_cinematic_lod(phantom_01.Entity, true);
            object_cinematic_lod(phantom_02.Entity, true);
            object_cinematic_lod(phantom_03.Entity, true);
            objects_attach(truth.Entity, "driver", throne_truth.Entity, "driver_cinematic");
            objects_attach(mercy.Entity, "driver", throne_mercy.Entity, "driver_cinematic");
            wake(new ScriptMethodReference(c07_intra1_score_01));
            wake(new ScriptMethodReference(c07_intra1_foley_01));
            wake(new ScriptMethodReference(c07_2010_tar));
            wake(new ScriptMethodReference(johnson_emotion));
            wake(new ScriptMethodReference(miranda_emotion));
            wake(new ScriptMethodReference(hide_pikes));
            wake(new ScriptMethodReference(show_pikes));
            wake(new ScriptMethodReference(c07_intra1_cinematic_light_01));
        }

        [ScriptMethod(168, Lifecycle.Static)]
        public async Task c07_intra1_01_cleanup()
        {
            object_destroy(miranda.Entity);
            object_destroy(johnson.Entity);
            object_destroy(monitor.Entity);
            object_destroy(brute_01.Entity);
            object_destroy(brute_02.Entity);
        }

        [ScriptMethod(169, Lifecycle.Static)]
        public async Task c07_intra1_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this._07_intra1_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_01_fol", 3842507666U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\music\\c07_intra1_01_mus", 3842442129U));
            await sleep(this.prediction_offset);
            await this.c07_intra1_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3842638740U), "07_intra1_01", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\07_intra1\\07_intra1", 3842704277U), "miranda_01", false, anchor_intra1.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\07_intra1\\07_intra1", 3845260220U), "johnson_01", false, anchor_intra1.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3845391294U), "truth_01", false, anchor_intra1.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3845391294U), "mercy_01", false, anchor_intra1.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\07_intra1\\07_intra1", 3845456831U), "monitor_01", false, anchor_intra1.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "tartarus_01", false, anchor_intra1.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute01_01", false, anchor_intra1.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute02_01", false, anchor_intra1.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute03_01", false, anchor_intra1.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute04_01", false, anchor_intra1.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\07_intra1\\07_intra1", 3845587905U), "hammer_01", anchor_intra1.Entity);
            scenery_animation_start_relative(intra_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3845653442U), "pike01_01", anchor_intra1.Entity);
            scenery_animation_start_relative(intra_pike_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3845653442U), "pike02_01", anchor_intra1.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom1_01", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom2_01", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom3_01", false, anchor_intra1.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intra1_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_02_fol", 3845784516U));
            await sleep((short)camera_time());
            await this.c07_intra1_01_cleanup();
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_02_fol", 3845784516U), default(IGameObject), 1F);
            print("c07_intra1 foley 02 start");
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task c07_2020_pot()
        {
            await sleep(52);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2020_pot", 3845850053U), truth.Entity, 1F);
            cinematic_subtitle("c07_2020_pot", 4F);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task c07_2030_tar()
        {
            await sleep(163);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2030_tar", 3845915590U), tartarus.Entity, 1F);
            cinematic_subtitle("c07_2030_tar", 4F);
            await sleep(90);
            print("spawn infection-forms");
            ai_place(c07_infection.Squad);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task c07_intra1_02_fov_01()
        {
            await sleep(347);
            print("fov change: 60 -> 8 over 20 ticks");
            camera_set_field_of_view(8F, 20);
        }

        [ScriptMethod(174, Lifecycle.Static)]
        public async Task c07_intra1_02_setup()
        {
            object_cannot_take_damage(truth.Entity);
            object_cannot_take_damage(mercy.Entity);
            object_cannot_take_damage(tartarus.Entity);
            object_cannot_take_damage(brute_03.Entity);
            object_cannot_take_damage(brute_04.Entity);
            object_cannot_take_damage(infection_form_01.Entity);
            object_cannot_take_damage(infection_form_02.Entity);
            object_create_anew(infection_form_01);
            object_create_anew(index);
            object_cinematic_lod(infection_form_01.Entity, true);
            object_cinematic_lod(index.Entity, true);
            wake(new ScriptMethodReference(c07_intra1_foley_02));
            wake(new ScriptMethodReference(c07_2020_pot));
            wake(new ScriptMethodReference(c07_2030_tar));
            wake(new ScriptMethodReference(c07_intra1_02_fov_01));
        }

        [ScriptMethod(175, Lifecycle.Static)]
        public async Task c07_intra1_02_cleanup()
        {
            objects_detach(mercy.Entity, throne_mercy.Entity);
            object_destroy(mercy.Entity);
            object_hide(index.Entity, true);
        }

        [ScriptMethod(176, Lifecycle.Static)]
        public async Task c07_intra1_scene_02()
        {
            await this.c07_intra1_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3842638740U), "07_intra1_02", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3845391294U), "truth_02", false, anchor_intra1.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3845391294U), "mercy_02", false, anchor_intra1.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "tartarus_02", false, anchor_intra1.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute03_02", false, anchor_intra1.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute04_02", false, anchor_intra1.Entity);
            custom_animation_relative(infection_form_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3845981127U), "infection01_02", false, anchor_intra1.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\07_intra1\\07_intra1", 3845587905U), "hammer_02", anchor_intra1.Entity);
            scenery_animation_start_relative(index.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\07_intra1\\07_intra1", 3846046664U), "index_02", anchor_intra1.Entity);
            scenery_animation_start_relative(intra_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3845653442U), "pike01_02", anchor_intra1.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom1_02", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom2_02", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom3_02", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intra1_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_03_fol", 3846112201U));
            await sleep((short)camera_time());
            await this.c07_intra1_02_cleanup();
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_03_fol", 3846112201U), default(IGameObject), 1F);
            print("c07_intra1 foley 03 start");
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task c07_2040_pom()
        {
            await sleep(295);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2040_pom", 3846177738U), mercy.Entity, 1F);
            cinematic_subtitle("c07_2040_pom", 4F);
            unit_set_emotional_state(mercy.Entity, "scared", 1F, 30);
            print("mercy - scared 1 30");
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task effect_infection_burrow()
        {
            await sleep(302);
            print("effect - infection burrow");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\07\\flood_burrowing", 3846243275U), infection_form_02.Entity, "mouth");
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task infection_pop_01()
        {
            time_code_reset();
            await sleep(162);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3846308812U), infection_form_01.Entity, "");
            object_hide(infection_form_01.Entity, true);
            await sleep(51);
            object_hide(infection_form_01.Entity, false);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3846308812U), infection_form_01.Entity, "");
            object_hide(infection_form_01.Entity, true);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task infection_pop_02()
        {
            await sleep(171);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3846308812U), infection_form_02.Entity, "");
            object_hide(infection_form_02.Entity, true);
            await sleep(2);
            object_hide(infection_form_02.Entity, false);
            await sleep(7);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3846308812U), infection_form_02.Entity, "");
            object_hide(infection_form_02.Entity, true);
            await sleep(9);
            object_hide(infection_form_02.Entity, false);
            await sleep(17);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3846308812U), infection_form_02.Entity, "");
            object_hide(infection_form_02.Entity, true);
            await sleep(10);
            object_hide(infection_form_02.Entity, false);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task kill_infection_forms()
        {
            await sleep(158);
            print("erase infection forms");
            ai_erase(c07_infection.Squad);
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task delete_mercy_throne()
        {
            await sleep(308);
            print("destroy mercy's throne");
            object_destroy(throne_mercy.Entity);
        }

        [ScriptMethod(184, Lifecycle.Static)]
        public async Task c07_intra1_03_setup()
        {
            object_create_anew(mercy_no_crown);
            object_create_anew(infection_form_02);
            object_cinematic_lod(mercy_no_crown.Entity, true);
            object_cinematic_lod(infection_form_02.Entity, true);
            object_uses_cinematic_lighting(mercy_no_crown.Entity, true);
            object_uses_cinematic_lighting(infection_form_02.Entity, true);
            objects_attach(mercy_no_crown.Entity, "driver", throne_mercy.Entity, "driver_cinematic");
            wake(new ScriptMethodReference(c07_intra1_foley_03));
            wake(new ScriptMethodReference(c07_2040_pom));
            wake(new ScriptMethodReference(delete_mercy_throne));
            wake(new ScriptMethodReference(kill_infection_forms));
            wake(new ScriptMethodReference(infection_pop_01));
            wake(new ScriptMethodReference(infection_pop_02));
            wake(new ScriptMethodReference(effect_infection_burrow));
        }

        [ScriptMethod(185, Lifecycle.Static)]
        public async Task c07_intra1_03_cleanup()
        {
            object_destroy(infection_form_02.Entity);
            object_destroy(hammer.Entity);
            object_destroy_containing("intra_pike");
        }

        [ScriptMethod(186, Lifecycle.Static)]
        public async Task c07_intra1_scene_03()
        {
            await this.c07_intra1_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3842638740U), "07_intra1_03", default(IUnit), anchor_flag_intra1);
            camera_set_field_of_view(60F, 0);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3845391294U), "truth_03", false, anchor_intra1.Entity);
            custom_animation_relative(mercy_no_crown.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3845391294U), "mercy_03", false, anchor_intra1.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "tartarus_03", false, anchor_intra1.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute03_03", false, anchor_intra1.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute04_03", false, anchor_intra1.Entity);
            custom_animation_relative(infection_form_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3845981127U), "infection01_03", false, anchor_intra1.Entity);
            custom_animation_relative(infection_form_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3845981127U), "infection02_03", false, anchor_intra1.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\07_intra1\\07_intra1", 3845587905U), "hammer_03", anchor_intra1.Entity);
            scenery_animation_start_relative(intra_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3845653442U), "pike01_03", anchor_intra1.Entity);
            scenery_animation_start_relative(intra_pike_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\07_intra1\\07_intra1", 3845653442U), "pike02_03", anchor_intra1.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom1_03", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom2_03", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom3_03", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intra1_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_04_fol", 3846964182U));
            await sleep((short)camera_time());
            await this.c07_intra1_03_cleanup();
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_04_fol", 3846964182U), default(IGameObject), 1F);
            print("c07_intra1 foley 04 start");
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task c07_2050_pot()
        {
            await sleep(64);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2050_pot", 3847029719U), truth.Entity, 1F);
            cinematic_subtitle("c07_2050_pot", 1F);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task c07_2060_pot()
        {
            await sleep(132);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2060_pot", 3847095256U), truth.Entity, 1F);
            cinematic_subtitle("c07_2060_pot", 3F);
            await sleep(45);
            unit_set_emotional_state(tartarus.Entity, "pensive", 0.5F, 60);
            print("tartarus - shocked .5 60");
            unit_set_emotional_state(mercy.Entity, "shocked", 1F, 0);
            print("mercy - shocked 1 0");
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task c07_2070_pot()
        {
            await sleep(231);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2070_pot", 3847160793U), truth.Entity, 1F);
            cinematic_subtitle("c07_2070_pot", 2F);
            unit_set_emotional_state(mercy.Entity, "pain", 1F, 60);
            print("mercy - pain 1 60");
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task c07_intra1_dof_04()
        {
            time_code_reset();
            await sleep(384);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(0.5F, 0.75F, 0.75F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(106);
            cinematic_screen_effect_set_depth_of_field(0.5F, 0.75F, 0F, 0.5F, 0F, 0.75F, 0.5F);
            print("rack focus");
        }

        [ScriptMethod(192, Lifecycle.Static)]
        public async Task c07_intra1_04_setup()
        {
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\07\\flood_burrowing", 3846243275U), infection_form_01.Entity, "mouth");
            object_hide(index.Entity, false);
            object_hide(infection_form_01.Entity, false);
            wake(new ScriptMethodReference(c07_intra1_foley_04));
            wake(new ScriptMethodReference(c07_2050_pot));
            wake(new ScriptMethodReference(c07_2060_pot));
            wake(new ScriptMethodReference(c07_2070_pot));
            wake(new ScriptMethodReference(c07_intra1_dof_04));
            unit_set_emotional_state(tartarus.Entity, "shocked", 0.5F, 0);
            print("tartarus - shocked .5 0");
        }

        [ScriptMethod(193, Lifecycle.Static)]
        public async Task c07_intra1_04_cleanup()
        {
            object_destroy(truth.Entity);
            object_destroy(mercy_no_crown.Entity);
            object_destroy(tartarus.Entity);
            object_destroy(brute_03.Entity);
            object_destroy(brute_04.Entity);
            object_destroy(infection_form_01.Entity);
            object_destroy(throne_mercy.Entity);
            object_destroy(phantom_01.Entity);
            object_destroy(phantom_02.Entity);
            object_destroy(phantom_03.Entity);
            object_destroy(index.Entity);
        }

        [ScriptMethod(194, Lifecycle.Static)]
        public async Task c07_intra1_scene_04()
        {
            await this.c07_intra1_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3842638740U), "07_intra1_04", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3845391294U), "truth_04", false, anchor_intra1.Entity);
            custom_animation_relative(mercy_no_crown.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3845391294U), "mercy_04", false, anchor_intra1.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "tartarus_04", false, anchor_intra1.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute03_04", false, anchor_intra1.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\07_intra1\\07_intra1", 3845522368U), "brute04_04", false, anchor_intra1.Entity);
            scenery_animation_start_relative(index.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\07_intra1\\07_intra1", 3846046664U), "index_04", anchor_intra1.Entity);
            custom_animation_relative(infection_form_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3845981127U), "infection01_04", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom1_04", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom2_04", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3845718979U), "phantom3_04", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - 60));
            fade_out(0F, 0F, 0F, 60);
            await sleep(60);
            await this.c07_intra1_04_cleanup();
            cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(195, Lifecycle.Static)]
        public async Task c07_intra1()
        {
            sound_class_set_gain("vehicle", 0.25F, 1);
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("high_5"));
            await sleep(1);
            await this.c07_intra1_scene_01();
            await this.c07_intra1_scene_02();
            await this.c07_intra1_scene_03();
            await this.c07_intra1_scene_04();
        }

        [ScriptMethod(196, Lifecycle.Static)]
        public async Task test()
        {
            print("effect - infection burrow");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\07\\flood_burrowing", 3846243275U), infection_form_02.Entity, "mouth");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\07\\flood_burrowing", 3846243275U), infection_form_01.Entity, "mouth");
        }

        [ScriptMethod(197, Lifecycle.CommandScript)]
        public async Task cs_jump()
        {
            cs_jump_to_point(0F, 5F);
        }

        [ScriptMethod(198, Lifecycle.CommandScript)]
        public async Task cs_abort()
        {
            await sleep(1);
        }

        [ScriptMethod(199, Lifecycle.CommandScript)]
        public async Task cs_alert()
        {
            cs_abort_on_alert(true);
            sleep_forever();
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task cs_alert_combat()
        {
            cs_abort_on_alert(true);
            cs_movement_mode(this.ai_movement_combat);
            sleep_forever();
        }

        [ScriptMethod(201, Lifecycle.Static)]
        public async Task test_rumble()
        {
            damage_object(GetTag<DamageEffectTag>("objects\\cinematics\\human\\inamberclad_to_scale\\damage_effects\\ioc_flyby", 4248771454U), await this.player0());
        }

        [ScriptMethod(202, Lifecycle.Static)]
        public async Task test_ioc()
        {
            object_create(ioc_effect);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\inamberclad_flyby\\slipspace", 4248836991U), rupture.Entity, 1F);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\inamberclad_flyby\\inamberclad_flyby", 4248902528U), default(IGameObject), 1F);
            await sleep(3);
            object_create(ioc);
            device_set_position_track(ioc.Entity, "high_charity_flyby", 0F);
            device_animate_position(ioc.Entity, 1F, 15F, 0F, 0F, false);
            await sleep(30);
            object_destroy(ioc_effect.Entity);
            await sleep(30);
            damage_object(GetTag<DamageEffectTag>("objects\\cinematics\\human\\inamberclad_to_scale\\damage_effects\\ioc_flyby", 4248771454U), await this.player0());
            await sleep_until(async () => device_get_position(ioc.Entity) >= 1F);
            object_destroy(ioc.Entity);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task bullshit()
        {
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            object_destroy_containing("bsp0_crate");
            object_destroy_containing("bsp1_crate");
            object_destroy_containing("bsp2_crate");
            object_destroy_containing("bsp2_body");
            await sleep(1);
            object_create_anew_containing("bsp3_body");
            object_create_anew_containing("bsp3_crate");
            await sleep_until(async () => (short)structure_bsp_index() == 4);
            object_destroy_containing("bsp3_body");
            object_destroy_containing("bsp3_crate");
            await sleep(1);
            object_create_anew_containing("bsp3b_body");
            object_create_anew_containing("bsp3b_crate");
            await sleep_until(async () => (short)structure_bsp_index() == 5);
            object_destroy_containing("bsp3b_body");
            object_destroy_containing("bsp3b_crate");
            await sleep(1);
            object_create_anew_containing("bsp4_body");
            object_create_anew_containing("bsp4_crate");
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task cs_expand_cortana()
        {
            object_set_scale(ai_get_object(this.ai_current_actor), 0.01F, 0);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            await sleep(5);
            object_dynamic_simulation_disable(ai_get_object(this.ai_current_actor), true);
            unit_set_emotional_state(ai_get_unit(this.ai_current_actor), "pensive", 0.5F, 0);
            await sleep(1);
            object_hide(ai_get_object(this.ai_current_actor), false);
            object_set_scale(ai_get_object(this.ai_current_actor), 0.65F, 20);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task cs_shrink_cortana()
        {
            cs_enable_dialogue(false);
            await sleep(60);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), ai_get_object(this.ai_current_actor), "effect");
            await sleep(3);
            object_set_scale(ai_get_object(this.ai_current_actor), 0.01F, 10);
            await sleep(30);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task ice_cream_angry()
        {
            await sleep_until(async () => volume_test_objects(tv_ice_cream, players()));
            object_create(ice_cream_effect);
            object_create(ice_cream_head);
            ai_place(ice_cream_grunt1.Squad);
            await sleep(1);
            device_set_position(ice_cream_effect.Entity, 1F);
            ai_set_active_camo(ice_cream_grunt1.Squad, true);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head.weapon", 4145026402U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head.weapon", 4145026402U)));
            if (this.debug)
            {
                print("you're going to get fat!!!!! or dead...");
            }

            if (this.debug)
            {
                print("because now everyone is angry!!!!");
            }

            ice_cream_flavor_stock(13);
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task music_07a_01()
        {
            await sleep_until(async () => this.g_music_07a_01);
            if (this.debug)
            {
                print("start music 07a_01");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_01", 4249361287U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_07a_01));
            if (this.debug)
            {
                print("stop music 07a_01");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_01", 4249361287U));
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task music_07a_02()
        {
            await sleep_until(async () => this.g_music_07a_02);
            if (this.debug)
            {
                print("start music 07a_02");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_02", 4249557898U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_07a_02));
            if (this.debug)
            {
                print("stop music 07a_02");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_02", 4249557898U));
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task music_07a_03()
        {
            await sleep_until(async () => this.g_music_07a_03);
            if (this.debug)
            {
                print("start music 07a_03");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_03", 4249754509U), default(IGameObject), 1F);
            await sleep_until(async () => this.g_music_07a_03_alt);
            if (this.debug)
            {
                print("set music 07a_03 alternate");
            }

            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_03", 4249754509U), true);
            await sleep_until(async () => !(this.g_music_07a_03));
            if (this.debug)
            {
                print("stop music 07a_03");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_03", 4249754509U));
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task music_07a_04()
        {
            await sleep_until(async () => this.g_music_07a_04);
            if (this.debug)
            {
                print("start music 07a_04");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_04", 4250016657U), default(IGameObject), 1F);
            await sleep_until(async () => this.g_music_07a_04_alt);
            if (this.debug)
            {
                print("set music 07a_04 alternate");
            }

            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_04", 4250016657U), true);
            await sleep_until(async () => !(this.g_music_07a_04));
            if (this.debug)
            {
                print("stop music 07a_04");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_04", 4250016657U));
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task music_07a_05()
        {
            await sleep_until(async () => this.g_music_07a_05);
            if (this.debug)
            {
                print("start music 07a_05");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_05", 4250344342U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_07a_05));
            if (this.debug)
            {
                print("stop music 07a_05");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_05", 4250344342U));
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task music_07a_06()
        {
            await sleep_until(async () => this.g_music_07a_06);
            if (this.debug)
            {
                print("start music 07a_06");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_06", 4250540953U), default(IGameObject), 1F);
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task music_07a_07()
        {
            await sleep_until(async () => this.g_music_07a_07);
            if (this.debug)
            {
                print("start music 07a_07");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_07", 4250672027U), default(IGameObject), 1F);
            await sleep_until(async () => this.g_music_07a_07_alt);
            if (this.debug)
            {
                print("set music 07a_07 alternate");
            }

            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_07", 4250672027U), true);
            await sleep_until(async () => !(this.g_music_07a_07));
            if (this.debug)
            {
                print("stop music 07a_07");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_07", 4250672027U));
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task music_07a_08()
        {
            await sleep_until(async () => this.g_music_07a_08);
            if (this.debug)
            {
                print("start music 07a_08");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_08", 4251065249U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_07a_08));
            if (this.debug)
            {
                print("stop music 07a_08");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07a_highcharity\\07a_music\\07a_08", 4251065249U));
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task chapter_job()
        {
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task chapter_thanks()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(217, Lifecycle.Dormant)]
        public async Task chapter_grudge()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_3);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(218, Lifecycle.Dormant)]
        public async Task chapter_graves()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_4);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task objective_locate_set()
        {
            await sleep(30);
            print("new objective set:");
            print("locate the prophet of truth and the index.");
            objectives_show_up_to(0);
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task objective_locate_clear()
        {
            print("objective complete:");
            print("locate the prophet of truth and the index.");
            objectives_finish_up_to(0);
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task objective_rescue_set()
        {
            await sleep(30);
            print("new objective set:");
            print("rescue the marines being held in the detention-block.");
            objectives_show_up_to(1);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task objective_rescue_clear()
        {
            print("objective complete:");
            print("rescue the marines being held in the detention-block.");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task objective_truth_set()
        {
            await sleep(30);
            print("new objective set:");
            print("follow the prophet of truth to the far tower.");
            objectives_show_up_to(2);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task objective_truth_clear()
        {
            print("objective complete:");
            print("follow the prophet of truth to the far tower.");
            objectives_finish_up_to(2);
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task objective_phantom_set()
        {
            await sleep(30);
            print("new objective set:");
            print("stop the prophet of truth from boarding his phantom.");
            objectives_show_up_to(3);
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task objective_phantom_clear()
        {
            print("objective complete:");
            print("stop the prophet of truth from boarding his phantom.");
            objectives_finish_up_to(3);
        }

        [ScriptMethod(227, Lifecycle.Static)]
        public async Task erase_cortana()
        {
            if (this.debug)
            {
                print("erasing cortana...");
            }

            cs_run_command_script(cortana1, new ScriptMethodReference(cs_shrink_cortana));
            await sleep(1);
        }

        [ScriptMethod(228, Lifecycle.Static)]
        public async Task sc_this_way_a()
        {
            if (this.dialogue)
            {
                print("cortana: this way, chief!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2000"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(229, Lifecycle.Static)]
        public async Task sc_this_way_b()
        {
            if (this.dialogue)
            {
                print("cortana: over here, chief!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2010"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(230, Lifecycle.Static)]
        public async Task sc_this_way_c()
        {
            if (this.dialogue)
            {
                print("cortana: chief! let's go");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2020"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(231, Lifecycle.Static)]
        public async Task sc_this_way_d()
        {
            if (this.dialogue)
            {
                print("cortana: come on, chief!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2030"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(232, Lifecycle.Static)]
        public async Task sc_this_way_e()
        {
            if (this.dialogue)
            {
                print("cortana: through here!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2040"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(233, Lifecycle.Static)]
        public async Task sc_this_way_f()
        {
            if (this.dialogue)
            {
                print("cortana: go on through!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2050"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task sc_council_ini()
        {
            if (this.dialogue)
            {
                print("cortana: brutes!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2070"));
            await sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                print("cortana: the faster you kill those brutes the better");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2100"));
            this.g_council_initial = true;
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task sc_brutes_berserk()
        {
            if ((short)ai_living_count(council_brute_ini1.Squad) > 0)
            {
                if (this.dialogue)
                {
                    print("cortana: they don't have shield generators, but take them out before...");
                }

                await sleep(ai_play_line_on_object(default(IGameObject), "2080"));
                await sleep(this.dialogue_pause);
            }

            if ((short)ai_living_count(council_brute_ini1.Squad) > 0)
            {
                if (this.dialogue)
                {
                    print("cortana: it's berserking!");
                }

                await sleep(ai_play_line_on_object(default(IGameObject), "2090"));
            }
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task sc_council_exit_reminder()
        {
            await sleep((short)(30 * 20));
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_council_bk, players()) || volume_test_objects(tv_council_lt_bk, players()) || volume_test_objects(tv_council_rt_bk, players()))
                {
                    if (this.g_council_exit_reminder)
                    {
                        sleep_forever();
                    }

                    if (this.dialogue)
                    {
                        print("cortana: they've locked it from below");
                    }

                    await sleep(ai_play_line_on_object(default(IGameObject), "2130"));
                    await sleep((short)(this.dialogue_pause * 2));
                    if (this.g_council_exit_reminder)
                    {
                        sleep_forever();
                    }

                    if (this.dialogue)
                    {
                        print("cortana: there's a door at the other end of the chamber");
                    }

                    await sleep(ai_play_line_on_object(default(IGameObject), "2120"));
                    this.g_council_reminder_played = true;
                }

                if (this.g_council_reminder_played)
                {
                    this.g_council_reminder_played = false;
                    await sleep((short)(30 * 30));
                }

                return this.g_council_exit_reminder;
            }, 60);
        }

        [ScriptMethod(237, Lifecycle.Static)]
        public async Task sc_council_mid()
        {
            await sleep((short)random_range(15, 45));
            if (this.dialogue)
            {
                print("brute: the demon has infiltrated the council chamber?!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4174518052U), council_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4174518052U), council_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4174518052U), council_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4174518052U), council_sound_d.Entity, 1F, 1);
            await sleep(1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1000_bth", 4174518052U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("brute: protect the hierarchs! seal the exits!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4174583589U), council_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4174583589U), council_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4174583589U), council_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4174583589U), council_sound_d.Entity, 1F, 1);
            await sleep(1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1010_bth", 4174583589U)));
            await sleep((short)(this.dialogue_pause * 2));
            if (this.dialogue)
            {
                print("cortana: oh, i don't think so");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2190"));
            await sleep((short)(this.dialogue_pause * 4));
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task sc_council_exit_leave()
        {
            await sleep(150);
            if (volume_test_objects(tv_council_ext, players()))
            {
                if (this.dialogue)
                {
                    print("cortana: don't worry. you can pick me up later");
                }

                await sleep(ai_play_line_at_player(cortana_01.Squad, "2180"));
            }

            await this.erase_cortana();
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task sc_council_exit()
        {
            await sleep((short)random_range(15, 45));
            if (this.dialogue)
            {
                print("cortana: put me down on one of the pedestals near the door.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2110"));
            wake(new ScriptMethodReference(sc_council_exit_reminder));
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(players(), bsp_0_holo_a.Entity) > 0F && objects_distance_to_object(players(), bsp_0_holo_a.Entity) < 2.5F)
                {
                    ai_place(cortana_01.a);
                    this.g_council_exit_reminder = true;
                    await sleep(5);
                    effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), bsp_0_holo_a.Entity, "effect");
                }
                else if (objects_distance_to_object(players(), bsp_0_holo_b.Entity) > 0F && objects_distance_to_object(players(), bsp_0_holo_b.Entity) < 2.5F)
                {
                    ai_place(cortana_01.b);
                    this.g_council_exit_reminder = true;
                    await sleep(5);
                    effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), bsp_0_holo_b.Entity, "effect");
                }

                return this.g_council_exit_reminder;
            }, 5);
            await sleep(90);
            if (this.dialogue)
            {
                print("cortana: that prophet - truth - he has the index!");
            }

            if (this.dialogue)
            {
                print("cortana: you've got to take it back from him!");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2150"));
            await sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                print("cortana: let me get these doors...");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2140"));
            await sleep(this.dialogue_pause);
            device_closes_automatically_set(council_exit.Entity, false);
            device_operates_automatically_set(council_exit.Entity, true);
            await sleep(1);
            device_set_position(council_exit.Entity, 1F);
            await sleep(15);
            game_save();
            if (this.dialogue)
            {
                print("cortana: go. it'll be easier to track truth if i stay in the network");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2170"));
            await sleep(this.dialogue_pause);
            this.g_music_07a_01 = true;
            wake(new ScriptMethodReference(sc_council_exit_leave));
            await sleep_until(async () => volume_test_objects(tv_council_hall, players()), 5);
            await sleep(30);
            await this.erase_cortana();
            device_closes_automatically_set(council_exit.Entity, true);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task sc_grand_a_exit()
        {
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_01.f);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), bsp_0_holo_f.Entity, "effect");
            await sleep_until(async () => objects_distance_to_object(players(), bsp_0_holo_f.Entity) > 0F && objects_distance_to_object(players(), bsp_0_holo_f.Entity) < 4F);
            this.g_music_07a_02 = true;
            if (this.dialogue)
            {
                print("cortana: right this way chief!");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2060"));
            device_one_sided_set(grand_a_exit.Entity, false);
            await sleep_until(async () => volume_test_objects(tv_dervish_ledge_fr, players()));
            await sleep(30);
            await this.erase_cortana();
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task sc_ledge_chieftan()
        {
            if (this.g_cheiftan)
            {
                sleep_forever();
            }

            await sleep(30);
            if (this.dialogue)
            {
                print("cortana: watch out for the captain!");
            }

            if (this.dialogue)
            {
                print("cortana: it's got a brute shot");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2200"));
            this.g_cheiftan = true;
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task sc_ledge_down_reminder()
        {
            await sleep(300);
            await sleep_until(async () => volume_test_objects(tv_dervish_ledge_lift, players()));
            if (this.g_ledge_reminder)
            {
                sleep_forever();
            }

            if (this.dialogue)
            {
                print("cortana: after that stunt on the cairo,");
            }

            if (this.dialogue)
            {
                print("cortana: i know you're not afraid of heights.");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2240"));
            await sleep((short)(this.dialogue_pause * 3));
            await sleep(300);
            await sleep_until(async () => volume_test_objects(tv_dervish_ledge_lift, players()));
            if (this.g_ledge_reminder)
            {
                sleep_forever();
            }

            if (this.dialogue)
            {
                print("cortana: fine, i won't watch");
            }

            if (this.dialogue)
            {
                print("cortana: meet you at the bottom, ok?");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2250"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task sc_ledge_down()
        {
            await sleep_until(async () => this.g_cheiftan && (short)ai_living_count(dervish_ledge_prophets) <= 3);
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_01.i);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), bsp_0_holo_i.Entity, "effect");
            await sleep(90);
            await sleep_until(async () => !(volume_test_objects(tv_dervish_ledge_fr, ai_actors(prophets))) && !(volume_test_objects(tv_dervish_ledge_bk, ai_actors(prophets))));
            this.g_dervish_ledge_orders = true;
            await sleep(30);
            await sleep_until(async () => objects_distance_to_object(players(), bsp_0_holo_i.Entity) > 0F && objects_distance_to_object(players(), bsp_0_holo_i.Entity) < 2F);
            if (this.dialogue)
            {
                print("cortana: truth is moving through the lower-levels of the tower.");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2210"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: i'll reverse this grav-lift. drop down, try to cut him off.");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2220"));
            await sleep(this.dialogue_pause);
            game_save();
            device_closes_automatically_set(dervish_lift_up.Entity, false);
            device_set_position(dervish_lift_up.Entity, 1F);
            await sleep(30);
            object_destroy(dervish_lift_up.Entity);
            object_create(dervish_lift_down);
            await sleep(5);
            if (this.dialogue)
            {
                print("cortana: it's safe really. just step in");
            }

            await sleep(ai_play_line_at_player(cortana_01.Squad, "2230"));
            await sleep(this.dialogue_pause);
            wake(new ScriptMethodReference(sc_ledge_down_reminder));
            await sleep_until(async () => volume_test_objects(tv_dervish_ledge_lower, players()));
            this.g_ledge_reminder = true;
            await this.erase_cortana();
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task sc_corridor_a_amb()
        {
            await sleep((short)random_range(15, 45));
            if (this.dialogue)
            {
                print("brute: reinforce all approaches to the holding-pens!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4174649126U), corr_a_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4174649126U), corr_a_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4174649126U), corr_a_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4174649126U), corr_a_sound_d.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1020_bth", 4174649126U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("brute: slay the demon on sight!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4174714663U), corr_a_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4174714663U), corr_a_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4174714663U), corr_a_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4174714663U), corr_a_sound_d.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1030_bth", 4174714663U)));
            await sleep((short)(this.dialogue_pause * 5));
            await sleep_until(async () => objects_distance_to_object(players(), grand_b_holo_b.Entity) > 0F && objects_distance_to_object(players(), grand_b_holo_b.Entity) < 5F, 5);
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_grand_b.b);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), grand_b_holo_b.Entity, "effect");
            await sleep(30);
            if (this.dialogue)
            {
                print("cortana: they're beefing-up their patrols. stay sharp.");
            }

            await sleep(ai_play_line_at_player(cortana_grand_b.Squad, "2260"));
            game_save_no_timeout();
            await sleep(30);
            device_set_position(grand_b_exit.Entity, 1F);
            await sleep(90);
            await this.erase_cortana();
            device_closes_automatically_set(grand_b_exit.Entity, true);
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task sc_jail_info()
        {
            if (this.dialogue)
            {
                print("cortana: wait a minute... i'm reading marine iff transponders!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2270"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: the signals are originating somewhere below your position.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2280"));
            game_save_no_timeout();
            ai_place(hall_b_jackals.Squad);
            wake(new ScriptMethodReference(objective_locate_clear));
            wake(new ScriptMethodReference(objective_rescue_set));
        }

        [ScriptMethod(246, Lifecycle.Dormant)]
        public async Task sc_room_a_lift()
        {
            await sleep_until(async () => (short)ai_living_count(hall_b_prophets) <= 3);
            ai_place(cortana_corridor_a.o);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), hall_a_holo_o.Entity, "effect");
            await sleep_until(async () => objects_distance_to_object(players(), hall_a_holo_o.Entity) > 0F && objects_distance_to_object(players(), hall_a_holo_o.Entity) < 4.5F);
            if (this.dialogue)
            {
                print("cortana: there's another lift in the next room");
            }

            await sleep(ai_play_line_at_player(cortana_corridor_a.Squad, "2290"));
            await sleep(this.dialogue_pause);
            await sleep_until(async () => this.g_room_a_door && volume_test_objects(tv_room_a, players()));
            await this.erase_cortana();
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task sc_room_a_down()
        {
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_room_a.m);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), room_a_holo_m.Entity, "effect");
            await sleep_until(async () => objects_distance_to_object(players(), jail_down.Entity) > 0F && objects_distance_to_object(players(), jail_down.Entity) < 3.5F, 5);
            await sleep(15);
            if (this.dialogue)
            {
                print("cortana: here, chief! jump in!");
            }

            await sleep(ai_play_line_at_player(cortana_room_a.Squad, "2300"));
            ai_place(room_a_tube_fodder.Squad);
            device_set_power(room_a_lift.Entity, 0F);
            device_set_position(room_a_lift_effect.Entity, 1F);
            await sleep(30);
            device_set_position(jail_down.Entity, 1F);
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task sc_jail_down()
        {
            if (this.dialogue)
            {
                print("cortana: there are two groups of marines in this detention-block.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2310"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: i'll zero their locations - you neutralize the guards... quietly");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2320"));
            await sleep(30);
            this.g_music_07a_03 = true;
            game_save_immediate();
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task sc_cell_a_ent()
        {
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_jail1.h);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), jail_ped_h.Entity, "effect");
            await sleep(60);
            if (this.dialogue)
            {
                print("cortana: come to middle-level, chief!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2350"));
            await sleep((short)(this.dialogue_pause * 3));
            if (this.g_jail_a_finished || this.g_jail_b_finished)
            {
                if (this.dialogue)
                {
                    print("cortana: more guards! get ready!");
                }

                await sleep(ai_play_line_on_object(default(IGameObject), "2380"));
            }
            else
            {
                if (this.dialogue)
                {
                    print("cortana: the marines are just inside. careful of the guards.");
                }

                await sleep(ai_play_line_on_object(default(IGameObject), "2360"));
            }

            await sleep_until(async () => objects_distance_to_object(players(), jail_ped_h.Entity) > 0F && objects_distance_to_object(players(), jail_ped_h.Entity) < 3F, 5);
            game_save();
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task sc_cell_b_ent()
        {
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_jail1.n);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), jail_ped_n.Entity, "effect");
            await sleep(60);
            if (this.dialogue)
            {
                print("cortana: chief! come to the lower level!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2370"));
            await sleep((short)(this.dialogue_pause * 3));
            if (this.g_jail_a_finished || this.g_jail_b_finished)
            {
                if (this.dialogue)
                {
                    print("cortana: more guards! get ready!");
                }

                await sleep(ai_play_line_on_object(default(IGameObject), "2380"));
            }
            else
            {
                if (this.dialogue)
                {
                    print("cortana: the marines are just inside. careful of the guards.");
                }

                await sleep(ai_play_line_on_object(default(IGameObject), "2360"));
            }

            await sleep_until(async () => objects_distance_to_object(players(), jail_ped_n.Entity) > 0F && objects_distance_to_object(players(), jail_ped_n.Entity) < 3F, 5);
            game_save();
        }

        [ScriptMethod(251, Lifecycle.Dormant)]
        public async Task sc_first_cell()
        {
            ai_dialogue_enable(false);
            await sleep(90);
            if (this.dialogue)
            {
                print("cortana: listen-up marines. the chief's hunting a prophet,");
            }

            if (this.dialogue)
            {
                print("cortana: and you're gonna help him kill it.");
            }

            await sleep(ai_play_line_at_player(cortana_jail1.Squad, "2390"));
            await sleep(this.dialogue_pause);
            this.g_music_07a_03_alt = true;
            if (this.dialogue)
            {
                print("marine: no sense sticking around here!");
            }

            await sleep(ai_play_line_at_player(jail_marines, "4000"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("marine: affirmative!");
            }

            await sleep(ai_play_line_at_player(jail_marines, "4010"));
            await sleep((short)(this.dialogue_pause * 5));
            if (this.dialogue)
            {
                print("cortana: one more group of marines to go");
            }

            await sleep(ai_play_line_at_player(cortana_jail1.Squad, "2400"));
            await sleep(this.dialogue_pause);
            game_save_no_timeout();
            await sleep(90);
            ai_dialogue_enable(true);
            await this.erase_cortana();
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task sc_second_cell()
        {
            await sleep(90);
            if (this.dialogue)
            {
                print("marine: good on ya");
            }

            await sleep(ai_play_line_at_player(jail_marines, "4020"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("marine: thanks");
            }

            await sleep(ai_play_line_at_player(jail_marines, "4030"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: that's all the marines, chief. good work.");
            }

            await sleep(ai_play_line_at_player(cortana_jail1.Squad, "2410"));
            await sleep(this.dialogue_pause);
            game_save_no_timeout();
            await sleep(90);
            wake(new ScriptMethodReference(objective_rescue_clear));
            await this.erase_cortana();
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task sc_jail_exit()
        {
            if (this.dialogue)
            {
                print("cortana: we'll get out of here the same way we came in:");
            }

            if (this.dialogue)
            {
                print("cortana: the central grav-lift");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2420"));
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task sc_lift_reins()
        {
            if (this.dialogue)
            {
                print("cortana: hostile reinforcements! coming down the lift!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2430"));
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task sc_jail_clear_reminder()
        {
            await sleep((short)(30 * 20));
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_jail_top, players()) || volume_test_objects(tv_jail_mid, players()) || volume_test_objects(tv_jail_bot, players()))
                {
                    if (this.g_jail_exit_reminder)
                    {
                        sleep_forever();
                    }

                    if (this.dialogue)
                    {
                        print("cortana: we've got to get after truth, chief! step into the lift!");
                    }

                    await sleep(ai_play_line_on_object(default(IGameObject), "2450"));
                    this.g_jail_exit_reminder_played = true;
                }

                if (this.g_jail_exit_reminder_played)
                {
                    this.g_jail_exit_reminder_played = false;
                    await sleep((short)(30 * 20));
                }

                return this.g_jail_exit_reminder;
            }, 60);
        }

        [ScriptMethod(256, Lifecycle.CommandScript)]
        public async Task cs_marines_exit()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_go_to(GetReference<ISpatialPoint>("jails/exit"));
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task sc_jail_clear()
        {
            if ((short)random_range(0, 2) == 0)
            {
                ai_place(cortana_jail1.a);
                await sleep(5);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), jail_ped_a.Entity, "effect");
            }
            else
            {
                ai_place(cortana_jail1.b);
                await sleep(5);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), jail_ped_b.Entity, "effect");
            }

            await sleep(90);
            object_destroy(jail_down.Entity);
            device_set_position(jail_up_effect.Entity, 1F);
            await sleep(30);
            object_create(jail_up);
            object_create(room_b_lift);
            device_set_position(room_b_lift_effect.Entity, 1F);
            pvs_set_object(jail_ped_a.Entity);
            await sleep_until(async () => objects_distance_to_object(players(), jail_ped_a.Entity) > 0F && objects_distance_to_object(players(), jail_ped_a.Entity) < 3F || objects_distance_to_object(players(), jail_ped_b.Entity) > 0F && objects_distance_to_object(players(), jail_ped_b.Entity) < 3F, 5);
            if (this.dialogue)
            {
                print("cortana: the lift is clear. step on in!");
            }

            await sleep(ai_play_line_at_player(cortana_jail1.Squad, "2440"));
            await sleep(this.dialogue_pause);
            cs_run_command_script(marines, new ScriptMethodReference(cs_marines_exit));
            wake(new ScriptMethodReference(sc_jail_clear_reminder));
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task sc_room_b()
        {
            await sleep(150);
            if (this.dialogue)
            {
                print("truth: fear not my brothers! the sacred icon is secure!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4173207312U), corr_b_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4173207312U), corr_b_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4173207312U), corr_b_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4173207312U), corr_b_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4173207312U), corr_b_sound_i.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0140_pot", 4173207312U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("truth: it was tartarus and his brutes who took the icon from the flood!");
            }

            if (this.dialogue)
            {
                print("truth: for that, they have our thanks!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4173272849U), corr_b_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4173272849U), corr_b_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4173272849U), corr_b_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4173272849U), corr_b_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4173272849U), corr_b_sound_i.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0150_pot", 4173272849U)));
            await sleep((short)(this.dialogue_pause * 4));
            if (this.dialogue)
            {
                print("cortana: excellent! truth is broadcasting on the move.");
            }

            if (this.dialogue)
            {
                print("cortana: it'll make him much easier to track");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2460"));
            this.g_sc_room_b_done = true;
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task sc_corridor_b_exit()
        {
            await sleep_until(async () => (bool)game_safe_to_save());
            if (this.dialogue)
            {
                print("truth: the elites have failed to protect the prophets,");
            }

            if (this.dialogue)
            {
                print("truth: and in doing so, put all our lives at risk!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_e.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_f.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_g.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_h.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U), corr_b_sound_i.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0220_pot", 4173731608U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("truth: let no warrior forget his oath: thou, in faith,");
            }

            if (this.dialogue)
            {
                print("truth: will keep us safe whilst we find the path!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_e.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_f.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_g.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_h.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U), corr_b_sound_i.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0240_pot", 4173862682U)));
            await sleep((short)(this.dialogue_pause * 4));
            if (this.dialogue)
            {
                print("cortana: i've got a fix on truth just outside this tower, chief");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2470"));
            await sleep(this.dialogue_pause);
            this.g_music_07a_04 = true;
            if (this.dialogue)
            {
                print("cortana: there's an exit nearby - hurry!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2480"));
            await sleep((short)(this.dialogue_pause * 5));
            this.g_corr_b_exit_finished = true;
            game_save_no_timeout();
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task sc_network()
        {
            await sleep_until(async () => (short)ai_living_count(grand_b_hunters) <= 0 || volume_test_objects(tv_tower_a_ext, players()));
            await sleep(30);
            await sleep_until(async () => this.g_corr_b_exit_finished);
            if (this.dialogue)
            {
                print("truth: with my blessing, the brutes now lead our fleets.");
            }

            if (this.dialogue)
            {
                print("truth: they ask for your allegiance, and you shall give it!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4173797145U), ext_a_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4173797145U), ext_a_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4173797145U), ext_a_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4173797145U), ext_a_sound_e.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4173797145U), ext_a_sound_f.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4173797145U), ext_a_sound_g.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0230_pot", 4173797145U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: you wouldn't believe the number of kill systems the");
            }

            if (this.dialogue)
            {
                print("cortana: covenant are throwing-down around me.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2490"));
            await sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                print("cortana: not to worry - it's pretty sloppy stuff.");
            }

            if (this.dialogue)
            {
                print("cortana: i guess they never expected a hostile intelligence");
            }

            if (this.dialogue)
            {
                print("cortana: to penetrate their network from the inside!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2500"));
            game_save_no_timeout();
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task in_amber_clad()
        {
            object_create(ioc_effect);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\inamberclad_flyby\\slipspace", 4248836991U), rupture.Entity, 1F);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\inamberclad_flyby\\inamberclad_flyby", 4248902528U), default(IGameObject), 1F);
            await sleep(3);
            object_create(ioc);
            device_set_position_track(ioc.Entity, "high_charity_flyby", 0F);
            device_animate_position(ioc.Entity, 1F, 15F, 0F, 0F, false);
            await sleep(30);
            object_destroy(ioc_effect.Entity);
            await sleep(30);
            damage_object(GetTag<DamageEffectTag>("objects\\cinematics\\human\\inamberclad_to_scale\\damage_effects\\ioc_flyby", 4248771454U), await this.player0());
            await sleep_until(async () => device_get_position(ioc.Entity) >= 1F);
            object_destroy(ioc.Entity);
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task sc_ioc_reminder()
        {
            await sleep((short)(30 * 10));
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_garden_a_tram, players()))
                {
                    if (this.g_council_exit_reminder)
                    {
                        sleep_forever();
                    }

                    if (this.dialogue)
                    {
                        print("cortana: just step into the pad. it'll move you forward automatically.");
                    }

                    await sleep(ai_play_line_at_player(cortana_3a1.Squad, "2570"));
                    this.g_ioc_reminder_played = true;
                    await sleep(30);
                }

                if (this.g_ioc_reminder_played)
                {
                    this.g_ioc_reminder_played = false;
                    await sleep((short)(30 * 20));
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
                print("cortana: they covenant just destroyed two of their own ships,");
            }

            if (this.dialogue)
            {
                print("cortana: and i'm hearing reports of small arms fire throughout their fleet.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2520"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("truth: creatures of the covenant: the path is broad,");
            }

            if (this.dialogue)
            {
                print("truth: and we shall walk it side-by-side!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0180_pot", 4173469460U), ioc_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0180_pot", 4173469460U), ioc_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0180_pot", 4173469460U), ioc_sound_c.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0180_pot", 4173469460U)));
            await sleep(this.dialogue_pause);
            this.g_truth_speaking = false;
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task sc_in_amber_clad()
        {
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_3a1.tram_a);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), garden_a_holo_a.Entity, "effect");
            await sleep(120);
            await sleep_until(async () => objects_distance_to_object(players(), garden_a_holo_a.Entity) > 0F && objects_distance_to_object(players(), garden_a_holo_a.Entity) < 4F, 5);
            if (this.dialogue)
            {
                print("cortana: slip-space rupture!");
            }

            await sleep(ai_play_line_at_player(cortana_3a1.Squad, "2530"));
            await sleep(this.dialogue_pause);
            this.g_music_07a_05 = true;
            wake(new ScriptMethodReference(in_amber_clad));
            if (this.dialogue)
            {
                print("cortana: it's in amber clad!");
            }

            await sleep(ai_play_line_at_player(cortana_3a1.Squad, "2531"));
            await sleep(this.dialogue_pause);
            this.g_sc_ioc_finished = true;
            await sleep_until(async () => !(this.g_truth_speaking));
            if (this.dialogue)
            {
                print("truth: be glad! the reward for all your toil, all your sacrifice,");
            }

            if (this.dialogue)
            {
                print("truth: is near at hand!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0320_pot", 4174386978U), ioc_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0320_pot", 4174386978U), ioc_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0320_pot", 4174386978U), ioc_sound_c.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0320_pot", 4174386978U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: hailing... no response!");
            }

            await sleep(ai_play_line_at_player(cortana_3a1.Squad, "2540"));
            await sleep(this.dialogue_pause);
            game_save();
            await sleep_until(async () => device_get_position(ioc.Entity) >= 0.9F);
            await sleep(30);
            if (this.dialogue)
            {
                print("cortana: she's crashed into another tower ahead of our position.");
            }

            if (this.dialogue)
            {
                print("cortana: i'll keep trying to make contact,");
            }

            if (this.dialogue)
            {
                print("cortana: but i'm not registering any human vital-signs...");
            }

            await sleep(ai_play_line_at_player(cortana_3a1.Squad, "2550"));
            await sleep((short)(this.dialogue_pause * 10));
            this.g_music_07a_04 = false;
            wake(new ScriptMethodReference(sc_ioc_reminder));
            game_save();
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task sc_garden_a_tram_reminder()
        {
            if (this.dialogue)
            {
                print("cortana: truth has a big enough lead as it is, chief. get going!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2580"));
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task sc_drive_elites()
        {
            await sleep((short)random_range(30, 90));
            if (this.dialogue)
            {
                print("truth: at this moment, the councilors gather on halo to see the icon safely placed!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4173338386U), midtower_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4173338386U), midtower_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4173338386U), midtower_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4173338386U), midtower_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4173338386U), midtower_sound_e.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0160_pot", 4173338386U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("brute: rise, pack-brothers! death to the elites!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4174780200U), midtower_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4174780200U), midtower_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4174780200U), midtower_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4174780200U), midtower_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4174780200U), midtower_sound_e.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1040_bth", 4174780200U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("truth: there are those who said this day would never come.");
            }

            if (this.dialogue)
            {
                print("truth: what have they to say now?");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4174321441U), midtower_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4174321441U), midtower_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4174321441U), midtower_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4174321441U), midtower_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4174321441U), midtower_sound_e.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0310_pot", 4174321441U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("brute: once the towers are cleared, we'll drive them from the lower districts!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4174845737U), midtower_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4174845737U), midtower_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4174845737U), midtower_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4174845737U), midtower_sound_d.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4174845737U), midtower_sound_e.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1050_bth", 4174845737U)));
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task sc_gardens_b()
        {
            await sleep_until(async () => volume_test_objects(tv_sc_gardens_b, players()));
            if (this.dialogue)
            {
                print("truth: i have listened to the oracle, and it confirmed our dearest hope:");
            }

            if (this.dialogue)
            {
                print("truth: the great journey begins with halo!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U), garden_b_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U), garden_b_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U), garden_b_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U), garden_b_sound_e.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U), garden_b_sound_f.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U), garden_b_sound_g.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U), garden_b_sound_h.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U), garden_b_sound_d.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0290_pot", 4174190367U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("brute: the elites are falling back to the mausoleum!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U), garden_b_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U), garden_b_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U), garden_b_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U), garden_b_sound_e.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U), garden_b_sound_f.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U), garden_b_sound_g.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U), garden_b_sound_h.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U), garden_b_sound_d.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1060_bth", 4174911274U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("brute: fools! their arbiter can do nothing for them now!");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U), garden_b_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U), garden_b_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U), garden_b_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U), garden_b_sound_e.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U), garden_b_sound_f.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U), garden_b_sound_g.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U), garden_b_sound_h.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U), garden_b_sound_d.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_1070_bth", 4174976811U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("truth: who would doubt the prophets?");
            }

            if (this.dialogue)
            {
                print("truth: what have we foretold that has not come to pass?");
            }

            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U), garden_b_sound_a.Entity, 1F);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U), garden_b_sound_b.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U), garden_b_sound_c.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U), garden_b_sound_e.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U), garden_b_sound_f.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U), garden_b_sound_g.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U), garden_b_sound_h.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U), garden_b_sound_d.Entity, 1F, 1);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0300_pot", 4174255904U)));
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task sc_catch_truth()
        {
            if (this.dialogue)
            {
                print("cortana: if we're going to catch truth, we'll need to take a short-cut -");
            }

            if (this.dialogue)
            {
                print("cortana: straight through this mausoleum");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2610"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: look on the bright side. for now,");
            }

            if (this.dialogue)
            {
                print("cortana: they seem much more interested in killing each other");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2620"));
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task sc_maus_interior()
        {
            await sleep_until(async () => volume_test_objects(tv_maus_ent, players()) || device_get_position(maus_inner_ent.Entity) >= 0F);
            await sleep(30);
            ai_place(cortana_maus.a);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), maus_inner_holo_a.Entity, "effect");
            await sleep(45);
            if (this.dialogue)
            {
                print("cortana: you might consider sitting this one out");
            }

            await sleep(ai_play_line_at_player(cortana_maus.Squad, "2630"));
            await sleep(30);
            this.g_music_07a_07 = true;
            await sleep(60);
            await this.erase_cortana();
        }

        [ScriptMethod(270, Lifecycle.Static)]
        public async Task sc_maus_breather()
        {
            ai_place(cortana_maus.j);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), maus_inner_holo_j.Entity, "effect");
            await sleep_until(async () => objects_distance_to_object(players(), maus_inner_holo_j.Entity) > 0F && objects_distance_to_object(players(), maus_inner_holo_j.Entity) < 6F, 30, 30 * 60 * 2);
            if (this.dialogue)
            {
                print("cortana: hang on... i'm picking-up two more transponders...");
            }

            await sleep(ai_play_line_at_player(cortana_maus.Squad, "2640"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: it's the commander and johnsom!");
            }

            await sleep(ai_play_line_at_player(cortana_maus.Squad, "2650"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: they're closing on truth's position, chief!");
            }

            await sleep(ai_play_line_at_player(cortana_maus.Squad, "2660"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: they'll need your help!");
            }

            await sleep(ai_play_line_at_player(cortana_maus.Squad, "2670"));
            this.g_music_07a_07_alt = true;
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task sc_maus_exit()
        {
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_maus.f);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), maus_inner_holo_f.Entity, "effect");
            device_one_sided_set(maus_inner_exit.Entity, false);
            await sleep(1);
            await sleep_until(async () => objects_distance_to_object(players(), maus_inner_holo_f.Entity) > 0F && objects_distance_to_object(players(), maus_inner_holo_f.Entity) < 7F, 5);
            await this.erase_cortana();
            if (this.dialogue)
            {
                print("cortana: this way, chief!");
            }

            await sleep(ai_play_line_at_player(cortana_maus.Squad, "2000"));
            await sleep(this.dialogue_pause);
            await sleep_until(async () => volume_test_objects(tv_game_won, players()), 1);
            this.g_music_07a_08 = false;
            await sleep(75);
            if (this.dialogue)
            {
                print("cortana: this isn't good. i'm getting confirmed reports of flood");
            }

            if (this.dialogue)
            {
                print("cortana: leaving in amber clad's wreckage");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2590"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: let's get the index, and find a way out of here -");
            }

            if (this.dialogue)
            {
                print("cortana: before things get really ugly!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2600"));
            await sleep(30);
            await this.cinematic_fade_to_white();
            ai_erase_all();
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        print("c07_intra_1");
                    }

                    await this.c07_intra1();
                }

                await this.cinematic_skip_stop();
            }

            if (this.debug)
            {
                print("you win");
            }

            await this.playtest_mission();
            game_won();
        }

        [ScriptMethod(272, Lifecycle.Dormant)]
        public async Task marine_migration()
        {
            await sleep_until(async () =>
            {
                if ((short)structure_bsp_index() == 2)
                {
                    if (this.debug)
                    {
                        print("migrate into corridor b");
                    }

                    ai_set_orders(marines, marines_corr_b);
                }
                else if ((short)structure_bsp_index() == 3)
                {
                    if (this.debug)
                    {
                        print("migrate into exterior a");
                    }

                    ai_set_orders(marines, marines_ext_a);
                }

                return this.g_marine_mig_garden_a;
            });
            await sleep(30);
            if (this.debug)
            {
                print("migrate into gardens a");
            }

            ai_set_orders(marines, marines_gardens_a);
            await sleep_until(async () => this.g_marine_mig_midtower);
            await sleep_until(async () =>
            {
                if ((short)structure_bsp_index() == 3)
                {
                    if (this.debug)
                    {
                        print("migrate into mid-tower");
                    }

                    ai_set_orders(marines, marines_midtower);
                }
                else if ((short)structure_bsp_index() == 4)
                {
                    if (this.debug)
                    {
                        print("migrate into gardens b");
                    }

                    ai_set_orders(marines, marines_gardens_b);
                }

                return this.g_marine_mig_ext_b;
            });
            await sleep(30);
            if (this.debug)
            {
                print("migrate into exterior b");
            }

            ai_set_orders(marines, marines_ext_b);
            await sleep_until(async () => this.g_marine_mig_maus);
            await sleep_until(async () =>
            {
                if ((short)structure_bsp_index() == 4)
                {
                    if (this.debug)
                    {
                        print("migrate into mausoleum halls");
                    }

                    ai_set_orders(marines, marines_maus_halls);
                }
                else if ((short)structure_bsp_index() == 5)
                {
                    if (this.debug)
                    {
                        print("migrate into mausoleum room bridge");
                    }

                    ai_set_orders(marines, marines_maus_room_bridge);
                }

                return this.g_marine_mig_maus_int;
            });
            await sleep(30);
            if (this.debug)
            {
                print("migrate into mausoleum interior");
            }

            ai_set_orders(marines, marines_maus_int);
        }

        [ScriptMethod(273, Lifecycle.Dormant)]
        public async Task grand_b_door()
        {
            await sleep_until(async () =>
            {
                if ((short)structure_bsp_index() == 2)
                {
                    device_operates_automatically_set(grand_b_door1.Entity, true);
                }
                else if ((short)structure_bsp_index() == 3)
                {
                    device_operates_automatically_set(grand_b_door1.Entity, false);
                }

                return false;
            }, 1);
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task cs_council_grunt_a()
        {
            cs_movement_mode(3);
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("council/p0"));
            await sleep_until(async () => volume_test_objects(tv_council_door_right_a, players()) || (short)ai_living_count(council_brute_ini1.Squad) <= 0);
        }

        [ScriptMethod(275, Lifecycle.CommandScript)]
        public async Task cs_council_grunt_b()
        {
            cs_movement_mode(3);
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("council/p1"));
            await sleep_until(async () => volume_test_objects(tv_council_door_right_b, players()) || (short)ai_living_count(council_brute_ini1.Squad) <= 0);
        }

        [ScriptMethod(276, Lifecycle.CommandScript)]
        public async Task cs_council_grunt_c()
        {
            cs_movement_mode(3);
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("council/p2"));
            await sleep_until(async () => volume_test_objects(tv_council_door_left_a, players()) || (short)ai_living_count(council_brute_ini1.Squad) <= 0);
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task cs_council_grunt_d()
        {
            cs_movement_mode(3);
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("council/p3"));
            await sleep_until(async () => volume_test_objects(tv_council_door_left_b, players()) || (short)ai_living_count(council_brute_ini1.Squad) <= 0);
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task ai_council_brutes_berserk()
        {
            await sleep_until(async () => (short)ai_living_count(council_brute_ini1.Squad) <= 1, 1);
            if ((short)ai_living_count(council_brute_ini1.Squad) > 0)
            {
                ai_set_orders(council_brute_ini1.Squad, council_floor_all);
                ai_berserk(council_brute_ini1.Squad, true);
                await sleep_until(async () => this.g_council_initial);
                wake(new ScriptMethodReference(sc_brutes_berserk));
            }
        }

        [ScriptMethod(279, Lifecycle.Static)]
        public async Task ai_council_left_a()
        {
            if (!(volume_test_objects(tv_council_door_left_a, players())) && device_get_position(council_door_left_a.Entity) == 0F)
            {
                if (this.debug)
                {
                    print("left a");
                }

                ai_place(council_lt_brute_a.Squad);
                ai_place(council_lt_grunt_a.Squad);
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
            if (!(volume_test_objects(tv_council_door_left_b, players())) && device_get_position(council_door_left_b.Entity) == 0F)
            {
                if (this.debug)
                {
                    print("left b");
                }

                ai_place(council_lt_brute_b.Squad);
                ai_place(council_lt_grunt_b.Squad);
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
            if (!(volume_test_objects(tv_council_door_left_c, players())) && device_get_position(council_door_left_c.Entity) == 0F)
            {
                if (this.debug)
                {
                    print("left c");
                }

                ai_place(council_lt_brute_c.Squad);
                ai_place(council_lt_grunt_c.Squad);
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
            if (!(volume_test_objects(tv_council_door_right_a, players())) && device_get_position(council_door_right_a.Entity) == 0F)
            {
                if (this.debug)
                {
                    print("right a");
                }

                ai_place(council_rt_brute_a.Squad);
                ai_place(council_rt_grunt_a.Squad);
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
            if (!(volume_test_objects(tv_council_door_right_b, players())) && device_get_position(council_door_right_b.Entity) == 0F)
            {
                if (this.debug)
                {
                    print("right b");
                }

                ai_place(council_rt_brute_b.Squad);
                ai_place(council_rt_grunt_b.Squad);
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
            if (!(volume_test_objects(tv_council_door_right_c, players())) && device_get_position(council_door_right_c.Entity) == 0F)
            {
                if (this.debug)
                {
                    print("right c");
                }

                ai_place(council_rt_brute_c.Squad);
                ai_place(council_rt_grunt_c.Squad);
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
                print("right front");
            }

            begin_random(async () =>
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
                print("right back");
            }

            begin_random(async () =>
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
                print("left front");
            }

            begin_random(async () =>
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
                print("left back");
            }

            begin_random(async () =>
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
                print("front");
            }

            begin_random(async () =>
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
                print("back");
            }

            begin_random(async () =>
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
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_council_rt_fr, players()))
                {
                    ai_set_orders(council_prophets_floor, council_rt_fr);
                }
                else if (volume_test_objects(tv_council_rt_bk, players()))
                {
                    ai_set_orders(council_prophets_floor, council_rt_bk);
                }
                else if (volume_test_objects(tv_council_lt_fr, players()))
                {
                    ai_set_orders(council_prophets_floor, council_lt_fr);
                }
                else if (volume_test_objects(tv_council_lt_bk, players()))
                {
                    ai_set_orders(council_prophets_floor, council_lt_bk);
                }

                return this.g_council_orders;
            });
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task ai_council_upper_migrate()
        {
            await sleep_until(async () => (short)ai_living_count(council_prophets_floor) <= 0 || (float)ai_strength(council_prophets_upper) <= 0.4F, 30, 30 * 40);
            await sleep(30);
            ai_migrate(council_prophets_upper, council_rt_brute_a.Squad);
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task ai_council_upper()
        {
            await sleep_until(async () => (short)ai_living_count(council_prophets) <= 2);
            await sleep(120);
            begin_random(async () =>
            {
                if (this.g_council_upper)
                {
                    ai_place(council_rt_upper_brute_a.Squad);
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
                    ai_place(council_rt_upper_brute_b.Squad);
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
                    ai_place(council_rt_upper_brute_c.Squad);
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
                    ai_place(council_lt_upper_brute_a.Squad);
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
                    ai_place(council_lt_upper_brute_b.Squad);
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
                    ai_place(council_lt_upper_brute_c.Squad);
                    this.g_council_upper_count = (short)(this.g_council_upper_count + 1);
                    if (this.g_council_upper_count == this.g_council_upper_limit)
                    {
                        this.g_council_upper = false;
                    }
                }
            });
            wake(new ScriptMethodReference(ai_council_upper_migrate));
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

            data_mine_set_mission_segment("enc_council_wave_1");
            await this.sc_council_mid();
            game_save();
            await sleep(120);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(council_prophets_floor) <= 0);
                game_save();
                await sleep((short)random_range(this.sleep_lower_bound, this.sleep_upper_bound));
                if (this.debug)
                {
                    print("begin wave 1");
                }

                this.g_council_wave = true;
                this.g_council_count = 0;
                if (volume_test_objects(tv_council_fr, players()))
                {
                    await this.ai_council_fr();
                }
                else if (volume_test_objects(tv_council_rt_fr, players()))
                {
                    await this.ai_council_rt_fr();
                }
                else if (volume_test_objects(tv_council_rt_bk, players()))
                {
                    await this.ai_council_rt_bk();
                }
                else if (volume_test_objects(tv_council_lt_fr, players()))
                {
                    await this.ai_council_lt_fr();
                }
                else if (volume_test_objects(tv_council_lt_bk, players()))
                {
                    await this.ai_council_lt_bk();
                }
                else if (volume_test_objects(tv_council_bk, players()))
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
                print("wave 1 over");
            }

            this.g_council_floor_wave = false;
            this.g_council_floor_wave_count = 0;
            await sleep_until(async () => (short)ai_living_count(council_prophets_floor) <= 0);
            await sleep(150);
            data_mine_set_mission_segment("enc_council_pedestal");
            game_save();
            await sleep(15);
            if (this.debug)
            {
                print("pedestal, sides and upper");
            }

            ai_place(council_brute_ped.a);
            ai_place(council_brute_ped.b);
            if (await this.difficulty_legendary())
            {
                ai_place(council_brute_ped.chief);
                wake(new ScriptMethodReference(sc_ledge_chieftan));
            }

            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                ai_place(council_rt_grunt_c.Squad, 1);
                ai_place(council_lt_grunt_c.Squad, 1);
            }

            if (await this.difficulty_legendary())
            {
                ai_place(council_rt_grunt_b.Squad, 1);
                ai_place(council_lt_grunt_b.Squad, 1);
            }

            await sleep(30);
            wake(new ScriptMethodReference(ai_council_upper));
            await sleep(30);
            device_set_position(council_ped.Entity, 0F);
            await sleep(5);
            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                await sleep_until(async () =>
                {
                    await sleep_until(async () => (short)ai_living_count(council_prophets) <= 0);
                    game_save();
                    data_mine_set_mission_segment("enc_council_wave_2");
                    await sleep((short)random_range(this.sleep_lower_bound, this.sleep_upper_bound));
                    if (this.debug)
                    {
                        print("begin wave 2");
                    }

                    this.g_council_wave = true;
                    this.g_council_count = 0;
                    if (volume_test_objects(tv_council_fr, players()))
                    {
                        await this.ai_council_fr();
                    }
                    else if (volume_test_objects(tv_council_rt_fr, players()))
                    {
                        await this.ai_council_rt_fr();
                    }
                    else if (volume_test_objects(tv_council_rt_bk, players()))
                    {
                        await this.ai_council_rt_bk();
                    }
                    else if (volume_test_objects(tv_council_lt_fr, players()))
                    {
                        await this.ai_council_lt_fr();
                    }
                    else if (volume_test_objects(tv_council_lt_bk, players()))
                    {
                        await this.ai_council_lt_bk();
                    }
                    else if (volume_test_objects(tv_council_bk, players()))
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

            print("wave 2 over");
            this.g_council_floor_wave = false;
            this.g_council_over = true;
        }

        [ScriptMethod(295, Lifecycle.CommandScript)]
        public async Task cs_grand_a_grunt_a()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("grand_a/p0"), 2F), 
                    async () => await sleep((short)random_range(0, 15)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("grand_a/p1"), 2F), 
                    async () => await sleep((short)random_range(0, 15)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("grand_a/p2"), 2F), 
                    async () => await sleep((short)random_range(0, 15)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("grand_a/p3"), 2F), 
                    async () => await sleep((short)random_range(0, 15)));
                return false;
            });
        }

        [ScriptMethod(296, Lifecycle.CommandScript)]
        public async Task cs_grand_a_grunt_b()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("grand_a/p4"), 2F), 
                    async () => await sleep((short)random_range(0, 15)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("grand_a/p5"), 2F), 
                    async () => await sleep((short)random_range(0, 15)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("grand_a/p6"), 2F), 
                    async () => await sleep((short)random_range(0, 15)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("grand_a/p7"), 2F), 
                    async () => await sleep((short)random_range(0, 15)));
                return false;
            });
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task create_ledge_columns()
        {
            begin_random(async () => object_create(ledge_col_a), 
                async () => await sleep((short)random_range(45, 90)), 
                async () => object_create(ledge_col_b), 
                async () => await sleep((short)random_range(45, 90)), 
                async () => object_create(ledge_col_c), 
                async () => await sleep((short)random_range(45, 90)), 
                async () => object_create(ledge_col_d), 
                async () => await sleep((short)random_range(45, 90)), 
                async () => object_create(ledge_col_e), 
                async () => await sleep((short)random_range(45, 90)), 
                async () => object_create(ledge_col_f), 
                async () => await sleep((short)random_range(45, 90)));
        }

        [ScriptMethod(298, Lifecycle.CommandScript)]
        public async Task cs_ledge_jackals_lt()
        {
            cs_abort_on_alert(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("dervish_ledge/lt_0"));
                cs_go_to(GetReference<ISpatialPoint>("dervish_ledge/lt_1"));
                return false;
            });
        }

        [ScriptMethod(299, Lifecycle.CommandScript)]
        public async Task cs_ledge_jackals_rt()
        {
            cs_abort_on_alert(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("dervish_ledge/rt_0"));
                cs_go_to(GetReference<ISpatialPoint>("dervish_ledge/rt_1"));
                return false;
            });
        }

        [ScriptMethod(300, Lifecycle.CommandScript)]
        public async Task cs_ledge_brute_a()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_go_to(GetReference<ISpatialPoint>("dervish_ledge/b1_2"));
        }

        [ScriptMethod(301, Lifecycle.CommandScript)]
        public async Task cs_ledge_brute_b()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_go_to(GetReference<ISpatialPoint>("dervish_ledge/b2_2"));
        }

        [ScriptMethod(302, Lifecycle.CommandScript)]
        public async Task cs_lift_jump()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("dervish_ledge/p0"));
            cs_jump_to_point(0F, 5F);
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task ledge_fr_orders()
        {
            ai_set_orders(ledge_lift_brute_rt.Squad, ledge_rt_fr);
            ai_set_orders(ledge_lift_brute_lt.Squad, ledge_lt_fr);
            ai_set_orders(ledge_lift_grunt_rt.Squad, ledge_minor_rt_fr);
            ai_set_orders(ledge_lift_grunt_lt.Squad, ledge_minor_lt_fr);
            ai_set_orders(ledge_jackal_right.Squad, ledge_minor_rt_fr);
            ai_set_orders(ledge_jackal_left.Squad, ledge_minor_lt_fr);
            ai_set_orders(ledge_lift_chieftan.Squad, ledge_chieftan);
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task ledge_bk_orders()
        {
            ai_set_orders(ledge_lift_brute_rt.Squad, ledge_rt_bk);
            ai_set_orders(ledge_lift_brute_lt.Squad, ledge_lt_bk);
            ai_set_orders(ledge_lift_grunt_rt.Squad, ledge_minor_rt_bk);
            ai_set_orders(ledge_lift_grunt_lt.Squad, ledge_minor_lt_bk);
            ai_set_orders(ledge_jackal_right.Squad, ledge_minor_rt_bk);
            ai_set_orders(ledge_jackal_left.Squad, ledge_minor_lt_bk);
            ai_set_orders(ledge_lift_chieftan.Squad, ledge_chieftan_lift);
        }

        [ScriptMethod(305, Lifecycle.Dormant)]
        public async Task ai_dervish_ledge_orders()
        {
            await sleep_until(async () => (short)ai_combat_status(dervish_ledge_prophets) >= this.ai_combat_status_active);
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_dervish_ledge_fr, players()))
                {
                    await sleep((short)random_range(5, 30));
                    await this.ledge_fr_orders();
                }
                else if (volume_test_objects(tv_dervish_ledge_bk, players()))
                {
                    await sleep((short)random_range(5, 30));
                    await this.ledge_bk_orders();
                }
                else if (volume_test_objects(tv_dervish_ledge_lift, players()))
                {
                    await sleep((short)random_range(5, 30));
                    await this.ledge_bk_orders();
                }

                return this.g_dervish_ledge_orders;
            });
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task cs_ledge_turrets_left()
        {
            cs_enable_pathfinding_failsafe(true);
            if (!(this.g_ledge_turret_left))
            {
                this.g_ledge_turret_left = true;
                cs_go_to(GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p2"));
                cs_deploy_turret(GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p2"));
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p3"));
                cs_deploy_turret(GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p3"));
            }
        }

        [ScriptMethod(307, Lifecycle.CommandScript)]
        public async Task cs_ledge_turrets_right()
        {
            cs_enable_pathfinding_failsafe(true);
            if (!(this.g_ledge_turret_right))
            {
                this.g_ledge_turret_right = true;
                cs_go_to(GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p0"));
                cs_deploy_turret(GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p0"));
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p1"));
                cs_deploy_turret(GetReference<ISpatialPoint>("dervish_ledge_turret/deploy_p1"));
            }
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task ai_ledge_lift()
        {
            ai_place(ledge_lift_grunt_lt.Squad, 2);
            ai_place(ledge_lift_grunt_rt.Squad);
            await sleep(120);
            if ((short)ai_living_count(dervish_ledge_prophets) <= 5 && await this.difficulty_heroic() || await this.difficulty_legendary() && !(volume_test_objects(tv_dervish_ledge_lift, players())))
            {
                ai_place(ledge_lift_grunt_lt.Squad);
                ai_place(ledge_lift_grunt_rt.Squad, 2);
            }

            await sleep(150);
            await sleep_until(async () => (short)ai_living_count(dervish_ledge_prophets) <= 6);
            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                ai_place(ledge_lift_brute_lt.Squad);
                ai_place(ledge_lift_brute_rt.Squad);
            }

            ai_place(ledge_lift_chieftan.Squad);
            await sleep_until(async () => objects_can_see_object(players(), ai_get_object(ledge_lift_chieftan.Squad), 45F) && volume_test_objects(tv_dervish_ledge_lift, ai_get_object(ledge_lift_chieftan.Squad)), 30, 30 * 20);
            wake(new ScriptMethodReference(sc_ledge_chieftan));
            this.g_music_07a_01 = false;
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task ai_ledge_lower()
        {
            ai_place(ledge_bot_grunts1.Squad);
            ai_place(ledge_bot_jackals1.Squad);
        }

        [ScriptMethod(310, Lifecycle.CommandScript)]
        public async Task cs_hall_a_jackal_ini_a()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_looking(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("hall_a/jackal_patrol_p0"), 1F);
            cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p0"));
            await sleep_until(async () => !(volume_test_objects(tv_hall_a_jackal_patrol, players())) && device_get_position(hall_a_jackal_door.Entity) <= 0F, 5);
            if (!(this.g_corridor_a_active))
            {
                ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(311, Lifecycle.CommandScript)]
        public async Task cs_hall_a_jackal_ini_b()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_looking(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("hall_a/jackal_patrol_p1"), 1F);
            cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p0"));
            await sleep_until(async () => !(volume_test_objects(tv_hall_a_jackal_patrol, players())) && device_get_position(hall_a_jackal_door.Entity) <= 0F, 5);
            if (!(this.g_corridor_a_active))
            {
                ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(312, Lifecycle.CommandScript)]
        public async Task cs_hall_a_jackal_ini_c()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_looking(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("hall_a/jackal_patrol_p2"), 1F);
            cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p0"));
            await sleep_until(async () => !(volume_test_objects(tv_hall_a_jackal_patrol, players())) && device_get_position(hall_a_jackal_door.Entity) <= 0F, 5);
            if (!(this.g_corridor_a_active))
            {
                ai_erase(this.ai_current_actor);
            }
        }

        [ScriptMethod(313, Lifecycle.CommandScript)]
        public async Task cs_hall_a_brute_ini()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/b_p0"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/b_p1"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/b_p2"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/b_p3"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/b_p4"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p0")), 
                    async () => await sleep((short)random_range(45, 90)), 
                    async () => cs_look(false, GetReference<ISpatialPoint>("hall_a/look_p0")), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p1")), 
                    async () => await sleep((short)random_range(45, 90)), 
                    async () => cs_look(false, GetReference<ISpatialPoint>("hall_a/look_p1")), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p2")), 
                    async () => await sleep((short)random_range(45, 90)), 
                    async () => cs_look(false, GetReference<ISpatialPoint>("hall_a/look_p2")), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p3")), 
                    async () => await sleep((short)random_range(45, 90)), 
                    async () => cs_look(false, GetReference<ISpatialPoint>("hall_a/look_p3")));
                return false;
            });
        }

        [ScriptMethod(314, Lifecycle.CommandScript)]
        public async Task cs_hall_a_jackal_ini()
        {
            cs_abort_on_combat_status(this.ai_combat_status_certain);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/j_p0"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/j_p1"), 1F), 
                    async () => begin_random(async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p0")), 
    async () => await sleep((short)random_range(60, 90)), 
    async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p2")), 
    async () => await sleep((short)random_range(60, 90))), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/j_p2"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/j_p3"), 1F), 
                    async () => begin_random(async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p1")), 
    async () => await sleep((short)random_range(60, 90)), 
    async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p3")), 
    async () => await sleep((short)random_range(60, 90))), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/j_p4"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/j_p5"), 1F), 
                    async () => begin_random(async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p0")), 
    async () => await sleep((short)random_range(60, 90)), 
    async () => cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p3")), 
    async () => await sleep((short)random_range(60, 90))), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_a/j_p6"), 1F), 
                    async () => await sleep((short)random_range(0, 45)));
                return false;
            });
        }

        [ScriptMethod(315, Lifecycle.CommandScript)]
        public async Task cs_hall_b_jackal_a()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_looking(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("hall_b/jackal_p0"), 1F);
            cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p0"));
            await sleep_until(async () => !(volume_test_objects(tv_hall_b_jackal, players())) && device_get_position(hall_b_jackal_door.Entity) <= 0F, 5);
            device_one_sided_set(hall_b_jackal_door.Entity, true);
        }

        [ScriptMethod(316, Lifecycle.CommandScript)]
        public async Task cs_hall_b_jackal_b()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_looking(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("hall_b/jackal_p1"), 1F);
            cs_look(true, GetReference<ISpatialPoint>("hall_a/look_p0"));
            await sleep_until(async () => !(volume_test_objects(tv_hall_b_jackal, players())) && device_get_position(hall_b_jackal_door.Entity) <= 0F, 5);
            device_one_sided_set(hall_b_jackal_door.Entity, true);
        }

        [ScriptMethod(317, Lifecycle.CommandScript)]
        public async Task cs_hall_b_brutes()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("hall_b/p0"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_b/p1"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_b/p2"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_b/p3"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("hall_b/p4"), 1F), 
                    async () => await sleep((short)random_range(0, 45)));
                return false;
            });
        }

        [ScriptMethod(318, Lifecycle.CommandScript)]
        public async Task cs_hall_b_wake_grunts()
        {
            if (this.g_corridor_a_active)
            {
                cs_force_combat_status(this.ai_combat_status_alert);
            }
        }

        [ScriptMethod(319, Lifecycle.CommandScript)]
        public async Task cs_room_a_brute_ini()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("room_a/p0"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("room_a/p1"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("room_a/look_p0")), 
                    async () => await sleep((short)random_range(45, 90)), 
                    async () => cs_look(false, GetReference<ISpatialPoint>("room_a/look_p0")), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("room_a/look_p1")), 
                    async () => await sleep((short)random_range(45, 90)), 
                    async () => cs_look(false, GetReference<ISpatialPoint>("hall_a/look_p1")));
                return false;
            });
        }

        [ScriptMethod(320, Lifecycle.CommandScript)]
        public async Task cs_room_a_jackal_ini()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("room_a/p4"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("room_a/p5"), 1F), 
                    async () => await sleep((short)random_range(0, 45)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("room_a/look_p0")), 
                    async () => await sleep((short)random_range(45, 90)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("room_a/look_p1")), 
                    async () => await sleep((short)random_range(45, 90)));
                return false;
            });
        }

        [ScriptMethod(321, Lifecycle.CommandScript)]
        public async Task cs_room_a_brutes_bk()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_look(true, GetReference<ISpatialPoint>("room_a/look_p0")), 
                    async () => await sleep((short)random_range(90, 150)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("room_a/look_p2")), 
                    async () => await sleep((short)random_range(90, 150)), 
                    async () => cs_look(true, GetReference<ISpatialPoint>("room_a/look_p3")), 
                    async () => await sleep((short)random_range(90, 150)));
                return false;
            });
        }

        [ScriptMethod(322, Lifecycle.CommandScript)]
        public async Task cs_room_a_to_jail()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("room_a/stand_p0"));
            cs_move_in_direction(0F, 1F, 180F);
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task room_a_door()
        {
            await sleep_until(async () => device_get_position(room_a_door1.Entity) > 0F, 5);
            this.g_room_a_door = true;
            if (this.debug)
            {
                print("room a door opened");
            }
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task corridor_a_activate()
        {
            await sleep_until(async () => (short)ai_combat_status(hall_a_prophets) >= this.ai_combat_status_active);
            this.g_corridor_a_active = true;
            if (this.debug)
            {
                print("corridor a prophets active");
            }
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task ai_hall_a_prophets()
        {
            if (this.debug)
            {
                print("hall a initial prophets");
            }

            ai_place(hall_a_jackal_patrol_ini.Squad);
            ai_place(hall_a_brute_ini1.Squad);
            ai_place(hall_a_jackal_ini2.Squad);
            await sleep_until(async () => (short)ai_living_count(hall_a_prophets) <= 1 || volume_test_objects(tv_hall_a_bk, players()));
            game_save();
            if (this.g_corridor_a_active)
            {
                if (this.debug)
                {
                    print("hall a reinforcements");
                }

                ai_place(hall_a_brute_rein.Squad);
                ai_place(hall_a_grunt_rein.Squad, (short)pin(6F - (float)ai_living_count(hall_a_prophets), 0F, 2F));
                await sleep(1);
                ai_place(hall_a_brute_rein_bk1.Squad);
                ai_place(hall_a_grunt_rein_bk1.Squad, (short)pin(6F - (float)ai_living_count(hall_a_prophets), 0F, 2F));
            }
        }

        [ScriptMethod(326, Lifecycle.Dormant)]
        public async Task ai_room_a()
        {
            ai_place(room_a_brutes_ini1.Squad);
            ai_place(room_a_jackals_ini.Squad);
            ai_place(room_a_brutes_bk1.Squad);
            await sleep_until(async () => volume_test_objects(tv_room_a_mid, players()) || (short)ai_living_count(room_a_prophets) <= 2 && (short)ai_combat_status(room_a_prophets) >= this.ai_combat_status_active);
            if ((short)ai_combat_status(room_a_prophets) >= this.ai_combat_status_active && (short)ai_living_count(room_a_prophets) <= 2)
            {
                ai_place(room_a_brutes_a.Squad);
                ai_place(room_a_brutes_c.Squad);
                await sleep(1);
                ai_place(room_a_grunts_a.Squad, (short)pin(4F - (float)ai_living_count(room_a_prophets), 0F, 2F));
                ai_place(room_a_grunts_c.Squad, (short)pin(4F - (float)ai_living_count(room_a_prophets), 0F, 2F));
            }

            await sleep_until(async () => volume_test_objects(tv_room_a_bk, players()));
            if ((short)ai_combat_status(room_a_prophets) >= this.ai_combat_status_active && (short)ai_living_count(room_a_prophets) <= 4)
            {
                ai_place(room_a_brutes_b.Squad);
                ai_place(room_a_grunts_b.Squad, (short)pin(4F - (float)ai_living_count(room_a_prophets), 0F, 2F));
            }
        }

        [ScriptMethod(327, Lifecycle.Static)]
        public async Task test_room_a_to_jail()
        {
            wake(new ScriptMethodReference(sc_room_a_down));
            ai_place(room_a_brutes_ini1.Squad);
            ai_place(room_a_jackals_ini.Squad);
            ai_place(room_a_brutes_bk1.Squad);
            await sleep(150);
            cs_run_command_script(room_a_prophets, new ScriptMethodReference(cs_room_a_to_jail));
        }

        [ScriptMethod(328, Lifecycle.CommandScript)]
        public async Task cs_ignore_jail_a_marines()
        {
            cs_abort_on_damage(false);
            ai_disregard(ai_actors(jail_a_marines.Squad), true);
            cs_look_player(true);
            await sleep_until(async () => this.g_jail_a_free);
        }

        [ScriptMethod(329, Lifecycle.CommandScript)]
        public async Task cs_ignore_jail_b_marines()
        {
            cs_abort_on_damage(false);
            ai_disregard(ai_actors(jail_b_marines.Squad), true);
            cs_look_player(true);
            await sleep_until(async () => this.g_jail_b_free);
        }

        [ScriptMethod(330, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_a()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p0"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p1"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p2"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(331, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_b()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p3"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p4"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p5"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_c()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p6"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p7"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p8"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_d()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p9"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p10"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p11"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_e()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p12"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p13"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p14"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(335, Lifecycle.CommandScript)]
        public async Task cs_jail_jackal_ini_f()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p15"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p16"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("jail_jackal_patrol/p17"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task cs_cell_a_jackal_a()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jails/jail_a_p0"), 1F);
                await sleep((short)random_range(5, 45));
                cs_go_to(GetReference<ISpatialPoint>("jails/jail_a_p1"), 1F);
                await sleep((short)random_range(5, 45));
                return false;
            });
        }

        [ScriptMethod(337, Lifecycle.CommandScript)]
        public async Task cs_cell_a_jackal_b()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jails/jail_a_p2"), 1F);
                await sleep((short)random_range(5, 45));
                cs_go_to(GetReference<ISpatialPoint>("jails/jail_a_p3"), 1F);
                await sleep((short)random_range(5, 45));
                return false;
            });
        }

        [ScriptMethod(338, Lifecycle.CommandScript)]
        public async Task cs_cell_a_brute()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jails/jail_a_p4"), 1F);
                await sleep((short)random_range(5, 10));
                cs_go_to(GetReference<ISpatialPoint>("jails/jail_a_p5"), 1F);
                await sleep((short)random_range(5, 10));
                return false;
            });
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task cs_cell_b_brute()
        {
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("jails/jail_b_p0"), 1F);
                await sleep((short)random_range(5, 10));
                cs_go_to(GetReference<ISpatialPoint>("jails/jail_b_p1"), 1F);
                await sleep((short)random_range(5, 10));
                return false;
            });
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task cs_jail_a_marine_a()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_go_to(GetReference<ISpatialPoint>("jails/jail_a_plasma_rifle"));
            await sleep(5);
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3842835351U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await sleep(15);
            unit_add_equipment(ai_get_unit(this.ai_current_actor), jail_a_a, true, true);
            object_destroy(jail_a_plasma_rifle.Entity);
            await sleep(15);
            cs_stop_custom_animation();
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task cs_jail_a_marine_b()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("jails/jail_a_needler"));
            await sleep(5);
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3842835351U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await sleep(15);
            unit_add_equipment(ai_get_unit(this.ai_current_actor), jail_a_b, true, true);
            object_destroy(jail_a_needler.Entity);
            await sleep(15);
            cs_stop_custom_animation();
        }

        [ScriptMethod(342, Lifecycle.CommandScript)]
        public async Task cs_jail_b_marine_a()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("jails/jail_b_carbine"));
            await sleep(5);
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3842835351U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await sleep(15);
            unit_add_equipment(ai_get_unit(this.ai_current_actor), jail_b_a, true, true);
            object_destroy(jail_b_carbine.Entity);
            await sleep(15);
            cs_stop_custom_animation();
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task cs_jail_b_marine_b()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("jails/jail_b_plasma_rifle"));
            await sleep(5);
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3842835351U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await sleep(15);
            unit_add_equipment(ai_get_unit(this.ai_current_actor), jail_b_b, true, true);
            object_destroy(jail_b_plasma_rifle.Entity);
            await sleep(15);
            cs_stop_custom_animation();
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task cs_jail_b_marine_c()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("jails/jail_b_plasma_pistol"));
            await sleep(5);
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\marine\\marine", 3842835351U), "combat:rifle:idle:2:crouch:idle", 0F, true);
            await sleep(15);
            unit_add_equipment(ai_get_unit(this.ai_current_actor), jail_b_c, true, true);
            object_destroy(jail_b_plasma_pistol.Entity);
            await sleep(15);
            cs_stop_custom_animation();
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task ai_cell_a_guards()
        {
            if (this.debug)
            {
                print("cell a guards");
            }

            ai_place(jail_guard_brute_cell_a.Squad);
            ai_place(jail_guard_jackal_cell_a.Squad);
            await sleep(1);
            if (this.g_jail_prophets_ini_active)
            {
                ai_set_orders(jail_cell_outer_guards_a, jail_guard_alert_cell_a);
            }
        }

        [ScriptMethod(346, Lifecycle.Dormant)]
        public async Task ai_cell_b_guards()
        {
            if (this.debug)
            {
                print("cell b guards");
            }

            ai_place(jail_guard_brute_cell_b.Squad);
            ai_place(jail_guard_jackal_cell_b.Squad);
            await sleep(1);
            if (this.g_jail_prophets_ini_active)
            {
                ai_set_orders(jail_cell_outer_guards_b, jail_guard_alert_cell_b);
            }
        }

        [ScriptMethod(347, Lifecycle.CommandScript)]
        public async Task cs_lift_grunt_a()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("jail_turret/p0"));
            cs_deploy_turret(GetReference<ISpatialPoint>("jail_turret/p0"));
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task cs_lift_grunt_b()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("jail_turret/p1"));
            cs_deploy_turret(GetReference<ISpatialPoint>("jail_turret/p1"));
        }

        [ScriptMethod(349, Lifecycle.Dormant)]
        public async Task jail_a_doors()
        {
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_jail1.p);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), jail_ped_p.Entity, "effect");
            await sleep_until(async () => this.jail_a_doors_open);
            ai_disregard(ai_actors(jail_a_marines.Squad), false);
            ai_set_orders(jail_a_marines.Squad, jail_marines_mid);
            this.g_jail_a_free = true;
            await sleep(15);
            cs_run_command_script(jail_a_marines.a, new ScriptMethodReference(cs_jail_a_marine_a));
            cs_run_command_script(jail_a_marines.b, new ScriptMethodReference(cs_jail_a_marine_b));
            if (this.g_jail_a_finished || this.g_jail_b_finished)
            {
                wake(new ScriptMethodReference(sc_second_cell));
            }
            else
            {
                wake(new ScriptMethodReference(sc_first_cell));
            }

            await sleep_until(async () => !(volume_test_objects_all(tv_cell_a, players())));
            await sleep(90);
            this.g_jail_a_finished = true;
        }

        [ScriptMethod(350, Lifecycle.Dormant)]
        public async Task jail_b_doors()
        {
            await this.erase_cortana();
            await sleep(1);
            ai_place(cortana_jail1.q);
            await sleep(5);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4248968065U), jail_ped_q.Entity, "effect");
            await sleep_until(async () => this.jail_b_doors_open);
            ai_disregard(ai_actors(jail_b_marines.Squad), false);
            ai_set_orders(jail_b_marines.Squad, jail_marines_bot);
            this.g_jail_b_free = true;
            await sleep(15);
            cs_run_command_script(jail_b_marines.a, new ScriptMethodReference(cs_jail_b_marine_a));
            cs_run_command_script(jail_b_marines.b, new ScriptMethodReference(cs_jail_b_marine_b));
            cs_run_command_script(jail_b_marines.c, new ScriptMethodReference(cs_jail_b_marine_c));
            if (this.g_jail_a_finished || this.g_jail_b_finished)
            {
                wake(new ScriptMethodReference(sc_second_cell));
            }
            else
            {
                wake(new ScriptMethodReference(sc_first_cell));
            }

            await sleep_until(async () => !(volume_test_objects_all(tv_cell_b, players())));
            await sleep(60);
            this.g_jail_b_finished = true;
        }

        [ScriptMethod(351, Lifecycle.Dormant)]
        public async Task cor_open_a()
        {
            await sleep_until(async () => (short)ai_living_count(cell_a_prophets) <= 0);
            await sleep(60);
            begin_random(async () => device_group_set(jail_a_door_b.Entity, jail_a_group_a, 1F), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => device_group_set(jail_a_door_a.Entity, jail_a_group_b, 1F), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => device_group_set(jail_a_door_c.Entity, jail_a_group_c, 1F), 
                async () => await sleep((short)random_range(5, 15)));
            this.jail_a_doors_open = true;
        }

        [ScriptMethod(352, Lifecycle.Dormant)]
        public async Task cor_open_b()
        {
            await sleep_until(async () => (short)ai_living_count(cell_b_prophets) <= 0);
            await sleep(60);
            begin_random(async () => device_group_set(jail_b_door_c.Entity, jail_b_group_a, 1F), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => device_group_set(jail_b_door_b.Entity, jail_b_group_b, 1F), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => device_group_set(jail_b_door_a.Entity, jail_b_group_c, 1F), 
                async () => await sleep((short)random_range(5, 15)));
            this.jail_b_doors_open = true;
        }

        [ScriptMethod(353, Lifecycle.Dormant)]
        public async Task ai_jail_a()
        {
            data_mine_set_mission_segment("enc_jail_cell_a");
            game_save();
            await sleep(60);
            wake(new ScriptMethodReference(sc_cell_a_ent));
            wake(new ScriptMethodReference(ai_cell_a_guards));
            await sleep(15);
            await sleep_until(async () => volume_test_objects(tv_jail_a_ent, players()), 1);
            ai_place(jail_a_marines.Squad);
            ai_place(jail_a_brute1.Squad);
            ai_place(jail_a_jackals1.Squad);
            await sleep(30);
            wake(new ScriptMethodReference(cor_open_a));
            wake(new ScriptMethodReference(jail_a_doors));
            await sleep_until(async () => this.g_jail_a_finished);
            game_save();
        }

        [ScriptMethod(354, Lifecycle.Dormant)]
        public async Task ai_jail_b()
        {
            data_mine_set_mission_segment("enc_jail_cell_b");
            game_save();
            await sleep(60);
            wake(new ScriptMethodReference(sc_cell_b_ent));
            wake(new ScriptMethodReference(ai_cell_b_guards));
            await sleep(15);
            await sleep_until(async () => volume_test_objects(tv_jail_b_ent, players()), 1);
            ai_place(jail_b_marines.Squad);
            ai_place(jail_b_brutes.Squad);
            ai_place(jail_b_grunts1.Squad);
            await sleep(30);
            wake(new ScriptMethodReference(cor_open_b));
            wake(new ScriptMethodReference(jail_b_doors));
            await sleep_until(async () => this.g_jail_b_finished);
            game_save();
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task ai_jail_door_c()
        {
            if (this.debug)
            {
                print("door c");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_c.Squad);
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
                    ai_place(jail_grunt_c.Squad);
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
                    ai_place(jail_jackal_c.Squad);
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
                print("door d");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_d.Squad);
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
                    ai_place(jail_grunt_d.Squad);
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
                    ai_place(jail_jackal_d.Squad);
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
                print("door e");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_e.Squad);
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
                    ai_place(jail_grunt_e.Squad);
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
                    ai_place(jail_jackal_e.Squad);
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
                print("door f");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_f.Squad);
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
                    ai_place(jail_grunt_f.Squad);
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
                    ai_place(jail_jackal_f.Squad);
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
                print("door g");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_g.Squad);
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
                    ai_place(jail_grunt_g.Squad);
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
                    ai_place(jail_jackal_g.Squad);
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
                print("door i");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_i.Squad);
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
                    ai_place(jail_grunt_i.Squad);
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
                    ai_place(jail_jackal_i.Squad);
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
                print("door j");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_j.Squad);
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
                    ai_place(jail_grunt_j.Squad);
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
                    ai_place(jail_jackal_j.Squad);
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
                print("door k");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_k.Squad);
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
                    ai_place(jail_grunt_k.Squad);
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
                    ai_place(jail_jackal_k.Squad);
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
                print("door l");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_l.Squad);
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
                    ai_place(jail_grunt_l.Squad);
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
                    ai_place(jail_jackal_l.Squad);
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
                print("door m");
            }

            begin_random(async () =>
            {
                if (this.g_jail_door)
                {
                    ai_place(jail_brute_m.Squad);
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
                    ai_place(jail_grunt_m.Squad);
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
                    ai_place(jail_jackal_m.Squad);
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
                print("jail spawner!!!!");
            }

            game_save_no_timeout();
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

            begin_random(async () =>
            {
                if (this.g_jail_spawner)
                {
                    if (device_get_position(jail_door_c.Entity) <= 0F && !(volume_test_objects(tv_jail_door_c, players())))
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
                    if (device_get_position(jail_door_d.Entity) <= 0F && !(volume_test_objects(tv_jail_door_d, players())))
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
                    if (device_get_position(jail_door_e.Entity) <= 0F && !(volume_test_objects(tv_jail_door_e, players())))
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
                    if (device_get_position(jail_door_f.Entity) <= 0F && !(volume_test_objects(tv_jail_door_f, players())))
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
                    if (device_get_position(jail_door_g.Entity) <= 0F && !(volume_test_objects(tv_jail_door_g, players())))
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
                    if (device_get_position(jail_door_i.Entity) <= 0F && !(volume_test_objects(tv_jail_door_i, players())))
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
                    if (device_get_position(jail_door_j.Entity) <= 0F && !(volume_test_objects(tv_jail_door_j, players())))
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
                    if (device_get_position(jail_door_k.Entity) <= 0F && !(volume_test_objects(tv_jail_door_k, players())))
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
                    if (device_get_position(jail_door_l.Entity) <= 0F && !(volume_test_objects(tv_jail_door_l, players())))
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
                    if (device_get_position(jail_door_m.Entity) <= 0F && !(volume_test_objects(tv_jail_door_m, players())))
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
            await sleep_until(async () => volume_test_objects(tv_jail_top, players()) && (short)ai_living_count(jail_prophets) <= 2, 30, 30 * 30);
            data_mine_set_mission_segment("enc_jail_down_lift");
            await sleep(60);
            wake(new ScriptMethodReference(sc_lift_reins));
            begin_random(async () => ai_place(jail_jackals_down.Squad), 
                async () => await sleep_until(async () => volume_test_objects_all(tv_jail_top, ai_actors(jail_jackals_down.Squad)), 30, 450), 
                async () => ai_place(jail_grunts_down.Squad), 
                async () => await sleep_until(async () => volume_test_objects_all(tv_jail_top, ai_actors(jail_grunts_down.Squad)), 30, 450));
            ai_place(jail_brutes_down.Squad);
            await sleep_until(async () => volume_test_objects_all(tv_jail_top, ai_actors(jail_brutes_down.Squad)), 30, 450);
            await sleep(90);
            this.g_jail_round_lift_spawned = true;
            wake(new ScriptMethodReference(sc_jail_clear));
        }

        [ScriptMethod(367, Lifecycle.Dormant)]
        public async Task ai_prophets_ini_active()
        {
            await sleep_until(async () => (short)ai_combat_status(jail_prophets) >= this.ai_combat_status_active);
            if (this.debug)
            {
                print("jail prophets active");
            }

            this.g_jail_prophets_ini_active = true;
            ai_set_orders(jail_grunts_ini1.Squad, jail_cov_top);
            ai_set_orders(jail_jackals_ini1.Squad, jail_cov_top);
            await sleep_until(async () => (short)ai_living_count(jail_prophets) <= 2);
            await this.ai_jail_spawner();
        }

        [ScriptMethod(368, Lifecycle.CommandScript)]
        public async Task cs_room_b_brute_ini_a()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("room_b/p0"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("room_b/p1"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(369, Lifecycle.CommandScript)]
        public async Task cs_room_b_brute_ini_b()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("room_b/p2"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("room_b/p3"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(370, Lifecycle.CommandScript)]
        public async Task cs_room_b_brute_ini_c()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("room_b/p4"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("room_b/p5"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(371, Lifecycle.Dormant)]
        public async Task ai_room_b_buggers()
        {
            ai_place(room_b_buggers1.Squad);
            await sleep_until(async () => (short)ai_living_count(room_b_buggers1.Squad) <= 2);
            if (volume_test_objects_all(tv_room_b, players()) && device_get_position(room_b_exit.Entity) == 0F)
            {
                ai_place(room_b_buggers1.Squad);
            }
        }

        [ScriptMethod(372, Lifecycle.Dormant)]
        public async Task ai_corridor_b()
        {
            if ((float)ai_living_count(corridor_b_prophets) + (float)ai_living_count(corridor_b_covenant) <= 8F)
            {
                ai_place(hall_c_elites1.Squad);
            }

            ai_place(hall_c_buggers1.Squad);
            await sleep(1);
            await sleep_until(async () => (short)ai_living_count(corridor_b_prophets) <= 2);
            ai_place(hall_c_brute_reins.Squad);
        }

        [ScriptMethod(373, Lifecycle.Dormant)]
        public async Task ai_ext_a_elite_ini()
        {
            ai_place(ext_a_elite_ini1.Squad);
            await sleep_until(async () => (short)ai_living_count(ext_a_brute_ini1.Squad) <= 0);
            ai_migrate(ext_a_elite_ini1.Squad, ext_a_watch_elites.Squad);
        }

        [ScriptMethod(374, Lifecycle.Dormant)]
        public async Task ai_ext_a_brute_ini()
        {
            ai_place(ext_a_brute_ini1.Squad);
            await sleep_until(async () => (short)ai_living_count(ext_a_elite_ini1.Squad) <= 0);
            ai_migrate(ext_a_brute_ini1.Squad, ext_a_watch_brutes1.Squad);
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task ai_ext_a_hunters()
        {
            ai_place(ext_a_hunters.Squad);
            await sleep(150);
            await sleep_until(async () => (short)ai_living_count(ext_a_prophets) <= 4 || volume_test_objects(tv_ext_a_mid, players()));
            if ((float)ai_living_count(ext_a_prophets) + (float)ai_living_count(ext_a_covenant) <= 6F)
            {
                ai_place(ext_a_brute_door1.Squad);
            }
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task ai_ext_a_prophet_migrate()
        {
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(ext_a_covenant) <= 0)
                {
                    ai_set_orders(ext_a_watch_brutes1.Squad, ext_a_prophets_follow);
                    ai_set_orders(ext_a_brute_door1.Squad, ext_a_prophets_follow);
                    ai_set_orders(ext_a_brute_ini1.Squad, ext_a_prophets_follow);
                    ai_set_orders(ext_a_buggers1.Squad, ext_a_prophets_follow);
                }

                if ((short)ai_living_count(ext_a_prophets) <= 0)
                {
                    ai_set_orders(ext_a_covenant, ext_a_covenant_follow);
                }

                return false;
            }, 90);
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task ai_ext_a_snipers()
        {
            if (this.g_ext_a_snipers)
            {
                ai_place(ext_a_jackal_snipers_a1.Squad);
                this.g_ext_a_snipers_count = (short)(this.g_ext_a_snipers_count + 1);
                if (this.g_ext_a_snipers_count == this.g_ext_a_snipers_index)
                {
                    this.g_ext_a_snipers = false;
                }
            }

            if (this.g_ext_a_snipers)
            {
                ai_place(ext_a_jackal_snipers_b1.Squad);
                this.g_ext_a_snipers_count = (short)(this.g_ext_a_snipers_count + 1);
                if (this.g_ext_a_snipers_count == this.g_ext_a_snipers_index)
                {
                    this.g_ext_a_snipers = false;
                }
            }

            if (this.g_ext_a_snipers)
            {
                ai_place(ext_a_jackal_snipers_c1.Squad);
                this.g_ext_a_snipers_count = (short)(this.g_ext_a_snipers_count + 1);
                if (this.g_ext_a_snipers_count == this.g_ext_a_snipers_index)
                {
                    this.g_ext_a_snipers = false;
                }
            }

            if (this.g_ext_a_snipers)
            {
                ai_place(ext_a_jackal_snipers_d1.Squad);
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
            await sleep_until(async () => (float)ai_living_count(ext_a_prophets) + (float)ai_living_count(ext_a_covenant) <= 3F);
            if (!(this.g_ext_a_fliers))
            {
                ai_place(ext_a_rangers1.Squad);
                ai_place(ext_a_buggers1.Squad);
            }
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task tram_a_no_save()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_tram_a_no_save, players()))
                {
                    game_save_cancel();
                }

                return false;
            }, 1);
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task tram_b_no_save()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_tram_b_no_save, players()))
                {
                    game_save_cancel();
                }

                return false;
            }, 1);
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task tram_c_no_save()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_tram_c_no_save, players()))
                {
                    game_save_cancel();
                }

                return false;
            }, 1);
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task tram_d_no_save()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_tram_d_no_save, players()))
                {
                    game_save_cancel();
                }

                return false;
            }, 1);
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task ai_garden_a_ini()
        {
            ai_place(garden_a_elites.Squad);
            ai_place(garden_a_grunts.Squad);
            ai_place(garden_a_brute_lt1.Squad);
            ai_place(garden_a_brute_rt1.Squad);
            ai_place(garden_a_jackal_snipers1.Squad);
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task ai_garden_a_rangers()
        {
            await sleep_until(async () => (float)ai_living_count(garden_a_prophet) + (float)ai_living_count(garden_a_covenant) <= 5F);
            ai_place(garden_a_rangers.Squad);
        }

        [ScriptMethod(385, Lifecycle.CommandScript)]
        public async Task cs_garden_a_turret_bk_a()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("garden_a_turrets/p0"));
            cs_deploy_turret(GetReference<ISpatialPoint>("garden_a_turrets/p0"));
        }

        [ScriptMethod(386, Lifecycle.CommandScript)]
        public async Task cs_garden_a_turret_bk_b()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("garden_a_turrets/p1"));
            cs_deploy_turret(GetReference<ISpatialPoint>("garden_a_turrets/p1"));
        }

        [ScriptMethod(387, Lifecycle.Dormant)]
        public async Task garden_a_tram_b_on()
        {
            await sleep_until(async () => volume_test_objects(tv_garden_a_tram_b, players()), 5);
            object_destroy(garden_tram_b_bk.Entity);
            await sleep(30);
            object_create(garden_tram_b);
        }

        [ScriptMethod(388, Lifecycle.CommandScript)]
        public async Task cs_midtower_buggers_hall()
        {
            cs_abort_on_damage(false);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to(GetReference<ISpatialPoint>("midtower/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("midtower/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("midtower/p2"));
            cs_fly_to(GetReference<ISpatialPoint>("midtower/p3"));
            cs_fly_to(GetReference<ISpatialPoint>("midtower/p4"));
            cs_fly_to(GetReference<ISpatialPoint>("midtower/p5"));
            cs_fly_to(GetReference<ISpatialPoint>("midtower/p6"));
        }

        [ScriptMethod(389, Lifecycle.Dormant)]
        public async Task ai_midtower_buggers_rein()
        {
            await sleep_until(async () => volume_test_objects(tv_midtower_mid, players()) || (short)ai_living_count(midtower_prophets) <= 3);
            if ((float)ai_living_count(midtower_prophets) + (float)ai_living_count(midtower_covenant) <= 4F)
            {
                ai_place(midtower_bugger_rein.Squad);
            }

            if (this.debug)
            {
                print("bugger reinforcements");
            }
        }

        [ScriptMethod(390, Lifecycle.Dormant)]
        public async Task ai_midtower_cov_rein()
        {
            await sleep_until(async () => volume_test_objects(tv_midtower_mid, players()) || (short)ai_living_count(midtower_covenant) <= 1 || this.g_midtower_prophet_rein);
            if ((float)ai_living_count(midtower_prophets) + (float)ai_living_count(midtower_covenant) <= 4F)
            {
                ai_place(midtower_elite_reins.Squad);
                if (this.debug)
                {
                    print("covenant reinforcements");
                }

                await sleep(5);
                device_set_position(midtower_exit.Entity, 1F);
            }
        }

        [ScriptMethod(391, Lifecycle.Dormant)]
        public async Task ai_midtower_prophets()
        {
            await sleep_until(async () => volume_test_objects(tv_midtower_bk, players()) || (short)ai_living_count(midtower_prophets) <= 2);
            if (volume_test_objects(tv_midtower_bk, players()))
            {
                ai_place(midtower_brutes1.Squad);
                if ((short)ai_living_count(midtower_prophets) <= 3)
                {
                    ai_place(midtower_jackals1.Squad);
                }

                this.g_midtower_prophet_rein = true;
                if (this.debug)
                {
                    print("exit prophets");
                }
            }

            await sleep(1);
            if (!(this.g_midtower_prophet_rein))
            {
                await sleep_until(async () => volume_test_objects(tv_midtower_bk, players()), 10, 30 * 15);
                ai_place(midtower_brutes1.Squad);
                if ((short)ai_living_count(midtower_prophets) <= 3)
                {
                    ai_place(midtower_jackals1.Squad);
                }

                this.g_midtower_prophet_rein = true;
                if (this.debug)
                {
                    print("exit prophets");
                }
            }
        }

        [ScriptMethod(392, Lifecycle.CommandScript)]
        public async Task cs_garden_b_grunts()
        {
            cs_movement_mode(3);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p0")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p1")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p2")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p3")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p4")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p5")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p6")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p7")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p8")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p9")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p10")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p11")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p12")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p13")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("garden_b/p14")));
                return false;
            });
        }

        [ScriptMethod(393, Lifecycle.CommandScript)]
        public async Task garden_b_brute_berserk()
        {
            ai_berserk(garden_b_brute_ini.Squad, true);
            ai_magically_see(garden_b_prophet, garden_b_covenant);
        }

        [ScriptMethod(394, Lifecycle.Dormant)]
        public async Task ai_ext_b_dump()
        {
            await sleep_until(async () => this.g_ext_b_dump, 30, 30 * 25);
            await sleep_until(async () => volume_test_objects(tv_ext_b_low, players()) || (short)ai_living_count(ext_b_covenant) <= 0 || (short)ai_living_count(ext_b_prophets) <= 0);
            await sleep(60);
            if (this.debug)
            {
                print("--- migrating enemies --- migrating enemies ---");
            }

            ai_migrate(ext_b_covenant, ext_b_cov_dump1.Squad);
            ai_migrate(ext_b_prophets, ext_b_prophet_dump1.Squad);
        }

        [ScriptMethod(395, Lifecycle.Dormant)]
        public async Task ai_ext_b_reins()
        {
            await sleep_until(async () => volume_test_objects(tv_ext_b_low, players()) || (short)ai_living_count(all_enemies) <= 4);
            if (this.debug)
            {
                print("far door covenant");
            }

            ai_place(ext_b_grunt_bk_door1.Squad);
            ai_place(ext_b_elites_bk_door1.Squad, (short)pin(8F - (float)ai_living_count(all_enemies), 1F, 3F));
            await sleep(1);
            await sleep_until(async () => volume_test_objects(tv_ext_b_low, players()) || (short)ai_living_count(all_enemies) <= 4);
            if (this.debug)
            {
                print("lower door brutes");
            }

            ai_place(ext_b_brutes_low_door1.Squad, (short)pin(8F - (float)ai_living_count(all_enemies), 1F, 4F));
        }

        [ScriptMethod(396, Lifecycle.CommandScript)]
        public async Task cs_ext_b_grunts_low()
        {
            cs_movement_mode(3);
            cs_abort_on_damage(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p0")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p1")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p2")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p3")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p4")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p5")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p6")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p7")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("ext_b/p8")));
                return false;
            });
        }

        [ScriptMethod(397, Lifecycle.CommandScript)]
        public async Task cs_maus_hall_grunts()
        {
            cs_movement_mode(3);
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("maus_hall/p0"), 2F), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("maus_hall/p2"), 2F), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("maus_hall/p4"), 2F), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("maus_hall/p5"), 2F), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("maus_hall/p6"), 2F), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("maus_hall/p7"), 2F), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("maus_hall/p8"), 2F), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("maus_hall/p9"), 2F));
                return false;
            });
        }

        [ScriptMethod(398, Lifecycle.Dormant)]
        public async Task maus_door()
        {
            await sleep_until(async () =>
            {
                if ((short)structure_bsp_index() == 4)
                {
                    device_operates_automatically_set(maus_bsp_4_door.Entity, false);
                }
                else if ((short)structure_bsp_index() == 5)
                {
                    device_operates_automatically_set(maus_bsp_4_door.Entity, true);
                }

                return false;
            }, 5);
        }

        [ScriptMethod(399, Lifecycle.CommandScript)]
        public async Task cs_maus_room_elite_lt()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("maus_room/p0"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("maus_room/p1"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("maus_room/p2"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("maus_room/p3"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(400, Lifecycle.CommandScript)]
        public async Task cs_maus_room_elite_rt()
        {
            cs_abort_on_alert(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("maus_room/p4"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("maus_room/p5"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("maus_room/p6"), 1F);
                await sleep((short)random_range(0, 15));
                cs_go_to(GetReference<ISpatialPoint>("maus_room/p7"), 1F);
                await sleep((short)random_range(0, 15));
                return false;
            });
        }

        [ScriptMethod(401, Lifecycle.Dormant)]
        public async Task ai_maus_room_ini()
        {
            ai_place(maus_room_elite_lt1.Squad);
            ai_place(maus_room_elite_rt1.Squad);
            if ((short)ai_living_count(all_enemies) <= 6)
            {
                ai_place(maus_room_grunt_lt1.Squad, (short)pin(6F - (float)ai_living_count(all_enemies), 0F, 2F));
                ai_place(maus_room_grunt_rt1.Squad, (short)pin(6F - (float)ai_living_count(all_enemies), 0F, 2F));
            }

            await sleep_until(async () => volume_test_objects(tv_maus_room_bk, players()) || (short)ai_living_count(maus_room_covenant) <= 2);
            ai_place(maus_room_lt_elite_reins.Squad, (short)pin(8F - (float)ai_living_count(all_enemies), 0F, 1F));
            ai_place(maus_room_rt_elite_reins.Squad, (short)pin(8F - (float)ai_living_count(all_enemies), 0F, 1F));
            await sleep(1);
            ai_place(maus_room_lt_grunt_reins.Squad, (short)pin(6F - (float)ai_living_count(all_enemies), 0F, 2F));
            ai_place(maus_room_rt_grunt_reins.Squad, (short)pin(6F - (float)ai_living_count(all_enemies), 0F, 2F));
        }

        [ScriptMethod(402, Lifecycle.Dormant)]
        public async Task ai_maus_bridge_ini()
        {
            if (this.debug)
            {
                print("initial bridge");
            }

            if ((short)ai_living_count(all_enemies) < 4)
            {
                ai_place(maus_bridge_elite_turret.Squad, 2);
            }
            else
            {
                ai_place(maus_bridge_elite_turret.Squad, 1);
            }

            ai_place(maus_bridge_elites_ini1.Squad);
            ai_place(maus_bridge_brutes_ini.Squad, (short)pin(10F - (float)ai_living_count(all_enemies), 0F, 3F));
            ai_place(maus_bridge_jackals_ini.Squad);
            await sleep_until(async () => this.g_maus_bridge_fr || (bool)ai_trigger_test("maus_bridge_elites_ini", maus_bridge_elites_ini1.Squad) || (short)ai_living_count(maus_bridge_prophets) <= 1);
            await sleep(1);
            if (this.debug)
            {
                print("bugger reinforcements");
            }

            ai_place(maus_bridge_buggers_ini1.Squad, (short)pin(11F - (float)ai_living_count(all_enemies), 0F, 5F));
        }

        [ScriptMethod(403, Lifecycle.Dormant)]
        public async Task ai_maus_inner_order_transitions()
        {
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(maus_inner_prophets) <= 0)
                {
                    ai_vehicle_exit(maus_inner_turrets.Squad);
                    ai_vehicle_reserve(ai_vehicle_get_from_starting_location(maus_inner_turrets.a), true);
                    ai_vehicle_reserve(ai_vehicle_get_from_starting_location(maus_inner_turrets.b), true);
                    await sleep(60);
                    ai_set_orders(maus_inner_elites_ini1.Squad, maus_inner_follow);
                    ai_set_orders(maus_inner_turrets.Squad, maus_inner_follow);
                }

                if ((short)ai_living_count(maus_inner_elites_ini1.Squad) <= 0 && (short)ai_living_count(maus_inner_prophets) <= 0)
                {
                    ai_set_orders(maus_inner_hunters_ini.Squad, maus_inner_follow);
                }

                if ((short)ai_living_count(maus_inner_covenant) <= 0)
                {
                    ai_set_orders(maus_inner_prophets, maus_inner_follow);
                }

                return this.g_maus_inner_order_trans;
            }, 60);
        }

        [ScriptMethod(404, Lifecycle.Dormant)]
        public async Task ai_maus_inner_brute_reins()
        {
            await sleep_until(async () => (short)ai_living_count(maus_inner_brutes_ini1.Squad) <= 0);
            await sleep(90);
            ai_place(maus_inner_brutes_rein.Squad);
            await sleep(1);
            wake(new ScriptMethodReference(ai_maus_inner_order_transitions));
        }

        [ScriptMethod(405, Lifecycle.Static)]
        public async Task ai_maus_inner_brute_a()
        {
            if (this.debug)
            {
                print("door a");
            }

            if (!(volume_test_objects(tv_maus_inner_door_a, players())) && device_get_position(maus_inner_door_a.Entity) == 0F)
            {
                ai_place(maus_inner_brutes_a.Squad);
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
                print("door b");
            }

            if (!(volume_test_objects(tv_maus_inner_door_b, players())) && device_get_position(maus_inner_door_b.Entity) == 0F)
            {
                ai_place(maus_inner_brutes_b.Squad);
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
                print("door c");
            }

            if (!(volume_test_objects(tv_maus_inner_door_c, players())) && device_get_position(maus_inner_door_c.Entity) == 0F)
            {
                ai_place(maus_inner_brutes_c.Squad);
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
                print("door d");
            }

            if (!(volume_test_objects(tv_maus_inner_door_d, players())) && device_get_position(maus_inner_door_d.Entity) == 0F)
            {
                ai_place(maus_inner_brutes_d.Squad);
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
                print("door e");
            }

            if (!(volume_test_objects(tv_maus_inner_door_e, players())) && device_get_position(maus_inner_door_e.Entity) == 0F)
            {
                ai_place(maus_inner_brutes_e.Squad);
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
                print("door f");
            }

            if (!(volume_test_objects(tv_maus_inner_door_f, players())) && device_get_position(maus_inner_door_f.Entity) == 0F)
            {
                ai_place(maus_inner_brutes_f.Squad);
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

            await sleep_until(async () =>
            {
                this.g_maus_inner = true;
                this.g_maus_inner_count = 0;
                await sleep_until(async () => (short)ai_living_count(maus_inner_prophets) <= 1);
                await sleep((short)random_range(this.sleep_lower_bound, this.sleep_upper_bound));
                begin_random(async () =>
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
                await sleep((short)random_range(this.sleep_lower_bound, this.sleep_upper_bound));
                if ((short)random_range(0, 2) == 0)
                {
                    ai_place(maus_inner_buggers_lt.Squad);
                }
                else
                {
                    ai_place(maus_inner_buggers_rt.Squad);
                }

                await sleep(1);
                ai_set_orders(maus_inner_buggers, maus_inner_follow);
                this.g_maus_inner_wave_count = (short)(this.g_maus_inner_wave_count + 1);
                if (this.g_maus_inner_wave_count == this.g_maus_inner_wave_limit)
                {
                    this.g_maus_inner_wave_pause = false;
                    await sleep_until(async () => this.g_maus_inner_wave_pause);
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
            await sleep_until(async () => !(volume_test_objects(tv_maus_ent_door_a, players())) && device_get_position(maus_ent_door_a.Entity) <= 0F && !(volume_test_objects(tv_maus_ent_door_b, players())) && device_get_position(maus_ent_door_b.Entity) <= 0F);
            ai_place(maus_inner_elites_ultra.Squad);
            await sleep(45);
            await sleep_until(async () => !(volume_test_objects(tv_maus_ent_door_a, players())) && device_get_position(maus_ent_door_a.Entity) <= 0F && !(volume_test_objects(tv_maus_ent_door_b, players())) && device_get_position(maus_ent_door_b.Entity) <= 0F);
            ai_place(maus_inner_elites_spec.Squad);
            await sleep(45);
            await sleep_until(async () => !(volume_test_objects(tv_maus_ent_door_a, players())) && device_get_position(maus_ent_door_a.Entity) <= 0F && !(volume_test_objects(tv_maus_ent_door_b, players())) && device_get_position(maus_ent_door_b.Entity) <= 0F);
            ai_place(maus_inner_elite_zealot.Squad);
        }

        [ScriptMethod(413, Lifecycle.Dormant)]
        public async Task enc_council_chamber()
        {
            data_mine_set_mission_segment("enc_council_ini");
            if (this.debug)
            {
                print("initialize council chamber encounters");
            }

            game_save();
            object_hide(holo_generator.Entity, false);
            device_set_position_immediate(council_ped.Entity, 0.75F);
            device_set_position(council_ped.Entity, 1F);
            ai_place(council_grunt_ini.Squad);
            ai_place(council_brute_ini1.Squad);
            wake(new ScriptMethodReference(ai_council_brutes_berserk));
            await sleep(90);
            wake(new ScriptMethodReference(sc_council_ini));
            await sleep(90);
            device_one_sided_set(council_door_left_a.Entity, true);
            device_one_sided_set(council_door_left_b.Entity, true);
            device_one_sided_set(council_door_left_c.Entity, true);
            device_one_sided_set(council_door_right_a.Entity, true);
            device_one_sided_set(council_door_right_b.Entity, true);
            device_one_sided_set(council_door_right_c.Entity, true);
            wake(new ScriptMethodReference(ai_council_orders));
            await sleep_until(async () => (short)ai_living_count(council_prophets_floor) <= 0);
            wake(new ScriptMethodReference(ai_council_floor_spawn));
            await sleep_until(async () => (short)ai_living_count(prophets) <= 0 && this.g_council_over);
            await sleep(75);
            wake(new ScriptMethodReference(music_07a_01));
            wake(new ScriptMethodReference(sc_council_exit));
            await sleep_until(async () => device_get_position(council_exit.Entity) >= 0.8F);
            ai_place(grand_a_grunts.Squad);
            await sleep_until(async () => volume_test_objects(tv_dervish_grand_hall, players()), 10);
            data_mine_set_mission_segment("enc_grand_a");
            game_save();
            ai_place(grand_a_brutes.Squad);
            ai_place(grand_a_turret1.Squad);
            if (await this.difficulty_normal())
            {
                ai_place(ledge_brutes_ini1.Squad, 1);
            }
            else
            {
                ai_place(ledge_brutes_ini1.Squad);
            }

            if (await this.difficulty_normal())
            {
                ai_place(ledge_brutes_honor_ini1.Squad, 1);
            }
            else
            {
                ai_place(ledge_brutes_honor_ini1.Squad);
            }

            await sleep_until(async () => (short)ai_living_count(grand_a_prophets) <= 2, 30, 210);
            wake(new ScriptMethodReference(music_07a_02));
            wake(new ScriptMethodReference(sc_grand_a_exit));
        }

        [ScriptMethod(414, Lifecycle.Dormant)]
        public async Task enc_dervish_ledge()
        {
            data_mine_set_mission_segment("enc_ledge_ini");
            if (this.debug)
            {
                print("initialize dervish ledge encounters");
            }

            game_save();
            ai_disposable(council_prophets, true);
            ai_place(ledge_jackal_left.Squad);
            ai_place(ledge_jackal_right.Squad);
            wake(new ScriptMethodReference(ai_dervish_ledge_orders));
            await sleep_until(async () => volume_test_objects(tv_dervish_ledge_fr, players()));
            await sleep((short)random_range(15, 45));
            await sleep_until(async () => volume_test_objects(tv_dervish_ledge_bk, players()) || (short)ai_living_count(dervish_ledge_prophets) <= 2, 10);
            data_mine_set_mission_segment("enc_ledge_lift");
            game_save();
            wake(new ScriptMethodReference(ai_ledge_lift));
            wake(new ScriptMethodReference(sc_ledge_down));
            await sleep_until(async () => volume_test_objects(tv_dervish_ledge_lower, players()));
            game_save();
            data_mine_set_mission_segment("enc_ledge_lower");
            wake(new ScriptMethodReference(ai_ledge_lower));
            this.g_music_07a_02 = false;
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task enc_corridors_a()
        {
            data_mine_set_mission_segment("enc_high_hall_a");
            if (this.debug)
            {
                print("initialize corridor a encounters");
            }

            ai_disposable(grand_a_prophets, true);
            ai_disposable(dervish_ledge_prophets, true);
            wake(new ScriptMethodReference(corridor_a_activate));
            wake(new ScriptMethodReference(ai_hall_a_prophets));
            wake(new ScriptMethodReference(sc_corridor_a_amb));
            await sleep_until(async () => volume_test_objects(tv_hall_b, players()), 5);
            data_mine_set_mission_segment("enc_high_hall_b");
            wake(new ScriptMethodReference(sc_jail_info));
            ai_place(hall_b_brutes1.Squad);
            ai_place(hall_b_grunts1.Squad);
            ai_place(hall_b_grunts_bk1.Squad);
            wake(new ScriptMethodReference(sc_room_a_lift));
            await sleep_until(async () => volume_test_objects(tv_room_a, players()), 1);
            data_mine_set_mission_segment("enc_room_a");
            game_save();
            device_operates_automatically_set(room_a_door1.Entity, true);
            wake(new ScriptMethodReference(ai_room_a));
            wake(new ScriptMethodReference(room_a_door));
            await sleep_until(async () => volume_test_objects(tv_room_a_bot, players()), 10);
            wake(new ScriptMethodReference(sc_room_a_down));
            await sleep_until(async () => volume_test_objects(tv_room_a_tube, players()));
            cs_run_command_script(room_a_prophets, new ScriptMethodReference(cs_room_a_to_jail));
            ai_migrate(room_a_prophets, jail_trash.Squad);
            await this.erase_cortana();
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task enc_jails()
        {
            data_mine_set_mission_segment("enc_jail_ini");
            if (this.debug)
            {
                print("initialize jails encounters");
            }

            ai_disposable(hall_a_prophets, true);
            ai_disposable(hall_b_prophets, true);
            device_set_power(room_a_lift.Entity, 0F);
            device_set_position(room_a_lift_effect.Entity, 1F);
            device_set_position(jail_down.Entity, 1F);
            ai_erase(room_a_tube_fodder.Squad);
            ai_place(jail_brutes_ini1.Squad);
            ai_place(jail_grunts_ini1.Squad);
            ai_place(jail_jackals_ini1.Squad);
            wake(new ScriptMethodReference(music_07a_03));
            wake(new ScriptMethodReference(ai_prophets_ini_active));
            wake(new ScriptMethodReference(sc_jail_down));
            await sleep_until(async () => (short)ai_living_count(jail_brutes_ini1.Squad) <= 0 && (short)ai_living_count(jail_jackals_ini1.Squad) <= 0);
            game_save();
            if (this.g_jail_prophets_ini_active)
            {
                await sleep_until(async () => (short)ai_living_count(jail_prophets) <= 0);
            }
            else
            {
                sleep_forever(new ScriptMethodReference(ai_prophets_ini_active));
            }

            if ((short)random_range(0, 2) == 0)
            {
                wake(new ScriptMethodReference(ai_jail_a));
            }
            else
            {
                wake(new ScriptMethodReference(ai_jail_b));
            }

            await sleep_until(async () => this.g_jail_a_finished || this.g_jail_b_finished);
            await this.ai_jail_spawner();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            if (this.g_jail_a_finished)
            {
                wake(new ScriptMethodReference(ai_jail_b));
            }
            else
            {
                wake(new ScriptMethodReference(ai_jail_a));
            }

            await sleep_until(async () => this.g_jail_a_finished && this.g_jail_b_finished);
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            wake(new ScriptMethodReference(sc_jail_exit));
            await this.ai_jail_spawner();
            await sleep(1);
            wake(new ScriptMethodReference(ai_jail_down_lift));
            await sleep_until(async () => this.g_jail_round_lift_spawned);
            await sleep(30);
            await sleep_until(async () => !(volume_test_objects_all(tv_jail_top, players())) && !(volume_test_objects_all(tv_jail_mid, players())) && !(volume_test_objects_all(tv_jail_bot, players())));
            await this.erase_cortana();
            this.g_music_07a_03 = false;
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task enc_corridors_b()
        {
            data_mine_set_mission_segment("enc_corridors_b");
            if (this.debug)
            {
                print("initialize corridor b encounters");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            this.g_jail_exit_reminder = true;
            if (!(this.g_jail_a_finished) && !(this.g_jail_b_finished))
            {
                object_destroy(jail_down.Entity);
                object_create(jail_up);
                object_create(room_b_lift);
                device_set_position(room_b_lift_effect.Entity, 1F);
                await sleep(1);
                ai_place(room_b_marines1.Squad);
            }

            ai_disposable(jail_prophets, true);
            wake(new ScriptMethodReference(sc_room_b));
            wake(new ScriptMethodReference(grand_b_door));
            wake(new ScriptMethodReference(objective_truth_set));
            ai_set_orders(marines, marines_corr_b);
            await sleep_until(async () => volume_test_objects(tv_room_b_start, players()), 5);
            pvs_clear();
            ai_place(room_b_elites1.Squad);
            wake(new ScriptMethodReference(ai_room_b_buggers));
            await sleep_until(async () => volume_test_objects(tv_hall_c, players()));
            game_save();
            cs_run_command_script(marines, new ScriptMethodReference(cs_abort));
            wake(new ScriptMethodReference(ai_corridor_b));
            wake(new ScriptMethodReference(marine_migration));
            await sleep_until(async () => volume_test_objects(tv_hall_c_bk, players()), 1);
            ai_disposable(room_b_prophets, true);
            ai_disposable(room_b_covenant, true);
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            if ((short)ai_living_count(corridor_b_prophets) <= 4)
            {
                ai_place(hall_c_bugger_reins.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_hall_d, players()));
            wake(new ScriptMethodReference(sc_corridor_b_exit));
            ai_place(hall_d_elites1.Squad);
            ai_place(hall_d_brutes1.Squad);
            if ((float)ai_living_count(corridor_b_prophets) + (float)ai_living_count(corridor_b_covenant) <= 8F)
            {
                ai_place(hall_d_jackals_bk1.Squad);
            }

            await sleep(1);
            if ((float)ai_living_count(corridor_b_prophets) + (float)ai_living_count(corridor_b_covenant) <= 8F)
            {
                ai_place(hall_d_jackals_fr1.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_grand_b, players()));
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            game_save();
            wake(new ScriptMethodReference(music_07a_04));
            ai_place(grand_b_hunter_a1.Squad);
            ai_place(grand_b_hunter_b1.Squad);
            ai_disposable(corridor_b_prophets, true);
            ai_disposable(corridor_b_covenant, true);
            objects_predict(ai_actors(ext_a_prophets));
            objects_predict(ai_actors(ext_a_covenant));
            wake(new ScriptMethodReference(sc_network));
        }

        [ScriptMethod(418, Lifecycle.Dormant)]
        public async Task enc_tower_a_ext()
        {
            data_mine_set_mission_segment("enc_tower_a_exterior");
            if (this.debug)
            {
                print("initialize tower a exterior encounters");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            if (await this.difficulty_legendary())
            {
                wake(new ScriptMethodReference(ice_cream_angry));
            }

            ai_disposable(corridor_b_prophets, true);
            ai_disposable(corridor_b_covenant, true);
            wake(new ScriptMethodReference(ai_ext_a_snipers));
            ai_place(ext_a_watch_brutes1.Squad);
            ai_place(ext_a_watch_elites.Squad);
            wake(new ScriptMethodReference(ai_ext_a_hunters));
            wake(new ScriptMethodReference(ai_ext_a_elite_ini));
            wake(new ScriptMethodReference(ai_ext_a_brute_ini));
            wake(new ScriptMethodReference(ai_ext_a_prophet_migrate));
            await sleep_until(async () => volume_test_objects(tv_ext_a_mid, players()) || (float)ai_living_count(ext_a_prophets) + (float)ai_living_count(ext_a_covenant) <= 6F, 10);
            ai_disposable(grand_b_hunters, true);
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            wake(new ScriptMethodReference(ai_ext_a_fliers));
            await sleep_until(async () => volume_test_objects(tv_ext_a_exit, players()));
            this.g_ext_a_fliers = true;
            ai_place(ext_a_brute_bk_door1.Squad);
            await sleep_until(async () => volume_test_objects(tv_tower_a_ramp, players()), 10);
            this.g_music_07a_04_alt = true;
            wake(new ScriptMethodReference(sc_truth_a));
            await sleep_until(async () => volume_test_objects(tv_garden_a_tram, players()) || (short)ai_living_count(ext_a_brutes_bk1.Squad) <= 0 && (short)ai_living_count(ext_a_buggers_bk1.Squad) <= 0, 10);
            await sleep(30);
            wake(new ScriptMethodReference(sc_in_amber_clad));
            wake(new ScriptMethodReference(tram_a_no_save));
            await sleep(60);
            if (!(volume_test_objects(tv_tram_a_no_save, players())))
            {
                game_save();
            }

            wake(new ScriptMethodReference(music_07a_05));
            await sleep_until(async () => this.g_sc_ioc_finished);
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }
        }

        [ScriptMethod(419, Lifecycle.Dormant)]
        public async Task enc_gardens_a()
        {
            data_mine_set_mission_segment("enc_gardens_a");
            if (this.debug)
            {
                print("initialize hanging gardens a encounters");
            }

            game_save();
            await this.erase_cortana();
            ai_disposable(ext_a_prophets, true);
            ai_disposable(ext_a_covenant, true);
            this.g_marine_mig_garden_a = true;
            this.g_ioc_reminder = true;
            wake(new ScriptMethodReference(ai_garden_a_ini));
            await sleep_until(async () => volume_test_objects(tv_garden_a_fr_suck, players()) || volume_test_objects(tv_garden_a_fr, players()), 5);
            if (this.debug)
            {
                print("garden a fr");
            }

            ai_place(garden_a_brute_a1.Squad);
            ai_place(garden_a_brute_b1.Squad);
            ai_place(garden_a_brute_c1.Squad);
            ai_place(garden_a_elite_a1.Squad);
            ai_place(garden_a_elite_b1.Squad);
            ai_place(garden_a_elite_c1.Squad);
            await sleep_until(async () => volume_test_objects(tv_garden_a_mid, players()));
            if (this.debug)
            {
                print("garden a mid");
            }

            game_save();
            this.g_music_07a_05 = false;
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            wake(new ScriptMethodReference(ai_garden_a_rangers));
            await sleep_until(async () => volume_test_objects(tv_garden_a_bk, players()));
            if (this.debug)
            {
                print("garden a bk");
            }

            game_save();
            wake(new ScriptMethodReference(garden_a_tram_b_on));
            ai_place(garden_a_elites_bk1.Squad);
            ai_place(garden_a_grunts_bk.Squad, (short)pin(8F - (float)ai_living_count(all_enemies), 0F, 2F));
            await sleep(1);
            ai_place(garden_a_brutes_bk.Squad);
            ai_place(garden_a_jackals_bk.Squad, (short)pin(8F - (float)ai_living_count(all_enemies), 0F, 2F));
        }

        [ScriptMethod(420, Lifecycle.Dormant)]
        public async Task ai_midtower_ini()
        {
            await sleep_until(async () => device_get_position(midtower_ent_door.Entity) > 0F, 10);
            ai_place(midtower_buggers_hall.Squad);
        }

        [ScriptMethod(421, Lifecycle.Dormant)]
        public async Task enc_mid_tower()
        {
            data_mine_set_mission_segment("enc_mid_tower");
            if (this.debug)
            {
                print("initialize midspan tower encounters");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_disposable(garden_a_prophet, true);
            ai_disposable(garden_a_covenant, true);
            this.g_marine_mig_midtower = true;
            wake(new ScriptMethodReference(sc_drive_elites));
            wake(new ScriptMethodReference(ai_midtower_ini));
            await sleep_until(async () => volume_test_objects(tv_mid_tower_room, players()));
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            game_save();
            ai_place(midtower_elites1.Squad);
            ai_place(midtower_buggers_ini.Squad);
            wake(new ScriptMethodReference(ai_midtower_buggers_rein));
            wake(new ScriptMethodReference(ai_midtower_cov_rein));
            wake(new ScriptMethodReference(ai_midtower_prophets));
            wake(new ScriptMethodReference(music_07a_06));
        }

        [ScriptMethod(422, Lifecycle.Dormant)]
        public async Task enc_gardens_b()
        {
            data_mine_set_mission_segment("enc_gardens_b");
            if (this.debug)
            {
                print("initialize hanging gardens b encounters");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            this.g_music_07a_06 = true;
            ai_disposable(midtower_prophets, true);
            ai_disposable(midtower_covenant, true);
            wake(new ScriptMethodReference(sc_gardens_b));
            await sleep_until(async () => volume_test_objects(tv_garden_b_fr, players()));
            if (this.debug)
            {
                print("garden b fr");
            }

            game_save();
            ai_place(garden_b_grunt_a.Squad);
            ai_place(garden_b_grunt_b.Squad);
            ai_place(garden_b_grunt_c.Squad);
            ai_place(garden_b_brute_ini.Squad);
            await sleep_until(async () => volume_test_objects(tv_garden_b_mid, players()));
            if (this.debug)
            {
                print("garden b mid");
            }

            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            game_save();
            await sleep_until(async () => volume_test_objects(tv_garden_b_bk, players()));
            if (this.debug)
            {
                print("garden b bk");
            }

            game_save();
            wake(new ScriptMethodReference(tram_d_no_save));
        }

        [ScriptMethod(423, Lifecycle.Dormant)]
        public async Task enc_tower_b_ext()
        {
            data_mine_set_mission_segment("enc_tower_b_exterior");
            if (this.debug)
            {
                print("initialize tower b exterior encounters");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_disposable(garden_b_prophet, true);
            ai_disposable(garden_b_covenant, true);
            this.g_marine_mig_ext_b = true;
            wake(new ScriptMethodReference(objective_truth_clear));
            wake(new ScriptMethodReference(objective_phantom_set));
            ai_place(ext_b_brute_ramp1.Squad);
            await sleep_until(async () => volume_test_objects(tv_ext_b, players()), 5);
            if (this.debug)
            {
                print("initial enemies");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_place(ext_b_elite_a1.Squad);
            ai_place(ext_b_brute_a1.Squad);
            ai_place(ext_b_grunts_b1.Squad);
            ai_place(ext_b_brutes_b1.Squad);
            ai_place(ext_b_grunts_low1.Squad);
            ai_place(ext_b_brutes_low1.Squad);
            ai_place(ext_b_jackal_a1.Squad);
            await sleep(1);
            wake(new ScriptMethodReference(ai_ext_b_reins));
            wake(new ScriptMethodReference(ai_ext_b_dump));
            await sleep_until(async () => volume_test_objects(tv_ext_b_lt, players()));
            this.g_ext_b_dump = true;
            if (this.debug)
            {
                print("placing left covenant");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_place(ext_b_grunts_lt1.Squad);
            ai_place(ext_b_elites_stealth.Squad);
        }

        [ScriptMethod(424, Lifecycle.Dormant)]
        public async Task enc_mausoleum_ext()
        {
            data_mine_set_mission_segment("enc_maus_grand");
            if (this.debug)
            {
                print("initialize mausoleum exterior encounters");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_disposable(ext_b_prophets, true);
            ai_disposable(ext_b_covenant, true);
            this.g_marine_mig_maus = true;
            wake(new ScriptMethodReference(maus_door));
            ai_place(maus_hall_grunts1.Squad);
            ai_place(maus_hall_elites_stealth1.Squad);
            await sleep_until(async () => volume_test_objects(tv_maus_room, players()), 5);
            data_mine_set_mission_segment("enc_maus_room");
            game_save();
            cs_run_command_script(covenant1, new ScriptMethodReference(cs_abort));
            ai_set_orders(maus_hall_covenant, maus_room_cov_follow);
            this.g_marine_mig_maus_room = true;
            wake(new ScriptMethodReference(ai_maus_room_ini));
            await sleep_until(async () => volume_test_objects(tv_maus_room_bk, players()), 10);
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_place(maus_room_brute_bk1.Squad);
            ai_place(maus_room_jackal_bk_lt1.Squad);
            ai_place(maus_room_jackal_bk_rt1.Squad);
            ai_set_orders(maus_hall_covenant, maus_room_cov_follow);
            ai_set_orders(maus_room_covenant, maus_room_cov_follow);
            await sleep_until(async () => volume_test_objects(tv_maus_bridge, players()), 5);
            data_mine_set_mission_segment("enc_maus_bridge");
            game_save();
            await this.erase_cortana();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_set_orders(maus_hall_covenant, maus_bridge_cov_screw);
            ai_set_orders(maus_room_prophet, maus_bridge_prophet_screw);
            ai_set_orders(maus_room_covenant, maus_bridge_cov_screw);
            sleep_forever(new ScriptMethodReference(ai_maus_room_ini));
            ai_disposable(maus_hall_covenant, true);
            wake(new ScriptMethodReference(ai_maus_bridge_ini));
            wake(new ScriptMethodReference(sc_catch_truth));
            await sleep_until(async () => volume_test_objects(tv_maus_bridge_fr, players()), 10);
            this.g_maus_bridge_fr = true;
            await sleep_until(async () => volume_test_objects(tv_maus_bridge_mid, players()), 10);
            game_save();
            if (this.debug)
            {
                print("bridge reinforcements wave 1");
            }

            ai_place(maus_bridge_elite_rein.Squad, (short)pin(12F - (float)ai_living_count(all_enemies), 1F, 2F));
            await sleep(1);
            ai_place(maus_bridge_grunt_rein.Squad, (short)pin(10F - (float)ai_living_count(all_enemies), 0F, 4F));
            await sleep(1);
            ai_place(maus_bridge_buggers_ini1.Squad, (short)pin(6F - (float)ai_living_count(all_enemies), 2F, 5F));
            ai_set_orders(maus_bridge_buggers_ini1.Squad, maus_bridge_buggers_rein);
            await sleep_until(async () => volume_test_objects(tv_maus_bridge_bk, players()), 10);
            if (this.debug)
            {
                print("bridge reinforcements wave 2");
            }

            game_save();
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_place(maus_bridge_grunt_rein_b1.Squad, (short)pin(8F - (float)ai_living_count(all_enemies), 0F, 4F));
            ai_place(maus_bridge_hunters1.Squad);
        }

        [ScriptMethod(425, Lifecycle.Dormant)]
        public async Task enc_mausoleum()
        {
            data_mine_set_mission_segment("enc_mausoleum");
            if (this.debug)
            {
                print("initialize mausoleum encounters");
            }

            game_save();
            kill_volume_disable(kill_maus);
            this.g_marine_mig_maus_int = true;
            if ((short)ai_living_count(marines) <= 3)
            {
                ai_renew(marines);
            }

            ai_disposable(maus_room_prophet, true);
            ai_disposable(maus_room_covenant, true);
            ai_disposable(maus_bridge_prophets, true);
            ai_disposable(maus_bridge_covenant, true);
            ai_set_orders(maus_bridge_covenant, maus_ent_collapse);
            ai_set_orders(maus_bridge_prophets, maus_ent_collapse);
            ai_place(maus_inner_elites_ini1.Squad);
            ai_place(maus_inner_brutes_ini1.Squad);
            ai_place(maus_inner_buggers_lt.Squad);
            wake(new ScriptMethodReference(music_07a_07));
            wake(new ScriptMethodReference(sc_maus_interior));
            await sleep(120);
            kill_volume_enable(kill_maus);
            await sleep_until(async () => volume_test_objects(tv_maus_inner_mid, players()) || (short)ai_living_count(maus_inner_covenant) <= 1);
            game_save();
            await sleep(5);
            ai_place(maus_inner_hunters_ini.Squad);
            await sleep(1);
            wake(new ScriptMethodReference(ai_maus_inner_brute_reins));
            await sleep_until(async () => (short)ai_living_count(maus_inner_prophets) <= 0 && (short)ai_living_count(maus_inner_covenant) <= 0, 30, 30 * 60 * 10);
            game_save();
            this.g_maus_inner_order_trans = true;
            await this.sc_maus_breather();
            data_mine_set_mission_segment("enc_maus_midpoint");
            game_save();
            wake(new ScriptMethodReference(music_07a_08));
            wake(new ScriptMethodReference(ai_maus_inner_elites_final));
            this.g_music_07a_07 = false;
            this.g_music_07a_08 = true;
            await sleep(60);
            game_save();
            wake(new ScriptMethodReference(sc_maus_exit));
        }

        [ScriptMethod(426, Lifecycle.Static)]
        public async Task cutscenes()
        {
            await this.x08();
            await sleep(30);
            await this.c07_intro();
            await sleep(30);
            await this.c07_intra1();
        }

        [ScriptMethod(427, Lifecycle.Dormant)]
        public async Task mission_highcharity()
        {
            await this.cinematic_snap_to_white();
            object_hide(holo_generator.Entity, true);
            switch_bsp(0);
            if (this.g_play_cinematics == true)
            {
                sound_suppress_ambience_update_on_revert();
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        print("x08");
                    }

                    await this.x08();
                }

                await this.cinematic_skip_stop();
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        print("c07_intro");
                    }

                    await this.c07_intro();
                }

                await this.cinematic_skip_stop();
            }

            await sleep(2);
            object_teleport(await this.player0(), player0_start);
            object_teleport(await this.player1(), player1_start);
            wake(new ScriptMethodReference(enc_council_chamber));
            wake(new ScriptMethodReference(bullshit));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(chapter_job));
            wake(new ScriptMethodReference(objective_locate_set));
            await sleep_until(async () => volume_test_objects(tv_dervish_ledge, players()), 5);
            wake(new ScriptMethodReference(enc_dervish_ledge));
            await sleep_until(async () => volume_test_objects(tv_corridors_a, players()), 5);
            wake(new ScriptMethodReference(enc_corridors_a));
            await sleep_until(async () => volume_test_objects(tv_jails, players()), 5);
            wake(new ScriptMethodReference(enc_jails));
            await sleep_until(async () => volume_test_objects(tv_room_a_tube, players()), 5);
            wake(new ScriptMethodReference(enc_corridors_b));
            await sleep_until(async () => volume_test_objects(tv_tower_a_ext, players()), 5);
            wake(new ScriptMethodReference(enc_tower_a_ext));
            await sleep_until(async () => volume_test_objects(tv_gardens_a, players()), 5);
            wake(new ScriptMethodReference(enc_gardens_a));
            await sleep_until(async () => volume_test_objects(tv_mid_tower, players()), 5);
            wake(new ScriptMethodReference(enc_mid_tower));
            await sleep_until(async () => volume_test_objects(tv_gardens_b, players()), 5);
            wake(new ScriptMethodReference(enc_gardens_b));
            await sleep_until(async () => volume_test_objects(tv_tower_b_ext, players()), 5);
            wake(new ScriptMethodReference(enc_tower_b_ext));
            await sleep_until(async () => volume_test_objects(tv_mausoleum_ext, players()), 5);
            wake(new ScriptMethodReference(enc_mausoleum_ext));
            await sleep_until(async () => volume_test_objects(tv_mausoleum, players()), 5);
            wake(new ScriptMethodReference(enc_mausoleum));
        }

        [ScriptMethod(428, Lifecycle.Static)]
        public async Task start()
        {
            wake(new ScriptMethodReference(mission_highcharity));
        }

        [ScriptMethod(429, Lifecycle.Startup)]
        public async Task mission_main()
        {
            ai_allegiance(player, human);
            ai_allegiance(human, player);
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(430, Lifecycle.Dormant)]
        public async Task x08_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3847226330U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3847226330U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\fp_needler\\fp_needler", 3801481504U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\fp_needler\\fp_needler", 3801481504U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3848799218U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3849126903U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner\\high_banner", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3850568717U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3851551772U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\holo_generator\\holo_generator", 3852338216U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3853124660U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3853255734U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 5);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\gravemind"), 0, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3855156307U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3855156307U), 1);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\tentacle_capture_driven", 3856598121U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\tentacle_capture_driven", 3856598121U), 1);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\tentacle_capture_masterchief", 3856860269U), 0);
        }

        [ScriptMethod(431, Lifecycle.Dormant)]
        public async Task x08_02_predict()
        {
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3855156307U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3855156307U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\tentacle_capture_masterchief", 3856860269U), 0);
        }

        [ScriptMethod(432, Lifecycle.Dormant)]
        public async Task x08_03_predict()
        {
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3856925806U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3856925806U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\tentacle_capture_driven", 3856598121U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_driven\\tentacle_capture_driven", 3856598121U), 1);
            await sleep(145);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3856925806U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3856925806U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture_masterchief\\tentacle_capture_masterchief", 3856860269U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3855156307U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3855156307U), 1);
        }

        [ScriptMethod(433, Lifecycle.Dormant)]
        public async Task x08_04_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(434, Lifecycle.Dormant)]
        public async Task x08_05_predict()
        {
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\floodregret\\floodregret", 3859088527U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\floodregret\\floodregret", 3859088527U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\floodregret\\floodregret", 3859088527U), 2);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\monitor_flood_infected\\monitor_flood_infected", 3860792489U), 0);
        }

        [ScriptMethod(435, Lifecycle.Dormant)]
        public async Task x08_06a_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(436, Lifecycle.Dormant)]
        public async Task x08_06b_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(437, Lifecycle.Dormant)]
        public async Task x08_06c_predict()
        {
            await sleep(512);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3855156307U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\gravemind", 3855156307U), 1);
        }

        [ScriptMethod(438, Lifecycle.Dormant)]
        public async Task x08_07_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(439, Lifecycle.Dormant)]
        public async Task x08_08_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(440, Lifecycle.Dormant)]
        public async Task x08_09_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(441, Lifecycle.Dormant)]
        public async Task x08_10_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(442, Lifecycle.Dormant)]
        public async Task x08_11_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(443, Lifecycle.Dormant)]
        public async Task _07_intro_01_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3861578933U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3861644470U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 7);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3862168766U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3862496451U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3862889673U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3863086284U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3863741654U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\spacestation\\spacestation", 3786539068U), 0);
        }

        [ScriptMethod(444, Lifecycle.Dormant)]
        public async Task _07_intro_02_predict()
        {
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3850568717U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3827696304U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3863807191U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_dervish_lift_up\\high_dervish_lift_up", 3864855783U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 3865117931U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_planter\\high_planter", 3866297597U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_holo_ped\\high_holo_ped", 3867084041U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 3867149578U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3868853540U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3868853540U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3868853540U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3868853540U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt_scenery\\grunt_scenery", 3868853540U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 7);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3870491965U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3853255734U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner_small\\high_banner_small", 3873506667U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3873637741U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 3873703278U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3848799218U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            await sleep(25);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 1);
            await sleep(24);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\ambient_life\\seagull\\seagull", 3873899889U), 0);
            await sleep(21);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 3);
            await sleep(54);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal_scenery\\jackal_scenery", 3867149578U), 0);
            await sleep(75);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_planter\\high_planter", 3866297597U), 0);
            await sleep(17);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 3873703278U), 0);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3874227574U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
        }

        [ScriptMethod(445, Lifecycle.Dormant)]
        public async Task _07_intro_03_predict()
        {
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3850568717U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3873637741U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3849126903U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3853124660U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner\\high_banner", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3851551772U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\holo_cam\\holo_cam", 3874555259U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            await sleep(176);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 2);
            await sleep(166);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 41);
            await sleep(167);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\holo_cam\\holo_cam", 3874555259U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3850568717U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3849126903U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3853124660U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3873637741U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_holo_ped\\high_holo_ped", 3867084041U), 0);
        }

        [ScriptMethod(446, Lifecycle.Dormant)]
        public async Task _07_intro_04_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            await sleep(53);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\holo_cam\\holo_cam", 3874555259U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3875407240U), 0);
            await sleep(37);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3850568717U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3849126903U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3853124660U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3873637741U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_holo_ped\\high_holo_ped", 3867084041U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3873637741U), 0);
            await sleep(21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 1);
            await sleep(15);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner\\high_banner", 3849651199U), 0);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 19);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            await sleep(73);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3851551772U), 0);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3850568717U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_banner\\high_banner", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null\\null", 3853124660U), 0);
            await sleep(47);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 5);
            await sleep(11);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3850568717U), 0);
            await sleep(22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 1);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\pedestal\\pedestal", 3851551772U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3853255734U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 41);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3875407240U), 0);
            await sleep(23);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 1);
            await sleep(17);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 2);
        }

        [ScriptMethod(447, Lifecycle.Dormant)]
        public async Task _07_intra1_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3849126903U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3847226330U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3847226330U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\fp_needler\\fp_needler", 3801481504U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\fp_needler\\fp_needler", 3801481504U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3817800217U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\holo_generator\\holo_generator", 3852338216U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3881567718U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3881567718U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3817800217U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3875407240U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3882092014U), 0);
            await sleep(16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3882943995U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3887662659U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3887662659U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3853255734U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3889170010U), 2);
            await sleep(110);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3863807191U), 0);
            await sleep(33);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            await sleep(74);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            await sleep(28);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 60);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3889170010U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3861644470U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3802792244U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\flak_cannon\\flak_cannon", 3889628769U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3787325512U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\brute_shot\\brute_shot", 3890480750U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3861578933U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3893888674U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3893888674U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3895002803U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3895854784U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3895854784U), 1);
            await sleep(62);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 4, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 4);
            await sleep(58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 12);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3883402754U), 60);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3882092014U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3853255734U), 0);
        }

        [ScriptMethod(448, Lifecycle.Dormant)]
        public async Task _07_intra1_02_predict()
        {
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3896444617U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3874227574U), 0);
            await sleep(72);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 2);
            await sleep(103);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3882943995U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3848799218U), 0);
            await sleep(100);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3896444617U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3896444617U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3882092014U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 1);
            await sleep(71);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 2);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3896444617U), 1);
        }

        [ScriptMethod(449, Lifecycle.Dormant)]
        public async Task _07_intra1_03_predict()
        {
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3882943995U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3861578933U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3893888674U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3893888674U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3895002803U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3895854784U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3895854784U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3848799218U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 3);
            await sleep(100);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3896444617U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3882092014U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 2);
            await sleep(51);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3896444617U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3863807191U), 0);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3861578933U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3895854784U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3895854784U), 1);
            await sleep(16);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3863807191U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3848799218U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            await sleep(17);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3861185711U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3861578933U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3893888674U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\hunter\\hunter", 3893888674U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3891005046U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3895002803U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3871409483U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3895854784U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3895854784U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3853255734U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3896444617U), 2);
            await sleep(27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            await sleep(18);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 2);
            await sleep(49);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3882092014U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 1);
        }

        [ScriptMethod(450, Lifecycle.Dormant)]
        public async Task _07_intra1_04_predict()
        {
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 34);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3874227574U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3848799218U), 0);
            await sleep(43);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3882288625U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3882878458U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 2);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3875603851U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3880388052U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 1);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3882092014U), 0);
            await sleep(67);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 41);
            await sleep(147);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3871475020U), 41);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\cooke_cutter_1x1\\cooke_cutter_1x1", 3882092014U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 0);
            await sleep(111);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3880977885U), 2);
        }

        [ScriptMethod(451, Lifecycle.Static)]
        public async Task test_halls()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(1);
            print("teleporting players...");
            object_teleport(await this.player0(), halls);
            fade_in(0F, 0F, 0F, 60);
            await sleep(10);
            player_enable_input(true);
        }

        [ScriptMethod(452, Lifecycle.Static)]
        public async Task test_jails()
        {
            switch_bsp(2);
            await sleep(1);
            object_teleport(await this.player0(), jails0_tele);
            object_teleport(await this.player1(), jails1_tele);
            await sleep_until(async () => volume_test_objects(tv_jails, players()), 5);
            wake(new ScriptMethodReference(enc_jails));
        }

        [ScriptMethod(453, Lifecycle.Static)]
        public async Task test_corridors_b()
        {
            switch_bsp(2);
            await sleep(1);
            object_teleport(await this.player0(), corrb0_tele);
            object_teleport(await this.player1(), corrb1_tele);
            await sleep(90);
            wake(new ScriptMethodReference(enc_corridors_b));
            await sleep_until(async () => volume_test_objects(tv_tower_a_ext, players()), 5);
            wake(new ScriptMethodReference(enc_tower_a_ext));
            await sleep_until(async () => volume_test_objects(tv_gardens_a, players()), 5);
            wake(new ScriptMethodReference(enc_gardens_a));
            await sleep_until(async () => volume_test_objects(tv_mid_tower, players()), 5);
            wake(new ScriptMethodReference(enc_mid_tower));
            await sleep_until(async () => volume_test_objects(tv_gardens_b, players()), 5);
            wake(new ScriptMethodReference(enc_gardens_b));
            await sleep_until(async () => volume_test_objects(tv_tower_b_ext, players()), 5);
            wake(new ScriptMethodReference(enc_tower_b_ext));
            await sleep_until(async () => volume_test_objects(tv_mausoleum_ext, players()), 5);
            wake(new ScriptMethodReference(enc_mausoleum_ext));
            await sleep_until(async () => volume_test_objects(tv_mausoleum, players()), 5);
            wake(new ScriptMethodReference(enc_mausoleum));
        }

        [ScriptMethod(454, Lifecycle.Static)]
        public async Task test_gardens()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(3);
            print("teleporting players...");
            object_teleport(await this.player0(), garden);
            fade_in(0F, 0F, 0F, 60);
            await sleep(10);
            player_enable_input(true);
        }

        [ScriptMethod(455, Lifecycle.Static)]
        public async Task test_mausoleum()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(4);
            print("teleporting players...");
            object_teleport(await this.player0(), mausoleum);
            fade_in(0F, 0F, 0F, 60);
            await sleep(10);
            player_enable_input(true);
        }
    }
}